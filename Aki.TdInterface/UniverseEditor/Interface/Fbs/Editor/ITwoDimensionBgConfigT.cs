using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x020048B1 RID: 18609
	public class ITwoDimensionBgConfigT
	{
		// Token: 0x170086EE RID: 34542
		// (get) Token: 0x0601D0D6 RID: 118998 RVA: 0x0041A3FB File Offset: 0x004185FB
		// (set) Token: 0x0601D0D7 RID: 118999 RVA: 0x0041A403 File Offset: 0x00418603
		public string BgUrl { get; set; }

		// Token: 0x170086EF RID: 34543
		// (get) Token: 0x0601D0D8 RID: 119000 RVA: 0x0041A40C File Offset: 0x0041860C
		// (set) Token: 0x0601D0D9 RID: 119001 RVA: 0x0041A414 File Offset: 0x00418614
		public int Width { get; set; }

		// Token: 0x170086F0 RID: 34544
		// (get) Token: 0x0601D0DA RID: 119002 RVA: 0x0041A41D File Offset: 0x0041861D
		// (set) Token: 0x0601D0DB RID: 119003 RVA: 0x0041A425 File Offset: 0x00418625
		public int Height { get; set; }

		// Token: 0x170086F1 RID: 34545
		// (get) Token: 0x0601D0DC RID: 119004 RVA: 0x0041A42E File Offset: 0x0041862E
		// (set) Token: 0x0601D0DD RID: 119005 RVA: 0x0041A436 File Offset: 0x00418636
		public float Scale { get; set; }

		// Token: 0x0601D0DE RID: 119006 RVA: 0x0041A43F File Offset: 0x0041863F
		public ITwoDimensionBgConfigT()
		{
			this.BgUrl = null;
			this.Width = 0;
			this.Height = 0;
			this.Scale = 0f;
		}
	}
}
