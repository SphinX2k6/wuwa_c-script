using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200011F RID: 287
	[NullableContext(1)]
	[Nullable(0)]
	public static class FKuroCycleCounter
	{
		// Token: 0x06000A93 RID: 2707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitializeEnvironment_Internal();

		// Token: 0x06000A94 RID: 2708 RVA: 0x0003459A File Offset: 0x0003279A
		public static void InitializeEnvironment()
		{
			FKuroCycleCounter.InitializeEnvironment_Internal();
		}

		// Token: 0x06000A95 RID: 2709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int CreateCycleCounter_Internal(string Name);

		// Token: 0x06000A96 RID: 2710 RVA: 0x000345A4 File Offset: 0x000327A4
		public static int CreateCycleCounter(string statName)
		{
			return FKuroCycleCounter.CreateCycleCounter_Internal(statName);
		}

		// Token: 0x06000A97 RID: 2711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void StartCycleCounter_Internal(int StatIndex);

		// Token: 0x06000A98 RID: 2712 RVA: 0x000345B7 File Offset: 0x000327B7
		public static void StartCycleCounter(int statIndex)
		{
			FKuroCycleCounter.StartCycleCounter_Internal(statIndex);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000345BF File Offset: 0x000327BF
		public static void StartCycleCounterByName(FName statName)
		{
			FKuroCycleCounter.StartCycleCounter_Internal(FKuroCycleCounter.CreateCycleCounter_Internal(statName.ToString()));
		}

		// Token: 0x06000A9A RID: 2714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void StopCycleCounter_Internal();

		// Token: 0x06000A9B RID: 2715 RVA: 0x000345D8 File Offset: 0x000327D8
		public static void StopCycleCounter()
		{
			FKuroCycleCounter.StopCycleCounter_Internal();
		}

		// Token: 0x06000A9C RID: 2716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void DestroyEnvironment_Internal();

		// Token: 0x06000A9D RID: 2717 RVA: 0x000345DF File Offset: 0x000327DF
		public static void DestroyEnvironment()
		{
			FKuroCycleCounter.DestroyEnvironment_Internal();
		}
	}
}
