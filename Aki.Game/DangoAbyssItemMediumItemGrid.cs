using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001A42 RID: 6722
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssItemMediumItemGrid : LoopScrollMediumItemGrid<AbyssPluginItemInfo>
{
	// Token: 0x0600C5BB RID: 50619 RVA: 0x002CE8A4 File Offset: 0x002CCAA4
	protected override void OnRefresh(AbyssPluginItemInfo itemData, bool isSelected, int gridIndex)
	{
		AbyssQuality? abyssQualityByPluginItemId = DangoAbyssConfig.Instance.GetAbyssQualityByPluginItemId(itemData.GetConfigId());
		if (itemData == null || abyssQualityByPluginItemId == null)
		{
			return;
		}
		TItemConfig config = itemData.GetConfig();
		DangoRoleHeadInfo dangoRoleHeadInfo = new DangoRoleHeadInfo
		{
			DangoConfigId = new int?(itemData.GetRoleId())
		};
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = itemData,
			ItemConfigId = new int?(itemData.GetConfigId()),
			BottomTextId = config.As<AbyssItem>().Value.Name,
			IsLockVisible = new bool?(itemData.GetIsLock()),
			DangoRoleHeadInfo = dangoRoleHeadInfo
		};
		base.SetReduceButton(null);
		base.Apply<PropMediumItemGrid>(parameters);
		this.SetSelected(isSelected, false);
	}

	// Token: 0x0600C5BC RID: 50620 RVA: 0x002CE957 File Offset: 0x002CCB57
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x0600C5BD RID: 50621 RVA: 0x002CE961 File Offset: 0x002CCB61
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}
}
