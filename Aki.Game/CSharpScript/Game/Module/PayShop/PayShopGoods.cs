using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02004338 RID: 17208
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PayShopGoods : PayShopUnionData<PayShopGoodsData>
	{
		// Token: 0x0602B71A RID: 177946 RVA: 0x00C357E4 File Offset: 0x00C339E4
		public PayShopGoods(PayShopDefine.EPayShopTabType payShopId)
		{
			this.PayShopId = payShopId;
		}

		// Token: 0x0602B71B RID: 177947 RVA: 0x00C357FA File Offset: 0x00C339FA
		public void SetPayShopId(PayShopDefine.EPayShopTabType payShopId)
		{
			this.PayShopId = payShopId;
		}

		// Token: 0x0602B71C RID: 177948 RVA: 0x00C35803 File Offset: 0x00C33A03
		public void SetGoodsData(PayShopGoodsData data)
		{
			this.Data = data;
			this.IsOnSell = this.InSellTime();
			this.CachePayShopItemBaseSt = new PayShopItemBaseSt();
			this.CachePayShopItemBaseSt.PhraseFromPayItemData(this);
		}

		// Token: 0x0602B71D RID: 177949 RVA: 0x00C3582F File Offset: 0x00C33A2F
		public void SetPayGiftId(int id)
		{
			this.PayGiftId = id;
		}

		// Token: 0x0602B71E RID: 177950 RVA: 0x00C35838 File Offset: 0x00C33A38
		[NullableContext(2)]
		public PayPackageData GetGetPayGiftData()
		{
			return PayGiftModel.Instance.GetPayGiftDataById(this.PayGiftId);
		}

		// Token: 0x0602B71F RID: 177951 RVA: 0x00C3584A File Offset: 0x00C33A4A
		[NullableContext(2)]
		public PayShopGoodsData GetGoodsData()
		{
			return this.Data;
		}

		// Token: 0x0602B720 RID: 177952 RVA: 0x00C35852 File Offset: 0x00C33A52
		public bool IsLocked()
		{
			return this.Data.Locked;
		}

		// Token: 0x0602B721 RID: 177953 RVA: 0x00C35860 File Offset: 0x00C33A60
		public string GetConditionTextId()
		{
			int buyConditionId = this.Data.GetBuyConditionId();
			if (buyConditionId != 0)
			{
				return LevelGeneralCommons.GetConditionGroupHintText(buyConditionId) ?? "";
			}
			return "";
		}

		// Token: 0x0602B722 RID: 177954 RVA: 0x00C35891 File Offset: 0x00C33A91
		public int GetDiscountLabel()
		{
			return this.Data.LabelId;
		}

		// Token: 0x0602B723 RID: 177955 RVA: 0x00C358A0 File Offset: 0x00C33AA0
		public IItemData GetItemData()
		{
			InventoryConfig instance = InventoryConfig.Instance;
			int itemId = this.Data.ItemId;
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = instance.GetItemConfigData(itemId);
			int quality = (this.Data.ShopItemQuality > 0) ? this.Data.ShopItemQuality : itemConfigData.QualityId;
			EItemQualityType qualityType = (this.Data.ShopItemQuality > 0) ? EItemQualityType.PayShop : EItemQualityType.Item;
			return new ItemData
			{
				Quality = quality,
				ItemId = itemId,
				Name = itemConfigData.Name,
				QualityType = qualityType
			};
		}

		// Token: 0x0602B724 RID: 177956 RVA: 0x00C35920 File Offset: 0x00C33B20
		public bool IfPayGift()
		{
			return this.Data.IfPayGift();
		}

		// Token: 0x0602B725 RID: 177957 RVA: 0x00C35930 File Offset: 0x00C33B30
		public IPriceData GetPriceData()
		{
			int availableCouponDiscount = this.GetAvailableCouponDiscount();
			int num = Math.Max(this.Data.GetNowPrice() - availableCouponDiscount, 0);
			int? originalPrice = this.Data.GetOriginalPrice();
			if (originalPrice == null && availableCouponDiscount > 0)
			{
				originalPrice = new int?(num + availableCouponDiscount);
			}
			int currencyId = this.Data.Price.Id;
			int num2 = InventoryModel.Instance.GetItemCountByConfigId(currencyId, 0) - num;
			return new PriceData
			{
				OwnNumber = (() => InventoryModel.Instance.GetItemCountByConfigId(currencyId, 0)),
				NowPrice = num,
				OriginalPrice = originalPrice,
				CurrencyId = currencyId,
				Enough = (num2 >= 0),
				InDiscountTime = this.Data.HasDiscount()
			};
		}

		// Token: 0x0602B726 RID: 177958 RVA: 0x00C359FC File Offset: 0x00C33BFC
		public string GetDirectPriceText()
		{
			KuroSdkModel instance = KuroSdkModel.Instance;
			string text = (instance != null) ? instance.GetQueryProductShowPrice(this.Data.Price.Id.ToString()) : null;
			if (text != null)
			{
				return text;
			}
			int id = this.Data.Price.Id;
			return PayItemConfig.Instance.GetPayShow(id);
		}

		// Token: 0x0602B727 RID: 177959 RVA: 0x00C35A54 File Offset: 0x00C33C54
		[NullableContext(2)]
		public IRemainingData GetRemainingData()
		{
			if (!this.Data.HasBuyLimit())
			{
				return null;
			}
			int remainingCount = this.Data.GetRemainingCount();
			return new RemainingData(this.Data.GetRemainingTextId(), remainingCount);
		}

		// Token: 0x0602B728 RID: 177960 RVA: 0x00C35A8D File Offset: 0x00C33C8D
		public void SetUnLock()
		{
			this.Data.SetUnLock();
		}

		// Token: 0x0602B729 RID: 177961 RVA: 0x00C35A9A File Offset: 0x00C33C9A
		public int GetDiscount()
		{
			return this.Data.GetDiscount();
		}

		// Token: 0x0602B72A RID: 177962 RVA: 0x00C35AA8 File Offset: 0x00C33CA8
		public int GetDiscountNew()
		{
			PayPackageData getPayGiftData = this.GetGetPayGiftData();
			if (getPayGiftData != null)
			{
				return getPayGiftData.GetDiscount() / 100;
			}
			return this.Data.GetDiscountNew();
		}

		// Token: 0x0602B72B RID: 177963 RVA: 0x00C35AD4 File Offset: 0x00C33CD4
		public bool HasDiscount()
		{
			PayPackageData getPayGiftData = this.GetGetPayGiftData();
			if (getPayGiftData != null)
			{
				return getPayGiftData.HasDiscount();
			}
			return this.Data.HasDiscount();
		}

		// Token: 0x0602B72C RID: 177964 RVA: 0x00C35B00 File Offset: 0x00C33D00
		public bool IsPermanentDiscount()
		{
			return (this.Data.EndPromotionTime == 0L && this.Data.BeginPromotionTime == 0L) || (this.Data.EndPromotionTime == 0L && TimeUtil.Instance.GetServerTime() >= (double)this.Data.BeginTime);
		}

		// Token: 0x0602B72D RID: 177965 RVA: 0x00C35B54 File Offset: 0x00C33D54
		public bool IsPermanentSell()
		{
			return (this.Data.BeginTime == 0L && this.Data.EndTime == 0L) || (TimeUtil.Instance.GetServerTime() >= (double)this.Data.BeginTime && this.Data.EndTime == 0L);
		}

		// Token: 0x0602B72E RID: 177966 RVA: 0x00C35BA8 File Offset: 0x00C33DA8
		public bool InSellTime()
		{
			return this.IsPermanentSell() || ((double)this.Data.EndTime > TimeUtil.Instance.GetServerTime() && TimeUtil.Instance.GetServerTime() >= (double)this.Data.BeginTime);
		}

		// Token: 0x0602B72F RID: 177967 RVA: 0x00C35BF4 File Offset: 0x00C33DF4
		public bool HasShowTime()
		{
			return this.Data.ShowBeginTime > 0L;
		}

		// Token: 0x0602B730 RID: 177968 RVA: 0x00C35C08 File Offset: 0x00C33E08
		public bool InShowTime()
		{
			if (!this.HasShowTime())
			{
				return true;
			}
			double serverTime = TimeUtil.Instance.GetServerTime();
			return (double)this.Data.ShowEndTime > serverTime && serverTime >= (double)this.Data.ShowBeginTime;
		}

		// Token: 0x0602B731 RID: 177969 RVA: 0x00C35C4D File Offset: 0x00C33E4D
		public bool IsShowTimePreview()
		{
			return this.HasShowTime() && this.InShowTime() && !this.InSellTime();
		}

		// Token: 0x0602B732 RID: 177970 RVA: 0x00C35C6A File Offset: 0x00C33E6A
		public bool InLabelShowTime()
		{
			return this.Data.InLabelShowTime();
		}

		// Token: 0x0602B733 RID: 177971 RVA: 0x00C35C78 File Offset: 0x00C33E78
		public bool InUnPermanentSellTime()
		{
			return !this.IsPermanentSell() && (double)this.Data.EndTime > TimeUtil.Instance.GetServerTime() && TimeUtil.Instance.GetServerTime() >= (double)this.Data.BeginTime;
		}

		// Token: 0x0602B734 RID: 177972 RVA: 0x00C35CC4 File Offset: 0x00C33EC4
		public bool WillSell()
		{
			return !this.IsOnSell && TimeUtil.Instance.GetServerTime() < (double)this.Data.BeginTime;
		}

		// Token: 0x0602B735 RID: 177973 RVA: 0x00C35CEC File Offset: 0x00C33EEC
		public CommonDefine.IPayShowCountDownRemainTime GetDiscountTimeData()
		{
			long endPromotionTime = this.Data.EndPromotionTime;
			return new CommonDefine.PayShowCountDownRemainTime<string>
			{
				Value = PayShopGoods.GetEndTimeShowText(endPromotionTime)
			};
		}

		// Token: 0x0602B736 RID: 177974 RVA: 0x00C35D18 File Offset: 0x00C33F18
		public CommonDefine.IRemainTime GetDiscountRemainTime()
		{
			double time = (double)this.Data.EndPromotionTime - TimeUtil.Instance.GetServerTime();
			CommonDefine.IRemainTime remainTime = TimeUtil.Instance.CalculateRemainingTime(time, CommonDefine.ETimeType.Minute);
			if (remainTime == null)
			{
				remainTime = new CommonDefine.RemainTime
				{
					TimeValue = 0,
					RemainingTime = 0.0 + TimeUtil.Instance.TimeDeviation,
					TextId = CommonDefine.remainTimeTextId[CommonDefine.ETimeType.Minute]
				};
			}
			return remainTime;
		}

		// Token: 0x0602B737 RID: 177975 RVA: 0x00C35D88 File Offset: 0x00C33F88
		public CommonDefine.ICountDown GetDiscountCountDown()
		{
			double time = (double)this.Data.EndPromotionTime - TimeUtil.Instance.GetServerTime();
			return TimeUtil.Instance.GetCountDownData(time, null, null);
		}

		// Token: 0x0602B738 RID: 177976 RVA: 0x00C35DCC File Offset: 0x00C33FCC
		public CommonDefine.IPayShowCountDownRemainTime GetUpdateTimeRemainData()
		{
			long updateTime = this.Data.UpdateTime;
			return new CommonDefine.PayShowCountDownRemainTime<string>
			{
				Value = PayShopGoods.GetEndTimeShowText(updateTime)
			};
		}

		// Token: 0x0602B739 RID: 177977 RVA: 0x00C35DF6 File Offset: 0x00C33FF6
		public long GetUpdateRemainTime()
		{
			return (long)((double)this.Data.UpdateTime - TimeUtil.Instance.GetServerTime() + TimeUtil.Instance.TimeDeviation);
		}

		// Token: 0x0602B73A RID: 177978 RVA: 0x00C35E1B File Offset: 0x00C3401B
		public bool InUpdateTime()
		{
			return this.Data.HasBuyLimit() && this.Data.UpdateTime != 0L && (double)this.Data.UpdateTime > TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0602B73B RID: 177979 RVA: 0x00C35E53 File Offset: 0x00C34053
		public bool NeedDown()
		{
			if (this.IsOnSell && !this.IsPermanentSell() && !this.InUnPermanentSellTime())
			{
				this.IsOnSell = false;
				return true;
			}
			return false;
		}

		// Token: 0x0602B73C RID: 177980 RVA: 0x00C35E78 File Offset: 0x00C34078
		public bool NeedUpdate()
		{
			if (this.InSellTime() && !this.IsOnSell)
			{
				this.IsOnSell = true;
				return true;
			}
			return this.Data.HasBuyLimit() && this.Data.UpdateTime != 0L && (double)this.Data.UpdateTime <= TimeUtil.Instance.GetServerTime() && this.InSellTime();
		}

		// Token: 0x0602B73D RID: 177981 RVA: 0x00C35EDC File Offset: 0x00C340DC
		[NullableContext(2)]
		public static string GetEndTimeShowText(long endTime)
		{
			double serverTime = TimeUtil.Instance.GetServerTime();
			double num = Math.Max((double)endTime - serverTime, 0.0);
			ValueTuple<int, int> timeTypeData = PayShopGoods.GetTimeTypeData((long)num);
			if (timeTypeData.Item1 == 0)
			{
				return TextConfig.Instance.GetTextById("NotEnoughOneHour");
			}
			return TimeUtil.Instance.GetCountDownDataFormat2(num, new CommonDefine.ETimeType?((CommonDefine.ETimeType)timeTypeData.Item1), new CommonDefine.ETimeType?((CommonDefine.ETimeType)timeTypeData.Item2)).CountDownText;
		}

		// Token: 0x0602B73E RID: 177982 RVA: 0x00C35F4D File Offset: 0x00C3414D
		[NullableContext(0)]
		public static ValueTuple<int, int> GetTimeTypeData(long remainTime)
		{
			if (remainTime > 86400L)
			{
				return new ValueTuple<int, int>(3, 2);
			}
			if (remainTime > 3600L)
			{
				return new ValueTuple<int, int>(2, 2);
			}
			return new ValueTuple<int, int>(0, 0);
		}

		// Token: 0x0602B73F RID: 177983 RVA: 0x00C35F78 File Offset: 0x00C34178
		public CommonDefine.IRemainTime GetTimeRemainData(long time)
		{
			double time2 = (double)time - TimeUtil.Instance.GetServerTime();
			CommonDefine.IRemainTime remainTime = TimeUtil.Instance.CalculateRemainingTime(time2, CommonDefine.ETimeType.Minute);
			if (remainTime == null)
			{
				remainTime = new CommonDefine.RemainTime
				{
					TimeValue = 0,
					RemainingTime = 0.0,
					TextId = CommonDefine.remainTimeTextId[CommonDefine.ETimeType.Minute]
				};
			}
			return remainTime;
		}

		// Token: 0x0602B740 RID: 177984 RVA: 0x00C35FD4 File Offset: 0x00C341D4
		public CommonDefine.IPayShowCountDownRemainTime GetEndTimeRemainData()
		{
			long endTime = this.Data.EndTime;
			return new CommonDefine.PayShowCountDownRemainTime<string>
			{
				Value = PayShopGoods.GetEndTimeShowText(endTime)
			};
		}

		// Token: 0x0602B741 RID: 177985 RVA: 0x00C36000 File Offset: 0x00C34200
		[NullableContext(2)]
		public string GetDownTipsText()
		{
			if (this.CheckIfMonthCardItem())
			{
				return TextConfig.Instance.GetTextById("MonthlyCardMax");
			}
			if (this.IsLimitGoods() && this.IsSoldOut())
			{
				return TextConfig.Instance.GetTextById("SoldOut");
			}
			if (!this.IfCanBuy())
			{
				InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.GetGoodsData().ItemId));
				if (Array.IndexOf<int>(this.GetGoodsData().GetItemConfig().ShowTypes, 30) >= 0 || itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
				{
					return TextConfig.Instance.GetTextById("Text_Shop_Role_Text");
				}
				string conditionTextId = this.GetConditionTextId();
				if (!StringUtils.IsEmpty(conditionTextId))
				{
					return ConfigMultiTextLang.GetLocalTextNew(conditionTextId, null);
				}
			}
			return "";
		}

		// Token: 0x0602B742 RID: 177986 RVA: 0x00C360B2 File Offset: 0x00C342B2
		[NullableContext(2)]
		public string GetConditionLimitText()
		{
			if (!this.Data.GetIfCanBuy())
			{
				return this.Data.GetUnFinishConditionText();
			}
			return "";
		}

		// Token: 0x0602B743 RID: 177987 RVA: 0x00C360D4 File Offset: 0x00C342D4
		[NullableContext(2)]
		public string GetExtraLimitText()
		{
			if (this.CheckIfMonthCardItem())
			{
				return "Text_MonthlyCardMax_Text";
			}
			if (this.GetCantBuyReason() != PayShopDefine.EPayShopCantBuyReason.Other)
			{
				return null;
			}
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.GetGoodsData().ItemId));
			if (Array.IndexOf<int>(this.GetGoodsData().GetItemConfig().ShowTypes, 30) < 0 && itemDataTypeByConfigId != InventoryDefine.EItemDataType.RoleItem)
			{
				return this.GetConditionTextId();
			}
			int id;
			if (Array.IndexOf<int>(this.GetGoodsData().GetItemConfig().ShowTypes, 30) >= 0)
			{
				id = RoleModel.Instance.GetResonantItemRoleId(this.GetGoodsData().ItemId)[0];
			}
			else
			{
				id = this.GetGoodsData().ItemId;
			}
			if (RoleModel.Instance.GetRoleInstanceById(id) == null)
			{
				return "DontHaveRole";
			}
			return "RoleBrenchItemMax";
		}

		// Token: 0x0602B744 RID: 177988 RVA: 0x00C36197 File Offset: 0x00C34397
		public bool GetIfNeedExtraLimitText()
		{
			if (this.CheckIfMonthCardItem())
			{
				return !MonthCardModel.Instance.IsRemainDayInMaxLimit();
			}
			return this.GetCantBuyReason() == PayShopDefine.EPayShopCantBuyReason.Other;
		}

		// Token: 0x0602B745 RID: 177989 RVA: 0x00C361BC File Offset: 0x00C343BC
		public bool GetIfNeedShowDownTipsText()
		{
			return (this.CheckIfMonthCardItem() && MonthCardModel.Instance.GetRemainDays() > ConfigCommonParamById.GetIntConfig("MonthCardMaxDays").Value) || (this.IsLimitGoods() && this.IsSoldOut()) || !this.IfCanBuy();
		}

		// Token: 0x0602B746 RID: 177990 RVA: 0x00C36210 File Offset: 0x00C34410
		public string GetSpriteTextBgColor()
		{
			if (this.CheckIfMonthCardItem() && MonthCardModel.Instance.GetRemainDays() > ConfigCommonParamById.GetIntConfig("MonthCardMaxDays").Value)
			{
				return "3E3E3BFF";
			}
			if (this.IsLimitGoods() && this.IsSoldOut())
			{
				return "6C6C6CFF";
			}
			return "F9F9F9FF";
		}

		// Token: 0x0602B747 RID: 177991 RVA: 0x00C36264 File Offset: 0x00C34464
		public string GetTextTipsColor()
		{
			if (this.CheckIfMonthCardItem() && MonthCardModel.Instance.GetRemainDays() > ConfigCommonParamById.GetIntConfig("MonthCardMaxDays").Value)
			{
				return "F9F9F9FF";
			}
			if (this.IsLimitGoods() && this.IsSoldOut())
			{
				return "F9F9F9FF";
			}
			return "181818FF";
		}

		// Token: 0x0602B748 RID: 177992 RVA: 0x00C362B8 File Offset: 0x00C344B8
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double> GetCountDownData()
		{
			CommonDefine.IPayShowCountDownRemainTime payShowCountDownRemainTime = null;
			EPayCountTimeType item = EPayCountTimeType.Default;
			double num = 0.0;
			if (payShowCountDownRemainTime == null && this.IsLimitGoods() && this.GetGoodsData().IsWeeklyRefresh() && this.GetRemainingData().Count == 0 && this.GetGoodsData().IfMayReSell())
			{
				payShowCountDownRemainTime = this.GetUpdateTimeRemainData();
				item = EPayCountTimeType.Resell;
				CommonDefine.IRemainTime timeRemainData = this.GetTimeRemainData(this.Data.UpdateTime);
				num = ((timeRemainData != null) ? timeRemainData.RemainingTime : 0.0);
			}
			if (payShowCountDownRemainTime != null)
			{
				return new ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double>(item, payShowCountDownRemainTime, num);
			}
			if (this.HasDiscount())
			{
				num = this.GetTimeRemainData(this.Data.EndPromotionTime).RemainingTime;
				if (num > 0.0)
				{
					payShowCountDownRemainTime = this.GetDiscountTimeData();
					item = EPayCountTimeType.Discount;
				}
			}
			if (payShowCountDownRemainTime != null)
			{
				return new ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double>(item, payShowCountDownRemainTime, num);
			}
			payShowCountDownRemainTime = this.GetEndTimeRemainData();
			item = EPayCountTimeType.NeverResell;
			CommonDefine.IRemainTime timeRemainData2 = this.GetTimeRemainData(this.Data.EndTime);
			num = ((timeRemainData2 != null) ? timeRemainData2.RemainingTime : 0.0);
			return new ValueTuple<EPayCountTimeType, CommonDefine.IPayShowCountDownRemainTime, double>(item, payShowCountDownRemainTime, num);
		}

		// Token: 0x0602B749 RID: 177993 RVA: 0x00C363B8 File Offset: 0x00C345B8
		public string GetResellText()
		{
			string result = "";
			if (this.IsLimitGoods() && this.GetGoodsData().IsWeeklyRefresh())
			{
				if (this.GetRemainingData().Count == 0 && !this.GetGoodsData().IfMayReSell())
				{
					result = "DistanceToDown";
				}
				else if (this.GetRemainingData().Count == 0 && this.GetGoodsData().IfMayReSell())
				{
					result = "ReSell";
				}
			}
			return result;
		}

		// Token: 0x0602B74A RID: 177994 RVA: 0x00C36424 File Offset: 0x00C34624
		public string GetExchangePopViewResellText()
		{
			string result = "";
			if (this.IsLimitGoods() && this.GetGoodsData().IsWeeklyRefresh() && this.GetRemainingData().Count == 0 && this.GetGoodsData().IfMayReSell())
			{
				result = "SoldOut";
			}
			return result;
		}

		// Token: 0x0602B74B RID: 177995 RVA: 0x00C36470 File Offset: 0x00C34670
		public string GetBuyLimitText()
		{
			if (!this.IsLimitGoods())
			{
				return "";
			}
			string text;
			if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.None)
			{
				text = "LimitBuy";
			}
			else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Daily)
			{
				text = "DailyLeftTime";
			}
			else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Weekly)
			{
				text = "WeekLeftTime";
			}
			else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Monthly)
			{
				text = "MonthLeftTime";
			}
			else
			{
				text = "LimitBuy";
			}
			if (text == "LimitBuy")
			{
				int num = this.Data.BuyLimit - this.Data.BoughtCount;
				return StringUtils.Format(TextConfig.Instance.GetTextById(text), new string[]
				{
					num.ToString(),
					this.Data.BuyLimit.ToString()
				});
			}
			return StringUtils.Format(TextConfig.Instance.GetTextById(text), new string[]
			{
				(this.Data.BuyLimit - this.Data.BoughtCount).ToString()
			});
		}

		// Token: 0x0602B74C RID: 177996 RVA: 0x00C36584 File Offset: 0x00C34784
		public string GetExchangeViewShopTipsText()
		{
			if (this.CheckIfMonthCardItem())
			{
				return MonthCardModel.Instance.GetRemainDayText(null);
			}
			if (this.IsLimitGoods())
			{
				string id;
				if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.None)
				{
					id = "LimitBuy_B";
				}
				else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Daily)
				{
					id = "DayLimitBuy_B";
				}
				else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Weekly)
				{
					id = "WeekLimitBuy_B";
				}
				else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Monthly)
				{
					id = "MonthLimitBuy_B";
				}
				else
				{
					id = "LimitBuy_B";
				}
				int num = this.Data.BuyLimit - this.Data.BoughtCount;
				string text;
				if (this.GetGoodsData().GetRemainingCount() > 0)
				{
					text = StringUtils.Format(TextConfig.Instance.GetTextById("BuyTextEnough"), new string[]
					{
						num.ToString(),
						this.Data.BuyLimit.ToString()
					});
				}
				else
				{
					text = StringUtils.Format(TextConfig.Instance.GetTextById("BuyTextNotEnough"), new string[]
					{
						num.ToString(),
						this.Data.BuyLimit.ToString()
					});
				}
				return StringUtils.Format(TextConfig.Instance.GetTextById(id), new string[]
				{
					text
				});
			}
			return "";
		}

		// Token: 0x0602B74D RID: 177997 RVA: 0x00C366D4 File Offset: 0x00C348D4
		public string GetShopTipsText()
		{
			if (this.CheckIfMonthCardItem())
			{
				return MonthCardModel.Instance.GetRemainDayText(null);
			}
			if (this.IsLimitGoods())
			{
				string id;
				if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.None)
				{
					id = "LimitBuy";
				}
				else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Daily)
				{
					id = "DayLimitBuy";
				}
				else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Weekly)
				{
					id = "WeekLimitBuy";
				}
				else if (this.Data.UpdateType == PayShopDefine.EPayShopUpdateType.Monthly)
				{
					id = "MonthLimitBuy";
				}
				else
				{
					id = "LimitBuy";
				}
				int num = this.Data.BuyLimit - this.Data.BoughtCount;
				return StringUtils.Format(TextConfig.Instance.GetTextById(id), new string[]
				{
					num.ToString(),
					this.Data.BuyLimit.ToString()
				});
			}
			return "";
		}

		// Token: 0x0602B74E RID: 177998 RVA: 0x00C367B4 File Offset: 0x00C349B4
		public int GetTabId()
		{
			return this.Data.TabId;
		}

		// Token: 0x0602B74F RID: 177999 RVA: 0x00C367C1 File Offset: 0x00C349C1
		public bool IsLimitGoods()
		{
			return this.Data.HasBuyLimit();
		}

		// Token: 0x0602B750 RID: 178000 RVA: 0x00C367CE File Offset: 0x00C349CE
		public bool IfCanBuy()
		{
			return this.GetCantBuyReason() == PayShopDefine.EPayShopCantBuyReason.None;
		}

		// Token: 0x0602B751 RID: 178001 RVA: 0x00C367DC File Offset: 0x00C349DC
		private bool IfCanBuyWithoutTime()
		{
			if (this.CheckIfMonthCardItem())
			{
				ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(this.GetGoodsData().ItemId);
				int value;
				int? num;
				if (!config.Value.Parameters().TryGetValue(13, out value))
				{
					num = null;
				}
				else
				{
					num = new int?(value);
				}
				if (num == null)
				{
					int value2;
					if (!config.Value.Parameters().TryGetValue(14, out value2))
					{
						num = null;
					}
					else
					{
						num = new int?(value2);
					}
				}
				if (num == null)
				{
					return true;
				}
				if (!MonthCardModel.Instance.CheckMonthCardIfCanBuy())
				{
					return false;
				}
			}
			CSharpScript.Game.Module.Inventory.ItemConfig itemConfig = this.GetGoodsData().GetItemConfig();
			if (itemConfig != null && itemConfig.ShowTypes != null && Array.IndexOf<int>(itemConfig.ShowTypes, 30) >= 0)
			{
				int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(this.GetGoodsData().ItemId);
				if (resonantItemRoleId != null && resonantItemRoleId.Length != 0)
				{
					int num2 = resonantItemRoleId[0];
					return RoleModel.Instance.GetRoleInstanceById(num2) != null && RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(num2) > 0;
				}
			}
			return this.Data.GetIfCanBuy();
		}

		// Token: 0x0602B752 RID: 178002 RVA: 0x00C368FF File Offset: 0x00C34AFF
		public PayShopDefine.EPayShopCantBuyReason GetCantBuyReason()
		{
			if (!this.IfCanBuyWithoutTime())
			{
				return PayShopDefine.EPayShopCantBuyReason.Other;
			}
			if (!this.InSellTime())
			{
				return PayShopDefine.EPayShopCantBuyReason.NotInSellTime;
			}
			return PayShopDefine.EPayShopCantBuyReason.None;
		}

		// Token: 0x0602B753 RID: 178003 RVA: 0x00C36918 File Offset: 0x00C34B18
		public bool IsSoldOut()
		{
			if (this.Data.HasBuyLimit())
			{
				return this.Data.BoughtCount == this.Data.BuyLimit;
			}
			int rewardRoleSkinId = this.GetRewardRoleSkinId();
			return rewardRoleSkinId > 0 && !RoleSkinModel.Instance.GetRoleSkinData(rewardRoleSkinId).IsLocked();
		}

		// Token: 0x0602B754 RID: 178004 RVA: 0x00C3696B File Offset: 0x00C34B6B
		public int GetGoodsId()
		{
			return this.Data.Id;
		}

		// Token: 0x0602B755 RID: 178005 RVA: 0x00C36978 File Offset: 0x00C34B78
		public bool IsDirect()
		{
			return this.Data.IsDirect();
		}

		// Token: 0x0602B756 RID: 178006 RVA: 0x00C36985 File Offset: 0x00C34B85
		public void AddBoughtCount(int addCount)
		{
			this.Data.BoughtCount += addCount;
		}

		// Token: 0x0602B757 RID: 178007 RVA: 0x00C3699A File Offset: 0x00C34B9A
		public bool IsShowInShop()
		{
			return this.Data.IsShowInShop();
		}

		// Token: 0x0602B758 RID: 178008 RVA: 0x00C369A7 File Offset: 0x00C34BA7
		public PayShopItemBaseSt ConvertToPayShopBaseSt()
		{
			this.CachePayShopItemBaseSt.Refresh(this);
			return this.CachePayShopItemBaseSt;
		}

		// Token: 0x0602B759 RID: 178009 RVA: 0x00C369BB File Offset: 0x00C34BBB
		public bool CheckIfMonthCardItem()
		{
			return this.GetGoodsData().CheckIfMonthCardItem();
		}

		// Token: 0x0602B75A RID: 178010 RVA: 0x00C369C8 File Offset: 0x00C34BC8
		public bool GetIfNeedRemind()
		{
			return this.IsGoodsFree() || this.IfNeedRemind();
		}

		// Token: 0x0602B75B RID: 178011 RVA: 0x00C369DD File Offset: 0x00C34BDD
		private bool IsGoodsFree()
		{
			return !this.IsLocked() && this.IfCanBuy() && !this.IsSoldOut() && this.CheckGoodIfShow() && !this.IsDirect() && this.GetPriceData().NowPrice == 0;
		}

		// Token: 0x0602B75C RID: 178012 RVA: 0x00C36A17 File Offset: 0x00C34C17
		private bool IfNeedRemind()
		{
			return this.IfCanBuy() && !this.IsSoldOut() && this.CheckGoodIfShow() && this.Data.GetIfNeedRemind();
		}

		// Token: 0x0602B75D RID: 178013 RVA: 0x00C36A3E File Offset: 0x00C34C3E
		public bool GetIfShowRecommendTag()
		{
			return this.Data.ShowRecommendTag;
		}

		// Token: 0x0602B75E RID: 178014 RVA: 0x00C36A4C File Offset: 0x00C34C4C
		public unsafe bool CheckGoodIfShow()
		{
			if (!this.IsShowInShop())
			{
				return false;
			}
			if (this.HasShowTime())
			{
				if (!this.InShowTime() && !this.InSellTime())
				{
					return false;
				}
				if (this.GetCantBuyReason() == PayShopDefine.EPayShopCantBuyReason.NotInSellTime)
				{
					int tabId = this.GetTabId();
					PayShopTab? config = ConfigPayShopTabByShopIdAndTabId.GetConfig((int)this.PayShopId, tabId, true);
					if (config == null || !config.GetValueOrDefault().NeedShowShowTime)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Shop;
						ELogAuthor author = ELogAuthor.XXJ;
						string message = "商城商品展示时间配置错误，PayShopTab未开启NeedShowShowTime";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ConfigId", this.Data.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tabId", tabId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("shopId", this.PayShopId);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
						return false;
					}
				}
			}
			else if (!this.InSellTime())
			{
				return false;
			}
			return this.GetGoodsData().Show && (!this.GetGoodsData().HasBuyLimit() || this.GetGoodsData().GetRemainingCount() != 0 || this.GetGoodsData().IsWeeklyRefresh() || this.GetGoodsData().IfShowAfterSoldOut()) && (!this.GetGoodsData().HasBuyLimit() || this.GetGoodsData().GetRemainingCount() != 0 || !this.GetGoodsData().IsWeeklyRefresh() || this.GetGoodsData().UpdateTime < this.GetGoodsData().EndTime || this.IsPermanentSell());
		}

		// Token: 0x0602B75F RID: 178015 RVA: 0x00C36BE8 File Offset: 0x00C34DE8
		public void SaveRemindState(long timestamp)
		{
			if (this.Data.SaveRemindState(timestamp) == 0)
			{
				EventSystem.Instance.Emit(EEventName.RefreshPayShopEntranceRedDot);
				EventSystem.Instance.Emit<PayShopDefine.EPayShopTabType>(EEventName.RefreshPayShopInstanceRedDot, this.PayShopId);
				EventSystem.Instance.Emit<int>(EEventName.RefreshPayShopTabRedDot, this.GetTabId());
			}
		}

		// Token: 0x0602B760 RID: 178016 RVA: 0x00C36C40 File Offset: 0x00C34E40
		public bool CheckIfGiftPackage()
		{
			int itemId = this.GetGoodsData().ItemId;
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
			if (itemConfig != null && itemConfig.Value.Parameters() != null)
			{
				int value;
				int? num;
				if (!itemConfig.Value.Parameters().TryGetValue(2, out value))
				{
					num = null;
				}
				else
				{
					num = new int?(value);
				}
				if (num == null)
				{
					int value2;
					if (!itemConfig.Value.Parameters().TryGetValue(4, out value2))
					{
						num = null;
					}
					else
					{
						num = new int?(value2);
					}
				}
				return num != null;
			}
			return false;
		}

		// Token: 0x0602B761 RID: 178017 RVA: 0x00C36CF0 File Offset: 0x00C34EF0
		public int GetPackageRewardId()
		{
			int itemId = this.GetGoodsData().ItemId;
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
			if (itemConfig == null || itemConfig.Value.Parameters() == null)
			{
				return 0;
			}
			int value;
			int? num;
			if (!itemConfig.Value.Parameters().TryGetValue(2, out value))
			{
				num = null;
			}
			else
			{
				num = new int?(value);
			}
			if (num == null)
			{
				int value2;
				if (!itemConfig.Value.Parameters().TryGetValue(4, out value2))
				{
					num = null;
				}
				else
				{
					num = new int?(value2);
				}
			}
			if (num == null)
			{
				return 0;
			}
			return num.Value;
		}

		// Token: 0x0602B762 RID: 178018 RVA: 0x00C36DA8 File Offset: 0x00C34FA8
		public int GetRewardRoleSkinId()
		{
			int itemId = this.GetGoodsData().ItemId;
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
			if (itemConfig != null && itemConfig.Value.Parameters() != null)
			{
				if (!this.CheckIfGiftPackage())
				{
					return 0;
				}
				GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(this.GetPackageRewardId());
				if (giftPackageConfig == null)
				{
					return 0;
				}
				foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
				{
					int key = keyValuePair.Key;
					if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) == InventoryDefine.EItemDataType.RoleSkinItem)
					{
						return key;
					}
				}
				return 0;
			}
			return 0;
		}

		// Token: 0x0602B763 RID: 178019 RVA: 0x00C36E88 File Offset: 0x00C35088
		public int GetRewardFlySkinId()
		{
			int itemId = this.GetGoodsData().ItemId;
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
			if (itemConfig != null && itemConfig.Value.Parameters() != null)
			{
				if (!this.CheckIfGiftPackage())
				{
					return 0;
				}
				GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(this.GetPackageRewardId());
				if (giftPackageConfig == null)
				{
					return 0;
				}
				foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
				{
					int key = keyValuePair.Key;
					if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) == InventoryDefine.EItemDataType.FlySkinItem)
					{
						return key;
					}
				}
				return 0;
			}
			return 0;
		}

		// Token: 0x0602B764 RID: 178020 RVA: 0x00C36F68 File Offset: 0x00C35168
		public int GetRewardOrnamentId()
		{
			int itemId = this.GetGoodsData().ItemId;
			if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(itemId)) == InventoryDefine.EItemDataType.OrnamentItem)
			{
				return itemId;
			}
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
			if (itemConfig != null && itemConfig.Value.Parameters() != null)
			{
				if (!this.CheckIfGiftPackage())
				{
					return 0;
				}
				GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(this.GetPackageRewardId());
				if (giftPackageConfig == null)
				{
					return 0;
				}
				if (giftPackageConfig.Value.CheckGoodsMethod == 1)
				{
					return 0;
				}
				foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
				{
					int key = keyValuePair.Key;
					if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) == InventoryDefine.EItemDataType.OrnamentItem)
					{
						return key;
					}
				}
				return 0;
			}
			return 0;
		}

		// Token: 0x0602B765 RID: 178021 RVA: 0x00C37074 File Offset: 0x00C35274
		public bool CheckIfOrnamentGoods()
		{
			return this.GetRewardOrnamentId() != 0;
		}

		// Token: 0x0602B766 RID: 178022 RVA: 0x00C3707F File Offset: 0x00C3527F
		public bool CheckIfRoleSkinGoods()
		{
			return this.GetRewardRoleSkinId() != 0;
		}

		// Token: 0x0602B767 RID: 178023 RVA: 0x00C3708C File Offset: 0x00C3528C
		public bool CheckIfFlySkinGoods()
		{
			int itemId = this.GetGoodsData().ItemId;
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
			if (itemConfig != null && itemConfig.Value.Parameters() != null)
			{
				if (!this.CheckIfGiftPackage())
				{
					return false;
				}
				GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(this.GetPackageRewardId());
				if (giftPackageConfig == null)
				{
					return false;
				}
				if (giftPackageConfig.Value.CheckGoodsMethod == 1)
				{
					return false;
				}
				foreach (KeyValuePair<int, int> keyValuePair in giftPackageConfig.Value.Content())
				{
					int key = keyValuePair.Key;
					if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key)) == InventoryDefine.EItemDataType.FlySkinItem)
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0602B768 RID: 178024 RVA: 0x00C37180 File Offset: 0x00C35380
		[NullableContext(2)]
		public CommonItemData GetAvailableCouponItem()
		{
			foreach (int configId in this.Data.GetCouponList())
			{
				CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(configId, 0);
				if (commonItemData != null)
				{
					return commonItemData;
				}
			}
			return null;
		}

		// Token: 0x0602B769 RID: 178025 RVA: 0x00C371E8 File Offset: 0x00C353E8
		public int GetAvailableCouponDiscount()
		{
			CommonItemData availableCouponItem = this.GetAvailableCouponItem();
			if (availableCouponItem == null)
			{
				return 0;
			}
			Coupon? config = ConfigCouponById.GetConfig(availableCouponItem.GetConfigId(), true);
			if (config == null)
			{
				return 0;
			}
			return config.Value.Param;
		}

		// Token: 0x0602B76A RID: 178026 RVA: 0x00C37228 File Offset: 0x00C35428
		public int GetRewardMotorSkinId()
		{
			int itemId = this.GetGoodsData().ItemId;
			ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
			if (itemConfig != null && itemConfig.Value.Parameters() != null)
			{
				if (!this.CheckIfGiftPackage())
				{
					return 0;
				}
				GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(this.GetPackageRewardId());
				if (giftPackageConfig == null)
				{
					return 0;
				}
				Dictionary<int, int> dictionary = giftPackageConfig.Value.Content();
				List<InventoryDefine.EItemDataType> list = new List<InventoryDefine.EItemDataType>
				{
					InventoryDefine.EItemDataType.MotorStickerItem,
					InventoryDefine.EItemDataType.MotorDecorationItem,
					InventoryDefine.EItemDataType.MotorFrameItem,
					InventoryDefine.EItemDataType.MotorSkinItem
				};
				foreach (KeyValuePair<int, int> keyValuePair in dictionary)
				{
					int key = keyValuePair.Key;
					InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(key));
					if (list.Contains(itemDataTypeByConfigId))
					{
						return key;
					}
				}
				return 0;
			}
			return 0;
		}

		// Token: 0x0602B76B RID: 178027 RVA: 0x00C37338 File Offset: 0x00C35538
		public bool CheckIfMotorSkinGoods()
		{
			return this.GetRewardMotorSkinId() != 0;
		}

		// Token: 0x0602B76C RID: 178028 RVA: 0x00C37343 File Offset: 0x00C35543
		public bool HasCloudGameInfo()
		{
			return this.Data.CloudGameTime > 0;
		}

		// Token: 0x0602B76D RID: 178029 RVA: 0x00C37353 File Offset: 0x00C35553
		public string GetCloudGameDesc()
		{
			if (!this.HasCloudGameInfo())
			{
				return "";
			}
			return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(this.Data.CloudGameDesc, null), new string[]
			{
				this.Data.CloudGameTime.ToString()
			});
		}

		// Token: 0x0602B76E RID: 178030 RVA: 0x00C37392 File Offset: 0x00C35592
		public string GetCloudGameIcon()
		{
			return this.Data.CloudGameIcon;
		}

		// Token: 0x0602B76F RID: 178031 RVA: 0x00C3739F File Offset: 0x00C3559F
		public bool GetIfShowTotalTopUpScore()
		{
			return TotalTopUpController.Instance.GetGoodsScore(this.GetGoodsId()) > 0;
		}

		// Token: 0x040177D4 RID: 96212
		private bool IsOnSell;

		// Token: 0x040177D5 RID: 96213
		public PayShopDefine.EPayShopTabType PayShopId = PayShopDefine.EPayShopTabType.Recommend;

		// Token: 0x040177D6 RID: 96214
		[Nullable(2)]
		private PayShopItemBaseSt CachePayShopItemBaseSt;

		// Token: 0x040177D7 RID: 96215
		private int PayGiftId;
	}
}
