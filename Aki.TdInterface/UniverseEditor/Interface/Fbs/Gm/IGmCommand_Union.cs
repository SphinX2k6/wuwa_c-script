using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC5 RID: 19141
	public enum IGmCommand_Union : byte
	{
		// Token: 0x0400D208 RID: 53768
		NONE,
		// Token: 0x0400D209 RID: 53769
		IGmCommand,
		// Token: 0x0400D20A RID: 53770
		ISkipToLevelPlayNode,
		// Token: 0x0400D20B RID: 53771
		IFinishCurrentLevelPlayNode,
		// Token: 0x0400D20C RID: 53772
		ITeleportToCurLevelPlayTrackPosition,
		// Token: 0x0400D20D RID: 53773
		IGmSetLevelPlaySwitchForce,
		// Token: 0x0400D20E RID: 53774
		IGmSetLevelPlayUpdateForce,
		// Token: 0x0400D20F RID: 53775
		ITeleportToLevelPlayCenter,
		// Token: 0x0400D210 RID: 53776
		ISkipToQuestNode,
		// Token: 0x0400D211 RID: 53777
		IFinishCurrentTrackQuestNode,
		// Token: 0x0400D212 RID: 53778
		ITeleportToCurQuestTrackPosition,
		// Token: 0x0400D213 RID: 53779
		IAcceptQuest,
		// Token: 0x0400D214 RID: 53780
		IUnlockQuest,
		// Token: 0x0400D215 RID: 53781
		IPlayFlowForGm,
		// Token: 0x0400D216 RID: 53782
		ISkipToInstanceDungeonNode,
		// Token: 0x0400D217 RID: 53783
		IFinishCurTrackDungeonNode,
		// Token: 0x0400D218 RID: 53784
		ITeleportToCurDungeonTrackPosition,
		// Token: 0x0400D219 RID: 53785
		IResetCurrentDungeon,
		// Token: 0x0400D21A RID: 53786
		IExitDungeonInGm,
		// Token: 0x0400D21B RID: 53787
		IGmRoguelikeStartInGm,
		// Token: 0x0400D21C RID: 53788
		IGmGotoRogueRoomInGm,
		// Token: 0x0400D21D RID: 53789
		IUnlockEntityForGm,
		// Token: 0x0400D21E RID: 53790
		ITeleportToEntity,
		// Token: 0x0400D21F RID: 53791
		IGmTeleportToEntity,
		// Token: 0x0400D220 RID: 53792
		IOpenDungeonEntrance,
		// Token: 0x0400D221 RID: 53793
		IShowTipsView,
		// Token: 0x0400D222 RID: 53794
		IShieldGuide,
		// Token: 0x0400D223 RID: 53795
		IOpenFunc,
		// Token: 0x0400D224 RID: 53796
		ISetTime,
		// Token: 0x0400D225 RID: 53797
		IUnlockAllExploreSkill,
		// Token: 0x0400D226 RID: 53798
		IActivateTeleport,
		// Token: 0x0400D227 RID: 53799
		ISetUnopenedAreaPullback,
		// Token: 0x0400D228 RID: 53800
		ITeleportToPos,
		// Token: 0x0400D229 RID: 53801
		ITeleportToPosInWorld,
		// Token: 0x0400D22A RID: 53802
		IUnfreezeInstanceLimit,
		// Token: 0x0400D22B RID: 53803
		IUpdateSceneRoles,
		// Token: 0x0400D22C RID: 53804
		IAddAllRole,
		// Token: 0x0400D22D RID: 53805
		IAddNewRole,
		// Token: 0x0400D22E RID: 53806
		ISetAllRoleToGraduate,
		// Token: 0x0400D22F RID: 53807
		IAddAllItem,
		// Token: 0x0400D230 RID: 53808
		IAddItem,
		// Token: 0x0400D231 RID: 53809
		IAddAllPhantom,
		// Token: 0x0400D232 RID: 53810
		IGetAllGraduatedPhantom,
		// Token: 0x0400D233 RID: 53811
		IGetAllGraduatedWeapon,
		// Token: 0x0400D234 RID: 53812
		ISetEquippedWeaponToGraduate,
		// Token: 0x0400D235 RID: 53813
		IEquipGraduatedWeaponToTeam,
		// Token: 0x0400D236 RID: 53814
		IExecuteActionList,
		// Token: 0x0400D237 RID: 53815
		IOpenBackLoginView,
		// Token: 0x0400D238 RID: 53816
		ISavePlayerData,
		// Token: 0x0400D239 RID: 53817
		IBrokenRockHotFix,
		// Token: 0x0400D23A RID: 53818
		ISetVar,
		// Token: 0x0400D23B RID: 53819
		IGoToNode,
		// Token: 0x0400D23C RID: 53820
		ICustomTextGm,
		// Token: 0x0400D23D RID: 53821
		IStartCombatOperationCapture,
		// Token: 0x0400D23E RID: 53822
		IStopCombatOperationCapture,
		// Token: 0x0400D23F RID: 53823
		IRecordCombatOperationCaptureCheckpoint,
		// Token: 0x0400D240 RID: 53824
		IStartCombatOperationReplay,
		// Token: 0x0400D241 RID: 53825
		IStopCombatOperationReplay
	}
}
