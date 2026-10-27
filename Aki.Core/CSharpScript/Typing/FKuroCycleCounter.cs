using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011E RID: 286
	[NullableContext(1)]
	[Nullable(0)]
	public static class FKuroCycleCounter
	{
		// Token: 0x06000A3C RID: 2620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeEnvironment_Internal();

		// Token: 0x06000A3D RID: 2621 RVA: 0x00033B26 File Offset: 0x00031D26
		public static void InitializeEnvironment()
		{
			FKuroCycleCounter.InitializeEnvironment_Internal();
		}

		// Token: 0x06000A3E RID: 2622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int CreateCycleCounter_Internal(string Name);

		// Token: 0x06000A3F RID: 2623 RVA: 0x00033B30 File Offset: 0x00031D30
		public static int CreateCycleCounter(string statName)
		{
			return FKuroCycleCounter.CreateCycleCounter_Internal(statName);
		}

		// Token: 0x06000A40 RID: 2624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void StartCycleCounter_Internal(int StatIndex);

		// Token: 0x06000A41 RID: 2625 RVA: 0x00033B43 File Offset: 0x00031D43
		public static void StartCycleCounter(int statIndex)
		{
			FKuroCycleCounter.StartCycleCounter_Internal(statIndex);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00033B4B File Offset: 0x00031D4B
		public static void StartCycleCounterByName(FName statName)
		{
			FKuroCycleCounter.StartCycleCounter_Internal(FKuroCycleCounter.CreateCycleCounter_Internal(statName.ToString()));
		}

		// Token: 0x06000A43 RID: 2627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void StopCycleCounter_Internal();

		// Token: 0x06000A44 RID: 2628 RVA: 0x00033B64 File Offset: 0x00031D64
		public static void StopCycleCounter()
		{
			FKuroCycleCounter.StopCycleCounter_Internal();
		}

		// Token: 0x06000A45 RID: 2629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DestroyEnvironment_Internal();

		// Token: 0x06000A46 RID: 2630 RVA: 0x00033B6B File Offset: 0x00031D6B
		public static void DestroyEnvironment()
		{
			FKuroCycleCounter.DestroyEnvironment_Internal();
		}
	}
}
