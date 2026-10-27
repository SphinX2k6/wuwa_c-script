using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter.Camera
{
	// Token: 0x0200439C RID: 17308
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/Camera/BPL_CameraUtility.BPL_CameraUtility_C")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class BPL_CameraUtility_C : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602CD40 RID: 183616 RVA: 0x00A2998E File Offset: 0x00A27B8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BPL_CameraUtility_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/Camera/BPL_CameraUtility.BPL_CameraUtility_C");
			}
			return BPL_CameraUtility_C._ClassPtr;
		}

		// Token: 0x0602CD41 RID: 183617 RVA: 0x00A299B4 File Offset: 0x00A27BB4
		public BPL_CameraUtility_C() : this(BuiltinUtils.AllocNativeUObject(BPL_CameraUtility_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602CD42 RID: 183618 RVA: 0x00A299DC File Offset: 0x00A27BDC
		[NullableContext(1)]
		public BPL_CameraUtility_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BPL_CameraUtility_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602CD43 RID: 183619 RVA: 0x00A29A10 File Offset: 0x00A27C10
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DtGetCameraConfigList([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SCameraConfig> CameraSettings, UDataTable DataTable, UObject __WorldContext)
		{
			BPL_CameraUtility_C.StaticClass();
			BPL_CameraUtility_C.__DtGetCameraConfigList_FunctionParams* ptr = stackalloc BPL_CameraUtility_C.__DtGetCameraConfigList_FunctionParams[(UIntPtr)2247] + 15L / (long)sizeof(BPL_CameraUtility_C.__DtGetCameraConfigList_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CameraUtility_C.__DtGetCameraConfigList_NativeFunctionPtr, (void*)ptr, 1);
			TArray<SCameraConfig> tarray = CameraSettings;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->CameraSettings);
			}
			ptr->DataTable = ((DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CameraUtility_C._ClassDefaultObjectPtr, BPL_CameraUtility_C.__DtGetCameraConfigList_NativeFunctionPtr, (void*)ptr);
			TArray<SCameraConfig> tarray2 = CameraSettings;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->CameraSettings);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CameraUtility_C.__DtGetCameraConfigList_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602CD44 RID: 183620 RVA: 0x00A29ABC File Offset: 0x00A27CBC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DtGetCameraConfigs([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<SCamera_Setting> CameraSettings, UDataTable DataTable, UObject __WorldContext)
		{
			BPL_CameraUtility_C.StaticClass();
			BPL_CameraUtility_C.__DtGetCameraConfigs_FunctionParams* ptr = stackalloc BPL_CameraUtility_C.__DtGetCameraConfigs_FunctionParams[(UIntPtr)287] + 15L / (long)sizeof(BPL_CameraUtility_C.__DtGetCameraConfigs_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(BPL_CameraUtility_C.__DtGetCameraConfigs_NativeFunctionPtr, (void*)ptr, 1);
			TArray<SCamera_Setting> tarray = CameraSettings;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->CameraSettings);
			}
			ptr->DataTable = ((DataTable != null) ? DataTable.NativePtr : IntPtr.Zero);
			ptr->__WorldContext = ((__WorldContext != null) ? __WorldContext.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(BPL_CameraUtility_C._ClassDefaultObjectPtr, BPL_CameraUtility_C.__DtGetCameraConfigs_NativeFunctionPtr, (void*)ptr);
			TArray<SCamera_Setting> tarray2 = CameraSettings;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->CameraSettings);
			}
			UnrealReflectionUtils.DestroyStruct(BPL_CameraUtility_C.__DtGetCameraConfigs_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602CD45 RID: 183621 RVA: 0x00A29B68 File Offset: 0x00A27D68
		protected BPL_CameraUtility_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04017A74 RID: 96884
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/Camera/BPL_CameraUtility.BPL_CameraUtility_C";

		// Token: 0x04017A75 RID: 96885
		private static IntPtr _ClassPtr;

		// Token: 0x04017A76 RID: 96886
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04017A77 RID: 96887
		private static IntPtr __DtGetCameraConfigList_NativeFunctionPtr;

		// Token: 0x04017A78 RID: 96888
		private static IntPtr __DtGetCameraConfigs_NativeFunctionPtr;

		// Token: 0x0200A673 RID: 42611
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2232)]
		protected ref struct __DtGetCameraConfigList_FunctionParams
		{
			// Token: 0x040325B3 RID: 206259
			[FieldOffset(0)]
			public byte CameraSettings;

			// Token: 0x040325B4 RID: 206260
			[FieldOffset(16)]
			public IntPtr DataTable;

			// Token: 0x040325B5 RID: 206261
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}

		// Token: 0x0200A674 RID: 42612
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __DtGetCameraConfigs_FunctionParams
		{
			// Token: 0x040325B6 RID: 206262
			[FieldOffset(0)]
			public byte CameraSettings;

			// Token: 0x040325B7 RID: 206263
			[FieldOffset(16)]
			public IntPtr DataTable;

			// Token: 0x040325B8 RID: 206264
			[FieldOffset(24)]
			public IntPtr __WorldContext;
		}
	}
}
