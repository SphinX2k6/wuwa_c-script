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
	// Token: 0x0200054D RID: 1357
	[NullableContext(1)]
	[Nullable(0)]
	[Intrinsic]
	[DebuggerDisplay("{DisplayString,nq}")]
	[DebuggerTypeProxy(typeof(Vector64DebugView<>))]
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	public readonly struct Vector64<[Nullable(2)] T> : ISimdVector<Vector64<T>, T>, IAdditionOperators<Vector64<T>, Vector64<T>, Vector64<T>>, IBitwiseOperators<Vector64<T>, Vector64<T>, Vector64<T>>, IDivisionOperators<Vector64<T>, Vector64<T>, Vector64<T>>, IEqualityOperators<Vector64<T>, Vector64<T>, bool>, IEquatable<Vector64<T>>, IMultiplyOperators<Vector64<T>, Vector64<T>, Vector64<T>>, IShiftOperators<Vector64<T>, int, Vector64<T>>, ISubtractionOperators<Vector64<T>, Vector64<T>, Vector64<T>>, IUnaryNegationOperators<Vector64<T>, Vector64<T>>, IUnaryPlusOperators<Vector64<T>, Vector64<T>>
	{
		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06004FD5 RID: 20437 RVA: 0x00103AFA File Offset: 0x00101CFA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> AllBitsSet
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector64.Create<T>(Scalar<T>.AllBitsSet);
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06004FD6 RID: 20438 RVA: 0x00103B06 File Offset: 0x00101D06
		public static int Count
		{
			[Intrinsic]
			get
			{
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
				return 8 / sizeof(T);
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06004FD7 RID: 20439 RVA: 0x00103B18 File Offset: 0x00101D18
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Indices
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
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
				Vector64<T> result;
				Unsafe.SkipInit<Vector64<T>>(out result);
				for (int i = 0; i < Vector64<T>.Count; i++)
				{
					result.SetElementUnsafe(i, Scalar<T>.Convert(i));
				}
				return result;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06004FD8 RID: 20440 RVA: 0x00103B50 File Offset: 0x00101D50
		public static bool IsSupported
		{
			[Intrinsic]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return typeof(T) == typeof(byte) || typeof(T) == typeof(double) || typeof(T) == typeof(short) || typeof(T) == typeof(int) || typeof(T) == typeof(long) || typeof(T) == typeof(IntPtr) || typeof(T) == typeof(sbyte) || typeof(T) == typeof(float) || typeof(T) == typeof(ushort) || typeof(T) == typeof(uint) || typeof(T) == typeof(ulong) || typeof(T) == typeof(UIntPtr);
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06004FD9 RID: 20441 RVA: 0x00103CB6 File Offset: 0x00101EB6
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> One
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return Vector64.Create<T>(Scalar<T>.One);
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06004FDA RID: 20442 RVA: 0x00103CC4 File Offset: 0x00101EC4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> Zero
		{
			[Intrinsic]
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
				return default(Vector64<T>);
			}
		}

		// Token: 0x17000D51 RID: 3409
		// (get) Token: 0x06004FDB RID: 20443 RVA: 0x00103CDF File Offset: 0x00101EDF
		internal string DisplayString
		{
			get
			{
				if (!Vector64<T>.IsSupported)
				{
					return SR.NotSupported_Type;
				}
				return this.ToString();
			}
		}

		// Token: 0x17000D52 RID: 3410
		public T this[int index]
		{
			get
			{
				return this.GetElement(index);
			}
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x00103D08 File Offset: 0x00101F08
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Add(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x00103D4C File Offset: 0x00101F4C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector64<T>operator &([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			*Unsafe.AsRef<ulong>(ref result._00) = (left._00 & right._00);
			return result;
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x00103D80 File Offset: 0x00101F80
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector64<T>operator |([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			*Unsafe.AsRef<ulong>(ref result._00) = (left._00 | right._00);
			return result;
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x00103DB4 File Offset: 0x00101FB4
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Divide(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00103DF8 File Offset: 0x00101FF8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator /([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, T right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Divide(left.GetElementUnsafe(i), right);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00103E38 File Offset: 0x00102038
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (!Scalar<T>.Equals(left.GetElementUnsafe(i), right.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00103E70 File Offset: 0x00102070
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector64<T>operator ^([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			*Unsafe.AsRef<ulong>(ref result._00) = (left._00 ^ right._00);
			return result;
		}

		// Token: 0x06004FE4 RID: 20452 RVA: 0x00103EA4 File Offset: 0x001020A4
		[Intrinsic]
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return !(left == right);
		}

		// Token: 0x06004FE5 RID: 20453 RVA: 0x00103EB0 File Offset: 0x001020B0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator <<([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value, int shiftCount)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value2 = Scalar<T>.ShiftLeft(value.GetElementUnsafe(i), shiftCount);
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06004FE6 RID: 20454 RVA: 0x00103EF0 File Offset: 0x001020F0
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Multiply(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FE7 RID: 20455 RVA: 0x00103F34 File Offset: 0x00102134
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator *([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, T right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Multiply(left.GetElementUnsafe(i), right);
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FE8 RID: 20456 RVA: 0x00103F71 File Offset: 0x00102171
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator *(T left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			return right * left;
		}

		// Token: 0x06004FE9 RID: 20457 RVA: 0x00103F7C File Offset: 0x0010217C
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe static Vector64<T>operator ~([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			*Unsafe.AsRef<ulong>(ref result._00) = ~vector._00;
			return result;
		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00103FAC File Offset: 0x001021AC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator >>([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value, int shiftCount)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value2 = Scalar<T>.ShiftRightArithmetic(value.GetElementUnsafe(i), shiftCount);
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00103FEC File Offset: 0x001021EC
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> right)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value = Scalar<T>.Subtract(left.GetElementUnsafe(i), right.GetElementUnsafe(i));
				result.SetElementUnsafe(i, value);
			}
			return result;
		}

		// Token: 0x06004FEC RID: 20460 RVA: 0x00104030 File Offset: 0x00102230
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator -([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> vector)
		{
			if (typeof(T) == typeof(float))
			{
				return vector ^ Vector64.Create(--0f).As<float, T>();
			}
			if (typeof(T) == typeof(double))
			{
				return vector ^ Vector64.Create(--0.0).As<double, T>();
			}
			return Vector64<T>.Zero - vector;
		}

		// Token: 0x06004FED RID: 20461 RVA: 0x001040AE File Offset: 0x001022AE
		[Intrinsic]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T>operator +([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			return value;
		}

		// Token: 0x06004FEE RID: 20462 RVA: 0x001040B8 File Offset: 0x001022B8
		[Intrinsic]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static Vector64<T> op_UnsignedRightShift([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> value, int shiftCount)
		{
			Vector64<T> result;
			Unsafe.SkipInit<Vector64<T>>(out result);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T value2 = Scalar<T>.ShiftRightLogical(value.GetElementUnsafe(i), shiftCount);
				result.SetElementUnsafe(i, value2);
			}
			return result;
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x001040F8 File Offset: 0x001022F8
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is Vector64<T>)
			{
				Vector64<T> other = (Vector64<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x0010411D File Offset: 0x0010231D
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] Vector64<T> other)
		{
			if (false)
			{
			}
			return Vector64<T>.<Equals>g__SoftwareFallback|36_0(this, other);
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x0010412C File Offset: 0x0010232C
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				T elementUnsafe = this.GetElementUnsafe(i);
				hashCode.Add<T>(elementUnsafe);
			}
			return hashCode.ToHashCode();
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x00104168 File Offset: 0x00102368
		public override string ToString()
		{
			return this.ToString("G", CultureInfo.InvariantCulture);
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x0010417C File Offset: 0x0010237C
		private unsafe string ToString([StringSyntax("NumericFormat")] string format, IFormatProvider formatProvider)
		{
			ThrowHelper.ThrowForUnsupportedIntrinsicsVector64BaseType<T>();
			Span<char> initialBuffer = new Span<char>(stackalloc byte[(UIntPtr)128], 64);
			ValueStringBuilder valueStringBuilder = new ValueStringBuilder(initialBuffer);
			string numberGroupSeparator = NumberFormatInfo.GetInstance(formatProvider).NumberGroupSeparator;
			valueStringBuilder.Append('<');
			valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(0))).ToString(format, formatProvider));
			for (int i = 1; i < Vector64<T>.Count; i++)
			{
				valueStringBuilder.Append(numberGroupSeparator);
				valueStringBuilder.Append(' ');
				valueStringBuilder.Append(((IFormattable)((object)this.GetElementUnsafe(i))).ToString(format, formatProvider));
			}
			valueStringBuilder.Append('>');
			return valueStringBuilder.ToString();
		}

		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x0002EBDD File Offset: 0x0002CDDD
		int ISimdVector<Vector64<!0>, !0>.Alignment
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x00007B65 File Offset: 0x00005D65
		bool ISimdVector<Vector64<!0>, !0>.IsHardwareAccelerated
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x00104230 File Offset: 0x00102430
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Abs(Vector64<T> vector)
		{
			return Vector64.Abs<T>(vector);
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x00104238 File Offset: 0x00102438
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Add(Vector64<T> left, Vector64<T> right)
		{
			return left + right;
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x00104241 File Offset: 0x00102441
		Vector64<T> ISimdVector<Vector64<!0>, !0>.AndNot(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.AndNot<T>(left, right);
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x0010424A File Offset: 0x0010244A
		Vector64<T> ISimdVector<Vector64<!0>, !0>.BitwiseAnd(Vector64<T> left, Vector64<T> right)
		{
			return left & right;
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x00104253 File Offset: 0x00102453
		Vector64<T> ISimdVector<Vector64<!0>, !0>.BitwiseOr(Vector64<T> left, Vector64<T> right)
		{
			return left | right;
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x0010425C File Offset: 0x0010245C
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Ceiling(Vector64<T> vector)
		{
			return Vector64.Ceiling<T>(vector);
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x00104264 File Offset: 0x00102464
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Clamp(Vector64<T> value, Vector64<T> min, Vector64<T> max)
		{
			return Vector64.Clamp<T>(value, min, max);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x0010426E File Offset: 0x0010246E
		Vector64<T> ISimdVector<Vector64<!0>, !0>.ClampNative(Vector64<T> value, Vector64<T> min, Vector64<T> max)
		{
			return Vector64.ClampNative<T>(value, min, max);
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x00104278 File Offset: 0x00102478
		Vector64<T> ISimdVector<Vector64<!0>, !0>.ConditionalSelect(Vector64<T> condition, Vector64<T> left, Vector64<T> right)
		{
			return Vector64.ConditionalSelect<T>(condition, left, right);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x00104282 File Offset: 0x00102482
		Vector64<T> ISimdVector<Vector64<!0>, !0>.CopySign(Vector64<T> value, Vector64<T> sign)
		{
			return Vector64.CopySign<T>(value, sign);
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x0010428B File Offset: 0x0010248B
		void ISimdVector<Vector64<!0>, !0>.CopyTo(Vector64<T> vector, T[] destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x00104294 File Offset: 0x00102494
		void ISimdVector<Vector64<!0>, !0>.CopyTo(Vector64<T> vector, T[] destination, int startIndex)
		{
			vector.CopyTo(destination, startIndex);
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x0010429E File Offset: 0x0010249E
		void ISimdVector<Vector64<!0>, !0>.CopyTo(Vector64<T> vector, Span<T> destination)
		{
			vector.CopyTo(destination);
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x001042A7 File Offset: 0x001024A7
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Create(T value)
		{
			return Vector64.Create<T>(value);
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x001042AF File Offset: 0x001024AF
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Create(T[] values)
		{
			return Vector64.Create<T>(values);
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x001042B7 File Offset: 0x001024B7
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Create(T[] values, int index)
		{
			return Vector64.Create<T>(values, index);
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x001042C0 File Offset: 0x001024C0
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Create(ReadOnlySpan<T> values)
		{
			return Vector64.Create<T>(values);
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x001042C8 File Offset: 0x001024C8
		Vector64<T> ISimdVector<Vector64<!0>, !0>.CreateScalar(T value)
		{
			return Vector64.CreateScalar<T>(value);
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x001042D0 File Offset: 0x001024D0
		Vector64<T> ISimdVector<Vector64<!0>, !0>.CreateScalarUnsafe(T value)
		{
			return Vector64.CreateScalarUnsafe<T>(value);
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x001042D8 File Offset: 0x001024D8
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Divide(Vector64<T> left, Vector64<T> right)
		{
			return left / right;
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x001042E1 File Offset: 0x001024E1
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Divide(Vector64<T> left, T right)
		{
			return left / right;
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x001042EA File Offset: 0x001024EA
		T ISimdVector<Vector64<!0>, !0>.Dot(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.Dot<T>(left, right);
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x001042F3 File Offset: 0x001024F3
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Equals(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.Equals<T>(left, right);
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x001042FC File Offset: 0x001024FC
		bool ISimdVector<Vector64<!0>, !0>.EqualsAll(Vector64<T> left, Vector64<T> right)
		{
			return left == right;
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x00104305 File Offset: 0x00102505
		bool ISimdVector<Vector64<!0>, !0>.EqualsAny(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.EqualsAny<T>(left, right);
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x0010430E File Offset: 0x0010250E
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Floor(Vector64<T> vector)
		{
			return Vector64.Floor<T>(vector);
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x00104316 File Offset: 0x00102516
		T ISimdVector<Vector64<!0>, !0>.GetElement(Vector64<T> vector, int index)
		{
			return vector.GetElement(index);
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x0010431F File Offset: 0x0010251F
		Vector64<T> ISimdVector<Vector64<!0>, !0>.GreaterThan(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.GreaterThan<T>(left, right);
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x00104328 File Offset: 0x00102528
		bool ISimdVector<Vector64<!0>, !0>.GreaterThanAll(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.GreaterThanAll<T>(left, right);
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x00104331 File Offset: 0x00102531
		bool ISimdVector<Vector64<!0>, !0>.GreaterThanAny(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.GreaterThanAny<T>(left, right);
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x0010433A File Offset: 0x0010253A
		Vector64<T> ISimdVector<Vector64<!0>, !0>.GreaterThanOrEqual(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.GreaterThanOrEqual<T>(left, right);
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x00104343 File Offset: 0x00102543
		bool ISimdVector<Vector64<!0>, !0>.GreaterThanOrEqualAll(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.GreaterThanOrEqualAll<T>(left, right);
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x0010434C File Offset: 0x0010254C
		bool ISimdVector<Vector64<!0>, !0>.GreaterThanOrEqualAny(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.GreaterThanOrEqualAny<T>(left, right);
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00104355 File Offset: 0x00102555
		Vector64<T> ISimdVector<Vector64<!0>, !0>.LessThan(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.LessThan<T>(left, right);
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x0010435E File Offset: 0x0010255E
		bool ISimdVector<Vector64<!0>, !0>.LessThanAll(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.LessThanAll<T>(left, right);
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x00104367 File Offset: 0x00102567
		bool ISimdVector<Vector64<!0>, !0>.LessThanAny(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.LessThanAny<T>(left, right);
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x00104370 File Offset: 0x00102570
		Vector64<T> ISimdVector<Vector64<!0>, !0>.LessThanOrEqual(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.LessThanOrEqual<T>(left, right);
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x00104379 File Offset: 0x00102579
		bool ISimdVector<Vector64<!0>, !0>.LessThanOrEqualAll(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.LessThanOrEqualAll<T>(left, right);
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00104382 File Offset: 0x00102582
		bool ISimdVector<Vector64<!0>, !0>.LessThanOrEqualAny(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.LessThanOrEqualAny<T>(left, right);
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x0010438B File Offset: 0x0010258B
		unsafe Vector64<T> ISimdVector<Vector64<!0>, !0>.Load(T* source)
		{
			return Vector64.Load<T>(source);
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x00104393 File Offset: 0x00102593
		unsafe Vector64<T> ISimdVector<Vector64<!0>, !0>.LoadAligned(T* source)
		{
			return Vector64.LoadAligned<T>(source);
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x0010439B File Offset: 0x0010259B
		unsafe Vector64<T> ISimdVector<Vector64<!0>, !0>.LoadAlignedNonTemporal(T* source)
		{
			return Vector64.LoadAlignedNonTemporal<T>(source);
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x001043A3 File Offset: 0x001025A3
		Vector64<T> ISimdVector<Vector64<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source)
		{
			return Vector64.LoadUnsafe<T>(ref source);
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x001043AB File Offset: 0x001025AB
		Vector64<T> ISimdVector<Vector64<!0>, !0>.LoadUnsafe([RequiresLocation] [In] ref T source, UIntPtr elementOffset)
		{
			return Vector64.LoadUnsafe<T>(ref source, elementOffset);
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x001043B4 File Offset: 0x001025B4
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Max(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.Max<T>(left, right);
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x001043BD File Offset: 0x001025BD
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MaxMagnitude(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.MaxMagnitude<T>(left, right);
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x001043C6 File Offset: 0x001025C6
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MaxMagnitudeNumber(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.MaxMagnitudeNumber<T>(left, right);
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x001043CF File Offset: 0x001025CF
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MaxNative(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.MaxNative<T>(left, right);
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x001043D8 File Offset: 0x001025D8
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MaxNumber(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.MaxNumber<T>(left, right);
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x001043E1 File Offset: 0x001025E1
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Min(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.Min<T>(left, right);
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x001043EA File Offset: 0x001025EA
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MinMagnitude(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.MinMagnitude<T>(left, right);
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x001043F3 File Offset: 0x001025F3
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MinMagnitudeNumber(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.MinMagnitudeNumber<T>(left, right);
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x001043FC File Offset: 0x001025FC
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MinNative(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.MinNative<T>(left, right);
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00104405 File Offset: 0x00102605
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MinNumber(Vector64<T> left, Vector64<T> right)
		{
			return Vector64.MinNumber<T>(left, right);
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x0010440E File Offset: 0x0010260E
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Multiply(Vector64<T> left, Vector64<T> right)
		{
			return left * right;
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x00104417 File Offset: 0x00102617
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Multiply(Vector64<T> left, T right)
		{
			return left * right;
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x00104420 File Offset: 0x00102620
		Vector64<T> ISimdVector<Vector64<!0>, !0>.MultiplyAddEstimate(Vector64<T> left, Vector64<T> right, Vector64<T> addend)
		{
			return Vector64.MultiplyAddEstimate<T>(left, right, addend);
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x0010442A File Offset: 0x0010262A
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Negate(Vector64<T> vector)
		{
			return -vector;
		}

		// Token: 0x06005030 RID: 20528 RVA: 0x00104432 File Offset: 0x00102632
		Vector64<T> ISimdVector<Vector64<!0>, !0>.OnesComplement(Vector64<T> vector)
		{
			return ~vector;
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x0010443A File Offset: 0x0010263A
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Round(Vector64<T> vector)
		{
			return Vector64.Round<T>(vector);
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x00104442 File Offset: 0x00102642
		Vector64<T> ISimdVector<Vector64<!0>, !0>.ShiftLeft(Vector64<T> vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x0010444B File Offset: 0x0010264B
		Vector64<T> ISimdVector<Vector64<!0>, !0>.ShiftRightArithmetic(Vector64<T> vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x00104454 File Offset: 0x00102654
		Vector64<T> ISimdVector<Vector64<!0>, !0>.ShiftRightLogical(Vector64<T> vector, int shiftCount)
		{
			return Vector64<T>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x0010445D File Offset: 0x0010265D
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Sqrt(Vector64<T> vector)
		{
			return Vector64.Sqrt<T>(vector);
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00104465 File Offset: 0x00102665
		unsafe void ISimdVector<Vector64<!0>, !0>.Store(Vector64<T> source, T* destination)
		{
			source.Store(destination);
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x0010446E File Offset: 0x0010266E
		unsafe void ISimdVector<Vector64<!0>, !0>.StoreAligned(Vector64<T> source, T* destination)
		{
			source.StoreAligned(destination);
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00104477 File Offset: 0x00102677
		unsafe void ISimdVector<Vector64<!0>, !0>.StoreAlignedNonTemporal(Vector64<T> source, T* destination)
		{
			source.StoreAlignedNonTemporal(destination);
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00104480 File Offset: 0x00102680
		void ISimdVector<Vector64<!0>, !0>.StoreUnsafe(Vector64<T> vector, ref T destination)
		{
			vector.StoreUnsafe(ref destination);
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00104489 File Offset: 0x00102689
		void ISimdVector<Vector64<!0>, !0>.StoreUnsafe(Vector64<T> vector, ref T destination, UIntPtr elementOffset)
		{
			vector.StoreUnsafe(ref destination, elementOffset);
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00104493 File Offset: 0x00102693
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Subtract(Vector64<T> left, Vector64<T> right)
		{
			return left - right;
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x0010449C File Offset: 0x0010269C
		T ISimdVector<Vector64<!0>, !0>.Sum(Vector64<T> vector)
		{
			return Vector64.Sum<T>(vector);
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x001044A4 File Offset: 0x001026A4
		T ISimdVector<Vector64<!0>, !0>.ToScalar(Vector64<T> vector)
		{
			return vector.ToScalar<T>();
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x001044AC File Offset: 0x001026AC
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Truncate(Vector64<T> vector)
		{
			return Vector64.Truncate<T>(vector);
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x001044B4 File Offset: 0x001026B4
		bool ISimdVector<Vector64<!0>, !0>.TryCopyTo(Vector64<T> vector, Span<T> destination)
		{
			return vector.TryCopyTo(destination);
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x001044BD File Offset: 0x001026BD
		Vector64<T> ISimdVector<Vector64<!0>, !0>.WithElement(Vector64<T> vector, int index, T value)
		{
			return vector.WithElement(index, value);
		}

		// Token: 0x06005041 RID: 20545 RVA: 0x001044C7 File Offset: 0x001026C7
		Vector64<T> ISimdVector<Vector64<!0>, !0>.Xor(Vector64<T> left, Vector64<T> right)
		{
			return left ^ right;
		}

		// Token: 0x06005042 RID: 20546 RVA: 0x001044D0 File Offset: 0x001026D0
		bool ISimdVector<Vector64<!0>, !0>.AnyWhereAllBitsSet(Vector64<T> vector)
		{
			return Vector64.EqualsAny<T>(vector, Vector64<T>.AllBitsSet);
		}

		// Token: 0x06005043 RID: 20547 RVA: 0x001044DD File Offset: 0x001026DD
		bool ISimdVector<Vector64<!0>, !0>.Any(Vector64<T> vector, T value)
		{
			return Vector64.EqualsAny<T>(vector, Vector64.Create<T>(value));
		}

		// Token: 0x06005044 RID: 20548 RVA: 0x001044EC File Offset: 0x001026EC
		int ISimdVector<Vector64<!0>, !0>.IndexOfLastMatch(Vector64<T> vector)
		{
			uint value = vector.ExtractMostSignificantBits<T>();
			return 31 - BitOperations.LeadingZeroCount(value);
		}

		// Token: 0x06005045 RID: 20549 RVA: 0x00104509 File Offset: 0x00102709
		Vector64<T> ISimdVector<Vector64<!0>, !0>.IsNaN(Vector64<T> vector)
		{
			return Vector64.IsNaN<T>(vector);
		}

		// Token: 0x06005046 RID: 20550 RVA: 0x00104511 File Offset: 0x00102711
		Vector64<T> ISimdVector<Vector64<!0>, !0>.IsNegative(Vector64<T> vector)
		{
			return Vector64.IsNegative<T>(vector);
		}

		// Token: 0x06005047 RID: 20551 RVA: 0x00104519 File Offset: 0x00102719
		Vector64<T> ISimdVector<Vector64<!0>, !0>.IsPositive(Vector64<T> vector)
		{
			return Vector64.IsPositive<T>(vector);
		}

		// Token: 0x06005048 RID: 20552 RVA: 0x00104521 File Offset: 0x00102721
		Vector64<T> ISimdVector<Vector64<!0>, !0>.IsPositiveInfinity(Vector64<T> vector)
		{
			return Vector64.IsPositiveInfinity<T>(vector);
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x00104529 File Offset: 0x00102729
		Vector64<T> ISimdVector<Vector64<!0>, !0>.IsZero(Vector64<T> vector)
		{
			return Vector64.IsZero<T>(vector);
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x00104534 File Offset: 0x00102734
		[CompilerGenerated]
		internal static bool <Equals>g__SoftwareFallback|36_0(in Vector64<T> self, Vector64<T> other)
		{
			for (int i = 0; i < Vector64<T>.Count; i++)
			{
				if (!Scalar<T>.ObjectEquals(self.GetElementUnsafe(i), other.GetElementUnsafe(i)))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040011C9 RID: 4553
		internal readonly ulong _00;
	}
}
