using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039CE RID: 14798
public class __TsEntityDebugInfoManager_InheritProxy : TsEntityDebugInfoManager
{
	// Token: 0x0601EF1B RID: 126747 RVA: 0x008A3674 File Offset: 0x008A1874
	[NullableContext(1)]
	public __TsEntityDebugInfoManager_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEntityDebugInfoManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF1C RID: 126748 RVA: 0x008A36A7 File Offset: 0x008A18A7
	protected __TsEntityDebugInfoManager_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EF1D RID: 126749 RVA: 0x008A36B0 File Offset: 0x008A18B0
	protected unsafe override void __CPPCALL_GetDebugEntityNameList_Implementation(TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams* __Params)
	{
		TArray<string> debugEntityNameList_Implementation = base.GetDebugEntityNameList_Implementation();
		if (debugEntityNameList_Implementation == null)
		{
			return;
		}
		debugEntityNameList_Implementation.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601EF1E RID: 126750 RVA: 0x008A36E0 File Offset: 0x008A18E0
	protected unsafe override void __CPPCALL_GetSelectedEntityId_Implementation(TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams* __Params)
	{
		string label = FString.ToString((void*)(&__Params->label));
		__Params->__Result = base.GetSelectedEntityId_Implementation(label);
	}

	// Token: 0x0601EF1F RID: 126751 RVA: 0x008A3707 File Offset: 0x008A1907
	protected unsafe override void __CPPCALL_GetEntityTimeScale_Implementation(TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams* __Params)
	{
		__Params->__Result = base.GetEntityTimeScale_Implementation(__Params->entityId);
	}

	// Token: 0x0601EF20 RID: 126752 RVA: 0x008A371B File Offset: 0x008A191B
	protected unsafe override void __CPPCALL_SetEntityTimeScale_Implementation(TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams* __Params)
	{
		base.SetEntityTimeScale_Implementation(__Params->entityId, __Params->timeScale);
	}

	// Token: 0x0601EF21 RID: 126753 RVA: 0x008A372F File Offset: 0x008A192F
	protected unsafe override void __CPPCALL_GetEntityPbDataId_Implementation(TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams* __Params)
	{
		__Params->__Result = base.GetEntityPbDataId_Implementation(__Params->entityId);
	}

	// Token: 0x0601EF22 RID: 126754 RVA: 0x008A3743 File Offset: 0x008A1943
	protected unsafe override void __CPPCALL_GetInteractionDebugInfos_Implementation(TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetInteractionDebugInfos_Implementation(__Params->entityId));
	}

	// Token: 0x0601EF23 RID: 126755 RVA: 0x008A375D File Offset: 0x008A195D
	protected unsafe override void __CPPCALL_GetEntityCommonTagDebugString_Implementation(TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetEntityCommonTagDebugString_Implementation(__Params->entityId));
	}

	// Token: 0x0601EF24 RID: 126756 RVA: 0x008A3777 File Offset: 0x008A1977
	protected unsafe override void __CPPCALL_GetDebugEntityActor_Implementation(TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor debugEntityActor_Implementation = base.GetDebugEntityActor_Implementation(__Params->entityId);
		ptr = ((debugEntityActor_Implementation != null) ? debugEntityActor_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601EF25 RID: 126757 RVA: 0x008A379A File Offset: 0x008A199A
	protected unsafe override void __CPPCALL_GetDebugBaseInfo_Implementation(TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetDebugBaseInfo_Implementation(__Params->entityId));
	}

	// Token: 0x0601EF26 RID: 126758 RVA: 0x008A37B4 File Offset: 0x008A19B4
	protected unsafe override void __CPPCALL_GetDebugEntityName_Implementation(TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), base.GetDebugEntityName_Implementation(__Params->entityId));
	}
}
