using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004050 RID: 16464
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextWriterComponentContext
	{
		// Token: 0x17005427 RID: 21543
		// (get) Token: 0x06029BC2 RID: 170946 RVA: 0x00BCAEED File Offset: 0x00BC90ED
		// (set) Token: 0x06029BC3 RID: 170947 RVA: 0x00BCAEF5 File Offset: 0x00BC90F5
		public UUIText TextComponent { get; set; }

		// Token: 0x17005428 RID: 21544
		// (get) Token: 0x06029BC4 RID: 170948 RVA: 0x00BCAEFE File Offset: 0x00BC90FE
		// (set) Token: 0x06029BC5 RID: 170949 RVA: 0x00BCAF06 File Offset: 0x00BC9106
		public UUIEffectTextAnimation TextAnimComp { get; set; }

		// Token: 0x17005429 RID: 21545
		// (get) Token: 0x06029BC6 RID: 170950 RVA: 0x00BCAF0F File Offset: 0x00BC910F
		// (set) Token: 0x06029BC7 RID: 170951 RVA: 0x00BCAF17 File Offset: 0x00BC9117
		public ULGUIPlayTweenComponent TweenComp { get; set; }

		// Token: 0x1700542A RID: 21546
		// (get) Token: 0x06029BC8 RID: 170952 RVA: 0x00BCAF20 File Offset: 0x00BC9120
		// (set) Token: 0x06029BC9 RID: 170953 RVA: 0x00BCAF28 File Offset: 0x00BC9128
		public Action OnAnimCompleteDelegate { get; set; }

		// Token: 0x1700542B RID: 21547
		// (get) Token: 0x06029BCA RID: 170954 RVA: 0x00BCAF31 File Offset: 0x00BC9131
		// (set) Token: 0x06029BCB RID: 170955 RVA: 0x00BCAF39 File Offset: 0x00BC9139
		public Action OnStopDelegate { get; set; }
	}
}
