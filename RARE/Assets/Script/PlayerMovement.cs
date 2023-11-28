using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 0.02f;
    [SerializeField] private Animator animator;
    [HideInInspector] private float horizontalMove = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Animation
        horizontalMove = Input.GetAxisRaw("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));

        // Position
        gameObject.transform.position = new Vector3(gameObject.transform.position.x + (horizontalMove * speed), gameObject.transform.position.y, gameObject.transform.position.z);
        
        // Scales
        if(horizontalMove < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(horizontalMove > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //Remain Same
        }
    }
}
