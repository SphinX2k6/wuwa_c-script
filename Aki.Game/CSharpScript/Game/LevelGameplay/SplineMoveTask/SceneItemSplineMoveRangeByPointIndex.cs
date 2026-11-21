using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B87 RID: 23431
	public class SceneItemSplineMoveRangeByPointIndex : ISceneItemSplineMoveRangeByPointIndex, ISceneItemSplineMoveRange
	{
		// Token: 0x17006DC3 RID: 28099
		// (get) Token: 0x060399E9 RID: 236009 RVA: 0x0102F8E2 File Offset: 0x0102DAE2
		// (set) Token: 0x060399EA RID: 236010 RVA: 0x0102F8EA File Offset: 0x0102DAEA
		public ESceneItemSplineMoveRangeType Type { get; set; }

		// Token: 0x17006DC4 RID: 28100
		// (get) Token: 0x060399EB RID: 236011 RVA: 0x0102F8F3 File Offset: 0x0102DAF3
		// (set) Token: 0x060399EC RID: 236012 RVA: 0x0102F8FB File Offset: 0x0102DAFB
		public int StartIndex { get; set; }

		// Token: 0x17006DC5 RID: 28101
		// (get) Token: 0x060399ED RID: 236013 RVA: 0x0102F904 File Offset: 0x0102DB04
		// (set) Token: 0x060399EE RID: 236014 RVA: 0x0102F90C File Offset: 0x0102DB0C
		public int EndIndex { get; set; }
	}
}
