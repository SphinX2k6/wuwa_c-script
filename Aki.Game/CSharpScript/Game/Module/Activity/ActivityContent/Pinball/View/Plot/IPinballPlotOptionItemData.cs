using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x0200529D RID: 21149
	[NullableContext(1)]
	public interface IPinballPlotOptionItemData
	{
		// Token: 0x17006648 RID: 26184
		// (get) Token: 0x06034A1E RID: 215582
		// (set) Token: 0x06034A1F RID: 215583
		int OptionIndex { get; set; }

		// Token: 0x17006649 RID: 26185
		// (get) Token: 0x06034A20 RID: 215584
		// (set) Token: 0x06034A21 RID: 215585
		TableTextArgNew OptionText { get; set; }

		// Token: 0x1700664A RID: 26186
		// (get) Token: 0x06034A22 RID: 215586
		// (set) Token: 0x06034A23 RID: 215587
		Action<int> OptionDelegate { get; set; }
	}
}
