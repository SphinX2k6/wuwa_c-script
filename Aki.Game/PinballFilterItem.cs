using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D27 RID: 3367
[NullableContext(1)]
[Nullable(0)]
public class PinballFilterItem : UiPanelBase
{
	// Token: 0x06008B80 RID: 35712 RVA: 0x002A2F31 File Offset: 0x002A1131
	public PinballFilterItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008B81 RID: 35713 RVA: 0x002A2F48 File Offset: 0x002A1148
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.ToggleEvent));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008B82 RID: 35714 RVA: 0x002A300F File Offset: 0x002A120F
	private void ToggleEvent(EToggleState state)
	{
		TFilterItemToggleEvent toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(state, this.Data.FilterId, this.Data.Content);
	}

	// Token: 0x06008B83 RID: 35715 RVA: 0x002A3038 File Offset: 0x002A1238
	private void SetContent()
	{
		string content = this.Data.Content;
		base.GetText(0).SetText(content, true);
	}

	// Token: 0x06008B84 RID: 35716 RVA: 0x002A3060 File Offset: 0x002A1260
	private void SetIcon()
	{
		FilterItemData data = this.Data;
		string text = (data != null) ? data.GetIconPath() : null;
		this.Icon = new PinballFilterIconView();
		this.Icon.CreateThenShowByActor(base.GetItem(2).GetOwner(), null);
		if (!StringUtils.IsBlank(text))
		{
			PinballFilterIconView icon = this.Icon;
			if (icon != null)
			{
				icon.SetIcon(true, text);
			}
			PinballFilterIconView icon2 = this.Icon;
			if (icon2 == null)
			{
				return;
			}
			icon2.SetBgChangeColor(false, null);
			return;
		}
		else
		{
			PinballFilterIconView icon3 = this.Icon;
			if (icon3 != null)
			{
				icon3.SetIcon(false, "");
			}
			PinballFilterIconView icon4 = this.Icon;
			if (icon4 == null)
			{
				return;
			}
			icon4.SetBgChangeColor(true, new FColor?(FColor.FromHex(this.Data.ChangeColor)));
			return;
		}
	}

	// Token: 0x06008B85 RID: 35717 RVA: 0x002A3116 File Offset: 0x002A1316
	public void SetToggleFunction(TFilterItemToggleEvent toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06008B86 RID: 35718 RVA: 0x002A3120 File Offset: 0x002A1320
	public void SetToggleState(bool bSelected)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(1).SetToggleState(state, false, false, false);
	}

	// Token: 0x06008B87 RID: 35719 RVA: 0x002A3146 File Offset: 0x002A1346
	public void ShowTemp(FilterItemData data, bool bSelected)
	{
		this.Data = data;
		this.SetContent();
		this.SetIcon();
		this.SetToggleState(bSelected);
	}

	// Token: 0x0400537C RID: 21372
	[Nullable(2)]
	private FilterItemData Data;

	// Token: 0x0400537D RID: 21373
	[Nullable(2)]
	private TFilterItemToggleEvent ToggleFunction;

	// Token: 0x0400537E RID: 21374
	[Nullable(2)]
	private PinballFilterIconView Icon;

	// Token: 0x02006FBA RID: 28602
	[NullableContext(0)]
	private enum EPinballFilterItemComponent
	{
		// Token: 0x04024805 RID: 149509
		Name,
		// Token: 0x04024806 RID: 149510
		Toggle,
		// Token: 0x04024807 RID: 149511
		Icon
	}
}
