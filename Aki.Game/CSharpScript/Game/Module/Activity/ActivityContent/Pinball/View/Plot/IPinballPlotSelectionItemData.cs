using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x020052A0 RID: 21152
	[NullableContext(1)]
	public interface IPinballPlotSelectionItemData
	{
		// Token: 0x1700664E RID: 26190
		// (get) Token: 0x06034A2F RID: 215599
		// (set) Token: 0x06034A30 RID: 215600
		int OptionIndex { get; set; }

		// Token: 0x1700664F RID: 26191
		// (get) Token: 0x06034A31 RID: 215601
		// (set) Token: 0x06034A32 RID: 215602
		Action<int> OptionDelegate { get; set; }
	}
}
