using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001DD RID: 477
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Tuple<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x0006EDB4 File Offset: 0x0006CFB4
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x0600242C RID: 9260 RVA: 0x0006EDBC File Offset: 0x0006CFBC
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x0006EDC4 File Offset: 0x0006CFC4
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x0006EDCC File Offset: 0x0006CFCC
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x0006EDD4 File Offset: 0x0006CFD4
		public T5 Item5
		{
			get
			{
				return this.m_Item5;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x0006EDDC File Offset: 0x0006CFDC
		public T6 Item6
		{
			get
			{
				return this.m_Item6;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x0006EDE4 File Offset: 0x0006CFE4
		public T7 Item7
		{
			get
			{
				return this.m_Item7;
			}
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0006EDEC File Offset: 0x0006CFEC
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
			this.m_Item5 = item5;
			this.m_Item6 = item6;
			this.m_Item7 = item7;
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0006EE29 File Offset: 0x0006D029
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj, EqualityComparer<object>.Default);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x0006EE37 File Offset: 0x0006D037
		bool IStructuralEquatable.Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			return this.Equals(other, comparer);
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0006EE44 File Offset: 0x0006D044
		private bool Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7> tuple = other as Tuple<T1, T2, T3, T4, T5, T6, T7>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3) && comparer.Equals(this.m_Item4, tuple.m_Item4) && comparer.Equals(this.m_Item5, tuple.m_Item5) && comparer.Equals(this.m_Item6, tuple.m_Item6)) && comparer.Equals(this.m_Item7, tuple.m_Item7);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0006EF3A File Offset: 0x0006D13A
		int IComparable.CompareTo(object obj)
		{
			return ((IStructuralComparable)this).CompareTo(obj, Comparer<object>.Default);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0006EF48 File Offset: 0x0006D148
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return this.CompareTo(other, comparer);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0006EF54 File Offset: 0x0006D154
		private int CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7> tuple = other as Tuple<T1, T2, T3, T4, T5, T6, T7>;
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
			num = comparer.Compare(this.m_Item5, tuple.m_Item5);
			if (num != 0)
			{
				return num;
			}
			num = comparer.Compare(this.m_Item6, tuple.m_Item6);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Item7, tuple.m_Item7);
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0006F073 File Offset: 0x0006D273
		public override int GetHashCode()
		{
			return this.GetHashCode(EqualityComparer<object>.Default);
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x0006F080 File Offset: 0x0006D280
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0006F080 File Offset: 0x0006D280
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0006F08C File Offset: 0x0006D28C
		private int GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7));
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0006F118 File Offset: 0x0006D318
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return this.ToString(stringBuilder);
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x0006F13B File Offset: 0x0006D33B
		string ITupleInternal.ToString(StringBuilder sb)
		{
			return this.ToString(sb);
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0006F144 File Offset: 0x0006D344
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
			sb.Append(", ");
			sb.Append(this.m_Item6);
			sb.Append(", ");
			sb.Append(this.m_Item7);
			sb.Append(')');
			return sb.ToString();
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06002440 RID: 9280 RVA: 0x0003EE4B File Offset: 0x0003D04B
		int ITuple.Length
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x170007B4 RID: 1972
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
				case 6:
					result = this.Item7;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
		}

		// Token: 0x040006B6 RID: 1718
		private readonly T1 m_Item1;

		// Token: 0x040006B7 RID: 1719
		private readonly T2 m_Item2;

		// Token: 0x040006B8 RID: 1720
		private readonly T3 m_Item3;

		// Token: 0x040006B9 RID: 1721
		private readonly T4 m_Item4;

		// Token: 0x040006BA RID: 1722
		private readonly T5 m_Item5;

		// Token: 0x040006BB RID: 1723
		private readonly T6 m_Item6;

		// Token: 0x040006BC RID: 1724
		private readonly T7 m_Item7;
	}
}
