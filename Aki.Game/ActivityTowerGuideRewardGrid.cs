using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x0200152D RID: 5421
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityTowerGuideRewardGrid : LoopScrollSmallItemGrid<ITowerGuideRewardItem>
{
	// Token: 0x06009A9C RID: 39580 RVA: 0x0021726C File Offset: 0x0021546C
	protected override void OnRefresh(ITowerGuideRewardItem data, bool isSelected, int gridIndex)
	{
		this.ItemConfigId = data.Item.ItemData.ItemId;
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			Data = data,
			IsLockVisible = new bool?(data.IsLock),
			BottomText = data.Item.Count.ToString(),
			ItemConfigId = new int?(data.Item.ItemData.ItemId),
			IsDisable = new bool?(data.IsLock),
			IsReceivableVisible = new bool?(data.IsReceivableVisible)
		};
		base.Apply<PropSmallItemGrid>(parameters);
		base.SetDisableComponentColor("365988", data.IsLock);
		this.SetSelected(false, false);
	}

	// Token: 0x06009A9D RID: 39581 RVA: 0x00217323 File Offset: 0x00215523
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06009A9E RID: 39582 RVA: 0x0021732D File Offset: 0x0021552D
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06009A9F RID: 39583 RVA: 0x00217337 File Offset: 0x00215537
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06009AA0 RID: 39584 RVA: 0x0021733A File Offset: 0x0021553A
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ItemConfigId, true, null);
	}

	// Token: 0x0400440A RID: 17418
	private int ItemConfigId;
}
