using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000B4A RID: 2890
[NullableContext(2)]
[Nullable(0)]
public class AdventureTargetRewardItem : LoopScrollMediumItemGrid<TItem>
{
	// Token: 0x060078B8 RID: 30904 RVA: 0x00255E5B File Offset: 0x0025405B
	protected override void OnStart()
	{
		base.SetUseFixedAsync(true);
	}

	// Token: 0x060078B9 RID: 30905 RVA: 0x00255E64 File Offset: 0x00254064
	protected override void OnRefresh(TItem data, bool isSelected, int gridIndex)
	{
		this.SetSelected(isSelected, false);
		int itemId = data.ItemData.ItemId;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			return;
		}
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			IsOmitBottomText = new bool?(true),
			BottomText = data.Count.ToString(),
			ItemConfigId = new int?(itemId),
			StarLevel = new int?(itemConfigData.QualityId),
			IsReceivedFlagVisible = new bool?(false)
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x060078BA RID: 30906 RVA: 0x00255EF5 File Offset: 0x002540F5
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x060078BB RID: 30907 RVA: 0x00255EFF File Offset: 0x002540FF
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x060078BC RID: 30908 RVA: 0x00255F09 File Offset: 0x00254109
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x04004B3A RID: 19258
	public Func<int, int> GetRolePositionFunc;

	// Token: 0x04004B3B RID: 19259
	public Func<int, bool> IsHighlightIndex;
}
