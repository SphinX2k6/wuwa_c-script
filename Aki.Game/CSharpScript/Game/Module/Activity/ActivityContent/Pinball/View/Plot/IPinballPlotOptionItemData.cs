using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Plot
{
	// Token: 0x0200631F RID: 25375
	[NullableContext(1)]
	public interface IPinballPlotOptionItemData
	{
		// Token: 0x170092E6 RID: 37606
		// (get) Token: 0x0603FD5D RID: 261469
		// (set) Token: 0x0603FD5E RID: 261470
		int OptionIndex { get; set; }

		// Token: 0x170092E7 RID: 37607
		// (get) Token: 0x0603FD5F RID: 261471
		// (set) Token: 0x0603FD60 RID: 261472
		TableTextArgNew OptionText { get; set; }

		// Token: 0x170092E8 RID: 37608
		// (get) Token: 0x0603FD61 RID: 261473
		// (set) Token: 0x0603FD62 RID: 261474
		Action<int> OptionDelegate { get; set; }
	}
}
