using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001F1 RID: 497
	[NullableContext(1)]
	[Nullable(0)]
	[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
	{
		// Token: 0x060027B9 RID: 10169 RVA: 0x0007820F File Offset: 0x0007640F
		[NullableContext(2)]
		public override bool Equals([NotNullWhen(true)] object obj)
		{
			return obj is ValueTuple;
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000070DD File Offset: 0x000052DD
		public bool Equals(ValueTuple other)
		{
			return true;
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x0007820F File Offset: 0x0007640F
		bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
		{
			return other is ValueTuple;
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x0007821A File Offset: 0x0007641A
		int IComparable.CompareTo(object other)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple))
			{
				ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
			}
			return 0;
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00007B65 File Offset: 0x00005D65
		public int CompareTo(ValueTuple other)
		{
			return 0;
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x0007821A File Offset: 0x0007641A
		int IStructuralComparable.CompareTo(object other, IComparer comparer)
		{
			if (other == null)
			{
				return 1;
			}
			if (!(other is ValueTuple))
			{
				ThrowHelper.ThrowArgumentException_TupleIncorrectType(this);
			}
			return 0;
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00007B65 File Offset: 0x00005D65
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00007B65 File Offset: 0x00005D65
		int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00007B65 File Offset: 0x00005D65
		int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
		{
			return 0;
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x0007823A File Offset: 0x0007643A
		public override string ToString()
		{
			return "()";
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00078241 File Offset: 0x00076441
		string IValueTupleInternal.ToStringEnd()
		{
			return ")";
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00007B65 File Offset: 0x00005D65
		int ITuple.Length
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000804 RID: 2052
		[Nullable(2)]
		object ITuple.this[int index]
		{
			get
			{
				throw new IndexOutOfRangeException();
			}
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00078248 File Offset: 0x00076448
		public static ValueTuple Create()
		{
			return default(ValueTuple);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0007825E File Offset: 0x0007645E
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static ValueTuple<T1> Create<[Nullable(2)] T1>(T1 item1)
		{
			return new ValueTuple<T1>(item1);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00078266 File Offset: 0x00076466
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public static ValueTuple<T1, T2> Create<[Nullable(2)] T1, [Nullable(2)] T2>(T1 item1, T2 item2)
		{
			return new ValueTuple<T1, T2>(item1, item2);
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x0007826F File Offset: 0x0007646F
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})]
		public static ValueTuple<T1, T2, T3> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(T1 item1, T2 item2, T3 item3)
		{
			return new ValueTuple<T1, T2, T3>(item1, item2, item3);
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00078279 File Offset: 0x00076479
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1
		})]
		public static ValueTuple<T1, T2, T3, T4> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			return new ValueTuple<T1, T2, T3, T4>(item1, item2, item3, item4);
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00078284 File Offset: 0x00076484
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1,
			1
		})]
		public static ValueTuple<T1, T2, T3, T4, T5> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			return new ValueTuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00078291 File Offset: 0x00076491
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1,
			1,
			1
		})]
		public static ValueTuple<T1, T2, T3, T4, T5, T6> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			return new ValueTuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x000782A0 File Offset: 0x000764A0
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1,
			1,
			1,
			1
		})]
		public static ValueTuple<T1, T2, T3, T4, T5, T6, T7> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			return new ValueTuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x000782B1 File Offset: 0x000764B1
		[return: Nullable(new byte[]
		{
			0,
			1,
			1,
			1,
			1,
			1,
			1,
			1,
			0,
			1
		})]
		public static ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8>> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7, [Nullable(2)] T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			return new ValueTuple<T1, T2, T3, T4, T5, T6, T7, ValueTuple<T8>>(item1, item2, item3, item4, item5, item6, item7, ValueTuple.Create<T8>(item8));
		}
	}
}
