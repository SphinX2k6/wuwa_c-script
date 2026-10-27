using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D4B RID: 27979
	public class IPlayWalkingOverlayRenderMontageT
	{
		// Token: 0x1700D0B1 RID: 53425
		// (get) Token: 0x0603167D RID: 202365 RVA: 0x006B332D File Offset: 0x006B152D
		// (set) Token: 0x0603167E RID: 202366 RVA: 0x006B3335 File Offset: 0x006B1535
		public int EntityId { get; set; }

		// Token: 0x1700D0B2 RID: 53426
		// (get) Token: 0x0603167F RID: 202367 RVA: 0x006B333E File Offset: 0x006B153E
		// (set) Token: 0x06031680 RID: 202368 RVA: 0x006B3346 File Offset: 0x006B1546
		public IMontageIdT OverlapMontageId { get; set; }

		// Token: 0x1700D0B3 RID: 53427
		// (get) Token: 0x06031681 RID: 202369 RVA: 0x006B334F File Offset: 0x006B154F
		// (set) Token: 0x06031682 RID: 202370 RVA: 0x006B3357 File Offset: 0x006B1557
		public float LoopDuration { get; set; }

		// Token: 0x1700D0B4 RID: 53428
		// (get) Token: 0x06031683 RID: 202371 RVA: 0x006B3360 File Offset: 0x006B1560
		// (set) Token: 0x06031684 RID: 202372 RVA: 0x006B3368 File Offset: 0x006B1568
		public int RepeatTimes { get; set; }

		// Token: 0x1700D0B5 RID: 53429
		// (get) Token: 0x06031685 RID: 202373 RVA: 0x006B3371 File Offset: 0x006B1571
		// (set) Token: 0x06031686 RID: 202374 RVA: 0x006B3379 File Offset: 0x006B1579
		public byte NullMask { get; set; }

		// Token: 0x06031687 RID: 202375 RVA: 0x006B3382 File Offset: 0x006B1582
		public IPlayWalkingOverlayRenderMontageT()
		{
			this.EntityId = 0;
			this.OverlapMontageId = null;
			this.LoopDuration = 0f;
			this.RepeatTimes = 0;
			this.NullMask = 0;
		}
	}
}
