using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FB7 RID: 16311
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotReviewItemData
	{
		// Token: 0x1700538B RID: 21387
		// (get) Token: 0x0602944E RID: 169038 RVA: 0x00B9798F File Offset: 0x00B95B8F
		// (set) Token: 0x0602944F RID: 169039 RVA: 0x00B97997 File Offset: 0x00B95B97
		public EPlotReviewItemType Type { get; set; }

		// Token: 0x1700538C RID: 21388
		// (get) Token: 0x06029450 RID: 169040 RVA: 0x00B979A0 File Offset: 0x00B95BA0
		// (set) Token: 0x06029451 RID: 169041 RVA: 0x00B979A8 File Offset: 0x00B95BA8
		public object Data { get; set; }
	}
}
