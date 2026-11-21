using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.HonamiStory
{
	// Token: 0x0200490A RID: 18698
	[NullableContext(1)]
	[Nullable(0)]
	public class HonamiStoryDragItemHoverInfo : IHonamiStoryDragItemHoverInfo
	{
		// Token: 0x17005EB8 RID: 24248
		// (get) Token: 0x0602EF08 RID: 192264 RVA: 0x00D1972E File Offset: 0x00D1792E
		// (set) Token: 0x0602EF09 RID: 192265 RVA: 0x00D19736 File Offset: 0x00D17936
		public bool IsValid { get; set; }

		// Token: 0x17005EB9 RID: 24249
		// (get) Token: 0x0602EF0A RID: 192266 RVA: 0x00D1973F File Offset: 0x00D1793F
		// (set) Token: 0x0602EF0B RID: 192267 RVA: 0x00D19747 File Offset: 0x00D17947
		public int StartPosition { get; set; }

		// Token: 0x17005EBA RID: 24250
		// (get) Token: 0x0602EF0C RID: 192268 RVA: 0x00D19750 File Offset: 0x00D17950
		// (set) Token: 0x0602EF0D RID: 192269 RVA: 0x00D19758 File Offset: 0x00D17958
		public int EndPosition { get; set; }

		// Token: 0x17005EBB RID: 24251
		// (get) Token: 0x0602EF0E RID: 192270 RVA: 0x00D19761 File Offset: 0x00D17961
		// (set) Token: 0x0602EF0F RID: 192271 RVA: 0x00D19769 File Offset: 0x00D17969
		public int Height { get; set; }

		// Token: 0x17005EBC RID: 24252
		// (get) Token: 0x0602EF10 RID: 192272 RVA: 0x00D19772 File Offset: 0x00D17972
		// (set) Token: 0x0602EF11 RID: 192273 RVA: 0x00D1977A File Offset: 0x00D1797A
		public int Width { get; set; }

		// Token: 0x17005EBD RID: 24253
		// (get) Token: 0x0602EF12 RID: 192274 RVA: 0x00D19783 File Offset: 0x00D17983
		// (set) Token: 0x0602EF13 RID: 192275 RVA: 0x00D1978B File Offset: 0x00D1798B
		public List<int> FillPosList { get; set; } = new List<int>();
	}
}
