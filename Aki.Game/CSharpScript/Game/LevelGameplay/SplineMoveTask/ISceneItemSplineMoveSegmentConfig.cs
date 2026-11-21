using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B77 RID: 23415
	public interface ISceneItemSplineMoveSegmentConfig
	{
		// Token: 0x17006D93 RID: 28051
		// (get) Token: 0x06039972 RID: 235890
		[Obsolete]
		ESceneItemSplineMoveSegmentConfigType Type { get; }

		// Token: 0x17006D94 RID: 28052
		// (get) Token: 0x06039973 RID: 235891
		// (set) Token: 0x06039974 RID: 235892
		float? WaitTime { get; set; }
	}
}
