using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x0200404D RID: 16461
	[NullableContext(2)]
	[Nullable(0)]
	public class PlotTextAudioComponentContext
	{
		// Token: 0x17005421 RID: 21537
		// (get) Token: 0x06029BB3 RID: 170931 RVA: 0x00BCAE6F File Offset: 0x00BC906F
		// (set) Token: 0x06029BB4 RID: 170932 RVA: 0x00BCAE77 File Offset: 0x00BC9077
		public Action OnAudioStartDelegate { get; set; }

		// Token: 0x17005422 RID: 21538
		// (get) Token: 0x06029BB5 RID: 170933 RVA: 0x00BCAE80 File Offset: 0x00BC9080
		// (set) Token: 0x06029BB6 RID: 170934 RVA: 0x00BCAE88 File Offset: 0x00BC9088
		public Action OnAudioEndDelegate { get; set; }

		// Token: 0x17005423 RID: 21539
		// (get) Token: 0x06029BB7 RID: 170935 RVA: 0x00BCAE91 File Offset: 0x00BC9091
		// (set) Token: 0x06029BB8 RID: 170936 RVA: 0x00BCAE99 File Offset: 0x00BC9099
		public Action OnAudioLoadTimeoutDelegate { get; set; }
	}
}
