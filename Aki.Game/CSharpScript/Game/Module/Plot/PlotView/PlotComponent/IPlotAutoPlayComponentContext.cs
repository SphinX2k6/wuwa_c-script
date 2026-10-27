using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005087 RID: 20615
	[NullableContext(1)]
	public interface IPlotAutoPlayComponentContext
	{
		// Token: 0x1700807E RID: 32894
		// (get) Token: 0x06034D01 RID: 216321
		// (set) Token: 0x06034D02 RID: 216322
		UUIExtendToggle Toggle { get; set; }

		// Token: 0x1700807F RID: 32895
		// (get) Token: 0x06034D03 RID: 216323
		// (set) Token: 0x06034D04 RID: 216324
		float WaitTime { get; set; }

		// Token: 0x17008080 RID: 32896
		// (get) Token: 0x06034D05 RID: 216325
		// (set) Token: 0x06034D06 RID: 216326
		Func<bool> CheckTalkFinishedDelegate { get; set; }

		// Token: 0x17008081 RID: 32897
		// (get) Token: 0x06034D07 RID: 216327
		// (set) Token: 0x06034D08 RID: 216328
		Action ContinueToNextTalkDelegate { get; set; }
	}
}
