using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001885 RID: 6277
[NullableContext(1)]
[Nullable(0)]
public class WeekCardData
{
	// Token: 0x0600F88C RID: 63628 RVA: 0x0048B99C File Offset: 0x00489B9C
	public WeekCardData(WeekCardInfo info)
	{
		this.Update(info);
	}

	// Token: 0x0600F88D RID: 63629 RVA: 0x0048B9B8 File Offset: 0x00489BB8
	public void Update(WeekCardInfo info)
	{
		this.WeekCardIdInner = info.WeekCardId;
		this.DaysInner = info.Days;
		this.BuyTimeStampInner = info.BuyTimeStamp;
		this.EndTimeStampInner = info.EndTimeStamp;
		this.WeekCardContentInfosInner = new List<WeekCardContentInfo>(info.WeekCardContentInfos);
	}

	// Token: 0x170017DF RID: 6111
	// (get) Token: 0x0600F88E RID: 63630 RVA: 0x0048BA06 File Offset: 0x00489C06
	public int WeekCardId
	{
		get
		{
			return this.WeekCardIdInner;
		}
	}

	// Token: 0x170017E0 RID: 6112
	// (get) Token: 0x0600F88F RID: 63631 RVA: 0x0048BA0E File Offset: 0x00489C0E
	public int Days
	{
		get
		{
			return this.DaysInner;
		}
	}

	// Token: 0x170017E1 RID: 6113
	// (get) Token: 0x0600F890 RID: 63632 RVA: 0x0048BA16 File Offset: 0x00489C16
	public long BuyTimeStamp
	{
		get
		{
			return this.BuyTimeStampInner;
		}
	}

	// Token: 0x170017E2 RID: 6114
	// (get) Token: 0x0600F891 RID: 63633 RVA: 0x0048BA1E File Offset: 0x00489C1E
	public long EndTimeStamp
	{
		get
		{
			return this.EndTimeStampInner;
		}
	}

	// Token: 0x0600F892 RID: 63634 RVA: 0x0048BA26 File Offset: 0x00489C26
	public WeekCardContentInfo GetWeekCardContentInfo(int index)
	{
		return this.WeekCardContentInfosInner[index];
	}

	// Token: 0x0600F893 RID: 63635 RVA: 0x0048BA34 File Offset: 0x00489C34
	public List<WeekCardContentInfo> GetAllWeekCardContentInfos()
	{
		return this.WeekCardContentInfosInner;
	}

	// Token: 0x0600F894 RID: 63636 RVA: 0x0048BA3C File Offset: 0x00489C3C
	[NullableContext(2)]
	public PayPackageData GetWeekCardGiftData()
	{
		WeekCard? config = WeekCardConfig.Instance.GetConfig(this.WeekCardIdInner);
		if (config == null)
		{
			return null;
		}
		foreach (PayPackageData payPackageData in PayGiftModel.Instance.GetPayGiftDataByType(EPayGiftType.WeekCard))
		{
			if (payPackageData.Id == config.Value.PayGiftId)
			{
				return payPackageData;
			}
		}
		return null;
	}

	// Token: 0x0600F895 RID: 63637 RVA: 0x0048BACC File Offset: 0x00489CCC
	public long GetActivityBeginTime()
	{
		PayPackageData weekCardGiftData = this.GetWeekCardGiftData();
		if (weekCardGiftData == null)
		{
			return 0L;
		}
		return weekCardGiftData.BeginTime;
	}

	// Token: 0x0600F896 RID: 63638 RVA: 0x0048BAE0 File Offset: 0x00489CE0
	public long GetActivityEndTime()
	{
		PayPackageData weekCardGiftData = this.GetWeekCardGiftData();
		if (weekCardGiftData == null)
		{
			return 0L;
		}
		return weekCardGiftData.EndTime;
	}

	// Token: 0x0600F897 RID: 63639 RVA: 0x0048BAF4 File Offset: 0x00489CF4
	public bool GetIsWeekCardBuyOpen()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return (double)this.GetActivityEndTime() > serverTime && serverTime >= (double)this.GetActivityBeginTime();
	}

	// Token: 0x0600F898 RID: 63640 RVA: 0x0048BB25 File Offset: 0x00489D25
	public bool GetHasBuyWeekCard()
	{
		return this.EndTimeStampInner > 0L;
	}

	// Token: 0x0600F899 RID: 63641 RVA: 0x0048BB31 File Offset: 0x00489D31
	public bool GetIsWeekCardInRewardStage()
	{
		return this.GetHasBuyWeekCard() && TimeUtil.Instance.SetTimeSecond((double)this.EndTimeStampInner) > TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x0600F89A RID: 63642 RVA: 0x0048BB5C File Offset: 0x00489D5C
	public bool HasRewardUnReceive()
	{
		if (!this.GetIsWeekCardInRewardStage())
		{
			return false;
		}
		using (List<WeekCardContentInfo>.Enumerator enumerator = this.WeekCardContentInfosInner.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Status == 1)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x0600F89B RID: 63643 RVA: 0x0048BBC0 File Offset: 0x00489DC0
	public bool GetWeekCardRedDotState()
	{
		if (!this.HasRewardUnReceive())
		{
			PayPackageData weekCardGiftData = this.GetWeekCardGiftData();
			bool? flag;
			if (weekCardGiftData == null)
			{
				flag = null;
			}
			else
			{
				PayShopGoods payShopGoods = weekCardGiftData.GetPayShopGoods();
				flag = ((payShopGoods != null) ? new bool?(payShopGoods.GetIfNeedRemind()) : null);
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}
		return true;
	}

	// Token: 0x0600F89C RID: 63644 RVA: 0x0048BC12 File Offset: 0x00489E12
	public bool GetWeekCardIsOpen()
	{
		if (this.GetHasBuyWeekCard())
		{
			return this.GetIsWeekCardInRewardStage();
		}
		return this.GetIsWeekCardBuyOpen();
	}

	// Token: 0x04008B0B RID: 35595
	private int WeekCardIdInner;

	// Token: 0x04008B0C RID: 35596
	private int DaysInner;

	// Token: 0x04008B0D RID: 35597
	private long BuyTimeStampInner;

	// Token: 0x04008B0E RID: 35598
	private long EndTimeStampInner;

	// Token: 0x04008B0F RID: 35599
	private List<WeekCardContentInfo> WeekCardContentInfosInner = new List<WeekCardContentInfo>();
}
