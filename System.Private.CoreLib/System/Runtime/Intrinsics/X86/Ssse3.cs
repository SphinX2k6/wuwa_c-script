using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200059A RID: 1434
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Ssse3 : Sse3
	{
		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06006E6A RID: 28266 RVA: 0x0010AA8B File Offset: 0x00108C8B
		public new static bool IsSupported
		{
			get
			{
				return Ssse3.IsSupported;
			}
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x0010AA92 File Offset: 0x00108C92
		public static Vector128<byte> Abs(Vector128<sbyte> value)
		{
			return Ssse3.Abs(value);
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x0010AA9A File Offset: 0x00108C9A
		public static Vector128<ushort> Abs(Vector128<short> value)
		{
			return Ssse3.Abs(value);
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x0010AAA2 File Offset: 0x00108CA2
		public static Vector128<uint> Abs(Vector128<int> value)
		{
			return Ssse3.Abs(value);
		}

		// Token: 0x06006E6E RID: 28270 RVA: 0x0010AAAA File Offset: 0x00108CAA
		public static Vector128<sbyte> AlignRight(Vector128<sbyte> left, Vector128<sbyte> right, [ConstantExpected] byte mask)
		{
			return Ssse3.AlignRight(left, right, mask);
		}

		// Token: 0x06006E6F RID: 28271 RVA: 0x0010AAB4 File Offset: 0x00108CB4
		public static Vector128<byte> AlignRight(Vector128<byte> left, Vector128<byte> right, [ConstantExpected] byte mask)
		{
			return Ssse3.AlignRight(left, right, mask);
		}

		// Token: 0x06006E70 RID: 28272 RVA: 0x0010AABE File Offset: 0x00108CBE
		public static Vector128<short> AlignRight(Vector128<short> left, Vector128<short> right, [ConstantExpected] byte mask)
		{
			return Ssse3.AlignRight(left, right, mask);
		}

		// Token: 0x06006E71 RID: 28273 RVA: 0x0010AAC8 File Offset: 0x00108CC8
		public static Vector128<ushort> AlignRight(Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected] byte mask)
		{
			return Ssse3.AlignRight(left, right, mask);
		}

		// Token: 0x06006E72 RID: 28274 RVA: 0x0010AAD2 File Offset: 0x00108CD2
		public static Vector128<int> AlignRight(Vector128<int> left, Vector128<int> right, [ConstantExpected] byte mask)
		{
			return Ssse3.AlignRight(left, right, mask);
		}

		// Token: 0x06006E73 RID: 28275 RVA: 0x0010AADC File Offset: 0x00108CDC
		public static Vector128<uint> AlignRight(Vector128<uint> left, Vector128<uint> right, [ConstantExpected] byte mask)
		{
			return Ssse3.AlignRight(left, right, mask);
		}

		// Token: 0x06006E74 RID: 28276 RVA: 0x0010AAE6 File Offset: 0x00108CE6
		public static Vector128<long> AlignRight(Vector128<long> left, Vector128<long> right, [ConstantExpected] byte mask)
		{
			return Ssse3.AlignRight(left, right, mask);
		}

		// Token: 0x06006E75 RID: 28277 RVA: 0x0010AAF0 File Offset: 0x00108CF0
		public static Vector128<ulong> AlignRight(Vector128<ulong> left, Vector128<ulong> right, [ConstantExpected] byte mask)
		{
			return Ssse3.AlignRight(left, right, mask);
		}

		// Token: 0x06006E76 RID: 28278 RVA: 0x0010AAFA File Offset: 0x00108CFA
		public static Vector128<short> HorizontalAdd(Vector128<short> left, Vector128<short> right)
		{
			return Ssse3.HorizontalAdd(left, right);
		}

		// Token: 0x06006E77 RID: 28279 RVA: 0x0010AB03 File Offset: 0x00108D03
		public static Vector128<int> HorizontalAdd(Vector128<int> left, Vector128<int> right)
		{
			return Ssse3.HorizontalAdd(left, right);
		}

		// Token: 0x06006E78 RID: 28280 RVA: 0x0010AB0C File Offset: 0x00108D0C
		public static Vector128<short> HorizontalAddSaturate(Vector128<short> left, Vector128<short> right)
		{
			return Ssse3.HorizontalAddSaturate(left, right);
		}

		// Token: 0x06006E79 RID: 28281 RVA: 0x0010AB15 File Offset: 0x00108D15
		public static Vector128<short> HorizontalSubtract(Vector128<short> left, Vector128<short> right)
		{
			return Ssse3.HorizontalSubtract(left, right);
		}

		// Token: 0x06006E7A RID: 28282 RVA: 0x0010AB1E File Offset: 0x00108D1E
		public static Vector128<int> HorizontalSubtract(Vector128<int> left, Vector128<int> right)
		{
			return Ssse3.HorizontalSubtract(left, right);
		}

		// Token: 0x06006E7B RID: 28283 RVA: 0x0010AB27 File Offset: 0x00108D27
		public static Vector128<short> HorizontalSubtractSaturate(Vector128<short> left, Vector128<short> right)
		{
			return Ssse3.HorizontalSubtractSaturate(left, right);
		}

		// Token: 0x06006E7C RID: 28284 RVA: 0x0010AB30 File Offset: 0x00108D30
		public static Vector128<short> MultiplyAddAdjacent(Vector128<byte> left, Vector128<sbyte> right)
		{
			return Ssse3.MultiplyAddAdjacent(left, right);
		}

		// Token: 0x06006E7D RID: 28285 RVA: 0x0010AB39 File Offset: 0x00108D39
		public static Vector128<short> MultiplyHighRoundScale(Vector128<short> left, Vector128<short> right)
		{
			return Ssse3.MultiplyHighRoundScale(left, right);
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x0010AB42 File Offset: 0x00108D42
		public static Vector128<sbyte> Shuffle(Vector128<sbyte> value, Vector128<sbyte> mask)
		{
			return Ssse3.Shuffle(value, mask);
		}

		// Token: 0x06006E7F RID: 28287 RVA: 0x0010AB4B File Offset: 0x00108D4B
		public static Vector128<byte> Shuffle(Vector128<byte> value, Vector128<byte> mask)
		{
			return Ssse3.Shuffle(value, mask);
		}

		// Token: 0x06006E80 RID: 28288 RVA: 0x0010AB54 File Offset: 0x00108D54
		public static Vector128<sbyte> Sign(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Ssse3.Sign(left, right);
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x0010AB5D File Offset: 0x00108D5D
		public static Vector128<short> Sign(Vector128<short> left, Vector128<short> right)
		{
			return Ssse3.Sign(left, right);
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x0010AB66 File Offset: 0x00108D66
		public static Vector128<int> Sign(Vector128<int> left, Vector128<int> right)
		{
			return Ssse3.Sign(left, right);
		}

		// Token: 0x0200059B RID: 1435
		[Intrinsic]
		public new abstract class X64 : Sse3.X64
		{
			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x06006E83 RID: 28291 RVA: 0x0010AB6F File Offset: 0x00108D6F
			public new static bool IsSupported
			{
				get
				{
					return Ssse3.X64.IsSupported;
				}
			}
		}
	}
}
