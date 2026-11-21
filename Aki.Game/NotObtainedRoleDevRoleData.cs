using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D90 RID: 7568
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevRoleData : RoleDevRoleViewItemDataBase
{
	// Token: 0x06012B37 RID: 76599 RVA: 0x00581141 File Offset: 0x0057F341
	protected override void InitByRoleType(int roleId)
	{
		this.InitDetailItemData();
	}

	// Token: 0x06012B38 RID: 76600 RVA: 0x00581149 File Offset: 0x0057F349
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByRoleId(base.RoleId);
	}

	// Token: 0x06012B39 RID: 76601 RVA: 0x0058115C File Offset: 0x0057F35C
	protected override int GetRoleLevel()
	{
		return 1;
	}

	// Token: 0x06012B3A RID: 76602 RVA: 0x0058115F File Offset: 0x0057F35F
	protected override int GetRoleBreachLevel()
	{
		return 0;
	}

	// Token: 0x06012B3B RID: 76603 RVA: 0x00581164 File Offset: 0x0057F364
	protected override int GetRoleGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.RoleLevel;
	}

	// Token: 0x06012B3C RID: 76604 RVA: 0x00581198 File Offset: 0x0057F398
	protected override int GetRoleGoalBreakLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.RoleBreachLevel;
	}

	// Token: 0x06012B3D RID: 76605 RVA: 0x005811CB File Offset: 0x0057F3CB
	protected override int GetMaxLevel()
	{
		return 0;
	}

	// Token: 0x06012B3E RID: 76606 RVA: 0x005811CE File Offset: 0x0057F3CE
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x06012B3F RID: 76607 RVA: 0x005811DC File Offset: 0x0057F3DC
	protected override string GetRoleName()
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(base.RoleId);
		if (roleConfig == null)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(roleConfig.Value.Name, null) ?? "";
	}

	// Token: 0x06012B40 RID: 76608 RVA: 0x00581227 File Offset: 0x0057F427
	protected override bool GetIsCanUpgrade()
	{
		return true;
	}

	// Token: 0x06012B41 RID: 76609 RVA: 0x0058122A File Offset: 0x0057F42A
	protected override bool GetIsCanBreach()
	{
		return true;
	}

	// Token: 0x06012B42 RID: 76610 RVA: 0x0058122D File Offset: 0x0057F42D
	protected override bool GetIsCall()
	{
		return RoleDevUtils.IsHotRole(base.RoleId) && RoleDevUtils.GetRoleGachaIds(base.RoleId).Length != 0;
	}

	// Token: 0x06012B43 RID: 76611 RVA: 0x00581250 File Offset: 0x0057F450
	protected override int GetGachaId()
	{
		if (!RoleDevUtils.IsHotRole(base.RoleId))
		{
			return 0;
		}
		int[] roleGachaIds = RoleDevUtils.GetRoleGachaIds(base.RoleId);
		if (roleGachaIds.Length == 0)
		{
			return 0;
		}
		return roleGachaIds[0];
	}

	// Token: 0x06012B44 RID: 76612 RVA: 0x00581281 File Offset: 0x0057F481
	protected override bool GetIsForecast()
	{
		return false;
	}

	// Token: 0x17001C30 RID: 7216
	// (get) Token: 0x06012B45 RID: 76613 RVA: 0x00581284 File Offset: 0x0057F484
	public NotObtainedRoleDevRoleDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x0400A21F RID: 41503
	private readonly NotObtainedRoleDevRoleDetailItemData DetailItemDataInternal = new NotObtainedRoleDevRoleDetailItemData();
}
