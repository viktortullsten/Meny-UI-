using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtenToggler : MonoBehaviour
{


    public void ToggleChanged(bool state)
    {
        GetComponent<Button>().interactable = state;
    }
}


