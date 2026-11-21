using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Swift
{
	// Token: 0x02000607 RID: 1543
	[CLSCompliant(false)]
	[Intrinsic]
	public readonly struct SwiftError
	{
		// Token: 0x060071C2 RID: 29122 RVA: 0x00110944 File Offset: 0x0010EB44
		public unsafe SwiftError(void* value)
		{
			this.Value = value;
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x060071C3 RID: 29123 RVA: 0x0011094D File Offset: 0x0010EB4D
		public unsafe void* Value { get; }
	}
}
