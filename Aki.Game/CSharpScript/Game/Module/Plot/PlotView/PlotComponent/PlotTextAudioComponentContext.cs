using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200507D RID: 20605
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextAudioComponentContext
	{
		// Token: 0x17008061 RID: 32865
		// (get) Token: 0x06034CBE RID: 216254 RVA: 0x00C7DA97 File Offset: 0x00C7BC97
		// (set) Token: 0x06034CBF RID: 216255 RVA: 0x00C7DA9F File Offset: 0x00C7BC9F
		public Action OnAudioStartDelegate { get; set; }

		// Token: 0x17008062 RID: 32866
		// (get) Token: 0x06034CC0 RID: 216256 RVA: 0x00C7DAA8 File Offset: 0x00C7BCA8
		// (set) Token: 0x06034CC1 RID: 216257 RVA: 0x00C7DAB0 File Offset: 0x00C7BCB0
		public Action OnAudioEndDelegate { get; set; }

		// Token: 0x17008063 RID: 32867
		// (get) Token: 0x06034CC2 RID: 216258 RVA: 0x00C7DAB9 File Offset: 0x00C7BCB9
		// (set) Token: 0x06034CC3 RID: 216259 RVA: 0x00C7DAC1 File Offset: 0x00C7BCC1
		public Action OnAudioLoadTimeoutDelegate { get; set; }
	}
}
