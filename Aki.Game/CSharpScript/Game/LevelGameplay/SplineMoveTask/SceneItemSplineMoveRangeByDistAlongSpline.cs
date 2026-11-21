using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B88 RID: 23432
	public class SceneItemSplineMoveRangeByDistAlongSpline : ISceneItemSplineMoveRangeByDistAlongSpline, ISceneItemSplineMoveRange
	{
		// Token: 0x17006DC6 RID: 28102
		// (get) Token: 0x060399F0 RID: 236016 RVA: 0x0102F91D File Offset: 0x0102DB1D
		// (set) Token: 0x060399F1 RID: 236017 RVA: 0x0102F925 File Offset: 0x0102DB25
		public ESceneItemSplineMoveRangeType Type { get; set; }

		// Token: 0x17006DC7 RID: 28103
		// (get) Token: 0x060399F2 RID: 236018 RVA: 0x0102F92E File Offset: 0x0102DB2E
		// (set) Token: 0x060399F3 RID: 236019 RVA: 0x0102F936 File Offset: 0x0102DB36
		public float StartDis { get; set; }

		// Token: 0x17006DC8 RID: 28104
		// (get) Token: 0x060399F4 RID: 236020 RVA: 0x0102F93F File Offset: 0x0102DB3F
		// (set) Token: 0x060399F5 RID: 236021 RVA: 0x0102F947 File Offset: 0x0102DB47
		public float EndDis { get; set; }
	}
}
