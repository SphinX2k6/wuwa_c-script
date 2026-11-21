using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000923 RID: 2339
	public enum EventFieldFormat
	{
		// Token: 0x040020E9 RID: 8425
		Default,
		// Token: 0x040020EA RID: 8426
		String = 2,
		// Token: 0x040020EB RID: 8427
		Boolean,
		// Token: 0x040020EC RID: 8428
		Hexadecimal,
		// Token: 0x040020ED RID: 8429
		Xml = 11,
		// Token: 0x040020EE RID: 8430
		Json,
		// Token: 0x040020EF RID: 8431
		HResult = 15
	}
}
