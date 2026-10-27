using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x0200020F RID: 527
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true)]
public class CameraInputController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x060020B7 RID: 8375 RVA: 0x000B1B1C File Offset: 0x000AFD1C
	public CameraInputController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x17000502 RID: 1282
	// (get) Token: 0x060020B8 RID: 8376 RVA: 0x000B1C7C File Offset: 0x000AFE7C
	protected bool IsAiming
	{
		get
		{
			if (DeadEyeModeModel.Instance.IsInDeadEyeMode)
			{
				return !Info.Instance.IsInTouch();
			}
			return this.Camera.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.方向状态.瞄准方向"], false) || this.Camera.ContainsTag(GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.显示准星"], false);
		}
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x000B1CDD File Offset: 0x000AFEDD
	public override string Name()
	{
		return "InputController";
	}

	// Token: 0x060020BA RID: 8378 RVA: 0x000B1CE4 File Offset: 0x000AFEE4
	protected override void OnInit()
	{
		base.SetConfigMap(EFightCameraInput.滚轮轴影响臂长系数, "ZoomSpeed");
		base.SetConfigMap(EFightCameraInput.滚轮轴影响臂长系数_手柄, "GamePadZoomSpeed");
		base.SetConfigMap(EFightCameraInput.镜头输入速率Min, "InputSpeedMin");
		base.SetConfigMap(EFightCameraInput.镜头输入速率Max, "InputSpeedMax");
		base.SetConfigMap(EFightCameraInput.镜头输入缓冲系数最小值, "SmoothFactorMin");
		base.SetConfigMap(EFightCameraInput.镜头输入缓冲系数最大值, "SmoothFactorMax");
		base.SetConfigMap(EFightCameraInput.镜头输入缓冲系数输入极值, "SmoothFactorRange");
		base.SetCurveConfigMap(EFightCameraInput.镜头输入缓冲系数输入极值, "SmoothFactorCurve");
		base.SetConfigMap(EFightCameraInput.镜头输入缓冲系数最小值_手柄_, "GamePadSmoothFactorMin");
		base.SetConfigMap(EFightCameraInput.镜头输入缓冲系数最大值_手柄_, "GamePadSmoothFactorMax");
		base.SetConfigMap(EFightCameraInput.镜头输入缓冲系数输入极值_手柄_, "GamePadSmoothFactorRange");
		base.SetCurveConfigMap(EFightCameraInput.镜头输入缓冲系数输入极值_手柄_, "GamePadSmoothFactorCurve");
		base.SetConfigMap(EFightCameraInput.镜头Yaw灵敏度系数最小值, "SensitivityYawMin");
		base.SetConfigMap(EFightCameraInput.镜头Yaw灵敏度系数最大值, "SensitivityYawMax");
		base.SetConfigMap(EFightCameraInput.镜头Yaw灵敏度系数输入极值, "SensitivityYawRange");
		base.SetCurveConfigMap(EFightCameraInput.镜头Yaw灵敏度系数输入极值, "SensitivityYawCurve");
		base.SetConfigMap(EFightCameraInput.镜头Pitch灵敏度系数最小值, "SensitivityPitchMin");
		base.SetConfigMap(EFightCameraInput.镜头Pitch灵敏度系数最大值, "SensitivityPitchMax");
		base.SetConfigMap(EFightCameraInput.镜头Pitch灵敏度系数输入极值, "SensitivityPitchRange");
		base.SetCurveConfigMap(EFightCameraInput.镜头Pitch灵敏度系数输入极值, "SensitivityPitchCurve");
		base.SetConfigMap(EFightCameraInput.倍化手柄输入倍率, "GamepadInputRate");
		base.SetConfigMap(EFightCameraInput.特定镜头Yaw灵敏度, "SpecificCameraBaseYawSensitivity");
		base.SetConfigMap(EFightCameraInput.特定镜头Pitch灵敏度, "SpecificCameraBasePitchSensitivity");
		base.SetConfigMap(EFightCameraInput.特定瞄准镜头Yaw灵敏度, "SpecificCameraAimingYawSensitivity");
		base.SetConfigMap(EFightCameraInput.特定瞄准镜头Pitch灵敏度, "SpecificCameraAimingPitchSensitivity");
		base.SetConfigMap(EFightCameraInput.辅助瞄准中心速度, "AimAssistSpeedCenter");
		base.SetConfigMap(EFightCameraInput.辅助瞄准边缘速度, "AimAssistSpeedEdge");
		base.SetConfigMap(EFightCameraInput.辅助瞄准最远距离, "AimAssistRange");
		base.SetConfigMap(EFightCameraInput.辅助瞄准阻尼系数, "AimAssistDamping");
		base.SetCurveConfigMap(EFightCameraInput.辅助瞄准最远距离, "AimAssistCurve");
		base.SetConfigMap(EFightCameraInput.进入瞄准模式时长, "AimAssistStartTimeLength");
		base.SetConfigMap(EFightCameraInput.进入瞄准模式速度初始值, "AimAssistStartSpeedBegin");
		base.SetConfigMap(EFightCameraInput.进入瞄准模式速度结束值, "AimAssistStartSpeedEnd");
		base.SetCurveConfigMap(EFightCameraInput.进入瞄准模式时长, "AimAssistStartCurve");
		base.RegisterPairConfigKey(EFightCameraInput.镜头输入缓冲系数最小值, EFightCameraInput.镜头输入缓冲系数最大值, false);
		base.RegisterPairConfigKey(EFightCameraInput.镜头输入速率Min, EFightCameraInput.镜头输入速率Max, true);
		base.RegisterPairConfigKey(EFightCameraInput.镜头Pitch灵敏度系数最小值, EFightCameraInput.镜头Pitch灵敏度系数最大值, true);
		base.RegisterPairConfigKey(EFightCameraInput.镜头Yaw灵敏度系数最小值, EFightCameraInput.镜头Yaw灵敏度系数最大值, true);
		base.RegisterPairConfigKey(EFightCameraInput.镜头输入缓冲系数最小值_手柄_, EFightCameraInput.镜头输入缓冲系数最大值_手柄_, false);
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x000B1FB0 File Offset: 0x000B01B0
	public override void OnStart()
	{
		base.OnStart();
		this.LineTrace = new UTraceLineElement();
		this.LineTrace.bIsSingle = false;
		this.LineTrace.bIgnoreSelf = true;
		this.LineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldStatic);
		this.LineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.WorldDynamic);
		this.LineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.Pawn);
		this.LineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnPlayer);
		this.LineTrace.AddObjectTypeQuery(KuroObjectTypeQuery.PawnMonster);
		TraceElementCommon.Instance.SetTraceColor(this.LineTrace, ColorUtils.LinearGreen);
		TraceElementCommon.Instance.SetTraceHitColor(this.LineTrace, ColorUtils.LinearRed);
		this.UpdateCameraParam();
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x000B2066 File Offset: 0x000B0266
	protected override void OnDisable()
	{
		this.AimTime = 0f;
		this.CurrentInputPitch = 0f;
		this.CurrentInputYaw = 0f;
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x000B208C File Offset: 0x000B028C
	protected unsafe override void UpdateInternal(float deltaTime)
	{
		FightCameraLogicComponent camera = this.Camera;
		int num = 2;
		List<int> list = new List<int>(num);
		CollectionsMarshal.SetCount<int>(list, num);
		Span<int> span = CollectionsMarshal.AsSpan<int>(list);
		int num2 = 0;
		*span[num2] = GameplayTagDefine.EGameplayTagId["行为状态.方向状态.注视方向"];
		num2++;
		*span[num2] = GameplayTagDefine.EGameplayTagId["行为状态.方向状态.看向方向"];
		bool flag = camera.ContainsAnyTag(list, false);
		if (this.Camera.TargetEntity == null || !this.Camera.IsTargetLocationValid || (!flag && this.Camera.CameraFocusController.CanMoveCameraInSoftLock()))
		{
			this.UpdateLookUpInput(deltaTime);
		}
		this.UpdateZoomInput(deltaTime);
		this.NormalizedCameraModifier();
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x000B2135 File Offset: 0x000B0335
	public void LockArmRotationYaw(object control)
	{
		this.ArmRotationYawBlockSet.Add(control);
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x000B2144 File Offset: 0x000B0344
	public void LockArmRotationPitch(object control)
	{
		this.ArmRotationPitchBlockSet.Add(control);
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x000B2153 File Offset: 0x000B0353
	public void UnlockArmRotationYaw(object control)
	{
		this.ArmRotationYawBlockSet.Remove(control);
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x000B2162 File Offset: 0x000B0362
	public void UnlockArmRotationPitch(object control)
	{
		this.ArmRotationPitchBlockSet.Remove(control);
	}

	// Token: 0x060020C2 RID: 8386 RVA: 0x000B2171 File Offset: 0x000B0371
	public void LockArmLength(object control)
	{
		this.ArmLengthBlockSet.Add(control);
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x000B2180 File Offset: 0x000B0380
	public void UnlockArmLength(object control)
	{
		this.ArmLengthBlockSet.Remove(control);
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000B218F File Offset: 0x000B038F
	public void SetInputEnable(object handler, bool bVisible)
	{
		this.InputEnable.SetActive(handler, bVisible);
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000B21A0 File Offset: 0x000B03A0
	private void UpdateLookUpInput(float deltaTime)
	{
		EntityHandle characterEntityHandle = this.Camera.CharacterEntityHandle;
		if (characterEntityHandle == null || !characterEntityHandle.IsInit)
		{
			this.AimTime = 0f;
			return;
		}
		if (this.Camera.CharacterController == null)
		{
			this.AimTime = 0f;
			return;
		}
		if (!this.InputEnable.Active)
		{
			this.AimTime = 0f;
			return;
		}
		this.IsModifiedYaw = false;
		this.IsModifiedPitch = false;
		Rotator armRotation = this.Camera.CurrentCamera.ArmRotation;
		ValueTuple<float, float> cameraInput = characterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetCameraInput();
		float num = cameraInput.Item1;
		float num2 = cameraInput.Item2;
		if (this.IsInGamepad())
		{
			num *= this.GamepadInputRate;
			num2 *= this.GamepadInputRate;
		}
		else if (Info.Instance.IsInKeyBoard())
		{
			num *= CharacterModel.Instance.SelfCenteredTimeDilation;
			num2 *= CharacterModel.Instance.SelfCenteredTimeDilation;
			num /= 60f;
			num2 /= 60f;
		}
		else if (this.IsInTouch())
		{
			num *= 180f * this.MobileDensityYawScale;
			num2 *= 180f * this.MobileDensityPitchScale;
		}
		CameraModelInstance cameraModel = base.CameraModel;
		if (this.IsAiming)
		{
			num *= cameraModel.CameraAimingYawSensitivityInputModifier;
			num2 *= cameraModel.CameraAimingPitchSensitivityInputModifier;
		}
		else
		{
			num *= cameraModel.CameraBaseYawSensitivityInputModifier;
			num2 *= cameraModel.CameraBasePitchSensitivityInputModifier;
		}
		float num3 = (float)Math.Sqrt((double)(num * num + num2 * num2));
		num *= MathUtils.Instance.Lerp(this.SensitivityYawMin, this.SensitivityYawMax, this.SensitivityYawCurve.GetCurrentValue(num3 / this.SensitivityYawRange)) * (this.IsInTouch() ? 0.016666f : Math.Min(deltaTime, 0.033333f));
		num2 *= MathUtils.Instance.Lerp(this.SensitivityPitchMin, this.SensitivityPitchMax, this.SensitivityPitchCurve.GetCurrentValue(num3 / this.SensitivityPitchRange)) * (this.IsInTouch() ? 0.016666f : Math.Min(deltaTime, 0.033333f));
		this.ChangedSelectedAimPart = false;
		bool flag = this.ShouldAimAssist(deltaTime, num != 0f || num2 != 0f);
		if (flag)
		{
			num *= 1f - this.AimAssistDamping;
			num2 *= 1f - this.AimAssistDamping;
		}
		float normalizedSmoothFactor = this.GetNormalizedSmoothFactor(num3, deltaTime);
		this.CurrentInputYaw = this.CurrentInputYaw * normalizedSmoothFactor + num * (1f - normalizedSmoothFactor);
		this.CurrentInputPitch = this.CurrentInputPitch * normalizedSmoothFactor + num2 * (1f - normalizedSmoothFactor);
		this.CurrentInputYaw = MathUtils.Instance.Clamp(this.CurrentInputYaw, -this.InputSpeedMax, this.InputSpeedMax);
		this.CurrentInputPitch = MathUtils.Instance.Clamp(this.CurrentInputPitch, -this.InputSpeedMax, this.InputSpeedMax);
		if (this.Camera.CameraCollision.CurrentBlendState == ECollisionBlendState.BlendIn)
		{
			if (this.Camera.CameraCollision.IsLeftCollision && this.CurrentInputYaw > 0f)
			{
				this.CurrentInputYaw = 0f;
			}
			else if (this.Camera.CameraCollision.IsRightCollision && this.CurrentInputYaw < 0f)
			{
				this.CurrentInputYaw = 0f;
			}
		}
		this.InputSpeedPercentage = Math.Abs(this.CurrentInputYaw / this.InputSpeedMax);
		this.TmpRotator.DeepCopy(armRotation);
		this.TmpRotator.Quaternion(this.TmpQuat);
		if (this.ArmRotationYawBlockSet.Count == 0 && !MathUtils.Instance.IsNearlyZero((double)this.CurrentInputYaw, new double?((double)this.InputSpeedMin)))
		{
			this.IsModifiedYaw = true;
			this.Camera.IsModifiedArmRotationYaw = true;
			if (this.Camera.IsInNormalGravityMode())
			{
				this.TmpRotator.Yaw = MathUtils.Instance.WrapAngle(this.TmpRotator.Yaw + this.CurrentInputYaw * this.Camera.CharacterController.InputYawScale);
			}
			else
			{
				Quat.ConstructorByAxisAngle(this.Camera.GravityUp, this.CurrentInputYaw * this.Camera.CharacterController.InputYawScale * 0.017453292f, this.TmpQuat2);
				this.TmpQuat2.Multiply(this.TmpQuat, this.TmpQuat3);
				this.TmpQuat.DeepCopy(this.TmpQuat3);
			}
		}
		if (this.ArmRotationPitchBlockSet.Count == 0 && !MathUtils.Instance.IsNearlyZero((double)this.CurrentInputPitch, new double?((double)this.InputSpeedMin)))
		{
			this.IsModifiedPitch = true;
			this.Camera.IsModifiedArmRotationPitch = true;
			float cameraPitchInGravity = this.Camera.GetCameraPitchInGravity();
			float num4 = MathUtils.Instance.Clamp(cameraPitchInGravity + this.CurrentInputPitch * this.Camera.CharacterController.InputPitchScale, -89.9f, 89.9f);
			if (this.Camera.IsInNormalGravityMode())
			{
				this.TmpRotator.Pitch = num4;
			}
			else
			{
				float num5 = num4 - cameraPitchInGravity;
				if ((double)Math.Abs(num5) > 1E-08)
				{
					this.TmpRotator2.Set(num5, 0f, 0f);
					this.TmpRotator2.Quaternion(this.TmpQuat2);
					this.TmpQuat.Multiply(this.TmpQuat2, this.TmpQuat3);
					this.TmpQuat.DeepCopy(this.TmpQuat3);
				}
			}
		}
		if (this.IsModifiedYaw || this.IsModifiedPitch)
		{
			if (this.Camera.IsInNormalGravityMode())
			{
				this.Camera.DesiredCamera.ArmRotation.DeepCopy(this.TmpRotator);
			}
			else
			{
				this.TmpQuat.Rotator(this.Camera.DesiredCamera.ArmRotation);
			}
		}
		if (flag)
		{
			this.AimAssistStep2(deltaTime);
		}
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000B274C File Offset: 0x000B094C
	private void UpdateZoomInput(float deltaTime)
	{
		EntityHandle characterEntityHandle = this.Camera.CharacterEntityHandle;
		if (characterEntityHandle == null || !characterEntityHandle.IsInit)
		{
			return;
		}
		if (!this.InputEnable.Active)
		{
			return;
		}
		if (this.ArmLengthBlockSet.Count > 0)
		{
			return;
		}
		if (this.Camera.IsModifiedArmLength || this.Camera.IsModifiedZoomModifier)
		{
			return;
		}
		float num = -characterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetZoomInput() * deltaTime;
		if (num == 0f)
		{
			return;
		}
		float num2 = num * (Info.Instance.IsInGamepad() ? this.GamePadZoomSpeed : this.ZoomSpeed) / (this.Camera.DesiredCamera.MaxArmLength - this.Camera.DesiredCamera.MinArmLength);
		this.ClampZoomModifier(this.Camera.DesiredCamera.ZoomModifier + num2);
		this.Camera.IsModifiedArmLength = true;
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000B282C File Offset: 0x000B0A2C
	private void NormalizedCameraModifier()
	{
		if (this.Camera.IsModifiedArmLength || this.Camera.IsModifiedZoomModifier)
		{
			return;
		}
		if (this.ArmLength <= 0f || this.MinArmLength <= 0f || this.MaxArmLength <= 0f)
		{
			this.ArmLength = this.Camera.CurrentCamera.ArmLength;
			this.MinArmLength = this.Camera.CurrentCamera.MinArmLength;
			this.MaxArmLength = this.Camera.CurrentCamera.MaxArmLength;
			return;
		}
		if (MathUtils.Instance.IsNearlyEqual((double)this.MinArmLength, (double)this.Camera.CurrentCamera.MinArmLength, null) && MathUtils.Instance.IsNearlyEqual((double)this.MaxArmLength, (double)this.Camera.CurrentCamera.MaxArmLength, null) && MathUtils.Instance.IsNearlyEqual((double)this.ArmLength, (double)this.Camera.CurrentCamera.ArmLength, null))
		{
			return;
		}
		this.ClampZoomModifier(this.Camera.DesiredCamera.ZoomModifier);
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x000B295C File Offset: 0x000B0B5C
	private void ClampZoomModifier(float zoomModifier)
	{
		float armLengthWithSetting = this.Camera.GetArmLengthWithSetting(this.Camera.CurrentCamera);
		this.Camera.DesiredCamera.ZoomModifier = MathUtils.Instance.Clamp(zoomModifier * armLengthWithSetting, this.Camera.CurrentCamera.MinArmLength, this.Camera.CurrentCamera.MaxArmLength) / armLengthWithSetting;
		this.ArmLength = this.Camera.CurrentCamera.ArmLength;
		this.MinArmLength = this.Camera.CurrentCamera.MinArmLength;
		this.MaxArmLength = this.Camera.CurrentCamera.MaxArmLength;
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x000B2A04 File Offset: 0x000B0C04
	public void SetAimAssistTarget(EntityHandle handle, FName socketName)
	{
		CharacterActorComponent component = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterActorComponent>();
		ECamp camp = component.Actor.Camp;
		CharacterActorComponent component2 = handle.Entity.GetComponent<CharacterActorComponent>();
		if (component2 == null || CampUtils.GetCampRelationship(camp, component2.Actor.Camp) != ERelation.Enemy || !CameraUtility.TargetCanBeSelect(component2))
		{
			return;
		}
		float num = this.AimAssistRange;
		if (!FNameUtil.IsEmpty(new FName?(socketName)) && component2.LockOnParts.Count > 0)
		{
			LockOnPart lockOnPart;
			component2.LockOnParts.TryGetValue(socketName.ToString(), out lockOnPart);
			string key = (!string.IsNullOrEmpty((lockOnPart != null) ? lockOnPart.AimPartBoneName : null)) ? lockOnPart.AimPartBoneName : socketName.ToString();
			component2.AimParts.TryGetValue(key, out this.SelectedAimPart);
			if (this.SelectedAimPart != null)
			{
				this.SelectedAimPart.GetAimPointLocation(this.TmpAimPoint);
				this.TmpAimPoint.Subtraction(this.Camera.CameraLocation, this.TargetDirection);
				this.AimPoint.DeepCopy(this.TmpAimPoint);
				this.LastAimPoint.DeepCopy(this.TmpAimPoint);
				return;
			}
		}
		else
		{
			this.SelectedAimPart = null;
		}
		foreach (KeyValuePair<string, AimPart> keyValuePair in component2.AimParts)
		{
			string text;
			AimPart aimPart;
			keyValuePair.Deconstruct(out text, out aimPart);
			AimPart aimPart2 = aimPart;
			aimPart2.GetAimPointLocation(this.TmpAimPoint);
			this.TmpAimPoint.Subtraction(this.Camera.CameraLocation, this.TargetDirection);
			float num2 = (float)this.TargetDirection.DotProduct(this.Camera.CameraForward);
			if (num2 >= 0f && num2 <= num && this.TargetDirection.SizeSquared() - MathUtils.Instance.Square((double)num2) <= MathUtils.Instance.Square((double)aimPart2.GetRadius(true)))
			{
				this.TmpAimPoint.Subtraction(component.ActorLocationProxy, this.TmpVector);
				this.TmpVector.Normalize(9.99999993922529E-09);
				if (Math.Acos(this.TmpVector.DotProduct(this.Camera.CameraForward)) <= 0.6981316804885864)
				{
					num = num2;
					this.SelectedAimPart = aimPart2;
					this.AimPoint.DeepCopy(this.TmpAimPoint);
					this.LastAimPoint.DeepCopy(this.TmpAimPoint);
				}
			}
		}
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x000B2CB0 File Offset: 0x000B0EB0
	private bool ShouldAimAssist(float deltaTime, bool hasInput)
	{
		if (!base.CameraModel.GetAimAssistEnable())
		{
			return false;
		}
		if (!this.IsAiming)
		{
			if (this.AimTime != 0f)
			{
				Log.Instance.Info(ELogModule.Camera, ELogAuthor.LCZ, "Exit Aim Assist", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.AimTime = 0f;
			this.SelectedAimPart = null;
			return false;
		}
		if (hasInput)
		{
			this.AimTime = this.AimAssistStartTimeLength + 1f;
		}
		else
		{
			this.AimTime += deltaTime;
		}
		bool flag = this.AimTime < this.AimAssistStartTimeLength;
		EAimAssistMode aimAssistMode = base.CameraModel.AimAssistMode;
		if (aimAssistMode == EAimAssistMode.Closed)
		{
			return false;
		}
		if (aimAssistMode == EAimAssistMode.OpenOnStart)
		{
			if (!flag)
			{
				return false;
			}
		}
		bool aimAssistDebugDraw = base.CameraModel.AimAssistDebugDraw;
		CharacterActorComponent component = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return false;
		}
		TsBaseCharacter actor = component.Actor;
		if (!hasInput && this.CanUseOldAimPart(deltaTime, actor))
		{
			if (aimAssistDebugDraw)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(this.SelectedAimPart.OwnerBase.Owner, this.AimPoint.ToUeVector(false), this.SelectedAimPart.GetRadius(flag), 12, new FLinearColor?(ColorUtils.LinearGreen), 0f, 0f);
			}
			return true;
		}
		float num = this.AimAssistRange * 0.7f;
		this.TmpVector.DeepCopy(this.Camera.CameraForward);
		this.TmpVector.MultiplyEqual((double)num);
		this.TmpVector.AdditionEqual(this.Camera.PlayerLocation);
		CreatureModel.Instance.GetEntitiesInRangeWithLocation(this.TmpVector, num, EEntityTypeQuery.SceneItemOrCharacter, this.EntityHandleList, true);
		this.SelectedAimPart = null;
		ECamp camp = actor.Camp;
		this.SortList.Clear();
		foreach (EntityHandle entityHandle in this.EntityHandleList)
		{
			WorldEntity entity = entityHandle.Entity;
			if (entity != null && entity.Active)
			{
				CharacterActorComponent component2 = entityHandle.Entity.GetComponent<CharacterActorComponent>();
				if (component2 != null && CampUtils.GetCampRelationship(camp, component2.Actor.Camp) == ERelation.Enemy && CameraUtility.TargetCanBeSelect(component2))
				{
					foreach (KeyValuePair<string, AimPart> keyValuePair in component2.AimParts)
					{
						string text;
						AimPart aimPart;
						keyValuePair.Deconstruct(out text, out aimPart);
						AimPart aimPart2 = aimPart;
						this.TryPushItemToSortList(aimPart2, flag, component);
					}
				}
				SceneItemHitComponent component3 = entityHandle.Entity.GetComponent<SceneItemHitComponent>();
				if (component3 != null)
				{
					foreach (AimPart aimPart3 in component3.AimParts)
					{
						this.TryPushItemToSortList(aimPart3, flag, component);
					}
				}
			}
		}
		this.SortList.Sort(new Comparison<ValueTuple<float, AimPart>>(this.CompareSortListItems));
		foreach (ValueTuple<float, AimPart> valueTuple in this.SortList)
		{
			AimPart item = valueTuple.Item2;
			item.GetAimPointLocation(this.TmpAimPoint);
			if (this.TraceCheck(actor, this.TmpAimPoint, item))
			{
				this.AimPoint.DeepCopy(this.TmpAimPoint);
				this.SelectedAimPart = item;
				this.ChangedSelectedAimPart = true;
				return true;
			}
		}
		return false;
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x000B3080 File Offset: 0x000B1280
	private void TryPushItemToSortList(AimPart aimPart, bool onStart, CharacterActorComponent selfActorComp)
	{
		aimPart.GetAimPointLocation(this.TmpAimPoint);
		if (base.CameraModel.AimAssistDebugDraw)
		{
			UKismetSystemLibrary.D_DrawDebugSphere(aimPart.OwnerBase.Owner, this.TmpAimPoint.ToUeVector(false), aimPart.GetRadius(onStart), 12, new FLinearColor?(ColorUtils.LinearGreen), 0f, 0f);
		}
		this.TmpAimPoint.Subtraction(this.Camera.CameraLocation, this.TargetDirection);
		double num = this.TargetDirection.DotProduct(this.Camera.CameraForward);
		if (num < 0.0 || num > (double)this.AimAssistRange)
		{
			return;
		}
		if (this.TargetDirection.SizeSquared() - MathUtils.Instance.Square(num) > MathUtils.Instance.Square((double)aimPart.GetRadius(onStart)))
		{
			return;
		}
		this.TmpAimPoint.Subtraction(selfActorComp.ActorLocationProxy, this.TmpVector);
		this.TmpVector.Normalize(9.99999993922529E-09);
		float num2 = (float)Math.Acos(this.TmpVector.DotProduct(this.Camera.CameraForward));
		if (num2 > 0.6981317f)
		{
			return;
		}
		this.SortList.Add(new ValueTuple<float, AimPart>(num2, aimPart));
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x000B31BC File Offset: 0x000B13BC
	private bool TraceCheck(AActor actor, Vector targetLocation, AimPart aimPart)
	{
		this.LineTrace.WorldContextObject = actor;
		TraceElementCommon.Instance.SetStartLocation(this.LineTrace, this.Camera.CameraLocation);
		TraceElementCommon.Instance.SetEndLocation(this.LineTrace, targetLocation);
		TraceElementCommon.Instance.LineTrace(this.LineTrace, "CameraInputController Aim");
		UKuroHitResult hitResult = this.LineTrace.HitResult;
		int? num = (hitResult != null) ? new int?(hitResult.GetHitCount()) : null;
		if (num != null)
		{
			string ignoreCollisionBoneName = aimPart.IgnoreCollisionBoneName;
			int num2 = 0;
			TWeakObjectPtr<UPrimitiveComponent> weak;
			for (;;)
			{
				int num3 = num2;
				int? num4 = num;
				if (!(num3 < num4.GetValueOrDefault() & num4 != null))
				{
					return true;
				}
				weak = this.LineTrace.HitResult.Components.Get(0);
				int instanceIndex = this.LineTrace.HitResult.ItemArray.Get(0);
				if (!(UKuroCollisionLibrary.GetCollisionResponseToChannel(weak, KuroCollisionChannel.Bullet, instanceIndex) == ECollisionResponse.ECR_Ignore))
				{
					break;
				}
				num2++;
			}
			if (aimPart.OwnerCharacter != null)
			{
				if (weak.Get().GetOwner() == aimPart.OwnerBase.Owner)
				{
					if (ignoreCollisionBoneName == "")
					{
						return true;
					}
					if (weak.GetName() == ignoreCollisionBoneName)
					{
						return true;
					}
				}
			}
			else if (aimPart.SceneItemHit != null)
			{
				AActor owner = aimPart.OwnerBase.Owner;
				AActor aactor = weak.Get().GetOwner();
				while (aactor != null && aactor != owner)
				{
					aactor = aactor.GetAttachParentActor();
				}
				if (aactor != null)
				{
					return true;
				}
			}
			return false;
		}
		return true;
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000B3344 File Offset: 0x000B1544
	private bool CanUseOldAimPart(float deltaTime, AActor actor)
	{
		if (this.SelectedAimPart == null || !CameraUtility.TargetCanBeSelect(this.SelectedAimPart.OwnerBase))
		{
			return false;
		}
		this.SelectedAimPart.GetAimPointLocation(this.AimPoint);
		this.AimPoint.Subtraction(this.Camera.CameraLocation, this.TargetDirection);
		double num = this.TargetDirection.DotProduct(this.Camera.CameraForward);
		if (num < 0.0 || num > (double)(this.AimAssistRange * 1.05f))
		{
			return false;
		}
		this.LastAimPoint.Subtraction(this.Camera.CameraLocation, this.TmpVector);
		double num2 = this.TmpVector.SizeSquared() * this.TargetDirection.SizeSquared();
		return (num2 <= 1E-08 || Math.Acos(MathUtils.Instance.DotProduct(this.TmpVector, this.TargetDirection) / Math.Sqrt(num2)) * 57.295780181884766 <= (double)(this.AimAssistSpeedEdge * deltaTime)) && this.TraceCheck(actor, this.AimPoint, this.SelectedAimPart);
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000B3464 File Offset: 0x000B1664
	private void AimAssistStep2(float deltaTime)
	{
		if (this.SelectedAimPart == null)
		{
			return;
		}
		this.AimPoint.Subtraction(this.Camera.CameraLocation, this.TargetDirection);
		if (this.TargetDirection.IsNearlyZero(9.999999747378752E-05))
		{
			return;
		}
		this.Camera.IsModifiedArmRotationPitch = true;
		this.Camera.IsModifiedArmRotationYaw = true;
		Rotator armRotation = this.Camera.DesiredCamera.ArmRotation;
		if (!this.ChangedSelectedAimPart)
		{
			this.LastAimPoint.Subtraction(this.Camera.CameraLocation, this.TmpVector);
			Quat.FindBetween(this.TmpVector, this.TargetDirection, this.TmpQuat);
			armRotation.Quaternion(this.TmpQuat2);
			this.TmpQuat.Multiply(this.TmpQuat2, this.TmpQuat2);
			this.TmpQuat2.Rotator(armRotation);
		}
		this.LastAimPoint.DeepCopy(this.AimPoint);
		double v = this.TargetDirection.DotProduct(this.Camera.CameraForward);
		double num = Math.Sqrt(this.TargetDirection.SizeSquared() - MathUtils.Instance.Square(v));
		bool flag = this.AimTime < this.AimAssistStartTimeLength;
		float num2 = flag ? 0f : this.SelectedAimPart.RadiusIn;
		if (num <= (double)num2)
		{
			return;
		}
		double num3 = this.TargetDirection.Size();
		double num4 = Math.Asin(num / num3) * 57.295780181884766;
		double num5 = Math.Asin((double)num2 / num3) * 57.295780181884766;
		double num6 = num4 - num5;
		if (flag && num6 < 1.0 && this.AimTime > 0.4f)
		{
			this.AimTime = this.AimAssistStartTimeLength + 1f;
		}
		float num7;
		if (flag)
		{
			num7 = MathUtils.Instance.Lerp(this.AimAssistStartSpeedBegin, this.AimAssistStartSpeedEnd, this.AimAssistCurve.GetCurrentValue(this.AimTime / this.AimAssistStartTimeLength));
			CharacterActorComponent component = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterActorComponent>();
			this.AimPoint.Subtraction(component.ActorLocationProxy, this.TmpVector);
			this.TmpVector.Normalize(9.99999993922529E-09);
			double num8 = Math.Acos(this.TmpVector.DotProduct(this.Camera.CameraForward));
			num7 *= (float)(1.0 + 0.5 * num8 / 0.6981316804885864);
		}
		else
		{
			float radius = this.SelectedAimPart.GetRadius(flag);
			num7 = MathUtils.Instance.Lerp(this.AimAssistSpeedCenter, this.AimAssistSpeedEdge, this.AimAssistCurve.GetCurrentValue((float)((num - (double)num2) / (double)(radius - num2))));
		}
		float slerp;
		if ((double)(num7 * deltaTime) > num6)
		{
			slerp = (float)(num6 / num4);
		}
		else
		{
			slerp = (float)((double)(num7 * deltaTime) / num4);
		}
		Quat.FindBetween(this.Camera.CameraForward, this.TargetDirection, this.TmpQuat);
		Quat.Slerp(Quat.IdentityProxy, this.TmpQuat, slerp, this.TmpQuat);
		armRotation.Quaternion(this.TmpQuat2);
		this.TmpQuat.Multiply(this.TmpQuat2, this.TmpQuat2);
		this.TmpQuat2.Rotator(armRotation);
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x000B37A8 File Offset: 0x000B19A8
	private float GetNormalizedSmoothFactor(float factor, float _)
	{
		return MathUtils.Instance.Lerp(this.IsInGamepad() ? this.GamePadSmoothFactorMin : this.SmoothFactorMin, this.IsInGamepad() ? this.GamePadSmoothFactorMax : this.SmoothFactorMax, this.IsInGamepad() ? this.GamePadSmoothFactorCurve.GetCurrentValue(factor / this.GamePadSmoothFactorRange) : this.SmoothFactorCurve.GetCurrentValue(factor / this.SmoothFactorRange));
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x000B381B File Offset: 0x000B1A1B
	private bool IsInTouch()
	{
		return Info.Instance.IsInTouch() || (Info.Instance.IsInGamepad() && ControlScreenModel.Instance.IsTouching);
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x000B3843 File Offset: 0x000B1A43
	private bool IsInGamepad()
	{
		return Info.Instance.IsInGamepad() && !ControlScreenModel.Instance.IsTouching;
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x000B3860 File Offset: 0x000B1A60
	public void ResetCameraInput()
	{
		this.CurrentInputPitch = 0f;
		this.CurrentInputYaw = 0f;
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x000B3878 File Offset: 0x000B1A78
	private int CompareSortListItems([Nullable(new byte[]
	{
		0,
		1
	})] ValueTuple<float, AimPart> a, [Nullable(new byte[]
	{
		0,
		1
	})] ValueTuple<float, AimPart> b)
	{
		return a.Item1.CompareTo(b.Item1);
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x000B388C File Offset: 0x000B1A8C
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x000B3895 File Offset: 0x000B1A95
	private void UpdateCameraParam()
	{
		this.MobileDensityYawScale = CSharpScript.Game.Camera.CameraModel.Instance.MobileDensityYawScale;
		this.MobileDensityPitchScale = CSharpScript.Game.Camera.CameraModel.Instance.MobileDensityPitchScale;
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x000B38B8 File Offset: 0x000B1AB8
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 7:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c == 'T')
					{
						if (key == "TmpQuat")
						{
							value = this.TmpQuat;
							return true;
						}
					}
				}
				else if (key == "AimTime")
				{
					value = this.AimTime;
					return true;
				}
				break;
			}
			case 8:
			{
				char c = key[0];
				if (c <= 'I')
				{
					if (c != 'A')
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
					else if (key == "AimPoint")
					{
						value = this.AimPoint;
						return true;
					}
				}
				else if (c != 'S')
				{
					if (c == 'T')
					{
						if (key == "TmpQuat2")
						{
							value = this.TmpQuat2;
							return true;
						}
						if (key == "TmpQuat3")
						{
							value = this.TmpQuat3;
							return true;
						}
					}
				}
				else if (key == "SortList")
				{
					value = this.SortList;
					return true;
				}
				break;
			}
			case 9:
			{
				char c = key[0];
				if (c <= 'L')
				{
					if (c != 'A')
					{
						if (c == 'L')
						{
							if (key == "LineTrace")
							{
								value = this.LineTrace;
								return true;
							}
						}
					}
					else if (key == "ArmLength")
					{
						value = this.ArmLength;
						return true;
					}
				}
				else if (c != 'T')
				{
					if (c == 'Z')
					{
						if (key == "ZoomSpeed")
						{
							value = this.ZoomSpeed;
							return true;
						}
					}
				}
				else if (key == "TmpVector")
				{
					value = this.TmpVector;
					return true;
				}
				break;
			}
			case 10:
				if (key == "TmpRotator")
				{
					value = this.TmpRotator;
					return true;
				}
				break;
			case 11:
			{
				char c = key[3];
				if (c != 'A')
				{
					if (c != 'R')
					{
						if (c == 'u')
						{
							if (key == "InputEnable")
							{
								value = this.InputEnable;
								return true;
							}
						}
					}
					else if (key == "TmpRotator2")
					{
						value = this.TmpRotator2;
						return true;
					}
				}
				else if (key == "TmpAimPoint")
				{
					value = this.TmpAimPoint;
					return true;
				}
				break;
			}
			case 12:
			{
				char c = key[2];
				if (c != 'n')
				{
					if (c != 's')
					{
						if (c == 'x')
						{
							if (key == "MaxArmLength")
							{
								value = this.MaxArmLength;
								return true;
							}
						}
					}
					else if (key == "LastAimPoint")
					{
						value = this.LastAimPoint;
						return true;
					}
				}
				else if (key == "MinArmLength")
				{
					value = this.MinArmLength;
					return true;
				}
				break;
			}
			case 13:
			{
				char c = key[12];
				if (c != 'n')
				{
					if (c != 'w')
					{
						if (c == 'x')
						{
							if (key == "InputSpeedMax")
							{
								value = this.InputSpeedMax;
								return true;
							}
						}
					}
					else if (key == "IsModifiedYaw")
					{
						value = this.IsModifiedYaw;
						return true;
					}
				}
				else if (key == "InputSpeedMin")
				{
					value = this.InputSpeedMin;
					return true;
				}
				break;
			}
			case 14:
			{
				char c = key[9];
				if (c != 'C')
				{
					if (c == 'R')
					{
						if (key == "AimAssistRange")
						{
							value = this.AimAssistRange;
							return true;
						}
					}
				}
				else if (key == "AimAssistCurve")
				{
					value = this.AimAssistCurve;
					return true;
				}
				break;
			}
			case 15:
			{
				char c = key[1];
				if (c <= 'm')
				{
					if (c != 'a')
					{
						if (c != 'e')
						{
							if (c == 'm')
							{
								if (key == "SmoothFactorMin")
								{
									value = this.SmoothFactorMin;
									return true;
								}
								if (key == "SmoothFactorMax")
								{
									value = this.SmoothFactorMax;
									return true;
								}
							}
						}
						else if (key == "SelectedAimPart")
						{
							value = this.SelectedAimPart;
							return true;
						}
					}
					else if (key == "TargetDirection")
					{
						value = this.TargetDirection;
						return true;
					}
				}
				else if (c != 'n')
				{
					if (c != 's')
					{
						if (c == 'u')
						{
							if (key == "CurrentInputYaw")
							{
								value = this.CurrentInputYaw;
								return true;
							}
						}
					}
					else if (key == "IsModifiedPitch")
					{
						value = this.IsModifiedPitch;
						return true;
					}
				}
				else if (key == "EnableAutopilot")
				{
					value = this.EnableAutopilot;
					return true;
				}
				break;
			}
			case 16:
			{
				char c = key[4];
				if (c != 'P')
				{
					switch (c)
					{
					case 'p':
						if (key == "GamepadInputRate")
						{
							value = this.GamepadInputRate;
							return true;
						}
						break;
					case 's':
						if (key == "AimAssistDamping")
						{
							value = this.AimAssistDamping;
							return true;
						}
						break;
					case 't':
						if (key == "EntityHandleList")
						{
							value = this.EntityHandleList;
							return true;
						}
						break;
					}
				}
				else if (key == "GamePadZoomSpeed")
				{
					value = this.GamePadZoomSpeed;
					return true;
				}
				break;
			}
			case 17:
			{
				char c = key[12];
				if (c <= 'R')
				{
					if (c != 'C')
					{
						if (c != 'P')
						{
							if (c == 'R')
							{
								if (key == "SmoothFactorRange")
								{
									value = this.SmoothFactorRange;
									return true;
								}
							}
						}
						else if (key == "CurrentInputPitch")
						{
							value = this.CurrentInputPitch;
							return true;
						}
					}
					else if (key == "SmoothFactorCurve")
					{
						value = this.SmoothFactorCurve;
						return true;
					}
				}
				else if (c != 'a')
				{
					if (c != 'c')
					{
						if (c == 'u')
						{
							if (key == "AutopilotInputMin")
							{
								value = this.AutopilotInputMin;
								return true;
							}
							if (key == "AutopilotInputMax")
							{
								value = this.AutopilotInputMax;
								return true;
							}
						}
					}
					else if (key == "ArmLengthBlockSet")
					{
						value = this.ArmLengthBlockSet;
						return true;
					}
				}
				else
				{
					if (key == "SensitivityYawMin")
					{
						value = this.SensitivityYawMin;
						return true;
					}
					if (key == "SensitivityYawMax")
					{
						value = this.SensitivityYawMax;
						return true;
					}
				}
				break;
			}
			case 18:
				if (key == "AimAssistSpeedEdge")
				{
					value = this.AimAssistSpeedEdge;
					return true;
				}
				break;
			case 19:
			{
				char c = key[17];
				if (c <= 'g')
				{
					if (c != 'a')
					{
						if (c == 'g')
						{
							if (key == "SensitivityYawRange")
							{
								value = this.SensitivityYawRange;
								return true;
							}
						}
					}
					else if (key == "SensitivityPitchMax")
					{
						value = this.SensitivityPitchMax;
						return true;
					}
				}
				else if (c != 'i')
				{
					if (c != 'm')
					{
						if (c == 'v')
						{
							if (key == "SensitivityYawCurve")
							{
								value = this.SensitivityYawCurve;
								return true;
							}
							if (key == "AimAssistStartCurve")
							{
								value = this.AimAssistStartCurve;
								return true;
							}
						}
					}
					else if (key == "AutopilotEnableTime")
					{
						value = this.AutopilotEnableTime;
						return true;
					}
				}
				else if (key == "SensitivityPitchMin")
				{
					value = this.SensitivityPitchMin;
					return true;
				}
				break;
			}
			case 20:
			{
				char c = key[1];
				if (c != 'i')
				{
					if (c != 'n')
					{
						if (c == 'u')
						{
							if (key == "AutopilotInputFactor")
							{
								value = this.AutopilotInputFactor;
								return true;
							}
						}
					}
					else if (key == "InputSpeedPercentage")
					{
						value = this.InputSpeedPercentage;
						return true;
					}
				}
				else if (key == "AimAssistSpeedCenter")
				{
					value = this.AimAssistSpeedCenter;
					return true;
				}
				break;
			}
			case 21:
			{
				char c = key[16];
				if (c != 'C')
				{
					if (c != 'R')
					{
						if (c == 'S')
						{
							if (key == "MobileDensityYawScale")
							{
								value = this.MobileDensityYawScale;
								return true;
							}
						}
					}
					else if (key == "SensitivityPitchRange")
					{
						value = this.SensitivityPitchRange;
						return true;
					}
				}
				else if (key == "SensitivityPitchCurve")
				{
					value = this.SensitivityPitchCurve;
					return true;
				}
				break;
			}
			case 22:
			{
				char c = key[1];
				if (c <= 'h')
				{
					if (c != 'a')
					{
						if (c == 'h')
						{
							if (key == "ChangedSelectedAimPart")
							{
								value = this.ChangedSelectedAimPart;
								return true;
							}
						}
					}
					else
					{
						if (key == "GamePadSmoothFactorMin")
						{
							value = this.GamePadSmoothFactorMin;
							return true;
						}
						if (key == "GamePadSmoothFactorMax")
						{
							value = this.GamePadSmoothFactorMax;
							return true;
						}
					}
				}
				else if (c != 'i')
				{
					if (c != 'r')
					{
						if (c == 'u')
						{
							if (key == "AutopilotInputAngleMin")
							{
								value = this.AutopilotInputAngleMin;
								return true;
							}
							if (key == "AutopilotInputAngleMax")
							{
								value = this.AutopilotInputAngleMax;
								return true;
							}
						}
					}
					else if (key == "ArmRotationYawBlockSet")
					{
						value = this.ArmRotationYawBlockSet;
						return true;
					}
				}
				else if (key == "AimAssistStartSpeedEnd")
				{
					value = this.AimAssistStartSpeedEnd;
					return true;
				}
				break;
			}
			case 23:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c == 'M')
					{
						if (key == "MobileDensityPitchScale")
						{
							value = this.MobileDensityPitchScale;
							return true;
						}
					}
				}
				else if (key == "AutopilotAngleTolerance")
				{
					value = this.AutopilotAngleTolerance;
					return true;
				}
				break;
			}
			case 24:
			{
				char c = key[19];
				if (c <= 'C')
				{
					if (c != 'B')
					{
						if (c == 'C')
						{
							if (key == "GamePadSmoothFactorCurve")
							{
								value = this.GamePadSmoothFactorCurve;
								return true;
							}
						}
					}
					else if (key == "AimAssistStartSpeedBegin")
					{
						value = this.AimAssistStartSpeedBegin;
						return true;
					}
				}
				else if (c != 'R')
				{
					if (c != 'c')
					{
						if (c == 'e')
						{
							if (key == "AimAssistStartTimeLength")
							{
								value = this.AimAssistStartTimeLength;
								return true;
							}
						}
					}
					else if (key == "ArmRotationPitchBlockSet")
					{
						value = this.ArmRotationPitchBlockSet;
						return true;
					}
				}
				else if (key == "GamePadSmoothFactorRange")
				{
					value = this.GamePadSmoothFactorRange;
					return true;
				}
				break;
			}
			case 27:
				if (key == "AutopilotGamepadInputFactor")
				{
					value = this.AutopilotGamepadInputFactor;
					return true;
				}
				break;
			case 32:
				if (key == "SpecificCameraBaseYawSensitivity")
				{
					value = this.SpecificCameraBaseYawSensitivity;
					return true;
				}
				break;
			case 34:
			{
				char c = key[14];
				if (c != 'A')
				{
					if (c == 'B')
					{
						if (key == "SpecificCameraBasePitchSensitivity")
						{
							value = this.SpecificCameraBasePitchSensitivity;
							return true;
						}
					}
				}
				else if (key == "SpecificCameraAimingYawSensitivity")
				{
					value = this.SpecificCameraAimingYawSensitivity;
					return true;
				}
				break;
			}
			case 36:
				if (key == "SpecificCameraAimingPitchSensitivity")
				{
					value = this.SpecificCameraAimingPitchSensitivity;
					return true;
				}
				break;
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x000B464C File Offset: 0x000B284C
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 7:
				if (key == "AimTime")
				{
					float num2;
					if (value is double)
					{
						double num = (double)value;
						num2 = (float)num;
					}
					else if (value is float)
					{
						float num3 = (float)value;
						num2 = num3;
					}
					else if (value is int)
					{
						int num4 = (int)value;
						num2 = (float)num4;
					}
					else if (value is long)
					{
						long num5 = (long)value;
						num2 = (float)num5;
					}
					else
					{
						num2 = (float)value;
					}
					this.AimTime = num2;
					return;
				}
				break;
			case 9:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c != 'L')
					{
						if (c == 'Z')
						{
							if (key == "ZoomSpeed")
							{
								float num2;
								if (value is double)
								{
									double num6 = (double)value;
									num2 = (float)num6;
								}
								else if (value is float)
								{
									float num7 = (float)value;
									num2 = num7;
								}
								else if (value is int)
								{
									int num8 = (int)value;
									num2 = (float)num8;
								}
								else if (value is long)
								{
									long num9 = (long)value;
									num2 = (float)num9;
								}
								else
								{
									num2 = (float)value;
								}
								this.ZoomSpeed = num2;
								return;
							}
						}
					}
					else if (key == "LineTrace")
					{
						this.LineTrace = (UTraceLineElement)value;
						return;
					}
				}
				else if (key == "ArmLength")
				{
					float num2;
					if (value is double)
					{
						double num10 = (double)value;
						num2 = (float)num10;
					}
					else if (value is float)
					{
						float num11 = (float)value;
						num2 = num11;
					}
					else if (value is int)
					{
						int num12 = (int)value;
						num2 = (float)num12;
					}
					else if (value is long)
					{
						long num13 = (long)value;
						num2 = (float)num13;
					}
					else
					{
						num2 = (float)value;
					}
					this.ArmLength = num2;
					return;
				}
				break;
			}
			case 12:
			{
				char c = key[1];
				if (c != 'a')
				{
					if (c == 'i')
					{
						if (key == "MinArmLength")
						{
							float num2;
							if (value is double)
							{
								double num14 = (double)value;
								num2 = (float)num14;
							}
							else if (value is float)
							{
								float num15 = (float)value;
								num2 = num15;
							}
							else if (value is int)
							{
								int num16 = (int)value;
								num2 = (float)num16;
							}
							else if (value is long)
							{
								long num17 = (long)value;
								num2 = (float)num17;
							}
							else
							{
								num2 = (float)value;
							}
							this.MinArmLength = num2;
							return;
						}
					}
				}
				else if (key == "MaxArmLength")
				{
					float num2;
					if (value is double)
					{
						double num18 = (double)value;
						num2 = (float)num18;
					}
					else if (value is float)
					{
						float num19 = (float)value;
						num2 = num19;
					}
					else if (value is int)
					{
						int num20 = (int)value;
						num2 = (float)num20;
					}
					else if (value is long)
					{
						long num21 = (long)value;
						num2 = (float)num21;
					}
					else
					{
						num2 = (float)value;
					}
					this.MaxArmLength = num2;
					return;
				}
				break;
			}
			case 13:
			{
				char c = key[12];
				if (c != 'n')
				{
					if (c != 'w')
					{
						if (c == 'x')
						{
							if (key == "InputSpeedMax")
							{
								float num2;
								if (value is double)
								{
									double num22 = (double)value;
									num2 = (float)num22;
								}
								else if (value is float)
								{
									float num23 = (float)value;
									num2 = num23;
								}
								else if (value is int)
								{
									int num24 = (int)value;
									num2 = (float)num24;
								}
								else if (value is long)
								{
									long num25 = (long)value;
									num2 = (float)num25;
								}
								else
								{
									num2 = (float)value;
								}
								this.InputSpeedMax = num2;
								return;
							}
						}
					}
					else if (key == "IsModifiedYaw")
					{
						this.IsModifiedYaw = (bool)value;
						return;
					}
				}
				else if (key == "InputSpeedMin")
				{
					float num2;
					if (value is double)
					{
						double num26 = (double)value;
						num2 = (float)num26;
					}
					else if (value is float)
					{
						float num27 = (float)value;
						num2 = num27;
					}
					else if (value is int)
					{
						int num28 = (int)value;
						num2 = (float)num28;
					}
					else if (value is long)
					{
						long num29 = (long)value;
						num2 = (float)num29;
					}
					else
					{
						num2 = (float)value;
					}
					this.InputSpeedMin = num2;
					return;
				}
				break;
			}
			case 14:
			{
				char c = key[9];
				if (c != 'C')
				{
					if (c == 'R')
					{
						if (key == "AimAssistRange")
						{
							float num2;
							if (value is double)
							{
								double num30 = (double)value;
								num2 = (float)num30;
							}
							else if (value is float)
							{
								float num31 = (float)value;
								num2 = num31;
							}
							else if (value is int)
							{
								int num32 = (int)value;
								num2 = (float)num32;
							}
							else if (value is long)
							{
								long num33 = (long)value;
								num2 = (float)num33;
							}
							else
							{
								num2 = (float)value;
							}
							this.AimAssistRange = num2;
							return;
						}
					}
				}
				else if (key == "AimAssistCurve")
				{
					this.AimAssistCurve = (CurveBase)value;
					return;
				}
				break;
			}
			case 15:
			{
				char c = key[1];
				if (c <= 'm')
				{
					if (c != 'e')
					{
						if (c == 'm')
						{
							if (key == "SmoothFactorMin")
							{
								float num2;
								if (value is double)
								{
									double num34 = (double)value;
									num2 = (float)num34;
								}
								else if (value is float)
								{
									float num35 = (float)value;
									num2 = num35;
								}
								else if (value is int)
								{
									int num36 = (int)value;
									num2 = (float)num36;
								}
								else if (value is long)
								{
									long num37 = (long)value;
									num2 = (float)num37;
								}
								else
								{
									num2 = (float)value;
								}
								this.SmoothFactorMin = num2;
								return;
							}
							if (key == "SmoothFactorMax")
							{
								float num2;
								if (value is double)
								{
									double num38 = (double)value;
									num2 = (float)num38;
								}
								else if (value is float)
								{
									float num39 = (float)value;
									num2 = num39;
								}
								else if (value is int)
								{
									int num40 = (int)value;
									num2 = (float)num40;
								}
								else if (value is long)
								{
									long num41 = (long)value;
									num2 = (float)num41;
								}
								else
								{
									num2 = (float)value;
								}
								this.SmoothFactorMax = num2;
								return;
							}
						}
					}
					else if (key == "SelectedAimPart")
					{
						this.SelectedAimPart = (AimPart)value;
						return;
					}
				}
				else if (c != 'n')
				{
					if (c != 's')
					{
						if (c == 'u')
						{
							if (key == "CurrentInputYaw")
							{
								float num2;
								if (value is double)
								{
									double num42 = (double)value;
									num2 = (float)num42;
								}
								else if (value is float)
								{
									float num43 = (float)value;
									num2 = num43;
								}
								else if (value is int)
								{
									int num44 = (int)value;
									num2 = (float)num44;
								}
								else if (value is long)
								{
									long num45 = (long)value;
									num2 = (float)num45;
								}
								else
								{
									num2 = (float)value;
								}
								this.CurrentInputYaw = num2;
								return;
							}
						}
					}
					else if (key == "IsModifiedPitch")
					{
						this.IsModifiedPitch = (bool)value;
						return;
					}
				}
				else if (key == "EnableAutopilot")
				{
					float num2;
					if (value is double)
					{
						double num46 = (double)value;
						num2 = (float)num46;
					}
					else if (value is float)
					{
						float num47 = (float)value;
						num2 = num47;
					}
					else if (value is int)
					{
						int num48 = (int)value;
						num2 = (float)num48;
					}
					else if (value is long)
					{
						long num49 = (long)value;
						num2 = (float)num49;
					}
					else
					{
						num2 = (float)value;
					}
					this.EnableAutopilot = num2;
					return;
				}
				break;
			}
			case 16:
			{
				char c = key[4];
				if (c != 'P')
				{
					if (c != 'p')
					{
						if (c == 's')
						{
							if (key == "AimAssistDamping")
							{
								float num2;
								if (value is double)
								{
									double num50 = (double)value;
									num2 = (float)num50;
								}
								else if (value is float)
								{
									float num51 = (float)value;
									num2 = num51;
								}
								else if (value is int)
								{
									int num52 = (int)value;
									num2 = (float)num52;
								}
								else if (value is long)
								{
									long num53 = (long)value;
									num2 = (float)num53;
								}
								else
								{
									num2 = (float)value;
								}
								this.AimAssistDamping = num2;
								return;
							}
						}
					}
					else if (key == "GamepadInputRate")
					{
						float num2;
						if (value is double)
						{
							double num54 = (double)value;
							num2 = (float)num54;
						}
						else if (value is float)
						{
							float num55 = (float)value;
							num2 = num55;
						}
						else if (value is int)
						{
							int num56 = (int)value;
							num2 = (float)num56;
						}
						else if (value is long)
						{
							long num57 = (long)value;
							num2 = (float)num57;
						}
						else
						{
							num2 = (float)value;
						}
						this.GamepadInputRate = num2;
						return;
					}
				}
				else if (key == "GamePadZoomSpeed")
				{
					float num2;
					if (value is double)
					{
						double num58 = (double)value;
						num2 = (float)num58;
					}
					else if (value is float)
					{
						float num59 = (float)value;
						num2 = num59;
					}
					else if (value is int)
					{
						int num60 = (int)value;
						num2 = (float)num60;
					}
					else if (value is long)
					{
						long num61 = (long)value;
						num2 = (float)num61;
					}
					else
					{
						num2 = (float)value;
					}
					this.GamePadZoomSpeed = num2;
					return;
				}
				break;
			}
			case 17:
			{
				char c = key[12];
				if (c <= 'P')
				{
					if (c != 'C')
					{
						if (c == 'P')
						{
							if (key == "CurrentInputPitch")
							{
								float num2;
								if (value is double)
								{
									double num62 = (double)value;
									num2 = (float)num62;
								}
								else if (value is float)
								{
									float num63 = (float)value;
									num2 = num63;
								}
								else if (value is int)
								{
									int num64 = (int)value;
									num2 = (float)num64;
								}
								else if (value is long)
								{
									long num65 = (long)value;
									num2 = (float)num65;
								}
								else
								{
									num2 = (float)value;
								}
								this.CurrentInputPitch = num2;
								return;
							}
						}
					}
					else if (key == "SmoothFactorCurve")
					{
						this.SmoothFactorCurve = (CurveBase)value;
						return;
					}
				}
				else if (c != 'R')
				{
					if (c != 'a')
					{
						if (c == 'u')
						{
							if (key == "AutopilotInputMin")
							{
								float num2;
								if (value is double)
								{
									double num66 = (double)value;
									num2 = (float)num66;
								}
								else if (value is float)
								{
									float num67 = (float)value;
									num2 = num67;
								}
								else if (value is int)
								{
									int num68 = (int)value;
									num2 = (float)num68;
								}
								else if (value is long)
								{
									long num69 = (long)value;
									num2 = (float)num69;
								}
								else
								{
									num2 = (float)value;
								}
								this.AutopilotInputMin = num2;
								return;
							}
							if (key == "AutopilotInputMax")
							{
								float num2;
								if (value is double)
								{
									double num70 = (double)value;
									num2 = (float)num70;
								}
								else if (value is float)
								{
									float num71 = (float)value;
									num2 = num71;
								}
								else if (value is int)
								{
									int num72 = (int)value;
									num2 = (float)num72;
								}
								else if (value is long)
								{
									long num73 = (long)value;
									num2 = (float)num73;
								}
								else
								{
									num2 = (float)value;
								}
								this.AutopilotInputMax = num2;
								return;
							}
						}
					}
					else
					{
						if (key == "SensitivityYawMin")
						{
							float num2;
							if (value is double)
							{
								double num74 = (double)value;
								num2 = (float)num74;
							}
							else if (value is float)
							{
								float num75 = (float)value;
								num2 = num75;
							}
							else if (value is int)
							{
								int num76 = (int)value;
								num2 = (float)num76;
							}
							else if (value is long)
							{
								long num77 = (long)value;
								num2 = (float)num77;
							}
							else
							{
								num2 = (float)value;
							}
							this.SensitivityYawMin = num2;
							return;
						}
						if (key == "SensitivityYawMax")
						{
							float num2;
							if (value is double)
							{
								double num78 = (double)value;
								num2 = (float)num78;
							}
							else if (value is float)
							{
								float num79 = (float)value;
								num2 = num79;
							}
							else if (value is int)
							{
								int num80 = (int)value;
								num2 = (float)num80;
							}
							else if (value is long)
							{
								long num81 = (long)value;
								num2 = (float)num81;
							}
							else
							{
								num2 = (float)value;
							}
							this.SensitivityYawMax = num2;
							return;
						}
					}
				}
				else if (key == "SmoothFactorRange")
				{
					float num2;
					if (value is double)
					{
						double num82 = (double)value;
						num2 = (float)num82;
					}
					else if (value is float)
					{
						float num83 = (float)value;
						num2 = num83;
					}
					else if (value is int)
					{
						int num84 = (int)value;
						num2 = (float)num84;
					}
					else if (value is long)
					{
						long num85 = (long)value;
						num2 = (float)num85;
					}
					else
					{
						num2 = (float)value;
					}
					this.SmoothFactorRange = num2;
					return;
				}
				break;
			}
			case 18:
				if (key == "AimAssistSpeedEdge")
				{
					float num2;
					if (value is double)
					{
						double num86 = (double)value;
						num2 = (float)num86;
					}
					else if (value is float)
					{
						float num87 = (float)value;
						num2 = num87;
					}
					else if (value is int)
					{
						int num88 = (int)value;
						num2 = (float)num88;
					}
					else if (value is long)
					{
						long num89 = (long)value;
						num2 = (float)num89;
					}
					else
					{
						num2 = (float)value;
					}
					this.AimAssistSpeedEdge = num2;
					return;
				}
				break;
			case 19:
			{
				char c = key[17];
				if (c <= 'g')
				{
					if (c != 'a')
					{
						if (c == 'g')
						{
							if (key == "SensitivityYawRange")
							{
								float num2;
								if (value is double)
								{
									double num90 = (double)value;
									num2 = (float)num90;
								}
								else if (value is float)
								{
									float num91 = (float)value;
									num2 = num91;
								}
								else if (value is int)
								{
									int num92 = (int)value;
									num2 = (float)num92;
								}
								else if (value is long)
								{
									long num93 = (long)value;
									num2 = (float)num93;
								}
								else
								{
									num2 = (float)value;
								}
								this.SensitivityYawRange = num2;
								return;
							}
						}
					}
					else if (key == "SensitivityPitchMax")
					{
						float num2;
						if (value is double)
						{
							double num94 = (double)value;
							num2 = (float)num94;
						}
						else if (value is float)
						{
							float num95 = (float)value;
							num2 = num95;
						}
						else if (value is int)
						{
							int num96 = (int)value;
							num2 = (float)num96;
						}
						else if (value is long)
						{
							long num97 = (long)value;
							num2 = (float)num97;
						}
						else
						{
							num2 = (float)value;
						}
						this.SensitivityPitchMax = num2;
						return;
					}
				}
				else if (c != 'i')
				{
					if (c != 'm')
					{
						if (c == 'v')
						{
							if (key == "SensitivityYawCurve")
							{
								this.SensitivityYawCurve = (CurveBase)value;
								return;
							}
							if (key == "AimAssistStartCurve")
							{
								this.AimAssistStartCurve = (CurveBase)value;
								return;
							}
						}
					}
					else if (key == "AutopilotEnableTime")
					{
						float num2;
						if (value is double)
						{
							double num98 = (double)value;
							num2 = (float)num98;
						}
						else if (value is float)
						{
							float num99 = (float)value;
							num2 = num99;
						}
						else if (value is int)
						{
							int num100 = (int)value;
							num2 = (float)num100;
						}
						else if (value is long)
						{
							long num101 = (long)value;
							num2 = (float)num101;
						}
						else
						{
							num2 = (float)value;
						}
						this.AutopilotEnableTime = num2;
						return;
					}
				}
				else if (key == "SensitivityPitchMin")
				{
					float num2;
					if (value is double)
					{
						double num102 = (double)value;
						num2 = (float)num102;
					}
					else if (value is float)
					{
						float num103 = (float)value;
						num2 = num103;
					}
					else if (value is int)
					{
						int num104 = (int)value;
						num2 = (float)num104;
					}
					else if (value is long)
					{
						long num105 = (long)value;
						num2 = (float)num105;
					}
					else
					{
						num2 = (float)value;
					}
					this.SensitivityPitchMin = num2;
					return;
				}
				break;
			}
			case 20:
			{
				char c = key[1];
				if (c != 'i')
				{
					if (c != 'n')
					{
						if (c == 'u')
						{
							if (key == "AutopilotInputFactor")
							{
								float num2;
								if (value is double)
								{
									double num106 = (double)value;
									num2 = (float)num106;
								}
								else if (value is float)
								{
									float num107 = (float)value;
									num2 = num107;
								}
								else if (value is int)
								{
									int num108 = (int)value;
									num2 = (float)num108;
								}
								else if (value is long)
								{
									long num109 = (long)value;
									num2 = (float)num109;
								}
								else
								{
									num2 = (float)value;
								}
								this.AutopilotInputFactor = num2;
								return;
							}
						}
					}
					else if (key == "InputSpeedPercentage")
					{
						float num2;
						if (value is double)
						{
							double num110 = (double)value;
							num2 = (float)num110;
						}
						else if (value is float)
						{
							float num111 = (float)value;
							num2 = num111;
						}
						else if (value is int)
						{
							int num112 = (int)value;
							num2 = (float)num112;
						}
						else if (value is long)
						{
							long num113 = (long)value;
							num2 = (float)num113;
						}
						else
						{
							num2 = (float)value;
						}
						this.InputSpeedPercentage = num2;
						return;
					}
				}
				else if (key == "AimAssistSpeedCenter")
				{
					float num2;
					if (value is double)
					{
						double num114 = (double)value;
						num2 = (float)num114;
					}
					else if (value is float)
					{
						float num115 = (float)value;
						num2 = num115;
					}
					else if (value is int)
					{
						int num116 = (int)value;
						num2 = (float)num116;
					}
					else if (value is long)
					{
						long num117 = (long)value;
						num2 = (float)num117;
					}
					else
					{
						num2 = (float)value;
					}
					this.AimAssistSpeedCenter = num2;
					return;
				}
				break;
			}
			case 21:
			{
				char c = key[16];
				if (c != 'C')
				{
					if (c != 'R')
					{
						if (c == 'S')
						{
							if (key == "MobileDensityYawScale")
							{
								float num2;
								if (value is double)
								{
									double num118 = (double)value;
									num2 = (float)num118;
								}
								else if (value is float)
								{
									float num119 = (float)value;
									num2 = num119;
								}
								else if (value is int)
								{
									int num120 = (int)value;
									num2 = (float)num120;
								}
								else if (value is long)
								{
									long num121 = (long)value;
									num2 = (float)num121;
								}
								else
								{
									num2 = (float)value;
								}
								this.MobileDensityYawScale = num2;
								return;
							}
						}
					}
					else if (key == "SensitivityPitchRange")
					{
						float num2;
						if (value is double)
						{
							double num122 = (double)value;
							num2 = (float)num122;
						}
						else if (value is float)
						{
							float num123 = (float)value;
							num2 = num123;
						}
						else if (value is int)
						{
							int num124 = (int)value;
							num2 = (float)num124;
						}
						else if (value is long)
						{
							long num125 = (long)value;
							num2 = (float)num125;
						}
						else
						{
							num2 = (float)value;
						}
						this.SensitivityPitchRange = num2;
						return;
					}
				}
				else if (key == "SensitivityPitchCurve")
				{
					this.SensitivityPitchCurve = (CurveBase)value;
					return;
				}
				break;
			}
			case 22:
			{
				char c = key[1];
				if (c <= 'h')
				{
					if (c != 'a')
					{
						if (c == 'h')
						{
							if (key == "ChangedSelectedAimPart")
							{
								this.ChangedSelectedAimPart = (bool)value;
								return;
							}
						}
					}
					else
					{
						if (key == "GamePadSmoothFactorMin")
						{
							float num2;
							if (value is double)
							{
								double num126 = (double)value;
								num2 = (float)num126;
							}
							else if (value is float)
							{
								float num127 = (float)value;
								num2 = num127;
							}
							else if (value is int)
							{
								int num128 = (int)value;
								num2 = (float)num128;
							}
							else if (value is long)
							{
								long num129 = (long)value;
								num2 = (float)num129;
							}
							else
							{
								num2 = (float)value;
							}
							this.GamePadSmoothFactorMin = num2;
							return;
						}
						if (key == "GamePadSmoothFactorMax")
						{
							float num2;
							if (value is double)
							{
								double num130 = (double)value;
								num2 = (float)num130;
							}
							else if (value is float)
							{
								float num131 = (float)value;
								num2 = num131;
							}
							else if (value is int)
							{
								int num132 = (int)value;
								num2 = (float)num132;
							}
							else if (value is long)
							{
								long num133 = (long)value;
								num2 = (float)num133;
							}
							else
							{
								num2 = (float)value;
							}
							this.GamePadSmoothFactorMax = num2;
							return;
						}
					}
				}
				else if (c != 'i')
				{
					if (c == 'u')
					{
						if (key == "AutopilotInputAngleMin")
						{
							float num2;
							if (value is double)
							{
								double num134 = (double)value;
								num2 = (float)num134;
							}
							else if (value is float)
							{
								float num135 = (float)value;
								num2 = num135;
							}
							else if (value is int)
							{
								int num136 = (int)value;
								num2 = (float)num136;
							}
							else if (value is long)
							{
								long num137 = (long)value;
								num2 = (float)num137;
							}
							else
							{
								num2 = (float)value;
							}
							this.AutopilotInputAngleMin = num2;
							return;
						}
						if (key == "AutopilotInputAngleMax")
						{
							float num2;
							if (value is double)
							{
								double num138 = (double)value;
								num2 = (float)num138;
							}
							else if (value is float)
							{
								float num139 = (float)value;
								num2 = num139;
							}
							else if (value is int)
							{
								int num140 = (int)value;
								num2 = (float)num140;
							}
							else if (value is long)
							{
								long num141 = (long)value;
								num2 = (float)num141;
							}
							else
							{
								num2 = (float)value;
							}
							this.AutopilotInputAngleMax = num2;
							return;
						}
					}
				}
				else if (key == "AimAssistStartSpeedEnd")
				{
					float num2;
					if (value is double)
					{
						double num142 = (double)value;
						num2 = (float)num142;
					}
					else if (value is float)
					{
						float num143 = (float)value;
						num2 = num143;
					}
					else if (value is int)
					{
						int num144 = (int)value;
						num2 = (float)num144;
					}
					else if (value is long)
					{
						long num145 = (long)value;
						num2 = (float)num145;
					}
					else
					{
						num2 = (float)value;
					}
					this.AimAssistStartSpeedEnd = num2;
					return;
				}
				break;
			}
			case 23:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c == 'M')
					{
						if (key == "MobileDensityPitchScale")
						{
							float num2;
							if (value is double)
							{
								double num146 = (double)value;
								num2 = (float)num146;
							}
							else if (value is float)
							{
								float num147 = (float)value;
								num2 = num147;
							}
							else if (value is int)
							{
								int num148 = (int)value;
								num2 = (float)num148;
							}
							else if (value is long)
							{
								long num149 = (long)value;
								num2 = (float)num149;
							}
							else
							{
								num2 = (float)value;
							}
							this.MobileDensityPitchScale = num2;
							return;
						}
					}
				}
				else if (key == "AutopilotAngleTolerance")
				{
					float num2;
					if (value is double)
					{
						double num150 = (double)value;
						num2 = (float)num150;
					}
					else if (value is float)
					{
						float num151 = (float)value;
						num2 = num151;
					}
					else if (value is int)
					{
						int num152 = (int)value;
						num2 = (float)num152;
					}
					else if (value is long)
					{
						long num153 = (long)value;
						num2 = (float)num153;
					}
					else
					{
						num2 = (float)value;
					}
					this.AutopilotAngleTolerance = num2;
					return;
				}
				break;
			}
			case 24:
			{
				char c = key[19];
				if (c <= 'C')
				{
					if (c != 'B')
					{
						if (c == 'C')
						{
							if (key == "GamePadSmoothFactorCurve")
							{
								this.GamePadSmoothFactorCurve = (CurveBase)value;
								return;
							}
						}
					}
					else if (key == "AimAssistStartSpeedBegin")
					{
						float num2;
						if (value is double)
						{
							double num154 = (double)value;
							num2 = (float)num154;
						}
						else if (value is float)
						{
							float num155 = (float)value;
							num2 = num155;
						}
						else if (value is int)
						{
							int num156 = (int)value;
							num2 = (float)num156;
						}
						else if (value is long)
						{
							long num157 = (long)value;
							num2 = (float)num157;
						}
						else
						{
							num2 = (float)value;
						}
						this.AimAssistStartSpeedBegin = num2;
						return;
					}
				}
				else if (c != 'R')
				{
					if (c == 'e')
					{
						if (key == "AimAssistStartTimeLength")
						{
							float num2;
							if (value is double)
							{
								double num158 = (double)value;
								num2 = (float)num158;
							}
							else if (value is float)
							{
								float num159 = (float)value;
								num2 = num159;
							}
							else if (value is int)
							{
								int num160 = (int)value;
								num2 = (float)num160;
							}
							else if (value is long)
							{
								long num161 = (long)value;
								num2 = (float)num161;
							}
							else
							{
								num2 = (float)value;
							}
							this.AimAssistStartTimeLength = num2;
							return;
						}
					}
				}
				else if (key == "GamePadSmoothFactorRange")
				{
					float num2;
					if (value is double)
					{
						double num162 = (double)value;
						num2 = (float)num162;
					}
					else if (value is float)
					{
						float num163 = (float)value;
						num2 = num163;
					}
					else if (value is int)
					{
						int num164 = (int)value;
						num2 = (float)num164;
					}
					else if (value is long)
					{
						long num165 = (long)value;
						num2 = (float)num165;
					}
					else
					{
						num2 = (float)value;
					}
					this.GamePadSmoothFactorRange = num2;
					return;
				}
				break;
			}
			case 27:
				if (key == "AutopilotGamepadInputFactor")
				{
					float num2;
					if (value is double)
					{
						double num166 = (double)value;
						num2 = (float)num166;
					}
					else if (value is float)
					{
						float num167 = (float)value;
						num2 = num167;
					}
					else if (value is int)
					{
						int num168 = (int)value;
						num2 = (float)num168;
					}
					else if (value is long)
					{
						long num169 = (long)value;
						num2 = (float)num169;
					}
					else
					{
						num2 = (float)value;
					}
					this.AutopilotGamepadInputFactor = num2;
					return;
				}
				break;
			case 32:
				if (key == "SpecificCameraBaseYawSensitivity")
				{
					float num2;
					if (value is double)
					{
						double num170 = (double)value;
						num2 = (float)num170;
					}
					else if (value is float)
					{
						float num171 = (float)value;
						num2 = num171;
					}
					else if (value is int)
					{
						int num172 = (int)value;
						num2 = (float)num172;
					}
					else if (value is long)
					{
						long num173 = (long)value;
						num2 = (float)num173;
					}
					else
					{
						num2 = (float)value;
					}
					this.SpecificCameraBaseYawSensitivity = num2;
					return;
				}
				break;
			case 34:
			{
				char c = key[14];
				if (c != 'A')
				{
					if (c == 'B')
					{
						if (key == "SpecificCameraBasePitchSensitivity")
						{
							float num2;
							if (value is double)
							{
								double num174 = (double)value;
								num2 = (float)num174;
							}
							else if (value is float)
							{
								float num175 = (float)value;
								num2 = num175;
							}
							else if (value is int)
							{
								int num176 = (int)value;
								num2 = (float)num176;
							}
							else if (value is long)
							{
								long num177 = (long)value;
								num2 = (float)num177;
							}
							else
							{
								num2 = (float)value;
							}
							this.SpecificCameraBasePitchSensitivity = num2;
							return;
						}
					}
				}
				else if (key == "SpecificCameraAimingYawSensitivity")
				{
					float num2;
					if (value is double)
					{
						double num178 = (double)value;
						num2 = (float)num178;
					}
					else if (value is float)
					{
						float num179 = (float)value;
						num2 = num179;
					}
					else if (value is int)
					{
						int num180 = (int)value;
						num2 = (float)num180;
					}
					else if (value is long)
					{
						long num181 = (long)value;
						num2 = (float)num181;
					}
					else
					{
						num2 = (float)value;
					}
					this.SpecificCameraAimingYawSensitivity = num2;
					return;
				}
				break;
			}
			case 36:
				if (key == "SpecificCameraAimingPitchSensitivity")
				{
					float num2;
					if (value is double)
					{
						double num182 = (double)value;
						num2 = (float)num182;
					}
					else if (value is float)
					{
						float num183 = (float)value;
						num2 = num183;
					}
					else if (value is int)
					{
						int num184 = (int)value;
						num2 = (float)num184;
					}
					else if (value is long)
					{
						long num185 = (long)value;
						num2 = (float)num185;
					}
					else
					{
						num2 = (float)value;
					}
					this.SpecificCameraAimingPitchSensitivity = num2;
					return;
				}
				break;
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x000B6372 File Offset: 0x000B4572
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraInputController.<MemberIter>d__120 <MemberIter>d__ = new CameraInputController.<MemberIter>d__120(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040014B3 RID: 5299
	private const int DEFAULT_FPS = 60;

	// Token: 0x040014B4 RID: 5300
	private const float RANGE_TO_RADIUS = 0.7f;

	// Token: 0x040014B5 RID: 5301
	private const int DEFAULT_SEGMENT = 12;

	// Token: 0x040014B6 RID: 5302
	private const float MAX_AIM_ASSIST_ANGLE = 0.6981317f;

	// Token: 0x040014B7 RID: 5303
	private const float STOP_ON_START_ANGLE_THRESHOLD = 1f;

	// Token: 0x040014B8 RID: 5304
	private const float SHORT_AIM_START_TIME = 0.4f;

	// Token: 0x040014B9 RID: 5305
	private const float AIM_RANGE_TOLERANT = 1.05f;

	// Token: 0x040014BA RID: 5306
	private const int DEFAULT_DPI = 180;

	// Token: 0x040014BB RID: 5307
	private const float TOUCH_YAW_DELTA_TIME = 0.016666f;

	// Token: 0x040014BC RID: 5308
	private const float TOUCHPITCH_DELTA_TIME = 0.016666f;

	// Token: 0x040014BD RID: 5309
	private const float MAX_YAW_DELTA_TIME = 0.033333f;

	// Token: 0x040014BE RID: 5310
	private const float MAX_PITCH_DELTA_TIME = 0.033333f;

	// Token: 0x040014BF RID: 5311
	private const float PITCH_LIMIT_VALUE = 89.9f;

	// Token: 0x040014C0 RID: 5312
	public float ZoomSpeed;

	// Token: 0x040014C1 RID: 5313
	public float GamePadZoomSpeed;

	// Token: 0x040014C2 RID: 5314
	public float InputSpeedMax;

	// Token: 0x040014C3 RID: 5315
	public float InputSpeedPercentage;

	// Token: 0x040014C4 RID: 5316
	public float SmoothFactorMin;

	// Token: 0x040014C5 RID: 5317
	public float SmoothFactorMax;

	// Token: 0x040014C6 RID: 5318
	public float SmoothFactorRange;

	// Token: 0x040014C7 RID: 5319
	[Nullable(2)]
	public CurveBase SmoothFactorCurve;

	// Token: 0x040014C8 RID: 5320
	public float GamePadSmoothFactorMin;

	// Token: 0x040014C9 RID: 5321
	public float GamePadSmoothFactorMax;

	// Token: 0x040014CA RID: 5322
	public float GamePadSmoothFactorRange;

	// Token: 0x040014CB RID: 5323
	[Nullable(2)]
	public CurveBase GamePadSmoothFactorCurve;

	// Token: 0x040014CC RID: 5324
	public float SensitivityYawMin;

	// Token: 0x040014CD RID: 5325
	public float SensitivityYawMax;

	// Token: 0x040014CE RID: 5326
	public float SensitivityYawRange;

	// Token: 0x040014CF RID: 5327
	[Nullable(2)]
	public CurveBase SensitivityYawCurve;

	// Token: 0x040014D0 RID: 5328
	public float SensitivityPitchMin;

	// Token: 0x040014D1 RID: 5329
	public float SensitivityPitchMax;

	// Token: 0x040014D2 RID: 5330
	public float SensitivityPitchRange;

	// Token: 0x040014D3 RID: 5331
	[Nullable(2)]
	public CurveBase SensitivityPitchCurve;

	// Token: 0x040014D4 RID: 5332
	public float InputSpeedMin;

	// Token: 0x040014D5 RID: 5333
	public float GamepadInputRate;

	// Token: 0x040014D6 RID: 5334
	public float AimAssistSpeedCenter;

	// Token: 0x040014D7 RID: 5335
	public float AimAssistSpeedEdge;

	// Token: 0x040014D8 RID: 5336
	public float AimAssistRange;

	// Token: 0x040014D9 RID: 5337
	public float AimAssistDamping;

	// Token: 0x040014DA RID: 5338
	[Nullable(2)]
	public CurveBase AimAssistCurve;

	// Token: 0x040014DB RID: 5339
	public float AimAssistStartTimeLength;

	// Token: 0x040014DC RID: 5340
	public float AimAssistStartSpeedBegin;

	// Token: 0x040014DD RID: 5341
	public float AimAssistStartSpeedEnd;

	// Token: 0x040014DE RID: 5342
	[Nullable(2)]
	public CurveBase AimAssistStartCurve;

	// Token: 0x040014DF RID: 5343
	public float EnableAutopilot;

	// Token: 0x040014E0 RID: 5344
	public float AutopilotEnableTime;

	// Token: 0x040014E1 RID: 5345
	public float AutopilotAngleTolerance;

	// Token: 0x040014E2 RID: 5346
	public float AutopilotInputFactor;

	// Token: 0x040014E3 RID: 5347
	public float AutopilotGamepadInputFactor;

	// Token: 0x040014E4 RID: 5348
	public float AutopilotInputAngleMin;

	// Token: 0x040014E5 RID: 5349
	public float AutopilotInputAngleMax;

	// Token: 0x040014E6 RID: 5350
	public float AutopilotInputMin;

	// Token: 0x040014E7 RID: 5351
	public float AutopilotInputMax;

	// Token: 0x040014E8 RID: 5352
	private readonly Switcher InputEnable = new Switcher(true, null);

	// Token: 0x040014E9 RID: 5353
	private readonly HashSet<object> ArmRotationYawBlockSet = new HashSet<object>();

	// Token: 0x040014EA RID: 5354
	private readonly HashSet<object> ArmRotationPitchBlockSet = new HashSet<object>();

	// Token: 0x040014EB RID: 5355
	private readonly HashSet<object> ArmLengthBlockSet = new HashSet<object>();

	// Token: 0x040014EC RID: 5356
	private float ArmLength;

	// Token: 0x040014ED RID: 5357
	private float MinArmLength;

	// Token: 0x040014EE RID: 5358
	private float MaxArmLength;

	// Token: 0x040014EF RID: 5359
	private float CurrentInputYaw;

	// Token: 0x040014F0 RID: 5360
	private float CurrentInputPitch;

	// Token: 0x040014F1 RID: 5361
	private bool IsModifiedYaw;

	// Token: 0x040014F2 RID: 5362
	private bool IsModifiedPitch;

	// Token: 0x040014F3 RID: 5363
	private float AimTime;

	// Token: 0x040014F4 RID: 5364
	[Nullable(2)]
	private AimPart SelectedAimPart;

	// Token: 0x040014F5 RID: 5365
	private bool ChangedSelectedAimPart;

	// Token: 0x040014F6 RID: 5366
	[Nullable(2)]
	private UTraceLineElement LineTrace;

	// Token: 0x040014F7 RID: 5367
	private readonly Vector AimPoint = Vector.Create();

	// Token: 0x040014F8 RID: 5368
	private readonly Vector LastAimPoint = Vector.Create();

	// Token: 0x040014F9 RID: 5369
	private readonly Vector TmpVector = Vector.Create();

	// Token: 0x040014FA RID: 5370
	private readonly Vector TmpAimPoint = Vector.Create();

	// Token: 0x040014FB RID: 5371
	private readonly Vector TargetDirection = Vector.Create();

	// Token: 0x040014FC RID: 5372
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x040014FD RID: 5373
	private readonly Rotator TmpRotator2 = Rotator.Create();

	// Token: 0x040014FE RID: 5374
	private readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x040014FF RID: 5375
	private readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001500 RID: 5376
	private readonly Quat TmpQuat3 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x04001501 RID: 5377
	private readonly List<EntityHandle> EntityHandleList = new List<EntityHandle>();

	// Token: 0x04001502 RID: 5378
	[Nullable(new byte[]
	{
		1,
		0,
		1
	})]
	private readonly List<ValueTuple<float, AimPart>> SortList = new List<ValueTuple<float, AimPart>>();

	// Token: 0x04001503 RID: 5379
	private float MobileDensityYawScale;

	// Token: 0x04001504 RID: 5380
	private float MobileDensityPitchScale;

	// Token: 0x04001505 RID: 5381
	public float SpecificCameraBaseYawSensitivity = -1f;

	// Token: 0x04001506 RID: 5382
	public float SpecificCameraBasePitchSensitivity = -1f;

	// Token: 0x04001507 RID: 5383
	public float SpecificCameraAimingYawSensitivity = -1f;

	// Token: 0x04001508 RID: 5384
	public float SpecificCameraAimingPitchSensitivity = -1f;
}
