using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001692 RID: 5778
[NullableContext(2)]
[Nullable(0)]
public class AdventureTargetRewardItem : LoopScrollMediumItemGrid<TItem>
{
	// Token: 0x0600A4D8 RID: 42200 RVA: 0x0024BAEE File Offset: 0x00249CEE
	protected override void OnStart()
	{
		base.SetUseFixedAsync(true);
	}

	// Token: 0x0600A4D9 RID: 42201 RVA: 0x0024BAF8 File Offset: 0x00249CF8
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

	// Token: 0x0600A4DA RID: 42202 RVA: 0x0024BB89 File Offset: 0x00249D89
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x0600A4DB RID: 42203 RVA: 0x0024BB93 File Offset: 0x00249D93
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x0600A4DC RID: 42204 RVA: 0x0024BB9D File Offset: 0x00249D9D
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x04004A93 RID: 19091
	public Func<int, int> GetRolePositionFunc;

	// Token: 0x04004A94 RID: 19092
	public Func<int, bool> IsHighlightIndex;
}
