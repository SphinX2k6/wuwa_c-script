using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;

namespace System
{
	// Token: 0x020001A7 RID: 423
	internal static class SpanHelpers
	{
		// Token: 0x06001C5A RID: 7258 RVA: 0x0005A303 File Offset: 0x00058503
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int BinarySearch<T, TComparable>(this ReadOnlySpan<T> span, TComparable comparable) where TComparable : IComparable<T>
		{
			if (comparable == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.comparable);
			}
			return SpanHelpers.BinarySearch<T, TComparable>(MemoryMarshal.GetReference<T>(span), span.Length, comparable);
		}

		// Token: 0x06001C5B RID: 7259 RVA: 0x0005A328 File Offset: 0x00058528
		public unsafe static int BinarySearch<T, TComparable>(ref T spanStart, int length, TComparable comparable) where TComparable : IComparable<T>
		{
			int i = 0;
			int num = length - 1;
			while (i <= num)
			{
				int num2 = (int)((uint)(num + i) >> 1);
				ref TComparable ptr = ref comparable;
				if (default(TComparable) == null)
				{
					TComparable tcomparable = comparable;
					ptr = ref tcomparable;
				}
				int num3 = ptr.CompareTo(*Unsafe.Add<T>(ref spanStart, num2));
				if (num3 == 0)
				{
					return num2;
				}
				if (num3 > 0)
				{
					i = num2 + 1;
				}
				else
				{
					num = num2 - 1;
				}
			}
			return ~i;
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x0005A390 File Offset: 0x00058590
		public unsafe static int IndexOf(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength)
		{
			if (valueLength == 0)
			{
				return 0;
			}
			int num = valueLength - 1;
			if (num == 0)
			{
				return SpanHelpers.IndexOfValueType<byte>(ref searchSpace, value, searchSpaceLength);
			}
			IntPtr intPtr = (IntPtr)0;
			byte value2 = value;
			int num2 = searchSpaceLength - num;
			if (!Vector128.IsHardwareAccelerated || num2 < Vector128<byte>.Count)
			{
				ref byte second = ref Unsafe.Add<byte>(ref value, 1);
				int i = num2;
				while (i > 0)
				{
					int num3 = SpanHelpers.IndexOfValueType<byte>(Unsafe.Add<byte>(ref searchSpace, intPtr), value2, i);
					if (num3 < 0)
					{
						break;
					}
					i -= num3;
					intPtr += (IntPtr)num3;
					if (i <= 0)
					{
						break;
					}
					if (SpanHelpers.SequenceEqual(Unsafe.Add<byte>(ref searchSpace, intPtr + (IntPtr)1), ref second, (UIntPtr)num))
					{
						return (int)intPtr;
					}
					i--;
					intPtr++;
				}
				return -1;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			byte b = *Unsafe.Add<byte>(ref value, num);
			int num4 = num;
			while (b == value && num4 > 1)
			{
				b = *Unsafe.Add<byte>(ref value, --num4);
			}
			Vector128<byte> left = Vector128.Create(value);
			Vector128<byte> left2 = Vector128.Create(b);
			IntPtr intPtr2 = (IntPtr)num2 - (IntPtr)Vector128<byte>.Count;
			int num6;
			for (;;)
			{
				Vector128<byte> right = Vector128.Equals<byte>(left2, Vector128.LoadUnsafe<byte>(ref searchSpace, (UIntPtr)(intPtr + (IntPtr)num4)));
				Vector128<byte> vector = (Vector128.Equals<byte>(left, Vector128.LoadUnsafe<byte>(ref searchSpace, (UIntPtr)intPtr)) & right).AsByte<byte>();
				if (vector != Vector128<byte>.Zero)
				{
					uint num5 = vector.ExtractMostSignificantBits<byte>();
					do
					{
						num6 = BitOperations.TrailingZeroCount(num5);
						if (valueLength == 2 || SpanHelpers.SequenceEqual(Unsafe.Add<byte>(ref searchSpace, intPtr + (IntPtr)num6), ref value, (UIntPtr)valueLength))
						{
							goto IL_164;
						}
						num5 = BitOperations.ResetLowestSetBit(num5);
					}
					while (num5 != 0U);
				}
				intPtr += (IntPtr)Vector128<byte>.Count;
				if (intPtr == (IntPtr)num2)
				{
					break;
				}
				if (intPtr > intPtr2)
				{
					intPtr = intPtr2;
				}
			}
			return -1;
			IL_164:
			return (int)(intPtr + (IntPtr)num6);
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x0005A518 File Offset: 0x00058718
		public unsafe static int LastIndexOf(ref byte searchSpace, int searchSpaceLength, ref byte value, int valueLength)
		{
			if (valueLength == 0)
			{
				return searchSpaceLength;
			}
			int num = valueLength - 1;
			if (num == 0)
			{
				return SpanHelpers.LastIndexOfValueType<byte>(ref searchSpace, value, searchSpaceLength);
			}
			int num2 = 0;
			byte value2 = value;
			int num3 = searchSpaceLength - num;
			if (!Vector128.IsHardwareAccelerated || num3 < Vector128<byte>.Count)
			{
				ref byte second = ref Unsafe.Add<byte>(ref value, 1);
				int num5;
				for (;;)
				{
					int num4 = searchSpaceLength - num2 - num;
					if (num4 <= 0)
					{
						return -1;
					}
					num5 = SpanHelpers.LastIndexOfValueType<byte>(ref searchSpace, value2, num4);
					if (num5 < 0)
					{
						return -1;
					}
					if (SpanHelpers.SequenceEqual(Unsafe.Add<byte>(ref searchSpace, num5 + 1), ref second, (UIntPtr)num))
					{
						break;
					}
					num2 += num4 - num5;
				}
				return num5;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			num2 = num3 - Vector128<byte>.Count;
			byte b = *Unsafe.Add<byte>(ref value, num);
			int num6 = num;
			while (b == value && num6 > 1)
			{
				b = *Unsafe.Add<byte>(ref value, --num6);
			}
			Vector128<byte> left = Vector128.Create(value);
			Vector128<byte> left2 = Vector128.Create(b);
			int num8;
			for (;;)
			{
				Vector128<byte> left3 = Vector128.Equals<byte>(left, Vector128.LoadUnsafe<byte>(ref searchSpace, (UIntPtr)((IntPtr)num2)));
				Vector128<byte> right = Vector128.Equals<byte>(left2, Vector128.LoadUnsafe<byte>(ref searchSpace, (UIntPtr)((IntPtr)(num2 + num6))));
				Vector128<byte> vector = (left3 & right).AsByte<byte>();
				if (vector != Vector128<byte>.Zero)
				{
					uint num7 = vector.ExtractMostSignificantBits<byte>();
					do
					{
						num8 = 31 - BitOperations.LeadingZeroCount(num7);
						if (valueLength == 2 || SpanHelpers.SequenceEqual(Unsafe.Add<byte>(ref searchSpace, num2 + num8), ref value, (UIntPtr)valueLength))
						{
							goto IL_133;
						}
						num7 = BitOperations.FlipBit(num7, num8);
					}
					while (num7 != 0U);
				}
				num2 -= Vector128<byte>.Count;
				if (num2 == -Vector128<byte>.Count)
				{
					return -1;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
			}
			IL_133:
			return num8 + num2;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x0005A68C File Offset: 0x0005888C
		[DoesNotReturn]
		private static void ThrowMustBeNullTerminatedString()
		{
			throw new ArgumentException(SR.Arg_MustBeNullTerminatedString);
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x0005A698 File Offset: 0x00058898
		internal unsafe static int IndexOfNullByte(byte* searchSpace)
		{
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			UIntPtr uintPtr2 = (UIntPtr)((IntPtr)int.MaxValue);
			if (Vector128.IsHardwareAccelerated)
			{
				uintPtr2 = SpanHelpers.UnalignedCountVector128(searchSpace);
			}
			Vector128<byte> vector;
			for (;;)
			{
				if (uintPtr2 < (UIntPtr)((IntPtr)8))
				{
					if (uintPtr2 >= (UIntPtr)((IntPtr)4))
					{
						uintPtr2 -= (UIntPtr)((IntPtr)4);
						if (searchSpace[(ulong)uintPtr] == 0)
						{
							goto IL_18B;
						}
						if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)1))] == 0)
						{
							goto IL_18E;
						}
						if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)2))] == 0)
						{
							goto IL_194;
						}
						if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)3))] == 0)
						{
							goto IL_19A;
						}
						uintPtr += (UIntPtr)((IntPtr)4);
					}
					while (uintPtr2 > (UIntPtr)((IntPtr)0))
					{
						uintPtr2 -= (UIntPtr)((IntPtr)1);
						if (searchSpace[(ulong)uintPtr] == 0)
						{
							goto IL_18B;
						}
						uintPtr += (UIntPtr)((IntPtr)1);
					}
					if (false)
					{
					}
					if (false)
					{
					}
					if (!Vector128.IsHardwareAccelerated || uintPtr >= (UIntPtr)((IntPtr)2147483647))
					{
						goto IL_186;
					}
					uintPtr2 = SpanHelpers.GetByteVector128SpanLength(uintPtr, int.MaxValue);
					while (uintPtr2 > uintPtr)
					{
						Vector128<byte> right = Vector128.Load<byte>(searchSpace + (ulong)uintPtr);
						vector = Vector128.Equals<byte>(Vector128<byte>.Zero, right);
						if (!(vector == Vector128<byte>.Zero))
						{
							goto IL_156;
						}
						uintPtr += (UIntPtr)((IntPtr)Vector128<byte>.Count);
					}
					if (uintPtr >= (UIntPtr)((IntPtr)2147483647))
					{
						goto IL_186;
					}
					uintPtr2 = (UIntPtr)((IntPtr)int.MaxValue - (IntPtr)uintPtr);
				}
				else
				{
					uintPtr2 -= (UIntPtr)((IntPtr)8);
					if (searchSpace[(ulong)uintPtr] == 0)
					{
						goto IL_18B;
					}
					if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)1))] == 0)
					{
						goto IL_18E;
					}
					if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)2))] == 0)
					{
						goto IL_194;
					}
					if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)3))] == 0)
					{
						goto IL_19A;
					}
					if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)4))] == 0)
					{
						goto IL_1A0;
					}
					if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)5))] == 0)
					{
						goto IL_1A6;
					}
					if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)6))] == 0)
					{
						goto IL_1AC;
					}
					if (searchSpace[(ulong)(uintPtr + (UIntPtr)((IntPtr)7))] == 0)
					{
						goto IL_1B2;
					}
					uintPtr += (UIntPtr)((IntPtr)8);
				}
			}
			IL_156:
			uint value = vector.ExtractMostSignificantBits<byte>();
			return (int)(uintPtr + (UIntPtr)BitOperations.TrailingZeroCount(value));
			IL_186:
			SpanHelpers.ThrowMustBeNullTerminatedString();
			IL_18B:
			return (int)uintPtr;
			IL_18E:
			return (int)(uintPtr + (UIntPtr)((IntPtr)1));
			IL_194:
			return (int)(uintPtr + (UIntPtr)((IntPtr)2));
			IL_19A:
			return (int)(uintPtr + (UIntPtr)((IntPtr)3));
			IL_1A0:
			return (int)(uintPtr + (UIntPtr)((IntPtr)4));
			IL_1A6:
			return (int)(uintPtr + (UIntPtr)((IntPtr)5));
			IL_1AC:
			return (int)(uintPtr + (UIntPtr)((IntPtr)6));
			IL_1B2:
			return (int)(uintPtr + (UIntPtr)((IntPtr)7));
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x0005A85C File Offset: 0x00058A5C
		[Intrinsic]
		public unsafe static bool SequenceEqual(ref byte first, ref byte second, UIntPtr length)
		{
			if (length >= (UIntPtr)((IntPtr)8))
			{
				if (!Unsafe.AreSame<byte>(ref first, ref second))
				{
					if (Vector128.IsHardwareAccelerated)
					{
						if (false)
						{
						}
						if (false)
						{
						}
						if (length >= (UIntPtr)((IntPtr)Vector128<byte>.Count))
						{
							UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
							UIntPtr uintPtr2 = length - (UIntPtr)((IntPtr)Vector128<byte>.Count);
							if (uintPtr2 != 0)
							{
								while (!(Vector128.LoadUnsafe<byte>(ref first, uintPtr) != Vector128.LoadUnsafe<byte>(ref second, uintPtr)))
								{
									uintPtr += (UIntPtr)((IntPtr)Vector128<byte>.Count);
									if (uintPtr2 <= uintPtr)
									{
										goto IL_D6;
									}
								}
								return false;
							}
							IL_D6:
							if (Vector128.LoadUnsafe<byte>(ref first, uintPtr2) == Vector128.LoadUnsafe<byte>(ref second, uintPtr2))
							{
								return true;
							}
							return false;
						}
					}
					if (Vector128.IsHardwareAccelerated)
					{
						UIntPtr offset = length - (UIntPtr)((IntPtr)8);
						return (SpanHelpers.LoadNUInt(ref first) - SpanHelpers.LoadNUInt(ref second) | SpanHelpers.LoadNUInt(ref first, offset) - SpanHelpers.LoadNUInt(ref second, offset)) == (UIntPtr)((IntPtr)0);
					}
					UIntPtr uintPtr3 = (UIntPtr)((IntPtr)0);
					UIntPtr uintPtr4 = length - (UIntPtr)((IntPtr)8);
					if (uintPtr4 > (UIntPtr)((IntPtr)0))
					{
						while (SpanHelpers.LoadNUInt(ref first, uintPtr3) == SpanHelpers.LoadNUInt(ref second, uintPtr3))
						{
							uintPtr3 += (UIntPtr)((IntPtr)8);
							if (uintPtr4 <= uintPtr3)
							{
								goto IL_166;
							}
						}
						return false;
					}
					IL_166:
					return SpanHelpers.LoadNUInt(ref first, uintPtr4) == SpanHelpers.LoadNUInt(ref second, uintPtr4);
				}
				return true;
			}
			bool result;
			if (length < (UIntPtr)((IntPtr)4))
			{
				uint num = 0U;
				UIntPtr uintPtr5 = length & (UIntPtr)((IntPtr)2);
				if (uintPtr5 != 0)
				{
					num = (uint)SpanHelpers.LoadUShort(ref first);
					num -= (uint)SpanHelpers.LoadUShort(ref second);
				}
				if ((length & (UIntPtr)((IntPtr)1)) != 0)
				{
					num |= (uint)(*Unsafe.AddByteOffset<byte>(ref first, uintPtr5) - *Unsafe.AddByteOffset<byte>(ref second, uintPtr5));
				}
				result = (num == 0U);
			}
			else
			{
				UIntPtr offset2 = length - (UIntPtr)((IntPtr)4);
				result = ((SpanHelpers.LoadUInt(ref first) - SpanHelpers.LoadUInt(ref second) | SpanHelpers.LoadUInt(ref first, offset2) - SpanHelpers.LoadUInt(ref second, offset2)) == 0U);
			}
			return result;
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x0005A9E8 File Offset: 0x00058BE8
		public unsafe static int SequenceCompareTo(ref byte first, int firstLength, ref byte second, int secondLength)
		{
			if (!Unsafe.AreSame<byte>(ref first, ref second))
			{
				UIntPtr uintPtr = (UIntPtr)((firstLength < secondLength) ? firstLength : secondLength);
				UIntPtr uintPtr2 = (UIntPtr)((IntPtr)0);
				UIntPtr uintPtr3 = uintPtr;
				if (false)
				{
				}
				if (Vector128.IsHardwareAccelerated && uintPtr3 >= (UIntPtr)((IntPtr)Vector128<byte>.Count))
				{
					uintPtr3 -= (UIntPtr)((IntPtr)Vector128<byte>.Count);
					while (uintPtr3 > uintPtr2)
					{
						if (!(Vector128.LoadUnsafe<byte>(ref first, uintPtr2) == Vector128.LoadUnsafe<byte>(ref second, uintPtr2)))
						{
							goto IL_CC;
						}
						uintPtr2 += (UIntPtr)((IntPtr)Vector128<byte>.Count);
					}
					uintPtr2 = uintPtr3;
					if (Vector128.LoadUnsafe<byte>(ref first, uintPtr2) == Vector128.LoadUnsafe<byte>(ref second, uintPtr2))
					{
						goto IL_D0;
					}
				}
				else if (uintPtr3 > (UIntPtr)((IntPtr)8))
				{
					uintPtr3 -= (UIntPtr)((IntPtr)8);
					while (uintPtr3 > uintPtr2)
					{
						if (SpanHelpers.LoadNUInt(ref first, uintPtr2) != SpanHelpers.LoadNUInt(ref second, uintPtr2))
						{
							break;
						}
						uintPtr2 += (UIntPtr)((IntPtr)8);
					}
				}
				IL_CC:
				while (uintPtr > uintPtr2)
				{
					int num = Unsafe.AddByteOffset<byte>(ref first, uintPtr2).CompareTo(*Unsafe.AddByteOffset<byte>(ref second, uintPtr2));
					if (num != 0)
					{
						return num;
					}
					uintPtr2 += (UIntPtr)((IntPtr)1);
				}
			}
			IL_D0:
			return firstLength - secondLength;
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0005AAC8 File Offset: 0x00058CC8
		public unsafe static UIntPtr CommonPrefixLength(ref byte first, ref byte second, UIntPtr length)
		{
			UIntPtr uintPtr;
			if (!Vector128.IsHardwareAccelerated || length < (UIntPtr)((IntPtr)Vector128<byte>.Count))
			{
				uintPtr = length % (UIntPtr)((IntPtr)4);
				if (uintPtr > (UIntPtr)((IntPtr)0))
				{
					if (first != second)
					{
						return (UIntPtr)((IntPtr)0);
					}
					if (uintPtr > (UIntPtr)((IntPtr)1))
					{
						if (*Unsafe.Add<byte>(ref first, 1) != *Unsafe.Add<byte>(ref second, 1))
						{
							return (UIntPtr)((IntPtr)1);
						}
						if (uintPtr > (UIntPtr)((IntPtr)2) && *Unsafe.Add<byte>(ref first, 2) != *Unsafe.Add<byte>(ref second, 2))
						{
							return (UIntPtr)((IntPtr)2);
						}
					}
				}
				while (uintPtr <= length - (UIntPtr)((IntPtr)4))
				{
					if (*Unsafe.Add<byte>(ref first, uintPtr + (UIntPtr)((IntPtr)0)) != *Unsafe.Add<byte>(ref second, uintPtr + (UIntPtr)((IntPtr)0)))
					{
						return uintPtr;
					}
					if (*Unsafe.Add<byte>(ref first, uintPtr + (UIntPtr)((IntPtr)1)) != *Unsafe.Add<byte>(ref second, uintPtr + (UIntPtr)((IntPtr)1)))
					{
						return uintPtr + (UIntPtr)((IntPtr)1);
					}
					if (*Unsafe.Add<byte>(ref first, uintPtr + (UIntPtr)((IntPtr)2)) != *Unsafe.Add<byte>(ref second, uintPtr + (UIntPtr)((IntPtr)2)))
					{
						return uintPtr + (UIntPtr)((IntPtr)2);
					}
					if (*Unsafe.Add<byte>(ref first, uintPtr + (UIntPtr)((IntPtr)3)) != *Unsafe.Add<byte>(ref second, uintPtr + (UIntPtr)((IntPtr)3)))
					{
						return uintPtr + (UIntPtr)((IntPtr)3);
					}
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				return length;
			}
			UIntPtr uintPtr2 = length - (UIntPtr)((IntPtr)Vector128<byte>.Count);
			uint num;
			for (uintPtr = (UIntPtr)((IntPtr)0); uintPtr < uintPtr2; uintPtr += (UIntPtr)((IntPtr)Vector128<byte>.Count))
			{
				num = Vector128.Equals<byte>(Vector128.LoadUnsafe<byte>(ref first, uintPtr), Vector128.LoadUnsafe<byte>(ref second, uintPtr)).ExtractMostSignificantBits<byte>();
				if (num != 65535U)
				{
					IL_140:
					num = ~num;
					return uintPtr + (UIntPtr)uint.TrailingZeroCount(num);
				}
			}
			uintPtr = uintPtr2;
			num = Vector128.Equals<byte>(Vector128.LoadUnsafe<byte>(ref first, uintPtr), Vector128.LoadUnsafe<byte>(ref second, uintPtr)).ExtractMostSignificantBits<byte>();
			if (num == 65535U)
			{
				return length;
			}
			goto IL_140;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0005AC21 File Offset: 0x00058E21
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ushort LoadUShort(ref byte start)
		{
			return Unsafe.ReadUnaligned<ushort>(ref start);
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0005AC29 File Offset: 0x00058E29
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint LoadUInt(ref byte start)
		{
			return Unsafe.ReadUnaligned<uint>(ref start);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0005AC31 File Offset: 0x00058E31
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint LoadUInt(ref byte start, UIntPtr offset)
		{
			return Unsafe.ReadUnaligned<uint>(Unsafe.AddByteOffset<byte>(ref start, offset));
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0005AC3F File Offset: 0x00058E3F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static UIntPtr LoadNUInt(ref byte start)
		{
			return Unsafe.ReadUnaligned<UIntPtr>(ref start);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x0005AC47 File Offset: 0x00058E47
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static UIntPtr LoadNUInt(ref byte start, UIntPtr offset)
		{
			return Unsafe.ReadUnaligned<UIntPtr>(Unsafe.AddByteOffset<byte>(ref start, offset));
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0005AC55 File Offset: 0x00058E55
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static UIntPtr GetByteVector128SpanLength(UIntPtr offset, int length)
		{
			return (UIntPtr)(length - (int)offset & ~(Vector128<byte>.Count - 1));
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0005AC68 File Offset: 0x00058E68
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static UIntPtr UnalignedCountVector128(byte* searchSpace)
		{
			IntPtr intPtr = searchSpace & Vector128<byte>.Count - 1;
			return (UIntPtr)((uint)((IntPtr)Vector128<byte>.Count - intPtr & (IntPtr)(Vector128<byte>.Count - 1)));
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0005AC94 File Offset: 0x00058E94
		public static void Reverse(ref byte buf, UIntPtr length)
		{
			IntPtr intPtr = (IntPtr)length;
			IntPtr intPtr2 = (IntPtr)0;
			if (false)
			{
			}
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated && intPtr >= (IntPtr)(Vector128<byte>.Count * 2))
			{
				IntPtr intPtr3 = intPtr - (IntPtr)Vector128<byte>.Count;
				do
				{
					Vector128<byte> vector = Vector128.LoadUnsafe<byte>(ref buf, (UIntPtr)intPtr2);
					Vector128<byte> vector2 = Vector128.LoadUnsafe<byte>(ref buf, (UIntPtr)intPtr3);
					Vector128<byte> source = Vector128.Shuffle(vector, Vector128.Create(15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0));
					vector2 = Vector128.Shuffle(vector2, Vector128.Create(15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0));
					vector2.StoreUnsafe(ref buf, (UIntPtr)intPtr2);
					source.StoreUnsafe(ref buf, (UIntPtr)intPtr3);
					intPtr2 += (IntPtr)Vector128<byte>.Count;
					intPtr3 -= (IntPtr)Vector128<byte>.Count;
				}
				while (intPtr3 >= intPtr2);
				intPtr = intPtr3 + (IntPtr)Vector128<byte>.Count - intPtr2;
			}
			if (intPtr >= (IntPtr)8)
			{
				IntPtr intPtr4 = (IntPtr)(length - (UIntPtr)intPtr2 - (UIntPtr)((IntPtr)8));
				do
				{
					long value = Unsafe.ReadUnaligned<long>(Unsafe.Add<byte>(ref buf, intPtr2));
					long value2 = Unsafe.ReadUnaligned<long>(Unsafe.Add<byte>(ref buf, intPtr4));
					Unsafe.WriteUnaligned<long>(Unsafe.Add<byte>(ref buf, intPtr2), BinaryPrimitives.ReverseEndianness(value2));
					Unsafe.WriteUnaligned<long>(Unsafe.Add<byte>(ref buf, intPtr4), BinaryPrimitives.ReverseEndianness(value));
					intPtr2 += (IntPtr)8;
					intPtr4 -= (IntPtr)8;
				}
				while (intPtr4 >= intPtr2);
				intPtr = intPtr4 + (IntPtr)8 - intPtr2;
			}
			if (intPtr >= (IntPtr)4)
			{
				IntPtr intPtr5 = (IntPtr)(length - (UIntPtr)intPtr2 - (UIntPtr)((IntPtr)4));
				do
				{
					int value3 = Unsafe.ReadUnaligned<int>(Unsafe.Add<byte>(ref buf, intPtr2));
					int value4 = Unsafe.ReadUnaligned<int>(Unsafe.Add<byte>(ref buf, intPtr5));
					Unsafe.WriteUnaligned<int>(Unsafe.Add<byte>(ref buf, intPtr2), BinaryPrimitives.ReverseEndianness(value4));
					Unsafe.WriteUnaligned<int>(Unsafe.Add<byte>(ref buf, intPtr5), BinaryPrimitives.ReverseEndianness(value3));
					intPtr2 += (IntPtr)4;
					intPtr5 -= (IntPtr)4;
				}
				while (intPtr5 >= intPtr2);
				intPtr = intPtr5 + (IntPtr)4 - intPtr2;
			}
			if (intPtr > (IntPtr)1)
			{
				SpanHelpers.ReverseInner<byte>(Unsafe.Add<byte>(ref buf, intPtr2), (UIntPtr)intPtr);
			}
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0005AE4C File Offset: 0x0005904C
		[Intrinsic]
		internal static void Memmove(ref byte dest, ref byte src, UIntPtr len)
		{
			if (Unsafe.ByteOffset<byte>(ref src, ref dest) >= (IntPtr)len && Unsafe.ByteOffset<byte>(ref dest, ref src) >= (IntPtr)len)
			{
				ref byte source = ref Unsafe.Add<byte>(ref src, len);
				ref byte source2 = ref Unsafe.Add<byte>(ref dest, len);
				if (len > (UIntPtr)((IntPtr)16))
				{
					if (len > (UIntPtr)((IntPtr)64))
					{
						if (len > (UIntPtr)((IntPtr)2048))
						{
							goto IL_1D2;
						}
						if (len >= (UIntPtr)((IntPtr)256))
						{
							UIntPtr uintPtr = (UIntPtr)((IntPtr)64 - (IntPtr)Unsafe.OpportunisticMisalignment<byte>(ref dest, (UIntPtr)((IntPtr)64)));
							Unsafe.WriteUnaligned<SpanHelpers.Block64>(ref dest, Unsafe.ReadUnaligned<SpanHelpers.Block64>(ref src));
							src = Unsafe.Add<byte>(ref src, uintPtr);
							dest = Unsafe.Add<byte>(ref dest, uintPtr);
							len -= uintPtr;
						}
						UIntPtr uintPtr2 = len >> 6;
						do
						{
							Unsafe.WriteUnaligned<SpanHelpers.Block64>(ref dest, Unsafe.ReadUnaligned<SpanHelpers.Block64>(ref src));
							dest = Unsafe.Add<byte>(ref dest, 64);
							src = Unsafe.Add<byte>(ref src, 64);
							uintPtr2--;
						}
						while (uintPtr2 != 0);
						len %= (UIntPtr)((IntPtr)64);
						if (len <= (UIntPtr)((IntPtr)16))
						{
							Unsafe.WriteUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref source2, -16), Unsafe.ReadUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref source, -16)));
							return;
						}
					}
					Unsafe.WriteUnaligned<SpanHelpers.Block16>(ref dest, Unsafe.ReadUnaligned<SpanHelpers.Block16>(ref src));
					if (len > (UIntPtr)((IntPtr)32))
					{
						Unsafe.WriteUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref dest, 16), Unsafe.ReadUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref src, 16)));
						if (len > (UIntPtr)((IntPtr)48))
						{
							Unsafe.WriteUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref dest, 32), Unsafe.ReadUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref src, 32)));
						}
					}
					Unsafe.WriteUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref source2, -16), Unsafe.ReadUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref source, -16)));
					return;
				}
				if ((len & (UIntPtr)((IntPtr)24)) != 0)
				{
					Unsafe.WriteUnaligned<long>(ref dest, Unsafe.ReadUnaligned<long>(ref src));
					Unsafe.WriteUnaligned<long>(Unsafe.Add<byte>(ref source2, -8), Unsafe.ReadUnaligned<long>(Unsafe.Add<byte>(ref source, -8)));
					return;
				}
				if ((len & (UIntPtr)((IntPtr)4)) != 0)
				{
					Unsafe.WriteUnaligned<int>(ref dest, Unsafe.ReadUnaligned<int>(ref src));
					Unsafe.WriteUnaligned<int>(Unsafe.Add<byte>(ref source2, -4), Unsafe.ReadUnaligned<int>(Unsafe.Add<byte>(ref source, -4)));
					return;
				}
				if (len == 0)
				{
					return;
				}
				dest = src;
				if ((len & (UIntPtr)((IntPtr)2)) == 0)
				{
					return;
				}
				Unsafe.WriteUnaligned<short>(Unsafe.Add<byte>(ref source2, -2), Unsafe.ReadUnaligned<short>(Unsafe.Add<byte>(ref source, -2)));
				return;
			}
			else if (Unsafe.AreSame<byte>(ref dest, ref src))
			{
				Unsafe.ReadUnaligned<byte>(ref dest);
				return;
			}
			IL_1D2:
			Unsafe.ReadUnaligned<byte>(ref dest);
			Unsafe.ReadUnaligned<byte>(ref src);
			Buffer._Memmove(ref dest, ref src, len);
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0005B044 File Offset: 0x00059244
		[Intrinsic]
		public static void ClearWithoutReferences(ref byte dest, UIntPtr len)
		{
			if (len == 0)
			{
				return;
			}
			ref byte source = ref Unsafe.Add<byte>(ref dest, len);
			if (len > (UIntPtr)((IntPtr)16))
			{
				if (len > (UIntPtr)((IntPtr)64))
				{
					if (len > (UIntPtr)((IntPtr)1024))
					{
						Unsafe.ReadUnaligned<byte>(ref dest);
						Buffer._ZeroMemory(ref dest, len);
						return;
					}
					if (len >= (UIntPtr)((IntPtr)256))
					{
						UIntPtr uintPtr = (UIntPtr)((IntPtr)64 - (IntPtr)Unsafe.OpportunisticMisalignment<byte>(ref dest, (UIntPtr)((IntPtr)64)));
						Unsafe.WriteUnaligned<SpanHelpers.Block64>(ref dest, default(SpanHelpers.Block64));
						dest = Unsafe.Add<byte>(ref dest, uintPtr);
						len -= uintPtr;
					}
					UIntPtr uintPtr2 = len >> 6;
					do
					{
						Unsafe.WriteUnaligned<SpanHelpers.Block64>(ref dest, default(SpanHelpers.Block64));
						dest = Unsafe.Add<byte>(ref dest, 64);
						uintPtr2--;
					}
					while (uintPtr2 != 0);
					len %= (UIntPtr)((IntPtr)64);
					if (len <= (UIntPtr)((IntPtr)16))
					{
						Unsafe.WriteUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref source, -16), default(SpanHelpers.Block16));
						return;
					}
				}
				Unsafe.WriteUnaligned<SpanHelpers.Block16>(ref dest, default(SpanHelpers.Block16));
				if (len > (UIntPtr)((IntPtr)32))
				{
					Unsafe.WriteUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref dest, 16), default(SpanHelpers.Block16));
					if (len > (UIntPtr)((IntPtr)48))
					{
						Unsafe.WriteUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref dest, 32), default(SpanHelpers.Block16));
					}
				}
				Unsafe.WriteUnaligned<SpanHelpers.Block16>(Unsafe.Add<byte>(ref source, -16), default(SpanHelpers.Block16));
				return;
			}
			if ((len & (UIntPtr)((IntPtr)24)) != 0)
			{
				Unsafe.WriteUnaligned<long>(ref dest, 0L);
				Unsafe.WriteUnaligned<long>(Unsafe.Add<byte>(ref source, -8), 0L);
				return;
			}
			if ((len & (UIntPtr)((IntPtr)4)) != 0)
			{
				Unsafe.WriteUnaligned<int>(ref dest, 0);
				Unsafe.WriteUnaligned<int>(Unsafe.Add<byte>(ref source, -4), 0);
				return;
			}
			if (len == 0)
			{
				return;
			}
			dest = 0;
			if ((len & (UIntPtr)((IntPtr)2)) == 0)
			{
				return;
			}
			Unsafe.WriteUnaligned<short>(Unsafe.Add<byte>(ref source, -2), 0);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0005B1C0 File Offset: 0x000593C0
		public unsafe static int IndexOf(ref char searchSpace, int searchSpaceLength, ref char value, int valueLength)
		{
			if (valueLength == 0)
			{
				return 0;
			}
			int num = valueLength - 1;
			if (num == 0)
			{
				return SpanHelpers.IndexOfChar(ref searchSpace, value, searchSpaceLength);
			}
			IntPtr intPtr = (IntPtr)0;
			char c = value;
			int num2 = searchSpaceLength - num;
			if (!Vector128.IsHardwareAccelerated || num2 < Vector128<ushort>.Count)
			{
				ref byte second = ref Unsafe.As<char, byte>(Unsafe.Add<char>(ref value, 1));
				int i = num2;
				while (i > 0)
				{
					int num3 = SpanHelpers.NonPackedIndexOfChar(Unsafe.Add<char>(ref searchSpace, intPtr), c, i);
					if (num3 < 0)
					{
						break;
					}
					i -= num3;
					intPtr += (IntPtr)num3;
					if (i <= 0)
					{
						break;
					}
					if (SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(Unsafe.Add<char>(ref searchSpace, intPtr + (IntPtr)1)), ref second, (UIntPtr)num * (UIntPtr)((IntPtr)2)))
					{
						return (int)intPtr;
					}
					i--;
					intPtr++;
				}
				return -1;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			ushort num4 = (ushort)(*Unsafe.Add<char>(ref value, num));
			IntPtr intPtr2 = (IntPtr)num;
			while (num4 == (ushort)c && intPtr2 > (IntPtr)1)
			{
				num4 = (ushort)(*Unsafe.Add<char>(ref value, --intPtr2));
			}
			Vector128<ushort> left = Vector128.Create((ushort)c);
			Vector128<ushort> left2 = Vector128.Create(num4);
			IntPtr intPtr3 = (IntPtr)num2 - (IntPtr)Vector128<ushort>.Count;
			IntPtr intPtr4;
			for (;;)
			{
				Vector128<ushort> right = Vector128.Equals<ushort>(left2, Vector128.LoadUnsafe(ref searchSpace, (UIntPtr)(intPtr + intPtr2)));
				Vector128<byte> vector = (Vector128.Equals<ushort>(left, Vector128.LoadUnsafe(ref searchSpace, (UIntPtr)intPtr)) & right).AsByte<ushort>();
				if (vector != Vector128<byte>.Zero)
				{
					uint num5 = vector.ExtractMostSignificantBits<byte>();
					do
					{
						intPtr4 = (IntPtr)((UIntPtr)(uint.TrailingZeroCount(num5) / 2U));
						if (valueLength == 2 || SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(Unsafe.Add<char>(ref searchSpace, intPtr + intPtr4)), Unsafe.As<char, byte>(ref value), (UIntPtr)valueLength * (UIntPtr)((IntPtr)2)))
						{
							goto IL_17F;
						}
						num5 = BitOperations.ResetLowestSetBit(BitOperations.ResetLowestSetBit(num5));
					}
					while (num5 != 0U);
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
			IL_17F:
			return (int)(intPtr + intPtr4);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0005B368 File Offset: 0x00059568
		public unsafe static int LastIndexOf(ref char searchSpace, int searchSpaceLength, ref char value, int valueLength)
		{
			if (valueLength == 0)
			{
				return searchSpaceLength;
			}
			int num = valueLength - 1;
			if (num == 0)
			{
				return SpanHelpers.LastIndexOfValueType<short>(Unsafe.As<char, short>(ref searchSpace), (short)value, searchSpaceLength);
			}
			int num2 = 0;
			char c = value;
			int num3 = searchSpaceLength - num;
			if (!Vector128.IsHardwareAccelerated || num3 < Vector128<ushort>.Count)
			{
				ref byte second = ref Unsafe.As<char, byte>(Unsafe.Add<char>(ref value, 1));
				int num5;
				for (;;)
				{
					int num4 = searchSpaceLength - num2 - num;
					if (num4 <= 0)
					{
						return -1;
					}
					num5 = SpanHelpers.LastIndexOfValueType<short>(Unsafe.As<char, short>(ref searchSpace), (short)c, num4);
					if (num5 == -1)
					{
						return -1;
					}
					if (SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(Unsafe.Add<char>(ref searchSpace, num5 + 1)), ref second, (UIntPtr)num * (UIntPtr)((IntPtr)2)))
					{
						break;
					}
					num2 += num4 - num5;
				}
				return num5;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			num2 = num3 - Vector128<ushort>.Count;
			char c2 = *Unsafe.Add<char>(ref value, num);
			int num6 = num;
			while (c2 == value && num6 > 1)
			{
				c2 = *Unsafe.Add<char>(ref value, --num6);
			}
			Vector128<ushort> left = Vector128.Create((ushort)value);
			Vector128<ushort> left2 = Vector128.Create((ushort)c2);
			int num9;
			for (;;)
			{
				Vector128<ushort> left3 = Vector128.Equals<ushort>(left, Vector128.LoadUnsafe(ref searchSpace, (UIntPtr)((IntPtr)num2)));
				Vector128<ushort> right = Vector128.Equals<ushort>(left2, Vector128.LoadUnsafe(ref searchSpace, (UIntPtr)((IntPtr)(num2 + num6))));
				Vector128<byte> vector = (left3 & right).AsByte<ushort>();
				if (vector != Vector128<byte>.Zero)
				{
					uint num7 = vector.ExtractMostSignificantBits<byte>();
					do
					{
						int num8 = 30 - BitOperations.LeadingZeroCount(num7);
						num9 = num8 / 2;
						if (valueLength == 2 || SpanHelpers.SequenceEqual(Unsafe.As<char, byte>(Unsafe.Add<char>(ref searchSpace, num2 + num9)), Unsafe.As<char, byte>(ref value), (UIntPtr)valueLength * (UIntPtr)((IntPtr)2)))
						{
							goto IL_15F;
						}
						num7 &= ~(3U << num8);
					}
					while (num7 != 0U);
				}
				num2 -= Vector128<ushort>.Count;
				if (num2 == -Vector128<ushort>.Count)
				{
					return -1;
				}
				if (num2 < 0)
				{
					num2 = 0;
				}
			}
			IL_15F:
			return num9 + num2;
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0005B50C File Offset: 0x0005970C
		public unsafe static int SequenceCompareTo(ref char first, int firstLength, ref char second, int secondLength)
		{
			int result = firstLength - secondLength;
			if (!Unsafe.AreSame<char>(ref first, ref second))
			{
				UIntPtr uintPtr = (UIntPtr)((firstLength < secondLength) ? firstLength : secondLength);
				UIntPtr uintPtr2 = (UIntPtr)((IntPtr)0);
				if (uintPtr >= (UIntPtr)((IntPtr)(8 / 2)))
				{
					if (Vector.IsHardwareAccelerated && uintPtr >= (UIntPtr)((IntPtr)Vector<ushort>.Count))
					{
						UIntPtr uintPtr3 = uintPtr - (UIntPtr)((IntPtr)Vector<ushort>.Count);
						while (!(Unsafe.ReadUnaligned<Vector<ushort>>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref first, (IntPtr)uintPtr2))) != Unsafe.ReadUnaligned<Vector<ushort>>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref second, (IntPtr)uintPtr2)))))
						{
							uintPtr2 += (UIntPtr)((IntPtr)Vector<ushort>.Count);
							if (uintPtr3 < uintPtr2)
							{
								break;
							}
						}
					}
					while (uintPtr >= uintPtr2 + (UIntPtr)((IntPtr)(8 / 2)) && Unsafe.ReadUnaligned<UIntPtr>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref first, (IntPtr)uintPtr2))) == Unsafe.ReadUnaligned<UIntPtr>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref second, (IntPtr)uintPtr2))))
					{
						uintPtr2 += (UIntPtr)((IntPtr)(8 / 2));
					}
				}
				if (uintPtr >= uintPtr2 + (UIntPtr)((IntPtr)2) && Unsafe.ReadUnaligned<int>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref first, (IntPtr)uintPtr2))) == Unsafe.ReadUnaligned<int>(Unsafe.As<char, byte>(Unsafe.Add<char>(ref second, (IntPtr)uintPtr2))))
				{
					uintPtr2 += (UIntPtr)((IntPtr)2);
				}
				while (uintPtr2 < uintPtr)
				{
					int num = Unsafe.Add<char>(ref first, (IntPtr)uintPtr2).CompareTo(*Unsafe.Add<char>(ref second, (IntPtr)uintPtr2));
					if (num != 0)
					{
						return num;
					}
					uintPtr2 += (UIntPtr)((IntPtr)1);
				}
			}
			return result;
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0005B62C File Offset: 0x0005982C
		public unsafe static int IndexOfNullCharacter(char* searchSpace)
		{
			IntPtr intPtr = (IntPtr)0;
			IntPtr intPtr2 = (IntPtr)int.MaxValue;
			if ((searchSpace & 1) == 0 && Vector128.IsHardwareAccelerated)
			{
				intPtr2 = SpanHelpers.UnalignedCountVector128(searchSpace);
			}
			Vector128<ushort> vector;
			for (;;)
			{
				if (intPtr2 < (IntPtr)4)
				{
					while (intPtr2 > (IntPtr)0)
					{
						if (searchSpace[(long)intPtr * 2L / 2L] == '\0')
						{
							goto IL_150;
						}
						intPtr++;
						intPtr2--;
					}
					if (false)
					{
					}
					if (false)
					{
					}
					if (!Vector128.IsHardwareAccelerated || intPtr >= (IntPtr)2147483647)
					{
						goto IL_139;
					}
					intPtr2 = SpanHelpers.GetCharVector128SpanLength(intPtr, (IntPtr)int.MaxValue);
					if (intPtr2 > (IntPtr)0)
					{
						do
						{
							Vector128<ushort> right = *(Vector128<ushort>*)(searchSpace + (ulong)intPtr * 2UL / 2UL);
							vector = Vector128.Equals<ushort>(Vector128<ushort>.Zero, right);
							if (!(vector == Vector128<ushort>.Zero))
							{
								goto IL_100;
							}
							intPtr += (IntPtr)Vector128<ushort>.Count;
							intPtr2 -= (IntPtr)Vector128<ushort>.Count;
						}
						while (intPtr2 > (IntPtr)0);
					}
					if (intPtr >= (IntPtr)2147483647)
					{
						goto IL_139;
					}
					intPtr2 = (IntPtr)int.MaxValue - intPtr;
				}
				else
				{
					if (searchSpace[(long)intPtr * 2L / 2L] == '\0')
					{
						goto IL_150;
					}
					if (searchSpace[(long)(intPtr + (IntPtr)1) * 2L / 2L] == '\0')
					{
						goto IL_14A;
					}
					if (searchSpace[(long)(intPtr + (IntPtr)2) * 2L / 2L] == '\0')
					{
						goto IL_144;
					}
					if (searchSpace[(long)(intPtr + (IntPtr)3) * 2L / 2L] == '\0')
					{
						goto IL_13E;
					}
					intPtr += (IntPtr)4;
					intPtr2 -= (IntPtr)4;
				}
			}
			IL_100:
			uint value = vector.AsByte<ushort>().ExtractMostSignificantBits<byte>();
			return (int)((long)intPtr + (long)((ulong)(BitOperations.TrailingZeroCount(value) / 2)));
			IL_139:
			SpanHelpers.ThrowMustBeNullTerminatedString();
			IL_13E:
			return (int)(intPtr + (IntPtr)3);
			IL_144:
			return (int)(intPtr + (IntPtr)2);
			IL_14A:
			return (int)(intPtr + (IntPtr)1);
			IL_150:
			return (int)intPtr;
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0005B78B File Offset: 0x0005998B
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IntPtr GetCharVector128SpanLength(IntPtr offset, IntPtr length)
		{
			return length - offset & (IntPtr)(~(IntPtr)(Vector128<ushort>.Count - 1));
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0005B79A File Offset: 0x0005999A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static IntPtr UnalignedCountVector128(char* searchSpace)
		{
			return (IntPtr)((UIntPtr)(-searchSpace / 2) & (UIntPtr)((IntPtr)(Vector128<ushort>.Count - 1)));
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0005B7AC File Offset: 0x000599AC
		public static void Reverse(ref char buf, UIntPtr length)
		{
			IntPtr intPtr = (IntPtr)length;
			IntPtr intPtr2 = (IntPtr)0;
			if (false)
			{
			}
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated && intPtr >= (IntPtr)(Vector128<ushort>.Count * 2))
			{
				IntPtr intPtr3 = intPtr - (IntPtr)Vector128<ushort>.Count;
				do
				{
					ref ushort ptr = ref Unsafe.As<char, ushort>(Unsafe.Add<char>(ref buf, intPtr2));
					ref ushort ptr2 = ref Unsafe.As<char, ushort>(Unsafe.Add<char>(ref buf, intPtr3));
					Vector128<ushort> vector = Vector128.LoadUnsafe<ushort>(ref ptr);
					Vector128<ushort> vector2 = Vector128.LoadUnsafe<ushort>(ref ptr2);
					Vector128<ushort> source = Vector128.Shuffle(vector, Vector128.Create(7, 6, 5, 4, 3, 2, 1, 0));
					vector2 = Vector128.Shuffle(vector2, Vector128.Create(7, 6, 5, 4, 3, 2, 1, 0));
					vector2.StoreUnsafe(ref ptr);
					source.StoreUnsafe(ref ptr2);
					intPtr2 += (IntPtr)Vector128<ushort>.Count;
					intPtr3 -= (IntPtr)Vector128<ushort>.Count;
				}
				while (intPtr3 >= intPtr2);
				intPtr = intPtr3 + (IntPtr)Vector128<ushort>.Count - intPtr2;
			}
			if (intPtr > (IntPtr)1)
			{
				SpanHelpers.ReverseInner<char>(Unsafe.Add<char>(ref buf, intPtr2), (UIntPtr)intPtr);
			}
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0005B888 File Offset: 0x00059A88
		public unsafe static void ClearWithReferences(ref IntPtr ip, UIntPtr pointerSizeLength)
		{
			while (pointerSizeLength >= (UIntPtr)((IntPtr)8))
			{
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -1) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -2) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -3) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -4) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -5) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -6) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -7) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -8) = (IntPtr)0;
				pointerSizeLength -= (UIntPtr)((IntPtr)8);
			}
			if (pointerSizeLength < (UIntPtr)((IntPtr)4))
			{
				if (pointerSizeLength < (UIntPtr)((IntPtr)2))
				{
					if (pointerSizeLength <= (UIntPtr)((IntPtr)0))
					{
						return;
					}
					goto IL_FA;
				}
			}
			else
			{
				*Unsafe.Add<IntPtr>(ref ip, 2) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(ref ip, 3) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -3) = (IntPtr)0;
				*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -2) = (IntPtr)0;
			}
			*Unsafe.Add<IntPtr>(ref ip, 1) = (IntPtr)0;
			*Unsafe.Add<IntPtr>(Unsafe.Add<IntPtr>(ref ip, (IntPtr)pointerSizeLength), -1) = (IntPtr)0;
			IL_FA:
			ip = (IntPtr)0;
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0005B994 File Offset: 0x00059B94
		public static void Reverse(ref int buf, UIntPtr length)
		{
			IntPtr intPtr = (IntPtr)length;
			IntPtr intPtr2 = (IntPtr)0;
			if (false)
			{
			}
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated && intPtr >= (IntPtr)(Vector128<int>.Count * 2))
			{
				IntPtr intPtr3 = intPtr - (IntPtr)Vector128<int>.Count;
				do
				{
					Vector128<int> vector = Vector128.LoadUnsafe<int>(ref buf, (UIntPtr)intPtr2);
					Vector128<int> vector2 = Vector128.LoadUnsafe<int>(ref buf, (UIntPtr)intPtr3);
					Vector128<int> source = Vector128.Shuffle(vector, Vector128.Create(3, 2, 1, 0));
					vector2 = Vector128.Shuffle(vector2, Vector128.Create(3, 2, 1, 0));
					vector2.StoreUnsafe(ref buf, (UIntPtr)intPtr2);
					source.StoreUnsafe(ref buf, (UIntPtr)intPtr3);
					intPtr2 += (IntPtr)Vector128<int>.Count;
					intPtr3 -= (IntPtr)Vector128<int>.Count;
				}
				while (intPtr3 >= intPtr2);
				intPtr = intPtr3 + (IntPtr)Vector128<int>.Count - intPtr2;
			}
			if (intPtr > (IntPtr)1)
			{
				SpanHelpers.ReverseInner<int>(Unsafe.Add<int>(ref buf, intPtr2), (UIntPtr)intPtr);
			}
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0005BA48 File Offset: 0x00059C48
		public static void Reverse(ref long buf, UIntPtr length)
		{
			IntPtr intPtr = (IntPtr)length;
			IntPtr intPtr2 = (IntPtr)0;
			if (false)
			{
			}
			if (false)
			{
			}
			if (Vector128.IsHardwareAccelerated && intPtr >= (IntPtr)(Vector128<long>.Count * 2))
			{
				IntPtr intPtr3 = intPtr - (IntPtr)Vector128<long>.Count;
				do
				{
					Vector128<long> vector = Vector128.LoadUnsafe<long>(ref buf, (UIntPtr)intPtr2);
					Vector128<long> vector2 = Vector128.LoadUnsafe<long>(ref buf, (UIntPtr)intPtr3);
					Vector128<long> source = Vector128.Shuffle(vector, Vector128.Create(1L, 0L));
					vector2 = Vector128.Shuffle(vector2, Vector128.Create(1L, 0L));
					vector2.StoreUnsafe(ref buf, (UIntPtr)intPtr2);
					source.StoreUnsafe(ref buf, (UIntPtr)intPtr3);
					intPtr2 += (IntPtr)Vector128<long>.Count;
					intPtr3 -= (IntPtr)Vector128<long>.Count;
				}
				while (intPtr3 >= intPtr2);
				intPtr = intPtr3 + (IntPtr)Vector128<long>.Count - intPtr2;
			}
			if (intPtr > (IntPtr)1)
			{
				SpanHelpers.ReverseInner<long>(Unsafe.Add<long>(ref buf, intPtr2), (UIntPtr)intPtr);
			}
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0005BAF8 File Offset: 0x00059CF8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Reverse<T>(ref T elements, UIntPtr length)
		{
			if (!RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				if (sizeof(T) == 1)
				{
					SpanHelpers.Reverse(Unsafe.As<T, byte>(ref elements), length);
					return;
				}
				if (sizeof(T) == 2)
				{
					SpanHelpers.Reverse(Unsafe.As<T, char>(ref elements), length);
					return;
				}
				if (sizeof(T) == 4)
				{
					SpanHelpers.Reverse(Unsafe.As<T, int>(ref elements), length);
					return;
				}
				if (sizeof(T) == 8)
				{
					SpanHelpers.Reverse(Unsafe.As<T, long>(ref elements), length);
					return;
				}
			}
			SpanHelpers.ReverseInner<T>(ref elements, length);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0005BB6C File Offset: 0x00059D6C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void ReverseInner<T>(ref T elements, UIntPtr length)
		{
			ref T ptr = ref elements;
			ref T ptr2 = ref Unsafe.Subtract<T>(Unsafe.Add<T>(ref ptr, length), 1);
			do
			{
				T t = ptr;
				ptr = ptr2;
				ptr2 = t;
				ptr = Unsafe.Add<T>(ref ptr, 1);
				ptr2 = Unsafe.Subtract<T>(ref ptr2, 1);
			}
			while (Unsafe.IsAddressLessThan<T>(ref ptr, ref ptr2));
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0005BBBC File Offset: 0x00059DBC
		[Intrinsic]
		public unsafe static void Fill<T>(ref T refData, UIntPtr numElements, T value)
		{
			if (!RuntimeHelpers.IsReferenceOrContainsReferences<T>() && Vector.IsHardwareAccelerated && sizeof(T) <= Vector<byte>.Count && BitOperations.IsPow2(sizeof(T)) && numElements >= (UIntPtr)(Vector<byte>.Count / sizeof(T)))
			{
				T t = value;
				Vector<byte> value2;
				if (sizeof(T) == 1)
				{
					value2 = new Vector<byte>(*Unsafe.As<T, byte>(ref t));
				}
				else if (sizeof(T) == 2)
				{
					value2 = (Vector<byte>)new Vector<ushort>(*Unsafe.As<T, ushort>(ref t));
				}
				else if (sizeof(T) == 4)
				{
					value2 = ((typeof(T) == typeof(float)) ? ((Vector<byte>)new Vector<float>((float)((object)t))) : ((Vector<byte>)new Vector<uint>(*Unsafe.As<T, uint>(ref t))));
				}
				else if (sizeof(T) == 8)
				{
					value2 = ((typeof(T) == typeof(double)) ? ((Vector<byte>)new Vector<double>((double)((object)t))) : ((Vector<byte>)new Vector<ulong>(*Unsafe.As<T, ulong>(ref t))));
				}
				else if (sizeof(T) == 16)
				{
					Vector128<byte> value3 = *Unsafe.As<T, Vector128<byte>>(ref t);
					if (Vector<byte>.Count == 16)
					{
						value2 = value3.AsVector<byte>();
					}
					else
					{
						if (Vector<byte>.Count != 32)
						{
							goto IL_236;
						}
						value2 = Vector256.Create<byte>(value3).AsVector<byte>();
					}
				}
				else
				{
					if (sizeof(T) != 32 || Vector<byte>.Count != 32)
					{
						goto IL_236;
					}
					value2 = (*Unsafe.As<T, Vector256<byte>>(ref t)).AsVector<byte>();
				}
				ref byte source = ref Unsafe.As<T, byte>(ref refData);
				UIntPtr uintPtr = numElements * (UIntPtr)((IntPtr)sizeof(T));
				UIntPtr uintPtr2 = uintPtr & (UIntPtr)((IntPtr)(2 * -Vector<byte>.Count));
				UIntPtr uintPtr3 = (UIntPtr)((IntPtr)0);
				if (numElements >= (UIntPtr)(2 * Vector<byte>.Count / sizeof(T)))
				{
					do
					{
						Unsafe.WriteUnaligned<Vector<byte>>(Unsafe.AddByteOffset<byte>(ref source, uintPtr3), value2);
						Unsafe.WriteUnaligned<Vector<byte>>(Unsafe.AddByteOffset<byte>(ref source, uintPtr3 + (UIntPtr)((IntPtr)Vector<byte>.Count)), value2);
						uintPtr3 += (UIntPtr)(2 * Vector<byte>.Count);
					}
					while (uintPtr3 < uintPtr2);
				}
				if ((uintPtr & (UIntPtr)((IntPtr)Vector<byte>.Count)) != 0)
				{
					Unsafe.WriteUnaligned<Vector<byte>>(Unsafe.AddByteOffset<byte>(ref source, uintPtr3), value2);
				}
				Unsafe.WriteUnaligned<Vector<byte>>(Unsafe.AddByteOffset<byte>(ref source, uintPtr - (UIntPtr)((IntPtr)Vector<byte>.Count)), value2);
				return;
			}
			IL_236:
			UIntPtr uintPtr4 = (UIntPtr)((IntPtr)0);
			if (numElements >= (UIntPtr)((IntPtr)8))
			{
				UIntPtr uintPtr5 = numElements & (UIntPtr)(~(UIntPtr)((IntPtr)7));
				do
				{
					*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)0))) = value;
					*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)1))) = value;
					*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)2))) = value;
					*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)3))) = value;
					*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)4))) = value;
					*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)5))) = value;
					*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)6))) = value;
					*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)7))) = value;
				}
				while ((uintPtr4 += (UIntPtr)((IntPtr)8)) < uintPtr5);
			}
			if ((numElements & (UIntPtr)((IntPtr)4)) != 0)
			{
				*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)0))) = value;
				*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)1))) = value;
				*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)2))) = value;
				*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)3))) = value;
				uintPtr4 += (UIntPtr)((IntPtr)4);
			}
			if ((numElements & (UIntPtr)((IntPtr)2)) != 0)
			{
				*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)0))) = value;
				*Unsafe.Add<T>(ref refData, (IntPtr)(uintPtr4 + (UIntPtr)((IntPtr)1))) = value;
				uintPtr4 += (UIntPtr)((IntPtr)2);
			}
			if ((numElements & (UIntPtr)((IntPtr)1)) != 0)
			{
				*Unsafe.Add<T>(ref refData, (IntPtr)uintPtr4) = value;
			}
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0005BF28 File Offset: 0x0005A128
		public static int IndexOf<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) where T : IEquatable<T>
		{
			if (valueLength == 0)
			{
				return 0;
			}
			T value2 = value;
			ref T second = ref Unsafe.Add<T>(ref value, 1);
			int num = valueLength - 1;
			int num2 = 0;
			for (;;)
			{
				int num3 = searchSpaceLength - num2 - num;
				if (num3 <= 0)
				{
					return -1;
				}
				int num4 = SpanHelpers.IndexOf<T>(Unsafe.Add<T>(ref searchSpace, num2), value2, num3);
				if (num4 < 0)
				{
					return -1;
				}
				num2 += num4;
				if (SpanHelpers.SequenceEqual<T>(Unsafe.Add<T>(ref searchSpace, num2 + 1), ref second, num))
				{
					break;
				}
				num2++;
			}
			return num2;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0005BF94 File Offset: 0x0005A194
		public unsafe static bool Contains<T>(ref T searchSpace, T value, int length) where T : IEquatable<T>
		{
			IntPtr intPtr = (IntPtr)0;
			if (default(T) == null)
			{
				if (value == null)
				{
					IntPtr intPtr2 = (IntPtr)length;
					for (intPtr = (IntPtr)0; intPtr < intPtr2; intPtr++)
					{
						if (*Unsafe.Add<T>(ref searchSpace, intPtr) == null)
						{
							return true;
						}
					}
					return false;
				}
			}
			while (length >= 8)
			{
				length -= 8;
				ref T ptr = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr = ref t;
				}
				if (ptr.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)0)))
				{
					return true;
				}
				ref T ptr2 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr2 = ref t;
				}
				if (ptr2.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)1)))
				{
					return true;
				}
				ref T ptr3 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr3 = ref t;
				}
				if (ptr3.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)2)))
				{
					return true;
				}
				ref T ptr4 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr4 = ref t;
				}
				if (ptr4.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)3)))
				{
					return true;
				}
				ref T ptr5 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr5 = ref t;
				}
				if (ptr5.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)4)))
				{
					return true;
				}
				ref T ptr6 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr6 = ref t;
				}
				if (ptr6.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)5)))
				{
					return true;
				}
				ref T ptr7 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr7 = ref t;
				}
				if (ptr7.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)6)))
				{
					return true;
				}
				ref T ptr8 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr8 = ref t;
				}
				if (ptr8.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)7)))
				{
					return true;
				}
				intPtr += (IntPtr)8;
			}
			if (length >= 4)
			{
				length -= 4;
				ref T ptr9 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr9 = ref t;
				}
				if (ptr9.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)0)))
				{
					return true;
				}
				ref T ptr10 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr10 = ref t;
				}
				if (ptr10.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)1)))
				{
					return true;
				}
				ref T ptr11 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr11 = ref t;
				}
				if (ptr11.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)2)))
				{
					return true;
				}
				ref T ptr12 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr12 = ref t;
				}
				if (ptr12.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)3)))
				{
					return true;
				}
				intPtr += (IntPtr)4;
			}
			while (length > 0)
			{
				length--;
				ref T ptr13 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr13 = ref t;
				}
				if (ptr13.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr)))
				{
					return true;
				}
				intPtr += (IntPtr)1;
			}
			return false;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0005C300 File Offset: 0x0005A500
		public unsafe static int IndexOf<T>(ref T searchSpace, T value, int length) where T : IEquatable<T>
		{
			IntPtr intPtr = (IntPtr)0;
			if (default(T) == null)
			{
				if (value == null)
				{
					IntPtr intPtr2 = (IntPtr)length;
					for (intPtr = (IntPtr)0; intPtr < intPtr2; intPtr++)
					{
						if (*Unsafe.Add<T>(ref searchSpace, intPtr) == null)
						{
							goto IL_355;
						}
					}
					return -1;
				}
			}
			while (length >= 8)
			{
				length -= 8;
				ref T ptr = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr = ref t;
				}
				if (ptr.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr)))
				{
					goto IL_355;
				}
				ref T ptr2 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr2 = ref t;
				}
				if (ptr2.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)1)))
				{
					IL_358:
					return (int)(intPtr + (IntPtr)1);
				}
				ref T ptr3 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr3 = ref t;
				}
				if (ptr3.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)2)))
				{
					IL_35E:
					return (int)(intPtr + (IntPtr)2);
				}
				ref T ptr4 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr4 = ref t;
				}
				if (ptr4.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)3)))
				{
					IL_364:
					return (int)(intPtr + (IntPtr)3);
				}
				ref T ptr5 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr5 = ref t;
				}
				if (ptr5.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)4)))
				{
					return (int)(intPtr + (IntPtr)4);
				}
				ref T ptr6 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr6 = ref t;
				}
				if (ptr6.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)5)))
				{
					return (int)(intPtr + (IntPtr)5);
				}
				ref T ptr7 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr7 = ref t;
				}
				if (ptr7.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)6)))
				{
					return (int)(intPtr + (IntPtr)6);
				}
				ref T ptr8 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr8 = ref t;
				}
				if (ptr8.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)7)))
				{
					return (int)(intPtr + (IntPtr)7);
				}
				intPtr += (IntPtr)8;
			}
			if (length >= 4)
			{
				length -= 4;
				ref T ptr9 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr9 = ref t;
				}
				if (ptr9.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr)))
				{
					goto IL_355;
				}
				ref T ptr10 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr10 = ref t;
				}
				if (ptr10.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)1)))
				{
					goto IL_358;
				}
				ref T ptr11 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr11 = ref t;
				}
				if (ptr11.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)2)))
				{
					goto IL_35E;
				}
				ref T ptr12 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr12 = ref t;
				}
				if (ptr12.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr + (IntPtr)3)))
				{
					goto IL_364;
				}
				intPtr += (IntPtr)4;
			}
			while (length > 0)
			{
				ref T ptr13 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr13 = ref t;
				}
				if (ptr13.Equals(*Unsafe.Add<T>(ref searchSpace, intPtr)))
				{
					goto IL_355;
				}
				intPtr += (IntPtr)1;
				length--;
			}
			return -1;
			IL_355:
			return (int)intPtr;
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0005C690 File Offset: 0x0005A890
		public unsafe static int IndexOfAny<T>(ref T searchSpace, T value0, T value1, int length) where T : IEquatable<T>
		{
			int i = 0;
			if (default(T) == null)
			{
				if (value0 == null || value1 == null)
				{
					for (i = 0; i < length; i++)
					{
						T t = *Unsafe.Add<T>(ref searchSpace, i);
						if (t == null)
						{
							if (value0 == null)
							{
								return i;
							}
							if (value1 == null)
							{
								return i;
							}
						}
						else if (t.Equals(value0) || t.Equals(value1))
						{
							return i;
						}
					}
					return -1;
				}
			}
			while (length - i >= 8)
			{
				T t = *Unsafe.Add<T>(ref searchSpace, i);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return i;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 1);
				if (value0.Equals(t) || value1.Equals(t))
				{
					IL_352:
					return i + 1;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 2);
				if (value0.Equals(t) || value1.Equals(t))
				{
					IL_356:
					return i + 2;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 3);
				if (value0.Equals(t) || value1.Equals(t))
				{
					IL_35A:
					return i + 3;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 4);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return i + 4;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 5);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return i + 5;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 6);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return i + 6;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 7);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return i + 7;
				}
				i += 8;
			}
			if (length - i >= 4)
			{
				T t = *Unsafe.Add<T>(ref searchSpace, i);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return i;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 1);
				if (value0.Equals(t) || value1.Equals(t))
				{
					goto IL_352;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 2);
				if (value0.Equals(t) || value1.Equals(t))
				{
					goto IL_356;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 3);
				if (value0.Equals(t) || value1.Equals(t))
				{
					goto IL_35A;
				}
				i += 4;
			}
			while (i < length)
			{
				T t = *Unsafe.Add<T>(ref searchSpace, i);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0005CA0C File Offset: 0x0005AC0C
		public unsafe static int IndexOfAny<T>(ref T searchSpace, T value0, T value1, T value2, int length) where T : IEquatable<T>
		{
			int i = 0;
			if (default(T) == null)
			{
				if (value0 == null || value1 == null || value2 == null)
				{
					for (i = 0; i < length; i++)
					{
						T t = *Unsafe.Add<T>(ref searchSpace, i);
						if (t == null)
						{
							if (value0 == null || value1 == null)
							{
								return i;
							}
							if (value2 == null)
							{
								return i;
							}
						}
						else if (t.Equals(value0) || t.Equals(value1) || t.Equals(value2))
						{
							return i;
						}
					}
					return -1;
				}
			}
			while (length - i >= 8)
			{
				T t = *Unsafe.Add<T>(ref searchSpace, i);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return i;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 1);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					IL_473:
					return i + 1;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 2);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					IL_477:
					return i + 2;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 3);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					IL_47B:
					return i + 3;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 4);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return i + 4;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 5);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return i + 5;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 6);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return i + 6;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 7);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return i + 7;
				}
				i += 8;
			}
			if (length - i >= 4)
			{
				T t = *Unsafe.Add<T>(ref searchSpace, i);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return i;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 1);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					goto IL_473;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 2);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					goto IL_477;
				}
				t = *Unsafe.Add<T>(ref searchSpace, i + 3);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					goto IL_47B;
				}
				i += 4;
			}
			while (i < length)
			{
				T t = *Unsafe.Add<T>(ref searchSpace, i);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0005CEA8 File Offset: 0x0005B0A8
		public unsafe static int IndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) where T : IEquatable<T>
		{
			if (valueLength == 0)
			{
				return -1;
			}
			if (typeof(T).IsValueType)
			{
				for (int i = 0; i < searchSpaceLength; i++)
				{
					T other = *Unsafe.Add<T>(ref searchSpace, i);
					for (int j = 0; j < valueLength; j++)
					{
						if (Unsafe.Add<T>(ref value, j).Equals(other))
						{
							return i;
						}
					}
				}
			}
			else
			{
				for (int k = 0; k < searchSpaceLength; k++)
				{
					T t = *Unsafe.Add<T>(ref searchSpace, k);
					if (t != null)
					{
						for (int l = 0; l < valueLength; l++)
						{
							ref T ptr = ref t;
							if (default(T) == null)
							{
								T t2 = t;
								ptr = ref t2;
							}
							if (ptr.Equals(*Unsafe.Add<T>(ref value, l)))
							{
								return k;
							}
						}
					}
					else
					{
						for (int m = 0; m < valueLength; m++)
						{
							if (*Unsafe.Add<T>(ref value, m) == null)
							{
								return k;
							}
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0005CFA8 File Offset: 0x0005B1A8
		public static int LastIndexOf<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) where T : IEquatable<T>
		{
			if (valueLength == 0)
			{
				return searchSpaceLength;
			}
			int num = valueLength - 1;
			if (num == 0)
			{
				return SpanHelpers.LastIndexOf<T>(ref searchSpace, value, searchSpaceLength);
			}
			int num2 = 0;
			T value2 = value;
			ref T second = ref Unsafe.Add<T>(ref value, 1);
			int num4;
			for (;;)
			{
				int num3 = searchSpaceLength - num2 - num;
				if (num3 <= 0)
				{
					return -1;
				}
				num4 = SpanHelpers.LastIndexOf<T>(ref searchSpace, value2, num3);
				if (num4 < 0)
				{
					return -1;
				}
				if (SpanHelpers.SequenceEqual<T>(Unsafe.Add<T>(ref searchSpace, num4 + 1), ref second, num))
				{
					break;
				}
				num2 += num3 - num4;
			}
			return num4;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0005D020 File Offset: 0x0005B220
		public unsafe static int LastIndexOf<T>(ref T searchSpace, T value, int length) where T : IEquatable<T>
		{
			if (default(T) == null)
			{
				if (value == null)
				{
					for (length--; length >= 0; length--)
					{
						if (*Unsafe.Add<T>(ref searchSpace, length) == null)
						{
							return length;
						}
					}
					return -1;
				}
			}
			while (length >= 8)
			{
				length -= 8;
				ref T ptr = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr = ref t;
				}
				if (ptr.Equals(*Unsafe.Add<T>(ref searchSpace, length + 7)))
				{
					return length + 7;
				}
				ref T ptr2 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr2 = ref t;
				}
				if (ptr2.Equals(*Unsafe.Add<T>(ref searchSpace, length + 6)))
				{
					return length + 6;
				}
				ref T ptr3 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr3 = ref t;
				}
				if (ptr3.Equals(*Unsafe.Add<T>(ref searchSpace, length + 5)))
				{
					return length + 5;
				}
				ref T ptr4 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr4 = ref t;
				}
				if (ptr4.Equals(*Unsafe.Add<T>(ref searchSpace, length + 4)))
				{
					return length + 4;
				}
				ref T ptr5 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr5 = ref t;
				}
				if (ptr5.Equals(*Unsafe.Add<T>(ref searchSpace, length + 3)))
				{
					IL_343:
					return length + 3;
				}
				ref T ptr6 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr6 = ref t;
				}
				if (ptr6.Equals(*Unsafe.Add<T>(ref searchSpace, length + 2)))
				{
					IL_33F:
					return length + 2;
				}
				ref T ptr7 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr7 = ref t;
				}
				if (ptr7.Equals(*Unsafe.Add<T>(ref searchSpace, length + 1)))
				{
					IL_33B:
					return length + 1;
				}
				ref T ptr8 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr8 = ref t;
				}
				if (ptr8.Equals(*Unsafe.Add<T>(ref searchSpace, length)))
				{
					return length;
				}
			}
			if (length >= 4)
			{
				length -= 4;
				ref T ptr9 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr9 = ref t;
				}
				if (ptr9.Equals(*Unsafe.Add<T>(ref searchSpace, length + 3)))
				{
					goto IL_343;
				}
				ref T ptr10 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr10 = ref t;
				}
				if (ptr10.Equals(*Unsafe.Add<T>(ref searchSpace, length + 2)))
				{
					goto IL_33F;
				}
				ref T ptr11 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr11 = ref t;
				}
				if (ptr11.Equals(*Unsafe.Add<T>(ref searchSpace, length + 1)))
				{
					goto IL_33B;
				}
				ref T ptr12 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr12 = ref t;
				}
				if (ptr12.Equals(*Unsafe.Add<T>(ref searchSpace, length)))
				{
					return length;
				}
			}
			while (length > 0)
			{
				length--;
				ref T ptr13 = ref value;
				if (default(T) == null)
				{
					T t = value;
					ptr13 = ref t;
				}
				if (ptr13.Equals(*Unsafe.Add<T>(ref searchSpace, length)))
				{
					return length;
				}
			}
			return -1;
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0005D384 File Offset: 0x0005B584
		public unsafe static int LastIndexOfAny<T>(ref T searchSpace, T value0, T value1, int length) where T : IEquatable<T>
		{
			if (default(T) == null)
			{
				if (value0 == null || value1 == null)
				{
					for (length--; length >= 0; length--)
					{
						T t = *Unsafe.Add<T>(ref searchSpace, length);
						if (t == null)
						{
							if (value0 == null)
							{
								return length;
							}
							if (value1 == null)
							{
								return length;
							}
						}
						else if (t.Equals(value0) || t.Equals(value1))
						{
							return length;
						}
					}
					return -1;
				}
			}
			while (length >= 8)
			{
				length -= 8;
				T t = *Unsafe.Add<T>(ref searchSpace, length + 7);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return length + 7;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 6);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return length + 6;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 5);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return length + 5;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 4);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return length + 4;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 3);
				if (value0.Equals(t) || value1.Equals(t))
				{
					IL_35B:
					return length + 3;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 2);
				if (value0.Equals(t) || value1.Equals(t))
				{
					IL_357:
					return length + 2;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 1);
				if (value0.Equals(t) || value1.Equals(t))
				{
					IL_353:
					return length + 1;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return length;
				}
			}
			if (length >= 4)
			{
				length -= 4;
				T t = *Unsafe.Add<T>(ref searchSpace, length + 3);
				if (value0.Equals(t) || value1.Equals(t))
				{
					goto IL_35B;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 2);
				if (value0.Equals(t) || value1.Equals(t))
				{
					goto IL_357;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 1);
				if (value0.Equals(t) || value1.Equals(t))
				{
					goto IL_353;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length);
				if (value0.Equals(t))
				{
					return length;
				}
				if (value1.Equals(t))
				{
					return length;
				}
			}
			while (length > 0)
			{
				length--;
				T t = *Unsafe.Add<T>(ref searchSpace, length);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return length;
				}
			}
			return -1;
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0005D700 File Offset: 0x0005B900
		public unsafe static int LastIndexOfAny<T>(ref T searchSpace, T value0, T value1, T value2, int length) where T : IEquatable<T>
		{
			if (default(T) == null)
			{
				if (value0 == null || value1 == null || value2 == null)
				{
					for (length--; length >= 0; length--)
					{
						T t = *Unsafe.Add<T>(ref searchSpace, length);
						if (t == null)
						{
							if (value0 == null || value1 == null)
							{
								return length;
							}
							if (value2 == null)
							{
								return length;
							}
						}
						else if (t.Equals(value0) || t.Equals(value1) || t.Equals(value2))
						{
							return length;
						}
					}
					return -1;
				}
			}
			while (length >= 8)
			{
				length -= 8;
				T t = *Unsafe.Add<T>(ref searchSpace, length + 7);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return length + 7;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 6);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return length + 6;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 5);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return length + 5;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 4);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return length + 4;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 3);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					IL_492:
					return length + 3;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 2);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					IL_48D:
					return length + 2;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 1);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					IL_488:
					return length + 1;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return length;
				}
			}
			if (length >= 4)
			{
				length -= 4;
				T t = *Unsafe.Add<T>(ref searchSpace, length + 3);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					goto IL_492;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 2);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					goto IL_48D;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length + 1);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					goto IL_488;
				}
				t = *Unsafe.Add<T>(ref searchSpace, length);
				if (value0.Equals(t) || value1.Equals(t))
				{
					return length;
				}
				if (value2.Equals(t))
				{
					return length;
				}
			}
			while (length > 0)
			{
				length--;
				T t = *Unsafe.Add<T>(ref searchSpace, length);
				if (value0.Equals(t) || value1.Equals(t) || value2.Equals(t))
				{
					return length;
				}
			}
			return -1;
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0005DBB8 File Offset: 0x0005BDB8
		public unsafe static int LastIndexOfAny<T>(ref T searchSpace, int searchSpaceLength, ref T value, int valueLength) where T : IEquatable<T>
		{
			if (valueLength == 0)
			{
				return -1;
			}
			if (typeof(T).IsValueType)
			{
				for (int i = searchSpaceLength - 1; i >= 0; i--)
				{
					T other = *Unsafe.Add<T>(ref searchSpace, i);
					for (int j = 0; j < valueLength; j++)
					{
						if (Unsafe.Add<T>(ref value, j).Equals(other))
						{
							return i;
						}
					}
				}
			}
			else
			{
				for (int k = searchSpaceLength - 1; k >= 0; k--)
				{
					T t = *Unsafe.Add<T>(ref searchSpace, k);
					if (t != null)
					{
						for (int l = 0; l < valueLength; l++)
						{
							ref T ptr = ref t;
							if (default(T) == null)
							{
								T t2 = t;
								ptr = ref t2;
							}
							if (ptr.Equals(*Unsafe.Add<T>(ref value, l)))
							{
								return k;
							}
						}
					}
					else
					{
						for (int m = 0; m < valueLength; m++)
						{
							if (*Unsafe.Add<T>(ref value, m) == null)
							{
								return k;
							}
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0005DCBC File Offset: 0x0005BEBC
		internal unsafe static int IndexOfAnyExcept<T>(ref T searchSpace, T value0, int length)
		{
			for (int i = 0; i < length; i++)
			{
				if (!EqualityComparer<T>.Default.Equals(*Unsafe.Add<T>(ref searchSpace, i), value0))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0005DCF4 File Offset: 0x0005BEF4
		internal unsafe static int LastIndexOfAnyExcept<T>(ref T searchSpace, T value0, int length)
		{
			for (int i = length - 1; i >= 0; i--)
			{
				if (!EqualityComparer<T>.Default.Equals(*Unsafe.Add<T>(ref searchSpace, i), value0))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0005DD2C File Offset: 0x0005BF2C
		internal static int IndexOfAnyExcept<T>(ref T searchSpace, T value0, T value1, int length)
		{
			for (int i = 0; i < length; i++)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (!EqualityComparer<T>.Default.Equals(ptr, value0) && !EqualityComparer<T>.Default.Equals(ptr, value1))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0005DD78 File Offset: 0x0005BF78
		internal static int LastIndexOfAnyExcept<T>(ref T searchSpace, T value0, T value1, int length)
		{
			for (int i = length - 1; i >= 0; i--)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (!EqualityComparer<T>.Default.Equals(ptr, value0) && !EqualityComparer<T>.Default.Equals(ptr, value1))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0005DDC4 File Offset: 0x0005BFC4
		internal static int IndexOfAnyExcept<T>(ref T searchSpace, T value0, T value1, T value2, int length)
		{
			for (int i = 0; i < length; i++)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (!EqualityComparer<T>.Default.Equals(ptr, value0) && !EqualityComparer<T>.Default.Equals(ptr, value1) && !EqualityComparer<T>.Default.Equals(ptr, value2))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0005DE24 File Offset: 0x0005C024
		internal static int LastIndexOfAnyExcept<T>(ref T searchSpace, T value0, T value1, T value2, int length)
		{
			for (int i = length - 1; i >= 0; i--)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (!EqualityComparer<T>.Default.Equals(ptr, value0) && !EqualityComparer<T>.Default.Equals(ptr, value1) && !EqualityComparer<T>.Default.Equals(ptr, value2))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0005DE84 File Offset: 0x0005C084
		internal static int IndexOfAnyExcept<T>(ref T searchSpace, T value0, T value1, T value2, T value3, int length)
		{
			for (int i = 0; i < length; i++)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (!EqualityComparer<T>.Default.Equals(ptr, value0) && !EqualityComparer<T>.Default.Equals(ptr, value1) && !EqualityComparer<T>.Default.Equals(ptr, value2) && !EqualityComparer<T>.Default.Equals(ptr, value3))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0005DEF8 File Offset: 0x0005C0F8
		internal static int LastIndexOfAnyExcept<T>(ref T searchSpace, T value0, T value1, T value2, T value3, int length)
		{
			for (int i = length - 1; i >= 0; i--)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (!EqualityComparer<T>.Default.Equals(ptr, value0) && !EqualityComparer<T>.Default.Equals(ptr, value1) && !EqualityComparer<T>.Default.Equals(ptr, value2) && !EqualityComparer<T>.Default.Equals(ptr, value3))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0005DF6C File Offset: 0x0005C16C
		public unsafe static bool SequenceEqual<T>(ref T first, ref T second, int length) where T : IEquatable<T>
		{
			if (!Unsafe.AreSame<T>(ref first, ref second))
			{
				IntPtr intPtr = (IntPtr)0;
				while (length >= 8)
				{
					length -= 8;
					T t = *Unsafe.Add<T>(ref first, intPtr);
					T t2 = *Unsafe.Add<T>(ref second, intPtr);
					if ((t != null) ? t.Equals(t2) : (t2 == null))
					{
						t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)1);
						t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)1);
						if ((t != null) ? t.Equals(t2) : (t2 == null))
						{
							t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)2);
							t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)2);
							if ((t != null) ? t.Equals(t2) : (t2 == null))
							{
								t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)3);
								t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)3);
								if ((t != null) ? t.Equals(t2) : (t2 == null))
								{
									t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)4);
									t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)4);
									if ((t != null) ? t.Equals(t2) : (t2 == null))
									{
										t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)5);
										t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)5);
										if ((t != null) ? t.Equals(t2) : (t2 == null))
										{
											t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)6);
											t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)6);
											if ((t != null) ? t.Equals(t2) : (t2 == null))
											{
												t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)7);
												t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)7);
												if ((t != null) ? t.Equals(t2) : (t2 == null))
												{
													intPtr += (IntPtr)8;
													continue;
												}
											}
										}
									}
								}
							}
						}
					}
					return false;
				}
				if (length >= 4)
				{
					length -= 4;
					T t = *Unsafe.Add<T>(ref first, intPtr);
					T t2 = *Unsafe.Add<T>(ref second, intPtr);
					if (!((t != null) ? t.Equals(t2) : (t2 == null)))
					{
						return false;
					}
					t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)1);
					t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)1);
					if (!((t != null) ? t.Equals(t2) : (t2 == null)))
					{
						return false;
					}
					t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)2);
					t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)2);
					if (!((t != null) ? t.Equals(t2) : (t2 == null)))
					{
						return false;
					}
					t = *Unsafe.Add<T>(ref first, intPtr + (IntPtr)3);
					t2 = *Unsafe.Add<T>(ref second, intPtr + (IntPtr)3);
					if (!((t != null) ? t.Equals(t2) : (t2 == null)))
					{
						return false;
					}
					intPtr += (IntPtr)4;
				}
				while (length > 0)
				{
					T t = *Unsafe.Add<T>(ref first, intPtr);
					T t2 = *Unsafe.Add<T>(ref second, intPtr);
					if (!((t != null) ? t.Equals(t2) : (t2 == null)))
					{
						return false;
					}
					intPtr += (IntPtr)1;
					length--;
				}
			}
			return true;
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0005E338 File Offset: 0x0005C538
		public unsafe static int SequenceCompareTo<T>(ref T first, int firstLength, ref T second, int secondLength) where T : IComparable<T>
		{
			int num = firstLength;
			if (num > secondLength)
			{
				num = secondLength;
			}
			int i = 0;
			while (i < num)
			{
				T t = *Unsafe.Add<T>(ref second, i);
				T ptr2;
				ref T ptr = ptr2 = Unsafe.Add<T>(ref first, i);
				T t2 = default(T);
				if (t2 != null)
				{
					goto IL_52;
				}
				t2 = ptr;
				ptr2 = ref t2;
				if (t2 != null)
				{
					goto IL_52;
				}
				int num2 = (t == null) ? 0 : -1;
				IL_5E:
				int num3 = num2;
				if (num3 != 0)
				{
					return num3;
				}
				i++;
				continue;
				IL_52:
				num2 = ptr2.CompareTo(t);
				goto IL_5E;
			}
			return firstLength.CompareTo(secondLength);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0005E3BC File Offset: 0x0005C5BC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool ContainsValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
		{
			if (PackedSpanHelpers.PackedIndexOfIsSupported && typeof(T) == typeof(short) && PackedSpanHelpers.CanUsePackedIndexOf<T>(value))
			{
				return PackedSpanHelpers.Contains(Unsafe.As<T, short>(ref searchSpace), Unsafe.BitCast<T, short>(value), length);
			}
			return SpanHelpers.NonPackedContainsValueType<T>(ref searchSpace, value, length);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0005E410 File Offset: 0x0005C610
		internal unsafe static bool NonPackedContainsValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
		{
			if (Vector128.IsHardwareAccelerated && length >= Vector128<T>.Count)
			{
				if (false)
				{
				}
				if (false)
				{
				}
				Vector128<T> left = Vector128.Create<T>(value);
				ref T ptr = ref searchSpace;
				ref T ptr2 = ref Unsafe.Add<T>(ref searchSpace, (UIntPtr)(length - Vector128<T>.Count));
				while (Vector128.Equals<T>(left, Vector128.LoadUnsafe<T>(ref ptr)) == Vector128<T>.Zero)
				{
					ptr = Unsafe.Add<T>(ref ptr, Vector128<T>.Count);
					if (Unsafe.IsAddressGreaterThan<T>(ref ptr, ref ptr2))
					{
						if ((ulong)length % (ulong)((long)Vector128<T>.Count) != 0UL && Vector128.Equals<T>(left, Vector128.LoadUnsafe<T>(ref ptr2)) != Vector128<T>.Zero)
						{
							return true;
						}
						return false;
					}
				}
				return true;
			}
			UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
			while (length >= 8)
			{
				length -= 8;
				if (*Unsafe.Add<T>(ref searchSpace, uintPtr) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)1)) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)2)) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)3)) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)4)) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)5)) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)6)) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)7)) == value)
				{
					return true;
				}
				uintPtr += (UIntPtr)((IntPtr)8);
			}
			if (length >= 4)
			{
				length -= 4;
				if (*Unsafe.Add<T>(ref searchSpace, uintPtr) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)1)) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)2)) == value || *Unsafe.Add<T>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)3)) == value)
				{
					return true;
				}
				uintPtr += (UIntPtr)((IntPtr)4);
			}
			while (length > 0)
			{
				length--;
				if (*Unsafe.Add<T>(ref searchSpace, uintPtr) == value)
				{
					return true;
				}
				uintPtr += (UIntPtr)((IntPtr)1);
			}
			return false;
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0005E670 File Offset: 0x0005C870
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfChar(ref char searchSpace, char value, int length)
		{
			return SpanHelpers.IndexOfValueType<short>(Unsafe.As<char, short>(ref searchSpace), (short)value, length);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0005E680 File Offset: 0x0005C880
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int NonPackedIndexOfChar(ref char searchSpace, char value, int length)
		{
			return SpanHelpers.NonPackedIndexOfValueType<short, SpanHelpers.DontNegate<short>>(Unsafe.As<char, short>(ref searchSpace), (short)value, length);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0005E690 File Offset: 0x0005C890
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value, length);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0005E69A File Offset: 0x0005C89A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyExceptValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value, length);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0005E6A4 File Offset: 0x0005C8A4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int IndexOfValueType<TValue, TNegator>(ref TValue searchSpace, TValue value, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!PackedSpanHelpers.PackedIndexOfIsSupported || !(typeof(TValue) == typeof(short)) || !PackedSpanHelpers.CanUsePackedIndexOf<TValue>(value))
			{
				return SpanHelpers.NonPackedIndexOfValueType<TValue, TNegator>(ref searchSpace, value, length);
			}
			if (!(typeof(TNegator) == typeof(SpanHelpers.DontNegate<short>)))
			{
				return PackedSpanHelpers.IndexOfAnyExcept(Unsafe.As<TValue, char>(ref searchSpace), Unsafe.BitCast<TValue, char>(value), length);
			}
			return PackedSpanHelpers.IndexOf(Unsafe.As<TValue, char>(ref searchSpace), Unsafe.BitCast<TValue, char>(value), length);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0005E724 File Offset: 0x0005C924
		internal unsafe static int NonPackedIndexOfValueType<TValue, TNegator>(ref TValue searchSpace, TValue value, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				while (length >= 8)
				{
					length -= 8;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr) == value))
					{
						IL_298:
						return (int)uintPtr;
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)1)) == value))
					{
						IL_292:
						return (int)(uintPtr + (UIntPtr)((IntPtr)1));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)2)) == value))
					{
						IL_28C:
						return (int)(uintPtr + (UIntPtr)((IntPtr)2));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)3)) == value))
					{
						IL_286:
						return (int)(uintPtr + (UIntPtr)((IntPtr)3));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)4)) == value))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)4));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)5)) == value))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)5));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)6)) == value))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)6));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)7)) == value))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)7));
					}
					uintPtr += (UIntPtr)((IntPtr)8);
				}
				if (length >= 4)
				{
					length -= 4;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr) == value))
					{
						goto IL_298;
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)1)) == value))
					{
						goto IL_292;
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)2)) == value))
					{
						goto IL_28C;
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr + (UIntPtr)((IntPtr)3)) == value))
					{
						goto IL_286;
					}
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr) == value))
					{
						goto IL_298;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
				return -1;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			Vector128<TValue> left = Vector128.Create<TValue>(value);
			ref TValue ptr = ref searchSpace;
			ref TValue ptr2 = ref Unsafe.Add<TValue>(ref searchSpace, length - Vector128<TValue>.Count);
			Vector128<TValue> vector;
			for (;;)
			{
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left, Vector128.LoadUnsafe<TValue>(ref ptr)));
				if (!(vector == Vector128<TValue>.Zero))
				{
					break;
				}
				ptr = Unsafe.Add<TValue>(ref ptr, Vector128<TValue>.Count);
				if (Unsafe.IsAddressGreaterThan<TValue>(ref ptr, ref ptr2))
				{
					goto Block_19;
				}
			}
			return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr, vector);
			Block_19:
			if ((ulong)length % (ulong)((long)Vector128<TValue>.Count) != 0UL)
			{
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left, Vector128.LoadUnsafe<TValue>(ref ptr2)));
				if (vector != Vector128<TValue>.Zero)
				{
					return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr2, vector);
				}
			}
			return -1;
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0005EA81 File Offset: 0x0005CC81
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyChar(ref char searchSpace, char value0, char value1, int length)
		{
			return SpanHelpers.IndexOfAnyValueType<short>(Unsafe.As<char, short>(ref searchSpace), (short)value0, (short)value1, length);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0005EA93 File Offset: 0x0005CC93
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyValueType<T>(ref T searchSpace, T value0, T value1, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfAnyValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value0, value1, length);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0005EA9E File Offset: 0x0005CC9E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyExceptValueType<T>(ref T searchSpace, T value0, T value1, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfAnyValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value0, value1, length);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0005EAAC File Offset: 0x0005CCAC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int IndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!PackedSpanHelpers.PackedIndexOfIsSupported || !(typeof(TValue) == typeof(short)) || !PackedSpanHelpers.CanUsePackedIndexOf<TValue>(value0) || !PackedSpanHelpers.CanUsePackedIndexOf<TValue>(value1))
			{
				return SpanHelpers.NonPackedIndexOfAnyValueType<TValue, TNegator>(ref searchSpace, value0, value1, length);
			}
			char c = Unsafe.BitCast<TValue, char>(value0);
			char c2 = Unsafe.BitCast<TValue, char>(value1);
			if (RuntimeHelpers.IsKnownConstant<TValue>(value0) && RuntimeHelpers.IsKnownConstant<TValue>(value1) && (c ^ c2) == ' ')
			{
				char value2 = (char)Math.Max((ushort)c, (ushort)c2);
				if (!(typeof(TNegator) == typeof(SpanHelpers.DontNegate<short>)))
				{
					return PackedSpanHelpers.IndexOfAnyExceptIgnoreCase(Unsafe.As<TValue, char>(ref searchSpace), value2, length);
				}
				return PackedSpanHelpers.IndexOfAnyIgnoreCase(Unsafe.As<TValue, char>(ref searchSpace), value2, length);
			}
			else
			{
				if (!(typeof(TNegator) == typeof(SpanHelpers.DontNegate<short>)))
				{
					return PackedSpanHelpers.IndexOfAnyExcept(Unsafe.As<TValue, char>(ref searchSpace), c, c2, length);
				}
				return PackedSpanHelpers.IndexOfAny(Unsafe.As<TValue, char>(ref searchSpace), c, c2, length);
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0005EBA0 File Offset: 0x0005CDA0
		internal unsafe static int NonPackedIndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				if (typeof(TValue) == typeof(byte))
				{
					while (length >= 8)
					{
						length -= 8;
						ref TValue ptr = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
						TValue left = ptr;
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							goto IL_3A5;
						}
						left = *Unsafe.Add<TValue>(ref ptr, 1);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							goto IL_39F;
						}
						left = *Unsafe.Add<TValue>(ref ptr, 2);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							goto IL_399;
						}
						left = *Unsafe.Add<TValue>(ref ptr, 3);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							goto IL_393;
						}
						left = *Unsafe.Add<TValue>(ref ptr, 4);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							return (int)(uintPtr + (UIntPtr)((IntPtr)4));
						}
						left = *Unsafe.Add<TValue>(ref ptr, 5);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							return (int)(uintPtr + (UIntPtr)((IntPtr)5));
						}
						left = *Unsafe.Add<TValue>(ref ptr, 6);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							return (int)(uintPtr + (UIntPtr)((IntPtr)6));
						}
						left = *Unsafe.Add<TValue>(ref ptr, 7);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							return (int)(uintPtr + (UIntPtr)((IntPtr)7));
						}
						uintPtr += (UIntPtr)((IntPtr)8);
					}
				}
				while (length >= 4)
				{
					length -= 4;
					ref TValue ptr2 = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					TValue left = ptr2;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_3A5;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, 1);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_39F;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, 2);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_399;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, 3);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_393;
					}
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					TValue left = *Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_3A5;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
				return -1;
				IL_393:
				return (int)(uintPtr + (UIntPtr)((IntPtr)3));
				IL_399:
				return (int)(uintPtr + (UIntPtr)((IntPtr)2));
				IL_39F:
				return (int)(uintPtr + (UIntPtr)((IntPtr)1));
				IL_3A5:
				return (int)uintPtr;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			Vector128<TValue> left2 = Vector128.Create<TValue>(value0);
			Vector128<TValue> left3 = Vector128.Create<TValue>(value1);
			ref TValue ptr3 = ref searchSpace;
			ref TValue ptr4 = ref Unsafe.Add<TValue>(ref searchSpace, length - Vector128<TValue>.Count);
			Vector128<TValue> vector;
			for (;;)
			{
				Vector128<TValue> right = Vector128.LoadUnsafe<TValue>(ref ptr3);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left3, right));
				if (!(vector == Vector128<TValue>.Zero))
				{
					break;
				}
				ptr3 = Unsafe.Add<TValue>(ref ptr3, Vector128<TValue>.Count);
				if (Unsafe.IsAddressGreaterThan<TValue>(ref ptr3, ref ptr4))
				{
					goto Block_33;
				}
			}
			return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr3, vector);
			Block_33:
			if ((ulong)length % (ulong)((long)Vector128<TValue>.Count) != 0UL)
			{
				Vector128<TValue> right = Vector128.LoadUnsafe<TValue>(ref ptr4);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left3, right));
				if (vector != Vector128<TValue>.Zero)
				{
					return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr4, vector);
				}
			}
			return -1;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0005F036 File Offset: 0x0005D236
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyValueType<T>(ref T searchSpace, T value0, T value1, T value2, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfAnyValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value0, value1, value2, length);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0005F043 File Offset: 0x0005D243
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyExceptValueType<T>(ref T searchSpace, T value0, T value1, T value2, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfAnyValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value0, value1, value2, length);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0005F050 File Offset: 0x0005D250
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int IndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, TValue value2, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!PackedSpanHelpers.PackedIndexOfIsSupported || !(typeof(TValue) == typeof(short)) || !PackedSpanHelpers.CanUsePackedIndexOf<TValue>(value0) || !PackedSpanHelpers.CanUsePackedIndexOf<TValue>(value1) || !PackedSpanHelpers.CanUsePackedIndexOf<TValue>(value2))
			{
				return SpanHelpers.NonPackedIndexOfAnyValueType<TValue, TNegator>(ref searchSpace, value0, value1, value2, length);
			}
			if (!(typeof(TNegator) == typeof(SpanHelpers.DontNegate<short>)))
			{
				return PackedSpanHelpers.IndexOfAnyExcept(Unsafe.As<TValue, char>(ref searchSpace), Unsafe.BitCast<TValue, char>(value0), Unsafe.BitCast<TValue, char>(value1), Unsafe.BitCast<TValue, char>(value2), length);
			}
			return PackedSpanHelpers.IndexOfAny(Unsafe.As<TValue, char>(ref searchSpace), Unsafe.BitCast<TValue, char>(value0), Unsafe.BitCast<TValue, char>(value1), Unsafe.BitCast<TValue, char>(value2), length);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0005F100 File Offset: 0x0005D300
		internal unsafe static int NonPackedIndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, TValue value2, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				if (typeof(TValue) == typeof(byte))
				{
					while (length >= 8)
					{
						length -= 8;
						ref TValue ptr = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
						TValue left = ptr;
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							goto IL_472;
						}
						left = *Unsafe.Add<TValue>(ref ptr, 1);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							goto IL_46C;
						}
						left = *Unsafe.Add<TValue>(ref ptr, 2);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							goto IL_466;
						}
						left = *Unsafe.Add<TValue>(ref ptr, 3);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							goto IL_460;
						}
						left = *Unsafe.Add<TValue>(ref ptr, 4);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							return (int)(uintPtr + (UIntPtr)((IntPtr)4));
						}
						left = *Unsafe.Add<TValue>(ref ptr, 5);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							return (int)(uintPtr + (UIntPtr)((IntPtr)5));
						}
						left = *Unsafe.Add<TValue>(ref ptr, 6);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							return (int)(uintPtr + (UIntPtr)((IntPtr)6));
						}
						left = *Unsafe.Add<TValue>(ref ptr, 7);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							return (int)(uintPtr + (UIntPtr)((IntPtr)7));
						}
						uintPtr += (UIntPtr)((IntPtr)8);
					}
				}
				while (length >= 4)
				{
					length -= 4;
					ref TValue ptr2 = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					TValue left = ptr2;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_472;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, 1);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_46C;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, 2);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_466;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, 3);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_460;
					}
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					TValue left = *Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_472;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
				return -1;
				IL_460:
				return (int)(uintPtr + (UIntPtr)((IntPtr)3));
				IL_466:
				return (int)(uintPtr + (UIntPtr)((IntPtr)2));
				IL_46C:
				return (int)(uintPtr + (UIntPtr)((IntPtr)1));
				IL_472:
				return (int)uintPtr;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			Vector128<TValue> left2 = Vector128.Create<TValue>(value0);
			Vector128<TValue> left3 = Vector128.Create<TValue>(value1);
			Vector128<TValue> left4 = Vector128.Create<TValue>(value2);
			ref TValue ptr3 = ref searchSpace;
			ref TValue ptr4 = ref Unsafe.Add<TValue>(ref searchSpace, length - Vector128<TValue>.Count);
			Vector128<TValue> vector;
			for (;;)
			{
				Vector128<TValue> right = Vector128.LoadUnsafe<TValue>(ref ptr3);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left3, right) | Vector128.Equals<TValue>(left4, right));
				if (!(vector == Vector128<TValue>.Zero))
				{
					break;
				}
				ptr3 = Unsafe.Add<TValue>(ref ptr3, Vector128<TValue>.Count);
				if (Unsafe.IsAddressGreaterThan<TValue>(ref ptr3, ref ptr4))
				{
					goto Block_46;
				}
			}
			return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr3, vector);
			Block_46:
			if ((ulong)length % (ulong)((long)Vector128<TValue>.Count) != 0UL)
			{
				Vector128<TValue> right = Vector128.LoadUnsafe<TValue>(ref ptr4);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left3, right) | Vector128.Equals<TValue>(left4, right));
				if (vector != Vector128<TValue>.Zero)
				{
					return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr4, vector);
				}
			}
			return -1;
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0005F689 File Offset: 0x0005D889
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyValueType<T>(ref T searchSpace, T value0, T value1, T value2, T value3, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfAnyValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value0, value1, value2, value3, length);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0005F698 File Offset: 0x0005D898
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyExceptValueType<T>(ref T searchSpace, T value0, T value1, T value2, T value3, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfAnyValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value0, value1, value2, value3, length);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0005F6A8 File Offset: 0x0005D8A8
		private unsafe static int IndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, TValue value2, TValue value3, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				while (length >= 4)
				{
					length -= 4;
					ref TValue ptr = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					TValue left = ptr;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						IL_217:
						return (int)uintPtr;
					}
					left = *Unsafe.Add<TValue>(ref ptr, 1);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)1));
					}
					left = *Unsafe.Add<TValue>(ref ptr, 2);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)2));
					}
					left = *Unsafe.Add<TValue>(ref ptr, 3);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)3));
					}
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					TValue left = *Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						goto IL_217;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
				return -1;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			Vector128<TValue> left2 = Vector128.Create<TValue>(value0);
			Vector128<TValue> left3 = Vector128.Create<TValue>(value1);
			Vector128<TValue> left4 = Vector128.Create<TValue>(value2);
			Vector128<TValue> left5 = Vector128.Create<TValue>(value3);
			ref TValue ptr2 = ref searchSpace;
			ref TValue ptr3 = ref Unsafe.Add<TValue>(ref searchSpace, length - Vector128<TValue>.Count);
			Vector128<TValue> vector;
			for (;;)
			{
				Vector128<TValue> right = Vector128.LoadUnsafe<TValue>(ref ptr2);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left3, right) | Vector128.Equals<TValue>(left4, right) | Vector128.Equals<TValue>(left5, right));
				if (!(vector == Vector128<TValue>.Zero))
				{
					break;
				}
				ptr2 = Unsafe.Add<TValue>(ref ptr2, Vector128<TValue>.Count);
				if (Unsafe.IsAddressGreaterThan<TValue>(ref ptr2, ref ptr3))
				{
					goto Block_25;
				}
			}
			return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr2, vector);
			Block_25:
			if ((ulong)length % (ulong)((long)Vector128<TValue>.Count) != 0UL)
			{
				Vector128<TValue> right = Vector128.LoadUnsafe<TValue>(ref ptr3);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left3, right) | Vector128.Equals<TValue>(left4, right) | Vector128.Equals<TValue>(left5, right));
				if (vector != Vector128<TValue>.Zero)
				{
					return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr3, vector);
				}
			}
			return -1;
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0005F9FB File Offset: 0x0005DBFB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyValueType<T>(ref T searchSpace, T value0, T value1, T value2, T value3, T value4, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfAnyValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value0, value1, value2, value3, value4, length);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0005FA0C File Offset: 0x0005DC0C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int IndexOfAnyExceptValueType<T>(ref T searchSpace, T value0, T value1, T value2, T value3, T value4, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.IndexOfAnyValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value0, value1, value2, value3, value4, length);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0005FA20 File Offset: 0x0005DC20
		private unsafe static int IndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, TValue value2, TValue value3, TValue value4, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				while (length >= 4)
				{
					length -= 4;
					ref TValue ptr = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					TValue left = ptr;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						IL_26A:
						return (int)uintPtr;
					}
					left = *Unsafe.Add<TValue>(ref ptr, 1);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)1));
					}
					left = *Unsafe.Add<TValue>(ref ptr, 2);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)2));
					}
					left = *Unsafe.Add<TValue>(ref ptr, 3);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						return (int)(uintPtr + (UIntPtr)((IntPtr)3));
					}
					uintPtr += (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					TValue left = *Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						goto IL_26A;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
				return -1;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			Vector128<TValue> left2 = Vector128.Create<TValue>(value0);
			Vector128<TValue> left3 = Vector128.Create<TValue>(value1);
			Vector128<TValue> left4 = Vector128.Create<TValue>(value2);
			Vector128<TValue> left5 = Vector128.Create<TValue>(value3);
			Vector128<TValue> left6 = Vector128.Create<TValue>(value4);
			ref TValue ptr2 = ref searchSpace;
			ref TValue ptr3 = ref Unsafe.Add<TValue>(ref searchSpace, (UIntPtr)(length - Vector128<TValue>.Count));
			Vector128<TValue> vector;
			for (;;)
			{
				Vector128<TValue> right = Vector128.LoadUnsafe<TValue>(ref ptr2);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left3, right) | Vector128.Equals<TValue>(left4, right) | Vector128.Equals<TValue>(left5, right) | Vector128.Equals<TValue>(left6, right));
				if (!(vector == Vector128<TValue>.Zero))
				{
					break;
				}
				ptr2 = Unsafe.Add<TValue>(ref ptr2, Vector128<TValue>.Count);
				if (Unsafe.IsAddressGreaterThan<TValue>(ref ptr2, ref ptr3))
				{
					goto Block_30;
				}
			}
			return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr2, vector);
			Block_30:
			if ((ulong)length % (ulong)((long)Vector128<TValue>.Count) != 0UL)
			{
				Vector128<TValue> right = Vector128.LoadUnsafe<TValue>(ref ptr3);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left3, right) | Vector128.Equals<TValue>(left4, right) | Vector128.Equals<TValue>(left5, right) | Vector128.Equals<TValue>(left6, right));
				if (vector != Vector128<TValue>.Zero)
				{
					return SpanHelpers.ComputeFirstIndex<TValue>(ref searchSpace, ref ptr3, vector);
				}
			}
			return -1;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0005FDEF File Offset: 0x0005DFEF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value, length);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0005FDF9 File Offset: 0x0005DFF9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyExceptValueType<T>(ref T searchSpace, T value, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value, length);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0005FE04 File Offset: 0x0005E004
		private unsafe static int LastIndexOfValueType<TValue, TNegator>(ref TValue searchSpace, TValue value, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)length - (IntPtr)1);
				while (length >= 8)
				{
					length -= 8;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr) == value))
					{
						IL_29B:
						return (int)uintPtr;
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)1)) == value))
					{
						IL_295:
						return (int)(uintPtr - (UIntPtr)((IntPtr)1));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)2)) == value))
					{
						IL_28F:
						return (int)(uintPtr - (UIntPtr)((IntPtr)2));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)3)) == value))
					{
						IL_289:
						return (int)(uintPtr - (UIntPtr)((IntPtr)3));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)4)) == value))
					{
						return (int)(uintPtr - (UIntPtr)((IntPtr)4));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)5)) == value))
					{
						return (int)(uintPtr - (UIntPtr)((IntPtr)5));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)6)) == value))
					{
						return (int)(uintPtr - (UIntPtr)((IntPtr)6));
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)7)) == value))
					{
						return (int)(uintPtr - (UIntPtr)((IntPtr)7));
					}
					uintPtr -= (UIntPtr)((IntPtr)8);
				}
				if (length >= 4)
				{
					length -= 4;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr) == value))
					{
						goto IL_29B;
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)1)) == value))
					{
						goto IL_295;
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)2)) == value))
					{
						goto IL_28F;
					}
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr - (UIntPtr)((IntPtr)3)) == value))
					{
						goto IL_289;
					}
					uintPtr -= (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(*Unsafe.Add<TValue>(ref searchSpace, uintPtr) == value))
					{
						goto IL_29B;
					}
					uintPtr -= (UIntPtr)((IntPtr)1);
				}
				return -1;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			return SpanHelpers.<LastIndexOfValueType>g__SimdImpl|93_0<TValue, TNegator, Vector128<TValue>>(ref searchSpace, value, length);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000600BD File Offset: 0x0005E2BD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyValueType<T>(ref T searchSpace, T value0, T value1, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfAnyValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value0, value1, length);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000600C8 File Offset: 0x0005E2C8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyExceptValueType<T>(ref T searchSpace, T value0, T value1, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfAnyValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value0, value1, length);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x000600D4 File Offset: 0x0005E2D4
		private unsafe static int LastIndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)length - (IntPtr)1);
				if (typeof(TValue) == typeof(byte))
				{
					while (length >= 8)
					{
						length -= 8;
						ref TValue ptr = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
						TValue left = ptr;
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							goto IL_3B0;
						}
						left = *Unsafe.Add<TValue>(ref ptr, -1);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							goto IL_3AA;
						}
						left = *Unsafe.Add<TValue>(ref ptr, -2);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							goto IL_3A4;
						}
						left = *Unsafe.Add<TValue>(ref ptr, -3);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							goto IL_39E;
						}
						left = *Unsafe.Add<TValue>(ref ptr, -4);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							return (int)(uintPtr - (UIntPtr)((IntPtr)4));
						}
						left = *Unsafe.Add<TValue>(ref ptr, -5);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							return (int)(uintPtr - (UIntPtr)((IntPtr)5));
						}
						left = *Unsafe.Add<TValue>(ref ptr, -6);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							return (int)(uintPtr - (UIntPtr)((IntPtr)6));
						}
						left = *Unsafe.Add<TValue>(ref ptr, -7);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
						{
							return (int)(uintPtr - (UIntPtr)((IntPtr)7));
						}
						uintPtr -= (UIntPtr)((IntPtr)8);
					}
				}
				while (length >= 4)
				{
					length -= 4;
					ref TValue ptr2 = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					TValue left = ptr2;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_3B0;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, -1);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_3AA;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, -2);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_3A4;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, -3);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_39E;
					}
					uintPtr -= (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					TValue left = *Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1))
					{
						goto IL_3B0;
					}
					uintPtr -= (UIntPtr)((IntPtr)1);
				}
				return -1;
				IL_39E:
				return (int)(uintPtr - (UIntPtr)((IntPtr)3));
				IL_3A4:
				return (int)(uintPtr - (UIntPtr)((IntPtr)2));
				IL_3AA:
				return (int)(uintPtr - (UIntPtr)((IntPtr)1));
				IL_3B0:
				return (int)uintPtr;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			Vector128<TValue> right = Vector128.Create<TValue>(value0);
			Vector128<TValue> right2 = Vector128.Create<TValue>(value1);
			Vector128<TValue> left2;
			Vector128<TValue> vector;
			for (IntPtr intPtr = (IntPtr)(length - Vector128<TValue>.Count); intPtr > (IntPtr)0; intPtr -= (IntPtr)Vector128<TValue>.Count)
			{
				left2 = Vector128.LoadUnsafe<TValue>(ref searchSpace, (UIntPtr)intPtr);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left2, right2));
				if (!(vector == Vector128<TValue>.Zero))
				{
					return SpanHelpers.ComputeLastIndex<TValue>(intPtr, vector);
				}
			}
			left2 = Vector128.LoadUnsafe<TValue>(ref searchSpace);
			vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left2, right2));
			if (vector != Vector128<TValue>.Zero)
			{
				return SpanHelpers.ComputeLastIndex<TValue>((IntPtr)0, vector);
			}
			return -1;
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0006055A File Offset: 0x0005E75A
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyValueType<T>(ref T searchSpace, T value0, T value1, T value2, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfAnyValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value0, value1, value2, length);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00060567 File Offset: 0x0005E767
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyExceptValueType<T>(ref T searchSpace, T value0, T value1, T value2, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfAnyValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value0, value1, value2, length);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00060574 File Offset: 0x0005E774
		private unsafe static int LastIndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, TValue value2, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)length - (IntPtr)1);
				if (typeof(TValue) == typeof(byte))
				{
					while (length >= 8)
					{
						length -= 8;
						ref TValue ptr = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
						TValue left = ptr;
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							goto IL_47E;
						}
						left = *Unsafe.Add<TValue>(ref ptr, -1);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							goto IL_478;
						}
						left = *Unsafe.Add<TValue>(ref ptr, -2);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							goto IL_472;
						}
						left = *Unsafe.Add<TValue>(ref ptr, -3);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							goto IL_46C;
						}
						left = *Unsafe.Add<TValue>(ref ptr, -4);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							return (int)(uintPtr - (UIntPtr)((IntPtr)4));
						}
						left = *Unsafe.Add<TValue>(ref ptr, -5);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							return (int)(uintPtr - (UIntPtr)((IntPtr)5));
						}
						left = *Unsafe.Add<TValue>(ref ptr, -6);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							return (int)(uintPtr - (UIntPtr)((IntPtr)6));
						}
						left = *Unsafe.Add<TValue>(ref ptr, -7);
						if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
						{
							return (int)(uintPtr - (UIntPtr)((IntPtr)7));
						}
						uintPtr -= (UIntPtr)((IntPtr)8);
					}
				}
				while (length >= 4)
				{
					length -= 4;
					ref TValue ptr2 = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					TValue left = ptr2;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_47E;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, -1);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_478;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, -2);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_472;
					}
					left = *Unsafe.Add<TValue>(ref ptr2, -3);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_46C;
					}
					uintPtr -= (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					TValue left = *Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2))
					{
						goto IL_47E;
					}
					uintPtr -= (UIntPtr)((IntPtr)1);
				}
				return -1;
				IL_46C:
				return (int)(uintPtr - (UIntPtr)((IntPtr)3));
				IL_472:
				return (int)(uintPtr - (UIntPtr)((IntPtr)2));
				IL_478:
				return (int)(uintPtr - (UIntPtr)((IntPtr)1));
				IL_47E:
				return (int)uintPtr;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			Vector128<TValue> right = Vector128.Create<TValue>(value0);
			Vector128<TValue> right2 = Vector128.Create<TValue>(value1);
			Vector128<TValue> right3 = Vector128.Create<TValue>(value2);
			Vector128<TValue> left2;
			Vector128<TValue> vector;
			for (IntPtr intPtr = (IntPtr)(length - Vector128<TValue>.Count); intPtr > (IntPtr)0; intPtr -= (IntPtr)Vector128<TValue>.Count)
			{
				left2 = Vector128.LoadUnsafe<TValue>(ref searchSpace, (UIntPtr)intPtr);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left2, right2) | Vector128.Equals<TValue>(left2, right3));
				if (!(vector == Vector128<TValue>.Zero))
				{
					return SpanHelpers.ComputeLastIndex<TValue>(intPtr, vector);
				}
			}
			left2 = Vector128.LoadUnsafe<TValue>(ref searchSpace);
			vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left2, right2) | Vector128.Equals<TValue>(left2, right3));
			if (vector != Vector128<TValue>.Zero)
			{
				return SpanHelpers.ComputeLastIndex<TValue>((IntPtr)0, vector);
			}
			return -1;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00060AED File Offset: 0x0005ECED
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyValueType<T>(ref T searchSpace, T value0, T value1, T value2, T value3, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfAnyValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value0, value1, value2, value3, length);
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00060AFC File Offset: 0x0005ECFC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyExceptValueType<T>(ref T searchSpace, T value0, T value1, T value2, T value3, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfAnyValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value0, value1, value2, value3, length);
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00060B0C File Offset: 0x0005ED0C
		private unsafe static int LastIndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, TValue value2, TValue value3, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)length - (IntPtr)1);
				while (length >= 4)
				{
					length -= 4;
					ref TValue ptr = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					TValue left = ptr;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						IL_21D:
						return (int)uintPtr;
					}
					left = *Unsafe.Add<TValue>(ref ptr, -1);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						return (int)(uintPtr - (UIntPtr)((IntPtr)1));
					}
					left = *Unsafe.Add<TValue>(ref ptr, -2);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						return (int)(uintPtr - (UIntPtr)((IntPtr)2));
					}
					left = *Unsafe.Add<TValue>(ref ptr, -3);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						return (int)(uintPtr - (UIntPtr)((IntPtr)3));
					}
					uintPtr -= (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					TValue left = *Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3))
					{
						goto IL_21D;
					}
					uintPtr -= (UIntPtr)((IntPtr)1);
				}
				return -1;
			}
			if (false)
			{
			}
			if (false)
			{
			}
			Vector128<TValue> right = Vector128.Create<TValue>(value0);
			Vector128<TValue> right2 = Vector128.Create<TValue>(value1);
			Vector128<TValue> right3 = Vector128.Create<TValue>(value2);
			Vector128<TValue> right4 = Vector128.Create<TValue>(value3);
			Vector128<TValue> left2;
			Vector128<TValue> vector;
			for (IntPtr intPtr = (IntPtr)(length - Vector128<TValue>.Count); intPtr > (IntPtr)0; intPtr -= (IntPtr)Vector128<TValue>.Count)
			{
				left2 = Vector128.LoadUnsafe<TValue>(ref searchSpace, (UIntPtr)intPtr);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left2, right2) | Vector128.Equals<TValue>(left2, right3) | Vector128.Equals<TValue>(left2, right4));
				if (!(vector == Vector128<TValue>.Zero))
				{
					return SpanHelpers.ComputeLastIndex<TValue>(intPtr, vector);
				}
			}
			left2 = Vector128.LoadUnsafe<TValue>(ref searchSpace);
			vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left2, right2) | Vector128.Equals<TValue>(left2, right3) | Vector128.Equals<TValue>(left2, right4));
			if (vector != Vector128<TValue>.Zero)
			{
				return SpanHelpers.ComputeLastIndex<TValue>((IntPtr)0, vector);
			}
			return -1;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00060E4C File Offset: 0x0005F04C
		public unsafe static void Replace<T>(ref T src, ref T dst, T oldValue, T newValue, UIntPtr length) where T : IEquatable<T>
		{
			if (default(T) != null || oldValue != null)
			{
				for (UIntPtr uintPtr = (UIntPtr)((IntPtr)0); uintPtr < length; uintPtr++)
				{
					T t = *Unsafe.Add<T>(ref src, uintPtr);
					*Unsafe.Add<T>(ref dst, uintPtr) = (oldValue.Equals(t) ? newValue : t);
				}
				return;
			}
			for (UIntPtr uintPtr2 = (UIntPtr)((IntPtr)0); uintPtr2 < length; uintPtr2++)
			{
				T t2 = *Unsafe.Add<T>(ref src, uintPtr2);
				*Unsafe.Add<T>(ref dst, uintPtr2) = ((t2 == null) ? newValue : t2);
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00060EE4 File Offset: 0x0005F0E4
		public unsafe static void ReplaceValueType<T>(ref T src, ref T dst, T oldValue, T newValue, UIntPtr length) where T : struct
		{
			if (!Vector128.IsHardwareAccelerated || length < (UIntPtr)Vector128<T>.Count)
			{
				for (UIntPtr uintPtr = (UIntPtr)((IntPtr)0); uintPtr < length; uintPtr++)
				{
					T t = *Unsafe.Add<T>(ref src, uintPtr);
					*Unsafe.Add<T>(ref dst, uintPtr) = (EqualityComparer<T>.Default.Equals(t, oldValue) ? newValue : t);
				}
				return;
			}
			UIntPtr uintPtr2 = (UIntPtr)((IntPtr)0);
			if (false)
			{
			}
			UIntPtr uintPtr3 = length - (UIntPtr)Vector128<T>.Count;
			Vector128<T> left = Vector128.Create<T>(oldValue);
			Vector128<T> left2 = Vector128.Create<T>(newValue);
			Vector128<T> right;
			do
			{
				right = Vector128.LoadUnsafe<T>(ref src, uintPtr2);
				Vector128.ConditionalSelect<T>(Vector128.Equals<T>(left, right), left2, right).StoreUnsafe(ref dst, uintPtr2);
				uintPtr2 += (UIntPtr)Vector128<T>.Count;
			}
			while (uintPtr2 < uintPtr3);
			right = Vector128.LoadUnsafe<T>(ref src, uintPtr3);
			Vector128.ConditionalSelect<T>(Vector128.Equals<T>(left, right), left2, right).StoreUnsafe(ref dst, uintPtr3);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x00060FAD File Offset: 0x0005F1AD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyValueType<T>(ref T searchSpace, T value0, T value1, T value2, T value3, T value4, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfAnyValueType<T, SpanHelpers.DontNegate<T>>(ref searchSpace, value0, value1, value2, value3, value4, length);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00060FBE File Offset: 0x0005F1BE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static int LastIndexOfAnyExceptValueType<T>(ref T searchSpace, T value0, T value1, T value2, T value3, T value4, int length) where T : struct, INumber<T>
		{
			return SpanHelpers.LastIndexOfAnyValueType<T, SpanHelpers.Negate<T>>(ref searchSpace, value0, value1, value2, value3, value4, length);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00060FD0 File Offset: 0x0005F1D0
		private unsafe static int LastIndexOfAnyValueType<TValue, TNegator>(ref TValue searchSpace, TValue value0, TValue value1, TValue value2, TValue value3, TValue value4, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<TValue>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)length - (IntPtr)1);
				while (length >= 4)
				{
					length -= 4;
					ref TValue ptr = ref Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					TValue left = ptr;
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						return (int)uintPtr;
					}
					left = *Unsafe.Add<TValue>(ref ptr, -1);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						return (int)uintPtr - 1;
					}
					left = *Unsafe.Add<TValue>(ref ptr, -2);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						return (int)uintPtr - 2;
					}
					left = *Unsafe.Add<TValue>(ref ptr, -3);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						return (int)uintPtr - 3;
					}
					uintPtr -= (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					TValue left = *Unsafe.Add<TValue>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<TValue>.NegateIfNeeded(left == value0 || left == value1 || left == value2 || left == value3 || left == value4))
					{
						return (int)uintPtr;
					}
					uintPtr -= (UIntPtr)((IntPtr)1);
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
				Vector128<TValue> right = Vector128.Create<TValue>(value0);
				Vector128<TValue> right2 = Vector128.Create<TValue>(value1);
				Vector128<TValue> right3 = Vector128.Create<TValue>(value2);
				Vector128<TValue> right4 = Vector128.Create<TValue>(value3);
				Vector128<TValue> right5 = Vector128.Create<TValue>(value4);
				Vector128<TValue> left2;
				Vector128<TValue> vector;
				for (IntPtr intPtr = (IntPtr)(length - Vector128<TValue>.Count); intPtr > (IntPtr)0; intPtr -= (IntPtr)Vector128<TValue>.Count)
				{
					left2 = Vector128.LoadUnsafe<TValue>(ref searchSpace, (UIntPtr)intPtr);
					vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left2, right2) | Vector128.Equals<TValue>(left2, right3) | Vector128.Equals<TValue>(left2, right4) | Vector128.Equals<TValue>(left2, right5));
					if (!(vector == Vector128<TValue>.Zero))
					{
						return SpanHelpers.ComputeLastIndex<TValue>(intPtr, vector);
					}
				}
				left2 = Vector128.LoadUnsafe<TValue>(ref searchSpace);
				vector = SpanHelpers.INegator<TValue>.NegateIfNeeded(Vector128.Equals<TValue>(left2, right) | Vector128.Equals<TValue>(left2, right2) | Vector128.Equals<TValue>(left2, right3) | Vector128.Equals<TValue>(left2, right4) | Vector128.Equals<TValue>(left2, right5));
				if (vector != Vector128<TValue>.Zero)
				{
					return SpanHelpers.ComputeLastIndex<TValue>((IntPtr)0, vector);
				}
			}
			return -1;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0006137F File Offset: 0x0005F57F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ComputeFirstIndex<T>(ref T searchSpace, ref T current, Vector128<T> equals) where T : struct
		{
			return BitOperations.TrailingZeroCount(equals.ExtractMostSignificantBits<T>()) + (int)(Unsafe.ByteOffset<T>(ref searchSpace, ref current) / (IntPtr)sizeof(T));
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000613A0 File Offset: 0x0005F5A0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ComputeLastIndex<T>(IntPtr offset, Vector128<T> equals) where T : struct
		{
			uint value = equals.ExtractMostSignificantBits<T>();
			int num = 31 - BitOperations.LeadingZeroCount(value);
			return (int)offset + num;
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000613C4 File Offset: 0x0005F5C4
		internal static int IndexOfAnyInRange<T>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : IComparable<T>
		{
			for (int i = 0; i < length; i++)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (lowInclusive.CompareTo(ptr) <= 0 && highInclusive.CompareTo(ptr) >= 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00061414 File Offset: 0x0005F614
		internal static int IndexOfAnyExceptInRange<T>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : IComparable<T>
		{
			for (int i = 0; i < length; i++)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (lowInclusive.CompareTo(ptr) > 0 || highInclusive.CompareTo(ptr) < 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00061464 File Offset: 0x0005F664
		internal static int IndexOfAnyInRangeUnsignedNumber<T>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : struct, IUnsignedNumber<T>, IComparisonOperators<T, T, bool>
		{
			return SpanHelpers.IndexOfAnyInRangeUnsignedNumber<T, SpanHelpers.DontNegate<T>>(ref searchSpace, lowInclusive, highInclusive, length);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0006146F File Offset: 0x0005F66F
		internal static int IndexOfAnyExceptInRangeUnsignedNumber<T>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : struct, IUnsignedNumber<T>, IComparisonOperators<T, T, bool>
		{
			return SpanHelpers.IndexOfAnyInRangeUnsignedNumber<T, SpanHelpers.Negate<T>>(ref searchSpace, lowInclusive, highInclusive, length);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x0006147C File Offset: 0x0005F67C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int IndexOfAnyInRangeUnsignedNumber<T, TNegator>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : struct, IUnsignedNumber<T>, IComparisonOperators<T, T, bool> where TNegator : struct, SpanHelpers.INegator<T>
		{
			if (!PackedSpanHelpers.PackedIndexOfIsSupported || !(typeof(T) == typeof(ushort)) || !PackedSpanHelpers.CanUsePackedIndexOf<T>(lowInclusive) || !PackedSpanHelpers.CanUsePackedIndexOf<T>(highInclusive) || !(highInclusive >= lowInclusive))
			{
				return SpanHelpers.NonPackedIndexOfAnyInRangeUnsignedNumber<T, TNegator>(ref searchSpace, lowInclusive, highInclusive, length);
			}
			ref char searchSpace2 = ref Unsafe.As<T, char>(ref searchSpace);
			char c = Unsafe.BitCast<T, char>(lowInclusive);
			char rangeInclusive = Unsafe.BitCast<T, char>(highInclusive) - c;
			if (!(typeof(TNegator) == typeof(SpanHelpers.DontNegate<ushort>)))
			{
				return PackedSpanHelpers.IndexOfAnyExceptInRange(ref searchSpace2, c, rangeInclusive, length);
			}
			return PackedSpanHelpers.IndexOfAnyInRange(ref searchSpace2, c, rangeInclusive, length);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00061520 File Offset: 0x0005F720
		internal unsafe static int NonPackedIndexOfAnyInRangeUnsignedNumber<T, TNegator>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : struct, IUnsignedNumber<T>, IComparisonOperators<T, T, bool> where TNegator : struct, SpanHelpers.INegator<T>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<T>.Count)
			{
				T right = highInclusive - lowInclusive;
				for (int i = 0; i < length; i++)
				{
					if (SpanHelpers.INegator<T>.NegateIfNeeded(*Unsafe.Add<T>(ref searchSpace, i) - lowInclusive <= right))
					{
						return i;
					}
				}
			}
			else
			{
				if (false)
				{
				}
				Vector128<T> right2 = Vector128.Create<T>(lowInclusive);
				Vector128<T> right3 = Vector128.Create<T>(highInclusive - lowInclusive);
				ref T ptr = ref searchSpace;
				ref T ptr2 = ref Unsafe.Add<T>(ref searchSpace, (UIntPtr)(length - Vector128<T>.Count));
				Vector128<T> vector;
				for (;;)
				{
					vector = SpanHelpers.INegator<T>.NegateIfNeeded(Vector128.LessThanOrEqual<T>(Vector128.LoadUnsafe<T>(ref ptr) - right2, right3));
					if (vector != Vector128<T>.Zero)
					{
						break;
					}
					ptr = Unsafe.Add<T>(ref ptr, Vector128<T>.Count);
					if (!Unsafe.IsAddressLessThan<T>(ref ptr, ref ptr2))
					{
						goto Block_5;
					}
				}
				return SpanHelpers.ComputeFirstIndex<T>(ref searchSpace, ref ptr, vector);
				Block_5:
				vector = SpanHelpers.INegator<T>.NegateIfNeeded(Vector128.LessThanOrEqual<T>(Vector128.LoadUnsafe<T>(ref ptr2) - right2, right3));
				if (vector != Vector128<T>.Zero)
				{
					return SpanHelpers.ComputeFirstIndex<T>(ref searchSpace, ref ptr2, vector);
				}
			}
			return -1;
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00061650 File Offset: 0x0005F850
		internal static int LastIndexOfAnyInRange<T>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : IComparable<T>
		{
			for (int i = length - 1; i >= 0; i--)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (lowInclusive.CompareTo(ptr) <= 0 && highInclusive.CompareTo(ptr) >= 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x000616A4 File Offset: 0x0005F8A4
		internal static int LastIndexOfAnyExceptInRange<T>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : IComparable<T>
		{
			for (int i = length - 1; i >= 0; i--)
			{
				ref T ptr = ref Unsafe.Add<T>(ref searchSpace, i);
				if (lowInclusive.CompareTo(ptr) > 0 || highInclusive.CompareTo(ptr) < 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000616F6 File Offset: 0x0005F8F6
		internal static int LastIndexOfAnyInRangeUnsignedNumber<T>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : struct, IUnsignedNumber<T>, IComparisonOperators<T, T, bool>
		{
			return SpanHelpers.LastIndexOfAnyInRangeUnsignedNumber<T, SpanHelpers.DontNegate<T>>(ref searchSpace, lowInclusive, highInclusive, length);
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00061701 File Offset: 0x0005F901
		internal static int LastIndexOfAnyExceptInRangeUnsignedNumber<T>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : struct, IUnsignedNumber<T>, IComparisonOperators<T, T, bool>
		{
			return SpanHelpers.LastIndexOfAnyInRangeUnsignedNumber<T, SpanHelpers.Negate<T>>(ref searchSpace, lowInclusive, highInclusive, length);
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x0006170C File Offset: 0x0005F90C
		private unsafe static int LastIndexOfAnyInRangeUnsignedNumber<T, TNegator>(ref T searchSpace, T lowInclusive, T highInclusive, int length) where T : struct, IUnsignedNumber<T>, IComparisonOperators<T, T, bool> where TNegator : struct, SpanHelpers.INegator<T>
		{
			if (!Vector128.IsHardwareAccelerated || length < Vector128<T>.Count)
			{
				T right = highInclusive - lowInclusive;
				for (int i = length - 1; i >= 0; i--)
				{
					if (SpanHelpers.INegator<T>.NegateIfNeeded(*Unsafe.Add<T>(ref searchSpace, i) - lowInclusive <= right))
					{
						return i;
					}
				}
			}
			else
			{
				if (false)
				{
				}
				Vector128<T> right2 = Vector128.Create<T>(lowInclusive);
				Vector128<T> right3 = Vector128.Create<T>(highInclusive - lowInclusive);
				Vector128<T> vector;
				for (IntPtr intPtr = (IntPtr)(length - Vector128<T>.Count); intPtr > (IntPtr)0; intPtr -= (IntPtr)Vector128<T>.Count)
				{
					vector = SpanHelpers.INegator<T>.NegateIfNeeded(Vector128.LessThanOrEqual<T>(Vector128.LoadUnsafe<T>(ref searchSpace, (UIntPtr)intPtr) - right2, right3));
					if (vector != Vector128<T>.Zero)
					{
						return SpanHelpers.ComputeLastIndex<T>(intPtr, vector);
					}
				}
				vector = SpanHelpers.INegator<T>.NegateIfNeeded(Vector128.LessThanOrEqual<T>(Vector128.LoadUnsafe<T>(ref searchSpace) - right2, right3));
				if (vector != Vector128<T>.Zero)
				{
					return SpanHelpers.ComputeLastIndex<T>((IntPtr)0, vector);
				}
			}
			return -1;
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x0006182C File Offset: 0x0005FA2C
		public static int Count<T>(ref T current, T value, int length) where T : IEquatable<T>
		{
			int num = 0;
			ref T right = ref Unsafe.Add<T>(ref current, length);
			if (value != null)
			{
				while (Unsafe.IsAddressLessThan<T>(ref current, ref right))
				{
					if (value.Equals(current))
					{
						num++;
					}
					current = Unsafe.Add<T>(ref current, 1);
				}
			}
			else
			{
				while (Unsafe.IsAddressLessThan<T>(ref current, ref right))
				{
					if (current == null)
					{
						num++;
					}
					current = Unsafe.Add<T>(ref current, 1);
				}
			}
			return num;
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x000618A0 File Offset: 0x0005FAA0
		public static int CountValueType<T>(ref T current, T value, int length) where T : struct, IEquatable<T>
		{
			int num = 0;
			ref T ptr = ref Unsafe.Add<T>(ref current, length);
			if (Vector128.IsHardwareAccelerated && length >= Vector128<T>.Count)
			{
				if (false)
				{
				}
				if (false)
				{
				}
				Vector128<T> right = Vector128.Create<T>(value);
				ref T ptr2 = ref Unsafe.Subtract<T>(ref ptr, Vector128<T>.Count);
				while (Unsafe.IsAddressLessThan<T>(ref current, ref ptr2))
				{
					num += BitOperations.PopCount(Vector128.Equals<T>(Vector128.LoadUnsafe<T>(ref current), right).ExtractMostSignificantBits<T>());
					current = Unsafe.Add<T>(ref current, Vector128<T>.Count);
				}
				uint num2 = Vector128.Equals<T>(Vector128.LoadUnsafe<T>(ref ptr2), right).ExtractMostSignificantBits<T>();
				num2 >>= (int)(Unsafe.ByteOffset<T>(ref ptr2, ref current) / (IntPtr)((UIntPtr)sizeof(T)));
				num += BitOperations.PopCount(num2);
			}
			else
			{
				while (Unsafe.IsAddressLessThan<T>(ref current, ref ptr))
				{
					if (current.Equals(value))
					{
						num++;
					}
					current = Unsafe.Add<T>(ref current, 1);
				}
			}
			return num;
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00061980 File Offset: 0x0005FB80
		[CompilerGenerated]
		internal static int <LastIndexOfValueType>g__SimdImpl|93_0<TValue, TNegator, TVector>(ref TValue searchSpace, TValue value, int length) where TValue : struct, INumber<TValue> where TNegator : struct, SpanHelpers.INegator<TValue> where TVector : struct, ISimdVector<TVector, TValue>
		{
			TVector left = ISimdVector<TVector, TValue>.Create(value);
			TVector right;
			for (int i = length - ISimdVector<TVector, TValue>.Count; i > 0; i -= ISimdVector<TVector, TValue>.Count)
			{
				right = ISimdVector<TVector, TValue>.LoadUnsafe(ref searchSpace, (UIntPtr)i);
				if (SpanHelpers.INegator<TValue>.HasMatch<TVector>(left, right))
				{
					return i + ISimdVector<TVector, TValue>.IndexOfLastMatch(SpanHelpers.INegator<TValue>.GetMatchMask<TVector>(left, right));
				}
			}
			right = ISimdVector<TVector, TValue>.LoadUnsafe(ref searchSpace);
			if (SpanHelpers.INegator<TValue>.HasMatch<TVector>(left, right))
			{
				return ISimdVector<TVector, TValue>.IndexOfLastMatch(SpanHelpers.INegator<TValue>.GetMatchMask<TVector>(left, right));
			}
			return -1;
		}

		// Token: 0x020001A8 RID: 424
		[CompilerFeatureRequired("RefStructs")]
		internal readonly ref struct ComparerComparable<T, TComparer> : IComparable<T> where TComparer : IComparer<T>
		{
			// Token: 0x06001CC7 RID: 7367 RVA: 0x00061A2B File Offset: 0x0005FC2B
			public ComparerComparable(T value, TComparer comparer)
			{
				this._value = value;
				this._comparer = comparer;
			}

			// Token: 0x06001CC8 RID: 7368 RVA: 0x00061A3C File Offset: 0x0005FC3C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public int CompareTo(T other)
			{
				TComparer comparer = this._comparer;
				return comparer.Compare(this._value, other);
			}

			// Token: 0x04000576 RID: 1398
			private readonly T _value;

			// Token: 0x04000577 RID: 1399
			private readonly TComparer _comparer;
		}

		// Token: 0x020001A9 RID: 425
		private struct Block16
		{
		}

		// Token: 0x020001AA RID: 426
		private struct Block64
		{
		}

		// Token: 0x020001AB RID: 427
		internal interface INegator<T> where T : struct
		{
			// Token: 0x06001CC9 RID: 7369
			public abstract static bool NegateIfNeeded(bool equals);

			// Token: 0x06001CCA RID: 7370
			public abstract static Vector128<T> NegateIfNeeded(Vector128<T> equals);

			// Token: 0x06001CCB RID: 7371
			public abstract static Vector256<T> NegateIfNeeded(Vector256<T> equals);

			// Token: 0x06001CCC RID: 7372
			public abstract static Vector512<T> NegateIfNeeded(Vector512<T> equals);

			// Token: 0x06001CCD RID: 7373
			public abstract static bool HasMatch<TVector>(TVector left, TVector right);

			// Token: 0x06001CCE RID: 7374
			public abstract static TVector GetMatchMask<TVector>(TVector left, TVector right);
		}

		// Token: 0x020001AC RID: 428
		internal readonly struct DontNegate<T> : SpanHelpers.INegator<T> where T : struct
		{
			// Token: 0x06001CCF RID: 7375 RVA: 0x00007B62 File Offset: 0x00005D62
			public static bool NegateIfNeeded(bool equals)
			{
				return equals;
			}

			// Token: 0x06001CD0 RID: 7376 RVA: 0x00007B62 File Offset: 0x00005D62
			public static Vector128<T> NegateIfNeeded(Vector128<T> equals)
			{
				return equals;
			}

			// Token: 0x06001CD1 RID: 7377 RVA: 0x00007B62 File Offset: 0x00005D62
			public static Vector256<T> NegateIfNeeded(Vector256<T> equals)
			{
				return equals;
			}

			// Token: 0x06001CD2 RID: 7378 RVA: 0x00007B62 File Offset: 0x00005D62
			public static Vector512<T> NegateIfNeeded(Vector512<T> equals)
			{
				return equals;
			}

			// Token: 0x06001CD3 RID: 7379 RVA: 0x00061A64 File Offset: 0x0005FC64
			public static bool HasMatch<TVector>(TVector left, TVector right) where TVector : struct, ISimdVector<TVector, T>
			{
				return ISimdVector<TVector, T>.EqualsAny(left, right);
			}

			// Token: 0x06001CD4 RID: 7380 RVA: 0x00061A73 File Offset: 0x0005FC73
			public static TVector GetMatchMask<TVector>(TVector left, TVector right) where TVector : struct, ISimdVector<TVector, T>
			{
				return ISimdVector<TVector, T>.Equals(left, right);
			}
		}

		// Token: 0x020001AD RID: 429
		internal readonly struct Negate<T> : SpanHelpers.INegator<!0> where T : struct
		{
			// Token: 0x06001CD5 RID: 7381 RVA: 0x000202CE File Offset: 0x0001E4CE
			public static bool NegateIfNeeded(bool equals)
			{
				return !equals;
			}

			// Token: 0x06001CD6 RID: 7382 RVA: 0x00061A82 File Offset: 0x0005FC82
			public static Vector128<T> NegateIfNeeded(Vector128<T> equals)
			{
				return ~equals;
			}

			// Token: 0x06001CD7 RID: 7383 RVA: 0x00061A8A File Offset: 0x0005FC8A
			public static Vector256<T> NegateIfNeeded(Vector256<T> equals)
			{
				return ~equals;
			}

			// Token: 0x06001CD8 RID: 7384 RVA: 0x00061A92 File Offset: 0x0005FC92
			public static Vector512<T> NegateIfNeeded(Vector512<T> equals)
			{
				return ~equals;
			}

			// Token: 0x06001CD9 RID: 7385 RVA: 0x00061A9A File Offset: 0x0005FC9A
			public static bool HasMatch<TVector>(TVector left, TVector right) where TVector : struct, ISimdVector<TVector, T>
			{
				return !ISimdVector<TVector, T>.EqualsAll(left, right);
			}

			// Token: 0x06001CDA RID: 7386 RVA: 0x00061AAC File Offset: 0x0005FCAC
			public static TVector GetMatchMask<TVector>(TVector left, TVector right) where TVector : struct, ISimdVector<TVector, T>
			{
				return ~ISimdVector<TVector, T>.Equals(left, right);
			}
		}
	}
}
