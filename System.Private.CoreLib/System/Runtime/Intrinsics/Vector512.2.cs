using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Runtime.Intrinsics
{
	// Token: 0x0200054A RID: 1354
	[NullableContext(1)]
	[Nullable(0)]
	[Intrinsic]
	[DebuggerDisplay("{DisplayString,nq}")]
	[DebuggerTypeProxy(typeof(Vector512DebugView<>))]
	[StructLayout(LayoutKind.Sequential, Size = 64)]
	public readonly struct Vector512<[Nullable(2)] T> : ISimdVector<Vector512<T>, T>, IAdditionOperators<Vector512<T>, Vector512<T>, Vector512<T>>, IBitwiseOperators<Vector512<T>, Vector512<T>, Vector512<T>>, IDivisionOperators<Vector512<T>, Vector512<T>, Vector512<T>>, IEqualityOperators<Vector512<T>, Vector512<T>, bool>, IEquatable<Vector512<T>>, IMultiplyOperators<Vector512<T>, Vector512<T>, Vector512<T>>, IShiftOperators<Vector512<T>, int, Vector512<T>>, ISubtractionOperators<Vector512<T>, Vector512<T>, Vector512<T>>, IUnaryNegationOperators<Vector512<T>, Vector512<T>>, IUnaryPlusOperators<Vector512<T>, Vector512<T>>
	{
		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06004E51 RID: 20049 RVA: 0x001005D5 File Offset: 0x000FE7D5
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> AllBitsSet
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector512.Create<T>(Scalar<T>.AllBitsSet);
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x001005E1 File Offset: 0x000FE7E1
		public static int Count
		{
			[Intrinsic]
			get
			{
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
				return 64 / sizeof(T);
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06004E53 RID: 20051 RVA: 0x001005F4 File Offset: 0x000FE7F4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Indices
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
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
				Vector512<T> result;
				Unsafe.SkipInit<Vector512<T>>(out result);
				for (int i = 0; i < Vector512<T>.Count; i++)
				{
					result.SetElementUnsafe(i, Scalar<T>.Convert(i));
				}
				return result;
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x0010062C File Offset: 0x000FE82C
		public static bool IsSupported
		{
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return typeof(T) == typeof(byte) || typeof(T) == typeof(double) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(float) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr);
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06004E55 RID: 20053 RVA: 0x00100792 File Offset: 0x000FE992
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> One
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector512.Create<T>(Scalar<T>.One);
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06004E56 RID: 20054 RVA: 0x001007A0 File Offset: 0x000FE9A0
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> Zero
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
				return default(Vector512<T>);
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06004E57 RID: 20055 RVA: 0x001007BB File Offset: 0x000FE9BB
		internal string DisplayString
		{
			get
			{
				if (!Vector512<T>.IsSupported)
				{
					return SR.NotSupported_Type;
				}
				return this.ToString();
			}
		}

		// Token: 0x17000D3B RID: 3387
		public T this[int index]
		{
			get
			{
				return this.GetElement(index);
			}
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x001007E4 File Offset: 0x000FE9E4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(left._lower + right._lower, left._upper + right._upper);
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x0010080D File Offset: 0x000FEA0D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator &([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(left._lower & right._lower, left._upper & right._upper);
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x00100836 File Offset: 0x000FEA36
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator |([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(left._lower | right._lower, left._upper | right._upper);
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x0010085F File Offset: 0x000FEA5F
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(left._lower / right._lower, left._upper / right._upper);
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x00100888 File Offset: 0x000FEA88
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, T right)
		{
			return Vector512.Create<T>(left._lower / right, left._upper / right);
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x001008A7 File Offset: 0x000FEAA7
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return left._lower == right._lower && left._upper == right._upper;
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x001008CF File Offset: 0x000FEACF
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator ^([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(left._lower ^ right._lower, left._upper ^ right._upper);
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x001008F8 File Offset: 0x000FEAF8
		[Intrinsic]
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return !(left == right);
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x00100904 File Offset: 0x000FEB04
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator <<([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> value, int shiftCount)
		{
			return Vector512.Create<T>(value._lower << shiftCount, value._upper << shiftCount);
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x00100923 File Offset: 0x000FEB23
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(left._lower * right._lower, left._upper * right._upper);
		}

		// Token: 0x06004E63 RID: 20067 RVA: 0x0010094C File Offset: 0x000FEB4C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, T right)
		{
			return Vector512.Create<T>(left._lower * right, left._upper * right);
		}

		// Token: 0x06004E64 RID: 20068 RVA: 0x0010096B File Offset: 0x000FEB6B
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator *(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return right * left;
		}

		// Token: 0x06004E65 RID: 20069 RVA: 0x00100974 File Offset: 0x000FEB74
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator ~([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			return Vector512.Create<T>(~vector._lower, ~vector._upper);
		}

		// Token: 0x06004E66 RID: 20070 RVA: 0x00100991 File Offset: 0x000FEB91
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator >>([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> value, int shiftCount)
		{
			return Vector512.Create<T>(value._lower >> shiftCount, value._upper >> shiftCount);
		}

		// Token: 0x06004E67 RID: 20071 RVA: 0x001009B0 File Offset: 0x000FEBB0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> right)
		{
			return Vector512.Create<T>(left._lower - right._lower, left._upper - right._upper);
		}

		// Token: 0x06004E68 RID: 20072 RVA: 0x001009DC File Offset: 0x000FEBDC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return vector ^ Vector512.Create(--0f).As<float, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return vector ^ Vector512.Create(--0.0).As<double, T>();
			}
			return Vector512<T>.Zero - vector;
		}

		// Token: 0x06004E69 RID: 20073 RVA: 0x00100A5A File Offset: 0x000FEC5A
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			return value;
		}

		// Token: 0x06004E6A RID: 20074 RVA: 0x00100A62 File Offset: 0x000FEC62
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector512<T> op_UnsignedRightShift([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> value, int shiftCount)
		{
			return Vector512.Create<T>(Vector256<T>.op_UnsignedRightShift(value._lower, shiftCount), Vector256<T>.op_UnsignedRightShift(value._upper, shiftCount));
		}

		// Token: 0x06004E6B RID: 20075 RVA: 0x00100A84 File Offset: 0x000FEC84
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Vector512<T>)
			{
				Vector512<T> other = (Vector512<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06004E6C RID: 20076 RVA: 0x00100AA9 File Offset: 0x000FECA9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] Vector512<T> other)
		{
			if (false)
			{
			}
			return this._lower.Equals(other._lower) && this._upper.Equals(other._upper);
		}

		// Token: 0x06004E6D RID: 20077 RVA: 0x00100AD8 File Offset: 0x000FECD8
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			for (int i = 0; i < Vector512<T>.Count; i++)
			{
				T elementUnsafe = this.GetElementUnsafe(i);
				hashCode.Add<T>(elementUnsafe);
			}
			return hashCode.ToHashCode();
		}

		// Token: 0x06004E6E RID: 20078 RVA: 0x00100B14 File Offset: 0x000FED14
		public override string ToString()
		{
			return this.ToString("G", CultureInfo.InvariantCulture);
		}

		// Token: 0x06004E6F RID: 20079 RVA: 0x00100B28 File Offset: 0x000FED28
		private unsafe string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider formatProvider)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector512BaseType<T>();
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			valueStringBuilder.Append('<');
			valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(0))).ToString(format, formatProvider));
			for (int i = 1; i < Vector512<T>.Count; i++)
			{
				valueStringBuilder.Append(numberGroupSeparator);
				valueStringBuilder.Append(' ');
				valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(i))).ToString(format, formatProvider));
			}
			valueStringBuilder.Append('>');
			return valueStringBuilder.ToString();
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06004E70 RID: 20080 RVA: 0x00100BDC File Offset: 0x000FEDDC
		int ISimdVector<Vector512<!0>, !0>.Alignment
		{
			get
			{
				return 64;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06004E71 RID: 20081 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ISimdVector<Vector512<!0>, !0>.IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00100BE0 File Offset: 0x000FEDE0
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Abs(Vector512<T> vector)
		{
			return Vector512.Abs<T>(vector);
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x00100BE8 File Offset: 0x000FEDE8
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Add(Vector512<T> left, Vector512<T> right)
		{
			return left + right;
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x00100BF1 File Offset: 0x000FEDF1
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.AndNot(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.AndNot<T>(left, right);
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x00100BFA File Offset: 0x000FEDFA
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.BitwiseAnd(Vector512<T> left, Vector512<T> right)
		{
			return left & right;
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x00100C03 File Offset: 0x000FEE03
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.BitwiseOr(Vector512<T> left, Vector512<T> right)
		{
			return left | right;
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x00100C0C File Offset: 0x000FEE0C
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Ceiling(Vector512<T> vector)
		{
			return Vector512.Ceiling<T>(vector);
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x00100C14 File Offset: 0x000FEE14
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Clamp(Vector512<T> value, Vector512<T> min, Vector512<T> max)
		{
			return Vector512.Clamp<T>(value, min, max);
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00100C1E File Offset: 0x000FEE1E
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.ClampNative(Vector512<T> value, Vector512<T> min, Vector512<T> max)
		{
			return Vector512.ClampNative<T>(value, min, max);
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x00100C28 File Offset: 0x000FEE28
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.ConditionalSelect(Vector512<T> condition, Vector512<T> left, Vector512<T> right)
		{
			return Vector512.ConditionalSelect<T>(condition, left, right);
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x00100C32 File Offset: 0x000FEE32
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.CopySign(Vector512<T> value, Vector512<T> sign)
		{
			return Vector512.CopySign<T>(value, sign);
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x00100C3B File Offset: 0x000FEE3B
		void ISimdVector<Vector512<!0>, !0>.CopyTo(Vector512<T> vector, T[] destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x00100C44 File Offset: 0x000FEE44
		void ISimdVector<Vector512<!0>, !0>.CopyTo(Vector512<T> vector, T[] destination, int startIndex)
		{
			vector.CopyTo(destination, startIndex);
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x00100C4E File Offset: 0x000FEE4E
		void ISimdVector<Vector512<!0>, !0>.CopyTo(Vector512<T> vector, Span<T> destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x00100C57 File Offset: 0x000FEE57
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Create(T value)
		{
			return Vector512.Create<T>(value);
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x00100C5F File Offset: 0x000FEE5F
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Create(T[] values)
		{
			return Vector512.Create<T>(values);
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00100C67 File Offset: 0x000FEE67
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Create(T[] values, int index)
		{
			return Vector512.Create<T>(values, index);
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x00100C70 File Offset: 0x000FEE70
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Create(ReadOnlySpan<T> values)
		{
			return Vector512.Create<T>(values);
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x00100C78 File Offset: 0x000FEE78
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.CreateScalar(T value)
		{
			return Vector512.CreateScalar<T>(value);
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x00100C80 File Offset: 0x000FEE80
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.CreateScalarUnsafe(T value)
		{
			return Vector512.CreateScalarUnsafe<T>(value);
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x00100C88 File Offset: 0x000FEE88
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Divide(Vector512<T> left, Vector512<T> right)
		{
			return left / right;
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x00100C91 File Offset: 0x000FEE91
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Divide(Vector512<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x00100C9A File Offset: 0x000FEE9A
		[Intrinsic]
		T ISimdVector<Vector512<!0>, !0>.Dot(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.Dot<T>(left, right);
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x00100CA3 File Offset: 0x000FEEA3
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Equals(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.Equals<T>(left, right);
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x00100CAC File Offset: 0x000FEEAC
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.EqualsAll(Vector512<T> left, Vector512<T> right)
		{
			return left == right;
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x00100CB5 File Offset: 0x000FEEB5
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.EqualsAny(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.EqualsAny<T>(left, right);
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x00100CBE File Offset: 0x000FEEBE
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Floor(Vector512<T> vector)
		{
			return Vector512.Floor<T>(vector);
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x00100CC6 File Offset: 0x000FEEC6
		[Intrinsic]
		T ISimdVector<Vector512<!0>, !0>.GetElement(Vector512<T> vector, int index)
		{
			return vector.GetElement(index);
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x00100CCF File Offset: 0x000FEECF
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.GreaterThan(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.GreaterThan<T>(left, right);
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x00100CD8 File Offset: 0x000FEED8
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.GreaterThanAll(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.GreaterThanAll<T>(left, right);
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x00100CE1 File Offset: 0x000FEEE1
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.GreaterThanAny(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.GreaterThanAny<T>(left, right);
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x00100CEA File Offset: 0x000FEEEA
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.GreaterThanOrEqual(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.GreaterThanOrEqual<T>(left, right);
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x00100CF3 File Offset: 0x000FEEF3
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.GreaterThanOrEqualAll(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.GreaterThanOrEqualAll<T>(left, right);
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x00100CFC File Offset: 0x000FEEFC
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.GreaterThanOrEqualAny(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.GreaterThanOrEqualAny<T>(left, right);
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x00100D05 File Offset: 0x000FEF05
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.LessThan(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.LessThan<T>(left, right);
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x00100D0E File Offset: 0x000FEF0E
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.LessThanAll(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.LessThanAll<T>(left, right);
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00100D17 File Offset: 0x000FEF17
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.LessThanAny(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.LessThanAny<T>(left, right);
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x00100D20 File Offset: 0x000FEF20
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.LessThanOrEqual(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.LessThanOrEqual<T>(left, right);
		}

		// Token: 0x06004E97 RID: 20119 RVA: 0x00100D29 File Offset: 0x000FEF29
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.LessThanOrEqualAll(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.LessThanOrEqualAll<T>(left, right);
		}

		// Token: 0x06004E98 RID: 20120 RVA: 0x00100D32 File Offset: 0x000FEF32
		[Intrinsic]
		bool ISimdVector<Vector512<!0>, !0>.LessThanOrEqualAny(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.LessThanOrEqualAny<T>(left, right);
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x00100D3B File Offset: 0x000FEF3B
		[Intrinsic]
		unsafe Vector512<T> ISimdVector<Vector512<!0>, !0>.Load(T* source)
		{
			return Vector512.Load<T>(source);
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x00100D43 File Offset: 0x000FEF43
		[Intrinsic]
		unsafe Vector512<T> ISimdVector<Vector512<!0>, !0>.LoadAligned(T* source)
		{
			return Vector512.LoadAligned<T>(source);
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x00100D4B File Offset: 0x000FEF4B
		[Intrinsic]
		unsafe Vector512<T> ISimdVector<Vector512<!0>, !0>.LoadAlignedNonTemporal(T* source)
		{
			return Vector512.LoadAlignedNonTemporal<T>(source);
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x000801F8 File Offset: 0x0007E3F8
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source)
		{
			return Vector512.LoadUnsafe<T>(ref source);
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x00100D53 File Offset: 0x000FEF53
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			return Vector512.LoadUnsafe<T>(ref source, elementOffset);
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x00100D5C File Offset: 0x000FEF5C
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Max(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.Max<T>(left, right);
		}

		// Token: 0x06004E9F RID: 20127 RVA: 0x00100D65 File Offset: 0x000FEF65
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MaxMagnitude(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.MaxMagnitude<T>(left, right);
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x00100D6E File Offset: 0x000FEF6E
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MaxMagnitudeNumber(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.MaxMagnitudeNumber<T>(left, right);
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x00100D77 File Offset: 0x000FEF77
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MaxNative(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.MaxNative<T>(left, right);
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x00100D80 File Offset: 0x000FEF80
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MaxNumber(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.MaxNumber<T>(left, right);
		}

		// Token: 0x06004EA3 RID: 20131 RVA: 0x00100D89 File Offset: 0x000FEF89
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Min(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.Min<T>(left, right);
		}

		// Token: 0x06004EA4 RID: 20132 RVA: 0x00100D92 File Offset: 0x000FEF92
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MinMagnitude(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.MinMagnitude<T>(left, right);
		}

		// Token: 0x06004EA5 RID: 20133 RVA: 0x00100D9B File Offset: 0x000FEF9B
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MinMagnitudeNumber(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.MinMagnitudeNumber<T>(left, right);
		}

		// Token: 0x06004EA6 RID: 20134 RVA: 0x00100DA4 File Offset: 0x000FEFA4
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MinNative(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.MinNative<T>(left, right);
		}

		// Token: 0x06004EA7 RID: 20135 RVA: 0x00100DAD File Offset: 0x000FEFAD
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MinNumber(Vector512<T> left, Vector512<T> right)
		{
			return Vector512.MinNumber<T>(left, right);
		}

		// Token: 0x06004EA8 RID: 20136 RVA: 0x00100DB6 File Offset: 0x000FEFB6
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Multiply(Vector512<T> left, Vector512<T> right)
		{
			return left * right;
		}

		// Token: 0x06004EA9 RID: 20137 RVA: 0x00100DBF File Offset: 0x000FEFBF
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Multiply(Vector512<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x06004EAA RID: 20138 RVA: 0x00100DC8 File Offset: 0x000FEFC8
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.MultiplyAddEstimate(Vector512<T> left, Vector512<T> right, Vector512<T> addend)
		{
			return Vector512.MultiplyAddEstimate<T>(left, right, addend);
		}

		// Token: 0x06004EAB RID: 20139 RVA: 0x00100DD2 File Offset: 0x000FEFD2
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Negate(Vector512<T> vector)
		{
			return -vector;
		}

		// Token: 0x06004EAC RID: 20140 RVA: 0x00061A92 File Offset: 0x0005FC92
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.OnesComplement(Vector512<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06004EAD RID: 20141 RVA: 0x00100DDA File Offset: 0x000FEFDA
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Round(Vector512<T> vector)
		{
			return Vector512.Round<T>(vector);
		}

		// Token: 0x06004EAE RID: 20142 RVA: 0x00100DE2 File Offset: 0x000FEFE2
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.ShiftLeft(Vector512<T> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004EAF RID: 20143 RVA: 0x00100DEB File Offset: 0x000FEFEB
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.ShiftRightArithmetic(Vector512<T> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004EB0 RID: 20144 RVA: 0x00100DF4 File Offset: 0x000FEFF4
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.ShiftRightLogical(Vector512<T> vector, int shiftCount)
		{
			return Vector512<T>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004EB1 RID: 20145 RVA: 0x00100DFD File Offset: 0x000FEFFD
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Sqrt(Vector512<T> vector)
		{
			return Vector512.Sqrt<T>(vector);
		}

		// Token: 0x06004EB2 RID: 20146 RVA: 0x00100E05 File Offset: 0x000FF005
		[Intrinsic]
		unsafe void ISimdVector<Vector512<!0>, !0>.Store(Vector512<T> source, T* destination)
		{
			source.Store(destination);
		}

		// Token: 0x06004EB3 RID: 20147 RVA: 0x00100E0E File Offset: 0x000FF00E
		[Intrinsic]
		unsafe void ISimdVector<Vector512<!0>, !0>.StoreAligned(Vector512<T> source, T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x06004EB4 RID: 20148 RVA: 0x00100E17 File Offset: 0x000FF017
		[Intrinsic]
		unsafe void ISimdVector<Vector512<!0>, !0>.StoreAlignedNonTemporal(Vector512<T> source, T* destination)
		{
			source.StoreAlignedNonTemporal(destination);
		}

		// Token: 0x06004EB5 RID: 20149 RVA: 0x00100E20 File Offset: 0x000FF020
		[Intrinsic]
		void ISimdVector<Vector512<!0>, !0>.StoreUnsafe(Vector512<T> vector, ref T destination)
		{
			vector.StoreUnsafe(ref destination);
		}

		// Token: 0x06004EB6 RID: 20150 RVA: 0x00100E29 File Offset: 0x000FF029
		[Intrinsic]
		void ISimdVector<Vector512<!0>, !0>.StoreUnsafe(Vector512<T> vector, ref T destination, UIntPtr elementOffset)
		{
			vector.StoreUnsafe(ref destination, elementOffset);
		}

		// Token: 0x06004EB7 RID: 20151 RVA: 0x00100E33 File Offset: 0x000FF033
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Subtract(Vector512<T> left, Vector512<T> right)
		{
			return left - right;
		}

		// Token: 0x06004EB8 RID: 20152 RVA: 0x00100E3C File Offset: 0x000FF03C
		[Intrinsic]
		T ISimdVector<Vector512<!0>, !0>.Sum(Vector512<T> vector)
		{
			return Vector512.Sum<T>(vector);
		}

		// Token: 0x06004EB9 RID: 20153 RVA: 0x00100E44 File Offset: 0x000FF044
		[Intrinsic]
		T ISimdVector<Vector512<!0>, !0>.ToScalar(Vector512<T> vector)
		{
			return vector.ToScalar<T>();
		}

		// Token: 0x06004EBA RID: 20154 RVA: 0x00100E4C File Offset: 0x000FF04C
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Truncate(Vector512<T> vector)
		{
			return Vector512.Truncate<T>(vector);
		}

		// Token: 0x06004EBB RID: 20155 RVA: 0x00100E54 File Offset: 0x000FF054
		bool ISimdVector<Vector512<!0>, !0>.TryCopyTo(Vector512<T> vector, Span<T> destination)
		{
			return vector.TryCopyTo(destination);
		}

		// Token: 0x06004EBC RID: 20156 RVA: 0x00100E5D File Offset: 0x000FF05D
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.WithElement(Vector512<T> vector, int index, T value)
		{
			return vector.WithElement(index, value);
		}

		// Token: 0x06004EBD RID: 20157 RVA: 0x00100E67 File Offset: 0x000FF067
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.Xor(Vector512<T> left, Vector512<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06004EBE RID: 20158 RVA: 0x00100E70 File Offset: 0x000FF070
		bool ISimdVector<Vector512<!0>, !0>.AnyWhereAllBitsSet(Vector512<T> vector)
		{
			return Vector512.EqualsAny<T>(vector, Vector512<T>.AllBitsSet);
		}

		// Token: 0x06004EBF RID: 20159 RVA: 0x00100E7D File Offset: 0x000FF07D
		bool ISimdVector<Vector512<!0>, !0>.Any(Vector512<T> vector, T value)
		{
			return Vector512.EqualsAny<T>(vector, Vector512.Create<T>(value));
		}

		// Token: 0x06004EC0 RID: 20160 RVA: 0x00100E8C File Offset: 0x000FF08C
		int ISimdVector<Vector512<!0>, !0>.IndexOfLastMatch(Vector512<T> vector)
		{
			ulong value = vector.ExtractMostSignificantBits<T>();
			return 63 - BitOperations.LeadingZeroCount(value);
		}

		// Token: 0x06004EC1 RID: 20161 RVA: 0x00100EA9 File Offset: 0x000FF0A9
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.IsNaN(Vector512<T> vector)
		{
			return Vector512.IsNaN<T>(vector);
		}

		// Token: 0x06004EC2 RID: 20162 RVA: 0x00100EB1 File Offset: 0x000FF0B1
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.IsNegative(Vector512<T> vector)
		{
			return Vector512.IsNegative<T>(vector);
		}

		// Token: 0x06004EC3 RID: 20163 RVA: 0x00100EB9 File Offset: 0x000FF0B9
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.IsPositive(Vector512<T> vector)
		{
			return Vector512.IsPositive<T>(vector);
		}

		// Token: 0x06004EC4 RID: 20164 RVA: 0x00100EC1 File Offset: 0x000FF0C1
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.IsPositiveInfinity(Vector512<T> vector)
		{
			return Vector512.IsPositiveInfinity<T>(vector);
		}

		// Token: 0x06004EC5 RID: 20165 RVA: 0x00100EC9 File Offset: 0x000FF0C9
		[Intrinsic]
		Vector512<T> ISimdVector<Vector512<!0>, !0>.IsZero(Vector512<T> vector)
		{
			return Vector512.IsZero<T>(vector);
		}

		// Token: 0x040011C6 RID: 4550
		internal readonly Vector256<T> _lower;

		// Token: 0x040011C7 RID: 4551
		internal readonly Vector256<T> _upper;
	}
}
