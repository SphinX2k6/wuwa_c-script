using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B7D RID: 23421
	public interface ISceneItemSplineMoveRangeByPointIndex : ISceneItemSplineMoveRange
	{
		// Token: 0x17006D9B RID: 28059
		// (get) Token: 0x06039981 RID: 235905
		// (set) Token: 0x06039982 RID: 235906
		int StartIndex { get; set; }

		// Token: 0x17006D9C RID: 28060
		// (get) Token: 0x06039983 RID: 235907
		// (set) Token: 0x06039984 RID: 235908
		int EndIndex { get; set; }
	}
}
