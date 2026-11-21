using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001F80 RID: 8064
[NullableContext(2)]
[Nullable(0)]
public class ShowerSkillButton : UiPanelBase
{
	// Token: 0x06013F25 RID: 81701 RVA: 0x005D107C File Offset: 0x005CF27C
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

	// Token: 0x06013F26 RID: 81702 RVA: 0x005D1125 File Offset: 0x005CF325
	protected override void OnStart()
	{
		this.CoolDownUiItem = base.GetItem(1);
		this.CoolDownBarUiSprite = base.GetSprite(2);
		this.CoolDownUiText = base.GetText(3);
		this.SetSkillButtonEnable(true);
	}

	// Token: 0x06013F27 RID: 81703 RVA: 0x005D1155 File Offset: 0x005CF355
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

	// Token: 0x06013F28 RID: 81704 RVA: 0x005D1170 File Offset: 0x005CF370
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

	// Token: 0x06013F29 RID: 81705 RVA: 0x005D1207 File Offset: 0x005CF407
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

	// Token: 0x06013F2A RID: 81706 RVA: 0x005D1234 File Offset: 0x005CF434
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

	// Token: 0x06013F2B RID: 81707 RVA: 0x005D1298 File Offset: 0x005CF498
	public void PlaySwitchCd()
	{
		int? intConfig = ConfigCommonParamById.GetIntConfig("ShowerVisionChangeCoolDown");
		if (intConfig != null && intConfig.GetValueOrDefault() != 0)
		{
			float num = (float)TimeUtil.Instance.SetTimeSecond((double)intConfig.Value);
			this.PlaySkillTimeDown(num, num);
		}
	}

	// Token: 0x06013F2C RID: 81708 RVA: 0x005D12E0 File Offset: 0x005CF4E0
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

	// Token: 0x06013F2D RID: 81709 RVA: 0x005D13CC File Offset: 0x005CF5CC
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

	// Token: 0x06013F2E RID: 81710 RVA: 0x005D1462 File Offset: 0x005CF662
	protected void FinishSkillCoolDown()
	{
		this.ResetSkillCoolDown();
	}

	// Token: 0x06013F2F RID: 81711 RVA: 0x005D146C File Offset: 0x005CF66C
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

	// Token: 0x06013F30 RID: 81712 RVA: 0x005D14AC File Offset: 0x005CF6AC
	private float GetTimeDilation()
	{
		return Time.Instance.TimeDilation;
	}

	// Token: 0x06013F31 RID: 81713 RVA: 0x005D14B8 File Offset: 0x005CF6B8
	[NullableContext(1)]
	public void SetPressCallback(Action onPressCallback)
	{
		this.OnPressCallback = onPressCallback;
	}

	// Token: 0x06013F32 RID: 81714 RVA: 0x005D14C1 File Offset: 0x005CF6C1
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

	// Token: 0x06013F33 RID: 81715 RVA: 0x005D14F0 File Offset: 0x005CF6F0
	[NullableContext(1)]
	public void SetSkillIconSprite(string path)
	{
		UUISprite sprite = base.GetSprite(4);
		this.SetSpriteByPath(path, sprite, true, null, null);
		UUISpriteTransition uiSpriteTransition = sprite.GetOwner().GetComponentByClass(UUISpriteTransition.StaticClass()) as UUISpriteTransition;
		base.SetSpriteTransitionByPath(path, uiSpriteTransition, EUISelectableSelectionState.EUISelectableSelectionState_MAX).Forget();
	}

	// Token: 0x06013F34 RID: 81716 RVA: 0x005D1541 File Offset: 0x005CF741
	public void SetButtonInteractive(bool value)
	{
		base.GetButton(0).SetSelfInteractive(value);
	}

	// Token: 0x06013F35 RID: 81717 RVA: 0x005D1550 File Offset: 0x005CF750
	public void SetDisabledHint(Action callback)
	{
		this.DisabledHintCallback = callback;
	}

	// Token: 0x0400A9E9 RID: 43497
	private const int SKILL_COOLDOWN_INTERVAL = 100;

	// Token: 0x0400A9EA RID: 43498
	private const float SKILL_COOLDOWN_LOOP_INTERVAL = 0.1f;

	// Token: 0x0400A9EB RID: 43499
	private Action OnPressCallback;

	// Token: 0x0400A9EC RID: 43500
	private bool Enable;

	// Token: 0x0400A9ED RID: 43501
	private Action DisabledHintCallback;

	// Token: 0x0400A9EE RID: 43502
	private UUIItem CoolDownUiItem;

	// Token: 0x0400A9EF RID: 43503
	private UUIText CoolDownUiText;

	// Token: 0x0400A9F0 RID: 43504
	private UUISprite CoolDownBarUiSprite;

	// Token: 0x0400A9F1 RID: 43505
	private float CurrentCoolDownTime;

	// Token: 0x0400A9F2 RID: 43506
	private float TotalCoolDownTime;

	// Token: 0x0400A9F3 RID: 43507
	private double CoolDownStartTime;

	// Token: 0x0400A9F4 RID: 43508
	private TimerHandle ChangeCoolDownRefreshTimerId;

	// Token: 0x0400A9F5 RID: 43509
	private readonly TimerHandle HideCdTimerId;

	// Token: 0x0400A9F6 RID: 43510
	private readonly int CdFixedPoint = 1;

	// Token: 0x02008287 RID: 33415
	[NullableContext(0)]
	private class EShowerSkillButtonDefine
	{
		// Token: 0x0402A24A RID: 172618
		public const int Button = 0;

		// Token: 0x0402A24B RID: 172619
		public const int CoolDownItem = 1;

		// Token: 0x0402A24C RID: 172620
		public const int CoolDownBarSprite = 2;

		// Token: 0x0402A24D RID: 172621
		public const int CoolDownText = 3;

		// Token: 0x0402A24E RID: 172622
		public const int SkillIconSprite = 4;
	}
}
