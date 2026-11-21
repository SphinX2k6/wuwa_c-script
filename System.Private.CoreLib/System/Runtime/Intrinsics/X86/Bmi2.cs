using System;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000586 RID: 1414
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Bmi2 : X86Base
	{
		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06006BF2 RID: 27634 RVA: 0x00109625 File Offset: 0x00107825
		public new static bool IsSupported
		{
			get
			{
				return Bmi2.IsSupported;
			}
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x0010962C File Offset: 0x0010782C
		public static uint ZeroHighBits(uint value, uint index)
		{
			return Bmi2.ZeroHighBits(value, index);
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x00109635 File Offset: 0x00107835
		public static uint MultiplyNoFlags(uint left, uint right)
		{
			return Bmi2.MultiplyNoFlags(left, right);
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x0010963E File Offset: 0x0010783E
		public unsafe static uint MultiplyNoFlags(uint left, uint right, uint* low)
		{
			return Bmi2.MultiplyNoFlags(left, right, low);
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x00109648 File Offset: 0x00107848
		public static uint ParallelBitDeposit(uint value, uint mask)
		{
			return Bmi2.ParallelBitDeposit(value, mask);
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x00109651 File Offset: 0x00107851
		public static uint ParallelBitExtract(uint value, uint mask)
		{
			return Bmi2.ParallelBitExtract(value, mask);
		}

		// Token: 0x02000587 RID: 1415
		[Intrinsic]
		public new abstract class X64 : X86Base.X64
		{
			// Token: 0x17000D94 RID: 3476
			// (get) Token: 0x06006BF8 RID: 27640 RVA: 0x0010965A File Offset: 0x0010785A
			public new static bool IsSupported
			{
				get
				{
					return Bmi2.X64.IsSupported;
				}
			}

			// Token: 0x06006BF9 RID: 27641 RVA: 0x00109661 File Offset: 0x00107861
			public static ulong ZeroHighBits(ulong value, ulong index)
			{
				return Bmi2.X64.ZeroHighBits(value, index);
			}

			// Token: 0x06006BFA RID: 27642 RVA: 0x0010966A File Offset: 0x0010786A
			public static ulong MultiplyNoFlags(ulong left, ulong right)
			{
				return Bmi2.X64.MultiplyNoFlags(left, right);
			}

			// Token: 0x06006BFB RID: 27643 RVA: 0x00109673 File Offset: 0x00107873
			public unsafe static ulong MultiplyNoFlags(ulong left, ulong right, ulong* low)
			{
				return Bmi2.X64.MultiplyNoFlags(left, right, low);
			}

			// Token: 0x06006BFC RID: 27644 RVA: 0x0010967D File Offset: 0x0010787D
			public static ulong ParallelBitDeposit(ulong value, ulong mask)
			{
				return Bmi2.X64.ParallelBitDeposit(value, mask);
			}

			// Token: 0x06006BFD RID: 27645 RVA: 0x00109686 File Offset: 0x00107886
			public static ulong ParallelBitExtract(ulong value, ulong mask)
			{
				return Bmi2.X64.ParallelBitExtract(value, mask);
			}
		}
	}
}
