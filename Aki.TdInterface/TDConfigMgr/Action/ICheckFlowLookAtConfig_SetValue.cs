using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A1E RID: 6686
	public class ICheckFlowLookAtConfig_SetValue
	{
		// Token: 0x04005968 RID: 22888
		public PlayFlow Flow;

		// Token: 0x04005969 RID: 22889
		public ICheckFlowLookAtTarget Target;

		// Token: 0x0400596A RID: 22890
		[Nullable(2)]
		public IEntityLookAtPerform EntityLookAtPerform;
	}
}
