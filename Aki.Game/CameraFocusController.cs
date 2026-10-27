using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;

// Token: 0x020001FE RID: 510
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true)]
public class CameraFocusController : CameraControllerBase, ICanGetConfigMapValue
{
	// Token: 0x06002019 RID: 8217 RVA: 0x000A80A6 File Offset: 0x000A62A6
	public CameraFocusController(FightCameraLogicComponent camera) : base(camera)
	{
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x000A80E2 File Offset: 0x000A62E2
	public override string Name()
	{
		return "FocusController";
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x000A80EC File Offset: 0x000A62EC
	protected override void OnInit()
	{
		base.SetConfigMap(EFightCameraFocus.臂旋转Yaw过渡最小速度, "RelativeRotationLagYawSpeedMin");
		base.SetConfigMap(EFightCameraFocus.臂旋转Yaw过渡最大速度, "RelativeRotationLagYawSpeedMax");
		base.SetConfigMap(EFightCameraFocus.臂旋转Yaw过渡与目标Yaw角度最大差值, "RelativeRotationLagYawAngleRange");
		base.SetCurveConfigMap(EFightCameraFocus.臂旋转Yaw过渡与目标Yaw角度最大差值, "RelativeRotationLagYawCurve");
		base.SetConfigMap(EFightCameraFocus.臂旋转Pitch过渡最小速度, "RelativeRotationLagPitchSpeedMin");
		base.SetConfigMap(EFightCameraFocus.臂旋转Pitch过渡最大速度, "RelativeRotationLagPitchSpeedMax");
		base.SetConfigMap(EFightCameraFocus.臂旋转Pitch过渡与目标Pitch角度最大差值, "RelativeRotationLagPitchAngleRange");
		base.SetCurveConfigMap(EFightCameraFocus.臂旋转Pitch过渡与目标Pitch角度最大差值, "RelativeRotationLagPitchCurve");
		base.SetConfigMap(EFightCameraFocus.臂旋转过渡速度最小系数_目标距离_, "RelativeRotationLagRatioMin");
		base.SetConfigMap(EFightCameraFocus.臂旋转过渡速度最大系数_目标距离_, "RelativeRotationLagRatioMax");
		base.SetConfigMap(EFightCameraFocus.臂旋转过渡速度最小距离_目标距离_, "RelativeRotationLagDistanceRangeMin");
		base.SetConfigMap(EFightCameraFocus.臂旋转过渡速度最大距离_目标距离_, "RelativeRotationLagDistanceRangeMax");
		base.SetCurveConfigMap(EFightCameraFocus.臂旋转过渡速度最大距离_目标距离_, "RelativeRotationLagRatioCurve");
		base.SetConfigMap(EFightCameraFocus.强锁定_启动左右对峙, "YawSignAdaptionOn");
		base.SetConfigMap(EFightCameraFocus.强锁定_左右对峙_交换角度, "YawSignAdaptionThreshold");
		base.SetConfigMap(EFightCameraFocus.强锁定_左右对峙_交换冷却, "YawSignAdaptionCooldown");
		base.SetConfigMap(EFightCameraFocus.强锁定_左右对峙_启动距离阈值, "YawSignAdaptionDistanceThreshold");
		base.SetConfigMap(EFightCameraFocus.强锁定_左右对峙_锁定方向, "YawSignAdaptionLockDirection");
		base.SetConfigMap(EFightCameraFocus.软锁定_镜头偏角最小值, "RelativeYawSoftMin");
		base.SetConfigMap(EFightCameraFocus.软锁定_镜头偏角最大值, "RelativeYawSoftMax");
		base.SetConfigMap(EFightCameraFocus.软锁定_镜头输入缓冲时间, "SoftUnlockInputTime");
		base.SetConfigMap(EFightCameraFocus.软锁定_镜头Yaw输入启动速度, "SoftUnlockInputYawMinSpeed");
		base.SetConfigMap(EFightCameraFocus.软锁定_镜头Pitch输入启动速度, "SoftUnlockInputPitchMinSpeed");
		base.SetConfigMap(EFightCameraFocus.软锁定_锁定时相机臂偏移Y, "CameraOffsetSoft");
		base.SetConfigMap(EFightCameraFocus.强锁定_锁定时相机臂偏移Y, "CameraOffset");
		base.SetConfigMap(EFightCameraFocus.强锁定_输入灵敏度Yaw, "HardLockInputYawSensitivity");
		base.SetConfigMap(EFightCameraFocus.强锁定_输入灵敏度Pitch, "HardLockInputPitchSensitivity");
		base.SetConfigMap(EFightCameraFocus.强锁定_输入灵敏度Yaw_手柄, "HardLockInputYawSensitivityGamepad");
		base.SetConfigMap(EFightCameraFocus.强锁定_输入灵敏度Pitch_手柄, "HardLockInputPitchSensitivityGamepad");
		base.SetConfigMap(EFightCameraFocus.软锁定_输入灵敏度Yaw, "SoftLockInputYawSensitivity");
		base.SetConfigMap(EFightCameraFocus.软锁定_输入灵敏度Pitch, "SoftLockInputPitchSensitivity");
		base.SetConfigMap(EFightCameraFocus.软锁定_输入灵敏度Yaw_手柄, "SoftLockInputYawSensitivityGamepad");
		base.SetConfigMap(EFightCameraFocus.软锁定_输入灵敏度Pitch_手柄, "SoftLockInputPitchSensitivityGamepad");
		base.SetConfigMap(EFightCameraFocus.强锁定_切换目标_输入衰减律, "ChangeShowTargetDamping");
		base.SetConfigMap(EFightCameraFocus.强锁定_切换目标_角度系数, "ChangeShowTargetAngleCoefficient");
		base.SetConfigMap(EFightCameraFocus.强锁定_切换目标_距离系数, "ChangeShowTargetDistCoefficient");
		base.SetConfigMap(EFightCameraFocus.强锁定_镜头偏角最小值, "RelativeYawHardMin");
		base.SetConfigMap(EFightCameraFocus.强锁定_镜头偏角最大值, "RelativeYawHardMax");
		base.SetConfigMap(EFightCameraFocus.强锁定_镜头俯仰角最小值, "RelativePitchHardMin");
		base.SetConfigMap(EFightCameraFocus.强锁定_镜头俯仰角最大值, "RelativePitchHardMax");
		base.SetConfigMap(EFightCameraFocus.软锁定_镜头Yaw输入解锁速度, "SoftUnlockYawSpeed");
		base.SetConfigMap(EFightCameraFocus.软锁定_镜头Pitch输入解锁速度, "SoftUnlockPitchSpeed");
		base.SetConfigMap(EFightCameraFocus.强锁定_切换目标_启动速度, "ChangeShowTargetSensitivity");
		base.SetConfigMap(EFightCameraFocus.强锁定_切换目标_启动速度_手柄, "ChangeShowTargetSensitivityGamepad");
		base.RegisterPairConfigKey(EFightCameraFocus.臂旋转Yaw过渡最小速度, EFightCameraFocus.臂旋转Yaw过渡最大速度, true);
		base.RegisterPairConfigKey(EFightCameraFocus.臂旋转Pitch过渡最小速度, EFightCameraFocus.臂旋转Pitch过渡最大速度, true);
		base.RegisterPairConfigKey(EFightCameraFocus.软锁定_镜头偏角最小值, EFightCameraFocus.软锁定_镜头偏角最大值, true);
		base.RegisterPairConfigKey(EFightCameraFocus.强锁定_镜头偏角最小值, EFightCameraFocus.强锁定_镜头偏角最大值, true);
		base.RegisterPairConfigKey(EFightCameraFocus.强锁定_镜头俯仰角最小值, EFightCameraFocus.强锁定_镜头俯仰角最大值, true);
		base.RegisterPairConfigKey(EFightCameraFocus.臂旋转过渡速度最小距离_目标距离_, EFightCameraFocus.臂旋转过渡速度最大距离_目标距离_, true);
		base.RegisterPairConfigKey(EFightCameraFocus.臂旋转过渡速度最小系数_目标距离_, EFightCameraFocus.臂旋转过渡速度最大系数_目标距离_, true);
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000A8498 File Offset: 0x000A6698
	protected override void OnEnable()
	{
		this.Camera.CameraAutoController.EnableForce(this);
		this.Camera.CameraSidestepController.Lock(this);
		this.AddCameraOffsetY = new float?(0f);
		EventSystem.Instance.Add<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x000A84F0 File Offset: 0x000A66F0
	protected override void OnDisable()
	{
		EventSystem.Instance.Remove<int, int, bool>(EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
		this.Camera.CameraAutoController.DisableForce(this);
		this.Camera.CameraSidestepController.Unlock(this);
		this.ExpectedYawSign = 0f;
		this.PrevChangeYawSignTime = 0f;
		this.SumYawPitchInput.Reset();
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x000A8559 File Offset: 0x000A6759
	protected override bool UpdateCustomEnableCondition()
	{
		return this.HasTarget() && this.Camera.CharacterEntityHandle.IsInit;
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000A8578 File Offset: 0x000A6778
	private bool HasTarget()
	{
		if (this.Camera.TargetEntity == null)
		{
			FightCameraLogicComponent camera = this.Camera;
			return camera != null && camera.IsSpecificLockTarget && camera.SpecificLockTargetType == ECameraSpecificLockType.Location;
		}
		return true;
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x000A85B1 File Offset: 0x000A67B1
	protected override void UpdateInternal(float deltaSeconds)
	{
		this.UpdateSoftUnlockState((double)deltaSeconds);
		this.UpdateArmRotation(deltaSeconds);
		this.UpdateShowTarget((double)deltaSeconds);
	}

	// Token: 0x06002021 RID: 8225 RVA: 0x000A85CC File Offset: 0x000A67CC
	private void UpdateSoftUnlockState(double deltaSeconds)
	{
		if (!this.HasTarget() || !this.Camera.IsTargetLocationValid)
		{
			return;
		}
		ValueTuple<float, float> cameraInput = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetCameraInput();
		float num = cameraInput.Item1;
		float num2 = cameraInput.Item2;
		num *= (Info.Instance.IsInGamepad() ? this.SoftLockInputYawSensitivityGamepad : this.SoftLockInputYawSensitivity);
		num2 *= (Info.Instance.IsInGamepad() ? this.SoftLockInputPitchSensitivityGamepad : this.SoftLockInputPitchSensitivity);
		if (Math.Abs(num) > this.SoftUnlockInputYawMinSpeed || Math.Abs(num2) > this.SoftUnlockInputPitchMinSpeed)
		{
			this.SoftUnlockInputRemainTime = (double)this.SoftUnlockInputTime;
		}
		if (this.SoftUnlockInputRemainTime <= 0.0)
		{
			return;
		}
		this.SoftUnlockInputRemainTime -= deltaSeconds;
	}

	// Token: 0x06002022 RID: 8226 RVA: 0x000A869C File Offset: 0x000A689C
	private unsafe void UpdateArmRotation(float deltaSeconds)
	{
		if (!this.HasTarget() || !this.Camera.IsTargetLocationValid)
		{
			return;
		}
		if (this.Camera.IsModifiedArmRotationPitch && this.Camera.IsModifiedArmRotationYaw)
		{
			return;
		}
		ValueTuple<float, float> cameraInput = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetCameraInput();
		float item = cameraInput.Item1;
		float item2 = cameraInput.Item2;
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
		bool isSoftLockEnable = !flag && base.CameraModel.IsSoftLockEnable() && !this.ShouldSoftUnlock() && !this.CanMoveCameraInSoftLock();
		Vector playerLocation = this.Camera.PlayerLocation;
		this.Camera.TargetLocation.Subtraction(playerLocation, this.TargetOffset);
		this.UpdateTargetYaw(deltaSeconds, flag || this.Camera.IsSpecificLockTarget, isSoftLockEnable, item);
		this.UpdateTargetPitch(deltaSeconds, flag || this.Camera.IsSpecificLockTarget, isSoftLockEnable, item2);
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x000A87E4 File Offset: 0x000A69E4
	private void UpdateTargetYaw(float deltaSeconds, bool isLockSight, bool isSoftLockEnable, float inputYaw)
	{
		if (this.Camera.IsModifiedArmRotationYaw)
		{
			return;
		}
		this.Camera.IsModifiedArmRotationYaw = true;
		float value = this.AddCameraOffsetY.GetValueOrDefault();
		if (this.AddCameraOffsetY == null)
		{
			value = 0f;
			this.AddCameraOffsetY = new float?(value);
		}
		float num = 0f;
		bool flag = false;
		float min = 0f;
		float max = 0f;
		this.TargetRotator.Yaw = (float)(Math.Atan2(this.TargetOffset.Y, this.TargetOffset.X) * 57.295780181884766);
		float num2 = MathUtils.Instance.WrapAngle(this.Camera.CameraRotation.Yaw - this.TargetRotator.Yaw);
		float num3 = (float)((num2 >= 0f) ? 1 : -1);
		this.TargetOffset.Rotation(this.TmpRotator);
		float yaw = GravityUtils.Instance.GetRotatorInGravity(this.TmpRotator, this.Camera.GravityInverseQuat, this.TmpRotator).Yaw;
		float yaw2 = GravityUtils.Instance.GetRotatorInGravity(this.Camera.CameraRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Yaw;
		float yaw3 = GravityUtils.Instance.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Yaw;
		if (!this.Camera.IsInNormalGravityMode())
		{
			this.TargetRotator.Yaw = yaw;
			num2 = MathUtils.Instance.WrapAngle(yaw2 - yaw);
			num3 = (float)((num2 >= 0f) ? 1 : -1);
		}
		if (isLockSight)
		{
			if (this.YawSignAdaptionOn != 0f)
			{
				float num4 = 0f;
				float num5 = inputYaw * (Info.Instance.IsInGamepad() ? this.HardLockInputYawSensitivityGamepad : this.HardLockInputYawSensitivity);
				float num6 = (float)((num5 >= 0f) ? 1 : -1);
				if (this.ExpectedYawSign == 0f)
				{
					this.ExpectedYawSign = num3;
					this.PrevChangeYawSignTime = (float)Time.Instance.Now;
				}
				if (MathUtils.Instance.IsNearlyEqual((double)this.YawSignAdaptionLockDirection, -1.0, null))
				{
					this.ExpectedYawSign = -1f;
				}
				else if (MathUtils.Instance.IsNearlyEqual((double)this.YawSignAdaptionLockDirection, 1.0, null))
				{
					this.ExpectedYawSign = 1f;
				}
				else if (Time.Instance.Now > (double)(this.PrevChangeYawSignTime + this.YawSignAdaptionCooldown) && this.ExpectedYawSign != num3)
				{
					this.ExpectedYawSign = num3;
					this.PrevChangeYawSignTime = (float)Time.Instance.Now;
				}
				float num7 = 0f;
				float num8 = 180f;
				if (MathUtils.Instance.Square((double)this.YawSignAdaptionDistanceThreshold) < this.TargetOffset.SizeSquared())
				{
					num7 = this.RelativeYawHardMin;
					num8 = this.RelativeYawHardMax;
				}
				if (Math.Abs(num2) < num7)
				{
					num4 += this.ExpectedYawSign * num7;
					if (num6 == num3)
					{
						num4 += num5;
					}
				}
				else if (Math.Abs(num2) > num8)
				{
					num4 += this.ExpectedYawSign * num8;
					if (num6 != num3)
					{
						num4 += num5;
					}
				}
				else
				{
					float num9 = num2 + num5;
					if (num3 * num9 < 0f)
					{
						if (num3 == num6 && num8 != 180f)
						{
							float val = MathUtils.Instance.WrapAngle(this.TargetRotator.Yaw + this.ExpectedYawSign * num8);
							float val2 = MathUtils.Instance.WrapAngle(this.TargetRotator.Yaw + this.ExpectedYawSign * num7);
							max = Math.Max(val2, val);
							min = Math.Min(val2, val);
							flag = true;
						}
						if (num3 != num6 && num7 != 0f)
						{
							double val3 = (double)MathUtils.Instance.WrapAngle(this.TargetRotator.Yaw + this.ExpectedYawSign * num8);
							double val4 = (double)MathUtils.Instance.WrapAngle(this.TargetRotator.Yaw + this.ExpectedYawSign * num7);
							max = (float)Math.Max(val4, val3);
							min = (float)Math.Min(val4, val3);
							flag = true;
						}
					}
					num4 += num9;
				}
				num4 = MathUtils.Instance.Clamp(num4, num2 - 179f, num2 + 179f);
				this.TargetRotator.Yaw = MathUtils.Instance.WrapAngle(this.TargetRotator.Yaw + num4);
				num = num3 * this.CameraOffset;
			}
		}
		else
		{
			if (isSoftLockEnable)
			{
				CharacterLockOnComponent component = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterLockOnComponent>();
				if (component != null && component != null)
				{
					EntityHandle showTarget = component.ShowTarget;
					if (((showTarget != null) ? new bool?(showTarget.Valid) : null).GetValueOrDefault())
					{
						if (Math.Abs(num2) < this.RelativeYawSoftMin)
						{
							this.TargetRotator.Yaw += num3 * this.RelativeYawSoftMin;
						}
						else if (Math.Abs(num2) > this.RelativeYawSoftMax)
						{
							this.TargetRotator.Yaw += num3 * this.RelativeYawSoftMax;
						}
						else
						{
							this.TargetRotator.Yaw = yaw2;
						}
					}
				}
			}
			else
			{
				this.TargetRotator.Yaw = yaw3;
			}
			num = num3 * this.CameraOffsetSoft;
		}
		float num10 = Math.Abs(num - this.AddCameraOffsetY.Value);
		if (num10 > 100f * deltaSeconds)
		{
			this.AddCameraOffsetY = new float?(MathUtils.Instance.Lerp(this.AddCameraOffsetY.Value, num, 100f * deltaSeconds / num10));
		}
		else
		{
			this.AddCameraOffsetY = new float?(num);
		}
		float num11 = MathUtils.Instance.Lerp(this.RelativeRotationLagRatioMin, this.RelativeRotationLagRatioMax, this.RelativeRotationLagRatioCurve.GetCurrentValue((float)((this.TargetOffset.Size2D() - (double)this.RelativeRotationLagDistanceRangeMin) / (double)(this.RelativeRotationLagDistanceRangeMax - this.RelativeRotationLagDistanceRangeMin))));
		float num12 = MathUtils.Instance.Lerp(this.RelativeRotationLagYawSpeedMin, this.RelativeRotationLagYawSpeedMax, this.RelativeRotationLagYawCurve.GetCurrentValue(Math.Abs(num2) / this.RelativeRotationLagYawAngleRange));
		if (this.Camera.IsInNormalGravityMode())
		{
			this.Camera.DesiredCamera.ArmRotation.Yaw = MathUtils.Instance.RotatorAxisInterpTo(this.Camera.CurrentCamera.ArmRotation.Yaw, this.TargetRotator.Yaw, deltaSeconds, num11 * num12);
		}
		else
		{
			CameraUtility.SetYawInGravity(this.Camera.DesiredCamera.ArmRotation, (double)MathUtils.Instance.RotatorAxisInterpTo(yaw3, this.TargetRotator.Yaw, deltaSeconds, num11 * num12), this.Camera.DesiredCamera.ArmRotation);
		}
		if (flag)
		{
			this.Camera.DesiredCamera.ArmRotation.Yaw = MathUtils.Instance.Clamp(this.Camera.DesiredCamera.ArmRotation.Yaw, min, max);
		}
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x000A8EE4 File Offset: 0x000A70E4
	private void UpdateTargetPitch(float deltaSeconds, bool isLockSight, bool isSoftLockEnable, float inputPitch)
	{
		if (this.Camera.IsModifiedArmRotationPitch)
		{
			return;
		}
		this.Camera.IsModifiedArmRotationPitch = true;
		this.TargetRotator.Pitch = this.Camera.AdjustPitch(this.TargetOffset);
		float num = MathUtils.Instance.WrapAngle(this.Camera.CameraRotation.Pitch - this.TargetRotator.Pitch);
		float num2 = (float)((num >= 0f) ? 1 : -1);
		float pitch = GravityUtils.Instance.GetRotatorInGravity(this.Camera.CameraRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Pitch;
		float pitch2 = GravityUtils.Instance.GetRotatorInGravity(this.Camera.CurrentCamera.ArmRotation, this.Camera.GravityInverseQuat, this.TmpRotator).Pitch;
		if (!this.Camera.IsInNormalGravityMode())
		{
			num = MathUtils.Instance.WrapAngle(pitch - this.TargetRotator.Pitch);
			num2 = (float)((num >= 0f) ? 1 : -1);
		}
		if (isLockSight)
		{
			if (this.YawSignAdaptionOn != 0f)
			{
				double num3 = 0.0;
				double num4 = (double)inputPitch;
				num4 *= (double)(Info.Instance.IsInGamepad() ? this.HardLockInputPitchSensitivityGamepad : this.HardLockInputPitchSensitivity);
				num4 = -num4;
				double num5 = (double)((num4 >= 0.0) ? 1 : -1);
				if (Math.Abs(num) < this.RelativePitchHardMin)
				{
					num3 += (double)(num2 * this.RelativePitchHardMin);
					if (num5 == (double)num2)
					{
						num3 += num4;
					}
				}
				else if (Math.Abs(num) > this.RelativePitchHardMax)
				{
					num3 += (double)(num2 * this.RelativePitchHardMax);
					if (num5 != (double)num2)
					{
						num3 += num4;
					}
				}
				else
				{
					double num6 = (double)num + num4;
					num3 += num6;
				}
				num3 = MathUtils.Instance.Clamp(num3, (double)(num - 179f), (double)(num + 179f));
				this.TargetRotator.Pitch = (float)MathUtils.Instance.WrapAngle((double)this.TargetRotator.Pitch + num3);
			}
		}
		else if (!isSoftLockEnable)
		{
			if (this.Camera.IsInNormalGravityMode())
			{
				this.TargetRotator.Pitch = this.Camera.CurrentCamera.ArmRotation.Pitch;
			}
			else
			{
				this.TargetRotator.Pitch = pitch2;
			}
		}
		float interpSpeed = MathUtils.Instance.Lerp(this.RelativeRotationLagPitchSpeedMin, this.RelativeRotationLagPitchSpeedMax, this.RelativeRotationLagPitchCurve.GetCurrentValue(Math.Abs(num) / this.RelativeRotationLagPitchAngleRange));
		if (this.Camera.IsInNormalGravityMode())
		{
			this.Camera.DesiredCamera.ArmRotation.Pitch = MathUtils.Instance.RotatorAxisInterpTo(this.Camera.CurrentCamera.ArmRotation.Pitch, this.TargetRotator.Pitch, deltaSeconds, interpSpeed);
			return;
		}
		CameraUtility.SetPitchInGravity(this.Camera.DesiredCamera.ArmRotation, (double)MathUtils.Instance.RotatorAxisInterpTo(pitch2, this.TargetRotator.Pitch, deltaSeconds, interpSpeed), this.Camera.DesiredCamera.ArmRotation);
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000A91F4 File Offset: 0x000A73F4
	private void UpdateShowTarget(double deltaSeconds)
	{
		if (!this.Camera.ContainsTag(GameplayTagDefine.EGameplayTagId["行为状态.方向状态.注视方向"], false))
		{
			this.SumYawPitchInput.Reset();
			this.FirstInput = true;
			return;
		}
		ValueTuple<float, float> cameraInput = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetCameraInput();
		float item = cameraInput.Item1;
		float item2 = cameraInput.Item2;
		if (item == 0f && item2 == 0f)
		{
			this.SumYawPitchInput.Reset();
			this.FirstInput = true;
			return;
		}
		double num = (double)(-(double)item2);
		double num2 = (double)(Info.Instance.IsInGamepad() ? this.ChangeShowTargetSensitivityGamepad : this.ChangeShowTargetSensitivity) * deltaSeconds;
		if ((double)item * this.SumYawPitchInput.X + num * this.SumYawPitchInput.Y <= 0.0)
		{
			this.FirstInput = true;
			this.SumYawPitchInput.Set((double)item * num2, num * num2);
		}
		else
		{
			this.SumYawPitchInput.X += (double)item * num2;
			this.SumYawPitchInput.Y += num * num2;
		}
		double num3 = this.SumYawPitchInput.SizeSquared();
		if (num3 > (this.FirstInput ? 0.25 : 1.0))
		{
			double num4 = Math.Sqrt(num3);
			this.SumYawPitchInput.DivisionEqual((double)((float)num4));
			this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterLockOnComponent>().ChangeShowTarget(this.SumYawPitchInput, this.ChangeShowTargetAngleCoefficient, this.ChangeShowTargetDistCoefficient);
			this.SumYawPitchInput.MultiplyEqual((double)((float)(num4 - (double)(this.FirstInput ? 0.5f : 1f))));
			this.FirstInput = false;
		}
		this.SumYawPitchInput.MultiplyEqual((double)((float)Math.Pow((double)(1f - this.ChangeShowTargetDamping), deltaSeconds * 60.0)));
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x000A93D8 File Offset: 0x000A75D8
	protected override void UpdateDeactivateInternal(float deltaSeconds)
	{
		this.ClearUnlockInputRemainTime();
		if (this.AddCameraOffsetY == null)
		{
			return;
		}
		int num = 0;
		float num2 = Math.Abs((float)num - this.AddCameraOffsetY.Value);
		if (num2 > 100f * deltaSeconds)
		{
			this.AddCameraOffsetY = new float?(MathUtils.Instance.Lerp(this.AddCameraOffsetY.Value, (float)num, 100f * deltaSeconds / num2));
			return;
		}
		this.AddCameraOffsetY = null;
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000A9454 File Offset: 0x000A7654
	private void OnCharUseSkill(int charId, int skillId, bool isAutonomousProxy)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
		int? num = (entity != null) ? new int?(entity.Id) : null;
		if (!(charId == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		CharacterSkillComponent component = entity.GetComponent<CharacterSkillComponent>();
		if (component != null && component.Valid)
		{
			Skill currentSkill = component.CurrentSkill;
			if (currentSkill != null && currentSkill.SkillInfo.IsLockOn)
			{
				this.ClearUnlockInputRemainTime();
				return;
			}
		}
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000A94E0 File Offset: 0x000A76E0
	public bool ShouldSoftUnlock()
	{
		ValueTuple<float, float> cameraInput = this.Camera.CharacterEntityHandle.Entity.GetComponent<CharacterInputComponent>().GetCameraInput();
		float num = cameraInput.Item1;
		float num2 = cameraInput.Item2;
		num *= (Info.Instance.IsInGamepad() ? this.SoftLockInputYawSensitivityGamepad : this.SoftLockInputYawSensitivity);
		num2 *= (Info.Instance.IsInGamepad() ? this.SoftLockInputPitchSensitivityGamepad : this.SoftLockInputPitchSensitivity);
		return Math.Abs(num) > this.SoftUnlockYawSpeed || Math.Abs(num2) > this.SoftUnlockPitchSpeed;
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000A956C File Offset: 0x000A776C
	public bool CanMoveCameraInSoftLock()
	{
		return this.SoftUnlockInputRemainTime > 0.0;
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000A957F File Offset: 0x000A777F
	private void ClearUnlockInputRemainTime()
	{
		this.SoftUnlockInputRemainTime = 0.0;
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x000A9590 File Offset: 0x000A7790
	public override string GetConfigMapValue(int key)
	{
		return base.GetConfigMapValue(key);
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000A959C File Offset: 0x000A779C
	public override void PostProcessConfig(Dictionary<int, float> config, Dictionary<int, CurveBase> curveConfig)
	{
		base.PostProcessConfig(config, curveConfig);
		if (this.RelativeYawHardMin < 0f || this.RelativeYawHardMin > 180f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Controller;
			ELogAuthor author = ELogAuthor.LJM;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
			defaultInterpolatedStringHandler.AppendLiteral("锁定镜头配置错误，强锁定-镜头偏角最小值");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.RelativeYawHardMin);
			defaultInterpolatedStringHandler.AppendLiteral("不在0-180之间或者大于强锁定-镜头偏角最大值");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.RelativeYawHardMax);
			instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (this.RelativeYawHardMax < 0f || this.RelativeYawHardMax > 180f)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Controller;
			ELogAuthor author2 = ELogAuthor.LJM;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(44, 2);
			defaultInterpolatedStringHandler.AppendLiteral("锁定镜头配置错误，强锁定-镜头偏角最大值");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.RelativeYawHardMax);
			defaultInterpolatedStringHandler.AppendLiteral("不在0-180之间或者小于强锁定-镜头偏角最小值");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.RelativeYawHardMin);
			instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (this.RelativePitchHardMin < 0f || this.RelativePitchHardMin > 180f)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Controller;
			ELogAuthor author3 = ELogAuthor.LJM;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
			defaultInterpolatedStringHandler.AppendLiteral("锁定镜头配置错误，强锁定-镜头俯仰角最小值");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.RelativePitchHardMin);
			defaultInterpolatedStringHandler.AppendLiteral("不在0-180之间或者大于强锁定-镜头俯仰角最大值");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.RelativePitchHardMax);
			instance3.Error(module3, author3, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
		if (this.RelativePitchHardMax < 0f || this.RelativePitchHardMax > 180f)
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.Controller;
			ELogAuthor author4 = ELogAuthor.LJM;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(46, 2);
			defaultInterpolatedStringHandler.AppendLiteral("锁定镜头配置错误，强锁定-镜头俯仰角最大值");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.RelativePitchHardMax);
			defaultInterpolatedStringHandler.AppendLiteral("不在0-180之间或者小于强锁定-镜头俯仰角最小值");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.RelativePitchHardMin);
			instance4.Error(module4, author4, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
		}
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x000A9790 File Offset: 0x000A7990
	[NullableContext(0)]
	public override bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 10:
			{
				char c = key[0];
				if (c != 'F')
				{
					if (c == 'T')
					{
						if (key == "TmpRotator")
						{
							value = this.TmpRotator;
							return true;
						}
					}
				}
				else if (key == "FirstInput")
				{
					value = this.FirstInput;
					return true;
				}
				break;
			}
			case 12:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'T')
					{
						if (key == "TargetOffset")
						{
							value = this.TargetOffset;
							return true;
						}
					}
				}
				else if (key == "CameraOffset")
				{
					value = this.CameraOffset;
					return true;
				}
				break;
			}
			case 13:
				if (key == "TargetRotator")
				{
					value = this.TargetRotator;
					return true;
				}
				break;
			case 15:
				if (key == "ExpectedYawSign")
				{
					value = this.ExpectedYawSign;
					return true;
				}
				break;
			case 16:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c != 'C')
					{
						if (c == 'S')
						{
							if (key == "SumYawPitchInput")
							{
								value = this.SumYawPitchInput;
								return true;
							}
						}
					}
					else if (key == "CameraOffsetSoft")
					{
						value = this.CameraOffsetSoft;
						return true;
					}
				}
				else if (key == "AddCameraOffsetY")
				{
					value = this.AddCameraOffsetY;
					return true;
				}
				break;
			}
			case 17:
				if (key == "YawSignAdaptionOn")
				{
					value = this.YawSignAdaptionOn;
					return true;
				}
				break;
			case 18:
			{
				char c = key[11];
				if (c != 'H')
				{
					if (c != 'S')
					{
						if (c == 'a')
						{
							if (key == "SoftUnlockYawSpeed")
							{
								value = this.SoftUnlockYawSpeed;
								return true;
							}
						}
					}
					else
					{
						if (key == "RelativeYawSoftMin")
						{
							value = this.RelativeYawSoftMin;
							return true;
						}
						if (key == "RelativeYawSoftMax")
						{
							value = this.RelativeYawSoftMax;
							return true;
						}
					}
				}
				else
				{
					if (key == "RelativeYawHardMax")
					{
						value = this.RelativeYawHardMax;
						return true;
					}
					if (key == "RelativeYawHardMin")
					{
						value = this.RelativeYawHardMin;
						return true;
					}
				}
				break;
			}
			case 19:
				if (key == "SoftUnlockInputTime")
				{
					value = this.SoftUnlockInputTime;
					return true;
				}
				break;
			case 20:
			{
				char c = key[18];
				if (c != 'a')
				{
					if (c != 'e')
					{
						if (c == 'i')
						{
							if (key == "RelativePitchHardMin")
							{
								value = this.RelativePitchHardMin;
								return true;
							}
						}
					}
					else if (key == "SoftUnlockPitchSpeed")
					{
						value = this.SoftUnlockPitchSpeed;
						return true;
					}
				}
				else if (key == "RelativePitchHardMax")
				{
					value = this.RelativePitchHardMax;
					return true;
				}
				break;
			}
			case 21:
				if (key == "PrevChangeYawSignTime")
				{
					value = this.PrevChangeYawSignTime;
					return true;
				}
				break;
			case 23:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'Y')
					{
						if (key == "YawSignAdaptionCooldown")
						{
							value = this.YawSignAdaptionCooldown;
							return true;
						}
					}
				}
				else if (key == "ChangeShowTargetDamping")
				{
					value = this.ChangeShowTargetDamping;
					return true;
				}
				break;
			}
			case 24:
				if (key == "YawSignAdaptionThreshold")
				{
					value = this.YawSignAdaptionThreshold;
					return true;
				}
				break;
			case 25:
				if (key == "SoftUnlockInputRemainTime")
				{
					value = this.SoftUnlockInputRemainTime;
					return true;
				}
				break;
			case 26:
				if (key == "SoftUnlockInputYawMinSpeed")
				{
					value = this.SoftUnlockInputYawMinSpeed;
					return true;
				}
				break;
			case 27:
			{
				char c = key[0];
				if (c <= 'H')
				{
					if (c != 'C')
					{
						if (c == 'H')
						{
							if (key == "HardLockInputYawSensitivity")
							{
								value = this.HardLockInputYawSensitivity;
								return true;
							}
						}
					}
					else if (key == "ChangeShowTargetSensitivity")
					{
						value = this.ChangeShowTargetSensitivity;
						return true;
					}
				}
				else if (c != 'R')
				{
					if (c == 'S')
					{
						if (key == "SoftLockInputYawSensitivity")
						{
							value = this.SoftLockInputYawSensitivity;
							return true;
						}
					}
				}
				else
				{
					if (key == "RelativeRotationLagYawCurve")
					{
						value = this.RelativeRotationLagYawCurve;
						return true;
					}
					if (key == "RelativeRotationLagRatioMin")
					{
						value = this.RelativeRotationLagRatioMin;
						return true;
					}
					if (key == "RelativeRotationLagRatioMax")
					{
						value = this.RelativeRotationLagRatioMax;
						return true;
					}
				}
				break;
			}
			case 28:
			{
				char c = key[0];
				if (c != 'S')
				{
					if (c == 'Y')
					{
						if (key == "YawSignAdaptionLockDirection")
						{
							value = this.YawSignAdaptionLockDirection;
							return true;
						}
					}
				}
				else if (key == "SoftUnlockInputPitchMinSpeed")
				{
					value = this.SoftUnlockInputPitchMinSpeed;
					return true;
				}
				break;
			}
			case 29:
			{
				char c = key[0];
				if (c != 'H')
				{
					if (c != 'R')
					{
						if (c == 'S')
						{
							if (key == "SoftLockInputPitchSensitivity")
							{
								value = this.SoftLockInputPitchSensitivity;
								return true;
							}
						}
					}
					else
					{
						if (key == "RelativeRotationLagPitchCurve")
						{
							value = this.RelativeRotationLagPitchCurve;
							return true;
						}
						if (key == "RelativeRotationLagRatioCurve")
						{
							value = this.RelativeRotationLagRatioCurve;
							return true;
						}
					}
				}
				else if (key == "HardLockInputPitchSensitivity")
				{
					value = this.HardLockInputPitchSensitivity;
					return true;
				}
				break;
			}
			case 30:
			{
				char c = key[28];
				if (c != 'a')
				{
					if (c == 'i')
					{
						if (key == "RelativeRotationLagYawSpeedMin")
						{
							value = this.RelativeRotationLagYawSpeedMin;
							return true;
						}
					}
				}
				else if (key == "RelativeRotationLagYawSpeedMax")
				{
					value = this.RelativeRotationLagYawSpeedMax;
					return true;
				}
				break;
			}
			case 31:
				if (key == "ChangeShowTargetDistCoefficient")
				{
					value = this.ChangeShowTargetDistCoefficient;
					return true;
				}
				break;
			case 32:
			{
				char c = key[30];
				if (c <= 'g')
				{
					if (c != 'a')
					{
						if (c == 'g')
						{
							if (key == "RelativeRotationLagYawAngleRange")
							{
								value = this.RelativeRotationLagYawAngleRange;
								return true;
							}
						}
					}
					else if (key == "RelativeRotationLagPitchSpeedMax")
					{
						value = this.RelativeRotationLagPitchSpeedMax;
						return true;
					}
				}
				else if (c != 'i')
				{
					if (c != 'l')
					{
						if (c == 'n')
						{
							if (key == "ChangeShowTargetAngleCoefficient")
							{
								value = this.ChangeShowTargetAngleCoefficient;
								return true;
							}
						}
					}
					else if (key == "YawSignAdaptionDistanceThreshold")
					{
						value = this.YawSignAdaptionDistanceThreshold;
						return true;
					}
				}
				else if (key == "RelativeRotationLagPitchSpeedMin")
				{
					value = this.RelativeRotationLagPitchSpeedMin;
					return true;
				}
				break;
			}
			case 34:
			{
				char c = key[0];
				if (c <= 'H')
				{
					if (c != 'C')
					{
						if (c == 'H')
						{
							if (key == "HardLockInputYawSensitivityGamepad")
							{
								value = this.HardLockInputYawSensitivityGamepad;
								return true;
							}
						}
					}
					else if (key == "ChangeShowTargetSensitivityGamepad")
					{
						value = this.ChangeShowTargetSensitivityGamepad;
						return true;
					}
				}
				else if (c != 'R')
				{
					if (c == 'S')
					{
						if (key == "SoftLockInputYawSensitivityGamepad")
						{
							value = this.SoftLockInputYawSensitivityGamepad;
							return true;
						}
					}
				}
				else if (key == "RelativeRotationLagPitchAngleRange")
				{
					value = this.RelativeRotationLagPitchAngleRange;
					return true;
				}
				break;
			}
			case 35:
			{
				char c = key[33];
				if (c != 'a')
				{
					if (c == 'i')
					{
						if (key == "RelativeRotationLagDistanceRangeMin")
						{
							value = this.RelativeRotationLagDistanceRangeMin;
							return true;
						}
					}
				}
				else if (key == "RelativeRotationLagDistanceRangeMax")
				{
					value = this.RelativeRotationLagDistanceRangeMax;
					return true;
				}
				break;
			}
			case 36:
			{
				char c = key[0];
				if (c != 'H')
				{
					if (c == 'S')
					{
						if (key == "SoftLockInputPitchSensitivityGamepad")
						{
							value = this.SoftLockInputPitchSensitivityGamepad;
							return true;
						}
					}
				}
				else if (key == "HardLockInputPitchSensitivityGamepad")
				{
					value = this.HardLockInputPitchSensitivityGamepad;
					return true;
				}
				break;
			}
			}
		}
		return base.TryGetMember(key, out value);
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x000AA178 File Offset: 0x000A8378
	[NullableContext(0)]
	public override void SetMember(string key, object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 10:
				if (key == "FirstInput")
				{
					this.FirstInput = (bool)value;
					return;
				}
				break;
			case 12:
				if (key == "CameraOffset")
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
					this.CameraOffset = num2;
					return;
				}
				break;
			case 15:
				if (key == "ExpectedYawSign")
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
					this.ExpectedYawSign = num2;
					return;
				}
				break;
			case 16:
			{
				char c = key[0];
				if (c != 'A')
				{
					if (c == 'C')
					{
						if (key == "CameraOffsetSoft")
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
							this.CameraOffsetSoft = num2;
							return;
						}
					}
				}
				else if (key == "AddCameraOffsetY")
				{
					this.AddCameraOffsetY = (float?)value;
					return;
				}
				break;
			}
			case 17:
				if (key == "YawSignAdaptionOn")
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
					this.YawSignAdaptionOn = num2;
					return;
				}
				break;
			case 18:
			{
				char c = key[11];
				if (c != 'H')
				{
					if (c != 'S')
					{
						if (c == 'a')
						{
							if (key == "SoftUnlockYawSpeed")
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
								this.SoftUnlockYawSpeed = num2;
								return;
							}
						}
					}
					else
					{
						if (key == "RelativeYawSoftMin")
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
							this.RelativeYawSoftMin = num2;
							return;
						}
						if (key == "RelativeYawSoftMax")
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
							this.RelativeYawSoftMax = num2;
							return;
						}
					}
				}
				else
				{
					if (key == "RelativeYawHardMax")
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
						this.RelativeYawHardMax = num2;
						return;
					}
					if (key == "RelativeYawHardMin")
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
						this.RelativeYawHardMin = num2;
						return;
					}
				}
				break;
			}
			case 19:
				if (key == "SoftUnlockInputTime")
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
					this.SoftUnlockInputTime = num2;
					return;
				}
				break;
			case 20:
			{
				char c = key[18];
				if (c != 'a')
				{
					if (c != 'e')
					{
						if (c == 'i')
						{
							if (key == "RelativePitchHardMin")
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
								this.RelativePitchHardMin = num2;
								return;
							}
						}
					}
					else if (key == "SoftUnlockPitchSpeed")
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
						this.SoftUnlockPitchSpeed = num2;
						return;
					}
				}
				else if (key == "RelativePitchHardMax")
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
					this.RelativePitchHardMax = num2;
					return;
				}
				break;
			}
			case 21:
				if (key == "PrevChangeYawSignTime")
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
					this.PrevChangeYawSignTime = num2;
					return;
				}
				break;
			case 23:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'Y')
					{
						if (key == "YawSignAdaptionCooldown")
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
							this.YawSignAdaptionCooldown = num2;
							return;
						}
					}
				}
				else if (key == "ChangeShowTargetDamping")
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
					this.ChangeShowTargetDamping = num2;
					return;
				}
				break;
			}
			case 24:
				if (key == "YawSignAdaptionThreshold")
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
					this.YawSignAdaptionThreshold = num2;
					return;
				}
				break;
			case 25:
				if (key == "SoftUnlockInputRemainTime")
				{
					double softUnlockInputRemainTime;
					if (value is double)
					{
						double num70 = (double)value;
						softUnlockInputRemainTime = num70;
					}
					else if (value is float)
					{
						float num71 = (float)value;
						softUnlockInputRemainTime = (double)num71;
					}
					else if (value is int)
					{
						int num72 = (int)value;
						softUnlockInputRemainTime = (double)num72;
					}
					else if (value is long)
					{
						long num73 = (long)value;
						softUnlockInputRemainTime = (double)num73;
					}
					else
					{
						softUnlockInputRemainTime = (double)value;
					}
					this.SoftUnlockInputRemainTime = softUnlockInputRemainTime;
					return;
				}
				break;
			case 26:
				if (key == "SoftUnlockInputYawMinSpeed")
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
					this.SoftUnlockInputYawMinSpeed = num2;
					return;
				}
				break;
			case 27:
			{
				char c = key[0];
				if (c <= 'H')
				{
					if (c != 'C')
					{
						if (c == 'H')
						{
							if (key == "HardLockInputYawSensitivity")
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
								this.HardLockInputYawSensitivity = num2;
								return;
							}
						}
					}
					else if (key == "ChangeShowTargetSensitivity")
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
						this.ChangeShowTargetSensitivity = num2;
						return;
					}
				}
				else if (c != 'R')
				{
					if (c == 'S')
					{
						if (key == "SoftLockInputYawSensitivity")
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
							this.SoftLockInputYawSensitivity = num2;
							return;
						}
					}
				}
				else
				{
					if (key == "RelativeRotationLagYawCurve")
					{
						this.RelativeRotationLagYawCurve = (CurveBase)value;
						return;
					}
					if (key == "RelativeRotationLagRatioMin")
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
						this.RelativeRotationLagRatioMin = num2;
						return;
					}
					if (key == "RelativeRotationLagRatioMax")
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
						this.RelativeRotationLagRatioMax = num2;
						return;
					}
				}
				break;
			}
			case 28:
			{
				char c = key[0];
				if (c != 'S')
				{
					if (c == 'Y')
					{
						if (key == "YawSignAdaptionLockDirection")
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
							this.YawSignAdaptionLockDirection = num2;
							return;
						}
					}
				}
				else if (key == "SoftUnlockInputPitchMinSpeed")
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
					this.SoftUnlockInputPitchMinSpeed = num2;
					return;
				}
				break;
			}
			case 29:
			{
				char c = key[0];
				if (c != 'H')
				{
					if (c != 'R')
					{
						if (c == 'S')
						{
							if (key == "SoftLockInputPitchSensitivity")
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
								this.SoftLockInputPitchSensitivity = num2;
								return;
							}
						}
					}
					else
					{
						if (key == "RelativeRotationLagPitchCurve")
						{
							this.RelativeRotationLagPitchCurve = (CurveBase)value;
							return;
						}
						if (key == "RelativeRotationLagRatioCurve")
						{
							this.RelativeRotationLagRatioCurve = (CurveBase)value;
							return;
						}
					}
				}
				else if (key == "HardLockInputPitchSensitivity")
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
					this.HardLockInputPitchSensitivity = num2;
					return;
				}
				break;
			}
			case 30:
			{
				char c = key[28];
				if (c != 'a')
				{
					if (c == 'i')
					{
						if (key == "RelativeRotationLagYawSpeedMin")
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
							this.RelativeRotationLagYawSpeedMin = num2;
							return;
						}
					}
				}
				else if (key == "RelativeRotationLagYawSpeedMax")
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
					this.RelativeRotationLagYawSpeedMax = num2;
					return;
				}
				break;
			}
			case 31:
				if (key == "ChangeShowTargetDistCoefficient")
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
					this.ChangeShowTargetDistCoefficient = num2;
					return;
				}
				break;
			case 32:
			{
				char c = key[30];
				if (c <= 'g')
				{
					if (c != 'a')
					{
						if (c == 'g')
						{
							if (key == "RelativeRotationLagYawAngleRange")
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
								this.RelativeRotationLagYawAngleRange = num2;
								return;
							}
						}
					}
					else if (key == "RelativeRotationLagPitchSpeedMax")
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
						this.RelativeRotationLagPitchSpeedMax = num2;
						return;
					}
				}
				else if (c != 'i')
				{
					if (c != 'l')
					{
						if (c == 'n')
						{
							if (key == "ChangeShowTargetAngleCoefficient")
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
								this.ChangeShowTargetAngleCoefficient = num2;
								return;
							}
						}
					}
					else if (key == "YawSignAdaptionDistanceThreshold")
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
						this.YawSignAdaptionDistanceThreshold = num2;
						return;
					}
				}
				else if (key == "RelativeRotationLagPitchSpeedMin")
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
					this.RelativeRotationLagPitchSpeedMin = num2;
					return;
				}
				break;
			}
			case 34:
			{
				char c = key[0];
				if (c <= 'H')
				{
					if (c != 'C')
					{
						if (c == 'H')
						{
							if (key == "HardLockInputYawSensitivityGamepad")
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
								this.HardLockInputYawSensitivityGamepad = num2;
								return;
							}
						}
					}
					else if (key == "ChangeShowTargetSensitivityGamepad")
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
						this.ChangeShowTargetSensitivityGamepad = num2;
						return;
					}
				}
				else if (c != 'R')
				{
					if (c == 'S')
					{
						if (key == "SoftLockInputYawSensitivityGamepad")
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
							this.SoftLockInputYawSensitivityGamepad = num2;
							return;
						}
					}
				}
				else if (key == "RelativeRotationLagPitchAngleRange")
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
					this.RelativeRotationLagPitchAngleRange = num2;
					return;
				}
				break;
			}
			case 35:
			{
				char c = key[33];
				if (c != 'a')
				{
					if (c == 'i')
					{
						if (key == "RelativeRotationLagDistanceRangeMin")
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
							this.RelativeRotationLagDistanceRangeMin = num2;
							return;
						}
					}
				}
				else if (key == "RelativeRotationLagDistanceRangeMax")
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
					this.RelativeRotationLagDistanceRangeMax = num2;
					return;
				}
				break;
			}
			case 36:
			{
				char c = key[0];
				if (c != 'H')
				{
					if (c == 'S')
					{
						if (key == "SoftLockInputPitchSensitivityGamepad")
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
							this.SoftLockInputPitchSensitivityGamepad = num2;
							return;
						}
					}
				}
				else if (key == "HardLockInputPitchSensitivityGamepad")
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
					this.HardLockInputPitchSensitivityGamepad = num2;
					return;
				}
				break;
			}
			}
		}
		base.SetMember(key, value);
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000ABC28 File Offset: 0x000A9E28
	[NullableContext(0)]
	public override IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraFocusController.<MemberIter>d__81 <MemberIter>d__ = new CameraFocusController.<MemberIter>d__81(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040013F4 RID: 5108
	internal const int ArmOffsetYSpeed = 100;

	// Token: 0x040013F5 RID: 5109
	internal const int DefaultFps = 60;

	// Token: 0x040013F6 RID: 5110
	internal const float FirstThreshold = 0.5f;

	// Token: 0x040013F7 RID: 5111
	internal const double FirstThresholdSquared = 0.25;

	// Token: 0x040013F8 RID: 5112
	internal const float LockDirectionLeft = -1f;

	// Token: 0x040013F9 RID: 5113
	internal const float LockDirectionRight = 1f;

	// Token: 0x040013FA RID: 5114
	public float RelativeRotationLagYawSpeedMin;

	// Token: 0x040013FB RID: 5115
	public float RelativeRotationLagYawSpeedMax;

	// Token: 0x040013FC RID: 5116
	public float RelativeRotationLagYawAngleRange;

	// Token: 0x040013FD RID: 5117
	[Nullable(2)]
	public CurveBase RelativeRotationLagYawCurve;

	// Token: 0x040013FE RID: 5118
	public float RelativeRotationLagPitchSpeedMin;

	// Token: 0x040013FF RID: 5119
	public float RelativeRotationLagPitchSpeedMax;

	// Token: 0x04001400 RID: 5120
	public float RelativeRotationLagPitchAngleRange;

	// Token: 0x04001401 RID: 5121
	[Nullable(2)]
	public CurveBase RelativeRotationLagPitchCurve;

	// Token: 0x04001402 RID: 5122
	public float RelativeRotationLagRatioMin;

	// Token: 0x04001403 RID: 5123
	public float RelativeRotationLagRatioMax;

	// Token: 0x04001404 RID: 5124
	public float RelativeRotationLagDistanceRangeMin;

	// Token: 0x04001405 RID: 5125
	public float RelativeRotationLagDistanceRangeMax;

	// Token: 0x04001406 RID: 5126
	[Nullable(2)]
	public CurveBase RelativeRotationLagRatioCurve;

	// Token: 0x04001407 RID: 5127
	public float YawSignAdaptionOn;

	// Token: 0x04001408 RID: 5128
	public float YawSignAdaptionThreshold;

	// Token: 0x04001409 RID: 5129
	public float YawSignAdaptionCooldown;

	// Token: 0x0400140A RID: 5130
	public float YawSignAdaptionDistanceThreshold;

	// Token: 0x0400140B RID: 5131
	public float YawSignAdaptionLockDirection;

	// Token: 0x0400140C RID: 5132
	public float RelativeYawSoftMin;

	// Token: 0x0400140D RID: 5133
	public float RelativeYawSoftMax;

	// Token: 0x0400140E RID: 5134
	public float CameraOffsetSoft;

	// Token: 0x0400140F RID: 5135
	public float CameraOffset;

	// Token: 0x04001410 RID: 5136
	public float HardLockInputYawSensitivity;

	// Token: 0x04001411 RID: 5137
	public float HardLockInputPitchSensitivity;

	// Token: 0x04001412 RID: 5138
	public float HardLockInputYawSensitivityGamepad;

	// Token: 0x04001413 RID: 5139
	public float HardLockInputPitchSensitivityGamepad;

	// Token: 0x04001414 RID: 5140
	public float SoftLockInputYawSensitivity;

	// Token: 0x04001415 RID: 5141
	public float SoftLockInputPitchSensitivity;

	// Token: 0x04001416 RID: 5142
	public float SoftLockInputYawSensitivityGamepad;

	// Token: 0x04001417 RID: 5143
	public float SoftLockInputPitchSensitivityGamepad;

	// Token: 0x04001418 RID: 5144
	public float ChangeShowTargetDamping;

	// Token: 0x04001419 RID: 5145
	public float ChangeShowTargetAngleCoefficient;

	// Token: 0x0400141A RID: 5146
	public float ChangeShowTargetDistCoefficient;

	// Token: 0x0400141B RID: 5147
	public float ChangeShowTargetSensitivity;

	// Token: 0x0400141C RID: 5148
	public float ChangeShowTargetSensitivityGamepad;

	// Token: 0x0400141D RID: 5149
	public float RelativeYawHardMax;

	// Token: 0x0400141E RID: 5150
	public float RelativeYawHardMin;

	// Token: 0x0400141F RID: 5151
	public float RelativePitchHardMax;

	// Token: 0x04001420 RID: 5152
	public float RelativePitchHardMin;

	// Token: 0x04001421 RID: 5153
	public float SoftUnlockYawSpeed;

	// Token: 0x04001422 RID: 5154
	public float SoftUnlockPitchSpeed;

	// Token: 0x04001423 RID: 5155
	public float SoftUnlockInputTime;

	// Token: 0x04001424 RID: 5156
	public float SoftUnlockInputYawMinSpeed;

	// Token: 0x04001425 RID: 5157
	public float SoftUnlockInputPitchMinSpeed;

	// Token: 0x04001426 RID: 5158
	private double SoftUnlockInputRemainTime;

	// Token: 0x04001427 RID: 5159
	private readonly Rotator TmpRotator = Rotator.Create();

	// Token: 0x04001428 RID: 5160
	private readonly Vector TargetOffset = Vector.Create();

	// Token: 0x04001429 RID: 5161
	private readonly Rotator TargetRotator = Rotator.Create();

	// Token: 0x0400142A RID: 5162
	private float ExpectedYawSign;

	// Token: 0x0400142B RID: 5163
	public float? AddCameraOffsetY;

	// Token: 0x0400142C RID: 5164
	private readonly Vector2D SumYawPitchInput = Vector2D.Create();

	// Token: 0x0400142D RID: 5165
	private bool FirstInput = true;

	// Token: 0x0400142E RID: 5166
	private float PrevChangeYawSignTime;
}
