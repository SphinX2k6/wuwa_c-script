using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200004D RID: 77
	public class ConveyorBeltComponent_SetValue
	{
		// Token: 0x04000191 RID: 401
		public bool? Disabled;

		// Token: 0x04000192 RID: 402
		public bool? EdIsLocked;

		// Token: 0x04000193 RID: 403
		[Nullable(1)]
		public List<IConveyorBeltState> StateGroups;
	}
}
