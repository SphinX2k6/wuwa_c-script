using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.Intrinsics
{
	// Token: 0x02000540 RID: 1344
	internal interface ISimdVector<TSelf, T> : IAdditionOperators<TSelf, TSelf, TSelf>, IBitwiseOperators<TSelf, TSelf, TSelf>, IDivisionOperators<TSelf, TSelf, TSelf>, IEqualityOperators<TSelf, TSelf, bool>, IEquatable<TSelf>, IMultiplyOperators<TSelf, TSelf, TSelf>, IShiftOperators<TSelf, int, TSelf>, ISubtractionOperators<TSelf, TSelf, TSelf>, IUnaryNegationOperators<TSelf, TSelf>, IUnaryPlusOperators<TSelf, TSelf> where TSelf : ISimdVector<TSelf, T>
	{
		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06004978 RID: 18808
		int Alignment { get; }

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06004979 RID: 18809
		TSelf AllBitsSet { get; }

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x0600497A RID: 18810
		int Count { get; }

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x0600497B RID: 18811
		bool IsHardwareAccelerated { get; }

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x0600497C RID: 18812
		bool IsSupported { get; }

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x0600497D RID: 18813
		TSelf One { get; }

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x0600497E RID: 18814
		TSelf Zero { get; }

		// Token: 0x17000D02 RID: 3330
		T this[int index]
		{
			get;
		}

		// Token: 0x06004980 RID: 18816
		public abstract static TSelf operator /(TSelf left, T right);

		// Token: 0x06004981 RID: 18817
		public abstract static TSelf operator *(TSelf left, T right);

		// Token: 0x06004982 RID: 18818
		public abstract static TSelf Abs(TSelf vector);

		// Token: 0x06004983 RID: 18819 RVA: 0x000F3665 File Offset: 0x000F1865
		public virtual static TSelf Add(TSelf left, TSelf right)
		{
			return left + right;
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x000F3674 File Offset: 0x000F1874
		public virtual static TSelf AndNot(TSelf left, TSelf right)
		{
			return left & ~right;
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x000F368E File Offset: 0x000F188E
		public virtual static TSelf BitwiseAnd(TSelf left, TSelf right)
		{
			return left & right;
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x000F369D File Offset: 0x000F189D
		public virtual static TSelf BitwiseOr(TSelf left, TSelf right)
		{
			return left | right;
		}

		// Token: 0x06004987 RID: 18823
		public abstract static TSelf Ceiling(TSelf vector);

		// Token: 0x06004988 RID: 18824
		public abstract static TSelf Clamp(TSelf value, TSelf min, TSelf max);

		// Token: 0x06004989 RID: 18825
		public abstract static TSelf ClampNative(TSelf value, TSelf min, TSelf max);

		// Token: 0x0600498A RID: 18826 RVA: 0x000F36AC File Offset: 0x000F18AC
		public virtual static TSelf ConditionalSelect(TSelf condition, TSelf left, TSelf right)
		{
			return (left & condition) | (right & ~condition);
		}

		// Token: 0x0600498B RID: 18827
		public abstract static TSelf CopySign(TSelf value, TSelf sign);

		// Token: 0x0600498C RID: 18828 RVA: 0x000F36DE File Offset: 0x000F18DE
		public virtual static void CopyTo(TSelf vector, T[] destination)
		{
			ISimdVector<TSelf, T>.CopyTo(vector, destination.AsSpan<T>());
		}

		// Token: 0x0600498D RID: 18829 RVA: 0x000F36F2 File Offset: 0x000F18F2
		public virtual static void CopyTo(TSelf vector, T[] destination, int startIndex)
		{
			ISimdVector<TSelf, T>.CopyTo(vector, destination.AsSpan(startIndex));
		}

		// Token: 0x0600498E RID: 18830 RVA: 0x000F3707 File Offset: 0x000F1907
		public virtual static void CopyTo(TSelf vector, Span<T> destination)
		{
			if (destination.Length < ISimdVector<TSelf, T>.Count)
			{
				ThrowHelper.ThrowArgumentException_DestinationTooShort();
			}
			ISimdVector<TSelf, T>.StoreUnsafe(vector, MemoryMarshal.GetReference<T>(destination));
		}

		// Token: 0x0600498F RID: 18831
		public abstract static TSelf Create(T value);

		// Token: 0x06004990 RID: 18832 RVA: 0x000F3734 File Offset: 0x000F1934
		public virtual static TSelf Create(T[] values)
		{
			return ISimdVector<TSelf, T>.Create(values.AsSpan<T>());
		}

		// Token: 0x06004991 RID: 18833 RVA: 0x000F374C File Offset: 0x000F194C
		public virtual static TSelf Create(T[] values, int index)
		{
			return ISimdVector<TSelf, T>.Create(values.AsSpan(index));
		}

		// Token: 0x06004992 RID: 18834 RVA: 0x000F3765 File Offset: 0x000F1965
		public virtual static TSelf Create(ReadOnlySpan<T> values)
		{
			if (values.Length < ISimdVector<TSelf, T>.Count)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException(ExceptionArgument.values);
			}
			return ISimdVector<TSelf, T>.LoadUnsafe(MemoryMarshal.GetReference<T>(values));
		}

		// Token: 0x06004993 RID: 18835 RVA: 0x000F3792 File Offset: 0x000F1992
		public virtual static TSelf CreateScalar(T value)
		{
			return ISimdVector<TSelf, T>.WithElement(ISimdVector<TSelf, T>.Zero, 0, value);
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x000F37AC File Offset: 0x000F19AC
		public virtual static TSelf CreateScalarUnsafe(T value)
		{
			TSelf vector;
			Unsafe.SkipInit<TSelf>(out vector);
			return ISimdVector<TSelf, T>.WithElement(vector, 0, value);
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x000F37CE File Offset: 0x000F19CE
		public virtual static TSelf Divide(TSelf left, TSelf right)
		{
			return left / right;
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x000F37DD File Offset: 0x000F19DD
		public virtual static TSelf Divide(TSelf left, T right)
		{
			return left / right;
		}

		// Token: 0x06004997 RID: 18839
		public abstract static T Dot(TSelf left, TSelf right);

		// Token: 0x06004998 RID: 18840
		public abstract static TSelf Equals(TSelf left, TSelf right);

		// Token: 0x06004999 RID: 18841
		public abstract static bool EqualsAll(TSelf left, TSelf right);

		// Token: 0x0600499A RID: 18842
		public abstract static bool EqualsAny(TSelf left, TSelf right);

		// Token: 0x0600499B RID: 18843
		public abstract static TSelf Floor(TSelf vector);

		// Token: 0x0600499C RID: 18844
		public abstract static T GetElement(TSelf vector, int index);

		// Token: 0x0600499D RID: 18845
		public abstract static TSelf GreaterThan(TSelf left, TSelf right);

		// Token: 0x0600499E RID: 18846
		public abstract static bool GreaterThanAll(TSelf left, TSelf right);

		// Token: 0x0600499F RID: 18847
		public abstract static bool GreaterThanAny(TSelf left, TSelf right);

		// Token: 0x060049A0 RID: 18848
		public abstract static TSelf GreaterThanOrEqual(TSelf left, TSelf right);

		// Token: 0x060049A1 RID: 18849
		public abstract static bool GreaterThanOrEqualAll(TSelf left, TSelf right);

		// Token: 0x060049A2 RID: 18850
		public abstract static bool GreaterThanOrEqualAny(TSelf left, TSelf right);

		// Token: 0x060049A3 RID: 18851
		public abstract static TSelf IsNaN(TSelf vector);

		// Token: 0x060049A4 RID: 18852
		public abstract static TSelf IsNegative(TSelf vector);

		// Token: 0x060049A5 RID: 18853
		public abstract static TSelf IsPositive(TSelf vector);

		// Token: 0x060049A6 RID: 18854
		public abstract static TSelf IsPositiveInfinity(TSelf vector);

		// Token: 0x060049A7 RID: 18855
		public abstract static TSelf IsZero(TSelf vector);

		// Token: 0x060049A8 RID: 18856
		public abstract static TSelf LessThan(TSelf left, TSelf right);

		// Token: 0x060049A9 RID: 18857
		public abstract static bool LessThanAll(TSelf left, TSelf right);

		// Token: 0x060049AA RID: 18858
		public abstract static bool LessThanAny(TSelf left, TSelf right);

		// Token: 0x060049AB RID: 18859
		public abstract static TSelf LessThanOrEqual(TSelf left, TSelf right);

		// Token: 0x060049AC RID: 18860
		public abstract static bool LessThanOrEqualAll(TSelf left, TSelf right);

		// Token: 0x060049AD RID: 18861
		public abstract static bool LessThanOrEqualAny(TSelf left, TSelf right);

		// Token: 0x060049AE RID: 18862 RVA: 0x000F37EC File Offset: 0x000F19EC
		public unsafe virtual static TSelf Load(T* source)
		{
			return ISimdVector<TSelf, T>.LoadUnsafe(source);
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x000F37FA File Offset: 0x000F19FA
		public unsafe virtual static TSelf LoadAligned(T* source)
		{
			if (source % ISimdVector<TSelf, T>.Alignment != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			return ISimdVector<TSelf, T>.LoadUnsafe(source);
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x000F381D File Offset: 0x000F1A1D
		public unsafe virtual static TSelf LoadAlignedNonTemporal(T* source)
		{
			return ISimdVector<TSelf, T>.LoadAligned(source);
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x000F382B File Offset: 0x000F1A2B
		public virtual static TSelf LoadUnsafe([RequiresLocation] [In] ref T source)
		{
			return ISimdVector<TSelf, T>.LoadUnsafe(ref source, (UIntPtr)((IntPtr)0));
		}

		// Token: 0x060049B2 RID: 18866
		public abstract static TSelf LoadUnsafe([RequiresLocation] [In] ref T source, UIntPtr elementOffset);

		// Token: 0x060049B3 RID: 18867
		public abstract static TSelf Max(TSelf left, TSelf right);

		// Token: 0x060049B4 RID: 18868
		public abstract static TSelf MaxMagnitude(TSelf left, TSelf right);

		// Token: 0x060049B5 RID: 18869
		public abstract static TSelf MaxMagnitudeNumber(TSelf left, TSelf right);

		// Token: 0x060049B6 RID: 18870
		public abstract static TSelf MaxNative(TSelf left, TSelf right);

		// Token: 0x060049B7 RID: 18871
		public abstract static TSelf MaxNumber(TSelf left, TSelf right);

		// Token: 0x060049B8 RID: 18872
		public abstract static TSelf Min(TSelf left, TSelf right);

		// Token: 0x060049B9 RID: 18873
		public abstract static TSelf MinMagnitude(TSelf left, TSelf right);

		// Token: 0x060049BA RID: 18874
		public abstract static TSelf MinMagnitudeNumber(TSelf left, TSelf right);

		// Token: 0x060049BB RID: 18875
		public abstract static TSelf MinNative(TSelf left, TSelf right);

		// Token: 0x060049BC RID: 18876
		public abstract static TSelf MinNumber(TSelf left, TSelf right);

		// Token: 0x060049BD RID: 18877 RVA: 0x000F383B File Offset: 0x000F1A3B
		public virtual static TSelf Multiply(TSelf left, TSelf right)
		{
			return left * right;
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x000F384A File Offset: 0x000F1A4A
		public virtual static TSelf Multiply(TSelf left, T right)
		{
			return left * right;
		}

		// Token: 0x060049BF RID: 18879
		public abstract static TSelf MultiplyAddEstimate(TSelf left, TSelf right, TSelf addend);

		// Token: 0x060049C0 RID: 18880 RVA: 0x000F3859 File Offset: 0x000F1A59
		public virtual static TSelf Negate(TSelf vector)
		{
			return -vector;
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x000F3867 File Offset: 0x000F1A67
		public virtual static TSelf OnesComplement(TSelf vector)
		{
			return ~vector;
		}

		// Token: 0x060049C2 RID: 18882
		public abstract static TSelf Round(TSelf vector);

		// Token: 0x060049C3 RID: 18883 RVA: 0x000F3875 File Offset: 0x000F1A75
		public virtual static TSelf ShiftLeft(TSelf vector, int shiftCount)
		{
			return vector << shiftCount;
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x000F3884 File Offset: 0x000F1A84
		public virtual static TSelf ShiftRightArithmetic(TSelf vector, int shiftCount)
		{
			return vector >> shiftCount;
		}

		// Token: 0x060049C5 RID: 18885 RVA: 0x000F3893 File Offset: 0x000F1A93
		public virtual static TSelf ShiftRightLogical(TSelf vector, int shiftCount)
		{
			return IShiftOperators<TSelf, int, TSelf>.op_UnsignedRightShift(vector, shiftCount);
		}

		// Token: 0x060049C6 RID: 18886
		public abstract static TSelf Sqrt(TSelf vector);

		// Token: 0x060049C7 RID: 18887 RVA: 0x000F38A2 File Offset: 0x000F1AA2
		public unsafe virtual static void Store(TSelf source, T* destination)
		{
			ISimdVector<TSelf, T>.StoreUnsafe(source, ref *destination);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x000F38B1 File Offset: 0x000F1AB1
		public unsafe virtual static void StoreAligned(TSelf source, T* destination)
		{
			if (destination % ISimdVector<TSelf, T>.Alignment != null)
			{
				ThrowHelper.ThrowAccessViolationException();
			}
			ISimdVector<TSelf, T>.StoreUnsafe(source, ref *destination);
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x000F38D5 File Offset: 0x000F1AD5
		public unsafe virtual static void StoreAlignedNonTemporal(TSelf source, T* destination)
		{
			ISimdVector<TSelf, T>.StoreAligned(source, destination);
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x000F38E4 File Offset: 0x000F1AE4
		public virtual static void StoreUnsafe(TSelf vector, ref T destination)
		{
			ISimdVector<TSelf, T>.StoreUnsafe(vector, ref destination, (UIntPtr)((IntPtr)0));
		}

		// Token: 0x060049CB RID: 18891
		public abstract static void StoreUnsafe(TSelf vector, ref T destination, UIntPtr elementOffset);

		// Token: 0x060049CC RID: 18892 RVA: 0x000F38F5 File Offset: 0x000F1AF5
		public virtual static TSelf Subtract(TSelf left, TSelf right)
		{
			return left - right;
		}

		// Token: 0x060049CD RID: 18893
		public abstract static T Sum(TSelf vector);

		// Token: 0x060049CE RID: 18894 RVA: 0x000F3904 File Offset: 0x000F1B04
		public virtual static T ToScalar(TSelf vector)
		{
			return ISimdVector<TSelf, T>.GetElement(vector, 0);
		}

		// Token: 0x060049CF RID: 18895
		public abstract static TSelf Truncate(TSelf vector);

		// Token: 0x060049D0 RID: 18896 RVA: 0x000F3913 File Offset: 0x000F1B13
		public virtual static bool TryCopyTo(TSelf vector, Span<T> destination)
		{
			if (destination.Length < ISimdVector<TSelf, T>.Count)
			{
				return false;
			}
			ISimdVector<TSelf, T>.StoreUnsafe(vector, MemoryMarshal.GetReference<T>(destination));
			return true;
		}

		// Token: 0x060049D1 RID: 18897
		public abstract static TSelf WithElement(TSelf vector, int index, T value);

		// Token: 0x060049D2 RID: 18898 RVA: 0x000F393E File Offset: 0x000F1B3E
		public virtual static TSelf Xor(TSelf left, TSelf right)
		{
			return left ^ right;
		}

		// Token: 0x060049D3 RID: 18899
		public abstract static bool Any(TSelf vector, T value);

		// Token: 0x060049D4 RID: 18900
		public abstract static bool AnyWhereAllBitsSet(TSelf vector);

		// Token: 0x060049D5 RID: 18901
		public abstract static int IndexOfLastMatch(TSelf vector);
	}
}
