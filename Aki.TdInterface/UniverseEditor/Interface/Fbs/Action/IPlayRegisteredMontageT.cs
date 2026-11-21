using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074B1 RID: 29873
	public class IPlayRegisteredMontageT
	{
		// Token: 0x1700DBA1 RID: 56225
		// (get) Token: 0x0603455F RID: 214367 RVA: 0x0070C854 File Offset: 0x0070AA54
		// (set) Token: 0x06034560 RID: 214368 RVA: 0x0070C85C File Offset: 0x0070AA5C
		public int EntityId { get; set; }

		// Token: 0x1700DBA2 RID: 56226
		// (get) Token: 0x06034561 RID: 214369 RVA: 0x0070C865 File Offset: 0x0070AA65
		// (set) Token: 0x06034562 RID: 214370 RVA: 0x0070C86D File Offset: 0x0070AA6D
		public int MontageId { get; set; }

		// Token: 0x1700DBA3 RID: 56227
		// (get) Token: 0x06034563 RID: 214371 RVA: 0x0070C876 File Offset: 0x0070AA76
		// (set) Token: 0x06034564 RID: 214372 RVA: 0x0070C87E File Offset: 0x0070AA7E
		public bool IsOverlayMontage { get; set; }

		// Token: 0x1700DBA4 RID: 56228
		// (get) Token: 0x06034565 RID: 214373 RVA: 0x0070C887 File Offset: 0x0070AA87
		// (set) Token: 0x06034566 RID: 214374 RVA: 0x0070C88F File Offset: 0x0070AA8F
		public bool IsAbpMontage { get; set; }

		// Token: 0x1700DBA5 RID: 56229
		// (get) Token: 0x06034567 RID: 214375 RVA: 0x0070C898 File Offset: 0x0070AA98
		// (set) Token: 0x06034568 RID: 214376 RVA: 0x0070C8A0 File Offset: 0x0070AAA0
		public int FaceExpressionId { get; set; }

		// Token: 0x1700DBA6 RID: 56230
		// (get) Token: 0x06034569 RID: 214377 RVA: 0x0070C8A9 File Offset: 0x0070AAA9
		// (set) Token: 0x0603456A RID: 214378 RVA: 0x0070C8B1 File Offset: 0x0070AAB1
		public float LoopDuration { get; set; }

		// Token: 0x1700DBA7 RID: 56231
		// (get) Token: 0x0603456B RID: 214379 RVA: 0x0070C8BA File Offset: 0x0070AABA
		// (set) Token: 0x0603456C RID: 214380 RVA: 0x0070C8C2 File Offset: 0x0070AAC2
		public int RepeatTimes { get; set; }

		// Token: 0x1700DBA8 RID: 56232
		// (get) Token: 0x0603456D RID: 214381 RVA: 0x0070C8CB File Offset: 0x0070AACB
		// (set) Token: 0x0603456E RID: 214382 RVA: 0x0070C8D3 File Offset: 0x0070AAD3
		public bool KeepMontageWhenEnd { get; set; }

		// Token: 0x1700DBA9 RID: 56233
		// (get) Token: 0x0603456F RID: 214383 RVA: 0x0070C8DC File Offset: 0x0070AADC
		// (set) Token: 0x06034570 RID: 214384 RVA: 0x0070C8E4 File Offset: 0x0070AAE4
		public bool KeepMontageAfterFlow { get; set; }

		// Token: 0x1700DBAA RID: 56234
		// (get) Token: 0x06034571 RID: 214385 RVA: 0x0070C8ED File Offset: 0x0070AAED
		// (set) Token: 0x06034572 RID: 214386 RVA: 0x0070C8F5 File Offset: 0x0070AAF5
		public byte NullMask { get; set; }

		// Token: 0x06034573 RID: 214387 RVA: 0x0070C900 File Offset: 0x0070AB00
		public IPlayRegisteredMontageT()
		{
			this.EntityId = 0;
			this.MontageId = 0;
			this.IsOverlayMontage = false;
			this.IsAbpMontage = false;
			this.FaceExpressionId = 0;
			this.LoopDuration = 0f;
			this.RepeatTimes = 0;
			this.KeepMontageWhenEnd = false;
			this.KeepMontageAfterFlow = false;
			this.NullMask = 0;
		}
	}
}
