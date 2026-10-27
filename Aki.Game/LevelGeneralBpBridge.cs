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

// Token: 0x02000EE3 RID: 3811
[UClass("/Game/Aki/TypeScript/Game/LevelGamePlay/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBpBridge.LevelGeneralBpBridge_C")]
public class LevelGeneralBpBridge : UObject, IUnrealUObject, IUnrealObject
{
	// Token: 0x06005F3F RID: 24383 RVA: 0x0011CFA4 File Offset: 0x0011B1A4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual bool HandleCoditionInteractOption(SInteractionOption inInteractOptionConfig, string inInteractionConfigId, float inOptionIndex, AActor inTrigger)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("HandleCoditionInteractOption"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams*)ptr + 15L / (long)sizeof(LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			UnrealReflectionUtils.CopyNativeStruct(SInteractionOption.StaticStruct(), &ptr2->inInteractOptionConfig, (inInteractOptionConfig != null) ? inInteractOptionConfig.NativePtr : ((IntPtr)0), 1, false);
			FString.CopyFrom((void*)(&ptr2->inInteractionConfigId), inInteractionConfigId);
			ptr2->inOptionIndex = inOptionIndex;
			*(&ptr2->inTrigger) = ((inTrigger != null) ? inTrigger.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x06005F40 RID: 24384 RVA: 0x0011D064 File Offset: 0x0011B264
	[NullableContext(1)]
	protected bool HandleCoditionInteractOption_Implementation(SInteractionOption inInteractOptionConfig, string inInteractionConfigId, float inOptionIndex, AActor inTrigger)
	{
		return false;
	}

	// Token: 0x06005F41 RID: 24385 RVA: 0x0011D068 File Offset: 0x0011B268
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void TriggerLevelGeneralEvents(float inEventGroupId, AActor inTrigger)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("TriggerLevelGeneralEvents"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams*)ptr + 15L / (long)sizeof(LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->inEventGroupId = inEventGroupId;
			*(&ptr2->inTrigger) = ((inTrigger != null) ? inTrigger.NativePtr : ((IntPtr)0));
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005F42 RID: 24386 RVA: 0x0011D0F3 File Offset: 0x0011B2F3
	[NullableContext(1)]
	protected void TriggerLevelGeneralEvents_Implementation(float inEventGroupId, AActor inTrigger)
	{
	}

	// Token: 0x06005F43 RID: 24387 RVA: 0x0011D0F8 File Offset: 0x0011B2F8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void HandleConditionalEventListen(TMap<int, int> inTargetMap)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("HandleConditionalEventListen"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams*)ptr + 15L / (long)sizeof(LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			if (inTargetMap != null)
			{
				inTargetMap.CopyTo(&ptr2->inTargetMap, default(UScriptStructStackOnlyPtr));
			}
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005F44 RID: 24388 RVA: 0x0011D181 File Offset: 0x0011B381
	[NullableContext(1)]
	protected void HandleConditionalEventListen_Implementation(TMap<int, int> inTargetMap)
	{
	}

	// Token: 0x06005F45 RID: 24389 RVA: 0x0011D184 File Offset: 0x0011B384
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void HandleConditionPush(int inConditionGroupId)
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("HandleConditionPush"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		LevelGeneralBpBridge.__HandleConditionPush_FunctionParams* ptr2 = null;
		if (num != 0)
		{
			ptr2 = ((LevelGeneralBpBridge.__HandleConditionPush_FunctionParams*)ptr + 15L / (long)sizeof(LevelGeneralBpBridge.__HandleConditionPush_FunctionParams) & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
			ptr2->inConditionGroupId = inConditionGroupId;
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x06005F46 RID: 24390 RVA: 0x0011D1FA File Offset: 0x0011B3FA
	protected void HandleConditionPush_Implementation(int inConditionGroupId)
	{
	}

	// Token: 0x06005F47 RID: 24391 RVA: 0x0011D1FC File Offset: 0x0011B3FC
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void OpenInteractHints()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OpenInteractHints"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06005F48 RID: 24392 RVA: 0x0011D26C File Offset: 0x0011B46C
	protected void OpenInteractHints_Implementation()
	{
		TsInteractionUtils.OpenInteractHintView();
	}

	// Token: 0x06005F49 RID: 24393 RVA: 0x0011D274 File Offset: 0x0011B474
	[UFunction(EFunctionFlags.FUNC_BlueprintNativeEvent)]
	public unsafe virtual void CloseInteractHints()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("CloseInteractHints"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* dest = null;
		if (num != 0)
		{
			dest = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
		UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, null);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)dest, 1);
		}
	}

	// Token: 0x06005F4A RID: 24394 RVA: 0x0011D2E4 File Offset: 0x0011B4E4
	protected void CloseInteractHints_Implementation()
	{
		TsInteractionUtils.CloseInteractHintView("Unknown");
	}

	// Token: 0x06005F4B RID: 24395 RVA: 0x0011D2F0 File Offset: 0x0011B4F0
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (LevelGeneralBpBridge._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBpBridge.LevelGeneralBpBridge_C");
		}
		return LevelGeneralBpBridge._ClassPtr;
	}

	// Token: 0x06005F4C RID: 24396 RVA: 0x0011D314 File Offset: 0x0011B514
	public LevelGeneralBpBridge() : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBpBridge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06005F4D RID: 24397 RVA: 0x0011D33C File Offset: 0x0011B53C
	[NullableContext(1)]
	public LevelGeneralBpBridge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBpBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06005F4E RID: 24398 RVA: 0x0011D36F File Offset: 0x0011B56F
	protected LevelGeneralBpBridge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06005F4F RID: 24399 RVA: 0x0011D378 File Offset: 0x0011B578
	protected unsafe virtual void __CPPCALL_HandleCoditionInteractOption_Implementation(LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams* __Params)
	{
		SInteractionOption inInteractOptionConfig = new SInteractionOption(&__Params->inInteractOptionConfig, true, true);
		string inInteractionConfigId = FString.ToString((void*)(&__Params->inInteractionConfigId));
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		__Params->__Result = this.HandleCoditionInteractOption_Implementation(inInteractOptionConfig, inInteractionConfigId, __Params->inOptionIndex, orCreateUObjectByNativePointer);
	}

	// Token: 0x06005F50 RID: 24400 RVA: 0x0011D3C4 File Offset: 0x0011B5C4
	protected unsafe virtual void __CPPCALL_TriggerLevelGeneralEvents_Implementation(LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		this.TriggerLevelGeneralEvents_Implementation(__Params->inEventGroupId, orCreateUObjectByNativePointer);
	}

	// Token: 0x06005F51 RID: 24401 RVA: 0x0011D3EC File Offset: 0x0011B5EC
	protected unsafe virtual void __CPPCALL_HandleConditionalEventListen_Implementation(LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams* __Params)
	{
		TMap<int, int> inTargetMap = new TMap<int, int>(&__Params->inTargetMap, true, true);
		this.HandleConditionalEventListen_Implementation(inTargetMap);
	}

	// Token: 0x06005F52 RID: 24402 RVA: 0x0011D40F File Offset: 0x0011B60F
	protected unsafe virtual void __CPPCALL_HandleConditionPush_Implementation(LevelGeneralBpBridge.__HandleConditionPush_FunctionParams* __Params)
	{
		this.HandleConditionPush_Implementation(__Params->inConditionGroupId);
	}

	// Token: 0x06005F53 RID: 24403 RVA: 0x0011D41D File Offset: 0x0011B61D
	protected virtual void __CPPCALL_OpenInteractHints_Implementation()
	{
		this.OpenInteractHints_Implementation();
	}

	// Token: 0x06005F54 RID: 24404 RVA: 0x0011D425 File Offset: 0x0011B625
	protected virtual void __CPPCALL_CloseInteractHints_Implementation()
	{
		this.CloseInteractHints_Implementation();
	}

	// Token: 0x04002B38 RID: 11064
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/LevelGamePlay/LevelGeneralBpBridge.LevelGeneralBpBridge_C";

	// Token: 0x04002B39 RID: 11065
	private static IntPtr _ClassPtr;

	// Token: 0x04002B3A RID: 11066
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02007540 RID: 30016
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 288)]
	protected ref struct __HandleCoditionInteractOption_FunctionParams
	{
		// Token: 0x04026C71 RID: 158833
		[FieldOffset(0)]
		public byte inInteractOptionConfig;

		// Token: 0x04026C72 RID: 158834
		[FieldOffset(248)]
		public FString inInteractionConfigId;

		// Token: 0x04026C73 RID: 158835
		[FieldOffset(264)]
		public float inOptionIndex;

		// Token: 0x04026C74 RID: 158836
		[FieldOffset(272)]
		public IntPtr inTrigger;

		// Token: 0x04026C75 RID: 158837
		[FieldOffset(280)]
		public bool __Result;
	}

	// Token: 0x02007541 RID: 30017
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __TriggerLevelGeneralEvents_FunctionParams
	{
		// Token: 0x04026C76 RID: 158838
		[FieldOffset(0)]
		public float inEventGroupId;

		// Token: 0x04026C77 RID: 158839
		[FieldOffset(8)]
		public IntPtr inTrigger;
	}

	// Token: 0x02007542 RID: 30018
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 80)]
	protected ref struct __HandleConditionalEventListen_FunctionParams
	{
		// Token: 0x04026C78 RID: 158840
		[FieldOffset(0)]
		public byte inTargetMap;
	}

	// Token: 0x02007543 RID: 30019
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	protected ref struct __HandleConditionPush_FunctionParams
	{
		// Token: 0x04026C79 RID: 158841
		[FieldOffset(0)]
		public int inConditionGroupId;
	}
}
