using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000031 RID: 49
	public class BehaviorFlowComponent_SetValue
	{
		// Token: 0x0400011E RID: 286
		public bool? Disabled;

		// Token: 0x0400011F RID: 287
		public bool? EdIsLocked;

		// Token: 0x04000120 RID: 288
		public bool? _folded;

		// Token: 0x04000121 RID: 289
		public int InitStateId;

		// Token: 0x04000122 RID: 290
		[Nullable(1)]
		public IFlowInfo FlowInfo;
	}
}
