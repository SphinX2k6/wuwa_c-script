using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001DA RID: 474
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Tuple<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x0006E212 File Offset: 0x0006C412
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x060023ED RID: 9197 RVA: 0x0006E21A File Offset: 0x0006C41A
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x0006E222 File Offset: 0x0006C422
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0006E22A File Offset: 0x0006C42A
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x0006E232 File Offset: 0x0006C432
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x0006E257 File Offset: 0x0006C457
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj, EqualityComparer<object>.Default);
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x0006E265 File Offset: 0x0006C465
		bool IStructuralEquatable.Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			return this.Equals(other, comparer);
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x0006E270 File Offset: 0x0006C470
		private bool Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4> tuple = other as Tuple<T1, T2, T3, T4>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3)) && comparer.Equals(this.m_Item4, tuple.m_Item4);
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x0006E306 File Offset: 0x0006C506
		int IComparable.CompareTo(object obj)
		{
			return this.CompareTo(obj, Comparer<object>.Default);
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x0006E314 File Offset: 0x0006C514
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return this.CompareTo(other, comparer);
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0006E320 File Offset: 0x0006C520
		private int CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4> tuple = other as Tuple<T1, T2, T3, T4>;
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
			return comparer.Compare(this.m_Item4, tuple.m_Item4);
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0006E3D9 File Offset: 0x0006C5D9
		public override int GetHashCode()
		{
			return this.GetHashCode(EqualityComparer<object>.Default);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0006E3E6 File Offset: 0x0006C5E6
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0006E3E6 File Offset: 0x0006C5E6
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
		private int GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4));
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0006E448 File Offset: 0x0006C648
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return this.ToString(stringBuilder);
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x0006E46B File Offset: 0x0006C66B
		string ITupleInternal.ToString(StringBuilder sb)
		{
			return this.ToString(sb);
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0006E474 File Offset: 0x0006C674
		private string ToString(StringBuilder sb)
		{
			sb.Append(this.m_Item1);
			sb.Append(", ");
			sb.Append(this.m_Item2);
			sb.Append(", ");
			sb.Append(this.m_Item3);
			sb.Append(", ");
			sb.Append(this.m_Item4);
			sb.Append(')');
			return sb.ToString();
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x000211FB File Offset: 0x0001F3FB
		int ITuple.Length
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x1700079C RID: 1948
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
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
		}

		// Token: 0x040006A7 RID: 1703
		private readonly T1 m_Item1;

		// Token: 0x040006A8 RID: 1704
		private readonly T2 m_Item2;

		// Token: 0x040006A9 RID: 1705
		private readonly T3 m_Item3;

		// Token: 0x040006AA RID: 1706
		private readonly T4 m_Item4;
	}
}
