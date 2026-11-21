using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Interaction.Struct;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002E27 RID: 11815
public class __LevelGeneralBpBridge_InheritProxy : LevelGeneralBpBridge
{
	// Token: 0x0601C73C RID: 116540 RVA: 0x008BAF38 File Offset: 0x008B9138
	[NullableContext(1)]
	public __LevelGeneralBpBridge_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(LevelGeneralBpBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C73D RID: 116541 RVA: 0x008BAF6B File Offset: 0x008B916B
	protected __LevelGeneralBpBridge_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C73E RID: 116542 RVA: 0x008BAF74 File Offset: 0x008B9174
	protected unsafe override void __CPPCALL_HandleCoditionInteractOption_Implementation(LevelGeneralBpBridge.__HandleCoditionInteractOption_FunctionParams* __Params)
	{
		SInteractionOption inInteractOptionConfig = new SInteractionOption(&__Params->inInteractOptionConfig, true, true);
		string inInteractionConfigId = FString.ToString((void*)(&__Params->inInteractionConfigId));
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		__Params->__Result = base.HandleCoditionInteractOption_Implementation(inInteractOptionConfig, inInteractionConfigId, __Params->inOptionIndex, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C73F RID: 116543 RVA: 0x008BAFC0 File Offset: 0x008B91C0
	protected unsafe override void __CPPCALL_TriggerLevelGeneralEvents_Implementation(LevelGeneralBpBridge.__TriggerLevelGeneralEvents_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->inTrigger);
		base.TriggerLevelGeneralEvents_Implementation(__Params->inEventGroupId, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C740 RID: 116544 RVA: 0x008BAFE8 File Offset: 0x008B91E8
	protected unsafe override void __CPPCALL_HandleConditionalEventListen_Implementation(LevelGeneralBpBridge.__HandleConditionalEventListen_FunctionParams* __Params)
	{
		TMap<int, int> inTargetMap = new TMap<int, int>(&__Params->inTargetMap, true, true);
		base.HandleConditionalEventListen_Implementation(inTargetMap);
	}

	// Token: 0x0601C741 RID: 116545 RVA: 0x008BB00B File Offset: 0x008B920B
	protected unsafe override void __CPPCALL_HandleConditionPush_Implementation(LevelGeneralBpBridge.__HandleConditionPush_FunctionParams* __Params)
	{
		base.HandleConditionPush_Implementation(__Params->inConditionGroupId);
	}

	// Token: 0x0601C742 RID: 116546 RVA: 0x008BB019 File Offset: 0x008B9219
	protected override void __CPPCALL_OpenInteractHints_Implementation()
	{
		base.OpenInteractHints_Implementation();
	}

	// Token: 0x0601C743 RID: 116547 RVA: 0x008BB021 File Offset: 0x008B9221
	protected override void __CPPCALL_CloseInteractHints_Implementation()
	{
		base.CloseInteractHints_Implementation();
	}
}
