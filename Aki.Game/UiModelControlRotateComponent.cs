using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiModel.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Core.Utils.StaticVariableReset;
using UnrealEngine;

// Token: 0x02002C85 RID: 11397
[NullableContext(2)]
[Nullable(0)]
[StaticVariablePriority(100)]
public class UiModelControlRotateComponent : UiModelComponentBase
{
	// Token: 0x06017CE2 RID: 97506 RVA: 0x0060E11C File Offset: 0x0060C31C
	protected override void OnInit()
	{
		this.ActorComponent = base.Owner.CheckGetComponent<UiModelActorComponent>();
		this.InputDataComponent = base.Owner.CheckGetComponent<UiModelInputDataComponent>();
		this.Rotator = Rotator.Create();
		this.BaseRotator = Rotator.Create();
		this.CaptureBaseRotator();
		if (this.BaseRotator != null)
		{
			Rotator rotator = this.Rotator;
			if (rotator == null)
			{
				return;
			}
			rotator.DeepCopy(this.BaseRotator);
		}
	}

	// Token: 0x06017CE3 RID: 97507 RVA: 0x0060E188 File Offset: 0x0060C388
	[NullableContext(1)]
	public void InitDataByConfig(SUiModelRotateSetting config)
	{
		this.InitData(config.旋转中轴, config.旋转偏移, config.倍化手柄输入倍率, config.移动端旋转输入倍率, config.模型Yaw灵敏度系数, config.模型Pitch灵敏度系数, config.Yaw限制Min, config.Yaw限制Max, config.Pitch限制Min, config.Pitch限制Max);
	}

	// Token: 0x06017CE4 RID: 97508 RVA: 0x0060E1D8 File Offset: 0x0060C3D8
	[NullableContext(1)]
	public void InitData(string originCase, float rotateOffset, float gamepadInputRate, float mobileRotateInputRate, float sensitivityYaw, float sensitivityPitch, float yawLimitMin, float yawLimitMax, float pitchLimitMin, float pitchLimitMax)
	{
		this.OriginCase = originCase;
		this.RotateOffset = rotateOffset;
		this.GamepadInputRate = gamepadInputRate;
		this.MobileRotateInputRate = mobileRotateInputRate;
		this.SensitivityYaw = sensitivityYaw;
		this.SensitivityPitch = sensitivityPitch;
		this.YawLimitMin = yawLimitMin;
		this.YawLimitMax = yawLimitMax;
		this.PitchLimitMin = pitchLimitMin;
		this.PitchLimitMax = pitchLimitMax;
	}

	// Token: 0x06017CE5 RID: 97509 RVA: 0x0060E232 File Offset: 0x0060C432
	public void Activate()
	{
		this.AutoSetOriginActorByCase();
		this.CaptureBaseRotator();
		if (this.BaseRotator != null)
		{
			Rotator rotator = this.Rotator;
			if (rotator != null)
			{
				rotator.DeepCopy(this.BaseRotator);
			}
		}
		this.NeedTick = true;
		this.ApplyRotation();
	}

	// Token: 0x06017CE6 RID: 97510 RVA: 0x0060E26C File Offset: 0x0060C46C
	public void Deactivate()
	{
		this.NeedTick = false;
	}

	// Token: 0x06017CE7 RID: 97511 RVA: 0x0060E275 File Offset: 0x0060C475
	protected override void OnTick(float deltaTime)
	{
		this.HandleAxisInput(deltaTime);
		this.UpdateYaw();
		this.UpdatePitch();
		this.ApplyRotation();
	}

	// Token: 0x06017CE8 RID: 97512 RVA: 0x0060E290 File Offset: 0x0060C490
	public void SetIsRotatePlus(bool isRotatePlus)
	{
		this.IsRotatePlus = isRotatePlus;
	}

	// Token: 0x06017CE9 RID: 97513 RVA: 0x0060E299 File Offset: 0x0060C499
	private AActor GetOriginActor()
	{
		if (!string.IsNullOrEmpty(this.OriginCase))
		{
			AActor result;
			if ((result = this.OriginActor) == null)
			{
				UiModelActorComponent actorComponent = this.ActorComponent;
				if (actorComponent == null)
				{
					return null;
				}
				result = actorComponent.Actor;
			}
			return result;
		}
		UiModelActorComponent actorComponent2 = this.ActorComponent;
		if (actorComponent2 == null)
		{
			return null;
		}
		return actorComponent2.Actor;
	}

	// Token: 0x06017CEA RID: 97514 RVA: 0x0060E2D8 File Offset: 0x0060C4D8
	private void AutoSetOriginActorByCase()
	{
		if (string.IsNullOrEmpty(this.OriginCase))
		{
			this.OriginActor = null;
			return;
		}
		FName? dynamicFName = FNameUtil.GetDynamicFName(this.OriginCase);
		this.OriginActor = ((dynamicFName == null) ? null : UKuroCollectActorComponent.GetActorWithTag(dynamicFName.Value, ECollectActorType.UI));
	}

	// Token: 0x06017CEB RID: 97515 RVA: 0x0060E328 File Offset: 0x0060C528
	private void CaptureBaseRotator()
	{
		AActor originActor = this.GetOriginActor();
		if (originActor == null || this.BaseRotator == null)
		{
			return;
		}
		Rotator baseRotator = this.BaseRotator;
		FRotator frotator = originActor.K2_GetActorRotation();
		baseRotator.FromUeRotator(frotator);
		this.BaseRotator.Yaw += this.RotateOffset;
	}

	// Token: 0x06017CEC RID: 97516 RVA: 0x0060E374 File Offset: 0x0060C574
	public void SyncRotatorFromActor()
	{
		UiModelActorComponent actorComponent = this.ActorComponent;
		AActor aactor = (actorComponent != null) ? actorComponent.Actor : null;
		if (aactor != null && this.Rotator != null)
		{
			Rotator rotator = this.Rotator;
			FRotator frotator = aactor.K2_GetActorRotation();
			rotator.FromUeRotator(frotator);
		}
	}

	// Token: 0x06017CED RID: 97517 RVA: 0x0060E3B3 File Offset: 0x0060C5B3
	public void ResumeFromCurrentActorRotation()
	{
		this.SyncRotatorFromActor();
		this.NeedTick = true;
	}

	// Token: 0x06017CEE RID: 97518 RVA: 0x0060E3C4 File Offset: 0x0060C5C4
	public void HandleAxisInput(float deltaTime)
	{
		UiModelInputDataComponent inputDataComponent = this.InputDataComponent;
		float num = (inputDataComponent != null) ? inputDataComponent.GetAxisInput(ERotateAxis.Yaw) : 0f;
		UiModelInputDataComponent inputDataComponent2 = this.InputDataComponent;
		float num2 = (inputDataComponent2 != null) ? inputDataComponent2.GetAxisInput(ERotateAxis.Pitch) : 0f;
		if (MathUtils.Instance.IsNearlyZero((double)num, null) && MathUtils.Instance.IsNearlyZero((double)num2, null))
		{
			return;
		}
		int num3 = this.IsRotatePlus ? 1 : -1;
		num *= (float)num3;
		num2 *= (float)num3;
		if (Info.Instance.IsInGamepad())
		{
			num *= this.GamepadInputRate;
			num2 *= this.GamepadInputRate;
		}
		else if (Info.Instance.IsInTouch())
		{
			num *= this.MobileRotateInputRate;
			num2 *= this.MobileRotateInputRate;
		}
		num = num * this.SensitivityYaw * deltaTime;
		num2 = num2 * this.SensitivityPitch * deltaTime;
		if (!MathUtils.Instance.IsNearlyZero((double)num, null) && this.Rotator != null)
		{
			this.Rotator.Yaw += num;
		}
		if (!MathUtils.Instance.IsNearlyZero((double)num2, null) && this.Rotator != null)
		{
			this.Rotator.Pitch += num2;
		}
	}

	// Token: 0x06017CEF RID: 97519 RVA: 0x0060E500 File Offset: 0x0060C700
	private void UpdateYaw()
	{
		if (this.Rotator == null || this.BaseRotator == null)
		{
			return;
		}
		float num = Rotator.NormalizeAxis(this.Rotator.Yaw - this.BaseRotator.Yaw);
		if (Math.Abs(this.YawLimitMin) + Math.Abs(this.YawLimitMax) < 360f)
		{
			num = MathUtils.Instance.Clamp(num, this.YawLimitMin, this.YawLimitMax);
		}
		this.Rotator.Yaw = this.BaseRotator.Yaw + num;
	}

	// Token: 0x06017CF0 RID: 97520 RVA: 0x0060E58C File Offset: 0x0060C78C
	private void UpdatePitch()
	{
		if (this.Rotator == null || this.BaseRotator == null)
		{
			return;
		}
		float num = Rotator.NormalizeAxis(this.Rotator.Pitch - this.BaseRotator.Pitch);
		num = MathUtils.Instance.Clamp(num, this.PitchLimitMin, this.PitchLimitMax);
		this.Rotator.Pitch = this.BaseRotator.Pitch + num;
	}

	// Token: 0x06017CF1 RID: 97521 RVA: 0x0060E5F8 File Offset: 0x0060C7F8
	private void ApplyRotation()
	{
		UiModelActorComponent actorComponent = this.ActorComponent;
		AActor aactor = (actorComponent != null) ? actorComponent.Actor : null;
		if (aactor == null || this.Rotator == null)
		{
			return;
		}
		aactor.K2_SetActorRotation(this.Rotator.ToUeRotator(), false);
	}

	// Token: 0x0400B16D RID: 45421
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B16E RID: 45422
	private UiModelInputDataComponent InputDataComponent;

	// Token: 0x0400B16F RID: 45423
	private AActor OriginActor;

	// Token: 0x0400B170 RID: 45424
	private Rotator Rotator;

	// Token: 0x0400B171 RID: 45425
	private Rotator BaseRotator;

	// Token: 0x0400B172 RID: 45426
	private float GamepadInputRate;

	// Token: 0x0400B173 RID: 45427
	private float MobileRotateInputRate;

	// Token: 0x0400B174 RID: 45428
	private float SensitivityYaw;

	// Token: 0x0400B175 RID: 45429
	private float SensitivityPitch;

	// Token: 0x0400B176 RID: 45430
	private float YawLimitMin;

	// Token: 0x0400B177 RID: 45431
	private float YawLimitMax;

	// Token: 0x0400B178 RID: 45432
	private float PitchLimitMin;

	// Token: 0x0400B179 RID: 45433
	private float PitchLimitMax;

	// Token: 0x0400B17A RID: 45434
	[Nullable(1)]
	private string OriginCase = string.Empty;

	// Token: 0x0400B17B RID: 45435
	private float RotateOffset;

	// Token: 0x0400B17C RID: 45436
	private bool IsRotatePlus;
}
