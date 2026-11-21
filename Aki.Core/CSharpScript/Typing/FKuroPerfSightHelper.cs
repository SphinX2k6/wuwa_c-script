using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Typing
{
	// Token: 0x02000121 RID: 289
	[NullableContext(1)]
	[Nullable(0)]
	public class FKuroPerfSightHelper
	{
		// Token: 0x06000AA3 RID: 2723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void UnRegisterTickGroupEvent_Internal();

		// Token: 0x06000AA4 RID: 2724 RVA: 0x000345EE File Offset: 0x000327EE
		public static void UnRegisterTickGroupEvent()
		{
			FKuroPerfSightHelper.UnRegisterTickGroupEvent_Internal();
		}

		// Token: 0x06000AA5 RID: 2725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void UnRegisterOnFrameBegin_Internal();

		// Token: 0x06000AA6 RID: 2726 RVA: 0x000345F5 File Offset: 0x000327F5
		public static void UnRegisterOnFrameBegin()
		{
			FKuroPerfSightHelper.UnRegisterOnFrameBegin_Internal();
		}

		// Token: 0x06000AA7 RID: 2727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetStrategyById_Internal(int strategyId, int strategyValue);

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000345FC File Offset: 0x000327FC
		public static void SetStrategyById(int strategyId, int strategyValue)
		{
			FKuroPerfSightHelper.SetStrategyById_Internal(strategyId, strategyValue);
		}

		// Token: 0x06000AA9 RID: 2729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFlameGraphStrMapSize_Internal(int inSize);

		// Token: 0x06000AAA RID: 2730 RVA: 0x00034605 File Offset: 0x00032805
		public static void SetFlameGraphStrMapSize(int inSize)
		{
			FKuroPerfSightHelper.SetFlameGraphStrMapSize_Internal(inSize);
		}

		// Token: 0x06000AAB RID: 2731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFlameGraphQueueSize_Internal(int length);

		// Token: 0x06000AAC RID: 2732 RVA: 0x0003460D File Offset: 0x0003280D
		public static void SetFlameGraphQueueSize(int length)
		{
			FKuroPerfSightHelper.SetFlameGraphQueueSize_Internal(length);
		}

		// Token: 0x06000AAD RID: 2733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetFlameGraphDropThresholds_Internal(int threshold);

		// Token: 0x06000AAE RID: 2734 RVA: 0x00034615 File Offset: 0x00032815
		public static void SetFlameGraphDropThresholds(int threshold)
		{
			FKuroPerfSightHelper.SetFlameGraphDropThresholds_Internal(threshold);
		}

		// Token: 0x06000AAF RID: 2735
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SafePushCall_Internal(char* callGraphName);

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00034620 File Offset: 0x00032820
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

		// Token: 0x06000AB1 RID: 2737
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SafePopCall_Internal(char* callGraphName);

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00034650 File Offset: 0x00032850
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

		// Token: 0x06000AB3 RID: 2739
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterTickGroupEvent_Internal();

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0003467F File Offset: 0x0003287F
		public static void RegisterTickGroupEvent()
		{
			FKuroPerfSightHelper.RegisterTickGroupEvent_Internal();
		}

		// Token: 0x06000AB5 RID: 2741
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void RegisterOnFrameBegin_Internal(in FString callGraphName);

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00034688 File Offset: 0x00032888
		public unsafe static void RegisterOnFrameBegin(string callGraphName)
		{
			FString fstring = FString.AllocTemp(callGraphName);
			FKuroPerfSightHelper.RegisterOnFrameBegin_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000AB7 RID: 2743
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueString_Internal(in FString category, in FString key, in FString value);

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000346AC File Offset: 0x000328AC
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

		// Token: 0x06000AB9 RID: 2745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueInteger3_Internal(in FString category, in FString key, int valueA, int valueB, int valueC);

		// Token: 0x06000ABA RID: 2746 RVA: 0x000346F4 File Offset: 0x000328F4
		public unsafe static void PostValueInteger3(string category, string key, int valueA, int valueB, int valueC)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueInteger3_Internal(fstring, fstring2, valueA, valueB, valueC);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000ABB RID: 2747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueInteger2_Internal(in FString category, in FString key, int valueA, int valueB);

		// Token: 0x06000ABC RID: 2748 RVA: 0x00034730 File Offset: 0x00032930
		public unsafe static void PostValueInteger2(string category, string key, int valueA, int valueB)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueInteger2_Internal(fstring, fstring2, valueA, valueB);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000ABD RID: 2749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueInteger1_Internal(in FString category, in FString key, int valueA);

		// Token: 0x06000ABE RID: 2750 RVA: 0x00034768 File Offset: 0x00032968
		public unsafe static void PostValueInteger1(string category, string key, int valueA)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueInteger1_Internal(fstring, fstring2, valueA);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000ABF RID: 2751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueFloat3_Internal(in FString category, in FString key, float valueA, float valueB, float valueC);

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000347A0 File Offset: 0x000329A0
		public unsafe static void PostValueFloat3(string category, string key, float valueA, float valueB, float valueC)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueFloat3_Internal(fstring, fstring2, valueA, valueB, valueC);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000AC1 RID: 2753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueFloat2_Internal(in FString category, in FString key, float valueA, float valueB);

		// Token: 0x06000AC2 RID: 2754 RVA: 0x000347DC File Offset: 0x000329DC
		public unsafe static void PostValueFloat2(string category, string key, float valueA, float valueB)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueFloat2_Internal(fstring, fstring2, valueA, valueB);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000AC3 RID: 2755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostValueFloat1_Internal(in FString category, in FString key, float valueA);

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00034814 File Offset: 0x00032A14
		public unsafe static void PostValueFloat1(string category, string key, float valueA)
		{
			FString fstring = FString.AllocTemp(category);
			FString fstring2 = FString.AllocTemp(key);
			FKuroPerfSightHelper.PostValueFloat1_Internal(fstring, fstring2, valueA);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x06000AC5 RID: 2757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PostFrame_Internal(float deltaTime);

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0003484B File Offset: 0x00032A4B
		public static void PostFrame(float deltaTime)
		{
			FKuroPerfSightHelper.PostFrame_Internal(deltaTime);
		}

		// Token: 0x06000AC7 RID: 2759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void MarkStartUpFinish_Internal();

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00034853 File Offset: 0x00032A53
		public static void MarkStartUpFinish()
		{
			FKuroPerfSightHelper.MarkStartUpFinish_Internal();
		}

		// Token: 0x06000AC9 RID: 2761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsOnFrameBeginRegistered_Internal();

		// Token: 0x06000ACA RID: 2762 RVA: 0x0003485A File Offset: 0x00032A5A
		public static bool IsOnFrameBeginRegistered()
		{
			return FKuroPerfSightHelper.IsOnFrameBeginRegistered_Internal();
		}

		// Token: 0x06000ACB RID: 2763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsBeginCallGraphCalled_Internal();

		// Token: 0x06000ACC RID: 2764 RVA: 0x00034861 File Offset: 0x00032A61
		public static bool IsBeginCallGraphCalled()
		{
			return FKuroPerfSightHelper.IsBeginCallGraphCalled_Internal();
		}

		// Token: 0x06000ACD RID: 2765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void EndExtTag_Internal(in FString tagName);

		// Token: 0x06000ACE RID: 2766 RVA: 0x00034868 File Offset: 0x00032A68
		public unsafe static void EndExtTag(string tagName)
		{
			FString fstring = FString.AllocTemp(tagName);
			FKuroPerfSightHelper.EndExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000ACF RID: 2767
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void EndCallGraph_Internal(char* name);

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003488C File Offset: 0x00032A8C
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

		// Token: 0x06000AD1 RID: 2769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void EnableTimedReport_Internal();

		// Token: 0x06000AD2 RID: 2770 RVA: 0x000348BB File Offset: 0x00032ABB
		public static void EnableTimedReport()
		{
			FKuroPerfSightHelper.EnableTimedReport_Internal();
		}

		// Token: 0x06000AD3 RID: 2771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void BeginExtTag_Internal(in FString tagName);

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000348C4 File Offset: 0x00032AC4
		public unsafe static void BeginExtTag(string tagName)
		{
			FString fstring = FString.AllocTemp(tagName);
			FKuroPerfSightHelper.BeginExtTag_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06000AD5 RID: 2773
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void BeginCallGraph_Internal(char* name);

		// Token: 0x06000AD6 RID: 2774 RVA: 0x000348E8 File Offset: 0x00032AE8
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
