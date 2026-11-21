using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003598 RID: 13720
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EUiTabViewName : IEquatable<EUiTabViewName>, IStaticVariableResetter
	{
		// Token: 0x06022F97 RID: 143255 RVA: 0x009F3098 File Offset: 0x009F1298
		public EUiTabViewName(string value)
		{
			this._value = value;
		}

		// Token: 0x06022F98 RID: 143256 RVA: 0x009F30A1 File Offset: 0x009F12A1
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x06022F99 RID: 143257 RVA: 0x009F30A9 File Offset: 0x009F12A9
		public bool Equals(EUiTabViewName other)
		{
			return this._value == other._value;
		}

		// Token: 0x06022F9A RID: 143258 RVA: 0x009F30BC File Offset: 0x009F12BC
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

		// Token: 0x06022F9B RID: 143259 RVA: 0x009F30E1 File Offset: 0x009F12E1
		public override int GetHashCode()
		{
			string value = this._value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06022F9C RID: 143260 RVA: 0x009F30F4 File Offset: 0x009F12F4
		public static bool operator ==(EUiTabViewName left, EUiTabViewName right)
		{
			return left.Equals(right);
		}

		// Token: 0x06022F9D RID: 143261 RVA: 0x009F30FE File Offset: 0x009F12FE
		public static bool operator !=(EUiTabViewName left, EUiTabViewName right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06022F9E RID: 143262 RVA: 0x009F310B File Offset: 0x009F130B
		public static implicit operator string(EUiTabViewName name)
		{
			return name._value;
		}

		// Token: 0x06022F9F RID: 143263 RVA: 0x009F3113 File Offset: 0x009F1313
		public static explicit operator EUiTabViewName(string value)
		{
			return new EUiTabViewName(value);
		}

		// Token: 0x06022FA0 RID: 143264 RVA: 0x009F311B File Offset: 0x009F131B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022FA1 RID: 143265 RVA: 0x009F311D File Offset: 0x009F131D
		public static void ResetStaticDefaultValue()
		{
		}

		// Token: 0x04013AD5 RID: 80597
		private readonly string _value;

		// Token: 0x04013AD6 RID: 80598
		public static readonly EUiTabViewName RoleAttributeTabView = new EUiTabViewName("RoleAttributeTabView");

		// Token: 0x04013AD7 RID: 80599
		public static readonly EUiTabViewName RoleSkillTabView = new EUiTabViewName("RoleSkillTabView");

		// Token: 0x04013AD8 RID: 80600
		public static readonly EUiTabViewName RoleResonanceTabView = new EUiTabViewName("RoleResonanceTabView");

		// Token: 0x04013AD9 RID: 80601
		public static readonly EUiTabViewName RoleResonanceTabNewView = new EUiTabViewName("RoleResonanceTabNewView");

		// Token: 0x04013ADA RID: 80602
		public static readonly EUiTabViewName RolePreviewAttributeTabView = new EUiTabViewName("RolePreviewAttributeTabView");

		// Token: 0x04013ADB RID: 80603
		public static readonly EUiTabViewName RoleWeaponTabView = new EUiTabViewName("RoleWeaponTabView");

		// Token: 0x04013ADC RID: 80604
		public static readonly EUiTabViewName RolePhantomTabView = new EUiTabViewName("RolePhantomTabView");

		// Token: 0x04013ADD RID: 80605
		public static readonly EUiTabViewName RoleFavorTabView = new EUiTabViewName("RoleFavorTabView");

		// Token: 0x04013ADE RID: 80606
		public static readonly EUiTabViewName WeaponLevelUpView = new EUiTabViewName("WeaponLevelUpView");

		// Token: 0x04013ADF RID: 80607
		public static readonly EUiTabViewName WeaponBreachView = new EUiTabViewName("WeaponBreachView");

		// Token: 0x04013AE0 RID: 80608
		public static readonly EUiTabViewName WeaponResonanceView = new EUiTabViewName("WeaponResonanceView");

		// Token: 0x04013AE1 RID: 80609
		public static readonly EUiTabViewName PayShopGiftBagView = new EUiTabViewName("PayShopGiftBagView");

		// Token: 0x04013AE2 RID: 80610
		public static readonly EUiTabViewName RogueShopTabView = new EUiTabViewName("RogueShopTabView");

		// Token: 0x04013AE3 RID: 80611
		public static readonly EUiTabViewName PayShopExchangeEntryView = new EUiTabViewName("PayShopExchangeEntryView");

		// Token: 0x04013AE4 RID: 80612
		public static readonly EUiTabViewName PayItemTabView = new EUiTabViewName("PayItemTabView");

		// Token: 0x04013AE5 RID: 80613
		public static readonly EUiTabViewName PayPackageShopView = new EUiTabViewName("PayPackageShopView");

		// Token: 0x04013AE6 RID: 80614
		public static readonly EUiTabViewName PayShopRecommendView = new EUiTabViewName("PayShopRecommendView");

		// Token: 0x04013AE7 RID: 80615
		public static readonly EUiTabViewName PayShopSkinView = new EUiTabViewName("PayShopSkinView");

		// Token: 0x04013AE8 RID: 80616
		public static readonly EUiTabViewName MonthCardView = new EUiTabViewName("MonthCardView");

		// Token: 0x04013AE9 RID: 80617
		public static readonly EUiTabViewName WeekCardView = new EUiTabViewName("WeekCardView");

		// Token: 0x04013AEA RID: 80618
		public static readonly EUiTabViewName RoleSkinRecommendView = new EUiTabViewName("RoleSkinRecommendView");

		// Token: 0x04013AEB RID: 80619
		public static readonly EUiTabViewName MotorSkinTabView = new EUiTabViewName("MotorSkinTabView");

		// Token: 0x04013AEC RID: 80620
		public static readonly EUiTabViewName PayShopNewPlayerView = new EUiTabViewName("PayShopNewPlayerView");

		// Token: 0x04013AED RID: 80621
		public static readonly EUiTabViewName NewPlayerWeekCardView = new EUiTabViewName("NewPlayerWeekCardView");

		// Token: 0x04013AEE RID: 80622
		public static readonly EUiTabViewName MotorSkinRecommendView = new EUiTabViewName("MotorSkinRecommendView");

		// Token: 0x04013AEF RID: 80623
		public static readonly EUiTabViewName RoleShopSkinTabView = new EUiTabViewName("RoleShopSkinTabView");

		// Token: 0x04013AF0 RID: 80624
		public static readonly EUiTabViewName RoleShopOrnamentTabView = new EUiTabViewName("RoleShopOrnamentTabView");

		// Token: 0x04013AF1 RID: 80625
		public static readonly EUiTabViewName ShopFlySkinTabView = new EUiTabViewName("ShopFlySkinTabView");

		// Token: 0x04013AF2 RID: 80626
		public static readonly EUiTabViewName BabelTowerShopTabView = new EUiTabViewName("BabelTowerShopTabView");

		// Token: 0x04013AF3 RID: 80627
		public static readonly EUiTabViewName RolePreviewDescribeTabView = new EUiTabViewName("RolePreviewDescribeTabView");

		// Token: 0x04013AF4 RID: 80628
		public static readonly EUiTabViewName RolePreviewSkillTabView = new EUiTabViewName("RolePreviewSkillTabView");

		// Token: 0x04013AF5 RID: 80629
		public static readonly EUiTabViewName RolePreviewResonanceTabView = new EUiTabViewName("RolePreviewResonanceTabView");

		// Token: 0x04013AF6 RID: 80630
		public static readonly EUiTabViewName RoleSkillEmptyTabView = new EUiTabViewName("RoleSkillEmptyTabView");

		// Token: 0x04013AF7 RID: 80631
		public static readonly EUiTabViewName WeaponPreviewLevelUpView = new EUiTabViewName("WeaponPreviewLevelUpView");

		// Token: 0x04013AF8 RID: 80632
		public static readonly EUiTabViewName WeaponPreviewResonanceView = new EUiTabViewName("WeaponPreviewResonanceView");

		// Token: 0x04013AF9 RID: 80633
		public static readonly EUiTabViewName AdventureTargetView = new EUiTabViewName("AdventureTargetView");

		// Token: 0x04013AFA RID: 80634
		public static readonly EUiTabViewName MonsterDetectView = new EUiTabViewName("MonsterDetectView");

		// Token: 0x04013AFB RID: 80635
		public static readonly EUiTabViewName DisposableChallengeView = new EUiTabViewName("DisposableChallengeView");

		// Token: 0x04013AFC RID: 80636
		public static readonly EUiTabViewName NewSoundAreaView = new EUiTabViewName("NewSoundAreaView");

		// Token: 0x04013AFD RID: 80637
		public static readonly EUiTabViewName DailyActivityTabView = new EUiTabViewName("DailyActivityTabView");

		// Token: 0x04013AFE RID: 80638
		public static readonly EUiTabViewName PeriodicityChallengeView = new EUiTabViewName("PeriodicityChallengeView");

		// Token: 0x04013AFF RID: 80639
		public static readonly EUiTabViewName RoleHandBookPreviewView = new EUiTabViewName("RoleHandBookPreviewView");

		// Token: 0x04013B00 RID: 80640
		public static readonly EUiTabViewName PersonalInfoTabView = new EUiTabViewName("PersonalInfoTabView");

		// Token: 0x04013B01 RID: 80641
		public static readonly EUiTabViewName PersonalCardTabView = new EUiTabViewName("PersonalCardTabView");

		// Token: 0x04013B02 RID: 80642
		public static readonly EUiTabViewName VisionLevelUpView = new EUiTabViewName("VisionLevelUpView");

		// Token: 0x04013B03 RID: 80643
		public static readonly EUiTabViewName VisionSlotView = new EUiTabViewName("VisionSlotView");

		// Token: 0x04013B04 RID: 80644
		public static readonly EUiTabViewName VisionIdentifyView = new EUiTabViewName("VisionIdentifyView");

		// Token: 0x04013B05 RID: 80645
		public static readonly EUiTabViewName CalabashLevelUpTabView = new EUiTabViewName("CalabashLevelUpTabView");

		// Token: 0x04013B06 RID: 80646
		public static readonly EUiTabViewName CalabashCollectTabView = new EUiTabViewName("CalabashCollectTabView");

		// Token: 0x04013B07 RID: 80647
		public static readonly EUiTabViewName PhantomBattleFettersTabView = new EUiTabViewName("PhantomBattleFettersTabView");

		// Token: 0x04013B08 RID: 80648
		public static readonly EUiTabViewName VisionRecoveryTabView = new EUiTabViewName("VisionRecoveryTabView");

		// Token: 0x04013B09 RID: 80649
		public static readonly EUiTabViewName VisionRefineTabView = new EUiTabViewName("VisionRefineTabView");

		// Token: 0x04013B0A RID: 80650
		public static readonly EUiTabViewName PhantomManageConfigView = new EUiTabViewName("PhantomManageConfigView");

		// Token: 0x04013B0B RID: 80651
		public static readonly EUiTabViewName PhantomManageConfigNewView = new EUiTabViewName("PhantomManageConfigNewView");

		// Token: 0x04013B0C RID: 80652
		public static readonly EUiTabViewName RoleSkinTabView = new EUiTabViewName("RoleSkinTabView");

		// Token: 0x04013B0D RID: 80653
		public static readonly EUiTabViewName WeaponSkinTabView = new EUiTabViewName("WeaponSkinTabView");

		// Token: 0x04013B0E RID: 80654
		public static readonly EUiTabViewName FlySkinTabView = new EUiTabViewName("FlySkinTabView");

		// Token: 0x04013B0F RID: 80655
		public static readonly EUiTabViewName CalabashSkinTabView = new EUiTabViewName("CalabashSkinTabView");

		// Token: 0x04013B10 RID: 80656
		public static readonly EUiTabViewName RoleOrnamentTabView = new EUiTabViewName("RoleOrnamentTabView");

		// Token: 0x04013B11 RID: 80657
		public static readonly EUiTabViewName BattlePassRewardView = new EUiTabViewName("BattlePassRewardView");

		// Token: 0x04013B12 RID: 80658
		public static readonly EUiTabViewName BattlePassTaskView = new EUiTabViewName("BattlePassTaskView");

		// Token: 0x04013B13 RID: 80659
		public static readonly EUiTabViewName BattlePassWeaponView = new EUiTabViewName("BattlePassWeaponView");

		// Token: 0x04013B14 RID: 80660
		public static readonly EUiTabViewName BossRushBuffSelectView = new EUiTabViewName("BossRushBuffSelectView");

		// Token: 0x04013B15 RID: 80661
		public static readonly EUiTabViewName BossRushLevelDetailView = new EUiTabViewName("BossRushLevelDetailView");

		// Token: 0x04013B16 RID: 80662
		public static readonly EUiTabViewName BossRushSelectView = new EUiTabViewName("BossRushSelectView");

		// Token: 0x04013B17 RID: 80663
		public static readonly EUiTabViewName BossRushRewardView = new EUiTabViewName("BossRushRewardView");

		// Token: 0x04013B18 RID: 80664
		public static readonly EUiTabViewName RewardTargetTabView = new EUiTabViewName("RewardTargetTabView");

		// Token: 0x04013B19 RID: 80665
		public static readonly EUiTabViewName RewardShopTabView = new EUiTabViewName("RewardShopTabView");

		// Token: 0x04013B1A RID: 80666
		public static readonly EUiTabViewName DockyardSellTabView = new EUiTabViewName("DockyardSellTabView");

		// Token: 0x04013B1B RID: 80667
		public static readonly EUiTabViewName DockyardBuyTabView = new EUiTabViewName("DockyardBuyTabView");

		// Token: 0x04013B1C RID: 80668
		public static readonly EUiTabViewName FishingNormalTechView = new EUiTabViewName("FishingNormalTechView");

		// Token: 0x04013B1D RID: 80669
		public static readonly EUiTabViewName FishingRoleTechView = new EUiTabViewName("FishingRoleTechView");

		// Token: 0x04013B1E RID: 80670
		public static readonly EUiTabViewName FishingTimeLimitRewardTabView = new EUiTabViewName("FishingTimeLimitRewardTabView");

		// Token: 0x04013B1F RID: 80671
		public static readonly EUiTabViewName FishingTimeLimitShopTabView = new EUiTabViewName("FishingTimeLimitShopTabView");

		// Token: 0x04013B20 RID: 80672
		public static readonly EUiTabViewName RogueIllustratedTokenTabView = new EUiTabViewName("RogueIllustratedTokenTabView");

		// Token: 0x04013B21 RID: 80673
		public static readonly EUiTabViewName RogueIllustratedEventTabView = new EUiTabViewName("RogueIllustratedEventTabView");

		// Token: 0x04013B22 RID: 80674
		public static readonly EUiTabViewName RogueBattleMapSummaryTeamTabView = new EUiTabViewName("RogueBattleMapSummaryTeamTabView");

		// Token: 0x04013B23 RID: 80675
		public static readonly EUiTabViewName RogueBattleMapSummaryFettersTabView = new EUiTabViewName("RogueBattleMapSummaryFettersTabView");

		// Token: 0x04013B24 RID: 80676
		public static readonly EUiTabViewName RogueBattleSummaryTeamTabView = new EUiTabViewName("RogueBattleSummaryTeamTabView");

		// Token: 0x04013B25 RID: 80677
		public static readonly EUiTabViewName RogueBattleSummaryTokenTabView = new EUiTabViewName("RogueBattleSummaryTokenTabView");

		// Token: 0x04013B26 RID: 80678
		public static readonly EUiTabViewName RogueBattleMapSummaryGridEffectTabView = new EUiTabViewName("RogueBattleMapSummaryGridEffectTabView");

		// Token: 0x04013B27 RID: 80679
		public static readonly EUiTabViewName SurvivorsRoleTabView = new EUiTabViewName("SurvivorsRoleTabView");

		// Token: 0x04013B28 RID: 80680
		public static readonly EUiTabViewName SurvivorsWeaponTabView = new EUiTabViewName("SurvivorsWeaponTabView");

		// Token: 0x04013B29 RID: 80681
		public static readonly EUiTabViewName SurvivorsItemTabView = new EUiTabViewName("SurvivorsItemTabView");

		// Token: 0x04013B2A RID: 80682
		public static readonly EUiTabViewName PhantomArenaEntranceGymTabView = new EUiTabViewName("PhantomArenaEntranceLevelTabView");

		// Token: 0x04013B2B RID: 80683
		public static readonly EUiTabViewName PhantomArenaEntranceRepeatTabView = new EUiTabViewName("PhantomArenaEntranceRepeatTabView");

		// Token: 0x04013B2C RID: 80684
		public static readonly EUiTabViewName PhantomArenaCollectCardTabView = new EUiTabViewName("PhantomArenaCollectCardTabView");

		// Token: 0x04013B2D RID: 80685
		public static readonly EUiTabViewName PhantomArenaCollectCardTabViewNew = new EUiTabViewName("PhantomArenaCollectCardTabViewNew");

		// Token: 0x04013B2E RID: 80686
		public static readonly EUiTabViewName PhantomArenaCollectBadgeTabView = new EUiTabViewName("PhantomArenaCollectBadgeTabView");

		// Token: 0x04013B2F RID: 80687
		public static readonly EUiTabViewName PhantomArenaEntranceTaskTabView = new EUiTabViewName("PhantomArenaEntranceTaskTabView");

		// Token: 0x04013B30 RID: 80688
		public static readonly EUiTabViewName PhantomArenaEntranceShopTabView = new EUiTabViewName("PhantomArenaEntranceShopTabView");

		// Token: 0x04013B31 RID: 80689
		public static readonly EUiTabViewName HonamiStoryEquipTabView = new EUiTabViewName("HonamiStoryEquipTabView");

		// Token: 0x04013B32 RID: 80690
		public static readonly EUiTabViewName HonamiStoryRefineTabView = new EUiTabViewName("HonamiStoryRefineTabView");

		// Token: 0x04013B33 RID: 80691
		public static readonly EUiTabViewName AdvanceNoticeNewRoleTabView = new EUiTabViewName("AdvanceNoticeNewRoleTabView");

		// Token: 0x04013B34 RID: 80692
		public static readonly EUiTabViewName AdvanceNoticeNewJourneyTabView = new EUiTabViewName("AdvanceNoticeNewJourneyTabView");

		// Token: 0x04013B35 RID: 80693
		public static readonly EUiTabViewName AdvanceNoticeNewAreaTabView = new EUiTabViewName("AdvanceNoticeNewAreaTabView");

		// Token: 0x04013B36 RID: 80694
		public static readonly EUiTabViewName AdvanceNoticeNewSkinTabView = new EUiTabViewName("AdvanceNoticeNewSkinTabView");

		// Token: 0x04013B37 RID: 80695
		public static readonly EUiTabViewName AdvanceNoticeNewEnemyTabView = new EUiTabViewName("AdvanceNoticeNewEnemyTabView");

		// Token: 0x04013B38 RID: 80696
		public static readonly EUiTabViewName AdvanceNoticeNewActivityTabView = new EUiTabViewName("AdvanceNoticeNewActivityTabView");

		// Token: 0x04013B39 RID: 80697
		public static readonly EUiTabViewName AdvanceNoticeNewSystemOptimizeTabView = new EUiTabViewName("AdvanceNoticeNewSystemOptimizeTabView");

		// Token: 0x04013B3A RID: 80698
		public static readonly EUiTabViewName MotorcycleLevelInfoTabView = new EUiTabViewName("MotorcycleLevelInfoTabView");

		// Token: 0x04013B3B RID: 80699
		public static readonly EUiTabViewName MotorcycleTechTreeTabView = new EUiTabViewName("MotorcycleTechTreeTabView");

		// Token: 0x04013B3C RID: 80700
		public static readonly EUiTabViewName MotorcycleTaskTabView = new EUiTabViewName("MotorcycleTaskTabView");

		// Token: 0x04013B3D RID: 80701
		public static readonly EUiTabViewName MotorcycleDiyMainView = new EUiTabViewName("MotorcycleDiyMainView");

		// Token: 0x04013B3E RID: 80702
		public static readonly EUiTabViewName MotorcycleDiyFrameTabView = new EUiTabViewName("MotorcycleDiyFrameTabView");

		// Token: 0x04013B3F RID: 80703
		public static readonly EUiTabViewName MotorcycleDiyStickerTabView = new EUiTabViewName("MotorcycleDiyStickerTabView");

		// Token: 0x04013B40 RID: 80704
		public static readonly EUiTabViewName MotorcycleDiyDecorationTabView = new EUiTabViewName("MotorcycleDiyDecorationTabView");

		// Token: 0x04013B41 RID: 80705
		public static readonly EUiTabViewName MotorcycleDiyEditFrameTabView = new EUiTabViewName("MotorcycleDiyEditFrameTabView");

		// Token: 0x04013B42 RID: 80706
		public static readonly EUiTabViewName MotorcycleDiyEditStickerTabView = new EUiTabViewName("MotorcycleDiyEditStickerTabView");

		// Token: 0x04013B43 RID: 80707
		public static readonly EUiTabViewName MotorcycleDiyEditDecorationTabView = new EUiTabViewName("MotorcycleDiyEditDecorationTabView");

		// Token: 0x04013B44 RID: 80708
		public static readonly EUiTabViewName PinballRoleAttributeTabView = new EUiTabViewName("PinballRoleAttributeTabView");

		// Token: 0x04013B45 RID: 80709
		public static readonly EUiTabViewName PinballRoleWeaponTabView = new EUiTabViewName("PinballRoleWeaponTabView");

		// Token: 0x04013B46 RID: 80710
		public static readonly EUiTabViewName RegressBpTaskTabView = new EUiTabViewName("RegressBpTaskTabView");

		// Token: 0x04013B47 RID: 80711
		public static readonly EUiTabViewName RegressBpRewardTabView = new EUiTabViewName("RegressBpRewardTabView");

		// Token: 0x04013B48 RID: 80712
		public static readonly EUiTabViewName KurotatoRoleOverviewTabView = new EUiTabViewName("KurotatoRoleOverviewTabView");

		// Token: 0x04013B49 RID: 80713
		public static readonly EUiTabViewName KurotatoWeaponOverviewTabView = new EUiTabViewName("KurotatoWeaponOverviewTabView");

		// Token: 0x04013B4A RID: 80714
		public static readonly EUiTabViewName KurotatoHandBookWeaponTabView = new EUiTabViewName("KurotatoHandBookWeaponTabView");

		// Token: 0x04013B4B RID: 80715
		public static readonly EUiTabViewName KurotatoHandBookRoleTabView = new EUiTabViewName("KurotatoHandBookRoleTabView");

		// Token: 0x04013B4C RID: 80716
		public static readonly EUiTabViewName RoverlikeDetailRoleTabView = new EUiTabViewName("RoverlikeDetailRoleTabView");

		// Token: 0x04013B4D RID: 80717
		public static readonly EUiTabViewName RoverlikeDetailBlessTabView = new EUiTabViewName("RoverlikeDetailBlessTabView");

		// Token: 0x04013B4E RID: 80718
		public static readonly EUiTabViewName RoverlikeDetailEnhanceTabView = new EUiTabViewName("RoverlikeDetailEnhanceTabView");

		// Token: 0x04013B4F RID: 80719
		public static readonly EUiTabViewName RoverlikeOutsideBlessTabView = new EUiTabViewName("RoverlikeOutsideBlessTabView");

		// Token: 0x04013B50 RID: 80720
		public static readonly EUiTabViewName RoverlikeOutsideEnhanceTabView = new EUiTabViewName("RoverlikeOutsideEnhanceTabView");

		// Token: 0x04013B51 RID: 80721
		public static readonly EUiTabViewName RoverlikeOutsidePropTabView = new EUiTabViewName("RoverlikeOutsidePropTabView");

		// Token: 0x04013B52 RID: 80722
		public static readonly EUiTabViewName SheriffMainAnalysisCluePanel = new EUiTabViewName("SheriffMainAnalysisCluePanel");

		// Token: 0x04013B53 RID: 80723
		public static readonly EUiTabViewName SheriffMainSelectCluePanel = new EUiTabViewName("SheriffMainSelectCluePanel");

		// Token: 0x04013B54 RID: 80724
		public static readonly EUiTabViewName SheriffMainClueDetailPanel = new EUiTabViewName("SheriffMainClueDetailPanel");

		// Token: 0x04013B55 RID: 80725
		public static readonly EUiTabViewName SheriffMainConclusionPanel = new EUiTabViewName("SheriffMainConclusionPanel");

		// Token: 0x04013B56 RID: 80726
		public static readonly EUiTabViewName SheriffReportDetailItem = new EUiTabViewName("SheriffReportDetailItem");

		// Token: 0x04013B57 RID: 80727
		public static readonly EUiTabViewName SheriffReportRecordItem = new EUiTabViewName("SheriffReportRecordItem");

		// Token: 0x04013B58 RID: 80728
		public static readonly EUiTabViewName DangoBrawlHandBookItemTabView = new EUiTabViewName("DangoBrawlHandBookItemTabView");

		// Token: 0x04013B59 RID: 80729
		public static readonly EUiTabViewName DangoBrawlOccupationTabView = new EUiTabViewName("DangoBrawlOccupationTabView");

		// Token: 0x04013B5A RID: 80730
		public static readonly EUiTabViewName SolarSchoolInfoFriendTabView = new EUiTabViewName("SolarSchoolInfoFriendTabView");

		// Token: 0x04013B5B RID: 80731
		public static readonly EUiTabViewName SolarSchoolInfoPlayerTabView = new EUiTabViewName("SolarSchoolInfoPlayerTabView");

		// Token: 0x04013B5C RID: 80732
		public static readonly EUiTabViewName SolarSchoolGalleryEndingTabView = new EUiTabViewName("SolarSchoolGalleryEndingTabView");

		// Token: 0x04013B5D RID: 80733
		public static readonly EUiTabViewName SolarSchoolGalleryCgTabView = new EUiTabViewName("SolarSchoolGalleryCgTabView");

		// Token: 0x04013B5E RID: 80734
		public static readonly EUiTabViewName SolarSchoolGalleryOpTabView = new EUiTabViewName("SolarSchoolGalleryOpTabView");
	}
}
