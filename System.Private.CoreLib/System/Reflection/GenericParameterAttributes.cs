using System;

namespace System.Reflection
{
	// Token: 0x02000744 RID: 1860
	[Flags]
	public enum GenericParameterAttributes
	{
		// Token: 0x0400166B RID: 5739
		None = 0,
		// Token: 0x0400166C RID: 5740
		VarianceMask = 3,
		// Token: 0x0400166D RID: 5741
		Covariant = 1,
		// Token: 0x0400166E RID: 5742
		Contravariant = 2,
		// Token: 0x0400166F RID: 5743
		SpecialConstraintMask = 28,
		// Token: 0x04001670 RID: 5744
		ReferenceTypeConstraint = 4,
		// Token: 0x04001671 RID: 5745
		NotNullableValueTypeConstraint = 8,
		// Token: 0x04001672 RID: 5746
		DefaultConstructorConstraint = 16,
		// Token: 0x04001673 RID: 5747
		AllowByRefLike = 32
	}
}
