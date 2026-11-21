using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020014A9 RID: 5289
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class SelectItem : GridProxyAbstract<InventoryDefine.ISelectItemData>
{
	// Token: 0x0600D3D0 RID: 54224 RVA: 0x003EF828 File Offset: 0x003EDA28
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

	// Token: 0x0600D3D1 RID: 54225 RVA: 0x003EF8F4 File Offset: 0x003EDAF4
	protected override void OnStart()
	{
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnClickedItem));
	}

	// Token: 0x0600D3D2 RID: 54226 RVA: 0x003EF913 File Offset: 0x003EDB13
	protected override void OnDestroy()
	{
		base.GetExtendToggle(0).OnStateChange.Clear();
	}

	// Token: 0x0600D3D3 RID: 54227 RVA: 0x003EF926 File Offset: 0x003EDB26
	[NullableContext(1)]
	public override void Refresh(InventoryDefine.ISelectItemData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshName();
		this.RefreshIcon();
		this.RefreshToggleState();
	}

	// Token: 0x0600D3D4 RID: 54228 RVA: 0x003EF944 File Offset: 0x003EDB44
	private void RefreshName()
	{
		string name = this.Data.Name;
		base.GetText(4).SetText(name, true);
	}

	// Token: 0x0600D3D5 RID: 54229 RVA: 0x003EF96C File Offset: 0x003EDB6C
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

	// Token: 0x0600D3D6 RID: 54230 RVA: 0x003EFA44 File Offset: 0x003EDC44
	public void RefreshToggleState()
	{
		if (this.CallbackGetState == null)
		{
			return;
		}
		EToggleState state = this.CallbackGetState(this.Data.Value) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state, false, false, false);
	}

	// Token: 0x0600D3D7 RID: 54231 RVA: 0x003EFA88 File Offset: 0x003EDC88
	[NullableContext(1)]
	public override object GetKey(InventoryDefine.ISelectItemData data, int displayIndex)
	{
		return this.Data.Value;
	}

	// Token: 0x0600D3D8 RID: 54232 RVA: 0x003EFA9A File Offset: 0x003EDC9A
	private void OnClickedItem(EToggleState state)
	{
		Action<EToggleState, int> callbackClickItem = this.CallbackClickItem;
		if (callbackClickItem == null)
		{
			return;
		}
		callbackClickItem(state, this.Data.Value);
	}

	// Token: 0x0400771E RID: 30494
	private InventoryDefine.ISelectItemData Data;

	// Token: 0x0400771F RID: 30495
	public Action<EToggleState, int> CallbackClickItem;

	// Token: 0x04007720 RID: 30496
	public Func<int, bool> CallbackGetState;

	// Token: 0x02007774 RID: 30580
	[NullableContext(0)]
	private enum EItemComponent
	{
		// Token: 0x04026C84 RID: 158852
		Toggle,
		// Token: 0x04026C85 RID: 158853
		IconRoot,
		// Token: 0x04026C86 RID: 158854
		Icon,
		// Token: 0x04026C87 RID: 158855
		Sprite,
		// Token: 0x04026C88 RID: 158856
		Content
	}
}
