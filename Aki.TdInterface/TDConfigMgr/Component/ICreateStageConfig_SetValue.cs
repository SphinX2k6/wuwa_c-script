using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D7 RID: 727
	public class ICreateStageConfig_SetValue
	{
		// Token: 0x04000C80 RID: 3200
		public float? PerformDuration;

		// Token: 0x04000C81 RID: 3201
		[Nullable(2)]
		public ICreateBulletConfig BulletConfig;

		// Token: 0x04000C82 RID: 3202
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ActionInfo> Actions;
	}
}
