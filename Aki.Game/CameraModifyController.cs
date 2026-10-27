using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using CSharpScript.Core.Utils.LockingHandler;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200021D RID: 541
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true)]
public class CameraModifyController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x17000503 RID: 1283
	// (get) Token: 0x060020EF RID: 8431 RVA: 0x000B6AC8 File Offset: 0x000B4CC8
	private bool ModifyArmRotation
	{
		get
		{
			return this.ModifyArmRotationPitch || this.ModifyArmRotationYaw || this.ModifyArmRotationRoll;
		}
	}

	// Token: 0x17000504 RID: 1284
	// (get) Token: 0x060020F0 RID: 8432 RVA: 0x000B6AE2 File Offset: 0x000B4CE2
	// (set) Token: 0x060020F1 RID: 8433 RVA: 0x000B6AEA File Offset: 0x000B4CEA
	protected bool IsAiming
	{
		get
		{
			return this.IsAimingInternal;
		}
		set
		{
			if (this.IsAimingInternal == value)
			{
				return;
			}
			this.IsAimingInternal = value;
			if (this.IsAimingInternal)
			{
				base.Lock(this);
				return;
			}
			base.Unlock(this);
		}
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x000B6B14 File Offset: 0x000B4D14
	public CameraModifyController(FightCameraLogicComponent camera) : base(camera)
	{
		this.OnAllMontageInstancesEnded = new Action(this.OnAllMontageInstancesEndedHandler);
		this.OnMontageEnded = new Action<UAnimMontage, bool>(this.OnMontageEndedHandler);
		this.OnMontageStarted = new Action<UAnimMontage>(this.OnMontageStartedHandler);
		this.OnLookAtEntityDead = new Action<int>(this.OnLookAtEntityDeadHandler);
		this.OnVisionMorphEnd = new Action<EntityHandle, EntityHandle>(this.OnVisionMorphEndHandler);
		this.OnPlayCameraLevelSequence = new Action<ULevelSequence, AActor, ALevelSequenceActor, FTransformDouble, bool, bool, string>(this.OnPlayCameraLevelSequenceHandler);
		this.OnCharBeforeUseSkill = new Action<int, int, bool>(this.OnCharBeforeUseSkillHandler);
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x000B6D3D File Offset: 0x000B4F3D
	private void OnAllMontageInstancesEndedHandler()
	{
		if (this.ModifyMontage != null)
		{
			UAnimMontage modifyMontage = this.ModifyMontage;
			UAnimInstance modifyAnimInstance = this.ModifyAnimInstance;
			if (modifyMontage != ((modifyAnimInstance != null) ? modifyAnimInstance.GetCurrentActiveMontage() : null))
			{
				this.EndModify(true, true, null);
			}
		}
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x000B6D6A File Offset: 0x000B4F6A
	[NullableContext(2)]
	private void OnMontageEndedHandler(UAnimMontage montage, bool interrupt)
	{
		if (this.ModifyMontage != null)
		{
			UAnimMontage modifyMontage = this.ModifyMontage;
			UAnimInstance modifyAnimInstance = this.ModifyAnimInstance;
			if (modifyMontage != ((modifyAnimInstance != null) ? modifyAnimInstance.GetCurrentActiveMontage() : null))
			{
				this.EndModify(true, true, null);
			}
		}
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x000B6D97 File Offset: 0x000B4F97
	[NullableContext(2)]
	private void OnMontageStartedHandler(UAnimMontage montage)
	{
		if (this.ModifyMontage != null && this.ModifyMontage != montage)
		{
			this.EndModify(true, true, null);
		}
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
	private void OnLookAtEntityDeadHandler(int id)
	{
		if (!this.LookAtActor.HasValue)
		{
			return;
		}
		if (id != (this.LookAtActor.IsT1 ? this.LookAtActor.AsT1.EntityId : this.LookAtActor.AsT2.EntityId))
		{
			return;
		}
		this.EndModify(true, false, null);
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000B6E0B File Offset: 0x000B500B
	[NullableContext(2)]
	private void OnVisionMorphEndHandler(EntityHandle roleEntityHandle, EntityHandle visionEntityHandle)
	{
		if (visionEntityHandle == null || !visionEntityHandle.Valid || visionEntityHandle.Entity != this.LookAtEntity)
		{
			return;
		}
		this.EndModify(true, true, null);
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x000B6E38 File Offset: 0x000B5038
	private void OnPlayCameraLevelSequenceHandler(ULevelSequence levelSequence, AActor role, ALevelSequenceActor sequenceActor, FTransformDouble startTrans, bool playResult, bool isStopModify, string cameraName)
	{
		CameraModelInstance cameraModel = base.CameraModel;
		if (cameraName != ((cameraModel != null) ? cameraModel.CameraName : null))
		{
			return;
		}
		if (!playResult || !isStopModify)
		{
			return;
		}
		if (this.IsModified && this.AnimOwner.HasValue && (this.AnimOwner.IsT1 ? this.AnimOwner.AsT1.IsValid() : this.AnimOwner.AsT2.IsValid()) && CameraUtility.CheckFormationControlState(CharacterModel.Instance.GetHandle(this.AnimOwner.IsT1 ? this.AnimOwner.AsT1.EntityId : this.AnimOwner.AsT2.EntityId), true, false))
		{
			this.EndModify(true, true, null);
		}
		this.EndModifyFadeOut(true);
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000B6F08 File Offset: 0x000B5108
	private void OnCharBeforeUseSkillHandler(int entityId, int skillId, bool isAutonomousProxy)
	{
		if (!isAutonomousProxy)
		{
			return;
		}
		if (!this.IsModified)
		{
			return;
		}
		foreach (ResetFinalArmLengthToDynamicValueData resetFinalArmLengthToDynamicValueData in this.ModifySettings.ResetFinalArmLengthToDynamicValueList)
		{
			if (resetFinalArmLengthToDynamicValueData.ArmLengthDynamicValueType == ECameraModifier_Settings_ArmLengthDynamicValueType.技能Id && resetFinalArmLengthToDynamicValueData.SkillId == skillId)
			{
				this.ModifyEndContext.Clear();
				this.ModifyEndContext.ArmLengthDynamicValueType = ECameraModifier_Settings_ArmLengthDynamicValueType.技能Id;
				this.ModifyEndContext.SkillId = skillId;
				this.EndModify(true, true, this.ModifyEndContext);
				break;
			}
		}
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000B6FAC File Offset: 0x000B51AC
	public override string Name()
	{
		return "ModifyController";
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x000B6FB4 File Offset: 0x000B51B4
	protected override void OnInit()
	{
		base.SetConfigMap(EFightCameraModify.臂长还原过渡速度, "ModifyArmLengthLagSpeed");
		base.SetConfigMap(EFightCameraModify.臂偏移还原过渡速度, "ModifyCameraOffsetLagSpeed");
		base.SetConfigMap(EFightCameraModify.旋转还原过渡速度, "ModifyArmRotationLagSpeed");
		base.SetConfigMap(EFightCameraModify.Fov还原过渡速度, "ModifyFovLagSpeed");
		base.SetConfigMap(EFightCameraModify.臂偏移原点还原过渡速度, "ModifyArmOffsetLagSpeed");
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x000B7016 File Offset: 0x000B5216
	protected override void OnDisable()
	{
		if (this.IsModified)
		{
			this.EndModify(true, false, null);
		}
		if (this.IsModifyFadeOut)
		{
			this.EndModifyFadeOut(false);
		}
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x000B7038 File Offset: 0x000B5238
	protected override void UpdateInternal(float deltaTime)
	{
		this.IsAiming = this.Camera.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.方向状态.瞄准方向"], false);
		if (this.IsAiming)
		{
			return;
		}
		this.UpdateModifyFadeOut(deltaTime);
		this.UpdateModifiers(deltaTime);
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x000B7072 File Offset: 0x000B5272
	protected override void UpdateDeactivateInternal(float deltaTime)
	{
		this.IsAiming = this.Camera.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.方向状态.瞄准方向"], false);
		if (this.IsAiming)
		{
			return;
		}
		this.UpdateModifyFadeOut(deltaTime);
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x000B70A5 File Offset: 0x000B52A5
	protected override void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
		CameraModify modifySettings = this.ModifySettings;
		if (modifySettings != null && modifySettings.IsSwitchModifier)
		{
			return;
		}
		this.EndModify(true, true, null);
	}

	// Token: 0x17000505 RID: 1285
	// (get) Token: 0x06002100 RID: 8448 RVA: 0x000B70C5 File Offset: 0x000B52C5
	public override bool IsActivate
	{
		get
		{
			if (!base.IsActivate)
			{
				CameraModify modifySettings = this.ModifySettings;
				return modifySettings != null && modifySettings.IsForcePlayModify && !this.Camera.ContainsTag(CameraModifyController.BanForcePlayModify, false);
			}
			return true;
		}
	}

	// Token: 0x17000506 RID: 1286
	// (get) Token: 0x06002101 RID: 8449 RVA: 0x000B70FB File Offset: 0x000B52FB
	public bool IsModified
	{
		get
		{
			return this.ModifySettings != null;
		}
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000B7108 File Offset: 0x000B5308
	public unsafe int ApplyCameraModify(FGameplayTag? tag, float duration, float blendInTime, float blendOutTime, float breakBlendOutTime, SCameraModifier_Settings settings, [Nullable(2)] UAnimSequenceBase anim, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<CurveBase, SBaseCurve> blendInCurve, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<CurveBase, SBaseCurve> blendOutCurve, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<TsBaseCharacter, TsBaseVehicle> newLookAtActor, string lookAtActorSocket, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<TsBaseCharacter, TsBaseVehicle> animOwner)
	{
		if (!base.IsActivate && (!settings.IsForcePlayModify || this.Camera.ContainsTag(CameraModifyController.BanForcePlayModify, false)))
		{
			return -1;
		}
		if (this.IsCameraModifyLocked())
		{
			return -1;
		}
		if (tag != null && tag.Value.TagName != FName.NAME_None && !this.Camera.ContainsTag(tag.Value.TagId(), false))
		{
			return -1;
		}
		if (settings.Priority < this.Priority)
		{
			return -1;
		}
		this.ModifyInstance++;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "ApplyCameraModify";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", (tag != null) ? new FName?(tag.GetValueOrDefault().TagName) : null);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("montage", anim);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ArmLengthAddition", settings.CameraOffsetAdditional);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ModifyInstance", this.ModifyInstance);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		bool flag = this.IsModified || this.IsModifyFadeOut;
		if (this.IsDebugCurveEval && flag)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Camera;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[CurveEval][Interrupt] 新 Modify 打断旧 Modify";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
			string item = "prevModifyName";
			CameraModify modifySettings = this.ModifySettings;
			ptr = new ValueTuple<string, object>(item, ((modifySettings != null) ? modifySettings.Name : null) ?? "FadeOut");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("newModifyName", settings.ModifySettingsAdditional.Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("isModified", this.IsModified);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("isModifyFadeOut", this.IsModifyFadeOut);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		}
		bool flag2;
		if (this.IsModified)
		{
			if (!this.ModifyArmLength)
			{
				CameraModify modifySettings2 = this.ModifySettings;
				flag2 = (modifySettings2 != null && modifySettings2.IsModifiedArmLength);
			}
			else
			{
				flag2 = true;
			}
		}
		else
		{
			flag2 = false;
		}
		bool flag3 = flag2;
		bool flag4;
		if (this.IsModified)
		{
			if (!this.ModifyArmOffset)
			{
				CameraModify modifySettings3 = this.ModifySettings;
				flag4 = (modifySettings3 != null && modifySettings3.IsModifiedArmOffset);
			}
			else
			{
				flag4 = true;
			}
		}
		else
		{
			flag4 = false;
		}
		bool modifyArmOffset = flag4;
		bool isBreakPreviousPlayerLocationModify = flag && this.ModifyPlayerLocation;
		bool flag5;
		if (this.IsModified)
		{
			if (!this.ModifyFov)
			{
				CameraModify modifySettings4 = this.ModifySettings;
				flag5 = (modifySettings4 != null && modifySettings4.IsModifiedCameraFov);
			}
			else
			{
				flag5 = true;
			}
		}
		else
		{
			flag5 = false;
		}
		bool flag6 = flag5;
		bool flag7;
		if (this.IsModified)
		{
			if (!this.ModifyCameraOffset)
			{
				CameraModify modifySettings5 = this.ModifySettings;
				flag7 = (modifySettings5 != null && modifySettings5.IsModifiedCameraOffset);
			}
			else
			{
				flag7 = true;
			}
		}
		else
		{
			flag7 = false;
		}
		bool flag8 = flag7;
		this.EndModify(!flag, false, null);
		this.IsBreakPreviousPlayerLocationModify = isBreakPreviousPlayerLocationModify;
		this.Priority = settings.Priority;
		if (tag != null && tag.Value.TagName != FName.NAME_None)
		{
			this.ModifyTag = tag;
		}
		this.Camera.CameraAdjustController.Lock(this);
		this.Camera.CameraGuideController.Lock(this);
		this.Camera.CopyVirtualCamera(this.StartVirtualCamera, this.Camera.CurrentCamera, false);
		if (!flag)
		{
			this.Camera.CopyVirtualCamera(this.FirstStartVirtualCamera, this.StartVirtualCamera, false);
		}
		this.ModifyDuration = duration;
		this.ModifyBlendInTime = blendInTime;
		this.ModifyBlendOutTime = blendOutTime;
		this.ModifyFadeOutTime = breakBlendOutTime;
		this.ModifyBlendInCurve = (blendInCurve.IsT1 ? blendInCurve.AsT1 : CurveUtils.CreateCurveByStruct(blendInCurve.IsT2 ? blendInCurve.AsT2 : null));
		this.ModifyBlendOutCurve = (blendOutCurve.IsT1 ? blendOutCurve.AsT1 : CurveUtils.CreateCurveByStruct(blendOutCurve.IsT2 ? blendOutCurve.AsT2 : null));
		this.ModifyElapsedTime = 0f;
		this.ModifySettings = new CameraModify(settings);
		this.Camera.SetSuppressClearRoll(ESuppressClearRollFlag.CameraModify);
		this.ModifyAnimSequence = anim;
		this.AnimOwner = animOwner;
		if (this.ModifySettings.StopModifyOnMontageEnd)
		{
			UAnimMontage uanimMontage = anim as UAnimMontage;
			if (uanimMontage != null)
			{
				this.ModifyMontage = uanimMontage;
				this.ModifyAnimInstance = this.GetModifyAnimInstance(newLookAtActor, animOwner);
				UAnimInstance modifyAnimInstance = this.ModifyAnimInstance;
				if (modifyAnimInstance != null)
				{
					modifyAnimInstance.OnMontageStarted.Add(this.OnMontageStarted);
				}
				UAnimInstance modifyAnimInstance2 = this.ModifyAnimInstance;
				if (modifyAnimInstance2 != null)
				{
					modifyAnimInstance2.OnMontageEnded.Add(this.OnMontageEnded);
				}
				UAnimInstance modifyAnimInstance3 = this.ModifyAnimInstance;
				if (modifyAnimInstance3 != null)
				{
					modifyAnimInstance3.OnAllMontageInstancesEnded.Add(this.OnAllMontageInstancesEnded);
				}
			}
		}
		this.ModifyArmLength = (flag3 || !MathUtils.Instance.IsNearlyEqual((double)this.ModifySettings.ArmLengthAdditional, 0.0, null));
		this.ModifyArmOffset = modifyArmOffset;
		this.ModifyCameraOffset = (flag8 || !this.ModifySettings.CameraOffsetAdditional.IsNearlyZero(0.0001));
		this.ModifyArmRotationPitch = !MathUtils.Instance.IsNearlyZero((double)this.ModifySettings.ArmRotationAdditional.Pitch, new double?(0.0001));
		this.ModifyArmRotationYaw = !MathUtils.Instance.IsNearlyZero((double)this.ModifySettings.ArmRotationAdditional.Yaw, new double?(0.0001));
		this.ModifyArmRotationRoll = !MathUtils.Instance.IsNearlyZero((double)this.ModifySettings.ArmRotationAdditional.Roll, new double?(0.0001));
		this.ModifyPlayerLocation = newLookAtActor.HasValue;
		this.LookAtActor = newLookAtActor;
		this.LookAtEntity = (newLookAtActor.HasValue ? (newLookAtActor.IsT1 ? newLookAtActor.AsT1.GetEntityNoBlueprint() : newLookAtActor.AsT2.GetEntityNoBlueprint()) : null);
		this.LookAtActorSocket = lookAtActorSocket;
		if (this.ModifyPlayerLocation)
		{
			EventSystem.Instance.Add<int>(EEventName.CharOnRoleDead, this.OnLookAtEntityDead);
		}
		Entity lookAtEntity = this.LookAtEntity;
		if (lookAtEntity != null && lookAtEntity.Valid && this.LookAtEntityIsVision())
		{
			EventSystem.Instance.AddWithTarget<EntityHandle, EntityHandle>(this.LookAtEntity, EEventName.VisionMorphEnd, this.OnVisionMorphEnd);
		}
		this.StartAutoCameraArmLengthAddition = this.Camera.CameraAutoController.CurrentAutoCameraArmLengthAddition;
		this.StartAutoCameraArmOffset.DeepCopy(this.Camera.CameraAutoController.CurrentAutoCameraArmOffset);
		this.ModifyFov = (flag6 || this.ModifySettings.IsModifiedCameraFov);
		this.ModifyLens = this.ModifySettings.IsModifiedCameraLens;
		if (this.ModifySettings.OverrideCameraInput)
		{
			if (this.ModifyArmRotationPitch || (this.ModifySettings.IsModifiedArmRotation && this.ModifySettings.IsModifiedArmRotationPitch))
			{
				this.Camera.CameraInputController.LockArmRotationPitch(this);
			}
			if (this.ModifyArmRotationYaw || (this.ModifySettings.IsModifiedArmRotation && this.ModifySettings.IsModifiedArmRotationYaw))
			{
				this.Camera.CameraInputController.LockArmRotationYaw(this);
			}
			if (this.ModifyArmLength || this.ModifySettings.IsModifiedArmLength)
			{
				this.Camera.CameraInputController.LockArmLength(this);
			}
		}
		if (this.ModifySettings.IsLockInput)
		{
			this.Camera.CameraInputController.Lock(this);
		}
		if (this.ModifyArmRotation || this.ModifySettings.IsModifiedArmRotation)
		{
			this.Camera.CameraInputController.ResetCameraInput();
		}
		this.MaxAngleFixQuat.Reset();
		this.FirstModifyArmRotationPitch = true;
		this.FirstModifyArmRotationYaw = true;
		this.FirstModifyArmRotationRoll = true;
		this.BlendOutData.Reset();
		if (!EventSystem.Instance.Has<ULevelSequence, AActor, ALevelSequenceActor, FTransformDouble, bool, bool, string>(EEventName.PlayCameraLevelSequence, this.OnPlayCameraLevelSequence))
		{
			EventSystem.Instance.Add<ULevelSequence, AActor, ALevelSequenceActor, FTransformDouble, bool, bool, string>(EEventName.PlayCameraLevelSequence, this.OnPlayCameraLevelSequence);
		}
		if (!EventSystem.Instance.Has<int, int, bool>(EEventName.CharBeforeSkill, this.OnCharBeforeUseSkill))
		{
			EventSystem.Instance.Add<int, int, bool>(EEventName.CharBeforeSkill, this.OnCharBeforeUseSkill);
		}
		return this.ModifyInstance;
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x000B7930 File Offset: 0x000B5B30
	private void UpdateModifiers(float deltaSeconds)
	{
		if (!this.IsModified)
		{
			return;
		}
		this.ModifyElapsedTime += deltaSeconds;
		if (this.ModifyTag != null && !this.IsModifyBlendingOut)
		{
			if (this.Camera.ContainsTag(this.ModifyTag.Value.TagId(), false))
			{
				if (this.ModifyElapsedTime > this.ModifyBlendInTime)
				{
					this.ModifyElapsedTime = this.ModifyBlendInTime;
				}
			}
			else if (this.ModifyElapsedTime < this.ModifyBlendInTime + this.ModifyDuration)
			{
				this.EndModify(true, true, null);
				return;
			}
		}
		float blendInTimeRatio = 0f;
		EBlendState? eblendState;
		float num;
		float num2;
		if (this.ModifyElapsedTime < this.ModifyBlendInTime)
		{
			eblendState = new EBlendState?(EBlendState.BlendIn);
			blendInTimeRatio = this.ModifyElapsedTime / this.ModifyBlendInTime;
			num = ((this.ModifyBlendInTime > 0f) ? this.ModifyBlendInCurve.GetCurrentValue(this.ModifyElapsedTime / this.ModifyBlendInTime) : 1f);
			num2 = ((this.ModifyBlendInTime > 0f) ? this.ModifyBlendInCurve.GetOffsetRate((this.ModifyElapsedTime - deltaSeconds) / this.ModifyBlendInTime, deltaSeconds / this.ModifyBlendInTime) : 1f);
		}
		else if (this.ModifyElapsedTime < this.ModifyBlendInTime + this.ModifyDuration)
		{
			eblendState = new EBlendState?(EBlendState.Loop);
			num = 1f;
			num2 = 1f;
		}
		else
		{
			eblendState = new EBlendState?(EBlendState.BlendOut);
			float num3 = this.ModifyElapsedTime - this.ModifyBlendInTime - this.ModifyDuration;
			num = ((this.ModifyBlendOutTime > 0f) ? this.ModifyBlendOutCurve.GetCurrentValue(num3 / this.ModifyBlendOutTime) : 1f);
			num2 = ((this.ModifyBlendOutTime > 0f) ? this.ModifyBlendOutCurve.GetOffsetRate((num3 - deltaSeconds) / this.ModifyBlendOutTime, deltaSeconds / this.ModifyBlendOutTime) : 1f);
			this.Priority = 0;
		}
		this.CurrentBlendState = eblendState.Value;
		this.UpdateHasInput();
		this.UpdatePlayerLocationModifier(eblendState.Value, num, num2);
		this.UpdateArmLocationModifier(eblendState.Value, num, num2);
		this.UpdateArmLengthModifier(eblendState.Value, num, blendInTimeRatio);
		this.UpdateArmOffsetModifier(eblendState.Value, num, blendInTimeRatio);
		this.UpdateCameraOffsetModifier(eblendState.Value, num, blendInTimeRatio);
		this.UpdateArmRotationModifier(eblendState.Value, num, blendInTimeRatio);
		this.UpdateFovModifier(eblendState.Value, num, blendInTimeRatio);
		this.UpdateLensModifier(eblendState.Value, num, blendInTimeRatio);
		if (this.ModifyElapsedTime > this.ModifyBlendInTime + this.ModifyDuration + this.ModifyBlendOutTime)
		{
			this.EndModify(true, false, null);
			return;
		}
		if (this.ModifySettings.StopModifyOnZoomInput && (this.ModifyArmLength || this.ModifySettings.IsModifiedArmLength) && this.HasZoomInput())
		{
			this.EndModify(true, true, null);
		}
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x000B7BE8 File Offset: 0x000B5DE8
	private void UpdatePlayerLocationModifier(EBlendState state, float alpha, float _)
	{
		if (!this.ModifyPlayerLocation)
		{
			return;
		}
		USkeletalMeshComponent uskeletalMeshComponent = this.LookAtActor.HasValue ? (this.LookAtActor.IsT1 ? this.LookAtActor.AsT1.Mesh : this.LookAtActor.AsT2.Mesh) : null;
		if (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid())
		{
			this.EndModify(true, false, null);
			return;
		}
		Vector targetLocation = this.TargetLocation;
		FVectorDouble fvectorDouble = uskeletalMeshComponent.D_GetSocketLocation(FNameUtil.GetDynamicFName(this.LookAtActorSocket) ?? FName.NAME_None);
		targetLocation.FromUeVector(fvectorDouble);
		switch (state)
		{
		case EBlendState.BlendIn:
			this.TmpVector.DeepCopy(this.IsBreakPreviousPlayerLocationModify ? this.TmpPlayerLocation : this.Camera.PlayerLocation);
			Vector.Lerp(this.TmpVector, this.TargetLocation, (double)alpha, this.Camera.PlayerLocation);
			this.TmpPlayerLocation.DeepCopy(this.Camera.PlayerLocation);
			this.ModifyPlayerLocation = true;
			return;
		case EBlendState.Loop:
			this.Camera.PlayerLocation.DeepCopy(this.TargetLocation);
			this.TmpPlayerLocation.DeepCopy(this.Camera.PlayerLocation);
			this.ModifyPlayerLocation = true;
			return;
		case EBlendState.BlendOut:
			Vector.Lerp(this.TmpPlayerLocation, this.Camera.PlayerLocation, (double)alpha, this.Camera.PlayerLocation);
			this.TmpPlayerLocation.DeepCopy(this.Camera.PlayerLocation);
			this.ModifyPlayerLocation = true;
			return;
		default:
			this.ModifyPlayerLocation = false;
			return;
		}
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000B7D84 File Offset: 0x000B5F84
	private void UpdateArmLocationModifier(EBlendState state, float _, float alphaOffsetRate)
	{
		if (!this.ModifySettings.IsLerpArmLocation)
		{
			return;
		}
		if (state != EBlendState.BlendIn)
		{
			if (state != EBlendState.BlendOut)
			{
				this.Camera.DesiredCamera.ArmLocation.DeepCopy(this.Camera.PlayerLocation);
				this.Camera.CameraAutoController.CurrentAutoCameraArmOffset.Set(0.0, 0.0, 0.0);
			}
			else
			{
				Vector.Lerp(this.Camera.CurrentCamera.ArmLocation, this.Camera.TmpArmLocation, (double)alphaOffsetRate, this.Camera.DesiredCamera.ArmLocation);
				Vector.Lerp(Vector.Create(0.0, 0.0, 0.0), this.StartAutoCameraArmOffset, (double)alphaOffsetRate, this.Camera.CameraAutoController.CurrentAutoCameraArmOffset);
			}
		}
		else
		{
			Vector.Lerp(this.Camera.CurrentCamera.ArmLocation, this.Camera.PlayerLocation, (double)alphaOffsetRate, this.Camera.DesiredCamera.ArmLocation);
			Vector.Lerp(this.StartAutoCameraArmOffset, Vector.Create(0.0, 0.0, 0.0), (double)alphaOffsetRate, this.Camera.CameraAutoController.CurrentAutoCameraArmOffset);
		}
		this.Camera.IsModifiedArmLocation = true;
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x000B7EF0 File Offset: 0x000B60F0
	private unsafe void UpdateArmLengthModifier(EBlendState state, float alpha, float blendInTimeRatio)
	{
		if (!this.ModifySettings.IsModifiedArmLength && !this.ModifyArmLength)
		{
			return;
		}
		float num = alpha;
		float armLengthWithSetting = this.Camera.GetArmLengthWithSetting(this.Camera.CurrentCamera);
		float num2;
		if (this.ModifySettings.IsModifiedArmLength)
		{
			num2 = this.ModifySettings.ArmLength / armLengthWithSetting;
		}
		else
		{
			num2 = this.Camera.GetArmLengthWithSettingAndZoom(this.FirstStartVirtualCamera, true) / armLengthWithSetting;
		}
		if (this.ModifyArmLength)
		{
			num2 += this.ModifySettings.ArmLengthAdditional / armLengthWithSetting;
			num2 = Math.Max(num2, this.Camera.CurrentCamera.MinArmLength / armLengthWithSetting);
		}
		switch (state)
		{
		case EBlendState.BlendIn:
			if (this.ModifySettings.IsUseArmLengthFloatCurve)
			{
				num = this.ModifySettings.ArmLengthFloatCurve.GetCurrentValue(blendInTimeRatio);
			}
			this.Camera.DesiredCamera.ZoomModifier = MathUtils.Instance.Lerp(this.StartVirtualCamera.ZoomModifier, num2, num);
			if (this.ModifySettings.IsModifiedArmLength)
			{
				this.Camera.CameraAutoController.CurrentAutoCameraArmLengthAddition = MathUtils.Instance.Lerp(this.StartAutoCameraArmLengthAddition, 0f, num);
			}
			break;
		case EBlendState.Loop:
			this.Camera.DesiredCamera.ZoomModifier = num2;
			if (this.ModifySettings.IsModifiedArmLength)
			{
				this.Camera.CameraAutoController.CurrentAutoCameraArmLengthAddition = 0f;
			}
			break;
		case EBlendState.BlendOut:
			this.Camera.DesiredCamera.ZoomModifier = MathUtils.Instance.Lerp(num2, MathUtils.Instance.Clamp(this.GetFinalZoomModifierArmLength(null), this.Camera.CurrentCamera.MinArmLength, this.Camera.CurrentCamera.MaxArmLength) / this.Camera.GetArmLengthWithSetting(this.Camera.CurrentCamera), alpha);
			if (this.ModifySettings.IsModifiedArmLength)
			{
				this.Camera.CameraAutoController.CurrentAutoCameraArmLengthAddition = MathUtils.Instance.Lerp(0f, this.StartAutoCameraArmLengthAddition, alpha);
			}
			break;
		}
		this.Camera.IsModifiedArmLength = true;
		this.Camera.IsModifiedZoomModifier = true;
		if ((double)this.Camera.DesiredCamera.ZoomModifier <= 1E-08 && this.EnableDebugModifyZoomModifier)
		{
			this.EnableDebugModifyZoomModifier = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "[DebugZoomModifier UpdateArmLengthModifier]";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", state);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DesiredCamera.ZoomModifier", this.Camera.DesiredCamera.ZoomModifier);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("this.StartVirtualCamera.ZoomModifier", this.StartVirtualCamera.ZoomModifier);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("targetZoomModifier", num2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ratio", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Anim", this.ModifyAnimSequence);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("CameraConfigTags", this.Camera.CameraConfigController.GetCameraConfigTagsContent());
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
		}
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x000B8258 File Offset: 0x000B6458
	private void UpdateArmOffsetModifier(EBlendState state, float alpha, float blendInTimeRatio)
	{
		if (!this.ModifySettings.IsModifiedArmOffset && !this.ModifyArmOffset)
		{
			return;
		}
		this.TmpTargetArmOffset.DeepCopy(this.ModifySettings.ArmOffset);
		float num = alpha;
		switch (state)
		{
		case EBlendState.BlendIn:
			if (this.ModifySettings.IsUseArmOffsetFloatCurve)
			{
				num = this.ModifySettings.ArmOffsetFloatCurve.GetCurrentValue(blendInTimeRatio);
			}
			Vector.Lerp(this.StartVirtualCamera.ArmOffset, this.TmpTargetArmOffset, (double)num, this.Camera.DesiredCamera.ArmOffset);
			break;
		case EBlendState.Loop:
			this.Camera.DesiredCamera.ArmOffset.DeepCopy(this.TmpTargetArmOffset);
			break;
		case EBlendState.BlendOut:
		{
			Vector to = Vector.Create((double)this.Camera.ArmOffsetX, (double)this.Camera.ArmOffsetY, (double)this.Camera.ArmOffsetZ);
			Vector.Lerp(this.TmpTargetArmOffset, to, (double)num, this.Camera.DesiredCamera.ArmOffset);
			break;
		}
		}
		this.Camera.IsModifiedCameraOffset = true;
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000B8368 File Offset: 0x000B6568
	private unsafe void UpdateCameraOffsetModifier(EBlendState state, float alpha, float blendInTimeRatio)
	{
		if (!this.ModifySettings.IsModifiedCameraOffset && !this.ModifyCameraOffset)
		{
			return;
		}
		Vector vector = Vector.Create();
		if (this.ModifySettings.IsModifiedCameraOffset)
		{
			FVector value = this.ModifySettings.CameraOffsetEval.GetValue(this.ModifyElapsedTime);
			float num = this.ModifySettings.IsModifiedCameraOffsetX ? value.X : this.Camera.CameraOffsetX;
			float num2 = this.ModifySettings.IsModifiedCameraOffsetY ? value.Y : this.Camera.CameraOffsetY;
			float num3 = this.ModifySettings.IsModifiedCameraOffsetZ ? value.Z : this.Camera.CameraOffsetZ;
			vector.Set((double)num, (double)num2, (double)num3);
		}
		else
		{
			vector.X = (double)this.Camera.CameraOffsetX;
			vector.Y = (double)this.Camera.CameraOffsetY;
			vector.Z = (double)this.Camera.CameraOffsetZ;
		}
		if (this.ModifyCameraOffset)
		{
			FVector value2 = this.ModifySettings.CameraOffsetAdditionalEval.GetValue(this.ModifyElapsedTime);
			vector.X += (double)value2.X;
			vector.Y += (double)value2.Y;
			vector.Z += (double)value2.Z;
		}
		if (this.IsDebugCurveEval)
		{
			Vector cameraOffset = this.Camera.DesiredCamera.CameraOffset;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[CurveEval][CameraOffset]";
			<>y__InlineArray9<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray9<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("state", state);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("t", this.ModifyElapsedTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("alpha", alpha);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("targetX", vector.X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("targetY", vector.Y);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("targetZ", vector.Z);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("desiredX", cameraOffset.X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 7) = new ValueTuple<string, object>("desiredY", cameraOffset.Y);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 8) = new ValueTuple<string, object>("desiredZ", cameraOffset.Z);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray9<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 9));
		}
		float num4 = alpha;
		switch (state)
		{
		case EBlendState.BlendIn:
			if (this.ModifySettings.IsUseCameraOffsetFloatCurve)
			{
				num4 = this.ModifySettings.CameraOffsetFloatCurve.GetCurrentValue(blendInTimeRatio);
			}
			Vector.Lerp(this.StartVirtualCamera.CameraOffset, vector, (double)num4, this.Camera.DesiredCamera.CameraOffset);
			break;
		case EBlendState.Loop:
			this.Camera.DesiredCamera.CameraOffset.DeepCopy(vector);
			break;
		case EBlendState.BlendOut:
		{
			this.BlendOutData.SetBlendOutCameraOffset(vector);
			Vector to = Vector.Create((double)this.Camera.CameraOffsetX, (double)this.Camera.CameraOffsetY, (double)this.Camera.CameraOffsetZ);
			Vector.Lerp(this.BlendOutData.CameraOffset, to, (double)num4, this.Camera.DesiredCamera.CameraOffset);
			break;
		}
		}
		this.Camera.IsModifiedCameraOffset = true;
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x000B8710 File Offset: 0x000B6910
	private void UpdateArmRotationModifier(EBlendState state, float alpha, float blendInTimeRatio)
	{
		this.TempTargetArmRotator.FromUeRotator(this.Camera.PlayerRotator);
		if (this.ModifyPlayerLocation && this.LookAtActor.HasValue)
		{
			OneOf<TsBaseCharacter, TsBaseVehicle> lookAtActor = this.LookAtActor;
			if (lookAtActor.IsT1)
			{
				TsBaseCharacter asT = lookAtActor.AsT1;
				if (asT != null)
				{
					CharacterActorComponent characterActorComponent = asT.CharacterActorComponent;
					if (characterActorComponent != null && characterActorComponent.Valid)
					{
						this.TempTargetArmRotator.FromUeRotator(this.LookAtActor.AsT1.CharacterActorComponent.ActorRotationProxy);
						goto IL_D0;
					}
				}
			}
			lookAtActor = this.LookAtActor;
			if (lookAtActor.IsT2)
			{
				TsBaseVehicle asT2 = lookAtActor.AsT2;
				if (asT2 != null)
				{
					VehicleActorComponent vehicleActorComponent = asT2.VehicleActorComponent;
					if (vehicleActorComponent != null && vehicleActorComponent.Valid)
					{
						this.TempTargetArmRotator.FromUeRotator(this.LookAtActor.AsT2.VehicleActorComponent.ActorRotationProxy);
					}
				}
			}
		}
		IL_D0:
		if (this.Camera.IsInNormalGravityMode())
		{
			this.TmpFinalRotator.DeepCopy(this.GetFinalArmRotation());
		}
		else
		{
			this.TmpFinalRotator.DeepCopy(this.GetFinalArmQuaternion());
		}
		this.TempTargetArmRotator.Quaternion(this.TmpQuat);
		this.Camera.GravityInverseQuat.Multiply(this.TmpQuat, this.TmpQuat2);
		this.TmpQuat2.Rotator(this.TmpRotator);
		this.TempTargetArmRotator.DeepCopy(this.TmpRotator);
		GravityUtils.Instance.GetRotatorInGravity(this.TmpFinalRotator, this.Camera.GravityInverseQuat, this.TmpFinalRotatorInGravity);
		this.UpdateArmRotationPitchModifier(state, alpha, blendInTimeRatio, this.TempTargetArmRotator.Pitch, this.TmpFinalRotatorInGravity.Pitch);
		this.UpdateArmRotationYawModifier(state, alpha, blendInTimeRatio, this.TempTargetArmRotator.Yaw, this.TmpFinalRotatorInGravity.Yaw);
		this.UpdateArmRotationRollModifier(state, alpha, blendInTimeRatio, this.TempTargetArmRotator.Roll, this.TmpFinalRotatorInGravity.Roll);
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000B88F0 File Offset: 0x000B6AF0
	private void UpdateArmRotationPitchModifier(EBlendState state, float alpha, float blendIntTimeRatio, float tempTargetArmRotatorPitch, float finalPitch)
	{
		if (this.Camera.IsModifiedArmRotationPitch || ((!this.ModifySettings.IsModifiedArmRotation || !this.ModifySettings.IsModifiedArmRotationPitch) && !this.ModifyArmRotationPitch) || (!this.ModifySettings.IsLockInput && this.HasInput))
		{
			return;
		}
		if (this.Camera.IsInNormalGravityMode())
		{
			this.TargetArmRotatorPitch = this.StartVirtualCamera.ArmRotation.Pitch;
		}
		else
		{
			this.TargetArmRotatorPitch = GravityUtils.Instance.GetRotatorInGravity(this.StartVirtualCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Pitch;
		}
		this.PreparePitchTarget(tempTargetArmRotatorPitch);
		if (this.ModifyArmRotationPitch)
		{
			this.TargetArmRotatorPitch += this.GetTargetRotatorAdditional(ECameraRotationAxis.Pitch);
		}
		this.Camera.IsModifiedArmRotationPitch = (this.ModifySettings.IsModifiedArmRotationPitch || this.ModifyArmRotationPitch);
		float alpha2 = alpha;
		this.TmpRotator.DeepCopy(this.Camera.DesiredCamera.ArmRotation);
		this.TmpRotator.Quaternion(this.TmpQuat);
		switch (state)
		{
		case EBlendState.BlendIn:
		{
			if (this.ModifySettings.IsUseArmRotationFloatCurve)
			{
				alpha2 = this.ModifySettings.ArmRotationFloatCurve.GetCurrentValue(blendIntTimeRatio);
			}
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Pitch = Rotator.AxisLerp(this.StartVirtualCamera.ArmRotation.Pitch, this.TargetArmRotatorPitch, alpha2);
				return;
			}
			float pitch = GravityUtils.Instance.GetRotatorInGravity(this.StartVirtualCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Pitch;
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Pitch = Rotator.AxisLerp(pitch, this.TargetArmRotatorPitch, alpha2);
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		}
		case EBlendState.Loop:
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Pitch = this.TargetArmRotatorPitch;
				return;
			}
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Pitch = this.TargetArmRotatorPitch;
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		case EBlendState.BlendOut:
			this.BlendOutData.SetBlendOutArmRotationPitch(this.TargetArmRotatorPitch);
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Pitch = Rotator.AxisLerp(this.BlendOutData.ArmRotationPitch, finalPitch, alpha2);
				return;
			}
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Pitch = Rotator.AxisLerp(this.BlendOutData.ArmRotationPitch, finalPitch, alpha2);
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600210B RID: 8459 RVA: 0x000B8C6C File Offset: 0x000B6E6C
	private void UpdateArmRotationYawModifier(EBlendState state, float alpha, float blendIntTimeRatio, float tempTargetArmRotatorYaw, float finalYaw)
	{
		if (this.Camera.IsModifiedArmRotationYaw || ((!this.ModifySettings.IsModifiedArmRotation || !this.ModifySettings.IsModifiedArmRotationYaw) && !this.ModifyArmRotationYaw) || (!this.ModifySettings.IsLockInput && this.HasInput))
		{
			return;
		}
		if (this.Camera.IsInNormalGravityMode())
		{
			this.TargetArmRotatorYaw = this.StartVirtualCamera.ArmRotation.Yaw;
		}
		else
		{
			this.TargetArmRotatorYaw = GravityUtils.Instance.GetRotatorInGravity(this.StartVirtualCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Yaw;
		}
		this.PrepareYawTarget(tempTargetArmRotatorYaw);
		if (this.ModifyArmRotationYaw)
		{
			this.TargetArmRotatorYaw += this.GetTargetRotatorAdditional(ECameraRotationAxis.Yaw);
		}
		this.Camera.IsModifiedArmRotationYaw = (this.ModifySettings.IsModifiedArmRotationYaw || this.ModifyArmRotationYaw);
		float alpha2 = alpha;
		switch (state)
		{
		case EBlendState.BlendIn:
		{
			if (this.ModifySettings.IsUseArmRotationFloatCurve)
			{
				alpha2 = this.ModifySettings.ArmRotationFloatCurve.GetCurrentValue(blendIntTimeRatio);
			}
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Yaw = Rotator.AxisLerp(this.StartVirtualCamera.ArmRotation.Yaw, this.TargetArmRotatorYaw, alpha2);
				return;
			}
			float yaw = GravityUtils.Instance.GetRotatorInGravity(this.StartVirtualCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Yaw;
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Yaw = Rotator.AxisLerp(yaw, this.TargetArmRotatorYaw, alpha2);
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		}
		case EBlendState.Loop:
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Yaw = this.TargetArmRotatorYaw;
				return;
			}
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Yaw = this.TargetArmRotatorYaw;
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		case EBlendState.BlendOut:
			this.BlendOutData.SetBlendOutArmRotationYaw(this.TargetArmRotatorYaw);
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Yaw = Rotator.AxisLerp(this.BlendOutData.ArmRotationYaw, finalYaw, alpha2);
				return;
			}
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Yaw = Rotator.AxisLerp(this.BlendOutData.ArmRotationYaw, finalYaw, alpha2);
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x000B8FBC File Offset: 0x000B71BC
	private void UpdateArmRotationRollModifier(EBlendState state, float alpha, float blendIntTimeRatio, float tempTargetArmRotatorRoll, float finalRoll)
	{
		if (this.Camera.IsModifiedArmRotationRoll || ((!this.ModifySettings.IsModifiedArmRotation || !this.ModifySettings.IsModifiedArmRotationRoll) && !this.ModifyArmRotationRoll))
		{
			return;
		}
		if (this.Camera.IsInNormalGravityMode())
		{
			this.TargetArmRotatorRoll = this.StartVirtualCamera.ArmRotation.Roll;
		}
		else
		{
			this.TargetArmRotatorRoll = GravityUtils.Instance.GetRotatorInGravity(this.StartVirtualCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Roll;
		}
		this.PrepareRollTarget(tempTargetArmRotatorRoll);
		if (this.ModifyArmRotationRoll)
		{
			this.TargetArmRotatorRoll += this.GetTargetRotatorAdditional(ECameraRotationAxis.Roll);
		}
		this.Camera.IsModifiedArmRotationRoll = (this.ModifySettings.IsModifiedArmRotationRoll || this.ModifyArmRotationRoll);
		float alpha2 = alpha;
		switch (state)
		{
		case EBlendState.BlendIn:
		{
			if (this.ModifySettings.IsUseArmRotationFloatCurve)
			{
				alpha2 = this.ModifySettings.ArmRotationFloatCurve.GetCurrentValue(blendIntTimeRatio);
			}
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Roll = Rotator.AxisLerp(this.StartVirtualCamera.ArmRotation.Roll, this.TargetArmRotatorRoll, alpha2);
				return;
			}
			float roll = GravityUtils.Instance.GetRotatorInGravity(this.StartVirtualCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Roll;
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Roll = Rotator.AxisLerp(roll, this.TargetArmRotatorRoll, alpha2);
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		}
		case EBlendState.Loop:
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Roll = this.TargetArmRotatorRoll;
				return;
			}
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Roll = this.TargetArmRotatorRoll;
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		case EBlendState.BlendOut:
			this.BlendOutData.SetBlendOutArmRotationRoll(this.TargetArmRotatorRoll);
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.Roll = Rotator.AxisLerp(this.BlendOutData.ArmRotationRoll, finalRoll, alpha2);
				return;
			}
			GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
			this.TmpRotator2.Roll = Rotator.AxisLerp(this.BlendOutData.ArmRotationRoll, finalRoll, alpha2);
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x000B92F8 File Offset: 0x000B74F8
	private void UpdateHasInput()
	{
		CharacterInputComponent characterInputComponent = this.Camera.CharacterInputComponent;
		if (characterInputComponent == null || !characterInputComponent.Valid)
		{
			return;
		}
		ValueTuple<float, float> cameraInput = this.Camera.CharacterInputComponent.GetCameraInput();
		float item = cameraInput.Item1;
		float item2 = cameraInput.Item2;
		if ((double)Math.Abs(item) > 0.0001 || (double)Math.Abs(item2) > 0.0001)
		{
			this.HasInput = true;
		}
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x000B936C File Offset: 0x000B756C
	private bool HasZoomInput()
	{
		CharacterInputComponent characterInputComponent = this.Camera.CharacterInputComponent;
		return characterInputComponent != null && characterInputComponent.Valid && !MathUtils.Instance.IsNearlyZero((double)this.Camera.CharacterInputComponent.GetZoomInput(), new double?(0.0001));
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x000B93C4 File Offset: 0x000B75C4
	private Rotator GetFinalArmRotation()
	{
		if (this.ModifySettings.ResetFinalArmRotation)
		{
			if (this.ModifySettings.IsResetFinalArmRotationToSpecificPitch)
			{
				this.TmpFinalRotator.Pitch = this.ModifySettings.ResetFinalArmRotationToSpecificPitch;
			}
			else
			{
				this.TmpFinalRotator.Pitch = this.Camera.DesiredCamera.ArmRotation.Pitch;
			}
			if (this.ModifySettings.IsResetFinalArmRotationToSpecificYaw)
			{
				CameraUtility.GetCameraCharacterRotation(this.TmpRotator);
				this.TmpFinalRotator.Yaw = this.TmpRotator.Yaw + this.ModifySettings.ResetFinalArmRotationToSpecificYaw;
			}
			else
			{
				this.TmpFinalRotator.Yaw = this.Camera.DesiredCamera.ArmRotation.Yaw;
			}
			this.TmpFinalRotator.Roll = 0f;
			return this.TmpFinalRotator;
		}
		return this.FirstStartVirtualCamera.ArmRotation;
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x000B94A4 File Offset: 0x000B76A4
	private Rotator GetFinalArmQuaternion()
	{
		this.TmpFinalRotator.Reset();
		this.TmpRotator.Reset();
		if (this.ModifySettings.ResetFinalArmRotation)
		{
			if (!this.ModifySettings.IsResetFinalArmRotationToSpecificPitch)
			{
				this.TmpFinalRotator.Pitch = this.Camera.DesiredCamera.ArmRotation.Pitch;
			}
			if (!this.ModifySettings.IsResetFinalArmRotationToSpecificYaw)
			{
				this.TmpFinalRotator.Yaw = this.Camera.DesiredCamera.ArmRotation.Yaw;
			}
			this.TmpFinalRotator.Roll = 0f;
			GravityUtils.Instance.GetRotatorInGravity(this.TmpFinalRotator, this.Camera.GravityInverseQuat, this.TmpRotator2);
			if (this.ModifySettings.IsResetFinalArmRotationToSpecificPitch)
			{
				this.TmpRotator2.Pitch = this.ModifySettings.ResetFinalArmRotationToSpecificPitch;
			}
			if (this.ModifySettings.IsResetFinalArmRotationToSpecificYaw)
			{
				CameraUtility.GetCameraCharacterRotation(this.TmpRotator3);
				GravityUtils.Instance.GetRotatorInGravity(this.TmpRotator3, this.Camera.GravityInverseQuat, this.TmpRotator4);
				this.TmpRotator2.Yaw = this.TmpRotator4.Yaw + this.ModifySettings.ResetFinalArmRotationToSpecificYaw;
			}
			this.TmpRotator2.Roll = 0f;
			GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.TmpFinalRotator);
			return this.TmpFinalRotator;
		}
		return this.FirstStartVirtualCamera.ArmRotation;
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x000B9626 File Offset: 0x000B7826
	private float GetFinalArmLength()
	{
		if (this.ModifySettings.ResetFinalArmLength)
		{
			return this.Camera.DesiredCamera.ArmLength;
		}
		return this.FirstStartVirtualCamera.ArmLength;
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x000B9654 File Offset: 0x000B7854
	[NullableContext(2)]
	private float GetFinalZoomModifierArmLength(ModifyEndContext modifyEndContext = null)
	{
		if (modifyEndContext != null)
		{
			foreach (ResetFinalArmLengthToDynamicValueData resetFinalArmLengthToDynamicValueData in this.ModifySettings.ResetFinalArmLengthToDynamicValueList)
			{
				if (modifyEndContext.ArmLengthDynamicValueType == ECameraModifier_Settings_ArmLengthDynamicValueType.技能Id && resetFinalArmLengthToDynamicValueData.ArmLengthDynamicValueType == modifyEndContext.ArmLengthDynamicValueType && resetFinalArmLengthToDynamicValueData.SkillId == modifyEndContext.SkillId)
				{
					return resetFinalArmLengthToDynamicValueData.ArmLength;
				}
			}
		}
		if (this.ModifySettings.ResetFinalArmLength && this.ModifySettings.IsModifiedArmLength)
		{
			return MathUtils.Instance.Clamp(this.ModifySettings.IsResetFinalArmLengthToSpecificValue ? this.ModifySettings.ResetFinalArmLengthToSpecificValue : (this.ModifySettings.ArmLength + (this.ModifyArmLength ? this.ModifySettings.ArmLengthAdditional : 0f)), this.Camera.CurrentCamera.MinArmLength, this.Camera.CurrentCamera.MaxArmLength);
		}
		return MathUtils.Instance.Clamp(this.FirstStartVirtualCamera.ZoomModifier * this.Camera.GetArmLengthWithSetting(this.FirstStartVirtualCamera), this.Camera.CurrentCamera.MinArmLength, this.Camera.CurrentCamera.MaxArmLength);
	}

	// Token: 0x06002113 RID: 8467 RVA: 0x000B97A8 File Offset: 0x000B79A8
	private void UpdateFovModifier(EBlendState state, float alpha, float blendInTimeRatio)
	{
		if (!this.ModifyFov)
		{
			return;
		}
		float alpha2 = alpha;
		float num = this.ModifySettings.IsModifiedCameraFov ? this.ModifySettings.CameraFov : this.FirstStartVirtualCamera.Fov;
		switch (state)
		{
		case EBlendState.BlendIn:
			if (this.ModifySettings.IsUseFovFloatCurve)
			{
				alpha2 = this.ModifySettings.FovFloatCurve.GetCurrentValue(blendInTimeRatio);
			}
			this.Camera.DesiredCamera.Fov = MathUtils.Instance.Lerp(this.StartVirtualCamera.Fov, num, alpha2);
			break;
		case EBlendState.Loop:
			this.Camera.DesiredCamera.Fov = num;
			break;
		case EBlendState.BlendOut:
			this.Camera.DesiredCamera.Fov = MathUtils.Instance.Lerp(num, this.Camera.Fov, alpha2);
			break;
		}
		this.Camera.IsModifiedFov = true;
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x000B9890 File Offset: 0x000B7A90
	private void UpdateLensModifier(EBlendState state, float alpha, float blendInTimeRatio)
	{
		if (!this.ModifyLens)
		{
			return;
		}
		float alpha2 = alpha;
		float? fStop = null;
		float value = 0f;
		SCameraModifier_Lens cameraLens = this.ModifySettings.CameraLens;
		switch (state)
		{
		case EBlendState.BlendIn:
			if (this.ModifySettings.IsUseLensFloatCurve)
			{
				alpha2 = this.ModifySettings.LensFloatCurve.GetCurrentValue(blendInTimeRatio);
			}
			fStop = new float?(MathUtils.Instance.Lerp(cameraLens.StartFStop, cameraLens.EndFStop, alpha2));
			value = MathUtils.Instance.Lerp(cameraLens.RadialBlurStartIntensity, cameraLens.RadialBlurEndIntensity, alpha2);
			break;
		case EBlendState.Loop:
			fStop = new float?(cameraLens.EndFStop);
			value = cameraLens.RadialBlurEndIntensity;
			break;
		case EBlendState.BlendOut:
			fStop = new float?(MathUtils.Instance.Lerp(cameraLens.EndFStop, cameraLens.StartFStop, alpha2));
			value = MathUtils.Instance.Lerp(cameraLens.RadialBlurEndIntensity, cameraLens.RadialBlurStartIntensity, alpha2);
			break;
		}
		this.Camera.ApplyDepthOfField(fStop, null, null, null);
		this.Camera.ApplyRadialBlur(new float?(value), new FVector2D?(cameraLens.RadialBlurCenter), new float?(cameraLens.RadialBlurRadius), new float?(cameraLens.RadialBlurHardness), new int?((int)cameraLens.RadialBlurPassNumber), new int?((int)cameraLens.RadialBlurSampleNumber));
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x000B99F4 File Offset: 0x000B7BF4
	[NullableContext(2)]
	public void EndModify(bool withFadeOut, bool useFadeOutTime, ModifyEndContext modifyEndContext = null)
	{
		if (!this.IsModified)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "EndModify";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("withFadeOut", withFadeOut);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.Priority = 0;
		this.Camera.CameraAdjustController.Unlock(this);
		this.Camera.CameraGuideController.Unlock(this);
		if (this.ModifySettings.OverrideCameraInput)
		{
			if (this.ModifyArmRotationPitch || (this.ModifySettings.IsModifiedArmRotation && this.ModifySettings.IsModifiedArmRotationPitch))
			{
				this.Camera.CameraInputController.UnlockArmRotationPitch(this);
			}
			if (this.ModifyArmRotationYaw || (this.ModifySettings.IsModifiedArmRotation && this.ModifySettings.IsModifiedArmRotationYaw))
			{
				this.Camera.CameraInputController.UnlockArmRotationYaw(this);
			}
			if (this.ModifyArmLength || this.ModifySettings.IsModifiedArmLength)
			{
				this.Camera.CameraInputController.UnlockArmLength(this);
			}
		}
		if (withFadeOut)
		{
			this.StartModifyFadeOut(useFadeOutTime, modifyEndContext);
		}
		else
		{
			this.EndModifyFadeOut(false);
		}
		this.ModifyMontage = null;
		this.ModifyAnimSequence = null;
		this.AnimOwner.Clear();
		UAnimInstance modifyAnimInstance = this.ModifyAnimInstance;
		if (modifyAnimInstance != null && modifyAnimInstance.IsValid())
		{
			this.ModifyAnimInstance.OnMontageStarted.Remove(this.OnMontageStarted);
			this.ModifyAnimInstance.OnMontageEnded.Remove(this.OnMontageEnded);
			this.ModifyAnimInstance.OnAllMontageInstancesEnded.Remove(this.OnAllMontageInstancesEnded);
			this.ModifyAnimInstance = null;
		}
		this.ModifyArmLength = false;
		this.ModifyArmOffset = false;
		if (this.ModifySettings.IsModifiedCameraOffset || this.ModifyCameraOffset)
		{
			this.ModifyCameraOffset = false;
		}
		if (this.ModifyArmRotation)
		{
			this.ModifyArmRotationPitch = false;
			this.ModifyArmRotationYaw = false;
			this.ModifyArmRotationRoll = false;
		}
		if (this.ModifyFov)
		{
			this.ModifyFov = false;
		}
		if (this.ModifyTag != null)
		{
			this.ModifyTag = null;
			this.IsModifyBlendingOut = false;
		}
		if (this.ModifyLens)
		{
			this.ModifyLens = false;
			this.Camera.ExitDepthOfField();
			this.Camera.ExitRadialBlur();
		}
		this.HasInput = false;
		this.ModifySettings = null;
		this.Camera.CameraInputController.Unlock(this);
		if (this.LookAtActor.HasValue)
		{
			EventSystem.Instance.Remove<int>(EEventName.CharOnRoleDead, this.OnLookAtEntityDead);
		}
		this.LookAtActor.Clear();
		Entity lookAtEntity = this.LookAtEntity;
		if (lookAtEntity != null && lookAtEntity.Valid && this.LookAtEntityIsVision())
		{
			EventSystem.Instance.RemoveWithTarget<EntityHandle, EntityHandle>(this.LookAtEntity, EEventName.VisionMorphEnd, this.OnVisionMorphEnd);
		}
		this.LookAtEntity = null;
		this.ModifyPlayerLocation = false;
		this.IsBreakPreviousPlayerLocationModify = false;
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x000B9CBC File Offset: 0x000B7EBC
	[NullableContext(2)]
	private void StartModifyFadeOut(bool useFadeOutTime = false, ModifyEndContext modifyEndContext = null)
	{
		this.ModifyFadeOutData.ModifyArmLength = (this.ModifySettings.IsModifiedArmLength || this.ModifyArmLength);
		if (this.ModifyFadeOutData.ModifyArmLength)
		{
			this.ModifyFadeOutData.StartArmLength = this.Camera.CurrentCamera.ArmLength;
			this.ModifyFadeOutData.ArmLength = this.GetFinalArmLength();
		}
		this.ModifyFadeOutData.ModifyZoomModifier = this.ModifyFadeOutData.ModifyArmLength;
		if (this.ModifyFadeOutData.ModifyZoomModifier)
		{
			this.ModifyFadeOutData.StartFinalArmLength = this.Camera.GetArmLengthWithSettingAndZoom(this.Camera.CurrentCamera, false);
			this.ModifyFadeOutData.FinalArmLength = this.GetFinalZoomModifierArmLength(modifyEndContext);
		}
		this.ModifyFadeOutData.ModifyArmOffset = (this.ModifySettings.IsModifiedArmOffset || this.ModifyArmOffset);
		if (this.ModifyFadeOutData.ModifyArmOffset)
		{
			this.ModifyFadeOutData.StartArmOffset = this.Camera.CurrentCamera.ArmOffset;
			this.ModifyFadeOutData.ArmOffset.DeepCopy(this.FirstStartVirtualCamera.ArmOffset);
		}
		GravityUtils.Instance.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.Camera.GravityInverseQuat, this.FadeOutStartRotator);
		if (this.Camera.IsInNormalGravityMode())
		{
			this.TmpFinalRotator.DeepCopy(this.GetFinalArmRotation());
		}
		else
		{
			this.TmpFinalRotator.DeepCopy(this.GetFinalArmQuaternion());
		}
		GravityUtils.Instance.GetRotatorInGravity(this.TmpFinalRotator, this.Camera.GravityInverseQuat, this.TmpFinalRotatorInGravity);
		this.ModifyFadeOutData.ModifyArmRotationPitch = ((this.ModifyArmRotationPitch || (this.ModifySettings.IsModifiedArmRotation && this.ModifySettings.IsModifiedArmRotationPitch)) && (this.ModifySettings.IsLockInput || !this.HasInput));
		if (this.ModifyFadeOutData.ModifyArmRotationPitch)
		{
			this.ModifyFadeOutData.StartArmRotationPitch = this.FadeOutStartRotator.Pitch;
			this.ModifyFadeOutData.ArmRotationPitch = this.TmpFinalRotatorInGravity.Pitch;
		}
		this.ModifyFadeOutData.ModifyArmRotationYaw = ((this.ModifyArmRotationYaw || (this.ModifySettings.IsModifiedArmRotation && this.ModifySettings.IsModifiedArmRotationYaw)) && (this.ModifySettings.IsLockInput || !this.HasInput));
		if (this.ModifyFadeOutData.ModifyArmRotationYaw)
		{
			this.ModifyFadeOutData.StartArmRotationYaw = this.FadeOutStartRotator.Yaw;
			this.ModifyFadeOutData.ArmRotationYaw = this.TmpFinalRotatorInGravity.Yaw;
		}
		this.ModifyFadeOutData.ModifyArmRotationRoll = ((this.ModifyArmRotationRoll || (this.ModifySettings.IsModifiedArmRotation && this.ModifySettings.IsModifiedArmRotationRoll)) && !MathUtils.Instance.IsNearlyZero((double)this.Camera.DesiredCamera.ArmRotation.Roll, new double?(0.0001)));
		if (this.ModifyFadeOutData.ModifyArmRotationRoll)
		{
			this.ModifyFadeOutData.StartArmRotationRoll = this.FadeOutStartRotator.Roll;
			this.ModifyFadeOutData.ArmRotationRoll = 0f;
		}
		this.ModifyFadeOutData.ModifyCameraOffset = (this.ModifySettings.IsModifiedCameraOffset || this.ModifyCameraOffset);
		if (this.ModifyFadeOutData.ModifyCameraOffset)
		{
			this.ModifyFadeOutData.StartCameraOffset.DeepCopy(this.Camera.CurrentCamera.CameraOffset);
		}
		this.ModifyFadeOutData.ModifyFov = this.ModifyFov;
		if (this.ModifyFadeOutData.ModifyFov)
		{
			this.ModifyFadeOutData.StartFov = this.Camera.CurrentCamera.Fov;
			this.ModifyFadeOutData.Fov = this.Camera.Fov;
		}
		this.ModifyFadeOutData.ModifyPlayerLocation = this.ModifyPlayerLocation;
		if (this.ModifyFadeOutData.ModifyPlayerLocation)
		{
			this.ModifyFadeOutData.StartPlayerLocation.DeepCopy(this.Camera.PlayerLocation);
			this.ModifyFadeOutData.PlayerLocation.DeepCopy(this.TmpPlayerLocation);
		}
		this.ModifyFadeOutData.ElapsedTime = 0f;
		this.ModifyFadeOutData.FadeOutTotalTime = this.ModifyFadeOutTime;
		this.ModifyFadeOutData.UseFadeOutTimeLerp = useFadeOutTime;
		this.ModifyFadeOutData.BlendOutCurve = this.ModifyBlendOutCurve;
		this.IsModifyFadeOut = (this.ModifyFadeOutData.ModifyArmLength || this.ModifyFadeOutData.ModifyArmOffset || this.ModifyFadeOutData.ModifyArmRotationPitch || this.ModifyFadeOutData.ModifyArmRotationYaw || this.ModifyFadeOutData.ModifyArmRotationRoll || this.ModifyFadeOutData.ModifyCameraOffset || this.ModifyFadeOutData.ModifyFov || this.ModifyFadeOutData.ModifyPlayerLocation);
		if (!this.IsModifyFadeOut)
		{
			this.Camera.ClearSuppressClearRoll(ESuppressClearRollFlag.CameraModify);
		}
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x000BA1A4 File Offset: 0x000B83A4
	public void EndModifyFadeOut(bool isRestoreToFinalValue = false)
	{
		if (isRestoreToFinalValue)
		{
			CameraFadeOutData modifyFadeOutData = this.ModifyFadeOutData;
			VirtualCamera desiredCamera = this.Camera.DesiredCamera;
			if (modifyFadeOutData.ModifyZoomModifier)
			{
				desiredCamera.ZoomModifier = modifyFadeOutData.FinalArmLength / this.Camera.GetArmLengthWithSetting(this.Camera.CurrentCamera);
				this.Camera.IsModifiedZoomModifier = true;
				this.Camera.IsModifiedArmLength = true;
			}
			if (modifyFadeOutData.ModifyArmOffset)
			{
				desiredCamera.ArmOffset = modifyFadeOutData.ArmOffset;
				this.Camera.IsModifiedArmOffset = true;
			}
			if (modifyFadeOutData.ModifyCameraOffset)
			{
				desiredCamera.CameraOffset.X = (double)this.Camera.CameraOffsetX;
				desiredCamera.CameraOffset.Y = (double)this.Camera.CameraOffsetY;
				desiredCamera.CameraOffset.Z = (double)this.Camera.CameraOffsetZ;
				this.Camera.IsModifiedCameraOffset = true;
			}
			if (modifyFadeOutData.ModifyArmRotationPitch)
			{
				if (this.Camera.IsInNormalGravityMode())
				{
					desiredCamera.ArmRotation.Pitch = modifyFadeOutData.ArmRotationPitch;
				}
				else
				{
					GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
					this.TmpRotator2.Pitch = modifyFadeOutData.ArmRotationPitch;
					GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
				}
			}
			if (modifyFadeOutData.ModifyArmRotationYaw)
			{
				if (this.Camera.IsInNormalGravityMode())
				{
					desiredCamera.ArmRotation.Yaw = modifyFadeOutData.ArmRotationYaw;
				}
				else
				{
					GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
					this.TmpRotator2.Yaw = modifyFadeOutData.ArmRotationYaw;
					GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
				}
			}
			if (modifyFadeOutData.ModifyArmRotationRoll)
			{
				if (this.Camera.IsInNormalGravityMode())
				{
					desiredCamera.ArmRotation.Roll = modifyFadeOutData.ArmRotationRoll;
				}
				else
				{
					GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
					this.TmpRotator2.Roll = modifyFadeOutData.ArmRotationRoll;
					GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
				}
			}
			if (modifyFadeOutData.ModifyFov)
			{
				desiredCamera.Fov = modifyFadeOutData.Fov;
				this.Camera.IsModifiedFov = true;
			}
		}
		this.IsModifyFadeOut = false;
		this.Camera.ClearSuppressClearRoll(ESuppressClearRollFlag.CameraModify);
		this.ModifyFadeOutData.ModifyArmLength = false;
		this.ModifyFadeOutData.ModifyArmOffset = false;
		this.ModifyFadeOutData.ModifyArmRotationPitch = false;
		this.ModifyFadeOutData.ModifyArmRotationYaw = false;
		this.ModifyFadeOutData.ModifyArmRotationRoll = false;
		this.ModifyFadeOutData.ModifyCameraOffset = false;
		this.ModifyFadeOutData.ModifyFov = false;
		this.ModifyFadeOutData.ModifyPlayerLocation = false;
		this.ModifyFadeOutData.BlendOutCurve = null;
		if (EventSystem.Instance.Has<ULevelSequence, AActor, ALevelSequenceActor, FTransformDouble, bool, bool, string>(EEventName.PlayCameraLevelSequence, this.OnPlayCameraLevelSequence))
		{
			EventSystem.Instance.Remove<ULevelSequence, AActor, ALevelSequenceActor, FTransformDouble, bool, bool, string>(EEventName.PlayCameraLevelSequence, this.OnPlayCameraLevelSequence);
		}
		if (EventSystem.Instance.Has<int, int, bool>(EEventName.CharBeforeSkill, this.OnCharBeforeUseSkill))
		{
			EventSystem.Instance.Remove<int, int, bool>(EEventName.CharBeforeSkill, this.OnCharBeforeUseSkill);
		}
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x000BA538 File Offset: 0x000B8738
	private unsafe void UpdateModifyFadeOut(float deltaTime)
	{
		if (!this.IsModifyFadeOut)
		{
			return;
		}
		CameraFadeOutData modifyFadeOutData = this.ModifyFadeOutData;
		VirtualCamera currentCamera = this.Camera.CurrentCamera;
		VirtualCamera desiredCamera = this.Camera.DesiredCamera;
		this.ModifyFadeOutData.ElapsedTime += deltaTime;
		float alpha = (modifyFadeOutData.FadeOutTotalTime <= 0f) ? 1f : ((modifyFadeOutData.BlendOutCurve != null) ? modifyFadeOutData.BlendOutCurve.GetCurrentValue(modifyFadeOutData.ElapsedTime / modifyFadeOutData.FadeOutTotalTime) : MathUtils.Instance.Clamp(modifyFadeOutData.ElapsedTime / modifyFadeOutData.FadeOutTotalTime, 0f, 1f));
		if (modifyFadeOutData.ModifyZoomModifier)
		{
			if (this.Camera.IsModifiedZoomModifier)
			{
				modifyFadeOutData.ModifyZoomModifier = false;
				modifyFadeOutData.ModifyArmLength = false;
			}
			else
			{
				modifyFadeOutData.FinalArmLength = MathUtils.Instance.Clamp(modifyFadeOutData.FinalArmLength, this.Camera.CurrentCamera.MinArmLength, this.Camera.CurrentCamera.MaxArmLength);
				modifyFadeOutData.ModifyArmLength = false;
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				float item;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, float> valueTuple = this.FloatInterpTo(this.Camera.GetArmLengthWithSettingAndZoom(this.Camera.CurrentCamera, false), modifyFadeOutData.FinalArmLength, deltaTime, this.ModifyArmLengthLagSpeed, 1f);
					cameraFadeOutData.ModifyZoomModifier = valueTuple.Item1;
					item = valueTuple.Item2;
				}
				else
				{
					ValueTuple<bool, float> valueTuple = this.FloatLerp(modifyFadeOutData.StartFinalArmLength, modifyFadeOutData.FinalArmLength, alpha, 0.0001f);
					cameraFadeOutData.ModifyZoomModifier = valueTuple.Item1;
					item = valueTuple.Item2;
				}
				desiredCamera.ZoomModifier = item / this.Camera.GetArmLengthWithSetting(this.Camera.CurrentCamera);
				this.Camera.IsModifiedZoomModifier = true;
				this.Camera.IsModifiedArmLength = true;
				if ((double)this.Camera.DesiredCamera.ZoomModifier <= 1E-08 && this.EnableDebugFadeOutZoomModifier)
				{
					this.EnableDebugFadeOutZoomModifier = false;
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Camera;
					ELogAuthor author = ELogAuthor.LJM;
					string message = "[DebugZoomModifier UpdateModifyFadeOut]";
					<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("DesiredCamera.ZoomModifier", this.Camera.DesiredCamera.ZoomModifier);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("finalArmLength", item);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ArmLength", this.Camera.GetArmLengthWithSetting(this.Camera.CurrentCamera));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Anim", this.ModifyAnimSequence);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("CameraConfigTags", this.Camera.CameraConfigController.GetCameraConfigTagsContent());
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				}
			}
		}
		if (modifyFadeOutData.ModifyArmOffset)
		{
			if (this.Camera.IsModifiedArmOffset)
			{
				modifyFadeOutData.ModifyArmOffset = false;
			}
			else
			{
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				VirtualCamera virtualCamera = desiredCamera;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, Vector> valueTuple2 = this.VectorInterpTo(currentCamera.ArmOffset, modifyFadeOutData.ArmOffset, deltaTime, this.ModifyArmOffsetLagSpeed, 1f);
					cameraFadeOutData.ModifyArmOffset = valueTuple2.Item1;
					virtualCamera.ArmOffset = valueTuple2.Item2;
				}
				else
				{
					ValueTuple<bool, Vector> valueTuple2 = this.VectorLerp(modifyFadeOutData.StartArmOffset, modifyFadeOutData.ArmOffset, alpha, 1f);
					cameraFadeOutData.ModifyArmOffset = valueTuple2.Item1;
					virtualCamera.ArmOffset = valueTuple2.Item2;
				}
				this.Camera.IsModifiedArmOffset = true;
			}
		}
		if (modifyFadeOutData.ModifyCameraOffset)
		{
			if (this.Camera.IsModifiedCameraOffset)
			{
				modifyFadeOutData.ModifyCameraOffset = false;
			}
			else
			{
				modifyFadeOutData.CameraOffset.X = (double)this.Camera.CameraOffsetX;
				modifyFadeOutData.CameraOffset.Y = (double)this.Camera.CameraOffsetY;
				modifyFadeOutData.CameraOffset.Z = (double)this.Camera.CameraOffsetZ;
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				VirtualCamera virtualCamera = desiredCamera;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, Vector> valueTuple2 = this.VectorInterpTo(currentCamera.CameraOffset, modifyFadeOutData.CameraOffset, deltaTime, this.ModifyCameraOffsetLagSpeed, 1f);
					cameraFadeOutData.ModifyCameraOffset = valueTuple2.Item1;
					virtualCamera.CameraOffset = valueTuple2.Item2;
				}
				else
				{
					ValueTuple<bool, Vector> valueTuple2 = this.VectorLerp(modifyFadeOutData.StartCameraOffset, modifyFadeOutData.CameraOffset, alpha, 1f);
					cameraFadeOutData.ModifyCameraOffset = valueTuple2.Item1;
					virtualCamera.CameraOffset = valueTuple2.Item2;
				}
				this.Camera.IsModifiedCameraOffset = true;
			}
		}
		this.UpdateHasInput();
		GravityUtils.Instance.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.Camera.GravityInverseQuat, this.FadeOutStartRotator);
		if (modifyFadeOutData.ModifyArmRotationPitch)
		{
			if (this.Camera.IsModifiedArmRotationPitch || this.HasInput)
			{
				modifyFadeOutData.ModifyArmRotationPitch = false;
			}
			else if (this.Camera.IsInNormalGravityMode())
			{
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				Rotator armRotation = desiredCamera.ArmRotation;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisInterpTo(currentCamera.ArmRotation.Pitch, modifyFadeOutData.ArmRotationPitch, deltaTime, this.ModifyArmRotationLagSpeed, 1f);
					cameraFadeOutData.ModifyArmRotationPitch = valueTuple.Item1;
					armRotation.Pitch = valueTuple.Item2;
				}
				else
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisLerp(modifyFadeOutData.StartArmRotationPitch, modifyFadeOutData.ArmRotationPitch, alpha, 1f);
					cameraFadeOutData.ModifyArmRotationPitch = valueTuple.Item1;
					armRotation.Pitch = valueTuple.Item2;
				}
			}
			else
			{
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				float item2;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisInterpTo(this.FadeOutStartRotator.Pitch, modifyFadeOutData.ArmRotationPitch, deltaTime, this.ModifyArmRotationLagSpeed, 1f);
					cameraFadeOutData.ModifyArmRotationPitch = valueTuple.Item1;
					item2 = valueTuple.Item2;
				}
				else
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisLerp(modifyFadeOutData.StartArmRotationPitch, modifyFadeOutData.ArmRotationPitch, alpha, 1f);
					cameraFadeOutData.ModifyArmRotationPitch = valueTuple.Item1;
					item2 = valueTuple.Item2;
				}
				GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
				this.TmpRotator2.Pitch = item2;
				GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			}
		}
		if (modifyFadeOutData.ModifyArmRotationYaw)
		{
			if (this.Camera.IsModifiedArmRotationYaw || this.HasInput)
			{
				modifyFadeOutData.ModifyArmRotationYaw = false;
			}
			else if (this.Camera.IsInNormalGravityMode())
			{
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				Rotator armRotation = desiredCamera.ArmRotation;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisInterpTo(currentCamera.ArmRotation.Yaw, modifyFadeOutData.ArmRotationYaw, deltaTime, this.ModifyArmRotationLagSpeed, 1f);
					cameraFadeOutData.ModifyArmRotationYaw = valueTuple.Item1;
					armRotation.Yaw = valueTuple.Item2;
				}
				else
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisLerp(modifyFadeOutData.StartArmRotationYaw, modifyFadeOutData.ArmRotationYaw, alpha, 1f);
					cameraFadeOutData.ModifyArmRotationYaw = valueTuple.Item1;
					armRotation.Yaw = valueTuple.Item2;
				}
			}
			else
			{
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				float item3;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisInterpTo(this.FadeOutStartRotator.Yaw, modifyFadeOutData.ArmRotationYaw, deltaTime, this.ModifyArmRotationLagSpeed, 1f);
					cameraFadeOutData.ModifyArmRotationYaw = valueTuple.Item1;
					item3 = valueTuple.Item2;
				}
				else
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisLerp(modifyFadeOutData.StartArmRotationYaw, modifyFadeOutData.ArmRotationYaw, alpha, 1f);
					cameraFadeOutData.ModifyArmRotationYaw = valueTuple.Item1;
					item3 = valueTuple.Item2;
				}
				GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
				this.TmpRotator2.Yaw = item3;
				GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			}
		}
		if (modifyFadeOutData.ModifyArmRotationRoll)
		{
			if (this.Camera.IsModifiedArmRotationRoll)
			{
				modifyFadeOutData.ModifyArmRotationRoll = false;
			}
			else if (this.Camera.IsInNormalGravityMode())
			{
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				Rotator armRotation = desiredCamera.ArmRotation;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisInterpTo(currentCamera.ArmRotation.Roll, modifyFadeOutData.ArmRotationRoll, deltaTime, this.ModifyArmRotationLagSpeed, 1f);
					cameraFadeOutData.ModifyArmRotationRoll = valueTuple.Item1;
					armRotation.Roll = valueTuple.Item2;
				}
				else
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisLerp(modifyFadeOutData.StartArmRotationRoll, modifyFadeOutData.ArmRotationRoll, alpha, 1f);
					cameraFadeOutData.ModifyArmRotationRoll = valueTuple.Item1;
					armRotation.Roll = valueTuple.Item2;
				}
			}
			else
			{
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				float item4;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisInterpTo(this.FadeOutStartRotator.Roll, modifyFadeOutData.ArmRotationRoll, deltaTime, this.ModifyArmRotationLagSpeed, 1f);
					cameraFadeOutData.ModifyArmRotationRoll = valueTuple.Item1;
					item4 = valueTuple.Item2;
				}
				else
				{
					ValueTuple<bool, float> valueTuple = this.RotationAxisLerp(modifyFadeOutData.StartArmRotationRoll, modifyFadeOutData.ArmRotationRoll, alpha, 1f);
					cameraFadeOutData.ModifyArmRotationRoll = valueTuple.Item1;
					item4 = valueTuple.Item2;
				}
				GravityUtils.Instance.GetRotatorInGravity(this.Camera.DesiredCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator2);
				this.TmpRotator2.Roll = item4;
				GravityUtils.Instance.GetRotatorInNormal(this.TmpRotator2, this.Camera.GravityQuat, this.Camera.DesiredCamera.ArmRotation);
			}
		}
		if (this.IsDebugCurveEval)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Camera;
			ELogAuthor author2 = ELogAuthor.ZJL;
			string message2 = "[CurveEval][FadeOut] Modify FadeOut";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("desiredX", desiredCamera.CameraOffset.X);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("desiredY", desiredCamera.CameraOffset.Y);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("desiredZ", desiredCamera.CameraOffset.Z);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("desiredPitch", desiredCamera.ArmRotation.Pitch);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("desiredYaw", desiredCamera.ArmRotation.Yaw);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("desiredRoll", desiredCamera.ArmRotation.Roll);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
		}
		if (modifyFadeOutData.ModifyFov)
		{
			if (this.Camera.IsModifiedFov)
			{
				modifyFadeOutData.ModifyFov = false;
			}
			else
			{
				CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
				VirtualCamera virtualCamera = desiredCamera;
				if (!modifyFadeOutData.UseFadeOutTimeLerp)
				{
					ValueTuple<bool, float> valueTuple = this.FloatInterpTo(currentCamera.Fov, modifyFadeOutData.Fov, deltaTime, this.ModifyFovLagSpeed, 1f);
					cameraFadeOutData.ModifyFov = valueTuple.Item1;
					virtualCamera.Fov = valueTuple.Item2;
				}
				else
				{
					ValueTuple<bool, float> valueTuple = this.FloatLerp(modifyFadeOutData.StartFov, modifyFadeOutData.Fov, alpha, 1f);
					cameraFadeOutData.ModifyFov = valueTuple.Item1;
					virtualCamera.Fov = valueTuple.Item2;
				}
				this.Camera.IsModifiedFov = true;
			}
		}
		if (modifyFadeOutData.ModifyPlayerLocation)
		{
			CameraFadeOutData cameraFadeOutData = modifyFadeOutData;
			CameraFadeOutData cameraFadeOutData2 = modifyFadeOutData;
			if (!modifyFadeOutData.UseFadeOutTimeLerp)
			{
				ValueTuple<bool, Vector> valueTuple2 = this.VectorInterpTo(modifyFadeOutData.PlayerLocation, this.Camera.PlayerLocation, deltaTime, this.ModifyCameraOffsetLagSpeed, 1f);
				cameraFadeOutData.ModifyPlayerLocation = valueTuple2.Item1;
				cameraFadeOutData2.PlayerLocation = valueTuple2.Item2;
			}
			else
			{
				ValueTuple<bool, Vector> valueTuple2 = this.VectorLerp(modifyFadeOutData.PlayerLocation, this.Camera.PlayerLocation, alpha, 1f);
				cameraFadeOutData.ModifyPlayerLocation = valueTuple2.Item1;
				cameraFadeOutData2.PlayerLocation = valueTuple2.Item2;
			}
			this.Camera.PlayerLocation.DeepCopy(modifyFadeOutData.PlayerLocation);
		}
		if (modifyFadeOutData.UseFadeOutTimeLerp && modifyFadeOutData.ElapsedTime > modifyFadeOutData.FadeOutTotalTime)
		{
			this.IsModifyFadeOut = false;
			this.EndModifyFadeOut(false);
			return;
		}
		this.IsModifyFadeOut = (modifyFadeOutData.ModifyArmLength || modifyFadeOutData.ModifyArmOffset || modifyFadeOutData.ModifyZoomModifier || modifyFadeOutData.ModifyCameraOffset || modifyFadeOutData.ModifyArmRotationPitch || modifyFadeOutData.ModifyArmRotationYaw || modifyFadeOutData.ModifyArmRotationRoll || modifyFadeOutData.ModifyFov || modifyFadeOutData.ModifyPlayerLocation);
		if (!this.IsModifyFadeOut)
		{
			this.Camera.ClearSuppressClearRoll(ESuppressClearRollFlag.CameraModify);
		}
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x000BB1F8 File Offset: 0x000B93F8
	[NullableContext(2)]
	private UAnimInstance GetModifyAnimInstance([Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<TsBaseCharacter, TsBaseVehicle> newLookAtActor, [Nullable(new byte[]
	{
		0,
		1,
		1
	})] OneOf<TsBaseCharacter, TsBaseVehicle> montageOwner)
	{
		Entity entity = null;
		if (newLookAtActor.HasValue)
		{
			if (newLookAtActor.IsT1)
			{
				entity = newLookAtActor.AsT1.GetEntityNoBlueprint();
			}
			else if (newLookAtActor.IsT2)
			{
				entity = newLookAtActor.AsT2.GetEntityNoBlueprint();
			}
		}
		else
		{
			Entity entity2 = montageOwner.HasValue ? (montageOwner.IsT1 ? montageOwner.AsT1.GetEntityNoBlueprint() : montageOwner.AsT2.GetEntityNoBlueprint()) : null;
			CreatureDataComponent creatureDataComponent = (entity2 != null) ? entity2.GetComponent<CreatureDataComponent>() : null;
			if ((creatureDataComponent != null && creatureDataComponent.IsVision()) || (creatureDataComponent != null && creatureDataComponent.IsMonster()))
			{
				entity = (montageOwner.IsT1 ? montageOwner.AsT1.GetEntityNoBlueprint() : montageOwner.AsT2.GetEntityNoBlueprint());
			}
			else
			{
				entity = this.Camera.CharacterEntityHandle.Entity;
			}
		}
		if (entity == null)
		{
			return null;
		}
		CharacterAnimationComponent component = entity.GetComponent<CharacterAnimationComponent>();
		if (component == null)
		{
			return null;
		}
		return component.MainAnimInstance;
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x000BB2E8 File Offset: 0x000B94E8
	private bool LookAtEntityIsVision()
	{
		Entity lookAtEntity = this.LookAtEntity;
		CreatureDataComponent creatureDataComponent = (lookAtEntity != null) ? lookAtEntity.GetComponent<CreatureDataComponent>() : null;
		return creatureDataComponent != null && creatureDataComponent.Valid && creatureDataComponent.IsVision();
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x000BB324 File Offset: 0x000B9524
	[NullableContext(0)]
	public ValueTuple<bool, float> FloatInterpTo(float current, float target, float deltaTime, float interpSpeed, float nearValue)
	{
		double num = MathUtils.Instance.InterpTo((double)current, (double)target, (double)deltaTime, (double)interpSpeed);
		if (Math.Abs(current - target) < nearValue)
		{
			return new ValueTuple<bool, float>(false, target);
		}
		return new ValueTuple<bool, float>(true, (float)num);
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x000BB364 File Offset: 0x000B9564
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, Vector> VectorInterpTo(Vector current, Vector target, float deltaTime, float interpSpeed, float nearValue)
	{
		Vector vector = Vector.Create();
		MathUtils.Instance.VectorInterpTo(current, target, (double)deltaTime, (double)interpSpeed, vector);
		Vector vector2 = Vector.Create();
		current.Subtraction(target, vector2);
		if (vector2.GetAbsMax() < (double)nearValue)
		{
			vector.DeepCopy(target);
			return new ValueTuple<bool, Vector>(false, vector);
		}
		return new ValueTuple<bool, Vector>(true, vector);
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x000BB3BC File Offset: 0x000B95BC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, Rotator> RotationInterpTo(Rotator current, Rotator target, float deltaTime, float interpSpeed, float nearValue)
	{
		Rotator rotator = Rotator.Create();
		MathUtils.Instance.RotatorInterpTo(current, target, (double)deltaTime, (double)interpSpeed, rotator);
		if (current.Equals(target, nearValue))
		{
			rotator.DeepCopy(target);
			return new ValueTuple<bool, Rotator>(false, rotator);
		}
		return new ValueTuple<bool, Rotator>(true, rotator);
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x000BB404 File Offset: 0x000B9604
	[NullableContext(0)]
	public ValueTuple<bool, float> RotationAxisInterpTo(float current, float target, float deltaTime, float interpSpeed, float nearValue)
	{
		float item = MathUtils.Instance.RotatorAxisInterpTo(current, target, deltaTime, interpSpeed);
		if (MathUtils.Instance.IsAngleNearEqual((double)current, (double)target, (double)nearValue))
		{
			return new ValueTuple<bool, float>(false, item);
		}
		return new ValueTuple<bool, float>(true, item);
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000BB444 File Offset: 0x000B9644
	[NullableContext(0)]
	public ValueTuple<bool, float> FloatLerp(float current, float target, float alpha, float nearValue)
	{
		float item = MathUtils.Instance.Lerp(current, target, alpha);
		if (Math.Abs(current - target) < nearValue)
		{
			return new ValueTuple<bool, float>(false, target);
		}
		return new ValueTuple<bool, float>(true, item);
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x000BB47C File Offset: 0x000B967C
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, Vector> VectorLerp(Vector current, Vector target, float alpha, float nearValue)
	{
		Vector vector = Vector.Create();
		Vector.Lerp(current, target, (double)alpha, vector);
		if (current.Equals(target, (double)nearValue))
		{
			vector.DeepCopy(target);
			return new ValueTuple<bool, Vector>(false, vector);
		}
		return new ValueTuple<bool, Vector>(true, vector);
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x000BB4BC File Offset: 0x000B96BC
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	public ValueTuple<bool, Rotator> RotationLerp(Rotator current, Rotator target, float alpha, float nearValue)
	{
		Rotator rotator = Rotator.Create();
		Rotator.Lerp(current, target, alpha, rotator);
		if (current.Equals(target, nearValue))
		{
			rotator.DeepCopy(target);
			return new ValueTuple<bool, Rotator>(false, rotator);
		}
		return new ValueTuple<bool, Rotator>(true, rotator);
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x000BB4FC File Offset: 0x000B96FC
	[NullableContext(0)]
	public ValueTuple<bool, float> RotationAxisLerp(float current, float target, float alpha, float nearValue)
	{
		float item = Rotator.AxisLerp(current, target, alpha);
		if (MathUtils.Instance.IsAngleNearEqual((double)current, (double)target, (double)nearValue))
		{
			return new ValueTuple<bool, float>(false, item);
		}
		return new ValueTuple<bool, float>(true, item);
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x000BB534 File Offset: 0x000B9734
	public void StopCameraModify(UAnimSequenceBase anim, int modifyInstance)
	{
		if (this.ModifyAnimSequence != anim || this.ModifyInstance != modifyInstance)
		{
			return;
		}
		this.EndModify(true, true, null);
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x000BB552 File Offset: 0x000B9752
	public void ForceStopModify(bool withFadeOut)
	{
		if (this.IsModified)
		{
			this.EndModify(withFadeOut, withFadeOut, null);
			return;
		}
		if (!withFadeOut && this.IsModifyFadeOut)
		{
			this.EndModifyFadeOut(false);
		}
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x000BB578 File Offset: 0x000B9778
	public float GetTargetRotatorAdditional(ECameraRotationAxis axis)
	{
		switch (axis)
		{
		case ECameraRotationAxis.Pitch:
			if (!this.ModifyArmRotationPitch)
			{
				return 0f;
			}
			return this.ModifySettings.ArmRotationAdditionalPitchEval.GetValue(this.ModifyElapsedTime);
		case ECameraRotationAxis.Yaw:
			if (!this.ModifyArmRotationYaw)
			{
				return 0f;
			}
			return this.ModifySettings.ArmRotationAdditionalYawEval.GetValue(this.ModifyElapsedTime);
		case ECameraRotationAxis.Roll:
			if (!this.ModifyArmRotationRoll)
			{
				return 0f;
			}
			return this.ModifySettings.ArmRotationAdditionalRollEval.GetValue(this.ModifyElapsedTime);
		default:
			return 0f;
		}
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x000BB610 File Offset: 0x000B9810
	private unsafe void PreparePitchTarget(float tempTargetArmRotatorPitch)
	{
		if (!this.ModifySettings.IsModifiedArmRotationPitch)
		{
			return;
		}
		if (this.FirstModifyArmRotationPitch)
		{
			this.StartTargetArmRotator.Pitch = tempTargetArmRotatorPitch;
			this.FirstModifyArmRotationPitch = false;
		}
		this.TargetArmRotatorPitch = this.StartTargetArmRotator.Pitch + this.ModifySettings.ArmRotationPitchEval.GetValue(this.ModifyElapsedTime);
		if (this.IsDebugCurveEval)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[CurveEval][Rotation][Pitch]";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("t", this.ModifyElapsedTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("evalValue", this.ModifySettings.ArmRotationPitchEval.GetValue(this.ModifyElapsedTime));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("startPitch", this.StartTargetArmRotator.Pitch);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("targetPitch", this.TargetArmRotatorPitch);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x000BB73C File Offset: 0x000B993C
	private unsafe void PrepareYawTarget(float tempTargetArmRotatorYaw)
	{
		if (!this.ModifySettings.IsModifiedArmRotationYaw)
		{
			return;
		}
		if (this.FirstModifyArmRotationYaw)
		{
			this.StartTargetArmRotator.Yaw = tempTargetArmRotatorYaw;
			this.FirstModifyArmRotationYaw = false;
		}
		this.TargetArmRotatorYaw = this.StartTargetArmRotator.Yaw + this.ModifySettings.ArmRotationYawEval.GetValue(this.ModifyElapsedTime);
		if (this.IsDebugCurveEval)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[CurveEval][Rotation][Yaw]";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("t", this.ModifyElapsedTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("evalValue", this.ModifySettings.ArmRotationYawEval.GetValue(this.ModifyElapsedTime));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("startYaw", this.StartTargetArmRotator.Yaw);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("targetYaw", this.TargetArmRotatorYaw);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x000BB868 File Offset: 0x000B9A68
	private unsafe void PrepareRollTarget(float tempTargetArmRotatorRoll)
	{
		if (!this.ModifySettings.IsModifiedArmRotationRoll)
		{
			return;
		}
		if (this.FirstModifyArmRotationRoll)
		{
			this.StartTargetArmRotator.Roll = tempTargetArmRotatorRoll;
			this.FirstModifyArmRotationRoll = false;
		}
		this.TargetArmRotatorRoll = this.StartTargetArmRotator.Roll + this.ModifySettings.ArmRotationRollEval.GetValue(this.ModifyElapsedTime);
		if (this.IsDebugCurveEval)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.ZJL;
			string message = "[CurveEval][Rotation][Roll]";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("t", this.ModifyElapsedTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("evalValue", this.ModifySettings.ArmRotationRollEval.GetValue(this.ModifyElapsedTime));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("startRoll", this.StartTargetArmRotator.Roll);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("targetRoll", this.TargetArmRotatorRoll);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x000BB991 File Offset: 0x000B9B91
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x000BB99A File Offset: 0x000B9B9A
	public void LockCameraModify(EModifyInternalLockReason lockType, bool isFadeOut, bool isEndFadeOut)
	{
		this.ModifyLockHandler.Lock(lockType);
		if (this.IsModified && isFadeOut)
		{
			this.EndModify(true, true, null);
		}
		if (this.IsModifyFadeOut && isEndFadeOut)
		{
			this.EndModifyFadeOut(false);
		}
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x000BB9CC File Offset: 0x000B9BCC
	public void UnlockCameraModify(EModifyInternalLockReason lockType)
	{
		this.ModifyLockHandler.Unlock(lockType);
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x000BB9DA File Offset: 0x000B9BDA
	public bool IsCameraModifyLocked()
	{
		return !this.ModifyLockHandler.IsUnlocked();
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x000BB9EC File Offset: 0x000B9BEC
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 7:
				if (key == "TmpQuat")
				{
					value = this.TmpQuat;
					return true;
				}
				break;
			case 8:
			{
				char c = key[0];
				if (c <= 'I')
				{
					if (c != 'H')
					{
						if (c == 'I')
						{
							if (key == "IsAiming")
							{
								value = this.IsAiming;
								return true;
							}
						}
					}
					else if (key == "HasInput")
					{
						value = this.HasInput;
						return true;
					}
				}
				else if (c != 'P')
				{
					if (c == 'T')
					{
						if (key == "TmpQuat2")
						{
							value = this.TmpQuat2;
							return true;
						}
					}
				}
				else if (key == "Priority")
				{
					value = this.Priority;
					return true;
				}
				break;
			}
			case 9:
			{
				char c = key[6];
				if (c <= 'T')
				{
					if (c != 'F')
					{
						if (c == 'T')
						{
							if (key == "ModifyTag")
							{
								value = this.ModifyTag;
								return true;
							}
						}
					}
					else if (key == "ModifyFov")
					{
						value = this.ModifyFov;
						return true;
					}
				}
				else if (c != 'n')
				{
					if (c == 't')
					{
						if (key == "TmpVector")
						{
							value = this.TmpVector;
							return true;
						}
					}
				}
				else if (key == "AnimOwner")
				{
					value = this.AnimOwner;
					return true;
				}
				break;
			}
			case 10:
			{
				char c = key[2];
				if (c <= 'M')
				{
					if (c != 'A')
					{
						if (c == 'M')
						{
							if (key == "IsModified")
							{
								value = this.IsModified;
								return true;
							}
						}
					}
					else if (key == "IsActivate")
					{
						value = this.IsActivate;
						return true;
					}
				}
				else if (c != 'd')
				{
					if (c == 'p')
					{
						if (key == "TmpRotator")
						{
							value = this.TmpRotator;
							return true;
						}
					}
				}
				else if (key == "ModifyLens")
				{
					value = this.ModifyLens;
					return true;
				}
				break;
			}
			case 11:
			{
				char c = key[10];
				switch (c)
				{
				case '2':
					if (key == "TmpRotator2")
					{
						value = this.TmpRotator2;
						return true;
					}
					break;
				case '3':
					if (key == "TmpRotator3")
					{
						value = this.TmpRotator3;
						return true;
					}
					break;
				case '4':
					if (key == "TmpRotator4")
					{
						value = this.TmpRotator4;
						return true;
					}
					break;
				default:
					if (c == 'r')
					{
						if (key == "LookAtActor")
						{
							value = this.LookAtActor;
							return true;
						}
					}
					break;
				}
				break;
			}
			case 12:
			{
				char c = key[0];
				if (c != 'B')
				{
					if (c == 'L')
					{
						if (key == "LookAtEntity")
						{
							value = this.LookAtEntity;
							return true;
						}
					}
				}
				else if (key == "BlendOutData")
				{
					value = this.BlendOutData;
					return true;
				}
				break;
			}
			case 13:
				if (key == "ModifyMontage")
				{
					value = this.ModifyMontage;
					return true;
				}
				break;
			case 14:
			{
				char c = key[6];
				if (c <= 'I')
				{
					if (c != 'D')
					{
						if (c == 'I')
						{
							if (key == "ModifyInstance")
							{
								value = this.ModifyInstance;
								return true;
							}
						}
					}
					else if (key == "ModifyDuration")
					{
						value = this.ModifyDuration;
						return true;
					}
				}
				else if (c != 'L')
				{
					if (c != 'S')
					{
						if (c == 'a')
						{
							if (key == "OnMontageEnded")
							{
								value = this.OnMontageEnded;
								return true;
							}
						}
					}
					else if (key == "ModifySettings")
					{
						value = this.ModifySettings;
						return true;
					}
				}
				else if (key == "TargetLocation")
				{
					value = this.TargetLocation;
					return true;
				}
				break;
			}
			case 15:
			{
				char c = key[9];
				if (c <= 'O')
				{
					if (c != 'L')
					{
						if (c == 'O')
						{
							if (key == "ModifyArmOffset")
							{
								value = this.ModifyArmOffset;
								return true;
							}
						}
					}
					else if (key == "ModifyArmLength")
					{
						value = this.ModifyArmLength;
						return true;
					}
				}
				else if (c != 'a')
				{
					if (c != 'i')
					{
						if (c == 'o')
						{
							if (key == "TmpFinalRotator")
							{
								value = this.TmpFinalRotator;
								return true;
							}
						}
					}
					else if (key == "MaxAngleFixQuat")
					{
						value = this.MaxAngleFixQuat;
						return true;
					}
				}
				else if (key == "IsModifyFadeOut")
				{
					value = this.IsModifyFadeOut;
					return true;
				}
				break;
			}
			case 16:
			{
				char c = key[2];
				if (c <= 'D')
				{
					if (c != 'A')
					{
						if (c == 'D')
						{
							if (key == "IsDebugCurveEval")
							{
								value = this.IsDebugCurveEval;
								return true;
							}
						}
					}
					else if (key == "IsAimingInternal")
					{
						value = this.IsAimingInternal;
						return true;
					}
				}
				else if (c != 'M')
				{
					if (c != 'V')
					{
						if (c == 'd')
						{
							if (key == "ModifyEndContext")
							{
								value = this.ModifyEndContext;
								return true;
							}
						}
					}
					else if (key == "OnVisionMorphEnd")
					{
						value = this.OnVisionMorphEnd;
						return true;
					}
				}
				else if (key == "OnMontageStarted")
				{
					value = this.OnMontageStarted;
					return true;
				}
				break;
			}
			case 17:
			{
				char c = key[8];
				if (c <= 'l')
				{
					switch (c)
					{
					case 'a':
						if (key == "ModifyElapsedTime")
						{
							value = this.ModifyElapsedTime;
							return true;
						}
						break;
					case 'b':
						break;
					case 'c':
						if (key == "ModifyLockHandler")
						{
							value = this.ModifyLockHandler;
							return true;
						}
						break;
					case 'd':
						if (key == "ModifyFadeOutTime")
						{
							value = this.ModifyFadeOutTime;
							return true;
						}
						if (key == "ModifyFadeOutData")
						{
							value = this.ModifyFadeOutData;
							return true;
						}
						break;
					case 'e':
						if (key == "ModifyBlendInTime")
						{
							value = this.ModifyBlendInTime;
							return true;
						}
						break;
					default:
						if (c == 'l')
						{
							if (key == "CurrentBlendState")
							{
								value = this.CurrentBlendState;
								return true;
							}
						}
						break;
					}
				}
				else if (c != 'm')
				{
					switch (c)
					{
					case 'r':
						if (key == "TmpPlayerLocation")
						{
							value = this.TmpPlayerLocation;
							return true;
						}
						break;
					case 't':
						if (key == "LookAtActorSocket")
						{
							value = this.LookAtActorSocket;
							return true;
						}
						break;
					case 'v':
						if (key == "ModifyFovLagSpeed")
						{
							value = this.ModifyFovLagSpeed;
							return true;
						}
						break;
					}
				}
				else if (key == "ModifyArmRotation")
				{
					value = this.ModifyArmRotation;
					return true;
				}
				break;
			}
			case 18:
			{
				char c = key[11];
				if (c <= 'O')
				{
					if (c != 'I')
					{
						if (c == 'O')
						{
							if (key == "ModifyBlendOutTime")
							{
								value = this.ModifyBlendOutTime;
								return true;
							}
						}
					}
					else if (key == "ModifyBlendInCurve")
					{
						value = this.ModifyBlendInCurve;
						return true;
					}
				}
				else if (c != 'a')
				{
					if (c != 'e')
					{
						switch (c)
						{
						case 'i':
							if (key == "OnLookAtEntityDead")
							{
								value = this.OnLookAtEntityDead;
								return true;
							}
							break;
						case 'l':
							if (key == "StartVirtualCamera")
							{
								value = this.StartVirtualCamera;
								return true;
							}
							break;
						case 'm':
							if (key == "TmpTargetArmOffset")
							{
								value = this.TmpTargetArmOffset;
								return true;
							}
							break;
						case 'n':
							if (key == "ModifyAnimInstance")
							{
								value = this.ModifyAnimInstance;
								return true;
							}
							break;
						}
					}
					else if (key == "ModifyAnimSequence")
					{
						value = this.ModifyAnimSequence;
						return true;
					}
				}
				else if (key == "ModifyCameraOffset")
				{
					value = this.ModifyCameraOffset;
					return true;
				}
				break;
			}
			case 19:
			{
				char c = key[0];
				if (c <= 'I')
				{
					if (c != 'F')
					{
						if (c == 'I')
						{
							if (key == "IsModifyBlendingOut")
							{
								value = this.IsModifyBlendingOut;
								return true;
							}
						}
					}
					else if (key == "FadeOutStartRotator")
					{
						value = this.FadeOutStartRotator;
						return true;
					}
				}
				else if (c != 'M')
				{
					if (c == 'T')
					{
						if (key == "TargetArmRotatorYaw")
						{
							value = this.TargetArmRotatorYaw;
							return true;
						}
					}
				}
				else if (key == "ModifyBlendOutCurve")
				{
					value = this.ModifyBlendOutCurve;
					return true;
				}
				break;
			}
			case 20:
			{
				char c = key[15];
				if (c <= 'a')
				{
					if (c != 'S')
					{
						if (c == 'a')
						{
							if (key == "ModifyPlayerLocation")
							{
								value = this.ModifyPlayerLocation;
								return true;
							}
						}
					}
					else if (key == "OnCharBeforeUseSkill")
					{
						value = this.OnCharBeforeUseSkill;
						return true;
					}
				}
				else if (c != 'o')
				{
					if (c != 'r')
					{
						if (c == 't')
						{
							if (key == "TempTargetArmRotator")
							{
								value = this.TempTargetArmRotator;
								return true;
							}
						}
					}
					else if (key == "TargetArmRotatorRoll")
					{
						value = this.TargetArmRotatorRoll;
						return true;
					}
				}
				else if (key == "ModifyArmRotationYaw")
				{
					value = this.ModifyArmRotationYaw;
					return true;
				}
				break;
			}
			case 21:
			{
				char c = key[0];
				if (c != 'M')
				{
					if (c != 'S')
					{
						if (c == 'T')
						{
							if (key == "TargetArmRotatorPitch")
							{
								value = this.TargetArmRotatorPitch;
								return true;
							}
						}
					}
					else if (key == "StartTargetArmRotator")
					{
						value = this.StartTargetArmRotator;
						return true;
					}
				}
				else if (key == "ModifyArmRotationRoll")
				{
					value = this.ModifyArmRotationRoll;
					return true;
				}
				break;
			}
			case 22:
				if (key == "ModifyArmRotationPitch")
				{
					value = this.ModifyArmRotationPitch;
					return true;
				}
				break;
			case 23:
			{
				char c = key[9];
				if (c != 'L')
				{
					if (c != 'O')
					{
						if (c == 't')
						{
							if (key == "FirstStartVirtualCamera")
							{
								value = this.FirstStartVirtualCamera;
								return true;
							}
						}
					}
					else if (key == "ModifyArmOffsetLagSpeed")
					{
						value = this.ModifyArmOffsetLagSpeed;
						return true;
					}
				}
				else if (key == "ModifyArmLengthLagSpeed")
				{
					value = this.ModifyArmLengthLagSpeed;
					return true;
				}
				break;
			}
			case 24:
			{
				char c = key[0];
				if (c != 'S')
				{
					if (c == 'T')
					{
						if (key == "TmpFinalRotatorInGravity")
						{
							value = this.TmpFinalRotatorInGravity;
							return true;
						}
					}
				}
				else if (key == "StartAutoCameraArmOffset")
				{
					value = this.StartAutoCameraArmOffset;
					return true;
				}
				break;
			}
			case 25:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c != 'M')
					{
						if (c == 'O')
						{
							if (key == "OnPlayCameraLevelSequence")
							{
								value = this.OnPlayCameraLevelSequence;
								return true;
							}
						}
					}
					else if (key == "ModifyArmRotationLagSpeed")
					{
						value = this.ModifyArmRotationLagSpeed;
						return true;
					}
				}
				else if (key == "FirstModifyArmRotationYaw")
				{
					value = this.FirstModifyArmRotationYaw;
					return true;
				}
				break;
			}
			case 26:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c != 'M')
					{
						if (c == 'O')
						{
							if (key == "OnAllMontageInstancesEnded")
							{
								value = this.OnAllMontageInstancesEnded;
								return true;
							}
						}
					}
					else if (key == "ModifyCameraOffsetLagSpeed")
					{
						value = this.ModifyCameraOffsetLagSpeed;
						return true;
					}
				}
				else if (key == "FirstModifyArmRotationRoll")
				{
					value = this.FirstModifyArmRotationRoll;
					return true;
				}
				break;
			}
			case 27:
				if (key == "FirstModifyArmRotationPitch")
				{
					value = this.FirstModifyArmRotationPitch;
					return true;
				}
				break;
			case 29:
				if (key == "EnableDebugModifyZoomModifier")
				{
					value = this.EnableDebugModifyZoomModifier;
					return true;
				}
				break;
			case 30:
				if (key == "EnableDebugFadeOutZoomModifier")
				{
					value = this.EnableDebugFadeOutZoomModifier;
					return true;
				}
				break;
			case 32:
				if (key == "StartAutoCameraArmLengthAddition")
				{
					value = this.StartAutoCameraArmLengthAddition;
					return true;
				}
				break;
			case 35:
				if (key == "IsBreakPreviousPlayerLocationModify")
				{
					value = this.IsBreakPreviousPlayerLocationModify;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x000BC8E4 File Offset: 0x000BAAE4
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 8:
			{
				char c = key[0];
				if (c != 'H')
				{
					if (c != 'I')
					{
						if (c == 'P')
						{
							if (key == "Priority")
							{
								int num2;
								if (value is double)
								{
									double num = (double)value;
									num2 = (int)num;
								}
								else if (value is float)
								{
									float num3 = (float)value;
									num2 = (int)num3;
								}
								else if (value is int)
								{
									int num4 = (int)value;
									num2 = num4;
								}
								else if (value is long)
								{
									long num5 = (long)value;
									num2 = (int)num5;
								}
								else
								{
									num2 = (int)value;
								}
								this.Priority = num2;
								return;
							}
						}
					}
					else if (key == "IsAiming")
					{
						this.IsAiming = (bool)value;
						return;
					}
				}
				else if (key == "HasInput")
				{
					this.HasInput = (bool)value;
					return;
				}
				break;
			}
			case 9:
			{
				char c = key[6];
				if (c != 'F')
				{
					if (c != 'T')
					{
						if (c == 'n')
						{
							if (key == "AnimOwner")
							{
								this.AnimOwner = (OneOf<TsBaseCharacter, TsBaseVehicle>)value;
								return;
							}
						}
					}
					else if (key == "ModifyTag")
					{
						this.ModifyTag = (FGameplayTag?)value;
						return;
					}
				}
				else if (key == "ModifyFov")
				{
					this.ModifyFov = (bool)value;
					return;
				}
				break;
			}
			case 10:
				if (key == "ModifyLens")
				{
					this.ModifyLens = (bool)value;
					return;
				}
				break;
			case 11:
				if (key == "LookAtActor")
				{
					this.LookAtActor = (OneOf<TsBaseCharacter, TsBaseVehicle>)value;
					return;
				}
				break;
			case 12:
				if (key == "LookAtEntity")
				{
					this.LookAtEntity = (Entity)value;
					return;
				}
				break;
			case 13:
				if (key == "ModifyMontage")
				{
					this.ModifyMontage = (UAnimMontage)value;
					return;
				}
				break;
			case 14:
			{
				char c = key[6];
				if (c != 'D')
				{
					if (c != 'I')
					{
						if (c == 'S')
						{
							if (key == "ModifySettings")
							{
								this.ModifySettings = (CameraModify)value;
								return;
							}
						}
					}
					else if (key == "ModifyInstance")
					{
						int num2;
						if (value is double)
						{
							double num6 = (double)value;
							num2 = (int)num6;
						}
						else if (value is float)
						{
							float num7 = (float)value;
							num2 = (int)num7;
						}
						else if (value is int)
						{
							int num8 = (int)value;
							num2 = num8;
						}
						else if (value is long)
						{
							long num9 = (long)value;
							num2 = (int)num9;
						}
						else
						{
							num2 = (int)value;
						}
						this.ModifyInstance = num2;
						return;
					}
				}
				else if (key == "ModifyDuration")
				{
					float num11;
					if (value is double)
					{
						double num10 = (double)value;
						num11 = (float)num10;
					}
					else if (value is float)
					{
						float num12 = (float)value;
						num11 = num12;
					}
					else if (value is int)
					{
						int num13 = (int)value;
						num11 = (float)num13;
					}
					else if (value is long)
					{
						long num14 = (long)value;
						num11 = (float)num14;
					}
					else
					{
						num11 = (float)value;
					}
					this.ModifyDuration = num11;
					return;
				}
				break;
			}
			case 15:
			{
				char c = key[9];
				if (c != 'L')
				{
					if (c != 'O')
					{
						if (c == 'a')
						{
							if (key == "IsModifyFadeOut")
							{
								this.IsModifyFadeOut = (bool)value;
								return;
							}
						}
					}
					else if (key == "ModifyArmOffset")
					{
						this.ModifyArmOffset = (bool)value;
						return;
					}
				}
				else if (key == "ModifyArmLength")
				{
					this.ModifyArmLength = (bool)value;
					return;
				}
				break;
			}
			case 16:
			{
				char c = key[2];
				if (c != 'A')
				{
					if (c == 'D')
					{
						if (key == "IsDebugCurveEval")
						{
							this.IsDebugCurveEval = (bool)value;
							return;
						}
					}
				}
				else if (key == "IsAimingInternal")
				{
					this.IsAimingInternal = (bool)value;
					return;
				}
				break;
			}
			case 17:
			{
				char c = key[8];
				if (c <= 'l')
				{
					switch (c)
					{
					case 'a':
						if (key == "ModifyElapsedTime")
						{
							float num11;
							if (value is double)
							{
								double num15 = (double)value;
								num11 = (float)num15;
							}
							else if (value is float)
							{
								float num16 = (float)value;
								num11 = num16;
							}
							else if (value is int)
							{
								int num17 = (int)value;
								num11 = (float)num17;
							}
							else if (value is long)
							{
								long num18 = (long)value;
								num11 = (float)num18;
							}
							else
							{
								num11 = (float)value;
							}
							this.ModifyElapsedTime = num11;
							return;
						}
						break;
					case 'b':
					case 'c':
						break;
					case 'd':
						if (key == "ModifyFadeOutTime")
						{
							float num11;
							if (value is double)
							{
								double num19 = (double)value;
								num11 = (float)num19;
							}
							else if (value is float)
							{
								float num20 = (float)value;
								num11 = num20;
							}
							else if (value is int)
							{
								int num21 = (int)value;
								num11 = (float)num21;
							}
							else if (value is long)
							{
								long num22 = (long)value;
								num11 = (float)num22;
							}
							else
							{
								num11 = (float)value;
							}
							this.ModifyFadeOutTime = num11;
							return;
						}
						break;
					case 'e':
						if (key == "ModifyBlendInTime")
						{
							float num11;
							if (value is double)
							{
								double num23 = (double)value;
								num11 = (float)num23;
							}
							else if (value is float)
							{
								float num24 = (float)value;
								num11 = num24;
							}
							else if (value is int)
							{
								int num25 = (int)value;
								num11 = (float)num25;
							}
							else if (value is long)
							{
								long num26 = (long)value;
								num11 = (float)num26;
							}
							else
							{
								num11 = (float)value;
							}
							this.ModifyBlendInTime = num11;
							return;
						}
						break;
					default:
						if (c == 'l')
						{
							if (key == "CurrentBlendState")
							{
								this.CurrentBlendState = (EBlendState)value;
								return;
							}
						}
						break;
					}
				}
				else if (c != 't')
				{
					if (c == 'v')
					{
						if (key == "ModifyFovLagSpeed")
						{
							float num11;
							if (value is double)
							{
								double num27 = (double)value;
								num11 = (float)num27;
							}
							else if (value is float)
							{
								float num28 = (float)value;
								num11 = num28;
							}
							else if (value is int)
							{
								int num29 = (int)value;
								num11 = (float)num29;
							}
							else if (value is long)
							{
								long num30 = (long)value;
								num11 = (float)num30;
							}
							else
							{
								num11 = (float)value;
							}
							this.ModifyFovLagSpeed = num11;
							return;
						}
					}
				}
				else if (key == "LookAtActorSocket")
				{
					this.LookAtActorSocket = (string)value;
					return;
				}
				break;
			}
			case 18:
			{
				char c = key[11];
				if (c <= 'O')
				{
					if (c != 'I')
					{
						if (c == 'O')
						{
							if (key == "ModifyBlendOutTime")
							{
								float num11;
								if (value is double)
								{
									double num31 = (double)value;
									num11 = (float)num31;
								}
								else if (value is float)
								{
									float num32 = (float)value;
									num11 = num32;
								}
								else if (value is int)
								{
									int num33 = (int)value;
									num11 = (float)num33;
								}
								else if (value is long)
								{
									long num34 = (long)value;
									num11 = (float)num34;
								}
								else
								{
									num11 = (float)value;
								}
								this.ModifyBlendOutTime = num11;
								return;
							}
						}
					}
					else if (key == "ModifyBlendInCurve")
					{
						this.ModifyBlendInCurve = (CurveBase)value;
						return;
					}
				}
				else if (c != 'a')
				{
					if (c != 'e')
					{
						if (c == 'n')
						{
							if (key == "ModifyAnimInstance")
							{
								this.ModifyAnimInstance = (UAnimInstance)value;
								return;
							}
						}
					}
					else if (key == "ModifyAnimSequence")
					{
						this.ModifyAnimSequence = (UAnimSequenceBase)value;
						return;
					}
				}
				else if (key == "ModifyCameraOffset")
				{
					this.ModifyCameraOffset = (bool)value;
					return;
				}
				break;
			}
			case 19:
			{
				char c = key[0];
				if (c != 'I')
				{
					if (c != 'M')
					{
						if (c == 'T')
						{
							if (key == "TargetArmRotatorYaw")
							{
								float num11;
								if (value is double)
								{
									double num35 = (double)value;
									num11 = (float)num35;
								}
								else if (value is float)
								{
									float num36 = (float)value;
									num11 = num36;
								}
								else if (value is int)
								{
									int num37 = (int)value;
									num11 = (float)num37;
								}
								else if (value is long)
								{
									long num38 = (long)value;
									num11 = (float)num38;
								}
								else
								{
									num11 = (float)value;
								}
								this.TargetArmRotatorYaw = num11;
								return;
							}
						}
					}
					else if (key == "ModifyBlendOutCurve")
					{
						this.ModifyBlendOutCurve = (CurveBase)value;
						return;
					}
				}
				else if (key == "IsModifyBlendingOut")
				{
					this.IsModifyBlendingOut = (bool)value;
					return;
				}
				break;
			}
			case 20:
			{
				char c = key[14];
				if (c != 'c')
				{
					if (c != 'i')
					{
						if (c == 'o')
						{
							if (key == "TargetArmRotatorRoll")
							{
								float num11;
								if (value is double)
								{
									double num39 = (double)value;
									num11 = (float)num39;
								}
								else if (value is float)
								{
									float num40 = (float)value;
									num11 = num40;
								}
								else if (value is int)
								{
									int num41 = (int)value;
									num11 = (float)num41;
								}
								else if (value is long)
								{
									long num42 = (long)value;
									num11 = (float)num42;
								}
								else
								{
									num11 = (float)value;
								}
								this.TargetArmRotatorRoll = num11;
								return;
							}
						}
					}
					else if (key == "ModifyArmRotationYaw")
					{
						this.ModifyArmRotationYaw = (bool)value;
						return;
					}
				}
				else if (key == "ModifyPlayerLocation")
				{
					this.ModifyPlayerLocation = (bool)value;
					return;
				}
				break;
			}
			case 21:
			{
				char c = key[0];
				if (c != 'M')
				{
					if (c == 'T')
					{
						if (key == "TargetArmRotatorPitch")
						{
							float num11;
							if (value is double)
							{
								double num43 = (double)value;
								num11 = (float)num43;
							}
							else if (value is float)
							{
								float num44 = (float)value;
								num11 = num44;
							}
							else if (value is int)
							{
								int num45 = (int)value;
								num11 = (float)num45;
							}
							else if (value is long)
							{
								long num46 = (long)value;
								num11 = (float)num46;
							}
							else
							{
								num11 = (float)value;
							}
							this.TargetArmRotatorPitch = num11;
							return;
						}
					}
				}
				else if (key == "ModifyArmRotationRoll")
				{
					this.ModifyArmRotationRoll = (bool)value;
					return;
				}
				break;
			}
			case 22:
				if (key == "ModifyArmRotationPitch")
				{
					this.ModifyArmRotationPitch = (bool)value;
					return;
				}
				break;
			case 23:
			{
				char c = key[9];
				if (c != 'L')
				{
					if (c == 'O')
					{
						if (key == "ModifyArmOffsetLagSpeed")
						{
							float num11;
							if (value is double)
							{
								double num47 = (double)value;
								num11 = (float)num47;
							}
							else if (value is float)
							{
								float num48 = (float)value;
								num11 = num48;
							}
							else if (value is int)
							{
								int num49 = (int)value;
								num11 = (float)num49;
							}
							else if (value is long)
							{
								long num50 = (long)value;
								num11 = (float)num50;
							}
							else
							{
								num11 = (float)value;
							}
							this.ModifyArmOffsetLagSpeed = num11;
							return;
						}
					}
				}
				else if (key == "ModifyArmLengthLagSpeed")
				{
					float num11;
					if (value is double)
					{
						double num51 = (double)value;
						num11 = (float)num51;
					}
					else if (value is float)
					{
						float num52 = (float)value;
						num11 = num52;
					}
					else if (value is int)
					{
						int num53 = (int)value;
						num11 = (float)num53;
					}
					else if (value is long)
					{
						long num54 = (long)value;
						num11 = (float)num54;
					}
					else
					{
						num11 = (float)value;
					}
					this.ModifyArmLengthLagSpeed = num11;
					return;
				}
				break;
			}
			case 25:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'M')
					{
						if (key == "ModifyArmRotationLagSpeed")
						{
							float num11;
							if (value is double)
							{
								double num55 = (double)value;
								num11 = (float)num55;
							}
							else if (value is float)
							{
								float num56 = (float)value;
								num11 = num56;
							}
							else if (value is int)
							{
								int num57 = (int)value;
								num11 = (float)num57;
							}
							else if (value is long)
							{
								long num58 = (long)value;
								num11 = (float)num58;
							}
							else
							{
								num11 = (float)value;
							}
							this.ModifyArmRotationLagSpeed = num11;
							return;
						}
					}
				}
				else if (key == "FirstModifyArmRotationYaw")
				{
					this.FirstModifyArmRotationYaw = (bool)value;
					return;
				}
				break;
			}
			case 26:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'M')
					{
						if (key == "ModifyCameraOffsetLagSpeed")
						{
							float num11;
							if (value is double)
							{
								double num59 = (double)value;
								num11 = (float)num59;
							}
							else if (value is float)
							{
								float num60 = (float)value;
								num11 = num60;
							}
							else if (value is int)
							{
								int num61 = (int)value;
								num11 = (float)num61;
							}
							else if (value is long)
							{
								long num62 = (long)value;
								num11 = (float)num62;
							}
							else
							{
								num11 = (float)value;
							}
							this.ModifyCameraOffsetLagSpeed = num11;
							return;
						}
					}
				}
				else if (key == "FirstModifyArmRotationRoll")
				{
					this.FirstModifyArmRotationRoll = (bool)value;
					return;
				}
				break;
			}
			case 27:
				if (key == "FirstModifyArmRotationPitch")
				{
					this.FirstModifyArmRotationPitch = (bool)value;
					return;
				}
				break;
			case 29:
				if (key == "EnableDebugModifyZoomModifier")
				{
					this.EnableDebugModifyZoomModifier = (bool)value;
					return;
				}
				break;
			case 30:
				if (key == "EnableDebugFadeOutZoomModifier")
				{
					this.EnableDebugFadeOutZoomModifier = (bool)value;
					return;
				}
				break;
			case 32:
				if (key == "StartAutoCameraArmLengthAddition")
				{
					float num11;
					if (value is double)
					{
						double num63 = (double)value;
						num11 = (float)num63;
					}
					else if (value is float)
					{
						float num64 = (float)value;
						num11 = num64;
					}
					else if (value is int)
					{
						int num65 = (int)value;
						num11 = (float)num65;
					}
					else if (value is long)
					{
						long num66 = (long)value;
						num11 = (float)num66;
					}
					else
					{
						num11 = (float)value;
					}
					this.StartAutoCameraArmLengthAddition = num11;
					return;
				}
				break;
			case 35:
				if (key == "IsBreakPreviousPlayerLocationModify")
				{
					this.IsBreakPreviousPlayerLocationModify = (bool)value;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x000BD871 File Offset: 0x000BBA71
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraModifyController.<MemberIter>d__149 <MemberIter>d__ = new CameraModifyController.<MemberIter>d__149(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x0400157B RID: 5499
	private const int MODIFY_SMALL_LENGTH = 1;

	// Token: 0x0400157C RID: 5500
	private const int INVALID_MODIFY_INSTANCE = -1;

	// Token: 0x0400157D RID: 5501
	[StaticVariableRuleIgnore]
	private static readonly int BanForcePlayModify = GameplayTagDefine.EGameplayTagId["功能.通用镜头.屏蔽modify强制生效"];

	// Token: 0x0400157E RID: 5502
	public float ModifyArmLengthLagSpeed;

	// Token: 0x0400157F RID: 5503
	public float ModifyArmOffsetLagSpeed;

	// Token: 0x04001580 RID: 5504
	public float ModifyCameraOffsetLagSpeed;

	// Token: 0x04001581 RID: 5505
	public float ModifyArmRotationLagSpeed;

	// Token: 0x04001582 RID: 5506
	public float ModifyFovLagSpeed;

	// Token: 0x04001583 RID: 5507
	public int ModifyInstance;

	// Token: 0x04001584 RID: 5508
	private float ModifyElapsedTime;

	// Token: 0x04001585 RID: 5509
	private FGameplayTag? ModifyTag;

	// Token: 0x04001586 RID: 5510
	private float ModifyDuration;

	// Token: 0x04001587 RID: 5511
	private float ModifyBlendInTime;

	// Token: 0x04001588 RID: 5512
	private float ModifyBlendOutTime;

	// Token: 0x04001589 RID: 5513
	private float ModifyFadeOutTime;

	// Token: 0x0400158A RID: 5514
	private bool IsBreakPreviousPlayerLocationModify;

	// Token: 0x0400158B RID: 5515
	[Nullable(2)]
	private CurveBase ModifyBlendInCurve;

	// Token: 0x0400158C RID: 5516
	[Nullable(2)]
	private CurveBase ModifyBlendOutCurve;

	// Token: 0x0400158D RID: 5517
	private bool IsModifyBlendingOut;

	// Token: 0x0400158E RID: 5518
	public bool IsModifyFadeOut;

	// Token: 0x0400158F RID: 5519
	public EBlendState CurrentBlendState;

	// Token: 0x04001590 RID: 5520
	public readonly CameraFadeOutData ModifyFadeOutData = new CameraFadeOutData();

	// Token: 0x04001591 RID: 5521
	[Nullable(2)]
	public CameraModify ModifySettings;

	// Token: 0x04001592 RID: 5522
	[Nullable(2)]
	private UAnimSequenceBase ModifyAnimSequence;

	// Token: 0x04001593 RID: 5523
	[Nullable(2)]
	public UAnimMontage ModifyMontage;

	// Token: 0x04001594 RID: 5524
	[Nullable(2)]
	private UAnimInstance ModifyAnimInstance;

	// Token: 0x04001595 RID: 5525
	public bool ModifyArmLength;

	// Token: 0x04001596 RID: 5526
	public bool ModifyArmOffset;

	// Token: 0x04001597 RID: 5527
	private bool ModifyCameraOffset;

	// Token: 0x04001598 RID: 5528
	private bool ModifyArmRotationPitch;

	// Token: 0x04001599 RID: 5529
	private bool ModifyArmRotationYaw;

	// Token: 0x0400159A RID: 5530
	private bool ModifyArmRotationRoll;

	// Token: 0x0400159B RID: 5531
	private bool ModifyPlayerLocation;

	// Token: 0x0400159C RID: 5532
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private OneOf<TsBaseCharacter, TsBaseVehicle> AnimOwner;

	// Token: 0x0400159D RID: 5533
	[Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private OneOf<TsBaseCharacter, TsBaseVehicle> LookAtActor;

	// Token: 0x0400159E RID: 5534
	[Nullable(2)]
	private Entity LookAtEntity;

	// Token: 0x0400159F RID: 5535
	private string LookAtActorSocket = "";

	// Token: 0x040015A0 RID: 5536
	private readonly Vector TargetLocation = Vector.Create();

	// Token: 0x040015A1 RID: 5537
	private readonly Vector TmpPlayerLocation = Vector.Create();

	// Token: 0x040015A2 RID: 5538
	private bool ModifyFov;

	// Token: 0x040015A3 RID: 5539
	private bool ModifyLens;

	// Token: 0x040015A4 RID: 5540
	private bool HasInput;

	// Token: 0x040015A5 RID: 5541
	private bool FirstModifyArmRotationPitch = true;

	// Token: 0x040015A6 RID: 5542
	private bool FirstModifyArmRotationYaw = true;

	// Token: 0x040015A7 RID: 5543
	private bool FirstModifyArmRotationRoll = true;

	// Token: 0x040015A8 RID: 5544
	private readonly Quat MaxAngleFixQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040015A9 RID: 5545
	private float TargetArmRotatorPitch;

	// Token: 0x040015AA RID: 5546
	private float TargetArmRotatorYaw;

	// Token: 0x040015AB RID: 5547
	private float TargetArmRotatorRoll;

	// Token: 0x040015AC RID: 5548
	private readonly ModifyEndContext ModifyEndContext = new ModifyEndContext();

	// Token: 0x040015AD RID: 5549
	private readonly Rotator TempTargetArmRotator = Rotator.Create();

	// Token: 0x040015AE RID: 5550
	private readonly Rotator StartTargetArmRotator = Rotator.Create();

	// Token: 0x040015AF RID: 5551
	private readonly Rotator FadeOutStartRotator = Rotator.Create();

	// Token: 0x040015B0 RID: 5552
	private readonly Vector TmpTargetArmOffset = Vector.Create();

	// Token: 0x040015B1 RID: 5553
	private readonly Rotator TmpFinalRotator = Rotator.Create();

	// Token: 0x040015B2 RID: 5554
	private readonly Rotator TmpFinalRotatorInGravity = Rotator.Create();

	// Token: 0x040015B3 RID: 5555
	private readonly VirtualCamera FirstStartVirtualCamera = new VirtualCamera();

	// Token: 0x040015B4 RID: 5556
	private readonly VirtualCamera StartVirtualCamera = new VirtualCamera();

	// Token: 0x040015B5 RID: 5557
	private float StartAutoCameraArmLengthAddition;

	// Token: 0x040015B6 RID: 5558
	private readonly Vector StartAutoCameraArmOffset = Vector.Create();

	// Token: 0x040015B7 RID: 5559
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x040015B8 RID: 5560
	private readonly Rotator TmpRotator2 = Rotator.Create();

	// Token: 0x040015B9 RID: 5561
	private readonly Rotator TmpRotator3 = Rotator.Create();

	// Token: 0x040015BA RID: 5562
	private readonly Rotator TmpRotator4 = Rotator.Create();

	// Token: 0x040015BB RID: 5563
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040015BC RID: 5564
	private readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040015BD RID: 5565
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x040015BE RID: 5566
	private bool EnableDebugModifyZoomModifier = true;

	// Token: 0x040015BF RID: 5567
	private bool EnableDebugFadeOutZoomModifier = true;

	// Token: 0x040015C0 RID: 5568
	public bool IsDebugCurveEval;

	// Token: 0x040015C1 RID: 5569
	private readonly CameraBlendOutData BlendOutData = new CameraBlendOutData();

	// Token: 0x040015C2 RID: 5570
	private readonly Action OnAllMontageInstancesEnded;

	// Token: 0x040015C3 RID: 5571
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Action<UAnimMontage, bool> OnMontageEnded;

	// Token: 0x040015C4 RID: 5572
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Action<UAnimMontage> OnMontageStarted;

	// Token: 0x040015C5 RID: 5573
	private readonly Action<int> OnLookAtEntityDead;

	// Token: 0x040015C6 RID: 5574
	[Nullable(new byte[]
	{
		1,
		2,
		2
	})]
	private readonly Action<EntityHandle, EntityHandle> OnVisionMorphEnd;

	// Token: 0x040015C7 RID: 5575
	private readonly Action<ULevelSequence, AActor, ALevelSequenceActor, FTransformDouble, bool, bool, string> OnPlayCameraLevelSequence;

	// Token: 0x040015C8 RID: 5576
	private readonly Action<int, int, bool> OnCharBeforeUseSkill;

	// Token: 0x040015C9 RID: 5577
	private bool IsAimingInternal;

	// Token: 0x040015CA RID: 5578
	private readonly UniqueLockingHandler<EModifyInternalLockReason> ModifyLockHandler = new UniqueLockingHandler<EModifyInternalLockReason>();

	// Token: 0x040015CB RID: 5579
	private int Priority;
}
