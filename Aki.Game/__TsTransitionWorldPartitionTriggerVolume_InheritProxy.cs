using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003952 RID: 14674
public class __TsTransitionWorldPartitionTriggerVolume_InheritProxy : TsTransitionWorldPartitionTriggerVolume
{
	// Token: 0x0601EC69 RID: 126057 RVA: 0x0089A840 File Offset: 0x00898A40
	[NullableContext(1)]
	public __TsTransitionWorldPartitionTriggerVolume_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTransitionWorldPartitionTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EC6A RID: 126058 RVA: 0x0089A873 File Offset: 0x00898A73
	protected __TsTransitionWorldPartitionTriggerVolume_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EC6B RID: 126059 RVA: 0x0089A87C File Offset: 0x00898A7C
	protected unsafe override void __CPPCALL_SetMatForActivatingDataLayers_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		base.SetMatForActivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EC6C RID: 126060 RVA: 0x0089A89C File Offset: 0x00898A9C
	protected unsafe override void __CPPCALL_WasMatForActivatingDataLayersSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasMatForActivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601EC6D RID: 126061 RVA: 0x0089A8AC File Offset: 0x00898AAC
	protected unsafe override void __CPPCALL_SetMatForDeactivatingDataLayers_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		base.SetMatForDeactivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EC6E RID: 126062 RVA: 0x0089A8CC File Offset: 0x00898ACC
	protected unsafe override void __CPPCALL_WasMatForDeactivatingDataLayersSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasMatForDeactivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601EC6F RID: 126063 RVA: 0x0089A8DC File Offset: 0x00898ADC
	protected unsafe override void __CPPCALL_SetSeqForSourceIn_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		base.SetSeqForSourceIn_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601EC70 RID: 126064 RVA: 0x0089A90A File Offset: 0x00898B0A
	protected unsafe override void __CPPCALL_WasSeqForSourceInSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasSeqForSourceInSet_Implementation();
	}

	// Token: 0x0601EC71 RID: 126065 RVA: 0x0089A918 File Offset: 0x00898B18
	protected unsafe override void __CPPCALL_SetSeqForSourceOut_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		base.SetSeqForSourceOut_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601EC72 RID: 126066 RVA: 0x0089A946 File Offset: 0x00898B46
	protected unsafe override void __CPPCALL_WasSeqForSourceOutSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasSeqForSourceOutSet_Implementation();
	}

	// Token: 0x0601EC73 RID: 126067 RVA: 0x0089A954 File Offset: 0x00898B54
	protected override void __CPPCALL_OnStateChanged_Implementation()
	{
		base.OnStateChanged_Implementation();
	}
}
