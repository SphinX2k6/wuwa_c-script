using System;

namespace System.Reflection
{
	// Token: 0x02000714 RID: 1812
	[Flags]
	internal enum PInfo
	{
		// Token: 0x040015C8 RID: 5576
		Attributes = 1,
		// Token: 0x040015C9 RID: 5577
		GetMethod = 2,
		// Token: 0x040015CA RID: 5578
		SetMethod = 4,
		// Token: 0x040015CB RID: 5579
		ReflectedType = 8,
		// Token: 0x040015CC RID: 5580
		DeclaringType = 16,
		// Token: 0x040015CD RID: 5581
		Name = 32
	}
}
