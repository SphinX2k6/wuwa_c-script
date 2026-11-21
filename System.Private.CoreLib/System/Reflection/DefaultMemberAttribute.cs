using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200073E RID: 1854
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class DefaultMemberAttribute : Attribute
	{
		// Token: 0x060078E9 RID: 30953 RVA: 0x0011F333 File Offset: 0x0011D533
		public DefaultMemberAttribute(string memberName)
		{
			this.MemberName = memberName;
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x060078EA RID: 30954 RVA: 0x0011F342 File Offset: 0x0011D542
		public string MemberName { get; }
	}
}
