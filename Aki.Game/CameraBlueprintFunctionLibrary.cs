using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using AkiClient.Game.Aki.Data.Camera.CameraDebugTool;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Camera.FightCameraController.SpecialGameplay;
using CSharpScript.Game.Module.UiCamera;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;
using UnrealEngine.Utils;

// Token: 0x020001F2 RID: 498
[UClass("/Game/Aki/TypeScript/Game/Camera/", EClassFlags.CLASS_None)]
[UnrealObjectPath("/Game/Aki/TypeScript/Game/Camera/CameraBlueprintFunctionLibrary.CameraBlueprintFunctionLibrary_C")]
public class CameraBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticVariableResetter, IUnrealUObject, IUnrealObject
{
	// Token: 0x06001F3C RID: 7996 RVA: 0x0009FD6C File Offset: 0x0009DF6C
	static CameraBlueprintFunctionLibrary()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CameraBlueprintFunctionLibrary.CreateStaticDefaultValue), new Action(CameraBlueprintFunctionLibrary.ResetStaticDefaultValue));
	}

	// Token: 0x17000514 RID: 1300
	// (get) Token: 0x06001F3D RID: 7997 RVA: 0x0009FD8B File Offset: 0x0009DF8B
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

	// Token: 0x17000515 RID: 1301
	// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0009FDA3 File Offset: 0x0009DFA3
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

	// Token: 0x17000516 RID: 1302
	// (get) Token: 0x06001F3F RID: 7999 RVA: 0x0009FDDF File Offset: 0x0009DFDF
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

	// Token: 0x17000517 RID: 1303
	// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0009FDF7 File Offset: 0x0009DFF7
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

	// Token: 0x06001F41 RID: 8001 RVA: 0x0009FE0F File Offset: 0x0009E00F
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OnPossess(APawn pawn)
	{
		CameraController.Instance.OnPossess(pawn, "MainCamera");
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x0009FE24 File Offset: 0x0009E024
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ECustomCameraMode GetCameraMode()
	{
		return CameraController.Instance.MainModel.CameraMode.Value;
	}

	// Token: 0x06001F43 RID: 8003 RVA: 0x0009FE48 File Offset: 0x0009E048
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

	// Token: 0x06001F44 RID: 8004 RVA: 0x0009FE9F File Offset: 0x0009E09F
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ALevelSequenceActor GetSequenceCameraActor()
	{
		SequenceCamera sequenceCamera = CameraController.Instance.MainModel.SequenceCamera;
		if (sequenceCamera == null)
		{
			return null;
		}
		return sequenceCamera.GetLevelSequenceActor();
	}

	// Token: 0x06001F45 RID: 8005 RVA: 0x0009FEBC File Offset: 0x0009E0BC
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

	// Token: 0x06001F46 RID: 8006 RVA: 0x0009FF18 File Offset: 0x0009E118
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

	// Token: 0x06001F47 RID: 8007 RVA: 0x0009FF73 File Offset: 0x0009E173
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetCameraRotation(FRotator rotator)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.SetRotation(rotator);
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x0009FF8F File Offset: 0x0009E18F
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsTargetSocketLocationValid()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.IsTargetLocationValid;
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x0009FFAA File Offset: 0x0009E1AA
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetTargetSocketLocation()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.TargetLocation.ToUeVector(false);
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x0009FFCB File Offset: 0x0009E1CB
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVectorDouble GetFightCameraLocation()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraLocation.ToUeVector(false);
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x0009FFEC File Offset: 0x0009E1EC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FRotator GetFightCameraRotation()
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraRotation.ToUeRotator();
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x000A000C File Offset: 0x0009E20C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static FVector GetFightCameraForward(int index)
	{
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraForward.ToUeVectorOld();
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x000A002C File Offset: 0x0009E22C
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ACameraActor GetFightCameraActor()
	{
		CameraController instance = CameraController.Instance;
		if (((instance != null) ? instance.MainModel : null) == null)
		{
			return null;
		}
		return CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraActor;
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x000A005C File Offset: 0x0009E25C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetFightCameraFollow(bool follow)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.IsFollowing = follow;
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x000A0078 File Offset: 0x0009E278
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

	// Token: 0x06001F50 RID: 8016 RVA: 0x000A00E1 File Offset: 0x0009E2E1
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ForceStopCameraModify(bool withFadeOut)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ForceStopModify(withFadeOut);
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x000A0100 File Offset: 0x0009E300
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

	// Token: 0x06001F52 RID: 8018 RVA: 0x000A01A8 File Offset: 0x0009E3A8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitCameraGuide()
	{
		global::Log.Instance.Info(ELogModule.Camera, ELogAuthor.LJM, "[CameraLookAt] ExitCameraGuide", default(ReadOnlySpan<ValueTuple<string, object>>));
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraGuide();
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x000A01EC File Offset: 0x0009E3EC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnterCameraExplore(int id, FVector lookAt1, FVector lookAt2, float prepTime, float fadeDistance, float armLengthMin, float armLengthMax)
	{
		FVectorDouble value = UKismetMathLibrary.Conv_VectorToVectorDouble(lookAt1);
		FVectorDouble value2 = UKismetMathLibrary.Conv_VectorToVectorDouble(lookAt2);
		CameraController.Instance.MainModel.FightCamera.LogicComponent.EnterCameraExplore(id, new FVectorDouble?(value), new FVectorDouble?(value2), prepTime, fadeDistance, armLengthMin, armLengthMax);
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000A0234 File Offset: 0x0009E434
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitCameraExplore(int id)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ExitCameraExplore(id);
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x000A0250 File Offset: 0x0009E450
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

	// Token: 0x06001F56 RID: 8022 RVA: 0x000A0380 File Offset: 0x0009E580
	[NullableContext(2)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static ACameraActor GetWidgetCameraActor()
	{
		return CameraController.Instance.MainModel.WidgetCamera.DisplayComponent.CineCamera;
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x000A039C File Offset: 0x0009E59C
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetWidgetCameraBlendParams(float blendTime, TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction, float blendExp, bool blendLocation, bool isRelativeLocation, bool overrideLocation, FVector newLocation, bool blendRotation, bool isRelativeRotation, bool overrideRotation, FRotator newRotation)
	{
		FVectorDouble newLocation2 = UKismetMathLibrary.Conv_VectorToVectorDouble(newLocation);
		CameraController.Instance.MainModel.WidgetCamera.BlendComponent.SetBlendParams(blendTime, blendFunction, (byte)blendExp, blendLocation, isRelativeLocation, overrideLocation, newLocation2, blendRotation, isRelativeRotation, overrideRotation, newRotation);
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000A03E1 File Offset: 0x0009E5E1
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void PlayCameraOrbital(ULevelSequence levelSequence, FVector startLocation, FVector endLocation, float blendInTime, float blendOutTime)
	{
		CameraController.Instance.MainModel.OrbitalCamera.PlayerComponent.PlayCameraOrbital(levelSequence, startLocation, endLocation, blendInTime, blendOutTime);
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000A0402 File Offset: 0x0009E602
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void StopCameraOrbital()
	{
		CameraController.Instance.MainModel.OrbitalCamera.PlayerComponent.StopCameraOrbital();
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x000A041D File Offset: 0x0009E61D
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ResetFightCameraPitchAndArmLength()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.ResetArmLengthAndRotation(Rotator.ZeroRotator);
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x000A0440 File Offset: 0x0009E640
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EnterSequenceDialogue(AActor target)
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraDialogueController.EnterSequenceDialogue(Vector.Create(target.D_K2_GetActorLocation()), false, null, null);
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000A048E File Offset: 0x0009E68E
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ExitSequenceDialogue()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraDialogueController.ExitSequenceDialogue();
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x000A04AE File Offset: 0x0009E6AE
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ReloadCameraConfig()
	{
		CameraController.Instance.MainModel.FightCamera.LogicComponent.LoadConfig();
		CameraController.Instance.MainModel.FightCamera.LogicComponent.CameraConfigController.LoadConfig();
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x000A04E7 File Offset: 0x0009E6E7
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetAimAssistMode(EAimAssistMode mode)
	{
		CameraController.Instance.MainModel.SetAimAssistMode(mode);
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x000A04FC File Offset: 0x0009E6FC
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsRoleOnCameraRight()
	{
		BaseActorComponent component = Global.BaseCharacter.GetEntityNoBlueprint().GetComponent<BaseActorComponent>();
		FightCameraLogicComponent logicComponent = CameraController.Instance.MainModel.FightCamera.LogicComponent;
		logicComponent.CameraRotation.Quaternion(CameraBlueprintFunctionLibrary.TmpQuat);
		CameraBlueprintFunctionLibrary.TmpQuat.RotateVector(Vector.RightVectorProxy, CameraBlueprintFunctionLibrary.TmpVector);
		return component.ActorLocationProxy.DotProduct(CameraBlueprintFunctionLibrary.TmpVector) - logicComponent.CameraLocation.DotProduct(CameraBlueprintFunctionLibrary.TmpVector) > 0.0;
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x000A057D File Offset: 0x0009E77D
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

	// Token: 0x06001F61 RID: 8033 RVA: 0x000A0597 File Offset: 0x0009E797
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

	// Token: 0x06001F62 RID: 8034 RVA: 0x000A05C2 File Offset: 0x0009E7C2
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

	// Token: 0x06001F63 RID: 8035 RVA: 0x000A05ED File Offset: 0x0009E7ED
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

	// Token: 0x06001F64 RID: 8036 RVA: 0x000A0618 File Offset: 0x0009E818
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

	// Token: 0x06001F65 RID: 8037 RVA: 0x000A0643 File Offset: 0x0009E843
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

	// Token: 0x06001F66 RID: 8038 RVA: 0x000A066E File Offset: 0x0009E86E
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

	// Token: 0x06001F67 RID: 8039 RVA: 0x000A0699 File Offset: 0x0009E899
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

	// Token: 0x06001F68 RID: 8040 RVA: 0x000A06C4 File Offset: 0x0009E8C4
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

	// Token: 0x06001F69 RID: 8041 RVA: 0x000A06EF File Offset: 0x0009E8EF
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TMap<string, string> GetDebugDesiredCameraProps()
	{
		return new TMap<string, string>();
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x000A06F6 File Offset: 0x0009E8F6
	[NullableContext(1)]
	public static Dictionary<string, object> GetDebugCameraPropsRaw()
	{
		return new Dictionary<string, object>();
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x000A06FD File Offset: 0x0009E8FD
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<SCameraDebugTool_SubCameraModification> GetSubCameraModifications()
	{
		return new TArray<SCameraDebugTool_SubCameraModification>();
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x000A0704 File Offset: 0x0009E904
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TArray<SCameraDebugTool_ControllerModification> GetControllerModifications()
	{
		return new TArray<SCameraDebugTool_ControllerModification>();
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000A070B File Offset: 0x0009E90B
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static SCameraDebugTool_CameraModeInfo GetCamereModeInfo()
	{
		return new SCameraDebugTool_CameraModeInfo();
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000A0712 File Offset: 0x0009E912
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

	// Token: 0x06001F6F RID: 8047 RVA: 0x000A0740 File Offset: 0x0009E940
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool GetIsCameraTargetInScreen()
	{
		FightCamera fightCamera = CameraController.Instance.MainModel.FightCamera;
		FightCameraLogicComponent fightCameraLogicComponent = (fightCamera != null) ? fightCamera.LogicComponent : null;
		return fightCameraLogicComponent != null && fightCameraLogicComponent.IsTargetLocationValid && fightCameraLogicComponent.CheckPositionInScreen(fightCameraLogicComponent.TargetLocation, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMinX, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMaxX, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMinY, fightCameraLogicComponent.CameraAdjustController.CheckInScreenMaxY);
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x000A07B4 File Offset: 0x0009E9B4
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

	// Token: 0x06001F71 RID: 8049 RVA: 0x000A07DC File Offset: 0x0009E9DC
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

	// Token: 0x06001F72 RID: 8050 RVA: 0x000A0801 File Offset: 0x0009EA01
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

	// Token: 0x06001F73 RID: 8051 RVA: 0x000A0826 File Offset: 0x0009EA26
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SetAimAssistModeByKey(string key, EAimAssistMode mode)
	{
		CameraController.Instance.MainModel.SetAimAssistModeWithKey(key, mode);
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x000A0839 File Offset: 0x0009EA39
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ClearAimAssistModeByKey(string key)
	{
		CameraController.Instance.MainModel.ClearAimAssistModeWithKey(key);
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x000A084B File Offset: 0x0009EA4B
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

	// Token: 0x06001F76 RID: 8054 RVA: 0x000A0874 File Offset: 0x0009EA74
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

	// Token: 0x06001F77 RID: 8055 RVA: 0x000A08E0 File Offset: 0x0009EAE0
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

	// Token: 0x06001F78 RID: 8056 RVA: 0x000A097C File Offset: 0x0009EB7C
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

	// Token: 0x06001F79 RID: 8057 RVA: 0x000A0A20 File Offset: 0x0009EC20
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

	// Token: 0x06001F7A RID: 8058 RVA: 0x000A0A69 File Offset: 0x0009EC69
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool IsCameraSpecificLockEnable()
	{
		return CameraController.Instance.MainModel.GetCameraSpecificLockTarget() != null;
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x000A0A80 File Offset: 0x0009EC80
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

	// Token: 0x06001F7C RID: 8060 RVA: 0x000A0AB8 File Offset: 0x0009ECB8
	[UFunction(EFunctionFlags.FUNC_None)]
	public static int EnableSoftLockCamera()
	{
		CameraController instance = CameraController.Instance;
		if (((instance != null) ? instance.MainModel : null) == null)
		{
			return -1;
		}
		int num = CameraController.Instance.MainModel.EnableSoftLock("Bp EnableSoftLockCamera1");
		global::Log instance2 = global::Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "CameraBlueprintFunctionLibrary EnableSoftLockCamera";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", num);
		instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return num;
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x000A0B1C File Offset: 0x0009ED1C
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

	// Token: 0x06001F7E RID: 8062 RVA: 0x000A0B80 File Offset: 0x0009ED80
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

	// Token: 0x06001F7F RID: 8063 RVA: 0x000A0BD4 File Offset: 0x0009EDD4
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

	// Token: 0x06001F80 RID: 8064 RVA: 0x000A0C18 File Offset: 0x0009EE18
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

	// Token: 0x06001F81 RID: 8065 RVA: 0x000A0C64 File Offset: 0x0009EE64
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

	// Token: 0x06001F82 RID: 8066 RVA: 0x000A0CB0 File Offset: 0x0009EEB0
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

	// Token: 0x06001F83 RID: 8067 RVA: 0x000A0CFC File Offset: 0x0009EEFC
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

	// Token: 0x06001F84 RID: 8068 RVA: 0x000A0D48 File Offset: 0x0009EF48
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

	// Token: 0x06001F85 RID: 8069 RVA: 0x000A0D93 File Offset: 0x0009EF93
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

	// Token: 0x06001F86 RID: 8070 RVA: 0x000A0DB0 File Offset: 0x0009EFB0
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchUiCameraDtSync()
	{
		UiCameraDebugTool uiCameraDebugTool = UiCameraModel.Instance.UiCameraDebugTool;
		if (uiCameraDebugTool == null)
		{
			return;
		}
		if (uiCameraDebugTool.GetDtSyncEnabled())
		{
			uiCameraDebugTool.EndDtSync();
			return;
		}
		uiCameraDebugTool.StartDtSync();
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x000A0DE1 File Offset: 0x0009EFE1
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static TMap<string, string> GetDebugToolUiCameraProps()
	{
		return new TMap<string, string>();
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x000A0DE8 File Offset: 0x0009EFE8
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void SwitchUiCameraArmLengthSync()
	{
		UiCameraDebugTool uiCameraDebugTool = UiCameraModel.Instance.UiCameraDebugTool;
		if (uiCameraDebugTool == null)
		{
			return;
		}
		if (uiCameraDebugTool.GetArmLengthSyncEnabled())
		{
			uiCameraDebugTool.EndArmLengthSync();
			return;
		}
		uiCameraDebugTool.StartArmLengthSync();
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x000A0E1C File Offset: 0x0009F01C
	[NullableContext(1)]
	[Conditional("DEBUG")]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void OnDebugToolUiCameraArmLengthInputChanged(string armLengthStr)
	{
		UiCameraDebugTool uiCameraDebugTool = UiCameraModel.Instance.UiCameraDebugTool;
		if (uiCameraDebugTool == null)
		{
			return;
		}
		float num;
		if (uiCameraDebugTool.GetArmLengthSyncEnabled() && float.TryParse(armLengthStr, NumberStyles.Float, CultureInfo.InvariantCulture, out num) && num > 0f)
		{
			uiCameraDebugTool.ArmLengthSync(num);
		}
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x000A0E64 File Offset: 0x0009F064
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

	// Token: 0x06001F8B RID: 8075 RVA: 0x000A0F55 File Offset: 0x0009F155
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool CreateSequenceSeparateCamera(FName cameraName, FName sequenceCameraTag, FKuroSeparateCameraData layout, bool enableSequencePlayerLogic)
	{
		return CameraController.Instance.CreateSequenceSeparateCamera(cameraName, sequenceCameraTag, layout, enableSequencePlayerLogic);
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x000A0F65 File Offset: 0x0009F165
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UpdateSequenceSeparateCamera(FName cameraName, FKuroSeparateCameraData layout)
	{
		CameraController.Instance.UpdateSequenceSeparateCamera(cameraName, layout);
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000A0F73 File Offset: 0x0009F173
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void DestroySequenceSeparateCamera(FName cameraName)
	{
		CameraController.Instance.DestroySequenceSeparateCamera(cameraName);
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x000A0F80 File Offset: 0x0009F180
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void UpdateSequenceMainCamera(FKuroSeparateCameraData layout)
	{
		CameraController.Instance.UpdateSequenceMainCamera(layout);
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x000A0F8D File Offset: 0x0009F18D
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void ResetSequenceMainCamera()
	{
		CameraController.Instance.ResetSequenceMainCamera();
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x000A0F99 File Offset: 0x0009F199
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static bool BeginSequenceSeparateCameraEditorPreview(string ownerId)
	{
		return CameraController.Instance.BeginEditorPreview(ownerId);
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x000A0FA6 File Offset: 0x0009F1A6
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static ACameraActor PrepareSequenceMainCameraEditorPreview(string ownerId, FKuroSeparateCameraData layout)
	{
		return CameraController.Instance.PrepareEditorPreviewMainCamera(ownerId, layout);
	}

	// Token: 0x06001F92 RID: 8082 RVA: 0x000A0FB4 File Offset: 0x0009F1B4
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	[return: Nullable(2)]
	public static ACameraActor PrepareSequenceSeparateCameraEditorPreview(string ownerId, FName cameraName, FKuroSeparateCameraData layout)
	{
		return CameraController.Instance.PrepareEditorPreviewSeparateCamera(ownerId, cameraName, layout);
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x000A0FC3 File Offset: 0x0009F1C3
	[NullableContext(1)]
	[UFunction(EFunctionFlags.FUNC_None)]
	public static void EndSequenceSeparateCameraEditorPreview(string ownerId, bool deferCameraModelDestruction = false)
	{
		CameraController.Instance.EndEditorPreview(ownerId, deferCameraModelDestruction);
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x000A0FD4 File Offset: 0x0009F1D4
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

	// Token: 0x06001F95 RID: 8085 RVA: 0x000A1033 File Offset: 0x0009F233
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x000A1035 File Offset: 0x0009F235
	public static void ResetStaticDefaultValue()
	{
		CameraBlueprintFunctionLibrary._tmpQuatInternal = null;
		CameraBlueprintFunctionLibrary._cacheLookAtVector = null;
		CameraBlueprintFunctionLibrary._cacheLookAtVector1 = null;
		CameraBlueprintFunctionLibrary._tmpVectorInternal = null;
		CameraBlueprintFunctionLibrary._tmpVector2D1Internal = null;
		CameraBlueprintFunctionLibrary._tmpVector2D2Internal = null;
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x000A105C File Offset: 0x0009F25C
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
			string message = "CameraBlueprintFunctionLibrary SetOcclusionDitherState12";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("isEnable", isEnable);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x000A10C7 File Offset: 0x0009F2C7
	public new static UClassStackOnlyPtr StaticClass()
	{
		if (CameraBlueprintFunctionLibrary._ClassPtr == IntPtr.Zero)
		{
			UObjectGlobals.StaticLoadClass(null, "/Game/Aki/TypeScript/Game/Camera/CameraBlueprintFunctionLibrary.CameraBlueprintFunctionLibrary_C");
		}
		return CameraBlueprintFunctionLibrary._ClassPtr;
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x000A10EC File Offset: 0x0009F2EC
	public CameraBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(CameraBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
	{
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x000A1114 File Offset: 0x0009F314
	[NullableContext(1)]
	public CameraBlueprintFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(CameraBlueprintFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
	{
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x000A1147 File Offset: 0x0009F347
	protected CameraBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
	{
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x000A1150 File Offset: 0x0009F350
	protected unsafe static void __CPPCALL_OnPossess_Implementation(CameraBlueprintFunctionLibrary.__OnPossess_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.OnPossess(BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(__Params->pawn));
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x000A1162 File Offset: 0x0009F362
	protected unsafe static void __CPPCALL_GetCameraMode_Implementation(CameraBlueprintFunctionLibrary.__GetCameraMode_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)CameraBlueprintFunctionLibrary.GetCameraMode();
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x000A1171 File Offset: 0x0009F371
	protected unsafe static void __CPPCALL_GetPhotoCameraComponent_Implementation(CameraBlueprintFunctionLibrary.__GetPhotoCameraComponent_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		UCameraComponent photoCameraComponent = CameraBlueprintFunctionLibrary.GetPhotoCameraComponent();
		ptr = ((photoCameraComponent != null) ? photoCameraComponent.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x000A118D File Offset: 0x0009F38D
	protected unsafe static void __CPPCALL_GetSequenceCameraActor_Implementation(CameraBlueprintFunctionLibrary.__GetSequenceCameraActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ALevelSequenceActor sequenceCameraActor = CameraBlueprintFunctionLibrary.GetSequenceCameraActor();
		ptr = ((sequenceCameraActor != null) ? sequenceCameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x000A11A9 File Offset: 0x0009F3A9
	protected unsafe static void __CPPCALL_EnterCameraMode_Implementation(CameraBlueprintFunctionLibrary.__EnterCameraMode_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.EnterCameraMode((ECustomCameraMode)__Params->cameraMode, __Params->blendTime, __Params->blendFunction, __Params->blendExp);
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x000A11C8 File Offset: 0x0009F3C8
	protected unsafe static void __CPPCALL_ExitCameraMode_Implementation(CameraBlueprintFunctionLibrary.__ExitCameraMode_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitCameraMode((ECustomCameraMode)__Params->cameraMode, __Params->blendTime, __Params->blendFunction, __Params->blendExp);
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x000A11E7 File Offset: 0x0009F3E7
	protected unsafe static void __CPPCALL_SetCameraRotation_Implementation(CameraBlueprintFunctionLibrary.__SetCameraRotation_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetCameraRotation(__Params->rotator);
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x000A11F4 File Offset: 0x0009F3F4
	protected unsafe static void __CPPCALL_IsTargetSocketLocationValid_Implementation(CameraBlueprintFunctionLibrary.__IsTargetSocketLocationValid_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.IsTargetSocketLocationValid();
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x000A1201 File Offset: 0x0009F401
	protected unsafe static void __CPPCALL_GetTargetSocketLocation_Implementation(CameraBlueprintFunctionLibrary.__GetTargetSocketLocation_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetTargetSocketLocation();
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x000A120E File Offset: 0x0009F40E
	protected unsafe static void __CPPCALL_GetFightCameraLocation_Implementation(CameraBlueprintFunctionLibrary.__GetFightCameraLocation_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetFightCameraLocation();
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x000A121B File Offset: 0x0009F41B
	protected unsafe static void __CPPCALL_GetFightCameraRotation_Implementation(CameraBlueprintFunctionLibrary.__GetFightCameraRotation_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetFightCameraRotation();
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x000A1228 File Offset: 0x0009F428
	protected unsafe static void __CPPCALL_GetFightCameraForward_Implementation(CameraBlueprintFunctionLibrary.__GetFightCameraForward_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetFightCameraForward(__Params->index);
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x000A123B File Offset: 0x0009F43B
	protected unsafe static void __CPPCALL_GetFightCameraActor_Implementation(CameraBlueprintFunctionLibrary.__GetFightCameraActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ACameraActor fightCameraActor = CameraBlueprintFunctionLibrary.GetFightCameraActor();
		ptr = ((fightCameraActor != null) ? fightCameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x000A1257 File Offset: 0x0009F457
	protected unsafe static void __CPPCALL_SetFightCameraFollow_Implementation(CameraBlueprintFunctionLibrary.__SetFightCameraFollow_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetFightCameraFollow(__Params->follow);
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x000A1264 File Offset: 0x0009F464
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

	// Token: 0x06001FAB RID: 8107 RVA: 0x000A131F File Offset: 0x0009F51F
	protected unsafe static void __CPPCALL_ForceStopCameraModify_Implementation(CameraBlueprintFunctionLibrary.__ForceStopCameraModify_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ForceStopCameraModify(__Params->withFadeOut);
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x000A132C File Offset: 0x0009F52C
	protected unsafe static void __CPPCALL_ApplyCameraGuide_Implementation(CameraBlueprintFunctionLibrary.__ApplyCameraGuide_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ApplyCameraGuide(__Params->lookAt, __Params->fadeInTime, __Params->stayTime, __Params->fadeOutTime, __Params->lockCameraInput, __Params->endPosition, __Params->fov, __Params->ignoreAdjustYaw, __Params->staticCamera);
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x000A1374 File Offset: 0x0009F574
	protected unsafe static void __CPPCALL_ExitCameraGuide_Implementation(CameraBlueprintFunctionLibrary.__ExitCameraGuide_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitCameraGuide();
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x000A137B File Offset: 0x0009F57B
	protected unsafe static void __CPPCALL_EnterCameraExplore_Implementation(CameraBlueprintFunctionLibrary.__EnterCameraExplore_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.EnterCameraExplore(__Params->id, __Params->lookAt1, __Params->lookAt2, __Params->prepTime, __Params->fadeDistance, __Params->armLengthMin, __Params->armLengthMax);
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x000A13AC File Offset: 0x0009F5AC
	protected unsafe static void __CPPCALL_ExitCameraExplore_Implementation(CameraBlueprintFunctionLibrary.__ExitCameraExplore_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitCameraExplore(__Params->id);
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x000A13BC File Offset: 0x0009F5BC
	protected unsafe static void __CPPCALL_PlayCameraSequence_Implementation(CameraBlueprintFunctionLibrary.__PlayCameraSequence_FunctionParams* __Params)
	{
		ESequenceCameraAnsEffectiveClientType 生效客户端 = (ESequenceCameraAnsEffectiveClientType)__Params->生效客户端;
		SSequenceCamera_Settings settings = new SSequenceCamera_Settings(&__Params->settings, true, true);
		string cameraAttachSocket = FString.ToString((void*)(&__Params->cameraAttachSocket));
		string cameraDetectSocket = FString.ToString((void*)(&__Params->cameraDetectSocket));
		__Params->__Result = CameraBlueprintFunctionLibrary.PlayCameraSequence(生效客户端, __Params->entityId, settings, __Params->resetLockOnCamera, __Params->additiveRotation, cameraAttachSocket, cameraDetectSocket, __Params->extraSphereLocation, __Params->extraDetectSphereRadius, __Params->isShowExtraSphere, __Params->isIgnoreCharacterCollision, __Params->disableMovementInput, __Params->disableLookAtInput, __Params->disableMotionBlur);
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x000A1444 File Offset: 0x0009F644
	protected unsafe static void __CPPCALL_GetWidgetCameraActor_Implementation(CameraBlueprintFunctionLibrary.__GetWidgetCameraActor_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ACameraActor widgetCameraActor = CameraBlueprintFunctionLibrary.GetWidgetCameraActor();
		ptr = ((widgetCameraActor != null) ? widgetCameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x000A1460 File Offset: 0x0009F660
	protected unsafe static void __CPPCALL_SetWidgetCameraBlendParams_Implementation(CameraBlueprintFunctionLibrary.__SetWidgetCameraBlendParams_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetWidgetCameraBlendParams(__Params->blendTime, __Params->blendFunction, __Params->blendExp, __Params->blendLocation, __Params->isRelativeLocation, __Params->overrideLocation, __Params->newLocation, __Params->blendRotation, __Params->isRelativeRotation, __Params->overrideRotation, __Params->newRotation);
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x000A14B4 File Offset: 0x0009F6B4
	protected unsafe static void __CPPCALL_PlayCameraOrbital_Implementation(CameraBlueprintFunctionLibrary.__PlayCameraOrbital_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.PlayCameraOrbital(BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelSequence>(__Params->levelSequence), __Params->startLocation, __Params->endLocation, __Params->blendInTime, __Params->blendOutTime);
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x000A14DE File Offset: 0x0009F6DE
	protected unsafe static void __CPPCALL_StopCameraOrbital_Implementation(CameraBlueprintFunctionLibrary.__StopCameraOrbital_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.StopCameraOrbital();
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x000A14E5 File Offset: 0x0009F6E5
	protected unsafe static void __CPPCALL_ResetFightCameraPitchAndArmLength_Implementation(CameraBlueprintFunctionLibrary.__ResetFightCameraPitchAndArmLength_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ResetFightCameraPitchAndArmLength();
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x000A14EC File Offset: 0x0009F6EC
	protected unsafe static void __CPPCALL_EnterSequenceDialogue_Implementation(CameraBlueprintFunctionLibrary.__EnterSequenceDialogue_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.EnterSequenceDialogue(BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(__Params->target));
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x000A14FE File Offset: 0x0009F6FE
	protected unsafe static void __CPPCALL_ExitSequenceDialogue_Implementation(CameraBlueprintFunctionLibrary.__ExitSequenceDialogue_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitSequenceDialogue();
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x000A1505 File Offset: 0x0009F705
	protected unsafe static void __CPPCALL_ReloadCameraConfig_Implementation(CameraBlueprintFunctionLibrary.__ReloadCameraConfig_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ReloadCameraConfig();
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x000A150C File Offset: 0x0009F70C
	protected unsafe static void __CPPCALL_SetAimAssistMode_Implementation(CameraBlueprintFunctionLibrary.__SetAimAssistMode_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetAimAssistMode((EAimAssistMode)__Params->mode);
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x000A1519 File Offset: 0x0009F719
	protected unsafe static void __CPPCALL_IsRoleOnCameraRight_Implementation(CameraBlueprintFunctionLibrary.__IsRoleOnCameraRight_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.IsRoleOnCameraRight();
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000A1526 File Offset: 0x0009F726
	protected unsafe static void __CPPCALL_SetCameraDebugToolEnabled_Implementation(CameraBlueprintFunctionLibrary.__SetCameraDebugToolEnabled_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x000A1528 File Offset: 0x0009F728
	protected unsafe static void __CPPCALL_SwitchCameraDebugRotatorEnabled_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugRotatorEnabled_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x000A152A File Offset: 0x0009F72A
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawCameraCollision_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawCameraCollision_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x000A152C File Offset: 0x0009F72C
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawSpringArm_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawSpringArm_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000A152E File Offset: 0x0009F72E
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawFocusTargetLine_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawFocusTargetLine_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x000A1530 File Offset: 0x0009F730
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawSpringArmEdgeRange_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawSpringArmEdgeRange_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x000A1532 File Offset: 0x0009F732
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawLockCameraMoveLine_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawLockCameraMoveLine_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x000A1534 File Offset: 0x0009F734
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawSettlementCamera_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawSettlementCamera_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000A1536 File Offset: 0x0009F736
	protected unsafe static void __CPPCALL_SwitchCameraDebugToolDrawCameraZone_Implementation(CameraBlueprintFunctionLibrary.__SwitchCameraDebugToolDrawCameraZone_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x000A1538 File Offset: 0x0009F738
	protected unsafe static void __CPPCALL_GetDebugDesiredCameraProps_Implementation(CameraBlueprintFunctionLibrary.__GetDebugDesiredCameraProps_FunctionParams* __Params)
	{
		TMap<string, string> debugDesiredCameraProps = CameraBlueprintFunctionLibrary.GetDebugDesiredCameraProps();
		if (debugDesiredCameraProps == null)
		{
			return;
		}
		debugDesiredCameraProps.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000A1564 File Offset: 0x0009F764
	protected unsafe static void __CPPCALL_GetSubCameraModifications_Implementation(CameraBlueprintFunctionLibrary.__GetSubCameraModifications_FunctionParams* __Params)
	{
		TArray<SCameraDebugTool_SubCameraModification> subCameraModifications = CameraBlueprintFunctionLibrary.GetSubCameraModifications();
		if (subCameraModifications == null)
		{
			return;
		}
		subCameraModifications.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x000A1590 File Offset: 0x0009F790
	protected unsafe static void __CPPCALL_GetControllerModifications_Implementation(CameraBlueprintFunctionLibrary.__GetControllerModifications_FunctionParams* __Params)
	{
		TArray<SCameraDebugTool_ControllerModification> controllerModifications = CameraBlueprintFunctionLibrary.GetControllerModifications();
		if (controllerModifications == null)
		{
			return;
		}
		controllerModifications.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000A15BC File Offset: 0x0009F7BC
	protected unsafe static void __CPPCALL_GetCamereModeInfo_Implementation(CameraBlueprintFunctionLibrary.__GetCamereModeInfo_FunctionParams* __Params)
	{
		UScriptStructStackOnlyPtr nativeUStructPtr = SCameraDebugTool_CameraModeInfo.StaticStruct();
		IntPtr dest = &__Params->__Result;
		SCameraDebugTool_CameraModeInfo camereModeInfo = CameraBlueprintFunctionLibrary.GetCamereModeInfo();
		UnrealReflectionUtils.CopyNativeStruct(nativeUStructPtr, dest, (camereModeInfo != null) ? camereModeInfo.NativePtr : ((IntPtr)0), 1, false);
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x000A15E3 File Offset: 0x0009F7E3
	protected unsafe static void __CPPCALL_PlaySettlementCamera_Implementation(CameraBlueprintFunctionLibrary.__PlaySettlementCamera_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x000A15E5 File Offset: 0x0009F7E5
	protected unsafe static void __CPPCALL_GetIsCameraTargetInScreen_Implementation(CameraBlueprintFunctionLibrary.__GetIsCameraTargetInScreen_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetIsCameraTargetInScreen();
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x000A15F2 File Offset: 0x0009F7F2
	protected unsafe static void __CPPCALL_EnterSpecialGameplayCamera_Implementation(CameraBlueprintFunctionLibrary.__EnterSpecialGameplayCamera_FunctionParams* __Params)
	{
		ref IntPtr ptr = ref *(&__Params->__Result);
		ACameraActor acameraActor = CameraBlueprintFunctionLibrary.EnterSpecialGameplayCamera(__Params->gameplayId);
		ptr = ((acameraActor != null) ? acameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x000A1614 File Offset: 0x0009F814
	protected unsafe static void __CPPCALL_ExitSpecialGameplayCamera_Implementation(CameraBlueprintFunctionLibrary.__ExitSpecialGameplayCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitSpecialGameplayCamera();
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x000A161B File Offset: 0x0009F81B
	protected unsafe static void __CPPCALL_ExitSpecialGameplayCamera2_Implementation(CameraBlueprintFunctionLibrary.__ExitSpecialGameplayCamera2_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ExitSpecialGameplayCamera2();
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000A1624 File Offset: 0x0009F824
	protected unsafe static void __CPPCALL_SetAimAssistModeByKey_Implementation(CameraBlueprintFunctionLibrary.__SetAimAssistModeByKey_FunctionParams* __Params)
	{
		string key = FString.ToString((void*)(&__Params->key));
		EAimAssistMode mode = (EAimAssistMode)__Params->mode;
		CameraBlueprintFunctionLibrary.SetAimAssistModeByKey(key, mode);
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000A164A File Offset: 0x0009F84A
	protected unsafe static void __CPPCALL_ClearAimAssistModeByKey_Implementation(CameraBlueprintFunctionLibrary.__ClearAimAssistModeByKey_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ClearAimAssistModeByKey(FString.ToString((void*)(&__Params->key)));
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000A165D File Offset: 0x0009F85D
	protected unsafe static void __CPPCALL_SetSequenceCameraCollisionState_Implementation(CameraBlueprintFunctionLibrary.__SetSequenceCameraCollisionState_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetSequenceCameraCollisionState(__Params->bEnable);
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000A166A File Offset: 0x0009F86A
	protected unsafe static void __CPPCALL_SetXRayState_Implementation(CameraBlueprintFunctionLibrary.__SetXRayState_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetXRayState(__Params->isEnable);
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x000A1677 File Offset: 0x0009F877
	protected unsafe static void __CPPCALL_EnableCameraSpecificLockTarget_Implementation(CameraBlueprintFunctionLibrary.__EnableCameraSpecificLockTarget_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.EnableCameraSpecificLockTarget(__Params->entityId, __Params->priority);
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x000A1690 File Offset: 0x0009F890
	protected unsafe static void __CPPCALL_EnableCameraSpecificLockLocation_Implementation(CameraBlueprintFunctionLibrary.__EnableCameraSpecificLockLocation_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.EnableCameraSpecificLockLocation(__Params->location, __Params->priority);
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x000A16A9 File Offset: 0x0009F8A9
	protected unsafe static void __CPPCALL_DisableCameraSpecificLockOnTarget_Implementation(CameraBlueprintFunctionLibrary.__DisableCameraSpecificLockOnTarget_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.DisableCameraSpecificLockOnTarget(__Params->id);
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x000A16B6 File Offset: 0x0009F8B6
	protected unsafe static void __CPPCALL_IsCameraSpecificLockEnable_Implementation(CameraBlueprintFunctionLibrary.__IsCameraSpecificLockEnable_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.IsCameraSpecificLockEnable();
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x000A16C3 File Offset: 0x0009F8C3
	protected unsafe static void __CPPCALL_GetCameraSpecificLockEntityId_Implementation(CameraBlueprintFunctionLibrary.__GetCameraSpecificLockEntityId_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetCameraSpecificLockEntityId();
	}

	// Token: 0x06001FD6 RID: 8150 RVA: 0x000A16D0 File Offset: 0x0009F8D0
	protected unsafe static void __CPPCALL_EnableSoftLockCamera_Implementation(CameraBlueprintFunctionLibrary.__EnableSoftLockCamera_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.EnableSoftLockCamera();
	}

	// Token: 0x06001FD7 RID: 8151 RVA: 0x000A16DD File Offset: 0x0009F8DD
	protected unsafe static void __CPPCALL_DisableSoftLockCamera_Implementation(CameraBlueprintFunctionLibrary.__DisableSoftLockCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.DisableSoftLockCamera(__Params->handle);
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x000A16EA File Offset: 0x0009F8EA
	protected unsafe static void __CPPCALL_SetCameraGravityMode_Implementation(CameraBlueprintFunctionLibrary.__SetCameraGravityMode_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetCameraGravityMode((ECameraGravityMode)__Params->gravityMode, __Params->gravityDirect);
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x000A16FD File Offset: 0x0009F8FD
	protected unsafe static void __CPPCALL_GetCameraGravityMode_Implementation(CameraBlueprintFunctionLibrary.__GetCameraGravityMode_FunctionParams* __Params)
	{
		*(&__Params->__Result) = (byte)CameraBlueprintFunctionLibrary.GetCameraGravityMode();
	}

	// Token: 0x06001FDA RID: 8154 RVA: 0x000A170C File Offset: 0x0009F90C
	protected unsafe static void __CPPCALL_GetCameraGravityDirect_Implementation(CameraBlueprintFunctionLibrary.__GetCameraGravityDirect_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetCameraGravityDirect();
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x000A1719 File Offset: 0x0009F919
	protected unsafe static void __CPPCALL_GetCameraGravityUp_Implementation(CameraBlueprintFunctionLibrary.__GetCameraGravityUp_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetCameraGravityUp();
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x000A1726 File Offset: 0x0009F926
	protected unsafe static void __CPPCALL_GetCameraRotationInGravity_Implementation(CameraBlueprintFunctionLibrary.__GetCameraRotationInGravity_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetCameraRotationInGravity();
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x000A1733 File Offset: 0x0009F933
	protected unsafe static void __CPPCALL_GetPlayerLocationInGravity_Implementation(CameraBlueprintFunctionLibrary.__GetPlayerLocationInGravity_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetPlayerLocationInGravity();
	}

	// Token: 0x06001FDE RID: 8158 RVA: 0x000A1740 File Offset: 0x0009F940
	protected unsafe static void __CPPCALL_GetPlayerRotatorInGravity_Implementation(CameraBlueprintFunctionLibrary.__GetPlayerRotatorInGravity_FunctionParams* __Params)
	{
		__Params->__Result = CameraBlueprintFunctionLibrary.GetPlayerRotatorInGravity();
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x000A174D File Offset: 0x0009F94D
	protected unsafe static void __CPPCALL_SetUiCameraDebugToolEnabled_Implementation(CameraBlueprintFunctionLibrary.__SetUiCameraDebugToolEnabled_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FE0 RID: 8160 RVA: 0x000A174F File Offset: 0x0009F94F
	protected unsafe static void __CPPCALL_SwitchUiCameraDtSync_Implementation(CameraBlueprintFunctionLibrary.__SwitchUiCameraDtSync_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x000A1754 File Offset: 0x0009F954
	protected unsafe static void __CPPCALL_GetDebugToolUiCameraProps_Implementation(CameraBlueprintFunctionLibrary.__GetDebugToolUiCameraProps_FunctionParams* __Params)
	{
		TMap<string, string> debugToolUiCameraProps = CameraBlueprintFunctionLibrary.GetDebugToolUiCameraProps();
		if (debugToolUiCameraProps == null)
		{
			return;
		}
		debugToolUiCameraProps.CopyTo(&__Params->__Result, default(UScriptStructStackOnlyPtr));
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x000A1780 File Offset: 0x0009F980
	protected unsafe static void __CPPCALL_SwitchUiCameraArmLengthSync_Implementation(CameraBlueprintFunctionLibrary.__SwitchUiCameraArmLengthSync_FunctionParams* __Params)
	{
	}

	// Token: 0x06001FE3 RID: 8163 RVA: 0x000A1782 File Offset: 0x0009F982
	protected unsafe static void __CPPCALL_OnDebugToolUiCameraArmLengthInputChanged_Implementation(CameraBlueprintFunctionLibrary.__OnDebugToolUiCameraArmLengthInputChanged_FunctionParams* __Params)
	{
		FString.ToString((void*)(&__Params->armLengthStr));
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x000A1791 File Offset: 0x0009F991
	protected unsafe static void __CPPCALL_InitSeparateCamera_Implementation(CameraBlueprintFunctionLibrary.__InitSeparateCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.InitSeparateCamera(FString.ToString((void*)(&__Params->cameraName)), __Params->initLocation, __Params->initSize, __Params->enableScissorOffset);
	}

	// Token: 0x06001FE5 RID: 8165 RVA: 0x000A17B8 File Offset: 0x0009F9B8
	protected unsafe static void __CPPCALL_CreateSequenceSeparateCamera_Implementation(CameraBlueprintFunctionLibrary.__CreateSequenceSeparateCamera_FunctionParams* __Params)
	{
		FKuroSeparateCameraData layout = new FKuroSeparateCameraData(&__Params->layout, true, true);
		__Params->__Result = CameraBlueprintFunctionLibrary.CreateSequenceSeparateCamera(__Params->cameraName, __Params->sequenceCameraTag, layout, __Params->enableSequencePlayerLogic);
	}

	// Token: 0x06001FE6 RID: 8166 RVA: 0x000A17F4 File Offset: 0x0009F9F4
	protected unsafe static void __CPPCALL_UpdateSequenceSeparateCamera_Implementation(CameraBlueprintFunctionLibrary.__UpdateSequenceSeparateCamera_FunctionParams* __Params)
	{
		FKuroSeparateCameraData layout = new FKuroSeparateCameraData(&__Params->layout, true, true);
		CameraBlueprintFunctionLibrary.UpdateSequenceSeparateCamera(__Params->cameraName, layout);
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x000A181C File Offset: 0x0009FA1C
	protected unsafe static void __CPPCALL_DestroySequenceSeparateCamera_Implementation(CameraBlueprintFunctionLibrary.__DestroySequenceSeparateCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.DestroySequenceSeparateCamera(__Params->cameraName);
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x000A1829 File Offset: 0x0009FA29
	protected unsafe static void __CPPCALL_UpdateSequenceMainCamera_Implementation(CameraBlueprintFunctionLibrary.__UpdateSequenceMainCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.UpdateSequenceMainCamera(new FKuroSeparateCameraData(&__Params->layout, true, true));
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x000A183E File Offset: 0x0009FA3E
	protected unsafe static void __CPPCALL_ResetSequenceMainCamera_Implementation(CameraBlueprintFunctionLibrary.__ResetSequenceMainCamera_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.ResetSequenceMainCamera();
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x000A1848 File Offset: 0x0009FA48
	protected unsafe static void __CPPCALL_BeginSequenceSeparateCameraEditorPreview_Implementation(CameraBlueprintFunctionLibrary.__BeginSequenceSeparateCameraEditorPreview_FunctionParams* __Params)
	{
		string ownerId = FString.ToString((void*)(&__Params->ownerId));
		__Params->__Result = CameraBlueprintFunctionLibrary.BeginSequenceSeparateCameraEditorPreview(ownerId);
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x000A1870 File Offset: 0x0009FA70
	protected unsafe static void __CPPCALL_PrepareSequenceMainCameraEditorPreview_Implementation(CameraBlueprintFunctionLibrary.__PrepareSequenceMainCameraEditorPreview_FunctionParams* __Params)
	{
		string ownerId = FString.ToString((void*)(&__Params->ownerId));
		FKuroSeparateCameraData layout = new FKuroSeparateCameraData(&__Params->layout, true, true);
		ref IntPtr ptr = ref *(&__Params->__Result);
		ACameraActor acameraActor = CameraBlueprintFunctionLibrary.PrepareSequenceMainCameraEditorPreview(ownerId, layout);
		ptr = ((acameraActor != null) ? acameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x000A18B8 File Offset: 0x0009FAB8
	protected unsafe static void __CPPCALL_PrepareSequenceSeparateCameraEditorPreview_Implementation(CameraBlueprintFunctionLibrary.__PrepareSequenceSeparateCameraEditorPreview_FunctionParams* __Params)
	{
		string ownerId = FString.ToString((void*)(&__Params->ownerId));
		FKuroSeparateCameraData layout = new FKuroSeparateCameraData(&__Params->layout, true, true);
		ref IntPtr ptr = ref *(&__Params->__Result);
		ACameraActor acameraActor = CameraBlueprintFunctionLibrary.PrepareSequenceSeparateCameraEditorPreview(ownerId, __Params->cameraName, layout);
		ptr = ((acameraActor != null) ? acameraActor.NativePtr : ((IntPtr)0));
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x000A1903 File Offset: 0x0009FB03
	protected unsafe static void __CPPCALL_EndSequenceSeparateCameraEditorPreview_Implementation(CameraBlueprintFunctionLibrary.__EndSequenceSeparateCameraEditorPreview_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.EndSequenceSeparateCameraEditorPreview(FString.ToString((void*)(&__Params->ownerId)), __Params->deferCameraModelDestruction);
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x000A191C File Offset: 0x0009FB1C
	protected unsafe static void __CPPCALL_FadeSeparateCamera_Implementation(CameraBlueprintFunctionLibrary.__FadeSeparateCamera_FunctionParams* __Params)
	{
		string cameraName = FString.ToString((void*)(&__Params->cameraName));
		UCurveFloat orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(__Params->curve);
		CameraBlueprintFunctionLibrary.FadeSeparateCamera(cameraName, __Params->fadeTime, __Params->targetViewLocation, __Params->targetViewSize, __Params->enableScissorOffset, orCreateUObjectByNativePointer);
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x000A195F File Offset: 0x0009FB5F
	protected unsafe static void __CPPCALL_SetOcclusionDitherState_Implementation(CameraBlueprintFunctionLibrary.__SetOcclusionDitherState_FunctionParams* __Params)
	{
		CameraBlueprintFunctionLibrary.SetOcclusionDitherState(__Params->isEnable);
	}

	// Token: 0x04001321 RID: 4897
	[Nullable(2)]
	private static Vector _cacheLookAtVector;

	// Token: 0x04001322 RID: 4898
	[Nullable(2)]
	private static Vector _cacheLookAtVector1;

	// Token: 0x04001323 RID: 4899
	[Nullable(2)]
	private static Vector _tmpVectorInternal;

	// Token: 0x04001324 RID: 4900
	[Nullable(2)]
	private static Quat _tmpQuatInternal;

	// Token: 0x04001325 RID: 4901
	[Nullable(2)]
	private static Vector2D _tmpVector2D1Internal;

	// Token: 0x04001326 RID: 4902
	[Nullable(2)]
	private static Vector2D _tmpVector2D2Internal;

	// Token: 0x04001327 RID: 4903
	[Nullable(1)]
	public new const string __ObjectPath = "/Game/Aki/TypeScript/Game/Camera/CameraBlueprintFunctionLibrary.CameraBlueprintFunctionLibrary_C";

	// Token: 0x04001328 RID: 4904
	private static IntPtr _ClassPtr;

	// Token: 0x04001329 RID: 4905
	private static IntPtr _ClassDefaultObjectPtr;

	// Token: 0x02006553 RID: 25939
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __OnPossess_FunctionParams
	{
		// Token: 0x040219C9 RID: 137673
		[FieldOffset(0)]
		public IntPtr pawn;

		// Token: 0x040219CA RID: 137674
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006554 RID: 25940
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetCameraMode_FunctionParams
	{
		// Token: 0x040219CB RID: 137675
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040219CC RID: 137676
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02006555 RID: 25941
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetPhotoCameraComponent_FunctionParams
	{
		// Token: 0x040219CD RID: 137677
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040219CE RID: 137678
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02006556 RID: 25942
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetSequenceCameraActor_FunctionParams
	{
		// Token: 0x040219CF RID: 137679
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040219D0 RID: 137680
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02006557 RID: 25943
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnterCameraMode_FunctionParams
	{
		// Token: 0x040219D1 RID: 137681
		[FieldOffset(0)]
		public byte cameraMode;

		// Token: 0x040219D2 RID: 137682
		[FieldOffset(4)]
		public float blendTime;

		// Token: 0x040219D3 RID: 137683
		[FieldOffset(8)]
		public TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction;

		// Token: 0x040219D4 RID: 137684
		[FieldOffset(12)]
		public float blendExp;

		// Token: 0x040219D5 RID: 137685
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006558 RID: 25944
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ExitCameraMode_FunctionParams
	{
		// Token: 0x040219D6 RID: 137686
		[FieldOffset(0)]
		public byte cameraMode;

		// Token: 0x040219D7 RID: 137687
		[FieldOffset(4)]
		public float blendTime;

		// Token: 0x040219D8 RID: 137688
		[FieldOffset(8)]
		public TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction;

		// Token: 0x040219D9 RID: 137689
		[FieldOffset(12)]
		public float blendExp;

		// Token: 0x040219DA RID: 137690
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006559 RID: 25945
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __SetCameraRotation_FunctionParams
	{
		// Token: 0x040219DB RID: 137691
		[FieldOffset(0)]
		public FRotator rotator;

		// Token: 0x040219DC RID: 137692
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200655A RID: 25946
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsTargetSocketLocationValid_FunctionParams
	{
		// Token: 0x040219DD RID: 137693
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040219DE RID: 137694
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200655B RID: 25947
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetTargetSocketLocation_FunctionParams
	{
		// Token: 0x040219DF RID: 137695
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040219E0 RID: 137696
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200655C RID: 25948
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetFightCameraLocation_FunctionParams
	{
		// Token: 0x040219E1 RID: 137697
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040219E2 RID: 137698
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x0200655D RID: 25949
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetFightCameraRotation_FunctionParams
	{
		// Token: 0x040219E3 RID: 137699
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040219E4 RID: 137700
		[FieldOffset(8)]
		public FRotator __Result;
	}

	// Token: 0x0200655E RID: 25950
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetFightCameraForward_FunctionParams
	{
		// Token: 0x040219E5 RID: 137701
		[FieldOffset(0)]
		public int index;

		// Token: 0x040219E6 RID: 137702
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x040219E7 RID: 137703
		[FieldOffset(16)]
		public FVector __Result;
	}

	// Token: 0x0200655F RID: 25951
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetFightCameraActor_FunctionParams
	{
		// Token: 0x040219E8 RID: 137704
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x040219E9 RID: 137705
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02006560 RID: 25952
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetFightCameraFollow_FunctionParams
	{
		// Token: 0x040219EA RID: 137706
		[FieldOffset(0)]
		public bool follow;

		// Token: 0x040219EB RID: 137707
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006561 RID: 25953
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 480)]
	protected ref struct __ApplyCameraModify_FunctionParams
	{
		// Token: 0x040219EC RID: 137708
		[FieldOffset(0)]
		public FGameplayTag tag;

		// Token: 0x040219ED RID: 137709
		[FieldOffset(12)]
		public float duration;

		// Token: 0x040219EE RID: 137710
		[FieldOffset(16)]
		public float blendInTime;

		// Token: 0x040219EF RID: 137711
		[FieldOffset(20)]
		public float blendOutTime;

		// Token: 0x040219F0 RID: 137712
		[FieldOffset(24)]
		public float breakBlendOutTime;

		// Token: 0x040219F1 RID: 137713
		[FieldOffset(32)]
		public byte cameraModifySettings;

		// Token: 0x040219F2 RID: 137714
		[FieldOffset(392)]
		public IntPtr montage;

		// Token: 0x040219F3 RID: 137715
		[FieldOffset(400)]
		public byte blendInCurve;

		// Token: 0x040219F4 RID: 137716
		[FieldOffset(416)]
		public byte blendOutCurve;

		// Token: 0x040219F5 RID: 137717
		[FieldOffset(432)]
		public FString cameraAttachSocket;

		// Token: 0x040219F6 RID: 137718
		[FieldOffset(448)]
		public int entityId;

		// Token: 0x040219F7 RID: 137719
		[FieldOffset(452)]
		public byte cameraEffectiveClientType;

		// Token: 0x040219F8 RID: 137720
		[FieldOffset(456)]
		public byte cameraModifierConditions;

		// Token: 0x040219F9 RID: 137721
		[FieldOffset(472)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006562 RID: 25954
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ForceStopCameraModify_FunctionParams
	{
		// Token: 0x040219FA RID: 137722
		[FieldOffset(0)]
		public bool withFadeOut;

		// Token: 0x040219FB RID: 137723
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006563 RID: 25955
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __ApplyCameraGuide_FunctionParams
	{
		// Token: 0x040219FC RID: 137724
		[FieldOffset(0)]
		public FVector lookAt;

		// Token: 0x040219FD RID: 137725
		[FieldOffset(12)]
		public float fadeInTime;

		// Token: 0x040219FE RID: 137726
		[FieldOffset(16)]
		public float stayTime;

		// Token: 0x040219FF RID: 137727
		[FieldOffset(20)]
		public float fadeOutTime;

		// Token: 0x04021A00 RID: 137728
		[FieldOffset(24)]
		public bool lockCameraInput;

		// Token: 0x04021A01 RID: 137729
		[FieldOffset(28)]
		public FVector endPosition;

		// Token: 0x04021A02 RID: 137730
		[FieldOffset(40)]
		public float fov;

		// Token: 0x04021A03 RID: 137731
		[FieldOffset(44)]
		public bool ignoreAdjustYaw;

		// Token: 0x04021A04 RID: 137732
		[FieldOffset(45)]
		public bool staticCamera;

		// Token: 0x04021A05 RID: 137733
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006564 RID: 25956
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ExitCameraGuide_FunctionParams
	{
		// Token: 0x04021A06 RID: 137734
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006565 RID: 25957
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __EnterCameraExplore_FunctionParams
	{
		// Token: 0x04021A07 RID: 137735
		[FieldOffset(0)]
		public int id;

		// Token: 0x04021A08 RID: 137736
		[FieldOffset(4)]
		public FVector lookAt1;

		// Token: 0x04021A09 RID: 137737
		[FieldOffset(16)]
		public FVector lookAt2;

		// Token: 0x04021A0A RID: 137738
		[FieldOffset(28)]
		public float prepTime;

		// Token: 0x04021A0B RID: 137739
		[FieldOffset(32)]
		public float fadeDistance;

		// Token: 0x04021A0C RID: 137740
		[FieldOffset(36)]
		public float armLengthMin;

		// Token: 0x04021A0D RID: 137741
		[FieldOffset(40)]
		public float armLengthMax;

		// Token: 0x04021A0E RID: 137742
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006566 RID: 25958
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __ExitCameraExplore_FunctionParams
	{
		// Token: 0x04021A0F RID: 137743
		[FieldOffset(0)]
		public int id;

		// Token: 0x04021A10 RID: 137744
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006567 RID: 25959
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 168)]
	protected ref struct __PlayCameraSequence_FunctionParams
	{
		// Token: 0x04021A11 RID: 137745
		[FieldOffset(0)]
		public byte 生效客户端;

		// Token: 0x04021A12 RID: 137746
		[FieldOffset(4)]
		public int entityId;

		// Token: 0x04021A13 RID: 137747
		[FieldOffset(8)]
		public byte settings;

		// Token: 0x04021A14 RID: 137748
		[FieldOffset(80)]
		public bool resetLockOnCamera;

		// Token: 0x04021A15 RID: 137749
		[FieldOffset(84)]
		public FRotator additiveRotation;

		// Token: 0x04021A16 RID: 137750
		[FieldOffset(96)]
		public FString cameraAttachSocket;

		// Token: 0x04021A17 RID: 137751
		[FieldOffset(112)]
		public FString cameraDetectSocket;

		// Token: 0x04021A18 RID: 137752
		[FieldOffset(128)]
		public FVector extraSphereLocation;

		// Token: 0x04021A19 RID: 137753
		[FieldOffset(140)]
		public float extraDetectSphereRadius;

		// Token: 0x04021A1A RID: 137754
		[FieldOffset(144)]
		public bool isShowExtraSphere;

		// Token: 0x04021A1B RID: 137755
		[FieldOffset(145)]
		public bool isIgnoreCharacterCollision;

		// Token: 0x04021A1C RID: 137756
		[FieldOffset(146)]
		public bool disableMovementInput;

		// Token: 0x04021A1D RID: 137757
		[FieldOffset(147)]
		public bool disableLookAtInput;

		// Token: 0x04021A1E RID: 137758
		[FieldOffset(148)]
		public bool disableMotionBlur;

		// Token: 0x04021A1F RID: 137759
		[FieldOffset(152)]
		public IntPtr __WorldContext;

		// Token: 0x04021A20 RID: 137760
		[FieldOffset(160)]
		public bool __Result;
	}

	// Token: 0x02006568 RID: 25960
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetWidgetCameraActor_FunctionParams
	{
		// Token: 0x04021A21 RID: 137761
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A22 RID: 137762
		[FieldOffset(8)]
		public IntPtr __Result;
	}

	// Token: 0x02006569 RID: 25961
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __SetWidgetCameraBlendParams_FunctionParams
	{
		// Token: 0x04021A23 RID: 137763
		[FieldOffset(0)]
		public float blendTime;

		// Token: 0x04021A24 RID: 137764
		[FieldOffset(4)]
		public TEnumAsByte<UnrealEngine.EViewTargetBlendFunction> blendFunction;

		// Token: 0x04021A25 RID: 137765
		[FieldOffset(8)]
		public float blendExp;

		// Token: 0x04021A26 RID: 137766
		[FieldOffset(12)]
		public bool blendLocation;

		// Token: 0x04021A27 RID: 137767
		[FieldOffset(13)]
		public bool isRelativeLocation;

		// Token: 0x04021A28 RID: 137768
		[FieldOffset(14)]
		public bool overrideLocation;

		// Token: 0x04021A29 RID: 137769
		[FieldOffset(16)]
		public FVector newLocation;

		// Token: 0x04021A2A RID: 137770
		[FieldOffset(28)]
		public bool blendRotation;

		// Token: 0x04021A2B RID: 137771
		[FieldOffset(29)]
		public bool isRelativeRotation;

		// Token: 0x04021A2C RID: 137772
		[FieldOffset(30)]
		public bool overrideRotation;

		// Token: 0x04021A2D RID: 137773
		[FieldOffset(32)]
		public FRotator newRotation;

		// Token: 0x04021A2E RID: 137774
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200656A RID: 25962
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __PlayCameraOrbital_FunctionParams
	{
		// Token: 0x04021A2F RID: 137775
		[FieldOffset(0)]
		public IntPtr levelSequence;

		// Token: 0x04021A30 RID: 137776
		[FieldOffset(8)]
		public FVector startLocation;

		// Token: 0x04021A31 RID: 137777
		[FieldOffset(20)]
		public FVector endLocation;

		// Token: 0x04021A32 RID: 137778
		[FieldOffset(32)]
		public float blendInTime;

		// Token: 0x04021A33 RID: 137779
		[FieldOffset(36)]
		public float blendOutTime;

		// Token: 0x04021A34 RID: 137780
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200656B RID: 25963
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __StopCameraOrbital_FunctionParams
	{
		// Token: 0x04021A35 RID: 137781
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200656C RID: 25964
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ResetFightCameraPitchAndArmLength_FunctionParams
	{
		// Token: 0x04021A36 RID: 137782
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200656D RID: 25965
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnterSequenceDialogue_FunctionParams
	{
		// Token: 0x04021A37 RID: 137783
		[FieldOffset(0)]
		public IntPtr target;

		// Token: 0x04021A38 RID: 137784
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200656E RID: 25966
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ExitSequenceDialogue_FunctionParams
	{
		// Token: 0x04021A39 RID: 137785
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200656F RID: 25967
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ReloadCameraConfig_FunctionParams
	{
		// Token: 0x04021A3A RID: 137786
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006570 RID: 25968
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetAimAssistMode_FunctionParams
	{
		// Token: 0x04021A3B RID: 137787
		[FieldOffset(0)]
		public byte mode;

		// Token: 0x04021A3C RID: 137788
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006571 RID: 25969
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsRoleOnCameraRight_FunctionParams
	{
		// Token: 0x04021A3D RID: 137789
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A3E RID: 137790
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02006572 RID: 25970
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetCameraDebugToolEnabled_FunctionParams
	{
		// Token: 0x04021A3F RID: 137791
		[FieldOffset(0)]
		public bool inEnable;

		// Token: 0x04021A40 RID: 137792
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006573 RID: 25971
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugRotatorEnabled_FunctionParams
	{
		// Token: 0x04021A41 RID: 137793
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006574 RID: 25972
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawCameraCollision_FunctionParams
	{
		// Token: 0x04021A42 RID: 137794
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006575 RID: 25973
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawSpringArm_FunctionParams
	{
		// Token: 0x04021A43 RID: 137795
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006576 RID: 25974
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawFocusTargetLine_FunctionParams
	{
		// Token: 0x04021A44 RID: 137796
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006577 RID: 25975
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawSpringArmEdgeRange_FunctionParams
	{
		// Token: 0x04021A45 RID: 137797
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006578 RID: 25976
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawLockCameraMoveLine_FunctionParams
	{
		// Token: 0x04021A46 RID: 137798
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006579 RID: 25977
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawSettlementCamera_FunctionParams
	{
		// Token: 0x04021A47 RID: 137799
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200657A RID: 25978
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchCameraDebugToolDrawCameraZone_FunctionParams
	{
		// Token: 0x04021A48 RID: 137800
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200657B RID: 25979
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	protected ref struct __GetDebugDesiredCameraProps_FunctionParams
	{
		// Token: 0x04021A49 RID: 137801
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A4A RID: 137802
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200657C RID: 25980
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetSubCameraModifications_FunctionParams
	{
		// Token: 0x04021A4B RID: 137803
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A4C RID: 137804
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200657D RID: 25981
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetControllerModifications_FunctionParams
	{
		// Token: 0x04021A4D RID: 137805
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A4E RID: 137806
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200657E RID: 25982
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 144)]
	protected ref struct __GetCamereModeInfo_FunctionParams
	{
		// Token: 0x04021A4F RID: 137807
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A50 RID: 137808
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x0200657F RID: 25983
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __PlaySettlementCamera_FunctionParams
	{
		// Token: 0x04021A51 RID: 137809
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006580 RID: 25984
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetIsCameraTargetInScreen_FunctionParams
	{
		// Token: 0x04021A52 RID: 137810
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A53 RID: 137811
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x02006581 RID: 25985
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnterSpecialGameplayCamera_FunctionParams
	{
		// Token: 0x04021A54 RID: 137812
		[FieldOffset(0)]
		public int gameplayId;

		// Token: 0x04021A55 RID: 137813
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021A56 RID: 137814
		[FieldOffset(16)]
		public IntPtr __Result;
	}

	// Token: 0x02006582 RID: 25986
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ExitSpecialGameplayCamera_FunctionParams
	{
		// Token: 0x04021A57 RID: 137815
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006583 RID: 25987
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ExitSpecialGameplayCamera2_FunctionParams
	{
		// Token: 0x04021A58 RID: 137816
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006584 RID: 25988
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __SetAimAssistModeByKey_FunctionParams
	{
		// Token: 0x04021A59 RID: 137817
		[FieldOffset(0)]
		public FString key;

		// Token: 0x04021A5A RID: 137818
		[FieldOffset(16)]
		public byte mode;

		// Token: 0x04021A5B RID: 137819
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006585 RID: 25989
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __ClearAimAssistModeByKey_FunctionParams
	{
		// Token: 0x04021A5C RID: 137820
		[FieldOffset(0)]
		public FString key;

		// Token: 0x04021A5D RID: 137821
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006586 RID: 25990
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetSequenceCameraCollisionState_FunctionParams
	{
		// Token: 0x04021A5E RID: 137822
		[FieldOffset(0)]
		public bool bEnable;

		// Token: 0x04021A5F RID: 137823
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006587 RID: 25991
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetXRayState_FunctionParams
	{
		// Token: 0x04021A60 RID: 137824
		[FieldOffset(0)]
		public bool isEnable;

		// Token: 0x04021A61 RID: 137825
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006588 RID: 25992
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __EnableCameraSpecificLockTarget_FunctionParams
	{
		// Token: 0x04021A62 RID: 137826
		[FieldOffset(0)]
		public int entityId;

		// Token: 0x04021A63 RID: 137827
		[FieldOffset(4)]
		public float priority;

		// Token: 0x04021A64 RID: 137828
		[FieldOffset(8)]
		public IntPtr __WorldContext;

		// Token: 0x04021A65 RID: 137829
		[FieldOffset(16)]
		public int __Result;
	}

	// Token: 0x02006589 RID: 25993
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __EnableCameraSpecificLockLocation_FunctionParams
	{
		// Token: 0x04021A66 RID: 137830
		[FieldOffset(0)]
		public FVectorDouble location;

		// Token: 0x04021A67 RID: 137831
		[FieldOffset(24)]
		public float priority;

		// Token: 0x04021A68 RID: 137832
		[FieldOffset(32)]
		public IntPtr __WorldContext;

		// Token: 0x04021A69 RID: 137833
		[FieldOffset(40)]
		public int __Result;
	}

	// Token: 0x0200658A RID: 25994
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DisableCameraSpecificLockOnTarget_FunctionParams
	{
		// Token: 0x04021A6A RID: 137834
		[FieldOffset(0)]
		public int id;

		// Token: 0x04021A6B RID: 137835
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200658B RID: 25995
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __IsCameraSpecificLockEnable_FunctionParams
	{
		// Token: 0x04021A6C RID: 137836
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A6D RID: 137837
		[FieldOffset(8)]
		public bool __Result;
	}

	// Token: 0x0200658C RID: 25996
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetCameraSpecificLockEntityId_FunctionParams
	{
		// Token: 0x04021A6E RID: 137838
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A6F RID: 137839
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x0200658D RID: 25997
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __EnableSoftLockCamera_FunctionParams
	{
		// Token: 0x04021A70 RID: 137840
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A71 RID: 137841
		[FieldOffset(8)]
		public int __Result;
	}

	// Token: 0x0200658E RID: 25998
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __DisableSoftLockCamera_FunctionParams
	{
		// Token: 0x04021A72 RID: 137842
		[FieldOffset(0)]
		public int handle;

		// Token: 0x04021A73 RID: 137843
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200658F RID: 25999
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __SetCameraGravityMode_FunctionParams
	{
		// Token: 0x04021A74 RID: 137844
		[FieldOffset(0)]
		public byte gravityMode;

		// Token: 0x04021A75 RID: 137845
		[FieldOffset(8)]
		public FVectorDouble gravityDirect;

		// Token: 0x04021A76 RID: 137846
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006590 RID: 26000
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __GetCameraGravityMode_FunctionParams
	{
		// Token: 0x04021A77 RID: 137847
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A78 RID: 137848
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02006591 RID: 26001
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCameraGravityDirect_FunctionParams
	{
		// Token: 0x04021A79 RID: 137849
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A7A RID: 137850
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x02006592 RID: 26002
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetCameraGravityUp_FunctionParams
	{
		// Token: 0x04021A7B RID: 137851
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A7C RID: 137852
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x02006593 RID: 26003
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetCameraRotationInGravity_FunctionParams
	{
		// Token: 0x04021A7D RID: 137853
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A7E RID: 137854
		[FieldOffset(8)]
		public FRotator __Result;
	}

	// Token: 0x02006594 RID: 26004
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __GetPlayerLocationInGravity_FunctionParams
	{
		// Token: 0x04021A7F RID: 137855
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A80 RID: 137856
		[FieldOffset(8)]
		public FVectorDouble __Result;
	}

	// Token: 0x02006595 RID: 26005
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __GetPlayerRotatorInGravity_FunctionParams
	{
		// Token: 0x04021A81 RID: 137857
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A82 RID: 137858
		[FieldOffset(8)]
		public FRotator __Result;
	}

	// Token: 0x02006596 RID: 26006
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetUiCameraDebugToolEnabled_FunctionParams
	{
		// Token: 0x04021A83 RID: 137859
		[FieldOffset(0)]
		public bool enabled;

		// Token: 0x04021A84 RID: 137860
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006597 RID: 26007
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchUiCameraDtSync_FunctionParams
	{
		// Token: 0x04021A85 RID: 137861
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x02006598 RID: 26008
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 88)]
	protected ref struct __GetDebugToolUiCameraProps_FunctionParams
	{
		// Token: 0x04021A86 RID: 137862
		[FieldOffset(0)]
		public IntPtr __WorldContext;

		// Token: 0x04021A87 RID: 137863
		[FieldOffset(8)]
		public byte __Result;
	}

	// Token: 0x02006599 RID: 26009
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __SwitchUiCameraArmLengthSync_FunctionParams
	{
		// Token: 0x04021A88 RID: 137864
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200659A RID: 26010
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __OnDebugToolUiCameraArmLengthInputChanged_FunctionParams
	{
		// Token: 0x04021A89 RID: 137865
		[FieldOffset(0)]
		public FString armLengthStr;

		// Token: 0x04021A8A RID: 137866
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200659B RID: 26011
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 48)]
	protected ref struct __InitSeparateCamera_FunctionParams
	{
		// Token: 0x04021A8B RID: 137867
		[FieldOffset(0)]
		public FString cameraName;

		// Token: 0x04021A8C RID: 137868
		[FieldOffset(16)]
		public FVector2D initLocation;

		// Token: 0x04021A8D RID: 137869
		[FieldOffset(24)]
		public FVector2D initSize;

		// Token: 0x04021A8E RID: 137870
		[FieldOffset(32)]
		public bool enableScissorOffset;

		// Token: 0x04021A8F RID: 137871
		[FieldOffset(40)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200659C RID: 26012
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __CreateSequenceSeparateCamera_FunctionParams
	{
		// Token: 0x04021A90 RID: 137872
		[FieldOffset(0)]
		public FName cameraName;

		// Token: 0x04021A91 RID: 137873
		[FieldOffset(12)]
		public FName sequenceCameraTag;

		// Token: 0x04021A92 RID: 137874
		[FieldOffset(24)]
		public byte layout;

		// Token: 0x04021A93 RID: 137875
		[FieldOffset(44)]
		public bool enableSequencePlayerLogic;

		// Token: 0x04021A94 RID: 137876
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x04021A95 RID: 137877
		[FieldOffset(56)]
		public bool __Result;
	}

	// Token: 0x0200659D RID: 26013
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 40)]
	protected ref struct __UpdateSequenceSeparateCamera_FunctionParams
	{
		// Token: 0x04021A96 RID: 137878
		[FieldOffset(0)]
		public FName cameraName;

		// Token: 0x04021A97 RID: 137879
		[FieldOffset(12)]
		public byte layout;

		// Token: 0x04021A98 RID: 137880
		[FieldOffset(32)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200659E RID: 26014
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 24)]
	protected ref struct __DestroySequenceSeparateCamera_FunctionParams
	{
		// Token: 0x04021A99 RID: 137881
		[FieldOffset(0)]
		public FName cameraName;

		// Token: 0x04021A9A RID: 137882
		[FieldOffset(16)]
		public IntPtr __WorldContext;
	}

	// Token: 0x0200659F RID: 26015
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __UpdateSequenceMainCamera_FunctionParams
	{
		// Token: 0x04021A9B RID: 137883
		[FieldOffset(0)]
		public byte layout;

		// Token: 0x04021A9C RID: 137884
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065A0 RID: 26016
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 8)]
	protected ref struct __ResetSequenceMainCamera_FunctionParams
	{
		// Token: 0x04021A9D RID: 137885
		[FieldOffset(0)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065A1 RID: 26017
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __BeginSequenceSeparateCameraEditorPreview_FunctionParams
	{
		// Token: 0x04021A9E RID: 137886
		[FieldOffset(0)]
		public FString ownerId;

		// Token: 0x04021A9F RID: 137887
		[FieldOffset(16)]
		public IntPtr __WorldContext;

		// Token: 0x04021AA0 RID: 137888
		[FieldOffset(24)]
		public bool __Result;
	}

	// Token: 0x020065A2 RID: 26018
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __PrepareSequenceMainCameraEditorPreview_FunctionParams
	{
		// Token: 0x04021AA1 RID: 137889
		[FieldOffset(0)]
		public FString ownerId;

		// Token: 0x04021AA2 RID: 137890
		[FieldOffset(16)]
		public byte layout;

		// Token: 0x04021AA3 RID: 137891
		[FieldOffset(40)]
		public IntPtr __WorldContext;

		// Token: 0x04021AA4 RID: 137892
		[FieldOffset(48)]
		public IntPtr __Result;
	}

	// Token: 0x020065A3 RID: 26019
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	protected ref struct __PrepareSequenceSeparateCameraEditorPreview_FunctionParams
	{
		// Token: 0x04021AA5 RID: 137893
		[FieldOffset(0)]
		public FString ownerId;

		// Token: 0x04021AA6 RID: 137894
		[FieldOffset(16)]
		public FName cameraName;

		// Token: 0x04021AA7 RID: 137895
		[FieldOffset(28)]
		public byte layout;

		// Token: 0x04021AA8 RID: 137896
		[FieldOffset(48)]
		public IntPtr __WorldContext;

		// Token: 0x04021AA9 RID: 137897
		[FieldOffset(56)]
		public IntPtr __Result;
	}

	// Token: 0x020065A4 RID: 26020
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 32)]
	protected ref struct __EndSequenceSeparateCameraEditorPreview_FunctionParams
	{
		// Token: 0x04021AAA RID: 137898
		[FieldOffset(0)]
		public FString ownerId;

		// Token: 0x04021AAB RID: 137899
		[FieldOffset(16)]
		public bool deferCameraModelDestruction;

		// Token: 0x04021AAC RID: 137900
		[FieldOffset(24)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065A5 RID: 26021
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 56)]
	protected ref struct __FadeSeparateCamera_FunctionParams
	{
		// Token: 0x04021AAD RID: 137901
		[FieldOffset(0)]
		public FString cameraName;

		// Token: 0x04021AAE RID: 137902
		[FieldOffset(16)]
		public float fadeTime;

		// Token: 0x04021AAF RID: 137903
		[FieldOffset(20)]
		public FVector2D targetViewLocation;

		// Token: 0x04021AB0 RID: 137904
		[FieldOffset(28)]
		public FVector2D targetViewSize;

		// Token: 0x04021AB1 RID: 137905
		[FieldOffset(36)]
		public bool enableScissorOffset;

		// Token: 0x04021AB2 RID: 137906
		[FieldOffset(40)]
		public IntPtr curve;

		// Token: 0x04021AB3 RID: 137907
		[FieldOffset(48)]
		public IntPtr __WorldContext;
	}

	// Token: 0x020065A6 RID: 26022
	[CompilerFeatureRequired("RefStructs")]
	[StructLayout(LayoutKind.Explicit, Size = 16)]
	protected ref struct __SetOcclusionDitherState_FunctionParams
	{
		// Token: 0x04021AB4 RID: 137908
		[FieldOffset(0)]
		public bool isEnable;

		// Token: 0x04021AB5 RID: 137909
		[FieldOffset(8)]
		public IntPtr __WorldContext;
	}
}
