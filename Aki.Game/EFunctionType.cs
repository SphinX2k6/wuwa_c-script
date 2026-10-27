using System;

// Token: 0x02001C47 RID: 7239
public enum EFunctionType
{
	// Token: 0x04006366 RID: 25446
	Role = 10001,
	// Token: 0x04006367 RID: 25447
	Bag,
	// Token: 0x04006368 RID: 25448
	Calabash,
	// Token: 0x04006369 RID: 25449
	Quest,
	// Token: 0x0400636A RID: 25450
	CommonGamePlay,
	// Token: 0x0400636B RID: 25451
	TimeLimitGamePlay,
	// Token: 0x0400636C RID: 25452
	FormatTeam,
	// Token: 0x0400636D RID: 25453
	MakeTeam,
	// Token: 0x0400636E RID: 25454
	Gacha,
	// Token: 0x0400636F RID: 25455
	Shop,
	// Token: 0x04006370 RID: 25456
	Friend,
	// Token: 0x04006371 RID: 25457
	Guild,
	// Token: 0x04006372 RID: 25458
	Achievement,
	// Token: 0x04006373 RID: 25459
	HandBook,
	// Token: 0x04006374 RID: 25460
	Map,
	// Token: 0x04006375 RID: 25461
	RecruitmentDivision,
	// Token: 0x04006376 RID: 25462
	PowerModule,
	// Token: 0x04006377 RID: 25463
	TimeOfDay,
	// Token: 0x04006378 RID: 25464
	Menu,
	// Token: 0x04006379 RID: 25465
	Mail,
	// Token: 0x0400637A RID: 25466
	Online,
	// Token: 0x0400637B RID: 25467
	Tutorial,
	// Token: 0x0400637C RID: 25468
	AdventureGuide,
	// Token: 0x0400637D RID: 25469
	RoleQuest = 10025,
	// Token: 0x0400637E RID: 25470
	ExploreTool,
	// Token: 0x0400637F RID: 25471
	FunctionRoulette = 10056,
	// Token: 0x04006380 RID: 25472
	ExploreProgressReward,
	// Token: 0x04006381 RID: 25473
	KuroStreet,
	// Token: 0x04006382 RID: 25474
	SingleTimeTower = 10027,
	// Token: 0x04006383 RID: 25475
	UserFeedback,
	// Token: 0x04006384 RID: 25476
	InfluenceReputation,
	// Token: 0x04006385 RID: 25477
	CycleTower,
	// Token: 0x04006386 RID: 25478
	ShowLockOnButton,
	// Token: 0x04006387 RID: 25479
	WuYinQu,
	// Token: 0x04006388 RID: 25480
	Forging = 10034,
	// Token: 0x04006389 RID: 25481
	Compose,
	// Token: 0x0400638A RID: 25482
	ConcertoResponse,
	// Token: 0x0400638B RID: 25483
	BattlePass = 10040,
	// Token: 0x0400638C RID: 25484
	RoleHandBook,
	// Token: 0x0400638D RID: 25485
	RoleTeach = 10043,
	// Token: 0x0400638E RID: 25486
	InstanceWeapon,
	// Token: 0x0400638F RID: 25487
	InstanceSkill,
	// Token: 0x04006390 RID: 25488
	InstanceLevel,
	// Token: 0x04006391 RID: 25489
	InstanceElement,
	// Token: 0x04006392 RID: 25490
	Advice,
	// Token: 0x04006393 RID: 25491
	Photograph,
	// Token: 0x04006394 RID: 25492
	AdvicePut,
	// Token: 0x04006395 RID: 25493
	HandBookSystem,
	// Token: 0x04006396 RID: 25494
	RoleElementChange,
	// Token: 0x04006397 RID: 25495
	NewTower = 10055,
	// Token: 0x04006398 RID: 25496
	Activity = 10053,
	// Token: 0x04006399 RID: 25497
	PersonalSystem = 10060,
	// Token: 0x0400639A RID: 25498
	PersonalCard,
	// Token: 0x0400639B RID: 25499
	JiYinHuiChuan = 10023001,
	// Token: 0x0400639C RID: 25500
	HuiYinJieXiang,
	// Token: 0x0400639D RID: 25501
	WuYinQv,
	// Token: 0x0400639E RID: 25502
	ShengZhiLingYu,
	// Token: 0x0400639F RID: 25503
	DailyActivity,
	// Token: 0x040063A0 RID: 25504
	VisionIdentify = 10001004,
	// Token: 0x040063A1 RID: 25505
	Roguelike = 110056,
	// Token: 0x040063A2 RID: 25506
	BoosRush = 110058,
	// Token: 0x040063A3 RID: 25507
	LordGym = 110057,
	// Token: 0x040063A4 RID: 25508
	PowerStore = 10066,
	// Token: 0x040063A5 RID: 25509
	VisionRecovery = 10024001,
	// Token: 0x040063A6 RID: 25510
	VisionRefine = 10083,
	// Token: 0x040063A7 RID: 25511
	PowerMagnificationReward = 10071,
	// Token: 0x040063A8 RID: 25512
	MailBind,
	// Token: 0x040063A9 RID: 25513
	Fishing,
	// Token: 0x040063AA RID: 25514
	VisionRecommend,
	// Token: 0x040063AB RID: 25515
	VisionGroup,
	// Token: 0x040063AC RID: 25516
	FishingItemDelete,
	// Token: 0x040063AD RID: 25517
	FishingItemSail,
	// Token: 0x040063AE RID: 25518
	FishingTech,
	// Token: 0x040063AF RID: 25519
	FishingPhoebeTech = 100781,
	// Token: 0x040063B0 RID: 25520
	FishingHandBook = 10079,
	// Token: 0x040063B1 RID: 25521
	FishingGhostShip,
	// Token: 0x040063B2 RID: 25522
	FishingEntrust = 100081,
	// Token: 0x040063B3 RID: 25523
	ShipTower = 10081,
	// Token: 0x040063B4 RID: 25524
	PlayerTitle,
	// Token: 0x040063B5 RID: 25525
	BirthdayReward = 10084,
	// Token: 0x040063B6 RID: 25526
	GameIntroduction = 10086,
	// Token: 0x040063B7 RID: 25527
	PhantomArenaCoreCardSlot = 10085,
	// Token: 0x040063B8 RID: 25528
	PhantomArenaCollect = 10088,
	// Token: 0x040063B9 RID: 25529
	PhantomArenaRole,
	// Token: 0x040063BA RID: 25530
	PhantomArenaCard,
	// Token: 0x040063BB RID: 25531
	PhantomArenaCardUnlock,
	// Token: 0x040063BC RID: 25532
	PhantomArenaCardOutlookUnlock,
	// Token: 0x040063BD RID: 25533
	PhantomArenaSkipFuncUnlock,
	// Token: 0x040063BE RID: 25534
	DirectTrainPro = 10095,
	// Token: 0x040063BF RID: 25535
	Soar = 10026010,
	// Token: 0x040063C0 RID: 25536
	RoleDev = 10097,
	// Token: 0x040063C1 RID: 25537
	MotorDevelop,
	// Token: 0x040063C2 RID: 25538
	MotorTechTree,
	// Token: 0x040063C3 RID: 25539
	MotorFreezeWater = 10143,
	// Token: 0x040063C4 RID: 25540
	HonamiStoryBackpack = 10102,
	// Token: 0x040063C5 RID: 25541
	HonamiStoryMainQuestLifeSupport,
	// Token: 0x040063C6 RID: 25542
	HonamiStoryBackpackStage1FuncId,
	// Token: 0x040063C7 RID: 25543
	HonamiStoryLifeSupport,
	// Token: 0x040063C8 RID: 25544
	SafeLeaveBuyFuncId = 10115,
	// Token: 0x040063C9 RID: 25545
	ChangeDangerFuncId = 10121,
	// Token: 0x040063CA RID: 25546
	TowerOpenFuncId = 10120,
	// Token: 0x040063CB RID: 25547
	LvSelectOpenFuncId = 10112,
	// Token: 0x040063CC RID: 25548
	HonamiStoryPollution = 10114,
	// Token: 0x040063CD RID: 25549
	HonamiStoryRoleSelectFuncId = 10111,
	// Token: 0x040063CE RID: 25550
	HonamiStoryWeaponSelectFuncId = 10123,
	// Token: 0x040063CF RID: 25551
	HonamiStoryMascotFuncId = 10116,
	// Token: 0x040063D0 RID: 25552
	HonamiStoryAreaTaskFuncId = 10113,
	// Token: 0x040063D1 RID: 25553
	HonamiStoryShopFuncId = 10117,
	// Token: 0x040063D2 RID: 25554
	HonamiStoryItemCollectFuncId,
	// Token: 0x040063D3 RID: 25555
	HonamiStoryTechFuncId = 10107,
	// Token: 0x040063D4 RID: 25556
	HonamiStoryMainQuestFuncId = 10124,
	// Token: 0x040063D5 RID: 25557
	HonamiStoryLifeSupportCanUpdate = 10122,
	// Token: 0x040063D6 RID: 25558
	PhotoSelfie = 10160,
	// Token: 0x040063D7 RID: 25559
	PhoneMsg = 10130,
	// Token: 0x040063D8 RID: 25560
	Infrastructure,
	// Token: 0x040063D9 RID: 25561
	PermanentPhantomArea,
	// Token: 0x040063DA RID: 25562
	PermanentPhantomAreaCollect = 10135,
	// Token: 0x040063DB RID: 25563
	PermanentPhantomArenaRole,
	// Token: 0x040063DC RID: 25564
	PermanentPhantomArenaCard,
	// Token: 0x040063DD RID: 25565
	PermanentPhantomArenaCardUnlock,
	// Token: 0x040063DE RID: 25566
	PermanentPhantomArenaRecommend,
	// Token: 0x040063DF RID: 25567
	PermanentPhantomArenaSkipFuncUnlock = 10141,
	// Token: 0x040063E0 RID: 25568
	PermanentPhantomArenaCoreCardSlot,
	// Token: 0x040063E1 RID: 25569
	WeatherCentral = 10133,
	// Token: 0x040063E2 RID: 25570
	FeedbackReward = 10140,
	// Token: 0x040063E3 RID: 25571
	VisionAim = 10100,
	// Token: 0x040063E4 RID: 25572
	MotorSoar = 10154,
	// Token: 0x040063E5 RID: 25573
	VillageInfr = 10150,
	// Token: 0x040063E6 RID: 25574
	PinballDailyLevel,
	// Token: 0x040063E7 RID: 25575
	PinballRole,
	// Token: 0x040063E8 RID: 25576
	PinballShop,
	// Token: 0x040063E9 RID: 25577
	WeeklyChallenge = 10155,
	// Token: 0x040063EA RID: 25578
	SheriffAnomaly,
	// Token: 0x040063EB RID: 25579
	SheriffQuest,
	// Token: 0x040063EC RID: 25580
	MoonChasingMain = 10159
}
