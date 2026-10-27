using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002116 RID: 8470
	public class PlayFlow_SetValue
	{
		// Token: 0x04006F81 RID: 28545
		[Nullable(1)]
		public string FlowListName;

		// Token: 0x04006F82 RID: 28546
		public int FlowId;

		// Token: 0x04006F83 RID: 28547
		public int StateId;

		// Token: 0x04006F84 RID: 28548
		[Nullable(2)]
		public string FlowGuid;
	}
}
