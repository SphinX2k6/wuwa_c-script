using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x020010E5 RID: 4325
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GridItem : LoopScrollSmallItemGrid<GridItemData>
{
	// Token: 0x0600ACA9 RID: 44201 RVA: 0x0032E06F File Offset: 0x0032C26F
	protected override void OnRefresh(GridItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0600ACAA RID: 44202 RVA: 0x0032E078 File Offset: 0x0032C278
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600ACAB RID: 44203 RVA: 0x0032E07B File Offset: 0x0032C27B
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null, false);
	}

	// Token: 0x0600ACAC RID: 44204 RVA: 0x0032E090 File Offset: 0x0032C290
	public void Refresh(GridItemData data)
	{
		if (data != null && data.Data != null)
		{
			InventoryDefine.IGetItemData itemData = data.Data.Value.ItemData;
			int count = data.Data.Value.Count;
			this.ConfigId = itemData.ItemId;
			bool getRewardState = data.GetRewardState;
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				Data = data,
				ItemConfigId = new int?(this.ConfigId),
				BottomText = ((count > 0) ? count.ToString() : ""),
				IsReceivedVisible = new bool?(getRewardState)
			};
			base.Apply<PropSmallItemGrid>(parameters);
		}
	}

	// Token: 0x04006387 RID: 25479
	private int ConfigId;
}
