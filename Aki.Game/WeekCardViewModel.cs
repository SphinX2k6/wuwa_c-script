using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.PayShop;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x020023AF RID: 9135
[NullableContext(2)]
[Nullable(0)]
public class WeekCardViewModel
{
	// Token: 0x06012449 RID: 74825 RVA: 0x0047FB16 File Offset: 0x0047DD16
	public WeekCardViewModel(EWeekCardKind kind)
	{
		this.Kind = kind;
	}

	// Token: 0x0601244A RID: 74826 RVA: 0x0047FB25 File Offset: 0x0047DD25
	private ActivityNewPlayerSupportActivityV2Controller GetNewPlayerActivityController()
	{
		return ActivityManager.GetActivityController(ActivityType.NewPlayerSupportActivityV2) as ActivityNewPlayerSupportActivityV2Controller;
	}

	// Token: 0x0601244B RID: 74827 RVA: 0x0047FB34 File Offset: 0x0047DD34
	private int ResolveTargetWeekCardId()
	{
		List<WeekCard> configListByKind = WeekCardConfig.Instance.GetConfigListByKind(this.Kind);
		if (configListByKind.Count == 0)
		{
			return 0;
		}
		if (configListByKind.Count == 1)
		{
			return configListByKind[0].Id;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		foreach (WeekCard weekCard in configListByKind)
		{
			WeekCardData byId = WeekCardModel.Instance.GetById(weekCard.Id);
			if (byId != null && byId.GetIsWeekCardInRewardStage())
			{
				return weekCard.Id;
			}
		}
		foreach (WeekCard weekCard2 in configListByKind)
		{
			PayPackageData payGiftDataById = PayGiftModel.Instance.GetPayGiftDataById(weekCard2.PayGiftId);
			if (payGiftDataById != null && serverTime >= (double)payGiftDataById.BeginTime && (double)payGiftDataById.EndTime > serverTime)
			{
				return weekCard2.Id;
			}
		}
		return configListByKind[0].Id;
	}

	// Token: 0x0601244C RID: 74828 RVA: 0x0047FC6C File Offset: 0x0047DE6C
	public int GetTargetWeekCardId()
	{
		return this.ResolveTargetWeekCardId();
	}

	// Token: 0x0601244D RID: 74829 RVA: 0x0047FC74 File Offset: 0x0047DE74
	public WeekCardData GetTargetCard()
	{
		int num = this.ResolveTargetWeekCardId();
		if (num == 0)
		{
			return null;
		}
		return WeekCardModel.Instance.GetById(num);
	}

	// Token: 0x0601244E RID: 74830 RVA: 0x0047FC98 File Offset: 0x0047DE98
	private PayPackageData GetTargetPayGift()
	{
		int num = this.ResolveTargetWeekCardId();
		if (num == 0)
		{
			return null;
		}
		WeekCard? config = WeekCardConfig.Instance.GetConfig(num);
		if (config == null)
		{
			return null;
		}
		return PayGiftModel.Instance.GetPayGiftDataById(config.Value.PayGiftId);
	}

	// Token: 0x0601244F RID: 74831 RVA: 0x0047FCE4 File Offset: 0x0047DEE4
	private bool IsConfigBuyOpen()
	{
		PayPackageData targetPayGift = this.GetTargetPayGift();
		if (targetPayGift == null)
		{
			return false;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		return serverTime >= (double)targetPayGift.BeginTime && (double)targetPayGift.EndTime > serverTime;
	}

	// Token: 0x06012450 RID: 74832 RVA: 0x0047FD1E File Offset: 0x0047DF1E
	public bool IsBuy()
	{
		WeekCardData targetCard = this.GetTargetCard();
		return targetCard != null && targetCard.GetHasBuyWeekCard();
	}

	// Token: 0x06012451 RID: 74833 RVA: 0x0047FD31 File Offset: 0x0047DF31
	public bool IsBuyOpen()
	{
		return this.IsConfigBuyOpen();
	}

	// Token: 0x06012452 RID: 74834 RVA: 0x0047FD39 File Offset: 0x0047DF39
	public bool IsInRewardStage()
	{
		WeekCardData targetCard = this.GetTargetCard();
		return targetCard != null && targetCard.GetIsWeekCardInRewardStage();
	}

	// Token: 0x06012453 RID: 74835 RVA: 0x0047FD4C File Offset: 0x0047DF4C
	public bool IsKindOpen()
	{
		if (this.IsBuy())
		{
			return this.IsInRewardStage();
		}
		return this.IsConfigBuyOpen();
	}

	// Token: 0x06012454 RID: 74836 RVA: 0x0047FD64 File Offset: 0x0047DF64
	public double GetCountDownLeftSec()
	{
		WeekCardData targetCard = this.GetTargetCard();
		if (targetCard != null && targetCard.GetHasBuyWeekCard())
		{
			return TimeUtil.Instance.SetTimeSecond((double)targetCard.EndTimeStamp) - TimeUtil.Instance.GetServerTime();
		}
		if (this.Kind == EWeekCardKind.NewPlayer)
		{
			ActivityNewPlayerSupportActivityV2Controller newPlayerActivityController = this.GetNewPlayerActivityController();
			ActivityNewPlayerSupportActivityV2Data activityNewPlayerSupportActivityV2Data = (newPlayerActivityController != null) ? newPlayerActivityController.ActivityData : null;
			if (activityNewPlayerSupportActivityV2Data == null)
			{
				return 0.0;
			}
			return (double)activityNewPlayerSupportActivityV2Data.GetDisplayRemainEndTime() - TimeUtil.Instance.GetServerTime();
		}
		else
		{
			PayPackageData targetPayGift = this.GetTargetPayGift();
			if (targetPayGift == null)
			{
				return 0.0;
			}
			return (double)targetPayGift.EndTime - TimeUtil.Instance.GetServerTime();
		}
	}

	// Token: 0x06012455 RID: 74837 RVA: 0x0047FE02 File Offset: 0x0047E002
	[NullableContext(1)]
	public string GetCountDownTextKey()
	{
		if (!this.IsBuy())
		{
			return "WeekCard_1004";
		}
		return "WeekCard_1005";
	}

	// Token: 0x06012456 RID: 74838 RVA: 0x0047FE18 File Offset: 0x0047E018
	public WeekCardContentInfo GetWeekCardContentInfo(int index)
	{
		WeekCardData targetCard = this.GetTargetCard();
		if (targetCard == null)
		{
			return null;
		}
		List<WeekCardContentInfo> allWeekCardContentInfos = targetCard.GetAllWeekCardContentInfos();
		if (index < 0 || index >= allWeekCardContentInfos.Count)
		{
			return null;
		}
		return targetCard.GetWeekCardContentInfo(index);
	}

	// Token: 0x06012457 RID: 74839 RVA: 0x0047FE50 File Offset: 0x0047E050
	public string GetContentRewardTexturePath(int contentId)
	{
		WeekCardContent? weekCardContent;
		string text = (WeekCardConfig.Instance.GetContentConfig(contentId) != null) ? weekCardContent.GetValueOrDefault().RewardTexture : null;
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return text;
	}

	// Token: 0x06012458 RID: 74840 RVA: 0x0047FE90 File Offset: 0x0047E090
	[NullableContext(1)]
	public List<IWeekCostData> GetTotalRewardData()
	{
		WeekCardData targetCard = this.GetTargetCard();
		List<WeekCardContentInfo> list = ((targetCard != null) ? targetCard.GetAllWeekCardContentInfos() : null) ?? new List<WeekCardContentInfo>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		foreach (WeekCardContentInfo weekCardContentInfo in list)
		{
			foreach (KeyValuePair<int, int> keyValuePair in weekCardContentInfo.RewardContent)
			{
				int key = keyValuePair.Key;
				int value = keyValuePair.Value;
				if (dictionary.ContainsKey(key))
				{
					Dictionary<int, int> dictionary2 = dictionary;
					int key2 = key;
					dictionary2[key2] += value;
				}
				else
				{
					dictionary[key] = value;
				}
			}
		}
		List<IWeekCostData> list2 = new List<IWeekCostData>();
		foreach (KeyValuePair<int, int> keyValuePair2 in dictionary)
		{
			list2.Add(new WeekCostData
			{
				ItemId = keyValuePair2.Key,
				Count = keyValuePair2.Value,
				Tips = ""
			});
		}
		list2.Sort((IWeekCostData a, IWeekCostData b) => a.ItemId - b.ItemId);
		return list2;
	}

	// Token: 0x06012459 RID: 74841 RVA: 0x00480004 File Offset: 0x0047E204
	public IWeekScoreData GetSendCostItemData()
	{
		PayPackageData targetPayGift = this.GetTargetPayGift();
		if (targetPayGift == null)
		{
			return null;
		}
		TotalTopUpController instance = TotalTopUpController.Instance;
		if (instance == null)
		{
			return null;
		}
		TotalTopUpData singleActivityData = instance.GetSingleActivityData();
		if (singleActivityData == null)
		{
			return null;
		}
		string totalUpScoreIcon = TotalTopUpConfig.Instance.GetTotalUpScoreIcon(singleActivityData.Id);
		if (string.IsNullOrEmpty(totalUpScoreIcon))
		{
			return null;
		}
		PayShopGoods payShopGoods = targetPayGift.GetPayShopGoods();
		if (payShopGoods == null)
		{
			return null;
		}
		int goodsScore = instance.GetGoodsScore(payShopGoods.GetGoodsData().Id);
		if (goodsScore <= 0)
		{
			return null;
		}
		return new WeekScoreData
		{
			Tips = "WeekCard_1009",
			IconPath = totalUpScoreIcon,
			Count = goodsScore
		};
	}

	// Token: 0x0601245A RID: 74842 RVA: 0x00480097 File Offset: 0x0047E297
	[NullableContext(1)]
	public string GetPrice()
	{
		PayPackageData targetPayGift = this.GetTargetPayGift();
		PayShopGoods payShopGoods = (targetPayGift != null) ? targetPayGift.GetPayShopGoods() : null;
		return ((payShopGoods != null) ? payShopGoods.GetDirectPriceText() : null) ?? "";
	}

	// Token: 0x0601245B RID: 74843 RVA: 0x004800C0 File Offset: 0x0047E2C0
	[NullableContext(1)]
	public string GetBuyButtonText()
	{
		if (!this.IsBuy())
		{
			return "WeekCard_1007";
		}
		return "WeekCard_1008";
	}

	// Token: 0x0601245C RID: 74844 RVA: 0x004800D8 File Offset: 0x0047E2D8
	public int? GetHelpGroupId()
	{
		int num = this.ResolveTargetWeekCardId();
		if (num == 0)
		{
			return null;
		}
		WeekCard? config = WeekCardConfig.Instance.GetConfig(num);
		if (config == null)
		{
			return null;
		}
		return new int?(config.Value.HelpGroupId);
	}

	// Token: 0x0601245D RID: 74845 RVA: 0x0048012C File Offset: 0x0047E32C
	public string GetTitleTextKey()
	{
		int num = this.ResolveTargetWeekCardId();
		if (num == 0)
		{
			return null;
		}
		WeekCard? weekCard;
		string text = (WeekCardConfig.Instance.GetConfig(num) != null) ? weekCard.GetValueOrDefault().Title : null;
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return text;
	}

	// Token: 0x0601245E RID: 74846 RVA: 0x00480178 File Offset: 0x0047E378
	public string GetDiscountTexturePath()
	{
		int num = this.ResolveTargetWeekCardId();
		if (num == 0)
		{
			return null;
		}
		WeekCard? weekCard;
		string text = (WeekCardConfig.Instance.GetConfig(num) != null) ? weekCard.GetValueOrDefault().DiscountTexture : null;
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return text;
	}

	// Token: 0x0601245F RID: 74847 RVA: 0x004801C4 File Offset: 0x0047E3C4
	public bool GetRedDotState()
	{
		WeekCardData targetCard = this.GetTargetCard();
		return targetCard != null && targetCard.GetWeekCardRedDotState();
	}

	// Token: 0x06012460 RID: 74848 RVA: 0x004801D8 File Offset: 0x0047E3D8
	public int? GetPayGiftId()
	{
		PayPackageData targetPayGift = this.GetTargetPayGift();
		if (targetPayGift == null)
		{
			return null;
		}
		return new int?(targetPayGift.Id);
	}

	// Token: 0x06012461 RID: 74849 RVA: 0x00480204 File Offset: 0x0047E404
	public int? GetPayShopGoodsId()
	{
		PayPackageData targetPayGift = this.GetTargetPayGift();
		if (targetPayGift == null)
		{
			return null;
		}
		PayShopGoods payShopGoods = targetPayGift.GetPayShopGoods();
		if (payShopGoods == null)
		{
			return null;
		}
		return new int?(payShopGoods.GetGoodsId());
	}

	// Token: 0x06012462 RID: 74850 RVA: 0x00480244 File Offset: 0x0047E444
	[NullableContext(0)]
	public UniTask<bool> RequestInfo()
	{
		WeekCardViewModel.<RequestInfo>d__26 <RequestInfo>d__;
		<RequestInfo>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestInfo>d__.<>4__this = this;
		<RequestInfo>d__.<>1__state = -1;
		<RequestInfo>d__.<>t__builder.Start<WeekCardViewModel.<RequestInfo>d__26>(ref <RequestInfo>d__);
		return <RequestInfo>d__.<>t__builder.Task;
	}

	// Token: 0x06012463 RID: 74851 RVA: 0x00480288 File Offset: 0x0047E488
	public void OnBuy()
	{
		int num = this.ResolveTargetWeekCardId();
		if (num != 0)
		{
			WeekCardConfig.Instance.GetConfig(num);
		}
		int? payGiftId = this.GetPayGiftId();
		if (payGiftId == null)
		{
			return;
		}
		PayGiftController.Instance.SdkPay(payGiftId.Value);
	}

	// Token: 0x06012464 RID: 74852 RVA: 0x004802D0 File Offset: 0x0047E4D0
	[NullableContext(0)]
	public UniTask<bool> OnReceiveReward(int contentId)
	{
		WeekCardViewModel.<OnReceiveReward>d__28 <OnReceiveReward>d__;
		<OnReceiveReward>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<OnReceiveReward>d__.contentId = contentId;
		<OnReceiveReward>d__.<>1__state = -1;
		<OnReceiveReward>d__.<>t__builder.Start<WeekCardViewModel.<OnReceiveReward>d__28>(ref <OnReceiveReward>d__);
		return <OnReceiveReward>d__.<>t__builder.Task;
	}

	// Token: 0x06012465 RID: 74853 RVA: 0x00480313 File Offset: 0x0047E513
	public void OnAfterShow()
	{
		PayPackageData targetPayGift = this.GetTargetPayGift();
		PayShopGoods payShopGoods = (targetPayGift != null) ? targetPayGift.GetPayShopGoods() : null;
		if (payShopGoods == null)
		{
			return;
		}
		payShopGoods.SaveRemindState((long)TimeUtil.Instance.GetServerTime());
	}

	// Token: 0x040089EF RID: 35311
	private readonly EWeekCardKind Kind;
}
