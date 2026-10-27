using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x020039C0 RID: 14784
public class __SceneInteractionActor_InheritProxy : SceneInteractionActor
{
	// Token: 0x0601EE7C RID: 126588 RVA: 0x008A10C0 File Offset: 0x0089F2C0
	[NullableContext(1)]
	public __SceneInteractionActor_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(SceneInteractionActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601EE7D RID: 126589 RVA: 0x008A10F3 File Offset: 0x0089F2F3
	protected __SceneInteractionActor_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601EE7E RID: 126590 RVA: 0x008A10FC File Offset: 0x0089F2FC
	protected unsafe override void __CPPCALL_SetOverrideSeqBindActor_Implementation(SceneInteractionActor.__SetOverrideSeqBindActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actorToBind);
		string bindingName = FString.ToString((void*)(&__Params->bindingName));
		base.SetOverrideSeqBindActor_Implementation(orCreateUObjectByNativePointer, bindingName);
	}

	// Token: 0x0601EE7F RID: 126591 RVA: 0x008A112C File Offset: 0x0089F32C
	protected unsafe override void __CPPCALL_UnsetOverrideSeqBindActor_Implementation(SceneInteractionActor.__UnsetOverrideSeqBindActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actorToUnbind);
		string bindingName = FString.ToString((void*)(&__Params->bindingName));
		base.UnsetOverrideSeqBindActor_Implementation(orCreateUObjectByNativePointer, bindingName);
	}

	// Token: 0x0601EE80 RID: 126592 RVA: 0x008A115A File Offset: 0x0089F35A
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601EE81 RID: 126593 RVA: 0x008A1164 File Offset: 0x0089F364
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(AActor.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601EE82 RID: 126594 RVA: 0x008A1184 File Offset: 0x0089F384
	protected override void __CPPCALL_AddNewState_Implementation()
	{
		base.AddNewState_Implementation();
	}

	// Token: 0x0601EE83 RID: 126595 RVA: 0x008A118C File Offset: 0x0089F38C
	protected override void __CPPCALL_AddNewEffect_Implementation()
	{
		base.AddNewEffect_Implementation();
	}

	// Token: 0x0601EE84 RID: 126596 RVA: 0x008A1194 File Offset: 0x0089F394
	protected override void __CPPCALL_AddNewEndEffect_Implementation()
	{
		base.AddNewEndEffect_Implementation();
	}

	// Token: 0x0601EE85 RID: 126597 RVA: 0x008A119C File Offset: 0x0089F39C
	protected override void __CPPCALL_UpdateTimeDilation_Implementation()
	{
		base.UpdateTimeDilation_Implementation();
	}

	// Token: 0x0601EE86 RID: 126598 RVA: 0x008A11A4 File Offset: 0x0089F3A4
	protected unsafe override void __CPPCALL_CheckAllEffectPlaying_Implementation(SceneInteractionActor.__CheckAllEffectPlaying_FunctionParams* __Params)
	{
		__Params->__Result = base.CheckAllEffectPlaying_Implementation();
	}

	// Token: 0x0601EE87 RID: 126599 RVA: 0x008A11B4 File Offset: 0x0089F3B4
	protected unsafe override void __CPPCALL_PlayKuroSkeletalMeshDestruction_Implementation(SceneInteractionActor.__PlayKuroSkeletalMeshDestruction_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		base.PlayKuroSkeletalMeshDestruction_Implementation(orCreateUObjectByNativePointer, __Params->isJumpToEnd);
	}

	// Token: 0x0601EE88 RID: 126600 RVA: 0x008A11DC File Offset: 0x0089F3DC
	protected unsafe override void __CPPCALL_OverrideKuroDestructibleActorPhysicsVelocity_Implementation(SceneInteractionActor.__OverrideKuroDestructibleActorPhysicsVelocity_FunctionParams* __Params)
	{
		AKuroDestructibleActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroDestructibleActor>(__Params->skeletalMeshDestruction);
		base.OverrideKuroDestructibleActorPhysicsVelocity_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EE89 RID: 126601 RVA: 0x008A11FC File Offset: 0x0089F3FC
	protected unsafe override void __CPPCALL_GetActiveSequenceRemainTime_Implementation(SceneInteractionActor.__GetActiveSequenceRemainTime_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->sequence);
		__Params->__Result = base.GetActiveSequenceRemainTime_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601EE8A RID: 126602 RVA: 0x008A1222 File Offset: 0x0089F422
	protected unsafe override void __CPPCALL_ApplyAnimOptimizationParams_Implementation(SceneInteractionActor.__ApplyAnimOptimizationParams_FunctionParams* __Params)
	{
		base.ApplyAnimOptimizationParams_Implementation(__Params->bUseDistanceMap);
	}

	// Token: 0x0601EE8B RID: 126603 RVA: 0x008A1230 File Offset: 0x0089F430
	protected override void __CPPCALL_PendingPlayStateEffect_Implementation()
	{
		base.PendingPlayStateEffect_Implementation();
	}

	// Token: 0x0601EE8C RID: 126604 RVA: 0x008A1238 File Offset: 0x0089F438
	protected override void __CPPCALL_RemovePendingStateEffectTick_Implementation()
	{
		base.RemovePendingStateEffectTick_Implementation();
	}

	// Token: 0x0601EE8D RID: 126605 RVA: 0x008A1240 File Offset: 0x0089F440
	protected override void __CPPCALL_PendingPlayCrossStateEffect_Implementation()
	{
		base.PendingPlayCrossStateEffect_Implementation();
	}

	// Token: 0x0601EE8E RID: 126606 RVA: 0x008A1248 File Offset: 0x0089F448
	protected override void __CPPCALL_RemovePendingCrossStateEffectTick_Implementation()
	{
		base.RemovePendingCrossStateEffectTick_Implementation();
	}

	// Token: 0x0601EE8F RID: 126607 RVA: 0x008A1250 File Offset: 0x0089F450
	protected override void __CPPCALL_PendingPlayTagEffect_Implementation()
	{
		base.PendingPlayTagEffect_Implementation();
	}

	// Token: 0x0601EE90 RID: 126608 RVA: 0x008A1258 File Offset: 0x0089F458
	protected override void __CPPCALL_RemovePendingTagEffectTick_Implementation()
	{
		base.RemovePendingTagEffectTick_Implementation();
	}

	// Token: 0x0601EE91 RID: 126609 RVA: 0x008A1260 File Offset: 0x0089F460
	protected unsafe override void __CPPCALL_PostAutoMergeEvent_Implementation(SceneInteractionActor.__PostAutoMergeEvent_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		base.PostAutoMergeEvent_Implementation(eventName, __Params->tagId, __Params->follow);
	}

	// Token: 0x0601EE92 RID: 126610 RVA: 0x008A1290 File Offset: 0x0089F490
	protected unsafe override void __CPPCALL_PostTagEvent_Implementation(SceneInteractionActor.__PostTagEvent_FunctionParams* __Params)
	{
		string eventName = FString.ToString((void*)(&__Params->eventName));
		base.PostTagEvent_Implementation(eventName, __Params->tag, __Params->follow);
	}

	// Token: 0x0601EE93 RID: 126611 RVA: 0x008A12BD File Offset: 0x0089F4BD
	protected unsafe override void __CPPCALL_StopTagAkEvent_Implementation(SceneInteractionActor.__StopTagAkEvent_FunctionParams* __Params)
	{
		base.StopTagAkEvent_Implementation(__Params->tag);
	}

	// Token: 0x0601EE94 RID: 126612 RVA: 0x008A12CB File Offset: 0x0089F4CB
	protected unsafe override void __CPPCALL_UpdateProjectionActorTransform_Implementation(SceneInteractionActor.__UpdateProjectionActorTransform_FunctionParams* __Params)
	{
		base.UpdateProjectionActorTransform_Implementation(__Params->transform);
	}

	// Token: 0x0601EE95 RID: 126613 RVA: 0x008A12DC File Offset: 0x0089F4DC
	protected unsafe override void __CPPCALL_AddMatrialDataForChildrenActor_Implementation(SceneInteractionActor.__AddMatrialDataForChildrenActor_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->actor);
		ItemMaterialControllerActorData orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ItemMaterialControllerActorData>(__Params->materialData);
		base.AddMatrialDataForChildrenActor_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601EE96 RID: 126614 RVA: 0x008A1309 File Offset: 0x0089F509
	protected override void __CPPCALL_RemoveActorProjection_Implementation()
	{
		base.RemoveActorProjection_Implementation();
	}

	// Token: 0x0601EE97 RID: 126615 RVA: 0x008A1311 File Offset: 0x0089F511
	protected override void __CPPCALL_DestroySelf_Implementation()
	{
		base.DestroySelf_Implementation();
	}

	// Token: 0x0601EE98 RID: 126616 RVA: 0x008A1319 File Offset: 0x0089F519
	protected unsafe override void __CPPCALL_ResetTagActorHide_Implementation(SceneInteractionActor.__ResetTagActorHide_FunctionParams* __Params)
	{
		base.ResetTagActorHide_Implementation(__Params->tag);
	}

	// Token: 0x0601EE99 RID: 126617 RVA: 0x008A1328 File Offset: 0x0089F528
	protected unsafe override void __CPPCALL_GetDirectorBySequence_Implementation(SceneInteractionActor.__GetDirectorBySequence_FunctionParams* __Params)
	{
		ULevelSequence orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->sequence);
		ref IntPtr ptr = ref *(&__Params->__Result);
		ALevelSequenceActor directorBySequence_Implementation = base.GetDirectorBySequence_Implementation(orCreateUObjectByNativePointer);
		ptr = ((directorBySequence_Implementation != null) ? directorBySequence_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601EE9A RID: 126618 RVA: 0x008A135D File Offset: 0x0089F55D
	protected unsafe override void __CPPCALL_StopExtraEffectOnTagsChange_Implementation(SceneInteractionActor.__StopExtraEffectOnTagsChange_FunctionParams* __Params)
	{
		base.StopExtraEffectOnTagsChange_Implementation(__Params->tag);
	}

	// Token: 0x0601EE9B RID: 126619 RVA: 0x008A136B File Offset: 0x0089F56B
	protected override void __CPPCALL_TryStopCurrentState_Implementation()
	{
		base.TryStopCurrentState_Implementation();
	}

	// Token: 0x0601EE9C RID: 126620 RVA: 0x008A1373 File Offset: 0x0089F573
	protected override void __CPPCALL_使用字段值切换状态_Implementation()
	{
		base.使用字段值切换状态_Implementation();
	}

	// Token: 0x0601EE9D RID: 126621 RVA: 0x008A137B File Offset: 0x0089F57B
	protected override void __CPPCALL_ChangeState1_Implementation()
	{
		base.ChangeState1_Implementation();
	}

	// Token: 0x0601EE9E RID: 126622 RVA: 0x008A1383 File Offset: 0x0089F583
	protected override void __CPPCALL_ChangeState2_Implementation()
	{
		base.ChangeState2_Implementation();
	}

	// Token: 0x0601EE9F RID: 126623 RVA: 0x008A138B File Offset: 0x0089F58B
	protected override void __CPPCALL_ChangeState3_Implementation()
	{
		base.ChangeState3_Implementation();
	}

	// Token: 0x0601EEA0 RID: 126624 RVA: 0x008A1393 File Offset: 0x0089F593
	protected override void __CPPCALL_ChangeState4_Implementation()
	{
		base.ChangeState4_Implementation();
	}

	// Token: 0x0601EEA1 RID: 126625 RVA: 0x008A139B File Offset: 0x0089F59B
	protected override void __CPPCALL_ChangeState5_Implementation()
	{
		base.ChangeState5_Implementation();
	}

	// Token: 0x0601EEA2 RID: 126626 RVA: 0x008A13A3 File Offset: 0x0089F5A3
	protected override void __CPPCALL_ChangeState6_Implementation()
	{
		base.ChangeState6_Implementation();
	}

	// Token: 0x0601EEA3 RID: 126627 RVA: 0x008A13AB File Offset: 0x0089F5AB
	protected override void __CPPCALL_ChangeState7_Implementation()
	{
		base.ChangeState7_Implementation();
	}

	// Token: 0x0601EEA4 RID: 126628 RVA: 0x008A13B3 File Offset: 0x0089F5B3
	protected override void __CPPCALL_ChangeState8_Implementation()
	{
		base.ChangeState8_Implementation();
	}

	// Token: 0x0601EEA5 RID: 126629 RVA: 0x008A13BB File Offset: 0x0089F5BB
	protected override void __CPPCALL_模拟Tag添加_Implementation()
	{
		base.模拟Tag添加_Implementation();
	}

	// Token: 0x0601EEA6 RID: 126630 RVA: 0x008A13C3 File Offset: 0x0089F5C3
	protected override void __CPPCALL_模拟Tag移除_Implementation()
	{
		base.模拟Tag移除_Implementation();
	}

	// Token: 0x0601EEA7 RID: 126631 RVA: 0x008A13CB File Offset: 0x0089F5CB
	protected override void __CPPCALL_重置_Implementation()
	{
		base.重置_Implementation();
	}
}
