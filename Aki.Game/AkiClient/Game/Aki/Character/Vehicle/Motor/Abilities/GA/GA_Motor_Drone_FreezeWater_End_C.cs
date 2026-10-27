using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x0200406C RID: 16492
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FreezeWater_End.GA_Motor_Drone_FreezeWater_End_C")]
	[UnrealStructLayout(1568, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1568)]
	public class GA_Motor_Drone_FreezeWater_End_C : GA_Motor_DroneBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5E8 RID: 173544 RVA: 0x009DE9EA File Offset: 0x009DCBEA
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_FreezeWater_End_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FreezeWater_End.GA_Motor_Drone_FreezeWater_End_C");
			}
			return GA_Motor_Drone_FreezeWater_End_C._ClassPtr;
		}

		// Token: 0x0602A5E9 RID: 173545 RVA: 0x009DEA10 File Offset: 0x009DCC10
		public GA_Motor_Drone_FreezeWater_End_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_FreezeWater_End_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5EA RID: 173546 RVA: 0x009DEA38 File Offset: 0x009DCC38
		public GA_Motor_Drone_FreezeWater_End_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_FreezeWater_End_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067D9 RID: 26585
		// (get) Token: 0x0602A5EB RID: 173547 RVA: 0x009DEA6C File Offset: 0x009DCC6C
		// (set) Token: 0x0602A5EC RID: 173548 RVA: 0x009DEAA5 File Offset: 0x009DCCA5
		public TArray<FGameplayTag> 挂点Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._挂点Tags) == null)
				{
					result = (this._挂点Tags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)GA_Motor_Drone_FreezeWater_End_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.挂点Tags.CopyAssign(value);
			}
		}

		// Token: 0x0602A5ED RID: 173549 RVA: 0x009DEAB3 File Offset: 0x009DCCB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FreezeWater_End_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A5EE RID: 173550 RVA: 0x009DEAC7 File Offset: 0x009DCCC7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_FreezeWater_End_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A5EF RID: 173551 RVA: 0x009DEADC File Offset: 0x009DCCDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5F0 RID: 173552 RVA: 0x009DEB24 File Offset: 0x009DCD24
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_FreezeWater_End_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A5F1 RID: 173553 RVA: 0x009DEB6B File Offset: 0x009DCD6B
		protected GA_Motor_Drone_FreezeWater_End_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DE6 RID: 89574
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_FreezeWater_End.GA_Motor_Drone_FreezeWater_End_C";

		// Token: 0x04015DE7 RID: 89575
		private static IntPtr _ClassPtr;

		// Token: 0x04015DE8 RID: 89576
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DE9 RID: 89577
		internal new static int __PropertyOffset_1;

		// Token: 0x04015DEA RID: 89578
		[Nullable(2)]
		private TArray<FGameplayTag> _挂点Tags;

		// Token: 0x04015DEB RID: 89579
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015DEC RID: 89580
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A38D RID: 41869
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032175 RID: 205173
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
