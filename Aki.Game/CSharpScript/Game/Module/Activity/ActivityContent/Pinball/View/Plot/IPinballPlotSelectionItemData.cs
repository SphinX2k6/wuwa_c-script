using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x02006322 RID: 25378
	[NullableContext(1)]
	public interface IPinballPlotSelectionItemData
	{
		// Token: 0x170092EC RID: 37612
		// (get) Token: 0x0603FD6E RID: 261486
		// (set) Token: 0x0603FD6F RID: 261487
		int OptionIndex { get; set; }

		// Token: 0x170092ED RID: 37613
		// (get) Token: 0x0603FD70 RID: 261488
		// (set) Token: 0x0603FD71 RID: 261489
		Action<int> OptionDelegate { get; set; }
	}
}
