using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004363 RID: 17251
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class EnterMovieModeParams : IEnterMovieModeParams
	{
		// Token: 0x1700573B RID: 22331
		// (get) Token: 0x0602B917 RID: 178455 RVA: 0x00C3D601 File Offset: 0x00C3B801
		// (set) Token: 0x0602B918 RID: 178456 RVA: 0x00C3D609 File Offset: 0x00C3B809
		[RequiredMember]
		public float BlendTime { get; set; }

		// Token: 0x1700573C RID: 22332
		// (get) Token: 0x0602B919 RID: 178457 RVA: 0x00C3D612 File Offset: 0x00C3B812
		// (set) Token: 0x0602B91A RID: 178458 RVA: 0x00C3D61A File Offset: 0x00C3B81A
		public IMovieCameraConfig MovieCameraConfig { get; set; }

		// Token: 0x1700573D RID: 22333
		// (get) Token: 0x0602B91B RID: 178459 RVA: 0x00C3D623 File Offset: 0x00C3B823
		// (set) Token: 0x0602B91C RID: 178460 RVA: 0x00C3D62B File Offset: 0x00C3B82B
		public float? DelayDuration { get; set; }

		// Token: 0x1700573E RID: 22334
		// (get) Token: 0x0602B91D RID: 178461 RVA: 0x00C3D634 File Offset: 0x00C3B834
		// (set) Token: 0x0602B91E RID: 178462 RVA: 0x00C3D63C File Offset: 0x00C3B83C
		public bool? IsEnableEsc { get; set; }

		// Token: 0x1700573F RID: 22335
		// (get) Token: 0x0602B91F RID: 178463 RVA: 0x00C3D645 File Offset: 0x00C3B845
		// (set) Token: 0x0602B920 RID: 178464 RVA: 0x00C3D64D File Offset: 0x00C3B84D
		public bool? IsEnablePhoto { get; set; }

		// Token: 0x17005740 RID: 22336
		// (get) Token: 0x0602B921 RID: 178465 RVA: 0x00C3D656 File Offset: 0x00C3B856
		// (set) Token: 0x0602B922 RID: 178466 RVA: 0x00C3D65E File Offset: 0x00C3B85E
		public bool? IsAutoExitInFlowSequence { get; set; }

		// Token: 0x17005741 RID: 22337
		// (get) Token: 0x0602B923 RID: 178467 RVA: 0x00C3D667 File Offset: 0x00C3B867
		// (set) Token: 0x0602B924 RID: 178468 RVA: 0x00C3D66F File Offset: 0x00C3B86F
		public bool? IsBanAdaptation { get; set; }

		// Token: 0x17005742 RID: 22338
		// (get) Token: 0x0602B925 RID: 178469 RVA: 0x00C3D678 File Offset: 0x00C3B878
		// (set) Token: 0x0602B926 RID: 178470 RVA: 0x00C3D680 File Offset: 0x00C3B880
		public UiPanelBase Parent { get; set; }

		// Token: 0x17005743 RID: 22339
		// (get) Token: 0x0602B927 RID: 178471 RVA: 0x00C3D689 File Offset: 0x00C3B889
		// (set) Token: 0x0602B928 RID: 178472 RVA: 0x00C3D691 File Offset: 0x00C3B891
		public ELayerType? UiLayer { get; set; }

		// Token: 0x17005744 RID: 22340
		// (get) Token: 0x0602B929 RID: 178473 RVA: 0x00C3D69A File Offset: 0x00C3B89A
		// (set) Token: 0x0602B92A RID: 178474 RVA: 0x00C3D6A2 File Offset: 0x00C3B8A2
		public ELayerType[] AdaptUiLayers { get; set; }

		// Token: 0x17005745 RID: 22341
		// (get) Token: 0x0602B92B RID: 178475 RVA: 0x00C3D6AB File Offset: 0x00C3B8AB
		// (set) Token: 0x0602B92C RID: 178476 RVA: 0x00C3D6B3 File Offset: 0x00C3B8B3
		public bool? IsIgnoreUiLayerVisible { get; set; }

		// Token: 0x17005746 RID: 22342
		// (get) Token: 0x0602B92D RID: 178477 RVA: 0x00C3D6BC File Offset: 0x00C3B8BC
		// (set) Token: 0x0602B92E RID: 178478 RVA: 0x00C3D6C4 File Offset: 0x00C3B8C4
		public bool? IsNeedMovieModeUi { get; set; }

		// Token: 0x0602B92F RID: 178479 RVA: 0x00C3D6CD File Offset: 0x00C3B8CD
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public EnterMovieModeParams()
		{
		}
	}
}
