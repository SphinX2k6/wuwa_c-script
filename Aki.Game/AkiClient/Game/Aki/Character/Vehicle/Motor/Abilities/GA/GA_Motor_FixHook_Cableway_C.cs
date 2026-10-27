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
	// Token: 0x02004071 RID: 16497
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook_Cableway.GA_Motor_FixHook_Cableway_C")]
	[UnrealStructLayout(1712, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1700)]
	public class GA_Motor_FixHook_Cableway_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A648 RID: 173640 RVA: 0x009DF508 File Offset: 0x009DD708
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_FixHook_Cableway_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook_Cableway.GA_Motor_FixHook_Cableway_C");
			}
			return GA_Motor_FixHook_Cableway_C._ClassPtr;
		}

		// Token: 0x0602A649 RID: 173641 RVA: 0x009DF52C File Offset: 0x009DD72C
		public GA_Motor_FixHook_Cableway_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FixHook_Cableway_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A64A RID: 173642 RVA: 0x009DF554 File Offset: 0x009DD754
		[NullableContext(1)]
		public GA_Motor_FixHook_Cableway_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FixHook_Cableway_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170067F0 RID: 26608
		// (get) Token: 0x0602A64B RID: 173643 RVA: 0x009DF587 File Offset: 0x009DD787
		// (set) Token: 0x0602A64C RID: 173644 RVA: 0x009DF59B File Offset: 0x009DD79B
		public unsafe TsBaseVehicle 施法载具
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Cableway_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Cableway_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x170067F1 RID: 26609
		// (get) Token: 0x0602A64D RID: 173645 RVA: 0x009DF5B0 File Offset: 0x009DD7B0
		// (set) Token: 0x0602A64E RID: 173646 RVA: 0x009DF5C0 File Offset: 0x009DD7C0
		public unsafe int 驾驶员EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170067F2 RID: 26610
		// (get) Token: 0x0602A64F RID: 173647 RVA: 0x009DF5D1 File Offset: 0x009DD7D1
		// (set) Token: 0x0602A650 RID: 173648 RVA: 0x009DF5E5 File Offset: 0x009DD7E5
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170067F3 RID: 26611
		// (get) Token: 0x0602A651 RID: 173649 RVA: 0x009DF5FA File Offset: 0x009DD7FA
		// (set) Token: 0x0602A652 RID: 173650 RVA: 0x009DF60E File Offset: 0x009DD80E
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170067F4 RID: 26612
		// (get) Token: 0x0602A653 RID: 173651 RVA: 0x009DF623 File Offset: 0x009DD823
		// (set) Token: 0x0602A654 RID: 173652 RVA: 0x009DF637 File Offset: 0x009DD837
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170067F5 RID: 26613
		// (get) Token: 0x0602A655 RID: 173653 RVA: 0x009DF64C File Offset: 0x009DD84C
		// (set) Token: 0x0602A656 RID: 173654 RVA: 0x009DF660 File Offset: 0x009DD860
		public unsafe FVector 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170067F6 RID: 26614
		// (get) Token: 0x0602A657 RID: 173655 RVA: 0x009DF675 File Offset: 0x009DD875
		// (set) Token: 0x0602A658 RID: 173656 RVA: 0x009DF685 File Offset: 0x009DD885
		public unsafe float 牵引速率
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170067F7 RID: 26615
		// (get) Token: 0x0602A659 RID: 173657 RVA: 0x009DF696 File Offset: 0x009DD896
		// (set) Token: 0x0602A65A RID: 173658 RVA: 0x009DF6A6 File Offset: 0x009DD8A6
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170067F8 RID: 26616
		// (get) Token: 0x0602A65B RID: 173659 RVA: 0x009DF6B7 File Offset: 0x009DD8B7
		// (set) Token: 0x0602A65C RID: 173660 RVA: 0x009DF6CB File Offset: 0x009DD8CB
		public unsafe UKuroVehicleMovementComponent VehicleMovementComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVehicleMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Cableway_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Cableway_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x170067F9 RID: 26617
		// (get) Token: 0x0602A65D RID: 173661 RVA: 0x009DF6E0 File Offset: 0x009DD8E0
		// (set) Token: 0x0602A65E RID: 173662 RVA: 0x009DF6F0 File Offset: 0x009DD8F0
		public unsafe float Speed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170067FA RID: 26618
		// (get) Token: 0x0602A65F RID: 173663 RVA: 0x009DF701 File Offset: 0x009DD901
		// (set) Token: 0x0602A660 RID: 173664 RVA: 0x009DF715 File Offset: 0x009DD915
		public unsafe UCurveFloat SpeedCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Cableway_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Cableway_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x170067FB RID: 26619
		// (get) Token: 0x0602A661 RID: 173665 RVA: 0x009DF72A File Offset: 0x009DD92A
		// (set) Token: 0x0602A662 RID: 173666 RVA: 0x009DF73E File Offset: 0x009DD93E
		public unsafe FQuat Target_Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170067FC RID: 26620
		// (get) Token: 0x0602A663 RID: 173667 RVA: 0x009DF753 File Offset: 0x009DD953
		// (set) Token: 0x0602A664 RID: 173668 RVA: 0x009DF767 File Offset: 0x009DD967
		public unsafe UCurveFloat QuatCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Cableway_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Cableway_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x170067FD RID: 26621
		// (get) Token: 0x0602A665 RID: 173669 RVA: 0x009DF77C File Offset: 0x009DD97C
		// (set) Token: 0x0602A666 RID: 173670 RVA: 0x009DF78C File Offset: 0x009DD98C
		public unsafe float StartDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x170067FE RID: 26622
		// (get) Token: 0x0602A667 RID: 173671 RVA: 0x009DF79D File Offset: 0x009DD99D
		// (set) Token: 0x0602A668 RID: 173672 RVA: 0x009DF7AD File Offset: 0x009DD9AD
		public unsafe float LastAlphaOnDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x170067FF RID: 26623
		// (get) Token: 0x0602A669 RID: 173673 RVA: 0x009DF7BE File Offset: 0x009DD9BE
		// (set) Token: 0x0602A66A RID: 173674 RVA: 0x009DF7CE File Offset: 0x009DD9CE
		public unsafe bool Need_Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006800 RID: 26624
		// (get) Token: 0x0602A66B RID: 173675 RVA: 0x009DF7DF File Offset: 0x009DD9DF
		// (set) Token: 0x0602A66C RID: 173676 RVA: 0x009DF7EF File Offset: 0x009DD9EF
		public unsafe float TimeAtSpeedCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006801 RID: 26625
		// (get) Token: 0x0602A66D RID: 173677 RVA: 0x009DF800 File Offset: 0x009DDA00
		// (set) Token: 0x0602A66E RID: 173678 RVA: 0x009DF810 File Offset: 0x009DDA10
		public unsafe bool IsStartGetOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_18) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_18) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006802 RID: 26626
		// (get) Token: 0x0602A66F RID: 173679 RVA: 0x009DF821 File Offset: 0x009DDA21
		// (set) Token: 0x0602A670 RID: 173680 RVA: 0x009DF831 File Offset: 0x009DDA31
		public unsafe int 钩锁Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006803 RID: 26627
		// (get) Token: 0x0602A671 RID: 173681 RVA: 0x009DF842 File Offset: 0x009DDA42
		// (set) Token: 0x0602A672 RID: 173682 RVA: 0x009DF852 File Offset: 0x009DDA52
		public unsafe int 变身材质handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Cableway_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x0602A673 RID: 173683 RVA: 0x009DF864 File Offset: 0x009DDA64
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Init(ref bool InitSuccess)
		{
			GA_Motor_FixHook_Cableway_C.__Init_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Cableway_C.__Init_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Motor_FixHook_Cableway_C.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Cableway_C.__Init_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InitSuccess = InitSuccess;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__Init_NativeFunctionPtr, (void*)ptr);
			InitSuccess = ptr->InitSuccess;
		}

		// Token: 0x0602A674 RID: 173684 RVA: 0x009DF8B3 File Offset: 0x009DDAB3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__FixHookEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602A675 RID: 173685 RVA: 0x009DF8C8 File Offset: 0x009DDAC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FixHookTick(bool LocationChange)
		{
			GA_Motor_FixHook_Cableway_C.__FixHookTick_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Cableway_C.__FixHookTick_FunctionParams[(UIntPtr)543] + 15L / (long)sizeof(GA_Motor_FixHook_Cableway_C.__FixHookTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Cableway_C.__FixHookTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LocationChange = LocationChange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__FixHookTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A676 RID: 173686 RVA: 0x009DF911 File Offset: 0x009DDB11
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602A677 RID: 173687 RVA: 0x009DF928 File Offset: 0x009DDB28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD88B63A122A(FGameplayEventData Payload)
		{
			GA_Motor_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD88B63A122A_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD88B63A122A_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Motor_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD88B63A122A_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD88B63A122A_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD88B63A122A_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Motor_FixHook_Cableway_C.__EventReceived_18B59F5945020DB23C42FD88B63A122A_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A678 RID: 173688 RVA: 0x009DF99D File Offset: 0x009DDB9D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B4EBDC293()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__OnTick_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr, null);
		}

		// Token: 0x0602A679 RID: 173689 RVA: 0x009DF9B1 File Offset: 0x009DDBB1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B4EBDC293()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr, null);
		}

		// Token: 0x0602A67A RID: 173690 RVA: 0x009DF9C5 File Offset: 0x009DDBC5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B4EBDC293()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr, null);
		}

		// Token: 0x0602A67B RID: 173691 RVA: 0x009DF9D9 File Offset: 0x009DDBD9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B4EBDC293()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr, null);
		}

		// Token: 0x0602A67C RID: 173692 RVA: 0x009DF9ED File Offset: 0x009DDBED
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B4EBDC293()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr, null);
		}

		// Token: 0x0602A67D RID: 173693 RVA: 0x009DFA01 File Offset: 0x009DDC01
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_4936A46849866951391520A2998AAD52()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__OnFinish_4936A46849866951391520A2998AAD52_NativeFunctionPtr, null);
		}

		// Token: 0x0602A67E RID: 173694 RVA: 0x009DFA15 File Offset: 0x009DDC15
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_4936A46849866951391520A2998AAD52()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__OnTick_4936A46849866951391520A2998AAD52_NativeFunctionPtr, null);
		}

		// Token: 0x0602A67F RID: 173695 RVA: 0x009DFA29 File Offset: 0x009DDC29
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A680 RID: 173696 RVA: 0x009DFA3D File Offset: 0x009DDC3D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A681 RID: 173697 RVA: 0x009DFA54 File Offset: 0x009DDC54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A682 RID: 173698 RVA: 0x009DFA9C File Offset: 0x009DDC9C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A683 RID: 173699 RVA: 0x009DFAE3 File Offset: 0x009DDCE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void Get_Off()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Cableway_C.__Get_Off_NativeFunctionPtr, null);
		}

		// Token: 0x0602A684 RID: 173700 RVA: 0x009DFAF7 File Offset: 0x009DDCF7
		protected GA_Motor_FixHook_Cableway_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015E21 RID: 89633
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook_Cableway.GA_Motor_FixHook_Cableway_C";

		// Token: 0x04015E22 RID: 89634
		private static IntPtr _ClassPtr;

		// Token: 0x04015E23 RID: 89635
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015E24 RID: 89636
		internal new static int __PropertyOffset_1;

		// Token: 0x04015E25 RID: 89637
		internal new static int __PropertyOffset_2;

		// Token: 0x04015E26 RID: 89638
		internal new static int __PropertyOffset_3;

		// Token: 0x04015E27 RID: 89639
		internal static int __PropertyOffset_4;

		// Token: 0x04015E28 RID: 89640
		internal static int __PropertyOffset_5;

		// Token: 0x04015E29 RID: 89641
		internal static int __PropertyOffset_6;

		// Token: 0x04015E2A RID: 89642
		internal static int __PropertyOffset_7;

		// Token: 0x04015E2B RID: 89643
		internal static int __PropertyOffset_8;

		// Token: 0x04015E2C RID: 89644
		internal static int __PropertyOffset_9;

		// Token: 0x04015E2D RID: 89645
		internal static int __PropertyOffset_10;

		// Token: 0x04015E2E RID: 89646
		internal static int __PropertyOffset_11;

		// Token: 0x04015E2F RID: 89647
		internal static int __PropertyOffset_12;

		// Token: 0x04015E30 RID: 89648
		internal static int __PropertyOffset_13;

		// Token: 0x04015E31 RID: 89649
		internal static int __PropertyOffset_14;

		// Token: 0x04015E32 RID: 89650
		internal static int __PropertyOffset_15;

		// Token: 0x04015E33 RID: 89651
		internal static int __PropertyOffset_16;

		// Token: 0x04015E34 RID: 89652
		internal static int __PropertyOffset_17;

		// Token: 0x04015E35 RID: 89653
		internal static int __PropertyOffset_18;

		// Token: 0x04015E36 RID: 89654
		internal static int __PropertyOffset_19;

		// Token: 0x04015E37 RID: 89655
		internal static int __PropertyOffset_20;

		// Token: 0x04015E38 RID: 89656
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04015E39 RID: 89657
		private static IntPtr __FixHookEnd_NativeFunctionPtr;

		// Token: 0x04015E3A RID: 89658
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x04015E3B RID: 89659
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x04015E3C RID: 89660
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD88B63A122A_NativeFunctionPtr;

		// Token: 0x04015E3D RID: 89661
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr;

		// Token: 0x04015E3E RID: 89662
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr;

		// Token: 0x04015E3F RID: 89663
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr;

		// Token: 0x04015E40 RID: 89664
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr;

		// Token: 0x04015E41 RID: 89665
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B4EBDC293_NativeFunctionPtr;

		// Token: 0x04015E42 RID: 89666
		private static IntPtr __OnFinish_4936A46849866951391520A2998AAD52_NativeFunctionPtr;

		// Token: 0x04015E43 RID: 89667
		private static IntPtr __OnTick_4936A46849866951391520A2998AAD52_NativeFunctionPtr;

		// Token: 0x04015E44 RID: 89668
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015E45 RID: 89669
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04015E46 RID: 89670
		private static IntPtr __Get_Off_NativeFunctionPtr;

		// Token: 0x0200A394 RID: 41876
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x0403217C RID: 205180
			[FieldOffset(0)]
			public bool InitSuccess;
		}

		// Token: 0x0200A395 RID: 41877
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 528)]
		protected ref struct __FixHookTick_FunctionParams
		{
			// Token: 0x0403217D RID: 205181
			[FieldOffset(0)]
			public bool LocationChange;
		}

		// Token: 0x0200A396 RID: 41878
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD88B63A122A_FunctionParams
		{
			// Token: 0x0403217E RID: 205182
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A397 RID: 41879
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x0403217F RID: 205183
			[FieldOffset(0)]
			public bool bWasCancelled;
		}
	}
}
