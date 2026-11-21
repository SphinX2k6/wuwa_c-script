using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F49 RID: 12105
public class __TsEntityDebugInfoManager_InheritProxy : TsEntityDebugInfoManager
{
	// Token: 0x0601CAFD RID: 117501 RVA: 0x008C124C File Offset: 0x008BF44C
	[NullableContext(1)]
	public __TsEntityDebugInfoManager_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEntityDebugInfoManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CAFE RID: 117502 RVA: 0x008C127F File Offset: 0x008BF47F
	protected __TsEntityDebugInfoManager_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CAFF RID: 117503 RVA: 0x008C1288 File Offset: 0x008BF488
	protected unsafe override void __CPPCALL_GetDebugEntityNameList_Implementation(TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams* __Params)
	{
		TArray<string> debugEntityNameList_Implementation = base.GetDebugEntityNameList_Implementation();
		if (debugEntityNameList_Implementation == null)
		{
			return;
		}
		debugEntityNameList_Implementation.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601CB00 RID: 117504 RVA: 0x008C12B8 File Offset: 0x008BF4B8
	protected unsafe override void __CPPCALL_GetSelectedEntityId_Implementation(TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams* __Params)
	{
		string label = FString.ToString((void*)(&__Params->label));
		__Params->__Result = base.GetSelectedEntityId_Implementation(label);
	}

	// Token: 0x0601CB01 RID: 117505 RVA: 0x008C12DF File Offset: 0x008BF4DF
	protected unsafe override void __CPPCALL_GetEntityTimeScale_Implementation(TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams* __Params)
	{
		__Params->__Result = base.GetEntityTimeScale_Implementation(__Params->entityId);
	}

	// Token: 0x0601CB02 RID: 117506 RVA: 0x008C12F3 File Offset: 0x008BF4F3
	protected unsafe override void __CPPCALL_SetEntityTimeScale_Implementation(TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams* __Params)
	{
		base.SetEntityTimeScale_Implementation(__Params->entityId, __Params->timeScale);
	}

	// Token: 0x0601CB03 RID: 117507 RVA: 0x008C1307 File Offset: 0x008BF507
	protected unsafe override void __CPPCALL_GetEntityPbDataId_Implementation(TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams* __Params)
	{
		__Params->__Result = base.GetEntityPbDataId_Implementation(__Params->entityId);
	}

	// Token: 0x0601CB04 RID: 117508 RVA: 0x008C131B File Offset: 0x008BF51B
	protected unsafe override void __CPPCALL_GetInteractionDebugInfos_Implementation(TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetInteractionDebugInfos_Implementation(__Params->entityId));
	}

	// Token: 0x0601CB05 RID: 117509 RVA: 0x008C1335 File Offset: 0x008BF535
	protected unsafe override void __CPPCALL_GetEntityCommonTagDebugString_Implementation(TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetEntityCommonTagDebugString_Implementation(__Params->entityId));
	}

	// Token: 0x0601CB06 RID: 117510 RVA: 0x008C134F File Offset: 0x008BF54F
	protected unsafe override void __CPPCALL_GetDebugEntityActor_Implementation(TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor debugEntityActor_Implementation = base.GetDebugEntityActor_Implementation(__Params->entityId);
		ptr = ((debugEntityActor_Implementation != null) ? debugEntityActor_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601CB07 RID: 117511 RVA: 0x008C1372 File Offset: 0x008BF572
	protected unsafe override void __CPPCALL_GetDebugBaseInfo_Implementation(TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetDebugBaseInfo_Implementation(__Params->entityId));
	}

	// Token: 0x0601CB08 RID: 117512 RVA: 0x008C138C File Offset: 0x008BF58C
	protected unsafe override void __CPPCALL_GetDebugEntityName_Implementation(TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetDebugEntityName_Implementation(__Params->entityId));
	}
}
