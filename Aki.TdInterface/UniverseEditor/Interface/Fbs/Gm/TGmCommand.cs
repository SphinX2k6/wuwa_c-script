using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B40 RID: 19264
	public enum TGmCommand : byte
	{
		// Token: 0x0400D2DA RID: 53978
		NONE,
		// Token: 0x0400D2DB RID: 53979
		IAcceptQuest,
		// Token: 0x0400D2DC RID: 53980
		IActivateTeleport,
		// Token: 0x0400D2DD RID: 53981
		IAddAllItem,
		// Token: 0x0400D2DE RID: 53982
		IAddAllPhantom,
		// Token: 0x0400D2DF RID: 53983
		IAddAllRole,
		// Token: 0x0400D2E0 RID: 53984
		IAddItem,
		// Token: 0x0400D2E1 RID: 53985
		IAddNewRole,
		// Token: 0x0400D2E2 RID: 53986
		IBrokenRockHotFix,
		// Token: 0x0400D2E3 RID: 53987
		ICustomTextGm,
		// Token: 0x0400D2E4 RID: 53988
		IEquipGraduatedWeaponToTeam,
		// Token: 0x0400D2E5 RID: 53989
		IExecuteActionList,
		// Token: 0x0400D2E6 RID: 53990
		IExitDungeonInGm,
		// Token: 0x0400D2E7 RID: 53991
		IFinishCurrentLevelPlayNode,
		// Token: 0x0400D2E8 RID: 53992
		IFinishCurrentTrackQuestNode,
		// Token: 0x0400D2E9 RID: 53993
		IFinishCurTrackDungeonNode,
		// Token: 0x0400D2EA RID: 53994
		IGetAllGraduatedPhantom,
		// Token: 0x0400D2EB RID: 53995
		IGetAllGraduatedWeapon,
		// Token: 0x0400D2EC RID: 53996
		IGmGotoRogueRoomInGm,
		// Token: 0x0400D2ED RID: 53997
		IGmRoguelikeStartInGm,
		// Token: 0x0400D2EE RID: 53998
		IGmSetLevelPlaySwitchForce,
		// Token: 0x0400D2EF RID: 53999
		IGmSetLevelPlayUpdateForce,
		// Token: 0x0400D2F0 RID: 54000
		IGmTeleportToEntity,
		// Token: 0x0400D2F1 RID: 54001
		IGoToNode,
		// Token: 0x0400D2F2 RID: 54002
		IOpenBackLoginView,
		// Token: 0x0400D2F3 RID: 54003
		IOpenDungeonEntrance,
		// Token: 0x0400D2F4 RID: 54004
		IOpenFunc,
		// Token: 0x0400D2F5 RID: 54005
		IPlayFlowForGm,
		// Token: 0x0400D2F6 RID: 54006
		IRecordCombatOperationCaptureCheckpoint,
		// Token: 0x0400D2F7 RID: 54007
		IResetCurrentDungeon,
		// Token: 0x0400D2F8 RID: 54008
		ISavePlayerData,
		// Token: 0x0400D2F9 RID: 54009
		ISetAllRoleToGraduate,
		// Token: 0x0400D2FA RID: 54010
		ISetEquippedWeaponToGraduate,
		// Token: 0x0400D2FB RID: 54011
		ISetTime,
		// Token: 0x0400D2FC RID: 54012
		ISetUnopenedAreaPullback,
		// Token: 0x0400D2FD RID: 54013
		ISetVar,
		// Token: 0x0400D2FE RID: 54014
		IShieldGuide,
		// Token: 0x0400D2FF RID: 54015
		IShowTipsView,
		// Token: 0x0400D300 RID: 54016
		ISkipToInstanceDungeonNode,
		// Token: 0x0400D301 RID: 54017
		ISkipToLevelPlayNode,
		// Token: 0x0400D302 RID: 54018
		ISkipToQuestNode,
		// Token: 0x0400D303 RID: 54019
		IStartCombatOperationCapture,
		// Token: 0x0400D304 RID: 54020
		IStartCombatOperationReplay,
		// Token: 0x0400D305 RID: 54021
		IStopCombatOperationCapture,
		// Token: 0x0400D306 RID: 54022
		IStopCombatOperationReplay,
		// Token: 0x0400D307 RID: 54023
		ITeleportToCurDungeonTrackPosition,
		// Token: 0x0400D308 RID: 54024
		ITeleportToCurLevelPlayTrackPosition,
		// Token: 0x0400D309 RID: 54025
		ITeleportToCurQuestTrackPosition,
		// Token: 0x0400D30A RID: 54026
		ITeleportToEntity,
		// Token: 0x0400D30B RID: 54027
		ITeleportToLevelPlayCenter,
		// Token: 0x0400D30C RID: 54028
		ITeleportToPos,
		// Token: 0x0400D30D RID: 54029
		ITeleportToPosInWorld,
		// Token: 0x0400D30E RID: 54030
		IUnfreezeInstanceLimit,
		// Token: 0x0400D30F RID: 54031
		IUnlockAllExploreSkill,
		// Token: 0x0400D310 RID: 54032
		IUnlockEntityForGm,
		// Token: 0x0400D311 RID: 54033
		IUnlockQuest,
		// Token: 0x0400D312 RID: 54034
		IUpdateSceneRoles
	}
}
