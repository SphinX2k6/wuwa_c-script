using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200410D RID: 16653
	public class ISequenceBtNodeT
	{
		// Token: 0x170075D8 RID: 30168
		// (get) Token: 0x060185EB RID: 99819 RVA: 0x003844C2 File Offset: 0x003826C2
		// (set) Token: 0x060185EC RID: 99820 RVA: 0x003844CA File Offset: 0x003826CA
		public EBtNode Type { get; set; }

		// Token: 0x170075D9 RID: 30169
		// (get) Token: 0x060185ED RID: 99821 RVA: 0x003844D3 File Offset: 0x003826D3
		// (set) Token: 0x060185EE RID: 99822 RVA: 0x003844DB File Offset: 0x003826DB
		public int Id { get; set; }

		// Token: 0x170075DA RID: 30170
		// (get) Token: 0x060185EF RID: 99823 RVA: 0x003844E4 File Offset: 0x003826E4
		// (set) Token: 0x060185F0 RID: 99824 RVA: 0x003844EC File Offset: 0x003826EC
		public string Desc { get; set; }

		// Token: 0x170075DB RID: 30171
		// (get) Token: 0x060185F1 RID: 99825 RVA: 0x003844F5 File Offset: 0x003826F5
		// (set) Token: 0x060185F2 RID: 99826 RVA: 0x003844FD File Offset: 0x003826FD
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x170075DC RID: 30172
		// (get) Token: 0x060185F3 RID: 99827 RVA: 0x00384506 File Offset: 0x00382706
		// (set) Token: 0x060185F4 RID: 99828 RVA: 0x0038450E File Offset: 0x0038270E
		public bool _FoldedForTree { get; set; }

		// Token: 0x170075DD RID: 30173
		// (get) Token: 0x060185F5 RID: 99829 RVA: 0x00384517 File Offset: 0x00382717
		// (set) Token: 0x060185F6 RID: 99830 RVA: 0x0038451F File Offset: 0x0038271F
		public bool Disabled { get; set; }

		// Token: 0x170075DE RID: 30174
		// (get) Token: 0x060185F7 RID: 99831 RVA: 0x00384528 File Offset: 0x00382728
		// (set) Token: 0x060185F8 RID: 99832 RVA: 0x00384530 File Offset: 0x00382730
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x170075DF RID: 30175
		// (get) Token: 0x060185F9 RID: 99833 RVA: 0x00384539 File Offset: 0x00382739
		// (set) Token: 0x060185FA RID: 99834 RVA: 0x00384541 File Offset: 0x00382741
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x170075E0 RID: 30176
		// (get) Token: 0x060185FB RID: 99835 RVA: 0x0038454A File Offset: 0x0038274A
		// (set) Token: 0x060185FC RID: 99836 RVA: 0x00384552 File Offset: 0x00382752
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x170075E1 RID: 30177
		// (get) Token: 0x060185FD RID: 99837 RVA: 0x0038455B File Offset: 0x0038275B
		// (set) Token: 0x060185FE RID: 99838 RVA: 0x00384563 File Offset: 0x00382763
		public string TidQuestAliasName { get; set; }

		// Token: 0x170075E2 RID: 30178
		// (get) Token: 0x060185FF RID: 99839 RVA: 0x0038456C File Offset: 0x0038276C
		// (set) Token: 0x06018600 RID: 99840 RVA: 0x00384574 File Offset: 0x00382774
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x170075E3 RID: 30179
		// (get) Token: 0x06018601 RID: 99841 RVA: 0x0038457D File Offset: 0x0038277D
		// (set) Token: 0x06018602 RID: 99842 RVA: 0x00384585 File Offset: 0x00382785
		public int DungeonId { get; set; }

		// Token: 0x170075E4 RID: 30180
		// (get) Token: 0x06018603 RID: 99843 RVA: 0x0038458E File Offset: 0x0038278E
		// (set) Token: 0x06018604 RID: 99844 RVA: 0x00384596 File Offset: 0x00382796
		public bool DisableOnline { get; set; }

		// Token: 0x170075E5 RID: 30181
		// (get) Token: 0x06018605 RID: 99845 RVA: 0x0038459F File Offset: 0x0038279F
		// (set) Token: 0x06018606 RID: 99846 RVA: 0x003845A7 File Offset: 0x003827A7
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x170075E6 RID: 30182
		// (get) Token: 0x06018607 RID: 99847 RVA: 0x003845B0 File Offset: 0x003827B0
		// (set) Token: 0x06018608 RID: 99848 RVA: 0x003845B8 File Offset: 0x003827B8
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x170075E7 RID: 30183
		// (get) Token: 0x06018609 RID: 99849 RVA: 0x003845C1 File Offset: 0x003827C1
		// (set) Token: 0x0601860A RID: 99850 RVA: 0x003845C9 File Offset: 0x003827C9
		public List<string> Occupations { get; set; }

		// Token: 0x170075E8 RID: 30184
		// (get) Token: 0x0601860B RID: 99851 RVA: 0x003845D2 File Offset: 0x003827D2
		// (set) Token: 0x0601860C RID: 99852 RVA: 0x003845DA File Offset: 0x003827DA
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x170075E9 RID: 30185
		// (get) Token: 0x0601860D RID: 99853 RVA: 0x003845E3 File Offset: 0x003827E3
		// (set) Token: 0x0601860E RID: 99854 RVA: 0x003845EB File Offset: 0x003827EB
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x170075EA RID: 30186
		// (get) Token: 0x0601860F RID: 99855 RVA: 0x003845F4 File Offset: 0x003827F4
		// (set) Token: 0x06018610 RID: 99856 RVA: 0x003845FC File Offset: 0x003827FC
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x170075EB RID: 30187
		// (get) Token: 0x06018611 RID: 99857 RVA: 0x00384605 File Offset: 0x00382805
		// (set) Token: 0x06018612 RID: 99858 RVA: 0x0038460D File Offset: 0x0038280D
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x170075EC RID: 30188
		// (get) Token: 0x06018613 RID: 99859 RVA: 0x00384616 File Offset: 0x00382816
		// (set) Token: 0x06018614 RID: 99860 RVA: 0x0038461E File Offset: 0x0038281E
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x170075ED RID: 30189
		// (get) Token: 0x06018615 RID: 99861 RVA: 0x00384627 File Offset: 0x00382827
		// (set) Token: 0x06018616 RID: 99862 RVA: 0x0038462F File Offset: 0x0038282F
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x170075EE RID: 30190
		// (get) Token: 0x06018617 RID: 99863 RVA: 0x00384638 File Offset: 0x00382838
		// (set) Token: 0x06018618 RID: 99864 RVA: 0x00384640 File Offset: 0x00382840
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x170075EF RID: 30191
		// (get) Token: 0x06018619 RID: 99865 RVA: 0x00384649 File Offset: 0x00382849
		// (set) Token: 0x0601861A RID: 99866 RVA: 0x00384651 File Offset: 0x00382851
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x170075F0 RID: 30192
		// (get) Token: 0x0601861B RID: 99867 RVA: 0x0038465A File Offset: 0x0038285A
		// (set) Token: 0x0601861C RID: 99868 RVA: 0x00384662 File Offset: 0x00382862
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x170075F1 RID: 30193
		// (get) Token: 0x0601861D RID: 99869 RVA: 0x0038466B File Offset: 0x0038286B
		// (set) Token: 0x0601861E RID: 99870 RVA: 0x00384673 File Offset: 0x00382873
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x170075F2 RID: 30194
		// (get) Token: 0x0601861F RID: 99871 RVA: 0x0038467C File Offset: 0x0038287C
		// (set) Token: 0x06018620 RID: 99872 RVA: 0x00384684 File Offset: 0x00382884
		public bool DisableSwitchGender { get; set; }

		// Token: 0x170075F3 RID: 30195
		// (get) Token: 0x06018621 RID: 99873 RVA: 0x0038468D File Offset: 0x0038288D
		// (set) Token: 0x06018622 RID: 99874 RVA: 0x00384695 File Offset: 0x00382895
		public bool DisableFocusMode { get; set; }

		// Token: 0x170075F4 RID: 30196
		// (get) Token: 0x06018623 RID: 99875 RVA: 0x0038469E File Offset: 0x0038289E
		// (set) Token: 0x06018624 RID: 99876 RVA: 0x003846A6 File Offset: 0x003828A6
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x170075F5 RID: 30197
		// (get) Token: 0x06018625 RID: 99877 RVA: 0x003846AF File Offset: 0x003828AF
		// (set) Token: 0x06018626 RID: 99878 RVA: 0x003846B7 File Offset: 0x003828B7
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x170075F6 RID: 30198
		// (get) Token: 0x06018627 RID: 99879 RVA: 0x003846C0 File Offset: 0x003828C0
		// (set) Token: 0x06018628 RID: 99880 RVA: 0x003846C8 File Offset: 0x003828C8
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x170075F7 RID: 30199
		// (get) Token: 0x06018629 RID: 99881 RVA: 0x003846D1 File Offset: 0x003828D1
		// (set) Token: 0x0601862A RID: 99882 RVA: 0x003846D9 File Offset: 0x003828D9
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x170075F8 RID: 30200
		// (get) Token: 0x0601862B RID: 99883 RVA: 0x003846E2 File Offset: 0x003828E2
		// (set) Token: 0x0601862C RID: 99884 RVA: 0x003846EA File Offset: 0x003828EA
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x170075F9 RID: 30201
		// (get) Token: 0x0601862D RID: 99885 RVA: 0x003846F3 File Offset: 0x003828F3
		// (set) Token: 0x0601862E RID: 99886 RVA: 0x003846FB File Offset: 0x003828FB
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x170075FA RID: 30202
		// (get) Token: 0x0601862F RID: 99887 RVA: 0x00384704 File Offset: 0x00382904
		// (set) Token: 0x06018630 RID: 99888 RVA: 0x0038470C File Offset: 0x0038290C
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x170075FB RID: 30203
		// (get) Token: 0x06018631 RID: 99889 RVA: 0x00384715 File Offset: 0x00382915
		// (set) Token: 0x06018632 RID: 99890 RVA: 0x0038471D File Offset: 0x0038291D
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x170075FC RID: 30204
		// (get) Token: 0x06018633 RID: 99891 RVA: 0x00384726 File Offset: 0x00382926
		// (set) Token: 0x06018634 RID: 99892 RVA: 0x0038472E File Offset: 0x0038292E
		public List<TBtNodeUnion> Children { get; set; }

		// Token: 0x170075FD RID: 30205
		// (get) Token: 0x06018635 RID: 99893 RVA: 0x00384737 File Offset: 0x00382937
		// (set) Token: 0x06018636 RID: 99894 RVA: 0x0038473F File Offset: 0x0038293F
		public IPerformanceSettingT PerformanceSetting { get; set; }

		// Token: 0x170075FE RID: 30206
		// (get) Token: 0x06018637 RID: 99895 RVA: 0x00384748 File Offset: 0x00382948
		// (set) Token: 0x06018638 RID: 99896 RVA: 0x00384750 File Offset: 0x00382950
		public ushort NullMask { get; set; }

		// Token: 0x06018639 RID: 99897 RVA: 0x0038475C File Offset: 0x0038295C
		public ISequenceBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.UIConfig = null;
			this.InformationView = null;
			this.InformationBoard = null;
			this.TidQuestAliasName = null;
			this.TidQuestAliasDesc = null;
			this.DungeonId = 0;
			this.DisableOnline = false;
			this.SaveConfig = null;
			this.ForceClosedRestriction = null;
			this.Occupations = null;
			this.OccupationConfig = null;
			this.DisableSwitchOccupation = false;
			this.BudgetCameraType = EBudgetCameraType.Role;
			this.Statistics = null;
			this.CompositeTrackViewMode = ETrackViewMode.All;
			this.RewardConfig = null;
			this.SpecialGamePlayConfig = null;
			this.EnableSystem = null;
			this.StartWave = null;
			this.DisableTrackAnim = null;
			this.DisableSwitchGender = false;
			this.DisableFocusMode = false;
			this.DisableSkeletalAnimationCheck = false;
			this.LogicProgramSpecialProcess = null;
			this.QuestBuffActiveRange = null;
			this.SunSpiritProcess = null;
			this.ModifyTrackAreaText = null;
			this.DisableGlobalTraffic = false;
			this.DisableSystemPrompt = null;
			this.TrackCustomBoard = null;
			this.Children = null;
			this.PerformanceSetting = null;
			this.NullMask = 0;
		}
	}
}
