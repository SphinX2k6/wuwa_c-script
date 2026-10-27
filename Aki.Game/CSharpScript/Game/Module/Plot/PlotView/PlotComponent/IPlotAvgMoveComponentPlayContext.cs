using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.PlotView.PlotComponent
{
	// Token: 0x02005085 RID: 20613
	[NullableContext(2)]
	public interface IPlotAvgMoveComponentPlayContext
	{
		// Token: 0x17008074 RID: 32884
		// (get) Token: 0x06034CEC RID: 216300
		// (set) Token: 0x06034CED RID: 216301
		IPlotAvgCharacterMove AvgCharacter { get; set; }

		// Token: 0x17008075 RID: 32885
		// (get) Token: 0x06034CEE RID: 216302
		// (set) Token: 0x06034CEF RID: 216303
		float StartPosition { get; set; }

		// Token: 0x17008076 RID: 32886
		// (get) Token: 0x06034CF0 RID: 216304
		// (set) Token: 0x06034CF1 RID: 216305
		float EndPosition { get; set; }

		// Token: 0x17008077 RID: 32887
		// (get) Token: 0x06034CF2 RID: 216306
		// (set) Token: 0x06034CF3 RID: 216307
		LTweenEase Ease { get; set; }

		// Token: 0x17008078 RID: 32888
		// (get) Token: 0x06034CF4 RID: 216308
		// (set) Token: 0x06034CF5 RID: 216309
		float Duration { get; set; }
	}
}
