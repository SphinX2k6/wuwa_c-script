using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004362 RID: 17250
	[NullableContext(2)]
	public interface IEnterMovieModeParams
	{
		// Token: 0x1700572F RID: 22319
		// (get) Token: 0x0602B8FF RID: 178431
		// (set) Token: 0x0602B900 RID: 178432
		float BlendTime { get; set; }

		// Token: 0x17005730 RID: 22320
		// (get) Token: 0x0602B901 RID: 178433
		// (set) Token: 0x0602B902 RID: 178434
		IMovieCameraConfig MovieCameraConfig { get; set; }

		// Token: 0x17005731 RID: 22321
		// (get) Token: 0x0602B903 RID: 178435
		// (set) Token: 0x0602B904 RID: 178436
		float? DelayDuration { get; set; }

		// Token: 0x17005732 RID: 22322
		// (get) Token: 0x0602B905 RID: 178437
		// (set) Token: 0x0602B906 RID: 178438
		bool? IsEnableEsc { get; set; }

		// Token: 0x17005733 RID: 22323
		// (get) Token: 0x0602B907 RID: 178439
		// (set) Token: 0x0602B908 RID: 178440
		bool? IsEnablePhoto { get; set; }

		// Token: 0x17005734 RID: 22324
		// (get) Token: 0x0602B909 RID: 178441
		// (set) Token: 0x0602B90A RID: 178442
		bool? IsAutoExitInFlowSequence { get; set; }

		// Token: 0x17005735 RID: 22325
		// (get) Token: 0x0602B90B RID: 178443
		// (set) Token: 0x0602B90C RID: 178444
		bool? IsBanAdaptation { get; set; }

		// Token: 0x17005736 RID: 22326
		// (get) Token: 0x0602B90D RID: 178445
		// (set) Token: 0x0602B90E RID: 178446
		UiPanelBase Parent { get; set; }

		// Token: 0x17005737 RID: 22327
		// (get) Token: 0x0602B90F RID: 178447
		// (set) Token: 0x0602B910 RID: 178448
		ELayerType? UiLayer { get; set; }

		// Token: 0x17005738 RID: 22328
		// (get) Token: 0x0602B911 RID: 178449
		// (set) Token: 0x0602B912 RID: 178450
		ELayerType[] AdaptUiLayers { get; set; }

		// Token: 0x17005739 RID: 22329
		// (get) Token: 0x0602B913 RID: 178451
		// (set) Token: 0x0602B914 RID: 178452
		bool? IsIgnoreUiLayerVisible { get; set; }

		// Token: 0x1700573A RID: 22330
		// (get) Token: 0x0602B915 RID: 178453
		// (set) Token: 0x0602B916 RID: 178454
		bool? IsNeedMovieModeUi { get; set; }
	}
}
