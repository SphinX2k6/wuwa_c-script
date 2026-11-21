using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001ADA RID: 6874
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PowerConfig : ConfigBase
{
	// Token: 0x060110F9 RID: 69881 RVA: 0x00503030 File Offset: 0x00501230
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

	// Token: 0x060110FA RID: 69882 RVA: 0x0050308C File Offset: 0x0050128C
	public int GetPowerNaturalLimit()
	{
		return ConfigCommonParamById.GetIntConfig("renew_energy_limit").GetValueOrDefault();
	}

	// Token: 0x060110FB RID: 69883 RVA: 0x005030AC File Offset: 0x005012AC
	public int GetPowerChargeLimit()
	{
		return ConfigCommonParamById.GetIntConfig("charge_energy_limit").GetValueOrDefault();
	}

	// Token: 0x060110FC RID: 69884 RVA: 0x005030CC File Offset: 0x005012CC
	public int GetPowerIncreaseSpan()
	{
		return ConfigCommonParamById.GetIntConfig("renew_energy_timespan").GetValueOrDefault();
	}

	// Token: 0x060110FD RID: 69885 RVA: 0x005030EC File Offset: 0x005012EC
	public int GetOverPowerLimit()
	{
		return ConfigCommonParamById.GetIntConfig("store_energy_limit").GetValueOrDefault();
	}

	// Token: 0x060110FE RID: 69886 RVA: 0x0050310C File Offset: 0x0050130C
	public int GetOverPowerRecoverTimeSpan()
	{
		return ConfigCommonParamById.GetIntConfig("store_energy_timespan").GetValueOrDefault();
	}

	// Token: 0x060110FF RID: 69887 RVA: 0x0050312C File Offset: 0x0050132C
	public int GetSingleTimeExchangePowerLimit()
	{
		return ConfigCommonParamById.GetIntConfig("single_time_get_max").GetValueOrDefault();
	}

	// Token: 0x06011100 RID: 69888 RVA: 0x0050314B File Offset: 0x0050134B
	public IReadOnlyList<int> GetPowerCurrencyIds()
	{
		return ConfigCommonParamById.GetIntArrayConfig("PowerTipsIdArray") ?? new <>z__ReadOnlySingleElementList<int>(0);
	}

	// Token: 0x06011101 RID: 69889 RVA: 0x00503164 File Offset: 0x00501364
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

	// Token: 0x17001989 RID: 6537
	// (get) Token: 0x06011102 RID: 69890 RVA: 0x005031E8 File Offset: 0x005013E8
	public static PowerConfig Instance
	{
		get
		{
			return PowerConfig._Instance;
		}
	}

	// Token: 0x06011103 RID: 69891 RVA: 0x005031EF File Offset: 0x005013EF
	public static PowerConfig GetOrCreateInstance()
	{
		if (PowerConfig._Instance == null)
		{
			PowerConfig.CreateInstance();
		}
		return PowerConfig._Instance;
	}

	// Token: 0x06011104 RID: 69892 RVA: 0x00503203 File Offset: 0x00501403
	public static bool CreateInstance()
	{
		if (PowerConfig._Instance != null)
		{
			return true;
		}
		PowerConfig._Instance = new PowerConfig();
		return true;
	}

	// Token: 0x06011105 RID: 69893 RVA: 0x00503219 File Offset: 0x00501419
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011106 RID: 69894 RVA: 0x0050321B File Offset: 0x0050141B
	public static void ResetStaticDefaultValue()
	{
		PowerConfig._Instance = null;
	}

	// Token: 0x06011107 RID: 69895 RVA: 0x00503223 File Offset: 0x00501423
	static PowerConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PowerConfig.CreateStaticDefaultValue), new Action(PowerConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009631 RID: 38449
	private readonly HashSet<int> PowerShopIds = new HashSet<int>();

	// Token: 0x04009632 RID: 38450
	[Nullable(2)]
	private static PowerConfig _Instance;
}
