using System;

namespace System.Reflection.Emit
{
	// Token: 0x020007C2 RID: 1986
	public enum FlowControl
	{
		// Token: 0x040018A7 RID: 6311
		Branch,
		// Token: 0x040018A8 RID: 6312
		Break,
		// Token: 0x040018A9 RID: 6313
		Call,
		// Token: 0x040018AA RID: 6314
		Cond_Branch,
		// Token: 0x040018AB RID: 6315
		Meta,
		// Token: 0x040018AC RID: 6316
		Next,
		// Token: 0x040018AD RID: 6317
		[Obsolete("FlowControl.Phi has been deprecated and is not supported.")]
		Phi,
		// Token: 0x040018AE RID: 6318
		Return,
		// Token: 0x040018AF RID: 6319
		Throw
	}
}
