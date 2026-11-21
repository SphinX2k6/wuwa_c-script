using System;

namespace System.Runtime.Versioning
{
	// Token: 0x02000514 RID: 1300
	[Flags]
	public enum ResourceScope
	{
		// Token: 0x04001148 RID: 4424
		None = 0,
		// Token: 0x04001149 RID: 4425
		Machine = 1,
		// Token: 0x0400114A RID: 4426
		Process = 2,
		// Token: 0x0400114B RID: 4427
		AppDomain = 4,
		// Token: 0x0400114C RID: 4428
		Library = 8,
		// Token: 0x0400114D RID: 4429
		Private = 16,
		// Token: 0x0400114E RID: 4430
		Assembly = 32
	}
}
