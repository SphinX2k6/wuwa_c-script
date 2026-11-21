using System;
using System.Buffers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;
using System.Text.Unicode;

namespace System.Text
{
	// Token: 0x0200020A RID: 522
	public static class Ascii
	{
		// Token: 0x060028B5 RID: 10421 RVA: 0x0007E10B File Offset: 0x0007C30B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsValid(ReadOnlySpan<byte> value)
		{
			return Ascii.IsValidCore<byte>(MemoryMarshal.GetReference<byte>(value), value.Length);
		}

		// Token: 0x060028B6 RID: 10422 RVA: 0x0007E11F File Offset: 0x0007C31F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsValid(ReadOnlySpan<char> value)
		{
			return Ascii.IsValidCore<ushort>(Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(value)), value.Length);
		}

		// Token: 0x060028B7 RID: 10423 RVA: 0x0007E138 File Offset: 0x0007C338
		public static bool IsValid(byte value)
		{
			return value <= 127;
		}

		// Token: 0x060028B8 RID: 10424 RVA: 0x0007E138 File Offset: 0x0007C338
		public static bool IsValid(char value)
		{
			return value <= '\u007f';
		}

		// Token: 0x060028B9 RID: 10425 RVA: 0x0007E144 File Offset: 0x0007C344
		private unsafe static bool IsValidCore<[IsUnmanaged] T>(ref T searchSpace, int length) where T : struct, ValueType
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<T>.Count)
			{
				uint num = (uint)(8 / sizeof(T));
				if ((long)length >= (long)((ulong)num))
				{
					UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
					if (!Vector128.IsHardwareAccelerated && (long)length > (long)((ulong)(2U * num)))
					{
						UIntPtr uintPtr2 = (UIntPtr)((IntPtr)length - (IntPtr)((UIntPtr)(2U * num)));
						while (uintPtr < uintPtr2)
						{
							if (!Ascii.AllCharsInUInt64AreAscii<T>(Unsafe.ReadUnaligned<ulong>(Unsafe.As<T, byte>(Unsafe.Add<T>(ref searchSpace, uintPtr))) | Unsafe.ReadUnaligned<ulong>(Unsafe.As<T, byte>(Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)num)))))
							{
								return false;
							}
							uintPtr += (UIntPtr)(2U * num);
						}
						uintPtr = uintPtr2;
					}
					return Ascii.AllCharsInUInt64AreAscii<T>(Unsafe.ReadUnaligned<ulong>(Unsafe.As<T, byte>(Unsafe.Add<T>(ref searchSpace, uintPtr))) | Unsafe.ReadUnaligned<ulong>(Unsafe.Subtract<byte>(Unsafe.As<T, byte>(Unsafe.Add<T>(ref searchSpace, length)), 8)));
				}
				if (typeof(T) == typeof(byte) && length >= 4)
				{
					return Ascii.AllBytesInUInt32AreAscii(Unsafe.ReadUnaligned<uint>(Unsafe.As<T, byte>(ref searchSpace)) | Unsafe.ReadUnaligned<uint>(Unsafe.As<T, byte>(Unsafe.Add<T>(ref searchSpace, length - 4))));
				}
				for (UIntPtr uintPtr3 = (UIntPtr)((IntPtr)0); uintPtr3 < (UIntPtr)length; uintPtr3++)
				{
					if ((typeof(T) == typeof(byte)) ? (Unsafe.BitCast<T, byte>(*Unsafe.Add<T>(ref searchSpace, uintPtr3)) > 127) : (Unsafe.BitCast<T, char>(*Unsafe.Add<T>(ref searchSpace, uintPtr3)) > '\u007f'))
					{
						return false;
					}
				}
				return true;
			}
			else
			{
				ref T source = ref Unsafe.Add<T>(ref searchSpace, length);
				if (length <= 2 * Vector128<T>.Count)
				{
					return Ascii.AllCharsInVectorAreAscii<T>(Vector128.LoadUnsafe<T>(ref searchSpace) | Vector128.LoadUnsafe<T>(Unsafe.Subtract<T>(ref source, Vector128<T>.Count)));
				}
				if (false)
				{
				}
				if (length > 4 * Vector128<T>.Count)
				{
					if (!Ascii.AllCharsInVectorAreAscii<T>(Vector128.LoadUnsafe<T>(ref searchSpace) | Vector128.LoadUnsafe<T>(ref searchSpace, (UIntPtr)((IntPtr)Vector128<T>.Count)) | Vector128.LoadUnsafe<T>(ref searchSpace, (UIntPtr)((IntPtr)2 * (IntPtr)Vector128<T>.Count)) | Vector128.LoadUnsafe<T>(ref searchSpace, (UIntPtr)((IntPtr)3 * (IntPtr)Vector128<T>.Count))))
					{
						return false;
					}
					UIntPtr uintPtr4 = (UIntPtr)((IntPtr)4 * (IntPtr)Vector128<T>.Count);
					UIntPtr uintPtr5 = Unsafe.OpportunisticMisalignment<T>(ref searchSpace, (UIntPtr)Vector128<byte>.Count) / (UIntPtr)((IntPtr)sizeof(T));
					uintPtr4 -= uintPtr5;
					UIntPtr uintPtr6 = (UIntPtr)((IntPtr)length - (IntPtr)4 * (IntPtr)Vector128<T>.Count);
					while (uintPtr4 < uintPtr6)
					{
						ref T source2 = ref Unsafe.Add<T>(ref searchSpace, uintPtr4);
						if (!Ascii.AllCharsInVectorAreAscii<T>(Vector128.LoadUnsafe<T>(ref source2) | Vector128.LoadUnsafe<T>(ref source2, (UIntPtr)((IntPtr)Vector128<T>.Count)) | Vector128.LoadUnsafe<T>(ref source2, (UIntPtr)((IntPtr)2 * (IntPtr)Vector128<T>.Count)) | Vector128.LoadUnsafe<T>(ref source2, (UIntPtr)((IntPtr)3 * (IntPtr)Vector128<T>.Count))))
						{
							return false;
						}
						uintPtr4 += (UIntPtr)((IntPtr)4 * (IntPtr)Vector128<T>.Count);
					}
					searchSpace = Unsafe.Add<T>(ref searchSpace, uintPtr6);
				}
				return Ascii.AllCharsInVectorAreAscii<T>(Vector128.LoadUnsafe<T>(ref searchSpace) | Vector128.LoadUnsafe<T>(ref searchSpace, (UIntPtr)((IntPtr)Vector128<T>.Count)) | Vector128.LoadUnsafe<T>(Unsafe.Subtract<T>(ref source, 2 * Vector128<T>.Count)) | Vector128.LoadUnsafe<T>(Unsafe.Subtract<T>(ref source, Vector128<T>.Count)));
			}
		}

		// Token: 0x060028BA RID: 10426 RVA: 0x0007E420 File Offset: 0x0007C620
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToUpper(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten)
		{
			return Ascii.ChangeCase<byte, byte, Ascii.ToUpperConversion>(source, destination, out bytesWritten);
		}

		// Token: 0x060028BB RID: 10427 RVA: 0x0007E42A File Offset: 0x0007C62A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToUpper(ReadOnlySpan<char> source, Span<char> destination, out int charsWritten)
		{
			return Ascii.ChangeCase<ushort, ushort, Ascii.ToUpperConversion>(MemoryMarshal.Cast<char, ushort>(source), MemoryMarshal.Cast<char, ushort>(destination), out charsWritten);
		}

		// Token: 0x060028BC RID: 10428 RVA: 0x0007E43E File Offset: 0x0007C63E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToUpper(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten)
		{
			return Ascii.ChangeCase<byte, ushort, Ascii.ToUpperConversion>(source, MemoryMarshal.Cast<char, ushort>(destination), out charsWritten);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0007E44D File Offset: 0x0007C64D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToUpper(ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten)
		{
			return Ascii.ChangeCase<ushort, byte, Ascii.ToUpperConversion>(MemoryMarshal.Cast<char, ushort>(source), destination, out bytesWritten);
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0007E45C File Offset: 0x0007C65C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToLower(ReadOnlySpan<byte> source, Span<byte> destination, out int bytesWritten)
		{
			return Ascii.ChangeCase<byte, byte, Ascii.ToLowerConversion>(source, destination, out bytesWritten);
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0007E466 File Offset: 0x0007C666
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToLower(ReadOnlySpan<char> source, Span<char> destination, out int charsWritten)
		{
			return Ascii.ChangeCase<ushort, ushort, Ascii.ToLowerConversion>(MemoryMarshal.Cast<char, ushort>(source), MemoryMarshal.Cast<char, ushort>(destination), out charsWritten);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0007E47A File Offset: 0x0007C67A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToLower(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten)
		{
			return Ascii.ChangeCase<byte, ushort, Ascii.ToLowerConversion>(source, MemoryMarshal.Cast<char, ushort>(destination), out charsWritten);
		}

		// Token: 0x060028C1 RID: 10433 RVA: 0x0007E489 File Offset: 0x0007C689
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToLower(ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten)
		{
			return Ascii.ChangeCase<ushort, byte, Ascii.ToLowerConversion>(MemoryMarshal.Cast<char, ushort>(source), destination, out bytesWritten);
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x0007E498 File Offset: 0x0007C698
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToLowerInPlace(Span<byte> value, out int bytesWritten)
		{
			return Ascii.ChangeCase<byte, Ascii.ToLowerConversion>(value, out bytesWritten);
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0007E4A1 File Offset: 0x0007C6A1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToLowerInPlace(Span<char> value, out int charsWritten)
		{
			return Ascii.ChangeCase<ushort, Ascii.ToLowerConversion>(MemoryMarshal.Cast<char, ushort>(value), out charsWritten);
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x0007E4AF File Offset: 0x0007C6AF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToUpperInPlace(Span<byte> value, out int bytesWritten)
		{
			return Ascii.ChangeCase<byte, Ascii.ToUpperConversion>(value, out bytesWritten);
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x0007E4B8 File Offset: 0x0007C6B8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static OperationStatus ToUpperInPlace(Span<char> value, out int charsWritten)
		{
			return Ascii.ChangeCase<ushort, Ascii.ToUpperConversion>(MemoryMarshal.Cast<char, ushort>(value), out charsWritten);
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x0007E4C8 File Offset: 0x0007C6C8
		private unsafe static OperationStatus ChangeCase<[IsUnmanaged] TFrom, [IsUnmanaged] TTo, TCasing>(ReadOnlySpan<TFrom> source, Span<TTo> destination, out int destinationElementsWritten) where TFrom : struct, ValueType, IBinaryInteger<TFrom> where TTo : struct, ValueType, IBinaryInteger<TTo> where TCasing : struct
		{
			if (MemoryMarshal.AsBytes<TFrom>(source).Overlaps(MemoryMarshal.AsBytes<TTo>(destination)))
			{
				ThrowHelper.ThrowInvalidOperationException(ExceptionResource.InvalidOperation_SpanOverlappedOperation);
			}
			UIntPtr uintPtr;
			OperationStatus result;
			if (source.Length <= destination.Length)
			{
				uintPtr = (UIntPtr)source.Length;
				result = OperationStatus.Done;
			}
			else
			{
				uintPtr = (UIntPtr)destination.Length;
				result = OperationStatus.DestinationTooSmall;
			}
			fixed (TFrom* reference = MemoryMarshal.GetReference<TFrom>(source))
			{
				TFrom* pSrc = reference;
				fixed (TTo* reference2 = MemoryMarshal.GetReference<TTo>(destination))
				{
					TTo* pDest = reference2;
					UIntPtr uintPtr2 = Ascii.ChangeCase<TFrom, TTo, TCasing>(pSrc, pDest, uintPtr);
					destinationElementsWritten = (int)uintPtr2;
					if (uintPtr != uintPtr2)
					{
						return OperationStatus.InvalidData;
					}
					return result;
				}
			}
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x0007E548 File Offset: 0x0007C748
		private unsafe static OperationStatus ChangeCase<[IsUnmanaged] T, TCasing>(Span<T> buffer, out int elementsWritten) where T : struct, ValueType, IBinaryInteger<T> where TCasing : struct
		{
			fixed (T* reference = MemoryMarshal.GetReference<T>(buffer))
			{
				T* ptr = reference;
				UIntPtr uintPtr = Ascii.ChangeCase<T, T, TCasing>(ptr, ptr, (UIntPtr)((IntPtr)buffer.Length));
				elementsWritten = (int)uintPtr;
				if (elementsWritten != buffer.Length)
				{
					return OperationStatus.InvalidData;
				}
				return OperationStatus.Done;
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x0007E580 File Offset: 0x0007C780
		private unsafe static UIntPtr ChangeCase<[IsUnmanaged] TFrom, [IsUnmanaged] TTo, TCasing>(TFrom* pSrc, TTo* pDest, UIntPtr elementCount) where TFrom : struct, ValueType, IBinaryInteger<TFrom> where TTo : struct, ValueType, IBinaryInteger<TTo> where TCasing : struct
		{
			bool flag = sizeof(TFrom) == 1;
			bool flag2 = sizeof(TTo) == 1;
			bool flag3 = flag && !flag2;
			bool flag4 = typeof(TFrom) == typeof(TTo);
			bool flag5 = typeof(TCasing) == typeof(Ascii.ToUpperConversion);
			uint num = (uint)(sizeof(Vector128<byte>) / sizeof(TFrom));
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			if (flag4 || Vector128.IsHardwareAccelerated)
			{
				if (Vector128.IsHardwareAccelerated && elementCount >= (UIntPtr)num)
				{
					Vector128<TFrom> vector = Vector128.LoadUnsafe<TFrom>(ref *pSrc);
					if (!Ascii.VectorContainsNonAsciiChar<TFrom>(vector))
					{
						TFrom left = INumberBase<TFrom>.CreateTruncating<int>(1 << 8 * sizeof(TFrom) - 1);
						Vector128<TFrom> right = Vector128.Create<TFrom>(flag5 ? (left + INumberBase<TFrom>.CreateTruncating<char>('a')) : (left + INumberBase<TFrom>.CreateTruncating<char>('A')));
						Vector128<TFrom> right2 = Vector128.Create<TFrom>(left + INumberBase<TFrom>.CreateTruncating<int>(26));
						Vector128<TFrom> right3 = Vector128.Create<TFrom>(INumberBase<TFrom>.CreateTruncating<int>(32));
						Vector128<TFrom> left2 = Ascii.SignedLessThan<TFrom>(vector - right, right2);
						vector ^= (left2 & right3);
						Ascii.ChangeWidthAndWriteTo<TFrom, TTo>(vector, pDest, (UIntPtr)((IntPtr)0));
						uint num2 = num * (uint)sizeof(TTo);
						uintPtr = (UIntPtr)(num - pDest % num2 / (uint)sizeof(TTo));
						for (;;)
						{
							if (elementCount - uintPtr < (UIntPtr)num)
							{
								if (uintPtr == elementCount)
								{
									return uintPtr;
								}
								uintPtr = elementCount - (UIntPtr)num;
							}
							vector = Vector128.LoadUnsafe<TFrom>(ref *pSrc, uintPtr);
							if (Ascii.VectorContainsNonAsciiChar<TFrom>(vector))
							{
								break;
							}
							left2 = Ascii.SignedLessThan<TFrom>(vector - right, right2);
							vector ^= (left2 & right3);
							Ascii.ChangeWidthAndWriteTo<TFrom, TTo>(vector, pDest, uintPtr);
							uintPtr += (UIntPtr)num;
						}
					}
				}
				while (elementCount - uintPtr >= (UIntPtr)((IntPtr)(8 / sizeof(TFrom))))
				{
					ulong value = Unsafe.ReadUnaligned<ulong>((void*)(pSrc + (ulong)uintPtr * (ulong)((long)sizeof(TFrom)) / (ulong)sizeof(TFrom)));
					if (flag)
					{
						if (!Utf8Utility.AllBytesInUInt64AreAscii(value))
						{
							break;
						}
						value = (flag5 ? Utf8Utility.ConvertAllAsciiBytesInUInt64ToUppercase(value) : Utf8Utility.ConvertAllAsciiBytesInUInt64ToLowercase(value));
					}
					else
					{
						if (!Utf16Utility.AllCharsInUInt64AreAscii(value))
						{
							break;
						}
						value = (flag5 ? Utf16Utility.ConvertAllAsciiCharsInUInt64ToUppercase(value) : Utf16Utility.ConvertAllAsciiCharsInUInt64ToLowercase(value));
					}
					if (flag4)
					{
						Unsafe.WriteUnaligned<ulong>((void*)(pDest + (ulong)uintPtr * (ulong)((long)sizeof(TTo)) / (ulong)sizeof(TTo)), value);
					}
					else
					{
						Vector128<ulong> vector2 = Vector128.CreateScalarUnsafe(value);
						if (flag3)
						{
							Vector128.WidenLower(vector2.AsByte<ulong>()).StoreUnsafe(ref *(ushort*)pDest, uintPtr);
						}
						else
						{
							Vector128<ushort> vector3 = vector2.AsUInt16<ulong>();
							Vector128<uint> vector4 = Vector128.Narrow(vector3, vector3).AsUInt32<byte>();
							Unsafe.WriteUnaligned<uint>((void*)(pDest + (ulong)uintPtr * (ulong)((long)sizeof(TTo)) / (ulong)sizeof(TTo)), vector4.ToScalar<uint>());
						}
					}
					uintPtr += (UIntPtr)((IntPtr)(8 / sizeof(TFrom)));
					if (Vector128.IsHardwareAccelerated)
					{
						break;
					}
				}
				while (elementCount - uintPtr >= (UIntPtr)((IntPtr)(4 / sizeof(TFrom))))
				{
					uint value2 = Unsafe.ReadUnaligned<uint>((void*)(pSrc + (ulong)uintPtr * (ulong)((long)sizeof(TFrom)) / (ulong)sizeof(TFrom)));
					if (flag)
					{
						if (!Utf8Utility.AllBytesInUInt32AreAscii(value2))
						{
							break;
						}
						value2 = (flag5 ? Utf8Utility.ConvertAllAsciiBytesInUInt32ToUppercase(value2) : Utf8Utility.ConvertAllAsciiBytesInUInt32ToLowercase(value2));
					}
					else
					{
						if (!Utf16Utility.AllCharsInUInt32AreAscii(value2))
						{
							break;
						}
						value2 = (flag5 ? Utf16Utility.ConvertAllAsciiCharsInUInt32ToUppercase(value2) : Utf16Utility.ConvertAllAsciiCharsInUInt32ToLowercase(value2));
					}
					if (flag4)
					{
						Unsafe.WriteUnaligned<uint>((void*)(pDest + (ulong)uintPtr * (ulong)((long)sizeof(TTo)) / (ulong)sizeof(TTo)), value2);
					}
					else
					{
						Vector128<uint> vector5 = Vector128.CreateScalarUnsafe(value2);
						if (flag3)
						{
							Vector128<ulong> vector6 = Vector128.WidenLower(vector5.AsByte<uint>()).AsUInt64<ushort>();
							Unsafe.WriteUnaligned<ulong>((void*)(pDest + (ulong)uintPtr * (ulong)((long)sizeof(TTo)) / (ulong)sizeof(TTo)), vector6.ToScalar<ulong>());
						}
						else
						{
							Vector128<ushort> vector7 = vector5.AsUInt16<uint>();
							Vector128<ushort> vector8 = Vector128.Narrow(vector7, vector7).AsUInt16<byte>();
							Unsafe.WriteUnaligned<ushort>((void*)(pDest + (ulong)uintPtr * (ulong)((long)sizeof(TTo)) / (ulong)sizeof(TTo)), vector8.ToScalar<ushort>());
						}
					}
					uintPtr += (UIntPtr)((IntPtr)(4 / sizeof(TFrom)));
					if (Vector128.IsHardwareAccelerated)
					{
						break;
					}
				}
			}
			while (uintPtr < elementCount)
			{
				uint num3 = uint.CreateTruncating<TFrom>(pSrc[(ulong)uintPtr * (ulong)((long)sizeof(TFrom)) / (ulong)sizeof(TFrom)]);
				if (!UnicodeUtility.IsAsciiCodePoint(num3))
				{
					break;
				}
				if (flag5)
				{
					if (UnicodeUtility.IsInRangeInclusive(num3, 97U, 122U))
					{
						num3 -= 32U;
					}
				}
				else if (UnicodeUtility.IsInRangeInclusive(num3, 65U, 90U))
				{
					num3 += 32U;
				}
				pDest[(ulong)uintPtr * (ulong)((long)sizeof(TTo)) / (ulong)sizeof(TTo)] = INumberBase<TTo>.CreateTruncating<uint>(num3);
				uintPtr++;
			}
			return uintPtr;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x0007E9F8 File Offset: 0x0007CBF8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void ChangeWidthAndWriteTo<[IsUnmanaged] TFrom, [IsUnmanaged] TTo>(Vector128<TFrom> vector, TTo* pDest, UIntPtr elementOffset) where TFrom : struct, ValueType where TTo : struct, ValueType
		{
			if (sizeof(TFrom) == sizeof(TTo))
			{
				vector.As<TFrom, TTo>().StoreUnsafe(ref *pDest, elementOffset);
				return;
			}
			if (sizeof(TFrom) == 1 && sizeof(TTo) == 2)
			{
				if (false)
				{
				}
				Vector128.WidenLower(vector.AsByte<TFrom>()).StoreUnsafe(ref *(ushort*)pDest, elementOffset);
				Vector128.WidenUpper(vector.AsByte<TFrom>()).StoreUnsafe(ref *(ushort*)pDest, elementOffset + (UIntPtr)((IntPtr)8));
				return;
			}
			if (sizeof(TFrom) == 2 && sizeof(TTo) == 1)
			{
				Ascii.ExtractAsciiVector(vector.AsUInt16<TFrom>(), vector.AsUInt16<TFrom>()).StoreLowerUnsafe(ref *(byte*)pDest, elementOffset);
				return;
			}
			throw new NotSupportedException();
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x0007EA90 File Offset: 0x0007CC90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<T> SignedLessThan<[IsUnmanaged] T>(Vector128<T> left, Vector128<T> right) where T : struct, ValueType
		{
			if (sizeof(T) == 1)
			{
				return Vector128.LessThan<sbyte>(left.AsSByte<T>(), right.AsSByte<T>()).As<sbyte, T>();
			}
			if (sizeof(T) == 2)
			{
				return Vector128.LessThan<short>(left.AsInt16<T>(), right.AsInt16<T>()).As<short, T>();
			}
			throw new NotSupportedException();
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x0007EAE2 File Offset: 0x0007CCE2
		public static bool Equals(ReadOnlySpan<byte> left, ReadOnlySpan<byte> right)
		{
			return left.Length == right.Length && Ascii.Equals<byte, byte, Ascii.PlainLoader<byte>>(MemoryMarshal.GetReference<byte>(left), MemoryMarshal.GetReference<byte>(right), (UIntPtr)right.Length);
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x0007EB0F File Offset: 0x0007CD0F
		public static bool Equals(ReadOnlySpan<byte> left, ReadOnlySpan<char> right)
		{
			return left.Length == right.Length && Ascii.Equals<byte, ushort, Ascii.WideningLoader>(MemoryMarshal.GetReference<byte>(left), Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(right)), (UIntPtr)right.Length);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0007EB41 File Offset: 0x0007CD41
		public static bool Equals(ReadOnlySpan<char> left, ReadOnlySpan<byte> right)
		{
			return Ascii.Equals(right, left);
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0007EB4A File Offset: 0x0007CD4A
		public static bool Equals(ReadOnlySpan<char> left, ReadOnlySpan<char> right)
		{
			return left.Length == right.Length && Ascii.Equals<ushort, ushort, Ascii.PlainLoader<ushort>>(Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(left)), Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(right)), (UIntPtr)right.Length);
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0007EB84 File Offset: 0x0007CD84
		private unsafe static bool Equals<[IsUnmanaged] TLeft, [IsUnmanaged] TRight, TLoader>(ref TLeft left, ref TRight right, UIntPtr length) where TLeft : struct, ValueType, INumberBase<TLeft> where TRight : struct, ValueType, INumberBase<TRight> where TLoader : struct, Ascii.ILoader<TLeft, TRight>
		{
			if (!Vector128.IsHardwareAccelerated || length < (UIntPtr)Vector128<TLeft>.Count)
			{
				for (UIntPtr uintPtr = (UIntPtr)((IntPtr)0); uintPtr < length; uintPtr++)
				{
					uint num = uint.CreateTruncating<TLeft>(*Unsafe.Add<TLeft>(ref left, uintPtr));
					uint num2 = uint.CreateTruncating<TRight>(*Unsafe.Add<TRight>(ref right, uintPtr));
					if (num != num2 || !UnicodeUtility.IsAsciiCodePoint(num))
					{
						return false;
					}
				}
			}
			else
			{
				if (false)
				{
				}
				if (false)
				{
				}
				ref TLeft ptr = ref left;
				ref TLeft ptr2 = ref Unsafe.Add<TLeft>(ref ptr, length - Ascii.ILoader<TLeft, TRight>.Count128);
				ref TRight ptr3 = ref right;
				ref TRight ptr4 = ref Unsafe.Add<TRight>(ref ptr3, length - (UIntPtr)Vector128<TRight>.Count);
				for (;;)
				{
					Vector128<TRight> vector = Ascii.ILoader<TLeft, TRight>.Load128(ref ptr);
					Vector128<TRight> right2 = Vector128.LoadUnsafe<TRight>(ref ptr3);
					if (vector != right2 || !Ascii.AllCharsInVectorAreAscii<TRight>(vector))
					{
						break;
					}
					ptr3 = Unsafe.Add<TRight>(ref ptr3, (UIntPtr)Vector128<TRight>.Count);
					ptr = Unsafe.Add<TLeft>(ref ptr, Ascii.ILoader<TLeft, TRight>.Count128);
					if (Unsafe.IsAddressGreaterThan<TRight>(ref ptr3, ref ptr4))
					{
						goto Block_5;
					}
				}
				return false;
				Block_5:
				if (length % (UIntPtr)Vector128<TRight>.Count != 0)
				{
					Vector128<TRight> vector = Ascii.ILoader<TLeft, TRight>.Load128(ref ptr2);
					Vector128<TRight> right2 = Vector128.LoadUnsafe<TRight>(ref ptr4);
					if (vector != right2 || !Ascii.AllCharsInVectorAreAscii<TRight>(vector))
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0007ECB0 File Offset: 0x0007CEB0
		public static bool EqualsIgnoreCase(ReadOnlySpan<byte> left, ReadOnlySpan<byte> right)
		{
			return left.Length == right.Length && Ascii.EqualsIgnoreCase<byte, byte, Ascii.PlainLoader<byte>>(MemoryMarshal.GetReference<byte>(left), MemoryMarshal.GetReference<byte>(right), (UIntPtr)right.Length);
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x0007ECDD File Offset: 0x0007CEDD
		public static bool EqualsIgnoreCase(ReadOnlySpan<byte> left, ReadOnlySpan<char> right)
		{
			return left.Length == right.Length && Ascii.EqualsIgnoreCase<byte, ushort, Ascii.WideningLoader>(MemoryMarshal.GetReference<byte>(left), Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(right)), (UIntPtr)right.Length);
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0007ED0F File Offset: 0x0007CF0F
		public static bool EqualsIgnoreCase(ReadOnlySpan<char> left, ReadOnlySpan<byte> right)
		{
			return Ascii.EqualsIgnoreCase(right, left);
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0007ED18 File Offset: 0x0007CF18
		public static bool EqualsIgnoreCase(ReadOnlySpan<char> left, ReadOnlySpan<char> right)
		{
			return left.Length == right.Length && Ascii.EqualsIgnoreCase<ushort, ushort, Ascii.PlainLoader<ushort>>(Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(left)), Unsafe.As<char, ushort>(MemoryMarshal.GetReference<char>(right)), (UIntPtr)right.Length);
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x0007ED4F File Offset: 0x0007CF4F
		internal static bool EqualsIgnoreCase(ref char left, ref char right, UIntPtr length)
		{
			return Ascii.EqualsIgnoreCase<ushort, ushort, Ascii.PlainLoader<ushort>>(Unsafe.As<char, ushort>(ref left), Unsafe.As<char, ushort>(ref right), length);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x0007ED64 File Offset: 0x0007CF64
		private unsafe static bool EqualsIgnoreCase<[IsUnmanaged] TLeft, [IsUnmanaged] TRight, TLoader>(ref TLeft left, ref TRight right, UIntPtr length) where TLeft : struct, ValueType, INumberBase<TLeft> where TRight : struct, ValueType, INumberBase<TRight> where TLoader : Ascii.ILoader<TLeft, TRight>
		{
			if (!Vector128.IsHardwareAccelerated || length < (UIntPtr)Vector128<TRight>.Count)
			{
				for (UIntPtr uintPtr = (UIntPtr)((IntPtr)0); uintPtr < length; uintPtr++)
				{
					uint num = uint.CreateTruncating<TLeft>(*Unsafe.Add<TLeft>(ref left, uintPtr));
					uint num2 = uint.CreateTruncating<TRight>(*Unsafe.Add<TRight>(ref right, uintPtr));
					if (!UnicodeUtility.IsAsciiCodePoint(num | num2))
					{
						return false;
					}
					if (num != num2)
					{
						num |= 32U;
						if (num - 97U > 25U)
						{
							return false;
						}
						if (num != (num2 | 32U))
						{
							return false;
						}
					}
				}
			}
			else
			{
				if (false)
				{
				}
				if (false)
				{
				}
				ref TLeft ptr = ref left;
				ref TLeft ptr2 = ref Unsafe.Add<TLeft>(ref ptr, length - Ascii.ILoader<TLeft, TRight>.Count128);
				ref TRight ptr3 = ref right;
				ref TRight ptr4 = ref Unsafe.Add<TRight>(ref ptr3, length - (UIntPtr)Vector128<TRight>.Count);
				Vector128<TRight> right2 = Vector128.Create<TRight>(INumberBase<TRight>.CreateTruncating<int>(32));
				Vector128<TRight> right3 = Vector128.Create<TRight>(INumberBase<TRight>.CreateTruncating<char>('a'));
				Vector128<TRight> right4 = Vector128.Create<TRight>(INumberBase<TRight>.CreateTruncating<int>(25));
				for (;;)
				{
					Vector128<TRight> left2 = Ascii.ILoader<TLeft, TRight>.Load128(ref ptr);
					Vector128<TRight> vector = Vector128.LoadUnsafe<TRight>(ref ptr3);
					if (!Ascii.AllCharsInVectorAreAscii<TRight>(left2 | vector))
					{
						break;
					}
					Vector128<TRight> vector2 = ~Vector128.Equals<TRight>(left2, vector);
					if (vector2 != Vector128<TRight>.Zero)
					{
						left2 |= right2;
						vector |= right2;
						if (Vector128.GreaterThanAny<TRight>(left2 - right3 & vector2, right4) || left2 != vector)
						{
							return false;
						}
					}
					ptr3 = Unsafe.Add<TRight>(ref ptr3, (UIntPtr)Vector128<TRight>.Count);
					ptr = Unsafe.Add<TLeft>(ref ptr, Ascii.ILoader<TLeft, TRight>.Count128);
					if (Unsafe.IsAddressGreaterThan<TRight>(ref ptr3, ref ptr4))
					{
						goto Block_10;
					}
				}
				return false;
				Block_10:
				if (length % (UIntPtr)Vector128<TRight>.Count != 0)
				{
					Vector128<TRight> left2 = Ascii.ILoader<TLeft, TRight>.Load128(ref ptr2);
					Vector128<TRight> vector = Vector128.LoadUnsafe<TRight>(ref ptr4);
					if (!Ascii.AllCharsInVectorAreAscii<TRight>(left2 | vector))
					{
						return false;
					}
					Vector128<TRight> vector3 = ~Vector128.Equals<TRight>(left2, vector);
					if (vector3 != Vector128<TRight>.Zero)
					{
						left2 |= right2;
						vector |= right2;
						if (Vector128.GreaterThanAny<TRight>(left2 - right3 & vector3, right4) || left2 != vector)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0007EF9C File Offset: 0x0007D19C
		public unsafe static OperationStatus ToUtf16(ReadOnlySpan<byte> source, Span<char> destination, out int charsWritten)
		{
			UIntPtr uintPtr;
			OperationStatus result;
			if (source.Length <= destination.Length)
			{
				uintPtr = (UIntPtr)source.Length;
				result = OperationStatus.Done;
			}
			else
			{
				uintPtr = (UIntPtr)destination.Length;
				result = OperationStatus.DestinationTooSmall;
			}
			fixed (byte* reference = MemoryMarshal.GetReference<byte>(source))
			{
				byte* pAsciiBuffer = reference;
				fixed (char* reference2 = MemoryMarshal.GetReference<char>(destination))
				{
					char* pUtf16Buffer = reference2;
					UIntPtr uintPtr2 = Ascii.WidenAsciiToUtf16(pAsciiBuffer, pUtf16Buffer, uintPtr);
					charsWritten = (int)uintPtr2;
					if (uintPtr != uintPtr2)
					{
						return OperationStatus.InvalidData;
					}
					return result;
				}
			}
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x0007EFFC File Offset: 0x0007D1FC
		public unsafe static OperationStatus FromUtf16(ReadOnlySpan<char> source, Span<byte> destination, out int bytesWritten)
		{
			UIntPtr uintPtr;
			OperationStatus result;
			if (source.Length <= destination.Length)
			{
				uintPtr = (UIntPtr)source.Length;
				result = OperationStatus.Done;
			}
			else
			{
				uintPtr = (UIntPtr)destination.Length;
				result = OperationStatus.DestinationTooSmall;
			}
			fixed (char* reference = MemoryMarshal.GetReference<char>(source))
			{
				char* pUtf16Buffer = reference;
				fixed (byte* reference2 = MemoryMarshal.GetReference<byte>(destination))
				{
					byte* pAsciiBuffer = reference2;
					UIntPtr uintPtr2 = Ascii.NarrowUtf16ToAscii(pUtf16Buffer, pAsciiBuffer, uintPtr);
					bytesWritten = (int)uintPtr2;
					if (uintPtr != uintPtr2)
					{
						return OperationStatus.InvalidData;
					}
					return result;
				}
			}
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0007F05C File Offset: 0x0007D25C
		public static Range Trim(ReadOnlySpan<byte> value)
		{
			return Ascii.TrimHelper<byte>(value, TrimType.Both);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0007F065 File Offset: 0x0007D265
		public static Range Trim(ReadOnlySpan<char> value)
		{
			return Ascii.TrimHelper<char>(value, TrimType.Both);
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x0007F06E File Offset: 0x0007D26E
		public static Range TrimStart(ReadOnlySpan<byte> value)
		{
			return Ascii.TrimHelper<byte>(value, TrimType.Head);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x0007F077 File Offset: 0x0007D277
		public static Range TrimStart(ReadOnlySpan<char> value)
		{
			return Ascii.TrimHelper<char>(value, TrimType.Head);
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x0007F080 File Offset: 0x0007D280
		public static Range TrimEnd(ReadOnlySpan<byte> value)
		{
			return Ascii.TrimHelper<byte>(value, TrimType.Tail);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0007F089 File Offset: 0x0007D289
		public static Range TrimEnd(ReadOnlySpan<char> value)
		{
			return Ascii.TrimHelper<char>(value, TrimType.Tail);
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0007F094 File Offset: 0x0007D294
		private unsafe static Range TrimHelper<[IsUnmanaged] T>(ReadOnlySpan<T> value, TrimType trimType) where T : struct, ValueType, IBinaryInteger<T>
		{
			int i = 0;
			if ((trimType & TrimType.Head) != (TrimType)0)
			{
				while (i < value.Length)
				{
					uint num = uint.CreateTruncating<T>(*value[i]) - 1U;
					if (num > 31U || (-2147475712 & 1 << (int)num) == 0)
					{
						break;
					}
					i++;
				}
			}
			int num2 = value.Length - 1;
			if ((trimType & TrimType.Tail) != (TrimType)0)
			{
				while (i <= num2)
				{
					uint num3 = uint.CreateTruncating<T>(*value[num2]) - 1U;
					if (num3 > 31U || (-2147475712 & 1 << (int)num3) == 0)
					{
						break;
					}
					num2--;
				}
			}
			return new Range(i, num2 + 1);
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0007F134 File Offset: 0x0007D334
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllBytesInUInt64AreAscii(ulong value)
		{
			return (value & 9259542123273814144UL) == 0UL;
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0007F145 File Offset: 0x0007D345
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllCharsInUInt32AreAscii(uint value)
		{
			return (value & 4286644096U) == 0U;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0007F151 File Offset: 0x0007D351
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllCharsInUInt64AreAscii(ulong value)
		{
			return (value & 18410996206198128512UL) == 0UL;
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x0007F162 File Offset: 0x0007D362
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllCharsInUInt64AreAscii<[IsUnmanaged] T>(ulong value) where T : struct, ValueType
		{
			if (!(typeof(T) == typeof(byte)))
			{
				return Ascii.AllCharsInUInt64AreAscii(value);
			}
			return Ascii.AllBytesInUInt64AreAscii(value);
		}

		// Token: 0x060028E3 RID: 10467 RVA: 0x0007F18C File Offset: 0x0007D38C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool FirstCharInUInt32IsAscii(uint value)
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

		// Token: 0x060028E4 RID: 10468 RVA: 0x0007F1A7 File Offset: 0x0007D3A7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static UIntPtr GetIndexOfFirstNonAsciiByte(byte* pBuffer, UIntPtr bufferLength)
		{
			if (Sse2.IsSupported || false)
			{
				return Ascii.GetIndexOfFirstNonAsciiByte_Intrinsified(pBuffer, bufferLength);
			}
			return Ascii.GetIndexOfFirstNonAsciiByte_Vector(pBuffer, bufferLength);
		}

		// Token: 0x060028E5 RID: 10469 RVA: 0x0007F1C8 File Offset: 0x0007D3C8
		private unsafe static UIntPtr GetIndexOfFirstNonAsciiByte_Vector(byte* pBuffer, UIntPtr bufferLength)
		{
			byte* ptr = pBuffer;
			if (false)
			{
			}
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated && bufferLength >= (UIntPtr)(2 * Vector128<byte>.Count) && !Ascii.VectorContainsNonAsciiChar(Vector128.Load<byte>(pBuffer)))
			{
				byte* ptr2 = pBuffer + (ulong)bufferLength - 16;
				pBuffer = (pBuffer + 16 & ~15);
				while (!Ascii.VectorContainsNonAsciiChar(Vector128.LoadAligned<byte>(pBuffer)))
				{
					pBuffer += 16;
					if (pBuffer != ptr2)
					{
						break;
					}
				}
				bufferLength -= pBuffer;
				bufferLength += ptr;
			}
			while (bufferLength >= (UIntPtr)((IntPtr)8))
			{
				uint num = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
				uint num2 = Unsafe.ReadUnaligned<uint>((void*)(pBuffer + 4));
				if (!Ascii.AllBytesInUInt32AreAscii(num | num2))
				{
					if (Ascii.AllBytesInUInt32AreAscii(num))
					{
						num = num2;
						pBuffer += 4;
					}
					IL_F4:
					pBuffer += Ascii.CountNumberOfLeadingAsciiBytesFromUInt32WithSomeNonAsciiData(num);
					IL_F0:
					return (UIntPtr)(pBuffer - ptr);
				}
				pBuffer += 8;
				bufferLength -= (UIntPtr)((IntPtr)8);
			}
			if ((bufferLength & (UIntPtr)((IntPtr)4)) != 0)
			{
				uint num = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
				if (!Ascii.AllBytesInUInt32AreAscii(num))
				{
					goto IL_F4;
				}
				pBuffer += 4;
			}
			if ((bufferLength & (UIntPtr)((IntPtr)2)) != 0)
			{
				uint num = (uint)Unsafe.ReadUnaligned<ushort>((void*)pBuffer);
				if (!Ascii.AllBytesInUInt32AreAscii(num) && BitConverter.IsLittleEndian)
				{
					goto IL_F4;
				}
				pBuffer += 2;
			}
			if ((bufferLength & (UIntPtr)((IntPtr)1)) != 0 && *(sbyte*)pBuffer >= 0)
			{
				pBuffer++;
				goto IL_F0;
			}
			goto IL_F0;
		}

		// Token: 0x060028E6 RID: 10470 RVA: 0x000201AE File Offset: 0x0001E3AE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ContainsNonAsciiByte_Sse2(uint sseMask)
		{
			return sseMask > 0U;
		}

		// Token: 0x060028E7 RID: 10471 RVA: 0x0007F2D8 File Offset: 0x0007D4D8
		private unsafe static UIntPtr GetIndexOfFirstNonAsciiByte_Intrinsified(byte* pBuffer, UIntPtr bufferLength)
		{
			uint num = (uint)sizeof(Vector128<byte>);
			UIntPtr uintPtr = (UIntPtr)(num - 1U);
			if (!BitConverter.IsLittleEndian)
			{
			}
			Vector128<byte> vector = Vector128.Create(4097).AsByte<ushort>();
			byte* ptr = pBuffer;
			if (bufferLength >= (UIntPtr)num)
			{
				if (!Sse2.IsSupported)
				{
					if (false)
					{
					}
					throw new PlatformNotSupportedException();
				}
				uint num2 = (uint)Sse2.MoveMask(Sse2.LoadVector128(pBuffer));
				if (!Ascii.ContainsNonAsciiByte_Sse2(num2))
				{
					if (bufferLength >= (UIntPtr)(2U * num))
					{
						pBuffer = (pBuffer + num & ~uintPtr);
						bufferLength += ptr;
						bufferLength -= pBuffer;
						if (bufferLength >= (UIntPtr)(2U * num))
						{
							byte* ptr2 = pBuffer + bufferLength - 2U * num;
							while (Sse2.IsSupported)
							{
								Vector128<byte> value = Sse2.LoadAlignedVector128(pBuffer);
								Vector128<byte> value2 = Sse2.LoadAlignedVector128(pBuffer + num);
								num2 = (uint)Sse2.MoveMask(value);
								uint num3 = (uint)Sse2.MoveMask(value2);
								if (Ascii.ContainsNonAsciiByte_Sse2(num2 | num3))
								{
									if (!Sse2.IsSupported)
									{
										if (false)
										{
										}
										throw new PlatformNotSupportedException();
									}
									if (!Ascii.ContainsNonAsciiByte_Sse2(num2))
									{
										pBuffer += num;
										num2 = num3;
										goto IL_180;
									}
									goto IL_180;
								}
								else
								{
									pBuffer += 2U * num;
									if (pBuffer != ptr2)
									{
										goto IL_E4;
									}
								}
							}
							if (false)
							{
							}
							throw new PlatformNotSupportedException();
						}
						IL_E4:
						if ((bufferLength & (UIntPtr)num) == 0)
						{
							goto IL_119;
						}
						if (!Sse2.IsSupported)
						{
							if (false)
							{
							}
							throw new PlatformNotSupportedException();
						}
						num2 = (uint)Sse2.MoveMask(Sse2.LoadAlignedVector128(pBuffer));
						if (Ascii.ContainsNonAsciiByte_Sse2(num2))
						{
							goto IL_180;
						}
					}
					pBuffer += num;
					IL_119:
					if (((UIntPtr)((byte)bufferLength) & uintPtr) == 0)
					{
						goto IL_158;
					}
					pBuffer += (ulong)((bufferLength & uintPtr) - (UIntPtr)num);
					if (!Sse2.IsSupported)
					{
						if (false)
						{
						}
						throw new PlatformNotSupportedException();
					}
					num2 = (uint)Sse2.MoveMask(Sse2.LoadVector128(pBuffer));
					if (!Ascii.ContainsNonAsciiByte_Sse2(num2))
					{
						pBuffer += num;
						goto IL_158;
					}
				}
				IL_180:
				if (!Sse2.IsSupported)
				{
					if (false)
					{
					}
					throw new PlatformNotSupportedException();
				}
				pBuffer += BitOperations.TrailingZeroCount(num2);
			}
			else
			{
				if ((bufferLength & (UIntPtr)((IntPtr)8)) != 0)
				{
					ulong num4 = Unsafe.ReadUnaligned<ulong>((void*)pBuffer);
					if (!Ascii.AllBytesInUInt64AreAscii(num4))
					{
						num4 &= 9259542123273814144UL;
						pBuffer += (ulong)((IntPtr)(BitOperations.TrailingZeroCount(num4) >> 3));
						goto IL_158;
					}
					pBuffer += 8;
				}
				if ((bufferLength & (UIntPtr)((IntPtr)4)) != 0)
				{
					uint num5 = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
					if (!Ascii.AllBytesInUInt32AreAscii(num5))
					{
						pBuffer += Ascii.CountNumberOfLeadingAsciiBytesFromUInt32WithSomeNonAsciiData(num5);
						goto IL_158;
					}
					pBuffer += 4;
				}
				if ((bufferLength & (UIntPtr)((IntPtr)2)) != 0)
				{
					uint num5 = (uint)Unsafe.ReadUnaligned<ushort>((void*)pBuffer);
					if (!Ascii.AllBytesInUInt32AreAscii(num5))
					{
						pBuffer += (ulong)(((IntPtr)((sbyte)num5) >> 7) + (IntPtr)1);
						goto IL_158;
					}
					pBuffer += 2;
				}
				if ((bufferLength & (UIntPtr)((IntPtr)1)) != 0 && *(sbyte*)pBuffer >= 0)
				{
					pBuffer++;
				}
			}
			IL_158:
			return (UIntPtr)(pBuffer - ptr);
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x0007F53E File Offset: 0x0007D73E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static UIntPtr GetIndexOfFirstNonAsciiChar(char* pBuffer, UIntPtr bufferLength)
		{
			if (Sse2.IsSupported || false)
			{
				return Ascii.GetIndexOfFirstNonAsciiChar_Intrinsified(pBuffer, bufferLength);
			}
			return Ascii.GetIndexOfFirstNonAsciiChar_Vector(pBuffer, bufferLength);
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x0007F560 File Offset: 0x0007D760
		private unsafe static UIntPtr GetIndexOfFirstNonAsciiChar_Vector(char* pBuffer, UIntPtr bufferLength)
		{
			char* ptr = pBuffer;
			if (false)
			{
			}
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated && bufferLength >= (UIntPtr)(2 * Vector128<ushort>.Count) && !Ascii.VectorContainsNonAsciiChar(Vector128.Load<ushort>((ushort*)pBuffer)))
			{
				char* ptr2 = pBuffer + (ulong)bufferLength * 2UL / 2UL - (ulong)8 * 2UL / 2UL;
				pBuffer = (pBuffer + 8 & ~15);
				while (!Ascii.VectorContainsNonAsciiChar(Vector128.LoadAligned<ushort>((ushort*)pBuffer)))
				{
					pBuffer += (ulong)8 * 2UL / 2UL;
					if (pBuffer != ptr2)
					{
						break;
					}
				}
				bufferLength -= (UIntPtr)((pBuffer - ptr) / (IntPtr)2);
			}
			while (bufferLength >= (UIntPtr)((IntPtr)4))
			{
				uint num = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
				uint num2 = Unsafe.ReadUnaligned<uint>((void*)(pBuffer + 2));
				if (!Ascii.AllCharsInUInt32AreAscii(num | num2))
				{
					if (Ascii.AllCharsInUInt32AreAscii(num))
					{
						num = num2;
						pBuffer += 2;
					}
					IL_F1:
					if (Ascii.FirstCharInUInt32IsAscii(num))
					{
						pBuffer++;
					}
					IL_EA:
					return (UIntPtr)((pBuffer - ptr) / (IntPtr)2);
				}
				pBuffer += 4;
				bufferLength -= (UIntPtr)((IntPtr)4);
			}
			if ((bufferLength & (UIntPtr)((IntPtr)2)) != 0)
			{
				uint num = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
				if (!Ascii.AllCharsInUInt32AreAscii(num))
				{
					goto IL_F1;
				}
				pBuffer += 2;
			}
			if ((bufferLength & (UIntPtr)((IntPtr)1)) != 0 && *pBuffer <= '\u007f')
			{
				pBuffer++;
				goto IL_EA;
			}
			goto IL_EA;
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x0007F66C File Offset: 0x0007D86C
		private unsafe static UIntPtr GetIndexOfFirstNonAsciiChar_Intrinsified(char* pBuffer, UIntPtr bufferLength)
		{
			if (bufferLength == 0)
			{
				return (UIntPtr)((IntPtr)0);
			}
			uint num = 8U;
			char* ptr = pBuffer;
			if (bufferLength >= (UIntPtr)num)
			{
				Vector128<ushort> vector = Vector128.LoadUnsafe<ushort>(ref *(ushort*)pBuffer);
				if (!Ascii.VectorContainsNonAsciiChar(vector))
				{
					bufferLength <<= 1;
					if (bufferLength >= (UIntPtr)((IntPtr)32))
					{
						pBuffer = (pBuffer + 8 & ~15);
						UIntPtr uintPtr = (UIntPtr)(pBuffer - ptr);
						bufferLength -= uintPtr;
						if (bufferLength >= (UIntPtr)((IntPtr)32))
						{
							char* ptr2 = pBuffer + bufferLength / 2 - 16;
							Vector128<ushort> vector2;
							for (;;)
							{
								vector = Vector128.LoadUnsafe<ushort>(ref *(ushort*)pBuffer);
								vector2 = Vector128.LoadUnsafe<ushort>(ref *(ushort*)pBuffer, (UIntPtr)num);
								if (Ascii.VectorContainsNonAsciiChar(vector | vector2))
								{
									break;
								}
								pBuffer += (ulong)(2U * num) * 2UL / 2UL;
								if (pBuffer != ptr2)
								{
									goto IL_86;
								}
							}
							if (!Ascii.VectorContainsNonAsciiChar(vector))
							{
								pBuffer += (ulong)num * 2UL / 2UL;
								vector = vector2;
								goto IL_F0;
							}
							goto IL_F0;
						}
						IL_86:
						if ((bufferLength & (UIntPtr)((IntPtr)16)) == 0)
						{
							goto IL_A6;
						}
						vector = Vector128.LoadUnsafe<ushort>(ref *(ushort*)pBuffer);
						if (Ascii.VectorContainsNonAsciiChar(vector))
						{
							goto IL_F0;
						}
					}
					pBuffer += (ulong)num * 2UL / 2UL;
					IL_A6:
					if (((byte)bufferLength & 15) == 0)
					{
						goto IL_D4;
					}
					pBuffer = pBuffer + (ulong)(bufferLength & (UIntPtr)((IntPtr)15)) / 2UL - 8;
					vector = Vector128.LoadUnsafe<ushort>(ref *(ushort*)pBuffer);
					if (!Ascii.VectorContainsNonAsciiChar(vector))
					{
						pBuffer += (ulong)num * 2UL / 2UL;
						goto IL_D4;
					}
				}
				IL_F0:
				if (!Sse2.IsSupported)
				{
					if (false)
					{
					}
					throw new PlatformNotSupportedException();
				}
				Vector128<ushort> right = Vector128.Create(32640);
				uint num2 = (uint)Sse2.MoveMask(Sse2.AddSaturate(vector, right).AsByte<ushort>());
				num2 &= 43690U;
				pBuffer = (char*)((byte*)(pBuffer + BitOperations.TrailingZeroCount(num2) / 2) - 1);
			}
			else
			{
				if ((bufferLength & (UIntPtr)((IntPtr)4)) != 0)
				{
					ulong num3 = Unsafe.ReadUnaligned<ulong>((void*)pBuffer);
					if (!Ascii.AllCharsInUInt64AreAscii(num3))
					{
						num3 &= 18410996206198128512UL;
						pBuffer += (ulong)((IntPtr)(BitOperations.TrailingZeroCount(num3) >> 3) & ~(IntPtr)1) / 2UL;
						goto IL_D4;
					}
					pBuffer += 4;
				}
				if ((bufferLength & (UIntPtr)((IntPtr)2)) != 0)
				{
					uint value = Unsafe.ReadUnaligned<uint>((void*)pBuffer);
					if (Ascii.AllCharsInUInt32AreAscii(value))
					{
						pBuffer += 2;
					}
					else
					{
						if (Ascii.FirstCharInUInt32IsAscii(value))
						{
							pBuffer++;
							goto IL_D4;
						}
						goto IL_D4;
					}
				}
				if ((bufferLength & (UIntPtr)((IntPtr)1)) != 0 && *pBuffer <= '\u007f')
				{
					pBuffer++;
				}
			}
			IL_D4:
			return (UIntPtr)((pBuffer - ptr) / (IntPtr)2);
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x0007F854 File Offset: 0x0007DA54
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(ref byte outputBuffer, ulong value)
		{
			if (Sse2.X64.IsSupported)
			{
				Vector128<short> vector = Sse2.X64.ConvertScalarToVector128UInt64(value).AsInt16<ulong>();
				Vector128<uint> value2 = Sse2.PackUnsignedSaturate(vector, vector).AsUInt32<byte>();
				Unsafe.WriteUnaligned<uint>(ref outputBuffer, Sse2.ConvertToUInt32(value2));
				return;
			}
			if (false)
			{
			}
			bool isLittleEndian = BitConverter.IsLittleEndian;
			outputBuffer = (byte)value;
			value >>= 16;
			*Unsafe.Add<byte>(ref outputBuffer, 1) = (byte)value;
			value >>= 16;
			*Unsafe.Add<byte>(ref outputBuffer, 2) = (byte)value;
			value >>= 16;
			*Unsafe.Add<byte>(ref outputBuffer, 3) = (byte)value;
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x0007F8C9 File Offset: 0x0007DAC9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void NarrowTwoUtf16CharsToAsciiAndWriteToBuffer(ref byte outputBuffer, uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			outputBuffer = (byte)value;
			*Unsafe.Add<byte>(ref outputBuffer, 1) = (byte)(value >> 16);
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x0007F8E4 File Offset: 0x0007DAE4
		internal unsafe static UIntPtr NarrowUtf16ToAscii(char* pUtf16Buffer, byte* pAsciiBuffer, UIntPtr elementCount)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			bool isLittleEndian = BitConverter.IsLittleEndian;
			ulong num;
			if (Vector128.IsHardwareAccelerated && elementCount >= (UIntPtr)(2 * Vector128<byte>.Count))
			{
				num = Unsafe.ReadUnaligned<ulong>((void*)pUtf16Buffer);
				if (!Ascii.AllCharsInUInt64AreAscii(num))
				{
					goto IL_EF;
				}
				if (false)
				{
				}
				if (false)
				{
				}
				uintPtr = Ascii.NarrowUtf16ToAscii_Intrinsified(pUtf16Buffer, pAsciiBuffer, elementCount);
			}
			UIntPtr uintPtr2 = elementCount - uintPtr;
			if (uintPtr2 >= (UIntPtr)((IntPtr)4))
			{
				UIntPtr uintPtr3 = uintPtr + uintPtr2 - (UIntPtr)((IntPtr)4);
				do
				{
					num = Unsafe.ReadUnaligned<ulong>((void*)(pUtf16Buffer + (ulong)uintPtr * 2UL / 2UL));
					if (!Ascii.AllCharsInUInt64AreAscii(num))
					{
						goto IL_EF;
					}
					Ascii.NarrowFourUtf16CharsToAsciiAndWriteToBuffer(ref pAsciiBuffer[(ulong)uintPtr], num);
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				while (uintPtr <= uintPtr3);
			}
			uint num2;
			if (((uint)uintPtr2 & 2U) != 0U)
			{
				num2 = Unsafe.ReadUnaligned<uint>((void*)(pUtf16Buffer + (ulong)uintPtr * 2UL / 2UL));
				if (!Ascii.AllCharsInUInt32AreAscii(num2))
				{
					goto IL_128;
				}
				Ascii.NarrowTwoUtf16CharsToAsciiAndWriteToBuffer(ref pAsciiBuffer[(ulong)uintPtr], num2);
				uintPtr += (UIntPtr)((IntPtr)2);
			}
			if (((uint)uintPtr2 & 1U) != 0U)
			{
				num2 = (uint)pUtf16Buffer[(ulong)uintPtr * 2UL / 2UL];
				if (num2 <= 127U)
				{
					pAsciiBuffer[(ulong)uintPtr] = (byte)num2;
					uintPtr++;
				}
			}
			return uintPtr;
			IL_EF:
			bool isLittleEndian2 = BitConverter.IsLittleEndian;
			num2 = (uint)num;
			if (Ascii.AllCharsInUInt32AreAscii(num2))
			{
				Ascii.NarrowTwoUtf16CharsToAsciiAndWriteToBuffer(ref pAsciiBuffer[(ulong)uintPtr], num2);
				bool isLittleEndian3 = BitConverter.IsLittleEndian;
				num2 = (uint)(num >> 32);
				uintPtr += (UIntPtr)((IntPtr)2);
			}
			IL_128:
			if (Ascii.FirstCharInUInt32IsAscii(num2))
			{
				if (!BitConverter.IsLittleEndian)
				{
				}
				pAsciiBuffer[(ulong)uintPtr] = (byte)num2;
				return uintPtr + 1;
			}
			return uintPtr;
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x0007FA38 File Offset: 0x0007DC38
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool VectorContainsNonAsciiChar(Vector128<byte> asciiVector)
		{
			if (Sse41.IsSupported)
			{
				return !Sse41.TestZ(asciiVector, Vector128.Create(128));
			}
			if (false)
			{
			}
			return asciiVector.ExtractMostSignificantBits<byte>() > 0U;
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x0007FA64 File Offset: 0x0007DC64
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool VectorContainsNonAsciiChar(Vector128<ushort> utf16Vector)
		{
			if (!Sse2.IsSupported)
			{
				if (false)
				{
				}
				return (utf16Vector & Vector128.Create(65408)) != Vector128<ushort>.Zero;
			}
			if (Sse41.IsSupported)
			{
				Vector128<ushort> vector = Vector128.Create(65408);
				return !Sse41.TestZ(utf16Vector.AsInt16<ushort>(), vector.AsInt16<ushort>());
			}
			Vector128<ushort> right = Vector128.Create(32640);
			return (Sse2.MoveMask(Sse2.AddSaturate(utf16Vector, right).AsByte<ushort>()) & 43690) != 0;
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x0007FAE2 File Offset: 0x0007DCE2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool VectorContainsNonAsciiChar(Vector256<ushort> utf16Vector)
		{
			if (false)
			{
			}
			return (utf16Vector & Vector256.Create(65408)) != Vector256<ushort>.Zero;
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x0007FB01 File Offset: 0x0007DD01
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool VectorContainsNonAsciiChar(Vector512<ushort> utf16Vector)
		{
			return (utf16Vector & Vector512.Create(65408)) != Vector512<ushort>.Zero;
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x0007FB1D File Offset: 0x0007DD1D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool VectorContainsNonAsciiChar<[IsUnmanaged] T>(Vector128<T> vector) where T : struct, ValueType
		{
			if (!(typeof(T) == typeof(byte)))
			{
				return Ascii.VectorContainsNonAsciiChar(vector.AsUInt16<T>());
			}
			return Ascii.VectorContainsNonAsciiChar(vector.AsByte<T>());
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x0007FB54 File Offset: 0x0007DD54
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllCharsInVectorAreAscii<[IsUnmanaged] T>(Vector128<T> vector) where T : struct, ValueType
		{
			if (typeof(T) == typeof(byte))
			{
				if (!Sse41.IsSupported)
				{
					return vector.AsByte<T>().ExtractMostSignificantBits<byte>() == 0U;
				}
				return Sse41.TestZ(vector.AsByte<T>(), Vector128.Create(128));
			}
			else
			{
				if (!Sse41.IsSupported)
				{
					return (vector.AsUInt16<T>() & Vector128.Create(65408)) == Vector128<ushort>.Zero;
				}
				return Sse41.TestZ(vector.AsUInt16<T>(), Vector128.Create(65408));
			}
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x0007FBE8 File Offset: 0x0007DDE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllCharsInVectorAreAscii<[IsUnmanaged] T>(Vector256<T> vector) where T : struct, ValueType
		{
			if (typeof(T) == typeof(byte))
			{
				return vector.AsByte<T>().ExtractMostSignificantBits<byte>() == 0U;
			}
			return (vector.AsUInt16<T>() & Vector256.Create(65408)) == Vector256<ushort>.Zero;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0007FC44 File Offset: 0x0007DE44
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool AllCharsInVectorAreAscii<[IsUnmanaged] T>(Vector512<T> vector) where T : struct, ValueType
		{
			if (typeof(T) == typeof(byte))
			{
				return vector.AsByte<T>().ExtractMostSignificantBits<byte>() == 0UL;
			}
			return (vector.AsUInt16<T>() & Vector512.Create(65408)) == Vector512<ushort>.Zero;
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0007FC9B File Offset: 0x0007DE9B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector128<byte> ExtractAsciiVector(Vector128<ushort> vectorFirst, Vector128<ushort> vectorSecond)
		{
			if (Sse2.IsSupported)
			{
				return Sse2.PackUnsignedSaturate(vectorFirst.AsInt16<ushort>(), vectorSecond.AsInt16<ushort>());
			}
			if (false)
			{
			}
			if (false)
			{
			}
			return Vector128.Narrow(vectorFirst, vectorSecond);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x0007FCC4 File Offset: 0x0007DEC4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static UIntPtr NarrowUtf16ToAscii_Intrinsified(char* pUtf16Buffer, byte* pAsciiBuffer, UIntPtr elementCount)
		{
			uint count = (uint)Vector128<byte>.Count;
			UIntPtr uintPtr = (UIntPtr)(count - 1U);
			ref ushort source = ref *(ushort*)pUtf16Buffer;
			Vector128<ushort> vector = Vector128.LoadUnsafe<ushort>(ref source);
			if (Ascii.VectorContainsNonAsciiChar(vector))
			{
				return (UIntPtr)((IntPtr)0);
			}
			ref byte destination = ref *pAsciiBuffer;
			Ascii.ExtractAsciiVector(vector, vector).StoreLowerUnsafe(ref destination, (UIntPtr)((IntPtr)0));
			UIntPtr uintPtr2 = (UIntPtr)(count / 2U);
			if ((pAsciiBuffer & count / 2U) == 0U)
			{
				vector = Vector128.LoadUnsafe<ushort>(ref source, uintPtr2);
				if (Ascii.VectorContainsNonAsciiChar(vector))
				{
					return uintPtr2;
				}
				Ascii.ExtractAsciiVector(vector, vector).StoreLowerUnsafe(ref destination, uintPtr2);
			}
			uintPtr2 = count - (pAsciiBuffer & uintPtr);
			UIntPtr uintPtr3 = elementCount - (UIntPtr)count;
			for (;;)
			{
				vector = Vector128.LoadUnsafe<ushort>(ref source, uintPtr2);
				Vector128<ushort> vector2 = Vector128.LoadUnsafe<ushort>(ref source, uintPtr2 + (UIntPtr)(count / 2U));
				if (Ascii.VectorContainsNonAsciiChar(vector | vector2))
				{
					break;
				}
				Ascii.ExtractAsciiVector(vector, vector2).StoreUnsafe(ref destination, uintPtr2);
				uintPtr2 += (UIntPtr)count;
				if (uintPtr2 > uintPtr3)
				{
					return uintPtr2;
				}
			}
			if (!Ascii.VectorContainsNonAsciiChar(vector))
			{
				Ascii.ExtractAsciiVector(vector, vector).StoreLowerUnsafe(ref destination, uintPtr2);
				uintPtr2 += (UIntPtr)(count / 2U);
			}
			return uintPtr2;
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0007FDAC File Offset: 0x0007DFAC
		internal unsafe static UIntPtr WidenAsciiToUtf16(byte* pAsciiBuffer, char* pUtf16Buffer, UIntPtr elementCount)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			bool isLittleEndian = BitConverter.IsLittleEndian;
			if (Vector128.IsHardwareAccelerated && elementCount >= (UIntPtr)Vector128<byte>.Count)
			{
				if (false)
				{
				}
				if (false)
				{
				}
				if (Vector128.IsHardwareAccelerated && elementCount - uintPtr >= (UIntPtr)Vector128<byte>.Count)
				{
					Ascii.WidenAsciiToUtf1_Vector<Vector128<byte>, Vector128<ushort>>(pAsciiBuffer, pUtf16Buffer, ref uintPtr, elementCount);
				}
			}
			UIntPtr uintPtr2 = elementCount - uintPtr;
			uint num;
			if (uintPtr2 >= (UIntPtr)((IntPtr)4))
			{
				UIntPtr uintPtr3 = uintPtr + uintPtr2 - (UIntPtr)((IntPtr)4);
				do
				{
					num = Unsafe.ReadUnaligned<uint>((void*)(pAsciiBuffer + (ulong)uintPtr));
					if (!Ascii.AllBytesInUInt32AreAscii(num))
					{
						goto IL_E8;
					}
					Ascii.WidenFourAsciiBytesToUtf16AndWriteToBuffer(ref pUtf16Buffer[(ulong)uintPtr * 2UL / 2UL], num);
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				while (uintPtr <= uintPtr3);
			}
			if (((uint)uintPtr2 & 2U) != 0U)
			{
				num = (uint)Unsafe.ReadUnaligned<ushort>((void*)(pAsciiBuffer + (ulong)uintPtr));
				if (!Ascii.AllBytesInUInt32AreAscii(num) && BitConverter.IsLittleEndian)
				{
					goto IL_E8;
				}
				bool isLittleEndian2 = BitConverter.IsLittleEndian;
				pUtf16Buffer[(ulong)uintPtr * 2UL / 2UL] = (char)((byte)num);
				pUtf16Buffer[(ulong)(uintPtr + (UIntPtr)((IntPtr)1)) * 2UL / 2UL] = (char)(num >> 8);
				uintPtr += (UIntPtr)((IntPtr)2);
			}
			if (((uint)uintPtr2 & 1U) != 0U)
			{
				num = (uint)pAsciiBuffer[(ulong)uintPtr];
				if (((byte)num & 128) == 0)
				{
					pUtf16Buffer[(ulong)uintPtr * 2UL / 2UL] = (char)num;
					uintPtr++;
				}
			}
			return uintPtr;
			IL_E8:
			bool isLittleEndian3 = BitConverter.IsLittleEndian;
			while (((byte)num & 128) == 0)
			{
				pUtf16Buffer[(ulong)uintPtr * 2UL / 2UL] = (char)((byte)num);
				uintPtr++;
				num >>= 8;
			}
			return uintPtr;
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x0007FEC8 File Offset: 0x0007E0C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static void WidenAsciiToUtf1_Vector<[IsUnmanaged] TVectorByte, [IsUnmanaged] TVectorUInt16>(byte* pAsciiBuffer, char* pUtf16Buffer, ref UIntPtr currentOffset, UIntPtr elementCount) where TVectorByte : struct, ValueType, ISimdVector<TVectorByte, byte> where TVectorUInt16 : struct, ValueType, ISimdVector<TVectorUInt16, ushort>
		{
			UIntPtr uintPtr = elementCount - (UIntPtr)((IntPtr)ISimdVector<TVectorByte, byte>.Count);
			TVectorByte vector = ISimdVector<TVectorByte, byte>.Load(pAsciiBuffer + (ulong)currentOffset);
			if (!Ascii.HasMatch<TVectorByte>(vector))
			{
				ValueTuple<TVectorUInt16, TVectorUInt16> valueTuple = Ascii.Widen<TVectorByte, TVectorUInt16>(vector);
				TVectorUInt16 item = valueTuple.Item1;
				TVectorUInt16 item2 = valueTuple.Item2;
				item.Store((ushort*)pUtf16Buffer);
				item2.Store((ushort*)(pUtf16Buffer + ISimdVector<TVectorUInt16, ushort>.Count));
				ushort* ptr = (ushort*)(pUtf16Buffer + (ulong)((IntPtr)(ISimdVector<TVectorUInt16, ushort>.Count * 2)) * 2UL / 2UL);
				if (ptr % 2 == null)
				{
					ptr &= ~(ISimdVector<TVectorUInt16, ushort>.Alignment - 1);
					UIntPtr uintPtr2 = (UIntPtr)(ptr - pUtf16Buffer);
					currentOffset += uintPtr2 / (UIntPtr)((IntPtr)2);
				}
				else
				{
					currentOffset += (UIntPtr)((IntPtr)ISimdVector<TVectorByte, byte>.Count);
				}
				while (currentOffset <= uintPtr)
				{
					vector = ISimdVector<TVectorByte, byte>.Load(pAsciiBuffer + (ulong)currentOffset);
					if (Ascii.HasMatch<TVectorByte>(vector))
					{
						break;
					}
					ValueTuple<TVectorUInt16, TVectorUInt16> valueTuple2 = Ascii.Widen<TVectorByte, TVectorUInt16>(vector);
					item = valueTuple2.Item1;
					TVectorUInt16 item3 = valueTuple2.Item2;
					item.Store(ptr);
					item3.Store(ptr + ISimdVector<TVectorUInt16, ushort>.Count);
					currentOffset += (UIntPtr)((IntPtr)ISimdVector<TVectorByte, byte>.Count);
					ptr += (ulong)((IntPtr)(ISimdVector<TVectorUInt16, ushort>.Count * 2)) * 2UL / 2UL;
				}
			}
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0007FFFC File Offset: 0x0007E1FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool HasMatch<[IsUnmanaged] TVectorByte>(TVectorByte vector) where TVectorByte : struct, ValueType, ISimdVector<TVectorByte, byte>
		{
			TVectorByte tvectorByte = vector & ISimdVector<TVectorByte, byte>.Create(128);
			return !tvectorByte.Equals(ISimdVector<TVectorByte, byte>.Zero);
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00080044 File Offset: 0x0007E244
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: TupleElementNames(new string[]
		{
			"Lower",
			"Upper"
		})]
		private static ValueTuple<TVectorUInt16, TVectorUInt16> Widen<[IsUnmanaged] TVectorByte, [IsUnmanaged] TVectorUInt16>(TVectorByte vector) where TVectorByte : struct, ValueType, ISimdVector<TVectorByte, byte> where TVectorUInt16 : struct, ValueType, ISimdVector<TVectorUInt16, ushort>
		{
			if (typeof(TVectorByte) == typeof(Vector256<byte>))
			{
				ValueTuple<Vector256<ushort>, Vector256<ushort>> valueTuple = Vector256.Widen((Vector256<byte>)((object)vector));
				Vector256<ushort> item = valueTuple.Item1;
				Vector256<ushort> item2 = valueTuple.Item2;
				return new ValueTuple<TVectorUInt16, TVectorUInt16>((TVectorUInt16)((object)item), (TVectorUInt16)((object)item2));
			}
			if (typeof(TVectorByte) == typeof(Vector512<byte>))
			{
				ValueTuple<Vector512<ushort>, Vector512<ushort>> valueTuple2 = Vector512.Widen((Vector512<byte>)((object)vector));
				Vector512<ushort> item3 = valueTuple2.Item1;
				Vector512<ushort> item4 = valueTuple2.Item2;
				return new ValueTuple<TVectorUInt16, TVectorUInt16>((TVectorUInt16)((object)item3), (TVectorUInt16)((object)item4));
			}
			ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple3 = Vector128.Widen((Vector128<byte>)((object)vector));
			Vector128<ushort> item5 = valueTuple3.Item1;
			Vector128<ushort> item6 = valueTuple3.Item2;
			return new ValueTuple<TVectorUInt16, TVectorUInt16>((TVectorUInt16)((object)item5), (TVectorUInt16)((object)item6));
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00080138 File Offset: 0x0007E338
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void WidenFourAsciiBytesToUtf16AndWriteToBuffer(ref char outputBuffer, uint value)
		{
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated)
			{
				Vector128<ulong> vector = Vector128.WidenLower(Vector128.CreateScalar(value).AsByte<uint>()).AsUInt64<ushort>();
				Unsafe.WriteUnaligned<ulong>(Unsafe.As<char, byte>(ref outputBuffer), vector.ToScalar<ulong>());
				return;
			}
			bool isLittleEndian = BitConverter.IsLittleEndian;
			outputBuffer = (char)((byte)value);
			value >>= 8;
			*Unsafe.Add<char>(ref outputBuffer, 1) = (char)((byte)value);
			value >>= 8;
			*Unsafe.Add<char>(ref outputBuffer, 2) = (char)((byte)value);
			value >>= 8;
			*Unsafe.Add<char>(ref outputBuffer, 3) = (char)value;
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x000801AE File Offset: 0x0007E3AE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool AllBytesInUInt32AreAscii(uint value)
		{
			return (value & 2155905152U) == 0U;
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x000801BA File Offset: 0x0007E3BA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static uint CountNumberOfLeadingAsciiBytesFromUInt32WithSomeNonAsciiData(uint value)
		{
			bool isLittleEndian = BitConverter.IsLittleEndian;
			return (uint)BitOperations.TrailingZeroCount(value & 2155905152U) >> 3;
		}

		// Token: 0x0200020B RID: 523
		private struct ToUpperConversion
		{
		}

		// Token: 0x0200020C RID: 524
		private struct ToLowerConversion
		{
		}

		// Token: 0x0200020D RID: 525
		private interface ILoader<[IsUnmanaged] TLeft, [IsUnmanaged] TRight> where TLeft : struct, ValueType, INumberBase<TLeft> where TRight : struct, ValueType, INumberBase<TRight>
		{
			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x060028FF RID: 10495
			UIntPtr Count128 { get; }

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x06002900 RID: 10496
			UIntPtr Count256 { get; }

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x06002901 RID: 10497
			UIntPtr Count512 { get; }

			// Token: 0x06002902 RID: 10498
			public abstract static Vector128<TRight> Load128(ref TLeft ptr);

			// Token: 0x06002903 RID: 10499
			public abstract static Vector256<TRight> Load256(ref TLeft ptr);

			// Token: 0x06002904 RID: 10500
			public abstract static Vector512<TRight> Load512(ref TLeft ptr);

			// Token: 0x06002905 RID: 10501
			public abstract static bool EqualAndAscii256(ref TLeft left, ref TRight right);

			// Token: 0x06002906 RID: 10502
			public abstract static bool EqualAndAscii512(ref TLeft left, ref TRight right);
		}

		// Token: 0x0200020E RID: 526
		private readonly struct PlainLoader<[IsUnmanaged] T> : Ascii.ILoader<T, T> where T : struct, ValueType, INumberBase<T>
		{
			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x06002907 RID: 10503 RVA: 0x000801D0 File Offset: 0x0007E3D0
			public static UIntPtr Count128
			{
				get
				{
					return (UIntPtr)Vector128<T>.Count;
				}
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x06002908 RID: 10504 RVA: 0x000801D8 File Offset: 0x0007E3D8
			public static UIntPtr Count256
			{
				get
				{
					return (UIntPtr)Vector256<T>.Count;
				}
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x06002909 RID: 10505 RVA: 0x000801E0 File Offset: 0x0007E3E0
			public static UIntPtr Count512
			{
				get
				{
					return (UIntPtr)Vector512<T>.Count;
				}
			}

			// Token: 0x0600290A RID: 10506 RVA: 0x000801E8 File Offset: 0x0007E3E8
			public static Vector128<T> Load128(ref T ptr)
			{
				return Vector128.LoadUnsafe<T>(ref ptr);
			}

			// Token: 0x0600290B RID: 10507 RVA: 0x000801F0 File Offset: 0x0007E3F0
			public static Vector256<T> Load256(ref T ptr)
			{
				return Vector256.LoadUnsafe<T>(ref ptr);
			}

			// Token: 0x0600290C RID: 10508 RVA: 0x000801F8 File Offset: 0x0007E3F8
			public static Vector512<T> Load512(ref T ptr)
			{
				return Vector512.LoadUnsafe<T>(ref ptr);
			}

			// Token: 0x0600290D RID: 10509 RVA: 0x00080200 File Offset: 0x0007E400
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool EqualAndAscii256(ref T left, ref T right)
			{
				Vector256<T> vector = Vector256.LoadUnsafe<T>(ref left);
				Vector256<T> right2 = Vector256.LoadUnsafe<T>(ref right);
				return !(vector != right2) && Ascii.AllCharsInVectorAreAscii<T>(vector);
			}

			// Token: 0x0600290E RID: 10510 RVA: 0x00080230 File Offset: 0x0007E430
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool EqualAndAscii512(ref T left, ref T right)
			{
				Vector512<T> vector = Vector512.LoadUnsafe<T>(ref left);
				Vector512<T> right2 = Vector512.LoadUnsafe<T>(ref right);
				return !(vector != right2) && Ascii.AllCharsInVectorAreAscii<T>(vector);
			}
		}

		// Token: 0x0200020F RID: 527
		private readonly struct WideningLoader : Ascii.ILoader<byte, ushort>
		{
			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x0600290F RID: 10511 RVA: 0x0008025F File Offset: 0x0007E45F
			public static UIntPtr Count128
			{
				get
				{
					return (UIntPtr)((IntPtr)8);
				}
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x06002910 RID: 10512 RVA: 0x00080263 File Offset: 0x0007E463
			public static UIntPtr Count256
			{
				get
				{
					return (UIntPtr)Vector128<byte>.Count;
				}
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x06002911 RID: 10513 RVA: 0x0008026B File Offset: 0x0007E46B
			public static UIntPtr Count512
			{
				get
				{
					return (UIntPtr)Vector256<byte>.Count;
				}
			}

			// Token: 0x06002912 RID: 10514 RVA: 0x00080274 File Offset: 0x0007E474
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector128<ushort> Load128(ref byte ptr)
			{
				if (false)
				{
				}
				if (Sse2.IsSupported)
				{
					return Sse2.UnpackLow(Vector128.CreateScalarUnsafe(Unsafe.ReadUnaligned<long>(ref ptr)).AsByte<long>(), Vector128<byte>.Zero).AsUInt16<byte>();
				}
				ValueTuple<Vector64<ushort>, Vector64<ushort>> valueTuple = Vector64.Widen(Vector64.LoadUnsafe<byte>(ref ptr));
				Vector64<ushort> item = valueTuple.Item1;
				Vector64<ushort> item2 = valueTuple.Item2;
				return Vector128.Create(item, item2);
			}

			// Token: 0x06002913 RID: 10515 RVA: 0x000802CC File Offset: 0x0007E4CC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector256<ushort> Load256(ref byte ptr)
			{
				ValueTuple<Vector128<ushort>, Vector128<ushort>> valueTuple = Vector128.Widen(Vector128.LoadUnsafe<byte>(ref ptr));
				Vector128<ushort> item = valueTuple.Item1;
				Vector128<ushort> item2 = valueTuple.Item2;
				return Vector256.Create(item, item2);
			}

			// Token: 0x06002914 RID: 10516 RVA: 0x000802F8 File Offset: 0x0007E4F8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Vector512<ushort> Load512(ref byte ptr)
			{
				return Vector512.WidenLower(Vector256.LoadUnsafe<byte>(ref ptr).ToVector512<byte>());
			}

			// Token: 0x06002915 RID: 10517 RVA: 0x0008030C File Offset: 0x0007E50C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool EqualAndAscii256(ref byte utf8, ref ushort utf16)
			{
				Vector256<byte> vector = Vector256.LoadUnsafe<byte>(ref utf8);
				if (!Ascii.AllCharsInVectorAreAscii<byte>(vector))
				{
					return false;
				}
				ValueTuple<Vector256<ushort>, Vector256<ushort>> valueTuple = Vector256.Widen(vector);
				Vector256<ushort> item = valueTuple.Item1;
				Vector256<ushort> item2 = valueTuple.Item2;
				Vector256<ushort> right = Vector256.LoadUnsafe<ushort>(ref utf16);
				Vector256<ushort> right2 = Vector256.LoadUnsafe<ushort>(ref utf16, (UIntPtr)Vector256<ushort>.Count);
				return !(((item ^ right) | (item2 ^ right2)) != Vector256<ushort>.Zero);
			}

			// Token: 0x06002916 RID: 10518 RVA: 0x00080378 File Offset: 0x0007E578
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool EqualAndAscii512(ref byte utf8, ref ushort utf16)
			{
				Vector512<byte> vector = Vector512.LoadUnsafe<byte>(ref utf8);
				if (!Ascii.AllCharsInVectorAreAscii<byte>(vector))
				{
					return false;
				}
				ValueTuple<Vector512<ushort>, Vector512<ushort>> valueTuple = Vector512.Widen(vector);
				Vector512<ushort> item = valueTuple.Item1;
				Vector512<ushort> item2 = valueTuple.Item2;
				Vector512<ushort> right = Vector512.LoadUnsafe<ushort>(ref utf16);
				Vector512<ushort> right2 = Vector512.LoadUnsafe<ushort>(ref utf16, (UIntPtr)Vector512<ushort>.Count);
				return !(((item ^ right) | (item2 ^ right2)) != Vector512<ushort>.Zero);
			}
		}
	}
}
