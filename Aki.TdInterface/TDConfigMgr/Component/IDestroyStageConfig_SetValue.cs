using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002FD RID: 765
	public class IDestroyStageConfig_SetValue
	{
		// Token: 0x04000CD7 RID: 3287
		public float? PerformDuration;

		// Token: 0x04000CD8 RID: 3288
		public long? BulletId;

		// Token: 0x04000CD9 RID: 3289
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;
	}
}
