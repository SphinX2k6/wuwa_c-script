using System;

namespace System.Threading.Tasks
{
	// Token: 0x020004A7 RID: 1191
	public enum TaskStatus
	{
		// Token: 0x04000FFE RID: 4094
		Created,
		// Token: 0x04000FFF RID: 4095
		WaitingForActivation,
		// Token: 0x04001000 RID: 4096
		WaitingToRun,
		// Token: 0x04001001 RID: 4097
		Running,
		// Token: 0x04001002 RID: 4098
		WaitingForChildrenToComplete,
		// Token: 0x04001003 RID: 4099
		RanToCompletion,
		// Token: 0x04001004 RID: 4100
		Canceled,
		// Token: 0x04001005 RID: 4101
		Faulted
	}
}
