using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070EF RID: 28911
	public class ILiveDanmakuPoolT
	{
		// Token: 0x1700D3B8 RID: 54200
		// (get) Token: 0x06032356 RID: 205654 RVA: 0x006CAA3C File Offset: 0x006C8C3C
		// (set) Token: 0x06032357 RID: 205655 RVA: 0x006CAA44 File Offset: 0x006C8C44
		public int DanmakuPoolId { get; set; }

		// Token: 0x1700D3B9 RID: 54201
		// (get) Token: 0x06032358 RID: 205656 RVA: 0x006CAA4D File Offset: 0x006C8C4D
		// (set) Token: 0x06032359 RID: 205657 RVA: 0x006CAA55 File Offset: 0x006C8C55
		public float Weight { get; set; }

		// Token: 0x1700D3BA RID: 54202
		// (get) Token: 0x0603235A RID: 205658 RVA: 0x006CAA5E File Offset: 0x006C8C5E
		// (set) Token: 0x0603235B RID: 205659 RVA: 0x006CAA66 File Offset: 0x006C8C66
		public float DelayTime { get; set; }

		// Token: 0x1700D3BB RID: 54203
		// (get) Token: 0x0603235C RID: 205660 RVA: 0x006CAA6F File Offset: 0x006C8C6F
		// (set) Token: 0x0603235D RID: 205661 RVA: 0x006CAA77 File Offset: 0x006C8C77
		public ELiveDanmakuLoopType LoopType { get; set; }

		// Token: 0x0603235E RID: 205662 RVA: 0x006CAA80 File Offset: 0x006C8C80
		public ILiveDanmakuPoolT()
		{
			this.DanmakuPoolId = 0;
			this.Weight = 0f;
			this.DelayTime = 0f;
			this.LoopType = ELiveDanmakuLoopType.OrderOnce;
		}
	}
}
