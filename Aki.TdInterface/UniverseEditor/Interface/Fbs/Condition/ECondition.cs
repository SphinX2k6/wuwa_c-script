using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004933 RID: 18739
	public enum ECondition : byte
	{
		// Token: 0x0400D006 RID: 53254
		CompareVar,
		// Token: 0x0400D007 RID: 53255
		CompareQuestState,
		// Token: 0x0400D008 RID: 53256
		CompareExploreLevel,
		// Token: 0x0400D009 RID: 53257
		CompareCalabashLevel,
		// Token: 0x0400D00A RID: 53258
		CompareEntityState,
		// Token: 0x0400D00B RID: 53259
		CompareNpcPerformState,
		// Token: 0x0400D00C RID: 53260
		CheckTreasureBeenClaimed,
		// Token: 0x0400D00D RID: 53261
		CompareEntityGroupState,
		// Token: 0x0400D00E RID: 53262
		CompareLevelPlayRewardState,
		// Token: 0x0400D00F RID: 53263
		CompareEntitySelfState,
		// Token: 0x0400D010 RID: 53264
		HourToHour,
		// Token: 0x0400D011 RID: 53265
		RangeSphere,
		// Token: 0x0400D012 RID: 53266
		CheckItems,
		// Token: 0x0400D013 RID: 53267
		HasBuff,
		// Token: 0x0400D014 RID: 53268
		CheckEntityHasBuff,
		// Token: 0x0400D015 RID: 53269
		CheckEntityBuffStack,
		// Token: 0x0400D016 RID: 53270
		ListenEntitySelfEvent,
		// Token: 0x0400D017 RID: 53271
		CheckSystemFunction,
		// Token: 0x0400D018 RID: 53272
		CompareLift,
		// Token: 0x0400D019 RID: 53273
		CompareDungeonId,
		// Token: 0x0400D01A RID: 53274
		CheckAiState,
		// Token: 0x0400D01B RID: 53275
		CompareTimePeriod,
		// Token: 0x0400D01C RID: 53276
		CompareWeather,
		// Token: 0x0400D01D RID: 53277
		CheckLevelPlayState,
		// Token: 0x0400D01E RID: 53278
		CheckLevelPlayCompleteNumber,
		// Token: 0x0400D01F RID: 53279
		CheckLevelPlayChildQuestFinished,
		// Token: 0x0400D020 RID: 53280
		CheckCurrentRole,
		// Token: 0x0400D021 RID: 53281
		CheckPlayerGender,
		// Token: 0x0400D022 RID: 53282
		CheckInCombat,
		// Token: 0x0400D023 RID: 53283
		CheckHasFollowShooter,
		// Token: 0x0400D024 RID: 53284
		CheckFollowShooterActive,
		// Token: 0x0400D025 RID: 53285
		CheckChildQuestFinished,
		// Token: 0x0400D026 RID: 53286
		ComparePlayerMotionState,
		// Token: 0x0400D027 RID: 53287
		ComparePlayerMotionState2,
		// Token: 0x0400D028 RID: 53288
		CheckDataLayer,
		// Token: 0x0400D029 RID: 53289
		CheckHookLockPoint,
		// Token: 0x0400D02A RID: 53290
		CheckPlayerSkillReady,
		// Token: 0x0400D02B RID: 53291
		CheckPlayerUseSkill,
		// Token: 0x0400D02C RID: 53292
		CheckPlayerStateRestriction,
		// Token: 0x0400D02D RID: 53293
		CheckJigsawInfo,
		// Token: 0x0400D02E RID: 53294
		CheckLordGymFinish,
		// Token: 0x0400D02F RID: 53295
		CheckCalabashDevelopReward,
		// Token: 0x0400D030 RID: 53296
		CheckGameplayTag,
		// Token: 0x0400D031 RID: 53297
		CheckFormationRoleInfo,
		// Token: 0x0400D032 RID: 53298
		CheckTargetAttribute,
		// Token: 0x0400D033 RID: 53299
		CheckRogueAbilitySelect,
		// Token: 0x0400D034 RID: 53300
		CompareTeammateDie,
		// Token: 0x0400D035 RID: 53301
		CheckNodeStatus,
		// Token: 0x0400D036 RID: 53302
		CheckChildQuestStatus,
		// Token: 0x0400D037 RID: 53303
		CheckEntitesExist,
		// Token: 0x0400D038 RID: 53304
		CheckPlayerPosition,
		// Token: 0x0400D039 RID: 53305
		CheckEntityPosition,
		// Token: 0x0400D03A RID: 53306
		CheckDirection,
		// Token: 0x0400D03B RID: 53307
		CheckSceneItemDirection,
		// Token: 0x0400D03C RID: 53308
		CheckPlayerFaceTo,
		// Token: 0x0400D03D RID: 53309
		CheckPlayerCanJoinActivity,
		// Token: 0x0400D03E RID: 53310
		CheckSystemState,
		// Token: 0x0400D03F RID: 53311
		CheckInRange,
		// Token: 0x0400D040 RID: 53312
		CheckInRangeProperly,
		// Token: 0x0400D041 RID: 53313
		CheckEntityLocked,
		// Token: 0x0400D042 RID: 53314
		CheckEntityDistance,
		// Token: 0x0400D043 RID: 53315
		CheckDungeonFinish,
		// Token: 0x0400D044 RID: 53316
		CheckEntityIsVisibility,
		// Token: 0x0400D045 RID: 53317
		CheckEntityHasSceneItemAttributeTag,
		// Token: 0x0400D046 RID: 53318
		ListenEntityThroughPortal,
		// Token: 0x0400D047 RID: 53319
		CheckTeleControlState,
		// Token: 0x0400D048 RID: 53320
		CustomJson,
		// Token: 0x0400D049 RID: 53321
		CheckChessWinner,
		// Token: 0x0400D04A RID: 53322
		CheckVehicleCondition,
		// Token: 0x0400D04B RID: 53323
		CompareAlertValue,
		// Token: 0x0400D04C RID: 53324
		CheckEntityGravityDirection,
		// Token: 0x0400D04D RID: 53325
		CheckCollectAnimalParts,
		// Token: 0x0400D04E RID: 53326
		CompleteCertainFishingEntrust,
		// Token: 0x0400D04F RID: 53327
		CheckCertainFishingItemCount,
		// Token: 0x0400D050 RID: 53328
		CompareFishingPrestigeLevel,
		// Token: 0x0400D051 RID: 53329
		CompareFishingBoatState,
		// Token: 0x0400D052 RID: 53330
		CheckFinishLoading,
		// Token: 0x0400D053 RID: 53331
		CheckFishingPointHasFish,
		// Token: 0x0400D054 RID: 53332
		CheckFishingCageFillingRatio,
		// Token: 0x0400D055 RID: 53333
		CompareFishingTechLevel,
		// Token: 0x0400D056 RID: 53334
		CheckGuestCharacter,
		// Token: 0x0400D057 RID: 53335
		CheckSubLevelState,
		// Token: 0x0400D058 RID: 53336
		ComparePlayerNumInDungeon,
		// Token: 0x0400D059 RID: 53337
		CheckAlertAreaEnabled,
		// Token: 0x0400D05A RID: 53338
		CheckClientEvent,
		// Token: 0x0400D05B RID: 53339
		CheckIsGramophonePlayingMusic,
		// Token: 0x0400D05C RID: 53340
		CheckEntityReward,
		// Token: 0x0400D05D RID: 53341
		CheckDungeonHasSaveConfig,
		// Token: 0x0400D05E RID: 53342
		CheckBVBEvent,
		// Token: 0x0400D05F RID: 53343
		CheckDangoCultivationProgress,
		// Token: 0x0400D060 RID: 53344
		CheckPlayerMoraleLevelRange,
		// Token: 0x0400D061 RID: 53345
		CheckIsGlobalTimeScaleEnabled,
		// Token: 0x0400D062 RID: 53346
		SaveConfigEnterMethod,
		// Token: 0x0400D063 RID: 53347
		CheckIsEntityTimeScaleEnabled,
		// Token: 0x0400D064 RID: 53348
		CheckIsCharacterHoldingHands,
		// Token: 0x0400D065 RID: 53349
		CheckIsTrackingCurrentQuest,
		// Token: 0x0400D066 RID: 53350
		CheckIsTrackingQuest,
		// Token: 0x0400D067 RID: 53351
		CheckMusicBeatsEvent,
		// Token: 0x0400D068 RID: 53352
		CompareGameDifficulty,
		// Token: 0x0400D069 RID: 53353
		CheckPhotographCameraParam,
		// Token: 0x0400D06A RID: 53354
		CheckAvailableSunSpiritCount,
		// Token: 0x0400D06B RID: 53355
		CheckHonamiStoryGetItem,
		// Token: 0x0400D06C RID: 53356
		CheckHonamiStoryEquipItem,
		// Token: 0x0400D06D RID: 53357
		CheckHonamiStoryActivateTalent,
		// Token: 0x0400D06E RID: 53358
		CheckHonamiStoryUnlockSlot,
		// Token: 0x0400D06F RID: 53359
		CheckHonamiStoryLifeSupportLevel,
		// Token: 0x0400D070 RID: 53360
		CheckHonamiStoryTowerComplete,
		// Token: 0x0400D071 RID: 53361
		CheckHonamiStoryPlayerCorruptedLevel,
		// Token: 0x0400D072 RID: 53362
		CheckHonamiStoryUnlockMascot,
		// Token: 0x0400D073 RID: 53363
		CheckHonamiStoryChestOpenTime,
		// Token: 0x0400D074 RID: 53364
		CheckHonamiStorySuccessfulEvacuation,
		// Token: 0x0400D075 RID: 53365
		CheckPlayerEnterClientTriggerDir,
		// Token: 0x0400D076 RID: 53366
		CheckPlayerRelativeAngle,
		// Token: 0x0400D077 RID: 53367
		CheckBvbChallengeState,
		// Token: 0x0400D078 RID: 53368
		CheckBvbActivityRank,
		// Token: 0x0400D079 RID: 53369
		CheckCollectedSunSpiritCount,
		// Token: 0x0400D07A RID: 53370
		CheckTargetSunSpiritCollected,
		// Token: 0x0400D07B RID: 53371
		CheckPlayerIsInDeadEyeProcess,
		// Token: 0x0400D07C RID: 53372
		CheckTrafficBlocked,
		// Token: 0x0400D07D RID: 53373
		CheckPlayerRelativeDistance,
		// Token: 0x0400D07E RID: 53374
		CheckDrinksPreferenceLevel,
		// Token: 0x0400D07F RID: 53375
		CheckPlayerIsInMotorcycleCruise,
		// Token: 0x0400D080 RID: 53376
		CheckEntitySelfDirection,
		// Token: 0x0400D081 RID: 53377
		CheckDollGrabItemComboAchievedInOnceDelivery,
		// Token: 0x0400D082 RID: 53378
		CheckDollGrabShowcaseItemComboAchieved,
		// Token: 0x0400D083 RID: 53379
		CheckDollGrabMachineFinished,
		// Token: 0x0400D084 RID: 53380
		CheckTetrisEndlessScore,
		// Token: 0x0400D085 RID: 53381
		CheckAtlasUnlocked,
		// Token: 0x0400D086 RID: 53382
		CheckSheriffUnlockEnding,
		// Token: 0x0400D087 RID: 53383
		CheckSyncLevelPlayCompleteNumber,
		// Token: 0x0400D088 RID: 53384
		CheckCrossSceneSyncKillMonsterFinished,
		// Token: 0x0400D089 RID: 53385
		CheckIsInDragActorPlay,
		// Token: 0x0400D08A RID: 53386
		CheckIsInDollGrabGamePlay,
		// Token: 0x0400D08B RID: 53387
		CheckEntityPrefabPerformanceType,
		// Token: 0x0400D08C RID: 53388
		CheckRoverRogueAbilitySelect,
		// Token: 0x0400D08D RID: 53389
		CheckIsSupportedWalking,
		// Token: 0x0400D08E RID: 53390
		CheckIsTargetHoldElementalBox,
		// Token: 0x0400D08F RID: 53391
		CheckElementalBoxState,
		// Token: 0x0400D090 RID: 53392
		CheckElementalEffectActive,
		// Token: 0x0400D091 RID: 53393
		CheckGiantStableValue,
		// Token: 0x0400D092 RID: 53394
		CheckGiantTotalProgressCanActivateNode,
		// Token: 0x0400D093 RID: 53395
		CheckGiantTotalProgressInteractActivatedNode,
		// Token: 0x0400D094 RID: 53396
		CheckGiantRegionCultivationTriggeredUpgradeLevel,
		// Token: 0x0400D095 RID: 53397
		CheckElementalWaterBoxStagnationSeq
	}
}
