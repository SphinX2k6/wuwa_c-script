using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001D2D RID: 7469
public class RoleLevelData : RoleModuleDataBase
{
	// Token: 0x06012857 RID: 75863 RVA: 0x00579531 File Offset: 0x00577731
	public RoleLevelData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06012858 RID: 75864 RVA: 0x0057953A File Offset: 0x0057773A
	public void SetLevel(int level)
	{
		this.Level = level;
	}

	// Token: 0x06012859 RID: 75865 RVA: 0x00579543 File Offset: 0x00577743
	public int GetLevel()
	{
		return this.Level;
	}

	// Token: 0x0601285A RID: 75866 RVA: 0x0057954B File Offset: 0x0057774B
	public void SetExp(int exp)
	{
		this.Exp = exp;
	}

	// Token: 0x0601285B RID: 75867 RVA: 0x00579554 File Offset: 0x00577754
	public int GetExp()
	{
		return this.Exp;
	}

	// Token: 0x0601285C RID: 75868 RVA: 0x0057955C File Offset: 0x0057775C
	public void SetBreachLevel(int level)
	{
		this.BreachLevel = level;
	}

	// Token: 0x0601285D RID: 75869 RVA: 0x00579565 File Offset: 0x00577765
	public int GetBreachLevel()
	{
		return this.BreachLevel;
	}

	// Token: 0x0601285E RID: 75870 RVA: 0x00579570 File Offset: 0x00577770
	public int GetRoleMaxLevel()
	{
		return base.GetRoleConfig().MaxLevel;
	}

	// Token: 0x0601285F RID: 75871 RVA: 0x0057958B File Offset: 0x0057778B
	public bool GetRoleIsMaxLevel()
	{
		return this.Level >= this.GetRoleMaxLevel();
	}

	// Token: 0x06012860 RID: 75872 RVA: 0x0057959E File Offset: 0x0057779E
	public int GetCurrentMaxExp()
	{
		return this.GetLevelUpExp(this.Level + 1);
	}

	// Token: 0x06012861 RID: 75873 RVA: 0x005795B0 File Offset: 0x005777B0
	public int GetLevelUpNeedExp()
	{
		int levelUpExp = this.GetLevelUpExp(this.Level + 1);
		return Math.Max(0, levelUpExp - this.Exp);
	}

	// Token: 0x06012862 RID: 75874 RVA: 0x005795DC File Offset: 0x005777DC
	private int GetLevelUpExp(int level)
	{
		RoleLevelConsume? roleLevelConsume = RoleConfig.Instance.GetRoleLevelConsume(base.GetRoleConfig().LevelConsumeId, level);
		if (roleLevelConsume != null)
		{
			return roleLevelConsume.Value.ExpCount;
		}
		return 1;
	}

	// Token: 0x06012863 RID: 75875 RVA: 0x00579620 File Offset: 0x00577820
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

	// Token: 0x06012864 RID: 75876 RVA: 0x0057967C File Offset: 0x0057787C
	public int GetCurrentMaxLevel()
	{
		RoleBreach? breachConfig = this.GetBreachConfig(this.BreachLevel);
		if (breachConfig == null)
		{
			return 0;
		}
		return breachConfig.Value.MaxLevel;
	}

	// Token: 0x06012865 RID: 75877 RVA: 0x005796B0 File Offset: 0x005778B0
	public RoleBreach? GetBreachConfig(int level)
	{
		return RoleConfig.Instance.GetRoleBreachConfig(base.GetRoleConfig().BreachId, level);
	}

	// Token: 0x06012866 RID: 75878 RVA: 0x005796D6 File Offset: 0x005778D6
	public bool GetRoleNeedBreakUp()
	{
		return this.Level >= this.GetCurrentMaxLevel() && this.Level < this.GetRoleMaxLevel();
	}

	// Token: 0x06012867 RID: 75879 RVA: 0x005796F8 File Offset: 0x005778F8
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

	// Token: 0x06012868 RID: 75880 RVA: 0x00579764 File Offset: 0x00577964
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

	// Token: 0x0400A0E5 RID: 41189
	protected int Level;

	// Token: 0x0400A0E6 RID: 41190
	protected int BreachLevel;

	// Token: 0x0400A0E7 RID: 41191
	protected int Exp;
}
