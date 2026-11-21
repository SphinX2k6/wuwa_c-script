using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x02004041 RID: 16449
	[NullableContext(2)]
	[Nullable(0)]
	public class TransitionPopupViewParams
	{
		// Token: 0x17005401 RID: 21505
		// (get) Token: 0x06029B16 RID: 170774 RVA: 0x00BC91D3 File Offset: 0x00BC73D3
		// (set) Token: 0x06029B17 RID: 170775 RVA: 0x00BC91DB File Offset: 0x00BC73DB
		public int? BoardId { get; set; }

		// Token: 0x17005402 RID: 21506
		// (get) Token: 0x06029B18 RID: 170776 RVA: 0x00BC91E4 File Offset: 0x00BC73E4
		// (set) Token: 0x06029B19 RID: 170777 RVA: 0x00BC91EC File Offset: 0x00BC73EC
		public bool InPlot { get; set; }

		// Token: 0x17005403 RID: 21507
		// (get) Token: 0x06029B1A RID: 170778 RVA: 0x00BC91F5 File Offset: 0x00BC73F5
		// (set) Token: 0x06029B1B RID: 170779 RVA: 0x00BC91FD File Offset: 0x00BC73FD
		public float? Duration { get; set; }

		// Token: 0x17005404 RID: 21508
		// (get) Token: 0x06029B1C RID: 170780 RVA: 0x00BC9206 File Offset: 0x00BC7406
		// (set) Token: 0x06029B1D RID: 170781 RVA: 0x00BC920E File Offset: 0x00BC740E
		public ITransitionPopupStyle Style { get; set; }
	}
}
