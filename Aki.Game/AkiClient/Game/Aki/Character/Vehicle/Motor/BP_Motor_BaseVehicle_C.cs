using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Data;
using AkiClient.Game.Aki.Render.RuntimeBP.SnowCoverInteraction.BluePrints;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.Vehicle.Motor
{
	// Token: 0x02004034 RID: 16436
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle.BP_Motor_BaseVehicle_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_Motor_BaseVehicle_C : BP_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A2C2 RID: 172738 RVA: 0x009D8224 File Offset: 0x009D6424
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle.BP_Motor_BaseVehicle_C");
			}
			return BP_Motor_BaseVehicle_C._ClassPtr;
		}

		// Token: 0x0602A2C3 RID: 172739 RVA: 0x009D8248 File Offset: 0x009D6448
		public BP_Motor_BaseVehicle_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A2C4 RID: 172740 RVA: 0x009D8270 File Offset: 0x009D6470
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700670A RID: 26378
		// (get) Token: 0x0602A2C5 RID: 172741 RVA: 0x009D82A3 File Offset: 0x009D64A3
		// (set) Token: 0x0602A2C6 RID: 172742 RVA: 0x009D82B7 File Offset: 0x009D64B7
		public unsafe BP_MotorObjTrailActor_C BP_MotorObjTrailActor2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_MotorObjTrailActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700670B RID: 26379
		// (get) Token: 0x0602A2C7 RID: 172743 RVA: 0x009D82CC File Offset: 0x009D64CC
		// (set) Token: 0x0602A2C8 RID: 172744 RVA: 0x009D82E0 File Offset: 0x009D64E0
		public unsafe BP_MotorObjTrailActor_C BP_MotorObjTrailActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_MotorObjTrailActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700670C RID: 26380
		// (get) Token: 0x0602A2C9 RID: 172745 RVA: 0x009D82F5 File Offset: 0x009D64F5
		// (set) Token: 0x0602A2CA RID: 172746 RVA: 0x009D8309 File Offset: 0x009D6509
		public unsafe USkeletalMeshComponent OtherCase5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700670D RID: 26381
		// (get) Token: 0x0602A2CB RID: 172747 RVA: 0x009D831E File Offset: 0x009D651E
		// (set) Token: 0x0602A2CC RID: 172748 RVA: 0x009D8332 File Offset: 0x009D6532
		public unsafe USkeletalMeshComponent OtherCase4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700670E RID: 26382
		// (get) Token: 0x0602A2CD RID: 172749 RVA: 0x009D8347 File Offset: 0x009D6547
		// (set) Token: 0x0602A2CE RID: 172750 RVA: 0x009D835B File Offset: 0x009D655B
		public unsafe USphereComponent SphereForInteraction2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700670F RID: 26383
		// (get) Token: 0x0602A2CF RID: 172751 RVA: 0x009D8370 File Offset: 0x009D6570
		// (set) Token: 0x0602A2D0 RID: 172752 RVA: 0x009D8384 File Offset: 0x009D6584
		public unsafe USphereComponent SphereForInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17006710 RID: 26384
		// (get) Token: 0x0602A2D1 RID: 172753 RVA: 0x009D8399 File Offset: 0x009D6599
		// (set) Token: 0x0602A2D2 RID: 172754 RVA: 0x009D83AD File Offset: 0x009D65AD
		public unsafe UCapsuleComponent CapsuleForTriggerAndBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17006711 RID: 26385
		// (get) Token: 0x0602A2D3 RID: 172755 RVA: 0x009D83C2 File Offset: 0x009D65C2
		// (set) Token: 0x0602A2D4 RID: 172756 RVA: 0x009D83D6 File Offset: 0x009D65D6
		public unsafe UCapsuleComponent CapsuleForDither
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006712 RID: 26386
		// (get) Token: 0x0602A2D5 RID: 172757 RVA: 0x009D83EB File Offset: 0x009D65EB
		// (set) Token: 0x0602A2D6 RID: 172758 RVA: 0x009D83FF File Offset: 0x009D65FF
		public unsafe USkeletalMeshComponent OtherCase3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17006713 RID: 26387
		// (get) Token: 0x0602A2D7 RID: 172759 RVA: 0x009D8414 File Offset: 0x009D6614
		// (set) Token: 0x0602A2D8 RID: 172760 RVA: 0x009D8428 File Offset: 0x009D6628
		public unsafe USkeletalMeshComponent OtherCase2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17006714 RID: 26388
		// (get) Token: 0x0602A2D9 RID: 172761 RVA: 0x009D843D File Offset: 0x009D663D
		// (set) Token: 0x0602A2DA RID: 172762 RVA: 0x009D8451 File Offset: 0x009D6651
		public unsafe USkeletalMeshComponent OtherCase1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006715 RID: 26389
		// (get) Token: 0x0602A2DB RID: 172763 RVA: 0x009D8466 File Offset: 0x009D6666
		// (set) Token: 0x0602A2DC RID: 172764 RVA: 0x009D847A File Offset: 0x009D667A
		public unsafe UCapsuleComponent CapsuleForPhotograph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17006716 RID: 26390
		// (get) Token: 0x0602A2DD RID: 172765 RVA: 0x009D848F File Offset: 0x009D668F
		// (set) Token: 0x0602A2DE RID: 172766 RVA: 0x009D84A3 File Offset: 0x009D66A3
		public unsafe UDataTable 技能表_用于加载_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006717 RID: 26391
		// (get) Token: 0x0602A2DF RID: 172767 RVA: 0x009D84B8 File Offset: 0x009D66B8
		// (set) Token: 0x0602A2E0 RID: 172768 RVA: 0x009D84C8 File Offset: 0x009D66C8
		public unsafe float 虚化碰撞NPC半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006718 RID: 26392
		// (get) Token: 0x0602A2E1 RID: 172769 RVA: 0x009D84D9 File Offset: 0x009D66D9
		// (set) Token: 0x0602A2E2 RID: 172770 RVA: 0x009D84ED File Offset: 0x009D66ED
		public unsafe UCurveFloat 深度虚化值曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x0602A2E3 RID: 172771 RVA: 0x009D8502 File Offset: 0x009D6702
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 解锁最高速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__解锁最高速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2E4 RID: 172772 RVA: 0x009D8516 File Offset: 0x009D6716
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 打开关闭Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__打开关闭Debug_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2E5 RID: 172773 RVA: 0x009D852A File Offset: 0x009D672A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 解锁二段跳_蓄力跳_新退场技()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__解锁二段跳_蓄力跳_新退场技_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2E6 RID: 172774 RVA: 0x009D853E File Offset: 0x009D673E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 刷新配置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__刷新配置_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2E7 RID: 172775 RVA: 0x009D8554 File Offset: 0x009D6754
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A2E8 RID: 172776 RVA: 0x009D85D0 File Offset: 0x009D67D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A2E9 RID: 172777 RVA: 0x009D8674 File Offset: 0x009D6874
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A2EA RID: 172778 RVA: 0x009D86BC File Offset: 0x009D68BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A2EB RID: 172779 RVA: 0x009D8703 File Offset: 0x009D6903
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602A2EC RID: 172780 RVA: 0x009D8717 File Offset: 0x009D6917
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A2ED RID: 172781 RVA: 0x009D872C File Offset: 0x009D692C
		protected BP_Motor_BaseVehicle_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BD2 RID: 89042
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle.BP_Motor_BaseVehicle_C";

		// Token: 0x04015BD3 RID: 89043
		private static IntPtr _ClassPtr;

		// Token: 0x04015BD4 RID: 89044
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BD5 RID: 89045
		internal static int __PropertyOffset_1;

		// Token: 0x04015BD6 RID: 89046
		internal static int __PropertyOffset_2;

		// Token: 0x04015BD7 RID: 89047
		internal static int __PropertyOffset_3;

		// Token: 0x04015BD8 RID: 89048
		internal static int __PropertyOffset_4;

		// Token: 0x04015BD9 RID: 89049
		internal static int __PropertyOffset_5;

		// Token: 0x04015BDA RID: 89050
		internal static int __PropertyOffset_6;

		// Token: 0x04015BDB RID: 89051
		internal static int __PropertyOffset_7;

		// Token: 0x04015BDC RID: 89052
		internal static int __PropertyOffset_8;

		// Token: 0x04015BDD RID: 89053
		internal static int __PropertyOffset_9;

		// Token: 0x04015BDE RID: 89054
		internal static int __PropertyOffset_10;

		// Token: 0x04015BDF RID: 89055
		internal static int __PropertyOffset_11;

		// Token: 0x04015BE0 RID: 89056
		internal static int __PropertyOffset_12;

		// Token: 0x04015BE1 RID: 89057
		internal static int __PropertyOffset_13;

		// Token: 0x04015BE2 RID: 89058
		internal static int __PropertyOffset_14;

		// Token: 0x04015BE3 RID: 89059
		internal static int __PropertyOffset_15;

		// Token: 0x04015BE4 RID: 89060
		private static IntPtr __解锁最高速度_NativeFunctionPtr;

		// Token: 0x04015BE5 RID: 89061
		private static IntPtr __打开关闭Debug_NativeFunctionPtr;

		// Token: 0x04015BE6 RID: 89062
		private static IntPtr __解锁二段跳_蓄力跳_新退场技_NativeFunctionPtr;

		// Token: 0x04015BE7 RID: 89063
		private static IntPtr __刷新配置_NativeFunctionPtr;

		// Token: 0x04015BE8 RID: 89064
		private static IntPtr __GetConfigDataNameTagMap_NativeFunctionPtr;

		// Token: 0x04015BE9 RID: 89065
		private static IntPtr __GetConfigDataByKeyName_NativeFunctionPtr;

		// Token: 0x04015BEA RID: 89066
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04015BEB RID: 89067
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A345 RID: 41797
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetConfigDataNameTagMap_FunctionParams
		{
			// Token: 0x04032109 RID: 205065
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x0200A346 RID: 41798
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetConfigDataByKeyName_FunctionParams
		{
			// Token: 0x0403210A RID: 205066
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x0403210B RID: 205067
			[FieldOffset(16)]
			public byte Result;
		}

		// Token: 0x0200A347 RID: 41799
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x0403210C RID: 205068
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
