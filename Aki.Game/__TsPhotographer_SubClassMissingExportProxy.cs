using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038BF RID: 14527
[NullableContext(1)]
[Nullable(0)]
public class __TsPhotographer_SubClassMissingExportProxy : __TsPhotographer_InheritProxy
{
	// Token: 0x0601EAB3 RID: 125619 RVA: 0x008967B8 File Offset: 0x008949B8
	protected __TsPhotographer_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsPhotographer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EAB4 RID: 125620 RVA: 0x008967EB File Offset: 0x008949EB
	protected __TsPhotographer_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EAB5 RID: 125621 RVA: 0x008967F4 File Offset: 0x008949F4
	public unsafe override void Initialize()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("Initialize"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EAB6 RID: 125622 RVA: 0x00896864 File Offset: 0x00894A64
	public unsafe override void RefreshPlayerLocation()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("RefreshPlayerLocation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EAB7 RID: 125623 RVA: 0x008968D4 File Offset: 0x00894AD4
	public unsafe override void SetPlayerSourceLocation(FVectorDouble location)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetPlayerSourceLocation"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetPlayerSourceLocation_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetPlayerSourceLocation_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetPlayerSourceLocation_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->location = location;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EAB8 RID: 125624 RVA: 0x0089694C File Offset: 0x00894B4C
	public unsafe override void SetCameraInitializeTransform(FTransformDouble transform)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCameraInitializeTransform"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetCameraInitializeTransform_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetCameraInitializeTransform_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetCameraInitializeTransform_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->transform = transform;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EAB9 RID: 125625 RVA: 0x008969C4 File Offset: 0x00894BC4
	public unsafe override FTransformDouble GetCameraInitializeTransform()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetCameraInitializeTransform"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__GetCameraInitializeTransform_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__GetCameraInitializeTransform_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__GetCameraInitializeTransform_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		FTransformDouble _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EABA RID: 125626 RVA: 0x00896A3C File Offset: 0x00894C3C
	public unsafe override void SetCameraInitializeFov(float fov)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCameraInitializeFov"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetCameraInitializeFov_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetCameraInitializeFov_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetCameraInitializeFov_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->fov = fov;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EABB RID: 125627 RVA: 0x00896AB4 File Offset: 0x00894CB4
	public unsafe override float GetCameraInitializeFov()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetCameraInitializeFov"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__GetCameraInitializeFov_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__GetCameraInitializeFov_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__GetCameraInitializeFov_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EABC RID: 125628 RVA: 0x00896B2C File Offset: 0x00894D2C
	public unsafe override void SetCameraArmTargetOffset(FVectorDouble cameraLocation, bool isInit)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCameraArmTargetOffset"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetCameraArmTargetOffset_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetCameraArmTargetOffset_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetCameraArmTargetOffset_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->cameraLocation = cameraLocation;
			ptr2->isInit = isInit;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EABD RID: 125629 RVA: 0x00896BAC File Offset: 0x00894DAC
	public unsafe override void MoveUp(float addValue)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MoveUp"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__MoveUp_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__MoveUp_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__MoveUp_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->addValue = addValue;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EABE RID: 125630 RVA: 0x00896C24 File Offset: 0x00894E24
	public unsafe override void MoveRight(float addValue)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MoveRight"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__MoveRight_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__MoveRight_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__MoveRight_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->addValue = addValue;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EABF RID: 125631 RVA: 0x00896C9C File Offset: 0x00894E9C
	public unsafe override void MoveForward(float addValue)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("MoveForward"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__MoveForward_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__MoveForward_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__MoveForward_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->addValue = addValue;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EAC0 RID: 125632 RVA: 0x00896D14 File Offset: 0x00894F14
	public unsafe override void SetFov(float fov)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetFov"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetFov_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetFov_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetFov_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->fov = fov;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EAC1 RID: 125633 RVA: 0x00896D8C File Offset: 0x00894F8C
	public unsafe override float GetFov()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetFov"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__GetFov_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__GetFov_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__GetFov_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EAC2 RID: 125634 RVA: 0x00896E04 File Offset: 0x00895004
	public unsafe override void ResetCamera()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("ResetCamera"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EAC3 RID: 125635 RVA: 0x00896E74 File Offset: 0x00895074
	public unsafe override void SetCameraLUT(string texturePath)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetCameraLUT"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsPhotographer.__SetCameraLUT_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsPhotographer.__SetCameraLUT_FunctionParams*)ptr + 15L / (long)sizeof(TsPhotographer.__SetCameraLUT_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->texturePath), texturePath);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
