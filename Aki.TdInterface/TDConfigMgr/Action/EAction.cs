using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001576 RID: 5494
	[EnumExtensions]
	public enum EAction
	{
		// Token: 0x0400475D RID: 18269
		Undefined,
		// Token: 0x0400475E RID: 18270
		Activate,
		// Token: 0x0400475F RID: 18271
		AccpetCurrentQuest,
		// Token: 0x04004760 RID: 18272
		AddFlowInteractOption,
		// Token: 0x04004761 RID: 18273
		SetTime,
		// Token: 0x04004762 RID: 18274
		AwakeEntity,
		// Token: 0x04004763 RID: 18275
		CalculateVar,
		// Token: 0x04004764 RID: 18276
		RandomVar,
		// Token: 0x04004765 RID: 18277
		CallByCondition,
		// Token: 0x04004766 RID: 18278
		CallFunction,
		// Token: 0x04004767 RID: 18279
		CameraLookAt,
		// Token: 0x04004768 RID: 18280
		StopCameraLookAt,
		// Token: 0x04004769 RID: 18281
		EnableHostility,
		// Token: 0x0400476A RID: 18282
		ChangeActorState,
		// Token: 0x0400476B RID: 18283
		ChangeBehaviorState,
		// Token: 0x0400476C RID: 18284
		ChangeEntityState,
		// Token: 0x0400476D RID: 18285
		ChangeNpcPerformState,
		// Token: 0x0400476E RID: 18286
		ChangeInteractOptionText,
		// Token: 0x0400476F RID: 18287
		ChangeOtherState,
		// Token: 0x04004770 RID: 18288
		ChangeRandomState,
		// Token: 0x04004771 RID: 18289
		ChangeState,
		// Token: 0x04004772 RID: 18290
		Collect,
		// Token: 0x04004773 RID: 18291
		CompleteChildQuest,
		// Token: 0x04004774 RID: 18292
		Destroy,
		// Token: 0x04004775 RID: 18293
		DestroyAllChild,
		// Token: 0x04004776 RID: 18294
		DestroyEntity,
		// Token: 0x04004777 RID: 18295
		DestroySelf,
		// Token: 0x04004778 RID: 18296
		DoCalculate,
		// Token: 0x04004779 RID: 18297
		EnableFunction,
		// Token: 0x0400477A RID: 18298
		EnableClientFunction,
		// Token: 0x0400477B RID: 18299
		FaceToPos,
		// Token: 0x0400477C RID: 18300
		FinishDoInteract,
		// Token: 0x0400477D RID: 18301
		FinishState,
		// Token: 0x0400477E RID: 18302
		FinishTalk,
		// Token: 0x0400477F RID: 18303
		GetItem,
		// Token: 0x04004780 RID: 18304
		DestroyQuestItem,
		// Token: 0x04004781 RID: 18305
		GuideTrigger,
		// Token: 0x04004782 RID: 18306
		CompleteGuide,
		// Token: 0x04004783 RID: 18307
		Invoke,
		// Token: 0x04004784 RID: 18308
		JumpTalk,
		// Token: 0x04004785 RID: 18309
		Log,
		// Token: 0x04004786 RID: 18310
		MoveToPos,
		// Token: 0x04004787 RID: 18311
		MoveWithSpline,
		// Token: 0x04004788 RID: 18312
		NewMoveWithSpline,
		// Token: 0x04004789 RID: 18313
		StopNewMoveWithSpline,
		// Token: 0x0400478A RID: 18314
		CharacterMoveToPoint,
		// Token: 0x0400478B RID: 18315
		PlayerMoveToPoint,
		// Token: 0x0400478C RID: 18316
		NpcMoveToPoint,
		// Token: 0x0400478D RID: 18317
		OpenSystemBoard,
		// Token: 0x0400478E RID: 18318
		OpenSystemFunction,
		// Token: 0x0400478F RID: 18319
		PlayCustomSequence,
		// Token: 0x04004790 RID: 18320
		PlayerLookAt,
		// Token: 0x04004791 RID: 18321
		EntityLookAt,
		// Token: 0x04004792 RID: 18322
		EntityTurnTo,
		// Token: 0x04004793 RID: 18323
		CharacterLookAt,
		// Token: 0x04004794 RID: 18324
		PlayFlow,
		// Token: 0x04004795 RID: 18325
		PlayMovie,
		// Token: 0x04004796 RID: 18326
		PlayEffect,
		// Token: 0x04004797 RID: 18327
		PlayEffect2,
		// Token: 0x04004798 RID: 18328
		RemoveEffect,
		// Token: 0x04004799 RID: 18329
		PlayMontage,
		// Token: 0x0400479A RID: 18330
		PlayRegisteredMontage,
		// Token: 0x0400479B RID: 18331
		PlaySequenceData,
		// Token: 0x0400479C RID: 18332
		PlayerInput,
		// Token: 0x0400479D RID: 18333
		Prompt,
		// Token: 0x0400479E RID: 18334
		AddPlayBubble,
		// Token: 0x0400479F RID: 18335
		PlayBubble,
		// Token: 0x040047A0 RID: 18336
		ClearPlayBubble,
		// Token: 0x040047A1 RID: 18337
		EnableAI,
		// Token: 0x040047A2 RID: 18338
		RemoveFlowInteractOption,
		// Token: 0x040047A3 RID: 18339
		SendNpcMail,
		// Token: 0x040047A4 RID: 18340
		SetBehaviorIsPaused,
		// Token: 0x040047A5 RID: 18341
		SetCameraMode,
		// Token: 0x040047A6 RID: 18342
		SetEntityVisible,
		// Token: 0x040047A7 RID: 18343
		SetEntityClientVisible,
		// Token: 0x040047A8 RID: 18344
		SetEntityClientVisibleSave,
		// Token: 0x040047A9 RID: 18345
		SetHeadIconVisible,
		// Token: 0x040047AA RID: 18346
		SetMoveSpeed,
		// Token: 0x040047AB RID: 18347
		SetNumberVar,
		// Token: 0x040047AC RID: 18348
		SetPlotMode,
		// Token: 0x040047AD RID: 18349
		SetPos,
		// Token: 0x040047AE RID: 18350
		SetVar,
		// Token: 0x040047AF RID: 18351
		SetActorVar,
		// Token: 0x040047B0 RID: 18352
		ShowCenterText,
		// Token: 0x040047B1 RID: 18353
		ShowMessage,
		// Token: 0x040047B2 RID: 18354
		ShowTalk,
		// Token: 0x040047B3 RID: 18355
		SimpleMove,
		// Token: 0x040047B4 RID: 18356
		SpawnChild,
		// Token: 0x040047B5 RID: 18357
		SpawnEntity,
		// Token: 0x040047B6 RID: 18358
		SyncVarToActorState,
		// Token: 0x040047B7 RID: 18359
		Wait,
		// Token: 0x040047B8 RID: 18360
		AddBuffToEntity,
		// Token: 0x040047B9 RID: 18361
		AddBuffToPlayer,
		// Token: 0x040047BA RID: 18362
		AddBuffToFollowShooter,
		// Token: 0x040047BB RID: 18363
		LockEntity,
		// Token: 0x040047BC RID: 18364
		UnlockEntity,
		// Token: 0x040047BD RID: 18365
		SetForceLock,
		// Token: 0x040047BE RID: 18366
		SetAreaState,
		// Token: 0x040047BF RID: 18367
		SetWuYinQuState,
		// Token: 0x040047C0 RID: 18368
		RemoveBuffFromEntity,
		// Token: 0x040047C1 RID: 18369
		RemoveBuffFromPlayer,
		// Token: 0x040047C2 RID: 18370
		SetPlayerMoveControl,
		// Token: 0x040047C3 RID: 18371
		UnlockTeleportTrigger,
		// Token: 0x040047C4 RID: 18372
		ChangeTeamPosition,
		// Token: 0x040047C5 RID: 18373
		ClientChangeTeamPosition,
		// Token: 0x040047C6 RID: 18374
		ClaimLevelPlayReward,
		// Token: 0x040047C7 RID: 18375
		ClaimDynamicEntityReward,
		// Token: 0x040047C8 RID: 18376
		SetReviveRegion,
		// Token: 0x040047C9 RID: 18377
		PromptQuestChapterUI,
		// Token: 0x040047CA RID: 18378
		FireBullet,
		// Token: 0x040047CB RID: 18379
		FireBulletEffect,
		// Token: 0x040047CC RID: 18380
		SetPlayerPos,
		// Token: 0x040047CD RID: 18381
		ClientSetPlayerPos,
		// Token: 0x040047CE RID: 18382
		ClientPreEnableSubLevels,
		// Token: 0x040047CF RID: 18383
		ChangeSelfEntityState,
		// Token: 0x040047D0 RID: 18384
		InterludeActions,
		// Token: 0x040047D1 RID: 18385
		AddBuffToTriggeredEntity,
		// Token: 0x040047D2 RID: 18386
		RemoveBuffToTriggeredEntity,
		// Token: 0x040047D3 RID: 18387
		DetectTrigger,
		// Token: 0x040047D4 RID: 18388
		ItemFoundationMatch,
		// Token: 0x040047D5 RID: 18389
		SetBattleState,
		// Token: 0x040047D6 RID: 18390
		WaitBattleCondition,
		// Token: 0x040047D7 RID: 18391
		UnlockSystemItem,
		// Token: 0x040047D8 RID: 18392
		ClientUnlockAchievementSystemItem,
		// Token: 0x040047D9 RID: 18393
		RunActions,
		// Token: 0x040047DA RID: 18394
		CommonTip,
		// Token: 0x040047DB RID: 18395
		EndCommonTip,
		// Token: 0x040047DC RID: 18396
		CommonTip2,
		// Token: 0x040047DD RID: 18397
		EnableNearbyTracking,
		// Token: 0x040047DE RID: 18398
		EnableLevelPlay,
		// Token: 0x040047DF RID: 18399
		UnLimitPlayerOperation,
		// Token: 0x040047E0 RID: 18400
		LimitPlayerOperation,
		// Token: 0x040047E1 RID: 18401
		SetPlayerOperationRestriction,
		// Token: 0x040047E2 RID: 18402
		ClientSetPlayerOperationRestriction,
		// Token: 0x040047E3 RID: 18403
		LeisureInteract,
		// Token: 0x040047E4 RID: 18404
		NpcLeisureInteract,
		// Token: 0x040047E5 RID: 18405
		ChangePhantom,
		// Token: 0x040047E6 RID: 18406
		RestorePhantom,
		// Token: 0x040047E7 RID: 18407
		TakePlotPhoto,
		// Token: 0x040047E8 RID: 18408
		OpenQte,
		// Token: 0x040047E9 RID: 18409
		Preload,
		// Token: 0x040047EA RID: 18410
		RemovePreloadResource,
		// Token: 0x040047EB RID: 18411
		ExecAlertSystemAction,
		// Token: 0x040047EC RID: 18412
		RecordDungeonEvent,
		// Token: 0x040047ED RID: 18413
		ResetLevelPlay,
		// Token: 0x040047EE RID: 18414
		SetAreaTimeState,
		// Token: 0x040047EF RID: 18415
		GetRewardByInteract,
		// Token: 0x040047F0 RID: 18416
		WaitUntilLevelSequenceReachMark,
		// Token: 0x040047F1 RID: 18417
		EnableKey4Func,
		// Token: 0x040047F2 RID: 18418
		OpenQuickHackSystem,
		// Token: 0x040047F3 RID: 18419
		GuestOperateUiAnimation,
		// Token: 0x040047F4 RID: 18420
		VehicleEnter,
		// Token: 0x040047F5 RID: 18421
		VehicleEnterNpc,
		// Token: 0x040047F6 RID: 18422
		VehicleExitPlayer,
		// Token: 0x040047F7 RID: 18423
		VehicleExitNpc,
		// Token: 0x040047F8 RID: 18424
		VehicleTeleport,
		// Token: 0x040047F9 RID: 18425
		ClientVehicleTeleport,
		// Token: 0x040047FA RID: 18426
		VehiclePlayPassengerVoice,
		// Token: 0x040047FB RID: 18427
		VehicleWaterfallClimbing,
		// Token: 0x040047FC RID: 18428
		TeleportToAndEnterVehicle,
		// Token: 0x040047FD RID: 18429
		VehicleMoveWithPathLine,
		// Token: 0x040047FE RID: 18430
		VehicleSprint,
		// Token: 0x040047FF RID: 18431
		VehicleSetSpeedImmediately,
		// Token: 0x04004800 RID: 18432
		TeleportDungeon,
		// Token: 0x04004801 RID: 18433
		SettlementDungeon,
		// Token: 0x04004802 RID: 18434
		ClaimDungeonReward,
		// Token: 0x04004803 RID: 18435
		ExitDungeon,
		// Token: 0x04004804 RID: 18436
		UnlockDungeonEntry,
		// Token: 0x04004805 RID: 18437
		FinishDungeon,
		// Token: 0x04004806 RID: 18438
		StopUiScreenEffect,
		// Token: 0x04004807 RID: 18439
		StartFlowTemplate,
		// Token: 0x04004808 RID: 18440
		BeginFlowTemplate,
		// Token: 0x04004809 RID: 18441
		ChangeFlowTemplate,
		// Token: 0x0400480A RID: 18442
		SetFlowTemplate,
		// Token: 0x0400480B RID: 18443
		EndFlowTemplate,
		// Token: 0x0400480C RID: 18444
		CloseFlowTemplate,
		// Token: 0x0400480D RID: 18445
		SendAiEvent,
		// Token: 0x0400480E RID: 18446
		FadeInScreen,
		// Token: 0x0400480F RID: 18447
		FadeOutScreen,
		// Token: 0x04004810 RID: 18448
		ChangeFightTeam,
		// Token: 0x04004811 RID: 18449
		ManualOccupations,
		// Token: 0x04004812 RID: 18450
		AddTrialCharacter,
		// Token: 0x04004813 RID: 18451
		UpdateTrialCharacter,
		// Token: 0x04004814 RID: 18452
		RestoreTrialCharacter,
		// Token: 0x04004815 RID: 18453
		RemoveTrialCharacter,
		// Token: 0x04004816 RID: 18454
		AddGuestCharacter,
		// Token: 0x04004817 RID: 18455
		RemoveGuestCharacter,
		// Token: 0x04004818 RID: 18456
		AddTrialFollowShooter,
		// Token: 0x04004819 RID: 18457
		RemoveTrialFollowShooter,
		// Token: 0x0400481A RID: 18458
		EnableFollowShooterAbility,
		// Token: 0x0400481B RID: 18459
		ClientFollowShooterLeisureInteract,
		// Token: 0x0400481C RID: 18460
		DestroyQuest,
		// Token: 0x0400481D RID: 18461
		SetCameraAnim,
		// Token: 0x0400481E RID: 18462
		RotatorEntity,
		// Token: 0x0400481F RID: 18463
		TraceSpline,
		// Token: 0x04004820 RID: 18464
		ToggleScanSplineEffect,
		// Token: 0x04004821 RID: 18465
		ChangeTimer,
		// Token: 0x04004822 RID: 18466
		ToggleTimerPauseState,
		// Token: 0x04004823 RID: 18467
		EnableSystem,
		// Token: 0x04004824 RID: 18468
		PostAkEvent,
		// Token: 0x04004825 RID: 18469
		MoveSceneItem,
		// Token: 0x04004826 RID: 18470
		StopSceneItemMove,
		// Token: 0x04004827 RID: 18471
		ChangeLiftTarget,
		// Token: 0x04004828 RID: 18472
		HideByRangeInFlow,
		// Token: 0x04004829 RID: 18473
		ShowAllHidedGroupInFlow,
		// Token: 0x0400482A RID: 18474
		OpenSimpleGameplay,
		// Token: 0x0400482B RID: 18475
		CloseSimpleGameplay,
		// Token: 0x0400482C RID: 18476
		ChangeActorTalker,
		// Token: 0x0400482D RID: 18477
		SwitchSubLevels,
		// Token: 0x0400482E RID: 18478
		SwitchDataLayers,
		// Token: 0x0400482F RID: 18479
		ActivateResetPoint,
		// Token: 0x04004830 RID: 18480
		TeleportToLatestResetPoint,
		// Token: 0x04004831 RID: 18481
		SetWeather,
		// Token: 0x04004832 RID: 18482
		SetTimeLockState,
		// Token: 0x04004833 RID: 18483
		SetWeatherLockState,
		// Token: 0x04004834 RID: 18484
		AdjustPlayerCamera,
		// Token: 0x04004835 RID: 18485
		AdjustPlayerCameraGravity,
		// Token: 0x04004836 RID: 18486
		RestorePlayerCameraAdjustment,
		// Token: 0x04004837 RID: 18487
		EnterMovieCamera,
		// Token: 0x04004838 RID: 18488
		ExitMovieCamera,
		// Token: 0x04004839 RID: 18489
		ResetPlayerCameraFocus,
		// Token: 0x0400483A RID: 18490
		UsePhantomSkill,
		// Token: 0x0400483B RID: 18491
		ChangePhantomFormation,
		// Token: 0x0400483C RID: 18492
		RestorePhantomFormation,
		// Token: 0x0400483D RID: 18493
		EnterOrbitalCamera,
		// Token: 0x0400483E RID: 18494
		ExitOrbitalCamera,
		// Token: 0x0400483F RID: 18495
		EnableSplineMoveModel,
		// Token: 0x04004840 RID: 18496
		SetSportsState,
		// Token: 0x04004841 RID: 18497
		PlayLevelSequence,
		// Token: 0x04004842 RID: 18498
		EnableTakePhotoClip,
		// Token: 0x04004843 RID: 18499
		SetExploreState,
		// Token: 0x04004844 RID: 18500
		EnableAoiNotify,
		// Token: 0x04004845 RID: 18501
		ChangeEntityPrefabPerformance,
		// Token: 0x04004846 RID: 18502
		ModifySceneItemAttributeTag,
		// Token: 0x04004847 RID: 18503
		ClientModifyTargetTag,
		// Token: 0x04004848 RID: 18504
		ToggleMapMarkState,
		// Token: 0x04004849 RID: 18505
		FocusOnMapMark,
		// Token: 0x0400484A RID: 18506
		ToggleHighlightExploreUi,
		// Token: 0x0400484B RID: 18507
		EnableTemporaryTeleport,
		// Token: 0x0400484C RID: 18508
		SetTeleControl,
		// Token: 0x0400484D RID: 18509
		ActiveAntiGravitySafePoint,
		// Token: 0x0400484E RID: 18510
		TriggerSpecificScanEffect,
		// Token: 0x0400484F RID: 18511
		SendClientEvent,
		// Token: 0x04004850 RID: 18512
		ClearFishingCabinInSaleItems,
		// Token: 0x04004851 RID: 18513
		AcceptFishingEntrust,
		// Token: 0x04004852 RID: 18514
		DestroyFishingBoat,
		// Token: 0x04004853 RID: 18515
		SlideRailStart,
		// Token: 0x04004854 RID: 18516
		SlideRailEnd,
		// Token: 0x04004855 RID: 18517
		SlidePerformStart,
		// Token: 0x04004856 RID: 18518
		BvbSendSystemEvent,
		// Token: 0x04004857 RID: 18519
		BvbSendAiEvent,
		// Token: 0x04004858 RID: 18520
		BvbPlayDialog,
		// Token: 0x04004859 RID: 18521
		BvbPlayerOperationConstraint,
		// Token: 0x0400485A RID: 18522
		BvbSkipChallenge,
		// Token: 0x0400485B RID: 18523
		SetSpineAnimation,
		// Token: 0x0400485C RID: 18524
		ChangeEntityCamp,
		// Token: 0x0400485D RID: 18525
		TrapDefenseChangeMiniMap,
		// Token: 0x0400485E RID: 18526
		TrapDefensePlayerOperationConstraint,
		// Token: 0x0400485F RID: 18527
		RogueGotoNextFloor,
		// Token: 0x04004860 RID: 18528
		RogueSelectRoom,
		// Token: 0x04004861 RID: 18529
		RogueActivatePortal,
		// Token: 0x04004862 RID: 18530
		RogueReceiveReward,
		// Token: 0x04004863 RID: 18531
		ExecRiskHarvestEffect,
		// Token: 0x04004864 RID: 18532
		MowingTowerGotoNextFloor,
		// Token: 0x04004865 RID: 18533
		SlashAndTowerGotoNextFloor,
		// Token: 0x04004866 RID: 18534
		RoleTowerGotoNextFloor,
		// Token: 0x04004867 RID: 18535
		DangoAbyssActivatePortal,
		// Token: 0x04004868 RID: 18536
		DangoAbyssGotoNextFloor,
		// Token: 0x04004869 RID: 18537
		DangoAbyssCreateRewardTreasureBox,
		// Token: 0x0400486A RID: 18538
		DangoAbyssReceiveReward,
		// Token: 0x0400486B RID: 18539
		RoverRogueRoomFinish,
		// Token: 0x0400486C RID: 18540
		RoverRogueActivate,
		// Token: 0x0400486D RID: 18541
		RoverRogueCreateRoomReward,
		// Token: 0x0400486E RID: 18542
		EnableActor,
		// Token: 0x0400486F RID: 18543
		ModifyActorMaterial,
		// Token: 0x04004870 RID: 18544
		SpecialOpModifyActorMaterialParamBySplineProgress,
		// Token: 0x04004871 RID: 18545
		ModifyActorMedia,
		// Token: 0x04004872 RID: 18546
		ToggleAirWall,
		// Token: 0x04004873 RID: 18547
		SetDataLayerTransitions,
		// Token: 0x04004874 RID: 18548
		TriggerCameraShake,
		// Token: 0x04004875 RID: 18549
		TriggerGamepadShake,
		// Token: 0x04004876 RID: 18550
		CreatePrefab,
		// Token: 0x04004877 RID: 18551
		DestroyPrefab,
		// Token: 0x04004878 RID: 18552
		ExecBattleAction,
		// Token: 0x04004879 RID: 18553
		ExecClientBattleAction,
		// Token: 0x0400487A RID: 18554
		RecoverDurability,
		// Token: 0x0400487B RID: 18555
		SetRegionConfig,
		// Token: 0x0400487C RID: 18556
		SetJigsawItem,
		// Token: 0x0400487D RID: 18557
		SetJigsawFoundation,
		// Token: 0x0400487E RID: 18558
		ResetEntity,
		// Token: 0x0400487F RID: 18559
		PlayDynamicSettlement,
		// Token: 0x04004880 RID: 18560
		SetInteractionLockState,
		// Token: 0x04004881 RID: 18561
		FinishCondition,
		// Token: 0x04004882 RID: 18562
		ClearEntityVisibleTag,
		// Token: 0x04004883 RID: 18563
		SetEntityPos,
		// Token: 0x04004884 RID: 18564
		ResetEntityPos,
		// Token: 0x04004885 RID: 18565
		ServerSetPlayerPos,
		// Token: 0x04004886 RID: 18566
		FixTeleControllerPos,
		// Token: 0x04004887 RID: 18567
		CustomJson,
		// Token: 0x04004888 RID: 18568
		FixFoundationRelation,
		// Token: 0x04004889 RID: 18569
		FixShowTargetRange,
		// Token: 0x0400488A RID: 18570
		TraceCurrentQuest,
		// Token: 0x0400488B RID: 18571
		ForceOccupations,
		// Token: 0x0400488C RID: 18572
		ServerForceEnableLevelPlay,
		// Token: 0x0400488D RID: 18573
		TeleportDungeonPos,
		// Token: 0x0400488E RID: 18574
		SetTimeScale,
		// Token: 0x0400488F RID: 18575
		FixGetItem,
		// Token: 0x04004890 RID: 18576
		SetAudioState,
		// Token: 0x04004891 RID: 18577
		PerformerAiSplineMove,
		// Token: 0x04004892 RID: 18578
		PerformerAiMoveTo,
		// Token: 0x04004893 RID: 18579
		EnterPatrolState,
		// Token: 0x04004894 RID: 18580
		PerformAiHideSelf,
		// Token: 0x04004895 RID: 18581
		ExecResurrection,
		// Token: 0x04004896 RID: 18582
		HideSpecificEntities,
		// Token: 0x04004897 RID: 18583
		ShowSpecificEntities,
		// Token: 0x04004898 RID: 18584
		HideTargetRange,
		// Token: 0x04004899 RID: 18585
		ShowTargetRange,
		// Token: 0x0400489A RID: 18586
		HideGroup,
		// Token: 0x0400489B RID: 18587
		ShowHidedGroup,
		// Token: 0x0400489C RID: 18588
		ReignsSetPropertyVisible,
		// Token: 0x0400489D RID: 18589
		ReignsChangeBackground,
		// Token: 0x0400489E RID: 18590
		ReignsChangePlayerName,
		// Token: 0x0400489F RID: 18591
		ReignsCallCard,
		// Token: 0x040048A0 RID: 18592
		ReignsTriggerGuide,
		// Token: 0x040048A1 RID: 18593
		ReignsAddBuff,
		// Token: 0x040048A2 RID: 18594
		ReignsCheckSettle,
		// Token: 0x040048A3 RID: 18595
		HonamiStoryInteractPickUp,
		// Token: 0x040048A4 RID: 18596
		HonamiStoryReceiveCorruptedChestReward,
		// Token: 0x040048A5 RID: 18597
		HonamiStoryActivateSafeEvacuation,
		// Token: 0x040048A6 RID: 18598
		HonamiStoryGetItem,
		// Token: 0x040048A7 RID: 18599
		HonamiStorySetFormation,
		// Token: 0x040048A8 RID: 18600
		InfrActivityUpgradeInfrastructure,
		// Token: 0x040048A9 RID: 18601
		SetNpcGroupPerform,
		// Token: 0x040048AA RID: 18602
		RemoveNpcGroupPerform,
		// Token: 0x040048AB RID: 18603
		EnableEntityLookAt,
		// Token: 0x040048AC RID: 18604
		DisableEntityLookAt,
		// Token: 0x040048AD RID: 18605
		OverrideAiBehaviorTree,
		// Token: 0x040048AE RID: 18606
		RestoreAiBehaviorTree,
		// Token: 0x040048AF RID: 18607
		FlowDefineNpcGroupPerform,
		// Token: 0x040048B0 RID: 18608
		SeqEventAddTagToSelf,
		// Token: 0x040048B1 RID: 18609
		SeqEventFireBullet,
		// Token: 0x040048B2 RID: 18610
		SetMotorSpeed,
		// Token: 0x040048B3 RID: 18611
		StartMotorCruise,
		// Token: 0x040048B4 RID: 18612
		StopMotorCruise,
		// Token: 0x040048B5 RID: 18613
		DriveMotorInSpecConfig,
		// Token: 0x040048B6 RID: 18614
		MotorSoarInWindField,
		// Token: 0x040048B7 RID: 18615
		CollectSunSpirit,
		// Token: 0x040048B8 RID: 18616
		PerformSunSpiritGearRoundTrip,
		// Token: 0x040048B9 RID: 18617
		TriggerDeadeyeMode,
		// Token: 0x040048BA RID: 18618
		OpenSystemBoardWithReturn,
		// Token: 0x040048BB RID: 18619
		ResumeSystemRewardPopup,
		// Token: 0x040048BC RID: 18620
		SummonEntity,
		// Token: 0x040048BD RID: 18621
		DestroySummonedEntities,
		// Token: 0x040048BE RID: 18622
		SetupMoraleSystem,
		// Token: 0x040048BF RID: 18623
		GiantToggleModel,
		// Token: 0x040048C0 RID: 18624
		GiantTriggerResponse,
		// Token: 0x040048C1 RID: 18625
		ActivateGiantTotalProgressNode,
		// Token: 0x040048C2 RID: 18626
		RunActorCustomEvent,
		// Token: 0x040048C3 RID: 18627
		RequestSystemFunction,
		// Token: 0x040048C4 RID: 18628
		PlayWalkingOverlayMontage,
		// Token: 0x040048C5 RID: 18629
		ChangeNpcAbpState,
		// Token: 0x040048C6 RID: 18630
		CloseWalkingOverlayMontage,
		// Token: 0x040048C7 RID: 18631
		SetSkillButtonEffect,
		// Token: 0x040048C8 RID: 18632
		ScanEnrichmentArea,
		// Token: 0x040048C9 RID: 18633
		TriggerSystemRandomPlot,
		// Token: 0x040048CA RID: 18634
		SetAudioEnable,
		// Token: 0x040048CB RID: 18635
		PhoneSystemInteract,
		// Token: 0x040048CC RID: 18636
		RollBlockGetReward,
		// Token: 0x040048CD RID: 18637
		EnterMovieMode,
		// Token: 0x040048CE RID: 18638
		ExitMovieMode,
		// Token: 0x040048CF RID: 18639
		StartRoadNetworkNavigation,
		// Token: 0x040048D0 RID: 18640
		SetWayOccupancyState,
		// Token: 0x040048D1 RID: 18641
		SendSceneActorsEvent,
		// Token: 0x040048D2 RID: 18642
		ExecBpActorFunc,
		// Token: 0x040048D3 RID: 18643
		ResetPlayerPosWithPresentation,
		// Token: 0x040048D4 RID: 18644
		PlayerLookTowards,
		// Token: 0x040048D5 RID: 18645
		DrinksRollRoleRequirement,
		// Token: 0x040048D6 RID: 18646
		SetBlendAnim,
		// Token: 0x040048D7 RID: 18647
		ReportTrackingEvent,
		// Token: 0x040048D8 RID: 18648
		TetrisThrowBlock,
		// Token: 0x040048D9 RID: 18649
		TetrisGameComplete,
		// Token: 0x040048DA RID: 18650
		TetrisTriggerDelayFall,
		// Token: 0x040048DB RID: 18651
		BossPilingRandomBuff,
		// Token: 0x040048DC RID: 18652
		BossPilingEnterNextInst,
		// Token: 0x040048DD RID: 18653
		DollGrabItemDelivery,
		// Token: 0x040048DE RID: 18654
		AvgPlayRoleAction,
		// Token: 0x040048DF RID: 18655
		AvgMoveRole,
		// Token: 0x040048E0 RID: 18656
		AvgFocusRole,
		// Token: 0x040048E1 RID: 18657
		AvgShakeUi,
		// Token: 0x040048E2 RID: 18658
		DestroyDynamicEntities,
		// Token: 0x040048E3 RID: 18659
		SheriffUnlockClue,
		// Token: 0x040048E4 RID: 18660
		SheriffUnlockProgress,
		// Token: 0x040048E5 RID: 18661
		SheriffChangeCriminalState,
		// Token: 0x040048E6 RID: 18662
		SheriffChangeCriminalIdentity,
		// Token: 0x040048E7 RID: 18663
		SheriffUnlockEnding,
		// Token: 0x040048E8 RID: 18664
		SetSubScreenMode,
		// Token: 0x040048E9 RID: 18665
		ClientSetSeasonState,
		// Token: 0x040048EA RID: 18666
		ToggleDragActorPlay,
		// Token: 0x040048EB RID: 18667
		SetTargetElementalAbility,
		// Token: 0x040048EC RID: 18668
		ToggleEntityElementalAbility,
		// Token: 0x040048ED RID: 18669
		CaptureElementalBox,
		// Token: 0x040048EE RID: 18670
		ChangeElementalBoxState,
		// Token: 0x040048EF RID: 18671
		SetElementalBoxToTarget,
		// Token: 0x040048F0 RID: 18672
		OverrideAbpAnimScheme
	}
}
