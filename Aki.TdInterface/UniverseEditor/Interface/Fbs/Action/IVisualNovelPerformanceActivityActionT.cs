using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D8F RID: 32143
	public class IVisualNovelPerformanceActivityActionT
	{
		// Token: 0x1700F06E RID: 61550
		// (get) Token: 0x0603A056 RID: 237654 RVA: 0x007D2473 File Offset: 0x007D0673
		// (set) Token: 0x0603A057 RID: 237655 RVA: 0x007D247B File Offset: 0x007D067B
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F06F RID: 61551
		// (get) Token: 0x0603A058 RID: 237656 RVA: 0x007D2484 File Offset: 0x007D0684
		// (set) Token: 0x0603A059 RID: 237657 RVA: 0x007D248C File Offset: 0x007D068C
		public float StartTime { get; set; }

		// Token: 0x1700F070 RID: 61552
		// (get) Token: 0x0603A05A RID: 237658 RVA: 0x007D2495 File Offset: 0x007D0695
		// (set) Token: 0x0603A05B RID: 237659 RVA: 0x007D249D File Offset: 0x007D069D
		public IVisualNovelActivityActionSolarSchoolT ActivityActionConfig { get; set; }

		// Token: 0x1700F071 RID: 61553
		// (get) Token: 0x0603A05C RID: 237660 RVA: 0x007D24A6 File Offset: 0x007D06A6
		// (set) Token: 0x0603A05D RID: 237661 RVA: 0x007D24AE File Offset: 0x007D06AE
		public byte NullMask { get; set; }

		// Token: 0x0603A05E RID: 237662 RVA: 0x007D24B7 File Offset: 0x007D06B7
		public IVisualNovelPerformanceActivityActionT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.ActivityActionConfig = null;
			this.NullMask = 0;
		}
	}
}
