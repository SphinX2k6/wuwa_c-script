using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Weather;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200227F RID: 8831
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WeatherToggleItem : GridProxyAbstract<IWeatherToggleData>
{
	// Token: 0x06015D5E RID: 89438 RVA: 0x00655388 File Offset: 0x00653588
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

	// Token: 0x06015D5F RID: 89439 RVA: 0x00655538 File Offset: 0x00653738
	protected override void OnStart()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.CanExecuteChange.Bind(() => !this.IsEmptySlot && (this.CanExecuteChange == null || this.CanExecuteChange(base.GridIndex)));
	}

	// Token: 0x06015D60 RID: 89440 RVA: 0x0065555C File Offset: 0x0065375C
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

	// Token: 0x06015D61 RID: 89441 RVA: 0x00655572 File Offset: 0x00653772
	public void SetToggleClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06015D62 RID: 89442 RVA: 0x0065557B File Offset: 0x0065377B
	public void SetCanExecuteChange(Func<int, bool> callback)
	{
		this.CanExecuteChange = callback;
	}

	// Token: 0x06015D63 RID: 89443 RVA: 0x00655584 File Offset: 0x00653784
	public EToggleState GetToggleState()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return EToggleState.ETT_UnChecked;
		}
		return extendToggle.GetToggleState();
	}

	// Token: 0x06015D64 RID: 89444 RVA: 0x00655598 File Offset: 0x00653798
	public UUIItem GetToggleItem()
	{
		return base.GetExtendToggle(0).GetRootComponent();
	}

	// Token: 0x06015D65 RID: 89445 RVA: 0x006555A6 File Offset: 0x006537A6
	public void SetToggleStateForce(bool @checked, bool fireEvent, bool skipAnim)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(@checked ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, fireEvent, skipAnim, skipAnim);
	}

	// Token: 0x06015D66 RID: 89446 RVA: 0x006555C4 File Offset: 0x006537C4
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

	// Token: 0x06015D67 RID: 89447 RVA: 0x0065564C File Offset: 0x0065384C
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

	// Token: 0x06015D68 RID: 89448 RVA: 0x00655710 File Offset: 0x00653910
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06015D69 RID: 89449 RVA: 0x00655728 File Offset: 0x00653928
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

	// Token: 0x06015D6A RID: 89450 RVA: 0x006557C0 File Offset: 0x006539C0
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

	// Token: 0x06015D6B RID: 89451 RVA: 0x00655808 File Offset: 0x00653A08
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

	// Token: 0x06015D6C RID: 89452 RVA: 0x00655874 File Offset: 0x00653A74
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

	// Token: 0x0400B7EE RID: 47086
	public int ConfigId;

	// Token: 0x0400B7EF RID: 47087
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x0400B7F0 RID: 47088
	[Nullable(2)]
	private Func<int, bool> CanExecuteChange;

	// Token: 0x0400B7F1 RID: 47089
	private bool IsEmptySlot;
}
