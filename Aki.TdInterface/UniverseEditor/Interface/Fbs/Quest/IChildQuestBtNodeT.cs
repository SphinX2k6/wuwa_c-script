using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.FixProcessor;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D89 RID: 15753
	public class IChildQuestBtNodeT
	{
		// Token: 0x17006C37 RID: 27703
		// (get) Token: 0x06015DB8 RID: 89528 RVA: 0x0032860E File Offset: 0x0032680E
		// (set) Token: 0x06015DB9 RID: 89529 RVA: 0x00328616 File Offset: 0x00326816
		public EBtNode Type { get; set; }

		// Token: 0x17006C38 RID: 27704
		// (get) Token: 0x06015DBA RID: 89530 RVA: 0x0032861F File Offset: 0x0032681F
		// (set) Token: 0x06015DBB RID: 89531 RVA: 0x00328627 File Offset: 0x00326827
		public int Id { get; set; }

		// Token: 0x17006C39 RID: 27705
		// (get) Token: 0x06015DBC RID: 89532 RVA: 0x00328630 File Offset: 0x00326830
		// (set) Token: 0x06015DBD RID: 89533 RVA: 0x00328638 File Offset: 0x00326838
		public string Desc { get; set; }

		// Token: 0x17006C3A RID: 27706
		// (get) Token: 0x06015DBE RID: 89534 RVA: 0x00328641 File Offset: 0x00326841
		// (set) Token: 0x06015DBF RID: 89535 RVA: 0x00328649 File Offset: 0x00326849
		public IFixProcessorT FixProcessor { get; set; }

		// Token: 0x17006C3B RID: 27707
		// (get) Token: 0x06015DC0 RID: 89536 RVA: 0x00328652 File Offset: 0x00326852
		// (set) Token: 0x06015DC1 RID: 89537 RVA: 0x0032865A File Offset: 0x0032685A
		public bool _FoldedForTree { get; set; }

		// Token: 0x17006C3C RID: 27708
		// (get) Token: 0x06015DC2 RID: 89538 RVA: 0x00328663 File Offset: 0x00326863
		// (set) Token: 0x06015DC3 RID: 89539 RVA: 0x0032866B File Offset: 0x0032686B
		public bool Disabled { get; set; }

		// Token: 0x17006C3D RID: 27709
		// (get) Token: 0x06015DC4 RID: 89540 RVA: 0x00328674 File Offset: 0x00326874
		// (set) Token: 0x06015DC5 RID: 89541 RVA: 0x0032867C File Offset: 0x0032687C
		public int RewardId { get; set; }

		// Token: 0x17006C3E RID: 27710
		// (get) Token: 0x06015DC6 RID: 89542 RVA: 0x00328685 File Offset: 0x00326885
		// (set) Token: 0x06015DC7 RID: 89543 RVA: 0x0032868D File Offset: 0x0032688D
		public EItemGetUiType RewardGetUiType { get; set; }

		// Token: 0x17006C3F RID: 27711
		// (get) Token: 0x06015DC8 RID: 89544 RVA: 0x00328696 File Offset: 0x00326896
		// (set) Token: 0x06015DC9 RID: 89545 RVA: 0x0032869E File Offset: 0x0032689E
		public IItemGetUiConfigSpecialQuestT RewardGetUiConfig { get; set; }

		// Token: 0x17006C40 RID: 27712
		// (get) Token: 0x06015DCA RID: 89546 RVA: 0x003286A7 File Offset: 0x003268A7
		// (set) Token: 0x06015DCB RID: 89547 RVA: 0x003286AF File Offset: 0x003268AF
		public bool HideTip { get; set; }

		// Token: 0x17006C41 RID: 27713
		// (get) Token: 0x06015DCC RID: 89548 RVA: 0x003286B8 File Offset: 0x003268B8
		// (set) Token: 0x06015DCD RID: 89549 RVA: 0x003286C0 File Offset: 0x003268C0
		public string TidTip { get; set; }

		// Token: 0x17006C42 RID: 27714
		// (get) Token: 0x06015DCE RID: 89550 RVA: 0x003286C9 File Offset: 0x003268C9
		// (set) Token: 0x06015DCF RID: 89551 RVA: 0x003286D1 File Offset: 0x003268D1
		public bool ShowTipBeforeEnterActions { get; set; }

		// Token: 0x17006C43 RID: 27715
		// (get) Token: 0x06015DD0 RID: 89552 RVA: 0x003286DA File Offset: 0x003268DA
		// (set) Token: 0x06015DD1 RID: 89553 RVA: 0x003286E2 File Offset: 0x003268E2
		public bool ShowNavigation { get; set; }

		// Token: 0x17006C44 RID: 27716
		// (get) Token: 0x06015DD2 RID: 89554 RVA: 0x003286EB File Offset: 0x003268EB
		// (set) Token: 0x06015DD3 RID: 89555 RVA: 0x003286F3 File Offset: 0x003268F3
		public ENavigationStyle NavigationStyle { get; set; }

		// Token: 0x17006C45 RID: 27717
		// (get) Token: 0x06015DD4 RID: 89556 RVA: 0x003286FC File Offset: 0x003268FC
		// (set) Token: 0x06015DD5 RID: 89557 RVA: 0x00328704 File Offset: 0x00326904
		public bool AlwaysShowNavigation { get; set; }

		// Token: 0x17006C46 RID: 27718
		// (get) Token: 0x06015DD6 RID: 89558 RVA: 0x0032870D File Offset: 0x0032690D
		// (set) Token: 0x06015DD7 RID: 89559 RVA: 0x00328715 File Offset: 0x00326915
		public List<IActionInfoT> EnterActions { get; set; }

		// Token: 0x17006C47 RID: 27719
		// (get) Token: 0x06015DD8 RID: 89560 RVA: 0x0032871E File Offset: 0x0032691E
		// (set) Token: 0x06015DD9 RID: 89561 RVA: 0x00328726 File Offset: 0x00326926
		public List<IActionInfoT> FinishActions { get; set; }

		// Token: 0x17006C48 RID: 27720
		// (get) Token: 0x06015DDA RID: 89562 RVA: 0x0032872F File Offset: 0x0032692F
		// (set) Token: 0x06015DDB RID: 89563 RVA: 0x00328737 File Offset: 0x00326937
		public ITrackTargetT TrackTarget { get; set; }

		// Token: 0x17006C49 RID: 27721
		// (get) Token: 0x06015DDC RID: 89564 RVA: 0x00328740 File Offset: 0x00326940
		// (set) Token: 0x06015DDD RID: 89565 RVA: 0x00328748 File Offset: 0x00326948
		public TChildQuestConditionUnion Condition { get; set; }

		// Token: 0x17006C4A RID: 27722
		// (get) Token: 0x06015DDE RID: 89566 RVA: 0x00328751 File Offset: 0x00326951
		// (set) Token: 0x06015DDF RID: 89567 RVA: 0x00328759 File Offset: 0x00326959
		public bool HideUi { get; set; }

		// Token: 0x17006C4B RID: 27723
		// (get) Token: 0x06015DE0 RID: 89568 RVA: 0x00328762 File Offset: 0x00326962
		// (set) Token: 0x06015DE1 RID: 89569 RVA: 0x0032876A File Offset: 0x0032696A
		public bool HideUiExceptTaskList { get; set; }

		// Token: 0x17006C4C RID: 27724
		// (get) Token: 0x06015DE2 RID: 89570 RVA: 0x00328773 File Offset: 0x00326973
		// (set) Token: 0x06015DE3 RID: 89571 RVA: 0x0032877B File Offset: 0x0032697B
		public TSaveConfigUnion SaveConfig { get; set; }

		// Token: 0x17006C4D RID: 27725
		// (get) Token: 0x06015DE4 RID: 89572 RVA: 0x00328784 File Offset: 0x00326984
		// (set) Token: 0x06015DE5 RID: 89573 RVA: 0x0032878C File Offset: 0x0032698C
		public int CustomIcon { get; set; }

		// Token: 0x17006C4E RID: 27726
		// (get) Token: 0x06015DE6 RID: 89574 RVA: 0x00328795 File Offset: 0x00326995
		// (set) Token: 0x06015DE7 RID: 89575 RVA: 0x0032879D File Offset: 0x0032699D
		public int CustomTrackUiPrefabId { get; set; }

		// Token: 0x17006C4F RID: 27727
		// (get) Token: 0x06015DE8 RID: 89576 RVA: 0x003287A6 File Offset: 0x003269A6
		// (set) Token: 0x06015DE9 RID: 89577 RVA: 0x003287AE File Offset: 0x003269AE
		public List<IStuckCheckConditionT> StuckCheck { get; set; }

		// Token: 0x17006C50 RID: 27728
		// (get) Token: 0x06015DEA RID: 89578 RVA: 0x003287B7 File Offset: 0x003269B7
		// (set) Token: 0x06015DEB RID: 89579 RVA: 0x003287BF File Offset: 0x003269BF
		public ITrackAreaTextT ModifyTrackAreaText { get; set; }

		// Token: 0x17006C51 RID: 27729
		// (get) Token: 0x06015DEC RID: 89580 RVA: 0x003287C8 File Offset: 0x003269C8
		// (set) Token: 0x06015DED RID: 89581 RVA: 0x003287D0 File Offset: 0x003269D0
		public ITrackCustomBoardT TrackCustomBoard { get; set; }

		// Token: 0x17006C52 RID: 27730
		// (get) Token: 0x06015DEE RID: 89582 RVA: 0x003287D9 File Offset: 0x003269D9
		// (set) Token: 0x06015DEF RID: 89583 RVA: 0x003287E1 File Offset: 0x003269E1
		public ushort NullMask { get; set; }

		// Token: 0x06015DF0 RID: 89584 RVA: 0x003287EC File Offset: 0x003269EC
		public IChildQuestBtNodeT()
		{
			this.Type = EBtNode.Start;
			this.Id = 0;
			this.Desc = null;
			this.FixProcessor = null;
			this._FoldedForTree = false;
			this.Disabled = false;
			this.RewardId = 0;
			this.RewardGetUiType = EItemGetUiType.None;
			this.RewardGetUiConfig = null;
			this.HideTip = false;
			this.TidTip = null;
			this.ShowTipBeforeEnterActions = false;
			this.ShowNavigation = false;
			this.NavigationStyle = ENavigationStyle.Default;
			this.AlwaysShowNavigation = false;
			this.EnterActions = null;
			this.FinishActions = null;
			this.TrackTarget = null;
			this.Condition = null;
			this.HideUi = false;
			this.HideUiExceptTaskList = false;
			this.SaveConfig = null;
			this.CustomIcon = 0;
			this.CustomTrackUiPrefabId = 0;
			this.StuckCheck = null;
			this.ModifyTrackAreaText = null;
			this.TrackCustomBoard = null;
			this.NullMask = 0;
		}
	}
}
