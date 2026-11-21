using System;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x0200116E RID: 4462
public class GameBudgetPlotMode : GameBudgetMode
{
	// Token: 0x0600B1C0 RID: 45504 RVA: 0x00348E4C File Offset: 0x0034704C
	public GameBudgetPlotMode() : base("EGameBudgetMode.Plot", EGameBudgetMode.Plot)
	{
		base.Active("centerRole", delegate
		{
			GameBudgetController.Instance.ApplyCenterRole(Global.BaseCharacter);
		}, delegate
		{
		});
		base.Active("sequenceCameraAssistant", delegate
		{
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
		}, delegate
		{
			AActor sequenceCamera = GameBudgetInterfaceController.Instance.SequenceCamera;
			if (sequenceCamera != null && sequenceCamera.IsValid())
			{
				UKuroGameBudgetAllocatorCSharpInterface.RemoveAssistantActor(sequenceCamera);
			}
			GameBudgetInterfaceController.Instance.SequenceCamera = null;
		});
	}
}
