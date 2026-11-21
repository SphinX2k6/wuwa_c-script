using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B7E RID: 23422
	public interface ISceneItemSplineMoveRangeByDistAlongSpline : ISceneItemSplineMoveRange
	{
		// Token: 0x17006D9D RID: 28061
		// (get) Token: 0x06039985 RID: 235909
		// (set) Token: 0x06039986 RID: 235910
		float StartDis { get; set; }

		// Token: 0x17006D9E RID: 28062
		// (get) Token: 0x06039987 RID: 235911
		// (set) Token: 0x06039988 RID: 235912
		float EndDis { get; set; }
	}
}
