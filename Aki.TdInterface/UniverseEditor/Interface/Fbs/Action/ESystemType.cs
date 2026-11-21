using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200667F RID: 26239
	public enum ESystemType : byte
	{
		// Token: 0x04010E5F RID: 69215
		Shop,
		// Token: 0x04010E60 RID: 69216
		RegionQuest,
		// Token: 0x04010E61 RID: 69217
		ContributionLevel,
		// Token: 0x04010E62 RID: 69218
		InstanceEntrance,
		// Token: 0x04010E63 RID: 69219
		MingSuTi,
		// Token: 0x04010E64 RID: 69220
		InformationView,
		// Token: 0x04010E65 RID: 69221
		DailyQuest,
		// Token: 0x04010E66 RID: 69222
		Cook,
		// Token: 0x04010E67 RID: 69223
		FixCook,
		// Token: 0x04010E68 RID: 69224
		Synthetic,
		// Token: 0x04010E69 RID: 69225
		Forging,
		// Token: 0x04010E6A RID: 69226
		Expostulation,
		// Token: 0x04010E6B RID: 69227
		RoleDescription,
		// Token: 0x04010E6C RID: 69228
		TrialRoleDescription,
		// Token: 0x04010E6D RID: 69229
		RogueAbilitySelect,
		// Token: 0x04010E6E RID: 69230
		RogueShop,
		// Token: 0x04010E6F RID: 69231
		RogueRandomEvent,
		// Token: 0x04010E70 RID: 69232
		RogueActivityIntroduce,
		// Token: 0x04010E71 RID: 69233
		RogueSettlement,
		// Token: 0x04010E72 RID: 69234
		RogueTowerTrial,
		// Token: 0x04010E73 RID: 69235
		GameSysOpen,
		// Token: 0x04010E74 RID: 69236
		TurntableControl,
		// Token: 0x04010E75 RID: 69237
		InstanceFailure,
		// Token: 0x04010E76 RID: 69238
		FeedingPets,
		// Token: 0x04010E77 RID: 69239
		SoundAreaPlayInfo,
		// Token: 0x04010E78 RID: 69240
		LordChallenge,
		// Token: 0x04010E79 RID: 69241
		ExploreLevelView,
		// Token: 0x04010E7A RID: 69242
		ConfirmBox,
		// Token: 0x04010E7B RID: 69243
		ConfirmBox2,
		// Token: 0x04010E7C RID: 69244
		ActivityIntroduce,
		// Token: 0x04010E7D RID: 69245
		ActivitySubInterface,
		// Token: 0x04010E7E RID: 69246
		Photograph,
		// Token: 0x04010E7F RID: 69247
		DigitalScreen,
		// Token: 0x04010E80 RID: 69248
		ChasingMoonMain,
		// Token: 0x04010E81 RID: 69249
		Gramophone,
		// Token: 0x04010E82 RID: 69250
		DreamLink,
		// Token: 0x04010E83 RID: 69251
		MowBuffDistribute,
		// Token: 0x04010E84 RID: 69252
		ScratchTicket,
		// Token: 0x04010E85 RID: 69253
		PreheatingCheckIn,
		// Token: 0x04010E86 RID: 69254
		MowingTowerActivity,
		// Token: 0x04010E87 RID: 69255
		SoaringChallenge,
		// Token: 0x04010E88 RID: 69256
		MotorRaceChallenge,
		// Token: 0x04010E89 RID: 69257
		MechaStuntTrackChallenge,
		// Token: 0x04010E8A RID: 69258
		PhotoMemoryTopic,
		// Token: 0x04010E8B RID: 69259
		LordGymEntrance,
		// Token: 0x04010E8C RID: 69260
		RaidReportSettlement,
		// Token: 0x04010E8D RID: 69261
		HideLordOpen,
		// Token: 0x04010E8E RID: 69262
		FishingDock,
		// Token: 0x04010E8F RID: 69263
		FishingCage,
		// Token: 0x04010E90 RID: 69264
		FishingItemDelivery,
		// Token: 0x04010E91 RID: 69265
		RogueTokenSelect,
		// Token: 0x04010E92 RID: 69266
		SlashAndTower,
		// Token: 0x04010E93 RID: 69267
		BossRushPlayInfo,
		// Token: 0x04010E94 RID: 69268
		GravityFlipControl,
		// Token: 0x04010E95 RID: 69269
		PermanentRogueAbilitySelect,
		// Token: 0x04010E96 RID: 69270
		PermanentRogueShop,
		// Token: 0x04010E97 RID: 69271
		PermanentRogueRandomEvent,
		// Token: 0x04010E98 RID: 69272
		PermanentRogueActivityIntroduce,
		// Token: 0x04010E99 RID: 69273
		PermanentRogueSettlement,
		// Token: 0x04010E9A RID: 69274
		PermanentRogueTokenSelect,
		// Token: 0x04010E9B RID: 69275
		CiacconaAvgSystemBoard,
		// Token: 0x04010E9C RID: 69276
		CiacconaAvgChapterBoard,
		// Token: 0x04010E9D RID: 69277
		DangoAbyssActivity,
		// Token: 0x04010E9E RID: 69278
		PhantomBattleChallenge,
		// Token: 0x04010E9F RID: 69279
		CoBathing,
		// Token: 0x04010EA0 RID: 69280
		PlotReview,
		// Token: 0x04010EA1 RID: 69281
		PlotReviewJumpTips,
		// Token: 0x04010EA2 RID: 69282
		MoraleSystem,
		// Token: 0x04010EA3 RID: 69283
		LifePointChallenge,
		// Token: 0x04010EA4 RID: 69284
		GreatSwordChallenge,
		// Token: 0x04010EA5 RID: 69285
		TrapDefenseMapChange,
		// Token: 0x04010EA6 RID: 69286
		HonamiStorySafeBag,
		// Token: 0x04010EA7 RID: 69287
		HonamiStoryFightPreparation,
		// Token: 0x04010EA8 RID: 69288
		HonamiStoryMascot,
		// Token: 0x04010EA9 RID: 69289
		HonamiStoryTalentTree,
		// Token: 0x04010EAA RID: 69290
		HonamiStoryResourceStation,
		// Token: 0x04010EAB RID: 69291
		HonamiStoryChooseLevel,
		// Token: 0x04010EAC RID: 69292
		HonamiStoryWareHouse,
		// Token: 0x04010EAD RID: 69293
		FindBug,
		// Token: 0x04010EAE RID: 69294
		InfrastructureItemDelivery,
		// Token: 0x04010EAF RID: 69295
		SurvivorsGameplay,
		// Token: 0x04010EB0 RID: 69296
		PhotographFightActivity,
		// Token: 0x04010EB1 RID: 69297
		TransitionPopup,
		// Token: 0x04010EB2 RID: 69298
		InfrActivityFinishInfrastructure,
		// Token: 0x04010EB3 RID: 69299
		Enrollment,
		// Token: 0x04010EB4 RID: 69300
		Motorcycle,
		// Token: 0x04010EB5 RID: 69301
		MotorcycleDiy,
		// Token: 0x04010EB6 RID: 69302
		Map,
		// Token: 0x04010EB7 RID: 69303
		AreaTerminalGamePlay,
		// Token: 0x04010EB8 RID: 69304
		GuessCardGamePlayView,
		// Token: 0x04010EB9 RID: 69305
		GuessJokerSelectRoleView,
		// Token: 0x04010EBA RID: 69306
		ChangePhantomExhibitView,
		// Token: 0x04010EBB RID: 69307
		ChangeWeaponExhibitView,
		// Token: 0x04010EBC RID: 69308
		DrinksMixDrinksView,
		// Token: 0x04010EBD RID: 69309
		DrinksSelectRoleView,
		// Token: 0x04010EBE RID: 69310
		FurnitureDiyShop,
		// Token: 0x04010EBF RID: 69311
		TakePhoto,
		// Token: 0x04010EC0 RID: 69312
		SpringFestivalBrochure,
		// Token: 0x04010EC1 RID: 69313
		SpringFestivalPictureAlbum,
		// Token: 0x04010EC2 RID: 69314
		PictureCaption,
		// Token: 0x04010EC3 RID: 69315
		Coop,
		// Token: 0x04010EC4 RID: 69316
		RhythmSpaceshipInMainStory,
		// Token: 0x04010EC5 RID: 69317
		DropCatchInMainStory,
		// Token: 0x04010EC6 RID: 69318
		TetrisBoardGameEndlessLevel,
		// Token: 0x04010EC7 RID: 69319
		VillageInfrMainView,
		// Token: 0x04010EC8 RID: 69320
		VillageInfrDelivery,
		// Token: 0x04010EC9 RID: 69321
		VillageInfrFinishConstruction,
		// Token: 0x04010ECA RID: 69322
		InteractiveComic,
		// Token: 0x04010ECB RID: 69323
		CyberpunkCollaborationVehicleShare,
		// Token: 0x04010ECC RID: 69324
		CyberpunkCollaborationVehicleShareInProgress,
		// Token: 0x04010ECD RID: 69325
		QuestBranch,
		// Token: 0x04010ECE RID: 69326
		QuestBranchTips,
		// Token: 0x04010ECF RID: 69327
		SheriffCriminalIdentityConfirmed,
		// Token: 0x04010ED0 RID: 69328
		SheriffAnomaly,
		// Token: 0x04010ED1 RID: 69329
		SheriffMainStoryError,
		// Token: 0x04010ED2 RID: 69330
		DollGrabDelivery,
		// Token: 0x04010ED3 RID: 69331
		WriteLetter,
		// Token: 0x04010ED4 RID: 69332
		MechascoutMindSpaceDungeon,
		// Token: 0x04010ED5 RID: 69333
		RoverRogueTrophy,
		// Token: 0x04010ED6 RID: 69334
		FoxFailureTips,
		// Token: 0x04010ED7 RID: 69335
		GiantDelivery,
		// Token: 0x04010ED8 RID: 69336
		DangoBrawlVictorySettlement,
		// Token: 0x04010ED9 RID: 69337
		DangoBrawlFailureSettlement,
		// Token: 0x04010EDA RID: 69338
		InformationViewPopup,
		// Token: 0x04010EDB RID: 69339
		DeliverItemProbeCollectibles,
		// Token: 0x04010EDC RID: 69340
		HandBookPage,
		// Token: 0x04010EDD RID: 69341
		HandBookTips,
		// Token: 0x04010EDE RID: 69342
		DiceNpcBattlePreparation,
		// Token: 0x04010EDF RID: 69343
		DiceBattle
	}
}
