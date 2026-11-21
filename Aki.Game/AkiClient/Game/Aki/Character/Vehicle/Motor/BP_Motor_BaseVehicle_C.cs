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
	// Token: 0x0200328C RID: 12940
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle.BP_Motor_BaseVehicle_C")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2273)]
	public class BP_Motor_BaseVehicle_C : BP_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602062B RID: 132651 RVA: 0x00944F9F File Offset: 0x0094319F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle.BP_Motor_BaseVehicle_C");
			}
			return BP_Motor_BaseVehicle_C._ClassPtr;
		}

		// Token: 0x0602062C RID: 132652 RVA: 0x00944FC4 File Offset: 0x009431C4
		public BP_Motor_BaseVehicle_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602062D RID: 132653 RVA: 0x00944FEC File Offset: 0x009431EC
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003EC4 RID: 16068
		// (get) Token: 0x0602062E RID: 132654 RVA: 0x0094501F File Offset: 0x0094321F
		// (set) Token: 0x0602062F RID: 132655 RVA: 0x00945033 File Offset: 0x00943233
		public unsafe USkeletalMeshComponent OtherCase5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase5, value);
			}
		}

		// Token: 0x17003EC5 RID: 16069
		// (get) Token: 0x06020630 RID: 132656 RVA: 0x00945048 File Offset: 0x00943248
		// (set) Token: 0x06020631 RID: 132657 RVA: 0x0094505C File Offset: 0x0094325C
		public unsafe USkeletalMeshComponent OtherCase4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase4, value);
			}
		}

		// Token: 0x17003EC6 RID: 16070
		// (get) Token: 0x06020632 RID: 132658 RVA: 0x00945071 File Offset: 0x00943271
		// (set) Token: 0x06020633 RID: 132659 RVA: 0x00945085 File Offset: 0x00943285
		public unsafe USphereComponent SphereForInteraction2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_SphereForInteraction2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_SphereForInteraction2, value);
			}
		}

		// Token: 0x17003EC7 RID: 16071
		// (get) Token: 0x06020634 RID: 132660 RVA: 0x0094509A File Offset: 0x0094329A
		// (set) Token: 0x06020635 RID: 132661 RVA: 0x009450AE File Offset: 0x009432AE
		public unsafe USphereComponent SphereForInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_SphereForInteraction);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_SphereForInteraction, value);
			}
		}

		// Token: 0x17003EC8 RID: 16072
		// (get) Token: 0x06020636 RID: 132662 RVA: 0x009450C3 File Offset: 0x009432C3
		// (set) Token: 0x06020637 RID: 132663 RVA: 0x009450D7 File Offset: 0x009432D7
		public unsafe UCapsuleComponent CapsuleForTriggerAndBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_CapsuleForTriggerAndBlock);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_CapsuleForTriggerAndBlock, value);
			}
		}

		// Token: 0x17003EC9 RID: 16073
		// (get) Token: 0x06020638 RID: 132664 RVA: 0x009450EC File Offset: 0x009432EC
		// (set) Token: 0x06020639 RID: 132665 RVA: 0x00945100 File Offset: 0x00943300
		public unsafe UCapsuleComponent CapsuleForDither
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_CapsuleForDither);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_CapsuleForDither, value);
			}
		}

		// Token: 0x17003ECA RID: 16074
		// (get) Token: 0x0602063A RID: 132666 RVA: 0x00945115 File Offset: 0x00943315
		// (set) Token: 0x0602063B RID: 132667 RVA: 0x00945129 File Offset: 0x00943329
		public unsafe USkeletalMeshComponent OtherCase3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase3, value);
			}
		}

		// Token: 0x17003ECB RID: 16075
		// (get) Token: 0x0602063C RID: 132668 RVA: 0x0094513E File Offset: 0x0094333E
		// (set) Token: 0x0602063D RID: 132669 RVA: 0x00945152 File Offset: 0x00943352
		public unsafe USkeletalMeshComponent OtherCase2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase2, value);
			}
		}

		// Token: 0x17003ECC RID: 16076
		// (get) Token: 0x0602063E RID: 132670 RVA: 0x00945167 File Offset: 0x00943367
		// (set) Token: 0x0602063F RID: 132671 RVA: 0x0094517B File Offset: 0x0094337B
		public unsafe USkeletalMeshComponent OtherCase1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_OtherCase1, value);
			}
		}

		// Token: 0x17003ECD RID: 16077
		// (get) Token: 0x06020640 RID: 132672 RVA: 0x00945190 File Offset: 0x00943390
		// (set) Token: 0x06020641 RID: 132673 RVA: 0x009451A4 File Offset: 0x009433A4
		public unsafe UCapsuleComponent CapsuleForPhotograph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_CapsuleForPhotograph);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_CapsuleForPhotograph, value);
			}
		}

		// Token: 0x17003ECE RID: 16078
		// (get) Token: 0x06020642 RID: 132674 RVA: 0x009451B9 File Offset: 0x009433B9
		// (set) Token: 0x06020643 RID: 132675 RVA: 0x009451CD File Offset: 0x009433CD
		public unsafe UDataTable 技能表_用于加载_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_技能表_用于加载_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_技能表_用于加载_, value);
			}
		}

		// Token: 0x17003ECF RID: 16079
		// (get) Token: 0x06020644 RID: 132676 RVA: 0x009451E2 File Offset: 0x009433E2
		// (set) Token: 0x06020645 RID: 132677 RVA: 0x009451F2 File Offset: 0x009433F2
		public unsafe float 虚化碰撞NPC半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_C.__PropertyOffset_虚化碰撞NPC半径);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_C.__PropertyOffset_虚化碰撞NPC半径) = value;
			}
		}

		// Token: 0x17003ED0 RID: 16080
		// (get) Token: 0x06020646 RID: 132678 RVA: 0x00945203 File Offset: 0x00943403
		// (set) Token: 0x06020647 RID: 132679 RVA: 0x00945217 File Offset: 0x00943417
		public unsafe UCurveFloat 深度虚化值曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_深度虚化值曲线);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_深度虚化值曲线, value);
			}
		}

		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x06020648 RID: 132680 RVA: 0x0094522C File Offset: 0x0094342C
		// (set) Token: 0x06020649 RID: 132681 RVA: 0x0094523C File Offset: 0x0094343C
		public unsafe bool NewVar_0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_C.__PropertyOffset_NewVar_0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_C.__PropertyOffset_NewVar_0) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602064A RID: 132682 RVA: 0x0094524D File Offset: 0x0094344D
		[SkipLocalsInit]
		public virtual void 测试增删配置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__测试增删配置_NativeFunctionPtr, null);
		}

		// Token: 0x0602064B RID: 132683 RVA: 0x00945261 File Offset: 0x00943461
		[SkipLocalsInit]
		public virtual void 解锁最高速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__解锁最高速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602064C RID: 132684 RVA: 0x00945275 File Offset: 0x00943475
		[SkipLocalsInit]
		public virtual void 打开关闭Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__打开关闭Debug_NativeFunctionPtr, null);
		}

		// Token: 0x0602064D RID: 132685 RVA: 0x00945289 File Offset: 0x00943489
		[SkipLocalsInit]
		public virtual void 解锁二段跳_蓄力跳_新退场技()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__解锁二段跳_蓄力跳_新退场技_NativeFunctionPtr, null);
		}

		// Token: 0x0602064E RID: 132686 RVA: 0x0094529D File Offset: 0x0094349D
		[SkipLocalsInit]
		public virtual void 刷新配置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__刷新配置_NativeFunctionPtr, null);
		}

		// Token: 0x0602064F RID: 132687 RVA: 0x009452B4 File Offset: 0x009434B4
		[SkipLocalsInit]
		public unsafe virtual void GetConfigDataNameTagMap(ref TMap<FName, FGameplayTag> Result)
		{
			BP_Motor_BaseVehicle_C.__GetConfigDataNameTagMap_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_C.__GetConfigDataNameTagMap_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_Motor_BaseVehicle_C.__GetConfigDataNameTagMap_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr, 1);
			TMap<FName, FGameplayTag> tmap = Result;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->Result);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr);
			TMap<FName, FGameplayTag> tmap2 = Result;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->Result);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Motor_BaseVehicle_C.__GetConfigDataNameTagMap_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020650 RID: 132688 RVA: 0x00945330 File Offset: 0x00943530
		[SkipLocalsInit]
		public unsafe virtual void GetConfigDataByKeyName(FName Name, ref SMotorConfigs Result)
		{
			BP_Motor_BaseVehicle_C.__GetConfigDataByKeyName_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_C.__GetConfigDataByKeyName_FunctionParams[(UIntPtr)167] + 15L / (long)sizeof(BP_Motor_BaseVehicle_C.__GetConfigDataByKeyName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Name = Name;
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorConfigs.StaticStruct(), &ptr->Result, Result.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr);
			if (Result != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SMotorConfigs.StaticStruct(), Result.NativePtr, &ptr->Result, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BP_Motor_BaseVehicle_C.__GetConfigDataByKeyName_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06020651 RID: 132689 RVA: 0x009453D4 File Offset: 0x009435D4
		[SkipLocalsInit]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020652 RID: 132690 RVA: 0x0094541C File Offset: 0x0094361C
		[SkipLocalsInit]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06020653 RID: 132691 RVA: 0x00945462 File Offset: 0x00943662
		[SkipLocalsInit]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020654 RID: 132692 RVA: 0x00945476 File Offset: 0x00943676
		[SkipLocalsInit]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x06020655 RID: 132693 RVA: 0x0094548A File Offset: 0x0094368A
		protected BP_Motor_BaseVehicle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117D8 RID: 71640
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle.BP_Motor_BaseVehicle_C";

		// Token: 0x040117D9 RID: 71641
		private static IntPtr _ClassPtr;

		// Token: 0x040117DA RID: 71642
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117DB RID: 71643
		internal static int __PropertyOffset_OtherCase5;

		// Token: 0x040117DC RID: 71644
		internal static int __PropertyOffset_OtherCase4;

		// Token: 0x040117DD RID: 71645
		internal static int __PropertyOffset_SphereForInteraction2;

		// Token: 0x040117DE RID: 71646
		internal static int __PropertyOffset_SphereForInteraction;

		// Token: 0x040117DF RID: 71647
		internal static int __PropertyOffset_CapsuleForTriggerAndBlock;

		// Token: 0x040117E0 RID: 71648
		internal static int __PropertyOffset_CapsuleForDither;

		// Token: 0x040117E1 RID: 71649
		internal static int __PropertyOffset_OtherCase3;

		// Token: 0x040117E2 RID: 71650
		internal static int __PropertyOffset_OtherCase2;

		// Token: 0x040117E3 RID: 71651
		internal static int __PropertyOffset_OtherCase1;

		// Token: 0x040117E4 RID: 71652
		internal static int __PropertyOffset_CapsuleForPhotograph;

		// Token: 0x040117E5 RID: 71653
		internal static int __PropertyOffset_技能表_用于加载_;

		// Token: 0x040117E6 RID: 71654
		internal static int __PropertyOffset_虚化碰撞NPC半径;

		// Token: 0x040117E7 RID: 71655
		internal static int __PropertyOffset_深度虚化值曲线;

		// Token: 0x040117E8 RID: 71656
		internal static int __PropertyOffset_NewVar_0;

		// Token: 0x040117E9 RID: 71657
		private static IntPtr __测试增删配置_NativeFunctionPtr;

		// Token: 0x040117EA RID: 71658
		private static IntPtr __解锁最高速度_NativeFunctionPtr;

		// Token: 0x040117EB RID: 71659
		private static IntPtr __打开关闭Debug_NativeFunctionPtr;

		// Token: 0x040117EC RID: 71660
		private static IntPtr __解锁二段跳_蓄力跳_新退场技_NativeFunctionPtr;

		// Token: 0x040117ED RID: 71661
		private static IntPtr __刷新配置_NativeFunctionPtr;

		// Token: 0x040117EE RID: 71662
		private static IntPtr __GetConfigDataNameTagMap_NativeFunctionPtr;

		// Token: 0x040117EF RID: 71663
		private static IntPtr __GetConfigDataByKeyName_NativeFunctionPtr;

		// Token: 0x040117F0 RID: 71664
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x040117F1 RID: 71665
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x02008F5A RID: 36698
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetConfigDataNameTagMap_FunctionParams
		{
			// Token: 0x0402CCCE RID: 183502
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x02008F5B RID: 36699
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetConfigDataByKeyName_FunctionParams
		{
			// Token: 0x0402CCCF RID: 183503
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x0402CCD0 RID: 183504
			[FieldOffset(16)]
			public byte Result;
		}

		// Token: 0x02008F5C RID: 36700
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0402CCD1 RID: 183505
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
