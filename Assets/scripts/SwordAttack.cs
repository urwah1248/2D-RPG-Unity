using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Collider2D swordColliderRight;
    public Collider2D swordColliderLeft;
    public float damage = 3;
    Vector2 rightAttackOffset;

    private void Start() {
        rightAttackOffset = transform.position;
        swordColliderRight.enabled = false;
        swordColliderLeft.enabled = false;
    }

    public void AttackRight() {
        swordColliderRight.enabled = true;
        // transform.localPosition = rightAttackOffset;
    }

    public void AttackLeft() {
        swordColliderLeft.enabled = true;
        // transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }

    public void StopAttack() {
        swordColliderRight.enabled = false;
        swordColliderLeft.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy") {
            // Deal damage to the enemy
            EnemyScript enemy = other.GetComponent<EnemyScript>();

            if(enemy != null) {
                enemy.Health -= damage;
            }
        }
    }
}
