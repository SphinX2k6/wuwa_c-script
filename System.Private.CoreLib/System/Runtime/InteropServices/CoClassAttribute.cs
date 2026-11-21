using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005B2 RID: 1458
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Interface, Inherited = false)]
	public sealed class CoClassAttribute : Attribute
	{
		// Token: 0x06006FCF RID: 28623 RVA: 0x0010D49F File Offset: 0x0010B69F
		public CoClassAttribute(Type coClass)
		{
			this.CoClass = coClass;
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06006FD0 RID: 28624 RVA: 0x0010D4AE File Offset: 0x0010B6AE
		public Type CoClass { get; }
	}
}
