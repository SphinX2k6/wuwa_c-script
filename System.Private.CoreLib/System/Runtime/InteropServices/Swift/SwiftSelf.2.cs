using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.Swift
{
	// Token: 0x02000606 RID: 1542
	[Intrinsic]
	public readonly struct SwiftSelf<[IsUnmanaged] T> where T : struct, ValueType
	{
		// Token: 0x060071C0 RID: 29120 RVA: 0x00110933 File Offset: 0x0010EB33
		public SwiftSelf(T value)
		{
			this.Value = value;
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060071C1 RID: 29121 RVA: 0x0011093C File Offset: 0x0010EB3C
		public T Value { get; }
	}
}
