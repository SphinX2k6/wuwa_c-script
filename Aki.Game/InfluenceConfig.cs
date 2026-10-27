using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001F75 RID: 8053
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class InfluenceConfig : ConfigBase
{
	// Token: 0x0600F9D6 RID: 63958 RVA: 0x003C8C2C File Offset: 0x003C6E2C
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

	// Token: 0x0600F9D7 RID: 63959 RVA: 0x003C8C94 File Offset: 0x003C6E94
	public List<Country> GetCountryList()
	{
		return (from value in ConfigCountryAll.GetConfigList(true)
		where value.Id != 0 && value.Id != 9999
		select value).ToList<Country>();
	}

	// Token: 0x0600F9D8 RID: 63960 RVA: 0x003C8CC8 File Offset: 0x003C6EC8
	public Country? GetCountryConfig(int id)
	{
		Country? config = ConfigCountryById.GetConfig(id, true);
		if (config != null)
		{
			return new Country?(config.Value);
		}
		return null;
	}

	// Token: 0x0600F9D9 RID: 63961 RVA: 0x003C8CFC File Offset: 0x003C6EFC
	public State? GetStateConfig(int stateId)
	{
		State? config = ConfigStateByStateId.GetConfig(stateId, true);
		if (config != null)
		{
			return new State?(config.Value);
		}
		return null;
	}

	// Token: 0x0600F9DA RID: 63962 RVA: 0x003C8D30 File Offset: 0x003C6F30
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

	// Token: 0x0600F9DB RID: 63963 RVA: 0x003C8E14 File Offset: 0x003C7014
	public string GetCountryTitle(int id)
	{
		Country? countryConfig = this.GetCountryConfig(id);
		if (countryConfig != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(countryConfig.Value.Title, null);
		}
		return "";
	}

	// Token: 0x0600F9DC RID: 63964 RVA: 0x003C8E50 File Offset: 0x003C7050
	public Influence? GetInfluenceConfig(int id)
	{
		Influence? config = ConfigInfluenceById.GetConfig(id, true);
		if (config != null)
		{
			return new Influence?(config.Value);
		}
		return null;
	}

	// Token: 0x0600F9DD RID: 63965 RVA: 0x003C8E84 File Offset: 0x003C7084
	public string GetInfluenceTitle(int id)
	{
		Influence? influenceConfig = this.GetInfluenceConfig(id);
		if (influenceConfig != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(influenceConfig.Value.Title, null);
		}
		return "";
	}

	// Token: 0x0600F9DE RID: 63966 RVA: 0x003C8EC0 File Offset: 0x003C70C0
	public bool GetInfluenceIfShowInDailyTask(int influenceId)
	{
		Influence? influenceConfig = this.GetInfluenceConfig(influenceId);
		return influenceConfig != null && influenceConfig.Value.DailyTaskShow == 1;
	}

	// Token: 0x0600F9DF RID: 63967 RVA: 0x003C8EF4 File Offset: 0x003C70F4
	public bool GetCountryIfShowInDailyTask(int countryId)
	{
		Country? countryConfig = this.GetCountryConfig(countryId);
		return countryConfig != null && countryConfig.Value.DailyTaskShow == 1;
	}

	// Token: 0x1700133B RID: 4923
	// (get) Token: 0x0600F9E0 RID: 63968 RVA: 0x003C8F26 File Offset: 0x003C7126
	public static InfluenceConfig Instance
	{
		get
		{
			return InfluenceConfig._Instance;
		}
	}

	// Token: 0x0600F9E1 RID: 63969 RVA: 0x003C8F2D File Offset: 0x003C712D
	public static InfluenceConfig GetOrCreateInstance()
	{
		if (InfluenceConfig._Instance == null)
		{
			InfluenceConfig.CreateInstance();
		}
		return InfluenceConfig._Instance;
	}

	// Token: 0x0600F9E2 RID: 63970 RVA: 0x003C8F41 File Offset: 0x003C7141
	public static bool CreateInstance()
	{
		if (InfluenceConfig._Instance != null)
		{
			return true;
		}
		InfluenceConfig._Instance = new InfluenceConfig();
		return true;
	}

	// Token: 0x0600F9E3 RID: 63971 RVA: 0x003C8F57 File Offset: 0x003C7157
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F9E4 RID: 63972 RVA: 0x003C8F59 File Offset: 0x003C7159
	public static void ResetStaticDefaultValue()
	{
		InfluenceConfig._Instance = null;
	}

	// Token: 0x0600F9E5 RID: 63973 RVA: 0x003C8F61 File Offset: 0x003C7161
	static InfluenceConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfluenceConfig.CreateStaticDefaultValue), new Action(InfluenceConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007477 RID: 29815
	[Nullable(2)]
	private static InfluenceConfig _Instance;
}
