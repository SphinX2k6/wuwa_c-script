using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001F30 RID: 7984
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerMediumItem : LoopScrollMediumItemGrid<ShipTowerMediumItemData>
{
	// Token: 0x06013C3F RID: 80959 RVA: 0x005C459A File Offset: 0x005C279A
	protected override void OnStart()
	{
		base.SetToggleInteractive(false);
	}

	// Token: 0x06013C40 RID: 80960 RVA: 0x005C45A3 File Offset: 0x005C27A3
	protected override void OnRefresh(ShipTowerMediumItemData data, bool isSelected, int gridIndex)
	{
		Action<ShipTowerMediumItemData> refreshCallBack = this.RefreshCallBack;
		if (refreshCallBack == null)
		{
			return;
		}
		refreshCallBack(data);
	}

	// Token: 0x06013C41 RID: 80961 RVA: 0x005C45B6 File Offset: 0x005C27B6
	private bool IsRoleItem(ShipTowerMediumItemData data)
	{
		return !data.IsBuff.GetValueOrDefault();
	}

	// Token: 0x06013C42 RID: 80962 RVA: 0x005C45C6 File Offset: 0x005C27C6
	public void RefreshRecommend(ShipTowerMediumItemData data)
	{
		if (this.IsRoleItem(data))
		{
			this.RefreshRecommendRole(data);
			return;
		}
		this.RefreshRecommendBuff(data);
	}

	// Token: 0x06013C43 RID: 80963 RVA: 0x005C45E0 File Offset: 0x005C27E0
	public void RefreshRecommendRole(ShipTowerMediumItemData data)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(data.Id);
		RoleInfo value = ((roleInstanceById != null) ? new RoleInfo?(roleInstanceById.GetRoleConfig()) : RoleConfig.Instance.GetRoleConfig(data.Id)).Value;
		bool flag = roleInstanceById != null;
		int roleBranchIndexById = RoleModel.Instance.GetRoleBranchIndexById(data.Id, data.SkillBranchId);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(data.Id),
			SkinId = value.SkinId,
			BottomTextId = value.Name,
			IsDisable = new bool?(!flag),
			ElementId = new int?(value.ElementId),
			SkillBranchIndex = ((roleBranchIndexById >= 0) ? new int?(roleBranchIndexById) : null)
		};
		base.Apply<CharacterMediumItemGrid>(parameters);
	}

	// Token: 0x06013C44 RID: 80964 RVA: 0x005C46BC File Offset: 0x005C28BC
	public void RefreshRecommendBuff(ShipTowerMediumItemData data)
	{
		ShipTowerModel instance = ShipTowerModel.Instance;
		ShipTowerBuffData shipTowerBuffData = (instance != null) ? instance.GetBuffDataByBuffId(data.Id) : null;
		ShipTowerConfig instance2 = ShipTowerConfig.Instance;
		SlashBuffToItem? slashBuffToItem = (instance2 != null) ? instance2.GetBuffCfgById(data.Id) : null;
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig((slashBuffToItem != null) ? slashBuffToItem.GetValueOrDefault().ItemId : 1);
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(itemConfig.Value.Id),
			BottomTextId = itemConfig.Value.Name,
			IsDisable = new bool?(shipTowerBuffData == null || !shipTowerBuffData.IsCanUse(this.GetStageIdCallback()))
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x06013C45 RID: 80965 RVA: 0x005C4793 File Offset: 0x005C2993
	public void RefreshRecord(ShipTowerMediumItemData data)
	{
		if (this.IsRoleItem(data))
		{
			this.RefreshRecordRole(data);
			return;
		}
		this.RefreshRecordBuff(data);
	}

	// Token: 0x06013C46 RID: 80966 RVA: 0x005C47B0 File Offset: 0x005C29B0
	public void RefreshRecordRole(ShipTowerMediumItemData data)
	{
		RoleInfo value = RoleConfig.Instance.GetRoleConfig(data.Id).Value;
		int roleBranchIndexById = RoleModel.Instance.GetRoleBranchIndexById(data.Id, data.SkillBranchId);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(data.Id),
			SkinId = value.SkinId,
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				data.Count
			},
			ElementId = new int?(value.ElementId),
			SkillBranchIndex = ((roleBranchIndexById >= 0) ? new int?(roleBranchIndexById) : null)
		};
		base.Apply<CharacterMediumItemGrid>(parameters);
	}

	// Token: 0x06013C47 RID: 80967 RVA: 0x005C4878 File Offset: 0x005C2A78
	public void RefreshRecordBuff(ShipTowerMediumItemData data)
	{
		ShipTowerConfig instance = ShipTowerConfig.Instance;
		SlashBuffToItem? slashBuffToItem = (instance != null) ? instance.GetBuffCfgById(data.Id) : null;
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig((slashBuffToItem != null) ? slashBuffToItem.GetValueOrDefault().ItemId : 1);
		PropMediumItemGrid parameters = new PropMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(itemConfig.Value.Id),
			BottomTextId = itemConfig.Value.Name
		};
		base.Apply<PropMediumItemGrid>(parameters);
	}

	// Token: 0x06013C48 RID: 80968 RVA: 0x005C4911 File Offset: 0x005C2B11
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06013C49 RID: 80969 RVA: 0x005C491B File Offset: 0x005C2B1B
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06013C4A RID: 80970 RVA: 0x005C4925 File Offset: 0x005C2B25
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0400A8DA RID: 43226
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerMediumItemData> RefreshCallBack;

	// Token: 0x0400A8DB RID: 43227
	[Nullable(2)]
	public Func<int?> GetStageIdCallback;
}
