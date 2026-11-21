using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x02001AE4 RID: 6884
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PowerModel : ModelBase
{
	// Token: 0x1700198D RID: 6541
	// (get) Token: 0x06011140 RID: 69952 RVA: 0x00503D3C File Offset: 0x00501F3C
	public unsafe List<PowerItemInfo> PowerItemInfoList
	{
		get
		{
			if (this.PowerItemInfos == null)
			{
				Dictionary<int, int> confSortRule = PowerConfig.Instance.GetConfSortRule();
				ItemInfo?[] array = ArrayPool<ItemInfo?>.Shared.Rent(confSortRule.Keys.Count);
				try
				{
					int num = 0;
					foreach (int p0Id in confSortRule.Keys)
					{
						ItemInfo? config = ConfigItemInfoById.GetConfig(p0Id, true);
						array[num++] = config;
					}
					this.PowerItemInfos = new List<PowerItemInfo>(confSortRule.Keys.Count);
					Span<ItemInfo?> span = array.AsSpan(0, confSortRule.Keys.Count);
					for (int i = 0; i < span.Length; i++)
					{
						ItemInfo? itemInfo = *span[i];
						if (itemInfo != null)
						{
							PowerItemInfo powerItemInfo = new PowerItemInfo(itemInfo.Value.Id)
							{
								ItemName = itemInfo.Value.Name
							};
							int num2;
							if (confSortRule.TryGetValue(powerItemInfo.ItemId, out num2))
							{
								powerItemInfo.IsHideWhenZero = (num2 != 0);
							}
							this.PowerItemInfos.Add(powerItemInfo);
						}
					}
				}
				finally
				{
					ArrayPool<ItemInfo?>.Shared.Return(array, false);
				}
				List<int> confSortList = new List<int>(confSortRule.Keys);
				this.PowerItemInfos.Sort(delegate(PowerItemInfo info1, PowerItemInfo info2)
				{
					int num5 = confSortList.IndexOf(info1.ItemId);
					int num6 = confSortList.IndexOf(info2.ItemId);
					return num5 - num6;
				});
			}
			foreach (PowerItemInfo powerItemInfo2 in this.PowerItemInfos)
			{
				int? num3 = new int?(0);
				num3 = new int?(InventoryModel.Instance.GetItemCountByConfigId(powerItemInfo2.ItemId, 0));
				powerItemInfo2.StackValue = num3.GetValueOrDefault();
				List<ShopItemFullInfo> shopItemInfoByShopId = this.GetShopItemInfoByShopId(powerItemInfo2.ShopId);
				int num4 = -1;
				for (int j = 0; j < shopItemInfoByShopId.Count; j++)
				{
					ShopItemFullInfo shopItemFullInfo = shopItemInfoByShopId[j];
					if (!shopItemFullInfo.IsSoldOut() && shopItemFullInfo.Price.ContainsKey(powerItemInfo2.ItemId))
					{
						num4 = j;
						break;
					}
				}
				if (num4 == -1)
				{
					List<ShopItemFullInfo> list = shopItemInfoByShopId;
					ShopItemFullInfo shopItemFullInfo2 = list[list.Count - 1];
					powerItemInfo2.RenewValue = ((powerItemInfo2.ItemId == 6) ? 0 : shopItemFullInfo2.StackSize);
					powerItemInfo2.CostValue = shopItemFullInfo2.GetPrice(powerItemInfo2.ItemId);
					powerItemInfo2.GoodsId = shopItemFullInfo2.Id;
					powerItemInfo2.RemainCount = ((powerItemInfo2.ItemId == 6) ? powerItemInfo2.StackValue : 0);
				}
				num4 = -1;
				for (int k = 0; k < shopItemInfoByShopId.Count; k++)
				{
					ShopItemFullInfo shopItemFullInfo3 = shopItemInfoByShopId[k];
					if (shopItemFullInfo3.IsUnlocked() && !shopItemFullInfo3.IsSoldOut() && shopItemFullInfo3.Price.ContainsKey(powerItemInfo2.ItemId))
					{
						num4 = k;
						break;
					}
				}
				if (num4 >= 0)
				{
					ShopItemFullInfo shopItemFullInfo4 = shopItemInfoByShopId[num4];
					powerItemInfo2.RenewValue = ((powerItemInfo2.ItemId == 6) ? 0 : shopItemFullInfo4.StackSize);
					powerItemInfo2.CostValue = shopItemFullInfo4.GetPrice(powerItemInfo2.ItemId);
					powerItemInfo2.GoodsId = shopItemFullInfo4.Id;
					int remainCount = (shopItemFullInfo4.BuyLimit < 0) ? shopItemFullInfo4.BuyLimit : (shopItemInfoByShopId.Count - num4);
					powerItemInfo2.RemainCount = remainCount;
				}
			}
			return this.PowerItemInfos;
		}
	}

	// Token: 0x06011141 RID: 69953 RVA: 0x005040F0 File Offset: 0x005022F0
	[NullableContext(2)]
	public PowerItemInfo GetPowerItemInfos(int itemId)
	{
		foreach (PowerItemInfo powerItemInfo in this.PowerItemInfoList)
		{
			if (powerItemInfo.ItemId == itemId)
			{
				return powerItemInfo;
			}
		}
		return null;
	}

	// Token: 0x1700198E RID: 6542
	// (get) Token: 0x06011142 RID: 69954 RVA: 0x0050414C File Offset: 0x0050234C
	public bool NeedUpdateCountDown
	{
		get
		{
			return this.GetPowerDataById(5).GetNeedUpdateFlag();
		}
	}

	// Token: 0x1700198F RID: 6543
	// (get) Token: 0x06011143 RID: 69955 RVA: 0x0050415A File Offset: 0x0050235A
	public int PowerCount
	{
		get
		{
			return this.GetPowerDataById(5).GetCurrentPower();
		}
	}

	// Token: 0x17001990 RID: 6544
	// (get) Token: 0x06011144 RID: 69956 RVA: 0x00504168 File Offset: 0x00502368
	public int PowerWithConvertedCount
	{
		get
		{
			PowerData powerDataById = this.GetPowerDataById(5);
			PowerData powerDataById2 = this.GetPowerDataById(6);
			return powerDataById.GetCurrentPower() + powerDataById2.GetCurrentPower();
		}
	}

	// Token: 0x06011145 RID: 69957 RVA: 0x00504190 File Offset: 0x00502390
	protected override bool OnInit()
	{
		this.PowerItemMap[10800] = 5;
		this.PowerItemMap[6] = 6;
		this.CanShowPowerTip = true;
		return true;
	}

	// Token: 0x06011146 RID: 69958 RVA: 0x005041B8 File Offset: 0x005023B8
	protected override bool OnClear()
	{
		this.CanShowPowerTip = false;
		return true;
	}

	// Token: 0x06011147 RID: 69959 RVA: 0x005041C4 File Offset: 0x005023C4
	public void UpdatePowerRenewTimer()
	{
		foreach (KeyValuePair<int, PowerData> keyValuePair in this.PowerMap)
		{
			keyValuePair.Value.CheckPowerUpdate();
		}
	}

	// Token: 0x06011148 RID: 69960 RVA: 0x0050421C File Offset: 0x0050241C
	public void UpdatePowerData([Nullable(new byte[]
	{
		2,
		1
	})] EnergyInfo[] data)
	{
		if (data == null)
		{
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.PowerModule;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "当前体力数据";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("data", data);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (EnergyInfo data2 in data)
		{
			this.RefreshPowerInfos(data2);
		}
	}

	// Token: 0x06011149 RID: 69961 RVA: 0x00504270 File Offset: 0x00502470
	[NullableContext(2)]
	public void RefreshPowerInfos(EnergyInfo data)
	{
		if (data == null)
		{
			return;
		}
		int id = data.Id;
		this.GetPowerDataById(id).Phrase(id, data.EnergyCount, (double)data.LastRenewEnergyTime);
	}

	// Token: 0x0601114A RID: 69962 RVA: 0x005042A2 File Offset: 0x005024A2
	public bool CheckItemIfPowerItem(int itemId)
	{
		return Array.IndexOf<int>(this.PowerItemKeyArray, itemId) >= 0;
	}

	// Token: 0x0601114B RID: 69963 RVA: 0x005042B8 File Offset: 0x005024B8
	public PowerData GetPowerDataById(int itemId)
	{
		int key = itemId;
		int num;
		if (this.PowerItemMap.TryGetValue(itemId, out num))
		{
			key = num;
		}
		PowerData powerData;
		if (!this.PowerMap.TryGetValue(key, out powerData))
		{
			if (itemId == 6)
			{
				powerData = new OverPowerData();
			}
			else
			{
				powerData = new PowerData();
			}
			this.PowerMap.Add(key, powerData);
		}
		return powerData;
	}

	// Token: 0x0601114C RID: 69964 RVA: 0x0050430C File Offset: 0x0050250C
	private List<ShopItemFullInfo> GetShopItemInfoByShopId(int shopId)
	{
		List<ShopItemFullInfo> shopItemList = ShopModel.Instance.GetShopItemList(shopId);
		if (shopItemList.Count == 0)
		{
			Log.Instance.Error(ELogModule.PowerModule, ELogAuthor.LK, "体力系统获取商店数据失败", default(ReadOnlySpan<ValueTuple<string, object>>));
			return shopItemList;
		}
		shopItemList.Sort((ShopItemFullInfo info1, ShopItemFullInfo info2) => info1.Id - info2.Id);
		return shopItemList;
	}

	// Token: 0x0601114D RID: 69965 RVA: 0x00504374 File Offset: 0x00502574
	public bool IsPowerEnough(int? neededPower)
	{
		bool flag = (neededPower ?? 0) == 0;
		return flag || this.PowerCount >= neededPower.Value;
	}

	// Token: 0x0601114E RID: 69966 RVA: 0x005043B0 File Offset: 0x005025B0
	public bool IsPowerWithConvertedEnough(int? neededPower)
	{
		bool flag = (neededPower ?? 0) == 0;
		return flag || this.PowerWithConvertedCount >= neededPower.Value;
	}

	// Token: 0x0601114F RID: 69967 RVA: 0x005043EC File Offset: 0x005025EC
	public int GetCurrentNeedPower(int? neededPower)
	{
		if (this.IsPowerEnough(neededPower))
		{
			return 0;
		}
		if (neededPower == null)
		{
			return 0;
		}
		return neededPower.Value - this.PowerCount;
	}

	// Token: 0x06011150 RID: 69968 RVA: 0x00504412 File Offset: 0x00502612
	public ShopFixed? GetOverPowerShopConfig()
	{
		return ShopConfig.Instance.GetShopFixedInfoByItemId(7, 17);
	}

	// Token: 0x06011151 RID: 69969 RVA: 0x00504421 File Offset: 0x00502621
	public bool GetCanShowPowerTip()
	{
		return this.CanShowPowerTip;
	}

	// Token: 0x06011152 RID: 69970 RVA: 0x00504429 File Offset: 0x00502629
	public void SetCanShowPowerTip(bool state)
	{
		this.CanShowPowerTip = state;
	}

	// Token: 0x17001991 RID: 6545
	// (get) Token: 0x06011153 RID: 69971 RVA: 0x00504432 File Offset: 0x00502632
	public static PowerModel Instance
	{
		get
		{
			return PowerModel._Instance;
		}
	}

	// Token: 0x06011154 RID: 69972 RVA: 0x00504439 File Offset: 0x00502639
	public static PowerModel GetOrCreateInstance()
	{
		if (PowerModel._Instance == null)
		{
			PowerModel.CreateInstance();
		}
		return PowerModel._Instance;
	}

	// Token: 0x06011155 RID: 69973 RVA: 0x0050444D File Offset: 0x0050264D
	public static bool CreateInstance()
	{
		if (PowerModel._Instance != null)
		{
			return true;
		}
		PowerModel._Instance = new PowerModel();
		return true;
	}

	// Token: 0x06011156 RID: 69974 RVA: 0x00504463 File Offset: 0x00502663
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011157 RID: 69975 RVA: 0x00504465 File Offset: 0x00502665
	public static void ResetStaticDefaultValue()
	{
		PowerModel._Instance = null;
	}

	// Token: 0x06011158 RID: 69976 RVA: 0x0050446D File Offset: 0x0050266D
	static PowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PowerModel.CreateStaticDefaultValue), new Action(PowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400965C RID: 38492
	private const int OVERPOWERSHOPID = 17;

	// Token: 0x0400965D RID: 38493
	private readonly Dictionary<int, int> PowerItemMap = new Dictionary<int, int>();

	// Token: 0x0400965E RID: 38494
	public int CurrentNeedPower;

	// Token: 0x0400965F RID: 38495
	public int[] PowerItemKeyArray = new int[]
	{
		5,
		6
	};

	// Token: 0x04009660 RID: 38496
	private readonly Dictionary<int, PowerData> PowerMap = new Dictionary<int, PowerData>();

	// Token: 0x04009661 RID: 38497
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PowerItemInfo> PowerItemInfos;

	// Token: 0x04009662 RID: 38498
	private bool CanShowPowerTip = true;

	// Token: 0x04009663 RID: 38499
	[Nullable(2)]
	private static PowerModel _Instance;

	// Token: 0x02007DB1 RID: 32177
	[NullableContext(0)]
	public enum EOverPowerRecoveryMode
	{
		// Token: 0x04028B17 RID: 166679
		Update,
		// Token: 0x04028B18 RID: 166680
		Stop,
		// Token: 0x04028B19 RID: 166681
		Full
	}
}
