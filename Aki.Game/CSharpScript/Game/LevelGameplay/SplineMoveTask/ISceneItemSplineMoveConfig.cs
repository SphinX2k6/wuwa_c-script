using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A22 RID: 27170
	[NullableContext(2)]
	public interface ISceneItemSplineMoveConfig
	{
		// Token: 0x170098BA RID: 39098
		// (get) Token: 0x0604393B RID: 276795
		// (set) Token: 0x0604393C RID: 276796
		ISceneItemSplineMoveSegmentConfig GlobalConfig { get; set; }

		// Token: 0x170098BB RID: 39099
		// (get) Token: 0x0604393D RID: 276797
		// (set) Token: 0x0604393E RID: 276798
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

		// Token: 0x170098BC RID: 39100
		// (get) Token: 0x0604393F RID: 276799
		// (set) Token: 0x06043940 RID: 276800
		ISceneItemSplineMoveRange SplineMoveRange { get; set; }

		// Token: 0x170098BD RID: 39101
		// (get) Token: 0x06043941 RID: 276801
		// (set) Token: 0x06043942 RID: 276802
		int MoveCount { get; set; }

		// Token: 0x170098BE RID: 39102
		// (get) Token: 0x06043943 RID: 276803
		// (set) Token: 0x06043944 RID: 276804
		bool IsClosedLoop { get; set; }

		// Token: 0x170098BF RID: 39103
		// (get) Token: 0x06043945 RID: 276805
		// (set) Token: 0x06043946 RID: 276806
		bool IsLookDir { get; set; }
	}
}
