using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000918 RID: 2328
	public enum EventChannel : byte
	{
		// Token: 0x040020BF RID: 8383
		None,
		// Token: 0x040020C0 RID: 8384
		Admin = 16,
		// Token: 0x040020C1 RID: 8385
		Operational,
		// Token: 0x040020C2 RID: 8386
		Analytic,
		// Token: 0x040020C3 RID: 8387
		Debug
	}
}
