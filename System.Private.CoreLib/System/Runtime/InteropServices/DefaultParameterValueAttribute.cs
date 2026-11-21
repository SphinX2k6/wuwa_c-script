using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005C8 RID: 1480
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class DefaultParameterValueAttribute : Attribute
	{
		// Token: 0x06007012 RID: 28690 RVA: 0x0010D9BD File Offset: 0x0010BBBD
		public DefaultParameterValueAttribute(object value)
		{
			this.Value = value;
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x06007013 RID: 28691 RVA: 0x0010D9CC File Offset: 0x0010BBCC
		public object Value { get; }
	}
}
