using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x0200048F RID: 1167
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurnitureHandBookItem : LoopScrollMediumItemGrid<IFurnitureHandBookItemData>
{
	// Token: 0x06003BD4 RID: 15316 RVA: 0x001539F0 File Offset: 0x00151BF0
	[NullableContext(1)]
	protected override void OnRefresh(IFurnitureHandBookItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			ItemConfigId = new int?(data.FurnitureConfig.Id),
			IsLockVisible = new bool?(data.IsLock),
			BottomTextId = data.FurnitureConfig.Name,
			Data = data,
			QualityId = new int?(data.FurnitureConfig.QualityId),
			IsRedDotVisible = new bool?(data.RedDotVisible),
			IsDisable = new bool?(data.IsLock)
		};
		base.Apply<PropMediumItemGrid>(parameters);
		this.SetSelected(isSelected, false);
	}

	// Token: 0x06003BD5 RID: 15317 RVA: 0x00153A9C File Offset: 0x00151C9C
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
		IFurnitureHandBookItemData itemData = this.ItemData;
		if (itemData != null && itemData.RedDotVisible)
		{
			this.ItemData.RedDotVisible = false;
			FurnitureController instance = FurnitureController.Instance;
			IFurnitureHandBookItemData itemData2 = this.ItemData;
			instance.SetFurnitureHandBookItemRedDotAsRead((itemData2 != null) ? itemData2.FurnitureConfig.Id : 0);
			base.SetRedDotVisible(new bool?(false));
		}
	}

	// Token: 0x06003BD6 RID: 15318 RVA: 0x00153B01 File Offset: 0x00151D01
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06003BD7 RID: 15319 RVA: 0x00153B0C File Offset: 0x00151D0C
	public object GetKey()
	{
		IFurnitureHandBookItemData itemData = this.ItemData;
		return (itemData != null) ? new int?(itemData.FurnitureConfig.Id) : null;
	}

	// Token: 0x04003024 RID: 12324
	private IFurnitureHandBookItemData ItemData;
}
