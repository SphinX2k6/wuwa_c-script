using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin;

// Token: 0x02002CF8 RID: 11512
[NullableContext(1)]
[Nullable(0)]
public abstract class WeaponDataBase
{
	// Token: 0x060182D3 RID: 99027
	public abstract int GetLevel();

	// Token: 0x060182D4 RID: 99028
	public abstract int GetResonanceLevel();

	// Token: 0x060182D5 RID: 99029
	public abstract int GetBreachLevel();

	// Token: 0x060182D6 RID: 99030
	public abstract int GetItemId();

	// Token: 0x060182D7 RID: 99031
	public abstract bool IsTrial();

	// Token: 0x060182D8 RID: 99032
	public abstract bool HasRole();

	// Token: 0x060182D9 RID: 99033
	public abstract void SetRoleId(int roleId);

	// Token: 0x060182DA RID: 99034
	public abstract int GetRoleId();

	// Token: 0x060182DB RID: 99035 RVA: 0x006268A0 File Offset: 0x00624AA0
	public int GetModelId(int skinId)
	{
		if (skinId == -1)
		{
			return this.GetItemConfig().ModelId;
		}
		return SkinConfig.Instance.GetWeaponSkinConfig(skinId).ModelId;
	}

	// Token: 0x060182DC RID: 99036 RVA: 0x006268D4 File Offset: 0x00624AD4
	public int[] GetModels(int skinId)
	{
		if (skinId == -1)
		{
			return this.GetItemConfig().GetModelsArray();
		}
		return SkinConfig.Instance.GetWeaponSkinConfig(skinId).GetModelsArray();
	}

	// Token: 0x060182DD RID: 99037 RVA: 0x00626908 File Offset: 0x00624B08
	public int[] GetModelsIndex(int skinId)
	{
		if (skinId == -1)
		{
			return this.GetItemConfig().ModelsIndex();
		}
		return SkinConfig.Instance.GetWeaponSkinConfig(skinId).ModelsIndex();
	}

	// Token: 0x060182DE RID: 99038 RVA: 0x0062693C File Offset: 0x00624B3C
	public int GetTransformId(int skinId)
	{
		if (skinId == -1)
		{
			return this.GetItemConfig().TransformId;
		}
		return SkinConfig.Instance.GetWeaponSkinConfig(skinId).TransformId;
	}

	// Token: 0x060182DF RID: 99039 RVA: 0x0062696F File Offset: 0x00624B6F
	public WeaponConf? GetWeaponConfig()
	{
		return WeaponConfig.Instance.GetWeaponConfigByItemId(this.GetItemId());
	}

	// Token: 0x060182E0 RID: 99040 RVA: 0x00626984 File Offset: 0x00624B84
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

	// Token: 0x060182E1 RID: 99041 RVA: 0x006269CC File Offset: 0x00624BCC
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

	// Token: 0x060182E2 RID: 99042 RVA: 0x00626A04 File Offset: 0x00624C04
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

	// Token: 0x060182E3 RID: 99043 RVA: 0x00626A4C File Offset: 0x00624C4C
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

	// Token: 0x060182E4 RID: 99044 RVA: 0x00626A9C File Offset: 0x00624C9C
	public WeaponBreach GetLastBreachConfig()
	{
		int breachId = this.GetWeaponConfig().Value.BreachId;
		IReadOnlyList<WeaponBreach> weaponBreachList = WeaponConfig.Instance.GetWeaponBreachList(breachId);
		return weaponBreachList[weaponBreachList.Count - 1];
	}

	// Token: 0x060182E5 RID: 99045 RVA: 0x00626AD8 File Offset: 0x00624CD8
	public WeaponBreach? GetBreachConsume()
	{
		WeaponConf? weaponConfig = this.GetWeaponConfig();
		int breachLevel = this.GetBreachLevel();
		return WeaponConfig.Instance.GetWeaponBreach(weaponConfig.Value.BreachId, breachLevel);
	}

	// Token: 0x060182E6 RID: 99046 RVA: 0x00626B10 File Offset: 0x00624D10
	public int GetMaxLevel()
	{
		return Math.Min(WeaponConfig.Instance.GetWeaponLevelLimit(this.GetItemConfig().QualityId), this.GetLastBreachConfig().LevelLimit);
	}

	// Token: 0x060182E7 RID: 99047 RVA: 0x00626B48 File Offset: 0x00624D48
	public bool IsLevelMax()
	{
		int maxLevel = this.GetMaxLevel();
		return this.GetLevel() >= maxLevel;
	}

	// Token: 0x060182E8 RID: 99048 RVA: 0x00626B68 File Offset: 0x00624D68
	public int GetMaterialCost()
	{
		int qualityId = this.GetItemConfig().QualityId;
		return WeaponConfig.Instance.GetWeaponQualityInfo(qualityId).Value.Cost;
	}

	// Token: 0x060182E9 RID: 99049 RVA: 0x00626BA0 File Offset: 0x00624DA0
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

	// Token: 0x060182EA RID: 99050 RVA: 0x00626C24 File Offset: 0x00624E24
	protected int GetLevelLimitMaxExp()
	{
		int breachLevel = this.GetBreachLevel();
		return this.GetMaxExp(WeaponConfig.Instance.GetWeaponBreach(this.GetWeaponConfig().Value.BreachId, breachLevel).Value.LevelLimit - 1);
	}

	// Token: 0x060182EB RID: 99051 RVA: 0x00626C74 File Offset: 0x00624E74
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

	// Token: 0x060182EC RID: 99052 RVA: 0x00626CC8 File Offset: 0x00624EC8
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

	// Token: 0x060182ED RID: 99053 RVA: 0x00626D19 File Offset: 0x00624F19
	public int GetLastLevelMaxExp()
	{
		return this.GetMaxExp(this.GetLevel() - 1);
	}

	// Token: 0x060182EE RID: 99054 RVA: 0x00626D2C File Offset: 0x00624F2C
	public WeaponConf GetItemConfig()
	{
		return InventoryConfig.Instance.GetWeaponItemConfig(this.GetItemId()).Value;
	}
}
