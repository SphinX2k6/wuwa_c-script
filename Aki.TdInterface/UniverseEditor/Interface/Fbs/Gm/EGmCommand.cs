using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004623 RID: 17955
	public enum EGmCommand : byte
	{
		// Token: 0x0400C755 RID: 51029
		SkipToLevelPlayNode,
		// Token: 0x0400C756 RID: 51030
		FinishCurrentLevelPlayNode,
		// Token: 0x0400C757 RID: 51031
		TeleportToCurLevelPlayTrackPosition,
		// Token: 0x0400C758 RID: 51032
		GmSetLevelPlaySwitchForce,
		// Token: 0x0400C759 RID: 51033
		GmSetLevelPlayUpdateForce,
		// Token: 0x0400C75A RID: 51034
		TeleportToLevelPlayCenter,
		// Token: 0x0400C75B RID: 51035
		SkipToQuestNode,
		// Token: 0x0400C75C RID: 51036
		FinishCurrentTrackQuestNode,
		// Token: 0x0400C75D RID: 51037
		TeleportToCurQuestTrackPosition,
		// Token: 0x0400C75E RID: 51038
		AcceptQuest,
		// Token: 0x0400C75F RID: 51039
		UnlockQuest,
		// Token: 0x0400C760 RID: 51040
		PlayFlowForGm,
		// Token: 0x0400C761 RID: 51041
		SkipToInstanceDungeonNode,
		// Token: 0x0400C762 RID: 51042
		FinishCurTrackDungeonNode,
		// Token: 0x0400C763 RID: 51043
		TeleportToCurDungeonTrackPosition,
		// Token: 0x0400C764 RID: 51044
		ResetCurrentDungeon,
		// Token: 0x0400C765 RID: 51045
		ExitDungeon,
		// Token: 0x0400C766 RID: 51046
		GmRoguelikeStart,
		// Token: 0x0400C767 RID: 51047
		GmGotoRogueRoom,
		// Token: 0x0400C768 RID: 51048
		UnlockEntityForGm,
		// Token: 0x0400C769 RID: 51049
		TeleportToEntity,
		// Token: 0x0400C76A RID: 51050
		GmTeleportToEntity,
		// Token: 0x0400C76B RID: 51051
		OpenDungeonEntrance,
		// Token: 0x0400C76C RID: 51052
		ShowTipsView,
		// Token: 0x0400C76D RID: 51053
		ShieldGuide,
		// Token: 0x0400C76E RID: 51054
		OpenFunc,
		// Token: 0x0400C76F RID: 51055
		SetTime,
		// Token: 0x0400C770 RID: 51056
		UnlockAllExploreSkill,
		// Token: 0x0400C771 RID: 51057
		ActivateTeleport,
		// Token: 0x0400C772 RID: 51058
		SetUnopenedAreaPullback,
		// Token: 0x0400C773 RID: 51059
		TeleportToPos,
		// Token: 0x0400C774 RID: 51060
		TeleportToPosInWorld,
		// Token: 0x0400C775 RID: 51061
		UnfreezeInstanceLimit,
		// Token: 0x0400C776 RID: 51062
		UpdateSceneRoles,
		// Token: 0x0400C777 RID: 51063
		AddAllRole,
		// Token: 0x0400C778 RID: 51064
		AddNewRole,
		// Token: 0x0400C779 RID: 51065
		SetAllRoleToGraduate,
		// Token: 0x0400C77A RID: 51066
		AddAllItem,
		// Token: 0x0400C77B RID: 51067
		AddItem,
		// Token: 0x0400C77C RID: 51068
		AddAllPhantom,
		// Token: 0x0400C77D RID: 51069
		GetAllGraduatedPhantom,
		// Token: 0x0400C77E RID: 51070
		GetAllGraduatedWeapon,
		// Token: 0x0400C77F RID: 51071
		SetEquippedWeaponToGraduate,
		// Token: 0x0400C780 RID: 51072
		EquipGraduatedWeaponToTeam,
		// Token: 0x0400C781 RID: 51073
		ExecuteActionList,
		// Token: 0x0400C782 RID: 51074
		OpenBackLoginView,
		// Token: 0x0400C783 RID: 51075
		SavePlayerData,
		// Token: 0x0400C784 RID: 51076
		BrokenRockHotFix,
		// Token: 0x0400C785 RID: 51077
		SetVar,
		// Token: 0x0400C786 RID: 51078
		GoToNode,
		// Token: 0x0400C787 RID: 51079
		CustomText,
		// Token: 0x0400C788 RID: 51080
		StartCombatOperationCapture,
		// Token: 0x0400C789 RID: 51081
		StopCombatOperationCapture,
		// Token: 0x0400C78A RID: 51082
		RecordCombatOperationCaptureCheckpoint,
		// Token: 0x0400C78B RID: 51083
		StartCombatOperationReplay,
		// Token: 0x0400C78C RID: 51084
		StopCombatOperationReplay
	}
}
