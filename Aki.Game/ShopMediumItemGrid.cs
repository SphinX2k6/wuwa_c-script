using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020029FA RID: 10746
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShopMediumItemGrid : LoopScrollMediumItemGrid<ShopItemFullInfo>
{
	// Token: 0x060164AE RID: 91310 RVA: 0x005A4490 File Offset: 0x005A2690
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

	// Token: 0x060164AF RID: 91311 RVA: 0x005A452A File Offset: 0x005A272A
	public override void OnSelected(bool fireEvent)
	{
		ShopModel.Instance.OpenItemInfo = this.ItemInfo;
		EventSystem.Instance.Emit(EEventName.OpenItemInfo);
		this.SetSelected(true, false);
	}

	// Token: 0x060164B0 RID: 91312 RVA: 0x005A4554 File Offset: 0x005A2754
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0400A5DD RID: 42461
	[Nullable(2)]
	public ShopItemFullInfo ItemInfo;
}
