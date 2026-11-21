using System;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x020004F2 RID: 1266
	[Flags]
	public enum ValueTaskSourceOnCompletedFlags
	{
		// Token: 0x04001109 RID: 4361
		None = 0,
		// Token: 0x0400110A RID: 4362
		UseSchedulingContext = 1,
		// Token: 0x0400110B RID: 4363
		FlowExecutionContext = 2
	}
}
