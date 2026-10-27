using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x02004068 RID: 16488
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyEnd.GA_Motor_Drone_DyEnd_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class GA_Motor_Drone_DyEnd_C : GA_Motor_DroneBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5B0 RID: 173488 RVA: 0x009DE080 File Offset: 0x009DC280
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_DyEnd_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyEnd.GA_Motor_Drone_DyEnd_C");
			}
			return GA_Motor_Drone_DyEnd_C._ClassPtr;
		}

		// Token: 0x0602A5B1 RID: 173489 RVA: 0x009DE0A4 File Offset: 0x009DC2A4
		public GA_Motor_Drone_DyEnd_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_DyEnd_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5B2 RID: 173490 RVA: 0x009DE0CC File Offset: 0x009DC2CC
		public GA_Motor_Drone_DyEnd_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_DyEnd_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067D0 RID: 26576
		// (get) Token: 0x0602A5B3 RID: 173491 RVA: 0x009DE100 File Offset: 0x009DC300
		// (set) Token: 0x0602A5B4 RID: 173492 RVA: 0x009DE139 File Offset: 0x009DC339
		public TArray<FGameplayTag> 挂点Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._挂点Tags) == null)
				{
					result = (this._挂点Tags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)GA_Motor_Drone_DyEnd_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.挂点Tags.CopyAssign(value);
			}
		}

		// Token: 0x170067D1 RID: 26577
		// (get) Token: 0x0602A5B5 RID: 173493 RVA: 0x009DE148 File Offset: 0x009DC348
		// (set) Token: 0x0602A5B6 RID: 173494 RVA: 0x009DE181 File Offset: 0x009DC381
		public TArray<FGameplayTag> 死眼Tag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._死眼Tag) == null)
				{
					result = (this._死眼Tag = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)GA_Motor_Drone_DyEnd_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.死眼Tag.CopyAssign(value);
			}
		}

		// Token: 0x0602A5B7 RID: 173495 RVA: 0x009DE18F File Offset: 0x009DC38F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_DyEnd_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A5B8 RID: 173496 RVA: 0x009DE1A3 File Offset: 0x009DC3A3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_DyEnd_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A5B9 RID: 173497 RVA: 0x009DE1B8 File Offset: 0x009DC3B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5BA RID: 173498 RVA: 0x009DE200 File Offset: 0x009DC400
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_DyEnd_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A5BB RID: 173499 RVA: 0x009DE247 File Offset: 0x009DC447
		protected GA_Motor_Drone_DyEnd_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DBC RID: 89532
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyEnd.GA_Motor_Drone_DyEnd_C";

		// Token: 0x04015DBD RID: 89533
		private static IntPtr _ClassPtr;

		// Token: 0x04015DBE RID: 89534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DBF RID: 89535
		internal new static int __PropertyOffset_1;

		// Token: 0x04015DC0 RID: 89536
		[Nullable(2)]
		private TArray<FGameplayTag> _挂点Tags;

		// Token: 0x04015DC1 RID: 89537
		internal new static int __PropertyOffset_2;

		// Token: 0x04015DC2 RID: 89538
		[Nullable(2)]
		private TArray<FGameplayTag> _死眼Tag;

		// Token: 0x04015DC3 RID: 89539
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015DC4 RID: 89540
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A382 RID: 41858
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032166 RID: 205158
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
