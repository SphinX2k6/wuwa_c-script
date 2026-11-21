using System;
using System.Runtime.CompilerServices;

namespace System.Collections
{
	// Token: 0x02000007 RID: 7
	[NullableContext(1)]
	[Nullable(0)]
	public static class StructuralComparisons
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003AEB File Offset: 0x00001CEB
		public static IComparer StructuralComparer
		{
			get
			{
				return System.Collections.StructuralComparer.s_instance;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003AF2 File Offset: 0x00001CF2
		public static IEqualityComparer StructuralEqualityComparer
		{
			get
			{
				return System.Collections.StructuralEqualityComparer.s_instance;
			}
		}
	}
}
