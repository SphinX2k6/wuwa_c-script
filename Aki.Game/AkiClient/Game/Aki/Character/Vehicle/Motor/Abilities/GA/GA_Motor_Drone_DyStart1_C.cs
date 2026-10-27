using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor.Abilities.GA
{
	// Token: 0x02004069 RID: 16489
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyStart1.GA_Motor_Drone_DyStart1_C")]
	[UnrealStructLayout(1592, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1592)]
	public class GA_Motor_Drone_DyStart1_C : GA_Motor_DroneBase_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A5BC RID: 173500 RVA: 0x009DE250 File Offset: 0x009DC450
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_Drone_DyStart1_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyStart1.GA_Motor_Drone_DyStart1_C");
			}
			return GA_Motor_Drone_DyStart1_C._ClassPtr;
		}

		// Token: 0x0602A5BD RID: 173501 RVA: 0x009DE274 File Offset: 0x009DC474
		public GA_Motor_Drone_DyStart1_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_DyStart1_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A5BE RID: 173502 RVA: 0x009DE29C File Offset: 0x009DC49C
		public GA_Motor_Drone_DyStart1_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_Drone_DyStart1_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067D2 RID: 26578
		// (get) Token: 0x0602A5BF RID: 173503 RVA: 0x009DE2D0 File Offset: 0x009DC4D0
		// (set) Token: 0x0602A5C0 RID: 173504 RVA: 0x009DE309 File Offset: 0x009DC509
		public TArray<FGameplayTag> 挂点Tags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._挂点Tags) == null)
				{
					result = (this._挂点Tags = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)GA_Motor_Drone_DyStart1_C.__PropertyOffset_1, this));
				}
				return result;
			}
			set
			{
				this.挂点Tags.CopyAssign(value);
			}
		}

		// Token: 0x170067D3 RID: 26579
		// (get) Token: 0x0602A5C1 RID: 173505 RVA: 0x009DE318 File Offset: 0x009DC518
		// (set) Token: 0x0602A5C2 RID: 173506 RVA: 0x009DE351 File Offset: 0x009DC551
		public TArray<FGameplayTag> 死眼Tag
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTag> result;
				if ((result = this._死眼Tag) == null)
				{
					result = (this._死眼Tag = new TArray<FGameplayTag>(base.NativePtr + (IntPtr)GA_Motor_Drone_DyStart1_C.__PropertyOffset_2, this));
				}
				return result;
			}
			set
			{
				this.死眼Tag.CopyAssign(value);
			}
		}

		// Token: 0x170067D4 RID: 26580
		// (get) Token: 0x0602A5C3 RID: 173507 RVA: 0x009DE35F File Offset: 0x009DC55F
		// (set) Token: 0x0602A5C4 RID: 173508 RVA: 0x009DE373 File Offset: 0x009DC573
		[Nullable(2)]
		public unsafe TsBaseVehicle 施法载具
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Drone_DyStart1_C.__PropertyOffset_3);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_Drone_DyStart1_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x0602A5C5 RID: 173509 RVA: 0x009DE388 File Offset: 0x009DC588
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A5C6 RID: 173510 RVA: 0x009DE3D0 File Offset: 0x009DC5D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_DyStart1_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A5C7 RID: 173511 RVA: 0x009DE417 File Offset: 0x009DC617
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_Drone_DyStart1_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A5C8 RID: 173512 RVA: 0x009DE42B File Offset: 0x009DC62B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_Drone_DyStart1_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A5C9 RID: 173513 RVA: 0x009DE440 File Offset: 0x009DC640
		protected GA_Motor_Drone_DyStart1_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015DC5 RID: 89541
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_Drone_DyStart1.GA_Motor_Drone_DyStart1_C";

		// Token: 0x04015DC6 RID: 89542
		private static IntPtr _ClassPtr;

		// Token: 0x04015DC7 RID: 89543
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015DC8 RID: 89544
		internal new static int __PropertyOffset_1;

		// Token: 0x04015DC9 RID: 89545
		[Nullable(2)]
		private TArray<FGameplayTag> _挂点Tags;

		// Token: 0x04015DCA RID: 89546
		internal new static int __PropertyOffset_2;

		// Token: 0x04015DCB RID: 89547
		[Nullable(2)]
		private TArray<FGameplayTag> _死眼Tag;

		// Token: 0x04015DCC RID: 89548
		internal new static int __PropertyOffset_3;

		// Token: 0x04015DCD RID: 89549
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04015DCE RID: 89550
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x0200A383 RID: 41859
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032167 RID: 205159
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
