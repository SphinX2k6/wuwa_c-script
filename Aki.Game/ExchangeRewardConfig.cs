using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001801 RID: 6145
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ExchangeRewardConfig : ConfigBase
{
	// Token: 0x0600B423 RID: 46115 RVA: 0x0028B120 File Offset: 0x00289320
	public ExchangeReward? GetExchangeRewardConfig(int? id)
	{
		if (id == null || id.Value == 0)
		{
			return null;
		}
		return ConfigExchangeRewardById.GetConfig(id.Value, true);
	}

	// Token: 0x0600B424 RID: 46116 RVA: 0x0028B158 File Offset: 0x00289358
	public ExchangeShared? GetExchangeShareConfig(int? id)
	{
		if (id == null || id.Value == 0)
		{
			return null;
		}
		return ConfigExchangeSharedById.GetConfig(id.Value, true);
	}

	// Token: 0x0600B425 RID: 46117 RVA: 0x0028B190 File Offset: 0x00289390
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

	// Token: 0x0600B426 RID: 46118 RVA: 0x0028B3D4 File Offset: 0x002895D4
	public int GetExchangeRewardMaxCount(int id)
	{
		if (this.GetExchangeRewardConfig(new int?(id)) == null)
		{
			return 0;
		}
		ExchangeReward? exchangeReward;
		return exchangeReward.GetValueOrDefault().MaxCount;
	}

	// Token: 0x0600B427 RID: 46119 RVA: 0x0028B408 File Offset: 0x00289608
	public int GetShareMaxCount(int id)
	{
		if (this.GetExchangeShareConfig(new int?(id)) == null)
		{
			return 0;
		}
		ExchangeShared? exchangeShared;
		return exchangeShared.GetValueOrDefault().MaxCount;
	}

	// Token: 0x0600B428 RID: 46120 RVA: 0x0028B43C File Offset: 0x0028963C
	public Dictionary<int, int> GetShareCost(int id)
	{
		ExchangeShared? exchangeShared;
		return ((this.GetExchangeShareConfig(new int?(id)) != null) ? exchangeShared.GetValueOrDefault().Cost() : null) ?? new Dictionary<int, int>();
	}

	// Token: 0x0600B429 RID: 46121 RVA: 0x0028B47C File Offset: 0x0028967C
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

	// Token: 0x0600B42A RID: 46122 RVA: 0x0028B4B0 File Offset: 0x002896B0
	public int? GetExchangeShareId(int id)
	{
		ExchangeReward? exchangeRewardConfig = this.GetExchangeRewardConfig(new int?(id));
		if (exchangeRewardConfig == null)
		{
			return null;
		}
		return new int?(exchangeRewardConfig.Value.SharedId);
	}

	// Token: 0x17000F21 RID: 3873
	// (get) Token: 0x0600B42B RID: 46123 RVA: 0x0028B4F1 File Offset: 0x002896F1
	public static ExchangeRewardConfig Instance
	{
		get
		{
			return ExchangeRewardConfig._Instance;
		}
	}

	// Token: 0x0600B42C RID: 46124 RVA: 0x0028B4F8 File Offset: 0x002896F8
	public static ExchangeRewardConfig GetOrCreateInstance()
	{
		if (ExchangeRewardConfig._Instance == null)
		{
			ExchangeRewardConfig.CreateInstance();
		}
		return ExchangeRewardConfig._Instance;
	}

	// Token: 0x0600B42D RID: 46125 RVA: 0x0028B50C File Offset: 0x0028970C
	public static bool CreateInstance()
	{
		if (ExchangeRewardConfig._Instance != null)
		{
			return true;
		}
		ExchangeRewardConfig._Instance = new ExchangeRewardConfig();
		return true;
	}

	// Token: 0x0600B42E RID: 46126 RVA: 0x0028B522 File Offset: 0x00289722
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B42F RID: 46127 RVA: 0x0028B524 File Offset: 0x00289724
	public static void ResetStaticDefaultValue()
	{
		ExchangeRewardConfig._Instance = null;
	}

	// Token: 0x0600B430 RID: 46128 RVA: 0x0028B52C File Offset: 0x0028972C
	static ExchangeRewardConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExchangeRewardConfig.CreateStaticDefaultValue), new Action(ExchangeRewardConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005168 RID: 20840
	[Nullable(2)]
	private static ExchangeRewardConfig _Instance;
}
