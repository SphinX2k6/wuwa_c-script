using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;

// Token: 0x02001D73 RID: 7539
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevDetailSubItemList : LoopScrollSmallItemGrid<IMaterialItemData>
{
	// Token: 0x06012A0A RID: 76298 RVA: 0x0057CB03 File Offset: 0x0057AD03
	protected override void OnStart()
	{
	}

	// Token: 0x06012A0B RID: 76299 RVA: 0x0057CB05 File Offset: 0x0057AD05
	protected override void OnRefresh(IMaterialItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.SetSelected(isSelected, false);
		this.RefreshMaterialItem(data);
	}

	// Token: 0x06012A0C RID: 76300 RVA: 0x0057CB1D File Offset: 0x0057AD1D
	public override void Refresh(IMaterialItemData data, bool isSelected, int gridIndex)
	{
		this.OnRefresh(data, false, 0);
	}

	// Token: 0x06012A0D RID: 76301 RVA: 0x0057CB28 File Offset: 0x0057AD28
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06012A0E RID: 76302 RVA: 0x0057CB32 File Offset: 0x0057AD32
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06012A0F RID: 76303 RVA: 0x0057CB3C File Offset: 0x0057AD3C
	private void RefreshMaterialItem(IMaterialItemData data)
	{
		base.SetSelectVisible(false);
		base.SetExtendToggleEnable(false, false);
		RoleDevCulProjectConfig? roleDevStaticConfig = RoleDevConfig.Instance.GetRoleDevStaticConfig();
		int itemId = data.ItemId;
		int? num = (roleDevStaticConfig != null) ? new int?(roleDevStaticConfig.GetValueOrDefault().UnknownItemId) : null;
		if (itemId == num.GetValueOrDefault() & num != null)
		{
			base.SetIconByPath(((roleDevStaticConfig != null) ? roleDevStaticConfig.GetValueOrDefault().UnknownItemIcon : null) ?? "");
			base.SetToggleInteractive(false);
			base.SetBottomTextVisible(false);
			base.SetQuality(null);
			return;
		}
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(data.ItemId, 0);
		string bottomText = StringUtils.Format((itemCountByConfigId >= data.RequiredCount) ? "<color=#f7eba6>{0}</color>/{1}" : "<color=#f55e66>{0}</color>/{1}", new string[]
		{
			itemCountByConfigId.ToString(),
			data.RequiredCount.ToString()
		});
		PropSmallItemGrid parameters = new PropSmallItemGrid
		{
			ItemConfigId = new int?(data.ItemId),
			BottomText = bottomText,
			Data = data
		};
		base.Apply<PropSmallItemGrid>(parameters);
		base.SetToggleInteractive(true);
	}

	// Token: 0x06012A10 RID: 76304 RVA: 0x0057CC79 File Offset: 0x0057AE79
	public static IMaterialItemData CreateMaterialData(int itemId, int requiredCount)
	{
		return new MaterialItemData
		{
			ItemId = itemId,
			RequiredCount = requiredCount
		};
	}

	// Token: 0x06012A11 RID: 76305 RVA: 0x0057CC90 File Offset: 0x0057AE90
	protected override void OnExtendToggleClicked()
	{
		IMaterialItemData currentData = this.CurrentData;
		if (currentData == null)
		{
			return;
		}
		int itemId = currentData.ItemId;
		RoleDevCulProjectConfig? roleDevCulProjectConfig;
		int? num = (RoleDevConfig.Instance.GetRoleDevStaticConfig() != null) ? new int?(roleDevCulProjectConfig.GetValueOrDefault().UnknownItemId) : null;
		if (itemId == num.GetValueOrDefault() & num != null)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(currentData.ItemId, true, null, false);
	}

	// Token: 0x06012A12 RID: 76306 RVA: 0x0057CD0A File Offset: 0x0057AF0A
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x0400A1E0 RID: 41440
	[Nullable(2)]
	private IMaterialItemData CurrentData;
}
