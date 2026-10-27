using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.NewWorld.Character.Common.Blueprint.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020034EE RID: 13550
[UClass("/Game/Aki/TypeScript/Game/World/Debug/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/World/Debug/TsEntityDebugInfoManager.TsEntityDebugInfoManager_C")]
public class TsEntityDebugInfoManager : UObject, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601DB45 RID: 121669 RVA: 0x00853762 File Offset: 0x00851962
	static TsEntityDebugInfoManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsEntityDebugInfoManager.CreateStaticDefaultValue), new Action(TsEntityDebugInfoManager.ResetStaticDefaultValue));
	}

	// Token: 0x0601DB46 RID: 121670 RVA: 0x00853781 File Offset: 0x00851981
	public static void CreateStaticDefaultValue()
	{
		TsEntityDebugInfoManager.Instance = null;
	}

	// Token: 0x0601DB47 RID: 121671 RVA: 0x00853789 File Offset: 0x00851989
	public static void ResetStaticDefaultValue()
	{
		TsEntityDebugInfoManager.Instance = null;
	}

	// Token: 0x0601DB48 RID: 121672 RVA: 0x00853791 File Offset: 0x00851991
	[NullableContext(1)]
	public static TsEntityDebugInfoManager GetInstance()
	{
		TsEntityDebugInfoManager instance = TsEntityDebugInfoManager.Instance;
		if (instance == null || !instance.IsValid())
		{
			TsEntityDebugInfoManager.Instance = UE.NewObject<TsEntityDebugInfoManager>(GlobalData.World, null, EObjectFlags.RF_NoFlags);
		}
		return TsEntityDebugInfoManager.Instance;
	}

	// Token: 0x0601DB49 RID: 121673 RVA: 0x008537C0 File Offset: 0x008519C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual TArray<string> GetDebugEntityNameList()
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		TArray<string> result = new TArray<string>(&ptr2->__Result, true, true);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601DB4A RID: 121674 RVA: 0x0085383D File Offset: 0x00851A3D
	[NullableContext(1)]
	protected TArray<string> GetDebugEntityNameList_Implementation()
	{
		return EntityDebugUtils.Instance.GetDebugEntityNameList();
	}

	// Token: 0x0601DB4B RID: 121675 RVA: 0x0085384C File Offset: 0x00851A4C
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int GetSelectedEntityId(string label)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601DB4C RID: 121676 RVA: 0x008538CE File Offset: 0x00851ACE
	[NullableContext(1)]
	protected int GetSelectedEntityId_Implementation(string label)
	{
		return EntityDebugUtils.Instance.GetSelectedEntityId(label);
	}

	// Token: 0x0601DB4D RID: 121677 RVA: 0x008538DC File Offset: 0x00851ADC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetEntityTimeScale(int entityId)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		float _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601DB4E RID: 121678 RVA: 0x00853958 File Offset: 0x00851B58
	protected float GetEntityTimeScale_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetEntityTimeScale(entityId);
	}

	// Token: 0x0601DB4F RID: 121679 RVA: 0x00853968 File Offset: 0x00851B68
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetEntityTimeScale(int entityId, float timeScale)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601DB50 RID: 121680 RVA: 0x008539E5 File Offset: 0x00851BE5
	protected void SetEntityTimeScale_Implementation(int entityId, float timeScale)
	{
		EntityDebugUtils.Instance.SetEntityTimeScale(entityId, timeScale);
	}

	// Token: 0x0601DB51 RID: 121681 RVA: 0x008539F4 File Offset: 0x00851BF4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int GetEntityPbDataId(int entityId)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		int _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601DB52 RID: 121682 RVA: 0x00853A70 File Offset: 0x00851C70
	protected int GetEntityPbDataId_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetEntityPbDataId(entityId);
	}

	// Token: 0x0601DB53 RID: 121683 RVA: 0x00853A80 File Offset: 0x00851C80
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetInteractionDebugInfos(int entityId)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601DB54 RID: 121684 RVA: 0x00853B02 File Offset: 0x00851D02
	[NullableContext(1)]
	protected string GetInteractionDebugInfos_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetInteractionDebugInfos(entityId);
	}

	// Token: 0x0601DB55 RID: 121685 RVA: 0x00853B10 File Offset: 0x00851D10
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetEntityCommonTagDebugString(int entityId)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601DB56 RID: 121686 RVA: 0x00853B92 File Offset: 0x00851D92
	[NullableContext(1)]
	protected string GetEntityCommonTagDebugString_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetEntityCommonTagDebugString(entityId);
	}

	// Token: 0x0601DB57 RID: 121687 RVA: 0x00853BA0 File Offset: 0x00851DA0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual AActor GetDebugEntityActor(int entityId)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr2->__Result);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601DB58 RID: 121688 RVA: 0x00853C21 File Offset: 0x00851E21
	[NullableContext(2)]
	protected AActor GetDebugEntityActor_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetDebugEntityActor(entityId);
	}

	// Token: 0x0601DB59 RID: 121689 RVA: 0x00853C30 File Offset: 0x00851E30
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetDebugBaseInfo(int entityId)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601DB5A RID: 121690 RVA: 0x00853CB2 File Offset: 0x00851EB2
	[NullableContext(1)]
	protected string GetDebugBaseInfo_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetDebugBaseInfo(entityId);
	}

	// Token: 0x0601DB5B RID: 121691 RVA: 0x00853CC0 File Offset: 0x00851EC0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetDebugEntityName(int entityId)
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
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		string result = FString.ToString((void*)(&ptr2->__Result));
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return result;
	}

	// Token: 0x0601DB5C RID: 121692 RVA: 0x00853D42 File Offset: 0x00851F42
	[NullableContext(2)]
	protected string GetDebugEntityName_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetDebugEntityName(entityId);
	}

	// Token: 0x0601DB5D RID: 121693 RVA: 0x00853D4F File Offset: 0x00851F4F
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsEntityDebugInfoManager._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/World/Debug/TsEntityDebugInfoManager.TsEntityDebugInfoManager_C");
		}
		return TsEntityDebugInfoManager._ClassPtr;
	}

	// Token: 0x0601DB5E RID: 121694 RVA: 0x00853D74 File Offset: 0x00851F74
	public TsEntityDebugInfoManager() : this(BuiltinUtils.AllocNativeUObject(TsEntityDebugInfoManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601DB5F RID: 121695 RVA: 0x00853D9C File Offset: 0x00851F9C
	[NullableContext(1)]
	public TsEntityDebugInfoManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEntityDebugInfoManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601DB60 RID: 121696 RVA: 0x00853DCF File Offset: 0x00851FCF
	protected TsEntityDebugInfoManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601DB61 RID: 121697 RVA: 0x00853DD8 File Offset: 0x00851FD8
	protected unsafe virtual void __CPPCALL_GetDebugEntityNameList_Implementation(TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams* __Params)
	{
		TArray<string> debugEntityNameList_Implementation = this.GetDebugEntityNameList_Implementation();
		if (debugEntityNameList_Implementation == null)
		{
			return;
		}
		debugEntityNameList_Implementation.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601DB62 RID: 121698 RVA: 0x00853E08 File Offset: 0x00852008
	protected unsafe virtual void __CPPCALL_GetSelectedEntityId_Implementation(TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams* __Params)
	{
		string label = FString.ToString((void*)(&__Params->label));
		__Params->__Result = this.GetSelectedEntityId_Implementation(label);
	}

	// Token: 0x0601DB63 RID: 121699 RVA: 0x00853E2F File Offset: 0x0085202F
	protected unsafe virtual void __CPPCALL_GetEntityTimeScale_Implementation(TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams* __Params)
	{
		__Params->__Result = this.GetEntityTimeScale_Implementation(__Params->entityId);
	}

	// Token: 0x0601DB64 RID: 121700 RVA: 0x00853E43 File Offset: 0x00852043
	protected unsafe virtual void __CPPCALL_SetEntityTimeScale_Implementation(TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams* __Params)
	{
		this.SetEntityTimeScale_Implementation(__Params->entityId, __Params->timeScale);
	}

	// Token: 0x0601DB65 RID: 121701 RVA: 0x00853E57 File Offset: 0x00852057
	protected unsafe virtual void __CPPCALL_GetEntityPbDataId_Implementation(TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams* __Params)
	{
		__Params->__Result = this.GetEntityPbDataId_Implementation(__Params->entityId);
	}

	// Token: 0x0601DB66 RID: 121702 RVA: 0x00853E6B File Offset: 0x0085206B
	protected unsafe virtual void __CPPCALL_GetInteractionDebugInfos_Implementation(TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetInteractionDebugInfos_Implementation(__Params->entityId));
	}

	// Token: 0x0601DB67 RID: 121703 RVA: 0x00853E85 File Offset: 0x00852085
	protected unsafe virtual void __CPPCALL_GetEntityCommonTagDebugString_Implementation(TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetEntityCommonTagDebugString_Implementation(__Params->entityId));
	}

	// Token: 0x0601DB68 RID: 121704 RVA: 0x00853E9F File Offset: 0x0085209F
	protected unsafe virtual void __CPPCALL_GetDebugEntityActor_Implementation(TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor debugEntityActor_Implementation = this.GetDebugEntityActor_Implementation(__Params->entityId);
		ptr = ((debugEntityActor_Implementation != null) ? debugEntityActor_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601DB69 RID: 121705 RVA: 0x00853EC2 File Offset: 0x008520C2
	protected unsafe virtual void __CPPCALL_GetDebugBaseInfo_Implementation(TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetDebugBaseInfo_Implementation(__Params->entityId));
	}

	// Token: 0x0601DB6A RID: 121706 RVA: 0x00853EDC File Offset: 0x008520DC
	protected unsafe virtual void __CPPCALL_GetDebugEntityName_Implementation(TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetDebugEntityName_Implementation(__Params->entityId));
	}

	// Token: 0x0400E92A RID: 59690
	[Nullable(2)]
	private static TsEntityDebugInfoManager Instance;

	// Token: 0x0400E92B RID: 59691
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/World/Debug/TsEntityDebugInfoManager.TsEntityDebugInfoManager_C";

	// Token: 0x0400E92C RID: 59692
	private static IntPtr _ClassPtr;

	// Token: 0x0400E92D RID: 59693
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020099A7 RID: 39335
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugEntityNameList_FunctionParams
	{
		// Token: 0x04030DD4 RID: 200148
		[FieldOffset(0)]
		public byte __Result;
	}

	// Token: 0x020099A8 RID: 39336
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSelectedEntityId_FunctionParams
	{
		// Token: 0x04030DD5 RID: 200149
		[FieldOffset(0)]
		public FString label;

		// Token: 0x04030DD6 RID: 200150
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x020099A9 RID: 39337
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetEntityTimeScale_FunctionParams
	{
		// Token: 0x04030DD7 RID: 200151
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030DD8 RID: 200152
		[FieldOffset(4)]
		public float __Result;
	}

	// Token: 0x020099AA RID: 39338
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetEntityTimeScale_FunctionParams
	{
		// Token: 0x04030DD9 RID: 200153
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030DDA RID: 200154
		[FieldOffset(4)]
		public float timeScale;
	}

	// Token: 0x020099AB RID: 39339
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetEntityPbDataId_FunctionParams
	{
		// Token: 0x04030DDB RID: 200155
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030DDC RID: 200156
		[FieldOffset(4)]
		public int __Result;
	}

	// Token: 0x020099AC RID: 39340
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetInteractionDebugInfos_FunctionParams
	{
		// Token: 0x04030DDD RID: 200157
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030DDE RID: 200158
		[FieldOffset(8)]
		public FString __Result;
	}

	// Token: 0x020099AD RID: 39341
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEntityCommonTagDebugString_FunctionParams
	{
		// Token: 0x04030DDF RID: 200159
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030DE0 RID: 200160
		[FieldOffset(8)]
		public FString __Result;
	}

	// Token: 0x020099AE RID: 39342
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugEntityActor_FunctionParams
	{
		// Token: 0x04030DE1 RID: 200161
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030DE2 RID: 200162
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020099AF RID: 39343
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDebugBaseInfo_FunctionParams
	{
		// Token: 0x04030DE3 RID: 200163
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030DE4 RID: 200164
		[FieldOffset(8)]
		public FString __Result;
	}

	// Token: 0x020099B0 RID: 39344
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDebugEntityName_FunctionParams
	{
		// Token: 0x04030DE5 RID: 200165
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04030DE6 RID: 200166
		[FieldOffset(8)]
		public FString __Result;
	}
}
