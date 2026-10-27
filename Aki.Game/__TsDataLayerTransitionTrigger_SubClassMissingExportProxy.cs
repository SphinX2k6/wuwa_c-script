using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200394F RID: 14671
[NullableContext(1)]
[Nullable(0)]
public class __TsDataLayerTransitionTrigger_SubClassMissingExportProxy : __TsDataLayerTransitionTrigger_InheritProxy
{
	// Token: 0x0601EC5B RID: 126043 RVA: 0x0089A374 File Offset: 0x00898574
	protected __TsDataLayerTransitionTrigger_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDataLayerTransitionTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC5C RID: 126044 RVA: 0x0089A3A7 File Offset: 0x008985A7
	protected __TsDataLayerTransitionTrigger_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC5D RID: 126045 RVA: 0x0089A3B0 File Offset: 0x008985B0
	[NullableContext(2)]
	public unsafe override void SetMatForActivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMatForActivatingDataLayers"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC5E RID: 126046 RVA: 0x0089A438 File Offset: 0x00898638
	public unsafe override bool WasMatForActivatingDataLayersSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasMatForActivatingDataLayersSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EC5F RID: 126047 RVA: 0x0089A4B0 File Offset: 0x008986B0
	[NullableContext(2)]
	public unsafe override void SetMatForDeactivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMatForDeactivatingDataLayers"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC60 RID: 126048 RVA: 0x0089A538 File Offset: 0x00898738
	public unsafe override bool WasMatForDeactivatingDataLayersSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasMatForDeactivatingDataLayersSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EC61 RID: 126049 RVA: 0x0089A5B0 File Offset: 0x008987B0
	public unsafe override void SetSeqForSourceIn([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetSeqForSourceIn"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
			FString.CopyFrom((void*)(&ptr2->beforeModifyMatMark), beforeModifyMatMark);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC62 RID: 126050 RVA: 0x0089A644 File Offset: 0x00898844
	public unsafe override bool WasSeqForSourceInSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasSeqForSourceInSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EC63 RID: 126051 RVA: 0x0089A6BC File Offset: 0x008988BC
	public unsafe override void SetSeqForSourceOut([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetSeqForSourceOut"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
			FString.CopyFrom((void*)(&ptr2->beforeModifyMatMark), beforeModifyMatMark);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC64 RID: 126052 RVA: 0x0089A750 File Offset: 0x00898950
	public unsafe override bool WasSeqForSourceOutSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasSeqForSourceOutSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams*)ptr + 15L / (long)sizeof(TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}
}
