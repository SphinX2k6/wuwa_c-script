using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002B6 RID: 694
	public class IDestroyStageConfig_SetValue
	{
		// Token: 0x04000BED RID: 3053
		public float? PerformDuration;

		// Token: 0x04000BEE RID: 3054
		public long? BulletId;

		// Token: 0x04000BEF RID: 3055
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> Actions;
	}
}
