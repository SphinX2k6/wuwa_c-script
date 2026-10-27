using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B63 RID: 19299
	public class ICheckTrafficBlockedT
	{
		// Token: 0x17008C0C RID: 35852
		// (get) Token: 0x0601E67B RID: 124539 RVA: 0x00442527 File Offset: 0x00440727
		// (set) Token: 0x0601E67C RID: 124540 RVA: 0x0044252F File Offset: 0x0044072F
		public ECondition Type { get; set; }

		// Token: 0x17008C0D RID: 35853
		// (get) Token: 0x0601E67D RID: 124541 RVA: 0x00442538 File Offset: 0x00440738
		// (set) Token: 0x0601E67E RID: 124542 RVA: 0x00442540 File Offset: 0x00440740
		public bool IsBlocked { get; set; }

		// Token: 0x17008C0E RID: 35854
		// (get) Token: 0x0601E67F RID: 124543 RVA: 0x00442549 File Offset: 0x00440749
		// (set) Token: 0x0601E680 RID: 124544 RVA: 0x00442551 File Offset: 0x00440751
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x17008C0F RID: 35855
		// (get) Token: 0x0601E681 RID: 124545 RVA: 0x0044255A File Offset: 0x0044075A
		// (set) Token: 0x0601E682 RID: 124546 RVA: 0x00442562 File Offset: 0x00440762
		public ITrafficMatchTargetT MatchTarget { get; set; }

		// Token: 0x0601E683 RID: 124547 RVA: 0x0044256B File Offset: 0x0044076B
		public ICheckTrafficBlockedT()
		{
			this.Type = ECondition.CompareVar;
			this.IsBlocked = false;
			this.Target = null;
			this.MatchTarget = null;
		}
	}
}
