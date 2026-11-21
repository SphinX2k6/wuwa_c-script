using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.UiModel.Struct;
using CSharpScript.Core.Common;
using CSharpScript.Core.Utils.StaticVariableReset;
using UnrealEngine;

// Token: 0x020021DE RID: 8670
[NullableContext(2)]
[Nullable(0)]
[StaticVariablePriority(100)]
public class UiModelControlRotateComponent : UiModelComponentBase
{
	// Token: 0x06015555 RID: 87381 RVA: 0x00633BE4 File Offset: 0x00631DE4
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

	// Token: 0x06015556 RID: 87382 RVA: 0x00633C50 File Offset: 0x00631E50
	[NullableContext(1)]
	public void InitDataByConfig(SUiModelRotateSetting config)
	{
		this.InitData(config.旋转中轴, config.旋转偏移, config.倍化手柄输入倍率, config.移动端旋转输入倍率, config.模型Yaw灵敏度系数, config.模型Pitch灵敏度系数, config.Yaw限制Min, config.Yaw限制Max, config.Pitch限制Min, config.Pitch限制Max);
	}

	// Token: 0x06015557 RID: 87383 RVA: 0x00633CA0 File Offset: 0x00631EA0
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

	// Token: 0x06015558 RID: 87384 RVA: 0x00633CFA File Offset: 0x00631EFA
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

	// Token: 0x06015559 RID: 87385 RVA: 0x00633D34 File Offset: 0x00631F34
	public void Deactivate()
	{
		this.NeedTick = false;
	}

	// Token: 0x0601555A RID: 87386 RVA: 0x00633D3D File Offset: 0x00631F3D
	protected override void OnTick(float deltaTime)
	{
		this.HandleAxisInput(deltaTime);
		this.UpdateYaw();
		this.UpdatePitch();
		this.ApplyRotation();
	}

	// Token: 0x0601555B RID: 87387 RVA: 0x00633D58 File Offset: 0x00631F58
	public void SetIsRotatePlus(bool isRotatePlus)
	{
		this.IsRotatePlus = isRotatePlus;
	}

	// Token: 0x0601555C RID: 87388 RVA: 0x00633D61 File Offset: 0x00631F61
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

	// Token: 0x0601555D RID: 87389 RVA: 0x00633DA0 File Offset: 0x00631FA0
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

	// Token: 0x0601555E RID: 87390 RVA: 0x00633DF0 File Offset: 0x00631FF0
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

	// Token: 0x0601555F RID: 87391 RVA: 0x00633E3C File Offset: 0x0063203C
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

	// Token: 0x06015560 RID: 87392 RVA: 0x00633E7B File Offset: 0x0063207B
	public void ResumeFromCurrentActorRotation()
	{
		this.SyncRotatorFromActor();
		this.NeedTick = true;
	}

	// Token: 0x06015561 RID: 87393 RVA: 0x00633E8C File Offset: 0x0063208C
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

	// Token: 0x06015562 RID: 87394 RVA: 0x00633FC8 File Offset: 0x006321C8
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

	// Token: 0x06015563 RID: 87395 RVA: 0x00634054 File Offset: 0x00632254
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

	// Token: 0x06015564 RID: 87396 RVA: 0x006340C0 File Offset: 0x006322C0
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

	// Token: 0x0400B4D8 RID: 46296
	private UiModelActorComponent ActorComponent;

	// Token: 0x0400B4D9 RID: 46297
	private UiModelInputDataComponent InputDataComponent;

	// Token: 0x0400B4DA RID: 46298
	private AActor OriginActor;

	// Token: 0x0400B4DB RID: 46299
	private Rotator Rotator;

	// Token: 0x0400B4DC RID: 46300
	private Rotator BaseRotator;

	// Token: 0x0400B4DD RID: 46301
	private float GamepadInputRate;

	// Token: 0x0400B4DE RID: 46302
	private float MobileRotateInputRate;

	// Token: 0x0400B4DF RID: 46303
	private float SensitivityYaw;

	// Token: 0x0400B4E0 RID: 46304
	private float SensitivityPitch;

	// Token: 0x0400B4E1 RID: 46305
	private float YawLimitMin;

	// Token: 0x0400B4E2 RID: 46306
	private float YawLimitMax;

	// Token: 0x0400B4E3 RID: 46307
	private float PitchLimitMin;

	// Token: 0x0400B4E4 RID: 46308
	private float PitchLimitMax;

	// Token: 0x0400B4E5 RID: 46309
	[Nullable(1)]
	private string OriginCase = string.Empty;

	// Token: 0x0400B4E6 RID: 46310
	private float RotateOffset;

	// Token: 0x0400B4E7 RID: 46311
	private bool IsRotatePlus;
}
