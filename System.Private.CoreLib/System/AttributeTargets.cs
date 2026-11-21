using System;

namespace System
{
	// Token: 0x020000DB RID: 219
	[Flags]
	public enum AttributeTargets
	{
		// Token: 0x040002EA RID: 746
		Assembly = 1,
		// Token: 0x040002EB RID: 747
		Module = 2,
		// Token: 0x040002EC RID: 748
		Class = 4,
		// Token: 0x040002ED RID: 749
		Struct = 8,
		// Token: 0x040002EE RID: 750
		Enum = 16,
		// Token: 0x040002EF RID: 751
		Constructor = 32,
		// Token: 0x040002F0 RID: 752
		Method = 64,
		// Token: 0x040002F1 RID: 753
		Property = 128,
		// Token: 0x040002F2 RID: 754
		Field = 256,
		// Token: 0x040002F3 RID: 755
		Event = 512,
		// Token: 0x040002F4 RID: 756
		Interface = 1024,
		// Token: 0x040002F5 RID: 757
		Parameter = 2048,
		// Token: 0x040002F6 RID: 758
		Delegate = 4096,
		// Token: 0x040002F7 RID: 759
		ReturnValue = 8192,
		// Token: 0x040002F8 RID: 760
		GenericParameter = 16384,
		// Token: 0x040002F9 RID: 761
		All = 32767
	}
}
