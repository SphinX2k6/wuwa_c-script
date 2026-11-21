using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Item;

// Token: 0x02001CE6 RID: 7398
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerRewardPreviewItem : LoopScrollSmallItemGrid<RoleTowerRewardPreviewData>
{
	// Token: 0x0601250A RID: 75018 RVA: 0x005671DC File Offset: 0x005653DC
	protected override void OnRefresh(RoleTowerRewardPreviewData data, bool isSelected, int gridIndex)
	{
		this.TipsItemId = data.ItemId;
		base.Apply<PropSmallItemGrid>(new PropSmallItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.ItemId),
			BottomText = data.Count.ToString()
		});
	}

	// Token: 0x0601250B RID: 75019 RVA: 0x00567229 File Offset: 0x00565429
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0601250C RID: 75020 RVA: 0x0056722C File Offset: 0x0056542C
	protected override void OnExtendToggleClicked()
	{
		if (this.TipsItemId > 0)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.TipsItemId, true, null, false);
		}
	}

	// Token: 0x04009FBA RID: 40890
	private int TipsItemId;
}
