using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch.Gameplay.Logic
{
	// Token: 0x0200567E RID: 22142
	[NullableContext(1)]
	[Nullable(0)]
	public class IDropPoolRuntime
	{
		// Token: 0x0401CDEC RID: 118252
		public int PoolId;

		// Token: 0x0401CDED RID: 118253
		public double LastSpawnTime;

		// Token: 0x0401CDEE RID: 118254
		public DropCatchGameplayAttribute SpawnTimeInterval;

		// Token: 0x0401CDEF RID: 118255
		public double LastSpawnPosX;

		// Token: 0x0401CDF0 RID: 118256
		public double SpawnPosInterval;

		// Token: 0x0401CDF1 RID: 118257
		public IAliasTable AliasTable;

		// Token: 0x0401CDF2 RID: 118258
		public List<double> TimeRange = new List<double>();
	}
}
