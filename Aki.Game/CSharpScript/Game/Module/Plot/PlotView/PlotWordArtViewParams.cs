using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.PlotView
{
	// Token: 0x0200506E RID: 20590
	[NullableContext(1)]
	[Nullable(0)]
	public class PlotWordArtViewParams
	{
		// Token: 0x1700803F RID: 32831
		// (get) Token: 0x06034C11 RID: 216081 RVA: 0x00C7B8C7 File Offset: 0x00C79AC7
		// (set) Token: 0x06034C12 RID: 216082 RVA: 0x00C7B8CF File Offset: 0x00C79ACF
		public ITransitionPopupYuanChengArtText Config { get; set; }

		// Token: 0x17008040 RID: 32832
		// (get) Token: 0x06034C13 RID: 216083 RVA: 0x00C7B8D8 File Offset: 0x00C79AD8
		// (set) Token: 0x06034C14 RID: 216084 RVA: 0x00C7B8E0 File Offset: 0x00C79AE0
		public float? Duration { get; set; }
	}
}
