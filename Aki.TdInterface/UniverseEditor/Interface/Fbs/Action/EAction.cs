using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006546 RID: 25926
	public enum EAction : ushort
	{
		// Token: 0x0401076D RID: 67437
		Undefined,
		// Token: 0x0401076E RID: 67438
		Activate,
		// Token: 0x0401076F RID: 67439
		AccpetCurrentQuest,
		// Token: 0x04010770 RID: 67440
		AddFlowInteractOption,
		// Token: 0x04010771 RID: 67441
		SetTime,
		// Token: 0x04010772 RID: 67442
		AwakeEntity,
		// Token: 0x04010773 RID: 67443
		CalculateVar,
		// Token: 0x04010774 RID: 67444
		RandomVar,
		// Token: 0x04010775 RID: 67445
		CallByCondition,
		// Token: 0x04010776 RID: 67446
		CallFunction,
		// Token: 0x04010777 RID: 67447
		CameraLookAt,
		// Token: 0x04010778 RID: 67448
		StopCameraLookAt,
		// Token: 0x04010779 RID: 67449
		EnableHostility,
		// Token: 0x0401077A RID: 67450
		ChangeActorState,
		// Token: 0x0401077B RID: 67451
		ChangeBehaviorState,
		// Token: 0x0401077C RID: 67452
		ChangeEntityState,
		// Token: 0x0401077D RID: 67453
		ChangeNpcPerformState,
		// Token: 0x0401077E RID: 67454
		ChangeInteractOptionText,
		// Token: 0x0401077F RID: 67455
		ChangeOtherState,
		// Token: 0x04010780 RID: 67456
		ChangeRandomState,
		// Token: 0x04010781 RID: 67457
		ChangeState,
		// Token: 0x04010782 RID: 67458
		Collect,
		// Token: 0x04010783 RID: 67459
		CompleteChildQuest,
		// Token: 0x04010784 RID: 67460
		Destroy,
		// Token: 0x04010785 RID: 67461
		DestroyAllChild,
		// Token: 0x04010786 RID: 67462
		DestroyEntity,
		// Token: 0x04010787 RID: 67463
		DestroySelf,
		// Token: 0x04010788 RID: 67464
		DoCalculate,
		// Token: 0x04010789 RID: 67465
		EnableFunction,
		// Token: 0x0401078A RID: 67466
		EnableClientFunction,
		// Token: 0x0401078B RID: 67467
		FaceToPos,
		// Token: 0x0401078C RID: 67468
		FinishDoInteract,
		// Token: 0x0401078D RID: 67469
		FinishState,
		// Token: 0x0401078E RID: 67470
		FinishTalk,
		// Token: 0x0401078F RID: 67471
		GetItem,
		// Token: 0x04010790 RID: 67472
		DestroyQuestItem,
		// Token: 0x04010791 RID: 67473
		GuideTrigger,
		// Token: 0x04010792 RID: 67474
		CompleteGuide,
		// Token: 0x04010793 RID: 67475
		Invoke,
		// Token: 0x04010794 RID: 67476
		JumpTalk,
		// Token: 0x04010795 RID: 67477
		Log,
		// Token: 0x04010796 RID: 67478
		MoveToPos,
		// Token: 0x04010797 RID: 67479
		MoveWithSpline,
		// Token: 0x04010798 RID: 67480
		NewMoveWithSpline,
		// Token: 0x04010799 RID: 67481
		StopNewMoveWithSpline,
		// Token: 0x0401079A RID: 67482
		CharacterMoveToPoint,
		// Token: 0x0401079B RID: 67483
		PlayerMoveToPoint,
		// Token: 0x0401079C RID: 67484
		NpcMoveToPoint,
		// Token: 0x0401079D RID: 67485
		OpenSystemBoard,
		// Token: 0x0401079E RID: 67486
		OpenSystemFunction,
		// Token: 0x0401079F RID: 67487
		PlayCustomSequence,
		// Token: 0x040107A0 RID: 67488
		PlayerLookAt,
		// Token: 0x040107A1 RID: 67489
		EntityLookAt,
		// Token: 0x040107A2 RID: 67490
		EntityTurnTo,
		// Token: 0x040107A3 RID: 67491
		CharacterLookAt,
		// Token: 0x040107A4 RID: 67492
		PlayFlow,
		// Token: 0x040107A5 RID: 67493
		PlayMovie,
		// Token: 0x040107A6 RID: 67494
		PlayEffect,
		// Token: 0x040107A7 RID: 67495
		PlayEffect2,
		// Token: 0x040107A8 RID: 67496
		RemoveEffect,
		// Token: 0x040107A9 RID: 67497
		PlayMontage,
		// Token: 0x040107AA RID: 67498
		PlayRegisteredMontage,
		// Token: 0x040107AB RID: 67499
		PlaySequenceData,
		// Token: 0x040107AC RID: 67500
		PlayerInput,
		// Token: 0x040107AD RID: 67501
		Prompt,
		// Token: 0x040107AE RID: 67502
		AddPlayBubble,
		// Token: 0x040107AF RID: 67503
		PlayBubble,
		// Token: 0x040107B0 RID: 67504
		ClearPlayBubble,
		// Token: 0x040107B1 RID: 67505
		EnableAI,
		// Token: 0x040107B2 RID: 67506
		RemoveFlowInteractOption,
		// Token: 0x040107B3 RID: 67507
		SendNpcMail,
		// Token: 0x040107B4 RID: 67508
		SetBehaviorIsPaused,
		// Token: 0x040107B5 RID: 67509
		SetCameraMode,
		// Token: 0x040107B6 RID: 67510
		SetEntityVisible,
		// Token: 0x040107B7 RID: 67511
		SetEntityClientVisible,
		// Token: 0x040107B8 RID: 67512
		SetEntityClientVisibleSave,
		// Token: 0x040107B9 RID: 67513
		SetHeadIconVisible,
		// Token: 0x040107BA RID: 67514
		SetMoveSpeed,
		// Token: 0x040107BB RID: 67515
		SetNumberVar,
		// Token: 0x040107BC RID: 67516
		SetPlotMode,
		// Token: 0x040107BD RID: 67517
		SetPos,
		// Token: 0x040107BE RID: 67518
		SetVar,
		// Token: 0x040107BF RID: 67519
		SetActorVar,
		// Token: 0x040107C0 RID: 67520
		ShowCenterText,
		// Token: 0x040107C1 RID: 67521
		ShowMessage,
		// Token: 0x040107C2 RID: 67522
		ShowTalk,
		// Token: 0x040107C3 RID: 67523
		ModifySceneUiSubtitle,
		// Token: 0x040107C4 RID: 67524
		SimpleMove,
		// Token: 0x040107C5 RID: 67525
		SpawnChild,
		// Token: 0x040107C6 RID: 67526
		SpawnEntity,
		// Token: 0x040107C7 RID: 67527
		SyncVarToActorState,
		// Token: 0x040107C8 RID: 67528
		Wait,
		// Token: 0x040107C9 RID: 67529
		ModifyEntityDecoration,
		// Token: 0x040107CA RID: 67530
		AddBuffToEntity,
		// Token: 0x040107CB RID: 67531
		AddBuffToPlayer,
		// Token: 0x040107CC RID: 67532
		AddBuffToFollowShooter,
		// Token: 0x040107CD RID: 67533
		LockEntity,
		// Token: 0x040107CE RID: 67534
		UnlockEntity,
		// Token: 0x040107CF RID: 67535
		SetForceLock,
		// Token: 0x040107D0 RID: 67536
		SetAreaState,
		// Token: 0x040107D1 RID: 67537
		SetWuYinQuState,
		// Token: 0x040107D2 RID: 67538
		RemoveBuffFromEntity,
		// Token: 0x040107D3 RID: 67539
		RemoveBuffFromPlayer,
		// Token: 0x040107D4 RID: 67540
		SetPlayerMoveControl,
		// Token: 0x040107D5 RID: 67541
		UnlockTeleportTrigger,
		// Token: 0x040107D6 RID: 67542
		ChangeTeamPosition,
		// Token: 0x040107D7 RID: 67543
		ClientChangeTeamPosition,
		// Token: 0x040107D8 RID: 67544
		ClaimLevelPlayReward,
		// Token: 0x040107D9 RID: 67545
		ClaimDynamicEntityReward,
		// Token: 0x040107DA RID: 67546
		SetReviveRegion,
		// Token: 0x040107DB RID: 67547
		PromptQuestChapterUI,
		// Token: 0x040107DC RID: 67548
		FireBullet,
		// Token: 0x040107DD RID: 67549
		FireBulletEffect,
		// Token: 0x040107DE RID: 67550
		SetAssistCharacterPos,
		// Token: 0x040107DF RID: 67551
		SetPlayerPos,
		// Token: 0x040107E0 RID: 67552
		ClientSetPlayerPos,
		// Token: 0x040107E1 RID: 67553
		ClientPreEnableSubLevels,
		// Token: 0x040107E2 RID: 67554
		ChangeSelfEntityState,
		// Token: 0x040107E3 RID: 67555
		InterludeActions,
		// Token: 0x040107E4 RID: 67556
		AddBuffToTriggeredEntity,
		// Token: 0x040107E5 RID: 67557
		RemoveBuffToTriggeredEntity,
		// Token: 0x040107E6 RID: 67558
		DetectTrigger,
		// Token: 0x040107E7 RID: 67559
		ItemFoundationMatch,
		// Token: 0x040107E8 RID: 67560
		SetBattleState,
		// Token: 0x040107E9 RID: 67561
		WaitBattleCondition,
		// Token: 0x040107EA RID: 67562
		SendBattleTag,
		// Token: 0x040107EB RID: 67563
		UnlockSystemItem,
		// Token: 0x040107EC RID: 67564
		ClientUnlockAchievementSystemItem,
		// Token: 0x040107ED RID: 67565
		RunActions,
		// Token: 0x040107EE RID: 67566
		CommonTip,
		// Token: 0x040107EF RID: 67567
		EndCommonTip,
		// Token: 0x040107F0 RID: 67568
		CommonTip2,
		// Token: 0x040107F1 RID: 67569
		EnableNearbyTracking,
		// Token: 0x040107F2 RID: 67570
		EnableLevelPlay,
		// Token: 0x040107F3 RID: 67571
		UnLimitPlayerOperation,
		// Token: 0x040107F4 RID: 67572
		LimitPlayerOperation,
		// Token: 0x040107F5 RID: 67573
		SetPlayerOperationRestriction,
		// Token: 0x040107F6 RID: 67574
		ClientSetPlayerOperationRestriction,
		// Token: 0x040107F7 RID: 67575
		LeisureInteract,
		// Token: 0x040107F8 RID: 67576
		NpcLeisureInteract,
		// Token: 0x040107F9 RID: 67577
		ChangePhantom,
		// Token: 0x040107FA RID: 67578
		RestorePhantom,
		// Token: 0x040107FB RID: 67579
		TakePlotPhoto,
		// Token: 0x040107FC RID: 67580
		OpenQte,
		// Token: 0x040107FD RID: 67581
		Preload,
		// Token: 0x040107FE RID: 67582
		RemovePreloadResource,
		// Token: 0x040107FF RID: 67583
		ExecAlertSystemAction,
		// Token: 0x04010800 RID: 67584
		RecordDungeonEvent,
		// Token: 0x04010801 RID: 67585
		ResetLevelPlay,
		// Token: 0x04010802 RID: 67586
		SetAreaTimeState,
		// Token: 0x04010803 RID: 67587
		GetRewardByInteract,
		// Token: 0x04010804 RID: 67588
		WaitUntilLevelSequenceReachMark,
		// Token: 0x04010805 RID: 67589
		EnableKey4Func,
		// Token: 0x04010806 RID: 67590
		OpenQuickHackSystem,
		// Token: 0x04010807 RID: 67591
		GuestOperateUiAnimation,
		// Token: 0x04010808 RID: 67592
		VehicleEnter,
		// Token: 0x04010809 RID: 67593
		VehicleEnterNpc,
		// Token: 0x0401080A RID: 67594
		VehicleExitPlayer,
		// Token: 0x0401080B RID: 67595
		VehicleExitNpc,
		// Token: 0x0401080C RID: 67596
		VehicleTeleport,
		// Token: 0x0401080D RID: 67597
		ClientVehicleTeleport,
		// Token: 0x0401080E RID: 67598
		VehiclePlayPassengerVoice,
		// Token: 0x0401080F RID: 67599
		VehicleWaterfallClimbing,
		// Token: 0x04010810 RID: 67600
		TeleportToAndEnterVehicle,
		// Token: 0x04010811 RID: 67601
		VehicleMoveWithPathLine,
		// Token: 0x04010812 RID: 67602
		VehicleSprint,
		// Token: 0x04010813 RID: 67603
		VehicleSetSpeedImmediately,
		// Token: 0x04010814 RID: 67604
		TeleportDungeon,
		// Token: 0x04010815 RID: 67605
		SettlementDungeon,
		// Token: 0x04010816 RID: 67606
		ClaimDungeonReward,
		// Token: 0x04010817 RID: 67607
		ExitDungeon,
		// Token: 0x04010818 RID: 67608
		UnlockDungeonEntry,
		// Token: 0x04010819 RID: 67609
		FinishDungeon,
		// Token: 0x0401081A RID: 67610
		StopUiScreenEffect,
		// Token: 0x0401081B RID: 67611
		StartFlowTemplate,
		// Token: 0x0401081C RID: 67612
		BeginFlowTemplate,
		// Token: 0x0401081D RID: 67613
		ChangeFlowTemplate,
		// Token: 0x0401081E RID: 67614
		SetFlowTemplate,
		// Token: 0x0401081F RID: 67615
		EndFlowTemplate,
		// Token: 0x04010820 RID: 67616
		CloseFlowTemplate,
		// Token: 0x04010821 RID: 67617
		SendAiEvent,
		// Token: 0x04010822 RID: 67618
		FadeInScreen,
		// Token: 0x04010823 RID: 67619
		FadeOutScreen,
		// Token: 0x04010824 RID: 67620
		ChangeFightTeam,
		// Token: 0x04010825 RID: 67621
		ManualOccupations,
		// Token: 0x04010826 RID: 67622
		AddTrialCharacter,
		// Token: 0x04010827 RID: 67623
		UpdateTrialCharacter,
		// Token: 0x04010828 RID: 67624
		RestoreTrialCharacter,
		// Token: 0x04010829 RID: 67625
		RemoveTrialCharacter,
		// Token: 0x0401082A RID: 67626
		AddGuestCharacter,
		// Token: 0x0401082B RID: 67627
		RemoveGuestCharacter,
		// Token: 0x0401082C RID: 67628
		AddTrialFollowShooter,
		// Token: 0x0401082D RID: 67629
		RemoveTrialFollowShooter,
		// Token: 0x0401082E RID: 67630
		EnableFollowShooterAbility,
		// Token: 0x0401082F RID: 67631
		FollowShooterLeisureInteract,
		// Token: 0x04010830 RID: 67632
		ClientFollowShooterLeisureInteract,
		// Token: 0x04010831 RID: 67633
		DestroyQuest,
		// Token: 0x04010832 RID: 67634
		SetCameraAnim,
		// Token: 0x04010833 RID: 67635
		RotatorEntity,
		// Token: 0x04010834 RID: 67636
		TraceSpline,
		// Token: 0x04010835 RID: 67637
		ToggleScanSplineEffect,
		// Token: 0x04010836 RID: 67638
		ChangeTimer,
		// Token: 0x04010837 RID: 67639
		ToggleTimerPauseState,
		// Token: 0x04010838 RID: 67640
		EnableSystem,
		// Token: 0x04010839 RID: 67641
		PostAkEvent,
		// Token: 0x0401083A RID: 67642
		MoveSceneItem,
		// Token: 0x0401083B RID: 67643
		StopSceneItemMove,
		// Token: 0x0401083C RID: 67644
		ChangeLiftTarget,
		// Token: 0x0401083D RID: 67645
		HideByRangeInFlow,
		// Token: 0x0401083E RID: 67646
		ShowAllHidedGroupInFlow,
		// Token: 0x0401083F RID: 67647
		OpenSimpleGameplay,
		// Token: 0x04010840 RID: 67648
		ToggleRideFlyingCarUiGameplay,
		// Token: 0x04010841 RID: 67649
		ChangeActorTalker,
		// Token: 0x04010842 RID: 67650
		SwitchSubLevels,
		// Token: 0x04010843 RID: 67651
		SwitchDataLayers,
		// Token: 0x04010844 RID: 67652
		ActivateResetPoint,
		// Token: 0x04010845 RID: 67653
		TeleportToLatestResetPoint,
		// Token: 0x04010846 RID: 67654
		SetWeather,
		// Token: 0x04010847 RID: 67655
		SetTimeLockState,
		// Token: 0x04010848 RID: 67656
		SetWeatherLockState,
		// Token: 0x04010849 RID: 67657
		AdjustPlayerCamera,
		// Token: 0x0401084A RID: 67658
		AdjustPlayerCameraGravity,
		// Token: 0x0401084B RID: 67659
		RestorePlayerCameraAdjustment,
		// Token: 0x0401084C RID: 67660
		EnterMovieCamera,
		// Token: 0x0401084D RID: 67661
		ExitMovieCamera,
		// Token: 0x0401084E RID: 67662
		ResetPlayerCameraFocus,
		// Token: 0x0401084F RID: 67663
		UsePhantomSkill,
		// Token: 0x04010850 RID: 67664
		ChangePhantomFormation,
		// Token: 0x04010851 RID: 67665
		RestorePhantomFormation,
		// Token: 0x04010852 RID: 67666
		EnterOrbitalCamera,
		// Token: 0x04010853 RID: 67667
		ExitOrbitalCamera,
		// Token: 0x04010854 RID: 67668
		EnableSplineMoveModel,
		// Token: 0x04010855 RID: 67669
		SetSportsState,
		// Token: 0x04010856 RID: 67670
		PlayLevelSequence,
		// Token: 0x04010857 RID: 67671
		EnableTakePhotoClip,
		// Token: 0x04010858 RID: 67672
		SetExploreState,
		// Token: 0x04010859 RID: 67673
		EnableAoiNotify,
		// Token: 0x0401085A RID: 67674
		ChangeEntityPrefabPerformance,
		// Token: 0x0401085B RID: 67675
		ModifySceneItemAttributeTag,
		// Token: 0x0401085C RID: 67676
		ClientModifyTargetTag,
		// Token: 0x0401085D RID: 67677
		ToggleMapMarkState,
		// Token: 0x0401085E RID: 67678
		FocusOnMapMark,
		// Token: 0x0401085F RID: 67679
		ToggleHighlightExploreUi,
		// Token: 0x04010860 RID: 67680
		EnableTemporaryTeleport,
		// Token: 0x04010861 RID: 67681
		SetTeleControl,
		// Token: 0x04010862 RID: 67682
		ActiveAntiGravitySafePoint,
		// Token: 0x04010863 RID: 67683
		TriggerSpecificScanEffect,
		// Token: 0x04010864 RID: 67684
		SendClientEvent,
		// Token: 0x04010865 RID: 67685
		ClearFishingCabinInSaleItems,
		// Token: 0x04010866 RID: 67686
		AcceptFishingEntrust,
		// Token: 0x04010867 RID: 67687
		DestroyFishingBoat,
		// Token: 0x04010868 RID: 67688
		SlideRailStart,
		// Token: 0x04010869 RID: 67689
		SlideRailEnd,
		// Token: 0x0401086A RID: 67690
		SlidePerformStart,
		// Token: 0x0401086B RID: 67691
		BvbSendSystemEvent,
		// Token: 0x0401086C RID: 67692
		BvbSendAiEvent,
		// Token: 0x0401086D RID: 67693
		BvbPlayDialog,
		// Token: 0x0401086E RID: 67694
		BvbPlayerOperationConstraint,
		// Token: 0x0401086F RID: 67695
		BvbSkipChallenge,
		// Token: 0x04010870 RID: 67696
		SetSpineAnimation,
		// Token: 0x04010871 RID: 67697
		ChangeEntityCamp,
		// Token: 0x04010872 RID: 67698
		TrapDefenseChangeMiniMap,
		// Token: 0x04010873 RID: 67699
		TrapDefensePlayerOperationConstraint,
		// Token: 0x04010874 RID: 67700
		RogueGotoNextFloor,
		// Token: 0x04010875 RID: 67701
		RogueSelectRoom,
		// Token: 0x04010876 RID: 67702
		RogueActivatePortal,
		// Token: 0x04010877 RID: 67703
		RogueReceiveReward,
		// Token: 0x04010878 RID: 67704
		ExecRiskHarvestEffect,
		// Token: 0x04010879 RID: 67705
		MowingTowerGotoNextFloor,
		// Token: 0x0401087A RID: 67706
		SlashAndTowerGotoNextFloor,
		// Token: 0x0401087B RID: 67707
		RoleTowerGotoNextFloor,
		// Token: 0x0401087C RID: 67708
		DangoAbyssActivatePortal,
		// Token: 0x0401087D RID: 67709
		DangoAbyssGotoNextFloor,
		// Token: 0x0401087E RID: 67710
		DangoAbyssCreateRewardTreasureBox,
		// Token: 0x0401087F RID: 67711
		DangoAbyssReceiveReward,
		// Token: 0x04010880 RID: 67712
		RoverRogueRoomFinish,
		// Token: 0x04010881 RID: 67713
		RoverRogueActivate,
		// Token: 0x04010882 RID: 67714
		RoverRogueCreateRoomReward,
		// Token: 0x04010883 RID: 67715
		EnableActor,
		// Token: 0x04010884 RID: 67716
		ModifyActorMaterial,
		// Token: 0x04010885 RID: 67717
		SpecialOpModifyActorMaterialParamBySplineProgress,
		// Token: 0x04010886 RID: 67718
		ModifyActorMedia,
		// Token: 0x04010887 RID: 67719
		ToggleAirWall,
		// Token: 0x04010888 RID: 67720
		SetDataLayerTransitions,
		// Token: 0x04010889 RID: 67721
		TriggerCameraShake,
		// Token: 0x0401088A RID: 67722
		TriggerGamepadShake,
		// Token: 0x0401088B RID: 67723
		CreatePrefab,
		// Token: 0x0401088C RID: 67724
		DestroyPrefab,
		// Token: 0x0401088D RID: 67725
		ExecBattleAction,
		// Token: 0x0401088E RID: 67726
		ExecClientBattleAction,
		// Token: 0x0401088F RID: 67727
		RecoverDurability,
		// Token: 0x04010890 RID: 67728
		SetRegionConfig,
		// Token: 0x04010891 RID: 67729
		SetJigsawItem,
		// Token: 0x04010892 RID: 67730
		SetJigsawFoundation,
		// Token: 0x04010893 RID: 67731
		ResetEntity,
		// Token: 0x04010894 RID: 67732
		PlayDynamicSettlement,
		// Token: 0x04010895 RID: 67733
		SetInteractionLockState,
		// Token: 0x04010896 RID: 67734
		FinishCondition,
		// Token: 0x04010897 RID: 67735
		ClearEntityVisibleTag,
		// Token: 0x04010898 RID: 67736
		SetEntityPos,
		// Token: 0x04010899 RID: 67737
		ResetEntityPos,
		// Token: 0x0401089A RID: 67738
		ServerSetPlayerPos,
		// Token: 0x0401089B RID: 67739
		FixTeleControllerPos,
		// Token: 0x0401089C RID: 67740
		CustomJson,
		// Token: 0x0401089D RID: 67741
		FixFoundationRelation,
		// Token: 0x0401089E RID: 67742
		FixShowTargetRange,
		// Token: 0x0401089F RID: 67743
		TraceCurrentQuest,
		// Token: 0x040108A0 RID: 67744
		ForceOccupations,
		// Token: 0x040108A1 RID: 67745
		ServerForceEnableLevelPlay,
		// Token: 0x040108A2 RID: 67746
		TeleportDungeonPos,
		// Token: 0x040108A3 RID: 67747
		SetTimeScale,
		// Token: 0x040108A4 RID: 67748
		FixGetItem,
		// Token: 0x040108A5 RID: 67749
		SetAudioState,
		// Token: 0x040108A6 RID: 67750
		PerformerAiSplineMove,
		// Token: 0x040108A7 RID: 67751
		PerformerAiMoveTo,
		// Token: 0x040108A8 RID: 67752
		EnterPatrolState,
		// Token: 0x040108A9 RID: 67753
		PerformAiHideSelf,
		// Token: 0x040108AA RID: 67754
		ExecResurrection,
		// Token: 0x040108AB RID: 67755
		HideSpecificEntities,
		// Token: 0x040108AC RID: 67756
		ShowSpecificEntities,
		// Token: 0x040108AD RID: 67757
		HideTargetRange,
		// Token: 0x040108AE RID: 67758
		ShowTargetRange,
		// Token: 0x040108AF RID: 67759
		HideGroup,
		// Token: 0x040108B0 RID: 67760
		ShowHidedGroup,
		// Token: 0x040108B1 RID: 67761
		ReignsSetPropertyVisible,
		// Token: 0x040108B2 RID: 67762
		ReignsChangeBackground,
		// Token: 0x040108B3 RID: 67763
		ReignsChangePlayerName,
		// Token: 0x040108B4 RID: 67764
		ReignsCallCard,
		// Token: 0x040108B5 RID: 67765
		ReignsTriggerGuide,
		// Token: 0x040108B6 RID: 67766
		ReignsAddBuff,
		// Token: 0x040108B7 RID: 67767
		ReignsCheckSettle,
		// Token: 0x040108B8 RID: 67768
		HonamiStoryInteractPickUp,
		// Token: 0x040108B9 RID: 67769
		HonamiStoryReceiveCorruptedChestReward,
		// Token: 0x040108BA RID: 67770
		HonamiStoryActivateSafeEvacuation,
		// Token: 0x040108BB RID: 67771
		HonamiStoryGetItem,
		// Token: 0x040108BC RID: 67772
		HonamiStorySetFormation,
		// Token: 0x040108BD RID: 67773
		InfrActivityUpgradeInfrastructure,
		// Token: 0x040108BE RID: 67774
		SetNpcGroupPerform,
		// Token: 0x040108BF RID: 67775
		RemoveNpcGroupPerform,
		// Token: 0x040108C0 RID: 67776
		EnableEntityLookAt,
		// Token: 0x040108C1 RID: 67777
		DisableEntityLookAt,
		// Token: 0x040108C2 RID: 67778
		OverrideAiBehaviorTree,
		// Token: 0x040108C3 RID: 67779
		RestoreAiBehaviorTree,
		// Token: 0x040108C4 RID: 67780
		FlowDefineNpcGroupPerform,
		// Token: 0x040108C5 RID: 67781
		SeqEventAddTagToSelf,
		// Token: 0x040108C6 RID: 67782
		SeqEventFireBullet,
		// Token: 0x040108C7 RID: 67783
		SetMotorSpeed,
		// Token: 0x040108C8 RID: 67784
		StartMotorCruise,
		// Token: 0x040108C9 RID: 67785
		StopMotorCruise,
		// Token: 0x040108CA RID: 67786
		DriveMotorInSpecConfig,
		// Token: 0x040108CB RID: 67787
		MotorSoarInWindField,
		// Token: 0x040108CC RID: 67788
		CollectSunSpirit,
		// Token: 0x040108CD RID: 67789
		PerformSunSpiritGearRoundTrip,
		// Token: 0x040108CE RID: 67790
		TriggerDeadeyeMode,
		// Token: 0x040108CF RID: 67791
		OpenSystemBoardWithReturn,
		// Token: 0x040108D0 RID: 67792
		ResumeSystemRewardPopup,
		// Token: 0x040108D1 RID: 67793
		SummonEntity,
		// Token: 0x040108D2 RID: 67794
		DestroySummonedEntities,
		// Token: 0x040108D3 RID: 67795
		SetupMoraleSystem,
		// Token: 0x040108D4 RID: 67796
		GiantToggleModel,
		// Token: 0x040108D5 RID: 67797
		GiantTriggerResponse,
		// Token: 0x040108D6 RID: 67798
		ActivateGiantTotalProgressNode,
		// Token: 0x040108D7 RID: 67799
		RunActorCustomEvent,
		// Token: 0x040108D8 RID: 67800
		RequestSystemFunction,
		// Token: 0x040108D9 RID: 67801
		PlayWalkingOverlayMontage,
		// Token: 0x040108DA RID: 67802
		ChangeNpcAbpState,
		// Token: 0x040108DB RID: 67803
		CloseWalkingOverlayMontage,
		// Token: 0x040108DC RID: 67804
		SetSkillButtonEffect,
		// Token: 0x040108DD RID: 67805
		ScanEnrichmentArea,
		// Token: 0x040108DE RID: 67806
		TriggerSystemRandomPlot,
		// Token: 0x040108DF RID: 67807
		SetAudioEnable,
		// Token: 0x040108E0 RID: 67808
		PhoneSystemInteract,
		// Token: 0x040108E1 RID: 67809
		RollBlockGetReward,
		// Token: 0x040108E2 RID: 67810
		EnterMovieMode,
		// Token: 0x040108E3 RID: 67811
		ExitMovieMode,
		// Token: 0x040108E4 RID: 67812
		StartRoadNetworkNavigation,
		// Token: 0x040108E5 RID: 67813
		SetWayOccupancyState,
		// Token: 0x040108E6 RID: 67814
		SendSceneActorsEvent,
		// Token: 0x040108E7 RID: 67815
		ExecBpActorFunc,
		// Token: 0x040108E8 RID: 67816
		ResetPlayerPosWithPresentation,
		// Token: 0x040108E9 RID: 67817
		PlayerLookTowards,
		// Token: 0x040108EA RID: 67818
		DrinksRollRoleRequirement,
		// Token: 0x040108EB RID: 67819
		SetBlendAnim,
		// Token: 0x040108EC RID: 67820
		ReportTrackingEvent,
		// Token: 0x040108ED RID: 67821
		TetrisThrowBlock,
		// Token: 0x040108EE RID: 67822
		TetrisGameComplete,
		// Token: 0x040108EF RID: 67823
		TetrisTriggerDelayFall,
		// Token: 0x040108F0 RID: 67824
		BossPilingRandomBuff,
		// Token: 0x040108F1 RID: 67825
		BossPilingEnterNextInst,
		// Token: 0x040108F2 RID: 67826
		DollGrabItemDelivery,
		// Token: 0x040108F3 RID: 67827
		AvgPlayRoleAction,
		// Token: 0x040108F4 RID: 67828
		AvgMoveRole,
		// Token: 0x040108F5 RID: 67829
		AvgFocusRole,
		// Token: 0x040108F6 RID: 67830
		AvgShakeUi,
		// Token: 0x040108F7 RID: 67831
		DestroyDynamicEntities,
		// Token: 0x040108F8 RID: 67832
		SheriffUnlockClue,
		// Token: 0x040108F9 RID: 67833
		SheriffUnlockProgress,
		// Token: 0x040108FA RID: 67834
		SheriffChangeCriminalState,
		// Token: 0x040108FB RID: 67835
		SheriffChangeCriminalIdentity,
		// Token: 0x040108FC RID: 67836
		SheriffUnlockEnding,
		// Token: 0x040108FD RID: 67837
		SetSubScreenMode,
		// Token: 0x040108FE RID: 67838
		ClientSetSeasonState,
		// Token: 0x040108FF RID: 67839
		SeasonWeatherSetRotationLock,
		// Token: 0x04010900 RID: 67840
		SeasonWeatherChangeTo,
		// Token: 0x04010901 RID: 67841
		SeasonWeatherUnlockSpecial,
		// Token: 0x04010902 RID: 67842
		ToggleDragActorPlay,
		// Token: 0x04010903 RID: 67843
		SetTargetElementalAbility,
		// Token: 0x04010904 RID: 67844
		ToggleEntityElementalAbility,
		// Token: 0x04010905 RID: 67845
		CaptureElementalBox,
		// Token: 0x04010906 RID: 67846
		ChangeElementalBoxState,
		// Token: 0x04010907 RID: 67847
		SetElementalBoxToTarget,
		// Token: 0x04010908 RID: 67848
		DarkTideSetMapMarkState,
		// Token: 0x04010909 RID: 67849
		OverrideAbpAnimScheme,
		// Token: 0x0401090A RID: 67850
		HandBookModifySystemProgress,
		// Token: 0x0401090B RID: 67851
		ClientExecEntityPrefabAction,
		// Token: 0x0401090C RID: 67852
		LiveSetUi,
		// Token: 0x0401090D RID: 67853
		LiveSetDanmaku,
		// Token: 0x0401090E RID: 67854
		LiveSetParam,
		// Token: 0x0401090F RID: 67855
		LiveSetSc
	}
}
