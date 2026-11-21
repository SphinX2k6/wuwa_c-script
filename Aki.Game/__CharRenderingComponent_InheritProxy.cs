using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Components;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialContainer;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.MaterialController;
using UnrealEngine;
using UnrealEngine.Utils;

// Token: 0x02002EF3 RID: 12019
public class __CharRenderingComponent_InheritProxy : CharRenderingComponent
{
	// Token: 0x0601C9B1 RID: 117169 RVA: 0x008BEF44 File Offset: 0x008BD144
	[NullableContext(1)]
	public __CharRenderingComponent_InheritProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CharRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x0601C9B2 RID: 117170 RVA: 0x008BEF77 File Offset: 0x008BD177
	protected __CharRenderingComponent_InheritProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x0601C9B3 RID: 117171 RVA: 0x008BEF80 File Offset: 0x008BD180
	protected unsafe override void __CPPCALL_QuickInitAndAddData_Implementation(CharRenderingComponent.__QuickInitAndAddData_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		ASkeletalMeshActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASkeletalMeshActor>(__Params->meshActor);
		__Params->__Result = base.QuickInitAndAddData_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601C9B4 RID: 117172 RVA: 0x008BEFB4 File Offset: 0x008BD1B4
	protected unsafe override void __CPPCALL_QuickInitAndAddDataWithMeshComponent_Implementation(CharRenderingComponent.__QuickInitAndAddDataWithMeshComponent_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		UMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->meshComponent);
		__Params->__Result = base.QuickInitAndAddDataWithMeshComponent_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601C9B5 RID: 117173 RVA: 0x008BEFE8 File Offset: 0x008BD1E8
	protected unsafe override void __CPPCALL_QuickInitAndAddDataGroup_Implementation(CharRenderingComponent.__QuickInitAndAddDataGroup_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		ASkeletalMeshActor orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<ASkeletalMeshActor>(__Params->meshActor);
		__Params->__Result = base.QuickInitAndAddDataGroup_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601C9B6 RID: 117174 RVA: 0x008BF01C File Offset: 0x008BD21C
	protected unsafe override void __CPPCALL_QuickInitAndAddDataGroupWithMeshComponent_Implementation(CharRenderingComponent.__QuickInitAndAddDataGroupWithMeshComponent_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		UMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->meshComponent);
		__Params->__Result = base.QuickInitAndAddDataGroupWithMeshComponent_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601C9B7 RID: 117175 RVA: 0x008BF050 File Offset: 0x008BD250
	protected unsafe override void __CPPCALL_Init_Implementation(CharRenderingComponent.__Init_FunctionParams* __Params)
	{
		ECharacterRenderingType renderType = (ECharacterRenderingType)__Params->renderType;
		base.Init_Implementation(renderType);
	}

	// Token: 0x0601C9B8 RID: 117176 RVA: 0x008BF06C File Offset: 0x008BD26C
	protected unsafe override void __CPPCALL_SetLogicOwner_Implementation(CharRenderingComponent.__SetLogicOwner_FunctionParams* __Params)
	{
		AActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->owner);
		base.SetLogicOwner_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C9B9 RID: 117177 RVA: 0x008BF08C File Offset: 0x008BD28C
	protected unsafe override void __CPPCALL_AddComponent_Implementation(CharRenderingComponent.__AddComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		base.AddComponent_Implementation(skelName, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C9BA RID: 117178 RVA: 0x008BF0BC File Offset: 0x008BD2BC
	protected unsafe override void __CPPCALL_AddComponentWithEmptyMaterial_Implementation(CharRenderingComponent.__AddComponentWithEmptyMaterial_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		base.AddComponentWithEmptyMaterial_Implementation(skelName, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C9BB RID: 117179 RVA: 0x008BF0EC File Offset: 0x008BD2EC
	protected unsafe override void __CPPCALL_RemoveComponent_Implementation(CharRenderingComponent.__RemoveComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		base.RemoveComponent_Implementation(skelName);
	}

	// Token: 0x0601C9BC RID: 117180 RVA: 0x008BF110 File Offset: 0x008BD310
	protected unsafe override void __CPPCALL_AddComponentByCase_Implementation(CharRenderingComponent.__AddComponentByCase_FunctionParams* __Params)
	{
		ECharacterControllerCaseType caseType = (ECharacterControllerCaseType)__Params->caseType;
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		base.AddComponentByCase_Implementation(caseType, orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C9BD RID: 117181 RVA: 0x008BF138 File Offset: 0x008BD338
	protected unsafe override void __CPPCALL_RemoveComponentByCase_Implementation(CharRenderingComponent.__RemoveComponentByCase_FunctionParams* __Params)
	{
		ECharacterControllerCaseType caseType = (ECharacterControllerCaseType)__Params->caseType;
		base.RemoveComponentByCase_Implementation(caseType);
	}

	// Token: 0x0601C9BE RID: 117182 RVA: 0x008BF154 File Offset: 0x008BD354
	protected unsafe override void __CPPCALL_AddComponentInnerV2_Implementation(CharRenderingComponent.__AddComponentInnerV2_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		UMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMeshComponent>(__Params->skeletalComp);
		base.AddComponentInnerV2_Implementation(skelName, orCreateUObjectByNativePointer, __Params->useEmptyMaterial);
	}

	// Token: 0x0601C9BF RID: 117183 RVA: 0x008BF188 File Offset: 0x008BD388
	protected unsafe override void __CPPCALL_RemoveComponentInnerV2_Implementation(CharRenderingComponent.__RemoveComponentInnerV2_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		base.RemoveComponentInnerV2_Implementation(skelName);
	}

	// Token: 0x0601C9C0 RID: 117184 RVA: 0x008BF1AC File Offset: 0x008BD3AC
	protected unsafe override void __CPPCALL_GetSkeletalMeshComponent_Implementation(CharRenderingComponent.__GetSkeletalMeshComponent_FunctionParams* __Params)
	{
		string skelName = FString.ToString((void*)(&__Params->skelName));
		ref IntPtr ptr = ref *(&__Params->__Result);
		USkeletalMeshComponent skeletalMeshComponent_Implementation = base.GetSkeletalMeshComponent_Implementation(skelName);
		ptr = ((skeletalMeshComponent_Implementation != null) ? skeletalMeshComponent_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601C9C1 RID: 117185 RVA: 0x008BF1E4 File Offset: 0x008BD3E4
	protected unsafe override void __CPPCALL_GetSkeletalMeshComponentBodyName_Implementation(CharRenderingComponent.__GetSkeletalMeshComponentBodyName_FunctionParams* __Params)
	{
		USkeletalMeshComponent orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->skeletalComp);
		__Params->__Result = base.GetSkeletalMeshComponentBodyName_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C9C2 RID: 117186 RVA: 0x008BF20A File Offset: 0x008BD40A
	protected unsafe override void __CPPCALL_CheckInit_Implementation(CharRenderingComponent.__CheckInit_FunctionParams* __Params)
	{
		__Params->__Result = base.CheckInit_Implementation();
	}

	// Token: 0x0601C9C3 RID: 117187 RVA: 0x008BF218 File Offset: 0x008BD418
	protected unsafe override void __CPPCALL_SetDebug_Implementation(CharRenderingComponent.__SetDebug_FunctionParams* __Params)
	{
		base.SetDebug_Implementation(__Params->value);
	}

	// Token: 0x0601C9C4 RID: 117188 RVA: 0x008BF226 File Offset: 0x008BD426
	protected unsafe override void __CPPCALL_GetDebugInfo_Implementation(CharRenderingComponent.__GetDebugInfo_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		PD_MaterialDebug_C debugInfo_Implementation = base.GetDebugInfo_Implementation();
		ptr = ((debugInfo_Implementation != null) ? debugInfo_Implementation.NativePtr : ((IntPtr)0));
	}

	// Token: 0x0601C9C5 RID: 117189 RVA: 0x008BF244 File Offset: 0x008BD444
	protected unsafe override void __CPPCALL_ReceiveEndPlay_Implementation(UActorComponent.__ReceiveEndPlay_FunctionParams* __Params)
	{
		EEndPlayReason endPlayReason = __Params->EndPlayReason;
		base.ReceiveEndPlay_Implementation(endPlayReason);
	}

	// Token: 0x0601C9C6 RID: 117190 RVA: 0x008BF264 File Offset: 0x008BD464
	protected unsafe override void __CPPCALL_GetInWater_Implementation(CharRenderingComponent.__GetInWater_FunctionParams* __Params)
	{
		__Params->__Result = base.GetInWater_Implementation(__Params->depthThreshold);
	}

	// Token: 0x0601C9C7 RID: 117191 RVA: 0x008BF278 File Offset: 0x008BD478
	protected unsafe override void __CPPCALL_GetInAudioShr_Implementation(CharRenderingComponent.__GetInAudioShr_FunctionParams* __Params)
	{
		__Params->__Result = base.GetInAudioShr_Implementation();
	}

	// Token: 0x0601C9C8 RID: 117192 RVA: 0x008BF286 File Offset: 0x008BD486
	protected override void __CPPCALL_ResetAllRenderingState_Implementation()
	{
		base.ResetAllRenderingState_Implementation();
	}

	// Token: 0x0601C9C9 RID: 117193 RVA: 0x008BF290 File Offset: 0x008BD490
	protected unsafe override void __CPPCALL_AddMaterialControllerDataGroup_Implementation(CharRenderingComponent.__AddMaterialControllerDataGroup_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		__Params->__Result = base.AddMaterialControllerDataGroup_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C9CA RID: 117194 RVA: 0x008BF2B8 File Offset: 0x008BD4B8
	protected unsafe override void __CPPCALL_AddMaterialControllerDataGroupWithAnimObject_Implementation(CharRenderingComponent.__AddMaterialControllerDataGroupWithAnimObject_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->animObject);
		__Params->__Result = base.AddMaterialControllerDataGroupWithAnimObject_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2);
	}

	// Token: 0x0601C9CB RID: 117195 RVA: 0x008BF2EB File Offset: 0x008BD4EB
	protected unsafe override void __CPPCALL_RemoveMaterialControllerDataGroup_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataGroup_FunctionParams* __Params)
	{
		base.RemoveMaterialControllerDataGroup_Implementation(__Params->handle);
	}

	// Token: 0x0601C9CC RID: 117196 RVA: 0x008BF2F9 File Offset: 0x008BD4F9
	protected unsafe override void __CPPCALL_RemoveMaterialControllerDataGroupWithEnding_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataGroupWithEnding_FunctionParams* __Params)
	{
		base.RemoveMaterialControllerDataGroupWithEnding_Implementation(__Params->handle);
	}

	// Token: 0x0601C9CD RID: 117197 RVA: 0x008BF308 File Offset: 0x008BD508
	protected unsafe override void __CPPCALL_AddMaterialControllerDataWithAnimObject_Implementation(CharRenderingComponent.__AddMaterialControllerDataWithAnimObject_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		USkeletalMeshComponent orCreateUObjectByNativePointer2 = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(__Params->animObject);
		UObject orCreateUObjectByNativePointer3 = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->userData);
		__Params->__Result = base.AddMaterialControllerDataWithAnimObject_Implementation(orCreateUObjectByNativePointer, orCreateUObjectByNativePointer2, orCreateUObjectByNativePointer3);
	}

	// Token: 0x0601C9CE RID: 117198 RVA: 0x008BF348 File Offset: 0x008BD548
	protected unsafe override void __CPPCALL_AddMaterialControllerData_Implementation(CharRenderingComponent.__AddMaterialControllerData_FunctionParams* __Params)
	{
		UObject orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(__Params->data);
		__Params->__Result = base.AddMaterialControllerData_Implementation(orCreateUObjectByNativePointer);
	}

	// Token: 0x0601C9CF RID: 117199 RVA: 0x008BF36E File Offset: 0x008BD56E
	protected unsafe override void __CPPCALL_RemoveMaterialControllerData_Implementation(CharRenderingComponent.__RemoveMaterialControllerData_FunctionParams* __Params)
	{
		base.RemoveMaterialControllerData_Implementation(__Params->handle);
	}

	// Token: 0x0601C9D0 RID: 117200 RVA: 0x008BF37C File Offset: 0x008BD57C
	protected unsafe override void __CPPCALL_SetEffectPause_Implementation(CharRenderingComponent.__SetEffectPause_FunctionParams* __Params)
	{
		base.SetEffectPause_Implementation(__Params->handle, __Params->paused);
	}

	// Token: 0x0601C9D1 RID: 117201 RVA: 0x008BF390 File Offset: 0x008BD590
	protected unsafe override void __CPPCALL_RemoveMaterialControllerDataWithEnding_Implementation(CharRenderingComponent.__RemoveMaterialControllerDataWithEnding_FunctionParams* __Params)
	{
		base.RemoveMaterialControllerDataWithEnding_Implementation(__Params->handle);
	}

	// Token: 0x0601C9D2 RID: 117202 RVA: 0x008BF3A0 File Offset: 0x008BD5A0
	protected unsafe override void __CPPCALL_SetDitherEffect_Implementation(CharRenderingComponent.__SetDitherEffect_FunctionParams* __Params)
	{
		ECharacterDitherType ditherType = (ECharacterDitherType)__Params->ditherType;
		base.SetDitherEffect_Implementation(__Params->ditherRate, ditherType);
	}

	// Token: 0x0601C9D3 RID: 117203 RVA: 0x008BF3C1 File Offset: 0x008BD5C1
	protected unsafe override void __CPPCALL_SetDisableFightDither_Implementation(CharRenderingComponent.__SetDisableFightDither_FunctionParams* __Params)
	{
		base.SetDisableFightDither_Implementation(__Params->disable);
	}

	// Token: 0x0601C9D4 RID: 117204 RVA: 0x008BF3CF File Offset: 0x008BD5CF
	protected override void __CPPCALL_SetDitherApplyAll_Implementation()
	{
		base.SetDitherApplyAll_Implementation();
	}

	// Token: 0x0601C9D5 RID: 117205 RVA: 0x008BF3D7 File Offset: 0x008BD5D7
	protected override void __CPPCALL_SetDitherApplyHeadsOnly_Implementation()
	{
		base.SetDitherApplyHeadsOnly_Implementation();
	}

	// Token: 0x0601C9D6 RID: 117206 RVA: 0x008BF3DF File Offset: 0x008BD5DF
	protected unsafe override void __CPPCALL_SetDitherUseHeadMaskHideEffect_Implementation(CharRenderingComponent.__SetDitherUseHeadMaskHideEffect_FunctionParams* __Params)
	{
		base.SetDitherUseHeadMaskHideEffect_Implementation(__Params->enable);
	}

	// Token: 0x0601C9D7 RID: 117207 RVA: 0x008BF3ED File Offset: 0x008BD5ED
	protected override void __CPPCALL_TempRemoveDither_Implementation()
	{
		base.TempRemoveDither_Implementation();
	}

	// Token: 0x0601C9D8 RID: 117208 RVA: 0x008BF3F5 File Offset: 0x008BD5F5
	protected override void __CPPCALL_TempRecoverDither_Implementation()
	{
		base.TempRecoverDither_Implementation();
	}

	// Token: 0x0601C9D9 RID: 117209 RVA: 0x008BF3FD File Offset: 0x008BD5FD
	protected unsafe override void __CPPCALL_GetOpacityConsiderVisibility_Implementation(CharRenderingComponent.__GetOpacityConsiderVisibility_FunctionParams* __Params)
	{
		__Params->__Result = base.GetOpacityConsiderVisibility_Implementation();
	}

	// Token: 0x0601C9DA RID: 117210 RVA: 0x008BF40C File Offset: 0x008BD60C
	protected unsafe override void __CPPCALL_SetMaterialPropertyFloat_Implementation(CharRenderingComponent.__SetMaterialPropertyFloat_FunctionParams* __Params)
	{
		ECharacterBodySpecifiedType bodyType = (ECharacterBodySpecifiedType)__Params->bodyType;
		ECharacterSlotSpecifiedType slotType = (ECharacterSlotSpecifiedType)__Params->slotType;
		string propertyName = FString.ToString((void*)(&__Params->propertyName));
		base.SetMaterialPropertyFloat_Implementation(bodyType, __Params->sectionIndex, slotType, propertyName, __Params->value);
	}

	// Token: 0x0601C9DB RID: 117211 RVA: 0x008BF44C File Offset: 0x008BD64C
	protected unsafe override void __CPPCALL_SetMaterialPropertyColor_Implementation(CharRenderingComponent.__SetMaterialPropertyColor_FunctionParams* __Params)
	{
		ECharacterBodySpecifiedType bodyType = (ECharacterBodySpecifiedType)__Params->bodyType;
		ECharacterSlotSpecifiedType slotType = (ECharacterSlotSpecifiedType)__Params->slotType;
		string propertyName = FString.ToString((void*)(&__Params->propertyName));
		base.SetMaterialPropertyColor_Implementation(bodyType, __Params->sectionIndex, slotType, propertyName, __Params->value);
	}

	// Token: 0x0601C9DC RID: 117212 RVA: 0x008BF48C File Offset: 0x008BD68C
	protected unsafe override void __CPPCALL_SetMaterialPropertyFloatV2_Implementation(CharRenderingComponent.__SetMaterialPropertyFloatV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		base.SetMaterialPropertyFloatV2_Implementation(__Params->name, __Params->value, bodyType, slotType, meshPart);
	}

	// Token: 0x0601C9DD RID: 117213 RVA: 0x008BF4C3 File Offset: 0x008BD6C3
	protected unsafe override void __CPPCALL_AddFloatUpdateParamPermanentByIndexV2_Implementation(CharRenderingComponent.__AddFloatUpdateParamPermanentByIndexV2_FunctionParams* __Params)
	{
		base.AddFloatUpdateParamPermanentByIndexV2_Implementation(__Params->name, __Params->value, __Params->bodyName, __Params->materialIndex);
	}

	// Token: 0x0601C9DE RID: 117214 RVA: 0x008BF4E4 File Offset: 0x008BD6E4
	protected unsafe override void __CPPCALL_SetMaterialPropertyColorV2_Implementation(CharRenderingComponent.__SetMaterialPropertyColorV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		base.SetMaterialPropertyColorV2_Implementation(__Params->name, __Params->value, bodyType, slotType, meshPart);
	}

	// Token: 0x0601C9DF RID: 117215 RVA: 0x008BF51C File Offset: 0x008BD71C
	protected unsafe override void __CPPCALL_SetMaterialReplaceV2_Implementation(CharRenderingComponent.__SetMaterialReplaceV2_FunctionParams* __Params)
	{
		UMaterialInterface orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(__Params->material);
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		base.SetMaterialReplaceV2_Implementation(orCreateUObjectByNativePointer, bodyType, slotType, meshPart);
	}

	// Token: 0x0601C9E0 RID: 117216 RVA: 0x008BF554 File Offset: 0x008BD754
	protected unsafe override void __CPPCALL_RemoveExternalMaterialReplaceV2_Implementation(CharRenderingComponent.__RemoveExternalMaterialReplaceV2_FunctionParams* __Params)
	{
		EKuroCharBodySpecifiedType bodyType = (EKuroCharBodySpecifiedType)__Params->bodyType;
		EKuroCharSlotSpecifiedType slotType = (EKuroCharSlotSpecifiedType)__Params->slotType;
		EKuroCharMeshPart meshPart = (EKuroCharMeshPart)__Params->meshPart;
		base.RemoveExternalMaterialReplaceV2_Implementation(bodyType, slotType, meshPart);
	}

	// Token: 0x0601C9E1 RID: 117217 RVA: 0x008BF57F File Offset: 0x008BD77F
	protected unsafe override void __CPPCALL_SetStarScarEnergy_Implementation(CharRenderingComponent.__SetStarScarEnergy_FunctionParams* __Params)
	{
		base.SetStarScarEnergy_Implementation(__Params->value);
	}

	// Token: 0x0601C9E2 RID: 117218 RVA: 0x008BF58D File Offset: 0x008BD78D
	protected unsafe override void __CPPCALL_SetCapsuleDither_Implementation(CharRenderingComponent.__SetCapsuleDither_FunctionParams* __Params)
	{
		base.SetCapsuleDither_Implementation(__Params->value);
	}

	// Token: 0x0601C9E3 RID: 117219 RVA: 0x008BF59B File Offset: 0x008BD79B
	protected unsafe override void __CPPCALL_SetDecalShadowEnabled_Implementation(CharRenderingComponent.__SetDecalShadowEnabled_FunctionParams* __Params)
	{
		base.SetDecalShadowEnabled_Implementation(__Params->enable);
	}

	// Token: 0x0601C9E4 RID: 117220 RVA: 0x008BF5A9 File Offset: 0x008BD7A9
	protected override void __CPPCALL_DisableAllShadowByDecalShadowComponent_Implementation()
	{
		base.DisableAllShadowByDecalShadowComponent_Implementation();
	}

	// Token: 0x0601C9E5 RID: 117221 RVA: 0x008BF5B1 File Offset: 0x008BD7B1
	protected unsafe override void __CPPCALL_SetShouldCastShadow_Implementation(CharRenderingComponent.__SetShouldCastShadow_FunctionParams* __Params)
	{
		base.SetShouldCastShadow_Implementation(__Params->castShadow);
	}

	// Token: 0x0601C9E6 RID: 117222 RVA: 0x008BF5BF File Offset: 0x008BD7BF
	protected unsafe override void __CPPCALL_SetEffectProgress_Implementation(CharRenderingComponent.__SetEffectProgress_FunctionParams* __Params)
	{
		base.SetEffectProgress_Implementation(__Params->progress, __Params->handleId);
	}

	// Token: 0x0601C9E7 RID: 117223 RVA: 0x008BF5D3 File Offset: 0x008BD7D3
	protected unsafe override void __CPPCALL_SetEffectGroupProgress_Implementation(CharRenderingComponent.__SetEffectGroupProgress_FunctionParams* __Params)
	{
		base.SetEffectGroupProgress_Implementation(__Params->progress, __Params->groupHandleId);
	}

	// Token: 0x0601C9E8 RID: 117224 RVA: 0x008BF5E7 File Offset: 0x008BD7E7
	protected override void __CPPCALL_RefreshMaterialController_Implementation()
	{
		base.RefreshMaterialController_Implementation();
	}

	// Token: 0x0601C9E9 RID: 117225 RVA: 0x008BF5EF File Offset: 0x008BD7EF
	protected override void __CPPCALL_Destroy_Implementation()
	{
		base.Destroy_Implementation();
	}

	// Token: 0x0601C9EA RID: 117226 RVA: 0x008BF5F7 File Offset: 0x008BD7F7
	protected override void __CPPCALL_OnFinalizedLevelSequence_Implementation()
	{
		base.OnFinalizedLevelSequence_Implementation();
	}

	// Token: 0x0601C9EB RID: 117227 RVA: 0x008BF5FF File Offset: 0x008BD7FF
	protected unsafe override void __CPPCALL_ShouldTickAfterGoDown_Implementation(CharRenderingComponent.__ShouldTickAfterGoDown_FunctionParams* __Params)
	{
		__Params->__Result = base.ShouldTickAfterGoDown_Implementation();
	}

	// Token: 0x0601C9EC RID: 117228 RVA: 0x008BF60D File Offset: 0x008BD80D
	protected override void __CPPCALL_ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
	}

	// Token: 0x0601C9ED RID: 117229 RVA: 0x008BF615 File Offset: 0x008BD815
	protected unsafe override void __CPPCALL_ReceiveTick_Implementation(UActorComponent.__ReceiveTick_FunctionParams* __Params)
	{
		base.ReceiveTick_Implementation(__Params->DeltaSeconds);
	}

	// Token: 0x0601C9EE RID: 117230 RVA: 0x008BF623 File Offset: 0x008BD823
	protected unsafe override void __CPPCALL_ReceiveSeqTick_Implementation(CharRenderingComponent.__ReceiveSeqTick_FunctionParams* __Params)
	{
		base.ReceiveSeqTick_Implementation(__Params->deltaSeconds);
	}
}
