using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using CSharpScript.Game.Module.Interaction;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x02000398 RID: 920
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBpBridge.LevelGeneralBpBridge_C")]
public class LevelGeneralBpBridge : UObject, IUnrealUObject, IUnrealObject
{
	// Token: 0x060032D5 RID: 13013 RVA: 0x00124CF4 File Offset: 0x00122EF4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool HandleCoditionInteractOption(SInteractionOption inInteractOptionConfig, string inInteractionConfigId, float inOptionIndex, AActor inTrigger)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(LevelGeneralBpBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("HandleCoditionInteractOption"), LevelGeneralBpBridge.StaticClass(), out intPtr, out num))
		{
			return this.HandleCoditionInteractOption_Implementation(inInteractOptionConfig, inInteractionConfigId, inOptionIndex, inTrigger);
		}
		LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams* ptr = stackalloc LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		UnrealReflectionUtils.CopyNativeStruct(SInteractionOption.StaticStruct(), &ptr->inInteractOptionConfig, (inInteractOptionConfig != null) ? inInteractOptionConfig.NativePtr : ((IntPtr)0), 1, false);
		FString.CopyFrom((void*)(&ptr->inInteractionConfigId), inInteractionConfigId);
		ptr->inOptionIndex = inOptionIndex;
		*(&ptr->inTrigger) = ((inTrigger != null) ? inTrigger.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		bool _Result = ptr->__Result;
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
		return _Result;
	}

	// Token: 0x060032D6 RID: 13014 RVA: 0x00124DCE File Offset: 0x00122FCE
	[NullableContext(1)]
	protected bool HandleCoditionInteractOption_Implementation(SInteractionOption inInteractOptionConfig, string inInteractionConfigId, float inOptionIndex, AActor inTrigger)
	{
		return false;
	}

	// Token: 0x060032D7 RID: 13015 RVA: 0x00124DD4 File Offset: 0x00122FD4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void TriggerLevelGeneralEvents(float inEventGroupId, AActor inTrigger)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(LevelGeneralBpBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("TriggerLevelGeneralEvents"), LevelGeneralBpBridge.StaticClass(), out intPtr, out num))
		{
			this.TriggerLevelGeneralEvents_Implementation(inEventGroupId, inTrigger);
			return;
		}
		LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams* ptr = stackalloc LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->inEventGroupId = inEventGroupId;
		*(&ptr->inTrigger) = ((inTrigger != null) ? inTrigger.NativePtr : ((IntPtr)0));
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060032D8 RID: 13016 RVA: 0x00124E76 File Offset: 0x00123076
	[NullableContext(1)]
	protected void TriggerLevelGeneralEvents_Implementation(float inEventGroupId, AActor inTrigger)
	{
	}

	// Token: 0x060032D9 RID: 13017 RVA: 0x00124E78 File Offset: 0x00123078
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void HandleConditionalEventListen(TMap<int, int> inTargetMap)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(LevelGeneralBpBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("HandleConditionalEventListen"), LevelGeneralBpBridge.StaticClass(), out intPtr, out num))
		{
			this.HandleConditionalEventListen_Implementation(inTargetMap);
			return;
		}
		LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams* ptr = stackalloc LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		if (inTargetMap != null)
		{
			inTargetMap.CopyTo(&ptr->inTargetMap, default(UScriptStructStackOnlyPtr));
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060032DA RID: 13018 RVA: 0x00124F16 File Offset: 0x00123116
	[NullableContext(1)]
	protected void HandleConditionalEventListen_Implementation(TMap<int, int> inTargetMap)
	{
	}

	// Token: 0x060032DB RID: 13019 RVA: 0x00124F18 File Offset: 0x00123118
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void HandleConditionPush(int inConditionGroupId)
	{
		IntPtr intPtr;
		int num;
		if (base.GetType() == typeof(LevelGeneralBpBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("HandleConditionPush"), LevelGeneralBpBridge.StaticClass(), out intPtr, out num))
		{
			this.HandleConditionPush_Implementation(inConditionGroupId);
			return;
		}
		LevelGeneralBpBridge.__HandleConditionPush_FunctionParams* ptr = stackalloc LevelGeneralBpBridge.__HandleConditionPush_FunctionParams[(UIntPtr)(num + 15)] + 15L / (long)sizeof(LevelGeneralBpBridge.__HandleConditionPush_FunctionParams) & -16L;
		UnrealReflectionUtils.InitializeStruct(intPtr, (void*)ptr, 1);
		ptr->inConditionGroupId = inConditionGroupId;
		UnrealReflectionUtils.CallUFunction(base.NativePtr, intPtr, (void*)ptr);
		UnrealReflectionUtils.DestroyStruct(intPtr, (void*)ptr, 1);
	}

	// Token: 0x060032DC RID: 13020 RVA: 0x00124FA4 File Offset: 0x001231A4
	protected void HandleConditionPush_Implementation(int inConditionGroupId)
	{
	}

	// Token: 0x060032DD RID: 13021 RVA: 0x00124FA8 File Offset: 0x001231A8
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void OpenInteractHints()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(LevelGeneralBpBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("OpenInteractHints"), LevelGeneralBpBridge.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.OpenInteractHints_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060032DE RID: 13022 RVA: 0x00125001 File Offset: 0x00123201
	protected void OpenInteractHints_Implementation()
	{
		TsInteractionUtils.OpenInteractHintView();
	}

	// Token: 0x060032DF RID: 13023 RVA: 0x0012500C File Offset: 0x0012320C
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public virtual void CloseInteractHints()
	{
		IntPtr nativeUFunctionPtr;
		int num;
		if (base.GetType() == typeof(LevelGeneralBpBridge) || !UnrealReflectionUtils.GetUFunctionPtrAndSizeAndNeedVirtualChecked(base.NativePtr, new FName("CloseInteractHints"), LevelGeneralBpBridge.StaticClass(), out nativeUFunctionPtr, out num))
		{
			this.CloseInteractHints_Implementation();
			return;
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, nativeUFunctionPtr, null);
	}

	// Token: 0x060032E0 RID: 13024 RVA: 0x00125065 File Offset: 0x00123265
	protected void CloseInteractHints_Implementation()
	{
		TsInteractionUtils.CloseInteractHintView("Unknown");
	}

	// Token: 0x060032E1 RID: 13025 RVA: 0x00125071 File Offset: 0x00123271
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LevelGeneralBpBridge._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBpBridge.LevelGeneralBpBridge_C");
		}
		return LevelGeneralBpBridge._ClassPtr;
	}

	// Token: 0x060032E2 RID: 13026 RVA: 0x00125098 File Offset: 0x00123298
	public LevelGeneralBpBridge() : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBpBridge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x060032E3 RID: 13027 RVA: 0x001250C0 File Offset: 0x001232C0
	[NullableContext(1)]
	public LevelGeneralBpBridge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBpBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x060032E4 RID: 13028 RVA: 0x001250F3 File Offset: 0x001232F3
	protected LevelGeneralBpBridge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x060032E5 RID: 13029 RVA: 0x001250FC File Offset: 0x001232FC
	protected unsafe virtual void __CPPCALL_HandleCoditionInteractOption_Implementation(LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams* __Params)
	{
		SInteractionOption inInteractOptionConfig = new SInteractionOption(&__Params->inInteractOptionConfig, true, true);
		string inInteractionConfigId = FString.ToString((void*)(&__Params->inInteractionConfigId));
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		__Params->__Result = this.HandleCoditionInteractOption_Implementation(inInteractOptionConfig, inInteractionConfigId, __Params->inOptionIndex, orCreateUObjectByNativePointer);
	}

	// Token: 0x060032E6 RID: 13030 RVA: 0x00125148 File Offset: 0x00123348
	protected unsafe virtual void __CPPCALL_TriggerLevelGeneralEvents_Implementation(LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		this.TriggerLevelGeneralEvents_Implementation(__Params->inEventGroupId, orCreateUObjectByNativePointer);
	}

	// Token: 0x060032E7 RID: 13031 RVA: 0x00125170 File Offset: 0x00123370
	protected unsafe virtual void __CPPCALL_HandleConditionalEventListen_Implementation(LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams* __Params)
	{
		TMap<int, int> inTargetMap = new TMap<int, int>(&__Params->inTargetMap, true, true);
		this.HandleConditionalEventListen_Implementation(inTargetMap);
	}

	// Token: 0x060032E8 RID: 13032 RVA: 0x00125193 File Offset: 0x00123393
	protected unsafe virtual void __CPPCALL_HandleConditionPush_Implementation(LevelGeneralBpBridge.__HandleConditionPush_FunctionParams* __Params)
	{
		this.HandleConditionPush_Implementation(__Params->inConditionGroupId);
	}

	// Token: 0x060032E9 RID: 13033 RVA: 0x001251A1 File Offset: 0x001233A1
	protected virtual void __CPPCALL_OpenInteractHints_Implementation()
	{
		this.OpenInteractHints_Implementation();
	}

	// Token: 0x060032EA RID: 13034 RVA: 0x001251A9 File Offset: 0x001233A9
	protected virtual void __CPPCALL_CloseInteractHints_Implementation()
	{
		this.CloseInteractHints_Implementation();
	}

	// Token: 0x04002BD2 RID: 11218
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBpBridge.LevelGeneralBpBridge_C";

	// Token: 0x04002BD3 RID: 11219
	private static IntPtr _ClassPtr;

	// Token: 0x04002BD4 RID: 11220
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020066D4 RID: 26324
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 288)]
	protected ref struct __HandleCoditionInteractOption_FunctionParams
	{
		// Token: 0x04021FBC RID: 139196
		[FieldOffset(0)]
		public byte inInteractOptionConfig;

		// Token: 0x04021FBD RID: 139197
		[FieldOffset(248)]
		public FString inInteractionConfigId;

		// Token: 0x04021FBE RID: 139198
		[FieldOffset(264)]
		public float inOptionIndex;

		// Token: 0x04021FBF RID: 139199
		[FieldOffset(272)]
		public IntPtr inTrigger;

		// Token: 0x04021FC0 RID: 139200
		[FieldOffset(280)]
		public bool __Result;
	}

	// Token: 0x020066D5 RID: 26325
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TriggerLevelGeneralEvents_FunctionParams
	{
		// Token: 0x04021FC1 RID: 139201
		[FieldOffset(0)]
		public float inEventGroupId;

		// Token: 0x04021FC2 RID: 139202
		[FieldOffset(8)]
		public IntPtr inTrigger;
	}

	// Token: 0x020066D6 RID: 26326
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __HandleConditionalEventListen_FunctionParams
	{
		// Token: 0x04021FC3 RID: 139203
		[FieldOffset(0)]
		public byte inTargetMap;
	}

	// Token: 0x020066D7 RID: 26327
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __HandleConditionPush_FunctionParams
	{
		// Token: 0x04021FC4 RID: 139204
		[FieldOffset(0)]
		public int inConditionGroupId;
	}
}
