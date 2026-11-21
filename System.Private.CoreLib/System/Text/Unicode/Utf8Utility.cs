using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace System.Text.Unicode
{
	// Token: 0x02000256 RID: 598
	internal static class Utf8Utility
	{
		// Token: 0x06002D20 RID: 11552 RVA: 0x00090D8C File Offset: 0x0008EF8C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static int GetIndexOfFirstInvalidUtf8Sequence(ReadOnlySpan<byte> utf8Data, out bool isAscii)
		{
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(utf8Data))
			{
				byte* ptr = reference;
				int num;
				int num2;
				byte* pointerToFirstInvalidByte = Utf8Utility.GetPointerToFirstInvalidByte(ptr, utf8Data.Length, out num, out num2);
				int num3 = (int)Unsafe.ByteOffset<byte>(ref *ptr, ref *pointerToFirstInvalidByte);
				isAscii = (num == 0);
				if (num3 >= utf8Data.Length)
				{
					return -1;
				}
				return num3;
			}
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x000801AE File Offset: 0x0007E3AE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool AllBytesInUInt32AreAscii(uint value)
		{
			return (value & 2155905152U) == 0U;
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x0007F134 File Offset: 0x0007D334
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool AllBytesInUInt64AreAscii(ulong value)
		{
			return (value & 9259542123273814144UL) == 0UL;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00090DD0 File Offset: 0x0008EFD0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint ConvertAllAsciiBytesInUInt32ToLowercase(uint value)
		{
			uint num = value + 2155905152U - 1094795585U;
			uint num2 = value + 2155905152U - 1532713819U;
			uint num3 = ((num ^ num2) & 2155905152U) >> 2;
			return value ^ num3;
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00090E08 File Offset: 0x0008F008
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint ConvertAllAsciiBytesInUInt32ToUppercase(uint value)
		{
			uint num = value + 2155905152U - 1633771873U;
			uint num2 = value + 2155905152U - 2071690107U;
			uint num3 = ((num ^ num2) & 2155905152U) >> 2;
			return value ^ num3;
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00090E40 File Offset: 0x0008F040
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong ConvertAllAsciiBytesInUInt64ToUppercase(ulong value)
		{
			ulong num = value + 9259542123273814144UL - 7016996765293437281UL;
			ulong num2 = value + 9259542123273814144UL - 8897841259083430779UL;
			ulong num3 = ((num ^ num2) & 9259542123273814144UL) >> 2;
			return value ^ num3;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00090E8C File Offset: 0x0008F08C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong ConvertAllAsciiBytesInUInt64ToLowercase(ulong value)
		{
			ulong num = value + 9259542123273814144UL - 4702111234474983745UL;
			ulong num2 = value + 9259542123273814144UL - 6582955728264977243UL;
			ulong num3 = ((num ^ num2) & 9259542123273814144UL) >> 2;
			return value ^ num3;
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00090ED8 File Offset: 0x0008F0D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool UInt32OrdinalIgnoreCaseAscii(uint valueA, uint valueB)
		{
			uint num = ((valueA + 1061109567U ^ valueA + 623191333U) & 2155905152U) >> 2;
			uint num2 = ((valueB + 1061109567U ^ valueB + 623191333U) & 2155905152U) >> 2;
			return (valueA | num) == (valueB | num2);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x00090F20 File Offset: 0x0008F120
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool UInt64OrdinalIgnoreCaseAscii(ulong valueA, ulong valueB)
		{
			ulong num = ((valueA + 4557430888798830399UL ^ valueA + 2676586395008836901UL) & 9259542123273814144UL) >> 2;
			ulong num2 = ((valueB + 4557430888798830399UL ^ valueB + 2676586395008836901UL) & 9259542123273814144UL) >> 2;
			return (valueA | num) == (valueB | num2);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00090F7D File Offset: 0x0008F17D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool AllBytesInVector128AreAscii(Vector128<byte> vec)
		{
			return (vec & Vector128.Create(128)) == Vector128<byte>.Zero;
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x00090F9C File Offset: 0x0008F19C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool Vector128OrdinalIgnoreCaseAscii(Vector128<byte> vec1, Vector128<byte> vec2)
		{
			Vector128<sbyte> right = Vector128.Create(63) + vec1.AsSByte<byte>();
			Vector128<sbyte> right2 = Vector128.Create(63) + vec2.AsSByte<byte>();
			Vector128<sbyte> right3 = Vector128.LessThan<sbyte>(Vector128.Create(-103), right);
			Vector128<sbyte> right4 = Vector128.LessThan<sbyte>(Vector128.Create(-103), right2);
			Vector128<sbyte> left = Vector128.AndNot<sbyte>(Vector128.Create(32), right3) + vec1.AsSByte<byte>();
			Vector128<sbyte> right5 = Vector128.AndNot<sbyte>(Vector128.Create(32), right4) + vec2.AsSByte<byte>();
			return (left ^ right5) == Vector128<sbyte>.Zero;
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x0009102E File Offset: 0x0008F22E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ExtractCharFromFirstThreeByteSequence(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return (value & 4128768U) >> 16 | (value & 16128U) >> 2 | (value & 15U) << 12;
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00091054 File Offset: 0x0008F254
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ExtractCharFromFirstTwoByteSequence(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			uint num = (uint)((uint)((byte)value) << 6);
			return (uint)((byte)(value >> 8)) + num - 12288U - 128U;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x00091080 File Offset: 0x0008F280
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ExtractCharsFromFourByteSequence(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return (uint)(((int)((byte)value) << 8 | (int)((value & 16128U) >> 6) | (int)((value & 3145728U) >> 20) | (int)((value & 1056964608U) >> 8) | (int)((int)(value & 983040U) << 6)) - 64 - 8192 + 2048 + -603979776);
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000910D8 File Offset: 0x0008F2D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ExtractFourUtf8BytesFromSurrogatePair(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			value += 64U;
			uint num = BinaryPrimitives.ReverseEndianness(value & 4130560U);
			num = BitOperations.RotateLeft(num, 16);
			uint num2 = (value & 252U) << 6;
			uint num3 = value >> 6 & 983040U;
			num3 |= num2;
			return (value & 3U) << 20 | 2155905264U | num | num3;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x0009112F File Offset: 0x0008F32F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ExtractTwoCharsPackedFromTwoAdjacentTwoByteSequences(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return (value & 1056980736U) >> 8 | (value & 2031647U) << 6;
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x0009114A File Offset: 0x0008F34A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ExtractTwoUtf8TwoByteSequencesFromTwoPackedUtf16Chars(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return (value >> 6 & 2031647U) + (value << 8 & 1056980736U) + 2160099520U;
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x0009116B File Offset: 0x0008F36B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ExtractUtf8TwoByteSequenceFromFirstUtf16Char(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			uint num = value << 2 & 7936U;
			value &= 63U;
			return (uint)BinaryPrimitives.ReverseEndianness((ushort)(num + value + 49280U));
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x0007F18C File Offset: 0x0007D38C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsFirstCharAscii(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value & 65408U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x00091190 File Offset: 0x0008F390
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsFirstCharAtLeastThreeUtf8Bytes(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value & 63488U) == 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D34 RID: 11572 RVA: 0x000911AB File Offset: 0x0008F3AB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsFirstCharSurrogate(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value - 55296U & 63488U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D35 RID: 11573 RVA: 0x000911CC File Offset: 0x0008F3CC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsFirstCharTwoUtf8Bytes(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value - 128U & 65535U) >= 1920U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D36 RID: 11574 RVA: 0x000911F2 File Offset: 0x0008F3F2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsLowByteUtf8ContinuationByte(uint value)
		{
			return (byte)(value - 128U) <= 63;
		}

		// Token: 0x06002D37 RID: 11575 RVA: 0x00091203 File Offset: 0x0008F403
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSecondCharAscii(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if (value >= 8388608U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D38 RID: 11576 RVA: 0x0009121D File Offset: 0x0008F41D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSecondCharAtLeastThreeUtf8Bytes(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value & 4160749568U) == 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D39 RID: 11577 RVA: 0x00091238 File Offset: 0x0008F438
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSecondCharSurrogate(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if (value - 3623878656U >= 134217728U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D3A RID: 11578 RVA: 0x00091258 File Offset: 0x0008F458
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsSecondCharTwoUtf8Bytes(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if (!UnicodeUtility.IsInRangeInclusive(value, 8388608U, 134217727U))
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D3B RID: 11579 RVA: 0x0009127C File Offset: 0x0008F47C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool IsUtf8ContinuationByte(in byte value)
		{
			return (sbyte)value < -64;
		}

		// Token: 0x06002D3C RID: 11580 RVA: 0x00091285 File Offset: 0x0008F485
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsWellFormedUtf16SurrogatePair(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value - 3691042816U & 4227922944U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D3D RID: 11581 RVA: 0x000912A6 File Offset: 0x0008F4A6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ToLittleEndian(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return value;
		}

		// Token: 0x06002D3E RID: 11582 RVA: 0x000912AF File Offset: 0x0008F4AF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32BeginsWithOverlongUtf8TwoByteSequence(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((byte)value >= 194)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D3F RID: 11583 RVA: 0x000912CA File Offset: 0x0008F4CA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32BeginsWithUtf8FourByteMask(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value - 2155905264U & 3233857784U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D40 RID: 11584 RVA: 0x000912EB File Offset: 0x0008F4EB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32BeginsWithUtf8ThreeByteMask(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value - 8421600U & 12632304U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D41 RID: 11585 RVA: 0x0009130C File Offset: 0x0008F50C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32BeginsWithUtf8TwoByteMask(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value - 32960U & 49376U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D42 RID: 11586 RVA: 0x0009132D File Offset: 0x0008F52D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32BeginsWithValidUtf8TwoByteSequenceLittleEndian(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if (!UnicodeUtility.IsInRangeInclusive(value & 49407U, 32962U, 32991U))
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x00091357 File Offset: 0x0008F557
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32EndsWithValidUtf8TwoByteSequenceLittleEndian(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if (!UnicodeUtility.IsInRangeInclusive(value & 3237937152U, 2160197632U, 2162098176U))
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x00091381 File Offset: 0x0008F581
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32FirstByteIsAscii(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value & 128U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D45 RID: 11589 RVA: 0x0009139C File Offset: 0x0008F59C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32FourthByteIsAscii(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if (value < 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x000913B2 File Offset: 0x0008F5B2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32SecondByteIsAscii(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value & 32768U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000913CD File Offset: 0x0008F5CD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool UInt32ThirdByteIsAscii(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if ((value & 8388608U) != 0U)
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x000913E8 File Offset: 0x0008F5E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void WriteTwoUtf16CharsAsTwoUtf8ThreeByteSequences(ref byte outputBuffer, uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			uint num = (value << 2 & 16128U) | (value & 63U) << 16;
			uint num2 = (value >> 4 & 251658240U) | (value >> 12 & 15U);
			Unsafe.WriteUnaligned<uint>(ref outputBuffer, num + num2 + 3766517984U);
			Unsafe.WriteUnaligned<ushort>(Unsafe.Add<byte>(ref outputBuffer, 4), (ushort)((value >> 22 & 63U) + (value >> 8 & 16128U) + 32896U));
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x00091454 File Offset: 0x0008F654
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void WriteFirstUtf16CharAsUtf8ThreeByteSequence(ref byte outputBuffer, uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			uint num = value << 2 & 16128U;
			uint num2 = (uint)((ushort)value) >> 12;
			Unsafe.WriteUnaligned<ushort>(ref outputBuffer, (ushort)(num + num2 + 32992U));
			*Unsafe.Add<byte>(ref outputBuffer, 2) = (byte)((value & 63U) | 4294967168U);
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x00091498 File Offset: 0x0008F698
		public unsafe static OperationStatus TranscodeToUtf16(byte* pInputBuffer, int inputLength, char* pOutputBuffer, int outputCharsRemaining, out byte* pInputBufferRemaining, out char* pOutputBufferRemaining)
		{
			UIntPtr uintPtr = Ascii.WidenAsciiToUtf16(pInputBuffer, pOutputBuffer, (UIntPtr)Math.Min(inputLength, outputCharsRemaining));
			pInputBuffer += (ulong)uintPtr;
			pOutputBuffer += (ulong)uintPtr * 2UL / 2UL;
			if ((int)uintPtr == inputLength)
			{
				pInputBufferRemaining = pInputBuffer;
				pOutputBufferRemaining = pOutputBuffer;
				return OperationStatus.Done;
			}
			inputLength -= (int)uintPtr;
			outputCharsRemaining -= (int)uintPtr;
			if (inputLength >= 4)
			{
				byte* ptr = pInputBuffer + inputLength - 4;
				for (;;)
				{
					uint num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
					int i;
					for (;;)
					{
						IL_51:
						if (Ascii.AllBytesInUInt32AreAscii(num))
						{
							if (outputCharsRemaining >= 4)
							{
								Ascii.WidenFourAsciiBytesToUtf16AndWriteToBuffer(ref *pOutputBuffer, num);
								pInputBuffer += 4;
								pOutputBuffer += 4;
								outputCharsRemaining -= 4;
								uint num2 = Math.Min((uint)Unsafe.ByteOffset<byte>(ref *pInputBuffer, ref *ptr) + 4U, (uint)outputCharsRemaining) / 8U;
								for (i = 0; i < (int)num2; i++)
								{
									num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
									uint num3 = Unsafe.ReadUnaligned<uint>((void*)(pInputBuffer + 4));
									if (!Ascii.AllBytesInUInt32AreAscii(num | num3))
									{
										if (Ascii.AllBytesInUInt32AreAscii(num))
										{
											Ascii.WidenFourAsciiBytesToUtf16AndWriteToBuffer(ref *pOutputBuffer, num);
											num = num3;
											pInputBuffer += 4;
											pOutputBuffer += 4;
											outputCharsRemaining -= 4;
										}
										outputCharsRemaining -= 8 * i;
										goto IL_117;
									}
									pInputBuffer += 8;
									Ascii.WidenFourAsciiBytesToUtf16AndWriteToBuffer(ref *pOutputBuffer, num);
									Ascii.WidenFourAsciiBytesToUtf16AndWriteToBuffer(ref pOutputBuffer[4], num3);
									pOutputBuffer += 8;
								}
								goto Block_6;
							}
							goto IL_49B;
						}
						IL_117:
						if (Utf8Utility.UInt32FirstByteIsAscii(num))
						{
							if (outputCharsRemaining >= 3)
							{
								uint num4 = Utf8Utility.ToLittleEndian(num);
								UIntPtr uintPtr2 = (UIntPtr)((IntPtr)1);
								*pOutputBuffer = (char)((byte)num4);
								if (Utf8Utility.UInt32SecondByteIsAscii(num))
								{
									uintPtr2++;
									num4 >>= 8;
									pOutputBuffer[1] = (char)((byte)num4);
									if (Utf8Utility.UInt32ThirdByteIsAscii(num))
									{
										uintPtr2++;
										num4 >>= 8;
										pOutputBuffer[2] = (char)((byte)num4);
									}
								}
								pInputBuffer += (ulong)uintPtr2;
								pOutputBuffer += (ulong)uintPtr2 * 2UL / 2UL;
								outputCharsRemaining -= (int)uintPtr2;
							}
							else
							{
								if (outputCharsRemaining == 0)
								{
									goto IL_680;
								}
								uint num5 = Utf8Utility.ToLittleEndian(num);
								pInputBuffer++;
								*(pOutputBuffer++) = (char)((byte)num5);
								outputCharsRemaining--;
								if (Utf8Utility.UInt32SecondByteIsAscii(num))
								{
									if (outputCharsRemaining == 0)
									{
										goto IL_680;
									}
									pInputBuffer++;
									num5 >>= 8;
									*(pOutputBuffer++) = (char)((byte)num5);
									if (Utf8Utility.UInt32ThirdByteIsAscii(num))
									{
										goto IL_680;
									}
									outputCharsRemaining = 0;
								}
							}
							if (pInputBuffer != ptr)
							{
								goto IL_49B;
							}
							num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
						}
						while (Utf8Utility.UInt32BeginsWithUtf8TwoByteMask(num))
						{
							if (Utf8Utility.UInt32BeginsWithOverlongUtf8TwoByteSequence(num))
							{
								goto IL_684;
							}
							for (;;)
							{
								bool isLittleEndian = BitConverter.IsLittleEndian;
								if (!Utf8Utility.UInt32EndsWithValidUtf8TwoByteSequenceLittleEndian(num) && BitConverter.IsLittleEndian)
								{
									break;
								}
								if (outputCharsRemaining < 2)
								{
									goto IL_49B;
								}
								Unsafe.WriteUnaligned<uint>((void*)pOutputBuffer, Utf8Utility.ExtractTwoCharsPackedFromTwoAdjacentTwoByteSequences(num));
								pInputBuffer += 4;
								pOutputBuffer += 2;
								outputCharsRemaining -= 2;
								if (pInputBuffer != ptr)
								{
									goto IL_49B;
								}
								num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
								bool isLittleEndian2 = BitConverter.IsLittleEndian;
								if (!Utf8Utility.UInt32BeginsWithValidUtf8TwoByteSequenceLittleEndian(num))
								{
									goto IL_51;
								}
							}
							uint num6 = Utf8Utility.ExtractCharFromFirstTwoByteSequence(num);
							if (Utf8Utility.UInt32ThirdByteIsAscii(num))
							{
								if (Utf8Utility.UInt32FourthByteIsAscii(num))
								{
									goto Block_23;
								}
								if (outputCharsRemaining < 2)
								{
									goto IL_49B;
								}
								*pOutputBuffer = (char)num6;
								ref short ptr2 = ref *(short*)(pOutputBuffer + 1);
								uint num7 = num;
								if (!BitConverter.IsLittleEndian)
								{
								}
								ptr2 = (short)(num7 >> (16 & 31));
								pInputBuffer += 3;
								pOutputBuffer += 2;
								outputCharsRemaining -= 2;
								if (ptr < pInputBuffer)
								{
									goto IL_49B;
								}
								num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
							}
							else
							{
								if (outputCharsRemaining == 0)
								{
									goto IL_49B;
								}
								*pOutputBuffer = (char)num6;
								pInputBuffer += 2;
								pOutputBuffer++;
								outputCharsRemaining--;
								if (ptr >= pInputBuffer)
								{
									num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
									break;
								}
								goto IL_49B;
							}
						}
						if (!Utf8Utility.UInt32BeginsWithUtf8ThreeByteMask(num))
						{
							goto IL_43B;
						}
						for (;;)
						{
							bool isLittleEndian3 = BitConverter.IsLittleEndian;
							if ((num & 8207U) == 0U)
							{
								goto IL_684;
							}
							if ((num - 8205U & 8207U) == 0U)
							{
								goto Block_30;
							}
							if (outputCharsRemaining != 0)
							{
								bool isLittleEndian4 = BitConverter.IsLittleEndian;
								if ((num - 3758096384U & 4026531840U) != 0U || outputCharsRemaining <= 1 || Unsafe.ByteOffset<byte>(ref *pInputBuffer, ref *ptr) < (IntPtr)3)
								{
									goto IL_3D9;
								}
								uint num8 = Unsafe.ReadUnaligned<uint>((void*)(pInputBuffer + 3));
								if (!Utf8Utility.UInt32BeginsWithUtf8ThreeByteMask(num8) || (num8 & 8207U) == 0U || (num8 - 8205U & 8207U) == 0U)
								{
									goto IL_3D9;
								}
								*pOutputBuffer = (char)Utf8Utility.ExtractCharFromFirstThreeByteSequence(num);
								pOutputBuffer[1] = (char)Utf8Utility.ExtractCharFromFirstThreeByteSequence(num8);
								pInputBuffer += 6;
								pOutputBuffer += 2;
								outputCharsRemaining -= 2;
								IL_3F1:
								if (Utf8Utility.UInt32FourthByteIsAscii(num))
								{
									if (outputCharsRemaining == 0)
									{
										goto IL_680;
									}
									bool isLittleEndian5 = BitConverter.IsLittleEndian;
									*pOutputBuffer = (char)(num >> 24);
									pInputBuffer++;
									pOutputBuffer++;
									outputCharsRemaining--;
								}
								if (pInputBuffer != ptr)
								{
									goto IL_49B;
								}
								num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
								if (Utf8Utility.UInt32BeginsWithUtf8ThreeByteMask(num))
								{
									continue;
								}
								break;
								IL_3D9:
								*pOutputBuffer = (char)Utf8Utility.ExtractCharFromFirstThreeByteSequence(num);
								pInputBuffer += 3;
								pOutputBuffer++;
								outputCharsRemaining--;
								goto IL_3F1;
							}
							goto IL_680;
						}
					}
					IL_494:
					if (pInputBuffer != ptr)
					{
						goto IL_49B;
					}
					continue;
					Block_6:
					outputCharsRemaining -= 8 * i;
					goto IL_494;
					Block_23:
					if (outputCharsRemaining >= 3)
					{
						uint num6;
						*pOutputBuffer = (char)num6;
						bool isLittleEndian6 = BitConverter.IsLittleEndian;
						num >>= 16;
						pOutputBuffer[1] = (char)((byte)num);
						num >>= 8;
						pOutputBuffer[2] = (char)num;
						pInputBuffer += 4;
						pOutputBuffer += 3;
						outputCharsRemaining -= 3;
						goto IL_494;
					}
					goto IL_49B;
					IL_43B:
					if (!Utf8Utility.UInt32BeginsWithUtf8FourByteMask(num))
					{
						break;
					}
					bool isLittleEndian7 = BitConverter.IsLittleEndian;
					if (!UnicodeUtility.IsInRangeInclusive(BitOperations.RotateRight(num & 65535U, 8), 4026531984U, 4093640847U))
					{
						break;
					}
					if (outputCharsRemaining >= 2)
					{
						Unsafe.WriteUnaligned<uint>((void*)pOutputBuffer, Utf8Utility.ExtractCharsFromFourByteSequence(num));
						pInputBuffer += 4;
						pOutputBuffer += 2;
						outputCharsRemaining -= 2;
						goto IL_494;
					}
					goto IL_680;
				}
				Block_30:
				goto IL_684;
				IL_49B:
				inputLength = (int)Unsafe.ByteOffset<byte>(ref *pInputBuffer, ref *ptr) + 4;
			}
			OperationStatus result;
			while (inputLength > 0)
			{
				uint num9 = (uint)(*pInputBuffer);
				if (num9 > 127U)
				{
					num9 -= 194U;
					if ((byte)num9 <= 29)
					{
						if (inputLength >= 2)
						{
							uint num10 = (uint)pInputBuffer[1];
							if (!Utf8Utility.IsLowByteUtf8ContinuationByte(num10))
							{
								goto IL_684;
							}
							if (outputCharsRemaining != 0)
							{
								uint num11 = (num9 << 6) + num10 + 128U - 128U;
								*pOutputBuffer = (char)num11;
								pInputBuffer += 2;
								pOutputBuffer++;
								inputLength -= 2;
								outputCharsRemaining--;
								continue;
							}
							goto IL_680;
						}
					}
					else if ((byte)num9 <= 45)
					{
						if (inputLength >= 3)
						{
							uint num12 = (uint)pInputBuffer[1];
							uint num13 = (uint)pInputBuffer[2];
							if (!Utf8Utility.IsLowByteUtf8ContinuationByte(num12) || !Utf8Utility.IsLowByteUtf8ContinuationByte(num13))
							{
								goto IL_684;
							}
							uint num14 = (num9 << 12) + (num12 << 6);
							if (num14 < 133120U)
							{
								goto IL_684;
							}
							num14 -= 186368U;
							if (num14 < 2048U)
							{
								goto IL_684;
							}
							if (outputCharsRemaining != 0)
							{
								num14 += num13;
								num14 += 55296U;
								num14 -= 128U;
								*pOutputBuffer = (char)num14;
								pInputBuffer += 3;
								pOutputBuffer++;
								inputLength -= 3;
								outputCharsRemaining--;
								continue;
							}
							goto IL_680;
						}
						else if (inputLength >= 2)
						{
							uint num15 = (uint)pInputBuffer[1];
							if (!Utf8Utility.IsLowByteUtf8ContinuationByte(num15))
							{
								goto IL_684;
							}
							uint num16 = (num9 << 6) + num15;
							if (num16 < 2080U)
							{
								goto IL_684;
							}
							if (UnicodeUtility.IsInRangeInclusive(num16, 2912U, 2943U))
							{
								goto IL_684;
							}
						}
					}
					else
					{
						if ((byte)num9 > 50)
						{
							goto IL_684;
						}
						if (inputLength >= 2)
						{
							uint num17 = (uint)pInputBuffer[1];
							if (!Utf8Utility.IsLowByteUtf8ContinuationByte(num17) || !UnicodeUtility.IsInRangeInclusive((num9 << 6) + num17, 3088U, 3343U))
							{
								goto IL_684;
							}
							if (inputLength >= 3)
							{
								if (!Utf8Utility.IsLowByteUtf8ContinuationByte((uint)pInputBuffer[2]))
								{
									goto IL_684;
								}
								if (inputLength >= 4)
								{
									if (!Utf8Utility.IsLowByteUtf8ContinuationByte((uint)pInputBuffer[3]))
									{
										goto IL_684;
									}
									goto IL_680;
								}
							}
						}
					}
					result = OperationStatus.NeedMoreData;
					goto IL_686;
				}
				if (outputCharsRemaining == 0)
				{
					goto IL_680;
				}
				*pOutputBuffer = (char)num9;
				pInputBuffer++;
				pOutputBuffer++;
				inputLength--;
				outputCharsRemaining--;
			}
			result = OperationStatus.Done;
			goto IL_686;
			IL_680:
			result = OperationStatus.DestinationTooSmall;
			goto IL_686;
			IL_684:
			result = OperationStatus.InvalidData;
			IL_686:
			pInputBufferRemaining = pInputBuffer;
			pOutputBufferRemaining = pOutputBuffer;
			return result;
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x00091B34 File Offset: 0x0008FD34
		public unsafe static OperationStatus TranscodeToUtf8(char* pInputBuffer, int inputLength, byte* pOutputBuffer, int outputBytesRemaining, out char* pInputBufferRemaining, out byte* pOutputBufferRemaining)
		{
			UIntPtr uintPtr = Ascii.NarrowUtf16ToAscii(pInputBuffer, pOutputBuffer, (UIntPtr)Math.Min(inputLength, outputBytesRemaining));
			pInputBuffer += (ulong)uintPtr * 2UL / 2UL;
			pOutputBuffer += (ulong)uintPtr;
			if ((int)uintPtr == inputLength)
			{
				pInputBufferRemaining = pInputBuffer;
				pOutputBufferRemaining = pOutputBuffer;
				return OperationStatus.Done;
			}
			inputLength -= (int)uintPtr;
			outputBytesRemaining -= (int)uintPtr;
			uint num8;
			if (inputLength >= 2)
			{
				char* ptr = pInputBuffer + (ulong)inputLength * 2UL / 2UL - 2;
				if (Sse41.X64.IsSupported || false)
				{
					Vector128<short> right = Vector128.Create(-128);
				}
				uint num;
				for (;;)
				{
					num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
					int i;
					Vector128<short> vector;
					ulong num7;
					for (;;)
					{
						IL_70:
						if (Utf16Utility.AllCharsInUInt32AreAscii(num))
						{
							if (outputBytesRemaining < 2)
							{
								goto IL_4E0;
							}
							uint num2 = num | num >> 8;
							Unsafe.WriteUnaligned<ushort>((void*)pOutputBuffer, (ushort)num2);
							pInputBuffer += 2;
							pOutputBuffer += 2;
							outputBytesRemaining -= 2;
							uint num3 = (uint)Math.Min((long)((ulong)((uint)((long)(ptr - pInputBuffer)) + 2U)), (long)outputBytesRemaining);
							if (!Sse41.X64.IsSupported && !false)
							{
								uint num4 = num3 / 4U;
								i = 0;
								while (i < (int)num4)
								{
									num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
									uint num5 = Unsafe.ReadUnaligned<uint>((void*)(pInputBuffer + 2));
									if (Utf16Utility.AllCharsInUInt32AreAscii(num | num5))
									{
										Unsafe.WriteUnaligned<ushort>((void*)pOutputBuffer, (ushort)(num | num >> 8));
										Unsafe.WriteUnaligned<ushort>((void*)(pOutputBuffer + 2), (ushort)(num5 | num5 >> 8));
										pInputBuffer += 4;
										pOutputBuffer += 4;
										i++;
									}
									else
									{
										outputBytesRemaining -= 4 * i;
										if (Utf16Utility.AllCharsInUInt32AreAscii(num))
										{
											Unsafe.WriteUnaligned<ushort>((void*)pOutputBuffer, (ushort)(num | num >> 8));
											pInputBuffer += 2;
											pOutputBuffer += 2;
											outputBytesRemaining -= 2;
											num = num5;
											goto IL_2CE;
										}
										goto IL_2CE;
									}
								}
								goto Block_15;
							}
							uint num6 = num3 / 8U;
							int j = 0;
							while (j < (int)num6)
							{
								Vector128<short> right;
								Unsafe.SkipInit<Vector128<short>>(out right);
								vector = Unsafe.ReadUnaligned<Vector128<short>>((void*)pInputBuffer);
								if (false)
								{
								}
								if (Sse41.TestZ(vector, right))
								{
									Sse2.StoreScalar((ulong*)pOutputBuffer, Sse2.PackUnsignedSaturate(vector, vector).AsUInt64<byte>());
									pInputBuffer += 8;
									pOutputBuffer += 8;
									j++;
								}
								else
								{
									outputBytesRemaining -= 8 * j;
									if (Sse2.X64.IsSupported)
									{
										num7 = Sse2.X64.ConvertToUInt64(vector.AsUInt64<short>());
									}
									else
									{
										num7 = vector.AsUInt64<short>().ToScalar<ulong>();
									}
									if (Utf16Utility.AllCharsInUInt64AreAscii(num7))
									{
										if (false)
										{
										}
										Unsafe.WriteUnaligned<uint>((void*)pOutputBuffer, Sse2.ConvertToUInt32(Sse2.PackUnsignedSaturate(vector, vector).AsUInt32<byte>()));
										pInputBuffer += 4;
										pOutputBuffer += 4;
										outputBytesRemaining -= 4;
										num7 = vector.AsUInt64<short>().GetElement(1);
									}
									IL_1F8:
									num = (uint)num7;
									if (Utf16Utility.AllCharsInUInt32AreAscii(num))
									{
										Unsafe.WriteUnaligned<ushort>((void*)pOutputBuffer, (ushort)(num | num >> 8));
										pInputBuffer += 2;
										pOutputBuffer += 2;
										outputBytesRemaining -= 2;
										num = (uint)(num7 >> 32);
										goto IL_2CE;
									}
									goto IL_2CE;
								}
							}
							outputBytesRemaining -= 8 * j;
							if ((num3 & 4U) == 0U)
							{
								break;
							}
							num7 = Unsafe.ReadUnaligned<ulong>((void*)pInputBuffer);
							if (Utf16Utility.AllCharsInUInt64AreAscii(num7))
							{
								goto Block_10;
							}
							goto IL_1F8;
						}
						for (;;)
						{
							IL_2CE:
							if (Utf8Utility.IsFirstCharAscii(num))
							{
								if (outputBytesRemaining == 0)
								{
									goto IL_58C;
								}
								bool isLittleEndian = BitConverter.IsLittleEndian;
								*pOutputBuffer = (byte)num;
								pInputBuffer++;
								pOutputBuffer++;
								outputBytesRemaining--;
								if (pInputBuffer != ptr)
								{
									goto IL_4CA;
								}
								num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
							}
							if (!Utf8Utility.IsFirstCharAtLeastThreeUtf8Bytes(num))
							{
								while (Utf8Utility.IsSecondCharTwoUtf8Bytes(num))
								{
									if (outputBytesRemaining < 4)
									{
										goto IL_4E0;
									}
									Unsafe.WriteUnaligned<uint>((void*)pOutputBuffer, Utf8Utility.ExtractTwoUtf8TwoByteSequencesFromTwoPackedUtf16Chars(num));
									pInputBuffer += 2;
									pOutputBuffer += 4;
									outputBytesRemaining -= 4;
									if (pInputBuffer != ptr)
									{
										goto IL_4CA;
									}
									num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
									if (!Utf8Utility.IsFirstCharTwoUtf8Bytes(num))
									{
										goto IL_70;
									}
								}
								if (outputBytesRemaining < 2)
								{
									goto IL_58C;
								}
								Unsafe.WriteUnaligned<ushort>((void*)pOutputBuffer, (ushort)Utf8Utility.ExtractUtf8TwoByteSequenceFromFirstUtf16Char(num));
								if (Utf8Utility.IsSecondCharAscii(num))
								{
									goto Block_25;
								}
								pInputBuffer++;
								pOutputBuffer += 2;
								outputBytesRemaining -= 2;
								if (pInputBuffer != ptr)
								{
									goto IL_4CA;
								}
								num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
							}
							while (!Utf8Utility.IsFirstCharSurrogate(num))
							{
								if (Utf8Utility.IsSecondCharAtLeastThreeUtf8Bytes(num) && !Utf8Utility.IsSecondCharSurrogate(num) && outputBytesRemaining >= 6)
								{
									Utf8Utility.WriteTwoUtf16CharsAsTwoUtf8ThreeByteSequences(ref *pOutputBuffer, num);
									pInputBuffer += 2;
									pOutputBuffer += 6;
									outputBytesRemaining -= 6;
									if (pInputBuffer != ptr)
									{
										goto IL_4CA;
									}
									num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
									if (!Utf8Utility.IsFirstCharAtLeastThreeUtf8Bytes(num))
									{
										goto IL_70;
									}
								}
								else
								{
									if (outputBytesRemaining < 3)
									{
										goto IL_58C;
									}
									Utf8Utility.WriteFirstUtf16CharAsUtf8ThreeByteSequence(ref *pOutputBuffer, num);
									pInputBuffer++;
									pOutputBuffer += 3;
									outputBytesRemaining -= 3;
									if (Utf8Utility.IsSecondCharAscii(num))
									{
										if (outputBytesRemaining == 0)
										{
											goto IL_58C;
										}
										bool isLittleEndian2 = BitConverter.IsLittleEndian;
										*pOutputBuffer = (byte)(num >> 16);
										pInputBuffer++;
										pOutputBuffer++;
										outputBytesRemaining--;
										if (pInputBuffer != ptr)
										{
											goto IL_4CA;
										}
										num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
										if (!Utf8Utility.IsFirstCharAtLeastThreeUtf8Bytes(num))
										{
											goto IL_70;
										}
									}
									else
									{
										if (pInputBuffer == ptr)
										{
											num = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
											goto IL_2CE;
										}
										goto IL_4CA;
									}
								}
							}
							goto IL_493;
						}
					}
					IL_4C3:
					if (pInputBuffer != ptr)
					{
						goto IL_4CA;
					}
					continue;
					Block_10:
					vector = Vector128.CreateScalarUnsafe(num7).AsInt16<ulong>();
					if (false)
					{
					}
					Unsafe.WriteUnaligned<uint>((void*)pOutputBuffer, Sse2.ConvertToUInt32(Sse2.PackUnsignedSaturate(vector, vector).AsUInt32<byte>()));
					pInputBuffer += 4;
					pOutputBuffer += 4;
					outputBytesRemaining -= 4;
					goto IL_4C3;
					Block_15:
					outputBytesRemaining -= 4 * i;
					goto IL_4C3;
					Block_25:
					if (outputBytesRemaining >= 3)
					{
						bool isLittleEndian3 = BitConverter.IsLittleEndian;
						num >>= 16;
						pOutputBuffer[2] = (byte)num;
						pInputBuffer += 2;
						pOutputBuffer += 3;
						outputBytesRemaining -= 3;
						goto IL_4C3;
					}
					break;
					IL_493:
					if (!Utf8Utility.IsWellFormedUtf16SurrogatePair(num))
					{
						goto IL_591;
					}
					if (outputBytesRemaining >= 4)
					{
						Unsafe.WriteUnaligned<uint>((void*)pOutputBuffer, Utf8Utility.ExtractFourUtf8BytesFromSurrogatePair(num));
						pInputBuffer += 2;
						pOutputBuffer += 4;
						outputBytesRemaining -= 4;
						goto IL_4C3;
					}
					goto IL_58C;
				}
				pInputBuffer++;
				pOutputBuffer += 2;
				goto IL_58C;
				IL_4CA:
				inputLength = (int)((long)(ptr - pInputBuffer)) + 2;
				goto IL_4D5;
				IL_4E0:
				bool isLittleEndian4 = BitConverter.IsLittleEndian;
				num8 = (num & 65535U);
				goto IL_4F0;
			}
			IL_4D5:
			if (inputLength == 0)
			{
				goto IL_582;
			}
			num8 = (uint)(*pInputBuffer);
			IL_4F0:
			OperationStatus result;
			if (num8 <= 127U)
			{
				if (outputBytesRemaining == 0)
				{
					goto IL_58C;
				}
				*pOutputBuffer = (byte)num8;
				pInputBuffer++;
				pOutputBuffer++;
			}
			else if (num8 < 2048U)
			{
				if (outputBytesRemaining < 2)
				{
					goto IL_58C;
				}
				pOutputBuffer[1] = (byte)((num8 & 63U) | 4294967168U);
				*pOutputBuffer = (byte)(num8 >> 6 | 4294967232U);
				pInputBuffer++;
				pOutputBuffer += 2;
			}
			else if (!UnicodeUtility.IsSurrogateCodePoint(num8))
			{
				if (outputBytesRemaining < 3)
				{
					goto IL_58C;
				}
				pOutputBuffer[2] = (byte)((num8 & 63U) | 4294967168U);
				pOutputBuffer[1] = (byte)((num8 >> 6 & 63U) | 4294967168U);
				*pOutputBuffer = (byte)(num8 >> 12 | 4294967264U);
				pInputBuffer++;
				pOutputBuffer += 3;
			}
			else
			{
				if (num8 <= 56319U)
				{
					result = OperationStatus.NeedMoreData;
					goto IL_594;
				}
				goto IL_591;
			}
			if (inputLength > 1)
			{
				goto IL_58C;
			}
			IL_582:
			result = OperationStatus.Done;
			goto IL_594;
			IL_58C:
			result = OperationStatus.DestinationTooSmall;
			goto IL_594;
			IL_591:
			result = OperationStatus.InvalidData;
			IL_594:
			pInputBufferRemaining = pInputBuffer;
			pOutputBufferRemaining = pOutputBuffer;
			return result;
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000920E0 File Offset: 0x000902E0
		public unsafe static byte* GetPointerToFirstInvalidByte(byte* pInputBuffer, int inputLength, out int utf16CodeUnitCountAdjustment, out int scalarCountAdjustment)
		{
			UIntPtr indexOfFirstNonAsciiByte = Ascii.GetIndexOfFirstNonAsciiByte(pInputBuffer, (UIntPtr)inputLength);
			pInputBuffer += (ulong)indexOfFirstNonAsciiByte;
			inputLength -= (int)indexOfFirstNonAsciiByte;
			if (inputLength == 0)
			{
				utf16CodeUnitCountAdjustment = 0;
				scalarCountAdjustment = 0;
				return pInputBuffer;
			}
			int num = 0;
			int num2 = 0;
			UIntPtr uintPtr2;
			if (inputLength >= 4)
			{
				byte* ptr = pInputBuffer + inputLength - 4;
				IL_41C:
				while (pInputBuffer == ptr)
				{
					uint num3 = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
					for (;;)
					{
						IL_40:
						if (!Ascii.AllBytesInUInt32AreAscii(num3))
						{
							goto IL_112;
						}
						pInputBuffer += 4;
						if (Unsafe.ByteOffset<byte>(ref *pInputBuffer, ref *ptr) < (IntPtr)16)
						{
							goto IL_41C;
						}
						num3 = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
						if (Ascii.AllBytesInUInt32AreAscii(num3))
						{
							pInputBuffer = (pInputBuffer + 4 & ~3);
							byte* ptr2 = ptr - 12;
							if (false)
							{
							}
							uint num4;
							for (;;)
							{
								if (Sse2.IsSupported)
								{
									num4 = (uint)Sse2.MoveMask(Sse2.LoadVector128(pInputBuffer));
									if (num4 != 0U)
									{
										break;
									}
								}
								else
								{
									if (!Ascii.AllBytesInUInt32AreAscii(*(uint*)pInputBuffer | *(uint*)(pInputBuffer + 4)))
									{
										goto IL_FC;
									}
									if (!Ascii.AllBytesInUInt32AreAscii(*(uint*)(pInputBuffer + (IntPtr)2 * 4) | *(uint*)(pInputBuffer + (IntPtr)3 * 4)))
									{
										goto IL_F7;
									}
								}
								pInputBuffer += 16;
								if (pInputBuffer != ptr2)
								{
									goto Block_9;
								}
							}
							UIntPtr uintPtr = (UIntPtr)((IntPtr)BitOperations.TrailingZeroCount(num4));
							pInputBuffer += (ulong)uintPtr;
							if (pInputBuffer == ptr)
							{
								num3 = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
								goto IL_131;
							}
							goto IL_42E;
							IL_FC:
							num3 = *(uint*)pInputBuffer;
							if (Ascii.AllBytesInUInt32AreAscii(num3))
							{
								pInputBuffer += 4;
								num3 = *(uint*)pInputBuffer;
								goto IL_112;
							}
							goto IL_112;
							IL_F7:
							pInputBuffer += 8;
							goto IL_FC;
						}
						goto IL_112;
						for (;;)
						{
							IL_131:
							uint num5 = num3;
							if (!BitConverter.IsLittleEndian)
							{
							}
							num3 = num5 - 32960U;
							bool flag = num3 != 0U;
							if (!BitConverter.IsLittleEndian)
							{
							}
							if (((flag ? 1 : 0) & 49376) != 0)
							{
								break;
							}
							bool isLittleEndian = BitConverter.IsLittleEndian;
							if ((byte)num3 < 2)
							{
								goto IL_51B;
							}
							if (!BitConverter.IsLittleEndian)
							{
							}
							for (;;)
							{
								bool isLittleEndian2 = BitConverter.IsLittleEndian;
								if (!Utf8Utility.UInt32EndsWithValidUtf8TwoByteSequenceLittleEndian(num3) && BitConverter.IsLittleEndian)
								{
									break;
								}
								pInputBuffer += 4;
								num -= 2;
								if (pInputBuffer != ptr)
								{
									goto IL_42E;
								}
								num3 = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
								bool isLittleEndian3 = BitConverter.IsLittleEndian;
								if (!Utf8Utility.UInt32BeginsWithValidUtf8TwoByteSequenceLittleEndian(num3))
								{
									goto IL_40;
								}
							}
							num--;
							if (!Utf8Utility.UInt32ThirdByteIsAscii(num3))
							{
								goto IL_1E7;
							}
							if (Utf8Utility.UInt32FourthByteIsAscii(num3))
							{
								goto Block_19;
							}
							pInputBuffer += 3;
							if (pInputBuffer != ptr)
							{
								goto IL_41C;
							}
							num3 = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
						}
						uint num6 = num3;
						if (!BitConverter.IsLittleEndian)
						{
						}
						num3 = num6 - 8388640U;
						bool flag2 = num3 != 0U;
						if (!BitConverter.IsLittleEndian)
						{
						}
						if (((flag2 ? 1 : 0) & 12632304) != 0)
						{
							goto IL_3D1;
						}
						for (;;)
						{
							bool isLittleEndian4 = BitConverter.IsLittleEndian;
							if ((num3 & 8207U) == 0U)
							{
								goto IL_51B;
							}
							if ((num3 - 8205U & 8207U) == 0U)
							{
								goto Block_22;
							}
							for (;;)
							{
								IL_23E:
								bool isLittleEndian5 = BitConverter.IsLittleEndian;
								IntPtr intPtr = (IntPtr)((int)num3 >> 31);
								pInputBuffer += 4;
								pInputBuffer += (long)intPtr;
								num -= 2;
								ulong num7;
								for (;;)
								{
									bool isLittleEndian6 = BitConverter.IsLittleEndian;
									if ((IntPtr)((long)(ptr - pInputBuffer)) < (IntPtr)5)
									{
										goto IL_3B1;
									}
									num7 = Unsafe.ReadUnaligned<ulong>((void*)pInputBuffer);
									num3 = (uint)num7;
									if ((num7 & 13902823984598139120UL) != 9286563722648649952UL || !Utf8Utility.IsUtf8ContinuationByte(pInputBuffer[8]))
									{
										break;
									}
									if (((uint)num7 & 8207U) == 0U || ((uint)num7 - 8205U & 8207U) == 0U)
									{
										goto IL_51B;
									}
									num7 >>= 24;
									if (((uint)num7 & 8207U) == 0U || ((uint)num7 - 8205U & 8207U) == 0U)
									{
										goto IL_23E;
									}
									num7 >>= 24;
									if (((uint)num7 & 8207U) == 0U || ((uint)num7 - 8205U & 8207U) == 0U)
									{
										goto IL_23E;
									}
									pInputBuffer += 9;
									num -= 6;
								}
								if ((num7 & 211934905417968UL) != 141291010687200UL)
								{
									break;
								}
								if (((uint)num7 & 8207U) == 0U || ((uint)num7 - 8205U & 8207U) == 0U)
								{
									goto IL_51B;
								}
								num7 >>= 24;
								if (((uint)num7 & 8207U) != 0U && ((uint)num7 - 8205U & 8207U) != 0U)
								{
									goto Block_36;
								}
							}
							if (Utf8Utility.UInt32BeginsWithUtf8ThreeByteMask(num3))
							{
								continue;
							}
							goto IL_40;
							IL_3B1:
							if (pInputBuffer != ptr)
							{
								goto IL_42E;
							}
							num3 = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
							if (!Utf8Utility.UInt32BeginsWithUtf8ThreeByteMask(num3))
							{
								goto IL_40;
							}
						}
						IL_112:
						uint num8 = Ascii.CountNumberOfLeadingAsciiBytesFromUInt32WithSomeNonAsciiData(num3);
						pInputBuffer += num8;
						if (ptr >= pInputBuffer)
						{
							num3 = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
							goto IL_131;
						}
						goto IL_42E;
					}
					Block_22:
					goto IL_51B;
					Block_9:
					continue;
					Block_19:
					pInputBuffer += 4;
					continue;
					IL_1E7:
					pInputBuffer += 2;
					continue;
					Block_36:
					pInputBuffer += 6;
					num -= 4;
					continue;
					IL_3D1:
					bool isLittleEndian7 = BitConverter.IsLittleEndian;
					num3 &= 3233873919U;
					if (num3 > 2147500031U)
					{
						goto IL_51B;
					}
					num3 = BitOperations.RotateRight(num3, 8);
					if (!UnicodeUtility.IsInRangeInclusive(num3, 276824080U, 343932943U))
					{
						goto IL_51B;
					}
					pInputBuffer += 4;
					num -= 2;
					num2--;
					continue;
					IL_42E:
					uintPtr2 = (UIntPtr)(Unsafe.ByteOffset<byte>(ref *pInputBuffer, ref *ptr) + (IntPtr)4);
					goto IL_512;
				}
				goto IL_42E;
			}
			uintPtr2 = (UIntPtr)inputLength;
			IL_512:
			while (uintPtr2 > (UIntPtr)((IntPtr)0))
			{
				uint num9 = (uint)(*pInputBuffer);
				if ((byte)num9 < 128)
				{
					pInputBuffer++;
					uintPtr2--;
				}
				else
				{
					if (uintPtr2 < (UIntPtr)((IntPtr)2))
					{
						break;
					}
					uint value = (uint)pInputBuffer[1];
					if ((byte)num9 < 224)
					{
						if ((byte)num9 < 194 || !Utf8Utility.IsLowByteUtf8ContinuationByte(value))
						{
							break;
						}
						pInputBuffer += 2;
						num--;
						uintPtr2 -= (UIntPtr)((IntPtr)2);
					}
					else
					{
						if (uintPtr2 < (UIntPtr)((IntPtr)3) || (byte)num9 >= 240)
						{
							break;
						}
						if ((byte)num9 == 224)
						{
							if (!UnicodeUtility.IsInRangeInclusive(value, 160U, 191U))
							{
								break;
							}
						}
						else if ((byte)num9 == 237)
						{
							if (!UnicodeUtility.IsInRangeInclusive(value, 128U, 159U))
							{
								break;
							}
						}
						else if (!Utf8Utility.IsLowByteUtf8ContinuationByte(value))
						{
							break;
						}
						if (!Utf8Utility.IsUtf8ContinuationByte(pInputBuffer[2]))
						{
							break;
						}
						pInputBuffer += 3;
						num -= 2;
						uintPtr2 -= (UIntPtr)((IntPtr)3);
					}
				}
			}
			IL_51B:
			utf16CodeUnitCountAdjustment = num;
			scalarCountAdjustment = num2;
			return pInputBuffer;
		}
	}
}
