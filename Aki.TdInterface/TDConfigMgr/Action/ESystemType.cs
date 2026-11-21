using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200183C RID: 6204
	[EnumExtensions]
	public enum ESystemType
	{
		// Token: 0x0400524C RID: 21068
		Shop,
		// Token: 0x0400524D RID: 21069
		RegionQuest,
		// Token: 0x0400524E RID: 21070
		ContributionLevel,
		// Token: 0x0400524F RID: 21071
		InstanceEntrance,
		// Token: 0x04005250 RID: 21072
		MingSuTi,
		// Token: 0x04005251 RID: 21073
		InformationView,
		// Token: 0x04005252 RID: 21074
		DailyQuest,
		// Token: 0x04005253 RID: 21075
		Cook,
		// Token: 0x04005254 RID: 21076
		FixCook,
		// Token: 0x04005255 RID: 21077
		Synthetic,
		// Token: 0x04005256 RID: 21078
		Forging,
		// Token: 0x04005257 RID: 21079
		Expostulation,
		// Token: 0x04005258 RID: 21080
		RoleDescription,
		// Token: 0x04005259 RID: 21081
		TrialRoleDescription,
		// Token: 0x0400525A RID: 21082
		RogueAbilitySelect,
		// Token: 0x0400525B RID: 21083
		RogueShop,
		// Token: 0x0400525C RID: 21084
		RogueRandomEvent,
		// Token: 0x0400525D RID: 21085
		RogueActivityIntroduce,
		// Token: 0x0400525E RID: 21086
		RogueSettlement,
		// Token: 0x0400525F RID: 21087
		RogueTowerTrial,
		// Token: 0x04005260 RID: 21088
		GameSysOpen,
		// Token: 0x04005261 RID: 21089
		TurntableControl,
		// Token: 0x04005262 RID: 21090
		InstanceFailure,
		// Token: 0x04005263 RID: 21091
		FeedingPets,
		// Token: 0x04005264 RID: 21092
		SoundAreaPlayInfo,
		// Token: 0x04005265 RID: 21093
		LordChallenge,
		// Token: 0x04005266 RID: 21094
		ExploreLevelView,
		// Token: 0x04005267 RID: 21095
		ConfirmBox,
		// Token: 0x04005268 RID: 21096
		ConfirmBox2,
		// Token: 0x04005269 RID: 21097
		ActivityIntroduce,
		// Token: 0x0400526A RID: 21098
		ActivitySubInterface,
		// Token: 0x0400526B RID: 21099
		Photograph,
		// Token: 0x0400526C RID: 21100
		DigitalScreen,
		// Token: 0x0400526D RID: 21101
		ChasingMoonMain,
		// Token: 0x0400526E RID: 21102
		Gramophone,
		// Token: 0x0400526F RID: 21103
		DreamLink,
		// Token: 0x04005270 RID: 21104
		MowBuffDistribute,
		// Token: 0x04005271 RID: 21105
		ScratchTicket,
		// Token: 0x04005272 RID: 21106
		PreheatingCheckIn,
		// Token: 0x04005273 RID: 21107
		MowingTowerActivity,
		// Token: 0x04005274 RID: 21108
		SoaringChallenge,
		// Token: 0x04005275 RID: 21109
		MotorRaceChallenge,
		// Token: 0x04005276 RID: 21110
		MechaStuntTrackChallenge,
		// Token: 0x04005277 RID: 21111
		PhotoMemoryTopic,
		// Token: 0x04005278 RID: 21112
		LordGymEntrance,
		// Token: 0x04005279 RID: 21113
		RaidReportSettlement,
		// Token: 0x0400527A RID: 21114
		HideLordOpen,
		// Token: 0x0400527B RID: 21115
		FishingDock,
		// Token: 0x0400527C RID: 21116
		FishingCage,
		// Token: 0x0400527D RID: 21117
		FishingItemDelivery,
		// Token: 0x0400527E RID: 21118
		RogueTokenSelect,
		// Token: 0x0400527F RID: 21119
		SlashAndTower,
		// Token: 0x04005280 RID: 21120
		BossRushPlayInfo,
		// Token: 0x04005281 RID: 21121
		GravityFlipControl,
		// Token: 0x04005282 RID: 21122
		PermanentRogueAbilitySelect,
		// Token: 0x04005283 RID: 21123
		PermanentRogueShop,
		// Token: 0x04005284 RID: 21124
		PermanentRogueRandomEvent,
		// Token: 0x04005285 RID: 21125
		PermanentRogueActivityIntroduce,
		// Token: 0x04005286 RID: 21126
		PermanentRogueSettlement,
		// Token: 0x04005287 RID: 21127
		PermanentRogueTokenSelect,
		// Token: 0x04005288 RID: 21128
		CiacconaAvgSystemBoard,
		// Token: 0x04005289 RID: 21129
		CiacconaAvgChapterBoard,
		// Token: 0x0400528A RID: 21130
		DangoAbyssActivity,
		// Token: 0x0400528B RID: 21131
		PhantomBattleChallenge,
		// Token: 0x0400528C RID: 21132
		CoBathing,
		// Token: 0x0400528D RID: 21133
		PlotReview,
		// Token: 0x0400528E RID: 21134
		PlotReviewJumpTips,
		// Token: 0x0400528F RID: 21135
		MoraleSystem,
		// Token: 0x04005290 RID: 21136
		LifePointChallenge,
		// Token: 0x04005291 RID: 21137
		GreatSwordChallenge,
		// Token: 0x04005292 RID: 21138
		TrapDefenseMapChange,
		// Token: 0x04005293 RID: 21139
		HonamiStorySafeBag,
		// Token: 0x04005294 RID: 21140
		HonamiStoryFightPreparation,
		// Token: 0x04005295 RID: 21141
		HonamiStoryMascot,
		// Token: 0x04005296 RID: 21142
		HonamiStoryTalentTree,
		// Token: 0x04005297 RID: 21143
		HonamiStoryResourceStation,
		// Token: 0x04005298 RID: 21144
		HonamiStoryChooseLevel,
		// Token: 0x04005299 RID: 21145
		HonamiStoryWareHouse,
		// Token: 0x0400529A RID: 21146
		FindBug,
		// Token: 0x0400529B RID: 21147
		InfrastructureItemDelivery,
		// Token: 0x0400529C RID: 21148
		SurvivorsGameplay,
		// Token: 0x0400529D RID: 21149
		PhotographFightActivity,
		// Token: 0x0400529E RID: 21150
		TransitionPopup,
		// Token: 0x0400529F RID: 21151
		InfrActivityFinishInfrastructure,
		// Token: 0x040052A0 RID: 21152
		Enrollment,
		// Token: 0x040052A1 RID: 21153
		Motorcycle,
		// Token: 0x040052A2 RID: 21154
		MotorcycleDiy,
		// Token: 0x040052A3 RID: 21155
		Map,
		// Token: 0x040052A4 RID: 21156
		AreaTerminalGamePlay,
		// Token: 0x040052A5 RID: 21157
		GuessCardGamePlayView,
		// Token: 0x040052A6 RID: 21158
		GuessJokerSelectRoleView,
		// Token: 0x040052A7 RID: 21159
		ChangePhantomExhibitView,
		// Token: 0x040052A8 RID: 21160
		ChangeWeaponExhibitView,
		// Token: 0x040052A9 RID: 21161
		DrinksMixDrinksView,
		// Token: 0x040052AA RID: 21162
		DrinksSelectRoleView,
		// Token: 0x040052AB RID: 21163
		FurnitureDiyShop,
		// Token: 0x040052AC RID: 21164
		TakePhoto,
		// Token: 0x040052AD RID: 21165
		SpringFestivalBrochure,
		// Token: 0x040052AE RID: 21166
		SpringFestivalPictureAlbum,
		// Token: 0x040052AF RID: 21167
		PictureCaption,
		// Token: 0x040052B0 RID: 21168
		Coop,
		// Token: 0x040052B1 RID: 21169
		RhythmSpaceshipInMainStory,
		// Token: 0x040052B2 RID: 21170
		DropCatchInMainStory,
		// Token: 0x040052B3 RID: 21171
		TetrisBoardGameEndlessLevel,
		// Token: 0x040052B4 RID: 21172
		VillageInfrMainView,
		// Token: 0x040052B5 RID: 21173
		VillageInfrDelivery,
		// Token: 0x040052B6 RID: 21174
		VillageInfrFinishConstruction,
		// Token: 0x040052B7 RID: 21175
		InteractiveComic,
		// Token: 0x040052B8 RID: 21176
		CyberpunkCollaborationVehicleShare,
		// Token: 0x040052B9 RID: 21177
		CyberpunkCollaborationVehicleShareInProgress,
		// Token: 0x040052BA RID: 21178
		QuestBranch,
		// Token: 0x040052BB RID: 21179
		QuestBranchTips,
		// Token: 0x040052BC RID: 21180
		SheriffCriminalIdentityConfirmed,
		// Token: 0x040052BD RID: 21181
		SheriffAnomaly,
		// Token: 0x040052BE RID: 21182
		SheriffMainStoryError,
		// Token: 0x040052BF RID: 21183
		DollGrabDelivery,
		// Token: 0x040052C0 RID: 21184
		WriteLetter,
		// Token: 0x040052C1 RID: 21185
		MechascoutMindSpaceDungeon,
		// Token: 0x040052C2 RID: 21186
		RoverRogueTrophy,
		// Token: 0x040052C3 RID: 21187
		FoxFailureTips,
		// Token: 0x040052C4 RID: 21188
		GiantDelivery,
		// Token: 0x040052C5 RID: 21189
		DangoBrawlVictorySettlement,
		// Token: 0x040052C6 RID: 21190
		DangoBrawlFailureSettlement,
		// Token: 0x040052C7 RID: 21191
		InformationViewPopup,
		// Token: 0x040052C8 RID: 21192
		DeliverItemProbeCollectibles,
		// Token: 0x040052C9 RID: 21193
		HandBookPage,
		// Token: 0x040052CA RID: 21194
		HandBookTips,
		// Token: 0x040052CB RID: 21195
		DiceNpcBattlePreparation,
		// Token: 0x040052CC RID: 21196
		DiceBattle
	}
}
