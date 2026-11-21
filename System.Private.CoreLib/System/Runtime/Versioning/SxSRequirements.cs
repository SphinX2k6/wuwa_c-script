using System;

namespace System.Runtime.Versioning
{
	// Token: 0x02000516 RID: 1302
	[Flags]
	internal enum SxSRequirements
	{
		// Token: 0x04001152 RID: 4434
		None = 0,
		// Token: 0x04001153 RID: 4435
		AppDomainID = 1,
		// Token: 0x04001154 RID: 4436
		ProcessID = 2,
		// Token: 0x04001155 RID: 4437
		CLRInstanceID = 4,
		// Token: 0x04001156 RID: 4438
		AssemblyName = 8,
		// Token: 0x04001157 RID: 4439
		TypeName = 16
	}
}
