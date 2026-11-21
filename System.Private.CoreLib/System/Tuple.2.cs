using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001D7 RID: 471
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Tuple<[Nullable(2)] T1> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060023B6 RID: 9142 RVA: 0x0006DBE3 File Offset: 0x0006BDE3
		[Nullable(1)]
		public T1 Item1
		{
			[NullableContext(1)]
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0006DBEB File Offset: 0x0006BDEB
		[NullableContext(1)]
		public Tuple(T1 item1)
		{
			this.m_Item1 = item1;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x0006DBFA File Offset: 0x0006BDFA
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj, EqualityComparer<object>.Default);
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0006DC08 File Offset: 0x0006BE08
		bool IStructuralEquatable.Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			return this.Equals(other, comparer);
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x0006DC14 File Offset: 0x0006BE14
		private bool Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1> tuple = other as Tuple<T1>;
			return tuple != null && comparer.Equals(this.m_Item1, tuple.m_Item1);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0006DC4E File Offset: 0x0006BE4E
		int IComparable.CompareTo(object obj)
		{
			return this.CompareTo(obj, Comparer<object>.Default);
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x0006DC5C File Offset: 0x0006BE5C
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return this.CompareTo(other, comparer);
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0006DC68 File Offset: 0x0006BE68
		private int CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1> tuple = other as Tuple<T1>;
			if (tuple == null)
			{
				throw new ArgumentException(SR.Format(SR.ArgumentException_TupleIncorrectType, base.GetType()), "other");
			}
			return comparer.Compare(this.m_Item1, tuple.m_Item1);
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0006DCBB File Offset: 0x0006BEBB
		public override int GetHashCode()
		{
			return this.GetHashCode(EqualityComparer<object>.Default);
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0006DCC8 File Offset: 0x0006BEC8
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0006DCC8 File Offset: 0x0006BEC8
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x0006DCD1 File Offset: 0x0006BED1
		private int GetHashCode(IEqualityComparer comparer)
		{
			return comparer.GetHashCode(this.m_Item1);
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x0006DCE4 File Offset: 0x0006BEE4
		[NullableContext(1)]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return this.ToString(stringBuilder);
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0006DD07 File Offset: 0x0006BF07
		string ITupleInternal.ToString(StringBuilder sb)
		{
			return this.ToString(sb);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0006DD10 File Offset: 0x0006BF10
		private string ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(')');
			return sb.ToString();
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060023C5 RID: 9157 RVA: 0x000070DD File Offset: 0x000052DD
		int ITuple.Length
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700078D RID: 1933
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

		// Token: 0x040006A1 RID: 1697
		private readonly T1 m_Item1;
	}
}
