using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002D8 RID: 728
	public class IDurabilityStateConfig_SetValue
	{
		// Token: 0x04000C74 RID: 3188
		public bool? NonDestructable;

		// Token: 0x04000C75 RID: 3189
		[Nullable(1)]
		public List<IDurabilityState> DurabilityStates;
	}
}
