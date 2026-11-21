using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001444 RID: 5188
[NullableContext(1)]
[Nullable(0)]
internal class AreaButtonItem : UiPanelBase
{
	// Token: 0x0600CE5B RID: 52827 RVA: 0x003D597A File Offset: 0x003D3B7A
	public AreaButtonItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600CE5C RID: 52828 RVA: 0x003D5990 File Offset: 0x003D3B90
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600CE5D RID: 52829 RVA: 0x003D5A78 File Offset: 0x003D3C78
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleFunction(this.CountryId);
		}
	}

	// Token: 0x0600CE5E RID: 52830 RVA: 0x003D5A91 File Offset: 0x003D3C91
	protected override void OnStart()
	{
		base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x0600CE5F RID: 52831 RVA: 0x003D5AB0 File Offset: 0x003D3CB0
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(1).CanExecuteChange.Unbind();
	}

	// Token: 0x0600CE60 RID: 52832 RVA: 0x003D5AC3 File Offset: 0x003D3CC3
	private bool CanExecuteChange()
	{
		return this.CanExecuteChangeFunction == null || this.CanExecuteChangeFunction(this.CountryId);
	}

	// Token: 0x0600CE61 RID: 52833 RVA: 0x003D5AE0 File Offset: 0x003D3CE0
	private void SetRedDot(bool isUnlock)
	{
		bool flag = InfluenceReputationModel.Instance.HasRedDotInCurrentCountry(this.CountryId);
		base.GetItem(3).SetUIActive(flag && isUnlock);
	}

	// Token: 0x0600CE62 RID: 52834 RVA: 0x003D5B10 File Offset: 0x003D3D10
	public void UpdateItem(int countryId)
	{
		this.CountryId = countryId;
		Country? countryConfig = InfluenceConfig.Instance.GetCountryConfig(countryId);
		bool flag = InfluenceReputationModel.Instance.IsCountryUnLock(countryId);
		UUITexture texture = base.GetTexture(0);
		UUIItem item = base.GetItem(2);
		texture.SetUIActive(flag);
		item.SetUIActive(!flag);
		if (flag && countryConfig != null)
		{
			base.SetTextureByPath(countryConfig.Value.Logo, texture, null, null);
		}
		this.SetRedDot(flag);
	}

	// Token: 0x0600CE63 RID: 52835 RVA: 0x003D5B8F File Offset: 0x003D3D8F
	public void SetToggleFunction(TAreaToggleFunction callback)
	{
		this.ToggleFunction = callback;
	}

	// Token: 0x0600CE64 RID: 52836 RVA: 0x003D5B98 File Offset: 0x003D3D98
	public void SetCanExecuteChange(TAreaCanExecuteChange callback)
	{
		this.CanExecuteChangeFunction = callback;
	}

	// Token: 0x0600CE65 RID: 52837 RVA: 0x003D5BA1 File Offset: 0x003D3DA1
	public void SetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x04007574 RID: 30068
	[Nullable(2)]
	private TAreaToggleFunction ToggleFunction;

	// Token: 0x04007575 RID: 30069
	[Nullable(2)]
	private TAreaCanExecuteChange CanExecuteChangeFunction;

	// Token: 0x04007576 RID: 30070
	private int CountryId;

	// Token: 0x020076F3 RID: 30451
	[NullableContext(0)]
	private enum EAreaButtonItem
	{
		// Token: 0x04026A39 RID: 158265
		Texture,
		// Token: 0x04026A3A RID: 158266
		Toggle,
		// Token: 0x04026A3B RID: 158267
		Lock,
		// Token: 0x04026A3C RID: 158268
		RedDot
	}
}
