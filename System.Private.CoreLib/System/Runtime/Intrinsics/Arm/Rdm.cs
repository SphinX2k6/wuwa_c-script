using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x0200055D RID: 1373
	[CLSCompliant(false)]
	public abstract class Rdm : AdvSimd
	{
		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06005CE1 RID: 23777 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingAndAddSaturateHigh(Vector128<short> addend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingAndAddSaturateHigh(Vector128<int> addend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector64<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CE7 RID: 23783 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector64<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CE8 RID: 23784 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingAndSubtractSaturateHigh(Vector128<short> minuend, Vector128<short> left, Vector128<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CE9 RID: 23785 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingAndSubtractSaturateHigh(Vector128<int> minuend, Vector128<int> left, Vector128<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CEA RID: 23786 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CEB RID: 23787 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CEC RID: 23788 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CED RID: 23789 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CEE RID: 23790 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector128<short> addend, Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CEF RID: 23791 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector128<short> addend, Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector128<int> addend, Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarAndAddSaturateHigh(Vector128<int> addend, Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF3 RID: 23795 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<short> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF4 RID: 23796 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF5 RID: 23797 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector64<int> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector128<short> minuend, Vector128<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector128<short> minuend, Vector128<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector128<int> minuend, Vector128<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> MultiplyRoundedDoublingBySelectedScalarAndSubtractSaturateHigh(Vector128<int> minuend, Vector128<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0200055E RID: 1374
		public new abstract class Arm64 : AdvSimd.Arm64
		{
			// Token: 0x17000D6D RID: 3437
			// (get) Token: 0x06005CFA RID: 23802 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06005CFB RID: 23803 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingAndAddSaturateHighScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CFC RID: 23804 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingAndAddSaturateHighScalar(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CFD RID: 23805 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingAndSubtractSaturateHighScalar(Vector64<short> addend, Vector64<short> left, Vector64<short> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CFE RID: 23806 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingAndSubtractSaturateHighScalar(Vector64<int> addend, Vector64<int> left, Vector64<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005CFF RID: 23807 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005D00 RID: 23808 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarAndAddSaturateHigh(Vector64<short> addend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005D01 RID: 23809 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005D02 RID: 23810 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarAndAddSaturateHigh(Vector64<int> addend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005D03 RID: 23811 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector64<short> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005D04 RID: 23812 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<short> MultiplyRoundedDoublingScalarBySelectedScalarAndSubtractSaturateHigh(Vector64<short> minuend, Vector64<short> left, Vector128<short> right, [ConstantExpected(Max = 7)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005D05 RID: 23813 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector64<int> right, [ConstantExpected(Max = 1)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06005D06 RID: 23814 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector64<int> MultiplyRoundedDoublingScalarBySelectedScalarAndSubtractSaturateHigh(Vector64<int> minuend, Vector64<int> left, Vector128<int> right, [ConstantExpected(Max = 3)] byte rightIndex)
			{
				throw new PlatformNotSupportedException();
			}
		}
	}
}
