using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    public GameObject Panel;
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        Animator animator = Panel.GetComponent<Animator>();
        if(animator != null)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                animator.SetBool("onCol", true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        Animator animator = Panel.GetComponent<Animator>();
        if (animator != null)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                animator.SetBool("onCol", false);
            }
        }
    }
}
