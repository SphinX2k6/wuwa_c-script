using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008A6 RID: 2214
	public class SpringComponent_SetValue
	{
		// Token: 0x0400208B RID: 8331
		public bool? Disabled;

		// Token: 0x0400208C RID: 8332
		public bool? EdIsLocked;

		// Token: 0x0400208D RID: 8333
		public bool IsNormalSpring;

		// Token: 0x0400208E RID: 8334
		public bool IsHitNormalSpring;

		// Token: 0x0400208F RID: 8335
		[Nullable(1)]
		public ISettingSpringDir SettingDir;

		// Token: 0x04002090 RID: 8336
		public int SpringPow;
	}
}
