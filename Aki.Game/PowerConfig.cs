using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020025EF RID: 9711
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PowerConfig : ConfigBase
{
	// Token: 0x06013C17 RID: 80919 RVA: 0x004F42A4 File Offset: 0x004F24A4
	public Dictionary<int, int> GetConfSortRule()
	{
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		string[] array = ConfigCommonParamById.GetStringConfig("energy_sort").Split(',', StringSplitOptions.None);
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(':', StringSplitOptions.None);
			int key = int.Parse(array2[0]);
			int value = int.Parse(array2[1]);
			dictionary.Add(key, value);
		}
		return dictionary;
	}

	// Token: 0x06013C18 RID: 80920 RVA: 0x004F4300 File Offset: 0x004F2500
	public int GetPowerNaturalLimit()
	{
		return ConfigCommonParamById.GetIntConfig("renew_energy_limit").GetValueOrDefault();
	}

	// Token: 0x06013C19 RID: 80921 RVA: 0x004F4320 File Offset: 0x004F2520
	public int GetPowerChargeLimit()
	{
		return ConfigCommonParamById.GetIntConfig("charge_energy_limit").GetValueOrDefault();
	}

	// Token: 0x06013C1A RID: 80922 RVA: 0x004F4340 File Offset: 0x004F2540
	public int GetPowerIncreaseSpan()
	{
		return ConfigCommonParamById.GetIntConfig("renew_energy_timespan").GetValueOrDefault();
	}

	// Token: 0x06013C1B RID: 80923 RVA: 0x004F4360 File Offset: 0x004F2560
	public int GetOverPowerLimit()
	{
		return ConfigCommonParamById.GetIntConfig("store_energy_limit").GetValueOrDefault();
	}

	// Token: 0x06013C1C RID: 80924 RVA: 0x004F4380 File Offset: 0x004F2580
	public int GetOverPowerRecoverTimeSpan()
	{
		return ConfigCommonParamById.GetIntConfig("store_energy_timespan").GetValueOrDefault();
	}

	// Token: 0x06013C1D RID: 80925 RVA: 0x004F43A0 File Offset: 0x004F25A0
	public int GetSingleTimeExchangePowerLimit()
	{
		return ConfigCommonParamById.GetIntConfig("single_time_get_max").GetValueOrDefault();
	}

	// Token: 0x06013C1E RID: 80926 RVA: 0x004F43BF File Offset: 0x004F25BF
	public IReadOnlyList<int> GetPowerCurrencyIds()
	{
		return ConfigCommonParamById.GetIntArrayConfig("PowerTipsIdArray") ?? new <>z__ReadOnlySingleElementList<int>(0);
	}

	// Token: 0x06013C1F RID: 80927 RVA: 0x004F43D8 File Offset: 0x004F25D8
	public HashSet<int> GetPowerShopIds()
	{
		if (this.PowerShopIds.Count != 0)
		{
			return this.PowerShopIds;
		}
		foreach (object obj in Enum.GetValues(typeof(EPowerShopType)))
		{
			EPowerShopType item = (EPowerShopType)obj;
			this.PowerShopIds.Add((int)item);
		}
		return this.PowerShopIds;
	}

	// Token: 0x17001951 RID: 6481
	// (get) Token: 0x06013C20 RID: 80928 RVA: 0x004F445C File Offset: 0x004F265C
	public static PowerConfig Instance
	{
		get
		{
			return PowerConfig._Instance;
		}
	}

	// Token: 0x06013C21 RID: 80929 RVA: 0x004F4463 File Offset: 0x004F2663
	public static PowerConfig GetOrCreateInstance()
	{
		if (PowerConfig._Instance == null)
		{
			PowerConfig.CreateInstance();
		}
		return PowerConfig._Instance;
	}

	// Token: 0x06013C22 RID: 80930 RVA: 0x004F4477 File Offset: 0x004F2677
	public static bool CreateInstance()
	{
		if (PowerConfig._Instance != null)
		{
			return true;
		}
		PowerConfig._Instance = new PowerConfig();
		return true;
	}

	// Token: 0x06013C23 RID: 80931 RVA: 0x004F448D File Offset: 0x004F268D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013C24 RID: 80932 RVA: 0x004F448F File Offset: 0x004F268F
	public static void ResetStaticDefaultValue()
	{
		PowerConfig._Instance = null;
	}

	// Token: 0x06013C25 RID: 80933 RVA: 0x004F4497 File Offset: 0x004F2697
	static PowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PowerConfig.CreateStaticDefaultValue), new Action(PowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040094DA RID: 38106
	private readonly HashSet<int> PowerShopIds = new HashSet<int>();

	// Token: 0x040094DB RID: 38107
	[Nullable(2)]
	private static PowerConfig _Instance;
}
