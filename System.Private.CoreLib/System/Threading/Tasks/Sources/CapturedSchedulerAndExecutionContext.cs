using System;

namespace System.Threading.Tasks.Sources
{
	// Token: 0x020004F7 RID: 1271
	internal sealed class CapturedSchedulerAndExecutionContext
	{
		// Token: 0x0600480A RID: 18442 RVA: 0x000F02B1 File Offset: 0x000EE4B1
		public CapturedSchedulerAndExecutionContext(object scheduler, ExecutionContext executionContext)
		{
			this._scheduler = scheduler;
			this._executionContext = executionContext;
		}

		// Token: 0x04001119 RID: 4377
		internal readonly object _scheduler;

		// Token: 0x0400111A RID: 4378
		internal readonly ExecutionContext _executionContext;
	}
}
