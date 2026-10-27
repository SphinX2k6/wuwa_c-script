using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006020 RID: 24608
	public enum ESystemType : byte
	{
		// Token: 0x04010079 RID: 65657
		Shop,
		// Token: 0x0401007A RID: 65658
		RegionQuest,
		// Token: 0x0401007B RID: 65659
		ContributionLevel,
		// Token: 0x0401007C RID: 65660
		InstanceEntrance,
		// Token: 0x0401007D RID: 65661
		MingSuTi,
		// Token: 0x0401007E RID: 65662
		InformationView,
		// Token: 0x0401007F RID: 65663
		DailyQuest,
		// Token: 0x04010080 RID: 65664
		Cook,
		// Token: 0x04010081 RID: 65665
		FixCook,
		// Token: 0x04010082 RID: 65666
		Synthetic,
		// Token: 0x04010083 RID: 65667
		Forging,
		// Token: 0x04010084 RID: 65668
		Expostulation,
		// Token: 0x04010085 RID: 65669
		RoleDescription,
		// Token: 0x04010086 RID: 65670
		TrialRoleDescription,
		// Token: 0x04010087 RID: 65671
		RogueAbilitySelect,
		// Token: 0x04010088 RID: 65672
		RogueShop,
		// Token: 0x04010089 RID: 65673
		RogueRandomEvent,
		// Token: 0x0401008A RID: 65674
		RogueActivityIntroduce,
		// Token: 0x0401008B RID: 65675
		RogueSettlement,
		// Token: 0x0401008C RID: 65676
		RogueTowerTrial,
		// Token: 0x0401008D RID: 65677
		GameSysOpen,
		// Token: 0x0401008E RID: 65678
		TurntableControl,
		// Token: 0x0401008F RID: 65679
		InstanceFailure,
		// Token: 0x04010090 RID: 65680
		FeedingPets,
		// Token: 0x04010091 RID: 65681
		SoundAreaPlayInfo,
		// Token: 0x04010092 RID: 65682
		LordChallenge,
		// Token: 0x04010093 RID: 65683
		ExploreLevelView,
		// Token: 0x04010094 RID: 65684
		ConfirmBox,
		// Token: 0x04010095 RID: 65685
		ConfirmBox2,
		// Token: 0x04010096 RID: 65686
		ActivityIntroduce,
		// Token: 0x04010097 RID: 65687
		ActivitySubInterface,
		// Token: 0x04010098 RID: 65688
		Photograph,
		// Token: 0x04010099 RID: 65689
		DigitalScreen,
		// Token: 0x0401009A RID: 65690
		ChasingMoonMain,
		// Token: 0x0401009B RID: 65691
		Gramophone,
		// Token: 0x0401009C RID: 65692
		DreamLink,
		// Token: 0x0401009D RID: 65693
		MowBuffDistribute,
		// Token: 0x0401009E RID: 65694
		ScratchTicket,
		// Token: 0x0401009F RID: 65695
		PreheatingCheckIn,
		// Token: 0x040100A0 RID: 65696
		MowingTowerActivity,
		// Token: 0x040100A1 RID: 65697
		SoaringChallenge,
		// Token: 0x040100A2 RID: 65698
		MotorRaceChallenge,
		// Token: 0x040100A3 RID: 65699
		PhotoMemoryTopic,
		// Token: 0x040100A4 RID: 65700
		LordGymEntrance,
		// Token: 0x040100A5 RID: 65701
		RaidReportSettlement,
		// Token: 0x040100A6 RID: 65702
		HideLordOpen,
		// Token: 0x040100A7 RID: 65703
		FishingDock,
		// Token: 0x040100A8 RID: 65704
		FishingCage,
		// Token: 0x040100A9 RID: 65705
		FishingItemDelivery,
		// Token: 0x040100AA RID: 65706
		RogueTokenSelect,
		// Token: 0x040100AB RID: 65707
		SlashAndTower,
		// Token: 0x040100AC RID: 65708
		BossRushPlayInfo,
		// Token: 0x040100AD RID: 65709
		GravityFlipControl,
		// Token: 0x040100AE RID: 65710
		PermanentRogueAbilitySelect,
		// Token: 0x040100AF RID: 65711
		PermanentRogueShop,
		// Token: 0x040100B0 RID: 65712
		PermanentRogueRandomEvent,
		// Token: 0x040100B1 RID: 65713
		PermanentRogueActivityIntroduce,
		// Token: 0x040100B2 RID: 65714
		PermanentRogueSettlement,
		// Token: 0x040100B3 RID: 65715
		PermanentRogueTokenSelect,
		// Token: 0x040100B4 RID: 65716
		CiacconaAvgSystemBoard,
		// Token: 0x040100B5 RID: 65717
		CiacconaAvgChapterBoard,
		// Token: 0x040100B6 RID: 65718
		DangoAbyssActivity,
		// Token: 0x040100B7 RID: 65719
		PhantomBattleChallenge,
		// Token: 0x040100B8 RID: 65720
		CoBathing,
		// Token: 0x040100B9 RID: 65721
		PlotReview,
		// Token: 0x040100BA RID: 65722
		PlotReviewJumpTips,
		// Token: 0x040100BB RID: 65723
		MoraleSystem,
		// Token: 0x040100BC RID: 65724
		LifePointChallenge,
		// Token: 0x040100BD RID: 65725
		GreatSwordChallenge,
		// Token: 0x040100BE RID: 65726
		TrapDefenseMapChange,
		// Token: 0x040100BF RID: 65727
		HonamiStorySafeBag,
		// Token: 0x040100C0 RID: 65728
		HonamiStoryFightPreparation,
		// Token: 0x040100C1 RID: 65729
		HonamiStoryMascot,
		// Token: 0x040100C2 RID: 65730
		HonamiStoryTalentTree,
		// Token: 0x040100C3 RID: 65731
		HonamiStoryResourceStation,
		// Token: 0x040100C4 RID: 65732
		HonamiStoryChooseLevel,
		// Token: 0x040100C5 RID: 65733
		HonamiStoryWareHouse,
		// Token: 0x040100C6 RID: 65734
		FindBug,
		// Token: 0x040100C7 RID: 65735
		InfrastructureItemDelivery,
		// Token: 0x040100C8 RID: 65736
		SurvivorsGameplay,
		// Token: 0x040100C9 RID: 65737
		PhotographFightActivity,
		// Token: 0x040100CA RID: 65738
		TransitionPopup,
		// Token: 0x040100CB RID: 65739
		InfrActivityFinishInfrastructure,
		// Token: 0x040100CC RID: 65740
		Enrollment,
		// Token: 0x040100CD RID: 65741
		Motorcycle,
		// Token: 0x040100CE RID: 65742
		MotorcycleDiy,
		// Token: 0x040100CF RID: 65743
		Map,
		// Token: 0x040100D0 RID: 65744
		AreaTerminalGamePlay,
		// Token: 0x040100D1 RID: 65745
		GuessCardGamePlayView,
		// Token: 0x040100D2 RID: 65746
		GuessJokerSelectRoleView,
		// Token: 0x040100D3 RID: 65747
		ChangePhantomExhibitView,
		// Token: 0x040100D4 RID: 65748
		ChangeWeaponExhibitView,
		// Token: 0x040100D5 RID: 65749
		DrinksMixDrinksView,
		// Token: 0x040100D6 RID: 65750
		DrinksSelectRoleView,
		// Token: 0x040100D7 RID: 65751
		FurnitureDiyShop,
		// Token: 0x040100D8 RID: 65752
		TakePhoto,
		// Token: 0x040100D9 RID: 65753
		SpringFestivalBrochure,
		// Token: 0x040100DA RID: 65754
		SpringFestivalPictureAlbum,
		// Token: 0x040100DB RID: 65755
		PictureCaption,
		// Token: 0x040100DC RID: 65756
		Coop,
		// Token: 0x040100DD RID: 65757
		RhythmSpaceshipInMainStory,
		// Token: 0x040100DE RID: 65758
		DropCatchInMainStory,
		// Token: 0x040100DF RID: 65759
		TetrisBoardGameEndlessLevel,
		// Token: 0x040100E0 RID: 65760
		VillageInfrMainView,
		// Token: 0x040100E1 RID: 65761
		VillageInfrDelivery,
		// Token: 0x040100E2 RID: 65762
		VillageInfrFinishConstruction,
		// Token: 0x040100E3 RID: 65763
		InteractiveComic,
		// Token: 0x040100E4 RID: 65764
		CyberpunkCollaborationVehicleShare,
		// Token: 0x040100E5 RID: 65765
		CyberpunkCollaborationVehicleShareInProgress,
		// Token: 0x040100E6 RID: 65766
		QuestBranch,
		// Token: 0x040100E7 RID: 65767
		QuestBranchTips,
		// Token: 0x040100E8 RID: 65768
		SheriffCriminalIdentityConfirmed,
		// Token: 0x040100E9 RID: 65769
		SheriffAnomaly,
		// Token: 0x040100EA RID: 65770
		SheriffMainStoryError,
		// Token: 0x040100EB RID: 65771
		DollGrabDelivery,
		// Token: 0x040100EC RID: 65772
		WriteLetter,
		// Token: 0x040100ED RID: 65773
		MechascoutMindSpaceDungeon,
		// Token: 0x040100EE RID: 65774
		RoverRogueTrophy,
		// Token: 0x040100EF RID: 65775
		FoxFailureTips,
		// Token: 0x040100F0 RID: 65776
		GiantDelivery,
		// Token: 0x040100F1 RID: 65777
		DangoBrawlVictorySettlement,
		// Token: 0x040100F2 RID: 65778
		DangoBrawlFailureSettlement,
		// Token: 0x040100F3 RID: 65779
		InformationViewPopup,
		// Token: 0x040100F4 RID: 65780
		DeliverItemProbeCollectibles
	}
}
