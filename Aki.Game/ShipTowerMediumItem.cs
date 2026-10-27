using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020029B5 RID: 10677
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerMediumItem : LoopScrollMediumItemGrid<ShipTowerMediumItemData>
{
	// Token: 0x06016239 RID: 90681 RVA: 0x0059960E File Offset: 0x0059780E
	protected override void OnStart()
	{
		base.SetToggleInteractive(false);
	}

	// Token: 0x0601623A RID: 90682 RVA: 0x00599617 File Offset: 0x00597817
	protected override void OnRefresh(ShipTowerMediumItemData data, bool isSelected, int gridIndex)
	{
		Action<ShipTowerMediumItemData> refreshCallBack = this.RefreshCallBack;
		if (refreshCallBack == null)
		{
			return;
		}
		refreshCallBack(data);
	}

	// Token: 0x0601623B RID: 90683 RVA: 0x0059962A File Offset: 0x0059782A
	private bool IsRoleItem(ShipTowerMediumItemData data)
	{
		return !data.IsBuff.GetValueOrDefault();
	}

	// Token: 0x0601623C RID: 90684 RVA: 0x0059963A File Offset: 0x0059783A
	public void RefreshRecommend(ShipTowerMediumItemData data)
	{
		if (this.IsRoleItem(data))
		{
			this.RefreshRecommendRole(data);
			return;
		}
		this.RefreshRecommendBuff(data);
	}

	// Token: 0x0601623D RID: 90685 RVA: 0x00599654 File Offset: 0x00597854
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

	// Token: 0x0601623E RID: 90686 RVA: 0x00599730 File Offset: 0x00597930
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

	// Token: 0x0601623F RID: 90687 RVA: 0x00599807 File Offset: 0x00597A07
	public void RefreshRecord(ShipTowerMediumItemData data)
	{
		if (this.IsRoleItem(data))
		{
			this.RefreshRecordRole(data);
			return;
		}
		this.RefreshRecordBuff(data);
	}

	// Token: 0x06016240 RID: 90688 RVA: 0x00599824 File Offset: 0x00597A24
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

	// Token: 0x06016241 RID: 90689 RVA: 0x005998EC File Offset: 0x00597AEC
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

	// Token: 0x06016242 RID: 90690 RVA: 0x00599985 File Offset: 0x00597B85
	public void OnForceSelected()
	{
		this.SetSelected(true, true);
	}

	// Token: 0x06016243 RID: 90691 RVA: 0x0059998F File Offset: 0x00597B8F
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06016244 RID: 90692 RVA: 0x00599999 File Offset: 0x00597B99
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, false);
	}

	// Token: 0x0400A4F0 RID: 42224
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerMediumItemData> RefreshCallBack;

	// Token: 0x0400A4F1 RID: 42225
	[Nullable(2)]
	public Func<int?> GetStageIdCallback;
}
