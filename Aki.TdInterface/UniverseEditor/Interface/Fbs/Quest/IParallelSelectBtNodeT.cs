using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043B3 RID: 17331
	public class IParallelSelectBtNodeT
	{
		// Token: 0x17007730 RID: 30512
		// (get) Token: 0x06018909 RID: 100617 RVA: 0x00381500 File Offset: 0x0037F700
		// (set) Token: 0x0601890A RID: 100618 RVA: 0x00381508 File Offset: 0x0037F708
		public EBtNode Type { get; set; }

		// Token: 0x17007731 RID: 30513
		// (get) Token: 0x0601890B RID: 100619 RVA: 0x00381511 File Offset: 0x0037F711
		// (set) Token: 0x0601890C RID: 100620 RVA: 0x00381519 File Offset: 0x0037F719
		public int Id { get; set; }

		// Token: 0x17007732 RID: 30514
		// (get) Token: 0x0601890D RID: 100621 RVA: 0x00381522 File Offset: 0x0037F722
		// (set) Token: 0x0601890E RID: 100622 RVA: 0x0038152A File Offset: 0x0037F72A
		public string Desc { get; set; }

		// Token: 0x17007733 RID: 30515
		// (get) Token: 0x0601890F RID: 100623 RVA: 0x00381533 File Offset: 0x0037F733
		// (set) Token: 0x06018910 RID: 100624 RVA: 0x0038153B File Offset: 0x0037F73B
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17007734 RID: 30516
		// (get) Token: 0x06018911 RID: 100625 RVA: 0x00381544 File Offset: 0x0037F744
		// (set) Token: 0x06018912 RID: 100626 RVA: 0x0038154C File Offset: 0x0037F74C
		public bool _FoldedForTree { get; set; }

		// Token: 0x17007735 RID: 30517
		// (get) Token: 0x06018913 RID: 100627 RVA: 0x00381555 File Offset: 0x0037F755
		// (set) Token: 0x06018914 RID: 100628 RVA: 0x0038155D File Offset: 0x0037F75D
		public bool Disabled { get; set; }

		// Token: 0x17007736 RID: 30518
		// (get) Token: 0x06018915 RID: 100629 RVA: 0x00381566 File Offset: 0x0037F766
		// (set) Token: 0x06018916 RID: 100630 RVA: 0x0038156E File Offset: 0x0037F76E
		public IQuestScheduleConfigT UIConfig { get; set; }

		// Token: 0x17007737 RID: 30519
		// (get) Token: 0x06018917 RID: 100631 RVA: 0x00381577 File Offset: 0x0037F777
		// (set) Token: 0x06018918 RID: 100632 RVA: 0x0038157F File Offset: 0x0037F77F
		public IInformationViewConfigT InformationView { get; set; }

		// Token: 0x17007738 RID: 30520
		// (get) Token: 0x06018919 RID: 100633 RVA: 0x00381588 File Offset: 0x0037F788
		// (set) Token: 0x0601891A RID: 100634 RVA: 0x00381590 File Offset: 0x0037F790
		public IInformationBoardConfigT InformationBoard { get; set; }

		// Token: 0x17007739 RID: 30521
		// (get) Token: 0x0601891B RID: 100635 RVA: 0x00381599 File Offset: 0x0037F799
		// (set) Token: 0x0601891C RID: 100636 RVA: 0x003815A1 File Offset: 0x0037F7A1
		public string TidQuestAliasName { get; set; }

		// Token: 0x1700773A RID: 30522
		// (get) Token: 0x0601891D RID: 100637 RVA: 0x003815AA File Offset: 0x0037F7AA
		// (set) Token: 0x0601891E RID: 100638 RVA: 0x003815B2 File Offset: 0x0037F7B2
		public string TidQuestAliasDesc { get; set; }

		// Token: 0x1700773B RID: 30523
		// (get) Token: 0x0601891F RID: 100639 RVA: 0x003815BB File Offset: 0x0037F7BB
		// (set) Token: 0x06018920 RID: 100640 RVA: 0x003815C3 File Offset: 0x0037F7C3
		public int DungeonId { get; set; }

		// Token: 0x1700773C RID: 30524
		// (get) Token: 0x06018921 RID: 100641 RVA: 0x003815CC File Offset: 0x0037F7CC
		// (set) Token: 0x06018922 RID: 100642 RVA: 0x003815D4 File Offset: 0x0037F7D4
		public bool DisableOnline { get; set; }

		// Token: 0x1700773D RID: 30525
		// (get) Token: 0x06018923 RID: 100643 RVA: 0x003815DD File Offset: 0x0037F7DD
		// (set) Token: 0x06018924 RID: 100644 RVA: 0x003815E5 File Offset: 0x0037F7E5
		public ISaveConfigT SaveConfig { get; set; }

		// Token: 0x1700773E RID: 30526
		// (get) Token: 0x06018925 RID: 100645 RVA: 0x003815EE File Offset: 0x0037F7EE
		// (set) Token: 0x06018926 RID: 100646 RVA: 0x003815F6 File Offset: 0x0037F7F6
		public IForceClosedRestrictionT ForceClosedRestriction { get; set; }

		// Token: 0x1700773F RID: 30527
		// (get) Token: 0x06018927 RID: 100647 RVA: 0x003815FF File Offset: 0x0037F7FF
		// (set) Token: 0x06018928 RID: 100648 RVA: 0x00381607 File Offset: 0x0037F807
		public List<string> Occupations { get; set; }

		// Token: 0x17007740 RID: 30528
		// (get) Token: 0x06018929 RID: 100649 RVA: 0x00381610 File Offset: 0x0037F810
		// (set) Token: 0x0601892A RID: 100650 RVA: 0x00381618 File Offset: 0x0037F818
		public ILogicNodeOccupationT OccupationConfig { get; set; }

		// Token: 0x17007741 RID: 30529
		// (get) Token: 0x0601892B RID: 100651 RVA: 0x00381621 File Offset: 0x0037F821
		// (set) Token: 0x0601892C RID: 100652 RVA: 0x00381629 File Offset: 0x0037F829
		public bool DisableSwitchOccupation { get; set; }

		// Token: 0x17007742 RID: 30530
		// (get) Token: 0x0601892D RID: 100653 RVA: 0x00381632 File Offset: 0x0037F832
		// (set) Token: 0x0601892E RID: 100654 RVA: 0x0038163A File Offset: 0x0037F83A
		public EBudgetCameraType BudgetCameraType { get; set; }

		// Token: 0x17007743 RID: 30531
		// (get) Token: 0x0601892F RID: 100655 RVA: 0x00381643 File Offset: 0x0037F843
		// (set) Token: 0x06018930 RID: 100656 RVA: 0x0038164B File Offset: 0x0037F84B
		public IQuestStatisticsT Statistics { get; set; }

		// Token: 0x17007744 RID: 30532
		// (get) Token: 0x06018931 RID: 100657 RVA: 0x00381654 File Offset: 0x0037F854
		// (set) Token: 0x06018932 RID: 100658 RVA: 0x0038165C File Offset: 0x0037F85C
		public ETrackViewMode CompositeTrackViewMode { get; set; }

		// Token: 0x17007745 RID: 30533
		// (get) Token: 0x06018933 RID: 100659 RVA: 0x00381665 File Offset: 0x0037F865
		// (set) Token: 0x06018934 RID: 100660 RVA: 0x0038166D File Offset: 0x0037F86D
		public IQuestRewardConfigT RewardConfig { get; set; }

		// Token: 0x17007746 RID: 30534
		// (get) Token: 0x06018935 RID: 100661 RVA: 0x00381676 File Offset: 0x0037F876
		// (set) Token: 0x06018936 RID: 100662 RVA: 0x0038167E File Offset: 0x0037F87E
		public TSpecialGamePlayConfigUnion SpecialGamePlayConfig { get; set; }

		// Token: 0x17007747 RID: 30535
		// (get) Token: 0x06018937 RID: 100663 RVA: 0x00381687 File Offset: 0x0037F887
		// (set) Token: 0x06018938 RID: 100664 RVA: 0x0038168F File Offset: 0x0037F88F
		public TEnableSystemConfigUnion EnableSystem { get; set; }

		// Token: 0x17007748 RID: 30536
		// (get) Token: 0x06018939 RID: 100665 RVA: 0x00381698 File Offset: 0x0037F898
		// (set) Token: 0x0601893A RID: 100666 RVA: 0x003816A0 File Offset: 0x0037F8A0
		public IWaveConfigT StartWave { get; set; }

		// Token: 0x17007749 RID: 30537
		// (get) Token: 0x0601893B RID: 100667 RVA: 0x003816A9 File Offset: 0x0037F8A9
		// (set) Token: 0x0601893C RID: 100668 RVA: 0x003816B1 File Offset: 0x0037F8B1
		public IDisableTrackAnimT DisableTrackAnim { get; set; }

		// Token: 0x1700774A RID: 30538
		// (get) Token: 0x0601893D RID: 100669 RVA: 0x003816BA File Offset: 0x0037F8BA
		// (set) Token: 0x0601893E RID: 100670 RVA: 0x003816C2 File Offset: 0x0037F8C2
		public bool DisableSwitchGender { get; set; }

		// Token: 0x1700774B RID: 30539
		// (get) Token: 0x0601893F RID: 100671 RVA: 0x003816CB File Offset: 0x0037F8CB
		// (set) Token: 0x06018940 RID: 100672 RVA: 0x003816D3 File Offset: 0x0037F8D3
		public bool DisableFocusMode { get; set; }

		// Token: 0x1700774C RID: 30540
		// (get) Token: 0x06018941 RID: 100673 RVA: 0x003816DC File Offset: 0x0037F8DC
		// (set) Token: 0x06018942 RID: 100674 RVA: 0x003816E4 File Offset: 0x0037F8E4
		public bool DisableSkeletalAnimationCheck { get; set; }

		// Token: 0x1700774D RID: 30541
		// (get) Token: 0x06018943 RID: 100675 RVA: 0x003816ED File Offset: 0x0037F8ED
		// (set) Token: 0x06018944 RID: 100676 RVA: 0x003816F5 File Offset: 0x0037F8F5
		public ILogicProgramSpecialProcessT LogicProgramSpecialProcess { get; set; }

		// Token: 0x1700774E RID: 30542
		// (get) Token: 0x06018945 RID: 100677 RVA: 0x003816FE File Offset: 0x0037F8FE
		// (set) Token: 0x06018946 RID: 100678 RVA: 0x00381706 File Offset: 0x0037F906
		public IQuestBuffActiveRangeT QuestBuffActiveRange { get; set; }

		// Token: 0x1700774F RID: 30543
		// (get) Token: 0x06018947 RID: 100679 RVA: 0x0038170F File Offset: 0x0037F90F
		// (set) Token: 0x06018948 RID: 100680 RVA: 0x00381717 File Offset: 0x0037F917
		public ISunSpiritProcessT SunSpiritProcess { get; set; }

		// Token: 0x17007750 RID: 30544
		// (get) Token: 0x06018949 RID: 100681 RVA: 0x00381720 File Offset: 0x0037F920
		// (set) Token: 0x0601894A RID: 100682 RVA: 0x00381728 File Offset: 0x0037F928
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x17007751 RID: 30545
		// (get) Token: 0x0601894B RID: 100683 RVA: 0x00381731 File Offset: 0x0037F931
		// (set) Token: 0x0601894C RID: 100684 RVA: 0x00381739 File Offset: 0x0037F939
		public bool DisableGlobalTraffic { get; set; }

		// Token: 0x17007752 RID: 30546
		// (get) Token: 0x0601894D RID: 100685 RVA: 0x00381742 File Offset: 0x0037F942
		// (set) Token: 0x0601894E RID: 100686 RVA: 0x0038174A File Offset: 0x0037F94A
		public List<IAreaNameSystemPromptT> DisableSystemPrompt { get; set; }

		// Token: 0x17007753 RID: 30547
		// (get) Token: 0x0601894F RID: 100687 RVA: 0x00381753 File Offset: 0x0037F953
		// (set) Token: 0x06018950 RID: 100688 RVA: 0x0038175B File Offset: 0x0037F95B
		public ITrackCustomBoardOnBtLogicNodeT TrackCustomBoard { get; set; }

		// Token: 0x17007754 RID: 30548
		// (get) Token: 0x06018951 RID: 100689 RVA: 0x00381764 File Offset: 0x0037F964
		// (set) Token: 0x06018952 RID: 100690 RVA: 0x0038176C File Offset: 0x0037F96C
		public List<TBtNodeUnion> Children { get; set; }

		// Token: 0x17007755 RID: 30549
		// (get) Token: 0x06018953 RID: 100691 RVA: 0x00381775 File Offset: 0x0037F975
		// (set) Token: 0x06018954 RID: 100692 RVA: 0x0038177D File Offset: 0x0037F97D
		public EConditionCount Count { get; set; }

		// Token: 0x17007756 RID: 30550
		// (get) Token: 0x06018955 RID: 100693 RVA: 0x00381786 File Offset: 0x0037F986
		// (set) Token: 0x06018956 RID: 100694 RVA: 0x0038178E File Offset: 0x0037F98E
		public IPerformanceSettingT PerformanceSetting { get; set; }

		// Token: 0x17007757 RID: 30551
		// (get) Token: 0x06018957 RID: 100695 RVA: 0x00381797 File Offset: 0x0037F997
		// (set) Token: 0x06018958 RID: 100696 RVA: 0x0038179F File Offset: 0x0037F99F
		public ushort NullMask { get; set; }

		// Token: 0x06018959 RID: 100697 RVA: 0x003817A8 File Offset: 0x0037F9A8
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
