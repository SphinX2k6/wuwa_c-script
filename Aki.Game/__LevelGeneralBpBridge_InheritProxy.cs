using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020038AE RID: 14510
public class __LevelGeneralBpBridge_InheritProxy : LevelGeneralBpBridge
{
	// Token: 0x0601EA62 RID: 125538 RVA: 0x00895A30 File Offset: 0x00893C30
	[NullableContext(1)]
	public __LevelGeneralBpBridge_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBpBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EA63 RID: 125539 RVA: 0x00895A63 File Offset: 0x00893C63
	protected __LevelGeneralBpBridge_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EA64 RID: 125540 RVA: 0x00895A6C File Offset: 0x00893C6C
	protected unsafe override void __CPPCALL_HandleCoditionInteractOption_Implementation(LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams* __Params)
	{
		SInteractionOption inInteractOptionConfig = new SInteractionOption(&__Params->inInteractOptionConfig, true, true);
		string inInteractionConfigId = FString.ToString((void*)(&__Params->inInteractionConfigId));
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		__Params->__Result = base.HandleCoditionInteractOption_Implementation(inInteractOptionConfig, inInteractionConfigId, __Params->inOptionIndex, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EA65 RID: 125541 RVA: 0x00895AB8 File Offset: 0x00893CB8
	protected unsafe override void __CPPCALL_TriggerLevelGeneralEvents_Implementation(LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		base.TriggerLevelGeneralEvents_Implementation(__Params->inEventGroupId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EA66 RID: 125542 RVA: 0x00895AE0 File Offset: 0x00893CE0
	protected unsafe override void __CPPCALL_HandleConditionalEventListen_Implementation(LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams* __Params)
	{
		TMap<int, int> inTargetMap = new TMap<int, int>(&__Params->inTargetMap, true, true);
		base.HandleConditionalEventListen_Implementation(inTargetMap);
	}

	// Token: 0x0601EA67 RID: 125543 RVA: 0x00895B03 File Offset: 0x00893D03
	protected unsafe override void __CPPCALL_HandleConditionPush_Implementation(LevelGeneralBpBridge.__HandleConditionPush_FunctionParams* __Params)
	{
		base.HandleConditionPush_Implementation(__Params->inConditionGroupId);
	}

	// Token: 0x0601EA68 RID: 125544 RVA: 0x00895B11 File Offset: 0x00893D11
	protected override void __CPPCALL_OpenInteractHints_Implementation()
	{
		base.OpenInteractHints_Implementation();
	}

	// Token: 0x0601EA69 RID: 125545 RVA: 0x00895B19 File Offset: 0x00893D19
	protected override void __CPPCALL_CloseInteractHints_Implementation()
	{
		base.CloseInteractHints_Implementation();
	}
}
