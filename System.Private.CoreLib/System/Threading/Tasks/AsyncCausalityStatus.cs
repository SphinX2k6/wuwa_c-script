using System;

namespace System.Threading.Tasks
{
	// Token: 0x0200048C RID: 1164
	internal enum AsyncCausalityStatus
	{
		// Token: 0x04000FA2 RID: 4002
		Started,
		// Token: 0x04000FA3 RID: 4003
		Completed,
		// Token: 0x04000FA4 RID: 4004
		Canceled,
		// Token: 0x04000FA5 RID: 4005
		Error
	}
}
