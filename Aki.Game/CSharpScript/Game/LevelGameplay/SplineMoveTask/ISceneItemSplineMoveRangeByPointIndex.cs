using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A20 RID: 27168
	public interface ISceneItemSplineMoveRangeByPointIndex : ISceneItemSplineMoveRange
	{
		// Token: 0x170098B6 RID: 39094
		// (get) Token: 0x06043933 RID: 276787
		// (set) Token: 0x06043934 RID: 276788
		int StartIndex { get; set; }

		// Token: 0x170098B7 RID: 39095
		// (get) Token: 0x06043935 RID: 276789
		// (set) Token: 0x06043936 RID: 276790
		int EndIndex { get; set; }
	}
}
