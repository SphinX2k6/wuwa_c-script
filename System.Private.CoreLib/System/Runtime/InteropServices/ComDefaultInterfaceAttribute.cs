using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005B4 RID: 1460
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class ComDefaultInterfaceAttribute : Attribute
	{
		// Token: 0x06006FD7 RID: 28631 RVA: 0x0010D592 File Offset: 0x0010B792
		public ComDefaultInterfaceAttribute(Type defaultInterface)
		{
			this.Value = defaultInterface;
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06006FD8 RID: 28632 RVA: 0x0010D5A1 File Offset: 0x0010B7A1
		public Type Value { get; }
	}
}
