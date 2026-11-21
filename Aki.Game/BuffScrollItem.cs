using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200082D RID: 2093
internal class BuffScrollItem : UiPanelBase
{
	// Token: 0x06005F16 RID: 24342 RVA: 0x001E6094 File Offset: 0x001E4294
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

	// Token: 0x06005F17 RID: 24343 RVA: 0x001E6170 File Offset: 0x001E4370
	protected override void OnStart()
	{
		base.GetExtendToggle(0).CanExecuteChange.Unbind();
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanClickLikeToggle));
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06005F18 RID: 24344 RVA: 0x001E61BC File Offset: 0x001E43BC
	private bool CanClickLikeToggle()
	{
		return this.CurrentData != null && this.CurrentData.CheckClickAble != null && this.CurrentData.CheckClickAble(this.CurrentData);
	}

	// Token: 0x06005F19 RID: 24345 RVA: 0x001E61ED File Offset: 0x001E43ED
	private void OnClickToggle(EToggleState toggleState)
	{
		this.CurrentData.OnClickToggle(this.CurrentData);
	}

	// Token: 0x06005F1A RID: 24346 RVA: 0x001E6208 File Offset: 0x001E4408
	public void SetToggleActiveState(bool state)
	{
		base.GetExtendToggle(0).RootUIComp.Get().SetUIActive(state);
	}

	// Token: 0x06005F1B RID: 24347 RVA: 0x001E622F File Offset: 0x001E442F
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

	// Token: 0x06005F1C RID: 24348 RVA: 0x001E625C File Offset: 0x001E445C
	private void RefreshSelectedTag()
	{
		base.GetItem(5).SetUIActive(this.CurrentData.SelectedAtStart);
	}

	// Token: 0x06005F1D RID: 24349 RVA: 0x001E6278 File Offset: 0x001E4478
	private void RefreshToggleState()
	{
		EToggleState state = this.CurrentData.Selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06005F1E RID: 24350 RVA: 0x001E62A8 File Offset: 0x001E44A8
	private void RefreshLockState()
	{
		base.GetItem(4).SetUIActive(false);
	}

	// Token: 0x06005F1F RID: 24351 RVA: 0x001E62B8 File Offset: 0x001E44B8
	private void RefreshName()
	{
		MowTowerBuffRe? mowingTowerBuffById = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentData.BuffId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), mowingTowerBuffById.Value.Name, Array.Empty<object>());
	}

	// Token: 0x06005F20 RID: 24352 RVA: 0x001E6300 File Offset: 0x001E4500
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

	// Token: 0x06005F21 RID: 24353 RVA: 0x001E6424 File Offset: 0x001E4624
	private void RefreshBuffTexture()
	{
		string texture = MowingTowerConfig.Instance.GetMowingTowerBuffById(this.CurrentData.BuffId).Value.Texture;
		base.SetTextureByPath(texture, base.GetTexture(1), null, null);
	}

	// Token: 0x04003E7F RID: 15999
	[Nullable(2)]
	private BuffScrollItemData CurrentData;
}
