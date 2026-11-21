using System;

// Token: 0x02001106 RID: 4358
public enum EFunctionType
{
	// Token: 0x04006438 RID: 25656
	Role = 10001,
	// Token: 0x04006439 RID: 25657
	Bag,
	// Token: 0x0400643A RID: 25658
	Calabash,
	// Token: 0x0400643B RID: 25659
	Quest,
	// Token: 0x0400643C RID: 25660
	CommonGamePlay,
	// Token: 0x0400643D RID: 25661
	TimeLimitGamePlay,
	// Token: 0x0400643E RID: 25662
	FormatTeam,
	// Token: 0x0400643F RID: 25663
	MakeTeam,
	// Token: 0x04006440 RID: 25664
	Gacha,
	// Token: 0x04006441 RID: 25665
	Shop,
	// Token: 0x04006442 RID: 25666
	Friend,
	// Token: 0x04006443 RID: 25667
	Guild,
	// Token: 0x04006444 RID: 25668
	Achievement,
	// Token: 0x04006445 RID: 25669
	HandBook,
	// Token: 0x04006446 RID: 25670
	Map,
	// Token: 0x04006447 RID: 25671
	RecruitmentDivision,
	// Token: 0x04006448 RID: 25672
	PowerModule,
	// Token: 0x04006449 RID: 25673
	TimeOfDay,
	// Token: 0x0400644A RID: 25674
	Menu,
	// Token: 0x0400644B RID: 25675
	Mail,
	// Token: 0x0400644C RID: 25676
	Online,
	// Token: 0x0400644D RID: 25677
	Tutorial,
	// Token: 0x0400644E RID: 25678
	AdventureGuide,
	// Token: 0x0400644F RID: 25679
	RoleQuest = 10025,
	// Token: 0x04006450 RID: 25680
	ExploreTool,
	// Token: 0x04006451 RID: 25681
	FunctionRoulette = 10056,
	// Token: 0x04006452 RID: 25682
	ExploreProgressReward,
	// Token: 0x04006453 RID: 25683
	KuroStreet,
	// Token: 0x04006454 RID: 25684
	SingleTimeTower = 10027,
	// Token: 0x04006455 RID: 25685
	UserFeedback,
	// Token: 0x04006456 RID: 25686
	InfluenceReputation,
	// Token: 0x04006457 RID: 25687
	CycleTower,
	// Token: 0x04006458 RID: 25688
	ShowLockOnButton,
	// Token: 0x04006459 RID: 25689
	WuYinQu,
	// Token: 0x0400645A RID: 25690
	Forging = 10034,
	// Token: 0x0400645B RID: 25691
	Compose,
	// Token: 0x0400645C RID: 25692
	ConcertoResponse,
	// Token: 0x0400645D RID: 25693
	BattlePass = 10040,
	// Token: 0x0400645E RID: 25694
	RoleHandBook,
	// Token: 0x0400645F RID: 25695
	RoleTeach = 10043,
	// Token: 0x04006460 RID: 25696
	InstanceWeapon,
	// Token: 0x04006461 RID: 25697
	InstanceSkill,
	// Token: 0x04006462 RID: 25698
	InstanceLevel,
	// Token: 0x04006463 RID: 25699
	InstanceElement,
	// Token: 0x04006464 RID: 25700
	Advice,
	// Token: 0x04006465 RID: 25701
	Photograph,
	// Token: 0x04006466 RID: 25702
	AdvicePut,
	// Token: 0x04006467 RID: 25703
	HandBookSystem,
	// Token: 0x04006468 RID: 25704
	RoleElementChange,
	// Token: 0x04006469 RID: 25705
	NewTower = 10055,
	// Token: 0x0400646A RID: 25706
	Activity = 10053,
	// Token: 0x0400646B RID: 25707
	PersonalSystem = 10060,
	// Token: 0x0400646C RID: 25708
	PersonalCard,
	// Token: 0x0400646D RID: 25709
	JiYinHuiChuan = 10023001,
	// Token: 0x0400646E RID: 25710
	HuiYinJieXiang,
	// Token: 0x0400646F RID: 25711
	WuYinQv,
	// Token: 0x04006470 RID: 25712
	ShengZhiLingYu,
	// Token: 0x04006471 RID: 25713
	DailyActivity,
	// Token: 0x04006472 RID: 25714
	VisionIdentify = 10001004,
	// Token: 0x04006473 RID: 25715
	Roguelike = 110056,
	// Token: 0x04006474 RID: 25716
	BoosRush = 110058,
	// Token: 0x04006475 RID: 25717
	LordGym = 110057,
	// Token: 0x04006476 RID: 25718
	PowerStore = 10066,
	// Token: 0x04006477 RID: 25719
	VisionRecovery = 10024001,
	// Token: 0x04006478 RID: 25720
	VisionRefine = 10083,
	// Token: 0x04006479 RID: 25721
	PowerMagnificationReward = 10071,
	// Token: 0x0400647A RID: 25722
	MailBind,
	// Token: 0x0400647B RID: 25723
	Fishing,
	// Token: 0x0400647C RID: 25724
	VisionRecommend,
	// Token: 0x0400647D RID: 25725
	VisionGroup,
	// Token: 0x0400647E RID: 25726
	FishingItemDelete,
	// Token: 0x0400647F RID: 25727
	FishingItemSail,
	// Token: 0x04006480 RID: 25728
	FishingTech,
	// Token: 0x04006481 RID: 25729
	FishingPhoebeTech = 100781,
	// Token: 0x04006482 RID: 25730
	FishingHandBook = 10079,
	// Token: 0x04006483 RID: 25731
	FishingGhostShip,
	// Token: 0x04006484 RID: 25732
	FishingEntrust = 100081,
	// Token: 0x04006485 RID: 25733
	ShipTower = 10081,
	// Token: 0x04006486 RID: 25734
	PlayerTitle,
	// Token: 0x04006487 RID: 25735
	BirthdayReward = 10084,
	// Token: 0x04006488 RID: 25736
	GameIntroduction = 10086,
	// Token: 0x04006489 RID: 25737
	PhantomArenaCoreCardSlot = 10085,
	// Token: 0x0400648A RID: 25738
	PhantomArenaCollect = 10088,
	// Token: 0x0400648B RID: 25739
	PhantomArenaRole,
	// Token: 0x0400648C RID: 25740
	PhantomArenaCard,
	// Token: 0x0400648D RID: 25741
	PhantomArenaCardUnlock,
	// Token: 0x0400648E RID: 25742
	PhantomArenaCardOutlookUnlock,
	// Token: 0x0400648F RID: 25743
	PhantomArenaSkipFuncUnlock,
	// Token: 0x04006490 RID: 25744
	DirectTrainPro = 10095,
	// Token: 0x04006491 RID: 25745
	Soar = 10026010,
	// Token: 0x04006492 RID: 25746
	RoleDev = 10097,
	// Token: 0x04006493 RID: 25747
	MotorDevelop,
	// Token: 0x04006494 RID: 25748
	MotorTechTree,
	// Token: 0x04006495 RID: 25749
	MotorFreezeWater = 10143,
	// Token: 0x04006496 RID: 25750
	HonamiStoryBackpack = 10102,
	// Token: 0x04006497 RID: 25751
	HonamiStoryMainQuestLifeSupport,
	// Token: 0x04006498 RID: 25752
	HonamiStoryBackpackStage1FuncId,
	// Token: 0x04006499 RID: 25753
	HonamiStoryLifeSupport,
	// Token: 0x0400649A RID: 25754
	SafeLeaveBuyFuncId = 10115,
	// Token: 0x0400649B RID: 25755
	ChangeDangerFuncId = 10121,
	// Token: 0x0400649C RID: 25756
	TowerOpenFuncId = 10120,
	// Token: 0x0400649D RID: 25757
	LvSelectOpenFuncId = 10112,
	// Token: 0x0400649E RID: 25758
	HonamiStoryPollution = 10114,
	// Token: 0x0400649F RID: 25759
	HonamiStoryRoleSelectFuncId = 10111,
	// Token: 0x040064A0 RID: 25760
	HonamiStoryWeaponSelectFuncId = 10123,
	// Token: 0x040064A1 RID: 25761
	HonamiStoryMascotFuncId = 10116,
	// Token: 0x040064A2 RID: 25762
	HonamiStoryAreaTaskFuncId = 10113,
	// Token: 0x040064A3 RID: 25763
	HonamiStoryShopFuncId = 10117,
	// Token: 0x040064A4 RID: 25764
	HonamiStoryItemCollectFuncId,
	// Token: 0x040064A5 RID: 25765
	HonamiStoryTechFuncId = 10107,
	// Token: 0x040064A6 RID: 25766
	HonamiStoryMainQuestFuncId = 10124,
	// Token: 0x040064A7 RID: 25767
	HonamiStoryLifeSupportCanUpdate = 10122,
	// Token: 0x040064A8 RID: 25768
	PhotoSelfie = 10160,
	// Token: 0x040064A9 RID: 25769
	PhoneMsg = 10130,
	// Token: 0x040064AA RID: 25770
	Infrastructure,
	// Token: 0x040064AB RID: 25771
	PermanentPhantomArea,
	// Token: 0x040064AC RID: 25772
	PermanentPhantomAreaCollect = 10135,
	// Token: 0x040064AD RID: 25773
	PermanentPhantomArenaRole,
	// Token: 0x040064AE RID: 25774
	PermanentPhantomArenaCard,
	// Token: 0x040064AF RID: 25775
	PermanentPhantomArenaCardUnlock,
	// Token: 0x040064B0 RID: 25776
	PermanentPhantomArenaRecommend,
	// Token: 0x040064B1 RID: 25777
	PermanentPhantomArenaSkipFuncUnlock = 10141,
	// Token: 0x040064B2 RID: 25778
	PermanentPhantomArenaCoreCardSlot,
	// Token: 0x040064B3 RID: 25779
	WeatherCentral = 10133,
	// Token: 0x040064B4 RID: 25780
	FeedbackReward = 10140,
	// Token: 0x040064B5 RID: 25781
	VisionAim = 10100,
	// Token: 0x040064B6 RID: 25782
	MotorSoar = 10154,
	// Token: 0x040064B7 RID: 25783
	VillageInfr = 10150,
	// Token: 0x040064B8 RID: 25784
	PinballDailyLevel,
	// Token: 0x040064B9 RID: 25785
	PinballRole,
	// Token: 0x040064BA RID: 25786
	PinballShop,
	// Token: 0x040064BB RID: 25787
	WeeklyChallenge = 10155,
	// Token: 0x040064BC RID: 25788
	SheriffAnomaly,
	// Token: 0x040064BD RID: 25789
	SheriffQuest,
	// Token: 0x040064BE RID: 25790
	MoonChasingMain = 10159
}
