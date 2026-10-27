using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A1A RID: 27162
	public interface ISceneItemSplineMoveSegmentConfig
	{
		// Token: 0x170098AE RID: 39086
		// (get) Token: 0x06043924 RID: 276772
		[Obsolete]
		ESceneItemSplineMoveSegmentConfigType Type { get; }

		// Token: 0x170098AF RID: 39087
		// (get) Token: 0x06043925 RID: 276773
		// (set) Token: 0x06043926 RID: 276774
		float? WaitTime { get; set; }
	}
}
