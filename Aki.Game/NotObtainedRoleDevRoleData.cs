using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002815 RID: 10261
[NullableContext(1)]
[Nullable(0)]
public class NotObtainedRoleDevRoleData : RoleDevRoleViewItemDataBase
{
	// Token: 0x06015137 RID: 86327 RVA: 0x00556341 File Offset: 0x00554541
	protected override void InitByRoleType(int roleId)
	{
		this.InitDetailItemData();
	}

	// Token: 0x06015138 RID: 86328 RVA: 0x00556349 File Offset: 0x00554549
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByRoleId(base.RoleId);
	}

	// Token: 0x06015139 RID: 86329 RVA: 0x0055635C File Offset: 0x0055455C
	protected override int GetRoleLevel()
	{
		return 1;
	}

	// Token: 0x0601513A RID: 86330 RVA: 0x0055635F File Offset: 0x0055455F
	protected override int GetRoleBreachLevel()
	{
		return 0;
	}

	// Token: 0x0601513B RID: 86331 RVA: 0x00556364 File Offset: 0x00554564
	protected override int GetRoleGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.RoleLevel;
	}

	// Token: 0x0601513C RID: 86332 RVA: 0x00556398 File Offset: 0x00554598
	protected override int GetRoleGoalBreakLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.RoleBreachLevel;
	}

	// Token: 0x0601513D RID: 86333 RVA: 0x005563CB File Offset: 0x005545CB
	protected override int GetMaxLevel()
	{
		return 0;
	}

	// Token: 0x0601513E RID: 86334 RVA: 0x005563CE File Offset: 0x005545CE
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x0601513F RID: 86335 RVA: 0x005563DC File Offset: 0x005545DC
	protected override string GetRoleName()
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(base.RoleId);
		if (roleConfig == null)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(roleConfig.Value.Name, null) ?? "";
	}

	// Token: 0x06015140 RID: 86336 RVA: 0x00556427 File Offset: 0x00554627
	protected override bool GetIsCanUpgrade()
	{
		return true;
	}

	// Token: 0x06015141 RID: 86337 RVA: 0x0055642A File Offset: 0x0055462A
	protected override bool GetIsCanBreach()
	{
		return true;
	}

	// Token: 0x06015142 RID: 86338 RVA: 0x0055642D File Offset: 0x0055462D
	protected override bool GetIsCall()
	{
		return RoleDevUtils.IsHotRole(base.RoleId) && RoleDevUtils.GetRoleGachaIds(base.RoleId).Length != 0;
	}

	// Token: 0x06015143 RID: 86339 RVA: 0x00556450 File Offset: 0x00554650
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

	// Token: 0x06015144 RID: 86340 RVA: 0x00556481 File Offset: 0x00554681
	protected override bool GetIsForecast()
	{
		return false;
	}

	// Token: 0x17001BD8 RID: 7128
	// (get) Token: 0x06015145 RID: 86341 RVA: 0x00556484 File Offset: 0x00554684
	public NotObtainedRoleDevRoleDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x04009E36 RID: 40502
	private readonly NotObtainedRoleDevRoleDetailItemData DetailItemDataInternal = new NotObtainedRoleDevRoleDetailItemData();
}
