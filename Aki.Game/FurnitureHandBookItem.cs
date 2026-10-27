using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02000FDA RID: 4058
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class FurnitureHandBookItem : LoopScrollMediumItemGrid<IFurnitureHandBookItemData>
{
	// Token: 0x0600683C RID: 26684 RVA: 0x0014B12C File Offset: 0x0014932C
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

	// Token: 0x0600683D RID: 26685 RVA: 0x0014B1D8 File Offset: 0x001493D8
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

	// Token: 0x0600683E RID: 26686 RVA: 0x0014B23D File Offset: 0x0014943D
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0600683F RID: 26687 RVA: 0x0014B248 File Offset: 0x00149448
	public object GetKey()
	{
		IFurnitureHandBookItemData itemData = this.ItemData;
		return (itemData != null) ? new int?(itemData.FurnitureConfig.Id) : null;
	}

	// Token: 0x04002F8B RID: 12171
	private IFurnitureHandBookItemData ItemData;
}
