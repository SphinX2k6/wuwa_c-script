using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200058C RID: 1420
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Pclmulqdq : Sse2
	{
		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06006C24 RID: 27684 RVA: 0x001096AD File Offset: 0x001078AD
		public new static bool IsSupported
		{
			get
			{
				return Pclmulqdq.IsSupported;
			}
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x001096B4 File Offset: 0x001078B4
		public static Vector128<long> CarrylessMultiply(Vector128<long> left, Vector128<long> right, [ConstantExpected] byte control)
		{
			return Pclmulqdq.CarrylessMultiply(left, right, control);
		}

		// Token: 0x06006C26 RID: 27686 RVA: 0x001096BE File Offset: 0x001078BE
		public static Vector128<ulong> CarrylessMultiply(Vector128<ulong> left, Vector128<ulong> right, [ConstantExpected] byte control)
		{
			return Pclmulqdq.CarrylessMultiply(left, right, control);
		}

		// Token: 0x0200058D RID: 1421
		[Intrinsic]
		public new abstract class X64 : Sse2.X64
		{
			// Token: 0x17000D9A RID: 3482
			// (get) Token: 0x06006C27 RID: 27687 RVA: 0x001096C8 File Offset: 0x001078C8
			public new static bool IsSupported
			{
				get
				{
					return Pclmulqdq.X64.IsSupported;
				}
			}
		}
	}
}
