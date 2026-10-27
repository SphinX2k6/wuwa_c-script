using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020005D7 RID: 1495
	public class IPathDrivenActorInitialSpawnConfig_SetValue
	{
		// Token: 0x04001655 RID: 5717
		public bool EnableInitialSpawn;

		// Token: 0x04001656 RID: 5718
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IPathDrivenActorInitialSpawnHandle> InitialSpawnHandles;
	}
}
