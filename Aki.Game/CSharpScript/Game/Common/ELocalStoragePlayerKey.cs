using System;

namespace CSharpScript.Game.Common
{
	// Token: 0x02006409 RID: 25609
	public enum ELocalStoragePlayerKey
	{
		// Token: 0x0402101A RID: 135194
		FirstOpenShop,
		// Token: 0x0402101B RID: 135195
		CookerLevelKey,
		// Token: 0x0402101C RID: 135196
		EditBattleTeam,
		// Token: 0x0402101D RID: 135197
		GachaPoolOpenRecord,
		// Token: 0x0402101E RID: 135198
		InventoryCommonItem,
		// Token: 0x0402101F RID: 135199
		InventoryAttributeItem,
		// Token: 0x04021020 RID: 135200
		InventoryCommonItemRedDot,
		// Token: 0x04021021 RID: 135201
		InventoryAttributeItemRedDot,
		// Token: 0x04021022 RID: 135202
		RouletteAssemblyItemRedDot,
		// Token: 0x04021023 RID: 135203
		GetItemConfigListSaveKey,
		// Token: 0x04021024 RID: 135204
		ComposeLevelKey,
		// Token: 0x04021025 RID: 135205
		ForgingLevelKey,
		// Token: 0x04021026 RID: 135206
		Chat,
		// Token: 0x04021027 RID: 135207
		BattlePassPayButton,
		// Token: 0x04021028 RID: 135208
		MonthCardNextShowRedDotTime,
		// Token: 0x04021029 RID: 135209
		IsErrorChatReplace,
		// Token: 0x0402102A RID: 135210
		LocalFriendApplication,
		// Token: 0x0402102B RID: 135211
		MarqueeScrollingMap,
		// Token: 0x0402102C RID: 135212
		LoginTime,
		// Token: 0x0402102D RID: 135213
		LastTimeUploadStamp,
		// Token: 0x0402102E RID: 135214
		Activity,
		// Token: 0x0402102F RID: 135215
		IsTriggerMobileGuide,
		// Token: 0x04021030 RID: 135216
		IsTriggerDesktopGuide,
		// Token: 0x04021031 RID: 135217
		AutoInteractionGuideAppearCount,
		// Token: 0x04021032 RID: 135218
		IsSimpleDetail,
		// Token: 0x04021033 RID: 135219
		VisionSpecialSkillShowMap,
		// Token: 0x04021034 RID: 135220
		ItemGridDropDown,
		// Token: 0x04021035 RID: 135221
		HasShowNewMailTipsMap,
		// Token: 0x04021036 RID: 135222
		RoguelikeDescModel,
		// Token: 0x04021037 RID: 135223
		RoleDataItem,
		// Token: 0x04021038 RID: 135224
		PersonalDataItem,
		// Token: 0x04021039 RID: 135225
		CalabashCollect,
		// Token: 0x0402103A RID: 135226
		CalabashCollectIsSimpleDetail,
		// Token: 0x0402103B RID: 135227
		RoguelikeShopRecord,
		// Token: 0x0402103C RID: 135228
		RoguelikeShopNextTimeStamp,
		// Token: 0x0402103D RID: 135229
		VisionSkin,
		// Token: 0x0402103E RID: 135230
		SilentTips,
		// Token: 0x0402103F RID: 135231
		GachaRoleRecord,
		// Token: 0x04021040 RID: 135232
		GachaWeaponRecord,
		// Token: 0x04021041 RID: 135233
		RouletteAction01OpenConfig,
		// Token: 0x04021042 RID: 135234
		RouletteAction02OpenConfig,
		// Token: 0x04021043 RID: 135235
		MoonChasingShopItemUnlock,
		// Token: 0x04021044 RID: 135236
		MoonChasingShopItemChecked,
		// Token: 0x04021045 RID: 135237
		MoonChasingRoleUnlock,
		// Token: 0x04021046 RID: 135238
		MoonChasingQuestUnlock,
		// Token: 0x04021047 RID: 135239
		MoonChasingMemoryChecked,
		// Token: 0x04021048 RID: 135240
		LoopTowerIsClickSeason,
		// Token: 0x04021049 RID: 135241
		LoopTowerIsClickShop,
		// Token: 0x0402104A RID: 135242
		TowerOverLockArea,
		// Token: 0x0402104B RID: 135243
		ActivityRecallWatchFirstShow,
		// Token: 0x0402104C RID: 135244
		ActivityRecallSplashFirstShowTime,
		// Token: 0x0402104D RID: 135245
		ActivityRecallWatchFirstShowTime,
		// Token: 0x0402104E RID: 135246
		ActivityRegressSignLastDailyFirstShowTimeStamp,
		// Token: 0x0402104F RID: 135247
		ActivityRegressShopRedDotCheckedInPeriod,
		// Token: 0x04021050 RID: 135248
		ActivityRegressQuestionnaireRedDotCheckedInPeriod,
		// Token: 0x04021051 RID: 135249
		ActivityRegressSecondQuestionnaireRedDotCheckedInPeriod,
		// Token: 0x04021052 RID: 135250
		ActivityRegressDoubleDropReminderLastShowTime,
		// Token: 0x04021053 RID: 135251
		ActivityRegressDoubleDropFirstRedDotCheckedInPeriod,
		// Token: 0x04021054 RID: 135252
		ActivityRegressBpPayButtonRedDotCheckedInPeriod,
		// Token: 0x04021055 RID: 135253
		ActivityRegressTrialRoleRedDotCheckedInPeriod,
		// Token: 0x04021056 RID: 135254
		ActivityRegressDoubleDropRedDotCheckedInPeriod,
		// Token: 0x04021057 RID: 135255
		ActivityRegressRecommendRedDotCheckedInPeriod,
		// Token: 0x04021058 RID: 135256
		ActivityRegressAdventureRedDotCheckedInPeriod,
		// Token: 0x04021059 RID: 135257
		TowerDefenseEntered,
		// Token: 0x0402105A RID: 135258
		VersionPreheatToQuestClicked,
		// Token: 0x0402105B RID: 135259
		VersionPreheatBonusClicked,
		// Token: 0x0402105C RID: 135260
		VersionPreheatToQuestPlayed,
		// Token: 0x0402105D RID: 135261
		VersionPreheatBonusPlayed,
		// Token: 0x0402105E RID: 135262
		Spring25FirstTimeTaskAllDone,
		// Token: 0x0402105F RID: 135263
		Spring25FirstDoneTaskIndex,
		// Token: 0x04021060 RID: 135264
		Spring25FirstLetterClick,
		// Token: 0x04021061 RID: 135265
		Spring25FirstEnter,
		// Token: 0x04021062 RID: 135266
		MoonChasingDelegation,
		// Token: 0x04021063 RID: 135267
		ShowPersonalTip,
		// Token: 0x04021064 RID: 135268
		HasCleanInvalidCustomMark,
		// Token: 0x04021065 RID: 135269
		SortConfig,
		// Token: 0x04021066 RID: 135270
		FilterConfig,
		// Token: 0x04021067 RID: 135271
		FragmentMemoryOpened,
		// Token: 0x04021068 RID: 135272
		VisionRecoveryBatchTip,
		// Token: 0x04021069 RID: 135273
		VisionRecoveryBatchAimTip,
		// Token: 0x0402106A RID: 135274
		VisionRefineTip,
		// Token: 0x0402106B RID: 135275
		AuToTrackQuestTime,
		// Token: 0x0402106C RID: 135276
		GoodsRemindMap,
		// Token: 0x0402106D RID: 135277
		WeaponSkinRedDot,
		// Token: 0x0402106E RID: 135278
		FlySkinRedDot,
		// Token: 0x0402106F RID: 135279
		CalabashSkinRedDot,
		// Token: 0x04021070 RID: 135280
		MowingRiskIsInstanceNew,
		// Token: 0x04021071 RID: 135281
		TowerDefenseNewLevel,
		// Token: 0x04021072 RID: 135282
		MailBindNextShowRedDotTime,
		// Token: 0x04021073 RID: 135283
		ShowSkillResume,
		// Token: 0x04021074 RID: 135284
		ShowSkillShowTag,
		// Token: 0x04021075 RID: 135285
		GamepadUsageRecord,
		// Token: 0x04021076 RID: 135286
		RedDotAdventureNewSoundAreaTabLastUpdateTime,
		// Token: 0x04021077 RID: 135287
		VisionLevelUpMaterialPutInMode,
		// Token: 0x04021078 RID: 135288
		VisionLevelUpMaterialUseType,
		// Token: 0x04021079 RID: 135289
		VisionLevelUpSettingRedDot,
		// Token: 0x0402107A RID: 135290
		VisionLevelUpIdentifyRedDot,
		// Token: 0x0402107B RID: 135291
		DirectTrainGotoRedDotHaveDisplayed,
		// Token: 0x0402107C RID: 135292
		DirectTrainGotoRedDotHaveDisplayedByActId,
		// Token: 0x0402107D RID: 135293
		DirectTrainMakeRoleChange,
		// Token: 0x0402107E RID: 135294
		DetectionRedDotRecord,
		// Token: 0x0402107F RID: 135295
		SuitWeaponFirstWearRecord,
		// Token: 0x04021080 RID: 135296
		RoleSkinRedDot,
		// Token: 0x04021081 RID: 135297
		NewLordGymEntranceIdRecord,
		// Token: 0x04021082 RID: 135298
		SailingIsFix,
		// Token: 0x04021083 RID: 135299
		VisionTopTipsState,
		// Token: 0x04021084 RID: 135300
		FirstOpenVisionGroup,
		// Token: 0x04021085 RID: 135301
		ShipTowerSeason,
		// Token: 0x04021086 RID: 135302
		AdventrueShipTowerSeason,
		// Token: 0x04021087 RID: 135303
		AdventrueWeeklyRogue,
		// Token: 0x04021088 RID: 135304
		AdventrueTower,
		// Token: 0x04021089 RID: 135305
		DockyardListItemRead,
		// Token: 0x0402108A RID: 135306
		FilterRedPoint,
		// Token: 0x0402108B RID: 135307
		SolarSpeedInstanceClicked,
		// Token: 0x0402108C RID: 135308
		PayShopTabItemChecked,
		// Token: 0x0402108D RID: 135309
		FishingHandBookItemRecord,
		// Token: 0x0402108E RID: 135310
		FishingShipSkinRecord,
		// Token: 0x0402108F RID: 135311
		ShipTowerGetBuffSet,
		// Token: 0x04021090 RID: 135312
		ShipTowerExchangeInstId,
		// Token: 0x04021091 RID: 135313
		ExploreActivityFirstUnlock,
		// Token: 0x04021092 RID: 135314
		PlayerTitleRecord,
		// Token: 0x04021093 RID: 135315
		PlayerTitleUnlockRedDot,
		// Token: 0x04021094 RID: 135316
		VersionRedDotMap,
		// Token: 0x04021095 RID: 135317
		BabelTowerNewLevel,
		// Token: 0x04021096 RID: 135318
		BabelTowerNewLevelHasClick,
		// Token: 0x04021097 RID: 135319
		InviteNewbieEntered,
		// Token: 0x04021098 RID: 135320
		AbyssDangoFormationSelect,
		// Token: 0x04021099 RID: 135321
		RogueResDungeonNewest,
		// Token: 0x0402109A RID: 135322
		RogueResSkillTreeOpen,
		// Token: 0x0402109B RID: 135323
		RogueResEndingOpen,
		// Token: 0x0402109C RID: 135324
		RogueResShopRefresh,
		// Token: 0x0402109D RID: 135325
		RogueResShopNewGoods,
		// Token: 0x0402109E RID: 135326
		RogueResTaskOpen,
		// Token: 0x0402109F RID: 135327
		RogueResTrialOpen,
		// Token: 0x040210A0 RID: 135328
		RogueResNewRoleFlag,
		// Token: 0x040210A1 RID: 135329
		RogueResMapScale,
		// Token: 0x040210A2 RID: 135330
		DangoMonopolyActivityId,
		// Token: 0x040210A3 RID: 135331
		DangoMonopolySpeed,
		// Token: 0x040210A4 RID: 135332
		DangoMonopolyLastEnterBoard,
		// Token: 0x040210A5 RID: 135333
		DangoMonopolyNewTask,
		// Token: 0x040210A6 RID: 135334
		RacingBetsMatchViewRecord,
		// Token: 0x040210A7 RID: 135335
		RacingBetsRankViewRecord,
		// Token: 0x040210A8 RID: 135336
		RacingBetsReplayGameRecord,
		// Token: 0x040210A9 RID: 135337
		RacingBetsWatchGameRecord,
		// Token: 0x040210AA RID: 135338
		RacingBetsSettlementMainViewRecord,
		// Token: 0x040210AB RID: 135339
		RacingBetsBettingMainViewRecord,
		// Token: 0x040210AC RID: 135340
		RacingBetsBulletScreenAlphaRecord,
		// Token: 0x040210AD RID: 135341
		RacingBetsBulletScreenShowTypeRecord,
		// Token: 0x040210AE RID: 135342
		SdkReportStateMap,
		// Token: 0x040210AF RID: 135343
		PayShopRechargeRedDot,
		// Token: 0x040210B0 RID: 135344
		ShowNoteIdMap,
		// Token: 0x040210B1 RID: 135345
		AbyssSelectRole,
		// Token: 0x040210B2 RID: 135346
		AbyssDangoLevelCheck,
		// Token: 0x040210B3 RID: 135347
		AbyssDangoRoleNew,
		// Token: 0x040210B4 RID: 135348
		AbyssDangoEnterNew,
		// Token: 0x040210B5 RID: 135349
		AbyssDangoFormationNew,
		// Token: 0x040210B6 RID: 135350
		RogueResDungeonSelected,
		// Token: 0x040210B7 RID: 135351
		IsDirectTrainProOpened,
		// Token: 0x040210B8 RID: 135352
		PhantomArenaEntranceShopRefresh,
		// Token: 0x040210B9 RID: 135353
		PhantomArenaEntranceGymCheck,
		// Token: 0x040210BA RID: 135354
		PhantomArenaRepeatLastIndex,
		// Token: 0x040210BB RID: 135355
		PhantomArenaEntranceGymRedDotCheck,
		// Token: 0x040210BC RID: 135356
		QuestReviewNodeRedDot,
		// Token: 0x040210BD RID: 135357
		QuestReviewNodeUnlockAnim,
		// Token: 0x040210BE RID: 135358
		QuestReviewLineUnlockAnim,
		// Token: 0x040210BF RID: 135359
		QuestReviewLineDestroyAnim,
		// Token: 0x040210C0 RID: 135360
		QuestReviewTabUnlockAnim,
		// Token: 0x040210C1 RID: 135361
		QuestReviewMainViewEntryAnim,
		// Token: 0x040210C2 RID: 135362
		QuestReviewHasFused,
		// Token: 0x040210C3 RID: 135363
		QuestReviewNewLineHasFused,
		// Token: 0x040210C4 RID: 135364
		BeginnerCarnivalShop,
		// Token: 0x040210C5 RID: 135365
		BeginnerCarnivalGacha,
		// Token: 0x040210C6 RID: 135366
		BeginnerCarnivalChoseRoleView,
		// Token: 0x040210C7 RID: 135367
		FloroRanchSpeed,
		// Token: 0x040210C8 RID: 135368
		MoraleAreaUnlockFlagSet,
		// Token: 0x040210C9 RID: 135369
		MoraleTipsAreaBuff,
		// Token: 0x040210CA RID: 135370
		MoraleActiveAreaBuff,
		// Token: 0x040210CB RID: 135371
		RoleTutorialNew,
		// Token: 0x040210CC RID: 135372
		AdventrueItemNew,
		// Token: 0x040210CD RID: 135373
		VisionSuitFilter,
		// Token: 0x040210CE RID: 135374
		FloroRanchSkillId,
		// Token: 0x040210CF RID: 135375
		FloroRanchSkillIdWeekly,
		// Token: 0x040210D0 RID: 135376
		CustomizedThumbnailShow,
		// Token: 0x040210D1 RID: 135377
		VisionLevelUpIdentify,
		// Token: 0x040210D2 RID: 135378
		FloroRanchSelectedRaceIds,
		// Token: 0x040210D3 RID: 135379
		FloroRanchSkillRedDot,
		// Token: 0x040210D4 RID: 135380
		FloroRanchCardRedDot,
		// Token: 0x040210D5 RID: 135381
		FloroRanchCardInGameRedDot,
		// Token: 0x040210D6 RID: 135382
		FloroRanchToyRedDot,
		// Token: 0x040210D7 RID: 135383
		FloroRanchRaceRedDot,
		// Token: 0x040210D8 RID: 135384
		WeeklyRogueExtraEnterTips,
		// Token: 0x040210D9 RID: 135385
		LoopTowerSeason,
		// Token: 0x040210DA RID: 135386
		IntroductionVersion,
		// Token: 0x040210DB RID: 135387
		TrapDefenseBuildingClicked,
		// Token: 0x040210DC RID: 135388
		TrapDefenseAuxiliaryClicked,
		// Token: 0x040210DD RID: 135389
		TrapDefenseBdBuffUnlock,
		// Token: 0x040210DE RID: 135390
		TrapDefenseLevelReachOpenTime,
		// Token: 0x040210DF RID: 135391
		TrapDefenseRougeModeOpen,
		// Token: 0x040210E0 RID: 135392
		TrapDefenseRougeModeOpenSub,
		// Token: 0x040210E1 RID: 135393
		SurvivorsHandbookClicked,
		// Token: 0x040210E2 RID: 135394
		FightPhotoLevelRedDot,
		// Token: 0x040210E3 RID: 135395
		QuestTreeNodeNewTag,
		// Token: 0x040210E4 RID: 135396
		SubDownLoadAgreeUseCellData,
		// Token: 0x040210E5 RID: 135397
		SubDownLoadLastDownLoadList,
		// Token: 0x040210E6 RID: 135398
		SubDownLoadLastPauseId,
		// Token: 0x040210E7 RID: 135399
		SubDownLoadLastDynamicDownLoadList,
		// Token: 0x040210E8 RID: 135400
		SubDownLoadLastDownLoadingId,
		// Token: 0x040210E9 RID: 135401
		HonamiStoryMascotUnlockSet,
		// Token: 0x040210EA RID: 135402
		HonamiStoryWeaponUnlockSet,
		// Token: 0x040210EB RID: 135403
		HonamiStoryMainButtonUnlockSet,
		// Token: 0x040210EC RID: 135404
		HonamiStorySelectLvAreaUnLockTips,
		// Token: 0x040210ED RID: 135405
		HonamiStorySelectLvUnLockTips,
		// Token: 0x040210EE RID: 135406
		HonamiStorySelectLvTowerUnLockTips,
		// Token: 0x040210EF RID: 135407
		HonamiStorySelectLvTowerUnLockTogRedDot,
		// Token: 0x040210F0 RID: 135408
		HonamiStorySelectLvTowerUnLockBtnGoRedDot,
		// Token: 0x040210F1 RID: 135409
		HonamiStorySkillDescMode,
		// Token: 0x040210F2 RID: 135410
		FirstOpenCommonWeaponSelect,
		// Token: 0x040210F3 RID: 135411
		SubDownLoadClearOnLogin,
		// Token: 0x040210F4 RID: 135412
		MotorcycleMusicRedDot,
		// Token: 0x040210F5 RID: 135413
		MotorcycleCurPlayAlbumId,
		// Token: 0x040210F6 RID: 135414
		MotorcycleCurPlayMusicId,
		// Token: 0x040210F7 RID: 135415
		MotorcyclePlayMode,
		// Token: 0x040210F8 RID: 135416
		MotorcycleMusicIsPause,
		// Token: 0x040210F9 RID: 135417
		FirstUnlockArtemisDayMap,
		// Token: 0x040210FA RID: 135418
		FirstPlayArtemisPlaneAnimMap,
		// Token: 0x040210FB RID: 135419
		RemindCanUpgradedLaHaiLuo,
		// Token: 0x040210FC RID: 135420
		RemindCanUpgradedRiLing,
		// Token: 0x040210FD RID: 135421
		InfrRecordObservatoryLevel,
		// Token: 0x040210FE RID: 135422
		InfrRoadMarkUnlockRecord,
		// Token: 0x040210FF RID: 135423
		InfrObservatoryLevelUpSeq,
		// Token: 0x04021100 RID: 135424
		MapNPCMarkShowSeq,
		// Token: 0x04021101 RID: 135425
		RegionalTerminalBarFoldState,
		// Token: 0x04021102 RID: 135426
		PhantomArenaChallengeUnlockRedDotCheck,
		// Token: 0x04021103 RID: 135427
		PhantomArenaMapUnlockRedDotCheck,
		// Token: 0x04021104 RID: 135428
		MotorParkourLevelClicked,
		// Token: 0x04021105 RID: 135429
		CyberPunkBossEntranceFirstClicked,
		// Token: 0x04021106 RID: 135430
		WeatherCentralClicked,
		// Token: 0x04021107 RID: 135431
		PhantomInteractNewUnlock,
		// Token: 0x04021108 RID: 135432
		NewPlayerSupportTrialRoleEntranceRedDot,
		// Token: 0x04021109 RID: 135433
		TrialRoleGroupUnlock,
		// Token: 0x0402110A RID: 135434
		ActivityNewPlayerSupportFirstShow,
		// Token: 0x0402110B RID: 135435
		MotorDevelopIsFirstDailyExpLimit,
		// Token: 0x0402110C RID: 135436
		MotorDevelopNewUnlockTree,
		// Token: 0x0402110D RID: 135437
		MotorDiyNewUnlockId,
		// Token: 0x0402110E RID: 135438
		MotorFightLevelClicked,
		// Token: 0x0402110F RID: 135439
		MotorFightItemClicked,
		// Token: 0x04021110 RID: 135440
		MotorFightRoleClicked,
		// Token: 0x04021111 RID: 135441
		DrinksUnlockLevelClicked,
		// Token: 0x04021112 RID: 135442
		GuessJokerUnlockLevelClicked,
		// Token: 0x04021113 RID: 135443
		GuessJokerFirstFinishAnim,
		// Token: 0x04021114 RID: 135444
		FlagChallengeFormationRoleIds,
		// Token: 0x04021115 RID: 135445
		FeedbackRewardHaveShowRewardId,
		// Token: 0x04021116 RID: 135446
		SpringManorBrochureUnlockSequencePlayed,
		// Token: 0x04021117 RID: 135447
		CoopLevelFirstRedDotClicked,
		// Token: 0x04021118 RID: 135448
		CoopPhotoRedDotClicked,
		// Token: 0x04021119 RID: 135449
		PhantomDiscardPlanRecycleSet,
		// Token: 0x0402111A RID: 135450
		RhythmShipLocalCalibrationValue,
		// Token: 0x0402111B RID: 135451
		RhythmShipHavePlayAniLevelId,
		// Token: 0x0402111C RID: 135452
		BossPilingQuestClicked,
		// Token: 0x0402111D RID: 135453
		BossPilingLevelNew,
		// Token: 0x0402111E RID: 135454
		RoguelikeInstanceSelectGroupIndex,
		// Token: 0x0402111F RID: 135455
		RoguelikeInstanceSelectEntryId,
		// Token: 0x04021120 RID: 135456
		RoguelikeFormationIdList,
		// Token: 0x04021121 RID: 135457
		RoguelikeSelectPhantomId,
		// Token: 0x04021122 RID: 135458
		RoleVoiceMap,
		// Token: 0x04021123 RID: 135459
		RoleTrialRemindMap,
		// Token: 0x04021124 RID: 135460
		GolemHackingBonusLevelGroupPlayed,
		// Token: 0x04021125 RID: 135461
		GolemHackingActivityLevelTime,
		// Token: 0x04021126 RID: 135462
		ShouldSaveCaptureCollectFlag,
		// Token: 0x04021127 RID: 135463
		FirstOpenDailyActivityDailyTab,
		// Token: 0x04021128 RID: 135464
		FirstOpenDailyActivityWeeklyTab,
		// Token: 0x04021129 RID: 135465
		IgnoreWheelTowerSeasonReviewMedalCheck,
		// Token: 0x0402112A RID: 135466
		RoguelikeShopItemChecked,
		// Token: 0x0402112B RID: 135467
		SheriffHideCompletedMarkItem,
		// Token: 0x0402112C RID: 135468
		SubPackageRecommendConfirmShown,
		// Token: 0x0402112D RID: 135469
		RoleLangCustomRecord,
		// Token: 0x0402112E RID: 135470
		RoverRogueLastPassRoleType,
		// Token: 0x0402112F RID: 135471
		UseFormation3DView,
		// Token: 0x04021130 RID: 135472
		RoverRogueSeenUnlockedInsIds,
		// Token: 0x04021131 RID: 135473
		RoverRogueSeenUnlockedBlessIds,
		// Token: 0x04021132 RID: 135474
		RoverRogueSeenUnlockedLootIds,
		// Token: 0x04021133 RID: 135475
		GiantAccessReadIds,
		// Token: 0x04021134 RID: 135476
		GiantCommissionRedDotClicked,
		// Token: 0x04021135 RID: 135477
		SubDownLoadRecallProtectedIds,
		// Token: 0x04021136 RID: 135478
		GiantInteractReadNodeIds,
		// Token: 0x04021137 RID: 135479
		InstRechallengeCache,
		// Token: 0x04021138 RID: 135480
		RoleDevelopNewState,
		// Token: 0x04021139 RID: 135481
		SolarSchoolLocalRecords,
		// Token: 0x0402113A RID: 135482
		RoleTowerShowBriefDesc
	}
}
