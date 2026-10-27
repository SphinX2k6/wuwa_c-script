using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;

// Token: 0x0200176D RID: 5997
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class VisionRefineMaterialItem : LoopScrollMediumItemGrid<ISelectedData>
{
	// Token: 0x0600ADE5 RID: 44517 RVA: 0x00272ED4 File Offset: 0x002710D4
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

	// Token: 0x0600ADE6 RID: 44518 RVA: 0x00272F8E File Offset: 0x0027118E
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0600ADE7 RID: 44519 RVA: 0x00272F94 File Offset: 0x00271194
	protected override void OnExtendToggleClicked()
	{
		ISelectedData selectedData = this.Data as ISelectedData;
		ItemController.Instance.OpenItemTipsByItemId(selectedData.ItemId, true, null);
	}
}
