using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02002813 RID: 10259
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevRoleData : RoleDevRoleViewItemDataBase
{
	// Token: 0x06015115 RID: 86293 RVA: 0x00555CF9 File Offset: 0x00553EF9
	protected override void InitByRoleType(int roleId)
	{
		this.InitDetailItemData();
	}

	// Token: 0x06015116 RID: 86294 RVA: 0x00555D01 File Offset: 0x00553F01
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByRoleId(base.RoleId);
	}

	// Token: 0x06015117 RID: 86295 RVA: 0x00555D14 File Offset: 0x00553F14
	protected override int GetRoleLevel()
	{
		return 1;
	}

	// Token: 0x06015118 RID: 86296 RVA: 0x00555D17 File Offset: 0x00553F17
	protected override int GetRoleBreachLevel()
	{
		return 0;
	}

	// Token: 0x06015119 RID: 86297 RVA: 0x00555D1C File Offset: 0x00553F1C
	protected override int GetRoleGoalUpgradeLevel()
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(base.RoleId);
		if (roleDevProsProjectConfig == null)
		{
			return 0;
		}
		return roleDevProsProjectConfig.RoleGoalLevel;
	}

	// Token: 0x0601511A RID: 86298 RVA: 0x00555D45 File Offset: 0x00553F45
	protected override int GetRoleGoalBreakLevel()
	{
		return 0;
	}

	// Token: 0x0601511B RID: 86299 RVA: 0x00555D48 File Offset: 0x00553F48
	protected override int GetMaxLevel()
	{
		return 0;
	}

	// Token: 0x0601511C RID: 86300 RVA: 0x00555D4B File Offset: 0x00553F4B
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x0601511D RID: 86301 RVA: 0x00555D58 File Offset: 0x00553F58
	protected override string GetRoleName()
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(base.RoleId);
		if (roleDevProsProjectConfig == null)
		{
			return "";
		}
		return roleDevProsProjectConfig.RoleName;
	}

	// Token: 0x0601511E RID: 86302 RVA: 0x00555D85 File Offset: 0x00553F85
	protected override bool GetIsCanUpgrade()
	{
		return false;
	}

	// Token: 0x0601511F RID: 86303 RVA: 0x00555D88 File Offset: 0x00553F88
	protected override bool GetIsCanBreach()
	{
		return false;
	}

	// Token: 0x06015120 RID: 86304 RVA: 0x00555D8B File Offset: 0x00553F8B
	protected override bool GetIsCall()
	{
		return RoleDevUtils.IsHotRole(base.RoleId) && RoleDevUtils.GetRoleGachaIds(base.RoleId).Length != 0;
	}

	// Token: 0x06015121 RID: 86305 RVA: 0x00555DAC File Offset: 0x00553FAC
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

	// Token: 0x06015122 RID: 86306 RVA: 0x00555DDD File Offset: 0x00553FDD
	protected override bool GetIsForecast()
	{
		return true;
	}

	// Token: 0x17001BD6 RID: 7126
	// (get) Token: 0x06015123 RID: 86307 RVA: 0x00555DE0 File Offset: 0x00553FE0
	public ForecastRoleDevRoleDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x04009E34 RID: 40500
	private readonly ForecastRoleDevRoleDetailItemData DetailItemDataInternal = new ForecastRoleDevRoleDetailItemData();
}
