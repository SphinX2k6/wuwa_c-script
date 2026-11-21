using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002C57 RID: 11351
public class __TsAiController_InheritProxy : TsAiController
{
	// Token: 0x0601C108 RID: 114952 RVA: 0x008ADA8C File Offset: 0x008ABC8C
	[NullableContext(1)]
	public __TsAiController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C109 RID: 114953 RVA: 0x008ADABF File Offset: 0x008ABCBF
	protected __TsAiController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C10A RID: 114954 RVA: 0x008ADAC8 File Offset: 0x008ABCC8
	protected override void __CPPCALL_OnStart_Implementation()
	{
		base.OnStart_Implementation();
	}

	// Token: 0x0601C10B RID: 114955 RVA: 0x008ADAD0 File Offset: 0x008ABCD0
	protected override void __CPPCALL_获取控制权时_Implementation()
	{
		base.获取控制权时_Implementation();
	}

	// Token: 0x0601C10C RID: 114956 RVA: 0x008ADAD8 File Offset: 0x008ABCD8
	protected unsafe override void __CPPCALL_状态切换时_Implementation(TsAiController.__状态切换时_FunctionParams* __Params)
	{
		ECharacterState oldState = (ECharacterState)__Params->oldState;
		ECharacterState newState = (ECharacterState)__Params->newState;
		base.状态切换时_Implementation(oldState, newState, __Params->isAutonomousProxy);
	}

	// Token: 0x0601C10D RID: 114957 RVA: 0x008ADB01 File Offset: 0x008ABD01
	protected unsafe override void __CPPCALL_渲染状态改变时_Implementation(TsAiController.__渲染状态改变时_FunctionParams* __Params)
	{
		base.渲染状态改变时_Implementation(__Params->wasRendered);
	}

	// Token: 0x0601C10E RID: 114958 RVA: 0x008ADB10 File Offset: 0x008ABD10
	protected unsafe override void __CPPCALL_AddComplicatedEventBinder_Implementation(TsAiController.__AddComplicatedEventBinder_FunctionParams* __Params)
	{
		SAiConditions conditions = new SAiConditions(&__Params->conditions, true, true);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		base.AddComplicatedEventBinder_Implementation(conditions, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C10F RID: 114959 RVA: 0x008ADB40 File Offset: 0x008ABD40
	protected unsafe override void __CPPCALL_AddSceneItemDestroyEventBinder_Implementation(TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams* __Params)
	{
		UKuroActorEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroActorEventBinder>(__Params->eventBinder);
		base.AddSceneItemDestroyEventBinder_Implementation(__Params->distance, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C110 RID: 114960 RVA: 0x008ADB68 File Offset: 0x008ABD68
	protected unsafe override void __CPPCALL_AddLevelVarBoolEventBinder_Implementation(TsAiController.__AddLevelVarBoolEventBinder_FunctionParams* __Params)
	{
		SAiLevelVar levelVar = new SAiLevelVar(&__Params->levelVar, true, true);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		base.AddLevelVarBoolEventBinder_Implementation(levelVar, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C111 RID: 114961 RVA: 0x008ADB98 File Offset: 0x008ABD98
	protected unsafe override void __CPPCALL_AddLevelVarIntEventBinder_Implementation(TsAiController.__AddLevelVarIntEventBinder_FunctionParams* __Params)
	{
		SAiLevelVar levelVar = new SAiLevelVar(&__Params->levelVar, true, true);
		UKuroIntEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroIntEventBinder>(__Params->eventBinder);
		base.AddLevelVarIntEventBinder_Implementation(levelVar, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C112 RID: 114962 RVA: 0x008ADBC8 File Offset: 0x008ABDC8
	protected unsafe override void __CPPCALL_AddHateEventBinder_Implementation(TsAiController.__AddHateEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		base.AddHateEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C113 RID: 114963 RVA: 0x008ADBE8 File Offset: 0x008ABDE8
	protected unsafe override void __CPPCALL_AddPerceptionEventBinder_Implementation(TsAiController.__AddPerceptionEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		base.AddPerceptionEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C114 RID: 114964 RVA: 0x008ADC08 File Offset: 0x008ABE08
	protected unsafe override void __CPPCALL_SetPerceptionEventState_Implementation(TsAiController.__SetPerceptionEventState_FunctionParams* __Params)
	{
		base.SetPerceptionEventState_Implementation(__Params->includeFriend, __Params->includeEnemy, __Params->includeNeutral);
	}

	// Token: 0x0601C115 RID: 114965 RVA: 0x008ADC24 File Offset: 0x008ABE24
	protected unsafe override void __CPPCALL_AddHateOutRangeEventBinder_Implementation(TsAiController.__AddHateOutRangeEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		base.AddHateOutRangeEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C116 RID: 114966 RVA: 0x008ADC44 File Offset: 0x008ABE44
	protected unsafe override void __CPPCALL_ActivateSkillGroup_Implementation(TsAiController.__ActivateSkillGroup_FunctionParams* __Params)
	{
		base.ActivateSkillGroup_Implementation(__Params->skillGroupIndex, __Params->activate);
	}

	// Token: 0x0601C117 RID: 114967 RVA: 0x008ADC58 File Offset: 0x008ABE58
	protected unsafe override void __CPPCALL_AddSkillCd_Implementation(TsAiController.__AddSkillCd_FunctionParams* __Params)
	{
		base.AddSkillCd_Implementation(__Params->skillInfoId, __Params->cdAdd);
	}

	// Token: 0x0601C118 RID: 114968 RVA: 0x008ADC6C File Offset: 0x008ABE6C
	protected unsafe override void __CPPCALL_AicApplyBuff_Implementation(TsAiController.__AicApplyBuff_FunctionParams* __Params)
	{
		base.AicApplyBuff_Implementation(__Params->buffId);
	}

	// Token: 0x0601C119 RID: 114969 RVA: 0x008ADC7A File Offset: 0x008ABE7A
	protected unsafe override void __CPPCALL_AicApplyBuffToTarget_Implementation(TsAiController.__AicApplyBuffToTarget_FunctionParams* __Params)
	{
		base.AicApplyBuffToTarget_Implementation(__Params->targetId, __Params->buffId);
	}

	// Token: 0x0601C11A RID: 114970 RVA: 0x008ADC8E File Offset: 0x008ABE8E
	protected unsafe override void __CPPCALL_AicRemoveBuff_Implementation(TsAiController.__AicRemoveBuff_FunctionParams* __Params)
	{
		base.AicRemoveBuff_Implementation(__Params->buffId);
	}

	// Token: 0x0601C11B RID: 114971 RVA: 0x008ADC9C File Offset: 0x008ABE9C
	protected unsafe override void __CPPCALL_AicAddTag_Implementation(TsAiController.__AicAddTag_FunctionParams* __Params)
	{
		base.AicAddTag_Implementation(__Params->tag);
	}

	// Token: 0x0601C11C RID: 114972 RVA: 0x008ADCAA File Offset: 0x008ABEAA
	protected unsafe override void __CPPCALL_AicRemoveTag_Implementation(TsAiController.__AicRemoveTag_FunctionParams* __Params)
	{
		base.AicRemoveTag_Implementation(__Params->tag);
	}

	// Token: 0x0601C11D RID: 114973 RVA: 0x008ADCB8 File Offset: 0x008ABEB8
	protected unsafe override void __CPPCALL_SetBattleWanderTime_Implementation(TsAiController.__SetBattleWanderTime_FunctionParams* __Params)
	{
		base.SetBattleWanderTime_Implementation(__Params->min, __Params->max);
	}

	// Token: 0x0601C11E RID: 114974 RVA: 0x008ADCCC File Offset: 0x008ABECC
	protected unsafe override void __CPPCALL_SetBattleWanderIndex_Implementation(TsAiController.__SetBattleWanderIndex_FunctionParams* __Params)
	{
		base.SetBattleWanderIndex_Implementation(__Params->index);
	}

	// Token: 0x0601C11F RID: 114975 RVA: 0x008ADCDA File Offset: 0x008ABEDA
	protected unsafe override void __CPPCALL_AddBattleWanderEndTime_Implementation(TsAiController.__AddBattleWanderEndTime_FunctionParams* __Params)
	{
		base.AddBattleWanderEndTime_Implementation(__Params->addTime);
	}

	// Token: 0x0601C120 RID: 114976 RVA: 0x008ADCE8 File Offset: 0x008ABEE8
	protected unsafe override void __CPPCALL_SetAiSenseEnable_Implementation(TsAiController.__SetAiSenseEnable_FunctionParams* __Params)
	{
		base.SetAiSenseEnable_Implementation(__Params->index, __Params->enable);
	}

	// Token: 0x0601C121 RID: 114977 RVA: 0x008ADCFC File Offset: 0x008ABEFC
	protected unsafe override void __CPPCALL_AddOrRemoveAiSense_Implementation(TsAiController.__AddOrRemoveAiSense_FunctionParams* __Params)
	{
		base.AddOrRemoveAiSense_Implementation(__Params->aiSenseId, __Params->add);
	}

	// Token: 0x0601C122 RID: 114978 RVA: 0x008ADD10 File Offset: 0x008ABF10
	protected unsafe override void __CPPCALL_EnableAiSenseByType_Implementation(TsAiController.__EnableAiSenseByType_FunctionParams* __Params)
	{
		base.EnableAiSenseByType_Implementation(__Params->type, __Params->enable);
	}

	// Token: 0x0601C123 RID: 114979 RVA: 0x008ADD24 File Offset: 0x008ABF24
	protected unsafe override void __CPPCALL_SetAiHateConfig_Implementation(TsAiController.__SetAiHateConfig_FunctionParams* __Params)
	{
		string aiHateConfig_Implementation = FString.ToString((void*)(&__Params->configId));
		base.SetAiHateConfig_Implementation(aiHateConfig_Implementation);
	}

	// Token: 0x0601C124 RID: 114980 RVA: 0x008ADD45 File Offset: 0x008ABF45
	protected unsafe override void __CPPCALL_ChangeHatred_Implementation(TsAiController.__ChangeHatred_FunctionParams* __Params)
	{
		base.ChangeHatred_Implementation(__Params->entityId, __Params->rate, __Params->abs);
	}

	// Token: 0x0601C125 RID: 114981 RVA: 0x008ADD5F File Offset: 0x008ABF5F
	protected unsafe override void __CPPCALL_ClearHatred_Implementation(TsAiController.__ClearHatred_FunctionParams* __Params)
	{
		base.ClearHatred_Implementation(__Params->entityId);
	}

	// Token: 0x0601C126 RID: 114982 RVA: 0x008ADD6D File Offset: 0x008ABF6D
	protected override void __CPPCALL_BindPlayerDamageEvents_Implementation()
	{
		base.BindPlayerDamageEvents_Implementation();
	}

	// Token: 0x0601C127 RID: 114983 RVA: 0x008ADD78 File Offset: 0x008ABF78
	protected unsafe override void __CPPCALL_AddAlertEventBinder_Implementation(TsAiController.__AddAlertEventBinder_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		base.AddAlertEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C128 RID: 114984 RVA: 0x008ADD98 File Offset: 0x008ABF98
	protected unsafe override void __CPPCALL_SetAiAlertConfig_Implementation(TsAiController.__SetAiAlertConfig_FunctionParams* __Params)
	{
		string aiAlertConfig_Implementation = FString.ToString((void*)(&__Params->configId));
		base.SetAiAlertConfig_Implementation(aiAlertConfig_Implementation);
	}

	// Token: 0x0601C129 RID: 114985 RVA: 0x008ADDBC File Offset: 0x008ABFBC
	protected unsafe override void __CPPCALL_SetAiEnable_Implementation(TsAiController.__SetAiEnable_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		base.SetAiEnable_Implementation(__Params->enable, key);
	}

	// Token: 0x0601C12A RID: 114986 RVA: 0x008ADDE4 File Offset: 0x008ABFE4
	protected unsafe override void __CPPCALL_TestChangeAi_Implementation(TsAiController.__TestChangeAi_FunctionParams* __Params)
	{
		string id = FString.ToString((void*)(&__Params->id));
		base.TestChangeAi_Implementation(id);
	}

	// Token: 0x0601C12B RID: 114987 RVA: 0x008ADE05 File Offset: 0x008AC005
	protected unsafe override void __CPPCALL_LogReport_Implementation(TsAiController.__LogReport_FunctionParams* __Params)
	{
		base.LogReport_Implementation(__Params->logId);
	}

	// Token: 0x0601C12C RID: 114988 RVA: 0x008ADE13 File Offset: 0x008AC013
	protected unsafe override void __CPPCALL_逻辑主控_Implementation(TsAiController.__逻辑主控_FunctionParams* __Params)
	{
		__Params->__Result = base.逻辑主控_Implementation();
	}

	// Token: 0x0601C12D RID: 114989 RVA: 0x008ADE21 File Offset: 0x008AC021
	protected unsafe override void __CPPCALL_移动主控_Implementation(TsAiController.__移动主控_FunctionParams* __Params)
	{
		__Params->__Result = base.移动主控_Implementation();
	}

	// Token: 0x0601C12E RID: 114990 RVA: 0x008ADE30 File Offset: 0x008AC030
	protected unsafe override void __CPPCALL_检查状态机状态_Implementation(TsAiController.__检查状态机状态_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->states, true, true);
		__Params->__Result = base.检查状态机状态_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->states, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601C12F RID: 114991 RVA: 0x008ADE74 File Offset: 0x008AC074
	protected unsafe override void __CPPCALL_切换状态机状态_Implementation(TsAiController.__切换状态机状态_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->states, true, true);
		base.切换状态机状态_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->states, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601C130 RID: 114992 RVA: 0x008ADEB1 File Offset: 0x008AC0B1
	protected unsafe override void __CPPCALL_GetCoolDownDone_Implementation(TsAiController.__GetCoolDownDone_FunctionParams* __Params)
	{
		__Params->__Result = base.GetCoolDownDone_Implementation(__Params->id);
	}

	// Token: 0x0601C131 RID: 114993 RVA: 0x008ADEC5 File Offset: 0x008AC0C5
	protected unsafe override void __CPPCALL_GetCoolDownRemainTime_Implementation(TsAiController.__GetCoolDownRemainTime_FunctionParams* __Params)
	{
		__Params->__Result = base.GetCoolDownRemainTime_Implementation(__Params->id);
	}

	// Token: 0x0601C132 RID: 114994 RVA: 0x008ADED9 File Offset: 0x008AC0D9
	protected unsafe override void __CPPCALL_SetCoolDown_Implementation(TsAiController.__SetCoolDown_FunctionParams* __Params)
	{
		base.SetCoolDown_Implementation(__Params->id, __Params->cd);
	}

	// Token: 0x0601C133 RID: 114995 RVA: 0x008ADEF0 File Offset: 0x008AC0F0
	protected unsafe override void __CPPCALL_InitCooldownEvent_Implementation(TsAiController.__InitCooldownEvent_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		base.InitCooldownEvent_Implementation(__Params->id, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C134 RID: 114996 RVA: 0x008ADF16 File Offset: 0x008AC116
	protected unsafe override void __CPPCALL_StartCooldownTimer_Implementation(TsAiController.__StartCooldownTimer_FunctionParams* __Params)
	{
		base.StartCooldownTimer_Implementation(__Params->id, __Params->duration);
	}

	// Token: 0x0601C135 RID: 114997 RVA: 0x008ADF2C File Offset: 0x008AC12C
	protected unsafe override void __CPPCALL_GetDebugStateMachine_Implementation(TsAiController.__GetDebugStateMachine_FunctionParams* __Params)
	{
		TArray<FText> tarray = new TArray<FText>(&__Params->output, true, true);
		base.GetDebugStateMachine_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->output, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601C136 RID: 114998 RVA: 0x008ADF69 File Offset: 0x008AC169
	protected unsafe override void __CPPCALL_GetDebugText_Implementation(TsAiController.__GetDebugText_FunctionParams* __Params)
	{
		void* dest = (void*)(&__Params->__Result);
		FText debugText_Implementation = base.GetDebugText_Implementation();
		FText.NativeCopy(dest, (debugText_Implementation != null) ? debugText_Implementation.NativePtr : null, 1);
	}

	// Token: 0x0601C137 RID: 114999 RVA: 0x008ADF8B File Offset: 0x008AC18B
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}
}
