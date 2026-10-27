using System;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200153E RID: 5438
	public enum ActivityType
	{
		// Token: 0x0400A4D4 RID: 42196
		[OriginalName("Parkour")]
		Parkour,
		// Token: 0x0400A4D5 RID: 42197
		[OriginalName("GatherActivity")]
		GatherActivity,
		// Token: 0x0400A4D6 RID: 42198
		[OriginalName("Sign")]
		Sign,
		// Token: 0x0400A4D7 RID: 42199
		[OriginalName("TowerGuide")]
		TowerGuide,
		// Token: 0x0400A4D8 RID: 42200
		[OriginalName("NewBieCourse")]
		NewBieCourse,
		// Token: 0x0400A4D9 RID: 42201
		[OriginalName("WorldNewJourney")]
		WorldNewJourney,
		// Token: 0x0400A4DA RID: 42202
		[OriginalName("RougeActivity")]
		RougeActivity,
		// Token: 0x0400A4DB RID: 42203
		[OriginalName("DoubleInstanceRewardActivity")]
		DoubleInstanceRewardActivity,
		// Token: 0x0400A4DC RID: 42204
		[OriginalName("RoleTrialActivity")]
		RoleTrialActivity,
		// Token: 0x0400A4DD RID: 42205
		[OriginalName("Harvest")]
		Harvest,
		// Token: 0x0400A4DE RID: 42206
		[OriginalName("NewRoleGuideActivity")]
		NewRoleGuideActivity,
		// Token: 0x0400A4DF RID: 42207
		[OriginalName("PhantomCollect")]
		PhantomCollect,
		// Token: 0x0400A4E0 RID: 42208
		[OriginalName("DailyAdventureActivity")]
		DailyAdventureActivity,
		// Token: 0x0400A4E1 RID: 42209
		[OriginalName("LongShanMainActivity")]
		LongShanMainActivity,
		// Token: 0x0400A4E2 RID: 42210
		[OriginalName("BossRushActivity")]
		BossRushActivity,
		// Token: 0x0400A4E3 RID: 42211
		[OriginalName("TurnTableActivity")]
		TurnTableActivity,
		// Token: 0x0400A4E4 RID: 42212
		[OriginalName("PhotoMemoryActivity")]
		PhotoMemoryActivity,
		// Token: 0x0400A4E5 RID: 42213
		[OriginalName("TrackMoonActivity")]
		TrackMoonActivity,
		// Token: 0x0400A4E6 RID: 42214
		[OriginalName("CircumFluence")]
		CircumFluence,
		// Token: 0x0400A4E7 RID: 42215
		[OriginalName("TowerDefenceActivity")]
		TowerDefenceActivity,
		// Token: 0x0400A4E8 RID: 42216
		[OriginalName("TimePointRewardActivity")]
		TimePointRewardActivity,
		// Token: 0x0400A4E9 RID: 42217
		[OriginalName("TowerGuideNew")]
		TowerGuideNew,
		// Token: 0x0400A4EA RID: 42218
		[OriginalName("TrackMoonPhase")]
		TrackMoonPhase,
		// Token: 0x0400A4EB RID: 42219
		[OriginalName("RiskHarvest")]
		RiskHarvest,
		// Token: 0x0400A4EC RID: 42220
		[OriginalName("CorniceMeeting")]
		CorniceMeeting,
		// Token: 0x0400A4ED RID: 42221
		[OriginalName("BlackCoastTheme")]
		BlackCoastTheme,
		// Token: 0x0400A4EE RID: 42222
		[OriginalName("RogueWhiteCat")]
		RogueWhiteCat,
		// Token: 0x0400A4EF RID: 42223
		[OriginalName("ScratchCard")]
		ScratchCard,
		// Token: 0x0400A4F0 RID: 42224
		[OriginalName("PreheatSign")]
		PreheatSign,
		// Token: 0x0400A4F1 RID: 42225
		[OriginalName("MowTower")]
		MowTower,
		// Token: 0x0400A4F2 RID: 42226
		[OriginalName("ThroughTrain")]
		ThroughTrain,
		// Token: 0x0400A4F3 RID: 42227
		[OriginalName("SprintSign")]
		SprintSign,
		// Token: 0x0400A4F4 RID: 42228
		[OriginalName("MapTravelActivity")]
		MapTravelActivity,
		// Token: 0x0400A4F5 RID: 42229
		[OriginalName("FarmGold")]
		FarmGold,
		// Token: 0x0400A4F6 RID: 42230
		[OriginalName("NewLordGym")]
		NewLordGym,
		// Token: 0x0400A4F7 RID: 42231
		[OriginalName("RoleSkinTrialActivity")]
		RoleSkinTrialActivity,
		// Token: 0x0400A4F8 RID: 42232
		[OriginalName("RogueWeekly")]
		RogueWeekly,
		// Token: 0x0400A4F9 RID: 42233
		[OriginalName("FishingActivity")]
		FishingActivity,
		// Token: 0x0400A4FA RID: 42234
		[OriginalName("TeamParkOurActivity")]
		TeamParkOurActivity,
		// Token: 0x0400A4FB RID: 42235
		[OriginalName("SlashAndTowerLevelPlay")]
		SlashAndTowerLevelPlay,
		// Token: 0x0400A4FC RID: 42236
		[OriginalName("BabelTower")]
		BabelTower,
		// Token: 0x0400A4FD RID: 42237
		[OriginalName("Avignon")]
		Avignon,
		// Token: 0x0400A4FE RID: 42238
		[OriginalName("BetHorses")]
		BetHorses,
		// Token: 0x0400A4FF RID: 42239
		[OriginalName("Explore")]
		Explore,
		// Token: 0x0400A500 RID: 42240
		[OriginalName("Abyss")]
		Abyss,
		// Token: 0x0400A501 RID: 42241
		[OriginalName("RogueRes")]
		RogueRes,
		// Token: 0x0400A502 RID: 42242
		[OriginalName("H5CircumFluence")]
		H5CircumFluence,
		// Token: 0x0400A503 RID: 42243
		[OriginalName("DangoMonopoly")]
		DangoMonopoly,
		// Token: 0x0400A504 RID: 42244
		[OriginalName("CiacconaActivity")]
		CiacconaActivity,
		// Token: 0x0400A505 RID: 42245
		[OriginalName("ActivityLinkage")]
		ActivityLinkage,
		// Token: 0x0400A506 RID: 42246
		[OriginalName("RegressActivity")]
		RegressActivity,
		// Token: 0x0400A507 RID: 42247
		[OriginalName("ConsumptiveActivity")]
		ConsumptiveActivity,
		// Token: 0x0400A508 RID: 42248
		[OriginalName("PhantomBattle")]
		PhantomBattle,
		// Token: 0x0400A509 RID: 42249
		[OriginalName("NewbieCarnival")]
		NewbieCarnival,
		// Token: 0x0400A50A RID: 42250
		[OriginalName("MoraleActivity")]
		MoraleActivity,
		// Token: 0x0400A50B RID: 42251
		[OriginalName("FloroRanchActivity")]
		FloroRanchActivity,
		// Token: 0x0400A50C RID: 42252
		[OriginalName("LifePointChallenge")]
		LifePointChallenge,
		// Token: 0x0400A50D RID: 42253
		[OriginalName("TrapDefense")]
		TrapDefense,
		// Token: 0x0400A50E RID: 42254
		[OriginalName("JinzhouFlyActivity")]
		JinzhouFlyActivity,
		// Token: 0x0400A50F RID: 42255
		[OriginalName("FunPlay")]
		FunPlay,
		// Token: 0x0400A510 RID: 42256
		[OriginalName("MoonPhase")]
		MoonPhase,
		// Token: 0x0400A511 RID: 42257
		[OriginalName("LineCross")]
		LineCross,
		// Token: 0x0400A512 RID: 42258
		[OriginalName("HonamiStory")]
		HonamiStory,
		// Token: 0x0400A513 RID: 42259
		[OriginalName("Survivors")]
		Survivors,
		// Token: 0x0400A514 RID: 42260
		[OriginalName("PhotoFight")]
		PhotoFight,
		// Token: 0x0400A515 RID: 42261
		[OriginalName("WuWuKuji")]
		WuWuKuji,
		// Token: 0x0400A516 RID: 42262
		[OriginalName("FirstPersonParkour")]
		FirstPersonParkour,
		// Token: 0x0400A517 RID: 42263
		[OriginalName("PreHeatTaskActivity")]
		PreHeatTaskActivity,
		// Token: 0x0400A518 RID: 42264
		[OriginalName("InfrTheme")]
		InfrTheme,
		// Token: 0x0400A519 RID: 42265
		[OriginalName("AdvanceNoticeActivity")]
		AdvanceNoticeActivity,
		// Token: 0x0400A51A RID: 42266
		[OriginalName("PhantomBattleRecord")]
		PhantomBattleRecord,
		// Token: 0x0400A51B RID: 42267
		[OriginalName("CoopActivity")]
		CoopActivity,
		// Token: 0x0400A51C RID: 42268
		[OriginalName("PhantomBattleRecordGuide")]
		PhantomBattleRecordGuide,
		// Token: 0x0400A51D RID: 42269
		[OriginalName("ArtemisActivity")]
		ArtemisActivity,
		// Token: 0x0400A51E RID: 42270
		[OriginalName("MotorcycleIpLink")]
		MotorcycleIpLink,
		// Token: 0x0400A51F RID: 42271
		[OriginalName("SkinRewardActivity")]
		SkinRewardActivity,
		// Token: 0x0400A520 RID: 42272
		[OriginalName("RoadBookActivity")]
		RoadBookActivity,
		// Token: 0x0400A521 RID: 42273
		[OriginalName("NewTowerClimbing")]
		NewTowerClimbing,
		// Token: 0x0400A522 RID: 42274
		[OriginalName("MotorFight")]
		MotorFight,
		// Token: 0x0400A523 RID: 42275
		[OriginalName("Encircle")]
		Encircle,
		// Token: 0x0400A524 RID: 42276
		[OriginalName("NewPlayerSupportActivity")]
		NewPlayerSupportActivity,
		// Token: 0x0400A525 RID: 42277
		[OriginalName("SpringFestivalActivity")]
		SpringFestivalActivity,
		// Token: 0x0400A526 RID: 42278
		[OriginalName("MotorParkourActivity")]
		MotorParkourActivity,
		// Token: 0x0400A527 RID: 42279
		[OriginalName("TotalTopUp")]
		TotalTopUp,
		// Token: 0x0400A528 RID: 42280
		[OriginalName("H5View")]
		H5View,
		// Token: 0x0400A529 RID: 42281
		[OriginalName("MotorDevelop")]
		MotorDevelop,
		// Token: 0x0400A52A RID: 42282
		[OriginalName("FlagChallenge")]
		FlagChallenge,
		// Token: 0x0400A52B RID: 42283
		[OriginalName("Rhythm")]
		Rhythm,
		// Token: 0x0400A52C RID: 42284
		[OriginalName("FeiXue")]
		FeiXue = 89,
		// Token: 0x0400A52D RID: 42285
		[OriginalName("DropCatchActivity")]
		DropCatchActivity,
		// Token: 0x0400A52E RID: 42286
		[OriginalName("TetrisActivity")]
		TetrisActivity,
		// Token: 0x0400A52F RID: 42287
		[OriginalName("InfrThemeV2")]
		InfrThemeV2,
		// Token: 0x0400A530 RID: 42288
		[OriginalName("Kurotato")]
		Kurotato,
		// Token: 0x0400A531 RID: 42289
		[OriginalName("PinballActivity")]
		PinballActivity,
		// Token: 0x0400A532 RID: 42290
		[OriginalName("WuWuWeekSign")]
		WuWuWeekSign = 96,
		// Token: 0x0400A533 RID: 42291
		[OriginalName("AnniversaryTheme")]
		AnniversaryTheme,
		// Token: 0x0400A534 RID: 42292
		[OriginalName("BossPiling")]
		BossPiling,
		// Token: 0x0400A535 RID: 42293
		[OriginalName("GolemCrackActivity")]
		GolemCrackActivity,
		// Token: 0x0400A536 RID: 42294
		[OriginalName("EdgeRunnerActivity")]
		EdgeRunnerActivity,
		// Token: 0x0400A537 RID: 42295
		[OriginalName("MotorDecalActivity")]
		MotorDecalActivity,
		// Token: 0x0400A538 RID: 42296
		[OriginalName("MotorParkour")]
		MotorParkour,
		// Token: 0x0400A539 RID: 42297
		[OriginalName("LinkageCheckIn")]
		LinkageCheckIn,
		// Token: 0x0400A53A RID: 42298
		[OriginalName("RoleGiftActivity")]
		RoleGiftActivity,
		// Token: 0x0400A53B RID: 42299
		[OriginalName("RealmBetween")]
		RealmBetween,
		// Token: 0x0400A53C RID: 42300
		[OriginalName("SheriffActivity")]
		SheriffActivity,
		// Token: 0x0400A53D RID: 42301
		[OriginalName("ThroughTrainSummary")]
		ThroughTrainSummary,
		// Token: 0x0400A53E RID: 42302
		[OriginalName("NewPlayerSupportActivityV2")]
		NewPlayerSupportActivityV2,
		// Token: 0x0400A53F RID: 42303
		[OriginalName("NewbieAdventureV2")]
		NewbieAdventureV2,
		// Token: 0x0400A540 RID: 42304
		[OriginalName("NewbieCourseV2")]
		NewbieCourseV2,
		// Token: 0x0400A541 RID: 42305
		[OriginalName("NewbieMain")]
		NewbieMain,
		// Token: 0x0400A542 RID: 42306
		[OriginalName("RoverRogue")]
		RoverRogue,
		// Token: 0x0400A543 RID: 42307
		[OriginalName("DangoBrawl")]
		DangoBrawl,
		// Token: 0x0400A544 RID: 42308
		[OriginalName("QingXiaoPlayThePiano")]
		QingXiaoPlayThePiano,
		// Token: 0x0400A545 RID: 42309
		[OriginalName("PurePreviewActivity")]
		PurePreviewActivity,
		// Token: 0x0400A546 RID: 42310
		[OriginalName("MatchThreeActivity")]
		MatchThreeActivity,
		// Token: 0x0400A547 RID: 42311
		[OriginalName("GiantSystemActivity")]
		GiantSystemActivity = 118,
		// Token: 0x0400A548 RID: 42312
		[OriginalName("PureUIActivity")]
		PureUiactivity = 200
	}
}
