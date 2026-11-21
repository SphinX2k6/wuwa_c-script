using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Utils.StaticVariableReset;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003597 RID: 13719
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariablePriority(50)]
	public readonly struct EUiViewName : IEquatable<EUiViewName>, IStaticVariableResetter
	{
		// Token: 0x06022F8B RID: 143243 RVA: 0x009ED3D6 File Offset: 0x009EB5D6
		private EUiViewName(string value)
		{
			this._value = value;
		}

		// Token: 0x06022F8C RID: 143244 RVA: 0x009ED3DF File Offset: 0x009EB5DF
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x06022F8D RID: 143245 RVA: 0x009ED3E7 File Offset: 0x009EB5E7
		public bool Equals(EUiViewName other)
		{
			return this._value == other._value;
		}

		// Token: 0x06022F8E RID: 143246 RVA: 0x009ED3FC File Offset: 0x009EB5FC
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EUiViewName)
			{
				EUiViewName other = (EUiViewName)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06022F8F RID: 143247 RVA: 0x009ED421 File Offset: 0x009EB621
		public override int GetHashCode()
		{
			string value = this._value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06022F90 RID: 143248 RVA: 0x009ED434 File Offset: 0x009EB634
		public static bool operator ==(EUiViewName left, EUiViewName right)
		{
			return left.Equals(right);
		}

		// Token: 0x06022F91 RID: 143249 RVA: 0x009ED43E File Offset: 0x009EB63E
		public static bool operator !=(EUiViewName left, EUiViewName right)
		{
			return !left.Equals(right);
		}

		// Token: 0x06022F92 RID: 143250 RVA: 0x009ED44B File Offset: 0x009EB64B
		public static implicit operator string(EUiViewName name)
		{
			return name._value;
		}

		// Token: 0x06022F93 RID: 143251 RVA: 0x009ED453 File Offset: 0x009EB653
		public static explicit operator EUiViewName(string value)
		{
			return new EUiViewName(value);
		}

		// Token: 0x06022F94 RID: 143252 RVA: 0x009ED45B File Offset: 0x009EB65B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022F95 RID: 143253 RVA: 0x009ED45D File Offset: 0x009EB65D
		public static void ResetStaticDefaultValue()
		{
		}

		// Token: 0x040134AF RID: 79023
		private readonly string _value;

		// Token: 0x040134B0 RID: 79024
		public static readonly EUiViewName All = new EUiViewName("All");

		// Token: 0x040134B1 RID: 79025
		public static readonly EUiViewName BattleView = new EUiViewName("BattleView");

		// Token: 0x040134B2 RID: 79026
		public static readonly EUiViewName MailBoxView = new EUiViewName("MailBoxView");

		// Token: 0x040134B3 RID: 79027
		public static readonly EUiViewName MailContentView = new EUiViewName("MailContentView");

		// Token: 0x040134B4 RID: 79028
		public static readonly EUiViewName WorldMapView = new EUiViewName("WorldMapView");

		// Token: 0x040134B5 RID: 79029
		public static readonly EUiViewName RoleRootView = new EUiViewName("RoleRootView");

		// Token: 0x040134B6 RID: 79030
		public static readonly EUiViewName RolePreviewRootView = new EUiViewName("RolePreviewRootView");

		// Token: 0x040134B7 RID: 79031
		public static readonly EUiViewName RoleNewJoinRootView = new EUiViewName("RoleNewJoinRootView");

		// Token: 0x040134B8 RID: 79032
		public static readonly EUiViewName RoleBreachView = new EUiViewName("RoleBreachView");

		// Token: 0x040134B9 RID: 79033
		public static readonly EUiViewName RoleSkillView = new EUiViewName("RoleSkillView");

		// Token: 0x040134BA RID: 79034
		public static readonly EUiViewName RoleLevelUpView = new EUiViewName("RoleLevelUpView");

		// Token: 0x040134BB RID: 79035
		public static readonly EUiViewName RoleSelectionView = new EUiViewName("RoleSelectionView");

		// Token: 0x040134BC RID: 79036
		public static readonly EUiViewName RoleNewJoinView = new EUiViewName("RoleNewJoinView");

		// Token: 0x040134BD RID: 79037
		public static readonly EUiViewName RoleNewJoinTipView = new EUiViewName("RoleNewJoinTipView");

		// Token: 0x040134BE RID: 79038
		public static readonly EUiViewName TeamRoleSelectView = new EUiViewName("TeamRoleSelectView");

		// Token: 0x040134BF RID: 79039
		public static readonly EUiViewName TeamSceneRoleSelectView = new EUiViewName("TeamSceneRoleSelectView");

		// Token: 0x040134C0 RID: 79040
		public static readonly EUiViewName MultiTeamRoleSelectView = new EUiViewName("MultiTeamRoleSelectView");

		// Token: 0x040134C1 RID: 79041
		public static readonly EUiViewName QuickRoleSelectView = new EUiViewName("QuickRoleSelectView");

		// Token: 0x040134C2 RID: 79042
		public static readonly EUiViewName PersonalQuickRoleSelectView = new EUiViewName("PersonalQuickRoleSelectView");

		// Token: 0x040134C3 RID: 79043
		public static readonly EUiViewName TeamRoleSelectWithModelView = new EUiViewName("TeamRoleSelectWithModelView");

		// Token: 0x040134C4 RID: 79044
		public static readonly EUiViewName ShopView = new EUiViewName("ShopView");

		// Token: 0x040134C5 RID: 79045
		public static readonly EUiViewName AreaView = new EUiViewName("AreaView");

		// Token: 0x040134C6 RID: 79046
		public static readonly EUiViewName SubLevelLoadingView = new EUiViewName("SubLevelLoadingView");

		// Token: 0x040134C7 RID: 79047
		public static readonly EUiViewName LoginView = new EUiViewName("LoginView");

		// Token: 0x040134C8 RID: 79048
		public static readonly EUiViewName LoginQueueTipsView = new EUiViewName("LoginQueueTipsView");

		// Token: 0x040134C9 RID: 79049
		public static readonly EUiViewName LoginDebugView = new EUiViewName("LoginDebugView");

		// Token: 0x040134CA RID: 79050
		public static readonly EUiViewName LoginDebugPlayerNameView = new EUiViewName("LoginDebugPlayerNameView");

		// Token: 0x040134CB RID: 79051
		public static readonly EUiViewName ItemTipsView = new EUiViewName("ItemTipsView");

		// Token: 0x040134CC RID: 79052
		public static readonly EUiViewName QuestView = new EUiViewName("QuestView");

		// Token: 0x040134CD RID: 79053
		public static readonly EUiViewName BcView = new EUiViewName("BcView");

		// Token: 0x040134CE RID: 79054
		public static readonly EUiViewName QuestHintView = new EUiViewName("QuestHintView");

		// Token: 0x040134CF RID: 79055
		public static readonly EUiViewName NewItemTipsView = new EUiViewName("NewItemTipsView");

		// Token: 0x040134D0 RID: 79056
		public static readonly EUiViewName PhantomTipsView = new EUiViewName("PhantomTipsView");

		// Token: 0x040134D1 RID: 79057
		public static readonly EUiViewName FunctionView = new EUiViewName("FunctionView");

		// Token: 0x040134D2 RID: 79058
		public static readonly EUiViewName ItemHintView = new EUiViewName("ItemHintView");

		// Token: 0x040134D3 RID: 79059
		public static readonly EUiViewName EditSceneFormationView = new EUiViewName("EditSceneFormationView");

		// Token: 0x040134D4 RID: 79060
		public static readonly EUiViewName Formation2DView = new EUiViewName("Formation2DView");

		// Token: 0x040134D5 RID: 79061
		public static readonly EUiViewName Formation3DView = new EUiViewName("Formation3DView");

		// Token: 0x040134D6 RID: 79062
		public static readonly EUiViewName BattleTeam2DView = new EUiViewName("BattleTeam2DView");

		// Token: 0x040134D7 RID: 79063
		public static readonly EUiViewName FormationEditView = new EUiViewName("FormationEditView");

		// Token: 0x040134D8 RID: 79064
		public static readonly EUiViewName HelpView = new EUiViewName("HelpView");

		// Token: 0x040134D9 RID: 79065
		public static readonly EUiViewName InventoryView = new EUiViewName("InventoryView");

		// Token: 0x040134DA RID: 79066
		public static readonly EUiViewName PhantomManageView = new EUiViewName("PhantomManageView");

		// Token: 0x040134DB RID: 79067
		public static readonly EUiViewName PhantomManageConfigView = new EUiViewName("PhantomManageConfigView");

		// Token: 0x040134DC RID: 79068
		public static readonly EUiViewName PhantomManageConfigSelectView = new EUiViewName("PhantomManageConfigSelectView");

		// Token: 0x040134DD RID: 79069
		public static readonly EUiViewName PhantomManageConfigRenameInputView = new EUiViewName("PhantomManageConfigRenameInputView");

		// Token: 0x040134DE RID: 79070
		public static readonly EUiViewName DestroyPreviewView = new EUiViewName("DestroyPreviewView");

		// Token: 0x040134DF RID: 79071
		public static readonly EUiViewName GuideTipsView = new EUiViewName("GuideTipsView");

		// Token: 0x040134E0 RID: 79072
		public static readonly EUiViewName GuideTutorialView = new EUiViewName("GuideTutorialView");

		// Token: 0x040134E1 RID: 79073
		public static readonly EUiViewName GuideTutorialPopView = new EUiViewName("GuideTutorialPopView");

		// Token: 0x040134E2 RID: 79074
		public static readonly EUiViewName HelpGuideView = new EUiViewName("HelpGuideView");

		// Token: 0x040134E3 RID: 79075
		public static readonly EUiViewName SignalDeviceGuideView = new EUiViewName("SignalDeviceGuideView");

		// Token: 0x040134E4 RID: 79076
		public static readonly EUiViewName GuideFocusView = new EUiViewName("GuideFocusView");

		// Token: 0x040134E5 RID: 79077
		public static readonly EUiViewName GuideTutorialTipsView = new EUiViewName("GuideTutorialTipsView");

		// Token: 0x040134E6 RID: 79078
		public static readonly EUiViewName GmView = new EUiViewName("GmView");

		// Token: 0x040134E7 RID: 79079
		public static readonly EUiViewName ItemRewardView = new EUiViewName("ItemRewardView");

		// Token: 0x040134E8 RID: 79080
		public static readonly EUiViewName MView = new EUiViewName("MView");

		// Token: 0x040134E9 RID: 79081
		public static readonly EUiViewName AchievementRewardItemView = new EUiViewName("AchievementRewardItemView");

		// Token: 0x040134EA RID: 79082
		public static readonly EUiViewName CipherView = new EUiViewName("CipherView");

		// Token: 0x040134EB RID: 79083
		public static readonly EUiViewName TimeTrackControlView = new EUiViewName("TimeTrackControlView");

		// Token: 0x040134EC RID: 79084
		public static readonly EUiViewName PickInteractionView = new EUiViewName("PickInteractionView");

		// Token: 0x040134ED RID: 79085
		public static readonly EUiViewName MazeTipsLoseView = new EUiViewName("MazeTipsLoseView");

		// Token: 0x040134EE RID: 79086
		public static readonly EUiViewName MazeTipsWinView = new EUiViewName("MazeTipsWinView");

		// Token: 0x040134EF RID: 79087
		public static readonly EUiViewName TurntableControlView = new EUiViewName("TurntableControlView");

		// Token: 0x040134F0 RID: 79088
		public static readonly EUiViewName FoxFailureTipsView = new EUiViewName("FoxFailureTipsView");

		// Token: 0x040134F1 RID: 79089
		public static readonly EUiViewName SundialControlView = new EUiViewName("SundialControlView");

		// Token: 0x040134F2 RID: 79090
		public static readonly EUiViewName PlotSubtitleView = new EUiViewName("PlotSubtitleView");

		// Token: 0x040134F3 RID: 79091
		public static readonly EUiViewName SolarSchoolVisualNovelChoiceView = new EUiViewName("SolarSchoolVisualNovelChoiceView");

		// Token: 0x040134F4 RID: 79092
		public static readonly EUiViewName SolarSchoolVisualNovelReviewView = new EUiViewName("SolarSchoolVisualNovelReviewView");

		// Token: 0x040134F5 RID: 79093
		public static readonly EUiViewName SolarSchoolVisualNovelCenterTextView = new EUiViewName("SolarSchoolVisualNovelCenterTextView");

		// Token: 0x040134F6 RID: 79094
		public static readonly EUiViewName PupuVillageItemView = new EUiViewName("PupuVillageItemView");

		// Token: 0x040134F7 RID: 79095
		public static readonly EUiViewName PupuVillageItemViewQIQIU = new EUiViewName("PupuVillageItemViewQIQIU");

		// Token: 0x040134F8 RID: 79096
		public static readonly EUiViewName PlotView = new EUiViewName("PlotView");

		// Token: 0x040134F9 RID: 79097
		public static readonly EUiViewName PlotViewHUD = new EUiViewName("PlotViewHUD");

		// Token: 0x040134FA RID: 79098
		public static readonly EUiViewName PlotGiantSubtitleView = new EUiViewName("PlotGiantSubtitleView");

		// Token: 0x040134FB RID: 79099
		public static readonly EUiViewName PlotTransitionView = new EUiViewName("PlotTransitionView");

		// Token: 0x040134FC RID: 79100
		public static readonly EUiViewName PlotTransitionViewPop = new EUiViewName("PlotTransitionViewPop");

		// Token: 0x040134FD RID: 79101
		public static readonly EUiViewName PlotPhotoView = new EUiViewName("PlotPhotoView");

		// Token: 0x040134FE RID: 79102
		public static readonly EUiViewName PlotLogoView = new EUiViewName("PlotLogoView");

		// Token: 0x040134FF RID: 79103
		public static readonly EUiViewName PlotTipsView = new EUiViewName("PlotTipsView");

		// Token: 0x04013500 RID: 79104
		public static readonly EUiViewName TransitionPopupView = new EUiViewName("TransitionPopupView");

		// Token: 0x04013501 RID: 79105
		public static readonly EUiViewName MusicSubtitleView = new EUiViewName("MusicSubtitleView");

		// Token: 0x04013502 RID: 79106
		public static readonly EUiViewName PlotHintView = new EUiViewName("PlotHintView");

		// Token: 0x04013503 RID: 79107
		public static readonly EUiViewName SummaryPopView = new EUiViewName("SummaryPopView");

		// Token: 0x04013504 RID: 79108
		public static readonly EUiViewName PlotReviewView = new EUiViewName("PlotReviewView");

		// Token: 0x04013505 RID: 79109
		public static readonly EUiViewName AdmissionStudentCardView = new EUiViewName("AdmissionStudentCardView");

		// Token: 0x04013506 RID: 79110
		public static readonly EUiViewName VideoPromptView = new EUiViewName("VideoPromptView");

		// Token: 0x04013507 RID: 79111
		public static readonly EUiViewName NetWorkMaskView = new EUiViewName("NetWorkMaskView");

		// Token: 0x04013508 RID: 79112
		public static readonly EUiViewName PlayStationNetWorkMaskView = new EUiViewName("PlayStationNetWorkMaskView");

		// Token: 0x04013509 RID: 79113
		public static readonly EUiViewName CreateCharacterView = new EUiViewName("CreateCharacterView");

		// Token: 0x0401350A RID: 79114
		public static readonly EUiViewName MingSuView = new EUiViewName("MingSuView");

		// Token: 0x0401350B RID: 79115
		public static readonly EUiViewName WeaponRootView = new EUiViewName("WeaponRootView");

		// Token: 0x0401350C RID: 79116
		public static readonly EUiViewName WeaponReplaceView = new EUiViewName("WeaponReplaceView");

		// Token: 0x0401350D RID: 79117
		public static readonly EUiViewName WeaponBreachSuccessView = new EUiViewName("WeaponBreachSuccessView");

		// Token: 0x0401350E RID: 79118
		public static readonly EUiViewName WeaponResonanceSuccessView = new EUiViewName("WeaponResonanceSuccessView");

		// Token: 0x0401350F RID: 79119
		public static readonly EUiViewName GameplayEnterView = new EUiViewName("GameplayEnterView");

		// Token: 0x04013510 RID: 79120
		public static readonly EUiViewName GameplayFirstPassView = new EUiViewName("GameplayFirstPassView");

		// Token: 0x04013511 RID: 79121
		public static readonly EUiViewName InstanceDungeonEntranceView = new EUiViewName("InstanceDungeonEntranceView");

		// Token: 0x04013512 RID: 79122
		public static readonly EUiViewName TowerDefenseLevelView = new EUiViewName("TowerDefenseLevelView");

		// Token: 0x04013513 RID: 79123
		public static readonly EUiViewName InstanceDungeonVictoryView = new EUiViewName("InstanceDungeonVictoryView");

		// Token: 0x04013514 RID: 79124
		public static readonly EUiViewName InstanceDungeonFailView = new EUiViewName("InstanceDungeonFailView");

		// Token: 0x04013515 RID: 79125
		public static readonly EUiViewName InstanceDungeonReward = new EUiViewName("InstanceDungeonReward");

		// Token: 0x04013516 RID: 79126
		public static readonly EUiViewName InstanceDungeonMonsterPreView = new EUiViewName("InstanceDungeonMonsterPreView");

		// Token: 0x04013517 RID: 79127
		public static readonly EUiViewName InstanceDungeonAreaView = new EUiViewName("InstanceDungeonAreaView");

		// Token: 0x04013518 RID: 79128
		public static readonly EUiViewName InstanceDungeonGuideView = new EUiViewName("InstanceDungeonGuideView");

		// Token: 0x04013519 RID: 79129
		public static readonly EUiViewName LordGymEntranceView = new EUiViewName("LordGymEntranceView");

		// Token: 0x0401351A RID: 79130
		public static readonly EUiViewName LordGymChallengeRecordView = new EUiViewName("LordGymChallengeRecordView");

		// Token: 0x0401351B RID: 79131
		public static readonly EUiViewName LoginStatusView = new EUiViewName("LoginStatusView");

		// Token: 0x0401351C RID: 79132
		public static readonly EUiViewName LoginOfficialStatusView = new EUiViewName("LoginOfficialStatusView");

		// Token: 0x0401351D RID: 79133
		public static readonly EUiViewName PreDownloadView = new EUiViewName("PreDownloadView");

		// Token: 0x0401351E RID: 79134
		public static readonly EUiViewName LordGymDifficultySelectView = new EUiViewName("LordGymDifficultySelectView");

		// Token: 0x0401351F RID: 79135
		public static readonly EUiViewName LordGymLordEntranceSelectView = new EUiViewName("LordGymLordEntranceSelectView");

		// Token: 0x04013520 RID: 79136
		public static readonly EUiViewName LordGymChallengeFailView = new EUiViewName("LordGymChallengeFailView");

		// Token: 0x04013521 RID: 79137
		public static readonly EUiViewName LordGymThirdBossSelectView = new EUiViewName("LordGymThirdBossSelectView");

		// Token: 0x04013522 RID: 79138
		public static readonly EUiViewName LordGymThirdDifficultySelectView = new EUiViewName("LordGymThirdDifficultySelectView");

		// Token: 0x04013523 RID: 79139
		public static readonly EUiViewName LordGymThird5BossSelectView = new EUiViewName("LordGymThird5BossSelectView");

		// Token: 0x04013524 RID: 79140
		public static readonly EUiViewName LordGymThird5DifficultySelectView = new EUiViewName("LordGymThird5DifficultySelectView");

		// Token: 0x04013525 RID: 79141
		public static readonly EUiViewName LordGymThird5LittleLoadingView = new EUiViewName("LordGymThird5LittleLoadingView");

		// Token: 0x04013526 RID: 79142
		public static readonly EUiViewName LordGymLoadingView = new EUiViewName("LordGymLoadingView");

		// Token: 0x04013527 RID: 79143
		public static readonly EUiViewName LordGymThird5LoadingView = new EUiViewName("LordGymThird5LoadingView");

		// Token: 0x04013528 RID: 79144
		public static readonly EUiViewName LordGymFirstBossSelectView = new EUiViewName("LordGymFirstBossSelectView");

		// Token: 0x04013529 RID: 79145
		public static readonly EUiViewName LordGymFirstDifficultySelectView = new EUiViewName("LordGymFirstDifficultySelectView");

		// Token: 0x0401352A RID: 79146
		public static readonly EUiViewName LordGymSecondBossSelectView = new EUiViewName("LordGymSecondBossSelectView");

		// Token: 0x0401352B RID: 79147
		public static readonly EUiViewName LordGymSecondDifficultySelectView = new EUiViewName("LordGymSecondDifficultySelectView");

		// Token: 0x0401352C RID: 79148
		public static readonly EUiViewName AdviceCreateView = new EUiViewName("AdviceCreateView");

		// Token: 0x0401352D RID: 79149
		public static readonly EUiViewName AdviceMotionView = new EUiViewName("AdviceMotionView");

		// Token: 0x0401352E RID: 79150
		public static readonly EUiViewName AdviceRoleView = new EUiViewName("AdviceRoleView");

		// Token: 0x0401352F RID: 79151
		public static readonly EUiViewName AdviceView = new EUiViewName("AdviceView");

		// Token: 0x04013530 RID: 79152
		public static readonly EUiViewName AdviceSortWordView = new EUiViewName("AdviceSortWordView");

		// Token: 0x04013531 RID: 79153
		public static readonly EUiViewName AdviceMutiSentenceSelectView = new EUiViewName("AdviceMutiSentenceSelectView");

		// Token: 0x04013532 RID: 79154
		public static readonly EUiViewName AdviceWordView = new EUiViewName("AdviceWordView");

		// Token: 0x04013533 RID: 79155
		public static readonly EUiViewName AdviceExpressionView = new EUiViewName("AdviceExpressionView");

		// Token: 0x04013534 RID: 79156
		public static readonly EUiViewName AdviceInfoView = new EUiViewName("AdviceInfoView");

		// Token: 0x04013535 RID: 79157
		public static readonly EUiViewName PhantomHandBookView = new EUiViewName("PhantomHandBookView");

		// Token: 0x04013536 RID: 79158
		public static readonly EUiViewName WeaponHandBookView = new EUiViewName("WeaponHandBookView");

		// Token: 0x04013537 RID: 79159
		public static readonly EUiViewName MonsterHandBookView = new EUiViewName("MonsterHandBookView");

		// Token: 0x04013538 RID: 79160
		public static readonly EUiViewName ItemHandBookView = new EUiViewName("ItemHandBookView");

		// Token: 0x04013539 RID: 79161
		public static readonly EUiViewName AnimalHandBookView = new EUiViewName("AnimalHandBookView");

		// Token: 0x0401353A RID: 79162
		public static readonly EUiViewName ChipHandBookView = new EUiViewName("ChipHandBookView");

		// Token: 0x0401353B RID: 79163
		public static readonly EUiViewName NounHandBookView = new EUiViewName("NounHandBookView");

		// Token: 0x0401353C RID: 79164
		public static readonly EUiViewName GeographyHandBookView = new EUiViewName("GeographyHandBookView");

		// Token: 0x0401353D RID: 79165
		public static readonly EUiViewName QuestHandBookView = new EUiViewName("QuestHandBookView");

		// Token: 0x0401353E RID: 79166
		public static readonly EUiViewName HandBookRoleView = new EUiViewName("HandBookRoleView");

		// Token: 0x0401353F RID: 79167
		public static readonly EUiViewName HandBookQuestPlotView = new EUiViewName("HandBookQuestPlotView");

		// Token: 0x04013540 RID: 79168
		public static readonly EUiViewName HandBookPhotoView = new EUiViewName("HandBookPhotoView");

		// Token: 0x04013541 RID: 79169
		public static readonly EUiViewName HandBookEntranceView = new EUiViewName("HandBookEntranceView");

		// Token: 0x04013542 RID: 79170
		public static readonly EUiViewName TeamTeleportFloatTips = new EUiViewName("TeamTeleportFloatTips");

		// Token: 0x04013543 RID: 79171
		public static readonly EUiViewName SceneGameplayItemRewardView = new EUiViewName("SceneGameplayItemRewardView");

		// Token: 0x04013544 RID: 79172
		public static readonly EUiViewName AccessPathPcView = new EUiViewName("AccessPathPcView");

		// Token: 0x04013545 RID: 79173
		public static readonly EUiViewName TapeRootView = new EUiViewName("TapeRootView");

		// Token: 0x04013546 RID: 79174
		public static readonly EUiViewName TapeReplaceView = new EUiViewName("TapeReplaceView");

		// Token: 0x04013547 RID: 79175
		public static readonly EUiViewName PhantomExploreView = new EUiViewName("PhantomExploreView");

		// Token: 0x04013548 RID: 79176
		public static readonly EUiViewName ConfirmBoxView = new EUiViewName("ConfirmBoxView");

		// Token: 0x04013549 RID: 79177
		public static readonly EUiViewName ConfirmBoxMiddleView = new EUiViewName("ConfirmBoxMiddleView");

		// Token: 0x0401354A RID: 79178
		public static readonly EUiViewName ConfirmBoxMiddleWithoutItemView = new EUiViewName("ConfirmBoxMiddleWithoutItemView");

		// Token: 0x0401354B RID: 79179
		public static readonly EUiViewName PowerMagnificationRewardPopView = new EUiViewName("PowerMagnificationRewardPopView");

		// Token: 0x0401354C RID: 79180
		public static readonly EUiViewName VisionLevelUpSettingPopView = new EUiViewName("VisionLevelUpSettingPopView");

		// Token: 0x0401354D RID: 79181
		public static readonly EUiViewName ItemRewardWithMouseView = new EUiViewName("ItemRewardWithMouseView");

		// Token: 0x0401354E RID: 79182
		public static readonly EUiViewName InteractionHintView = new EUiViewName("InteractionHintView");

		// Token: 0x0401354F RID: 79183
		public static readonly EUiViewName VolumeView = new EUiViewName("VolumeView");

		// Token: 0x04013550 RID: 79184
		public static readonly EUiViewName RoguePhantomSelectView = new EUiViewName("RoguePhantomSelectView");

		// Token: 0x04013551 RID: 79185
		public static readonly EUiViewName RoguePhantomReplaceView = new EUiViewName("RoguePhantomReplaceView");

		// Token: 0x04013552 RID: 79186
		public static readonly EUiViewName RoguePhantomSelectResultView = new EUiViewName("RoguePhantomSelectResultView");

		// Token: 0x04013553 RID: 79187
		public static readonly EUiViewName RogueCharacterRoomSelectView = new EUiViewName("RogueCharacterRoomSelectView");

		// Token: 0x04013554 RID: 79188
		public static readonly EUiViewName RoleBuffSelectView = new EUiViewName("RoleBuffSelectView");

		// Token: 0x04013555 RID: 79189
		public static readonly EUiViewName RoleReplaceView = new EUiViewName("RoleReplaceView");

		// Token: 0x04013556 RID: 79190
		public static readonly EUiViewName RogueRoleSelectResultView = new EUiViewName("RogueRoleSelectResultView");

		// Token: 0x04013557 RID: 79191
		public static readonly EUiViewName RoguelikeSkillOverView = new EUiViewName("RoguelikeSkillOverView");

		// Token: 0x04013558 RID: 79192
		public static readonly EUiViewName CommonSelectView = new EUiViewName("CommonSelectView");

		// Token: 0x04013559 RID: 79193
		public static readonly EUiViewName CommonSelectResultView = new EUiViewName("CommonSelectResultView");

		// Token: 0x0401355A RID: 79194
		public static readonly EUiViewName RogueEventResultViewOneByOne = new EUiViewName("RogueEventResultViewOneByOne");

		// Token: 0x0401355B RID: 79195
		public static readonly EUiViewName RogueEventResultViewAll = new EUiViewName("RogueEventResultViewAll");

		// Token: 0x0401355C RID: 79196
		public static readonly EUiViewName WeeklyRoguePhantomRewardView = new EUiViewName("WeeklyRoguePhantomRewardView");

		// Token: 0x0401355D RID: 79197
		public static readonly EUiViewName WeeklyRogueShop = new EUiViewName("WeeklyRogueShop");

		// Token: 0x0401355E RID: 79198
		public static readonly EUiViewName WeeklyRogueActivityView = new EUiViewName("WeeklyRogueActivityView");

		// Token: 0x0401355F RID: 79199
		public static readonly EUiViewName WeeklyRogueSettleView = new EUiViewName("WeeklyRogueSettleView");

		// Token: 0x04013560 RID: 79200
		public static readonly EUiViewName WeeklyRogueSelectToken = new EUiViewName("WeeklyRogueSelectToken");

		// Token: 0x04013561 RID: 79201
		public static readonly EUiViewName WeeklyRogueSelectArtifactView = new EUiViewName("WeeklyRogueSelectArtifactView");

		// Token: 0x04013562 RID: 79202
		public static readonly EUiViewName WeeklyRogueInfo = new EUiViewName("WeeklyRogueInfo");

		// Token: 0x04013563 RID: 79203
		public static readonly EUiViewName WeeklyRogueRewardPreviewView = new EUiViewName("WeeklyRogueRewardPreviewView");

		// Token: 0x04013564 RID: 79204
		public static readonly EUiViewName WeeklyRogueRoleSelectView = new EUiViewName("WeeklyRogueRoleSelectView");

		// Token: 0x04013565 RID: 79205
		public static readonly EUiViewName WeeklyRogueExtraRoomConfirmView = new EUiViewName("WeeklyRogueExtraRoomConfirmView");

		// Token: 0x04013566 RID: 79206
		public static readonly EUiViewName MapRogueMainView = new EUiViewName("MapRogueMainView");

		// Token: 0x04013567 RID: 79207
		public static readonly EUiViewName MapRogueGridTakeView = new EUiViewName("MapRogueGridTakeView");

		// Token: 0x04013568 RID: 79208
		public static readonly EUiViewName MapRogueGridEventView = new EUiViewName("MapRogueGridEventView");

		// Token: 0x04013569 RID: 79209
		public static readonly EUiViewName MapRogueRewardView = new EUiViewName("MapRogueRewardView");

		// Token: 0x0401356A RID: 79210
		public static readonly EUiViewName MapRogueEventStartView = new EUiViewName("MapRogueEventStartView");

		// Token: 0x0401356B RID: 79211
		public static readonly EUiViewName MapRogueFloatTipsAView = new EUiViewName("MapRogueFloatTipsAView");

		// Token: 0x0401356C RID: 79212
		public static readonly EUiViewName MapRogueFloatTipsBView = new EUiViewName("MapRogueFloatTipsBView");

		// Token: 0x0401356D RID: 79213
		public static readonly EUiViewName MapRogueExploreEndView = new EUiViewName("MapRogueExploreEndView");

		// Token: 0x0401356E RID: 79214
		public static readonly EUiViewName RogueBattleMapHelpView = new EUiViewName("RogueBattleMapHelpView");

		// Token: 0x0401356F RID: 79215
		public static readonly EUiViewName MapRogueExploreView = new EUiViewName("MapRogueExploreView");

		// Token: 0x04013570 RID: 79216
		public static readonly EUiViewName RogueBattleTokenSelectResultView = new EUiViewName("RogueBattleTokenSelectResultView");

		// Token: 0x04013571 RID: 79217
		public static readonly EUiViewName PowerView = new EUiViewName("PowerView");

		// Token: 0x04013572 RID: 79218
		public static readonly EUiViewName LevelUpView = new EUiViewName("LevelUpView");

		// Token: 0x04013573 RID: 79219
		public static readonly EUiViewName ResonanceDetailView = new EUiViewName("ResonanceDetailView");

		// Token: 0x04013574 RID: 79220
		public static readonly EUiViewName TimeOfDayView = new EUiViewName("TimeOfDayView");

		// Token: 0x04013575 RID: 79221
		public static readonly EUiViewName TimeOfDayLoadingView = new EUiViewName("TimeOfDayLoadingView");

		// Token: 0x04013576 RID: 79222
		public static readonly EUiViewName ReviveView = new EUiViewName("ReviveView");

		// Token: 0x04013577 RID: 79223
		public static readonly EUiViewName MultiReviveView = new EUiViewName("MultiReviveView");

		// Token: 0x04013578 RID: 79224
		public static readonly EUiViewName TowerDefenceReviveView = new EUiViewName("TowerDefenceReviveView");

		// Token: 0x04013579 RID: 79225
		public static readonly EUiViewName ShareTimesReviveView = new EUiViewName("ShareTimesReviveView");

		// Token: 0x0401357A RID: 79226
		public static readonly EUiViewName WorldLevelUpView = new EUiViewName("WorldLevelUpView");

		// Token: 0x0401357B RID: 79227
		public static readonly EUiViewName WorldLevelInfoView = new EUiViewName("WorldLevelInfoView");

		// Token: 0x0401357C RID: 79228
		public static readonly EUiViewName WorldLevelChangeConfirmView = new EUiViewName("WorldLevelChangeConfirmView");

		// Token: 0x0401357D RID: 79229
		public static readonly EUiViewName GenericPromptView = new EUiViewName("GenericPromptView");

		// Token: 0x0401357E RID: 79230
		public static readonly EUiViewName JoinTeamView = new EUiViewName("JoinTeamView");

		// Token: 0x0401357F RID: 79231
		public static readonly EUiViewName MarqueeView = new EUiViewName("MarqueeView");

		// Token: 0x04013580 RID: 79232
		public static readonly EUiViewName BattleSequenceQteView = new EUiViewName("BattleSequenceQteView");

		// Token: 0x04013581 RID: 79233
		public static readonly EUiViewName DebugView = new EUiViewName("DebugView");

		// Token: 0x04013582 RID: 79234
		public static readonly EUiViewName DebugCommandView = new EUiViewName("DebugCmdView");

		// Token: 0x04013583 RID: 79235
		public static readonly EUiViewName RegionalQuestView = new EUiViewName("RegionalQuestView");

		// Token: 0x04013584 RID: 79236
		public static readonly EUiViewName RegionalQuestRewardView = new EUiViewName("RegionalQuestRewardView");

		// Token: 0x04013585 RID: 79237
		public static readonly EUiViewName UseBuffItemView = new EUiViewName("UseBuffItemView");

		// Token: 0x04013586 RID: 79238
		public static readonly EUiViewName MenuView = new EUiViewName("MenuView");

		// Token: 0x04013587 RID: 79239
		public static readonly EUiViewName PlotCaptionImageView = new EUiViewName("PlotCaptionImageView");

		// Token: 0x04013588 RID: 79240
		public static readonly EUiViewName MenuViewPopView = new EUiViewName("MenuViewPopView");

		// Token: 0x04013589 RID: 79241
		public static readonly EUiViewName CommonKeySettingView = new EUiViewName("CommonKeySettingView");

		// Token: 0x0401358A RID: 79242
		public static readonly EUiViewName RegionContributionLevelView = new EUiViewName("RegionContributionLevelView");

		// Token: 0x0401358B RID: 79243
		public static readonly EUiViewName VideoView = new EUiViewName("VideoView");

		// Token: 0x0401358C RID: 79244
		public static readonly EUiViewName LoginAgeTipView = new EUiViewName("LoginAgeTipView");

		// Token: 0x0401358D RID: 79245
		public static readonly EUiViewName UidView = new EUiViewName("UidView");

		// Token: 0x0401358E RID: 79246
		public static readonly EUiViewName CommonSuccessView = new EUiViewName("CommonSuccessView");

		// Token: 0x0401358F RID: 79247
		public static readonly EUiViewName NetWorkConfirmBoxView = new EUiViewName("NetWorkConfirmBoxView");

		// Token: 0x04013590 RID: 79248
		public static readonly EUiViewName TextLanguageSettingView = new EUiViewName("TextLanguageSettingView");

		// Token: 0x04013591 RID: 79249
		public static readonly EUiViewName VoiceLanguageDownloadView = new EUiViewName("VoiceLanguageDownloadView");

		// Token: 0x04013592 RID: 79250
		public static readonly EUiViewName VoiceLanguageSelectView = new EUiViewName("VoiceLanguageSelectView");

		// Token: 0x04013593 RID: 79251
		public static readonly EUiViewName FriendView = new EUiViewName("FriendView");

		// Token: 0x04013594 RID: 79252
		public static readonly EUiViewName FriendProcessView = new EUiViewName("FriendProcessView");

		// Token: 0x04013595 RID: 79253
		public static readonly EUiViewName OnlineProcessView = new EUiViewName("OnlineProcessView");

		// Token: 0x04013596 RID: 79254
		public static readonly EUiViewName FriendSearchView = new EUiViewName("FriendSearchView");

		// Token: 0x04013597 RID: 79255
		public static readonly EUiViewName FriendBlackListView = new EUiViewName("FriendBlackListView");

		// Token: 0x04013598 RID: 79256
		public static readonly EUiViewName FriendApplyView = new EUiViewName("FriendApplyView");

		// Token: 0x04013599 RID: 79257
		public static readonly EUiViewName FriendMultipleApplyView = new EUiViewName("FriendMultipleApplyView");

		// Token: 0x0401359A RID: 79258
		public static readonly EUiViewName PhantomExploreSetView = new EUiViewName("PhantomExploreSetView");

		// Token: 0x0401359B RID: 79259
		public static readonly EUiViewName SelectedFriendChatView = new EUiViewName("SelectedFriendChatView");

		// Token: 0x0401359C RID: 79260
		public static readonly EUiViewName ChatView = new EUiViewName("ChatView");

		// Token: 0x0401359D RID: 79261
		public static readonly EUiViewName QuickChatView = new EUiViewName("QuickChatView");

		// Token: 0x0401359E RID: 79262
		public static readonly EUiViewName ChatOption = new EUiViewName("ChatOption");

		// Token: 0x0401359F RID: 79263
		public static readonly EUiViewName ChatExpressionView = new EUiViewName("ChatExpressionView");

		// Token: 0x040135A0 RID: 79264
		public static readonly EUiViewName TempShopView = new EUiViewName("TempShopView");

		// Token: 0x040135A1 RID: 79265
		public static readonly EUiViewName OnlineWorldHallView = new EUiViewName("OnlineWorldHallView");

		// Token: 0x040135A2 RID: 79266
		public static readonly EUiViewName OnlineSettingView = new EUiViewName("OnlineSettingView");

		// Token: 0x040135A3 RID: 79267
		public static readonly EUiViewName OnlineWorldSearch = new EUiViewName("OnlineWorldSearchView");

		// Token: 0x040135A4 RID: 79268
		public static readonly EUiViewName OnlineApplyView = new EUiViewName("OnlineApplyView");

		// Token: 0x040135A5 RID: 79269
		public static readonly EUiViewName OnlineMultipleApplyView = new EUiViewName("OnlineMultipleApplyView");

		// Token: 0x040135A6 RID: 79270
		public static readonly EUiViewName OnlineChallengeApplyView = new EUiViewName("OnlineChallengeApplyView");

		// Token: 0x040135A7 RID: 79271
		public static readonly EUiViewName OnlineMatchSuccessView = new EUiViewName("OnlineMatchSuccessView");

		// Token: 0x040135A8 RID: 79272
		public static readonly EUiViewName OnlineChallengeStateView = new EUiViewName("OnlineChallengeStateView");

		// Token: 0x040135A9 RID: 79273
		public static readonly EUiViewName OnlineInstanceMatchTips = new EUiViewName("OnlineInstanceMatchTips");

		// Token: 0x040135AA RID: 79274
		public static readonly EUiViewName PayShopRootView = new EUiViewName("PayShopRootView");

		// Token: 0x040135AB RID: 79275
		public static readonly EUiViewName GiftPackageDetailsView = new EUiViewName("GiftPackageDetailsView");

		// Token: 0x040135AC RID: 79276
		public static readonly EUiViewName CommonExchangeView = new EUiViewName("CommonExchangeView");

		// Token: 0x040135AD RID: 79277
		public static readonly EUiViewName GachaMainView = new EUiViewName("GachaMainView");

		// Token: 0x040135AE RID: 79278
		public static readonly EUiViewName GachaResultView = new EUiViewName("GachaResultView");

		// Token: 0x040135AF RID: 79279
		public static readonly EUiViewName GachaScanView = new EUiViewName("GachaScanView");

		// Token: 0x040135B0 RID: 79280
		public static readonly EUiViewName GachaSelectionView = new EUiViewName("GachaSelectionView");

		// Token: 0x040135B1 RID: 79281
		public static readonly EUiViewName CalabashRootView = new EUiViewName("CalabashRootView");

		// Token: 0x040135B2 RID: 79282
		public static readonly EUiViewName VisionDirectionalFusionSelectTargetView = new EUiViewName("VisionDirectionalFusionSelectTargetView");

		// Token: 0x040135B3 RID: 79283
		public static readonly EUiViewName CalabashUpgradeSuccessView = new EUiViewName("CalabashUpgradeSuccessView");

		// Token: 0x040135B4 RID: 79284
		public static readonly EUiViewName PhantomBattleFettersView = new EUiViewName("PhantomBattleFettersView");

		// Token: 0x040135B5 RID: 79285
		public static readonly EUiViewName PhantomBattleEquipView = new EUiViewName("PhantomBattleEquipView");

		// Token: 0x040135B6 RID: 79286
		public static readonly EUiViewName PhantomManagerConfigSharePopItem = new EUiViewName("PhantomManagerConfigSharePopItem");

		// Token: 0x040135B7 RID: 79287
		public static readonly EUiViewName PhantomManagerConfigResetPopItem = new EUiViewName("PhantomManagerConfigResetPopItem");

		// Token: 0x040135B8 RID: 79288
		public static readonly EUiViewName PhantomManagerConfigRemovePopItem = new EUiViewName("PhantomManagerConfigRemovePopItem");

		// Token: 0x040135B9 RID: 79289
		public static readonly EUiViewName PhantomManagerConfigEditPopItem = new EUiViewName("PhantomManagerConfigEditPopItem");

		// Token: 0x040135BA RID: 79290
		public static readonly EUiViewName TimeOfDaySecondView = new EUiViewName("TimeOfDaySecondView");

		// Token: 0x040135BB RID: 79291
		public static readonly EUiViewName ExchangePopView = new EUiViewName("ExchangePopView");

		// Token: 0x040135BC RID: 79292
		public static readonly EUiViewName GameplayExchangePopView = new EUiViewName("GameplayExchangePopView");

		// Token: 0x040135BD RID: 79293
		public static readonly EUiViewName TutorialView = new EUiViewName("TutorialView");

		// Token: 0x040135BE RID: 79294
		public static readonly EUiViewName TutorialPopView = new EUiViewName("TutorialPopView");

		// Token: 0x040135BF RID: 79295
		public static readonly EUiViewName AdventureGuideView = new EUiViewName("AdventureGuideView");

		// Token: 0x040135C0 RID: 79296
		public static readonly EUiViewName AcquireView = new EUiViewName("AcquireView");

		// Token: 0x040135C1 RID: 79297
		public static readonly EUiViewName InventoryGiftView = new EUiViewName("InventoryGiftView");

		// Token: 0x040135C2 RID: 79298
		public static readonly EUiViewName InfoDisplayImgView = new EUiViewName("InfoDisplayImgView");

		// Token: 0x040135C3 RID: 79299
		public static readonly EUiViewName InfoDisplayTypeOneView = new EUiViewName("InfoDisplayTypeOneView");

		// Token: 0x040135C4 RID: 79300
		public static readonly EUiViewName InfoDisplayTypeTwoView = new EUiViewName("InfoDisplayTypeTwoView");

		// Token: 0x040135C5 RID: 79301
		public static readonly EUiViewName InfoDisplayTypeThreeView = new EUiViewName("InfoDisplayTypeThreeView");

		// Token: 0x040135C6 RID: 79302
		public static readonly EUiViewName InfoDisplayTypeFourView = new EUiViewName("InfoDisplayTypeFourView");

		// Token: 0x040135C7 RID: 79303
		public static readonly EUiViewName InfoDisplayTypeFourNewView = new EUiViewName("InfoDisplayTypeFourNewView");

		// Token: 0x040135C8 RID: 79304
		public static readonly EUiViewName InfoDisplayTypeFiveView = new EUiViewName("InfoDisplayTypeFiveView");

		// Token: 0x040135C9 RID: 79305
		public static readonly EUiViewName InfoDisplayAttachmentBigImgView = new EUiViewName("InfoDisplayAttachmentBigImgView");

		// Token: 0x040135CA RID: 79306
		public static readonly EUiViewName WeaponPreviewView = new EUiViewName("WeaponPreviewView");

		// Token: 0x040135CB RID: 79307
		public static readonly EUiViewName MonthCardView = new EUiViewName("MonthCardView");

		// Token: 0x040135CC RID: 79308
		public static readonly EUiViewName MonthCardRewardView = new EUiViewName("MonthCardRewardView");

		// Token: 0x040135CD RID: 79309
		public static readonly EUiViewName AttributeView = new EUiViewName("AttributeView");

		// Token: 0x040135CE RID: 79310
		public static readonly EUiViewName RoleAttributeDetailView = new EUiViewName("RoleAttributeDetailView");

		// Token: 0x040135CF RID: 79311
		public static readonly EUiViewName SkillLevelUpView = new EUiViewName("SkillLevelUpView");

		// Token: 0x040135D0 RID: 79312
		public static readonly EUiViewName RoleSkillTreeInfoView = new EUiViewName("RoleSkillTreeInfoView");

		// Token: 0x040135D1 RID: 79313
		public static readonly EUiViewName RoleSkillInputView = new EUiViewName("RoleSkillInputView");

		// Token: 0x040135D2 RID: 79314
		public static readonly EUiViewName RoleQuestView = new EUiViewName("RoleQuestView");

		// Token: 0x040135D3 RID: 79315
		public static readonly EUiViewName ReportView = new EUiViewName("ReportView");

		// Token: 0x040135D4 RID: 79316
		public static readonly EUiViewName CookRootView = new EUiViewName("CookRootView");

		// Token: 0x040135D5 RID: 79317
		public static readonly EUiViewName CookLevelView = new EUiViewName("CookLevelView");

		// Token: 0x040135D6 RID: 79318
		public static readonly EUiViewName CookRoleView = new EUiViewName("CookRoleView");

		// Token: 0x040135D7 RID: 79319
		public static readonly EUiViewName CookPopView = new EUiViewName("CookPopView");

		// Token: 0x040135D8 RID: 79320
		public static readonly EUiViewName CookSuccessView = new EUiViewName("CookSuccessView");

		// Token: 0x040135D9 RID: 79321
		public static readonly EUiViewName RoleFavorInfoView = new EUiViewName("RoleFavorInfoView");

		// Token: 0x040135DA RID: 79322
		public static readonly EUiViewName RoleFavorHintView = new EUiViewName("RoleFavorHintView");

		// Token: 0x040135DB RID: 79323
		public static readonly EUiViewName RoleLangCustomView = new EUiViewName("RoleLangCustomView");

		// Token: 0x040135DC RID: 79324
		public static readonly EUiViewName RoleLangRemoveView = new EUiViewName("RoleLangRemoveView");

		// Token: 0x040135DD RID: 79325
		public static readonly EUiViewName RoleLangNetConfirmPop = new EUiViewName("RoleLangNetConfirmPop");

		// Token: 0x040135DE RID: 79326
		public static readonly EUiViewName RoleGiftSplashView = new EUiViewName("RoleGiftSplashView");

		// Token: 0x040135DF RID: 79327
		public static readonly EUiViewName FunctionOpenView = new EUiViewName("FunctionOpenView");

		// Token: 0x040135E0 RID: 79328
		public static readonly EUiViewName CookPopFixView = new EUiViewName("CookPopFixView");

		// Token: 0x040135E1 RID: 79329
		public static readonly EUiViewName SingleTimeTowerView = new EUiViewName("SingleTimeTowerView");

		// Token: 0x040135E2 RID: 79330
		public static readonly EUiViewName SingleTimeTowerChallengeView = new EUiViewName("SingleTimeTowerChallengeView");

		// Token: 0x040135E3 RID: 79331
		public static readonly EUiViewName SingleTimeTowerTeamView = new EUiViewName("SingleTimeTowerTeamView");

		// Token: 0x040135E4 RID: 79332
		public static readonly EUiViewName SingleTimeTowerDetailView = new EUiViewName("SingleTimeTowerDetailView");

		// Token: 0x040135E5 RID: 79333
		public static readonly EUiViewName SingleTimeTowerVictoryView = new EUiViewName("SingleTimeTowerVictoryView");

		// Token: 0x040135E6 RID: 79334
		public static readonly EUiViewName SingleTimeTowerFailView = new EUiViewName("SingleTimeTowerFailView");

		// Token: 0x040135E7 RID: 79335
		public static readonly EUiViewName TowerRewardView = new EUiViewName("TowerRewardView");

		// Token: 0x040135E8 RID: 79336
		public static readonly EUiViewName TowerApplyFloorDataView = new EUiViewName("TowerApplyFloorDataView");

		// Token: 0x040135E9 RID: 79337
		public static readonly EUiViewName TowerNormalView = new EUiViewName("TowerNormalView");

		// Token: 0x040135EA RID: 79338
		public static readonly EUiViewName TowerFloorView = new EUiViewName("TowerFloorView");

		// Token: 0x040135EB RID: 79339
		public static readonly EUiViewName TowerVariationView = new EUiViewName("TowerVariationView");

		// Token: 0x040135EC RID: 79340
		public static readonly EUiViewName TowerResetView = new EUiViewName("TowerResetView");

		// Token: 0x040135ED RID: 79341
		public static readonly EUiViewName TowerRecommendView = new EUiViewName("TowerRecommendView");

		// Token: 0x040135EE RID: 79342
		public static readonly EUiViewName TowerReviewView = new EUiViewName("TowerReviewView");

		// Token: 0x040135EF RID: 79343
		public static readonly EUiViewName TowerFloorDetailView = new EUiViewName("TowerFloorDetailView");

		// Token: 0x040135F0 RID: 79344
		public static readonly EUiViewName TowerGuideView = new EUiViewName("TowerGuideView");

		// Token: 0x040135F1 RID: 79345
		public static readonly EUiViewName TowerUnlockView = new EUiViewName("TowerUnlockView");

		// Token: 0x040135F2 RID: 79346
		public static readonly EUiViewName TowerChallengeFormationView = new EUiViewName("TowerChallengeFormationView");

		// Token: 0x040135F3 RID: 79347
		public static readonly EUiViewName TowerOverLockUnlockView = new EUiViewName("TowerOverLockUnlockView");

		// Token: 0x040135F4 RID: 79348
		public static readonly EUiViewName EventConditionFloatTips = new EUiViewName("EventConditionFloatTips");

		// Token: 0x040135F5 RID: 79349
		public static readonly EUiViewName ChallengeAchieveFloatTips = new EUiViewName("ChallengeAchieveFloatTips");

		// Token: 0x040135F6 RID: 79350
		public static readonly EUiViewName ChallengeWantedAchieveFloatTips = new EUiViewName("ChallengeWantedAchieveFloatTips");

		// Token: 0x040135F7 RID: 79351
		public static readonly EUiViewName ChallengeSuccessFloatTips = new EUiViewName("ChallengeSuccessFloatTips");

		// Token: 0x040135F8 RID: 79352
		public static readonly EUiViewName ChallengeFailedFloatTips = new EUiViewName("ChallengeFailedFloatTips");

		// Token: 0x040135F9 RID: 79353
		public static readonly EUiViewName AdditionalTasksFloatTips = new EUiViewName("AdditionalTasksFloatTips");

		// Token: 0x040135FA RID: 79354
		public static readonly EUiViewName DelegateCompletionFloatTips = new EUiViewName("DelegateCompletionFloatTips");

		// Token: 0x040135FB RID: 79355
		public static readonly EUiViewName CountDownFloatTips = new EUiViewName("CountDownFloatTips");

		// Token: 0x040135FC RID: 79356
		public static readonly EUiViewName CountDownChallenge = new EUiViewName("CountDownChallenge");

		// Token: 0x040135FD RID: 79357
		public static readonly EUiViewName UnOpenedAreaCountDownFloatTips = new EUiViewName("UnOpenedAreaCountDownFloatTips");

		// Token: 0x040135FE RID: 79358
		public static readonly EUiViewName LevelGamePlayPrepareCountDown = new EUiViewName("LevelGamePlayPrepareCountDown");

		// Token: 0x040135FF RID: 79359
		public static readonly EUiViewName LevelGamePlayMotorPrepareCountDown = new EUiViewName("LevelGamePlayMotorPrepareCountDown");

		// Token: 0x04013600 RID: 79360
		public static readonly EUiViewName PunishReportView = new EUiViewName("PunishReportView");

		// Token: 0x04013601 RID: 79361
		public static readonly EUiViewName PunishReportSettlementView = new EUiViewName("PunishReportSettlementView");

		// Token: 0x04013602 RID: 79362
		public static readonly EUiViewName DungeonClearanceFloatTips = new EUiViewName("DungeonClearanceFloatTips");

		// Token: 0x04013603 RID: 79363
		public static readonly EUiViewName DungeonAutoExitFloatTips = new EUiViewName("DungeonAutoExitFloatTips");

		// Token: 0x04013604 RID: 79364
		public static readonly EUiViewName ChapterEndFloatTips = new EUiViewName("ChapterEndFloatTips");

		// Token: 0x04013605 RID: 79365
		public static readonly EUiViewName FlowChapterStartTips = new EUiViewName("FlowChapterStartTips");

		// Token: 0x04013606 RID: 79366
		public static readonly EUiViewName FlowChapterEndTips = new EUiViewName("FlowChapterEndTips");

		// Token: 0x04013607 RID: 79367
		public static readonly EUiViewName ChapterBattleDeclarationTipsRed = new EUiViewName("ChapterBattleDeclarationTipsRed");

		// Token: 0x04013608 RID: 79368
		public static readonly EUiViewName ChapterBattleDeclarationTipsWhite = new EUiViewName("ChapterBattleDeclarationTipsWhite");

		// Token: 0x04013609 RID: 79369
		public static readonly EUiViewName ChapterStartFloatTips = new EUiViewName("ChapterStartFloatTips");

		// Token: 0x0401360A RID: 79370
		public static readonly EUiViewName DailyTaskEndTips = new EUiViewName("DailyTaskEndTips");

		// Token: 0x0401360B RID: 79371
		public static readonly EUiViewName TaskEndTips = new EUiViewName("TaskEndTips");

		// Token: 0x0401360C RID: 79372
		public static readonly EUiViewName PrepareCountdownFloatTips = new EUiViewName("PrepareCountdownFloatTips");

		// Token: 0x0401360D RID: 79373
		public static readonly EUiViewName ComboTeachingFloatTips = new EUiViewName("ComboTeachingFloatTips");

		// Token: 0x0401360E RID: 79374
		public static readonly EUiViewName InfluenceReputationView = new EUiViewName("InfluenceReputationView");

		// Token: 0x0401360F RID: 79375
		public static readonly EUiViewName InfluenceAreaSelectView = new EUiViewName("InfluenceAreaSelectView");

		// Token: 0x04013610 RID: 79376
		public static readonly EUiViewName ReputationDetailsView = new EUiViewName("ReputationDetailsView");

		// Token: 0x04013611 RID: 79377
		public static readonly EUiViewName ReputationTips = new EUiViewName("ReputationTips");

		// Token: 0x04013612 RID: 79378
		public static readonly EUiViewName ReputationRewardsView = new EUiViewName("ReputationRewardsView");

		// Token: 0x04013613 RID: 79379
		public static readonly EUiViewName InfluenceSearchView = new EUiViewName("InfluenceSearchView");

		// Token: 0x04013614 RID: 79380
		public static readonly EUiViewName CycleTowerView = new EUiViewName("CycleTowerView");

		// Token: 0x04013615 RID: 79381
		public static readonly EUiViewName CycleTowerChallengeView = new EUiViewName("CycleTowerChallengeView");

		// Token: 0x04013616 RID: 79382
		public static readonly EUiViewName CycleTowerTeamView = new EUiViewName("CycleTowerTeamView");

		// Token: 0x04013617 RID: 79383
		public static readonly EUiViewName CycleTowerDetailView = new EUiViewName("CycleTowerDetailView");

		// Token: 0x04013618 RID: 79384
		public static readonly EUiViewName CycleTowerRewardView = new EUiViewName("CycleTowerRewardView");

		// Token: 0x04013619 RID: 79385
		public static readonly EUiViewName CycleTowerSeasonRewardView = new EUiViewName("CycleTowerSeasonRewardView");

		// Token: 0x0401361A RID: 79386
		public static readonly EUiViewName CycleTowerClearInfoView = new EUiViewName("CycleTowerClearInfoView");

		// Token: 0x0401361B RID: 79387
		public static readonly EUiViewName CycleTowerSeasonInfoView = new EUiViewName("CycleTowerSeasonInfoView");

		// Token: 0x0401361C RID: 79388
		public static readonly EUiViewName TowerDetailView = new EUiViewName("TowerDetailView");

		// Token: 0x0401361D RID: 79389
		public static readonly EUiViewName BattlePassMainView = new EUiViewName("BattlePassMainView");

		// Token: 0x0401361E RID: 79390
		public static readonly EUiViewName BattlePassBuyLevelView = new EUiViewName("BattlePassBuyLevelView");

		// Token: 0x0401361F RID: 79391
		public static readonly EUiViewName BattlePassPayView = new EUiViewName("BattlePassPayView");

		// Token: 0x04013620 RID: 79392
		public static readonly EUiViewName BattlePassUnlockView = new EUiViewName("BattlePassUnlockView");

		// Token: 0x04013621 RID: 79393
		public static readonly EUiViewName BattlePassUpLevelView = new EUiViewName("BattlePassUpLevelView");

		// Token: 0x04013622 RID: 79394
		public static readonly EUiViewName BattlePassFirstOpenView = new EUiViewName("BattlePassFirstOpenView");

		// Token: 0x04013623 RID: 79395
		public static readonly EUiViewName DrawMainView = new EUiViewName("DrawMainView");

		// Token: 0x04013624 RID: 79396
		public static readonly EUiViewName PhonographView = new EUiViewName("PhonographView");

		// Token: 0x04013625 RID: 79397
		public static readonly EUiViewName PhonographNewMusicView = new EUiViewName("PhonographNewMusicView");

		// Token: 0x04013626 RID: 79398
		public static readonly EUiViewName RoleHandBookRootView = new EUiViewName("RoleHandBookRootView");

		// Token: 0x04013627 RID: 79399
		public static readonly EUiViewName RoleHandBookSelectionView = new EUiViewName("RoleHandBookSelectionView");

		// Token: 0x04013628 RID: 79400
		public static readonly EUiViewName ComposeRootView = new EUiViewName("ComposeRootView");

		// Token: 0x04013629 RID: 79401
		public static readonly EUiViewName ComposeLevelView = new EUiViewName("ComposeLevelView");

		// Token: 0x0401362A RID: 79402
		public static readonly EUiViewName ManufactureHelpRoleView = new EUiViewName("ManufactureHelpRoleView");

		// Token: 0x0401362B RID: 79403
		public static readonly EUiViewName ForgingRootView = new EUiViewName("ForgingRootView");

		// Token: 0x0401362C RID: 79404
		public static readonly EUiViewName RewardPopView = new EUiViewName("RewardPopView");

		// Token: 0x0401362D RID: 79405
		public static readonly EUiViewName ResolutionListView = new EUiViewName("ResolutionListView");

		// Token: 0x0401362E RID: 79406
		public static readonly EUiViewName BrightnessView = new EUiViewName("BrightnessView");

		// Token: 0x0401362F RID: 79407
		public static readonly EUiViewName LogUploadView = new EUiViewName("LogUploadView");

		// Token: 0x04013630 RID: 79408
		public static readonly EUiViewName ToolWindowView = new EUiViewName("ToolWindowView");

		// Token: 0x04013631 RID: 79409
		public static readonly EUiViewName VulkanSetView = new EUiViewName("VulkanSetView");

		// Token: 0x04013632 RID: 79410
		public static readonly EUiViewName PhotographView = new EUiViewName("PhotographView");

		// Token: 0x04013633 RID: 79411
		public static readonly EUiViewName PhotographSetupView = new EUiViewName("PhotographSetupView");

		// Token: 0x04013634 RID: 79412
		public static readonly EUiViewName PhotoSaveView = new EUiViewName("PhotoSaveView");

		// Token: 0x04013635 RID: 79413
		public static readonly EUiViewName FightPhotographView = new EUiViewName("FightPhotographView");

		// Token: 0x04013636 RID: 79414
		public static readonly EUiViewName FightPhotoResultView = new EUiViewName("FightPhotoResultView");

		// Token: 0x04013637 RID: 79415
		public static readonly EUiViewName FightPhotoRewardView = new EUiViewName("FightPhotoRewardView");

		// Token: 0x04013638 RID: 79416
		public static readonly EUiViewName FightPhotoMainView = new EUiViewName("FightPhotoMainView");

		// Token: 0x04013639 RID: 79417
		public static readonly EUiViewName FightPhotoUnlockTipView = new EUiViewName("FightPhotoUnlockTipView");

		// Token: 0x0401363A RID: 79418
		public static readonly EUiViewName FightPhotoEventTipView = new EUiViewName("FightPhotoEventTipView");

		// Token: 0x0401363B RID: 79419
		public static readonly EUiViewName FightPhotoFocusView = new EUiViewName("FightPhotoFocusView");

		// Token: 0x0401363C RID: 79420
		public static readonly EUiViewName FightPhotoLoadingView = new EUiViewName("FightPhotoLoadingView");

		// Token: 0x0401363D RID: 79421
		public static readonly EUiViewName FightPhotoSaveView = new EUiViewName("FightPhotoSaveView");

		// Token: 0x0401363E RID: 79422
		public static readonly EUiViewName CaptureCollectView = new EUiViewName("CaptureCollectView");

		// Token: 0x0401363F RID: 79423
		public static readonly EUiViewName PhotoCameraView = new EUiViewName("PhotoCameraView");

		// Token: 0x04013640 RID: 79424
		public static readonly EUiViewName PhotoMainView = new EUiViewName("PhotoMainView");

		// Token: 0x04013641 RID: 79425
		public static readonly EUiViewName UseReviveItemView = new EUiViewName("UseReviveItemView");

		// Token: 0x04013642 RID: 79426
		public static readonly EUiViewName PhantomBattleSkillInfoView = new EUiViewName("PhantomBattleSkillInfoView");

		// Token: 0x04013643 RID: 79427
		public static readonly EUiViewName PhantomBattleFettersObtainView = new EUiViewName("PhantomBattleFettersObtainView");

		// Token: 0x04013644 RID: 79428
		public static readonly EUiViewName CalabashUnlockItemView = new EUiViewName("CalabashUnlockItemView");

		// Token: 0x04013645 RID: 79429
		public static readonly EUiViewName PhantomDecomposeView = new EUiViewName("PhantomBattleDecomposeView");

		// Token: 0x04013646 RID: 79430
		public static readonly EUiViewName BattleUiSetView = new EUiViewName("BattleUiSetView");

		// Token: 0x04013647 RID: 79431
		public static readonly EUiViewName AchievementMainView = new EUiViewName("AchievementMainView");

		// Token: 0x04013648 RID: 79432
		public static readonly EUiViewName AchievementDetailView = new EUiViewName("AchievementDetailView");

		// Token: 0x04013649 RID: 79433
		public static readonly EUiViewName AchievementFinishView = new EUiViewName("AchievementFinishView");

		// Token: 0x0401364A RID: 79434
		public static readonly EUiViewName AchievementCompleteTipsView = new EUiViewName("AchievementCompleteTipsView");

		// Token: 0x0401364B RID: 79435
		public static readonly EUiViewName ExploreProgressView = new EUiViewName("ExploreProgressView");

		// Token: 0x0401364C RID: 79436
		public static readonly EUiViewName RoleBreachSuccessView = new EUiViewName("RoleBreachSuccessView");

		// Token: 0x0401364D RID: 79437
		public static readonly EUiViewName LoginServerView = new EUiViewName("LoginServerView");

		// Token: 0x0401364E RID: 79438
		public static readonly EUiViewName RoleGenderChangeView = new EUiViewName("RoleGenderChangeView");

		// Token: 0x0401364F RID: 79439
		public static readonly EUiViewName RoleElementView = new EUiViewName("RoleElementView");

		// Token: 0x04013650 RID: 79440
		public static readonly EUiViewName ComboTeachingView = new EUiViewName("ComboTeachingView");

		// Token: 0x04013651 RID: 79441
		public static readonly EUiViewName PersonalRootView = new EUiViewName("PersonalRootView");

		// Token: 0x04013652 RID: 79442
		public static readonly EUiViewName PersonalOptionView = new EUiViewName("PersonalOptionView");

		// Token: 0x04013653 RID: 79443
		public static readonly EUiViewName PersonalBirthView = new EUiViewName("PersonalBirthView");

		// Token: 0x04013654 RID: 79444
		public static readonly EUiViewName PersonalEditView = new EUiViewName("PersonalEditView");

		// Token: 0x04013655 RID: 79445
		public static readonly EUiViewName FrozenQteView = new EUiViewName("FrozenQteView");

		// Token: 0x04013656 RID: 79446
		public static readonly EUiViewName InteractQteView = new EUiViewName("InteractQteView");

		// Token: 0x04013657 RID: 79447
		public static readonly EUiViewName YouHuQteView = new EUiViewName("YouHuQteView");

		// Token: 0x04013658 RID: 79448
		public static readonly EUiViewName XiaKongQteView = new EUiViewName("XiaKongQteView");

		// Token: 0x04013659 RID: 79449
		public static readonly EUiViewName FreeRunningQteView = new EUiViewName("FreeRunningQteView");

		// Token: 0x0401365A RID: 79450
		public static readonly EUiViewName CommonQteView = new EUiViewName("CommonQteView");

		// Token: 0x0401365B RID: 79451
		public static readonly EUiViewName CommonQteNoIconView = new EUiViewName("CommonQteNoIconView");

		// Token: 0x0401365C RID: 79452
		public static readonly EUiViewName CommonQteContinuousClickView = new EUiViewName("CommonQteContinuousClickView");

		// Token: 0x0401365D RID: 79453
		public static readonly EUiViewName CommonQteLongPressView = new EUiViewName("CommonQteLongPressView");

		// Token: 0x0401365E RID: 79454
		public static readonly EUiViewName CommonQteNoIconLongPressView = new EUiViewName("CommonQteNoIconLongPressView");

		// Token: 0x0401365F RID: 79455
		public static readonly EUiViewName QtaView = new EUiViewName("QtaView");

		// Token: 0x04013660 RID: 79456
		public static readonly EUiViewName PersonalRoleShowView = new EUiViewName("PersonalRoleShowView");

		// Token: 0x04013661 RID: 79457
		public static readonly EUiViewName PersonalCardView = new EUiViewName("PersonalCardView");

		// Token: 0x04013662 RID: 79458
		public static readonly EUiViewName CommonActivityView = new EUiViewName("CommonActivityView");

		// Token: 0x04013663 RID: 79459
		public static readonly EUiViewName ActivityRewardPopUpView = new EUiViewName("ActivityRewardPopUpView");

		// Token: 0x04013664 RID: 79460
		public static readonly EUiViewName LongShanUnlockView = new EUiViewName("LongShanUnlockView");

		// Token: 0x04013665 RID: 79461
		public static readonly EUiViewName ActivityRunView = new EUiViewName("ActivityRunView");

		// Token: 0x04013666 RID: 79462
		public static readonly EUiViewName ActivityRunSuccessView = new EUiViewName("ActivityRunSuccessView");

		// Token: 0x04013667 RID: 79463
		public static readonly EUiViewName ActivityRunFailView = new EUiViewName("ActivityRunFailView");

		// Token: 0x04013668 RID: 79464
		public static readonly EUiViewName BossRushMainView = new EUiViewName("BossRushMainView");

		// Token: 0x04013669 RID: 79465
		public static readonly EUiViewName BossRushBuffInGameView = new EUiViewName("BossRushBuffInGameView");

		// Token: 0x0401366A RID: 79466
		public static readonly EUiViewName ActivityTurntableRewardView = new EUiViewName("ActivityTurntableRewardView");

		// Token: 0x0401366B RID: 79467
		public static readonly EUiViewName ActivityUnlockTipView = new EUiViewName("ActivityUnlockTipView");

		// Token: 0x0401366C RID: 79468
		public static readonly EUiViewName TowerDefensePhantomView = new EUiViewName("TowerDefensePhantomView");

		// Token: 0x0401366D RID: 79469
		public static readonly EUiViewName ActivityUnlockTipMoonChasingView = new EUiViewName("ActivityUnlockTipMoonChasingView");

		// Token: 0x0401366E RID: 79470
		public static readonly EUiViewName CorniceMeetingMainView = new EUiViewName("CorniceMeetingMainView");

		// Token: 0x0401366F RID: 79471
		public static readonly EUiViewName ActivityConditionView = new EUiViewName("ActivityConditionView");

		// Token: 0x04013670 RID: 79472
		public static readonly EUiViewName CommonConditionView = new EUiViewName("CommonConditionView");

		// Token: 0x04013671 RID: 79473
		public static readonly EUiViewName BlackCoastActivityMainView = new EUiViewName("BlackCoastActivityMainView");

		// Token: 0x04013672 RID: 79474
		public static readonly EUiViewName BlackCoastActivityTaskView = new EUiViewName("BlackCoastActivityTaskView");

		// Token: 0x04013673 RID: 79475
		public static readonly EUiViewName ActivityUnlockTipBlackCoastView = new EUiViewName("ActivityUnlockTipBlackCoastView");

		// Token: 0x04013674 RID: 79476
		public static readonly EUiViewName ActivityUnlockTipDreamLinkView = new EUiViewName("ActivityUnlockTipDreamLinkView");

		// Token: 0x04013675 RID: 79477
		public static readonly EUiViewName DreamLinkWhiteCatSettleView = new EUiViewName("DreamLinkWhiteCatSettleView");

		// Token: 0x04013676 RID: 79478
		public static readonly EUiViewName ActivityInstanceEntranceView = new EUiViewName("ActivityInstanceEntranceView");

		// Token: 0x04013677 RID: 79479
		public static readonly EUiViewName CommonRewardView = new EUiViewName("CommonRewardView");

		// Token: 0x04013678 RID: 79480
		public static readonly EUiViewName PayRewardView = new EUiViewName("PayRewardView");

		// Token: 0x04013679 RID: 79481
		public static readonly EUiViewName RoleIntroductionView = new EUiViewName("RoleIntroductionView");

		// Token: 0x0401367A RID: 79482
		public static readonly EUiViewName QuestRewardView = new EUiViewName("QuestRewardView");

		// Token: 0x0401367B RID: 79483
		public static readonly EUiViewName CompositeRewardView = new EUiViewName("CompositeRewardView");

		// Token: 0x0401367C RID: 79484
		public static readonly EUiViewName ExploreRewardView = new EUiViewName("ExploreRewardView");

		// Token: 0x0401367D RID: 79485
		public static readonly EUiViewName ExploreLevelRewardView = new EUiViewName("ExploreLevelRewardView");

		// Token: 0x0401367E RID: 79486
		public static readonly EUiViewName BattlePassExtraRewardView = new EUiViewName("BattlePassExtraRewardView");

		// Token: 0x0401367F RID: 79487
		public static readonly EUiViewName CommunicateView = new EUiViewName("CommunicateView");

		// Token: 0x04013680 RID: 79488
		public static readonly EUiViewName FilterView = new EUiViewName("FilterView");

		// Token: 0x04013681 RID: 79489
		public static readonly EUiViewName VisionFilterView = new EUiViewName("VisionFilterView");

		// Token: 0x04013682 RID: 79490
		public static readonly EUiViewName SortView = new EUiViewName("SortView");

		// Token: 0x04013683 RID: 79491
		public static readonly EUiViewName CommonItemSelectViewLeft = new EUiViewName("CommonItemSelectViewLeft");

		// Token: 0x04013684 RID: 79492
		public static readonly EUiViewName CommonItemSelectViewRight = new EUiViewName("CommonItemSelectViewRight");

		// Token: 0x04013685 RID: 79493
		public static readonly EUiViewName VisionEquipmentView = new EUiViewName("VisionEquipmentView");

		// Token: 0x04013686 RID: 79494
		public static readonly EUiViewName VisionLevelUpView = new EUiViewName("VisionLevelUpView");

		// Token: 0x04013687 RID: 79495
		public static readonly EUiViewName VisionSlotView = new EUiViewName("VisionSlotView");

		// Token: 0x04013688 RID: 79496
		public static readonly EUiViewName VisionIntensifyView = new EUiViewName("VisionIntensifyView");

		// Token: 0x04013689 RID: 79497
		public static readonly EUiViewName VisionSlotSuccessView = new EUiViewName("VisionSlotSuccessView");

		// Token: 0x0401368A RID: 79498
		public static readonly EUiViewName VisionLevelUpSuccessView = new EUiViewName("VisionLevelUpSuccessView");

		// Token: 0x0401368B RID: 79499
		public static readonly EUiViewName VisionRecommendView = new EUiViewName("VisionRecommendView");

		// Token: 0x0401368C RID: 79500
		public static readonly EUiViewName VisionNewRecommendView = new EUiViewName("VisionNewRecommendView");

		// Token: 0x0401368D RID: 79501
		public static readonly EUiViewName VisionNewRecommendPreviewView = new EUiViewName("VisionNewRecommendPreviewView");

		// Token: 0x0401368E RID: 79502
		public static readonly EUiViewName VisionLookOverView = new EUiViewName("VisionLookOverView");

		// Token: 0x0401368F RID: 79503
		public static readonly EUiViewName VisionSkinView = new EUiViewName("VisionSkinView");

		// Token: 0x04013690 RID: 79504
		public static readonly EUiViewName VisionAssembleView = new EUiViewName("VisionAssembleView");

		// Token: 0x04013691 RID: 79505
		public static readonly EUiViewName SignalDecodeView = new EUiViewName("SignalDecodeView");

		// Token: 0x04013692 RID: 79506
		public static readonly EUiViewName SignalDeviceView = new EUiViewName("SignalDeviceView");

		// Token: 0x04013693 RID: 79507
		public static readonly EUiViewName SignalDeviceChasingMoonView = new EUiViewName("SignalDeviceChasingMoonView");

		// Token: 0x04013694 RID: 79508
		public static readonly EUiViewName QuestFailRangeTipsView = new EUiViewName("QuestFailRangeTipsView");

		// Token: 0x04013695 RID: 79509
		public static readonly EUiViewName RoleLevelUpSuccessAttributeView = new EUiViewName("RoleLevelUpSuccessAttributeView");

		// Token: 0x04013696 RID: 79510
		public static readonly EUiViewName RoleLevelUpSuccessEffectView = new EUiViewName("RoleLevelUpSuccessEffectView");

		// Token: 0x04013697 RID: 79511
		public static readonly EUiViewName CommonSingleInputView = new EUiViewName("CommonSingleInputView");

		// Token: 0x04013698 RID: 79512
		public static readonly EUiViewName CommonModifyNameInputView = new EUiViewName("CommonModifyNameInputView");

		// Token: 0x04013699 RID: 79513
		public static readonly EUiViewName CommonMultiInputView = new EUiViewName("CommonMultiInputView");

		// Token: 0x0401369A RID: 79514
		public static readonly EUiViewName CdKeyInputView = new EUiViewName("CdKeyInputView");

		// Token: 0x0401369B RID: 79515
		public static readonly EUiViewName VersionCheckView = new EUiViewName("VersionCheckView");

		// Token: 0x0401369C RID: 79516
		public static readonly EUiViewName VisionAssembleInputView = new EUiViewName("VisionAssembleInputView");

		// Token: 0x0401369D RID: 79517
		public static readonly EUiViewName PingView = new EUiViewName("PingView");

		// Token: 0x0401369E RID: 79518
		public static readonly EUiViewName RogueInfoView = new EUiViewName("RogueInfoView");

		// Token: 0x0401369F RID: 79519
		public static readonly EUiViewName RogueShopView = new EUiViewName("RogueShopView");

		// Token: 0x040136A0 RID: 79520
		public static readonly EUiViewName RogueRoomTip = new EUiViewName("RogueRoomTip");

		// Token: 0x040136A1 RID: 79521
		public static readonly EUiViewName RoguelikeInstanceView = new EUiViewName("RoguelikeInstanceView");

		// Token: 0x040136A2 RID: 79522
		public static readonly EUiViewName RoguelikeSelectRoleView = new EUiViewName("RoguelikeSelectRoleView");

		// Token: 0x040136A3 RID: 79523
		public static readonly EUiViewName RoguelikeBossChallengeView = new EUiViewName("RoguelikeBossChallengeView");

		// Token: 0x040136A4 RID: 79524
		public static readonly EUiViewName RoguelikeBossChallengeBuffDetailView = new EUiViewName("RoguelikeBossChallengeBuffDetailView");

		// Token: 0x040136A5 RID: 79525
		public static readonly EUiViewName RoguelikeSettleView = new EUiViewName("RoguelikeSettleView");

		// Token: 0x040136A6 RID: 79526
		public static readonly EUiViewName RoguelikeExitTips = new EUiViewName("RoguelikeExitTips");

		// Token: 0x040136A7 RID: 79527
		public static readonly EUiViewName WeeklyRogueExitTips = new EUiViewName("WeeklyRogueExitTips");

		// Token: 0x040136A8 RID: 79528
		public static readonly EUiViewName WeeklyRogueResultCheckView = new EUiViewName("WeeklyRogueResultCheckView");

		// Token: 0x040136A9 RID: 79529
		public static readonly EUiViewName RoguelikeRoomFloatTips = new EUiViewName("RoguelikeRoomFloatTips");

		// Token: 0x040136AA RID: 79530
		public static readonly EUiViewName BattleFloatTipsView = new EUiViewName("BattleFloatTipsView");

		// Token: 0x040136AB RID: 79531
		public static readonly EUiViewName LoadingView = new EUiViewName("LoadingView");

		// Token: 0x040136AC RID: 79532
		public static readonly EUiViewName RacingBetsLoadingView = new EUiViewName("RacingBetsLoadingView");

		// Token: 0x040136AD RID: 79533
		public static readonly EUiViewName CyberpunkLoadingView = new EUiViewName("CyberpunkLoadingView");

		// Token: 0x040136AE RID: 79534
		public static readonly EUiViewName FadeLoadingView = new EUiViewName("FadeLoadingView");

		// Token: 0x040136AF RID: 79535
		public static readonly EUiViewName RoleLoadingView = new EUiViewName("RoleLoadingView");

		// Token: 0x040136B0 RID: 79536
		public static readonly EUiViewName SpecialTransitionView = new EUiViewName("SpecialTransitionView");

		// Token: 0x040136B1 RID: 79537
		public static readonly EUiViewName BlackScreenTextView = new EUiViewName("BlackScreenTextView");

		// Token: 0x040136B2 RID: 79538
		public static readonly EUiViewName RoguelikeSkillView = new EUiViewName("RoguelikeSkillView");

		// Token: 0x040136B3 RID: 79539
		public static readonly EUiViewName RoguelikeActivityView = new EUiViewName("RoguelikeActivityView");

		// Token: 0x040136B4 RID: 79540
		public static readonly EUiViewName SoundAreaPlayTips = new EUiViewName("SoundAreaPlayTips");

		// Token: 0x040136B5 RID: 79541
		public static readonly EUiViewName ExploreDetailView = new EUiViewName("ExploreDetailView");

		// Token: 0x040136B6 RID: 79542
		public static readonly EUiViewName MapAreaShowView = new EUiViewName("MapAreaShowView");

		// Token: 0x040136B7 RID: 79543
		public static readonly EUiViewName MapExploreDetailView = new EUiViewName("MapExploreDetailView");

		// Token: 0x040136B8 RID: 79544
		public static readonly EUiViewName MapPlayPointDetailView = new EUiViewName("MapPlayPointDetailView");

		// Token: 0x040136B9 RID: 79545
		public static readonly EUiViewName MapExploreStoryView = new EUiViewName("MapExploreStoryView");

		// Token: 0x040136BA RID: 79546
		public static readonly EUiViewName RoguelikeMemoryPlaceView = new EUiViewName("RoguelikeMemoryPlaceView");

		// Token: 0x040136BB RID: 79547
		public static readonly EUiViewName RoguelikeAchievementView = new EUiViewName("RoguelikeAchievementView");

		// Token: 0x040136BC RID: 79548
		public static readonly EUiViewName RoguelikeTokenOverView = new EUiViewName("RoguelikeTokenOverView");

		// Token: 0x040136BD RID: 79549
		public static readonly EUiViewName ExploreLevelView = new EUiViewName("ExploreLevelView");

		// Token: 0x040136BE RID: 79550
		public static readonly EUiViewName ExploreLevelPreviewView = new EUiViewName("ExploreLevelPreviewView");

		// Token: 0x040136BF RID: 79551
		public static readonly EUiViewName RoguelikeRandomEventView = new EUiViewName("RoguelikeRandomEventView");

		// Token: 0x040136C0 RID: 79552
		public static readonly EUiViewName RogueBattleRandomEventView = new EUiViewName("RogueBattleRandomEventView");

		// Token: 0x040136C1 RID: 79553
		public static readonly EUiViewName RogueBattleSelectTokenView = new EUiViewName("RogueBattleSelectTokenView");

		// Token: 0x040136C2 RID: 79554
		public static readonly EUiViewName RogueBattlePhantomSelectView = new EUiViewName("RogueBattlePhantomSelectView");

		// Token: 0x040136C3 RID: 79555
		public static readonly EUiViewName RogueBattleShopView = new EUiViewName("RogueBattleShopView");

		// Token: 0x040136C4 RID: 79556
		public static readonly EUiViewName RogueBattleSettleView = new EUiViewName("RogueBattleSettleView");

		// Token: 0x040136C5 RID: 79557
		public static readonly EUiViewName RogueBattleTeamEditView = new EUiViewName("RogueBattleTeamEditView");

		// Token: 0x040136C6 RID: 79558
		public static readonly EUiViewName RogueBattleBuyRoleView = new EUiViewName("RogueBattleBuyRoleView");

		// Token: 0x040136C7 RID: 79559
		public static readonly EUiViewName RogueBattleRoleBuffSelectView = new EUiViewName("RogueBattleRoleBuffSelectView");

		// Token: 0x040136C8 RID: 79560
		public static readonly EUiViewName RogueBattleRoleStarUpView = new EUiViewName("RogueBattleRoleStarUpView");

		// Token: 0x040136C9 RID: 79561
		public static readonly EUiViewName RogueBattleLinkUnlockView = new EUiViewName("RogueBattleLinkUnlockView");

		// Token: 0x040136CA RID: 79562
		public static readonly EUiViewName RogueBattleEnvironmentBuffView = new EUiViewName("RogueBattleEnvironmentBuffView");

		// Token: 0x040136CB RID: 79563
		public static readonly EUiViewName RogueAttributeDetailView = new EUiViewName("RogueAttributeDetailView");

		// Token: 0x040136CC RID: 79564
		public static readonly EUiViewName WeeklyRogueAttributeDetailView = new EUiViewName("WeeklyRogueAttributeDetailView");

		// Token: 0x040136CD RID: 79565
		public static readonly EUiViewName WhiteCatWarningTips = new EUiViewName("WhiteCatWarningTips");

		// Token: 0x040136CE RID: 79566
		public static readonly EUiViewName BlackCatWarningTips = new EUiViewName("BlackCatWarningTips");

		// Token: 0x040136CF RID: 79567
		public static readonly EUiViewName DreamLinkDungeonView = new EUiViewName("DreamLinkDungeonView");

		// Token: 0x040136D0 RID: 79568
		public static readonly EUiViewName DreamLinkMainView = new EUiViewName("DreamLinkMainView");

		// Token: 0x040136D1 RID: 79569
		public static readonly EUiViewName DreamLinkWhiteCatView = new EUiViewName("DreamLinkWhiteCatView");

		// Token: 0x040136D2 RID: 79570
		public static readonly EUiViewName DreamLinkWorldRunView = new EUiViewName("DreamLinkWorldRunView");

		// Token: 0x040136D3 RID: 79571
		public static readonly EUiViewName DreamLinkRewardViewEnergy = new EUiViewName("DreamLinkRewardViewEnergy");

		// Token: 0x040136D4 RID: 79572
		public static readonly EUiViewName DreamLinkRewardViewLimit = new EUiViewName("DreamLinkRewardViewLimit");

		// Token: 0x040136D5 RID: 79573
		public static readonly EUiViewName LordGymUnlockTipView = new EUiViewName("LordGymUnlockTipView");

		// Token: 0x040136D6 RID: 79574
		public static readonly EUiViewName LordChallengeResultView = new EUiViewName("LordChallengeResultView");

		// Token: 0x040136D7 RID: 79575
		public static readonly EUiViewName ItemDeliverView = new EUiViewName("ItemDeliverView");

		// Token: 0x040136D8 RID: 79576
		public static readonly EUiViewName NewMissionTips = new EUiViewName("NewMissionTips");

		// Token: 0x040136D9 RID: 79577
		public static readonly EUiViewName QuestLockPreview = new EUiViewName("QuestLockPreview");

		// Token: 0x040136DA RID: 79578
		public static readonly EUiViewName CsQuestLockPreview = new EUiViewName("CsQuestLockPreview");

		// Token: 0x040136DB RID: 79579
		public static readonly EUiViewName SilentAreaRewardPreviewPopView = new EUiViewName("SilentAreaRewardPreviewPopView");

		// Token: 0x040136DC RID: 79580
		public static readonly EUiViewName RoguelikeBlackFlowerPreviewView = new EUiViewName("RoguelikeBlackFlowerPreviewView");

		// Token: 0x040136DD RID: 79581
		public static readonly EUiViewName RepeatKeyTipsView = new EUiViewName("RepeatKeyTipsView");

		// Token: 0x040136DE RID: 79582
		public static readonly EUiViewName RemainStarWarningTips = new EUiViewName("RemainStarWarningTips");

		// Token: 0x040136DF RID: 79583
		public static readonly EUiViewName MemoryFragmentMainView = new EUiViewName("MemoryFragmentMainView");

		// Token: 0x040136E0 RID: 79584
		public static readonly EUiViewName ObtainFragmentView = new EUiViewName("ObtainFragmentView");

		// Token: 0x040136E1 RID: 79585
		public static readonly EUiViewName MemoryDetailView = new EUiViewName("MemoryDetailView");

		// Token: 0x040136E2 RID: 79586
		public static readonly EUiViewName FragmentedCluesView = new EUiViewName("FragmentedCluesView");

		// Token: 0x040136E3 RID: 79587
		public static readonly EUiViewName RoguelikeUnlockTips = new EUiViewName("RoguelikeUnlockTips");

		// Token: 0x040136E4 RID: 79588
		public static readonly EUiViewName ChangeActionTipsView = new EUiViewName("ChangeActionTipsView");

		// Token: 0x040136E5 RID: 79589
		public static readonly EUiViewName ChangeModeTipsView = new EUiViewName("ChangeModeTipsView");

		// Token: 0x040136E6 RID: 79590
		public static readonly EUiViewName VisionRecoveryResultView = new EUiViewName("VisionRecoveryResultView");

		// Token: 0x040136E7 RID: 79591
		public static readonly EUiViewName VisionRecoveryBatchResultView = new EUiViewName("VisionRecoveryBatchResultView");

		// Token: 0x040136E8 RID: 79592
		public static readonly EUiViewName VisionRefineAttributeSelectView = new EUiViewName("VisionRefineAttributeSelectView");

		// Token: 0x040136E9 RID: 79593
		public static readonly EUiViewName VisionRefineResultView = new EUiViewName("VisionRefineResultView");

		// Token: 0x040136EA RID: 79594
		public static readonly EUiViewName VisionRefineSubResultView = new EUiViewName("VisionRefineSubResultView");

		// Token: 0x040136EB RID: 79595
		public static readonly EUiViewName RoleTagDetailView = new EUiViewName("RoleTagDetailView");

		// Token: 0x040136EC RID: 79596
		public static readonly EUiViewName RoguelikeInstanceEntrySelectView = new EUiViewName("RoguelikeInstanceEntrySelectView");

		// Token: 0x040136ED RID: 79597
		public static readonly EUiViewName RoguelikeSpecialDetailView = new EUiViewName("RoguelikeSpecialDetailView");

		// Token: 0x040136EE RID: 79598
		public static readonly EUiViewName RoguelikeSelectSpecialView = new EUiViewName("RoguelikeSelectSpecialView");

		// Token: 0x040136EF RID: 79599
		public static readonly EUiViewName RoguelikeEntranceView = new EUiViewName("RoguelikeEntranceView");

		// Token: 0x040136F0 RID: 79600
		public static readonly EUiViewName RoguelikeRoleAffixDetailView = new EUiViewName("RoguelikeRoleAffixDetailView");

		// Token: 0x040136F1 RID: 79601
		public static readonly EUiViewName RoguelikePhantomNewUnlockView = new EUiViewName("RoguelikePhantomNewUnlockView");

		// Token: 0x040136F2 RID: 79602
		public static readonly EUiViewName RoguelikeAchieveView = new EUiViewName("RoguelikeAchieveView");

		// Token: 0x040136F3 RID: 79603
		public static readonly EUiViewName CollectItemView = new EUiViewName("CollectItemView");

		// Token: 0x040136F4 RID: 79604
		public static readonly EUiViewName DifficultUnlockTipView = new EUiViewName("DifficultUnlockTipView");

		// Token: 0x040136F5 RID: 79605
		public static readonly EUiViewName LongShanView = new EUiViewName("LongShanView");

		// Token: 0x040136F6 RID: 79606
		public static readonly EUiViewName ExploreMissionView = new EUiViewName("ExploreMissionView");

		// Token: 0x040136F7 RID: 79607
		public static readonly EUiViewName RoleBreakPreviewView = new EUiViewName("RoleBreakPreviewView");

		// Token: 0x040136F8 RID: 79608
		public static readonly EUiViewName TowerDefenseWaveTipView = new EUiViewName("TowerDefenceWaveTipView");

		// Token: 0x040136F9 RID: 79609
		public static readonly EUiViewName TowerDefenseStrengthenTipsView = new EUiViewName("TowerDefenseStrengthenTipsView");

		// Token: 0x040136FA RID: 79610
		public static readonly EUiViewName TowerDefenseInBattleTips = new EUiViewName("TowerDefenceInBattleTips");

		// Token: 0x040136FB RID: 79611
		public static readonly EUiViewName TuningStandView = new EUiViewName("TuningStandView");

		// Token: 0x040136FC RID: 79612
		public static readonly EUiViewName MoonChasingMainView = new EUiViewName("MoonChasingMainView");

		// Token: 0x040136FD RID: 79613
		public static readonly EUiViewName MoonChasingUnlockRoleView = new EUiViewName("MoonChasingUnlockRoleView");

		// Token: 0x040136FE RID: 79614
		public static readonly EUiViewName BuildingTipsInfoView = new EUiViewName("BuildingTipsInfoView");

		// Token: 0x040136FF RID: 79615
		public static readonly EUiViewName BuildingLevelUpView = new EUiViewName("BuildingLevelUpView");

		// Token: 0x04013700 RID: 79616
		public static readonly EUiViewName ScratchTicketMainView = new EUiViewName("ScratchTicketMainView");

		// Token: 0x04013701 RID: 79617
		public static readonly EUiViewName BusinessMainView = new EUiViewName("BusinessMainView");

		// Token: 0x04013702 RID: 79618
		public static readonly EUiViewName BusinessTipsTravelView = new EUiViewName("BusinessTipsTravelView");

		// Token: 0x04013703 RID: 79619
		public static readonly EUiViewName BusinessTipsShopView = new EUiViewName("BusinessTipsShopView");

		// Token: 0x04013704 RID: 79620
		public static readonly EUiViewName BusinessTipsBurstView = new EUiViewName("BusinessTipsBurstView");

		// Token: 0x04013705 RID: 79621
		public static readonly EUiViewName BusinessTipsResultView = new EUiViewName("BusinessTipsResultView");

		// Token: 0x04013706 RID: 79622
		public static readonly EUiViewName BusinessTipsFinishView = new EUiViewName("BusinessTipsFinishView");

		// Token: 0x04013707 RID: 79623
		public static readonly EUiViewName BusinessTipsPopularityUpView = new EUiViewName("BusinessTipsPopularityUpView");

		// Token: 0x04013708 RID: 79624
		public static readonly EUiViewName BusinessHelperView = new EUiViewName("BusinessHelperView");

		// Token: 0x04013709 RID: 79625
		public static readonly EUiViewName SdkMailView = new EUiViewName("SdkMailView");

		// Token: 0x0401370A RID: 79626
		public static readonly EUiViewName SdkLoginView = new EUiViewName("SdkLoginView");

		// Token: 0x0401370B RID: 79627
		public static readonly EUiViewName SdkTipsPopUpView = new EUiViewName("SdkTipsPopUpView");

		// Token: 0x0401370C RID: 79628
		public static readonly EUiViewName SdkEnterTipsView = new EUiViewName("SdkEnterTipsView");

		// Token: 0x0401370D RID: 79629
		public static readonly EUiViewName SdkTipsMiddlePopUpView = new EUiViewName("SdkTipsMiddlePopUpView");

		// Token: 0x0401370E RID: 79630
		public static readonly EUiViewName SdkLoadPopUpView = new EUiViewName("SdkLoadPopUpView");

		// Token: 0x0401370F RID: 79631
		public static readonly EUiViewName MoonChasingTaskView = new EUiViewName("MoonChasingTaskView");

		// Token: 0x04013710 RID: 79632
		public static readonly EUiViewName RewardMainView = new EUiViewName("RewardMainView");

		// Token: 0x04013711 RID: 79633
		public static readonly EUiViewName MoonChasingHandbookView = new EUiViewName("MoonChasingHandbookView");

		// Token: 0x04013712 RID: 79634
		public static readonly EUiViewName MoonChasingMemoryView = new EUiViewName("MoonChasingMemoryView");

		// Token: 0x04013713 RID: 79635
		public static readonly EUiViewName MoonChasingMemoryDetailView = new EUiViewName("MoonChasingMemoryDetailView");

		// Token: 0x04013714 RID: 79636
		public static readonly EUiViewName RoleGrowingMainView = new EUiViewName("RoleGrowingMainView");

		// Token: 0x04013715 RID: 79637
		public static readonly EUiViewName RoleGrowingTaskView = new EUiViewName("RoleGrowingTaskView");

		// Token: 0x04013716 RID: 79638
		public static readonly EUiViewName InstanceDungeonEntranceRootView = new EUiViewName("InstanceDungeonEntranceRootView");

		// Token: 0x04013717 RID: 79639
		public static readonly EUiViewName MowingBuffView = new EUiViewName("MowingBuffView");

		// Token: 0x04013718 RID: 79640
		public static readonly EUiViewName MowingRiskBuffTipView = new EUiViewName("MowingRiskBuffTipView");

		// Token: 0x04013719 RID: 79641
		public static readonly EUiViewName MowingBuffNewBuffTipsView = new EUiViewName("MowingBuffNewBuffTipsView");

		// Token: 0x0401371A RID: 79642
		public static readonly EUiViewName VersionPreheatQuestDetailView = new EUiViewName("VersionPreheatQuestDetailView");

		// Token: 0x0401371B RID: 79643
		public static readonly EUiViewName VersionPreheatVoteView = new EUiViewName("VersionPreheatVoteView");

		// Token: 0x0401371C RID: 79644
		public static readonly EUiViewName CookMechanismRootView = new EUiViewName("CookMechanismRootView");

		// Token: 0x0401371D RID: 79645
		public static readonly EUiViewName Spring25MainView = new EUiViewName("Spring25MainView");

		// Token: 0x0401371E RID: 79646
		public static readonly EUiViewName Spring25DialogueView = new EUiViewName("Spring25DialogueView");

		// Token: 0x0401371F RID: 79647
		public static readonly EUiViewName Spring25EnvelopeView = new EUiViewName("Spring25EnvelopeView");

		// Token: 0x04013720 RID: 79648
		public static readonly EUiViewName Spring25LetterListView = new EUiViewName("Spring25LetterListView");

		// Token: 0x04013721 RID: 79649
		public static readonly EUiViewName Spring25InfoView = new EUiViewName("Spring25InfoView");

		// Token: 0x04013722 RID: 79650
		public static readonly EUiViewName MapTravelMainView = new EUiViewName("MapTravelMainView");

		// Token: 0x04013723 RID: 79651
		public static readonly EUiViewName ActivityUnlockTipMapTravelView = new EUiViewName("ActivityUnlockTipMapTravelView");

		// Token: 0x04013724 RID: 79652
		public static readonly EUiViewName TravelLevelTipsView = new EUiViewName("TravelLevelTipsView");

		// Token: 0x04013725 RID: 79653
		public static readonly EUiViewName ActivityRegressStartupView = new EUiViewName("ActivityRegressStartupView");

		// Token: 0x04013726 RID: 79654
		public static readonly EUiViewName ActivityRegressNewVersionMainView = new EUiViewName("ActivityRegressNewVersionMainView");

		// Token: 0x04013727 RID: 79655
		public static readonly EUiViewName ActivityRegressMainView = new EUiViewName("ActivityRegressMainView");

		// Token: 0x04013728 RID: 79656
		public static readonly EUiViewName ActivityRegressQuestionnaireView = new EUiViewName("ActivityRegressQuestionnaireView");

		// Token: 0x04013729 RID: 79657
		public static readonly EUiViewName ActivityRegressTaskMainView = new EUiViewName("ActivityRegressTaskMainView");

		// Token: 0x0401372A RID: 79658
		public static readonly EUiViewName ActivityRecommendView = new EUiViewName("ActivityRecommendView");

		// Token: 0x0401372B RID: 79659
		public static readonly EUiViewName DigitalScreenaView = new EUiViewName("DigitalScreenA");

		// Token: 0x0401372C RID: 79660
		public static readonly EUiViewName DigitalScreenbView = new EUiViewName("DigitalScreenB");

		// Token: 0x0401372D RID: 79661
		public static readonly EUiViewName GachaPoolDetailView = new EUiViewName("GachaPoolDetailView");

		// Token: 0x0401372E RID: 79662
		public static readonly EUiViewName RogueSilentAreaFloatTips = new EUiViewName("RogueSilentAreaFloatTips");

		// Token: 0x0401372F RID: 79663
		public static readonly EUiViewName CorniceMeetingSettleView = new EUiViewName("CorniceMeetingSettleView");

		// Token: 0x04013730 RID: 79664
		public static readonly EUiViewName MobileSwitchInputView = new EUiViewName("MobileSwitchInputView");

		// Token: 0x04013731 RID: 79665
		public static readonly EUiViewName SdkPayProductInformationView = new EUiViewName("SdkPayProductInformationView");

		// Token: 0x04013732 RID: 79666
		public static readonly EUiViewName DarkCoastDeliveryMainView = new EUiViewName("DarkCoastDeliveryMainView");

		// Token: 0x04013733 RID: 79667
		public static readonly EUiViewName DarkCoastDeliveryLevelUpView = new EUiViewName("DarkCoastDeliveryLevelUpView");

		// Token: 0x04013734 RID: 79668
		public static readonly EUiViewName BattleLinkView = new EUiViewName("BattleLinkView");

		// Token: 0x04013735 RID: 79669
		public static readonly EUiViewName OperationPreferencesView = new EUiViewName("OperationPreferencesView");

		// Token: 0x04013736 RID: 79670
		public static readonly EUiViewName MailBindView = new EUiViewName("MailBindView");

		// Token: 0x04013737 RID: 79671
		public static readonly EUiViewName SkinRootView = new EUiViewName("SkinRootView");

		// Token: 0x04013738 RID: 79672
		public static readonly EUiViewName RecommendQualityView = new EUiViewName("RecommendQualityView");

		// Token: 0x04013739 RID: 79673
		public static readonly EUiViewName MowingTowerMainView = new EUiViewName("MowingTowerMainView");

		// Token: 0x0401373A RID: 79674
		public static readonly EUiViewName MowingTowerFloorView = new EUiViewName("MowingTowerFloorView");

		// Token: 0x0401373B RID: 79675
		public static readonly EUiViewName MowingTowerBuffView = new EUiViewName("MowingTowerBuffView");

		// Token: 0x0401373C RID: 79676
		public static readonly EUiViewName MowingTowerRewardView = new EUiViewName("MowingTowerRewardView");

		// Token: 0x0401373D RID: 79677
		public static readonly EUiViewName LifePointView = new EUiViewName("LifePointView");

		// Token: 0x0401373E RID: 79678
		public static readonly EUiViewName CheckInteractionView = new EUiViewName("CheckInteractionView");

		// Token: 0x0401373F RID: 79679
		public static readonly EUiViewName BigStuffedDollView = new EUiViewName("BigStuffedDollView");

		// Token: 0x04013740 RID: 79680
		public static readonly EUiViewName FlySettlementView = new EUiViewName("FlySettlementView");

		// Token: 0x04013741 RID: 79681
		public static readonly EUiViewName SkinObtainView = new EUiViewName("SkinObtainView");

		// Token: 0x04013742 RID: 79682
		public static readonly EUiViewName FlySkinObtainView = new EUiViewName("FlySkinObtainView");

		// Token: 0x04013743 RID: 79683
		public static readonly EUiViewName SkinShowView = new EUiViewName("SkinShowView");

		// Token: 0x04013744 RID: 79684
		public static readonly EUiViewName SkinBuyDetailView = new EUiViewName("SkinBuyDetailView");

		// Token: 0x04013745 RID: 79685
		public static readonly EUiViewName FlySkinBuyDetailView = new EUiViewName("FlySkinBuyDetailView");

		// Token: 0x04013746 RID: 79686
		public static readonly EUiViewName FlySkinShowView = new EUiViewName("FlySkinShowView");

		// Token: 0x04013747 RID: 79687
		public static readonly EUiViewName MotorSkinBuyDetailView = new EUiViewName("MotorSkinBuyDetailView");

		// Token: 0x04013748 RID: 79688
		public static readonly EUiViewName EquipBuffItemDetailView = new EUiViewName("EquipBuffItemDetailView");

		// Token: 0x04013749 RID: 79689
		public static readonly EUiViewName RoleOrnamentShowView = new EUiViewName("RoleOrnamentShowView");

		// Token: 0x0401374A RID: 79690
		public static readonly EUiViewName SpecialItemSummonShowView = new EUiViewName("SpecialItemSummonShowView");

		// Token: 0x0401374B RID: 79691
		public static readonly EUiViewName WeaponSkinShowView = new EUiViewName("WeaponSkinShowView");

		// Token: 0x0401374C RID: 79692
		public static readonly EUiViewName DockyardView = new EUiViewName("DockyardView");

		// Token: 0x0401374D RID: 79693
		public static readonly EUiViewName DockyardWareHouseView = new EUiViewName("DockyardWareHouseView");

		// Token: 0x0401374E RID: 79694
		public static readonly EUiViewName DockyardCageView = new EUiViewName("DockyardCageView");

		// Token: 0x0401374F RID: 79695
		public static readonly EUiViewName DockyardShopMainView = new EUiViewName("DockyardShopMainView");

		// Token: 0x04013750 RID: 79696
		public static readonly EUiViewName DockyardInteractView = new EUiViewName("DockyardInteractView");

		// Token: 0x04013751 RID: 79697
		public static readonly EUiViewName FishingDockView = new EUiViewName("FishingDockView");

		// Token: 0x04013752 RID: 79698
		public static readonly EUiViewName SailingView = new EUiViewName("SailingView");

		// Token: 0x04013753 RID: 79699
		public static readonly EUiViewName ShipSkinView = new EUiViewName("ShipSkinView");

		// Token: 0x04013754 RID: 79700
		public static readonly EUiViewName FishingQteView = new EUiViewName("FishingQteView");

		// Token: 0x04013755 RID: 79701
		public static readonly EUiViewName FishingQtePauseView = new EUiViewName("FishingQtePauseView");

		// Token: 0x04013756 RID: 79702
		public static readonly EUiViewName FishingQteSuccessView = new EUiViewName("FishingQteSuccessView");

		// Token: 0x04013757 RID: 79703
		public static readonly EUiViewName DockyardInteractFinishTipsView = new EUiViewName("DockyardInteractFinishTipsView");

		// Token: 0x04013758 RID: 79704
		public static readonly EUiViewName FishingTechRootView = new EUiViewName("FishingTechRootView");

		// Token: 0x04013759 RID: 79705
		public static readonly EUiViewName FishingLevelUpTips = new EUiViewName("FishingLevelUpTips");

		// Token: 0x0401375A RID: 79706
		public static readonly EUiViewName FishingWarningTips = new EUiViewName("FishingWarningTips");

		// Token: 0x0401375B RID: 79707
		public static readonly EUiViewName FishingQuestView = new EUiViewName("FishingQuestView");

		// Token: 0x0401375C RID: 79708
		public static readonly EUiViewName FishingHandBookView = new EUiViewName("FishingHandBookView");

		// Token: 0x0401375D RID: 79709
		public static readonly EUiViewName FishingTimeLimitView = new EUiViewName("FishingTimeLimitView");

		// Token: 0x0401375E RID: 79710
		public static readonly EUiViewName FishingActivityUnlockView = new EUiViewName("FishingActivityUnlockView");

		// Token: 0x0401375F RID: 79711
		public static readonly EUiViewName FishingHandBookRewardView = new EUiViewName("FishingHandBookRewardView");

		// Token: 0x04013760 RID: 79712
		public static readonly EUiViewName FishingLoadingView = new EUiViewName("FishingLoadingView");

		// Token: 0x04013761 RID: 79713
		public static readonly EUiViewName FishingTechLevelUpSuccessView = new EUiViewName("FishingTechLevelUpSuccessView");

		// Token: 0x04013762 RID: 79714
		public static readonly EUiViewName FishingLevelUpView = new EUiViewName("FishingLevelUpView");

		// Token: 0x04013763 RID: 79715
		public static readonly EUiViewName RacingBetsMainView = new EUiViewName("RacingBetsMainView");

		// Token: 0x04013764 RID: 79716
		public static readonly EUiViewName RacingBetsBettingView = new EUiViewName("RacingBetsBettingView");

		// Token: 0x04013765 RID: 79717
		public static readonly EUiViewName RacingBetsRewardView = new EUiViewName("RacingBetsRewardView");

		// Token: 0x04013766 RID: 79718
		public static readonly EUiViewName RacingBetsConfirmBoxView = new EUiViewName("RacingBetsConfirmBoxView");

		// Token: 0x04013767 RID: 79719
		public static readonly EUiViewName CyberpunkConfirmBoxView = new EUiViewName("CyberpunkConfirmBoxView");

		// Token: 0x04013768 RID: 79720
		public static readonly EUiViewName RacingBetsGamePlayView = new EUiViewName("RacingBetsGamePlayView");

		// Token: 0x04013769 RID: 79721
		public static readonly EUiViewName RacingBetsGamePlayPreviewView = new EUiViewName("RacingBetsGamePlayPreviewView");

		// Token: 0x0401376A RID: 79722
		public static readonly EUiViewName RacingBetsHistoryView = new EUiViewName("RacingBetsHistoryView");

		// Token: 0x0401376B RID: 79723
		public static readonly EUiViewName RacingBetsRankView = new EUiViewName("RacingBetsRankView");

		// Token: 0x0401376C RID: 79724
		public static readonly EUiViewName RacingBetsMatchView = new EUiViewName("RacingBetsMatchView");

		// Token: 0x0401376D RID: 79725
		public static readonly EUiViewName RacingBetsSuccessTip = new EUiViewName("RacingBetsSuccessTip");

		// Token: 0x0401376E RID: 79726
		public static readonly EUiViewName RacingBetsFailTip = new EUiViewName("RacingBetsFailTip");

		// Token: 0x0401376F RID: 79727
		public static readonly EUiViewName RacingBetsActivityRewardView = new EUiViewName("RacingBetsActivityRewardView");

		// Token: 0x04013770 RID: 79728
		public static readonly EUiViewName RacingBetsDungeonBeginTip = new EUiViewName("RacingBetsDungeonBeginTip");

		// Token: 0x04013771 RID: 79729
		public static readonly EUiViewName RacingBetsDangoSkillView = new EUiViewName("RacingBetsDangoSkillView");

		// Token: 0x04013772 RID: 79730
		public static readonly EUiViewName RacingBetsDangoTerrainView = new EUiViewName("RacingBetsDangoTerrainView");

		// Token: 0x04013773 RID: 79731
		public static readonly EUiViewName RacingBetsDangoSkillTip = new EUiViewName("RacingBetsDangoSkillTip");

		// Token: 0x04013774 RID: 79732
		public static readonly EUiViewName RacingBetsTerrainTip = new EUiViewName("RacingBetsTerrainTip");

		// Token: 0x04013775 RID: 79733
		public static readonly EUiViewName RacingBetsSpecialTip = new EUiViewName("RacingBetsSpecialTip");

		// Token: 0x04013776 RID: 79734
		public static readonly EUiViewName RacingBetsDangoFrameTipView = new EUiViewName("RacingBetsDangoFrameTipView");

		// Token: 0x04013777 RID: 79735
		public static readonly EUiViewName RacingBetsDungeonResultView = new EUiViewName("RacingBetsDungeonResultView");

		// Token: 0x04013778 RID: 79736
		public static readonly EUiViewName RacingBetsDangoActivityOpenTips = new EUiViewName("RacingBetsDangoActivityOpenTips");

		// Token: 0x04013779 RID: 79737
		public static readonly EUiViewName SkipMainQuestWindowView = new EUiViewName("SkipMainQuestWindowView");

		// Token: 0x0401377A RID: 79738
		public static readonly EUiViewName DirectTrainProView = new EUiViewName("DirectTrainProView");

		// Token: 0x0401377B RID: 79739
		public static readonly EUiViewName DirectTrainDetailView = new EUiViewName("DirectTrainDetailView");

		// Token: 0x0401377C RID: 79740
		public static readonly EUiViewName ShipTogetherView = new EUiViewName("ShipTogetherView");

		// Token: 0x0401377D RID: 79741
		public static readonly EUiViewName ChapterA = new EUiViewName("ChapterA");

		// Token: 0x0401377E RID: 79742
		public static readonly EUiViewName PlotChapterA = new EUiViewName("PlotChapterA");

		// Token: 0x0401377F RID: 79743
		public static readonly EUiViewName SolarSpeedRewardView = new EUiViewName("SolarSpeedRewardView");

		// Token: 0x04013780 RID: 79744
		public static readonly EUiViewName SolarSpeedResultView = new EUiViewName("SolarSpeedResultView");

		// Token: 0x04013781 RID: 79745
		public static readonly EUiViewName HiddenBossWindow = new EUiViewName("HiddenBossWindow");

		// Token: 0x04013782 RID: 79746
		public static readonly EUiViewName ComposeCarryOnView = new EUiViewName("ComposeCarryOnView");

		// Token: 0x04013783 RID: 79747
		public static readonly EUiViewName LiuLiDaoLingView = new EUiViewName("LiuLiDaoLingView");

		// Token: 0x04013784 RID: 79748
		public static readonly EUiViewName GuYingXiongKaiView = new EUiViewName("GuYingXiongKaiView");

		// Token: 0x04013785 RID: 79749
		public static readonly EUiViewName ShipTowerView = new EUiViewName("ShipTowerView");

		// Token: 0x04013786 RID: 79750
		public static readonly EUiViewName RoleTowerActivityView = new EUiViewName("RoleTowerActivityView");

		// Token: 0x04013787 RID: 79751
		public static readonly EUiViewName RoleTowerLoadingView = new EUiViewName("RoleTowerLoadingView");

		// Token: 0x04013788 RID: 79752
		public static readonly EUiViewName RoleTowerPrepareView = new EUiViewName("RoleTowerPrepareView");

		// Token: 0x04013789 RID: 79753
		public static readonly EUiViewName RoleTowerMonsterDetailView = new EUiViewName("RoleTowerMonsterDetailView");

		// Token: 0x0401378A RID: 79754
		public static readonly EUiViewName RoleTowerTokenView = new EUiViewName("RoleTowerTokenView");

		// Token: 0x0401378B RID: 79755
		public static readonly EUiViewName RoleTowerRankView = new EUiViewName("RoleTowerRankView");

		// Token: 0x0401378C RID: 79756
		public static readonly EUiViewName RoleTowerLevelSelectView = new EUiViewName("RoleTowerLevelSelectView");

		// Token: 0x0401378D RID: 79757
		public static readonly EUiViewName RoleTowerRewardView = new EUiViewName("RoleTowerRewardView");

		// Token: 0x0401378E RID: 79758
		public static readonly EUiViewName RoleTowerVisionDetailView = new EUiViewName("RoleTowerVisionDetailView");

		// Token: 0x0401378F RID: 79759
		public static readonly EUiViewName RoleTowerRolePropertyView = new EUiViewName("RoleTowerRolePropertyView");

		// Token: 0x04013790 RID: 79760
		public static readonly EUiViewName RoleTowerAttributeDetailView = new EUiViewName("RoleTowerAttributeDetailView");

		// Token: 0x04013791 RID: 79761
		public static readonly EUiViewName RoleTowerMonsterSelectView = new EUiViewName("RoleTowerMonsterSelectView");

		// Token: 0x04013792 RID: 79762
		public static readonly EUiViewName RoleTowerCountdownView = new EUiViewName("RoleTowerCountdownView");

		// Token: 0x04013793 RID: 79763
		public static readonly EUiViewName RoleTowerWaveView = new EUiViewName("RoleTowerWaveView");

		// Token: 0x04013794 RID: 79764
		public static readonly EUiViewName RoleTowerBossTipsView = new EUiViewName("RoleTowerBossTipsView");

		// Token: 0x04013795 RID: 79765
		public static readonly EUiViewName RoleTowerBuffDetailView = new EUiViewName("RoleTowerBuffDetailView");

		// Token: 0x04013796 RID: 79766
		public static readonly EUiViewName RoleTowerPauseView = new EUiViewName("RoleTowerPauseView");

		// Token: 0x04013797 RID: 79767
		public static readonly EUiViewName RoleTowerSaveExitConfirm = new EUiViewName("RoleTowerSaveExitConfirm");

		// Token: 0x04013798 RID: 79768
		public static readonly EUiViewName RoleTowerFloorSettleView = new EUiViewName("RoleTowerFloorSettleView");

		// Token: 0x04013799 RID: 79769
		public static readonly EUiViewName RoleTowerStarUpView = new EUiViewName("RoleTowerStarUpView");

		// Token: 0x0401379A RID: 79770
		public static readonly EUiViewName RoleTowerResultView = new EUiViewName("RoleTowerResultView");

		// Token: 0x0401379B RID: 79771
		public static readonly EUiViewName RoleTowerTimeRecordView = new EUiViewName("RoleTowerTimeRecordView");

		// Token: 0x0401379C RID: 79772
		public static readonly EUiViewName RoleTowerExitButtonView = new EUiViewName("RoleTowerExitButtonView");

		// Token: 0x0401379D RID: 79773
		public static readonly EUiViewName ShipTowerBuffView = new EUiViewName("ShipTowerBuffView");

		// Token: 0x0401379E RID: 79774
		public static readonly EUiViewName ShipTowerFightFinishView = new EUiViewName("ShipTowerFightFinishView");

		// Token: 0x0401379F RID: 79775
		public static readonly EUiViewName ShipTowerDescView = new EUiViewName("ShipTowerDescView");

		// Token: 0x040137A0 RID: 79776
		public static readonly EUiViewName ShipTowerResetView = new EUiViewName("ShipTowerResetView");

		// Token: 0x040137A1 RID: 79777
		public static readonly EUiViewName ShipTowerGetBuffView = new EUiViewName("ShipTowerGetBuffView");

		// Token: 0x040137A2 RID: 79778
		public static readonly EUiViewName ShipTowerCoverView = new EUiViewName("ShipTowerCoverView");

		// Token: 0x040137A3 RID: 79779
		public static readonly EUiViewName ShipTowerRewardView = new EUiViewName("ShipTowerRewardView");

		// Token: 0x040137A4 RID: 79780
		public static readonly EUiViewName ShipTowerPassBuffShowView = new EUiViewName("ShipTowerPassBuffShowView");

		// Token: 0x040137A5 RID: 79781
		public static readonly EUiViewName ShipTowerTeamRecommendView = new EUiViewName("ShipTowerTeamRecommendView");

		// Token: 0x040137A6 RID: 79782
		public static readonly EUiViewName ShipTowerMonsterDescView = new EUiViewName("ShipTowerMonsterDescView");

		// Token: 0x040137A7 RID: 79783
		public static readonly EUiViewName ShipTowerRecordView = new EUiViewName("ShipTowerRecordView");

		// Token: 0x040137A8 RID: 79784
		public static readonly EUiViewName ShipTowerReviewView = new EUiViewName("ShipTowerReviewView");

		// Token: 0x040137A9 RID: 79785
		public static readonly EUiViewName ShipTowerCountDownView = new EUiViewName("ShipTowerCountDownView");

		// Token: 0x040137AA RID: 79786
		public static readonly EUiViewName ShipTowerShowBuffView = new EUiViewName("ShipTowerShowBuffView");

		// Token: 0x040137AB RID: 79787
		public static readonly EUiViewName ShipTowerLoadingView = new EUiViewName("ShipTowerLoadingView");

		// Token: 0x040137AC RID: 79788
		public static readonly EUiViewName ShipTowerWelcomeView = new EUiViewName("ShipTowerWelcomeView");

		// Token: 0x040137AD RID: 79789
		public static readonly EUiViewName ShipTowerLevelInfoView = new EUiViewName("ShipTowerLevelInfoView");

		// Token: 0x040137AE RID: 79790
		public static readonly EUiViewName WeeklyRogueEnvironmentTips = new EUiViewName("WeeklyRogueEnvironmentTips");

		// Token: 0x040137AF RID: 79791
		public static readonly EUiViewName NetworkDetectionView = new EUiViewName("NetworkDetectionView");

		// Token: 0x040137B0 RID: 79792
		public static readonly EUiViewName NetworkDetectionSelectServerView = new EUiViewName("NetworkDetectionSelectServerView");

		// Token: 0x040137B1 RID: 79793
		public static readonly EUiViewName DangoAbyssInsSelectView = new EUiViewName("DangoAbyssInsSelectView");

		// Token: 0x040137B2 RID: 79794
		public static readonly EUiViewName DangoAbyssEntranceView = new EUiViewName("DangoAbyssEntranceView");

		// Token: 0x040137B3 RID: 79795
		public static readonly EUiViewName DangoAbyssRootView = new EUiViewName("DangoAbyssRootView");

		// Token: 0x040137B4 RID: 79796
		public static readonly EUiViewName DangoAbyssLevelUpView = new EUiViewName("DangoAbyssLevelUpView");

		// Token: 0x040137B5 RID: 79797
		public static readonly EUiViewName DangoAbyssPluginEquipView = new EUiViewName("DangoAbyssPluginEquipView");

		// Token: 0x040137B6 RID: 79798
		public static readonly EUiViewName DangoAbyssSelectDangoView = new EUiViewName("DangoAbyssSelectDangoView");

		// Token: 0x040137B7 RID: 79799
		public static readonly EUiViewName DangoAbyssPluginRecoveryView = new EUiViewName("DangoAbyssPluginRecoveryView");

		// Token: 0x040137B8 RID: 79800
		public static readonly EUiViewName DangoAbyssPluginRecoveryResultView = new EUiViewName("DangoAbyssPluginRecoveryResultView");

		// Token: 0x040137B9 RID: 79801
		public static readonly EUiViewName DangoAbyssRankView = new EUiViewName("DangoAbyssRankView");

		// Token: 0x040137BA RID: 79802
		public static readonly EUiViewName DangoAbyssWorldView = new EUiViewName("DangoAbyssWorldView");

		// Token: 0x040137BB RID: 79803
		public static readonly EUiViewName DangoAbyssWorldLoadingView = new EUiViewName("DangoAbyssWorldLoadingView");

		// Token: 0x040137BC RID: 79804
		public static readonly EUiViewName DangoAbyssInfoView = new EUiViewName("DangoAbyssInfoView");

		// Token: 0x040137BD RID: 79805
		public static readonly EUiViewName DangoAbyssTimeLimitRewardView = new EUiViewName("DangoAbyssTimeLimitRewardView");

		// Token: 0x040137BE RID: 79806
		public static readonly EUiViewName DangoAbyssCommonRewardView = new EUiViewName("DangoAbyssCommonRewardView");

		// Token: 0x040137BF RID: 79807
		public static readonly EUiViewName DangoAbyssTimeLimitRewardActivityView = new EUiViewName("DangoAbyssTimeLimitRewardActivityView");

		// Token: 0x040137C0 RID: 79808
		public static readonly EUiViewName DangoAbyssCommonRewardActivityView = new EUiViewName("DangoAbyssCommonRewardActivityView");

		// Token: 0x040137C1 RID: 79809
		public static readonly EUiViewName DangoAbyssShopView = new EUiViewName("DangoAbyssShopView");

		// Token: 0x040137C2 RID: 79810
		public static readonly EUiViewName DangoAbyssGetDangoView = new EUiViewName("DangoAbyssGetDangoView");

		// Token: 0x040137C3 RID: 79811
		public static readonly EUiViewName DangoAbyssActivityOpen = new EUiViewName("DangoAbyssActivityOpen");

		// Token: 0x040137C4 RID: 79812
		public static readonly EUiViewName DangoAbyssNpcTips = new EUiViewName("DangoAbyssNpcTips");

		// Token: 0x040137C5 RID: 79813
		public static readonly EUiViewName DangoAbyssAttributeDetailView = new EUiViewName("DangoAbyssAttributeDetailView");

		// Token: 0x040137C6 RID: 79814
		public static readonly EUiViewName GravityFlipView = new EUiViewName("GravityFlipView");

		// Token: 0x040137C7 RID: 79815
		public static readonly EUiViewName BabelTowerMainView = new EUiViewName("BabelTowerMainView");

		// Token: 0x040137C8 RID: 79816
		public static readonly EUiViewName BabelTowerBuffSelectView = new EUiViewName("BabelTowerBuffSelectView");

		// Token: 0x040137C9 RID: 79817
		public static readonly EUiViewName BabelTowerNormalLevelChoseView = new EUiViewName("BabelTowerNormalLevelChoseView");

		// Token: 0x040137CA RID: 79818
		public static readonly EUiViewName BabelTowerHardLevelChoseView = new EUiViewName("BabelTowerHardLevelChoseView");

		// Token: 0x040137CB RID: 79819
		public static readonly EUiViewName BabelTowerDeTermSelectView = new EUiViewName("BabelTowerDeTermSelectView");

		// Token: 0x040137CC RID: 79820
		public static readonly EUiViewName BabelTowerDeTermSelectViewNew = new EUiViewName("BabelTowerDeTermSelectViewNew");

		// Token: 0x040137CD RID: 79821
		public static readonly EUiViewName BabelTowerLevelInfoView = new EUiViewName("BabelTowerLevelInfoView");

		// Token: 0x040137CE RID: 79822
		public static readonly EUiViewName BabelTowerQuestView = new EUiViewName("BabelTowerQuestView");

		// Token: 0x040137CF RID: 79823
		public static readonly EUiViewName TowerDefenseRankView = new EUiViewName("TowerDefenseRankView");

		// Token: 0x040137D0 RID: 79824
		public static readonly EUiViewName TowerDefenseRankViewV2 = new EUiViewName("TowerDefenseRankViewV2");

		// Token: 0x040137D1 RID: 79825
		public static readonly EUiViewName TowerDefenseRewardView = new EUiViewName("TowerDefenseRewardView");

		// Token: 0x040137D2 RID: 79826
		public static readonly EUiViewName TowerDefenseSettleView = new EUiViewName("TowerDefenseSettleView");

		// Token: 0x040137D3 RID: 79827
		public static readonly EUiViewName TowerDefensePopupView = new EUiViewName("TowerDefensePopupView");

		// Token: 0x040137D4 RID: 79828
		public static readonly EUiViewName BabelTowerItemInfoView = new EUiViewName("BabelTowerItemInfoView");

		// Token: 0x040137D5 RID: 79829
		public static readonly EUiViewName BabelTowerResetView = new EUiViewName("BabelTowerResetView");

		// Token: 0x040137D6 RID: 79830
		public static readonly EUiViewName ActivityUnlockTipAvignonView = new EUiViewName("ActivityUnlockTipAvignonView");

		// Token: 0x040137D7 RID: 79831
		public static readonly EUiViewName AvignonActivityMainView = new EUiViewName("AvignonActivityMainView");

		// Token: 0x040137D8 RID: 79832
		public static readonly EUiViewName AvignonStageTaskView = new EUiViewName("AvignonStageTaskView");

		// Token: 0x040137D9 RID: 79833
		public static readonly EUiViewName PlayerTitleInfoTip = new EUiViewName("PlayerTitleInfoTip");

		// Token: 0x040137DA RID: 79834
		public static readonly EUiViewName BabelTowerBuffView = new EUiViewName("BabelTowerBuffView");

		// Token: 0x040137DB RID: 79835
		public static readonly EUiViewName BabelTowerSettlementView = new EUiViewName("BabelTowerSettlementView");

		// Token: 0x040137DC RID: 79836
		public static readonly EUiViewName BabelTowerReviveView = new EUiViewName("BabelTowerReviveView");

		// Token: 0x040137DD RID: 79837
		public static readonly EUiViewName BabelTowerNewLevelTipsView = new EUiViewName("BabelTowerNewLevelTipsView");

		// Token: 0x040137DE RID: 79838
		public static readonly EUiViewName BabelTowerHardLevelInfoView = new EUiViewName("BabelTowerHardLevelInfoView");

		// Token: 0x040137DF RID: 79839
		public static readonly EUiViewName BabelTowerHardLevelInfoViewNew = new EUiViewName("BabelTowerHardLevelInfoViewNew");

		// Token: 0x040137E0 RID: 79840
		public static readonly EUiViewName BabelTowerRankView = new EUiViewName("BabelTowerRankView");

		// Token: 0x040137E1 RID: 79841
		public static readonly EUiViewName BasicGraphicSettingView = new EUiViewName("BasicGraphicSettingView");

		// Token: 0x040137E2 RID: 79842
		public static readonly EUiViewName RogueBattleRoleAffixDetailView = new EUiViewName("RogueBattleRoleAffixDetailView");

		// Token: 0x040137E3 RID: 79843
		public static readonly EUiViewName RogueBattleSummary = new EUiViewName("RogueBattleSummary");

		// Token: 0x040137E4 RID: 79844
		public static readonly EUiViewName RogueBattleMapSummaryView = new EUiViewName("RogueBattleMapSummaryView");

		// Token: 0x040137E5 RID: 79845
		public static readonly EUiViewName RogueTokenIllustratedView = new EUiViewName("RogueTokenIllustratedView");

		// Token: 0x040137E6 RID: 79846
		public static readonly EUiViewName RogueEventIllustratedView = new EUiViewName("RogueEventIllustratedView");

		// Token: 0x040137E7 RID: 79847
		public static readonly EUiViewName RogueIllustratedView = new EUiViewName("RogueIllustratedView");

		// Token: 0x040137E8 RID: 79848
		public static readonly EUiViewName RogueTaskView = new EUiViewName("RogueTaskView");

		// Token: 0x040137E9 RID: 79849
		public static readonly EUiViewName RogueDungeonEntryView = new EUiViewName("RogueDungeonEntryView");

		// Token: 0x040137EA RID: 79850
		public static readonly EUiViewName RogueSeasonEntranceView = new EUiViewName("RogueSeasonEntranceView");

		// Token: 0x040137EB RID: 79851
		public static readonly EUiViewName RogueResSkillView = new EUiViewName("RogueResSkillView");

		// Token: 0x040137EC RID: 79852
		public static readonly EUiViewName RogueResSkillOverView = new EUiViewName("RogueResSkillOverView");

		// Token: 0x040137ED RID: 79853
		public static readonly EUiViewName RogueResEndingView = new EUiViewName("RogueResEndingView");

		// Token: 0x040137EE RID: 79854
		public static readonly EUiViewName RogueResEndingSubView = new EUiViewName("RogueResEndingSubView");

		// Token: 0x040137EF RID: 79855
		public static readonly EUiViewName RogueResTrialView = new EUiViewName("RogueResTrialView");

		// Token: 0x040137F0 RID: 79856
		public static readonly EUiViewName RogueResOpenTips = new EUiViewName("RogueResOpenTips");

		// Token: 0x040137F1 RID: 79857
		public static readonly EUiViewName RogueBattleTeamRoleSelectView = new EUiViewName("RogueBattleTeamRoleSelectView");

		// Token: 0x040137F2 RID: 79858
		public static readonly EUiViewName CiacconaGalView = new EUiViewName("CiacconaGalView");

		// Token: 0x040137F3 RID: 79859
		public static readonly EUiViewName CiacconaGalChapterView = new EUiViewName("CiacconaGalChapterView");

		// Token: 0x040137F4 RID: 79860
		public static readonly EUiViewName CiacconaGalEndingView = new EUiViewName("CiacconaGalEndingView");

		// Token: 0x040137F5 RID: 79861
		public static readonly EUiViewName CiacconaGalChapterEntryView = new EUiViewName("CiacconaGalChapterEntryView");

		// Token: 0x040137F6 RID: 79862
		public static readonly EUiViewName CiacconaActivityRewardView = new EUiViewName("CiacconaActivityRewardView");

		// Token: 0x040137F7 RID: 79863
		public static readonly EUiViewName CiacconaGalEndingDetailView = new EUiViewName("CiacconaGalEndingDetailView");

		// Token: 0x040137F8 RID: 79864
		public static readonly EUiViewName PhantomArenaBattleView = new EUiViewName("PhantomArenaBattleView");

		// Token: 0x040137F9 RID: 79865
		public static readonly EUiViewName DeckBuilderCardInfoView = new EUiViewName("DeckBuilderCardInfoView");

		// Token: 0x040137FA RID: 79866
		public static readonly EUiViewName PhantomArenaChangeCardView = new EUiViewName("PhantomArenaChangeCardView");

		// Token: 0x040137FB RID: 79867
		public static readonly EUiViewName PhantomArenaBattleLoading = new EUiViewName("PhantomArenaBattleLoading");

		// Token: 0x040137FC RID: 79868
		public static readonly EUiViewName PhantomArenaBattleVsView = new EUiViewName("PhantomArenaBattleVsView");

		// Token: 0x040137FD RID: 79869
		public static readonly EUiViewName PhantomArenaBattleDetailsView = new EUiViewName("PhantomArenaBattleDetailsView");

		// Token: 0x040137FE RID: 79870
		public static readonly EUiViewName PhantomArenaCoreCardView = new EUiViewName("PhantomArenaCoreCardView");

		// Token: 0x040137FF RID: 79871
		public static readonly EUiViewName PhantomArenaStartView = new EUiViewName("PhantomArenaStartView");

		// Token: 0x04013800 RID: 79872
		public static readonly EUiViewName PhantomArenaMainView = new EUiViewName("PhantomArenaMainView");

		// Token: 0x04013801 RID: 79873
		public static readonly EUiViewName DeckBuilderCardDeleteView = new EUiViewName("DeckBuilderCardDeleteView");

		// Token: 0x04013802 RID: 79874
		public static readonly EUiViewName PhantomArenaCardRewardView = new EUiViewName("PhantomArenaCardRewardView");

		// Token: 0x04013803 RID: 79875
		public static readonly EUiViewName PhantomArenaCardsRewardView = new EUiViewName("PhantomArenaCardsRewardView");

		// Token: 0x04013804 RID: 79876
		public static readonly EUiViewName PhantomArenaCardOutlookRewardView = new EUiViewName("PhantomArenaCardOutlookRewardView");

		// Token: 0x04013805 RID: 79877
		public static readonly EUiViewName PhantomArenaEntranceView = new EUiViewName("PhantomArenaEntranceView");

		// Token: 0x04013806 RID: 79878
		public static readonly EUiViewName PhantomArenaMatchView = new EUiViewName("PhantomArenaMatchView");

		// Token: 0x04013807 RID: 79879
		public static readonly EUiViewName CollectCardDetailView = new EUiViewName("CollectCardDetailView");

		// Token: 0x04013808 RID: 79880
		public static readonly EUiViewName PhantomArenaCollectView = new EUiViewName("PhantomArenaCollectView");

		// Token: 0x04013809 RID: 79881
		public static readonly EUiViewName PhantomArenaCollectViewNew = new EUiViewName("PhantomArenaCollectViewNew");

		// Token: 0x0401380A RID: 79882
		public static readonly EUiViewName PhantomArenaBattleResultView = new EUiViewName("PhantomArenaBattleResultView");

		// Token: 0x0401380B RID: 79883
		public static readonly EUiViewName PhantomArenaBattleResultViewNew = new EUiViewName("PhantomArenaBattleResultViewNew");

		// Token: 0x0401380C RID: 79884
		public static readonly EUiViewName PhantomArenaMasterInfoView = new EUiViewName("PhantomArenaMasterInfoView");

		// Token: 0x0401380D RID: 79885
		public static readonly EUiViewName PhantomArenaRoleCutInView = new EUiViewName("PhantomArenaRoleCutInView");

		// Token: 0x0401380E RID: 79886
		public static readonly EUiViewName PhantomArenaEntranceShopMainView = new EUiViewName("PhantomArenaEntranceShopMainView");

		// Token: 0x0401380F RID: 79887
		public static readonly EUiViewName DeckRenameInputView = new EUiViewName("DeckRenameInputView");

		// Token: 0x04013810 RID: 79888
		public static readonly EUiViewName DeckBuilderQuicklyBuildView = new EUiViewName("DeckBuilderQuicklyBuildView");

		// Token: 0x04013811 RID: 79889
		public static readonly EUiViewName PhantomArenaDeckDetailView = new EUiViewName("PhantomArenaDeckDetailView");

		// Token: 0x04013812 RID: 79890
		public static readonly EUiViewName PhantomArenaDeckDetailViewNew = new EUiViewName("PhantomArenaDeckDetailViewNew");

		// Token: 0x04013813 RID: 79891
		public static readonly EUiViewName PhantomArenaCardBattleLoadingView = new EUiViewName("PhantomArenaCardBattleLoadingView");

		// Token: 0x04013814 RID: 79892
		public static readonly EUiViewName PhantomArenaBattleFloatTips = new EUiViewName("PhantomArenaBattleFloatTips");

		// Token: 0x04013815 RID: 79893
		public static readonly EUiViewName PhantomArenaBadgeUnlockView = new EUiViewName("PhantomArenaBadgeUnlockView");

		// Token: 0x04013816 RID: 79894
		public static readonly EUiViewName PhantomArenaRoleUnlockView = new EUiViewName("PhantomArenaRoleUnlockView");

		// Token: 0x04013817 RID: 79895
		public static readonly EUiViewName PhantomArenaBattleDamageView = new EUiViewName("PhantomArenaBattleDamageView");

		// Token: 0x04013818 RID: 79896
		public static readonly EUiViewName PhantomArenaActivityOpen = new EUiViewName("PhantomArenaActivityOpen");

		// Token: 0x04013819 RID: 79897
		public static readonly EUiViewName PhantomArenaHelpView = new EUiViewName("PhantomArenaHelpView");

		// Token: 0x0401381A RID: 79898
		public static readonly EUiViewName PhantomArenaRewardView = new EUiViewName("PhantomArenaRewardView");

		// Token: 0x0401381B RID: 79899
		public static readonly EUiViewName DangoMonopolyMainView = new EUiViewName("DangoMonopolyMainView");

		// Token: 0x0401381C RID: 79900
		public static readonly EUiViewName DangoMonopolyTaskView = new EUiViewName("DangoMonopolyTaskView");

		// Token: 0x0401381D RID: 79901
		public static readonly EUiViewName DangoMonopolyRoundShowView = new EUiViewName("DangoMonopolyRoundShowView");

		// Token: 0x0401381E RID: 79902
		public static readonly EUiViewName DangoMonopolyResultView = new EUiViewName("DangoMonopolyResultView");

		// Token: 0x0401381F RID: 79903
		public static readonly EUiViewName DangoMonopolyBuffActiveView = new EUiViewName("DangoMonopolyBuffActiveView");

		// Token: 0x04013820 RID: 79904
		public static readonly EUiViewName DangoMonopolyRoundBuffShowView = new EUiViewName("DangoMonopolyRoundBuffShowView");

		// Token: 0x04013821 RID: 79905
		public static readonly EUiViewName DangoMonopolyTipsView = new EUiViewName("DangoMonopolyTipsView");

		// Token: 0x04013822 RID: 79906
		public static readonly EUiViewName DangoMonopolyRollDiceView = new EUiViewName("DangoMonopolyRollDiceView");

		// Token: 0x04013823 RID: 79907
		public static readonly EUiViewName DangoMonopolyTransitionView = new EUiViewName("DangoMonopolyTransitionView");

		// Token: 0x04013824 RID: 79908
		public static readonly EUiViewName MoraleBuffView = new EUiViewName("MoraleBuffView");

		// Token: 0x04013825 RID: 79909
		public static readonly EUiViewName MoraleRewardView = new EUiViewName("MoraleRewardView");

		// Token: 0x04013826 RID: 79910
		public static readonly EUiViewName MoraleAreaInfoView = new EUiViewName("MoraleAreaInfoView");

		// Token: 0x04013827 RID: 79911
		public static readonly EUiViewName MoraleAreaSumView = new EUiViewName("MoraleAreaSumView");

		// Token: 0x04013828 RID: 79912
		public static readonly EUiViewName MoraleBuffAddTips = new EUiViewName("MoraleBuffAddTips");

		// Token: 0x04013829 RID: 79913
		public static readonly EUiViewName MoraleBuffActiveTips = new EUiViewName("MoraleBuffActiveTips");

		// Token: 0x0401382A RID: 79914
		public static readonly EUiViewName MoraleAreaProgressTips = new EUiViewName("MoraleAreaProgressTips");

		// Token: 0x0401382B RID: 79915
		public static readonly EUiViewName MoralePrompt = new EUiViewName("MoralePrompt");

		// Token: 0x0401382C RID: 79916
		public static readonly EUiViewName MoraleAreaBuffActiveTips = new EUiViewName("MoraleAreaBuffActiveTips");

		// Token: 0x0401382D RID: 79917
		public static readonly EUiViewName TrapDefenseMainView = new EUiViewName("TrapDefenseMainView");

		// Token: 0x0401382E RID: 79918
		public static readonly EUiViewName TrapDefenseBdSumView = new EUiViewName("TrapDefenseBdSumView");

		// Token: 0x0401382F RID: 79919
		public static readonly EUiViewName TrapDefenseBdQualityView = new EUiViewName("TrapDefenseBdQualityView");

		// Token: 0x04013830 RID: 79920
		public static readonly EUiViewName TrapDefenseBdBuffSelectView = new EUiViewName("TrapDefenseBdBuffSelectView");

		// Token: 0x04013831 RID: 79921
		public static readonly EUiViewName TrapDefenseBdBuffGetView = new EUiViewName("TrapDefenseBdBuffGetView");

		// Token: 0x04013832 RID: 79922
		public static readonly EUiViewName TrapDefenseBdBuffStrengthenView = new EUiViewName("TrapDefenseBdBuffStrengthenView");

		// Token: 0x04013833 RID: 79923
		public static readonly EUiViewName TrapDefenseRoundTips = new EUiViewName("TrapDefenseRoundTips");

		// Token: 0x04013834 RID: 79924
		public static readonly EUiViewName TrapDefenseEventTerrainChangeTips = new EUiViewName("TrapDefenseEventTerrainChangeTips");

		// Token: 0x04013835 RID: 79925
		public static readonly EUiViewName TrapDefenseEventShopOpenTips = new EUiViewName("TrapDefenseEventShopOpenTips");

		// Token: 0x04013836 RID: 79926
		public static readonly EUiViewName TrapDefenseEventBossComingTips = new EUiViewName("TrapDefenseEventBossComingTips");

		// Token: 0x04013837 RID: 79927
		public static readonly EUiViewName TrapDefenseRewardView = new EUiViewName("TrapDefenseRewardView");

		// Token: 0x04013838 RID: 79928
		public static readonly EUiViewName TrapDefenseBuildingDevelopMainView = new EUiViewName("TrapDefenseBuildingDevelopMainView");

		// Token: 0x04013839 RID: 79929
		public static readonly EUiViewName TrapDefenseBuildingDevelopPreviewView = new EUiViewName("TrapDefenseBuildingDevelopPreviewView");

		// Token: 0x0401383A RID: 79930
		public static readonly EUiViewName TrapDefenseBuildingDevelopBranchSelectView = new EUiViewName("TrapDefenseBuildingDevelopBranchSelectView");

		// Token: 0x0401383B RID: 79931
		public static readonly EUiViewName TrapDefensePauseView = new EUiViewName("TrapDefensePauseView");

		// Token: 0x0401383C RID: 79932
		public static readonly EUiViewName TrapDefenseCountDownTips = new EUiViewName("TrapDefenseCountDownTips");

		// Token: 0x0401383D RID: 79933
		public static readonly EUiViewName TrapDefenseResultView = new EUiViewName("TrapDefenseResultView");

		// Token: 0x0401383E RID: 79934
		public static readonly EUiViewName TrapDefenseBuildingMachineInfoView = new EUiViewName("TrapDefenseBuildingMachineInfoView");

		// Token: 0x0401383F RID: 79935
		public static readonly EUiViewName TrapDefenseBuildingGangsInfoView = new EUiViewName("TrapDefenseBuildingGangsInfoView");

		// Token: 0x04013840 RID: 79936
		public static readonly EUiViewName TrapDefenseMonsterView = new EUiViewName("TrapDefenseMonsterView");

		// Token: 0x04013841 RID: 79937
		public static readonly EUiViewName TrapDefenseTalentTreeView = new EUiViewName("TrapDefenseTalentTreeView");

		// Token: 0x04013842 RID: 79938
		public static readonly EUiViewName TrapDefenseFixedRewardView = new EUiViewName("TrapDefenseFixedRewardView");

		// Token: 0x04013843 RID: 79939
		public static readonly EUiViewName TrapDefenseMainLevelView = new EUiViewName("TrapDefenseMainLevelView");

		// Token: 0x04013844 RID: 79940
		public static readonly EUiViewName TrapDefenseRougeLevelView = new EUiViewName("TrapDefenseRougeLevelView");

		// Token: 0x04013845 RID: 79941
		public static readonly EUiViewName TrapDefenseMapView = new EUiViewName("TrapDefenseMapView");

		// Token: 0x04013846 RID: 79942
		public static readonly EUiViewName TrapDefenseShopView = new EUiViewName("TrapDefenseShopView");

		// Token: 0x04013847 RID: 79943
		public static readonly EUiViewName TrapDefenseTransitionView = new EUiViewName("TrapDefenseTransitionView");

		// Token: 0x04013848 RID: 79944
		public static readonly EUiViewName TrapDefenseActivityUnlockView = new EUiViewName("TrapDefenseActivityUnlockView");

		// Token: 0x04013849 RID: 79945
		public static readonly EUiViewName TermExplanationCenterView = new EUiViewName("TermExplanationCenterView");

		// Token: 0x0401384A RID: 79946
		public static readonly EUiViewName TermExplanationSideView = new EUiViewName("TermExplanationSideView");

		// Token: 0x0401384B RID: 79947
		public static readonly EUiViewName FloroRanchTermExplanationCenterView = new EUiViewName("FloroRanchTermExplanationCenterView");

		// Token: 0x0401384C RID: 79948
		public static readonly EUiViewName FloroRanchTermExplanationSideView = new EUiViewName("FloroRanchTermExplanationSideView");

		// Token: 0x0401384D RID: 79949
		public static readonly EUiViewName BirthdayRoleSelectView = new EUiViewName("BirthdayRoleSelectView");

		// Token: 0x0401384E RID: 79950
		public static readonly EUiViewName BirthdaySelectConfirmView = new EUiViewName("BirthdaySelectConfirmView");

		// Token: 0x0401384F RID: 79951
		public static readonly EUiViewName BirthdayLetterView = new EUiViewName("BirthdayLetterView");

		// Token: 0x04013850 RID: 79952
		public static readonly EUiViewName CumulativeShopTaskView = new EUiViewName("CumulativeShopTaskView");

		// Token: 0x04013851 RID: 79953
		public static readonly EUiViewName RogueBattleFallbackView = new EUiViewName("RogueBattleFallbackView");

		// Token: 0x04013852 RID: 79954
		public static readonly EUiViewName RailSlideView = new EUiViewName("RailSlideView");

		// Token: 0x04013853 RID: 79955
		public static readonly EUiViewName MotorcycleRailMoveView = new EUiViewName("MotorcycleRailMoveView");

		// Token: 0x04013854 RID: 79956
		public static readonly EUiViewName ResDownLoadView = new EUiViewName("ResDownLoadView");

		// Token: 0x04013855 RID: 79957
		public static readonly EUiViewName ResDownLoadMeOutOfMemoryView = new EUiViewName("ResDownLoadMeOutOfMemoryView");

		// Token: 0x04013856 RID: 79958
		public static readonly EUiViewName ResDownLoadLoadingView = new EUiViewName("ResDownLoadLoadingView");

		// Token: 0x04013857 RID: 79959
		public static readonly EUiViewName MoraleIndomitableLevelView = new EUiViewName("MoraleIndomitableLevelView");

		// Token: 0x04013858 RID: 79960
		public static readonly EUiViewName MoraleOccupiedSuccessView = new EUiViewName("MoraleOccupiedSuccessView");

		// Token: 0x04013859 RID: 79961
		public static readonly EUiViewName MoraleLevelDecreaseView = new EUiViewName("MoraleLevelDecreaseView");

		// Token: 0x0401385A RID: 79962
		public static readonly EUiViewName PlotArtWord2dView = new EUiViewName("PlotArtWord2dView");

		// Token: 0x0401385B RID: 79963
		public static readonly EUiViewName ShowerInviteView = new EUiViewName("ShowerInviteView");

		// Token: 0x0401385C RID: 79964
		public static readonly EUiViewName ShowerMainView = new EUiViewName("ShowerMainView");

		// Token: 0x0401385D RID: 79965
		public static readonly EUiViewName QuestReviewMainView = new EUiViewName("QuestReviewMainView");

		// Token: 0x0401385E RID: 79966
		public static readonly EUiViewName QuestReviewDetailView = new EUiViewName("QuestReviewDetailView");

		// Token: 0x0401385F RID: 79967
		public static readonly EUiViewName QuestReviewTipsView = new EUiViewName("QuestReviewTipsView");

		// Token: 0x04013860 RID: 79968
		public static readonly EUiViewName FilterSettingView = new EUiViewName("FilterSettingView");

		// Token: 0x04013861 RID: 79969
		public static readonly EUiViewName BeginnerCarnivalMainView = new EUiViewName("BeginnerCarnivalMainView");

		// Token: 0x04013862 RID: 79970
		public static readonly EUiViewName BeginnerCarnivalRoleTaskView = new EUiViewName("BeginnerCarnivalRoleTaskView");

		// Token: 0x04013863 RID: 79971
		public static readonly EUiViewName BeginnerCarnivalChoseRoleView = new EUiViewName("BeginnerCarnivalChoseRoleView");

		// Token: 0x04013864 RID: 79972
		public static readonly EUiViewName BeginnerCarnivalTaskView = new EUiViewName("BeginnerCarnivalTaskView");

		// Token: 0x04013865 RID: 79973
		public static readonly EUiViewName BeginnerCarnivalUnlockTipView = new EUiViewName("BeginnerCarnivalUnlockTipView");

		// Token: 0x04013866 RID: 79974
		public static readonly EUiViewName ActivityUnlockTipSevenHillsView = new EUiViewName("ActivityUnlockTipSevenHillsView");

		// Token: 0x04013867 RID: 79975
		public static readonly EUiViewName SevenHillsMainView = new EUiViewName("SevenHillsMainView");

		// Token: 0x04013868 RID: 79976
		public static readonly EUiViewName SevenHillsStageTaskView = new EUiViewName("SevenHillsStageTaskView");

		// Token: 0x04013869 RID: 79977
		public static readonly EUiViewName FloroRanchActivityView = new EUiViewName("FloroRanchActivityView");

		// Token: 0x0401386A RID: 79978
		public static readonly EUiViewName FloroRanchMainView = new EUiViewName("FloroRanchMainView");

		// Token: 0x0401386B RID: 79979
		public static readonly EUiViewName FloroRanchCardSelectView = new EUiViewName("FloroRanchCardSelectView");

		// Token: 0x0401386C RID: 79980
		public static readonly EUiViewName FloroRanchCardGroupSelectView = new EUiViewName("FloroRanchCardGroupSelectView");

		// Token: 0x0401386D RID: 79981
		public static readonly EUiViewName FloroRanchPhaseTargetView = new EUiViewName("FloroRanchPhaseTargetView");

		// Token: 0x0401386E RID: 79982
		public static readonly EUiViewName FloroRanchPhaseSettleView = new EUiViewName("FloroRanchPhaseSettleView");

		// Token: 0x0401386F RID: 79983
		public static readonly EUiViewName FloroRanchCommonTipsView = new EUiViewName("FloroRanchCommonTipsView");

		// Token: 0x04013870 RID: 79984
		public static readonly EUiViewName FloroRanchDailySettleView = new EUiViewName("FloroRanchDailySettleView");

		// Token: 0x04013871 RID: 79985
		public static readonly EUiViewName FloroRanchDungeonSelectView = new EUiViewName("FloroRanchDungeonSelectView");

		// Token: 0x04013872 RID: 79986
		public static readonly EUiViewName FloroRanchGamePlayExplainView = new EUiViewName("FloroRanchGamePlayExplainView");

		// Token: 0x04013873 RID: 79987
		public static readonly EUiViewName FloroRanchGamePlayView = new EUiViewName("FloroRanchGamePlayView");

		// Token: 0x04013874 RID: 79988
		public static readonly EUiViewName FloroRanchHandBookView = new EUiViewName("FloroRanchHandBookView");

		// Token: 0x04013875 RID: 79989
		public static readonly EUiViewName FloroRanchLimitRewardView = new EUiViewName("FloroRanchLimitRewardView");

		// Token: 0x04013876 RID: 79990
		public static readonly EUiViewName FloroRanchPermanentRewardView = new EUiViewName("FloroRanchPermanentRewardView");

		// Token: 0x04013877 RID: 79991
		public static readonly EUiViewName FloroRanchRaceSelectView = new EUiViewName("FloroRanchRaceSelectView");

		// Token: 0x04013878 RID: 79992
		public static readonly EUiViewName FloroRanchRandomEventView = new EUiViewName("FloroRanchRandomEventView");

		// Token: 0x04013879 RID: 79993
		public static readonly EUiViewName FloroRanchShopView = new EUiViewName("FloroRanchShopView");

		// Token: 0x0401387A RID: 79994
		public static readonly EUiViewName FloroRanchShopTipView = new EUiViewName("FloroRanchShopTipView");

		// Token: 0x0401387B RID: 79995
		public static readonly EUiViewName FloroRanchSkillView = new EUiViewName("FloroRanchSkillView");

		// Token: 0x0401387C RID: 79996
		public static readonly EUiViewName FloroRanchTechnologyView = new EUiViewName("FloroRanchTechnologyView");

		// Token: 0x0401387D RID: 79997
		public static readonly EUiViewName FloroRanchIncomeDetailView = new EUiViewName("FloroRanchIncomeDetailView");

		// Token: 0x0401387E RID: 79998
		public static readonly EUiViewName FloroRanchDungeonFailSettleView = new EUiViewName("FloroRanchDungeonFailSettleView");

		// Token: 0x0401387F RID: 79999
		public static readonly EUiViewName FloroRanchDungeonEndlessSettleView = new EUiViewName("FloroRanchDungeonEndlessSettleView");

		// Token: 0x04013880 RID: 80000
		public static readonly EUiViewName FloroRanchDungeonSuccessSettleView = new EUiViewName("FloroRanchDungeonSuccessSettleView");

		// Token: 0x04013881 RID: 80001
		public static readonly EUiViewName FloroRanchConfirmBoxView = new EUiViewName("FloroRanchConfirmBoxView");

		// Token: 0x04013882 RID: 80002
		public static readonly EUiViewName FloroRanchPauseView = new EUiViewName("FloroRanchPauseView");

		// Token: 0x04013883 RID: 80003
		public static readonly EUiViewName FloroRanchSkillTipView = new EUiViewName("FloroRanchSkillTipView");

		// Token: 0x04013884 RID: 80004
		public static readonly EUiViewName FloroRanchHelpView = new EUiViewName("FloroRanchHelpView");

		// Token: 0x04013885 RID: 80005
		public static readonly EUiViewName FloroRanchComicView = new EUiViewName("FloroRanchComicView");

		// Token: 0x04013886 RID: 80006
		public static readonly EUiViewName FloroRanchComicView2 = new EUiViewName("FloroRanchComicView2");

		// Token: 0x04013887 RID: 80007
		public static readonly EUiViewName FloroRanchComicView3 = new EUiViewName("FloroRanchComicView3");

		// Token: 0x04013888 RID: 80008
		public static readonly EUiViewName FloroRanchComicView4 = new EUiViewName("FloroRanchComicView4");

		// Token: 0x04013889 RID: 80009
		public static readonly EUiViewName FloroRanchUnlockTipView = new EUiViewName("FloroRanchUnlockTipView");

		// Token: 0x0401388A RID: 80010
		public static readonly EUiViewName FloroRanchWeeklyMainView = new EUiViewName("FloroRanchWeeklyMainView");

		// Token: 0x0401388B RID: 80011
		public static readonly EUiViewName FloroRanchRecommendTipView = new EUiViewName("FloroRanchRecommendTipView");

		// Token: 0x0401388C RID: 80012
		public static readonly EUiViewName KingShipMainView = new EUiViewName("KingShipMainView");

		// Token: 0x0401388D RID: 80013
		public static readonly EUiViewName KingShipLoadingView = new EUiViewName("KingShipLoadingView");

		// Token: 0x0401388E RID: 80014
		public static readonly EUiViewName KingShipResultView = new EUiViewName("KingShipResultView");

		// Token: 0x0401388F RID: 80015
		public static readonly EUiViewName KingShipPlotView = new EUiViewName("KingShipPlotView");

		// Token: 0x04013890 RID: 80016
		public static readonly EUiViewName KingShipFailView = new EUiViewName("KingShipFailView");

		// Token: 0x04013891 RID: 80017
		public static readonly EUiViewName LifePointDrawDetailView = new EUiViewName("LifePointDrawDetailView");

		// Token: 0x04013892 RID: 80018
		public static readonly EUiViewName LifePointDrawEntranceView = new EUiViewName("LifePointDrawEntranceView");

		// Token: 0x04013893 RID: 80019
		public static readonly EUiViewName NightmareLordFloatTips = new EUiViewName("NightmareLordFloatTips");

		// Token: 0x04013894 RID: 80020
		public static readonly EUiViewName NightmareSpawnPointFloatTips = new EUiViewName("NightmareSpawnPointFloatTips");

		// Token: 0x04013895 RID: 80021
		public static readonly EUiViewName HonamiStoryMainLoadingView = new EUiViewName("HonamiStoryMainLoadingView");

		// Token: 0x04013896 RID: 80022
		public static readonly EUiViewName HonamiStorySmallLoadingView = new EUiViewName("HonamiStorySmallLoadingView");

		// Token: 0x04013897 RID: 80023
		public static readonly EUiViewName HonamiStoryInventoryView = new EUiViewName("HonamiStoryInventoryView");

		// Token: 0x04013898 RID: 80024
		public static readonly EUiViewName HonamiStoryBackpackView = new EUiViewName("HonamiStoryBackpackView");

		// Token: 0x04013899 RID: 80025
		public static readonly EUiViewName HonamiStoryPickUpBackpackView = new EUiViewName("HonamiStoryPickUpBackpackView");

		// Token: 0x0401389A RID: 80026
		public static readonly EUiViewName HonamiStoryPickUpMobileView = new EUiViewName("HonamiStoryPickUpMobileView");

		// Token: 0x0401389B RID: 80027
		public static readonly EUiViewName HonamiStorySettleSuccessView = new EUiViewName("HonamiStorySettleSuccessView");

		// Token: 0x0401389C RID: 80028
		public static readonly EUiViewName HonamiStorySettleFailView = new EUiViewName("HonamiStorySettleFailView");

		// Token: 0x0401389D RID: 80029
		public static readonly EUiViewName HonamiStorySellConfirmBoxView = new EUiViewName("HonamiStorySellConfirmBoxView");

		// Token: 0x0401389E RID: 80030
		public static readonly EUiViewName HonamiStoryMascotCollectBookView = new EUiViewName("HonamiStoryMascotCollectBookView");

		// Token: 0x0401389F RID: 80031
		public static readonly EUiViewName HonamiStoryQuestView = new EUiViewName("HonamiStoryQuestView");

		// Token: 0x040138A0 RID: 80032
		public static readonly EUiViewName HonamiStoryQuestFinishView = new EUiViewName("HonamiStoryQuestFinishView");

		// Token: 0x040138A1 RID: 80033
		public static readonly EUiViewName HonamiStoryShopView = new EUiViewName("HonamiStoryShopView");

		// Token: 0x040138A2 RID: 80034
		public static readonly EUiViewName HonamiStoryPermanentTaskView = new EUiViewName("HonamiStoryPermanentTaskView");

		// Token: 0x040138A3 RID: 80035
		public static readonly EUiViewName HonamiStoryLimitTaskView = new EUiViewName("HonamiStoryLimitTaskView");

		// Token: 0x040138A4 RID: 80036
		public static readonly EUiViewName HonamiStoryScoreRewardView = new EUiViewName("HonamiStoryScoreRewardView");

		// Token: 0x040138A5 RID: 80037
		public static readonly EUiViewName HonamiStoryTechnologyView = new EUiViewName("HonamiStoryTechnologyView");

		// Token: 0x040138A6 RID: 80038
		public static readonly EUiViewName HonamiStoryLevelInfoView = new EUiViewName("HonamiStoryLevelInfoView");

		// Token: 0x040138A7 RID: 80039
		public static readonly EUiViewName HonamiStoryItemCollectView = new EUiViewName("HonamiStoryItemCollectView");

		// Token: 0x040138A8 RID: 80040
		public static readonly EUiViewName HonamiStoryMainView = new EUiViewName("HonamiStoryMainView");

		// Token: 0x040138A9 RID: 80041
		public static readonly EUiViewName HonamiStoryWeaponSelectView = new EUiViewName("HonamiStoryWeaponSelectView");

		// Token: 0x040138AA RID: 80042
		public static readonly EUiViewName HonamiStoryTechSuccessEffectView = new EUiViewName("HonamiStoryTechSuccessEffectView");

		// Token: 0x040138AB RID: 80043
		public static readonly EUiViewName HonamiStoryLeaveTip = new EUiViewName("HonamiStoryLeaveTip");

		// Token: 0x040138AC RID: 80044
		public static readonly EUiViewName HonamiStoryPollutionLevelUpdateView = new EUiViewName("HonamiStoryPollutionLevelUpdateView");

		// Token: 0x040138AD RID: 80045
		public static readonly EUiViewName HonamiStorySafeLeaveUpdateView = new EUiViewName("HonamiStorySafeLeaveUpdateView");

		// Token: 0x040138AE RID: 80046
		public static readonly EUiViewName HonamiStoryUnlockTipView = new EUiViewName("HonamiStoryUnlockTipView");

		// Token: 0x040138AF RID: 80047
		public static readonly EUiViewName HonamiStoryNewTipsView = new EUiViewName("HonamiStoryNewTipsView");

		// Token: 0x040138B0 RID: 80048
		public static readonly EUiViewName HonamiWeaponRewardView = new EUiViewName("HonamiWeaponRewardView");

		// Token: 0x040138B1 RID: 80049
		public static readonly EUiViewName HonamiStoryLoadingView = new EUiViewName("HonamiStoryLoadingView");

		// Token: 0x040138B2 RID: 80050
		public static readonly EUiViewName CommonGameMainView = new EUiViewName("CommonGameMainView");

		// Token: 0x040138B3 RID: 80051
		public static readonly EUiViewName CommonTouchUiEditView = new EUiViewName("CommonTouchUiEditView");

		// Token: 0x040138B4 RID: 80052
		public static readonly EUiViewName AstrologyItemInspectView = new EUiViewName("AstrologyItemInspectView");

		// Token: 0x040138B5 RID: 80053
		public static readonly EUiViewName SeekTraceView = new EUiViewName("SeekTraceView");

		// Token: 0x040138B6 RID: 80054
		public static readonly EUiViewName SeekTraceStartView = new EUiViewName("SeekTraceStartView");

		// Token: 0x040138B7 RID: 80055
		public static readonly EUiViewName GreatSwordLevelSelectView = new EUiViewName("GreatSwordLevelSelectView");

		// Token: 0x040138B8 RID: 80056
		public static readonly EUiViewName GreatSwordCountDownView = new EUiViewName("GreatSwordCountDownView");

		// Token: 0x040138B9 RID: 80057
		public static readonly EUiViewName GreatSwordOpenTipsView = new EUiViewName("GreatSwordOpenTipsView");

		// Token: 0x040138BA RID: 80058
		public static readonly EUiViewName AnchorGameplayView = new EUiViewName("AnchorGameplayView");

		// Token: 0x040138BB RID: 80059
		public static readonly EUiViewName Theme26UnlockTipView = new EUiViewName("Theme26UnlockTipView");

		// Token: 0x040138BC RID: 80060
		public static readonly EUiViewName Theme26MainView = new EUiViewName("Theme26MainView");

		// Token: 0x040138BD RID: 80061
		public static readonly EUiViewName Theme26StageTaskView = new EUiViewName("Theme26StageTaskView");

		// Token: 0x040138BE RID: 80062
		public static readonly EUiViewName ActivityFunPlayView = new EUiViewName("ActivityFunPlayView");

		// Token: 0x040138BF RID: 80063
		public static readonly EUiViewName LineCrossEntranceView = new EUiViewName("LineCrossEntranceView");

		// Token: 0x040138C0 RID: 80064
		public static readonly EUiViewName LineCrossDetailView = new EUiViewName("LineCrossDetailView");

		// Token: 0x040138C1 RID: 80065
		public static readonly EUiViewName MoonSignInMainView = new EUiViewName("MoonSignInMainView");

		// Token: 0x040138C2 RID: 80066
		public static readonly EUiViewName MoonSignInDetailView = new EUiViewName("MoonSignInDetailView");

		// Token: 0x040138C3 RID: 80067
		public static readonly EUiViewName MoonSignInRewardView = new EUiViewName("MoonSignInRewardView");

		// Token: 0x040138C4 RID: 80068
		public static readonly EUiViewName SurvivorsTalentTreeView = new EUiViewName("SurvivorsTalentTreeView");

		// Token: 0x040138C5 RID: 80069
		public static readonly EUiViewName SurvivorsTalentUnlockView = new EUiViewName("SurvivorsTalentUnlockView");

		// Token: 0x040138C6 RID: 80070
		public static readonly EUiViewName SurvivorsTeamEditView = new EUiViewName("SurvivorsTeamEditView");

		// Token: 0x040138C7 RID: 80071
		public static readonly EUiViewName SurvivorsHandbookView = new EUiViewName("SurvivorsHandbookView");

		// Token: 0x040138C8 RID: 80072
		public static readonly EUiViewName SurvivorsRogueEvolveView = new EUiViewName("SurvivorsRogueEvolveView");

		// Token: 0x040138C9 RID: 80073
		public static readonly EUiViewName SurvivorsRogueGeneralObtainView = new EUiViewName("SurvivorsRogueGeneralObtainView");

		// Token: 0x040138CA RID: 80074
		public static readonly EUiViewName SurvivorsRogueShopView = new EUiViewName("SurvivorsRogueShopView");

		// Token: 0x040138CB RID: 80075
		public static readonly EUiViewName SurvivorsRogueSettleView = new EUiViewName("SurvivorsRogueSettleView");

		// Token: 0x040138CC RID: 80076
		public static readonly EUiViewName SurvivorsRogueSettleExternalView = new EUiViewName("SurvivorsRogueSettleExternalView");

		// Token: 0x040138CD RID: 80077
		public static readonly EUiViewName SurvivorsRogueExitView = new EUiViewName("SurvivorsRogueExitView");

		// Token: 0x040138CE RID: 80078
		public static readonly EUiViewName SurvivorsRogueRewardView = new EUiViewName("SurvivorsRogueRewardView");

		// Token: 0x040138CF RID: 80079
		public static readonly EUiViewName SurvivorsRogueMainView = new EUiViewName("SurvivorsRogueMainView");

		// Token: 0x040138D0 RID: 80080
		public static readonly EUiViewName SurvivorsRogueActivityUnlockView = new EUiViewName("SurvivorsRogueActivityUnlockView");

		// Token: 0x040138D1 RID: 80081
		public static readonly EUiViewName SurvivorsLevelDetailView = new EUiViewName("SurvivorsLevelDetailView");

		// Token: 0x040138D2 RID: 80082
		public static readonly EUiViewName SurvivorsTabMainView = new EUiViewName("SurvivorsTabMainView");

		// Token: 0x040138D3 RID: 80083
		public static readonly EUiViewName SurvivorsCardTips = new EUiViewName("SurvivorsCardTips");

		// Token: 0x040138D4 RID: 80084
		public static readonly EUiViewName SurvivorsWeaponUnlockView = new EUiViewName("SurvivorsWeaponUnlockView");

		// Token: 0x040138D5 RID: 80085
		public static readonly EUiViewName SurvivorsAttributeDetailView = new EUiViewName("SurvivorsAttributeDetailView");

		// Token: 0x040138D6 RID: 80086
		public static readonly EUiViewName SurvivorsWeaponAttributeView = new EUiViewName("SurvivorsWeaponAttributeView");

		// Token: 0x040138D7 RID: 80087
		public static readonly EUiViewName RoleDevRootView = new EUiViewName("RoleDevRootView");

		// Token: 0x040138D8 RID: 80088
		public static readonly EUiViewName RoleSkillMergeView = new EUiViewName("RoleSkillMergeView");

		// Token: 0x040138D9 RID: 80089
		public static readonly EUiViewName RoleDevelopRootView = new EUiViewName("RoleDevelopRootView");

		// Token: 0x040138DA RID: 80090
		public static readonly EUiViewName RoleDevelopSelectTargetView = new EUiViewName("RoleDevelopSelectTargetView");

		// Token: 0x040138DB RID: 80091
		public static readonly EUiViewName ItemHintViewNew = new EUiViewName("ItemHintViewNew");

		// Token: 0x040138DC RID: 80092
		public static readonly EUiViewName QuestTreeMainView = new EUiViewName("QuestTreeMainView");

		// Token: 0x040138DD RID: 80093
		public static readonly EUiViewName QuestTreeChapterView = new EUiViewName("QuestTreeChapterView");

		// Token: 0x040138DE RID: 80094
		public static readonly EUiViewName QuestTreeNodeDetailView = new EUiViewName("QuestTreeNodeDetailView");

		// Token: 0x040138DF RID: 80095
		public static readonly EUiViewName QuestTreeNodeImageView = new EUiViewName("QuestTreeNodeImageView");

		// Token: 0x040138E0 RID: 80096
		public static readonly EUiViewName QuestTreeAvailableListView = new EUiViewName("QuestTreeAvailableListView");

		// Token: 0x040138E1 RID: 80097
		public static readonly EUiViewName PersonalPlayerTitleUnLockTipsView = new EUiViewName("PersonalPlayerTitleUnLockTipsView");

		// Token: 0x040138E2 RID: 80098
		public static readonly EUiViewName VisionSettlementFloatTips = new EUiViewName("VisionSettlementFloatTips");

		// Token: 0x040138E3 RID: 80099
		public static readonly EUiViewName EyeProtectView = new EUiViewName("EyeProtectView");

		// Token: 0x040138E4 RID: 80100
		public static readonly EUiViewName CsViewProxy = new EUiViewName("CsViewProxy");

		// Token: 0x040138E5 RID: 80101
		public static readonly EUiViewName InfrastructureMainView = new EUiViewName("InfrastructureMainView");

		// Token: 0x040138E6 RID: 80102
		public static readonly EUiViewName InfrArchiveMainView = new EUiViewName("InfrArchiveMainView");

		// Token: 0x040138E7 RID: 80103
		public static readonly EUiViewName InfrastructureSettleView = new EUiViewName("InfrastructureSettleView");

		// Token: 0x040138E8 RID: 80104
		public static readonly EUiViewName InfrLimitTaskMainView = new EUiViewName("InfrLimitTaskMainView");

		// Token: 0x040138E9 RID: 80105
		public static readonly EUiViewName InfrastructureShopMainView = new EUiViewName("InfrastructureShopMainView");

		// Token: 0x040138EA RID: 80106
		public static readonly EUiViewName InfrRoadNetworkMainView = new EUiViewName("InfrRoadNetworkMainView");

		// Token: 0x040138EB RID: 80107
		public static readonly EUiViewName InfrMaterialsDeliveryView = new EUiViewName("InfrMaterialsDeliveryView");

		// Token: 0x040138EC RID: 80108
		public static readonly EUiViewName InfrRoadNetworkInfoView = new EUiViewName("InfrRoadNetworkInfoView");

		// Token: 0x040138ED RID: 80109
		public static readonly EUiViewName InfrOpeningTipsView = new EUiViewName("InfrOpeningTipsView");

		// Token: 0x040138EE RID: 80110
		public static readonly EUiViewName RegionalTerminalOverviewView = new EUiViewName("RegionalTerminalOverviewView");

		// Token: 0x040138EF RID: 80111
		public static readonly EUiViewName VillageInfrMainView = new EUiViewName("VillageInfrMainView");

		// Token: 0x040138F0 RID: 80112
		public static readonly EUiViewName VillageInfrTaskMainView = new EUiViewName("VillageInfrTaskMainView");

		// Token: 0x040138F1 RID: 80113
		public static readonly EUiViewName VillageInfrBuildFinishTipView = new EUiViewName("VillageInfrBuildFinishTipView");

		// Token: 0x040138F2 RID: 80114
		public static readonly EUiViewName VillageInfrWorldBuildView = new EUiViewName("VillageInfrWorldBuildView");

		// Token: 0x040138F3 RID: 80115
		public static readonly EUiViewName VillageInfrBuildInfoView = new EUiViewName("VillageInfrBuildInfoView");

		// Token: 0x040138F4 RID: 80116
		public static readonly EUiViewName VillageInfrNewTipsView = new EUiViewName("VillageInfrNewTipsView");

		// Token: 0x040138F5 RID: 80117
		public static readonly EUiViewName PrizeDrawingMainView = new EUiViewName("PrizeDrawingMainView");

		// Token: 0x040138F6 RID: 80118
		public static readonly EUiViewName PrizeDrawingTearView = new EUiViewName("PrizeDrawingTearView");

		// Token: 0x040138F7 RID: 80119
		public static readonly EUiViewName PilotThrowView = new EUiViewName("PilotThrowView");

		// Token: 0x040138F8 RID: 80120
		public static readonly EUiViewName DeadEyeModeView = new EUiViewName("DeadEyeJumpRampView");

		// Token: 0x040138F9 RID: 80121
		public static readonly EUiViewName DeadEyeFloaterShooterView = new EUiViewName("DeadEyeFloaterShooterView");

		// Token: 0x040138FA RID: 80122
		public static readonly EUiViewName SynthesisTipsInfoView = new EUiViewName("SynthesisTipsInfoView");

		// Token: 0x040138FB RID: 80123
		public static readonly EUiViewName ActivityPreWarmMainView = new EUiViewName("ActivityPreWarmMainView");

		// Token: 0x040138FC RID: 80124
		public static readonly EUiViewName AdvanceNoticeRootView = new EUiViewName("AdvanceNoticeRootView");

		// Token: 0x040138FD RID: 80125
		public static readonly EUiViewName SubPackageDownLoadView = new EUiViewName("SubPackageDownLoadView");

		// Token: 0x040138FE RID: 80126
		public static readonly EUiViewName SubPackageDownLoadFreeSpaceTipsView = new EUiViewName("SubPackageDownLoadFreeSpaceTipsView");

		// Token: 0x040138FF RID: 80127
		public static readonly EUiViewName SubPackageDownLoadClearTipsView = new EUiViewName("SubPackageDownLoadClearTipsView");

		// Token: 0x04013900 RID: 80128
		public static readonly EUiViewName SubPackageDownLoadMobileClearPopView = new EUiViewName("SubPackageDownLoadMobileClearPopView");

		// Token: 0x04013901 RID: 80129
		public static readonly EUiViewName ArtemisActivityRoleChatView = new EUiViewName("ArtemisActivityRoleChatView");

		// Token: 0x04013902 RID: 80130
		public static readonly EUiViewName ArtemisActivityCertificationView = new EUiViewName("ArtemisActivityCertificationView");

		// Token: 0x04013903 RID: 80131
		public static readonly EUiViewName ArtemisQteView = new EUiViewName("ArtemisQteView");

		// Token: 0x04013904 RID: 80132
		public static readonly EUiViewName WeatherCentralMainView = new EUiViewName("WeatherCentralMainView");

		// Token: 0x04013905 RID: 80133
		public static readonly EUiViewName WeatherUnlockTips = new EUiViewName("WeatherUnlockTips");

		// Token: 0x04013906 RID: 80134
		public static readonly EUiViewName MotorcycleRootView = new EUiViewName("MotorcycleRootView");

		// Token: 0x04013907 RID: 80135
		public static readonly EUiViewName MotorcycleRewardPreviewView = new EUiViewName("MotorcycleRewardPreviewView");

		// Token: 0x04013908 RID: 80136
		public static readonly EUiViewName MotorcycleTechTreeDetailView = new EUiViewName("MotorcycleTechTreeDetailView");

		// Token: 0x04013909 RID: 80137
		public static readonly EUiViewName MotorcycleTechTreeLevelDetailView = new EUiViewName("MotorcycleTechTreeLevelDetailView");

		// Token: 0x0401390A RID: 80138
		public static readonly EUiViewName MotorcycleTechTreeLevelUpEffectView = new EUiViewName("MotorcycleTechTreeLevelUpEffectView");

		// Token: 0x0401390B RID: 80139
		public static readonly EUiViewName MotorcycleLevelAttrDetailView = new EUiViewName("MotorcycleLevelAttrDetailView");

		// Token: 0x0401390C RID: 80140
		public static readonly EUiViewName MotorcycleConditionView = new EUiViewName("MotorcycleConditionView");

		// Token: 0x0401390D RID: 80141
		public static readonly EUiViewName MotorcycleLevelUpView = new EUiViewName("MotorcycleLevelUpView");

		// Token: 0x0401390E RID: 80142
		public static readonly EUiViewName MotorcycleTechTreeSwitchView = new EUiViewName("MotorcycleTechTreeSwitchView");

		// Token: 0x0401390F RID: 80143
		public static readonly EUiViewName MotorcycleDiyRootView = new EUiViewName("MotorcycleDiyRootView");

		// Token: 0x04013910 RID: 80144
		public static readonly EUiViewName MotorcycleDiyEditRootView = new EUiViewName("MotorcycleDiyEditRootView");

		// Token: 0x04013911 RID: 80145
		public static readonly EUiViewName MotorcycleDiyImportPresetView = new EUiViewName("MotorcycleDiyImportPresetView");

		// Token: 0x04013912 RID: 80146
		public static readonly EUiViewName MotorcycleDiyOverviewView = new EUiViewName("MotorcycleDiyOverviewView");

		// Token: 0x04013913 RID: 80147
		public static readonly EUiViewName MotorcycleDiyEditOverviewView = new EUiViewName("MotorcycleDiyEditOverviewView");

		// Token: 0x04013914 RID: 80148
		public static readonly EUiViewName MotorcycleDiyStickerPreviewView = new EUiViewName("MotorcycleDiyStickerPreviewView");

		// Token: 0x04013915 RID: 80149
		public static readonly EUiViewName MotorcycleDiyDecorationPreviewView = new EUiViewName("MotorcycleDiyDecorationPreviewView");

		// Token: 0x04013916 RID: 80150
		public static readonly EUiViewName MotorcycleDiyNameInputView = new EUiViewName("MotorcycleDiyNameInputView");

		// Token: 0x04013917 RID: 80151
		public static readonly EUiViewName MotorcycleDiySkinView = new EUiViewName("MotorcycleDiySkinView");

		// Token: 0x04013918 RID: 80152
		public static readonly EUiViewName MotorcycleScenePopupView = new EUiViewName("MotorcycleScenePopupView");

		// Token: 0x04013919 RID: 80153
		public static readonly EUiViewName MotorLinkageRewardView = new EUiViewName("MotoLinkageRewardView");

		// Token: 0x0401391A RID: 80154
		public static readonly EUiViewName MotorcycleTogetherView = new EUiViewName("MotorcycleTogetherView");

		// Token: 0x0401391B RID: 80155
		public static readonly EUiViewName MotorcycleCountDownView = new EUiViewName("MotorcycleCountDownView");

		// Token: 0x0401391C RID: 80156
		public static readonly EUiViewName MotorcycleMusicPlayerView = new EUiViewName("MotorcycleMusicPlayerView");

		// Token: 0x0401391D RID: 80157
		public static readonly EUiViewName MotorcycleMusicDetailView = new EUiViewName("MotorcycleMusicDetailView");

		// Token: 0x0401391E RID: 80158
		public static readonly EUiViewName MotorcycleMusicSortView = new EUiViewName("MotorcycleMusicSortView");

		// Token: 0x0401391F RID: 80159
		public static readonly EUiViewName MotorMusicNewMusicTips = new EUiViewName("MotorMusicNewMusicTips");

		// Token: 0x04013920 RID: 80160
		public static readonly EUiViewName PhoneMsgTipViewA = new EUiViewName("PhoneMsgTipViewA");

		// Token: 0x04013921 RID: 80161
		public static readonly EUiViewName PhoneMsgTipViewB = new EUiViewName("PhoneMsgTipViewB");

		// Token: 0x04013922 RID: 80162
		public static readonly EUiViewName PhoneMsgTipViewC = new EUiViewName("PhoneMsgTipViewC");

		// Token: 0x04013923 RID: 80163
		public static readonly EUiViewName PhoneMsgPanelViewBig = new EUiViewName("PhoneMsgPanelViewBig");

		// Token: 0x04013924 RID: 80164
		public static readonly EUiViewName PhoneMsgPanelViewSmall = new EUiViewName("PhoneMsgPanelViewSmall");

		// Token: 0x04013925 RID: 80165
		public static readonly EUiViewName PhoneMsgSettingView = new EUiViewName("PhoneMsgSettingView");

		// Token: 0x04013926 RID: 80166
		public static readonly EUiViewName PhoneMsgLoadingView = new EUiViewName("PhoneMsgLoadingView");

		// Token: 0x04013927 RID: 80167
		public static readonly EUiViewName PhoneViewFilterPanel = new EUiViewName("PhoneViewFilterPanel");

		// Token: 0x04013928 RID: 80168
		public static readonly EUiViewName ActivityTagInfoHelpView = new EUiViewName("ActivityTagInfoHelpView");

		// Token: 0x04013929 RID: 80169
		public static readonly EUiViewName PanoramicPointUnlockTipsView = new EUiViewName("PanoramicPointUnlockTipsView");

		// Token: 0x0401392A RID: 80170
		public static readonly EUiViewName LaHaiLuoCollectView = new EUiViewName("LaHaiLuoCollectView");

		// Token: 0x0401392B RID: 80171
		public static readonly EUiViewName RiLingCollectView = new EUiViewName("LaHaiLuoCollectView");

		// Token: 0x0401392C RID: 80172
		public static readonly EUiViewName CookSchoolMechanismRootView = new EUiViewName("CookSchoolMechanismRootView");

		// Token: 0x0401392D RID: 80173
		public static readonly EUiViewName RoadBookMainView = new EUiViewName("RoadBookMainView");

		// Token: 0x0401392E RID: 80174
		public static readonly EUiViewName RoadBookTravelTaskView = new EUiViewName("RoadBookTravelTaskView");

		// Token: 0x0401392F RID: 80175
		public static readonly EUiViewName RoadBookVehicleTaskView = new EUiViewName("RoadBookVehicleTaskView");

		// Token: 0x04013930 RID: 80176
		public static readonly EUiViewName RoadBookPhantomTaskView = new EUiViewName("RoadBookPhantomTaskView");

		// Token: 0x04013931 RID: 80177
		public static readonly EUiViewName RoadBookLevelTipsView = new EUiViewName("RoadBookLevelTipsView");

		// Token: 0x04013932 RID: 80178
		public static readonly EUiViewName ActivityUnlockTipRoadBookView = new EUiViewName("ActivityUnlockTipRoadBookView");

		// Token: 0x04013933 RID: 80179
		public static readonly EUiViewName DeviceInfoView = new EUiViewName("DeviceInfoView");

		// Token: 0x04013934 RID: 80180
		public static readonly EUiViewName FeedbackRewardMainView = new EUiViewName("FeedbackRewardMainView");

		// Token: 0x04013935 RID: 80181
		public static readonly EUiViewName FeedbackRewardStartView = new EUiViewName("FeedbackRewardStartView");

		// Token: 0x04013936 RID: 80182
		public static readonly EUiViewName TotalTopUpPreviewView = new EUiViewName("TotalTopUpPreviewView");

		// Token: 0x04013937 RID: 80183
		public static readonly EUiViewName TotalTopUpPickRoleRewardView = new EUiViewName("TotalTopUpPickRoleRewardView");

		// Token: 0x04013938 RID: 80184
		public static readonly EUiViewName TotalTopUp37VideoFullScreenView = new EUiViewName("TotalTopUp37VideoFullScreenView");

		// Token: 0x04013939 RID: 80185
		public static readonly EUiViewName KurotatoTabMainView = new EUiViewName("KurotatoTabMainView");

		// Token: 0x0401393A RID: 80186
		public static readonly EUiViewName KurotatoAttrSelectMainView = new EUiViewName("KurotatoAttrSelectMainView");

		// Token: 0x0401393B RID: 80187
		public static readonly EUiViewName KurotatoBoxDropMainView = new EUiViewName("KurotatoBoxDropMainView");

		// Token: 0x0401393C RID: 80188
		public static readonly EUiViewName KurotatoContentView = new EUiViewName("KurotatoContentView");

		// Token: 0x0401393D RID: 80189
		public static readonly EUiViewName KurotatoShopMainView = new EUiViewName("KurotatoShopMainView");

		// Token: 0x0401393E RID: 80190
		public static readonly EUiViewName KurotatoAttributeDetailView = new EUiViewName("KurotatoAttributeDetailView");

		// Token: 0x0401393F RID: 80191
		public static readonly EUiViewName KurotatoPopupDetailView = new EUiViewName("KurotatoPopupDetailView");

		// Token: 0x04013940 RID: 80192
		public static readonly EUiViewName KurotatoPopupItemDetailView = new EUiViewName("KurotatoPopupItemDetailView");

		// Token: 0x04013941 RID: 80193
		public static readonly EUiViewName KurotatoSettleView = new EUiViewName("KurotatoSettleView");

		// Token: 0x04013942 RID: 80194
		public static readonly EUiViewName KurotatoPauseView = new EUiViewName("KurotatoPauseView");

		// Token: 0x04013943 RID: 80195
		public static readonly EUiViewName KurotatoPopupWeaponDetailView = new EUiViewName("KurotatoPopupWeaponDetailView");

		// Token: 0x04013944 RID: 80196
		public static readonly EUiViewName KurotatoPopupUnlockRoleView = new EUiViewName("KurotatoPopupUnlockRoleView");

		// Token: 0x04013945 RID: 80197
		public static readonly EUiViewName KurotatoMainView = new EUiViewName("KurotatoMainView");

		// Token: 0x04013946 RID: 80198
		public static readonly EUiViewName KurotatoEnemyDetailBookMainView = new EUiViewName("KurotatoEnemyDetailBookMainView");

		// Token: 0x04013947 RID: 80199
		public static readonly EUiViewName KurotatoLimitedTimeRewardView = new EUiViewName("KurotatoLimitedTimeRewardView");

		// Token: 0x04013948 RID: 80200
		public static readonly EUiViewName KurotatoNormalRewardView = new EUiViewName("KurotatoNormalRewardView");

		// Token: 0x04013949 RID: 80201
		public static readonly EUiViewName KurotatoHandBookView = new EUiViewName("KurotatoHandBookView");

		// Token: 0x0401394A RID: 80202
		public static readonly EUiViewName KurotatoRoleSelectView = new EUiViewName("KurotatoRoleSelectView");

		// Token: 0x0401394B RID: 80203
		public static readonly EUiViewName KurotatoLevelSelectView = new EUiViewName("KurotatoLevelSelectView");

		// Token: 0x0401394C RID: 80204
		public static readonly EUiViewName KurotatoActivityOpenView = new EUiViewName("KurotatoActivityOpenView");

		// Token: 0x0401394D RID: 80205
		public static readonly EUiViewName KurotatoPopupSaveView = new EUiViewName("KurotatoPopupSaveView");

		// Token: 0x0401394E RID: 80206
		public static readonly EUiViewName KurotatoShopOpenTipView = new EUiViewName("KurotatoShopOpenTipView");

		// Token: 0x0401394F RID: 80207
		public static readonly EUiViewName ActivityFeiXuePreheatMainView = new EUiViewName("ActivityFeiXuePreheatConfirmView");

		// Token: 0x04013950 RID: 80208
		public static readonly EUiViewName FeiXuePreheatMainView = new EUiViewName("FeiXuePreheatMainView");

		// Token: 0x04013951 RID: 80209
		public static readonly EUiViewName FeiXuePreheatRewardView = new EUiViewName("FeiXuePreheatRewardView");

		// Token: 0x04013952 RID: 80210
		public static readonly EUiViewName DropCatchLevelSelectView = new EUiViewName("DropCatchLevelSelectView");

		// Token: 0x04013953 RID: 80211
		public static readonly EUiViewName DropCatchRoleDetailView = new EUiViewName("DropCatchRoleDetailView");

		// Token: 0x04013954 RID: 80212
		public static readonly EUiViewName DropCatchDropItemDetailView = new EUiViewName("DropCatchDropItemDetailView");

		// Token: 0x04013955 RID: 80213
		public static readonly EUiViewName DropCatchGameplayView = new EUiViewName("DropCatchGameplayView");

		// Token: 0x04013956 RID: 80214
		public static readonly EUiViewName DropCatchGameplayPauseView = new EUiViewName("DropCatchGameplayPauseView");

		// Token: 0x04013957 RID: 80215
		public static readonly EUiViewName DropCatchGameplayResultView = new EUiViewName("DropCatchGameplayResultView");

		// Token: 0x04013958 RID: 80216
		public static readonly EUiViewName DropCatchStartGameView = new EUiViewName("DropCatchStartGameView");

		// Token: 0x04013959 RID: 80217
		public static readonly EUiViewName DropCatchChatPopView = new EUiViewName("DropCatchChatPopView");

		// Token: 0x0401395A RID: 80218
		public static readonly EUiViewName SpringManorAlbumPropView = new EUiViewName("Spring26AlbumPropView");

		// Token: 0x0401395B RID: 80219
		public static readonly EUiViewName SpringManorBrochureView = new EUiViewName("Spring26BrochureView");

		// Token: 0x0401395C RID: 80220
		public static readonly EUiViewName SpringManorAlbumView = new EUiViewName("Spring26AlbumView");

		// Token: 0x0401395D RID: 80221
		public static readonly EUiViewName SpringManorBrochureDetailView = new EUiViewName("Spring26BrochureDetailView");

		// Token: 0x0401395E RID: 80222
		public static readonly EUiViewName SpringManorBrochureCompletedView = new EUiViewName("Spring26BrochureCompletedView");

		// Token: 0x0401395F RID: 80223
		public static readonly EUiViewName DrinksSelectRoleView = new EUiViewName("DrinksSelectRoleView");

		// Token: 0x04013960 RID: 80224
		public static readonly EUiViewName DrinksGameplayView = new EUiViewName("DrinksGameplayView");

		// Token: 0x04013961 RID: 80225
		public static readonly EUiViewName DrinksShowView = new EUiViewName("DrinksShowView");

		// Token: 0x04013962 RID: 80226
		public static readonly EUiViewName ActivityGamePlayPlotView = new EUiViewName("ActivityGamePlayPlotView");

		// Token: 0x04013963 RID: 80227
		public static readonly EUiViewName GuessJokerGamePlayView = new EUiViewName("GuessJokerGamePlayView");

		// Token: 0x04013964 RID: 80228
		public static readonly EUiViewName GuessJokerSelectRoleView = new EUiViewName("GuessJokerSelectRoleView");

		// Token: 0x04013965 RID: 80229
		public static readonly EUiViewName GuessJokerSettleWinView = new EUiViewName("GuessJokerSettleWinView");

		// Token: 0x04013966 RID: 80230
		public static readonly EUiViewName GuessJokerSettleFailView = new EUiViewName("GuessJokerSettleFailView");

		// Token: 0x04013967 RID: 80231
		public static readonly EUiViewName GuessJokerFloatTipsView = new EUiViewName("GuessJokerFloatTipsView");

		// Token: 0x04013968 RID: 80232
		public static readonly EUiViewName EncirclePlayView = new EUiViewName("EncirclePlayView");

		// Token: 0x04013969 RID: 80233
		public static readonly EUiViewName EncircleLevelDetailView = new EUiViewName("EncircleLevelDetailView");

		// Token: 0x0401396A RID: 80234
		public static readonly EUiViewName EncircleSelectLevelView = new EUiViewName("EncircleSelectLevelView");

		// Token: 0x0401396B RID: 80235
		public static readonly EUiViewName EncircleResultView = new EUiViewName("EncircleResultView");

		// Token: 0x0401396C RID: 80236
		public static readonly EUiViewName RoleSkinRewardView = new EUiViewName("RoleSkinRewardView");

		// Token: 0x0401396D RID: 80237
		public static readonly EUiViewName SunSpiritHintView = new EUiViewName("SunSpiritHintView");

		// Token: 0x0401396E RID: 80238
		public static readonly EUiViewName SunSpiritLauncherHintView = new EUiViewName("SunSpiritLauncherHintView");

		// Token: 0x0401396F RID: 80239
		public static readonly EUiViewName FurnitureDesignView = new EUiViewName("FurnitureDesignView");

		// Token: 0x04013970 RID: 80240
		public static readonly EUiViewName FurniturePresetView = new EUiViewName("FurniturePresetView");

		// Token: 0x04013971 RID: 80241
		public static readonly EUiViewName FurnitureHandBookView = new EUiViewName("FurnitureHandBookView");

		// Token: 0x04013972 RID: 80242
		public static readonly EUiViewName FurnitureGetWayView = new EUiViewName("FurnitureGetWayView");

		// Token: 0x04013973 RID: 80243
		public static readonly EUiViewName FurnitureAreaSelectView = new EUiViewName("FurnitureAreaSelectView");

		// Token: 0x04013974 RID: 80244
		public static readonly EUiViewName FurnitureShopView = new EUiViewName("FurnitureShopView");

		// Token: 0x04013975 RID: 80245
		public static readonly EUiViewName MotorRaceSettlementView = new EUiViewName("MotorRaceSettlementView");

		// Token: 0x04013976 RID: 80246
		public static readonly EUiViewName MotorParkourMainView = new EUiViewName("MotorParkourMainView");

		// Token: 0x04013977 RID: 80247
		public static readonly EUiViewName MotorParkourRewardView = new EUiViewName("MotorParkourRewardView");

		// Token: 0x04013978 RID: 80248
		public static readonly EUiViewName MotorParkourSettleView = new EUiViewName("MotorParkourSettleView");

		// Token: 0x04013979 RID: 80249
		public static readonly EUiViewName MotorParkourBattleView = new EUiViewName("MotorParkourBattleView");

		// Token: 0x0401397A RID: 80250
		public static readonly EUiViewName MotorParkourTimerView = new EUiViewName("MotorParkourTimerView");

		// Token: 0x0401397B RID: 80251
		public static readonly EUiViewName CoopRoleSelectView = new EUiViewName("CoopRoleSelectView");

		// Token: 0x0401397C RID: 80252
		public static readonly EUiViewName CoopEntranceView = new EUiViewName("CoopEntranceView");

		// Token: 0x0401397D RID: 80253
		public static readonly EUiViewName CoopUpGrateView = new EUiViewName("CoopUpGrateView");

		// Token: 0x0401397E RID: 80254
		public static readonly EUiViewName CoopSpRewardView = new EUiViewName("CoopSpRewardView");

		// Token: 0x0401397F RID: 80255
		public static readonly EUiViewName CoopPhotoPreviewView = new EUiViewName("CoopPhotoPreviewView");

		// Token: 0x04013980 RID: 80256
		public static readonly EUiViewName RollBlockView = new EUiViewName("RollBlockView");

		// Token: 0x04013981 RID: 80257
		public static readonly EUiViewName PhantomInteractSummonView = new EUiViewName("PhantomInteractSummonView");

		// Token: 0x04013982 RID: 80258
		public static readonly EUiViewName PhantomInteractEditView = new EUiViewName("PhantomInteractEditView");

		// Token: 0x04013983 RID: 80259
		public static readonly EUiViewName ActivityNewPlayerSupportTrialRoleView = new EUiViewName("ActivityNewPlayerSupportTrialRoleView");

		// Token: 0x04013984 RID: 80260
		public static readonly EUiViewName ActivityNewPlayerSupportRewardView = new EUiViewName("ActivityNewPlayerSupportRewardView");

		// Token: 0x04013985 RID: 80261
		public static readonly EUiViewName ActivityNewPlayerSupportStartupView = new EUiViewName("ActivityNewPlayerSupportStartupView");

		// Token: 0x04013986 RID: 80262
		public static readonly EUiViewName NewPlayerAdventureV2View = new EUiViewName("NewPlayerAdventureV2View");

		// Token: 0x04013987 RID: 80263
		public static readonly EUiViewName MotorcycleArrowCollectionSelectView = new EUiViewName("MotorcycleArrowCollectionSelectView");

		// Token: 0x04013988 RID: 80264
		public static readonly EUiViewName MotorFightMainView = new EUiViewName("MotorFightMainView");

		// Token: 0x04013989 RID: 80265
		public static readonly EUiViewName MotorcycleArrowCollectionTipsView = new EUiViewName("MotorcycleArrowCollectionTipsView");

		// Token: 0x0401398A RID: 80266
		public static readonly EUiViewName MotorFightRewardView = new EUiViewName("MotorFightRewardView");

		// Token: 0x0401398B RID: 80267
		public static readonly EUiViewName MotorFightHandBookView = new EUiViewName("MotorFightHandBookView");

		// Token: 0x0401398C RID: 80268
		public static readonly EUiViewName MotorFightTalentTreeView = new EUiViewName("MotorFightTalentTreeView");

		// Token: 0x0401398D RID: 80269
		public static readonly EUiViewName MotorFightRankView = new EUiViewName("MotorFightRankView");

		// Token: 0x0401398E RID: 80270
		public static readonly EUiViewName MotorFightRankDetailView = new EUiViewName("MotorFightRankDetailView");

		// Token: 0x0401398F RID: 80271
		public static readonly EUiViewName MotorFightLevelDetailView = new EUiViewName("MotorFightLevelDetailView");

		// Token: 0x04013990 RID: 80272
		public static readonly EUiViewName MotorFightRoleSelectView = new EUiViewName("MotorFightRoleSelectView");

		// Token: 0x04013991 RID: 80273
		public static readonly EUiViewName MotorFightSuccessView = new EUiViewName("MotorFightSuccessView");

		// Token: 0x04013992 RID: 80274
		public static readonly EUiViewName MotorFightFailView = new EUiViewName("MotorFightFailView");

		// Token: 0x04013993 RID: 80275
		public static readonly EUiViewName MotorFightPauseView = new EUiViewName("MotorFightPauseView");

		// Token: 0x04013994 RID: 80276
		public static readonly EUiViewName MotorFightArchiveTip = new EUiViewName("MotorFightArchiveTip");

		// Token: 0x04013995 RID: 80277
		public static readonly EUiViewName MotorFightAttrDetailView = new EUiViewName("MotorFightAttrDetailView");

		// Token: 0x04013996 RID: 80278
		public static readonly EUiViewName MotorFightItemTips = new EUiViewName("MotorFightItemTips");

		// Token: 0x04013997 RID: 80279
		public static readonly EUiViewName SpringManorAtmosphereLevelView = new EUiViewName("Spring26AtmosphereLevelView");

		// Token: 0x04013998 RID: 80280
		public static readonly EUiViewName SpringManorRewardView = new EUiViewName("Spring26RewardView");

		// Token: 0x04013999 RID: 80281
		public static readonly EUiViewName SpringManorQuestView = new EUiViewName("Spring26QuestView");

		// Token: 0x0401399A RID: 80282
		public static readonly EUiViewName SpringManorLoadingView = new EUiViewName("Spring26LoadingView");

		// Token: 0x0401399B RID: 80283
		public static readonly EUiViewName SpringManorHudView = new EUiViewName("Spring26HudView");

		// Token: 0x0401399C RID: 80284
		public static readonly EUiViewName SpringManorGameplayEntryView = new EUiViewName("Spring26GameplayEntryView");

		// Token: 0x0401399D RID: 80285
		public static readonly EUiViewName SpringManorAtmosphereLevelUpView = new EUiViewName("Spring26AtmosphereLevelUpView");

		// Token: 0x0401399E RID: 80286
		public static readonly EUiViewName SpringManorUnlockView = new EUiViewName("Spring26UnlockView");

		// Token: 0x0401399F RID: 80287
		public static readonly EUiViewName SpringManorWeaponExhibitView = new EUiViewName("Spring26WeaponExhibitView");

		// Token: 0x040139A0 RID: 80288
		public static readonly EUiViewName SpringManorPhantomExhibitView = new EUiViewName("Spring26PhantomExhibitView");

		// Token: 0x040139A1 RID: 80289
		public static readonly EUiViewName SpringManorActivityOpenView = new EUiViewName("Spring26ActivityOpenView");

		// Token: 0x040139A2 RID: 80290
		public static readonly EUiViewName SpringManorRoleSwitchView = new EUiViewName("Spring26RoleSelectView");

		// Token: 0x040139A3 RID: 80291
		public static readonly EUiViewName RegressBpMainView = new EUiViewName("RegressBpMainView");

		// Token: 0x040139A4 RID: 80292
		public static readonly EUiViewName RegressBpBuyLevelView = new EUiViewName("RegressBpBuyLevelView");

		// Token: 0x040139A5 RID: 80293
		public static readonly EUiViewName RegressBpPayView = new EUiViewName("RegressBpPayView");

		// Token: 0x040139A6 RID: 80294
		public static readonly EUiViewName RegressBpLevelUpTipsView = new EUiViewName("RegressBpLevelUpTipsView");

		// Token: 0x040139A7 RID: 80295
		public static readonly EUiViewName FindSunSpiritView = new EUiViewName("FindSunSpiritView");

		// Token: 0x040139A8 RID: 80296
		public static readonly EUiViewName RhythmShipCalibrationView = new EUiViewName("RhythmShipCalibrationView");

		// Token: 0x040139A9 RID: 80297
		public static readonly EUiViewName RhythmShipChoseLevelView = new EUiViewName("RhythmShipChoseLevelView");

		// Token: 0x040139AA RID: 80298
		public static readonly EUiViewName RhythmShipQuickSelectLevelView = new EUiViewName("RhythmShipQuickSelectLevelView");

		// Token: 0x040139AB RID: 80299
		public static readonly EUiViewName RhythmShipChoseRoleView = new EUiViewName("RhythmShipChoseRoleView");

		// Token: 0x040139AC RID: 80300
		public static readonly EUiViewName RhythmShipRatingView = new EUiViewName("RhythmShipRatingView");

		// Token: 0x040139AD RID: 80301
		public static readonly EUiViewName RhythmShipTaskView = new EUiViewName("RhythmShipTaskView");

		// Token: 0x040139AE RID: 80302
		public static readonly EUiViewName RhythmShipLimitTaskView = new EUiViewName("RhythmShipLimitTaskView");

		// Token: 0x040139AF RID: 80303
		public static readonly EUiViewName RhythmShipSettlementView = new EUiViewName("RhythmShipSettlementView");

		// Token: 0x040139B0 RID: 80304
		public static readonly EUiViewName RhythmShipPauseView = new EUiViewName("RhythmShipPauseView");

		// Token: 0x040139B1 RID: 80305
		public static readonly EUiViewName RhythmShipSetView = new EUiViewName("RhythmShipSetView");

		// Token: 0x040139B2 RID: 80306
		public static readonly EUiViewName RhythmShipSetTipsView = new EUiViewName("RhythmShipSetTipsView");

		// Token: 0x040139B3 RID: 80307
		public static readonly EUiViewName RhythmShipGameView = new EUiViewName("RhythmShipGameView");

		// Token: 0x040139B4 RID: 80308
		public static readonly EUiViewName RhythmShipGameEndTipView = new EUiViewName("RhythmShipGameEndTipView");

		// Token: 0x040139B5 RID: 80309
		public static readonly EUiViewName TetrisPlayView = new EUiViewName("TetrisPlayView");

		// Token: 0x040139B6 RID: 80310
		public static readonly EUiViewName TetrisLevelDetailView = new EUiViewName("TetrisLevelDetailView");

		// Token: 0x040139B7 RID: 80311
		public static readonly EUiViewName TetrisSelectLevelView = new EUiViewName("TetrisSelectLevelView");

		// Token: 0x040139B8 RID: 80312
		public static readonly EUiViewName TetrisTipsWinView = new EUiViewName("TetrisTipsWinView");

		// Token: 0x040139B9 RID: 80313
		public static readonly EUiViewName TetrisTipsTargetView = new EUiViewName("TetrisTipsTargetView");

		// Token: 0x040139BA RID: 80314
		public static readonly EUiViewName TetrisTipsLoseView = new EUiViewName("TetrisTipsLoseView");

		// Token: 0x040139BB RID: 80315
		public static readonly EUiViewName TetrisTipsEndLessEndView = new EUiViewName("TetrisTipsEndLessEndView");

		// Token: 0x040139BC RID: 80316
		public static readonly EUiViewName TetrisTipsEndLessStartView = new EUiViewName("TetrisTipsEndLessStartView");

		// Token: 0x040139BD RID: 80317
		public static readonly EUiViewName TetrisLoadingView = new EUiViewName("TetrisLoadingView");

		// Token: 0x040139BE RID: 80318
		public static readonly EUiViewName ChatPopView = new EUiViewName("ChatPopView");

		// Token: 0x040139BF RID: 80319
		public static readonly EUiViewName MenuDetailPopView = new EUiViewName("MenuDetailPopView");

		// Token: 0x040139C0 RID: 80320
		public static readonly EUiViewName FlagChallengeRewardView = new EUiViewName("FlagChallengeRewardView");

		// Token: 0x040139C1 RID: 80321
		public static readonly EUiViewName FlagChallengeSelectRoleView = new EUiViewName("FlagChallengeSelectRoleView");

		// Token: 0x040139C2 RID: 80322
		public static readonly EUiViewName FlagChallengeBuffView = new EUiViewName("FlagChallengeBuffView");

		// Token: 0x040139C3 RID: 80323
		public static readonly EUiViewName FlagChallengeOccupiedSuccessView = new EUiViewName("FlagChallengeOccupiedSuccessView");

		// Token: 0x040139C4 RID: 80324
		public static readonly EUiViewName FlagChallengeSettleView = new EUiViewName("FlagChallengeSettleView");

		// Token: 0x040139C5 RID: 80325
		public static readonly EUiViewName FlagChallengeReviveView = new EUiViewName("FlagChallengeReviveView");

		// Token: 0x040139C6 RID: 80326
		public static readonly EUiViewName FlagChallengePauseView = new EUiViewName("FlagChallengePauseView");

		// Token: 0x040139C7 RID: 80327
		public static readonly EUiViewName FlagChallengeMainView = new EUiViewName("FlagChallengeMainView");

		// Token: 0x040139C8 RID: 80328
		public static readonly EUiViewName FlagChallengeAreaDetailView = new EUiViewName("FlagChallengeAreaDetailView");

		// Token: 0x040139C9 RID: 80329
		public static readonly EUiViewName FlagChallengeBuffActiveTips = new EUiViewName("FlagChallengeBuffActiveTips");

		// Token: 0x040139CA RID: 80330
		public static readonly EUiViewName FlagChallengePrompt = new EUiViewName("FlagChallengePrompt");

		// Token: 0x040139CB RID: 80331
		public static readonly EUiViewName PhantomFilterPopupView = new EUiViewName("PhantomFilterPopupView");

		// Token: 0x040139CC RID: 80332
		public static readonly EUiViewName PhantomBatchConfirmPopupView = new EUiViewName("PhantomBatchConfirmPopupView");

		// Token: 0x040139CD RID: 80333
		public static readonly EUiViewName PhantomMainPropertyPopupView = new EUiViewName("PhantomMainPropertyPopupView");

		// Token: 0x040139CE RID: 80334
		public static readonly EUiViewName PhantomSmartDiscardPopupView = new EUiViewName("PhantomSmartDiscardPopupView");

		// Token: 0x040139CF RID: 80335
		public static readonly EUiViewName PhantomStackCountPopupView = new EUiViewName("PhantomStackCountPopupView");

		// Token: 0x040139D0 RID: 80336
		public static readonly EUiViewName WheelTowerRoundSelectView = new EUiViewName("WheelTowerRoundSelectView");

		// Token: 0x040139D1 RID: 80337
		public static readonly EUiViewName WheelTowerBuffSelectView = new EUiViewName("WheelTowerBuffSelectView");

		// Token: 0x040139D2 RID: 80338
		public static readonly EUiViewName WheelTowerTeamSelectView = new EUiViewName("WheelTowerTeamSelectView");

		// Token: 0x040139D3 RID: 80339
		public static readonly EUiViewName WheelTowerModeSelectView = new EUiViewName("WheelTowerModeSelectView");

		// Token: 0x040139D4 RID: 80340
		public static readonly EUiViewName WheelTowerResultView = new EUiViewName("WheelTowerResultView");

		// Token: 0x040139D5 RID: 80341
		public static readonly EUiViewName WheelTowerRewardView = new EUiViewName("WheelTowerRewardView");

		// Token: 0x040139D6 RID: 80342
		public static readonly EUiViewName WheelTowerRecordPopup = new EUiViewName("WheelTowerRecordPopup");

		// Token: 0x040139D7 RID: 80343
		public static readonly EUiViewName WheelTowerRoundTipsView = new EUiViewName("WheelTowerRoundTipsView");

		// Token: 0x040139D8 RID: 80344
		public static readonly EUiViewName WheelTowerMainView = new EUiViewName("WheelTowerMainView");

		// Token: 0x040139D9 RID: 80345
		public static readonly EUiViewName WheelTowerModeDetailView = new EUiViewName("WheelTowerModeDetailView");

		// Token: 0x040139DA RID: 80346
		public static readonly EUiViewName WheelTowerPrepareView = new EUiViewName("WheelTowerPrepareView");

		// Token: 0x040139DB RID: 80347
		public static readonly EUiViewName WheelTowerEnhanceRoleView = new EUiViewName("WheelTowerEnhanceRoleView");

		// Token: 0x040139DC RID: 80348
		public static readonly EUiViewName WheelTowerRecordView = new EUiViewName("WheelTowerRecordView");

		// Token: 0x040139DD RID: 80349
		public static readonly EUiViewName WheelTowerScoreLevelRuleView = new EUiViewName("WheelTowerScoreLevelRuleView");

		// Token: 0x040139DE RID: 80350
		public static readonly EUiViewName WheelTowerRecommendView = new EUiViewName("WheelTowerRecommendView");

		// Token: 0x040139DF RID: 80351
		public static readonly EUiViewName WheelTowerBossBuffTip = new EUiViewName("WheelTowerBossBuffTip");

		// Token: 0x040139E0 RID: 80352
		public static readonly EUiViewName WheelTowerLoadingView = new EUiViewName("WheelTowerLoadingView");

		// Token: 0x040139E1 RID: 80353
		public static readonly EUiViewName WheelTowerSettlementView = new EUiViewName("WheelTowerSettlementView");

		// Token: 0x040139E2 RID: 80354
		public static readonly EUiViewName WheelTowerBossHandBookView = new EUiViewName("WheelTowerBossHandBookView");

		// Token: 0x040139E3 RID: 80355
		public static readonly EUiViewName WheelTowerLimitRewardView = new EUiViewName("WheelTowerLimitRewardView");

		// Token: 0x040139E4 RID: 80356
		public static readonly EUiViewName WheelTowerSeasonRewardView = new EUiViewName("WheelTowerSeasonRewardView");

		// Token: 0x040139E5 RID: 80357
		public static readonly EUiViewName WheelTowerCoverRecordPopupView = new EUiViewName("WheelTowerCoverRecordPopupView");

		// Token: 0x040139E6 RID: 80358
		public static readonly EUiViewName WheelTowerReviewView = new EUiViewName("WheelTowerReviewView");

		// Token: 0x040139E7 RID: 80359
		public static readonly EUiViewName RoleSkillBranchPopView = new EUiViewName("RoleSkillBranchPopView");

		// Token: 0x040139E8 RID: 80360
		public static readonly EUiViewName ProjectorPuzzleView = new EUiViewName("ProjectorPuzzleView");

		// Token: 0x040139E9 RID: 80361
		public static readonly EUiViewName AdamSmasherSelectView = new EUiViewName("AdamSmasherSelectView");

		// Token: 0x040139EA RID: 80362
		public static readonly EUiViewName AdamSmasherFormationView = new EUiViewName("AdamSmasherFormationView");

		// Token: 0x040139EB RID: 80363
		public static readonly EUiViewName AdamSmasherChallengeFailView = new EUiViewName("AdamSmasherChallengeFailView");

		// Token: 0x040139EC RID: 80364
		public static readonly EUiViewName CyberPunkTrialRoleView = new EUiViewName("CyberPunkTrialRoleView");

		// Token: 0x040139ED RID: 80365
		public static readonly EUiViewName CyberPunkTaskView = new EUiViewName("CyberPunkTaskView");

		// Token: 0x040139EE RID: 80366
		public static readonly EUiViewName RoleDevelopWorldDropEnoughTips = new EUiViewName("RoleDevelopWorldDropEnoughTips");

		// Token: 0x040139EF RID: 80367
		public static readonly EUiViewName TetrisGameView = new EUiViewName("TetrisGameView");

		// Token: 0x040139F0 RID: 80368
		public static readonly EUiViewName TetrisSettlementView = new EUiViewName("TetrisSettlementView");

		// Token: 0x040139F1 RID: 80369
		public static readonly EUiViewName TetrisGameLoading = new EUiViewName("TetrisGameLoading");

		// Token: 0x040139F2 RID: 80370
		public static readonly EUiViewName WuWuLogisticsMissionView = new EUiViewName("WuWuLogisticsMissionView");

		// Token: 0x040139F3 RID: 80371
		public static readonly EUiViewName CyberpunkCountDownView = new EUiViewName("CyberpunkCountDownView");

		// Token: 0x040139F4 RID: 80372
		public static readonly EUiViewName CommonComicView = new EUiViewName("CommonComicView");

		// Token: 0x040139F5 RID: 80373
		public static readonly EUiViewName PinballComicView = new EUiViewName("PinballComicView");

		// Token: 0x040139F6 RID: 80374
		public static readonly EUiViewName BossPilingMainView = new EUiViewName("BossPilingMainView");

		// Token: 0x040139F7 RID: 80375
		public static readonly EUiViewName BossPilingLevelView = new EUiViewName("BossPilingLevelView");

		// Token: 0x040139F8 RID: 80376
		public static readonly EUiViewName BossPilingBuffView = new EUiViewName("BossPilingBuffView");

		// Token: 0x040139F9 RID: 80377
		public static readonly EUiViewName BossPilingLevelDescView = new EUiViewName("BossPilingLevelDescView");

		// Token: 0x040139FA RID: 80378
		public static readonly EUiViewName BossPilingTaskView = new EUiViewName("BossPilingTaskView");

		// Token: 0x040139FB RID: 80379
		public static readonly EUiViewName BossPilingSettleView = new EUiViewName("BossPilingSettleView");

		// Token: 0x040139FC RID: 80380
		public static readonly EUiViewName BossPilingKeyBuffFloatView = new EUiViewName("BossPilingKeyBuffFloatView");

		// Token: 0x040139FD RID: 80381
		public static readonly EUiViewName BossPilingNewBuffTipsView = new EUiViewName("BossPilingNewBuffTipsView");

		// Token: 0x040139FE RID: 80382
		public static readonly EUiViewName PinballRoleGainView = new EUiViewName("PinballRoleGainView");

		// Token: 0x040139FF RID: 80383
		public static readonly EUiViewName PinballSettleResultView = new EUiViewName("PinballSettleResultView");

		// Token: 0x04013A00 RID: 80384
		public static readonly EUiViewName PinballPlotView = new EUiViewName("PinballPlotView");

		// Token: 0x04013A01 RID: 80385
		public static readonly EUiViewName PinballMainRootView = new EUiViewName("PinballMainRootView");

		// Token: 0x04013A02 RID: 80386
		public static readonly EUiViewName PinballWeaponDecomposeView = new EUiViewName("PinballWeaponDecomposeView");

		// Token: 0x04013A03 RID: 80387
		public static readonly EUiViewName PinballRevivePopupView = new EUiViewName("PinballRevivePopupView");

		// Token: 0x04013A04 RID: 80388
		public static readonly EUiViewName PinballRoleView = new EUiViewName("PinballRoleView");

		// Token: 0x04013A05 RID: 80389
		public static readonly EUiViewName PinballShopView = new EUiViewName("PinballShopView");

		// Token: 0x04013A06 RID: 80390
		public static readonly EUiViewName PinballLimitedRewardView = new EUiViewName("PinballLimitedRewardView");

		// Token: 0x04013A07 RID: 80391
		public static readonly EUiViewName PinballPermanentRewardView = new EUiViewName("PinballPermanentRewardView");

		// Token: 0x04013A08 RID: 80392
		public static readonly EUiViewName PinballRankView = new EUiViewName("PinballRankView");

		// Token: 0x04013A09 RID: 80393
		public static readonly EUiViewName PinballExchangePopView = new EUiViewName("PinballExchangePopView");

		// Token: 0x04013A0A RID: 80394
		public static readonly EUiViewName PinballWeaponEquipView = new EUiViewName("PinballWeaponEquipView");

		// Token: 0x04013A0B RID: 80395
		public static readonly EUiViewName PinballFilterView = new EUiViewName("PinballFilterView");

		// Token: 0x04013A0C RID: 80396
		public static readonly EUiViewName PinballMainHelpView = new EUiViewName("PinballMainHelpView");

		// Token: 0x04013A0D RID: 80397
		public static readonly EUiViewName ActivityUnlockTipCatapultStoryView = new EUiViewName("ActivityUnlockTipCatapultStoryView");

		// Token: 0x04013A0E RID: 80398
		public static readonly EUiViewName PinballBubbleView = new EUiViewName("PinballBubbleView");

		// Token: 0x04013A0F RID: 80399
		public static readonly EUiViewName PinballBattlePauseView = new EUiViewName("PinballBattlePauseView");

		// Token: 0x04013A10 RID: 80400
		public static readonly EUiViewName PinballBossComingTipsView = new EUiViewName("PinballBossComingTipsView");

		// Token: 0x04013A11 RID: 80401
		public static readonly EUiViewName PinballFailureTipsView = new EUiViewName("PinballFailureTipsView");

		// Token: 0x04013A12 RID: 80402
		public static readonly EUiViewName PinballRoleSkillReleaseTipsView = new EUiViewName("PinballRoleSkillReleaseTipsView");

		// Token: 0x04013A13 RID: 80403
		public static readonly EUiViewName PinballSuccessTipsView = new EUiViewName("PinballSuccessTipsView");

		// Token: 0x04013A14 RID: 80404
		public static readonly EUiViewName PinballBossSkillTipsView = new EUiViewName("PinballBossSkillTipsView");

		// Token: 0x04013A15 RID: 80405
		public static readonly EUiViewName PinballRoleSkillMaxTipsView = new EUiViewName("PinballRoleSkillMaxTipsView");

		// Token: 0x04013A16 RID: 80406
		public static readonly EUiViewName PinballWaveStartTipsView = new EUiViewName("PinballWaveStartTipsView");

		// Token: 0x04013A17 RID: 80407
		public static readonly EUiViewName PinballWeaponDecomposeResultView = new EUiViewName("PinballWeaponDecomposeResultView");

		// Token: 0x04013A18 RID: 80408
		public static readonly EUiViewName PinballRoleSelectView = new EUiViewName("PinballRoleSelectView");

		// Token: 0x04013A19 RID: 80409
		public static readonly EUiViewName PinballFormationSelectRoleView = new EUiViewName("PinballFormationSelectRoleView");

		// Token: 0x04013A1A RID: 80410
		public static readonly EUiViewName PinballAttributeDetailView = new EUiViewName("PinballAttributeDetailView");

		// Token: 0x04013A1B RID: 80411
		public static readonly EUiViewName PinballFormationView = new EUiViewName("PinballFormationView");

		// Token: 0x04013A1C RID: 80412
		public static readonly EUiViewName PinballMonsterDetailView = new EUiViewName("PinballMonsterDetailView");

		// Token: 0x04013A1D RID: 80413
		public static readonly EUiViewName PinballLoadingView = new EUiViewName("PinballLoadingView");

		// Token: 0x04013A1E RID: 80414
		public static readonly EUiViewName SplineConstrainedDrag = new EUiViewName("SplineConstrainedDrag");

		// Token: 0x04013A1F RID: 80415
		public static readonly EUiViewName DollGrabMachineView = new EUiViewName("DollGrabMachineView");

		// Token: 0x04013A20 RID: 80416
		public static readonly EUiViewName DollGrabShowcaseInspectView = new EUiViewName("DollGrabShowcaseInspectView");

		// Token: 0x04013A21 RID: 80417
		public static readonly EUiViewName DollGrabShowcaseFocusView = new EUiViewName("DollGrabShowcaseFocusView");

		// Token: 0x04013A22 RID: 80418
		public static readonly EUiViewName DollGrabMachineCountDownView = new EUiViewName("DollGrabMachineCountDownView");

		// Token: 0x04013A23 RID: 80419
		public static readonly EUiViewName DollGrabFloatCountDownView = new EUiViewName("DollGrabFloatCountDownView");

		// Token: 0x04013A24 RID: 80420
		public static readonly EUiViewName DollGrabMachineTimeUpView = new EUiViewName("DollGrabMachineTimeUpView");

		// Token: 0x04013A25 RID: 80421
		public static readonly EUiViewName DollGrabMachineGetAllView = new EUiViewName("DollGrabMachineGetAllView");

		// Token: 0x04013A26 RID: 80422
		public static readonly EUiViewName DollGrabMachineSeltView = new EUiViewName("DollGrabMachineSeltView");

		// Token: 0x04013A27 RID: 80423
		public static readonly EUiViewName DollGrabMachinePauseView = new EUiViewName("DollGrabMachinePauseView");

		// Token: 0x04013A28 RID: 80424
		public static readonly EUiViewName DollGrabMachineHelpInfoView = new EUiViewName("DollGrabMachineHelpInfoView");

		// Token: 0x04013A29 RID: 80425
		public static readonly EUiViewName DollGrabDeliveryView = new EUiViewName("DollGrabDeliveryView");

		// Token: 0x04013A2A RID: 80426
		public static readonly EUiViewName DollGrabEndlessStartView = new EUiViewName("DollGrabEndlessStartView");

		// Token: 0x04013A2B RID: 80427
		public static readonly EUiViewName MachineryFactoryTouchMoveView = new EUiViewName("MachineryFactoryTouchMoveView");

		// Token: 0x04013A2C RID: 80428
		public static readonly EUiViewName MengZhouCollectView = new EUiViewName("MengZhouCollectView");

		// Token: 0x04013A2D RID: 80429
		public static readonly EUiViewName RealmBetweenMainView = new EUiViewName("RealmBetweenMainView");

		// Token: 0x04013A2E RID: 80430
		public static readonly EUiViewName RealmBetweenTravelTaskView = new EUiViewName("RealmBetweenTravelTaskView");

		// Token: 0x04013A2F RID: 80431
		public static readonly EUiViewName RealmBetweenPhantomTaskView = new EUiViewName("RealmBetweenPhantomTaskView");

		// Token: 0x04013A30 RID: 80432
		public static readonly EUiViewName RealmBetweenVehicleTaskView = new EUiViewName("RealmBetweenVehicleTaskView");

		// Token: 0x04013A31 RID: 80433
		public static readonly EUiViewName RealmBetweenLevelTipsView = new EUiViewName("RealmBetweenLevelTipsView");

		// Token: 0x04013A32 RID: 80434
		public static readonly EUiViewName ActivityUnlockTipRealmBetweenView = new EUiViewName("ActivityUnlockTipRealmBetweenView");

		// Token: 0x04013A33 RID: 80435
		public static readonly EUiViewName WriteLetterView = new EUiViewName("WriteLetterView");

		// Token: 0x04013A34 RID: 80436
		public static readonly EUiViewName LetterBackupDisplayView = new EUiViewName("LetterBackupDisplayView");

		// Token: 0x04013A35 RID: 80437
		public static readonly EUiViewName ProjectionPhotoView = new EUiViewName("ProjectionPhotoView");

		// Token: 0x04013A36 RID: 80438
		public static readonly EUiViewName GolemHackingGameView = new EUiViewName("GolemHackingGameView");

		// Token: 0x04013A37 RID: 80439
		public static readonly EUiViewName GolemHackingGameTipsPopView = new EUiViewName("GolemHackingGameTipsPopView");

		// Token: 0x04013A38 RID: 80440
		public static readonly EUiViewName GolemHackingResultPop = new EUiViewName("GolemHackingResultPop");

		// Token: 0x04013A39 RID: 80441
		public static readonly EUiViewName GolemHackingLevelMainView = new EUiViewName("GolemHackingLevelMainView");

		// Token: 0x04013A3A RID: 80442
		public static readonly EUiViewName GolemHackingLevelDetailView = new EUiViewName("GolemHackingLevelDetailView");

		// Token: 0x04013A3B RID: 80443
		public static readonly EUiViewName GachaAccumulateBonusView = new EUiViewName("GachaAccumulateBonusView");

		// Token: 0x04013A3C RID: 80444
		public static readonly EUiViewName ItemRewardSelectView = new EUiViewName("ItemRewardSelectView");

		// Token: 0x04013A3D RID: 80445
		public static readonly EUiViewName ItemConvertTipsView = new EUiViewName("ItemConvertTipsView");

		// Token: 0x04013A3E RID: 80446
		public static readonly EUiViewName ItemExpiredAutoConvertTipsView = new EUiViewName("ItemExpiredAutoConvertTipsView");

		// Token: 0x04013A3F RID: 80447
		public static readonly EUiViewName CommonQuickHackView = new EUiViewName("CommonQuickHackView");

		// Token: 0x04013A40 RID: 80448
		public static readonly EUiViewName BattleQuickHackView = new EUiViewName("BattleQuickHackView");

		// Token: 0x04013A41 RID: 80449
		public static readonly EUiViewName QuickHackCameraControlView = new EUiViewName("QuickHackCameraControlView");

		// Token: 0x04013A42 RID: 80450
		public static readonly EUiViewName MotorDecalLinkRewardView = new EUiViewName("MotorDecalLinkRewardView");

		// Token: 0x04013A43 RID: 80451
		public static readonly EUiViewName PlotWordArtView = new EUiViewName("PlotWordArtView");

		// Token: 0x04013A44 RID: 80452
		public static readonly EUiViewName PlotWordArtCaptionView = new EUiViewName("PlotWordArtCaptionView");

		// Token: 0x04013A45 RID: 80453
		public static readonly EUiViewName MultiMotorMainView = new EUiViewName("MultiMotorMainView");

		// Token: 0x04013A46 RID: 80454
		public static readonly EUiViewName MultiMotorChoseLevelView = new EUiViewName("MultiMotorChoseLevelView");

		// Token: 0x04013A47 RID: 80455
		public static readonly EUiViewName MultiMotorSettlementView = new EUiViewName("MultiMotorSettlementView");

		// Token: 0x04013A48 RID: 80456
		public static readonly EUiViewName MultiMotorRewardView = new EUiViewName("MultiMotorRewardView");

		// Token: 0x04013A49 RID: 80457
		public static readonly EUiViewName MoonTogetherMainView = new EUiViewName("MoonTogetherMainView");

		// Token: 0x04013A4A RID: 80458
		public static readonly EUiViewName MoonTogetherInviteView = new EUiViewName("MoonTogetherInviteView");

		// Token: 0x04013A4B RID: 80459
		public static readonly EUiViewName QteHourglassView = new EUiViewName("QteHourglassView");

		// Token: 0x04013A4C RID: 80460
		public static readonly EUiViewName QuestMultiLineView = new EUiViewName("QuestMultiLineView");

		// Token: 0x04013A4D RID: 80461
		public static readonly EUiViewName FirstPersonTurretView = new EUiViewName("FirstPersonTurretView");

		// Token: 0x04013A4E RID: 80462
		public static readonly EUiViewName QuestMultiLineTipsView = new EUiViewName("QuestMultiLineTipsView");

		// Token: 0x04013A4F RID: 80463
		public static readonly EUiViewName NewcomerSplashView = new EUiViewName("NewcomerSplashView");

		// Token: 0x04013A50 RID: 80464
		public static readonly EUiViewName NewcomerJourneyChoseRoleView = new EUiViewName("NewcomerJourneyChoseRoleView");

		// Token: 0x04013A51 RID: 80465
		public static readonly EUiViewName WuWaGoView = new EUiViewName("WuWaGoView");

		// Token: 0x04013A52 RID: 80466
		public static readonly EUiViewName WuWaGoPauseView = new EUiViewName("WuWaGoPauseView");

		// Token: 0x04013A53 RID: 80467
		public static readonly EUiViewName WuWaGoPopupView = new EUiViewName("WuWaGoPopupView");

		// Token: 0x04013A54 RID: 80468
		public static readonly EUiViewName WheelTowerMedalDetailView = new EUiViewName("WheelTowerMedalDetailView");

		// Token: 0x04013A55 RID: 80469
		public static readonly EUiViewName WheelTowerSeasonMedalView = new EUiViewName("WheelTowerSeasonMedalView");

		// Token: 0x04013A56 RID: 80470
		public static readonly EUiViewName WheelTowerSeasonOverviewView = new EUiViewName("WheelTowerSeasonOverviewView");

		// Token: 0x04013A57 RID: 80471
		public static readonly EUiViewName WheelTowerSeasonReviewView = new EUiViewName("WheelTowerSeasonReviewView");

		// Token: 0x04013A58 RID: 80472
		public static readonly EUiViewName WheelTowerMedalRuleView = new EUiViewName("WheelTowerMedalRuleView");

		// Token: 0x04013A59 RID: 80473
		public static readonly EUiViewName SheriffMainView = new EUiViewName("SheriffMainView");

		// Token: 0x04013A5A RID: 80474
		public static readonly EUiViewName SheriffReportPop = new EUiViewName("SheriffReportPop");

		// Token: 0x04013A5B RID: 80475
		public static readonly EUiViewName SheriffAnalysisResultPop = new EUiViewName("SheriffAnalysisResultPop");

		// Token: 0x04013A5C RID: 80476
		public static readonly EUiViewName SheriffShowClueViewPop = new EUiViewName("SheriffShowClueViewPop");

		// Token: 0x04013A5D RID: 80477
		public static readonly EUiViewName SheriffShopView = new EUiViewName("SheriffShopView");

		// Token: 0x04013A5E RID: 80478
		public static readonly EUiViewName SheriffStartTrackPopupView = new EUiViewName("SheriffStartTrackPopupView");

		// Token: 0x04013A5F RID: 80479
		public static readonly EUiViewName SheriffArrestPopupView = new EUiViewName("SheriffArrestPopupView");

		// Token: 0x04013A60 RID: 80480
		public static readonly EUiViewName SheriffCriminalIdentityConfirmedView = new EUiViewName("SheriffCriminalIdentityConfirmedView");

		// Token: 0x04013A61 RID: 80481
		public static readonly EUiViewName SheriffErrorView = new EUiViewName("SheriffErrorView");

		// Token: 0x04013A62 RID: 80482
		public static readonly EUiViewName GuQinActivityMainView = new EUiViewName("GuQinActivityMainView");

		// Token: 0x04013A63 RID: 80483
		public static readonly EUiViewName ChineseZitherView = new EUiViewName("ChineseZitherView");

		// Token: 0x04013A64 RID: 80484
		public static readonly EUiViewName RoverlikeMainView = new EUiViewName("RoverlikeMainView");

		// Token: 0x04013A65 RID: 80485
		public static readonly EUiViewName RoverlikeShopView = new EUiViewName("RoverlikeShopView");

		// Token: 0x04013A66 RID: 80486
		public static readonly EUiViewName RoverlikeQuestRewardView = new EUiViewName("RoverlikeQuestRewardView");

		// Token: 0x04013A67 RID: 80487
		public static readonly EUiViewName RoverlikeHandBookView = new EUiViewName("RoverlikeHandBookView");

		// Token: 0x04013A68 RID: 80488
		public static readonly EUiViewName RoverlikeDetailView = new EUiViewName("RoverlikeDetailView");

		// Token: 0x04013A69 RID: 80489
		public static readonly EUiViewName RoverlikeRoleUnlockView = new EUiViewName("RoverlikeRoleUnlockView");

		// Token: 0x04013A6A RID: 80490
		public static readonly EUiViewName RoverlikeLevelSelectView = new EUiViewName("RoverlikeLevelSelectView");

		// Token: 0x04013A6B RID: 80491
		public static readonly EUiViewName RoverlikeTalentTreeView = new EUiViewName("RoverlikeTalentTreeView");

		// Token: 0x04013A6C RID: 80492
		public static readonly EUiViewName RoverlikeTalentTreeUnlockView = new EUiViewName("RoverlikeTalentTreeUnlockView");

		// Token: 0x04013A6D RID: 80493
		public static readonly EUiViewName RoverlikeLootView = new EUiViewName("RoverlikeLootView");

		// Token: 0x04013A6E RID: 80494
		public static readonly EUiViewName RoverlikeRoleSelectView = new EUiViewName("RoverlikeRoleSelectView");

		// Token: 0x04013A6F RID: 80495
		public static readonly EUiViewName RoverlikeLootUnlockView = new EUiViewName("RoverlikeLootUnlockView");

		// Token: 0x04013A70 RID: 80496
		public static readonly EUiViewName RoverlikeGeneralActionView = new EUiViewName("RoverlikeGeneralActionView");

		// Token: 0x04013A71 RID: 80497
		public static readonly EUiViewName RoverlikeBlessingReplaceView = new EUiViewName("RoverlikeBlessingReplaceView");

		// Token: 0x04013A72 RID: 80498
		public static readonly EUiViewName RoverlikeGeneralObtainView = new EUiViewName("RoverlikeGeneralObtainView");

		// Token: 0x04013A73 RID: 80499
		public static readonly EUiViewName RoverlikeGameShopView = new EUiViewName("RoverlikeGameShopView");

		// Token: 0x04013A74 RID: 80500
		public static readonly EUiViewName RoverlikePauseView = new EUiViewName("RoverlikePauseView");

		// Token: 0x04013A75 RID: 80501
		public static readonly EUiViewName RoverlikeResultView = new EUiViewName("RoverlikeResultView");

		// Token: 0x04013A76 RID: 80502
		public static readonly EUiViewName RoverlikeLevelTipsView = new EUiViewName("RoverlikeLevelTipsView");

		// Token: 0x04013A77 RID: 80503
		public static readonly EUiViewName RoverlikeLootTipsView = new EUiViewName("RoverlikeLootTipsView");

		// Token: 0x04013A78 RID: 80504
		public static readonly EUiViewName RoverlikeInfoTipsView = new EUiViewName("RoverlikeInfoTipsView");

		// Token: 0x04013A79 RID: 80505
		public static readonly EUiViewName RoverlikeRoleBlessingTips = new EUiViewName("RoverlikeRoleBlessingTips");

		// Token: 0x04013A7A RID: 80506
		public static readonly EUiViewName RoverlikeUnlockTipView = new EUiViewName("RoverlikeUnlockTipView");

		// Token: 0x04013A7B RID: 80507
		public static readonly EUiViewName SwordControlGroundView = new EUiViewName("SwordControlGroundView");

		// Token: 0x04013A7C RID: 80508
		public static readonly EUiViewName SwordControlFlightView = new EUiViewName("SwordControlFlightView");

		// Token: 0x04013A7D RID: 80509
		public static readonly EUiViewName RecallFunctionView = new EUiViewName("RecallFunctionView");

		// Token: 0x04013A7E RID: 80510
		public static readonly EUiViewName RecallLoadingView = new EUiViewName("RecallLoadingView");

		// Token: 0x04013A7F RID: 80511
		public static readonly EUiViewName GiantSystemCollectView = new EUiViewName("GiantSystemCollectView");

		// Token: 0x04013A80 RID: 80512
		public static readonly EUiViewName GiantSystemMainView = new EUiViewName("GiantSystemMainView");

		// Token: 0x04013A81 RID: 80513
		public static readonly EUiViewName GiantSystemQuestView = new EUiViewName("GiantSystemQuestView");

		// Token: 0x04013A82 RID: 80514
		public static readonly EUiViewName DangoBrawlBackpackView = new EUiViewName("DangoBrawlBackpackView");

		// Token: 0x04013A83 RID: 80515
		public static readonly EUiViewName DangoBrawlBackpackShopRateView = new EUiViewName("DangoBrawlBackpackShopRateView");

		// Token: 0x04013A84 RID: 80516
		public static readonly EUiViewName DangoBrawlMainView = new EUiViewName("DangoBrawlMainView");

		// Token: 0x04013A85 RID: 80517
		public static readonly EUiViewName DangoBrawlShopView = new EUiViewName("DangoBrawlShopView");

		// Token: 0x04013A86 RID: 80518
		public static readonly EUiViewName DangoBrawlShopExchangePopView = new EUiViewName("DangoBrawlShopExchangePopView");

		// Token: 0x04013A87 RID: 80519
		public static readonly EUiViewName DangoBrawlConfirmBoxView = new EUiViewName("DangoBrawlConfirmBoxView");

		// Token: 0x04013A88 RID: 80520
		public static readonly EUiViewName DangoBrawlLevelView = new EUiViewName("DangoBrawlLevelView");

		// Token: 0x04013A89 RID: 80521
		public static readonly EUiViewName DangoBrawlLevelDetailView = new EUiViewName("DangoBrawlLevelDetailView");

		// Token: 0x04013A8A RID: 80522
		public static readonly EUiViewName DangoBrawlHandBookView = new EUiViewName("DangoBrawlHandBookView");

		// Token: 0x04013A8B RID: 80523
		public static readonly EUiViewName DangoBrawlHandBookFilterView = new EUiViewName("DangoBrawlHandBookFilterView");

		// Token: 0x04013A8C RID: 80524
		public static readonly EUiViewName DangoBrawlRoleView = new EUiViewName("DangoBrawlRoleView");

		// Token: 0x04013A8D RID: 80525
		public static readonly EUiViewName DangoBrawlRoleUnlockView = new EUiViewName("DangoBrawlRoleUnlockView");

		// Token: 0x04013A8E RID: 80526
		public static readonly EUiViewName DangoBrawlRoleHandBookView = new EUiViewName("DangoBrawlRoleHandBookView");

		// Token: 0x04013A8F RID: 80527
		public static readonly EUiViewName DangoBrawlCombineView = new EUiViewName("DangoBrawlCombineView");

		// Token: 0x04013A90 RID: 80528
		public static readonly EUiViewName DangoBrawlPauseView = new EUiViewName("DangoBrawlPauseView");

		// Token: 0x04013A91 RID: 80529
		public static readonly EUiViewName DangoBrawlLoadingView = new EUiViewName("DangoBrawlLoadingView");

		// Token: 0x04013A92 RID: 80530
		public static readonly EUiViewName DangoBrawlSuccessSettleView = new EUiViewName("DangoBrawlSuccessSettleView");

		// Token: 0x04013A93 RID: 80531
		public static readonly EUiViewName DangoBrawlFailSettleView = new EUiViewName("DangoBrawlFailureSettleView");

		// Token: 0x04013A94 RID: 80532
		public static readonly EUiViewName DangoBrawlRoundSuccessSettleView = new EUiViewName("DangoBrawlRoundSuccessSettleView");

		// Token: 0x04013A95 RID: 80533
		public static readonly EUiViewName DangoBrawlRoundFailureSettleView = new EUiViewName("DangoBrawlRoundFailureSettleView");

		// Token: 0x04013A96 RID: 80534
		public static readonly EUiViewName DangoBrawlSettleRoleBagDetailView = new EUiViewName("DangoBrawlSettleRoleBagDetailView");

		// Token: 0x04013A97 RID: 80535
		public static readonly EUiViewName DangoBrawlRewardsView = new EUiViewName("DangoBrawlRewardsView");

		// Token: 0x04013A98 RID: 80536
		public static readonly EUiViewName DangoBrawlChooseCardView = new EUiViewName("DangoBrawlChooseCardView");

		// Token: 0x04013A99 RID: 80537
		public static readonly EUiViewName DangoBrawlBuffDetailView = new EUiViewName("DangoBrawlBuffDetailView");

		// Token: 0x04013A9A RID: 80538
		public static readonly EUiViewName ActivityUnlockTipDangoBrawlView = new EUiViewName("ActivityUnlockTipDangoBrawlView");

		// Token: 0x04013A9B RID: 80539
		public static readonly EUiViewName DangoBrawlShopStateTips = new EUiViewName("DangoBrawlShopStateTips");

		// Token: 0x04013A9C RID: 80540
		public static readonly EUiViewName FarmGoldInstanceEntranceView = new EUiViewName("FarmGoldInstanceEntranceView");

		// Token: 0x04013A9D RID: 80541
		public static readonly EUiViewName MatchThreeTargetPopView = new EUiViewName("MatchThreeTargetPopView");

		// Token: 0x04013A9E RID: 80542
		public static readonly EUiViewName MatchThreeGameplayView = new EUiViewName("MatchThreeGameplayView");

		// Token: 0x04013A9F RID: 80543
		public static readonly EUiViewName MatchThreeSuccessPopView = new EUiViewName("MatchThreeSuccessPopView");

		// Token: 0x04013AA0 RID: 80544
		public static readonly EUiViewName MatchThreeFailPopView = new EUiViewName("MatchThreeFailPopView");

		// Token: 0x04013AA1 RID: 80545
		public static readonly EUiViewName MatchThreeSelectLevelView = new EUiViewName("MatchThreeSelectLevelView");

		// Token: 0x04013AA2 RID: 80546
		public static readonly EUiViewName MatchThreeLevelDetailView = new EUiViewName("MatchThreeLevelDetailView");

		// Token: 0x04013AA3 RID: 80547
		public static readonly EUiViewName MatchThreeRoleSelectView = new EUiViewName("MatchThreeRoleSelectView");

		// Token: 0x04013AA4 RID: 80548
		public static readonly EUiViewName MatchThreePopupInfoView = new EUiViewName("MatchThreePopupInfoView");

		// Token: 0x04013AA5 RID: 80549
		public static readonly EUiViewName MatchThreeConfirmBoxView = new EUiViewName("MatchThreeConfirmBoxView");

		// Token: 0x04013AA6 RID: 80550
		public static readonly EUiViewName PetalMechanicView = new EUiViewName("PetalMechanicView");

		// Token: 0x04013AA7 RID: 80551
		public static readonly EUiViewName SolarSchoolRootView = new EUiViewName("SolarSchoolRootView");

		// Token: 0x04013AA8 RID: 80552
		public static readonly EUiViewName SolarSchoolScheduleView = new EUiViewName("SolarSchoolScheduleView");

		// Token: 0x04013AA9 RID: 80553
		public static readonly EUiViewName SolarSchoolMapView = new EUiViewName("SolarSchoolMapView");

		// Token: 0x04013AAA RID: 80554
		public static readonly EUiViewName SolarSchoolEventCheckView = new EUiViewName("SolarSchoolEventCheckView");

		// Token: 0x04013AAB RID: 80555
		public static readonly EUiViewName SolarSchoolInfoOverviewView = new EUiViewName("SolarSchoolInfoOverviewView");

		// Token: 0x04013AAC RID: 80556
		public static readonly EUiViewName SolarSchoolBagView = new EUiViewName("SolarSchoolBagView");

		// Token: 0x04013AAD RID: 80557
		public static readonly EUiViewName SolarSchoolShopView = new EUiViewName("SolarSchoolShopView");

		// Token: 0x04013AAE RID: 80558
		public static readonly EUiViewName SolarSchoolTipsPopupView = new EUiViewName("SolarSchoolTipsPopupView");

		// Token: 0x04013AAF RID: 80559
		public static readonly EUiViewName SolarSchoolConfirmPopupView = new EUiViewName("SolarSchoolConfirmPopupView");

		// Token: 0x04013AB0 RID: 80560
		public static readonly EUiViewName SolarSchoolSpecialBehaviorAcceptView = new EUiViewName("SolarSchoolSpecialBehaviorAcceptView");

		// Token: 0x04013AB1 RID: 80561
		public static readonly EUiViewName SolarSchoolBuildPopupView = new EUiViewName("SolarSchoolBuildPopupView");

		// Token: 0x04013AB2 RID: 80562
		public static readonly EUiViewName SolarSchoolFavorLevelUpPopupView = new EUiViewName("SolarSchoolFavorLevelUpPopupView");

		// Token: 0x04013AB3 RID: 80563
		public static readonly EUiViewName SolarSchoolUnlockItemPopupView = new EUiViewName("SolarSchoolUnlockItemPopupView");

		// Token: 0x04013AB4 RID: 80564
		public static readonly EUiViewName SolarSchoolJumpAccessPopupView = new EUiViewName("SolarSchoolJumpAccessPopupView");

		// Token: 0x04013AB5 RID: 80565
		public static readonly EUiViewName SolarSchoolBehaviorDonePopupView = new EUiViewName("SolarSchoolBehaviorDonePopupView");

		// Token: 0x04013AB6 RID: 80566
		public static readonly EUiViewName SolarSchoolSettingView = new EUiViewName("SolarSchoolSettingView");

		// Token: 0x04013AB7 RID: 80567
		public static readonly EUiViewName SolarSchoolVolumeView = new EUiViewName("SolarSchoolVolumeView");

		// Token: 0x04013AB8 RID: 80568
		public static readonly EUiViewName SolarSchoolEventPopupView = new EUiViewName("SolarSchoolEventPopupView");

		// Token: 0x04013AB9 RID: 80569
		public static readonly EUiViewName SolarSchoolExamView = new EUiViewName("SolarSchoolExamView");

		// Token: 0x04013ABA RID: 80570
		public static readonly EUiViewName SolarSchoolEntranceView = new EUiViewName("SolarSchoolEntranceView");

		// Token: 0x04013ABB RID: 80571
		public static readonly EUiViewName SolarSchoolChooseEndingView = new EUiViewName("SolarSchoolChooseEndingView");

		// Token: 0x04013ABC RID: 80572
		public static readonly EUiViewName SolarSchoolEndingSummaryView = new EUiViewName("SolarSchoolEndingSummaryView");

		// Token: 0x04013ABD RID: 80573
		public static readonly EUiViewName SolarSchoolQuestDetailView = new EUiViewName("SolarSchoolQuestDetailView");

		// Token: 0x04013ABE RID: 80574
		public static readonly EUiViewName SolarSchoolLetterView = new EUiViewName("SolarSchoolLetterView");

		// Token: 0x04013ABF RID: 80575
		public static readonly EUiViewName SolarSchoolForumView = new EUiViewName("SolarSchoolForumView");

		// Token: 0x04013AC0 RID: 80576
		public static readonly EUiViewName SolarSchoolAffairsView = new EUiViewName("SolarSchoolAffairsView");

		// Token: 0x04013AC1 RID: 80577
		public static readonly EUiViewName SolarSchoolVisualNovelDialogueView = new EUiViewName("SolarSchoolVisualNovelDialogueView");

		// Token: 0x04013AC2 RID: 80578
		public static readonly EUiViewName SolarSchoolRewardTipView = new EUiViewName("SolarSchoolAcquireListView");

		// Token: 0x04013AC3 RID: 80579
		public static readonly EUiViewName SolarSchoolPrizeDrawingView = new EUiViewName("SolarSchoolPrizeDrawingView");

		// Token: 0x04013AC4 RID: 80580
		public static readonly EUiViewName SolarSchoolPrizeDrawingTearView = new EUiViewName("SolarSchoolPrizeDrawingTearView");

		// Token: 0x04013AC5 RID: 80581
		public static readonly EUiViewName SolarSchoolNormalRewardView = new EUiViewName("SolarSchoolNormalRewardView");

		// Token: 0x04013AC6 RID: 80582
		public static readonly EUiViewName SolarSchoolLimitTimeRewardView = new EUiViewName("SolarSchoolLimitTimeRewardView");

		// Token: 0x04013AC7 RID: 80583
		public static readonly EUiViewName SolarSchoolGalleryView = new EUiViewName("SolarSchoolGalleryView");

		// Token: 0x04013AC8 RID: 80584
		public static readonly EUiViewName SolarSchoolGalleryEndingDetailView = new EUiViewName("SolarSchoolGalleryEndingDetailView");

		// Token: 0x04013AC9 RID: 80585
		public static readonly EUiViewName SolarSchoolGalleryCgDetailView = new EUiViewName("SolarSchoolGalleryCgDetailView");

		// Token: 0x04013ACA RID: 80586
		public static readonly EUiViewName SolarSchoolGalleryOpDetailView = new EUiViewName("SolarSchoolGalleryOpDetailView");

		// Token: 0x04013ACB RID: 80587
		public static readonly EUiViewName SolarSchoolScratchTicketView = new EUiViewName("SolarSchoolScratchTicketView");

		// Token: 0x04013ACC RID: 80588
		public static readonly EUiViewName SolarSchoolSaveView = new EUiViewName("SolarSchoolSaveView");

		// Token: 0x04013ACD RID: 80589
		public static readonly EUiViewName SolarSchoolLoadingView = new EUiViewName("SolarSchoolLoadingView");

		// Token: 0x04013ACE RID: 80590
		public static readonly EUiViewName SolarSchoolUpgradePopupView = new EUiViewName("SolarSchoolUpgradePopupView");

		// Token: 0x04013ACF RID: 80591
		public static readonly EUiViewName SolarSchoolDayChangeLoadingView = new EUiViewName("SolarSchoolDayChangeLoadingView");

		// Token: 0x04013AD0 RID: 80592
		public static readonly EUiViewName SolarSchoolLocationChangeLoadingView = new EUiViewName("SolarSchoolLocationChangeLoadingView");

		// Token: 0x04013AD1 RID: 80593
		public static readonly EUiViewName SolarSchoolMonthSummaryView = new EUiViewName("SolarSchoolMonthSummaryView");

		// Token: 0x04013AD2 RID: 80594
		public static readonly EUiViewName SolarSchoolActivityOpenTipsView = new EUiViewName("SolarSchoolActivityOpenTipsView");

		// Token: 0x04013AD3 RID: 80595
		public static readonly EUiViewName PianoGameplayView = new EUiViewName("PianoGameplayView");

		// Token: 0x04013AD4 RID: 80596
		public static readonly EUiViewName AnimatedScreenTextView = new EUiViewName("AnimatedScreenTextView");
	}
}
