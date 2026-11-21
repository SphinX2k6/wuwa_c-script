using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005EC RID: 1516
	[NullableContext(1)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Class, Inherited = false)]
	public sealed class ProgIdAttribute : Attribute
	{
		// Token: 0x06007169 RID: 29033 RVA: 0x0010FF66 File Offset: 0x0010E166
		public ProgIdAttribute(string progId)
		{
			this.Value = progId;
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600716A RID: 29034 RVA: 0x0010FF75 File Offset: 0x0010E175
		public string Value { get; }
	}
}
