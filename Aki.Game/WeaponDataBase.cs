using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002252 RID: 8786
[NullableContext(1)]
[Nullable(0)]
public abstract class WeaponDataBase
{
	// Token: 0x06015B74 RID: 88948
	public abstract int GetLevel();

	// Token: 0x06015B75 RID: 88949
	public abstract int GetResonanceLevel();

	// Token: 0x06015B76 RID: 88950
	public abstract int GetBreachLevel();

	// Token: 0x06015B77 RID: 88951
	public abstract int GetItemId();

	// Token: 0x06015B78 RID: 88952
	public abstract bool IsTrial();

	// Token: 0x06015B79 RID: 88953
	public abstract bool HasRole();

	// Token: 0x06015B7A RID: 88954
	public abstract void SetRoleId(int roleId);

	// Token: 0x06015B7B RID: 88955
	public abstract int GetRoleId();

	// Token: 0x06015B7C RID: 88956 RVA: 0x0064C868 File Offset: 0x0064AA68
	public int GetModelId(int skinId)
	{
		if (skinId == -1)
		{
			return this.GetItemConfig().ModelId;
		}
		return SkinConfig.Instance.GetWeaponSkinConfig(skinId).ModelId;
	}

	// Token: 0x06015B7D RID: 88957 RVA: 0x0064C89C File Offset: 0x0064AA9C
	public int[] GetModels(int skinId)
	{
		if (skinId == -1)
		{
			return this.GetItemConfig().GetModelsArray();
		}
		return SkinConfig.Instance.GetWeaponSkinConfig(skinId).GetModelsArray();
	}

	// Token: 0x06015B7E RID: 88958 RVA: 0x0064C8D0 File Offset: 0x0064AAD0
	public int[] GetModelsIndex(int skinId)
	{
		if (skinId == -1)
		{
			return this.GetItemConfig().ModelsIndex();
		}
		return SkinConfig.Instance.GetWeaponSkinConfig(skinId).ModelsIndex();
	}

	// Token: 0x06015B7F RID: 88959 RVA: 0x0064C904 File Offset: 0x0064AB04
	public int GetTransformId(int skinId)
	{
		if (skinId == -1)
		{
			return this.GetItemConfig().TransformId;
		}
		return SkinConfig.Instance.GetWeaponSkinConfig(skinId).TransformId;
	}

	// Token: 0x06015B80 RID: 88960 RVA: 0x0064C937 File Offset: 0x0064AB37
	public WeaponConf? GetWeaponConfig()
	{
		return WeaponConfig.Instance.GetWeaponConfigByItemId(this.GetItemId());
	}

	// Token: 0x06015B81 RID: 88961 RVA: 0x0064C94C File Offset: 0x0064AB4C
	public WeaponBreach? GetBreachConfig()
	{
		WeaponConf? weaponConfig = this.GetWeaponConfig();
		if (weaponConfig != null)
		{
			int breachLevel = this.GetBreachLevel();
			return WeaponConfig.Instance.GetWeaponBreach(weaponConfig.Value.BreachId, breachLevel);
		}
		return null;
	}

	// Token: 0x06015B82 RID: 88962 RVA: 0x0064C994 File Offset: 0x0064AB94
	[NullableContext(2)]
	public IReadOnlyList<WeaponBreach> GetBreachConfigList()
	{
		WeaponConf? weaponConfig = this.GetWeaponConfig();
		if (weaponConfig != null)
		{
			return WeaponConfig.Instance.GetWeaponBreachList(weaponConfig.Value.BreachId);
		}
		return null;
	}

	// Token: 0x06015B83 RID: 88963 RVA: 0x0064C9CC File Offset: 0x0064ABCC
	public WeaponReson? GetResonanceConfig()
	{
		WeaponConf? weaponConfig = this.GetWeaponConfig();
		if (weaponConfig != null)
		{
			int resonanceLevel = this.GetResonanceLevel();
			return WeaponConfig.Instance.GetWeaponResonanceConfig(weaponConfig.Value.ResonId, resonanceLevel);
		}
		return null;
	}

	// Token: 0x06015B84 RID: 88964 RVA: 0x0064CA14 File Offset: 0x0064AC14
	public virtual bool CanGoBreach()
	{
		int level = this.GetLevel();
		int levelLimit = this.GetLastBreachConfig().LevelLimit;
		if (level >= levelLimit)
		{
			return false;
		}
		WeaponBreach? breachConfig = this.GetBreachConfig();
		return breachConfig != null && level >= breachConfig.Value.LevelLimit;
	}

	// Token: 0x06015B85 RID: 88965 RVA: 0x0064CA64 File Offset: 0x0064AC64
	public WeaponBreach GetLastBreachConfig()
	{
		int breachId = this.GetWeaponConfig().Value.BreachId;
		IReadOnlyList<WeaponBreach> weaponBreachList = WeaponConfig.Instance.GetWeaponBreachList(breachId);
		return weaponBreachList[weaponBreachList.Count - 1];
	}

	// Token: 0x06015B86 RID: 88966 RVA: 0x0064CAA0 File Offset: 0x0064ACA0
	public WeaponBreach? GetBreachConsume()
	{
		WeaponConf? weaponConfig = this.GetWeaponConfig();
		int breachLevel = this.GetBreachLevel();
		return WeaponConfig.Instance.GetWeaponBreach(weaponConfig.Value.BreachId, breachLevel);
	}

	// Token: 0x06015B87 RID: 88967 RVA: 0x0064CAD8 File Offset: 0x0064ACD8
	public int GetMaxLevel()
	{
		return Math.Min(WeaponConfig.Instance.GetWeaponLevelLimit(this.GetItemConfig().QualityId), this.GetLastBreachConfig().LevelLimit);
	}

	// Token: 0x06015B88 RID: 88968 RVA: 0x0064CB10 File Offset: 0x0064AD10
	public bool IsLevelMax()
	{
		int maxLevel = this.GetMaxLevel();
		return this.GetLevel() >= maxLevel;
	}

	// Token: 0x06015B89 RID: 88969 RVA: 0x0064CB30 File Offset: 0x0064AD30
	public int GetMaterialCost()
	{
		int qualityId = this.GetItemConfig().QualityId;
		return WeaponConfig.Instance.GetWeaponQualityInfo(qualityId).Value.Cost;
	}

	// Token: 0x06015B8A RID: 88970 RVA: 0x0064CB68 File Offset: 0x0064AD68
	public int GetMaxExp(int weaponLevel)
	{
		IEnumerable<WeaponLevel> weaponLevelList = WeaponConfig.Instance.GetWeaponLevelList(this.GetWeaponConfig().Value.LevelId);
		int num = 0;
		foreach (WeaponLevel weaponLevel2 in weaponLevelList)
		{
			if (weaponLevel2.Level > weaponLevel)
			{
				return num;
			}
			num += weaponLevel2.Exp;
		}
		return num;
	}

	// Token: 0x06015B8B RID: 88971 RVA: 0x0064CBEC File Offset: 0x0064ADEC
	protected int GetLevelLimitMaxExp()
	{
		int breachLevel = this.GetBreachLevel();
		return this.GetMaxExp(WeaponConfig.Instance.GetWeaponBreach(this.GetWeaponConfig().Value.BreachId, breachLevel).Value.LevelLimit - 1);
	}

	// Token: 0x06015B8C RID: 88972 RVA: 0x0064CC3C File Offset: 0x0064AE3C
	public int GetLevelExp(int level)
	{
		int result = 0;
		if (level <= 0)
		{
			return 0;
		}
		WeaponLevel? weaponLevelConfig = WeaponConfig.Instance.GetWeaponLevelConfig(this.GetWeaponConfig().Value.LevelId, level);
		if (weaponLevelConfig != null)
		{
			result = weaponLevelConfig.Value.Exp;
		}
		return result;
	}

	// Token: 0x06015B8D RID: 88973 RVA: 0x0064CC90 File Offset: 0x0064AE90
	public int GetCurrentMaxLevel()
	{
		WeaponConf? weaponConfig = this.GetWeaponConfig();
		if (weaponConfig != null)
		{
			int breachLevel = this.GetBreachLevel();
			return WeaponConfig.Instance.GetWeaponBreach(weaponConfig.Value.BreachId, breachLevel).Value.LevelLimit;
		}
		return 0;
	}

	// Token: 0x06015B8E RID: 88974 RVA: 0x0064CCE1 File Offset: 0x0064AEE1
	public int GetLastLevelMaxExp()
	{
		return this.GetMaxExp(this.GetLevel() - 1);
	}

	// Token: 0x06015B8F RID: 88975 RVA: 0x0064CCF4 File Offset: 0x0064AEF4
	public WeaponConf GetItemConfig()
	{
		return InventoryConfig.Instance.GetWeaponItemConfig(this.GetItemId()).Value;
	}
}
