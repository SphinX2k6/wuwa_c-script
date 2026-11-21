using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x0200072F RID: 1839
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
	public sealed class AssemblyProductAttribute : Attribute
	{
		// Token: 0x06007881 RID: 30849 RVA: 0x0011E92E File Offset: 0x0011CB2E
		public AssemblyProductAttribute(string product)
		{
			this.Product = product;
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06007882 RID: 30850 RVA: 0x0011E93D File Offset: 0x0011CB3D
		public string Product { get; }
	}
}
