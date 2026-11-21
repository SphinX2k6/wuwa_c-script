using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050A7 RID: 20647
	public class IComparePlayerMotionStateT
	{
		// Token: 0x170093E3 RID: 37859
		// (get) Token: 0x0602051C RID: 132380 RVA: 0x00479F07 File Offset: 0x00478107
		// (set) Token: 0x0602051D RID: 132381 RVA: 0x00479F0F File Offset: 0x0047810F
		public ECondition Type { get; set; }

		// Token: 0x170093E4 RID: 37860
		// (get) Token: 0x0602051E RID: 132382 RVA: 0x00479F18 File Offset: 0x00478118
		// (set) Token: 0x0602051F RID: 132383 RVA: 0x00479F20 File Offset: 0x00478120
		public EPlayerMotionState MotionState { get; set; }

		// Token: 0x170093E5 RID: 37861
		// (get) Token: 0x06020520 RID: 132384 RVA: 0x00479F29 File Offset: 0x00478129
		// (set) Token: 0x06020521 RID: 132385 RVA: 0x00479F31 File Offset: 0x00478131
		public ECompare Compare { get; set; }

		// Token: 0x170093E6 RID: 37862
		// (get) Token: 0x06020522 RID: 132386 RVA: 0x00479F3A File Offset: 0x0047813A
		// (set) Token: 0x06020523 RID: 132387 RVA: 0x00479F42 File Offset: 0x00478142
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x06020524 RID: 132388 RVA: 0x00479F4B File Offset: 0x0047814B
		public IComparePlayerMotionStateT()
		{
			this.Type = ECondition.CompareVar;
			this.MotionState = EPlayerMotionState.Ground;
			this.Compare = ECompare.Eq;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
