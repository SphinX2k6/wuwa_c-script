using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A24 RID: 27172
	[NullableContext(1)]
	public interface ISceneItemSplineMoveTaskParam
	{
		// Token: 0x170098C3 RID: 39107
		// (get) Token: 0x0604394D RID: 276813
		// (set) Token: 0x0604394E RID: 276814
		int SplineId { get; set; }

		// Token: 0x170098C4 RID: 39108
		// (get) Token: 0x0604394F RID: 276815
		// (set) Token: 0x06043950 RID: 276816
		ISceneItemSplineMoveConfig SplineMoveConfig { get; set; }

		// Token: 0x170098C5 RID: 39109
		// (get) Token: 0x06043951 RID: 276817
		// (set) Token: 0x06043952 RID: 276818
		bool EnableSplineMoveSync { get; set; }

		// Token: 0x170098C6 RID: 39110
		// (get) Token: 0x06043953 RID: 276819
		// (set) Token: 0x06043954 RID: 276820
		bool EnableMovementSync { get; set; }

		// Token: 0x170098C7 RID: 39111
		// (get) Token: 0x06043955 RID: 276821
		// (set) Token: 0x06043956 RID: 276822
		bool NeedMoveToStartPoint { get; set; }

		// Token: 0x170098C8 RID: 39112
		// (get) Token: 0x06043957 RID: 276823
		// (set) Token: 0x06043958 RID: 276824
		ISceneItemSplineMoveRuntimeData SplineMoveRuntimeData { get; set; }

		// Token: 0x170098C9 RID: 39113
		// (get) Token: 0x06043959 RID: 276825
		// (set) Token: 0x0604395A RID: 276826
		[Nullable(2)]
		Action<bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170098CA RID: 39114
		// (get) Token: 0x0604395B RID: 276827
		// (set) Token: 0x0604395C RID: 276828
		[Nullable(2)]
		GeneralContext Context { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170098CB RID: 39115
		// (get) Token: 0x0604395D RID: 276829
		// (set) Token: 0x0604395E RID: 276830
		bool? UseSplineMoveSyncSwitchOnStart { get; set; }
	}
}
