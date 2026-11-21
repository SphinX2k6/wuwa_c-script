using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x0200003A RID: 58
	public static class KuroScreen
	{
		// Token: 0x06000227 RID: 551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double ComputePhysicalScreenDensity_Internal();

		// Token: 0x06000228 RID: 552 RVA: 0x0000B34E File Offset: 0x0000954E
		public static double ComputePhysicalScreenDensity()
		{
			return KuroScreen.ComputePhysicalScreenDensity_Internal();
		}

		// Token: 0x06000229 RID: 553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double GetPhysicalScreenDensityDPI_Internal();

		// Token: 0x0600022A RID: 554 RVA: 0x0000B355 File Offset: 0x00009555
		public static double GetPhysicalScreenDensityDPI()
		{
			return KuroScreen.GetPhysicalScreenDensityDPI_Internal();
		}

		// Token: 0x0600022B RID: 555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D GetDisplayScreenResolution_Internal();

		// Token: 0x0600022C RID: 556 RVA: 0x0000B35C File Offset: 0x0000955C
		public static FVector2D GetDisplayScreenResolution()
		{
			return KuroScreen.GetDisplayScreenResolution_Internal();
		}

		// Token: 0x0600022D RID: 557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D GetPhysicalScreenResolution_Internal();

		// Token: 0x0600022E RID: 558 RVA: 0x0000B363 File Offset: 0x00009563
		public static FVector2D GetPhysicalScreenResolution()
		{
			return KuroScreen.GetPhysicalScreenResolution_Internal();
		}

		// Token: 0x0600022F RID: 559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D GetPhysicalScreenResolutionV2_Internal();

		// Token: 0x06000230 RID: 560 RVA: 0x0000B36A File Offset: 0x0000956A
		public static FVector2D GetPhysicalScreenResolutionV2()
		{
			return KuroScreen.GetPhysicalScreenResolutionV2_Internal();
		}

		// Token: 0x06000231 RID: 561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double GetScreenLogicalDensity_Internal();

		// Token: 0x06000232 RID: 562 RVA: 0x0000B371 File Offset: 0x00009571
		public static double GetScreenLogicalDensity()
		{
			return KuroScreen.GetScreenLogicalDensity_Internal();
		}

		// Token: 0x06000233 RID: 563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double GetScreenScaledDensity_Internal();

		// Token: 0x06000234 RID: 564 RVA: 0x0000B378 File Offset: 0x00009578
		public static double GetScreenScaledDensity()
		{
			return KuroScreen.GetScreenScaledDensity_Internal();
		}

		// Token: 0x06000235 RID: 565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double GetScreenDensityDPI_Internal();

		// Token: 0x06000236 RID: 566 RVA: 0x0000B37F File Offset: 0x0000957F
		public static double GetScreenDensityDPI()
		{
			return KuroScreen.GetScreenDensityDPI_Internal();
		}
	}
}
