using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200537F RID: 21375
	[NullableContext(2)]
	public interface IEnterMovieModeParams
	{
		// Token: 0x17008363 RID: 33635
		// (get) Token: 0x060369B9 RID: 223673
		// (set) Token: 0x060369BA RID: 223674
		float BlendTime { get; set; }

		// Token: 0x17008364 RID: 33636
		// (get) Token: 0x060369BB RID: 223675
		// (set) Token: 0x060369BC RID: 223676
		IMovieCameraConfig MovieCameraConfig { get; set; }

		// Token: 0x17008365 RID: 33637
		// (get) Token: 0x060369BD RID: 223677
		// (set) Token: 0x060369BE RID: 223678
		float? DelayDuration { get; set; }

		// Token: 0x17008366 RID: 33638
		// (get) Token: 0x060369BF RID: 223679
		// (set) Token: 0x060369C0 RID: 223680
		bool? IsEnableEsc { get; set; }

		// Token: 0x17008367 RID: 33639
		// (get) Token: 0x060369C1 RID: 223681
		// (set) Token: 0x060369C2 RID: 223682
		bool? IsEnablePhoto { get; set; }

		// Token: 0x17008368 RID: 33640
		// (get) Token: 0x060369C3 RID: 223683
		// (set) Token: 0x060369C4 RID: 223684
		bool? IsAutoExitInFlowSequence { get; set; }

		// Token: 0x17008369 RID: 33641
		// (get) Token: 0x060369C5 RID: 223685
		// (set) Token: 0x060369C6 RID: 223686
		bool? IsBanAdaptation { get; set; }

		// Token: 0x1700836A RID: 33642
		// (get) Token: 0x060369C7 RID: 223687
		// (set) Token: 0x060369C8 RID: 223688
		UiPanelBase Parent { get; set; }

		// Token: 0x1700836B RID: 33643
		// (get) Token: 0x060369C9 RID: 223689
		// (set) Token: 0x060369CA RID: 223690
		ELayerType? UiLayer { get; set; }

		// Token: 0x1700836C RID: 33644
		// (get) Token: 0x060369CB RID: 223691
		// (set) Token: 0x060369CC RID: 223692
		ELayerType[] AdaptUiLayers { get; set; }

		// Token: 0x1700836D RID: 33645
		// (get) Token: 0x060369CD RID: 223693
		// (set) Token: 0x060369CE RID: 223694
		bool? IsIgnoreUiLayerVisible { get; set; }

		// Token: 0x1700836E RID: 33646
		// (get) Token: 0x060369CF RID: 223695
		// (set) Token: 0x060369D0 RID: 223696
		bool? IsNeedMovieModeUi { get; set; }
	}
}
