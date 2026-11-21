using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x0200057C RID: 1404
	[CLSCompliant(false)]
	public abstract class Avx512F : Avx2
	{
		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x060068C5 RID: 26821 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Abs(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Abs(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> Add(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Add(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Add(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Add(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Add(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Add(Vector512<double> left, Vector512<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Add(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068CF RID: 26831 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Add(Vector512<float> left, Vector512<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D0 RID: 26832 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> AddScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> AddScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> AlignRight32(Vector512<int> left, Vector512<int> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D3 RID: 26835 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> AlignRight32(Vector512<uint> left, Vector512<uint> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D4 RID: 26836 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> AlignRight64(Vector512<long> left, Vector512<long> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> AlignRight64(Vector512<ulong> left, Vector512<ulong> right, [ConstantExpected] byte mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> And(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> And(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> And(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> And(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> And(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068DB RID: 26843 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> And(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068DC RID: 26844 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> And(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068DD RID: 26845 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> And(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068DE RID: 26846 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> AndNot(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068DF RID: 26847 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> AndNot(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E0 RID: 26848 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> AndNot(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E1 RID: 26849 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> AndNot(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E2 RID: 26850 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> AndNot(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E3 RID: 26851 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> AndNot(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E4 RID: 26852 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> AndNot(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E5 RID: 26853 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> AndNot(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E6 RID: 26854 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> BlendVariable(Vector512<double> left, Vector512<double> right, Vector512<double> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E7 RID: 26855 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> BlendVariable(Vector512<int> left, Vector512<int> right, Vector512<int> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E8 RID: 26856 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> BlendVariable(Vector512<long> left, Vector512<long> right, Vector512<long> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068E9 RID: 26857 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> BlendVariable(Vector512<float> left, Vector512<float> right, Vector512<float> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068EA RID: 26858 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> BlendVariable(Vector512<uint> left, Vector512<uint> right, Vector512<uint> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068EB RID: 26859 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> BlendVariable(Vector512<ulong> left, Vector512<ulong> right, Vector512<ulong> mask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068EC RID: 26860 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> BroadcastScalarToVector512(Vector128<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068ED RID: 26861 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> BroadcastScalarToVector512(Vector128<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068EE RID: 26862 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> BroadcastScalarToVector512(Vector128<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068EF RID: 26863 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> BroadcastScalarToVector512(Vector128<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F0 RID: 26864 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> BroadcastScalarToVector512(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F1 RID: 26865 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> BroadcastScalarToVector512(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F2 RID: 26866 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<int> BroadcastVector128ToVector512(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F3 RID: 26867 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<uint> BroadcastVector128ToVector512(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F4 RID: 26868 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<float> BroadcastVector128ToVector512(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F5 RID: 26869 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<long> BroadcastVector256ToVector512(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F6 RID: 26870 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<ulong> BroadcastVector256ToVector512(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F7 RID: 26871 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<double> BroadcastVector256ToVector512(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F8 RID: 26872 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Compare(Vector512<double> left, Vector512<double> right, [ConstantExpected(Max = FloatComparisonMode.UnorderedTrueSignaling)] FloatComparisonMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068F9 RID: 26873 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareEqual(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068FA RID: 26874 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareGreaterThan(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068FB RID: 26875 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareGreaterThanOrEqual(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068FC RID: 26876 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareLessThan(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068FD RID: 26877 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareLessThanOrEqual(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068FE RID: 26878 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareNotEqual(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060068FF RID: 26879 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareNotGreaterThan(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006900 RID: 26880 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareNotGreaterThanOrEqual(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006901 RID: 26881 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareNotLessThan(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006902 RID: 26882 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareNotLessThanOrEqual(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareOrdered(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006904 RID: 26884 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> CompareUnordered(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006905 RID: 26885 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Compare(Vector512<float> left, Vector512<float> right, [ConstantExpected(Max = FloatComparisonMode.UnorderedTrueSignaling)] FloatComparisonMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006906 RID: 26886 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareEqual(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006907 RID: 26887 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareGreaterThan(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006908 RID: 26888 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareGreaterThanOrEqual(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006909 RID: 26889 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareLessThan(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600690A RID: 26890 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareLessThanOrEqual(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600690B RID: 26891 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareNotEqual(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareNotGreaterThan(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareNotGreaterThanOrEqual(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareNotLessThan(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareNotLessThanOrEqual(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareOrdered(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> CompareUnordered(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> CompareEqual(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006913 RID: 26899 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> CompareGreaterThan(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> CompareGreaterThanOrEqual(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> CompareLessThan(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> CompareLessThanOrEqual(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> CompareNotEqual(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006918 RID: 26904 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> CompareEqual(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006919 RID: 26905 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> CompareGreaterThan(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600691A RID: 26906 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> CompareGreaterThanOrEqual(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600691B RID: 26907 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> CompareLessThan(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> CompareLessThanOrEqual(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> CompareNotEqual(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> CompareEqual(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> CompareGreaterThan(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> CompareGreaterThanOrEqual(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> CompareLessThan(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> CompareLessThanOrEqual(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> CompareNotEqual(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006924 RID: 26916 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> CompareEqual(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006925 RID: 26917 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> CompareGreaterThan(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006926 RID: 26918 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> CompareGreaterThanOrEqual(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006927 RID: 26919 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> CompareLessThan(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006928 RID: 26920 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> CompareLessThanOrEqual(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006929 RID: 26921 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> CompareNotEqual(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600692A RID: 26922 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600692B RID: 26923 RVA: 0x0010958D File Offset: 0x0010778D
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, uint value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			return Avx512F.ConvertScalarToVector128Single(upper, value, mode);
		}

		// Token: 0x0600692C RID: 26924 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, int value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600692D RID: 26925 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600692E RID: 26926 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, uint value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600692F RID: 26927 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ConvertToInt32(Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006930 RID: 26928 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ConvertToInt32(Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006931 RID: 26929 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006934 RID: 26932 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32(Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32WithTruncation(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConvertToUInt32WithTruncation(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006939 RID: 26937 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600693A RID: 26938 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128Byte(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600693B RID: 26939 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600693C RID: 26940 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600693D RID: 26941 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600693E RID: 26942 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600693F RID: 26943 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006940 RID: 26944 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006941 RID: 26945 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006942 RID: 26946 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006943 RID: 26947 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByte(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006944 RID: 26948 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006945 RID: 26949 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006946 RID: 26950 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006947 RID: 26951 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006949 RID: 26953 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ConvertToVector256Int16(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ConvertToVector256Int16(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ConvertToVector256Int16WithSaturation(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector512<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600694F RID: 26959 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006950 RID: 26960 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32WithSaturation(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006951 RID: 26961 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ConvertToVector256Int32WithTruncation(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006952 RID: 26962 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ConvertToVector256Single(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006953 RID: 26963 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ConvertToVector256Single(Vector512<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ConvertToVector256UInt16(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ConvertToVector256UInt16(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ConvertToVector256UInt16WithSaturation(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006957 RID: 26967 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ConvertToVector256UInt32(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006958 RID: 26968 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ConvertToVector256UInt32(Vector512<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ConvertToVector256UInt32(Vector512<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ConvertToVector256UInt32(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ConvertToVector256UInt32WithSaturation(Vector512<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ConvertToVector256UInt32WithTruncation(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> ConvertToVector512Double(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> ConvertToVector512Double(Vector256<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> ConvertToVector512Double(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ConvertToVector512Int32(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> ConvertToVector512Single(Vector512<int> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> ConvertToVector512Single(Vector512<uint> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ConvertToVector512Int32(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ConvertToVector512Int32(Vector256<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ConvertToVector512Int32(Vector256<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ConvertToVector512Int32(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ConvertToVector512Int32(Vector512<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ConvertToVector512Int32WithTruncation(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600696D RID: 26989 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ConvertToVector512Int64(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> ConvertToVector512Single(Vector512<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> ConvertToVector512Single(Vector512<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ConvertToVector512UInt32(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ConvertToVector512UInt32(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006973 RID: 26995 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ConvertToVector512UInt32(Vector256<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ConvertToVector512UInt32(Vector256<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006975 RID: 26997 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ConvertToVector512UInt32(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006976 RID: 26998 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ConvertToVector512UInt32(Vector512<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006977 RID: 26999 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ConvertToVector512UInt32WithTruncation(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006978 RID: 27000 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector128<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006979 RID: 27001 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector128<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600697A RID: 27002 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector128<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600697B RID: 27003 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector128<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector256<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ConvertToVector512UInt64(Vector256<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Divide(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Divide(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Divide(Vector512<float> left, Vector512<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Divide(Vector512<double> left, Vector512<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> DivideScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> DivideScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> DuplicateEvenIndexed(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006985 RID: 27013 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> DuplicateEvenIndexed(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006986 RID: 27014 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> DuplicateOddIndexed(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006987 RID: 27015 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<sbyte> ExtractVector128(Vector512<sbyte> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006988 RID: 27016 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<byte> ExtractVector128(Vector512<byte> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006989 RID: 27017 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<short> ExtractVector128(Vector512<short> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600698A RID: 27018 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ushort> ExtractVector128(Vector512<ushort> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600698B RID: 27019 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<int> ExtractVector128(Vector512<int> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600698C RID: 27020 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<uint> ExtractVector128(Vector512<uint> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600698D RID: 27021 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<long> ExtractVector128(Vector512<long> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600698E RID: 27022 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<ulong> ExtractVector128(Vector512<ulong> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600698F RID: 27023 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ExtractVector128(Vector512<float> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006990 RID: 27024 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ExtractVector128(Vector512<double> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006991 RID: 27025 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<sbyte> ExtractVector256(Vector512<sbyte> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006992 RID: 27026 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<byte> ExtractVector256(Vector512<byte> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006993 RID: 27027 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<short> ExtractVector256(Vector512<short> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006994 RID: 27028 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ushort> ExtractVector256(Vector512<ushort> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006995 RID: 27029 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<int> ExtractVector256(Vector512<int> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006996 RID: 27030 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<uint> ExtractVector256(Vector512<uint> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006997 RID: 27031 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<long> ExtractVector256(Vector512<long> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<ulong> ExtractVector256(Vector512<ulong> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006999 RID: 27033 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<float> ExtractVector256(Vector512<float> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600699A RID: 27034 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector256<double> ExtractVector256(Vector512<double> value, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600699B RID: 27035 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Fixup(Vector512<float> left, Vector512<float> right, Vector512<int> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600699C RID: 27036 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Fixup(Vector512<double> left, Vector512<double> right, Vector512<long> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600699D RID: 27037 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FixupScalar(Vector128<float> left, Vector128<float> right, Vector128<int> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600699E RID: 27038 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FixupScalar(Vector128<double> left, Vector128<double> right, Vector128<long> table, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600699F RID: 27039 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplyAdd(Vector512<float> a, Vector512<float> b, Vector512<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A0 RID: 27040 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplyAdd(Vector512<float> a, Vector512<float> b, Vector512<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A1 RID: 27041 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplyAdd(Vector512<double> a, Vector512<double> b, Vector512<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A2 RID: 27042 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplyAdd(Vector512<double> a, Vector512<double> b, Vector512<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A3 RID: 27043 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplyAddScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A4 RID: 27044 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FusedMultiplyAddScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A5 RID: 27045 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplyAddSubtract(Vector512<float> a, Vector512<float> b, Vector512<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A6 RID: 27046 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplyAddSubtract(Vector512<float> a, Vector512<float> b, Vector512<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A7 RID: 27047 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplyAddSubtract(Vector512<double> a, Vector512<double> b, Vector512<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A8 RID: 27048 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplyAddSubtract(Vector512<double> a, Vector512<double> b, Vector512<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069A9 RID: 27049 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplySubtract(Vector512<float> a, Vector512<float> b, Vector512<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069AA RID: 27050 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplySubtract(Vector512<float> a, Vector512<float> b, Vector512<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069AB RID: 27051 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplySubtract(Vector512<double> a, Vector512<double> b, Vector512<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069AC RID: 27052 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplySubtract(Vector512<double> a, Vector512<double> b, Vector512<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069AD RID: 27053 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplySubtractScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069AE RID: 27054 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FusedMultiplySubtractScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069AF RID: 27055 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplySubtractAdd(Vector512<float> a, Vector512<float> b, Vector512<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B0 RID: 27056 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplySubtractAdd(Vector512<float> a, Vector512<float> b, Vector512<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B1 RID: 27057 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplySubtractAdd(Vector512<double> a, Vector512<double> b, Vector512<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B2 RID: 27058 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplySubtractAdd(Vector512<double> a, Vector512<double> b, Vector512<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplyAddNegated(Vector512<float> a, Vector512<float> b, Vector512<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B4 RID: 27060 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplyAddNegated(Vector512<float> a, Vector512<float> b, Vector512<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B5 RID: 27061 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplyAddNegated(Vector512<double> a, Vector512<double> b, Vector512<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B6 RID: 27062 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplyAddNegated(Vector512<double> a, Vector512<double> b, Vector512<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B7 RID: 27063 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplyAddNegatedScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B8 RID: 27064 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FusedMultiplyAddNegatedScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069B9 RID: 27065 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplySubtractNegated(Vector512<float> a, Vector512<float> b, Vector512<float> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069BA RID: 27066 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> FusedMultiplySubtractNegated(Vector512<float> a, Vector512<float> b, Vector512<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069BB RID: 27067 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplySubtractNegated(Vector512<double> a, Vector512<double> b, Vector512<double> c)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069BC RID: 27068 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> FusedMultiplySubtractNegated(Vector512<double> a, Vector512<double> b, Vector512<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069BD RID: 27069 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> FusedMultiplySubtractNegatedScalar(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069BE RID: 27070 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> FusedMultiplySubtractNegatedScalar(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069BF RID: 27071 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> GetExponent(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C0 RID: 27072 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> GetExponent(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C1 RID: 27073 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetExponentScalar(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C2 RID: 27074 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetExponentScalar(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C3 RID: 27075 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetExponentScalar(Vector128<float> upper, Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C4 RID: 27076 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetExponentScalar(Vector128<double> upper, Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C5 RID: 27077 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> GetMantissa(Vector512<float> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C6 RID: 27078 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> GetMantissa(Vector512<double> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C7 RID: 27079 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetMantissaScalar(Vector128<float> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C8 RID: 27080 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetMantissaScalar(Vector128<double> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> GetMantissaScalar(Vector128<float> upper, Vector128<float> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069CA RID: 27082 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> GetMantissaScalar(Vector128<double> upper, Vector128<double> value, [ConstantExpected(Max = 15)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> InsertVector128(Vector512<sbyte> value, Vector128<sbyte> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> InsertVector128(Vector512<byte> value, Vector128<byte> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069CD RID: 27085 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> InsertVector128(Vector512<short> value, Vector128<short> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069CE RID: 27086 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> InsertVector128(Vector512<ushort> value, Vector128<ushort> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> InsertVector128(Vector512<int> value, Vector128<int> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> InsertVector128(Vector512<uint> value, Vector128<uint> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> InsertVector128(Vector512<long> value, Vector128<long> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D2 RID: 27090 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> InsertVector128(Vector512<ulong> value, Vector128<ulong> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D3 RID: 27091 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> InsertVector128(Vector512<float> value, Vector128<float> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D4 RID: 27092 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> InsertVector128(Vector512<double> value, Vector128<double> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D5 RID: 27093 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> InsertVector256(Vector512<sbyte> value, Vector256<sbyte> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D6 RID: 27094 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> InsertVector256(Vector512<byte> value, Vector256<byte> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> InsertVector256(Vector512<short> value, Vector256<short> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D8 RID: 27096 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> InsertVector256(Vector512<ushort> value, Vector256<ushort> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069D9 RID: 27097 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> InsertVector256(Vector512<int> value, Vector256<int> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069DA RID: 27098 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> InsertVector256(Vector512<uint> value, Vector256<uint> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069DB RID: 27099 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> InsertVector256(Vector512<long> value, Vector256<long> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> InsertVector256(Vector512<ulong> value, Vector256<ulong> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> InsertVector256(Vector512<float> value, Vector256<float> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> InsertVector256(Vector512<double> value, Vector256<double> data, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<byte> LoadAlignedVector512(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<sbyte> LoadAlignedVector512(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<short> LoadAlignedVector512(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<ushort> LoadAlignedVector512(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<int> LoadAlignedVector512(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<uint> LoadAlignedVector512(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<long> LoadAlignedVector512(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<ulong> LoadAlignedVector512(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<float> LoadAlignedVector512(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<double> LoadAlignedVector512(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<sbyte> LoadAlignedVector512NonTemporal(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<byte> LoadAlignedVector512NonTemporal(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<short> LoadAlignedVector512NonTemporal(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<ushort> LoadAlignedVector512NonTemporal(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<int> LoadAlignedVector512NonTemporal(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069EE RID: 27118 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<uint> LoadAlignedVector512NonTemporal(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<long> LoadAlignedVector512NonTemporal(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<ulong> LoadAlignedVector512NonTemporal(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<sbyte> LoadVector512(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<byte> LoadVector512(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<short> LoadVector512(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<ushort> LoadVector512(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<int> LoadVector512(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<uint> LoadVector512(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<long> LoadVector512(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<ulong> LoadVector512(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<float> LoadVector512(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector512<double> LoadVector512(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> Max(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Max(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Max(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Max(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Max(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Max(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> Min(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Min(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Min(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Min(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Min(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Min(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Multiply(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Multiply(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Multiply(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Multiply(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Multiply(Vector512<float> left, Vector512<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Multiply(Vector512<double> left, Vector512<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> MultiplyScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> MultiplyScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> MultiplyLow(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> MultiplyLow(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Or(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> Or(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> Or(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> Or(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> Or(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Or(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Or(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Or(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Permute2x64(Vector512<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Permute4x32(Vector512<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Permute4x64(Vector512<long> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Permute4x64(Vector512<ulong> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Permute4x64(Vector512<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A1E RID: 27166 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> PermuteVar2x64(Vector512<double> left, Vector512<long> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> PermuteVar4x32(Vector512<float> left, Vector512<int> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> PermuteVar8x64(Vector512<long> value, Vector512<long> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> PermuteVar8x64(Vector512<ulong> value, Vector512<ulong> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> PermuteVar8x64(Vector512<double> value, Vector512<long> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> PermuteVar8x64x2(Vector512<long> lower, Vector512<long> indices, Vector512<long> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> PermuteVar8x64x2(Vector512<ulong> lower, Vector512<ulong> indices, Vector512<ulong> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A25 RID: 27173 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> PermuteVar8x64x2(Vector512<double> lower, Vector512<long> indices, Vector512<double> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A26 RID: 27174 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> PermuteVar16x32(Vector512<int> left, Vector512<int> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A27 RID: 27175 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> PermuteVar16x32(Vector512<uint> left, Vector512<uint> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A28 RID: 27176 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> PermuteVar16x32(Vector512<float> left, Vector512<int> control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A29 RID: 27177 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> PermuteVar16x32x2(Vector512<int> lower, Vector512<int> indices, Vector512<int> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A2A RID: 27178 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> PermuteVar16x32x2(Vector512<uint> lower, Vector512<uint> indices, Vector512<uint> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A2B RID: 27179 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> PermuteVar16x32x2(Vector512<float> lower, Vector512<int> indices, Vector512<float> upper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A2C RID: 27180 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Reciprocal14(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A2D RID: 27181 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Reciprocal14(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A2E RID: 27182 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Reciprocal14Scalar(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A2F RID: 27183 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Reciprocal14Scalar(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A30 RID: 27184 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> Reciprocal14Scalar(Vector128<float> upper, Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> Reciprocal14Scalar(Vector128<double> upper, Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A32 RID: 27186 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> ReciprocalSqrt14(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A33 RID: 27187 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> ReciprocalSqrt14(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A34 RID: 27188 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalSqrt14Scalar(Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReciprocalSqrt14Scalar(Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A36 RID: 27190 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ReciprocalSqrt14Scalar(Vector128<float> upper, Vector128<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ReciprocalSqrt14Scalar(Vector128<double> upper, Vector128<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A38 RID: 27192 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> RotateLeft(Vector512<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A39 RID: 27193 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> RotateLeft(Vector512<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A3A RID: 27194 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> RotateLeft(Vector512<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A3B RID: 27195 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> RotateLeft(Vector512<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A3C RID: 27196 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> RotateLeftVariable(Vector512<int> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A3D RID: 27197 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> RotateLeftVariable(Vector512<uint> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A3E RID: 27198 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> RotateLeftVariable(Vector512<long> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A3F RID: 27199 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> RotateLeftVariable(Vector512<ulong> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A40 RID: 27200 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> RotateRight(Vector512<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A41 RID: 27201 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> RotateRight(Vector512<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A42 RID: 27202 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> RotateRight(Vector512<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A43 RID: 27203 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> RotateRight(Vector512<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A44 RID: 27204 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> RotateRightVariable(Vector512<int> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A45 RID: 27205 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> RotateRightVariable(Vector512<uint> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> RotateRightVariable(Vector512<long> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> RotateRightVariable(Vector512<ulong> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> RoundScale(Vector512<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> RoundScale(Vector512<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A4A RID: 27210 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundScaleScalar(Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> RoundScaleScalar(Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> RoundScaleScalar(Vector128<float> upper, Vector128<float> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> RoundScaleScalar(Vector128<double> upper, Vector128<double> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Scale(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Scale(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Scale(Vector512<float> left, Vector512<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Scale(Vector512<double> left, Vector512<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ScaleScalar(Vector128<float> left, Vector128<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ScaleScalar(Vector128<double> left, Vector128<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A54 RID: 27220 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> ScaleScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A55 RID: 27221 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> ScaleScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A56 RID: 27222 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftLeftLogical(Vector512<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A57 RID: 27223 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ShiftLeftLogical(Vector512<uint> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A58 RID: 27224 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftLeftLogical(Vector512<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A59 RID: 27225 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ShiftLeftLogical(Vector512<ulong> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A5A RID: 27226 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftLeftLogical(Vector512<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A5B RID: 27227 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ShiftLeftLogical(Vector512<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A5C RID: 27228 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftLeftLogical(Vector512<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ShiftLeftLogical(Vector512<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftLeftLogicalVariable(Vector512<int> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ShiftLeftLogicalVariable(Vector512<uint> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftLeftLogicalVariable(Vector512<long> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ShiftLeftLogicalVariable(Vector512<ulong> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftRightArithmetic(Vector512<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftRightArithmetic(Vector512<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftRightArithmetic(Vector512<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftRightArithmetic(Vector512<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftRightArithmeticVariable(Vector512<int> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftRightArithmeticVariable(Vector512<long> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftRightLogical(Vector512<int> value, Vector128<int> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ShiftRightLogical(Vector512<uint> value, Vector128<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftRightLogical(Vector512<long> value, Vector128<long> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ShiftRightLogical(Vector512<ulong> value, Vector128<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftRightLogical(Vector512<int> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ShiftRightLogical(Vector512<uint> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftRightLogical(Vector512<long> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ShiftRightLogical(Vector512<ulong> value, [ConstantExpected] byte count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> ShiftRightLogicalVariable(Vector512<int> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> ShiftRightLogicalVariable(Vector512<uint> value, Vector512<uint> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> ShiftRightLogicalVariable(Vector512<long> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> ShiftRightLogicalVariable(Vector512<ulong> value, Vector512<ulong> count)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> Shuffle(Vector512<int> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Shuffle(Vector512<uint> value, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Shuffle(Vector512<float> value, Vector512<float> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Shuffle(Vector512<double> value, Vector512<double> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Shuffle4x128(Vector512<double> left, Vector512<double> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> Shuffle4x128(Vector512<int> left, Vector512<int> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Shuffle4x128(Vector512<long> left, Vector512<long> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Shuffle4x128(Vector512<float> left, Vector512<float> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Shuffle4x128(Vector512<uint> left, Vector512<uint> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Shuffle4x128(Vector512<ulong> left, Vector512<ulong> right, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Sqrt(Vector512<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Sqrt(Vector512<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A80 RID: 27264 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Sqrt(Vector512<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A81 RID: 27265 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Sqrt(Vector512<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> SqrtScalar(Vector128<float> upper, Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> SqrtScalar(Vector128<double> upper, Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(sbyte* address, Vector512<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A85 RID: 27269 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(byte* address, Vector512<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A86 RID: 27270 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(short* address, Vector512<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A87 RID: 27271 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ushort* address, Vector512<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A88 RID: 27272 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(int* address, Vector512<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A89 RID: 27273 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(uint* address, Vector512<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A8A RID: 27274 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(long* address, Vector512<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A8B RID: 27275 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(ulong* address, Vector512<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(float* address, Vector512<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Store(double* address, Vector512<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(byte* address, Vector512<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(sbyte* address, Vector512<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(short* address, Vector512<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(ushort* address, Vector512<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(int* address, Vector512<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(uint* address, Vector512<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A94 RID: 27284 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(long* address, Vector512<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A95 RID: 27285 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(ulong* address, Vector512<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A96 RID: 27286 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(float* address, Vector512<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A97 RID: 27287 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAligned(double* address, Vector512<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A98 RID: 27288 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(sbyte* address, Vector512<sbyte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A99 RID: 27289 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(byte* address, Vector512<byte> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A9A RID: 27290 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(short* address, Vector512<short> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A9B RID: 27291 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(ushort* address, Vector512<ushort> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A9C RID: 27292 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(int* address, Vector512<int> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(uint* address, Vector512<uint> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A9E RID: 27294 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(long* address, Vector512<long> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006A9F RID: 27295 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(ulong* address, Vector512<ulong> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(float* address, Vector512<float> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAlignedNonTemporal(double* address, Vector512<double> source)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> Subtract(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Subtract(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Subtract(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA5 RID: 27301 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Subtract(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Subtract(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA7 RID: 27303 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Subtract(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA8 RID: 27304 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> Subtract(Vector512<float> left, Vector512<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> Subtract(Vector512<double> left, Vector512<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<float> SubtractScalar(Vector128<float> left, Vector128<float> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector128<double> SubtractScalar(Vector128<double> left, Vector128<double> right, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> TernaryLogic(Vector512<sbyte> a, Vector512<sbyte> b, Vector512<sbyte> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> TernaryLogic(Vector512<byte> a, Vector512<byte> b, Vector512<byte> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AAE RID: 27310 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> TernaryLogic(Vector512<short> a, Vector512<short> b, Vector512<short> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> TernaryLogic(Vector512<ushort> a, Vector512<ushort> b, Vector512<ushort> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> TernaryLogic(Vector512<int> a, Vector512<int> b, Vector512<int> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> TernaryLogic(Vector512<uint> a, Vector512<uint> b, Vector512<uint> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB2 RID: 27314 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> TernaryLogic(Vector512<long> a, Vector512<long> b, Vector512<long> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> TernaryLogic(Vector512<ulong> a, Vector512<ulong> b, Vector512<ulong> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> TernaryLogic(Vector512<float> a, Vector512<float> b, Vector512<float> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> TernaryLogic(Vector512<double> a, Vector512<double> b, Vector512<double> c, [ConstantExpected] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB6 RID: 27318 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> UnpackHigh(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> UnpackHigh(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> UnpackHigh(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AB9 RID: 27321 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> UnpackHigh(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006ABA RID: 27322 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> UnpackHigh(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> UnpackHigh(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> UnpackLow(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> UnpackLow(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> UnpackLow(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> UnpackLow(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC0 RID: 27328 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<float> UnpackLow(Vector512<float> left, Vector512<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<double> UnpackLow(Vector512<double> left, Vector512<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC2 RID: 27330 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<byte> Xor(Vector512<byte> left, Vector512<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC3 RID: 27331 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<sbyte> Xor(Vector512<sbyte> left, Vector512<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<short> Xor(Vector512<short> left, Vector512<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ushort> Xor(Vector512<ushort> left, Vector512<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<int> Xor(Vector512<int> left, Vector512<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<uint> Xor(Vector512<uint> left, Vector512<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<long> Xor(Vector512<long> left, Vector512<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006AC9 RID: 27337 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector512<ulong> Xor(Vector512<ulong> left, Vector512<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0200057D RID: 1405
		public abstract class VL
		{
			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x06006ACA RID: 27338 RVA: 0x00007B65 File Offset: 0x00005D65
			public static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06006ACB RID: 27339 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> Abs(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ACC RID: 27340 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> Abs(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ACD RID: 27341 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> AlignRight32(Vector128<int> left, Vector128<int> right, [ConstantExpected] byte mask)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ACE RID: 27342 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> AlignRight32(Vector128<uint> left, Vector128<uint> right, [ConstantExpected] byte mask)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ACF RID: 27343 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> AlignRight32(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte mask)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD0 RID: 27344 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> AlignRight32(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte mask)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD1 RID: 27345 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> AlignRight64(Vector128<long> left, Vector128<long> right, [ConstantExpected] byte mask)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD2 RID: 27346 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> AlignRight64(Vector128<ulong> left, Vector128<ulong> right, [ConstantExpected] byte mask)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD3 RID: 27347 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> AlignRight64(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte mask)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD4 RID: 27348 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> AlignRight64(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte mask)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD5 RID: 27349 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> CompareGreaterThanOrEqual(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD6 RID: 27350 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> CompareLessThan(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD7 RID: 27351 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> CompareLessThanOrEqual(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD8 RID: 27352 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> CompareNotEqual(Vector128<int> left, Vector128<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AD9 RID: 27353 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> CompareGreaterThanOrEqual(Vector256<int> left, Vector256<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ADA RID: 27354 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> CompareLessThan(Vector256<int> left, Vector256<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ADB RID: 27355 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> CompareLessThanOrEqual(Vector256<int> left, Vector256<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ADC RID: 27356 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> CompareNotEqual(Vector256<int> left, Vector256<int> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ADD RID: 27357 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareGreaterThanOrEqual(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ADE RID: 27358 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareLessThan(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006ADF RID: 27359 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareLessThanOrEqual(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE0 RID: 27360 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> CompareNotEqual(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE1 RID: 27361 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> CompareGreaterThanOrEqual(Vector256<long> left, Vector256<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE2 RID: 27362 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> CompareLessThan(Vector256<long> left, Vector256<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE3 RID: 27363 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> CompareLessThanOrEqual(Vector256<long> left, Vector256<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE4 RID: 27364 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> CompareNotEqual(Vector256<long> left, Vector256<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE5 RID: 27365 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> CompareGreaterThan(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE6 RID: 27366 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> CompareGreaterThanOrEqual(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE7 RID: 27367 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> CompareLessThan(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE8 RID: 27368 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> CompareLessThanOrEqual(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AE9 RID: 27369 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> CompareNotEqual(Vector128<uint> left, Vector128<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AEA RID: 27370 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> CompareGreaterThan(Vector256<uint> left, Vector256<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AEB RID: 27371 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> CompareGreaterThanOrEqual(Vector256<uint> left, Vector256<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AEC RID: 27372 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> CompareLessThan(Vector256<uint> left, Vector256<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AED RID: 27373 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> CompareLessThanOrEqual(Vector256<uint> left, Vector256<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AEE RID: 27374 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> CompareNotEqual(Vector256<uint> left, Vector256<uint> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AEF RID: 27375 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareGreaterThan(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF0 RID: 27376 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareGreaterThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF1 RID: 27377 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareLessThan(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF2 RID: 27378 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareLessThanOrEqual(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF3 RID: 27379 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> CompareNotEqual(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF4 RID: 27380 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> CompareGreaterThan(Vector256<ulong> left, Vector256<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF5 RID: 27381 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> CompareGreaterThanOrEqual(Vector256<ulong> left, Vector256<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF6 RID: 27382 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> CompareLessThan(Vector256<ulong> left, Vector256<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF7 RID: 27383 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> CompareLessThanOrEqual(Vector256<ulong> left, Vector256<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF8 RID: 27384 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> CompareNotEqual(Vector256<ulong> left, Vector256<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AF9 RID: 27385 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AFA RID: 27386 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AFB RID: 27387 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AFC RID: 27388 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AFD RID: 27389 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector256<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AFE RID: 27390 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006AFF RID: 27391 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B00 RID: 27392 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128Byte(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B01 RID: 27393 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B02 RID: 27394 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B03 RID: 27395 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B04 RID: 27396 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> ConvertToVector128ByteWithSaturation(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B05 RID: 27397 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertToVector128Double(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B06 RID: 27398 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B07 RID: 27399 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B08 RID: 27400 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B09 RID: 27401 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B0A RID: 27402 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16(Vector256<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B0B RID: 27403 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B0C RID: 27404 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B0D RID: 27405 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B0E RID: 27406 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B0F RID: 27407 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B10 RID: 27408 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector256<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B11 RID: 27409 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> ConvertToVector128Int16WithSaturation(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B12 RID: 27410 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> ConvertToVector128Int32(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B13 RID: 27411 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> ConvertToVector128Int32(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B14 RID: 27412 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> ConvertToVector128Int32(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B15 RID: 27413 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> ConvertToVector128Int32(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B16 RID: 27414 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> ConvertToVector128Int32WithSaturation(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B17 RID: 27415 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> ConvertToVector128Int32WithSaturation(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B18 RID: 27416 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B19 RID: 27417 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B1A RID: 27418 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B1B RID: 27419 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B1C RID: 27420 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector256<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B1D RID: 27421 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B1E RID: 27422 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B1F RID: 27423 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByte(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B20 RID: 27424 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B21 RID: 27425 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B22 RID: 27426 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B23 RID: 27427 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> ConvertToVector128SByteWithSaturation(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B24 RID: 27428 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertToVector128Single(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B25 RID: 27429 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16(Vector128<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B26 RID: 27430 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B27 RID: 27431 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B28 RID: 27432 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B29 RID: 27433 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16(Vector256<int> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B2A RID: 27434 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B2B RID: 27435 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B2C RID: 27436 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B2D RID: 27437 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B2E RID: 27438 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B2F RID: 27439 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B30 RID: 27440 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> ConvertToVector128UInt16WithSaturation(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B31 RID: 27441 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32(Vector128<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B32 RID: 27442 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B33 RID: 27443 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B34 RID: 27444 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B35 RID: 27445 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32(Vector256<long> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B36 RID: 27446 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B37 RID: 27447 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B38 RID: 27448 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32WithSaturation(Vector128<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B39 RID: 27449 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32WithSaturation(Vector256<ulong> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B3A RID: 27450 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B3B RID: 27451 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B3C RID: 27452 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> ConvertToVector128UInt32WithTruncation(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B3D RID: 27453 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> ConvertToVector256Double(Vector128<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B3E RID: 27454 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> ConvertToVector256Single(Vector256<uint> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B3F RID: 27455 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> ConvertToVector256UInt32(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B40 RID: 27456 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> ConvertToVector256UInt32WithTruncation(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B41 RID: 27457 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> Fixup(Vector128<float> left, Vector128<float> right, Vector128<int> table, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B42 RID: 27458 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Fixup(Vector128<double> left, Vector128<double> right, Vector128<long> table, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B43 RID: 27459 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> Fixup(Vector256<float> left, Vector256<float> right, Vector256<int> table, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B44 RID: 27460 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> Fixup(Vector256<double> left, Vector256<double> right, Vector256<long> table, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B45 RID: 27461 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> GetExponent(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B46 RID: 27462 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> GetExponent(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B47 RID: 27463 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> GetExponent(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B48 RID: 27464 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> GetExponent(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B49 RID: 27465 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> GetMantissa(Vector128<float> value, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B4A RID: 27466 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> GetMantissa(Vector128<double> value, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B4B RID: 27467 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> GetMantissa(Vector256<float> value, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B4C RID: 27468 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> GetMantissa(Vector256<double> value, [ConstantExpected(Max = 15)] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B4D RID: 27469 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> Max(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B4E RID: 27470 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> Max(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B4F RID: 27471 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> Max(Vector256<long> left, Vector256<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B50 RID: 27472 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> Max(Vector256<ulong> left, Vector256<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B51 RID: 27473 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> Min(Vector128<long> left, Vector128<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B52 RID: 27474 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> Min(Vector128<ulong> left, Vector128<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B53 RID: 27475 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> Min(Vector256<long> left, Vector256<long> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B54 RID: 27476 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> Min(Vector256<ulong> left, Vector256<ulong> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B55 RID: 27477 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> PermuteVar2x64x2(Vector128<long> lower, Vector128<long> indices, Vector128<long> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B56 RID: 27478 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> PermuteVar2x64x2(Vector128<ulong> lower, Vector128<ulong> indices, Vector128<ulong> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B57 RID: 27479 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> PermuteVar2x64x2(Vector128<double> lower, Vector128<long> indices, Vector128<double> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B58 RID: 27480 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> PermuteVar4x32x2(Vector128<int> lower, Vector128<int> indices, Vector128<int> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B59 RID: 27481 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> PermuteVar4x32x2(Vector128<uint> lower, Vector128<uint> indices, Vector128<uint> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B5A RID: 27482 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> PermuteVar4x32x2(Vector128<float> lower, Vector128<int> indices, Vector128<float> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B5B RID: 27483 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> PermuteVar4x64(Vector256<long> value, Vector256<long> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B5C RID: 27484 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> PermuteVar4x64(Vector256<ulong> value, Vector256<ulong> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B5D RID: 27485 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> PermuteVar4x64(Vector256<double> value, Vector256<long> control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B5E RID: 27486 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> PermuteVar4x64x2(Vector256<long> lower, Vector256<long> indices, Vector256<long> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B5F RID: 27487 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> PermuteVar4x64x2(Vector256<ulong> lower, Vector256<ulong> indices, Vector256<ulong> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B60 RID: 27488 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> PermuteVar4x64x2(Vector256<double> lower, Vector256<long> indices, Vector256<double> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B61 RID: 27489 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> PermuteVar8x32x2(Vector256<int> lower, Vector256<int> indices, Vector256<int> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B62 RID: 27490 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> PermuteVar8x32x2(Vector256<uint> lower, Vector256<uint> indices, Vector256<uint> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B63 RID: 27491 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> PermuteVar8x32x2(Vector256<float> lower, Vector256<int> indices, Vector256<float> upper)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B64 RID: 27492 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> Reciprocal14(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B65 RID: 27493 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Reciprocal14(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B66 RID: 27494 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> Reciprocal14(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B67 RID: 27495 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> Reciprocal14(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B68 RID: 27496 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ReciprocalSqrt14(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B69 RID: 27497 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ReciprocalSqrt14(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B6A RID: 27498 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> ReciprocalSqrt14(Vector256<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B6B RID: 27499 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> ReciprocalSqrt14(Vector256<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B6C RID: 27500 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> RotateLeft(Vector128<int> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B6D RID: 27501 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> RotateLeft(Vector128<uint> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B6E RID: 27502 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> RotateLeft(Vector128<long> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B6F RID: 27503 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> RotateLeft(Vector128<ulong> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B70 RID: 27504 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> RotateLeft(Vector256<int> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B71 RID: 27505 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> RotateLeft(Vector256<uint> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B72 RID: 27506 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> RotateLeft(Vector256<long> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B73 RID: 27507 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> RotateLeft(Vector256<ulong> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B74 RID: 27508 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> RotateLeftVariable(Vector128<int> value, Vector128<uint> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B75 RID: 27509 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> RotateLeftVariable(Vector128<uint> value, Vector128<uint> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B76 RID: 27510 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> RotateLeftVariable(Vector128<long> value, Vector128<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B77 RID: 27511 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> RotateLeftVariable(Vector128<ulong> value, Vector128<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B78 RID: 27512 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> RotateLeftVariable(Vector256<int> value, Vector256<uint> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B79 RID: 27513 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> RotateLeftVariable(Vector256<uint> value, Vector256<uint> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B7A RID: 27514 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> RotateLeftVariable(Vector256<long> value, Vector256<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B7B RID: 27515 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> RotateLeftVariable(Vector256<ulong> value, Vector256<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B7C RID: 27516 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> RotateRight(Vector128<int> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B7D RID: 27517 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> RotateRight(Vector128<uint> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B7E RID: 27518 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> RotateRight(Vector128<long> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B7F RID: 27519 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> RotateRight(Vector128<ulong> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B80 RID: 27520 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> RotateRight(Vector256<int> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B81 RID: 27521 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> RotateRight(Vector256<uint> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B82 RID: 27522 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> RotateRight(Vector256<long> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B83 RID: 27523 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> RotateRight(Vector256<ulong> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B84 RID: 27524 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> RotateRightVariable(Vector128<int> value, Vector128<uint> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B85 RID: 27525 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> RotateRightVariable(Vector128<uint> value, Vector128<uint> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B86 RID: 27526 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> RotateRightVariable(Vector128<long> value, Vector128<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B87 RID: 27527 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> RotateRightVariable(Vector128<ulong> value, Vector128<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B88 RID: 27528 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> RotateRightVariable(Vector256<int> value, Vector256<uint> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B89 RID: 27529 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> RotateRightVariable(Vector256<uint> value, Vector256<uint> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B8A RID: 27530 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> RotateRightVariable(Vector256<long> value, Vector256<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B8B RID: 27531 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> RotateRightVariable(Vector256<ulong> value, Vector256<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B8C RID: 27532 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> RoundScale(Vector128<float> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B8D RID: 27533 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> RoundScale(Vector128<double> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B8E RID: 27534 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> RoundScale(Vector256<float> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B8F RID: 27535 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> RoundScale(Vector256<double> value, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B90 RID: 27536 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> Scale(Vector128<float> left, Vector128<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B91 RID: 27537 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> Scale(Vector128<double> left, Vector128<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B92 RID: 27538 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> Scale(Vector256<float> left, Vector256<float> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B93 RID: 27539 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> Scale(Vector256<double> left, Vector256<double> right)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B94 RID: 27540 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, Vector128<long> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B95 RID: 27541 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, Vector128<long> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B96 RID: 27542 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ShiftRightArithmetic(Vector128<long> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B97 RID: 27543 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> ShiftRightArithmetic(Vector256<long> value, [ConstantExpected] byte count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B98 RID: 27544 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> ShiftRightArithmeticVariable(Vector128<long> value, Vector128<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B99 RID: 27545 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> ShiftRightArithmeticVariable(Vector256<long> value, Vector256<ulong> count)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B9A RID: 27546 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> Shuffle2x128(Vector256<double> left, Vector256<double> right, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B9B RID: 27547 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> Shuffle2x128(Vector256<int> left, Vector256<int> right, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B9C RID: 27548 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> Shuffle2x128(Vector256<long> left, Vector256<long> right, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B9D RID: 27549 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> Shuffle2x128(Vector256<float> left, Vector256<float> right, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B9E RID: 27550 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> Shuffle2x128(Vector256<uint> left, Vector256<uint> right, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006B9F RID: 27551 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> Shuffle2x128(Vector256<ulong> left, Vector256<ulong> right, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA0 RID: 27552 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<sbyte> TernaryLogic(Vector128<sbyte> a, Vector128<sbyte> b, Vector128<sbyte> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA1 RID: 27553 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<byte> TernaryLogic(Vector128<byte> a, Vector128<byte> b, Vector128<byte> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA2 RID: 27554 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<short> TernaryLogic(Vector128<short> a, Vector128<short> b, Vector128<short> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA3 RID: 27555 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ushort> TernaryLogic(Vector128<ushort> a, Vector128<ushort> b, Vector128<ushort> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA4 RID: 27556 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<int> TernaryLogic(Vector128<int> a, Vector128<int> b, Vector128<int> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA5 RID: 27557 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<uint> TernaryLogic(Vector128<uint> a, Vector128<uint> b, Vector128<uint> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA6 RID: 27558 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<long> TernaryLogic(Vector128<long> a, Vector128<long> b, Vector128<long> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA7 RID: 27559 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<ulong> TernaryLogic(Vector128<ulong> a, Vector128<ulong> b, Vector128<ulong> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA8 RID: 27560 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> TernaryLogic(Vector128<float> a, Vector128<float> b, Vector128<float> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BA9 RID: 27561 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> TernaryLogic(Vector128<double> a, Vector128<double> b, Vector128<double> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BAA RID: 27562 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<sbyte> TernaryLogic(Vector256<sbyte> a, Vector256<sbyte> b, Vector256<sbyte> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BAB RID: 27563 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<byte> TernaryLogic(Vector256<byte> a, Vector256<byte> b, Vector256<byte> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BAC RID: 27564 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<short> TernaryLogic(Vector256<short> a, Vector256<short> b, Vector256<short> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BAD RID: 27565 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ushort> TernaryLogic(Vector256<ushort> a, Vector256<ushort> b, Vector256<ushort> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BAE RID: 27566 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<int> TernaryLogic(Vector256<int> a, Vector256<int> b, Vector256<int> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BAF RID: 27567 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<uint> TernaryLogic(Vector256<uint> a, Vector256<uint> b, Vector256<uint> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BB0 RID: 27568 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<long> TernaryLogic(Vector256<long> a, Vector256<long> b, Vector256<long> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BB1 RID: 27569 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<ulong> TernaryLogic(Vector256<ulong> a, Vector256<ulong> b, Vector256<ulong> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BB2 RID: 27570 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<float> TernaryLogic(Vector256<float> a, Vector256<float> b, Vector256<float> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BB3 RID: 27571 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector256<double> TernaryLogic(Vector256<double> a, Vector256<double> b, Vector256<double> c, [ConstantExpected] byte control)
			{
				throw new PlatformNotSupportedException();
			}
		}

		// Token: 0x0200057E RID: 1406
		public new abstract class X64 : Avx2.X64
		{
			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x00007B65 File Offset: 0x00005D65
			public new static bool IsSupported
			{
				[Intrinsic]
				get
				{
					return false;
				}
			}

			// Token: 0x06006BB5 RID: 27573 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, ulong value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BB6 RID: 27574 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, long value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BB7 RID: 27575 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<float> ConvertScalarToVector128Single(Vector128<float> upper, ulong value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BB8 RID: 27576 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, ulong value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BB9 RID: 27577 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, long value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BBA RID: 27578 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static Vector128<double> ConvertScalarToVector128Double(Vector128<double> upper, ulong value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BBB RID: 27579 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static long ConvertToInt64(Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BBC RID: 27580 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static long ConvertToInt64(Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BBD RID: 27581 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BBE RID: 27582 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64(Vector128<float> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BBF RID: 27583 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BC0 RID: 27584 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64(Vector128<double> value, [ConstantExpected(Max = FloatRoundingMode.ToZero)] FloatRoundingMode mode)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BC1 RID: 27585 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64WithTruncation(Vector128<float> value)
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x06006BC2 RID: 27586 RVA: 0x0000ACEC File Offset: 0x00008EEC
			public static ulong ConvertToUInt64WithTruncation(Vector128<double> value)
			{
				throw new PlatformNotSupportedException();
			}
		}
	}
}
