using System;
using System.Collections.Generic;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000111 RID: 273
	public class EntityVisibleComponent_SetValue
	{
		// Token: 0x040005AD RID: 1453
		public bool? Disabled;

		// Token: 0x040005AE RID: 1454
		public bool? EdIsLocked;

		// Token: 0x040005AF RID: 1455
		public bool DelayChange;

		// Token: 0x040005B0 RID: 1456
		public bool UseFadeEffect;

		// Token: 0x040005B1 RID: 1457
		public bool? UseCutEffect;

		// Token: 0x040005B2 RID: 1458
		public bool? UseHolographicEffect;

		// Token: 0x040005B3 RID: 1459
		public List<IVisibleConditionGroup> VisibleConditions;

		// Token: 0x040005B4 RID: 1460
		public int? CustomVisibleRange;

		// Token: 0x040005B5 RID: 1461
		public ERuntimePlatformOptions? TargetPlatform;
	}
}
