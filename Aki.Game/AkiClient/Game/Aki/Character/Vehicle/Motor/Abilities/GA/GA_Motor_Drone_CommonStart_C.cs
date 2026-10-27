using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x02004066 RID: 16486
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_CommonStart.GA_Motor_Drone_CommonStart_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_Drone_CommonStart_C : GA_Motor_DroneBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5A0 RID: 173472 RVA: 0x009DDE00 File Offset: 0x009DC000
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_CommonStart_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_CommonStart.GA_Motor_Drone_CommonStart_C");
			}
			return GA_Motor_Drone_CommonStart_C._ClassPtr;
		}

		// Token: 0x0602A5A1 RID: 173473 RVA: 0x009DDE24 File Offset: 0x009DC024
		public GA_Motor_Drone_CommonStart_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_CommonStart_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5A2 RID: 173474 RVA: 0x009DDE4C File Offset: 0x009DC04C
		[NullableContext(1)]
		public GA_Motor_Drone_CommonStart_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_CommonStart_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A5A3 RID: 173475 RVA: 0x009DDE7F File Offset: 0x009DC07F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_CommonStart_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A5A4 RID: 173476 RVA: 0x009DDE93 File Offset: 0x009DC093
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_CommonStart_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A5A5 RID: 173477 RVA: 0x009DDEA8 File Offset: 0x009DC0A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5A6 RID: 173478 RVA: 0x009DDEF0 File Offset: 0x009DC0F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_CommonStart_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A5A7 RID: 173479 RVA: 0x009DDF37 File Offset: 0x009DC137
		protected GA_Motor_Drone_CommonStart_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DB2 RID: 89522
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_CommonStart.GA_Motor_Drone_CommonStart_C";

		// Token: 0x04015DB3 RID: 89523
		private static IntPtr _ClassPtr;

		// Token: 0x04015DB4 RID: 89524
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DB5 RID: 89525
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015DB6 RID: 89526
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A380 RID: 41856
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032164 RID: 205156
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
