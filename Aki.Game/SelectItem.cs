using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001FD6 RID: 8150
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SelectItem : GridProxyAbstract<InventoryDefine.ISelectItemData>
{
	// Token: 0x0600FF68 RID: 65384 RVA: 0x003E3224 File Offset: 0x003E1424
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
	}

	// Token: 0x0600FF69 RID: 65385 RVA: 0x003E32F0 File Offset: 0x003E14F0
	protected override void OnStart()
	{
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnClickedItem));
	}

	// Token: 0x0600FF6A RID: 65386 RVA: 0x003E330F File Offset: 0x003E150F
	protected override void OnDestroy()
	{
		base.GetExtendToggle(0).OnStateChange.Clear();
	}

	// Token: 0x0600FF6B RID: 65387 RVA: 0x003E3322 File Offset: 0x003E1522
	[NullableContext(1)]
	public override void Refresh(InventoryDefine.ISelectItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshName();
		this.RefreshIcon();
		this.RefreshToggleState();
	}

	// Token: 0x0600FF6C RID: 65388 RVA: 0x003E3340 File Offset: 0x003E1540
	private void RefreshName()
	{
		string name = this.Data.Name;
		base.GetText(4).SetText(name, true);
	}

	// Token: 0x0600FF6D RID: 65389 RVA: 0x003E3368 File Offset: 0x003E1568
	private void RefreshIcon()
	{
		string iconPath = this.Data.IconPath;
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

	// Token: 0x0600FF6E RID: 65390 RVA: 0x003E3440 File Offset: 0x003E1640
	public void RefreshToggleState()
	{
		if (this.CallbackGetState == null)
		{
			return;
		}
		EToggleState state = this.CallbackGetState(this.Data.Value) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600FF6F RID: 65391 RVA: 0x003E3484 File Offset: 0x003E1684
	[NullableContext(1)]
	public override object GetKey(InventoryDefine.ISelectItemData data, int displayIndex)
	{
		return this.Data.Value;
	}

	// Token: 0x0600FF70 RID: 65392 RVA: 0x003E3496 File Offset: 0x003E1696
	private void OnClickedItem(EToggleState state)
	{
		Action<EToggleState, int> callbackClickItem = this.CallbackClickItem;
		if (callbackClickItem == null)
		{
			return;
		}
		callbackClickItem(state, this.Data.Value);
	}

	// Token: 0x04007635 RID: 30261
	private InventoryDefine.ISelectItemData Data;

	// Token: 0x04007636 RID: 30262
	public Action<EToggleState, int> CallbackClickItem;

	// Token: 0x04007637 RID: 30263
	public Func<int, bool> CallbackGetState;

	// Token: 0x020085ED RID: 34285
	[NullableContext(0)]
	private enum EItemComponent
	{
		// Token: 0x0402B975 RID: 178549
		Toggle,
		// Token: 0x0402B976 RID: 178550
		IconRoot,
		// Token: 0x0402B977 RID: 178551
		Icon,
		// Token: 0x0402B978 RID: 178552
		Sprite,
		// Token: 0x0402B979 RID: 178553
		Content
	}
}
