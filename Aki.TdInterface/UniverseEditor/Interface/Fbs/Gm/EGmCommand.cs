using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004A8B RID: 19083
	public enum EGmCommand : byte
	{
		// Token: 0x0400D184 RID: 53636
		SkipToLevelPlayNode,
		// Token: 0x0400D185 RID: 53637
		FinishCurrentLevelPlayNode,
		// Token: 0x0400D186 RID: 53638
		TeleportToCurLevelPlayTrackPosition,
		// Token: 0x0400D187 RID: 53639
		GmSetLevelPlaySwitchForce,
		// Token: 0x0400D188 RID: 53640
		GmSetLevelPlayUpdateForce,
		// Token: 0x0400D189 RID: 53641
		TeleportToLevelPlayCenter,
		// Token: 0x0400D18A RID: 53642
		SkipToQuestNode,
		// Token: 0x0400D18B RID: 53643
		FinishCurrentTrackQuestNode,
		// Token: 0x0400D18C RID: 53644
		TeleportToCurQuestTrackPosition,
		// Token: 0x0400D18D RID: 53645
		AcceptQuest,
		// Token: 0x0400D18E RID: 53646
		UnlockQuest,
		// Token: 0x0400D18F RID: 53647
		PlayFlowForGm,
		// Token: 0x0400D190 RID: 53648
		SkipToInstanceDungeonNode,
		// Token: 0x0400D191 RID: 53649
		FinishCurTrackDungeonNode,
		// Token: 0x0400D192 RID: 53650
		TeleportToCurDungeonTrackPosition,
		// Token: 0x0400D193 RID: 53651
		ResetCurrentDungeon,
		// Token: 0x0400D194 RID: 53652
		ExitDungeon,
		// Token: 0x0400D195 RID: 53653
		GmRoguelikeStart,
		// Token: 0x0400D196 RID: 53654
		GmGotoRogueRoom,
		// Token: 0x0400D197 RID: 53655
		UnlockEntityForGm,
		// Token: 0x0400D198 RID: 53656
		TeleportToEntity,
		// Token: 0x0400D199 RID: 53657
		GmTeleportToEntity,
		// Token: 0x0400D19A RID: 53658
		OpenDungeonEntrance,
		// Token: 0x0400D19B RID: 53659
		ShowTipsView,
		// Token: 0x0400D19C RID: 53660
		ShieldGuide,
		// Token: 0x0400D19D RID: 53661
		OpenFunc,
		// Token: 0x0400D19E RID: 53662
		SetTime,
		// Token: 0x0400D19F RID: 53663
		UnlockAllExploreSkill,
		// Token: 0x0400D1A0 RID: 53664
		ActivateTeleport,
		// Token: 0x0400D1A1 RID: 53665
		SetUnopenedAreaPullback,
		// Token: 0x0400D1A2 RID: 53666
		TeleportToPos,
		// Token: 0x0400D1A3 RID: 53667
		TeleportToPosInWorld,
		// Token: 0x0400D1A4 RID: 53668
		UnfreezeInstanceLimit,
		// Token: 0x0400D1A5 RID: 53669
		UpdateSceneRoles,
		// Token: 0x0400D1A6 RID: 53670
		AddAllRole,
		// Token: 0x0400D1A7 RID: 53671
		AddNewRole,
		// Token: 0x0400D1A8 RID: 53672
		SetAllRoleToGraduate,
		// Token: 0x0400D1A9 RID: 53673
		AddAllItem,
		// Token: 0x0400D1AA RID: 53674
		AddItem,
		// Token: 0x0400D1AB RID: 53675
		AddAllPhantom,
		// Token: 0x0400D1AC RID: 53676
		GetAllGraduatedPhantom,
		// Token: 0x0400D1AD RID: 53677
		GetAllGraduatedWeapon,
		// Token: 0x0400D1AE RID: 53678
		SetEquippedWeaponToGraduate,
		// Token: 0x0400D1AF RID: 53679
		EquipGraduatedWeaponToTeam,
		// Token: 0x0400D1B0 RID: 53680
		ExecuteActionList,
		// Token: 0x0400D1B1 RID: 53681
		OpenBackLoginView,
		// Token: 0x0400D1B2 RID: 53682
		SavePlayerData,
		// Token: 0x0400D1B3 RID: 53683
		BrokenRockHotFix,
		// Token: 0x0400D1B4 RID: 53684
		SetVar,
		// Token: 0x0400D1B5 RID: 53685
		GoToNode,
		// Token: 0x0400D1B6 RID: 53686
		CustomText,
		// Token: 0x0400D1B7 RID: 53687
		StartCombatOperationCapture,
		// Token: 0x0400D1B8 RID: 53688
		StopCombatOperationCapture,
		// Token: 0x0400D1B9 RID: 53689
		RecordCombatOperationCaptureCheckpoint,
		// Token: 0x0400D1BA RID: 53690
		StartCombatOperationReplay,
		// Token: 0x0400D1BB RID: 53691
		StopCombatOperationReplay
	}
}
