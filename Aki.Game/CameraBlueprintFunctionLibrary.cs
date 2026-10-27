using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.Camera.CameraDebugTool;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001EE RID: 494
[UClass("/Game/Aki/TypeScript/Game/Camera/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Camera/CameraBlueprintFunctionLibrary.CameraBlueprintFunctionLibrary_C")]
public class CameraBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001E9F RID: 7839 RVA: 0x00098BF0 File Offset: 0x00096DF0
	static CameraBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CameraBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(CameraBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x170004F2 RID: 1266
	// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00098C0F File Offset: 0x00096E0F
	[Nullable(1)]
	private static Vector TmpVector
	{
		[NullableContext(1)]
		get
		{
			if (CameraBlueprintFunctionLibrary._tmpVectorInternal == null)
			{
				CameraBlueprintFunctionLibrary._tmpVectorInternal = Vector.Create();
			}
			return CameraBlueprintFunctionLibrary._tmpVectorInternal;
		}
	}

	// Token: 0x170004F3 RID: 1267
	// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x00098C27 File Offset: 0x00096E27
	[Nullable(1)]
	private static Quat TmpQuat
	{
		[NullableContext(1)]
		get
		{
			if (CameraBlueprintFunctionLibrary._tmpQuatInternal == null)
			{
				CameraBlueprintFunctionLibrary._tmpQuatInternal = Quat.Create(0.0, 0.0, 0.0, 1.0);
			}
			return CameraBlueprintFunctionLibrary._tmpQuatInternal;
		}
	}

	// Token: 0x170004F4 RID: 1268
	// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x00098C63 File Offset: 0x00096E63
	[Nullable(1)]
	private static Vector2D TmpVector2D1
	{
		[NullableContext(1)]
		get
		{
			if (CameraBlueprintFunctionLibrary._tmpVector2D1Internal == null)
			{
				CameraBlueprintFunctionLibrary._tmpVector2D1Internal = Vector2D.Create();
			}
			return CameraBlueprintFunctionLibrary._tmpVector2D1Internal;
		}
	}

	// Token: 0x170004F5 RID: 1269
	// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x00098C7B File Offset: 0x00096E7B
	[Nullable(1)]
	private static Vector2D TmpVector2D2
	{
		[NullableContext(1)]
		get
		{
			if (CameraBlueprintFunctionLibrary._tmpVector2D2Internal == null)
			{
				CameraBlueprintFunctionLibrary._tmpVector2D2Internal = Vector2D.Create();
			}
			return CameraBlueprintFunctionLibrary._tmpVector2D2Internal;
		}
	}

	// Token: 0x06001EA4 RID: 7844 RVA: 0x00098C93 File Offset: 0x00096E93
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OnPossess(APawn pawn)
	{
		CameraController.Instance.OnPossess(pawn, "MainCamera");
	}

	// Token: 0x06001EA5 RID: 7845 RVA: 0x00098CA8 File Offset: 0x00096EA8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ECustomCameraMode GetCameraMode()
	{
		return CameraController.Instance.MainModel.CameraMode.Value;
	}

	// Token: 0x06001EA6 RID: 7846 RVA: 0x00098CCC File Offset: 0x00096ECC
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static UCameraComponent GetPhotoCameraComponent()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		CameraSpecialGameplayController cameraSpecialGameplayController = (fightCameraLogicComponent != null) ? fightCameraLogicComponent.CameraSpecialGameplayController : null;
		PhotoCamera photoCamera = (cameraSpecialGameplayController != null) ? cameraSpecialGameplayController.GetCurrentGameplay<PhotoCamera>() : null;
		ACameraActor acameraActor = (photoCamera != null) ? photoCamera.CameraActor : null;
		if (acameraActor == null)
		{
			return null;
		}
		return acameraActor.CameraComponent;
	}

	// Token: 0x06001EA7 RID: 7847 RVA: 0x00098D23 File Offset: 0x00096F23
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ALevelSequenceActor GetSequenceCameraActor()
	{
		return CameraController.Instance.MainModel.SequenceCamera.PlayerComponent.GetCurrentLevelSequenceActor();
	}

	// Token: 0x06001EA8 RID: 7848 RVA: 0x00098D40 File Offset: 0x00096F40
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnterCameraMode(ECustomCameraMode cameraMode, float blendTime, TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction, float blendExp)
	{
		TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> tenumAsByte = blendFunction;
		if (tenumAsByte == UnrealEngine.EViewTargetBlendFunction.VTBlend_CurveAsset)
		{
			global::Log.Instance.Warn(ELogModule.Camera, ELogAuthor.ZJL, "EnterCameraMode暂时不支持CurveAsset作为BlendFunction，已自动回退到Linear", default(ReadOnlySpan<ValueTuple<string, object>>));
			tenumAsByte = UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear;
		}
		CameraController.Instance.EnterCameraMode(cameraMode, blendTime, tenumAsByte, blendExp, null, false, "MainCamera", null);
	}

	// Token: 0x06001EA9 RID: 7849 RVA: 0x00098D9C File Offset: 0x00096F9C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitCameraMode(ECustomCameraMode cameraMode, float blendTime, TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction, float blendExp)
	{
		TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> tenumAsByte = blendFunction;
		if (tenumAsByte == UnrealEngine.EViewTargetBlendFunction.VTBlend_CurveAsset)
		{
			global::Log.Instance.Warn(ELogModule.Camera, ELogAuthor.ZJL, "ExitCameraMode暂时不支持CurveAsset作为BlendFunction，已自动回退到Linear", default(ReadOnlySpan<ValueTuple<string, object>>));
			tenumAsByte = UnrealEngine.EViewTargetBlendFunction.VTBlend_Linear;
		}
		CameraController.Instance.ExitCameraMode(cameraMode, blendTime, tenumAsByte, blendExp, null, "MainCamera", null);
	}

	// Token: 0x06001EAA RID: 7850 RVA: 0x00098DF7 File Offset: 0x00096FF7
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCameraRotation(FRotator rotator)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(rotator);
	}

	// Token: 0x06001EAB RID: 7851 RVA: 0x00098E13 File Offset: 0x00097013
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsTargetSocketLocationValid()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.IsTargetLocationValid;
	}

	// Token: 0x06001EAC RID: 7852 RVA: 0x00098E2E File Offset: 0x0009702E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetTargetSocketLocation()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.TargetLocation.ToUeVector(false);
	}

	// Token: 0x06001EAD RID: 7853 RVA: 0x00098E4F File Offset: 0x0009704F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetFightCameraLocation()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraLocation.ToUeVector(false);
	}

	// Token: 0x06001EAE RID: 7854 RVA: 0x00098E70 File Offset: 0x00097070
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FRotator GetFightCameraRotation()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraRotation.ToUeRotator();
	}

	// Token: 0x06001EAF RID: 7855 RVA: 0x00098E90 File Offset: 0x00097090
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVector GetFightCameraForward(int index)
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraForward.ToUeVectorOld();
	}

	// Token: 0x06001EB0 RID: 7856 RVA: 0x00098EB0 File Offset: 0x000970B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ACameraActor GetFightCameraActor()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraActor;
	}

	// Token: 0x06001EB1 RID: 7857 RVA: 0x00098ECB File Offset: 0x000970CB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetFightCameraFollow(bool follow)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.IsFollowing = follow;
	}

	// Token: 0x06001EB2 RID: 7858 RVA: 0x00098EE8 File Offset: 0x000970E8
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ApplyCameraModify(FGameplayTag tag, float duration, float blendInTime, float blendOutTime, float breakBlendOutTime, SCameraModifier_Settings cameraModifySettings, UAnimMontage montage, SBaseCurve blendInCurve, SBaseCurve blendOutCurve, string cameraAttachSocket, int entityId, ECameraAnsEffectiveClientType cameraEffectiveClientType, ref TArray<SCameraModifier_Condition> cameraModifierConditions)
	{
		if (!CameraUtility.CheckApplyCameraModifyCondition(CreatureModel.Instance.GetEntityById(entityId), cameraModifySettings, cameraEffectiveClientType, cameraModifierConditions))
		{
			return;
		}
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ApplyCameraModify(new FGameplayTag?(tag), duration, blendInTime, blendOutTime, cameraModifySettings, montage, breakBlendOutTime, blendInCurve, blendOutCurve, default(OneOf<TsBaseCharacter, TsBaseVehicle>), cameraAttachSocket, default(OneOf<TsBaseCharacter, TsBaseVehicle>));
	}

	// Token: 0x06001EB3 RID: 7859 RVA: 0x00098F51 File Offset: 0x00097151
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ForceStopCameraModify(bool withFadeOut)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ForceStopModify(withFadeOut);
	}

	// Token: 0x06001EB4 RID: 7860 RVA: 0x00098F70 File Offset: 0x00097170
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ApplyCameraGuide(FVector lookAt, float fadeInTime, float stayTime, float fadeOutTime, bool lockCameraInput, FVector endPosition, float fov, bool ignoreAdjustYaw, bool staticCamera)
	{
		if (CameraBlueprintFunctionLibrary._cacheLookAtVector == null)
		{
			CameraBlueprintFunctionLibrary._cacheLookAtVector = Vector.Create();
		}
		if (CameraBlueprintFunctionLibrary._cacheLookAtVector1 == null)
		{
			CameraBlueprintFunctionLibrary._cacheLookAtVector1 = Vector.Create();
		}
		CameraBlueprintFunctionLibrary._cacheLookAtVector.FromUeVector(lookAt);
		Vector endPosition2 = null;
		if (!endPosition.IsNearlyZero(0.0001f))
		{
			CameraBlueprintFunctionLibrary._cacheLookAtVector1.FromUeVector(endPosition);
			endPosition2 = CameraBlueprintFunctionLibrary._cacheLookAtVector1;
		}
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ApplyCameraGuide(CameraBlueprintFunctionLibrary._cacheLookAtVector, fadeInTime, stayTime, fadeOutTime, lockCameraInput, endPosition2, (fov == 0f) ? null : new float?(fov), ignoreAdjustYaw, staticCamera, 0f, false, null, false);
	}

	// Token: 0x06001EB5 RID: 7861 RVA: 0x00099018 File Offset: 0x00097218
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitCameraGuide()
	{
		global::Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraLookAt] ExitCameraGuide", default(ReadOnlySpan<ValueTuple<string, object>>));
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraGuide();
	}

	// Token: 0x06001EB6 RID: 7862 RVA: 0x0009905C File Offset: 0x0009725C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnterCameraExplore(int id, FVector lookAt1, FVector lookAt2, float prepTime, float fadeDistance, float armLengthMin, float armLengthMax)
	{
		FVectorDouble value = UKismetMathLibrary.Conv_VectorToVectorDouble(lookAt1);
		FVectorDouble value2 = UKismetMathLibrary.Conv_VectorToVectorDouble(lookAt2);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.EnterCameraExplore(id, new FVectorDouble?(value), new FVectorDouble?(value2), prepTime, fadeDistance, armLengthMin, armLengthMax);
	}

	// Token: 0x06001EB7 RID: 7863 RVA: 0x000990A4 File Offset: 0x000972A4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitCameraExplore(int id)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraExplore(id);
	}

	// Token: 0x06001EB8 RID: 7864 RVA: 0x000990C0 File Offset: 0x000972C0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool PlayCameraSequence(ESequenceCameraAnsEffectiveClientType 生效客户端, int entityId, SSequenceCamera_Settings settings, bool resetLockOnCamera, FRotator additiveRotation, string cameraAttachSocket, string cameraDetectSocket, FVector extraSphereLocation, float extraDetectSphereRadius, bool isShowExtraSphere, bool isIgnoreCharacterCollision, bool disableMovementInput, bool disableLookAtInput, bool disableMotionBlur)
	{
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(entityId);
		if (entityById == null)
		{
			return false;
		}
		WorldEntity entity = entityById.Entity;
		TsBaseCharacter tsBaseCharacter;
		if (entity == null)
		{
			tsBaseCharacter = null;
		}
		else
		{
			CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
			tsBaseCharacter = ((component != null) ? component.Actor : null);
		}
		TsBaseCharacter tsBaseCharacter2 = tsBaseCharacter;
		if (tsBaseCharacter2 == null)
		{
			return false;
		}
		if (!CameraUtility.CheckCameraSequenceCondition(tsBaseCharacter2, 生效客户端))
		{
			return false;
		}
		WorldEntity entity2 = entityById.Entity;
		BaseSkillComponent baseSkillComponent = (entity2 != null) ? entity2.GetComponent<BaseSkillComponent>() : null;
		Skill skill = (baseSkillComponent != null) ? baseSkillComponent.CurrentSkill : null;
		int? skillEntityId = (skill != null) ? new int?(entityId) : null;
		int? num = (skill != null) ? new int?(skill.SkillId) : null;
		long? skillId = (num != null) ? new long?((long)num.GetValueOrDefault()) : null;
		return CameraController.Instance.MainModel.SequenceCamera.PlayerComponent.PlayCameraSequence(settings, resetLockOnCamera, additiveRotation, tsBaseCharacter2, StringUtils.IsEmpty(cameraAttachSocket) ? FNameUtil.EMPTY : FNameUtil.GetDynamicFName(cameraAttachSocket).Value, StringUtils.IsEmpty(cameraDetectSocket) ? FNameUtil.EMPTY : FNameUtil.GetDynamicFName(cameraDetectSocket).Value, extraSphereLocation, extraDetectSphereRadius, isShowExtraSphere, isIgnoreCharacterCollision, disableMovementInput, disableLookAtInput, disableMotionBlur, false, null, skillEntityId, skillId);
	}

	// Token: 0x06001EB9 RID: 7865 RVA: 0x000991F0 File Offset: 0x000973F0
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ACameraActor GetWidgetCameraActor()
	{
		return CameraController.Instance.MainModel.WidgetCamera.DisplayComponent.CineCamera;
	}

	// Token: 0x06001EBA RID: 7866 RVA: 0x0009920C File Offset: 0x0009740C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetWidgetCameraBlendParams(float blendTime, TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction, float blendExp, bool blendLocation, bool isRelativeLocation, bool overrideLocation, FVector newLocation, bool blendRotation, bool isRelativeRotation, bool overrideRotation, FRotator newRotation)
	{
		FVectorDouble newLocation2 = UKismetMathLibrary.Conv_VectorToVectorDouble(newLocation);
		CameraController.Instance.MainModel.WidgetCamera.BlendComponent.SetBlendParams(blendTime, blendFunction, (byte)blendExp, blendLocation, isRelativeLocation, overrideLocation, newLocation2, blendRotation, isRelativeRotation, overrideRotation, newRotation);
	}

	// Token: 0x06001EBB RID: 7867 RVA: 0x00099251 File Offset: 0x00097451
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlayCameraOrbital(ULevelSequence levelSequence, FVector startLocation, FVector endLocation, float blendInTime, float blendOutTime)
	{
		CameraController.Instance.MainModel.OrbitalCamera.PlayerComponent.PlayCameraOrbital(levelSequence, startLocation, endLocation, blendInTime, blendOutTime);
	}

	// Token: 0x06001EBC RID: 7868 RVA: 0x00099272 File Offset: 0x00097472
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopCameraOrbital()
	{
		CameraController.Instance.MainModel.OrbitalCamera.PlayerComponent.StopCameraOrbital();
	}

	// Token: 0x06001EBD RID: 7869 RVA: 0x0009928D File Offset: 0x0009748D
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ResetFightCameraPitchAndArmLength()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetArmLengthAndRotation(Rotator.ZeroRotator);
	}

	// Token: 0x06001EBE RID: 7870 RVA: 0x000992B0 File Offset: 0x000974B0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnterSequenceDialogue(AActor target)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraDialogueController.EnterSequenceDialogue(Vector.Create(target.D_K2_GetActorLocation()), false, null, null);
	}

	// Token: 0x06001EBF RID: 7871 RVA: 0x000992FE File Offset: 0x000974FE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitSequenceDialogue()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraDialogueController.ExitSequenceDialogue();
	}

	// Token: 0x06001EC0 RID: 7872 RVA: 0x0009931E File Offset: 0x0009751E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ReloadCameraConfig()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.LoadConfig();
		CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraConfigController.LoadConfig();
	}

	// Token: 0x06001EC1 RID: 7873 RVA: 0x00099357 File Offset: 0x00097557
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetAimAssistMode(EAimAssistMode mode)
	{
		CameraController.Instance.MainModel.SetAimAssistMode(mode);
	}

	// Token: 0x06001EC2 RID: 7874 RVA: 0x0009936C File Offset: 0x0009756C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsRoleOnCameraRight()
	{
		BaseActorComponent component = Global.BaseCharacter.GetEntityNoBlueprint().GetComponent<BaseActorComponent>();
		FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
		logicComponent.CameraRotation.Quaternion(CameraBlueprintFunctionLibrary.TmpQuat);
		CameraBlueprintFunctionLibrary.TmpQuat.RotateVector(Vector.RightVectorProxy, CameraBlueprintFunctionLibrary.TmpVector);
		return component.ActorLocationProxy.DotProduct(CameraBlueprintFunctionLibrary.TmpVector) - logicComponent.CameraLocation.DotProduct(CameraBlueprintFunctionLibrary.TmpVector) > 0.0;
	}

	// Token: 0x06001EC3 RID: 7875 RVA: 0x000993ED File Offset: 0x000975ED
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCameraDebugToolEnabled(bool inEnable)
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolEnabled = inEnable;
	}

	// Token: 0x06001EC4 RID: 7876 RVA: 0x00099407 File Offset: 0x00097607
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchCameraDebugRotatorEnabled()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolDrawRotator = !CameraController.Instance.MainModel.CameraDebugToolDrawRotator;
	}

	// Token: 0x06001EC5 RID: 7877 RVA: 0x00099432 File Offset: 0x00097632
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchCameraDebugToolDrawCameraCollision()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolDrawCameraCollision = !CameraController.Instance.MainModel.CameraDebugToolDrawCameraCollision;
	}

	// Token: 0x06001EC6 RID: 7878 RVA: 0x0009945D File Offset: 0x0009765D
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchCameraDebugToolDrawSpringArm()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolDrawSpringArm = !CameraController.Instance.MainModel.CameraDebugToolDrawSpringArm;
	}

	// Token: 0x06001EC7 RID: 7879 RVA: 0x00099488 File Offset: 0x00097688
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchCameraDebugToolDrawFocusTargetLine()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolDrawFocusTargetLine = !CameraController.Instance.MainModel.CameraDebugToolDrawFocusTargetLine;
	}

	// Token: 0x06001EC8 RID: 7880 RVA: 0x000994B3 File Offset: 0x000976B3
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchCameraDebugToolDrawSpringArmEdgeRange()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolDrawSpringArmEdgeRange = !CameraController.Instance.MainModel.CameraDebugToolDrawSpringArmEdgeRange;
	}

	// Token: 0x06001EC9 RID: 7881 RVA: 0x000994DE File Offset: 0x000976DE
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchCameraDebugToolDrawLockCameraMoveLine()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolDrawLockCameraMoveLine = !CameraController.Instance.MainModel.CameraDebugToolDrawLockCameraMoveLine;
	}

	// Token: 0x06001ECA RID: 7882 RVA: 0x00099509 File Offset: 0x00097709
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchCameraDebugToolDrawSettlementCamera()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolDrawSettlementCamera = !CameraController.Instance.MainModel.CameraDebugToolDrawSettlementCamera;
	}

	// Token: 0x06001ECB RID: 7883 RVA: 0x00099534 File Offset: 0x00097734
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchCameraDebugToolDrawCameraZone()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.CameraDebugToolDrawCameraZone = !CameraController.Instance.MainModel.CameraDebugToolDrawCameraZone;
	}

	// Token: 0x06001ECC RID: 7884 RVA: 0x0009955F File Offset: 0x0009775F
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TMap<string, string> GetDebugDesiredCameraProps()
	{
		return new TMap<string, string>();
	}

	// Token: 0x06001ECD RID: 7885 RVA: 0x00099566 File Offset: 0x00097766
	[NullableContext(1)]
	public static Dictionary<string, object> GetDebugCameraPropsRaw()
	{
		return new Dictionary<string, object>();
	}

	// Token: 0x06001ECE RID: 7886 RVA: 0x0009956D File Offset: 0x0009776D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<SCameraDebugTool_SubCameraModification> GetSubCameraModifications()
	{
		return new TArray<SCameraDebugTool_SubCameraModification>();
	}

	// Token: 0x06001ECF RID: 7887 RVA: 0x00099574 File Offset: 0x00097774
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<SCameraDebugTool_ControllerModification> GetControllerModifications()
	{
		return new TArray<SCameraDebugTool_ControllerModification>();
	}

	// Token: 0x06001ED0 RID: 7888 RVA: 0x0009957B File Offset: 0x0009777B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SCameraDebugTool_CameraModeInfo GetCamereModeInfo()
	{
		return new SCameraDebugTool_CameraModeInfo();
	}

	// Token: 0x06001ED1 RID: 7889 RVA: 0x00099582 File Offset: 0x00097782
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlaySettlementCamera()
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return;
		}
		FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
		if (logicComponent == null)
		{
			return;
		}
		logicComponent.PlaySettlementCamera(EDynamicSettlementType.Battle);
	}

	// Token: 0x06001ED2 RID: 7890 RVA: 0x000995B0 File Offset: 0x000977B0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsCameraTargetInScreen()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		return fightCameraLogicComponent != null && fightCameraLogicComponent.IsTargetLocationValid && fightCameraLogicComponent.CheckPositionInScreen(fightCameraLogicComponent.TargetLocation, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMinX, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMaxX, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMinY, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMaxY);
	}

	// Token: 0x06001ED3 RID: 7891 RVA: 0x00099624 File Offset: 0x00097824
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ACameraActor EnterSpecialGameplayCamera(int gameplayId)
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return null;
		}
		FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
		if (logicComponent == null)
		{
			return null;
		}
		return logicComponent.EnterSpecialGameplayCamera(gameplayId);
	}

	// Token: 0x06001ED4 RID: 7892 RVA: 0x0009964C File Offset: 0x0009784C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitSpecialGameplayCamera()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return;
		}
		FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
		if (logicComponent == null)
		{
			return;
		}
		logicComponent.ExitSpecialGameplayCamera();
	}

	// Token: 0x06001ED5 RID: 7893 RVA: 0x00099671 File Offset: 0x00097871
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitSpecialGameplayCamera2()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		if (fightCamera == null)
		{
			return;
		}
		FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
		if (logicComponent == null)
		{
			return;
		}
		logicComponent.ExitSpecialGameplayCamera();
	}

	// Token: 0x06001ED6 RID: 7894 RVA: 0x00099696 File Offset: 0x00097896
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetAimAssistModeByKey(string key, EAimAssistMode mode)
	{
		CameraController.Instance.MainModel.SetAimAssistModeWithKey(key, mode);
	}

	// Token: 0x06001ED7 RID: 7895 RVA: 0x000996A9 File Offset: 0x000978A9
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearAimAssistModeByKey(string key)
	{
		CameraController.Instance.MainModel.ClearAimAssistModeWithKey(key);
	}

	// Token: 0x06001ED8 RID: 7896 RVA: 0x000996BB File Offset: 0x000978BB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetSequenceCameraCollisionState(bool bEnable)
	{
		SequenceCamera sequenceCamera = CameraController.Instance.MainModel.SequenceCamera;
		if (sequenceCamera == null)
		{
			return;
		}
		SequenceCameraPlayerComponent playerComponent = sequenceCamera.PlayerComponent;
		if (playerComponent == null)
		{
			return;
		}
		playerComponent.SetCameraCollisionState(bEnable);
	}

	// Token: 0x06001ED9 RID: 7897 RVA: 0x000996E4 File Offset: 0x000978E4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetXRayState(bool isEnable)
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		CameraCollision cameraCollision;
		if (fightCamera == null)
		{
			cameraCollision = null;
		}
		else
		{
			FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
			cameraCollision = ((logicComponent != null) ? logicComponent.CameraCollision : null);
		}
		CameraCollision cameraCollision2 = cameraCollision;
		if (cameraCollision2 != null)
		{
			cameraCollision2.IsPlayerXRayEnable = isEnable;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "CameraBlueprintFunctionLibrary SetXRayState";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isEnable", isEnable);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06001EDA RID: 7898 RVA: 0x00099750 File Offset: 0x00097950
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static int EnableCameraSpecificLockTarget(int entityId, float priority)
	{
		int num = CameraController.Instance.MainModel.EnableCameraSpecificLockEntity(entityId, (int)priority, ECameraSpecificLockGroup.Normal);
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "CameraBlueprintFunctionLibrary EnableCameraSpecificLockTarget";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("entityId", entityId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("priority", priority);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("id", num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		return num;
	}

	// Token: 0x06001EDB RID: 7899 RVA: 0x000997EC File Offset: 0x000979EC
	[UFunction(EFunctionFlags.FUNC_None)]
	public unsafe static int EnableCameraSpecificLockLocation(FVectorDouble location, float priority)
	{
		Vector vector = Vector.Create(location);
		int num = CameraController.Instance.MainModel.EnableCameraSpecificLockLocation(vector, (int)priority, ECameraSpecificLockGroup.Normal);
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LYY;
		string message = "CameraBlueprintFunctionLibrary EnableCameraSpecificLockLocation";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("location", vector);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("priority", priority);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("id", num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		return num;
	}

	// Token: 0x06001EDC RID: 7900 RVA: 0x00099890 File Offset: 0x00097A90
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DisableCameraSpecificLockOnTarget(int id)
	{
		CameraController.Instance.MainModel.DisableCameraSpecificLockTarget(id);
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "CameraBlueprintFunctionLibrary DisableCameraSpecificLockOnTarget";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06001EDD RID: 7901 RVA: 0x000998D9 File Offset: 0x00097AD9
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsCameraSpecificLockEnable()
	{
		return CameraController.Instance.MainModel.GetCameraSpecificLockTarget() != null;
	}

	// Token: 0x06001EDE RID: 7902 RVA: 0x000998F0 File Offset: 0x00097AF0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int GetCameraSpecificLockEntityId()
	{
		CameraSpecificLockTarget cameraSpecificLockTarget = CameraController.Instance.MainModel.GetCameraSpecificLockTarget();
		if (cameraSpecificLockTarget == null || cameraSpecificLockTarget.Type != ECameraSpecificLockType.Entity)
		{
			return -1;
		}
		return ((CameraSpecificLockEntity)cameraSpecificLockTarget).EntityId;
	}

	// Token: 0x06001EDF RID: 7903 RVA: 0x00099928 File Offset: 0x00097B28
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int EnableSoftLockCamera()
	{
		CameraController instance = CameraController.Instance;
		if (((instance != null) ? instance.MainModel : null) == null)
		{
			return -1;
		}
		int num = CameraController.Instance.MainModel.EnableSoftLock("Bp EnableSoftLockCamera");
		global::Log instance2 = global::Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "CameraBlueprintFunctionLibrary EnableSoftLockCamera";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", num);
		instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return num;
	}

	// Token: 0x06001EE0 RID: 7904 RVA: 0x0009998C File Offset: 0x00097B8C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DisableSoftLockCamera(int handle)
	{
		CameraController instance = CameraController.Instance;
		if (((instance != null) ? instance.MainModel : null) == null)
		{
			return;
		}
		CameraController.Instance.MainModel.DisableSoftLock(handle, "Bp DisableSoftLockCamera");
		global::Log instance2 = global::Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "CameraBlueprintFunctionLibrary DisableSoftLockCamera";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", handle);
		instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06001EE1 RID: 7905 RVA: 0x000999F0 File Offset: 0x00097BF0
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCameraGravityMode(ECameraGravityMode gravityMode, FVectorDouble gravityDirect)
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return;
		}
		CameraBlueprintFunctionLibrary.TmpVector.DeepCopy(gravityDirect);
		fightCameraLogicComponent.SetCameraGravityMode(gravityMode, CameraBlueprintFunctionLibrary.TmpVector);
	}

	// Token: 0x06001EE2 RID: 7906 RVA: 0x00099A44 File Offset: 0x00097C44
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ECameraGravityMode GetCameraGravityMode()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return ECameraGravityMode.None;
		}
		return fightCameraLogicComponent.GravityMode;
	}

	// Token: 0x06001EE3 RID: 7907 RVA: 0x00099A88 File Offset: 0x00097C88
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetCameraGravityDirect()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return Vector.DownVectorDouble;
		}
		return fightCameraLogicComponent.GravityDirect.ToUeVector(false);
	}

	// Token: 0x06001EE4 RID: 7908 RVA: 0x00099AD4 File Offset: 0x00097CD4
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetCameraGravityUp()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return Vector.UpVectorDouble;
		}
		return fightCameraLogicComponent.GravityUp.ToUeVector(false);
	}

	// Token: 0x06001EE5 RID: 7909 RVA: 0x00099B20 File Offset: 0x00097D20
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FRotator GetCameraRotationInGravity()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return Rotator.ZeroRotator;
		}
		return fightCameraLogicComponent.CameraRotationInGravity.ToUeRotator();
	}

	// Token: 0x06001EE6 RID: 7910 RVA: 0x00099B6C File Offset: 0x00097D6C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetPlayerLocationInGravity()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return Vector.ZeroVectorDouble;
		}
		return fightCameraLogicComponent.PlayerLocationInGravity.ToUeVector(false);
	}

	// Token: 0x06001EE7 RID: 7911 RVA: 0x00099BB8 File Offset: 0x00097DB8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FRotator GetPlayerRotatorInGravity()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		if (fightCameraLogicComponent == null || !fightCameraLogicComponent.Valid)
		{
			return Rotator.ZeroRotator;
		}
		return fightCameraLogicComponent.PlayerRotatorInGravity.ToUeRotator();
	}

	// Token: 0x06001EE8 RID: 7912 RVA: 0x00099C03 File Offset: 0x00097E03
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetUiCameraDebugToolEnabled(bool enabled)
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		CameraController.Instance.MainModel.UiCameraDebugToolEnabled = enabled;
	}

	// Token: 0x06001EE9 RID: 7913 RVA: 0x00099C20 File Offset: 0x00097E20
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchUiCameraDtSync()
	{
		UiCameraDebugTool uiCameraDebugTool = UiCameraAnimationManager.Instance.UiCameraDebugTool;
		if (uiCameraDebugTool.GetDtSyncEnabled())
		{
			uiCameraDebugTool.EndDtSync();
			return;
		}
		uiCameraDebugTool.StartDtSync();
	}

	// Token: 0x06001EEA RID: 7914 RVA: 0x00099C4D File Offset: 0x00097E4D
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TMap<string, string> GetDebugToolUiCameraProps()
	{
		return new TMap<string, string>();
	}

	// Token: 0x06001EEB RID: 7915 RVA: 0x00099C54 File Offset: 0x00097E54
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchUiCameraArmLengthSync()
	{
		UiCameraDebugTool uiCameraDebugTool = UiCameraAnimationManager.Instance.UiCameraDebugTool;
		if (uiCameraDebugTool.GetArmLengthSyncEnabled())
		{
			uiCameraDebugTool.EndArmLengthSync();
			return;
		}
		uiCameraDebugTool.StartArmLengthSync();
	}

	// Token: 0x06001EEC RID: 7916 RVA: 0x00099C84 File Offset: 0x00097E84
	[NullableContext(1)]
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OnDebugToolUiCameraArmLengthInputChanged(string armLengthStr)
	{
		UiCameraDebugTool uiCameraDebugTool = UiCameraAnimationManager.Instance.UiCameraDebugTool;
		if (uiCameraDebugTool.GetArmLengthSyncEnabled())
		{
			float num = float.Parse(armLengthStr);
			if (num > 0f)
			{
				uiCameraDebugTool.ArmLengthSync(num);
			}
		}
	}

	// Token: 0x06001EED RID: 7917 RVA: 0x00099CBC File Offset: 0x00097EBC
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void InitSeparateCamera(string cameraName, FVector2D initLocation, FVector2D initSize, bool enableScissorOffset)
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		if (CameraController.Instance.GetSeparateCameraModel(cameraName) == null)
		{
			return;
		}
		CameraBlueprintFunctionLibrary.TmpVector2D1.FromUeVector2D(initLocation);
		CameraBlueprintFunctionLibrary.TmpVector2D2.FromUeVector2D(initSize);
		if (cameraName != "MainCamera")
		{
			CameraModelInstance separateCameraModel = CameraController.Instance.GetSeparateCameraModel("MainCamera");
			CameraBlueprintFunctionLibrary.TmpVector2D1.X = MathUtils.Instance.Clamp(separateCameraModel.SeparateCameraLayout.CurrentViewSize.X, 0.0, 1.0);
			CameraBlueprintFunctionLibrary.TmpVector2D2.X = MathUtils.Instance.Clamp(1.0 - separateCameraModel.SeparateCameraLayout.CurrentViewSize.X, 0.0, 1.0);
		}
		CameraController.Instance.InitSeparateCamera(cameraName, CameraBlueprintFunctionLibrary.TmpVector2D1, CameraBlueprintFunctionLibrary.TmpVector2D2, enableScissorOffset, false);
	}

	// Token: 0x06001EEE RID: 7918 RVA: 0x00099DB0 File Offset: 0x00097FB0
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void FadeSeparateCamera(string cameraName, float fadeTime, FVector2D targetViewLocation, FVector2D targetViewSize, bool enableScissorOffset, [Nullable(2)] UCurveFloat curve)
	{
		if (CameraModel.Instance == null)
		{
			return;
		}
		if (CameraController.Instance.GetSeparateCameraModel(cameraName) == null)
		{
			return;
		}
		CameraBlueprintFunctionLibrary.TmpVector2D1.FromUeVector2D(targetViewLocation);
		CameraBlueprintFunctionLibrary.TmpVector2D2.FromUeVector2D(targetViewSize);
		CameraController.Instance.FadeSeparateCamera(cameraName, fadeTime, CameraBlueprintFunctionLibrary.TmpVector2D1, CameraBlueprintFunctionLibrary.TmpVector2D2, enableScissorOffset, curve, null, false);
	}

	// Token: 0x06001EEF RID: 7919 RVA: 0x00099E0F File Offset: 0x0009800F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06001EF0 RID: 7920 RVA: 0x00099E11 File Offset: 0x00098011
	public static void ResetStaticDefaultValue()
	{
		CameraBlueprintFunctionLibrary._tmpQuatInternal = null;
		CameraBlueprintFunctionLibrary._cacheLookAtVector = null;
		CameraBlueprintFunctionLibrary._cacheLookAtVector1 = null;
		CameraBlueprintFunctionLibrary._tmpVectorInternal = null;
		CameraBlueprintFunctionLibrary._tmpVector2D1Internal = null;
		CameraBlueprintFunctionLibrary._tmpVector2D2Internal = null;
	}

	// Token: 0x06001EF1 RID: 7921 RVA: 0x00099E38 File Offset: 0x00098038
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetOcclusionDitherState(bool isEnable)
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		CameraCollision cameraCollision;
		if (fightCamera == null)
		{
			cameraCollision = null;
		}
		else
		{
			FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
			cameraCollision = ((logicComponent != null) ? logicComponent.CameraCollision : null);
		}
		CameraCollision cameraCollision2 = cameraCollision;
		if (cameraCollision2 != null)
		{
			cameraCollision2.IsActiveOcclusionDither = isEnable;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "CameraBlueprintFunctionLibrary SetOcclusionDitherState";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isEnable", isEnable);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06001EF2 RID: 7922 RVA: 0x00099EA3 File Offset: 0x000980A3
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CameraBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Camera/CameraBlueprintFunctionLibrary.CameraBlueprintFunctionLibrary_C");
		}
		return CameraBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06001EF3 RID: 7923 RVA: 0x00099EC8 File Offset: 0x000980C8
	public CameraBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(CameraBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001EF4 RID: 7924 RVA: 0x00099EF0 File Offset: 0x000980F0
	[NullableContext(1)]
	public CameraBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001EF5 RID: 7925 RVA: 0x00099F23 File Offset: 0x00098123
	protected CameraBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001EF6 RID: 7926 RVA: 0x00099F2C File Offset: 0x0009812C
	protected unsafe static void __CPPCALL_OnPossess_Implementation(CameraBlueprintFunctionLibrary.__OnPossess_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.OnPossess(BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->pawn));
	}

	// Token: 0x06001EF7 RID: 7927 RVA: 0x00099F3E File Offset: 0x0009813E
	protected unsafe static void __CPPCALL_GetCameraMode_Implementation(CameraBlueprintFunctionLibrary.__GetCameraMode_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)CameraBlueprintFunctionLibrary.GetCameraMode();
	}

	// Token: 0x06001EF8 RID: 7928 RVA: 0x00099F4D File Offset: 0x0009814D
	protected unsafe static void __CPPCALL_GetPhotoCameraComponent_Implementation(CameraBlueprintFunctionLibrary.__GetPhotoCameraComponent_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UCameraComponent photoCameraComponent = CameraBlueprintFunctionLibrary.GetPhotoCameraComponent();
		ptr = ((photoCameraComponent != null) ? photoCameraComponent.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001EF9 RID: 7929 RVA: 0x00099F69 File Offset: 0x00098169
	protected unsafe static void __CPPCALL_GetSequenceCameraActor_Implementation(CameraBlueprintFunctionLibrary.__GetSequenceCameraActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ALevelSequenceActor sequenceCameraActor = CameraBlueprintFunctionLibrary.GetSequenceCameraActor();
		ptr = ((sequenceCameraActor != null) ? sequenceCameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001EFA RID: 7930 RVA: 0x00099F85 File Offset: 0x00098185
	protected unsafe static void __CPPCALL_EnterCameraMode_Implementation(CameraBlueprintFunctionLibrary.__EnterCameraMode_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.EnterCameraMode((ECustomCameraMode)__Params->cameraMode, __Params->blendTime, __Params->blendFunction, __Params->blendExp);
	}

	// Token: 0x06001EFB RID: 7931 RVA: 0x00099FA4 File Offset: 0x000981A4
	protected unsafe static void __CPPCALL_ExitCameraMode_Implementation(CameraBlueprintFunctionLibrary.__ExitCameraMode_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitCameraMode((ECustomCameraMode)__Params->cameraMode, __Params->blendTime, __Params->blendFunction, __Params->blendExp);
	}

	// Token: 0x06001EFC RID: 7932 RVA: 0x00099FC3 File Offset: 0x000981C3
	protected unsafe static void __CPPCALL_SetCameraRotation_Implementation(CameraBlueprintFunctionLibrary.__SetCameraRotation_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetCameraRotation(__Params->rotator);
	}

	// Token: 0x06001EFD RID: 7933 RVA: 0x00099FD0 File Offset: 0x000981D0
	protected unsafe static void __CPPCALL_IsTargetSocketLocationValid_Implementation(CameraBlueprintFunctionLibrary.__IsTargetSocketLocationValid_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.IsTargetSocketLocationValid();
	}

	// Token: 0x06001EFE RID: 7934 RVA: 0x00099FDD File Offset: 0x000981DD
	protected unsafe static void __CPPCALL_GetTargetSocketLocation_Implementation(CameraBlueprintFunctionLibrary.__GetTargetSocketLocation_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetTargetSocketLocation();
	}

	// Token: 0x06001EFF RID: 7935 RVA: 0x00099FEA File Offset: 0x000981EA
	protected unsafe static void __CPPCALL_GetFightCameraLocation_Implementation(CameraBlueprintFunctionLibrary.__GetFightCameraLocation_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetFightCameraLocation();
	}

	// Token: 0x06001F00 RID: 7936 RVA: 0x00099FF7 File Offset: 0x000981F7
	protected unsafe static void __CPPCALL_GetFightCameraRotation_Implementation(CameraBlueprintFunctionLibrary.__GetFightCameraRotation_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetFightCameraRotation();
	}

	// Token: 0x06001F01 RID: 7937 RVA: 0x0009A004 File Offset: 0x00098204
	protected unsafe static void __CPPCALL_GetFightCameraForward_Implementation(CameraBlueprintFunctionLibrary.__GetFightCameraForward_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetFightCameraForward(__Params->index);
	}

	// Token: 0x06001F02 RID: 7938 RVA: 0x0009A017 File Offset: 0x00098217
	protected unsafe static void __CPPCALL_GetFightCameraActor_Implementation(CameraBlueprintFunctionLibrary.__GetFightCameraActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ACameraActor fightCameraActor = CameraBlueprintFunctionLibrary.GetFightCameraActor();
		ptr = ((fightCameraActor != null) ? fightCameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001F03 RID: 7939 RVA: 0x0009A033 File Offset: 0x00098233
	protected unsafe static void __CPPCALL_SetFightCameraFollow_Implementation(CameraBlueprintFunctionLibrary.__SetFightCameraFollow_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetFightCameraFollow(__Params->follow);
	}

	// Token: 0x06001F04 RID: 7940 RVA: 0x0009A040 File Offset: 0x00098240
	protected unsafe static void __CPPCALL_ApplyCameraModify_Implementation(CameraBlueprintFunctionLibrary.__ApplyCameraModify_FunctionParams* __Params)
	{
		SCameraModifier_Settings cameraModifySettings = new SCameraModifier_Settings(&__Params->cameraModifySettings, true, true);
		UAnimMontage orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(__Params->montage);
		SBaseCurve blendInCurve = new SBaseCurve(&__Params->blendInCurve, true, true);
		SBaseCurve blendOutCurve = new SBaseCurve(&__Params->blendOutCurve, true, true);
		string cameraAttachSocket = FString.ToString((void*)(&__Params->cameraAttachSocket));
		ECameraAnsEffectiveClientType cameraEffectiveClientType = (ECameraAnsEffectiveClientType)__Params->cameraEffectiveClientType;
		TArray<SCameraModifier_Condition> tarray = new TArray<SCameraModifier_Condition>(&__Params->cameraModifierConditions, true, true);
		CameraBlueprintFunctionLibrary.ApplyCameraModify(__Params->tag, __Params->duration, __Params->blendInTime, __Params->blendOutTime, __Params->breakBlendOutTime, cameraModifySettings, orCreateUObjectByNativePointer, blendInCurve, blendOutCurve, cameraAttachSocket, __Params->entityId, cameraEffectiveClientType, ref tarray);
		if (tarray != null)
		{
			tarray.CopyTo(&__Params->cameraModifierConditions, default(UScriptStructStackOnlyPtr));
		}
	}

	// Token: 0x06001F05 RID: 7941 RVA: 0x0009A0FB File Offset: 0x000982FB
	protected unsafe static void __CPPCALL_ForceStopCameraModify_Implementation(CameraBlueprintFunctionLibrary.__ForceStopCameraModify_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ForceStopCameraModify(__Params->withFadeOut);
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x0009A108 File Offset: 0x00098308
	protected unsafe static void __CPPCALL_ApplyCameraGuide_Implementation(CameraBlueprintFunctionLibrary.__ApplyCameraGuide_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ApplyCameraGuide(__Params->lookAt, __Params->fadeInTime, __Params->stayTime, __Params->fadeOutTime, __Params->lockCameraInput, __Params->endPosition, __Params->fov, __Params->ignoreAdjustYaw, __Params->staticCamera);
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x0009A150 File Offset: 0x00098350
	protected unsafe static void __CPPCALL_ExitCameraGuide_Implementation(CameraBlueprintFunctionLibrary.__ExitCameraGuide_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitCameraGuide();
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x0009A157 File Offset: 0x00098357
	protected unsafe static void __CPPCALL_EnterCameraExplore_Implementation(CameraBlueprintFunctionLibrary.__EnterCameraExplore_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.EnterCameraExplore(__Params->id, __Params->lookAt1, __Params->lookAt2, __Params->prepTime, __Params->fadeDistance, __Params->armLengthMin, __Params->armLengthMax);
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x0009A188 File Offset: 0x00098388
	protected unsafe static void __CPPCALL_ExitCameraExplore_Implementation(CameraBlueprintFunctionLibrary.__ExitCameraExplore_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitCameraExplore(__Params->id);
	}

	// Token: 0x06001F0A RID: 7946 RVA: 0x0009A198 File Offset: 0x00098398
	protected unsafe static void __CPPCALL_PlayCameraSequence_Implementation(CameraBlueprintFunctionLibrary.__PlayCameraSequence_FunctionParams* __Params)
	{
		ESequenceCameraAnsEffectiveClientType 生效客户端 = (ESequenceCameraAnsEffectiveClientType)__Params->生效客户端;
		SSequenceCamera_Settings settings = new SSequenceCamera_Settings(&__Params->settings, true, true);
		string cameraAttachSocket = FString.ToString((void*)(&__Params->cameraAttachSocket));
		string cameraDetectSocket = FString.ToString((void*)(&__Params->cameraDetectSocket));
		__Params->__Result = CameraBlueprintFunctionLibrary.PlayCameraSequence(生效客户端, __Params->entityId, settings, __Params->resetLockOnCamera, __Params->additiveRotation, cameraAttachSocket, cameraDetectSocket, __Params->extraSphereLocation, __Params->extraDetectSphereRadius, __Params->isShowExtraSphere, __Params->isIgnoreCharacterCollision, __Params->disableMovementInput, __Params->disableLookAtInput, __Params->disableMotionBlur);
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x0009A220 File Offset: 0x00098420
	protected unsafe static void __CPPCALL_GetWidgetCameraActor_Implementation(CameraBlueprintFunctionLibrary.__GetWidgetCameraActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ACameraActor widgetCameraActor = CameraBlueprintFunctionLibrary.GetWidgetCameraActor();
		ptr = ((widgetCameraActor != null) ? widgetCameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001F0C RID: 7948 RVA: 0x0009A23C File Offset: 0x0009843C
	protected unsafe static void __CPPCALL_SetWidgetCameraBlendParams_Implementation(CameraBlueprintFunctionLibrary.__SetWidgetCameraBlendParams_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetWidgetCameraBlendParams(__Params->blendTime, __Params->blendFunction, __Params->blendExp, __Params->blendLocation, __Params->isRelativeLocation, __Params->overrideLocation, __Params->newLocation, __Params->blendRotation, __Params->isRelativeRotation, __Params->overrideRotation, __Params->newRotation);
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x0009A290 File Offset: 0x00098490
	protected unsafe static void __CPPCALL_PlayCameraOrbital_Implementation(CameraBlueprintFunctionLibrary.__PlayCameraOrbital_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.PlayCameraOrbital(BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->levelSequence), __Params->startLocation, __Params->endLocation, __Params->blendInTime, __Params->blendOutTime);
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x0009A2BA File Offset: 0x000984BA
	protected unsafe static void __CPPCALL_StopCameraOrbital_Implementation(CameraBlueprintFunctionLibrary.__StopCameraOrbital_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.StopCameraOrbital();
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x0009A2C1 File Offset: 0x000984C1
	protected unsafe static void __CPPCALL_ResetFightCameraPitchAndArmLength_Implementation(CameraBlueprintFunctionLibrary.__ResetFightCameraPitchAndArmLength_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ResetFightCameraPitchAndArmLength();
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x0009A2C8 File Offset: 0x000984C8
	protected unsafe static void __CPPCALL_EnterSequenceDialogue_Implementation(CameraBlueprintFunctionLibrary.__EnterSequenceDialogue_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.EnterSequenceDialogue(BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target));
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x0009A2DA File Offset: 0x000984DA
	protected unsafe static void __CPPCALL_ExitSequenceDialogue_Implementation(CameraBlueprintFunctionLibrary.__ExitSequenceDialogue_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitSequenceDialogue();
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x0009A2E1 File Offset: 0x000984E1
	protected unsafe static void __CPPCALL_ReloadCameraConfig_Implementation(CameraBlueprintFunctionLibrary.__ReloadCameraConfig_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ReloadCameraConfig();
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x0009A2E8 File Offset: 0x000984E8
	protected unsafe static void __CPPCALL_SetAimAssistMode_Implementation(CameraBlueprintFunctionLibrary.__SetAimAssistMode_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetAimAssistMode((EAimAssistMode)__Params->mode);
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x0009A2F5 File Offset: 0x000984F5
	protected unsafe static void __CPPCALL_IsRoleOnCameraRight_Implementation(CameraBlueprintFunctionLibrary.__IsRoleOnCameraRight_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.IsRoleOnCameraRight();
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x0009A302 File Offset: 0x00098502
	protected unsafe static void __CPPCALL_SetCameraDebugToolEnabled_Implementation(CameraBlueprintFunctionLibrary.__SetCameraDebugToolEnabled_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x0009A304 File Offset: 0x00098504
	protected unsafe static void __CPPCALL_SwitchCameraDebugRotatorEnabled_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugRotatorEnabled_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F17 RID: 7959 RVA: 0x0009A306 File Offset: 0x00098506
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawCameraCollision_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawCameraCollision_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x0009A308 File Offset: 0x00098508
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawSpringArm_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawSpringArm_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F19 RID: 7961 RVA: 0x0009A30A File Offset: 0x0009850A
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawFocusTargetLine_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawFocusTargetLine_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F1A RID: 7962 RVA: 0x0009A30C File Offset: 0x0009850C
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawSpringArmEdgeRange_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawSpringArmEdgeRange_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x0009A30E File Offset: 0x0009850E
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawLockCameraMoveLine_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawLockCameraMoveLine_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F1C RID: 7964 RVA: 0x0009A310 File Offset: 0x00098510
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawSettlementCamera_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawSettlementCamera_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x0009A312 File Offset: 0x00098512
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawCameraZone_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawCameraZone_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x0009A314 File Offset: 0x00098514
	protected unsafe static void __CPPCALL_GetDebugDesiredCameraProps_Implementation(CameraBlueprintFunctionLibrary.__GetDebugDesiredCameraProps_FunctionParams* __Params)
	{
		TMap<string, string> debugDesiredCameraProps = CameraBlueprintFunctionLibrary.GetDebugDesiredCameraProps();
		if (debugDesiredCameraProps == null)
		{
			return;
		}
		debugDesiredCameraProps.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x0009A340 File Offset: 0x00098540
	protected unsafe static void __CPPCALL_GetSubCameraModifications_Implementation(CameraBlueprintFunctionLibrary.__GetSubCameraModifications_FunctionParams* __Params)
	{
		TArray<SCameraDebugTool_SubCameraModification> subCameraModifications = CameraBlueprintFunctionLibrary.GetSubCameraModifications();
		if (subCameraModifications == null)
		{
			return;
		}
		subCameraModifications.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x0009A36C File Offset: 0x0009856C
	protected unsafe static void __CPPCALL_GetControllerModifications_Implementation(CameraBlueprintFunctionLibrary.__GetControllerModifications_FunctionParams* __Params)
	{
		TArray<SCameraDebugTool_ControllerModification> controllerModifications = CameraBlueprintFunctionLibrary.GetControllerModifications();
		if (controllerModifications == null)
		{
			return;
		}
		controllerModifications.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x0009A398 File Offset: 0x00098598
	protected unsafe static void __CPPCALL_GetCamereModeInfo_Implementation(CameraBlueprintFunctionLibrary.__GetCamereModeInfo_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SCameraDebugTool_CameraModeInfo.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SCameraDebugTool_CameraModeInfo camereModeInfo = CameraBlueprintFunctionLibrary.GetCamereModeInfo();
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (camereModeInfo != null) ? camereModeInfo.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x0009A3BF File Offset: 0x000985BF
	protected unsafe static void __CPPCALL_PlaySettlementCamera_Implementation(CameraBlueprintFunctionLibrary.__PlaySettlementCamera_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x0009A3C1 File Offset: 0x000985C1
	protected unsafe static void __CPPCALL_GetIsCameraTargetInScreen_Implementation(CameraBlueprintFunctionLibrary.__GetIsCameraTargetInScreen_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetIsCameraTargetInScreen();
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x0009A3CE File Offset: 0x000985CE
	protected unsafe static void __CPPCALL_EnterSpecialGameplayCamera_Implementation(CameraBlueprintFunctionLibrary.__EnterSpecialGameplayCamera_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ACameraActor acameraActor = CameraBlueprintFunctionLibrary.EnterSpecialGameplayCamera(__Params->gameplayId);
		ptr = ((acameraActor != null) ? acameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x0009A3F0 File Offset: 0x000985F0
	protected unsafe static void __CPPCALL_ExitSpecialGameplayCamera_Implementation(CameraBlueprintFunctionLibrary.__ExitSpecialGameplayCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitSpecialGameplayCamera();
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x0009A3F7 File Offset: 0x000985F7
	protected unsafe static void __CPPCALL_ExitSpecialGameplayCamera2_Implementation(CameraBlueprintFunctionLibrary.__ExitSpecialGameplayCamera2_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitSpecialGameplayCamera2();
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x0009A400 File Offset: 0x00098600
	protected unsafe static void __CPPCALL_SetAimAssistModeByKey_Implementation(CameraBlueprintFunctionLibrary.__SetAimAssistModeByKey_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		EAimAssistMode mode = (EAimAssistMode)__Params->mode;
		CameraBlueprintFunctionLibrary.SetAimAssistModeByKey(key, mode);
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x0009A426 File Offset: 0x00098626
	protected unsafe static void __CPPCALL_ClearAimAssistModeByKey_Implementation(CameraBlueprintFunctionLibrary.__ClearAimAssistModeByKey_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ClearAimAssistModeByKey(FString.ToString((void*)(&__Params->key)));
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x0009A439 File Offset: 0x00098639
	protected unsafe static void __CPPCALL_SetSequenceCameraCollisionState_Implementation(CameraBlueprintFunctionLibrary.__SetSequenceCameraCollisionState_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetSequenceCameraCollisionState(__Params->bEnable);
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x0009A446 File Offset: 0x00098646
	protected unsafe static void __CPPCALL_SetXRayState_Implementation(CameraBlueprintFunctionLibrary.__SetXRayState_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetXRayState(__Params->isEnable);
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x0009A453 File Offset: 0x00098653
	protected unsafe static void __CPPCALL_EnableCameraSpecificLockTarget_Implementation(CameraBlueprintFunctionLibrary.__EnableCameraSpecificLockTarget_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.EnableCameraSpecificLockTarget(__Params->entityId, __Params->priority);
	}

	// Token: 0x06001F2C RID: 7980 RVA: 0x0009A46C File Offset: 0x0009866C
	protected unsafe static void __CPPCALL_EnableCameraSpecificLockLocation_Implementation(CameraBlueprintFunctionLibrary.__EnableCameraSpecificLockLocation_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.EnableCameraSpecificLockLocation(__Params->location, __Params->priority);
	}

	// Token: 0x06001F2D RID: 7981 RVA: 0x0009A485 File Offset: 0x00098685
	protected unsafe static void __CPPCALL_DisableCameraSpecificLockOnTarget_Implementation(CameraBlueprintFunctionLibrary.__DisableCameraSpecificLockOnTarget_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.DisableCameraSpecificLockOnTarget(__Params->id);
	}

	// Token: 0x06001F2E RID: 7982 RVA: 0x0009A492 File Offset: 0x00098692
	protected unsafe static void __CPPCALL_IsCameraSpecificLockEnable_Implementation(CameraBlueprintFunctionLibrary.__IsCameraSpecificLockEnable_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.IsCameraSpecificLockEnable();
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x0009A49F File Offset: 0x0009869F
	protected unsafe static void __CPPCALL_GetCameraSpecificLockEntityId_Implementation(CameraBlueprintFunctionLibrary.__GetCameraSpecificLockEntityId_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetCameraSpecificLockEntityId();
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x0009A4AC File Offset: 0x000986AC
	protected unsafe static void __CPPCALL_EnableSoftLockCamera_Implementation(CameraBlueprintFunctionLibrary.__EnableSoftLockCamera_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.EnableSoftLockCamera();
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x0009A4B9 File Offset: 0x000986B9
	protected unsafe static void __CPPCALL_DisableSoftLockCamera_Implementation(CameraBlueprintFunctionLibrary.__DisableSoftLockCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.DisableSoftLockCamera(__Params->handle);
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x0009A4C6 File Offset: 0x000986C6
	protected unsafe static void __CPPCALL_SetCameraGravityMode_Implementation(CameraBlueprintFunctionLibrary.__SetCameraGravityMode_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetCameraGravityMode((ECameraGravityMode)__Params->gravityMode, __Params->gravityDirect);
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x0009A4D9 File Offset: 0x000986D9
	protected unsafe static void __CPPCALL_GetCameraGravityMode_Implementation(CameraBlueprintFunctionLibrary.__GetCameraGravityMode_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)CameraBlueprintFunctionLibrary.GetCameraGravityMode();
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x0009A4E8 File Offset: 0x000986E8
	protected unsafe static void __CPPCALL_GetCameraGravityDirect_Implementation(CameraBlueprintFunctionLibrary.__GetCameraGravityDirect_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetCameraGravityDirect();
	}

	// Token: 0x06001F35 RID: 7989 RVA: 0x0009A4F5 File Offset: 0x000986F5
	protected unsafe static void __CPPCALL_GetCameraGravityUp_Implementation(CameraBlueprintFunctionLibrary.__GetCameraGravityUp_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetCameraGravityUp();
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x0009A502 File Offset: 0x00098702
	protected unsafe static void __CPPCALL_GetCameraRotationInGravity_Implementation(CameraBlueprintFunctionLibrary.__GetCameraRotationInGravity_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetCameraRotationInGravity();
	}

	// Token: 0x06001F37 RID: 7991 RVA: 0x0009A50F File Offset: 0x0009870F
	protected unsafe static void __CPPCALL_GetPlayerLocationInGravity_Implementation(CameraBlueprintFunctionLibrary.__GetPlayerLocationInGravity_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetPlayerLocationInGravity();
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x0009A51C File Offset: 0x0009871C
	protected unsafe static void __CPPCALL_GetPlayerRotatorInGravity_Implementation(CameraBlueprintFunctionLibrary.__GetPlayerRotatorInGravity_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetPlayerRotatorInGravity();
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x0009A529 File Offset: 0x00098729
	protected unsafe static void __CPPCALL_SetUiCameraDebugToolEnabled_Implementation(CameraBlueprintFunctionLibrary.__SetUiCameraDebugToolEnabled_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F3A RID: 7994 RVA: 0x0009A52B File Offset: 0x0009872B
	protected unsafe static void __CPPCALL_SwitchUiCameraDtSync_Implementation(CameraBlueprintFunctionLibrary.__SwitchUiCameraDtSync_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F3B RID: 7995 RVA: 0x0009A530 File Offset: 0x00098730
	protected unsafe static void __CPPCALL_GetDebugToolUiCameraProps_Implementation(CameraBlueprintFunctionLibrary.__GetDebugToolUiCameraProps_FunctionParams* __Params)
	{
		TMap<string, string> debugToolUiCameraProps = CameraBlueprintFunctionLibrary.GetDebugToolUiCameraProps();
		if (debugToolUiCameraProps == null)
		{
			return;
		}
		debugToolUiCameraProps.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x0009A55C File Offset: 0x0009875C
	protected unsafe static void __CPPCALL_SwitchUiCameraArmLengthSync_Implementation(CameraBlueprintFunctionLibrary.__SwitchUiCameraArmLengthSync_FunctionParams* __Params)
	{
	}

	// Token: 0x06001F3D RID: 7997 RVA: 0x0009A55E File Offset: 0x0009875E
	protected unsafe static void __CPPCALL_OnDebugToolUiCameraArmLengthInputChanged_Implementation(CameraBlueprintFunctionLibrary.__OnDebugToolUiCameraArmLengthInputChanged_FunctionParams* __Params)
	{
		FString.ToString((void*)(&__Params->armLengthStr));
	}

	// Token: 0x06001F3E RID: 7998 RVA: 0x0009A56D File Offset: 0x0009876D
	protected unsafe static void __CPPCALL_InitSeparateCamera_Implementation(CameraBlueprintFunctionLibrary.__InitSeparateCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.InitSeparateCamera(FString.ToString((void*)(&__Params->cameraName)), __Params->initLocation, __Params->initSize, __Params->enableScissorOffset);
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x0009A594 File Offset: 0x00098794
	protected unsafe static void __CPPCALL_FadeSeparateCamera_Implementation(CameraBlueprintFunctionLibrary.__FadeSeparateCamera_FunctionParams* __Params)
	{
		string cameraName = FString.ToString((void*)(&__Params->cameraName));
		UCurveFloat orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->curve);
		CameraBlueprintFunctionLibrary.FadeSeparateCamera(cameraName, __Params->fadeTime, __Params->targetViewLocation, __Params->targetViewSize, __Params->enableScissorOffset, orCreateUObjectByNativePointer);
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x0009A5D7 File Offset: 0x000987D7
	protected unsafe static void __CPPCALL_SetOcclusionDitherState_Implementation(CameraBlueprintFunctionLibrary.__SetOcclusionDitherState_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetOcclusionDitherState(__Params->isEnable);
	}

	// Token: 0x040012DE RID: 4830
	[Nullable(2)]
	private static Vector _cacheLookAtVector;

	// Token: 0x040012DF RID: 4831
	[Nullable(2)]
	private static Vector _cacheLookAtVector1;

	// Token: 0x040012E0 RID: 4832
	[Nullable(2)]
	private static Vector _tmpVectorInternal;

	// Token: 0x040012E1 RID: 4833
	[Nullable(2)]
	private static Quat _tmpQuatInternal;

	// Token: 0x040012E2 RID: 4834
	[Nullable(2)]
	private static Vector2D _tmpVector2D1Internal;

	// Token: 0x040012E3 RID: 4835
	[Nullable(2)]
	private static Vector2D _tmpVector2D2Internal;

	// Token: 0x040012E4 RID: 4836
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Camera/CameraBlueprintFunctionLibrary.CameraBlueprintFunctionLibrary_C";

	// Token: 0x040012E5 RID: 4837
	private static IntPtr _ClassPtr;

	// Token: 0x040012E6 RID: 4838
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x020073CB RID: 29643
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnPossess_FunctionParams
	{
		// Token: 0x040266A8 RID: 157352
		[FieldOffset(0)]
		public IntPtr pawn;

		// Token: 0x040266A9 RID: 157353
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073CC RID: 29644
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetCameraMode_FunctionParams
	{
		// Token: 0x040266AA RID: 157354
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040266AB RID: 157355
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x020073CD RID: 29645
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPhotoCameraComponent_FunctionParams
	{
		// Token: 0x040266AC RID: 157356
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040266AD RID: 157357
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020073CE RID: 29646
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetSequenceCameraActor_FunctionParams
	{
		// Token: 0x040266AE RID: 157358
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040266AF RID: 157359
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020073CF RID: 29647
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnterCameraMode_FunctionParams
	{
		// Token: 0x040266B0 RID: 157360
		[FieldOffset(0)]
		public byte cameraMode;

		// Token: 0x040266B1 RID: 157361
		[FieldOffset(4)]
		public float blendTime;

		// Token: 0x040266B2 RID: 157362
		[FieldOffset(8)]
		public TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction;

		// Token: 0x040266B3 RID: 157363
		[FieldOffset(12)]
		public float blendExp;

		// Token: 0x040266B4 RID: 157364
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073D0 RID: 29648
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ExitCameraMode_FunctionParams
	{
		// Token: 0x040266B5 RID: 157365
		[FieldOffset(0)]
		public byte cameraMode;

		// Token: 0x040266B6 RID: 157366
		[FieldOffset(4)]
		public float blendTime;

		// Token: 0x040266B7 RID: 157367
		[FieldOffset(8)]
		public TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction;

		// Token: 0x040266B8 RID: 157368
		[FieldOffset(12)]
		public float blendExp;

		// Token: 0x040266B9 RID: 157369
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073D1 RID: 29649
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetCameraRotation_FunctionParams
	{
		// Token: 0x040266BA RID: 157370
		[FieldOffset(0)]
		public FRotator rotator;

		// Token: 0x040266BB RID: 157371
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073D2 RID: 29650
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsTargetSocketLocationValid_FunctionParams
	{
		// Token: 0x040266BC RID: 157372
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040266BD RID: 157373
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x020073D3 RID: 29651
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetTargetSocketLocation_FunctionParams
	{
		// Token: 0x040266BE RID: 157374
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040266BF RID: 157375
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x020073D4 RID: 29652
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetFightCameraLocation_FunctionParams
	{
		// Token: 0x040266C0 RID: 157376
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040266C1 RID: 157377
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x020073D5 RID: 29653
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetFightCameraRotation_FunctionParams
	{
		// Token: 0x040266C2 RID: 157378
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040266C3 RID: 157379
		[FieldOffset(8)]
		public FRotator __Result;
	}

	// Token: 0x020073D6 RID: 29654
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetFightCameraForward_FunctionParams
	{
		// Token: 0x040266C4 RID: 157380
		[FieldOffset(0)]
		public int index;

		// Token: 0x040266C5 RID: 157381
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040266C6 RID: 157382
		[FieldOffset(16)]
		public FVector __Result;
	}

	// Token: 0x020073D7 RID: 29655
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetFightCameraActor_FunctionParams
	{
		// Token: 0x040266C7 RID: 157383
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040266C8 RID: 157384
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020073D8 RID: 29656
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetFightCameraFollow_FunctionParams
	{
		// Token: 0x040266C9 RID: 157385
		[FieldOffset(0)]
		public bool follow;

		// Token: 0x040266CA RID: 157386
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073D9 RID: 29657
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 480)]
	protected ref struct __ApplyCameraModify_FunctionParams
	{
		// Token: 0x040266CB RID: 157387
		[FieldOffset(0)]
		public FGameplayTag tag;

		// Token: 0x040266CC RID: 157388
		[FieldOffset(12)]
		public float duration;

		// Token: 0x040266CD RID: 157389
		[FieldOffset(16)]
		public float blendInTime;

		// Token: 0x040266CE RID: 157390
		[FieldOffset(20)]
		public float blendOutTime;

		// Token: 0x040266CF RID: 157391
		[FieldOffset(24)]
		public float breakBlendOutTime;

		// Token: 0x040266D0 RID: 157392
		[FieldOffset(32)]
		public byte cameraModifySettings;

		// Token: 0x040266D1 RID: 157393
		[FieldOffset(392)]
		public IntPtr montage;

		// Token: 0x040266D2 RID: 157394
		[FieldOffset(400)]
		public byte blendInCurve;

		// Token: 0x040266D3 RID: 157395
		[FieldOffset(416)]
		public byte blendOutCurve;

		// Token: 0x040266D4 RID: 157396
		[FieldOffset(432)]
		public FString cameraAttachSocket;

		// Token: 0x040266D5 RID: 157397
		[FieldOffset(448)]
		public int entityId;

		// Token: 0x040266D6 RID: 157398
		[FieldOffset(452)]
		public byte cameraEffectiveClientType;

		// Token: 0x040266D7 RID: 157399
		[FieldOffset(456)]
		public byte cameraModifierConditions;

		// Token: 0x040266D8 RID: 157400
		[FieldOffset(472)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073DA RID: 29658
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ForceStopCameraModify_FunctionParams
	{
		// Token: 0x040266D9 RID: 157401
		[FieldOffset(0)]
		public bool withFadeOut;

		// Token: 0x040266DA RID: 157402
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073DB RID: 29659
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __ApplyCameraGuide_FunctionParams
	{
		// Token: 0x040266DB RID: 157403
		[FieldOffset(0)]
		public FVector lookAt;

		// Token: 0x040266DC RID: 157404
		[FieldOffset(12)]
		public float fadeInTime;

		// Token: 0x040266DD RID: 157405
		[FieldOffset(16)]
		public float stayTime;

		// Token: 0x040266DE RID: 157406
		[FieldOffset(20)]
		public float fadeOutTime;

		// Token: 0x040266DF RID: 157407
		[FieldOffset(24)]
		public bool lockCameraInput;

		// Token: 0x040266E0 RID: 157408
		[FieldOffset(28)]
		public FVector endPosition;

		// Token: 0x040266E1 RID: 157409
		[FieldOffset(40)]
		public float fov;

		// Token: 0x040266E2 RID: 157410
		[FieldOffset(44)]
		public bool ignoreAdjustYaw;

		// Token: 0x040266E3 RID: 157411
		[FieldOffset(45)]
		public bool staticCamera;

		// Token: 0x040266E4 RID: 157412
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073DC RID: 29660
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ExitCameraGuide_FunctionParams
	{
		// Token: 0x040266E5 RID: 157413
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073DD RID: 29661
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __EnterCameraExplore_FunctionParams
	{
		// Token: 0x040266E6 RID: 157414
		[FieldOffset(0)]
		public int id;

		// Token: 0x040266E7 RID: 157415
		[FieldOffset(4)]
		public FVector lookAt1;

		// Token: 0x040266E8 RID: 157416
		[FieldOffset(16)]
		public FVector lookAt2;

		// Token: 0x040266E9 RID: 157417
		[FieldOffset(28)]
		public float prepTime;

		// Token: 0x040266EA RID: 157418
		[FieldOffset(32)]
		public float fadeDistance;

		// Token: 0x040266EB RID: 157419
		[FieldOffset(36)]
		public float armLengthMin;

		// Token: 0x040266EC RID: 157420
		[FieldOffset(40)]
		public float armLengthMax;

		// Token: 0x040266ED RID: 157421
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073DE RID: 29662
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitCameraExplore_FunctionParams
	{
		// Token: 0x040266EE RID: 157422
		[FieldOffset(0)]
		public int id;

		// Token: 0x040266EF RID: 157423
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073DF RID: 29663
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 168)]
	protected ref struct __PlayCameraSequence_FunctionParams
	{
		// Token: 0x040266F0 RID: 157424
		[FieldOffset(0)]
		public byte 生效客户端;

		// Token: 0x040266F1 RID: 157425
		[FieldOffset(4)]
		public int entityId;

		// Token: 0x040266F2 RID: 157426
		[FieldOffset(8)]
		public byte settings;

		// Token: 0x040266F3 RID: 157427
		[FieldOffset(80)]
		public bool resetLockOnCamera;

		// Token: 0x040266F4 RID: 157428
		[FieldOffset(84)]
		public FRotator additiveRotation;

		// Token: 0x040266F5 RID: 157429
		[FieldOffset(96)]
		public FString cameraAttachSocket;

		// Token: 0x040266F6 RID: 157430
		[FieldOffset(112)]
		public FString cameraDetectSocket;

		// Token: 0x040266F7 RID: 157431
		[FieldOffset(128)]
		public FVector extraSphereLocation;

		// Token: 0x040266F8 RID: 157432
		[FieldOffset(140)]
		public float extraDetectSphereRadius;

		// Token: 0x040266F9 RID: 157433
		[FieldOffset(144)]
		public bool isShowExtraSphere;

		// Token: 0x040266FA RID: 157434
		[FieldOffset(145)]
		public bool isIgnoreCharacterCollision;

		// Token: 0x040266FB RID: 157435
		[FieldOffset(146)]
		public bool disableMovementInput;

		// Token: 0x040266FC RID: 157436
		[FieldOffset(147)]
		public bool disableLookAtInput;

		// Token: 0x040266FD RID: 157437
		[FieldOffset(148)]
		public bool disableMotionBlur;

		// Token: 0x040266FE RID: 157438
		[FieldOffset(152)]
		public IntPtr __WorldContext;

		// Token: 0x040266FF RID: 157439
		[FieldOffset(160)]
		public bool __Result;
	}

	// Token: 0x020073E0 RID: 29664
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetWidgetCameraActor_FunctionParams
	{
		// Token: 0x04026700 RID: 157440
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026701 RID: 157441
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x020073E1 RID: 29665
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetWidgetCameraBlendParams_FunctionParams
	{
		// Token: 0x04026702 RID: 157442
		[FieldOffset(0)]
		public float blendTime;

		// Token: 0x04026703 RID: 157443
		[FieldOffset(4)]
		public TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction;

		// Token: 0x04026704 RID: 157444
		[FieldOffset(8)]
		public float blendExp;

		// Token: 0x04026705 RID: 157445
		[FieldOffset(12)]
		public bool blendLocation;

		// Token: 0x04026706 RID: 157446
		[FieldOffset(13)]
		public bool isRelativeLocation;

		// Token: 0x04026707 RID: 157447
		[FieldOffset(14)]
		public bool overrideLocation;

		// Token: 0x04026708 RID: 157448
		[FieldOffset(16)]
		public FVector newLocation;

		// Token: 0x04026709 RID: 157449
		[FieldOffset(28)]
		public bool blendRotation;

		// Token: 0x0402670A RID: 157450
		[FieldOffset(29)]
		public bool isRelativeRotation;

		// Token: 0x0402670B RID: 157451
		[FieldOffset(30)]
		public bool overrideRotation;

		// Token: 0x0402670C RID: 157452
		[FieldOffset(32)]
		public FRotator newRotation;

		// Token: 0x0402670D RID: 157453
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073E2 RID: 29666
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __PlayCameraOrbital_FunctionParams
	{
		// Token: 0x0402670E RID: 157454
		[FieldOffset(0)]
		public IntPtr levelSequence;

		// Token: 0x0402670F RID: 157455
		[FieldOffset(8)]
		public FVector startLocation;

		// Token: 0x04026710 RID: 157456
		[FieldOffset(20)]
		public FVector endLocation;

		// Token: 0x04026711 RID: 157457
		[FieldOffset(32)]
		public float blendInTime;

		// Token: 0x04026712 RID: 157458
		[FieldOffset(36)]
		public float blendOutTime;

		// Token: 0x04026713 RID: 157459
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073E3 RID: 29667
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __StopCameraOrbital_FunctionParams
	{
		// Token: 0x04026714 RID: 157460
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073E4 RID: 29668
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ResetFightCameraPitchAndArmLength_FunctionParams
	{
		// Token: 0x04026715 RID: 157461
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073E5 RID: 29669
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterSequenceDialogue_FunctionParams
	{
		// Token: 0x04026716 RID: 157462
		[FieldOffset(0)]
		public IntPtr target;

		// Token: 0x04026717 RID: 157463
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073E6 RID: 29670
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ExitSequenceDialogue_FunctionParams
	{
		// Token: 0x04026718 RID: 157464
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073E7 RID: 29671
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ReloadCameraConfig_FunctionParams
	{
		// Token: 0x04026719 RID: 157465
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073E8 RID: 29672
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetAimAssistMode_FunctionParams
	{
		// Token: 0x0402671A RID: 157466
		[FieldOffset(0)]
		public byte mode;

		// Token: 0x0402671B RID: 157467
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073E9 RID: 29673
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsRoleOnCameraRight_FunctionParams
	{
		// Token: 0x0402671C RID: 157468
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402671D RID: 157469
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x020073EA RID: 29674
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCameraDebugToolEnabled_FunctionParams
	{
		// Token: 0x0402671E RID: 157470
		[FieldOffset(0)]
		public bool inEnable;

		// Token: 0x0402671F RID: 157471
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073EB RID: 29675
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugRotatorEnabled_FunctionParams
	{
		// Token: 0x04026720 RID: 157472
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073EC RID: 29676
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawCameraCollision_FunctionParams
	{
		// Token: 0x04026721 RID: 157473
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073ED RID: 29677
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawSpringArm_FunctionParams
	{
		// Token: 0x04026722 RID: 157474
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073EE RID: 29678
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawFocusTargetLine_FunctionParams
	{
		// Token: 0x04026723 RID: 157475
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073EF RID: 29679
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawSpringArmEdgeRange_FunctionParams
	{
		// Token: 0x04026724 RID: 157476
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073F0 RID: 29680
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawLockCameraMoveLine_FunctionParams
	{
		// Token: 0x04026725 RID: 157477
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073F1 RID: 29681
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawSettlementCamera_FunctionParams
	{
		// Token: 0x04026726 RID: 157478
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073F2 RID: 29682
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawCameraZone_FunctionParams
	{
		// Token: 0x04026727 RID: 157479
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073F3 RID: 29683
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	protected ref struct __GetDebugDesiredCameraProps_FunctionParams
	{
		// Token: 0x04026728 RID: 157480
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026729 RID: 157481
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x020073F4 RID: 29684
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSubCameraModifications_FunctionParams
	{
		// Token: 0x0402672A RID: 157482
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402672B RID: 157483
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x020073F5 RID: 29685
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetControllerModifications_FunctionParams
	{
		// Token: 0x0402672C RID: 157484
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402672D RID: 157485
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x020073F6 RID: 29686
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 144)]
	protected ref struct __GetCamereModeInfo_FunctionParams
	{
		// Token: 0x0402672E RID: 157486
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402672F RID: 157487
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x020073F7 RID: 29687
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __PlaySettlementCamera_FunctionParams
	{
		// Token: 0x04026730 RID: 157488
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073F8 RID: 29688
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetIsCameraTargetInScreen_FunctionParams
	{
		// Token: 0x04026731 RID: 157489
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026732 RID: 157490
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x020073F9 RID: 29689
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnterSpecialGameplayCamera_FunctionParams
	{
		// Token: 0x04026733 RID: 157491
		[FieldOffset(0)]
		public int gameplayId;

		// Token: 0x04026734 RID: 157492
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026735 RID: 157493
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x020073FA RID: 29690
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ExitSpecialGameplayCamera_FunctionParams
	{
		// Token: 0x04026736 RID: 157494
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073FB RID: 29691
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ExitSpecialGameplayCamera2_FunctionParams
	{
		// Token: 0x04026737 RID: 157495
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073FC RID: 29692
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetAimAssistModeByKey_FunctionParams
	{
		// Token: 0x04026738 RID: 157496
		[FieldOffset(0)]
		public FString key;

		// Token: 0x04026739 RID: 157497
		[FieldOffset(16)]
		public byte mode;

		// Token: 0x0402673A RID: 157498
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073FD RID: 29693
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ClearAimAssistModeByKey_FunctionParams
	{
		// Token: 0x0402673B RID: 157499
		[FieldOffset(0)]
		public FString key;

		// Token: 0x0402673C RID: 157500
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073FE RID: 29694
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSequenceCameraCollisionState_FunctionParams
	{
		// Token: 0x0402673D RID: 157501
		[FieldOffset(0)]
		public bool bEnable;

		// Token: 0x0402673E RID: 157502
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020073FF RID: 29695
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetXRayState_FunctionParams
	{
		// Token: 0x0402673F RID: 157503
		[FieldOffset(0)]
		public bool isEnable;

		// Token: 0x04026740 RID: 157504
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007400 RID: 29696
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnableCameraSpecificLockTarget_FunctionParams
	{
		// Token: 0x04026741 RID: 157505
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04026742 RID: 157506
		[FieldOffset(4)]
		public float priority;

		// Token: 0x04026743 RID: 157507
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04026744 RID: 157508
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02007401 RID: 29697
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __EnableCameraSpecificLockLocation_FunctionParams
	{
		// Token: 0x04026745 RID: 157509
		[FieldOffset(0)]
		public FVectorDouble location;

		// Token: 0x04026746 RID: 157510
		[FieldOffset(24)]
		public float priority;

		// Token: 0x04026747 RID: 157511
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x04026748 RID: 157512
		[FieldOffset(40)]
		public int __Result;
	}

	// Token: 0x02007402 RID: 29698
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DisableCameraSpecificLockOnTarget_FunctionParams
	{
		// Token: 0x04026749 RID: 157513
		[FieldOffset(0)]
		public int id;

		// Token: 0x0402674A RID: 157514
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007403 RID: 29699
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsCameraSpecificLockEnable_FunctionParams
	{
		// Token: 0x0402674B RID: 157515
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402674C RID: 157516
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02007404 RID: 29700
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetCameraSpecificLockEntityId_FunctionParams
	{
		// Token: 0x0402674D RID: 157517
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402674E RID: 157518
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x02007405 RID: 29701
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnableSoftLockCamera_FunctionParams
	{
		// Token: 0x0402674F RID: 157519
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026750 RID: 157520
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x02007406 RID: 29702
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DisableSoftLockCamera_FunctionParams
	{
		// Token: 0x04026751 RID: 157521
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04026752 RID: 157522
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007407 RID: 29703
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetCameraGravityMode_FunctionParams
	{
		// Token: 0x04026753 RID: 157523
		[FieldOffset(0)]
		public byte gravityMode;

		// Token: 0x04026754 RID: 157524
		[FieldOffset(8)]
		public FVectorDouble gravityDirect;

		// Token: 0x04026755 RID: 157525
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007408 RID: 29704
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetCameraGravityMode_FunctionParams
	{
		// Token: 0x04026756 RID: 157526
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026757 RID: 157527
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02007409 RID: 29705
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCameraGravityDirect_FunctionParams
	{
		// Token: 0x04026758 RID: 157528
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026759 RID: 157529
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200740A RID: 29706
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCameraGravityUp_FunctionParams
	{
		// Token: 0x0402675A RID: 157530
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402675B RID: 157531
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200740B RID: 29707
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCameraRotationInGravity_FunctionParams
	{
		// Token: 0x0402675C RID: 157532
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402675D RID: 157533
		[FieldOffset(8)]
		public FRotator __Result;
	}

	// Token: 0x0200740C RID: 29708
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPlayerLocationInGravity_FunctionParams
	{
		// Token: 0x0402675E RID: 157534
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x0402675F RID: 157535
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200740D RID: 29709
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetPlayerRotatorInGravity_FunctionParams
	{
		// Token: 0x04026760 RID: 157536
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026761 RID: 157537
		[FieldOffset(8)]
		public FRotator __Result;
	}

	// Token: 0x0200740E RID: 29710
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetUiCameraDebugToolEnabled_FunctionParams
	{
		// Token: 0x04026762 RID: 157538
		[FieldOffset(0)]
		public bool enabled;

		// Token: 0x04026763 RID: 157539
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200740F RID: 29711
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchUiCameraDtSync_FunctionParams
	{
		// Token: 0x04026764 RID: 157540
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007410 RID: 29712
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	protected ref struct __GetDebugToolUiCameraProps_FunctionParams
	{
		// Token: 0x04026765 RID: 157541
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04026766 RID: 157542
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02007411 RID: 29713
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchUiCameraArmLengthSync_FunctionParams
	{
		// Token: 0x04026767 RID: 157543
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007412 RID: 29714
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __OnDebugToolUiCameraArmLengthInputChanged_FunctionParams
	{
		// Token: 0x04026768 RID: 157544
		[FieldOffset(0)]
		public FString armLengthStr;

		// Token: 0x04026769 RID: 157545
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007413 RID: 29715
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __InitSeparateCamera_FunctionParams
	{
		// Token: 0x0402676A RID: 157546
		[FieldOffset(0)]
		public FString cameraName;

		// Token: 0x0402676B RID: 157547
		[FieldOffset(16)]
		public FVector2D initLocation;

		// Token: 0x0402676C RID: 157548
		[FieldOffset(24)]
		public FVector2D initSize;

		// Token: 0x0402676D RID: 157549
		[FieldOffset(32)]
		public bool enableScissorOffset;

		// Token: 0x0402676E RID: 157550
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007414 RID: 29716
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __FadeSeparateCamera_FunctionParams
	{
		// Token: 0x0402676F RID: 157551
		[FieldOffset(0)]
		public FString cameraName;

		// Token: 0x04026770 RID: 157552
		[FieldOffset(16)]
		public float fadeTime;

		// Token: 0x04026771 RID: 157553
		[FieldOffset(20)]
		public FVector2D targetViewLocation;

		// Token: 0x04026772 RID: 157554
		[FieldOffset(28)]
		public FVector2D targetViewSize;

		// Token: 0x04026773 RID: 157555
		[FieldOffset(36)]
		public bool enableScissorOffset;

		// Token: 0x04026774 RID: 157556
		[FieldOffset(40)]
		public IntPtr curve;

		// Token: 0x04026775 RID: 157557
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02007415 RID: 29717
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetOcclusionDitherState_FunctionParams
	{
		// Token: 0x04026776 RID: 157558
		[FieldOffset(0)]
		public bool isEnable;

		// Token: 0x04026777 RID: 157559
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
