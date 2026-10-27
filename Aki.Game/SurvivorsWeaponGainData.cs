using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02002AF1 RID: 10993
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponGainData : global::SurvivorsGainData
{
	// Token: 0x06016DF3 RID: 93683 RVA: 0x005CD838 File Offset: 0x005CBA38
	public SurvivorsWeaponGainData(int incId, int configId, Aki.Protocol.SurvivorsWeapon data, ESurvivorsRogueItemType type = ESurvivorsRogueItemType.Weapon) : base(incId, configId)
	{
		this.Data = data;
		this.Type = type;
	}

	// Token: 0x06016DF4 RID: 93684 RVA: 0x005CD851 File Offset: 0x005CBA51
	public int GetCurrentEvolveId()
	{
		if (this.Data.Evolves.Count == 0)
		{
			return 0;
		}
		return this.Data.Evolves[this.Data.Evolves.Count - 1];
	}

	// Token: 0x06016DF5 RID: 93685 RVA: 0x005CD889 File Offset: 0x005CBA89
	public void SetWeaponKillCount(int count)
	{
		this.Data.KillMonsterCount = count;
	}

	// Token: 0x06016DF6 RID: 93686 RVA: 0x005CD898 File Offset: 0x005CBA98
	public List<ISurvivorsWeaponAttributeData> GetWeaponSpecialAttributeList()
	{
		List<ISurvivorsWeaponAttributeData> list = new List<ISurvivorsWeaponAttributeData>();
		for (int i = 0; i < this.Data.Affixs.Count; i++)
		{
			int num = this.Data.Affixs[i];
			Aki.Config.SurvivorsWeaponLv? survivorsWeaponLv = SurvivorsRogueConfig.Instance.GetSurvivorsWeaponLv(num);
			if (survivorsWeaponLv != null)
			{
				SurvivorsProperty? propertyConfig = SurvivorsRogueConfig.Instance.GetPropertyConfig(survivorsWeaponLv.Value.PropertyId);
				if (propertyConfig != null && propertyConfig.Value.IsSpecial)
				{
					list.Add(new SurvivorsWeaponAttributeData
					{
						WeaponLvId = num,
						AttrId = propertyConfig.Value.Id,
						SortId = propertyConfig.Value.Priority
					});
				}
			}
		}
		list.Sort((ISurvivorsWeaponAttributeData a, ISurvivorsWeaponAttributeData b) => a.SortId - b.SortId);
		return list;
	}

	// Token: 0x0400A9CE RID: 43470
	public Aki.Protocol.SurvivorsWeapon Data;
}
