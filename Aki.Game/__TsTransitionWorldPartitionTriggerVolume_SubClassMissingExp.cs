using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003953 RID: 14675
[NullableContext(1)]
[Nullable(0)]
public class __TsTransitionWorldPartitionTriggerVolume_SubClassMissingExportProxy : __TsTransitionWorldPartitionTriggerVolume_InheritProxy
{
	// Token: 0x0601EC74 RID: 126068 RVA: 0x0089A95C File Offset: 0x00898B5C
	protected __TsTransitionWorldPartitionTriggerVolume_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTransitionWorldPartitionTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC75 RID: 126069 RVA: 0x0089A98F File Offset: 0x00898B8F
	protected __TsTransitionWorldPartitionTriggerVolume_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC76 RID: 126070 RVA: 0x0089A998 File Offset: 0x00898B98
	[NullableContext(2)]
	public unsafe override void SetMatForActivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMatForActivatingDataLayers"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC77 RID: 126071 RVA: 0x0089AA20 File Offset: 0x00898C20
	public unsafe override bool WasMatForActivatingDataLayersSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasMatForActivatingDataLayersSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams) & -16L);
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

	// Token: 0x0601EC78 RID: 126072 RVA: 0x0089AA98 File Offset: 0x00898C98
	[NullableContext(2)]
	public unsafe override void SetMatForDeactivatingDataLayers(UKuroSceneMatModifyDataAsset asset)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetMatForDeactivatingDataLayers"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			*(&ptr2->asset) = ((asset != null) ? asset.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EC79 RID: 126073 RVA: 0x0089AB20 File Offset: 0x00898D20
	public unsafe override bool WasMatForDeactivatingDataLayersSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasMatForDeactivatingDataLayersSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams) & -16L);
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

	// Token: 0x0601EC7A RID: 126074 RVA: 0x0089AB98 File Offset: 0x00898D98
	public unsafe override void SetSeqForSourceIn([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetSeqForSourceIn"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams) & -16L);
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

	// Token: 0x0601EC7B RID: 126075 RVA: 0x0089AC2C File Offset: 0x00898E2C
	public unsafe override bool WasSeqForSourceInSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasSeqForSourceInSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams) & -16L);
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

	// Token: 0x0601EC7C RID: 126076 RVA: 0x0089ACA4 File Offset: 0x00898EA4
	public unsafe override void SetSeqForSourceOut([Nullable(2)] ULevelSequence asset, string beforeModifyMatMark)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetSeqForSourceOut"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams) & -16L);
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

	// Token: 0x0601EC7D RID: 126077 RVA: 0x0089AD38 File Offset: 0x00898F38
	public unsafe override bool WasSeqForSourceOutSet()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("WasSeqForSourceOutSet"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams*)ptr + 15L / (long)sizeof(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams) & -16L);
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
