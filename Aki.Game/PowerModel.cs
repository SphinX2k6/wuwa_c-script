using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

// Token: 0x020025F9 RID: 9721
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PowerModel : ModelBase
{
	// Token: 0x17001955 RID: 6485
	// (get) Token: 0x06013C5E RID: 80990 RVA: 0x004F4FB0 File Offset: 0x004F31B0
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
				List<int> confSortList = confSortRule.Keys.ToList<int>();
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

	// Token: 0x06013C5F RID: 80991 RVA: 0x004F5364 File Offset: 0x004F3564
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

	// Token: 0x17001956 RID: 6486
	// (get) Token: 0x06013C60 RID: 80992 RVA: 0x004F53C0 File Offset: 0x004F35C0
	public bool NeedUpdateCountDown
	{
		get
		{
			return this.GetPowerDataById(5).GetNeedUpdateFlag();
		}
	}

	// Token: 0x17001957 RID: 6487
	// (get) Token: 0x06013C61 RID: 80993 RVA: 0x004F53CE File Offset: 0x004F35CE
	public int PowerCount
	{
		get
		{
			return this.GetPowerDataById(5).GetCurrentPower();
		}
	}

	// Token: 0x17001958 RID: 6488
	// (get) Token: 0x06013C62 RID: 80994 RVA: 0x004F53DC File Offset: 0x004F35DC
	public int PowerWithConvertedCount
	{
		get
		{
			PowerData powerDataById = this.GetPowerDataById(5);
			PowerData powerDataById2 = this.GetPowerDataById(6);
			return powerDataById.GetCurrentPower() + powerDataById2.GetCurrentPower();
		}
	}

	// Token: 0x06013C63 RID: 80995 RVA: 0x004F5404 File Offset: 0x004F3604
	protected override bool OnInit()
	{
		this.PowerItemMap[10800] = 5;
		this.PowerItemMap[6] = 6;
		this.CanShowPowerTip = true;
		return true;
	}

	// Token: 0x06013C64 RID: 80996 RVA: 0x004F542C File Offset: 0x004F362C
	protected override bool OnClear()
	{
		this.CanShowPowerTip = false;
		return true;
	}

	// Token: 0x06013C65 RID: 80997 RVA: 0x004F5438 File Offset: 0x004F3638
	public void UpdatePowerRenewTimer()
	{
		foreach (KeyValuePair<int, PowerData> keyValuePair in this.PowerMap)
		{
			keyValuePair.Value.CheckPowerUpdate();
		}
	}

	// Token: 0x06013C66 RID: 80998 RVA: 0x004F5490 File Offset: 0x004F3690
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

	// Token: 0x06013C67 RID: 80999 RVA: 0x004F54E4 File Offset: 0x004F36E4
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

	// Token: 0x06013C68 RID: 81000 RVA: 0x004F5516 File Offset: 0x004F3716
	public bool CheckItemIfPowerItem(int itemId)
	{
		return this.PowerItemKeyArray.Contains(itemId);
	}

	// Token: 0x06013C69 RID: 81001 RVA: 0x004F5524 File Offset: 0x004F3724
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

	// Token: 0x06013C6A RID: 81002 RVA: 0x004F5578 File Offset: 0x004F3778
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

	// Token: 0x06013C6B RID: 81003 RVA: 0x004F55E0 File Offset: 0x004F37E0
	public bool IsPowerEnough(int? neededPower)
	{
		bool flag = (neededPower ?? 0) == 0;
		return flag || this.PowerCount >= neededPower.Value;
	}

	// Token: 0x06013C6C RID: 81004 RVA: 0x004F561C File Offset: 0x004F381C
	public bool IsPowerWithConvertedEnough(int? neededPower)
	{
		bool flag = (neededPower ?? 0) == 0;
		return flag || this.PowerWithConvertedCount >= neededPower.Value;
	}

	// Token: 0x06013C6D RID: 81005 RVA: 0x004F5658 File Offset: 0x004F3858
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

	// Token: 0x06013C6E RID: 81006 RVA: 0x004F567E File Offset: 0x004F387E
	public ShopFixed? GetOverPowerShopConfig()
	{
		return ShopConfig.Instance.GetShopFixedInfoByItemId(7, 17);
	}

	// Token: 0x06013C6F RID: 81007 RVA: 0x004F568D File Offset: 0x004F388D
	public bool GetCanShowPowerTip()
	{
		return this.CanShowPowerTip;
	}

	// Token: 0x06013C70 RID: 81008 RVA: 0x004F5695 File Offset: 0x004F3895
	public void SetCanShowPowerTip(bool state)
	{
		this.CanShowPowerTip = state;
	}

	// Token: 0x17001959 RID: 6489
	// (get) Token: 0x06013C71 RID: 81009 RVA: 0x004F569E File Offset: 0x004F389E
	public static PowerModel Instance
	{
		get
		{
			return PowerModel._Instance;
		}
	}

	// Token: 0x06013C72 RID: 81010 RVA: 0x004F56A5 File Offset: 0x004F38A5
	public static PowerModel GetOrCreateInstance()
	{
		if (PowerModel._Instance == null)
		{
			PowerModel.CreateInstance();
		}
		return PowerModel._Instance;
	}

	// Token: 0x06013C73 RID: 81011 RVA: 0x004F56B9 File Offset: 0x004F38B9
	public static bool CreateInstance()
	{
		if (PowerModel._Instance != null)
		{
			return true;
		}
		PowerModel._Instance = new PowerModel();
		return true;
	}

	// Token: 0x06013C74 RID: 81012 RVA: 0x004F56CF File Offset: 0x004F38CF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013C75 RID: 81013 RVA: 0x004F56D1 File Offset: 0x004F38D1
	public static void ResetStaticDefaultValue()
	{
		PowerModel._Instance = null;
	}

	// Token: 0x06013C76 RID: 81014 RVA: 0x004F56D9 File Offset: 0x004F38D9
	static PowerModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PowerModel.CreateStaticDefaultValue), new Action(PowerModel.ResetStaticDefaultValue));
	}

	// Token: 0x04009505 RID: 38149
	private const int OVERPOWERSHOPID = 17;

	// Token: 0x04009506 RID: 38150
	private readonly Dictionary<int, int> PowerItemMap = new Dictionary<int, int>();

	// Token: 0x04009507 RID: 38151
	public int CurrentNeedPower;

	// Token: 0x04009508 RID: 38152
	public int[] PowerItemKeyArray = new int[]
	{
		5,
		6
	};

	// Token: 0x04009509 RID: 38153
	private readonly Dictionary<int, PowerData> PowerMap = new Dictionary<int, PowerData>();

	// Token: 0x0400950A RID: 38154
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PowerItemInfo> PowerItemInfos;

	// Token: 0x0400950B RID: 38155
	private bool CanShowPowerTip = true;

	// Token: 0x0400950C RID: 38156
	[Nullable(2)]
	private static PowerModel _Instance;

	// Token: 0x02008C28 RID: 35880
	[NullableContext(0)]
	public enum EOverPowerRecoveryMode
	{
		// Token: 0x0402D7FF RID: 186367
		Update,
		// Token: 0x0402D800 RID: 186368
		Stop,
		// Token: 0x0402D801 RID: 186369
		Full
	}
}
