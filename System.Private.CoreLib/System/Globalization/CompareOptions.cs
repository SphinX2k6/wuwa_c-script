using System;

namespace System.Globalization
{
	// Token: 0x020002D1 RID: 721
	[Flags]
	public enum CompareOptions
	{
		// Token: 0x04000954 RID: 2388
		None = 0,
		// Token: 0x04000955 RID: 2389
		IgnoreCase = 1,
		// Token: 0x04000956 RID: 2390
		IgnoreNonSpace = 2,
		// Token: 0x04000957 RID: 2391
		IgnoreSymbols = 4,
		// Token: 0x04000958 RID: 2392
		IgnoreKanaType = 8,
		// Token: 0x04000959 RID: 2393
		IgnoreWidth = 16,
		// Token: 0x0400095A RID: 2394
		OrdinalIgnoreCase = 268435456,
		// Token: 0x0400095B RID: 2395
		StringSort = 536870912,
		// Token: 0x0400095C RID: 2396
		Ordinal = 1073741824
	}
}
