using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

// Token: 0x02001D8E RID: 7566
[NullableContext(1)]
[Nullable(0)]
public class ForecastRoleDevRoleData : RoleDevRoleViewItemDataBase
{
	// Token: 0x06012B15 RID: 76565 RVA: 0x00580AF9 File Offset: 0x0057ECF9
	protected override void InitByRoleType(int roleId)
	{
		this.InitDetailItemData();
	}

	// Token: 0x06012B16 RID: 76566 RVA: 0x00580B01 File Offset: 0x0057ED01
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByRoleId(base.RoleId);
	}

	// Token: 0x06012B17 RID: 76567 RVA: 0x00580B14 File Offset: 0x0057ED14
	protected override int GetRoleLevel()
	{
		return 1;
	}

	// Token: 0x06012B18 RID: 76568 RVA: 0x00580B17 File Offset: 0x0057ED17
	protected override int GetRoleBreachLevel()
	{
		return 0;
	}

	// Token: 0x06012B19 RID: 76569 RVA: 0x00580B1C File Offset: 0x0057ED1C
	protected override int GetRoleGoalUpgradeLevel()
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(base.RoleId);
		if (roleDevProsProjectConfig == null)
		{
			return 0;
		}
		return roleDevProsProjectConfig.RoleGoalLevel;
	}

	// Token: 0x06012B1A RID: 76570 RVA: 0x00580B45 File Offset: 0x0057ED45
	protected override int GetRoleGoalBreakLevel()
	{
		return 0;
	}

	// Token: 0x06012B1B RID: 76571 RVA: 0x00580B48 File Offset: 0x0057ED48
	protected override int GetMaxLevel()
	{
		return 0;
	}

	// Token: 0x06012B1C RID: 76572 RVA: 0x00580B4B File Offset: 0x0057ED4B
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x06012B1D RID: 76573 RVA: 0x00580B58 File Offset: 0x0057ED58
	protected override string GetRoleName()
	{
		IRoleDevProsProjectConfig roleDevProsProjectConfig = RoleDevConfig.Instance.GetRoleDevProsProjectConfig(base.RoleId);
		if (roleDevProsProjectConfig == null)
		{
			return "";
		}
		return roleDevProsProjectConfig.RoleName;
	}

	// Token: 0x06012B1E RID: 76574 RVA: 0x00580B85 File Offset: 0x0057ED85
	protected override bool GetIsCanUpgrade()
	{
		return false;
	}

	// Token: 0x06012B1F RID: 76575 RVA: 0x00580B88 File Offset: 0x0057ED88
	protected override bool GetIsCanBreach()
	{
		return false;
	}

	// Token: 0x06012B20 RID: 76576 RVA: 0x00580B8B File Offset: 0x0057ED8B
	protected override bool GetIsCall()
	{
		return RoleDevUtils.IsHotRole(base.RoleId) && RoleDevUtils.GetRoleGachaIds(base.RoleId).Length != 0;
	}

	// Token: 0x06012B21 RID: 76577 RVA: 0x00580BAC File Offset: 0x0057EDAC
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

	// Token: 0x06012B22 RID: 76578 RVA: 0x00580BDD File Offset: 0x0057EDDD
	protected override bool GetIsForecast()
	{
		return true;
	}

	// Token: 0x17001C2E RID: 7214
	// (get) Token: 0x06012B23 RID: 76579 RVA: 0x00580BE0 File Offset: 0x0057EDE0
	public ForecastRoleDevRoleDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x0400A21D RID: 41501
	private readonly ForecastRoleDevRoleDetailItemData DetailItemDataInternal = new ForecastRoleDevRoleDetailItemData();
}
