using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PayShop;

// Token: 0x020023A0 RID: 9120
[NullableContext(1)]
[Nullable(0)]
public class WeekCardData
{
	// Token: 0x060123DA RID: 74714 RVA: 0x0047E504 File Offset: 0x0047C704
	public WeekCardData(WeekCardInfo info)
	{
		this.Update(info);
	}

	// Token: 0x060123DB RID: 74715 RVA: 0x0047E520 File Offset: 0x0047C720
	public void Update(WeekCardInfo info)
	{
		this.WeekCardIdInner = info.WeekCardId;
		this.DaysInner = info.Days;
		this.BuyTimeStampInner = info.BuyTimeStamp;
		this.EndTimeStampInner = info.EndTimeStamp;
		this.WeekCardContentInfosInner = new List<WeekCardContentInfo>(info.WeekCardContentInfos);
	}

	// Token: 0x170017A5 RID: 6053
	// (get) Token: 0x060123DC RID: 74716 RVA: 0x0047E56E File Offset: 0x0047C76E
	public int WeekCardId
	{
		get
		{
			return this.WeekCardIdInner;
		}
	}

	// Token: 0x170017A6 RID: 6054
	// (get) Token: 0x060123DD RID: 74717 RVA: 0x0047E576 File Offset: 0x0047C776
	public int Days
	{
		get
		{
			return this.DaysInner;
		}
	}

	// Token: 0x170017A7 RID: 6055
	// (get) Token: 0x060123DE RID: 74718 RVA: 0x0047E57E File Offset: 0x0047C77E
	public long BuyTimeStamp
	{
		get
		{
			return this.BuyTimeStampInner;
		}
	}

	// Token: 0x170017A8 RID: 6056
	// (get) Token: 0x060123DF RID: 74719 RVA: 0x0047E586 File Offset: 0x0047C786
	public long EndTimeStamp
	{
		get
		{
			return this.EndTimeStampInner;
		}
	}

	// Token: 0x060123E0 RID: 74720 RVA: 0x0047E58E File Offset: 0x0047C78E
	public WeekCardContentInfo GetWeekCardContentInfo(int index)
	{
		return this.WeekCardContentInfosInner[index];
	}

	// Token: 0x060123E1 RID: 74721 RVA: 0x0047E59C File Offset: 0x0047C79C
	public List<WeekCardContentInfo> GetAllWeekCardContentInfos()
	{
		return this.WeekCardContentInfosInner;
	}

	// Token: 0x060123E2 RID: 74722 RVA: 0x0047E5A4 File Offset: 0x0047C7A4
	[NullableContext(2)]
	public PayPackageData GetWeekCardGiftData()
	{
		WeekCard? config = WeekCardConfig.Instance.GetConfig(this.WeekCardIdInner);
		if (config == null)
		{
			return null;
		}
		return PayGiftModel.Instance.GetPayGiftDataByType(EPayGiftType.WeekCard).FirstOrDefault((PayPackageData g) => g.Id == config.Value.PayGiftId);
	}

	// Token: 0x060123E3 RID: 74723 RVA: 0x0047E5F8 File Offset: 0x0047C7F8
	public long GetActivityBeginTime()
	{
		PayPackageData weekCardGiftData = this.GetWeekCardGiftData();
		if (weekCardGiftData == null)
		{
			return 0L;
		}
		return weekCardGiftData.BeginTime;
	}

	// Token: 0x060123E4 RID: 74724 RVA: 0x0047E60C File Offset: 0x0047C80C
	public long GetActivityEndTime()
	{
		PayPackageData weekCardGiftData = this.GetWeekCardGiftData();
		if (weekCardGiftData == null)
		{
			return 0L;
		}
		return weekCardGiftData.EndTime;
	}

	// Token: 0x060123E5 RID: 74725 RVA: 0x0047E620 File Offset: 0x0047C820
	public bool GetIsWeekCardBuyOpen()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return (double)this.GetActivityEndTime() > serverTime && serverTime >= (double)this.GetActivityBeginTime();
	}

	// Token: 0x060123E6 RID: 74726 RVA: 0x0047E651 File Offset: 0x0047C851
	public bool GetHasBuyWeekCard()
	{
		return this.EndTimeStampInner > 0L;
	}

	// Token: 0x060123E7 RID: 74727 RVA: 0x0047E65D File Offset: 0x0047C85D
	public bool GetIsWeekCardInRewardStage()
	{
		return this.GetHasBuyWeekCard() && TimeUtil.Instance.SetTimeSecond((double)this.EndTimeStampInner) > TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x060123E8 RID: 74728 RVA: 0x0047E688 File Offset: 0x0047C888
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

	// Token: 0x060123E9 RID: 74729 RVA: 0x0047E6EC File Offset: 0x0047C8EC
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

	// Token: 0x060123EA RID: 74730 RVA: 0x0047E73E File Offset: 0x0047C93E
	public bool GetWeekCardIsOpen()
	{
		if (this.GetHasBuyWeekCard())
		{
			return this.GetIsWeekCardInRewardStage();
		}
		return this.GetIsWeekCardBuyOpen();
	}

	// Token: 0x040089C4 RID: 35268
	private int WeekCardIdInner;

	// Token: 0x040089C5 RID: 35269
	private int DaysInner;

	// Token: 0x040089C6 RID: 35270
	private long BuyTimeStampInner;

	// Token: 0x040089C7 RID: 35271
	private long EndTimeStampInner;

	// Token: 0x040089C8 RID: 35272
	private List<WeekCardContentInfo> WeekCardContentInfosInner = new List<WeekCardContentInfo>();
}
