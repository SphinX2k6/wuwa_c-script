using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02005380 RID: 21376
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class EnterMovieModeParams : IEnterMovieModeParams
	{
		// Token: 0x1700836F RID: 33647
		// (get) Token: 0x060369D1 RID: 223697 RVA: 0x00CEE6D9 File Offset: 0x00CEC8D9
		// (set) Token: 0x060369D2 RID: 223698 RVA: 0x00CEE6E1 File Offset: 0x00CEC8E1
		[RequiredMember]
		public float BlendTime { get; set; }

		// Token: 0x17008370 RID: 33648
		// (get) Token: 0x060369D3 RID: 223699 RVA: 0x00CEE6EA File Offset: 0x00CEC8EA
		// (set) Token: 0x060369D4 RID: 223700 RVA: 0x00CEE6F2 File Offset: 0x00CEC8F2
		public IMovieCameraConfig MovieCameraConfig { get; set; }

		// Token: 0x17008371 RID: 33649
		// (get) Token: 0x060369D5 RID: 223701 RVA: 0x00CEE6FB File Offset: 0x00CEC8FB
		// (set) Token: 0x060369D6 RID: 223702 RVA: 0x00CEE703 File Offset: 0x00CEC903
		public float? DelayDuration { get; set; }

		// Token: 0x17008372 RID: 33650
		// (get) Token: 0x060369D7 RID: 223703 RVA: 0x00CEE70C File Offset: 0x00CEC90C
		// (set) Token: 0x060369D8 RID: 223704 RVA: 0x00CEE714 File Offset: 0x00CEC914
		public bool? IsEnableEsc { get; set; }

		// Token: 0x17008373 RID: 33651
		// (get) Token: 0x060369D9 RID: 223705 RVA: 0x00CEE71D File Offset: 0x00CEC91D
		// (set) Token: 0x060369DA RID: 223706 RVA: 0x00CEE725 File Offset: 0x00CEC925
		public bool? IsEnablePhoto { get; set; }

		// Token: 0x17008374 RID: 33652
		// (get) Token: 0x060369DB RID: 223707 RVA: 0x00CEE72E File Offset: 0x00CEC92E
		// (set) Token: 0x060369DC RID: 223708 RVA: 0x00CEE736 File Offset: 0x00CEC936
		public bool? IsAutoExitInFlowSequence { get; set; }

		// Token: 0x17008375 RID: 33653
		// (get) Token: 0x060369DD RID: 223709 RVA: 0x00CEE73F File Offset: 0x00CEC93F
		// (set) Token: 0x060369DE RID: 223710 RVA: 0x00CEE747 File Offset: 0x00CEC947
		public bool? IsBanAdaptation { get; set; }

		// Token: 0x17008376 RID: 33654
		// (get) Token: 0x060369DF RID: 223711 RVA: 0x00CEE750 File Offset: 0x00CEC950
		// (set) Token: 0x060369E0 RID: 223712 RVA: 0x00CEE758 File Offset: 0x00CEC958
		public UiPanelBase Parent { get; set; }

		// Token: 0x17008377 RID: 33655
		// (get) Token: 0x060369E1 RID: 223713 RVA: 0x00CEE761 File Offset: 0x00CEC961
		// (set) Token: 0x060369E2 RID: 223714 RVA: 0x00CEE769 File Offset: 0x00CEC969
		public ELayerType? UiLayer { get; set; }

		// Token: 0x17008378 RID: 33656
		// (get) Token: 0x060369E3 RID: 223715 RVA: 0x00CEE772 File Offset: 0x00CEC972
		// (set) Token: 0x060369E4 RID: 223716 RVA: 0x00CEE77A File Offset: 0x00CEC97A
		public ELayerType[] AdaptUiLayers { get; set; }

		// Token: 0x17008379 RID: 33657
		// (get) Token: 0x060369E5 RID: 223717 RVA: 0x00CEE783 File Offset: 0x00CEC983
		// (set) Token: 0x060369E6 RID: 223718 RVA: 0x00CEE78B File Offset: 0x00CEC98B
		public bool? IsIgnoreUiLayerVisible { get; set; }

		// Token: 0x1700837A RID: 33658
		// (get) Token: 0x060369E7 RID: 223719 RVA: 0x00CEE794 File Offset: 0x00CEC994
		// (set) Token: 0x060369E8 RID: 223720 RVA: 0x00CEE79C File Offset: 0x00CEC99C
		public bool? IsNeedMovieModeUi { get; set; }

		// Token: 0x060369E9 RID: 223721 RVA: 0x00CEE7A5 File Offset: 0x00CEC9A5
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public EnterMovieModeParams()
		{
		}
	}
}
