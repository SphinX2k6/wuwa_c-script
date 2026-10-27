using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038AF RID: 14511
[NullableContext(1)]
[Nullable(0)]
public class __LevelGeneralBpBridge_SubClassMissingExportProxy : __LevelGeneralBpBridge_InheritProxy
{
	// Token: 0x0601EA6A RID: 125546 RVA: 0x00895B24 File Offset: 0x00893D24
	protected __LevelGeneralBpBridge_SubClassMissingExportProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBpBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA6B RID: 125547 RVA: 0x00895B57 File Offset: 0x00893D57
	protected __LevelGeneralBpBridge_SubClassMissingExportProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA6C RID: 125548 RVA: 0x00895B60 File Offset: 0x00893D60
	public unsafe override bool HandleCoditionInteractOption(SInteractionOption inInteractOptionConfig, string inInteractionConfigId, float inOptionIndex, AActor inTrigger)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		bool _Result = ptr2->__Result;
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		return _Result;
	}

	// Token: 0x0601EA6D RID: 125549 RVA: 0x00895C24 File Offset: 0x00893E24
	public unsafe override void TriggerLevelGeneralEvents(float inEventGroupId, AActor inTrigger)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA6E RID: 125550 RVA: 0x00895CB0 File Offset: 0x00893EB0
	public unsafe override void HandleConditionalEventListen(TMap<int, int> inTargetMap)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA6F RID: 125551 RVA: 0x00895D3C File Offset: 0x00893F3C
	public unsafe override void HandleConditionPush(int inConditionGroupId)
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
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA70 RID: 125552 RVA: 0x00895DB4 File Offset: 0x00893FB4
	public unsafe override void OpenInteractHints()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("OpenInteractHints"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}

	// Token: 0x0601EA71 RID: 125553 RVA: 0x00895E24 File Offset: 0x00894024
	public unsafe override void CloseInteractHints()
	{
		int num;
		IntPtr ufunctionPtrAndSizeChecked = UnrealReflectionUtils.GetUFunctionPtrAndSizeChecked(base.NativePtr, new FName("CloseInteractHints"), out num);
		byte* ptr = stackalloc byte[(UIntPtr)((num != 0) ? (num + 15) : 0)];
		byte* ptr2 = null;
		if (num != 0)
		{
			ptr2 = (ptr + 15L & -16L);
			UnrealReflectionUtils.InitializeStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
		UnrealReflectionUtils.CallUFunction(base.NativePtr, ufunctionPtrAndSizeChecked, (void*)ptr2, 0);
		if (num != 0)
		{
			UnrealReflectionUtils.DestroyStruct(ufunctionPtrAndSizeChecked, (void*)ptr2, 1);
		}
	}
}
