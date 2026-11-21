using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x020009E5 RID: 2533
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ActivityTowerGuideRewardGrid : LoopScrollSmallItemGrid<ITowerGuideRewardItem>
{
	// Token: 0x06006E7A RID: 28282 RVA: 0x00221008 File Offset: 0x0021F208
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

	// Token: 0x06006E7B RID: 28283 RVA: 0x002210BF File Offset: 0x0021F2BF
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06006E7C RID: 28284 RVA: 0x002210C9 File Offset: 0x0021F2C9
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x06006E7D RID: 28285 RVA: 0x002210D3 File Offset: 0x0021F2D3
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x06006E7E RID: 28286 RVA: 0x002210D6 File Offset: 0x0021F2D6
	protected override void OnExtendToggleClicked()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.ItemConfigId, true, null, false);
	}

	// Token: 0x040044B0 RID: 17584
	private int ItemConfigId;
}
