using System;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.CodeAnalysis
{
	// Token: 0x020008A2 RID: 2210
	[NullableContext(2)]
	[Nullable(0)]
	[AttributeUsage(AttributeTargets.Parameter, Inherited = false)]
	public sealed class ConstantExpectedAttribute : Attribute
	{
		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x060089D1 RID: 35281 RVA: 0x0014E848 File Offset: 0x0014CA48
		// (set) Token: 0x060089D2 RID: 35282 RVA: 0x0014E850 File Offset: 0x0014CA50
		public object Min { get; set; }

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x060089D3 RID: 35283 RVA: 0x0014E859 File Offset: 0x0014CA59
		// (set) Token: 0x060089D4 RID: 35284 RVA: 0x0014E861 File Offset: 0x0014CA61
		public object Max { get; set; }
	}
}
