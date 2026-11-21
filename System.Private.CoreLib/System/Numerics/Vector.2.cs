using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Text;

namespace System.Numerics
{
	// Token: 0x02000297 RID: 663
	[Intrinsic]
	[DebuggerDisplay("{DisplayString,nq}")]
	[DebuggerTypeProxy(typeof(VectorDebugView<>))]
	public readonly struct Vector<[Nullable(2)] T> : ISimdVector<Vector<T>, T>, IAdditionOperators<Vector<T>, Vector<T>, Vector<T>>, IBitwiseOperators<Vector<T>, Vector<T>, Vector<T>>, IDivisionOperators<Vector<T>, Vector<T>, Vector<T>>, IEqualityOperators<Vector<T>, Vector<T>, bool>, IEquatable<Vector<T>>, IMultiplyOperators<Vector<T>, Vector<T>, Vector<T>>, IShiftOperators<Vector<T>, int, Vector<T>>, ISubtractionOperators<Vector<T>, Vector<T>, Vector<T>>, IUnaryNegationOperators<Vector<T>, Vector<T>>, IUnaryPlusOperators<Vector<T>, Vector<T>>, IFormattable
	{
		// Token: 0x060030FE RID: 12542 RVA: 0x000A0147 File Offset: 0x0009E347
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector(T value)
		{
			this = Vector.Create<T>(value);
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000A0155 File Offset: 0x0009E355
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector(T[] values)
		{
			if (values.Length < Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			this = Unsafe.ReadUnaligned<Vector<T>>(Unsafe.As<T, byte>(ref values[0]));
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000A017D File Offset: 0x0009E37D
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector(T[] values, int index)
		{
			if (index < 0 || values.Length - index < Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRange_IndexMustBeLessOrEqualException();
			}
			this = Unsafe.ReadUnaligned<Vector<T>>(Unsafe.As<T, byte>(ref values[index]));
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000A01AB File Offset: 0x0009E3AB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector([Nullable(new byte[]
		{
			0,
			1
		})] ReadOnlySpan<T> values)
		{
			if (values.Length < Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			this = Unsafe.ReadUnaligned<Vector<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(values)));
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x000A01D7 File Offset: 0x0009E3D7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector(ReadOnlySpan<byte> values)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			if (values.Length < Vector<byte>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			this = Unsafe.ReadUnaligned<Vector<T>>(MemoryMarshal.GetReference<byte>(values));
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x000A0203 File Offset: 0x0009E403
		public Vector([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> values)
		{
			this = new Vector<T>(values);
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x000A0211 File Offset: 0x0009E411
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> AllBitsSet
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector.Create<T>(Scalar<T>.AllBitsSet);
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x000A021D File Offset: 0x0009E41D
		public static int Count
		{
			[Intrinsic]
			get
			{
				ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
				return sizeof(Vector<T>) / sizeof(T);
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x000A0234 File Offset: 0x0009E434
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Indices
		{
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
				Vector<T> result;
				Unsafe.SkipInit<Vector<T>>(out result);
				for (int i = 0; i < Vector<T>.Count; i++)
				{
					result.SetElementUnsafe(i, Scalar<T>.Convert(i));
				}
				return result;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x000A026C File Offset: 0x0009E46C
		public static bool IsSupported
		{
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return typeof(T) == typeof(byte) || typeof(T) == typeof(double) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(UIntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(float) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong);
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x000A03D2 File Offset: 0x0009E5D2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> One
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector.Create<T>(Scalar<T>.One);
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000A03E0 File Offset: 0x0009E5E0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> Zero
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
				return default(Vector<T>);
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x000A03FB File Offset: 0x0009E5FB
		[Nullable(1)]
		internal string DisplayString
		{
			get
			{
				if (!Vector<T>.IsSupported)
				{
					return SR.NotSupported_Type;
				}
				return this.ToString();
			}
		}

		// Token: 0x1700091A RID: 2330
		[Nullable(1)]
		public T this[int index]
		{
			[NullableContext(1)]
			[Intrinsic]
			get
			{
				return this.GetElement(index);
			}
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000A0424 File Offset: 0x0009E624
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Add(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x000A0468 File Offset: 0x0009E668
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator &([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			Vector<ulong> vector;
			Unsafe.SkipInit<Vector<ulong>>(out vector);
			Vector<ulong> vector2 = left.As<T, ulong>();
			Vector<ulong> vector3 = right.As<T, ulong>();
			for (int i = 0; i < Vector<ulong>.Count; i++)
			{
				ulong value = vector2.GetElementUnsafe(i) & vector3.GetElementUnsafe(i);
				vector.SetElementUnsafe(i, value);
			}
			return vector.As<ulong, T>();
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x000A04C4 File Offset: 0x0009E6C4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator |([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			Vector<ulong> vector;
			Unsafe.SkipInit<Vector<ulong>>(out vector);
			Vector<ulong> vector2 = left.As<T, ulong>();
			Vector<ulong> vector3 = right.As<T, ulong>();
			for (int i = 0; i < Vector<ulong>.Count; i++)
			{
				ulong value = vector2.GetElementUnsafe(i) | vector3.GetElementUnsafe(i);
				vector.SetElementUnsafe(i, value);
			}
			return vector.As<ulong, T>();
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x000A0520 File Offset: 0x0009E720
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Divide(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x000A0564 File Offset: 0x0009E764
		[NullableContext(1)]
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, T right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Divide(left.GetElementUnsafe(i), right);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x000A05A4 File Offset: 0x0009E7A4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (!Scalar<T>.Equals(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x000A05DC File Offset: 0x0009E7DC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator ^([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			Vector<ulong> vector;
			Unsafe.SkipInit<Vector<ulong>>(out vector);
			Vector<ulong> vector2 = left.As<T, ulong>();
			Vector<ulong> vector3 = right.As<T, ulong>();
			for (int i = 0; i < Vector<ulong>.Count; i++)
			{
				ulong value = vector2.GetElementUnsafe(i) ^ vector3.GetElementUnsafe(i);
				vector.SetElementUnsafe(i, value);
			}
			return vector.As<ulong, T>();
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x000A0636 File Offset: 0x0009E836
		[Intrinsic]
		public static explicit operator Vector<byte>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, byte>();
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x000A063E File Offset: 0x0009E83E
		[Intrinsic]
		public static explicit operator Vector<double>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, double>();
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000A0646 File Offset: 0x0009E846
		[Intrinsic]
		public static explicit operator Vector<short>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, short>();
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x000A064E File Offset: 0x0009E84E
		[Intrinsic]
		public static explicit operator Vector<int>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, int>();
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x000A0656 File Offset: 0x0009E856
		[Intrinsic]
		public static explicit operator Vector<long>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, long>();
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000A065E File Offset: 0x0009E85E
		[Intrinsic]
		public static explicit operator Vector<IntPtr>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, IntPtr>();
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x000A0666 File Offset: 0x0009E866
		[Intrinsic]
		[CLSCompliant(false)]
		public static explicit operator Vector<UIntPtr>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, UIntPtr>();
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x000A066E File Offset: 0x0009E86E
		[Intrinsic]
		[CLSCompliant(false)]
		public static explicit operator Vector<sbyte>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, sbyte>();
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000A0676 File Offset: 0x0009E876
		[Intrinsic]
		public static explicit operator Vector<float>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, float>();
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x000A067E File Offset: 0x0009E87E
		[Intrinsic]
		[CLSCompliant(false)]
		public static explicit operator Vector<ushort>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, ushort>();
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x000A0686 File Offset: 0x0009E886
		[Intrinsic]
		[CLSCompliant(false)]
		public static explicit operator Vector<uint>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, uint>();
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x000A068E File Offset: 0x0009E88E
		[Intrinsic]
		[CLSCompliant(false)]
		public static explicit operator Vector<ulong>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value.As<T, ulong>();
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x000A0696 File Offset: 0x0009E896
		[Intrinsic]
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			return !(left == right);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000A06A4 File Offset: 0x0009E8A4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator <<([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value, int shiftCount)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value2 = Scalar<T>.ShiftLeft(value.GetElementUnsafe(i), shiftCount);
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000A06E4 File Offset: 0x0009E8E4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Multiply(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000A0728 File Offset: 0x0009E928
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value, T factor)
		{
			return value * Vector.Create<T>(factor);
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000A0736 File Offset: 0x0009E936
		[NullableContext(1)]
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator *(T factor, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			return value * factor;
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000A0740 File Offset: 0x0009E940
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator ~([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			Vector<ulong> vector;
			Unsafe.SkipInit<Vector<ulong>>(out vector);
			Vector<ulong> vector2 = value.As<T, ulong>();
			for (int i = 0; i < Vector<ulong>.Count; i++)
			{
				ulong value2 = ~vector2.GetElementUnsafe(i);
				vector.SetElementUnsafe(i, value2);
			}
			return vector.As<ulong, T>();
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000A078C File Offset: 0x0009E98C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator >>([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value, int shiftCount)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value2 = Scalar<T>.ShiftRightArithmetic(value.GetElementUnsafe(i), shiftCount);
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000A07CC File Offset: 0x0009E9CC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> right)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value = Scalar<T>.Subtract(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x000A0810 File Offset: 0x0009EA10
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			if (typeof(T) == typeof(float))
			{
				return value ^ Vector.Create<float>(--0f).As<float, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return value ^ Vector.Create<double>(--0.0).As<double, T>();
			}
			return Vector<T>.Zero - value;
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x000A088E File Offset: 0x0009EA8E
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			return value;
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x000A0898 File Offset: 0x0009EA98
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector<T> op_UnsignedRightShift([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> value, int shiftCount)
		{
			Vector<T> result;
			Unsafe.SkipInit<Vector<T>>(out result);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T value2 = Scalar<T>.ShiftRightLogical(value.GetElementUnsafe(i), shiftCount);
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x000A08D5 File Offset: 0x0009EAD5
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CopyTo(T[] destination)
		{
			if (destination.Length < Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<T, byte>(ref destination[0]), this);
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x000A08FD File Offset: 0x0009EAFD
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CopyTo(T[] destination, int startIndex)
		{
			if (startIndex >= destination.Length)
			{
				ThrowHelper.ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_IndexMustBeLess();
			}
			if (destination.Length - startIndex < Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<T, byte>(ref destination[startIndex]), this);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x000A0932 File Offset: 0x0009EB32
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CopyTo(Span<byte> destination)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			if (destination.Length < Vector<byte>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector<T>>(MemoryMarshal.GetReference<byte>(destination), this);
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x000A095D File Offset: 0x0009EB5D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void CopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector<T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), this);
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x000A0988 File Offset: 0x0009EB88
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Vector<T>)
			{
				Vector<T> other = (Vector<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x000A09B0 File Offset: 0x0009EBB0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] Vector<T> other)
		{
			if (!Vector.IsHardwareAccelerated)
			{
				return Vector<T>.<Equals>g__SoftwareFallback|59_0(this, other);
			}
			if (typeof(T) == typeof(double) || typeof(T) == typeof(float))
			{
				return (Vector.Equals<T>(this, other) | ~(Vector.Equals<T>(this, this) | Vector.Equals<T>(other, other))).As<T, int>() == Vector<int>.AllBitsSet;
			}
			return this == other;
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x000A0A54 File Offset: 0x0009EC54
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				T elementUnsafe = this.GetElementUnsafe(i);
				hashCode.Add<T>(elementUnsafe);
			}
			return hashCode.ToHashCode();
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x000A0A90 File Offset: 0x0009EC90
		[NullableContext(1)]
		public override string ToString()
		{
			return this.ToString("G", CultureInfo.CurrentCulture);
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x000A0AA2 File Offset: 0x0009ECA2
		[NullableContext(1)]
		public string ToString([Nullable(2)] [StringSyntax("NumericFormat")] string format)
		{
			return this.ToString(format, CultureInfo.CurrentCulture);
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x000A0AB0 File Offset: 0x0009ECB0
		[NullableContext(2)]
		[return: Nullable(1)]
		public unsafe string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider formatProvider)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			valueStringBuilder.Append('<');
			valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(0))).ToString(format, formatProvider));
			for (int i = 1; i < Vector<T>.Count; i++)
			{
				valueStringBuilder.Append(numberGroupSeparator);
				valueStringBuilder.Append(' ');
				valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(i))).ToString(format, formatProvider));
			}
			valueStringBuilder.Append('>');
			return valueStringBuilder.ToString();
		}

		// Token: 0x06003134 RID: 12596 RVA: 0x000A0B64 File Offset: 0x0009ED64
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryCopyTo(Span<byte> destination)
		{
			ThrowHelper.ThrowForUnsupportedNumericsVectorBaseType<T>();
			if (destination.Length < Vector<byte>.Count)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Vector<T>>(MemoryMarshal.GetReference<byte>(destination), this);
			return true;
		}

		// Token: 0x06003135 RID: 12597 RVA: 0x000A0B8D File Offset: 0x0009ED8D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryCopyTo([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			if (destination.Length < Vector<T>.Count)
			{
				return false;
			}
			Unsafe.WriteUnaligned<Vector<T>>(Unsafe.As<T, byte>(MemoryMarshal.GetReference<T>(destination)), this);
			return true;
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x000A0BB6 File Offset: 0x0009EDB6
		int ISimdVector<Vector<!0>, !0>.Alignment
		{
			get
			{
				return Vector.Alignment;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x0009CDC8 File Offset: 0x0009AFC8
		bool ISimdVector<Vector<!0>, !0>.IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return Vector.IsHardwareAccelerated;
			}
		}

		// Token: 0x06003138 RID: 12600 RVA: 0x000A0BBD File Offset: 0x0009EDBD
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Abs(Vector<T> vector)
		{
			return Vector.Abs<T>(vector);
		}

		// Token: 0x06003139 RID: 12601 RVA: 0x000A0BC5 File Offset: 0x0009EDC5
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Add(Vector<T> left, Vector<T> right)
		{
			return left + right;
		}

		// Token: 0x0600313A RID: 12602 RVA: 0x000A0BCE File Offset: 0x0009EDCE
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.AndNot(Vector<T> left, Vector<T> right)
		{
			return Vector.AndNot<T>(left, right);
		}

		// Token: 0x0600313B RID: 12603 RVA: 0x000A0BD7 File Offset: 0x0009EDD7
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.BitwiseAnd(Vector<T> left, Vector<T> right)
		{
			return left & right;
		}

		// Token: 0x0600313C RID: 12604 RVA: 0x000A0BE0 File Offset: 0x0009EDE0
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.BitwiseOr(Vector<T> left, Vector<T> right)
		{
			return left | right;
		}

		// Token: 0x0600313D RID: 12605 RVA: 0x000A0BE9 File Offset: 0x0009EDE9
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Ceiling(Vector<T> vector)
		{
			return Vector.Ceiling<T>(vector);
		}

		// Token: 0x0600313E RID: 12606 RVA: 0x000A0BF1 File Offset: 0x0009EDF1
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Clamp(Vector<T> value, Vector<T> min, Vector<T> max)
		{
			return Vector.Clamp<T>(value, min, max);
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x000A0BFB File Offset: 0x0009EDFB
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.ClampNative(Vector<T> value, Vector<T> min, Vector<T> max)
		{
			return Vector.ClampNative<T>(value, min, max);
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x000A0C05 File Offset: 0x0009EE05
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.ConditionalSelect(Vector<T> condition, Vector<T> left, Vector<T> right)
		{
			return Vector.ConditionalSelect<T>(condition, left, right);
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x000A0C0F File Offset: 0x0009EE0F
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.CopySign(Vector<T> value, Vector<T> sign)
		{
			return Vector.CopySign<T>(value, sign);
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x000A0C18 File Offset: 0x0009EE18
		void ISimdVector<Vector<!0>, !0>.CopyTo(Vector<T> vector, T[] destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x000A0C22 File Offset: 0x0009EE22
		void ISimdVector<Vector<!0>, !0>.CopyTo(Vector<T> vector, T[] destination, int startIndex)
		{
			vector.CopyTo(destination, startIndex);
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x000A0C2D File Offset: 0x0009EE2D
		void ISimdVector<Vector<!0>, !0>.CopyTo(Vector<T> vector, Span<T> destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x000A0C37 File Offset: 0x0009EE37
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Create(T value)
		{
			return Vector.Create<T>(value);
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x000A0C3F File Offset: 0x0009EE3F
		Vector<T> ISimdVector<Vector<!0>, !0>.Create(T[] values)
		{
			return new Vector<T>(values);
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x000A0C47 File Offset: 0x0009EE47
		Vector<T> ISimdVector<Vector<!0>, !0>.Create(T[] values, int index)
		{
			return new Vector<T>(values, index);
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x000A0C50 File Offset: 0x0009EE50
		Vector<T> ISimdVector<Vector<!0>, !0>.Create(ReadOnlySpan<T> values)
		{
			return Vector.Create<T>(values);
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x000A0C58 File Offset: 0x0009EE58
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.CreateScalar(T value)
		{
			return Vector.CreateScalar<T>(value);
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x000A0C60 File Offset: 0x0009EE60
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.CreateScalarUnsafe(T value)
		{
			return Vector.CreateScalarUnsafe<T>(value);
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x000A0C68 File Offset: 0x0009EE68
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Divide(Vector<T> left, Vector<T> right)
		{
			return left / right;
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x000A0C71 File Offset: 0x0009EE71
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Divide(Vector<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x000A0C7A File Offset: 0x0009EE7A
		[Intrinsic]
		T ISimdVector<Vector<!0>, !0>.Dot(Vector<T> left, Vector<T> right)
		{
			return Vector.Dot<T>(left, right);
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x000A0C83 File Offset: 0x0009EE83
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Equals(Vector<T> left, Vector<T> right)
		{
			return Vector.Equals<T>(left, right);
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000A0C8C File Offset: 0x0009EE8C
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.EqualsAll(Vector<T> left, Vector<T> right)
		{
			return left == right;
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x000A0C95 File Offset: 0x0009EE95
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.EqualsAny(Vector<T> left, Vector<T> right)
		{
			return Vector.EqualsAny<T>(left, right);
		}

		// Token: 0x06003151 RID: 12625 RVA: 0x000A0C9E File Offset: 0x0009EE9E
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Floor(Vector<T> vector)
		{
			return Vector.Floor<T>(vector);
		}

		// Token: 0x06003152 RID: 12626 RVA: 0x000A0CA6 File Offset: 0x0009EEA6
		[Intrinsic]
		T ISimdVector<Vector<!0>, !0>.GetElement(Vector<T> vector, int index)
		{
			return vector.GetElement(index);
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000A0CAF File Offset: 0x0009EEAF
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.GreaterThan(Vector<T> left, Vector<T> right)
		{
			return Vector.GreaterThan<T>(left, right);
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000A0CB8 File Offset: 0x0009EEB8
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.GreaterThanAll(Vector<T> left, Vector<T> right)
		{
			return Vector.GreaterThanAll<T>(left, right);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000A0CC1 File Offset: 0x0009EEC1
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.GreaterThanAny(Vector<T> left, Vector<T> right)
		{
			return Vector.GreaterThanAny<T>(left, right);
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000A0CCA File Offset: 0x0009EECA
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.GreaterThanOrEqual(Vector<T> left, Vector<T> right)
		{
			return Vector.GreaterThanOrEqual<T>(left, right);
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000A0CD3 File Offset: 0x0009EED3
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.GreaterThanOrEqualAll(Vector<T> left, Vector<T> right)
		{
			return Vector.GreaterThanOrEqualAll<T>(left, right);
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000A0CDC File Offset: 0x0009EEDC
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.GreaterThanOrEqualAny(Vector<T> left, Vector<T> right)
		{
			return Vector.GreaterThanOrEqualAny<T>(left, right);
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x000A0CE5 File Offset: 0x0009EEE5
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.LessThan(Vector<T> left, Vector<T> right)
		{
			return Vector.LessThan<T>(left, right);
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x000A0CEE File Offset: 0x0009EEEE
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.LessThanAll(Vector<T> left, Vector<T> right)
		{
			return Vector.LessThanAll<T>(left, right);
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x000A0CF7 File Offset: 0x0009EEF7
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.LessThanAny(Vector<T> left, Vector<T> right)
		{
			return Vector.LessThanAny<T>(left, right);
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x000A0D00 File Offset: 0x0009EF00
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.LessThanOrEqual(Vector<T> left, Vector<T> right)
		{
			return Vector.LessThanOrEqual<T>(left, right);
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x000A0D09 File Offset: 0x0009EF09
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.LessThanOrEqualAll(Vector<T> left, Vector<T> right)
		{
			return Vector.LessThanOrEqualAll<T>(left, right);
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000A0D12 File Offset: 0x0009EF12
		[Intrinsic]
		bool ISimdVector<Vector<!0>, !0>.LessThanOrEqualAny(Vector<T> left, Vector<T> right)
		{
			return Vector.LessThanOrEqualAny<T>(left, right);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x000A0D1B File Offset: 0x0009EF1B
		[Intrinsic]
		unsafe Vector<T> ISimdVector<Vector<!0>, !0>.Load(T* source)
		{
			return Vector.Load<T>(source);
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x000A0D23 File Offset: 0x0009EF23
		[Intrinsic]
		unsafe Vector<T> ISimdVector<Vector<!0>, !0>.LoadAligned(T* source)
		{
			return Vector.LoadAligned<T>(source);
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x000A0D2B File Offset: 0x0009EF2B
		[Intrinsic]
		unsafe Vector<T> ISimdVector<Vector<!0>, !0>.LoadAlignedNonTemporal(T* source)
		{
			return Vector.LoadAlignedNonTemporal<T>(source);
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x000A0D33 File Offset: 0x0009EF33
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source)
		{
			return Vector.LoadUnsafe<T>(ref source);
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x000A0D3B File Offset: 0x0009EF3B
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			return Vector.LoadUnsafe<T>(ref source, elementOffset);
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x000A0D44 File Offset: 0x0009EF44
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Max(Vector<T> left, Vector<T> right)
		{
			return Vector.Max<T>(left, right);
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x000A0D4D File Offset: 0x0009EF4D
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MaxMagnitude(Vector<T> left, Vector<T> right)
		{
			return Vector.MaxMagnitude<T>(left, right);
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x000A0D56 File Offset: 0x0009EF56
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MaxMagnitudeNumber(Vector<T> left, Vector<T> right)
		{
			return Vector.MaxMagnitudeNumber<T>(left, right);
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x000A0D5F File Offset: 0x0009EF5F
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MaxNative(Vector<T> left, Vector<T> right)
		{
			return Vector.MaxNative<T>(left, right);
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x000A0D68 File Offset: 0x0009EF68
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MaxNumber(Vector<T> left, Vector<T> right)
		{
			return Vector.MaxNumber<T>(left, right);
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x000A0D71 File Offset: 0x0009EF71
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Min(Vector<T> left, Vector<T> right)
		{
			return Vector.Min<T>(left, right);
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x000A0D7A File Offset: 0x0009EF7A
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MinMagnitude(Vector<T> left, Vector<T> right)
		{
			return Vector.MinMagnitude<T>(left, right);
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x000A0D83 File Offset: 0x0009EF83
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MinMagnitudeNumber(Vector<T> left, Vector<T> right)
		{
			return Vector.MinMagnitudeNumber<T>(left, right);
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x000A0D8C File Offset: 0x0009EF8C
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MinNative(Vector<T> left, Vector<T> right)
		{
			return Vector.MinNative<T>(left, right);
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x000A0D95 File Offset: 0x0009EF95
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MinNumber(Vector<T> left, Vector<T> right)
		{
			return Vector.MinNumber<T>(left, right);
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x000A0D9E File Offset: 0x0009EF9E
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Multiply(Vector<T> left, Vector<T> right)
		{
			return left * right;
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x000A0DA7 File Offset: 0x0009EFA7
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Multiply(Vector<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x000A0DB0 File Offset: 0x0009EFB0
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.MultiplyAddEstimate(Vector<T> left, Vector<T> right, Vector<T> addend)
		{
			return Vector.MultiplyAddEstimate<T>(left, right, addend);
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x000A0DBA File Offset: 0x0009EFBA
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Negate(Vector<T> vector)
		{
			return -vector;
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x000A0DC2 File Offset: 0x0009EFC2
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.OnesComplement(Vector<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x000A0DCA File Offset: 0x0009EFCA
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Round(Vector<T> vector)
		{
			return Vector.Round<T>(vector);
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x000A0DD2 File Offset: 0x0009EFD2
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.ShiftLeft(Vector<T> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x000A0DDB File Offset: 0x0009EFDB
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.ShiftRightArithmetic(Vector<T> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x000A0DE4 File Offset: 0x0009EFE4
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.ShiftRightLogical(Vector<T> vector, int shiftCount)
		{
			return Vector<T>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x000A0DED File Offset: 0x0009EFED
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Sqrt(Vector<T> vector)
		{
			return Vector.SquareRoot<T>(vector);
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x000A0DF5 File Offset: 0x0009EFF5
		[Intrinsic]
		unsafe void ISimdVector<Vector<!0>, !0>.Store(Vector<T> source, T* destination)
		{
			source.Store(destination);
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x000A0DFE File Offset: 0x0009EFFE
		[Intrinsic]
		unsafe void ISimdVector<Vector<!0>, !0>.StoreAligned(Vector<T> source, T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000A0E07 File Offset: 0x0009F007
		[Intrinsic]
		unsafe void ISimdVector<Vector<!0>, !0>.StoreAlignedNonTemporal(Vector<T> source, T* destination)
		{
			source.StoreAlignedNonTemporal(destination);
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000A0E10 File Offset: 0x0009F010
		[Intrinsic]
		void ISimdVector<Vector<!0>, !0>.StoreUnsafe(Vector<T> vector, ref T destination)
		{
			vector.StoreUnsafe(ref destination);
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x000A0E19 File Offset: 0x0009F019
		[Intrinsic]
		void ISimdVector<Vector<!0>, !0>.StoreUnsafe(Vector<T> vector, ref T destination, UIntPtr elementOffset)
		{
			vector.StoreUnsafe(ref destination, elementOffset);
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x000A0E23 File Offset: 0x0009F023
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Subtract(Vector<T> left, Vector<T> right)
		{
			return left - right;
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x000A0E2C File Offset: 0x0009F02C
		[Intrinsic]
		T ISimdVector<Vector<!0>, !0>.Sum(Vector<T> vector)
		{
			return Vector.Sum<T>(vector);
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x000A0E34 File Offset: 0x0009F034
		[Intrinsic]
		T ISimdVector<Vector<!0>, !0>.ToScalar(Vector<T> vector)
		{
			return vector.ToScalar<T>();
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x000A0E3C File Offset: 0x0009F03C
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Truncate(Vector<T> vector)
		{
			return Vector.Truncate<T>(vector);
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000A0E44 File Offset: 0x0009F044
		bool ISimdVector<Vector<!0>, !0>.TryCopyTo(Vector<T> vector, Span<T> destination)
		{
			return vector.TryCopyTo(destination);
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x000A0E4E File Offset: 0x0009F04E
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.WithElement(Vector<T> vector, int index, T value)
		{
			return vector.WithElement(index, value);
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x000A0E58 File Offset: 0x0009F058
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.Xor(Vector<T> left, Vector<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x000A0E61 File Offset: 0x0009F061
		bool ISimdVector<Vector<!0>, !0>.AnyWhereAllBitsSet(Vector<T> vector)
		{
			return Vector.EqualsAny<T>(vector, Vector<T>.AllBitsSet);
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x000A0E6E File Offset: 0x0009F06E
		bool ISimdVector<Vector<!0>, !0>.Any(Vector<T> vector, T value)
		{
			return Vector.EqualsAny<T>(vector, Vector.Create<T>(value));
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x000A0E7C File Offset: 0x0009F07C
		int ISimdVector<Vector<!0>, !0>.IndexOfLastMatch(Vector<T> vector)
		{
			if (sizeof(Vector<T>) == 64)
			{
				ulong value = vector.AsVector512<T>().ExtractMostSignificantBits<T>();
				return 63 - BitOperations.LeadingZeroCount(value);
			}
			if (sizeof(Vector<T>) == 32)
			{
				uint value2 = vector.AsVector256<T>().ExtractMostSignificantBits<T>();
				return 31 - BitOperations.LeadingZeroCount(value2);
			}
			uint value3 = vector.AsVector128<T>().ExtractMostSignificantBits<T>();
			return 31 - BitOperations.LeadingZeroCount(value3);
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x000A0EDE File Offset: 0x0009F0DE
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.IsNaN(Vector<T> vector)
		{
			return Vector.IsNaN<T>(vector);
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x000A0EE6 File Offset: 0x0009F0E6
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.IsNegative(Vector<T> vector)
		{
			return Vector.IsNegative<T>(vector);
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x000A0EEE File Offset: 0x0009F0EE
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.IsPositive(Vector<T> vector)
		{
			return Vector.IsPositive<T>(vector);
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x000A0EF6 File Offset: 0x0009F0F6
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.IsPositiveInfinity(Vector<T> vector)
		{
			return Vector.IsPositiveInfinity<T>(vector);
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x000A0EFE File Offset: 0x0009F0FE
		[Intrinsic]
		Vector<T> ISimdVector<Vector<!0>, !0>.IsZero(Vector<T> vector)
		{
			return Vector.IsZero<T>(vector);
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x000A0F08 File Offset: 0x0009F108
		[CompilerGenerated]
		internal static bool <Equals>g__SoftwareFallback|59_0(in Vector<T> self, Vector<T> other)
		{
			for (int i = 0; i < Vector<T>.Count; i++)
			{
				if (!Scalar<T>.ObjectEquals(self.GetElementUnsafe(i), other.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040008E9 RID: 2281
		internal readonly ulong _00;

		// Token: 0x040008EA RID: 2282
		internal readonly ulong _01;
	}
}
