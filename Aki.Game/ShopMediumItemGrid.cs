using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001F75 RID: 8053
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShopMediumItemGrid : LoopScrollMediumItemGrid<ShopItemFullInfo>
{
	// Token: 0x06013EB5 RID: 81589 RVA: 0x005CF468 File Offset: 0x005CD668
	protected override void OnRefresh(ShopItemFullInfo data, bool isSelected, int gridIndex)
	{
		if (data == null)
		{
			return;
		}
		this.SetSelected(isSelected, false);
		this.ItemInfo = data;
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.ItemId),
			IsProhibit = new bool?(data.IsLocked),
			StarLevel = new int?(data.ItemInfo.QualityId),
			BottomTextId = data.ItemInfo.Name,
			IsDisable = new bool?(data.IsSoldOut()),
			IsOmitBottomText = new bool?(true)
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x06013EB6 RID: 81590 RVA: 0x005CF502 File Offset: 0x005CD702
	public override void OnSelected(bool fireEvent)
	{
		ShopModel.Instance.OpenItemInfo = this.ItemInfo;
		EventSystem.Instance.Emit(EEventName.OpenItemInfo);
		this.SetSelected(true, false);
	}

	// Token: 0x06013EB7 RID: 81591 RVA: 0x005CF52C File Offset: 0x005CD72C
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0400A9C7 RID: 43463
	[Nullable(2)]
	public ShopItemFullInfo ItemInfo;
}
