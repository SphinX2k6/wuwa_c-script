using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A29 RID: 27177
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemSplineMoveRuntimeData : ISceneItemSplineMoveRuntimeData
	{
		// Token: 0x170098DB RID: 39131
		// (get) Token: 0x06043994 RID: 276884 RVA: 0x0108B077 File Offset: 0x01089277
		// (set) Token: 0x06043995 RID: 276885 RVA: 0x0108B07F File Offset: 0x0108927F
		public float? DistanceAloneSpline { get; set; }

		// Token: 0x170098DC RID: 39132
		// (get) Token: 0x06043996 RID: 276886 RVA: 0x0108B088 File Offset: 0x01089288
		// (set) Token: 0x06043997 RID: 276887 RVA: 0x0108B090 File Offset: 0x01089290
		public Vector CurPos { get; set; }

		// Token: 0x170098DD RID: 39133
		// (get) Token: 0x06043998 RID: 276888 RVA: 0x0108B099 File Offset: 0x01089299
		// (set) Token: 0x06043999 RID: 276889 RVA: 0x0108B0A1 File Offset: 0x010892A1
		public Rotator CurRot { get; set; }
	}
}
