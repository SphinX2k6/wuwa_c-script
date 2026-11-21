using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B86 RID: 23430
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemSplineMoveRuntimeData : ISceneItemSplineMoveRuntimeData
	{
		// Token: 0x17006DC0 RID: 28096
		// (get) Token: 0x060399E2 RID: 236002 RVA: 0x0102F8A7 File Offset: 0x0102DAA7
		// (set) Token: 0x060399E3 RID: 236003 RVA: 0x0102F8AF File Offset: 0x0102DAAF
		public float? DistanceAloneSpline { get; set; }

		// Token: 0x17006DC1 RID: 28097
		// (get) Token: 0x060399E4 RID: 236004 RVA: 0x0102F8B8 File Offset: 0x0102DAB8
		// (set) Token: 0x060399E5 RID: 236005 RVA: 0x0102F8C0 File Offset: 0x0102DAC0
		public Vector CurPos { get; set; }

		// Token: 0x17006DC2 RID: 28098
		// (get) Token: 0x060399E6 RID: 236006 RVA: 0x0102F8C9 File Offset: 0x0102DAC9
		// (set) Token: 0x060399E7 RID: 236007 RVA: 0x0102F8D1 File Offset: 0x0102DAD1
		public Rotator CurRot { get; set; }
	}
}
