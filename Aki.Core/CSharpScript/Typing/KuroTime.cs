using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Typing
{
	// Token: 0x02000127 RID: 295
	public class KuroTime
	{
		// Token: 0x06000AA5 RID: 2725
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetCycles64();

		// Token: 0x06000AA6 RID: 2726
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ulong GetCycles64BigInt();

		// Token: 0x06000AA7 RID: 2727
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetMicroseconds64();

		// Token: 0x06000AA8 RID: 2728
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetMilliseconds64();

		// Token: 0x06000AA9 RID: 2729
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetSecondsPerCycle();
	}
}
