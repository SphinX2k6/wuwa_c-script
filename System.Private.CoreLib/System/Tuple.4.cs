using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001D9 RID: 473
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Tuple<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x0006DF61 File Offset: 0x0006C161
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x0006DF69 File Offset: 0x0006C169
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x0006DF71 File Offset: 0x0006C171
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0006DF79 File Offset: 0x0006C179
		public Tuple(T1 item1, T2 item2, T3 item3)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0006DF96 File Offset: 0x0006C196
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj, EqualityComparer<object>.Default);
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0006DFA4 File Offset: 0x0006C1A4
		bool IStructuralEquatable.Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			return this.Equals(other, comparer);
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0006DFB0 File Offset: 0x0006C1B0
		private bool Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3> tuple = other as Tuple<T1, T2, T3>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2)) && comparer.Equals(this.m_Item3, tuple.m_Item3);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0006E028 File Offset: 0x0006C228
		int IComparable.CompareTo(object obj)
		{
			return this.CompareTo(obj, Comparer<object>.Default);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0006E036 File Offset: 0x0006C236
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return this.CompareTo(other, comparer);
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x0006E040 File Offset: 0x0006C240
		private int CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3> tuple = other as Tuple<T1, T2, T3>;
			if (tuple == null)
			{
				throw new ArgumentException(SR.Format(SR.ArgumentException_TupleIncorrectType, base.GetType()), "other");
			}
			int num = comparer.Compare(this.m_Item1, tuple.m_Item1);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item2, tuple.m_Item2);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Item3, tuple.m_Item3);
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0006E0D7 File Offset: 0x0006C2D7
		public override int GetHashCode()
		{
			return this.GetHashCode(EqualityComparer<object>.Default);
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x0006E0E4 File Offset: 0x0006C2E4
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x0006E0E4 File Offset: 0x0006C2E4
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x0006E0ED File Offset: 0x0006C2ED
		private int GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3));
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x0006E128 File Offset: 0x0006C328
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return this.ToString(stringBuilder);
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x0006E14B File Offset: 0x0006C34B
		string ITupleInternal.ToString(StringBuilder sb)
		{
			return this.ToString(sb);
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0006E154 File Offset: 0x0006C354
		private string ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(", ");
			sb.Append(this.m_Item3);
			sb.Append(')');
			return sb.ToString();
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x0001FC46 File Offset: 0x0001DE46
		int ITuple.Length
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000796 RID: 1942
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

		// Token: 0x040006A4 RID: 1700
		private readonly T1 m_Item1;

		// Token: 0x040006A5 RID: 1701
		private readonly T2 m_Item2;

		// Token: 0x040006A6 RID: 1702
		private readonly T3 m_Item3;
	}
}
