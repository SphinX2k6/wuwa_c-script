using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A21 RID: 27169
	public interface ISceneItemSplineMoveRangeByDistAlongSpline : ISceneItemSplineMoveRange
	{
		// Token: 0x170098B8 RID: 39096
		// (get) Token: 0x06043937 RID: 276791
		// (set) Token: 0x06043938 RID: 276792
		float StartDis { get; set; }

		// Token: 0x170098B9 RID: 39097
		// (get) Token: 0x06043939 RID: 276793
		// (set) Token: 0x0604393A RID: 276794
		float EndDis { get; set; }
	}
}
