using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

namespace System
{
	// Token: 0x020001AE RID: 430
	internal static class PackedSpanHelpers
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x00061AC6 File Offset: 0x0005FCC6
		public static bool PackedIndexOfIsSupported
		{
			get
			{
				return Sse2.IsSupported;
			}
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00061ACD File Offset: 0x0005FCCD
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool CanUsePackedIndexOf<T>(T value)
		{
			return Unsafe.BitCast<T, ushort>(value) - 1 < 254;
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00061ADE File Offset: 0x0005FCDE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOf(ref char searchSpace, char value, int length)
		{
			return PackedSpanHelpers.IndexOf<SpanHelpers.DontNegate<short>, PackedSpanHelpers.NopTransform>(Unsafe.As<char, short>(ref searchSpace), (short)value, length);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00061AEE File Offset: 0x0005FCEE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExcept(ref char searchSpace, char value, int length)
		{
			return PackedSpanHelpers.IndexOf<SpanHelpers.Negate<short>, PackedSpanHelpers.NopTransform>(Unsafe.As<char, short>(ref searchSpace), (short)value, length);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00061AFE File Offset: 0x0005FCFE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny(ref char searchSpace, char value0, char value1, int length)
		{
			return PackedSpanHelpers.IndexOfAny<SpanHelpers.DontNegate<short>, PackedSpanHelpers.NopTransform>(Unsafe.As<char, short>(ref searchSpace), (short)value0, (short)value1, length);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00061B10 File Offset: 0x0005FD10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExcept(ref char searchSpace, char value0, char value1, int length)
		{
			return PackedSpanHelpers.IndexOfAny<SpanHelpers.Negate<short>, PackedSpanHelpers.NopTransform>(Unsafe.As<char, short>(ref searchSpace), (short)value0, (short)value1, length);
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00061B22 File Offset: 0x0005FD22
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAny(ref char searchSpace, char value0, char value1, char value2, int length)
		{
			return PackedSpanHelpers.IndexOfAny<SpanHelpers.DontNegate<short>>(Unsafe.As<char, short>(ref searchSpace), (short)value0, (short)value1, (short)value2, length);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00061B37 File Offset: 0x0005FD37
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExcept(ref char searchSpace, char value0, char value1, char value2, int length)
		{
			return PackedSpanHelpers.IndexOfAny<SpanHelpers.Negate<short>>(Unsafe.As<char, short>(ref searchSpace), (short)value0, (short)value1, (short)value2, length);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00061B4C File Offset: 0x0005FD4C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyIgnoreCase(ref char searchSpace, char value, int length)
		{
			return PackedSpanHelpers.IndexOf<SpanHelpers.DontNegate<short>, PackedSpanHelpers.Or20Transform>(Unsafe.As<char, short>(ref searchSpace), (short)value, length);
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00061B5C File Offset: 0x0005FD5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExceptIgnoreCase(ref char searchSpace, char value, int length)
		{
			return PackedSpanHelpers.IndexOf<SpanHelpers.Negate<short>, PackedSpanHelpers.Or20Transform>(Unsafe.As<char, short>(ref searchSpace), (short)value, length);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00061B6C File Offset: 0x0005FD6C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyIgnoreCase(ref char searchSpace, char value0, char value1, int length)
		{
			return PackedSpanHelpers.IndexOfAny<SpanHelpers.DontNegate<short>, PackedSpanHelpers.Or20Transform>(Unsafe.As<char, short>(ref searchSpace), (short)value0, (short)value1, length);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00061B7E File Offset: 0x0005FD7E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExceptIgnoreCase(ref char searchSpace, char value0, char value1, int length)
		{
			return PackedSpanHelpers.IndexOfAny<SpanHelpers.Negate<short>, PackedSpanHelpers.Or20Transform>(Unsafe.As<char, short>(ref searchSpace), (short)value0, (short)value1, length);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00061B90 File Offset: 0x0005FD90
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyInRange(ref char searchSpace, char lowInclusive, char rangeInclusive, int length)
		{
			return PackedSpanHelpers.IndexOfAnyInRange<SpanHelpers.DontNegate<short>>(Unsafe.As<char, short>(ref searchSpace), (short)lowInclusive, (short)rangeInclusive, length);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00061BA2 File Offset: 0x0005FDA2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfAnyExceptInRange(ref char searchSpace, char lowInclusive, char rangeInclusive, int length)
		{
			return PackedSpanHelpers.IndexOfAnyInRange<SpanHelpers.Negate<short>>(Unsafe.As<char, short>(ref searchSpace), (short)lowInclusive, (short)rangeInclusive, length);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00061BB4 File Offset: 0x0005FDB4
		public unsafe static bool Contains(ref short searchSpace, short value, int length)
		{
			if (length < Vector128<short>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				if (length >= 4)
				{
					length -= 4;
					if (searchSpace == value || *Unsafe.Add<short>(ref searchSpace, 1) == value || *Unsafe.Add<short>(ref searchSpace, 2) == value || *Unsafe.Add<short>(ref searchSpace, 3) == value)
					{
						return true;
					}
					uintPtr = (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					if (*Unsafe.Add<short>(ref searchSpace, uintPtr) == value)
					{
						return true;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
			}
			else
			{
				ref short ptr = ref searchSpace;
				if (false)
				{
				}
				if (false)
				{
				}
				Vector128<byte> left = Vector128.Create((byte)value);
				if (length > 2 * Vector128<short>.Count)
				{
					ref short right = ref Unsafe.Add<short>(ref searchSpace, length - 2 * Vector128<short>.Count);
					for (;;)
					{
						Vector128<short> source = Vector128.LoadUnsafe<short>(ref ptr);
						Vector128<short> source2 = Vector128.LoadUnsafe<short>(ref ptr, (UIntPtr)((IntPtr)Vector128<short>.Count));
						Vector128<byte> right2 = PackedSpanHelpers.PackSources(source, source2);
						if (Vector128.Equals<byte>(left, right2) != Vector128<byte>.Zero)
						{
							break;
						}
						ptr = Unsafe.Add<short>(ref ptr, 2 * Vector128<short>.Count);
						if (!Unsafe.IsAddressLessThan<short>(ref ptr, ref right))
						{
							goto IL_E1;
						}
					}
					return true;
				}
				IL_E1:
				ref short ptr2 = ref Unsafe.Add<short>(ref searchSpace, length - Vector128<short>.Count);
				Vector128<short> source3 = Vector128.LoadUnsafe<short>(ref Unsafe.IsAddressGreaterThan<short>(ref ptr, ref ptr2) ? ref ptr2 : ref ptr);
				Vector128<short> source4 = Vector128.LoadUnsafe<short>(ref ptr2);
				Vector128<byte> right3 = PackedSpanHelpers.PackSources(source3, source4);
				if (Vector128.Equals<byte>(left, right3) != Vector128<byte>.Zero)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00061CF0 File Offset: 0x0005FEF0
		private unsafe static int IndexOf<TNegator, TTransform>(ref short searchSpace, short value, int length) where TNegator : struct, SpanHelpers.INegator<short> where TTransform : struct, PackedSpanHelpers.ITransform
		{
			if (length < Vector128<short>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				if (length >= 4)
				{
					length -= 4;
					if (SpanHelpers.INegator<short>.NegateIfNeeded(PackedSpanHelpers.ITransform.TransformInput(searchSpace) == value))
					{
						return 0;
					}
					if (SpanHelpers.INegator<short>.NegateIfNeeded(PackedSpanHelpers.ITransform.TransformInput(*Unsafe.Add<short>(ref searchSpace, 1)) == value))
					{
						return 1;
					}
					if (SpanHelpers.INegator<short>.NegateIfNeeded(PackedSpanHelpers.ITransform.TransformInput(*Unsafe.Add<short>(ref searchSpace, 2)) == value))
					{
						return 2;
					}
					if (SpanHelpers.INegator<short>.NegateIfNeeded(PackedSpanHelpers.ITransform.TransformInput(*Unsafe.Add<short>(ref searchSpace, 3)) == value))
					{
						return 3;
					}
					uintPtr = (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					if (SpanHelpers.INegator<short>.NegateIfNeeded(PackedSpanHelpers.ITransform.TransformInput(*Unsafe.Add<short>(ref searchSpace, uintPtr)) == value))
					{
						return (int)uintPtr;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
			}
			else
			{
				ref short ptr = ref searchSpace;
				if (false)
				{
				}
				if (false)
				{
				}
				Vector128<byte> left = Vector128.Create((byte)value);
				if (length > 2 * Vector128<short>.Count)
				{
					ref short right = ref Unsafe.Add<short>(ref searchSpace, length - 2 * Vector128<short>.Count);
					Vector128<byte> vector;
					for (;;)
					{
						Vector128<short> source = Vector128.LoadUnsafe<short>(ref ptr);
						Vector128<short> source2 = Vector128.LoadUnsafe<short>(ref ptr, (UIntPtr)((IntPtr)Vector128<short>.Count));
						Vector128<byte> right2 = PackedSpanHelpers.ITransform.TransformInput(PackedSpanHelpers.PackSources(source, source2));
						vector = Vector128.Equals<byte>(left, right2);
						vector = PackedSpanHelpers.NegateIfNeeded<TNegator>(vector);
						if (vector != Vector128<byte>.Zero)
						{
							break;
						}
						ptr = Unsafe.Add<short>(ref ptr, 2 * Vector128<short>.Count);
						if (!Unsafe.IsAddressLessThan<short>(ref ptr, ref right))
						{
							goto IL_186;
						}
					}
					return PackedSpanHelpers.ComputeFirstIndex(ref searchSpace, ref ptr, vector);
				}
				IL_186:
				ref short ptr2 = ref Unsafe.Add<short>(ref searchSpace, length - Vector128<short>.Count);
				ref short ptr3 = ref Unsafe.IsAddressGreaterThan<short>(ref ptr, ref ptr2) ? ref ptr2 : ref ptr;
				Vector128<short> source3 = Vector128.LoadUnsafe<short>(ref ptr3);
				Vector128<short> source4 = Vector128.LoadUnsafe<short>(ref ptr2);
				Vector128<byte> right3 = PackedSpanHelpers.ITransform.TransformInput(PackedSpanHelpers.PackSources(source3, source4));
				Vector128<byte> vector2 = Vector128.Equals<byte>(left, right3);
				vector2 = PackedSpanHelpers.NegateIfNeeded<TNegator>(vector2);
				if (vector2 != Vector128<byte>.Zero)
				{
					return PackedSpanHelpers.ComputeFirstIndexOverlapped(ref searchSpace, ref ptr3, ref ptr2, vector2);
				}
			}
			return -1;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00061EF8 File Offset: 0x000600F8
		private unsafe static int IndexOfAny<TNegator, TTransform>(ref short searchSpace, short value0, short value1, int length) where TNegator : struct, SpanHelpers.INegator<short> where TTransform : struct, PackedSpanHelpers.ITransform
		{
			if (length < Vector128<short>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				if (length >= 4)
				{
					length -= 4;
					short num = PackedSpanHelpers.ITransform.TransformInput(searchSpace);
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1))
					{
						return 0;
					}
					num = PackedSpanHelpers.ITransform.TransformInput(*Unsafe.Add<short>(ref searchSpace, 1));
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1))
					{
						return 1;
					}
					num = PackedSpanHelpers.ITransform.TransformInput(*Unsafe.Add<short>(ref searchSpace, 2));
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1))
					{
						return 2;
					}
					num = PackedSpanHelpers.ITransform.TransformInput(*Unsafe.Add<short>(ref searchSpace, 3));
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1))
					{
						return 3;
					}
					uintPtr = (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					short num = PackedSpanHelpers.ITransform.TransformInput(*Unsafe.Add<short>(ref searchSpace, uintPtr));
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1))
					{
						return (int)uintPtr;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
			}
			else
			{
				ref short ptr = ref searchSpace;
				if (false)
				{
				}
				if (false)
				{
				}
				Vector128<byte> left = Vector128.Create((byte)value0);
				Vector128<byte> left2 = Vector128.Create((byte)value1);
				if (length > 2 * Vector128<short>.Count)
				{
					ref short right = ref Unsafe.Add<short>(ref searchSpace, length - 2 * Vector128<short>.Count);
					Vector128<byte> vector;
					for (;;)
					{
						Vector128<short> source = Vector128.LoadUnsafe<short>(ref ptr);
						Vector128<short> source2 = Vector128.LoadUnsafe<short>(ref ptr, (UIntPtr)((IntPtr)Vector128<short>.Count));
						Vector128<byte> right2 = PackedSpanHelpers.ITransform.TransformInput(PackedSpanHelpers.PackSources(source, source2));
						vector = (Vector128.Equals<byte>(left, right2) | Vector128.Equals<byte>(left2, right2));
						vector = PackedSpanHelpers.NegateIfNeeded<TNegator>(vector);
						if (vector != Vector128<byte>.Zero)
						{
							break;
						}
						ptr = Unsafe.Add<short>(ref ptr, 2 * Vector128<short>.Count);
						if (!Unsafe.IsAddressLessThan<short>(ref ptr, ref right))
						{
							goto IL_1CD;
						}
					}
					return PackedSpanHelpers.ComputeFirstIndex(ref searchSpace, ref ptr, vector);
				}
				IL_1CD:
				ref short ptr2 = ref Unsafe.Add<short>(ref searchSpace, length - Vector128<short>.Count);
				ref short ptr3 = ref Unsafe.IsAddressGreaterThan<short>(ref ptr, ref ptr2) ? ref ptr2 : ref ptr;
				Vector128<short> source3 = Vector128.LoadUnsafe<short>(ref ptr3);
				Vector128<short> source4 = Vector128.LoadUnsafe<short>(ref ptr2);
				Vector128<byte> right3 = PackedSpanHelpers.ITransform.TransformInput(PackedSpanHelpers.PackSources(source3, source4));
				Vector128<byte> vector2 = Vector128.Equals<byte>(left, right3) | Vector128.Equals<byte>(left2, right3);
				vector2 = PackedSpanHelpers.NegateIfNeeded<TNegator>(vector2);
				if (vector2 != Vector128<byte>.Zero)
				{
					return PackedSpanHelpers.ComputeFirstIndexOverlapped(ref searchSpace, ref ptr3, ref ptr2, vector2);
				}
			}
			return -1;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00062154 File Offset: 0x00060354
		private unsafe static int IndexOfAny<TNegator>(ref short searchSpace, short value0, short value1, short value2, int length) where TNegator : struct, SpanHelpers.INegator<short>
		{
			if (length < Vector128<short>.Count)
			{
				UIntPtr uintPtr = (UIntPtr)((IntPtr)0);
				if (length >= 4)
				{
					length -= 4;
					short num = searchSpace;
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1 || num == value2))
					{
						return 0;
					}
					num = *Unsafe.Add<short>(ref searchSpace, 1);
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1 || num == value2))
					{
						return 1;
					}
					num = *Unsafe.Add<short>(ref searchSpace, 2);
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1 || num == value2))
					{
						return 2;
					}
					num = *Unsafe.Add<short>(ref searchSpace, 3);
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1 || num == value2))
					{
						return 3;
					}
					uintPtr = (UIntPtr)((IntPtr)4);
				}
				while (length > 0)
				{
					length--;
					short num = *Unsafe.Add<short>(ref searchSpace, uintPtr);
					if (SpanHelpers.INegator<short>.NegateIfNeeded(num == value0 || num == value1 || num == value2))
					{
						return (int)uintPtr;
					}
					uintPtr += (UIntPtr)((IntPtr)1);
				}
			}
			else
			{
				ref short ptr = ref searchSpace;
				if (false)
				{
				}
				if (false)
				{
				}
				Vector128<byte> left = Vector128.Create((byte)value0);
				Vector128<byte> left2 = Vector128.Create((byte)value1);
				Vector128<byte> left3 = Vector128.Create((byte)value2);
				if (length > 2 * Vector128<short>.Count)
				{
					ref short right = ref Unsafe.Add<short>(ref searchSpace, length - 2 * Vector128<short>.Count);
					Vector128<byte> vector;
					for (;;)
					{
						Vector128<short> source = Vector128.LoadUnsafe<short>(ref ptr);
						Vector128<short> source2 = Vector128.LoadUnsafe<short>(ref ptr, (UIntPtr)((IntPtr)Vector128<short>.Count));
						Vector128<byte> right2 = PackedSpanHelpers.PackSources(source, source2);
						vector = (Vector128.Equals<byte>(left, right2) | Vector128.Equals<byte>(left2, right2) | Vector128.Equals<byte>(left3, right2));
						vector = PackedSpanHelpers.NegateIfNeeded<TNegator>(vector);
						if (vector != Vector128<byte>.Zero)
						{
							break;
						}
						ptr = Unsafe.Add<short>(ref ptr, 2 * Vector128<short>.Count);
						if (!Unsafe.IsAddressLessThan<short>(ref ptr, ref right))
						{
							goto IL_1BD;
						}
					}
					return PackedSpanHelpers.ComputeFirstIndex(ref searchSpace, ref ptr, vector);
				}
				IL_1BD:
				ref short ptr2 = ref Unsafe.Add<short>(ref searchSpace, length - Vector128<short>.Count);
				ref short ptr3 = ref Unsafe.IsAddressGreaterThan<short>(ref ptr, ref ptr2) ? ref ptr2 : ref ptr;
				Vector128<short> source3 = Vector128.LoadUnsafe<short>(ref ptr3);
				Vector128<short> source4 = Vector128.LoadUnsafe<short>(ref ptr2);
				Vector128<byte> right3 = PackedSpanHelpers.PackSources(source3, source4);
				Vector128<byte> vector2 = Vector128.Equals<byte>(left, right3) | Vector128.Equals<byte>(left2, right3) | Vector128.Equals<byte>(left3, right3);
				vector2 = PackedSpanHelpers.NegateIfNeeded<TNegator>(vector2);
				if (vector2 != Vector128<byte>.Zero)
				{
					return PackedSpanHelpers.ComputeFirstIndexOverlapped(ref searchSpace, ref ptr3, ref ptr2, vector2);
				}
			}
			return -1;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000623A4 File Offset: 0x000605A4
		private unsafe static int IndexOfAnyInRange<TNegator>(ref short searchSpace, short lowInclusive, short rangeInclusive, int length) where TNegator : struct, SpanHelpers.INegator<short>
		{
			if (length < Vector128<short>.Count)
			{
				for (int i = 0; i < length; i++)
				{
					if (SpanHelpers.INegator<short>.NegateIfNeeded(*Unsafe.Add<short>(ref searchSpace, i) - lowInclusive <= rangeInclusive))
					{
						return i;
					}
				}
			}
			else
			{
				ref short ptr = ref searchSpace;
				if (false)
				{
				}
				if (false)
				{
				}
				Vector128<byte> right = Vector128.Create((byte)lowInclusive);
				Vector128<byte> right2 = Vector128.Create((byte)rangeInclusive);
				if (length > 2 * Vector128<short>.Count)
				{
					ref short right3 = ref Unsafe.Add<short>(ref searchSpace, length - 2 * Vector128<short>.Count);
					Vector128<byte> vector;
					for (;;)
					{
						Vector128<short> source = Vector128.LoadUnsafe<short>(ref ptr);
						Vector128<short> source2 = Vector128.LoadUnsafe<short>(ref ptr, (UIntPtr)((IntPtr)Vector128<short>.Count));
						vector = Vector128.LessThanOrEqual<byte>(PackedSpanHelpers.PackSources(source, source2) - right, right2);
						vector = PackedSpanHelpers.NegateIfNeeded<TNegator>(vector);
						if (vector != Vector128<byte>.Zero)
						{
							break;
						}
						ptr = Unsafe.Add<short>(ref ptr, 2 * Vector128<short>.Count);
						if (!Unsafe.IsAddressLessThan<short>(ref ptr, ref right3))
						{
							goto IL_DD;
						}
					}
					return PackedSpanHelpers.ComputeFirstIndex(ref searchSpace, ref ptr, vector);
				}
				IL_DD:
				ref short ptr2 = ref Unsafe.Add<short>(ref searchSpace, length - Vector128<short>.Count);
				ref short ptr3 = ref Unsafe.IsAddressGreaterThan<short>(ref ptr, ref ptr2) ? ref ptr2 : ref ptr;
				Vector128<short> source3 = Vector128.LoadUnsafe<short>(ref ptr3);
				Vector128<short> source4 = Vector128.LoadUnsafe<short>(ref ptr2);
				Vector128<byte> vector2 = Vector128.LessThanOrEqual<byte>(PackedSpanHelpers.PackSources(source3, source4) - right, right2);
				vector2 = PackedSpanHelpers.NegateIfNeeded<TNegator>(vector2);
				if (vector2 != Vector128<byte>.Zero)
				{
					return PackedSpanHelpers.ComputeFirstIndexOverlapped(ref searchSpace, ref ptr3, ref ptr2, vector2);
				}
			}
			return -1;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000624FA File Offset: 0x000606FA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> PackSources(Vector128<short> source0, Vector128<short> source1)
		{
			return Sse2.PackUnsignedSaturate(source0, source1).AsByte<byte>();
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00062508 File Offset: 0x00060708
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector128<byte> NegateIfNeeded<TNegator>(Vector128<byte> result) where TNegator : struct, SpanHelpers.INegator<short>
		{
			if (!(typeof(TNegator) == typeof(SpanHelpers.DontNegate<short>)))
			{
				return ~result;
			}
			return result;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x0006252D File Offset: 0x0006072D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ComputeFirstIndex(ref short searchSpace, ref short current, Vector128<byte> equals)
		{
			return BitOperations.TrailingZeroCount(equals.ExtractMostSignificantBits<byte>()) + (int)(Unsafe.ByteOffset<short>(ref searchSpace, ref current) / (IntPtr)2);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00062548 File Offset: 0x00060748
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ComputeFirstIndexOverlapped(ref short searchSpace, ref short current0, ref short current1, Vector128<byte> equals)
		{
			int num = BitOperations.TrailingZeroCount(equals.ExtractMostSignificantBits<byte>());
			if (num >= Vector128<short>.Count)
			{
				current0 = ref current1;
				num -= Vector128<short>.Count;
			}
			return num + (int)(Unsafe.ByteOffset<short>(ref searchSpace, ref current0) / (IntPtr)2);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00062581 File Offset: 0x00060781
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Vector256<byte> FixUpPackedVector256Result(Vector256<byte> result)
		{
			return Avx2.Permute4x64(result.AsInt64<byte>(), 216).AsByte<long>();
		}

		// Token: 0x020001AF RID: 431
		private interface ITransform
		{
			// Token: 0x06001CF3 RID: 7411
			public abstract static short TransformInput(short input);

			// Token: 0x06001CF4 RID: 7412
			public abstract static Vector128<byte> TransformInput(Vector128<byte> input);

			// Token: 0x06001CF5 RID: 7413
			public abstract static Vector256<byte> TransformInput(Vector256<byte> input);

			// Token: 0x06001CF6 RID: 7414
			public abstract static Vector512<byte> TransformInput(Vector512<byte> input);
		}

		// Token: 0x020001B0 RID: 432
		private readonly struct NopTransform : PackedSpanHelpers.ITransform
		{
			// Token: 0x06001CF7 RID: 7415 RVA: 0x00007B62 File Offset: 0x00005D62
			public static short TransformInput(short input)
			{
				return input;
			}

			// Token: 0x06001CF8 RID: 7416 RVA: 0x00007B62 File Offset: 0x00005D62
			public static Vector128<byte> TransformInput(Vector128<byte> input)
			{
				return input;
			}

			// Token: 0x06001CF9 RID: 7417 RVA: 0x00007B62 File Offset: 0x00005D62
			public static Vector256<byte> TransformInput(Vector256<byte> input)
			{
				return input;
			}

			// Token: 0x06001CFA RID: 7418 RVA: 0x00007B62 File Offset: 0x00005D62
			public static Vector512<byte> TransformInput(Vector512<byte> input)
			{
				return input;
			}
		}

		// Token: 0x020001B1 RID: 433
		private readonly struct Or20Transform : PackedSpanHelpers.ITransform
		{
			// Token: 0x06001CFB RID: 7419 RVA: 0x00062598 File Offset: 0x00060798
			public static short TransformInput(short input)
			{
				return input | 32;
			}

			// Token: 0x06001CFC RID: 7420 RVA: 0x0006259F File Offset: 0x0006079F
			public static Vector128<byte> TransformInput(Vector128<byte> input)
			{
				return input | Vector128.Create(32);
			}

			// Token: 0x06001CFD RID: 7421 RVA: 0x000625AE File Offset: 0x000607AE
			public static Vector256<byte> TransformInput(Vector256<byte> input)
			{
				return input | Vector256.Create(32);
			}

			// Token: 0x06001CFE RID: 7422 RVA: 0x000625BD File Offset: 0x000607BD
			public static Vector512<byte> TransformInput(Vector512<byte> input)
			{
				return input | Vector512.Create(32);
			}
		}
	}
}
