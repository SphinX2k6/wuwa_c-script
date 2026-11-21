using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050CA RID: 20682
	public enum ICondition2_Union : byte
	{
		// Token: 0x0400DFDD RID: 57309
		NONE,
		// Token: 0x0400DFDE RID: 57310
		ICondition2,
		// Token: 0x0400DFDF RID: 57311
		ICompareVarCondition,
		// Token: 0x0400DFE0 RID: 57312
		IQuestStateEqualCondition,
		// Token: 0x0400DFE1 RID: 57313
		ICompareExploreLevelCondition,
		// Token: 0x0400DFE2 RID: 57314
		ICompareCalabashLevelCondition,
		// Token: 0x0400DFE3 RID: 57315
		ICompareLiftCondition,
		// Token: 0x0400DFE4 RID: 57316
		ICompareEntityStateCondition,
		// Token: 0x0400DFE5 RID: 57317
		ICompareNpcPerformStateCondition,
		// Token: 0x0400DFE6 RID: 57318
		ICheckTreasureBeenClaimedCondition,
		// Token: 0x0400DFE7 RID: 57319
		ICompareEntityGroupStateCondition,
		// Token: 0x0400DFE8 RID: 57320
		ICompareEntitySelfStateCondition,
		// Token: 0x0400DFE9 RID: 57321
		ICompareLevelPlayRewardStateCondition,
		// Token: 0x0400DFEA RID: 57322
		IHourToHourCondition,
		// Token: 0x0400DFEB RID: 57323
		IRangeSphere,
		// Token: 0x0400DFEC RID: 57324
		ICheckItems,
		// Token: 0x0400DFED RID: 57325
		IHasBuff,
		// Token: 0x0400DFEE RID: 57326
		ICheckSystemFunction,
		// Token: 0x0400DFEF RID: 57327
		ICheckAiState,
		// Token: 0x0400DFF0 RID: 57328
		ICompareDungeonId,
		// Token: 0x0400DFF1 RID: 57329
		ICompareTimePeriod,
		// Token: 0x0400DFF2 RID: 57330
		ICompareWeather,
		// Token: 0x0400DFF3 RID: 57331
		ICheckLevelPlayState,
		// Token: 0x0400DFF4 RID: 57332
		ICheckLevelPlayCompleteNumber,
		// Token: 0x0400DFF5 RID: 57333
		ICheckLevelPlayChildQuestFinished,
		// Token: 0x0400DFF6 RID: 57334
		ICheckCurrentRole,
		// Token: 0x0400DFF7 RID: 57335
		ICheckPlayerGender,
		// Token: 0x0400DFF8 RID: 57336
		ICheckInCombat,
		// Token: 0x0400DFF9 RID: 57337
		ICheckHasFollowShooter,
		// Token: 0x0400DFFA RID: 57338
		ICheckFollowShooterActive,
		// Token: 0x0400DFFB RID: 57339
		ICheckChildQuestFinished,
		// Token: 0x0400DFFC RID: 57340
		ICheckSyncLevelPlayCompleteNumber,
		// Token: 0x0400DFFD RID: 57341
		ICheckCrossSceneSyncKillMonsterFinished,
		// Token: 0x0400DFFE RID: 57342
		ICheckNodeStatus,
		// Token: 0x0400DFFF RID: 57343
		ICheckChildQuestStatus,
		// Token: 0x0400E000 RID: 57344
		ICheckEntitiesExist,
		// Token: 0x0400E001 RID: 57345
		ICheckPlayerPosition,
		// Token: 0x0400E002 RID: 57346
		ICheckEntityPosition,
		// Token: 0x0400E003 RID: 57347
		ICheckDungeonFinish,
		// Token: 0x0400E004 RID: 57348
		ICheckEntityIsVisibility,
		// Token: 0x0400E005 RID: 57349
		IComparePlayerMotionState,
		// Token: 0x0400E006 RID: 57350
		IComparePlayerMotionState2,
		// Token: 0x0400E007 RID: 57351
		ICheckDataLayerCondition,
		// Token: 0x0400E008 RID: 57352
		ICheckHookLockPointCondition,
		// Token: 0x0400E009 RID: 57353
		ICheckPlayerSkillReadyCondition,
		// Token: 0x0400E00A RID: 57354
		ICheckPlayerUseSkillCondition,
		// Token: 0x0400E00B RID: 57355
		ICheckPlayerStateRestrictionCondition,
		// Token: 0x0400E00C RID: 57356
		ICheckLordGymFinishCondition,
		// Token: 0x0400E00D RID: 57357
		ICheckCalabashDevelopRewardCondition,
		// Token: 0x0400E00E RID: 57358
		ICompareFishingPrestigeLevelCondition,
		// Token: 0x0400E00F RID: 57359
		ICheckCertainFishingItemCount,
		// Token: 0x0400E010 RID: 57360
		ICompleteCertainFishingEntrust,
		// Token: 0x0400E011 RID: 57361
		ICompareFishingBoatState,
		// Token: 0x0400E012 RID: 57362
		ICheckJigsawInfoCondition,
		// Token: 0x0400E013 RID: 57363
		ICheckGameplayTagCondition,
		// Token: 0x0400E014 RID: 57364
		ICheckFormationRoleInfoCondition,
		// Token: 0x0400E015 RID: 57365
		ICheckTargetAttributeCondition,
		// Token: 0x0400E016 RID: 57366
		ICheckRogueAbilitySelectCondition,
		// Token: 0x0400E017 RID: 57367
		ICheckDirectionCondition,
		// Token: 0x0400E018 RID: 57368
		ICheckSceneItemDirectionCondition,
		// Token: 0x0400E019 RID: 57369
		ICheckPlayerFaceToCondition,
		// Token: 0x0400E01A RID: 57370
		ICheckPlayerCanJoinActivityCondition,
		// Token: 0x0400E01B RID: 57371
		ICheckSystemStateCondition,
		// Token: 0x0400E01C RID: 57372
		ICheckInRangeCondition,
		// Token: 0x0400E01D RID: 57373
		ICheckInRangeProperlyCondition,
		// Token: 0x0400E01E RID: 57374
		ICheckEntityLockedCondition,
		// Token: 0x0400E01F RID: 57375
		ICompareTeammateDieCondition,
		// Token: 0x0400E020 RID: 57376
		IListenEntitySelfEventCondition,
		// Token: 0x0400E021 RID: 57377
		ICheckEntityDistanceCondition,
		// Token: 0x0400E022 RID: 57378
		ICheckEntityHasSceneItemAttributeTag,
		// Token: 0x0400E023 RID: 57379
		IListenEntityThroughPortal,
		// Token: 0x0400E024 RID: 57380
		ICheckTeleControlState,
		// Token: 0x0400E025 RID: 57381
		ICustomJsonCondition,
		// Token: 0x0400E026 RID: 57382
		ICheckChessWinner,
		// Token: 0x0400E027 RID: 57383
		ICheckVehicleCondition,
		// Token: 0x0400E028 RID: 57384
		ICheckMechState,
		// Token: 0x0400E029 RID: 57385
		ICheckExploreSkillState,
		// Token: 0x0400E02A RID: 57386
		ICompareAlertValue,
		// Token: 0x0400E02B RID: 57387
		ICheckEntityGravityDirection,
		// Token: 0x0400E02C RID: 57388
		ICheckCollectAnimalParts,
		// Token: 0x0400E02D RID: 57389
		ICheckPreloadComplete,
		// Token: 0x0400E02E RID: 57390
		ICheckFinishLoading,
		// Token: 0x0400E02F RID: 57391
		ICheckFishingPointHasFish,
		// Token: 0x0400E030 RID: 57392
		ICheckFishingCageFillingRatio,
		// Token: 0x0400E031 RID: 57393
		ICompareFishingTechLevel,
		// Token: 0x0400E032 RID: 57394
		ICheckGuestCharacter,
		// Token: 0x0400E033 RID: 57395
		ICheckSubLevelState,
		// Token: 0x0400E034 RID: 57396
		IComparePlayerNumInDungeon,
		// Token: 0x0400E035 RID: 57397
		ICheckAlertAreaEnabled,
		// Token: 0x0400E036 RID: 57398
		ICheckClientEvent,
		// Token: 0x0400E037 RID: 57399
		ICheckIsGramophonePlayingMusic,
		// Token: 0x0400E038 RID: 57400
		ICheckEntityReward,
		// Token: 0x0400E039 RID: 57401
		ICheckDungeonHasSaveConfig,
		// Token: 0x0400E03A RID: 57402
		ICheckSystemEventBvb,
		// Token: 0x0400E03B RID: 57403
		ICheckDangoCultivationProgress,
		// Token: 0x0400E03C RID: 57404
		ICheckPlayerMoraleLevelRange,
		// Token: 0x0400E03D RID: 57405
		ICheckIsGlobalTimeScaleEnabled,
		// Token: 0x0400E03E RID: 57406
		ISaveConfigEnterMethod,
		// Token: 0x0400E03F RID: 57407
		ICheckIsEntityTimeScaleEnabled,
		// Token: 0x0400E040 RID: 57408
		ICheckIsCharacterHoldingHands,
		// Token: 0x0400E041 RID: 57409
		ICheckIsTrackingCurrentQuest,
		// Token: 0x0400E042 RID: 57410
		ICheckIsTrackingQuest,
		// Token: 0x0400E043 RID: 57411
		ICheckMusicEvent,
		// Token: 0x0400E044 RID: 57412
		ICompareGameDifficulty,
		// Token: 0x0400E045 RID: 57413
		ICheckPhotographCameraParam,
		// Token: 0x0400E046 RID: 57414
		ICheckEntityHasBuff,
		// Token: 0x0400E047 RID: 57415
		ICheckEntityBuffStack,
		// Token: 0x0400E048 RID: 57416
		ICheckAvailableSunSpiritCount,
		// Token: 0x0400E049 RID: 57417
		ICheckPlayerEnterClientTriggerDir,
		// Token: 0x0400E04A RID: 57418
		ICheckPlayerRelativeDistance,
		// Token: 0x0400E04B RID: 57419
		ICheckPlayerRelativeAngle,
		// Token: 0x0400E04C RID: 57420
		ICheckHonamiStoryGetItem,
		// Token: 0x0400E04D RID: 57421
		ICheckHonamiStoryEquipItem,
		// Token: 0x0400E04E RID: 57422
		ICheckHonamiStoryActivateTalent,
		// Token: 0x0400E04F RID: 57423
		ICheckHonamiStoryUnlockSlot,
		// Token: 0x0400E050 RID: 57424
		ICheckHonamiStoryLifeSupportLevel,
		// Token: 0x0400E051 RID: 57425
		ICheckHonamiStoryTowerComplete,
		// Token: 0x0400E052 RID: 57426
		ICheckHonamiStoryPlayerCorruptedLevel,
		// Token: 0x0400E053 RID: 57427
		ICheckHonamiStoryUnlockMascot,
		// Token: 0x0400E054 RID: 57428
		ICheckHonamiStoryChestOpenTime,
		// Token: 0x0400E055 RID: 57429
		ICheckHonamiStorySuccessfulEvacuation,
		// Token: 0x0400E056 RID: 57430
		ICheckBvbChallengeState,
		// Token: 0x0400E057 RID: 57431
		ICheckBvbActivityRank,
		// Token: 0x0400E058 RID: 57432
		ICheckDiceGameChallengeState,
		// Token: 0x0400E059 RID: 57433
		ICompareDiceGameRankLevel,
		// Token: 0x0400E05A RID: 57434
		ICheckCollectedSunSpiritCount,
		// Token: 0x0400E05B RID: 57435
		ICheckTargetSunSpiritCollected,
		// Token: 0x0400E05C RID: 57436
		ICheckPlayerIsInDeadEyeProcess,
		// Token: 0x0400E05D RID: 57437
		ICheckEntitySelfDirection,
		// Token: 0x0400E05E RID: 57438
		ICheckDollGrabItemComboAchievedInOnceDelivery,
		// Token: 0x0400E05F RID: 57439
		ICheckDollGrabShowcaseItemComboAchieved,
		// Token: 0x0400E060 RID: 57440
		ICheckRoverRogueAbilitySelectCondition,
		// Token: 0x0400E061 RID: 57441
		ICheckDollGrabMachineFinished,
		// Token: 0x0400E062 RID: 57442
		ICheckTrafficBlocked,
		// Token: 0x0400E063 RID: 57443
		ICheckDrinksPreferenceLevel,
		// Token: 0x0400E064 RID: 57444
		ICheckPlayerIsInMotorcycleCruise,
		// Token: 0x0400E065 RID: 57445
		ICheckPlayerIsControlledByAi,
		// Token: 0x0400E066 RID: 57446
		ICheckTetrisEndlessScore,
		// Token: 0x0400E067 RID: 57447
		ICheckDartLevelComplete,
		// Token: 0x0400E068 RID: 57448
		ICheckAtlasUnlocked,
		// Token: 0x0400E069 RID: 57449
		ICheckSheriffUnlockEnding,
		// Token: 0x0400E06A RID: 57450
		ICheckIsInDragActorPlay,
		// Token: 0x0400E06B RID: 57451
		ICheckIsInDollGrabGamePlay,
		// Token: 0x0400E06C RID: 57452
		ICheckIsInDartGameplay,
		// Token: 0x0400E06D RID: 57453
		ICheckIsInRideFlyingCarGameplay,
		// Token: 0x0400E06E RID: 57454
		ICheckEntityPrefabPerformanceType,
		// Token: 0x0400E06F RID: 57455
		ICheckIsSupportedWalking,
		// Token: 0x0400E070 RID: 57456
		ICheckGiantStableValue,
		// Token: 0x0400E071 RID: 57457
		ICheckGiantTotalProgressCanActivateNode,
		// Token: 0x0400E072 RID: 57458
		ICheckGiantTotalProgressInteractActivatedNode,
		// Token: 0x0400E073 RID: 57459
		ICheckGiantRegionCultivationTriggeredUpgradeLevel,
		// Token: 0x0400E074 RID: 57460
		ICheckElementalBoxState,
		// Token: 0x0400E075 RID: 57461
		ICheckIsTargetHoldElementalBox,
		// Token: 0x0400E076 RID: 57462
		ICheckElementalEffectActive,
		// Token: 0x0400E077 RID: 57463
		ICheckElementalWaterBoxStagnationSeq,
		// Token: 0x0400E078 RID: 57464
		ICompareSeasonAndWeather,
		// Token: 0x0400E079 RID: 57465
		ICheckIsSpecialWeatherUnlocked,
		// Token: 0x0400E07A RID: 57466
		ICheckCollectiblesDetectionAllowed
	}
}
