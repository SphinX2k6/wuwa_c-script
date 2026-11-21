using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02000CBA RID: 3258
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ExchangeRewardConfig : ConfigBase
{
	// Token: 0x0600880E RID: 34830 RVA: 0x00295840 File Offset: 0x00293A40
	public ExchangeReward? GetExchangeRewardConfig(int? id)
	{
		if (id == null || id.Value == 0)
		{
			return null;
		}
		return ConfigExchangeRewardById.GetConfig(id.Value, true);
	}

	// Token: 0x0600880F RID: 34831 RVA: 0x00295878 File Offset: 0x00293A78
	public ExchangeShared? GetExchangeShareConfig(int? id)
	{
		if (id == null || id.Value == 0)
		{
			return null;
		}
		return ConfigExchangeSharedById.GetConfig(id.Value, true);
	}

	// Token: 0x06008810 RID: 34832 RVA: 0x002958B0 File Offset: 0x00293AB0
	public List<TItem> GetExchangeRewardPreviewRewardList(int exchangeId, int? worldLevel = null)
	{
		if (exchangeId == 0)
		{
			return new List<TItem>();
		}
		ExchangeReward? exchangeRewardConfig = this.GetExchangeRewardConfig(new int?(exchangeId));
		List<TItem> list = new List<TItem>();
		if (exchangeRewardConfig == null)
		{
			return list;
		}
		Dictionary<int, IntIntMap> dictionary = exchangeRewardConfig.Value.PreviewReward();
		int num = (worldLevel.GetValueOrDefault() != 0) ? worldLevel.Value : WorldLevelModel.Instance.CurWorldLevel;
		Dictionary<int, int> dictionary2 = null;
		if (dictionary.ContainsKey(num))
		{
			int mapIntIntLength = dictionary[num].MapIntIntLength;
			for (int i = 0; i < mapIntIntLength; i++)
			{
				DicIntInt value = dictionary[num].MapIntInt(i).Value;
				if (dictionary2 == null)
				{
					dictionary2 = new Dictionary<int, int>();
				}
				dictionary2.Add(value.Key, value.Value);
			}
		}
		else
		{
			for (int j = num - 1; j >= 0; j--)
			{
				if (dictionary.ContainsKey(j))
				{
					int mapIntIntLength2 = dictionary[j].MapIntIntLength;
					for (int k = 0; k < mapIntIntLength2; k++)
					{
						DicIntInt value2 = dictionary[j].MapIntInt(k).Value;
						if (dictionary2 == null)
						{
							dictionary2 = new Dictionary<int, int>();
						}
						dictionary2.Add(value2.Key, value2.Value);
					}
					break;
				}
			}
		}
		if (dictionary2 == null)
		{
			Dictionary<int, int> dictionary3 = exchangeRewardConfig.Value.RewardId();
			int num2 = 0;
			if (dictionary3.ContainsKey(num))
			{
				num2 = dictionary3[num];
			}
			else
			{
				for (int l = num - 1; l >= 0; l--)
				{
					if (dictionary3.ContainsKey(l))
					{
						num2 = dictionary3[l];
						break;
					}
				}
			}
			if (num2 > 0)
			{
				DropPackage? config = ConfigDropPackageById.GetConfig(num2, true);
				if (config != null)
				{
					dictionary2 = config.Value.DropPreview();
				}
			}
		}
		if (dictionary2 != null)
		{
			foreach (KeyValuePair<int, int> keyValuePair in dictionary2)
			{
				int key = keyValuePair.Key;
				int value3 = keyValuePair.Value;
				TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value3);
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x06008811 RID: 34833 RVA: 0x00295AF4 File Offset: 0x00293CF4
	public int GetExchangeRewardMaxCount(int id)
	{
		if (this.GetExchangeRewardConfig(new int?(id)) == null)
		{
			return 0;
		}
		ExchangeReward? exchangeReward;
		return exchangeReward.GetValueOrDefault().MaxCount;
	}

	// Token: 0x06008812 RID: 34834 RVA: 0x00295B28 File Offset: 0x00293D28
	public int GetShareMaxCount(int id)
	{
		if (this.GetExchangeShareConfig(new int?(id)) == null)
		{
			return 0;
		}
		ExchangeShared? exchangeShared;
		return exchangeShared.GetValueOrDefault().MaxCount;
	}

	// Token: 0x06008813 RID: 34835 RVA: 0x00295B5C File Offset: 0x00293D5C
	public Dictionary<int, int> GetShareCost(int id)
	{
		ExchangeShared? exchangeShared;
		return ((this.GetExchangeShareConfig(new int?(id)) != null) ? exchangeShared.GetValueOrDefault().Cost() : null) ?? new Dictionary<int, int>();
	}

	// Token: 0x06008814 RID: 34836 RVA: 0x00295B9C File Offset: 0x00293D9C
	[NullableContext(2)]
	public Dictionary<int, int> GetExchangeCost(int id)
	{
		ExchangeReward? exchangeRewardConfig = this.GetExchangeRewardConfig(new int?(id));
		if (exchangeRewardConfig == null)
		{
			return null;
		}
		return exchangeRewardConfig.Value.Cost();
	}

	// Token: 0x06008815 RID: 34837 RVA: 0x00295BD0 File Offset: 0x00293DD0
	public int? GetExchangeShareId(int id)
	{
		ExchangeReward? exchangeRewardConfig = this.GetExchangeRewardConfig(new int?(id));
		if (exchangeRewardConfig == null)
		{
			return null;
		}
		return new int?(exchangeRewardConfig.Value.SharedId);
	}

	// Token: 0x17000F44 RID: 3908
	// (get) Token: 0x06008816 RID: 34838 RVA: 0x00295C11 File Offset: 0x00293E11
	public static ExchangeRewardConfig Instance
	{
		get
		{
			return ExchangeRewardConfig._Instance;
		}
	}

	// Token: 0x06008817 RID: 34839 RVA: 0x00295C18 File Offset: 0x00293E18
	public static ExchangeRewardConfig GetOrCreateInstance()
	{
		if (ExchangeRewardConfig._Instance == null)
		{
			ExchangeRewardConfig.CreateInstance();
		}
		return ExchangeRewardConfig._Instance;
	}

	// Token: 0x06008818 RID: 34840 RVA: 0x00295C2C File Offset: 0x00293E2C
	public static bool CreateInstance()
	{
		if (ExchangeRewardConfig._Instance != null)
		{
			return true;
		}
		ExchangeRewardConfig._Instance = new ExchangeRewardConfig();
		return true;
	}

	// Token: 0x06008819 RID: 34841 RVA: 0x00295C42 File Offset: 0x00293E42
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600881A RID: 34842 RVA: 0x00295C44 File Offset: 0x00293E44
	public static void ResetStaticDefaultValue()
	{
		ExchangeRewardConfig._Instance = null;
	}

	// Token: 0x0600881B RID: 34843 RVA: 0x00295C4C File Offset: 0x00293E4C
	static ExchangeRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExchangeRewardConfig.CreateStaticDefaultValue), new Action(ExchangeRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005213 RID: 21011
	[Nullable(2)]
	private static ExchangeRewardConfig _Instance;
}
