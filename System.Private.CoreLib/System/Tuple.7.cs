using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001DC RID: 476
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Tuple<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06002415 RID: 9237 RVA: 0x0006E942 File Offset: 0x0006CB42
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x0006E94A File Offset: 0x0006CB4A
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x0006E952 File Offset: 0x0006CB52
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x0006E95A File Offset: 0x0006CB5A
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x0006E962 File Offset: 0x0006CB62
		public T5 Item5
		{
			get
			{
				return this.m_Item5;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x0006E96A File Offset: 0x0006CB6A
		public T6 Item6
		{
			get
			{
				return this.m_Item6;
			}
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0006E972 File Offset: 0x0006CB72
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
			this.m_Item5 = item5;
			this.m_Item6 = item6;
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0006E9A7 File Offset: 0x0006CBA7
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj, EqualityComparer<object>.Default);
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0006E9B5 File Offset: 0x0006CBB5
		bool IStructuralEquatable.Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			return this.Equals(other, comparer);
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x0006E9C0 File Offset: 0x0006CBC0
		private bool Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6> tuple = other as Tuple<T1, T2, T3, T4, T5, T6>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3) && comparer.Equals(this.m_Item4, tuple.m_Item4) && comparer.Equals(this.m_Item5, tuple.m_Item5)) && comparer.Equals(this.m_Item6, tuple.m_Item6);
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x0006EA95 File Offset: 0x0006CC95
		int IComparable.CompareTo(object obj)
		{
			return this.CompareTo(obj, Comparer<object>.Default);
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x0006EAA3 File Offset: 0x0006CCA3
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return this.CompareTo(other, comparer);
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0006EAB0 File Offset: 0x0006CCB0
		private int CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4, T5, T6> tuple = other as Tuple<T1, T2, T3, T4, T5, T6>;
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
			return comparer.Compare(this.m_Item6, tuple.m_Item6);
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x0006EBAD File Offset: 0x0006CDAD
		public override int GetHashCode()
		{
			return this.GetHashCode(EqualityComparer<object>.Default);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0006EBBA File Offset: 0x0006CDBA
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x0006EBBA File Offset: 0x0006CDBA
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x0006EBC4 File Offset: 0x0006CDC4
		private int GetHashCode(IEqualityComparer comparer)
		{
			return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6));
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x0006EC3C File Offset: 0x0006CE3C
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return this.ToString(stringBuilder);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x0006EC5F File Offset: 0x0006CE5F
		string ITupleInternal.ToString(StringBuilder sb)
		{
			return this.ToString(sb);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x0006EC68 File Offset: 0x0006CE68
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
			sb.Append(')');
			return sb.ToString();
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x0001FEB2 File Offset: 0x0001E0B2
		int ITuple.Length
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x170007AB RID: 1963
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

		// Token: 0x040006B0 RID: 1712
		private readonly T1 m_Item1;

		// Token: 0x040006B1 RID: 1713
		private readonly T2 m_Item2;

		// Token: 0x040006B2 RID: 1714
		private readonly T3 m_Item3;

		// Token: 0x040006B3 RID: 1715
		private readonly T4 m_Item4;

		// Token: 0x040006B4 RID: 1716
		private readonly T5 m_Item5;

		// Token: 0x040006B5 RID: 1717
		private readonly T6 m_Item6;
	}
}
