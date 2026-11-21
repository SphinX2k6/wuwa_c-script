using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200058E RID: 1422
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Popcnt : Sse42
	{
		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06006C28 RID: 27688 RVA: 0x001096CF File Offset: 0x001078CF
		public new static bool IsSupported
		{
			get
			{
				return Popcnt.IsSupported;
			}
		}

		// Token: 0x06006C29 RID: 27689 RVA: 0x001096D6 File Offset: 0x001078D6
		public static uint PopCount(uint value)
		{
			return Popcnt.PopCount(value);
		}

		// Token: 0x0200058F RID: 1423
		[Intrinsic]
		public new abstract class X64 : Sse42.X64
		{
			// Token: 0x17000D9C RID: 3484
			// (get) Token: 0x06006C2A RID: 27690 RVA: 0x001096DE File Offset: 0x001078DE
			public new static bool IsSupported
			{
				get
				{
					return Popcnt.X64.IsSupported;
				}
			}

			// Token: 0x06006C2B RID: 27691 RVA: 0x001096E5 File Offset: 0x001078E5
			public static ulong PopCount(ulong value)
			{
				return Popcnt.X64.PopCount(value);
			}
		}
	}
}
