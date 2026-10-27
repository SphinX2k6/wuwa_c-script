using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039CF RID: 14799
[NullableContext(1)]
[Nullable(0)]
public class __TsEntityDebugInfoManager_SubClassMissingExportProxy : __TsEntityDebugInfoManager_InheritProxy
{
	// Token: 0x0601EF27 RID: 126759 RVA: 0x008A37D0 File Offset: 0x008A19D0
	protected __TsEntityDebugInfoManager_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEntityDebugInfoManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EF28 RID: 126760 RVA: 0x008A3803 File Offset: 0x008A1A03
	protected __TsEntityDebugInfoManager_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EF29 RID: 126761 RVA: 0x008A380C File Offset: 0x008A1A0C
	public unsafe override TArray<string> GetDebugEntityNameList()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDebugEntityNameList"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		TArray<string> result = new TArray<string>(&ptr2->__Result, true, true);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601EF2A RID: 126762 RVA: 0x008A388C File Offset: 0x008A1A8C
	public unsafe override int GetSelectedEntityId(string label)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetSelectedEntityId"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			FString.CopyFrom((void*)(&ptr2->label), label);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EF2B RID: 126763 RVA: 0x008A3910 File Offset: 0x008A1B10
	public unsafe override float GetEntityTimeScale(int entityId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetEntityTimeScale"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EF2C RID: 126764 RVA: 0x008A3990 File Offset: 0x008A1B90
	public unsafe override void SetEntityTimeScale(int entityId, float timeScale)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("SetEntityTimeScale"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
			ptr2->timeScale = timeScale;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EF2D RID: 126765 RVA: 0x008A3A10 File Offset: 0x008A1C10
	public unsafe override int GetEntityPbDataId(int entityId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetEntityPbDataId"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EF2E RID: 126766 RVA: 0x008A3A90 File Offset: 0x008A1C90
	public unsafe override string GetInteractionDebugInfos(int entityId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetInteractionDebugInfos"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601EF2F RID: 126767 RVA: 0x008A3B14 File Offset: 0x008A1D14
	public unsafe override string GetEntityCommonTagDebugString(int entityId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetEntityCommonTagDebugString"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601EF30 RID: 126768 RVA: 0x008A3B98 File Offset: 0x008A1D98
	[NullableContext(2)]
	public unsafe override AActor GetDebugEntityActor(int entityId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDebugEntityActor"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601EF31 RID: 126769 RVA: 0x008A3C1C File Offset: 0x008A1E1C
	public unsafe override string GetDebugBaseInfo(int entityId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDebugBaseInfo"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601EF32 RID: 126770 RVA: 0x008A3CA0 File Offset: 0x008A1EA0
	[NullableContext(2)]
	public unsafe override string GetDebugEntityName(int entityId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("GetDebugEntityName"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams*)ptr + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->entityId = entityId;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}
}
