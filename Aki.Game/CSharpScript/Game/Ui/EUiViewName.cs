using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Utils.StaticVariableReset;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004666 RID: 18022
	[NullableContext(1)]
	[Nullable(0)]
	[StaticVariablePriority(50)]
	public readonly struct EUiViewName : IEquatable<EUiViewName>, IStaticVariableResetter
	{
		// Token: 0x0602E841 RID: 190529 RVA: 0x00ABFD06 File Offset: 0x00ABDF06
		private EUiViewName(string value)
		{
			this._value = value;
		}

		// Token: 0x0602E842 RID: 190530 RVA: 0x00ABFD0F File Offset: 0x00ABDF0F
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x0602E843 RID: 190531 RVA: 0x00ABFD17 File Offset: 0x00ABDF17
		public bool Equals(EUiViewName other)
		{
			return this._value == other._value;
		}

		// Token: 0x0602E844 RID: 190532 RVA: 0x00ABFD2C File Offset: 0x00ABDF2C
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

		// Token: 0x0602E845 RID: 190533 RVA: 0x00ABFD51 File Offset: 0x00ABDF51
		public override int GetHashCode()
		{
			string value = this._value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602E846 RID: 190534 RVA: 0x00ABFD64 File Offset: 0x00ABDF64
		public static bool operator ==(EUiViewName left, EUiViewName right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602E847 RID: 190535 RVA: 0x00ABFD6E File Offset: 0x00ABDF6E
		public static bool operator !=(EUiViewName left, EUiViewName right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0602E848 RID: 190536 RVA: 0x00ABFD7B File Offset: 0x00ABDF7B
		public static implicit operator string(EUiViewName name)
		{
			return name._value;
		}

		// Token: 0x0602E849 RID: 190537 RVA: 0x00ABFD83 File Offset: 0x00ABDF83
		public static explicit operator EUiViewName(string value)
		{
			return new EUiViewName(value);
		}

		// Token: 0x0602E84A RID: 190538 RVA: 0x00ABFD8B File Offset: 0x00ABDF8B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E84B RID: 190539 RVA: 0x00ABFD8D File Offset: 0x00ABDF8D
		public static void ResetStaticDefaultValue()
		{
		}

		// Token: 0x04018E56 RID: 101974
		private readonly string _value;

		// Token: 0x04018E57 RID: 101975
		public static readonly EUiViewName All = new EUiViewName("All");

		// Token: 0x04018E58 RID: 101976
		public static readonly EUiViewName BattleView = new EUiViewName("BattleView");

		// Token: 0x04018E59 RID: 101977
		public static readonly EUiViewName MailBoxView = new EUiViewName("MailBoxView");

		// Token: 0x04018E5A RID: 101978
		public static readonly EUiViewName MailContentView = new EUiViewName("MailContentView");

		// Token: 0x04018E5B RID: 101979
		public static readonly EUiViewName WorldMapView = new EUiViewName("WorldMapView");

		// Token: 0x04018E5C RID: 101980
		public static readonly EUiViewName RoleRootView = new EUiViewName("RoleRootView");

		// Token: 0x04018E5D RID: 101981
		public static readonly EUiViewName RolePreviewRootView = new EUiViewName("RolePreviewRootView");

		// Token: 0x04018E5E RID: 101982
		public static readonly EUiViewName RoleNewJoinRootView = new EUiViewName("RoleNewJoinRootView");

		// Token: 0x04018E5F RID: 101983
		public static readonly EUiViewName RoleBreachView = new EUiViewName("RoleBreachView");

		// Token: 0x04018E60 RID: 101984
		public static readonly EUiViewName RoleSkillView = new EUiViewName("RoleSkillView");

		// Token: 0x04018E61 RID: 101985
		public static readonly EUiViewName RoleLevelUpView = new EUiViewName("RoleLevelUpView");

		// Token: 0x04018E62 RID: 101986
		public static readonly EUiViewName RoleSelectionView = new EUiViewName("RoleSelectionView");

		// Token: 0x04018E63 RID: 101987
		public static readonly EUiViewName RoleNewJoinView = new EUiViewName("RoleNewJoinView");

		// Token: 0x04018E64 RID: 101988
		public static readonly EUiViewName RoleNewJoinTipView = new EUiViewName("RoleNewJoinTipView");

		// Token: 0x04018E65 RID: 101989
		public static readonly EUiViewName TeamRoleSelectView = new EUiViewName("TeamRoleSelectView");

		// Token: 0x04018E66 RID: 101990
		public static readonly EUiViewName TeamSceneRoleSelectView = new EUiViewName("TeamSceneRoleSelectView");

		// Token: 0x04018E67 RID: 101991
		public static readonly EUiViewName MultiTeamRoleSelectView = new EUiViewName("MultiTeamRoleSelectView");

		// Token: 0x04018E68 RID: 101992
		public static readonly EUiViewName QuickRoleSelectView = new EUiViewName("QuickRoleSelectView");

		// Token: 0x04018E69 RID: 101993
		public static readonly EUiViewName PersonalQuickRoleSelectView = new EUiViewName("PersonalQuickRoleSelectView");

		// Token: 0x04018E6A RID: 101994
		public static readonly EUiViewName TeamRoleSelectWithModelView = new EUiViewName("TeamRoleSelectWithModelView");

		// Token: 0x04018E6B RID: 101995
		public static readonly EUiViewName ShopView = new EUiViewName("ShopView");

		// Token: 0x04018E6C RID: 101996
		public static readonly EUiViewName AreaView = new EUiViewName("AreaView");

		// Token: 0x04018E6D RID: 101997
		public static readonly EUiViewName SubLevelLoadingView = new EUiViewName("SubLevelLoadingView");

		// Token: 0x04018E6E RID: 101998
		public static readonly EUiViewName LoginView = new EUiViewName("LoginView");

		// Token: 0x04018E6F RID: 101999
		public static readonly EUiViewName LoginQueueTipsView = new EUiViewName("LoginQueueTipsView");

		// Token: 0x04018E70 RID: 102000
		public static readonly EUiViewName LoginDebugView = new EUiViewName("LoginDebugView");

		// Token: 0x04018E71 RID: 102001
		public static readonly EUiViewName LoginDebugPlayerNameView = new EUiViewName("LoginDebugPlayerNameView");

		// Token: 0x04018E72 RID: 102002
		public static readonly EUiViewName ItemTipsView = new EUiViewName("ItemTipsView");

		// Token: 0x04018E73 RID: 102003
		public static readonly EUiViewName QuestView = new EUiViewName("QuestView");

		// Token: 0x04018E74 RID: 102004
		public static readonly EUiViewName BcView = new EUiViewName("BcView");

		// Token: 0x04018E75 RID: 102005
		public static readonly EUiViewName QuestHintView = new EUiViewName("QuestHintView");

		// Token: 0x04018E76 RID: 102006
		public static readonly EUiViewName NewItemTipsView = new EUiViewName("NewItemTipsView");

		// Token: 0x04018E77 RID: 102007
		public static readonly EUiViewName PhantomTipsView = new EUiViewName("PhantomTipsView");

		// Token: 0x04018E78 RID: 102008
		public static readonly EUiViewName FunctionView = new EUiViewName("FunctionView");

		// Token: 0x04018E79 RID: 102009
		public static readonly EUiViewName ItemHintView = new EUiViewName("ItemHintView");

		// Token: 0x04018E7A RID: 102010
		public static readonly EUiViewName EditSceneFormationView = new EUiViewName("EditSceneFormationView");

		// Token: 0x04018E7B RID: 102011
		public static readonly EUiViewName Formation2DView = new EUiViewName("Formation2DView");

		// Token: 0x04018E7C RID: 102012
		public static readonly EUiViewName Formation3DView = new EUiViewName("Formation3DView");

		// Token: 0x04018E7D RID: 102013
		public static readonly EUiViewName BattleTeam2DView = new EUiViewName("BattleTeam2DView");

		// Token: 0x04018E7E RID: 102014
		public static readonly EUiViewName FormationEditView = new EUiViewName("FormationEditView");

		// Token: 0x04018E7F RID: 102015
		public static readonly EUiViewName HelpView = new EUiViewName("HelpView");

		// Token: 0x04018E80 RID: 102016
		public static readonly EUiViewName InventoryView = new EUiViewName("InventoryView");

		// Token: 0x04018E81 RID: 102017
		public static readonly EUiViewName PhantomManageView = new EUiViewName("PhantomManageView");

		// Token: 0x04018E82 RID: 102018
		public static readonly EUiViewName PhantomManageConfigView = new EUiViewName("PhantomManageConfigView");

		// Token: 0x04018E83 RID: 102019
		public static readonly EUiViewName PhantomManageConfigSelectView = new EUiViewName("PhantomManageConfigSelectView");

		// Token: 0x04018E84 RID: 102020
		public static readonly EUiViewName PhantomManageConfigRenameInputView = new EUiViewName("PhantomManageConfigRenameInputView");

		// Token: 0x04018E85 RID: 102021
		public static readonly EUiViewName DestroyPreviewView = new EUiViewName("DestroyPreviewView");

		// Token: 0x04018E86 RID: 102022
		public static readonly EUiViewName GuideTipsView = new EUiViewName("GuideTipsView");

		// Token: 0x04018E87 RID: 102023
		public static readonly EUiViewName GuideTutorialView = new EUiViewName("GuideTutorialView");

		// Token: 0x04018E88 RID: 102024
		public static readonly EUiViewName GuideTutorialPopView = new EUiViewName("GuideTutorialPopView");

		// Token: 0x04018E89 RID: 102025
		public static readonly EUiViewName HelpGuideView = new EUiViewName("HelpGuideView");

		// Token: 0x04018E8A RID: 102026
		public static readonly EUiViewName SignalDeviceGuideView = new EUiViewName("SignalDeviceGuideView");

		// Token: 0x04018E8B RID: 102027
		public static readonly EUiViewName GuideFocusView = new EUiViewName("GuideFocusView");

		// Token: 0x04018E8C RID: 102028
		public static readonly EUiViewName GuideTutorialTipsView = new EUiViewName("GuideTutorialTipsView");

		// Token: 0x04018E8D RID: 102029
		public static readonly EUiViewName GmView = new EUiViewName("GmView");

		// Token: 0x04018E8E RID: 102030
		public static readonly EUiViewName ItemRewardView = new EUiViewName("ItemRewardView");

		// Token: 0x04018E8F RID: 102031
		public static readonly EUiViewName MView = new EUiViewName("MView");

		// Token: 0x04018E90 RID: 102032
		public static readonly EUiViewName AchievementRewardItemView = new EUiViewName("AchievementRewardItemView");

		// Token: 0x04018E91 RID: 102033
		public static readonly EUiViewName CipherView = new EUiViewName("CipherView");

		// Token: 0x04018E92 RID: 102034
		public static readonly EUiViewName TimeTrackControlView = new EUiViewName("TimeTrackControlView");

		// Token: 0x04018E93 RID: 102035
		public static readonly EUiViewName PickInteractionView = new EUiViewName("PickInteractionView");

		// Token: 0x04018E94 RID: 102036
		public static readonly EUiViewName MazeTipsLoseView = new EUiViewName("MazeTipsLoseView");

		// Token: 0x04018E95 RID: 102037
		public static readonly EUiViewName MazeTipsWinView = new EUiViewName("MazeTipsWinView");

		// Token: 0x04018E96 RID: 102038
		public static readonly EUiViewName TurntableControlView = new EUiViewName("TurntableControlView");

		// Token: 0x04018E97 RID: 102039
		public static readonly EUiViewName FoxFailureTipsView = new EUiViewName("FoxFailureTipsView");

		// Token: 0x04018E98 RID: 102040
		public static readonly EUiViewName SundialControlView = new EUiViewName("SundialControlView");

		// Token: 0x04018E99 RID: 102041
		public static readonly EUiViewName PlotSubtitleView = new EUiViewName("PlotSubtitleView");

		// Token: 0x04018E9A RID: 102042
		public static readonly EUiViewName PupuVillageItemView = new EUiViewName("PupuVillageItemView");

		// Token: 0x04018E9B RID: 102043
		public static readonly EUiViewName PupuVillageItemViewQIQIU = new EUiViewName("PupuVillageItemViewQIQIU");

		// Token: 0x04018E9C RID: 102044
		public static readonly EUiViewName PlotView = new EUiViewName("PlotView");

		// Token: 0x04018E9D RID: 102045
		public static readonly EUiViewName PlotViewHUD = new EUiViewName("PlotViewHUD");

		// Token: 0x04018E9E RID: 102046
		public static readonly EUiViewName PlotGiantSubtitleView = new EUiViewName("PlotGiantSubtitleView");

		// Token: 0x04018E9F RID: 102047
		public static readonly EUiViewName PlotTransitionView = new EUiViewName("PlotTransitionView");

		// Token: 0x04018EA0 RID: 102048
		public static readonly EUiViewName PlotTransitionViewPop = new EUiViewName("PlotTransitionViewPop");

		// Token: 0x04018EA1 RID: 102049
		public static readonly EUiViewName PlotPhotoView = new EUiViewName("PlotPhotoView");

		// Token: 0x04018EA2 RID: 102050
		public static readonly EUiViewName PlotLogoView = new EUiViewName("PlotLogoView");

		// Token: 0x04018EA3 RID: 102051
		public static readonly EUiViewName PlotTipsView = new EUiViewName("PlotTipsView");

		// Token: 0x04018EA4 RID: 102052
		public static readonly EUiViewName TransitionPopupView = new EUiViewName("TransitionPopupView");

		// Token: 0x04018EA5 RID: 102053
		public static readonly EUiViewName MusicSubtitleView = new EUiViewName("MusicSubtitleView");

		// Token: 0x04018EA6 RID: 102054
		public static readonly EUiViewName PlotHintView = new EUiViewName("PlotHintView");

		// Token: 0x04018EA7 RID: 102055
		public static readonly EUiViewName SummaryPopView = new EUiViewName("SummaryPopView");

		// Token: 0x04018EA8 RID: 102056
		public static readonly EUiViewName PlotReviewView = new EUiViewName("PlotReviewView");

		// Token: 0x04018EA9 RID: 102057
		public static readonly EUiViewName AdmissionStudentCardView = new EUiViewName("AdmissionStudentCardView");

		// Token: 0x04018EAA RID: 102058
		public static readonly EUiViewName VideoPromptView = new EUiViewName("VideoPromptView");

		// Token: 0x04018EAB RID: 102059
		public static readonly EUiViewName NetWorkMaskView = new EUiViewName("NetWorkMaskView");

		// Token: 0x04018EAC RID: 102060
		public static readonly EUiViewName PlayStationNetWorkMaskView = new EUiViewName("PlayStationNetWorkMaskView");

		// Token: 0x04018EAD RID: 102061
		public static readonly EUiViewName CreateCharacterView = new EUiViewName("CreateCharacterView");

		// Token: 0x04018EAE RID: 102062
		public static readonly EUiViewName MingSuView = new EUiViewName("MingSuView");

		// Token: 0x04018EAF RID: 102063
		public static readonly EUiViewName WeaponRootView = new EUiViewName("WeaponRootView");

		// Token: 0x04018EB0 RID: 102064
		public static readonly EUiViewName WeaponReplaceView = new EUiViewName("WeaponReplaceView");

		// Token: 0x04018EB1 RID: 102065
		public static readonly EUiViewName WeaponBreachSuccessView = new EUiViewName("WeaponBreachSuccessView");

		// Token: 0x04018EB2 RID: 102066
		public static readonly EUiViewName WeaponResonanceSuccessView = new EUiViewName("WeaponResonanceSuccessView");

		// Token: 0x04018EB3 RID: 102067
		public static readonly EUiViewName GameplayEnterView = new EUiViewName("GameplayEnterView");

		// Token: 0x04018EB4 RID: 102068
		public static readonly EUiViewName GameplayFirstPassView = new EUiViewName("GameplayFirstPassView");

		// Token: 0x04018EB5 RID: 102069
		public static readonly EUiViewName InstanceDungeonEntranceView = new EUiViewName("InstanceDungeonEntranceView");

		// Token: 0x04018EB6 RID: 102070
		public static readonly EUiViewName TowerDefenseLevelView = new EUiViewName("TowerDefenseLevelView");

		// Token: 0x04018EB7 RID: 102071
		public static readonly EUiViewName InstanceDungeonVictoryView = new EUiViewName("InstanceDungeonVictoryView");

		// Token: 0x04018EB8 RID: 102072
		public static readonly EUiViewName InstanceDungeonFailView = new EUiViewName("InstanceDungeonFailView");

		// Token: 0x04018EB9 RID: 102073
		public static readonly EUiViewName InstanceDungeonReward = new EUiViewName("InstanceDungeonReward");

		// Token: 0x04018EBA RID: 102074
		public static readonly EUiViewName InstanceDungeonMonsterPreView = new EUiViewName("InstanceDungeonMonsterPreView");

		// Token: 0x04018EBB RID: 102075
		public static readonly EUiViewName InstanceDungeonAreaView = new EUiViewName("InstanceDungeonAreaView");

		// Token: 0x04018EBC RID: 102076
		public static readonly EUiViewName InstanceDungeonGuideView = new EUiViewName("InstanceDungeonGuideView");

		// Token: 0x04018EBD RID: 102077
		public static readonly EUiViewName LordGymEntranceView = new EUiViewName("LordGymEntranceView");

		// Token: 0x04018EBE RID: 102078
		public static readonly EUiViewName LordGymChallengeRecordView = new EUiViewName("LordGymChallengeRecordView");

		// Token: 0x04018EBF RID: 102079
		public static readonly EUiViewName LoginStatusView = new EUiViewName("LoginStatusView");

		// Token: 0x04018EC0 RID: 102080
		public static readonly EUiViewName LoginOfficialStatusView = new EUiViewName("LoginOfficialStatusView");

		// Token: 0x04018EC1 RID: 102081
		public static readonly EUiViewName PreDownloadView = new EUiViewName("PreDownloadView");

		// Token: 0x04018EC2 RID: 102082
		public static readonly EUiViewName LordGymDifficultySelectView = new EUiViewName("LordGymDifficultySelectView");

		// Token: 0x04018EC3 RID: 102083
		public static readonly EUiViewName LordGymLordEntranceSelectView = new EUiViewName("LordGymLordEntranceSelectView");

		// Token: 0x04018EC4 RID: 102084
		public static readonly EUiViewName LordGymChallengeFailView = new EUiViewName("LordGymChallengeFailView");

		// Token: 0x04018EC5 RID: 102085
		public static readonly EUiViewName LordGymThirdBossSelectView = new EUiViewName("LordGymThirdBossSelectView");

		// Token: 0x04018EC6 RID: 102086
		public static readonly EUiViewName LordGymThirdDifficultySelectView = new EUiViewName("LordGymThirdDifficultySelectView");

		// Token: 0x04018EC7 RID: 102087
		public static readonly EUiViewName LordGymThird5BossSelectView = new EUiViewName("LordGymThird5BossSelectView");

		// Token: 0x04018EC8 RID: 102088
		public static readonly EUiViewName LordGymThird5DifficultySelectView = new EUiViewName("LordGymThird5DifficultySelectView");

		// Token: 0x04018EC9 RID: 102089
		public static readonly EUiViewName LordGymThird5LittleLoadingView = new EUiViewName("LordGymThird5LittleLoadingView");

		// Token: 0x04018ECA RID: 102090
		public static readonly EUiViewName LordGymLoadingView = new EUiViewName("LordGymLoadingView");

		// Token: 0x04018ECB RID: 102091
		public static readonly EUiViewName LordGymThird5LoadingView = new EUiViewName("LordGymThird5LoadingView");

		// Token: 0x04018ECC RID: 102092
		public static readonly EUiViewName LordGymFirstBossSelectView = new EUiViewName("LordGymFirstBossSelectView");

		// Token: 0x04018ECD RID: 102093
		public static readonly EUiViewName LordGymFirstDifficultySelectView = new EUiViewName("LordGymFirstDifficultySelectView");

		// Token: 0x04018ECE RID: 102094
		public static readonly EUiViewName LordGymSecondBossSelectView = new EUiViewName("LordGymSecondBossSelectView");

		// Token: 0x04018ECF RID: 102095
		public static readonly EUiViewName LordGymSecondDifficultySelectView = new EUiViewName("LordGymSecondDifficultySelectView");

		// Token: 0x04018ED0 RID: 102096
		public static readonly EUiViewName AdviceCreateView = new EUiViewName("AdviceCreateView");

		// Token: 0x04018ED1 RID: 102097
		public static readonly EUiViewName AdviceMotionView = new EUiViewName("AdviceMotionView");

		// Token: 0x04018ED2 RID: 102098
		public static readonly EUiViewName AdviceRoleView = new EUiViewName("AdviceRoleView");

		// Token: 0x04018ED3 RID: 102099
		public static readonly EUiViewName AdviceView = new EUiViewName("AdviceView");

		// Token: 0x04018ED4 RID: 102100
		public static readonly EUiViewName AdviceSortWordView = new EUiViewName("AdviceSortWordView");

		// Token: 0x04018ED5 RID: 102101
		public static readonly EUiViewName AdviceMutiSentenceSelectView = new EUiViewName("AdviceMutiSentenceSelectView");

		// Token: 0x04018ED6 RID: 102102
		public static readonly EUiViewName AdviceWordView = new EUiViewName("AdviceWordView");

		// Token: 0x04018ED7 RID: 102103
		public static readonly EUiViewName AdviceExpressionView = new EUiViewName("AdviceExpressionView");

		// Token: 0x04018ED8 RID: 102104
		public static readonly EUiViewName AdviceInfoView = new EUiViewName("AdviceInfoView");

		// Token: 0x04018ED9 RID: 102105
		public static readonly EUiViewName PhantomHandBookView = new EUiViewName("PhantomHandBookView");

		// Token: 0x04018EDA RID: 102106
		public static readonly EUiViewName WeaponHandBookView = new EUiViewName("WeaponHandBookView");

		// Token: 0x04018EDB RID: 102107
		public static readonly EUiViewName MonsterHandBookView = new EUiViewName("MonsterHandBookView");

		// Token: 0x04018EDC RID: 102108
		public static readonly EUiViewName ItemHandBookView = new EUiViewName("ItemHandBookView");

		// Token: 0x04018EDD RID: 102109
		public static readonly EUiViewName AnimalHandBookView = new EUiViewName("AnimalHandBookView");

		// Token: 0x04018EDE RID: 102110
		public static readonly EUiViewName ChipHandBookView = new EUiViewName("ChipHandBookView");

		// Token: 0x04018EDF RID: 102111
		public static readonly EUiViewName NounHandBookView = new EUiViewName("NounHandBookView");

		// Token: 0x04018EE0 RID: 102112
		public static readonly EUiViewName GeographyHandBookView = new EUiViewName("GeographyHandBookView");

		// Token: 0x04018EE1 RID: 102113
		public static readonly EUiViewName QuestHandBookView = new EUiViewName("QuestHandBookView");

		// Token: 0x04018EE2 RID: 102114
		public static readonly EUiViewName HandBookRoleView = new EUiViewName("HandBookRoleView");

		// Token: 0x04018EE3 RID: 102115
		public static readonly EUiViewName HandBookQuestPlotView = new EUiViewName("HandBookQuestPlotView");

		// Token: 0x04018EE4 RID: 102116
		public static readonly EUiViewName HandBookPhotoView = new EUiViewName("HandBookPhotoView");

		// Token: 0x04018EE5 RID: 102117
		public static readonly EUiViewName HandBookEntranceView = new EUiViewName("HandBookEntranceView");

		// Token: 0x04018EE6 RID: 102118
		public static readonly EUiViewName TeamTeleportFloatTips = new EUiViewName("TeamTeleportFloatTips");

		// Token: 0x04018EE7 RID: 102119
		public static readonly EUiViewName SceneGameplayItemRewardView = new EUiViewName("SceneGameplayItemRewardView");

		// Token: 0x04018EE8 RID: 102120
		public static readonly EUiViewName AccessPathPcView = new EUiViewName("AccessPathPcView");

		// Token: 0x04018EE9 RID: 102121
		public static readonly EUiViewName TapeRootView = new EUiViewName("TapeRootView");

		// Token: 0x04018EEA RID: 102122
		public static readonly EUiViewName TapeReplaceView = new EUiViewName("TapeReplaceView");

		// Token: 0x04018EEB RID: 102123
		public static readonly EUiViewName PhantomExploreView = new EUiViewName("PhantomExploreView");

		// Token: 0x04018EEC RID: 102124
		public static readonly EUiViewName ConfirmBoxView = new EUiViewName("ConfirmBoxView");

		// Token: 0x04018EED RID: 102125
		public static readonly EUiViewName ConfirmBoxMiddleView = new EUiViewName("ConfirmBoxMiddleView");

		// Token: 0x04018EEE RID: 102126
		public static readonly EUiViewName ConfirmBoxMiddleWithoutItemView = new EUiViewName("ConfirmBoxMiddleWithoutItemView");

		// Token: 0x04018EEF RID: 102127
		public static readonly EUiViewName PowerMagnificationRewardPopView = new EUiViewName("PowerMagnificationRewardPopView");

		// Token: 0x04018EF0 RID: 102128
		public static readonly EUiViewName VisionLevelUpSettingPopView = new EUiViewName("VisionLevelUpSettingPopView");

		// Token: 0x04018EF1 RID: 102129
		public static readonly EUiViewName ItemRewardWithMouseView = new EUiViewName("ItemRewardWithMouseView");

		// Token: 0x04018EF2 RID: 102130
		public static readonly EUiViewName InteractionHintView = new EUiViewName("InteractionHintView");

		// Token: 0x04018EF3 RID: 102131
		public static readonly EUiViewName VolumeView = new EUiViewName("VolumeView");

		// Token: 0x04018EF4 RID: 102132
		public static readonly EUiViewName RoguePhantomSelectView = new EUiViewName("RoguePhantomSelectView");

		// Token: 0x04018EF5 RID: 102133
		public static readonly EUiViewName RoguePhantomReplaceView = new EUiViewName("RoguePhantomReplaceView");

		// Token: 0x04018EF6 RID: 102134
		public static readonly EUiViewName RoguePhantomSelectResultView = new EUiViewName("RoguePhantomSelectResultView");

		// Token: 0x04018EF7 RID: 102135
		public static readonly EUiViewName RogueCharacterRoomSelectView = new EUiViewName("RogueCharacterRoomSelectView");

		// Token: 0x04018EF8 RID: 102136
		public static readonly EUiViewName RoleBuffSelectView = new EUiViewName("RoleBuffSelectView");

		// Token: 0x04018EF9 RID: 102137
		public static readonly EUiViewName RoleReplaceView = new EUiViewName("RoleReplaceView");

		// Token: 0x04018EFA RID: 102138
		public static readonly EUiViewName RogueRoleSelectResultView = new EUiViewName("RogueRoleSelectResultView");

		// Token: 0x04018EFB RID: 102139
		public static readonly EUiViewName RoguelikeSkillOverView = new EUiViewName("RoguelikeSkillOverView");

		// Token: 0x04018EFC RID: 102140
		public static readonly EUiViewName CommonSelectView = new EUiViewName("CommonSelectView");

		// Token: 0x04018EFD RID: 102141
		public static readonly EUiViewName CommonSelectResultView = new EUiViewName("CommonSelectResultView");

		// Token: 0x04018EFE RID: 102142
		public static readonly EUiViewName RogueEventResultViewOneByOne = new EUiViewName("RogueEventResultViewOneByOne");

		// Token: 0x04018EFF RID: 102143
		public static readonly EUiViewName RogueEventResultViewAll = new EUiViewName("RogueEventResultViewAll");

		// Token: 0x04018F00 RID: 102144
		public static readonly EUiViewName WeeklyRoguePhantomRewardView = new EUiViewName("WeeklyRoguePhantomRewardView");

		// Token: 0x04018F01 RID: 102145
		public static readonly EUiViewName WeeklyRogueShop = new EUiViewName("WeeklyRogueShop");

		// Token: 0x04018F02 RID: 102146
		public static readonly EUiViewName WeeklyRogueActivityView = new EUiViewName("WeeklyRogueActivityView");

		// Token: 0x04018F03 RID: 102147
		public static readonly EUiViewName WeeklyRogueSettleView = new EUiViewName("WeeklyRogueSettleView");

		// Token: 0x04018F04 RID: 102148
		public static readonly EUiViewName WeeklyRogueSelectToken = new EUiViewName("WeeklyRogueSelectToken");

		// Token: 0x04018F05 RID: 102149
		public static readonly EUiViewName WeeklyRogueSelectArtifactView = new EUiViewName("WeeklyRogueSelectArtifactView");

		// Token: 0x04018F06 RID: 102150
		public static readonly EUiViewName WeeklyRogueInfo = new EUiViewName("WeeklyRogueInfo");

		// Token: 0x04018F07 RID: 102151
		public static readonly EUiViewName WeeklyRogueRewardPreviewView = new EUiViewName("WeeklyRogueRewardPreviewView");

		// Token: 0x04018F08 RID: 102152
		public static readonly EUiViewName WeeklyRogueRoleSelectView = new EUiViewName("WeeklyRogueRoleSelectView");

		// Token: 0x04018F09 RID: 102153
		public static readonly EUiViewName WeeklyRogueExtraRoomConfirmView = new EUiViewName("WeeklyRogueExtraRoomConfirmView");

		// Token: 0x04018F0A RID: 102154
		public static readonly EUiViewName MapRogueMainView = new EUiViewName("MapRogueMainView");

		// Token: 0x04018F0B RID: 102155
		public static readonly EUiViewName MapRogueGridTakeView = new EUiViewName("MapRogueGridTakeView");

		// Token: 0x04018F0C RID: 102156
		public static readonly EUiViewName MapRogueGridEventView = new EUiViewName("MapRogueGridEventView");

		// Token: 0x04018F0D RID: 102157
		public static readonly EUiViewName MapRogueRewardView = new EUiViewName("MapRogueRewardView");

		// Token: 0x04018F0E RID: 102158
		public static readonly EUiViewName MapRogueEventStartView = new EUiViewName("MapRogueEventStartView");

		// Token: 0x04018F0F RID: 102159
		public static readonly EUiViewName MapRogueFloatTipsAView = new EUiViewName("MapRogueFloatTipsAView");

		// Token: 0x04018F10 RID: 102160
		public static readonly EUiViewName MapRogueFloatTipsBView = new EUiViewName("MapRogueFloatTipsBView");

		// Token: 0x04018F11 RID: 102161
		public static readonly EUiViewName MapRogueExploreEndView = new EUiViewName("MapRogueExploreEndView");

		// Token: 0x04018F12 RID: 102162
		public static readonly EUiViewName RogueBattleMapHelpView = new EUiViewName("RogueBattleMapHelpView");

		// Token: 0x04018F13 RID: 102163
		public static readonly EUiViewName MapRogueExploreView = new EUiViewName("MapRogueExploreView");

		// Token: 0x04018F14 RID: 102164
		public static readonly EUiViewName RogueBattleTokenSelectResultView = new EUiViewName("RogueBattleTokenSelectResultView");

		// Token: 0x04018F15 RID: 102165
		public static readonly EUiViewName PowerView = new EUiViewName("PowerView");

		// Token: 0x04018F16 RID: 102166
		public static readonly EUiViewName LevelUpView = new EUiViewName("LevelUpView");

		// Token: 0x04018F17 RID: 102167
		public static readonly EUiViewName ResonanceDetailView = new EUiViewName("ResonanceDetailView");

		// Token: 0x04018F18 RID: 102168
		public static readonly EUiViewName TimeOfDayView = new EUiViewName("TimeOfDayView");

		// Token: 0x04018F19 RID: 102169
		public static readonly EUiViewName TimeOfDayLoadingView = new EUiViewName("TimeOfDayLoadingView");

		// Token: 0x04018F1A RID: 102170
		public static readonly EUiViewName ReviveView = new EUiViewName("ReviveView");

		// Token: 0x04018F1B RID: 102171
		public static readonly EUiViewName MultiReviveView = new EUiViewName("MultiReviveView");

		// Token: 0x04018F1C RID: 102172
		public static readonly EUiViewName TowerDefenceReviveView = new EUiViewName("TowerDefenceReviveView");

		// Token: 0x04018F1D RID: 102173
		public static readonly EUiViewName ShareTimesReviveView = new EUiViewName("ShareTimesReviveView");

		// Token: 0x04018F1E RID: 102174
		public static readonly EUiViewName WorldLevelUpView = new EUiViewName("WorldLevelUpView");

		// Token: 0x04018F1F RID: 102175
		public static readonly EUiViewName WorldLevelInfoView = new EUiViewName("WorldLevelInfoView");

		// Token: 0x04018F20 RID: 102176
		public static readonly EUiViewName WorldLevelChangeConfirmView = new EUiViewName("WorldLevelChangeConfirmView");

		// Token: 0x04018F21 RID: 102177
		public static readonly EUiViewName GenericPromptView = new EUiViewName("GenericPromptView");

		// Token: 0x04018F22 RID: 102178
		public static readonly EUiViewName JoinTeamView = new EUiViewName("JoinTeamView");

		// Token: 0x04018F23 RID: 102179
		public static readonly EUiViewName MarqueeView = new EUiViewName("MarqueeView");

		// Token: 0x04018F24 RID: 102180
		public static readonly EUiViewName BattleSequenceQteView = new EUiViewName("BattleSequenceQteView");

		// Token: 0x04018F25 RID: 102181
		public static readonly EUiViewName DebugView = new EUiViewName("DebugView");

		// Token: 0x04018F26 RID: 102182
		public static readonly EUiViewName DebugCommandView = new EUiViewName("DebugCmdView");

		// Token: 0x04018F27 RID: 102183
		public static readonly EUiViewName RegionalQuestView = new EUiViewName("RegionalQuestView");

		// Token: 0x04018F28 RID: 102184
		public static readonly EUiViewName RegionalQuestRewardView = new EUiViewName("RegionalQuestRewardView");

		// Token: 0x04018F29 RID: 102185
		public static readonly EUiViewName UseBuffItemView = new EUiViewName("UseBuffItemView");

		// Token: 0x04018F2A RID: 102186
		public static readonly EUiViewName MenuView = new EUiViewName("MenuView");

		// Token: 0x04018F2B RID: 102187
		public static readonly EUiViewName PlotCaptionImageView = new EUiViewName("PlotCaptionImageView");

		// Token: 0x04018F2C RID: 102188
		public static readonly EUiViewName MenuViewPopView = new EUiViewName("MenuViewPopView");

		// Token: 0x04018F2D RID: 102189
		public static readonly EUiViewName CommonKeySettingView = new EUiViewName("CommonKeySettingView");

		// Token: 0x04018F2E RID: 102190
		public static readonly EUiViewName RegionContributionLevelView = new EUiViewName("RegionContributionLevelView");

		// Token: 0x04018F2F RID: 102191
		public static readonly EUiViewName VideoView = new EUiViewName("VideoView");

		// Token: 0x04018F30 RID: 102192
		public static readonly EUiViewName LoginAgeTipView = new EUiViewName("LoginAgeTipView");

		// Token: 0x04018F31 RID: 102193
		public static readonly EUiViewName UidView = new EUiViewName("UidView");

		// Token: 0x04018F32 RID: 102194
		public static readonly EUiViewName CommonSuccessView = new EUiViewName("CommonSuccessView");

		// Token: 0x04018F33 RID: 102195
		public static readonly EUiViewName NetWorkConfirmBoxView = new EUiViewName("NetWorkConfirmBoxView");

		// Token: 0x04018F34 RID: 102196
		public static readonly EUiViewName TextLanguageSettingView = new EUiViewName("TextLanguageSettingView");

		// Token: 0x04018F35 RID: 102197
		public static readonly EUiViewName VoiceLanguageDownloadView = new EUiViewName("VoiceLanguageDownloadView");

		// Token: 0x04018F36 RID: 102198
		public static readonly EUiViewName VoiceLanguageSelectView = new EUiViewName("VoiceLanguageSelectView");

		// Token: 0x04018F37 RID: 102199
		public static readonly EUiViewName FriendView = new EUiViewName("FriendView");

		// Token: 0x04018F38 RID: 102200
		public static readonly EUiViewName FriendProcessView = new EUiViewName("FriendProcessView");

		// Token: 0x04018F39 RID: 102201
		public static readonly EUiViewName OnlineProcessView = new EUiViewName("OnlineProcessView");

		// Token: 0x04018F3A RID: 102202
		public static readonly EUiViewName FriendSearchView = new EUiViewName("FriendSearchView");

		// Token: 0x04018F3B RID: 102203
		public static readonly EUiViewName FriendBlackListView = new EUiViewName("FriendBlackListView");

		// Token: 0x04018F3C RID: 102204
		public static readonly EUiViewName FriendApplyView = new EUiViewName("FriendApplyView");

		// Token: 0x04018F3D RID: 102205
		public static readonly EUiViewName FriendMultipleApplyView = new EUiViewName("FriendMultipleApplyView");

		// Token: 0x04018F3E RID: 102206
		public static readonly EUiViewName PhantomExploreSetView = new EUiViewName("PhantomExploreSetView");

		// Token: 0x04018F3F RID: 102207
		public static readonly EUiViewName SelectedFriendChatView = new EUiViewName("SelectedFriendChatView");

		// Token: 0x04018F40 RID: 102208
		public static readonly EUiViewName ChatView = new EUiViewName("ChatView");

		// Token: 0x04018F41 RID: 102209
		public static readonly EUiViewName QuickChatView = new EUiViewName("QuickChatView");

		// Token: 0x04018F42 RID: 102210
		public static readonly EUiViewName ChatOption = new EUiViewName("ChatOption");

		// Token: 0x04018F43 RID: 102211
		public static readonly EUiViewName ChatExpressionView = new EUiViewName("ChatExpressionView");

		// Token: 0x04018F44 RID: 102212
		public static readonly EUiViewName TempShopView = new EUiViewName("TempShopView");

		// Token: 0x04018F45 RID: 102213
		public static readonly EUiViewName OnlineWorldHallView = new EUiViewName("OnlineWorldHallView");

		// Token: 0x04018F46 RID: 102214
		public static readonly EUiViewName OnlineSettingView = new EUiViewName("OnlineSettingView");

		// Token: 0x04018F47 RID: 102215
		public static readonly EUiViewName OnlineWorldSearch = new EUiViewName("OnlineWorldSearchView");

		// Token: 0x04018F48 RID: 102216
		public static readonly EUiViewName OnlineApplyView = new EUiViewName("OnlineApplyView");

		// Token: 0x04018F49 RID: 102217
		public static readonly EUiViewName OnlineMultipleApplyView = new EUiViewName("OnlineMultipleApplyView");

		// Token: 0x04018F4A RID: 102218
		public static readonly EUiViewName OnlineChallengeApplyView = new EUiViewName("OnlineChallengeApplyView");

		// Token: 0x04018F4B RID: 102219
		public static readonly EUiViewName OnlineMatchSuccessView = new EUiViewName("OnlineMatchSuccessView");

		// Token: 0x04018F4C RID: 102220
		public static readonly EUiViewName OnlineChallengeStateView = new EUiViewName("OnlineChallengeStateView");

		// Token: 0x04018F4D RID: 102221
		public static readonly EUiViewName OnlineInstanceMatchTips = new EUiViewName("OnlineInstanceMatchTips");

		// Token: 0x04018F4E RID: 102222
		public static readonly EUiViewName PayShopRootView = new EUiViewName("PayShopRootView");

		// Token: 0x04018F4F RID: 102223
		public static readonly EUiViewName GiftPackageDetailsView = new EUiViewName("GiftPackageDetailsView");

		// Token: 0x04018F50 RID: 102224
		public static readonly EUiViewName CommonExchangeView = new EUiViewName("CommonExchangeView");

		// Token: 0x04018F51 RID: 102225
		public static readonly EUiViewName GachaMainView = new EUiViewName("GachaMainView");

		// Token: 0x04018F52 RID: 102226
		public static readonly EUiViewName GachaResultView = new EUiViewName("GachaResultView");

		// Token: 0x04018F53 RID: 102227
		public static readonly EUiViewName GachaScanView = new EUiViewName("GachaScanView");

		// Token: 0x04018F54 RID: 102228
		public static readonly EUiViewName GachaSelectionView = new EUiViewName("GachaSelectionView");

		// Token: 0x04018F55 RID: 102229
		public static readonly EUiViewName CalabashRootView = new EUiViewName("CalabashRootView");

		// Token: 0x04018F56 RID: 102230
		public static readonly EUiViewName VisionDirectionalFusionSelectTargetView = new EUiViewName("VisionDirectionalFusionSelectTargetView");

		// Token: 0x04018F57 RID: 102231
		public static readonly EUiViewName CalabashUpgradeSuccessView = new EUiViewName("CalabashUpgradeSuccessView");

		// Token: 0x04018F58 RID: 102232
		public static readonly EUiViewName PhantomBattleFettersView = new EUiViewName("PhantomBattleFettersView");

		// Token: 0x04018F59 RID: 102233
		public static readonly EUiViewName PhantomBattleEquipView = new EUiViewName("PhantomBattleEquipView");

		// Token: 0x04018F5A RID: 102234
		public static readonly EUiViewName PhantomManagerConfigSharePopItem = new EUiViewName("PhantomManagerConfigSharePopItem");

		// Token: 0x04018F5B RID: 102235
		public static readonly EUiViewName PhantomManagerConfigResetPopItem = new EUiViewName("PhantomManagerConfigResetPopItem");

		// Token: 0x04018F5C RID: 102236
		public static readonly EUiViewName PhantomManagerConfigRemovePopItem = new EUiViewName("PhantomManagerConfigRemovePopItem");

		// Token: 0x04018F5D RID: 102237
		public static readonly EUiViewName PhantomManagerConfigEditPopItem = new EUiViewName("PhantomManagerConfigEditPopItem");

		// Token: 0x04018F5E RID: 102238
		public static readonly EUiViewName TimeOfDaySecondView = new EUiViewName("TimeOfDaySecondView");

		// Token: 0x04018F5F RID: 102239
		public static readonly EUiViewName ExchangePopView = new EUiViewName("ExchangePopView");

		// Token: 0x04018F60 RID: 102240
		public static readonly EUiViewName GameplayExchangePopView = new EUiViewName("GameplayExchangePopView");

		// Token: 0x04018F61 RID: 102241
		public static readonly EUiViewName TutorialView = new EUiViewName("TutorialView");

		// Token: 0x04018F62 RID: 102242
		public static readonly EUiViewName TutorialPopView = new EUiViewName("TutorialPopView");

		// Token: 0x04018F63 RID: 102243
		public static readonly EUiViewName AdventureGuideView = new EUiViewName("AdventureGuideView");

		// Token: 0x04018F64 RID: 102244
		public static readonly EUiViewName AcquireView = new EUiViewName("AcquireView");

		// Token: 0x04018F65 RID: 102245
		public static readonly EUiViewName InventoryGiftView = new EUiViewName("InventoryGiftView");

		// Token: 0x04018F66 RID: 102246
		public static readonly EUiViewName InfoDisplayImgView = new EUiViewName("InfoDisplayImgView");

		// Token: 0x04018F67 RID: 102247
		public static readonly EUiViewName InfoDisplayTypeOneView = new EUiViewName("InfoDisplayTypeOneView");

		// Token: 0x04018F68 RID: 102248
		public static readonly EUiViewName InfoDisplayTypeTwoView = new EUiViewName("InfoDisplayTypeTwoView");

		// Token: 0x04018F69 RID: 102249
		public static readonly EUiViewName InfoDisplayTypeThreeView = new EUiViewName("InfoDisplayTypeThreeView");

		// Token: 0x04018F6A RID: 102250
		public static readonly EUiViewName InfoDisplayTypeFourView = new EUiViewName("InfoDisplayTypeFourView");

		// Token: 0x04018F6B RID: 102251
		public static readonly EUiViewName InfoDisplayTypeFourNewView = new EUiViewName("InfoDisplayTypeFourNewView");

		// Token: 0x04018F6C RID: 102252
		public static readonly EUiViewName InfoDisplayTypeFiveView = new EUiViewName("InfoDisplayTypeFiveView");

		// Token: 0x04018F6D RID: 102253
		public static readonly EUiViewName InfoDisplayAttachmentBigImgView = new EUiViewName("InfoDisplayAttachmentBigImgView");

		// Token: 0x04018F6E RID: 102254
		public static readonly EUiViewName WeaponPreviewView = new EUiViewName("WeaponPreviewView");

		// Token: 0x04018F6F RID: 102255
		public static readonly EUiViewName MonthCardView = new EUiViewName("MonthCardView");

		// Token: 0x04018F70 RID: 102256
		public static readonly EUiViewName MonthCardRewardView = new EUiViewName("MonthCardRewardView");

		// Token: 0x04018F71 RID: 102257
		public static readonly EUiViewName AttributeView = new EUiViewName("AttributeView");

		// Token: 0x04018F72 RID: 102258
		public static readonly EUiViewName RoleAttributeDetailView = new EUiViewName("RoleAttributeDetailView");

		// Token: 0x04018F73 RID: 102259
		public static readonly EUiViewName SkillLevelUpView = new EUiViewName("SkillLevelUpView");

		// Token: 0x04018F74 RID: 102260
		public static readonly EUiViewName RoleSkillTreeInfoView = new EUiViewName("RoleSkillTreeInfoView");

		// Token: 0x04018F75 RID: 102261
		public static readonly EUiViewName RoleSkillInputView = new EUiViewName("RoleSkillInputView");

		// Token: 0x04018F76 RID: 102262
		public static readonly EUiViewName RoleQuestView = new EUiViewName("RoleQuestView");

		// Token: 0x04018F77 RID: 102263
		public static readonly EUiViewName ReportView = new EUiViewName("ReportView");

		// Token: 0x04018F78 RID: 102264
		public static readonly EUiViewName CookRootView = new EUiViewName("CookRootView");

		// Token: 0x04018F79 RID: 102265
		public static readonly EUiViewName CookLevelView = new EUiViewName("CookLevelView");

		// Token: 0x04018F7A RID: 102266
		public static readonly EUiViewName CookRoleView = new EUiViewName("CookRoleView");

		// Token: 0x04018F7B RID: 102267
		public static readonly EUiViewName CookPopView = new EUiViewName("CookPopView");

		// Token: 0x04018F7C RID: 102268
		public static readonly EUiViewName CookSuccessView = new EUiViewName("CookSuccessView");

		// Token: 0x04018F7D RID: 102269
		public static readonly EUiViewName RoleFavorInfoView = new EUiViewName("RoleFavorInfoView");

		// Token: 0x04018F7E RID: 102270
		public static readonly EUiViewName RoleFavorHintView = new EUiViewName("RoleFavorHintView");

		// Token: 0x04018F7F RID: 102271
		public static readonly EUiViewName RoleLangCustomView = new EUiViewName("RoleLangCustomView");

		// Token: 0x04018F80 RID: 102272
		public static readonly EUiViewName RoleLangRemoveView = new EUiViewName("RoleLangRemoveView");

		// Token: 0x04018F81 RID: 102273
		public static readonly EUiViewName RoleLangNetConfirmPop = new EUiViewName("RoleLangNetConfirmPop");

		// Token: 0x04018F82 RID: 102274
		public static readonly EUiViewName RoleGiftSplashView = new EUiViewName("RoleGiftSplashView");

		// Token: 0x04018F83 RID: 102275
		public static readonly EUiViewName FunctionOpenView = new EUiViewName("FunctionOpenView");

		// Token: 0x04018F84 RID: 102276
		public static readonly EUiViewName CookPopFixView = new EUiViewName("CookPopFixView");

		// Token: 0x04018F85 RID: 102277
		public static readonly EUiViewName SingleTimeTowerView = new EUiViewName("SingleTimeTowerView");

		// Token: 0x04018F86 RID: 102278
		public static readonly EUiViewName SingleTimeTowerChallengeView = new EUiViewName("SingleTimeTowerChallengeView");

		// Token: 0x04018F87 RID: 102279
		public static readonly EUiViewName SingleTimeTowerTeamView = new EUiViewName("SingleTimeTowerTeamView");

		// Token: 0x04018F88 RID: 102280
		public static readonly EUiViewName SingleTimeTowerDetailView = new EUiViewName("SingleTimeTowerDetailView");

		// Token: 0x04018F89 RID: 102281
		public static readonly EUiViewName SingleTimeTowerVictoryView = new EUiViewName("SingleTimeTowerVictoryView");

		// Token: 0x04018F8A RID: 102282
		public static readonly EUiViewName SingleTimeTowerFailView = new EUiViewName("SingleTimeTowerFailView");

		// Token: 0x04018F8B RID: 102283
		public static readonly EUiViewName TowerRewardView = new EUiViewName("TowerRewardView");

		// Token: 0x04018F8C RID: 102284
		public static readonly EUiViewName TowerApplyFloorDataView = new EUiViewName("TowerApplyFloorDataView");

		// Token: 0x04018F8D RID: 102285
		public static readonly EUiViewName TowerNormalView = new EUiViewName("TowerNormalView");

		// Token: 0x04018F8E RID: 102286
		public static readonly EUiViewName TowerFloorView = new EUiViewName("TowerFloorView");

		// Token: 0x04018F8F RID: 102287
		public static readonly EUiViewName TowerVariationView = new EUiViewName("TowerVariationView");

		// Token: 0x04018F90 RID: 102288
		public static readonly EUiViewName TowerResetView = new EUiViewName("TowerResetView");

		// Token: 0x04018F91 RID: 102289
		public static readonly EUiViewName TowerRecommendView = new EUiViewName("TowerRecommendView");

		// Token: 0x04018F92 RID: 102290
		public static readonly EUiViewName TowerReviewView = new EUiViewName("TowerReviewView");

		// Token: 0x04018F93 RID: 102291
		public static readonly EUiViewName TowerFloorDetailView = new EUiViewName("TowerFloorDetailView");

		// Token: 0x04018F94 RID: 102292
		public static readonly EUiViewName TowerGuideView = new EUiViewName("TowerGuideView");

		// Token: 0x04018F95 RID: 102293
		public static readonly EUiViewName TowerUnlockView = new EUiViewName("TowerUnlockView");

		// Token: 0x04018F96 RID: 102294
		public static readonly EUiViewName TowerChallengeFormationView = new EUiViewName("TowerChallengeFormationView");

		// Token: 0x04018F97 RID: 102295
		public static readonly EUiViewName TowerOverLockUnlockView = new EUiViewName("TowerOverLockUnlockView");

		// Token: 0x04018F98 RID: 102296
		public static readonly EUiViewName EventConditionFloatTips = new EUiViewName("EventConditionFloatTips");

		// Token: 0x04018F99 RID: 102297
		public static readonly EUiViewName ChallengeAchieveFloatTips = new EUiViewName("ChallengeAchieveFloatTips");

		// Token: 0x04018F9A RID: 102298
		public static readonly EUiViewName ChallengeWantedAchieveFloatTips = new EUiViewName("ChallengeWantedAchieveFloatTips");

		// Token: 0x04018F9B RID: 102299
		public static readonly EUiViewName ChallengeSuccessFloatTips = new EUiViewName("ChallengeSuccessFloatTips");

		// Token: 0x04018F9C RID: 102300
		public static readonly EUiViewName ChallengeFailedFloatTips = new EUiViewName("ChallengeFailedFloatTips");

		// Token: 0x04018F9D RID: 102301
		public static readonly EUiViewName AdditionalTasksFloatTips = new EUiViewName("AdditionalTasksFloatTips");

		// Token: 0x04018F9E RID: 102302
		public static readonly EUiViewName DelegateCompletionFloatTips = new EUiViewName("DelegateCompletionFloatTips");

		// Token: 0x04018F9F RID: 102303
		public static readonly EUiViewName CountDownFloatTips = new EUiViewName("CountDownFloatTips");

		// Token: 0x04018FA0 RID: 102304
		public static readonly EUiViewName CountDownChallenge = new EUiViewName("CountDownChallenge");

		// Token: 0x04018FA1 RID: 102305
		public static readonly EUiViewName UnOpenedAreaCountDownFloatTips = new EUiViewName("UnOpenedAreaCountDownFloatTips");

		// Token: 0x04018FA2 RID: 102306
		public static readonly EUiViewName LevelGamePlayPrepareCountDown = new EUiViewName("LevelGamePlayPrepareCountDown");

		// Token: 0x04018FA3 RID: 102307
		public static readonly EUiViewName LevelGamePlayMotorPrepareCountDown = new EUiViewName("LevelGamePlayMotorPrepareCountDown");

		// Token: 0x04018FA4 RID: 102308
		public static readonly EUiViewName PunishReportView = new EUiViewName("PunishReportView");

		// Token: 0x04018FA5 RID: 102309
		public static readonly EUiViewName PunishReportSettlementView = new EUiViewName("PunishReportSettlementView");

		// Token: 0x04018FA6 RID: 102310
		public static readonly EUiViewName DungeonClearanceFloatTips = new EUiViewName("DungeonClearanceFloatTips");

		// Token: 0x04018FA7 RID: 102311
		public static readonly EUiViewName DungeonAutoExitFloatTips = new EUiViewName("DungeonAutoExitFloatTips");

		// Token: 0x04018FA8 RID: 102312
		public static readonly EUiViewName ChapterEndFloatTips = new EUiViewName("ChapterEndFloatTips");

		// Token: 0x04018FA9 RID: 102313
		public static readonly EUiViewName FlowChapterStartTips = new EUiViewName("FlowChapterStartTips");

		// Token: 0x04018FAA RID: 102314
		public static readonly EUiViewName FlowChapterEndTips = new EUiViewName("FlowChapterEndTips");

		// Token: 0x04018FAB RID: 102315
		public static readonly EUiViewName ChapterBattleDeclarationTipsRed = new EUiViewName("ChapterBattleDeclarationTipsRed");

		// Token: 0x04018FAC RID: 102316
		public static readonly EUiViewName ChapterBattleDeclarationTipsWhite = new EUiViewName("ChapterBattleDeclarationTipsWhite");

		// Token: 0x04018FAD RID: 102317
		public static readonly EUiViewName ChapterStartFloatTips = new EUiViewName("ChapterStartFloatTips");

		// Token: 0x04018FAE RID: 102318
		public static readonly EUiViewName DailyTaskEndTips = new EUiViewName("DailyTaskEndTips");

		// Token: 0x04018FAF RID: 102319
		public static readonly EUiViewName TaskEndTips = new EUiViewName("TaskEndTips");

		// Token: 0x04018FB0 RID: 102320
		public static readonly EUiViewName PrepareCountdownFloatTips = new EUiViewName("PrepareCountdownFloatTips");

		// Token: 0x04018FB1 RID: 102321
		public static readonly EUiViewName ComboTeachingFloatTips = new EUiViewName("ComboTeachingFloatTips");

		// Token: 0x04018FB2 RID: 102322
		public static readonly EUiViewName InfluenceReputationView = new EUiViewName("InfluenceReputationView");

		// Token: 0x04018FB3 RID: 102323
		public static readonly EUiViewName InfluenceAreaSelectView = new EUiViewName("InfluenceAreaSelectView");

		// Token: 0x04018FB4 RID: 102324
		public static readonly EUiViewName ReputationDetailsView = new EUiViewName("ReputationDetailsView");

		// Token: 0x04018FB5 RID: 102325
		public static readonly EUiViewName ReputationTips = new EUiViewName("ReputationTips");

		// Token: 0x04018FB6 RID: 102326
		public static readonly EUiViewName ReputationRewardsView = new EUiViewName("ReputationRewardsView");

		// Token: 0x04018FB7 RID: 102327
		public static readonly EUiViewName InfluenceSearchView = new EUiViewName("InfluenceSearchView");

		// Token: 0x04018FB8 RID: 102328
		public static readonly EUiViewName CycleTowerView = new EUiViewName("CycleTowerView");

		// Token: 0x04018FB9 RID: 102329
		public static readonly EUiViewName CycleTowerChallengeView = new EUiViewName("CycleTowerChallengeView");

		// Token: 0x04018FBA RID: 102330
		public static readonly EUiViewName CycleTowerTeamView = new EUiViewName("CycleTowerTeamView");

		// Token: 0x04018FBB RID: 102331
		public static readonly EUiViewName CycleTowerDetailView = new EUiViewName("CycleTowerDetailView");

		// Token: 0x04018FBC RID: 102332
		public static readonly EUiViewName CycleTowerRewardView = new EUiViewName("CycleTowerRewardView");

		// Token: 0x04018FBD RID: 102333
		public static readonly EUiViewName CycleTowerSeasonRewardView = new EUiViewName("CycleTowerSeasonRewardView");

		// Token: 0x04018FBE RID: 102334
		public static readonly EUiViewName CycleTowerClearInfoView = new EUiViewName("CycleTowerClearInfoView");

		// Token: 0x04018FBF RID: 102335
		public static readonly EUiViewName CycleTowerSeasonInfoView = new EUiViewName("CycleTowerSeasonInfoView");

		// Token: 0x04018FC0 RID: 102336
		public static readonly EUiViewName TowerDetailView = new EUiViewName("TowerDetailView");

		// Token: 0x04018FC1 RID: 102337
		public static readonly EUiViewName BattlePassMainView = new EUiViewName("BattlePassMainView");

		// Token: 0x04018FC2 RID: 102338
		public static readonly EUiViewName BattlePassBuyLevelView = new EUiViewName("BattlePassBuyLevelView");

		// Token: 0x04018FC3 RID: 102339
		public static readonly EUiViewName BattlePassPayView = new EUiViewName("BattlePassPayView");

		// Token: 0x04018FC4 RID: 102340
		public static readonly EUiViewName BattlePassUnlockView = new EUiViewName("BattlePassUnlockView");

		// Token: 0x04018FC5 RID: 102341
		public static readonly EUiViewName BattlePassUpLevelView = new EUiViewName("BattlePassUpLevelView");

		// Token: 0x04018FC6 RID: 102342
		public static readonly EUiViewName BattlePassFirstOpenView = new EUiViewName("BattlePassFirstOpenView");

		// Token: 0x04018FC7 RID: 102343
		public static readonly EUiViewName DrawMainView = new EUiViewName("DrawMainView");

		// Token: 0x04018FC8 RID: 102344
		public static readonly EUiViewName PhonographView = new EUiViewName("PhonographView");

		// Token: 0x04018FC9 RID: 102345
		public static readonly EUiViewName PhonographNewMusicView = new EUiViewName("PhonographNewMusicView");

		// Token: 0x04018FCA RID: 102346
		public static readonly EUiViewName RoleHandBookRootView = new EUiViewName("RoleHandBookRootView");

		// Token: 0x04018FCB RID: 102347
		public static readonly EUiViewName RoleHandBookSelectionView = new EUiViewName("RoleHandBookSelectionView");

		// Token: 0x04018FCC RID: 102348
		public static readonly EUiViewName ComposeRootView = new EUiViewName("ComposeRootView");

		// Token: 0x04018FCD RID: 102349
		public static readonly EUiViewName ComposeLevelView = new EUiViewName("ComposeLevelView");

		// Token: 0x04018FCE RID: 102350
		public static readonly EUiViewName ManufactureHelpRoleView = new EUiViewName("ManufactureHelpRoleView");

		// Token: 0x04018FCF RID: 102351
		public static readonly EUiViewName ForgingRootView = new EUiViewName("ForgingRootView");

		// Token: 0x04018FD0 RID: 102352
		public static readonly EUiViewName RewardPopView = new EUiViewName("RewardPopView");

		// Token: 0x04018FD1 RID: 102353
		public static readonly EUiViewName ResolutionListView = new EUiViewName("ResolutionListView");

		// Token: 0x04018FD2 RID: 102354
		public static readonly EUiViewName BrightnessView = new EUiViewName("BrightnessView");

		// Token: 0x04018FD3 RID: 102355
		public static readonly EUiViewName LogUploadView = new EUiViewName("LogUploadView");

		// Token: 0x04018FD4 RID: 102356
		public static readonly EUiViewName ToolWindowView = new EUiViewName("ToolWindowView");

		// Token: 0x04018FD5 RID: 102357
		public static readonly EUiViewName VulkanSetView = new EUiViewName("VulkanSetView");

		// Token: 0x04018FD6 RID: 102358
		public static readonly EUiViewName PhotographView = new EUiViewName("PhotographView");

		// Token: 0x04018FD7 RID: 102359
		public static readonly EUiViewName PhotographSetupView = new EUiViewName("PhotographSetupView");

		// Token: 0x04018FD8 RID: 102360
		public static readonly EUiViewName PhotoSaveView = new EUiViewName("PhotoSaveView");

		// Token: 0x04018FD9 RID: 102361
		public static readonly EUiViewName FightPhotographView = new EUiViewName("FightPhotographView");

		// Token: 0x04018FDA RID: 102362
		public static readonly EUiViewName FightPhotoResultView = new EUiViewName("FightPhotoResultView");

		// Token: 0x04018FDB RID: 102363
		public static readonly EUiViewName FightPhotoRewardView = new EUiViewName("FightPhotoRewardView");

		// Token: 0x04018FDC RID: 102364
		public static readonly EUiViewName FightPhotoMainView = new EUiViewName("FightPhotoMainView");

		// Token: 0x04018FDD RID: 102365
		public static readonly EUiViewName FightPhotoUnlockTipView = new EUiViewName("FightPhotoUnlockTipView");

		// Token: 0x04018FDE RID: 102366
		public static readonly EUiViewName FightPhotoEventTipView = new EUiViewName("FightPhotoEventTipView");

		// Token: 0x04018FDF RID: 102367
		public static readonly EUiViewName FightPhotoFocusView = new EUiViewName("FightPhotoFocusView");

		// Token: 0x04018FE0 RID: 102368
		public static readonly EUiViewName FightPhotoLoadingView = new EUiViewName("FightPhotoLoadingView");

		// Token: 0x04018FE1 RID: 102369
		public static readonly EUiViewName FightPhotoSaveView = new EUiViewName("FightPhotoSaveView");

		// Token: 0x04018FE2 RID: 102370
		public static readonly EUiViewName CaptureCollectView = new EUiViewName("CaptureCollectView");

		// Token: 0x04018FE3 RID: 102371
		public static readonly EUiViewName PhotoCameraView = new EUiViewName("PhotoCameraView");

		// Token: 0x04018FE4 RID: 102372
		public static readonly EUiViewName PhotoMainView = new EUiViewName("PhotoMainView");

		// Token: 0x04018FE5 RID: 102373
		public static readonly EUiViewName UseReviveItemView = new EUiViewName("UseReviveItemView");

		// Token: 0x04018FE6 RID: 102374
		public static readonly EUiViewName PhantomBattleSkillInfoView = new EUiViewName("PhantomBattleSkillInfoView");

		// Token: 0x04018FE7 RID: 102375
		public static readonly EUiViewName PhantomBattleFettersObtainView = new EUiViewName("PhantomBattleFettersObtainView");

		// Token: 0x04018FE8 RID: 102376
		public static readonly EUiViewName CalabashUnlockItemView = new EUiViewName("CalabashUnlockItemView");

		// Token: 0x04018FE9 RID: 102377
		public static readonly EUiViewName PhantomDecomposeView = new EUiViewName("PhantomBattleDecomposeView");

		// Token: 0x04018FEA RID: 102378
		public static readonly EUiViewName BattleUiSetView = new EUiViewName("BattleUiSetView");

		// Token: 0x04018FEB RID: 102379
		public static readonly EUiViewName AchievementMainView = new EUiViewName("AchievementMainView");

		// Token: 0x04018FEC RID: 102380
		public static readonly EUiViewName AchievementDetailView = new EUiViewName("AchievementDetailView");

		// Token: 0x04018FED RID: 102381
		public static readonly EUiViewName AchievementFinishView = new EUiViewName("AchievementFinishView");

		// Token: 0x04018FEE RID: 102382
		public static readonly EUiViewName AchievementCompleteTipsView = new EUiViewName("AchievementCompleteTipsView");

		// Token: 0x04018FEF RID: 102383
		public static readonly EUiViewName ExploreProgressView = new EUiViewName("ExploreProgressView");

		// Token: 0x04018FF0 RID: 102384
		public static readonly EUiViewName RoleBreachSuccessView = new EUiViewName("RoleBreachSuccessView");

		// Token: 0x04018FF1 RID: 102385
		public static readonly EUiViewName LoginServerView = new EUiViewName("LoginServerView");

		// Token: 0x04018FF2 RID: 102386
		public static readonly EUiViewName RoleGenderChangeView = new EUiViewName("RoleGenderChangeView");

		// Token: 0x04018FF3 RID: 102387
		public static readonly EUiViewName RoleElementView = new EUiViewName("RoleElementView");

		// Token: 0x04018FF4 RID: 102388
		public static readonly EUiViewName ComboTeachingView = new EUiViewName("ComboTeachingView");

		// Token: 0x04018FF5 RID: 102389
		public static readonly EUiViewName PersonalRootView = new EUiViewName("PersonalRootView");

		// Token: 0x04018FF6 RID: 102390
		public static readonly EUiViewName PersonalOptionView = new EUiViewName("PersonalOptionView");

		// Token: 0x04018FF7 RID: 102391
		public static readonly EUiViewName PersonalBirthView = new EUiViewName("PersonalBirthView");

		// Token: 0x04018FF8 RID: 102392
		public static readonly EUiViewName PersonalEditView = new EUiViewName("PersonalEditView");

		// Token: 0x04018FF9 RID: 102393
		public static readonly EUiViewName FrozenQteView = new EUiViewName("FrozenQteView");

		// Token: 0x04018FFA RID: 102394
		public static readonly EUiViewName InteractQteView = new EUiViewName("InteractQteView");

		// Token: 0x04018FFB RID: 102395
		public static readonly EUiViewName YouHuQteView = new EUiViewName("YouHuQteView");

		// Token: 0x04018FFC RID: 102396
		public static readonly EUiViewName XiaKongQteView = new EUiViewName("XiaKongQteView");

		// Token: 0x04018FFD RID: 102397
		public static readonly EUiViewName FreeRunningQteView = new EUiViewName("FreeRunningQteView");

		// Token: 0x04018FFE RID: 102398
		public static readonly EUiViewName CommonQteView = new EUiViewName("CommonQteView");

		// Token: 0x04018FFF RID: 102399
		public static readonly EUiViewName CommonQteNoIconView = new EUiViewName("CommonQteNoIconView");

		// Token: 0x04019000 RID: 102400
		public static readonly EUiViewName CommonQteContinuousClickView = new EUiViewName("CommonQteContinuousClickView");

		// Token: 0x04019001 RID: 102401
		public static readonly EUiViewName CommonQteLongPressView = new EUiViewName("CommonQteLongPressView");

		// Token: 0x04019002 RID: 102402
		public static readonly EUiViewName CommonQteNoIconLongPressView = new EUiViewName("CommonQteNoIconLongPressView");

		// Token: 0x04019003 RID: 102403
		public static readonly EUiViewName QtaView = new EUiViewName("QtaView");

		// Token: 0x04019004 RID: 102404
		public static readonly EUiViewName PersonalRoleShowView = new EUiViewName("PersonalRoleShowView");

		// Token: 0x04019005 RID: 102405
		public static readonly EUiViewName PersonalCardView = new EUiViewName("PersonalCardView");

		// Token: 0x04019006 RID: 102406
		public static readonly EUiViewName CommonActivityView = new EUiViewName("CommonActivityView");

		// Token: 0x04019007 RID: 102407
		public static readonly EUiViewName ActivityRewardPopUpView = new EUiViewName("ActivityRewardPopUpView");

		// Token: 0x04019008 RID: 102408
		public static readonly EUiViewName LongShanUnlockView = new EUiViewName("LongShanUnlockView");

		// Token: 0x04019009 RID: 102409
		public static readonly EUiViewName ActivityRunView = new EUiViewName("ActivityRunView");

		// Token: 0x0401900A RID: 102410
		public static readonly EUiViewName ActivityRunSuccessView = new EUiViewName("ActivityRunSuccessView");

		// Token: 0x0401900B RID: 102411
		public static readonly EUiViewName ActivityRunFailView = new EUiViewName("ActivityRunFailView");

		// Token: 0x0401900C RID: 102412
		public static readonly EUiViewName BossRushMainView = new EUiViewName("BossRushMainView");

		// Token: 0x0401900D RID: 102413
		public static readonly EUiViewName BossRushBuffInGameView = new EUiViewName("BossRushBuffInGameView");

		// Token: 0x0401900E RID: 102414
		public static readonly EUiViewName ActivityTurntableRewardView = new EUiViewName("ActivityTurntableRewardView");

		// Token: 0x0401900F RID: 102415
		public static readonly EUiViewName ActivityUnlockTipView = new EUiViewName("ActivityUnlockTipView");

		// Token: 0x04019010 RID: 102416
		public static readonly EUiViewName TowerDefensePhantomView = new EUiViewName("TowerDefensePhantomView");

		// Token: 0x04019011 RID: 102417
		public static readonly EUiViewName ActivityUnlockTipMoonChasingView = new EUiViewName("ActivityUnlockTipMoonChasingView");

		// Token: 0x04019012 RID: 102418
		public static readonly EUiViewName CorniceMeetingMainView = new EUiViewName("CorniceMeetingMainView");

		// Token: 0x04019013 RID: 102419
		public static readonly EUiViewName ActivityConditionView = new EUiViewName("ActivityConditionView");

		// Token: 0x04019014 RID: 102420
		public static readonly EUiViewName CommonConditionView = new EUiViewName("CommonConditionView");

		// Token: 0x04019015 RID: 102421
		public static readonly EUiViewName BlackCoastActivityMainView = new EUiViewName("BlackCoastActivityMainView");

		// Token: 0x04019016 RID: 102422
		public static readonly EUiViewName BlackCoastActivityTaskView = new EUiViewName("BlackCoastActivityTaskView");

		// Token: 0x04019017 RID: 102423
		public static readonly EUiViewName ActivityUnlockTipBlackCoastView = new EUiViewName("ActivityUnlockTipBlackCoastView");

		// Token: 0x04019018 RID: 102424
		public static readonly EUiViewName ActivityUnlockTipDreamLinkView = new EUiViewName("ActivityUnlockTipDreamLinkView");

		// Token: 0x04019019 RID: 102425
		public static readonly EUiViewName DreamLinkWhiteCatSettleView = new EUiViewName("DreamLinkWhiteCatSettleView");

		// Token: 0x0401901A RID: 102426
		public static readonly EUiViewName ActivityInstanceEntranceView = new EUiViewName("ActivityInstanceEntranceView");

		// Token: 0x0401901B RID: 102427
		public static readonly EUiViewName CommonRewardView = new EUiViewName("CommonRewardView");

		// Token: 0x0401901C RID: 102428
		public static readonly EUiViewName PayRewardView = new EUiViewName("PayRewardView");

		// Token: 0x0401901D RID: 102429
		public static readonly EUiViewName RoleIntroductionView = new EUiViewName("RoleIntroductionView");

		// Token: 0x0401901E RID: 102430
		public static readonly EUiViewName QuestRewardView = new EUiViewName("QuestRewardView");

		// Token: 0x0401901F RID: 102431
		public static readonly EUiViewName CompositeRewardView = new EUiViewName("CompositeRewardView");

		// Token: 0x04019020 RID: 102432
		public static readonly EUiViewName ExploreRewardView = new EUiViewName("ExploreRewardView");

		// Token: 0x04019021 RID: 102433
		public static readonly EUiViewName ExploreLevelRewardView = new EUiViewName("ExploreLevelRewardView");

		// Token: 0x04019022 RID: 102434
		public static readonly EUiViewName BattlePassExtraRewardView = new EUiViewName("BattlePassExtraRewardView");

		// Token: 0x04019023 RID: 102435
		public static readonly EUiViewName CommunicateView = new EUiViewName("CommunicateView");

		// Token: 0x04019024 RID: 102436
		public static readonly EUiViewName FilterView = new EUiViewName("FilterView");

		// Token: 0x04019025 RID: 102437
		public static readonly EUiViewName VisionFilterView = new EUiViewName("VisionFilterView");

		// Token: 0x04019026 RID: 102438
		public static readonly EUiViewName SortView = new EUiViewName("SortView");

		// Token: 0x04019027 RID: 102439
		public static readonly EUiViewName CommonItemSelectViewLeft = new EUiViewName("CommonItemSelectViewLeft");

		// Token: 0x04019028 RID: 102440
		public static readonly EUiViewName CommonItemSelectViewRight = new EUiViewName("CommonItemSelectViewRight");

		// Token: 0x04019029 RID: 102441
		public static readonly EUiViewName VisionEquipmentView = new EUiViewName("VisionEquipmentView");

		// Token: 0x0401902A RID: 102442
		public static readonly EUiViewName VisionLevelUpView = new EUiViewName("VisionLevelUpView");

		// Token: 0x0401902B RID: 102443
		public static readonly EUiViewName VisionSlotView = new EUiViewName("VisionSlotView");

		// Token: 0x0401902C RID: 102444
		public static readonly EUiViewName VisionIntensifyView = new EUiViewName("VisionIntensifyView");

		// Token: 0x0401902D RID: 102445
		public static readonly EUiViewName VisionSlotSuccessView = new EUiViewName("VisionSlotSuccessView");

		// Token: 0x0401902E RID: 102446
		public static readonly EUiViewName VisionLevelUpSuccessView = new EUiViewName("VisionLevelUpSuccessView");

		// Token: 0x0401902F RID: 102447
		public static readonly EUiViewName VisionRecommendView = new EUiViewName("VisionRecommendView");

		// Token: 0x04019030 RID: 102448
		public static readonly EUiViewName VisionNewRecommendView = new EUiViewName("VisionNewRecommendView");

		// Token: 0x04019031 RID: 102449
		public static readonly EUiViewName VisionNewRecommendPreviewView = new EUiViewName("VisionNewRecommendPreviewView");

		// Token: 0x04019032 RID: 102450
		public static readonly EUiViewName VisionLookOverView = new EUiViewName("VisionLookOverView");

		// Token: 0x04019033 RID: 102451
		public static readonly EUiViewName VisionSkinView = new EUiViewName("VisionSkinView");

		// Token: 0x04019034 RID: 102452
		public static readonly EUiViewName VisionAssembleView = new EUiViewName("VisionAssembleView");

		// Token: 0x04019035 RID: 102453
		public static readonly EUiViewName SignalDecodeView = new EUiViewName("SignalDecodeView");

		// Token: 0x04019036 RID: 102454
		public static readonly EUiViewName SignalDeviceView = new EUiViewName("SignalDeviceView");

		// Token: 0x04019037 RID: 102455
		public static readonly EUiViewName SignalDeviceChasingMoonView = new EUiViewName("SignalDeviceChasingMoonView");

		// Token: 0x04019038 RID: 102456
		public static readonly EUiViewName QuestFailRangeTipsView = new EUiViewName("QuestFailRangeTipsView");

		// Token: 0x04019039 RID: 102457
		public static readonly EUiViewName RoleLevelUpSuccessAttributeView = new EUiViewName("RoleLevelUpSuccessAttributeView");

		// Token: 0x0401903A RID: 102458
		public static readonly EUiViewName RoleLevelUpSuccessEffectView = new EUiViewName("RoleLevelUpSuccessEffectView");

		// Token: 0x0401903B RID: 102459
		public static readonly EUiViewName CommonSingleInputView = new EUiViewName("CommonSingleInputView");

		// Token: 0x0401903C RID: 102460
		public static readonly EUiViewName CommonModifyNameInputView = new EUiViewName("CommonModifyNameInputView");

		// Token: 0x0401903D RID: 102461
		public static readonly EUiViewName CommonMultiInputView = new EUiViewName("CommonMultiInputView");

		// Token: 0x0401903E RID: 102462
		public static readonly EUiViewName CdKeyInputView = new EUiViewName("CdKeyInputView");

		// Token: 0x0401903F RID: 102463
		public static readonly EUiViewName VersionCheckView = new EUiViewName("VersionCheckView");

		// Token: 0x04019040 RID: 102464
		public static readonly EUiViewName VisionAssembleInputView = new EUiViewName("VisionAssembleInputView");

		// Token: 0x04019041 RID: 102465
		public static readonly EUiViewName PingView = new EUiViewName("PingView");

		// Token: 0x04019042 RID: 102466
		public static readonly EUiViewName RogueInfoView = new EUiViewName("RogueInfoView");

		// Token: 0x04019043 RID: 102467
		public static readonly EUiViewName RogueShopView = new EUiViewName("RogueShopView");

		// Token: 0x04019044 RID: 102468
		public static readonly EUiViewName RogueRoomTip = new EUiViewName("RogueRoomTip");

		// Token: 0x04019045 RID: 102469
		public static readonly EUiViewName RoguelikeInstanceView = new EUiViewName("RoguelikeInstanceView");

		// Token: 0x04019046 RID: 102470
		public static readonly EUiViewName RoguelikeSelectRoleView = new EUiViewName("RoguelikeSelectRoleView");

		// Token: 0x04019047 RID: 102471
		public static readonly EUiViewName RoguelikeBossChallengeView = new EUiViewName("RoguelikeBossChallengeView");

		// Token: 0x04019048 RID: 102472
		public static readonly EUiViewName RoguelikeBossChallengeBuffDetailView = new EUiViewName("RoguelikeBossChallengeBuffDetailView");

		// Token: 0x04019049 RID: 102473
		public static readonly EUiViewName RoguelikeSettleView = new EUiViewName("RoguelikeSettleView");

		// Token: 0x0401904A RID: 102474
		public static readonly EUiViewName RoguelikeExitTips = new EUiViewName("RoguelikeExitTips");

		// Token: 0x0401904B RID: 102475
		public static readonly EUiViewName WeeklyRogueExitTips = new EUiViewName("WeeklyRogueExitTips");

		// Token: 0x0401904C RID: 102476
		public static readonly EUiViewName WeeklyRogueResultCheckView = new EUiViewName("WeeklyRogueResultCheckView");

		// Token: 0x0401904D RID: 102477
		public static readonly EUiViewName RoguelikeRoomFloatTips = new EUiViewName("RoguelikeRoomFloatTips");

		// Token: 0x0401904E RID: 102478
		public static readonly EUiViewName BattleFloatTipsView = new EUiViewName("BattleFloatTipsView");

		// Token: 0x0401904F RID: 102479
		public static readonly EUiViewName LoadingView = new EUiViewName("LoadingView");

		// Token: 0x04019050 RID: 102480
		public static readonly EUiViewName RacingBetsLoadingView = new EUiViewName("RacingBetsLoadingView");

		// Token: 0x04019051 RID: 102481
		public static readonly EUiViewName CyberpunkLoadingView = new EUiViewName("CyberpunkLoadingView");

		// Token: 0x04019052 RID: 102482
		public static readonly EUiViewName FadeLoadingView = new EUiViewName("FadeLoadingView");

		// Token: 0x04019053 RID: 102483
		public static readonly EUiViewName RoleLoadingView = new EUiViewName("RoleLoadingView");

		// Token: 0x04019054 RID: 102484
		public static readonly EUiViewName SpecialTransitionView = new EUiViewName("SpecialTransitionView");

		// Token: 0x04019055 RID: 102485
		public static readonly EUiViewName BlackScreenTextView = new EUiViewName("BlackScreenTextView");

		// Token: 0x04019056 RID: 102486
		public static readonly EUiViewName RoguelikeSkillView = new EUiViewName("RoguelikeSkillView");

		// Token: 0x04019057 RID: 102487
		public static readonly EUiViewName RoguelikeActivityView = new EUiViewName("RoguelikeActivityView");

		// Token: 0x04019058 RID: 102488
		public static readonly EUiViewName SoundAreaPlayTips = new EUiViewName("SoundAreaPlayTips");

		// Token: 0x04019059 RID: 102489
		public static readonly EUiViewName ExploreDetailView = new EUiViewName("ExploreDetailView");

		// Token: 0x0401905A RID: 102490
		public static readonly EUiViewName MapAreaShowView = new EUiViewName("MapAreaShowView");

		// Token: 0x0401905B RID: 102491
		public static readonly EUiViewName MapExploreDetailView = new EUiViewName("MapExploreDetailView");

		// Token: 0x0401905C RID: 102492
		public static readonly EUiViewName MapPlayPointDetailView = new EUiViewName("MapPlayPointDetailView");

		// Token: 0x0401905D RID: 102493
		public static readonly EUiViewName MapExploreStoryView = new EUiViewName("MapExploreStoryView");

		// Token: 0x0401905E RID: 102494
		public static readonly EUiViewName RoguelikeMemoryPlaceView = new EUiViewName("RoguelikeMemoryPlaceView");

		// Token: 0x0401905F RID: 102495
		public static readonly EUiViewName RoguelikeAchievementView = new EUiViewName("RoguelikeAchievementView");

		// Token: 0x04019060 RID: 102496
		public static readonly EUiViewName RoguelikeTokenOverView = new EUiViewName("RoguelikeTokenOverView");

		// Token: 0x04019061 RID: 102497
		public static readonly EUiViewName ExploreLevelView = new EUiViewName("ExploreLevelView");

		// Token: 0x04019062 RID: 102498
		public static readonly EUiViewName ExploreLevelPreviewView = new EUiViewName("ExploreLevelPreviewView");

		// Token: 0x04019063 RID: 102499
		public static readonly EUiViewName RoguelikeRandomEventView = new EUiViewName("RoguelikeRandomEventView");

		// Token: 0x04019064 RID: 102500
		public static readonly EUiViewName RogueBattleRandomEventView = new EUiViewName("RogueBattleRandomEventView");

		// Token: 0x04019065 RID: 102501
		public static readonly EUiViewName RogueBattleSelectTokenView = new EUiViewName("RogueBattleSelectTokenView");

		// Token: 0x04019066 RID: 102502
		public static readonly EUiViewName RogueBattlePhantomSelectView = new EUiViewName("RogueBattlePhantomSelectView");

		// Token: 0x04019067 RID: 102503
		public static readonly EUiViewName RogueBattleShopView = new EUiViewName("RogueBattleShopView");

		// Token: 0x04019068 RID: 102504
		public static readonly EUiViewName RogueBattleSettleView = new EUiViewName("RogueBattleSettleView");

		// Token: 0x04019069 RID: 102505
		public static readonly EUiViewName RogueBattleTeamEditView = new EUiViewName("RogueBattleTeamEditView");

		// Token: 0x0401906A RID: 102506
		public static readonly EUiViewName RogueBattleBuyRoleView = new EUiViewName("RogueBattleBuyRoleView");

		// Token: 0x0401906B RID: 102507
		public static readonly EUiViewName RogueBattleRoleBuffSelectView = new EUiViewName("RogueBattleRoleBuffSelectView");

		// Token: 0x0401906C RID: 102508
		public static readonly EUiViewName RogueBattleRoleStarUpView = new EUiViewName("RogueBattleRoleStarUpView");

		// Token: 0x0401906D RID: 102509
		public static readonly EUiViewName RogueBattleLinkUnlockView = new EUiViewName("RogueBattleLinkUnlockView");

		// Token: 0x0401906E RID: 102510
		public static readonly EUiViewName RogueBattleEnvironmentBuffView = new EUiViewName("RogueBattleEnvironmentBuffView");

		// Token: 0x0401906F RID: 102511
		public static readonly EUiViewName RogueAttributeDetailView = new EUiViewName("RogueAttributeDetailView");

		// Token: 0x04019070 RID: 102512
		public static readonly EUiViewName WeeklyRogueAttributeDetailView = new EUiViewName("WeeklyRogueAttributeDetailView");

		// Token: 0x04019071 RID: 102513
		public static readonly EUiViewName WhiteCatWarningTips = new EUiViewName("WhiteCatWarningTips");

		// Token: 0x04019072 RID: 102514
		public static readonly EUiViewName BlackCatWarningTips = new EUiViewName("BlackCatWarningTips");

		// Token: 0x04019073 RID: 102515
		public static readonly EUiViewName DreamLinkDungeonView = new EUiViewName("DreamLinkDungeonView");

		// Token: 0x04019074 RID: 102516
		public static readonly EUiViewName DreamLinkMainView = new EUiViewName("DreamLinkMainView");

		// Token: 0x04019075 RID: 102517
		public static readonly EUiViewName DreamLinkWhiteCatView = new EUiViewName("DreamLinkWhiteCatView");

		// Token: 0x04019076 RID: 102518
		public static readonly EUiViewName DreamLinkWorldRunView = new EUiViewName("DreamLinkWorldRunView");

		// Token: 0x04019077 RID: 102519
		public static readonly EUiViewName DreamLinkRewardViewEnergy = new EUiViewName("DreamLinkRewardViewEnergy");

		// Token: 0x04019078 RID: 102520
		public static readonly EUiViewName DreamLinkRewardViewLimit = new EUiViewName("DreamLinkRewardViewLimit");

		// Token: 0x04019079 RID: 102521
		public static readonly EUiViewName LordGymUnlockTipView = new EUiViewName("LordGymUnlockTipView");

		// Token: 0x0401907A RID: 102522
		public static readonly EUiViewName LordChallengeResultView = new EUiViewName("LordChallengeResultView");

		// Token: 0x0401907B RID: 102523
		public static readonly EUiViewName ItemDeliverView = new EUiViewName("ItemDeliverView");

		// Token: 0x0401907C RID: 102524
		public static readonly EUiViewName NewMissionTips = new EUiViewName("NewMissionTips");

		// Token: 0x0401907D RID: 102525
		public static readonly EUiViewName QuestLockPreview = new EUiViewName("QuestLockPreview");

		// Token: 0x0401907E RID: 102526
		public static readonly EUiViewName CsQuestLockPreview = new EUiViewName("CsQuestLockPreview");

		// Token: 0x0401907F RID: 102527
		public static readonly EUiViewName SilentAreaRewardPreviewPopView = new EUiViewName("SilentAreaRewardPreviewPopView");

		// Token: 0x04019080 RID: 102528
		public static readonly EUiViewName RoguelikeBlackFlowerPreviewView = new EUiViewName("RoguelikeBlackFlowerPreviewView");

		// Token: 0x04019081 RID: 102529
		public static readonly EUiViewName RepeatKeyTipsView = new EUiViewName("RepeatKeyTipsView");

		// Token: 0x04019082 RID: 102530
		public static readonly EUiViewName RemainStarWarningTips = new EUiViewName("RemainStarWarningTips");

		// Token: 0x04019083 RID: 102531
		public static readonly EUiViewName MemoryFragmentMainView = new EUiViewName("MemoryFragmentMainView");

		// Token: 0x04019084 RID: 102532
		public static readonly EUiViewName ObtainFragmentView = new EUiViewName("ObtainFragmentView");

		// Token: 0x04019085 RID: 102533
		public static readonly EUiViewName MemoryDetailView = new EUiViewName("MemoryDetailView");

		// Token: 0x04019086 RID: 102534
		public static readonly EUiViewName FragmentedCluesView = new EUiViewName("FragmentedCluesView");

		// Token: 0x04019087 RID: 102535
		public static readonly EUiViewName RoguelikeUnlockTips = new EUiViewName("RoguelikeUnlockTips");

		// Token: 0x04019088 RID: 102536
		public static readonly EUiViewName ChangeActionTipsView = new EUiViewName("ChangeActionTipsView");

		// Token: 0x04019089 RID: 102537
		public static readonly EUiViewName ChangeModeTipsView = new EUiViewName("ChangeModeTipsView");

		// Token: 0x0401908A RID: 102538
		public static readonly EUiViewName VisionRecoveryResultView = new EUiViewName("VisionRecoveryResultView");

		// Token: 0x0401908B RID: 102539
		public static readonly EUiViewName VisionRecoveryBatchResultView = new EUiViewName("VisionRecoveryBatchResultView");

		// Token: 0x0401908C RID: 102540
		public static readonly EUiViewName VisionRefineAttributeSelectView = new EUiViewName("VisionRefineAttributeSelectView");

		// Token: 0x0401908D RID: 102541
		public static readonly EUiViewName VisionRefineResultView = new EUiViewName("VisionRefineResultView");

		// Token: 0x0401908E RID: 102542
		public static readonly EUiViewName VisionRefineSubResultView = new EUiViewName("VisionRefineSubResultView");

		// Token: 0x0401908F RID: 102543
		public static readonly EUiViewName RoleTagDetailView = new EUiViewName("RoleTagDetailView");

		// Token: 0x04019090 RID: 102544
		public static readonly EUiViewName RoguelikeInstanceEntrySelectView = new EUiViewName("RoguelikeInstanceEntrySelectView");

		// Token: 0x04019091 RID: 102545
		public static readonly EUiViewName RoguelikeSpecialDetailView = new EUiViewName("RoguelikeSpecialDetailView");

		// Token: 0x04019092 RID: 102546
		public static readonly EUiViewName RoguelikeSelectSpecialView = new EUiViewName("RoguelikeSelectSpecialView");

		// Token: 0x04019093 RID: 102547
		public static readonly EUiViewName RoguelikeEntranceView = new EUiViewName("RoguelikeEntranceView");

		// Token: 0x04019094 RID: 102548
		public static readonly EUiViewName RoguelikeRoleAffixDetailView = new EUiViewName("RoguelikeRoleAffixDetailView");

		// Token: 0x04019095 RID: 102549
		public static readonly EUiViewName RoguelikePhantomNewUnlockView = new EUiViewName("RoguelikePhantomNewUnlockView");

		// Token: 0x04019096 RID: 102550
		public static readonly EUiViewName RoguelikeAchieveView = new EUiViewName("RoguelikeAchieveView");

		// Token: 0x04019097 RID: 102551
		public static readonly EUiViewName CollectItemView = new EUiViewName("CollectItemView");

		// Token: 0x04019098 RID: 102552
		public static readonly EUiViewName DifficultUnlockTipView = new EUiViewName("DifficultUnlockTipView");

		// Token: 0x04019099 RID: 102553
		public static readonly EUiViewName LongShanView = new EUiViewName("LongShanView");

		// Token: 0x0401909A RID: 102554
		public static readonly EUiViewName ExploreMissionView = new EUiViewName("ExploreMissionView");

		// Token: 0x0401909B RID: 102555
		public static readonly EUiViewName RoleBreakPreviewView = new EUiViewName("RoleBreakPreviewView");

		// Token: 0x0401909C RID: 102556
		public static readonly EUiViewName TowerDefenseWaveTipView = new EUiViewName("TowerDefenceWaveTipView");

		// Token: 0x0401909D RID: 102557
		public static readonly EUiViewName TowerDefenseStrengthenTipsView = new EUiViewName("TowerDefenseStrengthenTipsView");

		// Token: 0x0401909E RID: 102558
		public static readonly EUiViewName TowerDefenseInBattleTips = new EUiViewName("TowerDefenceInBattleTips");

		// Token: 0x0401909F RID: 102559
		public static readonly EUiViewName TuningStandView = new EUiViewName("TuningStandView");

		// Token: 0x040190A0 RID: 102560
		public static readonly EUiViewName MoonChasingMainView = new EUiViewName("MoonChasingMainView");

		// Token: 0x040190A1 RID: 102561
		public static readonly EUiViewName MoonChasingUnlockRoleView = new EUiViewName("MoonChasingUnlockRoleView");

		// Token: 0x040190A2 RID: 102562
		public static readonly EUiViewName BuildingTipsInfoView = new EUiViewName("BuildingTipsInfoView");

		// Token: 0x040190A3 RID: 102563
		public static readonly EUiViewName BuildingLevelUpView = new EUiViewName("BuildingLevelUpView");

		// Token: 0x040190A4 RID: 102564
		public static readonly EUiViewName ScratchTicketMainView = new EUiViewName("ScratchTicketMainView");

		// Token: 0x040190A5 RID: 102565
		public static readonly EUiViewName BusinessMainView = new EUiViewName("BusinessMainView");

		// Token: 0x040190A6 RID: 102566
		public static readonly EUiViewName BusinessTipsTravelView = new EUiViewName("BusinessTipsTravelView");

		// Token: 0x040190A7 RID: 102567
		public static readonly EUiViewName BusinessTipsShopView = new EUiViewName("BusinessTipsShopView");

		// Token: 0x040190A8 RID: 102568
		public static readonly EUiViewName BusinessTipsBurstView = new EUiViewName("BusinessTipsBurstView");

		// Token: 0x040190A9 RID: 102569
		public static readonly EUiViewName BusinessTipsResultView = new EUiViewName("BusinessTipsResultView");

		// Token: 0x040190AA RID: 102570
		public static readonly EUiViewName BusinessTipsFinishView = new EUiViewName("BusinessTipsFinishView");

		// Token: 0x040190AB RID: 102571
		public static readonly EUiViewName BusinessTipsPopularityUpView = new EUiViewName("BusinessTipsPopularityUpView");

		// Token: 0x040190AC RID: 102572
		public static readonly EUiViewName BusinessHelperView = new EUiViewName("BusinessHelperView");

		// Token: 0x040190AD RID: 102573
		public static readonly EUiViewName SdkMailView = new EUiViewName("SdkMailView");

		// Token: 0x040190AE RID: 102574
		public static readonly EUiViewName SdkLoginView = new EUiViewName("SdkLoginView");

		// Token: 0x040190AF RID: 102575
		public static readonly EUiViewName SdkTipsPopUpView = new EUiViewName("SdkTipsPopUpView");

		// Token: 0x040190B0 RID: 102576
		public static readonly EUiViewName SdkEnterTipsView = new EUiViewName("SdkEnterTipsView");

		// Token: 0x040190B1 RID: 102577
		public static readonly EUiViewName SdkTipsMiddlePopUpView = new EUiViewName("SdkTipsMiddlePopUpView");

		// Token: 0x040190B2 RID: 102578
		public static readonly EUiViewName SdkLoadPopUpView = new EUiViewName("SdkLoadPopUpView");

		// Token: 0x040190B3 RID: 102579
		public static readonly EUiViewName MoonChasingTaskView = new EUiViewName("MoonChasingTaskView");

		// Token: 0x040190B4 RID: 102580
		public static readonly EUiViewName RewardMainView = new EUiViewName("RewardMainView");

		// Token: 0x040190B5 RID: 102581
		public static readonly EUiViewName MoonChasingHandbookView = new EUiViewName("MoonChasingHandbookView");

		// Token: 0x040190B6 RID: 102582
		public static readonly EUiViewName MoonChasingMemoryView = new EUiViewName("MoonChasingMemoryView");

		// Token: 0x040190B7 RID: 102583
		public static readonly EUiViewName MoonChasingMemoryDetailView = new EUiViewName("MoonChasingMemoryDetailView");

		// Token: 0x040190B8 RID: 102584
		public static readonly EUiViewName RoleGrowingMainView = new EUiViewName("RoleGrowingMainView");

		// Token: 0x040190B9 RID: 102585
		public static readonly EUiViewName RoleGrowingTaskView = new EUiViewName("RoleGrowingTaskView");

		// Token: 0x040190BA RID: 102586
		public static readonly EUiViewName InstanceDungeonEntranceRootView = new EUiViewName("InstanceDungeonEntranceRootView");

		// Token: 0x040190BB RID: 102587
		public static readonly EUiViewName MowingBuffView = new EUiViewName("MowingBuffView");

		// Token: 0x040190BC RID: 102588
		public static readonly EUiViewName MowingRiskBuffTipView = new EUiViewName("MowingRiskBuffTipView");

		// Token: 0x040190BD RID: 102589
		public static readonly EUiViewName MowingBuffNewBuffTipsView = new EUiViewName("MowingBuffNewBuffTipsView");

		// Token: 0x040190BE RID: 102590
		public static readonly EUiViewName VersionPreheatQuestDetailView = new EUiViewName("VersionPreheatQuestDetailView");

		// Token: 0x040190BF RID: 102591
		public static readonly EUiViewName VersionPreheatVoteView = new EUiViewName("VersionPreheatVoteView");

		// Token: 0x040190C0 RID: 102592
		public static readonly EUiViewName CookMechanismRootView = new EUiViewName("CookMechanismRootView");

		// Token: 0x040190C1 RID: 102593
		public static readonly EUiViewName Spring25MainView = new EUiViewName("Spring25MainView");

		// Token: 0x040190C2 RID: 102594
		public static readonly EUiViewName Spring25DialogueView = new EUiViewName("Spring25DialogueView");

		// Token: 0x040190C3 RID: 102595
		public static readonly EUiViewName Spring25EnvelopeView = new EUiViewName("Spring25EnvelopeView");

		// Token: 0x040190C4 RID: 102596
		public static readonly EUiViewName Spring25LetterListView = new EUiViewName("Spring25LetterListView");

		// Token: 0x040190C5 RID: 102597
		public static readonly EUiViewName Spring25InfoView = new EUiViewName("Spring25InfoView");

		// Token: 0x040190C6 RID: 102598
		public static readonly EUiViewName MapTravelMainView = new EUiViewName("MapTravelMainView");

		// Token: 0x040190C7 RID: 102599
		public static readonly EUiViewName ActivityUnlockTipMapTravelView = new EUiViewName("ActivityUnlockTipMapTravelView");

		// Token: 0x040190C8 RID: 102600
		public static readonly EUiViewName TravelLevelTipsView = new EUiViewName("TravelLevelTipsView");

		// Token: 0x040190C9 RID: 102601
		public static readonly EUiViewName ActivityRegressStartupView = new EUiViewName("ActivityRegressStartupView");

		// Token: 0x040190CA RID: 102602
		public static readonly EUiViewName ActivityRegressNewVersionMainView = new EUiViewName("ActivityRegressNewVersionMainView");

		// Token: 0x040190CB RID: 102603
		public static readonly EUiViewName ActivityRegressMainView = new EUiViewName("ActivityRegressMainView");

		// Token: 0x040190CC RID: 102604
		public static readonly EUiViewName ActivityRegressQuestionnaireView = new EUiViewName("ActivityRegressQuestionnaireView");

		// Token: 0x040190CD RID: 102605
		public static readonly EUiViewName ActivityRegressTaskMainView = new EUiViewName("ActivityRegressTaskMainView");

		// Token: 0x040190CE RID: 102606
		public static readonly EUiViewName ActivityRecommendView = new EUiViewName("ActivityRecommendView");

		// Token: 0x040190CF RID: 102607
		public static readonly EUiViewName DigitalScreenaView = new EUiViewName("DigitalScreenA");

		// Token: 0x040190D0 RID: 102608
		public static readonly EUiViewName DigitalScreenbView = new EUiViewName("DigitalScreenB");

		// Token: 0x040190D1 RID: 102609
		public static readonly EUiViewName GachaPoolDetailView = new EUiViewName("GachaPoolDetailView");

		// Token: 0x040190D2 RID: 102610
		public static readonly EUiViewName RogueSilentAreaFloatTips = new EUiViewName("RogueSilentAreaFloatTips");

		// Token: 0x040190D3 RID: 102611
		public static readonly EUiViewName CorniceMeetingSettleView = new EUiViewName("CorniceMeetingSettleView");

		// Token: 0x040190D4 RID: 102612
		public static readonly EUiViewName MobileSwitchInputView = new EUiViewName("MobileSwitchInputView");

		// Token: 0x040190D5 RID: 102613
		public static readonly EUiViewName SdkPayProductInformationView = new EUiViewName("SdkPayProductInformationView");

		// Token: 0x040190D6 RID: 102614
		public static readonly EUiViewName DarkCoastDeliveryMainView = new EUiViewName("DarkCoastDeliveryMainView");

		// Token: 0x040190D7 RID: 102615
		public static readonly EUiViewName DarkCoastDeliveryLevelUpView = new EUiViewName("DarkCoastDeliveryLevelUpView");

		// Token: 0x040190D8 RID: 102616
		public static readonly EUiViewName BattleLinkView = new EUiViewName("BattleLinkView");

		// Token: 0x040190D9 RID: 102617
		public static readonly EUiViewName OperationPreferencesView = new EUiViewName("OperationPreferencesView");

		// Token: 0x040190DA RID: 102618
		public static readonly EUiViewName MailBindView = new EUiViewName("MailBindView");

		// Token: 0x040190DB RID: 102619
		public static readonly EUiViewName SkinRootView = new EUiViewName("SkinRootView");

		// Token: 0x040190DC RID: 102620
		public static readonly EUiViewName RecommendQualityView = new EUiViewName("RecommendQualityView");

		// Token: 0x040190DD RID: 102621
		public static readonly EUiViewName MowingTowerMainView = new EUiViewName("MowingTowerMainView");

		// Token: 0x040190DE RID: 102622
		public static readonly EUiViewName MowingTowerFloorView = new EUiViewName("MowingTowerFloorView");

		// Token: 0x040190DF RID: 102623
		public static readonly EUiViewName MowingTowerBuffView = new EUiViewName("MowingTowerBuffView");

		// Token: 0x040190E0 RID: 102624
		public static readonly EUiViewName MowingTowerRewardView = new EUiViewName("MowingTowerRewardView");

		// Token: 0x040190E1 RID: 102625
		public static readonly EUiViewName LifePointView = new EUiViewName("LifePointView");

		// Token: 0x040190E2 RID: 102626
		public static readonly EUiViewName CheckInteractionView = new EUiViewName("CheckInteractionView");

		// Token: 0x040190E3 RID: 102627
		public static readonly EUiViewName BigStuffedDollView = new EUiViewName("BigStuffedDollView");

		// Token: 0x040190E4 RID: 102628
		public static readonly EUiViewName FlySettlementView = new EUiViewName("FlySettlementView");

		// Token: 0x040190E5 RID: 102629
		public static readonly EUiViewName SkinObtainView = new EUiViewName("SkinObtainView");

		// Token: 0x040190E6 RID: 102630
		public static readonly EUiViewName FlySkinObtainView = new EUiViewName("FlySkinObtainView");

		// Token: 0x040190E7 RID: 102631
		public static readonly EUiViewName SkinShowView = new EUiViewName("SkinShowView");

		// Token: 0x040190E8 RID: 102632
		public static readonly EUiViewName SkinBuyDetailView = new EUiViewName("SkinBuyDetailView");

		// Token: 0x040190E9 RID: 102633
		public static readonly EUiViewName FlySkinBuyDetailView = new EUiViewName("FlySkinBuyDetailView");

		// Token: 0x040190EA RID: 102634
		public static readonly EUiViewName FlySkinShowView = new EUiViewName("FlySkinShowView");

		// Token: 0x040190EB RID: 102635
		public static readonly EUiViewName MotorSkinBuyDetailView = new EUiViewName("MotorSkinBuyDetailView");

		// Token: 0x040190EC RID: 102636
		public static readonly EUiViewName EquipBuffItemDetailView = new EUiViewName("EquipBuffItemDetailView");

		// Token: 0x040190ED RID: 102637
		public static readonly EUiViewName RoleOrnamentShowView = new EUiViewName("RoleOrnamentShowView");

		// Token: 0x040190EE RID: 102638
		public static readonly EUiViewName SpecialItemSummonShowView = new EUiViewName("SpecialItemSummonShowView");

		// Token: 0x040190EF RID: 102639
		public static readonly EUiViewName WeaponSkinShowView = new EUiViewName("WeaponSkinShowView");

		// Token: 0x040190F0 RID: 102640
		public static readonly EUiViewName DockyardView = new EUiViewName("DockyardView");

		// Token: 0x040190F1 RID: 102641
		public static readonly EUiViewName DockyardWareHouseView = new EUiViewName("DockyardWareHouseView");

		// Token: 0x040190F2 RID: 102642
		public static readonly EUiViewName DockyardCageView = new EUiViewName("DockyardCageView");

		// Token: 0x040190F3 RID: 102643
		public static readonly EUiViewName DockyardShopMainView = new EUiViewName("DockyardShopMainView");

		// Token: 0x040190F4 RID: 102644
		public static readonly EUiViewName DockyardInteractView = new EUiViewName("DockyardInteractView");

		// Token: 0x040190F5 RID: 102645
		public static readonly EUiViewName FishingDockView = new EUiViewName("FishingDockView");

		// Token: 0x040190F6 RID: 102646
		public static readonly EUiViewName SailingView = new EUiViewName("SailingView");

		// Token: 0x040190F7 RID: 102647
		public static readonly EUiViewName ShipSkinView = new EUiViewName("ShipSkinView");

		// Token: 0x040190F8 RID: 102648
		public static readonly EUiViewName FishingQteView = new EUiViewName("FishingQteView");

		// Token: 0x040190F9 RID: 102649
		public static readonly EUiViewName FishingQtePauseView = new EUiViewName("FishingQtePauseView");

		// Token: 0x040190FA RID: 102650
		public static readonly EUiViewName FishingQteSuccessView = new EUiViewName("FishingQteSuccessView");

		// Token: 0x040190FB RID: 102651
		public static readonly EUiViewName DockyardInteractFinishTipsView = new EUiViewName("DockyardInteractFinishTipsView");

		// Token: 0x040190FC RID: 102652
		public static readonly EUiViewName FishingTechRootView = new EUiViewName("FishingTechRootView");

		// Token: 0x040190FD RID: 102653
		public static readonly EUiViewName FishingLevelUpTips = new EUiViewName("FishingLevelUpTips");

		// Token: 0x040190FE RID: 102654
		public static readonly EUiViewName FishingWarningTips = new EUiViewName("FishingWarningTips");

		// Token: 0x040190FF RID: 102655
		public static readonly EUiViewName FishingQuestView = new EUiViewName("FishingQuestView");

		// Token: 0x04019100 RID: 102656
		public static readonly EUiViewName FishingHandBookView = new EUiViewName("FishingHandBookView");

		// Token: 0x04019101 RID: 102657
		public static readonly EUiViewName FishingTimeLimitView = new EUiViewName("FishingTimeLimitView");

		// Token: 0x04019102 RID: 102658
		public static readonly EUiViewName FishingActivityUnlockView = new EUiViewName("FishingActivityUnlockView");

		// Token: 0x04019103 RID: 102659
		public static readonly EUiViewName FishingHandBookRewardView = new EUiViewName("FishingHandBookRewardView");

		// Token: 0x04019104 RID: 102660
		public static readonly EUiViewName FishingLoadingView = new EUiViewName("FishingLoadingView");

		// Token: 0x04019105 RID: 102661
		public static readonly EUiViewName FishingTechLevelUpSuccessView = new EUiViewName("FishingTechLevelUpSuccessView");

		// Token: 0x04019106 RID: 102662
		public static readonly EUiViewName FishingLevelUpView = new EUiViewName("FishingLevelUpView");

		// Token: 0x04019107 RID: 102663
		public static readonly EUiViewName RacingBetsMainView = new EUiViewName("RacingBetsMainView");

		// Token: 0x04019108 RID: 102664
		public static readonly EUiViewName RacingBetsBettingView = new EUiViewName("RacingBetsBettingView");

		// Token: 0x04019109 RID: 102665
		public static readonly EUiViewName RacingBetsRewardView = new EUiViewName("RacingBetsRewardView");

		// Token: 0x0401910A RID: 102666
		public static readonly EUiViewName RacingBetsConfirmBoxView = new EUiViewName("RacingBetsConfirmBoxView");

		// Token: 0x0401910B RID: 102667
		public static readonly EUiViewName CyberpunkConfirmBoxView = new EUiViewName("CyberpunkConfirmBoxView");

		// Token: 0x0401910C RID: 102668
		public static readonly EUiViewName RacingBetsGamePlayView = new EUiViewName("RacingBetsGamePlayView");

		// Token: 0x0401910D RID: 102669
		public static readonly EUiViewName RacingBetsGamePlayPreviewView = new EUiViewName("RacingBetsGamePlayPreviewView");

		// Token: 0x0401910E RID: 102670
		public static readonly EUiViewName RacingBetsHistoryView = new EUiViewName("RacingBetsHistoryView");

		// Token: 0x0401910F RID: 102671
		public static readonly EUiViewName RacingBetsRankView = new EUiViewName("RacingBetsRankView");

		// Token: 0x04019110 RID: 102672
		public static readonly EUiViewName RacingBetsMatchView = new EUiViewName("RacingBetsMatchView");

		// Token: 0x04019111 RID: 102673
		public static readonly EUiViewName RacingBetsSuccessTip = new EUiViewName("RacingBetsSuccessTip");

		// Token: 0x04019112 RID: 102674
		public static readonly EUiViewName RacingBetsFailTip = new EUiViewName("RacingBetsFailTip");

		// Token: 0x04019113 RID: 102675
		public static readonly EUiViewName RacingBetsActivityRewardView = new EUiViewName("RacingBetsActivityRewardView");

		// Token: 0x04019114 RID: 102676
		public static readonly EUiViewName RacingBetsDungeonBeginTip = new EUiViewName("RacingBetsDungeonBeginTip");

		// Token: 0x04019115 RID: 102677
		public static readonly EUiViewName RacingBetsDangoSkillView = new EUiViewName("RacingBetsDangoSkillView");

		// Token: 0x04019116 RID: 102678
		public static readonly EUiViewName RacingBetsDangoTerrainView = new EUiViewName("RacingBetsDangoTerrainView");

		// Token: 0x04019117 RID: 102679
		public static readonly EUiViewName RacingBetsDangoSkillTip = new EUiViewName("RacingBetsDangoSkillTip");

		// Token: 0x04019118 RID: 102680
		public static readonly EUiViewName RacingBetsTerrainTip = new EUiViewName("RacingBetsTerrainTip");

		// Token: 0x04019119 RID: 102681
		public static readonly EUiViewName RacingBetsSpecialTip = new EUiViewName("RacingBetsSpecialTip");

		// Token: 0x0401911A RID: 102682
		public static readonly EUiViewName RacingBetsDangoFrameTipView = new EUiViewName("RacingBetsDangoFrameTipView");

		// Token: 0x0401911B RID: 102683
		public static readonly EUiViewName RacingBetsDungeonResultView = new EUiViewName("RacingBetsDungeonResultView");

		// Token: 0x0401911C RID: 102684
		public static readonly EUiViewName RacingBetsDangoActivityOpenTips = new EUiViewName("RacingBetsDangoActivityOpenTips");

		// Token: 0x0401911D RID: 102685
		public static readonly EUiViewName SkipMainQuestWindowView = new EUiViewName("SkipMainQuestWindowView");

		// Token: 0x0401911E RID: 102686
		public static readonly EUiViewName DirectTrainProView = new EUiViewName("DirectTrainProView");

		// Token: 0x0401911F RID: 102687
		public static readonly EUiViewName DirectTrainDetailView = new EUiViewName("DirectTrainDetailView");

		// Token: 0x04019120 RID: 102688
		public static readonly EUiViewName ShipTogetherView = new EUiViewName("ShipTogetherView");

		// Token: 0x04019121 RID: 102689
		public static readonly EUiViewName ChapterA = new EUiViewName("ChapterA");

		// Token: 0x04019122 RID: 102690
		public static readonly EUiViewName PlotChapterA = new EUiViewName("PlotChapterA");

		// Token: 0x04019123 RID: 102691
		public static readonly EUiViewName SolarSpeedRewardView = new EUiViewName("SolarSpeedRewardView");

		// Token: 0x04019124 RID: 102692
		public static readonly EUiViewName SolarSpeedResultView = new EUiViewName("SolarSpeedResultView");

		// Token: 0x04019125 RID: 102693
		public static readonly EUiViewName HiddenBossWindow = new EUiViewName("HiddenBossWindow");

		// Token: 0x04019126 RID: 102694
		public static readonly EUiViewName ComposeCarryOnView = new EUiViewName("ComposeCarryOnView");

		// Token: 0x04019127 RID: 102695
		public static readonly EUiViewName LiuLiDaoLingView = new EUiViewName("LiuLiDaoLingView");

		// Token: 0x04019128 RID: 102696
		public static readonly EUiViewName GuYingXiongKaiView = new EUiViewName("GuYingXiongKaiView");

		// Token: 0x04019129 RID: 102697
		public static readonly EUiViewName ShipTowerView = new EUiViewName("ShipTowerView");

		// Token: 0x0401912A RID: 102698
		public static readonly EUiViewName ShipTowerBuffView = new EUiViewName("ShipTowerBuffView");

		// Token: 0x0401912B RID: 102699
		public static readonly EUiViewName ShipTowerFightFinishView = new EUiViewName("ShipTowerFightFinishView");

		// Token: 0x0401912C RID: 102700
		public static readonly EUiViewName ShipTowerDescView = new EUiViewName("ShipTowerDescView");

		// Token: 0x0401912D RID: 102701
		public static readonly EUiViewName ShipTowerResetView = new EUiViewName("ShipTowerResetView");

		// Token: 0x0401912E RID: 102702
		public static readonly EUiViewName ShipTowerGetBuffView = new EUiViewName("ShipTowerGetBuffView");

		// Token: 0x0401912F RID: 102703
		public static readonly EUiViewName ShipTowerCoverView = new EUiViewName("ShipTowerCoverView");

		// Token: 0x04019130 RID: 102704
		public static readonly EUiViewName ShipTowerRewardView = new EUiViewName("ShipTowerRewardView");

		// Token: 0x04019131 RID: 102705
		public static readonly EUiViewName ShipTowerPassBuffShowView = new EUiViewName("ShipTowerPassBuffShowView");

		// Token: 0x04019132 RID: 102706
		public static readonly EUiViewName ShipTowerTeamRecommendView = new EUiViewName("ShipTowerTeamRecommendView");

		// Token: 0x04019133 RID: 102707
		public static readonly EUiViewName ShipTowerMonsterDescView = new EUiViewName("ShipTowerMonsterDescView");

		// Token: 0x04019134 RID: 102708
		public static readonly EUiViewName ShipTowerRecordView = new EUiViewName("ShipTowerRecordView");

		// Token: 0x04019135 RID: 102709
		public static readonly EUiViewName ShipTowerReviewView = new EUiViewName("ShipTowerReviewView");

		// Token: 0x04019136 RID: 102710
		public static readonly EUiViewName ShipTowerCountDownView = new EUiViewName("ShipTowerCountDownView");

		// Token: 0x04019137 RID: 102711
		public static readonly EUiViewName ShipTowerShowBuffView = new EUiViewName("ShipTowerShowBuffView");

		// Token: 0x04019138 RID: 102712
		public static readonly EUiViewName ShipTowerLoadingView = new EUiViewName("ShipTowerLoadingView");

		// Token: 0x04019139 RID: 102713
		public static readonly EUiViewName ShipTowerWelcomeView = new EUiViewName("ShipTowerWelcomeView");

		// Token: 0x0401913A RID: 102714
		public static readonly EUiViewName ShipTowerLevelInfoView = new EUiViewName("ShipTowerLevelInfoView");

		// Token: 0x0401913B RID: 102715
		public static readonly EUiViewName WeeklyRogueEnvironmentTips = new EUiViewName("WeeklyRogueEnvironmentTips");

		// Token: 0x0401913C RID: 102716
		public static readonly EUiViewName NetworkDetectionView = new EUiViewName("NetworkDetectionView");

		// Token: 0x0401913D RID: 102717
		public static readonly EUiViewName NetworkDetectionSelectServerView = new EUiViewName("NetworkDetectionSelectServerView");

		// Token: 0x0401913E RID: 102718
		public static readonly EUiViewName DangoAbyssInsSelectView = new EUiViewName("DangoAbyssInsSelectView");

		// Token: 0x0401913F RID: 102719
		public static readonly EUiViewName DangoAbyssEntranceView = new EUiViewName("DangoAbyssEntranceView");

		// Token: 0x04019140 RID: 102720
		public static readonly EUiViewName DangoAbyssRootView = new EUiViewName("DangoAbyssRootView");

		// Token: 0x04019141 RID: 102721
		public static readonly EUiViewName DangoAbyssLevelUpView = new EUiViewName("DangoAbyssLevelUpView");

		// Token: 0x04019142 RID: 102722
		public static readonly EUiViewName DangoAbyssPluginEquipView = new EUiViewName("DangoAbyssPluginEquipView");

		// Token: 0x04019143 RID: 102723
		public static readonly EUiViewName DangoAbyssSelectDangoView = new EUiViewName("DangoAbyssSelectDangoView");

		// Token: 0x04019144 RID: 102724
		public static readonly EUiViewName DangoAbyssPluginRecoveryView = new EUiViewName("DangoAbyssPluginRecoveryView");

		// Token: 0x04019145 RID: 102725
		public static readonly EUiViewName DangoAbyssPluginRecoveryResultView = new EUiViewName("DangoAbyssPluginRecoveryResultView");

		// Token: 0x04019146 RID: 102726
		public static readonly EUiViewName DangoAbyssRankView = new EUiViewName("DangoAbyssRankView");

		// Token: 0x04019147 RID: 102727
		public static readonly EUiViewName DangoAbyssWorldView = new EUiViewName("DangoAbyssWorldView");

		// Token: 0x04019148 RID: 102728
		public static readonly EUiViewName DangoAbyssWorldLoadingView = new EUiViewName("DangoAbyssWorldLoadingView");

		// Token: 0x04019149 RID: 102729
		public static readonly EUiViewName DangoAbyssInfoView = new EUiViewName("DangoAbyssInfoView");

		// Token: 0x0401914A RID: 102730
		public static readonly EUiViewName DangoAbyssTimeLimitRewardView = new EUiViewName("DangoAbyssTimeLimitRewardView");

		// Token: 0x0401914B RID: 102731
		public static readonly EUiViewName DangoAbyssCommonRewardView = new EUiViewName("DangoAbyssCommonRewardView");

		// Token: 0x0401914C RID: 102732
		public static readonly EUiViewName DangoAbyssTimeLimitRewardActivityView = new EUiViewName("DangoAbyssTimeLimitRewardActivityView");

		// Token: 0x0401914D RID: 102733
		public static readonly EUiViewName DangoAbyssCommonRewardActivityView = new EUiViewName("DangoAbyssCommonRewardActivityView");

		// Token: 0x0401914E RID: 102734
		public static readonly EUiViewName DangoAbyssShopView = new EUiViewName("DangoAbyssShopView");

		// Token: 0x0401914F RID: 102735
		public static readonly EUiViewName DangoAbyssGetDangoView = new EUiViewName("DangoAbyssGetDangoView");

		// Token: 0x04019150 RID: 102736
		public static readonly EUiViewName DangoAbyssActivityOpen = new EUiViewName("DangoAbyssActivityOpen");

		// Token: 0x04019151 RID: 102737
		public static readonly EUiViewName DangoAbyssNpcTips = new EUiViewName("DangoAbyssNpcTips");

		// Token: 0x04019152 RID: 102738
		public static readonly EUiViewName DangoAbyssAttributeDetailView = new EUiViewName("DangoAbyssAttributeDetailView");

		// Token: 0x04019153 RID: 102739
		public static readonly EUiViewName GravityFlipView = new EUiViewName("GravityFlipView");

		// Token: 0x04019154 RID: 102740
		public static readonly EUiViewName BabelTowerMainView = new EUiViewName("BabelTowerMainView");

		// Token: 0x04019155 RID: 102741
		public static readonly EUiViewName BabelTowerBuffSelectView = new EUiViewName("BabelTowerBuffSelectView");

		// Token: 0x04019156 RID: 102742
		public static readonly EUiViewName BabelTowerNormalLevelChoseView = new EUiViewName("BabelTowerNormalLevelChoseView");

		// Token: 0x04019157 RID: 102743
		public static readonly EUiViewName BabelTowerHardLevelChoseView = new EUiViewName("BabelTowerHardLevelChoseView");

		// Token: 0x04019158 RID: 102744
		public static readonly EUiViewName BabelTowerDeTermSelectView = new EUiViewName("BabelTowerDeTermSelectView");

		// Token: 0x04019159 RID: 102745
		public static readonly EUiViewName BabelTowerDeTermSelectViewNew = new EUiViewName("BabelTowerDeTermSelectViewNew");

		// Token: 0x0401915A RID: 102746
		public static readonly EUiViewName BabelTowerLevelInfoView = new EUiViewName("BabelTowerLevelInfoView");

		// Token: 0x0401915B RID: 102747
		public static readonly EUiViewName BabelTowerQuestView = new EUiViewName("BabelTowerQuestView");

		// Token: 0x0401915C RID: 102748
		public static readonly EUiViewName TowerDefenseRankView = new EUiViewName("TowerDefenseRankView");

		// Token: 0x0401915D RID: 102749
		public static readonly EUiViewName TowerDefenseRankViewV2 = new EUiViewName("TowerDefenseRankViewV2");

		// Token: 0x0401915E RID: 102750
		public static readonly EUiViewName TowerDefenseRewardView = new EUiViewName("TowerDefenseRewardView");

		// Token: 0x0401915F RID: 102751
		public static readonly EUiViewName TowerDefenseSettleView = new EUiViewName("TowerDefenseSettleView");

		// Token: 0x04019160 RID: 102752
		public static readonly EUiViewName TowerDefensePopupView = new EUiViewName("TowerDefensePopupView");

		// Token: 0x04019161 RID: 102753
		public static readonly EUiViewName BabelTowerItemInfoView = new EUiViewName("BabelTowerItemInfoView");

		// Token: 0x04019162 RID: 102754
		public static readonly EUiViewName BabelTowerResetView = new EUiViewName("BabelTowerResetView");

		// Token: 0x04019163 RID: 102755
		public static readonly EUiViewName ActivityUnlockTipAvignonView = new EUiViewName("ActivityUnlockTipAvignonView");

		// Token: 0x04019164 RID: 102756
		public static readonly EUiViewName AvignonActivityMainView = new EUiViewName("AvignonActivityMainView");

		// Token: 0x04019165 RID: 102757
		public static readonly EUiViewName AvignonStageTaskView = new EUiViewName("AvignonStageTaskView");

		// Token: 0x04019166 RID: 102758
		public static readonly EUiViewName PlayerTitleInfoTip = new EUiViewName("PlayerTitleInfoTip");

		// Token: 0x04019167 RID: 102759
		public static readonly EUiViewName BabelTowerBuffView = new EUiViewName("BabelTowerBuffView");

		// Token: 0x04019168 RID: 102760
		public static readonly EUiViewName BabelTowerSettlementView = new EUiViewName("BabelTowerSettlementView");

		// Token: 0x04019169 RID: 102761
		public static readonly EUiViewName BabelTowerReviveView = new EUiViewName("BabelTowerReviveView");

		// Token: 0x0401916A RID: 102762
		public static readonly EUiViewName BabelTowerNewLevelTipsView = new EUiViewName("BabelTowerNewLevelTipsView");

		// Token: 0x0401916B RID: 102763
		public static readonly EUiViewName BabelTowerHardLevelInfoView = new EUiViewName("BabelTowerHardLevelInfoView");

		// Token: 0x0401916C RID: 102764
		public static readonly EUiViewName BabelTowerHardLevelInfoViewNew = new EUiViewName("BabelTowerHardLevelInfoViewNew");

		// Token: 0x0401916D RID: 102765
		public static readonly EUiViewName BabelTowerRankView = new EUiViewName("BabelTowerRankView");

		// Token: 0x0401916E RID: 102766
		public static readonly EUiViewName BasicGraphicSettingView = new EUiViewName("BasicGraphicSettingView");

		// Token: 0x0401916F RID: 102767
		public static readonly EUiViewName RogueBattleRoleAffixDetailView = new EUiViewName("RogueBattleRoleAffixDetailView");

		// Token: 0x04019170 RID: 102768
		public static readonly EUiViewName RogueBattleSummary = new EUiViewName("RogueBattleSummary");

		// Token: 0x04019171 RID: 102769
		public static readonly EUiViewName RogueBattleMapSummaryView = new EUiViewName("RogueBattleMapSummaryView");

		// Token: 0x04019172 RID: 102770
		public static readonly EUiViewName RogueTokenIllustratedView = new EUiViewName("RogueTokenIllustratedView");

		// Token: 0x04019173 RID: 102771
		public static readonly EUiViewName RogueEventIllustratedView = new EUiViewName("RogueEventIllustratedView");

		// Token: 0x04019174 RID: 102772
		public static readonly EUiViewName RogueIllustratedView = new EUiViewName("RogueIllustratedView");

		// Token: 0x04019175 RID: 102773
		public static readonly EUiViewName RogueTaskView = new EUiViewName("RogueTaskView");

		// Token: 0x04019176 RID: 102774
		public static readonly EUiViewName RogueDungeonEntryView = new EUiViewName("RogueDungeonEntryView");

		// Token: 0x04019177 RID: 102775
		public static readonly EUiViewName RogueSeasonEntranceView = new EUiViewName("RogueSeasonEntranceView");

		// Token: 0x04019178 RID: 102776
		public static readonly EUiViewName RogueResSkillView = new EUiViewName("RogueResSkillView");

		// Token: 0x04019179 RID: 102777
		public static readonly EUiViewName RogueResSkillOverView = new EUiViewName("RogueResSkillOverView");

		// Token: 0x0401917A RID: 102778
		public static readonly EUiViewName RogueResEndingView = new EUiViewName("RogueResEndingView");

		// Token: 0x0401917B RID: 102779
		public static readonly EUiViewName RogueResEndingSubView = new EUiViewName("RogueResEndingSubView");

		// Token: 0x0401917C RID: 102780
		public static readonly EUiViewName RogueResTrialView = new EUiViewName("RogueResTrialView");

		// Token: 0x0401917D RID: 102781
		public static readonly EUiViewName RogueResOpenTips = new EUiViewName("RogueResOpenTips");

		// Token: 0x0401917E RID: 102782
		public static readonly EUiViewName RogueBattleTeamRoleSelectView = new EUiViewName("RogueBattleTeamRoleSelectView");

		// Token: 0x0401917F RID: 102783
		public static readonly EUiViewName CiacconaGalView = new EUiViewName("CiacconaGalView");

		// Token: 0x04019180 RID: 102784
		public static readonly EUiViewName CiacconaGalChapterView = new EUiViewName("CiacconaGalChapterView");

		// Token: 0x04019181 RID: 102785
		public static readonly EUiViewName CiacconaGalEndingView = new EUiViewName("CiacconaGalEndingView");

		// Token: 0x04019182 RID: 102786
		public static readonly EUiViewName CiacconaGalChapterEntryView = new EUiViewName("CiacconaGalChapterEntryView");

		// Token: 0x04019183 RID: 102787
		public static readonly EUiViewName CiacconaActivityRewardView = new EUiViewName("CiacconaActivityRewardView");

		// Token: 0x04019184 RID: 102788
		public static readonly EUiViewName CiacconaGalEndingDetailView = new EUiViewName("CiacconaGalEndingDetailView");

		// Token: 0x04019185 RID: 102789
		public static readonly EUiViewName PhantomArenaBattleView = new EUiViewName("PhantomArenaBattleView");

		// Token: 0x04019186 RID: 102790
		public static readonly EUiViewName DeckBuilderCardInfoView = new EUiViewName("DeckBuilderCardInfoView");

		// Token: 0x04019187 RID: 102791
		public static readonly EUiViewName PhantomArenaChangeCardView = new EUiViewName("PhantomArenaChangeCardView");

		// Token: 0x04019188 RID: 102792
		public static readonly EUiViewName PhantomArenaBattleLoading = new EUiViewName("PhantomArenaBattleLoading");

		// Token: 0x04019189 RID: 102793
		public static readonly EUiViewName PhantomArenaBattleVsView = new EUiViewName("PhantomArenaBattleVsView");

		// Token: 0x0401918A RID: 102794
		public static readonly EUiViewName PhantomArenaBattleDetailsView = new EUiViewName("PhantomArenaBattleDetailsView");

		// Token: 0x0401918B RID: 102795
		public static readonly EUiViewName PhantomArenaCoreCardView = new EUiViewName("PhantomArenaCoreCardView");

		// Token: 0x0401918C RID: 102796
		public static readonly EUiViewName PhantomArenaStartView = new EUiViewName("PhantomArenaStartView");

		// Token: 0x0401918D RID: 102797
		public static readonly EUiViewName PhantomArenaMainView = new EUiViewName("PhantomArenaMainView");

		// Token: 0x0401918E RID: 102798
		public static readonly EUiViewName DeckBuilderCardDeleteView = new EUiViewName("DeckBuilderCardDeleteView");

		// Token: 0x0401918F RID: 102799
		public static readonly EUiViewName PhantomArenaCardRewardView = new EUiViewName("PhantomArenaCardRewardView");

		// Token: 0x04019190 RID: 102800
		public static readonly EUiViewName PhantomArenaCardsRewardView = new EUiViewName("PhantomArenaCardsRewardView");

		// Token: 0x04019191 RID: 102801
		public static readonly EUiViewName PhantomArenaCardOutlookRewardView = new EUiViewName("PhantomArenaCardOutlookRewardView");

		// Token: 0x04019192 RID: 102802
		public static readonly EUiViewName PhantomArenaEntranceView = new EUiViewName("PhantomArenaEntranceView");

		// Token: 0x04019193 RID: 102803
		public static readonly EUiViewName PhantomArenaMatchView = new EUiViewName("PhantomArenaMatchView");

		// Token: 0x04019194 RID: 102804
		public static readonly EUiViewName CollectCardDetailView = new EUiViewName("CollectCardDetailView");

		// Token: 0x04019195 RID: 102805
		public static readonly EUiViewName PhantomArenaCollectView = new EUiViewName("PhantomArenaCollectView");

		// Token: 0x04019196 RID: 102806
		public static readonly EUiViewName PhantomArenaCollectViewNew = new EUiViewName("PhantomArenaCollectViewNew");

		// Token: 0x04019197 RID: 102807
		public static readonly EUiViewName PhantomArenaBattleResultView = new EUiViewName("PhantomArenaBattleResultView");

		// Token: 0x04019198 RID: 102808
		public static readonly EUiViewName PhantomArenaBattleResultViewNew = new EUiViewName("PhantomArenaBattleResultViewNew");

		// Token: 0x04019199 RID: 102809
		public static readonly EUiViewName PhantomArenaMasterInfoView = new EUiViewName("PhantomArenaMasterInfoView");

		// Token: 0x0401919A RID: 102810
		public static readonly EUiViewName PhantomArenaRoleCutInView = new EUiViewName("PhantomArenaRoleCutInView");

		// Token: 0x0401919B RID: 102811
		public static readonly EUiViewName PhantomArenaEntranceShopMainView = new EUiViewName("PhantomArenaEntranceShopMainView");

		// Token: 0x0401919C RID: 102812
		public static readonly EUiViewName DeckRenameInputView = new EUiViewName("DeckRenameInputView");

		// Token: 0x0401919D RID: 102813
		public static readonly EUiViewName DeckBuilderQuicklyBuildView = new EUiViewName("DeckBuilderQuicklyBuildView");

		// Token: 0x0401919E RID: 102814
		public static readonly EUiViewName PhantomArenaDeckDetailView = new EUiViewName("PhantomArenaDeckDetailView");

		// Token: 0x0401919F RID: 102815
		public static readonly EUiViewName PhantomArenaDeckDetailViewNew = new EUiViewName("PhantomArenaDeckDetailViewNew");

		// Token: 0x040191A0 RID: 102816
		public static readonly EUiViewName PhantomArenaCardBattleLoadingView = new EUiViewName("PhantomArenaCardBattleLoadingView");

		// Token: 0x040191A1 RID: 102817
		public static readonly EUiViewName PhantomArenaBattleFloatTips = new EUiViewName("PhantomArenaBattleFloatTips");

		// Token: 0x040191A2 RID: 102818
		public static readonly EUiViewName PhantomArenaBadgeUnlockView = new EUiViewName("PhantomArenaBadgeUnlockView");

		// Token: 0x040191A3 RID: 102819
		public static readonly EUiViewName PhantomArenaRoleUnlockView = new EUiViewName("PhantomArenaRoleUnlockView");

		// Token: 0x040191A4 RID: 102820
		public static readonly EUiViewName PhantomArenaBattleDamageView = new EUiViewName("PhantomArenaBattleDamageView");

		// Token: 0x040191A5 RID: 102821
		public static readonly EUiViewName PhantomArenaActivityOpen = new EUiViewName("PhantomArenaActivityOpen");

		// Token: 0x040191A6 RID: 102822
		public static readonly EUiViewName PhantomArenaHelpView = new EUiViewName("PhantomArenaHelpView");

		// Token: 0x040191A7 RID: 102823
		public static readonly EUiViewName PhantomArenaRewardView = new EUiViewName("PhantomArenaRewardView");

		// Token: 0x040191A8 RID: 102824
		public static readonly EUiViewName DangoMonopolyMainView = new EUiViewName("DangoMonopolyMainView");

		// Token: 0x040191A9 RID: 102825
		public static readonly EUiViewName DangoMonopolyTaskView = new EUiViewName("DangoMonopolyTaskView");

		// Token: 0x040191AA RID: 102826
		public static readonly EUiViewName DangoMonopolyRoundShowView = new EUiViewName("DangoMonopolyRoundShowView");

		// Token: 0x040191AB RID: 102827
		public static readonly EUiViewName DangoMonopolyResultView = new EUiViewName("DangoMonopolyResultView");

		// Token: 0x040191AC RID: 102828
		public static readonly EUiViewName DangoMonopolyBuffActiveView = new EUiViewName("DangoMonopolyBuffActiveView");

		// Token: 0x040191AD RID: 102829
		public static readonly EUiViewName DangoMonopolyRoundBuffShowView = new EUiViewName("DangoMonopolyRoundBuffShowView");

		// Token: 0x040191AE RID: 102830
		public static readonly EUiViewName DangoMonopolyTipsView = new EUiViewName("DangoMonopolyTipsView");

		// Token: 0x040191AF RID: 102831
		public static readonly EUiViewName DangoMonopolyRollDiceView = new EUiViewName("DangoMonopolyRollDiceView");

		// Token: 0x040191B0 RID: 102832
		public static readonly EUiViewName DangoMonopolyTransitionView = new EUiViewName("DangoMonopolyTransitionView");

		// Token: 0x040191B1 RID: 102833
		public static readonly EUiViewName MoraleBuffView = new EUiViewName("MoraleBuffView");

		// Token: 0x040191B2 RID: 102834
		public static readonly EUiViewName MoraleRewardView = new EUiViewName("MoraleRewardView");

		// Token: 0x040191B3 RID: 102835
		public static readonly EUiViewName MoraleAreaInfoView = new EUiViewName("MoraleAreaInfoView");

		// Token: 0x040191B4 RID: 102836
		public static readonly EUiViewName MoraleAreaSumView = new EUiViewName("MoraleAreaSumView");

		// Token: 0x040191B5 RID: 102837
		public static readonly EUiViewName MoraleBuffAddTips = new EUiViewName("MoraleBuffAddTips");

		// Token: 0x040191B6 RID: 102838
		public static readonly EUiViewName MoraleBuffActiveTips = new EUiViewName("MoraleBuffActiveTips");

		// Token: 0x040191B7 RID: 102839
		public static readonly EUiViewName MoraleAreaProgressTips = new EUiViewName("MoraleAreaProgressTips");

		// Token: 0x040191B8 RID: 102840
		public static readonly EUiViewName MoralePrompt = new EUiViewName("MoralePrompt");

		// Token: 0x040191B9 RID: 102841
		public static readonly EUiViewName MoraleAreaBuffActiveTips = new EUiViewName("MoraleAreaBuffActiveTips");

		// Token: 0x040191BA RID: 102842
		public static readonly EUiViewName TrapDefenseMainView = new EUiViewName("TrapDefenseMainView");

		// Token: 0x040191BB RID: 102843
		public static readonly EUiViewName TrapDefenseBdSumView = new EUiViewName("TrapDefenseBdSumView");

		// Token: 0x040191BC RID: 102844
		public static readonly EUiViewName TrapDefenseBdQualityView = new EUiViewName("TrapDefenseBdQualityView");

		// Token: 0x040191BD RID: 102845
		public static readonly EUiViewName TrapDefenseBdBuffSelectView = new EUiViewName("TrapDefenseBdBuffSelectView");

		// Token: 0x040191BE RID: 102846
		public static readonly EUiViewName TrapDefenseBdBuffGetView = new EUiViewName("TrapDefenseBdBuffGetView");

		// Token: 0x040191BF RID: 102847
		public static readonly EUiViewName TrapDefenseBdBuffStrengthenView = new EUiViewName("TrapDefenseBdBuffStrengthenView");

		// Token: 0x040191C0 RID: 102848
		public static readonly EUiViewName TrapDefenseRoundTips = new EUiViewName("TrapDefenseRoundTips");

		// Token: 0x040191C1 RID: 102849
		public static readonly EUiViewName TrapDefenseEventTerrainChangeTips = new EUiViewName("TrapDefenseEventTerrainChangeTips");

		// Token: 0x040191C2 RID: 102850
		public static readonly EUiViewName TrapDefenseEventShopOpenTips = new EUiViewName("TrapDefenseEventShopOpenTips");

		// Token: 0x040191C3 RID: 102851
		public static readonly EUiViewName TrapDefenseEventBossComingTips = new EUiViewName("TrapDefenseEventBossComingTips");

		// Token: 0x040191C4 RID: 102852
		public static readonly EUiViewName TrapDefenseRewardView = new EUiViewName("TrapDefenseRewardView");

		// Token: 0x040191C5 RID: 102853
		public static readonly EUiViewName TrapDefenseBuildingDevelopMainView = new EUiViewName("TrapDefenseBuildingDevelopMainView");

		// Token: 0x040191C6 RID: 102854
		public static readonly EUiViewName TrapDefenseBuildingDevelopPreviewView = new EUiViewName("TrapDefenseBuildingDevelopPreviewView");

		// Token: 0x040191C7 RID: 102855
		public static readonly EUiViewName TrapDefenseBuildingDevelopBranchSelectView = new EUiViewName("TrapDefenseBuildingDevelopBranchSelectView");

		// Token: 0x040191C8 RID: 102856
		public static readonly EUiViewName TrapDefensePauseView = new EUiViewName("TrapDefensePauseView");

		// Token: 0x040191C9 RID: 102857
		public static readonly EUiViewName TrapDefenseCountDownTips = new EUiViewName("TrapDefenseCountDownTips");

		// Token: 0x040191CA RID: 102858
		public static readonly EUiViewName TrapDefenseResultView = new EUiViewName("TrapDefenseResultView");

		// Token: 0x040191CB RID: 102859
		public static readonly EUiViewName TrapDefenseBuildingMachineInfoView = new EUiViewName("TrapDefenseBuildingMachineInfoView");

		// Token: 0x040191CC RID: 102860
		public static readonly EUiViewName TrapDefenseBuildingGangsInfoView = new EUiViewName("TrapDefenseBuildingGangsInfoView");

		// Token: 0x040191CD RID: 102861
		public static readonly EUiViewName TrapDefenseMonsterView = new EUiViewName("TrapDefenseMonsterView");

		// Token: 0x040191CE RID: 102862
		public static readonly EUiViewName TrapDefenseTalentTreeView = new EUiViewName("TrapDefenseTalentTreeView");

		// Token: 0x040191CF RID: 102863
		public static readonly EUiViewName TrapDefenseFixedRewardView = new EUiViewName("TrapDefenseFixedRewardView");

		// Token: 0x040191D0 RID: 102864
		public static readonly EUiViewName TrapDefenseMainLevelView = new EUiViewName("TrapDefenseMainLevelView");

		// Token: 0x040191D1 RID: 102865
		public static readonly EUiViewName TrapDefenseRougeLevelView = new EUiViewName("TrapDefenseRougeLevelView");

		// Token: 0x040191D2 RID: 102866
		public static readonly EUiViewName TrapDefenseMapView = new EUiViewName("TrapDefenseMapView");

		// Token: 0x040191D3 RID: 102867
		public static readonly EUiViewName TrapDefenseShopView = new EUiViewName("TrapDefenseShopView");

		// Token: 0x040191D4 RID: 102868
		public static readonly EUiViewName TrapDefenseTransitionView = new EUiViewName("TrapDefenseTransitionView");

		// Token: 0x040191D5 RID: 102869
		public static readonly EUiViewName TrapDefenseActivityUnlockView = new EUiViewName("TrapDefenseActivityUnlockView");

		// Token: 0x040191D6 RID: 102870
		public static readonly EUiViewName TermExplanationCenterView = new EUiViewName("TermExplanationCenterView");

		// Token: 0x040191D7 RID: 102871
		public static readonly EUiViewName TermExplanationSideView = new EUiViewName("TermExplanationSideView");

		// Token: 0x040191D8 RID: 102872
		public static readonly EUiViewName FloroRanchTermExplanationCenterView = new EUiViewName("FloroRanchTermExplanationCenterView");

		// Token: 0x040191D9 RID: 102873
		public static readonly EUiViewName FloroRanchTermExplanationSideView = new EUiViewName("FloroRanchTermExplanationSideView");

		// Token: 0x040191DA RID: 102874
		public static readonly EUiViewName BirthdayRoleSelectView = new EUiViewName("BirthdayRoleSelectView");

		// Token: 0x040191DB RID: 102875
		public static readonly EUiViewName BirthdaySelectConfirmView = new EUiViewName("BirthdaySelectConfirmView");

		// Token: 0x040191DC RID: 102876
		public static readonly EUiViewName BirthdayLetterView = new EUiViewName("BirthdayLetterView");

		// Token: 0x040191DD RID: 102877
		public static readonly EUiViewName CumulativeShopTaskView = new EUiViewName("CumulativeShopTaskView");

		// Token: 0x040191DE RID: 102878
		public static readonly EUiViewName RogueBattleFallbackView = new EUiViewName("RogueBattleFallbackView");

		// Token: 0x040191DF RID: 102879
		public static readonly EUiViewName RailSlideView = new EUiViewName("RailSlideView");

		// Token: 0x040191E0 RID: 102880
		public static readonly EUiViewName MotorcycleRailMoveView = new EUiViewName("MotorcycleRailMoveView");

		// Token: 0x040191E1 RID: 102881
		public static readonly EUiViewName ResDownLoadView = new EUiViewName("ResDownLoadView");

		// Token: 0x040191E2 RID: 102882
		public static readonly EUiViewName ResDownLoadMeOutOfMemoryView = new EUiViewName("ResDownLoadMeOutOfMemoryView");

		// Token: 0x040191E3 RID: 102883
		public static readonly EUiViewName ResDownLoadLoadingView = new EUiViewName("ResDownLoadLoadingView");

		// Token: 0x040191E4 RID: 102884
		public static readonly EUiViewName MoraleIndomitableLevelView = new EUiViewName("MoraleIndomitableLevelView");

		// Token: 0x040191E5 RID: 102885
		public static readonly EUiViewName MoraleOccupiedSuccessView = new EUiViewName("MoraleOccupiedSuccessView");

		// Token: 0x040191E6 RID: 102886
		public static readonly EUiViewName MoraleLevelDecreaseView = new EUiViewName("MoraleLevelDecreaseView");

		// Token: 0x040191E7 RID: 102887
		public static readonly EUiViewName PlotArtWord2dView = new EUiViewName("PlotArtWord2dView");

		// Token: 0x040191E8 RID: 102888
		public static readonly EUiViewName ShowerInviteView = new EUiViewName("ShowerInviteView");

		// Token: 0x040191E9 RID: 102889
		public static readonly EUiViewName ShowerMainView = new EUiViewName("ShowerMainView");

		// Token: 0x040191EA RID: 102890
		public static readonly EUiViewName QuestReviewMainView = new EUiViewName("QuestReviewMainView");

		// Token: 0x040191EB RID: 102891
		public static readonly EUiViewName QuestReviewDetailView = new EUiViewName("QuestReviewDetailView");

		// Token: 0x040191EC RID: 102892
		public static readonly EUiViewName QuestReviewTipsView = new EUiViewName("QuestReviewTipsView");

		// Token: 0x040191ED RID: 102893
		public static readonly EUiViewName FilterSettingView = new EUiViewName("FilterSettingView");

		// Token: 0x040191EE RID: 102894
		public static readonly EUiViewName BeginnerCarnivalMainView = new EUiViewName("BeginnerCarnivalMainView");

		// Token: 0x040191EF RID: 102895
		public static readonly EUiViewName BeginnerCarnivalRoleTaskView = new EUiViewName("BeginnerCarnivalRoleTaskView");

		// Token: 0x040191F0 RID: 102896
		public static readonly EUiViewName BeginnerCarnivalChoseRoleView = new EUiViewName("BeginnerCarnivalChoseRoleView");

		// Token: 0x040191F1 RID: 102897
		public static readonly EUiViewName BeginnerCarnivalTaskView = new EUiViewName("BeginnerCarnivalTaskView");

		// Token: 0x040191F2 RID: 102898
		public static readonly EUiViewName BeginnerCarnivalUnlockTipView = new EUiViewName("BeginnerCarnivalUnlockTipView");

		// Token: 0x040191F3 RID: 102899
		public static readonly EUiViewName ActivityUnlockTipSevenHillsView = new EUiViewName("ActivityUnlockTipSevenHillsView");

		// Token: 0x040191F4 RID: 102900
		public static readonly EUiViewName SevenHillsMainView = new EUiViewName("SevenHillsMainView");

		// Token: 0x040191F5 RID: 102901
		public static readonly EUiViewName SevenHillsStageTaskView = new EUiViewName("SevenHillsStageTaskView");

		// Token: 0x040191F6 RID: 102902
		public static readonly EUiViewName FloroRanchActivityView = new EUiViewName("FloroRanchActivityView");

		// Token: 0x040191F7 RID: 102903
		public static readonly EUiViewName FloroRanchMainView = new EUiViewName("FloroRanchMainView");

		// Token: 0x040191F8 RID: 102904
		public static readonly EUiViewName FloroRanchCardSelectView = new EUiViewName("FloroRanchCardSelectView");

		// Token: 0x040191F9 RID: 102905
		public static readonly EUiViewName FloroRanchCardGroupSelectView = new EUiViewName("FloroRanchCardGroupSelectView");

		// Token: 0x040191FA RID: 102906
		public static readonly EUiViewName FloroRanchPhaseTargetView = new EUiViewName("FloroRanchPhaseTargetView");

		// Token: 0x040191FB RID: 102907
		public static readonly EUiViewName FloroRanchPhaseSettleView = new EUiViewName("FloroRanchPhaseSettleView");

		// Token: 0x040191FC RID: 102908
		public static readonly EUiViewName FloroRanchCommonTipsView = new EUiViewName("FloroRanchCommonTipsView");

		// Token: 0x040191FD RID: 102909
		public static readonly EUiViewName FloroRanchDailySettleView = new EUiViewName("FloroRanchDailySettleView");

		// Token: 0x040191FE RID: 102910
		public static readonly EUiViewName FloroRanchDungeonSelectView = new EUiViewName("FloroRanchDungeonSelectView");

		// Token: 0x040191FF RID: 102911
		public static readonly EUiViewName FloroRanchGamePlayExplainView = new EUiViewName("FloroRanchGamePlayExplainView");

		// Token: 0x04019200 RID: 102912
		public static readonly EUiViewName FloroRanchGamePlayView = new EUiViewName("FloroRanchGamePlayView");

		// Token: 0x04019201 RID: 102913
		public static readonly EUiViewName FloroRanchHandBookView = new EUiViewName("FloroRanchHandBookView");

		// Token: 0x04019202 RID: 102914
		public static readonly EUiViewName FloroRanchLimitRewardView = new EUiViewName("FloroRanchLimitRewardView");

		// Token: 0x04019203 RID: 102915
		public static readonly EUiViewName FloroRanchPermanentRewardView = new EUiViewName("FloroRanchPermanentRewardView");

		// Token: 0x04019204 RID: 102916
		public static readonly EUiViewName FloroRanchRaceSelectView = new EUiViewName("FloroRanchRaceSelectView");

		// Token: 0x04019205 RID: 102917
		public static readonly EUiViewName FloroRanchRandomEventView = new EUiViewName("FloroRanchRandomEventView");

		// Token: 0x04019206 RID: 102918
		public static readonly EUiViewName FloroRanchShopView = new EUiViewName("FloroRanchShopView");

		// Token: 0x04019207 RID: 102919
		public static readonly EUiViewName FloroRanchShopTipView = new EUiViewName("FloroRanchShopTipView");

		// Token: 0x04019208 RID: 102920
		public static readonly EUiViewName FloroRanchSkillView = new EUiViewName("FloroRanchSkillView");

		// Token: 0x04019209 RID: 102921
		public static readonly EUiViewName FloroRanchTechnologyView = new EUiViewName("FloroRanchTechnologyView");

		// Token: 0x0401920A RID: 102922
		public static readonly EUiViewName FloroRanchIncomeDetailView = new EUiViewName("FloroRanchIncomeDetailView");

		// Token: 0x0401920B RID: 102923
		public static readonly EUiViewName FloroRanchDungeonFailSettleView = new EUiViewName("FloroRanchDungeonFailSettleView");

		// Token: 0x0401920C RID: 102924
		public static readonly EUiViewName FloroRanchDungeonEndlessSettleView = new EUiViewName("FloroRanchDungeonEndlessSettleView");

		// Token: 0x0401920D RID: 102925
		public static readonly EUiViewName FloroRanchDungeonSuccessSettleView = new EUiViewName("FloroRanchDungeonSuccessSettleView");

		// Token: 0x0401920E RID: 102926
		public static readonly EUiViewName FloroRanchConfirmBoxView = new EUiViewName("FloroRanchConfirmBoxView");

		// Token: 0x0401920F RID: 102927
		public static readonly EUiViewName FloroRanchPauseView = new EUiViewName("FloroRanchPauseView");

		// Token: 0x04019210 RID: 102928
		public static readonly EUiViewName FloroRanchSkillTipView = new EUiViewName("FloroRanchSkillTipView");

		// Token: 0x04019211 RID: 102929
		public static readonly EUiViewName FloroRanchHelpView = new EUiViewName("FloroRanchHelpView");

		// Token: 0x04019212 RID: 102930
		public static readonly EUiViewName FloroRanchComicView = new EUiViewName("FloroRanchComicView");

		// Token: 0x04019213 RID: 102931
		public static readonly EUiViewName FloroRanchComicView2 = new EUiViewName("FloroRanchComicView2");

		// Token: 0x04019214 RID: 102932
		public static readonly EUiViewName FloroRanchComicView3 = new EUiViewName("FloroRanchComicView3");

		// Token: 0x04019215 RID: 102933
		public static readonly EUiViewName FloroRanchComicView4 = new EUiViewName("FloroRanchComicView4");

		// Token: 0x04019216 RID: 102934
		public static readonly EUiViewName FloroRanchUnlockTipView = new EUiViewName("FloroRanchUnlockTipView");

		// Token: 0x04019217 RID: 102935
		public static readonly EUiViewName FloroRanchWeeklyMainView = new EUiViewName("FloroRanchWeeklyMainView");

		// Token: 0x04019218 RID: 102936
		public static readonly EUiViewName FloroRanchRecommendTipView = new EUiViewName("FloroRanchRecommendTipView");

		// Token: 0x04019219 RID: 102937
		public static readonly EUiViewName KingShipMainView = new EUiViewName("KingShipMainView");

		// Token: 0x0401921A RID: 102938
		public static readonly EUiViewName KingShipLoadingView = new EUiViewName("KingShipLoadingView");

		// Token: 0x0401921B RID: 102939
		public static readonly EUiViewName KingShipResultView = new EUiViewName("KingShipResultView");

		// Token: 0x0401921C RID: 102940
		public static readonly EUiViewName KingShipPlotView = new EUiViewName("KingShipPlotView");

		// Token: 0x0401921D RID: 102941
		public static readonly EUiViewName KingShipFailView = new EUiViewName("KingShipFailView");

		// Token: 0x0401921E RID: 102942
		public static readonly EUiViewName LifePointDrawDetailView = new EUiViewName("LifePointDrawDetailView");

		// Token: 0x0401921F RID: 102943
		public static readonly EUiViewName LifePointDrawEntranceView = new EUiViewName("LifePointDrawEntranceView");

		// Token: 0x04019220 RID: 102944
		public static readonly EUiViewName NightmareLordFloatTips = new EUiViewName("NightmareLordFloatTips");

		// Token: 0x04019221 RID: 102945
		public static readonly EUiViewName NightmareSpawnPointFloatTips = new EUiViewName("NightmareSpawnPointFloatTips");

		// Token: 0x04019222 RID: 102946
		public static readonly EUiViewName HonamiStoryMainLoadingView = new EUiViewName("HonamiStoryMainLoadingView");

		// Token: 0x04019223 RID: 102947
		public static readonly EUiViewName HonamiStorySmallLoadingView = new EUiViewName("HonamiStorySmallLoadingView");

		// Token: 0x04019224 RID: 102948
		public static readonly EUiViewName HonamiStoryInventoryView = new EUiViewName("HonamiStoryInventoryView");

		// Token: 0x04019225 RID: 102949
		public static readonly EUiViewName HonamiStoryBackpackView = new EUiViewName("HonamiStoryBackpackView");

		// Token: 0x04019226 RID: 102950
		public static readonly EUiViewName HonamiStoryPickUpBackpackView = new EUiViewName("HonamiStoryPickUpBackpackView");

		// Token: 0x04019227 RID: 102951
		public static readonly EUiViewName HonamiStoryPickUpMobileView = new EUiViewName("HonamiStoryPickUpMobileView");

		// Token: 0x04019228 RID: 102952
		public static readonly EUiViewName HonamiStorySettleSuccessView = new EUiViewName("HonamiStorySettleSuccessView");

		// Token: 0x04019229 RID: 102953
		public static readonly EUiViewName HonamiStorySettleFailView = new EUiViewName("HonamiStorySettleFailView");

		// Token: 0x0401922A RID: 102954
		public static readonly EUiViewName HonamiStorySellConfirmBoxView = new EUiViewName("HonamiStorySellConfirmBoxView");

		// Token: 0x0401922B RID: 102955
		public static readonly EUiViewName HonamiStoryMascotCollectBookView = new EUiViewName("HonamiStoryMascotCollectBookView");

		// Token: 0x0401922C RID: 102956
		public static readonly EUiViewName HonamiStoryQuestView = new EUiViewName("HonamiStoryQuestView");

		// Token: 0x0401922D RID: 102957
		public static readonly EUiViewName HonamiStoryQuestFinishView = new EUiViewName("HonamiStoryQuestFinishView");

		// Token: 0x0401922E RID: 102958
		public static readonly EUiViewName HonamiStoryShopView = new EUiViewName("HonamiStoryShopView");

		// Token: 0x0401922F RID: 102959
		public static readonly EUiViewName HonamiStoryPermanentTaskView = new EUiViewName("HonamiStoryPermanentTaskView");

		// Token: 0x04019230 RID: 102960
		public static readonly EUiViewName HonamiStoryLimitTaskView = new EUiViewName("HonamiStoryLimitTaskView");

		// Token: 0x04019231 RID: 102961
		public static readonly EUiViewName HonamiStoryScoreRewardView = new EUiViewName("HonamiStoryScoreRewardView");

		// Token: 0x04019232 RID: 102962
		public static readonly EUiViewName HonamiStoryTechnologyView = new EUiViewName("HonamiStoryTechnologyView");

		// Token: 0x04019233 RID: 102963
		public static readonly EUiViewName HonamiStoryLevelInfoView = new EUiViewName("HonamiStoryLevelInfoView");

		// Token: 0x04019234 RID: 102964
		public static readonly EUiViewName HonamiStoryItemCollectView = new EUiViewName("HonamiStoryItemCollectView");

		// Token: 0x04019235 RID: 102965
		public static readonly EUiViewName HonamiStoryMainView = new EUiViewName("HonamiStoryMainView");

		// Token: 0x04019236 RID: 102966
		public static readonly EUiViewName HonamiStoryWeaponSelectView = new EUiViewName("HonamiStoryWeaponSelectView");

		// Token: 0x04019237 RID: 102967
		public static readonly EUiViewName HonamiStoryTechSuccessEffectView = new EUiViewName("HonamiStoryTechSuccessEffectView");

		// Token: 0x04019238 RID: 102968
		public static readonly EUiViewName HonamiStoryLeaveTip = new EUiViewName("HonamiStoryLeaveTip");

		// Token: 0x04019239 RID: 102969
		public static readonly EUiViewName HonamiStoryPollutionLevelUpdateView = new EUiViewName("HonamiStoryPollutionLevelUpdateView");

		// Token: 0x0401923A RID: 102970
		public static readonly EUiViewName HonamiStorySafeLeaveUpdateView = new EUiViewName("HonamiStorySafeLeaveUpdateView");

		// Token: 0x0401923B RID: 102971
		public static readonly EUiViewName HonamiStoryUnlockTipView = new EUiViewName("HonamiStoryUnlockTipView");

		// Token: 0x0401923C RID: 102972
		public static readonly EUiViewName HonamiStoryNewTipsView = new EUiViewName("HonamiStoryNewTipsView");

		// Token: 0x0401923D RID: 102973
		public static readonly EUiViewName HonamiWeaponRewardView = new EUiViewName("HonamiWeaponRewardView");

		// Token: 0x0401923E RID: 102974
		public static readonly EUiViewName HonamiStoryLoadingView = new EUiViewName("HonamiStoryLoadingView");

		// Token: 0x0401923F RID: 102975
		public static readonly EUiViewName CommonGameMainView = new EUiViewName("CommonGameMainView");

		// Token: 0x04019240 RID: 102976
		public static readonly EUiViewName CommonTouchUiEditView = new EUiViewName("CommonTouchUiEditView");

		// Token: 0x04019241 RID: 102977
		public static readonly EUiViewName AstrologyItemInspectView = new EUiViewName("AstrologyItemInspectView");

		// Token: 0x04019242 RID: 102978
		public static readonly EUiViewName SeekTraceView = new EUiViewName("SeekTraceView");

		// Token: 0x04019243 RID: 102979
		public static readonly EUiViewName SeekTraceStartView = new EUiViewName("SeekTraceStartView");

		// Token: 0x04019244 RID: 102980
		public static readonly EUiViewName GreatSwordLevelSelectView = new EUiViewName("GreatSwordLevelSelectView");

		// Token: 0x04019245 RID: 102981
		public static readonly EUiViewName GreatSwordCountDownView = new EUiViewName("GreatSwordCountDownView");

		// Token: 0x04019246 RID: 102982
		public static readonly EUiViewName GreatSwordOpenTipsView = new EUiViewName("GreatSwordOpenTipsView");

		// Token: 0x04019247 RID: 102983
		public static readonly EUiViewName AnchorGameplayView = new EUiViewName("AnchorGameplayView");

		// Token: 0x04019248 RID: 102984
		public static readonly EUiViewName Theme26UnlockTipView = new EUiViewName("Theme26UnlockTipView");

		// Token: 0x04019249 RID: 102985
		public static readonly EUiViewName Theme26MainView = new EUiViewName("Theme26MainView");

		// Token: 0x0401924A RID: 102986
		public static readonly EUiViewName Theme26StageTaskView = new EUiViewName("Theme26StageTaskView");

		// Token: 0x0401924B RID: 102987
		public static readonly EUiViewName ActivityFunPlayView = new EUiViewName("ActivityFunPlayView");

		// Token: 0x0401924C RID: 102988
		public static readonly EUiViewName LineCrossEntranceView = new EUiViewName("LineCrossEntranceView");

		// Token: 0x0401924D RID: 102989
		public static readonly EUiViewName LineCrossDetailView = new EUiViewName("LineCrossDetailView");

		// Token: 0x0401924E RID: 102990
		public static readonly EUiViewName MoonSignInMainView = new EUiViewName("MoonSignInMainView");

		// Token: 0x0401924F RID: 102991
		public static readonly EUiViewName MoonSignInDetailView = new EUiViewName("MoonSignInDetailView");

		// Token: 0x04019250 RID: 102992
		public static readonly EUiViewName MoonSignInRewardView = new EUiViewName("MoonSignInRewardView");

		// Token: 0x04019251 RID: 102993
		public static readonly EUiViewName SurvivorsTalentTreeView = new EUiViewName("SurvivorsTalentTreeView");

		// Token: 0x04019252 RID: 102994
		public static readonly EUiViewName SurvivorsTalentUnlockView = new EUiViewName("SurvivorsTalentUnlockView");

		// Token: 0x04019253 RID: 102995
		public static readonly EUiViewName SurvivorsTeamEditView = new EUiViewName("SurvivorsTeamEditView");

		// Token: 0x04019254 RID: 102996
		public static readonly EUiViewName SurvivorsHandbookView = new EUiViewName("SurvivorsHandbookView");

		// Token: 0x04019255 RID: 102997
		public static readonly EUiViewName SurvivorsRogueEvolveView = new EUiViewName("SurvivorsRogueEvolveView");

		// Token: 0x04019256 RID: 102998
		public static readonly EUiViewName SurvivorsRogueGeneralObtainView = new EUiViewName("SurvivorsRogueGeneralObtainView");

		// Token: 0x04019257 RID: 102999
		public static readonly EUiViewName SurvivorsRogueShopView = new EUiViewName("SurvivorsRogueShopView");

		// Token: 0x04019258 RID: 103000
		public static readonly EUiViewName SurvivorsRogueSettleView = new EUiViewName("SurvivorsRogueSettleView");

		// Token: 0x04019259 RID: 103001
		public static readonly EUiViewName SurvivorsRogueSettleExternalView = new EUiViewName("SurvivorsRogueSettleExternalView");

		// Token: 0x0401925A RID: 103002
		public static readonly EUiViewName SurvivorsRogueExitView = new EUiViewName("SurvivorsRogueExitView");

		// Token: 0x0401925B RID: 103003
		public static readonly EUiViewName SurvivorsRogueRewardView = new EUiViewName("SurvivorsRogueRewardView");

		// Token: 0x0401925C RID: 103004
		public static readonly EUiViewName SurvivorsRogueMainView = new EUiViewName("SurvivorsRogueMainView");

		// Token: 0x0401925D RID: 103005
		public static readonly EUiViewName SurvivorsRogueActivityUnlockView = new EUiViewName("SurvivorsRogueActivityUnlockView");

		// Token: 0x0401925E RID: 103006
		public static readonly EUiViewName SurvivorsLevelDetailView = new EUiViewName("SurvivorsLevelDetailView");

		// Token: 0x0401925F RID: 103007
		public static readonly EUiViewName SurvivorsTabMainView = new EUiViewName("SurvivorsTabMainView");

		// Token: 0x04019260 RID: 103008
		public static readonly EUiViewName SurvivorsCardTips = new EUiViewName("SurvivorsCardTips");

		// Token: 0x04019261 RID: 103009
		public static readonly EUiViewName SurvivorsWeaponUnlockView = new EUiViewName("SurvivorsWeaponUnlockView");

		// Token: 0x04019262 RID: 103010
		public static readonly EUiViewName SurvivorsAttributeDetailView = new EUiViewName("SurvivorsAttributeDetailView");

		// Token: 0x04019263 RID: 103011
		public static readonly EUiViewName SurvivorsWeaponAttributeView = new EUiViewName("SurvivorsWeaponAttributeView");

		// Token: 0x04019264 RID: 103012
		public static readonly EUiViewName RoleDevRootView = new EUiViewName("RoleDevRootView");

		// Token: 0x04019265 RID: 103013
		public static readonly EUiViewName RoleSkillMergeView = new EUiViewName("RoleSkillMergeView");

		// Token: 0x04019266 RID: 103014
		public static readonly EUiViewName RoleDevelopRootView = new EUiViewName("RoleDevelopRootView");

		// Token: 0x04019267 RID: 103015
		public static readonly EUiViewName RoleDevelopSelectTargetView = new EUiViewName("RoleDevelopSelectTargetView");

		// Token: 0x04019268 RID: 103016
		public static readonly EUiViewName ItemHintViewNew = new EUiViewName("ItemHintViewNew");

		// Token: 0x04019269 RID: 103017
		public static readonly EUiViewName QuestTreeMainView = new EUiViewName("QuestTreeMainView");

		// Token: 0x0401926A RID: 103018
		public static readonly EUiViewName QuestTreeChapterView = new EUiViewName("QuestTreeChapterView");

		// Token: 0x0401926B RID: 103019
		public static readonly EUiViewName QuestTreeNodeDetailView = new EUiViewName("QuestTreeNodeDetailView");

		// Token: 0x0401926C RID: 103020
		public static readonly EUiViewName QuestTreeNodeImageView = new EUiViewName("QuestTreeNodeImageView");

		// Token: 0x0401926D RID: 103021
		public static readonly EUiViewName QuestTreeAvailableListView = new EUiViewName("QuestTreeAvailableListView");

		// Token: 0x0401926E RID: 103022
		public static readonly EUiViewName PersonalPlayerTitleUnLockTipsView = new EUiViewName("PersonalPlayerTitleUnLockTipsView");

		// Token: 0x0401926F RID: 103023
		public static readonly EUiViewName VisionSettlementFloatTips = new EUiViewName("VisionSettlementFloatTips");

		// Token: 0x04019270 RID: 103024
		public static readonly EUiViewName EyeProtectView = new EUiViewName("EyeProtectView");

		// Token: 0x04019271 RID: 103025
		public static readonly EUiViewName CsViewProxy = new EUiViewName("CsViewProxy");

		// Token: 0x04019272 RID: 103026
		public static readonly EUiViewName InfrastructureMainView = new EUiViewName("InfrastructureMainView");

		// Token: 0x04019273 RID: 103027
		public static readonly EUiViewName InfrArchiveMainView = new EUiViewName("InfrArchiveMainView");

		// Token: 0x04019274 RID: 103028
		public static readonly EUiViewName InfrastructureSettleView = new EUiViewName("InfrastructureSettleView");

		// Token: 0x04019275 RID: 103029
		public static readonly EUiViewName InfrLimitTaskMainView = new EUiViewName("InfrLimitTaskMainView");

		// Token: 0x04019276 RID: 103030
		public static readonly EUiViewName InfrastructureShopMainView = new EUiViewName("InfrastructureShopMainView");

		// Token: 0x04019277 RID: 103031
		public static readonly EUiViewName InfrRoadNetworkMainView = new EUiViewName("InfrRoadNetworkMainView");

		// Token: 0x04019278 RID: 103032
		public static readonly EUiViewName InfrMaterialsDeliveryView = new EUiViewName("InfrMaterialsDeliveryView");

		// Token: 0x04019279 RID: 103033
		public static readonly EUiViewName InfrRoadNetworkInfoView = new EUiViewName("InfrRoadNetworkInfoView");

		// Token: 0x0401927A RID: 103034
		public static readonly EUiViewName InfrOpeningTipsView = new EUiViewName("InfrOpeningTipsView");

		// Token: 0x0401927B RID: 103035
		public static readonly EUiViewName RegionalTerminalOverviewView = new EUiViewName("RegionalTerminalOverviewView");

		// Token: 0x0401927C RID: 103036
		public static readonly EUiViewName VillageInfrMainView = new EUiViewName("VillageInfrMainView");

		// Token: 0x0401927D RID: 103037
		public static readonly EUiViewName VillageInfrTaskMainView = new EUiViewName("VillageInfrTaskMainView");

		// Token: 0x0401927E RID: 103038
		public static readonly EUiViewName VillageInfrBuildFinishTipView = new EUiViewName("VillageInfrBuildFinishTipView");

		// Token: 0x0401927F RID: 103039
		public static readonly EUiViewName VillageInfrWorldBuildView = new EUiViewName("VillageInfrWorldBuildView");

		// Token: 0x04019280 RID: 103040
		public static readonly EUiViewName VillageInfrBuildInfoView = new EUiViewName("VillageInfrBuildInfoView");

		// Token: 0x04019281 RID: 103041
		public static readonly EUiViewName VillageInfrNewTipsView = new EUiViewName("VillageInfrNewTipsView");

		// Token: 0x04019282 RID: 103042
		public static readonly EUiViewName PrizeDrawingMainView = new EUiViewName("PrizeDrawingMainView");

		// Token: 0x04019283 RID: 103043
		public static readonly EUiViewName PrizeDrawingTearView = new EUiViewName("PrizeDrawingTearView");

		// Token: 0x04019284 RID: 103044
		public static readonly EUiViewName PilotThrowView = new EUiViewName("PilotThrowView");

		// Token: 0x04019285 RID: 103045
		public static readonly EUiViewName DeadEyeModeView = new EUiViewName("DeadEyeJumpRampView");

		// Token: 0x04019286 RID: 103046
		public static readonly EUiViewName DeadEyeFloaterShooterView = new EUiViewName("DeadEyeFloaterShooterView");

		// Token: 0x04019287 RID: 103047
		public static readonly EUiViewName SynthesisTipsInfoView = new EUiViewName("SynthesisTipsInfoView");

		// Token: 0x04019288 RID: 103048
		public static readonly EUiViewName ActivityPreWarmMainView = new EUiViewName("ActivityPreWarmMainView");

		// Token: 0x04019289 RID: 103049
		public static readonly EUiViewName AdvanceNoticeRootView = new EUiViewName("AdvanceNoticeRootView");

		// Token: 0x0401928A RID: 103050
		public static readonly EUiViewName SubPackageDownLoadView = new EUiViewName("SubPackageDownLoadView");

		// Token: 0x0401928B RID: 103051
		public static readonly EUiViewName SubPackageDownLoadFreeSpaceTipsView = new EUiViewName("SubPackageDownLoadFreeSpaceTipsView");

		// Token: 0x0401928C RID: 103052
		public static readonly EUiViewName SubPackageDownLoadClearTipsView = new EUiViewName("SubPackageDownLoadClearTipsView");

		// Token: 0x0401928D RID: 103053
		public static readonly EUiViewName SubPackageDownLoadMobileClearPopView = new EUiViewName("SubPackageDownLoadMobileClearPopView");

		// Token: 0x0401928E RID: 103054
		public static readonly EUiViewName ArtemisActivityRoleChatView = new EUiViewName("ArtemisActivityRoleChatView");

		// Token: 0x0401928F RID: 103055
		public static readonly EUiViewName ArtemisActivityCertificationView = new EUiViewName("ArtemisActivityCertificationView");

		// Token: 0x04019290 RID: 103056
		public static readonly EUiViewName ArtemisQteView = new EUiViewName("ArtemisQteView");

		// Token: 0x04019291 RID: 103057
		public static readonly EUiViewName WeatherCentralMainView = new EUiViewName("WeatherCentralMainView");

		// Token: 0x04019292 RID: 103058
		public static readonly EUiViewName WeatherUnlockTips = new EUiViewName("WeatherUnlockTips");

		// Token: 0x04019293 RID: 103059
		public static readonly EUiViewName MotorcycleRootView = new EUiViewName("MotorcycleRootView");

		// Token: 0x04019294 RID: 103060
		public static readonly EUiViewName MotorcycleRewardPreviewView = new EUiViewName("MotorcycleRewardPreviewView");

		// Token: 0x04019295 RID: 103061
		public static readonly EUiViewName MotorcycleTechTreeDetailView = new EUiViewName("MotorcycleTechTreeDetailView");

		// Token: 0x04019296 RID: 103062
		public static readonly EUiViewName MotorcycleTechTreeLevelDetailView = new EUiViewName("MotorcycleTechTreeLevelDetailView");

		// Token: 0x04019297 RID: 103063
		public static readonly EUiViewName MotorcycleTechTreeLevelUpEffectView = new EUiViewName("MotorcycleTechTreeLevelUpEffectView");

		// Token: 0x04019298 RID: 103064
		public static readonly EUiViewName MotorcycleLevelAttrDetailView = new EUiViewName("MotorcycleLevelAttrDetailView");

		// Token: 0x04019299 RID: 103065
		public static readonly EUiViewName MotorcycleConditionView = new EUiViewName("MotorcycleConditionView");

		// Token: 0x0401929A RID: 103066
		public static readonly EUiViewName MotorcycleLevelUpView = new EUiViewName("MotorcycleLevelUpView");

		// Token: 0x0401929B RID: 103067
		public static readonly EUiViewName MotorcycleTechTreeSwitchView = new EUiViewName("MotorcycleTechTreeSwitchView");

		// Token: 0x0401929C RID: 103068
		public static readonly EUiViewName MotorcycleDiyRootView = new EUiViewName("MotorcycleDiyRootView");

		// Token: 0x0401929D RID: 103069
		public static readonly EUiViewName MotorcycleDiyEditRootView = new EUiViewName("MotorcycleDiyEditRootView");

		// Token: 0x0401929E RID: 103070
		public static readonly EUiViewName MotorcycleDiyImportPresetView = new EUiViewName("MotorcycleDiyImportPresetView");

		// Token: 0x0401929F RID: 103071
		public static readonly EUiViewName MotorcycleDiyOverviewView = new EUiViewName("MotorcycleDiyOverviewView");

		// Token: 0x040192A0 RID: 103072
		public static readonly EUiViewName MotorcycleDiyEditOverviewView = new EUiViewName("MotorcycleDiyEditOverviewView");

		// Token: 0x040192A1 RID: 103073
		public static readonly EUiViewName MotorcycleDiyStickerPreviewView = new EUiViewName("MotorcycleDiyStickerPreviewView");

		// Token: 0x040192A2 RID: 103074
		public static readonly EUiViewName MotorcycleDiyDecorationPreviewView = new EUiViewName("MotorcycleDiyDecorationPreviewView");

		// Token: 0x040192A3 RID: 103075
		public static readonly EUiViewName MotorcycleDiyNameInputView = new EUiViewName("MotorcycleDiyNameInputView");

		// Token: 0x040192A4 RID: 103076
		public static readonly EUiViewName MotorcycleDiySkinView = new EUiViewName("MotorcycleDiySkinView");

		// Token: 0x040192A5 RID: 103077
		public static readonly EUiViewName MotorcycleScenePopupView = new EUiViewName("MotorcycleScenePopupView");

		// Token: 0x040192A6 RID: 103078
		public static readonly EUiViewName MotorLinkageRewardView = new EUiViewName("MotoLinkageRewardView");

		// Token: 0x040192A7 RID: 103079
		public static readonly EUiViewName MotorcycleTogetherView = new EUiViewName("MotorcycleTogetherView");

		// Token: 0x040192A8 RID: 103080
		public static readonly EUiViewName MotorcycleCountDownView = new EUiViewName("MotorcycleCountDownView");

		// Token: 0x040192A9 RID: 103081
		public static readonly EUiViewName MotorcycleMusicPlayerView = new EUiViewName("MotorcycleMusicPlayerView");

		// Token: 0x040192AA RID: 103082
		public static readonly EUiViewName MotorcycleMusicDetailView = new EUiViewName("MotorcycleMusicDetailView");

		// Token: 0x040192AB RID: 103083
		public static readonly EUiViewName MotorcycleMusicSortView = new EUiViewName("MotorcycleMusicSortView");

		// Token: 0x040192AC RID: 103084
		public static readonly EUiViewName MotorMusicNewMusicTips = new EUiViewName("MotorMusicNewMusicTips");

		// Token: 0x040192AD RID: 103085
		public static readonly EUiViewName PhoneMsgTipViewA = new EUiViewName("PhoneMsgTipViewA");

		// Token: 0x040192AE RID: 103086
		public static readonly EUiViewName PhoneMsgTipViewB = new EUiViewName("PhoneMsgTipViewB");

		// Token: 0x040192AF RID: 103087
		public static readonly EUiViewName PhoneMsgTipViewC = new EUiViewName("PhoneMsgTipViewC");

		// Token: 0x040192B0 RID: 103088
		public static readonly EUiViewName PhoneMsgPanelViewBig = new EUiViewName("PhoneMsgPanelViewBig");

		// Token: 0x040192B1 RID: 103089
		public static readonly EUiViewName PhoneMsgPanelViewSmall = new EUiViewName("PhoneMsgPanelViewSmall");

		// Token: 0x040192B2 RID: 103090
		public static readonly EUiViewName PhoneMsgSettingView = new EUiViewName("PhoneMsgSettingView");

		// Token: 0x040192B3 RID: 103091
		public static readonly EUiViewName PhoneMsgLoadingView = new EUiViewName("PhoneMsgLoadingView");

		// Token: 0x040192B4 RID: 103092
		public static readonly EUiViewName PhoneViewFilterPanel = new EUiViewName("PhoneViewFilterPanel");

		// Token: 0x040192B5 RID: 103093
		public static readonly EUiViewName ActivityTagInfoHelpView = new EUiViewName("ActivityTagInfoHelpView");

		// Token: 0x040192B6 RID: 103094
		public static readonly EUiViewName PanoramicPointUnlockTipsView = new EUiViewName("PanoramicPointUnlockTipsView");

		// Token: 0x040192B7 RID: 103095
		public static readonly EUiViewName LaHaiLuoCollectView = new EUiViewName("LaHaiLuoCollectView");

		// Token: 0x040192B8 RID: 103096
		public static readonly EUiViewName RiLingCollectView = new EUiViewName("LaHaiLuoCollectView");

		// Token: 0x040192B9 RID: 103097
		public static readonly EUiViewName CookSchoolMechanismRootView = new EUiViewName("CookSchoolMechanismRootView");

		// Token: 0x040192BA RID: 103098
		public static readonly EUiViewName RoadBookMainView = new EUiViewName("RoadBookMainView");

		// Token: 0x040192BB RID: 103099
		public static readonly EUiViewName RoadBookTravelTaskView = new EUiViewName("RoadBookTravelTaskView");

		// Token: 0x040192BC RID: 103100
		public static readonly EUiViewName RoadBookVehicleTaskView = new EUiViewName("RoadBookVehicleTaskView");

		// Token: 0x040192BD RID: 103101
		public static readonly EUiViewName RoadBookPhantomTaskView = new EUiViewName("RoadBookPhantomTaskView");

		// Token: 0x040192BE RID: 103102
		public static readonly EUiViewName RoadBookLevelTipsView = new EUiViewName("RoadBookLevelTipsView");

		// Token: 0x040192BF RID: 103103
		public static readonly EUiViewName ActivityUnlockTipRoadBookView = new EUiViewName("ActivityUnlockTipRoadBookView");

		// Token: 0x040192C0 RID: 103104
		public static readonly EUiViewName DeviceInfoView = new EUiViewName("DeviceInfoView");

		// Token: 0x040192C1 RID: 103105
		public static readonly EUiViewName FeedbackRewardMainView = new EUiViewName("FeedbackRewardMainView");

		// Token: 0x040192C2 RID: 103106
		public static readonly EUiViewName FeedbackRewardStartView = new EUiViewName("FeedbackRewardStartView");

		// Token: 0x040192C3 RID: 103107
		public static readonly EUiViewName TotalTopUpPreviewView = new EUiViewName("TotalTopUpPreviewView");

		// Token: 0x040192C4 RID: 103108
		public static readonly EUiViewName TotalTopUpPickRoleRewardView = new EUiViewName("TotalTopUpPickRoleRewardView");

		// Token: 0x040192C5 RID: 103109
		public static readonly EUiViewName TotalTopUp37VideoFullScreenView = new EUiViewName("TotalTopUp37VideoFullScreenView");

		// Token: 0x040192C6 RID: 103110
		public static readonly EUiViewName KurotatoTabMainView = new EUiViewName("KurotatoTabMainView");

		// Token: 0x040192C7 RID: 103111
		public static readonly EUiViewName KurotatoAttrSelectMainView = new EUiViewName("KurotatoAttrSelectMainView");

		// Token: 0x040192C8 RID: 103112
		public static readonly EUiViewName KurotatoBoxDropMainView = new EUiViewName("KurotatoBoxDropMainView");

		// Token: 0x040192C9 RID: 103113
		public static readonly EUiViewName KurotatoContentView = new EUiViewName("KurotatoContentView");

		// Token: 0x040192CA RID: 103114
		public static readonly EUiViewName KurotatoShopMainView = new EUiViewName("KurotatoShopMainView");

		// Token: 0x040192CB RID: 103115
		public static readonly EUiViewName KurotatoAttributeDetailView = new EUiViewName("KurotatoAttributeDetailView");

		// Token: 0x040192CC RID: 103116
		public static readonly EUiViewName KurotatoPopupDetailView = new EUiViewName("KurotatoPopupDetailView");

		// Token: 0x040192CD RID: 103117
		public static readonly EUiViewName KurotatoPopupItemDetailView = new EUiViewName("KurotatoPopupItemDetailView");

		// Token: 0x040192CE RID: 103118
		public static readonly EUiViewName KurotatoSettleView = new EUiViewName("KurotatoSettleView");

		// Token: 0x040192CF RID: 103119
		public static readonly EUiViewName KurotatoPauseView = new EUiViewName("KurotatoPauseView");

		// Token: 0x040192D0 RID: 103120
		public static readonly EUiViewName KurotatoPopupWeaponDetailView = new EUiViewName("KurotatoPopupWeaponDetailView");

		// Token: 0x040192D1 RID: 103121
		public static readonly EUiViewName KurotatoPopupUnlockRoleView = new EUiViewName("KurotatoPopupUnlockRoleView");

		// Token: 0x040192D2 RID: 103122
		public static readonly EUiViewName KurotatoMainView = new EUiViewName("KurotatoMainView");

		// Token: 0x040192D3 RID: 103123
		public static readonly EUiViewName KurotatoEnemyDetailBookMainView = new EUiViewName("KurotatoEnemyDetailBookMainView");

		// Token: 0x040192D4 RID: 103124
		public static readonly EUiViewName KurotatoLimitedTimeRewardView = new EUiViewName("KurotatoLimitedTimeRewardView");

		// Token: 0x040192D5 RID: 103125
		public static readonly EUiViewName KurotatoNormalRewardView = new EUiViewName("KurotatoNormalRewardView");

		// Token: 0x040192D6 RID: 103126
		public static readonly EUiViewName KurotatoHandBookView = new EUiViewName("KurotatoHandBookView");

		// Token: 0x040192D7 RID: 103127
		public static readonly EUiViewName KurotatoRoleSelectView = new EUiViewName("KurotatoRoleSelectView");

		// Token: 0x040192D8 RID: 103128
		public static readonly EUiViewName KurotatoLevelSelectView = new EUiViewName("KurotatoLevelSelectView");

		// Token: 0x040192D9 RID: 103129
		public static readonly EUiViewName KurotatoActivityOpenView = new EUiViewName("KurotatoActivityOpenView");

		// Token: 0x040192DA RID: 103130
		public static readonly EUiViewName KurotatoPopupSaveView = new EUiViewName("KurotatoPopupSaveView");

		// Token: 0x040192DB RID: 103131
		public static readonly EUiViewName KurotatoShopOpenTipView = new EUiViewName("KurotatoShopOpenTipView");

		// Token: 0x040192DC RID: 103132
		public static readonly EUiViewName ActivityFeiXuePreheatMainView = new EUiViewName("ActivityFeiXuePreheatConfirmView");

		// Token: 0x040192DD RID: 103133
		public static readonly EUiViewName FeiXuePreheatMainView = new EUiViewName("FeiXuePreheatMainView");

		// Token: 0x040192DE RID: 103134
		public static readonly EUiViewName FeiXuePreheatRewardView = new EUiViewName("FeiXuePreheatRewardView");

		// Token: 0x040192DF RID: 103135
		public static readonly EUiViewName DropCatchLevelSelectView = new EUiViewName("DropCatchLevelSelectView");

		// Token: 0x040192E0 RID: 103136
		public static readonly EUiViewName DropCatchRoleDetailView = new EUiViewName("DropCatchRoleDetailView");

		// Token: 0x040192E1 RID: 103137
		public static readonly EUiViewName DropCatchDropItemDetailView = new EUiViewName("DropCatchDropItemDetailView");

		// Token: 0x040192E2 RID: 103138
		public static readonly EUiViewName DropCatchGameplayView = new EUiViewName("DropCatchGameplayView");

		// Token: 0x040192E3 RID: 103139
		public static readonly EUiViewName DropCatchGameplayPauseView = new EUiViewName("DropCatchGameplayPauseView");

		// Token: 0x040192E4 RID: 103140
		public static readonly EUiViewName DropCatchGameplayResultView = new EUiViewName("DropCatchGameplayResultView");

		// Token: 0x040192E5 RID: 103141
		public static readonly EUiViewName DropCatchStartGameView = new EUiViewName("DropCatchStartGameView");

		// Token: 0x040192E6 RID: 103142
		public static readonly EUiViewName DropCatchChatPopView = new EUiViewName("DropCatchChatPopView");

		// Token: 0x040192E7 RID: 103143
		public static readonly EUiViewName SpringManorAlbumPropView = new EUiViewName("Spring26AlbumPropView");

		// Token: 0x040192E8 RID: 103144
		public static readonly EUiViewName SpringManorBrochureView = new EUiViewName("Spring26BrochureView");

		// Token: 0x040192E9 RID: 103145
		public static readonly EUiViewName SpringManorAlbumView = new EUiViewName("Spring26AlbumView");

		// Token: 0x040192EA RID: 103146
		public static readonly EUiViewName SpringManorBrochureDetailView = new EUiViewName("Spring26BrochureDetailView");

		// Token: 0x040192EB RID: 103147
		public static readonly EUiViewName SpringManorBrochureCompletedView = new EUiViewName("Spring26BrochureCompletedView");

		// Token: 0x040192EC RID: 103148
		public static readonly EUiViewName DrinksSelectRoleView = new EUiViewName("DrinksSelectRoleView");

		// Token: 0x040192ED RID: 103149
		public static readonly EUiViewName DrinksGameplayView = new EUiViewName("DrinksGameplayView");

		// Token: 0x040192EE RID: 103150
		public static readonly EUiViewName DrinksShowView = new EUiViewName("DrinksShowView");

		// Token: 0x040192EF RID: 103151
		public static readonly EUiViewName ActivityGamePlayPlotView = new EUiViewName("ActivityGamePlayPlotView");

		// Token: 0x040192F0 RID: 103152
		public static readonly EUiViewName GuessJokerGamePlayView = new EUiViewName("GuessJokerGamePlayView");

		// Token: 0x040192F1 RID: 103153
		public static readonly EUiViewName GuessJokerSelectRoleView = new EUiViewName("GuessJokerSelectRoleView");

		// Token: 0x040192F2 RID: 103154
		public static readonly EUiViewName GuessJokerSettleWinView = new EUiViewName("GuessJokerSettleWinView");

		// Token: 0x040192F3 RID: 103155
		public static readonly EUiViewName GuessJokerSettleFailView = new EUiViewName("GuessJokerSettleFailView");

		// Token: 0x040192F4 RID: 103156
		public static readonly EUiViewName GuessJokerFloatTipsView = new EUiViewName("GuessJokerFloatTipsView");

		// Token: 0x040192F5 RID: 103157
		public static readonly EUiViewName EncirclePlayView = new EUiViewName("EncirclePlayView");

		// Token: 0x040192F6 RID: 103158
		public static readonly EUiViewName EncircleLevelDetailView = new EUiViewName("EncircleLevelDetailView");

		// Token: 0x040192F7 RID: 103159
		public static readonly EUiViewName EncircleSelectLevelView = new EUiViewName("EncircleSelectLevelView");

		// Token: 0x040192F8 RID: 103160
		public static readonly EUiViewName EncircleResultView = new EUiViewName("EncircleResultView");

		// Token: 0x040192F9 RID: 103161
		public static readonly EUiViewName RoleSkinRewardView = new EUiViewName("RoleSkinRewardView");

		// Token: 0x040192FA RID: 103162
		public static readonly EUiViewName SunSpiritHintView = new EUiViewName("SunSpiritHintView");

		// Token: 0x040192FB RID: 103163
		public static readonly EUiViewName SunSpiritLauncherHintView = new EUiViewName("SunSpiritLauncherHintView");

		// Token: 0x040192FC RID: 103164
		public static readonly EUiViewName FurnitureDesignView = new EUiViewName("FurnitureDesignView");

		// Token: 0x040192FD RID: 103165
		public static readonly EUiViewName FurniturePresetView = new EUiViewName("FurniturePresetView");

		// Token: 0x040192FE RID: 103166
		public static readonly EUiViewName FurnitureHandBookView = new EUiViewName("FurnitureHandBookView");

		// Token: 0x040192FF RID: 103167
		public static readonly EUiViewName FurnitureGetWayView = new EUiViewName("FurnitureGetWayView");

		// Token: 0x04019300 RID: 103168
		public static readonly EUiViewName FurnitureAreaSelectView = new EUiViewName("FurnitureAreaSelectView");

		// Token: 0x04019301 RID: 103169
		public static readonly EUiViewName FurnitureShopView = new EUiViewName("FurnitureShopView");

		// Token: 0x04019302 RID: 103170
		public static readonly EUiViewName MotorRaceSettlementView = new EUiViewName("MotorRaceSettlementView");

		// Token: 0x04019303 RID: 103171
		public static readonly EUiViewName MotorParkourMainView = new EUiViewName("MotorParkourMainView");

		// Token: 0x04019304 RID: 103172
		public static readonly EUiViewName MotorParkourRewardView = new EUiViewName("MotorParkourRewardView");

		// Token: 0x04019305 RID: 103173
		public static readonly EUiViewName MotorParkourSettleView = new EUiViewName("MotorParkourSettleView");

		// Token: 0x04019306 RID: 103174
		public static readonly EUiViewName MotorParkourBattleView = new EUiViewName("MotorParkourBattleView");

		// Token: 0x04019307 RID: 103175
		public static readonly EUiViewName MotorParkourTimerView = new EUiViewName("MotorParkourTimerView");

		// Token: 0x04019308 RID: 103176
		public static readonly EUiViewName CoopRoleSelectView = new EUiViewName("CoopRoleSelectView");

		// Token: 0x04019309 RID: 103177
		public static readonly EUiViewName CoopEntranceView = new EUiViewName("CoopEntranceView");

		// Token: 0x0401930A RID: 103178
		public static readonly EUiViewName CoopUpGrateView = new EUiViewName("CoopUpGrateView");

		// Token: 0x0401930B RID: 103179
		public static readonly EUiViewName CoopSpRewardView = new EUiViewName("CoopSpRewardView");

		// Token: 0x0401930C RID: 103180
		public static readonly EUiViewName CoopPhotoPreviewView = new EUiViewName("CoopPhotoPreviewView");

		// Token: 0x0401930D RID: 103181
		public static readonly EUiViewName RollBlockView = new EUiViewName("RollBlockView");

		// Token: 0x0401930E RID: 103182
		public static readonly EUiViewName PhantomInteractSummonView = new EUiViewName("PhantomInteractSummonView");

		// Token: 0x0401930F RID: 103183
		public static readonly EUiViewName PhantomInteractEditView = new EUiViewName("PhantomInteractEditView");

		// Token: 0x04019310 RID: 103184
		public static readonly EUiViewName ActivityNewPlayerSupportTrialRoleView = new EUiViewName("ActivityNewPlayerSupportTrialRoleView");

		// Token: 0x04019311 RID: 103185
		public static readonly EUiViewName ActivityNewPlayerSupportRewardView = new EUiViewName("ActivityNewPlayerSupportRewardView");

		// Token: 0x04019312 RID: 103186
		public static readonly EUiViewName ActivityNewPlayerSupportStartupView = new EUiViewName("ActivityNewPlayerSupportStartupView");

		// Token: 0x04019313 RID: 103187
		public static readonly EUiViewName NewPlayerAdventureV2View = new EUiViewName("NewPlayerAdventureV2View");

		// Token: 0x04019314 RID: 103188
		public static readonly EUiViewName MotorcycleArrowCollectionSelectView = new EUiViewName("MotorcycleArrowCollectionSelectView");

		// Token: 0x04019315 RID: 103189
		public static readonly EUiViewName MotorFightMainView = new EUiViewName("MotorFightMainView");

		// Token: 0x04019316 RID: 103190
		public static readonly EUiViewName MotorcycleArrowCollectionTipsView = new EUiViewName("MotorcycleArrowCollectionTipsView");

		// Token: 0x04019317 RID: 103191
		public static readonly EUiViewName MotorFightRewardView = new EUiViewName("MotorFightRewardView");

		// Token: 0x04019318 RID: 103192
		public static readonly EUiViewName MotorFightHandBookView = new EUiViewName("MotorFightHandBookView");

		// Token: 0x04019319 RID: 103193
		public static readonly EUiViewName MotorFightTalentTreeView = new EUiViewName("MotorFightTalentTreeView");

		// Token: 0x0401931A RID: 103194
		public static readonly EUiViewName MotorFightRankView = new EUiViewName("MotorFightRankView");

		// Token: 0x0401931B RID: 103195
		public static readonly EUiViewName MotorFightRankDetailView = new EUiViewName("MotorFightRankDetailView");

		// Token: 0x0401931C RID: 103196
		public static readonly EUiViewName MotorFightLevelDetailView = new EUiViewName("MotorFightLevelDetailView");

		// Token: 0x0401931D RID: 103197
		public static readonly EUiViewName MotorFightRoleSelectView = new EUiViewName("MotorFightRoleSelectView");

		// Token: 0x0401931E RID: 103198
		public static readonly EUiViewName MotorFightSuccessView = new EUiViewName("MotorFightSuccessView");

		// Token: 0x0401931F RID: 103199
		public static readonly EUiViewName MotorFightFailView = new EUiViewName("MotorFightFailView");

		// Token: 0x04019320 RID: 103200
		public static readonly EUiViewName MotorFightPauseView = new EUiViewName("MotorFightPauseView");

		// Token: 0x04019321 RID: 103201
		public static readonly EUiViewName MotorFightArchiveTip = new EUiViewName("MotorFightArchiveTip");

		// Token: 0x04019322 RID: 103202
		public static readonly EUiViewName MotorFightAttrDetailView = new EUiViewName("MotorFightAttrDetailView");

		// Token: 0x04019323 RID: 103203
		public static readonly EUiViewName MotorFightItemTips = new EUiViewName("MotorFightItemTips");

		// Token: 0x04019324 RID: 103204
		public static readonly EUiViewName SpringManorAtmosphereLevelView = new EUiViewName("Spring26AtmosphereLevelView");

		// Token: 0x04019325 RID: 103205
		public static readonly EUiViewName SpringManorRewardView = new EUiViewName("Spring26RewardView");

		// Token: 0x04019326 RID: 103206
		public static readonly EUiViewName SpringManorQuestView = new EUiViewName("Spring26QuestView");

		// Token: 0x04019327 RID: 103207
		public static readonly EUiViewName SpringManorLoadingView = new EUiViewName("Spring26LoadingView");

		// Token: 0x04019328 RID: 103208
		public static readonly EUiViewName SpringManorHudView = new EUiViewName("Spring26HudView");

		// Token: 0x04019329 RID: 103209
		public static readonly EUiViewName SpringManorGameplayEntryView = new EUiViewName("Spring26GameplayEntryView");

		// Token: 0x0401932A RID: 103210
		public static readonly EUiViewName SpringManorAtmosphereLevelUpView = new EUiViewName("Spring26AtmosphereLevelUpView");

		// Token: 0x0401932B RID: 103211
		public static readonly EUiViewName SpringManorUnlockView = new EUiViewName("Spring26UnlockView");

		// Token: 0x0401932C RID: 103212
		public static readonly EUiViewName SpringManorWeaponExhibitView = new EUiViewName("Spring26WeaponExhibitView");

		// Token: 0x0401932D RID: 103213
		public static readonly EUiViewName SpringManorPhantomExhibitView = new EUiViewName("Spring26PhantomExhibitView");

		// Token: 0x0401932E RID: 103214
		public static readonly EUiViewName SpringManorActivityOpenView = new EUiViewName("Spring26ActivityOpenView");

		// Token: 0x0401932F RID: 103215
		public static readonly EUiViewName SpringManorRoleSwitchView = new EUiViewName("Spring26RoleSelectView");

		// Token: 0x04019330 RID: 103216
		public static readonly EUiViewName RegressBpMainView = new EUiViewName("RegressBpMainView");

		// Token: 0x04019331 RID: 103217
		public static readonly EUiViewName RegressBpBuyLevelView = new EUiViewName("RegressBpBuyLevelView");

		// Token: 0x04019332 RID: 103218
		public static readonly EUiViewName RegressBpPayView = new EUiViewName("RegressBpPayView");

		// Token: 0x04019333 RID: 103219
		public static readonly EUiViewName RegressBpLevelUpTipsView = new EUiViewName("RegressBpLevelUpTipsView");

		// Token: 0x04019334 RID: 103220
		public static readonly EUiViewName FindSunSpiritView = new EUiViewName("FindSunSpiritView");

		// Token: 0x04019335 RID: 103221
		public static readonly EUiViewName RhythmShipCalibrationView = new EUiViewName("RhythmShipCalibrationView");

		// Token: 0x04019336 RID: 103222
		public static readonly EUiViewName RhythmShipChoseLevelView = new EUiViewName("RhythmShipChoseLevelView");

		// Token: 0x04019337 RID: 103223
		public static readonly EUiViewName RhythmShipQuickSelectLevelView = new EUiViewName("RhythmShipQuickSelectLevelView");

		// Token: 0x04019338 RID: 103224
		public static readonly EUiViewName RhythmShipChoseRoleView = new EUiViewName("RhythmShipChoseRoleView");

		// Token: 0x04019339 RID: 103225
		public static readonly EUiViewName RhythmShipRatingView = new EUiViewName("RhythmShipRatingView");

		// Token: 0x0401933A RID: 103226
		public static readonly EUiViewName RhythmShipTaskView = new EUiViewName("RhythmShipTaskView");

		// Token: 0x0401933B RID: 103227
		public static readonly EUiViewName RhythmShipLimitTaskView = new EUiViewName("RhythmShipLimitTaskView");

		// Token: 0x0401933C RID: 103228
		public static readonly EUiViewName RhythmShipSettlementView = new EUiViewName("RhythmShipSettlementView");

		// Token: 0x0401933D RID: 103229
		public static readonly EUiViewName RhythmShipPauseView = new EUiViewName("RhythmShipPauseView");

		// Token: 0x0401933E RID: 103230
		public static readonly EUiViewName RhythmShipSetView = new EUiViewName("RhythmShipSetView");

		// Token: 0x0401933F RID: 103231
		public static readonly EUiViewName RhythmShipSetTipsView = new EUiViewName("RhythmShipSetTipsView");

		// Token: 0x04019340 RID: 103232
		public static readonly EUiViewName RhythmShipGameView = new EUiViewName("RhythmShipGameView");

		// Token: 0x04019341 RID: 103233
		public static readonly EUiViewName RhythmShipGameEndTipView = new EUiViewName("RhythmShipGameEndTipView");

		// Token: 0x04019342 RID: 103234
		public static readonly EUiViewName TetrisPlayView = new EUiViewName("TetrisPlayView");

		// Token: 0x04019343 RID: 103235
		public static readonly EUiViewName TetrisLevelDetailView = new EUiViewName("TetrisLevelDetailView");

		// Token: 0x04019344 RID: 103236
		public static readonly EUiViewName TetrisSelectLevelView = new EUiViewName("TetrisSelectLevelView");

		// Token: 0x04019345 RID: 103237
		public static readonly EUiViewName TetrisTipsWinView = new EUiViewName("TetrisTipsWinView");

		// Token: 0x04019346 RID: 103238
		public static readonly EUiViewName TetrisTipsTargetView = new EUiViewName("TetrisTipsTargetView");

		// Token: 0x04019347 RID: 103239
		public static readonly EUiViewName TetrisTipsLoseView = new EUiViewName("TetrisTipsLoseView");

		// Token: 0x04019348 RID: 103240
		public static readonly EUiViewName TetrisTipsEndLessEndView = new EUiViewName("TetrisTipsEndLessEndView");

		// Token: 0x04019349 RID: 103241
		public static readonly EUiViewName TetrisTipsEndLessStartView = new EUiViewName("TetrisTipsEndLessStartView");

		// Token: 0x0401934A RID: 103242
		public static readonly EUiViewName TetrisLoadingView = new EUiViewName("TetrisLoadingView");

		// Token: 0x0401934B RID: 103243
		public static readonly EUiViewName ChatPopView = new EUiViewName("ChatPopView");

		// Token: 0x0401934C RID: 103244
		public static readonly EUiViewName MenuDetailPopView = new EUiViewName("MenuDetailPopView");

		// Token: 0x0401934D RID: 103245
		public static readonly EUiViewName FlagChallengeRewardView = new EUiViewName("FlagChallengeRewardView");

		// Token: 0x0401934E RID: 103246
		public static readonly EUiViewName FlagChallengeSelectRoleView = new EUiViewName("FlagChallengeSelectRoleView");

		// Token: 0x0401934F RID: 103247
		public static readonly EUiViewName FlagChallengeBuffView = new EUiViewName("FlagChallengeBuffView");

		// Token: 0x04019350 RID: 103248
		public static readonly EUiViewName FlagChallengeOccupiedSuccessView = new EUiViewName("FlagChallengeOccupiedSuccessView");

		// Token: 0x04019351 RID: 103249
		public static readonly EUiViewName FlagChallengeSettleView = new EUiViewName("FlagChallengeSettleView");

		// Token: 0x04019352 RID: 103250
		public static readonly EUiViewName FlagChallengeReviveView = new EUiViewName("FlagChallengeReviveView");

		// Token: 0x04019353 RID: 103251
		public static readonly EUiViewName FlagChallengePauseView = new EUiViewName("FlagChallengePauseView");

		// Token: 0x04019354 RID: 103252
		public static readonly EUiViewName FlagChallengeMainView = new EUiViewName("FlagChallengeMainView");

		// Token: 0x04019355 RID: 103253
		public static readonly EUiViewName FlagChallengeAreaDetailView = new EUiViewName("FlagChallengeAreaDetailView");

		// Token: 0x04019356 RID: 103254
		public static readonly EUiViewName FlagChallengeBuffActiveTips = new EUiViewName("FlagChallengeBuffActiveTips");

		// Token: 0x04019357 RID: 103255
		public static readonly EUiViewName FlagChallengePrompt = new EUiViewName("FlagChallengePrompt");

		// Token: 0x04019358 RID: 103256
		public static readonly EUiViewName PhantomFilterPopupView = new EUiViewName("PhantomFilterPopupView");

		// Token: 0x04019359 RID: 103257
		public static readonly EUiViewName PhantomBatchConfirmPopupView = new EUiViewName("PhantomBatchConfirmPopupView");

		// Token: 0x0401935A RID: 103258
		public static readonly EUiViewName PhantomMainPropertyPopupView = new EUiViewName("PhantomMainPropertyPopupView");

		// Token: 0x0401935B RID: 103259
		public static readonly EUiViewName PhantomSmartDiscardPopupView = new EUiViewName("PhantomSmartDiscardPopupView");

		// Token: 0x0401935C RID: 103260
		public static readonly EUiViewName PhantomStackCountPopupView = new EUiViewName("PhantomStackCountPopupView");

		// Token: 0x0401935D RID: 103261
		public static readonly EUiViewName WheelTowerRoundSelectView = new EUiViewName("WheelTowerRoundSelectView");

		// Token: 0x0401935E RID: 103262
		public static readonly EUiViewName WheelTowerBuffSelectView = new EUiViewName("WheelTowerBuffSelectView");

		// Token: 0x0401935F RID: 103263
		public static readonly EUiViewName WheelTowerTeamSelectView = new EUiViewName("WheelTowerTeamSelectView");

		// Token: 0x04019360 RID: 103264
		public static readonly EUiViewName WheelTowerModeSelectView = new EUiViewName("WheelTowerModeSelectView");

		// Token: 0x04019361 RID: 103265
		public static readonly EUiViewName WheelTowerResultView = new EUiViewName("WheelTowerResultView");

		// Token: 0x04019362 RID: 103266
		public static readonly EUiViewName WheelTowerRewardView = new EUiViewName("WheelTowerRewardView");

		// Token: 0x04019363 RID: 103267
		public static readonly EUiViewName WheelTowerRecordPopup = new EUiViewName("WheelTowerRecordPopup");

		// Token: 0x04019364 RID: 103268
		public static readonly EUiViewName WheelTowerRoundTipsView = new EUiViewName("WheelTowerRoundTipsView");

		// Token: 0x04019365 RID: 103269
		public static readonly EUiViewName WheelTowerMainView = new EUiViewName("WheelTowerMainView");

		// Token: 0x04019366 RID: 103270
		public static readonly EUiViewName WheelTowerModeDetailView = new EUiViewName("WheelTowerModeDetailView");

		// Token: 0x04019367 RID: 103271
		public static readonly EUiViewName WheelTowerPrepareView = new EUiViewName("WheelTowerPrepareView");

		// Token: 0x04019368 RID: 103272
		public static readonly EUiViewName WheelTowerEnhanceRoleView = new EUiViewName("WheelTowerEnhanceRoleView");

		// Token: 0x04019369 RID: 103273
		public static readonly EUiViewName WheelTowerRecordView = new EUiViewName("WheelTowerRecordView");

		// Token: 0x0401936A RID: 103274
		public static readonly EUiViewName WheelTowerScoreLevelRuleView = new EUiViewName("WheelTowerScoreLevelRuleView");

		// Token: 0x0401936B RID: 103275
		public static readonly EUiViewName WheelTowerRecommendView = new EUiViewName("WheelTowerRecommendView");

		// Token: 0x0401936C RID: 103276
		public static readonly EUiViewName WheelTowerBossBuffTip = new EUiViewName("WheelTowerBossBuffTip");

		// Token: 0x0401936D RID: 103277
		public static readonly EUiViewName WheelTowerLoadingView = new EUiViewName("WheelTowerLoadingView");

		// Token: 0x0401936E RID: 103278
		public static readonly EUiViewName WheelTowerSettlementView = new EUiViewName("WheelTowerSettlementView");

		// Token: 0x0401936F RID: 103279
		public static readonly EUiViewName WheelTowerBossHandBookView = new EUiViewName("WheelTowerBossHandBookView");

		// Token: 0x04019370 RID: 103280
		public static readonly EUiViewName WheelTowerLimitRewardView = new EUiViewName("WheelTowerLimitRewardView");

		// Token: 0x04019371 RID: 103281
		public static readonly EUiViewName WheelTowerSeasonRewardView = new EUiViewName("WheelTowerSeasonRewardView");

		// Token: 0x04019372 RID: 103282
		public static readonly EUiViewName WheelTowerCoverRecordPopupView = new EUiViewName("WheelTowerCoverRecordPopupView");

		// Token: 0x04019373 RID: 103283
		public static readonly EUiViewName WheelTowerReviewView = new EUiViewName("WheelTowerReviewView");

		// Token: 0x04019374 RID: 103284
		public static readonly EUiViewName RoleSkillBranchPopView = new EUiViewName("RoleSkillBranchPopView");

		// Token: 0x04019375 RID: 103285
		public static readonly EUiViewName ProjectorPuzzleView = new EUiViewName("ProjectorPuzzleView");

		// Token: 0x04019376 RID: 103286
		public static readonly EUiViewName AdamSmasherSelectView = new EUiViewName("AdamSmasherSelectView");

		// Token: 0x04019377 RID: 103287
		public static readonly EUiViewName AdamSmasherFormationView = new EUiViewName("AdamSmasherFormationView");

		// Token: 0x04019378 RID: 103288
		public static readonly EUiViewName AdamSmasherChallengeFailView = new EUiViewName("AdamSmasherChallengeFailView");

		// Token: 0x04019379 RID: 103289
		public static readonly EUiViewName CyberPunkTrialRoleView = new EUiViewName("CyberPunkTrialRoleView");

		// Token: 0x0401937A RID: 103290
		public static readonly EUiViewName CyberPunkTaskView = new EUiViewName("CyberPunkTaskView");

		// Token: 0x0401937B RID: 103291
		public static readonly EUiViewName RoleDevelopWorldDropEnoughTips = new EUiViewName("RoleDevelopWorldDropEnoughTips");

		// Token: 0x0401937C RID: 103292
		public static readonly EUiViewName TetrisGameView = new EUiViewName("TetrisGameView");

		// Token: 0x0401937D RID: 103293
		public static readonly EUiViewName TetrisSettlementView = new EUiViewName("TetrisSettlementView");

		// Token: 0x0401937E RID: 103294
		public static readonly EUiViewName TetrisGameLoading = new EUiViewName("TetrisGameLoading");

		// Token: 0x0401937F RID: 103295
		public static readonly EUiViewName WuWuLogisticsMissionView = new EUiViewName("WuWuLogisticsMissionView");

		// Token: 0x04019380 RID: 103296
		public static readonly EUiViewName CyberpunkCountDownView = new EUiViewName("CyberpunkCountDownView");

		// Token: 0x04019381 RID: 103297
		public static readonly EUiViewName CommonComicView = new EUiViewName("CommonComicView");

		// Token: 0x04019382 RID: 103298
		public static readonly EUiViewName PinballComicView = new EUiViewName("PinballComicView");

		// Token: 0x04019383 RID: 103299
		public static readonly EUiViewName BossPilingMainView = new EUiViewName("BossPilingMainView");

		// Token: 0x04019384 RID: 103300
		public static readonly EUiViewName BossPilingLevelView = new EUiViewName("BossPilingLevelView");

		// Token: 0x04019385 RID: 103301
		public static readonly EUiViewName BossPilingBuffView = new EUiViewName("BossPilingBuffView");

		// Token: 0x04019386 RID: 103302
		public static readonly EUiViewName BossPilingLevelDescView = new EUiViewName("BossPilingLevelDescView");

		// Token: 0x04019387 RID: 103303
		public static readonly EUiViewName BossPilingTaskView = new EUiViewName("BossPilingTaskView");

		// Token: 0x04019388 RID: 103304
		public static readonly EUiViewName BossPilingSettleView = new EUiViewName("BossPilingSettleView");

		// Token: 0x04019389 RID: 103305
		public static readonly EUiViewName BossPilingKeyBuffFloatView = new EUiViewName("BossPilingKeyBuffFloatView");

		// Token: 0x0401938A RID: 103306
		public static readonly EUiViewName BossPilingNewBuffTipsView = new EUiViewName("BossPilingNewBuffTipsView");

		// Token: 0x0401938B RID: 103307
		public static readonly EUiViewName PinballRoleGainView = new EUiViewName("PinballRoleGainView");

		// Token: 0x0401938C RID: 103308
		public static readonly EUiViewName PinballSettleResultView = new EUiViewName("PinballSettleResultView");

		// Token: 0x0401938D RID: 103309
		public static readonly EUiViewName PinballPlotView = new EUiViewName("PinballPlotView");

		// Token: 0x0401938E RID: 103310
		public static readonly EUiViewName PinballMainRootView = new EUiViewName("PinballMainRootView");

		// Token: 0x0401938F RID: 103311
		public static readonly EUiViewName PinballWeaponDecomposeView = new EUiViewName("PinballWeaponDecomposeView");

		// Token: 0x04019390 RID: 103312
		public static readonly EUiViewName PinballRevivePopupView = new EUiViewName("PinballRevivePopupView");

		// Token: 0x04019391 RID: 103313
		public static readonly EUiViewName PinballRoleView = new EUiViewName("PinballRoleView");

		// Token: 0x04019392 RID: 103314
		public static readonly EUiViewName PinballShopView = new EUiViewName("PinballShopView");

		// Token: 0x04019393 RID: 103315
		public static readonly EUiViewName PinballLimitedRewardView = new EUiViewName("PinballLimitedRewardView");

		// Token: 0x04019394 RID: 103316
		public static readonly EUiViewName PinballPermanentRewardView = new EUiViewName("PinballPermanentRewardView");

		// Token: 0x04019395 RID: 103317
		public static readonly EUiViewName PinballRankView = new EUiViewName("PinballRankView");

		// Token: 0x04019396 RID: 103318
		public static readonly EUiViewName PinballExchangePopView = new EUiViewName("PinballExchangePopView");

		// Token: 0x04019397 RID: 103319
		public static readonly EUiViewName PinballWeaponEquipView = new EUiViewName("PinballWeaponEquipView");

		// Token: 0x04019398 RID: 103320
		public static readonly EUiViewName PinballFilterView = new EUiViewName("PinballFilterView");

		// Token: 0x04019399 RID: 103321
		public static readonly EUiViewName PinballMainHelpView = new EUiViewName("PinballMainHelpView");

		// Token: 0x0401939A RID: 103322
		public static readonly EUiViewName ActivityUnlockTipCatapultStoryView = new EUiViewName("ActivityUnlockTipCatapultStoryView");

		// Token: 0x0401939B RID: 103323
		public static readonly EUiViewName PinballBubbleView = new EUiViewName("PinballBubbleView");

		// Token: 0x0401939C RID: 103324
		public static readonly EUiViewName PinballBattlePauseView = new EUiViewName("PinballBattlePauseView");

		// Token: 0x0401939D RID: 103325
		public static readonly EUiViewName PinballBossComingTipsView = new EUiViewName("PinballBossComingTipsView");

		// Token: 0x0401939E RID: 103326
		public static readonly EUiViewName PinballFailureTipsView = new EUiViewName("PinballFailureTipsView");

		// Token: 0x0401939F RID: 103327
		public static readonly EUiViewName PinballRoleSkillReleaseTipsView = new EUiViewName("PinballRoleSkillReleaseTipsView");

		// Token: 0x040193A0 RID: 103328
		public static readonly EUiViewName PinballSuccessTipsView = new EUiViewName("PinballSuccessTipsView");

		// Token: 0x040193A1 RID: 103329
		public static readonly EUiViewName PinballBossSkillTipsView = new EUiViewName("PinballBossSkillTipsView");

		// Token: 0x040193A2 RID: 103330
		public static readonly EUiViewName PinballRoleSkillMaxTipsView = new EUiViewName("PinballRoleSkillMaxTipsView");

		// Token: 0x040193A3 RID: 103331
		public static readonly EUiViewName PinballWaveStartTipsView = new EUiViewName("PinballWaveStartTipsView");

		// Token: 0x040193A4 RID: 103332
		public static readonly EUiViewName PinballWeaponDecomposeResultView = new EUiViewName("PinballWeaponDecomposeResultView");

		// Token: 0x040193A5 RID: 103333
		public static readonly EUiViewName PinballRoleSelectView = new EUiViewName("PinballRoleSelectView");

		// Token: 0x040193A6 RID: 103334
		public static readonly EUiViewName PinballFormationSelectRoleView = new EUiViewName("PinballFormationSelectRoleView");

		// Token: 0x040193A7 RID: 103335
		public static readonly EUiViewName PinballAttributeDetailView = new EUiViewName("PinballAttributeDetailView");

		// Token: 0x040193A8 RID: 103336
		public static readonly EUiViewName PinballFormationView = new EUiViewName("PinballFormationView");

		// Token: 0x040193A9 RID: 103337
		public static readonly EUiViewName PinballMonsterDetailView = new EUiViewName("PinballMonsterDetailView");

		// Token: 0x040193AA RID: 103338
		public static readonly EUiViewName PinballLoadingView = new EUiViewName("PinballLoadingView");

		// Token: 0x040193AB RID: 103339
		public static readonly EUiViewName SplineConstrainedDrag = new EUiViewName("SplineConstrainedDrag");

		// Token: 0x040193AC RID: 103340
		public static readonly EUiViewName DollGrabMachineView = new EUiViewName("DollGrabMachineView");

		// Token: 0x040193AD RID: 103341
		public static readonly EUiViewName DollGrabShowcaseInspectView = new EUiViewName("DollGrabShowcaseInspectView");

		// Token: 0x040193AE RID: 103342
		public static readonly EUiViewName DollGrabShowcaseFocusView = new EUiViewName("DollGrabShowcaseFocusView");

		// Token: 0x040193AF RID: 103343
		public static readonly EUiViewName DollGrabMachineCountDownView = new EUiViewName("DollGrabMachineCountDownView");

		// Token: 0x040193B0 RID: 103344
		public static readonly EUiViewName DollGrabFloatCountDownView = new EUiViewName("DollGrabFloatCountDownView");

		// Token: 0x040193B1 RID: 103345
		public static readonly EUiViewName DollGrabMachineTimeUpView = new EUiViewName("DollGrabMachineTimeUpView");

		// Token: 0x040193B2 RID: 103346
		public static readonly EUiViewName DollGrabMachineGetAllView = new EUiViewName("DollGrabMachineGetAllView");

		// Token: 0x040193B3 RID: 103347
		public static readonly EUiViewName DollGrabMachineSeltView = new EUiViewName("DollGrabMachineSeltView");

		// Token: 0x040193B4 RID: 103348
		public static readonly EUiViewName DollGrabMachinePauseView = new EUiViewName("DollGrabMachinePauseView");

		// Token: 0x040193B5 RID: 103349
		public static readonly EUiViewName DollGrabMachineHelpInfoView = new EUiViewName("DollGrabMachineHelpInfoView");

		// Token: 0x040193B6 RID: 103350
		public static readonly EUiViewName DollGrabDeliveryView = new EUiViewName("DollGrabDeliveryView");

		// Token: 0x040193B7 RID: 103351
		public static readonly EUiViewName DollGrabEndlessStartView = new EUiViewName("DollGrabEndlessStartView");

		// Token: 0x040193B8 RID: 103352
		public static readonly EUiViewName MachineryFactoryTouchMoveView = new EUiViewName("MachineryFactoryTouchMoveView");

		// Token: 0x040193B9 RID: 103353
		public static readonly EUiViewName MengZhouCollectView = new EUiViewName("MengZhouCollectView");

		// Token: 0x040193BA RID: 103354
		public static readonly EUiViewName RealmBetweenMainView = new EUiViewName("RealmBetweenMainView");

		// Token: 0x040193BB RID: 103355
		public static readonly EUiViewName RealmBetweenTravelTaskView = new EUiViewName("RealmBetweenTravelTaskView");

		// Token: 0x040193BC RID: 103356
		public static readonly EUiViewName RealmBetweenPhantomTaskView = new EUiViewName("RealmBetweenPhantomTaskView");

		// Token: 0x040193BD RID: 103357
		public static readonly EUiViewName RealmBetweenVehicleTaskView = new EUiViewName("RealmBetweenVehicleTaskView");

		// Token: 0x040193BE RID: 103358
		public static readonly EUiViewName RealmBetweenLevelTipsView = new EUiViewName("RealmBetweenLevelTipsView");

		// Token: 0x040193BF RID: 103359
		public static readonly EUiViewName ActivityUnlockTipRealmBetweenView = new EUiViewName("ActivityUnlockTipRealmBetweenView");

		// Token: 0x040193C0 RID: 103360
		public static readonly EUiViewName WriteLetterView = new EUiViewName("WriteLetterView");

		// Token: 0x040193C1 RID: 103361
		public static readonly EUiViewName LetterBackupDisplayView = new EUiViewName("LetterBackupDisplayView");

		// Token: 0x040193C2 RID: 103362
		public static readonly EUiViewName ProjectionPhotoView = new EUiViewName("ProjectionPhotoView");

		// Token: 0x040193C3 RID: 103363
		public static readonly EUiViewName GolemHackingGameView = new EUiViewName("GolemHackingGameView");

		// Token: 0x040193C4 RID: 103364
		public static readonly EUiViewName GolemHackingGameTipsPopView = new EUiViewName("GolemHackingGameTipsPopView");

		// Token: 0x040193C5 RID: 103365
		public static readonly EUiViewName GolemHackingResultPop = new EUiViewName("GolemHackingResultPop");

		// Token: 0x040193C6 RID: 103366
		public static readonly EUiViewName GolemHackingLevelMainView = new EUiViewName("GolemHackingLevelMainView");

		// Token: 0x040193C7 RID: 103367
		public static readonly EUiViewName GolemHackingLevelDetailView = new EUiViewName("GolemHackingLevelDetailView");

		// Token: 0x040193C8 RID: 103368
		public static readonly EUiViewName GachaAccumulateBonusView = new EUiViewName("GachaAccumulateBonusView");

		// Token: 0x040193C9 RID: 103369
		public static readonly EUiViewName ItemRewardSelectView = new EUiViewName("ItemRewardSelectView");

		// Token: 0x040193CA RID: 103370
		public static readonly EUiViewName ItemConvertTipsView = new EUiViewName("ItemConvertTipsView");

		// Token: 0x040193CB RID: 103371
		public static readonly EUiViewName ItemExpiredAutoConvertTipsView = new EUiViewName("ItemExpiredAutoConvertTipsView");

		// Token: 0x040193CC RID: 103372
		public static readonly EUiViewName CommonQuickHackView = new EUiViewName("CommonQuickHackView");

		// Token: 0x040193CD RID: 103373
		public static readonly EUiViewName BattleQuickHackView = new EUiViewName("BattleQuickHackView");

		// Token: 0x040193CE RID: 103374
		public static readonly EUiViewName QuickHackCameraControlView = new EUiViewName("QuickHackCameraControlView");

		// Token: 0x040193CF RID: 103375
		public static readonly EUiViewName MotorDecalLinkRewardView = new EUiViewName("MotorDecalLinkRewardView");

		// Token: 0x040193D0 RID: 103376
		public static readonly EUiViewName PlotWordArtView = new EUiViewName("PlotWordArtView");

		// Token: 0x040193D1 RID: 103377
		public static readonly EUiViewName PlotWordArtCaptionView = new EUiViewName("PlotWordArtCaptionView");

		// Token: 0x040193D2 RID: 103378
		public static readonly EUiViewName MultiMotorMainView = new EUiViewName("MultiMotorMainView");

		// Token: 0x040193D3 RID: 103379
		public static readonly EUiViewName MultiMotorChoseLevelView = new EUiViewName("MultiMotorChoseLevelView");

		// Token: 0x040193D4 RID: 103380
		public static readonly EUiViewName MultiMotorSettlementView = new EUiViewName("MultiMotorSettlementView");

		// Token: 0x040193D5 RID: 103381
		public static readonly EUiViewName MultiMotorRewardView = new EUiViewName("MultiMotorRewardView");

		// Token: 0x040193D6 RID: 103382
		public static readonly EUiViewName MoonTogetherMainView = new EUiViewName("MoonTogetherMainView");

		// Token: 0x040193D7 RID: 103383
		public static readonly EUiViewName MoonTogetherInviteView = new EUiViewName("MoonTogetherInviteView");

		// Token: 0x040193D8 RID: 103384
		public static readonly EUiViewName QteHourglassView = new EUiViewName("QteHourglassView");

		// Token: 0x040193D9 RID: 103385
		public static readonly EUiViewName QuestMultiLineView = new EUiViewName("QuestMultiLineView");

		// Token: 0x040193DA RID: 103386
		public static readonly EUiViewName FirstPersonTurretView = new EUiViewName("FirstPersonTurretView");

		// Token: 0x040193DB RID: 103387
		public static readonly EUiViewName QuestMultiLineTipsView = new EUiViewName("QuestMultiLineTipsView");

		// Token: 0x040193DC RID: 103388
		public static readonly EUiViewName NewcomerSplashView = new EUiViewName("NewcomerSplashView");

		// Token: 0x040193DD RID: 103389
		public static readonly EUiViewName NewcomerJourneyChoseRoleView = new EUiViewName("NewcomerJourneyChoseRoleView");

		// Token: 0x040193DE RID: 103390
		public static readonly EUiViewName WuWaGoView = new EUiViewName("WuWaGoView");

		// Token: 0x040193DF RID: 103391
		public static readonly EUiViewName WuWaGoPauseView = new EUiViewName("WuWaGoPauseView");

		// Token: 0x040193E0 RID: 103392
		public static readonly EUiViewName WuWaGoPopupView = new EUiViewName("WuWaGoPopupView");

		// Token: 0x040193E1 RID: 103393
		public static readonly EUiViewName WheelTowerMedalDetailView = new EUiViewName("WheelTowerMedalDetailView");

		// Token: 0x040193E2 RID: 103394
		public static readonly EUiViewName WheelTowerSeasonMedalView = new EUiViewName("WheelTowerSeasonMedalView");

		// Token: 0x040193E3 RID: 103395
		public static readonly EUiViewName WheelTowerSeasonOverviewView = new EUiViewName("WheelTowerSeasonOverviewView");

		// Token: 0x040193E4 RID: 103396
		public static readonly EUiViewName WheelTowerSeasonReviewView = new EUiViewName("WheelTowerSeasonReviewView");

		// Token: 0x040193E5 RID: 103397
		public static readonly EUiViewName WheelTowerMedalRuleView = new EUiViewName("WheelTowerMedalRuleView");

		// Token: 0x040193E6 RID: 103398
		public static readonly EUiViewName SheriffMainView = new EUiViewName("SheriffMainView");

		// Token: 0x040193E7 RID: 103399
		public static readonly EUiViewName SheriffReportPop = new EUiViewName("SheriffReportPop");

		// Token: 0x040193E8 RID: 103400
		public static readonly EUiViewName SheriffAnalysisResultPop = new EUiViewName("SheriffAnalysisResultPop");

		// Token: 0x040193E9 RID: 103401
		public static readonly EUiViewName SheriffShowClueViewPop = new EUiViewName("SheriffShowClueViewPop");

		// Token: 0x040193EA RID: 103402
		public static readonly EUiViewName SheriffShopView = new EUiViewName("SheriffShopView");

		// Token: 0x040193EB RID: 103403
		public static readonly EUiViewName SheriffStartTrackPopupView = new EUiViewName("SheriffStartTrackPopupView");

		// Token: 0x040193EC RID: 103404
		public static readonly EUiViewName SheriffArrestPopupView = new EUiViewName("SheriffArrestPopupView");

		// Token: 0x040193ED RID: 103405
		public static readonly EUiViewName SheriffCriminalIdentityConfirmedView = new EUiViewName("SheriffCriminalIdentityConfirmedView");

		// Token: 0x040193EE RID: 103406
		public static readonly EUiViewName SheriffErrorView = new EUiViewName("SheriffErrorView");

		// Token: 0x040193EF RID: 103407
		public static readonly EUiViewName GuQinActivityMainView = new EUiViewName("GuQinActivityMainView");

		// Token: 0x040193F0 RID: 103408
		public static readonly EUiViewName ChineseZitherView = new EUiViewName("ChineseZitherView");

		// Token: 0x040193F1 RID: 103409
		public static readonly EUiViewName RoverlikeMainView = new EUiViewName("RoverlikeMainView");

		// Token: 0x040193F2 RID: 103410
		public static readonly EUiViewName RoverlikeShopView = new EUiViewName("RoverlikeShopView");

		// Token: 0x040193F3 RID: 103411
		public static readonly EUiViewName RoverlikeQuestRewardView = new EUiViewName("RoverlikeQuestRewardView");

		// Token: 0x040193F4 RID: 103412
		public static readonly EUiViewName RoverlikeHandBookView = new EUiViewName("RoverlikeHandBookView");

		// Token: 0x040193F5 RID: 103413
		public static readonly EUiViewName RoverlikeDetailView = new EUiViewName("RoverlikeDetailView");

		// Token: 0x040193F6 RID: 103414
		public static readonly EUiViewName RoverlikeRoleUnlockView = new EUiViewName("RoverlikeRoleUnlockView");

		// Token: 0x040193F7 RID: 103415
		public static readonly EUiViewName RoverlikeLevelSelectView = new EUiViewName("RoverlikeLevelSelectView");

		// Token: 0x040193F8 RID: 103416
		public static readonly EUiViewName RoverlikeTalentTreeView = new EUiViewName("RoverlikeTalentTreeView");

		// Token: 0x040193F9 RID: 103417
		public static readonly EUiViewName RoverlikeTalentTreeUnlockView = new EUiViewName("RoverlikeTalentTreeUnlockView");

		// Token: 0x040193FA RID: 103418
		public static readonly EUiViewName RoverlikeLootView = new EUiViewName("RoverlikeLootView");

		// Token: 0x040193FB RID: 103419
		public static readonly EUiViewName RoverlikeRoleSelectView = new EUiViewName("RoverlikeRoleSelectView");

		// Token: 0x040193FC RID: 103420
		public static readonly EUiViewName RoverlikeLootUnlockView = new EUiViewName("RoverlikeLootUnlockView");

		// Token: 0x040193FD RID: 103421
		public static readonly EUiViewName RoverlikeGeneralActionView = new EUiViewName("RoverlikeGeneralActionView");

		// Token: 0x040193FE RID: 103422
		public static readonly EUiViewName RoverlikeBlessingReplaceView = new EUiViewName("RoverlikeBlessingReplaceView");

		// Token: 0x040193FF RID: 103423
		public static readonly EUiViewName RoverlikeGeneralObtainView = new EUiViewName("RoverlikeGeneralObtainView");

		// Token: 0x04019400 RID: 103424
		public static readonly EUiViewName RoverlikeGameShopView = new EUiViewName("RoverlikeGameShopView");

		// Token: 0x04019401 RID: 103425
		public static readonly EUiViewName RoverlikePauseView = new EUiViewName("RoverlikePauseView");

		// Token: 0x04019402 RID: 103426
		public static readonly EUiViewName RoverlikeResultView = new EUiViewName("RoverlikeResultView");

		// Token: 0x04019403 RID: 103427
		public static readonly EUiViewName RoverlikeLevelTipsView = new EUiViewName("RoverlikeLevelTipsView");

		// Token: 0x04019404 RID: 103428
		public static readonly EUiViewName RoverlikeLootTipsView = new EUiViewName("RoverlikeLootTipsView");

		// Token: 0x04019405 RID: 103429
		public static readonly EUiViewName RoverlikeInfoTipsView = new EUiViewName("RoverlikeInfoTipsView");

		// Token: 0x04019406 RID: 103430
		public static readonly EUiViewName RoverlikeRoleBlessingTips = new EUiViewName("RoverlikeRoleBlessingTips");

		// Token: 0x04019407 RID: 103431
		public static readonly EUiViewName RoverlikeUnlockTipView = new EUiViewName("RoverlikeUnlockTipView");

		// Token: 0x04019408 RID: 103432
		public static readonly EUiViewName SwordControlGroundView = new EUiViewName("SwordControlGroundView");

		// Token: 0x04019409 RID: 103433
		public static readonly EUiViewName SwordControlFlightView = new EUiViewName("SwordControlFlightView");

		// Token: 0x0401940A RID: 103434
		public static readonly EUiViewName RecallFunctionView = new EUiViewName("RecallFunctionView");

		// Token: 0x0401940B RID: 103435
		public static readonly EUiViewName RecallLoadingView = new EUiViewName("RecallLoadingView");

		// Token: 0x0401940C RID: 103436
		public static readonly EUiViewName GiantSystemCollectView = new EUiViewName("GiantSystemCollectView");

		// Token: 0x0401940D RID: 103437
		public static readonly EUiViewName GiantSystemMainView = new EUiViewName("GiantSystemMainView");

		// Token: 0x0401940E RID: 103438
		public static readonly EUiViewName GiantSystemQuestView = new EUiViewName("GiantSystemQuestView");

		// Token: 0x0401940F RID: 103439
		public static readonly EUiViewName DangoBrawlBackpackView = new EUiViewName("DangoBrawlBackpackView");

		// Token: 0x04019410 RID: 103440
		public static readonly EUiViewName DangoBrawlBackpackShopRateView = new EUiViewName("DangoBrawlBackpackShopRateView");

		// Token: 0x04019411 RID: 103441
		public static readonly EUiViewName DangoBrawlMainView = new EUiViewName("DangoBrawlMainView");

		// Token: 0x04019412 RID: 103442
		public static readonly EUiViewName DangoBrawlShopView = new EUiViewName("DangoBrawlShopView");

		// Token: 0x04019413 RID: 103443
		public static readonly EUiViewName DangoBrawlShopExchangePopView = new EUiViewName("DangoBrawlShopExchangePopView");

		// Token: 0x04019414 RID: 103444
		public static readonly EUiViewName DangoBrawlConfirmBoxView = new EUiViewName("DangoBrawlConfirmBoxView");

		// Token: 0x04019415 RID: 103445
		public static readonly EUiViewName DangoBrawlLevelView = new EUiViewName("DangoBrawlLevelView");

		// Token: 0x04019416 RID: 103446
		public static readonly EUiViewName DangoBrawlLevelDetailView = new EUiViewName("DangoBrawlLevelDetailView");

		// Token: 0x04019417 RID: 103447
		public static readonly EUiViewName DangoBrawlHandBookView = new EUiViewName("DangoBrawlHandBookView");

		// Token: 0x04019418 RID: 103448
		public static readonly EUiViewName DangoBrawlHandBookFilterView = new EUiViewName("DangoBrawlHandBookFilterView");

		// Token: 0x04019419 RID: 103449
		public static readonly EUiViewName DangoBrawlRoleView = new EUiViewName("DangoBrawlRoleView");

		// Token: 0x0401941A RID: 103450
		public static readonly EUiViewName DangoBrawlRoleUnlockView = new EUiViewName("DangoBrawlRoleUnlockView");

		// Token: 0x0401941B RID: 103451
		public static readonly EUiViewName DangoBrawlRoleHandBookView = new EUiViewName("DangoBrawlRoleHandBookView");

		// Token: 0x0401941C RID: 103452
		public static readonly EUiViewName DangoBrawlCombineView = new EUiViewName("DangoBrawlCombineView");

		// Token: 0x0401941D RID: 103453
		public static readonly EUiViewName DangoBrawlPauseView = new EUiViewName("DangoBrawlPauseView");

		// Token: 0x0401941E RID: 103454
		public static readonly EUiViewName DangoBrawlLoadingView = new EUiViewName("DangoBrawlLoadingView");

		// Token: 0x0401941F RID: 103455
		public static readonly EUiViewName DangoBrawlSuccessSettleView = new EUiViewName("DangoBrawlSuccessSettleView");

		// Token: 0x04019420 RID: 103456
		public static readonly EUiViewName DangoBrawlFailSettleView = new EUiViewName("DangoBrawlFailureSettleView");

		// Token: 0x04019421 RID: 103457
		public static readonly EUiViewName DangoBrawlRoundSuccessSettleView = new EUiViewName("DangoBrawlRoundSuccessSettleView");

		// Token: 0x04019422 RID: 103458
		public static readonly EUiViewName DangoBrawlRoundFailureSettleView = new EUiViewName("DangoBrawlRoundFailureSettleView");

		// Token: 0x04019423 RID: 103459
		public static readonly EUiViewName DangoBrawlSettleRoleBagDetailView = new EUiViewName("DangoBrawlSettleRoleBagDetailView");

		// Token: 0x04019424 RID: 103460
		public static readonly EUiViewName DangoBrawlRewardsView = new EUiViewName("DangoBrawlRewardsView");

		// Token: 0x04019425 RID: 103461
		public static readonly EUiViewName DangoBrawlChooseCardView = new EUiViewName("DangoBrawlChooseCardView");

		// Token: 0x04019426 RID: 103462
		public static readonly EUiViewName DangoBrawlBuffDetailView = new EUiViewName("DangoBrawlBuffDetailView");

		// Token: 0x04019427 RID: 103463
		public static readonly EUiViewName ActivityUnlockTipDangoBrawlView = new EUiViewName("ActivityUnlockTipDangoBrawlView");

		// Token: 0x04019428 RID: 103464
		public static readonly EUiViewName DangoBrawlShopStateTips = new EUiViewName("DangoBrawlShopStateTips");

		// Token: 0x04019429 RID: 103465
		public static readonly EUiViewName FarmGoldInstanceEntranceView = new EUiViewName("FarmGoldInstanceEntranceView");

		// Token: 0x0401942A RID: 103466
		public static readonly EUiViewName MatchThreeTargetPopView = new EUiViewName("MatchThreeTargetPopView");

		// Token: 0x0401942B RID: 103467
		public static readonly EUiViewName MatchThreeGameplayView = new EUiViewName("MatchThreeGameplayView");

		// Token: 0x0401942C RID: 103468
		public static readonly EUiViewName MatchThreeSuccessPopView = new EUiViewName("MatchThreeSuccessPopView");

		// Token: 0x0401942D RID: 103469
		public static readonly EUiViewName MatchThreeFailPopView = new EUiViewName("MatchThreeFailPopView");

		// Token: 0x0401942E RID: 103470
		public static readonly EUiViewName MatchThreeSelectLevelView = new EUiViewName("MatchThreeSelectLevelView");

		// Token: 0x0401942F RID: 103471
		public static readonly EUiViewName MatchThreeLevelDetailView = new EUiViewName("MatchThreeLevelDetailView");

		// Token: 0x04019430 RID: 103472
		public static readonly EUiViewName MatchThreeRoleSelectView = new EUiViewName("MatchThreeRoleSelectView");

		// Token: 0x04019431 RID: 103473
		public static readonly EUiViewName MatchThreePopupInfoView = new EUiViewName("MatchThreePopupInfoView");

		// Token: 0x04019432 RID: 103474
		public static readonly EUiViewName MatchThreeConfirmBoxView = new EUiViewName("MatchThreeConfirmBoxView");
	}
}
