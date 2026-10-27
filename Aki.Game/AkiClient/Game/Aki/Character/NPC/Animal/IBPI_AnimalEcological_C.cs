using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.NPC.Animal
{
	// Token: 0x020041A5 RID: 16805
	[UnrealObjectPath("/Game/Aki/Character/NPC/Animal/BPI_AnimalEcological.BPI_AnimalEcological_C")]
	public interface IBPI_AnimalEcological_C : IUnrealBlueprintInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602BBEF RID: 179183 RVA: 0x00A093F3 File Offset: 0x00A075F3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void SystemUiEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__SystemUiEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBF0 RID: 179184 RVA: 0x00A09407 File Offset: 0x00A07607
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void SystemUiStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__SystemUiStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBF1 RID: 179185 RVA: 0x00A0941C File Offset: 0x00A0761C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void FeedStart(FGameplayTag GameplayTag)
		{
			IBPI_AnimalEcological_C.__FeedStart_FunctionParams* ptr = stackalloc IBPI_AnimalEcological_C.__FeedStart_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(IBPI_AnimalEcological_C.__FeedStart_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_AnimalEcological_C_ReflectionImplementationFields.__FeedStart_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayTag = GameplayTag;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__FeedStart_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602BBF2 RID: 179186 RVA: 0x00A09464 File Offset: 0x00A07664
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe void GetCurrentActionTime(ref float ActionTime)
		{
			IBPI_AnimalEcological_C.__GetCurrentActionTime_FunctionParams* ptr = stackalloc IBPI_AnimalEcological_C.__GetCurrentActionTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(IBPI_AnimalEcological_C.__GetCurrentActionTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(IBPI_AnimalEcological_C_ReflectionImplementationFields.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ActionTime = ActionTime;
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__GetCurrentActionTime_NativeFunctionPtr, (void*)ptr);
			ActionTime = ptr->ActionTime;
		}

		// Token: 0x0602BBF3 RID: 179187 RVA: 0x00A094B3 File Offset: 0x00A076B3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void NoneStateEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__NoneStateEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBF4 RID: 179188 RVA: 0x00A094C7 File Offset: 0x00A076C7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void NoneStateStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__NoneStateStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBF5 RID: 179189 RVA: 0x00A094DB File Offset: 0x00A076DB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void StateMachineInitializationComplete()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__StateMachineInitializationComplete_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBF6 RID: 179190 RVA: 0x00A094EF File Offset: 0x00A076EF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void InteractEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__InteractEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBF7 RID: 179191 RVA: 0x00A09503 File Offset: 0x00A07703
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void InteractStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__InteractStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBF8 RID: 179192 RVA: 0x00A09517 File Offset: 0x00A07717
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void IdleEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__IdleEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBF9 RID: 179193 RVA: 0x00A0952B File Offset: 0x00A0772B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void IdleStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__IdleStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBFA RID: 179194 RVA: 0x00A0953F File Offset: 0x00A0773F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void UnderAttackEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__UnderAttackEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBFB RID: 179195 RVA: 0x00A09553 File Offset: 0x00A07753
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void UnderAttackStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__UnderAttackStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBFC RID: 179196 RVA: 0x00A09567 File Offset: 0x00A07767
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void AlertEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__AlertEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBFD RID: 179197 RVA: 0x00A0957B File Offset: 0x00A0777B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void AlertStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__AlertStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBFE RID: 179198 RVA: 0x00A0958F File Offset: 0x00A0778F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void TakeOffEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__TakeOffEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602BBFF RID: 179199 RVA: 0x00A095A3 File Offset: 0x00A077A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		void TakeOffStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(this.NativePtr, IBPI_AnimalEcological_C_ReflectionImplementationFields.__TakeOffStart_NativeFunctionPtr, null);
		}

		// Token: 0x04016CC6 RID: 93382
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/NPC/Animal/BPI_AnimalEcological.BPI_AnimalEcological_C";

		// Token: 0x0200A593 RID: 42387
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __FeedStart_FunctionParams
		{
			// Token: 0x0403241F RID: 205855
			[FieldOffset(0)]
			public FGameplayTag GameplayTag;
		}

		// Token: 0x0200A594 RID: 42388
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentActionTime_FunctionParams
		{
			// Token: 0x04032420 RID: 205856
			[FieldOffset(0)]
			public float ActionTime;
		}
	}
}
