using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004057 RID: 16471
	[NullableContext(1)]
	public interface IPlotAutoPlayComponentContext
	{
		// Token: 0x1700543E RID: 21566
		// (get) Token: 0x06029BF6 RID: 170998
		// (set) Token: 0x06029BF7 RID: 170999
		UUIExtendToggle Toggle { get; set; }

		// Token: 0x1700543F RID: 21567
		// (get) Token: 0x06029BF8 RID: 171000
		// (set) Token: 0x06029BF9 RID: 171001
		float WaitTime { get; set; }

		// Token: 0x17005440 RID: 21568
		// (get) Token: 0x06029BFA RID: 171002
		// (set) Token: 0x06029BFB RID: 171003
		Func<bool> CheckTalkFinishedDelegate { get; set; }

		// Token: 0x17005441 RID: 21569
		// (get) Token: 0x06029BFC RID: 171004
		// (set) Token: 0x06029BFD RID: 171005
		Action ContinueToNextTalkDelegate { get; set; }
	}
}
