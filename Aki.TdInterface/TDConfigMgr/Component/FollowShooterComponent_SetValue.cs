using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200017A RID: 378
	public class FollowShooterComponent_SetValue
	{
		// Token: 0x0400073A RID: 1850
		public bool? Disabled;

		// Token: 0x0400073B RID: 1851
		public bool? EdIsLocked;

		// Token: 0x0400073C RID: 1852
		[Nullable(1)]
		public string Config;

		// Token: 0x0400073D RID: 1853
		[Nullable(2)]
		public IFollowShooterJellyFishConfig TypeConfig;

		// Token: 0x0400073E RID: 1854
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<IEntityCategory> LockableCategories;
	}
}
