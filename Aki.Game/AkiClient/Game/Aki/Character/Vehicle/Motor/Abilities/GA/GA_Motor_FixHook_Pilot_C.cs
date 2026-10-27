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
	// Token: 0x02004072 RID: 16498
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook_Pilot.GA_Motor_FixHook_Pilot_C")]
	[UnrealStructLayout(1696, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1688)]
	public class GA_Motor_FixHook_Pilot_C : GA_Base_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A685 RID: 173701 RVA: 0x009DFB00 File Offset: 0x009DDD00
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (GA_Motor_FixHook_Pilot_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook_Pilot.GA_Motor_FixHook_Pilot_C");
			}
			return GA_Motor_FixHook_Pilot_C._ClassPtr;
		}

		// Token: 0x0602A686 RID: 173702 RVA: 0x009DFB24 File Offset: 0x009DDD24
		public GA_Motor_FixHook_Pilot_C() : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FixHook_Pilot_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A687 RID: 173703 RVA: 0x009DFB4C File Offset: 0x009DDD4C
		[NullableContext(1)]
		public GA_Motor_FixHook_Pilot_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(GA_Motor_FixHook_Pilot_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006804 RID: 26628
		// (get) Token: 0x0602A688 RID: 173704 RVA: 0x009DFB7F File Offset: 0x009DDD7F
		// (set) Token: 0x0602A689 RID: 173705 RVA: 0x009DFB93 File Offset: 0x009DDD93
		public unsafe TsBaseVehicle 施法载具
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<TsBaseVehicle>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Pilot_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Pilot_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x17006805 RID: 26629
		// (get) Token: 0x0602A68A RID: 173706 RVA: 0x009DFBA8 File Offset: 0x009DDDA8
		// (set) Token: 0x0602A68B RID: 173707 RVA: 0x009DFBB8 File Offset: 0x009DDDB8
		public unsafe int 驾驶员EntityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006806 RID: 26630
		// (get) Token: 0x0602A68C RID: 173708 RVA: 0x009DFBC9 File Offset: 0x009DDDC9
		// (set) Token: 0x0602A68D RID: 173709 RVA: 0x009DFBDD File Offset: 0x009DDDDD
		public unsafe FVectorDouble FixHookLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006807 RID: 26631
		// (get) Token: 0x0602A68E RID: 173710 RVA: 0x009DFBF2 File Offset: 0x009DDDF2
		// (set) Token: 0x0602A68F RID: 173711 RVA: 0x009DFC06 File Offset: 0x009DDE06
		public unsafe FVector LastDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006808 RID: 26632
		// (get) Token: 0x0602A690 RID: 173712 RVA: 0x009DFC1B File Offset: 0x009DDE1B
		// (set) Token: 0x0602A691 RID: 173713 RVA: 0x009DFC2F File Offset: 0x009DDE2F
		public unsafe FVectorDouble LastLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006809 RID: 26633
		// (get) Token: 0x0602A692 RID: 173714 RVA: 0x009DFC44 File Offset: 0x009DDE44
		// (set) Token: 0x0602A693 RID: 173715 RVA: 0x009DFC58 File Offset: 0x009DDE58
		public unsafe FVector 牵引速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700680A RID: 26634
		// (get) Token: 0x0602A694 RID: 173716 RVA: 0x009DFC6D File Offset: 0x009DDE6D
		// (set) Token: 0x0602A695 RID: 173717 RVA: 0x009DFC7D File Offset: 0x009DDE7D
		public unsafe float BlockTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700680B RID: 26635
		// (get) Token: 0x0602A696 RID: 173718 RVA: 0x009DFC8E File Offset: 0x009DDE8E
		// (set) Token: 0x0602A697 RID: 173719 RVA: 0x009DFCA2 File Offset: 0x009DDEA2
		public unsafe UKuroVehicleMovementComponent VehicleMovementComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVehicleMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Pilot_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Pilot_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x1700680C RID: 26636
		// (get) Token: 0x0602A698 RID: 173720 RVA: 0x009DFCB7 File Offset: 0x009DDEB7
		// (set) Token: 0x0602A699 RID: 173721 RVA: 0x009DFCC7 File Offset: 0x009DDEC7
		public unsafe float Speed_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x1700680D RID: 26637
		// (get) Token: 0x0602A69A RID: 173722 RVA: 0x009DFCD8 File Offset: 0x009DDED8
		// (set) Token: 0x0602A69B RID: 173723 RVA: 0x009DFCEC File Offset: 0x009DDEEC
		public unsafe UCurveFloat SpeedCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Pilot_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Pilot_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x1700680E RID: 26638
		// (get) Token: 0x0602A69C RID: 173724 RVA: 0x009DFD01 File Offset: 0x009DDF01
		// (set) Token: 0x0602A69D RID: 173725 RVA: 0x009DFD15 File Offset: 0x009DDF15
		public unsafe FQuat Target_Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x1700680F RID: 26639
		// (get) Token: 0x0602A69E RID: 173726 RVA: 0x009DFD2A File Offset: 0x009DDF2A
		// (set) Token: 0x0602A69F RID: 173727 RVA: 0x009DFD3E File Offset: 0x009DDF3E
		public unsafe UCurveFloat QuatCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Pilot_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + GA_Motor_FixHook_Pilot_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17006810 RID: 26640
		// (get) Token: 0x0602A6A0 RID: 173728 RVA: 0x009DFD53 File Offset: 0x009DDF53
		// (set) Token: 0x0602A6A1 RID: 173729 RVA: 0x009DFD63 File Offset: 0x009DDF63
		public unsafe float StartDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_13);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_13) = value;
			}
		}

		// Token: 0x17006811 RID: 26641
		// (get) Token: 0x0602A6A2 RID: 173730 RVA: 0x009DFD74 File Offset: 0x009DDF74
		// (set) Token: 0x0602A6A3 RID: 173731 RVA: 0x009DFD84 File Offset: 0x009DDF84
		public unsafe float LastAlphaOnDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006812 RID: 26642
		// (get) Token: 0x0602A6A4 RID: 173732 RVA: 0x009DFD95 File Offset: 0x009DDF95
		// (set) Token: 0x0602A6A5 RID: 173733 RVA: 0x009DFDA5 File Offset: 0x009DDFA5
		public unsafe float TimeAtSpeedCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006813 RID: 26643
		// (get) Token: 0x0602A6A6 RID: 173734 RVA: 0x009DFDB6 File Offset: 0x009DDFB6
		// (set) Token: 0x0602A6A7 RID: 173735 RVA: 0x009DFDC6 File Offset: 0x009DDFC6
		public unsafe bool Need_Quat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006814 RID: 26644
		// (get) Token: 0x0602A6A8 RID: 173736 RVA: 0x009DFDD7 File Offset: 0x009DDFD7
		// (set) Token: 0x0602A6A9 RID: 173737 RVA: 0x009DFDE7 File Offset: 0x009DDFE7
		public unsafe int 变身材质handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006815 RID: 26645
		// (get) Token: 0x0602A6AA RID: 173738 RVA: 0x009DFDF8 File Offset: 0x009DDFF8
		// (set) Token: 0x0602A6AB RID: 173739 RVA: 0x009DFE08 File Offset: 0x009DE008
		public unsafe int 变身特效Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006816 RID: 26646
		// (get) Token: 0x0602A6AC RID: 173740 RVA: 0x009DFE19 File Offset: 0x009DE019
		// (set) Token: 0x0602A6AD RID: 173741 RVA: 0x009DFE29 File Offset: 0x009DE029
		public unsafe int 变身特效2Handle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x17006817 RID: 26647
		// (get) Token: 0x0602A6AE RID: 173742 RVA: 0x009DFE3A File Offset: 0x009DE03A
		// (set) Token: 0x0602A6AF RID: 173743 RVA: 0x009DFE4A File Offset: 0x009DE04A
		public unsafe int 钩锁ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_20);
			}
			set
			{
				*(base.NativePtr + (IntPtr)GA_Motor_FixHook_Pilot_C.__PropertyOffset_20) = value;
			}
		}

		// Token: 0x0602A6B0 RID: 173744 RVA: 0x009DFE5C File Offset: 0x009DE05C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void AddTags(ref TArray<FGameplayTag> TagsArray)
		{
			GA_Motor_FixHook_Pilot_C.__AddTags_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Pilot_C.__AddTags_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(GA_Motor_FixHook_Pilot_C.__AddTags_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Pilot_C.__AddTags_NativeFunctionPtr, (void*)ptr, 1);
			TArray<FGameplayTag> tarray = TagsArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->TagsArray);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__AddTags_NativeFunctionPtr, (void*)ptr);
			TArray<FGameplayTag> tarray2 = TagsArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->TagsArray);
			}
			UnrealReflectionUtils.DestroyStruct(GA_Motor_FixHook_Pilot_C.__AddTags_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A6B1 RID: 173745 RVA: 0x009DFED4 File Offset: 0x009DE0D4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void NiagaraSetting()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__NiagaraSetting_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6B2 RID: 173746 RVA: 0x009DFEE8 File Offset: 0x009DE0E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void Init(ref bool InitSuccess)
		{
			GA_Motor_FixHook_Pilot_C.__Init_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Pilot_C.__Init_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(GA_Motor_FixHook_Pilot_C.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Pilot_C.__Init_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InitSuccess = InitSuccess;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__Init_NativeFunctionPtr, (void*)ptr);
			InitSuccess = ptr->InitSuccess;
		}

		// Token: 0x0602A6B3 RID: 173747 RVA: 0x009DFF37 File Offset: 0x009DE137
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__FixHookEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6B4 RID: 173748 RVA: 0x009DFF4C File Offset: 0x009DE14C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void FixHookTick(bool LocationChange)
		{
			GA_Motor_FixHook_Pilot_C.__FixHookTick_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Pilot_C.__FixHookTick_FunctionParams[(UIntPtr)527] + 15L / (long)sizeof(GA_Motor_FixHook_Pilot_C.__FixHookTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Pilot_C.__FixHookTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->LocationChange = LocationChange;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__FixHookTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6B5 RID: 173749 RVA: 0x009DFF95 File Offset: 0x009DE195
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void FixHookStart()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__FixHookStart_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6B6 RID: 173750 RVA: 0x009DFFAC File Offset: 0x009DE1AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void EventReceived_18B59F5945020DB23C42FD8859A58434(FGameplayEventData Payload)
		{
			GA_Motor_FixHook_Pilot_C.__EventReceived_18B59F5945020DB23C42FD8859A58434_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Pilot_C.__EventReceived_18B59F5945020DB23C42FD8859A58434_FunctionParams[(UIntPtr)199] + 15L / (long)sizeof(GA_Motor_FixHook_Pilot_C.__EventReceived_18B59F5945020DB23C42FD8859A58434_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Pilot_C.__EventReceived_18B59F5945020DB23C42FD8859A58434_NativeFunctionPtr, (void*)ptr, 1);
			if (Payload != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEventData.StaticStruct(), &ptr->Payload, Payload.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__EventReceived_18B59F5945020DB23C42FD8859A58434_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(GA_Motor_FixHook_Pilot_C.__EventReceived_18B59F5945020DB23C42FD8859A58434_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602A6B7 RID: 173751 RVA: 0x009E0021 File Offset: 0x009DE221
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnFinish_8DAE42674B45A6FEE64E31924E97CDAD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnFinish_8DAE42674B45A6FEE64E31924E97CDAD_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6B8 RID: 173752 RVA: 0x009E0035 File Offset: 0x009DE235
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_8DAE42674B45A6FEE64E31924E97CDAD()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnTick_8DAE42674B45A6FEE64E31924E97CDAD_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6B9 RID: 173753 RVA: 0x009E0049 File Offset: 0x009DE249
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_EF1403574367A068E1C9B38B9C3F2B6A()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnTick_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6BA RID: 173754 RVA: 0x009E005D File Offset: 0x009DE25D
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_EF1403574367A068E1C9B38B9C3F2B6A()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnCancelled_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6BB RID: 173755 RVA: 0x009E0071 File Offset: 0x009DE271
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_EF1403574367A068E1C9B38B9C3F2B6A()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnInterrupted_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6BC RID: 173756 RVA: 0x009E0085 File Offset: 0x009DE285
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_EF1403574367A068E1C9B38B9C3F2B6A()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnBlendOut_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6BD RID: 173757 RVA: 0x009E0099 File Offset: 0x009DE299
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_EF1403574367A068E1C9B38B9C3F2B6A()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnCompleted_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6BE RID: 173758 RVA: 0x009E00AD File Offset: 0x009DE2AD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnTick_CF946D5D4EFE5E5564EFF09B494A439E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnTick_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6BF RID: 173759 RVA: 0x009E00C1 File Offset: 0x009DE2C1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCancelled_CF946D5D4EFE5E5564EFF09B494A439E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnCancelled_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6C0 RID: 173760 RVA: 0x009E00D5 File Offset: 0x009DE2D5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnInterrupted_CF946D5D4EFE5E5564EFF09B494A439E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnInterrupted_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6C1 RID: 173761 RVA: 0x009E00E9 File Offset: 0x009DE2E9
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnBlendOut_CF946D5D4EFE5E5564EFF09B494A439E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnBlendOut_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6C2 RID: 173762 RVA: 0x009E00FD File Offset: 0x009DE2FD
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void OnCompleted_CF946D5D4EFE5E5564EFF09B494A439E()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__OnCompleted_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6C3 RID: 173763 RVA: 0x009E0111 File Offset: 0x009DE311
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void K2_ActivateAbility()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__K2_ActivateAbility_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6C4 RID: 173764 RVA: 0x009E0125 File Offset: 0x009DE325
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected override void K2_ActivateAbility_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__K2_ActivateAbility_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A6C5 RID: 173765 RVA: 0x009E013C File Offset: 0x009DE33C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void K2_OnEndAbility(bool bWasCancelled)
		{
			GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6C6 RID: 173766 RVA: 0x009E0184 File Offset: 0x009DE384
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe override void K2_OnEndAbility_Implementation(bool bWasCancelled)
		{
			GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bWasCancelled = bWasCancelled;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__K2_OnEndAbility_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A6C7 RID: 173767 RVA: 0x009E01CC File Offset: 0x009DE3CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void PlayMontage4Func(UAnimMontage MontageToPlay, float Rate, bool bStopWhenAbilityEnds, float AnimRootMotionTranslationScale, float StartTimeSeconds, bool NeedTick)
		{
			GA_Motor_FixHook_Pilot_C.__PlayMontage4Func_FunctionParams* ptr = stackalloc GA_Motor_FixHook_Pilot_C.__PlayMontage4Func_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(GA_Motor_FixHook_Pilot_C.__PlayMontage4Func_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(GA_Motor_FixHook_Pilot_C.__PlayMontage4Func_NativeFunctionPtr, (void*)ptr, 1);
			ptr->MontageToPlay = ((MontageToPlay != null) ? MontageToPlay.NativePtr : IntPtr.Zero);
			ptr->Rate = Rate;
			ptr->bStopWhenAbilityEnds = bStopWhenAbilityEnds;
			ptr->AnimRootMotionTranslationScale = AnimRootMotionTranslationScale;
			ptr->StartTimeSeconds = StartTimeSeconds;
			ptr->NeedTick = NeedTick;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__PlayMontage4Func_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A6C8 RID: 173768 RVA: 0x009E0247 File Offset: 0x009DE447
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void CE_StartEnd()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, GA_Motor_FixHook_Pilot_C.__CE_StartEnd_NativeFunctionPtr, null);
		}

		// Token: 0x0602A6C9 RID: 173769 RVA: 0x009E025B File Offset: 0x009DE45B
		protected GA_Motor_FixHook_Pilot_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015E47 RID: 89671
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/Abilities/GA/GA_Motor_FixHook_Pilot.GA_Motor_FixHook_Pilot_C";

		// Token: 0x04015E48 RID: 89672
		private static IntPtr _ClassPtr;

		// Token: 0x04015E49 RID: 89673
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015E4A RID: 89674
		internal new static int __PropertyOffset_1;

		// Token: 0x04015E4B RID: 89675
		internal new static int __PropertyOffset_2;

		// Token: 0x04015E4C RID: 89676
		internal new static int __PropertyOffset_3;

		// Token: 0x04015E4D RID: 89677
		internal static int __PropertyOffset_4;

		// Token: 0x04015E4E RID: 89678
		internal static int __PropertyOffset_5;

		// Token: 0x04015E4F RID: 89679
		internal static int __PropertyOffset_6;

		// Token: 0x04015E50 RID: 89680
		internal static int __PropertyOffset_7;

		// Token: 0x04015E51 RID: 89681
		internal static int __PropertyOffset_8;

		// Token: 0x04015E52 RID: 89682
		internal static int __PropertyOffset_9;

		// Token: 0x04015E53 RID: 89683
		internal static int __PropertyOffset_10;

		// Token: 0x04015E54 RID: 89684
		internal static int __PropertyOffset_11;

		// Token: 0x04015E55 RID: 89685
		internal static int __PropertyOffset_12;

		// Token: 0x04015E56 RID: 89686
		internal static int __PropertyOffset_13;

		// Token: 0x04015E57 RID: 89687
		internal static int __PropertyOffset_14;

		// Token: 0x04015E58 RID: 89688
		internal static int __PropertyOffset_15;

		// Token: 0x04015E59 RID: 89689
		internal static int __PropertyOffset_16;

		// Token: 0x04015E5A RID: 89690
		internal static int __PropertyOffset_17;

		// Token: 0x04015E5B RID: 89691
		internal static int __PropertyOffset_18;

		// Token: 0x04015E5C RID: 89692
		internal static int __PropertyOffset_19;

		// Token: 0x04015E5D RID: 89693
		internal static int __PropertyOffset_20;

		// Token: 0x04015E5E RID: 89694
		private static IntPtr __AddTags_NativeFunctionPtr;

		// Token: 0x04015E5F RID: 89695
		private static IntPtr __NiagaraSetting_NativeFunctionPtr;

		// Token: 0x04015E60 RID: 89696
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x04015E61 RID: 89697
		private static IntPtr __FixHookEnd_NativeFunctionPtr;

		// Token: 0x04015E62 RID: 89698
		private static IntPtr __FixHookTick_NativeFunctionPtr;

		// Token: 0x04015E63 RID: 89699
		private static IntPtr __FixHookStart_NativeFunctionPtr;

		// Token: 0x04015E64 RID: 89700
		private static IntPtr __EventReceived_18B59F5945020DB23C42FD8859A58434_NativeFunctionPtr;

		// Token: 0x04015E65 RID: 89701
		private static IntPtr __OnFinish_8DAE42674B45A6FEE64E31924E97CDAD_NativeFunctionPtr;

		// Token: 0x04015E66 RID: 89702
		private static IntPtr __OnTick_8DAE42674B45A6FEE64E31924E97CDAD_NativeFunctionPtr;

		// Token: 0x04015E67 RID: 89703
		private static IntPtr __OnTick_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr;

		// Token: 0x04015E68 RID: 89704
		private static IntPtr __OnCancelled_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr;

		// Token: 0x04015E69 RID: 89705
		private static IntPtr __OnInterrupted_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr;

		// Token: 0x04015E6A RID: 89706
		private static IntPtr __OnBlendOut_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr;

		// Token: 0x04015E6B RID: 89707
		private static IntPtr __OnCompleted_EF1403574367A068E1C9B38B9C3F2B6A_NativeFunctionPtr;

		// Token: 0x04015E6C RID: 89708
		private static IntPtr __OnTick_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr;

		// Token: 0x04015E6D RID: 89709
		private static IntPtr __OnCancelled_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr;

		// Token: 0x04015E6E RID: 89710
		private static IntPtr __OnInterrupted_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr;

		// Token: 0x04015E6F RID: 89711
		private static IntPtr __OnBlendOut_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr;

		// Token: 0x04015E70 RID: 89712
		private static IntPtr __OnCompleted_CF946D5D4EFE5E5564EFF09B494A439E_NativeFunctionPtr;

		// Token: 0x04015E71 RID: 89713
		private static IntPtr __K2_ActivateAbility_NativeFunctionPtr;

		// Token: 0x04015E72 RID: 89714
		private static IntPtr __K2_OnEndAbility_NativeFunctionPtr;

		// Token: 0x04015E73 RID: 89715
		private static IntPtr __PlayMontage4Func_NativeFunctionPtr;

		// Token: 0x04015E74 RID: 89716
		private static IntPtr __CE_StartEnd_NativeFunctionPtr;

		// Token: 0x0200A398 RID: 41880
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddTags_FunctionParams
		{
			// Token: 0x04032180 RID: 205184
			[FieldOffset(0)]
			public byte TagsArray;
		}

		// Token: 0x0200A399 RID: 41881
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x04032181 RID: 205185
			[FieldOffset(0)]
			public bool InitSuccess;
		}

		// Token: 0x0200A39A RID: 41882
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 512)]
		protected ref struct __FixHookTick_FunctionParams
		{
			// Token: 0x04032182 RID: 205186
			[FieldOffset(0)]
			public bool LocationChange;
		}

		// Token: 0x0200A39B RID: 41883
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __EventReceived_18B59F5945020DB23C42FD8859A58434_FunctionParams
		{
			// Token: 0x04032183 RID: 205187
			[FieldOffset(0)]
			public byte Payload;
		}

		// Token: 0x0200A39C RID: 41884
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected new ref struct __K2_OnEndAbility_FunctionParams
		{
			// Token: 0x04032184 RID: 205188
			[FieldOffset(0)]
			public bool bWasCancelled;
		}

		// Token: 0x0200A39D RID: 41885
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __PlayMontage4Func_FunctionParams
		{
			// Token: 0x04032185 RID: 205189
			[FieldOffset(0)]
			public IntPtr MontageToPlay;

			// Token: 0x04032186 RID: 205190
			[FieldOffset(8)]
			public float Rate;

			// Token: 0x04032187 RID: 205191
			[FieldOffset(12)]
			public bool bStopWhenAbilityEnds;

			// Token: 0x04032188 RID: 205192
			[FieldOffset(16)]
			public float AnimRootMotionTranslationScale;

			// Token: 0x04032189 RID: 205193
			[FieldOffset(20)]
			public float StartTimeSeconds;

			// Token: 0x0403218A RID: 205194
			[FieldOffset(24)]
			public bool NeedTick;
		}
	}
}
