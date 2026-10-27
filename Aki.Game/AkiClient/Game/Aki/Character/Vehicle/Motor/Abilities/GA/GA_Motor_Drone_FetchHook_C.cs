using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Fight.FollowShooter.DeadEye;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x0200406B RID: 16491
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FetchHook.GA_Motor_Drone_FetchHook_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1564)]
	public class GA_Motor_Drone_FetchHook_C : GA_Motor_DroneBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5D6 RID: 173526 RVA: 0x009DE61C File Offset: 0x009DC81C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_FetchHook_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FetchHook.GA_Motor_Drone_FetchHook_C");
			}
			return GA_Motor_Drone_FetchHook_C._ClassPtr;
		}

		// Token: 0x0602A5D7 RID: 173527 RVA: 0x009DE640 File Offset: 0x009DC840
		public GA_Motor_Drone_FetchHook_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_FetchHook_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5D8 RID: 173528 RVA: 0x009DE668 File Offset: 0x009DC868
		[NullableContext(1)]
		public GA_Motor_Drone_FetchHook_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_FetchHook_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067D7 RID: 26583
		// (get) Token: 0x0602A5D9 RID: 173529 RVA: 0x009DE69B File Offset: 0x009DC89B
		// (set) Token: 0x0602A5DA RID: 173530 RVA: 0x009DE6AF File Offset: 0x009DC8AF
		[Nullable(2)]
		public unsafe BP_FollowShooterDeadEyeConfig_C DeadEyeConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_FollowShooterDeadEyeConfig_C>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Drone_FetchHook_C.__PropertyOffset_1);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Drone_FetchHook_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170067D8 RID: 26584
		// (get) Token: 0x0602A5DB RID: 173531 RVA: 0x009DE6C4 File Offset: 0x009DC8C4
		// (set) Token: 0x0602A5DC RID: 173532 RVA: 0x009DE6D4 File Offset: 0x009DC8D4
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_Drone_FetchHook_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_Drone_FetchHook_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x0602A5DD RID: 173533 RVA: 0x009DE6E8 File Offset: 0x009DC8E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnSequenceFinished_D3BEE19E4FC298531A14328D25806F3F(USceneComponent AimPivot)
		{
			GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D25806F3F_FunctionParams* ptr = stackalloc GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D25806F3F_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D25806F3F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D25806F3F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D25806F3F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5DE RID: 173534 RVA: 0x009DE740 File Offset: 0x009DC940
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnShootStepFired_D3BEE19E4FC298531A14328D25806F3F(USceneComponent AimPivot, FVector TargetLocation)
		{
			GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D25806F3F_FunctionParams* ptr = stackalloc GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D25806F3F_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D25806F3F_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D25806F3F_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			ptr->TargetLocation = TargetLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D25806F3F_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5DF RID: 173535 RVA: 0x009DE79C File Offset: 0x009DC99C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnSequenceFinished_D3BEE19E4FC298531A14328D7FD4119A(USceneComponent AimPivot)
		{
			GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D7FD4119A_FunctionParams* ptr = stackalloc GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D7FD4119A_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D7FD4119A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D7FD4119A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D7FD4119A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5E0 RID: 173536 RVA: 0x009DE7F4 File Offset: 0x009DC9F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnShootStepFired_D3BEE19E4FC298531A14328D7FD4119A(USceneComponent AimPivot, FVector TargetLocation)
		{
			GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D7FD4119A_FunctionParams* ptr = stackalloc GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D7FD4119A_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D7FD4119A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D7FD4119A_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			ptr->TargetLocation = TargetLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D7FD4119A_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5E1 RID: 173537 RVA: 0x009DE850 File Offset: 0x009DCA50
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnSequenceFinished_D3BEE19E4FC298531A14328D74F690BF(USceneComponent AimPivot)
		{
			GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D74F690BF_FunctionParams* ptr = stackalloc GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D74F690BF_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D74F690BF_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D74F690BF_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328D74F690BF_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5E2 RID: 173538 RVA: 0x009DE8A8 File Offset: 0x009DCAA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnShootStepFired_D3BEE19E4FC298531A14328D74F690BF(USceneComponent AimPivot, FVector TargetLocation)
		{
			GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D74F690BF_FunctionParams* ptr = stackalloc GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D74F690BF_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D74F690BF_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D74F690BF_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			ptr->TargetLocation = TargetLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328D74F690BF_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5E3 RID: 173539 RVA: 0x009DE904 File Offset: 0x009DCB04
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnSequenceFinished_D3BEE19E4FC298531A14328DF0F60775(USceneComponent AimPivot)
		{
			GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328DF0F60775_FunctionParams* ptr = stackalloc GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328DF0F60775_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328DF0F60775_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328DF0F60775_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__OnSequenceFinished_D3BEE19E4FC298531A14328DF0F60775_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5E4 RID: 173540 RVA: 0x009DE95C File Offset: 0x009DCB5C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void OnShootStepFired_D3BEE19E4FC298531A14328DF0F60775(USceneComponent AimPivot, FVector TargetLocation)
		{
			GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328DF0F60775_FunctionParams* ptr = stackalloc GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328DF0F60775_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328DF0F60775_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328DF0F60775_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AimPivot = ((AimPivot != null) ? AimPivot.NativePtr : IntPtr.Zero);
			ptr->TargetLocation = TargetLocation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__OnShootStepFired_D3BEE19E4FC298531A14328DF0F60775_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5E5 RID: 173541 RVA: 0x009DE9B8 File Offset: 0x009DCBB8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A5E6 RID: 173542 RVA: 0x009DE9CC File Offset: 0x009DCBCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_FetchHook_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A5E7 RID: 173543 RVA: 0x009DE9E1 File Offset: 0x009DCBE1
		protected GA_Motor_Drone_FetchHook_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DD8 RID: 89560
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FetchHook.GA_Motor_Drone_FetchHook_C";

		// Token: 0x04015DD9 RID: 89561
		private static IntPtr _ClassPtr;

		// Token: 0x04015DDA RID: 89562
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DDB RID: 89563
		internal new static int __PropertyOffset_1;

		// Token: 0x04015DDC RID: 89564
		internal new static int __PropertyOffset_2;

		// Token: 0x04015DDD RID: 89565
		private static IntPtr __OnSequenceFinished_D3BEE19E4FC298531A14328D25806F3F_NativeFunctionPtr;

		// Token: 0x04015DDE RID: 89566
		private static IntPtr __OnShootStepFired_D3BEE19E4FC298531A14328D25806F3F_NativeFunctionPtr;

		// Token: 0x04015DDF RID: 89567
		private static IntPtr __OnSequenceFinished_D3BEE19E4FC298531A14328D7FD4119A_NativeFunctionPtr;

		// Token: 0x04015DE0 RID: 89568
		private static IntPtr __OnShootStepFired_D3BEE19E4FC298531A14328D7FD4119A_NativeFunctionPtr;

		// Token: 0x04015DE1 RID: 89569
		private static IntPtr __OnSequenceFinished_D3BEE19E4FC298531A14328D74F690BF_NativeFunctionPtr;

		// Token: 0x04015DE2 RID: 89570
		private static IntPtr __OnShootStepFired_D3BEE19E4FC298531A14328D74F690BF_NativeFunctionPtr;

		// Token: 0x04015DE3 RID: 89571
		private static IntPtr __OnSequenceFinished_D3BEE19E4FC298531A14328DF0F60775_NativeFunctionPtr;

		// Token: 0x04015DE4 RID: 89572
		private static IntPtr __OnShootStepFired_D3BEE19E4FC298531A14328DF0F60775_NativeFunctionPtr;

		// Token: 0x04015DE5 RID: 89573
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A385 RID: 41861
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnSequenceFinished_D3BEE19E4FC298531A14328D25806F3F_FunctionParams
		{
			// Token: 0x04032169 RID: 205161
			[FieldOffset(0)]
			public IntPtr AimPivot;
		}

		// Token: 0x0200A386 RID: 41862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnShootStepFired_D3BEE19E4FC298531A14328D25806F3F_FunctionParams
		{
			// Token: 0x0403216A RID: 205162
			[FieldOffset(0)]
			public IntPtr AimPivot;

			// Token: 0x0403216B RID: 205163
			[FieldOffset(8)]
			public FVector TargetLocation;
		}

		// Token: 0x0200A387 RID: 41863
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnSequenceFinished_D3BEE19E4FC298531A14328D7FD4119A_FunctionParams
		{
			// Token: 0x0403216C RID: 205164
			[FieldOffset(0)]
			public IntPtr AimPivot;
		}

		// Token: 0x0200A388 RID: 41864
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnShootStepFired_D3BEE19E4FC298531A14328D7FD4119A_FunctionParams
		{
			// Token: 0x0403216D RID: 205165
			[FieldOffset(0)]
			public IntPtr AimPivot;

			// Token: 0x0403216E RID: 205166
			[FieldOffset(8)]
			public FVector TargetLocation;
		}

		// Token: 0x0200A389 RID: 41865
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnSequenceFinished_D3BEE19E4FC298531A14328D74F690BF_FunctionParams
		{
			// Token: 0x0403216F RID: 205167
			[FieldOffset(0)]
			public IntPtr AimPivot;
		}

		// Token: 0x0200A38A RID: 41866
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnShootStepFired_D3BEE19E4FC298531A14328D74F690BF_FunctionParams
		{
			// Token: 0x04032170 RID: 205168
			[FieldOffset(0)]
			public IntPtr AimPivot;

			// Token: 0x04032171 RID: 205169
			[FieldOffset(8)]
			public FVector TargetLocation;
		}

		// Token: 0x0200A38B RID: 41867
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnSequenceFinished_D3BEE19E4FC298531A14328DF0F60775_FunctionParams
		{
			// Token: 0x04032172 RID: 205170
			[FieldOffset(0)]
			public IntPtr AimPivot;
		}

		// Token: 0x0200A38C RID: 41868
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __OnShootStepFired_D3BEE19E4FC298531A14328DF0F60775_FunctionParams
		{
			// Token: 0x04032173 RID: 205171
			[FieldOffset(0)]
			public IntPtr AimPivot;

			// Token: 0x04032174 RID: 205172
			[FieldOffset(8)]
			public FVector TargetLocation;
		}
	}
}
