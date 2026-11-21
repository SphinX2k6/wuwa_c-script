using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace System.Numerics
{
	// Token: 0x0200028D RID: 653
	public static class BitOperations
	{
		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002ED4 RID: 11988 RVA: 0x00097931 File Offset: 0x00095B31
		private unsafe static ReadOnlySpan<byte> TrailingZeroCountDeBruijn
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.3BF63951626584EB1653F9B8DBB590A5EE1EAE1135A904B9317C3773896DF076), 32);
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06002ED5 RID: 11989 RVA: 0x0009793F File Offset: 0x00095B3F
		private unsafe static ReadOnlySpan<byte> Log2DeBruijn
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.4BCD43D478B9229AB7A13406353712C7944B60348C36B4D0E6B789D10F697652), 32);
			}
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x0009794D File Offset: 0x00095B4D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPow2(int value)
		{
			return (value & value - 1) == 0 && value > 0;
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x0009795C File Offset: 0x00095B5C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPow2(uint value)
		{
			return (value & value - 1U) == 0U && value > 0U;
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x0009796B File Offset: 0x00095B6B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPow2(long value)
		{
			return (value & value - 1L) == 0L && value > 0L;
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x0009797C File Offset: 0x00095B7C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPow2(ulong value)
		{
			return (value & value - 1UL) == 0UL && value > 0UL;
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x0009798D File Offset: 0x00095B8D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPow2(IntPtr value)
		{
			return (value & value - (IntPtr)1) == 0 && value > (IntPtr)0;
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x0009799E File Offset: 0x00095B9E
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPow2(UIntPtr value)
		{
			return (value & value - (UIntPtr)((IntPtr)1)) == 0 && value > (UIntPtr)((IntPtr)0);
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000979B0 File Offset: 0x00095BB0
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint RoundUpToPowerOf2(uint value)
		{
			if (X86Base.IsSupported || false)
			{
				return (uint)(4294967296UL >> BitOperations.LeadingZeroCount(value - 1U));
			}
			value -= 1U;
			value |= value >> 1;
			value |= value >> 2;
			value |= value >> 4;
			value |= value >> 8;
			value |= value >> 16;
			return value + 1U;
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x00097A0C File Offset: 0x00095C0C
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong RoundUpToPowerOf2(ulong value)
		{
			if (X86Base.X64.IsSupported || false)
			{
				int num = 64 - BitOperations.LeadingZeroCount(value - 1UL);
				return (ulong)((ulong)(1L ^ (long)(num >> 6)) << num);
			}
			value -= 1UL;
			value |= value >> 1;
			value |= value >> 2;
			value |= value >> 4;
			value |= value >> 8;
			value |= value >> 16;
			value |= value >> 32;
			return value + 1UL;
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x00097A75 File Offset: 0x00095C75
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr RoundUpToPowerOf2(UIntPtr value)
		{
			return (UIntPtr)BitOperations.RoundUpToPowerOf2((ulong)value);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00097A7F File Offset: 0x00095C7F
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LeadingZeroCount(uint value)
		{
			if (Lzcnt.IsSupported)
			{
				return (int)Lzcnt.LeadingZeroCount(value);
			}
			if (false)
			{
			}
			if (false)
			{
			}
			if (value == 0U)
			{
				return 32;
			}
			if (X86Base.IsSupported)
			{
				return (int)(31U ^ X86Base.BitScanReverse(value));
			}
			return 31 ^ BitOperations.Log2SoftwareFallback(value);
		}

		// Token: 0x06002EE0 RID: 12000 RVA: 0x00097AB8 File Offset: 0x00095CB8
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LeadingZeroCount(ulong value)
		{
			if (Lzcnt.X64.IsSupported)
			{
				return (int)Lzcnt.X64.LeadingZeroCount(value);
			}
			if (false)
			{
			}
			if (false)
			{
			}
			if (X86Base.X64.IsSupported)
			{
				if (value != 0UL)
				{
					return 63 ^ (int)X86Base.X64.BitScanReverse(value);
				}
				return 64;
			}
			else
			{
				uint num = (uint)(value >> 32);
				if (num == 0U)
				{
					return 32 + BitOperations.LeadingZeroCount((uint)value);
				}
				return BitOperations.LeadingZeroCount(num);
			}
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x00097B0C File Offset: 0x00095D0C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int LeadingZeroCount(UIntPtr value)
		{
			return BitOperations.LeadingZeroCount((ulong)value);
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x00097B15 File Offset: 0x00095D15
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Log2(uint value)
		{
			value |= 1U;
			if (Lzcnt.IsSupported)
			{
				return (int)(31U ^ Lzcnt.LeadingZeroCount(value));
			}
			if (false)
			{
			}
			if (false)
			{
			}
			if (X86Base.IsSupported)
			{
				return (int)X86Base.BitScanReverse(value);
			}
			return BitOperations.Log2SoftwareFallback(value);
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x00097B48 File Offset: 0x00095D48
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Log2(ulong value)
		{
			value |= 1UL;
			if (Lzcnt.X64.IsSupported)
			{
				return 63 ^ (int)Lzcnt.X64.LeadingZeroCount(value);
			}
			if (false)
			{
			}
			if (X86Base.X64.IsSupported)
			{
				return (int)X86Base.X64.BitScanReverse(value);
			}
			if (false)
			{
			}
			uint num = (uint)(value >> 32);
			if (num == 0U)
			{
				return BitOperations.Log2((uint)value);
			}
			return 32 + BitOperations.Log2(num);
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x00097B9C File Offset: 0x00095D9C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Log2(UIntPtr value)
		{
			return BitOperations.Log2((ulong)value);
		}

		// Token: 0x06002EE5 RID: 12005 RVA: 0x00097BA8 File Offset: 0x00095DA8
		private unsafe static int Log2SoftwareFallback(uint value)
		{
			value |= value >> 1;
			value |= value >> 2;
			value |= value >> 4;
			value |= value >> 8;
			value |= value >> 16;
			return (int)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(BitOperations.Log2DeBruijn), (IntPtr)(value * 130329821U >> 27)));
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x00097BF4 File Offset: 0x00095DF4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int Log2Ceiling(ulong value)
		{
			int num = BitOperations.Log2(value);
			if (BitOperations.PopCount(value) != 1)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x00097C16 File Offset: 0x00095E16
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PopCount(uint value)
		{
			if (Popcnt.IsSupported)
			{
				return (int)Popcnt.PopCount(value);
			}
			if (false)
			{
			}
			return BitOperations.<PopCount>g__SoftwareFallback|22_0(value);
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00097C2F File Offset: 0x00095E2F
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PopCount(ulong value)
		{
			if (Popcnt.X64.IsSupported)
			{
				return (int)Popcnt.X64.PopCount(value);
			}
			if (false)
			{
			}
			return BitOperations.<PopCount>g__SoftwareFallback|23_0(value);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x00097C49 File Offset: 0x00095E49
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int PopCount(UIntPtr value)
		{
			return BitOperations.PopCount((ulong)value);
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x00073031 File Offset: 0x00071231
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TrailingZeroCount(int value)
		{
			return BitOperations.TrailingZeroCount((uint)value);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x00097C54 File Offset: 0x00095E54
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int TrailingZeroCount(uint value)
		{
			if (Bmi1.IsSupported)
			{
				return (int)Bmi1.TrailingZeroCount(value);
			}
			if (false)
			{
			}
			if (false)
			{
			}
			if (value == 0U)
			{
				return 32;
			}
			if (X86Base.IsSupported)
			{
				return (int)X86Base.BitScanForward(value);
			}
			return (int)(*Unsafe.AddByteOffset<byte>(MemoryMarshal.GetReference<byte>(BitOperations.TrailingZeroCountDeBruijn), (IntPtr)((value & -value) * 125613361U >> 27)));
		}

		// Token: 0x06002EEC RID: 12012 RVA: 0x00097CA7 File Offset: 0x00095EA7
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TrailingZeroCount(long value)
		{
			return BitOperations.TrailingZeroCount((ulong)value);
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x00097CB0 File Offset: 0x00095EB0
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TrailingZeroCount(ulong value)
		{
			if (Bmi1.X64.IsSupported)
			{
				return (int)Bmi1.X64.TrailingZeroCount(value);
			}
			if (false)
			{
			}
			if (false)
			{
			}
			if (X86Base.X64.IsSupported)
			{
				if (value != 0UL)
				{
					return (int)X86Base.X64.BitScanForward(value);
				}
				return 64;
			}
			else
			{
				uint num = (uint)value;
				if (num == 0U)
				{
					return 32 + BitOperations.TrailingZeroCount((uint)(value >> 32));
				}
				return BitOperations.TrailingZeroCount(num);
			}
		}

		// Token: 0x06002EEE RID: 12014 RVA: 0x00097D01 File Offset: 0x00095F01
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TrailingZeroCount(IntPtr value)
		{
			return BitOperations.TrailingZeroCount((ulong)value);
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x00097D01 File Offset: 0x00095F01
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int TrailingZeroCount(UIntPtr value)
		{
			return BitOperations.TrailingZeroCount((ulong)value);
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00097D0A File Offset: 0x00095F0A
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint RotateLeft(uint value, int offset)
		{
			return value << offset | value >> 32 - offset;
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x00097D1C File Offset: 0x00095F1C
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong RotateLeft(ulong value, int offset)
		{
			return value << offset | value >> 64 - offset;
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x00097D2E File Offset: 0x00095F2E
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr RotateLeft(UIntPtr value, int offset)
		{
			return (UIntPtr)BitOperations.RotateLeft((ulong)value, offset);
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00097D39 File Offset: 0x00095F39
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint RotateRight(uint value, int offset)
		{
			return value >> offset | value << 32 - offset;
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00097D4B File Offset: 0x00095F4B
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ulong RotateRight(ulong value, int offset)
		{
			return value >> offset | value << 64 - offset;
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00097D5D File Offset: 0x00095F5D
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static UIntPtr RotateRight(UIntPtr value, int offset)
		{
			return (UIntPtr)BitOperations.RotateRight((ulong)value, offset);
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00097D68 File Offset: 0x00095F68
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Crc32C(uint crc, byte data)
		{
			if (Sse42.IsSupported)
			{
				return Sse42.Crc32(crc, data);
			}
			if (false)
			{
			}
			return BitOperations.Crc32Fallback.Crc32C(crc, data);
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00097D83 File Offset: 0x00095F83
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Crc32C(uint crc, ushort data)
		{
			if (Sse42.IsSupported)
			{
				return Sse42.Crc32(crc, data);
			}
			if (false)
			{
			}
			return BitOperations.Crc32Fallback.Crc32C(crc, data);
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x00097D9E File Offset: 0x00095F9E
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Crc32C(uint crc, uint data)
		{
			if (Sse42.IsSupported)
			{
				return Sse42.Crc32(crc, data);
			}
			if (false)
			{
			}
			return BitOperations.Crc32Fallback.Crc32C(crc, data);
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x00097DB9 File Offset: 0x00095FB9
		[Intrinsic]
		[CLSCompliant(false)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint Crc32C(uint crc, ulong data)
		{
			if (Sse42.X64.IsSupported)
			{
				return (uint)Sse42.X64.Crc32((ulong)crc, data);
			}
			if (false)
			{
			}
			return BitOperations.Crc32C(BitOperations.Crc32C(crc, (uint)data), (uint)(data >> 32));
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x00097DE1 File Offset: 0x00095FE1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint ResetLowestSetBit(uint value)
		{
			return value & value - 1U;
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00097DE8 File Offset: 0x00095FE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint FlipBit(uint value, int index)
		{
			return value ^ 1U << index;
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00097DF2 File Offset: 0x00095FF2
		[CompilerGenerated]
		internal static int <PopCount>g__SoftwareFallback|22_0(uint value)
		{
			value -= (value >> 1 & 1431655765U);
			value = (value & 858993459U) + (value >> 2 & 858993459U);
			value = (value + (value >> 4) & 252645135U) * 16843009U >> 24;
			return (int)value;
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00097E2C File Offset: 0x0009602C
		[CompilerGenerated]
		internal static int <PopCount>g__SoftwareFallback|23_0(ulong value)
		{
			value -= (value >> 1 & 6148914691236517205UL);
			value = (value & 3689348814741910323UL) + (value >> 2 & 3689348814741910323UL);
			value = (value + (value >> 4) & 1085102592571150095UL) * 72340172838076673UL >> 56;
			return (int)value;
		}

		// Token: 0x0200028E RID: 654
		private static class Crc32Fallback
		{
			// Token: 0x06002EFE RID: 12030 RVA: 0x00097E85 File Offset: 0x00096085
			internal unsafe static uint Crc32C(uint crc, byte data)
			{
				crc = (*Unsafe.Add<uint>(MemoryMarshal.GetArrayDataReference<uint>(BitOperations.Crc32Fallback.s_crcTable), (IntPtr)((UIntPtr)((byte)(crc ^ (uint)data)))) ^ crc >> 8);
				return crc;
			}

			// Token: 0x06002EFF RID: 12031 RVA: 0x00097EA3 File Offset: 0x000960A3
			internal unsafe static uint Crc32C(uint crc, ushort data)
			{
				ref uint arrayDataReference = ref MemoryMarshal.GetArrayDataReference<uint>(BitOperations.Crc32Fallback.s_crcTable);
				crc = (*Unsafe.Add<uint>(ref arrayDataReference, (IntPtr)((UIntPtr)((byte)(crc ^ (uint)((byte)data))))) ^ crc >> 8);
				data = (ushort)(data >> 8);
				crc = (*Unsafe.Add<uint>(ref arrayDataReference, (IntPtr)((UIntPtr)((byte)(crc ^ (uint)data)))) ^ crc >> 8);
				return crc;
			}

			// Token: 0x06002F00 RID: 12032 RVA: 0x00097EDA File Offset: 0x000960DA
			internal static uint Crc32C(uint crc, uint data)
			{
				return BitOperations.Crc32Fallback.Crc32CCore(MemoryMarshal.GetArrayDataReference<uint>(BitOperations.Crc32Fallback.s_crcTable), crc, data);
			}

			// Token: 0x06002F01 RID: 12033 RVA: 0x00097EF0 File Offset: 0x000960F0
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private unsafe static uint Crc32CCore(ref uint lookupTable, uint crc, uint data)
			{
				crc = (*Unsafe.Add<uint>(ref lookupTable, (IntPtr)((UIntPtr)((byte)(crc ^ (uint)((byte)data))))) ^ crc >> 8);
				data >>= 8;
				crc = (*Unsafe.Add<uint>(ref lookupTable, (IntPtr)((UIntPtr)((byte)(crc ^ (uint)((byte)data))))) ^ crc >> 8);
				data >>= 8;
				crc = (*Unsafe.Add<uint>(ref lookupTable, (IntPtr)((UIntPtr)((byte)(crc ^ (uint)((byte)data))))) ^ crc >> 8);
				data >>= 8;
				crc = (*Unsafe.Add<uint>(ref lookupTable, (IntPtr)((UIntPtr)((byte)(crc ^ data)))) ^ crc >> 8);
				return crc;
			}

			// Token: 0x040008C5 RID: 2245
			private static readonly uint[] s_crcTable = Crc32ReflectedTable.Generate(2197175160U);
		}
	}
}
