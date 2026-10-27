using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x0200394E RID: 14670
public class __TsDataLayerTransitionTrigger_InheritProxy : TsDataLayerTransitionTrigger
{
	// Token: 0x0601EC51 RID: 126033 RVA: 0x0089A260 File Offset: 0x00898460
	[NullableContext(1)]
	public __TsDataLayerTransitionTrigger_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsDataLayerTransitionTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC52 RID: 126034 RVA: 0x0089A293 File Offset: 0x00898493
	protected __TsDataLayerTransitionTrigger_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC53 RID: 126035 RVA: 0x0089A29C File Offset: 0x0089849C
	protected unsafe override void __CPPCALL_SetMatForActivatingDataLayers_Implementation(TsDataLayerTransitionTrigger.__SetMatForActivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		base.SetMatForActivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EC54 RID: 126036 RVA: 0x0089A2BC File Offset: 0x008984BC
	protected unsafe override void __CPPCALL_WasMatForActivatingDataLayersSet_Implementation(TsDataLayerTransitionTrigger.__WasMatForActivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasMatForActivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601EC55 RID: 126037 RVA: 0x0089A2CC File Offset: 0x008984CC
	protected unsafe override void __CPPCALL_SetMatForDeactivatingDataLayers_Implementation(TsDataLayerTransitionTrigger.__SetMatForDeactivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		base.SetMatForDeactivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EC56 RID: 126038 RVA: 0x0089A2EC File Offset: 0x008984EC
	protected unsafe override void __CPPCALL_WasMatForDeactivatingDataLayersSet_Implementation(TsDataLayerTransitionTrigger.__WasMatForDeactivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasMatForDeactivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601EC57 RID: 126039 RVA: 0x0089A2FC File Offset: 0x008984FC
	protected unsafe override void __CPPCALL_SetSeqForSourceIn_Implementation(TsDataLayerTransitionTrigger.__SetSeqForSourceIn_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		base.SetSeqForSourceIn_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601EC58 RID: 126040 RVA: 0x0089A32A File Offset: 0x0089852A
	protected unsafe override void __CPPCALL_WasSeqForSourceInSet_Implementation(TsDataLayerTransitionTrigger.__WasSeqForSourceInSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasSeqForSourceInSet_Implementation();
	}

	// Token: 0x0601EC59 RID: 126041 RVA: 0x0089A338 File Offset: 0x00898538
	protected unsafe override void __CPPCALL_SetSeqForSourceOut_Implementation(TsDataLayerTransitionTrigger.__SetSeqForSourceOut_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		base.SetSeqForSourceOut_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601EC5A RID: 126042 RVA: 0x0089A366 File Offset: 0x00898566
	protected unsafe override void __CPPCALL_WasSeqForSourceOutSet_Implementation(TsDataLayerTransitionTrigger.__WasSeqForSourceOutSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasSeqForSourceOutSet_Implementation();
	}
}
