using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x02000725 RID: 1829
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyDescriptionAttribute : Attribute
	{
		// Token: 0x06007868 RID: 30824 RVA: 0x0011E71C File Offset: 0x0011C91C
		public AssemblyDescriptionAttribute(string description)
		{
			this.Description = description;
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06007869 RID: 30825 RVA: 0x0011E72B File Offset: 0x0011C92B
		public string Description { get; }
	}
}
