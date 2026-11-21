using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x0200206D RID: 8301
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsWeaponGainData : global::SurvivorsGainData
{
	// Token: 0x06014824 RID: 84004 RVA: 0x005FA3B8 File Offset: 0x005F85B8
	public SurvivorsWeaponGainData(int incId, int configId, Aki.Protocol.SurvivorsWeapon data, ESurvivorsRogueItemType type = ESurvivorsRogueItemType.Weapon) : base(incId, configId)
	{
		this.Data = data;
		this.Type = type;
	}

	// Token: 0x06014825 RID: 84005 RVA: 0x005FA3D1 File Offset: 0x005F85D1
	public int GetCurrentEvolveId()
	{
		if (this.Data.Evolves.Count == 0)
		{
			return 0;
		}
		return this.Data.Evolves[this.Data.Evolves.Count - 1];
	}

	// Token: 0x06014826 RID: 84006 RVA: 0x005FA409 File Offset: 0x005F8609
	public void SetWeaponKillCount(int count)
	{
		this.Data.KillMonsterCount = count;
	}

	// Token: 0x06014827 RID: 84007 RVA: 0x005FA418 File Offset: 0x005F8618
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

	// Token: 0x0400ADD4 RID: 44500
	public Aki.Protocol.SurvivorsWeapon Data;
}
