using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BDD RID: 19421
	public enum ICondition2_Union : byte
	{
		// Token: 0x0400D4D2 RID: 54482
		NONE,
		// Token: 0x0400D4D3 RID: 54483
		ICondition2,
		// Token: 0x0400D4D4 RID: 54484
		ICompareVarCondition,
		// Token: 0x0400D4D5 RID: 54485
		IQuestStateEqualCondition,
		// Token: 0x0400D4D6 RID: 54486
		ICompareExploreLevelCondition,
		// Token: 0x0400D4D7 RID: 54487
		ICompareCalabashLevelCondition,
		// Token: 0x0400D4D8 RID: 54488
		ICompareLiftCondition,
		// Token: 0x0400D4D9 RID: 54489
		ICompareEntityStateCondition,
		// Token: 0x0400D4DA RID: 54490
		ICompareNpcPerformStateCondition,
		// Token: 0x0400D4DB RID: 54491
		ICheckTreasureBeenClaimedCondition,
		// Token: 0x0400D4DC RID: 54492
		ICompareEntityGroupStateCondition,
		// Token: 0x0400D4DD RID: 54493
		ICompareEntitySelfStateCondition,
		// Token: 0x0400D4DE RID: 54494
		ICompareLevelPlayRewardStateCondition,
		// Token: 0x0400D4DF RID: 54495
		IHourToHourCondition,
		// Token: 0x0400D4E0 RID: 54496
		IRangeSphere,
		// Token: 0x0400D4E1 RID: 54497
		ICheckItems,
		// Token: 0x0400D4E2 RID: 54498
		IHasBuff,
		// Token: 0x0400D4E3 RID: 54499
		ICheckSystemFunction,
		// Token: 0x0400D4E4 RID: 54500
		ICheckAiState,
		// Token: 0x0400D4E5 RID: 54501
		ICompareDungeonId,
		// Token: 0x0400D4E6 RID: 54502
		ICompareTimePeriod,
		// Token: 0x0400D4E7 RID: 54503
		ICompareWeather,
		// Token: 0x0400D4E8 RID: 54504
		ICheckLevelPlayState,
		// Token: 0x0400D4E9 RID: 54505
		ICheckLevelPlayCompleteNumber,
		// Token: 0x0400D4EA RID: 54506
		ICheckLevelPlayChildQuestFinished,
		// Token: 0x0400D4EB RID: 54507
		ICheckCurrentRole,
		// Token: 0x0400D4EC RID: 54508
		ICheckPlayerGender,
		// Token: 0x0400D4ED RID: 54509
		ICheckInCombat,
		// Token: 0x0400D4EE RID: 54510
		ICheckHasFollowShooter,
		// Token: 0x0400D4EF RID: 54511
		ICheckFollowShooterActive,
		// Token: 0x0400D4F0 RID: 54512
		ICheckChildQuestFinished,
		// Token: 0x0400D4F1 RID: 54513
		ICheckSyncLevelPlayCompleteNumber,
		// Token: 0x0400D4F2 RID: 54514
		ICheckCrossSceneSyncKillMonsterFinished,
		// Token: 0x0400D4F3 RID: 54515
		ICheckNodeStatus,
		// Token: 0x0400D4F4 RID: 54516
		ICheckChildQuestStatus,
		// Token: 0x0400D4F5 RID: 54517
		ICheckEntitiesExist,
		// Token: 0x0400D4F6 RID: 54518
		ICheckPlayerPosition,
		// Token: 0x0400D4F7 RID: 54519
		ICheckEntityPosition,
		// Token: 0x0400D4F8 RID: 54520
		ICheckDungeonFinish,
		// Token: 0x0400D4F9 RID: 54521
		ICheckEntityIsVisibility,
		// Token: 0x0400D4FA RID: 54522
		IComparePlayerMotionState,
		// Token: 0x0400D4FB RID: 54523
		IComparePlayerMotionState2,
		// Token: 0x0400D4FC RID: 54524
		ICheckDataLayerCondition,
		// Token: 0x0400D4FD RID: 54525
		ICheckHookLockPointCondition,
		// Token: 0x0400D4FE RID: 54526
		ICheckPlayerSkillReadyCondition,
		// Token: 0x0400D4FF RID: 54527
		ICheckPlayerUseSkillCondition,
		// Token: 0x0400D500 RID: 54528
		ICheckPlayerStateRestrictionCondition,
		// Token: 0x0400D501 RID: 54529
		ICheckLordGymFinishCondition,
		// Token: 0x0400D502 RID: 54530
		ICheckCalabashDevelopRewardCondition,
		// Token: 0x0400D503 RID: 54531
		ICompareFishingPrestigeLevelCondition,
		// Token: 0x0400D504 RID: 54532
		ICheckCertainFishingItemCount,
		// Token: 0x0400D505 RID: 54533
		ICompleteCertainFishingEntrust,
		// Token: 0x0400D506 RID: 54534
		ICompareFishingBoatState,
		// Token: 0x0400D507 RID: 54535
		ICheckJigsawInfoCondition,
		// Token: 0x0400D508 RID: 54536
		ICheckGameplayTagCondition,
		// Token: 0x0400D509 RID: 54537
		ICheckFormationRoleInfoCondition,
		// Token: 0x0400D50A RID: 54538
		ICheckTargetAttributeCondition,
		// Token: 0x0400D50B RID: 54539
		ICheckRogueAbilitySelectCondition,
		// Token: 0x0400D50C RID: 54540
		ICheckDirectionCondition,
		// Token: 0x0400D50D RID: 54541
		ICheckSceneItemDirectionCondition,
		// Token: 0x0400D50E RID: 54542
		ICheckPlayerFaceToCondition,
		// Token: 0x0400D50F RID: 54543
		ICheckPlayerCanJoinActivityCondition,
		// Token: 0x0400D510 RID: 54544
		ICheckSystemStateCondition,
		// Token: 0x0400D511 RID: 54545
		ICheckInRangeCondition,
		// Token: 0x0400D512 RID: 54546
		ICheckInRangeProperlyCondition,
		// Token: 0x0400D513 RID: 54547
		ICheckEntityLockedCondition,
		// Token: 0x0400D514 RID: 54548
		ICompareTeammateDieCondition,
		// Token: 0x0400D515 RID: 54549
		IListenEntitySelfEventCondition,
		// Token: 0x0400D516 RID: 54550
		ICheckEntityDistanceCondition,
		// Token: 0x0400D517 RID: 54551
		ICheckEntityHasSceneItemAttributeTag,
		// Token: 0x0400D518 RID: 54552
		IListenEntityThroughPortal,
		// Token: 0x0400D519 RID: 54553
		ICheckTeleControlState,
		// Token: 0x0400D51A RID: 54554
		ICustomJsonCondition,
		// Token: 0x0400D51B RID: 54555
		ICheckChessWinner,
		// Token: 0x0400D51C RID: 54556
		ICheckVehicleCondition,
		// Token: 0x0400D51D RID: 54557
		ICompareAlertValue,
		// Token: 0x0400D51E RID: 54558
		ICheckEntityGravityDirection,
		// Token: 0x0400D51F RID: 54559
		ICheckCollectAnimalParts,
		// Token: 0x0400D520 RID: 54560
		ICheckFinishLoading,
		// Token: 0x0400D521 RID: 54561
		ICheckFishingPointHasFish,
		// Token: 0x0400D522 RID: 54562
		ICheckFishingCageFillingRatio,
		// Token: 0x0400D523 RID: 54563
		ICompareFishingTechLevel,
		// Token: 0x0400D524 RID: 54564
		ICheckGuestCharacter,
		// Token: 0x0400D525 RID: 54565
		ICheckSubLevelState,
		// Token: 0x0400D526 RID: 54566
		IComparePlayerNumInDungeon,
		// Token: 0x0400D527 RID: 54567
		ICheckAlertAreaEnabled,
		// Token: 0x0400D528 RID: 54568
		ICheckClientEvent,
		// Token: 0x0400D529 RID: 54569
		ICheckIsGramophonePlayingMusic,
		// Token: 0x0400D52A RID: 54570
		ICheckEntityReward,
		// Token: 0x0400D52B RID: 54571
		ICheckDungeonHasSaveConfig,
		// Token: 0x0400D52C RID: 54572
		ICheckSystemEventBvb,
		// Token: 0x0400D52D RID: 54573
		ICheckDangoCultivationProgress,
		// Token: 0x0400D52E RID: 54574
		ICheckPlayerMoraleLevelRange,
		// Token: 0x0400D52F RID: 54575
		ICheckIsGlobalTimeScaleEnabled,
		// Token: 0x0400D530 RID: 54576
		ISaveConfigEnterMethod,
		// Token: 0x0400D531 RID: 54577
		ICheckIsEntityTimeScaleEnabled,
		// Token: 0x0400D532 RID: 54578
		ICheckIsCharacterHoldingHands,
		// Token: 0x0400D533 RID: 54579
		ICheckIsTrackingCurrentQuest,
		// Token: 0x0400D534 RID: 54580
		ICheckIsTrackingQuest,
		// Token: 0x0400D535 RID: 54581
		ICheckMusicEvent,
		// Token: 0x0400D536 RID: 54582
		ICompareGameDifficulty,
		// Token: 0x0400D537 RID: 54583
		ICheckPhotographCameraParam,
		// Token: 0x0400D538 RID: 54584
		ICheckEntityHasBuff,
		// Token: 0x0400D539 RID: 54585
		ICheckEntityBuffStack,
		// Token: 0x0400D53A RID: 54586
		ICheckAvailableSunSpiritCount,
		// Token: 0x0400D53B RID: 54587
		ICheckPlayerEnterClientTriggerDir,
		// Token: 0x0400D53C RID: 54588
		ICheckPlayerRelativeDistance,
		// Token: 0x0400D53D RID: 54589
		ICheckPlayerRelativeAngle,
		// Token: 0x0400D53E RID: 54590
		ICheckHonamiStoryGetItem,
		// Token: 0x0400D53F RID: 54591
		ICheckHonamiStoryEquipItem,
		// Token: 0x0400D540 RID: 54592
		ICheckHonamiStoryActivateTalent,
		// Token: 0x0400D541 RID: 54593
		ICheckHonamiStoryUnlockSlot,
		// Token: 0x0400D542 RID: 54594
		ICheckHonamiStoryLifeSupportLevel,
		// Token: 0x0400D543 RID: 54595
		ICheckHonamiStoryTowerComplete,
		// Token: 0x0400D544 RID: 54596
		ICheckHonamiStoryPlayerCorruptedLevel,
		// Token: 0x0400D545 RID: 54597
		ICheckHonamiStoryUnlockMascot,
		// Token: 0x0400D546 RID: 54598
		ICheckHonamiStoryChestOpenTime,
		// Token: 0x0400D547 RID: 54599
		ICheckHonamiStorySuccessfulEvacuation,
		// Token: 0x0400D548 RID: 54600
		ICheckBvbChallengeState,
		// Token: 0x0400D549 RID: 54601
		ICheckBvbActivityRank,
		// Token: 0x0400D54A RID: 54602
		ICheckCollectedSunSpiritCount,
		// Token: 0x0400D54B RID: 54603
		ICheckTargetSunSpiritCollected,
		// Token: 0x0400D54C RID: 54604
		ICheckPlayerIsInDeadEyeProcess,
		// Token: 0x0400D54D RID: 54605
		ICheckEntitySelfDirection,
		// Token: 0x0400D54E RID: 54606
		ICheckDollGrabItemComboAchievedInOnceDelivery,
		// Token: 0x0400D54F RID: 54607
		ICheckDollGrabShowcaseItemComboAchieved,
		// Token: 0x0400D550 RID: 54608
		ICheckRoverRogueAbilitySelectCondition,
		// Token: 0x0400D551 RID: 54609
		ICheckDollGrabMachineFinished,
		// Token: 0x0400D552 RID: 54610
		ICheckTrafficBlocked,
		// Token: 0x0400D553 RID: 54611
		ICheckDrinksPreferenceLevel,
		// Token: 0x0400D554 RID: 54612
		ICheckPlayerIsInMotorcycleCruise,
		// Token: 0x0400D555 RID: 54613
		ICheckTetrisEndlessScore,
		// Token: 0x0400D556 RID: 54614
		ICheckAtlasUnlocked,
		// Token: 0x0400D557 RID: 54615
		ICheckSheriffUnlockEnding,
		// Token: 0x0400D558 RID: 54616
		ICheckIsInDragActorPlay,
		// Token: 0x0400D559 RID: 54617
		ICheckIsInDollGrabGamePlay,
		// Token: 0x0400D55A RID: 54618
		ICheckEntityPrefabPerformanceType,
		// Token: 0x0400D55B RID: 54619
		ICheckIsSupportedWalking,
		// Token: 0x0400D55C RID: 54620
		ICheckGiantStableValue,
		// Token: 0x0400D55D RID: 54621
		ICheckGiantTotalProgressCanActivateNode,
		// Token: 0x0400D55E RID: 54622
		ICheckGiantTotalProgressInteractActivatedNode,
		// Token: 0x0400D55F RID: 54623
		ICheckGiantRegionCultivationTriggeredUpgradeLevel,
		// Token: 0x0400D560 RID: 54624
		ICheckElementalBoxState,
		// Token: 0x0400D561 RID: 54625
		ICheckIsTargetHoldElementalBox,
		// Token: 0x0400D562 RID: 54626
		ICheckElementalEffectActive,
		// Token: 0x0400D563 RID: 54627
		ICheckElementalWaterBoxStagnationSeq
	}
}
