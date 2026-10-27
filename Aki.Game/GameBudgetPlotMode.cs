using System;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02001CAC RID: 7340
public class GameBudgetPlotMode : GameBudgetMode
{
	// Token: 0x0600DD9C RID: 56732 RVA: 0x0033D499 File Offset: 0x0033B699
	public GameBudgetPlotMode() : base("EGameBudgetMode.Plot", EGameBudgetMode.Plot)
	{
	}

	// Token: 0x0600DD9D RID: 56733 RVA: 0x0033D4A8 File Offset: 0x0033B6A8
	public override void OnEnterMode()
	{
		GameBudgetInterfaceController.Instance.SetCenterRole(Global.BaseCharacter);
		SequenceCamera sequenceCamera = CameraModel.Instance.MainModel.SequenceCamera;
		BP_CineCamera_C bp_CineCamera_C;
		if (sequenceCamera == null)
		{
			bp_CineCamera_C = null;
		}
		else
		{
			SequenceCameraDisplayComponent displayComponent = sequenceCamera.DisplayComponent;
			bp_CineCamera_C = ((displayComponent != null) ? displayComponent.CineCamera : null);
		}
		BP_CineCamera_C bp_CineCamera_C2 = bp_CineCamera_C;
		if (bp_CineCamera_C2 != null)
		{
			GameBudgetInterfaceController.Instance.SequenceCamera = bp_CineCamera_C2;
			UKuroGameBudgetAllocatorCSharpInterface.AddAssistantActor(bp_CineCamera_C2);
		}
	}

	// Token: 0x0600DD9E RID: 56734 RVA: 0x0033D500 File Offset: 0x0033B700
	public override void OnExitMode()
	{
		AActor sequenceCamera = GameBudgetInterfaceController.Instance.SequenceCamera;
		if (sequenceCamera != null)
		{
			UKuroGameBudgetAllocatorCSharpInterface.RemoveAssistantActor(sequenceCamera);
			GameBudgetInterfaceController.Instance.SequenceCamera = null;
		}
	}
}
