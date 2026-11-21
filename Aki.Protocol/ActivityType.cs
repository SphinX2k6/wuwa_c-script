using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020015B4 RID: 5556
	public enum ActivityType
	{
		// Token: 0x0400A930 RID: 43312
		[OriginalName("Parkour")]
		Parkour,
		// Token: 0x0400A931 RID: 43313
		[OriginalName("GatherActivity")]
		GatherActivity,
		// Token: 0x0400A932 RID: 43314
		[OriginalName("Sign")]
		Sign,
		// Token: 0x0400A933 RID: 43315
		[OriginalName("TowerGuide")]
		TowerGuide,
		// Token: 0x0400A934 RID: 43316
		[OriginalName("NewBieCourse")]
		NewBieCourse,
		// Token: 0x0400A935 RID: 43317
		[OriginalName("WorldNewJourney")]
		WorldNewJourney,
		// Token: 0x0400A936 RID: 43318
		[OriginalName("RougeActivity")]
		RougeActivity,
		// Token: 0x0400A937 RID: 43319
		[OriginalName("DoubleInstanceRewardActivity")]
		DoubleInstanceRewardActivity,
		// Token: 0x0400A938 RID: 43320
		[OriginalName("RoleTrialActivity")]
		RoleTrialActivity,
		// Token: 0x0400A939 RID: 43321
		[OriginalName("Harvest")]
		Harvest,
		// Token: 0x0400A93A RID: 43322
		[OriginalName("NewRoleGuideActivity")]
		NewRoleGuideActivity,
		// Token: 0x0400A93B RID: 43323
		[OriginalName("PhantomCollect")]
		PhantomCollect,
		// Token: 0x0400A93C RID: 43324
		[OriginalName("DailyAdventureActivity")]
		DailyAdventureActivity,
		// Token: 0x0400A93D RID: 43325
		[OriginalName("LongShanMainActivity")]
		LongShanMainActivity,
		// Token: 0x0400A93E RID: 43326
		[OriginalName("BossRushActivity")]
		BossRushActivity,
		// Token: 0x0400A93F RID: 43327
		[OriginalName("TurnTableActivity")]
		TurnTableActivity,
		// Token: 0x0400A940 RID: 43328
		[OriginalName("PhotoMemoryActivity")]
		PhotoMemoryActivity,
		// Token: 0x0400A941 RID: 43329
		[OriginalName("TrackMoonActivity")]
		TrackMoonActivity,
		// Token: 0x0400A942 RID: 43330
		[OriginalName("CircumFluence")]
		CircumFluence,
		// Token: 0x0400A943 RID: 43331
		[OriginalName("TowerDefenceActivity")]
		TowerDefenceActivity,
		// Token: 0x0400A944 RID: 43332
		[OriginalName("TimePointRewardActivity")]
		TimePointRewardActivity,
		// Token: 0x0400A945 RID: 43333
		[OriginalName("TowerGuideNew")]
		TowerGuideNew,
		// Token: 0x0400A946 RID: 43334
		[OriginalName("TrackMoonPhase")]
		TrackMoonPhase,
		// Token: 0x0400A947 RID: 43335
		[OriginalName("RiskHarvest")]
		RiskHarvest,
		// Token: 0x0400A948 RID: 43336
		[OriginalName("CorniceMeeting")]
		CorniceMeeting,
		// Token: 0x0400A949 RID: 43337
		[OriginalName("BlackCoastTheme")]
		BlackCoastTheme,
		// Token: 0x0400A94A RID: 43338
		[OriginalName("RogueWhiteCat")]
		RogueWhiteCat,
		// Token: 0x0400A94B RID: 43339
		[OriginalName("ScratchCard")]
		ScratchCard,
		// Token: 0x0400A94C RID: 43340
		[OriginalName("PreheatSign")]
		PreheatSign,
		// Token: 0x0400A94D RID: 43341
		[OriginalName("MowTower")]
		MowTower,
		// Token: 0x0400A94E RID: 43342
		[OriginalName("ThroughTrain")]
		ThroughTrain,
		// Token: 0x0400A94F RID: 43343
		[OriginalName("SprintSign")]
		SprintSign,
		// Token: 0x0400A950 RID: 43344
		[OriginalName("MapTravelActivity")]
		MapTravelActivity,
		// Token: 0x0400A951 RID: 43345
		[OriginalName("FarmGold")]
		FarmGold,
		// Token: 0x0400A952 RID: 43346
		[OriginalName("NewLordGym")]
		NewLordGym,
		// Token: 0x0400A953 RID: 43347
		[OriginalName("RoleSkinTrialActivity")]
		RoleSkinTrialActivity,
		// Token: 0x0400A954 RID: 43348
		[OriginalName("RogueWeekly")]
		RogueWeekly,
		// Token: 0x0400A955 RID: 43349
		[OriginalName("FishingActivity")]
		FishingActivity,
		// Token: 0x0400A956 RID: 43350
		[OriginalName("TeamParkOurActivity")]
		TeamParkOurActivity,
		// Token: 0x0400A957 RID: 43351
		[OriginalName("SlashAndTowerLevelPlay")]
		SlashAndTowerLevelPlay,
		// Token: 0x0400A958 RID: 43352
		[OriginalName("BabelTower")]
		BabelTower,
		// Token: 0x0400A959 RID: 43353
		[OriginalName("Avignon")]
		Avignon,
		// Token: 0x0400A95A RID: 43354
		[OriginalName("BetHorses")]
		BetHorses,
		// Token: 0x0400A95B RID: 43355
		[OriginalName("Explore")]
		Explore,
		// Token: 0x0400A95C RID: 43356
		[OriginalName("Abyss")]
		Abyss,
		// Token: 0x0400A95D RID: 43357
		[OriginalName("RogueRes")]
		RogueRes,
		// Token: 0x0400A95E RID: 43358
		[OriginalName("H5CircumFluence")]
		H5CircumFluence,
		// Token: 0x0400A95F RID: 43359
		[OriginalName("DangoMonopoly")]
		DangoMonopoly,
		// Token: 0x0400A960 RID: 43360
		[OriginalName("CiacconaActivity")]
		CiacconaActivity,
		// Token: 0x0400A961 RID: 43361
		[OriginalName("ActivityLinkage")]
		ActivityLinkage,
		// Token: 0x0400A962 RID: 43362
		[OriginalName("RegressActivity")]
		RegressActivity,
		// Token: 0x0400A963 RID: 43363
		[OriginalName("ConsumptiveActivity")]
		ConsumptiveActivity,
		// Token: 0x0400A964 RID: 43364
		[OriginalName("PhantomBattle")]
		PhantomBattle,
		// Token: 0x0400A965 RID: 43365
		[OriginalName("NewbieCarnival")]
		NewbieCarnival,
		// Token: 0x0400A966 RID: 43366
		[OriginalName("MoraleActivity")]
		MoraleActivity,
		// Token: 0x0400A967 RID: 43367
		[OriginalName("FloroRanchActivity")]
		FloroRanchActivity,
		// Token: 0x0400A968 RID: 43368
		[OriginalName("LifePointChallenge")]
		LifePointChallenge,
		// Token: 0x0400A969 RID: 43369
		[OriginalName("TrapDefense")]
		TrapDefense,
		// Token: 0x0400A96A RID: 43370
		[OriginalName("JinzhouFlyActivity")]
		JinzhouFlyActivity,
		// Token: 0x0400A96B RID: 43371
		[OriginalName("FunPlay")]
		FunPlay,
		// Token: 0x0400A96C RID: 43372
		[OriginalName("MoonPhase")]
		MoonPhase,
		// Token: 0x0400A96D RID: 43373
		[OriginalName("LineCross")]
		LineCross,
		// Token: 0x0400A96E RID: 43374
		[OriginalName("HonamiStory")]
		HonamiStory,
		// Token: 0x0400A96F RID: 43375
		[OriginalName("Survivors")]
		Survivors,
		// Token: 0x0400A970 RID: 43376
		[OriginalName("PhotoFight")]
		PhotoFight,
		// Token: 0x0400A971 RID: 43377
		[OriginalName("WuWuKuji")]
		WuWuKuji,
		// Token: 0x0400A972 RID: 43378
		[OriginalName("FirstPersonParkour")]
		FirstPersonParkour,
		// Token: 0x0400A973 RID: 43379
		[OriginalName("PreHeatTaskActivity")]
		PreHeatTaskActivity,
		// Token: 0x0400A974 RID: 43380
		[OriginalName("InfrTheme")]
		InfrTheme,
		// Token: 0x0400A975 RID: 43381
		[OriginalName("AdvanceNoticeActivity")]
		AdvanceNoticeActivity,
		// Token: 0x0400A976 RID: 43382
		[OriginalName("PhantomBattleRecord")]
		PhantomBattleRecord,
		// Token: 0x0400A977 RID: 43383
		[OriginalName("CoopActivity")]
		CoopActivity,
		// Token: 0x0400A978 RID: 43384
		[OriginalName("PhantomBattleRecordGuide")]
		PhantomBattleRecordGuide,
		// Token: 0x0400A979 RID: 43385
		[OriginalName("ArtemisActivity")]
		ArtemisActivity,
		// Token: 0x0400A97A RID: 43386
		[OriginalName("MotorcycleIpLink")]
		MotorcycleIpLink,
		// Token: 0x0400A97B RID: 43387
		[OriginalName("SkinRewardActivity")]
		SkinRewardActivity,
		// Token: 0x0400A97C RID: 43388
		[OriginalName("RoadBookActivity")]
		RoadBookActivity,
		// Token: 0x0400A97D RID: 43389
		[OriginalName("NewTowerClimbing")]
		NewTowerClimbing,
		// Token: 0x0400A97E RID: 43390
		[OriginalName("MotorFight")]
		MotorFight,
		// Token: 0x0400A97F RID: 43391
		[OriginalName("Encircle")]
		Encircle,
		// Token: 0x0400A980 RID: 43392
		[OriginalName("NewPlayerSupportActivity")]
		NewPlayerSupportActivity,
		// Token: 0x0400A981 RID: 43393
		[OriginalName("SpringFestivalActivity")]
		SpringFestivalActivity,
		// Token: 0x0400A982 RID: 43394
		[OriginalName("MotorParkourActivity")]
		MotorParkourActivity,
		// Token: 0x0400A983 RID: 43395
		[OriginalName("TotalTopUp")]
		TotalTopUp,
		// Token: 0x0400A984 RID: 43396
		[OriginalName("H5View")]
		H5View,
		// Token: 0x0400A985 RID: 43397
		[OriginalName("MotorDevelop")]
		MotorDevelop,
		// Token: 0x0400A986 RID: 43398
		[OriginalName("FlagChallenge")]
		FlagChallenge,
		// Token: 0x0400A987 RID: 43399
		[OriginalName("Rhythm")]
		Rhythm,
		// Token: 0x0400A988 RID: 43400
		[OriginalName("FeiXue")]
		FeiXue = 89,
		// Token: 0x0400A989 RID: 43401
		[OriginalName("DropCatchActivity")]
		DropCatchActivity,
		// Token: 0x0400A98A RID: 43402
		[OriginalName("TetrisActivity")]
		TetrisActivity,
		// Token: 0x0400A98B RID: 43403
		[OriginalName("InfrThemeV2")]
		InfrThemeV2,
		// Token: 0x0400A98C RID: 43404
		[OriginalName("Kurotato")]
		Kurotato,
		// Token: 0x0400A98D RID: 43405
		[OriginalName("PinballActivity")]
		PinballActivity,
		// Token: 0x0400A98E RID: 43406
		[OriginalName("WuWuWeekSign")]
		WuWuWeekSign = 96,
		// Token: 0x0400A98F RID: 43407
		[OriginalName("AnniversaryTheme")]
		AnniversaryTheme,
		// Token: 0x0400A990 RID: 43408
		[OriginalName("BossPiling")]
		BossPiling,
		// Token: 0x0400A991 RID: 43409
		[OriginalName("GolemCrackActivity")]
		GolemCrackActivity,
		// Token: 0x0400A992 RID: 43410
		[OriginalName("EdgeRunnerActivity")]
		EdgeRunnerActivity,
		// Token: 0x0400A993 RID: 43411
		[OriginalName("MotorDecalActivity")]
		MotorDecalActivity,
		// Token: 0x0400A994 RID: 43412
		[OriginalName("MotorParkour")]
		MotorParkour,
		// Token: 0x0400A995 RID: 43413
		[OriginalName("LinkageCheckIn")]
		LinkageCheckIn,
		// Token: 0x0400A996 RID: 43414
		[OriginalName("RoleGiftActivity")]
		RoleGiftActivity,
		// Token: 0x0400A997 RID: 43415
		[OriginalName("RealmBetween")]
		RealmBetween,
		// Token: 0x0400A998 RID: 43416
		[OriginalName("SheriffActivity")]
		SheriffActivity,
		// Token: 0x0400A999 RID: 43417
		[OriginalName("ThroughTrainSummary")]
		ThroughTrainSummary,
		// Token: 0x0400A99A RID: 43418
		[OriginalName("NewPlayerSupportActivityV2")]
		NewPlayerSupportActivityV2,
		// Token: 0x0400A99B RID: 43419
		[OriginalName("NewbieAdventureV2")]
		NewbieAdventureV2,
		// Token: 0x0400A99C RID: 43420
		[OriginalName("NewbieCourseV2")]
		NewbieCourseV2,
		// Token: 0x0400A99D RID: 43421
		[OriginalName("NewbieMain")]
		NewbieMain,
		// Token: 0x0400A99E RID: 43422
		[OriginalName("RoverRogue")]
		RoverRogue,
		// Token: 0x0400A99F RID: 43423
		[OriginalName("DangoBrawl")]
		DangoBrawl,
		// Token: 0x0400A9A0 RID: 43424
		[OriginalName("QingXiaoPlayThePiano")]
		QingXiaoPlayThePiano,
		// Token: 0x0400A9A1 RID: 43425
		[OriginalName("PurePreviewActivity")]
		PurePreviewActivity,
		// Token: 0x0400A9A2 RID: 43426
		[OriginalName("MatchThreeActivity")]
		MatchThreeActivity,
		// Token: 0x0400A9A3 RID: 43427
		[OriginalName("SolarSchool")]
		SolarSchool,
		// Token: 0x0400A9A4 RID: 43428
		[OriginalName("GiantSystemActivity")]
		GiantSystemActivity,
		// Token: 0x0400A9A5 RID: 43429
		[OriginalName("RoleTower")]
		RoleTower = 120,
		// Token: 0x0400A9A6 RID: 43430
		[OriginalName("PureUIActivity")]
		PureUiactivity = 200
	}
}
