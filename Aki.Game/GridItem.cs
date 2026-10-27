using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

// Token: 0x02001C26 RID: 7206
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GridItem : LoopScrollSmallItemGrid<GridItemData>
{
	// Token: 0x0600D893 RID: 55443 RVA: 0x00322C97 File Offset: 0x00320E97
	protected override void OnRefresh(GridItemData data, bool isSelected, int gridIndex)
	{
		this.Refresh(data);
	}

	// Token: 0x0600D894 RID: 55444 RVA: 0x00322CA0 File Offset: 0x00320EA0
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600D895 RID: 55445 RVA: 0x00322CA3 File Offset: 0x00320EA3
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ConfigId, true, null);
	}

	// Token: 0x0600D896 RID: 55446 RVA: 0x00322CB8 File Offset: 0x00320EB8
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

	// Token: 0x040062B5 RID: 25269
	private int ConfigId;
}
