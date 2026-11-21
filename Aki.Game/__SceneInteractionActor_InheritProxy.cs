using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002F3B RID: 12091
public class __SceneInteractionActor_InheritProxy : SceneInteractionActor
{
	// Token: 0x0601CA9E RID: 117406 RVA: 0x008C0A94 File Offset: 0x008BEC94
	[NullableContext(1)]
	public __SceneInteractionActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601CA9F RID: 117407 RVA: 0x008C0AC7 File Offset: 0x008BECC7
	protected __SceneInteractionActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601CAA0 RID: 117408 RVA: 0x008C0AD0 File Offset: 0x008BECD0
	protected unsafe override void __CPPCALL_SetOverrideSeqBindActor_Implementation(SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actorToBind);
		string bindingName = FString.ToString((void*)(&__Params->bindingName));
		base.SetOverrideSeqBindActor_Implementation(orCreateUObjectByNativePointer, bindingName);
	}

	// Token: 0x0601CAA1 RID: 117409 RVA: 0x008C0B00 File Offset: 0x008BED00
	protected unsafe override void __CPPCALL_UnsetOverrideSeqBindActor_Implementation(SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actorToUnbind);
		string bindingName = FString.ToString((void*)(&__Params->bindingName));
		base.UnsetOverrideSeqBindActor_Implementation(orCreateUObjectByNativePointer, bindingName);
	}

	// Token: 0x0601CAA2 RID: 117410 RVA: 0x008C0B2E File Offset: 0x008BED2E
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601CAA3 RID: 117411 RVA: 0x008C0B38 File Offset: 0x008BED38
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601CAA4 RID: 117412 RVA: 0x008C0B58 File Offset: 0x008BED58
	protected override void __CPPCALL_AddNewState_Implementation()
	{
		base.AddNewState_Implementation();
	}

	// Token: 0x0601CAA5 RID: 117413 RVA: 0x008C0B60 File Offset: 0x008BED60
	protected override void __CPPCALL_AddNewEffect_Implementation()
	{
		base.AddNewEffect_Implementation();
	}

	// Token: 0x0601CAA6 RID: 117414 RVA: 0x008C0B68 File Offset: 0x008BED68
	protected override void __CPPCALL_AddNewEndEffect_Implementation()
	{
		base.AddNewEndEffect_Implementation();
	}

	// Token: 0x0601CAA7 RID: 117415 RVA: 0x008C0B70 File Offset: 0x008BED70
	protected override void __CPPCALL_UpdateTimeDilation_Implementation()
	{
		base.UpdateTimeDilation_Implementation();
	}

	// Token: 0x0601CAA8 RID: 117416 RVA: 0x008C0B78 File Offset: 0x008BED78
	protected unsafe override void __CPPCALL_CheckAllEffectPlaying_Implementation(SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams* __Params)
	{
		__Params->__Result = base.CheckAllEffectPlaying_Implementation();
	}

	// Token: 0x0601CAA9 RID: 117417 RVA: 0x008C0B88 File Offset: 0x008BED88
	protected unsafe override void __CPPCALL_PlayKuroSkeletalMeshDestruction_Implementation(SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		base.PlayKuroSkeletalMeshDestruction_Implementation(orCreateUObjectByNativePointer, __Params->isJumpToEnd);
	}

	// Token: 0x0601CAAA RID: 117418 RVA: 0x008C0BB0 File Offset: 0x008BEDB0
	protected unsafe override void __CPPCALL_OverrideKuroDestructibleActorPhysicsVelocity_Implementation(SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams* __Params)
	{
		AKuroDestructibleActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroDestructibleActor>(__Params->skeletalMeshDestruction);
		base.OverrideKuroDestructibleActorPhysicsVelocity_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601CAAB RID: 117419 RVA: 0x008C0BD0 File Offset: 0x008BEDD0
	protected unsafe override void __CPPCALL_GetActiveSequenceRemainTime_Implementation(SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->sequence);
		__Params->__Result = base.GetActiveSequenceRemainTime_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601CAAC RID: 117420 RVA: 0x008C0BF6 File Offset: 0x008BEDF6
	protected unsafe override void __CPPCALL_ApplyAnimOptimizationParams_Implementation(SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams* __Params)
	{
		base.ApplyAnimOptimizationParams_Implementation(__Params->bUseDistanceMap);
	}

	// Token: 0x0601CAAD RID: 117421 RVA: 0x008C0C04 File Offset: 0x008BEE04
	protected override void __CPPCALL_PendingPlayStateEffect_Implementation()
	{
		base.PendingPlayStateEffect_Implementation();
	}

	// Token: 0x0601CAAE RID: 117422 RVA: 0x008C0C0C File Offset: 0x008BEE0C
	protected override void __CPPCALL_RemovePendingStateEffectTick_Implementation()
	{
		base.RemovePendingStateEffectTick_Implementation();
	}

	// Token: 0x0601CAAF RID: 117423 RVA: 0x008C0C14 File Offset: 0x008BEE14
	protected override void __CPPCALL_PendingPlayCrossStateEffect_Implementation()
	{
		base.PendingPlayCrossStateEffect_Implementation();
	}

	// Token: 0x0601CAB0 RID: 117424 RVA: 0x008C0C1C File Offset: 0x008BEE1C
	protected override void __CPPCALL_RemovePendingCrossStateEffectTick_Implementation()
	{
		base.RemovePendingCrossStateEffectTick_Implementation();
	}

	// Token: 0x0601CAB1 RID: 117425 RVA: 0x008C0C24 File Offset: 0x008BEE24
	protected override void __CPPCALL_PendingPlayTagEffect_Implementation()
	{
		base.PendingPlayTagEffect_Implementation();
	}

	// Token: 0x0601CAB2 RID: 117426 RVA: 0x008C0C2C File Offset: 0x008BEE2C
	protected override void __CPPCALL_RemovePendingTagEffectTick_Implementation()
	{
		base.RemovePendingTagEffectTick_Implementation();
	}

	// Token: 0x0601CAB3 RID: 117427 RVA: 0x008C0C34 File Offset: 0x008BEE34
	protected unsafe override void __CPPCALL_PostAutoMergeEvent_Implementation(SceneInteractionActor.__PostAutoMergeEvent_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		base.PostAutoMergeEvent_Implementation(eventName, __Params->tagId, __Params->follow);
	}

	// Token: 0x0601CAB4 RID: 117428 RVA: 0x008C0C64 File Offset: 0x008BEE64
	protected unsafe override void __CPPCALL_PostTagEvent_Implementation(SceneInteractionActor.__PostTagEvent_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		base.PostTagEvent_Implementation(eventName, __Params->tag, __Params->follow);
	}

	// Token: 0x0601CAB5 RID: 117429 RVA: 0x008C0C91 File Offset: 0x008BEE91
	protected unsafe override void __CPPCALL_StopTagAkEvent_Implementation(SceneInteractionActor.__StopTagAkEvent_FunctionParams* __Params)
	{
		base.StopTagAkEvent_Implementation(__Params->tag);
	}

	// Token: 0x0601CAB6 RID: 117430 RVA: 0x008C0C9F File Offset: 0x008BEE9F
	protected unsafe override void __CPPCALL_UpdateProjectionActorTransform_Implementation(SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams* __Params)
	{
		base.UpdateProjectionActorTransform_Implementation(__Params->transform);
	}

	// Token: 0x0601CAB7 RID: 117431 RVA: 0x008C0CB0 File Offset: 0x008BEEB0
	protected unsafe override void __CPPCALL_AddMatrialDataForChildrenActor_Implementation(SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		ItemMaterialControllerActorData orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ItemMaterialControllerActorData>(__Params->materialData);
		base.AddMatrialDataForChildrenActor_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601CAB8 RID: 117432 RVA: 0x008C0CDD File Offset: 0x008BEEDD
	protected override void __CPPCALL_RemoveActorProjection_Implementation()
	{
		base.RemoveActorProjection_Implementation();
	}

	// Token: 0x0601CAB9 RID: 117433 RVA: 0x008C0CE5 File Offset: 0x008BEEE5
	protected override void __CPPCALL_DestroySelf_Implementation()
	{
		base.DestroySelf_Implementation();
	}

	// Token: 0x0601CABA RID: 117434 RVA: 0x008C0CED File Offset: 0x008BEEED
	protected unsafe override void __CPPCALL_ResetTagActorHide_Implementation(SceneInteractionActor.__ResetTagActorHide_FunctionParams* __Params)
	{
		base.ResetTagActorHide_Implementation(__Params->tag);
	}

	// Token: 0x0601CABB RID: 117435 RVA: 0x008C0CFC File Offset: 0x008BEEFC
	protected unsafe override void __CPPCALL_GetDirectorBySequence_Implementation(SceneInteractionActor.__GetDirectorBySequence_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->sequence);
		ref IntPtr ptr = ref *(&__Params->__Result);
		ALevelSequenceActor directorBySequence_Implementation = base.GetDirectorBySequence_Implementation(orCreateUObjectByNativePointer);
		ptr = ((directorBySequence_Implementation != null) ? directorBySequence_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601CABC RID: 117436 RVA: 0x008C0D31 File Offset: 0x008BEF31
	protected unsafe override void __CPPCALL_StopExtraEffectOnTagsChange_Implementation(SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams* __Params)
	{
		base.StopExtraEffectOnTagsChange_Implementation(__Params->tag);
	}

	// Token: 0x0601CABD RID: 117437 RVA: 0x008C0D3F File Offset: 0x008BEF3F
	protected override void __CPPCALL_TryStopCurrentState_Implementation()
	{
		base.TryStopCurrentState_Implementation();
	}

	// Token: 0x0601CABE RID: 117438 RVA: 0x008C0D47 File Offset: 0x008BEF47
	protected override void __CPPCALL_使用字段值切换状态_Implementation()
	{
		base.使用字段值切换状态_Implementation();
	}

	// Token: 0x0601CABF RID: 117439 RVA: 0x008C0D4F File Offset: 0x008BEF4F
	protected override void __CPPCALL_ChangeState1_Implementation()
	{
		base.ChangeState1_Implementation();
	}

	// Token: 0x0601CAC0 RID: 117440 RVA: 0x008C0D57 File Offset: 0x008BEF57
	protected override void __CPPCALL_ChangeState2_Implementation()
	{
		base.ChangeState2_Implementation();
	}

	// Token: 0x0601CAC1 RID: 117441 RVA: 0x008C0D5F File Offset: 0x008BEF5F
	protected override void __CPPCALL_ChangeState3_Implementation()
	{
		base.ChangeState3_Implementation();
	}

	// Token: 0x0601CAC2 RID: 117442 RVA: 0x008C0D67 File Offset: 0x008BEF67
	protected override void __CPPCALL_ChangeState4_Implementation()
	{
		base.ChangeState4_Implementation();
	}

	// Token: 0x0601CAC3 RID: 117443 RVA: 0x008C0D6F File Offset: 0x008BEF6F
	protected override void __CPPCALL_ChangeState5_Implementation()
	{
		base.ChangeState5_Implementation();
	}

	// Token: 0x0601CAC4 RID: 117444 RVA: 0x008C0D77 File Offset: 0x008BEF77
	protected override void __CPPCALL_ChangeState6_Implementation()
	{
		base.ChangeState6_Implementation();
	}

	// Token: 0x0601CAC5 RID: 117445 RVA: 0x008C0D7F File Offset: 0x008BEF7F
	protected override void __CPPCALL_ChangeState7_Implementation()
	{
		base.ChangeState7_Implementation();
	}

	// Token: 0x0601CAC6 RID: 117446 RVA: 0x008C0D87 File Offset: 0x008BEF87
	protected override void __CPPCALL_ChangeState8_Implementation()
	{
		base.ChangeState8_Implementation();
	}

	// Token: 0x0601CAC7 RID: 117447 RVA: 0x008C0D8F File Offset: 0x008BEF8F
	protected override void __CPPCALL_模拟Tag添加_Implementation()
	{
		base.模拟Tag添加_Implementation();
	}

	// Token: 0x0601CAC8 RID: 117448 RVA: 0x008C0D97 File Offset: 0x008BEF97
	protected override void __CPPCALL_模拟Tag移除_Implementation()
	{
		base.模拟Tag移除_Implementation();
	}

	// Token: 0x0601CAC9 RID: 117449 RVA: 0x008C0D9F File Offset: 0x008BEF9F
	protected override void __CPPCALL_重置_Implementation()
	{
		base.重置_Implementation();
	}
}
