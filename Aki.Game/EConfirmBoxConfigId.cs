using System;

// Token: 0x020019D6 RID: 6614
public enum EConfirmBoxConfigId
{
	// Token: 0x040056DA RID: 22234
	Default = -1,
	// Token: 0x040056DB RID: 22235
	WeaponLevelUpThreeCondition = 1,
	// Token: 0x040056DC RID: 22236
	WeaponLevelUpTwoCondition,
	// Token: 0x040056DD RID: 22237
	WeaponLevelUpOneCondition,
	// Token: 0x040056DE RID: 22238
	BattleViewLeaveInstance,
	// Token: 0x040056DF RID: 22239
	EditBattleTeamCreate,
	// Token: 0x040056E0 RID: 22240
	EditBattleTeamExit,
	// Token: 0x040056E1 RID: 22241
	EditBattleTeamDisband,
	// Token: 0x040056E2 RID: 22242
	EditBattleTeam,
	// Token: 0x040056E3 RID: 22243
	MingsuTip,
	// Token: 0x040056E4 RID: 22244
	NetTip,
	// Token: 0x040056E5 RID: 22245
	MultiplayerTeamTip,
	// Token: 0x040056E6 RID: 22246
	PhantomCultureTip,
	// Token: 0x040056E7 RID: 22247
	RoleResonanceLevelUpTip,
	// Token: 0x040056E8 RID: 22248
	RoleResonanceActiveTip,
	// Token: 0x040056E9 RID: 22249
	TapeLevelUpHighQualityHighLevel,
	// Token: 0x040056EA RID: 22250
	TapeLevelUpHighQuality,
	// Token: 0x040056EB RID: 22251
	TapeLevelUpHighLevel,
	// Token: 0x040056EC RID: 22252
	TapeEquipmentTip,
	// Token: 0x040056ED RID: 22253
	TapeTransTip,
	// Token: 0x040056EE RID: 22254
	TapeTransHasHighLevelTip,
	// Token: 0x040056EF RID: 22255
	WeaponResonanceTip,
	// Token: 0x040056F0 RID: 22256
	WeaponEquipmentTip,
	// Token: 0x040056F1 RID: 22257
	RoleLevelUpExpTip,
	// Token: 0x040056F2 RID: 22258
	WeaponOverflowExpTip,
	// Token: 0x040056F3 RID: 22259
	WeaponResonanceHasResonance,
	// Token: 0x040056F4 RID: 22260
	WeaponResonanceHasStrength,
	// Token: 0x040056F5 RID: 22261
	WeaponResonanceBoth,
	// Token: 0x040056F6 RID: 22262
	MingsuTipByMoreCore,
	// Token: 0x040056F7 RID: 22263
	PhantomCultureTipWithSkill,
	// Token: 0x040056F8 RID: 22264
	NetWorkMaskTip,
	// Token: 0x040056F9 RID: 22265
	PhantomEquipRoleTip,
	// Token: 0x040056FA RID: 22266
	PhantomUnEquipRoleTip,
	// Token: 0x040056FB RID: 22267
	ErrorCodeTips,
	// Token: 0x040056FC RID: 22268
	PhantomUnEquipOtherRoleTip,
	// Token: 0x040056FD RID: 22269
	PowerNotEnoughForDungeon,
	// Token: 0x040056FE RID: 22270
	ShowTimeDownTips,
	// Token: 0x040056FF RID: 22271
	UseBuffItemToMaxLifeRoleTips,
	// Token: 0x04005700 RID: 22272
	BackLoginView,
	// Token: 0x04005701 RID: 22273
	NetWorkExcept,
	// Token: 0x04005702 RID: 22274
	HasNewVersion,
	// Token: 0x04005703 RID: 22275
	HasPatch,
	// Token: 0x04005704 RID: 22276
	ServerMaintenance,
	// Token: 0x04005705 RID: 22277
	ClientIntegrity,
	// Token: 0x04005706 RID: 22278
	LogoutAccount,
	// Token: 0x04005707 RID: 22279
	CreateCharacterSecondConfirm,
	// Token: 0x04005708 RID: 22280
	RegionQuestGiveUpConfirm,
	// Token: 0x04005709 RID: 22281
	MenuRestart,
	// Token: 0x0400570A RID: 22282
	OneMailBeingDeleted,
	// Token: 0x0400570B RID: 22283
	ScannedMailsBeingDeleted,
	// Token: 0x0400570C RID: 22284
	MaintenanceNotice,
	// Token: 0x0400570D RID: 22285
	ExitGame,
	// Token: 0x0400570E RID: 22286
	CreateCharacterNameTooLong,
	// Token: 0x0400570F RID: 22287
	CreateCharacterNameIllegal,
	// Token: 0x04005710 RID: 22288
	AppVersionNotMatch,
	// Token: 0x04005711 RID: 22289
	DefaultExploreSet,
	// Token: 0x04005712 RID: 22290
	DeleteFriend,
	// Token: 0x04005713 RID: 22291
	BlockFriend,
	// Token: 0x04005714 RID: 22292
	SaveExploreSet,
	// Token: 0x04005715 RID: 22293
	IgnoreAllFriendApplication,
	// Token: 0x04005716 RID: 22294
	ExchangeNoEnough,
	// Token: 0x04005717 RID: 22295
	GachaCurrency,
	// Token: 0x04005718 RID: 22296
	SecondCurrency,
	// Token: 0x04005719 RID: 22297
	FirstCurrency,
	// Token: 0x0400571A RID: 22298
	ReceiveLevelPlayReward,
	// Token: 0x0400571B RID: 22299
	BreachPreview,
	// Token: 0x0400571C RID: 22300
	DecomposePreview,
	// Token: 0x0400571D RID: 22301
	GachaIsInValid,
	// Token: 0x0400571E RID: 22302
	GachaRefresh,
	// Token: 0x0400571F RID: 22303
	GachaTimeIsMax,
	// Token: 0x04005720 RID: 22304
	VoiceDownloadCell,
	// Token: 0x04005721 RID: 22305
	VoiceDownload,
	// Token: 0x04005722 RID: 22306
	VoiceDelete,
	// Token: 0x04005723 RID: 22307
	PayResTimeOut,
	// Token: 0x04005724 RID: 22308
	DecomposeNoGetItem,
	// Token: 0x04005725 RID: 22309
	SkillTreeReset,
	// Token: 0x04005726 RID: 22310
	BtRollbackTeleport = 77,
	// Token: 0x04005727 RID: 22311
	QuitOnlineWorld,
	// Token: 0x04005728 RID: 22312
	KnockPlayerOnlineWorld,
	// Token: 0x04005729 RID: 22313
	RoleQuestUnlockCheck,
	// Token: 0x0400572A RID: 22314
	VoiceDownloadShortOfSpace,
	// Token: 0x0400572B RID: 22315
	SingleTowerContinue,
	// Token: 0x0400572C RID: 22316
	SingleTowerExit,
	// Token: 0x0400572D RID: 22317
	SingleTowerReSimulate,
	// Token: 0x0400572E RID: 22318
	CycleTowerReset,
	// Token: 0x0400572F RID: 22319
	FunctionNoOpen,
	// Token: 0x04005730 RID: 22320
	CycleTowerLock,
	// Token: 0x04005731 RID: 22321
	CycleTowerContinue,
	// Token: 0x04005732 RID: 22322
	CycleTowerExit,
	// Token: 0x04005733 RID: 22323
	CycleTowerChallengeExit,
	// Token: 0x04005734 RID: 22324
	TakeExpSureTip,
	// Token: 0x04005735 RID: 22325
	AdviceDeleteTips,
	// Token: 0x04005736 RID: 22326
	ConcertoReactionTip,
	// Token: 0x04005737 RID: 22327
	RoleTeachTip,
	// Token: 0x04005738 RID: 22328
	AdviceExpressionDelete,
	// Token: 0x04005739 RID: 22329
	UsingItemRevive = 98,
	// Token: 0x0400573A RID: 22330
	PhantomSupplementTips = 96,
	// Token: 0x0400573B RID: 22331
	PhantomReplaceTips,
	// Token: 0x0400573C RID: 22332
	CycleTowerSeasonRefresh = 99,
	// Token: 0x0400573D RID: 22333
	QuitOnlineWorldAndReduceTeam,
	// Token: 0x0400573E RID: 22334
	MatchingKickOut,
	// Token: 0x0400573F RID: 22335
	MatchingTeamLack,
	// Token: 0x04005740 RID: 22336
	CheckOverlap,
	// Token: 0x04005741 RID: 22337
	ButtonNotSave,
	// Token: 0x04005742 RID: 22338
	ButtonReset,
	// Token: 0x04005743 RID: 22339
	CookFail,
	// Token: 0x04005744 RID: 22340
	UnlockCook,
	// Token: 0x04005745 RID: 22341
	OnlineQuitInstance,
	// Token: 0x04005746 RID: 22342
	SetBirthDay,
	// Token: 0x04005747 RID: 22343
	SetName,
	// Token: 0x04005748 RID: 22344
	OnlineInstanceInvite,
	// Token: 0x04005749 RID: 22345
	ChangeName,
	// Token: 0x0400574A RID: 22346
	ChangeSign,
	// Token: 0x0400574B RID: 22347
	PlayEnd,
	// Token: 0x0400574C RID: 22348
	ActivityEnd,
	// Token: 0x0400574D RID: 22349
	VisionRareTipsOne,
	// Token: 0x0400574E RID: 22350
	VisionRareTipsTwo,
	// Token: 0x0400574F RID: 22351
	VisionRareTipsThree,
	// Token: 0x04005750 RID: 22352
	MainVisionCannotDown,
	// Token: 0x04005751 RID: 22353
	BlankVisionCannotChange,
	// Token: 0x04005752 RID: 22354
	CostOver,
	// Token: 0x04005753 RID: 22355
	DailyActivityRefresh,
	// Token: 0x04005754 RID: 22356
	AbandonCurrentSlotWhenNotSubProp,
	// Token: 0x04005755 RID: 22357
	AbandonCurrentSlot,
	// Token: 0x04005756 RID: 22358
	VisionLevelUpTips3,
	// Token: 0x04005757 RID: 22359
	VisionLevelUpTips2,
	// Token: 0x04005758 RID: 22360
	VisionLevelUpTips1,
	// Token: 0x04005759 RID: 22361
	VisionSlotTips,
	// Token: 0x0400575A RID: 22362
	TotalLimitTimes,
	// Token: 0x0400575B RID: 22363
	TodayResult,
	// Token: 0x0400575C RID: 22364
	TowerLeave = 133,
	// Token: 0x0400575D RID: 22365
	RoguelikeEnter = 135,
	// Token: 0x0400575E RID: 22366
	PayShopRefresh = 131,
	// Token: 0x0400575F RID: 22367
	MonthCardUseTips,
	// Token: 0x04005760 RID: 22368
	IosCloseRecharge = 134,
	// Token: 0x04005761 RID: 22369
	LeaveMultiOnLoading = 136,
	// Token: 0x04005762 RID: 22370
	LeaveTowerOnTowerView,
	// Token: 0x04005763 RID: 22371
	RefreshChargeView,
	// Token: 0x04005764 RID: 22372
	UseSoundBoxDetector,
	// Token: 0x04005765 RID: 22373
	UseTreasureBoxDetectorAtLimit,
	// Token: 0x04005766 RID: 22374
	UseTempTeleportPointer,
	// Token: 0x04005767 RID: 22375
	UseTempTeleportPointerAtLimit,
	// Token: 0x04005768 RID: 22376
	ExploreSkillEmptyEquipItemTips,
	// Token: 0x04005769 RID: 22377
	VisionDownAllEquipmentTip,
	// Token: 0x0400576A RID: 22378
	BattlePassExpireTip,
	// Token: 0x0400576B RID: 22379
	BattlePassTaskExpire,
	// Token: 0x0400576C RID: 22380
	BattlePassTimeWarning,
	// Token: 0x0400576D RID: 22381
	CdKeyVerifySuccess,
	// Token: 0x0400576E RID: 22382
	BattlePassLock,
	// Token: 0x0400576F RID: 22383
	BattlePassOutTime,
	// Token: 0x04005770 RID: 22384
	BattlePassPrimaryRepeat,
	// Token: 0x04005771 RID: 22385
	BattlePassPrimaryTimeWarning,
	// Token: 0x04005772 RID: 22386
	BattlePassUsePrimary,
	// Token: 0x04005773 RID: 22387
	BattlePassUseUpgrade,
	// Token: 0x04005774 RID: 22388
	BattlePassAdvanceRepeat,
	// Token: 0x04005775 RID: 22389
	BattlePassUseAdvance,
	// Token: 0x04005776 RID: 22390
	JumpToCalabash,
	// Token: 0x04005777 RID: 22391
	CostMax,
	// Token: 0x04005778 RID: 22392
	BattlePassAdvanceTimeWarning,
	// Token: 0x04005779 RID: 22393
	CalabashExpTipId,
	// Token: 0x0400577A RID: 22394
	AccountIsBlocked,
	// Token: 0x0400577B RID: 22395
	QuestForceOccupy,
	// Token: 0x0400577C RID: 22396
	CalabashCollectSuitTipId,
	// Token: 0x0400577D RID: 22397
	TeleportDungeonConfirm,
	// Token: 0x0400577E RID: 22398
	BetaDisableCharge,
	// Token: 0x0400577F RID: 22399
	BetaDisableGacha,
	// Token: 0x04005780 RID: 22400
	ItemDestructionConfirm,
	// Token: 0x04005781 RID: 22401
	ClearHotPatchConfirm,
	// Token: 0x04005782 RID: 22402
	PhotoPermissionRequest,
	// Token: 0x04005783 RID: 22403
	UseBuffItemOverflow,
	// Token: 0x04005784 RID: 22404
	OpenPushNotification,
	// Token: 0x04005785 RID: 22405
	InventoryCapacityMax = 173,
	// Token: 0x04005786 RID: 22406
	ItemInvalidTips,
	// Token: 0x04005787 RID: 22407
	RoleSkillLevelUpTip = 172,
	// Token: 0x04005788 RID: 22408
	RoleBreakUpTip = 175,
	// Token: 0x04005789 RID: 22409
	InstancePowerNotEnough,
	// Token: 0x0400578A RID: 22410
	TakeExpOverSureTip = 178,
	// Token: 0x0400578B RID: 22411
	ResetAllInput,
	// Token: 0x0400578C RID: 22412
	SkipPlot,
	// Token: 0x0400578D RID: 22413
	BossRushRoleLess = 188,
	// Token: 0x0400578E RID: 22414
	GachaJumpToMail = 195,
	// Token: 0x0400578F RID: 22415
	DailyAdventureRefresh = 184,
	// Token: 0x04005790 RID: 22416
	HotResourceVersionNotMatch,
	// Token: 0x04005791 RID: 22417
	PatchCleanProcessing,
	// Token: 0x04005792 RID: 22418
	MoonChasingEditTeam,
	// Token: 0x04005793 RID: 22419
	MoonChasingJumpPreQuest = 190,
	// Token: 0x04005794 RID: 22420
	LogoutConfirm,
	// Token: 0x04005795 RID: 22421
	BanIp,
	// Token: 0x04005796 RID: 22422
	BanDevice,
	// Token: 0x04005797 RID: 22423
	BanForever,
	// Token: 0x04005798 RID: 22424
	MoonChasingBusinessJumpToBuilding = 196,
	// Token: 0x04005799 RID: 22425
	MoonChasingBuildingJumpToTask,
	// Token: 0x0400579A RID: 22426
	MoonChasingTaskJumpToBuilding,
	// Token: 0x0400579B RID: 22427
	MoonChasingBusinessJumpToTask,
	// Token: 0x0400579C RID: 22428
	InstanceLevelTooLowToGetPhantom,
	// Token: 0x0400579D RID: 22429
	MoonChasingBusinessEnergyNotEnough,
	// Token: 0x0400579E RID: 22430
	MoonChasingBusinessMoneyNotEnough,
	// Token: 0x0400579F RID: 22431
	BackToLoginAndEnterGame,
	// Token: 0x040057A0 RID: 22432
	MoonChasingJinxiTaskUnlock,
	// Token: 0x040057A1 RID: 22433
	MoonChasingBuildingNotEnough,
	// Token: 0x040057A2 RID: 22434
	MoonChasingRoleCostNotEnough,
	// Token: 0x040057A3 RID: 22435
	TowerDefenseLeaveInstance,
	// Token: 0x040057A4 RID: 22436
	PlatformLoginFail,
	// Token: 0x040057A5 RID: 22437
	PlatformSdkTokenExpire,
	// Token: 0x040057A6 RID: 22438
	MobileInputSwitch = 212,
	// Token: 0x040057A7 RID: 22439
	CannotFindSdkProduct,
	// Token: 0x040057A8 RID: 22440
	SdkServerNetworkError,
	// Token: 0x040057A9 RID: 22441
	PictureConfigOverload,
	// Token: 0x040057AA RID: 22442
	QuickTranser,
	// Token: 0x040057AB RID: 22443
	InstanceRewardTimesNotEnoughSingle,
	// Token: 0x040057AC RID: 22444
	InstanceRewardTimesNotEnoughMulti,
	// Token: 0x040057AD RID: 22445
	InstanceExitReChallengeSingle,
	// Token: 0x040057AE RID: 22446
	TeleportOutOfQuestRangeConfirm,
	// Token: 0x040057AF RID: 22447
	ImageQualityAdjustConfirm,
	// Token: 0x040057B0 RID: 22448
	ShowReviewConfirm,
	// Token: 0x040057B1 RID: 22449
	ShowDoubleCheckQuickTransfer,
	// Token: 0x040057B2 RID: 22450
	GMWorldMapTrans = 225,
	// Token: 0x040057B3 RID: 22451
	AllActivityClose = 224,
	// Token: 0x040057B4 RID: 22452
	WeaponSkinReplace = 226,
	// Token: 0x040057B5 RID: 22453
	SdkBlankTips,
	// Token: 0x040057B6 RID: 22454
	RogueBlackFlower,
	// Token: 0x040057B7 RID: 22455
	NoRoleBuySkin,
	// Token: 0x040057B8 RID: 22456
	EnterPureMode,
	// Token: 0x040057B9 RID: 22457
	RoleSkinTip,
	// Token: 0x040057BA RID: 22458
	BigStuffedBrokenRock,
	// Token: 0x040057BB RID: 22459
	ObtainNoRole,
	// Token: 0x040057BC RID: 22460
	DailyTurntableRefresh,
	// Token: 0x040057BD RID: 22461
	DockyardDeleteItem,
	// Token: 0x040057BE RID: 22462
	DockyardExitFishing,
	// Token: 0x040057BF RID: 22463
	DirectTrainRecommendQuest,
	// Token: 0x040057C0 RID: 22464
	PreOpenSpoilConfirmBox,
	// Token: 0x040057C1 RID: 22465
	RoleGenderChangeConfirmBox = 240,
	// Token: 0x040057C2 RID: 22466
	LifePointBonus = 239,
	// Token: 0x040057C3 RID: 22467
	VisionGroupToTop = 242,
	// Token: 0x040057C4 RID: 22468
	VisionGroupDelete,
	// Token: 0x040057C5 RID: 22469
	VisionGroupOtherRoleUse,
	// Token: 0x040057C6 RID: 22470
	VisionGroupMax,
	// Token: 0x040057C7 RID: 22471
	FishingEntrustGiveUp,
	// Token: 0x040057C8 RID: 22472
	RayTracingOn = 248,
	// Token: 0x040057C9 RID: 22473
	DestroyVisionInGroup = 247,
	// Token: 0x040057CA RID: 22474
	FishingEntrustsTargetSell = 249,
	// Token: 0x040057CB RID: 22475
	ActivityPreOpen = 251,
	// Token: 0x040057CC RID: 22476
	WeeklyRogueCycleRefresh = 278,
	// Token: 0x040057CD RID: 22477
	ShipTowerLeaveInstance = 252,
	// Token: 0x040057CE RID: 22478
	ConfirmToTeleportToPort,
	// Token: 0x040057CF RID: 22479
	ShipTowerFromViewLeaveInst,
	// Token: 0x040057D0 RID: 22480
	ExploreClearPlayPointMark,
	// Token: 0x040057D1 RID: 22481
	ShipTowerSeasonUpdate,
	// Token: 0x040057D2 RID: 22482
	FishingBait,
	// Token: 0x040057D3 RID: 22483
	FishingBaitLimit,
	// Token: 0x040057D4 RID: 22484
	FishingTeleport,
	// Token: 0x040057D5 RID: 22485
	FishingDeliverEntrustRefresh,
	// Token: 0x040057D6 RID: 22486
	FishingNightTraceSailingInDay,
	// Token: 0x040057D7 RID: 22487
	VisionRefineMaterialHint,
	// Token: 0x040057D8 RID: 22488
	DestroyTemporaryTeleport,
	// Token: 0x040057D9 RID: 22489
	PreDownloadConfirmBox,
	// Token: 0x040057DA RID: 22490
	PreDownloadToSpeedMode,
	// Token: 0x040057DB RID: 22491
	PreDownloadToNormalMode,
	// Token: 0x040057DC RID: 22492
	PreDownloadNoWifi,
	// Token: 0x040057DD RID: 22493
	PreDownloadNoSpace,
	// Token: 0x040057DE RID: 22494
	MatchingTeamLackButNoEnter,
	// Token: 0x040057DF RID: 22495
	ExitGameOrReturnLogin,
	// Token: 0x040057E0 RID: 22496
	BabelTowerClearDeTerm,
	// Token: 0x040057E1 RID: 22497
	GpuDriverVersionLowForRayTracing = 273,
	// Token: 0x040057E2 RID: 22498
	DlssFrameGenerateInvalid = 292,
	// Token: 0x040057E3 RID: 22499
	PreDownloadErrorOneBtn = 274,
	// Token: 0x040057E4 RID: 22500
	PreDownloadErrorTwoBtn,
	// Token: 0x040057E5 RID: 22501
	BabelTowerInstanceDungeonLeave,
	// Token: 0x040057E6 RID: 22502
	BabelTowerLowStarConfirm,
	// Token: 0x040057E7 RID: 22503
	ClientVersionNoMatchOnline = 279,
	// Token: 0x040057E8 RID: 22504
	ClientVersionNoMatchTeam,
	// Token: 0x040057E9 RID: 22505
	DungeonContinuePlayConfirm,
	// Token: 0x040057EA RID: 22506
	ShareReviveRole,
	// Token: 0x040057EB RID: 22507
	AbyssExit,
	// Token: 0x040057EC RID: 22508
	UnfinishedDungeonBoxIdSupportArchive,
	// Token: 0x040057ED RID: 22509
	UnfinishedDungeonBoxId,
	// Token: 0x040057EE RID: 22510
	FinishedDungeonBoxId = 290,
	// Token: 0x040057EF RID: 22511
	FlySkinApplyToAll = 293,
	// Token: 0x040057F0 RID: 22512
	FlySkinApplyHelp,
	// Token: 0x040057F1 RID: 22513
	CiacconaAvgExit,
	// Token: 0x040057F2 RID: 22514
	IOSExitInstanceConfirm,
	// Token: 0x040057F3 RID: 22515
	RacingBetsBettingConfirm,
	// Token: 0x040057F4 RID: 22516
	RacingBetsCancelBettingConfirm,
	// Token: 0x040057F5 RID: 22517
	RacingBetsBettingEndConfirm,
	// Token: 0x040057F6 RID: 22518
	AbyssUnlockTip,
	// Token: 0x040057F7 RID: 22519
	DangoQuitWorld = 317,
	// Token: 0x040057F8 RID: 22520
	Dxr1_1NotSupported = 301,
	// Token: 0x040057F9 RID: 22521
	BirthdayExitConfirm,
	// Token: 0x040057FA RID: 22522
	DangoAbyssEquipPluginDiffDango,
	// Token: 0x040057FB RID: 22523
	MapRogueGiveUpReward,
	// Token: 0x040057FC RID: 22524
	DangoAbyssLockSlotToLevelUp,
	// Token: 0x040057FD RID: 22525
	RogueResDungeonContinue,
	// Token: 0x040057FE RID: 22526
	PreDownloadOnClickedClose,
	// Token: 0x040057FF RID: 22527
	RacingBetsExitDungeonConfirm,
	// Token: 0x04005800 RID: 22528
	MapRogueHighLvEventConfirm,
	// Token: 0x04005801 RID: 22529
	RogueResCancelDungeonConfirm,
	// Token: 0x04005802 RID: 22530
	FocusModeSwitchConfirm,
	// Token: 0x04005803 RID: 22531
	BeforeEnterFocusModeConfirm,
	// Token: 0x04005804 RID: 22532
	ResDownLoadDoneConfirm,
	// Token: 0x04005805 RID: 22533
	PhantomArenaExitDeckBuilderViewConfirm,
	// Token: 0x04005806 RID: 22534
	PhantomArenaDeleteDeckConfirm,
	// Token: 0x04005807 RID: 22535
	VulkanOn,
	// Token: 0x04005808 RID: 22536
	LoginResDownLoadFailedConfirm = 318,
	// Token: 0x04005809 RID: 22537
	PhantomArenaQuicklyBuildConfirm,
	// Token: 0x0400580A RID: 22538
	BabelTowerTeamTipsConfirm,
	// Token: 0x0400580B RID: 22539
	VideoResDownLoadShortOfSpaceConfirm,
	// Token: 0x0400580C RID: 22540
	FocusModeSwitchToCommonQuest,
	// Token: 0x0400580D RID: 22541
	CloseFocusQuestTips = 341,
	// Token: 0x0400580E RID: 22542
	PhantomArenaBattleRoundOver = 323,
	// Token: 0x0400580F RID: 22543
	FilterSettingChangingConfirm,
	// Token: 0x04005810 RID: 22544
	PhantomArenaOneCostCardNotEnough,
	// Token: 0x04005811 RID: 22545
	InstanceDungeonMultiStart,
	// Token: 0x04005812 RID: 22546
	InstanceDungeonMatchStart,
	// Token: 0x04005813 RID: 22547
	BeginnerCarnivalNoRole,
	// Token: 0x04005814 RID: 22548
	BeginnerCarnivalGetRole,
	// Token: 0x04005815 RID: 22549
	RedMagic90Fps,
	// Token: 0x04005816 RID: 22550
	PhantomManageBatchDisposeConfirm,
	// Token: 0x04005817 RID: 22551
	VisionLevelUpIdentifyLessMin,
	// Token: 0x04005818 RID: 22552
	VisionLevelUpIdentifyLessTarget,
	// Token: 0x04005819 RID: 22553
	FloroRanchArchive,
	// Token: 0x0400581A RID: 22554
	PhantomManageConfigSaveOn,
	// Token: 0x0400581B RID: 22555
	PhantomManageConfigReset,
	// Token: 0x0400581C RID: 22556
	PhantomManageConfigEditReset,
	// Token: 0x0400581D RID: 22557
	PhantomManageConfigEditPreview,
	// Token: 0x0400581E RID: 22558
	FloroRanchCardGroupSelect,
	// Token: 0x0400581F RID: 22559
	FloroRanchSkipComic,
	// Token: 0x04005820 RID: 22560
	FloroRanchExitConfirm = 345,
	// Token: 0x04005821 RID: 22561
	PhantomManageConfigQuitEdit,
	// Token: 0x04005822 RID: 22562
	UsePhantomManagePlanConfirm,
	// Token: 0x04005823 RID: 22563
	RogueResInactiveLinkConfirm,
	// Token: 0x04005824 RID: 22564
	RogueResSkipBattleConfirm,
	// Token: 0x04005825 RID: 22565
	PhantomCapacityMax,
	// Token: 0x04005826 RID: 22566
	TrapDefenseUnloadAndSell,
	// Token: 0x04005827 RID: 22567
	RoleTrialLeaveInstanceConfirm,
	// Token: 0x04005828 RID: 22568
	KingShipExitConfirm,
	// Token: 0x04005829 RID: 22569
	VisionLevelUpTipsOverflow1,
	// Token: 0x0400582A RID: 22570
	VisionLevelUpTipsOverflow2,
	// Token: 0x0400582B RID: 22571
	VisionLevelUpTipsOverflow3,
	// Token: 0x0400582C RID: 22572
	WeaponLevelUpTipsOverflow1,
	// Token: 0x0400582D RID: 22573
	WeaponLevelUpTipsOverflow2,
	// Token: 0x0400582E RID: 22574
	WeaponLevelUpTipsOverflow3,
	// Token: 0x0400582F RID: 22575
	TrapDefenseLevelStarSwitch,
	// Token: 0x04005830 RID: 22576
	TrapDefenseOrganResetAll = 365,
	// Token: 0x04005831 RID: 22577
	TrapDefenseMachineFull = 363,
	// Token: 0x04005832 RID: 22578
	PlayStationConnectFail,
	// Token: 0x04005833 RID: 22579
	SeekTraceAddStep = 366,
	// Token: 0x04005834 RID: 22580
	SeekTraceExit,
	// Token: 0x04005835 RID: 22581
	TrapDefenseOrganReset,
	// Token: 0x04005836 RID: 22582
	TrapDefenseNextLevelThreshold = 377,
	// Token: 0x04005837 RID: 22583
	SkipAstrologyItemInspect = 369,
	// Token: 0x04005838 RID: 22584
	OnlineSingleConfirm = 371,
	// Token: 0x04005839 RID: 22585
	FightPhotoActivityEnd = 393,
	// Token: 0x0400583A RID: 22586
	ParallelPackageUpdate = 373,
	// Token: 0x0400583B RID: 22587
	SurvivorsLevelFirstEndlessConfirm = 376,
	// Token: 0x0400583C RID: 22588
	RecommendSwitch = 375,
	// Token: 0x0400583D RID: 22589
	SurvivorsEnterInstConfirm = 378,
	// Token: 0x0400583E RID: 22590
	GameSettingDefaultFilter,
	// Token: 0x0400583F RID: 22591
	PreOpenSpoilConfirmBoxFromRoleDev,
	// Token: 0x04005840 RID: 22592
	EyeProtectModeExit,
	// Token: 0x04005841 RID: 22593
	ShopPurchaseAvailableConfirm = 385,
	// Token: 0x04005842 RID: 22594
	UnFinishFightPhotoLeaveInstanceConfirm = 394,
	// Token: 0x04005843 RID: 22595
	FinishFightPhotoLeaveInstanceConfirm,
	// Token: 0x04005844 RID: 22596
	HonamiStoryQualitySellConfirm = 384,
	// Token: 0x04005845 RID: 22597
	PhantomArenaApplyRecommendDeckConfirm = 412,
	// Token: 0x04005846 RID: 22598
	PhantomArenaRecommendDeckCardInsufficientConfirm,
	// Token: 0x04005847 RID: 22599
	PhantomArenaRecommendOverrideOriginal,
	// Token: 0x04005848 RID: 22600
	PreloadFailConfirm = 386,
	// Token: 0x04005849 RID: 22601
	HonamiStorySlotUnlockConfirm = 389,
	// Token: 0x0400584A RID: 22602
	GameQualityLoadOver = 388,
	// Token: 0x0400584B RID: 22603
	AutoSynthesisOverFlowPop = 390,
	// Token: 0x0400584C RID: 22604
	HonamiStoryLifeSupportLevelConfirm,
	// Token: 0x0400584D RID: 22605
	WeatherCentralTimeSwitchConfirm,
	// Token: 0x0400584E RID: 22606
	QuestResDownloadCellNetworkConfirm = 396,
	// Token: 0x0400584F RID: 22607
	KeySubPackageDownLoadConfirm,
	// Token: 0x04005850 RID: 22608
	SubPackageDownloadCellNetworkConfirm,
	// Token: 0x04005851 RID: 22609
	SubPackageCommonConfirm,
	// Token: 0x04005852 RID: 22610
	SubPackageDownloadListFinishConfirm,
	// Token: 0x04005853 RID: 22611
	LordGymExitInstanceConfirm,
	// Token: 0x04005854 RID: 22612
	ReplaceBuffEquipItemConfirm,
	// Token: 0x04005855 RID: 22613
	MotorcycleDiyChangeConfirm,
	// Token: 0x04005856 RID: 22614
	MotorcycleDiyImportConfirm,
	// Token: 0x04005857 RID: 22615
	SubPackageTeleportToUnFinishAreaConfirm,
	// Token: 0x04005858 RID: 22616
	WheelTowerReturnWorldConfirm,
	// Token: 0x04005859 RID: 22617
	WheelTowerTemplateReplaceConfirm,
	// Token: 0x0400585A RID: 22618
	WheelTowerTeamBuffNotSelectTips,
	// Token: 0x0400585B RID: 22619
	WheelTowerRoundResetAllConfirm,
	// Token: 0x0400585C RID: 22620
	WheelTowerInstanceExitConfirm,
	// Token: 0x0400585D RID: 22621
	WheelTowerInstanceRetryConfirm,
	// Token: 0x0400585E RID: 22622
	LordGymExitConfirm = 416,
	// Token: 0x0400585F RID: 22623
	LordGymThird5ExitConfirm = 535,
	// Token: 0x04005860 RID: 22624
	LordGymThird5BossSelectExitConfirm,
	// Token: 0x04005861 RID: 22625
	HonamiStoryStorageFullConfirm = 418,
	// Token: 0x04005862 RID: 22626
	WheelTowerSelectConflictConfirm = 420,
	// Token: 0x04005863 RID: 22627
	HonamiStoryEquipWeaponConfirm,
	// Token: 0x04005864 RID: 22628
	HonamiStoryTowerRestart,
	// Token: 0x04005865 RID: 22629
	ResonantItemConvertConfirm = 494,
	// Token: 0x04005866 RID: 22630
	PhantomArenaReChallengeConfirm = 423,
	// Token: 0x04005867 RID: 22631
	PhantomInteractConfirmRecommend,
	// Token: 0x04005868 RID: 22632
	SubPackageNeedReLogin,
	// Token: 0x04005869 RID: 22633
	TrialRoleChooseConfirm,
	// Token: 0x0400586A RID: 22634
	AutoPilotQuickGoToTeleportConfirm,
	// Token: 0x0400586B RID: 22635
	WeatherCentralCooldownTips,
	// Token: 0x0400586C RID: 22636
	WeatherCentralTeleportConfirm,
	// Token: 0x0400586D RID: 22637
	DrinkPrevConfirm,
	// Token: 0x0400586E RID: 22638
	DrinkCloseConfirm,
	// Token: 0x0400586F RID: 22639
	DrinkNoBatchingConfirm,
	// Token: 0x04005870 RID: 22640
	FurnitureExitConfirm,
	// Token: 0x04005871 RID: 22641
	SpringManorPhantomExhibitConfirm,
	// Token: 0x04005872 RID: 22642
	SpringManorWeaponExhibitConfirm,
	// Token: 0x04005873 RID: 22643
	ApplyImageQualityConfirm,
	// Token: 0x04005874 RID: 22644
	EncircleDifficultyChangeConfirm,
	// Token: 0x04005875 RID: 22645
	EncircleExitConfirm,
	// Token: 0x04005876 RID: 22646
	PhantomDirectRefiningWeeklyConfirm,
	// Token: 0x04005877 RID: 22647
	FurniturePlaceToNewSlotConfirm,
	// Token: 0x04005878 RID: 22648
	FurniturePresetApplyConfirm,
	// Token: 0x04005879 RID: 22649
	GuessJokerExitConfirm = 459,
	// Token: 0x0400587A RID: 22650
	FurniturePresetFillAndApplyConfirm = 442,
	// Token: 0x0400587B RID: 22651
	MotorFightActivityEnd = 461,
	// Token: 0x0400587C RID: 22652
	FurnitureSwitchAreaConfirm = 443,
	// Token: 0x0400587D RID: 22653
	KeySettingResetConfirm = 446,
	// Token: 0x0400587E RID: 22654
	VisionRefineSubUnderTwo,
	// Token: 0x0400587F RID: 22655
	EncircleResetConfirm,
	// Token: 0x04005880 RID: 22656
	TotalTopUpClaimRoleConfirm,
	// Token: 0x04005881 RID: 22657
	VisionRefineSubGreaterEqualTwo,
	// Token: 0x04005882 RID: 22658
	FurnitureDesignSaveAndTeleportConfirm,
	// Token: 0x04005883 RID: 22659
	FlagChallengeFormationNotFullConfirm,
	// Token: 0x04005884 RID: 22660
	FindSunSpiritReduceConfirm,
	// Token: 0x04005885 RID: 22661
	AutoClearUnusedResourcesConfirm,
	// Token: 0x04005886 RID: 22662
	PhantomFullFusionConfirm = 456,
	// Token: 0x04005887 RID: 22663
	PhantomFullDiscardConfirm,
	// Token: 0x04005888 RID: 22664
	FurnitureTeleportConfirm = 460,
	// Token: 0x04005889 RID: 22665
	WheelTowerReChallengeConfirm = 458,
	// Token: 0x0400588A RID: 22666
	PhantomConfigApplyPreRecommendConfirm = 462,
	// Token: 0x0400588B RID: 22667
	PhantomConfigApplyClearPlanConfirm,
	// Token: 0x0400588C RID: 22668
	PhantomConfigSaveCloseEditConfirm,
	// Token: 0x0400588D RID: 22669
	PhantomConfigAutoDiscardNot5Confirm,
	// Token: 0x0400588E RID: 22670
	PhantomConfigCanUpdateSelf,
	// Token: 0x0400588F RID: 22671
	PhantomConfigUsePlayerPlant,
	// Token: 0x04005890 RID: 22672
	FlagChallengeBattleExitConfirm,
	// Token: 0x04005891 RID: 22673
	TetrisLoseConfirm,
	// Token: 0x04005892 RID: 22674
	TetrisQuitConfirm,
	// Token: 0x04005893 RID: 22675
	TetrisDifficultyChangeConfirm,
	// Token: 0x04005894 RID: 22676
	TetrisTakeBackConfirm,
	// Token: 0x04005895 RID: 22677
	PhantomDiscardFusionConfirm = 474,
	// Token: 0x04005896 RID: 22678
	VisionRefineSubResultConfirm = 476,
	// Token: 0x04005897 RID: 22679
	RoguelikeInstEnterConfirm = 478,
	// Token: 0x04005898 RID: 22680
	BossPilingExitConfirm,
	// Token: 0x04005899 RID: 22681
	RhythmCalibrationExitConfirm,
	// Token: 0x0400589A RID: 22682
	PinballBattleRestartConfirm,
	// Token: 0x0400589B RID: 22683
	PinballBattleRestartCowConfirm,
	// Token: 0x0400589C RID: 22684
	PinballWeaponReplaceConfirm,
	// Token: 0x0400589D RID: 22685
	PinballWeaponOverCapacityConfirm,
	// Token: 0x0400589E RID: 22686
	TetrisGameFailConfirm,
	// Token: 0x0400589F RID: 22687
	ClearBlockSubPackageConfirm = 488,
	// Token: 0x040058A0 RID: 22688
	MotorDiyDeletePresetConfirm,
	// Token: 0x040058A1 RID: 22689
	MotorDiyChangePresetConfirm,
	// Token: 0x040058A2 RID: 22690
	TetrisGameCloseConfirm,
	// Token: 0x040058A3 RID: 22691
	PinballBattleResetLaunchConfirm,
	// Token: 0x040058A4 RID: 22692
	KurotatoArchiveConfirm,
	// Token: 0x040058A5 RID: 22693
	PhantomRefreshAcceptConfirm = 495,
	// Token: 0x040058A6 RID: 22694
	KurotatoOverwriteSave,
	// Token: 0x040058A7 RID: 22695
	RacingBetsExitDungeonBackFightConfirm,
	// Token: 0x040058A8 RID: 22696
	GolemHackingNormalLevelExitConfirm,
	// Token: 0x040058A9 RID: 22697
	GolemHackingMainLevelExitConfirm,
	// Token: 0x040058AA RID: 22698
	PhantomRefreshRejectConfirm,
	// Token: 0x040058AB RID: 22699
	CyberpunkConfirm,
	// Token: 0x040058AC RID: 22700
	XboxBindAccountWithRegionConfirm,
	// Token: 0x040058AD RID: 22701
	KurotatoDieConfirm,
	// Token: 0x040058AE RID: 22702
	KurotatoDieNoLimitConfirm = 540,
	// Token: 0x040058AF RID: 22703
	KurotatoNotBuyConfirm = 504,
	// Token: 0x040058B0 RID: 22704
	CyberPunkExitChallengeViewConfirm,
	// Token: 0x040058B1 RID: 22705
	CyberPunkExitDungeonConfirm,
	// Token: 0x040058B2 RID: 22706
	CyberPunkDirectionConfirm,
	// Token: 0x040058B3 RID: 22707
	RoleLangCustomConfirm,
	// Token: 0x040058B4 RID: 22708
	KurotatoSaveNotifyConfirm,
	// Token: 0x040058B5 RID: 22709
	FloroRanchWeeklyArchiveConfirm,
	// Token: 0x040058B6 RID: 22710
	MotorDiyNewPresetConfirm,
	// Token: 0x040058B7 RID: 22711
	KurotatoSellWeaponConfirm = 513,
	// Token: 0x040058B8 RID: 22712
	RoguelikeBossChallengeExitConfirm,
	// Token: 0x040058B9 RID: 22713
	QuestFastReturnConfirm = 542,
	// Token: 0x040058BA RID: 22714
	QuestFastReturnViaWorldMapConfirm,
	// Token: 0x040058BB RID: 22715
	FastReturnDungeonConfirm,
	// Token: 0x040058BC RID: 22716
	RoguelikeOverwriteArchiveConfirm = 515,
	// Token: 0x040058BD RID: 22717
	RoguelikeGiveUpArchiveConfirm,
	// Token: 0x040058BE RID: 22718
	RoguelikeTempArchiveProcessConfirm,
	// Token: 0x040058BF RID: 22719
	RoguelikeBossChallengeLeaveArchiveConfirm,
	// Token: 0x040058C0 RID: 22720
	RoguelikeNormalLeaveArchiveConfirm = 530,
	// Token: 0x040058C1 RID: 22721
	RoverlikeResultConfirm = 545,
	// Token: 0x040058C2 RID: 22722
	CyberPunkRoleTrialExitConfirm = 512,
	// Token: 0x040058C3 RID: 22723
	FloroRanchEventToyGridNotEnough = 520,
	// Token: 0x040058C4 RID: 22724
	FloroRanchWeeklyEnd = 537,
	// Token: 0x040058C5 RID: 22725
	VoiceDownloadLoginConfirm = 523,
	// Token: 0x040058C6 RID: 22726
	VoiceDownloadLoginConfirmCell,
	// Token: 0x040058C7 RID: 22727
	CdkGiftBuyConfirm = 521,
	// Token: 0x040058C8 RID: 22728
	XboxExitGame,
	// Token: 0x040058C9 RID: 22729
	BuyItemSecondConfirm = 550,
	// Token: 0x040058CA RID: 22730
	SheriffCloseConfirm = 525,
	// Token: 0x040058CB RID: 22731
	SheriffRestartConfirm,
	// Token: 0x040058CC RID: 22732
	SubPackageRecommendConfirm = 531,
	// Token: 0x040058CD RID: 22733
	KurotatoEndSpecialWaveCombatConfirm,
	// Token: 0x040058CE RID: 22734
	DollGrabMachineExitConfirm = 528,
	// Token: 0x040058CF RID: 22735
	GuideLordGymExitDungeonConfirm = 533,
	// Token: 0x040058D0 RID: 22736
	GuideLordGymExitChallengeConfirm,
	// Token: 0x040058D1 RID: 22737
	ExpiredFavoriteMailUnfavoriteConfirm = 548,
	// Token: 0x040058D2 RID: 22738
	RoverRogueSaveEnterConfirm = 556,
	// Token: 0x040058D3 RID: 22739
	RoverRogueLootNotMatchConfirm = 555,
	// Token: 0x040058D4 RID: 22740
	FavoriteMailDeleteConfirm = 549,
	// Token: 0x040058D5 RID: 22741
	BabelTowerQuickSelectConfirm = 539,
	// Token: 0x040058D6 RID: 22742
	DollGrabMachineEndlessRestartConfirm = 529,
	// Token: 0x040058D7 RID: 22743
	ConfigReloadTips = 541,
	// Token: 0x040058D8 RID: 22744
	DollGrabMachineNoEnoughItem = 527,
	// Token: 0x040058D9 RID: 22745
	DangoBrawlEnterSaveConfirm = 538,
	// Token: 0x040058DA RID: 22746
	DangoBrawlReStartConfirm = 551,
	// Token: 0x040058DB RID: 22747
	RestartRecall = 553,
	// Token: 0x040058DC RID: 22748
	SaveAndExitRecall,
	// Token: 0x040058DD RID: 22749
	DangoBrawlEnterAdditionalConfirm = 557,
	// Token: 0x040058DE RID: 22750
	RecallResourceDownLoadConfirm,
	// Token: 0x040058DF RID: 22751
	RecallResourceDownLoadingTips,
	// Token: 0x040058E0 RID: 22752
	ResourceStandardChangeConfirm,
	// Token: 0x040058E1 RID: 22753
	DangoBrawlSellConfirm,
	// Token: 0x040058E2 RID: 22754
	PhotoExitSaveConfirm,
	// Token: 0x040058E3 RID: 22755
	MatchThreeLowerDifficultyConfirm = 565,
	// Token: 0x040058E4 RID: 22756
	MatchThreeRestartConfirm,
	// Token: 0x040058E5 RID: 22757
	MatchThreeExitConfirm,
	// Token: 0x040058E6 RID: 22758
	DangoBrawlEnterFinalSettleConfirm = 570,
	// Token: 0x040058E7 RID: 22759
	DangoBrawlSellFollowerConfirm,
	// Token: 0x040058E8 RID: 22760
	ItemDestroyStackHighQualityConfirm,
	// Token: 0x040058E9 RID: 22761
	ItemDestroyStackConfirm
}
