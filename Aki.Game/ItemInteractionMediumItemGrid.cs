using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020018C9 RID: 6345
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ItemInteractionMediumItemGrid : LoopScrollMediumItemGrid<ItemInteractionPanelItemData>
{
	// Token: 0x0600BA19 RID: 47641 RVA: 0x002A2444 File Offset: 0x002A0644
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

	// Token: 0x0600BA1A RID: 47642 RVA: 0x002A2558 File Offset: 0x002A0758
	public override void OnSelected(bool fireEvent)
	{
		if (this.ItemInteractionPanelItemData != null)
		{
			this.ItemInteractionPanelItemData.IsSelected = true;
		}
		this.SetSelected(true, false);
	}

	// Token: 0x0600BA1B RID: 47643 RVA: 0x002A2576 File Offset: 0x002A0776
	public override void OnDeselected(bool fireEvent)
	{
		if (this.ItemInteractionPanelItemData != null)
		{
			this.ItemInteractionPanelItemData.IsSelected = false;
		}
		this.SetSelected(false, false);
	}

	// Token: 0x0400544E RID: 21582
	private int ItemCount;

	// Token: 0x0400544F RID: 21583
	[Nullable(2)]
	private ItemInteractionPanelItemData ItemInteractionPanelItemData;
}
