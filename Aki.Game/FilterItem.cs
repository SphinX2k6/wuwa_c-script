using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001859 RID: 6233
[NullableContext(1)]
[Nullable(0)]
public class FilterItem : UiPanelBase
{
	// Token: 0x0600B69C RID: 46748 RVA: 0x002945A2 File Offset: 0x002927A2
	public FilterItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600B69D RID: 46749 RVA: 0x002945B8 File Offset: 0x002927B8
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

	// Token: 0x0600B69E RID: 46750 RVA: 0x002946C1 File Offset: 0x002928C1
	private void ToggleEvent(EToggleState state)
	{
		TFilterItemToggleEvent toggleFunction = this.ToggleFunction;
		if (toggleFunction == null)
		{
			return;
		}
		toggleFunction(state, this.Data.FilterId, this.Data.Content);
	}

	// Token: 0x0600B69F RID: 46751 RVA: 0x002946EC File Offset: 0x002928EC
	private void SetContent()
	{
		string content = this.Data.Content;
		base.GetText(4).SetText(content, true);
	}

	// Token: 0x0600B6A0 RID: 46752 RVA: 0x00294714 File Offset: 0x00292914
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

	// Token: 0x0600B6A1 RID: 46753 RVA: 0x002947E9 File Offset: 0x002929E9
	public void SetToggleFunction(TFilterItemToggleEvent toggleFunction)
	{
		this.ToggleFunction = toggleFunction;
	}

	// Token: 0x0600B6A2 RID: 46754 RVA: 0x002947F4 File Offset: 0x002929F4
	public void SetToggleState(bool bSelected)
	{
		EToggleState state = bSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600B6A3 RID: 46755 RVA: 0x0029481A File Offset: 0x00292A1A
	public void ShowTemp(FilterItemData data, bool bSelected)
	{
		this.Data = data;
		this.SetContent();
		this.SetIcon();
		this.SetToggleState(bSelected);
	}

	// Token: 0x04005283 RID: 21123
	[Nullable(2)]
	private FilterItemData Data;

	// Token: 0x04005284 RID: 21124
	[Nullable(2)]
	private TFilterItemToggleEvent ToggleFunction;

	// Token: 0x02007E1A RID: 32282
	[NullableContext(0)]
	private enum EFilterItemDefine
	{
		// Token: 0x04029461 RID: 169057
		Toggle,
		// Token: 0x04029462 RID: 169058
		IconRoot,
		// Token: 0x04029463 RID: 169059
		Icon,
		// Token: 0x04029464 RID: 169060
		Sprite,
		// Token: 0x04029465 RID: 169061
		Content
	}
}
