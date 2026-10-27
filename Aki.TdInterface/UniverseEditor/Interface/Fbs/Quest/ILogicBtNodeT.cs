using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F0F RID: 16143
	public class ILogicBtNodeT
	{
		// Token: 0x1700701E RID: 28702
		// (get) Token: 0x06016E30 RID: 93744 RVA: 0x0034DC2D File Offset: 0x0034BE2D
		// (set) Token: 0x06016E31 RID: 93745 RVA: 0x0034DC35 File Offset: 0x0034BE35
		public EBtNode Type { get; set; }

		// Token: 0x1700701F RID: 28703
		// (get) Token: 0x06016E32 RID: 93746 RVA: 0x0034DC3E File Offset: 0x0034BE3E
		// (set) Token: 0x06016E33 RID: 93747 RVA: 0x0034DC46 File Offset: 0x0034BE46
		public int Id { get; set; }

		// Token: 0x17007020 RID: 28704
		// (get) Token: 0x06016E34 RID: 93748 RVA: 0x0034DC4F File Offset: 0x0034BE4F
		// (set) Token: 0x06016E35 RID: 93749 RVA: 0x0034DC57 File Offset: 0x0034BE57
		public string Desc { get; set; }

		// Token: 0x17007021 RID: 28705
		// (get) Token: 0x06016E36 RID: 93750 RVA: 0x0034DC60 File Offset: 0x0034BE60
		// (set) Token: 0x06016E37 RID: 93751 RVA: 0x0034DC68 File Offset: 0x0034BE68
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007022 RID: 28706
		// (get) Token: 0x06016E38 RID: 93752 RVA: 0x0034DC71 File Offset: 0x0034BE71
		// (set) Token: 0x06016E39 RID: 93753 RVA: 0x0034DC79 File Offset: 0x0034BE79
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007023 RID: 28707
		// (get) Token: 0x06016E3A RID: 93754 RVA: 0x0034DC82 File Offset: 0x0034BE82
		// (set) Token: 0x06016E3B RID: 93755 RVA: 0x0034DC8A File Offset: 0x0034BE8A
		public bool Disabled { get; set; }

		// Token: 0x17007024 RID: 28708
		// (get) Token: 0x06016E3C RID: 93756 RVA: 0x0034DC93 File Offset: 0x0034BE93
		// (set) Token: 0x06016E3D RID: 93757 RVA: 0x0034DC9B File Offset: 0x0034BE9B
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x17007025 RID: 28709
		// (get) Token: 0x06016E3E RID: 93758 RVA: 0x0034DCA4 File Offset: 0x0034BEA4
		// (set) Token: 0x06016E3F RID: 93759 RVA: 0x0034DCAC File Offset: 0x0034BEAC
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x17007026 RID: 28710
		// (get) Token: 0x06016E40 RID: 93760 RVA: 0x0034DCB5 File Offset: 0x0034BEB5
		// (set) Token: 0x06016E41 RID: 93761 RVA: 0x0034DCBD File Offset: 0x0034BEBD
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x17007027 RID: 28711
		// (get) Token: 0x06016E42 RID: 93762 RVA: 0x0034DCC6 File Offset: 0x0034BEC6
		// (set) Token: 0x06016E43 RID: 93763 RVA: 0x0034DCCE File Offset: 0x0034BECE
		public string TidQuestAliasName { get; set; }

		// Token: 0x17007028 RID: 28712
		// (get) Token: 0x06016E44 RID: 93764 RVA: 0x0034DCD7 File Offset: 0x0034BED7
		// (set) Token: 0x06016E45 RID: 93765 RVA: 0x0034DCDF File Offset: 0x0034BEDF
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x17007029 RID: 28713
		// (get) Token: 0x06016E46 RID: 93766 RVA: 0x0034DCE8 File Offset: 0x0034BEE8
		// (set) Token: 0x06016E47 RID: 93767 RVA: 0x0034DCF0 File Offset: 0x0034BEF0
		public int DungeonId { get; set; }

		// Token: 0x1700702A RID: 28714
		// (get) Token: 0x06016E48 RID: 93768 RVA: 0x0034DCF9 File Offset: 0x0034BEF9
		// (set) Token: 0x06016E49 RID: 93769 RVA: 0x0034DD01 File Offset: 0x0034BF01
		public bool DisableOnline { get; set; }

		// Token: 0x1700702B RID: 28715
		// (get) Token: 0x06016E4A RID: 93770 RVA: 0x0034DD0A File Offset: 0x0034BF0A
		// (set) Token: 0x06016E4B RID: 93771 RVA: 0x0034DD12 File Offset: 0x0034BF12
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x1700702C RID: 28716
		// (get) Token: 0x06016E4C RID: 93772 RVA: 0x0034DD1B File Offset: 0x0034BF1B
		// (set) Token: 0x06016E4D RID: 93773 RVA: 0x0034DD23 File Offset: 0x0034BF23
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x1700702D RID: 28717
		// (get) Token: 0x06016E4E RID: 93774 RVA: 0x0034DD2C File Offset: 0x0034BF2C
		// (set) Token: 0x06016E4F RID: 93775 RVA: 0x0034DD34 File Offset: 0x0034BF34
		public List<string> Occupations { get; set; }

		// Token: 0x1700702E RID: 28718
		// (get) Token: 0x06016E50 RID: 93776 RVA: 0x0034DD3D File Offset: 0x0034BF3D
		// (set) Token: 0x06016E51 RID: 93777 RVA: 0x0034DD45 File Offset: 0x0034BF45
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x1700702F RID: 28719
		// (get) Token: 0x06016E52 RID: 93778 RVA: 0x0034DD4E File Offset: 0x0034BF4E
		// (set) Token: 0x06016E53 RID: 93779 RVA: 0x0034DD56 File Offset: 0x0034BF56
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x17007030 RID: 28720
		// (get) Token: 0x06016E54 RID: 93780 RVA: 0x0034DD5F File Offset: 0x0034BF5F
		// (set) Token: 0x06016E55 RID: 93781 RVA: 0x0034DD67 File Offset: 0x0034BF67
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x17007031 RID: 28721
		// (get) Token: 0x06016E56 RID: 93782 RVA: 0x0034DD70 File Offset: 0x0034BF70
		// (set) Token: 0x06016E57 RID: 93783 RVA: 0x0034DD78 File Offset: 0x0034BF78
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x17007032 RID: 28722
		// (get) Token: 0x06016E58 RID: 93784 RVA: 0x0034DD81 File Offset: 0x0034BF81
		// (set) Token: 0x06016E59 RID: 93785 RVA: 0x0034DD89 File Offset: 0x0034BF89
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x17007033 RID: 28723
		// (get) Token: 0x06016E5A RID: 93786 RVA: 0x0034DD92 File Offset: 0x0034BF92
		// (set) Token: 0x06016E5B RID: 93787 RVA: 0x0034DD9A File Offset: 0x0034BF9A
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x17007034 RID: 28724
		// (get) Token: 0x06016E5C RID: 93788 RVA: 0x0034DDA3 File Offset: 0x0034BFA3
		// (set) Token: 0x06016E5D RID: 93789 RVA: 0x0034DDAB File Offset: 0x0034BFAB
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x17007035 RID: 28725
		// (get) Token: 0x06016E5E RID: 93790 RVA: 0x0034DDB4 File Offset: 0x0034BFB4
		// (set) Token: 0x06016E5F RID: 93791 RVA: 0x0034DDBC File Offset: 0x0034BFBC
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x17007036 RID: 28726
		// (get) Token: 0x06016E60 RID: 93792 RVA: 0x0034DDC5 File Offset: 0x0034BFC5
		// (set) Token: 0x06016E61 RID: 93793 RVA: 0x0034DDCD File Offset: 0x0034BFCD
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x17007037 RID: 28727
		// (get) Token: 0x06016E62 RID: 93794 RVA: 0x0034DDD6 File Offset: 0x0034BFD6
		// (set) Token: 0x06016E63 RID: 93795 RVA: 0x0034DDDE File Offset: 0x0034BFDE
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x17007038 RID: 28728
		// (get) Token: 0x06016E64 RID: 93796 RVA: 0x0034DDE7 File Offset: 0x0034BFE7
		// (set) Token: 0x06016E65 RID: 93797 RVA: 0x0034DDEF File Offset: 0x0034BFEF
		public bool DisableSwitchGender { get; set; }

		// Token: 0x17007039 RID: 28729
		// (get) Token: 0x06016E66 RID: 93798 RVA: 0x0034DDF8 File Offset: 0x0034BFF8
		// (set) Token: 0x06016E67 RID: 93799 RVA: 0x0034DE00 File Offset: 0x0034C000
		public bool DisableFocusMode { get; set; }

		// Token: 0x1700703A RID: 28730
		// (get) Token: 0x06016E68 RID: 93800 RVA: 0x0034DE09 File Offset: 0x0034C009
		// (set) Token: 0x06016E69 RID: 93801 RVA: 0x0034DE11 File Offset: 0x0034C011
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x1700703B RID: 28731
		// (get) Token: 0x06016E6A RID: 93802 RVA: 0x0034DE1A File Offset: 0x0034C01A
		// (set) Token: 0x06016E6B RID: 93803 RVA: 0x0034DE22 File Offset: 0x0034C022
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x1700703C RID: 28732
		// (get) Token: 0x06016E6C RID: 93804 RVA: 0x0034DE2B File Offset: 0x0034C02B
		// (set) Token: 0x06016E6D RID: 93805 RVA: 0x0034DE33 File Offset: 0x0034C033
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x1700703D RID: 28733
		// (get) Token: 0x06016E6E RID: 93806 RVA: 0x0034DE3C File Offset: 0x0034C03C
		// (set) Token: 0x06016E6F RID: 93807 RVA: 0x0034DE44 File Offset: 0x0034C044
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x1700703E RID: 28734
		// (get) Token: 0x06016E70 RID: 93808 RVA: 0x0034DE4D File Offset: 0x0034C04D
		// (set) Token: 0x06016E71 RID: 93809 RVA: 0x0034DE55 File Offset: 0x0034C055
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x1700703F RID: 28735
		// (get) Token: 0x06016E72 RID: 93810 RVA: 0x0034DE5E File Offset: 0x0034C05E
		// (set) Token: 0x06016E73 RID: 93811 RVA: 0x0034DE66 File Offset: 0x0034C066
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x17007040 RID: 28736
		// (get) Token: 0x06016E74 RID: 93812 RVA: 0x0034DE6F File Offset: 0x0034C06F
		// (set) Token: 0x06016E75 RID: 93813 RVA: 0x0034DE77 File Offset: 0x0034C077
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x17007041 RID: 28737
		// (get) Token: 0x06016E76 RID: 93814 RVA: 0x0034DE80 File Offset: 0x0034C080
		// (set) Token: 0x06016E77 RID: 93815 RVA: 0x0034DE88 File Offset: 0x0034C088
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x17007042 RID: 28738
		// (get) Token: 0x06016E78 RID: 93816 RVA: 0x0034DE91 File Offset: 0x0034C091
		// (set) Token: 0x06016E79 RID: 93817 RVA: 0x0034DE99 File Offset: 0x0034C099
		public ushort NullMask { get; set; }

		// Token: 0x06016E7A RID: 93818 RVA: 0x0034DEA4 File Offset: 0x0034C0A4
		public ILogicBtNodeT()
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
			this.NullMask = 0;
		}
	}
}
