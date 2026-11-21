using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016D4 RID: 5844
	[EnumExtensions]
	public enum EAction
	{
		// Token: 0x04004AFD RID: 19197
		Undefined,
		// Token: 0x04004AFE RID: 19198
		Activate,
		// Token: 0x04004AFF RID: 19199
		AccpetCurrentQuest,
		// Token: 0x04004B00 RID: 19200
		AddFlowInteractOption,
		// Token: 0x04004B01 RID: 19201
		SetTime,
		// Token: 0x04004B02 RID: 19202
		AwakeEntity,
		// Token: 0x04004B03 RID: 19203
		CalculateVar,
		// Token: 0x04004B04 RID: 19204
		RandomVar,
		// Token: 0x04004B05 RID: 19205
		CallByCondition,
		// Token: 0x04004B06 RID: 19206
		CallFunction,
		// Token: 0x04004B07 RID: 19207
		CameraLookAt,
		// Token: 0x04004B08 RID: 19208
		StopCameraLookAt,
		// Token: 0x04004B09 RID: 19209
		EnableHostility,
		// Token: 0x04004B0A RID: 19210
		ChangeActorState,
		// Token: 0x04004B0B RID: 19211
		ChangeBehaviorState,
		// Token: 0x04004B0C RID: 19212
		ChangeEntityState,
		// Token: 0x04004B0D RID: 19213
		ChangeNpcPerformState,
		// Token: 0x04004B0E RID: 19214
		ChangeInteractOptionText,
		// Token: 0x04004B0F RID: 19215
		ChangeOtherState,
		// Token: 0x04004B10 RID: 19216
		ChangeRandomState,
		// Token: 0x04004B11 RID: 19217
		ChangeState,
		// Token: 0x04004B12 RID: 19218
		Collect,
		// Token: 0x04004B13 RID: 19219
		CompleteChildQuest,
		// Token: 0x04004B14 RID: 19220
		Destroy,
		// Token: 0x04004B15 RID: 19221
		DestroyAllChild,
		// Token: 0x04004B16 RID: 19222
		DestroyEntity,
		// Token: 0x04004B17 RID: 19223
		DestroySelf,
		// Token: 0x04004B18 RID: 19224
		DoCalculate,
		// Token: 0x04004B19 RID: 19225
		EnableFunction,
		// Token: 0x04004B1A RID: 19226
		EnableClientFunction,
		// Token: 0x04004B1B RID: 19227
		FaceToPos,
		// Token: 0x04004B1C RID: 19228
		FinishDoInteract,
		// Token: 0x04004B1D RID: 19229
		FinishState,
		// Token: 0x04004B1E RID: 19230
		FinishTalk,
		// Token: 0x04004B1F RID: 19231
		GetItem,
		// Token: 0x04004B20 RID: 19232
		DestroyQuestItem,
		// Token: 0x04004B21 RID: 19233
		GuideTrigger,
		// Token: 0x04004B22 RID: 19234
		CompleteGuide,
		// Token: 0x04004B23 RID: 19235
		Invoke,
		// Token: 0x04004B24 RID: 19236
		JumpTalk,
		// Token: 0x04004B25 RID: 19237
		Log,
		// Token: 0x04004B26 RID: 19238
		MoveToPos,
		// Token: 0x04004B27 RID: 19239
		MoveWithSpline,
		// Token: 0x04004B28 RID: 19240
		NewMoveWithSpline,
		// Token: 0x04004B29 RID: 19241
		StopNewMoveWithSpline,
		// Token: 0x04004B2A RID: 19242
		CharacterMoveToPoint,
		// Token: 0x04004B2B RID: 19243
		PlayerMoveToPoint,
		// Token: 0x04004B2C RID: 19244
		NpcMoveToPoint,
		// Token: 0x04004B2D RID: 19245
		OpenSystemBoard,
		// Token: 0x04004B2E RID: 19246
		OpenSystemFunction,
		// Token: 0x04004B2F RID: 19247
		PlayCustomSequence,
		// Token: 0x04004B30 RID: 19248
		PlayerLookAt,
		// Token: 0x04004B31 RID: 19249
		EntityLookAt,
		// Token: 0x04004B32 RID: 19250
		EntityTurnTo,
		// Token: 0x04004B33 RID: 19251
		CharacterLookAt,
		// Token: 0x04004B34 RID: 19252
		PlayFlow,
		// Token: 0x04004B35 RID: 19253
		PlayMovie,
		// Token: 0x04004B36 RID: 19254
		PlayEffect,
		// Token: 0x04004B37 RID: 19255
		PlayEffect2,
		// Token: 0x04004B38 RID: 19256
		RemoveEffect,
		// Token: 0x04004B39 RID: 19257
		PlayMontage,
		// Token: 0x04004B3A RID: 19258
		PlayRegisteredMontage,
		// Token: 0x04004B3B RID: 19259
		PlaySequenceData,
		// Token: 0x04004B3C RID: 19260
		PlayerInput,
		// Token: 0x04004B3D RID: 19261
		Prompt,
		// Token: 0x04004B3E RID: 19262
		AddPlayBubble,
		// Token: 0x04004B3F RID: 19263
		PlayBubble,
		// Token: 0x04004B40 RID: 19264
		ClearPlayBubble,
		// Token: 0x04004B41 RID: 19265
		EnableAI,
		// Token: 0x04004B42 RID: 19266
		RemoveFlowInteractOption,
		// Token: 0x04004B43 RID: 19267
		SendNpcMail,
		// Token: 0x04004B44 RID: 19268
		SetBehaviorIsPaused,
		// Token: 0x04004B45 RID: 19269
		SetCameraMode,
		// Token: 0x04004B46 RID: 19270
		SetEntityVisible,
		// Token: 0x04004B47 RID: 19271
		SetEntityClientVisible,
		// Token: 0x04004B48 RID: 19272
		SetEntityClientVisibleSave,
		// Token: 0x04004B49 RID: 19273
		SetHeadIconVisible,
		// Token: 0x04004B4A RID: 19274
		SetMoveSpeed,
		// Token: 0x04004B4B RID: 19275
		SetNumberVar,
		// Token: 0x04004B4C RID: 19276
		SetPlotMode,
		// Token: 0x04004B4D RID: 19277
		SetPos,
		// Token: 0x04004B4E RID: 19278
		SetVar,
		// Token: 0x04004B4F RID: 19279
		SetActorVar,
		// Token: 0x04004B50 RID: 19280
		ShowCenterText,
		// Token: 0x04004B51 RID: 19281
		ShowMessage,
		// Token: 0x04004B52 RID: 19282
		ShowTalk,
		// Token: 0x04004B53 RID: 19283
		ModifySceneUiSubtitle,
		// Token: 0x04004B54 RID: 19284
		SimpleMove,
		// Token: 0x04004B55 RID: 19285
		SpawnChild,
		// Token: 0x04004B56 RID: 19286
		SpawnEntity,
		// Token: 0x04004B57 RID: 19287
		SyncVarToActorState,
		// Token: 0x04004B58 RID: 19288
		Wait,
		// Token: 0x04004B59 RID: 19289
		ModifyEntityDecoration,
		// Token: 0x04004B5A RID: 19290
		AddBuffToEntity,
		// Token: 0x04004B5B RID: 19291
		AddBuffToPlayer,
		// Token: 0x04004B5C RID: 19292
		AddBuffToFollowShooter,
		// Token: 0x04004B5D RID: 19293
		LockEntity,
		// Token: 0x04004B5E RID: 19294
		UnlockEntity,
		// Token: 0x04004B5F RID: 19295
		SetForceLock,
		// Token: 0x04004B60 RID: 19296
		SetAreaState,
		// Token: 0x04004B61 RID: 19297
		SetWuYinQuState,
		// Token: 0x04004B62 RID: 19298
		RemoveBuffFromEntity,
		// Token: 0x04004B63 RID: 19299
		RemoveBuffFromPlayer,
		// Token: 0x04004B64 RID: 19300
		SetPlayerMoveControl,
		// Token: 0x04004B65 RID: 19301
		UnlockTeleportTrigger,
		// Token: 0x04004B66 RID: 19302
		ChangeTeamPosition,
		// Token: 0x04004B67 RID: 19303
		ClientChangeTeamPosition,
		// Token: 0x04004B68 RID: 19304
		ClaimLevelPlayReward,
		// Token: 0x04004B69 RID: 19305
		ClaimDynamicEntityReward,
		// Token: 0x04004B6A RID: 19306
		SetReviveRegion,
		// Token: 0x04004B6B RID: 19307
		PromptQuestChapterUI,
		// Token: 0x04004B6C RID: 19308
		FireBullet,
		// Token: 0x04004B6D RID: 19309
		FireBulletEffect,
		// Token: 0x04004B6E RID: 19310
		SetAssistCharacterPos,
		// Token: 0x04004B6F RID: 19311
		SetPlayerPos,
		// Token: 0x04004B70 RID: 19312
		ClientSetPlayerPos,
		// Token: 0x04004B71 RID: 19313
		ClientPreEnableSubLevels,
		// Token: 0x04004B72 RID: 19314
		ChangeSelfEntityState,
		// Token: 0x04004B73 RID: 19315
		InterludeActions,
		// Token: 0x04004B74 RID: 19316
		AddBuffToTriggeredEntity,
		// Token: 0x04004B75 RID: 19317
		RemoveBuffToTriggeredEntity,
		// Token: 0x04004B76 RID: 19318
		DetectTrigger,
		// Token: 0x04004B77 RID: 19319
		ItemFoundationMatch,
		// Token: 0x04004B78 RID: 19320
		SetBattleState,
		// Token: 0x04004B79 RID: 19321
		WaitBattleCondition,
		// Token: 0x04004B7A RID: 19322
		SendBattleTag,
		// Token: 0x04004B7B RID: 19323
		UnlockSystemItem,
		// Token: 0x04004B7C RID: 19324
		ClientUnlockAchievementSystemItem,
		// Token: 0x04004B7D RID: 19325
		RunActions,
		// Token: 0x04004B7E RID: 19326
		CommonTip,
		// Token: 0x04004B7F RID: 19327
		EndCommonTip,
		// Token: 0x04004B80 RID: 19328
		CommonTip2,
		// Token: 0x04004B81 RID: 19329
		EnableNearbyTracking,
		// Token: 0x04004B82 RID: 19330
		EnableLevelPlay,
		// Token: 0x04004B83 RID: 19331
		UnLimitPlayerOperation,
		// Token: 0x04004B84 RID: 19332
		LimitPlayerOperation,
		// Token: 0x04004B85 RID: 19333
		SetPlayerOperationRestriction,
		// Token: 0x04004B86 RID: 19334
		ClientSetPlayerOperationRestriction,
		// Token: 0x04004B87 RID: 19335
		LeisureInteract,
		// Token: 0x04004B88 RID: 19336
		NpcLeisureInteract,
		// Token: 0x04004B89 RID: 19337
		ChangePhantom,
		// Token: 0x04004B8A RID: 19338
		RestorePhantom,
		// Token: 0x04004B8B RID: 19339
		TakePlotPhoto,
		// Token: 0x04004B8C RID: 19340
		OpenQte,
		// Token: 0x04004B8D RID: 19341
		Preload,
		// Token: 0x04004B8E RID: 19342
		RemovePreloadResource,
		// Token: 0x04004B8F RID: 19343
		ExecAlertSystemAction,
		// Token: 0x04004B90 RID: 19344
		RecordDungeonEvent,
		// Token: 0x04004B91 RID: 19345
		ResetLevelPlay,
		// Token: 0x04004B92 RID: 19346
		SetAreaTimeState,
		// Token: 0x04004B93 RID: 19347
		GetRewardByInteract,
		// Token: 0x04004B94 RID: 19348
		WaitUntilLevelSequenceReachMark,
		// Token: 0x04004B95 RID: 19349
		EnableKey4Func,
		// Token: 0x04004B96 RID: 19350
		OpenQuickHackSystem,
		// Token: 0x04004B97 RID: 19351
		GuestOperateUiAnimation,
		// Token: 0x04004B98 RID: 19352
		VehicleEnter,
		// Token: 0x04004B99 RID: 19353
		VehicleEnterNpc,
		// Token: 0x04004B9A RID: 19354
		VehicleExitPlayer,
		// Token: 0x04004B9B RID: 19355
		VehicleExitNpc,
		// Token: 0x04004B9C RID: 19356
		VehicleTeleport,
		// Token: 0x04004B9D RID: 19357
		ClientVehicleTeleport,
		// Token: 0x04004B9E RID: 19358
		VehiclePlayPassengerVoice,
		// Token: 0x04004B9F RID: 19359
		VehicleWaterfallClimbing,
		// Token: 0x04004BA0 RID: 19360
		TeleportToAndEnterVehicle,
		// Token: 0x04004BA1 RID: 19361
		VehicleMoveWithPathLine,
		// Token: 0x04004BA2 RID: 19362
		VehicleSprint,
		// Token: 0x04004BA3 RID: 19363
		VehicleSetSpeedImmediately,
		// Token: 0x04004BA4 RID: 19364
		TeleportDungeon,
		// Token: 0x04004BA5 RID: 19365
		SettlementDungeon,
		// Token: 0x04004BA6 RID: 19366
		ClaimDungeonReward,
		// Token: 0x04004BA7 RID: 19367
		ExitDungeon,
		// Token: 0x04004BA8 RID: 19368
		UnlockDungeonEntry,
		// Token: 0x04004BA9 RID: 19369
		FinishDungeon,
		// Token: 0x04004BAA RID: 19370
		StopUiScreenEffect,
		// Token: 0x04004BAB RID: 19371
		StartFlowTemplate,
		// Token: 0x04004BAC RID: 19372
		BeginFlowTemplate,
		// Token: 0x04004BAD RID: 19373
		ChangeFlowTemplate,
		// Token: 0x04004BAE RID: 19374
		SetFlowTemplate,
		// Token: 0x04004BAF RID: 19375
		EndFlowTemplate,
		// Token: 0x04004BB0 RID: 19376
		CloseFlowTemplate,
		// Token: 0x04004BB1 RID: 19377
		SendAiEvent,
		// Token: 0x04004BB2 RID: 19378
		FadeInScreen,
		// Token: 0x04004BB3 RID: 19379
		FadeOutScreen,
		// Token: 0x04004BB4 RID: 19380
		ChangeFightTeam,
		// Token: 0x04004BB5 RID: 19381
		ManualOccupations,
		// Token: 0x04004BB6 RID: 19382
		AddTrialCharacter,
		// Token: 0x04004BB7 RID: 19383
		UpdateTrialCharacter,
		// Token: 0x04004BB8 RID: 19384
		RestoreTrialCharacter,
		// Token: 0x04004BB9 RID: 19385
		RemoveTrialCharacter,
		// Token: 0x04004BBA RID: 19386
		AddGuestCharacter,
		// Token: 0x04004BBB RID: 19387
		RemoveGuestCharacter,
		// Token: 0x04004BBC RID: 19388
		AddTrialFollowShooter,
		// Token: 0x04004BBD RID: 19389
		RemoveTrialFollowShooter,
		// Token: 0x04004BBE RID: 19390
		EnableFollowShooterAbility,
		// Token: 0x04004BBF RID: 19391
		FollowShooterLeisureInteract,
		// Token: 0x04004BC0 RID: 19392
		ClientFollowShooterLeisureInteract,
		// Token: 0x04004BC1 RID: 19393
		DestroyQuest,
		// Token: 0x04004BC2 RID: 19394
		SetCameraAnim,
		// Token: 0x04004BC3 RID: 19395
		RotatorEntity,
		// Token: 0x04004BC4 RID: 19396
		TraceSpline,
		// Token: 0x04004BC5 RID: 19397
		ToggleScanSplineEffect,
		// Token: 0x04004BC6 RID: 19398
		ChangeTimer,
		// Token: 0x04004BC7 RID: 19399
		ToggleTimerPauseState,
		// Token: 0x04004BC8 RID: 19400
		EnableSystem,
		// Token: 0x04004BC9 RID: 19401
		PostAkEvent,
		// Token: 0x04004BCA RID: 19402
		MoveSceneItem,
		// Token: 0x04004BCB RID: 19403
		StopSceneItemMove,
		// Token: 0x04004BCC RID: 19404
		ChangeLiftTarget,
		// Token: 0x04004BCD RID: 19405
		HideByRangeInFlow,
		// Token: 0x04004BCE RID: 19406
		ShowAllHidedGroupInFlow,
		// Token: 0x04004BCF RID: 19407
		OpenSimpleGameplay,
		// Token: 0x04004BD0 RID: 19408
		ToggleRideFlyingCarUiGameplay,
		// Token: 0x04004BD1 RID: 19409
		ChangeActorTalker,
		// Token: 0x04004BD2 RID: 19410
		SwitchSubLevels,
		// Token: 0x04004BD3 RID: 19411
		SwitchDataLayers,
		// Token: 0x04004BD4 RID: 19412
		ActivateResetPoint,
		// Token: 0x04004BD5 RID: 19413
		TeleportToLatestResetPoint,
		// Token: 0x04004BD6 RID: 19414
		SetWeather,
		// Token: 0x04004BD7 RID: 19415
		SetTimeLockState,
		// Token: 0x04004BD8 RID: 19416
		SetWeatherLockState,
		// Token: 0x04004BD9 RID: 19417
		AdjustPlayerCamera,
		// Token: 0x04004BDA RID: 19418
		AdjustPlayerCameraGravity,
		// Token: 0x04004BDB RID: 19419
		RestorePlayerCameraAdjustment,
		// Token: 0x04004BDC RID: 19420
		EnterMovieCamera,
		// Token: 0x04004BDD RID: 19421
		ExitMovieCamera,
		// Token: 0x04004BDE RID: 19422
		ResetPlayerCameraFocus,
		// Token: 0x04004BDF RID: 19423
		UsePhantomSkill,
		// Token: 0x04004BE0 RID: 19424
		ChangePhantomFormation,
		// Token: 0x04004BE1 RID: 19425
		RestorePhantomFormation,
		// Token: 0x04004BE2 RID: 19426
		EnterOrbitalCamera,
		// Token: 0x04004BE3 RID: 19427
		ExitOrbitalCamera,
		// Token: 0x04004BE4 RID: 19428
		EnableSplineMoveModel,
		// Token: 0x04004BE5 RID: 19429
		SetSportsState,
		// Token: 0x04004BE6 RID: 19430
		PlayLevelSequence,
		// Token: 0x04004BE7 RID: 19431
		EnableTakePhotoClip,
		// Token: 0x04004BE8 RID: 19432
		SetExploreState,
		// Token: 0x04004BE9 RID: 19433
		EnableAoiNotify,
		// Token: 0x04004BEA RID: 19434
		ChangeEntityPrefabPerformance,
		// Token: 0x04004BEB RID: 19435
		ModifySceneItemAttributeTag,
		// Token: 0x04004BEC RID: 19436
		ClientModifyTargetTag,
		// Token: 0x04004BED RID: 19437
		ToggleMapMarkState,
		// Token: 0x04004BEE RID: 19438
		FocusOnMapMark,
		// Token: 0x04004BEF RID: 19439
		ToggleHighlightExploreUi,
		// Token: 0x04004BF0 RID: 19440
		EnableTemporaryTeleport,
		// Token: 0x04004BF1 RID: 19441
		SetTeleControl,
		// Token: 0x04004BF2 RID: 19442
		ActiveAntiGravitySafePoint,
		// Token: 0x04004BF3 RID: 19443
		TriggerSpecificScanEffect,
		// Token: 0x04004BF4 RID: 19444
		SendClientEvent,
		// Token: 0x04004BF5 RID: 19445
		ClearFishingCabinInSaleItems,
		// Token: 0x04004BF6 RID: 19446
		AcceptFishingEntrust,
		// Token: 0x04004BF7 RID: 19447
		DestroyFishingBoat,
		// Token: 0x04004BF8 RID: 19448
		SlideRailStart,
		// Token: 0x04004BF9 RID: 19449
		SlideRailEnd,
		// Token: 0x04004BFA RID: 19450
		SlidePerformStart,
		// Token: 0x04004BFB RID: 19451
		BvbSendSystemEvent,
		// Token: 0x04004BFC RID: 19452
		BvbSendAiEvent,
		// Token: 0x04004BFD RID: 19453
		BvbPlayDialog,
		// Token: 0x04004BFE RID: 19454
		BvbPlayerOperationConstraint,
		// Token: 0x04004BFF RID: 19455
		BvbSkipChallenge,
		// Token: 0x04004C00 RID: 19456
		SetSpineAnimation,
		// Token: 0x04004C01 RID: 19457
		ChangeEntityCamp,
		// Token: 0x04004C02 RID: 19458
		TrapDefenseChangeMiniMap,
		// Token: 0x04004C03 RID: 19459
		TrapDefensePlayerOperationConstraint,
		// Token: 0x04004C04 RID: 19460
		RogueGotoNextFloor,
		// Token: 0x04004C05 RID: 19461
		RogueSelectRoom,
		// Token: 0x04004C06 RID: 19462
		RogueActivatePortal,
		// Token: 0x04004C07 RID: 19463
		RogueReceiveReward,
		// Token: 0x04004C08 RID: 19464
		ExecRiskHarvestEffect,
		// Token: 0x04004C09 RID: 19465
		MowingTowerGotoNextFloor,
		// Token: 0x04004C0A RID: 19466
		SlashAndTowerGotoNextFloor,
		// Token: 0x04004C0B RID: 19467
		RoleTowerGotoNextFloor,
		// Token: 0x04004C0C RID: 19468
		DangoAbyssActivatePortal,
		// Token: 0x04004C0D RID: 19469
		DangoAbyssGotoNextFloor,
		// Token: 0x04004C0E RID: 19470
		DangoAbyssCreateRewardTreasureBox,
		// Token: 0x04004C0F RID: 19471
		DangoAbyssReceiveReward,
		// Token: 0x04004C10 RID: 19472
		RoverRogueRoomFinish,
		// Token: 0x04004C11 RID: 19473
		RoverRogueActivate,
		// Token: 0x04004C12 RID: 19474
		RoverRogueCreateRoomReward,
		// Token: 0x04004C13 RID: 19475
		EnableActor,
		// Token: 0x04004C14 RID: 19476
		ModifyActorMaterial,
		// Token: 0x04004C15 RID: 19477
		SpecialOpModifyActorMaterialParamBySplineProgress,
		// Token: 0x04004C16 RID: 19478
		ModifyActorMedia,
		// Token: 0x04004C17 RID: 19479
		ToggleAirWall,
		// Token: 0x04004C18 RID: 19480
		SetDataLayerTransitions,
		// Token: 0x04004C19 RID: 19481
		TriggerCameraShake,
		// Token: 0x04004C1A RID: 19482
		TriggerGamepadShake,
		// Token: 0x04004C1B RID: 19483
		CreatePrefab,
		// Token: 0x04004C1C RID: 19484
		DestroyPrefab,
		// Token: 0x04004C1D RID: 19485
		ExecBattleAction,
		// Token: 0x04004C1E RID: 19486
		ExecClientBattleAction,
		// Token: 0x04004C1F RID: 19487
		RecoverDurability,
		// Token: 0x04004C20 RID: 19488
		SetRegionConfig,
		// Token: 0x04004C21 RID: 19489
		SetJigsawItem,
		// Token: 0x04004C22 RID: 19490
		SetJigsawFoundation,
		// Token: 0x04004C23 RID: 19491
		ResetEntity,
		// Token: 0x04004C24 RID: 19492
		PlayDynamicSettlement,
		// Token: 0x04004C25 RID: 19493
		SetInteractionLockState,
		// Token: 0x04004C26 RID: 19494
		FinishCondition,
		// Token: 0x04004C27 RID: 19495
		ClearEntityVisibleTag,
		// Token: 0x04004C28 RID: 19496
		SetEntityPos,
		// Token: 0x04004C29 RID: 19497
		ResetEntityPos,
		// Token: 0x04004C2A RID: 19498
		ServerSetPlayerPos,
		// Token: 0x04004C2B RID: 19499
		FixTeleControllerPos,
		// Token: 0x04004C2C RID: 19500
		CustomJson,
		// Token: 0x04004C2D RID: 19501
		FixFoundationRelation,
		// Token: 0x04004C2E RID: 19502
		FixShowTargetRange,
		// Token: 0x04004C2F RID: 19503
		TraceCurrentQuest,
		// Token: 0x04004C30 RID: 19504
		ForceOccupations,
		// Token: 0x04004C31 RID: 19505
		ServerForceEnableLevelPlay,
		// Token: 0x04004C32 RID: 19506
		TeleportDungeonPos,
		// Token: 0x04004C33 RID: 19507
		SetTimeScale,
		// Token: 0x04004C34 RID: 19508
		FixGetItem,
		// Token: 0x04004C35 RID: 19509
		SetAudioState,
		// Token: 0x04004C36 RID: 19510
		PerformerAiSplineMove,
		// Token: 0x04004C37 RID: 19511
		PerformerAiMoveTo,
		// Token: 0x04004C38 RID: 19512
		EnterPatrolState,
		// Token: 0x04004C39 RID: 19513
		PerformAiHideSelf,
		// Token: 0x04004C3A RID: 19514
		ExecResurrection,
		// Token: 0x04004C3B RID: 19515
		HideSpecificEntities,
		// Token: 0x04004C3C RID: 19516
		ShowSpecificEntities,
		// Token: 0x04004C3D RID: 19517
		HideTargetRange,
		// Token: 0x04004C3E RID: 19518
		ShowTargetRange,
		// Token: 0x04004C3F RID: 19519
		HideGroup,
		// Token: 0x04004C40 RID: 19520
		ShowHidedGroup,
		// Token: 0x04004C41 RID: 19521
		ReignsSetPropertyVisible,
		// Token: 0x04004C42 RID: 19522
		ReignsChangeBackground,
		// Token: 0x04004C43 RID: 19523
		ReignsChangePlayerName,
		// Token: 0x04004C44 RID: 19524
		ReignsCallCard,
		// Token: 0x04004C45 RID: 19525
		ReignsTriggerGuide,
		// Token: 0x04004C46 RID: 19526
		ReignsAddBuff,
		// Token: 0x04004C47 RID: 19527
		ReignsCheckSettle,
		// Token: 0x04004C48 RID: 19528
		HonamiStoryInteractPickUp,
		// Token: 0x04004C49 RID: 19529
		HonamiStoryReceiveCorruptedChestReward,
		// Token: 0x04004C4A RID: 19530
		HonamiStoryActivateSafeEvacuation,
		// Token: 0x04004C4B RID: 19531
		HonamiStoryGetItem,
		// Token: 0x04004C4C RID: 19532
		HonamiStorySetFormation,
		// Token: 0x04004C4D RID: 19533
		InfrActivityUpgradeInfrastructure,
		// Token: 0x04004C4E RID: 19534
		SetNpcGroupPerform,
		// Token: 0x04004C4F RID: 19535
		RemoveNpcGroupPerform,
		// Token: 0x04004C50 RID: 19536
		EnableEntityLookAt,
		// Token: 0x04004C51 RID: 19537
		DisableEntityLookAt,
		// Token: 0x04004C52 RID: 19538
		OverrideAiBehaviorTree,
		// Token: 0x04004C53 RID: 19539
		RestoreAiBehaviorTree,
		// Token: 0x04004C54 RID: 19540
		FlowDefineNpcGroupPerform,
		// Token: 0x04004C55 RID: 19541
		SeqEventAddTagToSelf,
		// Token: 0x04004C56 RID: 19542
		SeqEventFireBullet,
		// Token: 0x04004C57 RID: 19543
		SetMotorSpeed,
		// Token: 0x04004C58 RID: 19544
		StartMotorCruise,
		// Token: 0x04004C59 RID: 19545
		StopMotorCruise,
		// Token: 0x04004C5A RID: 19546
		DriveMotorInSpecConfig,
		// Token: 0x04004C5B RID: 19547
		MotorSoarInWindField,
		// Token: 0x04004C5C RID: 19548
		CollectSunSpirit,
		// Token: 0x04004C5D RID: 19549
		PerformSunSpiritGearRoundTrip,
		// Token: 0x04004C5E RID: 19550
		TriggerDeadeyeMode,
		// Token: 0x04004C5F RID: 19551
		OpenSystemBoardWithReturn,
		// Token: 0x04004C60 RID: 19552
		ResumeSystemRewardPopup,
		// Token: 0x04004C61 RID: 19553
		SummonEntity,
		// Token: 0x04004C62 RID: 19554
		DestroySummonedEntities,
		// Token: 0x04004C63 RID: 19555
		SetupMoraleSystem,
		// Token: 0x04004C64 RID: 19556
		GiantToggleModel,
		// Token: 0x04004C65 RID: 19557
		GiantTriggerResponse,
		// Token: 0x04004C66 RID: 19558
		ActivateGiantTotalProgressNode,
		// Token: 0x04004C67 RID: 19559
		RunActorCustomEvent,
		// Token: 0x04004C68 RID: 19560
		RequestSystemFunction,
		// Token: 0x04004C69 RID: 19561
		PlayWalkingOverlayMontage,
		// Token: 0x04004C6A RID: 19562
		ChangeNpcAbpState,
		// Token: 0x04004C6B RID: 19563
		CloseWalkingOverlayMontage,
		// Token: 0x04004C6C RID: 19564
		SetSkillButtonEffect,
		// Token: 0x04004C6D RID: 19565
		ScanEnrichmentArea,
		// Token: 0x04004C6E RID: 19566
		TriggerSystemRandomPlot,
		// Token: 0x04004C6F RID: 19567
		SetAudioEnable,
		// Token: 0x04004C70 RID: 19568
		PhoneSystemInteract,
		// Token: 0x04004C71 RID: 19569
		RollBlockGetReward,
		// Token: 0x04004C72 RID: 19570
		EnterMovieMode,
		// Token: 0x04004C73 RID: 19571
		ExitMovieMode,
		// Token: 0x04004C74 RID: 19572
		StartRoadNetworkNavigation,
		// Token: 0x04004C75 RID: 19573
		SetWayOccupancyState,
		// Token: 0x04004C76 RID: 19574
		SendSceneActorsEvent,
		// Token: 0x04004C77 RID: 19575
		ExecBpActorFunc,
		// Token: 0x04004C78 RID: 19576
		ResetPlayerPosWithPresentation,
		// Token: 0x04004C79 RID: 19577
		PlayerLookTowards,
		// Token: 0x04004C7A RID: 19578
		DrinksRollRoleRequirement,
		// Token: 0x04004C7B RID: 19579
		SetBlendAnim,
		// Token: 0x04004C7C RID: 19580
		ReportTrackingEvent,
		// Token: 0x04004C7D RID: 19581
		TetrisThrowBlock,
		// Token: 0x04004C7E RID: 19582
		TetrisGameComplete,
		// Token: 0x04004C7F RID: 19583
		TetrisTriggerDelayFall,
		// Token: 0x04004C80 RID: 19584
		BossPilingRandomBuff,
		// Token: 0x04004C81 RID: 19585
		BossPilingEnterNextInst,
		// Token: 0x04004C82 RID: 19586
		DollGrabItemDelivery,
		// Token: 0x04004C83 RID: 19587
		AvgPlayRoleAction,
		// Token: 0x04004C84 RID: 19588
		AvgMoveRole,
		// Token: 0x04004C85 RID: 19589
		AvgFocusRole,
		// Token: 0x04004C86 RID: 19590
		AvgShakeUi,
		// Token: 0x04004C87 RID: 19591
		DestroyDynamicEntities,
		// Token: 0x04004C88 RID: 19592
		SheriffUnlockClue,
		// Token: 0x04004C89 RID: 19593
		SheriffUnlockProgress,
		// Token: 0x04004C8A RID: 19594
		SheriffChangeCriminalState,
		// Token: 0x04004C8B RID: 19595
		SheriffChangeCriminalIdentity,
		// Token: 0x04004C8C RID: 19596
		SheriffUnlockEnding,
		// Token: 0x04004C8D RID: 19597
		SetSubScreenMode,
		// Token: 0x04004C8E RID: 19598
		ClientSetSeasonState,
		// Token: 0x04004C8F RID: 19599
		SeasonWeatherSetRotationLock,
		// Token: 0x04004C90 RID: 19600
		SeasonWeatherChangeTo,
		// Token: 0x04004C91 RID: 19601
		SeasonWeatherUnlockSpecial,
		// Token: 0x04004C92 RID: 19602
		ToggleDragActorPlay,
		// Token: 0x04004C93 RID: 19603
		SetTargetElementalAbility,
		// Token: 0x04004C94 RID: 19604
		ToggleEntityElementalAbility,
		// Token: 0x04004C95 RID: 19605
		CaptureElementalBox,
		// Token: 0x04004C96 RID: 19606
		ChangeElementalBoxState,
		// Token: 0x04004C97 RID: 19607
		SetElementalBoxToTarget,
		// Token: 0x04004C98 RID: 19608
		DarkTideSetMapMarkState,
		// Token: 0x04004C99 RID: 19609
		OverrideAbpAnimScheme,
		// Token: 0x04004C9A RID: 19610
		HandBookModifySystemProgress,
		// Token: 0x04004C9B RID: 19611
		ClientExecEntityPrefabAction,
		// Token: 0x04004C9C RID: 19612
		LiveSetUi,
		// Token: 0x04004C9D RID: 19613
		LiveSetDanmaku,
		// Token: 0x04004C9E RID: 19614
		LiveSetParam,
		// Token: 0x04004C9F RID: 19615
		LiveSetSc
	}
}
