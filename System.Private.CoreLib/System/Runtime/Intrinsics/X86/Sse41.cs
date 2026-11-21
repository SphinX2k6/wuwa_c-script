using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Runtime.Intrinsics.X86
{
	// Token: 0x02000596 RID: 1430
	[Intrinsic]
	[CLSCompliant(false)]
	public abstract class Sse41 : Ssse3
	{
		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06006DD2 RID: 28114 RVA: 0x0010A560 File Offset: 0x00108760
		public new static bool IsSupported
		{
			get
			{
				return Sse41.IsSupported;
			}
		}

		// Token: 0x06006DD3 RID: 28115 RVA: 0x0010A567 File Offset: 0x00108767
		public static Vector128<short> Blend(Vector128<short> left, Vector128<short> right, [ConstantExpected] byte control)
		{
			return Sse41.Blend(left, right, control);
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x0010A571 File Offset: 0x00108771
		public static Vector128<ushort> Blend(Vector128<ushort> left, Vector128<ushort> right, [ConstantExpected] byte control)
		{
			return Sse41.Blend(left, right, control);
		}

		// Token: 0x06006DD5 RID: 28117 RVA: 0x0010A57B File Offset: 0x0010877B
		public static Vector128<float> Blend(Vector128<float> left, Vector128<float> right, [ConstantExpected] byte control)
		{
			return Sse41.Blend(left, right, control);
		}

		// Token: 0x06006DD6 RID: 28118 RVA: 0x0010A585 File Offset: 0x00108785
		public static Vector128<double> Blend(Vector128<double> left, Vector128<double> right, [ConstantExpected] byte control)
		{
			return Sse41.Blend(left, right, control);
		}

		// Token: 0x06006DD7 RID: 28119 RVA: 0x0010A58F File Offset: 0x0010878F
		public static Vector128<sbyte> BlendVariable(Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DD8 RID: 28120 RVA: 0x0010A599 File Offset: 0x00108799
		public static Vector128<byte> BlendVariable(Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DD9 RID: 28121 RVA: 0x0010A5A3 File Offset: 0x001087A3
		public static Vector128<short> BlendVariable(Vector128<short> left, Vector128<short> right, Vector128<short> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DDA RID: 28122 RVA: 0x0010A5AD File Offset: 0x001087AD
		public static Vector128<ushort> BlendVariable(Vector128<ushort> left, Vector128<ushort> right, Vector128<ushort> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DDB RID: 28123 RVA: 0x0010A5B7 File Offset: 0x001087B7
		public static Vector128<int> BlendVariable(Vector128<int> left, Vector128<int> right, Vector128<int> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x0010A5C1 File Offset: 0x001087C1
		public static Vector128<uint> BlendVariable(Vector128<uint> left, Vector128<uint> right, Vector128<uint> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x0010A5CB File Offset: 0x001087CB
		public static Vector128<long> BlendVariable(Vector128<long> left, Vector128<long> right, Vector128<long> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x0010A5D5 File Offset: 0x001087D5
		public static Vector128<ulong> BlendVariable(Vector128<ulong> left, Vector128<ulong> right, Vector128<ulong> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x0010A5DF File Offset: 0x001087DF
		public static Vector128<float> BlendVariable(Vector128<float> left, Vector128<float> right, Vector128<float> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DE0 RID: 28128 RVA: 0x0010A5E9 File Offset: 0x001087E9
		public static Vector128<double> BlendVariable(Vector128<double> left, Vector128<double> right, Vector128<double> mask)
		{
			return Sse41.BlendVariable(left, right, mask);
		}

		// Token: 0x06006DE1 RID: 28129 RVA: 0x0010A5F3 File Offset: 0x001087F3
		public static Vector128<float> Ceiling(Vector128<float> value)
		{
			return Sse41.Ceiling(value);
		}

		// Token: 0x06006DE2 RID: 28130 RVA: 0x0010A5FB File Offset: 0x001087FB
		public static Vector128<double> Ceiling(Vector128<double> value)
		{
			return Sse41.Ceiling(value);
		}

		// Token: 0x06006DE3 RID: 28131 RVA: 0x0010A603 File Offset: 0x00108803
		public static Vector128<float> CeilingScalar(Vector128<float> value)
		{
			return Sse41.CeilingScalar(value);
		}

		// Token: 0x06006DE4 RID: 28132 RVA: 0x0010A60B File Offset: 0x0010880B
		public static Vector128<float> CeilingScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse41.CeilingScalar(upper, value);
		}

		// Token: 0x06006DE5 RID: 28133 RVA: 0x0010A614 File Offset: 0x00108814
		public static Vector128<double> CeilingScalar(Vector128<double> value)
		{
			return Sse41.CeilingScalar(value);
		}

		// Token: 0x06006DE6 RID: 28134 RVA: 0x0010A61C File Offset: 0x0010881C
		public static Vector128<double> CeilingScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse41.CeilingScalar(upper, value);
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x0010A625 File Offset: 0x00108825
		public static Vector128<long> CompareEqual(Vector128<long> left, Vector128<long> right)
		{
			return Sse41.CompareEqual(left, right);
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x0010A62E File Offset: 0x0010882E
		public static Vector128<ulong> CompareEqual(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse41.CompareEqual(left, right);
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x0010A637 File Offset: 0x00108837
		public static Vector128<short> ConvertToVector128Int16(Vector128<sbyte> value)
		{
			return Sse41.ConvertToVector128Int16(value);
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x0010A63F File Offset: 0x0010883F
		public static Vector128<short> ConvertToVector128Int16(Vector128<byte> value)
		{
			return Sse41.ConvertToVector128Int16(value);
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x0010A647 File Offset: 0x00108847
		public static Vector128<int> ConvertToVector128Int32(Vector128<sbyte> value)
		{
			return Sse41.ConvertToVector128Int32(value);
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x0010A64F File Offset: 0x0010884F
		public static Vector128<int> ConvertToVector128Int32(Vector128<byte> value)
		{
			return Sse41.ConvertToVector128Int32(value);
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x0010A657 File Offset: 0x00108857
		public static Vector128<int> ConvertToVector128Int32(Vector128<short> value)
		{
			return Sse41.ConvertToVector128Int32(value);
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x0010A65F File Offset: 0x0010885F
		public static Vector128<int> ConvertToVector128Int32(Vector128<ushort> value)
		{
			return Sse41.ConvertToVector128Int32(value);
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x0010A667 File Offset: 0x00108867
		public static Vector128<long> ConvertToVector128Int64(Vector128<sbyte> value)
		{
			return Sse41.ConvertToVector128Int64(value);
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x0010A66F File Offset: 0x0010886F
		public static Vector128<long> ConvertToVector128Int64(Vector128<byte> value)
		{
			return Sse41.ConvertToVector128Int64(value);
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x0010A677 File Offset: 0x00108877
		public static Vector128<long> ConvertToVector128Int64(Vector128<short> value)
		{
			return Sse41.ConvertToVector128Int64(value);
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x0010A67F File Offset: 0x0010887F
		public static Vector128<long> ConvertToVector128Int64(Vector128<ushort> value)
		{
			return Sse41.ConvertToVector128Int64(value);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x0010A687 File Offset: 0x00108887
		public static Vector128<long> ConvertToVector128Int64(Vector128<int> value)
		{
			return Sse41.ConvertToVector128Int64(value);
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x0010A68F File Offset: 0x0010888F
		public static Vector128<long> ConvertToVector128Int64(Vector128<uint> value)
		{
			return Sse41.ConvertToVector128Int64(value);
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x0010A697 File Offset: 0x00108897
		public unsafe static Vector128<short> ConvertToVector128Int16(sbyte* address)
		{
			return Sse41.ConvertToVector128Int16(address);
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x0010A69F File Offset: 0x0010889F
		public unsafe static Vector128<short> ConvertToVector128Int16(byte* address)
		{
			return Sse41.ConvertToVector128Int16(address);
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x0010A6A7 File Offset: 0x001088A7
		public unsafe static Vector128<int> ConvertToVector128Int32(sbyte* address)
		{
			return Sse41.ConvertToVector128Int32(address);
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x0010A6AF File Offset: 0x001088AF
		public unsafe static Vector128<int> ConvertToVector128Int32(byte* address)
		{
			return Sse41.ConvertToVector128Int32(address);
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x0010A6B7 File Offset: 0x001088B7
		public unsafe static Vector128<int> ConvertToVector128Int32(short* address)
		{
			return Sse41.ConvertToVector128Int32(address);
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x0010A6BF File Offset: 0x001088BF
		public unsafe static Vector128<int> ConvertToVector128Int32(ushort* address)
		{
			return Sse41.ConvertToVector128Int32(address);
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x0010A6C7 File Offset: 0x001088C7
		public unsafe static Vector128<long> ConvertToVector128Int64(sbyte* address)
		{
			return Sse41.ConvertToVector128Int64(address);
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x0010A6CF File Offset: 0x001088CF
		public unsafe static Vector128<long> ConvertToVector128Int64(byte* address)
		{
			return Sse41.ConvertToVector128Int64(address);
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x0010A6D7 File Offset: 0x001088D7
		public unsafe static Vector128<long> ConvertToVector128Int64(short* address)
		{
			return Sse41.ConvertToVector128Int64(address);
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x0010A6DF File Offset: 0x001088DF
		public unsafe static Vector128<long> ConvertToVector128Int64(ushort* address)
		{
			return Sse41.ConvertToVector128Int64(address);
		}

		// Token: 0x06006DFF RID: 28159 RVA: 0x0010A6E7 File Offset: 0x001088E7
		public unsafe static Vector128<long> ConvertToVector128Int64(int* address)
		{
			return Sse41.ConvertToVector128Int64(address);
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x0010A6EF File Offset: 0x001088EF
		public unsafe static Vector128<long> ConvertToVector128Int64(uint* address)
		{
			return Sse41.ConvertToVector128Int64(address);
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x0010A6F7 File Offset: 0x001088F7
		public static Vector128<float> DotProduct(Vector128<float> left, Vector128<float> right, [ConstantExpected] byte control)
		{
			return Sse41.DotProduct(left, right, control);
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x0010A701 File Offset: 0x00108901
		public static Vector128<double> DotProduct(Vector128<double> left, Vector128<double> right, [ConstantExpected] byte control)
		{
			return Sse41.DotProduct(left, right, control);
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x0010A70B File Offset: 0x0010890B
		public static byte Extract(Vector128<byte> value, [ConstantExpected] byte index)
		{
			return Sse41.Extract(value, index);
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x0010A714 File Offset: 0x00108914
		public static int Extract(Vector128<int> value, [ConstantExpected] byte index)
		{
			return Sse41.Extract(value, index);
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x0010A71D File Offset: 0x0010891D
		public static uint Extract(Vector128<uint> value, [ConstantExpected] byte index)
		{
			return Sse41.Extract(value, index);
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x0010A726 File Offset: 0x00108926
		public static float Extract(Vector128<float> value, [ConstantExpected] byte index)
		{
			return Sse41.Extract(value, index);
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x0010A72F File Offset: 0x0010892F
		public static Vector128<float> Floor(Vector128<float> value)
		{
			return Sse41.Floor(value);
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x0010A737 File Offset: 0x00108937
		public static Vector128<double> Floor(Vector128<double> value)
		{
			return Sse41.Floor(value);
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x0010A73F File Offset: 0x0010893F
		public static Vector128<float> FloorScalar(Vector128<float> value)
		{
			return Sse41.FloorScalar(value);
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x0010A747 File Offset: 0x00108947
		public static Vector128<float> FloorScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse41.FloorScalar(upper, value);
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x0010A750 File Offset: 0x00108950
		public static Vector128<double> FloorScalar(Vector128<double> value)
		{
			return Sse41.FloorScalar(value);
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x0010A758 File Offset: 0x00108958
		public static Vector128<double> FloorScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse41.FloorScalar(upper, value);
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x0010A761 File Offset: 0x00108961
		public static Vector128<sbyte> Insert(Vector128<sbyte> value, sbyte data, [ConstantExpected] byte index)
		{
			return Sse41.Insert(value, data, index);
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x0010A76B File Offset: 0x0010896B
		public static Vector128<byte> Insert(Vector128<byte> value, byte data, [ConstantExpected] byte index)
		{
			return Sse41.Insert(value, data, index);
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x0010A775 File Offset: 0x00108975
		public static Vector128<int> Insert(Vector128<int> value, int data, [ConstantExpected] byte index)
		{
			return Sse41.Insert(value, data, index);
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x0010A77F File Offset: 0x0010897F
		public static Vector128<uint> Insert(Vector128<uint> value, uint data, [ConstantExpected] byte index)
		{
			return Sse41.Insert(value, data, index);
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x0010A789 File Offset: 0x00108989
		public static Vector128<float> Insert(Vector128<float> value, Vector128<float> data, [ConstantExpected] byte index)
		{
			return Sse41.Insert(value, data, index);
		}

		// Token: 0x06006E12 RID: 28178 RVA: 0x0010A793 File Offset: 0x00108993
		public unsafe static Vector128<sbyte> LoadAlignedVector128NonTemporal(sbyte* address)
		{
			return Sse41.LoadAlignedVector128NonTemporal(address);
		}

		// Token: 0x06006E13 RID: 28179 RVA: 0x0010A79B File Offset: 0x0010899B
		public unsafe static Vector128<byte> LoadAlignedVector128NonTemporal(byte* address)
		{
			return Sse41.LoadAlignedVector128NonTemporal(address);
		}

		// Token: 0x06006E14 RID: 28180 RVA: 0x0010A7A3 File Offset: 0x001089A3
		public unsafe static Vector128<short> LoadAlignedVector128NonTemporal(short* address)
		{
			return Sse41.LoadAlignedVector128NonTemporal(address);
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x0010A7AB File Offset: 0x001089AB
		public unsafe static Vector128<ushort> LoadAlignedVector128NonTemporal(ushort* address)
		{
			return Sse41.LoadAlignedVector128NonTemporal(address);
		}

		// Token: 0x06006E16 RID: 28182 RVA: 0x0010A7B3 File Offset: 0x001089B3
		public unsafe static Vector128<int> LoadAlignedVector128NonTemporal(int* address)
		{
			return Sse41.LoadAlignedVector128NonTemporal(address);
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x0010A7BB File Offset: 0x001089BB
		public unsafe static Vector128<uint> LoadAlignedVector128NonTemporal(uint* address)
		{
			return Sse41.LoadAlignedVector128NonTemporal(address);
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x0010A7C3 File Offset: 0x001089C3
		public unsafe static Vector128<long> LoadAlignedVector128NonTemporal(long* address)
		{
			return Sse41.LoadAlignedVector128NonTemporal(address);
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x0010A7CB File Offset: 0x001089CB
		public unsafe static Vector128<ulong> LoadAlignedVector128NonTemporal(ulong* address)
		{
			return Sse41.LoadAlignedVector128NonTemporal(address);
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x0010A7D3 File Offset: 0x001089D3
		public static Vector128<sbyte> Max(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse41.Max(left, right);
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x0010A7DC File Offset: 0x001089DC
		public static Vector128<ushort> Max(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse41.Max(left, right);
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x0010A7E5 File Offset: 0x001089E5
		public static Vector128<int> Max(Vector128<int> left, Vector128<int> right)
		{
			return Sse41.Max(left, right);
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x0010A7EE File Offset: 0x001089EE
		public static Vector128<uint> Max(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse41.Max(left, right);
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x0010A7F7 File Offset: 0x001089F7
		public static Vector128<sbyte> Min(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse41.Min(left, right);
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x0010A800 File Offset: 0x00108A00
		public static Vector128<ushort> Min(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse41.Min(left, right);
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x0010A809 File Offset: 0x00108A09
		public static Vector128<int> Min(Vector128<int> left, Vector128<int> right)
		{
			return Sse41.Min(left, right);
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x0010A812 File Offset: 0x00108A12
		public static Vector128<uint> Min(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse41.Min(left, right);
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x0010A81B File Offset: 0x00108A1B
		public static Vector128<ushort> MinHorizontal(Vector128<ushort> value)
		{
			return Sse41.MinHorizontal(value);
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x0010A823 File Offset: 0x00108A23
		public static Vector128<ushort> MultipleSumAbsoluteDifferences(Vector128<byte> left, Vector128<byte> right, [ConstantExpected] byte mask)
		{
			return Sse41.MultipleSumAbsoluteDifferences(left, right, mask);
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x0010A82D File Offset: 0x00108A2D
		public static Vector128<long> Multiply(Vector128<int> left, Vector128<int> right)
		{
			return Sse41.Multiply(left, right);
		}

		// Token: 0x06006E25 RID: 28197 RVA: 0x0010A836 File Offset: 0x00108A36
		public static Vector128<int> MultiplyLow(Vector128<int> left, Vector128<int> right)
		{
			return Sse41.MultiplyLow(left, right);
		}

		// Token: 0x06006E26 RID: 28198 RVA: 0x0010A83F File Offset: 0x00108A3F
		public static Vector128<uint> MultiplyLow(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse41.MultiplyLow(left, right);
		}

		// Token: 0x06006E27 RID: 28199 RVA: 0x0010A848 File Offset: 0x00108A48
		public static Vector128<ushort> PackUnsignedSaturate(Vector128<int> left, Vector128<int> right)
		{
			return Sse41.PackUnsignedSaturate(left, right);
		}

		// Token: 0x06006E28 RID: 28200 RVA: 0x0010A851 File Offset: 0x00108A51
		public static Vector128<float> RoundCurrentDirection(Vector128<float> value)
		{
			return Sse41.RoundCurrentDirection(value);
		}

		// Token: 0x06006E29 RID: 28201 RVA: 0x0010A859 File Offset: 0x00108A59
		public static Vector128<double> RoundCurrentDirection(Vector128<double> value)
		{
			return Sse41.RoundCurrentDirection(value);
		}

		// Token: 0x06006E2A RID: 28202 RVA: 0x0010A861 File Offset: 0x00108A61
		public static Vector128<float> RoundCurrentDirectionScalar(Vector128<float> value)
		{
			return Sse41.RoundCurrentDirectionScalar(value);
		}

		// Token: 0x06006E2B RID: 28203 RVA: 0x0010A869 File Offset: 0x00108A69
		public static Vector128<float> RoundCurrentDirectionScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse41.RoundCurrentDirectionScalar(upper, value);
		}

		// Token: 0x06006E2C RID: 28204 RVA: 0x0010A872 File Offset: 0x00108A72
		public static Vector128<double> RoundCurrentDirectionScalar(Vector128<double> value)
		{
			return Sse41.RoundCurrentDirectionScalar(value);
		}

		// Token: 0x06006E2D RID: 28205 RVA: 0x0010A87A File Offset: 0x00108A7A
		public static Vector128<double> RoundCurrentDirectionScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse41.RoundCurrentDirectionScalar(upper, value);
		}

		// Token: 0x06006E2E RID: 28206 RVA: 0x0010A883 File Offset: 0x00108A83
		public static Vector128<float> RoundToNearestInteger(Vector128<float> value)
		{
			return Sse41.RoundToNearestInteger(value);
		}

		// Token: 0x06006E2F RID: 28207 RVA: 0x0010A88B File Offset: 0x00108A8B
		public static Vector128<double> RoundToNearestInteger(Vector128<double> value)
		{
			return Sse41.RoundToNearestInteger(value);
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x0010A893 File Offset: 0x00108A93
		public static Vector128<float> RoundToNearestIntegerScalar(Vector128<float> value)
		{
			return Sse41.RoundToNearestIntegerScalar(value);
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x0010A89B File Offset: 0x00108A9B
		public static Vector128<float> RoundToNearestIntegerScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse41.RoundToNearestIntegerScalar(upper, value);
		}

		// Token: 0x06006E32 RID: 28210 RVA: 0x0010A8A4 File Offset: 0x00108AA4
		public static Vector128<double> RoundToNearestIntegerScalar(Vector128<double> value)
		{
			return Sse41.RoundToNearestIntegerScalar(value);
		}

		// Token: 0x06006E33 RID: 28211 RVA: 0x0010A8AC File Offset: 0x00108AAC
		public static Vector128<double> RoundToNearestIntegerScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse41.RoundToNearestIntegerScalar(upper, value);
		}

		// Token: 0x06006E34 RID: 28212 RVA: 0x0010A8B5 File Offset: 0x00108AB5
		public static Vector128<float> RoundToNegativeInfinity(Vector128<float> value)
		{
			return Sse41.RoundToNegativeInfinity(value);
		}

		// Token: 0x06006E35 RID: 28213 RVA: 0x0010A8BD File Offset: 0x00108ABD
		public static Vector128<double> RoundToNegativeInfinity(Vector128<double> value)
		{
			return Sse41.RoundToNegativeInfinity(value);
		}

		// Token: 0x06006E36 RID: 28214 RVA: 0x0010A8C5 File Offset: 0x00108AC5
		public static Vector128<float> RoundToNegativeInfinityScalar(Vector128<float> value)
		{
			return Sse41.RoundToNegativeInfinityScalar(value);
		}

		// Token: 0x06006E37 RID: 28215 RVA: 0x0010A8CD File Offset: 0x00108ACD
		public static Vector128<float> RoundToNegativeInfinityScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse41.RoundToNegativeInfinityScalar(upper, value);
		}

		// Token: 0x06006E38 RID: 28216 RVA: 0x0010A8D6 File Offset: 0x00108AD6
		public static Vector128<double> RoundToNegativeInfinityScalar(Vector128<double> value)
		{
			return Sse41.RoundToNegativeInfinityScalar(value);
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x0010A8DE File Offset: 0x00108ADE
		public static Vector128<double> RoundToNegativeInfinityScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse41.RoundToNegativeInfinityScalar(upper, value);
		}

		// Token: 0x06006E3A RID: 28218 RVA: 0x0010A8E7 File Offset: 0x00108AE7
		public static Vector128<float> RoundToPositiveInfinity(Vector128<float> value)
		{
			return Sse41.RoundToPositiveInfinity(value);
		}

		// Token: 0x06006E3B RID: 28219 RVA: 0x0010A8EF File Offset: 0x00108AEF
		public static Vector128<double> RoundToPositiveInfinity(Vector128<double> value)
		{
			return Sse41.RoundToPositiveInfinity(value);
		}

		// Token: 0x06006E3C RID: 28220 RVA: 0x0010A8F7 File Offset: 0x00108AF7
		public static Vector128<float> RoundToPositiveInfinityScalar(Vector128<float> value)
		{
			return Sse41.RoundToPositiveInfinityScalar(value);
		}

		// Token: 0x06006E3D RID: 28221 RVA: 0x0010A8FF File Offset: 0x00108AFF
		public static Vector128<float> RoundToPositiveInfinityScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse41.RoundToPositiveInfinityScalar(upper, value);
		}

		// Token: 0x06006E3E RID: 28222 RVA: 0x0010A908 File Offset: 0x00108B08
		public static Vector128<double> RoundToPositiveInfinityScalar(Vector128<double> value)
		{
			return Sse41.RoundToPositiveInfinityScalar(value);
		}

		// Token: 0x06006E3F RID: 28223 RVA: 0x0010A910 File Offset: 0x00108B10
		public static Vector128<double> RoundToPositiveInfinityScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse41.RoundToPositiveInfinityScalar(upper, value);
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x0010A919 File Offset: 0x00108B19
		public static Vector128<float> RoundToZero(Vector128<float> value)
		{
			return Sse41.RoundToZero(value);
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x0010A921 File Offset: 0x00108B21
		public static Vector128<double> RoundToZero(Vector128<double> value)
		{
			return Sse41.RoundToZero(value);
		}

		// Token: 0x06006E42 RID: 28226 RVA: 0x0010A929 File Offset: 0x00108B29
		public static Vector128<float> RoundToZeroScalar(Vector128<float> value)
		{
			return Sse41.RoundToZeroScalar(value);
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x0010A931 File Offset: 0x00108B31
		public static Vector128<float> RoundToZeroScalar(Vector128<float> upper, Vector128<float> value)
		{
			return Sse41.RoundToZeroScalar(upper, value);
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x0010A93A File Offset: 0x00108B3A
		public static Vector128<double> RoundToZeroScalar(Vector128<double> value)
		{
			return Sse41.RoundToZeroScalar(value);
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x0010A942 File Offset: 0x00108B42
		public static Vector128<double> RoundToZeroScalar(Vector128<double> upper, Vector128<double> value)
		{
			return Sse41.RoundToZeroScalar(upper, value);
		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x0010A94B File Offset: 0x00108B4B
		public static bool TestC(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse41.TestC(left, right);
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x0010A954 File Offset: 0x00108B54
		public static bool TestC(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse41.TestC(left, right);
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x0010A95D File Offset: 0x00108B5D
		public static bool TestC(Vector128<short> left, Vector128<short> right)
		{
			return Sse41.TestC(left, right);
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x0010A966 File Offset: 0x00108B66
		public static bool TestC(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse41.TestC(left, right);
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x0010A96F File Offset: 0x00108B6F
		public static bool TestC(Vector128<int> left, Vector128<int> right)
		{
			return Sse41.TestC(left, right);
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x0010A978 File Offset: 0x00108B78
		public static bool TestC(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse41.TestC(left, right);
		}

		// Token: 0x06006E4C RID: 28236 RVA: 0x0010A981 File Offset: 0x00108B81
		public static bool TestC(Vector128<long> left, Vector128<long> right)
		{
			return Sse41.TestC(left, right);
		}

		// Token: 0x06006E4D RID: 28237 RVA: 0x0010A98A File Offset: 0x00108B8A
		public static bool TestC(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse41.TestC(left, right);
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x0010A993 File Offset: 0x00108B93
		public static bool TestNotZAndNotC(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse41.TestNotZAndNotC(left, right);
		}

		// Token: 0x06006E4F RID: 28239 RVA: 0x0010A99C File Offset: 0x00108B9C
		public static bool TestNotZAndNotC(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse41.TestNotZAndNotC(left, right);
		}

		// Token: 0x06006E50 RID: 28240 RVA: 0x0010A9A5 File Offset: 0x00108BA5
		public static bool TestNotZAndNotC(Vector128<short> left, Vector128<short> right)
		{
			return Sse41.TestNotZAndNotC(left, right);
		}

		// Token: 0x06006E51 RID: 28241 RVA: 0x0010A9AE File Offset: 0x00108BAE
		public static bool TestNotZAndNotC(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse41.TestNotZAndNotC(left, right);
		}

		// Token: 0x06006E52 RID: 28242 RVA: 0x0010A9B7 File Offset: 0x00108BB7
		public static bool TestNotZAndNotC(Vector128<int> left, Vector128<int> right)
		{
			return Sse41.TestNotZAndNotC(left, right);
		}

		// Token: 0x06006E53 RID: 28243 RVA: 0x0010A9C0 File Offset: 0x00108BC0
		public static bool TestNotZAndNotC(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse41.TestNotZAndNotC(left, right);
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x0010A9C9 File Offset: 0x00108BC9
		public static bool TestNotZAndNotC(Vector128<long> left, Vector128<long> right)
		{
			return Sse41.TestNotZAndNotC(left, right);
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x0010A9D2 File Offset: 0x00108BD2
		public static bool TestNotZAndNotC(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse41.TestNotZAndNotC(left, right);
		}

		// Token: 0x06006E56 RID: 28246 RVA: 0x0010A9DB File Offset: 0x00108BDB
		public static bool TestZ(Vector128<sbyte> left, Vector128<sbyte> right)
		{
			return Sse41.TestZ(left, right);
		}

		// Token: 0x06006E57 RID: 28247 RVA: 0x0010A9E4 File Offset: 0x00108BE4
		public static bool TestZ(Vector128<byte> left, Vector128<byte> right)
		{
			return Sse41.TestZ(left, right);
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x0010A9ED File Offset: 0x00108BED
		public static bool TestZ(Vector128<short> left, Vector128<short> right)
		{
			return Sse41.TestZ(left, right);
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x0010A9F6 File Offset: 0x00108BF6
		public static bool TestZ(Vector128<ushort> left, Vector128<ushort> right)
		{
			return Sse41.TestZ(left, right);
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x0010A9FF File Offset: 0x00108BFF
		public static bool TestZ(Vector128<int> left, Vector128<int> right)
		{
			return Sse41.TestZ(left, right);
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x0010AA08 File Offset: 0x00108C08
		public static bool TestZ(Vector128<uint> left, Vector128<uint> right)
		{
			return Sse41.TestZ(left, right);
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x0010AA11 File Offset: 0x00108C11
		public static bool TestZ(Vector128<long> left, Vector128<long> right)
		{
			return Sse41.TestZ(left, right);
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x0010AA1A File Offset: 0x00108C1A
		public static bool TestZ(Vector128<ulong> left, Vector128<ulong> right)
		{
			return Sse41.TestZ(left, right);
		}

		// Token: 0x02000597 RID: 1431
		[Intrinsic]
		public new abstract class X64 : Ssse3.X64
		{
			// Token: 0x17000DA4 RID: 3492
			// (get) Token: 0x06006E5E RID: 28254 RVA: 0x0010AA23 File Offset: 0x00108C23
			public new static bool IsSupported
			{
				get
				{
					return Sse41.X64.IsSupported;
				}
			}

			// Token: 0x06006E5F RID: 28255 RVA: 0x0010AA2A File Offset: 0x00108C2A
			public static long Extract(Vector128<long> value, [ConstantExpected] byte index)
			{
				return Sse41.X64.Extract(value, index);
			}

			// Token: 0x06006E60 RID: 28256 RVA: 0x0010AA33 File Offset: 0x00108C33
			public static ulong Extract(Vector128<ulong> value, [ConstantExpected] byte index)
			{
				return Sse41.X64.Extract(value, index);
			}

			// Token: 0x06006E61 RID: 28257 RVA: 0x0010AA3C File Offset: 0x00108C3C
			public static Vector128<long> Insert(Vector128<long> value, long data, [ConstantExpected] byte index)
			{
				return Sse41.X64.Insert(value, data, index);
			}

			// Token: 0x06006E62 RID: 28258 RVA: 0x0010AA46 File Offset: 0x00108C46
			public static Vector128<ulong> Insert(Vector128<ulong> value, ulong data, [ConstantExpected] byte index)
			{
				return Sse41.X64.Insert(value, data, index);
			}
		}
	}
}
