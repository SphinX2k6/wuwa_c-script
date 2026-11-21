using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Unicode;

namespace System
{
	// Token: 0x02000201 RID: 513
	internal static class HexConverter
	{
		// Token: 0x06002896 RID: 10390 RVA: 0x0007D6B0 File Offset: 0x0007B8B0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void ToCharsBuffer(byte value, Span<char> buffer, int startingIndex = 0, HexConverter.Casing casing = HexConverter.Casing.Upper)
		{
			uint num = (uint)(((int)(value & 240) << 4) + (int)(value & 15) - 35209);
			uint num2 = (uint)(((-num & 28784U) >> 4) + num + (HexConverter.Casing)47545U | casing);
			*buffer[startingIndex + 1] = (char)(num2 & 255U);
			*buffer[startingIndex] = (char)(num2 >> 8);
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0007D708 File Offset: 0x0007B908
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ValueTuple<Vector128<byte>, Vector128<byte>> AsciiToHexVector128(Vector128<byte> src, Vector128<byte> hexMap)
		{
			Vector128<byte> left = Vector128.ShiftRightLogical(src.AsUInt64<byte>(), 4).AsByte<ulong>();
			Vector128<byte> left2 = Vector128.UnpackLow(left, src);
			Vector128<byte> left3 = Vector128.UnpackHigh(left, src);
			return new ValueTuple<Vector128<byte>, Vector128<byte>>(Vector128.ShuffleUnsafe(hexMap, left2 & Vector128.Create(15)), Vector128.ShuffleUnsafe(hexMap, left3 & Vector128.Create(15)));
		}

		// Token: 0x06002898 RID: 10392 RVA: 0x0007D760 File Offset: 0x0007B960
		private static void EncodeToUtf16_Vector128(ReadOnlySpan<byte> bytes, Span<char> chars, HexConverter.Casing casing)
		{
			ref byte reference = ref MemoryMarshal.GetReference<byte>(bytes);
			ref ushort destination = ref Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(chars));
			Vector128<byte> hexMap = (casing == HexConverter.Casing.Upper) ? Vector128.Create(48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 65, 66, 67, 68, 69, 70) : Vector128.Create(48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 97, 98, 99, 100, 101, 102);
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			UIntPtr uintPtr2 = (UIntPtr)((IntPtr)bytes.Length - (IntPtr)Vector128<int>.Count);
			for (;;)
			{
				Vector128.Widen(HexConverter.AsciiToHexVector128(Vector128.CreateScalar(Unsafe.ReadUnaligned<uint>(Unsafe.Add<byte>(ref reference, uintPtr))).AsByte<uint>(), hexMap).Item1).Item1.StoreUnsafe(ref destination, uintPtr * (UIntPtr)((IntPtr)2));
				uintPtr += (UIntPtr)((IntPtr)Vector128<int>.Count);
				if (uintPtr == (UIntPtr)((IntPtr)bytes.Length))
				{
					break;
				}
				if (uintPtr > uintPtr2)
				{
					uintPtr = uintPtr2;
				}
			}
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x0007D838 File Offset: 0x0007BA38
		public unsafe static void EncodeToUtf16(ReadOnlySpan<byte> bytes, Span<char> chars, HexConverter.Casing casing = HexConverter.Casing.Upper)
		{
			if (Ssse3.IsSupported && bytes.Length >= 4)
			{
				HexConverter.EncodeToUtf16_Vector128(bytes, chars, casing);
				return;
			}
			for (int i = 0; i < bytes.Length; i++)
			{
				HexConverter.ToCharsBuffer(*bytes[i], chars, i * 2, casing);
			}
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0007D886 File Offset: 0x0007BA86
		public unsafe static string ToString(ReadOnlySpan<byte> bytes, HexConverter.Casing casing = HexConverter.Casing.Upper)
		{
			return string.Create<ValueTuple<IntPtr, HexConverter.Casing>>(bytes.Length * 2, new ValueTuple<IntPtr, HexConverter.Casing>(&bytes, casing), delegate(Span<char> chars, [TupleElementNames(new string[]
			{
				"RosPtr",
				"casing"
			})] ValueTuple<IntPtr, HexConverter.Casing> args)
			{
				HexConverter.EncodeToUtf16(*args.Item1, chars, args.Item2);
			});
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0007D8BE File Offset: 0x0007BABE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static char ToCharUpper(int value)
		{
			value &= 15;
			value += 48;
			if (value > 57)
			{
				value += 7;
			}
			return (char)value;
		}

		// Token: 0x0600289C RID: 10396 RVA: 0x0007D8D8 File Offset: 0x0007BAD8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static char ToCharLower(int value)
		{
			value &= 15;
			value += 48;
			if (value > 57)
			{
				value += 39;
			}
			return (char)value;
		}

		// Token: 0x0600289D RID: 10397 RVA: 0x0007D8F3 File Offset: 0x0007BAF3
		public static bool TryDecodeFromUtf16(ReadOnlySpan<char> chars, Span<byte> bytes, out int charsProcessed)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((Ssse3.IsSupported || false) && chars.Length >= Vector128<ushort>.Count * 2)
			{
				return HexConverter.TryDecodeFromUtf16_Vector128(chars, bytes, out charsProcessed);
			}
			return HexConverter.TryDecodeFromUtf16_Scalar(chars, bytes, out charsProcessed);
		}

		// Token: 0x0600289E RID: 10398 RVA: 0x0007D928 File Offset: 0x0007BB28
		public static bool TryDecodeFromUtf16_Vector128(ReadOnlySpan<char> chars, Span<byte> bytes, out int charsProcessed)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			UIntPtr uintPtr2 = (UIntPtr)((IntPtr)chars.Length - (IntPtr)Vector128<ushort>.Count * (IntPtr)2);
			ref ushort source = ref Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(chars));
			ref byte reference = ref MemoryMarshal.GetReference<byte>(bytes);
			for (;;)
			{
				Vector128<ushort> vector = Vector128.LoadUnsafe<ushort>(ref source, uintPtr);
				Vector128<ushort> vector2 = Vector128.LoadUnsafe<ushort>(ref source, uintPtr + (UIntPtr)((IntPtr)Vector128<ushort>.Count));
				Vector128<byte> left = Ascii.ExtractAsciiVector(vector, vector2);
				Vector128<byte> left2 = Vector128.SubtractSaturate(left + Vector128.Create(198), Vector128.Create(6));
				Vector128<byte> right = Vector128.AddSaturate((left & Vector128.Create(223)) - Vector128.Create(65), Vector128.Create(10));
				Vector128<byte> left3 = Vector128.Min<byte>(left2 - Vector128.Create(240), right);
				if (!Utf16Utility.AllCharsInVectorAreAscii<Vector128<ushort>>(vector | vector2) || Vector128.AddSaturate(left3, Vector128.Create(112)).ExtractMostSignificantBits<byte>() != 0U)
				{
					goto IL_1AD;
				}
				Vector128<byte> vector3;
				if (Ssse3.IsSupported)
				{
					vector3 = Ssse3.MultiplyAddAdjacent(left3, Vector128.Create(272).AsSByte<short>()).AsByte<short>();
				}
				else
				{
					Vector128<short> vector4 = AdvSimd.Arm64.TransposeEven(left3, Vector128<byte>.Zero).AsInt16<byte>();
					Vector128<short> right2 = AdvSimd.Arm64.TransposeOdd(left3, Vector128<byte>.Zero).AsInt16<byte>();
					vector4 = AdvSimd.ShiftLeftLogical(vector4, 4).AsInt16<short>();
					vector3 = AdvSimd.AddSaturate(vector4, right2).AsByte<short>();
				}
				vector3 = Vector128.Shuffle(vector3, Vector128.Create(0, 2, 4, 6, 8, 10, 12, 14, 0, 0, 0, 0, 0, 0, 0, 0));
				Unsafe.WriteUnaligned<ulong>(Unsafe.Add<byte>(ref reference, uintPtr / (UIntPtr)((IntPtr)2)), vector3.AsUInt64<byte>().ToScalar<ulong>());
				uintPtr += (UIntPtr)((IntPtr)Vector128<ushort>.Count * (IntPtr)2);
				if (uintPtr == (UIntPtr)((IntPtr)chars.Length))
				{
					break;
				}
				if (uintPtr > uintPtr2)
				{
					uintPtr = uintPtr2;
				}
			}
			charsProcessed = chars.Length;
			return true;
			IL_1AD:
			int num;
			bool result = HexConverter.TryDecodeFromUtf16_Scalar(chars.Slice((int)uintPtr), bytes.Slice((int)(uintPtr / (UIntPtr)((IntPtr)2))), out num);
			charsProcessed = (int)uintPtr + num;
			return result;
		}

		// Token: 0x0600289F RID: 10399 RVA: 0x0007DB08 File Offset: 0x0007BD08
		private unsafe static bool TryDecodeFromUtf16_Scalar(ReadOnlySpan<char> chars, Span<byte> bytes, out int charsProcessed)
		{
			int num = 0;
			int i = 0;
			int num2 = 0;
			int num3 = 0;
			while (i < bytes.Length)
			{
				num2 = HexConverter.FromChar((int)(*chars[num + 1]));
				num3 = HexConverter.FromChar((int)(*chars[num]));
				if ((num2 | num3) == 255)
				{
					break;
				}
				*bytes[i++] = (byte)(num3 << 4 | num2);
				num += 2;
			}
			if (num2 == 255)
			{
				num++;
			}
			charsProcessed = num;
			return (num2 | num3) != 255;
		}

		// Token: 0x060028A0 RID: 10400 RVA: 0x0007DB88 File Offset: 0x0007BD88
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int FromChar(int c)
		{
			if (c < HexConverter.CharToHexLookup.Length)
			{
				return (int)(*HexConverter.CharToHexLookup[c]);
			}
			return 255;
		}

		// Token: 0x060028A1 RID: 10401 RVA: 0x0007DBBC File Offset: 0x0007BDBC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsHexChar(int c)
		{
			ulong num = (ulong)(c - 48);
			ulong num2 = 18428868213665201664UL << (int)num;
			ulong num3 = num - 64UL;
			return (num2 & num3) < 0UL;
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x0007DBF0 File Offset: 0x0007BDF0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsHexUpperChar(int c)
		{
			return c - 48 <= 9 || c - 65 <= 5;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x0007DC06 File Offset: 0x0007BE06
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsHexLowerChar(int c)
		{
			return c - 48 <= 9 || c - 97 <= 5;
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x0007DC1C File Offset: 0x0007BE1C
		public unsafe static ReadOnlySpan<byte> CharToHexLookup
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.21244F82B210125632917591768F6BF22EB6861F80C6C25A25BD26DFB580EA7B), 256);
			}
		}

		// Token: 0x02000202 RID: 514
		public enum Casing : uint
		{
			// Token: 0x04000722 RID: 1826
			Upper,
			// Token: 0x04000723 RID: 1827
			Lower = 8224U
		}
	}
}
