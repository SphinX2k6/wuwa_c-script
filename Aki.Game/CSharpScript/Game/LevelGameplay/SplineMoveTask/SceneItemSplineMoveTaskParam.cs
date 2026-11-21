using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B82 RID: 23426
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemSplineMoveTaskParam : ISceneItemSplineMoveTaskParam
	{
		// Token: 0x17006DB1 RID: 28081
		// (get) Token: 0x060399AD RID: 235949 RVA: 0x0102E739 File Offset: 0x0102C939
		// (set) Token: 0x060399AE RID: 235950 RVA: 0x0102E741 File Offset: 0x0102C941
		public int SplineId { get; set; }

		// Token: 0x17006DB2 RID: 28082
		// (get) Token: 0x060399AF RID: 235951 RVA: 0x0102E74A File Offset: 0x0102C94A
		// (set) Token: 0x060399B0 RID: 235952 RVA: 0x0102E752 File Offset: 0x0102C952
		public ISceneItemSplineMoveConfig SplineMoveConfig { get; set; }

		// Token: 0x17006DB3 RID: 28083
		// (get) Token: 0x060399B1 RID: 235953 RVA: 0x0102E75B File Offset: 0x0102C95B
		// (set) Token: 0x060399B2 RID: 235954 RVA: 0x0102E763 File Offset: 0x0102C963
		public bool EnableSplineMoveSync { get; set; }

		// Token: 0x17006DB4 RID: 28084
		// (get) Token: 0x060399B3 RID: 235955 RVA: 0x0102E76C File Offset: 0x0102C96C
		// (set) Token: 0x060399B4 RID: 235956 RVA: 0x0102E774 File Offset: 0x0102C974
		public bool EnableMovementSync { get; set; }

		// Token: 0x17006DB5 RID: 28085
		// (get) Token: 0x060399B5 RID: 235957 RVA: 0x0102E77D File Offset: 0x0102C97D
		// (set) Token: 0x060399B6 RID: 235958 RVA: 0x0102E785 File Offset: 0x0102C985
		public bool NeedMoveToStartPoint { get; set; }

		// Token: 0x17006DB6 RID: 28086
		// (get) Token: 0x060399B7 RID: 235959 RVA: 0x0102E78E File Offset: 0x0102C98E
		// (set) Token: 0x060399B8 RID: 235960 RVA: 0x0102E796 File Offset: 0x0102C996
		public ISceneItemSplineMoveRuntimeData SplineMoveRuntimeData { get; set; }

		// Token: 0x17006DB7 RID: 28087
		// (get) Token: 0x060399B9 RID: 235961 RVA: 0x0102E79F File Offset: 0x0102C99F
		// (set) Token: 0x060399BA RID: 235962 RVA: 0x0102E7A7 File Offset: 0x0102C9A7
		[Nullable(2)]
		public Action<bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006DB8 RID: 28088
		// (get) Token: 0x060399BB RID: 235963 RVA: 0x0102E7B0 File Offset: 0x0102C9B0
		// (set) Token: 0x060399BC RID: 235964 RVA: 0x0102E7B8 File Offset: 0x0102C9B8
		[Nullable(2)]
		public GeneralContext Context { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006DB9 RID: 28089
		// (get) Token: 0x060399BD RID: 235965 RVA: 0x0102E7C1 File Offset: 0x0102C9C1
		// (set) Token: 0x060399BE RID: 235966 RVA: 0x0102E7C9 File Offset: 0x0102C9C9
		public bool? UseSplineMoveSyncSwitchOnStart { get; set; }
	}
}
