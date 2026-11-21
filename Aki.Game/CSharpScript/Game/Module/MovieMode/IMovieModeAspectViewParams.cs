using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200436C RID: 17260
	[NullableContext(2)]
	public interface IMovieModeAspectViewParams
	{
		// Token: 0x1700575D RID: 22365
		// (get) Token: 0x0602B95F RID: 178527
		// (set) Token: 0x0602B960 RID: 178528
		bool IsBanAdaptation { get; set; }

		// Token: 0x1700575E RID: 22366
		// (get) Token: 0x0602B961 RID: 178529
		// (set) Token: 0x0602B962 RID: 178530
		ELayerType[] AdaptUiLayers { get; set; }

		// Token: 0x1700575F RID: 22367
		// (get) Token: 0x0602B963 RID: 178531
		// (set) Token: 0x0602B964 RID: 178532
		bool? IsIgnoreUiLayerVisible { get; set; }
	}
}
