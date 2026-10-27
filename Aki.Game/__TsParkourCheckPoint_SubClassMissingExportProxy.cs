using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038B1 RID: 14513
[NullableContext(1)]
[Nullable(0)]
public class __TsParkourCheckPoint_SubClassMissingExportProxy : __TsParkourCheckPoint_InheritProxy
{
	// Token: 0x0601EA79 RID: 125561 RVA: 0x00895F4C File Offset: 0x0089414C
	protected __TsParkourCheckPoint_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsParkourCheckPoint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA7A RID: 125562 RVA: 0x00895F7F File Offset: 0x0089417F
	protected __TsParkourCheckPoint_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA7B RID: 125563 RVA: 0x00895F88 File Offset: 0x00894188
	public unsafe override void SetDetectSphere(float inRadius)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetDetectSphere"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsParkourCheckPoint.__SetDetectSphere_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsParkourCheckPoint.__SetDetectSphere_FunctionParams*)ptr + 15L / (long)sizeof(TsParkourCheckPoint.__SetDetectSphere_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->inRadius = inRadius;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA7C RID: 125564 RVA: 0x00896000 File Offset: 0x00894200
	public unsafe override void GenerateFx(UEffectModelBase inModelBase)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GenerateFx"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsParkourCheckPoint.__GenerateFx_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsParkourCheckPoint.__GenerateFx_FunctionParams*)ptr + 15L / (long)sizeof(TsParkourCheckPoint.__GenerateFx_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->inModelBase) = ((inModelBase != null) ? inModelBase.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA7D RID: 125565 RVA: 0x00896088 File Offset: 0x00894288
	public unsafe override void GenerateFxByPath(string effectPath)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GenerateFxByPath"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsParkourCheckPoint.__GenerateFxByPath_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsParkourCheckPoint.__GenerateFxByPath_FunctionParams*)ptr + 15L / (long)sizeof(TsParkourCheckPoint.__GenerateFxByPath_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->effectPath), effectPath);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
