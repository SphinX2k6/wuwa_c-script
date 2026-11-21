using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Skin.Skip
{
	// Token: 0x02003BA4 RID: 15268
	[NullableContext(1)]
	[Nullable(0)]
	public class SkinSkipData : ISkinSkipData
	{
		// Token: 0x1700501B RID: 20507
		// (get) Token: 0x06027206 RID: 160262 RVA: 0x00AF25E6 File Offset: 0x00AF07E6
		// (set) Token: 0x06027207 RID: 160263 RVA: 0x00AF25EE File Offset: 0x00AF07EE
		public int Id { get; set; }

		// Token: 0x1700501C RID: 20508
		// (get) Token: 0x06027208 RID: 160264 RVA: 0x00AF25F7 File Offset: 0x00AF07F7
		// (set) Token: 0x06027209 RID: 160265 RVA: 0x00AF25FF File Offset: 0x00AF07FF
		public int ConfigId { get; set; }

		// Token: 0x1700501D RID: 20509
		// (get) Token: 0x0602720A RID: 160266 RVA: 0x00AF2608 File Offset: 0x00AF0808
		// (set) Token: 0x0602720B RID: 160267 RVA: 0x00AF2610 File Offset: 0x00AF0810
		public ESkinSkipType Type { get; set; }

		// Token: 0x1700501E RID: 20510
		// (get) Token: 0x0602720C RID: 160268 RVA: 0x00AF2619 File Offset: 0x00AF0819
		// (set) Token: 0x0602720D RID: 160269 RVA: 0x00AF2621 File Offset: 0x00AF0821
		public string Text { get; set; }

		// Token: 0x1700501F RID: 20511
		// (get) Token: 0x0602720E RID: 160270 RVA: 0x00AF262A File Offset: 0x00AF082A
		// (set) Token: 0x0602720F RID: 160271 RVA: 0x00AF2632 File Offset: 0x00AF0832
		public int SortIndex { get; set; }
	}
}
