using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FED RID: 20461
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotReviewItemData
	{
		// Token: 0x17007FD6 RID: 32726
		// (get) Token: 0x060345C3 RID: 214467 RVA: 0x00C4D92F File Offset: 0x00C4BB2F
		// (set) Token: 0x060345C4 RID: 214468 RVA: 0x00C4D937 File Offset: 0x00C4BB37
		public EPlotReviewItemType Type { get; set; }

		// Token: 0x17007FD7 RID: 32727
		// (get) Token: 0x060345C5 RID: 214469 RVA: 0x00C4D940 File Offset: 0x00C4BB40
		// (set) Token: 0x060345C6 RID: 214470 RVA: 0x00C4D948 File Offset: 0x00C4BB48
		public object Data { get; set; }
	}
}
