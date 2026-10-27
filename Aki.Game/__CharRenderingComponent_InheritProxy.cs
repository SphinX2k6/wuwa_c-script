using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Components;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02003978 RID: 14712
public class __CharRenderingComponent_InheritProxy : CharRenderingComponent
{
	// Token: 0x0601ED4B RID: 126283 RVA: 0x0089D30C File Offset: 0x0089B50C
	[NullableContext(1)]
	public __CharRenderingComponent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601ED4C RID: 126284 RVA: 0x0089D33F File Offset: 0x0089B53F
	protected __CharRenderingComponent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601ED4D RID: 126285 RVA: 0x0089D348 File Offset: 0x0089B548
	protected unsafe override void __CPPCALL_QuickInitAndAddData_Implementation(CharRenderingComponent.__QuickInitAndAddData_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		ASkeletalMeshActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASkeletalMeshActor>(__Params->meshActor);
		__Params->__Result = base.QuickInitAndAddData_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601ED4E RID: 126286 RVA: 0x0089D37C File Offset: 0x0089B57C
	protected unsafe override void __CPPCALL_QuickInitAndAddDataWithMeshComponent_Implementation(CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		UMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->meshComponent);
		__Params->__Result = base.QuickInitAndAddDataWithMeshComponent_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601ED4F RID: 126287 RVA: 0x0089D3B0 File Offset: 0x0089B5B0
	protected unsafe override void __CPPCALL_QuickInitAndAddDataGroup_Implementation(CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		ASkeletalMeshActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASkeletalMeshActor>(__Params->meshActor);
		__Params->__Result = base.QuickInitAndAddDataGroup_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601ED50 RID: 126288 RVA: 0x0089D3E4 File Offset: 0x0089B5E4
	protected unsafe override void __CPPCALL_QuickInitAndAddDataGroupWithMeshComponent_Implementation(CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		UMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->meshComponent);
		__Params->__Result = base.QuickInitAndAddDataGroupWithMeshComponent_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601ED51 RID: 126289 RVA: 0x0089D418 File Offset: 0x0089B618
	protected unsafe override void __CPPCALL_Init_Implementation(CharRenderingComponent.__Init_FunctionParams* __Params)
	{
		ECharacterRenderingType renderType = (ECharacterRenderingType)__Params->renderType;
		base.Init_Implementation(renderType);
	}

	// Token: 0x0601ED52 RID: 126290 RVA: 0x0089D434 File Offset: 0x0089B634
	protected unsafe override void __CPPCALL_SetLogicOwner_Implementation(CharRenderingComponent.__SetLogicOwner_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->owner);
		base.SetLogicOwner_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601ED53 RID: 126291 RVA: 0x0089D454 File Offset: 0x0089B654
	protected unsafe override void __CPPCALL_AddComponent_Implementation(CharRenderingComponent.__AddComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		base.AddComponent_Implementation(skelName, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601ED54 RID: 126292 RVA: 0x0089D484 File Offset: 0x0089B684
	protected unsafe override void __CPPCALL_AddComponentWithEmptyMaterial_Implementation(CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		base.AddComponentWithEmptyMaterial_Implementation(skelName, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601ED55 RID: 126293 RVA: 0x0089D4B4 File Offset: 0x0089B6B4
	protected unsafe override void __CPPCALL_RemoveComponent_Implementation(CharRenderingComponent.__RemoveComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		base.RemoveComponent_Implementation(skelName);
	}

	// Token: 0x0601ED56 RID: 126294 RVA: 0x0089D4D8 File Offset: 0x0089B6D8
	protected unsafe override void __CPPCALL_AddComponentByCase_Implementation(CharRenderingComponent.__AddComponentByCase_FunctionParams* __Params)
	{
		ECharacterControllerCaseType caseType = (ECharacterControllerCaseType)__Params->caseType;
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		base.AddComponentByCase_Implementation(caseType, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601ED57 RID: 126295 RVA: 0x0089D500 File Offset: 0x0089B700
	protected unsafe override void __CPPCALL_RemoveComponentByCase_Implementation(CharRenderingComponent.__RemoveComponentByCase_FunctionParams* __Params)
	{
		ECharacterControllerCaseType caseType = (ECharacterControllerCaseType)__Params->caseType;
		base.RemoveComponentByCase_Implementation(caseType);
	}

	// Token: 0x0601ED58 RID: 126296 RVA: 0x0089D51C File Offset: 0x0089B71C
	protected unsafe override void __CPPCALL_AddComponentInnerV2_Implementation(CharRenderingComponent.__AddComponentInnerV2_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		base.AddComponentInnerV2_Implementation(skelName, orCreateUObjectByNativePointer, __Params->useEmptyMaterial);
	}

	// Token: 0x0601ED59 RID: 126297 RVA: 0x0089D550 File Offset: 0x0089B750
	protected unsafe override void __CPPCALL_RemoveComponentInnerV2_Implementation(CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		base.RemoveComponentInnerV2_Implementation(skelName);
	}

	// Token: 0x0601ED5A RID: 126298 RVA: 0x0089D574 File Offset: 0x0089B774
	protected unsafe override void __CPPCALL_GetSkeletalMeshComponent_Implementation(CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		USkeletalMeshComponent skeletalMeshComponent_Implementation = base.GetSkeletalMeshComponent_Implementation(skelName);
		ptr = ((skeletalMeshComponent_Implementation != null) ? skeletalMeshComponent_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601ED5B RID: 126299 RVA: 0x0089D5AC File Offset: 0x0089B7AC
	protected unsafe override void __CPPCALL_GetSkeletalMeshComponentBodyName_Implementation(CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->skeletalComp);
		__Params->__Result = base.GetSkeletalMeshComponentBodyName_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601ED5C RID: 126300 RVA: 0x0089D5D2 File Offset: 0x0089B7D2
	protected unsafe override void __CPPCALL_CheckInit_Implementation(CharRenderingComponent.__CheckInit_FunctionParams* __Params)
	{
		__Params->__Result = base.CheckInit_Implementation();
	}

	// Token: 0x0601ED5D RID: 126301 RVA: 0x0089D5E0 File Offset: 0x0089B7E0
	protected unsafe override void __CPPCALL_SetDebug_Implementation(CharRenderingComponent.__SetDebug_FunctionParams* __Params)
	{
		base.SetDebug_Implementation(__Params->value);
	}

	// Token: 0x0601ED5E RID: 126302 RVA: 0x0089D5EE File Offset: 0x0089B7EE
	protected unsafe override void __CPPCALL_GetDebugInfo_Implementation(CharRenderingComponent.__GetDebugInfo_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		PD_MaterialDebug_C debugInfo_Implementation = base.GetDebugInfo_Implementation();
		ptr = ((debugInfo_Implementation != null) ? debugInfo_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601ED5F RID: 126303 RVA: 0x0089D60C File Offset: 0x0089B80C
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(UActorComponent.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601ED60 RID: 126304 RVA: 0x0089D62C File Offset: 0x0089B82C
	protected unsafe override void __CPPCALL_GetInWater_Implementation(CharRenderingComponent.__GetInWater_FunctionParams* __Params)
	{
		__Params->__Result = base.GetInWater_Implementation(__Params->depthThreshold);
	}

	// Token: 0x0601ED61 RID: 126305 RVA: 0x0089D640 File Offset: 0x0089B840
	protected unsafe override void __CPPCALL_GetInAudioShr_Implementation(CharRenderingComponent.__GetInAudioShr_FunctionParams* __Params)
	{
		__Params->__Result = base.GetInAudioShr_Implementation();
	}

	// Token: 0x0601ED62 RID: 126306 RVA: 0x0089D64E File Offset: 0x0089B84E
	protected override void __CPPCALL_ResetAllRenderingState_Implementation()
	{
		base.ResetAllRenderingState_Implementation();
	}

	// Token: 0x0601ED63 RID: 126307 RVA: 0x0089D658 File Offset: 0x0089B858
	protected unsafe override void __CPPCALL_AddMaterialControllerDataGroup_Implementation(CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		__Params->__Result = base.AddMaterialControllerDataGroup_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601ED64 RID: 126308 RVA: 0x0089D680 File Offset: 0x0089B880
	protected unsafe override void __CPPCALL_AddMaterialControllerDataGroupWithAnimObject_Implementation(CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->animObject);
		__Params->__Result = base.AddMaterialControllerDataGroupWithAnimObject_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601ED65 RID: 126309 RVA: 0x0089D6B3 File Offset: 0x0089B8B3
	protected unsafe override void __CPPCALL_RemoveMaterialControllerDataGroup_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams* __Params)
	{
		base.RemoveMaterialControllerDataGroup_Implementation(__Params->handle);
	}

	// Token: 0x0601ED66 RID: 126310 RVA: 0x0089D6C1 File Offset: 0x0089B8C1
	protected unsafe override void __CPPCALL_RemoveMaterialControllerDataGroupWithEnding_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams* __Params)
	{
		base.RemoveMaterialControllerDataGroupWithEnding_Implementation(__Params->handle);
	}

	// Token: 0x0601ED67 RID: 126311 RVA: 0x0089D6D0 File Offset: 0x0089B8D0
	protected unsafe override void __CPPCALL_AddMaterialControllerDataWithAnimObject_Implementation(CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->animObject);
		UObject orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->userData);
		__Params->__Result = base.AddMaterialControllerDataWithAnimObject_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
	}

	// Token: 0x0601ED68 RID: 126312 RVA: 0x0089D710 File Offset: 0x0089B910
	protected unsafe override void __CPPCALL_AddMaterialControllerData_Implementation(CharRenderingComponent.__AddMaterialControllerData_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		__Params->__Result = base.AddMaterialControllerData_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601ED69 RID: 126313 RVA: 0x0089D736 File Offset: 0x0089B936
	protected unsafe override void __CPPCALL_RemoveMaterialControllerData_Implementation(CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams* __Params)
	{
		base.RemoveMaterialControllerData_Implementation(__Params->handle);
	}

	// Token: 0x0601ED6A RID: 126314 RVA: 0x0089D744 File Offset: 0x0089B944
	protected unsafe override void __CPPCALL_SetEffectPause_Implementation(CharRenderingComponent.__SetEffectPause_FunctionParams* __Params)
	{
		base.SetEffectPause_Implementation(__Params->handle, __Params->paused);
	}

	// Token: 0x0601ED6B RID: 126315 RVA: 0x0089D758 File Offset: 0x0089B958
	protected unsafe override void __CPPCALL_RemoveMaterialControllerDataWithEnding_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams* __Params)
	{
		base.RemoveMaterialControllerDataWithEnding_Implementation(__Params->handle);
	}

	// Token: 0x0601ED6C RID: 126316 RVA: 0x0089D768 File Offset: 0x0089B968
	protected unsafe override void __CPPCALL_SetDitherEffect_Implementation(CharRenderingComponent.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		base.SetDitherEffect_Implementation(__Params->ditherRate, ditherType);
	}

	// Token: 0x0601ED6D RID: 126317 RVA: 0x0089D789 File Offset: 0x0089B989
	protected unsafe override void __CPPCALL_SetDisableFightDither_Implementation(CharRenderingComponent.__SetDisableFightDither_FunctionParams* __Params)
	{
		base.SetDisableFightDither_Implementation(__Params->disable);
	}

	// Token: 0x0601ED6E RID: 126318 RVA: 0x0089D797 File Offset: 0x0089B997
	protected override void __CPPCALL_SetDitherApplyAll_Implementation()
	{
		base.SetDitherApplyAll_Implementation();
	}

	// Token: 0x0601ED6F RID: 126319 RVA: 0x0089D79F File Offset: 0x0089B99F
	protected override void __CPPCALL_SetDitherApplyHeadsOnly_Implementation()
	{
		base.SetDitherApplyHeadsOnly_Implementation();
	}

	// Token: 0x0601ED70 RID: 126320 RVA: 0x0089D7A7 File Offset: 0x0089B9A7
	protected unsafe override void __CPPCALL_SetDitherUseHeadMaskHideEffect_Implementation(CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams* __Params)
	{
		base.SetDitherUseHeadMaskHideEffect_Implementation(__Params->enable);
	}

	// Token: 0x0601ED71 RID: 126321 RVA: 0x0089D7B5 File Offset: 0x0089B9B5
	protected override void __CPPCALL_TempRemoveDither_Implementation()
	{
		base.TempRemoveDither_Implementation();
	}

	// Token: 0x0601ED72 RID: 126322 RVA: 0x0089D7BD File Offset: 0x0089B9BD
	protected override void __CPPCALL_TempRecoverDither_Implementation()
	{
		base.TempRecoverDither_Implementation();
	}

	// Token: 0x0601ED73 RID: 126323 RVA: 0x0089D7C5 File Offset: 0x0089B9C5
	protected unsafe override void __CPPCALL_GetOpacityConsiderVisibility_Implementation(CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams* __Params)
	{
		__Params->__Result = base.GetOpacityConsiderVisibility_Implementation();
	}

	// Token: 0x0601ED74 RID: 126324 RVA: 0x0089D7D4 File Offset: 0x0089B9D4
	protected unsafe override void __CPPCALL_SetMaterialPropertyFloat_Implementation(CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams* __Params)
	{
		ECharacterBodySpecifiedType bodyType = (ECharacterBodySpecifiedType)__Params->bodyType;
		ECharacterSlotSpecifiedType slotType = (ECharacterSlotSpecifiedType)__Params->slotType;
		string propertyName = FString.ToString((void*)(&__Params->propertyName));
		base.SetMaterialPropertyFloat_Implementation(bodyType, __Params->sectionIndex, slotType, propertyName, __Params->value);
	}

	// Token: 0x0601ED75 RID: 126325 RVA: 0x0089D814 File Offset: 0x0089BA14
	protected unsafe override void __CPPCALL_SetMaterialPropertyColor_Implementation(CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams* __Params)
	{
		ECharacterBodySpecifiedType bodyType = (ECharacterBodySpecifiedType)__Params->bodyType;
		ECharacterSlotSpecifiedType slotType = (ECharacterSlotSpecifiedType)__Params->slotType;
		string propertyName = FString.ToString((void*)(&__Params->propertyName));
		base.SetMaterialPropertyColor_Implementation(bodyType, __Params->sectionIndex, slotType, propertyName, __Params->value);
	}

	// Token: 0x0601ED76 RID: 126326 RVA: 0x0089D854 File Offset: 0x0089BA54
	protected unsafe override void __CPPCALL_SetMaterialPropertyFloatV2_Implementation(CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		base.SetMaterialPropertyFloatV2_Implementation(__Params->name, __Params->value, bodyType, slotType, meshPart);
	}

	// Token: 0x0601ED77 RID: 126327 RVA: 0x0089D88B File Offset: 0x0089BA8B
	protected unsafe override void __CPPCALL_AddFloatUpdateParamPermanentByIndexV2_Implementation(CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams* __Params)
	{
		base.AddFloatUpdateParamPermanentByIndexV2_Implementation(__Params->name, __Params->value, __Params->bodyName, __Params->materialIndex);
	}

	// Token: 0x0601ED78 RID: 126328 RVA: 0x0089D8AC File Offset: 0x0089BAAC
	protected unsafe override void __CPPCALL_SetMaterialPropertyColorV2_Implementation(CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		base.SetMaterialPropertyColorV2_Implementation(__Params->name, __Params->value, bodyType, slotType, meshPart);
	}

	// Token: 0x0601ED79 RID: 126329 RVA: 0x0089D8E4 File Offset: 0x0089BAE4
	protected unsafe override void __CPPCALL_SetMaterialReplaceV2_Implementation(CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams* __Params)
	{
		UMaterialInterface orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(__Params->material);
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		base.SetMaterialReplaceV2_Implementation(orCreateUObjectByNativePointer, bodyType, slotType, meshPart);
	}

	// Token: 0x0601ED7A RID: 126330 RVA: 0x0089D91C File Offset: 0x0089BB1C
	protected unsafe override void __CPPCALL_RemoveExternalMaterialReplaceV2_Implementation(CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		base.RemoveExternalMaterialReplaceV2_Implementation(bodyType, slotType, meshPart);
	}

	// Token: 0x0601ED7B RID: 126331 RVA: 0x0089D947 File Offset: 0x0089BB47
	protected unsafe override void __CPPCALL_SetStarScarEnergy_Implementation(CharRenderingComponent.__SetStarScarEnergy_FunctionParams* __Params)
	{
		base.SetStarScarEnergy_Implementation(__Params->value);
	}

	// Token: 0x0601ED7C RID: 126332 RVA: 0x0089D955 File Offset: 0x0089BB55
	protected unsafe override void __CPPCALL_SetCapsuleDither_Implementation(CharRenderingComponent.__SetCapsuleDither_FunctionParams* __Params)
	{
		base.SetCapsuleDither_Implementation(__Params->value);
	}

	// Token: 0x0601ED7D RID: 126333 RVA: 0x0089D963 File Offset: 0x0089BB63
	protected unsafe override void __CPPCALL_SetDecalShadowEnabled_Implementation(CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams* __Params)
	{
		base.SetDecalShadowEnabled_Implementation(__Params->enable);
	}

	// Token: 0x0601ED7E RID: 126334 RVA: 0x0089D971 File Offset: 0x0089BB71
	protected override void __CPPCALL_DisableAllShadowByDecalShadowComponent_Implementation()
	{
		base.DisableAllShadowByDecalShadowComponent_Implementation();
	}

	// Token: 0x0601ED7F RID: 126335 RVA: 0x0089D979 File Offset: 0x0089BB79
	protected unsafe override void __CPPCALL_SetShouldCastShadow_Implementation(CharRenderingComponent.__SetShouldCastShadow_FunctionParams* __Params)
	{
		base.SetShouldCastShadow_Implementation(__Params->castShadow);
	}

	// Token: 0x0601ED80 RID: 126336 RVA: 0x0089D987 File Offset: 0x0089BB87
	protected unsafe override void __CPPCALL_SetEffectProgress_Implementation(CharRenderingComponent.__SetEffectProgress_FunctionParams* __Params)
	{
		base.SetEffectProgress_Implementation(__Params->progress, __Params->handleId);
	}

	// Token: 0x0601ED81 RID: 126337 RVA: 0x0089D99B File Offset: 0x0089BB9B
	protected unsafe override void __CPPCALL_SetEffectGroupProgress_Implementation(CharRenderingComponent.__SetEffectGroupProgress_FunctionParams* __Params)
	{
		base.SetEffectGroupProgress_Implementation(__Params->progress, __Params->groupHandleId);
	}

	// Token: 0x0601ED82 RID: 126338 RVA: 0x0089D9AF File Offset: 0x0089BBAF
	protected override void __CPPCALL_RefreshMaterialController_Implementation()
	{
		base.RefreshMaterialController_Implementation();
	}

	// Token: 0x0601ED83 RID: 126339 RVA: 0x0089D9B7 File Offset: 0x0089BBB7
	protected override void __CPPCALL_Destroy_Implementation()
	{
		base.Destroy_Implementation();
	}

	// Token: 0x0601ED84 RID: 126340 RVA: 0x0089D9BF File Offset: 0x0089BBBF
	protected override void __CPPCALL_OnFinalizedLevelSequence_Implementation()
	{
		base.OnFinalizedLevelSequence_Implementation();
	}

	// Token: 0x0601ED85 RID: 126341 RVA: 0x0089D9C7 File Offset: 0x0089BBC7
	protected unsafe override void __CPPCALL_ShouldTickAfterGoDown_Implementation(CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams* __Params)
	{
		__Params->__Result = base.ShouldTickAfterGoDown_Implementation();
	}

	// Token: 0x0601ED86 RID: 126342 RVA: 0x0089D9D5 File Offset: 0x0089BBD5
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601ED87 RID: 126343 RVA: 0x0089D9DD File Offset: 0x0089BBDD
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(UActorComponent.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601ED88 RID: 126344 RVA: 0x0089D9EB File Offset: 0x0089BBEB
	protected unsafe override void __CPPCALL_ReceiveSeqTick_Implementation(CharRenderingComponent.__ReceiveSeqTick_FunctionParams* __Params)
	{
		base.ReceiveSeqTick_Implementation(__Params->deltaSeconds);
	}
}
