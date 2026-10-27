using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020003C9 RID: 969
	public class IFreeAngleTurntable_SetValue
	{
		// Token: 0x04000F7B RID: 3963
		public EControllerType Type;

		// Token: 0x04000F7C RID: 3964
		public int RotationSpeed;

		// Token: 0x04000F7D RID: 3965
		[Nullable(1)]
		public List<IFreeAngleItem> ItemConfig;

		// Token: 0x04000F7E RID: 3966
		public int IntervalAngle;
	}
}
