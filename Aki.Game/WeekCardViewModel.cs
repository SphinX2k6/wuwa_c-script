using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.PayShop;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001894 RID: 6292
[NullableContext(2)]
[Nullable(0)]
public class WeekCardViewModel
{
	// Token: 0x0600F8FB RID: 63739 RVA: 0x0048CFEA File Offset: 0x0048B1EA
	public WeekCardViewModel(EWeekCardKind kind)
	{
		this.Kind = kind;
	}

	// Token: 0x0600F8FC RID: 63740 RVA: 0x0048CFF9 File Offset: 0x0048B1F9
	private ActivityNewPlayerSupportActivityV2Controller GetNewPlayerActivityController()
	{
		return ActivityManager.GetActivityController(ActivityType.NewPlayerSupportActivityV2) as ActivityNewPlayerSupportActivityV2Controller;
	}

	// Token: 0x0600F8FD RID: 63741 RVA: 0x0048D008 File Offset: 0x0048B208
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

	// Token: 0x0600F8FE RID: 63742 RVA: 0x0048D140 File Offset: 0x0048B340
	public int GetTargetWeekCardId()
	{
		return this.ResolveTargetWeekCardId();
	}

	// Token: 0x0600F8FF RID: 63743 RVA: 0x0048D148 File Offset: 0x0048B348
	public WeekCardData GetTargetCard()
	{
		int num = this.ResolveTargetWeekCardId();
		if (num == 0)
		{
			return null;
		}
		return WeekCardModel.Instance.GetById(num);
	}

	// Token: 0x0600F900 RID: 63744 RVA: 0x0048D16C File Offset: 0x0048B36C
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

	// Token: 0x0600F901 RID: 63745 RVA: 0x0048D1B8 File Offset: 0x0048B3B8
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

	// Token: 0x0600F902 RID: 63746 RVA: 0x0048D1F2 File Offset: 0x0048B3F2
	public bool IsBuy()
	{
		WeekCardData targetCard = this.GetTargetCard();
		return targetCard != null && targetCard.GetHasBuyWeekCard();
	}

	// Token: 0x0600F903 RID: 63747 RVA: 0x0048D205 File Offset: 0x0048B405
	public bool IsBuyOpen()
	{
		return this.IsConfigBuyOpen();
	}

	// Token: 0x0600F904 RID: 63748 RVA: 0x0048D20D File Offset: 0x0048B40D
	public bool IsInRewardStage()
	{
		WeekCardData targetCard = this.GetTargetCard();
		return targetCard != null && targetCard.GetIsWeekCardInRewardStage();
	}

	// Token: 0x0600F905 RID: 63749 RVA: 0x0048D220 File Offset: 0x0048B420
	public bool IsKindOpen()
	{
		if (this.IsBuy())
		{
			return this.IsInRewardStage();
		}
		return this.IsConfigBuyOpen();
	}

	// Token: 0x0600F906 RID: 63750 RVA: 0x0048D238 File Offset: 0x0048B438
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

	// Token: 0x0600F907 RID: 63751 RVA: 0x0048D2D6 File Offset: 0x0048B4D6
	[NullableContext(1)]
	public string GetCountDownTextKey()
	{
		if (!this.IsBuy())
		{
			return "WeekCard_1004";
		}
		return "WeekCard_1005";
	}

	// Token: 0x0600F908 RID: 63752 RVA: 0x0048D2EC File Offset: 0x0048B4EC
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

	// Token: 0x0600F909 RID: 63753 RVA: 0x0048D324 File Offset: 0x0048B524
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

	// Token: 0x0600F90A RID: 63754 RVA: 0x0048D364 File Offset: 0x0048B564
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

	// Token: 0x0600F90B RID: 63755 RVA: 0x0048D4D8 File Offset: 0x0048B6D8
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

	// Token: 0x0600F90C RID: 63756 RVA: 0x0048D56B File Offset: 0x0048B76B
	[NullableContext(1)]
	public string GetPrice()
	{
		PayPackageData targetPayGift = this.GetTargetPayGift();
		PayShopGoods payShopGoods = (targetPayGift != null) ? targetPayGift.GetPayShopGoods() : null;
		return ((payShopGoods != null) ? payShopGoods.GetDirectPriceText() : null) ?? "";
	}

	// Token: 0x0600F90D RID: 63757 RVA: 0x0048D594 File Offset: 0x0048B794
	[NullableContext(1)]
	public string GetBuyButtonText()
	{
		if (!this.IsBuy())
		{
			return "WeekCard_1007";
		}
		return "WeekCard_1008";
	}

	// Token: 0x0600F90E RID: 63758 RVA: 0x0048D5AC File Offset: 0x0048B7AC
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

	// Token: 0x0600F90F RID: 63759 RVA: 0x0048D600 File Offset: 0x0048B800
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

	// Token: 0x0600F910 RID: 63760 RVA: 0x0048D64C File Offset: 0x0048B84C
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

	// Token: 0x0600F911 RID: 63761 RVA: 0x0048D698 File Offset: 0x0048B898
	public bool GetRedDotState()
	{
		WeekCardData targetCard = this.GetTargetCard();
		return targetCard != null && targetCard.GetWeekCardRedDotState();
	}

	// Token: 0x0600F912 RID: 63762 RVA: 0x0048D6AC File Offset: 0x0048B8AC
	public int? GetPayGiftId()
	{
		PayPackageData targetPayGift = this.GetTargetPayGift();
		if (targetPayGift == null)
		{
			return null;
		}
		return new int?(targetPayGift.Id);
	}

	// Token: 0x0600F913 RID: 63763 RVA: 0x0048D6D8 File Offset: 0x0048B8D8
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

	// Token: 0x0600F914 RID: 63764 RVA: 0x0048D718 File Offset: 0x0048B918
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

	// Token: 0x0600F915 RID: 63765 RVA: 0x0048D75C File Offset: 0x0048B95C
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

	// Token: 0x0600F916 RID: 63766 RVA: 0x0048D7A4 File Offset: 0x0048B9A4
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

	// Token: 0x0600F917 RID: 63767 RVA: 0x0048D7E7 File Offset: 0x0048B9E7
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

	// Token: 0x04008B36 RID: 35638
	private readonly EWeekCardKind Kind;
}
