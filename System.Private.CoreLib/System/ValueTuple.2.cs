using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001F2 RID: 498
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public struct ValueTuple<[Nullable(2)] T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple
	{
		// Token: 0x060027CF RID: 10191 RVA: 0x000782C9 File Offset: 0x000764C9
		[NullableContext(1)]
		public ValueTuple(T1 item1)
		{
			this.Item1 = item1;
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000782D4 File Offset: 0x000764D4
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			if (obj is ValueTuple<T1>)
			{
				ValueTuple<T1> other = (ValueTuple<T1>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000782F9 File Offset: 0x000764F9
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<T1> other)
		{
			return EqualityComparer<T1>.Default.Equals(this.Item1, other.Item1);
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00078314 File Offset: 0x00076514
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			if (other is ValueTuple<T1>)
			{
				ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
				return comparer.Equals(this.Item1, valueTuple.Item1);
			}
			return false;
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x00078350 File Offset: 0x00076550
		int IComparable.CompareTo(object other)
		{
			if (other != null)
			{
				if (other is ValueTuple<T1>)
				{
					ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
					return Comparer<T1>.Default.Compare(this.Item1, valueTuple.Item1);
				}
				ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
			}
			return 1;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00078397 File Offset: 0x00076597
		public int CompareTo([Nullable(new byte[]
		{
			0,
			1
		})] ValueTuple<T1> other)
		{
			return Comparer<T1>.Default.Compare(this.Item1, other.Item1);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x000783B0 File Offset: 0x000765B0
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other != null)
			{
				if (other is ValueTuple<T1>)
				{
					ValueTuple<T1> valueTuple = (ValueTuple<T1>)other;
					return comparer.Compare(this.Item1, valueTuple.Item1);
				}
				ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
			}
			return 1;
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x00078400 File Offset: 0x00076600
		public override int GetHashCode()
		{
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					return 0;
				}
			}
			return ptr.GetHashCode();
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00078441 File Offset: 0x00076641
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return comparer.GetHashCode(this.Item1);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x00078441 File Offset: 0x00076641
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return comparer.GetHashCode(this.Item1);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00078454 File Offset: 0x00076654
		[NullableContext(1)]
		public override string ToString()
		{
			string str = "(";
			ref T1 ptr = ref this.Item1;
			T1 t = default(T1);
			string str2;
			if (t == null)
			{
				t = this.Item1;
				ptr = ref t;
				if (t == null)
				{
					str2 = null;
					goto IL_3A;
				}
			}
			str2 = ptr.ToString();
			IL_3A:
			return str + str2 + ")";
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000784A8 File Offset: 0x000766A8
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
			return str + ")";
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x000070DD File Offset: 0x000052DD
		int ITuple.Length
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000806 RID: 2054
		[Nullable(2)]
		object ITuple.this[int index]
		{
			get
			{
				if (index != 0)
				{
					throw new IndexOutOfRangeException();
				}
				return this.Item1;
			}
		}

		// Token: 0x040006F3 RID: 1779
		[Nullable(1)]
		public T1 Item1;
	}
}
