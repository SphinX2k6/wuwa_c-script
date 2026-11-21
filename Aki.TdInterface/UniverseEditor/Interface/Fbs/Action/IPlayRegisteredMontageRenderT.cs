using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B4 RID: 29876
	public class IPlayRegisteredMontageRenderT
	{
		// Token: 0x1700DBB5 RID: 56245
		// (get) Token: 0x06034593 RID: 214419 RVA: 0x0070CF05 File Offset: 0x0070B105
		// (set) Token: 0x06034594 RID: 214420 RVA: 0x0070CF0D File Offset: 0x0070B10D
		public int EntityId { get; set; }

		// Token: 0x1700DBB6 RID: 56246
		// (get) Token: 0x06034595 RID: 214421 RVA: 0x0070CF16 File Offset: 0x0070B116
		// (set) Token: 0x06034596 RID: 214422 RVA: 0x0070CF1E File Offset: 0x0070B11E
		public bool IsOverlayMontage { get; set; }

		// Token: 0x1700DBB7 RID: 56247
		// (get) Token: 0x06034597 RID: 214423 RVA: 0x0070CF27 File Offset: 0x0070B127
		// (set) Token: 0x06034598 RID: 214424 RVA: 0x0070CF2F File Offset: 0x0070B12F
		public IMontageIdT MontageId { get; set; }

		// Token: 0x1700DBB8 RID: 56248
		// (get) Token: 0x06034599 RID: 214425 RVA: 0x0070CF38 File Offset: 0x0070B138
		// (set) Token: 0x0603459A RID: 214426 RVA: 0x0070CF40 File Offset: 0x0070B140
		public int FaceExpressionId { get; set; }

		// Token: 0x1700DBB9 RID: 56249
		// (get) Token: 0x0603459B RID: 214427 RVA: 0x0070CF49 File Offset: 0x0070B149
		// (set) Token: 0x0603459C RID: 214428 RVA: 0x0070CF51 File Offset: 0x0070B151
		public float LoopDuration { get; set; }

		// Token: 0x1700DBBA RID: 56250
		// (get) Token: 0x0603459D RID: 214429 RVA: 0x0070CF5A File Offset: 0x0070B15A
		// (set) Token: 0x0603459E RID: 214430 RVA: 0x0070CF62 File Offset: 0x0070B162
		public int RepeatTimes { get; set; }

		// Token: 0x1700DBBB RID: 56251
		// (get) Token: 0x0603459F RID: 214431 RVA: 0x0070CF6B File Offset: 0x0070B16B
		// (set) Token: 0x060345A0 RID: 214432 RVA: 0x0070CF73 File Offset: 0x0070B173
		public bool KeepMontageWhenEnd { get; set; }

		// Token: 0x1700DBBC RID: 56252
		// (get) Token: 0x060345A1 RID: 214433 RVA: 0x0070CF7C File Offset: 0x0070B17C
		// (set) Token: 0x060345A2 RID: 214434 RVA: 0x0070CF84 File Offset: 0x0070B184
		public bool KeepMontageAfterFlow { get; set; }

		// Token: 0x1700DBBD RID: 56253
		// (get) Token: 0x060345A3 RID: 214435 RVA: 0x0070CF8D File Offset: 0x0070B18D
		// (set) Token: 0x060345A4 RID: 214436 RVA: 0x0070CF95 File Offset: 0x0070B195
		public byte NullMask { get; set; }

		// Token: 0x060345A5 RID: 214437 RVA: 0x0070CFA0 File Offset: 0x0070B1A0
		public IPlayRegisteredMontageRenderT()
		{
			this.EntityId = 0;
			this.IsOverlayMontage = false;
			this.MontageId = null;
			this.FaceExpressionId = 0;
			this.LoopDuration = 0f;
			this.RepeatTimes = 0;
			this.KeepMontageWhenEnd = false;
			this.KeepMontageAfterFlow = false;
			this.NullMask = 0;
		}
	}
}
