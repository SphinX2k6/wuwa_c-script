using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B7F RID: 23423
	[NullableContext(2)]
	public interface ISceneItemSplineMoveConfig
	{
		// Token: 0x17006D9F RID: 28063
		// (get) Token: 0x06039989 RID: 235913
		// (set) Token: 0x0603998A RID: 235914
		ISceneItemSplineMoveSegmentConfig GlobalConfig { get; set; }

		// Token: 0x17006DA0 RID: 28064
		// (get) Token: 0x0603998B RID: 235915
		// (set) Token: 0x0603998C RID: 235916
		[Nullable(new byte[]
		{
			2,
			1
		})]
		List<ISceneItemSplineMoveSegmentConfig> PointConfigs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17006DA1 RID: 28065
		// (get) Token: 0x0603998D RID: 235917
		// (set) Token: 0x0603998E RID: 235918
		ISceneItemSplineMoveRange SplineMoveRange { get; set; }

		// Token: 0x17006DA2 RID: 28066
		// (get) Token: 0x0603998F RID: 235919
		// (set) Token: 0x06039990 RID: 235920
		int MoveCount { get; set; }

		// Token: 0x17006DA3 RID: 28067
		// (get) Token: 0x06039991 RID: 235921
		// (set) Token: 0x06039992 RID: 235922
		bool IsClosedLoop { get; set; }

		// Token: 0x17006DA4 RID: 28068
		// (get) Token: 0x06039993 RID: 235923
		// (set) Token: 0x06039994 RID: 235924
		bool IsLookDir { get; set; }
	}
}
