using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001379 RID: 4985
internal class BuffScrollItem : UiPanelBase
{
	// Token: 0x06008B7B RID: 35707 RVA: 0x001DD258 File Offset: 0x001DB458
	protected unsafe override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		int num = 1;
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list, num);
		Span<ValueTuple<int, Delegate>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list);
		int index = 0;
		*span[index] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list;
	}

	// Token: 0x06008B7C RID: 35708 RVA: 0x001DD334 File Offset: 0x001DB534
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Unbind();
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06008B7D RID: 35709 RVA: 0x001DD380 File Offset: 0x001DB580
	private bool CanClickLikeToggle()
	{
		return this.CurrentData != null && this.CurrentData.CheckClickAble != null && this.CurrentData.CheckClickAble(this.CurrentData);
	}

	// Token: 0x06008B7E RID: 35710 RVA: 0x001DD3B1 File Offset: 0x001DB5B1
	private void OnClickToggle(EToggleState toggleState)
	{
		this.CurrentData.OnClickToggle(this.CurrentData);
	}

	// Token: 0x06008B7F RID: 35711 RVA: 0x001DD3CC File Offset: 0x001DB5CC
	public void SetToggleActiveState(bool state)
	{
		base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06008B80 RID: 35712 RVA: 0x001DD3F3 File Offset: 0x001DB5F3
	[NullableContext(1)]
	public void Refresh(BuffScrollItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.RefreshLockState();
		this.RefreshToggleState();
		this.RefreshName();
		this.RefreshDesc();
		this.RefreshBuffTexture();
		this.RefreshSelectedTag();
	}

	// Token: 0x06008B81 RID: 35713 RVA: 0x001DD420 File Offset: 0x001DB620
	private void RefreshSelectedTag()
	{
		base.GetItem(5).SetUIActive(this.CurrentData.SelectedAtStart);
	}

	// Token: 0x06008B82 RID: 35714 RVA: 0x001DD43C File Offset: 0x001DB63C
	private void RefreshToggleState()
	{
		EToggleState state = this.CurrentData.Selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06008B83 RID: 35715 RVA: 0x001DD46C File Offset: 0x001DB66C
	private void RefreshLockState()
	{
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x06008B84 RID: 35716 RVA: 0x001DD47C File Offset: 0x001DB67C
	private void RefreshName()
	{
		MowTowerBuffRe? mowingTowerBuffById = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentData.BuffId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), mowingTowerBuffById.Value.Name, Array.Empty<object>());
	}

	// Token: 0x06008B85 RID: 35717 RVA: 0x001DD4C4 File Offset: 0x001DB6C4
	private void RefreshDesc()
	{
		MowTowerBuffRe? mowingTowerBuffById = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentData.BuffId);
		List<string> list = new List<string>();
		int descriptionParamLength = mowingTowerBuffById.Value.DescriptionParamLength;
		for (int i = 0; i < descriptionParamLength; i++)
		{
			string text = mowingTowerBuffById.Value.DescriptionParam(i);
			Match match = new Regex("\\[(.*?)\\]").Match(text ?? "");
			if (match.Success && match.Groups.Count > 1)
			{
				string[] array = match.Groups[1].Value.Split(',', StringSplitOptions.None);
				for (int j = 0; j < array.Length; j++)
				{
					list.Add(array[j]);
				}
			}
		}
		object[] array2 = new object[list.Count];
		for (int k = 0; k < list.Count; k++)
		{
			array2[k] = list[k];
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), mowingTowerBuffById.Value.Description, array2);
	}

	// Token: 0x06008B86 RID: 35718 RVA: 0x001DD5E8 File Offset: 0x001DB7E8
	private void RefreshBuffTexture()
	{
		string texture = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentData.BuffId).Value.Texture;
		base.SetTextureByPath(texture, base.GetTexture(1), null, null);
	}

	// Token: 0x04003DE7 RID: 15847
	[Nullable(2)]
	private BuffScrollItemData CurrentData;
}
