using System;
using CSharpScript.Core.Common;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016C2 RID: 5826
	[EnumExtensions]
	public enum ESystemType
	{
		// Token: 0x04004E2C RID: 20012
		Shop,
		// Token: 0x04004E2D RID: 20013
		RegionQuest,
		// Token: 0x04004E2E RID: 20014
		ContributionLevel,
		// Token: 0x04004E2F RID: 20015
		InstanceEntrance,
		// Token: 0x04004E30 RID: 20016
		MingSuTi,
		// Token: 0x04004E31 RID: 20017
		InformationView,
		// Token: 0x04004E32 RID: 20018
		DailyQuest,
		// Token: 0x04004E33 RID: 20019
		Cook,
		// Token: 0x04004E34 RID: 20020
		FixCook,
		// Token: 0x04004E35 RID: 20021
		Synthetic,
		// Token: 0x04004E36 RID: 20022
		Forging,
		// Token: 0x04004E37 RID: 20023
		Expostulation,
		// Token: 0x04004E38 RID: 20024
		RoleDescription,
		// Token: 0x04004E39 RID: 20025
		TrialRoleDescription,
		// Token: 0x04004E3A RID: 20026
		RogueAbilitySelect,
		// Token: 0x04004E3B RID: 20027
		RogueShop,
		// Token: 0x04004E3C RID: 20028
		RogueRandomEvent,
		// Token: 0x04004E3D RID: 20029
		RogueActivityIntroduce,
		// Token: 0x04004E3E RID: 20030
		RogueSettlement,
		// Token: 0x04004E3F RID: 20031
		RogueTowerTrial,
		// Token: 0x04004E40 RID: 20032
		GameSysOpen,
		// Token: 0x04004E41 RID: 20033
		TurntableControl,
		// Token: 0x04004E42 RID: 20034
		InstanceFailure,
		// Token: 0x04004E43 RID: 20035
		FeedingPets,
		// Token: 0x04004E44 RID: 20036
		SoundAreaPlayInfo,
		// Token: 0x04004E45 RID: 20037
		LordChallenge,
		// Token: 0x04004E46 RID: 20038
		ExploreLevelView,
		// Token: 0x04004E47 RID: 20039
		ConfirmBox,
		// Token: 0x04004E48 RID: 20040
		ConfirmBox2,
		// Token: 0x04004E49 RID: 20041
		ActivityIntroduce,
		// Token: 0x04004E4A RID: 20042
		ActivitySubInterface,
		// Token: 0x04004E4B RID: 20043
		Photograph,
		// Token: 0x04004E4C RID: 20044
		DigitalScreen,
		// Token: 0x04004E4D RID: 20045
		ChasingMoonMain,
		// Token: 0x04004E4E RID: 20046
		Gramophone,
		// Token: 0x04004E4F RID: 20047
		DreamLink,
		// Token: 0x04004E50 RID: 20048
		MowBuffDistribute,
		// Token: 0x04004E51 RID: 20049
		ScratchTicket,
		// Token: 0x04004E52 RID: 20050
		PreheatingCheckIn,
		// Token: 0x04004E53 RID: 20051
		MowingTowerActivity,
		// Token: 0x04004E54 RID: 20052
		SoaringChallenge,
		// Token: 0x04004E55 RID: 20053
		MotorRaceChallenge,
		// Token: 0x04004E56 RID: 20054
		PhotoMemoryTopic,
		// Token: 0x04004E57 RID: 20055
		LordGymEntrance,
		// Token: 0x04004E58 RID: 20056
		RaidReportSettlement,
		// Token: 0x04004E59 RID: 20057
		HideLordOpen,
		// Token: 0x04004E5A RID: 20058
		FishingDock,
		// Token: 0x04004E5B RID: 20059
		FishingCage,
		// Token: 0x04004E5C RID: 20060
		FishingItemDelivery,
		// Token: 0x04004E5D RID: 20061
		RogueTokenSelect,
		// Token: 0x04004E5E RID: 20062
		SlashAndTower,
		// Token: 0x04004E5F RID: 20063
		BossRushPlayInfo,
		// Token: 0x04004E60 RID: 20064
		GravityFlipControl,
		// Token: 0x04004E61 RID: 20065
		PermanentRogueAbilitySelect,
		// Token: 0x04004E62 RID: 20066
		PermanentRogueShop,
		// Token: 0x04004E63 RID: 20067
		PermanentRogueRandomEvent,
		// Token: 0x04004E64 RID: 20068
		PermanentRogueActivityIntroduce,
		// Token: 0x04004E65 RID: 20069
		PermanentRogueSettlement,
		// Token: 0x04004E66 RID: 20070
		PermanentRogueTokenSelect,
		// Token: 0x04004E67 RID: 20071
		CiacconaAvgSystemBoard,
		// Token: 0x04004E68 RID: 20072
		CiacconaAvgChapterBoard,
		// Token: 0x04004E69 RID: 20073
		DangoAbyssActivity,
		// Token: 0x04004E6A RID: 20074
		PhantomBattleChallenge,
		// Token: 0x04004E6B RID: 20075
		CoBathing,
		// Token: 0x04004E6C RID: 20076
		PlotReview,
		// Token: 0x04004E6D RID: 20077
		PlotReviewJumpTips,
		// Token: 0x04004E6E RID: 20078
		MoraleSystem,
		// Token: 0x04004E6F RID: 20079
		LifePointChallenge,
		// Token: 0x04004E70 RID: 20080
		GreatSwordChallenge,
		// Token: 0x04004E71 RID: 20081
		TrapDefenseMapChange,
		// Token: 0x04004E72 RID: 20082
		HonamiStorySafeBag,
		// Token: 0x04004E73 RID: 20083
		HonamiStoryFightPreparation,
		// Token: 0x04004E74 RID: 20084
		HonamiStoryMascot,
		// Token: 0x04004E75 RID: 20085
		HonamiStoryTalentTree,
		// Token: 0x04004E76 RID: 20086
		HonamiStoryResourceStation,
		// Token: 0x04004E77 RID: 20087
		HonamiStoryChooseLevel,
		// Token: 0x04004E78 RID: 20088
		HonamiStoryWareHouse,
		// Token: 0x04004E79 RID: 20089
		FindBug,
		// Token: 0x04004E7A RID: 20090
		InfrastructureItemDelivery,
		// Token: 0x04004E7B RID: 20091
		SurvivorsGameplay,
		// Token: 0x04004E7C RID: 20092
		PhotographFightActivity,
		// Token: 0x04004E7D RID: 20093
		TransitionPopup,
		// Token: 0x04004E7E RID: 20094
		InfrActivityFinishInfrastructure,
		// Token: 0x04004E7F RID: 20095
		Enrollment,
		// Token: 0x04004E80 RID: 20096
		Motorcycle,
		// Token: 0x04004E81 RID: 20097
		MotorcycleDiy,
		// Token: 0x04004E82 RID: 20098
		Map,
		// Token: 0x04004E83 RID: 20099
		AreaTerminalGamePlay,
		// Token: 0x04004E84 RID: 20100
		GuessCardGamePlayView,
		// Token: 0x04004E85 RID: 20101
		GuessJokerSelectRoleView,
		// Token: 0x04004E86 RID: 20102
		ChangePhantomExhibitView,
		// Token: 0x04004E87 RID: 20103
		ChangeWeaponExhibitView,
		// Token: 0x04004E88 RID: 20104
		DrinksMixDrinksView,
		// Token: 0x04004E89 RID: 20105
		DrinksSelectRoleView,
		// Token: 0x04004E8A RID: 20106
		FurnitureDiyShop,
		// Token: 0x04004E8B RID: 20107
		TakePhoto,
		// Token: 0x04004E8C RID: 20108
		SpringFestivalBrochure,
		// Token: 0x04004E8D RID: 20109
		SpringFestivalPictureAlbum,
		// Token: 0x04004E8E RID: 20110
		PictureCaption,
		// Token: 0x04004E8F RID: 20111
		Coop,
		// Token: 0x04004E90 RID: 20112
		RhythmSpaceshipInMainStory,
		// Token: 0x04004E91 RID: 20113
		DropCatchInMainStory,
		// Token: 0x04004E92 RID: 20114
		TetrisBoardGameEndlessLevel,
		// Token: 0x04004E93 RID: 20115
		VillageInfrMainView,
		// Token: 0x04004E94 RID: 20116
		VillageInfrDelivery,
		// Token: 0x04004E95 RID: 20117
		VillageInfrFinishConstruction,
		// Token: 0x04004E96 RID: 20118
		InteractiveComic,
		// Token: 0x04004E97 RID: 20119
		CyberpunkCollaborationVehicleShare,
		// Token: 0x04004E98 RID: 20120
		CyberpunkCollaborationVehicleShareInProgress,
		// Token: 0x04004E99 RID: 20121
		QuestBranch,
		// Token: 0x04004E9A RID: 20122
		QuestBranchTips,
		// Token: 0x04004E9B RID: 20123
		SheriffCriminalIdentityConfirmed,
		// Token: 0x04004E9C RID: 20124
		SheriffAnomaly,
		// Token: 0x04004E9D RID: 20125
		SheriffMainStoryError,
		// Token: 0x04004E9E RID: 20126
		DollGrabDelivery,
		// Token: 0x04004E9F RID: 20127
		WriteLetter,
		// Token: 0x04004EA0 RID: 20128
		MechascoutMindSpaceDungeon,
		// Token: 0x04004EA1 RID: 20129
		RoverRogueTrophy,
		// Token: 0x04004EA2 RID: 20130
		FoxFailureTips,
		// Token: 0x04004EA3 RID: 20131
		GiantDelivery,
		// Token: 0x04004EA4 RID: 20132
		DangoBrawlVictorySettlement,
		// Token: 0x04004EA5 RID: 20133
		DangoBrawlFailureSettlement,
		// Token: 0x04004EA6 RID: 20134
		InformationViewPopup,
		// Token: 0x04004EA7 RID: 20135
		DeliverItemProbeCollectibles
	}
}
