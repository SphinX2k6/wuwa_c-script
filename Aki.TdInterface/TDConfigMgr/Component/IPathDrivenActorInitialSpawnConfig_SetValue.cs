using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000668 RID: 1640
	public class IPathDrivenActorInitialSpawnConfig_SetValue
	{
		// Token: 0x0400182C RID: 6188
		public bool EnableInitialSpawn;

		// Token: 0x0400182D RID: 6189
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IPathDrivenActorInitialSpawnHandle> InitialSpawnHandles;
	}
}
