using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;

// Token: 0x02000C26 RID: 3110
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionRefineMaterialItem : LoopScrollMediumItemGrid<ISelectedData>
{
	// Token: 0x060081CC RID: 33228 RVA: 0x0027D398 File Offset: 0x0027B598
	protected override void OnRefresh(ISelectedData data, bool isSelected, int gridIndex)
	{
		int count = data.Count;
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(data.ItemId, 0);
		string bottomText = "";
		if (count <= 0)
		{
			bottomText = itemCountByConfigId.ToString();
		}
		else if (itemCountByConfigId < count)
		{
			bottomText = StringUtils.Format("Text_ItemNotEnoughText_Text", new string[]
			{
				itemCountByConfigId.ToString(),
				count.ToString()
			});
		}
		else if (itemCountByConfigId >= count)
		{
			bottomText = StringUtils.Format("Text_ItemEnoughText_Text", new string[]
			{
				itemCountByConfigId.ToString(),
				count.ToString()
			});
		}
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.ItemId),
			BottomText = bottomText
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x060081CD RID: 33229 RVA: 0x0027D452 File Offset: 0x0027B652
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x060081CE RID: 33230 RVA: 0x0027D458 File Offset: 0x0027B658
	protected override void OnExtendToggleClicked()
	{
		ISelectedData selectedData = this.Data as ISelectedData;
		ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null, false);
	}
}
