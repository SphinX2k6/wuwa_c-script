using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000723 RID: 1827
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDefaultAliasAttribute : Attribute
	{
		// Token: 0x06007864 RID: 30820 RVA: 0x0011E6EE File Offset: 0x0011C8EE
		public AssemblyDefaultAliasAttribute(string defaultAlias)
		{
			this.DefaultAlias = defaultAlias;
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06007865 RID: 30821 RVA: 0x0011E6FD File Offset: 0x0011C8FD
		public string DefaultAlias { get; }
	}
}
