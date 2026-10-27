using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Role.Common.ABP_Gameplay
{
	// Token: 0x02004117 RID: 16663
	[UnrealObjectPath("/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Poker.ABP_BaseRole_Gameplay_Poker_C")]
	[UnrealStructLayout(14080, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 14074)]
	public class ABP_BaseRole_Gameplay_Poker_C : UKuroAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602AE58 RID: 175704 RVA: 0x009EF019 File Offset: 0x009ED219
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (ABP_BaseRole_Gameplay_Poker_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Poker.ABP_BaseRole_Gameplay_Poker_C");
			}
			return ABP_BaseRole_Gameplay_Poker_C._ClassPtr;
		}

		// Token: 0x0602AE59 RID: 175705 RVA: 0x009EF040 File Offset: 0x009ED240
		public ABP_BaseRole_Gameplay_Poker_C() : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Poker_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602AE5A RID: 175706 RVA: 0x009EF068 File Offset: 0x009ED268
		[NullableContext(1)]
		public ABP_BaseRole_Gameplay_Poker_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ABP_BaseRole_Gameplay_Poker_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006995 RID: 27029
		// (get) Token: 0x0602AE5B RID: 175707 RVA: 0x009EF09B File Offset: 0x009ED29B
		// (set) Token: 0x0602AE5C RID: 175708 RVA: 0x009EF0AF File Offset: 0x009ED2AF
		public unsafe TEnumAsByte<EPokerStateType> PokerState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_115);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_115) = value;
			}
		}

		// Token: 0x17006996 RID: 27030
		// (get) Token: 0x0602AE5D RID: 175709 RVA: 0x009EF0C4 File Offset: 0x009ED2C4
		// (set) Token: 0x0602AE5E RID: 175710 RVA: 0x009EF0D4 File Offset: 0x009ED2D4
		public unsafe float 猜鬼牌表演倒计时
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_116);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_116) = value;
			}
		}

		// Token: 0x17006997 RID: 27031
		// (get) Token: 0x0602AE5F RID: 175711 RVA: 0x009EF0E5 File Offset: 0x009ED2E5
		// (set) Token: 0x0602AE60 RID: 175712 RVA: 0x009EF0F5 File Offset: 0x009ED2F5
		public unsafe int PokerPerformanceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_117);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_117) = value;
			}
		}

		// Token: 0x17006998 RID: 27032
		// (get) Token: 0x0602AE61 RID: 175713 RVA: 0x009EF106 File Offset: 0x009ED306
		// (set) Token: 0x0602AE62 RID: 175714 RVA: 0x009EF116 File Offset: 0x009ED316
		public unsafe float DeltaTimeX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_118);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_118) = value;
			}
		}

		// Token: 0x17006999 RID: 27033
		// (get) Token: 0x0602AE63 RID: 175715 RVA: 0x009EF127 File Offset: 0x009ED327
		// (set) Token: 0x0602AE64 RID: 175716 RVA: 0x009EF13B File Offset: 0x009ED33B
		public unsafe TEnumAsByte<EPokerIdleState> IdleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_119);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_119) = value;
			}
		}

		// Token: 0x1700699A RID: 27034
		// (get) Token: 0x0602AE65 RID: 175717 RVA: 0x009EF150 File Offset: 0x009ED350
		// (set) Token: 0x0602AE66 RID: 175718 RVA: 0x009EF160 File Offset: 0x009ED360
		public unsafe bool bIdleTimerActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_120) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_120) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700699B RID: 27035
		// (get) Token: 0x0602AE67 RID: 175719 RVA: 0x009EF171 File Offset: 0x009ED371
		// (set) Token: 0x0602AE68 RID: 175720 RVA: 0x009EF181 File Offset: 0x009ED381
		public unsafe int BeChooseEmotionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_121);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_121) = value;
			}
		}

		// Token: 0x1700699C RID: 27036
		// (get) Token: 0x0602AE69 RID: 175721 RVA: 0x009EF192 File Offset: 0x009ED392
		// (set) Token: 0x0602AE6A RID: 175722 RVA: 0x009EF1A2 File Offset: 0x009ED3A2
		public unsafe bool bPlayerInteractiveStage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_122) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_122) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700699D RID: 27037
		// (get) Token: 0x0602AE6B RID: 175723 RVA: 0x009EF1B3 File Offset: 0x009ED3B3
		// (set) Token: 0x0602AE6C RID: 175724 RVA: 0x009EF1C3 File Offset: 0x009ED3C3
		public unsafe bool bForceEndLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_123) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ABP_BaseRole_Gameplay_Poker_C.__PropertyOffset_123) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602AE6D RID: 175725 RVA: 0x009EF1D4 File Offset: 0x009ED3D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AnimGraph(ref FPoseLink AnimGraph)
		{
			ABP_BaseRole_Gameplay_Poker_C.__AnimGraph_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__AnimGraph_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__AnimGraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__AnimGraph_NativeFunctionPtr, (void*)ptr, 1);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), &ptr->AnimGraph, AnimGraph.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__AnimGraph_NativeFunctionPtr, (void*)ptr);
			if (AnimGraph != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), AnimGraph.NativePtr, &ptr->AnimGraph, 1, false);
			}
		}

		// Token: 0x0602AE6E RID: 175726 RVA: 0x009EF25B File Offset: 0x009ED45B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void InitPerformanceTickTime()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__InitPerformanceTickTime_NativeFunctionPtr, null);
		}

		// Token: 0x0602AE6F RID: 175727 RVA: 0x009EF270 File Offset: 0x009ED470
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPlayerInteractiveStage(bool isInteractive)
		{
			ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_FunctionParams[(UIntPtr)18] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_NativeFunctionPtr, (void*)ptr, 1);
			ptr->isInteractive = isInteractive;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__SetPlayerInteractiveStage_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE70 RID: 175728 RVA: 0x009EF2B8 File Offset: 0x009ED4B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetBeChooseEmotionIndex(int index)
		{
			ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->index = index;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__SetBeChooseEmotionIndex_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE71 RID: 175729 RVA: 0x009EF2FE File Offset: 0x009ED4FE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void ReturnIdel()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__ReturnIdel_NativeFunctionPtr, null);
		}

		// Token: 0x0602AE72 RID: 175730 RVA: 0x009EF314 File Offset: 0x009ED514
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPokerIdleState(EPokerIdleState IdleState)
		{
			ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->IdleState = IdleState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__SetPokerIdleState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE73 RID: 175731 RVA: 0x009EF360 File Offset: 0x009ED560
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void SetPokerState(EPokerStateType PokerState)
		{
			ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PokerState = PokerState;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__SetPokerState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE74 RID: 175732 RVA: 0x009EF3AB File Offset: 0x009ED5AB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 设置猜鬼牌表演倒计时()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__设置猜鬼牌表演倒计时_NativeFunctionPtr, null);
		}

		// Token: 0x0602AE75 RID: 175733 RVA: 0x009EF3C0 File Offset: 0x009ED5C0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void BlueprintUpdateAnimation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602AE76 RID: 175734 RVA: 0x009EF408 File Offset: 0x009ED608
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
		{
			ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams* ptr = stackalloc ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTimeX = DeltaTimeX;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, ABP_BaseRole_Gameplay_Poker_C.__BlueprintUpdateAnimation_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602AE77 RID: 175735 RVA: 0x009EF44F File Offset: 0x009ED64F
		protected ABP_BaseRole_Gameplay_Poker_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040163BE RID: 91070
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Role/Common/ABP_Gameplay/ABP_BaseRole_Gameplay_Poker.ABP_BaseRole_Gameplay_Poker_C";

		// Token: 0x040163BF RID: 91071
		private static IntPtr _ClassPtr;

		// Token: 0x040163C0 RID: 91072
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040163C1 RID: 91073
		internal static int __PropertyOffset_115;

		// Token: 0x040163C2 RID: 91074
		internal static int __PropertyOffset_116;

		// Token: 0x040163C3 RID: 91075
		internal static int __PropertyOffset_117;

		// Token: 0x040163C4 RID: 91076
		internal static int __PropertyOffset_118;

		// Token: 0x040163C5 RID: 91077
		internal static int __PropertyOffset_119;

		// Token: 0x040163C6 RID: 91078
		internal static int __PropertyOffset_120;

		// Token: 0x040163C7 RID: 91079
		internal static int __PropertyOffset_121;

		// Token: 0x040163C8 RID: 91080
		internal static int __PropertyOffset_122;

		// Token: 0x040163C9 RID: 91081
		internal static int __PropertyOffset_123;

		// Token: 0x040163CA RID: 91082
		private static IntPtr __AnimGraph_NativeFunctionPtr;

		// Token: 0x040163CB RID: 91083
		private static IntPtr __InitPerformanceTickTime_NativeFunctionPtr;

		// Token: 0x040163CC RID: 91084
		private static IntPtr __SetPlayerInteractiveStage_NativeFunctionPtr;

		// Token: 0x040163CD RID: 91085
		private static IntPtr __SetBeChooseEmotionIndex_NativeFunctionPtr;

		// Token: 0x040163CE RID: 91086
		private static IntPtr __ReturnIdel_NativeFunctionPtr;

		// Token: 0x040163CF RID: 91087
		private static IntPtr __SetPokerIdleState_NativeFunctionPtr;

		// Token: 0x040163D0 RID: 91088
		private static IntPtr __SetPokerState_NativeFunctionPtr;

		// Token: 0x040163D1 RID: 91089
		private static IntPtr __设置猜鬼牌表演倒计时_NativeFunctionPtr;

		// Token: 0x040163D2 RID: 91090
		private static IntPtr __BlueprintUpdateAnimation_NativeFunctionPtr;

		// Token: 0x0200A425 RID: 42021
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __AnimGraph_FunctionParams
		{
			// Token: 0x0403225F RID: 205407
			[FieldOffset(0)]
			public byte AnimGraph;
		}

		// Token: 0x0200A426 RID: 42022
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 3)]
		protected ref struct __SetPlayerInteractiveStage_FunctionParams
		{
			// Token: 0x04032260 RID: 205408
			[FieldOffset(0)]
			public bool isInteractive;
		}

		// Token: 0x0200A427 RID: 42023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetBeChooseEmotionIndex_FunctionParams
		{
			// Token: 0x04032261 RID: 205409
			[FieldOffset(0)]
			public int index;
		}

		// Token: 0x0200A428 RID: 42024
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetPokerIdleState_FunctionParams
		{
			// Token: 0x04032262 RID: 205410
			[FieldOffset(0)]
			public TEnumAsByte<EPokerIdleState> IdleState;
		}

		// Token: 0x0200A429 RID: 42025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __SetPokerState_FunctionParams
		{
			// Token: 0x04032263 RID: 205411
			[FieldOffset(0)]
			public TEnumAsByte<EPokerStateType> PokerState;
		}

		// Token: 0x0200A42A RID: 42026
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __BlueprintUpdateAnimation_FunctionParams
		{
			// Token: 0x04032264 RID: 205412
			[FieldOffset(0)]
			public float DeltaTimeX;
		}
	}
}
