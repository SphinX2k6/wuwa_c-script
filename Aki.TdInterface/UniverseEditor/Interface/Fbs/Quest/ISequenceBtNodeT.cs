using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200454E RID: 17742
	public class ISequenceBtNodeT
	{
		// Token: 0x17007BDE RID: 31710
		// (get) Token: 0x06019C8E RID: 105614 RVA: 0x003AE4CA File Offset: 0x003AC6CA
		// (set) Token: 0x06019C8F RID: 105615 RVA: 0x003AE4D2 File Offset: 0x003AC6D2
		public EBtNode Type { get; set; }

		// Token: 0x17007BDF RID: 31711
		// (get) Token: 0x06019C90 RID: 105616 RVA: 0x003AE4DB File Offset: 0x003AC6DB
		// (set) Token: 0x06019C91 RID: 105617 RVA: 0x003AE4E3 File Offset: 0x003AC6E3
		public int Id { get; set; }

		// Token: 0x17007BE0 RID: 31712
		// (get) Token: 0x06019C92 RID: 105618 RVA: 0x003AE4EC File Offset: 0x003AC6EC
		// (set) Token: 0x06019C93 RID: 105619 RVA: 0x003AE4F4 File Offset: 0x003AC6F4
		public string Desc { get; set; }

		// Token: 0x17007BE1 RID: 31713
		// (get) Token: 0x06019C94 RID: 105620 RVA: 0x003AE4FD File Offset: 0x003AC6FD
		// (set) Token: 0x06019C95 RID: 105621 RVA: 0x003AE505 File Offset: 0x003AC705
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007BE2 RID: 31714
		// (get) Token: 0x06019C96 RID: 105622 RVA: 0x003AE50E File Offset: 0x003AC70E
		// (set) Token: 0x06019C97 RID: 105623 RVA: 0x003AE516 File Offset: 0x003AC716
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007BE3 RID: 31715
		// (get) Token: 0x06019C98 RID: 105624 RVA: 0x003AE51F File Offset: 0x003AC71F
		// (set) Token: 0x06019C99 RID: 105625 RVA: 0x003AE527 File Offset: 0x003AC727
		public bool Disabled { get; set; }

		// Token: 0x17007BE4 RID: 31716
		// (get) Token: 0x06019C9A RID: 105626 RVA: 0x003AE530 File Offset: 0x003AC730
		// (set) Token: 0x06019C9B RID: 105627 RVA: 0x003AE538 File Offset: 0x003AC738
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x17007BE5 RID: 31717
		// (get) Token: 0x06019C9C RID: 105628 RVA: 0x003AE541 File Offset: 0x003AC741
		// (set) Token: 0x06019C9D RID: 105629 RVA: 0x003AE549 File Offset: 0x003AC749
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x17007BE6 RID: 31718
		// (get) Token: 0x06019C9E RID: 105630 RVA: 0x003AE552 File Offset: 0x003AC752
		// (set) Token: 0x06019C9F RID: 105631 RVA: 0x003AE55A File Offset: 0x003AC75A
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x17007BE7 RID: 31719
		// (get) Token: 0x06019CA0 RID: 105632 RVA: 0x003AE563 File Offset: 0x003AC763
		// (set) Token: 0x06019CA1 RID: 105633 RVA: 0x003AE56B File Offset: 0x003AC76B
		public string TidQuestAliasName { get; set; }

		// Token: 0x17007BE8 RID: 31720
		// (get) Token: 0x06019CA2 RID: 105634 RVA: 0x003AE574 File Offset: 0x003AC774
		// (set) Token: 0x06019CA3 RID: 105635 RVA: 0x003AE57C File Offset: 0x003AC77C
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x17007BE9 RID: 31721
		// (get) Token: 0x06019CA4 RID: 105636 RVA: 0x003AE585 File Offset: 0x003AC785
		// (set) Token: 0x06019CA5 RID: 105637 RVA: 0x003AE58D File Offset: 0x003AC78D
		public int DungeonId { get; set; }

		// Token: 0x17007BEA RID: 31722
		// (get) Token: 0x06019CA6 RID: 105638 RVA: 0x003AE596 File Offset: 0x003AC796
		// (set) Token: 0x06019CA7 RID: 105639 RVA: 0x003AE59E File Offset: 0x003AC79E
		public bool DisableOnline { get; set; }

		// Token: 0x17007BEB RID: 31723
		// (get) Token: 0x06019CA8 RID: 105640 RVA: 0x003AE5A7 File Offset: 0x003AC7A7
		// (set) Token: 0x06019CA9 RID: 105641 RVA: 0x003AE5AF File Offset: 0x003AC7AF
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x17007BEC RID: 31724
		// (get) Token: 0x06019CAA RID: 105642 RVA: 0x003AE5B8 File Offset: 0x003AC7B8
		// (set) Token: 0x06019CAB RID: 105643 RVA: 0x003AE5C0 File Offset: 0x003AC7C0
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x17007BED RID: 31725
		// (get) Token: 0x06019CAC RID: 105644 RVA: 0x003AE5C9 File Offset: 0x003AC7C9
		// (set) Token: 0x06019CAD RID: 105645 RVA: 0x003AE5D1 File Offset: 0x003AC7D1
		public List<string> Occupations { get; set; }

		// Token: 0x17007BEE RID: 31726
		// (get) Token: 0x06019CAE RID: 105646 RVA: 0x003AE5DA File Offset: 0x003AC7DA
		// (set) Token: 0x06019CAF RID: 105647 RVA: 0x003AE5E2 File Offset: 0x003AC7E2
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x17007BEF RID: 31727
		// (get) Token: 0x06019CB0 RID: 105648 RVA: 0x003AE5EB File Offset: 0x003AC7EB
		// (set) Token: 0x06019CB1 RID: 105649 RVA: 0x003AE5F3 File Offset: 0x003AC7F3
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x17007BF0 RID: 31728
		// (get) Token: 0x06019CB2 RID: 105650 RVA: 0x003AE5FC File Offset: 0x003AC7FC
		// (set) Token: 0x06019CB3 RID: 105651 RVA: 0x003AE604 File Offset: 0x003AC804
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x17007BF1 RID: 31729
		// (get) Token: 0x06019CB4 RID: 105652 RVA: 0x003AE60D File Offset: 0x003AC80D
		// (set) Token: 0x06019CB5 RID: 105653 RVA: 0x003AE615 File Offset: 0x003AC815
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x17007BF2 RID: 31730
		// (get) Token: 0x06019CB6 RID: 105654 RVA: 0x003AE61E File Offset: 0x003AC81E
		// (set) Token: 0x06019CB7 RID: 105655 RVA: 0x003AE626 File Offset: 0x003AC826
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x17007BF3 RID: 31731
		// (get) Token: 0x06019CB8 RID: 105656 RVA: 0x003AE62F File Offset: 0x003AC82F
		// (set) Token: 0x06019CB9 RID: 105657 RVA: 0x003AE637 File Offset: 0x003AC837
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x17007BF4 RID: 31732
		// (get) Token: 0x06019CBA RID: 105658 RVA: 0x003AE640 File Offset: 0x003AC840
		// (set) Token: 0x06019CBB RID: 105659 RVA: 0x003AE648 File Offset: 0x003AC848
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x17007BF5 RID: 31733
		// (get) Token: 0x06019CBC RID: 105660 RVA: 0x003AE651 File Offset: 0x003AC851
		// (set) Token: 0x06019CBD RID: 105661 RVA: 0x003AE659 File Offset: 0x003AC859
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x17007BF6 RID: 31734
		// (get) Token: 0x06019CBE RID: 105662 RVA: 0x003AE662 File Offset: 0x003AC862
		// (set) Token: 0x06019CBF RID: 105663 RVA: 0x003AE66A File Offset: 0x003AC86A
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x17007BF7 RID: 31735
		// (get) Token: 0x06019CC0 RID: 105664 RVA: 0x003AE673 File Offset: 0x003AC873
		// (set) Token: 0x06019CC1 RID: 105665 RVA: 0x003AE67B File Offset: 0x003AC87B
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x17007BF8 RID: 31736
		// (get) Token: 0x06019CC2 RID: 105666 RVA: 0x003AE684 File Offset: 0x003AC884
		// (set) Token: 0x06019CC3 RID: 105667 RVA: 0x003AE68C File Offset: 0x003AC88C
		public bool DisableSwitchGender { get; set; }

		// Token: 0x17007BF9 RID: 31737
		// (get) Token: 0x06019CC4 RID: 105668 RVA: 0x003AE695 File Offset: 0x003AC895
		// (set) Token: 0x06019CC5 RID: 105669 RVA: 0x003AE69D File Offset: 0x003AC89D
		public bool DisableFocusMode { get; set; }

		// Token: 0x17007BFA RID: 31738
		// (get) Token: 0x06019CC6 RID: 105670 RVA: 0x003AE6A6 File Offset: 0x003AC8A6
		// (set) Token: 0x06019CC7 RID: 105671 RVA: 0x003AE6AE File Offset: 0x003AC8AE
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x17007BFB RID: 31739
		// (get) Token: 0x06019CC8 RID: 105672 RVA: 0x003AE6B7 File Offset: 0x003AC8B7
		// (set) Token: 0x06019CC9 RID: 105673 RVA: 0x003AE6BF File Offset: 0x003AC8BF
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x17007BFC RID: 31740
		// (get) Token: 0x06019CCA RID: 105674 RVA: 0x003AE6C8 File Offset: 0x003AC8C8
		// (set) Token: 0x06019CCB RID: 105675 RVA: 0x003AE6D0 File Offset: 0x003AC8D0
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x17007BFD RID: 31741
		// (get) Token: 0x06019CCC RID: 105676 RVA: 0x003AE6D9 File Offset: 0x003AC8D9
		// (set) Token: 0x06019CCD RID: 105677 RVA: 0x003AE6E1 File Offset: 0x003AC8E1
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x17007BFE RID: 31742
		// (get) Token: 0x06019CCE RID: 105678 RVA: 0x003AE6EA File Offset: 0x003AC8EA
		// (set) Token: 0x06019CCF RID: 105679 RVA: 0x003AE6F2 File Offset: 0x003AC8F2
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x17007BFF RID: 31743
		// (get) Token: 0x06019CD0 RID: 105680 RVA: 0x003AE6FB File Offset: 0x003AC8FB
		// (set) Token: 0x06019CD1 RID: 105681 RVA: 0x003AE703 File Offset: 0x003AC903
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x17007C00 RID: 31744
		// (get) Token: 0x06019CD2 RID: 105682 RVA: 0x003AE70C File Offset: 0x003AC90C
		// (set) Token: 0x06019CD3 RID: 105683 RVA: 0x003AE714 File Offset: 0x003AC914
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x17007C01 RID: 31745
		// (get) Token: 0x06019CD4 RID: 105684 RVA: 0x003AE71D File Offset: 0x003AC91D
		// (set) Token: 0x06019CD5 RID: 105685 RVA: 0x003AE725 File Offset: 0x003AC925
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x17007C02 RID: 31746
		// (get) Token: 0x06019CD6 RID: 105686 RVA: 0x003AE72E File Offset: 0x003AC92E
		// (set) Token: 0x06019CD7 RID: 105687 RVA: 0x003AE736 File Offset: 0x003AC936
		public List<TBtNodeUnion> Children { get; set; }

		// Token: 0x17007C03 RID: 31747
		// (get) Token: 0x06019CD8 RID: 105688 RVA: 0x003AE73F File Offset: 0x003AC93F
		// (set) Token: 0x06019CD9 RID: 105689 RVA: 0x003AE747 File Offset: 0x003AC947
		public IPerformanceSettingT PerformanceSetting { get; set; }

		// Token: 0x17007C04 RID: 31748
		// (get) Token: 0x06019CDA RID: 105690 RVA: 0x003AE750 File Offset: 0x003AC950
		// (set) Token: 0x06019CDB RID: 105691 RVA: 0x003AE758 File Offset: 0x003AC958
		public ushort NullMask { get; set; }

		// Token: 0x06019CDC RID: 105692 RVA: 0x003AE764 File Offset: 0x003AC964
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
