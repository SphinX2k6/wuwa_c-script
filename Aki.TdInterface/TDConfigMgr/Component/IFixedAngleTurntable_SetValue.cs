using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000391 RID: 913
	public class IFixedAngleTurntable_SetValue
	{
		// Token: 0x04000EA5 RID: 3749
		public EControllerType Type;

		// Token: 0x04000EA6 RID: 3750
		public int RotationSpeed;

		// Token: 0x04000EA7 RID: 3751
		[Nullable(1)]
		public List<IFixedAngleItem> ItemConfig;
	}
}
