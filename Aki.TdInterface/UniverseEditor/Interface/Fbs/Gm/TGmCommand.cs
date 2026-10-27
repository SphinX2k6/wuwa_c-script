using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046D8 RID: 18136
	public enum TGmCommand : byte
	{
		// Token: 0x0400C8AB RID: 51371
		NONE,
		// Token: 0x0400C8AC RID: 51372
		IAcceptQuest,
		// Token: 0x0400C8AD RID: 51373
		IActivateTeleport,
		// Token: 0x0400C8AE RID: 51374
		IAddAllItem,
		// Token: 0x0400C8AF RID: 51375
		IAddAllPhantom,
		// Token: 0x0400C8B0 RID: 51376
		IAddAllRole,
		// Token: 0x0400C8B1 RID: 51377
		IAddItem,
		// Token: 0x0400C8B2 RID: 51378
		IAddNewRole,
		// Token: 0x0400C8B3 RID: 51379
		IBrokenRockHotFix,
		// Token: 0x0400C8B4 RID: 51380
		ICustomTextGm,
		// Token: 0x0400C8B5 RID: 51381
		IEquipGraduatedWeaponToTeam,
		// Token: 0x0400C8B6 RID: 51382
		IExecuteActionList,
		// Token: 0x0400C8B7 RID: 51383
		IExitDungeonInGm,
		// Token: 0x0400C8B8 RID: 51384
		IFinishCurrentLevelPlayNode,
		// Token: 0x0400C8B9 RID: 51385
		IFinishCurrentTrackQuestNode,
		// Token: 0x0400C8BA RID: 51386
		IFinishCurTrackDungeonNode,
		// Token: 0x0400C8BB RID: 51387
		IGetAllGraduatedPhantom,
		// Token: 0x0400C8BC RID: 51388
		IGetAllGraduatedWeapon,
		// Token: 0x0400C8BD RID: 51389
		IGmGotoRogueRoomInGm,
		// Token: 0x0400C8BE RID: 51390
		IGmRoguelikeStartInGm,
		// Token: 0x0400C8BF RID: 51391
		IGmSetLevelPlaySwitchForce,
		// Token: 0x0400C8C0 RID: 51392
		IGmSetLevelPlayUpdateForce,
		// Token: 0x0400C8C1 RID: 51393
		IGmTeleportToEntity,
		// Token: 0x0400C8C2 RID: 51394
		IGoToNode,
		// Token: 0x0400C8C3 RID: 51395
		IOpenBackLoginView,
		// Token: 0x0400C8C4 RID: 51396
		IOpenDungeonEntrance,
		// Token: 0x0400C8C5 RID: 51397
		IOpenFunc,
		// Token: 0x0400C8C6 RID: 51398
		IPlayFlowForGm,
		// Token: 0x0400C8C7 RID: 51399
		IRecordCombatOperationCaptureCheckpoint,
		// Token: 0x0400C8C8 RID: 51400
		IResetCurrentDungeon,
		// Token: 0x0400C8C9 RID: 51401
		ISavePlayerData,
		// Token: 0x0400C8CA RID: 51402
		ISetAllRoleToGraduate,
		// Token: 0x0400C8CB RID: 51403
		ISetEquippedWeaponToGraduate,
		// Token: 0x0400C8CC RID: 51404
		ISetTime,
		// Token: 0x0400C8CD RID: 51405
		ISetUnopenedAreaPullback,
		// Token: 0x0400C8CE RID: 51406
		ISetVar,
		// Token: 0x0400C8CF RID: 51407
		IShieldGuide,
		// Token: 0x0400C8D0 RID: 51408
		IShowTipsView,
		// Token: 0x0400C8D1 RID: 51409
		ISkipToInstanceDungeonNode,
		// Token: 0x0400C8D2 RID: 51410
		ISkipToLevelPlayNode,
		// Token: 0x0400C8D3 RID: 51411
		ISkipToQuestNode,
		// Token: 0x0400C8D4 RID: 51412
		IStartCombatOperationCapture,
		// Token: 0x0400C8D5 RID: 51413
		IStartCombatOperationReplay,
		// Token: 0x0400C8D6 RID: 51414
		IStopCombatOperationCapture,
		// Token: 0x0400C8D7 RID: 51415
		IStopCombatOperationReplay,
		// Token: 0x0400C8D8 RID: 51416
		ITeleportToCurDungeonTrackPosition,
		// Token: 0x0400C8D9 RID: 51417
		ITeleportToCurLevelPlayTrackPosition,
		// Token: 0x0400C8DA RID: 51418
		ITeleportToCurQuestTrackPosition,
		// Token: 0x0400C8DB RID: 51419
		ITeleportToEntity,
		// Token: 0x0400C8DC RID: 51420
		ITeleportToLevelPlayCenter,
		// Token: 0x0400C8DD RID: 51421
		ITeleportToPos,
		// Token: 0x0400C8DE RID: 51422
		ITeleportToPosInWorld,
		// Token: 0x0400C8DF RID: 51423
		IUnfreezeInstanceLimit,
		// Token: 0x0400C8E0 RID: 51424
		IUnlockAllExploreSkill,
		// Token: 0x0400C8E1 RID: 51425
		IUnlockEntityForGm,
		// Token: 0x0400C8E2 RID: 51426
		IUnlockQuest,
		// Token: 0x0400C8E3 RID: 51427
		IUpdateSceneRoles
	}
}
