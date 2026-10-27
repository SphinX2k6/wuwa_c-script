using System;

// Token: 0x0200024E RID: 590
public enum EEventName
{
	// Token: 0x04001830 RID: 6192
	SetEntityCreatureDataRelation,
	// Token: 0x04001831 RID: 6193
	KeyClick,
	// Token: 0x04001832 RID: 6194
	UiSceneLoaded,
	// Token: 0x04001833 RID: 6195
	UiSceneStartLoad,
	// Token: 0x04001834 RID: 6196
	UiSceneLastStepInLoadScene,
	// Token: 0x04001835 RID: 6197
	UiSceneLastStepInExitScene,
	// Token: 0x04001836 RID: 6198
	OpenView,
	// Token: 0x04001837 RID: 6199
	StackPreOpenView,
	// Token: 0x04001838 RID: 6200
	StackOpenView,
	// Token: 0x04001839 RID: 6201
	StackCloseView,
	// Token: 0x0400183A RID: 6202
	OnNormalTopViewChange,
	// Token: 0x0400183B RID: 6203
	FloatQueueCloseView,
	// Token: 0x0400183C RID: 6204
	OpenViewBegined,
	// Token: 0x0400183D RID: 6205
	OpenViewFail,
	// Token: 0x0400183E RID: 6206
	CreateViewInstance,
	// Token: 0x0400183F RID: 6207
	OnViewLoadCompleted,
	// Token: 0x04001840 RID: 6208
	OnViewDone,
	// Token: 0x04001841 RID: 6209
	OnViewHidden,
	// Token: 0x04001842 RID: 6210
	CloseView,
	// Token: 0x04001843 RID: 6211
	CloseCompositeRewardView,
	// Token: 0x04001844 RID: 6212
	OpenTabView,
	// Token: 0x04001845 RID: 6213
	TriggerUiTimeDilation,
	// Token: 0x04001846 RID: 6214
	CloseTabView,
	// Token: 0x04001847 RID: 6215
	ChangeChildView,
	// Token: 0x04001848 RID: 6216
	SwitchAdventureGuideViewTab,
	// Token: 0x04001849 RID: 6217
	UiManagerInit,
	// Token: 0x0400184A RID: 6218
	UiManagerDestroy,
	// Token: 0x0400184B RID: 6219
	HotKeyInput,
	// Token: 0x0400184C RID: 6220
	ViewHotKeyInputPress,
	// Token: 0x0400184D RID: 6221
	ViewHotKeyInputRelease,
	// Token: 0x0400184E RID: 6222
	ResetNormalAction,
	// Token: 0x0400184F RID: 6223
	UnBlockCharacterAction,
	// Token: 0x04001850 RID: 6224
	ResetSystemAction,
	// Token: 0x04001851 RID: 6225
	OnReduceDamageViewDepth,
	// Token: 0x04001852 RID: 6226
	LevelSequencePlayerBandStateChange,
	// Token: 0x04001853 RID: 6227
	UIViewPortSizeChanged,
	// Token: 0x04001854 RID: 6228
	OnDynamicScrollViewClearItem,
	// Token: 0x04001855 RID: 6229
	LoginSuccess,
	// Token: 0x04001856 RID: 6230
	EnterGameSuccess,
	// Token: 0x04001857 RID: 6231
	LoginStatusChange,
	// Token: 0x04001858 RID: 6232
	LoginRequestResult,
	// Token: 0x04001859 RID: 6233
	SdkLoginResult,
	// Token: 0x0400185A RID: 6234
	OnGetLoginPlayerInfo,
	// Token: 0x0400185B RID: 6235
	OnSelectServerItem,
	// Token: 0x0400185C RID: 6236
	OnConfirmServerItem,
	// Token: 0x0400185D RID: 6237
	OnNetworkDetectionSelectServerItem,
	// Token: 0x0400185E RID: 6238
	OnConfirmNetworkDetectionItem,
	// Token: 0x0400185F RID: 6239
	SendHeartbeat,
	// Token: 0x04001860 RID: 6240
	SdkInitDone,
	// Token: 0x04001861 RID: 6241
	SdkPayEnd,
	// Token: 0x04001862 RID: 6242
	PlayStationJoinSessionEvent,
	// Token: 0x04001863 RID: 6243
	SdkRefreshAccessToken,
	// Token: 0x04001864 RID: 6244
	SdkRefreshNoticeRedDot,
	// Token: 0x04001865 RID: 6245
	CharQteActive,
	// Token: 0x04001866 RID: 6246
	CharQteConsume,
	// Token: 0x04001867 RID: 6247
	CharInQteChanged,
	// Token: 0x04001868 RID: 6248
	CharExecuteQte,
	// Token: 0x04001869 RID: 6249
	CharExecuteMultiQte,
	// Token: 0x0400186A RID: 6250
	CharQteTagRowNameChanged,
	// Token: 0x0400186B RID: 6251
	CharHitLocal,
	// Token: 0x0400186C RID: 6252
	CharHitRemote,
	// Token: 0x0400186D RID: 6253
	CharBeHitLocal,
	// Token: 0x0400186E RID: 6254
	CharHitIncludingVision,
	// Token: 0x0400186F RID: 6255
	CharBeHitRemote,
	// Token: 0x04001870 RID: 6256
	CharLimitDodge,
	// Token: 0x04001871 RID: 6257
	CharBeHitAnim,
	// Token: 0x04001872 RID: 6258
	CharBeforeSetHitRotator,
	// Token: 0x04001873 RID: 6259
	CharBeHitTimeScale,
	// Token: 0x04001874 RID: 6260
	CharShieldChange,
	// Token: 0x04001875 RID: 6261
	CharAnimBreakPoint,
	// Token: 0x04001876 RID: 6262
	CharBeforeSkillWithTarget,
	// Token: 0x04001877 RID: 6263
	CharBeforeSkill,
	// Token: 0x04001878 RID: 6264
	ConditionDrivenSMTickLock,
	// Token: 0x04001879 RID: 6265
	CharBeforeInterruptWithTarget,
	// Token: 0x0400187A RID: 6266
	CharGameplayCueChanged,
	// Token: 0x0400187B RID: 6267
	CharUseSkill,
	// Token: 0x0400187C RID: 6268
	CharUseSkillRemote,
	// Token: 0x0400187D RID: 6269
	OnCharJump,
	// Token: 0x0400187E RID: 6270
	OnSkillEnd,
	// Token: 0x0400187F RID: 6271
	CharStopAllSkills,
	// Token: 0x04001880 RID: 6272
	CharStopGroup1Skill,
	// Token: 0x04001881 RID: 6273
	CharSetShowTarget,
	// Token: 0x04001882 RID: 6274
	CharEndShowTarget,
	// Token: 0x04001883 RID: 6275
	OnSkillSimulateMontage,
	// Token: 0x04001884 RID: 6276
	OnBeforeSkillSimulateMontage,
	// Token: 0x04001885 RID: 6277
	OnBeforeBeCaughtWithTarget,
	// Token: 0x04001886 RID: 6278
	OnMultiSkillIdChanged,
	// Token: 0x04001887 RID: 6279
	OnMultiSkillEnable,
	// Token: 0x04001888 RID: 6280
	CharSwitchControl,
	// Token: 0x04001889 RID: 6281
	CharSkillTargetChanged,
	// Token: 0x0400188A RID: 6282
	CharDeleteSkill,
	// Token: 0x0400188B RID: 6283
	CharResetSkill,
	// Token: 0x0400188C RID: 6284
	CharInterruptSkill,
	// Token: 0x0400188D RID: 6285
	CharSkillCountChanged,
	// Token: 0x0400188E RID: 6286
	CharSkillRemainCdChanged,
	// Token: 0x0400188F RID: 6287
	CharSkillCdPauseStateChanged,
	// Token: 0x04001890 RID: 6288
	CharClearSkill,
	// Token: 0x04001891 RID: 6289
	SpecialSkillLuPaSwitchLockTarget,
	// Token: 0x04001892 RID: 6290
	SpecialSkillRebeccaSwitchLockTarget,
	// Token: 0x04001893 RID: 6291
	FuLuoLuoAddDuplicatedEnergy,
	// Token: 0x04001894 RID: 6292
	CharDamage,
	// Token: 0x04001895 RID: 6293
	CharKillTarget,
	// Token: 0x04001896 RID: 6294
	CharBeKilled,
	// Token: 0x04001897 RID: 6295
	CharBeDamage,
	// Token: 0x04001898 RID: 6296
	GlobalCharDamage,
	// Token: 0x04001899 RID: 6297
	FormationPanelUIShowRoleHeal,
	// Token: 0x0400189A RID: 6298
	CharPartDamage,
	// Token: 0x0400189B RID: 6299
	FollowShooterForwardEvent,
	// Token: 0x0400189C RID: 6300
	OnBuffTriggerEvent,
	// Token: 0x0400189D RID: 6301
	CharAfterFrozenChange,
	// Token: 0x0400189E RID: 6302
	CharClimbStartExit,
	// Token: 0x0400189F RID: 6303
	CharActivateClimbInput,
	// Token: 0x040018A0 RID: 6304
	CharClimbJumpCheck,
	// Token: 0x040018A1 RID: 6305
	CustomMoveSwim,
	// Token: 0x040018A2 RID: 6306
	CustomMoveSlide,
	// Token: 0x040018A3 RID: 6307
	CustomMoveSki,
	// Token: 0x040018A4 RID: 6308
	CustomMoveRailSlide,
	// Token: 0x040018A5 RID: 6309
	CustomMoveRide,
	// Token: 0x040018A6 RID: 6310
	CustomMoveWalkOnWater,
	// Token: 0x040018A7 RID: 6311
	CustomMoveClimb,
	// Token: 0x040018A8 RID: 6312
	CustomMoveGlide,
	// Token: 0x040018A9 RID: 6313
	CustomMovePendulum,
	// Token: 0x040018AA RID: 6314
	CustomMoveCatapult,
	// Token: 0x040018AB RID: 6315
	CustomMoveSoar,
	// Token: 0x040018AC RID: 6316
	CustomMoveRoll,
	// Token: 0x040018AD RID: 6317
	CustomMoveSplineClimb,
	// Token: 0x040018AE RID: 6318
	CustomMoveFloating,
	// Token: 0x040018AF RID: 6319
	RequestRestartRailSlide,
	// Token: 0x040018B0 RID: 6320
	CharTurnBegin,
	// Token: 0x040018B1 RID: 6321
	CharTurnEnd,
	// Token: 0x040018B2 RID: 6322
	PerformMontageStop,
	// Token: 0x040018B3 RID: 6323
	CharMovementModeChanged,
	// Token: 0x040018B4 RID: 6324
	CharActivate,
	// Token: 0x040018B5 RID: 6325
	CharOnAttrChanged,
	// Token: 0x040018B6 RID: 6326
	CharGravityDirectChanged,
	// Token: 0x040018B7 RID: 6327
	AnyCharGravityDirectChanged,
	// Token: 0x040018B8 RID: 6328
	CharOnRoleDrown,
	// Token: 0x040018B9 RID: 6329
	CharOnRoleDrownInjure,
	// Token: 0x040018BA RID: 6330
	CharOnEnergyChanged,
	// Token: 0x040018BB RID: 6331
	CharOnHealthChanged,
	// Token: 0x040018BC RID: 6332
	CharOnHealthMaxChanged,
	// Token: 0x040018BD RID: 6333
	CharOnElementEnergyChanged,
	// Token: 0x040018BE RID: 6334
	MonsterBeginBroken,
	// Token: 0x040018BF RID: 6335
	CharOnUnifiedMoveStateChanged,
	// Token: 0x040018C0 RID: 6336
	CharOnPositionStateChanged,
	// Token: 0x040018C1 RID: 6337
	CharOnDirectionStateChanged,
	// Token: 0x040018C2 RID: 6338
	CharOnPositionSubStateChanged,
	// Token: 0x040018C3 RID: 6339
	CharSwimStrengthChanged,
	// Token: 0x040018C4 RID: 6340
	RoleOnStateInherit,
	// Token: 0x040018C5 RID: 6341
	CharOnEndPlay,
	// Token: 0x040018C6 RID: 6342
	CharOnBuffAddUITexture,
	// Token: 0x040018C7 RID: 6343
	CharOnBuffAddUIPrefab,
	// Token: 0x040018C8 RID: 6344
	CharOnBuffAddUIDamage,
	// Token: 0x040018C9 RID: 6345
	CharOnBuffAddRoleSideEnergyBar,
	// Token: 0x040018CA RID: 6346
	CharOnBuffAddShowMoraleBuffTips,
	// Token: 0x040018CB RID: 6347
	OnRoverlikeQSkillBuff,
	// Token: 0x040018CC RID: 6348
	SeamlessTravelUIRefresh,
	// Token: 0x040018CD RID: 6349
	CharOnAnimNotifyStateDurationChange,
	// Token: 0x040018CE RID: 6350
	CharOnLand,
	// Token: 0x040018CF RID: 6351
	CharPossessed,
	// Token: 0x040018D0 RID: 6352
	CharUnpossessed,
	// Token: 0x040018D1 RID: 6353
	CharChangeMeshAnim,
	// Token: 0x040018D2 RID: 6354
	CharRecordOperate,
	// Token: 0x040018D3 RID: 6355
	CharInputAction,
	// Token: 0x040018D4 RID: 6356
	CharBasePlatformChanged,
	// Token: 0x040018D5 RID: 6357
	CharHoldingHandsChanged,
	// Token: 0x040018D6 RID: 6358
	CharOnRoleDeadBefore,
	// Token: 0x040018D7 RID: 6359
	CharOnRoleDead,
	// Token: 0x040018D8 RID: 6360
	CharOnRoleDeadTargetSelf,
	// Token: 0x040018D9 RID: 6361
	CharOnRoleDeadEnd,
	// Token: 0x040018DA RID: 6362
	OnRevive,
	// Token: 0x040018DB RID: 6363
	CharOnRevive,
	// Token: 0x040018DC RID: 6364
	OnTeamLivingStateChange,
	// Token: 0x040018DD RID: 6365
	OnShareReviveTimesChange,
	// Token: 0x040018DE RID: 6366
	OnRoleReviveCooldownChange,
	// Token: 0x040018DF RID: 6367
	CharOnSetNewBeHit,
	// Token: 0x040018E0 RID: 6368
	OnBattleStateChanged,
	// Token: 0x040018E1 RID: 6369
	OnChangeWalkOrRun,
	// Token: 0x040018E2 RID: 6370
	CharOnFallInjure,
	// Token: 0x040018E3 RID: 6371
	ChangeAiTeamLevel,
	// Token: 0x040018E4 RID: 6372
	AiHateAddOrRemove,
	// Token: 0x040018E5 RID: 6373
	AiInFight,
	// Token: 0x040018E6 RID: 6374
	AiHateTargetChanged,
	// Token: 0x040018E7 RID: 6375
	AiTauntAddOrRemove,
	// Token: 0x040018E8 RID: 6376
	AiTaskWanderForResetEnd,
	// Token: 0x040018E9 RID: 6377
	OnRunBehaviorTree,
	// Token: 0x040018EA RID: 6378
	OnAiEnable,
	// Token: 0x040018EB RID: 6379
	OnAiDisable,
	// Token: 0x040018EC RID: 6380
	OnBeforeAiDisable,
	// Token: 0x040018ED RID: 6381
	OnPatrolStart,
	// Token: 0x040018EE RID: 6382
	OnPatrolPause,
	// Token: 0x040018EF RID: 6383
	OnPatrolResume,
	// Token: 0x040018F0 RID: 6384
	OnPatrolStop,
	// Token: 0x040018F1 RID: 6385
	CloseItemTips,
	// Token: 0x040018F2 RID: 6386
	CreateRoleForwardAnimEnd,
	// Token: 0x040018F3 RID: 6387
	CreateRoleShowInputName,
	// Token: 0x040018F4 RID: 6388
	GuideFinish,
	// Token: 0x040018F5 RID: 6389
	GuideGroupOpening,
	// Token: 0x040018F6 RID: 6390
	GuideGroupFinished,
	// Token: 0x040018F7 RID: 6391
	GuideGroupBreak,
	// Token: 0x040018F8 RID: 6392
	GuideGroupRest,
	// Token: 0x040018F9 RID: 6393
	GuideFocusNeedUiTabView,
	// Token: 0x040018FA RID: 6394
	FinishGuideStepByEvent,
	// Token: 0x040018FB RID: 6395
	GuideTouchIdInject,
	// Token: 0x040018FC RID: 6396
	OnRefreshRoleHp,
	// Token: 0x040018FD RID: 6397
	BeforeLoadMap,
	// Token: 0x040018FE RID: 6398
	BeforeTravelMap,
	// Token: 0x040018FF RID: 6399
	EndTravelMap,
	// Token: 0x04001900 RID: 6400
	OnEnterTransitionMap,
	// Token: 0x04001901 RID: 6401
	SeamlessTravelFinishBeforeShowUI,
	// Token: 0x04001902 RID: 6402
	AfterLoadMap,
	// Token: 0x04001903 RID: 6403
	ClearWorld,
	// Token: 0x04001904 RID: 6404
	OnUiManagerClearAsync,
	// Token: 0x04001905 RID: 6405
	WorldDone,
	// Token: 0x04001906 RID: 6406
	WorldDoneAndCloseLoading,
	// Token: 0x04001907 RID: 6407
	ChangeMode,
	// Token: 0x04001908 RID: 6408
	ChangeModeFinish,
	// Token: 0x04001909 RID: 6409
	ChangePerformanceLimitMode,
	// Token: 0x0400190A RID: 6410
	PauseGame,
	// Token: 0x0400190B RID: 6411
	OnInitRole,
	// Token: 0x0400190C RID: 6412
	OnChangeRole,
	// Token: 0x0400190D RID: 6413
	OnOtherChangeRole,
	// Token: 0x0400190E RID: 6414
	OnChangeRoleCoolDownChanged,
	// Token: 0x0400190F RID: 6415
	OnBeforeChangeRole,
	// Token: 0x04001910 RID: 6416
	OnRoleGoDown,
	// Token: 0x04001911 RID: 6417
	OnRoleGoDownFinish,
	// Token: 0x04001912 RID: 6418
	OnOtherRoleGoDownFinish,
	// Token: 0x04001913 RID: 6419
	OnRoleGoUpEnable,
	// Token: 0x04001914 RID: 6420
	OnRoleGoUp,
	// Token: 0x04001915 RID: 6421
	OnClearFollowData,
	// Token: 0x04001916 RID: 6422
	OnRoleGameplayAnimInstChanged,
	// Token: 0x04001917 RID: 6423
	InitArea,
	// Token: 0x04001918 RID: 6424
	InitStaticEntity,
	// Token: 0x04001919 RID: 6425
	OnManuallyClearStreamingPool,
	// Token: 0x0400191A RID: 6426
	OnManuallyResetStreamingPool,
	// Token: 0x0400191B RID: 6427
	OnDeadEyeModeTrigger,
	// Token: 0x0400191C RID: 6428
	OnDeadEyeModeShowShooter,
	// Token: 0x0400191D RID: 6429
	OnDeadEyeModeStageChange,
	// Token: 0x0400191E RID: 6430
	OnDeadEyeModeFinish,
	// Token: 0x0400191F RID: 6431
	DeadEyeModeTargetPointCanLockStateChange,
	// Token: 0x04001920 RID: 6432
	DeadEyeModeTargetPointLocked,
	// Token: 0x04001921 RID: 6433
	DeadEyeModeShootingPerformance,
	// Token: 0x04001922 RID: 6434
	TransportFindPath,
	// Token: 0x04001923 RID: 6435
	TransportSystemInitDone,
	// Token: 0x04001924 RID: 6436
	VehicleMemberBlockByTraceTarget,
	// Token: 0x04001925 RID: 6437
	ChangeArea,
	// Token: 0x04001926 RID: 6438
	UpdateAreaView,
	// Token: 0x04001927 RID: 6439
	CreateEntity,
	// Token: 0x04001928 RID: 6440
	CreateEntityFail,
	// Token: 0x04001929 RID: 6441
	AddEntity,
	// Token: 0x0400192A RID: 6442
	FixBornLocation,
	// Token: 0x0400192B RID: 6443
	CharBornFinished,
	// Token: 0x0400192C RID: 6444
	PreloadEntityFinished,
	// Token: 0x0400192D RID: 6445
	RemoveEntity,
	// Token: 0x0400192E RID: 6446
	RemoveEntityFromBindGroup,
	// Token: 0x0400192F RID: 6447
	EntityOnLandedPush,
	// Token: 0x04001930 RID: 6448
	EntityVarUpdate,
	// Token: 0x04001931 RID: 6449
	SpawnPlayer,
	// Token: 0x04001932 RID: 6450
	OnUpdateTeamGroupType,
	// Token: 0x04001933 RID: 6451
	OnBeforeUpdateSceneTeam,
	// Token: 0x04001934 RID: 6452
	OnUpdateSceneTeam,
	// Token: 0x04001935 RID: 6453
	OnItemDecompose,
	// Token: 0x04001936 RID: 6454
	OnItemLock,
	// Token: 0x04001937 RID: 6455
	OnItemFuncValueChange,
	// Token: 0x04001938 RID: 6456
	OnItemFuncValueBatchChange,
	// Token: 0x04001939 RID: 6457
	OnGetReward,
	// Token: 0x0400193A RID: 6458
	OnReceivePlayerVar,
	// Token: 0x0400193B RID: 6459
	OpenItemInfo,
	// Token: 0x0400193C RID: 6460
	CloseItemInfo,
	// Token: 0x0400193D RID: 6461
	BoughtItem,
	// Token: 0x0400193E RID: 6462
	ShopUpdate,
	// Token: 0x0400193F RID: 6463
	OnShopInfoResponded,
	// Token: 0x04001940 RID: 6464
	OnGoodUnlock,
	// Token: 0x04001941 RID: 6465
	SelectedMail,
	// Token: 0x04001942 RID: 6466
	PickingAttachment,
	// Token: 0x04001943 RID: 6467
	DeletingMail,
	// Token: 0x04001944 RID: 6468
	DeletingMailPassively,
	// Token: 0x04001945 RID: 6469
	AddingNewMail,
	// Token: 0x04001946 RID: 6470
	SwitchUnfinishedFlag,
	// Token: 0x04001947 RID: 6471
	MailFavoriteChanged,
	// Token: 0x04001948 RID: 6472
	CloseMailView,
	// Token: 0x04001949 RID: 6473
	OnlyCloseMailContentView,
	// Token: 0x0400194A RID: 6474
	SceneBulletOwnerCreated,
	// Token: 0x0400194B RID: 6475
	BulletCreate,
	// Token: 0x0400194C RID: 6476
	BulletDestroy,
	// Token: 0x0400194D RID: 6477
	BulletHit,
	// Token: 0x0400194E RID: 6478
	PreBulletCreateFromAnimNotify,
	// Token: 0x0400194F RID: 6479
	PostBulletCreateFromAnimNotify,
	// Token: 0x04001950 RID: 6480
	BulletRebound,
	// Token: 0x04001951 RID: 6481
	BulletHitSpecialCharacter,
	// Token: 0x04001952 RID: 6482
	BulletHitAirWall,
	// Token: 0x04001953 RID: 6483
	BulletPatternEnvironmentChanged,
	// Token: 0x04001954 RID: 6484
	ScenePlayerChanged,
	// Token: 0x04001955 RID: 6485
	ScenePlayerLocationChanged,
	// Token: 0x04001956 RID: 6486
	ScenePlayerLeaveScene,
	// Token: 0x04001957 RID: 6487
	ScenePlayerMarkItemStateChange,
	// Token: 0x04001958 RID: 6488
	MatchTeamFlagChange,
	// Token: 0x04001959 RID: 6489
	LoadingViewProgressSequenceEnd,
	// Token: 0x0400195A RID: 6490
	LoadingViewOnAfterShow,
	// Token: 0x0400195B RID: 6491
	DestroyAllUiCameraAnimationHandles,
	// Token: 0x0400195C RID: 6492
	RoleSelectionListUpdate,
	// Token: 0x0400195D RID: 6493
	SelectRole,
	// Token: 0x0400195E RID: 6494
	SelectSkill,
	// Token: 0x0400195F RID: 6495
	SelectLevelUpItem,
	// Token: 0x04001960 RID: 6496
	RoleInfoUpdate,
	// Token: 0x04001961 RID: 6497
	RoleRefreshAttribute,
	// Token: 0x04001962 RID: 6498
	RoleSkillLevelUp,
	// Token: 0x04001963 RID: 6499
	RoleLevelUp,
	// Token: 0x04001964 RID: 6500
	RoleLevelUpReceiveItem,
	// Token: 0x04001965 RID: 6501
	RoleBreakUp,
	// Token: 0x04001966 RID: 6502
	ActiveRole,
	// Token: 0x04001967 RID: 6503
	RoleSkinRedDotRefresh,
	// Token: 0x04001968 RID: 6504
	HuluSkinRedDotRefresh,
	// Token: 0x04001969 RID: 6505
	RoleOrnamentRedDotRefresh,
	// Token: 0x0400196A RID: 6506
	MainViewRoleButtonRefreshByRoleOrnament,
	// Token: 0x0400196B RID: 6507
	MainViewRoleButtonRefreshByRoleSkin,
	// Token: 0x0400196C RID: 6508
	RoleResonUplevel,
	// Token: 0x0400196D RID: 6509
	RoleResonActive,
	// Token: 0x0400196E RID: 6510
	RoleResonAnimationSuccess,
	// Token: 0x0400196F RID: 6511
	RoleResonPlayAnimation,
	// Token: 0x04001970 RID: 6512
	RoleLangCustomFuncClicked,
	// Token: 0x04001971 RID: 6513
	RoleLangCustomRefresh,
	// Token: 0x04001972 RID: 6514
	CloseRoleView,
	// Token: 0x04001973 RID: 6515
	SelectedResonanceTab,
	// Token: 0x04001974 RID: 6516
	UnSelectedResonanceTab,
	// Token: 0x04001975 RID: 6517
	SwitchRootTabState,
	// Token: 0x04001976 RID: 6518
	RoleRefreshName,
	// Token: 0x04001977 RID: 6519
	RoleSystemChangeRole,
	// Token: 0x04001978 RID: 6520
	RoleSystemDeleteRole,
	// Token: 0x04001979 RID: 6521
	OnSelectedRoleChanged,
	// Token: 0x0400197A RID: 6522
	OnRoleMorphTypeChanged,
	// Token: 0x0400197B RID: 6523
	HideVisionTabRole,
	// Token: 0x0400197C RID: 6524
	ChangeResonance,
	// Token: 0x0400197D RID: 6525
	OnRoleInternalViewEnter,
	// Token: 0x0400197E RID: 6526
	OnRoleInternalViewQuit,
	// Token: 0x0400197F RID: 6527
	AttributeComponentEvent,
	// Token: 0x04001980 RID: 6528
	UpdateRoleLevelUpViewData,
	// Token: 0x04001981 RID: 6529
	UpdateRoleResonanceDetailView,
	// Token: 0x04001982 RID: 6530
	UpdateRoleSkillLevelUpView,
	// Token: 0x04001983 RID: 6531
	RefreshSkillTreeInfoTabView,
	// Token: 0x04001984 RID: 6532
	SkillTreeRefresh,
	// Token: 0x04001985 RID: 6533
	RefreshSkillTreeLeftSkillPoint,
	// Token: 0x04001986 RID: 6534
	SkillTreeReset,
	// Token: 0x04001987 RID: 6535
	SkillTreeClickEmpty,
	// Token: 0x04001988 RID: 6536
	SkillTreeNodeActive,
	// Token: 0x04001989 RID: 6537
	SkillTreeNodeLevelUp,
	// Token: 0x0400198A RID: 6538
	OnSkillTreeNodeToggleClick,
	// Token: 0x0400198B RID: 6539
	UpdateRoleFavorData,
	// Token: 0x0400198C RID: 6540
	UnLockRoleFavorItem,
	// Token: 0x0400198D RID: 6541
	RoleFavorExpChange,
	// Token: 0x0400198E RID: 6542
	UpdateRoleFavorHintView,
	// Token: 0x0400198F RID: 6543
	RefreshFunctionOpenView,
	// Token: 0x04001990 RID: 6544
	ExploreComponentTargetChanged,
	// Token: 0x04001991 RID: 6545
	UpdateRoleBreachView,
	// Token: 0x04001992 RID: 6546
	OnClickSkillLevelUp,
	// Token: 0x04001993 RID: 6547
	OnClickSkillActive,
	// Token: 0x04001994 RID: 6548
	OnEnterOrExitUltraSkill,
	// Token: 0x04001995 RID: 6549
	OnRoleSkinChange,
	// Token: 0x04001996 RID: 6550
	OnRoleSkinSubViewShow,
	// Token: 0x04001997 RID: 6551
	OnInteractionWaterTypeChange,
	// Token: 0x04001998 RID: 6552
	OnRoleBackgroundMusicEnabledChanged,
	// Token: 0x04001999 RID: 6553
	OnCurTrialRoleGroupChanged,
	// Token: 0x0400199A RID: 6554
	OnGroupTrialRoleChanged,
	// Token: 0x0400199B RID: 6555
	OnRoleSkillBranchChanged,
	// Token: 0x0400199C RID: 6556
	OnSkillShowTagToggleChanged,
	// Token: 0x0400199D RID: 6557
	WeaponLevelUp,
	// Token: 0x0400199E RID: 6558
	WeaponLevelUpReceiveItem,
	// Token: 0x0400199F RID: 6559
	WeaponCanGoBreach,
	// Token: 0x040019A0 RID: 6560
	WeaponBreakUp,
	// Token: 0x040019A1 RID: 6561
	WeaponRoleEquipChanged,
	// Token: 0x040019A2 RID: 6562
	WeaponRoleLevelUp,
	// Token: 0x040019A3 RID: 6563
	WeaponRoleBreakUp,
	// Token: 0x040019A4 RID: 6564
	WeaponItemClick,
	// Token: 0x040019A5 RID: 6565
	WeaponEmptyClick,
	// Token: 0x040019A6 RID: 6566
	WeaponSortClick,
	// Token: 0x040019A7 RID: 6567
	WeaponMaterialPropClick,
	// Token: 0x040019A8 RID: 6568
	EquipWeapon,
	// Token: 0x040019A9 RID: 6569
	ContrastWeapon,
	// Token: 0x040019AA RID: 6570
	WeaponResonanceSuccess,
	// Token: 0x040019AB RID: 6571
	ReConnectBegin,
	// Token: 0x040019AC RID: 6572
	ReConnectFail,
	// Token: 0x040019AD RID: 6573
	CanNotReConnect,
	// Token: 0x040019AE RID: 6574
	ReConnectSuccess,
	// Token: 0x040019AF RID: 6575
	BackLoginView,
	// Token: 0x040019B0 RID: 6576
	LogOut,
	// Token: 0x040019B1 RID: 6577
	ExitGamePush,
	// Token: 0x040019B2 RID: 6578
	NetWorkMaskRpcAdd,
	// Token: 0x040019B3 RID: 6579
	NetWorkMaskRpcRemove,
	// Token: 0x040019B4 RID: 6580
	OnAimStateChanged,
	// Token: 0x040019B5 RID: 6581
	OnPhantomInputDataUpdate,
	// Token: 0x040019B6 RID: 6582
	OpenDragonPoolView,
	// Token: 0x040019B7 RID: 6583
	UpdateDragonPoolView,
	// Token: 0x040019B8 RID: 6584
	LoadMapTileFinish,
	// Token: 0x040019B9 RID: 6585
	MapOpenFogChange,
	// Token: 0x040019BA RID: 6586
	MapOpenFogFullUpdate,
	// Token: 0x040019BB RID: 6587
	MapAreaDarkShow,
	// Token: 0x040019BC RID: 6588
	WorldMapSecondaryUiClosed,
	// Token: 0x040019BD RID: 6589
	WorldMapSecondaryUiOpened,
	// Token: 0x040019BE RID: 6590
	BlackScreenFadeOnPlotToWorldMap,
	// Token: 0x040019BF RID: 6591
	MarkMenuClickItem,
	// Token: 0x040019C0 RID: 6592
	TrackMenuClickItem,
	// Token: 0x040019C1 RID: 6593
	RefreshMenuSetting,
	// Token: 0x040019C2 RID: 6594
	OnGameplaySettingsSet,
	// Token: 0x040019C3 RID: 6595
	ModelReady,
	// Token: 0x040019C4 RID: 6596
	MapReplaceMarkResponse,
	// Token: 0x040019C5 RID: 6597
	CreateMapMark,
	// Token: 0x040019C6 RID: 6598
	CreateTempMapMark,
	// Token: 0x040019C7 RID: 6599
	AddMapMark,
	// Token: 0x040019C8 RID: 6600
	RemoveMapMark,
	// Token: 0x040019C9 RID: 6601
	TrackMapMark,
	// Token: 0x040019CA RID: 6602
	MarkHideState,
	// Token: 0x040019CB RID: 6603
	OnMapMarkTaskComplete,
	// Token: 0x040019CC RID: 6604
	UnlockTeleport,
	// Token: 0x040019CD RID: 6605
	TrackMark,
	// Token: 0x040019CE RID: 6606
	UnTrackMark,
	// Token: 0x040019CF RID: 6607
	OnMarkItemTrackStateChange,
	// Token: 0x040019D0 RID: 6608
	ClearTrackMark,
	// Token: 0x040019D1 RID: 6609
	MarkForceVisibleChanged,
	// Token: 0x040019D2 RID: 6610
	UpdateTrackTarget,
	// Token: 0x040019D3 RID: 6611
	SetTrackMarkOccupied,
	// Token: 0x040019D4 RID: 6612
	TeleportComplete,
	// Token: 0x040019D5 RID: 6613
	TeleportChangeLocation,
	// Token: 0x040019D6 RID: 6614
	TeleportStart,
	// Token: 0x040019D7 RID: 6615
	TeleportStartEntity,
	// Token: 0x040019D8 RID: 6616
	TeleportOpenLoadingEnd,
	// Token: 0x040019D9 RID: 6617
	SetFightDtTypeForDebug,
	// Token: 0x040019DA RID: 6618
	OnEnterDailyQuestNotifyRange,
	// Token: 0x040019DB RID: 6619
	OnEnterNearbyTrackRange,
	// Token: 0x040019DC RID: 6620
	OnLeaveNearbyTrackRange,
	// Token: 0x040019DD RID: 6621
	RemoveNearbyTrack,
	// Token: 0x040019DE RID: 6622
	UpdateNearbyTrackTag,
	// Token: 0x040019DF RID: 6623
	OnUpdateNearbyEnable,
	// Token: 0x040019E0 RID: 6624
	OnUpdateCompassActive,
	// Token: 0x040019E1 RID: 6625
	WorldMapViewOpened,
	// Token: 0x040019E2 RID: 6626
	WorldMapPointerDown,
	// Token: 0x040019E3 RID: 6627
	WorldMapPointerDrag,
	// Token: 0x040019E4 RID: 6628
	WorldMapJoystickMoveForward,
	// Token: 0x040019E5 RID: 6629
	WorldMapJoystickMoveRight,
	// Token: 0x040019E6 RID: 6630
	WorldMapFocusPlayer,
	// Token: 0x040019E7 RID: 6631
	WorldMapShowTrackList,
	// Token: 0x040019E8 RID: 6632
	WorldMapDragInertia,
	// Token: 0x040019E9 RID: 6633
	WorldMapPointerUp,
	// Token: 0x040019EA RID: 6634
	WorldMapFingerExpandClose,
	// Token: 0x040019EB RID: 6635
	WorldMapWheelAxisInput,
	// Token: 0x040019EC RID: 6636
	WorldMapHandleTriggerAxisInput,
	// Token: 0x040019ED RID: 6637
	WorldMapZoomBtnInput,
	// Token: 0x040019EE RID: 6638
	WorldMapPositionChanged,
	// Token: 0x040019EF RID: 6639
	WorldMapUpdateMultiMap,
	// Token: 0x040019F0 RID: 6640
	WorldMapScaleTierChanged,
	// Token: 0x040019F1 RID: 6641
	OnTreasureChestCountChanged,
	// Token: 0x040019F2 RID: 6642
	MoveWorldMapToPosition,
	// Token: 0x040019F3 RID: 6643
	TaskRangeTrackStateChange,
	// Token: 0x040019F4 RID: 6644
	RangeTrackStateChanged,
	// Token: 0x040019F5 RID: 6645
	GetAreaProgress,
	// Token: 0x040019F6 RID: 6646
	PlaySoundTrackEffect,
	// Token: 0x040019F7 RID: 6647
	WorldMapNavigate,
	// Token: 0x040019F8 RID: 6648
	WorldMapFirstNavigateSelect,
	// Token: 0x040019F9 RID: 6649
	WorldMapSecondNavigateSelect,
	// Token: 0x040019FA RID: 6650
	WorldMapFocalMarkItem,
	// Token: 0x040019FB RID: 6651
	ChangeWorldMap,
	// Token: 0x040019FC RID: 6652
	WorldMapBeforeChangeMap,
	// Token: 0x040019FD RID: 6653
	WorldMapAfterChangeMap,
	// Token: 0x040019FE RID: 6654
	WorldMapOpenedForQuestMapFocus,
	// Token: 0x040019FF RID: 6655
	EnterAreaNotify,
	// Token: 0x04001A00 RID: 6656
	MiniMapForceUpdate,
	// Token: 0x04001A01 RID: 6657
	MultiMapUnlockChanged,
	// Token: 0x04001A02 RID: 6658
	MapAreaShowClickArea,
	// Token: 0x04001A03 RID: 6659
	MapExploreDetailItemClick,
	// Token: 0x04001A04 RID: 6660
	OnUpdateExploreProgressBar,
	// Token: 0x04001A05 RID: 6661
	OnUpdateGravityBtn,
	// Token: 0x04001A06 RID: 6662
	OnMarkTopRightIconUpdate,
	// Token: 0x04001A07 RID: 6663
	WorldMapActivityListDataUpdate,
	// Token: 0x04001A08 RID: 6664
	WorldMapExtraMarkTypeVisibleChange,
	// Token: 0x04001A09 RID: 6665
	OpenExtraUiFromMap,
	// Token: 0x04001A0A RID: 6666
	CloseAllExtraUiFromMap,
	// Token: 0x04001A0B RID: 6667
	WorldMapPanelHudVisibleChanged,
	// Token: 0x04001A0C RID: 6668
	OnWorldMapClose,
	// Token: 0x04001A0D RID: 6669
	SetWorldMapCursorButtonVisible,
	// Token: 0x04001A0E RID: 6670
	UpdatePlotSubtitle,
	// Token: 0x04001A0F RID: 6671
	ShowPlotSubtitleOptions,
	// Token: 0x04001A10 RID: 6672
	UpdatePlotCenterText,
	// Token: 0x04001A11 RID: 6673
	UpdatePortraitVisible,
	// Token: 0x04001A12 RID: 6674
	OnStartFlow,
	// Token: 0x04001A13 RID: 6675
	PlotNetworkStart,
	// Token: 0x04001A14 RID: 6676
	PlotNetworkEnd,
	// Token: 0x04001A15 RID: 6677
	OnExecuteAfterSetPlotMode,
	// Token: 0x04001A16 RID: 6678
	PlotConfigChanged,
	// Token: 0x04001A17 RID: 6679
	PlotDoingTextShow,
	// Token: 0x04001A18 RID: 6680
	ClearPlotSubtitle,
	// Token: 0x04001A19 RID: 6681
	HidePlotUi,
	// Token: 0x04001A1A RID: 6682
	PlotInteractViewOpen,
	// Token: 0x04001A1B RID: 6683
	TriggerPlotInteraction,
	// Token: 0x04001A1C RID: 6684
	TriggerBlackSequence,
	// Token: 0x04001A1D RID: 6685
	OnBlackFadeScreenStart,
	// Token: 0x04001A1E RID: 6686
	OnBlackFadeScreenFinish,
	// Token: 0x04001A1F RID: 6687
	EnableInteractPlot,
	// Token: 0x04001A20 RID: 6688
	EnableSkipPlot,
	// Token: 0x04001A21 RID: 6689
	EnableSkipPlotByReason,
	// Token: 0x04001A22 RID: 6690
	PlotSequencePlay,
	// Token: 0x04001A23 RID: 6691
	PlotSequenceStarted,
	// Token: 0x04001A24 RID: 6692
	PlotSequenceEnd,
	// Token: 0x04001A25 RID: 6693
	HangPlotViewHud,
	// Token: 0x04001A26 RID: 6694
	UpdatePlotUiParam,
	// Token: 0x04001A27 RID: 6695
	PlotViewChange,
	// Token: 0x04001A28 RID: 6696
	PlotViewBgFadePhoto,
	// Token: 0x04001A29 RID: 6697
	PlotViewBgFadeBlackScreen,
	// Token: 0x04001A2A RID: 6698
	PlotStartShowTalk,
	// Token: 0x04001A2B RID: 6699
	PlotEndShowTalk,
	// Token: 0x04001A2C RID: 6700
	PlotShowTalk,
	// Token: 0x04001A2D RID: 6701
	PlotEnableControlView,
	// Token: 0x04001A2E RID: 6702
	PlayPlotSpine,
	// Token: 0x04001A2F RID: 6703
	FiniteSpineEnd,
	// Token: 0x04001A30 RID: 6704
	PrewarFormationChanged,
	// Token: 0x04001A31 RID: 6705
	PrewarReadyChanged,
	// Token: 0x04001A32 RID: 6706
	DissolvePrewar,
	// Token: 0x04001A33 RID: 6707
	SceneStepGroupChanged,
	// Token: 0x04001A34 RID: 6708
	InstanceStepChanged,
	// Token: 0x04001A35 RID: 6709
	InstanceEnterCountChanged,
	// Token: 0x04001A36 RID: 6710
	InstanceEntranceUnlock,
	// Token: 0x04001A37 RID: 6711
	EnterInstanceDungeon,
	// Token: 0x04001A38 RID: 6712
	EnterInstanceDungeonFail,
	// Token: 0x04001A39 RID: 6713
	LeaveInstanceDungeon,
	// Token: 0x04001A3A RID: 6714
	DungeonGuideChange,
	// Token: 0x04001A3B RID: 6715
	LeaveInstanceDungeonConfirm,
	// Token: 0x04001A3C RID: 6716
	LeaveInstanceExternalConfirm,
	// Token: 0x04001A3D RID: 6717
	LeaveInstanceExternalCancel,
	// Token: 0x04001A3E RID: 6718
	OnRefreshInstancedRecommendLevel,
	// Token: 0x04001A3F RID: 6719
	OnDungeonFinish,
	// Token: 0x04001A40 RID: 6720
	OnSelectInstance,
	// Token: 0x04001A41 RID: 6721
	OnSelectInstanceIdChallenge,
	// Token: 0x04001A42 RID: 6722
	OnChallengeInstanceRedDot,
	// Token: 0x04001A43 RID: 6723
	CloseInstanceEntrancePositively,
	// Token: 0x04001A44 RID: 6724
	OnRefreshEditBattleRoleReady,
	// Token: 0x04001A45 RID: 6725
	EntityVisionSkillChanged,
	// Token: 0x04001A46 RID: 6726
	EntityVisionPosChanged,
	// Token: 0x04001A47 RID: 6727
	GetAllVisionSkill,
	// Token: 0x04001A48 RID: 6728
	ActivateAbilityVision,
	// Token: 0x04001A49 RID: 6729
	EndVisionSkill,
	// Token: 0x04001A4A RID: 6730
	ExploreVisionSkill,
	// Token: 0x04001A4B RID: 6731
	VisionMorphBegin,
	// Token: 0x04001A4C RID: 6732
	VisionMorphEnd,
	// Token: 0x04001A4D RID: 6733
	VisionMorphInterrupt,
	// Token: 0x04001A4E RID: 6734
	AddExploreVisionSkill,
	// Token: 0x04001A4F RID: 6735
	ChangeVisionSkillByTab,
	// Token: 0x04001A50 RID: 6736
	ChangeVisionSimplyState,
	// Token: 0x04001A51 RID: 6737
	VisionSkinViewClose,
	// Token: 0x04001A52 RID: 6738
	ChangeCalabashCollectSimplyState,
	// Token: 0x04001A53 RID: 6739
	SelectedPhantom,
	// Token: 0x04001A54 RID: 6740
	CheckNewUnlock,
	// Token: 0x04001A55 RID: 6741
	PhantomEquip,
	// Token: 0x04001A56 RID: 6742
	PhantomEquipError,
	// Token: 0x04001A57 RID: 6743
	VisionFilterMonster,
	// Token: 0x04001A58 RID: 6744
	OnRolePropUpdate,
	// Token: 0x04001A59 RID: 6745
	RefreshVisionIntensifyViewBackBtnState,
	// Token: 0x04001A5A RID: 6746
	OnClickVisionIntensifyItemJump,
	// Token: 0x04001A5B RID: 6747
	VisionIntensifyTabOpen,
	// Token: 0x04001A5C RID: 6748
	OnVisionLevelUpMaterialPutInModeChange,
	// Token: 0x04001A5D RID: 6749
	OnVisionLevelUpIdentifyChange,
	// Token: 0x04001A5E RID: 6750
	PhantomPersonalSkillActive,
	// Token: 0x04001A5F RID: 6751
	PhantomEquipWithSourceAndTargetPos,
	// Token: 0x04001A60 RID: 6752
	PhantomCostInsufficient,
	// Token: 0x04001A61 RID: 6753
	PhantomExpPreviewChange,
	// Token: 0x04001A62 RID: 6754
	PhantomLevelUp,
	// Token: 0x04001A63 RID: 6755
	PhantomLevelUpWithId,
	// Token: 0x04001A64 RID: 6756
	PhantomLevelUpReceiveItem,
	// Token: 0x04001A65 RID: 6757
	CloseSubPhantomView,
	// Token: 0x04001A66 RID: 6758
	PhantomBreach,
	// Token: 0x04001A67 RID: 6759
	PhantomBreachPreview,
	// Token: 0x04001A68 RID: 6760
	PhantomDecomposePreview,
	// Token: 0x04001A69 RID: 6761
	PhantomDecompose,
	// Token: 0x04001A6A RID: 6762
	PhantomMaxLevelSkip,
	// Token: 0x04001A6B RID: 6763
	HideDelFettersText,
	// Token: 0x04001A6C RID: 6764
	PhantomRecommendResponse,
	// Token: 0x04001A6D RID: 6765
	ClosePhantomSkillTips,
	// Token: 0x04001A6E RID: 6766
	OnPhantomItemUpdate,
	// Token: 0x04001A6F RID: 6767
	OnPhantomSlotUpdate,
	// Token: 0x04001A70 RID: 6768
	OnPhantomEnableStateChange,
	// Token: 0x04001A71 RID: 6769
	OnVisionIdentify,
	// Token: 0x04001A72 RID: 6770
	OnVisionIdentifyWithId,
	// Token: 0x04001A73 RID: 6771
	OnVisionIdentifyDoAnimation,
	// Token: 0x04001A74 RID: 6772
	RefreshVisionIdentifyRedPoint,
	// Token: 0x04001A75 RID: 6773
	RefreshVisionLevelUpSettingRedPoint,
	// Token: 0x04001A76 RID: 6774
	RefreshVisionEquipRedPoint,
	// Token: 0x04001A77 RID: 6775
	JumpToCalabashCollect,
	// Token: 0x04001A78 RID: 6776
	JumpToPhantomBattleFettersTabView,
	// Token: 0x04001A79 RID: 6777
	OnVisionSkinEquip,
	// Token: 0x04001A7A RID: 6778
	RedDotRefreshCalabash,
	// Token: 0x04001A7B RID: 6779
	HasCalabashExp,
	// Token: 0x04001A7C RID: 6780
	CloseUpgradeCalabashView,
	// Token: 0x04001A7D RID: 6781
	CloseCalabashExpAddView,
	// Token: 0x04001A7E RID: 6782
	ShowCalabashControllerView,
	// Token: 0x04001A7F RID: 6783
	GetCalabashRewardSuccess,
	// Token: 0x04001A80 RID: 6784
	ShowCalabashUnlockItemTips,
	// Token: 0x04001A81 RID: 6785
	GetCalabashReward,
	// Token: 0x04001A82 RID: 6786
	SelectDirectionalFusionTarget,
	// Token: 0x04001A83 RID: 6787
	PhantomDirectRefiningWeeklyReset,
	// Token: 0x04001A84 RID: 6788
	CalabashLevelUpdate,
	// Token: 0x04001A85 RID: 6789
	CalabashEnterInternalView,
	// Token: 0x04001A86 RID: 6790
	CalabashQuitInternalView,
	// Token: 0x04001A87 RID: 6791
	OnVisionRecoveryResult,
	// Token: 0x04001A88 RID: 6792
	OnVisionRecoveryBatchResult,
	// Token: 0x04001A89 RID: 6793
	OnVisionRecoveryStorage,
	// Token: 0x04001A8A RID: 6794
	OnVisionRefineStorage,
	// Token: 0x04001A8B RID: 6795
	OnVisionRefineResult,
	// Token: 0x04001A8C RID: 6796
	OnVisionRefineBatchMainResult,
	// Token: 0x04001A8D RID: 6797
	OnVisionRefineSubPreviewResult,
	// Token: 0x04001A8E RID: 6798
	OnVisionRefineSubResult,
	// Token: 0x04001A8F RID: 6799
	OnVisionRefineSubNeedAck,
	// Token: 0x04001A90 RID: 6800
	OnVisionGroupDataUpdate,
	// Token: 0x04001A91 RID: 6801
	OnVisionGroupDataAdd,
	// Token: 0x04001A92 RID: 6802
	OnVisionGroupDataToTop,
	// Token: 0x04001A93 RID: 6803
	OnVisionGroupDataDelete,
	// Token: 0x04001A94 RID: 6804
	OnVisionGroupDataChangeName,
	// Token: 0x04001A95 RID: 6805
	OnRefreshCalabashTabShowState,
	// Token: 0x04001A96 RID: 6806
	OnSetPartStateVisible,
	// Token: 0x04001A97 RID: 6807
	ShowHUD,
	// Token: 0x04001A98 RID: 6808
	HideHUD,
	// Token: 0x04001A99 RID: 6809
	OnGetPlayerBasicInfo,
	// Token: 0x04001A9A RID: 6810
	OnLoadedNewFlagConfig,
	// Token: 0x04001A9B RID: 6811
	OnPlayerLevelChanged,
	// Token: 0x04001A9C RID: 6812
	OnPlayerExpChanged,
	// Token: 0x04001A9D RID: 6813
	OnLevelUpLevelRefresh,
	// Token: 0x04001A9E RID: 6814
	OnLevelUpExpRefresh,
	// Token: 0x04001A9F RID: 6815
	OnLevelUpShowLevelOnly,
	// Token: 0x04001AA0 RID: 6816
	SelectFilterMultiple,
	// Token: 0x04001AA1 RID: 6817
	SelectFilterSingle,
	// Token: 0x04001AA2 RID: 6818
	SelectSort,
	// Token: 0x04001AA3 RID: 6819
	OnLevelPlayStateNotify,
	// Token: 0x04001AA4 RID: 6820
	OnEnterLevelPlayNotify,
	// Token: 0x04001AA5 RID: 6821
	OnLeaveLevelPlayNotify,
	// Token: 0x04001AA6 RID: 6822
	OnSceneItemHit,
	// Token: 0x04001AA7 RID: 6823
	OnSceneItemHitByHitData,
	// Token: 0x04001AA8 RID: 6824
	OnSceneItemEntityHit,
	// Token: 0x04001AA9 RID: 6825
	OnSceneItemEntityHitByHitActorData,
	// Token: 0x04001AAA RID: 6826
	OnSceneItemEntityHitAlways,
	// Token: 0x04001AAB RID: 6827
	OnAnySceneItemEntityHit,
	// Token: 0x04001AAC RID: 6828
	OnAnySceneItemDurabilityChange,
	// Token: 0x04001AAD RID: 6829
	OnSceneItemDurabilityChange,
	// Token: 0x04001AAE RID: 6830
	OnEnableSceneItemDurabilityUI,
	// Token: 0x04001AAF RID: 6831
	OnSceneItemSwitchMoveControl,
	// Token: 0x04001AB0 RID: 6832
	UpdateSceneItemState,
	// Token: 0x04001AB1 RID: 6833
	OnSceneItemDurabilityEmpty,
	// Token: 0x04001AB2 RID: 6834
	OnSceneItemStateChange,
	// Token: 0x04001AB3 RID: 6835
	OnSceneItemStatePreChange,
	// Token: 0x04001AB4 RID: 6836
	OnSceneItemStatePreChangeInSequence,
	// Token: 0x04001AB5 RID: 6837
	OnSceneItemCameraAlertStateChange,
	// Token: 0x04001AB6 RID: 6838
	OnEntityConcealedChange,
	// Token: 0x04001AB7 RID: 6839
	OnEntityNameChanged,
	// Token: 0x04001AB8 RID: 6840
	OnTimeTrackControlUpdate,
	// Token: 0x04001AB9 RID: 6841
	OnSceneInteractionLoadCompleted,
	// Token: 0x04001ABA RID: 6842
	OnSceneInteractionLoadCompletedNew,
	// Token: 0x04001ABB RID: 6843
	OnSceneInteractionShowCompleted,
	// Token: 0x04001ABC RID: 6844
	OnSceneInteractionHideCompleted,
	// Token: 0x04001ABD RID: 6845
	OnSceneInteractionAllEffectPlaying,
	// Token: 0x04001ABE RID: 6846
	OnSceneInteractionSequencePlay,
	// Token: 0x04001ABF RID: 6847
	OnSceneInteractionSequenceOver,
	// Token: 0x04001AC0 RID: 6848
	OnSceneInteractionStateReached,
	// Token: 0x04001AC1 RID: 6849
	OnSceneItemVisionCaptureAdd,
	// Token: 0x04001AC2 RID: 6850
	OnSceneItemVisionCaptureRemove,
	// Token: 0x04001AC3 RID: 6851
	OnSceneItemVisionCaptureAddFinish,
	// Token: 0x04001AC4 RID: 6852
	ShowItemTips,
	// Token: 0x04001AC5 RID: 6853
	OnInputDistributeTagChanged,
	// Token: 0x04001AC6 RID: 6854
	OnDeviceLangChange,
	// Token: 0x04001AC7 RID: 6855
	ForceReleaseInput,
	// Token: 0x04001AC8 RID: 6856
	GuideLimitActionInput,
	// Token: 0x04001AC9 RID: 6857
	OnFormationPlayLevelUp,
	// Token: 0x04001ACA RID: 6858
	OnFormationPlayRevive,
	// Token: 0x04001ACB RID: 6859
	OnItemUse,
	// Token: 0x04001ACC RID: 6860
	OnSpecialItemUse,
	// Token: 0x04001ACD RID: 6861
	OnLevelTagChanged,
	// Token: 0x04001ACE RID: 6862
	OnGlobalGameplayTagChanged,
	// Token: 0x04001ACF RID: 6863
	LevelEventTriggerExit,
	// Token: 0x04001AD0 RID: 6864
	OnLevelPlayStateChange,
	// Token: 0x04001AD1 RID: 6865
	OnLevelPlayCompleteNumberChange,
	// Token: 0x04001AD2 RID: 6866
	TodTimeChange,
	// Token: 0x04001AD3 RID: 6867
	DayStateChange,
	// Token: 0x04001AD4 RID: 6868
	CrossDay,
	// Token: 0x04001AD5 RID: 6869
	CrossDayZone,
	// Token: 0x04001AD6 RID: 6870
	CrossHour,
	// Token: 0x04001AD7 RID: 6871
	ClickTimeItem,
	// Token: 0x04001AD8 RID: 6872
	OnSelectTimeItem,
	// Token: 0x04001AD9 RID: 6873
	AdjustTime,
	// Token: 0x04001ADA RID: 6874
	AdjustTimeInAnim,
	// Token: 0x04001ADB RID: 6875
	PowerShopReady,
	// Token: 0x04001ADC RID: 6876
	OnPowerChanged,
	// Token: 0x04001ADD RID: 6877
	OnPowerChangedWithId,
	// Token: 0x04001ADE RID: 6878
	OnHonamiStoryBackpackUpdate,
	// Token: 0x04001ADF RID: 6879
	OnHonamiStoryLifeSupportLevelUp,
	// Token: 0x04001AE0 RID: 6880
	OnHonamiStoryLeaveButtonUpdate,
	// Token: 0x04001AE1 RID: 6881
	OnHonamiStoryPowerLevelUpdate,
	// Token: 0x04001AE2 RID: 6882
	OnHonamiStoryTechNodeLevelUpdate,
	// Token: 0x04001AE3 RID: 6883
	OnHonamiStoryItemCollectGetReward,
	// Token: 0x04001AE4 RID: 6884
	OnHonamiStoryMascotRewardReceive,
	// Token: 0x04001AE5 RID: 6885
	OnHonamiStoryAreaSecretRewardReceive,
	// Token: 0x04001AE6 RID: 6886
	OnHonamiStoryInstInfoUpdate,
	// Token: 0x04001AE7 RID: 6887
	OnHonamiStoryPollutionUpdate,
	// Token: 0x04001AE8 RID: 6888
	OnHonamiScanMarkInfoUpdate,
	// Token: 0x04001AE9 RID: 6889
	OnHonamiStoryPickUpAutoEquip,
	// Token: 0x04001AEA RID: 6890
	OnHonamiStorySortSuccess,
	// Token: 0x04001AEB RID: 6891
	OnHonamiStorySkillDescModeChange,
	// Token: 0x04001AEC RID: 6892
	OnHonamiStoryBackpackClickWeapon,
	// Token: 0x04001AED RID: 6893
	OnHonamiStorySetVisible,
	// Token: 0x04001AEE RID: 6894
	OnGamePlayCdChanged,
	// Token: 0x04001AEF RID: 6895
	InsertFloatTips,
	// Token: 0x04001AF0 RID: 6896
	RemoveFloatTips,
	// Token: 0x04001AF1 RID: 6897
	OriginWorldLevelUp,
	// Token: 0x04001AF2 RID: 6898
	CurWorldLevelChange,
	// Token: 0x04001AF3 RID: 6899
	WorldLevelUpViewRefresh,
	// Token: 0x04001AF4 RID: 6900
	OnShowMouseCursor,
	// Token: 0x04001AF5 RID: 6901
	RefreshCursor,
	// Token: 0x04001AF6 RID: 6902
	MoveCursorToRightDown,
	// Token: 0x04001AF7 RID: 6903
	InputDistribute,
	// Token: 0x04001AF8 RID: 6904
	OnRefreshJoinTeamRole,
	// Token: 0x04001AF9 RID: 6905
	LoadLguiEventSystemActor,
	// Token: 0x04001AFA RID: 6906
	InitializeLguiEventSystemActor,
	// Token: 0x04001AFB RID: 6907
	DestroyLguiEventSystemActor,
	// Token: 0x04001AFC RID: 6908
	OnUseBuffItem,
	// Token: 0x04001AFD RID: 6909
	OnEquipBuffItemUpdate,
	// Token: 0x04001AFE RID: 6910
	UpdateQuestDetails,
	// Token: 0x04001AFF RID: 6911
	UpdateQuestListAndDetails,
	// Token: 0x04001B00 RID: 6912
	UpdateRoleQuestDetails,
	// Token: 0x04001B01 RID: 6913
	QuestUpdateInfoAdd,
	// Token: 0x04001B02 RID: 6914
	AddInteractOptionByAction,
	// Token: 0x04001B03 RID: 6915
	RemoveInteractOptionByAction,
	// Token: 0x04001B04 RID: 6916
	OnQuestStateChange,
	// Token: 0x04001B05 RID: 6917
	OnQuestFinishListNotify,
	// Token: 0x04001B06 RID: 6918
	OnQuestRedDotStateChange,
	// Token: 0x04001B07 RID: 6919
	OnQuestFinishProtocolEnd,
	// Token: 0x04001B08 RID: 6920
	OnRoleQuestAccept,
	// Token: 0x04001B09 RID: 6921
	OnRoleQuestPointChange,
	// Token: 0x04001B0A RID: 6922
	OnRoleQuestNewUnlock,
	// Token: 0x04001B0B RID: 6923
	OnAddNewQuest,
	// Token: 0x04001B0C RID: 6924
	OnNavigationQuest,
	// Token: 0x04001B0D RID: 6925
	ActivityQuestCountdownEnd,
	// Token: 0x04001B0E RID: 6926
	OnQuestStageNameChange,
	// Token: 0x04001B0F RID: 6927
	FocusQuestChange,
	// Token: 0x04001B10 RID: 6928
	LevelGamePlayPrepareCountDownEnd,
	// Token: 0x04001B11 RID: 6929
	GeneralLogicTreeWakeUp,
	// Token: 0x04001B12 RID: 6930
	OnLogicTreeNodeStatusChange,
	// Token: 0x04001B13 RID: 6931
	OnLogicTreeChildQuestNodeStatusChange,
	// Token: 0x04001B14 RID: 6932
	AfterLogicTreeChildQuestNodeStatusChange,
	// Token: 0x04001B15 RID: 6933
	OnLogicTreeNodeProgressChange,
	// Token: 0x04001B16 RID: 6934
	GeneralLogicTreeTimerInfoChanged,
	// Token: 0x04001B17 RID: 6935
	OnGeneralLogicTreeTimerUpdate,
	// Token: 0x04001B18 RID: 6936
	OnLogicTreeTrackUpdate,
	// Token: 0x04001B19 RID: 6937
	CurTrackQuestUnTrackedCheck,
	// Token: 0x04001B1A RID: 6938
	OnLogicTreeTimerTick,
	// Token: 0x04001B1B RID: 6939
	GeneralLogicTreeStartShowTrackText,
	// Token: 0x04001B1C RID: 6940
	GeneralLogicTreeUpdateShowTrackText,
	// Token: 0x04001B1D RID: 6941
	GeneralLogicTreeEndShowTrackText,
	// Token: 0x04001B1E RID: 6942
	TearDownGeneralLogicTree,
	// Token: 0x04001B1F RID: 6943
	GeneralLogicTreeSuspend,
	// Token: 0x04001B20 RID: 6944
	GeneralLogicTreeCancelSuspend,
	// Token: 0x04001B21 RID: 6945
	GeneralLogicTreePrepareRollback,
	// Token: 0x04001B22 RID: 6946
	GeneralLogicTreePrepareRollbackFinish,
	// Token: 0x04001B23 RID: 6947
	GeneralLogicTreeRemovePrepareRollbackNode,
	// Token: 0x04001B24 RID: 6948
	GeneralLogicTreeRollbackWaitingUpdate,
	// Token: 0x04001B25 RID: 6949
	GeneralLogicTreeEntityInteractFinished,
	// Token: 0x04001B26 RID: 6950
	GeneralLogicTreeEntityKilled,
	// Token: 0x04001B27 RID: 6951
	GeneralLogicTreeAddTag,
	// Token: 0x04001B28 RID: 6952
	GeneralLogicTreeRemoveTag,
	// Token: 0x04001B29 RID: 6953
	GeneralLogicTreeViewForceRefresh,
	// Token: 0x04001B2A RID: 6954
	GeneralLogicTreeApplyExpressionOccupation,
	// Token: 0x04001B2B RID: 6955
	GeneralLogicTreeReleaseExpressionOccupation,
	// Token: 0x04001B2C RID: 6956
	GeneralLogicTreeOccupationInfoChanged,
	// Token: 0x04001B2D RID: 6957
	QuestUpdateTipsClickTrack,
	// Token: 0x04001B2E RID: 6958
	QuestUpdateTipsEndSequenceStart,
	// Token: 0x04001B2F RID: 6959
	MissionTrackRuleChange,
	// Token: 0x04001B30 RID: 6960
	MissionPanelOut,
	// Token: 0x04001B31 RID: 6961
	MissionUpdate,
	// Token: 0x04001B32 RID: 6962
	MissionPanelStepTitleAnimStart,
	// Token: 0x04001B33 RID: 6963
	MissionPanelStepTitleAnimEnd,
	// Token: 0x04001B34 RID: 6964
	MissionPanelStepConditionIndexChange,
	// Token: 0x04001B35 RID: 6965
	FailRangeTimerStartShow,
	// Token: 0x04001B36 RID: 6966
	FailRangeTimerEndShow,
	// Token: 0x04001B37 RID: 6967
	OnCreateBehaviorTree,
	// Token: 0x04001B38 RID: 6968
	OnGeneralLogicTreeRemove,
	// Token: 0x04001B39 RID: 6969
	ParkourFinished,
	// Token: 0x04001B3A RID: 6970
	HudInited,
	// Token: 0x04001B3B RID: 6971
	OnOpenDebugCommand,
	// Token: 0x04001B3C RID: 6972
	OnResetToBattleView,
	// Token: 0x04001B3D RID: 6973
	ResetModuleByResetToBattleView,
	// Token: 0x04001B3E RID: 6974
	ResetModuleAfterResetToBattleView,
	// Token: 0x04001B3F RID: 6975
	ExitNormalQueueState,
	// Token: 0x04001B40 RID: 6976
	OnStartLoadingState,
	// Token: 0x04001B41 RID: 6977
	OnFinishLoadingState,
	// Token: 0x04001B42 RID: 6978
	OnOpenLoadingView,
	// Token: 0x04001B43 RID: 6979
	OnCloseLoadingView,
	// Token: 0x04001B44 RID: 6980
	OnLoadingNetDataDone,
	// Token: 0x04001B45 RID: 6981
	PlayUiComponentCloseTween,
	// Token: 0x04001B46 RID: 6982
	ChangeUiComponentMarkId,
	// Token: 0x04001B47 RID: 6983
	OnMenuDataEnableChanged,
	// Token: 0x04001B48 RID: 6984
	OnSelectMenuMainType,
	// Token: 0x04001B49 RID: 6985
	ChangeConfigValue,
	// Token: 0x04001B4A RID: 6986
	RestartFlag,
	// Token: 0x04001B4B RID: 6987
	SettingFrameRateChanged,
	// Token: 0x04001B4C RID: 6988
	TextLanguageChange,
	// Token: 0x04001B4D RID: 6989
	UiPureModeChangedForSettingSystem,
	// Token: 0x04001B4E RID: 6990
	ConfigLoadChange,
	// Token: 0x04001B4F RID: 6991
	AutoMovingSettingChanged,
	// Token: 0x04001B50 RID: 6992
	AutoSprintSettingChanged,
	// Token: 0x04001B51 RID: 6993
	MotorcycleWaterAreaChange,
	// Token: 0x04001B52 RID: 6994
	MotorcycleWaterDetectedStart2,
	// Token: 0x04001B53 RID: 6995
	MotorcycleWaterDetectedEnd2,
	// Token: 0x04001B54 RID: 6996
	MotorcycleWaterDetectedTick2,
	// Token: 0x04001B55 RID: 6997
	MotorcycleBaseMovementChanged,
	// Token: 0x04001B56 RID: 6998
	MotorcycleAutoAcceleratorSettingChanged,
	// Token: 0x04001B57 RID: 6999
	MotorcycleAutoNitrogenSettingChanged,
	// Token: 0x04001B58 RID: 7000
	MotorcycleDriftAcceleratorSettingChanged,
	// Token: 0x04001B59 RID: 7001
	SneakResult,
	// Token: 0x04001B5A RID: 7002
	SneakMonsterStart,
	// Token: 0x04001B5B RID: 7003
	SneakMonsterStop,
	// Token: 0x04001B5C RID: 7004
	ChannelReset,
	// Token: 0x04001B5D RID: 7005
	OnShareResult,
	// Token: 0x04001B5E RID: 7006
	OnFirstShare,
	// Token: 0x04001B5F RID: 7007
	ShowVideo,
	// Token: 0x04001B60 RID: 7008
	VideoStart,
	// Token: 0x04001B61 RID: 7009
	PlayVideo,
	// Token: 0x04001B62 RID: 7010
	VideoTriggerBlendOut,
	// Token: 0x04001B63 RID: 7011
	VideoViewShow,
	// Token: 0x04001B64 RID: 7012
	VideoViewHide,
	// Token: 0x04001B65 RID: 7013
	ScanTrackedStart,
	// Token: 0x04001B66 RID: 7014
	ScanTrackedEnd,
	// Token: 0x04001B67 RID: 7015
	OnScanStart,
	// Token: 0x04001B68 RID: 7016
	RedDotStart,
	// Token: 0x04001B69 RID: 7017
	RedDotRefreshItemData,
	// Token: 0x04001B6A RID: 7018
	RedDotRoleConfigList,
	// Token: 0x04001B6B RID: 7019
	RedDotRefreshPhantomEquip,
	// Token: 0x04001B6C RID: 7020
	RedDotRoleChange,
	// Token: 0x04001B6D RID: 7021
	RedDotUnLockPhantom,
	// Token: 0x04001B6E RID: 7022
	RedDotNewTutorial,
	// Token: 0x04001B6F RID: 7023
	RedDotNewTutorialType,
	// Token: 0x04001B70 RID: 7024
	RedDotAdventureManualUpdate,
	// Token: 0x04001B71 RID: 7025
	RedDotSilentFirstAward,
	// Token: 0x04001B72 RID: 7026
	RedDotSilentFirstAwardCategory,
	// Token: 0x04001B73 RID: 7027
	RedDotSilentFirstAwardResult,
	// Token: 0x04001B74 RID: 7028
	RedDotCreateRole,
	// Token: 0x04001B75 RID: 7029
	RouletteRefreshNew,
	// Token: 0x04001B76 RID: 7030
	RedDotFilter,
	// Token: 0x04001B77 RID: 7031
	RedDotPhotoSetup,
	// Token: 0x04001B78 RID: 7032
	OnServerStorageInfoInited,
	// Token: 0x04001B79 RID: 7033
	SilentTipsRefresh,
	// Token: 0x04001B7A RID: 7034
	OnRefreshElementBallData,
	// Token: 0x04001B7B RID: 7035
	ShootTargetStateChanged,
	// Token: 0x04001B7C RID: 7036
	InteractNavigation,
	// Token: 0x04001B7D RID: 7037
	InteractionViewUpdate,
	// Token: 0x04001B7E RID: 7038
	HideInteractView,
	// Token: 0x04001B7F RID: 7039
	OnInteractViewVisibleChanged,
	// Token: 0x04001B80 RID: 7040
	SceneItemInteractionEvent,
	// Token: 0x04001B81 RID: 7041
	OnFunctionOpenSet,
	// Token: 0x04001B82 RID: 7042
	OnFunctionOpenUpdate,
	// Token: 0x04001B83 RID: 7043
	OnFunctionOpenUpdateNotify,
	// Token: 0x04001B84 RID: 7044
	OnConcertoResponseOpen,
	// Token: 0x04001B85 RID: 7045
	OnFirstOpenShopChanged,
	// Token: 0x04001B86 RID: 7046
	OnSetHeadStateVisible,
	// Token: 0x04001B87 RID: 7047
	OnSetBossStateVisible,
	// Token: 0x04001B88 RID: 7048
	SdkKick,
	// Token: 0x04001B89 RID: 7049
	SdkPostWebViewRedPointRefresh,
	// Token: 0x04001B8A RID: 7050
	SdkCustomerRedPointRefresh,
	// Token: 0x04001B8B RID: 7051
	SdkIntroductionRedPointRefresh,
	// Token: 0x04001B8C RID: 7052
	UpdateFriendViewShow,
	// Token: 0x04001B8D RID: 7053
	UpdateRecentlyTeamDataEvent,
	// Token: 0x04001B8E RID: 7054
	OnRemoveFriend,
	// Token: 0x04001B8F RID: 7055
	FriendApplicationListUpdate,
	// Token: 0x04001B90 RID: 7056
	UpdateBlackListShow,
	// Token: 0x04001B91 RID: 7057
	SearchPlayerInfo,
	// Token: 0x04001B92 RID: 7058
	FriendRemarkLengthLimit,
	// Token: 0x04001B93 RID: 7059
	FriendRemarkContainsDirtyWord,
	// Token: 0x04001B94 RID: 7060
	RefreshFriendApplicationRedDot,
	// Token: 0x04001B95 RID: 7061
	FriendApplyReceived,
	// Token: 0x04001B96 RID: 7062
	FriendAdded,
	// Token: 0x04001B97 RID: 7063
	LoadTestFriendsByGm,
	// Token: 0x04001B98 RID: 7064
	ApplicationHandled,
	// Token: 0x04001B99 RID: 7065
	ApplicationSent,
	// Token: 0x04001B9A RID: 7066
	OnGetFriendInitData,
	// Token: 0x04001B9B RID: 7067
	FriendOnMultiItemAction,
	// Token: 0x04001B9C RID: 7068
	UpdateNavigationListener,
	// Token: 0x04001B9D RID: 7069
	OnVisionAssembleNavigationRefresh,
	// Token: 0x04001B9E RID: 7070
	InputControllerChange,
	// Token: 0x04001B9F RID: 7071
	InputControllerMainTypeChange,
	// Token: 0x04001BA0 RID: 7072
	ShowTypeChange,
	// Token: 0x04001BA1 RID: 7073
	PointerInputTypeChange,
	// Token: 0x04001BA2 RID: 7074
	ControllerConnectChange,
	// Token: 0x04001BA3 RID: 7075
	ChangeScrollBarPosition,
	// Token: 0x04001BA4 RID: 7076
	RefreshGuest,
	// Token: 0x04001BA5 RID: 7077
	ShowGuestEffect,
	// Token: 0x04001BA6 RID: 7078
	OnSelectChatFriend,
	// Token: 0x04001BA7 RID: 7079
	OnCreatePrivateChatRoom,
	// Token: 0x04001BA8 RID: 7080
	OnJoinChatRoom,
	// Token: 0x04001BA9 RID: 7081
	OnAddChatContent,
	// Token: 0x04001BAA RID: 7082
	OnRefreshChatRedDot,
	// Token: 0x04001BAB RID: 7083
	OnRefreshChatRoomRedDot,
	// Token: 0x04001BAC RID: 7084
	OnAddHistoryChatContentCompleted,
	// Token: 0x04001BAD RID: 7085
	OnPushChatRowData,
	// Token: 0x04001BAE RID: 7086
	OnPopChatRowData,
	// Token: 0x04001BAF RID: 7087
	OnRefreshChatRowData,
	// Token: 0x04001BB0 RID: 7088
	OnAddMutePlayer,
	// Token: 0x04001BB1 RID: 7089
	OnRemoveMutePlayer,
	// Token: 0x04001BB2 RID: 7090
	OnRemovePrivateChatRoom,
	// Token: 0x04001BB3 RID: 7091
	OnClosePrivateChatRoom,
	// Token: 0x04001BB4 RID: 7092
	OnOpenChatRoom,
	// Token: 0x04001BB5 RID: 7093
	OnSelectExpression,
	// Token: 0x04001BB6 RID: 7094
	OnServerAttributeChange,
	// Token: 0x04001BB7 RID: 7095
	OnPayItemSuccess,
	// Token: 0x04001BB8 RID: 7096
	RefreshPayItemList,
	// Token: 0x04001BB9 RID: 7097
	RefreshPayGiftList,
	// Token: 0x04001BBA RID: 7098
	OnPlayerCurrencyChange,
	// Token: 0x04001BBB RID: 7099
	OnRefreshPermissionsSetting,
	// Token: 0x04001BBC RID: 7100
	OnRefreshApply,
	// Token: 0x04001BBD RID: 7101
	OnSearchWorld,
	// Token: 0x04001BBE RID: 7102
	OnRefreshWorldList,
	// Token: 0x04001BBF RID: 7103
	OnRefreshOnlineTeamList,
	// Token: 0x04001BC0 RID: 7104
	OnWorldTeamPlayerInfoChanged,
	// Token: 0x04001BC1 RID: 7105
	OnRefreshPlayerPing,
	// Token: 0x04001BC2 RID: 7106
	OnRefreshPlayerUiState,
	// Token: 0x04001BC3 RID: 7107
	OnRefreshOnlineChallengePlayer,
	// Token: 0x04001BC4 RID: 7108
	OnRefreshSuggestChallengePlayerInfo,
	// Token: 0x04001BC5 RID: 7109
	SwitchPayShopTabItem,
	// Token: 0x04001BC6 RID: 7110
	PayShopGoodsBuy,
	// Token: 0x04001BC7 RID: 7111
	GoodsRefreshDiscountTime,
	// Token: 0x04001BC8 RID: 7112
	SwitchPayShopView,
	// Token: 0x04001BC9 RID: 7113
	RefreshPayShop,
	// Token: 0x04001BCA RID: 7114
	RefreshAllPayShop,
	// Token: 0x04001BCB RID: 7115
	RefreshGoods,
	// Token: 0x04001BCC RID: 7116
	RefreshShopAccumulateCurrency,
	// Token: 0x04001BCD RID: 7117
	ShopVersionCodeChange,
	// Token: 0x04001BCE RID: 7118
	GoodsSoldOut,
	// Token: 0x04001BCF RID: 7119
	RefreshGoodsList,
	// Token: 0x04001BD0 RID: 7120
	UnLockGoods,
	// Token: 0x04001BD1 RID: 7121
	RefreshPayShopEntranceRedDot,
	// Token: 0x04001BD2 RID: 7122
	RefreshPayShopInstanceRedDot,
	// Token: 0x04001BD3 RID: 7123
	RefreshPayShopTabRedDot,
	// Token: 0x04001BD4 RID: 7124
	DiscountShopTimerRefresh,
	// Token: 0x04001BD5 RID: 7125
	TryRefreshRootShopMoney,
	// Token: 0x04001BD6 RID: 7126
	OnOpenGachaChanged,
	// Token: 0x04001BD7 RID: 7127
	OnOpenCommonWeaponSelect,
	// Token: 0x04001BD8 RID: 7128
	RefreshGachaMainView,
	// Token: 0x04001BD9 RID: 7129
	GachaPoolSelectResponse,
	// Token: 0x04001BDA RID: 7130
	GachaResponse,
	// Token: 0x04001BDB RID: 7131
	GachaHistoryResponse,
	// Token: 0x04001BDC RID: 7132
	CloseGachaSceneView,
	// Token: 0x04001BDD RID: 7133
	GachaNewNotify,
	// Token: 0x04001BDE RID: 7134
	EndGachaScene,
	// Token: 0x04001BDF RID: 7135
	GachaClick,
	// Token: 0x04001BE0 RID: 7136
	GachaSelectionViewRefresh,
	// Token: 0x04001BE1 RID: 7137
	AfterCloseGachaScene,
	// Token: 0x04001BE2 RID: 7138
	PlaySequenceEventByStringParam,
	// Token: 0x04001BE3 RID: 7139
	GachaInteractFinish,
	// Token: 0x04001BE4 RID: 7140
	ItemExChangeResponse,
	// Token: 0x04001BE5 RID: 7141
	GachaAccumulateDataUpdate,
	// Token: 0x04001BE6 RID: 7142
	GachaAccumulateRewardClaimed,
	// Token: 0x04001BE7 RID: 7143
	GachaAccumulateRedDot,
	// Token: 0x04001BE8 RID: 7144
	ItemHintVisibilityChange,
	// Token: 0x04001BE9 RID: 7145
	ShowAnimalsHeadInfo,
	// Token: 0x04001BEA RID: 7146
	OnAnimalDying,
	// Token: 0x04001BEB RID: 7147
	OnSkillButtonDataRefresh,
	// Token: 0x04001BEC RID: 7148
	OnSkillButtonDataClear,
	// Token: 0x04001BED RID: 7149
	OnSkillButtonIndexRefresh,
	// Token: 0x04001BEE RID: 7150
	OnSkillButtonEnableRefresh,
	// Token: 0x04001BEF RID: 7151
	OnSkillButtonVisibleRefresh,
	// Token: 0x04001BF0 RID: 7152
	OnSkillButtonSkillIdRefresh,
	// Token: 0x04001BF1 RID: 7153
	OnSkillButtonDynamicEffectRefresh,
	// Token: 0x04001BF2 RID: 7154
	OnSkillButtonCustomRefresh,
	// Token: 0x04001BF3 RID: 7155
	OnSkillButtonCdRefresh,
	// Token: 0x04001BF4 RID: 7156
	OnSkillButtonAttributeRefresh,
	// Token: 0x04001BF5 RID: 7157
	OnSkillButtonIconPathRefresh,
	// Token: 0x04001BF6 RID: 7158
	OnSkillButtonLongPressRefresh,
	// Token: 0x04001BF7 RID: 7159
	OnSkillButtonExtraEffectRefresh,
	// Token: 0x04001BF8 RID: 7160
	OnSkillButtonSlideControlRefresh,
	// Token: 0x04001BF9 RID: 7161
	OnBehaviorButtonEnableRefresh,
	// Token: 0x04001BFA RID: 7162
	OnBehaviorButtonVisibleRefresh,
	// Token: 0x04001BFB RID: 7163
	OnBehaviorButtonSkillIdRefresh,
	// Token: 0x04001BFC RID: 7164
	OnBehaviorButtonIconPathRefresh,
	// Token: 0x04001BFD RID: 7165
	OnBehaviorButtonDynamicEffectRefresh,
	// Token: 0x04001BFE RID: 7166
	OnAttributeLockUpperBoundChange,
	// Token: 0x04001BFF RID: 7167
	OnMotorPadSkillButtonIndexRefresh,
	// Token: 0x04001C00 RID: 7168
	OnInputChangeForCond,
	// Token: 0x04001C01 RID: 7169
	OnInputMoveChanged,
	// Token: 0x04001C02 RID: 7170
	OnFloatingMoveInputChanged,
	// Token: 0x04001C03 RID: 7171
	OnGetNewItem,
	// Token: 0x04001C04 RID: 7172
	OnElementFusion,
	// Token: 0x04001C05 RID: 7173
	OnChangeSelectedExploreId,
	// Token: 0x04001C06 RID: 7174
	OnRouletteViewVisibleChanged,
	// Token: 0x04001C07 RID: 7175
	OnRouletteItemSelect,
	// Token: 0x04001C08 RID: 7176
	OnRouletteItemUnlock,
	// Token: 0x04001C09 RID: 7177
	OnRouletteSaveDataChange,
	// Token: 0x04001C0A RID: 7178
	OpenRouletteSetView,
	// Token: 0x04001C0B RID: 7179
	RouletteSwitchToggleComponentEmit,
	// Token: 0x04001C0C RID: 7180
	RouletteNavigationComponentEmit,
	// Token: 0x04001C0D RID: 7181
	OnAggroAdd,
	// Token: 0x04001C0E RID: 7182
	OnAggroRemoved,
	// Token: 0x04001C0F RID: 7183
	OnBossFight,
	// Token: 0x04001C10 RID: 7184
	OnEntityFightByBpType,
	// Token: 0x04001C11 RID: 7185
	OnSkillTagChanged,
	// Token: 0x04001C12 RID: 7186
	OnMatchingChange,
	// Token: 0x04001C13 RID: 7187
	OnMatchingBegin,
	// Token: 0x04001C14 RID: 7188
	OnEnterTeam,
	// Token: 0x04001C15 RID: 7189
	OnLeaveTeam,
	// Token: 0x04001C16 RID: 7190
	OnEnterOnlineWorld,
	// Token: 0x04001C17 RID: 7191
	OnLeaveOnlineWorld,
	// Token: 0x04001C18 RID: 7192
	OnlineDisableStateChange,
	// Token: 0x04001C19 RID: 7193
	PlayerChallengeStateChange,
	// Token: 0x04001C1A RID: 7194
	OnTriggerVolumeExit,
	// Token: 0x04001C1B RID: 7195
	OnSeasonAreaEffectBegin,
	// Token: 0x04001C1C RID: 7196
	OnSeasonAreaEffectEnd,
	// Token: 0x04001C1D RID: 7197
	RefreshAcquireView,
	// Token: 0x04001C1E RID: 7198
	OnResonanceMaterialChange,
	// Token: 0x04001C1F RID: 7199
	OnAddMaterialController,
	// Token: 0x04001C20 RID: 7200
	OnRemoveMaterialController,
	// Token: 0x04001C21 RID: 7201
	OnAddMaterialControllerGroup,
	// Token: 0x04001C22 RID: 7202
	OnRemoveMaterialControllerGroup,
	// Token: 0x04001C23 RID: 7203
	WeatherChange,
	// Token: 0x04001C24 RID: 7204
	OnManipulateSwitchToNewTarget,
	// Token: 0x04001C25 RID: 7205
	OnManipulateStartChanting,
	// Token: 0x04001C26 RID: 7206
	OnManipulateCancelChanting,
	// Token: 0x04001C27 RID: 7207
	OnManipulateCompleteChanting,
	// Token: 0x04001C28 RID: 7208
	HiddenManipulateUI,
	// Token: 0x04001C29 RID: 7209
	ManipulateStartLockCastTarget,
	// Token: 0x04001C2A RID: 7210
	ManipulateEndLockCastTarget,
	// Token: 0x04001C2B RID: 7211
	OnManipulatableSceneItemPosInFoundation,
	// Token: 0x04001C2C RID: 7212
	AddSubCameraTag,
	// Token: 0x04001C2D RID: 7213
	RemoveSubCameraTag,
	// Token: 0x04001C2E RID: 7214
	AddExtraHoldingTags,
	// Token: 0x04001C2F RID: 7215
	RemoveExtraHoldingTags,
	// Token: 0x04001C30 RID: 7216
	HideJigsawBaseHint,
	// Token: 0x04001C31 RID: 7217
	OnModifyJigsawItemPutIndex,
	// Token: 0x04001C32 RID: 7218
	OnManipulatableItemStateModified,
	// Token: 0x04001C33 RID: 7219
	OnManipulatedItemPosReset,
	// Token: 0x04001C34 RID: 7220
	SetCameraAimVisible,
	// Token: 0x04001C35 RID: 7221
	SetFollowShootAimVisible,
	// Token: 0x04001C36 RID: 7222
	SetFollowShootAutoAimVisible,
	// Token: 0x04001C37 RID: 7223
	SetTDFollowShootAimVisible,
	// Token: 0x04001C38 RID: 7224
	ClickDisplayItem,
	// Token: 0x04001C39 RID: 7225
	OnSelectItemAdd,
	// Token: 0x04001C3A RID: 7226
	DetectSuccess,
	// Token: 0x04001C3B RID: 7227
	AdventureTaskStateChange,
	// Token: 0x04001C3C RID: 7228
	ChapterRewardReceived,
	// Token: 0x04001C3D RID: 7229
	SilentRewardReceived,
	// Token: 0x04001C3E RID: 7230
	AdventureHelpBtn,
	// Token: 0x04001C3F RID: 7231
	NewSoundAreaRefreshReward,
	// Token: 0x04001C40 RID: 7232
	RedDotNewSoundAreaTabUpdate,
	// Token: 0x04001C41 RID: 7233
	RedDotAdventureChallengeTabUpdate,
	// Token: 0x04001C42 RID: 7234
	RedDotAdventureSecondaryUpdate,
	// Token: 0x04001C43 RID: 7235
	RedDotAdventurePeriodicityTabUpdate,
	// Token: 0x04001C44 RID: 7236
	DailyActivityTaskUpdate,
	// Token: 0x04001C45 RID: 7237
	DailyActivityRefresh,
	// Token: 0x04001C46 RID: 7238
	DailyActivityValueChange,
	// Token: 0x04001C47 RID: 7239
	DailyActivityRewardTake,
	// Token: 0x04001C48 RID: 7240
	RefreshActivityRewardPopUp,
	// Token: 0x04001C49 RID: 7241
	DailyActivityCountDownUpdate,
	// Token: 0x04001C4A RID: 7242
	DailyUpdateNotify,
	// Token: 0x04001C4B RID: 7243
	DailyActivityStateNotify,
	// Token: 0x04001C4C RID: 7244
	DailyActivityMainTabOpened,
	// Token: 0x04001C4D RID: 7245
	DailyTaskAreaItemClick,
	// Token: 0x04001C4E RID: 7246
	DailyTaskInfluenceItemClick,
	// Token: 0x04001C4F RID: 7247
	DailyTaskUnlockAreaChange,
	// Token: 0x04001C50 RID: 7248
	DailyTaskStateChange,
	// Token: 0x04001C51 RID: 7249
	DailyTaskChange,
	// Token: 0x04001C52 RID: 7250
	DailyTaskTendencyChange,
	// Token: 0x04001C53 RID: 7251
	OnAddCommonItem,
	// Token: 0x04001C54 RID: 7252
	OnAddCommonItemList,
	// Token: 0x04001C55 RID: 7253
	OnAddCommonItemNotify,
	// Token: 0x04001C56 RID: 7254
	OnResponseCommonItem,
	// Token: 0x04001C57 RID: 7255
	OnResponseCommonItemFinished,
	// Token: 0x04001C58 RID: 7256
	OnRemoveCommonItem,
	// Token: 0x04001C59 RID: 7257
	OnCommonItemCountRefresh,
	// Token: 0x04001C5A RID: 7258
	OnCommonItemCountAnyChange,
	// Token: 0x04001C5B RID: 7259
	OnAddWeaponItem,
	// Token: 0x04001C5C RID: 7260
	OnAddWeaponItemList,
	// Token: 0x04001C5D RID: 7261
	OnResponseWeaponItem,
	// Token: 0x04001C5E RID: 7262
	OnResponseWeaponAll,
	// Token: 0x04001C5F RID: 7263
	OnRemoveWeaponItem,
	// Token: 0x04001C60 RID: 7264
	OnWeaponFunctionValueRefresh,
	// Token: 0x04001C61 RID: 7265
	OnAddPhantomItem,
	// Token: 0x04001C62 RID: 7266
	OnAddPhantomItemList,
	// Token: 0x04001C63 RID: 7267
	OnResponsePhantomItem,
	// Token: 0x04001C64 RID: 7268
	OnEquipPhantomItem,
	// Token: 0x04001C65 RID: 7269
	OnRemovePhantomItem,
	// Token: 0x04001C66 RID: 7270
	OnPhantomStackMerge,
	// Token: 0x04001C67 RID: 7271
	OnPhantomFunctionValueRefresh,
	// Token: 0x04001C68 RID: 7272
	OnAddFavorItem,
	// Token: 0x04001C69 RID: 7273
	OnAddOrnamentItemList,
	// Token: 0x04001C6A RID: 7274
	NotifyInvalidItem,
	// Token: 0x04001C6B RID: 7275
	NotifyExpireConvertItem,
	// Token: 0x04001C6C RID: 7276
	EnterLogicRange,
	// Token: 0x04001C6D RID: 7277
	LeaveLogicRange,
	// Token: 0x04001C6E RID: 7278
	PlayerSenseTargetEnter,
	// Token: 0x04001C6F RID: 7279
	PlayerSenseTargetLeave,
	// Token: 0x04001C70 RID: 7280
	OnAiSenseEntityEnter,
	// Token: 0x04001C71 RID: 7281
	OnAiSenseEntityLeave,
	// Token: 0x04001C72 RID: 7282
	OnInteractStateChange,
	// Token: 0x04001C73 RID: 7283
	OnGuideRangeEnter,
	// Token: 0x04001C74 RID: 7284
	SwitchCookType,
	// Token: 0x04001C75 RID: 7285
	UpdateFormula,
	// Token: 0x04001C76 RID: 7286
	UpdateCookerInfo,
	// Token: 0x04001C77 RID: 7287
	UpgradeCookerLevel,
	// Token: 0x04001C78 RID: 7288
	GetCookData,
	// Token: 0x04001C79 RID: 7289
	OpenProcessedStudy,
	// Token: 0x04001C7A RID: 7290
	CloseProcessedStudy,
	// Token: 0x04001C7B RID: 7291
	OpenCook,
	// Token: 0x04001C7C RID: 7292
	OpenCookLevel,
	// Token: 0x04001C7D RID: 7293
	OpenCookRole,
	// Token: 0x04001C7E RID: 7294
	CloseCookRole,
	// Token: 0x04001C7F RID: 7295
	CookSuccess,
	// Token: 0x04001C80 RID: 7296
	CookFail,
	// Token: 0x04001C81 RID: 7297
	MachiningSuccess,
	// Token: 0x04001C82 RID: 7298
	MachiningStudyFail,
	// Token: 0x04001C83 RID: 7299
	FixSuccess,
	// Token: 0x04001C84 RID: 7300
	OpenSelected,
	// Token: 0x04001C85 RID: 7301
	CloseSelected,
	// Token: 0x04001C86 RID: 7302
	OnAddCommonEffect,
	// Token: 0x04001C87 RID: 7303
	RefreshRewardPopUp,
	// Token: 0x04001C88 RID: 7304
	ReceiveMonthCardDataEvent,
	// Token: 0x04001C89 RID: 7305
	ReceiveWeekCardDataEvent,
	// Token: 0x04001C8A RID: 7306
	OnClickSingleTimeTowerStageBtn,
	// Token: 0x04001C8B RID: 7307
	OnClickSingleTimeTowerTeamBtn,
	// Token: 0x04001C8C RID: 7308
	OnClickSingleTimeTowerTeamRoleBtn,
	// Token: 0x04001C8D RID: 7309
	OnClickSingleTimeTowerStageDetailBtn,
	// Token: 0x04001C8E RID: 7310
	OnClickSingleTimeTowerMonsterBtn,
	// Token: 0x04001C8F RID: 7311
	OnClickSingleTimeTowerDetailSwitchBtn,
	// Token: 0x04001C90 RID: 7312
	OnInstResultNotify,
	// Token: 0x04001C91 RID: 7313
	OnTowerChallengeChangeTeamNotify,
	// Token: 0x04001C92 RID: 7314
	OnTowerRewardReceived,
	// Token: 0x04001C93 RID: 7315
	RedDotTowerReward,
	// Token: 0x04001C94 RID: 7316
	RedDotTowerRewardByDifficulties,
	// Token: 0x04001C95 RID: 7317
	OnTowerRefresh,
	// Token: 0x04001C96 RID: 7318
	OnTowerRecordUpdate,
	// Token: 0x04001C97 RID: 7319
	OnShowTowerGuideButton,
	// Token: 0x04001C98 RID: 7320
	OnTowerReviewGoToReward,
	// Token: 0x04001C99 RID: 7321
	OnClickCycleTowerAreaBtn,
	// Token: 0x04001C9A RID: 7322
	OnResetCycleTowerArea,
	// Token: 0x04001C9B RID: 7323
	OnClickCycleTowerRoleBtn,
	// Token: 0x04001C9C RID: 7324
	OnClickCycleTowerDetailSwitchBtn,
	// Token: 0x04001C9D RID: 7325
	OnCycleTowerUpdateSeason,
	// Token: 0x04001C9E RID: 7326
	OnCycleTowerUpdateSeasonNotify,
	// Token: 0x04001C9F RID: 7327
	OnCycleTowerScoreChange,
	// Token: 0x04001CA0 RID: 7328
	OnTowerGuideClose,
	// Token: 0x04001CA1 RID: 7329
	OnTowerRefreshStars,
	// Token: 0x04001CA2 RID: 7330
	OnReceiveAdviceData,
	// Token: 0x04001CA3 RID: 7331
	OnCreateAdviceSuccess,
	// Token: 0x04001CA4 RID: 7332
	OnModifyAdviceSuccess,
	// Token: 0x04001CA5 RID: 7333
	OnDeleteAdviceSuccess,
	// Token: 0x04001CA6 RID: 7334
	OnClickAdviceExpression,
	// Token: 0x04001CA7 RID: 7335
	OnClickAdviceWord,
	// Token: 0x04001CA8 RID: 7336
	OnChangeAdviceWord,
	// Token: 0x04001CA9 RID: 7337
	OnClickAdviceSort,
	// Token: 0x04001CAA RID: 7338
	OnClickAdviceSortWord,
	// Token: 0x04001CAB RID: 7339
	OnClickAdviceMotion,
	// Token: 0x04001CAC RID: 7340
	OnChangeAdviceRole,
	// Token: 0x04001CAD RID: 7341
	OnClickAdviceSelectItem,
	// Token: 0x04001CAE RID: 7342
	OnSelectAdviceWord,
	// Token: 0x04001CAF RID: 7343
	OnSelectAdviceExpression,
	// Token: 0x04001CB0 RID: 7344
	OnAdviceEntityNotify,
	// Token: 0x04001CB1 RID: 7345
	OnAdviceVoteNotify,
	// Token: 0x04001CB2 RID: 7346
	RefreshAdviceInfoView,
	// Token: 0x04001CB3 RID: 7347
	SneakStart,
	// Token: 0x04001CB4 RID: 7348
	SneakEnd,
	// Token: 0x04001CB5 RID: 7349
	AddAlterMark,
	// Token: 0x04001CB6 RID: 7350
	RemoveAlterMark,
	// Token: 0x04001CB7 RID: 7351
	OnSneakFoundChange,
	// Token: 0x04001CB8 RID: 7352
	OnChildQuestNodeFinish,
	// Token: 0x04001CB9 RID: 7353
	AddStalkAlertMark,
	// Token: 0x04001CBA RID: 7354
	RemoveStalkAlertMark,
	// Token: 0x04001CBB RID: 7355
	OnStalkAlert,
	// Token: 0x04001CBC RID: 7356
	OnStalkAlertLifted,
	// Token: 0x04001CBD RID: 7357
	OnStalkFound,
	// Token: 0x04001CBE RID: 7358
	OnStalkFailed,
	// Token: 0x04001CBF RID: 7359
	AddEavesdropMark,
	// Token: 0x04001CC0 RID: 7360
	RemoveEavesdropMark,
	// Token: 0x04001CC1 RID: 7361
	OnEavesdropFound,
	// Token: 0x04001CC2 RID: 7362
	OnAddFullScreenEffect,
	// Token: 0x04001CC3 RID: 7363
	OnRemoveFullScreenEffect,
	// Token: 0x04001CC4 RID: 7364
	OnClearFullScreenEffect,
	// Token: 0x04001CC5 RID: 7365
	OnChangeFullScreenNiagaraFloatParameter,
	// Token: 0x04001CC6 RID: 7366
	OnSceneItemBuffConsumed,
	// Token: 0x04001CC7 RID: 7367
	OnSceneItemBuffRemoved,
	// Token: 0x04001CC8 RID: 7368
	OnSceneItemBuffTimeout,
	// Token: 0x04001CC9 RID: 7369
	OnSceneItemBuffTargetRemoved,
	// Token: 0x04001CCA RID: 7370
	OnSceneItemBuffConsumerPerformanceComplete,
	// Token: 0x04001CCB RID: 7371
	OnExecuteServerGm,
	// Token: 0x04001CCC RID: 7372
	ActiveBattleView,
	// Token: 0x04001CCD RID: 7373
	DisActiveBattleView,
	// Token: 0x04001CCE RID: 7374
	DragActorPlayActivationChanged,
	// Token: 0x04001CCF RID: 7375
	DragActorPlayConditionRecheck,
	// Token: 0x04001CD0 RID: 7376
	BattleUiCurRoleDataChanged,
	// Token: 0x04001CD1 RID: 7377
	BattleUiCurRoleDataChangedNextTick,
	// Token: 0x04001CD2 RID: 7378
	BattleUiEnergyBarVisible,
	// Token: 0x04001CD3 RID: 7379
	BattleUiAllRoleDataChanged,
	// Token: 0x04001CD4 RID: 7380
	BattleUiRemoveRoleData,
	// Token: 0x04001CD5 RID: 7381
	BattleUiElementEnergyChanged,
	// Token: 0x04001CD6 RID: 7382
	BattleUiEnergyChanged,
	// Token: 0x04001CD7 RID: 7383
	BattleUiRoleHeadChanged,
	// Token: 0x04001CD8 RID: 7384
	BattleUiElementHideTagChanged,
	// Token: 0x04001CD9 RID: 7385
	BattleUiConcertoExtraEffectRefresh,
	// Token: 0x04001CDA RID: 7386
	BattleUiDeadTagChanged,
	// Token: 0x04001CDB RID: 7387
	BattleUiQteEnableTagChanged,
	// Token: 0x04001CDC RID: 7388
	BattleUiQteCdTagChanged,
	// Token: 0x04001CDD RID: 7389
	BattleUiUseQteTagChanged,
	// Token: 0x04001CDE RID: 7390
	BattleUiConcertoEnableTagChanged,
	// Token: 0x04001CDF RID: 7391
	BattleUiPoisonChanged,
	// Token: 0x04001CE0 RID: 7392
	BattleUiHealthChanged,
	// Token: 0x04001CE1 RID: 7393
	BattleUiShieldChanged,
	// Token: 0x04001CE2 RID: 7394
	BattleUiLevelChanged,
	// Token: 0x04001CE3 RID: 7395
	BattleUiFloatTipUpdate,
	// Token: 0x04001CE4 RID: 7396
	BattleUiPlayAudio,
	// Token: 0x04001CE5 RID: 7397
	BattleUiExploreModeChanged,
	// Token: 0x04001CE6 RID: 7398
	BattleUiMergeHeadStateVisibleChanged,
	// Token: 0x04001CE7 RID: 7399
	BattleUiMergeHeadStateHealthChanged,
	// Token: 0x04001CE8 RID: 7400
	BattleUiTowerMergeHeadStateVisibleChanged,
	// Token: 0x04001CE9 RID: 7401
	BattleUiTowerMergeHeadStateMonsterHpChanged,
	// Token: 0x04001CEA RID: 7402
	BattleUiEnvironmentKeyChanged,
	// Token: 0x04001CEB RID: 7403
	BattleUiPressCombineButtonChanged,
	// Token: 0x04001CEC RID: 7404
	BattleUiPressMotorcycleCombineButtonChanged,
	// Token: 0x04001CED RID: 7405
	BattleUiToggleSilentAreaInfoView,
	// Token: 0x04001CEE RID: 7406
	BattleInputEnableChanged,
	// Token: 0x04001CEF RID: 7407
	BattleInputVisibleChanged,
	// Token: 0x04001CF0 RID: 7408
	BattleUiFollowerAimStateChanged,
	// Token: 0x04001CF1 RID: 7409
	BattleUiChatScrollViewVisibleChanged,
	// Token: 0x04001CF2 RID: 7410
	BattleUiRouletteKeyChanged,
	// Token: 0x04001CF3 RID: 7411
	BattleUiSwitchInteractOpenChanged,
	// Token: 0x04001CF4 RID: 7412
	BattleUiSwitchInteractStateChanged,
	// Token: 0x04001CF5 RID: 7413
	BattleUiToggleTowerDefenseInfoView,
	// Token: 0x04001CF6 RID: 7414
	BattleUiAlphaChanged,
	// Token: 0x04001CF7 RID: 7415
	BattleUiPureModeChanged,
	// Token: 0x04001CF8 RID: 7416
	BattleUiSpecialSkillEnableChanged,
	// Token: 0x04001CF9 RID: 7417
	BattleUiRoleSpecialStateChanged,
	// Token: 0x04001CFA RID: 7418
	BattleUiSlowTimeVisibleChanged,
	// Token: 0x04001CFB RID: 7419
	BattleUiTimeDilationStateChanged,
	// Token: 0x04001CFC RID: 7420
	BattleUiShowWeaknessBreakEffect,
	// Token: 0x04001CFD RID: 7421
	BattleUiMotorcycleStateChanged,
	// Token: 0x04001CFE RID: 7422
	BattleUiMotorcycleBulletJumpChanged,
	// Token: 0x04001CFF RID: 7423
	BattleUiMotorcycleHudVisibleChanged,
	// Token: 0x04001D00 RID: 7424
	BattleUiMotorcycleHudColorStateChanged,
	// Token: 0x04001D01 RID: 7425
	BattleUiMotorcycleFlyTagChanged,
	// Token: 0x04001D02 RID: 7426
	BattleUiMotorcycleCannonTagChanged,
	// Token: 0x04001D03 RID: 7427
	AddStrengthItem,
	// Token: 0x04001D04 RID: 7428
	RemoveStrengthItem,
	// Token: 0x04001D05 RID: 7429
	BattleUiBossStateAreaChanged,
	// Token: 0x04001D06 RID: 7430
	BattleUiGamepadDataChanged,
	// Token: 0x04001D07 RID: 7431
	BattleUiSlideControlVisibleChanged,
	// Token: 0x04001D08 RID: 7432
	OnSkillButtonPanelVisibleChange,
	// Token: 0x04001D09 RID: 7433
	BattleSettlementStateChanged,
	// Token: 0x04001D0A RID: 7434
	BattleScoreChanged,
	// Token: 0x04001D0B RID: 7435
	BattleScoreEnableChanged,
	// Token: 0x04001D0C RID: 7436
	OnRefreshFormationCooldownExternalInBattleView,
	// Token: 0x04001D0D RID: 7437
	OnCharacterCapsuleChanged,
	// Token: 0x04001D0E RID: 7438
	OnKscPlayerHpChanged,
	// Token: 0x04001D0F RID: 7439
	OnKscPlayerCreate,
	// Token: 0x04001D10 RID: 7440
	RefreshInfluencePanel,
	// Token: 0x04001D11 RID: 7441
	ReceiveReputationReward,
	// Token: 0x04001D12 RID: 7442
	SearchInfluence,
	// Token: 0x04001D13 RID: 7443
	RedDotInfluence,
	// Token: 0x04001D14 RID: 7444
	BehaviorTreeStartActionSession,
	// Token: 0x04001D15 RID: 7445
	UiPlayCloseAudio,
	// Token: 0x04001D16 RID: 7446
	OnSceneItemLockPropChange,
	// Token: 0x04001D17 RID: 7447
	OnSpecialItemUpdate,
	// Token: 0x04001D18 RID: 7448
	EquipAndSwitchSpecialItem,
	// Token: 0x04001D19 RID: 7449
	UnEquipSpecialItem,
	// Token: 0x04001D1A RID: 7450
	ShowPlayerPosition,
	// Token: 0x04001D1B RID: 7451
	BattlePassHadEnterUpdate,
	// Token: 0x04001D1C RID: 7452
	GetBattlePassRewardEvent,
	// Token: 0x04001D1D RID: 7453
	ReceiveBattlePassDataEvent,
	// Token: 0x04001D1E RID: 7454
	NotifyBattlePassToBuyEvent,
	// Token: 0x04001D1F RID: 7455
	BattlePassFirstUnlockAnime,
	// Token: 0x04001D20 RID: 7456
	OnReceiveBattlePassPaid,
	// Token: 0x04001D21 RID: 7457
	ReceiveBattlePassTaskEvent,
	// Token: 0x04001D22 RID: 7458
	OnChoseLevelItemEvent,
	// Token: 0x04001D23 RID: 7459
	OnClickLevelItemEvent,
	// Token: 0x04001D24 RID: 7460
	UpdateBattlePassTaskEvent,
	// Token: 0x04001D25 RID: 7461
	OnBattlePassLevelUpEvent,
	// Token: 0x04001D26 RID: 7462
	OnBattlePassSkip,
	// Token: 0x04001D27 RID: 7463
	OnBattlePassExpireEvent,
	// Token: 0x04001D28 RID: 7464
	BattlePassMainViewHide,
	// Token: 0x04001D29 RID: 7465
	OnResetSkinDamageMode,
	// Token: 0x04001D2A RID: 7466
	OnExitNpcInteract,
	// Token: 0x04001D2B RID: 7467
	SwitchViewType,
	// Token: 0x04001D2C RID: 7468
	SwitchComposeType,
	// Token: 0x04001D2D RID: 7469
	GetComposeData,
	// Token: 0x04001D2E RID: 7470
	UpgradeComposeLevel,
	// Token: 0x04001D2F RID: 7471
	OpenComposeLevel,
	// Token: 0x04001D30 RID: 7472
	OpenCompose,
	// Token: 0x04001D31 RID: 7473
	ComposeSuccess,
	// Token: 0x04001D32 RID: 7474
	ComposeFail,
	// Token: 0x04001D33 RID: 7475
	ComposeSwitchType,
	// Token: 0x04001D34 RID: 7476
	OpenHelpRole,
	// Token: 0x04001D35 RID: 7477
	CloseHelpRole,
	// Token: 0x04001D36 RID: 7478
	UpdateComposeFormula,
	// Token: 0x04001D37 RID: 7479
	UpdateComposeInfo,
	// Token: 0x04001D38 RID: 7480
	UpdateForgingFormula,
	// Token: 0x04001D39 RID: 7481
	OpenForging,
	// Token: 0x04001D3A RID: 7482
	GetForgingData,
	// Token: 0x04001D3B RID: 7483
	ForgingSuccess,
	// Token: 0x04001D3C RID: 7484
	ForgingFail,
	// Token: 0x04001D3D RID: 7485
	ChangePlayerInfoId,
	// Token: 0x04001D3E RID: 7486
	OnShowGridAnimation,
	// Token: 0x04001D3F RID: 7487
	OnActivateUiCameraAnimationHandle,
	// Token: 0x04001D40 RID: 7488
	OnActivateUiCameraAnimationHandleFail,
	// Token: 0x04001D41 RID: 7489
	OnUiBlendInTimeCameraFinished,
	// Token: 0x04001D42 RID: 7490
	OnUiBlendInCameraSequenceFinished,
	// Token: 0x04001D43 RID: 7491
	RoleHandBookActive,
	// Token: 0x04001D44 RID: 7492
	OnSequenceCameraStatus,
	// Token: 0x04001D45 RID: 7493
	LocalStorageInitPlayerId,
	// Token: 0x04001D46 RID: 7494
	DynamicInteractServerResponse,
	// Token: 0x04001D47 RID: 7495
	UpdateCameraInfo,
	// Token: 0x04001D48 RID: 7496
	PlayCameraLevelSequence,
	// Token: 0x04001D49 RID: 7497
	CameraModeChanged,
	// Token: 0x04001D4A RID: 7498
	CameraViewTargetChanged,
	// Token: 0x04001D4B RID: 7499
	FixedCameraRestored,
	// Token: 0x04001D4C RID: 7500
	CameraCharacterChanged,
	// Token: 0x04001D4D RID: 7501
	AdjustCameraSync,
	// Token: 0x04001D4E RID: 7502
	OpenTreasureBox,
	// Token: 0x04001D4F RID: 7503
	OnHandBookDataInit,
	// Token: 0x04001D50 RID: 7504
	OnHandBookDataUpdate,
	// Token: 0x04001D51 RID: 7505
	OnHandBookRedDotUpdate,
	// Token: 0x04001D52 RID: 7506
	OnHandBookRead,
	// Token: 0x04001D53 RID: 7507
	OnPhantomReadRedDotUpdate,
	// Token: 0x04001D54 RID: 7508
	OnItemReadRedDotUpdate,
	// Token: 0x04001D55 RID: 7509
	OnPhotoSelect,
	// Token: 0x04001D56 RID: 7510
	OnGeographyPhotoSelect,
	// Token: 0x04001D57 RID: 7511
	OnHandBookPlotNodeRefresh,
	// Token: 0x04001D58 RID: 7512
	RemoveCreatureDataComponentCache,
	// Token: 0x04001D59 RID: 7513
	TravelClearView,
	// Token: 0x04001D5A RID: 7514
	OnPressOrReleaseBehaviorButton,
	// Token: 0x04001D5B RID: 7515
	SetImageQuality,
	// Token: 0x04001D5C RID: 7516
	SetImageQualityWithValue,
	// Token: 0x04001D5D RID: 7517
	SetRayTracingWithValue,
	// Token: 0x04001D5E RID: 7518
	SetDLSSFGWithValue,
	// Token: 0x04001D5F RID: 7519
	SetDisplayMode,
	// Token: 0x04001D60 RID: 7520
	SetResolution,
	// Token: 0x04001D61 RID: 7521
	SetNiagaraQuality,
	// Token: 0x04001D62 RID: 7522
	SetEnvironmentInteraction,
	// Token: 0x04001D63 RID: 7523
	AfterGameQualitySettingsManagerInitialize,
	// Token: 0x04001D64 RID: 7524
	AfterGameSettingsAppliedOnOpenLoading,
	// Token: 0x04001D65 RID: 7525
	LoadingRangeScaleChanged,
	// Token: 0x04001D66 RID: 7526
	SetGmIsOpen,
	// Token: 0x04001D67 RID: 7527
	AddToTickList,
	// Token: 0x04001D68 RID: 7528
	HandleNextAction,
	// Token: 0x04001D69 RID: 7529
	HandleActionFailure,
	// Token: 0x04001D6A RID: 7530
	AddGuaranteeAction,
	// Token: 0x04001D6B RID: 7531
	RemGuaranteeAction,
	// Token: 0x04001D6C RID: 7532
	ShareGroupCd,
	// Token: 0x04001D6D RID: 7533
	AddShareGroupLimitCount,
	// Token: 0x04001D6E RID: 7534
	OnInteractPlotStart,
	// Token: 0x04001D6F RID: 7535
	OnInteractPlotEnd,
	// Token: 0x04001D70 RID: 7536
	OnAchievementDataNotify,
	// Token: 0x04001D71 RID: 7537
	OnAchievementDataWithIdNotify,
	// Token: 0x04001D72 RID: 7538
	OnAchievementGroupDataNotify,
	// Token: 0x04001D73 RID: 7539
	OnGetAchievementBaseData,
	// Token: 0x04001D74 RID: 7540
	OnGetAchievementSearchTextChange,
	// Token: 0x04001D75 RID: 7541
	OnAchievementGroupChange,
	// Token: 0x04001D76 RID: 7542
	RefreshAchievementRedPoint,
	// Token: 0x04001D77 RID: 7543
	OnActivityUpdate,
	// Token: 0x04001D78 RID: 7544
	OnSelectActivity,
	// Token: 0x04001D79 RID: 7545
	OnSelectActivityAndSubViewReady,
	// Token: 0x04001D7A RID: 7546
	RefreshActivityTab,
	// Token: 0x04001D7B RID: 7547
	OnReceiveActivityData,
	// Token: 0x04001D7C RID: 7548
	SetActivityViewState,
	// Token: 0x04001D7D RID: 7549
	SetActivityViewCurrency,
	// Token: 0x04001D7E RID: 7550
	ChangeActivityViewNeedBlurState,
	// Token: 0x04001D7F RID: 7551
	OnClickActivityRunChallenge,
	// Token: 0x04001D80 RID: 7552
	OnSelectActivityRunChallengeItem,
	// Token: 0x04001D81 RID: 7553
	RefreshCommonActivityRedDot,
	// Token: 0x04001D82 RID: 7554
	RefreshActivityRecommendRedDot,
	// Token: 0x04001D83 RID: 7555
	RoverlikeTalentUnlockDataUpdate,
	// Token: 0x04001D84 RID: 7556
	RoverlikeQuestTaskUpdate,
	// Token: 0x04001D85 RID: 7557
	RoverlikeReviveTimesUpdate,
	// Token: 0x04001D86 RID: 7558
	RoverlikeResourceFloatText,
	// Token: 0x04001D87 RID: 7559
	RoverlikeGainDataUpdate,
	// Token: 0x04001D88 RID: 7560
	RoverlikeEquippedLootChange,
	// Token: 0x04001D89 RID: 7561
	RoverlikeLootInfoUpdate,
	// Token: 0x04001D8A RID: 7562
	RoverlikeLevelInfoUpdate,
	// Token: 0x04001D8B RID: 7563
	RoverlikeShopInfoUpdate,
	// Token: 0x04001D8C RID: 7564
	OnNewbieMainTaskUpdate,
	// Token: 0x04001D8D RID: 7565
	RefreshRunActivityRedDot,
	// Token: 0x04001D8E RID: 7566
	OnGetRunActivityReward,
	// Token: 0x04001D8F RID: 7567
	ActivityCrossDayRefresh,
	// Token: 0x04001D90 RID: 7568
	ActivityDataInitComplete,
	// Token: 0x04001D91 RID: 7569
	OnActivityClose,
	// Token: 0x04001D92 RID: 7570
	OnActivityOpen,
	// Token: 0x04001D93 RID: 7571
	OnActivityPreOpen,
	// Token: 0x04001D94 RID: 7572
	OnActivitySequenceEmitEvent,
	// Token: 0x04001D95 RID: 7573
	RefreshCommonActivityRewardPopUpView,
	// Token: 0x04001D96 RID: 7574
	ActivityViewChange,
	// Token: 0x04001D97 RID: 7575
	ActivityViewRefreshCurrent,
	// Token: 0x04001D98 RID: 7576
	LongShanUpdate,
	// Token: 0x04001D99 RID: 7577
	OnPhantomCollectUpdate,
	// Token: 0x04001D9A RID: 7578
	TurntableStartRun,
	// Token: 0x04001D9B RID: 7579
	TrackMoonHandbookUpdate,
	// Token: 0x04001D9C RID: 7580
	MoonChasingRefreshBuildingRedDot,
	// Token: 0x04001D9D RID: 7581
	MoonChasingRefreshRewardRedDot,
	// Token: 0x04001D9E RID: 7582
	MoonChasingRefreshDelegationRedDot,
	// Token: 0x04001D9F RID: 7583
	MoonChasingRefreshRoleRedDot,
	// Token: 0x04001DA0 RID: 7584
	MoonChasingRefreshQuestRedDot,
	// Token: 0x04001DA1 RID: 7585
	MoonChasingOnOpenInteractive,
	// Token: 0x04001DA2 RID: 7586
	DreamLinkRewardRefresh,
	// Token: 0x04001DA3 RID: 7587
	DreamLinkLimitRewardRefresh,
	// Token: 0x04001DA4 RID: 7588
	MapTravelTaskRefresh,
	// Token: 0x04001DA5 RID: 7589
	MapTravelSoarRefresh,
	// Token: 0x04001DA6 RID: 7590
	MapTravelTaskNavigationNext,
	// Token: 0x04001DA7 RID: 7591
	OnCyberPunkUpdate,
	// Token: 0x04001DA8 RID: 7592
	OnCyberPunkTaskRefresh,
	// Token: 0x04001DA9 RID: 7593
	OnCyberPunkItemUnLock,
	// Token: 0x04001DAA RID: 7594
	GmAutoModeChange,
	// Token: 0x04001DAB RID: 7595
	OnAddNotAllowFightInputViewName,
	// Token: 0x04001DAC RID: 7596
	OnRemoveNotAllowFightInputViewName,
	// Token: 0x04001DAD RID: 7597
	OnClearNotAllowFightInputViewName,
	// Token: 0x04001DAE RID: 7598
	OnSelectedEditPanelItem,
	// Token: 0x04001DAF RID: 7599
	UiRoleSequenceEndKeyFrame,
	// Token: 0x04001DB0 RID: 7600
	DropItemStarted,
	// Token: 0x04001DB1 RID: 7601
	OnRoleChangeEnd,
	// Token: 0x04001DB2 RID: 7602
	ComboTeachingPress,
	// Token: 0x04001DB3 RID: 7603
	ComboTeachingRelease,
	// Token: 0x04001DB4 RID: 7604
	ComboTeachingHold,
	// Token: 0x04001DB5 RID: 7605
	ComboTeachingNodeEnd,
	// Token: 0x04001DB6 RID: 7606
	ComboTeachingIndexUpdate,
	// Token: 0x04001DB7 RID: 7607
	ComboTeachingViewOpen,
	// Token: 0x04001DB8 RID: 7608
	SkillAcceptChanged,
	// Token: 0x04001DB9 RID: 7609
	ComboTeachingFinish,
	// Token: 0x04001DBA RID: 7610
	ComboTeachingCloseGuide,
	// Token: 0x04001DBB RID: 7611
	RoleIntroductionViewHide,
	// Token: 0x04001DBC RID: 7612
	RequestClearMeshRotationBuffer,
	// Token: 0x04001DBD RID: 7613
	NavigationViewCreate,
	// Token: 0x04001DBE RID: 7614
	NavigationViewDestroy,
	// Token: 0x04001DBF RID: 7615
	ResetNavigationListener,
	// Token: 0x04001DC0 RID: 7616
	NavigationTriggerMapForward,
	// Token: 0x04001DC1 RID: 7617
	NavigationTriggerMapRight,
	// Token: 0x04001DC2 RID: 7618
	NavigationTriggerMapZoom,
	// Token: 0x04001DC3 RID: 7619
	NavigationTriggerRoleLookUp,
	// Token: 0x04001DC4 RID: 7620
	NavigationTriggerRoleTurn,
	// Token: 0x04001DC5 RID: 7621
	NavigationTriggerRoleZoom,
	// Token: 0x04001DC6 RID: 7622
	NavigationTriggerRoleReset,
	// Token: 0x04001DC7 RID: 7623
	GamepadMoveOverScreen,
	// Token: 0x04001DC8 RID: 7624
	NavigationTriggerPlotForward,
	// Token: 0x04001DC9 RID: 7625
	NavigationTriggerPlotRight,
	// Token: 0x04001DCA RID: 7626
	NavigationTriggerPlotZoom,
	// Token: 0x04001DCB RID: 7627
	NavigationRefreshPlotNextPage,
	// Token: 0x04001DCC RID: 7628
	FunctionGridSelected,
	// Token: 0x04001DCD RID: 7629
	OnPersonalCardRead,
	// Token: 0x04001DCE RID: 7630
	OnPersonalCardRefreshRedDot,
	// Token: 0x04001DCF RID: 7631
	OnHeadIconChange,
	// Token: 0x04001DD0 RID: 7632
	OnSignChange,
	// Token: 0x04001DD1 RID: 7633
	OnNameChange,
	// Token: 0x04001DD2 RID: 7634
	OnModifyNameStateChange,
	// Token: 0x04001DD3 RID: 7635
	OnBirthChange,
	// Token: 0x04001DD4 RID: 7636
	OnBirthDisplayChange,
	// Token: 0x04001DD5 RID: 7637
	OnBirthRoleChange,
	// Token: 0x04001DD6 RID: 7638
	OnCardChange,
	// Token: 0x04001DD7 RID: 7639
	ResetRoleFlag,
	// Token: 0x04001DD8 RID: 7640
	OnRoleShowListChange,
	// Token: 0x04001DD9 RID: 7641
	OnRoleElementChange,
	// Token: 0x04001DDA RID: 7642
	ShowRoleElementChangePreviewEffect,
	// Token: 0x04001DDB RID: 7643
	OnChangedActionKeys,
	// Token: 0x04001DDC RID: 7644
	OnChangedAxisKeys,
	// Token: 0x04001DDD RID: 7645
	SelectRoleTab,
	// Token: 0x04001DDE RID: 7646
	SelectRoleTabOutside,
	// Token: 0x04001DDF RID: 7647
	OnFunctionViewShow,
	// Token: 0x04001DE0 RID: 7648
	OnPlayerTitleChange,
	// Token: 0x04001DE1 RID: 7649
	OnPlayerTitleRefreshRedDot,
	// Token: 0x04001DE2 RID: 7650
	OnPlayerTitleUnlock,
	// Token: 0x04001DE3 RID: 7651
	OnPersonalTipStateSet,
	// Token: 0x04001DE4 RID: 7652
	LevelFlowSequenceTriggerEvent,
	// Token: 0x04001DE5 RID: 7653
	OnLevelFlowFinished,
	// Token: 0x04001DE6 RID: 7654
	UpdatePanelQteWorldTimeDilation,
	// Token: 0x04001DE7 RID: 7655
	PanelQteStart,
	// Token: 0x04001DE8 RID: 7656
	PanelQteEnd,
	// Token: 0x04001DE9 RID: 7657
	FreeRunningQteStart,
	// Token: 0x04001DEA RID: 7658
	CommonQteStart,
	// Token: 0x04001DEB RID: 7659
	CommonQteEnd,
	// Token: 0x04001DEC RID: 7660
	QtaStart,
	// Token: 0x04001DED RID: 7661
	QtaEnd,
	// Token: 0x04001DEE RID: 7662
	StartHeartBeat,
	// Token: 0x04001DEF RID: 7663
	StopHeartBeat,
	// Token: 0x04001DF0 RID: 7664
	CreateEffectHandle,
	// Token: 0x04001DF1 RID: 7665
	RemoveEffectHandle,
	// Token: 0x04001DF2 RID: 7666
	LoadEffect,
	// Token: 0x04001DF3 RID: 7667
	BeforePlayEffect,
	// Token: 0x04001DF4 RID: 7668
	AfterPlayEffect,
	// Token: 0x04001DF5 RID: 7669
	FinishEffect,
	// Token: 0x04001DF6 RID: 7670
	TestQuestAutoPilotFinish,
	// Token: 0x04001DF7 RID: 7671
	TestQuestFunctionFinish,
	// Token: 0x04001DF8 RID: 7672
	OnRefreshRewardViewItemList,
	// Token: 0x04001DF9 RID: 7673
	OnRefreshRewardProgressBar,
	// Token: 0x04001DFA RID: 7674
	OnRefreshRewardButton,
	// Token: 0x04001DFB RID: 7675
	OnItemRewardNotify,
	// Token: 0x04001DFC RID: 7676
	OnExploreRewardShowEnd,
	// Token: 0x04001DFD RID: 7677
	OnShowRewardView,
	// Token: 0x04001DFE RID: 7678
	OnCloseRewardView,
	// Token: 0x04001DFF RID: 7679
	OnPlotWaitViewDone,
	// Token: 0x04001E00 RID: 7680
	OnPlayCameraAnimationStart,
	// Token: 0x04001E01 RID: 7681
	OnPlayCameraAnimationFinish,
	// Token: 0x04001E02 RID: 7682
	CommunicateFinished,
	// Token: 0x04001E03 RID: 7683
	CommunicateAgain,
	// Token: 0x04001E04 RID: 7684
	ChallengeAgain,
	// Token: 0x04001E05 RID: 7685
	OnPhotographSetUpViewVisibleChanged,
	// Token: 0x04001E06 RID: 7686
	OnEntityCameraOneSituationChanged,
	// Token: 0x04001E07 RID: 7687
	OnEntityCameraMissTarget,
	// Token: 0x04001E08 RID: 7688
	OnEntityCameraOptionalSituationChanged,
	// Token: 0x04001E09 RID: 7689
	OnEntityCameraSearchGreat,
	// Token: 0x04001E0A RID: 7690
	OnEntityCameraFinished,
	// Token: 0x04001E0B RID: 7691
	OnScreenShotDone,
	// Token: 0x04001E0C RID: 7692
	OnPhotographSetVisible,
	// Token: 0x04001E0D RID: 7693
	OnChangeFovByOption,
	// Token: 0x04001E0E RID: 7694
	NotifyBtFightPhotoTaskFinish,
	// Token: 0x04001E0F RID: 7695
	OnChangeFightPhotoOption,
	// Token: 0x04001E10 RID: 7696
	OnNeedShowFightPhotoFocus,
	// Token: 0x04001E11 RID: 7697
	OnRefreshFightPhotoLevelRedDot,
	// Token: 0x04001E12 RID: 7698
	OnSyncFightPhotoTiltAngle,
	// Token: 0x04001E13 RID: 7699
	OnSubmitItemSuccess,
	// Token: 0x04001E14 RID: 7700
	OnSubmitItemFail,
	// Token: 0x04001E15 RID: 7701
	OnSubmitItemLevelUp,
	// Token: 0x04001E16 RID: 7702
	OnSubmitItemLevelMax,
	// Token: 0x04001E17 RID: 7703
	OnCameraSequenceSetUiVisible,
	// Token: 0x04001E18 RID: 7704
	OnUiScreenRootVisibleChange,
	// Token: 0x04001E19 RID: 7705
	OnTurntableControllerBusyStateChange,
	// Token: 0x04001E1A RID: 7706
	OnAnyProgressControlEnableStateChange,
	// Token: 0x04001E1B RID: 7707
	OnDropItemSuccess,
	// Token: 0x04001E1C RID: 7708
	OnInteractDropItemSuccess,
	// Token: 0x04001E1D RID: 7709
	OnExecuteUiCameraSequenceEvent,
	// Token: 0x04001E1E RID: 7710
	OnInputAnyKey,
	// Token: 0x04001E1F RID: 7711
	OnImmersiveInputStateChange,
	// Token: 0x04001E20 RID: 7712
	OnAddDynamicOption,
	// Token: 0x04001E21 RID: 7713
	OnRemoveDynamicOption,
	// Token: 0x04001E22 RID: 7714
	OnFilterDataUpdate,
	// Token: 0x04001E23 RID: 7715
	OnPlayNpcPerformSequence,
	// Token: 0x04001E24 RID: 7716
	OnNpcPerformSequenceFinished,
	// Token: 0x04001E25 RID: 7717
	OnAntiqueShopUpgradeSequenceFinished,
	// Token: 0x04001E26 RID: 7718
	OnAntiqueShopLevelMaxSequenceFinished,
	// Token: 0x04001E27 RID: 7719
	OnAntiqueShopUpgradeSequencePlayFail,
	// Token: 0x04001E28 RID: 7720
	OnCookSuccessSequenceFinished,
	// Token: 0x04001E29 RID: 7721
	OnBeginPlayCookSuccessDisplay,
	// Token: 0x04001E2A RID: 7722
	OnPlayCookSuccessDisplayFinished,
	// Token: 0x04001E2B RID: 7723
	OnBeginPlayCookFailDisplay,
	// Token: 0x04001E2C RID: 7724
	OnPlayCookFailDisplayFinished,
	// Token: 0x04001E2D RID: 7725
	OnBeginPlayCompositeWorkingDisplay,
	// Token: 0x04001E2E RID: 7726
	OnPlayCompositeWorkingDisplayFinished,
	// Token: 0x04001E2F RID: 7727
	OnBeginPlayForgingWorkingDisplay,
	// Token: 0x04001E30 RID: 7728
	OnPlayForgingWorkingDisplayFinished,
	// Token: 0x04001E31 RID: 7729
	OnCharFootOnTheGround,
	// Token: 0x04001E32 RID: 7730
	BattleViewActiveSequenceFinish,
	// Token: 0x04001E33 RID: 7731
	ShowFloatTips,
	// Token: 0x04001E34 RID: 7732
	SmartObjectAiAlterNotify,
	// Token: 0x04001E35 RID: 7733
	OnSetActorHidden,
	// Token: 0x04001E36 RID: 7734
	OnPreSetActorHidden,
	// Token: 0x04001E37 RID: 7735
	OnCheckGamePing,
	// Token: 0x04001E38 RID: 7736
	OnRemoveItemRedDot,
	// Token: 0x04001E39 RID: 7737
	RunGm,
	// Token: 0x04001E3A RID: 7738
	GmHandleActionFailed,
	// Token: 0x04001E3B RID: 7739
	TestEffectAddDaRec,
	// Token: 0x04001E3C RID: 7740
	TestEffectAddEffectRec,
	// Token: 0x04001E3D RID: 7741
	TestManuallyGarbageCollection,
	// Token: 0x04001E3E RID: 7742
	GmEntityPerformanceTestFinish,
	// Token: 0x04001E3F RID: 7743
	GmOnlyShowMiniMap,
	// Token: 0x04001E40 RID: 7744
	GmOnlyShowJoyStick,
	// Token: 0x04001E41 RID: 7745
	GmHideMissionAndBossName,
	// Token: 0x04001E42 RID: 7746
	RogueBattleDescModeChange,
	// Token: 0x04001E43 RID: 7747
	RogueBattleSelectOption,
	// Token: 0x04001E44 RID: 7748
	RogueBattleSelectOptionPreview,
	// Token: 0x04001E45 RID: 7749
	RoguelikeCloseGainSelectView,
	// Token: 0x04001E46 RID: 7750
	RoguelikeDataUpdate,
	// Token: 0x04001E47 RID: 7751
	RoguelikeChooseDataResult,
	// Token: 0x04001E48 RID: 7752
	RoguelikeChooseDataNotify,
	// Token: 0x04001E49 RID: 7753
	RoguelikeInfoSelectedToken,
	// Token: 0x04001E4A RID: 7754
	RoguelikeRefreshGain,
	// Token: 0x04001E4B RID: 7755
	RoguelikeSelectSkill,
	// Token: 0x04001E4C RID: 7756
	RoguelikeTalentLevelUp,
	// Token: 0x04001E4D RID: 7757
	RoguelikeCurrencyUpdate,
	// Token: 0x04001E4E RID: 7758
	RoguelikeSelectToken,
	// Token: 0x04001E4F RID: 7759
	RoguelikeSelectSeason,
	// Token: 0x04001E50 RID: 7760
	RoguelikeGetTokenReward,
	// Token: 0x04001E51 RID: 7761
	RogueTermUnlock,
	// Token: 0x04001E52 RID: 7762
	RoguelikeHasSelectEntryAndShow,
	// Token: 0x04001E53 RID: 7763
	RoguelikeArchiveSaved,
	// Token: 0x04001E54 RID: 7764
	WeeklyRogueInstDataUpdate,
	// Token: 0x04001E55 RID: 7765
	WeeklyRogueSelectOption,
	// Token: 0x04001E56 RID: 7766
	WeeklyRogueDescModeChange,
	// Token: 0x04001E57 RID: 7767
	WeeklyRogueShopSelect,
	// Token: 0x04001E58 RID: 7768
	WeeklyRogueRefreshScoreRedDot,
	// Token: 0x04001E59 RID: 7769
	WeeklyRogueCycleRefresh,
	// Token: 0x04001E5A RID: 7770
	WeeklyRogueRedDotInfoRefresh,
	// Token: 0x04001E5B RID: 7771
	WeeklyRogueBurstEnableChange,
	// Token: 0x04001E5C RID: 7772
	MapDragMoveForward,
	// Token: 0x04001E5D RID: 7773
	MapDragMoveRight,
	// Token: 0x04001E5E RID: 7774
	PermanentRogueBattleSummaryInfoToggle,
	// Token: 0x04001E5F RID: 7775
	PermanentRogueRewardUpdate,
	// Token: 0x04001E60 RID: 7776
	PermanentRogueSeasonRedDotUpdate,
	// Token: 0x04001E61 RID: 7777
	PermanentRogueSkillCurrencyRedDotUpdate,
	// Token: 0x04001E62 RID: 7778
	RogueResSelectSkill,
	// Token: 0x04001E63 RID: 7779
	RogueResTalentLevelUp,
	// Token: 0x04001E64 RID: 7780
	RogueResEnterInstClicked,
	// Token: 0x04001E65 RID: 7781
	RogueResEndingSwitch,
	// Token: 0x04001E66 RID: 7782
	RogueResEndingRedDotUpdate,
	// Token: 0x04001E67 RID: 7783
	RogueResMapSummaryTeamUpdate,
	// Token: 0x04001E68 RID: 7784
	RogueResMapSummaryFettersSubTabUpdate,
	// Token: 0x04001E69 RID: 7785
	RogueResMapSummaryTeamToBondUpdate,
	// Token: 0x04001E6A RID: 7786
	RogueResMapSummaryBondUpdate,
	// Token: 0x04001E6B RID: 7787
	RogueViewInfoRefresh,
	// Token: 0x04001E6C RID: 7788
	RogueResMapSummaryTeamShowAgain,
	// Token: 0x04001E6D RID: 7789
	RogueTeamEditViewLinkBtnRefresh,
	// Token: 0x04001E6E RID: 7790
	RogueMapMoveTweenStarOrEnd,
	// Token: 0x04001E6F RID: 7791
	RogueMapEventDetailOpenOrClose,
	// Token: 0x04001E70 RID: 7792
	RogueResTeamLvChange,
	// Token: 0x04001E71 RID: 7793
	RogueResMoodChange,
	// Token: 0x04001E72 RID: 7794
	RogueResNewRoleFlagChange,
	// Token: 0x04001E73 RID: 7795
	OnPreparePhotoScreenShot,
	// Token: 0x04001E74 RID: 7796
	OnPhotographViewCaptureMode,
	// Token: 0x04001E75 RID: 7797
	OnMarkItemViewCreate,
	// Token: 0x04001E76 RID: 7798
	OnMarkItemViewDestroy,
	// Token: 0x04001E77 RID: 7799
	TakeMarkComponentEnterContainer,
	// Token: 0x04001E78 RID: 7800
	TakeMarkComponentExitContainer,
	// Token: 0x04001E79 RID: 7801
	OnMarkItemViewEnter,
	// Token: 0x04001E7A RID: 7802
	OnMarkItemViewExit,
	// Token: 0x04001E7B RID: 7803
	LogCustomMarkInfo,
	// Token: 0x04001E7C RID: 7804
	OnOpenSystemFeed,
	// Token: 0x04001E7D RID: 7805
	OnCloseSystemFeed,
	// Token: 0x04001E7E RID: 7806
	OnDeliveryProps,
	// Token: 0x04001E7F RID: 7807
	OnWorldMapTrackMarkItem,
	// Token: 0x04001E80 RID: 7808
	OnSundialRingChangeShine,
	// Token: 0x04001E81 RID: 7809
	OnSundialRingSwitch,
	// Token: 0x04001E82 RID: 7810
	OnNeedUpdateSundialTips,
	// Token: 0x04001E83 RID: 7811
	OnSignalDeviceLinkingCheck,
	// Token: 0x04001E84 RID: 7812
	OnSignalDeviceReset,
	// Token: 0x04001E85 RID: 7813
	OnSignalDeviceLinking,
	// Token: 0x04001E86 RID: 7814
	OnSignalDeviceFinish,
	// Token: 0x04001E87 RID: 7815
	OnOverlapSceneItemExploreInteractRange,
	// Token: 0x04001E88 RID: 7816
	OnUseMapExploreToolSuccess,
	// Token: 0x04001E89 RID: 7817
	OnMapExploreToolPlaceNumUpdated,
	// Token: 0x04001E8A RID: 7818
	DoLeaveLevel,
	// Token: 0x04001E8B RID: 7819
	OnInstanceChange,
	// Token: 0x04001E8C RID: 7820
	RefreshInputData,
	// Token: 0x04001E8D RID: 7821
	ClearSceneBegin,
	// Token: 0x04001E8E RID: 7822
	OnExploreProgressResponse,
	// Token: 0x04001E8F RID: 7823
	OnReceiveAreaStageRewardResponse,
	// Token: 0x04001E90 RID: 7824
	OnAreaExploreProgressUpdate,
	// Token: 0x04001E91 RID: 7825
	ToggleShowCustomMark,
	// Token: 0x04001E92 RID: 7826
	ToggleShowCompletedPlayMark,
	// Token: 0x04001E93 RID: 7827
	RedDotUpdateMapAreaBoxReward,
	// Token: 0x04001E94 RID: 7828
	AreaPlayPointUpdate,
	// Token: 0x04001E95 RID: 7829
	AreaStoryProgressSave,
	// Token: 0x04001E96 RID: 7830
	NavigateMarkAndShowRange,
	// Token: 0x04001E97 RID: 7831
	HideNavigateMarkRange,
	// Token: 0x04001E98 RID: 7832
	UpdateOnlinePlayersArea,
	// Token: 0x04001E99 RID: 7833
	PlayerMarkItemChanged,
	// Token: 0x04001E9A RID: 7834
	OpenExploreAreaDetailViewFromMap,
	// Token: 0x04001E9B RID: 7835
	OnExploreScoreRewardResponse,
	// Token: 0x04001E9C RID: 7836
	OnCountryExploreScoreInfoResponse,
	// Token: 0x04001E9D RID: 7837
	OnExploreLevelNotify,
	// Token: 0x04001E9E RID: 7838
	ShipTowerStageUpdate,
	// Token: 0x04001E9F RID: 7839
	ShipTowerRewardReceive,
	// Token: 0x04001EA0 RID: 7840
	ShipTowerBattleTip,
	// Token: 0x04001EA1 RID: 7841
	ShipTowerSureResetStage,
	// Token: 0x04001EA2 RID: 7842
	ShipTowerSureCoverChallenge,
	// Token: 0x04001EA3 RID: 7843
	ShipTowerTeamRecommendApplyFinish,
	// Token: 0x04001EA4 RID: 7844
	BattleUiToggleShipTowerBuffInfo,
	// Token: 0x04001EA5 RID: 7845
	RedDotUpdateShipTowerReward,
	// Token: 0x04001EA6 RID: 7846
	OpenActivityViewShipTower,
	// Token: 0x04001EA7 RID: 7847
	ShipTowerBuffNewUpdate,
	// Token: 0x04001EA8 RID: 7848
	ShipTowerEndlessRecordUpdate,
	// Token: 0x04001EA9 RID: 7849
	DangoMonopolyTaskUpdate,
	// Token: 0x04001EAA RID: 7850
	DangoMonopolyMoveStart,
	// Token: 0x04001EAB RID: 7851
	DangoMonopolyMovePause,
	// Token: 0x04001EAC RID: 7852
	DangoMonopolyMoveContinue,
	// Token: 0x04001EAD RID: 7853
	DangoMonopolyMoveEnd,
	// Token: 0x04001EAE RID: 7854
	DangoMonopolyEnterNextRound,
	// Token: 0x04001EAF RID: 7855
	DangoMonopolyBoardRewardUpdate,
	// Token: 0x04001EB0 RID: 7856
	DangoMonopolyGridRewardUpdate,
	// Token: 0x04001EB1 RID: 7857
	DangoMonopolyStartShowProcess,
	// Token: 0x04001EB2 RID: 7858
	DangoMonopolyEndShowProcess,
	// Token: 0x04001EB3 RID: 7859
	DangoMonopolyTransitionClose,
	// Token: 0x04001EB4 RID: 7860
	DangoMonopolyMoveStepStartOrEnd,
	// Token: 0x04001EB5 RID: 7861
	DangoMonopolyViewStart,
	// Token: 0x04001EB6 RID: 7862
	DangoMonopolyViewShowProcessStartOrEnd,
	// Token: 0x04001EB7 RID: 7863
	DangoMonopolyCameraFocusOnMainDango,
	// Token: 0x04001EB8 RID: 7864
	RedDotUpdateDangoMonopolyTask,
	// Token: 0x04001EB9 RID: 7865
	RedDotUpdateDangoMonopolyNum,
	// Token: 0x04001EBA RID: 7866
	RedDotUpdateDangoMonopolyRound,
	// Token: 0x04001EBB RID: 7867
	MoraleProgressRewardUpdate,
	// Token: 0x04001EBC RID: 7868
	MoraleProgressScoreUpdate,
	// Token: 0x04001EBD RID: 7869
	MoraleAreaChangeFlag,
	// Token: 0x04001EBE RID: 7870
	RedDotUpdateMoraleScoreBox,
	// Token: 0x04001EBF RID: 7871
	RedDotUpdateMoraleFlagBox,
	// Token: 0x04001EC0 RID: 7872
	RedDotUpdateMoraleAreaBuff,
	// Token: 0x04001EC1 RID: 7873
	BattleUiToggleMoraleBuffInfo,
	// Token: 0x04001EC2 RID: 7874
	OnMoralePromptShow,
	// Token: 0x04001EC3 RID: 7875
	ActivityMapExploreStateUpdate,
	// Token: 0x04001EC4 RID: 7876
	OnSignalCatchSuccess,
	// Token: 0x04001EC5 RID: 7877
	OnSignalCatchFailed,
	// Token: 0x04001EC6 RID: 7878
	OnSignalCatchStart,
	// Token: 0x04001EC7 RID: 7879
	OnSignalCatchContinue,
	// Token: 0x04001EC8 RID: 7880
	OnSignalCatchStartAgain,
	// Token: 0x04001EC9 RID: 7881
	RefreshMonthCardRedDot,
	// Token: 0x04001ECA RID: 7882
	OnSetJoystickMode,
	// Token: 0x04001ECB RID: 7883
	OnSetMotorcycleJoystickMode,
	// Token: 0x04001ECC RID: 7884
	OnMotorcycleRoundJoystickChanged,
	// Token: 0x04001ECD RID: 7885
	OnOverlapEncloseSpace,
	// Token: 0x04001ECE RID: 7886
	OnEncloseSpaceTypeChange,
	// Token: 0x04001ECF RID: 7887
	OnSubLevelAdded,
	// Token: 0x04001ED0 RID: 7888
	OnLevelEnvChange,
	// Token: 0x04001ED1 RID: 7889
	OnWorldOriginInUiMode,
	// Token: 0x04001ED2 RID: 7890
	OnAndroidConfigurationChange,
	// Token: 0x04001ED3 RID: 7891
	OnChatPlayerInfoChanged,
	// Token: 0x04001ED4 RID: 7892
	OnPlotTransitionRemoveCallback,
	// Token: 0x04001ED5 RID: 7893
	OnEnterOrExitExecutionRange,
	// Token: 0x04001ED6 RID: 7894
	OnExecutionOptionChange,
	// Token: 0x04001ED7 RID: 7895
	OnInteractActionEnd,
	// Token: 0x04001ED8 RID: 7896
	OnBeforeCharActionWithTarget,
	// Token: 0x04001ED9 RID: 7897
	CharActionStateChange,
	// Token: 0x04001EDA RID: 7898
	MReady,
	// Token: 0x04001EDB RID: 7899
	OnLevelFuncFlagSet,
	// Token: 0x04001EDC RID: 7900
	OnLevelFuncFlagChanged,
	// Token: 0x04001EDD RID: 7901
	OnRefreshRewardView,
	// Token: 0x04001EDE RID: 7902
	OnRefreshSpecialItemAllowReqUse,
	// Token: 0x04001EDF RID: 7903
	OnSdkFocusStateChange,
	// Token: 0x04001EE0 RID: 7904
	ReconnectClearData,
	// Token: 0x04001EE1 RID: 7905
	OnPreEndPIE,
	// Token: 0x04001EE2 RID: 7906
	NoticeJourneyReceive,
	// Token: 0x04001EE3 RID: 7907
	OnEntityInOutRangeLocal,
	// Token: 0x04001EE4 RID: 7908
	OnMyPlayerInOutRangeLocal,
	// Token: 0x04001EE5 RID: 7909
	OnStreamingTriggerConnected,
	// Token: 0x04001EE6 RID: 7910
	OnActorInOutRangeLocal,
	// Token: 0x04001EE7 RID: 7911
	OnEntityInOutRangeOnline,
	// Token: 0x04001EE8 RID: 7912
	OnPlayerInOutRangeOnline,
	// Token: 0x04001EE9 RID: 7913
	RoleTriggerInit,
	// Token: 0x04001EEA RID: 7914
	OnSetLoginServerId,
	// Token: 0x04001EEB RID: 7915
	SetDecalShadowEnabled,
	// Token: 0x04001EEC RID: 7916
	OnSelectTimePreset,
	// Token: 0x04001EED RID: 7917
	OnGlobalUiSceneStateChanged,
	// Token: 0x04001EEE RID: 7918
	OnSetGamePaused,
	// Token: 0x04001EEF RID: 7919
	OnActionKeyChanged,
	// Token: 0x04001EF0 RID: 7920
	OnAxisKeyChanged,
	// Token: 0x04001EF1 RID: 7921
	BeamCastStart,
	// Token: 0x04001EF2 RID: 7922
	BeamCastStop,
	// Token: 0x04001EF3 RID: 7923
	BeamCastActorChange,
	// Token: 0x04001EF4 RID: 7924
	BeamReflectStart,
	// Token: 0x04001EF5 RID: 7925
	BeamReflectStop,
	// Token: 0x04001EF6 RID: 7926
	OnResetPhotographCamera,
	// Token: 0x04001EF7 RID: 7927
	ClearAxisInputCache,
	// Token: 0x04001EF8 RID: 7928
	OnSpecialItemNotAllow,
	// Token: 0x04001EF9 RID: 7929
	OnMarkItemShowStateChange,
	// Token: 0x04001EFA RID: 7930
	OnMarkItemUpdateMarkHideInfo,
	// Token: 0x04001EFB RID: 7931
	OnTimeStopRequest,
	// Token: 0x04001EFC RID: 7932
	OnAbsoluteTimeStop,
	// Token: 0x04001EFD RID: 7933
	OnFightTestEnd,
	// Token: 0x04001EFE RID: 7934
	OnManipulateShowLandTips,
	// Token: 0x04001EFF RID: 7935
	BeforeUiModelLoadStart,
	// Token: 0x04001F00 RID: 7936
	OnUiModelRoleConfigIdChange,
	// Token: 0x04001F01 RID: 7937
	OnUiModelRoleDataIdChange,
	// Token: 0x04001F02 RID: 7938
	OnUiModelStartLoad,
	// Token: 0x04001F03 RID: 7939
	OnUiModelLoadComplete,
	// Token: 0x04001F04 RID: 7940
	OnUiModelSetMorphTypeComplete,
	// Token: 0x04001F05 RID: 7941
	OnUiModelVisibleChange,
	// Token: 0x04001F06 RID: 7942
	OnUiModelSetDitherEffect,
	// Token: 0x04001F07 RID: 7943
	WorldMapSubMapChanged,
	// Token: 0x04001F08 RID: 7944
	WorldMapSubMapChangedFromUpdate,
	// Token: 0x04001F09 RID: 7945
	WorldMapSelectMultiMap,
	// Token: 0x04001F0A RID: 7946
	RoguelikePopularEntriesChange,
	// Token: 0x04001F0B RID: 7947
	OnSceneItemSplineMoveBroken,
	// Token: 0x04001F0C RID: 7948
	OnSceneItemSplineMoveStarted,
	// Token: 0x04001F0D RID: 7949
	OnSceneItemSplineMoveStopped,
	// Token: 0x04001F0E RID: 7950
	OnSceneItemMoveBroken,
	// Token: 0x04001F0F RID: 7951
	OnSceneItemMoveStopped,
	// Token: 0x04001F10 RID: 7952
	OnSceneItemRotateStopped,
	// Token: 0x04001F11 RID: 7953
	OnFragmentMemoryDataUpdate,
	// Token: 0x04001F12 RID: 7954
	OnFragmentMemoryCollectUpdate,
	// Token: 0x04001F13 RID: 7955
	OnFragmentTopicSelect,
	// Token: 0x04001F14 RID: 7956
	OnFragmentTopicClick,
	// Token: 0x04001F15 RID: 7957
	FragmentRewardRedDot,
	// Token: 0x04001F16 RID: 7958
	FragmentRewardTopicRedDot,
	// Token: 0x04001F17 RID: 7959
	FragmentRewardEntranceRedDot,
	// Token: 0x04001F18 RID: 7960
	OnChangeBossRushBuff,
	// Token: 0x04001F19 RID: 7961
	RequestChangeBossRushView,
	// Token: 0x04001F1A RID: 7962
	BossRushDataUpdate,
	// Token: 0x04001F1B RID: 7963
	BossRefreshBossRushRewardRedDot,
	// Token: 0x04001F1C RID: 7964
	BossRefreshBossRushReward,
	// Token: 0x04001F1D RID: 7965
	BossRushBuffTabChange,
	// Token: 0x04001F1E RID: 7966
	BossRushSubViewChanged,
	// Token: 0x04001F1F RID: 7967
	BossRushTaskStateChanged,
	// Token: 0x04001F20 RID: 7968
	RefreshMowingTowerData,
	// Token: 0x04001F21 RID: 7969
	RefreshMowingTowerRewardRedDot,
	// Token: 0x04001F22 RID: 7970
	RefreshMowingTowerReward,
	// Token: 0x04001F23 RID: 7971
	ChangeMowingTowerBuff,
	// Token: 0x04001F24 RID: 7972
	ChangeMowingTowerMainView,
	// Token: 0x04001F25 RID: 7973
	TowerDefenseOnOpenPhantomView,
	// Token: 0x04001F26 RID: 7974
	TowerDefenseOnClickOnePhantom,
	// Token: 0x04001F27 RID: 7975
	TowerDefenseSelfPhantomConfirm,
	// Token: 0x04001F28 RID: 7976
	TowerDefensePhantomChanged,
	// Token: 0x04001F29 RID: 7977
	TowerDefenseBeforeConfirmQuickRoleSelect,
	// Token: 0x04001F2A RID: 7978
	TowerDefenseOnWaveChanged,
	// Token: 0x04001F2B RID: 7979
	TowerDefenseOnActivityInfoUpdateNotify,
	// Token: 0x04001F2C RID: 7980
	TowerDefenseOnInstanceInfoUpdateNotify,
	// Token: 0x04001F2D RID: 7981
	TowerDefenseOnPhantomInfoUpdateNotify,
	// Token: 0x04001F2E RID: 7982
	TowerDefenseShowInBattleView,
	// Token: 0x04001F2F RID: 7983
	TowerDefenseOnShowPhantomInFormation,
	// Token: 0x04001F30 RID: 7984
	TowerDefenseOnTowerDefenseBattleEndNotify,
	// Token: 0x04001F31 RID: 7985
	TowerDefenseDataInit,
	// Token: 0x04001F32 RID: 7986
	OnBeforeDestroyInstanceDungeonEntranceView,
	// Token: 0x04001F33 RID: 7987
	TrapFollowerSkillCd,
	// Token: 0x04001F34 RID: 7988
	RefreshTrapDefensePsFeedback,
	// Token: 0x04001F35 RID: 7989
	TowerDefenseRecycleRaycastNotify,
	// Token: 0x04001F36 RID: 7990
	TowerDefenseEventStepUpdate,
	// Token: 0x04001F37 RID: 7991
	TowerDefenseEventNotifyType,
	// Token: 0x04001F38 RID: 7992
	TrapDefenseMapMarkRemoved,
	// Token: 0x04001F39 RID: 7993
	TrapDefenseMapChanged,
	// Token: 0x04001F3A RID: 7994
	TrapDefenseComboNumChange,
	// Token: 0x04001F3B RID: 7995
	TrapDefenseOnSystemInfoNotify,
	// Token: 0x04001F3C RID: 7996
	OnClickEnterInstanceSingle,
	// Token: 0x04001F3D RID: 7997
	OnNeedRefreshByProtocol,
	// Token: 0x04001F3E RID: 7998
	MowingBasicBuffGridItemClick,
	// Token: 0x04001F3F RID: 7999
	MowingSuperBuffGridItemClick,
	// Token: 0x04001F40 RID: 8000
	MowingRiskInBattleViewSetActive,
	// Token: 0x04001F41 RID: 8001
	MowingRiskInBattleRootUpdate,
	// Token: 0x04001F42 RID: 8002
	MowingRiskOnInstanceClearRewardResponse,
	// Token: 0x04001F43 RID: 8003
	MowingRiskOnScoreRewardResponse,
	// Token: 0x04001F44 RID: 8004
	MowingRiskOnBuffCountRewardResponse,
	// Token: 0x04001F45 RID: 8005
	MowingRiskOnRefreshRewardRedDot,
	// Token: 0x04001F46 RID: 8006
	MowingRiskOnRefreshBuffAllRedDot,
	// Token: 0x04001F47 RID: 8007
	MowingRiskOnBuffTipsAfterDestroy,
	// Token: 0x04001F48 RID: 8008
	MowingRiskOnNeedPlayLevelUpSequence,
	// Token: 0x04001F49 RID: 8009
	MowingRiskOnGetReward,
	// Token: 0x04001F4A RID: 8010
	SpecialOpenMapAction,
	// Token: 0x04001F4B RID: 8011
	VersionPreheatRewardResponse,
	// Token: 0x04001F4C RID: 8012
	VersionPreheatOnClickVote,
	// Token: 0x04001F4D RID: 8013
	VersionPreheatSendVote,
	// Token: 0x04001F4E RID: 8014
	Spring25DrawRewardDone,
	// Token: 0x04001F4F RID: 8015
	Spring25SkinRewardDone,
	// Token: 0x04001F50 RID: 8016
	Spring25InviteDone,
	// Token: 0x04001F51 RID: 8017
	Spring25SelectLetter,
	// Token: 0x04001F52 RID: 8018
	Spring25ActivityParseDone,
	// Token: 0x04001F53 RID: 8019
	Spring25CloseLetterList,
	// Token: 0x04001F54 RID: 8020
	Spring25UnlockAnimDone,
	// Token: 0x04001F55 RID: 8021
	OnSetGameModeDataDone,
	// Token: 0x04001F56 RID: 8022
	OnBossRushBuffViewOpened,
	// Token: 0x04001F57 RID: 8023
	OnTutorialTipExistChanged,
	// Token: 0x04001F58 RID: 8024
	OnTutorialUpdate,
	// Token: 0x04001F59 RID: 8025
	AddLevelLoadingTimeDilationTag,
	// Token: 0x04001F5A RID: 8026
	RemoveLevelLoadingTimeDilationTag,
	// Token: 0x04001F5B RID: 8027
	RogueLevelLoadingLockTimeDilation,
	// Token: 0x04001F5C RID: 8028
	RogueLevelLoadingUnlockTimeDilation,
	// Token: 0x04001F5D RID: 8029
	BusinessInvestResult,
	// Token: 0x04001F5E RID: 8030
	SetDelegationResultData,
	// Token: 0x04001F5F RID: 8031
	PopularityChange,
	// Token: 0x04001F60 RID: 8032
	OpenTipsTravelView,
	// Token: 0x04001F61 RID: 8033
	OpenTipsShopView,
	// Token: 0x04001F62 RID: 8034
	UnlockMoonChasingData,
	// Token: 0x04001F63 RID: 8035
	RefreshCorniceMeetingRedDot,
	// Token: 0x04001F64 RID: 8036
	OnClickActivityCorniceMeetingTab,
	// Token: 0x04001F65 RID: 8037
	OnPlayerFollowerConfigChanged,
	// Token: 0x04001F66 RID: 8038
	OnPlayerFollowerPossessed,
	// Token: 0x04001F67 RID: 8039
	OnPlayerFollowerUnPossessed,
	// Token: 0x04001F68 RID: 8040
	OnPlayerFollowerEnableChange,
	// Token: 0x04001F69 RID: 8041
	OnFollowerAdd,
	// Token: 0x04001F6A RID: 8042
	BuildAnimFinish,
	// Token: 0x04001F6B RID: 8043
	ConditionUnlockRole,
	// Token: 0x04001F6C RID: 8044
	TakenRewardTargetData,
	// Token: 0x04001F6D RID: 8045
	RefreshRewardTargetData,
	// Token: 0x04001F6E RID: 8046
	RefreshDelegate,
	// Token: 0x04001F6F RID: 8047
	ElevatorMove,
	// Token: 0x04001F70 RID: 8048
	OnHighSpeedModeChanged,
	// Token: 0x04001F71 RID: 8049
	SlowStreamingBySoar,
	// Token: 0x04001F72 RID: 8050
	OnDropDownListVisibleChanged,
	// Token: 0x04001F73 RID: 8051
	OnGlobalFootstepMaterialChange,
	// Token: 0x04001F74 RID: 8052
	OnForbidWeatherStateChange,
	// Token: 0x04001F75 RID: 8053
	OnPortalRegister,
	// Token: 0x04001F76 RID: 8054
	OnPortalUnRegister,
	// Token: 0x04001F77 RID: 8055
	OnRolePassPortalBeforeTeleport,
	// Token: 0x04001F78 RID: 8056
	OnRolePassPortalAfterTeleport,
	// Token: 0x04001F79 RID: 8057
	OnEnterVehicle,
	// Token: 0x04001F7A RID: 8058
	OnLeaveVehicle,
	// Token: 0x04001F7B RID: 8059
	OnVehicleBeenEntered,
	// Token: 0x04001F7C RID: 8060
	OnVehicleBeenLeaved,
	// Token: 0x04001F7D RID: 8061
	OnEnterVehicleAtOnceResponse,
	// Token: 0x04001F7E RID: 8062
	OnLeaveVehicleAtOnceResponse,
	// Token: 0x04001F7F RID: 8063
	OnEnterVehicleRideSharing,
	// Token: 0x04001F80 RID: 8064
	OnLeaveVehicleRideSharing,
	// Token: 0x04001F81 RID: 8065
	OnChangeRideSharingPassenger,
	// Token: 0x04001F82 RID: 8066
	OnRemoveRideSharingPassenger,
	// Token: 0x04001F83 RID: 8067
	OnChangeRideSharingPassengerResponse,
	// Token: 0x04001F84 RID: 8068
	OnRemoveRideSharingPassengerResponse,
	// Token: 0x04001F85 RID: 8069
	OnChangeRideSharingPassengerNotify,
	// Token: 0x04001F86 RID: 8070
	OnRemoveRideSharingPassengerNotify,
	// Token: 0x04001F87 RID: 8071
	OnSpecialVehicleShareNotify,
	// Token: 0x04001F88 RID: 8072
	OnMovieMotorRideSharingModeChangeRequest,
	// Token: 0x04001F89 RID: 8073
	OnMovieMotorRideSharingModeChangeResponse,
	// Token: 0x04001F8A RID: 8074
	OnVehicleSkillEnableChanged,
	// Token: 0x04001F8B RID: 8075
	OnVehicleSkillUsableCountChanged,
	// Token: 0x04001F8C RID: 8076
	OnBeforeAttachVehicle,
	// Token: 0x04001F8D RID: 8077
	OnAfterAttachVehicle,
	// Token: 0x04001F8E RID: 8078
	OnWaterfallMoveBegin,
	// Token: 0x04001F8F RID: 8079
	OnWaterfallMoveEnd,
	// Token: 0x04001F90 RID: 8080
	OnVehicleDriverChange,
	// Token: 0x04001F91 RID: 8081
	OnVehicleActivate,
	// Token: 0x04001F92 RID: 8082
	OnCoBathSwitchFirstPlayerView,
	// Token: 0x04001F93 RID: 8083
	OnChangeModuleDebugLevel,
	// Token: 0x04001F94 RID: 8084
	OnBattleLinkStop,
	// Token: 0x04001F95 RID: 8085
	OnBattleLinkRestart,
	// Token: 0x04001F96 RID: 8086
	OnBattleLinkStatusChanged,
	// Token: 0x04001F97 RID: 8087
	OnNewLinkStatusChanged,
	// Token: 0x04001F98 RID: 8088
	OnBattleLinkToggle,
	// Token: 0x04001F99 RID: 8089
	OnMoraleActiveChanged,
	// Token: 0x04001F9A RID: 8090
	OnMoraleExpChanged,
	// Token: 0x04001F9B RID: 8091
	OnMoraleTempExpChanged,
	// Token: 0x04001F9C RID: 8092
	OnMoraleSumLevelChanged,
	// Token: 0x04001F9D RID: 8093
	OnMoraleIndomitableLevelChanged,
	// Token: 0x04001F9E RID: 8094
	OnMoralePlayIndomitableLevelAnim,
	// Token: 0x04001F9F RID: 8095
	OnMoraleTempExpViewVisibleChanged,
	// Token: 0x04001FA0 RID: 8096
	OnMoraleBattleFail,
	// Token: 0x04001FA1 RID: 8097
	OnMarkActorInFighting,
	// Token: 0x04001FA2 RID: 8098
	OnPunishMarkStateChanged,
	// Token: 0x04001FA3 RID: 8099
	OnInputSettingResponse,
	// Token: 0x04001FA4 RID: 8100
	OnInputSettingUpdateNotify,
	// Token: 0x04001FA5 RID: 8101
	RecallActivityInfoUpdate,
	// Token: 0x04001FA6 RID: 8102
	ActivityDirectTrainDataUpdate,
	// Token: 0x04001FA7 RID: 8103
	ActivityDirectTrainRedDotUpdate,
	// Token: 0x04001FA8 RID: 8104
	OnActivityDirectTrainProSetActive,
	// Token: 0x04001FA9 RID: 8105
	OnScratchTicketConditionRefresh,
	// Token: 0x04001FAA RID: 8106
	OnSelectRoleDreamDungeon,
	// Token: 0x04001FAB RID: 8107
	OnMailBindInfoResponse,
	// Token: 0x04001FAC RID: 8108
	OnMailBindRewardResponse,
	// Token: 0x04001FAD RID: 8109
	OnMailBindResponse,
	// Token: 0x04001FAE RID: 8110
	OnMailBindInfoNotify,
	// Token: 0x04001FAF RID: 8111
	RefreshMailBindRedDot,
	// Token: 0x04001FB0 RID: 8112
	CharacterWeaponLoaded,
	// Token: 0x04001FB1 RID: 8113
	FightWeaponSkinChange,
	// Token: 0x04001FB2 RID: 8114
	EquipWeaponSkin,
	// Token: 0x04001FB3 RID: 8115
	UninstallWeaponSkin,
	// Token: 0x04001FB4 RID: 8116
	OnRoleFlyEquipNotify,
	// Token: 0x04001FB5 RID: 8117
	OnRoleFlyEquipChangeNotify,
	// Token: 0x04001FB6 RID: 8118
	OnFlySkinEquipResponse,
	// Token: 0x04001FB7 RID: 8119
	OnFlySkinUnLoadResponse,
	// Token: 0x04001FB8 RID: 8120
	OnFlySkinAllUnLoadResponse,
	// Token: 0x04001FB9 RID: 8121
	OnFlySkinEquipToAllRoleResponse,
	// Token: 0x04001FBA RID: 8122
	OnRoleFlySkinChange,
	// Token: 0x04001FBB RID: 8123
	OnFlyEquipAddNotify,
	// Token: 0x04001FBC RID: 8124
	RefreshFlySkinTabRedDot,
	// Token: 0x04001FBD RID: 8125
	RefreshFlySkinChildTabRed,
	// Token: 0x04001FBE RID: 8126
	OnSkinRootViewDestroy,
	// Token: 0x04001FBF RID: 8127
	OnUpdateAreaAlertEnable,
	// Token: 0x04001FC0 RID: 8128
	OnUpdateAreaAlertValue,
	// Token: 0x04001FC1 RID: 8129
	OnUpdateAreaAlertUiEnable,
	// Token: 0x04001FC2 RID: 8130
	OnUpdateAreaAlertUiVisible,
	// Token: 0x04001FC3 RID: 8131
	LevelPlayReportSimpleUpdate,
	// Token: 0x04001FC4 RID: 8132
	LevelPlayReportDetailUpdate,
	// Token: 0x04001FC5 RID: 8133
	LevelPlayStateDetailUpdate,
	// Token: 0x04001FC6 RID: 8134
	OnBigStuffedDollGameStageUpdate,
	// Token: 0x04001FC7 RID: 8135
	OnBigStuffedDollArrowStayAreaUpdate,
	// Token: 0x04001FC8 RID: 8136
	OnBigStuffedDollRingItemSequencePlayStart,
	// Token: 0x04001FC9 RID: 8137
	OnBigStuffedDollRingItemSequencePlayEnd,
	// Token: 0x04001FCA RID: 8138
	OnRacingBetsDataRefresh,
	// Token: 0x04001FCB RID: 8139
	OnRacingBetsBettingInfoUpdate,
	// Token: 0x04001FCC RID: 8140
	OnRacingBetsPlayerInfoUpdate,
	// Token: 0x04001FCD RID: 8141
	OnRacingBetsDangoOddsUpdate,
	// Token: 0x04001FCE RID: 8142
	OnRacingBetsRewardRefresh,
	// Token: 0x04001FCF RID: 8143
	OnRacingBetsDangoOrderRefresh,
	// Token: 0x04001FD0 RID: 8144
	OnRacingBetsDangoOrderEnd,
	// Token: 0x04001FD1 RID: 8145
	OnRacingBetsDangoRoundStart,
	// Token: 0x04001FD2 RID: 8146
	OnRacingBetsDiceAnim,
	// Token: 0x04001FD3 RID: 8147
	OnRacingBetsDiceAnimEnd,
	// Token: 0x04001FD4 RID: 8148
	OnRacingBetsDungeonDangoRankChange,
	// Token: 0x04001FD5 RID: 8149
	OnRacingBetsLegMatchEnd,
	// Token: 0x04001FD6 RID: 8150
	OnRacingBetsRedDotUpdate,
	// Token: 0x04001FD7 RID: 8151
	OnRacingBetsPushBulletScreen,
	// Token: 0x04001FD8 RID: 8152
	OnRacingBetsViewAfterShow,
	// Token: 0x04001FD9 RID: 8153
	OnRacingBetsReplay,
	// Token: 0x04001FDA RID: 8154
	OnFloroRanchNextDayTaskRefresh,
	// Token: 0x04001FDB RID: 8155
	OnFloroRanchInsertTask,
	// Token: 0x04001FDC RID: 8156
	OnFloroRanchStageInfoRefresh,
	// Token: 0x04001FDD RID: 8157
	OnFloroRanchCardEntityCountChange,
	// Token: 0x04001FDE RID: 8158
	FloroRanchDataRedDot,
	// Token: 0x04001FDF RID: 8159
	FloroRanchRaceRedDot,
	// Token: 0x04001FE0 RID: 8160
	FloroRanchSkillChange,
	// Token: 0x04001FE1 RID: 8161
	FloroRanchSkillRedDotRefresh,
	// Token: 0x04001FE2 RID: 8162
	FloroRanchSettlement,
	// Token: 0x04001FE3 RID: 8163
	FloroRanchWeeklySettlement,
	// Token: 0x04001FE4 RID: 8164
	FloroRanchSubInsHistoryUpdate,
	// Token: 0x04001FE5 RID: 8165
	OnFloroRanchDebugInfoRefresh,
	// Token: 0x04001FE6 RID: 8166
	OnFloroRanchSuccessSettleViewOpen,
	// Token: 0x04001FE7 RID: 8167
	OnFloroRanchStageStartTaskBeforeFinish,
	// Token: 0x04001FE8 RID: 8168
	FishingRefreshBackpackData,
	// Token: 0x04001FE9 RID: 8169
	FishingBackpackDeliverableRefresh,
	// Token: 0x04001FEA RID: 8170
	FishingShipSkinChangeSuccess,
	// Token: 0x04001FEB RID: 8171
	DriveFishingShipStateChanged,
	// Token: 0x04001FEC RID: 8172
	FishingRefreshQuestView,
	// Token: 0x04001FED RID: 8173
	FishingRefreshDockId,
	// Token: 0x04001FEE RID: 8174
	OnRefreshTempFishingPointNum,
	// Token: 0x04001FEF RID: 8175
	FishingEntrustStartShowTrackText,
	// Token: 0x04001FF0 RID: 8176
	FishingEntrustEndShowTrackText,
	// Token: 0x04001FF1 RID: 8177
	OnFishingSailing,
	// Token: 0x04001FF2 RID: 8178
	FishingRefreshHandBookRewardView,
	// Token: 0x04001FF3 RID: 8179
	FishingShipDataRefresh,
	// Token: 0x04001FF4 RID: 8180
	FishingPointFinish,
	// Token: 0x04001FF5 RID: 8181
	OnFishingQteStageUpdate,
	// Token: 0x04001FF6 RID: 8182
	OnFishingQteAreaChange,
	// Token: 0x04001FF7 RID: 8183
	OnFishingTechNodeRefresh,
	// Token: 0x04001FF8 RID: 8184
	OnFishingTechNodeRedDotRefresh,
	// Token: 0x04001FF9 RID: 8185
	OnFishingRoleTechRefresh,
	// Token: 0x04001FFA RID: 8186
	FishingTimeLimitRewardListRefresh,
	// Token: 0x04001FFB RID: 8187
	FishingTimeLimitRewardProgressRefresh,
	// Token: 0x04001FFC RID: 8188
	FishingTimeLimitShopRefresh,
	// Token: 0x04001FFD RID: 8189
	FishingShipSkinClick,
	// Token: 0x04001FFE RID: 8190
	FishingTechViewComeBack,
	// Token: 0x04001FFF RID: 8191
	FishingRoleTechViewOpened,
	// Token: 0x04002000 RID: 8192
	FishingDockyardItemTipsShown,
	// Token: 0x04002001 RID: 8193
	FishingQteBtnHitValidArea,
	// Token: 0x04002002 RID: 8194
	OnFishingQteScoreReachedMaximum,
	// Token: 0x04002003 RID: 8195
	FishingBackpackBtnStateChange,
	// Token: 0x04002004 RID: 8196
	OnTreasureCompassUnitVisibleChange,
	// Token: 0x04002005 RID: 8197
	OnFishingBackpackQuickSellToggleStateChange,
	// Token: 0x04002006 RID: 8198
	PlayerSoarChanged,
	// Token: 0x04002007 RID: 8199
	FilterCriteriaChanged,
	// Token: 0x04002008 RID: 8200
	EntityToLoadFilterCreated,
	// Token: 0x04002009 RID: 8201
	EntityToLoadFilterDestroyed,
	// Token: 0x0400200A RID: 8202
	EntityToLoadParamUpdated,
	// Token: 0x0400200B RID: 8203
	VehicleInputLayerPress,
	// Token: 0x0400200C RID: 8204
	VehicleInputLayerRelease,
	// Token: 0x0400200D RID: 8205
	SkillLongPressStart,
	// Token: 0x0400200E RID: 8206
	SkillLongPressEnd,
	// Token: 0x0400200F RID: 8207
	CheckClientEvent,
	// Token: 0x04002010 RID: 8208
	StartMoveWithSpline,
	// Token: 0x04002011 RID: 8209
	OnPhonographSwitchMusic,
	// Token: 0x04002012 RID: 8210
	OnPhonographSelectDisable,
	// Token: 0x04002013 RID: 8211
	OnPhonographPlayTick,
	// Token: 0x04002014 RID: 8212
	OnPhonographPlayStop,
	// Token: 0x04002015 RID: 8213
	OnPhonographRemoveNewTag,
	// Token: 0x04002016 RID: 8214
	OnPhonographSetBgm,
	// Token: 0x04002017 RID: 8215
	OnPhonographMusicForceRefresh,
	// Token: 0x04002018 RID: 8216
	RefreshActivityEntranceScroller,
	// Token: 0x04002019 RID: 8217
	RefreshActivityEntranceItemContent,
	// Token: 0x0400201A RID: 8218
	FarmGoldRefreshRewardRedDot,
	// Token: 0x0400201B RID: 8219
	EntityCampModify,
	// Token: 0x0400201C RID: 8220
	MobileGamepadDisconnect,
	// Token: 0x0400201D RID: 8221
	DisableCustomInputData,
	// Token: 0x0400201E RID: 8222
	EnableCacheCustomInputData,
	// Token: 0x0400201F RID: 8223
	EnableActionRecord,
	// Token: 0x04002020 RID: 8224
	SolarSpeedClickRewardTab,
	// Token: 0x04002021 RID: 8225
	SolarSpeedRewarded,
	// Token: 0x04002022 RID: 8226
	SolarSpeedSubViewOnRefreshView,
	// Token: 0x04002023 RID: 8227
	ShipTowerTeamPanelShown,
	// Token: 0x04002024 RID: 8228
	OnCharacterMorphTypeChanged,
	// Token: 0x04002025 RID: 8229
	OnBeforeCharacterMorphTypeChanged,
	// Token: 0x04002026 RID: 8230
	OnCharacterSetMaster,
	// Token: 0x04002027 RID: 8231
	OnSwitchSelfCenteredMode,
	// Token: 0x04002028 RID: 8232
	OnGravityFlipAnimFinish,
	// Token: 0x04002029 RID: 8233
	BabelTowerRefreshLevelInfo,
	// Token: 0x0400202A RID: 8234
	BabelTowerRefreshQuestState,
	// Token: 0x0400202B RID: 8235
	BabelTowerDifficultyLevelClick,
	// Token: 0x0400202C RID: 8236
	BabelTowerLevelClick,
	// Token: 0x0400202D RID: 8237
	BabelTowerLevelRedDotUpdate,
	// Token: 0x0400202E RID: 8238
	BabelTowerDifficultyRedDotUpdate,
	// Token: 0x0400202F RID: 8239
	OnBabelActivityInstInfoUpdate,
	// Token: 0x04002030 RID: 8240
	OnAbyssRoleInfoUpdate,
	// Token: 0x04002031 RID: 8241
	OnAbyssPluginInfoUpdate,
	// Token: 0x04002032 RID: 8242
	OnAbyssRewardStateUpdate,
	// Token: 0x04002033 RID: 8243
	RefreshAbyssRewardRedDot,
	// Token: 0x04002034 RID: 8244
	OnAbyssUnlockChallengeStateUpdate,
	// Token: 0x04002035 RID: 8245
	OnAbyssChallengeResult,
	// Token: 0x04002036 RID: 8246
	OnAbyssLikeChange,
	// Token: 0x04002037 RID: 8247
	OnAbyssFormationUpdate,
	// Token: 0x04002038 RID: 8248
	OnAbyssAddRole,
	// Token: 0x04002039 RID: 8249
	OnAbyssDangoLevelUp,
	// Token: 0x0400203A RID: 8250
	OnAbyssPluginItemEquip,
	// Token: 0x0400203B RID: 8251
	OnAbyssPluginRecovery,
	// Token: 0x0400203C RID: 8252
	RefreshAbyssDevelopRedDot,
	// Token: 0x0400203D RID: 8253
	OnAbyssDangoSelect,
	// Token: 0x0400203E RID: 8254
	RefreshAbyssDangoRedDot,
	// Token: 0x0400203F RID: 8255
	OnAbyssRoomInfoUpdate,
	// Token: 0x04002040 RID: 8256
	OnAbyssFirstRoomEnter,
	// Token: 0x04002041 RID: 8257
	OnAbyssRoomPreloadFinished,
	// Token: 0x04002042 RID: 8258
	RefreshFormationDango,
	// Token: 0x04002043 RID: 8259
	ShowBadDangoTip,
	// Token: 0x04002044 RID: 8260
	OnAbyssPluginDangoSelect,
	// Token: 0x04002045 RID: 8261
	OnAbyssTeamBtnVisibleRefresh,
	// Token: 0x04002046 RID: 8262
	OnAbyssPluginEquipAttrRefresh,
	// Token: 0x04002047 RID: 8263
	PreDownloadStateUpdate,
	// Token: 0x04002048 RID: 8264
	OnPreDownloadAvailableUpdate,
	// Token: 0x04002049 RID: 8265
	InviteNewbieEntered,
	// Token: 0x0400204A RID: 8266
	InviteNewbieInviteCodeChanged,
	// Token: 0x0400204B RID: 8267
	RefreshCommonH5ActivityRedDot,
	// Token: 0x0400204C RID: 8268
	OnCiacconaAvgReChoose,
	// Token: 0x0400204D RID: 8269
	OnCiacconaReChooseConfirm,
	// Token: 0x0400204E RID: 8270
	OnCiacconaReChooseCancel,
	// Token: 0x0400204F RID: 8271
	NotifyBtCiacconaChapterFinish,
	// Token: 0x04002050 RID: 8272
	OnCiacconaChapterFinish,
	// Token: 0x04002051 RID: 8273
	OnCiacconaChapterDataUpdate,
	// Token: 0x04002052 RID: 8274
	OnCiacconaInspirationDataUpdate,
	// Token: 0x04002053 RID: 8275
	OnCiacconaEndingDataUpdate,
	// Token: 0x04002054 RID: 8276
	OnCiacconaRewardDataUpdate,
	// Token: 0x04002055 RID: 8277
	OnCiacconaActivityStateUpdate,
	// Token: 0x04002056 RID: 8278
	OnCiacconaAvgInspirationChoiceShow,
	// Token: 0x04002057 RID: 8279
	OnCiacconaChapterFirstStart,
	// Token: 0x04002058 RID: 8280
	OnCiacconaChapterRestart,
	// Token: 0x04002059 RID: 8281
	OnTermExplanationViewOpening,
	// Token: 0x0400205A RID: 8282
	OnTermExplanationViewBeforeStart,
	// Token: 0x0400205B RID: 8283
	OnTermExplanationViewClosed,
	// Token: 0x0400205C RID: 8284
	OnTermExplanationRegisteredTextContentChange,
	// Token: 0x0400205D RID: 8285
	OnQuestReviewMainViewBeforeHide,
	// Token: 0x0400205E RID: 8286
	OnOpenQuestReviewDetail,
	// Token: 0x0400205F RID: 8287
	ResDownLoadStateRefresh,
	// Token: 0x04002060 RID: 8288
	RefreshRound,
	// Token: 0x04002061 RID: 8289
	OwnBattleStatusChange,
	// Token: 0x04002062 RID: 8290
	OwnBattleAttrChange,
	// Token: 0x04002063 RID: 8291
	OwnHandCardAdd,
	// Token: 0x04002064 RID: 8292
	OwnHandCardRemove,
	// Token: 0x04002065 RID: 8293
	OwnHandCardAddFourCost,
	// Token: 0x04002066 RID: 8294
	OpponentBattleStatusChange,
	// Token: 0x04002067 RID: 8295
	OpponentBattleAttrChange,
	// Token: 0x04002068 RID: 8296
	ReplaceCardFinish,
	// Token: 0x04002069 RID: 8297
	OwnCardLibraryChange,
	// Token: 0x0400206A RID: 8298
	OpponentHandCardChange,
	// Token: 0x0400206B RID: 8299
	OpponentCardLibraryChange,
	// Token: 0x0400206C RID: 8300
	PhantomArenaTriggerSkillEffect,
	// Token: 0x0400206D RID: 8301
	NotifyCardTaskData,
	// Token: 0x0400206E RID: 8302
	DiscardCardPanelActive,
	// Token: 0x0400206F RID: 8303
	ReserveCardPanelActive,
	// Token: 0x04002070 RID: 8304
	RefreshBattleCardNum,
	// Token: 0x04002071 RID: 8305
	RefreshHandCardState,
	// Token: 0x04002072 RID: 8306
	PhantomArenaCardAttrRefresh,
	// Token: 0x04002073 RID: 8307
	PhantomArenaCardFactorsRefresh,
	// Token: 0x04002074 RID: 8308
	OnPhantomArenaCardUnlock,
	// Token: 0x04002075 RID: 8309
	OnPhantomArenaCardOutlookUnlock,
	// Token: 0x04002076 RID: 8310
	NotifyBattleCardChange,
	// Token: 0x04002077 RID: 8311
	OnPhantomArenaTaskAwardUpdate,
	// Token: 0x04002078 RID: 8312
	OnPhantomArenaMasterInfoUpdate,
	// Token: 0x04002079 RID: 8313
	OnPhantomArenaCardRewardUpdate,
	// Token: 0x0400207A RID: 8314
	OnPhantomArenaBadgeRewardUpdate,
	// Token: 0x0400207B RID: 8315
	OnPhantomArenaChallengeUpdate,
	// Token: 0x0400207C RID: 8316
	OnPhantomArenaRoleRewardUpdate,
	// Token: 0x0400207D RID: 8317
	OnPhantomArenaShopOpen,
	// Token: 0x0400207E RID: 8318
	OnPhantomArenaBattleLoadingHide,
	// Token: 0x0400207F RID: 8319
	OnPhantomArenaBattleDamageAccumulateEnd,
	// Token: 0x04002080 RID: 8320
	PhantomArenaStartTurnResult,
	// Token: 0x04002081 RID: 8321
	OnPhantomArenaHandCardsShowHideChange,
	// Token: 0x04002082 RID: 8322
	OnPhantomArenaCardDetailShowHideChange,
	// Token: 0x04002083 RID: 8323
	OnPhantomArenaBattleCardNumChange,
	// Token: 0x04002084 RID: 8324
	OnPhantomArenaChildViewOpen,
	// Token: 0x04002085 RID: 8325
	OnHandAreaAddCard,
	// Token: 0x04002086 RID: 8326
	GamepadTriggerCardInfo,
	// Token: 0x04002087 RID: 8327
	PhantomBattleBoardSettleNotify,
	// Token: 0x04002088 RID: 8328
	OpponentSealFieldChange,
	// Token: 0x04002089 RID: 8329
	OwnSealRecycleChange,
	// Token: 0x0400208A RID: 8330
	OnFieldCardSkillActivated,
	// Token: 0x0400208B RID: 8331
	CumulativeShopTaskRefresh,
	// Token: 0x0400208C RID: 8332
	CumulativeShopTaskViewDataRefresh,
	// Token: 0x0400208D RID: 8333
	RefreshPlayerInfoVisible,
	// Token: 0x0400208E RID: 8334
	UpdateRayTraceReflection,
	// Token: 0x0400208F RID: 8335
	OnEntityBeSlashAim,
	// Token: 0x04002090 RID: 8336
	OnSelectHintChange,
	// Token: 0x04002091 RID: 8337
	OnInEntityInteractRangeChange,
	// Token: 0x04002092 RID: 8338
	OnInteractionSpotStateChange,
	// Token: 0x04002093 RID: 8339
	SetInteractSpotOccupied,
	// Token: 0x04002094 RID: 8340
	OnInteractionLongPressProgressChange,
	// Token: 0x04002095 RID: 8341
	RefreshBeginnerCarnivalTask,
	// Token: 0x04002096 RID: 8342
	NpcAnimStateSwitchBegin,
	// Token: 0x04002097 RID: 8343
	NpcAnimStateSwitchEnd,
	// Token: 0x04002098 RID: 8344
	SoarTypeChange,
	// Token: 0x04002099 RID: 8345
	OnDemoInteractiveActorAdd,
	// Token: 0x0400209A RID: 8346
	OnDemoInteractiveActorRemove,
	// Token: 0x0400209B RID: 8347
	OnDemoInteractiveActorMemberUpdated,
	// Token: 0x0400209C RID: 8348
	OnDemoInteractiveActorMemberCalled,
	// Token: 0x0400209D RID: 8349
	TuningStandUpdate,
	// Token: 0x0400209E RID: 8350
	TuningStandSuccess,
	// Token: 0x0400209F RID: 8351
	TuningStandSuccessShowStart,
	// Token: 0x040020A0 RID: 8352
	TuningStandSuccessShowEnd,
	// Token: 0x040020A1 RID: 8353
	TuningStandBubbleUpdate,
	// Token: 0x040020A2 RID: 8354
	TuningStandBubbleEnd,
	// Token: 0x040020A3 RID: 8355
	TuningStandTooLongTime,
	// Token: 0x040020A4 RID: 8356
	TuningStandOnLinkMiss,
	// Token: 0x040020A5 RID: 8357
	OnKingShipAttrItemSetShow,
	// Token: 0x040020A6 RID: 8358
	OnKingShipAllAttrItemShown,
	// Token: 0x040020A7 RID: 8359
	OnRefreshBeginnerCarnivalChoseRole,
	// Token: 0x040020A8 RID: 8360
	OnMontageRemain,
	// Token: 0x040020A9 RID: 8361
	OnGeneratedMonsterPatrolGroup,
	// Token: 0x040020AA RID: 8362
	OnGroupAiSyncTagAdded,
	// Token: 0x040020AB RID: 8363
	OnGroupAiSyncTagRemoved,
	// Token: 0x040020AC RID: 8364
	OnStateTaskFinished,
	// Token: 0x040020AD RID: 8365
	OnStateActivated,
	// Token: 0x040020AE RID: 8366
	OnForeverTimeDilationAdd,
	// Token: 0x040020AF RID: 8367
	OnForeverTimeDilationRemove,
	// Token: 0x040020B0 RID: 8368
	TrapDefenseBuildingDevelopSelectUpdate,
	// Token: 0x040020B1 RID: 8369
	TrapDefenseBuildingBottomSelectUpdate,
	// Token: 0x040020B2 RID: 8370
	TrapDefenseBuildingPreviewSelectUpdate,
	// Token: 0x040020B3 RID: 8371
	TrapDefenseOnDevelopUpdate,
	// Token: 0x040020B4 RID: 8372
	TrapDefenseOnDevelopResetAll,
	// Token: 0x040020B5 RID: 8373
	TrapDefenseOnSlotUpdate,
	// Token: 0x040020B6 RID: 8374
	TrapDefenseOnBranchUpdate,
	// Token: 0x040020B7 RID: 8375
	TrapDefenseActivityDataUpdate,
	// Token: 0x040020B8 RID: 8376
	TrapDefenseLevelDataListUpdate,
	// Token: 0x040020B9 RID: 8377
	TrapDefenseBdBuffListUpdate,
	// Token: 0x040020BA RID: 8378
	TrapDefenseBdBuffAllUpdate,
	// Token: 0x040020BB RID: 8379
	TrapDefenseRewardUpdate,
	// Token: 0x040020BC RID: 8380
	TrapDefenseTalentTreeUpdate,
	// Token: 0x040020BD RID: 8381
	TrapDefenseShopRefresh,
	// Token: 0x040020BE RID: 8382
	TrapDefenseBuildingDevelopDetailUpdate,
	// Token: 0x040020BF RID: 8383
	TrapDefenseBdBuffSelectChange,
	// Token: 0x040020C0 RID: 8384
	RedDotUpdateTrapDefenseFixedReward,
	// Token: 0x040020C1 RID: 8385
	RedDotUpdateTrapDefenseLimitReward,
	// Token: 0x040020C2 RID: 8386
	RedDotUpdateTrapDefenseTalentTree,
	// Token: 0x040020C3 RID: 8387
	RedDotUpdateTrapDefenseBdBuffNewUnlock,
	// Token: 0x040020C4 RID: 8388
	RedDotUpdateTrapDefenseLevelModeLevelReachOpenTime,
	// Token: 0x040020C5 RID: 8389
	RedDotUpdateTrapDefenseRougeModeLevelReachOpenTime,
	// Token: 0x040020C6 RID: 8390
	RedDotUpdateTrapDefenseRougeModeOpen,
	// Token: 0x040020C7 RID: 8391
	TrapDefenseLevelUpPointUpdate,
	// Token: 0x040020C8 RID: 8392
	TrapDefenseInventoryDataUpdate,
	// Token: 0x040020C9 RID: 8393
	TrapDefenseBuildingDevelopDetailInfoItemUpdate,
	// Token: 0x040020CA RID: 8394
	TrapDefensePreviewMachine,
	// Token: 0x040020CB RID: 8395
	TrapDefenseBuildingDevelopMainViewStart,
	// Token: 0x040020CC RID: 8396
	TrapDefenseMainLevelViewOpen,
	// Token: 0x040020CD RID: 8397
	OnCommonKeySettingKeyChange,
	// Token: 0x040020CE RID: 8398
	RefreshLifePointDrawChallengeRedDot,
	// Token: 0x040020CF RID: 8399
	RefreshLifePointDrawGroupRedDot,
	// Token: 0x040020D0 RID: 8400
	OnChangeBasedPlatform,
	// Token: 0x040020D1 RID: 8401
	ForceClientTravelModify,
	// Token: 0x040020D2 RID: 8402
	GreatSwordLevelPlayUiInfoUpdated,
	// Token: 0x040020D3 RID: 8403
	GreatSwordLevelSelectedComplete,
	// Token: 0x040020D4 RID: 8404
	GreatSwordLevelRefreshUI,
	// Token: 0x040020D5 RID: 8405
	OnSelectActivityFunPlayChallengeItem,
	// Token: 0x040020D6 RID: 8406
	RefreshActivityFunPlayRedDot,
	// Token: 0x040020D7 RID: 8407
	ActivityFunPlayInfoRefresh,
	// Token: 0x040020D8 RID: 8408
	RefreshLineCrossGroupRedDot,
	// Token: 0x040020D9 RID: 8409
	RefreshLineCrossChallengeRedDot,
	// Token: 0x040020DA RID: 8410
	MoonSignRewardRefresh,
	// Token: 0x040020DB RID: 8411
	SeekTraceMoveActionInput,
	// Token: 0x040020DC RID: 8412
	SeekTraceMoveAxisInput,
	// Token: 0x040020DD RID: 8413
	SeekTraceSelectItemInput,
	// Token: 0x040020DE RID: 8414
	SeekTraceResetItemInput,
	// Token: 0x040020DF RID: 8415
	OnOnlyAllowFightInputStateChanged,
	// Token: 0x040020E0 RID: 8416
	OnVisionIntensifyViewShow,
	// Token: 0x040020E1 RID: 8417
	VersionCheckRefresh,
	// Token: 0x040020E2 RID: 8418
	CheckMusicBeatsEvent,
	// Token: 0x040020E3 RID: 8419
	OnVisionRecommendFetterGroupSelected,
	// Token: 0x040020E4 RID: 8420
	RoleDevTargetRoleIdChange,
	// Token: 0x040020E5 RID: 8421
	RoleDevelopNeedItemsChanged,
	// Token: 0x040020E6 RID: 8422
	OnRoleDevViewOpen,
	// Token: 0x040020E7 RID: 8423
	BtnStateUpdate,
	// Token: 0x040020E8 RID: 8424
	OnArtemisStateRefresh,
	// Token: 0x040020E9 RID: 8425
	OnArtemisQteAreaChange,
	// Token: 0x040020EA RID: 8426
	SurvivorsRogueShowBonusWaveTips,
	// Token: 0x040020EB RID: 8427
	SurvivorsRogueShowEndlessWaveTips,
	// Token: 0x040020EC RID: 8428
	SurvivorsRogueSwitchWaveTipsState,
	// Token: 0x040020ED RID: 8429
	SurvivorsRebindCommandView,
	// Token: 0x040020EE RID: 8430
	SurvivorsRogueWeaponGainUpdate,
	// Token: 0x040020EF RID: 8431
	SurvivorsRogueRoleGainUpdate,
	// Token: 0x040020F0 RID: 8432
	SurvivorsRogueBossTrackedMarkerUpdate,
	// Token: 0x040020F1 RID: 8433
	SurvivorsRoguePlayerEntityCreated,
	// Token: 0x040020F2 RID: 8434
	SurvivorsInstSettle,
	// Token: 0x040020F3 RID: 8435
	SurvivorsRogueTalentNodeUpdate,
	// Token: 0x040020F4 RID: 8436
	SurvivorsRogueLevelDetailViewEndlessToggleRefresh,
	// Token: 0x040020F5 RID: 8437
	SurvivorsRogueComboBuffShow,
	// Token: 0x040020F6 RID: 8438
	SurvivorsRoguePopViewRefresh,
	// Token: 0x040020F7 RID: 8439
	SurvivorsRogueWeaponDetailTabViewShow,
	// Token: 0x040020F8 RID: 8440
	QuestTreeNodeDataUpdate,
	// Token: 0x040020F9 RID: 8441
	RegionalTerminalGameplayPinUpdate,
	// Token: 0x040020FA RID: 8442
	AreaMapGroupIdChanged,
	// Token: 0x040020FB RID: 8443
	AnimCompActiveStateChange,
	// Token: 0x040020FC RID: 8444
	OnPrizeDrawingRewardStatusChanged,
	// Token: 0x040020FD RID: 8445
	OnPrizeDrawingQuestUpdated,
	// Token: 0x040020FE RID: 8446
	OnHonamiStoryLifeSupportChanged,
	// Token: 0x040020FF RID: 8447
	OnHonamiStoryRoleEquipChanged,
	// Token: 0x04002100 RID: 8448
	OnHonamiScanMarkItemView,
	// Token: 0x04002101 RID: 8449
	OnPickUpHonamiStoryItem,
	// Token: 0x04002102 RID: 8450
	PlayerEntityStarted,
	// Token: 0x04002103 RID: 8451
	PlayerEntityEnded,
	// Token: 0x04002104 RID: 8452
	OnMarkItemAutoPilotTrackStateChange,
	// Token: 0x04002105 RID: 8453
	OnAutoPilotStateChange,
	// Token: 0x04002106 RID: 8454
	OnCircleStateChange,
	// Token: 0x04002107 RID: 8455
	OnUpdateAutoPilotLine,
	// Token: 0x04002108 RID: 8456
	MovieModeAspectOffsetUpdate,
	// Token: 0x04002109 RID: 8457
	MovieModeAspectOffsetApply,
	// Token: 0x0400210A RID: 8458
	MovieModeHideUiChange,
	// Token: 0x0400210B RID: 8459
	OnPanoramicActive,
	// Token: 0x0400210C RID: 8460
	OnPanoramicDisable,
	// Token: 0x0400210D RID: 8461
	OnActivityNewPlayerSupportTrialRoleItemSelect,
	// Token: 0x0400210E RID: 8462
	OnActivityNewPlayerSupportTaskUpdate,
	// Token: 0x0400210F RID: 8463
	OnActivityNewPlayerSupportTrialRoleUpdate,
	// Token: 0x04002110 RID: 8464
	OnActivityNewPlayerSupportCurTrialRoleChange,
	// Token: 0x04002111 RID: 8465
	InfrastructureFireExpAdd,
	// Token: 0x04002112 RID: 8466
	InfrastructureFireShopRefresh,
	// Token: 0x04002113 RID: 8467
	InfrastructureActivityTaskDataUpdate,
	// Token: 0x04002114 RID: 8468
	InfrastructureArchiveTaskUpdate,
	// Token: 0x04002115 RID: 8469
	InfrastructurePhoneTaskUpdate,
	// Token: 0x04002116 RID: 8470
	InfrastructureRoadNoticeUpdate,
	// Token: 0x04002117 RID: 8471
	InfrastructureArchiveReadUpdate,
	// Token: 0x04002118 RID: 8472
	InfrastructureTraceRoadUpdate,
	// Token: 0x04002119 RID: 8473
	InfrastructureSelectRoadNetworkMark,
	// Token: 0x0400211A RID: 8474
	InfrastructureRoadDataUpdate,
	// Token: 0x0400211B RID: 8475
	InfrastructureShopRedDotUpdate,
	// Token: 0x0400211C RID: 8476
	VillageInfrActivityTaskDataUpdate,
	// Token: 0x0400211D RID: 8477
	VillageInfrTreeDataUpdate,
	// Token: 0x0400211E RID: 8478
	VillageInfrVillageDataUpdate,
	// Token: 0x0400211F RID: 8479
	VillageInfrScoreRewardDataUpdate,
	// Token: 0x04002120 RID: 8480
	VillageInfrTreeFinishCondDataUpdate,
	// Token: 0x04002121 RID: 8481
	VillageDeliverySuccess,
	// Token: 0x04002122 RID: 8482
	VillageCompleteDelivery,
	// Token: 0x04002123 RID: 8483
	VillageInfrMainViewOnSelect,
	// Token: 0x04002124 RID: 8484
	CloseVillageInfrBuildInfoView,
	// Token: 0x04002125 RID: 8485
	VillageInfrMissionItemClick,
	// Token: 0x04002126 RID: 8486
	MotorDevelopRootUpdate,
	// Token: 0x04002127 RID: 8487
	MotorDevelopInfoUpdate,
	// Token: 0x04002128 RID: 8488
	MotorDevelopTechTreeUpdate,
	// Token: 0x04002129 RID: 8489
	MotorDevelopTaskUpdate,
	// Token: 0x0400212A RID: 8490
	SelectMotorDevelopTab,
	// Token: 0x0400212B RID: 8491
	MotorDiyInfoUpdate,
	// Token: 0x0400212C RID: 8492
	MotorDiyFullOutlookUpdate,
	// Token: 0x0400212D RID: 8493
	MotorDiyOnSelectToggleClick,
	// Token: 0x0400212E RID: 8494
	MotorDiySceneItemUpdate,
	// Token: 0x0400212F RID: 8495
	MotorParkourFinishLap,
	// Token: 0x04002130 RID: 8496
	OnMotorSwitchMusic,
	// Token: 0x04002131 RID: 8497
	OnMotorMusicEnableStateChanged,
	// Token: 0x04002132 RID: 8498
	OnMotorMusicSortDragCancel,
	// Token: 0x04002133 RID: 8499
	OnMotorMusicPlayerShow,
	// Token: 0x04002134 RID: 8500
	OnMotorMusicForceRefresh,
	// Token: 0x04002135 RID: 8501
	OnPhoneMsgUpdateNotify,
	// Token: 0x04002136 RID: 8502
	OnUpdateShortMsgOptionData,
	// Token: 0x04002137 RID: 8503
	OnNewPhoneMsgNeedShowTips,
	// Token: 0x04002138 RID: 8504
	OnPhoneMsgChatShowChange,
	// Token: 0x04002139 RID: 8505
	OnPhoneMsgChatTabClick,
	// Token: 0x0400213A RID: 8506
	OnPhoneMsgDialogShowClick,
	// Token: 0x0400213B RID: 8507
	OnPhoneMsgBgShowClick,
	// Token: 0x0400213C RID: 8508
	OnPhoneMsgReadProgressUpdate,
	// Token: 0x0400213D RID: 8509
	OnPhoneMsgSetAsRead,
	// Token: 0x0400213E RID: 8510
	OnPhoneMsgSetReceived,
	// Token: 0x0400213F RID: 8511
	OnPhoneTipsClose,
	// Token: 0x04002140 RID: 8512
	PhoneMsgDialogBgThemeCharmUpdate,
	// Token: 0x04002141 RID: 8513
	PhoneMsgDialogBgThemeCharmRedDotUpdate,
	// Token: 0x04002142 RID: 8514
	OnWeatherCentralRedDotUpdate,
	// Token: 0x04002143 RID: 8515
	RoadBookTaskRefresh,
	// Token: 0x04002144 RID: 8516
	RoadBookMotorRefresh,
	// Token: 0x04002145 RID: 8517
	RoadBookTaskNavigationNext,
	// Token: 0x04002146 RID: 8518
	WheelTowerCycleChange,
	// Token: 0x04002147 RID: 8519
	GuessJokerCardUpdateTaskData,
	// Token: 0x04002148 RID: 8520
	GuessJokerFinishPokerPerformAction,
	// Token: 0x04002149 RID: 8521
	EncircleMapChange,
	// Token: 0x0400214A RID: 8522
	EncircleReset,
	// Token: 0x0400214B RID: 8523
	EncircleDataUpdate,
	// Token: 0x0400214C RID: 8524
	MotorArrowInitBoss,
	// Token: 0x0400214D RID: 8525
	MotorArrowSubLevelNotify,
	// Token: 0x0400214E RID: 8526
	MotorArrowBossStateChange,
	// Token: 0x0400214F RID: 8527
	MotorArrowBossCreate,
	// Token: 0x04002150 RID: 8528
	MotorArrowBossRemove,
	// Token: 0x04002151 RID: 8529
	MotorArrowScoreUpdate,
	// Token: 0x04002152 RID: 8530
	MotorArrowBossHpChange,
	// Token: 0x04002153 RID: 8531
	MotorArrowSave,
	// Token: 0x04002154 RID: 8532
	MotorArrowGameOver,
	// Token: 0x04002155 RID: 8533
	SpringManorFunctionOpenNotify,
	// Token: 0x04002156 RID: 8534
	SpringManorTaskUpdateNotify,
	// Token: 0x04002157 RID: 8535
	SpringManorAtmosphereUpdate,
	// Token: 0x04002158 RID: 8536
	FurnitureFunctionOpenNotify,
	// Token: 0x04002159 RID: 8537
	OnCoopLevelUpdate,
	// Token: 0x0400215A RID: 8538
	OnCoopSpUpdate,
	// Token: 0x0400215B RID: 8539
	OnCoopLevelToggleClick,
	// Token: 0x0400215C RID: 8540
	OnPinballRoleLevelUp,
	// Token: 0x0400215D RID: 8541
	OnPinballRoleStateChange,
	// Token: 0x0400215E RID: 8542
	OnPinballEntityHpChanged,
	// Token: 0x0400215F RID: 8543
	OnPinballFirstLaunch,
	// Token: 0x04002160 RID: 8544
	OnPinballFeverChange,
	// Token: 0x04002161 RID: 8545
	OnPinballScoreChanged,
	// Token: 0x04002162 RID: 8546
	OnPinballComboChanged,
	// Token: 0x04002163 RID: 8547
	OnPinballRoleChargeMax,
	// Token: 0x04002164 RID: 8548
	OnPinballRoleUseSkill,
	// Token: 0x04002165 RID: 8549
	OnPinballEntityCreated,
	// Token: 0x04002166 RID: 8550
	OnPinballWeaponLockChanged,
	// Token: 0x04002167 RID: 8551
	RefreshPinballRoleRedDot,
	// Token: 0x04002168 RID: 8552
	OnPinballBattleViewSwitchIn,
	// Token: 0x04002169 RID: 8553
	RefreshPinballWeaponRedDot,
	// Token: 0x0400216A RID: 8554
	OnRefreshKurotatoRoleRedDot,
	// Token: 0x0400216B RID: 8555
	OnRefreshKurotatoWeaponAndPropRedDot,
	// Token: 0x0400216C RID: 8556
	OnRefreshKurotatoNormalRewardData,
	// Token: 0x0400216D RID: 8557
	OnRefreshKurotatoLimitRewardData,
	// Token: 0x0400216E RID: 8558
	OnNpcBeenAttackedStart,
	// Token: 0x0400216F RID: 8559
	OnNpcBeenAttackedEnd,
	// Token: 0x04002170 RID: 8560
	OnNpcBeenImpactedStart,
	// Token: 0x04002171 RID: 8561
	OnNpcBeenImpactedEnd,
	// Token: 0x04002172 RID: 8562
	OnNpcSwitchTimetable,
	// Token: 0x04002173 RID: 8563
	OnNpcStopTimetable,
	// Token: 0x04002174 RID: 8564
	OnTsBasePlayerControllerReceiveSetupInputComponent,
	// Token: 0x04002175 RID: 8565
	OnTsBasePlayerControllerReceiveBeginPlay,
	// Token: 0x04002176 RID: 8566
	OnTsBasePlayerControllerReceiveDestroyed,
	// Token: 0x04002177 RID: 8567
	OnTsBasePlayerControllerReceiveTick,
	// Token: 0x04002178 RID: 8568
	OnTsBasePlayerControllerReceivedPlayer,
	// Token: 0x04002179 RID: 8569
	OnTsBasePlayerControllerInitInputHandle,
	// Token: 0x0400217A RID: 8570
	OnTsBasePlayerControllerAddInputBinding,
	// Token: 0x0400217B RID: 8571
	OnTsBasePlayerControllerClearInputBinding,
	// Token: 0x0400217C RID: 8572
	OnTsBasePlayerControllerOnSetupInputComponent,
	// Token: 0x0400217D RID: 8573
	OnTsBasePlayerControllerBindTouchHandle,
	// Token: 0x0400217E RID: 8574
	OnTsBasePlayerControllerInputAction,
	// Token: 0x0400217F RID: 8575
	OnTsBasePlayerControllerInputAxis,
	// Token: 0x04002180 RID: 8576
	OnTsBasePlayerControllerOnTouchBegin,
	// Token: 0x04002181 RID: 8577
	OnTsBasePlayerControllerOnTouchEnd,
	// Token: 0x04002182 RID: 8578
	OnTsBasePlayerControllerOnTouchMove,
	// Token: 0x04002183 RID: 8579
	OnTsBasePlayerControllerOnPressAnyKey,
	// Token: 0x04002184 RID: 8580
	OnTsBasePlayerControllerOnReleaseAnyKey,
	// Token: 0x04002185 RID: 8581
	OnTsBasePlayerControllerRemoveActionHandle,
	// Token: 0x04002186 RID: 8582
	OnTsBasePlayerControllerGetActionHandle,
	// Token: 0x04002187 RID: 8583
	OnTsBasePlayerControllerRemoveAxisHandle,
	// Token: 0x04002188 RID: 8584
	OnTsBasePlayerControllerGetAxisHandle,
	// Token: 0x04002189 RID: 8585
	OnTsBasePlayerControllerIsInTouch,
	// Token: 0x0400218A RID: 8586
	OnTsBasePlayerControllerSetIsPrintKeyName,
	// Token: 0x0400218B RID: 8587
	OnTsBasePlayerControllerTouchBegin,
	// Token: 0x0400218C RID: 8588
	OnTsBasePlayerControllerTouchEnd,
	// Token: 0x0400218D RID: 8589
	OnTsBasePlayerControllerTouchMove,
	// Token: 0x0400218E RID: 8590
	OnTsBasePlayerControllerPressAnyKey,
	// Token: 0x0400218F RID: 8591
	OnTsBasePlayerControllerReleaseAnyKey,
	// Token: 0x04002190 RID: 8592
	OnTsCharacterControllerReceiveBeginPlay,
	// Token: 0x04002191 RID: 8593
	OnTsCharacterControllerReceiveDestroyed,
	// Token: 0x04002192 RID: 8594
	OnTsCharacterControllerReceivePossess,
	// Token: 0x04002193 RID: 8595
	OnTsCharacterControllerReceiveUnPossess,
	// Token: 0x04002194 RID: 8596
	OnTsCharacterControllerOnSetupInputComponent,
	// Token: 0x04002195 RID: 8597
	OnTsCharacterControllerReceivePreProcessInput,
	// Token: 0x04002196 RID: 8598
	OnTsCharacterControllerReceivePostProcessInput,
	// Token: 0x04002197 RID: 8599
	OnTsCharacterControllerSetUiRootActive,
	// Token: 0x04002198 RID: 8600
	OnTsCharacterControllerSetUiRootDeactivate,
	// Token: 0x04002199 RID: 8601
	OnTsUiManagerInit,
	// Token: 0x0400219A RID: 8602
	OnTsLayerInit,
	// Token: 0x0400219B RID: 8603
	OnTsLguiEventSystemInit,
	// Token: 0x0400219C RID: 8604
	OpenViewRedirectToCs,
	// Token: 0x0400219D RID: 8605
	CloseViewRedirectToCs,
	// Token: 0x0400219E RID: 8606
	OpenViewRedirectToTs,
	// Token: 0x0400219F RID: 8607
	CloseViewRedirectToTs,
	// Token: 0x040021A0 RID: 8608
	HideViewRedirectToTs,
	// Token: 0x040021A1 RID: 8609
	CloseAndOpenRedirectToTs,
	// Token: 0x040021A2 RID: 8610
	CloseAndOpenRedirectToCs,
	// Token: 0x040021A3 RID: 8611
	PreOpenViewAsyncRedirectToCs,
	// Token: 0x040021A4 RID: 8612
	PreOpenViewAsyncRedirectToTs,
	// Token: 0x040021A5 RID: 8613
	OpenViewAfterPreOpenedAsyncToCs,
	// Token: 0x040021A6 RID: 8614
	OpenViewAfterPreOpenedAsyncToTs,
	// Token: 0x040021A7 RID: 8615
	TsNotifyCsViewOnCreateAsync,
	// Token: 0x040021A8 RID: 8616
	TsNotifyCsBeforeStartAsync,
	// Token: 0x040021A9 RID: 8617
	TsNotifyCsOnBeforeHideAsync,
	// Token: 0x040021AA RID: 8618
	TsNotifyCsOnPlayingStartSequenceAsync,
	// Token: 0x040021AB RID: 8619
	TsNotifyCsOnPlayingCloseSequenceAsync,
	// Token: 0x040021AC RID: 8620
	TsNotifyCsOnBeforeShowAsyncImplementImplement,
	// Token: 0x040021AD RID: 8621
	CsNotifyTsViewOnCreateAsync,
	// Token: 0x040021AE RID: 8622
	CsNotifyTsBeforeStartAsync,
	// Token: 0x040021AF RID: 8623
	CsNotifyTsOnBeforeHideAsync,
	// Token: 0x040021B0 RID: 8624
	CsNotifyTsOnPlayingStartSequenceAsync,
	// Token: 0x040021B1 RID: 8625
	CsNotifyTsOnPlayingCloseSequenceAsync,
	// Token: 0x040021B2 RID: 8626
	CsNotifyTsOnBeforeShowAsyncImplementImplement,
	// Token: 0x040021B3 RID: 8627
	NotifyCsOnNetReceiveResponse,
	// Token: 0x040021B4 RID: 8628
	NotifyCsOnNetReceiveException,
	// Token: 0x040021B5 RID: 8629
	NotifyCsOnNetReceiveTcpException,
	// Token: 0x040021B6 RID: 8630
	NotifyCsOnNetReceivePush,
	// Token: 0x040021B7 RID: 8631
	NotifyCsOnNetKcpConnectSuccess,
	// Token: 0x040021B8 RID: 8632
	NotifyCsOnNetError,
	// Token: 0x040021B9 RID: 8633
	NotifyCsCleanNetMessageCaches,
	// Token: 0x040021BA RID: 8634
	CsNetCall,
	// Token: 0x040021BB RID: 8635
	CsNotifyTsOpenWorldMapView,
	// Token: 0x040021BC RID: 8636
	CsNotifyTsTrackQuest,
	// Token: 0x040021BD RID: 8637
	TsNotifyCsTrackQuestResponse,
	// Token: 0x040021BE RID: 8638
	CsNotifyTsQuestTreeGotoQuest,
	// Token: 0x040021BF RID: 8639
	CsNotifyInfoSwitchInputControllerType,
	// Token: 0x040021C0 RID: 8640
	CsNotifyTsUiNavigationBehaviorListenerAwakeBP,
	// Token: 0x040021C1 RID: 8641
	CsNotifyTsUiNavigationBehaviorListenerStartBP,
	// Token: 0x040021C2 RID: 8642
	CsNotifyTsUiNavigationBehaviorListenerOnNotifyNavigationEnterBP,
	// Token: 0x040021C3 RID: 8643
	CsNotifyTsUiNavigationBehaviorListenerOnNotifyNavigationSelectBP,
	// Token: 0x040021C4 RID: 8644
	CsNotifyTsUiNavigationBehaviorListenerOnEnableBP,
	// Token: 0x040021C5 RID: 8645
	CsNotifyTsUiNavigationBehaviorListenerOnDisableBP,
	// Token: 0x040021C6 RID: 8646
	CsNotifyTsUiNavigationBehaviorListenerOnNotifyInteractiveBP,
	// Token: 0x040021C7 RID: 8647
	CsNotifyTsUiNavigationBehaviorListenerOnNotifyNotInteractiveBP,
	// Token: 0x040021C8 RID: 8648
	CsNotifyTsUiNavigationBehaviorListenerOnDestroyBP,
	// Token: 0x040021C9 RID: 8649
	CsNotifyTsUiNavigationBehaviorListenerOnCheckCanSetNavigationBP,
	// Token: 0x040021CA RID: 8650
	CsNotifyTsUiNavigationBehaviorListenerOnCheckLoopScrollChangeNavigationBP,
	// Token: 0x040021CB RID: 8651
	CsNotifyTsUiNavigationPanelConfigAwakeBP,
	// Token: 0x040021CC RID: 8652
	CsNotifyTsUiNavigationPanelConfigStartBP,
	// Token: 0x040021CD RID: 8653
	CsNotifyTsUiNavigationPanelConfigOnEnableBP,
	// Token: 0x040021CE RID: 8654
	CsNotifyTsUiNavigationPanelConfigOnDisableBP,
	// Token: 0x040021CF RID: 8655
	CsNotifyTsUiNavigationPanelConfigOnDestroyBP,
	// Token: 0x040021D0 RID: 8656
	CsNotifyTsLguiEventSystemActorInputTrigger,
	// Token: 0x040021D1 RID: 8657
	CsNotifyTsLguiEventSystemActorInputNavigation,
	// Token: 0x040021D2 RID: 8658
	CsNotifyTsLguiEventSystemActorInputTriggerForNavigation,
	// Token: 0x040021D3 RID: 8659
	CsNotifyTsLguiEventSystemActorInputScroll,
	// Token: 0x040021D4 RID: 8660
	CsNotifyTsLguiEventSystemActorInputTouchTrigger,
	// Token: 0x040021D5 RID: 8661
	CsNotifyTsLguiEventSystemActorInputTouchMove,
	// Token: 0x040021D6 RID: 8662
	CsNotifyTsLguiEventSystemActorSetClickThresholdWithInputKeyType,
	// Token: 0x040021D7 RID: 8663
	CsNotifyTsLguiEventSystemActorGetNowHitComponent,
	// Token: 0x040021D8 RID: 8664
	CsNotifyTsLguiEventSystemActorGetPointerEventData,
	// Token: 0x040021D9 RID: 8665
	CsNotifyTsLguiEventSystemActorIsPointerEventDataLineTrace,
	// Token: 0x040021DA RID: 8666
	CsNotifyTsUiBlurSetEnableUiBlur,
	// Token: 0x040021DB RID: 8667
	CsNotifyTsUiHotKeyActorComponentAwakeBP,
	// Token: 0x040021DC RID: 8668
	CsNotifyTsUiHotKeyActorComponentStartBP,
	// Token: 0x040021DD RID: 8669
	CsNotifyTsUiHotKeyActorComponentOnEnableBP,
	// Token: 0x040021DE RID: 8670
	CsNotifyTsUiHotKeyActorComponentOnDisableBP,
	// Token: 0x040021DF RID: 8671
	CsNotifyTsUiHotKeyActorComponentOnDestroyBP,
	// Token: 0x040021E0 RID: 8672
	CsNotifyTsUiNavigationTextChangeListenerAwakeBP,
	// Token: 0x040021E1 RID: 8673
	CsNotifyTsUiNavigationTextChangeListenerStartBP,
	// Token: 0x040021E2 RID: 8674
	CsNotifyTsUiNavigationTextChangeListenerOnNotifyTextChangeBP,
	// Token: 0x040021E3 RID: 8675
	CsNotifyTsUiNavigationPlatformChangeListenerAwakeBP,
	// Token: 0x040021E4 RID: 8676
	CsNotifyTsUiNavigationPlatformChangeListenerOnDestroyBP,
	// Token: 0x040021E5 RID: 8677
	CsRequestTsOpenView,
	// Token: 0x040021E6 RID: 8678
	TsWorldDone,
	// Token: 0x040021E7 RID: 8679
	TsReconnectClearData,
	// Token: 0x040021E8 RID: 8680
	TsOnPreEndPIE,
	// Token: 0x040021E9 RID: 8681
	CsNotifyUiNavigationNewControllerSetNavigationFocusForView,
	// Token: 0x040021EA RID: 8682
	TsActiveBattleView,
	// Token: 0x040021EB RID: 8683
	ResetToViewRedirectToTs,
	// Token: 0x040021EC RID: 8684
	ResetToViewRedirectToCs,
	// Token: 0x040021ED RID: 8685
	CsNotifyTsAddBlackScreen,
	// Token: 0x040021EE RID: 8686
	CsNotifyTsRemoveBlackScreen,
	// Token: 0x040021EF RID: 8687
	TsNotifyCsAddBlackScreenFinish,
	// Token: 0x040021F0 RID: 8688
	CsRequestTsHandleQuestTreeNode,
	// Token: 0x040021F1 RID: 8689
	TsHandleQuestTreeNodeResponse,
	// Token: 0x040021F2 RID: 8690
	TsClearSceneBegin,
	// Token: 0x040021F3 RID: 8691
	TsAfterLoadMap,
	// Token: 0x040021F4 RID: 8692
	TsSyncSetServerId,
	// Token: 0x040021F5 RID: 8693
	CsNotifyShowTips,
	// Token: 0x040021F6 RID: 8694
	CsRequestSelectMail,
	// Token: 0x040021F7 RID: 8695
	CsRequestPickMailAttachment,
	// Token: 0x040021F8 RID: 8696
	CsRequestDeleteMail,
	// Token: 0x040021F9 RID: 8697
	TsOnReadMailResponse,
	// Token: 0x040021FA RID: 8698
	TsOnPickMailAttachmentResponse,
	// Token: 0x040021FB RID: 8699
	TsOnDeleteMailResponse,
	// Token: 0x040021FC RID: 8700
	CsRequestOpenSdkExternalUrl,
	// Token: 0x040021FD RID: 8701
	CsRequestOpenSdkUrlWnd,
	// Token: 0x040021FE RID: 8702
	CsRequestSyncTsTimeModelParam,
	// Token: 0x040021FF RID: 8703
	TsResponseSyncToCsTimeModelParam,
	// Token: 0x04002200 RID: 8704
	CsRequestSyncServerGameTime,
	// Token: 0x04002201 RID: 8705
	TsResponseSyncServerGameTime,
	// Token: 0x04002202 RID: 8706
	CsRequestAdjustTime,
	// Token: 0x04002203 RID: 8707
	TsRequestAdjustTime,
	// Token: 0x04002204 RID: 8708
	CsRequestLockTimeRunStateClient,
	// Token: 0x04002205 RID: 8709
	TsRequestLockTimeRunStateClient,
	// Token: 0x04002206 RID: 8710
	CsRequestLockTimeSyncLockStateClient,
	// Token: 0x04002207 RID: 8711
	TsRequestLockTimeSyncLockStateClient,
	// Token: 0x04002208 RID: 8712
	CsRequestSetTimeScale,
	// Token: 0x04002209 RID: 8713
	TsRequestSetTimeScale,
	// Token: 0x0400220A RID: 8714
	CsRequestTimeCanOpenViewState,
	// Token: 0x0400220B RID: 8715
	TsResponseTimeCanOpenViewState,
	// Token: 0x0400220C RID: 8716
	TsOnTimeEnterGame,
	// Token: 0x0400220D RID: 8717
	TsOnTimeBeforeLoadMap,
	// Token: 0x0400220E RID: 8718
	TsOnTimeWorldDone,
	// Token: 0x0400220F RID: 8719
	TsSyncUseClientLockState,
	// Token: 0x04002210 RID: 8720
	TsNotifyLevelSequencePlayerBannedState,
	// Token: 0x04002211 RID: 8721
	CsNotifyOpenHelpView,
	// Token: 0x04002212 RID: 8722
	TsNotifyQuestTrackState,
	// Token: 0x04002213 RID: 8723
	NotifyCsLocalStorageInit,
	// Token: 0x04002214 RID: 8724
	CsSyncItemTipsData,
	// Token: 0x04002215 RID: 8725
	CsRequestOpenFunctionRelateView,
	// Token: 0x04002216 RID: 8726
	TsSyncTickPauseState,
	// Token: 0x04002217 RID: 8727
	TsSyncSceneTime,
	// Token: 0x04002218 RID: 8728
	TsOnRequestFriendInfoResponse,
	// Token: 0x04002219 RID: 8729
	CsRequestFriendHandle,
	// Token: 0x0400221A RID: 8730
	CsRequestChangeFriendRemark,
	// Token: 0x0400221B RID: 8731
	CsRequestFriendDelete,
	// Token: 0x0400221C RID: 8732
	CsRequestFriendApplicationDelete,
	// Token: 0x0400221D RID: 8733
	TsSyncInstanceType,
	// Token: 0x0400221E RID: 8734
	TsSyncHeadInfo,
	// Token: 0x0400221F RID: 8735
	CsSyncSelectedPlayerId,
	// Token: 0x04002220 RID: 8736
	CsSyncFriendShowingView,
	// Token: 0x04002221 RID: 8737
	CsSyncFriendFilterState,
	// Token: 0x04002222 RID: 8738
	CsRequestLookCard,
	// Token: 0x04002223 RID: 8739
	CsRequestAddMutePlayer,
	// Token: 0x04002224 RID: 8740
	CsRequestRemoveMutePlayer,
	// Token: 0x04002225 RID: 8741
	CsSyncRequestSearchData,
	// Token: 0x04002226 RID: 8742
	TsSyncResponseSearchBasicData,
	// Token: 0x04002227 RID: 8743
	TsSyncResponseSearchSdkData,
	// Token: 0x04002228 RID: 8744
	CsRequestBlockData,
	// Token: 0x04002229 RID: 8745
	TsResponseBlockData,
	// Token: 0x0400222A RID: 8746
	CsRequestFriendRecentlyTeam,
	// Token: 0x0400222B RID: 8747
	TsResponseFriendRecentlyTeam,
	// Token: 0x0400222C RID: 8748
	CsSyncCachePlayerData,
	// Token: 0x0400222D RID: 8749
	CsRequestReportPlayer,
	// Token: 0x0400222E RID: 8750
	CsRequestShowFriendPromptCode,
	// Token: 0x0400222F RID: 8751
	CsRequestChatOption,
	// Token: 0x04002230 RID: 8752
	CsRequestJoinWorld,
	// Token: 0x04002231 RID: 8753
	TsSyncBirthdayResetState,
	// Token: 0x04002232 RID: 8754
	CsRequestSdkBlockingUserData,
	// Token: 0x04002233 RID: 8755
	TsResponseSdkBlockingUserData,
	// Token: 0x04002234 RID: 8756
	CsRequestSdkTargetRelationData,
	// Token: 0x04002235 RID: 8757
	TsResponseSdkTargetRelationData,
	// Token: 0x04002236 RID: 8758
	CsRequestCommunicationRestricted,
	// Token: 0x04002237 RID: 8759
	TsResponseCommunicationRestricted,
	// Token: 0x04002238 RID: 8760
	CsRequestCommunicationRestrictedSync,
	// Token: 0x04002239 RID: 8761
	TsResponseCommunicationRestrictedSync,
	// Token: 0x0400223A RID: 8762
	CsRequestSdkPlayOnlyState,
	// Token: 0x0400223B RID: 8763
	TsResponseSdkPlayOnlyState,
	// Token: 0x0400223C RID: 8764
	CsRequestSdkFriendOnlyState,
	// Token: 0x0400223D RID: 8765
	TsResponseSdkFriendOnlyState,
	// Token: 0x0400223E RID: 8766
	CsRequestSaveSdkFriendOnlyState,
	// Token: 0x0400223F RID: 8767
	TsSyncAddMutePlayer,
	// Token: 0x04002240 RID: 8768
	TsSyncRemoveMutePlayer,
	// Token: 0x04002241 RID: 8769
	TsSyncLanguageChange,
	// Token: 0x04002242 RID: 8770
	TsSyncThirdPartyInfo,
	// Token: 0x04002243 RID: 8771
	LoadingPhaseChange,
	// Token: 0x04002244 RID: 8772
	TsSyncChatEnterTeam,
	// Token: 0x04002245 RID: 8773
	TsSyncChatLeaveTeam,
	// Token: 0x04002246 RID: 8774
	TsSyncChatEnterOnlineWorld,
	// Token: 0x04002247 RID: 8775
	TsSyncChatLeaveOnlineWorld,
	// Token: 0x04002248 RID: 8776
	CsRequestChangePlayerRemark,
	// Token: 0x04002249 RID: 8777
	TsSyncChangePlayerRemark,
	// Token: 0x0400224A RID: 8778
	TsSyncTime,
	// Token: 0x0400224B RID: 8779
	TsActivityCreateSubView,
	// Token: 0x0400224C RID: 8780
	TsActivityBeforeShowSelfAsync,
	// Token: 0x0400224D RID: 8781
	TsActivityBeforeHideSelfAsync,
	// Token: 0x0400224E RID: 8782
	TsActivityOnDestroy,
	// Token: 0x0400224F RID: 8783
	TsActivitySetActive,
	// Token: 0x04002250 RID: 8784
	TsActivityOnCommonViewStateChange,
	// Token: 0x04002251 RID: 8785
	TsActivityRefreshView,
	// Token: 0x04002252 RID: 8786
	TsActivityPlaySubViewSequence,
	// Token: 0x04002253 RID: 8787
	CsNotifyTsActivityOnCreateAsync,
	// Token: 0x04002254 RID: 8788
	CsNotifyTsActivityBeforeShowSelfAsync,
	// Token: 0x04002255 RID: 8789
	CsNotifyTsActivityBeforeHideSelfAsync,
	// Token: 0x04002256 RID: 8790
	CsMemoryFragmentMainViewRequestScreenshot,
	// Token: 0x04002257 RID: 8791
	CsRequestShowWorldLevelUpEffect,
	// Token: 0x04002258 RID: 8792
	CsRequestDestroyWorldLevelUpEffect,
	// Token: 0x04002259 RID: 8793
	CsRequestWorldLevelChangeInFight,
	// Token: 0x0400225A RID: 8794
	TsResponseWorldLevelChangeInFight,
	// Token: 0x0400225B RID: 8795
	CsRequestDownWorldLevel,
	// Token: 0x0400225C RID: 8796
	CsRequestRegainWorldLevel,
	// Token: 0x0400225D RID: 8797
	TsSyncWorldLevelChangeEvent,
	// Token: 0x0400225E RID: 8798
	TsSyncOriginWorldLevelUpEvent,
	// Token: 0x0400225F RID: 8799
	TsSyncAchievementFinish,
	// Token: 0x04002260 RID: 8800
	OnRefreshSubPackageDownLoadByPriority,
	// Token: 0x04002261 RID: 8801
	OnRefreshSubPackDownLoadState,
	// Token: 0x04002262 RID: 8802
	OnRefreshSubPackUseCellData,
	// Token: 0x04002263 RID: 8803
	OnRefreshSubPackClearData,
	// Token: 0x04002264 RID: 8804
	OnHookPointStateChanged,
	// Token: 0x04002265 RID: 8805
	OnSunSpiritEnableUpdated,
	// Token: 0x04002266 RID: 8806
	OnSunSpiritOccupiedByPlayerChanged,
	// Token: 0x04002267 RID: 8807
	OnSunSpiritOccupiedByGearChanged,
	// Token: 0x04002268 RID: 8808
	OnSunSpiritLauncherWatchSelectedChanged,
	// Token: 0x04002269 RID: 8809
	ShowRollBlockTips,
	// Token: 0x0400226A RID: 8810
	RollBlockAllCompleted,
	// Token: 0x0400226B RID: 8811
	OnRollBlockReseting,
	// Token: 0x0400226C RID: 8812
	OnRollBlockDifficultyChanged,
	// Token: 0x0400226D RID: 8813
	PhantomInteractEditGridRefresh,
	// Token: 0x0400226E RID: 8814
	PhantomInteractNewUnlock,
	// Token: 0x0400226F RID: 8815
	MonsterDebug,
	// Token: 0x04002270 RID: 8816
	OnEnableCrowdAiSystem,
	// Token: 0x04002271 RID: 8817
	MotorInMovieModeChange,
	// Token: 0x04002272 RID: 8818
	MotorSubStateModeChange,
	// Token: 0x04002273 RID: 8819
	MotorOnHit,
	// Token: 0x04002274 RID: 8820
	EnableGrapplingHookMark,
	// Token: 0x04002275 RID: 8821
	OnMapCustomMarkPanelShow,
	// Token: 0x04002276 RID: 8822
	OnPhantomArenaChooseCardPanelShow,
	// Token: 0x04002277 RID: 8823
	OnPhantomArenaDiscardCardPanelShow,
	// Token: 0x04002278 RID: 8824
	OnMotorDiyViewShow,
	// Token: 0x04002279 RID: 8825
	OnPhantomArenaPlayFieldEffect,
	// Token: 0x0400227A RID: 8826
	MotorDevelopTreeTypeRedDotUpdate,
	// Token: 0x0400227B RID: 8827
	OnGroupTrialRoleRedDotUpdate,
	// Token: 0x0400227C RID: 8828
	OnActivityNewPlayerSupportInfoUpdate,
	// Token: 0x0400227D RID: 8829
	OnActivityNewPlayerSupportEntranceRedDotUpdate,
	// Token: 0x0400227E RID: 8830
	OnEnterWheelTowerEndlessMode,
	// Token: 0x0400227F RID: 8831
	MotorDiyInfoRedDotUpdate,
	// Token: 0x04002280 RID: 8832
	OnGuideTriggerEvent,
	// Token: 0x04002281 RID: 8833
	OnSkillButtonAttributeFull,
	// Token: 0x04002282 RID: 8834
	OnEnterOrExitUnopenedArea,
	// Token: 0x04002283 RID: 8835
	OnForbidVehicleInUnopenedArea,
	// Token: 0x04002284 RID: 8836
	OnSetBattleUiChildCacheStateNotify,
	// Token: 0x04002285 RID: 8837
	OnSetBattleUiChildCacheState,
	// Token: 0x04002286 RID: 8838
	OnPhoneMsgPanelOpen,
	// Token: 0x04002287 RID: 8839
	OnPhoneMsgAdd,
	// Token: 0x04002288 RID: 8840
	OnPhoneHaveMsgToRemove,
	// Token: 0x04002289 RID: 8841
	OnPhoneMsgFilterChanged,
	// Token: 0x0400228A RID: 8842
	OnTouchUiEditSave,
	// Token: 0x0400228B RID: 8843
	OnViewShow,
	// Token: 0x0400228C RID: 8844
	RegressBpExpAnim,
	// Token: 0x0400228D RID: 8845
	TriggerBreakWeakness,
	// Token: 0x0400228E RID: 8846
	BreakWeaknessPanelLogicVisibleChange,
	// Token: 0x0400228F RID: 8847
	LevelPlayRewardDetailUpdate,
	// Token: 0x04002290 RID: 8848
	LevelPlayMarkGamePlayStateUpdate,
	// Token: 0x04002291 RID: 8849
	CommonPlayMarkGamePlayStateUpdate,
	// Token: 0x04002292 RID: 8850
	FeedbackRewardRefresh,
	// Token: 0x04002293 RID: 8851
	InfrastructureFireDataUpdate,
	// Token: 0x04002294 RID: 8852
	OnSceneItemNearbyTrackingEnd,
	// Token: 0x04002295 RID: 8853
	OnBrochureBookItemStateUpdate,
	// Token: 0x04002296 RID: 8854
	MotorDiyInfoPreviewRedDotUpdate,
	// Token: 0x04002297 RID: 8855
	ActivityPayShopGoodsBuy,
	// Token: 0x04002298 RID: 8856
	OnMotorDevelopTaskUpdate,
	// Token: 0x04002299 RID: 8857
	OnDrinksUnlockClickedNotify,
	// Token: 0x0400229A RID: 8858
	OnGuessJokerRedDotNotify,
	// Token: 0x0400229B RID: 8859
	OnSpringManorGameplayFinish,
	// Token: 0x0400229C RID: 8860
	OnFurnitureUnlockNotify,
	// Token: 0x0400229D RID: 8861
	OnFurnitureAreaUnlockNotify,
	// Token: 0x0400229E RID: 8862
	UpdateFurnitureEntranceRedDot,
	// Token: 0x0400229F RID: 8863
	OnRoleSkillInputPanelVisible,
	// Token: 0x040022A0 RID: 8864
	OnFlagChallengeTaskUpdate,
	// Token: 0x040022A1 RID: 8865
	OnFlagChallengeBattleActiveChanged,
	// Token: 0x040022A2 RID: 8866
	OnFlagChallengeExpChanged,
	// Token: 0x040022A3 RID: 8867
	OnFlagChallengeTempExpChanged,
	// Token: 0x040022A4 RID: 8868
	OnFlagChallengeTotalLevelChanged,
	// Token: 0x040022A5 RID: 8869
	OnFlagChallengeStrongholdOccupied,
	// Token: 0x040022A6 RID: 8870
	OnFlagChallengeFixedRoleLevelUpdate,
	// Token: 0x040022A7 RID: 8871
	OnFlagChallengeDungeonActiveChanged,
	// Token: 0x040022A8 RID: 8872
	OnFlagChallengeLevelNewlyUnlock,
	// Token: 0x040022A9 RID: 8873
	OnFlagChallengeBuffNewlyUnlock,
	// Token: 0x040022AA RID: 8874
	OnFlagChallengeBuffNewlyUnlockHintChanged,
	// Token: 0x040022AB RID: 8875
	OnFlagChallengeBattleBuffNewlyUnlock,
	// Token: 0x040022AC RID: 8876
	OnFlagChallengeRoleSelectCategoryUpdate,
	// Token: 0x040022AD RID: 8877
	BattleUiToggleFlagChallengeBuffInfo,
	// Token: 0x040022AE RID: 8878
	OnFlagChallengeUpdateStrongholdData,
	// Token: 0x040022AF RID: 8879
	OnFlagChallengeUpdateLevelData,
	// Token: 0x040022B0 RID: 8880
	OrnamentRedDotRefresh,
	// Token: 0x040022B1 RID: 8881
	OnOrnamentChange,
	// Token: 0x040022B2 RID: 8882
	OnOrnamentUnlock,
	// Token: 0x040022B3 RID: 8883
	OnPhantomConfigManagerDataUpdate,
	// Token: 0x040022B4 RID: 8884
	OnPayShopConditionFinish,
	// Token: 0x040022B5 RID: 8885
	KurotatoOnStepChanged,
	// Token: 0x040022B6 RID: 8886
	KurotatoOnUpgradeRewardDataChanged,
	// Token: 0x040022B7 RID: 8887
	KurotatoOnChestRewardDataChanged,
	// Token: 0x040022B8 RID: 8888
	KurotatoOnShopDataChanged,
	// Token: 0x040022B9 RID: 8889
	KurotatoOnItemUpdate,
	// Token: 0x040022BA RID: 8890
	KurotatoOnWeaponUpdate,
	// Token: 0x040022BB RID: 8891
	KurotatoOnWeaponRefined,
	// Token: 0x040022BC RID: 8892
	KurotatoOnRoleSaveStateUpdate,
	// Token: 0x040022BD RID: 8893
	KurotatoEnemyDetailBookGridItemClick,
	// Token: 0x040022BE RID: 8894
	KurotatoPlayerOneHpLeft,
	// Token: 0x040022BF RID: 8895
	KurotatoOnPropertyUpdate,
	// Token: 0x040022C0 RID: 8896
	KurotatoBossTrackedMarkerUpdate,
	// Token: 0x040022C1 RID: 8897
	KurotatoTreasureBoxTrackedMarkerUpdate,
	// Token: 0x040022C2 RID: 8898
	KurotatoOnSystemInfoUpdate,
	// Token: 0x040022C3 RID: 8899
	KurotatoOnPlayerDie,
	// Token: 0x040022C4 RID: 8900
	KurotatoOnWaveCountDownFinish,
	// Token: 0x040022C5 RID: 8901
	KurotatoOnNextWaveTypeUpdate,
	// Token: 0x040022C6 RID: 8902
	OnGolemHackingLevelStateUpdate,
	// Token: 0x040022C7 RID: 8903
	OnPhantomArenaMapUnlockUpdate,
	// Token: 0x040022C8 RID: 8904
	NotifyGuideBreakFocus,
	// Token: 0x040022C9 RID: 8905
	OnGuideTriggerResetEvent,
	// Token: 0x040022CA RID: 8906
	OnRhythmShipJumpLevel,
	// Token: 0x040022CB RID: 8907
	OnRhythmShipSelectRoleRefresh,
	// Token: 0x040022CC RID: 8908
	OnRhythmShipTaskRefresh,
	// Token: 0x040022CD RID: 8909
	OnRhythmShipTaskTabRefresh,
	// Token: 0x040022CE RID: 8910
	OnRhythmShipRedDotRefresh,
	// Token: 0x040022CF RID: 8911
	OnRhythmGameNoteResultUpdate,
	// Token: 0x040022D0 RID: 8912
	OnRhythmGameFinish,
	// Token: 0x040022D1 RID: 8913
	OnRhythmGameFeverModeChanged,
	// Token: 0x040022D2 RID: 8914
	OnRhythmGameFeverScoreChanged,
	// Token: 0x040022D3 RID: 8915
	OnRhythmGameSpeedLevelConfigIndexChanged,
	// Token: 0x040022D4 RID: 8916
	OnRhythmGameStartCoolDown,
	// Token: 0x040022D5 RID: 8917
	OnRhythmGameAutoJudgeCountChanged,
	// Token: 0x040022D6 RID: 8918
	OnRhythmGameEndCoolDown,
	// Token: 0x040022D7 RID: 8919
	OnRhythmGameStartPhase,
	// Token: 0x040022D8 RID: 8920
	OnRhythmGameStartNormalPhase,
	// Token: 0x040022D9 RID: 8921
	OnRhythmGameEndPhase,
	// Token: 0x040022DA RID: 8922
	OnRhythmGameFreePhase,
	// Token: 0x040022DB RID: 8923
	DropCatchActivityRewardUpdate,
	// Token: 0x040022DC RID: 8924
	OnAutoPilotTrackMarkVisibleChanged,
	// Token: 0x040022DD RID: 8925
	OnArcadeGameplayFinish,
	// Token: 0x040022DE RID: 8926
	OnTetrisChallengeStateUpdate,
	// Token: 0x040022DF RID: 8927
	OnMatchThreeChallengeStateUpdate,
	// Token: 0x040022E0 RID: 8928
	OnMatchThreeBoardSettled,
	// Token: 0x040022E1 RID: 8929
	OnMatchThreeRoleNewRedDotUpdate,
	// Token: 0x040022E2 RID: 8930
	MatchThreeSwapPieceInput,
	// Token: 0x040022E3 RID: 8931
	OnTetrisScoreChanged,
	// Token: 0x040022E4 RID: 8932
	OnTetrisDragCancel,
	// Token: 0x040022E5 RID: 8933
	OnFlagChallengeCalculatedLevelUpdate,
	// Token: 0x040022E6 RID: 8934
	OnBeforeOpenLoginView,
	// Token: 0x040022E7 RID: 8935
	OnEntitySelfDirectionUpdate,
	// Token: 0x040022E8 RID: 8936
	OnSceneItemElementalFieldSnapshotChange,
	// Token: 0x040022E9 RID: 8937
	OnSceneItemElementalFieldReady,
	// Token: 0x040022EA RID: 8938
	OnElementalFoundationCoreChanged,
	// Token: 0x040022EB RID: 8939
	SlidingBlockGameStageChanged,
	// Token: 0x040022EC RID: 8940
	WuWuLogisticsTaskUpdate,
	// Token: 0x040022ED RID: 8941
	SlidingBlockCheckLineClear,
	// Token: 0x040022EE RID: 8942
	SlidingBlockSqueezePlayer,
	// Token: 0x040022EF RID: 8943
	OnAnniversaryActivityRewardUpdate,
	// Token: 0x040022F0 RID: 8944
	OnBossPilingReward,
	// Token: 0x040022F1 RID: 8945
	OnRoleSkillBranchInGamePlayChanged,
	// Token: 0x040022F2 RID: 8946
	OnQuickHackCurrentRamChange,
	// Token: 0x040022F3 RID: 8947
	OnQuickHackMaxRamChange,
	// Token: 0x040022F4 RID: 8948
	OnQuickHackAllSkillChange,
	// Token: 0x040022F5 RID: 8949
	OnQuickHackSelectSkillChange,
	// Token: 0x040022F6 RID: 8950
	OnQuickHackDurationLimitChange,
	// Token: 0x040022F7 RID: 8951
	OnQuickHackTargetChange,
	// Token: 0x040022F8 RID: 8952
	OnQuickHackSceneItemStateChange,
	// Token: 0x040022F9 RID: 8953
	OnQuickHackCameraControlChange,
	// Token: 0x040022FA RID: 8954
	OnQuickHackStartMark,
	// Token: 0x040022FB RID: 8955
	OnQuickHackClose,
	// Token: 0x040022FC RID: 8956
	OnQuickHackCameraControlClose,
	// Token: 0x040022FD RID: 8957
	WeeklyChallengeRefresh,
	// Token: 0x040022FE RID: 8958
	WeeklyChallengeRefreshRedDotChanged,
	// Token: 0x040022FF RID: 8959
	WeeklyChallengeRewardStateChanged,
	// Token: 0x04002300 RID: 8960
	WeeklyChallengeScoreChanged,
	// Token: 0x04002301 RID: 8961
	OnTrialRoleDataChanged,
	// Token: 0x04002302 RID: 8962
	OnProjectionPhotoItemStartDrag,
	// Token: 0x04002303 RID: 8963
	OnProjectionPhotoItemEndDrag,
	// Token: 0x04002304 RID: 8964
	OnProjectionPhotoFinishDrag,
	// Token: 0x04002305 RID: 8965
	OnProjectionPhotoItemPointDown,
	// Token: 0x04002306 RID: 8966
	OnProjectionPhotoItemPointUp,
	// Token: 0x04002307 RID: 8967
	OnProjectionPhotoSliderEndDrag,
	// Token: 0x04002308 RID: 8968
	OnHorizontalSliderValueFirstChange,
	// Token: 0x04002309 RID: 8969
	OnProjectionPhotoItemDragCancel,
	// Token: 0x0400230A RID: 8970
	VisionSummonEndByAction,
	// Token: 0x0400230B RID: 8971
	ClosePlotCaptionImageView,
	// Token: 0x0400230C RID: 8972
	MultiMotorRankInfoRefresh,
	// Token: 0x0400230D RID: 8973
	MultiMotorRefresh,
	// Token: 0x0400230E RID: 8974
	MultiMotorBuffRefresh,
	// Token: 0x0400230F RID: 8975
	MultiMotorPassLine,
	// Token: 0x04002310 RID: 8976
	MultiMotorStart,
	// Token: 0x04002311 RID: 8977
	OnDollGrabMachineClawStateStart,
	// Token: 0x04002312 RID: 8978
	OnDollGrabMachineGrabbingActorChanged,
	// Token: 0x04002313 RID: 8979
	OnDollGrabMachineClawStateEnd,
	// Token: 0x04002314 RID: 8980
	OnDollGrabMachineRemainingTimeAdd,
	// Token: 0x04002315 RID: 8981
	OnDollGrabMachineGrabDoll,
	// Token: 0x04002316 RID: 8982
	OnDollGrabMachineEndlessScoreChanged,
	// Token: 0x04002317 RID: 8983
	OnDollGrabMachineStartCoolDown,
	// Token: 0x04002318 RID: 8984
	OnDollGrabMachineEndCoolDown,
	// Token: 0x04002319 RID: 8985
	OnDollGrabMachineEnd,
	// Token: 0x0400231A RID: 8986
	OnDollGrabMachineRestart,
	// Token: 0x0400231B RID: 8987
	OnDollGrabMachinePause,
	// Token: 0x0400231C RID: 8988
	OnDollGrabMachineResume,
	// Token: 0x0400231D RID: 8989
	OnDollGrabMachineDelivery,
	// Token: 0x0400231E RID: 8990
	OnDollGrabMachineDeliveryFinish,
	// Token: 0x0400231F RID: 8991
	OnDollGrabMachineDangerousCountdown,
	// Token: 0x04002320 RID: 8992
	OnDollGrabMachineGameplayStateChanged,
	// Token: 0x04002321 RID: 8993
	QuestMultiLineTimePointChange,
	// Token: 0x04002322 RID: 8994
	OnEntityPerformanceStateChanged,
	// Token: 0x04002323 RID: 8995
	RestartHangingPreloadTask,
	// Token: 0x04002324 RID: 8996
	RealmBetweenTaskRefresh,
	// Token: 0x04002325 RID: 8997
	RealmBetweenMotorRefresh,
	// Token: 0x04002326 RID: 8998
	RealmBetweenTaskNavigationNext,
	// Token: 0x04002327 RID: 8999
	OnWuWaGoRoleDead,
	// Token: 0x04002328 RID: 9000
	OnWuWaGoDamageBatchStateChanged,
	// Token: 0x04002329 RID: 9001
	OnWuWaGoMoveMonsterActed,
	// Token: 0x0400232A RID: 9002
	OnWuWaGoUserPickScreen,
	// Token: 0x0400232B RID: 9003
	OnWuWaGoUserPreviewScreen,
	// Token: 0x0400232C RID: 9004
	OnWuWaGoUserPickDirection,
	// Token: 0x0400232D RID: 9005
	OnWuWaGoUserUseInteraction,
	// Token: 0x0400232E RID: 9006
	OnWuWaGoInteractionAvailable,
	// Token: 0x0400232F RID: 9007
	OnWuWaGoPlayTipAvailable,
	// Token: 0x04002330 RID: 9008
	OnWuWaGoMainControlInputAcceptingChanged,
	// Token: 0x04002331 RID: 9009
	OnWuWaGoCinematicPlayingChanged,
	// Token: 0x04002332 RID: 9010
	OnWuWaGoProgressUpdate,
	// Token: 0x04002333 RID: 9011
	OnWuWaGoRollbackAvailable,
	// Token: 0x04002334 RID: 9012
	OnWuWaGoUserRequestRollbackToSavePoint,
	// Token: 0x04002335 RID: 9013
	OnAnimNotifyMaterialControllerHandleAdded,
	// Token: 0x04002336 RID: 9014
	OnGotoAnomaly,
	// Token: 0x04002337 RID: 9015
	OnSheriffShopRedDotRefresh,
	// Token: 0x04002338 RID: 9016
	ActivitySignGrandRewardRefresh,
	// Token: 0x04002339 RID: 9017
	OnUnOpenedAreaCountDownUpdate,
	// Token: 0x0400233A RID: 9018
	OnPhotoSaveViewPersonalInfoShowRefresh,
	// Token: 0x0400233B RID: 9019
	OnRoleTrialStateChanged,
	// Token: 0x0400233C RID: 9020
	OnInteractiveItemsFunctionEnableChanged,
	// Token: 0x0400233D RID: 9021
	OnLevelInputLockChanged,
	// Token: 0x0400233E RID: 9022
	OnWorldMapExtraUiOpen,
	// Token: 0x0400233F RID: 9023
	OnWorldMapExtraUiClose,
	// Token: 0x04002340 RID: 9024
	OnRefreshBattleRoleSlot,
	// Token: 0x04002341 RID: 9025
	OnDangoBrawlSelectionChanged,
	// Token: 0x04002342 RID: 9026
	OnDangoBrawlOverlapChanged,
	// Token: 0x04002343 RID: 9027
	OnDagnoBrawlClickOption,
	// Token: 0x04002344 RID: 9028
	OnDangoBrawlShortcutKey,
	// Token: 0x04002345 RID: 9029
	OnDangoBrawlShopToggleLock,
	// Token: 0x04002346 RID: 9030
	OnDangoBrawlRotateRequest,
	// Token: 0x04002347 RID: 9031
	OnDangoBrawlCoinUpdated,
	// Token: 0x04002348 RID: 9032
	OnDangoBrawlShopRefreshed,
	// Token: 0x04002349 RID: 9033
	OnDangoBrawlShopBought,
	// Token: 0x0400234A RID: 9034
	OnDangoBrawlShopComposed,
	// Token: 0x0400234B RID: 9035
	OnDangoBrawlShopSold,
	// Token: 0x0400234C RID: 9036
	OnDangoBrawlBagOperated,
	// Token: 0x0400234D RID: 9037
	OnDangoBrawlDragWillBegin,
	// Token: 0x0400234E RID: 9038
	OnDangoBrawlDragBegin,
	// Token: 0x0400234F RID: 9039
	OnDangoBrawlDragEnd,
	// Token: 0x04002350 RID: 9040
	OnDangoBrawlDragEndAnyWay,
	// Token: 0x04002351 RID: 9041
	OnDangoBrawlLayerModeChanged,
	// Token: 0x04002352 RID: 9042
	OnDangoBrawlCostChanged,
	// Token: 0x04002353 RID: 9043
	OnDangoBrawlBackpackModified,
	// Token: 0x04002354 RID: 9044
	OnDangoBrawlBenchModified,
	// Token: 0x04002355 RID: 9045
	OnDangoBrawlInteractionStateChanged,
	// Token: 0x04002356 RID: 9046
	OnDangoBrawlBagUpdated,
	// Token: 0x04002357 RID: 9047
	OnDangoBrawlItemHoveredChange,
	// Token: 0x04002358 RID: 9048
	OnDangoBrawlShopStateTipsClosed,
	// Token: 0x04002359 RID: 9049
	OnDangoBrawlRoundStartEffectsReady,
	// Token: 0x0400235A RID: 9050
	OnDangoBrawlLoseCountChanged,
	// Token: 0x0400235B RID: 9051
	OnDangoBrawlItemGiveCoinNotify,
	// Token: 0x0400235C RID: 9052
	OnDangoBrawlItemEffectShowNotify,
	// Token: 0x0400235D RID: 9053
	OnDangoBrawlShopLockChangedNotify,
	// Token: 0x0400235E RID: 9054
	OnDangoBrawlThreeChooseClosed,
	// Token: 0x0400235F RID: 9055
	OnDangoBrawlThreeChooseStateChanged,
	// Token: 0x04002360 RID: 9056
	OnDangoBrawlThreeChooseRecover,
	// Token: 0x04002361 RID: 9057
	OnDangoBrawlRoundSettleStateChanged,
	// Token: 0x04002362 RID: 9058
	OnDangoBrawlRoundSettleRecover,
	// Token: 0x04002363 RID: 9059
	OnDangoBrawlRoundSettleClosed,
	// Token: 0x04002364 RID: 9060
	OnDangobrawlMoveRotateHotKeyNotify,
	// Token: 0x04002365 RID: 9061
	OnDangobrawlLockShopGoodsHotKeyNotify,
	// Token: 0x04002366 RID: 9062
	OnDangobrawlOpenCombineTipsHotKeyNofify,
	// Token: 0x04002367 RID: 9063
	OnDangobrawlCancelHotKeyNotify,
	// Token: 0x04002368 RID: 9064
	OnDangobrawlReplaceHotKeyNotify,
	// Token: 0x04002369 RID: 9065
	OnDangobrawlOpenItemTipsHotkeyNotify,
	// Token: 0x0400236A RID: 9066
	OnDangoBrawlEntityCreate,
	// Token: 0x0400236B RID: 9067
	OnDangoBrawlFightingTimerInit,
	// Token: 0x0400236C RID: 9068
	OnDangoBrawlBattleBuffUpdate,
	// Token: 0x0400236D RID: 9069
	OnDangoBrawlBattleBuffVisualCue,
	// Token: 0x0400236E RID: 9070
	OnDangoBrawlFightStateModify,
	// Token: 0x0400236F RID: 9071
	OnDangoBrawlChooseCardRefresh,
	// Token: 0x04002370 RID: 9072
	OnDangoBrawlActiveEventsUpdated,
	// Token: 0x04002371 RID: 9073
	OnDangoBrawlFatigueFirstTriggered,
	// Token: 0x04002372 RID: 9074
	OnDangoBrawlBattleLogChanged,
	// Token: 0x04002373 RID: 9075
	OnDangoBrawlFighterAttrChanged,
	// Token: 0x04002374 RID: 9076
	OnDangoBrawlDamageUiText,
	// Token: 0x04002375 RID: 9077
	OnDangoBrawlItemCdUpdate,
	// Token: 0x04002376 RID: 9078
	OnDangoBrawlItemUIEffectShow,
	// Token: 0x04002377 RID: 9079
	OnDangoBrawlWeaponStop,
	// Token: 0x04002378 RID: 9080
	OnDangoBrawlEnterRoundSettle,
	// Token: 0x04002379 RID: 9081
	OnGiantStableValueChange,
	// Token: 0x0400237A RID: 9082
	OnGiantStageCross,
	// Token: 0x0400237B RID: 9083
	OnGiantIdleChange,
	// Token: 0x0400237C RID: 9084
	OnGiantUnlockChange,
	// Token: 0x0400237D RID: 9085
	OnGiantPlayMontage,
	// Token: 0x0400237E RID: 9086
	OnGiantBodyVisibilityChange,
	// Token: 0x0400237F RID: 9087
	OnGiantEcoStatusChange,
	// Token: 0x04002380 RID: 9088
	OnGiantAccessProgressChange,
	// Token: 0x04002381 RID: 9089
	OnGiantCommissionRead,
	// Token: 0x04002382 RID: 9090
	OnGiantNodeInteractChange,
	// Token: 0x04002383 RID: 9091
	OnDynamicDetectableActorsChanged,
	// Token: 0x04002384 RID: 9092
	OnPathDrivenActorRunStateChanged,
	// Token: 0x04002385 RID: 9093
	OnPathDrivenActorBatchSpawnedChanged,
	// Token: 0x04002386 RID: 9094
	Test0,
	// Token: 0x04002387 RID: 9095
	Test1,
	// Token: 0x04002388 RID: 9096
	Test2,
	// Token: 0x04002389 RID: 9097
	Test3,
	// Token: 0x0400238A RID: 9098
	Test4,
	// Token: 0x0400238B RID: 9099
	Test5,
	// Token: 0x0400238C RID: 9100
	Test6,
	// Token: 0x0400238D RID: 9101
	Test7,
	// Token: 0x0400238E RID: 9102
	ResetToBattleView,
	// Token: 0x0400238F RID: 9103
	OnHonamiStorySafeLeaveUpdate,
	// Token: 0x04002390 RID: 9104
	MovieModeAspectFadeComplete,
	// Token: 0x04002391 RID: 9105
	MotorDevelopTechTreeNodeUpdate,
	// Token: 0x04002392 RID: 9106
	RouletteRefreshRedDot,
	// Token: 0x04002393 RID: 9107
	RouletteRefreshNewOrRedDot,
	// Token: 0x04002394 RID: 9108
	RouletteAssemblyGridRefreshRedDot,
	// Token: 0x04002395 RID: 9109
	BattleUiPressMusicCombineButtonChanged,
	// Token: 0x04002396 RID: 9110
	TeleportAfterComplete,
	// Token: 0x04002397 RID: 9111
	BeforeTeleportComplete,
	// Token: 0x04002398 RID: 9112
	PlotTeleportToPositionFinished,
	// Token: 0x04002399 RID: 9113
	MotorUiModelUpdate,
	// Token: 0x0400239A RID: 9114
	ShowAreaTips,
	// Token: 0x0400239B RID: 9115
	RoleFindMotorcycleInteractiveEntity,
	// Token: 0x0400239C RID: 9116
	RoleFindFixHook,
	// Token: 0x0400239D RID: 9117
	OnMotorPlayTick,
	// Token: 0x0400239E RID: 9118
	TsSyncWorldLevel,
	// Token: 0x0400239F RID: 9119
	OnGuessJokerLevelUnlockNotify,
	// Token: 0x040023A0 RID: 9120
	OnGuessJokerUnlockClickedNotify,
	// Token: 0x040023A1 RID: 9121
	SpawnBoss,
	// Token: 0x040023A2 RID: 9122
	MotorcycleWaterDetectedTick,
	// Token: 0x040023A3 RID: 9123
	MotorcycleWaterDetectedStart,
	// Token: 0x040023A4 RID: 9124
	MotorcycleWaterDetectedEnd,
	// Token: 0x040023A5 RID: 9125
	OnPhantomConfigManagerSharedUpdate,
	// Token: 0x040023A6 RID: 9126
	OnRacingBetsMatchStateChange,
	// Token: 0x040023A7 RID: 9127
	SlidingBlockEndlessSpeedLevel,
	// Token: 0x040023A8 RID: 9128
	OnGameplayTagChanged
}
