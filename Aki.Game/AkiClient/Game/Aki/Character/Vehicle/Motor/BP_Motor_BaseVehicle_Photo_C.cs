using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Data;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor
{
	// Token: 0x0200328E RID: 12942
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Photo.BP_Motor_BaseVehicle_Photo_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_Motor_BaseVehicle_Photo_C : BP_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602067E RID: 132734 RVA: 0x0094594F File Offset: 0x00943B4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_Photo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Photo.BP_Motor_BaseVehicle_Photo_C");
			}
			return BP_Motor_BaseVehicle_Photo_C._ClassPtr;
		}

		// Token: 0x0602067F RID: 132735 RVA: 0x00945974 File Offset: 0x00943B74
		public BP_Motor_BaseVehicle_Photo_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Photo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020680 RID: 132736 RVA: 0x0094599C File Offset: 0x00943B9C
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_Photo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Photo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EDF RID: 16095
		// (get) Token: 0x06020681 RID: 132737 RVA: 0x009459CF File Offset: 0x00943BCF
		// (set) Token: 0x06020682 RID: 132738 RVA: 0x009459E3 File Offset: 0x00943BE3
		public unsafe USkeletalMeshComponent OtherCase5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase5, value);
			}
		}

		// Token: 0x17003EE0 RID: 16096
		// (get) Token: 0x06020683 RID: 132739 RVA: 0x009459F8 File Offset: 0x00943BF8
		// (set) Token: 0x06020684 RID: 132740 RVA: 0x00945A0C File Offset: 0x00943C0C
		public unsafe USkeletalMeshComponent OtherCase4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase4, value);
			}
		}

		// Token: 0x17003EE1 RID: 16097
		// (get) Token: 0x06020685 RID: 132741 RVA: 0x00945A21 File Offset: 0x00943C21
		// (set) Token: 0x06020686 RID: 132742 RVA: 0x00945A35 File Offset: 0x00943C35
		public unsafe USphereComponent SphereForInteraction2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_SphereForInteraction2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_SphereForInteraction2, value);
			}
		}

		// Token: 0x17003EE2 RID: 16098
		// (get) Token: 0x06020687 RID: 132743 RVA: 0x00945A4A File Offset: 0x00943C4A
		// (set) Token: 0x06020688 RID: 132744 RVA: 0x00945A5E File Offset: 0x00943C5E
		public unsafe USphereComponent SphereForInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_SphereForInteraction);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_SphereForInteraction, value);
			}
		}

		// Token: 0x17003EE3 RID: 16099
		// (get) Token: 0x06020689 RID: 132745 RVA: 0x00945A73 File Offset: 0x00943C73
		// (set) Token: 0x0602068A RID: 132746 RVA: 0x00945A87 File Offset: 0x00943C87
		public unsafe UCapsuleComponent CapsuleForTriggerAndBlockOtherVehicle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_CapsuleForTriggerAndBlockOtherVehicle);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_CapsuleForTriggerAndBlockOtherVehicle, value);
			}
		}

		// Token: 0x17003EE4 RID: 16100
		// (get) Token: 0x0602068B RID: 132747 RVA: 0x00945A9C File Offset: 0x00943C9C
		// (set) Token: 0x0602068C RID: 132748 RVA: 0x00945AB0 File Offset: 0x00943CB0
		public unsafe UCapsuleComponent CapsuleForDither
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_CapsuleForDither);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_CapsuleForDither, value);
			}
		}

		// Token: 0x17003EE5 RID: 16101
		// (get) Token: 0x0602068D RID: 132749 RVA: 0x00945AC5 File Offset: 0x00943CC5
		// (set) Token: 0x0602068E RID: 132750 RVA: 0x00945AD9 File Offset: 0x00943CD9
		public unsafe USkeletalMeshComponent OtherCase3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase3, value);
			}
		}

		// Token: 0x17003EE6 RID: 16102
		// (get) Token: 0x0602068F RID: 132751 RVA: 0x00945AEE File Offset: 0x00943CEE
		// (set) Token: 0x06020690 RID: 132752 RVA: 0x00945B02 File Offset: 0x00943D02
		public unsafe USkeletalMeshComponent OtherCase2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase2, value);
			}
		}

		// Token: 0x17003EE7 RID: 16103
		// (get) Token: 0x06020691 RID: 132753 RVA: 0x00945B17 File Offset: 0x00943D17
		// (set) Token: 0x06020692 RID: 132754 RVA: 0x00945B2B File Offset: 0x00943D2B
		public unsafe USkeletalMeshComponent OtherCase1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_OtherCase1, value);
			}
		}

		// Token: 0x17003EE8 RID: 16104
		// (get) Token: 0x06020693 RID: 132755 RVA: 0x00945B40 File Offset: 0x00943D40
		// (set) Token: 0x06020694 RID: 132756 RVA: 0x00945B54 File Offset: 0x00943D54
		public unsafe UCapsuleComponent CapsuleForPhotograph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_CapsuleForPhotograph);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_CapsuleForPhotograph, value);
			}
		}

		// Token: 0x17003EE9 RID: 16105
		// (get) Token: 0x06020695 RID: 132757 RVA: 0x00945B69 File Offset: 0x00943D69
		// (set) Token: 0x06020696 RID: 132758 RVA: 0x00945B7D File Offset: 0x00943D7D
		public unsafe UDataTable 技能表_用于加载_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_技能表_用于加载_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_技能表_用于加载_, value);
			}
		}

		// Token: 0x17003EEA RID: 16106
		// (get) Token: 0x06020697 RID: 132759 RVA: 0x00945B92 File Offset: 0x00943D92
		// (set) Token: 0x06020698 RID: 132760 RVA: 0x00945BA2 File Offset: 0x00943DA2
		public unsafe float 虚化碰撞NPC半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_虚化碰撞NPC半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_虚化碰撞NPC半径) = value;
			}
		}

		// Token: 0x17003EEB RID: 16107
		// (get) Token: 0x06020699 RID: 132761 RVA: 0x00945BB3 File Offset: 0x00943DB3
		// (set) Token: 0x0602069A RID: 132762 RVA: 0x00945BC7 File Offset: 0x00943DC7
		public unsafe UCurveFloat 深度虚化值曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_深度虚化值曲线);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_深度虚化值曲线, value);
			}
		}

		// Token: 0x0602069B RID: 132763 RVA: 0x00945BDC File Offset: 0x00943DDC
		[SkipLocalsInit]
		public virtual void 刷新配置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__刷新配置_NativeFunctionPtr, null);
		}

		// Token: 0x0602069C RID: 132764 RVA: 0x00945BF0 File Offset: 0x00943DF0
		[SkipLocalsInit]
		public unsafe virtual void GetConfigDataNameTagMap(ref TMap<FName, FGameplayTag> Result)
		{
			BP_Motor_BaseVehicle_Photo_C.__GetConfigDataNameTagMap_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_Photo_C.__GetConfigDataNameTagMap_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_Motor_BaseVehicle_Photo_C.__GetConfigDataNameTagMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_Photo_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FGameplayTag> tmap = Result;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->Result);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FGameplayTag> tmap2 = Result;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->Result);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Motor_BaseVehicle_Photo_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602069D RID: 132765 RVA: 0x00945C6C File Offset: 0x00943E6C
		[SkipLocalsInit]
		public unsafe virtual void GetConfigDataByKeyName(FName Name, ref SMotorConfigs Result)
		{
			BP_Motor_BaseVehicle_Photo_C.__GetConfigDataByKeyName_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_Photo_C.__GetConfigDataByKeyName_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_Motor_BaseVehicle_Photo_C.__GetConfigDataByKeyName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_Photo_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Name = Name;
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorConfigs.StaticStruct(), &ptr->Result, Result.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr);
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorConfigs.StaticStruct(), Result.NativePtr, &ptr->Result, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Motor_BaseVehicle_Photo_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602069E RID: 132766 RVA: 0x00945D0E File Offset: 0x00943F0E
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602069F RID: 132767 RVA: 0x00945D22 File Offset: 0x00943F22
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x060206A0 RID: 132768 RVA: 0x00945D38 File Offset: 0x00943F38
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060206A1 RID: 132769 RVA: 0x00945D80 File Offset: 0x00943F80
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060206A2 RID: 132770 RVA: 0x00945DC6 File Offset: 0x00943FC6
		protected BP_Motor_BaseVehicle_Photo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401180A RID: 71690
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Photo.BP_Motor_BaseVehicle_Photo_C";

		// Token: 0x0401180B RID: 71691
		private static IntPtr _ClassPtr;

		// Token: 0x0401180C RID: 71692
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401180D RID: 71693
		internal static int __PropertyOffset_OtherCase5;

		// Token: 0x0401180E RID: 71694
		internal static int __PropertyOffset_OtherCase4;

		// Token: 0x0401180F RID: 71695
		internal static int __PropertyOffset_SphereForInteraction2;

		// Token: 0x04011810 RID: 71696
		internal static int __PropertyOffset_SphereForInteraction;

		// Token: 0x04011811 RID: 71697
		internal static int __PropertyOffset_CapsuleForTriggerAndBlockOtherVehicle;

		// Token: 0x04011812 RID: 71698
		internal static int __PropertyOffset_CapsuleForDither;

		// Token: 0x04011813 RID: 71699
		internal static int __PropertyOffset_OtherCase3;

		// Token: 0x04011814 RID: 71700
		internal static int __PropertyOffset_OtherCase2;

		// Token: 0x04011815 RID: 71701
		internal static int __PropertyOffset_OtherCase1;

		// Token: 0x04011816 RID: 71702
		internal static int __PropertyOffset_CapsuleForPhotograph;

		// Token: 0x04011817 RID: 71703
		internal static int __PropertyOffset_技能表_用于加载_;

		// Token: 0x04011818 RID: 71704
		internal static int __PropertyOffset_虚化碰撞NPC半径;

		// Token: 0x04011819 RID: 71705
		internal static int __PropertyOffset_深度虚化值曲线;

		// Token: 0x0401181A RID: 71706
		private static IntPtr __刷新配置_NativeFunctionPtr;

		// Token: 0x0401181B RID: 71707
		private static IntPtr __GetConfigDataNameTagMap_NativeFunctionPtr;

		// Token: 0x0401181C RID: 71708
		private static IntPtr __GetConfigDataByKeyName_NativeFunctionPtr;

		// Token: 0x0401181D RID: 71709
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0401181E RID: 71710
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x02008F60 RID: 36704
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetConfigDataNameTagMap_FunctionParams
		{
			// Token: 0x0402CCD6 RID: 183510
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x02008F61 RID: 36705
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetConfigDataByKeyName_FunctionParams
		{
			// Token: 0x0402CCD7 RID: 183511
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x0402CCD8 RID: 183512
			[FieldOffset(16)]
			public byte Result;
		}

		// Token: 0x02008F62 RID: 36706
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CCD9 RID: 183513
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
