using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;

// Token: 0x020027F8 RID: 10232
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevDetailSubItemList : LoopScrollSmallItemGrid<IMaterialItemData>
{
	// Token: 0x0601500A RID: 86026 RVA: 0x00551D93 File Offset: 0x0054FF93
	protected override void OnStart()
	{
	}

	// Token: 0x0601500B RID: 86027 RVA: 0x00551D95 File Offset: 0x0054FF95
	protected override void OnRefresh(IMaterialItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.SetSelected(isSelected, false);
		this.RefreshMaterialItem(data);
	}

	// Token: 0x0601500C RID: 86028 RVA: 0x00551DAD File Offset: 0x0054FFAD
	public override void Refresh(IMaterialItemData data, bool isSelected, int gridIndex)
	{
		this.OnRefresh(data, false, 0);
	}

	// Token: 0x0601500D RID: 86029 RVA: 0x00551DB8 File Offset: 0x0054FFB8
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x0601500E RID: 86030 RVA: 0x00551DC2 File Offset: 0x0054FFC2
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0601500F RID: 86031 RVA: 0x00551DCC File Offset: 0x0054FFCC
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

	// Token: 0x06015010 RID: 86032 RVA: 0x00551F09 File Offset: 0x00550109
	public static IMaterialItemData CreateMaterialData(int itemId, int requiredCount)
	{
		return new MaterialItemData
		{
			ItemId = itemId,
			RequiredCount = requiredCount
		};
	}

	// Token: 0x06015011 RID: 86033 RVA: 0x00551F20 File Offset: 0x00550120
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
		ItemController.Instance.OpenItemTipsByItemId(currentData.ItemId, true, null);
	}

	// Token: 0x06015012 RID: 86034 RVA: 0x00551F99 File Offset: 0x00550199
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x04009DF7 RID: 40439
	[Nullable(2)]
	private IMaterialItemData CurrentData;
}
