using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004053 RID: 16467
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotWaitingProxyComponentContext
	{
		// Token: 0x17005431 RID: 21553
		// (get) Token: 0x06029BD9 RID: 170969 RVA: 0x00BCAFAF File Offset: 0x00BC91AF
		// (set) Token: 0x06029BDA RID: 170970 RVA: 0x00BCAFB7 File Offset: 0x00BC91B7
		public Action OnWaitingStartDelegate { get; set; }

		// Token: 0x17005432 RID: 21554
		// (get) Token: 0x06029BDB RID: 170971 RVA: 0x00BCAFC0 File Offset: 0x00BC91C0
		// (set) Token: 0x06029BDC RID: 170972 RVA: 0x00BCAFC8 File Offset: 0x00BC91C8
		public Action OnWaitingCompleteDelegate { get; set; }

		// Token: 0x17005433 RID: 21555
		// (get) Token: 0x06029BDD RID: 170973 RVA: 0x00BCAFD1 File Offset: 0x00BC91D1
		// (set) Token: 0x06029BDE RID: 170974 RVA: 0x00BCAFD9 File Offset: 0x00BC91D9
		public Action OnWaitingCancelDelegate { get; set; }
	}
}
