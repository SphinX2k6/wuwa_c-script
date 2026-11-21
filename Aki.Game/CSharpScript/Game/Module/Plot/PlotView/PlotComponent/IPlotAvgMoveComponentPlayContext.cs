using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02004055 RID: 16469
	[NullableContext(2)]
	public interface IPlotAvgMoveComponentPlayContext
	{
		// Token: 0x17005434 RID: 21556
		// (get) Token: 0x06029BE1 RID: 170977
		// (set) Token: 0x06029BE2 RID: 170978
		IPlotAvgCharacterMove AvgCharacter { get; set; }

		// Token: 0x17005435 RID: 21557
		// (get) Token: 0x06029BE3 RID: 170979
		// (set) Token: 0x06029BE4 RID: 170980
		float StartPosition { get; set; }

		// Token: 0x17005436 RID: 21558
		// (get) Token: 0x06029BE5 RID: 170981
		// (set) Token: 0x06029BE6 RID: 170982
		float EndPosition { get; set; }

		// Token: 0x17005437 RID: 21559
		// (get) Token: 0x06029BE7 RID: 170983
		// (set) Token: 0x06029BE8 RID: 170984
		LTweenEase Ease { get; set; }

		// Token: 0x17005438 RID: 21560
		// (get) Token: 0x06029BE9 RID: 170985
		// (set) Token: 0x06029BEA RID: 170986
		float Duration { get; set; }
	}
}
