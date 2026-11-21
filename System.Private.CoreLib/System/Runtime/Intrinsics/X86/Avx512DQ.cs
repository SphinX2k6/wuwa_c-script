using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000579 RID: 1401
	[CLSCompliant(false)]
	public abstract class Avx512DQ : Avx512F
	{
		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x0600685C RID: 26716 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> And(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> And(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> AndNot(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> AndNot(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> BroadcastPairScalarToVector512(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> BroadcastPairScalarToVector512(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> BroadcastPairScalarToVector512(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<long> BroadcastVector128ToVector512(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<ulong> BroadcastVector128ToVector512(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<double> BroadcastVector128ToVector512(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<int> BroadcastVector256ToVector512(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<uint> BroadcastVector256ToVector512(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<float> BroadcastVector256ToVector512(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ConvertToVector256Single(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ConvertToVector256Single(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ConvertToVector256Single(Vector512<long> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ConvertToVector256Single(Vector512<ulong> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> ConvertToVector512Double(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> ConvertToVector512Double(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> ConvertToVector512Double(Vector512<long> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> ConvertToVector512Double(Vector512<ulong> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector256<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector512<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64WithTruncation(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64WithTruncation(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector256<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector512<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64WithTruncation(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64WithTruncation(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<long> ExtractVector128(Vector512<long> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600687F RID: 26751 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<ulong> ExtractVector128(Vector512<ulong> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006880 RID: 26752 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector128<double> ExtractVector128(Vector512<double> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006881 RID: 26753 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<int> ExtractVector256(Vector512<int> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006882 RID: 26754 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<uint> ExtractVector256(Vector512<uint> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006883 RID: 26755 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector256<float> ExtractVector256(Vector512<float> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006884 RID: 26756 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector512<long> InsertVector128(Vector512<long> value, Vector128<long> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006885 RID: 26757 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector512<ulong> InsertVector128(Vector512<ulong> value, Vector128<ulong> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006886 RID: 26758 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector512<double> InsertVector128(Vector512<double> value, Vector128<double> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006887 RID: 26759 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector512<int> InsertVector256(Vector512<int> value, Vector256<int> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006888 RID: 26760 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector512<uint> InsertVector256(Vector512<uint> value, Vector256<uint> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006889 RID: 26761 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public new static Vector512<float> InsertVector256(Vector512<float> value, Vector256<float> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600688A RID: 26762 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> MultiplyLow(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600688B RID: 26763 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> MultiplyLow(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600688C RID: 26764 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Or(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600688D RID: 26765 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Or(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600688E RID: 26766 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Range(Vector512<float> left, Vector512<float> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600688F RID: 26767 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Range(Vector512<double> left, Vector512<double> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006890 RID: 26768 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RangeScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006891 RID: 26769 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> RangeScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006892 RID: 26770 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Reduce(Vector512<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006893 RID: 26771 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Reduce(Vector512<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006894 RID: 26772 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReduceScalar(Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006895 RID: 26773 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReduceScalar(Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006896 RID: 26774 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReduceScalar(Vector128<float> upper, Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006897 RID: 26775 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReduceScalar(Vector128<double> upper, Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006898 RID: 26776 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Xor(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006899 RID: 26777 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Xor(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0200057A RID: 1402
		public new abstract class VL : Avx512F.VL
		{
			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x0600689A RID: 26778 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x0600689B RID: 26779 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> BroadcastPairScalarToVector128(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600689C RID: 26780 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> BroadcastPairScalarToVector128(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600689D RID: 26781 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> BroadcastPairScalarToVector256(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600689E RID: 26782 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> BroadcastPairScalarToVector256(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0600689F RID: 26783 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> BroadcastPairScalarToVector256(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A0 RID: 26784 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertToVector128Double(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A1 RID: 26785 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertToVector128Double(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A2 RID: 26786 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToVector128Int64(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A3 RID: 26787 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToVector128Int64(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A4 RID: 26788 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToVector128Int64WithTruncation(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A5 RID: 26789 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ConvertToVector128Int64WithTruncation(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A6 RID: 26790 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertToVector128Single(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A7 RID: 26791 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertToVector128Single(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A8 RID: 26792 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertToVector128Single(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068A9 RID: 26793 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertToVector128Single(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068AA RID: 26794 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToVector128UInt64(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068AB RID: 26795 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToVector128UInt64(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068AC RID: 26796 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToVector128UInt64WithTruncation(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068AD RID: 26797 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> ConvertToVector128UInt64WithTruncation(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068AE RID: 26798 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> ConvertToVector256Double(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068AF RID: 26799 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> ConvertToVector256Double(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B0 RID: 26800 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> ConvertToVector256Int64(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B1 RID: 26801 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> ConvertToVector256Int64(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B2 RID: 26802 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> ConvertToVector256Int64WithTruncation(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B3 RID: 26803 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> ConvertToVector256Int64WithTruncation(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B4 RID: 26804 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> ConvertToVector256UInt64(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B5 RID: 26805 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> ConvertToVector256UInt64(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B6 RID: 26806 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> ConvertToVector256UInt64WithTruncation(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B7 RID: 26807 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> ConvertToVector256UInt64WithTruncation(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B8 RID: 26808 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> MultiplyLow(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068B9 RID: 26809 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> MultiplyLow(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068BA RID: 26810 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> MultiplyLow(Vector256<long> left, Vector256<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068BB RID: 26811 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> MultiplyLow(Vector256<ulong> left, Vector256<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068BC RID: 26812 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> Range(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068BD RID: 26813 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Range(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068BE RID: 26814 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> Range(Vector256<float> left, Vector256<float> right, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068BF RID: 26815 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> Range(Vector256<double> left, Vector256<double> right, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068C0 RID: 26816 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> Reduce(Vector128<float> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068C1 RID: 26817 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Reduce(Vector128<double> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068C2 RID: 26818 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> Reduce(Vector256<float> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x060068C3 RID: 26819 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> Reduce(Vector256<double> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}
		}

		// Token: 0x0200057B RID: 1403
		public new abstract class X64 : Avx512F.X64
		{
			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x060068C4 RID: 26820 RVA: 0x00007B65 File Offset: 0x00005D65
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
