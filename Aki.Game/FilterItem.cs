using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D12 RID: 3346
[NullableContext(1)]
[Nullable(0)]
public class FilterItem : UiPanelBase
{
	// Token: 0x06008A85 RID: 35461 RVA: 0x0029ECCE File Offset: 0x0029CECE
	public FilterItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06008A86 RID: 35462 RVA: 0x0029ECE4 File Offset: 0x0029CEE4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleEvent));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008A87 RID: 35463 RVA: 0x0029EDED File Offset: 0x0029CFED
	private void ToggleEvent(EToggleState state)
	{
		TFilterItemToggleEvent toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(state, this.Data.FilterId, this.Data.Content);
	}

	// Token: 0x06008A88 RID: 35464 RVA: 0x0029EE18 File Offset: 0x0029D018
	private void SetContent()
	{
		string content = this.Data.Content;
		base.GetText(4).SetText(content, true);
	}

	// Token: 0x06008A89 RID: 35465 RVA: 0x0029EE40 File Offset: 0x0029D040
	private void SetIcon()
	{
		string iconPath = this.Data.GetIconPath();
		UUIItem item = base.GetItem(1);
		if (StringUtils.IsBlank(iconPath))
		{
			item.SetUIActive(false);
			return;
		}
		item.SetUIActive(true);
		bool flag = iconPath.Contains("Atlas");
		UUITexture texture = base.GetTexture(2);
		texture.SetUIActive(!flag);
		UUISprite sprite = base.GetSprite(3);
		sprite.SetUIActive(flag);
		FColor? fcolor;
		if (flag)
		{
			this.SetSpriteByPath(iconPath, sprite, false, null, null);
			UUIItem uuiitem = sprite;
			bool needChangeColor = this.Data.NeedChangeColor;
			fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(needChangeColor, fcolor);
			return;
		}
		base.SetTextureByPath(iconPath, texture, null, null);
		UUIItem uuiitem2 = texture;
		bool needChangeColor2 = this.Data.NeedChangeColor;
		fcolor = new FColor?(texture.changeColor);
		uuiitem2.SetChangeColor(needChangeColor2, fcolor);
	}

	// Token: 0x06008A8A RID: 35466 RVA: 0x0029EF15 File Offset: 0x0029D115
	public void SetToggleFunction(TFilterItemToggleEvent toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x06008A8B RID: 35467 RVA: 0x0029EF20 File Offset: 0x0029D120
	public void SetToggleState(bool bSelected)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x06008A8C RID: 35468 RVA: 0x0029EF46 File Offset: 0x0029D146
	public void ShowTemp(FilterItemData data, bool bSelected)
	{
		this.Data = data;
		this.SetContent();
		this.SetIcon();
		this.SetToggleState(bSelected);
	}

	// Token: 0x0400532E RID: 21294
	[Nullable(2)]
	private FilterItemData Data;

	// Token: 0x0400532F RID: 21295
	[Nullable(2)]
	private TFilterItemToggleEvent ToggleFunction;

	// Token: 0x02006FA1 RID: 28577
	[NullableContext(0)]
	private enum EFilterItemDefine
	{
		// Token: 0x0402478E RID: 149390
		Toggle,
		// Token: 0x0402478F RID: 149391
		IconRoot,
		// Token: 0x04024790 RID: 149392
		Icon,
		// Token: 0x04024791 RID: 149393
		Sprite,
		// Token: 0x04024792 RID: 149394
		Content
	}
}
