using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002ECD RID: 11981
public class __TsTransitionWorldPartitionTriggerVolume_InheritProxy : TsTransitionWorldPartitionTriggerVolume
{
	// Token: 0x0601C905 RID: 116997 RVA: 0x008BDE34 File Offset: 0x008BC034
	[NullableContext(1)]
	public __TsTransitionWorldPartitionTriggerVolume_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsTransitionWorldPartitionTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C906 RID: 116998 RVA: 0x008BDE67 File Offset: 0x008BC067
	protected __TsTransitionWorldPartitionTriggerVolume_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C907 RID: 116999 RVA: 0x008BDE70 File Offset: 0x008BC070
	protected unsafe override void __CPPCALL_SetMatForActivatingDataLayers_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetMatForActivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		base.SetMatForActivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C908 RID: 117000 RVA: 0x008BDE90 File Offset: 0x008BC090
	protected unsafe override void __CPPCALL_WasMatForActivatingDataLayersSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasMatForActivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasMatForActivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601C909 RID: 117001 RVA: 0x008BDEA0 File Offset: 0x008BC0A0
	protected unsafe override void __CPPCALL_SetMatForDeactivatingDataLayers_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetMatForDeactivatingDataLayers_FunctionParams* __Params)
	{
		UKuroSceneMatModifyDataAsset orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroSceneMatModifyDataAsset>(__Params->asset);
		base.SetMatForDeactivatingDataLayers_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C90A RID: 117002 RVA: 0x008BDEC0 File Offset: 0x008BC0C0
	protected unsafe override void __CPPCALL_WasMatForDeactivatingDataLayersSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasMatForDeactivatingDataLayersSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasMatForDeactivatingDataLayersSet_Implementation();
	}

	// Token: 0x0601C90B RID: 117003 RVA: 0x008BDED0 File Offset: 0x008BC0D0
	protected unsafe override void __CPPCALL_SetSeqForSourceIn_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceIn_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		base.SetSeqForSourceIn_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601C90C RID: 117004 RVA: 0x008BDEFE File Offset: 0x008BC0FE
	protected unsafe override void __CPPCALL_WasSeqForSourceInSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceInSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasSeqForSourceInSet_Implementation();
	}

	// Token: 0x0601C90D RID: 117005 RVA: 0x008BDF0C File Offset: 0x008BC10C
	protected unsafe override void __CPPCALL_SetSeqForSourceOut_Implementation(TsTransitionWorldPartitionTriggerVolume.__SetSeqForSourceOut_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->asset);
		string beforeModifyMatMark = FString.ToString((void*)(&__Params->beforeModifyMatMark));
		base.SetSeqForSourceOut_Implementation(orCreateUObjectByNativePointer, beforeModifyMatMark);
	}

	// Token: 0x0601C90E RID: 117006 RVA: 0x008BDF3A File Offset: 0x008BC13A
	protected unsafe override void __CPPCALL_WasSeqForSourceOutSet_Implementation(TsTransitionWorldPartitionTriggerVolume.__WasSeqForSourceOutSet_FunctionParams* __Params)
	{
		__Params->__Result = base.WasSeqForSourceOutSet_Implementation();
	}

	// Token: 0x0601C90F RID: 117007 RVA: 0x008BDF48 File Offset: 0x008BC148
	protected override void __CPPCALL_OnStateChanged_Implementation()
	{
		base.OnStateChanged_Implementation();
	}

	// Token: 0x0601C910 RID: 117008 RVA: 0x008BDF50 File Offset: 0x008BC150
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}
}
