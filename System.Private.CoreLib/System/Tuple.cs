using System;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020001D6 RID: 470
	[NullableContext(1)]
	[Nullable(0)]
	public static class Tuple
	{
		// Token: 0x060023A7 RID: 9127 RVA: 0x0006DAE8 File Offset: 0x0006BCE8
		public static Tuple<T1> Create<[Nullable(2)] T1>(T1 item1)
		{
			return new Tuple<T1>(item1);
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0006DAF0 File Offset: 0x0006BCF0
		public static Tuple<T1, T2> Create<[Nullable(2)] T1, [Nullable(2)] T2>(T1 item1, T2 item2)
		{
			return new Tuple<T1, T2>(item1, item2);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0006DAF9 File Offset: 0x0006BCF9
		public static Tuple<T1, T2, T3> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3>(T1 item1, T2 item2, T3 item3)
		{
			return new Tuple<T1, T2, T3>(item1, item2, item3);
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0006DB03 File Offset: 0x0006BD03
		public static Tuple<T1, T2, T3, T4> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4>(T1 item1, T2 item2, T3 item3, T4 item4)
		{
			return new Tuple<T1, T2, T3, T4>(item1, item2, item3, item4);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0006DB0E File Offset: 0x0006BD0E
		public static Tuple<T1, T2, T3, T4, T5> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
		{
			return new Tuple<T1, T2, T3, T4, T5>(item1, item2, item3, item4, item5);
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0006DB1B File Offset: 0x0006BD1B
		public static Tuple<T1, T2, T3, T4, T5, T6> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
		{
			return new Tuple<T1, T2, T3, T4, T5, T6>(item1, item2, item3, item4, item5, item6);
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x0006DB2A File Offset: 0x0006BD2A
		public static Tuple<T1, T2, T3, T4, T5, T6, T7> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
		{
			return new Tuple<T1, T2, T3, T4, T5, T6, T7>(item1, item2, item3, item4, item5, item6, item7);
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x0006DB3B File Offset: 0x0006BD3B
		public static Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>> Create<[Nullable(2)] T1, [Nullable(2)] T2, [Nullable(2)] T3, [Nullable(2)] T4, [Nullable(2)] T5, [Nullable(2)] T6, [Nullable(2)] T7, [Nullable(2)] T8>(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, T8 item8)
		{
			return new Tuple<T1, T2, T3, T4, T5, T6, T7, Tuple<T8>>(item1, item2, item3, item4, item5, item6, item7, new Tuple<T8>(item8));
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x0006DB53 File Offset: 0x0006BD53
		internal static int CombineHashCodes(int h1, int h2)
		{
			return (h1 << 5) + h1 ^ h2;
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x0006DB5C File Offset: 0x0006BD5C
		internal static int CombineHashCodes(int h1, int h2, int h3)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2), h3);
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x0006DB6B File Offset: 0x0006BD6B
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2), Tuple.CombineHashCodes(h3, h4));
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0006DB80 File Offset: 0x0006BD80
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2, h3, h4), h5);
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0006DB92 File Offset: 0x0006BD92
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2, h3, h4), Tuple.CombineHashCodes(h5, h6));
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0006DBAB File Offset: 0x0006BDAB
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2, h3, h4), Tuple.CombineHashCodes(h5, h6, h7));
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x0006DBC6 File Offset: 0x0006BDC6
		internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
		{
			return Tuple.CombineHashCodes(Tuple.CombineHashCodes(h1, h2, h3, h4), Tuple.CombineHashCodes(h5, h6, h7, h8));
		}
	}
}
