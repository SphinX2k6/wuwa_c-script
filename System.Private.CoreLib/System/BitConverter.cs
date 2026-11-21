using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020000DE RID: 222
	[NullableContext(1)]
	[Nullable(0)]
	public static class BitConverter
	{
		// Token: 0x06000A60 RID: 2656 RVA: 0x0001F297 File Offset: 0x0001D497
		public static byte[] GetBytes(bool value)
		{
			return new byte[]
			{
				(value > false) ? 1 : 0
			};
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0001F2A7 File Offset: 0x0001D4A7
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, bool value)
		{
			if (destination.Length < 1)
			{
				return false;
			}
			Unsafe.WriteUnaligned<byte>(MemoryMarshal.GetReference<byte>(destination), (value > false) ? 1 : 0);
			return true;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0001F2C6 File Offset: 0x0001D4C6
		public unsafe static byte[] GetBytes(char value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, char>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0001F2DC File Offset: 0x0001D4DC
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, char value)
		{
			if (destination.Length < 2)
			{
				return false;
			}
			Unsafe.WriteUnaligned<char>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0001F2F7 File Offset: 0x0001D4F7
		public unsafe static byte[] GetBytes(short value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, short>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0001F30D File Offset: 0x0001D50D
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, short value)
		{
			if (destination.Length < 2)
			{
				return false;
			}
			Unsafe.WriteUnaligned<short>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0001F328 File Offset: 0x0001D528
		public unsafe static byte[] GetBytes(int value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, int>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0001F33E File Offset: 0x0001D53E
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, int value)
		{
			if (destination.Length < 4)
			{
				return false;
			}
			Unsafe.WriteUnaligned<int>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0001F359 File Offset: 0x0001D559
		public unsafe static byte[] GetBytes(long value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, long>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001F36F File Offset: 0x0001D56F
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, long value)
		{
			if (destination.Length < 8)
			{
				return false;
			}
			Unsafe.WriteUnaligned<long>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0001F38A File Offset: 0x0001D58A
		public unsafe static byte[] GetBytes(Int128 value)
		{
			byte[] array = new byte[16];
			*Unsafe.As<byte, Int128>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0001F3A5 File Offset: 0x0001D5A5
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, Int128 value)
		{
			if (destination.Length < 16)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Int128>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0001F3C1 File Offset: 0x0001D5C1
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(ushort value)
		{
			byte[] array = new byte[2];
			*Unsafe.As<byte, ushort>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0001F3D7 File Offset: 0x0001D5D7
		[NullableContext(0)]
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, ushort value)
		{
			if (destination.Length < 2)
			{
				return false;
			}
			Unsafe.WriteUnaligned<ushort>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0001F3F2 File Offset: 0x0001D5F2
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(uint value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, uint>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0001F408 File Offset: 0x0001D608
		[NullableContext(0)]
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, uint value)
		{
			if (destination.Length < 4)
			{
				return false;
			}
			Unsafe.WriteUnaligned<uint>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0001F423 File Offset: 0x0001D623
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(ulong value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, ulong>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0001F439 File Offset: 0x0001D639
		[NullableContext(0)]
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, ulong value)
		{
			if (destination.Length < 8)
			{
				return false;
			}
			Unsafe.WriteUnaligned<ulong>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0001F454 File Offset: 0x0001D654
		[CLSCompliant(false)]
		public unsafe static byte[] GetBytes(UInt128 value)
		{
			byte[] array = new byte[16];
			*Unsafe.As<byte, UInt128>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0001F46F File Offset: 0x0001D66F
		[NullableContext(0)]
		[CLSCompliant(false)]
		public static bool TryWriteBytes(Span<byte> destination, UInt128 value)
		{
			if (destination.Length < 16)
			{
				return false;
			}
			Unsafe.WriteUnaligned<UInt128>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0001F48B File Offset: 0x0001D68B
		public unsafe static byte[] GetBytes(Half value)
		{
			byte[] array = new byte[sizeof(Half)];
			*Unsafe.As<byte, Half>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001F4AA File Offset: 0x0001D6AA
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, Half value)
		{
			if (destination.Length < sizeof(Half))
			{
				return false;
			}
			Unsafe.WriteUnaligned<Half>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0001F4CA File Offset: 0x0001D6CA
		public unsafe static byte[] GetBytes(float value)
		{
			byte[] array = new byte[4];
			*Unsafe.As<byte, float>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0001F4E0 File Offset: 0x0001D6E0
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, float value)
		{
			if (destination.Length < 4)
			{
				return false;
			}
			Unsafe.WriteUnaligned<float>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0001F4FB File Offset: 0x0001D6FB
		public unsafe static byte[] GetBytes(double value)
		{
			byte[] array = new byte[8];
			*Unsafe.As<byte, double>(ref array[0]) = value;
			return array;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0001F511 File Offset: 0x0001D711
		[NullableContext(0)]
		public static bool TryWriteBytes(Span<byte> destination, double value)
		{
			if (destination.Length < 8)
			{
				return false;
			}
			Unsafe.WriteUnaligned<double>(MemoryMarshal.GetReference<byte>(destination), value);
			return true;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0001F52C File Offset: 0x0001D72C
		public static char ToChar(byte[] value, int startIndex)
		{
			return (char)BitConverter.ToInt16(value, startIndex);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0001F536 File Offset: 0x0001D736
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static char ToChar(ReadOnlySpan<byte> value)
		{
			if (value.Length < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<char>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0001F553 File Offset: 0x0001D753
		public static short ToInt16(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			if (startIndex > value.Length - 2)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ByteArrayTooSmallForValue, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<short>(ref value[startIndex]);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0001F586 File Offset: 0x0001D786
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short ToInt16(ReadOnlySpan<byte> value)
		{
			if (value.Length < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<short>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0001F5A3 File Offset: 0x0001D7A3
		public static int ToInt32(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			if (startIndex > value.Length - 4)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ByteArrayTooSmallForValue, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<int>(ref value[startIndex]);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001F5D6 File Offset: 0x0001D7D6
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ToInt32(ReadOnlySpan<byte> value)
		{
			if (value.Length < 4)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<int>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001F5F3 File Offset: 0x0001D7F3
		public static long ToInt64(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			if (startIndex > value.Length - 8)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ByteArrayTooSmallForValue, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<long>(ref value[startIndex]);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001F626 File Offset: 0x0001D826
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long ToInt64(ReadOnlySpan<byte> value)
		{
			if (value.Length < 8)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<long>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0001F643 File Offset: 0x0001D843
		public static Int128 ToInt128(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			if (startIndex > value.Length - 16)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ByteArrayTooSmallForValue, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<Int128>(ref value[startIndex]);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0001F677 File Offset: 0x0001D877
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Int128 ToInt128(ReadOnlySpan<byte> value)
		{
			if (value.Length < 16)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<Int128>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0001F52C File Offset: 0x0001D72C
		[CLSCompliant(false)]
		public static ushort ToUInt16(byte[] value, int startIndex)
		{
			return (ushort)BitConverter.ToInt16(value, startIndex);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001F695 File Offset: 0x0001D895
		[NullableContext(0)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort ToUInt16(ReadOnlySpan<byte> value)
		{
			if (value.Length < 2)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<ushort>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001F6B2 File Offset: 0x0001D8B2
		[CLSCompliant(false)]
		public static uint ToUInt32(byte[] value, int startIndex)
		{
			return (uint)BitConverter.ToInt32(value, startIndex);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0001F6BB File Offset: 0x0001D8BB
		[NullableContext(0)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ToUInt32(ReadOnlySpan<byte> value)
		{
			if (value.Length < 4)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<uint>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
		[CLSCompliant(false)]
		public static ulong ToUInt64(byte[] value, int startIndex)
		{
			return (ulong)BitConverter.ToInt64(value, startIndex);
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0001F6E1 File Offset: 0x0001D8E1
		[NullableContext(0)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong ToUInt64(ReadOnlySpan<byte> value)
		{
			if (value.Length < 8)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<ulong>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0001F6FE File Offset: 0x0001D8FE
		[CLSCompliant(false)]
		public static UInt128 ToUInt128(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			if (startIndex > value.Length - 16)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ByteArrayTooSmallForValue, ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<UInt128>(ref value[startIndex]);
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001F732 File Offset: 0x0001D932
		[NullableContext(0)]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UInt128 ToUInt128(ReadOnlySpan<byte> value)
		{
			if (value.Length < 16)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<UInt128>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0001F750 File Offset: 0x0001D950
		public static Half ToHalf(byte[] value, int startIndex)
		{
			return BitConverter.Int16BitsToHalf(BitConverter.ToInt16(value, startIndex));
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0001F75E File Offset: 0x0001D95E
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Half ToHalf(ReadOnlySpan<byte> value)
		{
			if (value.Length < sizeof(Half))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<Half>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0001F780 File Offset: 0x0001D980
		public static float ToSingle(byte[] value, int startIndex)
		{
			return BitConverter.Int32BitsToSingle(BitConverter.ToInt32(value, startIndex));
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0001F78E File Offset: 0x0001D98E
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float ToSingle(ReadOnlySpan<byte> value)
		{
			if (value.Length < 4)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<float>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0001F7AB File Offset: 0x0001D9AB
		public static double ToDouble(byte[] value, int startIndex)
		{
			return BitConverter.Int64BitsToDouble(BitConverter.ToInt64(value, startIndex));
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0001F7B9 File Offset: 0x0001D9B9
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double ToDouble(ReadOnlySpan<byte> value)
		{
			if (value.Length < 8)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<double>(MemoryMarshal.GetReference<byte>(value));
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		public unsafe static string ToString(byte[] value, int startIndex, int length)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex < 0 || (startIndex >= value.Length && startIndex > 0))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			ArgumentOutOfRangeException.ThrowIfNegative<int>(length, "length");
			if (startIndex > value.Length - length)
			{
				ThrowHelper.ThrowArgumentException(ExceptionResource.Arg_ByteArrayTooSmallForValue, ExceptionArgument.value);
			}
			if (length == 0)
			{
				return string.Empty;
			}
			ArgumentOutOfRangeException.ThrowIfGreaterThan<int>(length, 715827882, "length");
			string text = string.FastAllocateString(length * 3 - 1);
			Span<char> span = new Span<char>(text.GetRawStringData(), text.Length);
			ReadOnlySpan<byte> readOnlySpan = new ReadOnlySpan<byte>(value, startIndex, length);
			int i = 0;
			int num = 0;
			byte b = *readOnlySpan[i++];
			*span[num++] = HexConverter.ToCharUpper(b >> 4);
			*span[num++] = HexConverter.ToCharUpper((int)b);
			while (i < readOnlySpan.Length)
			{
				b = *readOnlySpan[i++];
				*span[num++] = '-';
				*span[num++] = HexConverter.ToCharUpper(b >> 4);
				*span[num++] = HexConverter.ToCharUpper((int)b);
			}
			return text;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001F8FA File Offset: 0x0001DAFA
		public static string ToString(byte[] value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return BitConverter.ToString(value, 0, value.Length);
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0001F90F File Offset: 0x0001DB0F
		public static string ToString(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			return BitConverter.ToString(value, startIndex, value.Length - startIndex);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0001F926 File Offset: 0x0001DB26
		public static bool ToBoolean(byte[] value, int startIndex)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			if (startIndex < 0)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			if (startIndex >= value.Length)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLess);
			}
			return value[startIndex] > 0;
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0001F94F File Offset: 0x0001DB4F
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ToBoolean(ReadOnlySpan<byte> value)
		{
			if (value.Length < 1)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.value);
			}
			return Unsafe.ReadUnaligned<byte>(MemoryMarshal.GetReference<byte>(value)) > 0;
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0001F96F File Offset: 0x0001DB6F
		[Intrinsic]
		public static long DoubleToInt64Bits(double value)
		{
			return Unsafe.BitCast<double, long>(value);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0001F977 File Offset: 0x0001DB77
		[Intrinsic]
		public static double Int64BitsToDouble(long value)
		{
			return Unsafe.BitCast<long, double>(value);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0001F97F File Offset: 0x0001DB7F
		[Intrinsic]
		public static int SingleToInt32Bits(float value)
		{
			return Unsafe.BitCast<float, int>(value);
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0001F987 File Offset: 0x0001DB87
		[Intrinsic]
		public static float Int32BitsToSingle(int value)
		{
			return Unsafe.BitCast<int, float>(value);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0001F98F File Offset: 0x0001DB8F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static short HalfToInt16Bits(Half value)
		{
			return (short)value._value;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0001F998 File Offset: 0x0001DB98
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Half Int16BitsToHalf(short value)
		{
			return new Half((ushort)value);
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0001F9A1 File Offset: 0x0001DBA1
		[CLSCompliant(false)]
		[Intrinsic]
		public static ulong DoubleToUInt64Bits(double value)
		{
			return Unsafe.BitCast<double, ulong>(value);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0001F9A9 File Offset: 0x0001DBA9
		[CLSCompliant(false)]
		[Intrinsic]
		public static double UInt64BitsToDouble(ulong value)
		{
			return Unsafe.BitCast<ulong, double>(value);
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0001F9B1 File Offset: 0x0001DBB1
		[CLSCompliant(false)]
		[Intrinsic]
		public static uint SingleToUInt32Bits(float value)
		{
			return Unsafe.BitCast<float, uint>(value);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0001F9B9 File Offset: 0x0001DBB9
		[CLSCompliant(false)]
		[Intrinsic]
		public static float UInt32BitsToSingle(uint value)
		{
			return Unsafe.BitCast<uint, float>(value);
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0001F9C1 File Offset: 0x0001DBC1
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ushort HalfToUInt16Bits(Half value)
		{
			return value._value;
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0001F9C9 File Offset: 0x0001DBC9
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Half UInt16BitsToHalf(ushort value)
		{
			return new Half(value);
		}

		// Token: 0x040002FF RID: 767
		[Intrinsic]
		public static readonly bool IsLittleEndian = true;
	}
}
