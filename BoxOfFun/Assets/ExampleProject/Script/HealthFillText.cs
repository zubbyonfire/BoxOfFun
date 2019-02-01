﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Access text mesh pro library
using TMPro;

//We need to add the ScriptableObjectVariable library
using ScriptableObjectVariable;

[RequireComponent(typeof(TextMeshPro))]
public class HealthFillText : MonoBehaviour
{
    [SerializeField]
    private SOInt playerHealth; //How much health the player has

    private TextMeshPro healthText;

    private void Start()
    {
        healthText = GetComponent<TextMeshPro>();

        //Set the player health at the start of the level
        UpdatePlayerHealthText();
    }

    /// <summary>
    /// Update the health text based on the playersHealth (when player is healed or damaged)
    /// </summary>
    public void UpdatePlayerHealthText()
    {
        //If health is greater or equal to 0 display the health value - otherwise display 0%
        if (playerHealth.value >= 100)
        {
            healthText.text = "100" + "%";
        }
        else if (playerHealth.value >= 0)
        {
            healthText.text = "" + playerHealth.value + "%";
        }
        else
        {
            healthText.text = "0" + "%";
        }
    }  
}