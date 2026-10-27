using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002817 RID: 10263
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevRoleData : RoleDevRoleViewItemDataBase
{
	// Token: 0x06015159 RID: 86361 RVA: 0x005569A0 File Offset: 0x00554BA0
	protected override void InitByRoleType(int roleId)
	{
		this.RoleDataInternal = RoleModel.Instance.GetRoleDataById(roleId, true);
		RoleDataBase roleDataInternal = this.RoleDataInternal;
		this.LevelDataInternal = ((roleDataInternal != null) ? roleDataInternal.GetLevelData() : null);
		this.InitDetailItemData();
	}

	// Token: 0x0601515A RID: 86362 RVA: 0x005569D2 File Offset: 0x00554BD2
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByRoleId(base.RoleId);
	}

	// Token: 0x0601515B RID: 86363 RVA: 0x005569E5 File Offset: 0x00554BE5
	protected override int GetRoleLevel()
	{
		RoleLevelData levelDataInternal = this.LevelDataInternal;
		if (levelDataInternal == null)
		{
			return 1;
		}
		return levelDataInternal.GetLevel();
	}

	// Token: 0x0601515C RID: 86364 RVA: 0x005569F8 File Offset: 0x00554BF8
	protected override int GetRoleBreachLevel()
	{
		RoleLevelData levelDataInternal = this.LevelDataInternal;
		if (levelDataInternal == null)
		{
			return 0;
		}
		return levelDataInternal.GetBreachLevel();
	}

	// Token: 0x0601515D RID: 86365 RVA: 0x00556A0C File Offset: 0x00554C0C
	protected override int GetRoleGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.RoleLevel;
	}

	// Token: 0x0601515E RID: 86366 RVA: 0x00556A40 File Offset: 0x00554C40
	protected override int GetRoleGoalBreakLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.RoleBreachLevel;
	}

	// Token: 0x0601515F RID: 86367 RVA: 0x00556A73 File Offset: 0x00554C73
	protected override int GetMaxLevel()
	{
		RoleLevelData levelDataInternal = this.LevelDataInternal;
		if (levelDataInternal == null)
		{
			return 90;
		}
		return levelDataInternal.GetRoleMaxLevel();
	}

	// Token: 0x06015160 RID: 86368 RVA: 0x00556A87 File Offset: 0x00554C87
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x06015161 RID: 86369 RVA: 0x00556A94 File Offset: 0x00554C94
	protected override string GetRoleName()
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(base.RoleId);
		if (roleConfig == null)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(roleConfig.Value.Name, null) ?? "";
	}

	// Token: 0x06015162 RID: 86370 RVA: 0x00556ADF File Offset: 0x00554CDF
	protected override bool GetIsCanUpgrade()
	{
		RoleLevelData levelDataInternal = this.LevelDataInternal;
		return levelDataInternal == null || !levelDataInternal.GetRoleNeedBreakUp();
	}

	// Token: 0x06015163 RID: 86371 RVA: 0x00556AF5 File Offset: 0x00554CF5
	protected override bool GetIsCanBreach()
	{
		if (!base.RoleLevelIsMax)
		{
			RoleLevelData levelDataInternal = this.LevelDataInternal;
			return levelDataInternal != null && levelDataInternal.GetRoleNeedBreakUp();
		}
		return false;
	}

	// Token: 0x06015164 RID: 86372 RVA: 0x00556B12 File Offset: 0x00554D12
	protected override bool GetIsCall()
	{
		return RoleDevUtils.IsHotRole(base.RoleId) && RoleDevUtils.GetRoleGachaIds(base.RoleId).Length != 0;
	}

	// Token: 0x06015165 RID: 86373 RVA: 0x00556B34 File Offset: 0x00554D34
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

	// Token: 0x06015166 RID: 86374 RVA: 0x00556B65 File Offset: 0x00554D65
	protected override bool GetIsForecast()
	{
		return false;
	}

	// Token: 0x17001BDA RID: 7130
	// (get) Token: 0x06015167 RID: 86375 RVA: 0x00556B68 File Offset: 0x00554D68
	public ObtainedRoleDevRoleDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x04009E38 RID: 40504
	[Nullable(2)]
	private RoleDataBase RoleDataInternal;

	// Token: 0x04009E39 RID: 40505
	[Nullable(2)]
	private RoleLevelData LevelDataInternal;

	// Token: 0x04009E3A RID: 40506
	private readonly ObtainedRoleDevRoleDetailItemData DetailItemDataInternal = new ObtainedRoleDevRoleDetailItemData();
}
