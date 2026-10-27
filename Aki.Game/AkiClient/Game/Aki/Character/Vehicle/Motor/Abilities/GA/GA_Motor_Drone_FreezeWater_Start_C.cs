using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x0200406D RID: 16493
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FreezeWater_Start.GA_Motor_Drone_FreezeWater_Start_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_Drone_FreezeWater_Start_C : GA_Motor_DroneBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5F2 RID: 173554 RVA: 0x009DEB74 File Offset: 0x009DCD74
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_FreezeWater_Start_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FreezeWater_Start.GA_Motor_Drone_FreezeWater_Start_C");
			}
			return GA_Motor_Drone_FreezeWater_Start_C._ClassPtr;
		}

		// Token: 0x0602A5F3 RID: 173555 RVA: 0x009DEB98 File Offset: 0x009DCD98
		public GA_Motor_Drone_FreezeWater_Start_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_FreezeWater_Start_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5F4 RID: 173556 RVA: 0x009DEBC0 File Offset: 0x009DCDC0
		[NullableContext(1)]
		public GA_Motor_Drone_FreezeWater_Start_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_FreezeWater_Start_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A5F5 RID: 173557 RVA: 0x009DEBF3 File Offset: 0x009DCDF3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FreezeWater_Start_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A5F6 RID: 173558 RVA: 0x009DEC07 File Offset: 0x009DCE07
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_FreezeWater_Start_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A5F7 RID: 173559 RVA: 0x009DEC1C File Offset: 0x009DCE1C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5F8 RID: 173560 RVA: 0x009DEC64 File Offset: 0x009DCE64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_FreezeWater_Start_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A5F9 RID: 173561 RVA: 0x009DECAB File Offset: 0x009DCEAB
		protected GA_Motor_Drone_FreezeWater_Start_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DED RID: 89581
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FreezeWater_Start.GA_Motor_Drone_FreezeWater_Start_C";

		// Token: 0x04015DEE RID: 89582
		private static IntPtr _ClassPtr;

		// Token: 0x04015DEF RID: 89583
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DF0 RID: 89584
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015DF1 RID: 89585
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A38E RID: 41870
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032176 RID: 205174
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
