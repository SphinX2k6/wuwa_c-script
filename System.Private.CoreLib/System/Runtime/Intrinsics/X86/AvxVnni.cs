using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000582 RID: 1410
	[CLSCompliant(false)]
	public abstract class AvxVnni : Avx2
	{
		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06006BD9 RID: 27609 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningAndAdd(Vector128<int> addend, Vector128<byte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BDA RID: 27610 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningAndAdd(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BDB RID: 27611 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> MultiplyWideningAndAdd(Vector256<int> addend, Vector256<byte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BDC RID: 27612 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> MultiplyWideningAndAdd(Vector256<int> addend, Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BDD RID: 27613 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningAndAddSaturate(Vector128<int> addend, Vector128<byte> left, Vector128<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BDE RID: 27614 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyWideningAndAddSaturate(Vector128<int> addend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> MultiplyWideningAndAddSaturate(Vector256<int> addend, Vector256<byte> left, Vector256<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> MultiplyWideningAndAddSaturate(Vector256<int> addend, Vector256<short> left, Vector256<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000583 RID: 1411
		public new abstract class X64 : Avx2.X64
		{
			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x06006BE1 RID: 27617 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}
		}
	}
}
