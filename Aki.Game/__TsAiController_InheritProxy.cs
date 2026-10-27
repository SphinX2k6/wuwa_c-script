using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Monster.Common;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020036E2 RID: 14050
public class __TsAiController_InheritProxy : TsAiController
{
	// Token: 0x0601E3F2 RID: 123890 RVA: 0x00886204 File Offset: 0x00884404
	[NullableContext(1)]
	public __TsAiController_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(TsAiController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601E3F3 RID: 123891 RVA: 0x00886237 File Offset: 0x00884437
	protected __TsAiController_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601E3F4 RID: 123892 RVA: 0x00886240 File Offset: 0x00884440
	protected override void __CPPCALL_OnStart_Implementation()
	{
		base.OnStart_Implementation();
	}

	// Token: 0x0601E3F5 RID: 123893 RVA: 0x00886248 File Offset: 0x00884448
	protected override void __CPPCALL_获取控制权时_Implementation()
	{
		base.获取控制权时_Implementation();
	}

	// Token: 0x0601E3F6 RID: 123894 RVA: 0x00886250 File Offset: 0x00884450
	protected unsafe override void __CPPCALL_状态切换时_Implementation(TsAiController.__状态切换时_FunctionParams* __Params)
	{
		ECharacterState oldState = (ECharacterState)__Params->oldState;
		ECharacterState newState = (ECharacterState)__Params->newState;
		base.状态切换时_Implementation(oldState, newState, __Params->isAutonomousProxy);
	}

	// Token: 0x0601E3F7 RID: 123895 RVA: 0x00886279 File Offset: 0x00884479
	protected unsafe override void __CPPCALL_渲染状态改变时_Implementation(TsAiController.__渲染状态改变时_FunctionParams* __Params)
	{
		base.渲染状态改变时_Implementation(__Params->wasRendered);
	}

	// Token: 0x0601E3F8 RID: 123896 RVA: 0x00886288 File Offset: 0x00884488
	protected unsafe override void __CPPCALL_AddComplicatedEventBinder_Implementation(TsAiController.__AddComplicatedEventBinder_FunctionParams* __Params)
	{
		SAiConditions conditions = new SAiConditions(&__Params->conditions, true, true);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		base.AddComplicatedEventBinder_Implementation(conditions, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E3F9 RID: 123897 RVA: 0x008862B8 File Offset: 0x008844B8
	protected unsafe override void __CPPCALL_AddSceneItemDestroyEventBinder_Implementation(TsAiController.__AddSceneItemDestroyEventBinder_FunctionParams* __Params)
	{
		UKuroActorEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroActorEventBinder>(__Params->eventBinder);
		base.AddSceneItemDestroyEventBinder_Implementation(__Params->distance, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E3FA RID: 123898 RVA: 0x008862E0 File Offset: 0x008844E0
	protected unsafe override void __CPPCALL_AddLevelVarBoolEventBinder_Implementation(TsAiController.__AddLevelVarBoolEventBinder_FunctionParams* __Params)
	{
		SAiLevelVar levelVar = new SAiLevelVar(&__Params->levelVar, true, true);
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		base.AddLevelVarBoolEventBinder_Implementation(levelVar, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E3FB RID: 123899 RVA: 0x00886310 File Offset: 0x00884510
	protected unsafe override void __CPPCALL_AddLevelVarIntEventBinder_Implementation(TsAiController.__AddLevelVarIntEventBinder_FunctionParams* __Params)
	{
		SAiLevelVar levelVar = new SAiLevelVar(&__Params->levelVar, true, true);
		UKuroIntEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroIntEventBinder>(__Params->eventBinder);
		base.AddLevelVarIntEventBinder_Implementation(levelVar, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E3FC RID: 123900 RVA: 0x00886340 File Offset: 0x00884540
	protected unsafe override void __CPPCALL_AddHateEventBinder_Implementation(TsAiController.__AddHateEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		base.AddHateEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E3FD RID: 123901 RVA: 0x00886360 File Offset: 0x00884560
	protected unsafe override void __CPPCALL_AddPerceptionEventBinder_Implementation(TsAiController.__AddPerceptionEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		base.AddPerceptionEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E3FE RID: 123902 RVA: 0x00886380 File Offset: 0x00884580
	protected unsafe override void __CPPCALL_SetPerceptionEventState_Implementation(TsAiController.__SetPerceptionEventState_FunctionParams* __Params)
	{
		base.SetPerceptionEventState_Implementation(__Params->includeFriend, __Params->includeEnemy, __Params->includeNeutral);
	}

	// Token: 0x0601E3FF RID: 123903 RVA: 0x0088639C File Offset: 0x0088459C
	protected unsafe override void __CPPCALL_AddHateOutRangeEventBinder_Implementation(TsAiController.__AddHateOutRangeEventBinder_FunctionParams* __Params)
	{
		UKuroPerceptionEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPerceptionEventBinder>(__Params->handler);
		base.AddHateOutRangeEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E400 RID: 123904 RVA: 0x008863BC File Offset: 0x008845BC
	protected unsafe override void __CPPCALL_ActivateSkillGroup_Implementation(TsAiController.__ActivateSkillGroup_FunctionParams* __Params)
	{
		base.ActivateSkillGroup_Implementation(__Params->skillGroupIndex, __Params->activate);
	}

	// Token: 0x0601E401 RID: 123905 RVA: 0x008863D0 File Offset: 0x008845D0
	protected unsafe override void __CPPCALL_AddSkillCd_Implementation(TsAiController.__AddSkillCd_FunctionParams* __Params)
	{
		base.AddSkillCd_Implementation(__Params->skillInfoId, __Params->cdAdd);
	}

	// Token: 0x0601E402 RID: 123906 RVA: 0x008863E4 File Offset: 0x008845E4
	protected unsafe override void __CPPCALL_AicApplyBuff_Implementation(TsAiController.__AicApplyBuff_FunctionParams* __Params)
	{
		base.AicApplyBuff_Implementation(__Params->buffId);
	}

	// Token: 0x0601E403 RID: 123907 RVA: 0x008863F2 File Offset: 0x008845F2
	protected unsafe override void __CPPCALL_AicApplyBuffToTarget_Implementation(TsAiController.__AicApplyBuffToTarget_FunctionParams* __Params)
	{
		base.AicApplyBuffToTarget_Implementation(__Params->targetId, __Params->buffId);
	}

	// Token: 0x0601E404 RID: 123908 RVA: 0x00886406 File Offset: 0x00884606
	protected unsafe override void __CPPCALL_AicRemoveBuff_Implementation(TsAiController.__AicRemoveBuff_FunctionParams* __Params)
	{
		base.AicRemoveBuff_Implementation(__Params->buffId);
	}

	// Token: 0x0601E405 RID: 123909 RVA: 0x00886414 File Offset: 0x00884614
	protected unsafe override void __CPPCALL_AicAddTag_Implementation(TsAiController.__AicAddTag_FunctionParams* __Params)
	{
		base.AicAddTag_Implementation(__Params->tag);
	}

	// Token: 0x0601E406 RID: 123910 RVA: 0x00886422 File Offset: 0x00884622
	protected unsafe override void __CPPCALL_AicRemoveTag_Implementation(TsAiController.__AicRemoveTag_FunctionParams* __Params)
	{
		base.AicRemoveTag_Implementation(__Params->tag);
	}

	// Token: 0x0601E407 RID: 123911 RVA: 0x00886430 File Offset: 0x00884630
	protected unsafe override void __CPPCALL_SetBattleWanderTime_Implementation(TsAiController.__SetBattleWanderTime_FunctionParams* __Params)
	{
		base.SetBattleWanderTime_Implementation(__Params->min, __Params->max);
	}

	// Token: 0x0601E408 RID: 123912 RVA: 0x00886444 File Offset: 0x00884644
	protected unsafe override void __CPPCALL_SetBattleWanderIndex_Implementation(TsAiController.__SetBattleWanderIndex_FunctionParams* __Params)
	{
		base.SetBattleWanderIndex_Implementation(__Params->index);
	}

	// Token: 0x0601E409 RID: 123913 RVA: 0x00886452 File Offset: 0x00884652
	protected unsafe override void __CPPCALL_AddBattleWanderEndTime_Implementation(TsAiController.__AddBattleWanderEndTime_FunctionParams* __Params)
	{
		base.AddBattleWanderEndTime_Implementation(__Params->addTime);
	}

	// Token: 0x0601E40A RID: 123914 RVA: 0x00886460 File Offset: 0x00884660
	protected unsafe override void __CPPCALL_SetAiSenseEnable_Implementation(TsAiController.__SetAiSenseEnable_FunctionParams* __Params)
	{
		base.SetAiSenseEnable_Implementation(__Params->index, __Params->enable);
	}

	// Token: 0x0601E40B RID: 123915 RVA: 0x00886474 File Offset: 0x00884674
	protected unsafe override void __CPPCALL_AddOrRemoveAiSense_Implementation(TsAiController.__AddOrRemoveAiSense_FunctionParams* __Params)
	{
		base.AddOrRemoveAiSense_Implementation(__Params->aiSenseId, __Params->add);
	}

	// Token: 0x0601E40C RID: 123916 RVA: 0x00886488 File Offset: 0x00884688
	protected unsafe override void __CPPCALL_EnableAiSenseByType_Implementation(TsAiController.__EnableAiSenseByType_FunctionParams* __Params)
	{
		base.EnableAiSenseByType_Implementation(__Params->type, __Params->enable);
	}

	// Token: 0x0601E40D RID: 123917 RVA: 0x0088649C File Offset: 0x0088469C
	protected unsafe override void __CPPCALL_SetAiHateConfig_Implementation(TsAiController.__SetAiHateConfig_FunctionParams* __Params)
	{
		string aiHateConfig_Implementation = FString.ToString((void*)(&__Params->configId));
		base.SetAiHateConfig_Implementation(aiHateConfig_Implementation);
	}

	// Token: 0x0601E40E RID: 123918 RVA: 0x008864BD File Offset: 0x008846BD
	protected unsafe override void __CPPCALL_ChangeHatred_Implementation(TsAiController.__ChangeHatred_FunctionParams* __Params)
	{
		base.ChangeHatred_Implementation(__Params->entityId, __Params->rate, __Params->abs);
	}

	// Token: 0x0601E40F RID: 123919 RVA: 0x008864D7 File Offset: 0x008846D7
	protected unsafe override void __CPPCALL_ClearHatred_Implementation(TsAiController.__ClearHatred_FunctionParams* __Params)
	{
		base.ClearHatred_Implementation(__Params->entityId);
	}

	// Token: 0x0601E410 RID: 123920 RVA: 0x008864E5 File Offset: 0x008846E5
	protected override void __CPPCALL_BindPlayerDamageEvents_Implementation()
	{
		base.BindPlayerDamageEvents_Implementation();
	}

	// Token: 0x0601E411 RID: 123921 RVA: 0x008864F0 File Offset: 0x008846F0
	protected unsafe override void __CPPCALL_AddAlertEventBinder_Implementation(TsAiController.__AddAlertEventBinder_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		base.AddAlertEventBinder_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E412 RID: 123922 RVA: 0x00886510 File Offset: 0x00884710
	protected unsafe override void __CPPCALL_SetAiAlertConfig_Implementation(TsAiController.__SetAiAlertConfig_FunctionParams* __Params)
	{
		string aiAlertConfig_Implementation = FString.ToString((void*)(&__Params->configId));
		base.SetAiAlertConfig_Implementation(aiAlertConfig_Implementation);
	}

	// Token: 0x0601E413 RID: 123923 RVA: 0x00886534 File Offset: 0x00884734
	protected unsafe override void __CPPCALL_SetAiEnable_Implementation(TsAiController.__SetAiEnable_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		base.SetAiEnable_Implementation(__Params->enable, key);
	}

	// Token: 0x0601E414 RID: 123924 RVA: 0x0088655C File Offset: 0x0088475C
	protected unsafe override void __CPPCALL_TestChangeAi_Implementation(TsAiController.__TestChangeAi_FunctionParams* __Params)
	{
		string id = FString.ToString((void*)(&__Params->id));
		base.TestChangeAi_Implementation(id);
	}

	// Token: 0x0601E415 RID: 123925 RVA: 0x0088657D File Offset: 0x0088477D
	protected unsafe override void __CPPCALL_LogReport_Implementation(TsAiController.__LogReport_FunctionParams* __Params)
	{
		base.LogReport_Implementation(__Params->logId);
	}

	// Token: 0x0601E416 RID: 123926 RVA: 0x0088658B File Offset: 0x0088478B
	protected unsafe override void __CPPCALL_逻辑主控_Implementation(TsAiController.__逻辑主控_FunctionParams* __Params)
	{
		__Params->__Result = base.逻辑主控_Implementation();
	}

	// Token: 0x0601E417 RID: 123927 RVA: 0x00886599 File Offset: 0x00884799
	protected unsafe override void __CPPCALL_移动主控_Implementation(TsAiController.__移动主控_FunctionParams* __Params)
	{
		__Params->__Result = base.移动主控_Implementation();
	}

	// Token: 0x0601E418 RID: 123928 RVA: 0x008865A8 File Offset: 0x008847A8
	protected unsafe override void __CPPCALL_检查状态机状态_Implementation(TsAiController.__检查状态机状态_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->states, true, true);
		__Params->__Result = base.检查状态机状态_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->states, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601E419 RID: 123929 RVA: 0x008865EC File Offset: 0x008847EC
	protected unsafe override void __CPPCALL_切换状态机状态_Implementation(TsAiController.__切换状态机状态_FunctionParams* __Params)
	{
		TArray<string> tarray = new TArray<string>(&__Params->states, true, true);
		base.切换状态机状态_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->states, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601E41A RID: 123930 RVA: 0x00886629 File Offset: 0x00884829
	protected unsafe override void __CPPCALL_GetCoolDownDone_Implementation(TsAiController.__GetCoolDownDone_FunctionParams* __Params)
	{
		__Params->__Result = base.GetCoolDownDone_Implementation(__Params->id);
	}

	// Token: 0x0601E41B RID: 123931 RVA: 0x0088663D File Offset: 0x0088483D
	protected unsafe override void __CPPCALL_GetCoolDownRemainTime_Implementation(TsAiController.__GetCoolDownRemainTime_FunctionParams* __Params)
	{
		__Params->__Result = base.GetCoolDownRemainTime_Implementation(__Params->id);
	}

	// Token: 0x0601E41C RID: 123932 RVA: 0x00886651 File Offset: 0x00884851
	protected unsafe override void __CPPCALL_SetCoolDown_Implementation(TsAiController.__SetCoolDown_FunctionParams* __Params)
	{
		base.SetCoolDown_Implementation(__Params->id, __Params->cd);
	}

	// Token: 0x0601E41D RID: 123933 RVA: 0x00886668 File Offset: 0x00884868
	protected unsafe override void __CPPCALL_InitCooldownEvent_Implementation(TsAiController.__InitCooldownEvent_FunctionParams* __Params)
	{
		UKuroBooleanEventBinder orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroBooleanEventBinder>(__Params->eventBinder);
		base.InitCooldownEvent_Implementation(__Params->id, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601E41E RID: 123934 RVA: 0x0088668E File Offset: 0x0088488E
	protected unsafe override void __CPPCALL_StartCooldownTimer_Implementation(TsAiController.__StartCooldownTimer_FunctionParams* __Params)
	{
		base.StartCooldownTimer_Implementation(__Params->id, __Params->duration);
	}

	// Token: 0x0601E41F RID: 123935 RVA: 0x008866A4 File Offset: 0x008848A4
	protected unsafe override void __CPPCALL_GetDebugStateMachine_Implementation(TsAiController.__GetDebugStateMachine_FunctionParams* __Params)
	{
		TArray<FText> tarray = new TArray<FText>(&__Params->output, true, true);
		base.GetDebugStateMachine_Implementation(ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->output, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x0601E420 RID: 123936 RVA: 0x008866E1 File Offset: 0x008848E1
	protected unsafe override void __CPPCALL_GetDebugText_Implementation(TsAiController.__GetDebugText_FunctionParams* __Params)
	{
		void* dest = (void*)(&__Params->__Result);
		FText debugText_Implementation = base.GetDebugText_Implementation();
		FText.NativeCopy(dest, (debugText_Implementation != null) ? debugText_Implementation.NativePtr : null, 1);
	}

	// Token: 0x0601E421 RID: 123937 RVA: 0x00886703 File Offset: 0x00884903
	protected override void __CPPCALL_ReceiveDestroyed_Implementation()
	{
		base.ReceiveDestroyed_Implementation();
	}
}
