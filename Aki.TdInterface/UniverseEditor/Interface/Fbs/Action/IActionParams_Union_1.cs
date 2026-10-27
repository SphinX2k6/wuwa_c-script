using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200608C RID: 24716
	public enum IActionParams_Union_1 : byte
	{
		// Token: 0x04010366 RID: 66406
		NONE,
		// Token: 0x04010367 RID: 66407
		ISetSportsState,
		// Token: 0x04010368 RID: 66408
		ISetExploreState,
		// Token: 0x04010369 RID: 66409
		IModifyActorMaterial,
		// Token: 0x0401036A RID: 66410
		IModifyActorMaterialParamBySplineProgress,
		// Token: 0x0401036B RID: 66411
		IModifyActorMedia,
		// Token: 0x0401036C RID: 66412
		IPlayLevelSequence,
		// Token: 0x0401036D RID: 66413
		IEnableTakePhotoClip,
		// Token: 0x0401036E RID: 66414
		IToggleAirWall,
		// Token: 0x0401036F RID: 66415
		ITriggerCameraShake,
		// Token: 0x04010370 RID: 66416
		ITriggerGamepadShake,
		// Token: 0x04010371 RID: 66417
		IPlayRegisteredMontage,
		// Token: 0x04010372 RID: 66418
		ICreatePrefab,
		// Token: 0x04010373 RID: 66419
		IDestroyPrefab,
		// Token: 0x04010374 RID: 66420
		ISetDataLayerTransitions,
		// Token: 0x04010375 RID: 66421
		IEnableAoiNotify,
		// Token: 0x04010376 RID: 66422
		IRecoverDurability,
		// Token: 0x04010377 RID: 66423
		ISetPlayerOperationRestriction,
		// Token: 0x04010378 RID: 66424
		IEnableAllPlayerOperation,
		// Token: 0x04010379 RID: 66425
		IDisableAllPlayerOperation,
		// Token: 0x0401037A RID: 66426
		IDisableModulePlayerOperation,
		// Token: 0x0401037B RID: 66427
		IClientSetPlayerOperationRestriction,
		// Token: 0x0401037C RID: 66428
		IClientEnableAllPlayerOperation,
		// Token: 0x0401037D RID: 66429
		IClientDisableAllPlayerOperation,
		// Token: 0x0401037E RID: 66430
		IClientDisableModulePlayerOperation,
		// Token: 0x0401037F RID: 66431
		IEnableFunction,
		// Token: 0x04010380 RID: 66432
		ITeleportDungeonFunction,
		// Token: 0x04010381 RID: 66433
		IMotorRadioUiFunction,
		// Token: 0x04010382 RID: 66434
		IInteractiveItemsFunction,
		// Token: 0x04010383 RID: 66435
		IEnableClientFunction,
		// Token: 0x04010384 RID: 66436
		IHealthBarDisplayClientFunction,
		// Token: 0x04010385 RID: 66437
		IChangeEntityPrefabPerformance,
		// Token: 0x04010386 RID: 66438
		IChangeTargetEntityPrefabPerformance,
		// Token: 0x04010387 RID: 66439
		IChangeSelfEntityPrefabPerformance,
		// Token: 0x04010388 RID: 66440
		IModifySceneItemAttributeTag,
		// Token: 0x04010389 RID: 66441
		IModifySelfSceneItemAttributeTag,
		// Token: 0x0401038A RID: 66442
		IModifyTargetSceneItemAttributeTag,
		// Token: 0x0401038B RID: 66443
		IClientModifyTargetTag,
		// Token: 0x0401038C RID: 66444
		IToggleMapMarkState,
		// Token: 0x0401038D RID: 66445
		IShowMapMark,
		// Token: 0x0401038E RID: 66446
		IHideMapMark,
		// Token: 0x0401038F RID: 66447
		IDisableMapMark,
		// Token: 0x04010390 RID: 66448
		IFocusOnMapMarkAction,
		// Token: 0x04010391 RID: 66449
		IEnableTemporaryTeleport,
		// Token: 0x04010392 RID: 66450
		ISetRegionConfig,
		// Token: 0x04010393 RID: 66451
		ISetRegionMpc,
		// Token: 0x04010394 RID: 66452
		ISetJigsawItem,
		// Token: 0x04010395 RID: 66453
		ISetJigsawFoundation,
		// Token: 0x04010396 RID: 66454
		IToggleHighlightExploreUi,
		// Token: 0x04010397 RID: 66455
		IShowHighlightExploreSkillIcon,
		// Token: 0x04010398 RID: 66456
		IHideHighlightExploreSkillIcon,
		// Token: 0x04010399 RID: 66457
		IToggleAndHighlightItem,
		// Token: 0x0401039A RID: 66458
		IResetEntity,
		// Token: 0x0401039B RID: 66459
		IResetLevelPlay,
		// Token: 0x0401039C RID: 66460
		IPlayDynamicSettlement,
		// Token: 0x0401039D RID: 66461
		ISetInteractionLockState,
		// Token: 0x0401039E RID: 66462
		ISetAudioState,
		// Token: 0x0401039F RID: 66463
		IPerformerAiSplineMove,
		// Token: 0x040103A0 RID: 66464
		IPerformerAiMoveTo,
		// Token: 0x040103A1 RID: 66465
		IAddTrialFollowShooter,
		// Token: 0x040103A2 RID: 66466
		IRemoveTrialFollowShooter,
		// Token: 0x040103A3 RID: 66467
		IEnableFollowShooterAbility,
		// Token: 0x040103A4 RID: 66468
		IClientFollowShooterLeisureInteract,
		// Token: 0x040103A5 RID: 66469
		ICustomJson,
		// Token: 0x040103A6 RID: 66470
		IExecResurrection,
		// Token: 0x040103A7 RID: 66471
		IOpenSystemBoardWithReturn,
		// Token: 0x040103A8 RID: 66472
		IResumeSystemRewardPopup,
		// Token: 0x040103A9 RID: 66473
		IExecRiskHarvestEffect,
		// Token: 0x040103AA RID: 66474
		ISetTeleControl,
		// Token: 0x040103AB RID: 66475
		IMowingTowerGotoNextFloor,
		// Token: 0x040103AC RID: 66476
		ISlashAndTowerGotoNextFloor,
		// Token: 0x040103AD RID: 66477
		IRoleTowerGotoNextFloor,
		// Token: 0x040103AE RID: 66478
		IVehicleEnter,
		// Token: 0x040103AF RID: 66479
		IEnterNpcVehicle,
		// Token: 0x040103B0 RID: 66480
		IVehicleExitPlayer,
		// Token: 0x040103B1 RID: 66481
		IVehicleExitNpc,
		// Token: 0x040103B2 RID: 66482
		ITeleportVehicle,
		// Token: 0x040103B3 RID: 66483
		IClientTeleportVehicle,
		// Token: 0x040103B4 RID: 66484
		IVehiclePlayPassengerVoice,
		// Token: 0x040103B5 RID: 66485
		IVehicleWaterfallClimbing,
		// Token: 0x040103B6 RID: 66486
		ITeleportToAndEnterVehicle,
		// Token: 0x040103B7 RID: 66487
		IVehicleMoveWithPathLine,
		// Token: 0x040103B8 RID: 66488
		IVehicleSprint,
		// Token: 0x040103B9 RID: 66489
		IOpenQteAction,
		// Token: 0x040103BA RID: 66490
		IPlayerInput,
		// Token: 0x040103BB RID: 66491
		IPreloadAction,
		// Token: 0x040103BC RID: 66492
		IRemovePreloadResourceAction,
		// Token: 0x040103BD RID: 66493
		IExecAlertSystemAction,
		// Token: 0x040103BE RID: 66494
		ISetSpineAnimation,
		// Token: 0x040103BF RID: 66495
		IChangeEntityCamp,
		// Token: 0x040103C0 RID: 66496
		IRecordDungeonEvent,
		// Token: 0x040103C1 RID: 66497
		IDangoAbyssGotoNextFloor,
		// Token: 0x040103C2 RID: 66498
		IDangoAbyssCreateRewardTreasureBox,
		// Token: 0x040103C3 RID: 66499
		IDangoAbyssActivatePortal,
		// Token: 0x040103C4 RID: 66500
		IDangoAbyssReceiveReward,
		// Token: 0x040103C5 RID: 66501
		IRoverRogueActivate,
		// Token: 0x040103C6 RID: 66502
		IRoverRogueRoomFinish,
		// Token: 0x040103C7 RID: 66503
		IRoverRogueCreateRoomReward,
		// Token: 0x040103C8 RID: 66504
		IGuestOperateUiAnimation,
		// Token: 0x040103C9 RID: 66505
		ISlideRailStart,
		// Token: 0x040103CA RID: 66506
		ISlideRailEnd,
		// Token: 0x040103CB RID: 66507
		ISlidePerformStart,
		// Token: 0x040103CC RID: 66508
		IBvbSendSystemEvent,
		// Token: 0x040103CD RID: 66509
		IBvbSendAiEvent,
		// Token: 0x040103CE RID: 66510
		IBvbPlayDialog,
		// Token: 0x040103CF RID: 66511
		IBvbPlayerOperationConstraint,
		// Token: 0x040103D0 RID: 66512
		IBvbSkipChallenge,
		// Token: 0x040103D1 RID: 66513
		IActiveAntiGravitySafePoint,
		// Token: 0x040103D2 RID: 66514
		ISummonEntity,
		// Token: 0x040103D3 RID: 66515
		IDestroySummonedEntities,
		// Token: 0x040103D4 RID: 66516
		ISetupMoraleSystem,
		// Token: 0x040103D5 RID: 66517
		IGiantToggleModel,
		// Token: 0x040103D6 RID: 66518
		IGiantTriggerResponse,
		// Token: 0x040103D7 RID: 66519
		IActivateGiantTotalProgressNode,
		// Token: 0x040103D8 RID: 66520
		IRunActorCustomEvent,
		// Token: 0x040103D9 RID: 66521
		ITriggerSpecificScanEffect,
		// Token: 0x040103DA RID: 66522
		ISendClientEvent,
		// Token: 0x040103DB RID: 66523
		IScanEnrichmentArea,
		// Token: 0x040103DC RID: 66524
		IRequestSystemFunction,
		// Token: 0x040103DD RID: 66525
		IReignsSetPropertyVisible,
		// Token: 0x040103DE RID: 66526
		IReignsChangeBackground,
		// Token: 0x040103DF RID: 66527
		IReignsSetUiEffect,
		// Token: 0x040103E0 RID: 66528
		IReignsChangePlayerName,
		// Token: 0x040103E1 RID: 66529
		IReignsCallCard,
		// Token: 0x040103E2 RID: 66530
		IReignsTriggerGuide,
		// Token: 0x040103E3 RID: 66531
		IReignsAddBuff,
		// Token: 0x040103E4 RID: 66532
		IReignsCheckSettle,
		// Token: 0x040103E5 RID: 66533
		ISetNpcGroupPerform,
		// Token: 0x040103E6 RID: 66534
		IRemoveNpcGroupPerform,
		// Token: 0x040103E7 RID: 66535
		IEnableEntityLookAt,
		// Token: 0x040103E8 RID: 66536
		IDisableEntityLookAt,
		// Token: 0x040103E9 RID: 66537
		IOverrideAiBehaviorTree,
		// Token: 0x040103EA RID: 66538
		IRestoreAiBehaviorTree,
		// Token: 0x040103EB RID: 66539
		IFlowDefineNpcGroupPerform,
		// Token: 0x040103EC RID: 66540
		ISeqEventAddTagToSelf,
		// Token: 0x040103ED RID: 66541
		ISeqEventFireBullet,
		// Token: 0x040103EE RID: 66542
		ITrapDefenseChangeMiniMap,
		// Token: 0x040103EF RID: 66543
		ITrapDefensePlayerOperationConstraint,
		// Token: 0x040103F0 RID: 66544
		IHonamiStoryInteractPickUp,
		// Token: 0x040103F1 RID: 66545
		IHonamiStoryReceiveCorruptedChestReward,
		// Token: 0x040103F2 RID: 66546
		IHonamiStoryActivateSafeEvacuation,
		// Token: 0x040103F3 RID: 66547
		IHonamiStorySetFormation,
		// Token: 0x040103F4 RID: 66548
		IHonamiStoryGetItem,
		// Token: 0x040103F5 RID: 66549
		IInfrActivityUpgradeInfrastructure,
		// Token: 0x040103F6 RID: 66550
		IPlayWalkingOverlayMontage,
		// Token: 0x040103F7 RID: 66551
		IEnableKey4Func,
		// Token: 0x040103F8 RID: 66552
		IChangeNpcAbpState,
		// Token: 0x040103F9 RID: 66553
		IOverrideAbpAnimScheme,
		// Token: 0x040103FA RID: 66554
		ICloseWalkingOverlayMontage,
		// Token: 0x040103FB RID: 66555
		ISetMotorSpeed,
		// Token: 0x040103FC RID: 66556
		IVehicleSetSpeedImmediately,
		// Token: 0x040103FD RID: 66557
		IStartMotorCruise,
		// Token: 0x040103FE RID: 66558
		IStopMotorCruise,
		// Token: 0x040103FF RID: 66559
		IDriveMotorInSpecConfig,
		// Token: 0x04010400 RID: 66560
		IMotorSoarInWindField,
		// Token: 0x04010401 RID: 66561
		ISetSkillBtnEffect,
		// Token: 0x04010402 RID: 66562
		ICollectSunSpirit,
		// Token: 0x04010403 RID: 66563
		IPerformSunSpiritGearRoundTrip,
		// Token: 0x04010404 RID: 66564
		ITriggerDeadeyeMode,
		// Token: 0x04010405 RID: 66565
		ITriggerSystemRandomPlot,
		// Token: 0x04010406 RID: 66566
		ISetAudioEnable,
		// Token: 0x04010407 RID: 66567
		IPhoneSystemInteract,
		// Token: 0x04010408 RID: 66568
		IRollBlockGetReward,
		// Token: 0x04010409 RID: 66569
		IEnterMovieMode,
		// Token: 0x0401040A RID: 66570
		IExitMovieMode,
		// Token: 0x0401040B RID: 66571
		IStartRoadNetworkNavigation,
		// Token: 0x0401040C RID: 66572
		ISetWayOccupancyState,
		// Token: 0x0401040D RID: 66573
		IEnterPatrolState,
		// Token: 0x0401040E RID: 66574
		IPerformAiHideSelf,
		// Token: 0x0401040F RID: 66575
		ISendSceneActorEvent,
		// Token: 0x04010410 RID: 66576
		IExecBpActorFunc,
		// Token: 0x04010411 RID: 66577
		IResetPlayerPosWithPresentation,
		// Token: 0x04010412 RID: 66578
		IDrinksRollRoleRequirement,
		// Token: 0x04010413 RID: 66579
		ISetBlendAnim,
		// Token: 0x04010414 RID: 66580
		IReportTrackingEvent,
		// Token: 0x04010415 RID: 66581
		ITetrisThrowBlock,
		// Token: 0x04010416 RID: 66582
		ITetrisGameComplete,
		// Token: 0x04010417 RID: 66583
		ITetrisTriggerDelayFall,
		// Token: 0x04010418 RID: 66584
		IBossPilingRandomBuff,
		// Token: 0x04010419 RID: 66585
		IBossPilingEnterNextInst,
		// Token: 0x0401041A RID: 66586
		IOpenQuickHackSystem,
		// Token: 0x0401041B RID: 66587
		IDollGrabItemDelivery,
		// Token: 0x0401041C RID: 66588
		ISheriffUnlockClue,
		// Token: 0x0401041D RID: 66589
		ISheriffUnlockProgress,
		// Token: 0x0401041E RID: 66590
		ISheriffChangeCriminalState,
		// Token: 0x0401041F RID: 66591
		ISheriffChangeCriminalIdentity,
		// Token: 0x04010420 RID: 66592
		ISheriffUnlockEnding,
		// Token: 0x04010421 RID: 66593
		ISetTargetElementalAbility,
		// Token: 0x04010422 RID: 66594
		IToggleEntityElementalAbility,
		// Token: 0x04010423 RID: 66595
		ICaptureElementalBox,
		// Token: 0x04010424 RID: 66596
		IChangeElementalBoxState,
		// Token: 0x04010425 RID: 66597
		ISetElementalBoxToTarget
	}
}
