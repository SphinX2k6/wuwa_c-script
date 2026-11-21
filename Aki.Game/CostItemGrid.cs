using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001D20 RID: 7456
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CostItemGrid : GridProxyAbstract<ISelectedData>
{
	// Token: 0x0601278D RID: 75661 RVA: 0x00575120 File Offset: 0x00573320
	[NullableContext(2)]
	public CostItemGrid(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x0601278E RID: 75662 RVA: 0x00575137 File Offset: 0x00573337
	public override void Refresh(ISelectedData data, bool isSelected, int gridIndex)
	{
		this.RefreshBySelectedData(data);
	}

	// Token: 0x0601278F RID: 75663 RVA: 0x00575140 File Offset: 0x00573340
	protected override void OnStart()
	{
		this.ItemGridVariantSelect = new ItemGridVariantSelect(null, null, null);
		this.ItemGridVariantSelect.CreateThenShowByActor(this.RootItem.GetOwner());
		Action<int, CSharpScript.Game.Module.Inventory.ItemConfig> toggleClickEvent = delegate(int _, CSharpScript.Game.Module.Inventory.ItemConfig _)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemGridVariantSelect.GetConfigId(), true, null, false);
			this.ItemGridVariantSelect.GetClickToggle().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		};
		this.ItemGridVariantSelect.SetToggleClickEvent(toggleClickEvent);
		this.ItemGridVariantSelect.GetAddButton().RootUIComp.Get().SetUIActive(false);
		this.ItemGridVariantSelect.GetReduceButton().RootUIComp.Get().SetUIActive(false);
		this.ItemGridVariantSelect.RefreshItemShowState(true);
	}

	// Token: 0x06012790 RID: 75664 RVA: 0x005751DA File Offset: 0x005733DA
	public void RefreshBySelectedData(ISelectedData data)
	{
		this.ItemGridVariantSelect.RefreshByItemId(data.ItemId);
		this.RefreshCountBySelectedData(data);
	}

	// Token: 0x06012791 RID: 75665 RVA: 0x005751F4 File Offset: 0x005733F4
	protected override void OnBeforeDestroy()
	{
		ItemGridVariantSelect itemGridVariantSelect = this.ItemGridVariantSelect;
		if (itemGridVariantSelect == null)
		{
			return;
		}
		itemGridVariantSelect.Destroy(null);
	}

	// Token: 0x06012792 RID: 75666 RVA: 0x00575208 File Offset: 0x00573408
	public void RefreshCountBySelectedData(ISelectedData data)
	{
		int selectedCount = data.SelectedCount;
		int count = data.Count;
		string text = "Text_ItemEnoughText_Text";
		if (selectedCount < count)
		{
			text = "Text_ItemNotEnoughText_Text";
		}
		this.ItemGridVariantSelect.RefreshTextDownByTextId(true, text, new object[]
		{
			selectedCount,
			count
		});
	}

	// Token: 0x0400A0BA RID: 41146
	[Nullable(2)]
	private ItemGridVariantSelect ItemGridVariantSelect;
}
