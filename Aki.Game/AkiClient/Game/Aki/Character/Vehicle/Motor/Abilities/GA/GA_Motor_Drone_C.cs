using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x02004065 RID: 16485
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone.GA_Motor_Drone_C")]
	[UnrealStructLayout(1552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1552)]
	public class GA_Motor_Drone_C : GA_Motor_DroneBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A598 RID: 173464 RVA: 0x009DDCBD File Offset: 0x009DBEBD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone.GA_Motor_Drone_C");
			}
			return GA_Motor_Drone_C._ClassPtr;
		}

		// Token: 0x0602A599 RID: 173465 RVA: 0x009DDCE4 File Offset: 0x009DBEE4
		public GA_Motor_Drone_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A59A RID: 173466 RVA: 0x009DDD0C File Offset: 0x009DBF0C
		[NullableContext(1)]
		public GA_Motor_Drone_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602A59B RID: 173467 RVA: 0x009DDD3F File Offset: 0x009DBF3F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A59C RID: 173468 RVA: 0x009DDD53 File Offset: 0x009DBF53
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A59D RID: 173469 RVA: 0x009DDD68 File Offset: 0x009DBF68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Drone_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A59E RID: 173470 RVA: 0x009DDDB0 File Offset: 0x009DBFB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Drone_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A59F RID: 173471 RVA: 0x009DDDF7 File Offset: 0x009DBFF7
		protected GA_Motor_Drone_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DAD RID: 89517
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone.GA_Motor_Drone_C";

		// Token: 0x04015DAE RID: 89518
		private static IntPtr _ClassPtr;

		// Token: 0x04015DAF RID: 89519
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DB0 RID: 89520
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015DB1 RID: 89521
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A37F RID: 41855
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032163 RID: 205155
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
