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
	// Token: 0x02000547 RID: 1351
	[NullableContext(1)]
	[Nullable(0)]
	[Intrinsic]
	[DebuggerDisplay("{DisplayString,nq}")]
	[DebuggerTypeProxy(typeof(Vector256DebugView<>))]
	[StructLayout(LayoutKind.Sequential, Size = 32)]
	public readonly struct Vector256<[Nullable(2)] T> : ISimdVector<Vector256<T>, T>, IAdditionOperators<Vector256<T>, Vector256<T>, Vector256<T>>, IBitwiseOperators<Vector256<T>, Vector256<T>, Vector256<T>>, IDivisionOperators<Vector256<T>, Vector256<T>, Vector256<T>>, IEqualityOperators<Vector256<T>, Vector256<T>, bool>, IEquatable<Vector256<T>>, IMultiplyOperators<Vector256<T>, Vector256<T>, Vector256<T>>, IShiftOperators<Vector256<T>, int, Vector256<T>>, ISubtractionOperators<Vector256<T>, Vector256<T>, Vector256<T>>, IUnaryNegationOperators<Vector256<T>, Vector256<T>>, IUnaryPlusOperators<Vector256<T>, Vector256<T>>
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06004CBB RID: 19643 RVA: 0x000FD665 File Offset: 0x000FB865
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> AllBitsSet
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector256.Create<T>(Scalar<T>.AllBitsSet);
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06004CBC RID: 19644 RVA: 0x000FD671 File Offset: 0x000FB871
		public static int Count
		{
			[Intrinsic]
			get
			{
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector128BaseType<T>();
				return 32 / sizeof(T);
			}
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06004CBD RID: 19645 RVA: 0x000FD684 File Offset: 0x000FB884
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Indices
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
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
				Vector256<T> result;
				Unsafe.SkipInit<Vector256<T>>(out result);
				for (int i = 0; i < Vector256<T>.Count; i++)
				{
					result.SetElementUnsafe(i, Scalar<T>.Convert(i));
				}
				return result;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x000FD6BC File Offset: 0x000FB8BC
		public static bool IsSupported
		{
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return typeof(T) == typeof(byte) || typeof(T) == typeof(double) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(float) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr);
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x000FD822 File Offset: 0x000FBA22
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> One
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector256.Create<T>(Scalar<T>.One);
			}
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06004CC0 RID: 19648 RVA: 0x000FD830 File Offset: 0x000FBA30
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> Zero
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
				return default(Vector256<T>);
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06004CC1 RID: 19649 RVA: 0x000FD84B File Offset: 0x000FBA4B
		internal string DisplayString
		{
			get
			{
				if (!Vector256<T>.IsSupported)
				{
					return SR.NotSupported_Type;
				}
				return this.ToString();
			}
		}

		// Token: 0x17000D24 RID: 3364
		public T this[int index]
		{
			get
			{
				return this.GetElement(index);
			}
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x000FD874 File Offset: 0x000FBA74
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(left._lower + right._lower, left._upper + right._upper);
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x000FD89D File Offset: 0x000FBA9D
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator &([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(left._lower & right._lower, left._upper & right._upper);
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x000FD8C6 File Offset: 0x000FBAC6
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator |([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(left._lower | right._lower, left._upper | right._upper);
		}

		// Token: 0x06004CC6 RID: 19654 RVA: 0x000FD8EF File Offset: 0x000FBAEF
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(left._lower / right._lower, left._upper / right._upper);
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x000FD918 File Offset: 0x000FBB18
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, T right)
		{
			return Vector256.Create<T>(left._lower / right, left._upper / right);
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x000FD937 File Offset: 0x000FBB37
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return left._lower == right._lower && left._upper == right._upper;
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x000FD95F File Offset: 0x000FBB5F
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator ^([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(left._lower ^ right._lower, left._upper ^ right._upper);
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x000FD988 File Offset: 0x000FBB88
		[Intrinsic]
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return !(left == right);
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x000FD994 File Offset: 0x000FBB94
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator <<([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value, int shiftCount)
		{
			return Vector256.Create<T>(value._lower << shiftCount, value._upper << shiftCount);
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x000FD9B3 File Offset: 0x000FBBB3
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(left._lower * right._lower, left._upper * right._upper);
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x000FD9DC File Offset: 0x000FBBDC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, T right)
		{
			return Vector256.Create<T>(left._lower * right, left._upper * right);
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x000FD9FB File Offset: 0x000FBBFB
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator *(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return right * left;
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x000FDA04 File Offset: 0x000FBC04
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator ~([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			return Vector256.Create<T>(~vector._lower, ~vector._upper);
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x000FDA21 File Offset: 0x000FBC21
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator >>([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value, int shiftCount)
		{
			return Vector256.Create<T>(value._lower >> shiftCount, value._upper >> shiftCount);
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x000FDA40 File Offset: 0x000FBC40
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> right)
		{
			return Vector256.Create<T>(left._lower - right._lower, left._upper - right._upper);
		}

		// Token: 0x06004CD2 RID: 19666 RVA: 0x000FDA6C File Offset: 0x000FBC6C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return vector ^ Vector256.Create(--0f).As<float, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return vector ^ Vector256.Create(--0.0).As<double, T>();
			}
			return Vector256<T>.Zero - vector;
		}

		// Token: 0x06004CD3 RID: 19667 RVA: 0x000FDAEA File Offset: 0x000FBCEA
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			return value;
		}

		// Token: 0x06004CD4 RID: 19668 RVA: 0x000FDAF2 File Offset: 0x000FBCF2
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector256<T> op_UnsignedRightShift([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> value, int shiftCount)
		{
			return Vector256.Create<T>(Vector128<T>.op_UnsignedRightShift(value._lower, shiftCount), Vector128<T>.op_UnsignedRightShift(value._upper, shiftCount));
		}

		// Token: 0x06004CD5 RID: 19669 RVA: 0x000FDB14 File Offset: 0x000FBD14
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Vector256<T>)
			{
				Vector256<T> other = (Vector256<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06004CD6 RID: 19670 RVA: 0x000FDB39 File Offset: 0x000FBD39
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] Vector256<T> other)
		{
			if (false)
			{
			}
			return this._lower.Equals(other._lower) && this._upper.Equals(other._upper);
		}

		// Token: 0x06004CD7 RID: 19671 RVA: 0x000FDB68 File Offset: 0x000FBD68
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			for (int i = 0; i < Vector256<T>.Count; i++)
			{
				T elementUnsafe = this.GetElementUnsafe(i);
				hashCode.Add<T>(elementUnsafe);
			}
			return hashCode.ToHashCode();
		}

		// Token: 0x06004CD8 RID: 19672 RVA: 0x000FDBA4 File Offset: 0x000FBDA4
		public override string ToString()
		{
			return this.ToString("G", CultureInfo.InvariantCulture);
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x000FDBB8 File Offset: 0x000FBDB8
		private unsafe string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider formatProvider)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector256BaseType<T>();
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			valueStringBuilder.Append('<');
			valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(0))).ToString(format, formatProvider));
			for (int i = 1; i < Vector256<T>.Count; i++)
			{
				valueStringBuilder.Append(numberGroupSeparator);
				valueStringBuilder.Append(' ');
				valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(i))).ToString(format, formatProvider));
			}
			valueStringBuilder.Append('>');
			return valueStringBuilder.ToString();
		}

		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x0001A499 File Offset: 0x00018699
		int ISimdVector<Vector256<!0>, !0>.Alignment
		{
			get
			{
				return 32;
			}
		}

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ISimdVector<Vector256<!0>, !0>.IsHardwareAccelerated
		{
			[Intrinsic]
			get
			{
				return false;
			}
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x000FDC6C File Offset: 0x000FBE6C
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Abs(Vector256<T> vector)
		{
			return Vector256.Abs<T>(vector);
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x000FDC74 File Offset: 0x000FBE74
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Add(Vector256<T> left, Vector256<T> right)
		{
			return left + right;
		}

		// Token: 0x06004CDE RID: 19678 RVA: 0x000FDC7D File Offset: 0x000FBE7D
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.AndNot(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.AndNot<T>(left, right);
		}

		// Token: 0x06004CDF RID: 19679 RVA: 0x000FDC86 File Offset: 0x000FBE86
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.BitwiseAnd(Vector256<T> left, Vector256<T> right)
		{
			return left & right;
		}

		// Token: 0x06004CE0 RID: 19680 RVA: 0x000FDC8F File Offset: 0x000FBE8F
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.BitwiseOr(Vector256<T> left, Vector256<T> right)
		{
			return left | right;
		}

		// Token: 0x06004CE1 RID: 19681 RVA: 0x000FDC98 File Offset: 0x000FBE98
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Ceiling(Vector256<T> vector)
		{
			return Vector256.Ceiling<T>(vector);
		}

		// Token: 0x06004CE2 RID: 19682 RVA: 0x000FDCA0 File Offset: 0x000FBEA0
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Clamp(Vector256<T> value, Vector256<T> min, Vector256<T> max)
		{
			return Vector256.Clamp<T>(value, min, max);
		}

		// Token: 0x06004CE3 RID: 19683 RVA: 0x000FDCAA File Offset: 0x000FBEAA
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.ClampNative(Vector256<T> value, Vector256<T> min, Vector256<T> max)
		{
			return Vector256.ClampNative<T>(value, min, max);
		}

		// Token: 0x06004CE4 RID: 19684 RVA: 0x000FDCB4 File Offset: 0x000FBEB4
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.ConditionalSelect(Vector256<T> condition, Vector256<T> left, Vector256<T> right)
		{
			return Vector256.ConditionalSelect<T>(condition, left, right);
		}

		// Token: 0x06004CE5 RID: 19685 RVA: 0x000FDCBE File Offset: 0x000FBEBE
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.CopySign(Vector256<T> value, Vector256<T> sign)
		{
			return Vector256.CopySign<T>(value, sign);
		}

		// Token: 0x06004CE6 RID: 19686 RVA: 0x000FDCC7 File Offset: 0x000FBEC7
		void ISimdVector<Vector256<!0>, !0>.CopyTo(Vector256<T> vector, T[] destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06004CE7 RID: 19687 RVA: 0x000FDCD0 File Offset: 0x000FBED0
		void ISimdVector<Vector256<!0>, !0>.CopyTo(Vector256<T> vector, T[] destination, int startIndex)
		{
			vector.CopyTo(destination, startIndex);
		}

		// Token: 0x06004CE8 RID: 19688 RVA: 0x000FDCDA File Offset: 0x000FBEDA
		void ISimdVector<Vector256<!0>, !0>.CopyTo(Vector256<T> vector, Span<T> destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06004CE9 RID: 19689 RVA: 0x000FDCE3 File Offset: 0x000FBEE3
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Create(T value)
		{
			return Vector256.Create<T>(value);
		}

		// Token: 0x06004CEA RID: 19690 RVA: 0x000FDCEB File Offset: 0x000FBEEB
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Create(T[] values)
		{
			return Vector256.Create<T>(values);
		}

		// Token: 0x06004CEB RID: 19691 RVA: 0x000FDCF3 File Offset: 0x000FBEF3
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Create(T[] values, int index)
		{
			return Vector256.Create<T>(values, index);
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x000FDCFC File Offset: 0x000FBEFC
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Create(ReadOnlySpan<T> values)
		{
			return Vector256.Create<T>(values);
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x000FDD04 File Offset: 0x000FBF04
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.CreateScalar(T value)
		{
			return Vector256.CreateScalar<T>(value);
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x000FDD0C File Offset: 0x000FBF0C
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.CreateScalarUnsafe(T value)
		{
			return Vector256.CreateScalarUnsafe<T>(value);
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x000FDD14 File Offset: 0x000FBF14
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Divide(Vector256<T> left, Vector256<T> right)
		{
			return left / right;
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x000FDD1D File Offset: 0x000FBF1D
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Divide(Vector256<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x000FDD26 File Offset: 0x000FBF26
		[Intrinsic]
		T ISimdVector<Vector256<!0>, !0>.Dot(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.Dot<T>(left, right);
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x000FDD2F File Offset: 0x000FBF2F
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Equals(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.Equals<T>(left, right);
		}

		// Token: 0x06004CF3 RID: 19699 RVA: 0x000FDD38 File Offset: 0x000FBF38
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.EqualsAll(Vector256<T> left, Vector256<T> right)
		{
			return left == right;
		}

		// Token: 0x06004CF4 RID: 19700 RVA: 0x000FDD41 File Offset: 0x000FBF41
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.EqualsAny(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.EqualsAny<T>(left, right);
		}

		// Token: 0x06004CF5 RID: 19701 RVA: 0x000FDD4A File Offset: 0x000FBF4A
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Floor(Vector256<T> vector)
		{
			return Vector256.Floor<T>(vector);
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x000FDD52 File Offset: 0x000FBF52
		[Intrinsic]
		T ISimdVector<Vector256<!0>, !0>.GetElement(Vector256<T> vector, int index)
		{
			return vector.GetElement(index);
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x000FDD5B File Offset: 0x000FBF5B
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.GreaterThan(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.GreaterThan<T>(left, right);
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x000FDD64 File Offset: 0x000FBF64
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.GreaterThanAll(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.GreaterThanAll<T>(left, right);
		}

		// Token: 0x06004CF9 RID: 19705 RVA: 0x000FDD6D File Offset: 0x000FBF6D
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.GreaterThanAny(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.GreaterThanAny<T>(left, right);
		}

		// Token: 0x06004CFA RID: 19706 RVA: 0x000FDD76 File Offset: 0x000FBF76
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.GreaterThanOrEqual(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.GreaterThanOrEqual<T>(left, right);
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x000FDD7F File Offset: 0x000FBF7F
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.GreaterThanOrEqualAll(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.GreaterThanOrEqualAll<T>(left, right);
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x000FDD88 File Offset: 0x000FBF88
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.GreaterThanOrEqualAny(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.GreaterThanOrEqualAny<T>(left, right);
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x000FDD91 File Offset: 0x000FBF91
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.LessThan(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.LessThan<T>(left, right);
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x000FDD9A File Offset: 0x000FBF9A
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.LessThanAll(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.LessThanAll<T>(left, right);
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x000FDDA3 File Offset: 0x000FBFA3
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.LessThanAny(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.LessThanAny<T>(left, right);
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x000FDDAC File Offset: 0x000FBFAC
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.LessThanOrEqual(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.LessThanOrEqual<T>(left, right);
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x000FDDB5 File Offset: 0x000FBFB5
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.LessThanOrEqualAll(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.LessThanOrEqualAll<T>(left, right);
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x000FDDBE File Offset: 0x000FBFBE
		[Intrinsic]
		bool ISimdVector<Vector256<!0>, !0>.LessThanOrEqualAny(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.LessThanOrEqualAny<T>(left, right);
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x000FDDC7 File Offset: 0x000FBFC7
		[Intrinsic]
		unsafe Vector256<T> ISimdVector<Vector256<!0>, !0>.Load(T* source)
		{
			return Vector256.Load<T>(source);
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x000FDDCF File Offset: 0x000FBFCF
		[Intrinsic]
		unsafe Vector256<T> ISimdVector<Vector256<!0>, !0>.LoadAligned(T* source)
		{
			return Vector256.LoadAligned<T>(source);
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x000FDDD7 File Offset: 0x000FBFD7
		[Intrinsic]
		unsafe Vector256<T> ISimdVector<Vector256<!0>, !0>.LoadAlignedNonTemporal(T* source)
		{
			return Vector256.LoadAlignedNonTemporal<T>(source);
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x000801F0 File Offset: 0x0007E3F0
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source)
		{
			return Vector256.LoadUnsafe<T>(ref source);
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x000FDDDF File Offset: 0x000FBFDF
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			return Vector256.LoadUnsafe<T>(ref source, elementOffset);
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x000FDDE8 File Offset: 0x000FBFE8
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Max(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.Max<T>(left, right);
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x000FDDF1 File Offset: 0x000FBFF1
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MaxMagnitude(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.MaxMagnitude<T>(left, right);
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x000FDDFA File Offset: 0x000FBFFA
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MaxMagnitudeNumber(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.MaxMagnitudeNumber<T>(left, right);
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x000FDE03 File Offset: 0x000FC003
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MaxNative(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.MaxNative<T>(left, right);
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x000FDE0C File Offset: 0x000FC00C
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MaxNumber(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.MaxNumber<T>(left, right);
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x000FDE15 File Offset: 0x000FC015
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Min(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.Min<T>(left, right);
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x000FDE1E File Offset: 0x000FC01E
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MinMagnitude(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.MinMagnitude<T>(left, right);
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x000FDE27 File Offset: 0x000FC027
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MinMagnitudeNumber(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.MinMagnitudeNumber<T>(left, right);
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x000FDE30 File Offset: 0x000FC030
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MinNative(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.MinNative<T>(left, right);
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x000FDE39 File Offset: 0x000FC039
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MinNumber(Vector256<T> left, Vector256<T> right)
		{
			return Vector256.MinNumber<T>(left, right);
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x000FDE42 File Offset: 0x000FC042
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Multiply(Vector256<T> left, Vector256<T> right)
		{
			return left * right;
		}

		// Token: 0x06004D13 RID: 19731 RVA: 0x000FDE4B File Offset: 0x000FC04B
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Multiply(Vector256<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x06004D14 RID: 19732 RVA: 0x000FDE54 File Offset: 0x000FC054
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.MultiplyAddEstimate(Vector256<T> left, Vector256<T> right, Vector256<T> addend)
		{
			return Vector256.MultiplyAddEstimate<T>(left, right, addend);
		}

		// Token: 0x06004D15 RID: 19733 RVA: 0x000FDE5E File Offset: 0x000FC05E
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Negate(Vector256<T> vector)
		{
			return -vector;
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x00061A8A File Offset: 0x0005FC8A
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.OnesComplement(Vector256<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x000FDE66 File Offset: 0x000FC066
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Round(Vector256<T> vector)
		{
			return Vector256.Round<T>(vector);
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x000FDE6E File Offset: 0x000FC06E
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.ShiftLeft(Vector256<T> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06004D19 RID: 19737 RVA: 0x000FDE77 File Offset: 0x000FC077
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.ShiftRightArithmetic(Vector256<T> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06004D1A RID: 19738 RVA: 0x000FDE80 File Offset: 0x000FC080
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.ShiftRightLogical(Vector256<T> vector, int shiftCount)
		{
			return Vector256<T>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06004D1B RID: 19739 RVA: 0x000FDE89 File Offset: 0x000FC089
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Sqrt(Vector256<T> vector)
		{
			return Vector256.Sqrt<T>(vector);
		}

		// Token: 0x06004D1C RID: 19740 RVA: 0x000FDE91 File Offset: 0x000FC091
		[Intrinsic]
		unsafe void ISimdVector<Vector256<!0>, !0>.Store(Vector256<T> source, T* destination)
		{
			source.Store(destination);
		}

		// Token: 0x06004D1D RID: 19741 RVA: 0x000FDE9A File Offset: 0x000FC09A
		[Intrinsic]
		unsafe void ISimdVector<Vector256<!0>, !0>.StoreAligned(Vector256<T> source, T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x000FDEA3 File Offset: 0x000FC0A3
		[Intrinsic]
		unsafe void ISimdVector<Vector256<!0>, !0>.StoreAlignedNonTemporal(Vector256<T> source, T* destination)
		{
			source.StoreAlignedNonTemporal(destination);
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x000FDEAC File Offset: 0x000FC0AC
		[Intrinsic]
		void ISimdVector<Vector256<!0>, !0>.StoreUnsafe(Vector256<T> vector, ref T destination)
		{
			vector.StoreUnsafe(ref destination);
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x000FDEB5 File Offset: 0x000FC0B5
		[Intrinsic]
		void ISimdVector<Vector256<!0>, !0>.StoreUnsafe(Vector256<T> vector, ref T destination, UIntPtr elementOffset)
		{
			vector.StoreUnsafe(ref destination, elementOffset);
		}

		// Token: 0x06004D21 RID: 19745 RVA: 0x000FDEBF File Offset: 0x000FC0BF
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Subtract(Vector256<T> left, Vector256<T> right)
		{
			return left - right;
		}

		// Token: 0x06004D22 RID: 19746 RVA: 0x000FDEC8 File Offset: 0x000FC0C8
		[Intrinsic]
		T ISimdVector<Vector256<!0>, !0>.Sum(Vector256<T> vector)
		{
			return Vector256.Sum<T>(vector);
		}

		// Token: 0x06004D23 RID: 19747 RVA: 0x000FDED0 File Offset: 0x000FC0D0
		[Intrinsic]
		T ISimdVector<Vector256<!0>, !0>.ToScalar(Vector256<T> vector)
		{
			return vector.ToScalar<T>();
		}

		// Token: 0x06004D24 RID: 19748 RVA: 0x000FDED8 File Offset: 0x000FC0D8
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Truncate(Vector256<T> vector)
		{
			return Vector256.Truncate<T>(vector);
		}

		// Token: 0x06004D25 RID: 19749 RVA: 0x000FDEE0 File Offset: 0x000FC0E0
		bool ISimdVector<Vector256<!0>, !0>.TryCopyTo(Vector256<T> vector, Span<T> destination)
		{
			return vector.TryCopyTo(destination);
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x000FDEE9 File Offset: 0x000FC0E9
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.WithElement(Vector256<T> vector, int index, T value)
		{
			return vector.WithElement(index, value);
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x000FDEF3 File Offset: 0x000FC0F3
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.Xor(Vector256<T> left, Vector256<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x000FDEFC File Offset: 0x000FC0FC
		bool ISimdVector<Vector256<!0>, !0>.AnyWhereAllBitsSet(Vector256<T> vector)
		{
			return Vector256.EqualsAny<T>(vector, Vector256<T>.AllBitsSet);
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x000FDF09 File Offset: 0x000FC109
		bool ISimdVector<Vector256<!0>, !0>.Any(Vector256<T> vector, T value)
		{
			return Vector256.EqualsAny<T>(vector, Vector256.Create<T>(value));
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x000FDF18 File Offset: 0x000FC118
		int ISimdVector<Vector256<!0>, !0>.IndexOfLastMatch(Vector256<T> vector)
		{
			uint value = vector.ExtractMostSignificantBits<T>();
			return 31 - BitOperations.LeadingZeroCount(value);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x000FDF35 File Offset: 0x000FC135
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.IsNaN(Vector256<T> vector)
		{
			return Vector256.IsNaN<T>(vector);
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x000FDF3D File Offset: 0x000FC13D
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.IsNegative(Vector256<T> vector)
		{
			return Vector256.IsNegative<T>(vector);
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x000FDF45 File Offset: 0x000FC145
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.IsPositive(Vector256<T> vector)
		{
			return Vector256.IsPositive<T>(vector);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x000FDF4D File Offset: 0x000FC14D
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.IsPositiveInfinity(Vector256<T> vector)
		{
			return Vector256.IsPositiveInfinity<T>(vector);
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x000FDF55 File Offset: 0x000FC155
		[Intrinsic]
		Vector256<T> ISimdVector<Vector256<!0>, !0>.IsZero(Vector256<T> vector)
		{
			return Vector256.IsZero<T>(vector);
		}

		// Token: 0x040011C3 RID: 4547
		internal readonly Vector128<T> _lower;

		// Token: 0x040011C4 RID: 4548
		internal readonly Vector128<T> _upper;
	}
}
