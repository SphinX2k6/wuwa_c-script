using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Swift
{
	// Token: 0x02000605 RID: 1541
	[CLSCompliant(false)]
	[Intrinsic]
	public readonly struct SwiftSelf
	{
		// Token: 0x060071BE RID: 29118 RVA: 0x00110922 File Offset: 0x0010EB22
		public unsafe SwiftSelf(void* value)
		{
			this.Value = value;
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x0011092B File Offset: 0x0010EB2B
		public unsafe void* Value { get; }
	}
}
