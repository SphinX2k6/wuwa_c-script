using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Weather;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D1E RID: 11550
[NullableContext(1)]
[Nullable(0)]
public class WeatherCentralBottomItem : UiPanelBase
{
	// Token: 0x06018496 RID: 99478 RVA: 0x0062E354 File Offset: 0x0062C554
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirm));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickSkip));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06018497 RID: 99479 RVA: 0x0062E505 File Offset: 0x0062C705
	private void OnCooldownTimer(int remainTime)
	{
		if (remainTime <= 0)
		{
			this.RefreshButtonState();
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "WeatherControl_Cooldown", new <>z__ReadOnlySingleElementList<object>(remainTime));
	}

	// Token: 0x06018498 RID: 99480 RVA: 0x0062E533 File Offset: 0x0062C733
	private void OnClickConfirm()
	{
		Action clickConfirmCallback = this.ClickConfirmCallback;
		if (clickConfirmCallback == null)
		{
			return;
		}
		clickConfirmCallback();
	}

	// Token: 0x06018499 RID: 99481 RVA: 0x0062E548 File Offset: 0x0062C748
	private void OnClickSkip()
	{
		SkipTaskManager.Run(ESkipName.SkipToQuest, new object[]
		{
			WeatherModuleConfig.Instance.GetWeatherSwitchConfig(this.SelectedConfigId).Value.QuestId
		});
	}

	// Token: 0x0601849A RID: 99482 RVA: 0x0062E589 File Offset: 0x0062C789
	public void SetClickConfirmCallback(Action callback)
	{
		this.ClickConfirmCallback = callback;
	}

	// Token: 0x0601849B RID: 99483 RVA: 0x0062E592 File Offset: 0x0062C792
	public void RefreshByConfigId(int configId)
	{
		this.SelectedConfigId = configId;
		this.RefreshTime();
		this.RefreshButtonState();
		this.RefreshLockText();
	}

	// Token: 0x0601849C RID: 99484 RVA: 0x0062E5B0 File Offset: 0x0062C7B0
	private void RefreshLockText()
	{
		WeatherSwitch? weatherSwitchConfig = WeatherModuleConfig.Instance.GetWeatherSwitchConfig(this.SelectedConfigId);
		if (weatherSwitchConfig == null || weatherSwitchConfig.Value.UnlockCondition == 0)
		{
			return;
		}
		ConditionGroup? conditionGroup;
		string key = ((ConditionConfig.Instance.GetConditionGroupConfig(weatherSwitchConfig.Value.UnlockCondition) != null) ? conditionGroup.GetValueOrDefault().HintText : null) ?? "";
		UUIText text = base.GetText(5);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(key);
	}

	// Token: 0x0601849D RID: 99485 RVA: 0x0062E63C File Offset: 0x0062C83C
	private void RefreshButtonState()
	{
		bool flag = WeatherModel.Instance.IsWeatherSwitchConfigUnlocked(this.SelectedConfigId);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(!flag);
		}
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(flag);
		}
		if (flag)
		{
			bool flag2 = WeatherModel.Instance.GetCurrentWeatherSwitchConfigId() == this.SelectedConfigId;
			int remainCoolDownTime = WeatherModel.Instance.GetRemainCoolDownTime();
			if (button != null)
			{
				button.SetSelfInteractive(!flag2 && remainCoolDownTime <= 0);
			}
			if (remainCoolDownTime > 0)
			{
				this.OnCooldownTimer(remainCoolDownTime);
				return;
			}
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew("WeatherControl_Confirm");
		}
	}

	// Token: 0x0601849E RID: 99486 RVA: 0x0062E6EC File Offset: 0x0062C8EC
	private void RefreshTime()
	{
		bool flag = WeatherModel.Instance.IsCurrentTimeInValidTime(this.SelectedConfigId);
		UUIArtText artText = base.GetArtText(1);
		UUIArtText artText2 = base.GetArtText(2);
		if (!flag)
		{
			if (artText != null)
			{
				artText.SetText(this.GetCurrentTimeText());
			}
			if (artText2 != null)
			{
				artText2.SetText(this.GetTargetTimeText());
			}
		}
		else if (artText2 != null)
		{
			artText2.SetText(this.GetCurrentTimeText());
		}
		if (artText != null)
		{
			artText.SetUIActive(!flag);
		}
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!flag);
	}

	// Token: 0x0601849F RID: 99487 RVA: 0x0062E76E File Offset: 0x0062C96E
	private string GetCurrentTimeText()
	{
		return TimeOfDayModel.Instance.GameTime.HourMinuteString;
	}

	// Token: 0x060184A0 RID: 99488 RVA: 0x0062E780 File Offset: 0x0062C980
	private string GetTargetTimeText()
	{
		string text = "0" + this.GetTargetTimeByConfigId(this.SelectedConfigId).ToString();
		int startIndex = Math.Max(0, text.Length - 2);
		return text.Substring(startIndex) + ":00";
	}

	// Token: 0x060184A1 RID: 99489 RVA: 0x0062E7CC File Offset: 0x0062C9CC
	private int GetTargetTimeByConfigId(int configId)
	{
		return WeatherModuleConfig.Instance.GetWeatherSwitchConfig(configId).Value.ValidTime()[0];
	}

	// Token: 0x0400B455 RID: 46165
	private int SelectedConfigId;

	// Token: 0x0400B456 RID: 46166
	[Nullable(2)]
	private Action ClickConfirmCallback;
}
