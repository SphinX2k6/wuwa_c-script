using System;
using System.Buffers;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Unicode;

namespace System
{
	// Token: 0x02000165 RID: 357
	internal static class Marvin
	{
		// Token: 0x06001750 RID: 5968 RVA: 0x000466E5 File Offset: 0x000448E5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ComputeHash32(ReadOnlySpan<byte> data, ulong seed)
		{
			return Marvin.ComputeHash32(MemoryMarshal.GetReference<byte>(data), (uint)data.Length, (uint)seed, (uint)(seed >> 32));
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00046700 File Offset: 0x00044900
		public unsafe static int ComputeHash32(ref byte data, uint count, uint p0, uint p1)
		{
			uint num;
			if (count < 8U)
			{
				if (count < 4U)
				{
					bool isLittleEndian = BitConverter.IsLittleEndian;
					num = 128U;
					if ((count & 1U) != 0U)
					{
						num = (uint)(*Unsafe.AddByteOffset<byte>(ref data, (UIntPtr)count & (UIntPtr)((IntPtr)2)));
						bool isLittleEndian2 = BitConverter.IsLittleEndian;
						num |= 32768U;
					}
					if ((count & 2U) != 0U)
					{
						bool isLittleEndian3 = BitConverter.IsLittleEndian;
						num <<= 16;
						num |= (uint)Unsafe.ReadUnaligned<ushort>(ref data);
						goto IL_A6;
					}
					goto IL_A6;
				}
			}
			else
			{
				uint num2 = count / 8U;
				do
				{
					p0 += Unsafe.ReadUnaligned<uint>(ref data);
					uint num3 = Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref data, (IntPtr)4));
					Marvin.Block(ref p0, ref p1);
					p0 += num3;
					Marvin.Block(ref p0, ref p1);
					data = Unsafe.AddByteOffset<byte>(ref data, (IntPtr)8);
				}
				while ((num2 -= 1U) > 0U);
				if ((count & 4U) == 0U)
				{
					goto IL_6A;
				}
			}
			p0 += Unsafe.ReadUnaligned<uint>(ref data);
			Marvin.Block(ref p0, ref p1);
			IL_6A:
			num = Unsafe.ReadUnaligned<uint>(Unsafe.Add<byte>(Unsafe.AddByteOffset<byte>(ref data, (UIntPtr)count & (UIntPtr)((IntPtr)7)), -4));
			count = ~count << 3;
			bool isLittleEndian4 = BitConverter.IsLittleEndian;
			num >>= 8;
			num |= 2147483648U;
			num >>= (int)count;
			IL_A6:
			p0 += num;
			Marvin.Block(ref p0, ref p1);
			Marvin.Block(ref p0, ref p1);
			return (int)(p1 ^ p0);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00046818 File Offset: 0x00044A18
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Block(ref uint rp0, ref uint rp1)
		{
			uint num = rp0;
			uint num2 = rp1;
			num2 ^= num;
			num = BitOperations.RotateLeft(num, 20);
			num += num2;
			num2 = BitOperations.RotateLeft(num2, 9);
			num2 ^= num;
			num = BitOperations.RotateLeft(num, 27);
			num += num2;
			num2 = BitOperations.RotateLeft(num2, 19);
			rp0 = num;
			rp1 = num2;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x00046865 File Offset: 0x00044A65
		public static ulong DefaultSeed { get; } = Marvin.GenerateSeed();

		// Token: 0x06001754 RID: 5972 RVA: 0x0004686C File Offset: 0x00044A6C
		private unsafe static ulong GenerateSeed()
		{
			ulong result;
			Interop.GetRandomBytes((byte*)(&result), 8);
			return result;
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x00046884 File Offset: 0x00044A84
		public unsafe static int ComputeHash32OrdinalIgnoreCase(ref char data, int count, uint p0, uint p1)
		{
			uint num = (uint)count;
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			while (num >= 2U)
			{
				uint num2 = Unsafe.ReadUnaligned<uint>(Unsafe.As<char, byte>(Unsafe.AddByteOffset<char>(ref data, uintPtr)));
				if (!Utf16Utility.AllCharsInUInt32AreAscii(num2))
				{
					IL_95:
					return Marvin.ComputeHash32OrdinalIgnoreCaseSlow(Unsafe.AddByteOffset<char>(ref data, uintPtr), (int)num, p0, p1);
				}
				p0 += Utf16Utility.ConvertAllAsciiCharsInUInt32ToUppercase(num2);
				Marvin.Block(ref p0, ref p1);
				uintPtr += (UIntPtr)((IntPtr)4);
				num -= 2U;
			}
			if (num > 0U)
			{
				uint num2 = (uint)(*Unsafe.AddByteOffset<char>(ref data, uintPtr));
				if (num2 > 127U)
				{
					goto IL_95;
				}
				bool isLittleEndian = BitConverter.IsLittleEndian;
				p0 += Utf16Utility.ConvertAllAsciiCharsInUInt32ToUppercase(num2) + 8388480U;
			}
			bool isLittleEndian2 = BitConverter.IsLittleEndian;
			p0 += 128U;
			Marvin.Block(ref p0, ref p1);
			Marvin.Block(ref p0, ref p1);
			return (int)(p1 ^ p0);
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00046938 File Offset: 0x00044B38
		private unsafe static int ComputeHash32OrdinalIgnoreCaseSlow(ref char data, int count, uint p0, uint p1)
		{
			char[] array = null;
			Span<char> span;
			if (count <= 64)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(count));
			}
			Span<char> span2 = span;
			int num = Ordinal.ToUpperOrdinal(new ReadOnlySpan<char>(ref data, count), span2);
			int result = Marvin.ComputeHash32(Unsafe.As<char, byte>(MemoryMarshal.GetReference<char>(span2)), (uint)(num * 2), p0, p1);
			if (array != null)
			{
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result;
		}
	}
}
