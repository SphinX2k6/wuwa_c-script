using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B81 RID: 23425
	[NullableContext(1)]
	public interface ISceneItemSplineMoveTaskParam
	{
		// Token: 0x17006DA8 RID: 28072
		// (get) Token: 0x0603999B RID: 235931
		// (set) Token: 0x0603999C RID: 235932
		int SplineId { get; set; }

		// Token: 0x17006DA9 RID: 28073
		// (get) Token: 0x0603999D RID: 235933
		// (set) Token: 0x0603999E RID: 235934
		ISceneItemSplineMoveConfig SplineMoveConfig { get; set; }

		// Token: 0x17006DAA RID: 28074
		// (get) Token: 0x0603999F RID: 235935
		// (set) Token: 0x060399A0 RID: 235936
		bool EnableSplineMoveSync { get; set; }

		// Token: 0x17006DAB RID: 28075
		// (get) Token: 0x060399A1 RID: 235937
		// (set) Token: 0x060399A2 RID: 235938
		bool EnableMovementSync { get; set; }

		// Token: 0x17006DAC RID: 28076
		// (get) Token: 0x060399A3 RID: 235939
		// (set) Token: 0x060399A4 RID: 235940
		bool NeedMoveToStartPoint { get; set; }

		// Token: 0x17006DAD RID: 28077
		// (get) Token: 0x060399A5 RID: 235941
		// (set) Token: 0x060399A6 RID: 235942
		ISceneItemSplineMoveRuntimeData SplineMoveRuntimeData { get; set; }

		// Token: 0x17006DAE RID: 28078
		// (get) Token: 0x060399A7 RID: 235943
		// (set) Token: 0x060399A8 RID: 235944
		[Nullable(2)]
		Action<bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006DAF RID: 28079
		// (get) Token: 0x060399A9 RID: 235945
		// (set) Token: 0x060399AA RID: 235946
		[Nullable(2)]
		GeneralContext Context { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006DB0 RID: 28080
		// (get) Token: 0x060399AB RID: 235947
		// (set) Token: 0x060399AC RID: 235948
		bool? UseSplineMoveSyncSwitchOnStart { get; set; }
	}
}
