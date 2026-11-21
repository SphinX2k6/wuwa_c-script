using System;

namespace System.Reflection
{
	// Token: 0x02000756 RID: 1878
	[Flags]
	public enum MemberTypes
	{
		// Token: 0x04001693 RID: 5779
		Constructor = 1,
		// Token: 0x04001694 RID: 5780
		Event = 2,
		// Token: 0x04001695 RID: 5781
		Field = 4,
		// Token: 0x04001696 RID: 5782
		Method = 8,
		// Token: 0x04001697 RID: 5783
		Property = 16,
		// Token: 0x04001698 RID: 5784
		TypeInfo = 32,
		// Token: 0x04001699 RID: 5785
		Custom = 64,
		// Token: 0x0400169A RID: 5786
		NestedType = 128,
		// Token: 0x0400169B RID: 5787
		All = 191
	}
}
