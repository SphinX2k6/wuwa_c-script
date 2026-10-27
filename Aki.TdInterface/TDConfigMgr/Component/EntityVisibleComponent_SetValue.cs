using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000108 RID: 264
	public class EntityVisibleComponent_SetValue
	{
		// Token: 0x04000583 RID: 1411
		public bool? Disabled;

		// Token: 0x04000584 RID: 1412
		public bool? EdIsLocked;

		// Token: 0x04000585 RID: 1413
		public bool DelayChange;

		// Token: 0x04000586 RID: 1414
		public bool UseFadeEffect;

		// Token: 0x04000587 RID: 1415
		public bool? UseCutEffect;

		// Token: 0x04000588 RID: 1416
		public bool? UseHolographicEffect;

		// Token: 0x04000589 RID: 1417
		[Nullable(1)]
		public List<IVisibleConditionGroup> VisibleConditions;

		// Token: 0x0400058A RID: 1418
		public int? CustomVisibleRange;

		// Token: 0x0400058B RID: 1419
		public ERuntimePlatformOptions? TargetPlatform;
	}
}
