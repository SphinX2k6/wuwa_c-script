using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C3 RID: 29891
	public class IPlayWalkingOverlayMontageT
	{
		// Token: 0x1700DBEE RID: 56302
		// (get) Token: 0x06034657 RID: 214615 RVA: 0x0070E5EE File Offset: 0x0070C7EE
		// (set) Token: 0x06034658 RID: 214616 RVA: 0x0070E5F6 File Offset: 0x0070C7F6
		public int EntityId { get; set; }

		// Token: 0x1700DBEF RID: 56303
		// (get) Token: 0x06034659 RID: 214617 RVA: 0x0070E5FF File Offset: 0x0070C7FF
		// (set) Token: 0x0603465A RID: 214618 RVA: 0x0070E607 File Offset: 0x0070C807
		public int OverlapMontageId { get; set; }

		// Token: 0x1700DBF0 RID: 56304
		// (get) Token: 0x0603465B RID: 214619 RVA: 0x0070E610 File Offset: 0x0070C810
		// (set) Token: 0x0603465C RID: 214620 RVA: 0x0070E618 File Offset: 0x0070C818
		public float LoopDuration { get; set; }

		// Token: 0x1700DBF1 RID: 56305
		// (get) Token: 0x0603465D RID: 214621 RVA: 0x0070E621 File Offset: 0x0070C821
		// (set) Token: 0x0603465E RID: 214622 RVA: 0x0070E629 File Offset: 0x0070C829
		public int RepeatTimes { get; set; }

		// Token: 0x1700DBF2 RID: 56306
		// (get) Token: 0x0603465F RID: 214623 RVA: 0x0070E632 File Offset: 0x0070C832
		// (set) Token: 0x06034660 RID: 214624 RVA: 0x0070E63A File Offset: 0x0070C83A
		public byte NullMask { get; set; }

		// Token: 0x06034661 RID: 214625 RVA: 0x0070E643 File Offset: 0x0070C843
		public IPlayWalkingOverlayMontageT()
		{
			this.EntityId = 0;
			this.OverlapMontageId = 0;
			this.LoopDuration = 0f;
			this.RepeatTimes = 0;
			this.NullMask = 0;
		}
	}
}
