using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004667 RID: 18023
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EUiTabViewName : IEquatable<EUiTabViewName>, IStaticVariableResetter
	{
		// Token: 0x0602E84D RID: 190541 RVA: 0x00AC5581 File Offset: 0x00AC3781
		public EUiTabViewName(string value)
		{
			this._value = value;
		}

		// Token: 0x0602E84E RID: 190542 RVA: 0x00AC558A File Offset: 0x00AC378A
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0602E84F RID: 190543 RVA: 0x00AC5592 File Offset: 0x00AC3792
		public bool Equals(EUiTabViewName other)
		{
			return this._value == other._value;
		}

		// Token: 0x0602E850 RID: 190544 RVA: 0x00AC55A8 File Offset: 0x00AC37A8
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EUiTabViewName)
			{
				EUiTabViewName other = (EUiTabViewName)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602E851 RID: 190545 RVA: 0x00AC55CD File Offset: 0x00AC37CD
		public override int GetHashCode()
		{
			string value = this._value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602E852 RID: 190546 RVA: 0x00AC55E0 File Offset: 0x00AC37E0
		public static bool operator ==(EUiTabViewName left, EUiTabViewName right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602E853 RID: 190547 RVA: 0x00AC55EA File Offset: 0x00AC37EA
		public static bool operator !=(EUiTabViewName left, EUiTabViewName right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0602E854 RID: 190548 RVA: 0x00AC55F7 File Offset: 0x00AC37F7
		public static implicit operator string(EUiTabViewName name)
		{
			return name._value;
		}

		// Token: 0x0602E855 RID: 190549 RVA: 0x00AC55FF File Offset: 0x00AC37FF
		public static explicit operator EUiTabViewName(string value)
		{
			return new EUiTabViewName(value);
		}

		// Token: 0x0602E856 RID: 190550 RVA: 0x00AC5607 File Offset: 0x00AC3807
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E857 RID: 190551 RVA: 0x00AC5609 File Offset: 0x00AC3809
		public static void ResetStaticDefaultValue()
		{
		}

		// Token: 0x04019433 RID: 103475
		private readonly string _value;

		// Token: 0x04019434 RID: 103476
		public static readonly EUiTabViewName RoleAttributeTabView = new EUiTabViewName("RoleAttributeTabView");

		// Token: 0x04019435 RID: 103477
		public static readonly EUiTabViewName RoleSkillTabView = new EUiTabViewName("RoleSkillTabView");

		// Token: 0x04019436 RID: 103478
		public static readonly EUiTabViewName RoleResonanceTabView = new EUiTabViewName("RoleResonanceTabView");

		// Token: 0x04019437 RID: 103479
		public static readonly EUiTabViewName RoleResonanceTabNewView = new EUiTabViewName("RoleResonanceTabNewView");

		// Token: 0x04019438 RID: 103480
		public static readonly EUiTabViewName RolePreviewAttributeTabView = new EUiTabViewName("RolePreviewAttributeTabView");

		// Token: 0x04019439 RID: 103481
		public static readonly EUiTabViewName RoleWeaponTabView = new EUiTabViewName("RoleWeaponTabView");

		// Token: 0x0401943A RID: 103482
		public static readonly EUiTabViewName RolePhantomTabView = new EUiTabViewName("RolePhantomTabView");

		// Token: 0x0401943B RID: 103483
		public static readonly EUiTabViewName RoleFavorTabView = new EUiTabViewName("RoleFavorTabView");

		// Token: 0x0401943C RID: 103484
		public static readonly EUiTabViewName WeaponLevelUpView = new EUiTabViewName("WeaponLevelUpView");

		// Token: 0x0401943D RID: 103485
		public static readonly EUiTabViewName WeaponBreachView = new EUiTabViewName("WeaponBreachView");

		// Token: 0x0401943E RID: 103486
		public static readonly EUiTabViewName WeaponResonanceView = new EUiTabViewName("WeaponResonanceView");

		// Token: 0x0401943F RID: 103487
		public static readonly EUiTabViewName PayShopGiftBagView = new EUiTabViewName("PayShopGiftBagView");

		// Token: 0x04019440 RID: 103488
		public static readonly EUiTabViewName RogueShopTabView = new EUiTabViewName("RogueShopTabView");

		// Token: 0x04019441 RID: 103489
		public static readonly EUiTabViewName PayShopExchangeEntryView = new EUiTabViewName("PayShopExchangeEntryView");

		// Token: 0x04019442 RID: 103490
		public static readonly EUiTabViewName PayItemTabView = new EUiTabViewName("PayItemTabView");

		// Token: 0x04019443 RID: 103491
		public static readonly EUiTabViewName PayPackageShopView = new EUiTabViewName("PayPackageShopView");

		// Token: 0x04019444 RID: 103492
		public static readonly EUiTabViewName PayShopRecommendView = new EUiTabViewName("PayShopRecommendView");

		// Token: 0x04019445 RID: 103493
		public static readonly EUiTabViewName PayShopSkinView = new EUiTabViewName("PayShopSkinView");

		// Token: 0x04019446 RID: 103494
		public static readonly EUiTabViewName MonthCardView = new EUiTabViewName("MonthCardView");

		// Token: 0x04019447 RID: 103495
		public static readonly EUiTabViewName WeekCardView = new EUiTabViewName("WeekCardView");

		// Token: 0x04019448 RID: 103496
		public static readonly EUiTabViewName RoleSkinRecommendView = new EUiTabViewName("RoleSkinRecommendView");

		// Token: 0x04019449 RID: 103497
		public static readonly EUiTabViewName MotorSkinTabView = new EUiTabViewName("MotorSkinTabView");

		// Token: 0x0401944A RID: 103498
		public static readonly EUiTabViewName PayShopNewPlayerView = new EUiTabViewName("PayShopNewPlayerView");

		// Token: 0x0401944B RID: 103499
		public static readonly EUiTabViewName NewPlayerWeekCardView = new EUiTabViewName("NewPlayerWeekCardView");

		// Token: 0x0401944C RID: 103500
		public static readonly EUiTabViewName MotorSkinRecommendView = new EUiTabViewName("MotorSkinRecommendView");

		// Token: 0x0401944D RID: 103501
		public static readonly EUiTabViewName RoleShopSkinTabView = new EUiTabViewName("RoleShopSkinTabView");

		// Token: 0x0401944E RID: 103502
		public static readonly EUiTabViewName RoleShopOrnamentTabView = new EUiTabViewName("RoleShopOrnamentTabView");

		// Token: 0x0401944F RID: 103503
		public static readonly EUiTabViewName ShopFlySkinTabView = new EUiTabViewName("ShopFlySkinTabView");

		// Token: 0x04019450 RID: 103504
		public static readonly EUiTabViewName BabelTowerShopTabView = new EUiTabViewName("BabelTowerShopTabView");

		// Token: 0x04019451 RID: 103505
		public static readonly EUiTabViewName RolePreviewDescribeTabView = new EUiTabViewName("RolePreviewDescribeTabView");

		// Token: 0x04019452 RID: 103506
		public static readonly EUiTabViewName RolePreviewSkillTabView = new EUiTabViewName("RolePreviewSkillTabView");

		// Token: 0x04019453 RID: 103507
		public static readonly EUiTabViewName RolePreviewResonanceTabView = new EUiTabViewName("RolePreviewResonanceTabView");

		// Token: 0x04019454 RID: 103508
		public static readonly EUiTabViewName RoleSkillEmptyTabView = new EUiTabViewName("RoleSkillEmptyTabView");

		// Token: 0x04019455 RID: 103509
		public static readonly EUiTabViewName WeaponPreviewLevelUpView = new EUiTabViewName("WeaponPreviewLevelUpView");

		// Token: 0x04019456 RID: 103510
		public static readonly EUiTabViewName WeaponPreviewResonanceView = new EUiTabViewName("WeaponPreviewResonanceView");

		// Token: 0x04019457 RID: 103511
		public static readonly EUiTabViewName AdventureTargetView = new EUiTabViewName("AdventureTargetView");

		// Token: 0x04019458 RID: 103512
		public static readonly EUiTabViewName MonsterDetectView = new EUiTabViewName("MonsterDetectView");

		// Token: 0x04019459 RID: 103513
		public static readonly EUiTabViewName DisposableChallengeView = new EUiTabViewName("DisposableChallengeView");

		// Token: 0x0401945A RID: 103514
		public static readonly EUiTabViewName NewSoundAreaView = new EUiTabViewName("NewSoundAreaView");

		// Token: 0x0401945B RID: 103515
		public static readonly EUiTabViewName DailyActivityTabView = new EUiTabViewName("DailyActivityTabView");

		// Token: 0x0401945C RID: 103516
		public static readonly EUiTabViewName PeriodicityChallengeView = new EUiTabViewName("PeriodicityChallengeView");

		// Token: 0x0401945D RID: 103517
		public static readonly EUiTabViewName RoleHandBookPreviewView = new EUiTabViewName("RoleHandBookPreviewView");

		// Token: 0x0401945E RID: 103518
		public static readonly EUiTabViewName PersonalInfoTabView = new EUiTabViewName("PersonalInfoTabView");

		// Token: 0x0401945F RID: 103519
		public static readonly EUiTabViewName PersonalCardTabView = new EUiTabViewName("PersonalCardTabView");

		// Token: 0x04019460 RID: 103520
		public static readonly EUiTabViewName VisionLevelUpView = new EUiTabViewName("VisionLevelUpView");

		// Token: 0x04019461 RID: 103521
		public static readonly EUiTabViewName VisionSlotView = new EUiTabViewName("VisionSlotView");

		// Token: 0x04019462 RID: 103522
		public static readonly EUiTabViewName VisionIdentifyView = new EUiTabViewName("VisionIdentifyView");

		// Token: 0x04019463 RID: 103523
		public static readonly EUiTabViewName CalabashLevelUpTabView = new EUiTabViewName("CalabashLevelUpTabView");

		// Token: 0x04019464 RID: 103524
		public static readonly EUiTabViewName CalabashCollectTabView = new EUiTabViewName("CalabashCollectTabView");

		// Token: 0x04019465 RID: 103525
		public static readonly EUiTabViewName PhantomBattleFettersTabView = new EUiTabViewName("PhantomBattleFettersTabView");

		// Token: 0x04019466 RID: 103526
		public static readonly EUiTabViewName VisionRecoveryTabView = new EUiTabViewName("VisionRecoveryTabView");

		// Token: 0x04019467 RID: 103527
		public static readonly EUiTabViewName VisionRefineTabView = new EUiTabViewName("VisionRefineTabView");

		// Token: 0x04019468 RID: 103528
		public static readonly EUiTabViewName PhantomManageConfigView = new EUiTabViewName("PhantomManageConfigView");

		// Token: 0x04019469 RID: 103529
		public static readonly EUiTabViewName PhantomManageConfigNewView = new EUiTabViewName("PhantomManageConfigNewView");

		// Token: 0x0401946A RID: 103530
		public static readonly EUiTabViewName RoleSkinTabView = new EUiTabViewName("RoleSkinTabView");

		// Token: 0x0401946B RID: 103531
		public static readonly EUiTabViewName WeaponSkinTabView = new EUiTabViewName("WeaponSkinTabView");

		// Token: 0x0401946C RID: 103532
		public static readonly EUiTabViewName FlySkinTabView = new EUiTabViewName("FlySkinTabView");

		// Token: 0x0401946D RID: 103533
		public static readonly EUiTabViewName CalabashSkinTabView = new EUiTabViewName("CalabashSkinTabView");

		// Token: 0x0401946E RID: 103534
		public static readonly EUiTabViewName RoleOrnamentTabView = new EUiTabViewName("RoleOrnamentTabView");

		// Token: 0x0401946F RID: 103535
		public static readonly EUiTabViewName BattlePassRewardView = new EUiTabViewName("BattlePassRewardView");

		// Token: 0x04019470 RID: 103536
		public static readonly EUiTabViewName BattlePassTaskView = new EUiTabViewName("BattlePassTaskView");

		// Token: 0x04019471 RID: 103537
		public static readonly EUiTabViewName BattlePassWeaponView = new EUiTabViewName("BattlePassWeaponView");

		// Token: 0x04019472 RID: 103538
		public static readonly EUiTabViewName BossRushBuffSelectView = new EUiTabViewName("BossRushBuffSelectView");

		// Token: 0x04019473 RID: 103539
		public static readonly EUiTabViewName BossRushLevelDetailView = new EUiTabViewName("BossRushLevelDetailView");

		// Token: 0x04019474 RID: 103540
		public static readonly EUiTabViewName BossRushSelectView = new EUiTabViewName("BossRushSelectView");

		// Token: 0x04019475 RID: 103541
		public static readonly EUiTabViewName BossRushRewardView = new EUiTabViewName("BossRushRewardView");

		// Token: 0x04019476 RID: 103542
		public static readonly EUiTabViewName RewardTargetTabView = new EUiTabViewName("RewardTargetTabView");

		// Token: 0x04019477 RID: 103543
		public static readonly EUiTabViewName RewardShopTabView = new EUiTabViewName("RewardShopTabView");

		// Token: 0x04019478 RID: 103544
		public static readonly EUiTabViewName DockyardSellTabView = new EUiTabViewName("DockyardSellTabView");

		// Token: 0x04019479 RID: 103545
		public static readonly EUiTabViewName DockyardBuyTabView = new EUiTabViewName("DockyardBuyTabView");

		// Token: 0x0401947A RID: 103546
		public static readonly EUiTabViewName FishingNormalTechView = new EUiTabViewName("FishingNormalTechView");

		// Token: 0x0401947B RID: 103547
		public static readonly EUiTabViewName FishingRoleTechView = new EUiTabViewName("FishingRoleTechView");

		// Token: 0x0401947C RID: 103548
		public static readonly EUiTabViewName FishingTimeLimitRewardTabView = new EUiTabViewName("FishingTimeLimitRewardTabView");

		// Token: 0x0401947D RID: 103549
		public static readonly EUiTabViewName FishingTimeLimitShopTabView = new EUiTabViewName("FishingTimeLimitShopTabView");

		// Token: 0x0401947E RID: 103550
		public static readonly EUiTabViewName RogueIllustratedTokenTabView = new EUiTabViewName("RogueIllustratedTokenTabView");

		// Token: 0x0401947F RID: 103551
		public static readonly EUiTabViewName RogueIllustratedEventTabView = new EUiTabViewName("RogueIllustratedEventTabView");

		// Token: 0x04019480 RID: 103552
		public static readonly EUiTabViewName RogueBattleMapSummaryTeamTabView = new EUiTabViewName("RogueBattleMapSummaryTeamTabView");

		// Token: 0x04019481 RID: 103553
		public static readonly EUiTabViewName RogueBattleMapSummaryFettersTabView = new EUiTabViewName("RogueBattleMapSummaryFettersTabView");

		// Token: 0x04019482 RID: 103554
		public static readonly EUiTabViewName RogueBattleSummaryTeamTabView = new EUiTabViewName("RogueBattleSummaryTeamTabView");

		// Token: 0x04019483 RID: 103555
		public static readonly EUiTabViewName RogueBattleSummaryTokenTabView = new EUiTabViewName("RogueBattleSummaryTokenTabView");

		// Token: 0x04019484 RID: 103556
		public static readonly EUiTabViewName RogueBattleMapSummaryGridEffectTabView = new EUiTabViewName("RogueBattleMapSummaryGridEffectTabView");

		// Token: 0x04019485 RID: 103557
		public static readonly EUiTabViewName SurvivorsRoleTabView = new EUiTabViewName("SurvivorsRoleTabView");

		// Token: 0x04019486 RID: 103558
		public static readonly EUiTabViewName SurvivorsWeaponTabView = new EUiTabViewName("SurvivorsWeaponTabView");

		// Token: 0x04019487 RID: 103559
		public static readonly EUiTabViewName SurvivorsItemTabView = new EUiTabViewName("SurvivorsItemTabView");

		// Token: 0x04019488 RID: 103560
		public static readonly EUiTabViewName PhantomArenaEntranceGymTabView = new EUiTabViewName("PhantomArenaEntranceLevelTabView");

		// Token: 0x04019489 RID: 103561
		public static readonly EUiTabViewName PhantomArenaEntranceRepeatTabView = new EUiTabViewName("PhantomArenaEntranceRepeatTabView");

		// Token: 0x0401948A RID: 103562
		public static readonly EUiTabViewName PhantomArenaCollectCardTabView = new EUiTabViewName("PhantomArenaCollectCardTabView");

		// Token: 0x0401948B RID: 103563
		public static readonly EUiTabViewName PhantomArenaCollectCardTabViewNew = new EUiTabViewName("PhantomArenaCollectCardTabViewNew");

		// Token: 0x0401948C RID: 103564
		public static readonly EUiTabViewName PhantomArenaCollectBadgeTabView = new EUiTabViewName("PhantomArenaCollectBadgeTabView");

		// Token: 0x0401948D RID: 103565
		public static readonly EUiTabViewName PhantomArenaEntranceTaskTabView = new EUiTabViewName("PhantomArenaEntranceTaskTabView");

		// Token: 0x0401948E RID: 103566
		public static readonly EUiTabViewName PhantomArenaEntranceShopTabView = new EUiTabViewName("PhantomArenaEntranceShopTabView");

		// Token: 0x0401948F RID: 103567
		public static readonly EUiTabViewName HonamiStoryEquipTabView = new EUiTabViewName("HonamiStoryEquipTabView");

		// Token: 0x04019490 RID: 103568
		public static readonly EUiTabViewName HonamiStoryRefineTabView = new EUiTabViewName("HonamiStoryRefineTabView");

		// Token: 0x04019491 RID: 103569
		public static readonly EUiTabViewName AdvanceNoticeNewRoleTabView = new EUiTabViewName("AdvanceNoticeNewRoleTabView");

		// Token: 0x04019492 RID: 103570
		public static readonly EUiTabViewName AdvanceNoticeNewJourneyTabView = new EUiTabViewName("AdvanceNoticeNewJourneyTabView");

		// Token: 0x04019493 RID: 103571
		public static readonly EUiTabViewName AdvanceNoticeNewAreaTabView = new EUiTabViewName("AdvanceNoticeNewAreaTabView");

		// Token: 0x04019494 RID: 103572
		public static readonly EUiTabViewName AdvanceNoticeNewSkinTabView = new EUiTabViewName("AdvanceNoticeNewSkinTabView");

		// Token: 0x04019495 RID: 103573
		public static readonly EUiTabViewName AdvanceNoticeNewEnemyTabView = new EUiTabViewName("AdvanceNoticeNewEnemyTabView");

		// Token: 0x04019496 RID: 103574
		public static readonly EUiTabViewName AdvanceNoticeNewActivityTabView = new EUiTabViewName("AdvanceNoticeNewActivityTabView");

		// Token: 0x04019497 RID: 103575
		public static readonly EUiTabViewName AdvanceNoticeNewSystemOptimizeTabView = new EUiTabViewName("AdvanceNoticeNewSystemOptimizeTabView");

		// Token: 0x04019498 RID: 103576
		public static readonly EUiTabViewName MotorcycleLevelInfoTabView = new EUiTabViewName("MotorcycleLevelInfoTabView");

		// Token: 0x04019499 RID: 103577
		public static readonly EUiTabViewName MotorcycleTechTreeTabView = new EUiTabViewName("MotorcycleTechTreeTabView");

		// Token: 0x0401949A RID: 103578
		public static readonly EUiTabViewName MotorcycleTaskTabView = new EUiTabViewName("MotorcycleTaskTabView");

		// Token: 0x0401949B RID: 103579
		public static readonly EUiTabViewName MotorcycleDiyMainView = new EUiTabViewName("MotorcycleDiyMainView");

		// Token: 0x0401949C RID: 103580
		public static readonly EUiTabViewName MotorcycleDiyFrameTabView = new EUiTabViewName("MotorcycleDiyFrameTabView");

		// Token: 0x0401949D RID: 103581
		public static readonly EUiTabViewName MotorcycleDiyStickerTabView = new EUiTabViewName("MotorcycleDiyStickerTabView");

		// Token: 0x0401949E RID: 103582
		public static readonly EUiTabViewName MotorcycleDiyDecorationTabView = new EUiTabViewName("MotorcycleDiyDecorationTabView");

		// Token: 0x0401949F RID: 103583
		public static readonly EUiTabViewName MotorcycleDiyEditFrameTabView = new EUiTabViewName("MotorcycleDiyEditFrameTabView");

		// Token: 0x040194A0 RID: 103584
		public static readonly EUiTabViewName MotorcycleDiyEditStickerTabView = new EUiTabViewName("MotorcycleDiyEditStickerTabView");

		// Token: 0x040194A1 RID: 103585
		public static readonly EUiTabViewName MotorcycleDiyEditDecorationTabView = new EUiTabViewName("MotorcycleDiyEditDecorationTabView");

		// Token: 0x040194A2 RID: 103586
		public static readonly EUiTabViewName PinballRoleAttributeTabView = new EUiTabViewName("PinballRoleAttributeTabView");

		// Token: 0x040194A3 RID: 103587
		public static readonly EUiTabViewName PinballRoleWeaponTabView = new EUiTabViewName("PinballRoleWeaponTabView");

		// Token: 0x040194A4 RID: 103588
		public static readonly EUiTabViewName RegressBpTaskTabView = new EUiTabViewName("RegressBpTaskTabView");

		// Token: 0x040194A5 RID: 103589
		public static readonly EUiTabViewName RegressBpRewardTabView = new EUiTabViewName("RegressBpRewardTabView");

		// Token: 0x040194A6 RID: 103590
		public static readonly EUiTabViewName KurotatoRoleOverviewTabView = new EUiTabViewName("KurotatoRoleOverviewTabView");

		// Token: 0x040194A7 RID: 103591
		public static readonly EUiTabViewName KurotatoWeaponOverviewTabView = new EUiTabViewName("KurotatoWeaponOverviewTabView");

		// Token: 0x040194A8 RID: 103592
		public static readonly EUiTabViewName KurotatoHandBookWeaponTabView = new EUiTabViewName("KurotatoHandBookWeaponTabView");

		// Token: 0x040194A9 RID: 103593
		public static readonly EUiTabViewName KurotatoHandBookRoleTabView = new EUiTabViewName("KurotatoHandBookRoleTabView");

		// Token: 0x040194AA RID: 103594
		public static readonly EUiTabViewName RoverlikeDetailRoleTabView = new EUiTabViewName("RoverlikeDetailRoleTabView");

		// Token: 0x040194AB RID: 103595
		public static readonly EUiTabViewName RoverlikeDetailBlessTabView = new EUiTabViewName("RoverlikeDetailBlessTabView");

		// Token: 0x040194AC RID: 103596
		public static readonly EUiTabViewName RoverlikeDetailEnhanceTabView = new EUiTabViewName("RoverlikeDetailEnhanceTabView");

		// Token: 0x040194AD RID: 103597
		public static readonly EUiTabViewName RoverlikeOutsideBlessTabView = new EUiTabViewName("RoverlikeOutsideBlessTabView");

		// Token: 0x040194AE RID: 103598
		public static readonly EUiTabViewName RoverlikeOutsideEnhanceTabView = new EUiTabViewName("RoverlikeOutsideEnhanceTabView");

		// Token: 0x040194AF RID: 103599
		public static readonly EUiTabViewName RoverlikeOutsidePropTabView = new EUiTabViewName("RoverlikeOutsidePropTabView");

		// Token: 0x040194B0 RID: 103600
		public static readonly EUiTabViewName SheriffMainAnalysisCluePanel = new EUiTabViewName("SheriffMainAnalysisCluePanel");

		// Token: 0x040194B1 RID: 103601
		public static readonly EUiTabViewName SheriffMainSelectCluePanel = new EUiTabViewName("SheriffMainSelectCluePanel");

		// Token: 0x040194B2 RID: 103602
		public static readonly EUiTabViewName SheriffMainClueDetailPanel = new EUiTabViewName("SheriffMainClueDetailPanel");

		// Token: 0x040194B3 RID: 103603
		public static readonly EUiTabViewName SheriffMainConclusionPanel = new EUiTabViewName("SheriffMainConclusionPanel");

		// Token: 0x040194B4 RID: 103604
		public static readonly EUiTabViewName SheriffReportDetailItem = new EUiTabViewName("SheriffReportDetailItem");

		// Token: 0x040194B5 RID: 103605
		public static readonly EUiTabViewName SheriffReportRecordItem = new EUiTabViewName("SheriffReportRecordItem");

		// Token: 0x040194B6 RID: 103606
		public static readonly EUiTabViewName DangoBrawlHandBookItemTabView = new EUiTabViewName("DangoBrawlHandBookItemTabView");

		// Token: 0x040194B7 RID: 103607
		public static readonly EUiTabViewName DangoBrawlOccupationTabView = new EUiTabViewName("DangoBrawlOccupationTabView");
	}
}
