using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A2A RID: 27178
	public class SceneItemSplineMoveRangeByPointIndex : ISceneItemSplineMoveRangeByPointIndex, ISceneItemSplineMoveRange
	{
		// Token: 0x170098DE RID: 39134
		// (get) Token: 0x0604399B RID: 276891 RVA: 0x0108B0B2 File Offset: 0x010892B2
		// (set) Token: 0x0604399C RID: 276892 RVA: 0x0108B0BA File Offset: 0x010892BA
		public ESceneItemSplineMoveRangeType Type { get; set; }

		// Token: 0x170098DF RID: 39135
		// (get) Token: 0x0604399D RID: 276893 RVA: 0x0108B0C3 File Offset: 0x010892C3
		// (set) Token: 0x0604399E RID: 276894 RVA: 0x0108B0CB File Offset: 0x010892CB
		public int StartIndex { get; set; }

		// Token: 0x170098E0 RID: 39136
		// (get) Token: 0x0604399F RID: 276895 RVA: 0x0108B0D4 File Offset: 0x010892D4
		// (set) Token: 0x060439A0 RID: 276896 RVA: 0x0108B0DC File Offset: 0x010892DC
		public int EndIndex { get; set; }
	}
}
