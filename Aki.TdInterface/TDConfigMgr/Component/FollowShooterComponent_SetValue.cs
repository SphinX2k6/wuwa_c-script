using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200018F RID: 399
	public class FollowShooterComponent_SetValue
	{
		// Token: 0x04000787 RID: 1927
		public bool? Disabled;

		// Token: 0x04000788 RID: 1928
		public bool? EdIsLocked;

		// Token: 0x04000789 RID: 1929
		public string Config;

		// Token: 0x0400078A RID: 1930
		[Nullable(2)]
		public IFollowShooterJellyFishConfig TypeConfig;

		// Token: 0x0400078B RID: 1931
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<IEntityCategory> LockableCategories;
	}
}
