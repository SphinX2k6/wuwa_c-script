using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

namespace System
{
	// Token: 0x020001DE RID: 478
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class Tuple<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7, TRest> : IStructuralEquatable, IStructuralComparable, IComparable, ITupleInternal, ITuple
	{
		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x0006F2C2 File Offset: 0x0006D4C2
		public T1 Item1
		{
			get
			{
				return this.m_Item1;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06002443 RID: 9283 RVA: 0x0006F2CA File Offset: 0x0006D4CA
		public T2 Item2
		{
			get
			{
				return this.m_Item2;
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x0006F2D2 File Offset: 0x0006D4D2
		public T3 Item3
		{
			get
			{
				return this.m_Item3;
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06002445 RID: 9285 RVA: 0x0006F2DA File Offset: 0x0006D4DA
		public T4 Item4
		{
			get
			{
				return this.m_Item4;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x0006F2E2 File Offset: 0x0006D4E2
		public T5 Item5
		{
			get
			{
				return this.m_Item5;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0006F2EA File Offset: 0x0006D4EA
		public T6 Item6
		{
			get
			{
				return this.m_Item6;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0006F2F2 File Offset: 0x0006D4F2
		public T7 Item7
		{
			get
			{
				return this.m_Item7;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002449 RID: 9289 RVA: 0x0006F2FA File Offset: 0x0006D4FA
		public TRest Rest
		{
			get
			{
				return this.m_Rest;
			}
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0006F304 File Offset: 0x0006D504
		public Tuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
		{
			if (!(rest is ITupleInternal))
			{
				throw new ArgumentException(SR.ArgumentException_TupleLastArgumentNotATuple);
			}
			this.m_Item1 = item1;
			this.m_Item2 = item2;
			this.m_Item3 = item3;
			this.m_Item4 = item4;
			this.m_Item5 = item5;
			this.m_Item6 = item6;
			this.m_Item7 = item7;
			this.m_Rest = rest;
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0006F36D File Offset: 0x0006D56D
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return this.Equals(obj, EqualityComparer<object>.Default);
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x0006F37B File Offset: 0x0006D57B
		bool IStructuralEquatable.Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			return this.Equals(other, comparer);
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x0006F388 File Offset: 0x0006D588
		private bool Equals([NotNullWhen(true)] object other, IEqualityComparer comparer)
		{
			if (other == null)
			{
				return false;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple = other as Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>;
			return tuple != null && (comparer.Equals(this.m_Item1, tuple.m_Item1) && comparer.Equals(this.m_Item2, tuple.m_Item2) && comparer.Equals(this.m_Item3, tuple.m_Item3) && comparer.Equals(this.m_Item4, tuple.m_Item4) && comparer.Equals(this.m_Item5, tuple.m_Item5) && comparer.Equals(this.m_Item6, tuple.m_Item6) && comparer.Equals(this.m_Item7, tuple.m_Item7)) && comparer.Equals(this.m_Rest, tuple.m_Rest);
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x0006F49F File Offset: 0x0006D69F
		int IComparable.CompareTo(object obj)
		{
			return this.CompareTo(obj, Comparer<object>.Default);
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0006F4AD File Offset: 0x0006D6AD
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			return this.CompareTo(other, comparer);
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0006F4B8 File Offset: 0x0006D6B8
		private int CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			Tuple<T1, T2, T3, T4, T5, T6, T7, TRest> tuple = other as Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>;
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
			num = comparer.Compare(this.m_Item7, tuple.m_Item7);
			if (num != 0)
			{
				return num;
			}
			return comparer.Compare(this.m_Rest, tuple.m_Rest);
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x0006F5F9 File Offset: 0x0006D7F9
		public override int GetHashCode()
		{
			return this.GetHashCode(EqualityComparer<object>.Default);
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0006F606 File Offset: 0x0006D806
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0006F610 File Offset: 0x0006D810
		private int GetHashCode(IEqualityComparer comparer)
		{
			ITupleInternal tupleInternal = (ITupleInternal)((object)this.m_Rest);
			if (tupleInternal.Length >= 8)
			{
				return tupleInternal.GetHashCode(comparer);
			}
			switch (8 - tupleInternal.Length)
			{
			case 1:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 2:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 3:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 4:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 5:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 6:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			case 7:
				return Tuple.CombineHashCodes(comparer.GetHashCode(this.m_Item1), comparer.GetHashCode(this.m_Item2), comparer.GetHashCode(this.m_Item3), comparer.GetHashCode(this.m_Item4), comparer.GetHashCode(this.m_Item5), comparer.GetHashCode(this.m_Item6), comparer.GetHashCode(this.m_Item7), tupleInternal.GetHashCode(comparer));
			default:
				return -1;
			}
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0006F606 File Offset: 0x0006D806
		int ITupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return this.GetHashCode(comparer);
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0006F8AC File Offset: 0x0006DAAC
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append('(');
			return this.ToString(stringBuilder);
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0006F8CF File Offset: 0x0006DACF
		string ITupleInternal.ToString(StringBuilder sb)
		{
			return this.ToString(sb);
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0006F8D8 File Offset: 0x0006DAD8
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
			sb.Append(", ");
			return ((ITupleInternal)((object)this.m_Rest)).ToString(sb);
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002458 RID: 9304 RVA: 0x0006F9CD File Offset: 0x0006DBCD
		int ITuple.Length
		{
			get
			{
				return 7 + ((ITupleInternal)((object)this.Rest)).Length;
			}
		}

		// Token: 0x170007BE RID: 1982
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
					result = ((ITupleInternal)((object)this.Rest))[index - 7];
					break;
				}
				return result;
			}
		}

		// Token: 0x040006BD RID: 1725
		private readonly T1 m_Item1;

		// Token: 0x040006BE RID: 1726
		private readonly T2 m_Item2;

		// Token: 0x040006BF RID: 1727
		private readonly T3 m_Item3;

		// Token: 0x040006C0 RID: 1728
		private readonly T4 m_Item4;

		// Token: 0x040006C1 RID: 1729
		private readonly T5 m_Item5;

		// Token: 0x040006C2 RID: 1730
		private readonly T6 m_Item6;

		// Token: 0x040006C3 RID: 1731
		private readonly T7 m_Item7;

		// Token: 0x040006C4 RID: 1732
		private readonly TRest m_Rest;
	}
}
