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
	// Token: 0x02004070 RID: 16496
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook.GA_Motor_FixHook_C")]
	[UnrealStructLayout(1696, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class GA_Motor_FixHook_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A618 RID: 173592 RVA: 0x009DF03C File Offset: 0x009DD23C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_FixHook_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook.GA_Motor_FixHook_C");
			}
			return GA_Motor_FixHook_C._ClassPtr;
		}

		// Token: 0x0602A619 RID: 173593 RVA: 0x009DF060 File Offset: 0x009DD260
		public GA_Motor_FixHook_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FixHook_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A61A RID: 173594 RVA: 0x009DF088 File Offset: 0x009DD288
		[NullableContext(1)]
		public GA_Motor_FixHook_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FixHook_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067DF RID: 26591
		// (get) Token: 0x0602A61B RID: 173595 RVA: 0x009DF0BB File Offset: 0x009DD2BB
		// (set) Token: 0x0602A61C RID: 173596 RVA: 0x009DF0CF File Offset: 0x009DD2CF
		public unsafe TsBaseVehicle 施法载具
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170067E0 RID: 26592
		// (get) Token: 0x0602A61D RID: 173597 RVA: 0x009DF0E4 File Offset: 0x009DD2E4
		// (set) Token: 0x0602A61E RID: 173598 RVA: 0x009DF0F4 File Offset: 0x009DD2F4
		public unsafe int 驾驶员EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170067E1 RID: 26593
		// (get) Token: 0x0602A61F RID: 173599 RVA: 0x009DF105 File Offset: 0x009DD305
		// (set) Token: 0x0602A620 RID: 173600 RVA: 0x009DF119 File Offset: 0x009DD319
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170067E2 RID: 26594
		// (get) Token: 0x0602A621 RID: 173601 RVA: 0x009DF12E File Offset: 0x009DD32E
		// (set) Token: 0x0602A622 RID: 173602 RVA: 0x009DF142 File Offset: 0x009DD342
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170067E3 RID: 26595
		// (get) Token: 0x0602A623 RID: 173603 RVA: 0x009DF157 File Offset: 0x009DD357
		// (set) Token: 0x0602A624 RID: 173604 RVA: 0x009DF16B File Offset: 0x009DD36B
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170067E4 RID: 26596
		// (get) Token: 0x0602A625 RID: 173605 RVA: 0x009DF180 File Offset: 0x009DD380
		// (set) Token: 0x0602A626 RID: 173606 RVA: 0x009DF194 File Offset: 0x009DD394
		public unsafe FVector 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170067E5 RID: 26597
		// (get) Token: 0x0602A627 RID: 173607 RVA: 0x009DF1A9 File Offset: 0x009DD3A9
		// (set) Token: 0x0602A628 RID: 173608 RVA: 0x009DF1B9 File Offset: 0x009DD3B9
		public unsafe float 牵引速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170067E6 RID: 26598
		// (get) Token: 0x0602A629 RID: 173609 RVA: 0x009DF1CA File Offset: 0x009DD3CA
		// (set) Token: 0x0602A62A RID: 173610 RVA: 0x009DF1DA File Offset: 0x009DD3DA
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170067E7 RID: 26599
		// (get) Token: 0x0602A62B RID: 173611 RVA: 0x009DF1EB File Offset: 0x009DD3EB
		// (set) Token: 0x0602A62C RID: 173612 RVA: 0x009DF1FF File Offset: 0x009DD3FF
		public unsafe UKuroVehicleMovementComponent VehicleMovementComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVehicleMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170067E8 RID: 26600
		// (get) Token: 0x0602A62D RID: 173613 RVA: 0x009DF214 File Offset: 0x009DD414
		// (set) Token: 0x0602A62E RID: 173614 RVA: 0x009DF224 File Offset: 0x009DD424
		public unsafe float Speed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170067E9 RID: 26601
		// (get) Token: 0x0602A62F RID: 173615 RVA: 0x009DF235 File Offset: 0x009DD435
		// (set) Token: 0x0602A630 RID: 173616 RVA: 0x009DF249 File Offset: 0x009DD449
		public unsafe UCurveFloat SpeedCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170067EA RID: 26602
		// (get) Token: 0x0602A631 RID: 173617 RVA: 0x009DF25E File Offset: 0x009DD45E
		// (set) Token: 0x0602A632 RID: 173618 RVA: 0x009DF272 File Offset: 0x009DD472
		public unsafe FQuat Target_Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170067EB RID: 26603
		// (get) Token: 0x0602A633 RID: 173619 RVA: 0x009DF287 File Offset: 0x009DD487
		// (set) Token: 0x0602A634 RID: 173620 RVA: 0x009DF29B File Offset: 0x009DD49B
		public unsafe UCurveFloat QuatCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170067EC RID: 26604
		// (get) Token: 0x0602A635 RID: 173621 RVA: 0x009DF2B0 File Offset: 0x009DD4B0
		// (set) Token: 0x0602A636 RID: 173622 RVA: 0x009DF2C0 File Offset: 0x009DD4C0
		public unsafe float StartDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170067ED RID: 26605
		// (get) Token: 0x0602A637 RID: 173623 RVA: 0x009DF2D1 File Offset: 0x009DD4D1
		// (set) Token: 0x0602A638 RID: 173624 RVA: 0x009DF2E1 File Offset: 0x009DD4E1
		public unsafe float LastAlphaOnDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170067EE RID: 26606
		// (get) Token: 0x0602A639 RID: 173625 RVA: 0x009DF2F2 File Offset: 0x009DD4F2
		// (set) Token: 0x0602A63A RID: 173626 RVA: 0x009DF302 File Offset: 0x009DD502
		public unsafe bool Need_Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x170067EF RID: 26607
		// (get) Token: 0x0602A63B RID: 173627 RVA: 0x009DF313 File Offset: 0x009DD513
		// (set) Token: 0x0602A63C RID: 173628 RVA: 0x009DF323 File Offset: 0x009DD523
		public unsafe float TimeAtSpeedCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x0602A63D RID: 173629 RVA: 0x009DF334 File Offset: 0x009DD534
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_C.__FixHookEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602A63E RID: 173630 RVA: 0x009DF348 File Offset: 0x009DD548
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FixHookTick(bool LocationChange)
		{
			GA_Motor_FixHook_C.__FixHookTick_FunctionParams* ptr = stackalloc GA_Motor_FixHook_C.__FixHookTick_FunctionParams[(UIntPtr)511] + 15L / (long)sizeof(GA_Motor_FixHook_C.__FixHookTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_C.__FixHookTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LocationChange = LocationChange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_C.__FixHookTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A63F RID: 173631 RVA: 0x009DF391 File Offset: 0x009DD591
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602A640 RID: 173632 RVA: 0x009DF3A8 File Offset: 0x009DD5A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88D397D2A5(FGameplayEventData Payload)
		{
			GA_Motor_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D397D2A5_FunctionParams* ptr = stackalloc GA_Motor_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D397D2A5_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Motor_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D397D2A5_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D397D2A5_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D397D2A5_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Motor_FixHook_C.__EventReceived_18B59F5945020DB23C42FD88D397D2A5_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A641 RID: 173633 RVA: 0x009DF41D File Offset: 0x009DD61D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_EA3C560F46E3B3A5CE0B368596110C6B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_C.__OnFinish_EA3C560F46E3B3A5CE0B368596110C6B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A642 RID: 173634 RVA: 0x009DF431 File Offset: 0x009DD631
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_EA3C560F46E3B3A5CE0B368596110C6B()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_C.__OnTick_EA3C560F46E3B3A5CE0B368596110C6B_NativeFunctionPtr, null);
		}

		// Token: 0x0602A643 RID: 173635 RVA: 0x009DF445 File Offset: 0x009DD645
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A644 RID: 173636 RVA: 0x009DF459 File Offset: 0x009DD659
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FixHook_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A645 RID: 173637 RVA: 0x009DF470 File Offset: 0x009DD670
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_FixHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FixHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FixHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A646 RID: 173638 RVA: 0x009DF4B8 File Offset: 0x009DD6B8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_FixHook_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FixHook_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FixHook_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FixHook_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A647 RID: 173639 RVA: 0x009DF4FF File Offset: 0x009DD6FF
		protected GA_Motor_FixHook_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015E05 RID: 89605
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook.GA_Motor_FixHook_C";

		// Token: 0x04015E06 RID: 89606
		private static IntPtr _ClassPtr;

		// Token: 0x04015E07 RID: 89607
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015E08 RID: 89608
		internal new static int __PropertyOffset_1;

		// Token: 0x04015E09 RID: 89609
		internal new static int __PropertyOffset_2;

		// Token: 0x04015E0A RID: 89610
		internal new static int __PropertyOffset_3;

		// Token: 0x04015E0B RID: 89611
		internal static int __PropertyOffset_4;

		// Token: 0x04015E0C RID: 89612
		internal static int __PropertyOffset_5;

		// Token: 0x04015E0D RID: 89613
		internal static int __PropertyOffset_6;

		// Token: 0x04015E0E RID: 89614
		internal static int __PropertyOffset_7;

		// Token: 0x04015E0F RID: 89615
		internal static int __PropertyOffset_8;

		// Token: 0x04015E10 RID: 89616
		internal static int __PropertyOffset_9;

		// Token: 0x04015E11 RID: 89617
		internal static int __PropertyOffset_10;

		// Token: 0x04015E12 RID: 89618
		internal static int __PropertyOffset_11;

		// Token: 0x04015E13 RID: 89619
		internal static int __PropertyOffset_12;

		// Token: 0x04015E14 RID: 89620
		internal static int __PropertyOffset_13;

		// Token: 0x04015E15 RID: 89621
		internal static int __PropertyOffset_14;

		// Token: 0x04015E16 RID: 89622
		internal static int __PropertyOffset_15;

		// Token: 0x04015E17 RID: 89623
		internal static int __PropertyOffset_16;

		// Token: 0x04015E18 RID: 89624
		internal static int __PropertyOffset_17;

		// Token: 0x04015E19 RID: 89625
		private static IntPtr __FixHookEnd_NativeFunctionPtr;

		// Token: 0x04015E1A RID: 89626
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x04015E1B RID: 89627
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x04015E1C RID: 89628
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88D397D2A5_NativeFunctionPtr;

		// Token: 0x04015E1D RID: 89629
		private static IntPtr __OnFinish_EA3C560F46E3B3A5CE0B368596110C6B_NativeFunctionPtr;

		// Token: 0x04015E1E RID: 89630
		private static IntPtr __OnTick_EA3C560F46E3B3A5CE0B368596110C6B_NativeFunctionPtr;

		// Token: 0x04015E1F RID: 89631
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015E20 RID: 89632
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x0200A391 RID: 41873
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 496)]
		protected ref struct __FixHookTick_FunctionParams
		{
			// Token: 0x04032179 RID: 205177
			[FieldOffset(0)]
			public bool LocationChange;
		}

		// Token: 0x0200A392 RID: 41874
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88D397D2A5_FunctionParams
		{
			// Token: 0x0403217A RID: 205178
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A393 RID: 41875
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403217B RID: 205179
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
