using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Swift
{
	// Token: 0x02000608 RID: 1544
	[CLSCompliant(false)]
	[Intrinsic]
	public readonly struct SwiftIndirectResult
	{
		// Token: 0x060071C4 RID: 29124 RVA: 0x00110955 File Offset: 0x0010EB55
		public unsafe SwiftIndirectResult(void* value)
		{
			this.Value = value;
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060071C5 RID: 29125 RVA: 0x0011095E File Offset: 0x0010EB5E
		public unsafe void* Value { get; }
	}
}
