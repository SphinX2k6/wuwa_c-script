using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;

// Token: 0x02001CDC RID: 7388
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerMonsterSelectGridItem : LoopScrollSmallItemGrid<RoleTowerMonsterInfoData>
{
	// Token: 0x0601249A RID: 74906 RVA: 0x00564B18 File Offset: 0x00562D18
	protected override void OnRefresh(RoleTowerMonsterInfoData data, bool isSelected, int gridIndex)
	{
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(data.TokenId);
		this.TipsItemId = ((tokenCfg != null) ? tokenCfg.Value.ItemId : 0);
		PropSmallItemGrid propSmallItemGrid = new PropSmallItemGrid();
		propSmallItemGrid.ItemConfigId = new int?(this.TipsItemId);
		propSmallItemGrid.Data = data;
		string bottomText;
		if (data.TokenCount <= 0)
		{
			bottomText = "";
		}
		else
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.TokenCount);
			bottomText = defaultInterpolatedStringHandler.ToStringAndClear();
		}
		propSmallItemGrid.BottomText = bottomText;
		base.Apply<PropSmallItemGrid>(propSmallItemGrid);
	}

	// Token: 0x0601249B RID: 74907 RVA: 0x00564BAD File Offset: 0x00562DAD
	protected override void OnExtendToggleClicked()
	{
		if (this.TipsItemId > 0)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.TipsItemId, true, null, false);
		}
	}

	// Token: 0x0601249C RID: 74908 RVA: 0x00564BCB File Offset: 0x00562DCB
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0601249D RID: 74909 RVA: 0x00564BCE File Offset: 0x00562DCE
	public override object GetKey(RoleTowerMonsterInfoData data, int displayIndex)
	{
		return displayIndex;
	}

	// Token: 0x04009FA0 RID: 40864
	private int TipsItemId;
}
