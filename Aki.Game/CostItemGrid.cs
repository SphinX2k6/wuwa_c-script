using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020027A5 RID: 10149
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CostItemGrid : GridProxyAbstract<ISelectedData>
{
	// Token: 0x06014D93 RID: 85395 RVA: 0x0054A598 File Offset: 0x00548798
	[NullableContext(2)]
	public CostItemGrid(UUIItem uiItem = null)
	{
		if (uiItem != null)
		{
			this.CreateThenShowByActor(uiItem.GetOwner());
		}
	}

	// Token: 0x06014D94 RID: 85396 RVA: 0x0054A5AF File Offset: 0x005487AF
	public override void Refresh(ISelectedData data, bool isSelected, int gridIndex)
	{
		this.RefreshBySelectedData(data);
	}

	// Token: 0x06014D95 RID: 85397 RVA: 0x0054A5B8 File Offset: 0x005487B8
	protected override void OnStart()
	{
		this.ItemGridVariantSelect = new ItemGridVariantSelect(null, null, null);
		this.ItemGridVariantSelect.CreateThenShowByActor(this.RootItem.GetOwner());
		Action<int, CSharpScript.Game.Module.Inventory.ItemConfig> toggleClickEvent = delegate(int _, CSharpScript.Game.Module.Inventory.ItemConfig _)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.ItemGridVariantSelect.GetConfigId(), true, null);
			this.ItemGridVariantSelect.GetClickToggle().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
		};
		this.ItemGridVariantSelect.SetToggleClickEvent(toggleClickEvent);
		this.ItemGridVariantSelect.GetAddButton().RootUIComp.Get().SetUIActive(false);
		this.ItemGridVariantSelect.GetReduceButton().RootUIComp.Get().SetUIActive(false);
		this.ItemGridVariantSelect.RefreshItemShowState(true);
	}

	// Token: 0x06014D96 RID: 85398 RVA: 0x0054A652 File Offset: 0x00548852
	public void RefreshBySelectedData(ISelectedData data)
	{
		this.ItemGridVariantSelect.RefreshByItemId(data.ItemId);
		this.RefreshCountBySelectedData(data);
	}

	// Token: 0x06014D97 RID: 85399 RVA: 0x0054A66C File Offset: 0x0054886C
	protected override void OnBeforeDestroy()
	{
		ItemGridVariantSelect itemGridVariantSelect = this.ItemGridVariantSelect;
		if (itemGridVariantSelect == null)
		{
			return;
		}
		itemGridVariantSelect.Destroy(null);
	}

	// Token: 0x06014D98 RID: 85400 RVA: 0x0054A680 File Offset: 0x00548880
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

	// Token: 0x04009CD7 RID: 40151
	[Nullable(2)]
	private ItemGridVariantSelect ItemGridVariantSelect;
}
