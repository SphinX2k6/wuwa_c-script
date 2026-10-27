using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Typing
{
	// Token: 0x02000036 RID: 54
	[NullableContext(1)]
	[Nullable(0)]
	public static class FKuroAnalyticsForCSharp
	{
		// Token: 0x060001FB RID: 507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Track_Internal(string eventName, string properties, int index = 0);

		// Token: 0x060001FC RID: 508 RVA: 0x0000B26C File Offset: 0x0000946C
		public static bool Track(string eventName, string properties, int index = 0)
		{
			return FKuroAnalyticsForCSharp.Track_Internal(eventName, properties, index);
		}

		// Token: 0x060001FD RID: 509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Flush_Internal(int index = 0);

		// Token: 0x060001FE RID: 510 RVA: 0x0000B276 File Offset: 0x00009476
		public static void Flush(int index = 0)
		{
			FKuroAnalyticsForCSharp.Flush_Internal(index);
		}
	}
}
