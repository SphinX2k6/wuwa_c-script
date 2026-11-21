using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.NewWorld.Character.Common.Blueprint.Utils;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02002A62 RID: 10850
[UClass("/Game/Aki/TypeScript/Game/World/Debug/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/World/Debug/TsEntityDebugInfoManager.TsEntityDebugInfoManager_C")]
public class TsEntityDebugInfoManager : UObject, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x0601B853 RID: 112723 RVA: 0x0087BABA File Offset: 0x00879CBA
	static TsEntityDebugInfoManager()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(TsEntityDebugInfoManager.CreateStaticDefaultValue), new Action(TsEntityDebugInfoManager.ResetStaticDefaultValue));
	}

	// Token: 0x0601B854 RID: 112724 RVA: 0x0087BAD9 File Offset: 0x00879CD9
	public static void CreateStaticDefaultValue()
	{
		TsEntityDebugInfoManager.Instance = null;
	}

	// Token: 0x0601B855 RID: 112725 RVA: 0x0087BAE1 File Offset: 0x00879CE1
	public static void ResetStaticDefaultValue()
	{
		TsEntityDebugInfoManager.Instance = null;
	}

	// Token: 0x0601B856 RID: 112726 RVA: 0x0087BAE9 File Offset: 0x00879CE9
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

	// Token: 0x0601B857 RID: 112727 RVA: 0x0087BB18 File Offset: 0x00879D18
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual TArray<string> GetDebugEntityNameList()
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDebugEntityNameList"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetDebugEntityNameList_Implementation();
		}
		TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0601B858 RID: 112728 RVA: 0x0087BBAA File Offset: 0x00879DAA
	[NullableContext(1)]
	protected TArray<string> GetDebugEntityNameList_Implementation()
	{
		return EntityDebugUtils.Instance.GetDebugEntityNameList();
	}

	// Token: 0x0601B859 RID: 112729 RVA: 0x0087BBB8 File Offset: 0x00879DB8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int GetSelectedEntityId(string label)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetSelectedEntityId"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetSelectedEntityId_Implementation(label);
		}
		TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		FString.CopyFrom((void*)(&ptr->label), label);
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		int _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601B85A RID: 112730 RVA: 0x0087BC50 File Offset: 0x00879E50
	[NullableContext(1)]
	protected int GetSelectedEntityId_Implementation(string label)
	{
		return EntityDebugUtils.Instance.GetSelectedEntityId(label);
	}

	// Token: 0x0601B85B RID: 112731 RVA: 0x0087BC60 File Offset: 0x00879E60
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual float GetEntityTimeScale(int entityId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetEntityTimeScale"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetEntityTimeScale_Implementation(entityId);
		}
		TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		float _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601B85C RID: 112732 RVA: 0x0087BCF2 File Offset: 0x00879EF2
	protected float GetEntityTimeScale_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetEntityTimeScale(entityId);
	}

	// Token: 0x0601B85D RID: 112733 RVA: 0x0087BD00 File Offset: 0x00879F00
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void SetEntityTimeScale(int entityId, float timeScale)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("SetEntityTimeScale"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			this.SetEntityTimeScale_Implementation(entityId, timeScale);
			return;
		}
		TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		ptr->timeScale = timeScale;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x0601B85E RID: 112734 RVA: 0x0087BD94 File Offset: 0x00879F94
	protected void SetEntityTimeScale_Implementation(int entityId, float timeScale)
	{
		EntityDebugUtils.Instance.SetEntityTimeScale(entityId, timeScale);
	}

	// Token: 0x0601B85F RID: 112735 RVA: 0x0087BDA4 File Offset: 0x00879FA4
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual int GetEntityPbDataId(int entityId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetEntityPbDataId"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetEntityPbDataId_Implementation(entityId);
		}
		TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		int _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x0601B860 RID: 112736 RVA: 0x0087BE36 File Offset: 0x0087A036
	protected int GetEntityPbDataId_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetEntityPbDataId(entityId);
	}

	// Token: 0x0601B861 RID: 112737 RVA: 0x0087BE44 File Offset: 0x0087A044
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetInteractionDebugInfos(int entityId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetInteractionDebugInfos"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetInteractionDebugInfos_Implementation(entityId);
		}
		TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0601B862 RID: 112738 RVA: 0x0087BEDC File Offset: 0x0087A0DC
	[NullableContext(1)]
	protected string GetInteractionDebugInfos_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetInteractionDebugInfos(entityId);
	}

	// Token: 0x0601B863 RID: 112739 RVA: 0x0087BEEC File Offset: 0x0087A0EC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetEntityCommonTagDebugString(int entityId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetEntityCommonTagDebugString"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetEntityCommonTagDebugString_Implementation(entityId);
		}
		TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0601B864 RID: 112740 RVA: 0x0087BF84 File Offset: 0x0087A184
	[NullableContext(1)]
	protected string GetEntityCommonTagDebugString_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetEntityCommonTagDebugString(entityId);
	}

	// Token: 0x0601B865 RID: 112741 RVA: 0x0087BF94 File Offset: 0x0087A194
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual AActor GetDebugEntityActor(int entityId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDebugEntityActor"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetDebugEntityActor_Implementation(entityId);
		}
		TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ptr->__Result);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return orCreateUObjectByNativePointer;
	}

	// Token: 0x0601B866 RID: 112742 RVA: 0x0087C02B File Offset: 0x0087A22B
	[NullableContext(2)]
	protected AActor GetDebugEntityActor_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetDebugEntityActor(entityId);
	}

	// Token: 0x0601B867 RID: 112743 RVA: 0x0087C038 File Offset: 0x0087A238
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetDebugBaseInfo(int entityId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDebugBaseInfo"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetDebugBaseInfo_Implementation(entityId);
		}
		TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0601B868 RID: 112744 RVA: 0x0087C0D0 File Offset: 0x0087A2D0
	[NullableContext(1)]
	protected string GetDebugBaseInfo_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetDebugBaseInfo(entityId);
	}

	// Token: 0x0601B869 RID: 112745 RVA: 0x0087C0E0 File Offset: 0x0087A2E0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual string GetDebugEntityName(int entityId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(TsEntityDebugInfoManager) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("GetDebugEntityName"), TsEntityDebugInfoManager.StaticClass(), out intPtr, out num))
		{
			return this.GetDebugEntityName_Implementation(entityId);
		}
		TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams* ptr = stackalloc TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->entityId = entityId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		string result = FString.ToString((void*)(&ptr->__Result));
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return result;
	}

	// Token: 0x0601B86A RID: 112746 RVA: 0x0087C178 File Offset: 0x0087A378
	[NullableContext(2)]
	protected string GetDebugEntityName_Implementation(int entityId)
	{
		return EntityDebugUtils.Instance.GetDebugEntityName(entityId);
	}

	// Token: 0x0601B86B RID: 112747 RVA: 0x0087C185 File Offset: 0x0087A385
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (TsEntityDebugInfoManager._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/World/Debug/TsEntityDebugInfoManager.TsEntityDebugInfoManager_C");
		}
		return TsEntityDebugInfoManager._ClassPtr;
	}

	// Token: 0x0601B86C RID: 112748 RVA: 0x0087C1AC File Offset: 0x0087A3AC
	public TsEntityDebugInfoManager() : this(BuiltinUtils.AllocNativeUObject(TsEntityDebugInfoManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x0601B86D RID: 112749 RVA: 0x0087C1D4 File Offset: 0x0087A3D4
	[NullableContext(1)]
	public TsEntityDebugInfoManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsEntityDebugInfoManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601B86E RID: 112750 RVA: 0x0087C207 File Offset: 0x0087A407
	protected TsEntityDebugInfoManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601B86F RID: 112751 RVA: 0x0087C210 File Offset: 0x0087A410
	protected unsafe virtual void __CPPCALL_GetDebugEntityNameList_Implementation(TsEntityDebugInfoManager.__GetDebugEntityNameList_FunctionParams* __Params)
	{
		TArray<string> debugEntityNameList_Implementation = this.GetDebugEntityNameList_Implementation();
		if (debugEntityNameList_Implementation == null)
		{
			return;
		}
		debugEntityNameList_Implementation.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x0601B870 RID: 112752 RVA: 0x0087C240 File Offset: 0x0087A440
	protected unsafe virtual void __CPPCALL_GetSelectedEntityId_Implementation(TsEntityDebugInfoManager.__GetSelectedEntityId_FunctionParams* __Params)
	{
		string label = FString.ToString((void*)(&__Params->label));
		__Params->__Result = this.GetSelectedEntityId_Implementation(label);
	}

	// Token: 0x0601B871 RID: 112753 RVA: 0x0087C267 File Offset: 0x0087A467
	protected unsafe virtual void __CPPCALL_GetEntityTimeScale_Implementation(TsEntityDebugInfoManager.__GetEntityTimeScale_FunctionParams* __Params)
	{
		__Params->__Result = this.GetEntityTimeScale_Implementation(__Params->entityId);
	}

	// Token: 0x0601B872 RID: 112754 RVA: 0x0087C27B File Offset: 0x0087A47B
	protected unsafe virtual void __CPPCALL_SetEntityTimeScale_Implementation(TsEntityDebugInfoManager.__SetEntityTimeScale_FunctionParams* __Params)
	{
		this.SetEntityTimeScale_Implementation(__Params->entityId, __Params->timeScale);
	}

	// Token: 0x0601B873 RID: 112755 RVA: 0x0087C28F File Offset: 0x0087A48F
	protected unsafe virtual void __CPPCALL_GetEntityPbDataId_Implementation(TsEntityDebugInfoManager.__GetEntityPbDataId_FunctionParams* __Params)
	{
		__Params->__Result = this.GetEntityPbDataId_Implementation(__Params->entityId);
	}

	// Token: 0x0601B874 RID: 112756 RVA: 0x0087C2A3 File Offset: 0x0087A4A3
	protected unsafe virtual void __CPPCALL_GetInteractionDebugInfos_Implementation(TsEntityDebugInfoManager.__GetInteractionDebugInfos_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetInteractionDebugInfos_Implementation(__Params->entityId));
	}

	// Token: 0x0601B875 RID: 112757 RVA: 0x0087C2BD File Offset: 0x0087A4BD
	protected unsafe virtual void __CPPCALL_GetEntityCommonTagDebugString_Implementation(TsEntityDebugInfoManager.__GetEntityCommonTagDebugString_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetEntityCommonTagDebugString_Implementation(__Params->entityId));
	}

	// Token: 0x0601B876 RID: 112758 RVA: 0x0087C2D7 File Offset: 0x0087A4D7
	protected unsafe virtual void __CPPCALL_GetDebugEntityActor_Implementation(TsEntityDebugInfoManager.__GetDebugEntityActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		AActor debugEntityActor_Implementation = this.GetDebugEntityActor_Implementation(__Params->entityId);
		ptr = ((debugEntityActor_Implementation != null) ? debugEntityActor_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601B877 RID: 112759 RVA: 0x0087C2FA File Offset: 0x0087A4FA
	protected unsafe virtual void __CPPCALL_GetDebugBaseInfo_Implementation(TsEntityDebugInfoManager.__GetDebugBaseInfo_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetDebugBaseInfo_Implementation(__Params->entityId));
	}

	// Token: 0x0601B878 RID: 112760 RVA: 0x0087C314 File Offset: 0x0087A514
	protected unsafe virtual void __CPPCALL_GetDebugEntityName_Implementation(TsEntityDebugInfoManager.__GetDebugEntityName_FunctionParams* __Params)
	{
		FString.CopyFrom((void*)(&__Params->__Result), this.GetDebugEntityName_Implementation(__Params->entityId));
	}

	// Token: 0x0400EDE1 RID: 60897
	[Nullable(2)]
	private static TsEntityDebugInfoManager Instance;

	// Token: 0x0400EDE2 RID: 60898
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/World/Debug/TsEntityDebugInfoManager.TsEntityDebugInfoManager_C";

	// Token: 0x0400EDE3 RID: 60899
	private static IntPtr _ClassPtr;

	// Token: 0x0400EDE4 RID: 60900
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02008BC1 RID: 35777
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugEntityNameList_FunctionParams
	{
		// Token: 0x0402C457 RID: 181335
		[FieldOffset(0)]
		public byte __Result;
	}

	// Token: 0x02008BC2 RID: 35778
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSelectedEntityId_FunctionParams
	{
		// Token: 0x0402C458 RID: 181336
		[FieldOffset(0)]
		public FString label;

		// Token: 0x0402C459 RID: 181337
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02008BC3 RID: 35779
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetEntityTimeScale_FunctionParams
	{
		// Token: 0x0402C45A RID: 181338
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402C45B RID: 181339
		[FieldOffset(4)]
		public float __Result;
	}

	// Token: 0x02008BC4 RID: 35780
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SetEntityTimeScale_FunctionParams
	{
		// Token: 0x0402C45C RID: 181340
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402C45D RID: 181341
		[FieldOffset(4)]
		public float timeScale;
	}

	// Token: 0x02008BC5 RID: 35781
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __GetEntityPbDataId_FunctionParams
	{
		// Token: 0x0402C45E RID: 181342
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402C45F RID: 181343
		[FieldOffset(4)]
		public int __Result;
	}

	// Token: 0x02008BC6 RID: 35782
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetInteractionDebugInfos_FunctionParams
	{
		// Token: 0x0402C460 RID: 181344
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402C461 RID: 181345
		[FieldOffset(8)]
		public FString __Result;
	}

	// Token: 0x02008BC7 RID: 35783
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetEntityCommonTagDebugString_FunctionParams
	{
		// Token: 0x0402C462 RID: 181346
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402C463 RID: 181347
		[FieldOffset(8)]
		public FString __Result;
	}

	// Token: 0x02008BC8 RID: 35784
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetDebugEntityActor_FunctionParams
	{
		// Token: 0x0402C464 RID: 181348
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402C465 RID: 181349
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02008BC9 RID: 35785
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDebugBaseInfo_FunctionParams
	{
		// Token: 0x0402C466 RID: 181350
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402C467 RID: 181351
		[FieldOffset(8)]
		public FString __Result;
	}

	// Token: 0x02008BCA RID: 35786
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetDebugEntityName_FunctionParams
	{
		// Token: 0x0402C468 RID: 181352
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x0402C469 RID: 181353
		[FieldOffset(8)]
		public FString __Result;
	}
}
