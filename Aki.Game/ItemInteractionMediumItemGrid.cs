using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02000D82 RID: 3458
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ItemInteractionMediumItemGrid : LoopScrollMediumItemGrid<ItemInteractionPanelItemData>
{
	// Token: 0x06008E02 RID: 36354 RVA: 0x002ACB9C File Offset: 0x002AAD9C
	protected override void OnRefresh(ItemInteractionPanelItemData data, bool isSelected, int gridIndex)
	{
		this.ItemInteractionPanelItemData = data;
		int itemConfigId = data.ItemConfigId;
		this.ItemCount = InventoryModel.Instance.GetItemCountByConfigId(itemConfigId, 0);
		int currentCount = data.GetCurrentCount();
		int needCount = data.NeedCount;
		PropMediumItemGrid propMediumItemGrid = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(itemConfigId),
			IsDisable = new bool?(!data.IsEnable())
		};
		if (currentCount > 0)
		{
			propMediumItemGrid.BottomTextId = "ItemCountSelected";
			propMediumItemGrid.BottomTextParameter = new object[]
			{
				currentCount,
				this.ItemCount
			};
			propMediumItemGrid.ReduceButtonInfo = new LongPressButton
			{
				IsVisible = new bool?(true),
				LongPressConfigId = new LongPressButtonItem.ELongPressConfigId?(LongPressButtonItem.ELongPressConfigId.LongPressOne)
			};
		}
		else if (this.ItemCount < needCount)
		{
			propMediumItemGrid.BottomTextId = "ItemCountNotEnough";
			propMediumItemGrid.BottomTextParameter = new object[]
			{
				this.ItemCount
			};
		}
		else
		{
			propMediumItemGrid.BottomText = this.ItemCount.ToString();
		}
		base.Apply<PropMediumItemGrid>(propMediumItemGrid);
		this.SetSelected(data.IsSelected, true);
	}

	// Token: 0x06008E03 RID: 36355 RVA: 0x002ACCB0 File Offset: 0x002AAEB0
	public override void OnSelected(bool fireEvent)
	{
		if (this.ItemInteractionPanelItemData != null)
		{
			this.ItemInteractionPanelItemData.IsSelected = true;
		}
		this.SetSelected(true, false);
	}

	// Token: 0x06008E04 RID: 36356 RVA: 0x002ACCCE File Offset: 0x002AAECE
	public override void OnDeselected(bool fireEvent)
	{
		if (this.ItemInteractionPanelItemData != null)
		{
			this.ItemInteractionPanelItemData.IsSelected = false;
		}
		this.SetSelected(false, false);
	}

	// Token: 0x040054F9 RID: 21753
	private int ItemCount;

	// Token: 0x040054FA RID: 21754
	[Nullable(2)]
	private ItemInteractionPanelItemData ItemInteractionPanelItemData;
}
