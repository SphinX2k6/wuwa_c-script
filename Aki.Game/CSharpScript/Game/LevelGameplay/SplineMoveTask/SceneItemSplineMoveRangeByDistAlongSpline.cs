using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A2B RID: 27179
	public class SceneItemSplineMoveRangeByDistAlongSpline : ISceneItemSplineMoveRangeByDistAlongSpline, ISceneItemSplineMoveRange
	{
		// Token: 0x170098E1 RID: 39137
		// (get) Token: 0x060439A2 RID: 276898 RVA: 0x0108B0ED File Offset: 0x010892ED
		// (set) Token: 0x060439A3 RID: 276899 RVA: 0x0108B0F5 File Offset: 0x010892F5
		public ESceneItemSplineMoveRangeType Type { get; set; }

		// Token: 0x170098E2 RID: 39138
		// (get) Token: 0x060439A4 RID: 276900 RVA: 0x0108B0FE File Offset: 0x010892FE
		// (set) Token: 0x060439A5 RID: 276901 RVA: 0x0108B106 File Offset: 0x01089306
		public float StartDis { get; set; }

		// Token: 0x170098E3 RID: 39139
		// (get) Token: 0x060439A6 RID: 276902 RVA: 0x0108B10F File Offset: 0x0108930F
		// (set) Token: 0x060439A7 RID: 276903 RVA: 0x0108B117 File Offset: 0x01089317
		public float EndDis { get; set; }
	}
}
