using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Weather;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002D25 RID: 11557
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeatherToggleItem : GridProxyAbstract<IWeatherToggleData>
{
	// Token: 0x060184BC RID: 99516 RVA: 0x0062F374 File Offset: 0x0062D574
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggleSpriteTransition));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060184BD RID: 99517 RVA: 0x0062F524 File Offset: 0x0062D724
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(() => !this.IsEmptySlot && (this.CanExecuteChange == null || this.CanExecuteChange(base.GridIndex)));
	}

	// Token: 0x060184BE RID: 99518 RVA: 0x0062F548 File Offset: 0x0062D748
	private void OnClickToggle(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback();
		}
	}

	// Token: 0x060184BF RID: 99519 RVA: 0x0062F55E File Offset: 0x0062D75E
	public void SetToggleClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x060184C0 RID: 99520 RVA: 0x0062F567 File Offset: 0x0062D767
	public void SetCanExecuteChange(Func<int, bool> callback)
	{
		this.CanExecuteChange = callback;
	}

	// Token: 0x060184C1 RID: 99521 RVA: 0x0062F570 File Offset: 0x0062D770
	public EToggleState GetToggleState()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return EToggleState.ETT_UnChecked;
		}
		return extendToggle.GetToggleState();
	}

	// Token: 0x060184C2 RID: 99522 RVA: 0x0062F584 File Offset: 0x0062D784
	public UUIItem GetToggleItem()
	{
		return base.GetExtendToggle(0).GetRootComponent();
	}

	// Token: 0x060184C3 RID: 99523 RVA: 0x0062F592 File Offset: 0x0062D792
	public void SetToggleStateForce(bool @checked, bool fireEvent, bool skipAnim)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(@checked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, skipAnim, skipAnim);
	}

	// Token: 0x060184C4 RID: 99524 RVA: 0x0062F5B0 File Offset: 0x0062D7B0
	public override void Refresh(IWeatherToggleData data, bool isSelected, int gridIndex)
	{
		int configId = this.ConfigId;
		int? configId2 = data.ConfigId;
		bool flag = configId == configId2.GetValueOrDefault() & configId2 != null;
		this.IsEmptySlot = (data.ConfigId == null);
		this.ConfigId = data.ConfigId.GetValueOrDefault();
		if (!flag)
		{
			this.RefreshMainPerformance();
			this.RefreshToggleState();
		}
		if (data.ConfigId != null)
		{
			this.RefreshCurrentTimeState();
			this.RefreshCurrentTips();
			this.RefreshRedDot();
		}
	}

	// Token: 0x060184C5 RID: 99525 RVA: 0x0062F638 File Offset: 0x0062D838
	private void RefreshToggleState()
	{
		<WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState = <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.None;
		if (this.ConfigId != 0)
		{
			<WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState = (WeatherModel.Instance.IsWeatherSwitchConfigUnlocked(this.ConfigId) ? <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.Normal : <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.Lock);
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetSelfInteractive(<WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState > <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.None);
		}
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(<WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState == <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.None);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(<WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState == <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.Lock);
		}
		UUIItem item3 = base.GetItem(5);
		if (item3 != null)
		{
			item3.SetUIActive(<WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState == <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.Normal);
		}
		UUIItem item4 = base.GetItem(3);
		if (item4 != null)
		{
			item4.SetUIActive(<WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState == <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.Normal);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetUIActive(<WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState == <WeatherCentralMainView>FCA3A73D83E8B3686A0EE16465F16C3C9A1E40830743953A3B3DA53602DD45085__EToggleState.Normal);
		}
		UUIItem item5 = base.GetItem(8);
		if (item5 == null)
		{
			return;
		}
		item5.SetUIActive(false);
	}

	// Token: 0x060184C6 RID: 99526 RVA: 0x0062F6FC File Offset: 0x0062D8FC
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060184C7 RID: 99527 RVA: 0x0062F714 File Offset: 0x0062D914
	public void RefreshMainPerformance()
	{
		if (this.ConfigId == 0)
		{
			return;
		}
		WeatherSwitch? weatherSwitchConfig = WeatherModuleConfig.Instance.GetWeatherSwitchConfig(this.ConfigId);
		if (weatherSwitchConfig == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(weatherSwitchConfig.Value.Background, base.GetTexture(1), null);
		base.SetExtendToggleSpriteTransitionByPath(weatherSwitchConfig.Value.Icon, base.GetUiExtendToggleSpriteTransition(4), null).Forget();
		UUIText text = base.GetText(2);
		if (text == null)
		{
			return;
		}
		text.ShowTextNew(weatherSwitchConfig.Value.Name);
	}

	// Token: 0x060184C8 RID: 99528 RVA: 0x0062F7AC File Offset: 0x0062D9AC
	public void RefreshCurrentTimeState()
	{
		bool flag = WeatherModel.Instance.IsCurrentTimeInValidTime(this.ConfigId);
		bool flag2 = WeatherModel.Instance.IsWeatherSwitchConfigUnlocked(this.ConfigId);
		UUIItem item = base.GetItem(9);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!flag && flag2);
	}

	// Token: 0x060184C9 RID: 99529 RVA: 0x0062F7F4 File Offset: 0x0062D9F4
	public void RefreshCurrentTips()
	{
		WeatherModel instance = WeatherModel.Instance;
		int? num = (instance != null) ? new int?(instance.GetCurrentWeatherSwitchConfigId()) : null;
		int configId = this.ConfigId;
		bool flag = num.GetValueOrDefault() == configId & num != null;
		bool flag2 = WeatherModel.Instance.IsWeatherSwitchConfigUnlocked(this.ConfigId);
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(flag2 && flag);
	}

	// Token: 0x060184CA RID: 99530 RVA: 0x0062F860 File Offset: 0x0062DA60
	public void RefreshRedDot()
	{
		bool flag = WeatherModel.Instance.IsWeatherSwitchConfigUnlocked(this.ConfigId);
		bool flag2 = WeatherModel.Instance.IsWeatherClicked(this.ConfigId);
		UUIItem item = base.GetItem(8);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(flag && !flag2);
	}

	// Token: 0x0400B479 RID: 46201
	public int ConfigId;

	// Token: 0x0400B47A RID: 46202
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x0400B47B RID: 46203
	[Nullable(2)]
	private Func<int, bool> CanExecuteChange;

	// Token: 0x0400B47C RID: 46204
	private bool IsEmptySlot;
}
