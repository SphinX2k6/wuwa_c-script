using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x020001F7 RID: 503
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	[StructLayout(LayoutKind.Auto)]
	public struct ValueTuple<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6>>, IValueTupleInternal, ITuple
	{
		// Token: 0x06002819 RID: 10265 RVA: 0x00079CA2 File Offset: 0x00077EA2
		public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			this.Item1 = item1;
			this.Item2 = item2;
			this.Item3 = item3;
			this.Item4 = item4;
			this.Item5 = item5;
			this.Item6 = item6;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00079CD4 File Offset: 0x00077ED4
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ValueTuple<T1, T2, T3, T4, T5, T6>)
			{
				ValueTuple<T1, T2, T3, T4, T5, T6> other = (ValueTuple<T1, T2, T3, T4, T5, T6>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00079CFC File Offset: 0x00077EFC
		public bool Equals([Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1,
			1,
			1
		})] ValueTuple<T1, T2, T3, T4, T5, T6> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(this.Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(this.Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(this.Item4, other.Item4) && EqualityComparer<T5>.Default.Equals(this.Item5, other.Item5) && EqualityComparer<T6>.Default.Equals(this.Item6, other.Item6);
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00079D9C File Offset: 0x00077F9C
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other is ValueTuple<T1, T2, T3, T4, T5, T6>)
			{
				ValueTuple<T1, T2, T3, T4, T5, T6> valueTuple = (ValueTuple<T1, T2, T3, T4, T5, T6>)other;
				if (comparer.Equals(this.Item1, valueTuple.Item1) && comparer.Equals(this.Item2, valueTuple.Item2) && comparer.Equals(this.Item3, valueTuple.Item3) && comparer.Equals(this.Item4, valueTuple.Item4) && comparer.Equals(this.Item5, valueTuple.Item5))
				{
					return comparer.Equals(this.Item6, valueTuple.Item6);
				}
			}
			return false;
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00079E74 File Offset: 0x00078074
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				if (other is ValueTuple<T1, T2, T3, T4, T5, T6>)
				{
					ValueTuple<T1, T2, T3, T4, T5, T6> other2 = (ValueTuple<T1, T2, T3, T4, T5, T6>)other;
					return this.CompareTo(other2);
				}
				ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
			}
			return 1;
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00079EAC File Offset: 0x000780AC
		public int CompareTo([Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1,
			1,
			1
		})] ValueTuple<T1, T2, T3, T4, T5, T6> other)
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
			num = Comparer<T3>.Default.Compare(this.Item3, other.Item3);
			if (num != 0)
			{
				return num;
			}
			num = Comparer<T4>.Default.Compare(this.Item4, other.Item4);
			if (num != 0)
			{
				return num;
			}
			num = Comparer<T5>.Default.Compare(this.Item5, other.Item5);
			if (num != 0)
			{
				return num;
			}
			return Comparer<T6>.Default.Compare(this.Item6, other.Item6);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00079F5C File Offset: 0x0007815C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
				if (other is ValueTuple<T1, T2, T3, T4, T5, T6>)
				{
					ValueTuple<T1, T2, T3, T4, T5, T6> valueTuple = (ValueTuple<T1, T2, T3, T4, T5, T6>)other;
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
					num = comparer.Compare(this.Item3, valueTuple.Item3);
					if (num != 0)
					{
						return num;
					}
					num = comparer.Compare(this.Item4, valueTuple.Item4);
					if (num != 0)
					{
						return num;
					}
					num = comparer.Compare(this.Item5, valueTuple.Item5);
					if (num != 0)
					{
						return num;
					}
					return comparer.Compare(this.Item6, valueTuple.Item6);
				}
				else
				{
					ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
				}
			}
			return 1;
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0007A05C File Offset: 0x0007825C
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
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			int value4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					value4 = 0;
					goto IL_D4;
				}
			}
			value4 = ptr4.GetHashCode();
			IL_D4:
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			int value5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					value5 = 0;
					goto IL_10C;
				}
			}
			value5 = ptr5.GetHashCode();
			IL_10C:
			ref T6 ptr6 = ref this.Item6;
			T6 t6 = default(T6);
			int value6;
			if (t6 == null)
			{
				t6 = this.Item6;
				ptr6 = ref t6;
				if (t6 == null)
				{
					value6 = 0;
					goto IL_144;
				}
			}
			value6 = ptr6.GetHashCode();
			IL_144:
			return HashCode.Combine<int, int, int, int, int, int>(value, value2, value3, value4, value5, value6);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0007A1B2 File Offset: 0x000783B2
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0007A1BC File Offset: 0x000783BC
		private int GetHashCodeCore(IEqualityComparer comparer)
		{
			return HashCode.Combine<int, int, int, int, int, int>(comparer.GetHashCode(this.Item1), comparer.GetHashCode(this.Item2), comparer.GetHashCode(this.Item3), comparer.GetHashCode(this.Item4), comparer.GetHashCode(this.Item5), comparer.GetHashCode(this.Item6));
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x0007A1B2 File Offset: 0x000783B2
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCodeCore(comparer);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x0007A234 File Offset: 0x00078434
		public override string ToString()
		{
			string[] array = new string[13];
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
					goto IL_46;
				}
			}
			text = ptr.ToString();
			IL_46:
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
					goto IL_86;
				}
			}
			text2 = ptr2.ToString();
			IL_86:
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
					goto IL_C6;
				}
			}
			text3 = ptr3.ToString();
			IL_C6:
			array[num3] = text3;
			array[6] = ", ";
			int num4 = 7;
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			string text4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					text4 = null;
					goto IL_106;
				}
			}
			text4 = ptr4.ToString();
			IL_106:
			array[num4] = text4;
			array[8] = ", ";
			int num5 = 9;
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			string text5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					text5 = null;
					goto IL_14A;
				}
			}
			text5 = ptr5.ToString();
			IL_14A:
			array[num5] = text5;
			array[10] = ", ";
			int num6 = 11;
			ref T6 ptr6 = ref this.Item6;
			T6 t6 = default(T6);
			string text6;
			if (t6 == null)
			{
				t6 = this.Item6;
				ptr6 = ref t6;
				if (t6 == null)
				{
					text6 = null;
					goto IL_18F;
				}
			}
			text6 = ptr6.ToString();
			IL_18F:
			array[num6] = text6;
			array[12] = ")";
			return string.Concat(array);
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0007A3E0 File Offset: 0x000785E0
		string IValueTupleInternal.ToStringEnd()
		{
			string[] array = new string[12];
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
					goto IL_3E;
				}
			}
			text = ptr.ToString();
			IL_3E:
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
					goto IL_7E;
				}
			}
			text2 = ptr2.ToString();
			IL_7E:
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
					goto IL_BE;
				}
			}
			text3 = ptr3.ToString();
			IL_BE:
			array[num3] = text3;
			array[5] = ", ";
			int num4 = 6;
			ref T4 ptr4 = ref this.Item4;
			T4 t4 = default(T4);
			string text4;
			if (t4 == null)
			{
				t4 = this.Item4;
				ptr4 = ref t4;
				if (t4 == null)
				{
					text4 = null;
					goto IL_FE;
				}
			}
			text4 = ptr4.ToString();
			IL_FE:
			array[num4] = text4;
			array[7] = ", ";
			int num5 = 8;
			ref T5 ptr5 = ref this.Item5;
			T5 t5 = default(T5);
			string text5;
			if (t5 == null)
			{
				t5 = this.Item5;
				ptr5 = ref t5;
				if (t5 == null)
				{
					text5 = null;
					goto IL_141;
				}
			}
			text5 = ptr5.ToString();
			IL_141:
			array[num5] = text5;
			array[9] = ", ";
			int num6 = 10;
			ref T6 ptr6 = ref this.Item6;
			T6 t6 = default(T6);
			string text6;
			if (t6 == null)
			{
				t6 = this.Item6;
				ptr6 = ref t6;
				if (t6 == null)
				{
					text6 = null;
					goto IL_186;
				}
			}
			text6 = ptr6.ToString();
			IL_186:
			array[num6] = text6;
			array[11] = ")";
			return string.Concat(array);
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x0001FEB2 File Offset: 0x0001E0B2
		int ITuple.Length
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17000810 RID: 2064
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
				case 3:
					result = this.Item4;
					break;
				case 4:
					result = this.Item5;
					break;
				case 5:
					result = this.Item6;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
		}

		// Token: 0x04000702 RID: 1794
		public T1 Item1;

		// Token: 0x04000703 RID: 1795
		public T2 Item2;

		// Token: 0x04000704 RID: 1796
		public T3 Item3;

		// Token: 0x04000705 RID: 1797
		public T4 Item4;

		// Token: 0x04000706 RID: 1798
		public T5 Item5;

		// Token: 0x04000707 RID: 1799
		public T6 Item6;
	}
}
