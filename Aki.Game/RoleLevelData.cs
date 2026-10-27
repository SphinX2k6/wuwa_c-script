using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020027B2 RID: 10162
public class RoleLevelData : RoleModuleDataBase
{
	// Token: 0x06014E58 RID: 85592 RVA: 0x0054E809 File Offset: 0x0054CA09
	public RoleLevelData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06014E59 RID: 85593 RVA: 0x0054E812 File Offset: 0x0054CA12
	public void SetLevel(int level)
	{
		this.Level = level;
	}

	// Token: 0x06014E5A RID: 85594 RVA: 0x0054E81B File Offset: 0x0054CA1B
	public int GetLevel()
	{
		return this.Level;
	}

	// Token: 0x06014E5B RID: 85595 RVA: 0x0054E823 File Offset: 0x0054CA23
	public void SetExp(int exp)
	{
		this.Exp = exp;
	}

	// Token: 0x06014E5C RID: 85596 RVA: 0x0054E82C File Offset: 0x0054CA2C
	public int GetExp()
	{
		return this.Exp;
	}

	// Token: 0x06014E5D RID: 85597 RVA: 0x0054E834 File Offset: 0x0054CA34
	public void SetBreachLevel(int level)
	{
		this.BreachLevel = level;
	}

	// Token: 0x06014E5E RID: 85598 RVA: 0x0054E83D File Offset: 0x0054CA3D
	public int GetBreachLevel()
	{
		return this.BreachLevel;
	}

	// Token: 0x06014E5F RID: 85599 RVA: 0x0054E848 File Offset: 0x0054CA48
	public int GetRoleMaxLevel()
	{
		return base.GetRoleConfig().MaxLevel;
	}

	// Token: 0x06014E60 RID: 85600 RVA: 0x0054E863 File Offset: 0x0054CA63
	public bool GetRoleIsMaxLevel()
	{
		return this.Level >= this.GetRoleMaxLevel();
	}

	// Token: 0x06014E61 RID: 85601 RVA: 0x0054E876 File Offset: 0x0054CA76
	public int GetCurrentMaxExp()
	{
		return this.GetLevelUpExp(this.Level + 1);
	}

	// Token: 0x06014E62 RID: 85602 RVA: 0x0054E888 File Offset: 0x0054CA88
	public int GetLevelUpNeedExp()
	{
		int levelUpExp = this.GetLevelUpExp(this.Level + 1);
		return Math.Max(0, levelUpExp - this.Exp);
	}

	// Token: 0x06014E63 RID: 85603 RVA: 0x0054E8B4 File Offset: 0x0054CAB4
	private int GetLevelUpExp(int level)
	{
		RoleLevelConsume? roleLevelConsume = RoleConfig.Instance.GetRoleLevelConsume(base.GetRoleConfig().LevelConsumeId, level);
		if (roleLevelConsume != null)
		{
			return roleLevelConsume.Value.ExpCount;
		}
		return 1;
	}

	// Token: 0x06014E64 RID: 85604 RVA: 0x0054E8F8 File Offset: 0x0054CAF8
	public int GetMaxBreachLevel()
	{
		IReadOnlyList<RoleBreach> roleBreachList = RoleConfig.Instance.GetRoleBreachList(base.GetRoleConfig().BreachId);
		int count = roleBreachList.Count;
		int num = 0;
		for (int i = 0; i < count; i++)
		{
			RoleBreach roleBreach = roleBreachList[i];
			if (roleBreach.BreachLevel > num)
			{
				num = roleBreach.BreachLevel;
			}
		}
		return num;
	}

	// Token: 0x06014E65 RID: 85605 RVA: 0x0054E954 File Offset: 0x0054CB54
	public int GetCurrentMaxLevel()
	{
		RoleBreach? breachConfig = this.GetBreachConfig(this.BreachLevel);
		if (breachConfig == null)
		{
			return 0;
		}
		return breachConfig.Value.MaxLevel;
	}

	// Token: 0x06014E66 RID: 85606 RVA: 0x0054E988 File Offset: 0x0054CB88
	public RoleBreach? GetBreachConfig(int level)
	{
		return RoleConfig.Instance.GetRoleBreachConfig(base.GetRoleConfig().BreachId, level);
	}

	// Token: 0x06014E67 RID: 85607 RVA: 0x0054E9AE File Offset: 0x0054CBAE
	public bool GetRoleNeedBreakUp()
	{
		return this.Level >= this.GetCurrentMaxLevel() && this.Level < this.GetRoleMaxLevel();
	}

	// Token: 0x06014E68 RID: 85608 RVA: 0x0054E9D0 File Offset: 0x0054CBD0
	public double GetExpPercentage()
	{
		if (this.GetRoleIsMaxLevel())
		{
			return 1.0;
		}
		RoleLevelConsume? roleLevelConsume = RoleConfig.Instance.GetRoleLevelConsume(base.GetRoleConfig().LevelConsumeId, this.Level + 1);
		if (roleLevelConsume != null)
		{
			return (double)this.Exp / (double)roleLevelConsume.Value.ExpCount;
		}
		return 0.0;
	}

	// Token: 0x06014E69 RID: 85609 RVA: 0x0054EA3C File Offset: 0x0054CC3C
	public bool IsEnoughBreachConsume()
	{
		RoleBreach? roleBreachConfig = RoleConfig.Instance.GetRoleBreachConfig(base.GetRoleConfig().BreachId, this.BreachLevel + 1);
		if (roleBreachConfig == null)
		{
			return false;
		}
		if (!LevelGeneralController.Instance.CheckCondition(roleBreachConfig.Value.ConditionId.ToString(), null, false, Array.Empty<object>()))
		{
			return false;
		}
		foreach (DicIntInt dicIntInt in roleBreachConfig.Value.BreachConsumeIter())
		{
			if (InventoryModel.Instance.GetItemCountByConfigId(dicIntInt.Key, 0) < dicIntInt.Value)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x04009D02 RID: 40194
	protected int Level;

	// Token: 0x04009D03 RID: 40195
	protected int BreachLevel;

	// Token: 0x04009D04 RID: 40196
	protected int Exp;
}
