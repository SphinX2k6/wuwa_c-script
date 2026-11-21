using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera
{
	// Token: 0x020031D2 RID: 12754
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraController.BP_ZoneFollowCameraController_C")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1140)]
	public class BP_ZoneFollowCameraController_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F9E8 RID: 129512 RVA: 0x00931AB7 File Offset: 0x0092FCB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ZoneFollowCameraController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraController.BP_ZoneFollowCameraController_C");
			}
			return BP_ZoneFollowCameraController_C._ClassPtr;
		}

		// Token: 0x0601F9E9 RID: 129513 RVA: 0x00931ADC File Offset: 0x0092FCDC
		public BP_ZoneFollowCameraController_C() : this(BuiltinUtils.AllocNativeUObject(BP_ZoneFollowCameraController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F9EA RID: 129514 RVA: 0x00931B04 File Offset: 0x0092FD04
		[NullableContext(1)]
		public BP_ZoneFollowCameraController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ZoneFollowCameraController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A71 RID: 14961
		// (get) Token: 0x0601F9EB RID: 129515 RVA: 0x00931B37 File Offset: 0x0092FD37
		// (set) Token: 0x0601F9EC RID: 129516 RVA: 0x00931B4B File Offset: 0x0092FD4B
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_Sphere);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_Sphere, value);
			}
		}

		// Token: 0x17003A72 RID: 14962
		// (get) Token: 0x0601F9ED RID: 129517 RVA: 0x00931B60 File Offset: 0x0092FD60
		// (set) Token: 0x0601F9EE RID: 129518 RVA: 0x00931B74 File Offset: 0x0092FD74
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_DefaultSceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_DefaultSceneRoot, value);
			}
		}

		// Token: 0x17003A73 RID: 14963
		// (get) Token: 0x0601F9EF RID: 129519 RVA: 0x00931B89 File Offset: 0x0092FD89
		// (set) Token: 0x0601F9F0 RID: 129520 RVA: 0x00931B9D File Offset: 0x0092FD9D
		public unsafe ACameraActor 预览相机
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_预览相机);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_预览相机, value);
			}
		}

		// Token: 0x17003A74 RID: 14964
		// (get) Token: 0x0601F9F1 RID: 129521 RVA: 0x00931BB2 File Offset: 0x0092FDB2
		// (set) Token: 0x0601F9F2 RID: 129522 RVA: 0x00931BC2 File Offset: 0x0092FDC2
		public unsafe float 过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_过渡速度);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_过渡速度) = value;
			}
		}

		// Token: 0x17003A75 RID: 14965
		// (get) Token: 0x0601F9F3 RID: 129523 RVA: 0x00931BD3 File Offset: 0x0092FDD3
		// (set) Token: 0x0601F9F4 RID: 129524 RVA: 0x00931BE7 File Offset: 0x0092FDE7
		public unsafe FVector TargetCameraPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_TargetCameraPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_TargetCameraPos) = value;
			}
		}

		// Token: 0x17003A76 RID: 14966
		// (get) Token: 0x0601F9F5 RID: 129525 RVA: 0x00931BFC File Offset: 0x0092FDFC
		// (set) Token: 0x0601F9F6 RID: 129526 RVA: 0x00931C10 File Offset: 0x0092FE10
		public unsafe FRotator TargetCameraRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_TargetCameraRot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_TargetCameraRot) = value;
			}
		}

		// Token: 0x17003A77 RID: 14967
		// (get) Token: 0x0601F9F7 RID: 129527 RVA: 0x00931C25 File Offset: 0x0092FE25
		// (set) Token: 0x0601F9F8 RID: 129528 RVA: 0x00931C35 File Offset: 0x0092FE35
		public unsafe bool IsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_IsActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_IsActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A78 RID: 14968
		// (get) Token: 0x0601F9F9 RID: 129529 RVA: 0x00931C46 File Offset: 0x0092FE46
		// (set) Token: 0x0601F9FA RID: 129530 RVA: 0x00931C56 File Offset: 0x0092FE56
		public unsafe float 默认相机FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_默认相机FOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_默认相机FOV) = value;
			}
		}

		// Token: 0x17003A79 RID: 14969
		// (get) Token: 0x0601F9FB RID: 129531 RVA: 0x00931C67 File Offset: 0x0092FE67
		// (set) Token: 0x0601F9FC RID: 129532 RVA: 0x00931C7B File Offset: 0x0092FE7B
		public unsafe FVector 默认相机偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_默认相机偏移);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_默认相机偏移) = value;
			}
		}

		// Token: 0x17003A7A RID: 14970
		// (get) Token: 0x0601F9FD RID: 129533 RVA: 0x00931C90 File Offset: 0x0092FE90
		// (set) Token: 0x0601F9FE RID: 129534 RVA: 0x00931CA4 File Offset: 0x0092FEA4
		public unsafe FRotator 默认相机旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_默认相机旋转);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_默认相机旋转) = value;
			}
		}

		// Token: 0x0601F9FF RID: 129535 RVA: 0x00931CBC File Offset: 0x0092FEBC
		[SkipLocalsInit]
		public unsafe virtual void PackageCameraConfig(ref SZoneFollowCameraSettings Configs)
		{
			BP_ZoneFollowCameraController_C.__PackageCameraConfig_FunctionParams* ptr = stackalloc BP_ZoneFollowCameraController_C.__PackageCameraConfig_FunctionParams[(UIntPtr)639] + 15L / (long)sizeof(BP_ZoneFollowCameraController_C.__PackageCameraConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ZoneFollowCameraController_C.__PackageCameraConfig_NativeFunctionPtr, (void*)ptr, 1);
			if (Configs != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SZoneFollowCameraSettings.StaticStruct(), &ptr->Configs, Configs.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ZoneFollowCameraController_C.__PackageCameraConfig_NativeFunctionPtr, (void*)ptr);
			if (Configs != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(SZoneFollowCameraSettings.StaticStruct(), Configs.NativePtr, &ptr->Configs, 1, false);
			}
			UnrealReflectionUtils.DestroyStruct(BP_ZoneFollowCameraController_C.__PackageCameraConfig_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FA00 RID: 129536 RVA: 0x00931D58 File Offset: 0x0092FF58
		[SkipLocalsInit]
		public unsafe virtual void ComputeTargetPosition(ref TArray<int> ZoneIndexs, FVector RoleWorldPos, ref FVector OutPosition, ref FRotator OutRotation)
		{
			BP_ZoneFollowCameraController_C.__ComputeTargetPosition_FunctionParams* ptr = stackalloc BP_ZoneFollowCameraController_C.__ComputeTargetPosition_FunctionParams[(UIntPtr)511] + 15L / (long)sizeof(BP_ZoneFollowCameraController_C.__ComputeTargetPosition_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ZoneFollowCameraController_C.__ComputeTargetPosition_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = ZoneIndexs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ZoneIndexs);
			}
			ptr->RoleWorldPos = RoleWorldPos;
			ptr->OutPosition = OutPosition;
			ptr->OutRotation = OutRotation;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ZoneFollowCameraController_C.__ComputeTargetPosition_NativeFunctionPtr, (void*)ptr);
			TArray<int> tarray2 = ZoneIndexs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ZoneIndexs);
			}
			OutPosition = ptr->OutPosition;
			OutRotation = ptr->OutRotation;
			UnrealReflectionUtils.DestroyStruct(BP_ZoneFollowCameraController_C.__ComputeTargetPosition_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FA01 RID: 129537 RVA: 0x00931E0C File Offset: 0x0093000C
		[SkipLocalsInit]
		public unsafe virtual void FindActiveZone(FVector WorldPos, ref TArray<int> ZoneIndexs, ref bool bFound)
		{
			BP_ZoneFollowCameraController_C.__FindActiveZone_FunctionParams* ptr = stackalloc BP_ZoneFollowCameraController_C.__FindActiveZone_FunctionParams[(UIntPtr)239] + 15L / (long)sizeof(BP_ZoneFollowCameraController_C.__FindActiveZone_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BP_ZoneFollowCameraController_C.__FindActiveZone_NativeFunctionPtr, (void*)ptr, 1);
			ptr->WorldPos = WorldPos;
			TArray<int> tarray = ZoneIndexs;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->ZoneIndexs);
			}
			ptr->bFound = bFound;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ZoneFollowCameraController_C.__FindActiveZone_NativeFunctionPtr, (void*)ptr);
			TArray<int> tarray2 = ZoneIndexs;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->ZoneIndexs);
			}
			bFound = ptr->bFound;
			UnrealReflectionUtils.DestroyStruct(BP_ZoneFollowCameraController_C.__FindActiveZone_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601FA02 RID: 129538 RVA: 0x00931E9E File Offset: 0x0093009E
		[SkipLocalsInit]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ZoneFollowCameraController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FA03 RID: 129539 RVA: 0x00931EB2 File Offset: 0x009300B2
		[SkipLocalsInit]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ZoneFollowCameraController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x0601FA04 RID: 129540 RVA: 0x00931EC6 File Offset: 0x009300C6
		protected BP_ZoneFollowCameraController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010F5F RID: 69471
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraController.BP_ZoneFollowCameraController_C";

		// Token: 0x04010F60 RID: 69472
		private static IntPtr _ClassPtr;

		// Token: 0x04010F61 RID: 69473
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010F62 RID: 69474
		internal static int __PropertyOffset_Sphere;

		// Token: 0x04010F63 RID: 69475
		internal static int __PropertyOffset_DefaultSceneRoot;

		// Token: 0x04010F64 RID: 69476
		internal static int __PropertyOffset_预览相机;

		// Token: 0x04010F65 RID: 69477
		internal static int __PropertyOffset_过渡速度;

		// Token: 0x04010F66 RID: 69478
		internal static int __PropertyOffset_TargetCameraPos;

		// Token: 0x04010F67 RID: 69479
		internal static int __PropertyOffset_TargetCameraRot;

		// Token: 0x04010F68 RID: 69480
		internal static int __PropertyOffset_IsActive;

		// Token: 0x04010F69 RID: 69481
		internal static int __PropertyOffset_默认相机FOV;

		// Token: 0x04010F6A RID: 69482
		internal static int __PropertyOffset_默认相机偏移;

		// Token: 0x04010F6B RID: 69483
		internal static int __PropertyOffset_默认相机旋转;

		// Token: 0x04010F6C RID: 69484
		private static IntPtr __PackageCameraConfig_NativeFunctionPtr;

		// Token: 0x04010F6D RID: 69485
		private static IntPtr __ComputeTargetPosition_NativeFunctionPtr;

		// Token: 0x04010F6E RID: 69486
		private static IntPtr __FindActiveZone_NativeFunctionPtr;

		// Token: 0x04010F6F RID: 69487
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x02008F25 RID: 36645
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 624)]
		protected ref struct __PackageCameraConfig_FunctionParams
		{
			// Token: 0x0402CC57 RID: 183383
			[FieldOffset(0)]
			public byte Configs;
		}

		// Token: 0x02008F26 RID: 36646
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 496)]
		protected ref struct __ComputeTargetPosition_FunctionParams
		{
			// Token: 0x0402CC58 RID: 183384
			[FieldOffset(0)]
			public byte ZoneIndexs;

			// Token: 0x0402CC59 RID: 183385
			[FieldOffset(16)]
			public FVector RoleWorldPos;

			// Token: 0x0402CC5A RID: 183386
			[FieldOffset(28)]
			public FVector OutPosition;

			// Token: 0x0402CC5B RID: 183387
			[FieldOffset(40)]
			public FRotator OutRotation;
		}

		// Token: 0x02008F27 RID: 36647
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __FindActiveZone_FunctionParams
		{
			// Token: 0x0402CC5C RID: 183388
			[FieldOffset(0)]
			public FVector WorldPos;

			// Token: 0x0402CC5D RID: 183389
			[FieldOffset(16)]
			public byte ZoneIndexs;

			// Token: 0x0402CC5E RID: 183390
			[FieldOffset(32)]
			public bool bFound;
		}
	}
}
