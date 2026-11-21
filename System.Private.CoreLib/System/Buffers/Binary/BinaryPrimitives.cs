using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System.Buffers.Binary
{
	// Token: 0x020003B4 RID: 948
	public static class BinaryPrimitives
	{
		// Token: 0x06003DD2 RID: 15826 RVA: 0x000D1AFE File Offset: 0x000CFCFE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ReadDoubleBigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BitConverter.Int64BitsToDouble(BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<long>(source)));
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x000D1B17 File Offset: 0x000CFD17
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Half ReadHalfBigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BitConverter.Int16BitsToHalf(BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<short>(source)));
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x000D1B30 File Offset: 0x000CFD30
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ReadInt16BigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<short>(source));
		}

		// Token: 0x06003DD5 RID: 15829 RVA: 0x000D1B44 File Offset: 0x000CFD44
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ReadInt32BigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<int>(source));
		}

		// Token: 0x06003DD6 RID: 15830 RVA: 0x000D1B58 File Offset: 0x000CFD58
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ReadInt64BigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<long>(source));
		}

		// Token: 0x06003DD7 RID: 15831 RVA: 0x000D1B6C File Offset: 0x000CFD6C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int128 ReadInt128BigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<Int128>(source));
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x000D1B80 File Offset: 0x000CFD80
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr ReadIntPtrBigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<IntPtr>(source));
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x000D1B94 File Offset: 0x000CFD94
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ReadSingleBigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BitConverter.Int32BitsToSingle(BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<int>(source)));
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x000D1BAD File Offset: 0x000CFDAD
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ReadUInt16BigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<ushort>(source));
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x000D1BC1 File Offset: 0x000CFDC1
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ReadUInt32BigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<uint>(source));
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x000D1BD5 File Offset: 0x000CFDD5
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ReadUInt64BigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<ulong>(source));
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x000D1BE9 File Offset: 0x000CFDE9
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt128 ReadUInt128BigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<UInt128>(source));
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x000D1BFD File Offset: 0x000CFDFD
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr ReadUIntPtrBigEndian(ReadOnlySpan<byte> source)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return BinaryPrimitives.ReverseEndianness(MemoryMarshal.Read<UIntPtr>(source));
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x000D1C14 File Offset: 0x000CFE14
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadDoubleBigEndian(ReadOnlySpan<byte> source, out double value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			long value2;
			bool result = MemoryMarshal.TryRead<long>(source, out value2);
			value = BitConverter.Int64BitsToDouble(BinaryPrimitives.ReverseEndianness(value2));
			return result;
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x000D1C3C File Offset: 0x000CFE3C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadHalfBigEndian(ReadOnlySpan<byte> source, out Half value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			short value2;
			bool result = MemoryMarshal.TryRead<short>(source, out value2);
			value = BitConverter.Int16BitsToHalf(BinaryPrimitives.ReverseEndianness(value2));
			return result;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x000D1C68 File Offset: 0x000CFE68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadInt16BigEndian(ReadOnlySpan<byte> source, out short value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			short value2;
			bool result = MemoryMarshal.TryRead<short>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x000D1C8C File Offset: 0x000CFE8C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadInt32BigEndian(ReadOnlySpan<byte> source, out int value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			int value2;
			bool result = MemoryMarshal.TryRead<int>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DE3 RID: 15843 RVA: 0x000D1CB0 File Offset: 0x000CFEB0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadInt64BigEndian(ReadOnlySpan<byte> source, out long value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			long value2;
			bool result = MemoryMarshal.TryRead<long>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DE4 RID: 15844 RVA: 0x000D1CD4 File Offset: 0x000CFED4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadInt128BigEndian(ReadOnlySpan<byte> source, out Int128 value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			Int128 value2;
			bool result = MemoryMarshal.TryRead<Int128>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DE5 RID: 15845 RVA: 0x000D1CFC File Offset: 0x000CFEFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadIntPtrBigEndian(ReadOnlySpan<byte> source, out IntPtr value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			IntPtr value2;
			bool result = MemoryMarshal.TryRead<IntPtr>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DE6 RID: 15846 RVA: 0x000D1D20 File Offset: 0x000CFF20
		public static bool TryReadSingleBigEndian(ReadOnlySpan<byte> source, out float value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			int value2;
			bool result = MemoryMarshal.TryRead<int>(source, out value2);
			value = BitConverter.Int32BitsToSingle(BinaryPrimitives.ReverseEndianness(value2));
			return result;
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x000D1D48 File Offset: 0x000CFF48
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUInt16BigEndian(ReadOnlySpan<byte> source, out ushort value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			ushort value2;
			bool result = MemoryMarshal.TryRead<ushort>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x000D1D6C File Offset: 0x000CFF6C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUInt32BigEndian(ReadOnlySpan<byte> source, out uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			uint value2;
			bool result = MemoryMarshal.TryRead<uint>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x000D1D90 File Offset: 0x000CFF90
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUInt64BigEndian(ReadOnlySpan<byte> source, out ulong value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			ulong value2;
			bool result = MemoryMarshal.TryRead<ulong>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x000D1DB4 File Offset: 0x000CFFB4
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUInt128BigEndian(ReadOnlySpan<byte> source, out UInt128 value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			UInt128 value2;
			bool result = MemoryMarshal.TryRead<UInt128>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x000D1DDC File Offset: 0x000CFFDC
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUIntPtrBigEndian(ReadOnlySpan<byte> source, out UIntPtr value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			UIntPtr value2;
			bool result = MemoryMarshal.TryRead<UIntPtr>(source, out value2);
			value = BinaryPrimitives.ReverseEndianness(value2);
			return result;
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x000D1DFF File Offset: 0x000CFFFF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ReadDoubleLittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<double>(source);
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x000D1E0D File Offset: 0x000D000D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Half ReadHalfLittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<Half>(source);
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x000D1E1B File Offset: 0x000D001B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ReadInt16LittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<short>(source);
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x000D1E29 File Offset: 0x000D0029
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ReadInt32LittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<int>(source);
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x000D1E37 File Offset: 0x000D0037
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ReadInt64LittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<long>(source);
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x000D1E45 File Offset: 0x000D0045
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int128 ReadInt128LittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<Int128>(source);
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x000D1E53 File Offset: 0x000D0053
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr ReadIntPtrLittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<IntPtr>(source);
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x000D1E61 File Offset: 0x000D0061
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ReadSingleLittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<float>(source);
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x000D1E6F File Offset: 0x000D006F
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ReadUInt16LittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<ushort>(source);
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x000D1E7D File Offset: 0x000D007D
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ReadUInt32LittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<uint>(source);
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x000D1E8B File Offset: 0x000D008B
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ReadUInt64LittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<ulong>(source);
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x000D1E99 File Offset: 0x000D0099
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt128 ReadUInt128LittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<UInt128>(source);
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x000D1EA7 File Offset: 0x000D00A7
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr ReadUIntPtrLittleEndian(ReadOnlySpan<byte> source)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.Read<UIntPtr>(source);
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x000D1EB5 File Offset: 0x000D00B5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadDoubleLittleEndian(ReadOnlySpan<byte> source, out double value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryRead<double>(source, out value);
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x000D1EC5 File Offset: 0x000D00C5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadHalfLittleEndian(ReadOnlySpan<byte> source, out Half value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryRead<Half>(source, out value);
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x000D1ED5 File Offset: 0x000D00D5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadInt16LittleEndian(ReadOnlySpan<byte> source, out short value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<short>(source, out value);
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x000D1EE4 File Offset: 0x000D00E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadInt32LittleEndian(ReadOnlySpan<byte> source, out int value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<int>(source, out value);
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x000D1EF3 File Offset: 0x000D00F3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadInt64LittleEndian(ReadOnlySpan<byte> source, out long value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<long>(source, out value);
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x000D1F02 File Offset: 0x000D0102
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadInt128LittleEndian(ReadOnlySpan<byte> source, out Int128 value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<Int128>(source, out value);
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x000D1F11 File Offset: 0x000D0111
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadIntPtrLittleEndian(ReadOnlySpan<byte> source, out IntPtr value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<IntPtr>(source, out value);
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x000D1F20 File Offset: 0x000D0120
		public static bool TryReadSingleLittleEndian(ReadOnlySpan<byte> source, out float value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryRead<float>(source, out value);
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x000D1F30 File Offset: 0x000D0130
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUInt16LittleEndian(ReadOnlySpan<byte> source, out ushort value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<ushort>(source, out value);
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x000D1F3F File Offset: 0x000D013F
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUInt32LittleEndian(ReadOnlySpan<byte> source, out uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<uint>(source, out value);
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x000D1F4E File Offset: 0x000D014E
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUInt64LittleEndian(ReadOnlySpan<byte> source, out ulong value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<ulong>(source, out value);
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x000D1F5D File Offset: 0x000D015D
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUInt128LittleEndian(ReadOnlySpan<byte> source, out UInt128 value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<UInt128>(source, out value);
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x000D1F6C File Offset: 0x000D016C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryReadUIntPtrLittleEndian(ReadOnlySpan<byte> source, out UIntPtr value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return MemoryMarshal.TryRead<UIntPtr>(source, out value);
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x00007B62 File Offset: 0x00005D62
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static sbyte ReverseEndianness(sbyte value)
		{
			return value;
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x000D1F7B File Offset: 0x000D017B
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ReverseEndianness(short value)
		{
			return (short)BinaryPrimitives.ReverseEndianness((ushort)value);
		}

		// Token: 0x06003E08 RID: 15880 RVA: 0x000D1F85 File Offset: 0x000D0185
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ReverseEndianness(int value)
		{
			return (int)BinaryPrimitives.ReverseEndianness((uint)value);
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x000D1F8D File Offset: 0x000D018D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ReverseEndianness(long value)
		{
			return (long)BinaryPrimitives.ReverseEndianness((ulong)value);
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x000D1F95 File Offset: 0x000D0195
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static IntPtr ReverseEndianness(IntPtr value)
		{
			return (IntPtr)BinaryPrimitives.ReverseEndianness((long)value);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x000D1F9F File Offset: 0x000D019F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int128 ReverseEndianness(Int128 value)
		{
			return new Int128(BinaryPrimitives.ReverseEndianness(value.Lower), BinaryPrimitives.ReverseEndianness(value.Upper));
		}

		// Token: 0x06003E0C RID: 15884 RVA: 0x00007B62 File Offset: 0x00005D62
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte ReverseEndianness(byte value)
		{
			return value;
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x000D1FBE File Offset: 0x000D01BE
		[CLSCompliant(false)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ReverseEndianness(ushort value)
		{
			return (ushort)((value >> 8) + ((int)value << 8));
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x000D1FC8 File Offset: 0x000D01C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static char ReverseEndianness(char value)
		{
			return (char)BinaryPrimitives.ReverseEndianness((ushort)value);
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x000D1FD0 File Offset: 0x000D01D0
		[CLSCompliant(false)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ReverseEndianness(uint value)
		{
			return BitOperations.RotateRight(value & 16711935U, 8) + BitOperations.RotateLeft(value & 4278255360U, 8);
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x000D1FED File Offset: 0x000D01ED
		[CLSCompliant(false)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ReverseEndianness(ulong value)
		{
			return ((ulong)BinaryPrimitives.ReverseEndianness((uint)value) << 32) + (ulong)BinaryPrimitives.ReverseEndianness((uint)(value >> 32));
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x000D2006 File Offset: 0x000D0206
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr ReverseEndianness(UIntPtr value)
		{
			return (UIntPtr)BinaryPrimitives.ReverseEndianness((ulong)value);
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x000D2010 File Offset: 0x000D0210
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt128 ReverseEndianness(UInt128 value)
		{
			return new UInt128(BinaryPrimitives.ReverseEndianness(value.Lower), BinaryPrimitives.ReverseEndianness(value.Upper));
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x000D202F File Offset: 0x000D022F
		[CLSCompliant(false)]
		public static void ReverseEndianness(ReadOnlySpan<ushort> source, Span<ushort> destination)
		{
			BinaryPrimitives.ReverseEndianness<short, BinaryPrimitives.Int16EndiannessReverser>(MemoryMarshal.Cast<ushort, short>(source), MemoryMarshal.Cast<ushort, short>(destination));
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x000D2042 File Offset: 0x000D0242
		public static void ReverseEndianness(ReadOnlySpan<short> source, Span<short> destination)
		{
			BinaryPrimitives.ReverseEndianness<short, BinaryPrimitives.Int16EndiannessReverser>(source, destination);
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x000D204B File Offset: 0x000D024B
		[CLSCompliant(false)]
		public static void ReverseEndianness(ReadOnlySpan<uint> source, Span<uint> destination)
		{
			BinaryPrimitives.ReverseEndianness<int, BinaryPrimitives.Int32EndiannessReverser>(MemoryMarshal.Cast<uint, int>(source), MemoryMarshal.Cast<uint, int>(destination));
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x000D205E File Offset: 0x000D025E
		public static void ReverseEndianness(ReadOnlySpan<int> source, Span<int> destination)
		{
			BinaryPrimitives.ReverseEndianness<int, BinaryPrimitives.Int32EndiannessReverser>(source, destination);
		}

		// Token: 0x06003E17 RID: 15895 RVA: 0x000D2067 File Offset: 0x000D0267
		[CLSCompliant(false)]
		public static void ReverseEndianness(ReadOnlySpan<ulong> source, Span<ulong> destination)
		{
			BinaryPrimitives.ReverseEndianness<long, BinaryPrimitives.Int64EndiannessReverser>(MemoryMarshal.Cast<ulong, long>(source), MemoryMarshal.Cast<ulong, long>(destination));
		}

		// Token: 0x06003E18 RID: 15896 RVA: 0x000D207A File Offset: 0x000D027A
		public static void ReverseEndianness(ReadOnlySpan<long> source, Span<long> destination)
		{
			BinaryPrimitives.ReverseEndianness<long, BinaryPrimitives.Int64EndiannessReverser>(source, destination);
		}

		// Token: 0x06003E19 RID: 15897 RVA: 0x000D2083 File Offset: 0x000D0283
		[CLSCompliant(false)]
		public static void ReverseEndianness(ReadOnlySpan<UIntPtr> source, Span<UIntPtr> destination)
		{
			BinaryPrimitives.ReverseEndianness<long, BinaryPrimitives.Int64EndiannessReverser>(MemoryMarshal.Cast<UIntPtr, long>(source), MemoryMarshal.Cast<UIntPtr, long>(destination));
		}

		// Token: 0x06003E1A RID: 15898 RVA: 0x000D2096 File Offset: 0x000D0296
		public static void ReverseEndianness(ReadOnlySpan<IntPtr> source, Span<IntPtr> destination)
		{
			BinaryPrimitives.ReverseEndianness<long, BinaryPrimitives.Int64EndiannessReverser>(MemoryMarshal.Cast<IntPtr, long>(source), MemoryMarshal.Cast<IntPtr, long>(destination));
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x000D20AC File Offset: 0x000D02AC
		private unsafe static void ReverseEndianness<T, TReverser>(ReadOnlySpan<T> source, Span<T> destination) where T : struct where TReverser : BinaryPrimitives.IEndiannessReverser<T>
		{
			if (destination.Length < source.Length)
			{
				BinaryPrimitives.ThrowDestinationTooSmall();
			}
			ref T reference = ref MemoryMarshal.GetReference<T>(source);
			ref T reference2 = ref MemoryMarshal.GetReference<T>(destination);
			int num;
			if (Unsafe.AreSame<T>(ref reference, ref reference2) || !source.Overlaps(destination, out num) || num < 0)
			{
				int i = 0;
				if (false)
				{
				}
				if (Vector128.IsHardwareAccelerated)
				{
					while (i <= source.Length - Vector128<T>.Count)
					{
						BinaryPrimitives.IEndiannessReverser<T>.Reverse(Vector128.LoadUnsafe<T>(ref reference, (UIntPtr)i)).StoreUnsafe(ref reference2, (UIntPtr)i);
						i += Vector128<T>.Count;
					}
				}
				while (i < source.Length)
				{
					*Unsafe.Add<T>(ref reference2, i) = BinaryPrimitives.IEndiannessReverser<T>.Reverse(*Unsafe.Add<T>(ref reference, i));
					i++;
				}
				return;
			}
			int j = source.Length;
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated)
			{
				while (j >= Vector128<T>.Count)
				{
					j -= Vector128<T>.Count;
					BinaryPrimitives.IEndiannessReverser<T>.Reverse(Vector128.LoadUnsafe<T>(ref reference, (UIntPtr)j)).StoreUnsafe(ref reference2, (UIntPtr)j);
				}
			}
			while (j > 0)
			{
				j--;
				*Unsafe.Add<T>(ref reference2, j) = BinaryPrimitives.IEndiannessReverser<T>.Reverse(*Unsafe.Add<T>(ref reference, j));
			}
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x000D21E8 File Offset: 0x000D03E8
		[CLSCompliant(false)]
		public static void ReverseEndianness(ReadOnlySpan<UInt128> source, Span<UInt128> destination)
		{
			BinaryPrimitives.ReverseEndianness(MemoryMarshal.Cast<UInt128, Int128>(source), MemoryMarshal.Cast<UInt128, Int128>(destination));
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x000D21FC File Offset: 0x000D03FC
		public unsafe static void ReverseEndianness(ReadOnlySpan<Int128> source, Span<Int128> destination)
		{
			if (destination.Length < source.Length)
			{
				BinaryPrimitives.ThrowDestinationTooSmall();
			}
			int num;
			if (Unsafe.AreSame<Int128>(MemoryMarshal.GetReference<Int128>(source), MemoryMarshal.GetReference<Int128>(destination)) || !source.Overlaps(destination, out num) || num < 0)
			{
				for (int i = 0; i < source.Length; i++)
				{
					*destination[i] = BinaryPrimitives.ReverseEndianness(*source[i]);
				}
				return;
			}
			for (int j = source.Length - 1; j >= 0; j--)
			{
				*destination[j] = BinaryPrimitives.ReverseEndianness(*source[j]);
			}
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x000D22AA File Offset: 0x000D04AA
		[DoesNotReturn]
		private static void ThrowDestinationTooSmall()
		{
			throw new ArgumentException(SR.Arg_BufferTooSmall, "destination");
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x000D22BC File Offset: 0x000D04BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteDoubleBigEndian(Span<byte> destination, double value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			long num = BinaryPrimitives.ReverseEndianness(BitConverter.DoubleToInt64Bits(value));
			MemoryMarshal.Write<long>(destination, num);
		}

		// Token: 0x06003E20 RID: 15904 RVA: 0x000D22E4 File Offset: 0x000D04E4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteHalfBigEndian(Span<byte> destination, Half value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			short num = BinaryPrimitives.ReverseEndianness(BitConverter.HalfToInt16Bits(value));
			MemoryMarshal.Write<short>(destination, num);
		}

		// Token: 0x06003E21 RID: 15905 RVA: 0x000D230C File Offset: 0x000D050C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteInt16BigEndian(Span<byte> destination, short value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			short num = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<short>(destination, num);
		}

		// Token: 0x06003E22 RID: 15906 RVA: 0x000D2330 File Offset: 0x000D0530
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteInt32BigEndian(Span<byte> destination, int value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			int num = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<int>(destination, num);
		}

		// Token: 0x06003E23 RID: 15907 RVA: 0x000D2354 File Offset: 0x000D0554
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteInt64BigEndian(Span<byte> destination, long value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			long num = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<long>(destination, num);
		}

		// Token: 0x06003E24 RID: 15908 RVA: 0x000D2378 File Offset: 0x000D0578
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteInt128BigEndian(Span<byte> destination, Int128 value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			Int128 @int = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<Int128>(destination, @int);
		}

		// Token: 0x06003E25 RID: 15909 RVA: 0x000D239C File Offset: 0x000D059C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteIntPtrBigEndian(Span<byte> destination, IntPtr value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			IntPtr intPtr = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<IntPtr>(destination, intPtr);
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x000D23C0 File Offset: 0x000D05C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteSingleBigEndian(Span<byte> destination, float value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			int num = BinaryPrimitives.ReverseEndianness(BitConverter.SingleToInt32Bits(value));
			MemoryMarshal.Write<int>(destination, num);
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x000D23E8 File Offset: 0x000D05E8
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt16BigEndian(Span<byte> destination, ushort value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			ushort num = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<ushort>(destination, num);
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x000D240C File Offset: 0x000D060C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt32BigEndian(Span<byte> destination, uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			uint num = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<uint>(destination, num);
		}

		// Token: 0x06003E29 RID: 15913 RVA: 0x000D2430 File Offset: 0x000D0630
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt64BigEndian(Span<byte> destination, ulong value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			ulong num = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<ulong>(destination, num);
		}

		// Token: 0x06003E2A RID: 15914 RVA: 0x000D2454 File Offset: 0x000D0654
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt128BigEndian(Span<byte> destination, UInt128 value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			UInt128 @uint = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<UInt128>(destination, @uint);
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x000D2478 File Offset: 0x000D0678
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUIntPtrBigEndian(Span<byte> destination, UIntPtr value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			UIntPtr uintPtr = BinaryPrimitives.ReverseEndianness(value);
			MemoryMarshal.Write<UIntPtr>(destination, uintPtr);
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x000D249C File Offset: 0x000D069C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteDoubleBigEndian(Span<byte> destination, double value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			long num = BinaryPrimitives.ReverseEndianness(BitConverter.DoubleToInt64Bits(value));
			return MemoryMarshal.TryWrite<long>(destination, num);
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x000D24C4 File Offset: 0x000D06C4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteHalfBigEndian(Span<byte> destination, Half value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			short num = BinaryPrimitives.ReverseEndianness(BitConverter.HalfToInt16Bits(value));
			return MemoryMarshal.TryWrite<short>(destination, num);
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x000D24EC File Offset: 0x000D06EC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteInt16BigEndian(Span<byte> destination, short value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			short num = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<short>(destination, num);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x000D2510 File Offset: 0x000D0710
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteInt32BigEndian(Span<byte> destination, int value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			int num = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<int>(destination, num);
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x000D2534 File Offset: 0x000D0734
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteInt64BigEndian(Span<byte> destination, long value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			long num = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<long>(destination, num);
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x000D2558 File Offset: 0x000D0758
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteInt128BigEndian(Span<byte> destination, Int128 value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			Int128 @int = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<Int128>(destination, @int);
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x000D257C File Offset: 0x000D077C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteIntPtrBigEndian(Span<byte> destination, IntPtr value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			IntPtr intPtr = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<IntPtr>(destination, intPtr);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x000D25A0 File Offset: 0x000D07A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteSingleBigEndian(Span<byte> destination, float value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			int num = BinaryPrimitives.ReverseEndianness(BitConverter.SingleToInt32Bits(value));
			return MemoryMarshal.TryWrite<int>(destination, num);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x000D25C8 File Offset: 0x000D07C8
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUInt16BigEndian(Span<byte> destination, ushort value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			ushort num = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<ushort>(destination, num);
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x000D25EC File Offset: 0x000D07EC
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUInt32BigEndian(Span<byte> destination, uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			uint num = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<uint>(destination, num);
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x000D2610 File Offset: 0x000D0810
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUInt64BigEndian(Span<byte> destination, ulong value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			ulong num = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<ulong>(destination, num);
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x000D2634 File Offset: 0x000D0834
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUInt128BigEndian(Span<byte> destination, UInt128 value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			UInt128 @uint = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<UInt128>(destination, @uint);
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x000D2658 File Offset: 0x000D0858
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUIntPtrBigEndian(Span<byte> destination, UIntPtr value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			UIntPtr uintPtr = BinaryPrimitives.ReverseEndianness(value);
			return MemoryMarshal.TryWrite<UIntPtr>(destination, uintPtr);
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x000D267A File Offset: 0x000D087A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteDoubleLittleEndian(Span<byte> destination, double value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<double>(destination, value);
		}

		// Token: 0x06003E3A RID: 15930 RVA: 0x000D268B File Offset: 0x000D088B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteHalfLittleEndian(Span<byte> destination, Half value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<Half>(destination, value);
		}

		// Token: 0x06003E3B RID: 15931 RVA: 0x000D269C File Offset: 0x000D089C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteInt16LittleEndian(Span<byte> destination, short value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<short>(destination, value);
		}

		// Token: 0x06003E3C RID: 15932 RVA: 0x000D26AD File Offset: 0x000D08AD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteInt32LittleEndian(Span<byte> destination, int value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<int>(destination, value);
		}

		// Token: 0x06003E3D RID: 15933 RVA: 0x000D26BE File Offset: 0x000D08BE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteInt64LittleEndian(Span<byte> destination, long value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<long>(destination, value);
		}

		// Token: 0x06003E3E RID: 15934 RVA: 0x000D26CF File Offset: 0x000D08CF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteInt128LittleEndian(Span<byte> destination, Int128 value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<Int128>(destination, value);
		}

		// Token: 0x06003E3F RID: 15935 RVA: 0x000D26E0 File Offset: 0x000D08E0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteIntPtrLittleEndian(Span<byte> destination, IntPtr value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<IntPtr>(destination, value);
		}

		// Token: 0x06003E40 RID: 15936 RVA: 0x000D26F1 File Offset: 0x000D08F1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteSingleLittleEndian(Span<byte> destination, float value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<float>(destination, value);
		}

		// Token: 0x06003E41 RID: 15937 RVA: 0x000D2702 File Offset: 0x000D0902
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt16LittleEndian(Span<byte> destination, ushort value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<ushort>(destination, value);
		}

		// Token: 0x06003E42 RID: 15938 RVA: 0x000D2713 File Offset: 0x000D0913
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt32LittleEndian(Span<byte> destination, uint value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<uint>(destination, value);
		}

		// Token: 0x06003E43 RID: 15939 RVA: 0x000D2724 File Offset: 0x000D0924
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt64LittleEndian(Span<byte> destination, ulong value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<ulong>(destination, value);
		}

		// Token: 0x06003E44 RID: 15940 RVA: 0x000D2735 File Offset: 0x000D0935
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt128LittleEndian(Span<byte> destination, UInt128 value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<UInt128>(destination, value);
		}

		// Token: 0x06003E45 RID: 15941 RVA: 0x000D2746 File Offset: 0x000D0946
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUIntPtrLittleEndian(Span<byte> destination, UIntPtr value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			MemoryMarshal.Write<UIntPtr>(destination, value);
		}

		// Token: 0x06003E46 RID: 15942 RVA: 0x000D2757 File Offset: 0x000D0957
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteDoubleLittleEndian(Span<byte> destination, double value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<double>(destination, value);
		}

		// Token: 0x06003E47 RID: 15943 RVA: 0x000D2768 File Offset: 0x000D0968
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteHalfLittleEndian(Span<byte> destination, Half value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<Half>(destination, value);
		}

		// Token: 0x06003E48 RID: 15944 RVA: 0x000D2779 File Offset: 0x000D0979
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteInt16LittleEndian(Span<byte> destination, short value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<short>(destination, value);
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x000D278A File Offset: 0x000D098A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteInt32LittleEndian(Span<byte> destination, int value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<int>(destination, value);
		}

		// Token: 0x06003E4A RID: 15946 RVA: 0x000D279B File Offset: 0x000D099B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteInt64LittleEndian(Span<byte> destination, long value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<long>(destination, value);
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x000D27AC File Offset: 0x000D09AC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteInt128LittleEndian(Span<byte> destination, Int128 value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<Int128>(destination, value);
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x000D27BD File Offset: 0x000D09BD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteIntPtrLittleEndian(Span<byte> destination, IntPtr value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<IntPtr>(destination, value);
		}

		// Token: 0x06003E4D RID: 15949 RVA: 0x000D27CE File Offset: 0x000D09CE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteSingleLittleEndian(Span<byte> destination, float value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<float>(destination, value);
		}

		// Token: 0x06003E4E RID: 15950 RVA: 0x000D27DF File Offset: 0x000D09DF
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUInt16LittleEndian(Span<byte> destination, ushort value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<ushort>(destination, value);
		}

		// Token: 0x06003E4F RID: 15951 RVA: 0x000D27F0 File Offset: 0x000D09F0
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUInt32LittleEndian(Span<byte> destination, uint value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<uint>(destination, value);
		}

		// Token: 0x06003E50 RID: 15952 RVA: 0x000D2801 File Offset: 0x000D0A01
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUInt64LittleEndian(Span<byte> destination, ulong value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<ulong>(destination, value);
		}

		// Token: 0x06003E51 RID: 15953 RVA: 0x000D2812 File Offset: 0x000D0A12
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUInt128LittleEndian(Span<byte> destination, UInt128 value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<UInt128>(destination, value);
		}

		// Token: 0x06003E52 RID: 15954 RVA: 0x000D2823 File Offset: 0x000D0A23
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryWriteUIntPtrLittleEndian(Span<byte> destination, UIntPtr value)
		{
			if (!BitConverter.IsLittleEndian)
			{
			}
			return MemoryMarshal.TryWrite<UIntPtr>(destination, value);
		}

		// Token: 0x020003B5 RID: 949
		private readonly struct Int16EndiannessReverser : BinaryPrimitives.IEndiannessReverser<short>
		{
			// Token: 0x06003E53 RID: 15955 RVA: 0x000D2834 File Offset: 0x000D0A34
			public static short Reverse(short value)
			{
				return BinaryPrimitives.ReverseEndianness(value);
			}

			// Token: 0x06003E54 RID: 15956 RVA: 0x000D283C File Offset: 0x000D0A3C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<short> Reverse(Vector128<short> vector)
			{
				return Vector128.ShiftLeft(vector, 8) | Vector128.ShiftRightLogical(vector, 8);
			}

			// Token: 0x06003E55 RID: 15957 RVA: 0x000D2851 File Offset: 0x000D0A51
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<short> Reverse(Vector256<short> vector)
			{
				return Vector256.ShiftLeft(vector, 8) | Vector256.ShiftRightLogical(vector, 8);
			}
		}

		// Token: 0x020003B6 RID: 950
		private readonly struct Int32EndiannessReverser : BinaryPrimitives.IEndiannessReverser<int>
		{
			// Token: 0x06003E56 RID: 15958 RVA: 0x000D2866 File Offset: 0x000D0A66
			public static int Reverse(int value)
			{
				return BinaryPrimitives.ReverseEndianness(value);
			}

			// Token: 0x06003E57 RID: 15959 RVA: 0x000D2870 File Offset: 0x000D0A70
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<int> Reverse(Vector128<int> vector)
			{
				return Vector128.Shuffle(vector.AsByte<int>(), Vector128.Create(3, 2, 1, 0, 7, 6, 5, 4, 11, 10, 9, 8, 15, 14, 13, 12)).AsInt32<byte>();
			}

			// Token: 0x06003E58 RID: 15960 RVA: 0x000D28AC File Offset: 0x000D0AAC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<int> Reverse(Vector256<int> vector)
			{
				return Vector256.Shuffle(vector.AsByte<int>(), Vector256.Create(3, 2, 1, 0, 7, 6, 5, 4, 11, 10, 9, 8, 15, 14, 13, 12, 19, 18, 17, 16, 23, 22, 21, 20, 27, 26, 25, 24, 31, 30, 29, 28)).AsInt32<byte>();
			}
		}

		// Token: 0x020003B7 RID: 951
		private readonly struct Int64EndiannessReverser : BinaryPrimitives.IEndiannessReverser<long>
		{
			// Token: 0x06003E59 RID: 15961 RVA: 0x000D2905 File Offset: 0x000D0B05
			public static long Reverse(long value)
			{
				return BinaryPrimitives.ReverseEndianness(value);
			}

			// Token: 0x06003E5A RID: 15962 RVA: 0x000D2910 File Offset: 0x000D0B10
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<long> Reverse(Vector128<long> vector)
			{
				return Vector128.Shuffle(vector.AsByte<long>(), Vector128.Create(7, 6, 5, 4, 3, 2, 1, 0, 15, 14, 13, 12, 11, 10, 9, 8)).AsInt64<byte>();
			}

			// Token: 0x06003E5B RID: 15963 RVA: 0x000D294C File Offset: 0x000D0B4C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<long> Reverse(Vector256<long> vector)
			{
				return Vector256.Shuffle(vector.AsByte<long>(), Vector256.Create(7, 6, 5, 4, 3, 2, 1, 0, 15, 14, 13, 12, 11, 10, 9, 8, 23, 22, 21, 20, 19, 18, 17, 16, 31, 30, 29, 28, 27, 26, 25, 24)).AsInt64<byte>();
			}
		}

		// Token: 0x020003B8 RID: 952
		private interface IEndiannessReverser<T> where T : struct
		{
			// Token: 0x06003E5C RID: 15964
			public abstract static T Reverse(T value);

			// Token: 0x06003E5D RID: 15965
			public abstract static Vector128<T> Reverse(Vector128<T> vector);

			// Token: 0x06003E5E RID: 15966
			public abstract static Vector256<T> Reverse(Vector256<T> vector);
		}
	}
}
