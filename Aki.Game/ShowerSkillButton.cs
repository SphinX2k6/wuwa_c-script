using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002A05 RID: 10757
[NullableContext(2)]
[Nullable(0)]
public class ShowerSkillButton : UiPanelBase
{
	// Token: 0x0601651E RID: 91422 RVA: 0x005A60A4 File Offset: 0x005A42A4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClick))
		};
	}

	// Token: 0x0601651F RID: 91423 RVA: 0x005A614D File Offset: 0x005A434D
	protected override void OnStart()
	{
		this.CoolDownUiItem = base.GetItem(1);
		this.CoolDownBarUiSprite = base.GetSprite(2);
		this.CoolDownUiText = base.GetText(3);
		this.SetSkillButtonEnable(true);
	}

	// Token: 0x06016520 RID: 91424 RVA: 0x005A617D File Offset: 0x005A437D
	private void SetSkillButtonEnable(bool bEnable)
	{
		this.Enable = bEnable;
		UUIButtonComponent button = base.GetButton(0);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(bEnable);
	}

	// Token: 0x06016521 RID: 91425 RVA: 0x005A6198 File Offset: 0x005A4398
	public void TickSkillCoolDown(float delta)
	{
		if (this.CurrentCoolDownTime <= 0f || this.TotalCoolDownTime <= 0f || this.CoolDownBarUiSprite == null)
		{
			return;
		}
		double num = (Time.Instance.WorldTimeSeconds - this.CoolDownStartTime) / (double)this.TotalCoolDownTime;
		this.CoolDownBarUiSprite.SetFillAmount((float)num);
		UUIText coolDownUiText = this.CoolDownUiText;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("F");
		defaultInterpolatedStringHandler.AppendFormatted<int>(this.CdFixedPoint);
		coolDownUiText.SetText(this.CurrentCoolDownTime.ToString(defaultInterpolatedStringHandler.ToStringAndClear()), true);
	}

	// Token: 0x06016522 RID: 91426 RVA: 0x005A622F File Offset: 0x005A442F
	public void ResetSkillCoolDown()
	{
		this.SetSkillButtonEnable(true);
		UUIItem coolDownUiItem = this.CoolDownUiItem;
		if (coolDownUiItem != null)
		{
			coolDownUiItem.SetUIActive(false);
		}
		this.ResetCoolDownTimer();
		this.CurrentCoolDownTime = 0f;
	}

	// Token: 0x06016523 RID: 91427 RVA: 0x005A625C File Offset: 0x005A445C
	private void ResetCoolDownTimer()
	{
		if (this.ChangeCoolDownRefreshTimerId != null && TimerSystem.Instance.Has(this.ChangeCoolDownRefreshTimerId))
		{
			TimerSystem.Instance.Remove(this.ChangeCoolDownRefreshTimerId);
		}
		if (this.HideCdTimerId != null && TimerSystem.Instance.Has(this.HideCdTimerId))
		{
			TimerSystem.Instance.Remove(this.HideCdTimerId);
		}
	}

	// Token: 0x06016524 RID: 91428 RVA: 0x005A62C0 File Offset: 0x005A44C0
	public void PlaySwitchCd()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("ShowerVisionChangeCoolDown");
		if (intConfig != null && intConfig.GetValueOrDefault() != 0)
		{
			float num = (float)TimeUtil.Instance.SetTimeSecond((double)intConfig.Value);
			this.PlaySkillTimeDown(num, num);
		}
	}

	// Token: 0x06016525 RID: 91429 RVA: 0x005A6308 File Offset: 0x005A4508
	private void PlaySkillTimeDown(float coolDownTime, float totalCoolDown)
	{
		this.ResetCoolDownTimer();
		this.CurrentCoolDownTime = 0f;
		if (coolDownTime <= 0f)
		{
			this.CoolDownUiItem.SetUIActive(false);
			this.SetSkillButtonEnable(true);
			return;
		}
		this.CurrentCoolDownTime = coolDownTime;
		this.TotalCoolDownTime = totalCoolDown;
		this.CoolDownStartTime = Time.Instance.WorldTimeSeconds - (double)(totalCoolDown - coolDownTime);
		UUIText coolDownUiText = this.CoolDownUiText;
		if (coolDownUiText != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("F");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CdFixedPoint);
			coolDownUiText.SetText(this.CurrentCoolDownTime.ToString(defaultInterpolatedStringHandler.ToStringAndClear()), true);
		}
		this.ChangeCoolDownRefreshTimerId = TimerSystem.Instance.Forever(new TTimerAction(this.OnSkillCoolDownRefresh), 100f, 1f, null, null, true);
		this.RefreshTimeDilationAtTimerCreate(this.ChangeCoolDownRefreshTimerId);
		this.CoolDownUiItem.SetUIActive(true);
		this.SetSkillButtonEnable(false);
	}

	// Token: 0x06016526 RID: 91430 RVA: 0x005A63F4 File Offset: 0x005A45F4
	private void OnSkillCoolDownRefresh(float delta)
	{
		this.CurrentCoolDownTime -= 0.1f;
		this.CurrentCoolDownTime = (float)(Math.Round((double)(this.CurrentCoolDownTime * 10f)) / 10.0);
		if (this.CurrentCoolDownTime > 0f)
		{
			UUIText coolDownUiText = this.CoolDownUiText;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("F");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CdFixedPoint);
			coolDownUiText.SetText(this.CurrentCoolDownTime.ToString(defaultInterpolatedStringHandler.ToStringAndClear()), true);
			return;
		}
		this.FinishSkillCoolDown();
	}

	// Token: 0x06016527 RID: 91431 RVA: 0x005A648A File Offset: 0x005A468A
	protected void FinishSkillCoolDown()
	{
		this.ResetSkillCoolDown();
	}

	// Token: 0x06016528 RID: 91432 RVA: 0x005A6494 File Offset: 0x005A4694
	[NullableContext(1)]
	private void RefreshTimeDilationAtTimerCreate(TimerHandle timerId)
	{
		float timeDilation = this.GetTimeDilation();
		if (timeDilation != 1f)
		{
			if (timeDilation > 0f)
			{
				TimerSystem.Instance.ChangeDilation(timerId, timeDilation, null);
				return;
			}
			TimerSystem.Instance.Pause(timerId, null);
		}
	}

	// Token: 0x06016529 RID: 91433 RVA: 0x005A64D4 File Offset: 0x005A46D4
	private float GetTimeDilation()
	{
		return Time.Instance.TimeDilation;
	}

	// Token: 0x0601652A RID: 91434 RVA: 0x005A64E0 File Offset: 0x005A46E0
	[NullableContext(1)]
	public void SetPressCallback(Action onPressCallback)
	{
		this.OnPressCallback = onPressCallback;
	}

	// Token: 0x0601652B RID: 91435 RVA: 0x005A64E9 File Offset: 0x005A46E9
	private void OnButtonClick()
	{
		if (!this.Enable)
		{
			return;
		}
		if (this.DisabledHintCallback != null)
		{
			this.DisabledHintCallback();
			return;
		}
		Action onPressCallback = this.OnPressCallback;
		if (onPressCallback == null)
		{
			return;
		}
		onPressCallback();
	}

	// Token: 0x0601652C RID: 91436 RVA: 0x005A6518 File Offset: 0x005A4718
	[NullableContext(1)]
	public void SetSkillIconSprite(string path)
	{
		UUISprite sprite = base.GetSprite(4);
		this.SetSpriteByPath(path, sprite, true, null, null);
		UUISpriteTransition uiSpriteTransition = sprite.GetOwner().GetComponentByClass(UUISpriteTransition.StaticClass()) as UUISpriteTransition;
		base.SetSpriteTransitionByPath(path, uiSpriteTransition, EUISelectableSelectionState.EUISelectableSelectionState_MAX).Forget();
	}

	// Token: 0x0601652D RID: 91437 RVA: 0x005A6569 File Offset: 0x005A4769
	public void SetButtonInteractive(bool value)
	{
		base.GetButton(0).SetSelfInteractive(value);
	}

	// Token: 0x0601652E RID: 91438 RVA: 0x005A6578 File Offset: 0x005A4778
	public void SetDisabledHint(Action callback)
	{
		this.DisabledHintCallback = callback;
	}

	// Token: 0x0400A5FF RID: 42495
	private const int SKILL_COOLDOWN_INTERVAL = 100;

	// Token: 0x0400A600 RID: 42496
	private const float SKILL_COOLDOWN_LOOP_INTERVAL = 0.1f;

	// Token: 0x0400A601 RID: 42497
	private Action OnPressCallback;

	// Token: 0x0400A602 RID: 42498
	private bool Enable;

	// Token: 0x0400A603 RID: 42499
	private Action DisabledHintCallback;

	// Token: 0x0400A604 RID: 42500
	private UUIItem CoolDownUiItem;

	// Token: 0x0400A605 RID: 42501
	private UUIText CoolDownUiText;

	// Token: 0x0400A606 RID: 42502
	private UUISprite CoolDownBarUiSprite;

	// Token: 0x0400A607 RID: 42503
	private float CurrentCoolDownTime;

	// Token: 0x0400A608 RID: 42504
	private float TotalCoolDownTime;

	// Token: 0x0400A609 RID: 42505
	private double CoolDownStartTime;

	// Token: 0x0400A60A RID: 42506
	private TimerHandle ChangeCoolDownRefreshTimerId;

	// Token: 0x0400A60B RID: 42507
	private readonly TimerHandle HideCdTimerId;

	// Token: 0x0400A60C RID: 42508
	private readonly int CdFixedPoint = 1;

	// Token: 0x02009040 RID: 36928
	[NullableContext(0)]
	private class EShowerSkillButtonDefine
	{
		// Token: 0x0402EB52 RID: 191314
		public const int Button = 0;

		// Token: 0x0402EB53 RID: 191315
		public const int CoolDownItem = 1;

		// Token: 0x0402EB54 RID: 191316
		public const int CoolDownBarSprite = 2;

		// Token: 0x0402EB55 RID: 191317
		public const int CoolDownText = 3;

		// Token: 0x0402EB56 RID: 191318
		public const int SkillIconSprite = 4;
	}
}
