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
	// Token: 0x02004038 RID: 16440
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Photo.BP_Motor_BaseVehicle_Photo_C")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public class BP_Motor_BaseVehicle_Photo_C : BP_BaseVehicle_C, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602A326 RID: 172838 RVA: 0x009D8DAD File Offset: 0x009D6FAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_Motor_BaseVehicle_Photo_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Photo.BP_Motor_BaseVehicle_Photo_C");
			}
			return BP_Motor_BaseVehicle_Photo_C._ClassPtr;
		}

		// Token: 0x0602A327 RID: 172839 RVA: 0x009D8DD4 File Offset: 0x009D6FD4
		public BP_Motor_BaseVehicle_Photo_C() : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Photo_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602A328 RID: 172840 RVA: 0x009D8DFC File Offset: 0x009D6FFC
		[NullableContext(1)]
		public BP_Motor_BaseVehicle_Photo_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_Motor_BaseVehicle_Photo_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700672A RID: 26410
		// (get) Token: 0x0602A329 RID: 172841 RVA: 0x009D8E2F File Offset: 0x009D702F
		// (set) Token: 0x0602A32A RID: 172842 RVA: 0x009D8E43 File Offset: 0x009D7043
		public unsafe USkeletalMeshComponent OtherCase5
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700672B RID: 26411
		// (get) Token: 0x0602A32B RID: 172843 RVA: 0x009D8E58 File Offset: 0x009D7058
		// (set) Token: 0x0602A32C RID: 172844 RVA: 0x009D8E6C File Offset: 0x009D706C
		public unsafe USkeletalMeshComponent OtherCase4
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700672C RID: 26412
		// (get) Token: 0x0602A32D RID: 172845 RVA: 0x009D8E81 File Offset: 0x009D7081
		// (set) Token: 0x0602A32E RID: 172846 RVA: 0x009D8E95 File Offset: 0x009D7095
		public unsafe USphereComponent SphereForInteraction2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_3);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_3, value);
			}
		}

		// Token: 0x1700672D RID: 26413
		// (get) Token: 0x0602A32F RID: 172847 RVA: 0x009D8EAA File Offset: 0x009D70AA
		// (set) Token: 0x0602A330 RID: 172848 RVA: 0x009D8EBE File Offset: 0x009D70BE
		public unsafe USphereComponent SphereForInteraction
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_4);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_4, value);
			}
		}

		// Token: 0x1700672E RID: 26414
		// (get) Token: 0x0602A331 RID: 172849 RVA: 0x009D8ED3 File Offset: 0x009D70D3
		// (set) Token: 0x0602A332 RID: 172850 RVA: 0x009D8EE7 File Offset: 0x009D70E7
		public unsafe UCapsuleComponent CapsuleForTriggerAndBlockOtherVehicle
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_5);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_5, value);
			}
		}

		// Token: 0x1700672F RID: 26415
		// (get) Token: 0x0602A333 RID: 172851 RVA: 0x009D8EFC File Offset: 0x009D70FC
		// (set) Token: 0x0602A334 RID: 172852 RVA: 0x009D8F10 File Offset: 0x009D7110
		public unsafe UCapsuleComponent CapsuleForDither
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_6);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_6, value);
			}
		}

		// Token: 0x17006730 RID: 26416
		// (get) Token: 0x0602A335 RID: 172853 RVA: 0x009D8F25 File Offset: 0x009D7125
		// (set) Token: 0x0602A336 RID: 172854 RVA: 0x009D8F39 File Offset: 0x009D7139
		public unsafe USkeletalMeshComponent OtherCase3
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_7);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_7, value);
			}
		}

		// Token: 0x17006731 RID: 26417
		// (get) Token: 0x0602A337 RID: 172855 RVA: 0x009D8F4E File Offset: 0x009D714E
		// (set) Token: 0x0602A338 RID: 172856 RVA: 0x009D8F62 File Offset: 0x009D7162
		public unsafe USkeletalMeshComponent OtherCase2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_8);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_8, value);
			}
		}

		// Token: 0x17006732 RID: 26418
		// (get) Token: 0x0602A339 RID: 172857 RVA: 0x009D8F77 File Offset: 0x009D7177
		// (set) Token: 0x0602A33A RID: 172858 RVA: 0x009D8F8B File Offset: 0x009D718B
		public unsafe USkeletalMeshComponent OtherCase1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_9);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_9, value);
			}
		}

		// Token: 0x17006733 RID: 26419
		// (get) Token: 0x0602A33B RID: 172859 RVA: 0x009D8FA0 File Offset: 0x009D71A0
		// (set) Token: 0x0602A33C RID: 172860 RVA: 0x009D8FB4 File Offset: 0x009D71B4
		public unsafe UCapsuleComponent CapsuleForPhotograph
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_10);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_10, value);
			}
		}

		// Token: 0x17006734 RID: 26420
		// (get) Token: 0x0602A33D RID: 172861 RVA: 0x009D8FC9 File Offset: 0x009D71C9
		// (set) Token: 0x0602A33E RID: 172862 RVA: 0x009D8FDD File Offset: 0x009D71DD
		public unsafe UDataTable 技能表_用于加载_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataTable>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_11);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_11, value);
			}
		}

		// Token: 0x17006735 RID: 26421
		// (get) Token: 0x0602A33F RID: 172863 RVA: 0x009D8FF2 File Offset: 0x009D71F2
		// (set) Token: 0x0602A340 RID: 172864 RVA: 0x009D9002 File Offset: 0x009D7202
		public unsafe float 虚化碰撞NPC半径
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x17006736 RID: 26422
		// (get) Token: 0x0602A341 RID: 172865 RVA: 0x009D9013 File Offset: 0x009D7213
		// (set) Token: 0x0602A342 RID: 172866 RVA: 0x009D9027 File Offset: 0x009D7227
		public unsafe UCurveFloat 深度虚化值曲线
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_13);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_Motor_BaseVehicle_Photo_C.__PropertyOffset_13, value);
			}
		}

		// Token: 0x0602A343 RID: 172867 RVA: 0x009D903C File Offset: 0x009D723C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public virtual void 刷新配置()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__刷新配置_NativeFunctionPtr, null);
		}

		// Token: 0x0602A344 RID: 172868 RVA: 0x009D9050 File Offset: 0x009D7250
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A345 RID: 172869 RVA: 0x009D90CC File Offset: 0x009D72CC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x0602A346 RID: 172870 RVA: 0x009D916E File Offset: 0x009D736E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void ReceiveBeginPlay()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__ReceiveBeginPlay_NativeFunctionPtr, null);
		}

		// Token: 0x0602A347 RID: 172871 RVA: 0x009D9182 File Offset: 0x009D7382
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void ReceiveBeginPlay_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__ReceiveBeginPlay_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602A348 RID: 172872 RVA: 0x009D9198 File Offset: 0x009D7398
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe override void ReceiveTick(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0602A349 RID: 172873 RVA: 0x009D91E0 File Offset: 0x009D73E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected unsafe virtual void ReceiveTick_Implementation(float DeltaSeconds)
		{
			BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams* ptr = stackalloc BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_Motor_BaseVehicle_Photo_C.__ReceiveTick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602A34A RID: 172874 RVA: 0x009D9227 File Offset: 0x009D7427
		protected BP_Motor_BaseVehicle_Photo_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C0E RID: 89102
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/Vehicle/Motor/BP_Motor_BaseVehicle_Photo.BP_Motor_BaseVehicle_Photo_C";

		// Token: 0x04015C0F RID: 89103
		private static IntPtr _ClassPtr;

		// Token: 0x04015C10 RID: 89104
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C11 RID: 89105
		internal static int __PropertyOffset_1;

		// Token: 0x04015C12 RID: 89106
		internal static int __PropertyOffset_2;

		// Token: 0x04015C13 RID: 89107
		internal static int __PropertyOffset_3;

		// Token: 0x04015C14 RID: 89108
		internal static int __PropertyOffset_4;

		// Token: 0x04015C15 RID: 89109
		internal static int __PropertyOffset_5;

		// Token: 0x04015C16 RID: 89110
		internal static int __PropertyOffset_6;

		// Token: 0x04015C17 RID: 89111
		internal static int __PropertyOffset_7;

		// Token: 0x04015C18 RID: 89112
		internal static int __PropertyOffset_8;

		// Token: 0x04015C19 RID: 89113
		internal static int __PropertyOffset_9;

		// Token: 0x04015C1A RID: 89114
		internal static int __PropertyOffset_10;

		// Token: 0x04015C1B RID: 89115
		internal static int __PropertyOffset_11;

		// Token: 0x04015C1C RID: 89116
		internal static int __PropertyOffset_12;

		// Token: 0x04015C1D RID: 89117
		internal static int __PropertyOffset_13;

		// Token: 0x04015C1E RID: 89118
		private static IntPtr __刷新配置_NativeFunctionPtr;

		// Token: 0x04015C1F RID: 89119
		private static IntPtr __GetConfigDataNameTagMap_NativeFunctionPtr;

		// Token: 0x04015C20 RID: 89120
		private static IntPtr __GetConfigDataByKeyName_NativeFunctionPtr;

		// Token: 0x04015C21 RID: 89121
		private static IntPtr __ReceiveBeginPlay_NativeFunctionPtr;

		// Token: 0x04015C22 RID: 89122
		private static IntPtr __ReceiveTick_NativeFunctionPtr;

		// Token: 0x0200A34B RID: 41803
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __GetConfigDataNameTagMap_FunctionParams
		{
			// Token: 0x04032111 RID: 205073
			[FieldOffset(0)]
			public byte Result;
		}

		// Token: 0x0200A34C RID: 41804
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 152)]
		protected ref struct __GetConfigDataByKeyName_FunctionParams
		{
			// Token: 0x04032112 RID: 205074
			[FieldOffset(0)]
			public FName Name;

			// Token: 0x04032113 RID: 205075
			[FieldOffset(16)]
			public byte Result;
		}

		// Token: 0x0200A34D RID: 41805
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected new ref struct __ReceiveTick_FunctionParams
		{
			// Token: 0x04032114 RID: 205076
			[FieldOffset(0)]
			public float DeltaSeconds;
		}
	}
}
