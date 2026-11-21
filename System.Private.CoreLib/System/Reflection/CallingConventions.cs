using System;

namespace System.Reflection
{
	// Token: 0x02000736 RID: 1846
	[Flags]
	public enum CallingConventions
	{
		// Token: 0x0400161B RID: 5659
		Standard = 1,
		// Token: 0x0400161C RID: 5660
		VarArgs = 2,
		// Token: 0x0400161D RID: 5661
		Any = 3,
		// Token: 0x0400161E RID: 5662
		HasThis = 32,
		// Token: 0x0400161F RID: 5663
		ExplicitThis = 64
	}
}
