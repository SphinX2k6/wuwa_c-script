using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Data.Gameplay.ZoneFollowCamera
{
	// Token: 0x02003F25 RID: 16165
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraController.BP_ZoneFollowCameraController_C")]
	[UnrealStructLayout(1144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1140)]
	public class BP_ZoneFollowCameraController_C : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060290B7 RID: 168119 RVA: 0x009BA63F File Offset: 0x009B883F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ZoneFollowCameraController_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraController.BP_ZoneFollowCameraController_C");
			}
			return BP_ZoneFollowCameraController_C._ClassPtr;
		}

		// Token: 0x060290B8 RID: 168120 RVA: 0x009BA664 File Offset: 0x009B8864
		public BP_ZoneFollowCameraController_C() : this(BuiltinUtils.AllocNativeUObject(BP_ZoneFollowCameraController_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060290B9 RID: 168121 RVA: 0x009BA68C File Offset: 0x009B888C
		[NullableContext(1)]
		public BP_ZoneFollowCameraController_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ZoneFollowCameraController_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700611A RID: 24858
		// (get) Token: 0x060290BA RID: 168122 RVA: 0x009BA6BF File Offset: 0x009B88BF
		// (set) Token: 0x060290BB RID: 168123 RVA: 0x009BA6D3 File Offset: 0x009B88D3
		public unsafe UStaticMeshComponent Sphere
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_0);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_0, value);
			}
		}

		// Token: 0x1700611B RID: 24859
		// (get) Token: 0x060290BC RID: 168124 RVA: 0x009BA6E8 File Offset: 0x009B88E8
		// (set) Token: 0x060290BD RID: 168125 RVA: 0x009BA6FC File Offset: 0x009B88FC
		public unsafe USceneComponent DefaultSceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_1, value);
			}
		}

		// Token: 0x1700611C RID: 24860
		// (get) Token: 0x060290BE RID: 168126 RVA: 0x009BA711 File Offset: 0x009B8911
		// (set) Token: 0x060290BF RID: 168127 RVA: 0x009BA725 File Offset: 0x009B8925
		public unsafe ACameraActor 预览相机
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACameraActor>(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + BP_ZoneFollowCameraController_C.__PropertyOffset_2, value);
			}
		}

		// Token: 0x1700611D RID: 24861
		// (get) Token: 0x060290C0 RID: 168128 RVA: 0x009BA73C File Offset: 0x009B893C
		// (set) Token: 0x060290C1 RID: 168129 RVA: 0x009BA775 File Offset: 0x009B8975
		[Nullable(1)]
		public TArray<BP_ZoneFollowCameraZone_C> 区域配置
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<BP_ZoneFollowCameraZone_C> result;
				if ((result = this._区域配置) == null)
				{
					result = (this._区域配置 = new TArray<BP_ZoneFollowCameraZone_C>(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_3, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.区域配置.CopyAssign(value);
			}
		}

		// Token: 0x1700611E RID: 24862
		// (get) Token: 0x060290C2 RID: 168130 RVA: 0x009BA783 File Offset: 0x009B8983
		// (set) Token: 0x060290C3 RID: 168131 RVA: 0x009BA793 File Offset: 0x009B8993
		public unsafe float 过渡速度
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700611F RID: 24863
		// (get) Token: 0x060290C4 RID: 168132 RVA: 0x009BA7A4 File Offset: 0x009B89A4
		// (set) Token: 0x060290C5 RID: 168133 RVA: 0x009BA7B8 File Offset: 0x009B89B8
		public unsafe FVector TargetCameraPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006120 RID: 24864
		// (get) Token: 0x060290C6 RID: 168134 RVA: 0x009BA7CD File Offset: 0x009B89CD
		// (set) Token: 0x060290C7 RID: 168135 RVA: 0x009BA7E1 File Offset: 0x009B89E1
		public unsafe FRotator TargetCameraRot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006121 RID: 24865
		// (get) Token: 0x060290C8 RID: 168136 RVA: 0x009BA7F6 File Offset: 0x009B89F6
		// (set) Token: 0x060290C9 RID: 168137 RVA: 0x009BA806 File Offset: 0x009B8A06
		public unsafe bool IsActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_7) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_7) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006122 RID: 24866
		// (get) Token: 0x060290CA RID: 168138 RVA: 0x009BA817 File Offset: 0x009B8A17
		// (set) Token: 0x060290CB RID: 168139 RVA: 0x009BA827 File Offset: 0x009B8A27
		public unsafe float 默认相机FOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x17006123 RID: 24867
		// (get) Token: 0x060290CC RID: 168140 RVA: 0x009BA838 File Offset: 0x009B8A38
		// (set) Token: 0x060290CD RID: 168141 RVA: 0x009BA84C File Offset: 0x009B8A4C
		public unsafe FVector 默认相机偏移
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x17006124 RID: 24868
		// (get) Token: 0x060290CE RID: 168142 RVA: 0x009BA861 File Offset: 0x009B8A61
		// (set) Token: 0x060290CF RID: 168143 RVA: 0x009BA875 File Offset: 0x009B8A75
		public unsafe FRotator 默认相机旋转
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ZoneFollowCameraController_C.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x060290D0 RID: 168144 RVA: 0x009BA88C File Offset: 0x009B8A8C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060290D1 RID: 168145 RVA: 0x009BA928 File Offset: 0x009B8B28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060290D2 RID: 168146 RVA: 0x009BA9DC File Offset: 0x009B8BDC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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

		// Token: 0x060290D3 RID: 168147 RVA: 0x009BAA6E File Offset: 0x009B8C6E
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public override void UserConstructionScript()
		{
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, BP_ZoneFollowCameraController_C.__UserConstructionScript_NativeFunctionPtr, null);
		}

		// Token: 0x060290D4 RID: 168148 RVA: 0x009BAA82 File Offset: 0x009B8C82
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		protected virtual void UserConstructionScript_Implementation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, BP_ZoneFollowCameraController_C.__UserConstructionScript_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060290D5 RID: 168149 RVA: 0x009BAA97 File Offset: 0x009B8C97
		protected BP_ZoneFollowCameraController_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401501F RID: 86047
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Data/Gameplay/ZoneFollowCamera/BP_ZoneFollowCameraController.BP_ZoneFollowCameraController_C";

		// Token: 0x04015020 RID: 86048
		private static IntPtr _ClassPtr;

		// Token: 0x04015021 RID: 86049
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015022 RID: 86050
		internal static int __PropertyOffset_0;

		// Token: 0x04015023 RID: 86051
		internal static int __PropertyOffset_1;

		// Token: 0x04015024 RID: 86052
		internal static int __PropertyOffset_2;

		// Token: 0x04015025 RID: 86053
		internal static int __PropertyOffset_3;

		// Token: 0x04015026 RID: 86054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<BP_ZoneFollowCameraZone_C> _区域配置;

		// Token: 0x04015027 RID: 86055
		internal static int __PropertyOffset_4;

		// Token: 0x04015028 RID: 86056
		internal static int __PropertyOffset_5;

		// Token: 0x04015029 RID: 86057
		internal static int __PropertyOffset_6;

		// Token: 0x0401502A RID: 86058
		internal static int __PropertyOffset_7;

		// Token: 0x0401502B RID: 86059
		internal static int __PropertyOffset_8;

		// Token: 0x0401502C RID: 86060
		internal static int __PropertyOffset_9;

		// Token: 0x0401502D RID: 86061
		internal static int __PropertyOffset_10;

		// Token: 0x0401502E RID: 86062
		private static IntPtr __PackageCameraConfig_NativeFunctionPtr;

		// Token: 0x0401502F RID: 86063
		private static IntPtr __ComputeTargetPosition_NativeFunctionPtr;

		// Token: 0x04015030 RID: 86064
		private static IntPtr __FindActiveZone_NativeFunctionPtr;

		// Token: 0x04015031 RID: 86065
		private static IntPtr __UserConstructionScript_NativeFunctionPtr;

		// Token: 0x0200A2DD RID: 41693
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 624)]
		protected ref struct __PackageCameraConfig_FunctionParams
		{
			// Token: 0x04032021 RID: 204833
			[FieldOffset(0)]
			public byte Configs;
		}

		// Token: 0x0200A2DE RID: 41694
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 496)]
		protected ref struct __ComputeTargetPosition_FunctionParams
		{
			// Token: 0x04032022 RID: 204834
			[FieldOffset(0)]
			public byte ZoneIndexs;

			// Token: 0x04032023 RID: 204835
			[FieldOffset(16)]
			public FVector RoleWorldPos;

			// Token: 0x04032024 RID: 204836
			[FieldOffset(28)]
			public FVector OutPosition;

			// Token: 0x04032025 RID: 204837
			[FieldOffset(40)]
			public FRotator OutRotation;
		}

		// Token: 0x0200A2DF RID: 41695
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 224)]
		protected ref struct __FindActiveZone_FunctionParams
		{
			// Token: 0x04032026 RID: 204838
			[FieldOffset(0)]
			public FVector WorldPos;

			// Token: 0x04032027 RID: 204839
			[FieldOffset(16)]
			public byte ZoneIndexs;

			// Token: 0x04032028 RID: 204840
			[FieldOffset(32)]
			public bool bFound;
		}
	}
}
