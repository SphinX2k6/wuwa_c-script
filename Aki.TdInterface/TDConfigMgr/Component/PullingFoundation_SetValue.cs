using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000862 RID: 2146
	public class PullingFoundation_SetValue
	{
		// Token: 0x04001F4E RID: 8014
		public bool? Disabled;

		// Token: 0x04001F4F RID: 8015
		public bool? EdIsLocked;

		// Token: 0x04001F50 RID: 8016
		[Nullable(1)]
		public IPullingCategoryMatchingFoundation Config;
	}
}
