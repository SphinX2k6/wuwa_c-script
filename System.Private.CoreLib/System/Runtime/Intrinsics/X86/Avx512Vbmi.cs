using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200057F RID: 1407
	[CLSCompliant(false)]
	public abstract class Avx512Vbmi : Avx512BW
	{
		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06006BC3 RID: 27587 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> MultiShift(Vector512<byte> control, Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> MultiShift(Vector512<sbyte> control, Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> PermuteVar64x8(Vector512<sbyte> left, Vector512<sbyte> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> PermuteVar64x8(Vector512<byte> left, Vector512<byte> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> PermuteVar64x8x2(Vector512<byte> lower, Vector512<byte> indices, Vector512<byte> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> PermuteVar64x8x2(Vector512<sbyte> lower, Vector512<sbyte> indices, Vector512<sbyte> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000580 RID: 1408
		public new abstract class VL : Avx512BW.VL
		{
			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x06006BCA RID: 27594 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06006BCB RID: 27595 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> MultiShift(Vector128<byte> control, Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BCC RID: 27596 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> MultiShift(Vector128<sbyte> control, Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BCD RID: 27597 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> MultiShift(Vector256<byte> control, Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BCE RID: 27598 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<sbyte> MultiShift(Vector256<sbyte> control, Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BCF RID: 27599 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> PermuteVar16x8(Vector128<sbyte> left, Vector128<sbyte> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BD0 RID: 27600 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> PermuteVar16x8(Vector128<byte> left, Vector128<byte> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BD1 RID: 27601 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> PermuteVar16x8x2(Vector128<byte> lower, Vector128<byte> indices, Vector128<byte> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BD2 RID: 27602 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> PermuteVar16x8x2(Vector128<sbyte> lower, Vector128<sbyte> indices, Vector128<sbyte> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BD3 RID: 27603 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<sbyte> PermuteVar32x8(Vector256<sbyte> left, Vector256<sbyte> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BD4 RID: 27604 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> PermuteVar32x8(Vector256<byte> left, Vector256<byte> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BD5 RID: 27605 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> PermuteVar32x8x2(Vector256<byte> lower, Vector256<byte> indices, Vector256<byte> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BD6 RID: 27606 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<sbyte> PermuteVar32x8x2(Vector256<sbyte> lower, Vector256<sbyte> indices, Vector256<sbyte> upper)
			{
				throw new PlatformNotSupportedException();
			}
		}

		// Token: 0x02000581 RID: 1409
		public new abstract class X64 : Avx512BW.X64
		{
			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x00007B65 File Offset: 0x00005D65
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
