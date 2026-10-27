using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Typing
{
	// Token: 0x02000037 RID: 55
	[NullableContext(1)]
	[Nullable(0)]
	public static class FThinkingAnalyticsForCSharp
	{
		// Token: 0x060001FF RID: 511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Track_Internal(string eventName, string properties, int index = 0);

		// Token: 0x06000200 RID: 512 RVA: 0x0000B27E File Offset: 0x0000947E
		public static bool Track(string eventName, string properties, int index = 0)
		{
			return FThinkingAnalyticsForCSharp.Track_Internal(eventName, properties, index);
		}

		// Token: 0x06000201 RID: 513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Flush_Internal(int index = 0);

		// Token: 0x06000202 RID: 514 RVA: 0x0000B288 File Offset: 0x00009488
		public static void Flush(int index = 0)
		{
			FThinkingAnalyticsForCSharp.Flush_Internal(index);
		}
	}
}
