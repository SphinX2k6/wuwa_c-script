using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F82 RID: 8066
[NullableContext(1)]
[Nullable(0)]
internal class AreaButtonItem : UiPanelBase
{
	// Token: 0x0600FA3C RID: 64060 RVA: 0x003C9E3E File Offset: 0x003C803E
	public AreaButtonItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600FA3D RID: 64061 RVA: 0x003C9E54 File Offset: 0x003C8054
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

	// Token: 0x0600FA3E RID: 64062 RVA: 0x003C9F3C File Offset: 0x003C813C
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ToggleFunction(this.CountryId);
		}
	}

	// Token: 0x0600FA3F RID: 64063 RVA: 0x003C9F55 File Offset: 0x003C8155
	protected override void OnStart()
	{
		base.GetExtendToggle(1).CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
	}

	// Token: 0x0600FA40 RID: 64064 RVA: 0x003C9F74 File Offset: 0x003C8174
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(1).CanExecuteChange.Unbind();
	}

	// Token: 0x0600FA41 RID: 64065 RVA: 0x003C9F87 File Offset: 0x003C8187
	private bool CanExecuteChange()
	{
		return this.CanExecuteChangeFunction == null || this.CanExecuteChangeFunction(this.CountryId);
	}

	// Token: 0x0600FA42 RID: 64066 RVA: 0x003C9FA4 File Offset: 0x003C81A4
	private void SetRedDot(bool isUnlock)
	{
		bool flag = InfluenceReputationModel.Instance.HasRedDotInCurrentCountry(this.CountryId);
		base.GetItem(3).SetUIActive(flag && isUnlock);
	}

	// Token: 0x0600FA43 RID: 64067 RVA: 0x003C9FD4 File Offset: 0x003C81D4
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

	// Token: 0x0600FA44 RID: 64068 RVA: 0x003CA053 File Offset: 0x003C8253
	public void SetToggleFunction(TAreaToggleFunction callback)
	{
		this.ToggleFunction = callback;
	}

	// Token: 0x0600FA45 RID: 64069 RVA: 0x003CA05C File Offset: 0x003C825C
	public void SetCanExecuteChange(TAreaCanExecuteChange callback)
	{
		this.CanExecuteChangeFunction = callback;
	}

	// Token: 0x0600FA46 RID: 64070 RVA: 0x003CA065 File Offset: 0x003C8265
	public void SetToggleState(EToggleState state, bool bFire)
	{
		base.GetExtendToggle(1).SetToggleStateForce(state, bFire, false, false);
	}

	// Token: 0x04007493 RID: 29843
	[Nullable(2)]
	private TAreaToggleFunction ToggleFunction;

	// Token: 0x04007494 RID: 29844
	[Nullable(2)]
	private TAreaCanExecuteChange CanExecuteChangeFunction;

	// Token: 0x04007495 RID: 29845
	private int CountryId;

	// Token: 0x0200856E RID: 34158
	[NullableContext(0)]
	private enum EAreaButtonItem
	{
		// Token: 0x0402B716 RID: 177942
		Texture,
		// Token: 0x0402B717 RID: 177943
		Toggle,
		// Token: 0x0402B718 RID: 177944
		Lock,
		// Token: 0x0402B719 RID: 177945
		RedDot
	}
}
