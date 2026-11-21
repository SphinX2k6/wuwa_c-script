using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System
{
	// Token: 0x02000177 RID: 375
	public static class Nullable
	{
		// Token: 0x060018AF RID: 6319 RVA: 0x0004CE5A File Offset: 0x0004B05A
		public static int Compare<T>(T? n1, T? n2) where T : struct
		{
			if (n1 != null)
			{
				if (n2 != null)
				{
					return Comparer<T>.Default.Compare(n1.value, n2.value);
				}
				return 1;
			}
			else
			{
				if (n2 != null)
				{
					return -1;
				}
				return 0;
			}
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0004CE93 File Offset: 0x0004B093
		public static bool Equals<T>(T? n1, T? n2) where T : struct
		{
			if (n1 != null)
			{
				return n2 != null && EqualityComparer<T>.Default.Equals(n1.value, n2.value);
			}
			return n2 == null;
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0004CECC File Offset: 0x0004B0CC
		[NullableContext(1)]
		[return: Nullable(2)]
		public static Type GetUnderlyingType(Type nullableType)
		{
			ArgumentNullException.ThrowIfNull(nullableType, "nullableType");
			if (nullableType.IsGenericType && !nullableType.IsGenericTypeDefinition && nullableType.GetGenericTypeDefinition() == typeof(Nullable<>))
			{
				return nullableType.GetGenericArguments()[0];
			}
			return null;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0004CF05 File Offset: 0x0004B105
		public static ref readonly T GetValueRefOrDefaultRef<T>([RequiresLocation] [In] ref T? nullable) where T : struct
		{
			return ref nullable.value;
		}
	}
}
