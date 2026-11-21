using System;
using System.Buffers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Text;
using System.Text.Unicode;

namespace System.Globalization
{
	// Token: 0x02000307 RID: 775
	internal static class Ordinal
	{
		// Token: 0x0600389D RID: 14493 RVA: 0x000BA7DC File Offset: 0x000B89DC
		internal static int CompareStringIgnoreCase(ref char strA, int lengthA, ref char strB, int lengthB)
		{
			int num = Math.Min(lengthA, lengthB);
			int num2 = num;
			ref char ptr = ref strA;
			ref char ptr2 = ref strB;
			while (num != 0 && ptr <= '\u007f' && ptr2 <= '\u007f')
			{
				if (ptr != ptr2 && ((ptr | ' ') != (ptr2 | ' ') || !char.IsAsciiLetter(ptr)))
				{
					int num3 = (int)ptr;
					int num4 = (int)ptr2;
					if (char.IsAsciiLetterLower(ptr))
					{
						num3 -= 32;
					}
					if (char.IsAsciiLetterLower(ptr2))
					{
						num4 -= 32;
					}
					return num3 - num4;
				}
				num--;
				ptr = Unsafe.Add<char>(ref ptr, 1);
				ptr2 = Unsafe.Add<char>(ref ptr2, 1);
			}
			if (num == 0)
			{
				return lengthA - lengthB;
			}
			num2 -= num;
			return Ordinal.CompareStringIgnoreCaseNonAscii(ref ptr, lengthA - num2, ref ptr2, lengthB - num2);
		}

		// Token: 0x0600389E RID: 14494 RVA: 0x000BA87F File Offset: 0x000B8A7F
		internal static int CompareStringIgnoreCaseNonAscii(ref char strA, int lengthA, ref char strB, int lengthB)
		{
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.CompareStringIgnoreCase(ref strA, lengthA, ref strB, lengthB);
			}
			if (GlobalizationMode.UseNls)
			{
				return CompareInfo.NlsCompareStringOrdinalIgnoreCase(ref strA, lengthA, ref strB, lengthB);
			}
			return OrdinalCasing.CompareStringIgnoreCase(ref strA, lengthA, ref strB, lengthB);
		}

		// Token: 0x0600389F RID: 14495 RVA: 0x000BA8AC File Offset: 0x000B8AAC
		private static bool EqualsIgnoreCase_Vector<TVector>(ref char charA, ref char charB, int length) where TVector : struct, ISimdVector<TVector, ushort>
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)length);
			UIntPtr uintPtr2 = uintPtr - (UIntPtr)((IntPtr)ISimdVector<TVector, ushort>.Count);
			UIntPtr uintPtr3 = (UIntPtr)((IntPtr)0);
			TVector right = ISimdVector<TVector, ushort>.Create(32);
			TVector right2 = ISimdVector<TVector, ushort>.Create(97);
			TVector right3 = ISimdVector<TVector, ushort>.Create(25);
			TVector tvector;
			TVector tvector2;
			for (;;)
			{
				tvector = ISimdVector<TVector, ushort>.LoadUnsafe(Unsafe.As<char, ushort>(ref charA), uintPtr3);
				tvector2 = ISimdVector<TVector, ushort>.LoadUnsafe(Unsafe.As<char, ushort>(ref charB), uintPtr3);
				if (!Utf16Utility.AllCharsInVectorAreAscii<TVector>(tvector | tvector2))
				{
					goto IL_212;
				}
				TVector right4 = ~ISimdVector<TVector, ushort>.Equals(tvector, tvector2);
				if (!right4.Equals(ISimdVector<TVector, ushort>.Zero))
				{
					tvector |= right;
					tvector2 |= right;
					if (ISimdVector<TVector, ushort>.GreaterThanAny(tvector - right2 & right4, right3) || !tvector.Equals(tvector2))
					{
						break;
					}
				}
				uintPtr3 += (UIntPtr)((IntPtr)ISimdVector<TVector, ushort>.Count);
				if (uintPtr3 > uintPtr2)
				{
					goto Block_4;
				}
			}
			return false;
			Block_4:
			if (uintPtr3 != uintPtr)
			{
				uintPtr3 = uintPtr - (UIntPtr)((IntPtr)ISimdVector<TVector, ushort>.Count);
				tvector = ISimdVector<TVector, ushort>.LoadUnsafe(Unsafe.As<char, ushort>(ref charA), uintPtr3);
				tvector2 = ISimdVector<TVector, ushort>.LoadUnsafe(Unsafe.As<char, ushort>(ref charB), uintPtr3);
				if (!Utf16Utility.AllCharsInVectorAreAscii<TVector>(tvector | tvector2))
				{
					goto IL_212;
				}
				TVector right5 = ~ISimdVector<TVector, ushort>.Equals(tvector, tvector2);
				if (!right5.Equals(ISimdVector<TVector, ushort>.Zero))
				{
					tvector |= right;
					tvector2 |= right;
					if (ISimdVector<TVector, ushort>.GreaterThanAny(tvector - right2 & right5, right3) || !tvector.Equals(tvector2))
					{
						return false;
					}
				}
			}
			return true;
			IL_212:
			return !Utf16Utility.AllCharsInVectorAreAscii<TVector>(tvector) && !Utf16Utility.AllCharsInVectorAreAscii<TVector>(tvector2) && Ordinal.CompareStringIgnoreCase(Unsafe.Add<char>(ref charA, uintPtr3), (int)(uintPtr - uintPtr3), Unsafe.Add<char>(ref charB, uintPtr3), (int)(uintPtr - uintPtr3)) == 0;
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x000BAAFC File Offset: 0x000B8CFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool EqualsIgnoreCase(ref char charA, ref char charB, int length)
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<ushort>.Count)
			{
				return Ordinal.EqualsIgnoreCase_Scalar(ref charA, ref charB, length);
			}
			if (false)
			{
			}
			if (false)
			{
			}
			return Ordinal.EqualsIgnoreCase_Vector<Vector128<ushort>>(ref charA, ref charB, length);
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x000BAB24 File Offset: 0x000B8D24
		internal unsafe static bool EqualsIgnoreCase_Scalar(ref char charA, ref char charB, int length)
		{
			IntPtr intPtr = IntPtr.Zero;
			while (length >= 4)
			{
				ulong num = Unsafe.ReadUnaligned<ulong>(Unsafe.As<char, byte>(Unsafe.AddByteOffset<char>(ref charA, intPtr)));
				ulong num2 = Unsafe.ReadUnaligned<ulong>(Unsafe.As<char, byte>(Unsafe.AddByteOffset<char>(ref charB, intPtr)));
				ulong num3 = num | num2;
				if (Utf16Utility.AllCharsInUInt32AreAscii((uint)num3 | (uint)(num3 >> 32)))
				{
					if (!Utf16Utility.UInt64OrdinalIgnoreCaseAscii(num, num2))
					{
						return false;
					}
					intPtr += (IntPtr)8;
					length -= 4;
				}
				else
				{
					if (Utf16Utility.AllCharsInUInt64AreAscii(num) || Utf16Utility.AllCharsInUInt64AreAscii(num2))
					{
						return false;
					}
					IL_117:
					return Ordinal.CompareStringIgnoreCase(Unsafe.AddByteOffset<char>(ref charA, intPtr), length, Unsafe.AddByteOffset<char>(ref charB, intPtr), length) == 0;
				}
			}
			uint num4;
			uint num5;
			if (length >= 2)
			{
				num4 = Unsafe.ReadUnaligned<uint>(Unsafe.As<char, byte>(Unsafe.AddByteOffset<char>(ref charA, intPtr)));
				num5 = Unsafe.ReadUnaligned<uint>(Unsafe.As<char, byte>(Unsafe.AddByteOffset<char>(ref charB, intPtr)));
				if (!Utf16Utility.AllCharsInUInt32AreAscii(num4 | num5))
				{
					goto IL_F2;
				}
				if (!Utf16Utility.UInt32OrdinalIgnoreCaseAscii(num4, num5))
				{
					return false;
				}
				intPtr += (IntPtr)4;
				length -= 2;
			}
			if (length == 0)
			{
				return true;
			}
			num4 = (uint)(*Unsafe.AddByteOffset<char>(ref charA, intPtr));
			num5 = (uint)(*Unsafe.AddByteOffset<char>(ref charB, intPtr));
			if ((num4 | num5) <= 127U)
			{
				if (num4 == num5)
				{
					return true;
				}
				num4 |= 32U;
				return num4 - 97U <= 25U && num4 == (num5 | 32U);
			}
			IL_F2:
			if (Utf16Utility.AllCharsInUInt32AreAscii(num4) || Utf16Utility.AllCharsInUInt32AreAscii(num5))
			{
				return false;
			}
			goto IL_117;
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x000BAC60 File Offset: 0x000B8E60
		internal static int IndexOf(string source, string value, int startIndex, int count, bool ignoreCase)
		{
			if (source == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
			}
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.value);
			}
			ReadOnlySpan<char> readOnlySpan;
			if (!source.TryGetSpan(startIndex, count, out readOnlySpan))
			{
				if (startIndex > source.Length)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.startIndex, ExceptionResource.ArgumentOutOfRange_IndexMustBeLessOrEqual);
				}
				else
				{
					ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.count, ExceptionResource.ArgumentOutOfRange_Count);
				}
			}
			int num = ignoreCase ? Ordinal.IndexOfOrdinalIgnoreCase(readOnlySpan, value) : readOnlySpan.IndexOf(value);
			if (num < 0)
			{
				return num;
			}
			return num + startIndex;
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x000BACD0 File Offset: 0x000B8ED0
		internal unsafe static int IndexOfOrdinalIgnoreCase(ReadOnlySpan<char> source, ReadOnlySpan<char> value)
		{
			if (value.Length == 0)
			{
				return 0;
			}
			if (value.Length > source.Length)
			{
				return -1;
			}
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.IndexOfIgnoreCase(source, value);
			}
			if (GlobalizationMode.UseNls)
			{
				return CompareInfo.NlsIndexOfOrdinalCore(source, value, true, true);
			}
			ref char reference = ref MemoryMarshal.GetReference<char>(value);
			char c = reference;
			if (!char.IsAscii(c))
			{
				return OrdinalCasing.IndexOf(source, value);
			}
			int num = value.Length - 1;
			int num2 = source.Length - num;
			ref char reference2 = ref MemoryMarshal.GetReference<char>(source);
			char c2 = '\0';
			char c3 = '\0';
			IntPtr intPtr = (IntPtr)0;
			bool flag = false;
			if (Vector128.IsHardwareAccelerated && num != 0 && num2 >= Vector128<ushort>.Count)
			{
				c2 = *Unsafe.Add<char>(ref reference, num);
				if (char.IsAscii(c2))
				{
					c |= ' ';
					c2 |= ' ';
					IntPtr intPtr2 = (IntPtr)num;
					while (c2 == c && intPtr2 > (IntPtr)1)
					{
						char c4 = *Unsafe.Add<char>(ref reference, intPtr2 - (IntPtr)1);
						if (!char.IsAscii(c4))
						{
							break;
						}
						intPtr2--;
						c2 = (c4 | ' ');
					}
					if (false)
					{
					}
					Vector128<ushort> left = Vector128.Create((ushort)c);
					Vector128<ushort> left2 = Vector128.Create((ushort)c2);
					IntPtr intPtr3 = (IntPtr)num2 - (IntPtr)Vector128<ushort>.Count;
					IntPtr intPtr4;
					for (;;)
					{
						Vector128<ushort> right = Vector128.Equals<ushort>(left2, Vector128.BitwiseOr<ushort>(Vector128.LoadUnsafe(ref reference2, (UIntPtr)(intPtr + intPtr2)), Vector128.Create(32)));
						Vector128<byte> vector = (Vector128.Equals<ushort>(left, Vector128.BitwiseOr<ushort>(Vector128.LoadUnsafe(ref reference2, (UIntPtr)intPtr), Vector128.Create(32))) & right).AsByte<ushort>();
						if (vector != Vector128<byte>.Zero)
						{
							uint num3 = vector.ExtractMostSignificantBits<byte>();
							do
							{
								intPtr4 = (IntPtr)((UIntPtr)(uint.TrailingZeroCount(num3) / 2U));
								if (Ordinal.EqualsIgnoreCase(Unsafe.Add<char>(ref reference2, intPtr + intPtr4), ref reference, value.Length))
								{
									goto Block_19;
								}
								num3 = BitOperations.ResetLowestSetBit(BitOperations.ResetLowestSetBit(num3));
							}
							while (num3 != 0U);
						}
						intPtr += (IntPtr)Vector128<ushort>.Count;
						if (intPtr == (IntPtr)num2)
						{
							break;
						}
						if (intPtr > intPtr3)
						{
							intPtr = intPtr3;
						}
					}
					return -1;
					Block_19:
					return (int)(intPtr + intPtr4);
				}
			}
			if (char.IsAsciiLetter(c))
			{
				c2 = (char)((int)c & -33);
				c3 = (c | ' ');
				flag = true;
			}
			for (;;)
			{
				int num4 = flag ? (PackedSpanHelpers.PackedIndexOfIsSupported ? PackedSpanHelpers.IndexOfAnyIgnoreCase(Unsafe.Add<char>(ref reference2, intPtr), c3, num2) : SpanHelpers.IndexOfAnyChar(Unsafe.Add<char>(ref reference2, intPtr), c2, c3, num2)) : SpanHelpers.IndexOfChar(Unsafe.Add<char>(ref reference2, intPtr), c, num2);
				if (num4 < 0)
				{
					return -1;
				}
				num2 -= num4;
				if (num2 <= 0)
				{
					return -1;
				}
				intPtr += (IntPtr)num4;
				if (num == 0 || Ordinal.EqualsIgnoreCase(Unsafe.Add<char>(ref reference2, (UIntPtr)(intPtr + (IntPtr)1)), Unsafe.Add<char>(ref reference, 1), num))
				{
					break;
				}
				num2--;
				intPtr++;
				if (num2 <= 0)
				{
					return -1;
				}
			}
			return (int)intPtr;
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x000BAF58 File Offset: 0x000B9158
		internal static int LastIndexOfOrdinalIgnoreCase(ReadOnlySpan<char> source, ReadOnlySpan<char> value)
		{
			if (value.Length == 0)
			{
				return source.Length;
			}
			if (value.Length > source.Length)
			{
				return -1;
			}
			if (GlobalizationMode.Invariant)
			{
				return InvariantModeCasing.LastIndexOfIgnoreCase(source, value);
			}
			if (GlobalizationMode.UseNls)
			{
				return CompareInfo.NlsIndexOfOrdinalCore(source, value, true, false);
			}
			return OrdinalCasing.LastIndexOf(source, value);
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x000BAFB0 File Offset: 0x000B91B0
		internal static int ToUpperOrdinal(ReadOnlySpan<char> source, Span<char> destination)
		{
			if (source.Overlaps(destination))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_SpanOverlappedOperation);
			}
			if (destination.Length < source.Length)
			{
				return -1;
			}
			if (GlobalizationMode.Invariant)
			{
				InvariantModeCasing.ToUpper(source, destination);
				return source.Length;
			}
			if (GlobalizationMode.UseNls)
			{
				TextInfo.Invariant.ChangeCaseToUpper(source, destination);
				return source.Length;
			}
			OrdinalCasing.ToUpperOrdinal(source, destination);
			return source.Length;
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x000BB024 File Offset: 0x000B9224
		internal static bool EqualsStringIgnoreCaseUtf8(ref byte strA, int lengthA, ref byte strB, int lengthB)
		{
			int num = Math.Min(lengthA, lengthB);
			int num2 = num;
			ref byte ptr = ref strA;
			ref byte ptr2 = ref strB;
			while (num != 0 && ptr <= 127 && ptr2 <= 127)
			{
				if (ptr != ptr2 && ((ptr | 32) != (ptr2 | 32) || !char.IsAsciiLetter((char)ptr)))
				{
					return false;
				}
				num--;
				ptr = Unsafe.Add<byte>(ref ptr, 1);
				ptr2 = Unsafe.Add<byte>(ref ptr2, 1);
			}
			if (num == 0)
			{
				return lengthA == lengthB;
			}
			num2 -= num;
			return Ordinal.EqualsStringIgnoreCaseNonAsciiUtf8(ref ptr, lengthA - num2, ref ptr2, lengthB - num2);
		}

		// Token: 0x060038A7 RID: 14503 RVA: 0x000BB09C File Offset: 0x000B929C
		internal static bool EqualsStringIgnoreCaseNonAsciiUtf8(ref byte strA, int lengthA, ref byte strB, int lengthB)
		{
			ReadOnlySpan<byte> source = MemoryMarshal.CreateReadOnlySpan<byte>(ref strA, lengthA);
			ReadOnlySpan<byte> source2 = MemoryMarshal.CreateReadOnlySpan<byte>(ref strB, lengthB);
			for (;;)
			{
				Rune value;
				int num;
				OperationStatus operationStatus = Rune.DecodeFromUtf8(source, out value, out num);
				Rune value2;
				int num2;
				OperationStatus operationStatus2 = Rune.DecodeFromUtf8(source2, out value2, out num2);
				if (operationStatus != operationStatus2)
				{
					break;
				}
				if (operationStatus == OperationStatus.Done)
				{
					if (Rune.ToUpperInvariant(value) != Rune.ToUpperInvariant(value2))
					{
						return false;
					}
				}
				else if (!source.Slice(0, num).SequenceEqual(source2.Slice(0, num2)))
				{
					return false;
				}
				source = source.Slice(num);
				source2 = source2.Slice(num2);
				if ((source.Length | source2.Length) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060038A8 RID: 14504 RVA: 0x000BB134 File Offset: 0x000B9334
		private static bool EqualsIgnoreCaseUtf8_Vector128(ref byte charA, int lengthA, ref byte charB, int lengthB)
		{
			UIntPtr uintPtr = (UIntPtr)Math.Min((uint)lengthA, (uint)lengthB);
			UIntPtr uintPtr2 = uintPtr - (UIntPtr)((IntPtr)Vector128<byte>.Count);
			UIntPtr uintPtr3 = (UIntPtr)((IntPtr)0);
			Vector128<byte> vector;
			Vector128<byte> vector2;
			for (;;)
			{
				vector = Vector128.LoadUnsafe<byte>(ref charA, uintPtr3);
				vector2 = Vector128.LoadUnsafe<byte>(ref charB, uintPtr3);
				if (!Utf8Utility.AllBytesInVector128AreAscii(vector | vector2))
				{
					goto IL_73;
				}
				if (!Utf8Utility.Vector128OrdinalIgnoreCaseAscii(vector, vector2))
				{
					break;
				}
				uintPtr3 += (UIntPtr)((IntPtr)Vector128<byte>.Count);
				if (uintPtr3 > uintPtr2)
				{
					goto Block_3;
				}
			}
			return false;
			Block_3:
			if (uintPtr3 == uintPtr)
			{
				return lengthA == lengthB;
			}
			return Ordinal.EqualsIgnoreCaseUtf8_Scalar(Unsafe.Add<byte>(ref charA, uintPtr3), (int)(uintPtr - uintPtr3), Unsafe.Add<byte>(ref charB, uintPtr3), (int)(uintPtr - uintPtr3));
			IL_73:
			return !Utf8Utility.AllBytesInVector128AreAscii(vector) && !Utf8Utility.AllBytesInVector128AreAscii(vector2) && Ordinal.EqualsStringIgnoreCaseUtf8(Unsafe.Add<byte>(ref charA, uintPtr3), lengthA - (int)uintPtr3, Unsafe.Add<byte>(ref charB, uintPtr3), lengthB - (int)uintPtr3);
		}

		// Token: 0x060038A9 RID: 14505 RVA: 0x000BB1E2 File Offset: 0x000B93E2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool EqualsIgnoreCaseUtf8(ref byte charA, int lengthA, ref byte charB, int lengthB)
		{
			if (!Vector128.IsHardwareAccelerated || lengthA < Vector128<byte>.Count || lengthB < Vector128<byte>.Count)
			{
				return Ordinal.EqualsIgnoreCaseUtf8_Scalar(ref charA, lengthA, ref charB, lengthB);
			}
			return Ordinal.EqualsIgnoreCaseUtf8_Vector128(ref charA, lengthA, ref charB, lengthB);
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x000BB210 File Offset: 0x000B9410
		internal unsafe static bool EqualsIgnoreCaseUtf8_Scalar(ref byte charA, int lengthA, ref byte charB, int lengthB)
		{
			IntPtr intPtr = IntPtr.Zero;
			int i = Math.Min(lengthA, lengthB);
			int num = i;
			while (i >= 8)
			{
				ulong num2 = Unsafe.ReadUnaligned<ulong>(Unsafe.AddByteOffset<byte>(ref charA, intPtr));
				ulong num3 = Unsafe.ReadUnaligned<ulong>(Unsafe.AddByteOffset<byte>(ref charB, intPtr));
				ulong num4 = num2 | num3;
				if (Utf8Utility.AllBytesInUInt32AreAscii((uint)num4 | (uint)(num4 >> 32)))
				{
					if (!Utf8Utility.UInt64OrdinalIgnoreCaseAscii(num2, num3))
					{
						return false;
					}
					intPtr += (IntPtr)8;
					i -= 8;
				}
				else
				{
					if (Utf8Utility.AllBytesInUInt64AreAscii(num2) || Utf8Utility.AllBytesInUInt64AreAscii(num3))
					{
						return false;
					}
					IL_185:
					num -= i;
					return Ordinal.EqualsStringIgnoreCaseUtf8(Unsafe.AddByteOffset<byte>(ref charA, intPtr), lengthA - num, Unsafe.AddByteOffset<byte>(ref charB, intPtr), lengthB - num);
				}
			}
			uint num5;
			uint num6;
			if (i >= 4)
			{
				num5 = Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref charA, intPtr));
				num6 = Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref charB, intPtr));
				if (!Utf8Utility.AllBytesInUInt32AreAscii(num5 | num6))
				{
					goto IL_15E;
				}
				if (!Utf8Utility.UInt32OrdinalIgnoreCaseAscii(num5, num6))
				{
					return false;
				}
				intPtr += (IntPtr)4;
				i -= 4;
			}
			if (i == 0)
			{
				return lengthA == lengthB;
			}
			if (i == 3)
			{
				num5 = (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref charA, intPtr));
				num6 = (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref charB, intPtr));
				intPtr += (IntPtr)2;
				num5 |= (uint)((uint)(*Unsafe.AddByteOffset<byte>(ref charA, intPtr)) << 16);
				num6 |= (uint)((uint)(*Unsafe.AddByteOffset<byte>(ref charB, intPtr)) << 16);
			}
			else if (i == 2)
			{
				num5 = (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref charA, intPtr));
				num6 = (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref charB, intPtr));
			}
			else
			{
				num5 = (uint)(*Unsafe.AddByteOffset<byte>(ref charA, intPtr));
				num6 = (uint)(*Unsafe.AddByteOffset<byte>(ref charB, intPtr));
			}
			if (Utf8Utility.AllBytesInUInt32AreAscii(num5 | num6))
			{
				return lengthA == lengthB && (num5 == num6 || Utf8Utility.UInt32OrdinalIgnoreCaseAscii(num5, num6));
			}
			IL_15E:
			if (Utf8Utility.AllBytesInUInt32AreAscii(num5) || Utf8Utility.AllBytesInUInt32AreAscii(num6))
			{
				return false;
			}
			goto IL_185;
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x000BB3C0 File Offset: 0x000B95C0
		internal static bool StartsWithStringIgnoreCaseUtf8(ref byte source, int sourceLength, ref byte prefix, int prefixLength)
		{
			int num = Math.Min(sourceLength, prefixLength);
			int num2 = num;
			while (num != 0 && source <= 127 && prefix <= 127)
			{
				if (source != prefix && ((source | 32) != (prefix | 32) || !char.IsAsciiLetter((char)source)))
				{
					return false;
				}
				num--;
				source = Unsafe.Add<byte>(ref source, 1);
				prefix = Unsafe.Add<byte>(ref prefix, 1);
			}
			if (num == 0)
			{
				return prefixLength == 0;
			}
			num2 -= num;
			return Ordinal.StartsWithStringIgnoreCaseNonAsciiUtf8(ref source, sourceLength - num2, ref prefix, prefixLength - num2);
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x000BB438 File Offset: 0x000B9638
		internal static bool StartsWithStringIgnoreCaseNonAsciiUtf8(ref byte source, int sourceLength, ref byte prefix, int prefixLength)
		{
			ReadOnlySpan<byte> source2 = MemoryMarshal.CreateReadOnlySpan<byte>(ref source, sourceLength);
			ReadOnlySpan<byte> source3 = MemoryMarshal.CreateReadOnlySpan<byte>(ref prefix, prefixLength);
			for (;;)
			{
				Rune value;
				int num;
				OperationStatus operationStatus = Rune.DecodeFromUtf8(source2, out value, out num);
				Rune value2;
				int num2;
				OperationStatus operationStatus2 = Rune.DecodeFromUtf8(source3, out value2, out num2);
				if (operationStatus != operationStatus2)
				{
					break;
				}
				if (operationStatus == OperationStatus.Done)
				{
					if (Rune.ToUpperInvariant(value) != Rune.ToUpperInvariant(value2))
					{
						return false;
					}
				}
				else if (!source2.Slice(0, num).SequenceEqual(source3.Slice(0, num2)))
				{
					return false;
				}
				source2 = source2.Slice(num);
				source3 = source3.Slice(num2);
				if (source3.Length == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x000BB4C8 File Offset: 0x000B96C8
		private static bool StartsWithIgnoreCaseUtf8_Vector128(ref byte source, int sourceLength, ref byte prefix, int prefixLength)
		{
			UIntPtr uintPtr = (UIntPtr)Math.Min((uint)sourceLength, (uint)prefixLength);
			UIntPtr uintPtr2 = uintPtr - (UIntPtr)((IntPtr)Vector128<byte>.Count);
			UIntPtr uintPtr3 = (UIntPtr)((IntPtr)0);
			Vector128<byte> vector;
			Vector128<byte> vector2;
			for (;;)
			{
				vector = Vector128.LoadUnsafe<byte>(ref source, uintPtr3);
				vector2 = Vector128.LoadUnsafe<byte>(ref prefix, uintPtr3);
				if (!Utf8Utility.AllBytesInVector128AreAscii(vector | vector2))
				{
					goto IL_71;
				}
				if (!Utf8Utility.Vector128OrdinalIgnoreCaseAscii(vector, vector2))
				{
					break;
				}
				uintPtr3 += (UIntPtr)((IntPtr)Vector128<byte>.Count);
				if (uintPtr3 > uintPtr2)
				{
					goto Block_3;
				}
			}
			return false;
			Block_3:
			return uintPtr3 == (UIntPtr)prefixLength || Ordinal.StartsWithIgnoreCaseUtf8_Scalar(Unsafe.Add<byte>(ref source, uintPtr3), (int)(uintPtr - uintPtr3), Unsafe.Add<byte>(ref prefix, uintPtr3), (int)(uintPtr - uintPtr3));
			IL_71:
			return !Utf8Utility.AllBytesInVector128AreAscii(vector) && !Utf8Utility.AllBytesInVector128AreAscii(vector2) && Ordinal.StartsWithStringIgnoreCaseUtf8(Unsafe.Add<byte>(ref source, uintPtr3), sourceLength - (int)uintPtr3, Unsafe.Add<byte>(ref prefix, uintPtr3), prefixLength - (int)uintPtr3);
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x000BB574 File Offset: 0x000B9774
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool StartsWithIgnoreCaseUtf8(ref byte source, int sourceLength, ref byte prefix, int prefixLength)
		{
			if (!Vector128.IsHardwareAccelerated || sourceLength < Vector128<byte>.Count || prefixLength < Vector128<byte>.Count)
			{
				return Ordinal.StartsWithIgnoreCaseUtf8_Scalar(ref source, sourceLength, ref prefix, prefixLength);
			}
			return Ordinal.StartsWithIgnoreCaseUtf8_Vector128(ref source, sourceLength, ref prefix, prefixLength);
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x000BB5A0 File Offset: 0x000B97A0
		internal unsafe static bool StartsWithIgnoreCaseUtf8_Scalar(ref byte source, int sourceLength, ref byte prefix, int prefixLength)
		{
			IntPtr intPtr = IntPtr.Zero;
			int i = Math.Min(sourceLength, prefixLength);
			int num = i;
			while (i >= 8)
			{
				ulong num2 = Unsafe.ReadUnaligned<ulong>(Unsafe.AddByteOffset<byte>(ref source, intPtr));
				ulong num3 = Unsafe.ReadUnaligned<ulong>(Unsafe.AddByteOffset<byte>(ref prefix, intPtr));
				ulong num4 = num2 | num3;
				if (Utf8Utility.AllBytesInUInt32AreAscii((uint)num4 | (uint)(num4 >> 32)))
				{
					if (!Utf8Utility.UInt64OrdinalIgnoreCaseAscii(num2, num3))
					{
						return false;
					}
					intPtr += (IntPtr)8;
					i -= 8;
				}
				else
				{
					if (Utf8Utility.AllBytesInUInt64AreAscii(num2) || Utf8Utility.AllBytesInUInt64AreAscii(num3))
					{
						return false;
					}
					IL_194:
					num -= i;
					return Ordinal.StartsWithStringIgnoreCaseUtf8(Unsafe.AddByteOffset<byte>(ref source, intPtr), sourceLength - num, Unsafe.AddByteOffset<byte>(ref prefix, intPtr), prefixLength - num);
				}
			}
			uint num5;
			uint num6;
			if (i >= 4)
			{
				num5 = Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref source, intPtr));
				num6 = Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref prefix, intPtr));
				if (!Utf8Utility.AllBytesInUInt32AreAscii(num5 | num6))
				{
					goto IL_16D;
				}
				if (!Utf8Utility.UInt32OrdinalIgnoreCaseAscii(num5, num6))
				{
					return false;
				}
				intPtr += (IntPtr)4;
				i -= 4;
			}
			if (i != 0)
			{
				if (i == 3)
				{
					num5 = (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref source, intPtr));
					num6 = (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref prefix, intPtr));
					intPtr += (IntPtr)2;
					num5 |= (uint)((uint)(*Unsafe.AddByteOffset<byte>(ref source, intPtr)) << 16);
					num6 |= (uint)((uint)(*Unsafe.AddByteOffset<byte>(ref prefix, intPtr)) << 16);
				}
				else if (i == 2)
				{
					num5 = (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref source, intPtr));
					num6 = (uint)Unsafe.ReadUnaligned<ushort>(Unsafe.AddByteOffset<byte>(ref prefix, intPtr));
				}
				else
				{
					num5 = (uint)(*Unsafe.AddByteOffset<byte>(ref source, intPtr));
					num6 = (uint)(*Unsafe.AddByteOffset<byte>(ref prefix, intPtr));
				}
				if (!Utf8Utility.AllBytesInUInt32AreAscii(num5 | num6))
				{
					goto IL_16D;
				}
				if (num != prefixLength)
				{
					return false;
				}
				if (num5 == num6)
				{
					return true;
				}
				if (!Utf8Utility.UInt32OrdinalIgnoreCaseAscii(num5, num6))
				{
					return false;
				}
				intPtr += (IntPtr)4;
				i -= 4;
			}
			return prefixLength <= sourceLength;
			IL_16D:
			if (Utf8Utility.AllBytesInUInt32AreAscii(num5) || Utf8Utility.AllBytesInUInt32AreAscii(num6))
			{
				return false;
			}
			goto IL_194;
		}
	}
}
