using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020001F3 RID: 499
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public struct ValueTuple<[Nullable(2)] T1, [Nullable(2)] T2> : IEquatable<ValueTuple<T1, T2>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2>>, IValueTupleInternal, ITuple
	{
		// Token: 0x060027DD RID: 10205 RVA: 0x0007850A File Offset: 0x0007670A
		[NullableContext(1)]
		public ValueTuple(T1 item1, T2 item2)
		{
			this.Item1 = item1;
			this.Item2 = item2;
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x0007851C File Offset: 0x0007671C
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ValueTuple<T1, T2>)
			{
				ValueTuple<T1, T2> other = (ValueTuple<T1, T2>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00078541 File Offset: 0x00076741
		public bool Equals([Nullable(new byte[]
		{
			0,
			1,
			1
		})] ValueTuple<T1, T2> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2);
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00078574 File Offset: 0x00076774
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other is ValueTuple<T1, T2>)
			{
				ValueTuple<T1, T2> valueTuple = (ValueTuple<T1, T2>)other;
				if (comparer.Equals(this.Item1, valueTuple.Item1))
				{
					return comparer.Equals(this.Item2, valueTuple.Item2);
				}
			}
			return false;
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x000785CC File Offset: 0x000767CC
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				if (other is ValueTuple<T1, T2>)
				{
					ValueTuple<T1, T2> other2 = (ValueTuple<T1, T2>)other;
					return this.CompareTo(other2);
				}
				ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
			}
			return 1;
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00078604 File Offset: 0x00076804
		public int CompareTo([Nullable(new byte[]
		{
			0,
			1,
			1
		})] ValueTuple<T1, T2> other)
		{
			int num = Comparer<T1>.Default.Compare(this.Item1, other.Item1);
			if (num != 0)
			{
				return num;
			}
			return Comparer<T2>.Default.Compare(this.Item2, other.Item2);
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00078644 File Offset: 0x00076844
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
				if (other is ValueTuple<T1, T2>)
				{
					ValueTuple<T1, T2> valueTuple = (ValueTuple<T1, T2>)other;
					int num = comparer.Compare(this.Item1, valueTuple.Item1);
					if (num != 0)
					{
						return num;
					}
					return comparer.Compare(this.Item2, valueTuple.Item2);
				}
				else
				{
					ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
				}
			}
			return 1;
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x000786B4 File Offset: 0x000768B4
		public override int GetHashCode()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			int value;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					value = 0;
					goto IL_35;
				}
			}
			value = ptr.GetHashCode();
			IL_35:
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			int value2;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					value2 = 0;
					goto IL_6A;
				}
			}
			value2 = ptr2.GetHashCode();
			IL_6A:
			return HashCode.Combine<int, int>(value, value2);
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00078730 File Offset: 0x00076930
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00078739 File Offset: 0x00076939
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return HashCode.Combine<int, int>(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2));
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00078730 File Offset: 0x00076930
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00078764 File Offset: 0x00076964
		[NullableContext(1)]
		public override string ToString()
		{
			string[] array = new string[5];
			array[0] = "(";
			int num = 1;
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string text;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					text = null;
					goto IL_45;
				}
			}
			text = ptr.ToString();
			IL_45:
			array[num] = text;
			array[2] = ", ";
			int num2 = 3;
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			string text2;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					text2 = null;
					goto IL_85;
				}
			}
			text2 = ptr2.ToString();
			IL_85:
			array[num2] = text2;
			array[4] = ")";
			return string.Concat(array);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00078804 File Offset: 0x00076A04
		string IValueTupleInternal.ToStringEnd()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string str;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					str = null;
					goto IL_35;
				}
			}
			str = ptr.ToString();
			IL_35:
			string str2 = ", ";
			ref T2 ptr2 = ref this.Item2;
			T2 t2 = default(T2);
			string str3;
			if (t2 == null)
			{
				t2 = this.Item2;
				ptr2 = ref t2;
				if (t2 == null)
				{
					str3 = null;
					goto IL_6F;
				}
			}
			str3 = ptr2.ToString();
			IL_6F:
			return str + str2 + str3 + ")";
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int ITuple.Length
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000808 RID: 2056
		[Nullable(2)]
		object ITuple.this[int index]
		{
			get
			{
				object result;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException();
					}
					result = this.Item2;
				}
				else
				{
					result = this.Item1;
				}
				return result;
			}
		}

		// Token: 0x040006F4 RID: 1780
		[Nullable(1)]
		public T1 Item1;

		// Token: 0x040006F5 RID: 1781
		[Nullable(1)]
		public T2 Item2;
	}
}
