using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001D8 RID: 472
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Tuple<[Nullable(2)] T1, [Nullable(2)] T2> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0006DD49 File Offset: 0x0006BF49
		[Nullable(1)]
		public T1 Item1
		{
			[NullableContext(1)]
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x0006DD51 File Offset: 0x0006BF51
		[Nullable(1)]
		public T2 Item2
		{
			[NullableContext(1)]
			get
			{
				return this.m_Item2;
			}
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0006DD59 File Offset: 0x0006BF59
		[NullableContext(1)]
		public Tuple(T1 item1, T2 item2)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0006DD6F File Offset: 0x0006BF6F
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj, EqualityComparer<object>.Default);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0006DD7D File Offset: 0x0006BF7D
		bool IStructuralEquatable.Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			return this.Equals(other, comparer);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x0006DD88 File Offset: 0x0006BF88
		private bool Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2> tuple = other as Tuple<T1, T2>;
			return tuple != null && comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x0006DDE2 File Offset: 0x0006BFE2
		int IComparable.CompareTo(object obj)
		{
			return this.CompareTo(obj, Comparer<object>.Default);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0006DDF0 File Offset: 0x0006BFF0
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return this.CompareTo(other, comparer);
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0006DDFC File Offset: 0x0006BFFC
		private int CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2> tuple = other as Tuple<T1, T2>;
			if (tuple == null)
			{
				throw new ArgumentException(SR.Format(SR.ArgumentException_TupleIncorrectType, base.GetType()), "other");
			}
			int num = comparer.Compare(this.m_Item1, tuple.m_Item1);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Item2, tuple.m_Item2);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x0006DE71 File Offset: 0x0006C071
		public override int GetHashCode()
		{
			return this.GetHashCode(EqualityComparer<object>.Default);
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0006DE7E File Offset: 0x0006C07E
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0006DE7E File Offset: 0x0006C07E
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0006DE87 File Offset: 0x0006C087
		private int GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2));
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0006DEB0 File Offset: 0x0006C0B0
		[NullableContext(1)]
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return this.ToString(stringBuilder);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0006DED3 File Offset: 0x0006C0D3
		string ITupleInternal.ToString(StringBuilder sb)
		{
			return this.ToString(sb);
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0006DEDC File Offset: 0x0006C0DC
		private string ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(')');
			return sb.ToString();
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x000201B4 File Offset: 0x0001E3B4
		int ITuple.Length
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000791 RID: 1937
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

		// Token: 0x040006A2 RID: 1698
		private readonly T1 m_Item1;

		// Token: 0x040006A3 RID: 1699
		private readonly T2 m_Item2;
	}
}
