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
	// Token: 0x02000544 RID: 1348
	[NullableContext(1)]
	[Nullable(0)]
	[Intrinsic]
	[DebuggerDisplay("{DisplayString,nq}")]
	[DebuggerTypeProxy(typeof(Vector128DebugView<>))]
	[StructLayout(LayoutKind.Sequential, Size = 16)]
	public readonly struct Vector128<[Nullable(2)] T> : ISimdVector<Vector128<T>, T>, IAdditionOperators<Vector128<T>, Vector128<T>, Vector128<T>>, IBitwiseOperators<Vector128<T>, Vector128<T>, Vector128<T>>, IDivisionOperators<Vector128<T>, Vector128<T>, Vector128<T>>, IEqualityOperators<Vector128<T>, Vector128<T>, bool>, IEquatable<Vector128<T>>, IMultiplyOperators<Vector128<T>, Vector128<T>, Vector128<T>>, IShiftOperators<Vector128<T>, int, Vector128<T>>, ISubtractionOperators<Vector128<T>, Vector128<T>, Vector128<T>>, IUnaryNegationOperators<Vector128<T>, Vector128<T>>, IUnaryPlusOperators<Vector128<T>, Vector128<T>>
	{
		// Token: 0x17000D06 RID: 3334
		// (get) Token: 0x06004B23 RID: 19235 RVA: 0x000FA745 File Offset: 0x000F8945
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> AllBitsSet
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector128.Create<T>(Scalar<T>.AllBitsSet);
			}
		}

		// Token: 0x17000D07 RID: 3335
		// (get) Token: 0x06004B24 RID: 19236 RVA: 0x000FA751 File Offset: 0x000F8951
		public static int Count
		{
			[Intrinsic]
			get
			{
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
				return 16 / sizeof(T);
			}
		}

		// Token: 0x17000D08 RID: 3336
		// (get) Token: 0x06004B25 RID: 19237 RVA: 0x000FA764 File Offset: 0x000F8964
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Indices
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
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
				Vector128<T> result;
				Unsafe.SkipInit<Vector128<T>>(out result);
				for (int i = 0; i < Vector128<T>.Count; i++)
				{
					result.SetElementUnsafe(i, Scalar<T>.Convert(i));
				}
				return result;
			}
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x06004B26 RID: 19238 RVA: 0x000FA79C File Offset: 0x000F899C
		public static bool IsSupported
		{
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return typeof(T) == typeof(byte) || typeof(T) == typeof(double) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(float) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr);
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06004B27 RID: 19239 RVA: 0x000FA902 File Offset: 0x000F8B02
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> One
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector128.Create<T>(Scalar<T>.One);
			}
		}

		// Token: 0x17000D0B RID: 3339
		// (get) Token: 0x06004B28 RID: 19240 RVA: 0x000FA910 File Offset: 0x000F8B10
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> Zero
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
				return default(Vector128<T>);
			}
		}

		// Token: 0x17000D0C RID: 3340
		// (get) Token: 0x06004B29 RID: 19241 RVA: 0x000FA92B File Offset: 0x000F8B2B
		internal string DisplayString
		{
			get
			{
				if (!Vector128<T>.IsSupported)
				{
					return SR.NotSupported_Type;
				}
				return this.ToString();
			}
		}

		// Token: 0x17000D0D RID: 3341
		public T this[int index]
		{
			get
			{
				return this.GetElement(index);
			}
		}

		// Token: 0x06004B2B RID: 19243 RVA: 0x000FA954 File Offset: 0x000F8B54
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(left._lower + right._lower, left._upper + right._upper);
		}

		// Token: 0x06004B2C RID: 19244 RVA: 0x000FA97D File Offset: 0x000F8B7D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator &([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(left._lower & right._lower, left._upper & right._upper);
		}

		// Token: 0x06004B2D RID: 19245 RVA: 0x000FA9A6 File Offset: 0x000F8BA6
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator |([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(left._lower | right._lower, left._upper | right._upper);
		}

		// Token: 0x06004B2E RID: 19246 RVA: 0x000FA9CF File Offset: 0x000F8BCF
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(left._lower / right._lower, left._upper / right._upper);
		}

		// Token: 0x06004B2F RID: 19247 RVA: 0x000FA9F8 File Offset: 0x000F8BF8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, T right)
		{
			return Vector128.Create<T>(left._lower / right, left._upper / right);
		}

		// Token: 0x06004B30 RID: 19248 RVA: 0x000FAA17 File Offset: 0x000F8C17
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return left._lower == right._lower && left._upper == right._upper;
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x000FAA3F File Offset: 0x000F8C3F
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator ^([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(left._lower ^ right._lower, left._upper ^ right._upper);
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x000FAA68 File Offset: 0x000F8C68
		[Intrinsic]
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return !(left == right);
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x000FAA74 File Offset: 0x000F8C74
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator <<([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value, int shiftCount)
		{
			return Vector128.Create<T>(value._lower << shiftCount, value._upper << shiftCount);
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x000FAA93 File Offset: 0x000F8C93
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(left._lower * right._lower, left._upper * right._upper);
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x000FAABC File Offset: 0x000F8CBC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, T right)
		{
			return Vector128.Create<T>(left._lower * right, left._upper * right);
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x000FAADB File Offset: 0x000F8CDB
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator *(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return right * left;
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x000FAAE4 File Offset: 0x000F8CE4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator ~([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			return Vector128.Create<T>(~vector._lower, ~vector._upper);
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x000FAB01 File Offset: 0x000F8D01
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator >>([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value, int shiftCount)
		{
			return Vector128.Create<T>(value._lower >> shiftCount, value._upper >> shiftCount);
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x000FAB20 File Offset: 0x000F8D20
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> right)
		{
			return Vector128.Create<T>(left._lower - right._lower, left._upper - right._upper);
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x000FAB4C File Offset: 0x000F8D4C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return vector ^ Vector128.Create(--0f).As<float, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return vector ^ Vector128.Create(--0.0).As<double, T>();
			}
			return Vector128<T>.Zero - vector;
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x000FABCA File Offset: 0x000F8DCA
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			return value;
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x000FABD2 File Offset: 0x000F8DD2
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector128<T> op_UnsignedRightShift([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> value, int shiftCount)
		{
			return Vector128.Create<T>(Vector64<T>.op_UnsignedRightShift(value._lower, shiftCount), Vector64<T>.op_UnsignedRightShift(value._upper, shiftCount));
		}

		// Token: 0x06004B3D RID: 19261 RVA: 0x000FABF4 File Offset: 0x000F8DF4
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Vector128<T>)
			{
				Vector128<T> other = (Vector128<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06004B3E RID: 19262 RVA: 0x000FAC19 File Offset: 0x000F8E19
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static bool EqualsFloatingPoint(Vector128<T> lhs, Vector128<T> rhs)
		{
			return (Vector128.Equals<T>(lhs, rhs) | ~(Vector128.Equals<T>(lhs, lhs) | Vector128.Equals<T>(rhs, rhs))).AsInt32<T>() == Vector128<int>.AllBitsSet;
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x000FAC50 File Offset: 0x000F8E50
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] Vector128<T> other)
		{
			if (!Vector128.IsHardwareAccelerated)
			{
				return this._lower.Equals(other._lower) && this._upper.Equals(other._upper);
			}
			if (typeof(T) == typeof(double) || typeof(T) == typeof(float))
			{
				return Vector128<T>.EqualsFloatingPoint(this, other);
			}
			return this == other;
		}

		// Token: 0x06004B40 RID: 19264 RVA: 0x000FACDC File Offset: 0x000F8EDC
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			for (int i = 0; i < Vector128<T>.Count; i++)
			{
				T elementUnsafe = this.GetElementUnsafe(i);
				hashCode.Add<T>(elementUnsafe);
			}
			return hashCode.ToHashCode();
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x000FAD18 File Offset: 0x000F8F18
		public override string ToString()
		{
			return this.ToString("G", CultureInfo.InvariantCulture);
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x000FAD2C File Offset: 0x000F8F2C
		private unsafe string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider formatProvider)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			valueStringBuilder.Append('<');
			valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(0))).ToString(format, formatProvider));
			for (int i = 1; i < Vector128<T>.Count; i++)
			{
				valueStringBuilder.Append(numberGroupSeparator);
				valueStringBuilder.Append(' ');
				valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(i))).ToString(format, formatProvider));
			}
			valueStringBuilder.Append('>');
			return valueStringBuilder.ToString();
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06004B43 RID: 19267 RVA: 0x00027484 File Offset: 0x00025684
		int ISimdVector<Vector128<!0>, !0>.Alignment
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06004B44 RID: 19268 RVA: 0x000F7EFC File Offset: 0x000F60FC
		bool ISimdVector<Vector128<!0>, !0>.IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return Vector128.IsHardwareAccelerated;
			}
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x000FADE0 File Offset: 0x000F8FE0
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Abs(Vector128<T> vector)
		{
			return Vector128.Abs<T>(vector);
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x000FADE8 File Offset: 0x000F8FE8
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Add(Vector128<T> left, Vector128<T> right)
		{
			return left + right;
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x000FADF1 File Offset: 0x000F8FF1
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.AndNot(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.AndNot<T>(left, right);
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x000FADFA File Offset: 0x000F8FFA
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.BitwiseAnd(Vector128<T> left, Vector128<T> right)
		{
			return left & right;
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x000FAE03 File Offset: 0x000F9003
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.BitwiseOr(Vector128<T> left, Vector128<T> right)
		{
			return left | right;
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x000FAE0C File Offset: 0x000F900C
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Ceiling(Vector128<T> vector)
		{
			return Vector128.Ceiling<T>(vector);
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x000FAE14 File Offset: 0x000F9014
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Clamp(Vector128<T> value, Vector128<T> min, Vector128<T> max)
		{
			return Vector128.Clamp<T>(value, min, max);
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x000FAE1E File Offset: 0x000F901E
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.ClampNative(Vector128<T> value, Vector128<T> min, Vector128<T> max)
		{
			return Vector128.ClampNative<T>(value, min, max);
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x000FAE28 File Offset: 0x000F9028
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.ConditionalSelect(Vector128<T> condition, Vector128<T> left, Vector128<T> right)
		{
			return Vector128.ConditionalSelect<T>(condition, left, right);
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x000FAE32 File Offset: 0x000F9032
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.CopySign(Vector128<T> value, Vector128<T> sign)
		{
			return Vector128.CopySign<T>(value, sign);
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x000FAE3B File Offset: 0x000F903B
		void ISimdVector<Vector128<!0>, !0>.CopyTo(Vector128<T> vector, T[] destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06004B50 RID: 19280 RVA: 0x000FAE44 File Offset: 0x000F9044
		void ISimdVector<Vector128<!0>, !0>.CopyTo(Vector128<T> vector, T[] destination, int startIndex)
		{
			vector.CopyTo(destination, startIndex);
		}

		// Token: 0x06004B51 RID: 19281 RVA: 0x000FAE4E File Offset: 0x000F904E
		void ISimdVector<Vector128<!0>, !0>.CopyTo(Vector128<T> vector, Span<T> destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06004B52 RID: 19282 RVA: 0x000FAE57 File Offset: 0x000F9057
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Create(T value)
		{
			return Vector128.Create<T>(value);
		}

		// Token: 0x06004B53 RID: 19283 RVA: 0x000FAE5F File Offset: 0x000F905F
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Create(T[] values)
		{
			return Vector128.Create<T>(values);
		}

		// Token: 0x06004B54 RID: 19284 RVA: 0x000FAE67 File Offset: 0x000F9067
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Create(T[] values, int index)
		{
			return Vector128.Create<T>(values, index);
		}

		// Token: 0x06004B55 RID: 19285 RVA: 0x000FAE70 File Offset: 0x000F9070
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Create(ReadOnlySpan<T> values)
		{
			return Vector128.Create<T>(values);
		}

		// Token: 0x06004B56 RID: 19286 RVA: 0x000FAE78 File Offset: 0x000F9078
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.CreateScalar(T value)
		{
			return Vector128.CreateScalar<T>(value);
		}

		// Token: 0x06004B57 RID: 19287 RVA: 0x000FAE80 File Offset: 0x000F9080
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.CreateScalarUnsafe(T value)
		{
			return Vector128.CreateScalarUnsafe<T>(value);
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x000FAE88 File Offset: 0x000F9088
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Divide(Vector128<T> left, Vector128<T> right)
		{
			return left / right;
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x000FAE91 File Offset: 0x000F9091
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Divide(Vector128<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x000FAE9A File Offset: 0x000F909A
		[Intrinsic]
		T ISimdVector<Vector128<!0>, !0>.Dot(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.Dot<T>(left, right);
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x000FAEA3 File Offset: 0x000F90A3
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Equals(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.Equals<T>(left, right);
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x000FAEAC File Offset: 0x000F90AC
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.EqualsAll(Vector128<T> left, Vector128<T> right)
		{
			return left == right;
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x000FAEB5 File Offset: 0x000F90B5
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.EqualsAny(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.EqualsAny<T>(left, right);
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x000FAEBE File Offset: 0x000F90BE
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Floor(Vector128<T> vector)
		{
			return Vector128.Floor<T>(vector);
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x000FAEC6 File Offset: 0x000F90C6
		[Intrinsic]
		T ISimdVector<Vector128<!0>, !0>.GetElement(Vector128<T> vector, int index)
		{
			return vector.GetElement(index);
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x000FAECF File Offset: 0x000F90CF
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.GreaterThan(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.GreaterThan<T>(left, right);
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x000FAED8 File Offset: 0x000F90D8
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.GreaterThanAll(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.GreaterThanAll<T>(left, right);
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x000FAEE1 File Offset: 0x000F90E1
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.GreaterThanAny(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.GreaterThanAny<T>(left, right);
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x000FAEEA File Offset: 0x000F90EA
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.GreaterThanOrEqual(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.GreaterThanOrEqual<T>(left, right);
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x000FAEF3 File Offset: 0x000F90F3
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.GreaterThanOrEqualAll(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.GreaterThanOrEqualAll<T>(left, right);
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x000FAEFC File Offset: 0x000F90FC
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.GreaterThanOrEqualAny(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.GreaterThanOrEqualAny<T>(left, right);
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x000FAF05 File Offset: 0x000F9105
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.LessThan(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.LessThan<T>(left, right);
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x000FAF0E File Offset: 0x000F910E
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.LessThanAll(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.LessThanAll<T>(left, right);
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x000FAF17 File Offset: 0x000F9117
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.LessThanAny(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.LessThanAny<T>(left, right);
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x000FAF20 File Offset: 0x000F9120
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.LessThanOrEqual(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.LessThanOrEqual<T>(left, right);
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x000FAF29 File Offset: 0x000F9129
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.LessThanOrEqualAll(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.LessThanOrEqualAll<T>(left, right);
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x000FAF32 File Offset: 0x000F9132
		[Intrinsic]
		bool ISimdVector<Vector128<!0>, !0>.LessThanOrEqualAny(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.LessThanOrEqualAny<T>(left, right);
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x000FAF3B File Offset: 0x000F913B
		[Intrinsic]
		unsafe Vector128<T> ISimdVector<Vector128<!0>, !0>.Load(T* source)
		{
			return Vector128.Load<T>(source);
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x000FAF43 File Offset: 0x000F9143
		[Intrinsic]
		unsafe Vector128<T> ISimdVector<Vector128<!0>, !0>.LoadAligned(T* source)
		{
			return Vector128.LoadAligned<T>(source);
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x000FAF4B File Offset: 0x000F914B
		[Intrinsic]
		unsafe Vector128<T> ISimdVector<Vector128<!0>, !0>.LoadAlignedNonTemporal(T* source)
		{
			return Vector128.LoadAlignedNonTemporal<T>(source);
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x000801E8 File Offset: 0x0007E3E8
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source)
		{
			return Vector128.LoadUnsafe<T>(ref source);
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x000FAF53 File Offset: 0x000F9153
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			return Vector128.LoadUnsafe<T>(ref source, elementOffset);
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x000FAF5C File Offset: 0x000F915C
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Max(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.Max<T>(left, right);
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x000FAF65 File Offset: 0x000F9165
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MaxMagnitude(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.MaxMagnitude<T>(left, right);
		}

		// Token: 0x06004B73 RID: 19315 RVA: 0x000FAF6E File Offset: 0x000F916E
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MaxMagnitudeNumber(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.MaxMagnitudeNumber<T>(left, right);
		}

		// Token: 0x06004B74 RID: 19316 RVA: 0x000FAF77 File Offset: 0x000F9177
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MaxNative(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.MaxNative<T>(left, right);
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x000FAF80 File Offset: 0x000F9180
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MaxNumber(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.MaxNumber<T>(left, right);
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x000FAF89 File Offset: 0x000F9189
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Min(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.Min<T>(left, right);
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x000FAF92 File Offset: 0x000F9192
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MinMagnitude(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.MinMagnitude<T>(left, right);
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x000FAF9B File Offset: 0x000F919B
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MinMagnitudeNumber(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.MinMagnitudeNumber<T>(left, right);
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x000FAFA4 File Offset: 0x000F91A4
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MinNative(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.MinNative<T>(left, right);
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x000FAFAD File Offset: 0x000F91AD
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MinNumber(Vector128<T> left, Vector128<T> right)
		{
			return Vector128.MinNumber<T>(left, right);
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x000FAFB6 File Offset: 0x000F91B6
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Multiply(Vector128<T> left, Vector128<T> right)
		{
			return left * right;
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x000FAFBF File Offset: 0x000F91BF
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Multiply(Vector128<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x000FAFC8 File Offset: 0x000F91C8
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.MultiplyAddEstimate(Vector128<T> left, Vector128<T> right, Vector128<T> addend)
		{
			return Vector128.MultiplyAddEstimate<T>(left, right, addend);
		}

		// Token: 0x06004B7E RID: 19326 RVA: 0x000FAFD2 File Offset: 0x000F91D2
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Negate(Vector128<T> vector)
		{
			return -vector;
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x00061A82 File Offset: 0x0005FC82
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.OnesComplement(Vector128<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06004B80 RID: 19328 RVA: 0x000FAFDA File Offset: 0x000F91DA
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Round(Vector128<T> vector)
		{
			return Vector128.Round<T>(vector);
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x000FAFE2 File Offset: 0x000F91E2
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.ShiftLeft(Vector128<T> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x000FAFEB File Offset: 0x000F91EB
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.ShiftRightArithmetic(Vector128<T> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004B83 RID: 19331 RVA: 0x000FAFF4 File Offset: 0x000F91F4
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.ShiftRightLogical(Vector128<T> vector, int shiftCount)
		{
			return Vector128<T>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004B84 RID: 19332 RVA: 0x000FAFFD File Offset: 0x000F91FD
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Sqrt(Vector128<T> vector)
		{
			return Vector128.Sqrt<T>(vector);
		}

		// Token: 0x06004B85 RID: 19333 RVA: 0x000FB005 File Offset: 0x000F9205
		[Intrinsic]
		unsafe void ISimdVector<Vector128<!0>, !0>.Store(Vector128<T> source, T* destination)
		{
			source.Store(destination);
		}

		// Token: 0x06004B86 RID: 19334 RVA: 0x000FB00E File Offset: 0x000F920E
		[Intrinsic]
		unsafe void ISimdVector<Vector128<!0>, !0>.StoreAligned(Vector128<T> source, T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x06004B87 RID: 19335 RVA: 0x000FB017 File Offset: 0x000F9217
		[Intrinsic]
		unsafe void ISimdVector<Vector128<!0>, !0>.StoreAlignedNonTemporal(Vector128<T> source, T* destination)
		{
			source.StoreAlignedNonTemporal(destination);
		}

		// Token: 0x06004B88 RID: 19336 RVA: 0x000FB020 File Offset: 0x000F9220
		[Intrinsic]
		void ISimdVector<Vector128<!0>, !0>.StoreUnsafe(Vector128<T> vector, ref T destination)
		{
			vector.StoreUnsafe(ref destination);
		}

		// Token: 0x06004B89 RID: 19337 RVA: 0x000FB029 File Offset: 0x000F9229
		[Intrinsic]
		void ISimdVector<Vector128<!0>, !0>.StoreUnsafe(Vector128<T> vector, ref T destination, UIntPtr elementOffset)
		{
			vector.StoreUnsafe(ref destination, elementOffset);
		}

		// Token: 0x06004B8A RID: 19338 RVA: 0x000FB033 File Offset: 0x000F9233
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Subtract(Vector128<T> left, Vector128<T> right)
		{
			return left - right;
		}

		// Token: 0x06004B8B RID: 19339 RVA: 0x000FB03C File Offset: 0x000F923C
		[Intrinsic]
		T ISimdVector<Vector128<!0>, !0>.Sum(Vector128<T> vector)
		{
			return Vector128.Sum<T>(vector);
		}

		// Token: 0x06004B8C RID: 19340 RVA: 0x000FB044 File Offset: 0x000F9244
		[Intrinsic]
		T ISimdVector<Vector128<!0>, !0>.ToScalar(Vector128<T> vector)
		{
			return vector.ToScalar<T>();
		}

		// Token: 0x06004B8D RID: 19341 RVA: 0x000FB04C File Offset: 0x000F924C
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Truncate(Vector128<T> vector)
		{
			return Vector128.Truncate<T>(vector);
		}

		// Token: 0x06004B8E RID: 19342 RVA: 0x000FB054 File Offset: 0x000F9254
		bool ISimdVector<Vector128<!0>, !0>.TryCopyTo(Vector128<T> vector, Span<T> destination)
		{
			return vector.TryCopyTo(destination);
		}

		// Token: 0x06004B8F RID: 19343 RVA: 0x000FB05D File Offset: 0x000F925D
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.WithElement(Vector128<T> vector, int index, T value)
		{
			return vector.WithElement(index, value);
		}

		// Token: 0x06004B90 RID: 19344 RVA: 0x000FB067 File Offset: 0x000F9267
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.Xor(Vector128<T> left, Vector128<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06004B91 RID: 19345 RVA: 0x000FB070 File Offset: 0x000F9270
		bool ISimdVector<Vector128<!0>, !0>.AnyWhereAllBitsSet(Vector128<T> vector)
		{
			return Vector128.EqualsAny<T>(vector, Vector128<T>.AllBitsSet);
		}

		// Token: 0x06004B92 RID: 19346 RVA: 0x000FB07D File Offset: 0x000F927D
		bool ISimdVector<Vector128<!0>, !0>.Any(Vector128<T> vector, T value)
		{
			return Vector128.EqualsAny<T>(vector, Vector128.Create<T>(value));
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x000FB08C File Offset: 0x000F928C
		int ISimdVector<Vector128<!0>, !0>.IndexOfLastMatch(Vector128<T> vector)
		{
			uint value = vector.ExtractMostSignificantBits<T>();
			return 31 - BitOperations.LeadingZeroCount(value);
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x000FB0A9 File Offset: 0x000F92A9
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.IsNaN(Vector128<T> vector)
		{
			return Vector128.IsNaN<T>(vector);
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x000FB0B1 File Offset: 0x000F92B1
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.IsNegative(Vector128<T> vector)
		{
			return Vector128.IsNegative<T>(vector);
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x000FB0B9 File Offset: 0x000F92B9
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.IsPositive(Vector128<T> vector)
		{
			return Vector128.IsPositive<T>(vector);
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x000FB0C1 File Offset: 0x000F92C1
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.IsPositiveInfinity(Vector128<T> vector)
		{
			return Vector128.IsPositiveInfinity<T>(vector);
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x000FB0C9 File Offset: 0x000F92C9
		[Intrinsic]
		Vector128<T> ISimdVector<Vector128<!0>, !0>.IsZero(Vector128<T> vector)
		{
			return Vector128.IsZero<T>(vector);
		}

		// Token: 0x040011C0 RID: 4544
		internal readonly Vector64<T> _lower;

		// Token: 0x040011C1 RID: 4545
		internal readonly Vector64<T> _upper;
	}
}
