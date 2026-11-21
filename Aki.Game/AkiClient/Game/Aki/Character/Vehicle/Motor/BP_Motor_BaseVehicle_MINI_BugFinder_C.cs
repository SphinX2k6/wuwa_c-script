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
	// Token: 0x0200328D RID: 12941
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_MINI_BugFinder.BP_Motor_BaseVehicle_MINI_BugFinder_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_Motor_BaseVehicle_MINI_BugFinder_C : BP_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020656 RID: 132694 RVA: 0x00945493 File Offset: 0x00943693
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_MINI_BugFinder_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_MINI_BugFinder.BP_Motor_BaseVehicle_MINI_BugFinder_C");
			}
			return BP_Motor_BaseVehicle_MINI_BugFinder_C._ClassPtr;
		}

		// Token: 0x06020657 RID: 132695 RVA: 0x009454B8 File Offset: 0x009436B8
		public BP_Motor_BaseVehicle_MINI_BugFinder_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_MINI_BugFinder_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020658 RID: 132696 RVA: 0x009454E0 File Offset: 0x009436E0
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_MINI_BugFinder_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_MINI_BugFinder_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x06020659 RID: 132697 RVA: 0x00945513 File Offset: 0x00943713
		// (set) Token: 0x0602065A RID: 132698 RVA: 0x00945527 File Offset: 0x00943727
		public unsafe USkeletalMeshComponent OtherCase5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase5, value);
			}
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x0602065B RID: 132699 RVA: 0x0094553C File Offset: 0x0094373C
		// (set) Token: 0x0602065C RID: 132700 RVA: 0x00945550 File Offset: 0x00943750
		public unsafe USkeletalMeshComponent OtherCase4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase4, value);
			}
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x0602065D RID: 132701 RVA: 0x00945565 File Offset: 0x00943765
		// (set) Token: 0x0602065E RID: 132702 RVA: 0x00945579 File Offset: 0x00943779
		public unsafe USphereComponent SphereForInteraction2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_SphereForInteraction2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_SphereForInteraction2, value);
			}
		}

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x0602065F RID: 132703 RVA: 0x0094558E File Offset: 0x0094378E
		// (set) Token: 0x06020660 RID: 132704 RVA: 0x009455A2 File Offset: 0x009437A2
		public unsafe USphereComponent SphereForInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_SphereForInteraction);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_SphereForInteraction, value);
			}
		}

		// Token: 0x17003ED6 RID: 16086
		// (get) Token: 0x06020661 RID: 132705 RVA: 0x009455B7 File Offset: 0x009437B7
		// (set) Token: 0x06020662 RID: 132706 RVA: 0x009455CB File Offset: 0x009437CB
		public unsafe UCapsuleComponent CapsuleForTriggerAndBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_CapsuleForTriggerAndBlock);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_CapsuleForTriggerAndBlock, value);
			}
		}

		// Token: 0x17003ED7 RID: 16087
		// (get) Token: 0x06020663 RID: 132707 RVA: 0x009455E0 File Offset: 0x009437E0
		// (set) Token: 0x06020664 RID: 132708 RVA: 0x009455F4 File Offset: 0x009437F4
		public unsafe UCapsuleComponent CapsuleForDither
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_CapsuleForDither);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_CapsuleForDither, value);
			}
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x06020665 RID: 132709 RVA: 0x00945609 File Offset: 0x00943809
		// (set) Token: 0x06020666 RID: 132710 RVA: 0x0094561D File Offset: 0x0094381D
		public unsafe USkeletalMeshComponent OtherCase3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase3, value);
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x06020667 RID: 132711 RVA: 0x00945632 File Offset: 0x00943832
		// (set) Token: 0x06020668 RID: 132712 RVA: 0x00945646 File Offset: 0x00943846
		public unsafe USkeletalMeshComponent OtherCase2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase2, value);
			}
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x06020669 RID: 132713 RVA: 0x0094565B File Offset: 0x0094385B
		// (set) Token: 0x0602066A RID: 132714 RVA: 0x0094566F File Offset: 0x0094386F
		public unsafe USkeletalMeshComponent OtherCase1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_OtherCase1, value);
			}
		}

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x0602066B RID: 132715 RVA: 0x00945684 File Offset: 0x00943884
		// (set) Token: 0x0602066C RID: 132716 RVA: 0x00945698 File Offset: 0x00943898
		public unsafe UCapsuleComponent CapsuleForPhotograph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_CapsuleForPhotograph);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_CapsuleForPhotograph, value);
			}
		}

		// Token: 0x17003EDC RID: 16092
		// (get) Token: 0x0602066D RID: 132717 RVA: 0x009456AD File Offset: 0x009438AD
		// (set) Token: 0x0602066E RID: 132718 RVA: 0x009456C1 File Offset: 0x009438C1
		public unsafe UDataTable 技能表_用于加载_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_技能表_用于加载_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_技能表_用于加载_, value);
			}
		}

		// Token: 0x17003EDD RID: 16093
		// (get) Token: 0x0602066F RID: 132719 RVA: 0x009456D6 File Offset: 0x009438D6
		// (set) Token: 0x06020670 RID: 132720 RVA: 0x009456E6 File Offset: 0x009438E6
		public unsafe float 虚化碰撞NPC半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_虚化碰撞NPC半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_虚化碰撞NPC半径) = value;
			}
		}

		// Token: 0x17003EDE RID: 16094
		// (get) Token: 0x06020671 RID: 132721 RVA: 0x009456F7 File Offset: 0x009438F7
		// (set) Token: 0x06020672 RID: 132722 RVA: 0x0094570B File Offset: 0x0094390B
		public unsafe UCurveFloat 深度虚化值曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_深度虚化值曲线);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_深度虚化值曲线, value);
			}
		}

		// Token: 0x06020673 RID: 132723 RVA: 0x00945720 File Offset: 0x00943920
		[SkipLocalsInit]
		public virtual void 解锁最高速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__解锁最高速度_NativeFunctionPtr, null);
		}

		// Token: 0x06020674 RID: 132724 RVA: 0x00945734 File Offset: 0x00943934
		[SkipLocalsInit]
		public virtual void 打开关闭Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__打开关闭Debug_NativeFunctionPtr, null);
		}

		// Token: 0x06020675 RID: 132725 RVA: 0x00945748 File Offset: 0x00943948
		[SkipLocalsInit]
		public virtual void 解锁二段跳_蓄力跳_新退场技()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__解锁二段跳_蓄力跳_新退场技_NativeFunctionPtr, null);
		}

		// Token: 0x06020676 RID: 132726 RVA: 0x0094575C File Offset: 0x0094395C
		[SkipLocalsInit]
		public virtual void 刷新配置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__刷新配置_NativeFunctionPtr, null);
		}

		// Token: 0x06020677 RID: 132727 RVA: 0x00945770 File Offset: 0x00943970
		[SkipLocalsInit]
		public unsafe virtual void GetConfigDataNameTagMap(ref TMap<FName, FGameplayTag> Result)
		{
			BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataNameTagMap_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataNameTagMap_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataNameTagMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FGameplayTag> tmap = Result;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->Result);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FGameplayTag> tmap2 = Result;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->Result);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020678 RID: 132728 RVA: 0x009457EC File Offset: 0x009439EC
		[SkipLocalsInit]
		public unsafe virtual void GetConfigDataByKeyName(FName Name, ref SMotorConfigs Result)
		{
			BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataByKeyName_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataByKeyName_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataByKeyName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Name = Name;
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorConfigs.StaticStruct(), &ptr->Result, Result.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr);
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorConfigs.StaticStruct(), Result.NativePtr, &ptr->Result, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Motor_BaseVehicle_MINI_BugFinder_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020679 RID: 132729 RVA: 0x00945890 File Offset: 0x00943A90
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602067A RID: 132730 RVA: 0x009458D8 File Offset: 0x00943AD8
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602067B RID: 132731 RVA: 0x0094591E File Offset: 0x00943B1E
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602067C RID: 132732 RVA: 0x00945932 File Offset: 0x00943B32
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602067D RID: 132733 RVA: 0x00945946 File Offset: 0x00943B46
		protected BP_Motor_BaseVehicle_MINI_BugFinder_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117F2 RID: 71666
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_MINI_BugFinder.BP_Motor_BaseVehicle_MINI_BugFinder_C";

		// Token: 0x040117F3 RID: 71667
		private static IntPtr _ClassPtr;

		// Token: 0x040117F4 RID: 71668
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117F5 RID: 71669
		internal static int __PropertyOffset_OtherCase5;

		// Token: 0x040117F6 RID: 71670
		internal static int __PropertyOffset_OtherCase4;

		// Token: 0x040117F7 RID: 71671
		internal static int __PropertyOffset_SphereForInteraction2;

		// Token: 0x040117F8 RID: 71672
		internal static int __PropertyOffset_SphereForInteraction;

		// Token: 0x040117F9 RID: 71673
		internal static int __PropertyOffset_CapsuleForTriggerAndBlock;

		// Token: 0x040117FA RID: 71674
		internal static int __PropertyOffset_CapsuleForDither;

		// Token: 0x040117FB RID: 71675
		internal static int __PropertyOffset_OtherCase3;

		// Token: 0x040117FC RID: 71676
		internal static int __PropertyOffset_OtherCase2;

		// Token: 0x040117FD RID: 71677
		internal static int __PropertyOffset_OtherCase1;

		// Token: 0x040117FE RID: 71678
		internal static int __PropertyOffset_CapsuleForPhotograph;

		// Token: 0x040117FF RID: 71679
		internal static int __PropertyOffset_技能表_用于加载_;

		// Token: 0x04011800 RID: 71680
		internal static int __PropertyOffset_虚化碰撞NPC半径;

		// Token: 0x04011801 RID: 71681
		internal static int __PropertyOffset_深度虚化值曲线;

		// Token: 0x04011802 RID: 71682
		private static IntPtr __解锁最高速度_NativeFunctionPtr;

		// Token: 0x04011803 RID: 71683
		private static IntPtr __打开关闭Debug_NativeFunctionPtr;

		// Token: 0x04011804 RID: 71684
		private static IntPtr __解锁二段跳_蓄力跳_新退场技_NativeFunctionPtr;

		// Token: 0x04011805 RID: 71685
		private static IntPtr __刷新配置_NativeFunctionPtr;

		// Token: 0x04011806 RID: 71686
		private static IntPtr __GetConfigDataNameTagMap_NativeFunctionPtr;

		// Token: 0x04011807 RID: 71687
		private static IntPtr __GetConfigDataByKeyName_NativeFunctionPtr;

		// Token: 0x04011808 RID: 71688
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04011809 RID: 71689
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008F5D RID: 36701
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetConfigDataNameTagMap_FunctionParams
		{
			// Token: 0x0402CCD2 RID: 183506
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x02008F5E RID: 36702
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetConfigDataByKeyName_FunctionParams
		{
			// Token: 0x0402CCD3 RID: 183507
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x0402CCD4 RID: 183508
			[FieldOffset(16)]
			public byte Result;
		}

		// Token: 0x02008F5F RID: 36703
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CCD5 RID: 183509
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
