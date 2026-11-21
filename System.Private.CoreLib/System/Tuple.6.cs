using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001DB RID: 475
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Tuple<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x0006E560 File Offset: 0x0006C760
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0006E568 File Offset: 0x0006C768
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x0006E570 File Offset: 0x0006C770
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x0006E578 File Offset: 0x0006C778
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x0006E580 File Offset: 0x0006C780
		public T5 Item5
		{
			get
			{
				return this.m_Item5;
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0006E588 File Offset: 0x0006C788
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
			this.m_Item5 = item5;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0006E5B5 File Offset: 0x0006C7B5
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj, EqualityComparer<object>.Default);
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0006E5C3 File Offset: 0x0006C7C3
		bool IStructuralEquatable.Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			return this.Equals(other, comparer);
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0006E5D0 File Offset: 0x0006C7D0
		private bool Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4, T5> tuple = other as Tuple<T1, T2, T3, T4, T5>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3) && comparer.Equals(this.m_Item4, tuple.m_Item4)) && comparer.Equals(this.m_Item5, tuple.m_Item5);
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0006E684 File Offset: 0x0006C884
		int IComparable.CompareTo(object obj)
		{
			return this.CompareTo(obj, Comparer<object>.Default);
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0006E692 File Offset: 0x0006C892
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return this.CompareTo(other, comparer);
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0006E69C File Offset: 0x0006C89C
		private int CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4, T5> tuple = other as Tuple<T1, T2, T3, T4, T5>;
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
			num = comparer.Compare(this.m_Item3, tuple.m_Item3);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item4, tuple.m_Item4);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Item5, tuple.m_Item5);
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0006E777 File Offset: 0x0006C977
		public override int GetHashCode()
		{
			return this.GetHashCode(EqualityComparer<object>.Default);
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x0006E784 File Offset: 0x0006C984
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0006E784 File Offset: 0x0006C984
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0006E790 File Offset: 0x0006C990
		private int GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5));
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0006E7F8 File Offset: 0x0006C9F8
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return this.ToString(stringBuilder);
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0006E81B File Offset: 0x0006CA1B
		string ITupleInternal.ToString(StringBuilder sb)
		{
			return this.ToString(sb);
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0006E824 File Offset: 0x0006CA24
		private string ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(", ");
			sb.Append(this.m_Item3);
			sb.Append(", ");
			sb.Append(this.m_Item4);
			sb.Append(", ");
			sb.Append(this.m_Item5);
			sb.Append(')');
			return sb.ToString();
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06002413 RID: 9235 RVA: 0x00022705 File Offset: 0x00020905
		int ITuple.Length
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x170007A3 RID: 1955
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
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
		}

		// Token: 0x040006AB RID: 1707
		private readonly T1 m_Item1;

		// Token: 0x040006AC RID: 1708
		private readonly T2 m_Item2;

		// Token: 0x040006AD RID: 1709
		private readonly T3 m_Item3;

		// Token: 0x040006AE RID: 1710
		private readonly T4 m_Item4;

		// Token: 0x040006AF RID: 1711
		private readonly T5 m_Item5;
	}
}
