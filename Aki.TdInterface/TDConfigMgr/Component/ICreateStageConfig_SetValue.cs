using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000294 RID: 660
	public class ICreateStageConfig_SetValue
	{
		// Token: 0x04000B9F RID: 2975
		public float? PerformDuration;

		// Token: 0x04000BA0 RID: 2976
		[Nullable(2)]
		public ICreateBulletConfig BulletConfig;

		// Token: 0x04000BA1 RID: 2977
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;
	}
}
