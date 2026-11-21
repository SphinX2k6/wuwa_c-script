using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000732 RID: 1842
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyTrademarkAttribute : Attribute
	{
		// Token: 0x06007888 RID: 30856 RVA: 0x0011E982 File Offset: 0x0011CB82
		public AssemblyTrademarkAttribute(string trademark)
		{
			this.Trademark = trademark;
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06007889 RID: 30857 RVA: 0x0011E991 File Offset: 0x0011CB91
		public string Trademark { get; }
	}
}
