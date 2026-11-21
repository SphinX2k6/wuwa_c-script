using System;

// Token: 0x02000252 RID: 594
public enum EEventName
{
	// Token: 0x04001874 RID: 6260
	SetEntityCreatureDataRelation,
	// Token: 0x04001875 RID: 6261
	WorldPartitionDataLayerStateUpdated,
	// Token: 0x04001876 RID: 6262
	KeyClick,
	// Token: 0x04001877 RID: 6263
	UiSceneLoaded,
	// Token: 0x04001878 RID: 6264
	UiSceneStartLoad,
	// Token: 0x04001879 RID: 6265
	OnUiScenePostLoaded,
	// Token: 0x0400187A RID: 6266
	UiSceneLastStepInLoadScene,
	// Token: 0x0400187B RID: 6267
	UiSceneLastStepInExitScene,
	// Token: 0x0400187C RID: 6268
	OpenView,
	// Token: 0x0400187D RID: 6269
	StackPreOpenView,
	// Token: 0x0400187E RID: 6270
	StackViewTransitionStart,
	// Token: 0x0400187F RID: 6271
	StackViewTransitionEnd,
	// Token: 0x04001880 RID: 6272
	StackOpenView,
	// Token: 0x04001881 RID: 6273
	StackCloseView,
	// Token: 0x04001882 RID: 6274
	OnNormalTopViewChange,
	// Token: 0x04001883 RID: 6275
	FloatQueueCloseView,
	// Token: 0x04001884 RID: 6276
	OpenViewBegined,
	// Token: 0x04001885 RID: 6277
	OpenViewFail,
	// Token: 0x04001886 RID: 6278
	CreateViewInstance,
	// Token: 0x04001887 RID: 6279
	OnViewLoadCompleted,
	// Token: 0x04001888 RID: 6280
	OnViewDone,
	// Token: 0x04001889 RID: 6281
	OnViewHidden,
	// Token: 0x0400188A RID: 6282
	CloseView,
	// Token: 0x0400188B RID: 6283
	CloseCompositeRewardView,
	// Token: 0x0400188C RID: 6284
	OpenTabView,
	// Token: 0x0400188D RID: 6285
	TriggerUiTimeDilation,
	// Token: 0x0400188E RID: 6286
	CloseTabView,
	// Token: 0x0400188F RID: 6287
	ChangeChildView,
	// Token: 0x04001890 RID: 6288
	SwitchAdventureGuideViewTab,
	// Token: 0x04001891 RID: 6289
	UiManagerInit,
	// Token: 0x04001892 RID: 6290
	UiManagerDestroy,
	// Token: 0x04001893 RID: 6291
	HotKeyInput,
	// Token: 0x04001894 RID: 6292
	ViewHotKeyInputPress,
	// Token: 0x04001895 RID: 6293
	ViewHotKeyInputRelease,
	// Token: 0x04001896 RID: 6294
	ResetNormalAction,
	// Token: 0x04001897 RID: 6295
	UnBlockCharacterAction,
	// Token: 0x04001898 RID: 6296
	ResetSystemAction,
	// Token: 0x04001899 RID: 6297
	OnReduceDamageViewDepth,
	// Token: 0x0400189A RID: 6298
	LevelSequencePlayerBandStateChange,
	// Token: 0x0400189B RID: 6299
	UIViewPortSizeChanged,
	// Token: 0x0400189C RID: 6300
	OnDynamicScrollViewClearItem,
	// Token: 0x0400189D RID: 6301
	LoginSuccess,
	// Token: 0x0400189E RID: 6302
	EnterGameSuccess,
	// Token: 0x0400189F RID: 6303
	LoginStatusChange,
	// Token: 0x040018A0 RID: 6304
	LoginRequestResult,
	// Token: 0x040018A1 RID: 6305
	SdkLoginResult,
	// Token: 0x040018A2 RID: 6306
	OnGetLoginPlayerInfo,
	// Token: 0x040018A3 RID: 6307
	OnSelectServerItem,
	// Token: 0x040018A4 RID: 6308
	OnConfirmServerItem,
	// Token: 0x040018A5 RID: 6309
	OnNetworkDetectionSelectServerItem,
	// Token: 0x040018A6 RID: 6310
	OnConfirmNetworkDetectionItem,
	// Token: 0x040018A7 RID: 6311
	SendHeartbeat,
	// Token: 0x040018A8 RID: 6312
	SdkInitDone,
	// Token: 0x040018A9 RID: 6313
	SdkPayEnd,
	// Token: 0x040018AA RID: 6314
	PlayStationJoinSessionEvent,
	// Token: 0x040018AB RID: 6315
	SdkRefreshAccessToken,
	// Token: 0x040018AC RID: 6316
	SdkRefreshNoticeRedDot,
	// Token: 0x040018AD RID: 6317
	CharQteActive,
	// Token: 0x040018AE RID: 6318
	CharQteConsume,
	// Token: 0x040018AF RID: 6319
	CharInQteChanged,
	// Token: 0x040018B0 RID: 6320
	CharExecuteQte,
	// Token: 0x040018B1 RID: 6321
	CharExecuteMultiQte,
	// Token: 0x040018B2 RID: 6322
	CharQteTagRowNameChanged,
	// Token: 0x040018B3 RID: 6323
	CharHitLocal,
	// Token: 0x040018B4 RID: 6324
	CharHitRemote,
	// Token: 0x040018B5 RID: 6325
	CharBeHitLocal,
	// Token: 0x040018B6 RID: 6326
	CharHitIncludingVision,
	// Token: 0x040018B7 RID: 6327
	CharBeHitRemote,
	// Token: 0x040018B8 RID: 6328
	CharLimitDodge,
	// Token: 0x040018B9 RID: 6329
	CharBeHitAnim,
	// Token: 0x040018BA RID: 6330
	CharBeforeSetHitRotator,
	// Token: 0x040018BB RID: 6331
	CharBeHitTimeScale,
	// Token: 0x040018BC RID: 6332
	CharShieldChange,
	// Token: 0x040018BD RID: 6333
	CharAnimBreakPoint,
	// Token: 0x040018BE RID: 6334
	CharBeforeSkillWithTarget,
	// Token: 0x040018BF RID: 6335
	CharBeforeSkill,
	// Token: 0x040018C0 RID: 6336
	ConditionDrivenSMTickLock,
	// Token: 0x040018C1 RID: 6337
	CharBeforeInterruptWithTarget,
	// Token: 0x040018C2 RID: 6338
	CharGameplayCueChanged,
	// Token: 0x040018C3 RID: 6339
	CharUseSkill,
	// Token: 0x040018C4 RID: 6340
	CharUseSkillRemote,
	// Token: 0x040018C5 RID: 6341
	OnCharJump,
	// Token: 0x040018C6 RID: 6342
	OnSkillEnd,
	// Token: 0x040018C7 RID: 6343
	CharStopAllSkills,
	// Token: 0x040018C8 RID: 6344
	CharStopGroup1Skill,
	// Token: 0x040018C9 RID: 6345
	CharSetShowTarget,
	// Token: 0x040018CA RID: 6346
	CharEndShowTarget,
	// Token: 0x040018CB RID: 6347
	OnSkillSimulateMontage,
	// Token: 0x040018CC RID: 6348
	OnBeforeSkillSimulateMontage,
	// Token: 0x040018CD RID: 6349
	OnBeforeBeCaughtWithTarget,
	// Token: 0x040018CE RID: 6350
	OnMultiSkillIdChanged,
	// Token: 0x040018CF RID: 6351
	OnMultiSkillEnable,
	// Token: 0x040018D0 RID: 6352
	CharSwitchControl,
	// Token: 0x040018D1 RID: 6353
	CharSkillTargetChanged,
	// Token: 0x040018D2 RID: 6354
	CharDeleteSkill,
	// Token: 0x040018D3 RID: 6355
	CharResetSkill,
	// Token: 0x040018D4 RID: 6356
	CharInterruptSkill,
	// Token: 0x040018D5 RID: 6357
	CharSkillCountChanged,
	// Token: 0x040018D6 RID: 6358
	CharSkillRemainCdChanged,
	// Token: 0x040018D7 RID: 6359
	CharSkillCdPauseStateChanged,
	// Token: 0x040018D8 RID: 6360
	CharClearSkill,
	// Token: 0x040018D9 RID: 6361
	SpecialSkillLuPaSwitchLockTarget,
	// Token: 0x040018DA RID: 6362
	SpecialSkillRebeccaSwitchLockTarget,
	// Token: 0x040018DB RID: 6363
	FuLuoLuoAddDuplicatedEnergy,
	// Token: 0x040018DC RID: 6364
	CharDamage,
	// Token: 0x040018DD RID: 6365
	CharKillTarget,
	// Token: 0x040018DE RID: 6366
	CharBeKilled,
	// Token: 0x040018DF RID: 6367
	CharBeDamage,
	// Token: 0x040018E0 RID: 6368
	GlobalCharDamage,
	// Token: 0x040018E1 RID: 6369
	FormationPanelUIShowRoleHeal,
	// Token: 0x040018E2 RID: 6370
	CharPartDamage,
	// Token: 0x040018E3 RID: 6371
	FollowShooterForwardEvent,
	// Token: 0x040018E4 RID: 6372
	OnBuffTriggerEvent,
	// Token: 0x040018E5 RID: 6373
	CharAfterFrozenChange,
	// Token: 0x040018E6 RID: 6374
	CharClimbStartExit,
	// Token: 0x040018E7 RID: 6375
	CharActivateClimbInput,
	// Token: 0x040018E8 RID: 6376
	CharClimbJumpCheck,
	// Token: 0x040018E9 RID: 6377
	CustomMoveSwim,
	// Token: 0x040018EA RID: 6378
	CustomMoveSlide,
	// Token: 0x040018EB RID: 6379
	CustomMoveSki,
	// Token: 0x040018EC RID: 6380
	CustomMoveRailSlide,
	// Token: 0x040018ED RID: 6381
	CustomMoveRide,
	// Token: 0x040018EE RID: 6382
	CustomMoveWalkOnWater,
	// Token: 0x040018EF RID: 6383
	CustomMoveClimb,
	// Token: 0x040018F0 RID: 6384
	CustomMoveGlide,
	// Token: 0x040018F1 RID: 6385
	CustomMovePendulum,
	// Token: 0x040018F2 RID: 6386
	CustomMoveCatapult,
	// Token: 0x040018F3 RID: 6387
	CustomMoveSoar,
	// Token: 0x040018F4 RID: 6388
	CustomMoveRoll,
	// Token: 0x040018F5 RID: 6389
	CustomMoveSplineClimb,
	// Token: 0x040018F6 RID: 6390
	CustomMoveFloating,
	// Token: 0x040018F7 RID: 6391
	RequestRestartRailSlide,
	// Token: 0x040018F8 RID: 6392
	CharTurnBegin,
	// Token: 0x040018F9 RID: 6393
	CharTurnEnd,
	// Token: 0x040018FA RID: 6394
	PerformMontageStop,
	// Token: 0x040018FB RID: 6395
	CharMovementModeChanged,
	// Token: 0x040018FC RID: 6396
	CharActivate,
	// Token: 0x040018FD RID: 6397
	CharOnAttrChanged,
	// Token: 0x040018FE RID: 6398
	CharGravityDirectChanged,
	// Token: 0x040018FF RID: 6399
	AnyCharGravityDirectChanged,
	// Token: 0x04001900 RID: 6400
	CharOnRoleDrown,
	// Token: 0x04001901 RID: 6401
	CharOnRoleDrownInjure,
	// Token: 0x04001902 RID: 6402
	CharOnEnergyChanged,
	// Token: 0x04001903 RID: 6403
	CharOnHealthChanged,
	// Token: 0x04001904 RID: 6404
	CharOnHealthMaxChanged,
	// Token: 0x04001905 RID: 6405
	CharOnElementEnergyChanged,
	// Token: 0x04001906 RID: 6406
	MonsterBeginBroken,
	// Token: 0x04001907 RID: 6407
	UltraSkillInteract,
	// Token: 0x04001908 RID: 6408
	CharOnUnifiedMoveStateChanged,
	// Token: 0x04001909 RID: 6409
	CharOnPositionStateChanged,
	// Token: 0x0400190A RID: 6410
	CharOnDirectionStateChanged,
	// Token: 0x0400190B RID: 6411
	CharOnPositionSubStateChanged,
	// Token: 0x0400190C RID: 6412
	CharSwimStrengthChanged,
	// Token: 0x0400190D RID: 6413
	RoleOnStateInherit,
	// Token: 0x0400190E RID: 6414
	CharOnEndPlay,
	// Token: 0x0400190F RID: 6415
	CharOnBuffAddUITexture,
	// Token: 0x04001910 RID: 6416
	CharOnBuffAddUIPrefab,
	// Token: 0x04001911 RID: 6417
	CharOnBuffAddUIDamage,
	// Token: 0x04001912 RID: 6418
	CharOnBuffAddRoleSideEnergyBar,
	// Token: 0x04001913 RID: 6419
	CharOnBuffAddShowMoraleBuffTips,
	// Token: 0x04001914 RID: 6420
	OnRoverlikeQSkillBuff,
	// Token: 0x04001915 RID: 6421
	SeamlessTravelUIRefresh,
	// Token: 0x04001916 RID: 6422
	CharOnAnimNotifyStateDurationChange,
	// Token: 0x04001917 RID: 6423
	CharOnLand,
	// Token: 0x04001918 RID: 6424
	CharPossessed,
	// Token: 0x04001919 RID: 6425
	CharUnpossessed,
	// Token: 0x0400191A RID: 6426
	CharChangeMeshAnim,
	// Token: 0x0400191B RID: 6427
	CharRecordOperate,
	// Token: 0x0400191C RID: 6428
	CharInputAction,
	// Token: 0x0400191D RID: 6429
	CharBasePlatformChanged,
	// Token: 0x0400191E RID: 6430
	CharHoldingHandsChanged,
	// Token: 0x0400191F RID: 6431
	CharOnRoleDeadBefore,
	// Token: 0x04001920 RID: 6432
	CharOnRoleDead,
	// Token: 0x04001921 RID: 6433
	CharOnRoleDeadTargetSelf,
	// Token: 0x04001922 RID: 6434
	CharOnRoleDeadEnd,
	// Token: 0x04001923 RID: 6435
	OnRevive,
	// Token: 0x04001924 RID: 6436
	CharOnRevive,
	// Token: 0x04001925 RID: 6437
	OnAnyRevive,
	// Token: 0x04001926 RID: 6438
	CharOnAnyRevive,
	// Token: 0x04001927 RID: 6439
	OnTeamLivingStateChange,
	// Token: 0x04001928 RID: 6440
	OnShareReviveTimesChange,
	// Token: 0x04001929 RID: 6441
	OnRoleReviveCooldownChange,
	// Token: 0x0400192A RID: 6442
	OnDying,
	// Token: 0x0400192B RID: 6443
	CharOnDying,
	// Token: 0x0400192C RID: 6444
	CharOnSetNewBeHit,
	// Token: 0x0400192D RID: 6445
	OnBattleStateChanged,
	// Token: 0x0400192E RID: 6446
	OnChangeWalkOrRun,
	// Token: 0x0400192F RID: 6447
	CharOnFallInjure,
	// Token: 0x04001930 RID: 6448
	ChangeAiTeamLevel,
	// Token: 0x04001931 RID: 6449
	AiHateAddOrRemove,
	// Token: 0x04001932 RID: 6450
	AiInFight,
	// Token: 0x04001933 RID: 6451
	AiHateTargetChanged,
	// Token: 0x04001934 RID: 6452
	AiTauntAddOrRemove,
	// Token: 0x04001935 RID: 6453
	AiTaskWanderForResetEnd,
	// Token: 0x04001936 RID: 6454
	OnRunBehaviorTree,
	// Token: 0x04001937 RID: 6455
	OnAiEnable,
	// Token: 0x04001938 RID: 6456
	OnAiDisable,
	// Token: 0x04001939 RID: 6457
	OnBeforeAiDisable,
	// Token: 0x0400193A RID: 6458
	OnPatrolStart,
	// Token: 0x0400193B RID: 6459
	OnPatrolPause,
	// Token: 0x0400193C RID: 6460
	OnPatrolResume,
	// Token: 0x0400193D RID: 6461
	OnPatrolStop,
	// Token: 0x0400193E RID: 6462
	CloseItemTips,
	// Token: 0x0400193F RID: 6463
	CreateRoleForwardAnimEnd,
	// Token: 0x04001940 RID: 6464
	CreateRoleShowInputName,
	// Token: 0x04001941 RID: 6465
	GuideFinish,
	// Token: 0x04001942 RID: 6466
	GuideGroupOpening,
	// Token: 0x04001943 RID: 6467
	GuideGroupFinished,
	// Token: 0x04001944 RID: 6468
	GuideGroupBreak,
	// Token: 0x04001945 RID: 6469
	GuideGroupRest,
	// Token: 0x04001946 RID: 6470
	GuideFocusNeedUiTabView,
	// Token: 0x04001947 RID: 6471
	FinishGuideStepByEvent,
	// Token: 0x04001948 RID: 6472
	GuideTouchIdInject,
	// Token: 0x04001949 RID: 6473
	OnRefreshRoleHp,
	// Token: 0x0400194A RID: 6474
	BeforeLoadMap,
	// Token: 0x0400194B RID: 6475
	BeforeTravelMap,
	// Token: 0x0400194C RID: 6476
	EndTravelMap,
	// Token: 0x0400194D RID: 6477
	OnEnterTransitionMap,
	// Token: 0x0400194E RID: 6478
	SeamlessTravelFinishBeforeShowUI,
	// Token: 0x0400194F RID: 6479
	AfterLoadMap,
	// Token: 0x04001950 RID: 6480
	ClearWorld,
	// Token: 0x04001951 RID: 6481
	OnUiManagerClearAsync,
	// Token: 0x04001952 RID: 6482
	WorldDone,
	// Token: 0x04001953 RID: 6483
	WorldDoneAndCloseLoading,
	// Token: 0x04001954 RID: 6484
	ChangeMode,
	// Token: 0x04001955 RID: 6485
	ChangeModeFinish,
	// Token: 0x04001956 RID: 6486
	ChangePerformanceLimitMode,
	// Token: 0x04001957 RID: 6487
	PauseGame,
	// Token: 0x04001958 RID: 6488
	OnInitRole,
	// Token: 0x04001959 RID: 6489
	OnChangeRole,
	// Token: 0x0400195A RID: 6490
	OnOtherChangeRole,
	// Token: 0x0400195B RID: 6491
	OnChangeRoleCoolDownChanged,
	// Token: 0x0400195C RID: 6492
	OnBeforeChangeRole,
	// Token: 0x0400195D RID: 6493
	OnRoleGoDown,
	// Token: 0x0400195E RID: 6494
	OnRoleGoDownFinish,
	// Token: 0x0400195F RID: 6495
	OnOtherRoleGoDownFinish,
	// Token: 0x04001960 RID: 6496
	OnRoleGoUpEnable,
	// Token: 0x04001961 RID: 6497
	OnRoleGoUp,
	// Token: 0x04001962 RID: 6498
	OnClearFollowData,
	// Token: 0x04001963 RID: 6499
	OnRoleGameplayAnimInstChanged,
	// Token: 0x04001964 RID: 6500
	InitArea,
	// Token: 0x04001965 RID: 6501
	InitStaticEntity,
	// Token: 0x04001966 RID: 6502
	OnManuallyClearStreamingPool,
	// Token: 0x04001967 RID: 6503
	OnManuallyResetStreamingPool,
	// Token: 0x04001968 RID: 6504
	OnDeadEyeModeTrigger,
	// Token: 0x04001969 RID: 6505
	OnDeadEyeModeShowShooter,
	// Token: 0x0400196A RID: 6506
	OnDeadEyeModeStageChange,
	// Token: 0x0400196B RID: 6507
	OnDeadEyeModeFinish,
	// Token: 0x0400196C RID: 6508
	DeadEyeModeTargetPointCanLockStateChange,
	// Token: 0x0400196D RID: 6509
	DeadEyeModeTargetPointLocked,
	// Token: 0x0400196E RID: 6510
	DeadEyeModeShootingPerformance,
	// Token: 0x0400196F RID: 6511
	TransportFindPath,
	// Token: 0x04001970 RID: 6512
	TransportSystemInitDone,
	// Token: 0x04001971 RID: 6513
	VehicleMemberBlockByTraceTarget,
	// Token: 0x04001972 RID: 6514
	ChangeArea,
	// Token: 0x04001973 RID: 6515
	UpdateAreaView,
	// Token: 0x04001974 RID: 6516
	CreateEntity,
	// Token: 0x04001975 RID: 6517
	CreateEntityFail,
	// Token: 0x04001976 RID: 6518
	AddEntity,
	// Token: 0x04001977 RID: 6519
	FixBornLocation,
	// Token: 0x04001978 RID: 6520
	CharBornFinished,
	// Token: 0x04001979 RID: 6521
	PreloadEntityFinished,
	// Token: 0x0400197A RID: 6522
	RemoveEntity,
	// Token: 0x0400197B RID: 6523
	RemoveEntityFromBindGroup,
	// Token: 0x0400197C RID: 6524
	EntityOnLandedPush,
	// Token: 0x0400197D RID: 6525
	EntityVarUpdate,
	// Token: 0x0400197E RID: 6526
	SpawnPlayer,
	// Token: 0x0400197F RID: 6527
	OnUpdateTeamGroupType,
	// Token: 0x04001980 RID: 6528
	OnBeforeUpdateSceneTeam,
	// Token: 0x04001981 RID: 6529
	OnUpdateSceneTeam,
	// Token: 0x04001982 RID: 6530
	OnItemDecompose,
	// Token: 0x04001983 RID: 6531
	OnItemLock,
	// Token: 0x04001984 RID: 6532
	OnItemFuncValueChange,
	// Token: 0x04001985 RID: 6533
	OnItemFuncValueBatchChange,
	// Token: 0x04001986 RID: 6534
	OnGetReward,
	// Token: 0x04001987 RID: 6535
	OnReceivePlayerVar,
	// Token: 0x04001988 RID: 6536
	OpenItemInfo,
	// Token: 0x04001989 RID: 6537
	CloseItemInfo,
	// Token: 0x0400198A RID: 6538
	BoughtItem,
	// Token: 0x0400198B RID: 6539
	ShopUpdate,
	// Token: 0x0400198C RID: 6540
	OnShopInfoResponded,
	// Token: 0x0400198D RID: 6541
	OnGoodUnlock,
	// Token: 0x0400198E RID: 6542
	SelectedMail,
	// Token: 0x0400198F RID: 6543
	PickingAttachment,
	// Token: 0x04001990 RID: 6544
	DeletingMail,
	// Token: 0x04001991 RID: 6545
	DeletingMailPassively,
	// Token: 0x04001992 RID: 6546
	AddingNewMail,
	// Token: 0x04001993 RID: 6547
	SwitchUnfinishedFlag,
	// Token: 0x04001994 RID: 6548
	MailFavoriteChanged,
	// Token: 0x04001995 RID: 6549
	CloseMailView,
	// Token: 0x04001996 RID: 6550
	OnlyCloseMailContentView,
	// Token: 0x04001997 RID: 6551
	SceneBulletOwnerCreated,
	// Token: 0x04001998 RID: 6552
	BulletCreate,
	// Token: 0x04001999 RID: 6553
	BulletDestroy,
	// Token: 0x0400199A RID: 6554
	BulletHit,
	// Token: 0x0400199B RID: 6555
	PreBulletCreateFromAnimNotify,
	// Token: 0x0400199C RID: 6556
	PostBulletCreateFromAnimNotify,
	// Token: 0x0400199D RID: 6557
	BulletRebound,
	// Token: 0x0400199E RID: 6558
	BulletHitSpecialCharacter,
	// Token: 0x0400199F RID: 6559
	BulletHitAirWall,
	// Token: 0x040019A0 RID: 6560
	BulletPatternEnvironmentChanged,
	// Token: 0x040019A1 RID: 6561
	ScenePlayerChanged,
	// Token: 0x040019A2 RID: 6562
	ScenePlayerLocationChanged,
	// Token: 0x040019A3 RID: 6563
	ScenePlayerLeaveScene,
	// Token: 0x040019A4 RID: 6564
	ScenePlayerMarkItemStateChange,
	// Token: 0x040019A5 RID: 6565
	MatchTeamFlagChange,
	// Token: 0x040019A6 RID: 6566
	LoadingViewProgressSequenceEnd,
	// Token: 0x040019A7 RID: 6567
	LoadingViewOnAfterShow,
	// Token: 0x040019A8 RID: 6568
	DestroyAllUiCameraAnimationHandles,
	// Token: 0x040019A9 RID: 6569
	RoleSelectionListUpdate,
	// Token: 0x040019AA RID: 6570
	SelectRole,
	// Token: 0x040019AB RID: 6571
	SelectSkill,
	// Token: 0x040019AC RID: 6572
	SelectLevelUpItem,
	// Token: 0x040019AD RID: 6573
	RoleInfoUpdate,
	// Token: 0x040019AE RID: 6574
	RoleRefreshAttribute,
	// Token: 0x040019AF RID: 6575
	RoleSkillLevelUp,
	// Token: 0x040019B0 RID: 6576
	RoleLevelUp,
	// Token: 0x040019B1 RID: 6577
	RoleLevelUpReceiveItem,
	// Token: 0x040019B2 RID: 6578
	RoleBreakUp,
	// Token: 0x040019B3 RID: 6579
	ActiveRole,
	// Token: 0x040019B4 RID: 6580
	RoleSkinRedDotRefresh,
	// Token: 0x040019B5 RID: 6581
	HuluSkinRedDotRefresh,
	// Token: 0x040019B6 RID: 6582
	RoleOrnamentRedDotRefresh,
	// Token: 0x040019B7 RID: 6583
	MainViewRoleButtonRefreshByRoleOrnament,
	// Token: 0x040019B8 RID: 6584
	MainViewRoleButtonRefreshByRoleSkin,
	// Token: 0x040019B9 RID: 6585
	RoleResonUplevel,
	// Token: 0x040019BA RID: 6586
	RoleResonActive,
	// Token: 0x040019BB RID: 6587
	RoleResonAnimationSuccess,
	// Token: 0x040019BC RID: 6588
	RoleResonPlayAnimation,
	// Token: 0x040019BD RID: 6589
	RoleLangCustomFuncClicked,
	// Token: 0x040019BE RID: 6590
	RoleLangCustomRefresh,
	// Token: 0x040019BF RID: 6591
	CloseRoleView,
	// Token: 0x040019C0 RID: 6592
	SelectedResonanceTab,
	// Token: 0x040019C1 RID: 6593
	UnSelectedResonanceTab,
	// Token: 0x040019C2 RID: 6594
	SwitchRootTabState,
	// Token: 0x040019C3 RID: 6595
	RoleRefreshName,
	// Token: 0x040019C4 RID: 6596
	RoleSystemChangeRole,
	// Token: 0x040019C5 RID: 6597
	RoleSystemDeleteRole,
	// Token: 0x040019C6 RID: 6598
	OnSelectedRoleChanged,
	// Token: 0x040019C7 RID: 6599
	OnRoleMorphTypeChanged,
	// Token: 0x040019C8 RID: 6600
	HideVisionTabRole,
	// Token: 0x040019C9 RID: 6601
	ChangeResonance,
	// Token: 0x040019CA RID: 6602
	OnRoleInternalViewEnter,
	// Token: 0x040019CB RID: 6603
	OnRoleInternalViewQuit,
	// Token: 0x040019CC RID: 6604
	AttributeComponentEvent,
	// Token: 0x040019CD RID: 6605
	UpdateRoleLevelUpViewData,
	// Token: 0x040019CE RID: 6606
	UpdateRoleResonanceDetailView,
	// Token: 0x040019CF RID: 6607
	UpdateRoleSkillLevelUpView,
	// Token: 0x040019D0 RID: 6608
	RefreshSkillTreeInfoTabView,
	// Token: 0x040019D1 RID: 6609
	SkillTreeRefresh,
	// Token: 0x040019D2 RID: 6610
	RefreshSkillTreeLeftSkillPoint,
	// Token: 0x040019D3 RID: 6611
	SkillTreeReset,
	// Token: 0x040019D4 RID: 6612
	SkillTreeClickEmpty,
	// Token: 0x040019D5 RID: 6613
	SkillTreeNodeActive,
	// Token: 0x040019D6 RID: 6614
	SkillTreeNodeLevelUp,
	// Token: 0x040019D7 RID: 6615
	OnSkillTreeNodeToggleClick,
	// Token: 0x040019D8 RID: 6616
	UpdateRoleFavorData,
	// Token: 0x040019D9 RID: 6617
	UnLockRoleFavorItem,
	// Token: 0x040019DA RID: 6618
	RoleFavorExpChange,
	// Token: 0x040019DB RID: 6619
	UpdateRoleFavorHintView,
	// Token: 0x040019DC RID: 6620
	RefreshFunctionOpenView,
	// Token: 0x040019DD RID: 6621
	ExploreComponentTargetChanged,
	// Token: 0x040019DE RID: 6622
	UpdateRoleBreachView,
	// Token: 0x040019DF RID: 6623
	OnClickSkillLevelUp,
	// Token: 0x040019E0 RID: 6624
	OnClickSkillActive,
	// Token: 0x040019E1 RID: 6625
	OnEnterOrExitUltraSkill,
	// Token: 0x040019E2 RID: 6626
	OnRoleSkinChange,
	// Token: 0x040019E3 RID: 6627
	OnRoleSkinSubViewShow,
	// Token: 0x040019E4 RID: 6628
	OnInteractionWaterTypeChange,
	// Token: 0x040019E5 RID: 6629
	OnRoleBackgroundMusicEnabledChanged,
	// Token: 0x040019E6 RID: 6630
	OnCurTrialRoleGroupChanged,
	// Token: 0x040019E7 RID: 6631
	OnGroupTrialRoleChanged,
	// Token: 0x040019E8 RID: 6632
	OnRoleSkillBranchChanged,
	// Token: 0x040019E9 RID: 6633
	OnSkillShowTagToggleChanged,
	// Token: 0x040019EA RID: 6634
	WeaponLevelUp,
	// Token: 0x040019EB RID: 6635
	WeaponLevelUpReceiveItem,
	// Token: 0x040019EC RID: 6636
	WeaponCanGoBreach,
	// Token: 0x040019ED RID: 6637
	WeaponBreakUp,
	// Token: 0x040019EE RID: 6638
	WeaponRoleEquipChanged,
	// Token: 0x040019EF RID: 6639
	WeaponRoleLevelUp,
	// Token: 0x040019F0 RID: 6640
	WeaponRoleBreakUp,
	// Token: 0x040019F1 RID: 6641
	WeaponItemClick,
	// Token: 0x040019F2 RID: 6642
	WeaponEmptyClick,
	// Token: 0x040019F3 RID: 6643
	WeaponSortClick,
	// Token: 0x040019F4 RID: 6644
	WeaponMaterialPropClick,
	// Token: 0x040019F5 RID: 6645
	EquipWeapon,
	// Token: 0x040019F6 RID: 6646
	ContrastWeapon,
	// Token: 0x040019F7 RID: 6647
	WeaponResonanceSuccess,
	// Token: 0x040019F8 RID: 6648
	ReConnectBegin,
	// Token: 0x040019F9 RID: 6649
	ReConnectFail,
	// Token: 0x040019FA RID: 6650
	CanNotReConnect,
	// Token: 0x040019FB RID: 6651
	ReConnectSuccess,
	// Token: 0x040019FC RID: 6652
	BackLoginView,
	// Token: 0x040019FD RID: 6653
	LogOut,
	// Token: 0x040019FE RID: 6654
	ExitGamePush,
	// Token: 0x040019FF RID: 6655
	NetWorkMaskRpcAdd,
	// Token: 0x04001A00 RID: 6656
	NetWorkMaskRpcRemove,
	// Token: 0x04001A01 RID: 6657
	OnAimStateChanged,
	// Token: 0x04001A02 RID: 6658
	OnPhantomInputDataUpdate,
	// Token: 0x04001A03 RID: 6659
	OpenDragonPoolView,
	// Token: 0x04001A04 RID: 6660
	UpdateDragonPoolView,
	// Token: 0x04001A05 RID: 6661
	LoadMapTileFinish,
	// Token: 0x04001A06 RID: 6662
	MapOpenFogChange,
	// Token: 0x04001A07 RID: 6663
	MapOpenFogFullUpdate,
	// Token: 0x04001A08 RID: 6664
	MapAreaDarkShow,
	// Token: 0x04001A09 RID: 6665
	WorldMapSecondaryUiClosed,
	// Token: 0x04001A0A RID: 6666
	WorldMapSecondaryUiOpened,
	// Token: 0x04001A0B RID: 6667
	BlackScreenFadeOnPlotToWorldMap,
	// Token: 0x04001A0C RID: 6668
	MarkMenuClickItem,
	// Token: 0x04001A0D RID: 6669
	TrackMenuClickItem,
	// Token: 0x04001A0E RID: 6670
	RefreshMenuSetting,
	// Token: 0x04001A0F RID: 6671
	OnGameplaySettingsSet,
	// Token: 0x04001A10 RID: 6672
	ModelReady,
	// Token: 0x04001A11 RID: 6673
	MapReplaceMarkResponse,
	// Token: 0x04001A12 RID: 6674
	CreateMapMark,
	// Token: 0x04001A13 RID: 6675
	CreateTempMapMark,
	// Token: 0x04001A14 RID: 6676
	AddMapMark,
	// Token: 0x04001A15 RID: 6677
	RemoveMapMark,
	// Token: 0x04001A16 RID: 6678
	TrackMapMark,
	// Token: 0x04001A17 RID: 6679
	MarkHideState,
	// Token: 0x04001A18 RID: 6680
	OnMapMarkTaskComplete,
	// Token: 0x04001A19 RID: 6681
	UnlockTeleport,
	// Token: 0x04001A1A RID: 6682
	TrackMark,
	// Token: 0x04001A1B RID: 6683
	UnTrackMark,
	// Token: 0x04001A1C RID: 6684
	OnMarkItemTrackStateChange,
	// Token: 0x04001A1D RID: 6685
	ClearTrackMark,
	// Token: 0x04001A1E RID: 6686
	MarkForceVisibleChanged,
	// Token: 0x04001A1F RID: 6687
	UpdateTrackTarget,
	// Token: 0x04001A20 RID: 6688
	SetTrackMarkOccupied,
	// Token: 0x04001A21 RID: 6689
	TeleportComplete,
	// Token: 0x04001A22 RID: 6690
	TeleportChangeLocation,
	// Token: 0x04001A23 RID: 6691
	TeleportStart,
	// Token: 0x04001A24 RID: 6692
	TeleportStartEntity,
	// Token: 0x04001A25 RID: 6693
	TeleportOpenLoadingEnd,
	// Token: 0x04001A26 RID: 6694
	SetFightDtTypeForDebug,
	// Token: 0x04001A27 RID: 6695
	OnEnterDailyQuestNotifyRange,
	// Token: 0x04001A28 RID: 6696
	OnEnterNearbyTrackRange,
	// Token: 0x04001A29 RID: 6697
	OnLeaveNearbyTrackRange,
	// Token: 0x04001A2A RID: 6698
	RemoveNearbyTrack,
	// Token: 0x04001A2B RID: 6699
	UpdateNearbyTrackTag,
	// Token: 0x04001A2C RID: 6700
	OnUpdateNearbyEnable,
	// Token: 0x04001A2D RID: 6701
	OnUpdateCompassActive,
	// Token: 0x04001A2E RID: 6702
	WorldMapViewOpened,
	// Token: 0x04001A2F RID: 6703
	WorldMapPointerDown,
	// Token: 0x04001A30 RID: 6704
	WorldMapPointerDrag,
	// Token: 0x04001A31 RID: 6705
	WorldMapJoystickMoveForward,
	// Token: 0x04001A32 RID: 6706
	WorldMapJoystickMoveRight,
	// Token: 0x04001A33 RID: 6707
	WorldMapFocusPlayer,
	// Token: 0x04001A34 RID: 6708
	WorldMapShowTrackList,
	// Token: 0x04001A35 RID: 6709
	WorldMapDragInertia,
	// Token: 0x04001A36 RID: 6710
	WorldMapPointerUp,
	// Token: 0x04001A37 RID: 6711
	WorldMapFingerExpandClose,
	// Token: 0x04001A38 RID: 6712
	WorldMapWheelAxisInput,
	// Token: 0x04001A39 RID: 6713
	WorldMapHandleTriggerAxisInput,
	// Token: 0x04001A3A RID: 6714
	WorldMapZoomBtnInput,
	// Token: 0x04001A3B RID: 6715
	WorldMapPositionChanged,
	// Token: 0x04001A3C RID: 6716
	WorldMapUpdateMultiMap,
	// Token: 0x04001A3D RID: 6717
	WorldMapScaleTierChanged,
	// Token: 0x04001A3E RID: 6718
	OnTreasureChestCountChanged,
	// Token: 0x04001A3F RID: 6719
	MoveWorldMapToPosition,
	// Token: 0x04001A40 RID: 6720
	TaskRangeTrackStateChange,
	// Token: 0x04001A41 RID: 6721
	RangeTrackStateChanged,
	// Token: 0x04001A42 RID: 6722
	GetAreaProgress,
	// Token: 0x04001A43 RID: 6723
	PlaySoundTrackEffect,
	// Token: 0x04001A44 RID: 6724
	WorldMapNavigate,
	// Token: 0x04001A45 RID: 6725
	WorldMapFirstNavigateSelect,
	// Token: 0x04001A46 RID: 6726
	WorldMapSecondNavigateSelect,
	// Token: 0x04001A47 RID: 6727
	WorldMapFocalMarkItem,
	// Token: 0x04001A48 RID: 6728
	ChangeWorldMap,
	// Token: 0x04001A49 RID: 6729
	WorldMapBeforeChangeMap,
	// Token: 0x04001A4A RID: 6730
	WorldMapAfterChangeMap,
	// Token: 0x04001A4B RID: 6731
	WorldMapOpenedForQuestMapFocus,
	// Token: 0x04001A4C RID: 6732
	EnterAreaNotify,
	// Token: 0x04001A4D RID: 6733
	MiniMapForceUpdate,
	// Token: 0x04001A4E RID: 6734
	MultiMapUnlockChanged,
	// Token: 0x04001A4F RID: 6735
	MapAreaShowClickArea,
	// Token: 0x04001A50 RID: 6736
	MapExploreDetailItemClick,
	// Token: 0x04001A51 RID: 6737
	OnUpdateExploreProgressBar,
	// Token: 0x04001A52 RID: 6738
	OnUpdateGravityBtn,
	// Token: 0x04001A53 RID: 6739
	OnMarkTopRightIconUpdate,
	// Token: 0x04001A54 RID: 6740
	WorldMapActivityListDataUpdate,
	// Token: 0x04001A55 RID: 6741
	WorldMapExtraMarkTypeVisibleChange,
	// Token: 0x04001A56 RID: 6742
	OpenExtraUiFromMap,
	// Token: 0x04001A57 RID: 6743
	CloseAllExtraUiFromMap,
	// Token: 0x04001A58 RID: 6744
	WorldMapPanelHudVisibleChanged,
	// Token: 0x04001A59 RID: 6745
	OnWorldMapClose,
	// Token: 0x04001A5A RID: 6746
	SetWorldMapCursorButtonVisible,
	// Token: 0x04001A5B RID: 6747
	UpdatePlotSubtitle,
	// Token: 0x04001A5C RID: 6748
	ShowPlotSubtitleOptions,
	// Token: 0x04001A5D RID: 6749
	UpdatePlotCenterText,
	// Token: 0x04001A5E RID: 6750
	UpdatePortraitVisible,
	// Token: 0x04001A5F RID: 6751
	OnStartFlow,
	// Token: 0x04001A60 RID: 6752
	PlotNetworkStart,
	// Token: 0x04001A61 RID: 6753
	PlotNetworkEnd,
	// Token: 0x04001A62 RID: 6754
	OnExecuteAfterSetPlotMode,
	// Token: 0x04001A63 RID: 6755
	PlotConfigChanged,
	// Token: 0x04001A64 RID: 6756
	PlotDoingTextShow,
	// Token: 0x04001A65 RID: 6757
	ClearPlotSubtitle,
	// Token: 0x04001A66 RID: 6758
	HidePlotUi,
	// Token: 0x04001A67 RID: 6759
	PlotInteractViewOpen,
	// Token: 0x04001A68 RID: 6760
	TriggerPlotInteraction,
	// Token: 0x04001A69 RID: 6761
	TriggerBlackSequence,
	// Token: 0x04001A6A RID: 6762
	OnBlackFadeScreenStart,
	// Token: 0x04001A6B RID: 6763
	OnBlackFadeScreenFinish,
	// Token: 0x04001A6C RID: 6764
	EnableInteractPlot,
	// Token: 0x04001A6D RID: 6765
	EnableSkipPlot,
	// Token: 0x04001A6E RID: 6766
	EnableSkipPlotByReason,
	// Token: 0x04001A6F RID: 6767
	PlotSequencePlay,
	// Token: 0x04001A70 RID: 6768
	PlotSequenceStarted,
	// Token: 0x04001A71 RID: 6769
	PlotSequenceEnd,
	// Token: 0x04001A72 RID: 6770
	HangPlotViewHud,
	// Token: 0x04001A73 RID: 6771
	UpdatePlotUiParam,
	// Token: 0x04001A74 RID: 6772
	PlotViewChange,
	// Token: 0x04001A75 RID: 6773
	PlotViewBgFadePhoto,
	// Token: 0x04001A76 RID: 6774
	PlotViewBgFadeBlackScreen,
	// Token: 0x04001A77 RID: 6775
	PlotStartShowTalk,
	// Token: 0x04001A78 RID: 6776
	PlotEndShowTalk,
	// Token: 0x04001A79 RID: 6777
	PlotShowTalk,
	// Token: 0x04001A7A RID: 6778
	PlotEnableControlView,
	// Token: 0x04001A7B RID: 6779
	PlayPlotSpine,
	// Token: 0x04001A7C RID: 6780
	FiniteSpineEnd,
	// Token: 0x04001A7D RID: 6781
	PrewarFormationChanged,
	// Token: 0x04001A7E RID: 6782
	PrewarReadyChanged,
	// Token: 0x04001A7F RID: 6783
	DissolvePrewar,
	// Token: 0x04001A80 RID: 6784
	SceneStepGroupChanged,
	// Token: 0x04001A81 RID: 6785
	InstanceStepChanged,
	// Token: 0x04001A82 RID: 6786
	InstanceEnterCountChanged,
	// Token: 0x04001A83 RID: 6787
	InstanceEntranceUnlock,
	// Token: 0x04001A84 RID: 6788
	EnterInstanceDungeon,
	// Token: 0x04001A85 RID: 6789
	EnterInstanceDungeonFail,
	// Token: 0x04001A86 RID: 6790
	LeaveInstanceDungeon,
	// Token: 0x04001A87 RID: 6791
	DungeonGuideChange,
	// Token: 0x04001A88 RID: 6792
	LeaveInstanceDungeonConfirm,
	// Token: 0x04001A89 RID: 6793
	LeaveInstanceExternalConfirm,
	// Token: 0x04001A8A RID: 6794
	LeaveInstanceExternalCancel,
	// Token: 0x04001A8B RID: 6795
	OnRefreshInstancedRecommendLevel,
	// Token: 0x04001A8C RID: 6796
	OnDungeonFinish,
	// Token: 0x04001A8D RID: 6797
	OnSelectInstance,
	// Token: 0x04001A8E RID: 6798
	OnSelectInstanceIdChallenge,
	// Token: 0x04001A8F RID: 6799
	OnChallengeInstanceRedDot,
	// Token: 0x04001A90 RID: 6800
	CloseInstanceEntrancePositively,
	// Token: 0x04001A91 RID: 6801
	OnRefreshEditBattleRoleReady,
	// Token: 0x04001A92 RID: 6802
	EntityVisionSkillChanged,
	// Token: 0x04001A93 RID: 6803
	EntityVisionPosChanged,
	// Token: 0x04001A94 RID: 6804
	GetAllVisionSkill,
	// Token: 0x04001A95 RID: 6805
	ActivateAbilityVision,
	// Token: 0x04001A96 RID: 6806
	EndVisionSkill,
	// Token: 0x04001A97 RID: 6807
	ExploreVisionSkill,
	// Token: 0x04001A98 RID: 6808
	VisionMorphBegin,
	// Token: 0x04001A99 RID: 6809
	VisionMorphEnd,
	// Token: 0x04001A9A RID: 6810
	VisionMorphInterrupt,
	// Token: 0x04001A9B RID: 6811
	AddExploreVisionSkill,
	// Token: 0x04001A9C RID: 6812
	ChangeVisionSkillByTab,
	// Token: 0x04001A9D RID: 6813
	ChangeVisionSimplyState,
	// Token: 0x04001A9E RID: 6814
	VisionSkinViewClose,
	// Token: 0x04001A9F RID: 6815
	ChangeCalabashCollectSimplyState,
	// Token: 0x04001AA0 RID: 6816
	SelectedPhantom,
	// Token: 0x04001AA1 RID: 6817
	CheckNewUnlock,
	// Token: 0x04001AA2 RID: 6818
	PhantomEquip,
	// Token: 0x04001AA3 RID: 6819
	PhantomEquipError,
	// Token: 0x04001AA4 RID: 6820
	VisionFilterMonster,
	// Token: 0x04001AA5 RID: 6821
	OnRolePropUpdate,
	// Token: 0x04001AA6 RID: 6822
	RefreshVisionIntensifyViewBackBtnState,
	// Token: 0x04001AA7 RID: 6823
	OnClickVisionIntensifyItemJump,
	// Token: 0x04001AA8 RID: 6824
	VisionIntensifyTabOpen,
	// Token: 0x04001AA9 RID: 6825
	OnVisionLevelUpMaterialPutInModeChange,
	// Token: 0x04001AAA RID: 6826
	OnVisionLevelUpIdentifyChange,
	// Token: 0x04001AAB RID: 6827
	PhantomPersonalSkillActive,
	// Token: 0x04001AAC RID: 6828
	PhantomEquipWithSourceAndTargetPos,
	// Token: 0x04001AAD RID: 6829
	PhantomCostInsufficient,
	// Token: 0x04001AAE RID: 6830
	PhantomExpPreviewChange,
	// Token: 0x04001AAF RID: 6831
	PhantomLevelUp,
	// Token: 0x04001AB0 RID: 6832
	PhantomLevelUpWithId,
	// Token: 0x04001AB1 RID: 6833
	PhantomLevelUpReceiveItem,
	// Token: 0x04001AB2 RID: 6834
	CloseSubPhantomView,
	// Token: 0x04001AB3 RID: 6835
	PhantomBreach,
	// Token: 0x04001AB4 RID: 6836
	PhantomBreachPreview,
	// Token: 0x04001AB5 RID: 6837
	PhantomDecomposePreview,
	// Token: 0x04001AB6 RID: 6838
	PhantomDecompose,
	// Token: 0x04001AB7 RID: 6839
	PhantomMaxLevelSkip,
	// Token: 0x04001AB8 RID: 6840
	HideDelFettersText,
	// Token: 0x04001AB9 RID: 6841
	PhantomRecommendResponse,
	// Token: 0x04001ABA RID: 6842
	ClosePhantomSkillTips,
	// Token: 0x04001ABB RID: 6843
	OnPhantomItemUpdate,
	// Token: 0x04001ABC RID: 6844
	OnPhantomSlotUpdate,
	// Token: 0x04001ABD RID: 6845
	OnPhantomEnableStateChange,
	// Token: 0x04001ABE RID: 6846
	OnVisionIdentify,
	// Token: 0x04001ABF RID: 6847
	OnVisionIdentifyWithId,
	// Token: 0x04001AC0 RID: 6848
	OnVisionIdentifyDoAnimation,
	// Token: 0x04001AC1 RID: 6849
	RefreshVisionIdentifyRedPoint,
	// Token: 0x04001AC2 RID: 6850
	RefreshVisionLevelUpSettingRedPoint,
	// Token: 0x04001AC3 RID: 6851
	RefreshVisionEquipRedPoint,
	// Token: 0x04001AC4 RID: 6852
	JumpToCalabashCollect,
	// Token: 0x04001AC5 RID: 6853
	JumpToPhantomBattleFettersTabView,
	// Token: 0x04001AC6 RID: 6854
	OnVisionSkinEquip,
	// Token: 0x04001AC7 RID: 6855
	RedDotRefreshCalabash,
	// Token: 0x04001AC8 RID: 6856
	HasCalabashExp,
	// Token: 0x04001AC9 RID: 6857
	CloseUpgradeCalabashView,
	// Token: 0x04001ACA RID: 6858
	CloseCalabashExpAddView,
	// Token: 0x04001ACB RID: 6859
	ShowCalabashControllerView,
	// Token: 0x04001ACC RID: 6860
	GetCalabashRewardSuccess,
	// Token: 0x04001ACD RID: 6861
	ShowCalabashUnlockItemTips,
	// Token: 0x04001ACE RID: 6862
	GetCalabashReward,
	// Token: 0x04001ACF RID: 6863
	SelectDirectionalFusionTarget,
	// Token: 0x04001AD0 RID: 6864
	PhantomDirectRefiningWeeklyReset,
	// Token: 0x04001AD1 RID: 6865
	CalabashLevelUpdate,
	// Token: 0x04001AD2 RID: 6866
	CalabashEnterInternalView,
	// Token: 0x04001AD3 RID: 6867
	CalabashQuitInternalView,
	// Token: 0x04001AD4 RID: 6868
	OnVisionRecoveryResult,
	// Token: 0x04001AD5 RID: 6869
	OnVisionRecoveryBatchResult,
	// Token: 0x04001AD6 RID: 6870
	OnVisionRecoveryStorage,
	// Token: 0x04001AD7 RID: 6871
	OnVisionRefineStorage,
	// Token: 0x04001AD8 RID: 6872
	OnVisionRefineResult,
	// Token: 0x04001AD9 RID: 6873
	OnVisionRefineBatchMainResult,
	// Token: 0x04001ADA RID: 6874
	OnVisionRefineSubPreviewResult,
	// Token: 0x04001ADB RID: 6875
	OnVisionRefineSubResult,
	// Token: 0x04001ADC RID: 6876
	OnVisionRefineSubNeedAck,
	// Token: 0x04001ADD RID: 6877
	OnVisionGroupDataUpdate,
	// Token: 0x04001ADE RID: 6878
	OnVisionGroupDataAdd,
	// Token: 0x04001ADF RID: 6879
	OnVisionGroupDataToTop,
	// Token: 0x04001AE0 RID: 6880
	OnVisionGroupDataDelete,
	// Token: 0x04001AE1 RID: 6881
	OnVisionGroupDataChangeName,
	// Token: 0x04001AE2 RID: 6882
	OnRefreshCalabashTabShowState,
	// Token: 0x04001AE3 RID: 6883
	OnSetPartStateVisible,
	// Token: 0x04001AE4 RID: 6884
	ShowHUD,
	// Token: 0x04001AE5 RID: 6885
	HideHUD,
	// Token: 0x04001AE6 RID: 6886
	OnGetPlayerBasicInfo,
	// Token: 0x04001AE7 RID: 6887
	OnLoadedNewFlagConfig,
	// Token: 0x04001AE8 RID: 6888
	OnPlayerLevelChanged,
	// Token: 0x04001AE9 RID: 6889
	OnPlayerExpChanged,
	// Token: 0x04001AEA RID: 6890
	OnLevelUpLevelRefresh,
	// Token: 0x04001AEB RID: 6891
	OnLevelUpExpRefresh,
	// Token: 0x04001AEC RID: 6892
	OnLevelUpShowLevelOnly,
	// Token: 0x04001AED RID: 6893
	SelectFilterMultiple,
	// Token: 0x04001AEE RID: 6894
	SelectFilterSingle,
	// Token: 0x04001AEF RID: 6895
	SelectSort,
	// Token: 0x04001AF0 RID: 6896
	OnLevelPlayStateNotify,
	// Token: 0x04001AF1 RID: 6897
	OnEnterLevelPlayNotify,
	// Token: 0x04001AF2 RID: 6898
	OnLeaveLevelPlayNotify,
	// Token: 0x04001AF3 RID: 6899
	OnSceneItemHit,
	// Token: 0x04001AF4 RID: 6900
	OnSceneItemHitByHitData,
	// Token: 0x04001AF5 RID: 6901
	OnSceneItemEntityHit,
	// Token: 0x04001AF6 RID: 6902
	OnSceneItemEntityHitByHitActorData,
	// Token: 0x04001AF7 RID: 6903
	OnSceneItemEntityHitAlways,
	// Token: 0x04001AF8 RID: 6904
	OnAnySceneItemEntityHit,
	// Token: 0x04001AF9 RID: 6905
	OnAnySceneItemDurabilityChange,
	// Token: 0x04001AFA RID: 6906
	OnSceneItemDurabilityChange,
	// Token: 0x04001AFB RID: 6907
	OnEnableSceneItemDurabilityUI,
	// Token: 0x04001AFC RID: 6908
	OnSceneItemSwitchMoveControl,
	// Token: 0x04001AFD RID: 6909
	UpdateSceneItemState,
	// Token: 0x04001AFE RID: 6910
	OnSceneItemDurabilityEmpty,
	// Token: 0x04001AFF RID: 6911
	OnSceneItemStateChange,
	// Token: 0x04001B00 RID: 6912
	OnSceneItemStatePreChange,
	// Token: 0x04001B01 RID: 6913
	OnSceneItemStatePreChangeInSequence,
	// Token: 0x04001B02 RID: 6914
	OnSceneItemCameraAlertStateChange,
	// Token: 0x04001B03 RID: 6915
	OnEntityConcealedChange,
	// Token: 0x04001B04 RID: 6916
	OnEntityNameChanged,
	// Token: 0x04001B05 RID: 6917
	OnTimeTrackControlUpdate,
	// Token: 0x04001B06 RID: 6918
	OnSceneInteractionLoadCompleted,
	// Token: 0x04001B07 RID: 6919
	OnSceneInteractionLoadCompletedNew,
	// Token: 0x04001B08 RID: 6920
	OnSceneInteractionShowCompleted,
	// Token: 0x04001B09 RID: 6921
	OnSceneInteractionHideCompleted,
	// Token: 0x04001B0A RID: 6922
	OnSceneInteractionAllEffectPlaying,
	// Token: 0x04001B0B RID: 6923
	OnSceneInteractionSequencePlay,
	// Token: 0x04001B0C RID: 6924
	OnSceneInteractionSequenceOver,
	// Token: 0x04001B0D RID: 6925
	OnSceneInteractionStateReached,
	// Token: 0x04001B0E RID: 6926
	OnSceneItemVisionCaptureAdd,
	// Token: 0x04001B0F RID: 6927
	OnSceneItemVisionCaptureRemove,
	// Token: 0x04001B10 RID: 6928
	OnSceneItemVisionCaptureAddFinish,
	// Token: 0x04001B11 RID: 6929
	ShowItemTips,
	// Token: 0x04001B12 RID: 6930
	OnInputDistributeTagChanged,
	// Token: 0x04001B13 RID: 6931
	OnDeviceLangChange,
	// Token: 0x04001B14 RID: 6932
	ForceReleaseInput,
	// Token: 0x04001B15 RID: 6933
	GuideLimitActionInput,
	// Token: 0x04001B16 RID: 6934
	OnFormationPlayLevelUp,
	// Token: 0x04001B17 RID: 6935
	OnFormationPlayRevive,
	// Token: 0x04001B18 RID: 6936
	OnItemUse,
	// Token: 0x04001B19 RID: 6937
	OnSpecialItemUse,
	// Token: 0x04001B1A RID: 6938
	OnLevelTagChanged,
	// Token: 0x04001B1B RID: 6939
	OnGlobalGameplayTagChanged,
	// Token: 0x04001B1C RID: 6940
	LevelEventTriggerExit,
	// Token: 0x04001B1D RID: 6941
	OnLevelPlayStateChange,
	// Token: 0x04001B1E RID: 6942
	OnLevelPlayCompleteNumberChange,
	// Token: 0x04001B1F RID: 6943
	TodTimeChange,
	// Token: 0x04001B20 RID: 6944
	DayStateChange,
	// Token: 0x04001B21 RID: 6945
	CrossDay,
	// Token: 0x04001B22 RID: 6946
	CrossDayZone,
	// Token: 0x04001B23 RID: 6947
	CrossHour,
	// Token: 0x04001B24 RID: 6948
	ClickTimeItem,
	// Token: 0x04001B25 RID: 6949
	OnSelectTimeItem,
	// Token: 0x04001B26 RID: 6950
	AdjustTime,
	// Token: 0x04001B27 RID: 6951
	AdjustTimeInAnim,
	// Token: 0x04001B28 RID: 6952
	PowerShopReady,
	// Token: 0x04001B29 RID: 6953
	OnPowerChanged,
	// Token: 0x04001B2A RID: 6954
	OnPowerChangedWithId,
	// Token: 0x04001B2B RID: 6955
	OnHonamiStoryBackpackUpdate,
	// Token: 0x04001B2C RID: 6956
	OnHonamiStoryLifeSupportLevelUp,
	// Token: 0x04001B2D RID: 6957
	OnHonamiStoryLeaveButtonUpdate,
	// Token: 0x04001B2E RID: 6958
	OnHonamiStoryPowerLevelUpdate,
	// Token: 0x04001B2F RID: 6959
	OnHonamiStoryTechNodeLevelUpdate,
	// Token: 0x04001B30 RID: 6960
	OnHonamiStoryItemCollectGetReward,
	// Token: 0x04001B31 RID: 6961
	OnHonamiStoryMascotRewardReceive,
	// Token: 0x04001B32 RID: 6962
	OnHonamiStoryAreaSecretRewardReceive,
	// Token: 0x04001B33 RID: 6963
	OnHonamiStoryInstInfoUpdate,
	// Token: 0x04001B34 RID: 6964
	OnHonamiStoryPollutionUpdate,
	// Token: 0x04001B35 RID: 6965
	OnHonamiScanMarkInfoUpdate,
	// Token: 0x04001B36 RID: 6966
	OnHonamiStoryPickUpAutoEquip,
	// Token: 0x04001B37 RID: 6967
	OnHonamiStorySortSuccess,
	// Token: 0x04001B38 RID: 6968
	OnHonamiStorySkillDescModeChange,
	// Token: 0x04001B39 RID: 6969
	OnHonamiStoryBackpackClickWeapon,
	// Token: 0x04001B3A RID: 6970
	OnHonamiStorySetVisible,
	// Token: 0x04001B3B RID: 6971
	OnGamePlayCdChanged,
	// Token: 0x04001B3C RID: 6972
	InsertFloatTips,
	// Token: 0x04001B3D RID: 6973
	RemoveFloatTips,
	// Token: 0x04001B3E RID: 6974
	OriginWorldLevelUp,
	// Token: 0x04001B3F RID: 6975
	CurWorldLevelChange,
	// Token: 0x04001B40 RID: 6976
	WorldLevelUpViewRefresh,
	// Token: 0x04001B41 RID: 6977
	OnShowMouseCursor,
	// Token: 0x04001B42 RID: 6978
	RefreshCursor,
	// Token: 0x04001B43 RID: 6979
	MoveCursorToRightDown,
	// Token: 0x04001B44 RID: 6980
	InputDistribute,
	// Token: 0x04001B45 RID: 6981
	OnRefreshJoinTeamRole,
	// Token: 0x04001B46 RID: 6982
	LoadLguiEventSystemActor,
	// Token: 0x04001B47 RID: 6983
	InitializeLguiEventSystemActor,
	// Token: 0x04001B48 RID: 6984
	DestroyLguiEventSystemActor,
	// Token: 0x04001B49 RID: 6985
	OnUseBuffItem,
	// Token: 0x04001B4A RID: 6986
	OnEquipBuffItemUpdate,
	// Token: 0x04001B4B RID: 6987
	UpdateQuestDetails,
	// Token: 0x04001B4C RID: 6988
	UpdateQuestListAndDetails,
	// Token: 0x04001B4D RID: 6989
	UpdateRoleQuestDetails,
	// Token: 0x04001B4E RID: 6990
	QuestUpdateInfoAdd,
	// Token: 0x04001B4F RID: 6991
	AddInteractOptionByAction,
	// Token: 0x04001B50 RID: 6992
	RemoveInteractOptionByAction,
	// Token: 0x04001B51 RID: 6993
	OnQuestStateChange,
	// Token: 0x04001B52 RID: 6994
	OnQuestFinishListNotify,
	// Token: 0x04001B53 RID: 6995
	OnQuestRedDotStateChange,
	// Token: 0x04001B54 RID: 6996
	OnQuestFinishProtocolEnd,
	// Token: 0x04001B55 RID: 6997
	OnRoleQuestAccept,
	// Token: 0x04001B56 RID: 6998
	OnRoleQuestPointChange,
	// Token: 0x04001B57 RID: 6999
	OnRoleQuestNewUnlock,
	// Token: 0x04001B58 RID: 7000
	OnAddNewQuest,
	// Token: 0x04001B59 RID: 7001
	OnNavigationQuest,
	// Token: 0x04001B5A RID: 7002
	ActivityQuestCountdownEnd,
	// Token: 0x04001B5B RID: 7003
	OnQuestStageNameChange,
	// Token: 0x04001B5C RID: 7004
	FocusQuestChange,
	// Token: 0x04001B5D RID: 7005
	LevelGamePlayPrepareCountDownEnd,
	// Token: 0x04001B5E RID: 7006
	GeneralLogicTreeWakeUp,
	// Token: 0x04001B5F RID: 7007
	OnLogicTreeNodeStatusChange,
	// Token: 0x04001B60 RID: 7008
	OnLogicTreeChildQuestNodeStatusChange,
	// Token: 0x04001B61 RID: 7009
	AfterLogicTreeChildQuestNodeStatusChange,
	// Token: 0x04001B62 RID: 7010
	OnLogicTreeNodeProgressChange,
	// Token: 0x04001B63 RID: 7011
	GeneralLogicTreeTimerInfoChanged,
	// Token: 0x04001B64 RID: 7012
	OnGeneralLogicTreeTimerUpdate,
	// Token: 0x04001B65 RID: 7013
	OnLogicTreeTrackUpdate,
	// Token: 0x04001B66 RID: 7014
	CurTrackQuestUnTrackedCheck,
	// Token: 0x04001B67 RID: 7015
	OnLogicTreeTimerTick,
	// Token: 0x04001B68 RID: 7016
	GeneralLogicTreeStartShowTrackText,
	// Token: 0x04001B69 RID: 7017
	GeneralLogicTreeUpdateShowTrackText,
	// Token: 0x04001B6A RID: 7018
	GeneralLogicTreeEndShowTrackText,
	// Token: 0x04001B6B RID: 7019
	TearDownGeneralLogicTree,
	// Token: 0x04001B6C RID: 7020
	GeneralLogicTreeSuspend,
	// Token: 0x04001B6D RID: 7021
	GeneralLogicTreeCancelSuspend,
	// Token: 0x04001B6E RID: 7022
	GeneralLogicTreePrepareRollback,
	// Token: 0x04001B6F RID: 7023
	GeneralLogicTreePrepareRollbackFinish,
	// Token: 0x04001B70 RID: 7024
	GeneralLogicTreeRemovePrepareRollbackNode,
	// Token: 0x04001B71 RID: 7025
	GeneralLogicTreeRollbackWaitingUpdate,
	// Token: 0x04001B72 RID: 7026
	GeneralLogicTreeEntityInteractFinished,
	// Token: 0x04001B73 RID: 7027
	GeneralLogicTreeEntityKilled,
	// Token: 0x04001B74 RID: 7028
	GeneralLogicTreeAddTag,
	// Token: 0x04001B75 RID: 7029
	GeneralLogicTreeRemoveTag,
	// Token: 0x04001B76 RID: 7030
	GeneralLogicTreeViewForceRefresh,
	// Token: 0x04001B77 RID: 7031
	GeneralLogicTreeApplyExpressionOccupation,
	// Token: 0x04001B78 RID: 7032
	GeneralLogicTreeReleaseExpressionOccupation,
	// Token: 0x04001B79 RID: 7033
	GeneralLogicTreeOccupationInfoChanged,
	// Token: 0x04001B7A RID: 7034
	QuestUpdateTipsClickTrack,
	// Token: 0x04001B7B RID: 7035
	QuestUpdateTipsEndSequenceStart,
	// Token: 0x04001B7C RID: 7036
	MissionTrackRuleChange,
	// Token: 0x04001B7D RID: 7037
	MissionPanelOut,
	// Token: 0x04001B7E RID: 7038
	MissionUpdate,
	// Token: 0x04001B7F RID: 7039
	MissionPanelStepTitleAnimStart,
	// Token: 0x04001B80 RID: 7040
	MissionPanelStepTitleAnimEnd,
	// Token: 0x04001B81 RID: 7041
	MissionPanelStepConditionIndexChange,
	// Token: 0x04001B82 RID: 7042
	FailRangeTimerStartShow,
	// Token: 0x04001B83 RID: 7043
	FailRangeTimerEndShow,
	// Token: 0x04001B84 RID: 7044
	OnCreateBehaviorTree,
	// Token: 0x04001B85 RID: 7045
	OnGeneralLogicTreeRemove,
	// Token: 0x04001B86 RID: 7046
	ParkourFinished,
	// Token: 0x04001B87 RID: 7047
	HudInited,
	// Token: 0x04001B88 RID: 7048
	OnOpenDebugCommand,
	// Token: 0x04001B89 RID: 7049
	OnResetToBattleView,
	// Token: 0x04001B8A RID: 7050
	ResetModuleByResetToBattleView,
	// Token: 0x04001B8B RID: 7051
	ResetModuleAfterResetToBattleView,
	// Token: 0x04001B8C RID: 7052
	ExitNormalQueueState,
	// Token: 0x04001B8D RID: 7053
	OnStartLoadingState,
	// Token: 0x04001B8E RID: 7054
	OnFinishLoadingState,
	// Token: 0x04001B8F RID: 7055
	OnOpenLoadingView,
	// Token: 0x04001B90 RID: 7056
	OnCloseLoadingView,
	// Token: 0x04001B91 RID: 7057
	OnLoadingNetDataDone,
	// Token: 0x04001B92 RID: 7058
	PlayUiComponentCloseTween,
	// Token: 0x04001B93 RID: 7059
	ChangeUiComponentMarkId,
	// Token: 0x04001B94 RID: 7060
	OnMenuDataEnableChanged,
	// Token: 0x04001B95 RID: 7061
	OnSelectMenuMainType,
	// Token: 0x04001B96 RID: 7062
	ChangeConfigValue,
	// Token: 0x04001B97 RID: 7063
	RestartFlag,
	// Token: 0x04001B98 RID: 7064
	SettingFrameRateChanged,
	// Token: 0x04001B99 RID: 7065
	TextLanguageChange,
	// Token: 0x04001B9A RID: 7066
	UiPureModeChangedForSettingSystem,
	// Token: 0x04001B9B RID: 7067
	ConfigLoadChange,
	// Token: 0x04001B9C RID: 7068
	AutoMovingSettingChanged,
	// Token: 0x04001B9D RID: 7069
	AutoSprintSettingChanged,
	// Token: 0x04001B9E RID: 7070
	MotorcycleWaterAreaChange,
	// Token: 0x04001B9F RID: 7071
	MotorcycleWaterDetectedStart2,
	// Token: 0x04001BA0 RID: 7072
	MotorcycleWaterDetectedEnd2,
	// Token: 0x04001BA1 RID: 7073
	MotorcycleWaterDetectedTick2,
	// Token: 0x04001BA2 RID: 7074
	MotorcycleBaseMovementChanged,
	// Token: 0x04001BA3 RID: 7075
	MotorcycleAutoAcceleratorSettingChanged,
	// Token: 0x04001BA4 RID: 7076
	MotorcycleAutoNitrogenSettingChanged,
	// Token: 0x04001BA5 RID: 7077
	MotorcycleDriftAcceleratorSettingChanged,
	// Token: 0x04001BA6 RID: 7078
	SneakResult,
	// Token: 0x04001BA7 RID: 7079
	SneakMonsterStart,
	// Token: 0x04001BA8 RID: 7080
	SneakMonsterStop,
	// Token: 0x04001BA9 RID: 7081
	ChannelReset,
	// Token: 0x04001BAA RID: 7082
	OnShareResult,
	// Token: 0x04001BAB RID: 7083
	OnFirstShare,
	// Token: 0x04001BAC RID: 7084
	ShowVideo,
	// Token: 0x04001BAD RID: 7085
	VideoStart,
	// Token: 0x04001BAE RID: 7086
	PlayVideo,
	// Token: 0x04001BAF RID: 7087
	VideoTriggerBlendOut,
	// Token: 0x04001BB0 RID: 7088
	VideoViewShow,
	// Token: 0x04001BB1 RID: 7089
	VideoViewHide,
	// Token: 0x04001BB2 RID: 7090
	ScanTrackedStart,
	// Token: 0x04001BB3 RID: 7091
	ScanTrackedEnd,
	// Token: 0x04001BB4 RID: 7092
	OnScanStart,
	// Token: 0x04001BB5 RID: 7093
	RedDotStart,
	// Token: 0x04001BB6 RID: 7094
	RedDotRefreshItemData,
	// Token: 0x04001BB7 RID: 7095
	RedDotRoleConfigList,
	// Token: 0x04001BB8 RID: 7096
	RedDotRefreshPhantomEquip,
	// Token: 0x04001BB9 RID: 7097
	RedDotRoleChange,
	// Token: 0x04001BBA RID: 7098
	RedDotUnLockPhantom,
	// Token: 0x04001BBB RID: 7099
	RedDotNewTutorial,
	// Token: 0x04001BBC RID: 7100
	RedDotNewTutorialType,
	// Token: 0x04001BBD RID: 7101
	RedDotAdventureManualUpdate,
	// Token: 0x04001BBE RID: 7102
	RedDotSilentFirstAward,
	// Token: 0x04001BBF RID: 7103
	RedDotSilentFirstAwardCategory,
	// Token: 0x04001BC0 RID: 7104
	RedDotSilentFirstAwardResult,
	// Token: 0x04001BC1 RID: 7105
	RedDotCreateRole,
	// Token: 0x04001BC2 RID: 7106
	RouletteRefreshNew,
	// Token: 0x04001BC3 RID: 7107
	RedDotFilter,
	// Token: 0x04001BC4 RID: 7108
	RedDotPhotoSetup,
	// Token: 0x04001BC5 RID: 7109
	OnServerStorageInfoInited,
	// Token: 0x04001BC6 RID: 7110
	SilentTipsRefresh,
	// Token: 0x04001BC7 RID: 7111
	OnRefreshElementBallData,
	// Token: 0x04001BC8 RID: 7112
	ShootTargetStateChanged,
	// Token: 0x04001BC9 RID: 7113
	InteractNavigation,
	// Token: 0x04001BCA RID: 7114
	InteractionViewUpdate,
	// Token: 0x04001BCB RID: 7115
	HideInteractView,
	// Token: 0x04001BCC RID: 7116
	OnInteractViewVisibleChanged,
	// Token: 0x04001BCD RID: 7117
	InteractEntitiesChanged,
	// Token: 0x04001BCE RID: 7118
	SceneItemInteractionEvent,
	// Token: 0x04001BCF RID: 7119
	OnFunctionOpenSet,
	// Token: 0x04001BD0 RID: 7120
	OnFunctionOpenUpdate,
	// Token: 0x04001BD1 RID: 7121
	OnFunctionOpenUpdateNotify,
	// Token: 0x04001BD2 RID: 7122
	OnConcertoResponseOpen,
	// Token: 0x04001BD3 RID: 7123
	OnFirstOpenShopChanged,
	// Token: 0x04001BD4 RID: 7124
	OnSetHeadStateVisible,
	// Token: 0x04001BD5 RID: 7125
	OnSetBossStateVisible,
	// Token: 0x04001BD6 RID: 7126
	SdkKick,
	// Token: 0x04001BD7 RID: 7127
	SdkPostWebViewRedPointRefresh,
	// Token: 0x04001BD8 RID: 7128
	SdkCustomerRedPointRefresh,
	// Token: 0x04001BD9 RID: 7129
	SdkIntroductionRedPointRefresh,
	// Token: 0x04001BDA RID: 7130
	UpdateFriendViewShow,
	// Token: 0x04001BDB RID: 7131
	UpdateRecentlyTeamDataEvent,
	// Token: 0x04001BDC RID: 7132
	OnRemoveFriend,
	// Token: 0x04001BDD RID: 7133
	FriendApplicationListUpdate,
	// Token: 0x04001BDE RID: 7134
	UpdateBlackListShow,
	// Token: 0x04001BDF RID: 7135
	SearchPlayerInfo,
	// Token: 0x04001BE0 RID: 7136
	FriendRemarkLengthLimit,
	// Token: 0x04001BE1 RID: 7137
	FriendRemarkContainsDirtyWord,
	// Token: 0x04001BE2 RID: 7138
	RefreshFriendApplicationRedDot,
	// Token: 0x04001BE3 RID: 7139
	FriendApplyReceived,
	// Token: 0x04001BE4 RID: 7140
	FriendAdded,
	// Token: 0x04001BE5 RID: 7141
	LoadTestFriendsByGm,
	// Token: 0x04001BE6 RID: 7142
	ApplicationHandled,
	// Token: 0x04001BE7 RID: 7143
	ApplicationSent,
	// Token: 0x04001BE8 RID: 7144
	OnGetFriendInitData,
	// Token: 0x04001BE9 RID: 7145
	FriendOnMultiItemAction,
	// Token: 0x04001BEA RID: 7146
	UpdateNavigationListener,
	// Token: 0x04001BEB RID: 7147
	OnVisionAssembleNavigationRefresh,
	// Token: 0x04001BEC RID: 7148
	InputControllerChange,
	// Token: 0x04001BED RID: 7149
	InputControllerMainTypeChange,
	// Token: 0x04001BEE RID: 7150
	ShowTypeChange,
	// Token: 0x04001BEF RID: 7151
	PointerInputTypeChange,
	// Token: 0x04001BF0 RID: 7152
	ControllerConnectChange,
	// Token: 0x04001BF1 RID: 7153
	ChangeScrollBarPosition,
	// Token: 0x04001BF2 RID: 7154
	RefreshGuest,
	// Token: 0x04001BF3 RID: 7155
	ShowGuestEffect,
	// Token: 0x04001BF4 RID: 7156
	OnSelectChatFriend,
	// Token: 0x04001BF5 RID: 7157
	OnCreatePrivateChatRoom,
	// Token: 0x04001BF6 RID: 7158
	OnJoinChatRoom,
	// Token: 0x04001BF7 RID: 7159
	OnAddChatContent,
	// Token: 0x04001BF8 RID: 7160
	OnRefreshChatRedDot,
	// Token: 0x04001BF9 RID: 7161
	OnRefreshChatRoomRedDot,
	// Token: 0x04001BFA RID: 7162
	OnAddHistoryChatContentCompleted,
	// Token: 0x04001BFB RID: 7163
	OnPushChatRowData,
	// Token: 0x04001BFC RID: 7164
	OnPopChatRowData,
	// Token: 0x04001BFD RID: 7165
	OnRefreshChatRowData,
	// Token: 0x04001BFE RID: 7166
	OnAddMutePlayer,
	// Token: 0x04001BFF RID: 7167
	OnRemoveMutePlayer,
	// Token: 0x04001C00 RID: 7168
	OnRemovePrivateChatRoom,
	// Token: 0x04001C01 RID: 7169
	OnClosePrivateChatRoom,
	// Token: 0x04001C02 RID: 7170
	OnOpenChatRoom,
	// Token: 0x04001C03 RID: 7171
	OnSelectExpression,
	// Token: 0x04001C04 RID: 7172
	OnServerAttributeChange,
	// Token: 0x04001C05 RID: 7173
	OnPayItemSuccess,
	// Token: 0x04001C06 RID: 7174
	RefreshPayItemList,
	// Token: 0x04001C07 RID: 7175
	RefreshPayGiftList,
	// Token: 0x04001C08 RID: 7176
	OnPlayerCurrencyChange,
	// Token: 0x04001C09 RID: 7177
	OnRefreshPermissionsSetting,
	// Token: 0x04001C0A RID: 7178
	OnRefreshApply,
	// Token: 0x04001C0B RID: 7179
	OnSearchWorld,
	// Token: 0x04001C0C RID: 7180
	OnRefreshWorldList,
	// Token: 0x04001C0D RID: 7181
	OnRefreshOnlineTeamList,
	// Token: 0x04001C0E RID: 7182
	OnWorldTeamPlayerInfoChanged,
	// Token: 0x04001C0F RID: 7183
	OnRefreshPlayerPing,
	// Token: 0x04001C10 RID: 7184
	OnRefreshPlayerUiState,
	// Token: 0x04001C11 RID: 7185
	OnRefreshOnlineChallengePlayer,
	// Token: 0x04001C12 RID: 7186
	OnRefreshSuggestChallengePlayerInfo,
	// Token: 0x04001C13 RID: 7187
	SwitchPayShopTabItem,
	// Token: 0x04001C14 RID: 7188
	PayShopGoodsBuy,
	// Token: 0x04001C15 RID: 7189
	GoodsRefreshDiscountTime,
	// Token: 0x04001C16 RID: 7190
	SwitchPayShopView,
	// Token: 0x04001C17 RID: 7191
	RefreshPayShop,
	// Token: 0x04001C18 RID: 7192
	RefreshAllPayShop,
	// Token: 0x04001C19 RID: 7193
	RefreshGoods,
	// Token: 0x04001C1A RID: 7194
	RefreshShopAccumulateCurrency,
	// Token: 0x04001C1B RID: 7195
	ShopVersionCodeChange,
	// Token: 0x04001C1C RID: 7196
	GoodsSoldOut,
	// Token: 0x04001C1D RID: 7197
	RefreshGoodsList,
	// Token: 0x04001C1E RID: 7198
	UnLockGoods,
	// Token: 0x04001C1F RID: 7199
	RefreshPayShopEntranceRedDot,
	// Token: 0x04001C20 RID: 7200
	RefreshPayShopInstanceRedDot,
	// Token: 0x04001C21 RID: 7201
	RefreshPayShopTabRedDot,
	// Token: 0x04001C22 RID: 7202
	DiscountShopTimerRefresh,
	// Token: 0x04001C23 RID: 7203
	TryRefreshRootShopMoney,
	// Token: 0x04001C24 RID: 7204
	OnOpenGachaChanged,
	// Token: 0x04001C25 RID: 7205
	OnOpenCommonWeaponSelect,
	// Token: 0x04001C26 RID: 7206
	RefreshGachaMainView,
	// Token: 0x04001C27 RID: 7207
	GachaPoolSelectResponse,
	// Token: 0x04001C28 RID: 7208
	GachaResponse,
	// Token: 0x04001C29 RID: 7209
	GachaHistoryResponse,
	// Token: 0x04001C2A RID: 7210
	CloseGachaSceneView,
	// Token: 0x04001C2B RID: 7211
	GachaNewNotify,
	// Token: 0x04001C2C RID: 7212
	EndGachaScene,
	// Token: 0x04001C2D RID: 7213
	GachaClick,
	// Token: 0x04001C2E RID: 7214
	GachaSelectionViewRefresh,
	// Token: 0x04001C2F RID: 7215
	AfterCloseGachaScene,
	// Token: 0x04001C30 RID: 7216
	PlaySequenceEventByStringParam,
	// Token: 0x04001C31 RID: 7217
	GachaInteractFinish,
	// Token: 0x04001C32 RID: 7218
	ItemExChangeResponse,
	// Token: 0x04001C33 RID: 7219
	GachaAccumulateDataUpdate,
	// Token: 0x04001C34 RID: 7220
	GachaAccumulateRewardClaimed,
	// Token: 0x04001C35 RID: 7221
	GachaAccumulateRedDot,
	// Token: 0x04001C36 RID: 7222
	ItemHintVisibilityChange,
	// Token: 0x04001C37 RID: 7223
	ShowAnimalsHeadInfo,
	// Token: 0x04001C38 RID: 7224
	OnAnimalDying,
	// Token: 0x04001C39 RID: 7225
	OnSkillButtonDataRefresh,
	// Token: 0x04001C3A RID: 7226
	OnSkillButtonDataClear,
	// Token: 0x04001C3B RID: 7227
	OnSkillButtonIndexRefresh,
	// Token: 0x04001C3C RID: 7228
	OnSkillButtonEnableRefresh,
	// Token: 0x04001C3D RID: 7229
	OnSkillButtonVisibleRefresh,
	// Token: 0x04001C3E RID: 7230
	OnSkillButtonSkillIdRefresh,
	// Token: 0x04001C3F RID: 7231
	OnSkillButtonDynamicEffectRefresh,
	// Token: 0x04001C40 RID: 7232
	OnSkillButtonCustomRefresh,
	// Token: 0x04001C41 RID: 7233
	OnSkillButtonCdRefresh,
	// Token: 0x04001C42 RID: 7234
	OnSkillButtonAttributeRefresh,
	// Token: 0x04001C43 RID: 7235
	OnSkillButtonIconPathRefresh,
	// Token: 0x04001C44 RID: 7236
	OnSkillButtonLongPressRefresh,
	// Token: 0x04001C45 RID: 7237
	OnSkillButtonExtraEffectRefresh,
	// Token: 0x04001C46 RID: 7238
	OnSkillButtonSlideControlRefresh,
	// Token: 0x04001C47 RID: 7239
	OnBehaviorButtonEnableRefresh,
	// Token: 0x04001C48 RID: 7240
	OnBehaviorButtonVisibleRefresh,
	// Token: 0x04001C49 RID: 7241
	OnBehaviorButtonSkillIdRefresh,
	// Token: 0x04001C4A RID: 7242
	OnBehaviorButtonIconPathRefresh,
	// Token: 0x04001C4B RID: 7243
	OnBehaviorButtonDynamicEffectRefresh,
	// Token: 0x04001C4C RID: 7244
	OnAttributeLockUpperBoundChange,
	// Token: 0x04001C4D RID: 7245
	OnMotorPadSkillButtonIndexRefresh,
	// Token: 0x04001C4E RID: 7246
	OnInputChangeForCond,
	// Token: 0x04001C4F RID: 7247
	OnInputMoveChanged,
	// Token: 0x04001C50 RID: 7248
	OnFloatingMoveInputChanged,
	// Token: 0x04001C51 RID: 7249
	OnGetNewItem,
	// Token: 0x04001C52 RID: 7250
	OnElementFusion,
	// Token: 0x04001C53 RID: 7251
	OnChangeSelectedExploreId,
	// Token: 0x04001C54 RID: 7252
	OnRouletteViewVisibleChanged,
	// Token: 0x04001C55 RID: 7253
	OnRouletteItemSelect,
	// Token: 0x04001C56 RID: 7254
	OnRouletteItemUnlock,
	// Token: 0x04001C57 RID: 7255
	OnRouletteSaveDataChange,
	// Token: 0x04001C58 RID: 7256
	OpenRouletteSetView,
	// Token: 0x04001C59 RID: 7257
	RouletteSwitchToggleComponentEmit,
	// Token: 0x04001C5A RID: 7258
	RouletteNavigationComponentEmit,
	// Token: 0x04001C5B RID: 7259
	OnAggroAdd,
	// Token: 0x04001C5C RID: 7260
	OnAggroRemoved,
	// Token: 0x04001C5D RID: 7261
	OnBossFight,
	// Token: 0x04001C5E RID: 7262
	OnEntityFightByBpType,
	// Token: 0x04001C5F RID: 7263
	OnSkillTagChanged,
	// Token: 0x04001C60 RID: 7264
	OnMatchingChange,
	// Token: 0x04001C61 RID: 7265
	OnMatchingBegin,
	// Token: 0x04001C62 RID: 7266
	OnEnterTeam,
	// Token: 0x04001C63 RID: 7267
	OnLeaveTeam,
	// Token: 0x04001C64 RID: 7268
	OnEnterOnlineWorld,
	// Token: 0x04001C65 RID: 7269
	OnLeaveOnlineWorld,
	// Token: 0x04001C66 RID: 7270
	OnlineDisableStateChange,
	// Token: 0x04001C67 RID: 7271
	PlayerChallengeStateChange,
	// Token: 0x04001C68 RID: 7272
	OnTriggerVolumeExit,
	// Token: 0x04001C69 RID: 7273
	OnSeasonAreaEffectBegin,
	// Token: 0x04001C6A RID: 7274
	OnSeasonAreaEffectEnd,
	// Token: 0x04001C6B RID: 7275
	RefreshAcquireView,
	// Token: 0x04001C6C RID: 7276
	OnResonanceMaterialChange,
	// Token: 0x04001C6D RID: 7277
	OnAddMaterialController,
	// Token: 0x04001C6E RID: 7278
	OnRemoveMaterialController,
	// Token: 0x04001C6F RID: 7279
	OnAddMaterialControllerGroup,
	// Token: 0x04001C70 RID: 7280
	OnRemoveMaterialControllerGroup,
	// Token: 0x04001C71 RID: 7281
	WeatherChange,
	// Token: 0x04001C72 RID: 7282
	OnManipulateSwitchToNewTarget,
	// Token: 0x04001C73 RID: 7283
	OnManipulateStartChanting,
	// Token: 0x04001C74 RID: 7284
	OnManipulateCancelChanting,
	// Token: 0x04001C75 RID: 7285
	OnManipulateCompleteChanting,
	// Token: 0x04001C76 RID: 7286
	HiddenManipulateUI,
	// Token: 0x04001C77 RID: 7287
	ManipulateStartLockCastTarget,
	// Token: 0x04001C78 RID: 7288
	ManipulateEndLockCastTarget,
	// Token: 0x04001C79 RID: 7289
	OnManipulatableSceneItemPosInFoundation,
	// Token: 0x04001C7A RID: 7290
	AddSubCameraTag,
	// Token: 0x04001C7B RID: 7291
	RemoveSubCameraTag,
	// Token: 0x04001C7C RID: 7292
	AddExtraHoldingTags,
	// Token: 0x04001C7D RID: 7293
	RemoveExtraHoldingTags,
	// Token: 0x04001C7E RID: 7294
	HideJigsawBaseHint,
	// Token: 0x04001C7F RID: 7295
	OnModifyJigsawItemPutIndex,
	// Token: 0x04001C80 RID: 7296
	OnManipulatableItemStateModified,
	// Token: 0x04001C81 RID: 7297
	OnManipulatedItemPosReset,
	// Token: 0x04001C82 RID: 7298
	SetCameraAimVisible,
	// Token: 0x04001C83 RID: 7299
	SetFollowShootAimVisible,
	// Token: 0x04001C84 RID: 7300
	SetFollowShootAutoAimVisible,
	// Token: 0x04001C85 RID: 7301
	SetTDFollowShootAimVisible,
	// Token: 0x04001C86 RID: 7302
	ClickDisplayItem,
	// Token: 0x04001C87 RID: 7303
	OnSelectItemAdd,
	// Token: 0x04001C88 RID: 7304
	DetectSuccess,
	// Token: 0x04001C89 RID: 7305
	AdventureTaskStateChange,
	// Token: 0x04001C8A RID: 7306
	ChapterRewardReceived,
	// Token: 0x04001C8B RID: 7307
	SilentRewardReceived,
	// Token: 0x04001C8C RID: 7308
	AdventureHelpBtn,
	// Token: 0x04001C8D RID: 7309
	NewSoundAreaRefreshReward,
	// Token: 0x04001C8E RID: 7310
	RedDotNewSoundAreaTabUpdate,
	// Token: 0x04001C8F RID: 7311
	RedDotAdventureChallengeTabUpdate,
	// Token: 0x04001C90 RID: 7312
	RedDotAdventureSecondaryUpdate,
	// Token: 0x04001C91 RID: 7313
	RedDotAdventurePeriodicityTabUpdate,
	// Token: 0x04001C92 RID: 7314
	DailyActivityTaskUpdate,
	// Token: 0x04001C93 RID: 7315
	DailyActivityRefresh,
	// Token: 0x04001C94 RID: 7316
	DailyActivityValueChange,
	// Token: 0x04001C95 RID: 7317
	DailyActivityRewardTake,
	// Token: 0x04001C96 RID: 7318
	RefreshActivityRewardPopUp,
	// Token: 0x04001C97 RID: 7319
	DailyActivityCountDownUpdate,
	// Token: 0x04001C98 RID: 7320
	DailyUpdateNotify,
	// Token: 0x04001C99 RID: 7321
	DailyActivityStateNotify,
	// Token: 0x04001C9A RID: 7322
	DailyActivityMainTabOpened,
	// Token: 0x04001C9B RID: 7323
	DailyTaskAreaItemClick,
	// Token: 0x04001C9C RID: 7324
	DailyTaskInfluenceItemClick,
	// Token: 0x04001C9D RID: 7325
	DailyTaskUnlockAreaChange,
	// Token: 0x04001C9E RID: 7326
	DailyTaskStateChange,
	// Token: 0x04001C9F RID: 7327
	DailyTaskChange,
	// Token: 0x04001CA0 RID: 7328
	DailyTaskTendencyChange,
	// Token: 0x04001CA1 RID: 7329
	OnAddCommonItem,
	// Token: 0x04001CA2 RID: 7330
	OnAddCommonItemList,
	// Token: 0x04001CA3 RID: 7331
	OnAddCommonItemNotify,
	// Token: 0x04001CA4 RID: 7332
	OnResponseCommonItem,
	// Token: 0x04001CA5 RID: 7333
	OnResponseCommonItemFinished,
	// Token: 0x04001CA6 RID: 7334
	OnRemoveCommonItem,
	// Token: 0x04001CA7 RID: 7335
	OnCommonItemCountRefresh,
	// Token: 0x04001CA8 RID: 7336
	OnCommonItemCountAnyChange,
	// Token: 0x04001CA9 RID: 7337
	OnAddWeaponItem,
	// Token: 0x04001CAA RID: 7338
	OnAddWeaponItemList,
	// Token: 0x04001CAB RID: 7339
	OnResponseWeaponItem,
	// Token: 0x04001CAC RID: 7340
	OnResponseWeaponAll,
	// Token: 0x04001CAD RID: 7341
	OnRemoveWeaponItem,
	// Token: 0x04001CAE RID: 7342
	OnWeaponFunctionValueRefresh,
	// Token: 0x04001CAF RID: 7343
	OnAddPhantomItem,
	// Token: 0x04001CB0 RID: 7344
	OnAddPhantomItemList,
	// Token: 0x04001CB1 RID: 7345
	OnResponsePhantomItem,
	// Token: 0x04001CB2 RID: 7346
	OnEquipPhantomItem,
	// Token: 0x04001CB3 RID: 7347
	OnRemovePhantomItem,
	// Token: 0x04001CB4 RID: 7348
	OnPhantomStackMerge,
	// Token: 0x04001CB5 RID: 7349
	OnPhantomFunctionValueRefresh,
	// Token: 0x04001CB6 RID: 7350
	OnAddFavorItem,
	// Token: 0x04001CB7 RID: 7351
	OnAddOrnamentItemList,
	// Token: 0x04001CB8 RID: 7352
	NotifyInvalidItem,
	// Token: 0x04001CB9 RID: 7353
	NotifyExpireConvertItem,
	// Token: 0x04001CBA RID: 7354
	EnterLogicRange,
	// Token: 0x04001CBB RID: 7355
	LeaveLogicRange,
	// Token: 0x04001CBC RID: 7356
	PlayerSenseTargetEnter,
	// Token: 0x04001CBD RID: 7357
	PlayerSenseTargetLeave,
	// Token: 0x04001CBE RID: 7358
	OnAiSenseEntityEnter,
	// Token: 0x04001CBF RID: 7359
	OnAiSenseEntityLeave,
	// Token: 0x04001CC0 RID: 7360
	OnInteractStateChange,
	// Token: 0x04001CC1 RID: 7361
	OnGuideRangeEnter,
	// Token: 0x04001CC2 RID: 7362
	SwitchCookType,
	// Token: 0x04001CC3 RID: 7363
	UpdateFormula,
	// Token: 0x04001CC4 RID: 7364
	UpdateCookerInfo,
	// Token: 0x04001CC5 RID: 7365
	UpgradeCookerLevel,
	// Token: 0x04001CC6 RID: 7366
	GetCookData,
	// Token: 0x04001CC7 RID: 7367
	OpenProcessedStudy,
	// Token: 0x04001CC8 RID: 7368
	CloseProcessedStudy,
	// Token: 0x04001CC9 RID: 7369
	OpenCook,
	// Token: 0x04001CCA RID: 7370
	OpenCookLevel,
	// Token: 0x04001CCB RID: 7371
	OpenCookRole,
	// Token: 0x04001CCC RID: 7372
	CloseCookRole,
	// Token: 0x04001CCD RID: 7373
	CookSuccess,
	// Token: 0x04001CCE RID: 7374
	CookFail,
	// Token: 0x04001CCF RID: 7375
	MachiningSuccess,
	// Token: 0x04001CD0 RID: 7376
	MachiningStudyFail,
	// Token: 0x04001CD1 RID: 7377
	FixSuccess,
	// Token: 0x04001CD2 RID: 7378
	OpenSelected,
	// Token: 0x04001CD3 RID: 7379
	CloseSelected,
	// Token: 0x04001CD4 RID: 7380
	OnAddCommonEffect,
	// Token: 0x04001CD5 RID: 7381
	RefreshRewardPopUp,
	// Token: 0x04001CD6 RID: 7382
	ReceiveMonthCardDataEvent,
	// Token: 0x04001CD7 RID: 7383
	ReceiveWeekCardDataEvent,
	// Token: 0x04001CD8 RID: 7384
	OnClickSingleTimeTowerStageBtn,
	// Token: 0x04001CD9 RID: 7385
	OnClickSingleTimeTowerTeamBtn,
	// Token: 0x04001CDA RID: 7386
	OnClickSingleTimeTowerTeamRoleBtn,
	// Token: 0x04001CDB RID: 7387
	OnClickSingleTimeTowerStageDetailBtn,
	// Token: 0x04001CDC RID: 7388
	OnClickSingleTimeTowerMonsterBtn,
	// Token: 0x04001CDD RID: 7389
	OnClickSingleTimeTowerDetailSwitchBtn,
	// Token: 0x04001CDE RID: 7390
	OnInstResultNotify,
	// Token: 0x04001CDF RID: 7391
	OnTowerChallengeChangeTeamNotify,
	// Token: 0x04001CE0 RID: 7392
	OnTowerRewardReceived,
	// Token: 0x04001CE1 RID: 7393
	RedDotTowerReward,
	// Token: 0x04001CE2 RID: 7394
	RedDotTowerRewardByDifficulties,
	// Token: 0x04001CE3 RID: 7395
	OnTowerRefresh,
	// Token: 0x04001CE4 RID: 7396
	OnTowerRecordUpdate,
	// Token: 0x04001CE5 RID: 7397
	OnShowTowerGuideButton,
	// Token: 0x04001CE6 RID: 7398
	OnTowerReviewGoToReward,
	// Token: 0x04001CE7 RID: 7399
	OnClickCycleTowerAreaBtn,
	// Token: 0x04001CE8 RID: 7400
	OnResetCycleTowerArea,
	// Token: 0x04001CE9 RID: 7401
	OnClickCycleTowerRoleBtn,
	// Token: 0x04001CEA RID: 7402
	OnClickCycleTowerDetailSwitchBtn,
	// Token: 0x04001CEB RID: 7403
	OnCycleTowerUpdateSeason,
	// Token: 0x04001CEC RID: 7404
	OnCycleTowerUpdateSeasonNotify,
	// Token: 0x04001CED RID: 7405
	OnCycleTowerScoreChange,
	// Token: 0x04001CEE RID: 7406
	OnTowerGuideClose,
	// Token: 0x04001CEF RID: 7407
	OnTowerRefreshStars,
	// Token: 0x04001CF0 RID: 7408
	OnReceiveAdviceData,
	// Token: 0x04001CF1 RID: 7409
	OnCreateAdviceSuccess,
	// Token: 0x04001CF2 RID: 7410
	OnModifyAdviceSuccess,
	// Token: 0x04001CF3 RID: 7411
	OnDeleteAdviceSuccess,
	// Token: 0x04001CF4 RID: 7412
	OnClickAdviceExpression,
	// Token: 0x04001CF5 RID: 7413
	OnClickAdviceWord,
	// Token: 0x04001CF6 RID: 7414
	OnChangeAdviceWord,
	// Token: 0x04001CF7 RID: 7415
	OnClickAdviceSort,
	// Token: 0x04001CF8 RID: 7416
	OnClickAdviceSortWord,
	// Token: 0x04001CF9 RID: 7417
	OnClickAdviceMotion,
	// Token: 0x04001CFA RID: 7418
	OnChangeAdviceRole,
	// Token: 0x04001CFB RID: 7419
	OnClickAdviceSelectItem,
	// Token: 0x04001CFC RID: 7420
	OnSelectAdviceWord,
	// Token: 0x04001CFD RID: 7421
	OnSelectAdviceExpression,
	// Token: 0x04001CFE RID: 7422
	OnAdviceEntityNotify,
	// Token: 0x04001CFF RID: 7423
	OnAdviceVoteNotify,
	// Token: 0x04001D00 RID: 7424
	RefreshAdviceInfoView,
	// Token: 0x04001D01 RID: 7425
	SneakStart,
	// Token: 0x04001D02 RID: 7426
	SneakEnd,
	// Token: 0x04001D03 RID: 7427
	AddAlterMark,
	// Token: 0x04001D04 RID: 7428
	RemoveAlterMark,
	// Token: 0x04001D05 RID: 7429
	OnSneakFoundChange,
	// Token: 0x04001D06 RID: 7430
	OnChildQuestNodeFinish,
	// Token: 0x04001D07 RID: 7431
	AddStalkAlertMark,
	// Token: 0x04001D08 RID: 7432
	RemoveStalkAlertMark,
	// Token: 0x04001D09 RID: 7433
	OnStalkAlert,
	// Token: 0x04001D0A RID: 7434
	OnStalkAlertLifted,
	// Token: 0x04001D0B RID: 7435
	OnStalkFound,
	// Token: 0x04001D0C RID: 7436
	OnStalkFailed,
	// Token: 0x04001D0D RID: 7437
	AddEavesdropMark,
	// Token: 0x04001D0E RID: 7438
	RemoveEavesdropMark,
	// Token: 0x04001D0F RID: 7439
	OnEavesdropFound,
	// Token: 0x04001D10 RID: 7440
	OnAddFullScreenEffect,
	// Token: 0x04001D11 RID: 7441
	OnRemoveFullScreenEffect,
	// Token: 0x04001D12 RID: 7442
	OnClearFullScreenEffect,
	// Token: 0x04001D13 RID: 7443
	OnChangeFullScreenNiagaraFloatParameter,
	// Token: 0x04001D14 RID: 7444
	OnSceneItemBuffConsumed,
	// Token: 0x04001D15 RID: 7445
	OnSceneItemBuffRemoved,
	// Token: 0x04001D16 RID: 7446
	OnSceneItemBuffTimeout,
	// Token: 0x04001D17 RID: 7447
	OnSceneItemBuffTargetRemoved,
	// Token: 0x04001D18 RID: 7448
	OnSceneItemBuffConsumerPerformanceComplete,
	// Token: 0x04001D19 RID: 7449
	OnExecuteServerGm,
	// Token: 0x04001D1A RID: 7450
	ActiveBattleView,
	// Token: 0x04001D1B RID: 7451
	DisActiveBattleView,
	// Token: 0x04001D1C RID: 7452
	DragActorPlayActivationChanged,
	// Token: 0x04001D1D RID: 7453
	DragActorPlayConditionRecheck,
	// Token: 0x04001D1E RID: 7454
	BattleUiCurRoleDataChanged,
	// Token: 0x04001D1F RID: 7455
	BattleUiCurRoleDataChangedNextTick,
	// Token: 0x04001D20 RID: 7456
	BattleUiEnergyBarVisible,
	// Token: 0x04001D21 RID: 7457
	BattleUiAllRoleDataChanged,
	// Token: 0x04001D22 RID: 7458
	BattleUiRemoveRoleData,
	// Token: 0x04001D23 RID: 7459
	BattleUiElementEnergyChanged,
	// Token: 0x04001D24 RID: 7460
	BattleUiEnergyChanged,
	// Token: 0x04001D25 RID: 7461
	BattleUiRoleHeadChanged,
	// Token: 0x04001D26 RID: 7462
	BattleUiElementHideTagChanged,
	// Token: 0x04001D27 RID: 7463
	BattleUiConcertoExtraEffectRefresh,
	// Token: 0x04001D28 RID: 7464
	BattleUiDeadTagChanged,
	// Token: 0x04001D29 RID: 7465
	BattleUiQteEnableTagChanged,
	// Token: 0x04001D2A RID: 7466
	BattleUiQteCdTagChanged,
	// Token: 0x04001D2B RID: 7467
	BattleUiUseQteTagChanged,
	// Token: 0x04001D2C RID: 7468
	BattleUiConcertoEnableTagChanged,
	// Token: 0x04001D2D RID: 7469
	BattleUiPoisonChanged,
	// Token: 0x04001D2E RID: 7470
	BattleUiHealthChanged,
	// Token: 0x04001D2F RID: 7471
	BattleUiShieldChanged,
	// Token: 0x04001D30 RID: 7472
	BattleUiLevelChanged,
	// Token: 0x04001D31 RID: 7473
	BattleUiFloatTipUpdate,
	// Token: 0x04001D32 RID: 7474
	BattleUiPlayAudio,
	// Token: 0x04001D33 RID: 7475
	BattleUiExploreModeChanged,
	// Token: 0x04001D34 RID: 7476
	BattleUiMergeHeadStateVisibleChanged,
	// Token: 0x04001D35 RID: 7477
	BattleUiMergeHeadStateHealthChanged,
	// Token: 0x04001D36 RID: 7478
	BattleUiTowerMergeHeadStateVisibleChanged,
	// Token: 0x04001D37 RID: 7479
	BattleUiTowerMergeHeadStateMonsterHpChanged,
	// Token: 0x04001D38 RID: 7480
	BattleUiEnvironmentKeyChanged,
	// Token: 0x04001D39 RID: 7481
	BattleUiPressCombineButtonChanged,
	// Token: 0x04001D3A RID: 7482
	BattleUiPressMotorcycleCombineButtonChanged,
	// Token: 0x04001D3B RID: 7483
	BattleUiToggleSilentAreaInfoView,
	// Token: 0x04001D3C RID: 7484
	BattleInputEnableChanged,
	// Token: 0x04001D3D RID: 7485
	BattleInputVisibleChanged,
	// Token: 0x04001D3E RID: 7486
	BattleUiFollowerAimStateChanged,
	// Token: 0x04001D3F RID: 7487
	BattleUiChatScrollViewVisibleChanged,
	// Token: 0x04001D40 RID: 7488
	BattleUiRouletteKeyChanged,
	// Token: 0x04001D41 RID: 7489
	BattleUiSwitchInteractOpenChanged,
	// Token: 0x04001D42 RID: 7490
	BattleUiSwitchInteractStateChanged,
	// Token: 0x04001D43 RID: 7491
	BattleUiToggleTowerDefenseInfoView,
	// Token: 0x04001D44 RID: 7492
	BattleUiAlphaChanged,
	// Token: 0x04001D45 RID: 7493
	BattleUiPureModeChanged,
	// Token: 0x04001D46 RID: 7494
	BattleUiSpecialSkillEnableChanged,
	// Token: 0x04001D47 RID: 7495
	BattleUiRoleSpecialStateChanged,
	// Token: 0x04001D48 RID: 7496
	BattleUiSlowTimeVisibleChanged,
	// Token: 0x04001D49 RID: 7497
	BattleUiTimeDilationStateChanged,
	// Token: 0x04001D4A RID: 7498
	BattleUiShowWeaknessBreakEffect,
	// Token: 0x04001D4B RID: 7499
	BattleUiMotorcycleStateChanged,
	// Token: 0x04001D4C RID: 7500
	BattleUiMotorcycleBulletJumpChanged,
	// Token: 0x04001D4D RID: 7501
	BattleUiMotorcycleHudVisibleChanged,
	// Token: 0x04001D4E RID: 7502
	BattleUiMotorcycleHudColorStateChanged,
	// Token: 0x04001D4F RID: 7503
	BattleUiMotorcycleFlyTagChanged,
	// Token: 0x04001D50 RID: 7504
	BattleUiMotorcycleCannonTagChanged,
	// Token: 0x04001D51 RID: 7505
	AddStrengthItem,
	// Token: 0x04001D52 RID: 7506
	RemoveStrengthItem,
	// Token: 0x04001D53 RID: 7507
	BattleUiBossStateAreaChanged,
	// Token: 0x04001D54 RID: 7508
	BattleUiGamepadDataChanged,
	// Token: 0x04001D55 RID: 7509
	BattleUiSlideControlVisibleChanged,
	// Token: 0x04001D56 RID: 7510
	OnSkillButtonPanelVisibleChange,
	// Token: 0x04001D57 RID: 7511
	BattleSettlementStateChanged,
	// Token: 0x04001D58 RID: 7512
	BattleScoreChanged,
	// Token: 0x04001D59 RID: 7513
	BattleScoreEnableChanged,
	// Token: 0x04001D5A RID: 7514
	OnRefreshFormationCooldownExternalInBattleView,
	// Token: 0x04001D5B RID: 7515
	OnCharacterCapsuleChanged,
	// Token: 0x04001D5C RID: 7516
	OnKscPlayerHpChanged,
	// Token: 0x04001D5D RID: 7517
	OnKscPlayerCreate,
	// Token: 0x04001D5E RID: 7518
	RefreshInfluencePanel,
	// Token: 0x04001D5F RID: 7519
	ReceiveReputationReward,
	// Token: 0x04001D60 RID: 7520
	SearchInfluence,
	// Token: 0x04001D61 RID: 7521
	RedDotInfluence,
	// Token: 0x04001D62 RID: 7522
	BehaviorTreeStartActionSession,
	// Token: 0x04001D63 RID: 7523
	UiPlayCloseAudio,
	// Token: 0x04001D64 RID: 7524
	OnSceneItemLockPropChange,
	// Token: 0x04001D65 RID: 7525
	OnSpecialItemUpdate,
	// Token: 0x04001D66 RID: 7526
	EquipAndSwitchSpecialItem,
	// Token: 0x04001D67 RID: 7527
	UnEquipSpecialItem,
	// Token: 0x04001D68 RID: 7528
	ShowPlayerPosition,
	// Token: 0x04001D69 RID: 7529
	BattlePassHadEnterUpdate,
	// Token: 0x04001D6A RID: 7530
	GetBattlePassRewardEvent,
	// Token: 0x04001D6B RID: 7531
	ReceiveBattlePassDataEvent,
	// Token: 0x04001D6C RID: 7532
	NotifyBattlePassToBuyEvent,
	// Token: 0x04001D6D RID: 7533
	BattlePassFirstUnlockAnime,
	// Token: 0x04001D6E RID: 7534
	OnReceiveBattlePassPaid,
	// Token: 0x04001D6F RID: 7535
	ReceiveBattlePassTaskEvent,
	// Token: 0x04001D70 RID: 7536
	OnChoseLevelItemEvent,
	// Token: 0x04001D71 RID: 7537
	OnClickLevelItemEvent,
	// Token: 0x04001D72 RID: 7538
	UpdateBattlePassTaskEvent,
	// Token: 0x04001D73 RID: 7539
	OnBattlePassLevelUpEvent,
	// Token: 0x04001D74 RID: 7540
	OnBattlePassSkip,
	// Token: 0x04001D75 RID: 7541
	OnBattlePassExpireEvent,
	// Token: 0x04001D76 RID: 7542
	BattlePassMainViewHide,
	// Token: 0x04001D77 RID: 7543
	OnResetSkinDamageMode,
	// Token: 0x04001D78 RID: 7544
	OnExitNpcInteract,
	// Token: 0x04001D79 RID: 7545
	SwitchViewType,
	// Token: 0x04001D7A RID: 7546
	SwitchComposeType,
	// Token: 0x04001D7B RID: 7547
	GetComposeData,
	// Token: 0x04001D7C RID: 7548
	UpgradeComposeLevel,
	// Token: 0x04001D7D RID: 7549
	OpenComposeLevel,
	// Token: 0x04001D7E RID: 7550
	OpenCompose,
	// Token: 0x04001D7F RID: 7551
	ComposeSuccess,
	// Token: 0x04001D80 RID: 7552
	ComposeFail,
	// Token: 0x04001D81 RID: 7553
	ComposeSwitchType,
	// Token: 0x04001D82 RID: 7554
	OpenHelpRole,
	// Token: 0x04001D83 RID: 7555
	CloseHelpRole,
	// Token: 0x04001D84 RID: 7556
	UpdateComposeFormula,
	// Token: 0x04001D85 RID: 7557
	UpdateComposeInfo,
	// Token: 0x04001D86 RID: 7558
	UpdateForgingFormula,
	// Token: 0x04001D87 RID: 7559
	OpenForging,
	// Token: 0x04001D88 RID: 7560
	GetForgingData,
	// Token: 0x04001D89 RID: 7561
	ForgingSuccess,
	// Token: 0x04001D8A RID: 7562
	ForgingFail,
	// Token: 0x04001D8B RID: 7563
	ChangePlayerInfoId,
	// Token: 0x04001D8C RID: 7564
	OnShowGridAnimation,
	// Token: 0x04001D8D RID: 7565
	OnActivateUiCameraAnimationHandle,
	// Token: 0x04001D8E RID: 7566
	OnActivateUiCameraAnimationHandleFail,
	// Token: 0x04001D8F RID: 7567
	OnUiBlendInTimeCameraFinished,
	// Token: 0x04001D90 RID: 7568
	OnUiBlendInCameraSequenceFinished,
	// Token: 0x04001D91 RID: 7569
	RoleHandBookActive,
	// Token: 0x04001D92 RID: 7570
	OnSequenceCameraStatus,
	// Token: 0x04001D93 RID: 7571
	LocalStorageInitPlayerId,
	// Token: 0x04001D94 RID: 7572
	DynamicInteractServerResponse,
	// Token: 0x04001D95 RID: 7573
	UpdateCameraInfo,
	// Token: 0x04001D96 RID: 7574
	PlayCameraLevelSequence,
	// Token: 0x04001D97 RID: 7575
	CameraModeChanged,
	// Token: 0x04001D98 RID: 7576
	CameraViewTargetChanged,
	// Token: 0x04001D99 RID: 7577
	FixedCameraRestored,
	// Token: 0x04001D9A RID: 7578
	CameraCharacterChanged,
	// Token: 0x04001D9B RID: 7579
	AdjustCameraSync,
	// Token: 0x04001D9C RID: 7580
	OpenTreasureBox,
	// Token: 0x04001D9D RID: 7581
	OnHandBookDataInit,
	// Token: 0x04001D9E RID: 7582
	OnHandBookDataUpdate,
	// Token: 0x04001D9F RID: 7583
	OnHandBookRedDotUpdate,
	// Token: 0x04001DA0 RID: 7584
	OnHandBookRead,
	// Token: 0x04001DA1 RID: 7585
	OnPhantomReadRedDotUpdate,
	// Token: 0x04001DA2 RID: 7586
	OnItemReadRedDotUpdate,
	// Token: 0x04001DA3 RID: 7587
	OnPhotoSelect,
	// Token: 0x04001DA4 RID: 7588
	OnGeographyPhotoSelect,
	// Token: 0x04001DA5 RID: 7589
	OnHandBookPlotNodeRefresh,
	// Token: 0x04001DA6 RID: 7590
	RemoveCreatureDataComponentCache,
	// Token: 0x04001DA7 RID: 7591
	TravelClearView,
	// Token: 0x04001DA8 RID: 7592
	OnPressOrReleaseBehaviorButton,
	// Token: 0x04001DA9 RID: 7593
	SetImageQuality,
	// Token: 0x04001DAA RID: 7594
	SetImageQualityWithValue,
	// Token: 0x04001DAB RID: 7595
	SetRayTracingWithValue,
	// Token: 0x04001DAC RID: 7596
	SetDLSSFGWithValue,
	// Token: 0x04001DAD RID: 7597
	SetDisplayMode,
	// Token: 0x04001DAE RID: 7598
	SetResolution,
	// Token: 0x04001DAF RID: 7599
	SetNiagaraQuality,
	// Token: 0x04001DB0 RID: 7600
	SetEnvironmentInteraction,
	// Token: 0x04001DB1 RID: 7601
	AfterGameQualitySettingsManagerInitialize,
	// Token: 0x04001DB2 RID: 7602
	AfterGameSettingsAppliedOnOpenLoading,
	// Token: 0x04001DB3 RID: 7603
	LoadingRangeScaleChanged,
	// Token: 0x04001DB4 RID: 7604
	SetGmIsOpen,
	// Token: 0x04001DB5 RID: 7605
	AddToTickList,
	// Token: 0x04001DB6 RID: 7606
	HandleNextAction,
	// Token: 0x04001DB7 RID: 7607
	HandleActionFailure,
	// Token: 0x04001DB8 RID: 7608
	AddGuaranteeAction,
	// Token: 0x04001DB9 RID: 7609
	RemGuaranteeAction,
	// Token: 0x04001DBA RID: 7610
	ShareGroupCd,
	// Token: 0x04001DBB RID: 7611
	AddShareGroupLimitCount,
	// Token: 0x04001DBC RID: 7612
	OnInteractPlotStart,
	// Token: 0x04001DBD RID: 7613
	OnInteractPlotEnd,
	// Token: 0x04001DBE RID: 7614
	OnAchievementDataNotify,
	// Token: 0x04001DBF RID: 7615
	OnAchievementDataWithIdNotify,
	// Token: 0x04001DC0 RID: 7616
	OnAchievementGroupDataNotify,
	// Token: 0x04001DC1 RID: 7617
	OnGetAchievementBaseData,
	// Token: 0x04001DC2 RID: 7618
	OnGetAchievementSearchTextChange,
	// Token: 0x04001DC3 RID: 7619
	OnAchievementGroupChange,
	// Token: 0x04001DC4 RID: 7620
	RefreshAchievementRedPoint,
	// Token: 0x04001DC5 RID: 7621
	OnActivityUpdate,
	// Token: 0x04001DC6 RID: 7622
	OnSelectActivity,
	// Token: 0x04001DC7 RID: 7623
	OnSelectActivityAndSubViewReady,
	// Token: 0x04001DC8 RID: 7624
	RefreshActivityTab,
	// Token: 0x04001DC9 RID: 7625
	OnReceiveActivityData,
	// Token: 0x04001DCA RID: 7626
	SetActivityViewState,
	// Token: 0x04001DCB RID: 7627
	SetActivityViewCurrency,
	// Token: 0x04001DCC RID: 7628
	ChangeActivityViewNeedBlurState,
	// Token: 0x04001DCD RID: 7629
	OnClickActivityRunChallenge,
	// Token: 0x04001DCE RID: 7630
	OnSelectActivityRunChallengeItem,
	// Token: 0x04001DCF RID: 7631
	RefreshCommonActivityRedDot,
	// Token: 0x04001DD0 RID: 7632
	RefreshActivityRecommendRedDot,
	// Token: 0x04001DD1 RID: 7633
	RoverlikeTalentUnlockDataUpdate,
	// Token: 0x04001DD2 RID: 7634
	RoverlikeQuestTaskUpdate,
	// Token: 0x04001DD3 RID: 7635
	RoverlikeReviveTimesUpdate,
	// Token: 0x04001DD4 RID: 7636
	RoverlikeResourceFloatText,
	// Token: 0x04001DD5 RID: 7637
	RoverlikeGainDataUpdate,
	// Token: 0x04001DD6 RID: 7638
	RoverlikeEquippedLootChange,
	// Token: 0x04001DD7 RID: 7639
	RoverlikeLootInfoUpdate,
	// Token: 0x04001DD8 RID: 7640
	RoverlikeLevelInfoUpdate,
	// Token: 0x04001DD9 RID: 7641
	RoverlikeShopInfoUpdate,
	// Token: 0x04001DDA RID: 7642
	OnNewbieMainTaskUpdate,
	// Token: 0x04001DDB RID: 7643
	RefreshRunActivityRedDot,
	// Token: 0x04001DDC RID: 7644
	OnGetRunActivityReward,
	// Token: 0x04001DDD RID: 7645
	ActivityCrossDayRefresh,
	// Token: 0x04001DDE RID: 7646
	ActivityDataInitComplete,
	// Token: 0x04001DDF RID: 7647
	OnActivityClose,
	// Token: 0x04001DE0 RID: 7648
	OnActivityOpen,
	// Token: 0x04001DE1 RID: 7649
	OnActivityPreOpen,
	// Token: 0x04001DE2 RID: 7650
	OnActivitySequenceEmitEvent,
	// Token: 0x04001DE3 RID: 7651
	RefreshCommonActivityRewardPopUpView,
	// Token: 0x04001DE4 RID: 7652
	ActivityViewChange,
	// Token: 0x04001DE5 RID: 7653
	ActivityViewRefreshCurrent,
	// Token: 0x04001DE6 RID: 7654
	LongShanUpdate,
	// Token: 0x04001DE7 RID: 7655
	OnPhantomCollectUpdate,
	// Token: 0x04001DE8 RID: 7656
	TurntableStartRun,
	// Token: 0x04001DE9 RID: 7657
	TrackMoonHandbookUpdate,
	// Token: 0x04001DEA RID: 7658
	MoonChasingRefreshBuildingRedDot,
	// Token: 0x04001DEB RID: 7659
	MoonChasingRefreshRewardRedDot,
	// Token: 0x04001DEC RID: 7660
	MoonChasingRefreshDelegationRedDot,
	// Token: 0x04001DED RID: 7661
	MoonChasingRefreshRoleRedDot,
	// Token: 0x04001DEE RID: 7662
	MoonChasingRefreshQuestRedDot,
	// Token: 0x04001DEF RID: 7663
	MoonChasingOnOpenInteractive,
	// Token: 0x04001DF0 RID: 7664
	DreamLinkRewardRefresh,
	// Token: 0x04001DF1 RID: 7665
	DreamLinkLimitRewardRefresh,
	// Token: 0x04001DF2 RID: 7666
	MapTravelTaskRefresh,
	// Token: 0x04001DF3 RID: 7667
	MapTravelSoarRefresh,
	// Token: 0x04001DF4 RID: 7668
	MapTravelTaskNavigationNext,
	// Token: 0x04001DF5 RID: 7669
	OnCyberPunkUpdate,
	// Token: 0x04001DF6 RID: 7670
	OnCyberPunkTaskRefresh,
	// Token: 0x04001DF7 RID: 7671
	OnCyberPunkItemUnLock,
	// Token: 0x04001DF8 RID: 7672
	GmAutoModeChange,
	// Token: 0x04001DF9 RID: 7673
	OnAddNotAllowFightInputViewName,
	// Token: 0x04001DFA RID: 7674
	OnRemoveNotAllowFightInputViewName,
	// Token: 0x04001DFB RID: 7675
	OnClearNotAllowFightInputViewName,
	// Token: 0x04001DFC RID: 7676
	OnSelectedEditPanelItem,
	// Token: 0x04001DFD RID: 7677
	UiRoleSequenceEndKeyFrame,
	// Token: 0x04001DFE RID: 7678
	DropItemStarted,
	// Token: 0x04001DFF RID: 7679
	OnRoleChangeEnd,
	// Token: 0x04001E00 RID: 7680
	ComboTeachingPress,
	// Token: 0x04001E01 RID: 7681
	ComboTeachingRelease,
	// Token: 0x04001E02 RID: 7682
	ComboTeachingHold,
	// Token: 0x04001E03 RID: 7683
	ComboTeachingNodeEnd,
	// Token: 0x04001E04 RID: 7684
	ComboTeachingIndexUpdate,
	// Token: 0x04001E05 RID: 7685
	ComboTeachingViewOpen,
	// Token: 0x04001E06 RID: 7686
	SkillAcceptChanged,
	// Token: 0x04001E07 RID: 7687
	ComboTeachingFinish,
	// Token: 0x04001E08 RID: 7688
	ComboTeachingCloseGuide,
	// Token: 0x04001E09 RID: 7689
	RoleIntroductionViewHide,
	// Token: 0x04001E0A RID: 7690
	RequestClearMeshRotationBuffer,
	// Token: 0x04001E0B RID: 7691
	NavigationViewCreate,
	// Token: 0x04001E0C RID: 7692
	NavigationViewDestroy,
	// Token: 0x04001E0D RID: 7693
	ResetNavigationListener,
	// Token: 0x04001E0E RID: 7694
	NavigationTriggerMapForward,
	// Token: 0x04001E0F RID: 7695
	NavigationTriggerMapRight,
	// Token: 0x04001E10 RID: 7696
	NavigationTriggerMapZoom,
	// Token: 0x04001E11 RID: 7697
	NavigationTriggerRoleLookUp,
	// Token: 0x04001E12 RID: 7698
	NavigationTriggerRoleTurn,
	// Token: 0x04001E13 RID: 7699
	NavigationTriggerRoleZoom,
	// Token: 0x04001E14 RID: 7700
	NavigationTriggerRoleReset,
	// Token: 0x04001E15 RID: 7701
	GamepadMoveOverScreen,
	// Token: 0x04001E16 RID: 7702
	NavigationTriggerPlotForward,
	// Token: 0x04001E17 RID: 7703
	NavigationTriggerPlotRight,
	// Token: 0x04001E18 RID: 7704
	NavigationTriggerPlotZoom,
	// Token: 0x04001E19 RID: 7705
	NavigationRefreshPlotNextPage,
	// Token: 0x04001E1A RID: 7706
	FunctionGridSelected,
	// Token: 0x04001E1B RID: 7707
	OnPersonalCardRead,
	// Token: 0x04001E1C RID: 7708
	OnPersonalCardRefreshRedDot,
	// Token: 0x04001E1D RID: 7709
	OnHeadIconChange,
	// Token: 0x04001E1E RID: 7710
	OnSignChange,
	// Token: 0x04001E1F RID: 7711
	OnNameChange,
	// Token: 0x04001E20 RID: 7712
	OnModifyNameStateChange,
	// Token: 0x04001E21 RID: 7713
	OnBirthChange,
	// Token: 0x04001E22 RID: 7714
	OnBirthDisplayChange,
	// Token: 0x04001E23 RID: 7715
	OnBirthRoleChange,
	// Token: 0x04001E24 RID: 7716
	OnCardChange,
	// Token: 0x04001E25 RID: 7717
	ResetRoleFlag,
	// Token: 0x04001E26 RID: 7718
	OnRoleShowListChange,
	// Token: 0x04001E27 RID: 7719
	OnRoleElementChange,
	// Token: 0x04001E28 RID: 7720
	ShowRoleElementChangePreviewEffect,
	// Token: 0x04001E29 RID: 7721
	OnChangedActionKeys,
	// Token: 0x04001E2A RID: 7722
	OnChangedAxisKeys,
	// Token: 0x04001E2B RID: 7723
	SelectRoleTab,
	// Token: 0x04001E2C RID: 7724
	SelectRoleTabOutside,
	// Token: 0x04001E2D RID: 7725
	OnFunctionViewShow,
	// Token: 0x04001E2E RID: 7726
	OnPlayerTitleChange,
	// Token: 0x04001E2F RID: 7727
	OnPlayerTitleRefreshRedDot,
	// Token: 0x04001E30 RID: 7728
	OnPlayerTitleUnlock,
	// Token: 0x04001E31 RID: 7729
	OnPersonalTipStateSet,
	// Token: 0x04001E32 RID: 7730
	LevelFlowSequenceTriggerEvent,
	// Token: 0x04001E33 RID: 7731
	OnLevelFlowFinished,
	// Token: 0x04001E34 RID: 7732
	UpdatePanelQteWorldTimeDilation,
	// Token: 0x04001E35 RID: 7733
	PanelQteStart,
	// Token: 0x04001E36 RID: 7734
	PanelQteEnd,
	// Token: 0x04001E37 RID: 7735
	FreeRunningQteStart,
	// Token: 0x04001E38 RID: 7736
	CommonQteStart,
	// Token: 0x04001E39 RID: 7737
	CommonQteEnd,
	// Token: 0x04001E3A RID: 7738
	QtaStart,
	// Token: 0x04001E3B RID: 7739
	QtaEnd,
	// Token: 0x04001E3C RID: 7740
	StartHeartBeat,
	// Token: 0x04001E3D RID: 7741
	StopHeartBeat,
	// Token: 0x04001E3E RID: 7742
	CreateEffectHandle,
	// Token: 0x04001E3F RID: 7743
	RemoveEffectHandle,
	// Token: 0x04001E40 RID: 7744
	LoadEffect,
	// Token: 0x04001E41 RID: 7745
	BeforePlayEffect,
	// Token: 0x04001E42 RID: 7746
	AfterPlayEffect,
	// Token: 0x04001E43 RID: 7747
	FinishEffect,
	// Token: 0x04001E44 RID: 7748
	TestQuestAutoPilotFinish,
	// Token: 0x04001E45 RID: 7749
	TestQuestFunctionFinish,
	// Token: 0x04001E46 RID: 7750
	OnRefreshRewardViewItemList,
	// Token: 0x04001E47 RID: 7751
	OnRefreshRewardProgressBar,
	// Token: 0x04001E48 RID: 7752
	OnRefreshRewardButton,
	// Token: 0x04001E49 RID: 7753
	OnItemRewardNotify,
	// Token: 0x04001E4A RID: 7754
	OnExploreRewardShowEnd,
	// Token: 0x04001E4B RID: 7755
	OnShowRewardView,
	// Token: 0x04001E4C RID: 7756
	OnCloseRewardView,
	// Token: 0x04001E4D RID: 7757
	OnPlotWaitViewDone,
	// Token: 0x04001E4E RID: 7758
	OnPlayCameraAnimationStart,
	// Token: 0x04001E4F RID: 7759
	OnPlayCameraAnimationFinish,
	// Token: 0x04001E50 RID: 7760
	CommunicateFinished,
	// Token: 0x04001E51 RID: 7761
	CommunicateAgain,
	// Token: 0x04001E52 RID: 7762
	ChallengeAgain,
	// Token: 0x04001E53 RID: 7763
	OnPhotographSetUpViewVisibleChanged,
	// Token: 0x04001E54 RID: 7764
	OnEntityCameraOneSituationChanged,
	// Token: 0x04001E55 RID: 7765
	OnEntityCameraMissTarget,
	// Token: 0x04001E56 RID: 7766
	OnEntityCameraOptionalSituationChanged,
	// Token: 0x04001E57 RID: 7767
	OnEntityCameraSearchGreat,
	// Token: 0x04001E58 RID: 7768
	OnEntityCameraFinished,
	// Token: 0x04001E59 RID: 7769
	OnScreenShotDone,
	// Token: 0x04001E5A RID: 7770
	OnPhotographSetVisible,
	// Token: 0x04001E5B RID: 7771
	OnChangeFovByOption,
	// Token: 0x04001E5C RID: 7772
	NotifyBtFightPhotoTaskFinish,
	// Token: 0x04001E5D RID: 7773
	OnChangeFightPhotoOption,
	// Token: 0x04001E5E RID: 7774
	OnNeedShowFightPhotoFocus,
	// Token: 0x04001E5F RID: 7775
	OnRefreshFightPhotoLevelRedDot,
	// Token: 0x04001E60 RID: 7776
	OnSyncFightPhotoTiltAngle,
	// Token: 0x04001E61 RID: 7777
	OnSubmitItemSuccess,
	// Token: 0x04001E62 RID: 7778
	OnSubmitItemFail,
	// Token: 0x04001E63 RID: 7779
	OnSubmitItemLevelUp,
	// Token: 0x04001E64 RID: 7780
	OnSubmitItemLevelMax,
	// Token: 0x04001E65 RID: 7781
	OnCameraSequenceSetUiVisible,
	// Token: 0x04001E66 RID: 7782
	OnUiScreenRootVisibleChange,
	// Token: 0x04001E67 RID: 7783
	OnTurntableControllerBusyStateChange,
	// Token: 0x04001E68 RID: 7784
	OnAnyProgressControlEnableStateChange,
	// Token: 0x04001E69 RID: 7785
	OnDropItemSuccess,
	// Token: 0x04001E6A RID: 7786
	OnInteractDropItemSuccess,
	// Token: 0x04001E6B RID: 7787
	OnExecuteUiCameraSequenceEvent,
	// Token: 0x04001E6C RID: 7788
	OnInputAnyKey,
	// Token: 0x04001E6D RID: 7789
	OnImmersiveInputStateChange,
	// Token: 0x04001E6E RID: 7790
	OnAddDynamicOption,
	// Token: 0x04001E6F RID: 7791
	OnRemoveDynamicOption,
	// Token: 0x04001E70 RID: 7792
	OnFilterDataUpdate,
	// Token: 0x04001E71 RID: 7793
	OnPlayNpcPerformSequence,
	// Token: 0x04001E72 RID: 7794
	OnNpcPerformSequenceFinished,
	// Token: 0x04001E73 RID: 7795
	OnAntiqueShopUpgradeSequenceFinished,
	// Token: 0x04001E74 RID: 7796
	OnAntiqueShopLevelMaxSequenceFinished,
	// Token: 0x04001E75 RID: 7797
	OnAntiqueShopUpgradeSequencePlayFail,
	// Token: 0x04001E76 RID: 7798
	OnCookSuccessSequenceFinished,
	// Token: 0x04001E77 RID: 7799
	OnBeginPlayCookSuccessDisplay,
	// Token: 0x04001E78 RID: 7800
	OnPlayCookSuccessDisplayFinished,
	// Token: 0x04001E79 RID: 7801
	OnBeginPlayCookFailDisplay,
	// Token: 0x04001E7A RID: 7802
	OnPlayCookFailDisplayFinished,
	// Token: 0x04001E7B RID: 7803
	OnBeginPlayCompositeWorkingDisplay,
	// Token: 0x04001E7C RID: 7804
	OnPlayCompositeWorkingDisplayFinished,
	// Token: 0x04001E7D RID: 7805
	OnBeginPlayForgingWorkingDisplay,
	// Token: 0x04001E7E RID: 7806
	OnPlayForgingWorkingDisplayFinished,
	// Token: 0x04001E7F RID: 7807
	OnCharFootOnTheGround,
	// Token: 0x04001E80 RID: 7808
	BattleViewActiveSequenceFinish,
	// Token: 0x04001E81 RID: 7809
	ShowFloatTips,
	// Token: 0x04001E82 RID: 7810
	SmartObjectAiAlterNotify,
	// Token: 0x04001E83 RID: 7811
	OnSetActorHidden,
	// Token: 0x04001E84 RID: 7812
	OnPreSetActorHidden,
	// Token: 0x04001E85 RID: 7813
	OnCheckGamePing,
	// Token: 0x04001E86 RID: 7814
	OnRemoveItemRedDot,
	// Token: 0x04001E87 RID: 7815
	RunGm,
	// Token: 0x04001E88 RID: 7816
	GmHandleActionFailed,
	// Token: 0x04001E89 RID: 7817
	TestEffectAddDaRec,
	// Token: 0x04001E8A RID: 7818
	TestEffectAddEffectRec,
	// Token: 0x04001E8B RID: 7819
	TestManuallyGarbageCollection,
	// Token: 0x04001E8C RID: 7820
	GmEntityPerformanceTestFinish,
	// Token: 0x04001E8D RID: 7821
	GmOnlyShowMiniMap,
	// Token: 0x04001E8E RID: 7822
	GmOnlyShowJoyStick,
	// Token: 0x04001E8F RID: 7823
	GmHideMissionAndBossName,
	// Token: 0x04001E90 RID: 7824
	RogueBattleDescModeChange,
	// Token: 0x04001E91 RID: 7825
	RogueBattleSelectOption,
	// Token: 0x04001E92 RID: 7826
	RogueBattleSelectOptionPreview,
	// Token: 0x04001E93 RID: 7827
	RoguelikeCloseGainSelectView,
	// Token: 0x04001E94 RID: 7828
	RoguelikeDataUpdate,
	// Token: 0x04001E95 RID: 7829
	RoguelikeChooseDataResult,
	// Token: 0x04001E96 RID: 7830
	RoguelikeChooseDataNotify,
	// Token: 0x04001E97 RID: 7831
	RoguelikeInfoSelectedToken,
	// Token: 0x04001E98 RID: 7832
	RoguelikeRefreshGain,
	// Token: 0x04001E99 RID: 7833
	RoguelikeSelectSkill,
	// Token: 0x04001E9A RID: 7834
	RoguelikeTalentLevelUp,
	// Token: 0x04001E9B RID: 7835
	RoguelikeCurrencyUpdate,
	// Token: 0x04001E9C RID: 7836
	RoguelikeSelectToken,
	// Token: 0x04001E9D RID: 7837
	RoguelikeSelectSeason,
	// Token: 0x04001E9E RID: 7838
	RoguelikeGetTokenReward,
	// Token: 0x04001E9F RID: 7839
	RogueTermUnlock,
	// Token: 0x04001EA0 RID: 7840
	RoguelikeHasSelectEntryAndShow,
	// Token: 0x04001EA1 RID: 7841
	RoguelikeArchiveSaved,
	// Token: 0x04001EA2 RID: 7842
	WeeklyRogueInstDataUpdate,
	// Token: 0x04001EA3 RID: 7843
	WeeklyRogueSelectOption,
	// Token: 0x04001EA4 RID: 7844
	WeeklyRogueDescModeChange,
	// Token: 0x04001EA5 RID: 7845
	WeeklyRogueShopSelect,
	// Token: 0x04001EA6 RID: 7846
	WeeklyRogueRefreshScoreRedDot,
	// Token: 0x04001EA7 RID: 7847
	WeeklyRogueCycleRefresh,
	// Token: 0x04001EA8 RID: 7848
	WeeklyRogueRedDotInfoRefresh,
	// Token: 0x04001EA9 RID: 7849
	WeeklyRogueBurstEnableChange,
	// Token: 0x04001EAA RID: 7850
	MapDragMoveForward,
	// Token: 0x04001EAB RID: 7851
	MapDragMoveRight,
	// Token: 0x04001EAC RID: 7852
	PermanentRogueBattleSummaryInfoToggle,
	// Token: 0x04001EAD RID: 7853
	PermanentRogueRewardUpdate,
	// Token: 0x04001EAE RID: 7854
	PermanentRogueSeasonRedDotUpdate,
	// Token: 0x04001EAF RID: 7855
	PermanentRogueSkillCurrencyRedDotUpdate,
	// Token: 0x04001EB0 RID: 7856
	RogueResSelectSkill,
	// Token: 0x04001EB1 RID: 7857
	RogueResTalentLevelUp,
	// Token: 0x04001EB2 RID: 7858
	RogueResEnterInstClicked,
	// Token: 0x04001EB3 RID: 7859
	RogueResEndingSwitch,
	// Token: 0x04001EB4 RID: 7860
	RogueResEndingRedDotUpdate,
	// Token: 0x04001EB5 RID: 7861
	RogueResMapSummaryTeamUpdate,
	// Token: 0x04001EB6 RID: 7862
	RogueResMapSummaryFettersSubTabUpdate,
	// Token: 0x04001EB7 RID: 7863
	RogueResMapSummaryTeamToBondUpdate,
	// Token: 0x04001EB8 RID: 7864
	RogueResMapSummaryBondUpdate,
	// Token: 0x04001EB9 RID: 7865
	RogueViewInfoRefresh,
	// Token: 0x04001EBA RID: 7866
	RogueResMapSummaryTeamShowAgain,
	// Token: 0x04001EBB RID: 7867
	RogueTeamEditViewLinkBtnRefresh,
	// Token: 0x04001EBC RID: 7868
	RogueMapMoveTweenStarOrEnd,
	// Token: 0x04001EBD RID: 7869
	RogueMapEventDetailOpenOrClose,
	// Token: 0x04001EBE RID: 7870
	RogueResTeamLvChange,
	// Token: 0x04001EBF RID: 7871
	RogueResMoodChange,
	// Token: 0x04001EC0 RID: 7872
	RogueResNewRoleFlagChange,
	// Token: 0x04001EC1 RID: 7873
	OnPreparePhotoScreenShot,
	// Token: 0x04001EC2 RID: 7874
	OnPhotographViewCaptureMode,
	// Token: 0x04001EC3 RID: 7875
	OnMarkItemViewCreate,
	// Token: 0x04001EC4 RID: 7876
	OnMarkItemViewDestroy,
	// Token: 0x04001EC5 RID: 7877
	TakeMarkComponentEnterContainer,
	// Token: 0x04001EC6 RID: 7878
	TakeMarkComponentExitContainer,
	// Token: 0x04001EC7 RID: 7879
	OnMarkItemViewEnter,
	// Token: 0x04001EC8 RID: 7880
	OnMarkItemViewExit,
	// Token: 0x04001EC9 RID: 7881
	LogCustomMarkInfo,
	// Token: 0x04001ECA RID: 7882
	OnOpenSystemFeed,
	// Token: 0x04001ECB RID: 7883
	OnCloseSystemFeed,
	// Token: 0x04001ECC RID: 7884
	OnDeliveryProps,
	// Token: 0x04001ECD RID: 7885
	OnWorldMapTrackMarkItem,
	// Token: 0x04001ECE RID: 7886
	OnSundialRingChangeShine,
	// Token: 0x04001ECF RID: 7887
	OnSundialRingSwitch,
	// Token: 0x04001ED0 RID: 7888
	OnNeedUpdateSundialTips,
	// Token: 0x04001ED1 RID: 7889
	OnSignalDeviceLinkingCheck,
	// Token: 0x04001ED2 RID: 7890
	OnSignalDeviceReset,
	// Token: 0x04001ED3 RID: 7891
	OnSignalDeviceLinking,
	// Token: 0x04001ED4 RID: 7892
	OnSignalDeviceFinish,
	// Token: 0x04001ED5 RID: 7893
	OnOverlapSceneItemExploreInteractRange,
	// Token: 0x04001ED6 RID: 7894
	OnUseMapExploreToolSuccess,
	// Token: 0x04001ED7 RID: 7895
	OnMapExploreToolPlaceNumUpdated,
	// Token: 0x04001ED8 RID: 7896
	DoLeaveLevel,
	// Token: 0x04001ED9 RID: 7897
	OnInstanceChange,
	// Token: 0x04001EDA RID: 7898
	RefreshInputData,
	// Token: 0x04001EDB RID: 7899
	ClearSceneBegin,
	// Token: 0x04001EDC RID: 7900
	OnExploreProgressResponse,
	// Token: 0x04001EDD RID: 7901
	OnReceiveAreaStageRewardResponse,
	// Token: 0x04001EDE RID: 7902
	OnAreaExploreProgressUpdate,
	// Token: 0x04001EDF RID: 7903
	ToggleShowCustomMark,
	// Token: 0x04001EE0 RID: 7904
	ToggleShowCompletedPlayMark,
	// Token: 0x04001EE1 RID: 7905
	RedDotUpdateMapAreaBoxReward,
	// Token: 0x04001EE2 RID: 7906
	AreaPlayPointUpdate,
	// Token: 0x04001EE3 RID: 7907
	AreaStoryProgressSave,
	// Token: 0x04001EE4 RID: 7908
	NavigateMarkAndShowRange,
	// Token: 0x04001EE5 RID: 7909
	HideNavigateMarkRange,
	// Token: 0x04001EE6 RID: 7910
	UpdateOnlinePlayersArea,
	// Token: 0x04001EE7 RID: 7911
	PlayerMarkItemChanged,
	// Token: 0x04001EE8 RID: 7912
	OpenExploreAreaDetailViewFromMap,
	// Token: 0x04001EE9 RID: 7913
	OnExploreScoreRewardResponse,
	// Token: 0x04001EEA RID: 7914
	OnCountryExploreScoreInfoResponse,
	// Token: 0x04001EEB RID: 7915
	OnExploreLevelNotify,
	// Token: 0x04001EEC RID: 7916
	ShipTowerStageUpdate,
	// Token: 0x04001EED RID: 7917
	ShipTowerRewardReceive,
	// Token: 0x04001EEE RID: 7918
	ShipTowerBattleTip,
	// Token: 0x04001EEF RID: 7919
	ShipTowerSureResetStage,
	// Token: 0x04001EF0 RID: 7920
	ShipTowerSureCoverChallenge,
	// Token: 0x04001EF1 RID: 7921
	ShipTowerTeamRecommendApplyFinish,
	// Token: 0x04001EF2 RID: 7922
	BattleUiToggleShipTowerBuffInfo,
	// Token: 0x04001EF3 RID: 7923
	RedDotUpdateShipTowerReward,
	// Token: 0x04001EF4 RID: 7924
	OpenActivityViewShipTower,
	// Token: 0x04001EF5 RID: 7925
	ShipTowerBuffNewUpdate,
	// Token: 0x04001EF6 RID: 7926
	ShipTowerEndlessRecordUpdate,
	// Token: 0x04001EF7 RID: 7927
	DangoMonopolyTaskUpdate,
	// Token: 0x04001EF8 RID: 7928
	DangoMonopolyMoveStart,
	// Token: 0x04001EF9 RID: 7929
	DangoMonopolyMovePause,
	// Token: 0x04001EFA RID: 7930
	DangoMonopolyMoveContinue,
	// Token: 0x04001EFB RID: 7931
	DangoMonopolyMoveEnd,
	// Token: 0x04001EFC RID: 7932
	DangoMonopolyEnterNextRound,
	// Token: 0x04001EFD RID: 7933
	DangoMonopolyBoardRewardUpdate,
	// Token: 0x04001EFE RID: 7934
	DangoMonopolyGridRewardUpdate,
	// Token: 0x04001EFF RID: 7935
	DangoMonopolyStartShowProcess,
	// Token: 0x04001F00 RID: 7936
	DangoMonopolyEndShowProcess,
	// Token: 0x04001F01 RID: 7937
	DangoMonopolyTransitionClose,
	// Token: 0x04001F02 RID: 7938
	DangoMonopolyMoveStepStartOrEnd,
	// Token: 0x04001F03 RID: 7939
	DangoMonopolyViewStart,
	// Token: 0x04001F04 RID: 7940
	DangoMonopolyViewShowProcessStartOrEnd,
	// Token: 0x04001F05 RID: 7941
	DangoMonopolyCameraFocusOnMainDango,
	// Token: 0x04001F06 RID: 7942
	RedDotUpdateDangoMonopolyTask,
	// Token: 0x04001F07 RID: 7943
	RedDotUpdateDangoMonopolyNum,
	// Token: 0x04001F08 RID: 7944
	RedDotUpdateDangoMonopolyRound,
	// Token: 0x04001F09 RID: 7945
	MoraleProgressRewardUpdate,
	// Token: 0x04001F0A RID: 7946
	MoraleProgressScoreUpdate,
	// Token: 0x04001F0B RID: 7947
	MoraleAreaChangeFlag,
	// Token: 0x04001F0C RID: 7948
	RedDotUpdateMoraleScoreBox,
	// Token: 0x04001F0D RID: 7949
	RedDotUpdateMoraleFlagBox,
	// Token: 0x04001F0E RID: 7950
	RedDotUpdateMoraleAreaBuff,
	// Token: 0x04001F0F RID: 7951
	BattleUiToggleMoraleBuffInfo,
	// Token: 0x04001F10 RID: 7952
	OnMoralePromptShow,
	// Token: 0x04001F11 RID: 7953
	ActivityMapExploreStateUpdate,
	// Token: 0x04001F12 RID: 7954
	OnSignalCatchSuccess,
	// Token: 0x04001F13 RID: 7955
	OnSignalCatchFailed,
	// Token: 0x04001F14 RID: 7956
	OnSignalCatchStart,
	// Token: 0x04001F15 RID: 7957
	OnSignalCatchContinue,
	// Token: 0x04001F16 RID: 7958
	OnSignalCatchStartAgain,
	// Token: 0x04001F17 RID: 7959
	RefreshMonthCardRedDot,
	// Token: 0x04001F18 RID: 7960
	OnSetJoystickMode,
	// Token: 0x04001F19 RID: 7961
	OnSetMotorcycleJoystickMode,
	// Token: 0x04001F1A RID: 7962
	OnMotorcycleRoundJoystickChanged,
	// Token: 0x04001F1B RID: 7963
	OnJoystickWalkRunRateChanged,
	// Token: 0x04001F1C RID: 7964
	OnOverlapEncloseSpace,
	// Token: 0x04001F1D RID: 7965
	OnEncloseSpaceTypeChange,
	// Token: 0x04001F1E RID: 7966
	OnSubLevelAdded,
	// Token: 0x04001F1F RID: 7967
	OnLevelEnvChange,
	// Token: 0x04001F20 RID: 7968
	OnWorldOriginInUiMode,
	// Token: 0x04001F21 RID: 7969
	OnAndroidConfigurationChange,
	// Token: 0x04001F22 RID: 7970
	OnChatPlayerInfoChanged,
	// Token: 0x04001F23 RID: 7971
	OnPlotTransitionRemoveCallback,
	// Token: 0x04001F24 RID: 7972
	OnEnterOrExitExecutionRange,
	// Token: 0x04001F25 RID: 7973
	OnExecutionOptionChange,
	// Token: 0x04001F26 RID: 7974
	OnInteractActionEnd,
	// Token: 0x04001F27 RID: 7975
	OnBeforeCharActionWithTarget,
	// Token: 0x04001F28 RID: 7976
	CharActionStateChange,
	// Token: 0x04001F29 RID: 7977
	MReady,
	// Token: 0x04001F2A RID: 7978
	OnLevelFuncFlagSet,
	// Token: 0x04001F2B RID: 7979
	OnLevelFuncFlagChanged,
	// Token: 0x04001F2C RID: 7980
	OnRefreshRewardView,
	// Token: 0x04001F2D RID: 7981
	OnRefreshSpecialItemAllowReqUse,
	// Token: 0x04001F2E RID: 7982
	OnSdkFocusStateChange,
	// Token: 0x04001F2F RID: 7983
	ReconnectClearData,
	// Token: 0x04001F30 RID: 7984
	OnPreEndPIE,
	// Token: 0x04001F31 RID: 7985
	NoticeJourneyReceive,
	// Token: 0x04001F32 RID: 7986
	OnEntityInOutRangeLocal,
	// Token: 0x04001F33 RID: 7987
	OnMyPlayerInOutRangeLocal,
	// Token: 0x04001F34 RID: 7988
	OnStreamingTriggerConnected,
	// Token: 0x04001F35 RID: 7989
	OnActorInOutRangeLocal,
	// Token: 0x04001F36 RID: 7990
	OnEntityInOutRangeOnline,
	// Token: 0x04001F37 RID: 7991
	OnPlayerInOutRangeOnline,
	// Token: 0x04001F38 RID: 7992
	RoleTriggerInit,
	// Token: 0x04001F39 RID: 7993
	OnSetLoginServerId,
	// Token: 0x04001F3A RID: 7994
	SetDecalShadowEnabled,
	// Token: 0x04001F3B RID: 7995
	OnSelectTimePreset,
	// Token: 0x04001F3C RID: 7996
	OnGlobalUiSceneStateChanged,
	// Token: 0x04001F3D RID: 7997
	OnSetGamePaused,
	// Token: 0x04001F3E RID: 7998
	OnActionKeyChanged,
	// Token: 0x04001F3F RID: 7999
	OnAxisKeyChanged,
	// Token: 0x04001F40 RID: 8000
	BeamCastStart,
	// Token: 0x04001F41 RID: 8001
	BeamCastStop,
	// Token: 0x04001F42 RID: 8002
	BeamCastActorChange,
	// Token: 0x04001F43 RID: 8003
	BeamReflectStart,
	// Token: 0x04001F44 RID: 8004
	BeamReflectStop,
	// Token: 0x04001F45 RID: 8005
	OnResetPhotographCamera,
	// Token: 0x04001F46 RID: 8006
	ClearAxisInputCache,
	// Token: 0x04001F47 RID: 8007
	OnSpecialItemNotAllow,
	// Token: 0x04001F48 RID: 8008
	OnMarkItemShowStateChange,
	// Token: 0x04001F49 RID: 8009
	OnMarkItemUpdateMarkHideInfo,
	// Token: 0x04001F4A RID: 8010
	OnTimeStopRequest,
	// Token: 0x04001F4B RID: 8011
	OnAbsoluteTimeStop,
	// Token: 0x04001F4C RID: 8012
	OnFightTestEnd,
	// Token: 0x04001F4D RID: 8013
	OnManipulateShowLandTips,
	// Token: 0x04001F4E RID: 8014
	BeforeUiModelLoadStart,
	// Token: 0x04001F4F RID: 8015
	OnUiModelRoleConfigIdChange,
	// Token: 0x04001F50 RID: 8016
	OnUiModelRoleDataIdChange,
	// Token: 0x04001F51 RID: 8017
	OnUiModelStartLoad,
	// Token: 0x04001F52 RID: 8018
	OnUiModelLoadComplete,
	// Token: 0x04001F53 RID: 8019
	OnUiModelSetMorphTypeComplete,
	// Token: 0x04001F54 RID: 8020
	OnUiModelVisibleChange,
	// Token: 0x04001F55 RID: 8021
	OnUiModelSetDitherEffect,
	// Token: 0x04001F56 RID: 8022
	WorldMapSubMapChanged,
	// Token: 0x04001F57 RID: 8023
	WorldMapSubMapChangedFromUpdate,
	// Token: 0x04001F58 RID: 8024
	WorldMapSelectMultiMap,
	// Token: 0x04001F59 RID: 8025
	RoguelikePopularEntriesChange,
	// Token: 0x04001F5A RID: 8026
	OnSceneItemSplineMoveBroken,
	// Token: 0x04001F5B RID: 8027
	OnSceneItemSplineMoveStarted,
	// Token: 0x04001F5C RID: 8028
	OnSceneItemSplineMoveStopped,
	// Token: 0x04001F5D RID: 8029
	OnSceneItemMoveBroken,
	// Token: 0x04001F5E RID: 8030
	OnSceneItemMoveStopped,
	// Token: 0x04001F5F RID: 8031
	OnSceneItemRotateStopped,
	// Token: 0x04001F60 RID: 8032
	OnFragmentMemoryDataUpdate,
	// Token: 0x04001F61 RID: 8033
	OnFragmentMemoryCollectUpdate,
	// Token: 0x04001F62 RID: 8034
	OnFragmentTopicSelect,
	// Token: 0x04001F63 RID: 8035
	OnFragmentTopicClick,
	// Token: 0x04001F64 RID: 8036
	FragmentRewardRedDot,
	// Token: 0x04001F65 RID: 8037
	FragmentRewardTopicRedDot,
	// Token: 0x04001F66 RID: 8038
	FragmentRewardEntranceRedDot,
	// Token: 0x04001F67 RID: 8039
	OnChangeBossRushBuff,
	// Token: 0x04001F68 RID: 8040
	RequestChangeBossRushView,
	// Token: 0x04001F69 RID: 8041
	BossRushDataUpdate,
	// Token: 0x04001F6A RID: 8042
	BossRefreshBossRushRewardRedDot,
	// Token: 0x04001F6B RID: 8043
	BossRefreshBossRushReward,
	// Token: 0x04001F6C RID: 8044
	BossRushBuffTabChange,
	// Token: 0x04001F6D RID: 8045
	BossRushSubViewChanged,
	// Token: 0x04001F6E RID: 8046
	BossRushTaskStateChanged,
	// Token: 0x04001F6F RID: 8047
	RefreshMowingTowerData,
	// Token: 0x04001F70 RID: 8048
	RefreshMowingTowerRewardRedDot,
	// Token: 0x04001F71 RID: 8049
	RefreshMowingTowerReward,
	// Token: 0x04001F72 RID: 8050
	ChangeMowingTowerBuff,
	// Token: 0x04001F73 RID: 8051
	ChangeMowingTowerMainView,
	// Token: 0x04001F74 RID: 8052
	TowerDefenseOnOpenPhantomView,
	// Token: 0x04001F75 RID: 8053
	TowerDefenseOnClickOnePhantom,
	// Token: 0x04001F76 RID: 8054
	TowerDefenseSelfPhantomConfirm,
	// Token: 0x04001F77 RID: 8055
	TowerDefensePhantomChanged,
	// Token: 0x04001F78 RID: 8056
	TowerDefenseBeforeConfirmQuickRoleSelect,
	// Token: 0x04001F79 RID: 8057
	TowerDefenseOnWaveChanged,
	// Token: 0x04001F7A RID: 8058
	TowerDefenseOnActivityInfoUpdateNotify,
	// Token: 0x04001F7B RID: 8059
	TowerDefenseOnInstanceInfoUpdateNotify,
	// Token: 0x04001F7C RID: 8060
	TowerDefenseOnPhantomInfoUpdateNotify,
	// Token: 0x04001F7D RID: 8061
	TowerDefenseShowInBattleView,
	// Token: 0x04001F7E RID: 8062
	TowerDefenseOnShowPhantomInFormation,
	// Token: 0x04001F7F RID: 8063
	TowerDefenseOnTowerDefenseBattleEndNotify,
	// Token: 0x04001F80 RID: 8064
	TowerDefenseDataInit,
	// Token: 0x04001F81 RID: 8065
	OnBeforeDestroyInstanceDungeonEntranceView,
	// Token: 0x04001F82 RID: 8066
	TrapFollowerSkillCd,
	// Token: 0x04001F83 RID: 8067
	RefreshTrapDefensePsFeedback,
	// Token: 0x04001F84 RID: 8068
	TowerDefenseRecycleRaycastNotify,
	// Token: 0x04001F85 RID: 8069
	TowerDefenseEventStepUpdate,
	// Token: 0x04001F86 RID: 8070
	TowerDefenseEventNotifyType,
	// Token: 0x04001F87 RID: 8071
	TrapDefenseMapMarkRemoved,
	// Token: 0x04001F88 RID: 8072
	TrapDefenseMapChanged,
	// Token: 0x04001F89 RID: 8073
	TrapDefenseComboNumChange,
	// Token: 0x04001F8A RID: 8074
	TrapDefenseOnSystemInfoNotify,
	// Token: 0x04001F8B RID: 8075
	OnClickEnterInstanceSingle,
	// Token: 0x04001F8C RID: 8076
	OnNeedRefreshByProtocol,
	// Token: 0x04001F8D RID: 8077
	MowingBasicBuffGridItemClick,
	// Token: 0x04001F8E RID: 8078
	MowingSuperBuffGridItemClick,
	// Token: 0x04001F8F RID: 8079
	MowingRiskInBattleViewSetActive,
	// Token: 0x04001F90 RID: 8080
	MowingRiskInBattleRootUpdate,
	// Token: 0x04001F91 RID: 8081
	MowingRiskOnInstanceClearRewardResponse,
	// Token: 0x04001F92 RID: 8082
	MowingRiskOnScoreRewardResponse,
	// Token: 0x04001F93 RID: 8083
	MowingRiskOnBuffCountRewardResponse,
	// Token: 0x04001F94 RID: 8084
	MowingRiskOnRefreshRewardRedDot,
	// Token: 0x04001F95 RID: 8085
	MowingRiskOnRefreshBuffAllRedDot,
	// Token: 0x04001F96 RID: 8086
	MowingRiskOnBuffTipsAfterDestroy,
	// Token: 0x04001F97 RID: 8087
	MowingRiskOnNeedPlayLevelUpSequence,
	// Token: 0x04001F98 RID: 8088
	MowingRiskOnGetReward,
	// Token: 0x04001F99 RID: 8089
	SpecialOpenMapAction,
	// Token: 0x04001F9A RID: 8090
	VersionPreheatRewardResponse,
	// Token: 0x04001F9B RID: 8091
	VersionPreheatOnClickVote,
	// Token: 0x04001F9C RID: 8092
	VersionPreheatSendVote,
	// Token: 0x04001F9D RID: 8093
	Spring25DrawRewardDone,
	// Token: 0x04001F9E RID: 8094
	Spring25SkinRewardDone,
	// Token: 0x04001F9F RID: 8095
	Spring25InviteDone,
	// Token: 0x04001FA0 RID: 8096
	Spring25SelectLetter,
	// Token: 0x04001FA1 RID: 8097
	Spring25ActivityParseDone,
	// Token: 0x04001FA2 RID: 8098
	Spring25CloseLetterList,
	// Token: 0x04001FA3 RID: 8099
	Spring25UnlockAnimDone,
	// Token: 0x04001FA4 RID: 8100
	OnSetGameModeDataDone,
	// Token: 0x04001FA5 RID: 8101
	OnBossRushBuffViewOpened,
	// Token: 0x04001FA6 RID: 8102
	OnTutorialTipExistChanged,
	// Token: 0x04001FA7 RID: 8103
	OnTutorialUpdate,
	// Token: 0x04001FA8 RID: 8104
	AddLevelLoadingTimeDilationTag,
	// Token: 0x04001FA9 RID: 8105
	RemoveLevelLoadingTimeDilationTag,
	// Token: 0x04001FAA RID: 8106
	RogueLevelLoadingLockTimeDilation,
	// Token: 0x04001FAB RID: 8107
	RogueLevelLoadingUnlockTimeDilation,
	// Token: 0x04001FAC RID: 8108
	BusinessInvestResult,
	// Token: 0x04001FAD RID: 8109
	SetDelegationResultData,
	// Token: 0x04001FAE RID: 8110
	PopularityChange,
	// Token: 0x04001FAF RID: 8111
	OpenTipsTravelView,
	// Token: 0x04001FB0 RID: 8112
	OpenTipsShopView,
	// Token: 0x04001FB1 RID: 8113
	UnlockMoonChasingData,
	// Token: 0x04001FB2 RID: 8114
	RefreshCorniceMeetingRedDot,
	// Token: 0x04001FB3 RID: 8115
	OnClickActivityCorniceMeetingTab,
	// Token: 0x04001FB4 RID: 8116
	OnPlayerFollowerConfigChanged,
	// Token: 0x04001FB5 RID: 8117
	OnPlayerFollowerPossessed,
	// Token: 0x04001FB6 RID: 8118
	OnPlayerFollowerUnPossessed,
	// Token: 0x04001FB7 RID: 8119
	OnPlayerFollowerEnableChange,
	// Token: 0x04001FB8 RID: 8120
	OnFollowerAdd,
	// Token: 0x04001FB9 RID: 8121
	BuildAnimFinish,
	// Token: 0x04001FBA RID: 8122
	ConditionUnlockRole,
	// Token: 0x04001FBB RID: 8123
	TakenRewardTargetData,
	// Token: 0x04001FBC RID: 8124
	RefreshRewardTargetData,
	// Token: 0x04001FBD RID: 8125
	RefreshDelegate,
	// Token: 0x04001FBE RID: 8126
	ElevatorMove,
	// Token: 0x04001FBF RID: 8127
	OnHighSpeedModeChanged,
	// Token: 0x04001FC0 RID: 8128
	SlowStreamingBySoar,
	// Token: 0x04001FC1 RID: 8129
	OnDropDownListVisibleChanged,
	// Token: 0x04001FC2 RID: 8130
	OnGlobalFootstepMaterialChange,
	// Token: 0x04001FC3 RID: 8131
	OnForbidWeatherStateChange,
	// Token: 0x04001FC4 RID: 8132
	OnPortalRegister,
	// Token: 0x04001FC5 RID: 8133
	OnPortalUnRegister,
	// Token: 0x04001FC6 RID: 8134
	OnRolePassPortalBeforeTeleport,
	// Token: 0x04001FC7 RID: 8135
	OnRolePassPortalAfterTeleport,
	// Token: 0x04001FC8 RID: 8136
	OnEnterVehicle,
	// Token: 0x04001FC9 RID: 8137
	OnLeaveVehicle,
	// Token: 0x04001FCA RID: 8138
	OnVehicleBeenEntered,
	// Token: 0x04001FCB RID: 8139
	OnVehicleBeenLeaved,
	// Token: 0x04001FCC RID: 8140
	OnEnterVehicleAtOnceResponse,
	// Token: 0x04001FCD RID: 8141
	OnLeaveVehicleAtOnceResponse,
	// Token: 0x04001FCE RID: 8142
	OnEnterVehicleRideSharing,
	// Token: 0x04001FCF RID: 8143
	OnLeaveVehicleRideSharing,
	// Token: 0x04001FD0 RID: 8144
	OnChangeRideSharingPassenger,
	// Token: 0x04001FD1 RID: 8145
	OnRemoveRideSharingPassenger,
	// Token: 0x04001FD2 RID: 8146
	OnChangeRideSharingPassengerResponse,
	// Token: 0x04001FD3 RID: 8147
	OnRemoveRideSharingPassengerResponse,
	// Token: 0x04001FD4 RID: 8148
	OnChangeRideSharingPassengerNotify,
	// Token: 0x04001FD5 RID: 8149
	OnRemoveRideSharingPassengerNotify,
	// Token: 0x04001FD6 RID: 8150
	OnSpecialVehicleShareNotify,
	// Token: 0x04001FD7 RID: 8151
	OnMovieMotorRideSharingModeChangeRequest,
	// Token: 0x04001FD8 RID: 8152
	OnMovieMotorRideSharingModeChangeResponse,
	// Token: 0x04001FD9 RID: 8153
	OnVehicleSkillEnableChanged,
	// Token: 0x04001FDA RID: 8154
	OnVehicleSkillUsableCountChanged,
	// Token: 0x04001FDB RID: 8155
	OnBeforeAttachVehicle,
	// Token: 0x04001FDC RID: 8156
	OnAfterAttachVehicle,
	// Token: 0x04001FDD RID: 8157
	OnWaterfallMoveBegin,
	// Token: 0x04001FDE RID: 8158
	OnWaterfallMoveEnd,
	// Token: 0x04001FDF RID: 8159
	OnVehicleDriverChange,
	// Token: 0x04001FE0 RID: 8160
	OnVehicleActivate,
	// Token: 0x04001FE1 RID: 8161
	OnCoBathSwitchFirstPlayerView,
	// Token: 0x04001FE2 RID: 8162
	OnChangeModuleDebugLevel,
	// Token: 0x04001FE3 RID: 8163
	OnBattleLinkStop,
	// Token: 0x04001FE4 RID: 8164
	OnBattleLinkRestart,
	// Token: 0x04001FE5 RID: 8165
	OnBattleLinkStatusChanged,
	// Token: 0x04001FE6 RID: 8166
	OnNewLinkStatusChanged,
	// Token: 0x04001FE7 RID: 8167
	OnBattleLinkToggle,
	// Token: 0x04001FE8 RID: 8168
	OnMoraleActiveChanged,
	// Token: 0x04001FE9 RID: 8169
	OnMoraleExpChanged,
	// Token: 0x04001FEA RID: 8170
	OnMoraleTempExpChanged,
	// Token: 0x04001FEB RID: 8171
	OnMoraleSumLevelChanged,
	// Token: 0x04001FEC RID: 8172
	OnMoraleIndomitableLevelChanged,
	// Token: 0x04001FED RID: 8173
	OnMoralePlayIndomitableLevelAnim,
	// Token: 0x04001FEE RID: 8174
	OnMoraleTempExpViewVisibleChanged,
	// Token: 0x04001FEF RID: 8175
	OnMoraleBattleFail,
	// Token: 0x04001FF0 RID: 8176
	OnMarkActorInFighting,
	// Token: 0x04001FF1 RID: 8177
	OnPunishMarkStateChanged,
	// Token: 0x04001FF2 RID: 8178
	OnInputSettingResponse,
	// Token: 0x04001FF3 RID: 8179
	OnInputSettingUpdateNotify,
	// Token: 0x04001FF4 RID: 8180
	RecallActivityInfoUpdate,
	// Token: 0x04001FF5 RID: 8181
	ActivityDirectTrainDataUpdate,
	// Token: 0x04001FF6 RID: 8182
	ActivityDirectTrainRedDotUpdate,
	// Token: 0x04001FF7 RID: 8183
	OnActivityDirectTrainProSetActive,
	// Token: 0x04001FF8 RID: 8184
	OnScratchTicketConditionRefresh,
	// Token: 0x04001FF9 RID: 8185
	OnSelectRoleDreamDungeon,
	// Token: 0x04001FFA RID: 8186
	OnMailBindInfoResponse,
	// Token: 0x04001FFB RID: 8187
	OnMailBindRewardResponse,
	// Token: 0x04001FFC RID: 8188
	OnMailBindResponse,
	// Token: 0x04001FFD RID: 8189
	OnMailBindInfoNotify,
	// Token: 0x04001FFE RID: 8190
	RefreshMailBindRedDot,
	// Token: 0x04001FFF RID: 8191
	CharacterWeaponLoaded,
	// Token: 0x04002000 RID: 8192
	FightWeaponSkinChange,
	// Token: 0x04002001 RID: 8193
	EquipWeaponSkin,
	// Token: 0x04002002 RID: 8194
	UninstallWeaponSkin,
	// Token: 0x04002003 RID: 8195
	OnRoleFlyEquipNotify,
	// Token: 0x04002004 RID: 8196
	OnRoleFlyEquipChangeNotify,
	// Token: 0x04002005 RID: 8197
	OnFlySkinEquipResponse,
	// Token: 0x04002006 RID: 8198
	OnFlySkinUnLoadResponse,
	// Token: 0x04002007 RID: 8199
	OnFlySkinAllUnLoadResponse,
	// Token: 0x04002008 RID: 8200
	OnFlySkinEquipToAllRoleResponse,
	// Token: 0x04002009 RID: 8201
	OnRoleFlySkinChange,
	// Token: 0x0400200A RID: 8202
	OnFlyEquipAddNotify,
	// Token: 0x0400200B RID: 8203
	RefreshFlySkinTabRedDot,
	// Token: 0x0400200C RID: 8204
	RefreshFlySkinChildTabRed,
	// Token: 0x0400200D RID: 8205
	OnSkinRootViewDestroy,
	// Token: 0x0400200E RID: 8206
	OnUpdateAreaAlertEnable,
	// Token: 0x0400200F RID: 8207
	OnUpdateAreaAlertValue,
	// Token: 0x04002010 RID: 8208
	OnUpdateAreaAlertUiEnable,
	// Token: 0x04002011 RID: 8209
	OnUpdateAreaAlertUiVisible,
	// Token: 0x04002012 RID: 8210
	LevelPlayReportSimpleUpdate,
	// Token: 0x04002013 RID: 8211
	LevelPlayReportDetailUpdate,
	// Token: 0x04002014 RID: 8212
	LevelPlayStateDetailUpdate,
	// Token: 0x04002015 RID: 8213
	OnBigStuffedDollGameStageUpdate,
	// Token: 0x04002016 RID: 8214
	OnBigStuffedDollArrowStayAreaUpdate,
	// Token: 0x04002017 RID: 8215
	OnBigStuffedDollRingItemSequencePlayStart,
	// Token: 0x04002018 RID: 8216
	OnBigStuffedDollRingItemSequencePlayEnd,
	// Token: 0x04002019 RID: 8217
	OnRacingBetsDataRefresh,
	// Token: 0x0400201A RID: 8218
	OnRacingBetsBettingInfoUpdate,
	// Token: 0x0400201B RID: 8219
	OnRacingBetsPlayerInfoUpdate,
	// Token: 0x0400201C RID: 8220
	OnRacingBetsDangoOddsUpdate,
	// Token: 0x0400201D RID: 8221
	OnRacingBetsRewardRefresh,
	// Token: 0x0400201E RID: 8222
	OnRacingBetsDangoOrderRefresh,
	// Token: 0x0400201F RID: 8223
	OnRacingBetsDangoOrderEnd,
	// Token: 0x04002020 RID: 8224
	OnRacingBetsDangoRoundStart,
	// Token: 0x04002021 RID: 8225
	OnRacingBetsDiceAnim,
	// Token: 0x04002022 RID: 8226
	OnRacingBetsDiceAnimEnd,
	// Token: 0x04002023 RID: 8227
	OnRacingBetsDungeonDangoRankChange,
	// Token: 0x04002024 RID: 8228
	OnRacingBetsLegMatchEnd,
	// Token: 0x04002025 RID: 8229
	OnRacingBetsRedDotUpdate,
	// Token: 0x04002026 RID: 8230
	OnRacingBetsPushBulletScreen,
	// Token: 0x04002027 RID: 8231
	OnRacingBetsViewAfterShow,
	// Token: 0x04002028 RID: 8232
	OnRacingBetsReplay,
	// Token: 0x04002029 RID: 8233
	OnFloroRanchNextDayTaskRefresh,
	// Token: 0x0400202A RID: 8234
	OnFloroRanchInsertTask,
	// Token: 0x0400202B RID: 8235
	OnFloroRanchStageInfoRefresh,
	// Token: 0x0400202C RID: 8236
	OnFloroRanchCardEntityCountChange,
	// Token: 0x0400202D RID: 8237
	FloroRanchDataRedDot,
	// Token: 0x0400202E RID: 8238
	FloroRanchRaceRedDot,
	// Token: 0x0400202F RID: 8239
	FloroRanchSkillChange,
	// Token: 0x04002030 RID: 8240
	FloroRanchSkillRedDotRefresh,
	// Token: 0x04002031 RID: 8241
	FloroRanchSettlement,
	// Token: 0x04002032 RID: 8242
	FloroRanchWeeklySettlement,
	// Token: 0x04002033 RID: 8243
	FloroRanchSubInsHistoryUpdate,
	// Token: 0x04002034 RID: 8244
	OnFloroRanchDebugInfoRefresh,
	// Token: 0x04002035 RID: 8245
	OnFloroRanchSuccessSettleViewOpen,
	// Token: 0x04002036 RID: 8246
	OnFloroRanchStageStartTaskBeforeFinish,
	// Token: 0x04002037 RID: 8247
	FishingRefreshBackpackData,
	// Token: 0x04002038 RID: 8248
	FishingBackpackDeliverableRefresh,
	// Token: 0x04002039 RID: 8249
	FishingShipSkinChangeSuccess,
	// Token: 0x0400203A RID: 8250
	DriveFishingShipStateChanged,
	// Token: 0x0400203B RID: 8251
	FishingRefreshQuestView,
	// Token: 0x0400203C RID: 8252
	FishingRefreshDockId,
	// Token: 0x0400203D RID: 8253
	OnRefreshTempFishingPointNum,
	// Token: 0x0400203E RID: 8254
	FishingEntrustStartShowTrackText,
	// Token: 0x0400203F RID: 8255
	FishingEntrustEndShowTrackText,
	// Token: 0x04002040 RID: 8256
	OnFishingSailing,
	// Token: 0x04002041 RID: 8257
	FishingRefreshHandBookRewardView,
	// Token: 0x04002042 RID: 8258
	FishingShipDataRefresh,
	// Token: 0x04002043 RID: 8259
	FishingPointFinish,
	// Token: 0x04002044 RID: 8260
	OnFishingQteStageUpdate,
	// Token: 0x04002045 RID: 8261
	OnFishingQteAreaChange,
	// Token: 0x04002046 RID: 8262
	OnFishingTechNodeRefresh,
	// Token: 0x04002047 RID: 8263
	OnFishingTechNodeRedDotRefresh,
	// Token: 0x04002048 RID: 8264
	OnFishingRoleTechRefresh,
	// Token: 0x04002049 RID: 8265
	FishingTimeLimitRewardListRefresh,
	// Token: 0x0400204A RID: 8266
	FishingTimeLimitRewardProgressRefresh,
	// Token: 0x0400204B RID: 8267
	FishingTimeLimitShopRefresh,
	// Token: 0x0400204C RID: 8268
	FishingShipSkinClick,
	// Token: 0x0400204D RID: 8269
	FishingTechViewComeBack,
	// Token: 0x0400204E RID: 8270
	FishingRoleTechViewOpened,
	// Token: 0x0400204F RID: 8271
	FishingDockyardItemTipsShown,
	// Token: 0x04002050 RID: 8272
	FishingQteBtnHitValidArea,
	// Token: 0x04002051 RID: 8273
	OnFishingQteScoreReachedMaximum,
	// Token: 0x04002052 RID: 8274
	FishingBackpackBtnStateChange,
	// Token: 0x04002053 RID: 8275
	OnTreasureCompassUnitVisibleChange,
	// Token: 0x04002054 RID: 8276
	OnFishingBackpackQuickSellToggleStateChange,
	// Token: 0x04002055 RID: 8277
	PlayerSoarChanged,
	// Token: 0x04002056 RID: 8278
	FilterCriteriaChanged,
	// Token: 0x04002057 RID: 8279
	EntityToLoadFilterCreated,
	// Token: 0x04002058 RID: 8280
	EntityToLoadFilterDestroyed,
	// Token: 0x04002059 RID: 8281
	EntityToLoadParamUpdated,
	// Token: 0x0400205A RID: 8282
	VehicleInputLayerPress,
	// Token: 0x0400205B RID: 8283
	VehicleInputLayerRelease,
	// Token: 0x0400205C RID: 8284
	SkillLongPressStart,
	// Token: 0x0400205D RID: 8285
	SkillLongPressEnd,
	// Token: 0x0400205E RID: 8286
	CheckClientEvent,
	// Token: 0x0400205F RID: 8287
	StartMoveWithSpline,
	// Token: 0x04002060 RID: 8288
	OnPhonographSwitchMusic,
	// Token: 0x04002061 RID: 8289
	OnPhonographSelectDisable,
	// Token: 0x04002062 RID: 8290
	OnPhonographPlayTick,
	// Token: 0x04002063 RID: 8291
	OnPhonographPlayStop,
	// Token: 0x04002064 RID: 8292
	OnPhonographRemoveNewTag,
	// Token: 0x04002065 RID: 8293
	OnPhonographSetBgm,
	// Token: 0x04002066 RID: 8294
	OnPhonographMusicForceRefresh,
	// Token: 0x04002067 RID: 8295
	RefreshActivityEntranceScroller,
	// Token: 0x04002068 RID: 8296
	RefreshActivityEntranceItemContent,
	// Token: 0x04002069 RID: 8297
	FarmGoldRefreshRewardRedDot,
	// Token: 0x0400206A RID: 8298
	EntityCampModify,
	// Token: 0x0400206B RID: 8299
	MobileGamepadDisconnect,
	// Token: 0x0400206C RID: 8300
	DisableCustomInputData,
	// Token: 0x0400206D RID: 8301
	EnableCacheCustomInputData,
	// Token: 0x0400206E RID: 8302
	EnableActionRecord,
	// Token: 0x0400206F RID: 8303
	SolarSpeedClickRewardTab,
	// Token: 0x04002070 RID: 8304
	SolarSpeedRewarded,
	// Token: 0x04002071 RID: 8305
	SolarSpeedSubViewOnRefreshView,
	// Token: 0x04002072 RID: 8306
	ShipTowerTeamPanelShown,
	// Token: 0x04002073 RID: 8307
	OnCharacterMorphTypeChanged,
	// Token: 0x04002074 RID: 8308
	OnBeforeCharacterMorphTypeChanged,
	// Token: 0x04002075 RID: 8309
	OnCharacterSetMaster,
	// Token: 0x04002076 RID: 8310
	OnSwitchSelfCenteredMode,
	// Token: 0x04002077 RID: 8311
	OnGravityFlipAnimFinish,
	// Token: 0x04002078 RID: 8312
	BabelTowerRefreshLevelInfo,
	// Token: 0x04002079 RID: 8313
	BabelTowerRefreshQuestState,
	// Token: 0x0400207A RID: 8314
	BabelTowerDifficultyLevelClick,
	// Token: 0x0400207B RID: 8315
	BabelTowerLevelClick,
	// Token: 0x0400207C RID: 8316
	BabelTowerLevelRedDotUpdate,
	// Token: 0x0400207D RID: 8317
	BabelTowerDifficultyRedDotUpdate,
	// Token: 0x0400207E RID: 8318
	OnBabelActivityInstInfoUpdate,
	// Token: 0x0400207F RID: 8319
	OnAbyssRoleInfoUpdate,
	// Token: 0x04002080 RID: 8320
	OnAbyssPluginInfoUpdate,
	// Token: 0x04002081 RID: 8321
	OnAbyssRewardStateUpdate,
	// Token: 0x04002082 RID: 8322
	RefreshAbyssRewardRedDot,
	// Token: 0x04002083 RID: 8323
	OnAbyssUnlockChallengeStateUpdate,
	// Token: 0x04002084 RID: 8324
	OnAbyssChallengeResult,
	// Token: 0x04002085 RID: 8325
	OnAbyssLikeChange,
	// Token: 0x04002086 RID: 8326
	OnAbyssFormationUpdate,
	// Token: 0x04002087 RID: 8327
	OnAbyssAddRole,
	// Token: 0x04002088 RID: 8328
	OnAbyssDangoLevelUp,
	// Token: 0x04002089 RID: 8329
	OnAbyssPluginItemEquip,
	// Token: 0x0400208A RID: 8330
	OnAbyssPluginRecovery,
	// Token: 0x0400208B RID: 8331
	RefreshAbyssDevelopRedDot,
	// Token: 0x0400208C RID: 8332
	OnAbyssDangoSelect,
	// Token: 0x0400208D RID: 8333
	RefreshAbyssDangoRedDot,
	// Token: 0x0400208E RID: 8334
	OnAbyssRoomInfoUpdate,
	// Token: 0x0400208F RID: 8335
	OnAbyssFirstRoomEnter,
	// Token: 0x04002090 RID: 8336
	OnAbyssRoomPreloadFinished,
	// Token: 0x04002091 RID: 8337
	RefreshFormationDango,
	// Token: 0x04002092 RID: 8338
	ShowBadDangoTip,
	// Token: 0x04002093 RID: 8339
	OnAbyssPluginDangoSelect,
	// Token: 0x04002094 RID: 8340
	OnAbyssTeamBtnVisibleRefresh,
	// Token: 0x04002095 RID: 8341
	OnAbyssPluginEquipAttrRefresh,
	// Token: 0x04002096 RID: 8342
	PreDownloadStateUpdate,
	// Token: 0x04002097 RID: 8343
	OnPreDownloadAvailableUpdate,
	// Token: 0x04002098 RID: 8344
	InviteNewbieEntered,
	// Token: 0x04002099 RID: 8345
	InviteNewbieInviteCodeChanged,
	// Token: 0x0400209A RID: 8346
	RefreshCommonH5ActivityRedDot,
	// Token: 0x0400209B RID: 8347
	OnCiacconaAvgReChoose,
	// Token: 0x0400209C RID: 8348
	OnCiacconaReChooseConfirm,
	// Token: 0x0400209D RID: 8349
	OnCiacconaReChooseCancel,
	// Token: 0x0400209E RID: 8350
	NotifyBtCiacconaChapterFinish,
	// Token: 0x0400209F RID: 8351
	OnCiacconaChapterFinish,
	// Token: 0x040020A0 RID: 8352
	OnCiacconaChapterDataUpdate,
	// Token: 0x040020A1 RID: 8353
	OnCiacconaInspirationDataUpdate,
	// Token: 0x040020A2 RID: 8354
	OnCiacconaEndingDataUpdate,
	// Token: 0x040020A3 RID: 8355
	OnCiacconaRewardDataUpdate,
	// Token: 0x040020A4 RID: 8356
	OnCiacconaActivityStateUpdate,
	// Token: 0x040020A5 RID: 8357
	OnCiacconaAvgInspirationChoiceShow,
	// Token: 0x040020A6 RID: 8358
	OnCiacconaChapterFirstStart,
	// Token: 0x040020A7 RID: 8359
	OnCiacconaChapterRestart,
	// Token: 0x040020A8 RID: 8360
	OnTermExplanationViewOpening,
	// Token: 0x040020A9 RID: 8361
	OnTermExplanationViewBeforeStart,
	// Token: 0x040020AA RID: 8362
	OnTermExplanationViewClosed,
	// Token: 0x040020AB RID: 8363
	OnTermExplanationRegisteredTextContentChange,
	// Token: 0x040020AC RID: 8364
	OnQuestReviewMainViewBeforeHide,
	// Token: 0x040020AD RID: 8365
	OnOpenQuestReviewDetail,
	// Token: 0x040020AE RID: 8366
	ResDownLoadStateRefresh,
	// Token: 0x040020AF RID: 8367
	RefreshRound,
	// Token: 0x040020B0 RID: 8368
	OwnBattleStatusChange,
	// Token: 0x040020B1 RID: 8369
	OwnBattleAttrChange,
	// Token: 0x040020B2 RID: 8370
	OwnHandCardAdd,
	// Token: 0x040020B3 RID: 8371
	OwnHandCardRemove,
	// Token: 0x040020B4 RID: 8372
	OwnHandCardAddFourCost,
	// Token: 0x040020B5 RID: 8373
	OpponentBattleStatusChange,
	// Token: 0x040020B6 RID: 8374
	OpponentBattleAttrChange,
	// Token: 0x040020B7 RID: 8375
	ReplaceCardFinish,
	// Token: 0x040020B8 RID: 8376
	OwnCardLibraryChange,
	// Token: 0x040020B9 RID: 8377
	OpponentHandCardChange,
	// Token: 0x040020BA RID: 8378
	OpponentCardLibraryChange,
	// Token: 0x040020BB RID: 8379
	PhantomArenaTriggerSkillEffect,
	// Token: 0x040020BC RID: 8380
	NotifyCardTaskData,
	// Token: 0x040020BD RID: 8381
	DiscardCardPanelActive,
	// Token: 0x040020BE RID: 8382
	ReserveCardPanelActive,
	// Token: 0x040020BF RID: 8383
	RefreshBattleCardNum,
	// Token: 0x040020C0 RID: 8384
	RefreshHandCardState,
	// Token: 0x040020C1 RID: 8385
	PhantomArenaCardAttrRefresh,
	// Token: 0x040020C2 RID: 8386
	PhantomArenaCardFactorsRefresh,
	// Token: 0x040020C3 RID: 8387
	OnPhantomArenaCardUnlock,
	// Token: 0x040020C4 RID: 8388
	OnPhantomArenaCardOutlookUnlock,
	// Token: 0x040020C5 RID: 8389
	NotifyBattleCardChange,
	// Token: 0x040020C6 RID: 8390
	OnPhantomArenaTaskAwardUpdate,
	// Token: 0x040020C7 RID: 8391
	OnPhantomArenaMasterInfoUpdate,
	// Token: 0x040020C8 RID: 8392
	OnPhantomArenaCardRewardUpdate,
	// Token: 0x040020C9 RID: 8393
	OnPhantomArenaBadgeRewardUpdate,
	// Token: 0x040020CA RID: 8394
	OnPhantomArenaChallengeUpdate,
	// Token: 0x040020CB RID: 8395
	OnPhantomArenaRoleRewardUpdate,
	// Token: 0x040020CC RID: 8396
	OnPhantomArenaShopOpen,
	// Token: 0x040020CD RID: 8397
	OnPhantomArenaBattleLoadingHide,
	// Token: 0x040020CE RID: 8398
	OnPhantomArenaBattleDamageAccumulateEnd,
	// Token: 0x040020CF RID: 8399
	PhantomArenaStartTurnResult,
	// Token: 0x040020D0 RID: 8400
	OnPhantomArenaHandCardsShowHideChange,
	// Token: 0x040020D1 RID: 8401
	OnPhantomArenaCardDetailShowHideChange,
	// Token: 0x040020D2 RID: 8402
	OnPhantomArenaBattleCardNumChange,
	// Token: 0x040020D3 RID: 8403
	OnPhantomArenaChildViewOpen,
	// Token: 0x040020D4 RID: 8404
	OnHandAreaAddCard,
	// Token: 0x040020D5 RID: 8405
	GamepadTriggerCardInfo,
	// Token: 0x040020D6 RID: 8406
	PhantomBattleBoardSettleNotify,
	// Token: 0x040020D7 RID: 8407
	OpponentSealFieldChange,
	// Token: 0x040020D8 RID: 8408
	OwnSealRecycleChange,
	// Token: 0x040020D9 RID: 8409
	OnFieldCardSkillActivated,
	// Token: 0x040020DA RID: 8410
	CumulativeShopTaskRefresh,
	// Token: 0x040020DB RID: 8411
	CumulativeShopTaskViewDataRefresh,
	// Token: 0x040020DC RID: 8412
	RefreshPlayerInfoVisible,
	// Token: 0x040020DD RID: 8413
	UpdateRayTraceReflection,
	// Token: 0x040020DE RID: 8414
	OnEntityBeSlashAim,
	// Token: 0x040020DF RID: 8415
	OnSelectHintChange,
	// Token: 0x040020E0 RID: 8416
	OnInEntityInteractRangeChange,
	// Token: 0x040020E1 RID: 8417
	OnInteractionSpotStateChange,
	// Token: 0x040020E2 RID: 8418
	SetInteractSpotOccupied,
	// Token: 0x040020E3 RID: 8419
	OnInteractionLongPressProgressChange,
	// Token: 0x040020E4 RID: 8420
	RefreshBeginnerCarnivalTask,
	// Token: 0x040020E5 RID: 8421
	NpcAnimStateSwitchBegin,
	// Token: 0x040020E6 RID: 8422
	NpcAnimStateSwitchEnd,
	// Token: 0x040020E7 RID: 8423
	NpcVisibleChanged,
	// Token: 0x040020E8 RID: 8424
	NpcPendingDestroy,
	// Token: 0x040020E9 RID: 8425
	SoarTypeChange,
	// Token: 0x040020EA RID: 8426
	OnDemoInteractiveActorAdd,
	// Token: 0x040020EB RID: 8427
	OnDemoInteractiveActorRemove,
	// Token: 0x040020EC RID: 8428
	OnDemoInteractiveActorMemberUpdated,
	// Token: 0x040020ED RID: 8429
	OnDemoInteractiveActorMemberCalled,
	// Token: 0x040020EE RID: 8430
	TuningStandUpdate,
	// Token: 0x040020EF RID: 8431
	TuningStandSuccess,
	// Token: 0x040020F0 RID: 8432
	TuningStandSuccessShowStart,
	// Token: 0x040020F1 RID: 8433
	TuningStandSuccessShowEnd,
	// Token: 0x040020F2 RID: 8434
	TuningStandBubbleUpdate,
	// Token: 0x040020F3 RID: 8435
	TuningStandBubbleEnd,
	// Token: 0x040020F4 RID: 8436
	TuningStandTooLongTime,
	// Token: 0x040020F5 RID: 8437
	TuningStandOnLinkMiss,
	// Token: 0x040020F6 RID: 8438
	OnKingShipAttrItemSetShow,
	// Token: 0x040020F7 RID: 8439
	OnKingShipAllAttrItemShown,
	// Token: 0x040020F8 RID: 8440
	OnRefreshBeginnerCarnivalChoseRole,
	// Token: 0x040020F9 RID: 8441
	OnMontageRemain,
	// Token: 0x040020FA RID: 8442
	OnGeneratedMonsterPatrolGroup,
	// Token: 0x040020FB RID: 8443
	OnGroupAiSyncTagAdded,
	// Token: 0x040020FC RID: 8444
	OnGroupAiSyncTagRemoved,
	// Token: 0x040020FD RID: 8445
	OnStateTaskFinished,
	// Token: 0x040020FE RID: 8446
	OnStateActivated,
	// Token: 0x040020FF RID: 8447
	OnForeverTimeDilationAdd,
	// Token: 0x04002100 RID: 8448
	OnForeverTimeDilationRemove,
	// Token: 0x04002101 RID: 8449
	TrapDefenseBuildingDevelopSelectUpdate,
	// Token: 0x04002102 RID: 8450
	TrapDefenseBuildingBottomSelectUpdate,
	// Token: 0x04002103 RID: 8451
	TrapDefenseBuildingPreviewSelectUpdate,
	// Token: 0x04002104 RID: 8452
	TrapDefenseOnDevelopUpdate,
	// Token: 0x04002105 RID: 8453
	TrapDefenseOnDevelopResetAll,
	// Token: 0x04002106 RID: 8454
	TrapDefenseOnSlotUpdate,
	// Token: 0x04002107 RID: 8455
	TrapDefenseOnBranchUpdate,
	// Token: 0x04002108 RID: 8456
	TrapDefenseActivityDataUpdate,
	// Token: 0x04002109 RID: 8457
	TrapDefenseLevelDataListUpdate,
	// Token: 0x0400210A RID: 8458
	TrapDefenseBdBuffListUpdate,
	// Token: 0x0400210B RID: 8459
	TrapDefenseBdBuffAllUpdate,
	// Token: 0x0400210C RID: 8460
	TrapDefenseRewardUpdate,
	// Token: 0x0400210D RID: 8461
	TrapDefenseTalentTreeUpdate,
	// Token: 0x0400210E RID: 8462
	TrapDefenseShopRefresh,
	// Token: 0x0400210F RID: 8463
	TrapDefenseBuildingDevelopDetailUpdate,
	// Token: 0x04002110 RID: 8464
	TrapDefenseBdBuffSelectChange,
	// Token: 0x04002111 RID: 8465
	RedDotUpdateTrapDefenseFixedReward,
	// Token: 0x04002112 RID: 8466
	RedDotUpdateTrapDefenseLimitReward,
	// Token: 0x04002113 RID: 8467
	RedDotUpdateTrapDefenseTalentTree,
	// Token: 0x04002114 RID: 8468
	RedDotUpdateTrapDefenseBdBuffNewUnlock,
	// Token: 0x04002115 RID: 8469
	RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime,
	// Token: 0x04002116 RID: 8470
	RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime,
	// Token: 0x04002117 RID: 8471
	RedDotUpdateTrapDefenseRougeModeOpen,
	// Token: 0x04002118 RID: 8472
	TrapDefenseLevelUpPointUpdate,
	// Token: 0x04002119 RID: 8473
	TrapDefenseInventoryDataUpdate,
	// Token: 0x0400211A RID: 8474
	TrapDefenseBuildingDevelopDetailInfoItemUpdate,
	// Token: 0x0400211B RID: 8475
	TrapDefensePreviewMachine,
	// Token: 0x0400211C RID: 8476
	TrapDefenseBuildingDevelopMainViewStart,
	// Token: 0x0400211D RID: 8477
	TrapDefenseMainLevelViewOpen,
	// Token: 0x0400211E RID: 8478
	OnCommonKeySettingKeyChange,
	// Token: 0x0400211F RID: 8479
	RefreshLifePointDrawChallengeRedDot,
	// Token: 0x04002120 RID: 8480
	RefreshLifePointDrawGroupRedDot,
	// Token: 0x04002121 RID: 8481
	OnChangeBasedPlatform,
	// Token: 0x04002122 RID: 8482
	ForceClientTravelModify,
	// Token: 0x04002123 RID: 8483
	GreatSwordLevelPlayUiInfoUpdated,
	// Token: 0x04002124 RID: 8484
	GreatSwordLevelSelectedComplete,
	// Token: 0x04002125 RID: 8485
	GreatSwordLevelRefreshUI,
	// Token: 0x04002126 RID: 8486
	OnSelectActivityFunPlayChallengeItem,
	// Token: 0x04002127 RID: 8487
	RefreshActivityFunPlayRedDot,
	// Token: 0x04002128 RID: 8488
	ActivityFunPlayInfoRefresh,
	// Token: 0x04002129 RID: 8489
	RefreshLineCrossGroupRedDot,
	// Token: 0x0400212A RID: 8490
	RefreshLineCrossChallengeRedDot,
	// Token: 0x0400212B RID: 8491
	MoonSignRewardRefresh,
	// Token: 0x0400212C RID: 8492
	SeekTraceMoveActionInput,
	// Token: 0x0400212D RID: 8493
	SeekTraceMoveAxisInput,
	// Token: 0x0400212E RID: 8494
	SeekTraceSelectItemInput,
	// Token: 0x0400212F RID: 8495
	SeekTraceResetItemInput,
	// Token: 0x04002130 RID: 8496
	OnOnlyAllowFightInputStateChanged,
	// Token: 0x04002131 RID: 8497
	OnVisionIntensifyViewShow,
	// Token: 0x04002132 RID: 8498
	VersionCheckRefresh,
	// Token: 0x04002133 RID: 8499
	CheckMusicBeatsEvent,
	// Token: 0x04002134 RID: 8500
	OnVisionRecommendFetterGroupSelected,
	// Token: 0x04002135 RID: 8501
	RoleDevTargetRoleIdChange,
	// Token: 0x04002136 RID: 8502
	RoleDevelopNeedItemsChanged,
	// Token: 0x04002137 RID: 8503
	OnRoleDevViewOpen,
	// Token: 0x04002138 RID: 8504
	BtnStateUpdate,
	// Token: 0x04002139 RID: 8505
	OnArtemisStateRefresh,
	// Token: 0x0400213A RID: 8506
	OnArtemisQteAreaChange,
	// Token: 0x0400213B RID: 8507
	SurvivorsRogueShowBonusWaveTips,
	// Token: 0x0400213C RID: 8508
	SurvivorsRogueShowEndlessWaveTips,
	// Token: 0x0400213D RID: 8509
	SurvivorsRogueSwitchWaveTipsState,
	// Token: 0x0400213E RID: 8510
	SurvivorsRebindCommandView,
	// Token: 0x0400213F RID: 8511
	SurvivorsRogueWeaponGainUpdate,
	// Token: 0x04002140 RID: 8512
	SurvivorsRogueRoleGainUpdate,
	// Token: 0x04002141 RID: 8513
	SurvivorsRogueBossTrackedMarkerUpdate,
	// Token: 0x04002142 RID: 8514
	SurvivorsRoguePlayerEntityCreated,
	// Token: 0x04002143 RID: 8515
	SurvivorsInstSettle,
	// Token: 0x04002144 RID: 8516
	SurvivorsRogueTalentNodeUpdate,
	// Token: 0x04002145 RID: 8517
	SurvivorsRogueLevelDetailViewEndlessToggleRefresh,
	// Token: 0x04002146 RID: 8518
	SurvivorsRogueComboBuffShow,
	// Token: 0x04002147 RID: 8519
	SurvivorsRoguePopViewRefresh,
	// Token: 0x04002148 RID: 8520
	SurvivorsRogueWeaponDetailTabViewShow,
	// Token: 0x04002149 RID: 8521
	QuestTreeNodeDataUpdate,
	// Token: 0x0400214A RID: 8522
	RegionalTerminalGameplayPinUpdate,
	// Token: 0x0400214B RID: 8523
	AreaMapGroupIdChanged,
	// Token: 0x0400214C RID: 8524
	AnimCompActiveStateChange,
	// Token: 0x0400214D RID: 8525
	OnPrizeDrawingRewardStatusChanged,
	// Token: 0x0400214E RID: 8526
	OnPrizeDrawingQuestUpdated,
	// Token: 0x0400214F RID: 8527
	OnHonamiStoryLifeSupportChanged,
	// Token: 0x04002150 RID: 8528
	OnHonamiStoryRoleEquipChanged,
	// Token: 0x04002151 RID: 8529
	OnHonamiScanMarkItemView,
	// Token: 0x04002152 RID: 8530
	OnPickUpHonamiStoryItem,
	// Token: 0x04002153 RID: 8531
	PlayerEntityStarted,
	// Token: 0x04002154 RID: 8532
	PlayerEntityEnded,
	// Token: 0x04002155 RID: 8533
	OnMarkItemAutoPilotTrackStateChange,
	// Token: 0x04002156 RID: 8534
	OnAutoPilotStateChange,
	// Token: 0x04002157 RID: 8535
	OnCircleStateChange,
	// Token: 0x04002158 RID: 8536
	OnUpdateAutoPilotLine,
	// Token: 0x04002159 RID: 8537
	MovieModeAspectOffsetUpdate,
	// Token: 0x0400215A RID: 8538
	MovieModeAspectOffsetApply,
	// Token: 0x0400215B RID: 8539
	MovieModeHideUiChange,
	// Token: 0x0400215C RID: 8540
	OnPanoramicActive,
	// Token: 0x0400215D RID: 8541
	OnPanoramicDisable,
	// Token: 0x0400215E RID: 8542
	OnActivityNewPlayerSupportTrialRoleItemSelect,
	// Token: 0x0400215F RID: 8543
	OnActivityNewPlayerSupportTaskUpdate,
	// Token: 0x04002160 RID: 8544
	OnActivityNewPlayerSupportTrialRoleUpdate,
	// Token: 0x04002161 RID: 8545
	OnActivityNewPlayerSupportCurTrialRoleChange,
	// Token: 0x04002162 RID: 8546
	InfrastructureFireExpAdd,
	// Token: 0x04002163 RID: 8547
	InfrastructureFireShopRefresh,
	// Token: 0x04002164 RID: 8548
	InfrastructureActivityTaskDataUpdate,
	// Token: 0x04002165 RID: 8549
	InfrastructureArchiveTaskUpdate,
	// Token: 0x04002166 RID: 8550
	InfrastructurePhoneTaskUpdate,
	// Token: 0x04002167 RID: 8551
	InfrastructureRoadNoticeUpdate,
	// Token: 0x04002168 RID: 8552
	InfrastructureArchiveReadUpdate,
	// Token: 0x04002169 RID: 8553
	InfrastructureTraceRoadUpdate,
	// Token: 0x0400216A RID: 8554
	InfrastructureSelectRoadNetworkMark,
	// Token: 0x0400216B RID: 8555
	InfrastructureRoadDataUpdate,
	// Token: 0x0400216C RID: 8556
	InfrastructureShopRedDotUpdate,
	// Token: 0x0400216D RID: 8557
	VillageInfrActivityTaskDataUpdate,
	// Token: 0x0400216E RID: 8558
	VillageInfrTreeDataUpdate,
	// Token: 0x0400216F RID: 8559
	VillageInfrVillageDataUpdate,
	// Token: 0x04002170 RID: 8560
	VillageInfrScoreRewardDataUpdate,
	// Token: 0x04002171 RID: 8561
	VillageInfrTreeFinishCondDataUpdate,
	// Token: 0x04002172 RID: 8562
	VillageDeliverySuccess,
	// Token: 0x04002173 RID: 8563
	VillageCompleteDelivery,
	// Token: 0x04002174 RID: 8564
	VillageInfrMainViewOnSelect,
	// Token: 0x04002175 RID: 8565
	CloseVillageInfrBuildInfoView,
	// Token: 0x04002176 RID: 8566
	VillageInfrMissionItemClick,
	// Token: 0x04002177 RID: 8567
	MotorDevelopRootUpdate,
	// Token: 0x04002178 RID: 8568
	MotorDevelopInfoUpdate,
	// Token: 0x04002179 RID: 8569
	MotorDevelopTechTreeUpdate,
	// Token: 0x0400217A RID: 8570
	MotorDevelopTaskUpdate,
	// Token: 0x0400217B RID: 8571
	SelectMotorDevelopTab,
	// Token: 0x0400217C RID: 8572
	MotorDiyInfoUpdate,
	// Token: 0x0400217D RID: 8573
	MotorDiyFullOutlookUpdate,
	// Token: 0x0400217E RID: 8574
	MotorDiyOnSelectToggleClick,
	// Token: 0x0400217F RID: 8575
	MotorDiySceneItemUpdate,
	// Token: 0x04002180 RID: 8576
	MotorParkourFinishLap,
	// Token: 0x04002181 RID: 8577
	OnMotorSwitchMusic,
	// Token: 0x04002182 RID: 8578
	OnMotorMusicEnableStateChanged,
	// Token: 0x04002183 RID: 8579
	OnMotorMusicSortDragCancel,
	// Token: 0x04002184 RID: 8580
	OnMotorMusicPlayerShow,
	// Token: 0x04002185 RID: 8581
	OnMotorMusicForceRefresh,
	// Token: 0x04002186 RID: 8582
	OnPhoneMsgUpdateNotify,
	// Token: 0x04002187 RID: 8583
	OnUpdateShortMsgOptionData,
	// Token: 0x04002188 RID: 8584
	OnNewPhoneMsgNeedShowTips,
	// Token: 0x04002189 RID: 8585
	OnPhoneMsgChatShowChange,
	// Token: 0x0400218A RID: 8586
	OnPhoneMsgChatTabClick,
	// Token: 0x0400218B RID: 8587
	OnPhoneMsgDialogShowClick,
	// Token: 0x0400218C RID: 8588
	OnPhoneMsgBgShowClick,
	// Token: 0x0400218D RID: 8589
	OnPhoneMsgReadProgressUpdate,
	// Token: 0x0400218E RID: 8590
	OnPhoneMsgSetAsRead,
	// Token: 0x0400218F RID: 8591
	OnPhoneMsgSetReceived,
	// Token: 0x04002190 RID: 8592
	OnPhoneTipsClose,
	// Token: 0x04002191 RID: 8593
	PhoneMsgDialogBgThemeCharmUpdate,
	// Token: 0x04002192 RID: 8594
	PhoneMsgDialogBgThemeCharmRedDotUpdate,
	// Token: 0x04002193 RID: 8595
	OnWeatherCentralRedDotUpdate,
	// Token: 0x04002194 RID: 8596
	RoadBookTaskRefresh,
	// Token: 0x04002195 RID: 8597
	RoadBookMotorRefresh,
	// Token: 0x04002196 RID: 8598
	RoadBookTaskNavigationNext,
	// Token: 0x04002197 RID: 8599
	WheelTowerCycleChange,
	// Token: 0x04002198 RID: 8600
	GuessJokerCardUpdateTaskData,
	// Token: 0x04002199 RID: 8601
	GuessJokerFinishPokerPerformAction,
	// Token: 0x0400219A RID: 8602
	EncircleMapChange,
	// Token: 0x0400219B RID: 8603
	EncircleReset,
	// Token: 0x0400219C RID: 8604
	EncircleDataUpdate,
	// Token: 0x0400219D RID: 8605
	MotorArrowInitBoss,
	// Token: 0x0400219E RID: 8606
	MotorArrowSubLevelNotify,
	// Token: 0x0400219F RID: 8607
	MotorArrowBossStateChange,
	// Token: 0x040021A0 RID: 8608
	MotorArrowBossCreate,
	// Token: 0x040021A1 RID: 8609
	MotorArrowBossRemove,
	// Token: 0x040021A2 RID: 8610
	MotorArrowScoreUpdate,
	// Token: 0x040021A3 RID: 8611
	MotorArrowBossHpChange,
	// Token: 0x040021A4 RID: 8612
	MotorArrowSave,
	// Token: 0x040021A5 RID: 8613
	MotorArrowGameOver,
	// Token: 0x040021A6 RID: 8614
	SpringManorFunctionOpenNotify,
	// Token: 0x040021A7 RID: 8615
	SpringManorTaskUpdateNotify,
	// Token: 0x040021A8 RID: 8616
	SpringManorAtmosphereUpdate,
	// Token: 0x040021A9 RID: 8617
	FurnitureFunctionOpenNotify,
	// Token: 0x040021AA RID: 8618
	OnCoopLevelUpdate,
	// Token: 0x040021AB RID: 8619
	OnCoopSpUpdate,
	// Token: 0x040021AC RID: 8620
	OnCoopLevelToggleClick,
	// Token: 0x040021AD RID: 8621
	OnPinballRoleLevelUp,
	// Token: 0x040021AE RID: 8622
	OnPinballRoleStateChange,
	// Token: 0x040021AF RID: 8623
	OnPinballEntityHpChanged,
	// Token: 0x040021B0 RID: 8624
	OnPinballFirstLaunch,
	// Token: 0x040021B1 RID: 8625
	OnPinballFeverChange,
	// Token: 0x040021B2 RID: 8626
	OnPinballScoreChanged,
	// Token: 0x040021B3 RID: 8627
	OnPinballComboChanged,
	// Token: 0x040021B4 RID: 8628
	OnPinballRoleChargeMax,
	// Token: 0x040021B5 RID: 8629
	OnPinballRoleUseSkill,
	// Token: 0x040021B6 RID: 8630
	OnPinballEntityCreated,
	// Token: 0x040021B7 RID: 8631
	OnPinballWeaponLockChanged,
	// Token: 0x040021B8 RID: 8632
	RefreshPinballRoleRedDot,
	// Token: 0x040021B9 RID: 8633
	OnPinballBattleViewSwitchIn,
	// Token: 0x040021BA RID: 8634
	RefreshPinballWeaponRedDot,
	// Token: 0x040021BB RID: 8635
	OnRefreshKurotatoRoleRedDot,
	// Token: 0x040021BC RID: 8636
	OnRefreshKurotatoWeaponAndPropRedDot,
	// Token: 0x040021BD RID: 8637
	OnRefreshKurotatoNormalRewardData,
	// Token: 0x040021BE RID: 8638
	OnRefreshKurotatoLimitRewardData,
	// Token: 0x040021BF RID: 8639
	RoleTowerInfoUpdate,
	// Token: 0x040021C0 RID: 8640
	RoleTowerLevelUpdate,
	// Token: 0x040021C1 RID: 8641
	RoleTowerLevelSelectUpdate,
	// Token: 0x040021C2 RID: 8642
	RoleTowerRewardReceive,
	// Token: 0x040021C3 RID: 8643
	RoleTowerRankUpdate,
	// Token: 0x040021C4 RID: 8644
	RoleTowerBattleTimeUpdate,
	// Token: 0x040021C5 RID: 8645
	RoleTowerBattleTimeDeltaUpdate,
	// Token: 0x040021C6 RID: 8646
	RoleTowerBattleWaveUpdate,
	// Token: 0x040021C7 RID: 8647
	RoleTowerItemUpdate,
	// Token: 0x040021C8 RID: 8648
	OnNpcBeenAttackedStart,
	// Token: 0x040021C9 RID: 8649
	OnNpcBeenAttackedEnd,
	// Token: 0x040021CA RID: 8650
	OnNpcBeenImpactedStart,
	// Token: 0x040021CB RID: 8651
	OnNpcBeenImpactedEnd,
	// Token: 0x040021CC RID: 8652
	OnNpcSwitchTimetable,
	// Token: 0x040021CD RID: 8653
	OnNpcStopTimetable,
	// Token: 0x040021CE RID: 8654
	OnTsBasePlayerControllerReceiveSetupInputComponent,
	// Token: 0x040021CF RID: 8655
	OnTsBasePlayerControllerReceiveBeginPlay,
	// Token: 0x040021D0 RID: 8656
	OnTsBasePlayerControllerReceiveDestroyed,
	// Token: 0x040021D1 RID: 8657
	OnTsBasePlayerControllerReceiveTick,
	// Token: 0x040021D2 RID: 8658
	OnTsBasePlayerControllerReceivedPlayer,
	// Token: 0x040021D3 RID: 8659
	OnTsBasePlayerControllerInitInputHandle,
	// Token: 0x040021D4 RID: 8660
	OnTsBasePlayerControllerAddInputBinding,
	// Token: 0x040021D5 RID: 8661
	OnTsBasePlayerControllerClearInputBinding,
	// Token: 0x040021D6 RID: 8662
	OnTsBasePlayerControllerOnSetupInputComponent,
	// Token: 0x040021D7 RID: 8663
	OnTsBasePlayerControllerBindTouchHandle,
	// Token: 0x040021D8 RID: 8664
	OnTsBasePlayerControllerInputAction,
	// Token: 0x040021D9 RID: 8665
	OnTsBasePlayerControllerInputAxis,
	// Token: 0x040021DA RID: 8666
	OnTsBasePlayerControllerOnTouchBegin,
	// Token: 0x040021DB RID: 8667
	OnTsBasePlayerControllerOnTouchEnd,
	// Token: 0x040021DC RID: 8668
	OnTsBasePlayerControllerOnTouchMove,
	// Token: 0x040021DD RID: 8669
	OnTsBasePlayerControllerOnPressAnyKey,
	// Token: 0x040021DE RID: 8670
	OnTsBasePlayerControllerOnReleaseAnyKey,
	// Token: 0x040021DF RID: 8671
	OnTsBasePlayerControllerRemoveActionHandle,
	// Token: 0x040021E0 RID: 8672
	OnTsBasePlayerControllerGetActionHandle,
	// Token: 0x040021E1 RID: 8673
	OnTsBasePlayerControllerRemoveAxisHandle,
	// Token: 0x040021E2 RID: 8674
	OnTsBasePlayerControllerGetAxisHandle,
	// Token: 0x040021E3 RID: 8675
	OnTsBasePlayerControllerIsInTouch,
	// Token: 0x040021E4 RID: 8676
	OnTsBasePlayerControllerSetIsPrintKeyName,
	// Token: 0x040021E5 RID: 8677
	OnTsBasePlayerControllerTouchBegin,
	// Token: 0x040021E6 RID: 8678
	OnTsBasePlayerControllerTouchEnd,
	// Token: 0x040021E7 RID: 8679
	OnTsBasePlayerControllerTouchMove,
	// Token: 0x040021E8 RID: 8680
	OnTsBasePlayerControllerPressAnyKey,
	// Token: 0x040021E9 RID: 8681
	OnTsBasePlayerControllerReleaseAnyKey,
	// Token: 0x040021EA RID: 8682
	OnTsCharacterControllerReceiveBeginPlay,
	// Token: 0x040021EB RID: 8683
	OnTsCharacterControllerReceiveDestroyed,
	// Token: 0x040021EC RID: 8684
	OnTsCharacterControllerReceivePossess,
	// Token: 0x040021ED RID: 8685
	OnTsCharacterControllerReceiveUnPossess,
	// Token: 0x040021EE RID: 8686
	OnTsCharacterControllerOnSetupInputComponent,
	// Token: 0x040021EF RID: 8687
	OnTsCharacterControllerReceivePreProcessInput,
	// Token: 0x040021F0 RID: 8688
	OnTsCharacterControllerReceivePostProcessInput,
	// Token: 0x040021F1 RID: 8689
	OnTsCharacterControllerSetUiRootActive,
	// Token: 0x040021F2 RID: 8690
	OnTsCharacterControllerSetUiRootDeactivate,
	// Token: 0x040021F3 RID: 8691
	OnTsUiManagerInit,
	// Token: 0x040021F4 RID: 8692
	OnTsLayerInit,
	// Token: 0x040021F5 RID: 8693
	OnTsLguiEventSystemInit,
	// Token: 0x040021F6 RID: 8694
	OpenViewRedirectToCs,
	// Token: 0x040021F7 RID: 8695
	CloseViewRedirectToCs,
	// Token: 0x040021F8 RID: 8696
	OpenViewRedirectToTs,
	// Token: 0x040021F9 RID: 8697
	CloseViewRedirectToTs,
	// Token: 0x040021FA RID: 8698
	HideViewRedirectToTs,
	// Token: 0x040021FB RID: 8699
	CloseAndOpenRedirectToTs,
	// Token: 0x040021FC RID: 8700
	CloseAndOpenRedirectToCs,
	// Token: 0x040021FD RID: 8701
	PreOpenViewAsyncRedirectToCs,
	// Token: 0x040021FE RID: 8702
	PreOpenViewAsyncRedirectToTs,
	// Token: 0x040021FF RID: 8703
	OpenViewAfterPreOpenedAsyncToCs,
	// Token: 0x04002200 RID: 8704
	OpenViewAfterPreOpenedAsyncToTs,
	// Token: 0x04002201 RID: 8705
	TsNotifyCsViewOnCreateAsync,
	// Token: 0x04002202 RID: 8706
	TsNotifyCsBeforeStartAsync,
	// Token: 0x04002203 RID: 8707
	TsNotifyCsOnBeforeHideAsync,
	// Token: 0x04002204 RID: 8708
	TsNotifyCsOnPlayingStartSequenceAsync,
	// Token: 0x04002205 RID: 8709
	TsNotifyCsOnPlayingCloseSequenceAsync,
	// Token: 0x04002206 RID: 8710
	TsNotifyCsOnBeforeShowAsyncImplementImplement,
	// Token: 0x04002207 RID: 8711
	CsNotifyTsViewOnCreateAsync,
	// Token: 0x04002208 RID: 8712
	CsNotifyTsBeforeStartAsync,
	// Token: 0x04002209 RID: 8713
	CsNotifyTsOnBeforeHideAsync,
	// Token: 0x0400220A RID: 8714
	CsNotifyTsOnPlayingStartSequenceAsync,
	// Token: 0x0400220B RID: 8715
	CsNotifyTsOnPlayingCloseSequenceAsync,
	// Token: 0x0400220C RID: 8716
	CsNotifyTsOnBeforeShowAsyncImplementImplement,
	// Token: 0x0400220D RID: 8717
	NotifyCsOnNetReceiveResponse,
	// Token: 0x0400220E RID: 8718
	NotifyCsOnNetReceiveException,
	// Token: 0x0400220F RID: 8719
	NotifyCsOnNetReceiveTcpException,
	// Token: 0x04002210 RID: 8720
	NotifyCsOnNetReceivePush,
	// Token: 0x04002211 RID: 8721
	NotifyCsOnNetKcpConnectSuccess,
	// Token: 0x04002212 RID: 8722
	NotifyCsOnNetError,
	// Token: 0x04002213 RID: 8723
	NotifyCsCleanNetMessageCaches,
	// Token: 0x04002214 RID: 8724
	CsNetCall,
	// Token: 0x04002215 RID: 8725
	CsNotifyTsOpenWorldMapView,
	// Token: 0x04002216 RID: 8726
	CsNotifyTsTrackQuest,
	// Token: 0x04002217 RID: 8727
	TsNotifyCsTrackQuestResponse,
	// Token: 0x04002218 RID: 8728
	CsNotifyTsQuestTreeGotoQuest,
	// Token: 0x04002219 RID: 8729
	CsNotifyInfoSwitchInputControllerType,
	// Token: 0x0400221A RID: 8730
	CsNotifyTsUiNavigationBehaviorListenerAwakeBP,
	// Token: 0x0400221B RID: 8731
	CsNotifyTsUiNavigationBehaviorListenerStartBP,
	// Token: 0x0400221C RID: 8732
	CsNotifyTsUiNavigationBehaviorListenerOnNotifyNavigationEnterBP,
	// Token: 0x0400221D RID: 8733
	CsNotifyTsUiNavigationBehaviorListenerOnNotifyNavigationSelectBP,
	// Token: 0x0400221E RID: 8734
	CsNotifyTsUiNavigationBehaviorListenerOnEnableBP,
	// Token: 0x0400221F RID: 8735
	CsNotifyTsUiNavigationBehaviorListenerOnDisableBP,
	// Token: 0x04002220 RID: 8736
	CsNotifyTsUiNavigationBehaviorListenerOnNotifyInteractiveBP,
	// Token: 0x04002221 RID: 8737
	CsNotifyTsUiNavigationBehaviorListenerOnNotifyNotInteractiveBP,
	// Token: 0x04002222 RID: 8738
	CsNotifyTsUiNavigationBehaviorListenerOnDestroyBP,
	// Token: 0x04002223 RID: 8739
	CsNotifyTsUiNavigationBehaviorListenerOnCheckCanSetNavigationBP,
	// Token: 0x04002224 RID: 8740
	CsNotifyTsUiNavigationBehaviorListenerOnCheckLoopScrollChangeNavigationBP,
	// Token: 0x04002225 RID: 8741
	CsNotifyTsUiNavigationPanelConfigAwakeBP,
	// Token: 0x04002226 RID: 8742
	CsNotifyTsUiNavigationPanelConfigStartBP,
	// Token: 0x04002227 RID: 8743
	CsNotifyTsUiNavigationPanelConfigOnEnableBP,
	// Token: 0x04002228 RID: 8744
	CsNotifyTsUiNavigationPanelConfigOnDisableBP,
	// Token: 0x04002229 RID: 8745
	CsNotifyTsUiNavigationPanelConfigOnDestroyBP,
	// Token: 0x0400222A RID: 8746
	CsNotifyTsLguiEventSystemActorInputTrigger,
	// Token: 0x0400222B RID: 8747
	CsNotifyTsLguiEventSystemActorInputNavigation,
	// Token: 0x0400222C RID: 8748
	CsNotifyTsLguiEventSystemActorInputTriggerForNavigation,
	// Token: 0x0400222D RID: 8749
	CsNotifyTsLguiEventSystemActorInputScroll,
	// Token: 0x0400222E RID: 8750
	CsNotifyTsLguiEventSystemActorInputTouchTrigger,
	// Token: 0x0400222F RID: 8751
	CsNotifyTsLguiEventSystemActorInputTouchMove,
	// Token: 0x04002230 RID: 8752
	CsNotifyTsLguiEventSystemActorSetClickThresholdWithInputKeyType,
	// Token: 0x04002231 RID: 8753
	CsNotifyTsLguiEventSystemActorGetNowHitComponent,
	// Token: 0x04002232 RID: 8754
	CsNotifyTsLguiEventSystemActorGetPointerEventData,
	// Token: 0x04002233 RID: 8755
	CsNotifyTsLguiEventSystemActorIsPointerEventDataLineTrace,
	// Token: 0x04002234 RID: 8756
	CsNotifyTsUiBlurSetEnableUiBlur,
	// Token: 0x04002235 RID: 8757
	CsNotifyTsUiHotKeyActorComponentAwakeBP,
	// Token: 0x04002236 RID: 8758
	CsNotifyTsUiHotKeyActorComponentStartBP,
	// Token: 0x04002237 RID: 8759
	CsNotifyTsUiHotKeyActorComponentOnEnableBP,
	// Token: 0x04002238 RID: 8760
	CsNotifyTsUiHotKeyActorComponentOnDisableBP,
	// Token: 0x04002239 RID: 8761
	CsNotifyTsUiHotKeyActorComponentOnDestroyBP,
	// Token: 0x0400223A RID: 8762
	CsNotifyTsUiNavigationTextChangeListenerAwakeBP,
	// Token: 0x0400223B RID: 8763
	CsNotifyTsUiNavigationTextChangeListenerStartBP,
	// Token: 0x0400223C RID: 8764
	CsNotifyTsUiNavigationTextChangeListenerOnNotifyTextChangeBP,
	// Token: 0x0400223D RID: 8765
	CsNotifyTsUiNavigationPlatformChangeListenerAwakeBP,
	// Token: 0x0400223E RID: 8766
	CsNotifyTsUiNavigationPlatformChangeListenerOnDestroyBP,
	// Token: 0x0400223F RID: 8767
	CsRequestTsOpenView,
	// Token: 0x04002240 RID: 8768
	TsWorldDone,
	// Token: 0x04002241 RID: 8769
	TsReconnectClearData,
	// Token: 0x04002242 RID: 8770
	TsOnPreEndPIE,
	// Token: 0x04002243 RID: 8771
	CsNotifyUiNavigationNewControllerSetNavigationFocusForView,
	// Token: 0x04002244 RID: 8772
	TsActiveBattleView,
	// Token: 0x04002245 RID: 8773
	ResetToViewRedirectToTs,
	// Token: 0x04002246 RID: 8774
	ResetToViewRedirectToCs,
	// Token: 0x04002247 RID: 8775
	CsNotifyTsAddBlackScreen,
	// Token: 0x04002248 RID: 8776
	CsNotifyTsRemoveBlackScreen,
	// Token: 0x04002249 RID: 8777
	TsNotifyCsAddBlackScreenFinish,
	// Token: 0x0400224A RID: 8778
	CsRequestTsHandleQuestTreeNode,
	// Token: 0x0400224B RID: 8779
	TsHandleQuestTreeNodeResponse,
	// Token: 0x0400224C RID: 8780
	TsClearSceneBegin,
	// Token: 0x0400224D RID: 8781
	TsAfterLoadMap,
	// Token: 0x0400224E RID: 8782
	TsSyncSetServerId,
	// Token: 0x0400224F RID: 8783
	CsNotifyShowTips,
	// Token: 0x04002250 RID: 8784
	CsRequestSelectMail,
	// Token: 0x04002251 RID: 8785
	CsRequestPickMailAttachment,
	// Token: 0x04002252 RID: 8786
	CsRequestDeleteMail,
	// Token: 0x04002253 RID: 8787
	TsOnReadMailResponse,
	// Token: 0x04002254 RID: 8788
	TsOnPickMailAttachmentResponse,
	// Token: 0x04002255 RID: 8789
	TsOnDeleteMailResponse,
	// Token: 0x04002256 RID: 8790
	CsRequestOpenSdkExternalUrl,
	// Token: 0x04002257 RID: 8791
	CsRequestOpenSdkUrlWnd,
	// Token: 0x04002258 RID: 8792
	CsRequestSyncTsTimeModelParam,
	// Token: 0x04002259 RID: 8793
	TsResponseSyncToCsTimeModelParam,
	// Token: 0x0400225A RID: 8794
	CsRequestSyncServerGameTime,
	// Token: 0x0400225B RID: 8795
	TsResponseSyncServerGameTime,
	// Token: 0x0400225C RID: 8796
	CsRequestAdjustTime,
	// Token: 0x0400225D RID: 8797
	TsRequestAdjustTime,
	// Token: 0x0400225E RID: 8798
	CsRequestLockTimeRunStateClient,
	// Token: 0x0400225F RID: 8799
	TsRequestLockTimeRunStateClient,
	// Token: 0x04002260 RID: 8800
	CsRequestLockTimeSyncLockStateClient,
	// Token: 0x04002261 RID: 8801
	TsRequestLockTimeSyncLockStateClient,
	// Token: 0x04002262 RID: 8802
	CsRequestSetTimeScale,
	// Token: 0x04002263 RID: 8803
	TsRequestSetTimeScale,
	// Token: 0x04002264 RID: 8804
	CsRequestTimeCanOpenViewState,
	// Token: 0x04002265 RID: 8805
	TsResponseTimeCanOpenViewState,
	// Token: 0x04002266 RID: 8806
	TsOnTimeEnterGame,
	// Token: 0x04002267 RID: 8807
	TsOnTimeBeforeLoadMap,
	// Token: 0x04002268 RID: 8808
	TsOnTimeWorldDone,
	// Token: 0x04002269 RID: 8809
	TsSyncUseClientLockState,
	// Token: 0x0400226A RID: 8810
	TsNotifyLevelSequencePlayerBannedState,
	// Token: 0x0400226B RID: 8811
	CsNotifyOpenHelpView,
	// Token: 0x0400226C RID: 8812
	TsNotifyQuestTrackState,
	// Token: 0x0400226D RID: 8813
	NotifyCsLocalStorageInit,
	// Token: 0x0400226E RID: 8814
	CsSyncItemTipsData,
	// Token: 0x0400226F RID: 8815
	CsRequestOpenFunctionRelateView,
	// Token: 0x04002270 RID: 8816
	TsSyncTickPauseState,
	// Token: 0x04002271 RID: 8817
	TsSyncSceneTime,
	// Token: 0x04002272 RID: 8818
	TsOnRequestFriendInfoResponse,
	// Token: 0x04002273 RID: 8819
	CsRequestFriendHandle,
	// Token: 0x04002274 RID: 8820
	CsRequestChangeFriendRemark,
	// Token: 0x04002275 RID: 8821
	CsRequestFriendDelete,
	// Token: 0x04002276 RID: 8822
	CsRequestFriendApplicationDelete,
	// Token: 0x04002277 RID: 8823
	TsSyncInstanceType,
	// Token: 0x04002278 RID: 8824
	TsSyncHeadInfo,
	// Token: 0x04002279 RID: 8825
	CsSyncSelectedPlayerId,
	// Token: 0x0400227A RID: 8826
	CsSyncFriendShowingView,
	// Token: 0x0400227B RID: 8827
	CsSyncFriendFilterState,
	// Token: 0x0400227C RID: 8828
	CsRequestLookCard,
	// Token: 0x0400227D RID: 8829
	CsRequestAddMutePlayer,
	// Token: 0x0400227E RID: 8830
	CsRequestRemoveMutePlayer,
	// Token: 0x0400227F RID: 8831
	CsSyncRequestSearchData,
	// Token: 0x04002280 RID: 8832
	TsSyncResponseSearchBasicData,
	// Token: 0x04002281 RID: 8833
	TsSyncResponseSearchSdkData,
	// Token: 0x04002282 RID: 8834
	CsRequestBlockData,
	// Token: 0x04002283 RID: 8835
	TsResponseBlockData,
	// Token: 0x04002284 RID: 8836
	CsRequestFriendRecentlyTeam,
	// Token: 0x04002285 RID: 8837
	TsResponseFriendRecentlyTeam,
	// Token: 0x04002286 RID: 8838
	CsSyncCachePlayerData,
	// Token: 0x04002287 RID: 8839
	CsRequestReportPlayer,
	// Token: 0x04002288 RID: 8840
	CsRequestShowFriendPromptCode,
	// Token: 0x04002289 RID: 8841
	CsRequestChatOption,
	// Token: 0x0400228A RID: 8842
	CsRequestJoinWorld,
	// Token: 0x0400228B RID: 8843
	TsSyncBirthdayResetState,
	// Token: 0x0400228C RID: 8844
	CsRequestSdkBlockingUserData,
	// Token: 0x0400228D RID: 8845
	TsResponseSdkBlockingUserData,
	// Token: 0x0400228E RID: 8846
	CsRequestSdkTargetRelationData,
	// Token: 0x0400228F RID: 8847
	TsResponseSdkTargetRelationData,
	// Token: 0x04002290 RID: 8848
	CsRequestCommunicationRestricted,
	// Token: 0x04002291 RID: 8849
	TsResponseCommunicationRestricted,
	// Token: 0x04002292 RID: 8850
	CsRequestCommunicationRestrictedSync,
	// Token: 0x04002293 RID: 8851
	TsResponseCommunicationRestrictedSync,
	// Token: 0x04002294 RID: 8852
	CsRequestSdkPlayOnlyState,
	// Token: 0x04002295 RID: 8853
	TsResponseSdkPlayOnlyState,
	// Token: 0x04002296 RID: 8854
	CsRequestSdkFriendOnlyState,
	// Token: 0x04002297 RID: 8855
	TsResponseSdkFriendOnlyState,
	// Token: 0x04002298 RID: 8856
	CsRequestSaveSdkFriendOnlyState,
	// Token: 0x04002299 RID: 8857
	TsSyncAddMutePlayer,
	// Token: 0x0400229A RID: 8858
	TsSyncRemoveMutePlayer,
	// Token: 0x0400229B RID: 8859
	TsSyncLanguageChange,
	// Token: 0x0400229C RID: 8860
	TsSyncThirdPartyInfo,
	// Token: 0x0400229D RID: 8861
	LoadingPhaseChange,
	// Token: 0x0400229E RID: 8862
	TsSyncChatEnterTeam,
	// Token: 0x0400229F RID: 8863
	TsSyncChatLeaveTeam,
	// Token: 0x040022A0 RID: 8864
	TsSyncChatEnterOnlineWorld,
	// Token: 0x040022A1 RID: 8865
	TsSyncChatLeaveOnlineWorld,
	// Token: 0x040022A2 RID: 8866
	CsRequestChangePlayerRemark,
	// Token: 0x040022A3 RID: 8867
	TsSyncChangePlayerRemark,
	// Token: 0x040022A4 RID: 8868
	TsSyncTime,
	// Token: 0x040022A5 RID: 8869
	TsActivityCreateSubView,
	// Token: 0x040022A6 RID: 8870
	TsActivityBeforeShowSelfAsync,
	// Token: 0x040022A7 RID: 8871
	TsActivityBeforeHideSelfAsync,
	// Token: 0x040022A8 RID: 8872
	TsActivityOnDestroy,
	// Token: 0x040022A9 RID: 8873
	TsActivitySetActive,
	// Token: 0x040022AA RID: 8874
	TsActivityOnCommonViewStateChange,
	// Token: 0x040022AB RID: 8875
	TsActivityRefreshView,
	// Token: 0x040022AC RID: 8876
	TsActivityPlaySubViewSequence,
	// Token: 0x040022AD RID: 8877
	CsNotifyTsActivityOnCreateAsync,
	// Token: 0x040022AE RID: 8878
	CsNotifyTsActivityBeforeShowSelfAsync,
	// Token: 0x040022AF RID: 8879
	CsNotifyTsActivityBeforeHideSelfAsync,
	// Token: 0x040022B0 RID: 8880
	CsMemoryFragmentMainViewRequestScreenshot,
	// Token: 0x040022B1 RID: 8881
	CsRequestShowWorldLevelUpEffect,
	// Token: 0x040022B2 RID: 8882
	CsRequestDestroyWorldLevelUpEffect,
	// Token: 0x040022B3 RID: 8883
	CsRequestWorldLevelChangeInFight,
	// Token: 0x040022B4 RID: 8884
	TsResponseWorldLevelChangeInFight,
	// Token: 0x040022B5 RID: 8885
	CsRequestDownWorldLevel,
	// Token: 0x040022B6 RID: 8886
	CsRequestRegainWorldLevel,
	// Token: 0x040022B7 RID: 8887
	TsSyncWorldLevelChangeEvent,
	// Token: 0x040022B8 RID: 8888
	TsSyncOriginWorldLevelUpEvent,
	// Token: 0x040022B9 RID: 8889
	TsSyncAchievementFinish,
	// Token: 0x040022BA RID: 8890
	OnRefreshSubPackageDownLoadByPriority,
	// Token: 0x040022BB RID: 8891
	OnRefreshSubPackDownLoadState,
	// Token: 0x040022BC RID: 8892
	OnRefreshSubPackUseCellData,
	// Token: 0x040022BD RID: 8893
	OnRefreshSubPackClearData,
	// Token: 0x040022BE RID: 8894
	OnHookPointStateChanged,
	// Token: 0x040022BF RID: 8895
	OnSunSpiritEnableUpdated,
	// Token: 0x040022C0 RID: 8896
	OnSunSpiritOccupiedByPlayerChanged,
	// Token: 0x040022C1 RID: 8897
	OnSunSpiritOccupiedByGearChanged,
	// Token: 0x040022C2 RID: 8898
	OnSunSpiritLauncherWatchSelectedChanged,
	// Token: 0x040022C3 RID: 8899
	ShowRollBlockTips,
	// Token: 0x040022C4 RID: 8900
	RollBlockAllCompleted,
	// Token: 0x040022C5 RID: 8901
	OnRollBlockReseting,
	// Token: 0x040022C6 RID: 8902
	OnRollBlockDifficultyChanged,
	// Token: 0x040022C7 RID: 8903
	PhantomInteractEditGridRefresh,
	// Token: 0x040022C8 RID: 8904
	PhantomInteractNewUnlock,
	// Token: 0x040022C9 RID: 8905
	MonsterDebug,
	// Token: 0x040022CA RID: 8906
	OnEnableCrowdAiSystem,
	// Token: 0x040022CB RID: 8907
	MotorInMovieModeChange,
	// Token: 0x040022CC RID: 8908
	MotorSubStateModeChange,
	// Token: 0x040022CD RID: 8909
	MotorOnHit,
	// Token: 0x040022CE RID: 8910
	EnableGrapplingHookMark,
	// Token: 0x040022CF RID: 8911
	OnMapCustomMarkPanelShow,
	// Token: 0x040022D0 RID: 8912
	OnPhantomArenaChooseCardPanelShow,
	// Token: 0x040022D1 RID: 8913
	OnPhantomArenaDiscardCardPanelShow,
	// Token: 0x040022D2 RID: 8914
	OnMotorDiyViewShow,
	// Token: 0x040022D3 RID: 8915
	OnPhantomArenaPlayFieldEffect,
	// Token: 0x040022D4 RID: 8916
	MotorDevelopTreeTypeRedDotUpdate,
	// Token: 0x040022D5 RID: 8917
	OnGroupTrialRoleRedDotUpdate,
	// Token: 0x040022D6 RID: 8918
	OnActivityNewPlayerSupportInfoUpdate,
	// Token: 0x040022D7 RID: 8919
	OnActivityNewPlayerSupportEntranceRedDotUpdate,
	// Token: 0x040022D8 RID: 8920
	OnEnterWheelTowerEndlessMode,
	// Token: 0x040022D9 RID: 8921
	MotorDiyInfoRedDotUpdate,
	// Token: 0x040022DA RID: 8922
	OnGuideTriggerEvent,
	// Token: 0x040022DB RID: 8923
	OnSkillButtonAttributeFull,
	// Token: 0x040022DC RID: 8924
	OnEnterOrExitUnopenedArea,
	// Token: 0x040022DD RID: 8925
	OnForbidVehicleInUnopenedArea,
	// Token: 0x040022DE RID: 8926
	OnSetBattleUiChildCacheStateNotify,
	// Token: 0x040022DF RID: 8927
	OnSetBattleUiChildCacheState,
	// Token: 0x040022E0 RID: 8928
	OnPhoneMsgPanelOpen,
	// Token: 0x040022E1 RID: 8929
	OnPhoneMsgAdd,
	// Token: 0x040022E2 RID: 8930
	OnPhoneHaveMsgToRemove,
	// Token: 0x040022E3 RID: 8931
	OnPhoneMsgFilterChanged,
	// Token: 0x040022E4 RID: 8932
	OnTouchUiEditSave,
	// Token: 0x040022E5 RID: 8933
	OnViewShow,
	// Token: 0x040022E6 RID: 8934
	RegressBpExpAnim,
	// Token: 0x040022E7 RID: 8935
	TriggerBreakWeakness,
	// Token: 0x040022E8 RID: 8936
	BreakWeaknessPanelLogicVisibleChange,
	// Token: 0x040022E9 RID: 8937
	LevelPlayRewardDetailUpdate,
	// Token: 0x040022EA RID: 8938
	FeedbackRewardRefresh,
	// Token: 0x040022EB RID: 8939
	InfrastructureFireDataUpdate,
	// Token: 0x040022EC RID: 8940
	OnSceneItemNearbyTrackingEnd,
	// Token: 0x040022ED RID: 8941
	OnBrochureBookItemStateUpdate,
	// Token: 0x040022EE RID: 8942
	MotorDiyInfoPreviewRedDotUpdate,
	// Token: 0x040022EF RID: 8943
	ActivityPayShopGoodsBuy,
	// Token: 0x040022F0 RID: 8944
	OnMotorDevelopTaskUpdate,
	// Token: 0x040022F1 RID: 8945
	OnDrinksUnlockClickedNotify,
	// Token: 0x040022F2 RID: 8946
	OnGuessJokerRedDotNotify,
	// Token: 0x040022F3 RID: 8947
	OnSpringManorGameplayFinish,
	// Token: 0x040022F4 RID: 8948
	OnFurnitureUnlockNotify,
	// Token: 0x040022F5 RID: 8949
	OnFurnitureAreaUnlockNotify,
	// Token: 0x040022F6 RID: 8950
	UpdateFurnitureEntranceRedDot,
	// Token: 0x040022F7 RID: 8951
	OnRoleSkillInputPanelVisible,
	// Token: 0x040022F8 RID: 8952
	OnFlagChallengeTaskUpdate,
	// Token: 0x040022F9 RID: 8953
	OnFlagChallengeBattleActiveChanged,
	// Token: 0x040022FA RID: 8954
	OnFlagChallengeExpChanged,
	// Token: 0x040022FB RID: 8955
	OnFlagChallengeTempExpChanged,
	// Token: 0x040022FC RID: 8956
	OnFlagChallengeTotalLevelChanged,
	// Token: 0x040022FD RID: 8957
	OnFlagChallengeStrongholdOccupied,
	// Token: 0x040022FE RID: 8958
	OnFlagChallengeFixedRoleLevelUpdate,
	// Token: 0x040022FF RID: 8959
	OnFlagChallengeDungeonActiveChanged,
	// Token: 0x04002300 RID: 8960
	OnFlagChallengeLevelNewlyUnlock,
	// Token: 0x04002301 RID: 8961
	OnFlagChallengeBuffNewlyUnlock,
	// Token: 0x04002302 RID: 8962
	OnFlagChallengeBuffNewlyUnlockHintChanged,
	// Token: 0x04002303 RID: 8963
	OnFlagChallengeBattleBuffNewlyUnlock,
	// Token: 0x04002304 RID: 8964
	OnFlagChallengeRoleSelectCategoryUpdate,
	// Token: 0x04002305 RID: 8965
	BattleUiToggleFlagChallengeBuffInfo,
	// Token: 0x04002306 RID: 8966
	OnFlagChallengeUpdateStrongholdData,
	// Token: 0x04002307 RID: 8967
	OnFlagChallengeUpdateLevelData,
	// Token: 0x04002308 RID: 8968
	OrnamentRedDotRefresh,
	// Token: 0x04002309 RID: 8969
	OnOrnamentChange,
	// Token: 0x0400230A RID: 8970
	OnOrnamentUnlock,
	// Token: 0x0400230B RID: 8971
	OnPhantomConfigManagerDataUpdate,
	// Token: 0x0400230C RID: 8972
	OnPayShopConditionFinish,
	// Token: 0x0400230D RID: 8973
	KurotatoOnStepChanged,
	// Token: 0x0400230E RID: 8974
	KurotatoOnUpgradeRewardDataChanged,
	// Token: 0x0400230F RID: 8975
	KurotatoOnChestRewardDataChanged,
	// Token: 0x04002310 RID: 8976
	KurotatoOnShopDataChanged,
	// Token: 0x04002311 RID: 8977
	KurotatoOnItemUpdate,
	// Token: 0x04002312 RID: 8978
	KurotatoOnWeaponUpdate,
	// Token: 0x04002313 RID: 8979
	KurotatoOnWeaponRefined,
	// Token: 0x04002314 RID: 8980
	KurotatoOnRoleSaveStateUpdate,
	// Token: 0x04002315 RID: 8981
	KurotatoEnemyDetailBookGridItemClick,
	// Token: 0x04002316 RID: 8982
	KurotatoPlayerOneHpLeft,
	// Token: 0x04002317 RID: 8983
	KurotatoOnPropertyUpdate,
	// Token: 0x04002318 RID: 8984
	KurotatoBossTrackedMarkerUpdate,
	// Token: 0x04002319 RID: 8985
	KurotatoTreasureBoxTrackedMarkerUpdate,
	// Token: 0x0400231A RID: 8986
	KurotatoOnSystemInfoUpdate,
	// Token: 0x0400231B RID: 8987
	KurotatoOnPlayerDie,
	// Token: 0x0400231C RID: 8988
	KurotatoOnWaveCountDownFinish,
	// Token: 0x0400231D RID: 8989
	KurotatoOnNextWaveTypeUpdate,
	// Token: 0x0400231E RID: 8990
	OnGolemHackingLevelStateUpdate,
	// Token: 0x0400231F RID: 8991
	OnPhantomArenaMapUnlockUpdate,
	// Token: 0x04002320 RID: 8992
	NotifyGuideBreakFocus,
	// Token: 0x04002321 RID: 8993
	OnGuideTriggerResetEvent,
	// Token: 0x04002322 RID: 8994
	OnRhythmShipJumpLevel,
	// Token: 0x04002323 RID: 8995
	OnRhythmShipSelectRoleRefresh,
	// Token: 0x04002324 RID: 8996
	OnRhythmShipTaskRefresh,
	// Token: 0x04002325 RID: 8997
	OnRhythmShipTaskTabRefresh,
	// Token: 0x04002326 RID: 8998
	OnRhythmShipRedDotRefresh,
	// Token: 0x04002327 RID: 8999
	OnRhythmGameNoteResultUpdate,
	// Token: 0x04002328 RID: 9000
	OnRhythmGameFinish,
	// Token: 0x04002329 RID: 9001
	OnRhythmGameFeverModeChanged,
	// Token: 0x0400232A RID: 9002
	OnRhythmGameFeverScoreChanged,
	// Token: 0x0400232B RID: 9003
	OnRhythmGameSpeedLevelConfigIndexChanged,
	// Token: 0x0400232C RID: 9004
	OnRhythmGameStartCoolDown,
	// Token: 0x0400232D RID: 9005
	OnRhythmGameAutoJudgeCountChanged,
	// Token: 0x0400232E RID: 9006
	OnRhythmGameEndCoolDown,
	// Token: 0x0400232F RID: 9007
	OnRhythmGameStartPhase,
	// Token: 0x04002330 RID: 9008
	OnRhythmGameStartNormalPhase,
	// Token: 0x04002331 RID: 9009
	OnRhythmGameEndPhase,
	// Token: 0x04002332 RID: 9010
	OnRhythmGameFreePhase,
	// Token: 0x04002333 RID: 9011
	DropCatchActivityRewardUpdate,
	// Token: 0x04002334 RID: 9012
	OnAutoPilotTrackMarkVisibleChanged,
	// Token: 0x04002335 RID: 9013
	OnArcadeGameplayFinish,
	// Token: 0x04002336 RID: 9014
	OnTetrisChallengeStateUpdate,
	// Token: 0x04002337 RID: 9015
	OnMatchThreeChallengeStateUpdate,
	// Token: 0x04002338 RID: 9016
	OnMatchThreeBoardSettled,
	// Token: 0x04002339 RID: 9017
	OnMatchThreeRoleNewRedDotUpdate,
	// Token: 0x0400233A RID: 9018
	MatchThreeSwapPieceInput,
	// Token: 0x0400233B RID: 9019
	OnTetrisScoreChanged,
	// Token: 0x0400233C RID: 9020
	OnTetrisDragCancel,
	// Token: 0x0400233D RID: 9021
	OnFlagChallengeCalculatedLevelUpdate,
	// Token: 0x0400233E RID: 9022
	OnBeforeOpenLoginView,
	// Token: 0x0400233F RID: 9023
	OnEntitySelfDirectionUpdate,
	// Token: 0x04002340 RID: 9024
	OnSceneItemElementalFieldSnapshotChange,
	// Token: 0x04002341 RID: 9025
	OnSceneItemElementalFieldReady,
	// Token: 0x04002342 RID: 9026
	OnElementalFoundationCoreChanged,
	// Token: 0x04002343 RID: 9027
	SlidingBlockGameStageChanged,
	// Token: 0x04002344 RID: 9028
	WuWuLogisticsTaskUpdate,
	// Token: 0x04002345 RID: 9029
	SlidingBlockCheckLineClear,
	// Token: 0x04002346 RID: 9030
	SlidingBlockSqueezePlayer,
	// Token: 0x04002347 RID: 9031
	OnAnniversaryActivityRewardUpdate,
	// Token: 0x04002348 RID: 9032
	OnBossPilingReward,
	// Token: 0x04002349 RID: 9033
	OnRoleSkillBranchInGamePlayChanged,
	// Token: 0x0400234A RID: 9034
	OnQuickHackCurrentRamChange,
	// Token: 0x0400234B RID: 9035
	OnQuickHackMaxRamChange,
	// Token: 0x0400234C RID: 9036
	OnQuickHackAllSkillChange,
	// Token: 0x0400234D RID: 9037
	OnQuickHackSelectSkillChange,
	// Token: 0x0400234E RID: 9038
	OnQuickHackDurationLimitChange,
	// Token: 0x0400234F RID: 9039
	OnQuickHackTargetChange,
	// Token: 0x04002350 RID: 9040
	OnQuickHackSceneItemStateChange,
	// Token: 0x04002351 RID: 9041
	OnQuickHackCameraControlChange,
	// Token: 0x04002352 RID: 9042
	OnQuickHackStartMark,
	// Token: 0x04002353 RID: 9043
	OnQuickHackClose,
	// Token: 0x04002354 RID: 9044
	OnQuickHackCameraControlClose,
	// Token: 0x04002355 RID: 9045
	WeeklyChallengeRefresh,
	// Token: 0x04002356 RID: 9046
	WeeklyChallengeRefreshRedDotChanged,
	// Token: 0x04002357 RID: 9047
	WeeklyChallengeRewardStateChanged,
	// Token: 0x04002358 RID: 9048
	WeeklyChallengeScoreChanged,
	// Token: 0x04002359 RID: 9049
	OnTrialRoleDataChanged,
	// Token: 0x0400235A RID: 9050
	OnProjectionPhotoItemStartDrag,
	// Token: 0x0400235B RID: 9051
	OnProjectionPhotoItemEndDrag,
	// Token: 0x0400235C RID: 9052
	OnProjectionPhotoFinishDrag,
	// Token: 0x0400235D RID: 9053
	OnProjectionPhotoItemPointDown,
	// Token: 0x0400235E RID: 9054
	OnProjectionPhotoItemPointUp,
	// Token: 0x0400235F RID: 9055
	OnProjectionPhotoSliderEndDrag,
	// Token: 0x04002360 RID: 9056
	OnHorizontalSliderValueFirstChange,
	// Token: 0x04002361 RID: 9057
	OnProjectionPhotoItemDragCancel,
	// Token: 0x04002362 RID: 9058
	VisionSummonEndByAction,
	// Token: 0x04002363 RID: 9059
	ClosePlotCaptionImageView,
	// Token: 0x04002364 RID: 9060
	MultiMotorRankInfoRefresh,
	// Token: 0x04002365 RID: 9061
	MultiMotorRefresh,
	// Token: 0x04002366 RID: 9062
	MultiMotorBuffRefresh,
	// Token: 0x04002367 RID: 9063
	MultiMotorPassLine,
	// Token: 0x04002368 RID: 9064
	MultiMotorStart,
	// Token: 0x04002369 RID: 9065
	OnDollGrabMachineClawStateStart,
	// Token: 0x0400236A RID: 9066
	OnDollGrabMachineGrabbingActorChanged,
	// Token: 0x0400236B RID: 9067
	OnDollGrabMachineClawStateEnd,
	// Token: 0x0400236C RID: 9068
	OnDollGrabMachineRemainingTimeAdd,
	// Token: 0x0400236D RID: 9069
	OnDollGrabMachineGrabDoll,
	// Token: 0x0400236E RID: 9070
	OnDollGrabMachineEndlessScoreChanged,
	// Token: 0x0400236F RID: 9071
	OnDollGrabMachineStartCoolDown,
	// Token: 0x04002370 RID: 9072
	OnDollGrabMachineEndCoolDown,
	// Token: 0x04002371 RID: 9073
	OnDollGrabMachineEnd,
	// Token: 0x04002372 RID: 9074
	OnDollGrabMachineRestart,
	// Token: 0x04002373 RID: 9075
	OnDollGrabMachinePause,
	// Token: 0x04002374 RID: 9076
	OnDollGrabMachineResume,
	// Token: 0x04002375 RID: 9077
	OnDollGrabMachineDelivery,
	// Token: 0x04002376 RID: 9078
	OnDollGrabMachineDeliveryFinish,
	// Token: 0x04002377 RID: 9079
	OnDollGrabMachineDangerousCountdown,
	// Token: 0x04002378 RID: 9080
	OnDollGrabMachineGameplayStateChanged,
	// Token: 0x04002379 RID: 9081
	QuestMultiLineTimePointChange,
	// Token: 0x0400237A RID: 9082
	OnEntityPerformanceStateChanged,
	// Token: 0x0400237B RID: 9083
	RestartHangingPreloadTask,
	// Token: 0x0400237C RID: 9084
	RealmBetweenTaskRefresh,
	// Token: 0x0400237D RID: 9085
	RealmBetweenMotorRefresh,
	// Token: 0x0400237E RID: 9086
	RealmBetweenTaskNavigationNext,
	// Token: 0x0400237F RID: 9087
	OnWuWaGoRoleDead,
	// Token: 0x04002380 RID: 9088
	OnWuWaGoDamageBatchStateChanged,
	// Token: 0x04002381 RID: 9089
	OnWuWaGoMoveMonsterActed,
	// Token: 0x04002382 RID: 9090
	OnWuWaGoUserPickScreen,
	// Token: 0x04002383 RID: 9091
	OnWuWaGoUserPreviewScreen,
	// Token: 0x04002384 RID: 9092
	OnWuWaGoUserPickDirection,
	// Token: 0x04002385 RID: 9093
	OnWuWaGoUserUseInteraction,
	// Token: 0x04002386 RID: 9094
	OnWuWaGoInteractionAvailable,
	// Token: 0x04002387 RID: 9095
	OnWuWaGoPlayTipAvailable,
	// Token: 0x04002388 RID: 9096
	OnWuWaGoMainControlInputAcceptingChanged,
	// Token: 0x04002389 RID: 9097
	OnWuWaGoCinematicPlayingChanged,
	// Token: 0x0400238A RID: 9098
	OnWuWaGoProgressUpdate,
	// Token: 0x0400238B RID: 9099
	OnWuWaGoRollbackAvailable,
	// Token: 0x0400238C RID: 9100
	OnWuWaGoUserRequestRollbackToSavePoint,
	// Token: 0x0400238D RID: 9101
	OnAnimNotifyMaterialControllerHandleAdded,
	// Token: 0x0400238E RID: 9102
	OnGotoAnomaly,
	// Token: 0x0400238F RID: 9103
	OnSheriffShopRedDotRefresh,
	// Token: 0x04002390 RID: 9104
	ActivitySignGrandRewardRefresh,
	// Token: 0x04002391 RID: 9105
	OnUnOpenedAreaCountDownUpdate,
	// Token: 0x04002392 RID: 9106
	OnPhotoSaveViewPersonalInfoShowRefresh,
	// Token: 0x04002393 RID: 9107
	OnRoleTrialStateChanged,
	// Token: 0x04002394 RID: 9108
	OnInteractiveItemsFunctionEnableChanged,
	// Token: 0x04002395 RID: 9109
	OnLevelInputLockChanged,
	// Token: 0x04002396 RID: 9110
	OnWorldMapExtraUiOpen,
	// Token: 0x04002397 RID: 9111
	OnWorldMapExtraUiClose,
	// Token: 0x04002398 RID: 9112
	OnRefreshBattleRoleSlot,
	// Token: 0x04002399 RID: 9113
	OnDangoBrawlSelectionChanged,
	// Token: 0x0400239A RID: 9114
	OnDangoBrawlOverlapChanged,
	// Token: 0x0400239B RID: 9115
	OnDagnoBrawlClickOption,
	// Token: 0x0400239C RID: 9116
	OnDangoBrawlShortcutKey,
	// Token: 0x0400239D RID: 9117
	OnDangoBrawlShopToggleLock,
	// Token: 0x0400239E RID: 9118
	OnDangoBrawlRotateRequest,
	// Token: 0x0400239F RID: 9119
	OnDangoBrawlCoinUpdated,
	// Token: 0x040023A0 RID: 9120
	OnDangoBrawlShopRefreshed,
	// Token: 0x040023A1 RID: 9121
	OnDangoBrawlShopBought,
	// Token: 0x040023A2 RID: 9122
	OnDangoBrawlShopComposed,
	// Token: 0x040023A3 RID: 9123
	OnDangoBrawlShopSold,
	// Token: 0x040023A4 RID: 9124
	OnDangoBrawlBagOperated,
	// Token: 0x040023A5 RID: 9125
	OnDangoBrawlDragWillBegin,
	// Token: 0x040023A6 RID: 9126
	OnDangoBrawlDragBegin,
	// Token: 0x040023A7 RID: 9127
	OnDangoBrawlDragEnd,
	// Token: 0x040023A8 RID: 9128
	OnDangoBrawlDragEndAnyWay,
	// Token: 0x040023A9 RID: 9129
	OnDangoBrawlLayerModeChanged,
	// Token: 0x040023AA RID: 9130
	OnDangoBrawlCostChanged,
	// Token: 0x040023AB RID: 9131
	OnDangoBrawlBackpackModified,
	// Token: 0x040023AC RID: 9132
	OnDangoBrawlBenchModified,
	// Token: 0x040023AD RID: 9133
	OnDangoBrawlInteractionStateChanged,
	// Token: 0x040023AE RID: 9134
	OnDangoBrawlBagUpdated,
	// Token: 0x040023AF RID: 9135
	OnDangoBrawlItemHoveredChange,
	// Token: 0x040023B0 RID: 9136
	OnDangoBrawlShopStateTipsClosed,
	// Token: 0x040023B1 RID: 9137
	OnDangoBrawlRoundStartEffectsReady,
	// Token: 0x040023B2 RID: 9138
	OnDangoBrawlLoseCountChanged,
	// Token: 0x040023B3 RID: 9139
	OnDangoBrawlItemGiveCoinNotify,
	// Token: 0x040023B4 RID: 9140
	OnDangoBrawlItemEffectShowNotify,
	// Token: 0x040023B5 RID: 9141
	OnDangoBrawlShopLockChangedNotify,
	// Token: 0x040023B6 RID: 9142
	OnDangoBrawlThreeChooseClosed,
	// Token: 0x040023B7 RID: 9143
	OnDangoBrawlThreeChooseStateChanged,
	// Token: 0x040023B8 RID: 9144
	OnDangoBrawlThreeChooseRecover,
	// Token: 0x040023B9 RID: 9145
	OnDangoBrawlRoundSettleStateChanged,
	// Token: 0x040023BA RID: 9146
	OnDangoBrawlRoundSettleRecover,
	// Token: 0x040023BB RID: 9147
	OnDangoBrawlRoundSettleClosed,
	// Token: 0x040023BC RID: 9148
	OnDangobrawlMoveRotateHotKeyNotify,
	// Token: 0x040023BD RID: 9149
	OnDangobrawlLockShopGoodsHotKeyNotify,
	// Token: 0x040023BE RID: 9150
	OnDangobrawlOpenCombineTipsHotKeyNofify,
	// Token: 0x040023BF RID: 9151
	OnDangobrawlCancelHotKeyNotify,
	// Token: 0x040023C0 RID: 9152
	OnDangobrawlReplaceHotKeyNotify,
	// Token: 0x040023C1 RID: 9153
	OnDangobrawlOpenItemTipsHotkeyNotify,
	// Token: 0x040023C2 RID: 9154
	OnDangoBrawlEntityCreate,
	// Token: 0x040023C3 RID: 9155
	OnDangoBrawlFightingTimerInit,
	// Token: 0x040023C4 RID: 9156
	OnDangoBrawlBattleBuffUpdate,
	// Token: 0x040023C5 RID: 9157
	OnDangoBrawlBattleBuffVisualCue,
	// Token: 0x040023C6 RID: 9158
	OnDangoBrawlFightStateModify,
	// Token: 0x040023C7 RID: 9159
	OnDangoBrawlChooseCardRefresh,
	// Token: 0x040023C8 RID: 9160
	OnDangoBrawlActiveEventsUpdated,
	// Token: 0x040023C9 RID: 9161
	OnDangoBrawlFatigueFirstTriggered,
	// Token: 0x040023CA RID: 9162
	OnDangoBrawlBattleLogChanged,
	// Token: 0x040023CB RID: 9163
	OnDangoBrawlFighterAttrChanged,
	// Token: 0x040023CC RID: 9164
	OnDangoBrawlDamageUiText,
	// Token: 0x040023CD RID: 9165
	OnDangoBrawlItemCdUpdate,
	// Token: 0x040023CE RID: 9166
	OnDangoBrawlItemUIEffectShow,
	// Token: 0x040023CF RID: 9167
	OnDangoBrawlWeaponStop,
	// Token: 0x040023D0 RID: 9168
	OnDangoBrawlEnterRoundSettle,
	// Token: 0x040023D1 RID: 9169
	OnGiantStableValueChange,
	// Token: 0x040023D2 RID: 9170
	OnGiantStageCross,
	// Token: 0x040023D3 RID: 9171
	OnGiantIdleChange,
	// Token: 0x040023D4 RID: 9172
	OnGiantUnlockChange,
	// Token: 0x040023D5 RID: 9173
	OnGiantPlayMontage,
	// Token: 0x040023D6 RID: 9174
	OnGiantBodyVisibilityChange,
	// Token: 0x040023D7 RID: 9175
	OnGiantEcoStatusChange,
	// Token: 0x040023D8 RID: 9176
	OnGiantAccessProgressChange,
	// Token: 0x040023D9 RID: 9177
	OnGiantCommissionRead,
	// Token: 0x040023DA RID: 9178
	OnGiantNodeInteractChange,
	// Token: 0x040023DB RID: 9179
	OnDynamicDetectableActorsChanged,
	// Token: 0x040023DC RID: 9180
	OnPathDrivenActorRunStateChanged,
	// Token: 0x040023DD RID: 9181
	OnPathDrivenActorBatchSpawnedChanged,
	// Token: 0x040023DE RID: 9182
	OnPianoGameplayStageChanged,
	// Token: 0x040023DF RID: 9183
	OnPianoGameplayUpdateSubtitle,
	// Token: 0x040023E0 RID: 9184
	OnSceneTextOpen,
	// Token: 0x040023E1 RID: 9185
	OnSceneTextClose,
	// Token: 0x040023E2 RID: 9186
	OnSceneTextVoiceClose,
	// Token: 0x040023E3 RID: 9187
	OnUiTextEnableUseDebugFixedDuration,
	// Token: 0x040023E4 RID: 9188
	OnFlyingFlowerUpdateSubtitle,
	// Token: 0x040023E5 RID: 9189
	Test0,
	// Token: 0x040023E6 RID: 9190
	Test1,
	// Token: 0x040023E7 RID: 9191
	Test2,
	// Token: 0x040023E8 RID: 9192
	Test3,
	// Token: 0x040023E9 RID: 9193
	Test4,
	// Token: 0x040023EA RID: 9194
	Test5,
	// Token: 0x040023EB RID: 9195
	Test6,
	// Token: 0x040023EC RID: 9196
	Test7,
	// Token: 0x040023ED RID: 9197
	ResetToBattleView,
	// Token: 0x040023EE RID: 9198
	OnHonamiStorySafeLeaveUpdate,
	// Token: 0x040023EF RID: 9199
	MovieModeAspectFadeComplete,
	// Token: 0x040023F0 RID: 9200
	MotorDevelopTechTreeNodeUpdate,
	// Token: 0x040023F1 RID: 9201
	RouletteRefreshRedDot,
	// Token: 0x040023F2 RID: 9202
	RouletteRefreshNewOrRedDot,
	// Token: 0x040023F3 RID: 9203
	RouletteAssemblyGridRefreshRedDot,
	// Token: 0x040023F4 RID: 9204
	BattleUiPressMusicCombineButtonChanged,
	// Token: 0x040023F5 RID: 9205
	TeleportAfterComplete,
	// Token: 0x040023F6 RID: 9206
	BeforeTeleportComplete,
	// Token: 0x040023F7 RID: 9207
	PlotTeleportToPositionFinished,
	// Token: 0x040023F8 RID: 9208
	MotorUiModelUpdate,
	// Token: 0x040023F9 RID: 9209
	ShowAreaTips,
	// Token: 0x040023FA RID: 9210
	RoleFindMotorcycleInteractiveEntity,
	// Token: 0x040023FB RID: 9211
	RoleFindFixHook,
	// Token: 0x040023FC RID: 9212
	OnMotorPlayTick,
	// Token: 0x040023FD RID: 9213
	TsSyncWorldLevel,
	// Token: 0x040023FE RID: 9214
	OnGuessJokerLevelUnlockNotify,
	// Token: 0x040023FF RID: 9215
	OnGuessJokerUnlockClickedNotify,
	// Token: 0x04002400 RID: 9216
	SpawnBoss,
	// Token: 0x04002401 RID: 9217
	MotorcycleWaterDetectedTick,
	// Token: 0x04002402 RID: 9218
	MotorcycleWaterDetectedStart,
	// Token: 0x04002403 RID: 9219
	MotorcycleWaterDetectedEnd,
	// Token: 0x04002404 RID: 9220
	OnPhantomConfigManagerSharedUpdate,
	// Token: 0x04002405 RID: 9221
	OnRacingBetsMatchStateChange,
	// Token: 0x04002406 RID: 9222
	SlidingBlockEndlessSpeedLevel,
	// Token: 0x04002407 RID: 9223
	OnGameplayTagChanged,
	// Token: 0x04002408 RID: 9224
	SolarSchoolAttrChanged,
	// Token: 0x04002409 RID: 9225
	SolarSchoolFavorChanged,
	// Token: 0x0400240A RID: 9226
	SolarSchoolInfluenceChanged,
	// Token: 0x0400240B RID: 9227
	SolarSchoolTimeChanged,
	// Token: 0x0400240C RID: 9228
	SolarSchoolBehaviorSettled,
	// Token: 0x0400240D RID: 9229
	SolarSchoolBehaviorUnlocked,
	// Token: 0x0400240E RID: 9230
	SolarSchoolSpecialStateChanged,
	// Token: 0x0400240F RID: 9231
	SolarSchoolItemChanged,
	// Token: 0x04002410 RID: 9232
	SolarSchoolItemTipsRefreshed,
	// Token: 0x04002411 RID: 9233
	OnCommonChildViewShowDone,
	// Token: 0x04002412 RID: 9234
	SolarSchoolExamScoreChanged,
	// Token: 0x04002413 RID: 9235
	SolarSchoolLocationChanged,
	// Token: 0x04002414 RID: 9236
	SolarSchoolAvgParamChanged,
	// Token: 0x04002415 RID: 9237
	SolarSchoolRewardTaskUpdate,
	// Token: 0x04002416 RID: 9238
	SolarSchoolGalleryUpdate,
	// Token: 0x04002417 RID: 9239
	SolarSchoolGalleryViewedUpdate,
	// Token: 0x04002418 RID: 9240
	SolarSchoolSaveUpdate,
	// Token: 0x04002419 RID: 9241
	SolarSchoolQuestUnlocked,
	// Token: 0x0400241A RID: 9242
	SolarSchoolQuestUnlockRedDotChanged,
	// Token: 0x0400241B RID: 9243
	SolarSchoolQuestProgressChanged,
	// Token: 0x0400241C RID: 9244
	SolarSchoolQuestRewardClaimed,
	// Token: 0x0400241D RID: 9245
	SolarSchoolShopPurchaseChanged,
	// Token: 0x0400241E RID: 9246
	SolarSchoolGiftCountChanged,
	// Token: 0x0400241F RID: 9247
	SolarSchoolQuestNodeStateChanged,
	// Token: 0x04002420 RID: 9248
	SolarSchoolLocationUnlocked,
	// Token: 0x04002421 RID: 9249
	SolarSchoolBagGridSequenceEnd,
	// Token: 0x04002422 RID: 9250
	SolarSchoolAttrImportantChanged,
	// Token: 0x04002423 RID: 9251
	TetrisRotate,
	// Token: 0x04002424 RID: 9252
	TetrisPickShape,
	// Token: 0x04002425 RID: 9253
	OnNormalQuestFinishListNotify
}
