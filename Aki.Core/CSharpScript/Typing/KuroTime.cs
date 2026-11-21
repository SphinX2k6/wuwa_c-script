using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Typing
{
	// Token: 0x02000128 RID: 296
	public class KuroTime
	{
		// Token: 0x06000AFC RID: 2812
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetCycles64();

		// Token: 0x06000AFD RID: 2813
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern ulong GetCycles64BigInt();

		// Token: 0x06000AFE RID: 2814
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetMicroseconds64();

		// Token: 0x06000AFF RID: 2815
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetMilliseconds64();

		// Token: 0x06000B00 RID: 2816
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double GetSecondsPerCycle();
	}
}
