using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001437 RID: 5175
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class InfluenceConfig : ConfigBase
{
	// Token: 0x0600CDF5 RID: 52725 RVA: 0x003D4718 File Offset: 0x003D2918
	public List<Country> GetCountriesByIds(int[] ids)
	{
		if (ids.Length != 0)
		{
			List<Country> list = new List<Country>();
			for (int i = 0; i < ids.Length; i++)
			{
				list.Add(ConfigCountryById.GetConfig(ids[i], true).Value);
			}
			list.Sort((Country a, Country b) => a.Id - b.Id);
			return list;
		}
		return new List<Country>();
	}

	// Token: 0x0600CDF6 RID: 52726 RVA: 0x003D4780 File Offset: 0x003D2980
	public List<Country> GetCountryList()
	{
		IEnumerable<Country> configList = ConfigCountryAll.GetConfigList(true);
		List<Country> list = new List<Country>();
		foreach (Country item in configList)
		{
			if (item.Id != 0 && item.Id != 9999)
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0600CDF7 RID: 52727 RVA: 0x003D47EC File Offset: 0x003D29EC
	public Country? GetCountryConfig(int id)
	{
		Country? config = ConfigCountryById.GetConfig(id, true);
		if (config != null)
		{
			return new Country?(config.Value);
		}
		return null;
	}

	// Token: 0x0600CDF8 RID: 52728 RVA: 0x003D4820 File Offset: 0x003D2A20
	public State? GetStateConfig(int stateId)
	{
		State? config = ConfigStateByStateId.GetConfig(stateId, true);
		if (config != null)
		{
			return new State?(config.Value);
		}
		return null;
	}

	// Token: 0x0600CDF9 RID: 52729 RVA: 0x003D4854 File Offset: 0x003D2A54
	public List<Influence> GetCountryInfluence(int id)
	{
		List<Influence> list = new List<Influence>();
		if (id == 0)
		{
			Influence? influenceConfig = this.GetInfluenceConfig(0);
			if (influenceConfig != null)
			{
				list.Add(influenceConfig.Value);
			}
		}
		else
		{
			Country? countryConfig = this.GetCountryConfig(id);
			if (countryConfig == null)
			{
				return list;
			}
			if (countryConfig.Value.Influences().Length == 0)
			{
				IReadOnlyList<Influence> configList = ConfigInfluenceAll.GetConfigList(true);
				for (int i = 0; i < configList.Count; i++)
				{
					list.Add(configList[i]);
				}
			}
			else
			{
				for (int j = 0; j < countryConfig.Value.Influences().Length; j++)
				{
					Influence? influenceConfig2 = this.GetInfluenceConfig(countryConfig.Value.Influences()[j]);
					if (influenceConfig2 != null)
					{
						list.Add(influenceConfig2.Value);
					}
				}
			}
		}
		return list;
	}

	// Token: 0x0600CDFA RID: 52730 RVA: 0x003D4938 File Offset: 0x003D2B38
	public string GetCountryTitle(int id)
	{
		Country? countryConfig = this.GetCountryConfig(id);
		if (countryConfig != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(countryConfig.Value.Title, null);
		}
		return "";
	}

	// Token: 0x0600CDFB RID: 52731 RVA: 0x003D4974 File Offset: 0x003D2B74
	public Influence? GetInfluenceConfig(int id)
	{
		Influence? config = ConfigInfluenceById.GetConfig(id, true);
		if (config != null)
		{
			return new Influence?(config.Value);
		}
		return null;
	}

	// Token: 0x0600CDFC RID: 52732 RVA: 0x003D49A8 File Offset: 0x003D2BA8
	public string GetInfluenceTitle(int id)
	{
		Influence? influenceConfig = this.GetInfluenceConfig(id);
		if (influenceConfig != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(influenceConfig.Value.Title, null);
		}
		return "";
	}

	// Token: 0x0600CDFD RID: 52733 RVA: 0x003D49E4 File Offset: 0x003D2BE4
	public bool GetInfluenceIfShowInDailyTask(int influenceId)
	{
		Influence? influenceConfig = this.GetInfluenceConfig(influenceId);
		return influenceConfig != null && influenceConfig.Value.DailyTaskShow == 1;
	}

	// Token: 0x0600CDFE RID: 52734 RVA: 0x003D4A18 File Offset: 0x003D2C18
	public bool GetCountryIfShowInDailyTask(int countryId)
	{
		Country? countryConfig = this.GetCountryConfig(countryId);
		return countryConfig != null && countryConfig.Value.DailyTaskShow == 1;
	}

	// Token: 0x17001365 RID: 4965
	// (get) Token: 0x0600CDFF RID: 52735 RVA: 0x003D4A4A File Offset: 0x003D2C4A
	public static InfluenceConfig Instance
	{
		get
		{
			return InfluenceConfig._Instance;
		}
	}

	// Token: 0x0600CE00 RID: 52736 RVA: 0x003D4A51 File Offset: 0x003D2C51
	public static InfluenceConfig GetOrCreateInstance()
	{
		if (InfluenceConfig._Instance == null)
		{
			InfluenceConfig.CreateInstance();
		}
		return InfluenceConfig._Instance;
	}

	// Token: 0x0600CE01 RID: 52737 RVA: 0x003D4A65 File Offset: 0x003D2C65
	public static bool CreateInstance()
	{
		if (InfluenceConfig._Instance != null)
		{
			return true;
		}
		InfluenceConfig._Instance = new InfluenceConfig();
		return true;
	}

	// Token: 0x0600CE02 RID: 52738 RVA: 0x003D4A7B File Offset: 0x003D2C7B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CE03 RID: 52739 RVA: 0x003D4A7D File Offset: 0x003D2C7D
	public static void ResetStaticDefaultValue()
	{
		InfluenceConfig._Instance = null;
	}

	// Token: 0x0600CE04 RID: 52740 RVA: 0x003D4A85 File Offset: 0x003D2C85
	static InfluenceConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfluenceConfig.CreateStaticDefaultValue), new Action(InfluenceConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007558 RID: 30040
	[Nullable(2)]
	private static InfluenceConfig _Instance;
}
