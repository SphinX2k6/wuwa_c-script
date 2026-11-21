using System;
using System.Runtime.CompilerServices;

namespace System.Collections.Generic
{
	// Token: 0x020009E3 RID: 2531
	public sealed class ReferenceEqualityComparer : IEqualityComparer<object>, IEqualityComparer
	{
		// Token: 0x060093E5 RID: 37861 RVA: 0x00005ACC File Offset: 0x00003CCC
		private ReferenceEqualityComparer()
		{
		}

		// Token: 0x1700142B RID: 5163
		// (get) Token: 0x060093E6 RID: 37862 RVA: 0x001711DB File Offset: 0x0016F3DB
		[Nullable(1)]
		public static ReferenceEqualityComparer Instance { [NullableContext(1)] get; } = new ReferenceEqualityComparer();

		// Token: 0x060093E7 RID: 37863 RVA: 0x0016D6FD File Offset: 0x0016B8FD
		[NullableContext(2)]
		public bool Equals(object x, object y)
		{
			return x == y;
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x001711E2 File Offset: 0x0016F3E2
		[NullableContext(2)]
		public int GetHashCode(object obj)
		{
			return RuntimeHelpers.GetHashCode(obj);
		}
	}
}
