using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x0200406A RID: 16490
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyStart.GA_Motor_Drone_DyStart_C")]
	[UnrealStructLayout(1584, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1584)]
	public class GA_Motor_Drone_DyStart_C : GA_Motor_DroneBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5CA RID: 173514 RVA: 0x009DE449 File Offset: 0x009DC649
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_DyStart_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyStart.GA_Motor_Drone_DyStart_C");
			}
			return GA_Motor_Drone_DyStart_C._ClassPtr;
		}

		// Token: 0x0602A5CB RID: 173515 RVA: 0x009DE470 File Offset: 0x009DC670
		public GA_Motor_Drone_DyStart_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_DyStart_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5CC RID: 173516 RVA: 0x009DE498 File Offset: 0x009DC698
		public GA_Motor_Drone_DyStart_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_DyStart_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067D5 RID: 26581
		// (get) Token: 0x0602A5CD RID: 173517 RVA: 0x009DE4CC File Offset: 0x009DC6CC
		// (set) Token: 0x0602A5CE RID: 173518 RVA: 0x009DE505 File Offset: 0x009DC705
		public TArray<FGameplayTag> 挂点Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._挂点Tags) == null)
				{
					result = (this._挂点Tags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)GA_Motor_Drone_DyStart_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.挂点Tags.CopyAssign(value);
			}
		}

		// Token: 0x170067D6 RID: 26582
		// (get) Token: 0x0602A5CF RID: 173519 RVA: 0x009DE514 File Offset: 0x009DC714
		// (set) Token: 0x0602A5D0 RID: 173520 RVA: 0x009DE54D File Offset: 0x009DC74D
		public TArray<FGameplayTag> 死眼Tag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._死眼Tag) == null)
				{
					result = (this._死眼Tag = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)GA_Motor_Drone_DyStart_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.死眼Tag.CopyAssign(value);
			}
		}

		// Token: 0x0602A5D1 RID: 173521 RVA: 0x009DE55B File Offset: 0x009DC75B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_DyStart_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A5D2 RID: 173522 RVA: 0x009DE56F File Offset: 0x009DC76F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_DyStart_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A5D3 RID: 173523 RVA: 0x009DE584 File Offset: 0x009DC784
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5D4 RID: 173524 RVA: 0x009DE5CC File Offset: 0x009DC7CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_DyStart_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A5D5 RID: 173525 RVA: 0x009DE613 File Offset: 0x009DC813
		protected GA_Motor_Drone_DyStart_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DCF RID: 89551
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyStart.GA_Motor_Drone_DyStart_C";

		// Token: 0x04015DD0 RID: 89552
		private static IntPtr _ClassPtr;

		// Token: 0x04015DD1 RID: 89553
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DD2 RID: 89554
		internal new static int __PropertyOffset_1;

		// Token: 0x04015DD3 RID: 89555
		[Nullable(2)]
		private TArray<FGameplayTag> _挂点Tags;

		// Token: 0x04015DD4 RID: 89556
		internal new static int __PropertyOffset_2;

		// Token: 0x04015DD5 RID: 89557
		[Nullable(2)]
		private TArray<FGameplayTag> _死眼Tag;

		// Token: 0x04015DD6 RID: 89558
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015DD7 RID: 89559
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A384 RID: 41860
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032168 RID: 205160
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
