using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005F5 RID: 1525
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	public sealed class TypeIdentifierAttribute : Attribute
	{
		// Token: 0x06007197 RID: 29079 RVA: 0x00022817 File Offset: 0x00020A17
		public TypeIdentifierAttribute()
		{
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x0011070B File Offset: 0x0010E90B
		public TypeIdentifierAttribute(string scope, string identifier)
		{
			this.Scope = scope;
			this.Identifier = identifier;
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06007199 RID: 29081 RVA: 0x00110721 File Offset: 0x0010E921
		public string Scope { get; }

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x0600719A RID: 29082 RVA: 0x00110729 File Offset: 0x0010E929
		public string Identifier { get; }
	}
}
