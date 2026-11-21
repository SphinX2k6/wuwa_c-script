using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004051 RID: 16465
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextScrollComponentContext
	{
		// Token: 0x1700542C RID: 21548
		// (get) Token: 0x06029BCD RID: 170957 RVA: 0x00BCAF4A File Offset: 0x00BC914A
		// (set) Token: 0x06029BCE RID: 170958 RVA: 0x00BCAF52 File Offset: 0x00BC9152
		public UUIText TextComponent { get; set; }

		// Token: 0x1700542D RID: 21549
		// (get) Token: 0x06029BCF RID: 170959 RVA: 0x00BCAF5B File Offset: 0x00BC915B
		// (set) Token: 0x06029BD0 RID: 170960 RVA: 0x00BCAF63 File Offset: 0x00BC9163
		public UUIScrollViewComponent TextScrollView { get; set; }
	}
}
