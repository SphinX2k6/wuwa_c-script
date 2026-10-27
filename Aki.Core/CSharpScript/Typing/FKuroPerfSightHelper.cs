using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000120 RID: 288
	[NullableContext(1)]
	[Nullable(0)]
	public class FKuroPerfSightHelper
	{
		// Token: 0x06000A4C RID: 2636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void UnRegisterTickGroupEvent_Internal();

		// Token: 0x06000A4D RID: 2637 RVA: 0x00033B7A File Offset: 0x00031D7A
		public static void UnRegisterTickGroupEvent()
		{
			FKuroPerfSightHelper.UnRegisterTickGroupEvent_Internal();
		}

		// Token: 0x06000A4E RID: 2638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void UnRegisterOnFrameBegin_Internal();

		// Token: 0x06000A4F RID: 2639 RVA: 0x00033B81 File Offset: 0x00031D81
		public static void UnRegisterOnFrameBegin()
		{
			FKuroPerfSightHelper.UnRegisterOnFrameBegin_Internal();
		}

		// Token: 0x06000A50 RID: 2640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetStrategyById_Internal(int strategyId, int strategyValue);

		// Token: 0x06000A51 RID: 2641 RVA: 0x00033B88 File Offset: 0x00031D88
		public static void SetStrategyById(int strategyId, int strategyValue)
		{
			FKuroPerfSightHelper.SetStrategyById_Internal(strategyId, strategyValue);
		}

		// Token: 0x06000A52 RID: 2642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFlameGraphStrMapSize_Internal(int inSize);

		// Token: 0x06000A53 RID: 2643 RVA: 0x00033B91 File Offset: 0x00031D91
		public static void SetFlameGraphStrMapSize(int inSize)
		{
			FKuroPerfSightHelper.SetFlameGraphStrMapSize_Internal(inSize);
		}

		// Token: 0x06000A54 RID: 2644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFlameGraphQueueSize_Internal(int length);

		// Token: 0x06000A55 RID: 2645 RVA: 0x00033B99 File Offset: 0x00031D99
		public static void SetFlameGraphQueueSize(int length)
		{
			FKuroPerfSightHelper.SetFlameGraphQueueSize_Internal(length);
		}

		// Token: 0x06000A56 RID: 2646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFlameGraphDropThresholds_Internal(int threshold);

		// Token: 0x06000A57 RID: 2647 RVA: 0x00033BA1 File Offset: 0x00031DA1
		public static void SetFlameGraphDropThresholds(int threshold)
		{
			FKuroPerfSightHelper.SetFlameGraphDropThresholds_Internal(threshold);
		}

		// Token: 0x06000A58 RID: 2648
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SafePushCall_Internal(char* callGraphName);

		// Token: 0x06000A59 RID: 2649 RVA: 0x00033BAC File Offset: 0x00031DAC
		[NullableContext(2)]
		public unsafe static void SafePushCall(string callGraphName)
		{
			if (callGraphName == null)
			{
				callGraphName = string.Empty;
			}
			char* callGraphName2;
			if (callGraphName == null)
			{
				callGraphName2 = null;
			}
			else
			{
				fixed (char* ptr = callGraphName.GetPinnableReference())
				{
					callGraphName2 = ptr;
				}
			}
			FKuroPerfSightHelper.SafePushCall_Internal(callGraphName2);
			char* ptr = null;
		}

		// Token: 0x06000A5A RID: 2650
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SafePopCall_Internal(char* callGraphName);

		// Token: 0x06000A5B RID: 2651 RVA: 0x00033BDC File Offset: 0x00031DDC
		[NullableContext(2)]
		public unsafe static void SafePopCall(string callGraphName)
		{
			if (callGraphName == null)
			{
				callGraphName = string.Empty;
			}
			char* callGraphName2;
			if (callGraphName == null)
			{
				callGraphName2 = null;
			}
			else
			{
				fixed (char* ptr = callGraphName.GetPinnableReference())
				{
					callGraphName2 = ptr;
				}
			}
			FKuroPerfSightHelper.SafePopCall_Internal(callGraphName2);
			char* ptr = null;
		}

		// Token: 0x06000A5C RID: 2652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterTickGroupEvent_Internal();

		// Token: 0x06000A5D RID: 2653 RVA: 0x00033C0B File Offset: 0x00031E0B
		public static void RegisterTickGroupEvent()
		{
			FKuroPerfSightHelper.RegisterTickGroupEvent_Internal();
		}

		// Token: 0x06000A5E RID: 2654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterOnFrameBegin_Internal(in FString callGraphName);

		// Token: 0x06000A5F RID: 2655 RVA: 0x00033C14 File Offset: 0x00031E14
		public unsafe static void RegisterOnFrameBegin(string callGraphName)
		{
			FString fstring = FString.AllocTemp(callGraphName);
			FKuroPerfSightHelper.RegisterOnFrameBegin_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000A60 RID: 2656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueString_Internal(in FString category, in FString key, in FString value);

		// Token: 0x06000A61 RID: 2657 RVA: 0x00033C38 File Offset: 0x00031E38
		public unsafe static void PostValueString(string category, string key, string value)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FString fstring3 = FString.AllocTemp(value);
			FKuroPerfSightHelper.PostValueString_Internal(fstring, fstring2, fstring3);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			FString.NativeDestruct(&fstring3, 1);
		}

		// Token: 0x06000A62 RID: 2658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueInteger3_Internal(in FString category, in FString key, int valueA, int valueB, int valueC);

		// Token: 0x06000A63 RID: 2659 RVA: 0x00033C80 File Offset: 0x00031E80
		public unsafe static void PostValueInteger3(string category, string key, int valueA, int valueB, int valueC)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueInteger3_Internal(fstring, fstring2, valueA, valueB, valueC);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000A64 RID: 2660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueInteger2_Internal(in FString category, in FString key, int valueA, int valueB);

		// Token: 0x06000A65 RID: 2661 RVA: 0x00033CBC File Offset: 0x00031EBC
		public unsafe static void PostValueInteger2(string category, string key, int valueA, int valueB)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueInteger2_Internal(fstring, fstring2, valueA, valueB);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000A66 RID: 2662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueInteger1_Internal(in FString category, in FString key, int valueA);

		// Token: 0x06000A67 RID: 2663 RVA: 0x00033CF4 File Offset: 0x00031EF4
		public unsafe static void PostValueInteger1(string category, string key, int valueA)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueInteger1_Internal(fstring, fstring2, valueA);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000A68 RID: 2664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueFloat3_Internal(in FString category, in FString key, float valueA, float valueB, float valueC);

		// Token: 0x06000A69 RID: 2665 RVA: 0x00033D2C File Offset: 0x00031F2C
		public unsafe static void PostValueFloat3(string category, string key, float valueA, float valueB, float valueC)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueFloat3_Internal(fstring, fstring2, valueA, valueB, valueC);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000A6A RID: 2666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueFloat2_Internal(in FString category, in FString key, float valueA, float valueB);

		// Token: 0x06000A6B RID: 2667 RVA: 0x00033D68 File Offset: 0x00031F68
		public unsafe static void PostValueFloat2(string category, string key, float valueA, float valueB)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueFloat2_Internal(fstring, fstring2, valueA, valueB);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000A6C RID: 2668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueFloat1_Internal(in FString category, in FString key, float valueA);

		// Token: 0x06000A6D RID: 2669 RVA: 0x00033DA0 File Offset: 0x00031FA0
		public unsafe static void PostValueFloat1(string category, string key, float valueA)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueFloat1_Internal(fstring, fstring2, valueA);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000A6E RID: 2670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostFrame_Internal(float deltaTime);

		// Token: 0x06000A6F RID: 2671 RVA: 0x00033DD7 File Offset: 0x00031FD7
		public static void PostFrame(float deltaTime)
		{
			FKuroPerfSightHelper.PostFrame_Internal(deltaTime);
		}

		// Token: 0x06000A70 RID: 2672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void MarkStartUpFinish_Internal();

		// Token: 0x06000A71 RID: 2673 RVA: 0x00033DDF File Offset: 0x00031FDF
		public static void MarkStartUpFinish()
		{
			FKuroPerfSightHelper.MarkStartUpFinish_Internal();
		}

		// Token: 0x06000A72 RID: 2674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsOnFrameBeginRegistered_Internal();

		// Token: 0x06000A73 RID: 2675 RVA: 0x00033DE6 File Offset: 0x00031FE6
		public static bool IsOnFrameBeginRegistered()
		{
			return FKuroPerfSightHelper.IsOnFrameBeginRegistered_Internal();
		}

		// Token: 0x06000A74 RID: 2676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsBeginCallGraphCalled_Internal();

		// Token: 0x06000A75 RID: 2677 RVA: 0x00033DED File Offset: 0x00031FED
		public static bool IsBeginCallGraphCalled()
		{
			return FKuroPerfSightHelper.IsBeginCallGraphCalled_Internal();
		}

		// Token: 0x06000A76 RID: 2678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void EndExtTag_Internal(in FString tagName);

		// Token: 0x06000A77 RID: 2679 RVA: 0x00033DF4 File Offset: 0x00031FF4
		public unsafe static void EndExtTag(string tagName)
		{
			FString fstring = FString.AllocTemp(tagName);
			FKuroPerfSightHelper.EndExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000A78 RID: 2680
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void EndCallGraph_Internal(char* name);

		// Token: 0x06000A79 RID: 2681 RVA: 0x00033E18 File Offset: 0x00032018
		[NullableContext(2)]
		public unsafe static void EndCallGraph(string name)
		{
			if (name == null)
			{
				name = string.Empty;
			}
			char* name2;
			if (name == null)
			{
				name2 = null;
			}
			else
			{
				fixed (char* ptr = name.GetPinnableReference())
				{
					name2 = ptr;
				}
			}
			FKuroPerfSightHelper.EndCallGraph_Internal(name2);
			char* ptr = null;
		}

		// Token: 0x06000A7A RID: 2682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void EnableTimedReport_Internal();

		// Token: 0x06000A7B RID: 2683 RVA: 0x00033E47 File Offset: 0x00032047
		public static void EnableTimedReport()
		{
			FKuroPerfSightHelper.EnableTimedReport_Internal();
		}

		// Token: 0x06000A7C RID: 2684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void BeginExtTag_Internal(in FString tagName);

		// Token: 0x06000A7D RID: 2685 RVA: 0x00033E50 File Offset: 0x00032050
		public unsafe static void BeginExtTag(string tagName)
		{
			FString fstring = FString.AllocTemp(tagName);
			FKuroPerfSightHelper.BeginExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000A7E RID: 2686
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void BeginCallGraph_Internal(char* name);

		// Token: 0x06000A7F RID: 2687 RVA: 0x00033E74 File Offset: 0x00032074
		[NullableContext(2)]
		public unsafe static void BeginCallGraph(string name)
		{
			if (name == null)
			{
				name = string.Empty;
			}
			char* name2;
			if (name == null)
			{
				name2 = null;
			}
			else
			{
				fixed (char* ptr = name.GetPinnableReference())
				{
					name2 = ptr;
				}
			}
			FKuroPerfSightHelper.BeginCallGraph_Internal(name2);
			char* ptr = null;
		}
	}
}
