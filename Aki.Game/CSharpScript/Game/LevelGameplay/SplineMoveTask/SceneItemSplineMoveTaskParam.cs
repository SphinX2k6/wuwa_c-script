using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A25 RID: 27173
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemSplineMoveTaskParam : ISceneItemSplineMoveTaskParam
	{
		// Token: 0x170098CC RID: 39116
		// (get) Token: 0x0604395F RID: 276831 RVA: 0x01089F08 File Offset: 0x01088108
		// (set) Token: 0x06043960 RID: 276832 RVA: 0x01089F10 File Offset: 0x01088110
		public int SplineId { get; set; }

		// Token: 0x170098CD RID: 39117
		// (get) Token: 0x06043961 RID: 276833 RVA: 0x01089F19 File Offset: 0x01088119
		// (set) Token: 0x06043962 RID: 276834 RVA: 0x01089F21 File Offset: 0x01088121
		public ISceneItemSplineMoveConfig SplineMoveConfig { get; set; }

		// Token: 0x170098CE RID: 39118
		// (get) Token: 0x06043963 RID: 276835 RVA: 0x01089F2A File Offset: 0x0108812A
		// (set) Token: 0x06043964 RID: 276836 RVA: 0x01089F32 File Offset: 0x01088132
		public bool EnableSplineMoveSync { get; set; }

		// Token: 0x170098CF RID: 39119
		// (get) Token: 0x06043965 RID: 276837 RVA: 0x01089F3B File Offset: 0x0108813B
		// (set) Token: 0x06043966 RID: 276838 RVA: 0x01089F43 File Offset: 0x01088143
		public bool EnableMovementSync { get; set; }

		// Token: 0x170098D0 RID: 39120
		// (get) Token: 0x06043967 RID: 276839 RVA: 0x01089F4C File Offset: 0x0108814C
		// (set) Token: 0x06043968 RID: 276840 RVA: 0x01089F54 File Offset: 0x01088154
		public bool NeedMoveToStartPoint { get; set; }

		// Token: 0x170098D1 RID: 39121
		// (get) Token: 0x06043969 RID: 276841 RVA: 0x01089F5D File Offset: 0x0108815D
		// (set) Token: 0x0604396A RID: 276842 RVA: 0x01089F65 File Offset: 0x01088165
		public ISceneItemSplineMoveRuntimeData SplineMoveRuntimeData { get; set; }

		// Token: 0x170098D2 RID: 39122
		// (get) Token: 0x0604396B RID: 276843 RVA: 0x01089F6E File Offset: 0x0108816E
		// (set) Token: 0x0604396C RID: 276844 RVA: 0x01089F76 File Offset: 0x01088176
		[Nullable(2)]
		public Action<bool> Callback { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170098D3 RID: 39123
		// (get) Token: 0x0604396D RID: 276845 RVA: 0x01089F7F File Offset: 0x0108817F
		// (set) Token: 0x0604396E RID: 276846 RVA: 0x01089F87 File Offset: 0x01088187
		[Nullable(2)]
		public GeneralContext Context { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x170098D4 RID: 39124
		// (get) Token: 0x0604396F RID: 276847 RVA: 0x01089F90 File Offset: 0x01088190
		// (set) Token: 0x06043970 RID: 276848 RVA: 0x01089F98 File Offset: 0x01088198
		public bool? UseSplineMoveSyncSwitchOnStart { get; set; }
	}
}
