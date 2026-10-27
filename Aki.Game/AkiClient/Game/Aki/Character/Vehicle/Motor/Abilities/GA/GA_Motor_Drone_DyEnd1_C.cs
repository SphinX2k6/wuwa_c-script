using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Abilities.GA;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x02004067 RID: 16487
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyEnd1.GA_Motor_Drone_DyEnd1_C")]
	[UnrealStructLayout(1512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1512)]
	public class GA_Motor_Drone_DyEnd1_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5A8 RID: 173480 RVA: 0x009DDF40 File Offset: 0x009DC140
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_DyEnd1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyEnd1.GA_Motor_Drone_DyEnd1_C");
			}
			return GA_Motor_Drone_DyEnd1_C._ClassPtr;
		}

		// Token: 0x0602A5A9 RID: 173481 RVA: 0x009DDF64 File Offset: 0x009DC164
		public GA_Motor_Drone_DyEnd1_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_DyEnd1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5AA RID: 173482 RVA: 0x009DDF8C File Offset: 0x009DC18C
		[NullableContext(1)]
		public GA_Motor_Drone_DyEnd1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_DyEnd1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A5AB RID: 173483 RVA: 0x009DDFBF File Offset: 0x009DC1BF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_DyEnd1_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A5AC RID: 173484 RVA: 0x009DDFD3 File Offset: 0x009DC1D3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_DyEnd1_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A5AD RID: 173485 RVA: 0x009DDFE8 File Offset: 0x009DC1E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5AE RID: 173486 RVA: 0x009DE030 File Offset: 0x009DC230
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_DyEnd1_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A5AF RID: 173487 RVA: 0x009DE077 File Offset: 0x009DC277
		protected GA_Motor_Drone_DyEnd1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DB7 RID: 89527
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyEnd1.GA_Motor_Drone_DyEnd1_C";

		// Token: 0x04015DB8 RID: 89528
		private static IntPtr _ClassPtr;

		// Token: 0x04015DB9 RID: 89529
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DBA RID: 89530
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015DBB RID: 89531
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A381 RID: 41857
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032165 RID: 205157
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
