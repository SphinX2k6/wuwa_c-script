using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000584 RID: 1412
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Bmi1 : X86Base
	{
		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06006BE2 RID: 27618 RVA: 0x00109597 File Offset: 0x00107797
		public new static bool IsSupported
		{
			get
			{
				return Bmi1.IsSupported;
			}
		}

		// Token: 0x06006BE3 RID: 27619 RVA: 0x0010959E File Offset: 0x0010779E
		public static uint AndNot(uint left, uint right)
		{
			return Bmi1.AndNot(left, right);
		}

		// Token: 0x06006BE4 RID: 27620 RVA: 0x001095A7 File Offset: 0x001077A7
		public static uint BitFieldExtract(uint value, byte start, byte length)
		{
			return Bmi1.BitFieldExtract(value, (ushort)((int)start | (int)length << 8));
		}

		// Token: 0x06006BE5 RID: 27621 RVA: 0x001095B5 File Offset: 0x001077B5
		public static uint BitFieldExtract(uint value, ushort control)
		{
			return Bmi1.BitFieldExtract(value, control);
		}

		// Token: 0x06006BE6 RID: 27622 RVA: 0x001095BE File Offset: 0x001077BE
		public static uint ExtractLowestSetBit(uint value)
		{
			return Bmi1.ExtractLowestSetBit(value);
		}

		// Token: 0x06006BE7 RID: 27623 RVA: 0x001095C6 File Offset: 0x001077C6
		public static uint GetMaskUpToLowestSetBit(uint value)
		{
			return Bmi1.GetMaskUpToLowestSetBit(value);
		}

		// Token: 0x06006BE8 RID: 27624 RVA: 0x001095CE File Offset: 0x001077CE
		public static uint ResetLowestSetBit(uint value)
		{
			return Bmi1.ResetLowestSetBit(value);
		}

		// Token: 0x06006BE9 RID: 27625 RVA: 0x001095D6 File Offset: 0x001077D6
		public static uint TrailingZeroCount(uint value)
		{
			return Bmi1.TrailingZeroCount(value);
		}

		// Token: 0x02000585 RID: 1413
		[Intrinsic]
		public new abstract class X64 : X86Base.X64
		{
			// Token: 0x17000D92 RID: 3474
			// (get) Token: 0x06006BEA RID: 27626 RVA: 0x001095DE File Offset: 0x001077DE
			public new static bool IsSupported
			{
				get
				{
					return Bmi1.X64.IsSupported;
				}
			}

			// Token: 0x06006BEB RID: 27627 RVA: 0x001095E5 File Offset: 0x001077E5
			public static ulong AndNot(ulong left, ulong right)
			{
				return Bmi1.X64.AndNot(left, right);
			}

			// Token: 0x06006BEC RID: 27628 RVA: 0x001095EE File Offset: 0x001077EE
			public static ulong BitFieldExtract(ulong value, byte start, byte length)
			{
				return Bmi1.X64.BitFieldExtract(value, (ushort)((int)start | (int)length << 8));
			}

			// Token: 0x06006BED RID: 27629 RVA: 0x001095FC File Offset: 0x001077FC
			public static ulong BitFieldExtract(ulong value, ushort control)
			{
				return Bmi1.X64.BitFieldExtract(value, control);
			}

			// Token: 0x06006BEE RID: 27630 RVA: 0x00109605 File Offset: 0x00107805
			public static ulong ExtractLowestSetBit(ulong value)
			{
				return Bmi1.X64.ExtractLowestSetBit(value);
			}

			// Token: 0x06006BEF RID: 27631 RVA: 0x0010960D File Offset: 0x0010780D
			public static ulong GetMaskUpToLowestSetBit(ulong value)
			{
				return Bmi1.X64.GetMaskUpToLowestSetBit(value);
			}

			// Token: 0x06006BF0 RID: 27632 RVA: 0x00109615 File Offset: 0x00107815
			public static ulong ResetLowestSetBit(ulong value)
			{
				return Bmi1.X64.ResetLowestSetBit(value);
			}

			// Token: 0x06006BF1 RID: 27633 RVA: 0x0010961D File Offset: 0x0010781D
			public static ulong TrailingZeroCount(ulong value)
			{
				return Bmi1.X64.TrailingZeroCount(value);
			}
		}
	}
}
