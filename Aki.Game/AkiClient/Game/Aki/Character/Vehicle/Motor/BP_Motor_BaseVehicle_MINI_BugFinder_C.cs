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
	// Token: 0x02004037 RID: 16439
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_MINI_BugFinder.BP_Motor_BaseVehicle_MINI_BugFinder_C")]
	[UnrealStructLayout(2272, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class BP_Motor_BaseVehicle_MINI_BugFinder_C : BP_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A2FA RID: 172794 RVA: 0x009D889C File Offset: 0x009D6A9C
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_MINI_BugFinder_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_MINI_BugFinder.BP_Motor_BaseVehicle_MINI_BugFinder_C");
			}
			return BP_Motor_BaseVehicle_MINI_BugFinder_C._ClassPtr;
		}

		// Token: 0x0602A2FB RID: 172795 RVA: 0x009D88C0 File Offset: 0x009D6AC0
		public BP_Motor_BaseVehicle_MINI_BugFinder_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_MINI_BugFinder_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A2FC RID: 172796 RVA: 0x009D88E8 File Offset: 0x009D6AE8
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_MINI_BugFinder_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_MINI_BugFinder_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700671B RID: 26395
		// (get) Token: 0x0602A2FD RID: 172797 RVA: 0x009D891B File Offset: 0x009D6B1B
		// (set) Token: 0x0602A2FE RID: 172798 RVA: 0x009D892F File Offset: 0x009D6B2F
		public unsafe BP_MotorObjTrailActor_C BP_MotorObjTrailActor2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_MotorObjTrailActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700671C RID: 26396
		// (get) Token: 0x0602A2FF RID: 172799 RVA: 0x009D8944 File Offset: 0x009D6B44
		// (set) Token: 0x0602A300 RID: 172800 RVA: 0x009D8958 File Offset: 0x009D6B58
		public unsafe BP_MotorObjTrailActor_C BP_MotorObjTrailActor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<BP_MotorObjTrailActor_C>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700671D RID: 26397
		// (get) Token: 0x0602A301 RID: 172801 RVA: 0x009D896D File Offset: 0x009D6B6D
		// (set) Token: 0x0602A302 RID: 172802 RVA: 0x009D8981 File Offset: 0x009D6B81
		public unsafe USkeletalMeshComponent OtherCase5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700671E RID: 26398
		// (get) Token: 0x0602A303 RID: 172803 RVA: 0x009D8996 File Offset: 0x009D6B96
		// (set) Token: 0x0602A304 RID: 172804 RVA: 0x009D89AA File Offset: 0x009D6BAA
		public unsafe USkeletalMeshComponent OtherCase4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700671F RID: 26399
		// (get) Token: 0x0602A305 RID: 172805 RVA: 0x009D89BF File Offset: 0x009D6BBF
		// (set) Token: 0x0602A306 RID: 172806 RVA: 0x009D89D3 File Offset: 0x009D6BD3
		public unsafe USphereComponent SphereForInteraction2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x17006720 RID: 26400
		// (get) Token: 0x0602A307 RID: 172807 RVA: 0x009D89E8 File Offset: 0x009D6BE8
		// (set) Token: 0x0602A308 RID: 172808 RVA: 0x009D89FC File Offset: 0x009D6BFC
		public unsafe USphereComponent SphereForInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17006721 RID: 26401
		// (get) Token: 0x0602A309 RID: 172809 RVA: 0x009D8A11 File Offset: 0x009D6C11
		// (set) Token: 0x0602A30A RID: 172810 RVA: 0x009D8A25 File Offset: 0x009D6C25
		public unsafe UCapsuleComponent CapsuleForTriggerAndBlock
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17006722 RID: 26402
		// (get) Token: 0x0602A30B RID: 172811 RVA: 0x009D8A3A File Offset: 0x009D6C3A
		// (set) Token: 0x0602A30C RID: 172812 RVA: 0x009D8A4E File Offset: 0x009D6C4E
		public unsafe UCapsuleComponent CapsuleForDither
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006723 RID: 26403
		// (get) Token: 0x0602A30D RID: 172813 RVA: 0x009D8A63 File Offset: 0x009D6C63
		// (set) Token: 0x0602A30E RID: 172814 RVA: 0x009D8A77 File Offset: 0x009D6C77
		public unsafe USkeletalMeshComponent OtherCase3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17006724 RID: 26404
		// (get) Token: 0x0602A30F RID: 172815 RVA: 0x009D8A8C File Offset: 0x009D6C8C
		// (set) Token: 0x0602A310 RID: 172816 RVA: 0x009D8AA0 File Offset: 0x009D6CA0
		public unsafe USkeletalMeshComponent OtherCase2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17006725 RID: 26405
		// (get) Token: 0x0602A311 RID: 172817 RVA: 0x009D8AB5 File Offset: 0x009D6CB5
		// (set) Token: 0x0602A312 RID: 172818 RVA: 0x009D8AC9 File Offset: 0x009D6CC9
		public unsafe USkeletalMeshComponent OtherCase1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006726 RID: 26406
		// (get) Token: 0x0602A313 RID: 172819 RVA: 0x009D8ADE File Offset: 0x009D6CDE
		// (set) Token: 0x0602A314 RID: 172820 RVA: 0x009D8AF2 File Offset: 0x009D6CF2
		public unsafe UCapsuleComponent CapsuleForPhotograph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_12);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_12, value);
			}
		}

		// Token: 0x17006727 RID: 26407
		// (get) Token: 0x0602A315 RID: 172821 RVA: 0x009D8B07 File Offset: 0x009D6D07
		// (set) Token: 0x0602A316 RID: 172822 RVA: 0x009D8B1B File Offset: 0x009D6D1B
		public unsafe UDataTable 技能表_用于加载_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x17006728 RID: 26408
		// (get) Token: 0x0602A317 RID: 172823 RVA: 0x009D8B30 File Offset: 0x009D6D30
		// (set) Token: 0x0602A318 RID: 172824 RVA: 0x009D8B40 File Offset: 0x009D6D40
		public unsafe float 虚化碰撞NPC半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006729 RID: 26409
		// (get) Token: 0x0602A319 RID: 172825 RVA: 0x009D8B51 File Offset: 0x009D6D51
		// (set) Token: 0x0602A31A RID: 172826 RVA: 0x009D8B65 File Offset: 0x009D6D65
		public unsafe UCurveFloat 深度虚化值曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_15);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_MINI_BugFinder_C.__PropertyOffset_15, value);
			}
		}

		// Token: 0x0602A31B RID: 172827 RVA: 0x009D8B7A File Offset: 0x009D6D7A
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 解锁最高速度()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__解锁最高速度_NativeFunctionPtr, null);
		}

		// Token: 0x0602A31C RID: 172828 RVA: 0x009D8B8E File Offset: 0x009D6D8E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 打开关闭Debug()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__打开关闭Debug_NativeFunctionPtr, null);
		}

		// Token: 0x0602A31D RID: 172829 RVA: 0x009D8BA2 File Offset: 0x009D6DA2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 解锁二段跳_蓄力跳_新退场技()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__解锁二段跳_蓄力跳_新退场技_NativeFunctionPtr, null);
		}

		// Token: 0x0602A31E RID: 172830 RVA: 0x009D8BB6 File Offset: 0x009D6DB6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 刷新配置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__刷新配置_NativeFunctionPtr, null);
		}

		// Token: 0x0602A31F RID: 172831 RVA: 0x009D8BCC File Offset: 0x009D6DCC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A320 RID: 172832 RVA: 0x009D8C48 File Offset: 0x009D6E48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A321 RID: 172833 RVA: 0x009D8CEC File Offset: 0x009D6EEC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A322 RID: 172834 RVA: 0x009D8D34 File Offset: 0x009D6F34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A323 RID: 172835 RVA: 0x009D8D7B File Offset: 0x009D6F7B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602A324 RID: 172836 RVA: 0x009D8D8F File Offset: 0x009D6F8F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_MINI_BugFinder_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A325 RID: 172837 RVA: 0x009D8DA4 File Offset: 0x009D6FA4
		protected BP_Motor_BaseVehicle_MINI_BugFinder_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015BF4 RID: 89076
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_MINI_BugFinder.BP_Motor_BaseVehicle_MINI_BugFinder_C";

		// Token: 0x04015BF5 RID: 89077
		private static IntPtr _ClassPtr;

		// Token: 0x04015BF6 RID: 89078
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015BF7 RID: 89079
		internal static int __PropertyOffset_1;

		// Token: 0x04015BF8 RID: 89080
		internal static int __PropertyOffset_2;

		// Token: 0x04015BF9 RID: 89081
		internal static int __PropertyOffset_3;

		// Token: 0x04015BFA RID: 89082
		internal static int __PropertyOffset_4;

		// Token: 0x04015BFB RID: 89083
		internal static int __PropertyOffset_5;

		// Token: 0x04015BFC RID: 89084
		internal static int __PropertyOffset_6;

		// Token: 0x04015BFD RID: 89085
		internal static int __PropertyOffset_7;

		// Token: 0x04015BFE RID: 89086
		internal static int __PropertyOffset_8;

		// Token: 0x04015BFF RID: 89087
		internal static int __PropertyOffset_9;

		// Token: 0x04015C00 RID: 89088
		internal static int __PropertyOffset_10;

		// Token: 0x04015C01 RID: 89089
		internal static int __PropertyOffset_11;

		// Token: 0x04015C02 RID: 89090
		internal static int __PropertyOffset_12;

		// Token: 0x04015C03 RID: 89091
		internal static int __PropertyOffset_13;

		// Token: 0x04015C04 RID: 89092
		internal static int __PropertyOffset_14;

		// Token: 0x04015C05 RID: 89093
		internal static int __PropertyOffset_15;

		// Token: 0x04015C06 RID: 89094
		private static IntPtr __解锁最高速度_NativeFunctionPtr;

		// Token: 0x04015C07 RID: 89095
		private static IntPtr __打开关闭Debug_NativeFunctionPtr;

		// Token: 0x04015C08 RID: 89096
		private static IntPtr __解锁二段跳_蓄力跳_新退场技_NativeFunctionPtr;

		// Token: 0x04015C09 RID: 89097
		private static IntPtr __刷新配置_NativeFunctionPtr;

		// Token: 0x04015C0A RID: 89098
		private static IntPtr __GetConfigDataNameTagMap_NativeFunctionPtr;

		// Token: 0x04015C0B RID: 89099
		private static IntPtr __GetConfigDataByKeyName_NativeFunctionPtr;

		// Token: 0x04015C0C RID: 89100
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x04015C0D RID: 89101
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x0200A348 RID: 41800
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetConfigDataNameTagMap_FunctionParams
		{
			// Token: 0x0403210D RID: 205069
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x0200A349 RID: 41801
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetConfigDataByKeyName_FunctionParams
		{
			// Token: 0x0403210E RID: 205070
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x0403210F RID: 205071
			[FieldOffset(16)]
			public byte Result;
		}

		// Token: 0x0200A34A RID: 41802
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032110 RID: 205072
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
