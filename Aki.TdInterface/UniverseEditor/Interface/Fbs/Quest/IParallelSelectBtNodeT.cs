using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F72 RID: 16242
	public class IParallelSelectBtNodeT
	{
		// Token: 0x17007132 RID: 28978
		// (get) Token: 0x0601727A RID: 94842 RVA: 0x0035792C File Offset: 0x00355B2C
		// (set) Token: 0x0601727B RID: 94843 RVA: 0x00357934 File Offset: 0x00355B34
		public EBtNode Type { get; set; }

		// Token: 0x17007133 RID: 28979
		// (get) Token: 0x0601727C RID: 94844 RVA: 0x0035793D File Offset: 0x00355B3D
		// (set) Token: 0x0601727D RID: 94845 RVA: 0x00357945 File Offset: 0x00355B45
		public int Id { get; set; }

		// Token: 0x17007134 RID: 28980
		// (get) Token: 0x0601727E RID: 94846 RVA: 0x0035794E File Offset: 0x00355B4E
		// (set) Token: 0x0601727F RID: 94847 RVA: 0x00357956 File Offset: 0x00355B56
		public string Desc { get; set; }

		// Token: 0x17007135 RID: 28981
		// (get) Token: 0x06017280 RID: 94848 RVA: 0x0035795F File Offset: 0x00355B5F
		// (set) Token: 0x06017281 RID: 94849 RVA: 0x00357967 File Offset: 0x00355B67
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007136 RID: 28982
		// (get) Token: 0x06017282 RID: 94850 RVA: 0x00357970 File Offset: 0x00355B70
		// (set) Token: 0x06017283 RID: 94851 RVA: 0x00357978 File Offset: 0x00355B78
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007137 RID: 28983
		// (get) Token: 0x06017284 RID: 94852 RVA: 0x00357981 File Offset: 0x00355B81
		// (set) Token: 0x06017285 RID: 94853 RVA: 0x00357989 File Offset: 0x00355B89
		public bool Disabled { get; set; }

		// Token: 0x17007138 RID: 28984
		// (get) Token: 0x06017286 RID: 94854 RVA: 0x00357992 File Offset: 0x00355B92
		// (set) Token: 0x06017287 RID: 94855 RVA: 0x0035799A File Offset: 0x00355B9A
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x17007139 RID: 28985
		// (get) Token: 0x06017288 RID: 94856 RVA: 0x003579A3 File Offset: 0x00355BA3
		// (set) Token: 0x06017289 RID: 94857 RVA: 0x003579AB File Offset: 0x00355BAB
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x1700713A RID: 28986
		// (get) Token: 0x0601728A RID: 94858 RVA: 0x003579B4 File Offset: 0x00355BB4
		// (set) Token: 0x0601728B RID: 94859 RVA: 0x003579BC File Offset: 0x00355BBC
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x1700713B RID: 28987
		// (get) Token: 0x0601728C RID: 94860 RVA: 0x003579C5 File Offset: 0x00355BC5
		// (set) Token: 0x0601728D RID: 94861 RVA: 0x003579CD File Offset: 0x00355BCD
		public string TidQuestAliasName { get; set; }

		// Token: 0x1700713C RID: 28988
		// (get) Token: 0x0601728E RID: 94862 RVA: 0x003579D6 File Offset: 0x00355BD6
		// (set) Token: 0x0601728F RID: 94863 RVA: 0x003579DE File Offset: 0x00355BDE
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x1700713D RID: 28989
		// (get) Token: 0x06017290 RID: 94864 RVA: 0x003579E7 File Offset: 0x00355BE7
		// (set) Token: 0x06017291 RID: 94865 RVA: 0x003579EF File Offset: 0x00355BEF
		public int DungeonId { get; set; }

		// Token: 0x1700713E RID: 28990
		// (get) Token: 0x06017292 RID: 94866 RVA: 0x003579F8 File Offset: 0x00355BF8
		// (set) Token: 0x06017293 RID: 94867 RVA: 0x00357A00 File Offset: 0x00355C00
		public bool DisableOnline { get; set; }

		// Token: 0x1700713F RID: 28991
		// (get) Token: 0x06017294 RID: 94868 RVA: 0x00357A09 File Offset: 0x00355C09
		// (set) Token: 0x06017295 RID: 94869 RVA: 0x00357A11 File Offset: 0x00355C11
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x17007140 RID: 28992
		// (get) Token: 0x06017296 RID: 94870 RVA: 0x00357A1A File Offset: 0x00355C1A
		// (set) Token: 0x06017297 RID: 94871 RVA: 0x00357A22 File Offset: 0x00355C22
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x17007141 RID: 28993
		// (get) Token: 0x06017298 RID: 94872 RVA: 0x00357A2B File Offset: 0x00355C2B
		// (set) Token: 0x06017299 RID: 94873 RVA: 0x00357A33 File Offset: 0x00355C33
		public List<string> Occupations { get; set; }

		// Token: 0x17007142 RID: 28994
		// (get) Token: 0x0601729A RID: 94874 RVA: 0x00357A3C File Offset: 0x00355C3C
		// (set) Token: 0x0601729B RID: 94875 RVA: 0x00357A44 File Offset: 0x00355C44
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x17007143 RID: 28995
		// (get) Token: 0x0601729C RID: 94876 RVA: 0x00357A4D File Offset: 0x00355C4D
		// (set) Token: 0x0601729D RID: 94877 RVA: 0x00357A55 File Offset: 0x00355C55
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x17007144 RID: 28996
		// (get) Token: 0x0601729E RID: 94878 RVA: 0x00357A5E File Offset: 0x00355C5E
		// (set) Token: 0x0601729F RID: 94879 RVA: 0x00357A66 File Offset: 0x00355C66
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x17007145 RID: 28997
		// (get) Token: 0x060172A0 RID: 94880 RVA: 0x00357A6F File Offset: 0x00355C6F
		// (set) Token: 0x060172A1 RID: 94881 RVA: 0x00357A77 File Offset: 0x00355C77
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x17007146 RID: 28998
		// (get) Token: 0x060172A2 RID: 94882 RVA: 0x00357A80 File Offset: 0x00355C80
		// (set) Token: 0x060172A3 RID: 94883 RVA: 0x00357A88 File Offset: 0x00355C88
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x17007147 RID: 28999
		// (get) Token: 0x060172A4 RID: 94884 RVA: 0x00357A91 File Offset: 0x00355C91
		// (set) Token: 0x060172A5 RID: 94885 RVA: 0x00357A99 File Offset: 0x00355C99
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x17007148 RID: 29000
		// (get) Token: 0x060172A6 RID: 94886 RVA: 0x00357AA2 File Offset: 0x00355CA2
		// (set) Token: 0x060172A7 RID: 94887 RVA: 0x00357AAA File Offset: 0x00355CAA
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x17007149 RID: 29001
		// (get) Token: 0x060172A8 RID: 94888 RVA: 0x00357AB3 File Offset: 0x00355CB3
		// (set) Token: 0x060172A9 RID: 94889 RVA: 0x00357ABB File Offset: 0x00355CBB
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x1700714A RID: 29002
		// (get) Token: 0x060172AA RID: 94890 RVA: 0x00357AC4 File Offset: 0x00355CC4
		// (set) Token: 0x060172AB RID: 94891 RVA: 0x00357ACC File Offset: 0x00355CCC
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x1700714B RID: 29003
		// (get) Token: 0x060172AC RID: 94892 RVA: 0x00357AD5 File Offset: 0x00355CD5
		// (set) Token: 0x060172AD RID: 94893 RVA: 0x00357ADD File Offset: 0x00355CDD
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x1700714C RID: 29004
		// (get) Token: 0x060172AE RID: 94894 RVA: 0x00357AE6 File Offset: 0x00355CE6
		// (set) Token: 0x060172AF RID: 94895 RVA: 0x00357AEE File Offset: 0x00355CEE
		public bool DisableSwitchGender { get; set; }

		// Token: 0x1700714D RID: 29005
		// (get) Token: 0x060172B0 RID: 94896 RVA: 0x00357AF7 File Offset: 0x00355CF7
		// (set) Token: 0x060172B1 RID: 94897 RVA: 0x00357AFF File Offset: 0x00355CFF
		public bool DisableFocusMode { get; set; }

		// Token: 0x1700714E RID: 29006
		// (get) Token: 0x060172B2 RID: 94898 RVA: 0x00357B08 File Offset: 0x00355D08
		// (set) Token: 0x060172B3 RID: 94899 RVA: 0x00357B10 File Offset: 0x00355D10
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x1700714F RID: 29007
		// (get) Token: 0x060172B4 RID: 94900 RVA: 0x00357B19 File Offset: 0x00355D19
		// (set) Token: 0x060172B5 RID: 94901 RVA: 0x00357B21 File Offset: 0x00355D21
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x17007150 RID: 29008
		// (get) Token: 0x060172B6 RID: 94902 RVA: 0x00357B2A File Offset: 0x00355D2A
		// (set) Token: 0x060172B7 RID: 94903 RVA: 0x00357B32 File Offset: 0x00355D32
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x17007151 RID: 29009
		// (get) Token: 0x060172B8 RID: 94904 RVA: 0x00357B3B File Offset: 0x00355D3B
		// (set) Token: 0x060172B9 RID: 94905 RVA: 0x00357B43 File Offset: 0x00355D43
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x17007152 RID: 29010
		// (get) Token: 0x060172BA RID: 94906 RVA: 0x00357B4C File Offset: 0x00355D4C
		// (set) Token: 0x060172BB RID: 94907 RVA: 0x00357B54 File Offset: 0x00355D54
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x17007153 RID: 29011
		// (get) Token: 0x060172BC RID: 94908 RVA: 0x00357B5D File Offset: 0x00355D5D
		// (set) Token: 0x060172BD RID: 94909 RVA: 0x00357B65 File Offset: 0x00355D65
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x17007154 RID: 29012
		// (get) Token: 0x060172BE RID: 94910 RVA: 0x00357B6E File Offset: 0x00355D6E
		// (set) Token: 0x060172BF RID: 94911 RVA: 0x00357B76 File Offset: 0x00355D76
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x17007155 RID: 29013
		// (get) Token: 0x060172C0 RID: 94912 RVA: 0x00357B7F File Offset: 0x00355D7F
		// (set) Token: 0x060172C1 RID: 94913 RVA: 0x00357B87 File Offset: 0x00355D87
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x17007156 RID: 29014
		// (get) Token: 0x060172C2 RID: 94914 RVA: 0x00357B90 File Offset: 0x00355D90
		// (set) Token: 0x060172C3 RID: 94915 RVA: 0x00357B98 File Offset: 0x00355D98
		public List<TBtNodeUnion> Children { get; set; }

		// Token: 0x17007157 RID: 29015
		// (get) Token: 0x060172C4 RID: 94916 RVA: 0x00357BA1 File Offset: 0x00355DA1
		// (set) Token: 0x060172C5 RID: 94917 RVA: 0x00357BA9 File Offset: 0x00355DA9
		public EConditionCount Count { get; set; }

		// Token: 0x17007158 RID: 29016
		// (get) Token: 0x060172C6 RID: 94918 RVA: 0x00357BB2 File Offset: 0x00355DB2
		// (set) Token: 0x060172C7 RID: 94919 RVA: 0x00357BBA File Offset: 0x00355DBA
		public IPerformanceSettingT PerformanceSetting { get; set; }

		// Token: 0x17007159 RID: 29017
		// (get) Token: 0x060172C8 RID: 94920 RVA: 0x00357BC3 File Offset: 0x00355DC3
		// (set) Token: 0x060172C9 RID: 94921 RVA: 0x00357BCB File Offset: 0x00355DCB
		public ushort NullMask { get; set; }

		// Token: 0x060172CA RID: 94922 RVA: 0x00357BD4 File Offset: 0x00355DD4
		public IParallelSelectBtNodeT()
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
			this.Count = EConditionCount.All;
			this.PerformanceSetting = null;
			this.NullMask = 0;
		}
	}
}
