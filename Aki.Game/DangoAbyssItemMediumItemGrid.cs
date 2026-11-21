using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000F01 RID: 3841
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class DangoAbyssItemMediumItemGrid : LoopScrollMediumItemGrid<AbyssPluginItemInfo>
{
	// Token: 0x060099CB RID: 39371 RVA: 0x002D99B8 File Offset: 0x002D7BB8
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

	// Token: 0x060099CC RID: 39372 RVA: 0x002D9A6B File Offset: 0x002D7C6B
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x060099CD RID: 39373 RVA: 0x002D9A75 File Offset: 0x002D7C75
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}
}
