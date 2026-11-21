using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001F72 RID: 8050
[NullableContext(1)]
[Nullable(0)]
public class ShopItemFullInfo
{
	// Token: 0x06013E8C RID: 81548 RVA: 0x005CDF64 File Offset: 0x005CC164
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

	// Token: 0x17001E1B RID: 7707
	// (get) Token: 0x06013E8D RID: 81549 RVA: 0x005CE128 File Offset: 0x005CC328
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

	// Token: 0x06013E8E RID: 81550 RVA: 0x005CE24A File Offset: 0x005CC44A
	public bool IsUnlocked()
	{
		return (this.BeginTime <= 0U || this.BeginTime <= TimeUtil.Instance.GetServerTime()) && !this.IsLocked;
	}

	// Token: 0x06013E8F RID: 81551 RVA: 0x005CE274 File Offset: 0x005CC474
	public bool InSellTime()
	{
		return this.EndTime <= 0U || (TimeUtil.Instance.GetServerTime() >= this.BeginTime && this.EndTime > TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x06013E90 RID: 81552 RVA: 0x005CE2AB File Offset: 0x005CC4AB
	public bool IsAffordable(int count = 1)
	{
		return this.DefaultPrice != null && ShopUtils.GetResource(this.DefaultPrice.CoinId) >= this.DefaultPrice.CoinPrice * count;
	}

	// Token: 0x06013E91 RID: 81553 RVA: 0x005CE2DC File Offset: 0x005CC4DC
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

	// Token: 0x06013E92 RID: 81554 RVA: 0x005CE335 File Offset: 0x005CC535
	public bool IsOutOfDate()
	{
		return this.EndTime > 0U && this.EndTime < TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x06013E93 RID: 81555 RVA: 0x005CE357 File Offset: 0x005CC557
	public bool IsSoldOut()
	{
		return this.BuyLimit > 0 && this.BoughtCount == this.BuyLimit;
	}

	// Token: 0x06013E94 RID: 81556 RVA: 0x005CE374 File Offset: 0x005CC574
	public bool InSaleTime()
	{
		if (this.BeginTime > 0U && this.EndTime > 0U)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			return this.BeginTime < serverTime && serverTime < this.EndTime;
		}
		return false;
	}

	// Token: 0x06013E95 RID: 81557 RVA: 0x005CE3B8 File Offset: 0x005CC5B8
	public bool IsOutOfStock()
	{
		return (this.BuyLimit > 0 && this.BoughtCount == this.BuyLimit) || (this.EndTime > 0U && this.EndTime < TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x06013E96 RID: 81558 RVA: 0x005CE3F3 File Offset: 0x005CC5F3
	public bool IsInteractive()
	{
		return this.IsUnlocked() && !this.IsOutOfStock();
	}

	// Token: 0x06013E97 RID: 81559 RVA: 0x005CE408 File Offset: 0x005CC608
	public int GetMoneyId()
	{
		if (this.DefaultPrice == null)
		{
			return -1;
		}
		return this.DefaultPrice.CoinId;
	}

	// Token: 0x06013E98 RID: 81560 RVA: 0x005CE41F File Offset: 0x005CC61F
	public int GetDefaultPrice()
	{
		if (this.DefaultPrice == null)
		{
			return -1;
		}
		return this.DefaultPrice.CoinPrice;
	}

	// Token: 0x06013E99 RID: 81561 RVA: 0x005CE438 File Offset: 0x005CC638
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

	// Token: 0x06013E9A RID: 81562 RVA: 0x005CE474 File Offset: 0x005CC674
	public int GetOriginalPrice()
	{
		if (this.DefaultPrice == null)
		{
			return -1;
		}
		return this.DefaultPrice.OriginalPrice;
	}

	// Token: 0x0400A9A9 RID: 43433
	public ItemConfig ItemInfo;

	// Token: 0x0400A9AA RID: 43434
	public readonly int ItemId;

	// Token: 0x0400A9AB RID: 43435
	public int BoughtCount;

	// Token: 0x0400A9AC RID: 43436
	public int BuyLimit;

	// Token: 0x0400A9AD RID: 43437
	public int StackSize;

	// Token: 0x0400A9AE RID: 43438
	[Nullable(2)]
	public ItemPrice DefaultPrice;

	// Token: 0x0400A9AF RID: 43439
	public Dictionary<int, ItemPrice> Price = new Dictionary<int, ItemPrice>();

	// Token: 0x0400A9B0 RID: 43440
	public uint BeginTime;

	// Token: 0x0400A9B1 RID: 43441
	public uint EndTime;

	// Token: 0x0400A9B2 RID: 43442
	public bool IsLocked;

	// Token: 0x0400A9B3 RID: 43443
	public string ConditionText = "";

	// Token: 0x0400A9B4 RID: 43444
	public int Id;

	// Token: 0x0400A9B5 RID: 43445
	public int ShopId;

	// Token: 0x0400A9B6 RID: 43446
	public string Label;

	// Token: 0x0400A9B7 RID: 43447
	public string SwitchText;

	// Token: 0x0400A9B8 RID: 43448
	public string PurchaseText;

	// Token: 0x0400A9B9 RID: 43449
	public int SortIndex;
}
