using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200689C RID: 26780
	public class IBubbleCylinderConfigT
	{
		// Token: 0x1700C4CA RID: 50378
		// (get) Token: 0x0602DC7F RID: 187519 RVA: 0x00641F7C File Offset: 0x0064017C
		// (set) Token: 0x0602DC80 RID: 187520 RVA: 0x00641F84 File Offset: 0x00640184
		public float Radius { get; set; }

		// Token: 0x1700C4CB RID: 50379
		// (get) Token: 0x0602DC81 RID: 187521 RVA: 0x00641F8D File Offset: 0x0064018D
		// (set) Token: 0x0602DC82 RID: 187522 RVA: 0x00641F95 File Offset: 0x00640195
		public float Height { get; set; }

		// Token: 0x0602DC83 RID: 187523 RVA: 0x00641F9E File Offset: 0x0064019E
		public IBubbleCylinderConfigT()
		{
			this.Radius = 0f;
			this.Height = 0f;
		}
	}
}
