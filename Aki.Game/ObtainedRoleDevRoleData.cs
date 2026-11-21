using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D92 RID: 7570
[NullableContext(1)]
[Nullable(0)]
public class ObtainedRoleDevRoleData : RoleDevRoleViewItemDataBase
{
	// Token: 0x06012B59 RID: 76633 RVA: 0x005817A0 File Offset: 0x0057F9A0
	protected override void InitByRoleType(int roleId)
	{
		this.RoleDataInternal = RoleModel.Instance.GetRoleDataById(roleId, true);
		RoleDataBase roleDataInternal = this.RoleDataInternal;
		this.LevelDataInternal = ((roleDataInternal != null) ? roleDataInternal.GetLevelData() : null);
		this.InitDetailItemData();
	}

	// Token: 0x06012B5A RID: 76634 RVA: 0x005817D2 File Offset: 0x0057F9D2
	private void InitDetailItemData()
	{
		this.DetailItemDataInternal.InitByRoleId(base.RoleId);
	}

	// Token: 0x06012B5B RID: 76635 RVA: 0x005817E5 File Offset: 0x0057F9E5
	protected override int GetRoleLevel()
	{
		RoleLevelData levelDataInternal = this.LevelDataInternal;
		if (levelDataInternal == null)
		{
			return 1;
		}
		return levelDataInternal.GetLevel();
	}

	// Token: 0x06012B5C RID: 76636 RVA: 0x005817F8 File Offset: 0x0057F9F8
	protected override int GetRoleBreachLevel()
	{
		RoleLevelData levelDataInternal = this.LevelDataInternal;
		if (levelDataInternal == null)
		{
			return 0;
		}
		return levelDataInternal.GetBreachLevel();
	}

	// Token: 0x06012B5D RID: 76637 RVA: 0x0058180C File Offset: 0x0057FA0C
	protected override int GetRoleGoalUpgradeLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.RoleLevel;
	}

	// Token: 0x06012B5E RID: 76638 RVA: 0x00581840 File Offset: 0x0057FA40
	protected override int GetRoleGoalBreakLevel()
	{
		RoleDevCultivateProject? cultivateProject = RoleDevUtils.GetCultivateProject(base.RoleId);
		if (cultivateProject == null)
		{
			return 0;
		}
		return cultivateProject.Value.RoleBreachLevel;
	}

	// Token: 0x06012B5F RID: 76639 RVA: 0x00581873 File Offset: 0x0057FA73
	protected override int GetMaxLevel()
	{
		RoleLevelData levelDataInternal = this.LevelDataInternal;
		if (levelDataInternal == null)
		{
			return 90;
		}
		return levelDataInternal.GetRoleMaxLevel();
	}

	// Token: 0x06012B60 RID: 76640 RVA: 0x00581887 File Offset: 0x0057FA87
	protected override List<IRoleDevDetailItemData> GetDetailItems()
	{
		return this.DetailItemDataInternal.DetailItems;
	}

	// Token: 0x06012B61 RID: 76641 RVA: 0x00581894 File Offset: 0x0057FA94
	protected override string GetRoleName()
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(base.RoleId);
		if (roleConfig == null)
		{
			return "";
		}
		return ConfigMultiTextLang.GetLocalTextNew(roleConfig.Value.Name, null) ?? "";
	}

	// Token: 0x06012B62 RID: 76642 RVA: 0x005818DF File Offset: 0x0057FADF
	protected override bool GetIsCanUpgrade()
	{
		RoleLevelData levelDataInternal = this.LevelDataInternal;
		return levelDataInternal == null || !levelDataInternal.GetRoleNeedBreakUp();
	}

	// Token: 0x06012B63 RID: 76643 RVA: 0x005818F5 File Offset: 0x0057FAF5
	protected override bool GetIsCanBreach()
	{
		if (!base.RoleLevelIsMax)
		{
			RoleLevelData levelDataInternal = this.LevelDataInternal;
			return levelDataInternal != null && levelDataInternal.GetRoleNeedBreakUp();
		}
		return false;
	}

	// Token: 0x06012B64 RID: 76644 RVA: 0x00581912 File Offset: 0x0057FB12
	protected override bool GetIsCall()
	{
		return RoleDevUtils.IsHotRole(base.RoleId) && RoleDevUtils.GetRoleGachaIds(base.RoleId).Length != 0;
	}

	// Token: 0x06012B65 RID: 76645 RVA: 0x00581934 File Offset: 0x0057FB34
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

	// Token: 0x06012B66 RID: 76646 RVA: 0x00581965 File Offset: 0x0057FB65
	protected override bool GetIsForecast()
	{
		return false;
	}

	// Token: 0x17001C32 RID: 7218
	// (get) Token: 0x06012B67 RID: 76647 RVA: 0x00581968 File Offset: 0x0057FB68
	public ObtainedRoleDevRoleDetailItemData DetailItemData
	{
		get
		{
			return this.DetailItemDataInternal;
		}
	}

	// Token: 0x0400A221 RID: 41505
	[Nullable(2)]
	private RoleDataBase RoleDataInternal;

	// Token: 0x0400A222 RID: 41506
	[Nullable(2)]
	private RoleLevelData LevelDataInternal;

	// Token: 0x0400A223 RID: 41507
	private readonly ObtainedRoleDevRoleDetailItemData DetailItemDataInternal = new ObtainedRoleDevRoleDetailItemData();
}
