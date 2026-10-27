using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018A RID: 394
	public class GravityFlipComponent_SetValue
	{
		// Token: 0x0400077D RID: 1917
		public bool? Disabled;

		// Token: 0x0400077E RID: 1918
		public bool? EdIsLocked;

		// Token: 0x0400077F RID: 1919
		[Nullable(1)]
		public List<IGravityFlipConfig> Config;

		// Token: 0x04000780 RID: 1920
		public EGravityFlipType DefaultGravity;
	}
}
