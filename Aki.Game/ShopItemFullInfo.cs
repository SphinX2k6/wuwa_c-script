using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x020029F7 RID: 10743
[NullableContext(1)]
[Nullable(0)]
public class ShopItemFullInfo
{
	// Token: 0x06016485 RID: 91269 RVA: 0x005A2F8C File Offset: 0x005A118C
	public ShopItemFullInfo(ItemConfig itemInfo, ShopItemInfoNew boughtInfo, int shopId)
	{
		this.ItemInfo = itemInfo;
		this.BoughtCount = boughtInfo.BoughtCount;
		this.IsLocked = boughtInfo.Lock;
		this.BuyLimit = boughtInfo.LimitNum;
		this.StackSize = boughtInfo.ItemNum;
		for (int i = 0; i < boughtInfo.MoneyList.Count; i++)
		{
			ShoppMoneyInfo shoppMoneyInfo = boughtInfo.MoneyList[i];
			ShoppMoneyInfo shoppMoneyInfo2 = null;
			foreach (ShoppMoneyInfo shoppMoneyInfo3 in boughtInfo.OriginalMoneyList)
			{
				if (shoppMoneyInfo3.MoneyId == shoppMoneyInfo.MoneyId)
				{
					shoppMoneyInfo2 = shoppMoneyInfo3;
					break;
				}
			}
			ItemPrice itemPrice = new ItemPrice(shoppMoneyInfo.MoneyId, shoppMoneyInfo.MoneyNum, (shoppMoneyInfo2 != null) ? shoppMoneyInfo2.MoneyNum : -1);
			this.Price[shoppMoneyInfo.MoneyId] = itemPrice;
			if (i == 0)
			{
				this.DefaultPrice = itemPrice;
			}
		}
		this.Id = boughtInfo.Id;
		this.Label = boughtInfo.Label;
		this.BeginTime = boughtInfo.BeginTime;
		this.EndTime = boughtInfo.EndTime;
		if (boughtInfo.UnlockConditionId != 0)
		{
			ConditionGroup? conditionGroupConfig = ConditionConfig.Instance.GetConditionGroupConfig(boughtInfo.UnlockConditionId);
			this.ConditionText = (((conditionGroupConfig != null) ? conditionGroupConfig.GetValueOrDefault().HintText : null) ?? "");
		}
		this.SwitchText = boughtInfo.SwitchText;
		this.PurchaseText = boughtInfo.PurchaseText;
		this.ItemId = boughtInfo.ItemId;
		this.ShopId = shopId;
		this.SortIndex = boughtInfo.SortIndex;
	}

	// Token: 0x17001DC2 RID: 7618
	// (get) Token: 0x06016486 RID: 91270 RVA: 0x005A3150 File Offset: 0x005A1350
	public string LockInfo
	{
		get
		{
			if (this.BeginTime > 0U && this.BeginTime > TimeUtil.Instance.GetServerTime())
			{
				int num = (int)Math.Truncate(this.BeginTime - TimeUtil.Instance.GetServerTime());
				int num2 = num / 86400;
				int num3 = num % 86400 / 3600;
				int num4 = num % 3600 / 60;
				int num5 = num % 60;
				if (num2 > 0)
				{
					return StringUtils.Format(TextConfig.Instance.GetTextById("ShopLockTime1"), new string[]
					{
						num2.ToString()
					});
				}
				if (num3 > 0)
				{
					return StringUtils.Format(TextConfig.Instance.GetTextById("ShopLockTime2"), new string[]
					{
						num3.ToString()
					});
				}
				if (num4 > 0)
				{
					return StringUtils.Format(TextConfig.Instance.GetTextById("ShopLockTime3"), new string[]
					{
						num4.ToString()
					});
				}
				return StringUtils.Format(TextConfig.Instance.GetTextById("ShopLockTime4"), new string[]
				{
					num5.ToString()
				});
			}
			else
			{
				if (this.IsLocked)
				{
					return this.ConditionText;
				}
				return "";
			}
		}
	}

	// Token: 0x06016487 RID: 91271 RVA: 0x005A3272 File Offset: 0x005A1472
	public bool IsUnlocked()
	{
		return (this.BeginTime <= 0U || this.BeginTime <= TimeUtil.Instance.GetServerTime()) && !this.IsLocked;
	}

	// Token: 0x06016488 RID: 91272 RVA: 0x005A329C File Offset: 0x005A149C
	public bool InSellTime()
	{
		return this.EndTime <= 0U || (TimeUtil.Instance.GetServerTime() >= this.BeginTime && this.EndTime > TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x06016489 RID: 91273 RVA: 0x005A32D3 File Offset: 0x005A14D3
	public bool IsAffordable(int count = 1)
	{
		return this.DefaultPrice != null && ShopUtils.GetResource(this.DefaultPrice.CoinId) >= this.DefaultPrice.CoinPrice * count;
	}

	// Token: 0x0601648A RID: 91274 RVA: 0x005A3304 File Offset: 0x005A1504
	public int GetMaxBuyCount()
	{
		if (this.DefaultPrice == null)
		{
			return -1;
		}
		int num = (int)Math.Truncate((double)(ShopUtils.GetResource(this.DefaultPrice.CoinId) / this.DefaultPrice.CoinPrice));
		if (this.BuyLimit > 0)
		{
			return Math.Min(this.BuyLimit - this.BoughtCount, num);
		}
		return num;
	}

	// Token: 0x0601648B RID: 91275 RVA: 0x005A335D File Offset: 0x005A155D
	public bool IsOutOfDate()
	{
		return this.EndTime > 0U && this.EndTime < TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x0601648C RID: 91276 RVA: 0x005A337F File Offset: 0x005A157F
	public bool IsSoldOut()
	{
		return this.BuyLimit > 0 && this.BoughtCount == this.BuyLimit;
	}

	// Token: 0x0601648D RID: 91277 RVA: 0x005A339C File Offset: 0x005A159C
	public bool InSaleTime()
	{
		if (this.BeginTime > 0U && this.EndTime > 0U)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.BeginTime < serverTime && serverTime < this.EndTime;
		}
		return false;
	}

	// Token: 0x0601648E RID: 91278 RVA: 0x005A33E0 File Offset: 0x005A15E0
	public bool IsOutOfStock()
	{
		return (this.BuyLimit > 0 && this.BoughtCount == this.BuyLimit) || (this.EndTime > 0U && this.EndTime < TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x0601648F RID: 91279 RVA: 0x005A341B File Offset: 0x005A161B
	public bool IsInteractive()
	{
		return this.IsUnlocked() && !this.IsOutOfStock();
	}

	// Token: 0x06016490 RID: 91280 RVA: 0x005A3430 File Offset: 0x005A1630
	public int GetMoneyId()
	{
		if (this.DefaultPrice == null)
		{
			return -1;
		}
		return this.DefaultPrice.CoinId;
	}

	// Token: 0x06016491 RID: 91281 RVA: 0x005A3447 File Offset: 0x005A1647
	public int GetDefaultPrice()
	{
		if (this.DefaultPrice == null)
		{
			return -1;
		}
		return this.DefaultPrice.CoinPrice;
	}

	// Token: 0x06016492 RID: 91282 RVA: 0x005A3460 File Offset: 0x005A1660
	public int GetPrice(int moneyId)
	{
		if (this.Price == null || this.Price.Count == 0)
		{
			return -1;
		}
		ItemPrice itemPrice;
		if (this.Price.TryGetValue(moneyId, out itemPrice))
		{
			return itemPrice.CoinPrice;
		}
		return 0;
	}

	// Token: 0x06016493 RID: 91283 RVA: 0x005A349C File Offset: 0x005A169C
	public int GetOriginalPrice()
	{
		if (this.DefaultPrice == null)
		{
			return -1;
		}
		return this.DefaultPrice.OriginalPrice;
	}

	// Token: 0x0400A5BF RID: 42431
	public ItemConfig ItemInfo;

	// Token: 0x0400A5C0 RID: 42432
	public readonly int ItemId;

	// Token: 0x0400A5C1 RID: 42433
	public int BoughtCount;

	// Token: 0x0400A5C2 RID: 42434
	public int BuyLimit;

	// Token: 0x0400A5C3 RID: 42435
	public int StackSize;

	// Token: 0x0400A5C4 RID: 42436
	[Nullable(2)]
	public ItemPrice DefaultPrice;

	// Token: 0x0400A5C5 RID: 42437
	public Dictionary<int, ItemPrice> Price = new Dictionary<int, ItemPrice>();

	// Token: 0x0400A5C6 RID: 42438
	public uint BeginTime;

	// Token: 0x0400A5C7 RID: 42439
	public uint EndTime;

	// Token: 0x0400A5C8 RID: 42440
	public bool IsLocked;

	// Token: 0x0400A5C9 RID: 42441
	public string ConditionText = "";

	// Token: 0x0400A5CA RID: 42442
	public int Id;

	// Token: 0x0400A5CB RID: 42443
	public int ShopId;

	// Token: 0x0400A5CC RID: 42444
	public string Label;

	// Token: 0x0400A5CD RID: 42445
	public string SwitchText;

	// Token: 0x0400A5CE RID: 42446
	public string PurchaseText;

	// Token: 0x0400A5CF RID: 42447
	public int SortIndex;
}
