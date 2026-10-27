using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008E9 RID: 2281
	public class WindSourceComponent_SetValue
	{
		// Token: 0x040021E3 RID: 8675
		public bool? Disabled;

		// Token: 0x040021E4 RID: 8676
		public bool? EdIsLocked;

		// Token: 0x040021E5 RID: 8677
		[Nullable(1)]
		public IWindDirectional WindSource;
	}
}
