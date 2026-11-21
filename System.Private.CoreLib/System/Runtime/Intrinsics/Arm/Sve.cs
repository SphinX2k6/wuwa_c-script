using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.Arm
{
	// Token: 0x02000563 RID: 1379
	[CLSCompliant(false)]
	[Experimental("SYSLIB5003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
	public abstract class Sve : AdvSimd
	{
		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06005D15 RID: 23829 RVA: 0x00007B65 File Offset: 0x00005D65
		public new static bool IsSupported
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06005D16 RID: 23830 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Abs(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D17 RID: 23831 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Abs(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D18 RID: 23832 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Abs(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D19 RID: 23833 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Abs(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D1A RID: 23834 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Abs(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D1B RID: 23835 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Abs(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D1C RID: 23836 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> AbsoluteCompareGreaterThan(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D1D RID: 23837 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> AbsoluteCompareGreaterThan(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D1E RID: 23838 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> AbsoluteCompareGreaterThanOrEqual(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D1F RID: 23839 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> AbsoluteCompareGreaterThanOrEqual(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> AbsoluteCompareLessThan(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> AbsoluteCompareLessThan(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> AbsoluteCompareLessThanOrEqual(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> AbsoluteCompareLessThanOrEqual(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> AbsoluteDifference(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D25 RID: 23845 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> AbsoluteDifference(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D26 RID: 23846 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> AbsoluteDifference(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D27 RID: 23847 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> AbsoluteDifference(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D28 RID: 23848 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> AbsoluteDifference(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D29 RID: 23849 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> AbsoluteDifference(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D2A RID: 23850 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> AbsoluteDifference(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D2B RID: 23851 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> AbsoluteDifference(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D2C RID: 23852 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> AbsoluteDifference(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D2D RID: 23853 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> AbsoluteDifference(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Add(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D2F RID: 23855 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Add(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D30 RID: 23856 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Add(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D31 RID: 23857 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Add(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D32 RID: 23858 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Add(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D33 RID: 23859 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Add(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D34 RID: 23860 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Add(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D35 RID: 23861 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Add(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D36 RID: 23862 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Add(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D37 RID: 23863 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Add(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D38 RID: 23864 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> AddAcross(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> AddAcross(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> AddAcross(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> AddAcross(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> AddAcross(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D3D RID: 23869 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> AddAcross(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D3E RID: 23870 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> AddAcross(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D3F RID: 23871 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> AddAcross(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D40 RID: 23872 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> AddAcross(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> AddAcross(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> AddRotateComplex(Vector<double> left, Vector<double> right, [ConstantExpected(Min = 0, Max = 1)] byte rotation)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D43 RID: 23875 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> AddRotateComplex(Vector<float> left, Vector<float> right, [ConstantExpected(Min = 0, Max = 1)] byte rotation)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D44 RID: 23876 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> AddSaturate(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D45 RID: 23877 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> AddSaturate(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D46 RID: 23878 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> AddSaturate(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D47 RID: 23879 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> AddSaturate(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D48 RID: 23880 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> AddSaturate(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D49 RID: 23881 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> AddSaturate(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D4A RID: 23882 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> AddSaturate(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D4B RID: 23883 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> AddSaturate(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D4C RID: 23884 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> AddSequentialAcross(Vector<double> initial, Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D4D RID: 23885 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> AddSequentialAcross(Vector<float> initial, Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D4E RID: 23886 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> And(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D4F RID: 23887 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> And(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D50 RID: 23888 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> And(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D51 RID: 23889 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> And(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D52 RID: 23890 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> And(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> And(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> And(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D55 RID: 23893 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> And(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D56 RID: 23894 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> AndAcross(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D57 RID: 23895 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> AndAcross(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> AndAcross(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> AndAcross(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> AndAcross(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> AndAcross(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> AndAcross(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D5D RID: 23901 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> AndAcross(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D5E RID: 23902 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> BitwiseClear(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D5F RID: 23903 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> BitwiseClear(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D60 RID: 23904 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> BitwiseClear(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D61 RID: 23905 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> BitwiseClear(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D62 RID: 23906 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> BitwiseClear(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D63 RID: 23907 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> BitwiseClear(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D64 RID: 23908 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> BitwiseClear(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D65 RID: 23909 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> BitwiseClear(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> BooleanNot(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> BooleanNot(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> BooleanNot(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> BooleanNot(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D6A RID: 23914 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> BooleanNot(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D6B RID: 23915 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> BooleanNot(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> BooleanNot(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> BooleanNot(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Compact(Vector<double> mask, Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D6F RID: 23919 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Compact(Vector<int> mask, Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D70 RID: 23920 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Compact(Vector<long> mask, Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Compact(Vector<float> mask, Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D72 RID: 23922 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compact(Vector<uint> mask, Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compact(Vector<ulong> mask, Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareEqual(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CompareEqual(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareEqual(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareEqual(Vector<short> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareEqual(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D79 RID: 23929 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareEqual(Vector<int> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D7A RID: 23930 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CompareEqual(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D7B RID: 23931 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareEqual(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D7C RID: 23932 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareEqual(Vector<sbyte> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D7D RID: 23933 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CompareEqual(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D7E RID: 23934 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareEqual(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D7F RID: 23935 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareEqual(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D80 RID: 23936 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CompareEqual(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D81 RID: 23937 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareGreaterThan(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D82 RID: 23938 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareGreaterThan(Vector<byte> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D83 RID: 23939 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CompareGreaterThan(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D84 RID: 23940 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareGreaterThan(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D85 RID: 23941 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareGreaterThan(Vector<short> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D86 RID: 23942 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareGreaterThan(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D87 RID: 23943 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareGreaterThan(Vector<int> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D88 RID: 23944 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CompareGreaterThan(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareGreaterThan(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareGreaterThan(Vector<sbyte> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D8B RID: 23947 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CompareGreaterThan(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D8C RID: 23948 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareGreaterThan(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D8D RID: 23949 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareGreaterThan(Vector<ushort> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D8E RID: 23950 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareGreaterThan(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D8F RID: 23951 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareGreaterThan(Vector<uint> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D90 RID: 23952 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CompareGreaterThan(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D91 RID: 23953 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareGreaterThanOrEqual(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D92 RID: 23954 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareGreaterThanOrEqual(Vector<byte> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D93 RID: 23955 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CompareGreaterThanOrEqual(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareGreaterThanOrEqual(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareGreaterThanOrEqual(Vector<short> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareGreaterThanOrEqual(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D97 RID: 23959 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareGreaterThanOrEqual(Vector<int> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D98 RID: 23960 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CompareGreaterThanOrEqual(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D99 RID: 23961 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareGreaterThanOrEqual(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D9A RID: 23962 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareGreaterThanOrEqual(Vector<sbyte> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D9B RID: 23963 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CompareGreaterThanOrEqual(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareGreaterThanOrEqual(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareGreaterThanOrEqual(Vector<ushort> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareGreaterThanOrEqual(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareGreaterThanOrEqual(Vector<uint> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CompareGreaterThanOrEqual(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareLessThan(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareLessThan(Vector<byte> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CompareLessThan(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareLessThan(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareLessThan(Vector<short> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA6 RID: 23974 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareLessThan(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA7 RID: 23975 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareLessThan(Vector<int> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA8 RID: 23976 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CompareLessThan(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareLessThan(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareLessThan(Vector<sbyte> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CompareLessThan(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareLessThan(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DAD RID: 23981 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareLessThan(Vector<ushort> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DAE RID: 23982 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareLessThan(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DAF RID: 23983 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareLessThan(Vector<uint> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB0 RID: 23984 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CompareLessThan(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareLessThanOrEqual(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB2 RID: 23986 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareLessThanOrEqual(Vector<byte> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB3 RID: 23987 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CompareLessThanOrEqual(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareLessThanOrEqual(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareLessThanOrEqual(Vector<short> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareLessThanOrEqual(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareLessThanOrEqual(Vector<int> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB8 RID: 23992 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CompareLessThanOrEqual(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DB9 RID: 23993 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareLessThanOrEqual(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DBA RID: 23994 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareLessThanOrEqual(Vector<sbyte> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DBB RID: 23995 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CompareLessThanOrEqual(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DBC RID: 23996 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareLessThanOrEqual(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DBD RID: 23997 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareLessThanOrEqual(Vector<ushort> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DBE RID: 23998 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareLessThanOrEqual(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareLessThanOrEqual(Vector<uint> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC0 RID: 24000 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CompareLessThanOrEqual(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CompareNotEqualTo(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CompareNotEqualTo(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareNotEqualTo(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CompareNotEqualTo(Vector<short> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareNotEqualTo(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CompareNotEqualTo(Vector<int> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CompareNotEqualTo(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareNotEqualTo(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CompareNotEqualTo(Vector<sbyte> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CompareNotEqualTo(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CompareNotEqualTo(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CompareNotEqualTo(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CompareNotEqualTo(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CompareUnordered(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CompareUnordered(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compute16BitAddresses(Vector<uint> bases, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compute16BitAddresses(Vector<uint> bases, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compute16BitAddresses(Vector<ulong> bases, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compute16BitAddresses(Vector<ulong> bases, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compute32BitAddresses(Vector<uint> bases, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compute32BitAddresses(Vector<uint> bases, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compute32BitAddresses(Vector<ulong> bases, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compute32BitAddresses(Vector<ulong> bases, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compute64BitAddresses(Vector<uint> bases, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compute64BitAddresses(Vector<uint> bases, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compute64BitAddresses(Vector<ulong> bases, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compute64BitAddresses(Vector<ulong> bases, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compute8BitAddresses(Vector<uint> bases, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Compute8BitAddresses(Vector<uint> bases, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compute8BitAddresses(Vector<ulong> bases, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Compute8BitAddresses(Vector<ulong> bases, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ConditionalExtractAfterLastActiveElement(Vector<byte> mask, Vector<byte> defaultValue, Vector<byte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static byte ConditionalExtractAfterLastActiveElement(Vector<byte> mask, byte defaultValues, Vector<byte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConditionalExtractAfterLastActiveElement(Vector<double> mask, Vector<double> defaultValue, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static double ConditionalExtractAfterLastActiveElement(Vector<double> mask, double defaultValues, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ConditionalExtractAfterLastActiveElement(Vector<short> mask, Vector<short> defaultValue, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static short ConditionalExtractAfterLastActiveElement(Vector<short> mask, short defaultValues, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ConditionalExtractAfterLastActiveElement(Vector<int> mask, Vector<int> defaultValue, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ConditionalExtractAfterLastActiveElement(Vector<int> mask, int defaultValues, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ConditionalExtractAfterLastActiveElement(Vector<long> mask, Vector<long> defaultValue, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long ConditionalExtractAfterLastActiveElement(Vector<long> mask, long defaultValues, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ConditionalExtractAfterLastActiveElement(Vector<sbyte> mask, Vector<sbyte> defaultValue, Vector<sbyte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static sbyte ConditionalExtractAfterLastActiveElement(Vector<sbyte> mask, sbyte defaultValues, Vector<sbyte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConditionalExtractAfterLastActiveElement(Vector<float> mask, Vector<float> defaultValue, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static float ConditionalExtractAfterLastActiveElement(Vector<float> mask, float defaultValues, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ConditionalExtractAfterLastActiveElement(Vector<ushort> mask, Vector<ushort> defaultValue, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ushort ConditionalExtractAfterLastActiveElement(Vector<ushort> mask, ushort defaultValues, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ConditionalExtractAfterLastActiveElement(Vector<uint> mask, Vector<uint> defaultValue, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConditionalExtractAfterLastActiveElement(Vector<uint> mask, uint defaultValues, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ConditionalExtractAfterLastActiveElement(Vector<ulong> mask, Vector<ulong> defaultValue, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong ConditionalExtractAfterLastActiveElement(Vector<ulong> mask, ulong defaultValues, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<byte> mask, Vector<byte> defaultScalar, Vector<byte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<double> mask, Vector<double> defaultScalar, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<short> mask, Vector<short> defaultScalar, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<int> mask, Vector<int> defaultScalar, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<long> mask, Vector<long> defaultScalar, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<sbyte> mask, Vector<sbyte> defaultScalar, Vector<sbyte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<float> mask, Vector<float> defaultScalar, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<ushort> mask, Vector<ushort> defaultScalar, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<uint> mask, Vector<uint> defaultScalar, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ConditionalExtractAfterLastActiveElementAndReplicate(Vector<ulong> mask, Vector<ulong> defaultScalar, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ConditionalExtractLastActiveElement(Vector<byte> mask, Vector<byte> defaultValue, Vector<byte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static byte ConditionalExtractLastActiveElement(Vector<byte> mask, byte defaultValues, Vector<byte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConditionalExtractLastActiveElement(Vector<double> mask, Vector<double> defaultValue, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static double ConditionalExtractLastActiveElement(Vector<double> mask, double defaultValues, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ConditionalExtractLastActiveElement(Vector<short> mask, Vector<short> defaultValue, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static short ConditionalExtractLastActiveElement(Vector<short> mask, short defaultValues, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ConditionalExtractLastActiveElement(Vector<int> mask, Vector<int> defaultValue, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int ConditionalExtractLastActiveElement(Vector<int> mask, int defaultValues, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ConditionalExtractLastActiveElement(Vector<long> mask, Vector<long> defaultValue, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long ConditionalExtractLastActiveElement(Vector<long> mask, long defaultValues, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ConditionalExtractLastActiveElement(Vector<sbyte> mask, Vector<sbyte> defaultValue, Vector<sbyte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static sbyte ConditionalExtractLastActiveElement(Vector<sbyte> mask, sbyte defaultValues, Vector<sbyte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConditionalExtractLastActiveElement(Vector<float> mask, Vector<float> defaultValue, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static float ConditionalExtractLastActiveElement(Vector<float> mask, float defaultValues, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ConditionalExtractLastActiveElement(Vector<ushort> mask, Vector<ushort> defaultValue, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ushort ConditionalExtractLastActiveElement(Vector<ushort> mask, ushort defaultValues, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ConditionalExtractLastActiveElement(Vector<uint> mask, Vector<uint> defaultValue, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint ConditionalExtractLastActiveElement(Vector<uint> mask, uint defaultValues, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ConditionalExtractLastActiveElement(Vector<ulong> mask, Vector<ulong> defaultValue, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong ConditionalExtractLastActiveElement(Vector<ulong> mask, ulong defaultValues, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ConditionalExtractLastActiveElementAndReplicate(Vector<byte> mask, Vector<byte> fallback, Vector<byte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConditionalExtractLastActiveElementAndReplicate(Vector<double> mask, Vector<double> fallback, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ConditionalExtractLastActiveElementAndReplicate(Vector<short> mask, Vector<short> fallback, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ConditionalExtractLastActiveElementAndReplicate(Vector<int> mask, Vector<int> fallback, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ConditionalExtractLastActiveElementAndReplicate(Vector<long> mask, Vector<long> fallback, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ConditionalExtractLastActiveElementAndReplicate(Vector<sbyte> mask, Vector<sbyte> fallback, Vector<sbyte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConditionalExtractLastActiveElementAndReplicate(Vector<float> mask, Vector<float> fallback, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ConditionalExtractLastActiveElementAndReplicate(Vector<ushort> mask, Vector<ushort> fallback, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ConditionalExtractLastActiveElementAndReplicate(Vector<uint> mask, Vector<uint> fallback, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ConditionalExtractLastActiveElementAndReplicate(Vector<ulong> mask, Vector<ulong> fallback, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ConditionalSelect(Vector<byte> mask, Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConditionalSelect(Vector<double> mask, Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ConditionalSelect(Vector<short> mask, Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ConditionalSelect(Vector<int> mask, Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ConditionalSelect(Vector<long> mask, Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ConditionalSelect(Vector<sbyte> mask, Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConditionalSelect(Vector<float> mask, Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ConditionalSelect(Vector<ushort> mask, Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ConditionalSelect(Vector<uint> mask, Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ConditionalSelect(Vector<ulong> mask, Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConvertToDouble(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConvertToDouble(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConvertToDouble(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E29 RID: 24105 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConvertToDouble(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E2A RID: 24106 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ConvertToDouble(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E2B RID: 24107 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ConvertToInt32(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ConvertToInt32(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ConvertToInt64(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ConvertToInt64(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConvertToSingle(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConvertToSingle(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConvertToSingle(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConvertToSingle(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ConvertToSingle(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ConvertToUInt32(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ConvertToUInt32(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ConvertToUInt64(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ConvertToUInt64(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong Count16BitElements([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong Count32BitElements([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong Count64BitElements([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong Count8BitElements([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateBreakAfterMask(Vector<byte> mask, Vector<byte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CreateBreakAfterMask(Vector<short> mask, Vector<short> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CreateBreakAfterMask(Vector<int> mask, Vector<int> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CreateBreakAfterMask(Vector<long> mask, Vector<long> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CreateBreakAfterMask(Vector<sbyte> mask, Vector<sbyte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateBreakAfterMask(Vector<ushort> mask, Vector<ushort> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateBreakAfterMask(Vector<uint> mask, Vector<uint> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateBreakAfterMask(Vector<ulong> mask, Vector<ulong> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateBreakAfterPropagateMask(Vector<byte> mask, Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CreateBreakAfterPropagateMask(Vector<short> mask, Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CreateBreakAfterPropagateMask(Vector<int> mask, Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CreateBreakAfterPropagateMask(Vector<long> mask, Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CreateBreakAfterPropagateMask(Vector<sbyte> mask, Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateBreakAfterPropagateMask(Vector<ushort> mask, Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateBreakAfterPropagateMask(Vector<uint> mask, Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateBreakAfterPropagateMask(Vector<ulong> mask, Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateBreakBeforeMask(Vector<byte> mask, Vector<byte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CreateBreakBeforeMask(Vector<short> mask, Vector<short> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E4E RID: 24142 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CreateBreakBeforeMask(Vector<int> mask, Vector<int> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E4F RID: 24143 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CreateBreakBeforeMask(Vector<long> mask, Vector<long> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E50 RID: 24144 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CreateBreakBeforeMask(Vector<sbyte> mask, Vector<sbyte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E51 RID: 24145 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateBreakBeforeMask(Vector<ushort> mask, Vector<ushort> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E52 RID: 24146 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateBreakBeforeMask(Vector<uint> mask, Vector<uint> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E53 RID: 24147 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateBreakBeforeMask(Vector<ulong> mask, Vector<ulong> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E54 RID: 24148 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateBreakBeforePropagateMask(Vector<byte> mask, Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CreateBreakBeforePropagateMask(Vector<short> mask, Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CreateBreakBeforePropagateMask(Vector<int> mask, Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CreateBreakBeforePropagateMask(Vector<long> mask, Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CreateBreakBeforePropagateMask(Vector<sbyte> mask, Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateBreakBeforePropagateMask(Vector<ushort> mask, Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateBreakBeforePropagateMask(Vector<uint> mask, Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateBreakBeforePropagateMask(Vector<ulong> mask, Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateBreakPropagateMask(Vector<byte> totalMask, Vector<byte> fromMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CreateBreakPropagateMask(Vector<short> totalMask, Vector<short> fromMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E5E RID: 24158 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CreateBreakPropagateMask(Vector<int> totalMask, Vector<int> fromMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E5F RID: 24159 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CreateBreakPropagateMask(Vector<long> totalMask, Vector<long> fromMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E60 RID: 24160 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CreateBreakPropagateMask(Vector<sbyte> totalMask, Vector<sbyte> fromMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E61 RID: 24161 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateBreakPropagateMask(Vector<ushort> totalMask, Vector<ushort> fromMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E62 RID: 24162 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateBreakPropagateMask(Vector<uint> totalMask, Vector<uint> fromMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E63 RID: 24163 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateBreakPropagateMask(Vector<ulong> totalMask, Vector<ulong> fromMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E64 RID: 24164 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateFalseMaskByte()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E65 RID: 24165 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CreateFalseMaskDouble()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CreateFalseMaskInt16()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E67 RID: 24167 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CreateFalseMaskInt32()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E68 RID: 24168 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CreateFalseMaskInt64()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CreateFalseMaskSByte()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CreateFalseMaskSingle()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateFalseMaskUInt16()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateFalseMaskUInt32()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateFalseMaskUInt64()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateMaskForFirstActiveElement(Vector<byte> mask, Vector<byte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CreateMaskForFirstActiveElement(Vector<short> mask, Vector<short> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CreateMaskForFirstActiveElement(Vector<int> mask, Vector<int> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CreateMaskForFirstActiveElement(Vector<long> mask, Vector<long> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CreateMaskForFirstActiveElement(Vector<sbyte> mask, Vector<sbyte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateMaskForFirstActiveElement(Vector<ushort> mask, Vector<ushort> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateMaskForFirstActiveElement(Vector<uint> mask, Vector<uint> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateMaskForFirstActiveElement(Vector<ulong> mask, Vector<ulong> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateMaskForNextActiveElement(Vector<byte> mask, Vector<byte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateMaskForNextActiveElement(Vector<ushort> mask, Vector<ushort> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateMaskForNextActiveElement(Vector<uint> mask, Vector<uint> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateMaskForNextActiveElement(Vector<ulong> mask, Vector<ulong> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateTrueMaskByte([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> CreateTrueMaskDouble([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> CreateTrueMaskInt16([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> CreateTrueMaskInt32([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> CreateTrueMaskInt64([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E7F RID: 24191 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> CreateTrueMaskSByte([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> CreateTrueMaskSingle([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E81 RID: 24193 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateTrueMaskUInt16([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateTrueMaskUInt32([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E83 RID: 24195 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateTrueMaskUInt64([ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateWhileLessThanMask16Bit(int left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E85 RID: 24197 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateWhileLessThanMask16Bit(long left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateWhileLessThanMask16Bit(uint left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E87 RID: 24199 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateWhileLessThanMask16Bit(ulong left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E88 RID: 24200 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateWhileLessThanMask32Bit(int left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E89 RID: 24201 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateWhileLessThanMask32Bit(long left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateWhileLessThanMask32Bit(uint left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E8B RID: 24203 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateWhileLessThanMask32Bit(ulong left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateWhileLessThanMask64Bit(int left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E8D RID: 24205 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateWhileLessThanMask64Bit(long left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateWhileLessThanMask64Bit(uint left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E8F RID: 24207 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateWhileLessThanMask64Bit(ulong left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateWhileLessThanMask8Bit(int left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E91 RID: 24209 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateWhileLessThanMask8Bit(long left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateWhileLessThanMask8Bit(uint left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E93 RID: 24211 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateWhileLessThanMask8Bit(ulong left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateWhileLessThanOrEqualMask16Bit(int left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E95 RID: 24213 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateWhileLessThanOrEqualMask16Bit(long left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateWhileLessThanOrEqualMask16Bit(uint left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E97 RID: 24215 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> CreateWhileLessThanOrEqualMask16Bit(ulong left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateWhileLessThanOrEqualMask32Bit(int left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E99 RID: 24217 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateWhileLessThanOrEqualMask32Bit(long left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateWhileLessThanOrEqualMask32Bit(uint left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E9B RID: 24219 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> CreateWhileLessThanOrEqualMask32Bit(ulong left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateWhileLessThanOrEqualMask64Bit(int left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E9D RID: 24221 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateWhileLessThanOrEqualMask64Bit(long left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E9E RID: 24222 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateWhileLessThanOrEqualMask64Bit(uint left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005E9F RID: 24223 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> CreateWhileLessThanOrEqualMask64Bit(ulong left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateWhileLessThanOrEqualMask8Bit(int left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA1 RID: 24225 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateWhileLessThanOrEqualMask8Bit(long left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateWhileLessThanOrEqualMask8Bit(uint left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> CreateWhileLessThanOrEqualMask8Bit(ulong left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Divide(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA5 RID: 24229 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Divide(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> DotProduct(Vector<int> addend, Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> DotProduct(Vector<long> addend, Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> DotProduct(Vector<uint> addend, Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EA9 RID: 24233 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> DotProduct(Vector<ulong> addend, Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> DotProductBySelectedScalar(Vector<int> addend, Vector<sbyte> left, Vector<sbyte> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> DotProductBySelectedScalar(Vector<long> addend, Vector<short> left, Vector<short> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> DotProductBySelectedScalar(Vector<uint> addend, Vector<byte> left, Vector<byte> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> DotProductBySelectedScalar(Vector<ulong> addend, Vector<ushort> left, Vector<ushort> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> DuplicateSelectedScalarToVector(Vector<byte> data, [ConstantExpected(Min = 0, Max = 63)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> DuplicateSelectedScalarToVector(Vector<double> data, [ConstantExpected(Min = 0, Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> DuplicateSelectedScalarToVector(Vector<short> data, [ConstantExpected(Min = 0, Max = 31)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB1 RID: 24241 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> DuplicateSelectedScalarToVector(Vector<int> data, [ConstantExpected(Min = 0, Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB2 RID: 24242 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> DuplicateSelectedScalarToVector(Vector<long> data, [ConstantExpected(Min = 0, Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB3 RID: 24243 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> DuplicateSelectedScalarToVector(Vector<sbyte> data, [ConstantExpected(Min = 0, Max = 63)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> DuplicateSelectedScalarToVector(Vector<float> data, [ConstantExpected(Min = 0, Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB5 RID: 24245 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> DuplicateSelectedScalarToVector(Vector<ushort> data, [ConstantExpected(Min = 0, Max = 31)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> DuplicateSelectedScalarToVector(Vector<uint> data, [ConstantExpected(Min = 0, Max = 15)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB7 RID: 24247 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> DuplicateSelectedScalarToVector(Vector<ulong> data, [ConstantExpected(Min = 0, Max = 7)] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ExtractVector(Vector<byte> upper, Vector<byte> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EB9 RID: 24249 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ExtractVector(Vector<double> upper, Vector<double> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ExtractVector(Vector<short> upper, Vector<short> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EBB RID: 24251 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ExtractVector(Vector<int> upper, Vector<int> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ExtractVector(Vector<long> upper, Vector<long> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EBD RID: 24253 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ExtractVector(Vector<sbyte> upper, Vector<sbyte> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ExtractVector(Vector<float> upper, Vector<float> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EBF RID: 24255 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ExtractVector(Vector<ushort> upper, Vector<ushort> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC0 RID: 24256 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ExtractVector(Vector<uint> upper, Vector<uint> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC1 RID: 24257 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ExtractVector(Vector<ulong> upper, Vector<ulong> lower, [ConstantExpected] byte index)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> FloatingPointExponentialAccelerator(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC3 RID: 24259 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> FloatingPointExponentialAccelerator(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC4 RID: 24260 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> FusedMultiplyAdd(Vector<double> addend, Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC5 RID: 24261 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> FusedMultiplyAdd(Vector<float> addend, Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> FusedMultiplyAddBySelectedScalar(Vector<double> addend, Vector<double> left, Vector<double> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC7 RID: 24263 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> FusedMultiplyAddBySelectedScalar(Vector<float> addend, Vector<float> left, Vector<float> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> FusedMultiplyAddNegated(Vector<double> addend, Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EC9 RID: 24265 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> FusedMultiplyAddNegated(Vector<float> addend, Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ECA RID: 24266 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> FusedMultiplySubtract(Vector<double> minuend, Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> FusedMultiplySubtract(Vector<float> minuend, Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> FusedMultiplySubtractBySelectedScalar(Vector<double> minuend, Vector<double> left, Vector<double> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> FusedMultiplySubtractBySelectedScalar(Vector<float> minuend, Vector<float> left, Vector<float> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> FusedMultiplySubtractNegated(Vector<double> minuend, Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> FusedMultiplySubtractNegated(Vector<float> minuend, Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch16Bit(Vector<short> mask, void* address, Vector<int> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch16Bit(Vector<short> mask, void* address, Vector<long> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch16Bit(Vector<short> mask, void* address, Vector<uint> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GatherPrefetch16Bit(Vector<short> mask, Vector<ulong> addresses, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch16Bit(Vector<short> mask, void* address, Vector<ulong> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch16Bit(Vector<ushort> mask, void* address, Vector<int> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch16Bit(Vector<ushort> mask, void* address, Vector<long> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch16Bit(Vector<ushort> mask, void* address, Vector<uint> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GatherPrefetch16Bit(Vector<ushort> mask, Vector<ulong> addresses, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch16Bit(Vector<ushort> mask, void* address, Vector<ulong> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch32Bit(Vector<int> mask, void* address, Vector<int> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch32Bit(Vector<int> mask, void* address, Vector<long> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch32Bit(Vector<int> mask, void* address, Vector<uint> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GatherPrefetch32Bit(Vector<int> mask, Vector<ulong> addresses, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch32Bit(Vector<int> mask, void* address, Vector<ulong> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch32Bit(Vector<uint> mask, void* address, Vector<int> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch32Bit(Vector<uint> mask, void* address, Vector<long> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch32Bit(Vector<uint> mask, void* address, Vector<uint> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GatherPrefetch32Bit(Vector<uint> mask, Vector<ulong> addresses, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch32Bit(Vector<uint> mask, void* address, Vector<ulong> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch64Bit(Vector<long> mask, void* address, Vector<int> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch64Bit(Vector<long> mask, void* address, Vector<long> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch64Bit(Vector<long> mask, void* address, Vector<uint> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GatherPrefetch64Bit(Vector<long> mask, Vector<ulong> addresses, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch64Bit(Vector<long> mask, void* address, Vector<ulong> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch64Bit(Vector<ulong> mask, void* address, Vector<int> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch64Bit(Vector<ulong> mask, void* address, Vector<long> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EEB RID: 24299 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch64Bit(Vector<ulong> mask, void* address, Vector<uint> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EEC RID: 24300 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GatherPrefetch64Bit(Vector<ulong> mask, Vector<ulong> addresses, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EED RID: 24301 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch64Bit(Vector<ulong> mask, void* address, Vector<ulong> indices, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EEE RID: 24302 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch8Bit(Vector<byte> mask, void* address, Vector<int> offsets, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EEF RID: 24303 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch8Bit(Vector<byte> mask, void* address, Vector<long> offsets, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF0 RID: 24304 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch8Bit(Vector<byte> mask, void* address, Vector<uint> offsets, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GatherPrefetch8Bit(Vector<byte> mask, Vector<ulong> addresses, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF2 RID: 24306 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch8Bit(Vector<byte> mask, void* address, Vector<ulong> offsets, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch8Bit(Vector<sbyte> mask, void* address, Vector<int> offsets, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF4 RID: 24308 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch8Bit(Vector<sbyte> mask, void* address, Vector<long> offsets, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch8Bit(Vector<sbyte> mask, void* address, Vector<uint> offsets, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF6 RID: 24310 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GatherPrefetch8Bit(Vector<sbyte> mask, Vector<ulong> addresses, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void GatherPrefetch8Bit(Vector<sbyte> mask, void* address, Vector<ulong> offsets, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF8 RID: 24312 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> GatherVector(Vector<double> mask, double* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> GatherVector(Vector<double> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> GatherVector(Vector<double> mask, double* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVector(Vector<int> mask, int* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVector(Vector<int> mask, int* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVector(Vector<long> mask, long* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVector(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVector(Vector<long> mask, long* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F00 RID: 24320 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> GatherVector(Vector<float> mask, float* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> GatherVector(Vector<float> mask, float* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVector(Vector<uint> mask, uint* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F03 RID: 24323 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVector(Vector<uint> mask, uint* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVector(Vector<ulong> mask, ulong* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F05 RID: 24325 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVector(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVector(Vector<ulong> mask, ulong* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F07 RID: 24327 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorByteZeroExtend(Vector<int> mask, byte* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorByteZeroExtend(Vector<int> mask, byte* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F09 RID: 24329 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorByteZeroExtend(Vector<long> mask, byte* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorByteZeroExtend(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F0B RID: 24331 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorByteZeroExtend(Vector<long> mask, byte* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorByteZeroExtend(Vector<uint> mask, byte* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorByteZeroExtend(Vector<uint> mask, byte* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorByteZeroExtend(Vector<ulong> mask, byte* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorByteZeroExtend(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorByteZeroExtend(Vector<ulong> mask, byte* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F11 RID: 24337 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorByteZeroExtendFirstFaulting(Vector<int> mask, byte* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F12 RID: 24338 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorByteZeroExtendFirstFaulting(Vector<int> mask, byte* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F13 RID: 24339 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorByteZeroExtendFirstFaulting(Vector<long> mask, byte* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F14 RID: 24340 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorByteZeroExtendFirstFaulting(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F15 RID: 24341 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorByteZeroExtendFirstFaulting(Vector<long> mask, byte* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorByteZeroExtendFirstFaulting(Vector<uint> mask, byte* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorByteZeroExtendFirstFaulting(Vector<uint> mask, byte* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F18 RID: 24344 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorByteZeroExtendFirstFaulting(Vector<ulong> mask, byte* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F19 RID: 24345 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorByteZeroExtendFirstFaulting(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorByteZeroExtendFirstFaulting(Vector<ulong> mask, byte* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F1B RID: 24347 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> GatherVectorFirstFaulting(Vector<double> mask, double* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F1C RID: 24348 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> GatherVectorFirstFaulting(Vector<double> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F1D RID: 24349 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> GatherVectorFirstFaulting(Vector<double> mask, double* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F1E RID: 24350 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorFirstFaulting(Vector<int> mask, int* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F1F RID: 24351 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorFirstFaulting(Vector<int> mask, int* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F20 RID: 24352 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorFirstFaulting(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorFirstFaulting(Vector<long> mask, long* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F22 RID: 24354 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorFirstFaulting(Vector<long> mask, long* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F23 RID: 24355 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> GatherVectorFirstFaulting(Vector<float> mask, float* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F24 RID: 24356 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> GatherVectorFirstFaulting(Vector<float> mask, float* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F25 RID: 24357 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorFirstFaulting(Vector<uint> mask, uint* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F26 RID: 24358 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorFirstFaulting(Vector<uint> mask, uint* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F27 RID: 24359 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorFirstFaulting(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorFirstFaulting(Vector<ulong> mask, ulong* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorFirstFaulting(Vector<ulong> mask, ulong* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorInt16SignExtend(Vector<int> mask, short* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorInt16SignExtend(Vector<int> mask, short* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt16SignExtend(Vector<long> mask, short* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorInt16SignExtend(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt16SignExtend(Vector<long> mask, short* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorInt16SignExtend(Vector<uint> mask, short* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorInt16SignExtend(Vector<uint> mask, short* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F31 RID: 24369 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt16SignExtend(Vector<ulong> mask, short* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorInt16SignExtend(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt16SignExtend(Vector<ulong> mask, short* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorInt16SignExtendFirstFaulting(Vector<int> mask, short* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorInt16SignExtendFirstFaulting(Vector<int> mask, short* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt16SignExtendFirstFaulting(Vector<long> mask, short* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorInt16SignExtendFirstFaulting(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt16SignExtendFirstFaulting(Vector<long> mask, short* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorInt16SignExtendFirstFaulting(Vector<uint> mask, short* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorInt16SignExtendFirstFaulting(Vector<uint> mask, short* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt16SignExtendFirstFaulting(Vector<ulong> mask, short* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorInt16SignExtendFirstFaulting(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F3D RID: 24381 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt16SignExtendFirstFaulting(Vector<ulong> mask, short* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F3E RID: 24382 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorInt16WithByteOffsetsSignExtend(Vector<int> mask, short* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorInt16WithByteOffsetsSignExtend(Vector<int> mask, short* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F40 RID: 24384 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt16WithByteOffsetsSignExtend(Vector<long> mask, short* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt16WithByteOffsetsSignExtend(Vector<long> mask, short* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F42 RID: 24386 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorInt16WithByteOffsetsSignExtend(Vector<uint> mask, short* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorInt16WithByteOffsetsSignExtend(Vector<uint> mask, short* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt16WithByteOffsetsSignExtend(Vector<ulong> mask, short* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt16WithByteOffsetsSignExtend(Vector<ulong> mask, short* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F46 RID: 24390 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorInt16WithByteOffsetsSignExtendFirstFaulting(Vector<int> mask, short* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F47 RID: 24391 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorInt16WithByteOffsetsSignExtendFirstFaulting(Vector<int> mask, short* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F48 RID: 24392 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt16WithByteOffsetsSignExtendFirstFaulting(Vector<long> mask, short* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F49 RID: 24393 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt16WithByteOffsetsSignExtendFirstFaulting(Vector<long> mask, short* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F4A RID: 24394 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorInt16WithByteOffsetsSignExtendFirstFaulting(Vector<uint> mask, short* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorInt16WithByteOffsetsSignExtendFirstFaulting(Vector<uint> mask, short* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt16WithByteOffsetsSignExtendFirstFaulting(Vector<ulong> mask, short* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt16WithByteOffsetsSignExtendFirstFaulting(Vector<ulong> mask, short* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt32SignExtend(Vector<long> mask, int* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorInt32SignExtend(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F50 RID: 24400 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt32SignExtend(Vector<long> mask, int* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F51 RID: 24401 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt32SignExtend(Vector<ulong> mask, int* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorInt32SignExtend(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt32SignExtend(Vector<ulong> mask, int* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt32SignExtendFirstFaulting(Vector<long> mask, int* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorInt32SignExtendFirstFaulting(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F56 RID: 24406 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt32SignExtendFirstFaulting(Vector<long> mask, int* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt32SignExtendFirstFaulting(Vector<ulong> mask, int* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorInt32SignExtendFirstFaulting(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F59 RID: 24409 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt32SignExtendFirstFaulting(Vector<ulong> mask, int* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F5A RID: 24410 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt32WithByteOffsetsSignExtend(Vector<long> mask, int* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F5B RID: 24411 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt32WithByteOffsetsSignExtend(Vector<long> mask, int* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt32WithByteOffsetsSignExtend(Vector<ulong> mask, int* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt32WithByteOffsetsSignExtend(Vector<ulong> mask, int* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt32WithByteOffsetsSignExtendFirstFaulting(Vector<long> mask, int* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F5F RID: 24415 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorInt32WithByteOffsetsSignExtendFirstFaulting(Vector<long> mask, int* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F60 RID: 24416 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt32WithByteOffsetsSignExtendFirstFaulting(Vector<ulong> mask, int* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F61 RID: 24417 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorInt32WithByteOffsetsSignExtendFirstFaulting(Vector<ulong> mask, int* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F62 RID: 24418 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorSByteSignExtend(Vector<int> mask, sbyte* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F63 RID: 24419 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorSByteSignExtend(Vector<int> mask, sbyte* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F64 RID: 24420 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorSByteSignExtend(Vector<long> mask, sbyte* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F65 RID: 24421 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorSByteSignExtend(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorSByteSignExtend(Vector<long> mask, sbyte* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorSByteSignExtend(Vector<uint> mask, sbyte* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorSByteSignExtend(Vector<uint> mask, sbyte* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorSByteSignExtend(Vector<ulong> mask, sbyte* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F6A RID: 24426 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorSByteSignExtend(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F6B RID: 24427 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorSByteSignExtend(Vector<ulong> mask, sbyte* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F6C RID: 24428 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorSByteSignExtendFirstFaulting(Vector<int> mask, sbyte* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorSByteSignExtendFirstFaulting(Vector<int> mask, sbyte* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorSByteSignExtendFirstFaulting(Vector<long> mask, sbyte* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorSByteSignExtendFirstFaulting(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorSByteSignExtendFirstFaulting(Vector<long> mask, sbyte* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorSByteSignExtendFirstFaulting(Vector<uint> mask, sbyte* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorSByteSignExtendFirstFaulting(Vector<uint> mask, sbyte* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorSByteSignExtendFirstFaulting(Vector<ulong> mask, sbyte* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F74 RID: 24436 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorSByteSignExtendFirstFaulting(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F75 RID: 24437 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorSByteSignExtendFirstFaulting(Vector<ulong> mask, sbyte* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F76 RID: 24438 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt16WithByteOffsetsZeroExtend(Vector<int> mask, ushort* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F77 RID: 24439 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt16WithByteOffsetsZeroExtend(Vector<int> mask, ushort* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F78 RID: 24440 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt16WithByteOffsetsZeroExtend(Vector<long> mask, ushort* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F79 RID: 24441 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt16WithByteOffsetsZeroExtend(Vector<long> mask, ushort* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt16WithByteOffsetsZeroExtend(Vector<uint> mask, ushort* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F7B RID: 24443 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt16WithByteOffsetsZeroExtend(Vector<uint> mask, ushort* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F7C RID: 24444 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt16WithByteOffsetsZeroExtend(Vector<ulong> mask, ushort* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F7D RID: 24445 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt16WithByteOffsetsZeroExtend(Vector<ulong> mask, ushort* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F7E RID: 24446 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt16WithByteOffsetsZeroExtendFirstFaulting(Vector<int> mask, ushort* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F7F RID: 24447 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt16WithByteOffsetsZeroExtendFirstFaulting(Vector<int> mask, ushort* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt16WithByteOffsetsZeroExtendFirstFaulting(Vector<long> mask, ushort* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F81 RID: 24449 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt16WithByteOffsetsZeroExtendFirstFaulting(Vector<long> mask, ushort* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F82 RID: 24450 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt16WithByteOffsetsZeroExtendFirstFaulting(Vector<uint> mask, ushort* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F83 RID: 24451 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt16WithByteOffsetsZeroExtendFirstFaulting(Vector<uint> mask, ushort* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F84 RID: 24452 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt16WithByteOffsetsZeroExtendFirstFaulting(Vector<ulong> mask, ushort* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F85 RID: 24453 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt16WithByteOffsetsZeroExtendFirstFaulting(Vector<ulong> mask, ushort* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F86 RID: 24454 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt16ZeroExtend(Vector<int> mask, ushort* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt16ZeroExtend(Vector<int> mask, ushort* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt16ZeroExtend(Vector<long> mask, ushort* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorUInt16ZeroExtend(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt16ZeroExtend(Vector<long> mask, ushort* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt16ZeroExtend(Vector<uint> mask, ushort* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F8C RID: 24460 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt16ZeroExtend(Vector<uint> mask, ushort* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt16ZeroExtend(Vector<ulong> mask, ushort* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorUInt16ZeroExtend(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt16ZeroExtend(Vector<ulong> mask, ushort* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<int> mask, ushort* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<int> mask, ushort* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<long> mask, ushort* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F94 RID: 24468 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<long> mask, ushort* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F95 RID: 24469 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<uint> mask, ushort* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<uint> mask, ushort* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<ulong> mask, ushort* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt16ZeroExtendFirstFaulting(Vector<ulong> mask, ushort* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt32WithByteOffsetsZeroExtend(Vector<int> mask, uint* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt32WithByteOffsetsZeroExtend(Vector<int> mask, uint* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt32WithByteOffsetsZeroExtend(Vector<long> mask, uint* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt32WithByteOffsetsZeroExtend(Vector<long> mask, uint* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt32WithByteOffsetsZeroExtend(Vector<uint> mask, uint* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt32WithByteOffsetsZeroExtend(Vector<uint> mask, uint* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt32WithByteOffsetsZeroExtend(Vector<ulong> mask, uint* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt32WithByteOffsetsZeroExtend(Vector<ulong> mask, uint* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt32WithByteOffsetsZeroExtendFirstFaulting(Vector<int> mask, uint* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt32WithByteOffsetsZeroExtendFirstFaulting(Vector<int> mask, uint* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt32WithByteOffsetsZeroExtendFirstFaulting(Vector<long> mask, uint* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt32WithByteOffsetsZeroExtendFirstFaulting(Vector<long> mask, uint* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt32WithByteOffsetsZeroExtendFirstFaulting(Vector<uint> mask, uint* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt32WithByteOffsetsZeroExtendFirstFaulting(Vector<uint> mask, uint* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt32WithByteOffsetsZeroExtendFirstFaulting(Vector<ulong> mask, uint* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt32WithByteOffsetsZeroExtendFirstFaulting(Vector<ulong> mask, uint* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FAA RID: 24490 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt32ZeroExtend(Vector<int> mask, uint* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FAB RID: 24491 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt32ZeroExtend(Vector<int> mask, uint* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FAC RID: 24492 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt32ZeroExtend(Vector<long> mask, uint* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorUInt32ZeroExtend(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt32ZeroExtend(Vector<long> mask, uint* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt32ZeroExtend(Vector<uint> mask, uint* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB0 RID: 24496 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt32ZeroExtend(Vector<uint> mask, uint* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt32ZeroExtend(Vector<ulong> mask, uint* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorUInt32ZeroExtend(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt32ZeroExtend(Vector<ulong> mask, uint* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB4 RID: 24500 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<int> mask, uint* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB5 RID: 24501 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<int> mask, uint* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB6 RID: 24502 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<long> mask, uint* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<long> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<long> mask, uint* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<uint> mask, uint* address, Vector<int> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<uint> mask, uint* address, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<ulong> mask, uint* address, Vector<long> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FBC RID: 24508 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<ulong> mask, Vector<ulong> addresses)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorUInt32ZeroExtendFirstFaulting(Vector<ulong> mask, uint* address, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> GatherVectorWithByteOffsetFirstFaulting(Vector<double> mask, double* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> GatherVectorWithByteOffsetFirstFaulting(Vector<double> mask, double* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorWithByteOffsetFirstFaulting(Vector<int> mask, int* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorWithByteOffsetFirstFaulting(Vector<int> mask, int* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorWithByteOffsetFirstFaulting(Vector<long> mask, long* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC3 RID: 24515 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorWithByteOffsetFirstFaulting(Vector<long> mask, long* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC4 RID: 24516 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> GatherVectorWithByteOffsetFirstFaulting(Vector<float> mask, float* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC5 RID: 24517 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> GatherVectorWithByteOffsetFirstFaulting(Vector<float> mask, float* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC6 RID: 24518 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorWithByteOffsetFirstFaulting(Vector<uint> mask, uint* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC7 RID: 24519 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorWithByteOffsetFirstFaulting(Vector<uint> mask, uint* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC8 RID: 24520 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorWithByteOffsetFirstFaulting(Vector<ulong> mask, ulong* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FC9 RID: 24521 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorWithByteOffsetFirstFaulting(Vector<ulong> mask, ulong* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FCA RID: 24522 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> GatherVectorWithByteOffsets(Vector<double> mask, double* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> GatherVectorWithByteOffsets(Vector<double> mask, double* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorWithByteOffsets(Vector<int> mask, int* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> GatherVectorWithByteOffsets(Vector<int> mask, int* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorWithByteOffsets(Vector<long> mask, long* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> GatherVectorWithByteOffsets(Vector<long> mask, long* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> GatherVectorWithByteOffsets(Vector<float> mask, float* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> GatherVectorWithByteOffsets(Vector<float> mask, float* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorWithByteOffsets(Vector<uint> mask, uint* address, Vector<int> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> GatherVectorWithByteOffsets(Vector<uint> mask, uint* address, Vector<uint> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorWithByteOffsets(Vector<ulong> mask, ulong* address, Vector<long> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> GatherVectorWithByteOffsets(Vector<ulong> mask, ulong* address, Vector<ulong> offsets)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<byte> mask, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<double> mask, Vector<double> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<short> mask, Vector<short> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FD9 RID: 24537 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<int> mask, Vector<int> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FDA RID: 24538 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<long> mask, Vector<long> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FDB RID: 24539 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<sbyte> mask, Vector<sbyte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FDC RID: 24540 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<float> mask, Vector<float> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FDD RID: 24541 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<ushort> mask, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FDE RID: 24542 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<uint> mask, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FDF RID: 24543 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong GetActiveElementCount(Vector<ulong> mask, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE0 RID: 24544 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> GetFfrByte()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE1 RID: 24545 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> GetFfrInt16()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE2 RID: 24546 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> GetFfrInt32()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE3 RID: 24547 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> GetFfrInt64()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE4 RID: 24548 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> GetFfrSByte()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE5 RID: 24549 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> GetFfrUInt16()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE6 RID: 24550 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> GetFfrUInt32()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE7 RID: 24551 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> GetFfrUInt64()
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE8 RID: 24552 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> InsertIntoShiftedVector(Vector<byte> left, byte right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FE9 RID: 24553 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> InsertIntoShiftedVector(Vector<double> left, double right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FEA RID: 24554 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> InsertIntoShiftedVector(Vector<short> left, short right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FEB RID: 24555 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> InsertIntoShiftedVector(Vector<int> left, int right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FEC RID: 24556 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> InsertIntoShiftedVector(Vector<long> left, long right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FED RID: 24557 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> InsertIntoShiftedVector(Vector<sbyte> left, sbyte right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FEE RID: 24558 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> InsertIntoShiftedVector(Vector<float> left, float right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FEF RID: 24559 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> InsertIntoShiftedVector(Vector<ushort> left, ushort right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF0 RID: 24560 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> InsertIntoShiftedVector(Vector<uint> left, uint right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF1 RID: 24561 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> InsertIntoShiftedVector(Vector<ulong> left, ulong right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF2 RID: 24562 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> LeadingSignCount(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> LeadingSignCount(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF4 RID: 24564 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> LeadingSignCount(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF5 RID: 24565 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> LeadingSignCount(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> LeadingZeroCount(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> LeadingZeroCount(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> LeadingZeroCount(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> LeadingZeroCount(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> LeadingZeroCount(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> LeadingZeroCount(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> LeadingZeroCount(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> LeadingZeroCount(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<byte> LoadVector(Vector<byte> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> LoadVector(Vector<double> mask, double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVector(Vector<short> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006001 RID: 24577 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVector(Vector<int> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006002 RID: 24578 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVector(Vector<long> mask, long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006003 RID: 24579 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<sbyte> LoadVector(Vector<sbyte> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006004 RID: 24580 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> LoadVector(Vector<float> mask, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006005 RID: 24581 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVector(Vector<ushort> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVector(Vector<uint> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006007 RID: 24583 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVector(Vector<ulong> mask, ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006008 RID: 24584 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<byte> LoadVector128AndReplicateToVector(Vector<byte> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006009 RID: 24585 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> LoadVector128AndReplicateToVector(Vector<double> mask, double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVector128AndReplicateToVector(Vector<short> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVector128AndReplicateToVector(Vector<int> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVector128AndReplicateToVector(Vector<long> mask, long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<sbyte> LoadVector128AndReplicateToVector(Vector<sbyte> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> LoadVector128AndReplicateToVector(Vector<float> mask, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600600F RID: 24591 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVector128AndReplicateToVector(Vector<ushort> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006010 RID: 24592 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVector128AndReplicateToVector(Vector<uint> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006011 RID: 24593 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVector128AndReplicateToVector(Vector<ulong> mask, ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006012 RID: 24594 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorByteNonFaultingZeroExtendToInt16(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006013 RID: 24595 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorByteNonFaultingZeroExtendToInt32(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006014 RID: 24596 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorByteNonFaultingZeroExtendToInt64(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006015 RID: 24597 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorByteNonFaultingZeroExtendToUInt16(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006016 RID: 24598 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorByteNonFaultingZeroExtendToUInt32(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006017 RID: 24599 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorByteNonFaultingZeroExtendToUInt64(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006018 RID: 24600 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorByteZeroExtendFirstFaulting(Vector<short> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006019 RID: 24601 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorByteZeroExtendFirstFaulting(Vector<int> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600601A RID: 24602 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorByteZeroExtendFirstFaulting(Vector<long> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600601B RID: 24603 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorByteZeroExtendFirstFaulting(Vector<ushort> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600601C RID: 24604 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorByteZeroExtendFirstFaulting(Vector<uint> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600601D RID: 24605 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorByteZeroExtendFirstFaulting(Vector<ulong> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600601E RID: 24606 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorByteZeroExtendToInt16(Vector<short> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600601F RID: 24607 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorByteZeroExtendToInt32(Vector<int> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorByteZeroExtendToInt64(Vector<long> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorByteZeroExtendToUInt16(Vector<ushort> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorByteZeroExtendToUInt32(Vector<uint> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorByteZeroExtendToUInt64(Vector<ulong> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<byte> LoadVectorFirstFaulting(Vector<byte> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> LoadVectorFirstFaulting(Vector<double> mask, double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorFirstFaulting(Vector<short> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorFirstFaulting(Vector<int> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorFirstFaulting(Vector<long> mask, long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<sbyte> LoadVectorFirstFaulting(Vector<sbyte> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> LoadVectorFirstFaulting(Vector<float> mask, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorFirstFaulting(Vector<ushort> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorFirstFaulting(Vector<uint> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorFirstFaulting(Vector<ulong> mask, ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorInt16NonFaultingSignExtendToInt32(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorInt16NonFaultingSignExtendToInt64(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorInt16NonFaultingSignExtendToUInt32(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorInt16NonFaultingSignExtendToUInt64(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorInt16SignExtendFirstFaulting(Vector<int> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorInt16SignExtendFirstFaulting(Vector<long> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorInt16SignExtendFirstFaulting(Vector<uint> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorInt16SignExtendFirstFaulting(Vector<ulong> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorInt16SignExtendToInt32(Vector<int> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorInt16SignExtendToInt64(Vector<long> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorInt16SignExtendToUInt32(Vector<uint> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorInt16SignExtendToUInt64(Vector<ulong> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorInt32NonFaultingSignExtendToInt64(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorInt32NonFaultingSignExtendToUInt64(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorInt32SignExtendFirstFaulting(Vector<long> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorInt32SignExtendFirstFaulting(Vector<ulong> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorInt32SignExtendToInt64(Vector<long> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorInt32SignExtendToUInt64(Vector<ulong> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006040 RID: 24640 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<byte> LoadVectorNonFaulting(byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006041 RID: 24641 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> LoadVectorNonFaulting(double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorNonFaulting(short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorNonFaulting(int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorNonFaulting(long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<sbyte> LoadVectorNonFaulting(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> LoadVectorNonFaulting(float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorNonFaulting(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006048 RID: 24648 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorNonFaulting(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006049 RID: 24649 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorNonFaulting(ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600604A RID: 24650 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<byte> LoadVectorNonTemporal(Vector<byte> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<double> LoadVectorNonTemporal(Vector<double> mask, double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600604C RID: 24652 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorNonTemporal(Vector<short> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600604D RID: 24653 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorNonTemporal(Vector<int> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600604E RID: 24654 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorNonTemporal(Vector<long> mask, long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600604F RID: 24655 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<sbyte> LoadVectorNonTemporal(Vector<sbyte> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<float> LoadVectorNonTemporal(Vector<float> mask, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorNonTemporal(Vector<ushort> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorNonTemporal(Vector<uint> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorNonTemporal(Vector<ulong> mask, ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorSByteNonFaultingSignExtendToInt16(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorSByteNonFaultingSignExtendToInt32(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorSByteNonFaultingSignExtendToInt64(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorSByteNonFaultingSignExtendToUInt16(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorSByteNonFaultingSignExtendToUInt32(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorSByteNonFaultingSignExtendToUInt64(sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600605A RID: 24666 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorSByteSignExtendFirstFaulting(Vector<short> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600605B RID: 24667 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorSByteSignExtendFirstFaulting(Vector<int> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600605C RID: 24668 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorSByteSignExtendFirstFaulting(Vector<long> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600605D RID: 24669 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorSByteSignExtendFirstFaulting(Vector<ushort> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorSByteSignExtendFirstFaulting(Vector<uint> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorSByteSignExtendFirstFaulting(Vector<ulong> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006060 RID: 24672 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<short> LoadVectorSByteSignExtendToInt16(Vector<short> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorSByteSignExtendToInt32(Vector<int> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorSByteSignExtendToInt64(Vector<long> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ushort> LoadVectorSByteSignExtendToUInt16(Vector<ushort> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006064 RID: 24676 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorSByteSignExtendToUInt32(Vector<uint> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorSByteSignExtendToUInt64(Vector<ulong> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorUInt16NonFaultingZeroExtendToInt32(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorUInt16NonFaultingZeroExtendToInt64(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006068 RID: 24680 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorUInt16NonFaultingZeroExtendToUInt32(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006069 RID: 24681 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorUInt16NonFaultingZeroExtendToUInt64(ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600606A RID: 24682 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorUInt16ZeroExtendFirstFaulting(Vector<int> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600606B RID: 24683 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorUInt16ZeroExtendFirstFaulting(Vector<long> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600606C RID: 24684 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorUInt16ZeroExtendFirstFaulting(Vector<uint> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorUInt16ZeroExtendFirstFaulting(Vector<ulong> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<int> LoadVectorUInt16ZeroExtendToInt32(Vector<int> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600606F RID: 24687 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorUInt16ZeroExtendToInt64(Vector<long> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006070 RID: 24688 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<uint> LoadVectorUInt16ZeroExtendToUInt32(Vector<uint> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorUInt16ZeroExtendToUInt64(Vector<ulong> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorUInt32NonFaultingZeroExtendToInt64(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorUInt32NonFaultingZeroExtendToUInt64(uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorUInt32ZeroExtendFirstFaulting(Vector<long> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorUInt32ZeroExtendFirstFaulting(Vector<ulong> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<long> LoadVectorUInt32ZeroExtendToInt64(Vector<long> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static Vector<ulong> LoadVectorUInt32ZeroExtendToUInt64(Vector<ulong> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006078 RID: 24696 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<byte>, Vector<byte>> Load2xVectorAndUnzip(Vector<byte> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006079 RID: 24697 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<double>, Vector<double>> Load2xVectorAndUnzip(Vector<double> mask, double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600607A RID: 24698 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<short>, Vector<short>> Load2xVectorAndUnzip(Vector<short> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<int>, Vector<int>> Load2xVectorAndUnzip(Vector<int> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<long>, Vector<long>> Load2xVectorAndUnzip(Vector<long> mask, long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<sbyte>, Vector<sbyte>> Load2xVectorAndUnzip(Vector<sbyte> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<float>, Vector<float>> Load2xVectorAndUnzip(Vector<float> mask, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<ushort>, Vector<ushort>> Load2xVectorAndUnzip(Vector<ushort> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<uint>, Vector<uint>> Load2xVectorAndUnzip(Vector<uint> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006081 RID: 24705 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<ulong>, Vector<ulong>> Load2xVectorAndUnzip(Vector<ulong> mask, ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006082 RID: 24706 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>> Load3xVectorAndUnzip(Vector<byte> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006083 RID: 24707 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<double>, Vector<double>, Vector<double>> Load3xVectorAndUnzip(Vector<double> mask, double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006084 RID: 24708 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<short>, Vector<short>, Vector<short>> Load3xVectorAndUnzip(Vector<short> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006085 RID: 24709 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<int>, Vector<int>, Vector<int>> Load3xVectorAndUnzip(Vector<int> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006086 RID: 24710 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<long>, Vector<long>, Vector<long>> Load3xVectorAndUnzip(Vector<long> mask, long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006087 RID: 24711 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>> Load3xVectorAndUnzip(Vector<sbyte> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006088 RID: 24712 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<float>, Vector<float>, Vector<float>> Load3xVectorAndUnzip(Vector<float> mask, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006089 RID: 24713 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>> Load3xVectorAndUnzip(Vector<ushort> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600608A RID: 24714 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>> Load3xVectorAndUnzip(Vector<uint> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600608B RID: 24715 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>> Load3xVectorAndUnzip(Vector<ulong> mask, ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600608C RID: 24716 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>> Load4xVectorAndUnzip(Vector<byte> mask, byte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600608D RID: 24717 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<double>, Vector<double>, Vector<double>, Vector<double>> Load4xVectorAndUnzip(Vector<double> mask, double* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600608E RID: 24718 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>> Load4xVectorAndUnzip(Vector<short> mask, short* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600608F RID: 24719 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>> Load4xVectorAndUnzip(Vector<int> mask, int* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006090 RID: 24720 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>> Load4xVectorAndUnzip(Vector<long> mask, long* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006091 RID: 24721 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>> Load4xVectorAndUnzip(Vector<sbyte> mask, sbyte* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<float>, Vector<float>, Vector<float>, Vector<float>> Load4xVectorAndUnzip(Vector<float> mask, float* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006093 RID: 24723 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>> Load4xVectorAndUnzip(Vector<ushort> mask, ushort* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>> Load4xVectorAndUnzip(Vector<uint> mask, uint* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>> Load4xVectorAndUnzip(Vector<ulong> mask, ulong* address)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006096 RID: 24726 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Max(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006097 RID: 24727 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Max(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006098 RID: 24728 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Max(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006099 RID: 24729 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Max(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600609A RID: 24730 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Max(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600609B RID: 24731 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Max(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600609C RID: 24732 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Max(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600609D RID: 24733 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Max(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600609E RID: 24734 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Max(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600609F RID: 24735 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Max(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A0 RID: 24736 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> MaxAcross(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A1 RID: 24737 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MaxAcross(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A2 RID: 24738 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> MaxAcross(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A3 RID: 24739 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> MaxAcross(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A4 RID: 24740 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> MaxAcross(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A5 RID: 24741 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> MaxAcross(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A6 RID: 24742 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MaxAcross(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A7 RID: 24743 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> MaxAcross(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A8 RID: 24744 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> MaxAcross(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060A9 RID: 24745 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> MaxAcross(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060AA RID: 24746 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MaxNumber(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060AB RID: 24747 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MaxNumber(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MaxNumberAcross(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MaxNumberAcross(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060AE RID: 24750 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Min(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Min(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B0 RID: 24752 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Min(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B1 RID: 24753 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Min(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B2 RID: 24754 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Min(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B3 RID: 24755 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Min(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B4 RID: 24756 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Min(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B5 RID: 24757 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Min(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B6 RID: 24758 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Min(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B7 RID: 24759 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Min(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B8 RID: 24760 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> MinAcross(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060B9 RID: 24761 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MinAcross(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060BA RID: 24762 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> MinAcross(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060BB RID: 24763 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> MinAcross(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060BC RID: 24764 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> MinAcross(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060BD RID: 24765 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> MinAcross(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060BE RID: 24766 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MinAcross(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060BF RID: 24767 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> MinAcross(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C0 RID: 24768 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> MinAcross(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C1 RID: 24769 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> MinAcross(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C2 RID: 24770 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MinNumber(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C3 RID: 24771 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MinNumber(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C4 RID: 24772 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MinNumberAcross(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C5 RID: 24773 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MinNumberAcross(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C6 RID: 24774 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Multiply(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C7 RID: 24775 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Multiply(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C8 RID: 24776 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Multiply(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060C9 RID: 24777 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Multiply(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060CA RID: 24778 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Multiply(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060CB RID: 24779 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Multiply(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060CC RID: 24780 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Multiply(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060CD RID: 24781 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Multiply(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Multiply(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Multiply(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> MultiplyAdd(Vector<byte> addend, Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D1 RID: 24785 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> MultiplyAdd(Vector<short> addend, Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D2 RID: 24786 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> MultiplyAdd(Vector<int> addend, Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D3 RID: 24787 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> MultiplyAdd(Vector<long> addend, Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D4 RID: 24788 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> MultiplyAdd(Vector<sbyte> addend, Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> MultiplyAdd(Vector<ushort> addend, Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> MultiplyAdd(Vector<uint> addend, Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> MultiplyAdd(Vector<ulong> addend, Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MultiplyAddRotateComplex(Vector<double> addend, Vector<double> left, Vector<double> right, [ConstantExpected(Min = 0, Max = 3)] byte rotation)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MultiplyAddRotateComplex(Vector<float> addend, Vector<float> left, Vector<float> right, [ConstantExpected(Min = 0, Max = 3)] byte rotation)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MultiplyAddRotateComplexBySelectedScalar(Vector<float> addend, Vector<float> left, Vector<float> right, [ConstantExpected(Min = 0, Max = 1)] byte rightIndex, [ConstantExpected(Min = 0, Max = 3)] byte rotation)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MultiplyBySelectedScalar(Vector<double> left, Vector<double> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MultiplyBySelectedScalar(Vector<float> left, Vector<float> right, [ConstantExpected] byte rightIndex)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> MultiplyExtended(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> MultiplyExtended(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> MultiplySubtract(Vector<byte> minuend, Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> MultiplySubtract(Vector<short> minuend, Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> MultiplySubtract(Vector<int> minuend, Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> MultiplySubtract(Vector<long> minuend, Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> MultiplySubtract(Vector<sbyte> minuend, Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> MultiplySubtract(Vector<ushort> minuend, Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> MultiplySubtract(Vector<uint> minuend, Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> MultiplySubtract(Vector<ulong> minuend, Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Negate(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Negate(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Negate(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Negate(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Negate(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Negate(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Not(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Not(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Not(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Not(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Not(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Not(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Not(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Not(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Or(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Or(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Or(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Or(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060F9 RID: 24825 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Or(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060FA RID: 24826 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Or(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060FB RID: 24827 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Or(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060FC RID: 24828 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Or(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060FD RID: 24829 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> OrAcross(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060FE RID: 24830 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> OrAcross(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060060FF RID: 24831 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> OrAcross(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006100 RID: 24832 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> OrAcross(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006101 RID: 24833 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> OrAcross(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006102 RID: 24834 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> OrAcross(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006103 RID: 24835 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> OrAcross(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006104 RID: 24836 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> OrAcross(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006105 RID: 24837 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> PopCount(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006106 RID: 24838 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> PopCount(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006107 RID: 24839 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> PopCount(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006108 RID: 24840 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> PopCount(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006109 RID: 24841 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> PopCount(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600610A RID: 24842 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> PopCount(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600610B RID: 24843 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> PopCount(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600610C RID: 24844 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> PopCount(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600610D RID: 24845 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> PopCount(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600610E RID: 24846 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> PopCount(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600610F RID: 24847 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void PrefetchBytes(Vector<byte> mask, void* address, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006110 RID: 24848 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void PrefetchInt16(Vector<ushort> mask, void* address, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006111 RID: 24849 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void PrefetchInt32(Vector<uint> mask, void* address, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006112 RID: 24850 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void PrefetchInt64(Vector<ulong> mask, void* address, [ConstantExpected] SvePrefetchType prefetchType)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006113 RID: 24851 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ReciprocalEstimate(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006114 RID: 24852 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ReciprocalEstimate(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006115 RID: 24853 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ReciprocalExponent(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006116 RID: 24854 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ReciprocalExponent(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006117 RID: 24855 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ReciprocalSqrtEstimate(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ReciprocalSqrtEstimate(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ReciprocalSqrtStep(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ReciprocalSqrtStep(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ReciprocalStep(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600611C RID: 24860 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ReciprocalStep(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ReverseBits(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600611E RID: 24862 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ReverseBits(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ReverseBits(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ReverseBits(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ReverseBits(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ReverseBits(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ReverseBits(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ReverseBits(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ReverseElement(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ReverseElement(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006127 RID: 24871 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ReverseElement(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006128 RID: 24872 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ReverseElement(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006129 RID: 24873 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ReverseElement(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600612A RID: 24874 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ReverseElement(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600612B RID: 24875 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ReverseElement(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600612C RID: 24876 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ReverseElement(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ReverseElement(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ReverseElement(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600612F RID: 24879 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ReverseElement16(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006130 RID: 24880 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ReverseElement16(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006131 RID: 24881 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ReverseElement16(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006132 RID: 24882 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ReverseElement16(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006133 RID: 24883 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ReverseElement32(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006134 RID: 24884 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ReverseElement32(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006135 RID: 24885 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ReverseElement8(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006136 RID: 24886 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ReverseElement8(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006137 RID: 24887 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ReverseElement8(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006138 RID: 24888 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ReverseElement8(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006139 RID: 24889 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ReverseElement8(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600613A RID: 24890 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ReverseElement8(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600613B RID: 24891 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> RoundAwayFromZero(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600613C RID: 24892 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> RoundAwayFromZero(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600613D RID: 24893 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> RoundToNearest(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600613E RID: 24894 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> RoundToNearest(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600613F RID: 24895 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> RoundToNegativeInfinity(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006140 RID: 24896 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> RoundToNegativeInfinity(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006141 RID: 24897 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> RoundToPositiveInfinity(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006142 RID: 24898 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> RoundToPositiveInfinity(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006143 RID: 24899 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> RoundToZero(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> RoundToZero(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int SaturatingDecrementBy16BitElementCount(int value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006146 RID: 24902 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementBy16BitElementCount(long value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006147 RID: 24903 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint SaturatingDecrementBy16BitElementCount(uint value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006148 RID: 24904 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementBy16BitElementCount(ulong value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006149 RID: 24905 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> SaturatingDecrementBy16BitElementCount(Vector<short> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600614A RID: 24906 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> SaturatingDecrementBy16BitElementCount(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600614B RID: 24907 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int SaturatingDecrementBy32BitElementCount(int value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600614C RID: 24908 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementBy32BitElementCount(long value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600614D RID: 24909 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint SaturatingDecrementBy32BitElementCount(uint value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600614E RID: 24910 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementBy32BitElementCount(ulong value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600614F RID: 24911 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SaturatingDecrementBy32BitElementCount(Vector<int> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006150 RID: 24912 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> SaturatingDecrementBy32BitElementCount(Vector<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int SaturatingDecrementBy64BitElementCount(int value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementBy64BitElementCount(long value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint SaturatingDecrementBy64BitElementCount(uint value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementBy64BitElementCount(ulong value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SaturatingDecrementBy64BitElementCount(Vector<long> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006156 RID: 24918 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> SaturatingDecrementBy64BitElementCount(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006157 RID: 24919 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int SaturatingDecrementBy8BitElementCount(int value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006158 RID: 24920 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementBy8BitElementCount(long value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006159 RID: 24921 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint SaturatingDecrementBy8BitElementCount(uint value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600615A RID: 24922 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementBy8BitElementCount(ulong value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600615B RID: 24923 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementByActiveElementCount(int value, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600615C RID: 24924 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementByActiveElementCount(long value, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600615D RID: 24925 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementByActiveElementCount(uint value, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600615E RID: 24926 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementByActiveElementCount(ulong value, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600615F RID: 24927 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> SaturatingDecrementByActiveElementCount(Vector<short> value, Vector<short> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006160 RID: 24928 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SaturatingDecrementByActiveElementCount(Vector<int> value, Vector<int> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006161 RID: 24929 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SaturatingDecrementByActiveElementCount(Vector<long> value, Vector<long> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006162 RID: 24930 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementByActiveElementCount(int value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementByActiveElementCount(long value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementByActiveElementCount(uint value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006165 RID: 24933 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementByActiveElementCount(ulong value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006166 RID: 24934 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> SaturatingDecrementByActiveElementCount(Vector<ushort> value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006167 RID: 24935 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementByActiveElementCount(int value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006168 RID: 24936 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementByActiveElementCount(long value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006169 RID: 24937 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementByActiveElementCount(uint value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600616A RID: 24938 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementByActiveElementCount(ulong value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600616B RID: 24939 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> SaturatingDecrementByActiveElementCount(Vector<uint> value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600616C RID: 24940 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementByActiveElementCount(int value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600616D RID: 24941 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingDecrementByActiveElementCount(long value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600616E RID: 24942 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementByActiveElementCount(uint value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600616F RID: 24943 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingDecrementByActiveElementCount(ulong value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006170 RID: 24944 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> SaturatingDecrementByActiveElementCount(Vector<ulong> value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int SaturatingIncrementBy16BitElementCount(int value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementBy16BitElementCount(long value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint SaturatingIncrementBy16BitElementCount(uint value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementBy16BitElementCount(ulong value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> SaturatingIncrementBy16BitElementCount(Vector<short> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> SaturatingIncrementBy16BitElementCount(Vector<ushort> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int SaturatingIncrementBy32BitElementCount(int value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006178 RID: 24952 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementBy32BitElementCount(long value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006179 RID: 24953 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint SaturatingIncrementBy32BitElementCount(uint value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementBy32BitElementCount(ulong value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600617B RID: 24955 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SaturatingIncrementBy32BitElementCount(Vector<int> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600617C RID: 24956 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> SaturatingIncrementBy32BitElementCount(Vector<uint> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int SaturatingIncrementBy64BitElementCount(int value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600617E RID: 24958 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementBy64BitElementCount(long value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600617F RID: 24959 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint SaturatingIncrementBy64BitElementCount(uint value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006180 RID: 24960 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementBy64BitElementCount(ulong value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006181 RID: 24961 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SaturatingIncrementBy64BitElementCount(Vector<long> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006182 RID: 24962 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> SaturatingIncrementBy64BitElementCount(Vector<ulong> value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006183 RID: 24963 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static int SaturatingIncrementBy8BitElementCount(int value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006184 RID: 24964 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementBy8BitElementCount(long value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006185 RID: 24965 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static uint SaturatingIncrementBy8BitElementCount(uint value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006186 RID: 24966 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementBy8BitElementCount(ulong value, [ConstantExpected(Min = 1, Max = 16)] byte scale, [ConstantExpected] SveMaskPattern pattern = SveMaskPattern.All)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006187 RID: 24967 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementByActiveElementCount(int value, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006188 RID: 24968 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementByActiveElementCount(long value, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006189 RID: 24969 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementByActiveElementCount(uint value, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600618A RID: 24970 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementByActiveElementCount(ulong value, Vector<byte> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600618B RID: 24971 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> SaturatingIncrementByActiveElementCount(Vector<short> value, Vector<short> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600618C RID: 24972 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SaturatingIncrementByActiveElementCount(Vector<int> value, Vector<int> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600618D RID: 24973 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SaturatingIncrementByActiveElementCount(Vector<long> value, Vector<long> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600618E RID: 24974 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementByActiveElementCount(int value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementByActiveElementCount(long value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementByActiveElementCount(uint value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementByActiveElementCount(ulong value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> SaturatingIncrementByActiveElementCount(Vector<ushort> value, Vector<ushort> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006193 RID: 24979 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementByActiveElementCount(int value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006194 RID: 24980 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementByActiveElementCount(long value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006195 RID: 24981 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementByActiveElementCount(uint value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006196 RID: 24982 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementByActiveElementCount(ulong value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006197 RID: 24983 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> SaturatingIncrementByActiveElementCount(Vector<uint> value, Vector<uint> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006198 RID: 24984 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementByActiveElementCount(int value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006199 RID: 24985 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static long SaturatingIncrementByActiveElementCount(long value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600619A RID: 24986 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementByActiveElementCount(uint value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600619B RID: 24987 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static ulong SaturatingIncrementByActiveElementCount(ulong value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600619C RID: 24988 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> SaturatingIncrementByActiveElementCount(Vector<ulong> value, Vector<ulong> from)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600619D RID: 24989 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Scale(Vector<double> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600619E RID: 24990 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Scale(Vector<float> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<double> mask, double* address, Vector<long> indicies, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter(Vector<double> mask, Vector<ulong> addresses, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<double> mask, double* address, Vector<ulong> indicies, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<int> mask, int* address, Vector<int> indicies, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<int> mask, int* address, Vector<uint> indicies, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<long> mask, long* address, Vector<long> indicies, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter(Vector<long> mask, Vector<ulong> addresses, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<long> mask, long* address, Vector<ulong> indicies, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<float> mask, float* address, Vector<int> indicies, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<float> mask, float* address, Vector<uint> indicies, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<uint> mask, uint* address, Vector<int> indicies, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<uint> mask, uint* address, Vector<uint> indicies, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<ulong> mask, ulong* address, Vector<long> indicies, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter(Vector<ulong> mask, Vector<ulong> addresses, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter(Vector<ulong> mask, ulong* address, Vector<ulong> indicies, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061AE RID: 25006 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter16BitNarrowing(Vector<long> mask, Vector<ulong> addresses, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061AF RID: 25007 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter16BitNarrowing(Vector<ulong> mask, Vector<ulong> addresses, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B0 RID: 25008 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter16BitWithByteOffsetsNarrowing(Vector<int> mask, short* address, Vector<int> offsets, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B1 RID: 25009 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter16BitWithByteOffsetsNarrowing(Vector<int> mask, short* address, Vector<uint> offsets, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B2 RID: 25010 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter16BitWithByteOffsetsNarrowing(Vector<long> mask, short* address, Vector<long> offsets, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B3 RID: 25011 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter16BitWithByteOffsetsNarrowing(Vector<long> mask, short* address, Vector<ulong> offsets, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter16BitWithByteOffsetsNarrowing(Vector<uint> mask, ushort* address, Vector<int> offsets, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter16BitWithByteOffsetsNarrowing(Vector<uint> mask, ushort* address, Vector<uint> offsets, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter16BitWithByteOffsetsNarrowing(Vector<ulong> mask, ushort* address, Vector<long> offsets, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter16BitWithByteOffsetsNarrowing(Vector<ulong> mask, ushort* address, Vector<ulong> offsets, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter32BitNarrowing(Vector<long> mask, Vector<ulong> addresses, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061B9 RID: 25017 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter32BitNarrowing(Vector<ulong> mask, Vector<ulong> addresses, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061BA RID: 25018 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter32BitWithByteOffsetsNarrowing(Vector<long> mask, int* address, Vector<long> offsets, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061BB RID: 25019 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter32BitWithByteOffsetsNarrowing(Vector<long> mask, int* address, Vector<ulong> offsets, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061BC RID: 25020 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter32BitWithByteOffsetsNarrowing(Vector<ulong> mask, uint* address, Vector<long> offsets, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061BD RID: 25021 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter32BitWithByteOffsetsNarrowing(Vector<ulong> mask, uint* address, Vector<ulong> offsets, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061BE RID: 25022 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter8BitNarrowing(Vector<long> mask, Vector<ulong> addresses, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061BF RID: 25023 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void Scatter8BitNarrowing(Vector<ulong> mask, Vector<ulong> addresses, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C0 RID: 25024 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter8BitWithByteOffsetsNarrowing(Vector<int> mask, sbyte* address, Vector<int> offsets, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C1 RID: 25025 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter8BitWithByteOffsetsNarrowing(Vector<int> mask, sbyte* address, Vector<uint> offsets, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C2 RID: 25026 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter8BitWithByteOffsetsNarrowing(Vector<long> mask, sbyte* address, Vector<long> offsets, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C3 RID: 25027 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter8BitWithByteOffsetsNarrowing(Vector<long> mask, sbyte* address, Vector<ulong> offsets, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C4 RID: 25028 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter8BitWithByteOffsetsNarrowing(Vector<uint> mask, byte* address, Vector<int> offsets, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C5 RID: 25029 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter8BitWithByteOffsetsNarrowing(Vector<uint> mask, byte* address, Vector<uint> offsets, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C6 RID: 25030 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter8BitWithByteOffsetsNarrowing(Vector<ulong> mask, byte* address, Vector<long> offsets, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C7 RID: 25031 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void Scatter8BitWithByteOffsetsNarrowing(Vector<ulong> mask, byte* address, Vector<ulong> offsets, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C8 RID: 25032 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetFfr(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061C9 RID: 25033 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetFfr(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061CA RID: 25034 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetFfr(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061CB RID: 25035 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetFfr(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061CC RID: 25036 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetFfr(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetFfr(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetFfr(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void SetFfr(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ShiftLeftLogical(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ShiftLeftLogical(Vector<byte> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ShiftLeftLogical(Vector<short> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ShiftLeftLogical(Vector<short> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ShiftLeftLogical(Vector<int> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D5 RID: 25045 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ShiftLeftLogical(Vector<int> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D6 RID: 25046 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ShiftLeftLogical(Vector<long> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ShiftLeftLogical(Vector<sbyte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ShiftLeftLogical(Vector<sbyte> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061D9 RID: 25049 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ShiftLeftLogical(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ShiftLeftLogical(Vector<ushort> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061DB RID: 25051 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ShiftLeftLogical(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ShiftLeftLogical(Vector<uint> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061DD RID: 25053 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ShiftLeftLogical(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ShiftRightArithmetic(Vector<short> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ShiftRightArithmetic(Vector<short> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ShiftRightArithmetic(Vector<int> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E1 RID: 25057 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ShiftRightArithmetic(Vector<int> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ShiftRightArithmetic(Vector<long> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E3 RID: 25059 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ShiftRightArithmetic(Vector<sbyte> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E5 RID: 25061 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ShiftRightArithmeticForDivide(Vector<short> value, [ConstantExpected(Min = 1, Max = 16)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ShiftRightArithmeticForDivide(Vector<int> value, [ConstantExpected(Min = 1, Max = 32)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ShiftRightArithmeticForDivide(Vector<long> value, [ConstantExpected(Min = 1, Max = 64)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E8 RID: 25064 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ShiftRightArithmeticForDivide(Vector<sbyte> value, [ConstantExpected(Min = 1, Max = 8)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061E9 RID: 25065 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ShiftRightLogical(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061EA RID: 25066 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ShiftRightLogical(Vector<byte> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061EB RID: 25067 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ShiftRightLogical(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061EC RID: 25068 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ShiftRightLogical(Vector<ushort> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061ED RID: 25069 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ShiftRightLogical(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061EE RID: 25070 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ShiftRightLogical(Vector<uint> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ShiftRightLogical(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SignExtend16(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F1 RID: 25073 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SignExtend16(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F2 RID: 25074 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SignExtend32(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F3 RID: 25075 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> SignExtend8(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F4 RID: 25076 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SignExtend8(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F5 RID: 25077 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SignExtend8(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F6 RID: 25078 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> SignExtendWideningLower(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F7 RID: 25079 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SignExtendWideningLower(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F8 RID: 25080 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SignExtendWideningLower(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061F9 RID: 25081 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> SignExtendWideningUpper(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061FA RID: 25082 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SignExtendWideningUpper(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061FB RID: 25083 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SignExtendWideningUpper(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061FC RID: 25084 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Splice(Vector<byte> mask, Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061FD RID: 25085 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Splice(Vector<double> mask, Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061FE RID: 25086 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Splice(Vector<short> mask, Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060061FF RID: 25087 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Splice(Vector<int> mask, Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006200 RID: 25088 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Splice(Vector<long> mask, Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Splice(Vector<sbyte> mask, Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Splice(Vector<float> mask, Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006203 RID: 25091 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Splice(Vector<ushort> mask, Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006204 RID: 25092 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Splice(Vector<uint> mask, Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006205 RID: 25093 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Splice(Vector<ulong> mask, Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006206 RID: 25094 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Sqrt(Vector<double> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006207 RID: 25095 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Sqrt(Vector<float> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006208 RID: 25096 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<byte> mask, byte* address, Vector<byte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<byte> mask, byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<byte>, Vector<byte>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<byte> mask, byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600620B RID: 25099 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<byte> mask, byte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<byte>, Vector<byte>, Vector<byte>, Vector<byte>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600620C RID: 25100 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<double> mask, double* address, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600620D RID: 25101 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<double> mask, double* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<double>, Vector<double>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600620E RID: 25102 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<double> mask, double* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<double>, Vector<double>, Vector<double>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600620F RID: 25103 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<double> mask, double* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<double>, Vector<double>, Vector<double>, Vector<double>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006210 RID: 25104 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<short> mask, short* address, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006211 RID: 25105 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<short> mask, short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<short>, Vector<short>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006212 RID: 25106 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<short> mask, short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<short>, Vector<short>, Vector<short>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006213 RID: 25107 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<short> mask, short* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<short>, Vector<short>, Vector<short>, Vector<short>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006214 RID: 25108 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<int> mask, int* address, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006215 RID: 25109 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<int> mask, int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<int>, Vector<int>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006216 RID: 25110 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<int> mask, int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<int>, Vector<int>, Vector<int>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006217 RID: 25111 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<int> mask, int* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<int>, Vector<int>, Vector<int>, Vector<int>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006218 RID: 25112 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<long> mask, long* address, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006219 RID: 25113 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<long> mask, long* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<long>, Vector<long>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600621A RID: 25114 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<long> mask, long* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<long>, Vector<long>, Vector<long>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600621B RID: 25115 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<long> mask, long* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<long>, Vector<long>, Vector<long>, Vector<long>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600621C RID: 25116 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<sbyte> mask, sbyte* address, Vector<sbyte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600621D RID: 25117 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<sbyte> mask, sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<sbyte>, Vector<sbyte>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600621E RID: 25118 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<sbyte> mask, sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600621F RID: 25119 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<sbyte> mask, sbyte* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<sbyte>, Vector<sbyte>, Vector<sbyte>, Vector<sbyte>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006220 RID: 25120 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<float> mask, float* address, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006221 RID: 25121 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<float> mask, float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<float>, Vector<float>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006222 RID: 25122 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<float> mask, float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<float>, Vector<float>, Vector<float>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006223 RID: 25123 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<float> mask, float* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<float>, Vector<float>, Vector<float>, Vector<float>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006224 RID: 25124 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<ushort> mask, ushort* address, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006225 RID: 25125 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<ushort> mask, ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<ushort>, Vector<ushort>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006226 RID: 25126 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<ushort> mask, ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006227 RID: 25127 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<ushort> mask, ushort* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<ushort>, Vector<ushort>, Vector<ushort>, Vector<ushort>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006228 RID: 25128 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<uint> mask, uint* address, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006229 RID: 25129 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<uint> mask, uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<uint>, Vector<uint>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600622A RID: 25130 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<uint> mask, uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600622B RID: 25131 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<uint> mask, uint* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<uint>, Vector<uint>, Vector<uint>, Vector<uint>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600622C RID: 25132 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<ulong> mask, ulong* address, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600622D RID: 25133 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<ulong> mask, ulong* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2"
		})] ValueTuple<Vector<ulong>, Vector<ulong>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600622E RID: 25134 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<ulong> mask, ulong* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3"
		})] ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600622F RID: 25135 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreAndZip(Vector<ulong> mask, ulong* address, [TupleElementNames(new string[]
		{
			"Value1",
			"Value2",
			"Value3",
			"Value4"
		})] ValueTuple<Vector<ulong>, Vector<ulong>, Vector<ulong>, Vector<ulong>> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<short> mask, sbyte* address, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006231 RID: 25137 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<int> mask, sbyte* address, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006232 RID: 25138 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<int> mask, short* address, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006233 RID: 25139 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<long> mask, sbyte* address, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006234 RID: 25140 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<long> mask, short* address, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006235 RID: 25141 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<long> mask, int* address, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006236 RID: 25142 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<ushort> mask, byte* address, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006237 RID: 25143 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<uint> mask, byte* address, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006238 RID: 25144 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<uint> mask, ushort* address, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006239 RID: 25145 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<ulong> mask, byte* address, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600623A RID: 25146 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<ulong> mask, ushort* address, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600623B RID: 25147 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNarrowing(Vector<ulong> mask, uint* address, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600623C RID: 25148 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<byte> mask, byte* address, Vector<byte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600623D RID: 25149 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<double> mask, double* address, Vector<double> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600623E RID: 25150 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<short> mask, short* address, Vector<short> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600623F RID: 25151 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<int> mask, int* address, Vector<int> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006240 RID: 25152 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<long> mask, long* address, Vector<long> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006241 RID: 25153 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<sbyte> mask, sbyte* address, Vector<sbyte> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006242 RID: 25154 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<float> mask, float* address, Vector<float> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006243 RID: 25155 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<ushort> mask, ushort* address, Vector<ushort> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<uint> mask, uint* address, Vector<uint> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006245 RID: 25157 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public unsafe static void StoreNonTemporal(Vector<ulong> mask, ulong* address, Vector<ulong> data)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Subtract(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006247 RID: 25159 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> Subtract(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Subtract(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006249 RID: 25161 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Subtract(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600624A RID: 25162 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Subtract(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600624B RID: 25163 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Subtract(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600624C RID: 25164 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> Subtract(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600624D RID: 25165 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Subtract(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Subtract(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Subtract(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006250 RID: 25168 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> SubtractSaturate(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006251 RID: 25169 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> SubtractSaturate(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006252 RID: 25170 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> SubtractSaturate(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006253 RID: 25171 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> SubtractSaturate(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006254 RID: 25172 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> SubtractSaturate(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006255 RID: 25173 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> SubtractSaturate(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006256 RID: 25174 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> SubtractSaturate(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006257 RID: 25175 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> SubtractSaturate(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006258 RID: 25176 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestAnyTrue(Vector<byte> mask, Vector<byte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006259 RID: 25177 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestAnyTrue(Vector<short> mask, Vector<short> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestAnyTrue(Vector<int> mask, Vector<int> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600625B RID: 25179 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestAnyTrue(Vector<long> mask, Vector<long> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600625C RID: 25180 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestAnyTrue(Vector<sbyte> mask, Vector<sbyte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600625D RID: 25181 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestAnyTrue(Vector<ushort> mask, Vector<ushort> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600625E RID: 25182 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestAnyTrue(Vector<uint> mask, Vector<uint> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestAnyTrue(Vector<ulong> mask, Vector<ulong> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006260 RID: 25184 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestFirstTrue(Vector<byte> mask, Vector<byte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006261 RID: 25185 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestFirstTrue(Vector<short> mask, Vector<short> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006262 RID: 25186 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestFirstTrue(Vector<int> mask, Vector<int> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006263 RID: 25187 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestFirstTrue(Vector<long> mask, Vector<long> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006264 RID: 25188 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestFirstTrue(Vector<sbyte> mask, Vector<sbyte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006265 RID: 25189 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestFirstTrue(Vector<ushort> mask, Vector<ushort> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006266 RID: 25190 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestFirstTrue(Vector<uint> mask, Vector<uint> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006267 RID: 25191 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestFirstTrue(Vector<ulong> mask, Vector<ulong> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006268 RID: 25192 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestLastTrue(Vector<byte> mask, Vector<byte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006269 RID: 25193 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestLastTrue(Vector<short> mask, Vector<short> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600626A RID: 25194 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestLastTrue(Vector<int> mask, Vector<int> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600626B RID: 25195 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestLastTrue(Vector<long> mask, Vector<long> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600626C RID: 25196 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestLastTrue(Vector<sbyte> mask, Vector<sbyte> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600626D RID: 25197 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestLastTrue(Vector<ushort> mask, Vector<ushort> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600626E RID: 25198 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestLastTrue(Vector<uint> mask, Vector<uint> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600626F RID: 25199 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static bool TestLastTrue(Vector<ulong> mask, Vector<ulong> srcMask)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> TransposeEven(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006271 RID: 25201 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> TransposeEven(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> TransposeEven(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> TransposeEven(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006274 RID: 25204 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> TransposeEven(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006275 RID: 25205 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> TransposeEven(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006276 RID: 25206 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> TransposeEven(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> TransposeEven(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> TransposeEven(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> TransposeEven(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> TransposeOdd(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> TransposeOdd(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> TransposeOdd(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600627D RID: 25213 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> TransposeOdd(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600627E RID: 25214 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> TransposeOdd(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600627F RID: 25215 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> TransposeOdd(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> TransposeOdd(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> TransposeOdd(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> TransposeOdd(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> TransposeOdd(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> TrigonometricMultiplyAddCoefficient(Vector<double> left, Vector<double> right, [ConstantExpected(Min = 0, Max = 7)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006285 RID: 25221 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> TrigonometricMultiplyAddCoefficient(Vector<float> left, Vector<float> right, [ConstantExpected(Min = 0, Max = 7)] byte control)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006286 RID: 25222 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> TrigonometricSelectCoefficient(Vector<double> value, Vector<ulong> selector)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> TrigonometricSelectCoefficient(Vector<float> value, Vector<uint> selector)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> TrigonometricStartingValue(Vector<double> value, Vector<ulong> sign)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> TrigonometricStartingValue(Vector<float> value, Vector<uint> sign)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> UnzipEven(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> UnzipEven(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> UnzipEven(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> UnzipEven(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> UnzipEven(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600628F RID: 25231 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> UnzipEven(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> UnzipEven(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> UnzipEven(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> UnzipEven(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> UnzipEven(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> UnzipOdd(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> UnzipOdd(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> UnzipOdd(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> UnzipOdd(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> UnzipOdd(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> UnzipOdd(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> UnzipOdd(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> UnzipOdd(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> UnzipOdd(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> UnzipOdd(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> VectorTableLookup(Vector<byte> data, Vector<byte> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> VectorTableLookup(Vector<double> data, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> VectorTableLookup(Vector<short> data, Vector<ushort> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> VectorTableLookup(Vector<int> data, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A2 RID: 25250 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> VectorTableLookup(Vector<long> data, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> VectorTableLookup(Vector<sbyte> data, Vector<byte> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A4 RID: 25252 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> VectorTableLookup(Vector<float> data, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> VectorTableLookup(Vector<ushort> data, Vector<ushort> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> VectorTableLookup(Vector<uint> data, Vector<uint> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> VectorTableLookup(Vector<ulong> data, Vector<ulong> indices)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> Xor(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> Xor(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> Xor(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> Xor(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062AC RID: 25260 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> Xor(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062AD RID: 25261 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> Xor(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062AE RID: 25262 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> Xor(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> Xor(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B0 RID: 25264 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> XorAcross(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B1 RID: 25265 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> XorAcross(Vector<short> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B2 RID: 25266 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> XorAcross(Vector<int> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> XorAcross(Vector<long> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> XorAcross(Vector<sbyte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> XorAcross(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> XorAcross(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> XorAcross(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ZeroExtend16(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ZeroExtend16(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ZeroExtend32(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ZeroExtend8(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ZeroExtend8(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062BD RID: 25277 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ZeroExtend8(Vector<ulong> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062BE RID: 25278 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ZeroExtendWideningLower(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062BF RID: 25279 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ZeroExtendWideningLower(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C0 RID: 25280 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ZeroExtendWideningLower(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C1 RID: 25281 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ZeroExtendWideningUpper(Vector<byte> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C2 RID: 25282 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ZeroExtendWideningUpper(Vector<ushort> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C3 RID: 25283 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ZeroExtendWideningUpper(Vector<uint> value)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ZipHigh(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ZipHigh(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C6 RID: 25286 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ZipHigh(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C7 RID: 25287 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ZipHigh(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C8 RID: 25288 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ZipHigh(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062C9 RID: 25289 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ZipHigh(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062CA RID: 25290 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ZipHigh(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ZipHigh(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ZipHigh(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ZipHigh(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062CE RID: 25294 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<byte> ZipLow(Vector<byte> left, Vector<byte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<double> ZipLow(Vector<double> left, Vector<double> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062D0 RID: 25296 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<short> ZipLow(Vector<short> left, Vector<short> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<int> ZipLow(Vector<int> left, Vector<int> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062D2 RID: 25298 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<long> ZipLow(Vector<long> left, Vector<long> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<sbyte> ZipLow(Vector<sbyte> left, Vector<sbyte> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062D4 RID: 25300 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<float> ZipLow(Vector<float> left, Vector<float> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062D5 RID: 25301 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ushort> ZipLow(Vector<ushort> left, Vector<ushort> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062D6 RID: 25302 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<uint> ZipLow(Vector<uint> left, Vector<uint> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060062D7 RID: 25303 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static Vector<ulong> ZipLow(Vector<ulong> left, Vector<ulong> right)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x02000564 RID: 1380
		public new abstract class Arm64 : AdvSimd.Arm64
		{
			// Token: 0x17000D73 RID: 3443
			// (get) Token: 0x060062D8 RID: 25304 RVA: 0x00007B65 File Offset: 0x00005D65
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
