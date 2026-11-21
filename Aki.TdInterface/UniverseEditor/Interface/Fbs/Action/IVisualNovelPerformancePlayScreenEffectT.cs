using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007DB0 RID: 32176
	public class IVisualNovelPerformancePlayScreenEffectT
	{
		// Token: 0x1700F0F2 RID: 61682
		// (get) Token: 0x0603A215 RID: 238101 RVA: 0x007D640F File Offset: 0x007D460F
		// (set) Token: 0x0603A216 RID: 238102 RVA: 0x007D6417 File Offset: 0x007D4617
		public EVisualNovelPerformanceType Type { get; set; }

		// Token: 0x1700F0F3 RID: 61683
		// (get) Token: 0x0603A217 RID: 238103 RVA: 0x007D6420 File Offset: 0x007D4620
		// (set) Token: 0x0603A218 RID: 238104 RVA: 0x007D6428 File Offset: 0x007D4628
		public float StartTime { get; set; }

		// Token: 0x1700F0F4 RID: 61684
		// (get) Token: 0x0603A219 RID: 238105 RVA: 0x007D6431 File Offset: 0x007D4631
		// (set) Token: 0x0603A21A RID: 238106 RVA: 0x007D6439 File Offset: 0x007D4639
		public TVisualNovelPlayScreenEffectConfigUnion EffectConfig { get; set; }

		// Token: 0x1700F0F5 RID: 61685
		// (get) Token: 0x0603A21B RID: 238107 RVA: 0x007D6442 File Offset: 0x007D4642
		// (set) Token: 0x0603A21C RID: 238108 RVA: 0x007D644A File Offset: 0x007D464A
		public byte NullMask { get; set; }

		// Token: 0x0603A21D RID: 238109 RVA: 0x007D6453 File Offset: 0x007D4653
		public IVisualNovelPerformancePlayScreenEffectT()
		{
			this.Type = EVisualNovelPerformanceType.Enter;
			this.StartTime = 0f;
			this.EffectConfig = null;
			this.NullMask = 0;
		}
	}
}
