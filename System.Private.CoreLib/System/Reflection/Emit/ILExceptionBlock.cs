using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007A9 RID: 1961
	internal struct ILExceptionBlock
	{
		// Token: 0x040017EE RID: 6126
		internal Type extype;

		// Token: 0x040017EF RID: 6127
		internal int type;

		// Token: 0x040017F0 RID: 6128
		internal int start;

		// Token: 0x040017F1 RID: 6129
		internal int len;

		// Token: 0x040017F2 RID: 6130
		internal int filter_offset;
	}
}
