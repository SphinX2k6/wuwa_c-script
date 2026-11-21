using System;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008A4 RID: 2212
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, Inherited = false)]
	public sealed class DynamicallyAccessedMembersAttribute : Attribute
	{
		// Token: 0x060089D6 RID: 35286 RVA: 0x0014E86A File Offset: 0x0014CA6A
		public DynamicallyAccessedMembersAttribute(DynamicallyAccessedMemberTypes memberTypes)
		{
			this.MemberTypes = memberTypes;
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x060089D7 RID: 35287 RVA: 0x0014E879 File Offset: 0x0014CA79
		public DynamicallyAccessedMemberTypes MemberTypes { get; }
	}
}
