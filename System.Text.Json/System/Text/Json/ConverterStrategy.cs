using System;

namespace System.Text.Json
{
	// Token: 0x02000042 RID: 66
	internal enum ConverterStrategy : byte
	{
		// Token: 0x040000F6 RID: 246
		None,
		// Token: 0x040000F7 RID: 247
		Object,
		// Token: 0x040000F8 RID: 248
		Value,
		// Token: 0x040000F9 RID: 249
		Enumerable = 8,
		// Token: 0x040000FA RID: 250
		Dictionary = 16
	}
}
