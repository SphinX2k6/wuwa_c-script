using System;

namespace System.Text
{
	// Token: 0x0200024E RID: 590
	internal static class StringBuilderCache
	{
		// Token: 0x06002CEB RID: 11499 RVA: 0x0008F938 File Offset: 0x0008DB38
		public static StringBuilder Acquire(int capacity = 16)
		{
			if (capacity <= 360)
			{
				StringBuilder stringBuilder = StringBuilderCache.t_cachedInstance;
				if (stringBuilder != null && capacity <= stringBuilder.Capacity)
				{
					StringBuilderCache.t_cachedInstance = null;
					stringBuilder.Clear();
					return stringBuilder;
				}
			}
			return new StringBuilder(capacity);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x0008F974 File Offset: 0x0008DB74
		public static void Release(StringBuilder sb)
		{
			if (sb.Capacity <= 360)
			{
				StringBuilderCache.t_cachedInstance = sb;
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x0008F989 File Offset: 0x0008DB89
		public static string GetStringAndRelease(StringBuilder sb)
		{
			string result = sb.ToString();
			StringBuilderCache.Release(sb);
			return result;
		}

		// Token: 0x040007F2 RID: 2034
		[ThreadStatic]
		private static StringBuilder t_cachedInstance;
	}
}
