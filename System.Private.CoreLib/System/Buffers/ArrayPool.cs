using System;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	// Token: 0x0200033E RID: 830
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class ArrayPool<[Nullable(2)] T>
	{
		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06003A8E RID: 14990 RVA: 0x000C2DFA File Offset: 0x000C0FFA
		public static ArrayPool<T> Shared
		{
			get
			{
				return ArrayPool<T>.s_shared;
			}
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x000C2E01 File Offset: 0x000C1001
		public static ArrayPool<T> Create()
		{
			return new ConfigurableArrayPool<T>();
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x000C2E08 File Offset: 0x000C1008
		public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket)
		{
			return new ConfigurableArrayPool<T>(maxArrayLength, maxArraysPerBucket);
		}

		// Token: 0x06003A91 RID: 14993
		public abstract T[] Rent(int minimumLength);

		// Token: 0x06003A92 RID: 14994
		public abstract void Return(T[] array, bool clearArray = false);

		// Token: 0x04000C30 RID: 3120
		private static readonly SharedArrayPool<T> s_shared = new SharedArrayPool<T>();
	}
}
