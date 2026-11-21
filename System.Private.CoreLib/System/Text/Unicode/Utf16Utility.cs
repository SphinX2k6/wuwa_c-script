using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace System.Text.Unicode
{
	// Token: 0x02000253 RID: 595
	internal static class Utf16Utility
	{
		// Token: 0x06002CF9 RID: 11513 RVA: 0x0007F145 File Offset: 0x0007D345
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool AllCharsInUInt32AreAscii(uint value)
		{
			return (value & 4286644096U) == 0U;
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x0007F151 File Offset: 0x0007D351
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool AllCharsInUInt64AreAscii(ulong value)
		{
			return (value & 18410996206198128512UL) == 0UL;
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x0008FC24 File Offset: 0x0008DE24
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint ConvertAllAsciiCharsInUInt32ToLowercase(uint value)
		{
			uint num = value + 8388736U - 4259905U;
			uint num2 = value + 8388736U - 5963867U;
			uint num3 = ((num ^ num2) & 8388736U) >> 2;
			return value ^ num3;
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x0008FC5C File Offset: 0x0008DE5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint ConvertAllAsciiCharsInUInt32ToUppercase(uint value)
		{
			uint num = value + 8388736U - 6357089U;
			uint num2 = value + 8388736U - 8061051U;
			uint num3 = ((num ^ num2) & 8388736U) >> 2;
			return value ^ num3;
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x0008FC94 File Offset: 0x0008DE94
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong ConvertAllAsciiCharsInUInt64ToUppercase(ulong value)
		{
			ulong num = value + 36029346783166592UL - 27303489359118433UL;
			ulong num2 = value + 36029346783166592UL - 34621950424449147UL;
			ulong num3 = ((num ^ num2) & 36029346783166592UL) >> 2;
			return value ^ num3;
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x0008FCE0 File Offset: 0x0008DEE0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static ulong ConvertAllAsciiCharsInUInt64ToLowercase(ulong value)
		{
			ulong num = value + 36029346783166592UL - 18296152663326785UL;
			ulong num2 = value + 36029346783166592UL - 25614613728657499UL;
			ulong num3 = ((num ^ num2) & 36029346783166592UL) >> 2;
			return value ^ num3;
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x0008FD2C File Offset: 0x0008DF2C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool UInt32ContainsAnyLowercaseAsciiChar(uint value)
		{
			uint num = value + 8388736U - 6357089U;
			uint num2 = value + 8388736U - 8061051U;
			return ((num ^ num2) & 8388736U) > 0U;
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0008FD60 File Offset: 0x0008DF60
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool UInt32ContainsAnyUppercaseAsciiChar(uint value)
		{
			uint num = value + 8388736U - 4259905U;
			uint num2 = value + 8388736U - 5963867U;
			return ((num ^ num2) & 8388736U) > 0U;
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x0008FD94 File Offset: 0x0008DF94
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool UInt32OrdinalIgnoreCaseAscii(uint valueA, uint valueB)
		{
			uint num = (valueA ^ valueB) << 2;
			uint num2 = valueA + 327685U;
			num2 |= 10485920U;
			num2 += 1703962U;
			num2 |= 4286578559U;
			return (num & num2) == 0U;
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x0008FDCC File Offset: 0x0008DFCC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool UInt64OrdinalIgnoreCaseAscii(ulong valueA, ulong valueB)
		{
			ulong num = (valueA ^ valueB) << 2;
			ulong num2 = valueA + 1407396358717445UL;
			num2 |= 45036683478958240UL;
			num2 += 7318461065330714UL;
			num2 |= 18410714726926385023UL;
			return (num & num2) == 0UL;
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x0008FE14 File Offset: 0x0008E014
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool AllCharsInVectorAreAscii<TVector>(TVector vec) where TVector : struct, ISimdVector<TVector, ushort>
		{
			TVector tvector = vec & ISimdVector<TVector, ushort>.Create(65408);
			return tvector.Equals(ISimdVector<TVector, ushort>.Zero);
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x0008FE58 File Offset: 0x0008E058
		public unsafe static char* GetPointerToFirstInvalidChar(char* pInputBuffer, int inputLength, out long utf8CodeUnitCountAdjustment, out int scalarCountAdjustment)
		{
			int num = (int)Ascii.GetIndexOfFirstNonAsciiChar(pInputBuffer, (UIntPtr)inputLength);
			pInputBuffer += (ulong)num * 2UL / 2UL;
			inputLength -= num;
			if (inputLength == 0)
			{
				utf8CodeUnitCountAdjustment = 0L;
				scalarCountAdjustment = 0;
				return pInputBuffer;
			}
			long num2 = 0L;
			int num3 = 0;
			char* ptr = pInputBuffer + (ulong)inputLength * 2UL / 2UL;
			if (Sse2.IsSupported)
			{
				if (inputLength >= Vector128<ushort>.Count)
				{
					Vector128<ushort> right = Vector128.Create(128);
					Vector128<ushort> vector = Vector128.Create(30720);
					Vector128<ushort> right2 = Vector128.Create(40960);
					char* ptr2 = ptr - Vector128<ushort>.Count;
					do
					{
						Vector128<ushort> vector2 = Vector128.Load<ushort>((ushort*)pInputBuffer);
						pInputBuffer += Vector128<ushort>.Count;
						Vector128<ushort> left = Vector128.Min<ushort>(vector2, right);
						Vector128<ushort> right3 = Vector128.AddSaturate(vector2, vector);
						uint num4 = (left | right3).AsByte<ushort>().ExtractMostSignificantBits<byte>();
						UIntPtr uintPtr = (UIntPtr)BitOperations.PopCount(num4);
						for (num4 = Vector128.LessThan<short>((vector2 + right2).AsInt16<ushort>(), vector.AsInt16<ushort>()).AsByte<short>().ExtractMostSignificantBits<byte>(); num4 != 65535U; num4 = 65535U)
						{
							num4 = ~num4;
							uint num5 = Vector128.ShiftRightLogical(vector2, 3).AsByte<ushort>().ExtractMostSignificantBits<byte>();
							uint num6 = num5 & num4;
							uint num7 = (num5 ^ 21845U) & num4;
							num7 <<= 2;
							if ((uint)((ushort)num7) != num6)
							{
								goto IL_182;
							}
							if (num7 > 65535U)
							{
								num7 = (uint)((ushort)num7);
								uintPtr -= (UIntPtr)((IntPtr)2);
								pInputBuffer--;
							}
							UIntPtr uintPtr2 = (UIntPtr)BitOperations.PopCount(num7);
							num3 -= (int)uintPtr2;
							num2 -= (long)((ulong)uintPtr2);
							num2 -= (long)((ulong)uintPtr2);
						}
						num2 += (long)((ulong)uintPtr);
					}
					while (pInputBuffer == ptr2);
					goto IL_3A6;
					IL_182:
					pInputBuffer -= Vector128<ushort>.Count;
				}
			}
			else if (Vector128.IsHardwareAccelerated && inputLength >= Vector128<ushort>.Count)
			{
				Vector128<ushort> right4 = Vector128.Create<ushort>(128);
				Vector128<ushort> right5 = Vector128.Create<ushort>(1024);
				Vector128<ushort> right6 = Vector128.Create<ushort>(2048);
				Vector128<ushort> right7 = Vector128.Create<ushort>(55296);
				char* ptr3 = ptr - Vector128<ushort>.Count;
				do
				{
					Vector128<ushort> left2 = Vector128.Load<ushort>((ushort*)pInputBuffer);
					Vector128<ushort> right8 = Vector128.GreaterThanOrEqual<ushort>(left2, right4);
					Vector128<ushort> right9 = Vector128.GreaterThanOrEqual<ushort>(left2, right6);
					Vector128<UIntPtr> vector3 = (Vector128<ushort>.Zero - right8 - right9).AsNUInt<ushort>();
					UIntPtr uintPtr3 = (UIntPtr)((IntPtr)0);
					for (int i = 0; i < Vector128<UIntPtr>.Count; i++)
					{
						uintPtr3 += vector3[i];
					}
					uint num8 = (uint)uintPtr3;
					num8 += (uint)(uintPtr3 >> (32 & 8 * 8 - 1));
					num8 = (uint)((ushort)num8) + (num8 >> 16);
					left2 -= right7;
					Vector128<ushort> left3 = Vector128.LessThan<ushort>(left2, right6);
					if (left3 != Vector128<ushort>.Zero)
					{
						Vector128<ushort> right10 = Vector128.LessThan<ushort>(left2, right5);
						Vector128<ushort> vector4 = Vector128.AndNot<ushort>(left3, right10);
						if (vector4[0] != 0)
						{
							goto IL_3AA;
						}
						ushort num9 = 0;
						for (int j = 0; j < Vector128<ushort>.Count - 1; j++)
						{
							num9 -= right10[j];
							if (right10[j] != vector4[j + 1])
							{
								goto IL_3A6;
							}
						}
						if (right10[Vector128<ushort>.Count - 1] != 0)
						{
							pInputBuffer--;
							num8 -= 2U;
						}
						IntPtr intPtr = (IntPtr)((UIntPtr)num9);
						num3 -= (int)intPtr;
						num2 -= (long)intPtr;
						num2 -= (long)intPtr;
					}
					num2 += (long)((ulong)num8);
					pInputBuffer += Vector128<ushort>.Count;
				}
				while (pInputBuffer == ptr3);
			}
			IL_3A6:
			while (pInputBuffer < ptr)
			{
				uint num10 = (uint)(*pInputBuffer);
				if (num10 > 127U)
				{
					num2 += (long)((ulong)(num10 + 129024U >> 16));
					if (UnicodeUtility.IsSurrogateCodePoint(num10))
					{
						num2 -= 2L;
						if (ptr - pInputBuffer < (IntPtr)4)
						{
							break;
						}
						num10 = Unsafe.ReadUnaligned<uint>((void*)pInputBuffer);
						bool flag = num10 != 0U;
						if (!BitConverter.IsLittleEndian)
						{
						}
						if (((flag ? 1 : 0) - -603924480 & -67044352) != 0)
						{
							break;
						}
						num3--;
						num2 += 2L;
						pInputBuffer++;
					}
				}
				pInputBuffer++;
			}
			IL_3AA:
			utf8CodeUnitCountAdjustment = num2;
			scalarCountAdjustment = num3;
			return pInputBuffer;
		}
	}
}
