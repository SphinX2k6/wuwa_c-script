using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020001F4 RID: 500
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public struct ValueTuple<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3> : IEquatable<ValueTuple<T1, T2, T3>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3>>, IValueTupleInternal, ITuple
	{
		// Token: 0x060027EC RID: 10220 RVA: 0x000788C5 File Offset: 0x00076AC5
		[NullableContext(1)]
		public ValueTuple(T1 item1, T2 item2, T3 item3)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
		}

		// Token: 0x060027ED RID: 10221 RVA: 0x000788DC File Offset: 0x00076ADC
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ValueTuple<T1, T2, T3>)
			{
				ValueTuple<T1, T2, T3> other = (ValueTuple<T1, T2, T3>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00078904 File Offset: 0x00076B04
		public bool Equals([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] ValueTuple<T1, T2, T3> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(this.Item3, other.Item3);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x0007895C File Offset: 0x00076B5C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other is ValueTuple<T1, T2, T3>)
			{
				ValueTuple<T1, T2, T3> valueTuple = (ValueTuple<T1, T2, T3>)other;
				if (comparer.Equals(this.Item1, valueTuple.Item1) && comparer.Equals(this.Item2, valueTuple.Item2))
				{
					return comparer.Equals(this.Item3, valueTuple.Item3);
				}
			}
			return false;
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000789D4 File Offset: 0x00076BD4
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				if (other is ValueTuple<T1, T2, T3>)
				{
					ValueTuple<T1, T2, T3> other2 = (ValueTuple<T1, T2, T3>)other;
					return this.CompareTo(other2);
				}
				ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
			}
			return 1;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x00078A0C File Offset: 0x00076C0C
		public int CompareTo([Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] ValueTuple<T1, T2, T3> other)
		{
			int num = Comparer<T1>.Default.Compare(this.Item1, other.Item1);
			if (num != 0)
			{
				return num;
			}
			num = Comparer<T2>.Default.Compare(this.Item2, other.Item2);
			if (num != 0)
			{
				return num;
			}
			return Comparer<T3>.Default.Compare(this.Item3, other.Item3);
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x00078A68 File Offset: 0x00076C68
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
				if (other is ValueTuple<T1, T2, T3>)
				{
					ValueTuple<T1, T2, T3> valueTuple = (ValueTuple<T1, T2, T3>)other;
					int num = comparer.Compare(this.Item1, valueTuple.Item1);
					if (num != 0)
					{
						return num;
					}
					num = comparer.Compare(this.Item2, valueTuple.Item2);
					if (num != 0)
					{
						return num;
					}
					return comparer.Compare(this.Item3, valueTuple.Item3);
				}
				else
				{
					ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
				}
			}
			return 1;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x00078AFC File Offset: 0x00076CFC
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
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			int value3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					value3 = 0;
					goto IL_9F;
				}
			}
			value3 = ptr3.GetHashCode();
			IL_9F:
			return HashCode.Combine<int, int, int>(value, value2, value3);
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00078BAD File Offset: 0x00076DAD
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00078BB6 File Offset: 0x00076DB6
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return HashCode.Combine<int, int, int>(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2), comparer.GetHashCode(this.Item3));
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00078BAD File Offset: 0x00076DAD
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x00078BF0 File Offset: 0x00076DF0
		[NullableContext(1)]
		public override string ToString()
		{
			string[] array = new string[7];
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
			array[4] = ", ";
			int num3 = 5;
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			string text3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					text3 = null;
					goto IL_C5;
				}
			}
			text3 = ptr3.ToString();
			IL_C5:
			array[num3] = text3;
			array[6] = ")";
			return string.Concat(array);
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00078CD0 File Offset: 0x00076ED0
		string IValueTupleInternal.ToStringEnd()
		{
			string[] array = new string[6];
			int num = 0;
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
					goto IL_3D;
				}
			}
			text = ptr.ToString();
			IL_3D:
			array[num] = text;
			array[1] = ", ";
			int num2 = 2;
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
					goto IL_7D;
				}
			}
			text2 = ptr2.ToString();
			IL_7D:
			array[num2] = text2;
			array[3] = ", ";
			int num3 = 4;
			ref T3 ptr3 = ref this.Item3;
			T3 t3 = default(T3);
			string text3;
			if (t3 == null)
			{
				t3 = this.Item3;
				ptr3 = ref t3;
				if (t3 == null)
				{
					text3 = null;
					goto IL_BD;
				}
			}
			text3 = ptr3.ToString();
			IL_BD:
			array[num3] = text3;
			array[5] = ")";
			return string.Concat(array);
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x0001FC46 File Offset: 0x0001DE46
		int ITuple.Length
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x1700080A RID: 2058
		[Nullable(2)]
		object ITuple.this[int index]
		{
			get
			{
				object result;
				switch (index)
				{
				case 0:
					result = this.Item1;
					break;
				case 1:
					result = this.Item2;
					break;
				case 2:
					result = this.Item3;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
		}

		// Token: 0x040006F6 RID: 1782
		[Nullable(1)]
		public T1 Item1;

		// Token: 0x040006F7 RID: 1783
		[Nullable(1)]
		public T2 Item2;

		// Token: 0x040006F8 RID: 1784
		[Nullable(1)]
		public T3 Item3;
	}
}
