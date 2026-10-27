using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005081 RID: 20609
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextScrollComponentContext
	{
		// Token: 0x1700806C RID: 32876
		// (get) Token: 0x06034CD8 RID: 216280 RVA: 0x00C7DB72 File Offset: 0x00C7BD72
		// (set) Token: 0x06034CD9 RID: 216281 RVA: 0x00C7DB7A File Offset: 0x00C7BD7A
		public UUIText TextComponent { get; set; }

		// Token: 0x1700806D RID: 32877
		// (get) Token: 0x06034CDA RID: 216282 RVA: 0x00C7DB83 File Offset: 0x00C7BD83
		// (set) Token: 0x06034CDB RID: 216283 RVA: 0x00C7DB8B File Offset: 0x00C7BD8B
		public UUIScrollViewComponent TextScrollView { get; set; }
	}
}
