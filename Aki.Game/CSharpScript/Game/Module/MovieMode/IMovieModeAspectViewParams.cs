using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02005389 RID: 21385
	[NullableContext(2)]
	public interface IMovieModeAspectViewParams
	{
		// Token: 0x17008391 RID: 33681
		// (get) Token: 0x06036A19 RID: 223769
		// (set) Token: 0x06036A1A RID: 223770
		bool IsBanAdaptation { get; set; }

		// Token: 0x17008392 RID: 33682
		// (get) Token: 0x06036A1B RID: 223771
		// (set) Token: 0x06036A1C RID: 223772
		ELayerType[] AdaptUiLayers { get; set; }

		// Token: 0x17008393 RID: 33683
		// (get) Token: 0x06036A1D RID: 223773
		// (set) Token: 0x06036A1E RID: 223774
		bool? IsIgnoreUiLayerVisible { get; set; }
	}
}
