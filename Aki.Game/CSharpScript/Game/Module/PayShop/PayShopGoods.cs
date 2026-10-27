using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.PayShop
{
	// Token: 0x02005355 RID: 21333
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PayShopGoods : PayShopUnionData<PayShopGoodsData>
	{
		// Token: 0x060367D9 RID: 223193 RVA: 0x00CE6AE4 File Offset: 0x00CE4CE4
		public PayShopGoods(PayShopDefine.EPayShopTabType payShopId)
		{
			this.PayShopId = payShopId;
		}

		// Token: 0x060367DA RID: 223194 RVA: 0x00CE6AFA File Offset: 0x00CE4CFA
		public void SetPayShopId(PayShopDefine.EPayShopTabType payShopId)
		{
			this.PayShopId = payShopId;
		}

		// Token: 0x060367DB RID: 223195 RVA: 0x00CE6B03 File Offset: 0x00CE4D03
		public void SetGoodsData(PayShopGoodsData data)
		{
			this.Data = data;
			this.IsOnSell = this.InSellTime();
			this.CachePayShopItemBaseSt = new PayShopItemBaseSt();
			this.CachePayShopItemBaseSt.PhraseFromPayItemData(this);
		}

		// Token: 0x060367DC RID: 223196 RVA: 0x00CE6B2F File Offset: 0x00CE4D2F
		public void SetPayGiftId(int id)
		{
			this.PayGiftId = id;
		}

		// Token: 0x060367DD RID: 223197 RVA: 0x00CE6B38 File Offset: 0x00CE4D38
		[NullableContext(2)]
		public PayPackageData GetGetPayGiftData()
		{
			return PayGiftModel.Instance.GetPayGiftDataById(this.PayGiftId);
		}

		// Token: 0x060367DE RID: 223198 RVA: 0x00CE6B4A File Offset: 0x00CE4D4A
		[NullableContext(2)]
		public PayShopGoodsData GetGoodsData()
		{
			return this.Data;
		}

		// Token: 0x060367DF RID: 223199 RVA: 0x00CE6B52 File Offset: 0x00CE4D52
		public bool IsLocked()
		{
			return this.Data.Locked;
		}

		// Token: 0x060367E0 RID: 223200 RVA: 0x00CE6B60 File Offset: 0x00CE4D60
		public string GetConditionTextId()
		{
			int buyConditionId = this.Data.GetBuyConditionId();
			if (buyConditionId != 0)
			{
				return LevelGeneralCommons.GetConditionGroupHintText(buyConditionId) ?? "";
			}
			return "";
		}

		// Token: 0x060367E1 RID: 223201 RVA: 0x00CE6B91 File Offset: 0x00CE4D91
		public int GetDiscountLabel()
		{
			return this.Data.LabelId;
		}

		// Token: 0x060367E2 RID: 223202 RVA: 0x00CE6BA0 File Offset: 0x00CE4DA0
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

		// Token: 0x060367E3 RID: 223203 RVA: 0x00CE6C20 File Offset: 0x00CE4E20
		public bool IfPayGift()
		{
			return this.Data.IfPayGift();
		}

		// Token: 0x060367E4 RID: 223204 RVA: 0x00CE6C30 File Offset: 0x00CE4E30
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

		// Token: 0x060367E5 RID: 223205 RVA: 0x00CE6CFC File Offset: 0x00CE4EFC
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

		// Token: 0x060367E6 RID: 223206 RVA: 0x00CE6D54 File Offset: 0x00CE4F54
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

		// Token: 0x060367E7 RID: 223207 RVA: 0x00CE6D8D File Offset: 0x00CE4F8D
		public void SetUnLock()
		{
			this.Data.SetUnLock();
		}

		// Token: 0x060367E8 RID: 223208 RVA: 0x00CE6D9A File Offset: 0x00CE4F9A
		public int GetDiscount()
		{
			return this.Data.GetDiscount();
		}

		// Token: 0x060367E9 RID: 223209 RVA: 0x00CE6DA8 File Offset: 0x00CE4FA8
		public int GetDiscountNew()
		{
			PayPackageData getPayGiftData = this.GetGetPayGiftData();
			if (getPayGiftData != null)
			{
				return getPayGiftData.GetDiscount() / 100;
			}
			return this.Data.GetDiscountNew();
		}

		// Token: 0x060367EA RID: 223210 RVA: 0x00CE6DD4 File Offset: 0x00CE4FD4
		public bool HasDiscount()
		{
			PayPackageData getPayGiftData = this.GetGetPayGiftData();
			if (getPayGiftData != null)
			{
				return getPayGiftData.HasDiscount();
			}
			return this.Data.HasDiscount();
		}

		// Token: 0x060367EB RID: 223211 RVA: 0x00CE6E00 File Offset: 0x00CE5000
		public bool IsPermanentDiscount()
		{
			return (this.Data.EndPromotionTime == 0L && this.Data.BeginPromotionTime == 0L) || (this.Data.EndPromotionTime == 0L && TimeUtil.Instance.GetServerTime() >= (double)this.Data.BeginTime);
		}

		// Token: 0x060367EC RID: 223212 RVA: 0x00CE6E54 File Offset: 0x00CE5054
		public bool IsPermanentSell()
		{
			return (this.Data.BeginTime == 0L && this.Data.EndTime == 0L) || (TimeUtil.Instance.GetServerTime() >= (double)this.Data.BeginTime && this.Data.EndTime == 0L);
		}

		// Token: 0x060367ED RID: 223213 RVA: 0x00CE6EA8 File Offset: 0x00CE50A8
		public bool InSellTime()
		{
			return this.IsPermanentSell() || ((double)this.Data.EndTime > TimeUtil.Instance.GetServerTime() && TimeUtil.Instance.GetServerTime() >= (double)this.Data.BeginTime);
		}

		// Token: 0x060367EE RID: 223214 RVA: 0x00CE6EF4 File Offset: 0x00CE50F4
		public bool InLabelShowTime()
		{
			return this.Data.InLabelShowTime();
		}

		// Token: 0x060367EF RID: 223215 RVA: 0x00CE6F04 File Offset: 0x00CE5104
		public bool InUnPermanentSellTime()
		{
			return !this.IsPermanentSell() && (double)this.Data.EndTime > TimeUtil.Instance.GetServerTime() && TimeUtil.Instance.GetServerTime() >= (double)this.Data.BeginTime;
		}

		// Token: 0x060367F0 RID: 223216 RVA: 0x00CE6F50 File Offset: 0x00CE5150
		public bool WillSell()
		{
			return !this.IsOnSell && TimeUtil.Instance.GetServerTime() < (double)this.Data.BeginTime;
		}

		// Token: 0x060367F1 RID: 223217 RVA: 0x00CE6F78 File Offset: 0x00CE5178
		public CommonDefine.IPayShowCountDownRemainTime GetDiscountTimeData()
		{
			long endPromotionTime = this.Data.EndPromotionTime;
			return new CommonDefine.PayShowCountDownRemainTime<string>
			{
				Value = PayShopGoods.GetEndTimeShowText(endPromotionTime)
			};
		}

		// Token: 0x060367F2 RID: 223218 RVA: 0x00CE6FA4 File Offset: 0x00CE51A4
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

		// Token: 0x060367F3 RID: 223219 RVA: 0x00CE7014 File Offset: 0x00CE5214
		public CommonDefine.ICountDown GetDiscountCountDown()
		{
			double time = (double)this.Data.EndPromotionTime - TimeUtil.Instance.GetServerTime();
			return TimeUtil.Instance.GetCountDownData(time, null, null);
		}

		// Token: 0x060367F4 RID: 223220 RVA: 0x00CE7058 File Offset: 0x00CE5258
		public CommonDefine.IPayShowCountDownRemainTime GetUpdateTimeRemainData()
		{
			long updateTime = this.Data.UpdateTime;
			return new CommonDefine.PayShowCountDownRemainTime<string>
			{
				Value = PayShopGoods.GetEndTimeShowText(updateTime)
			};
		}

		// Token: 0x060367F5 RID: 223221 RVA: 0x00CE7082 File Offset: 0x00CE5282
		public long GetUpdateRemainTime()
		{
			return (long)((double)this.Data.UpdateTime - TimeUtil.Instance.GetServerTime() + TimeUtil.Instance.TimeDeviation);
		}

		// Token: 0x060367F6 RID: 223222 RVA: 0x00CE70A7 File Offset: 0x00CE52A7
		public bool InUpdateTime()
		{
			return this.Data.HasBuyLimit() && this.Data.UpdateTime != 0L && (double)this.Data.UpdateTime > TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x060367F7 RID: 223223 RVA: 0x00CE70DF File Offset: 0x00CE52DF
		public bool NeedDown()
		{
			if (this.IsOnSell && !this.IsPermanentSell() && !this.InUnPermanentSellTime())
			{
				this.IsOnSell = false;
				return true;
			}
			return false;
		}

		// Token: 0x060367F8 RID: 223224 RVA: 0x00CE7104 File Offset: 0x00CE5304
		public bool NeedUpdate()
		{
			if (this.InSellTime() && !this.IsOnSell)
			{
				this.IsOnSell = true;
				return true;
			}
			return this.Data.HasBuyLimit() && this.Data.UpdateTime != 0L && (double)this.Data.UpdateTime <= TimeUtil.Instance.GetServerTime() && this.InSellTime();
		}

		// Token: 0x060367F9 RID: 223225 RVA: 0x00CE7168 File Offset: 0x00CE5368
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

		// Token: 0x060367FA RID: 223226 RVA: 0x00CE71D9 File Offset: 0x00CE53D9
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

		// Token: 0x060367FB RID: 223227 RVA: 0x00CE7204 File Offset: 0x00CE5404
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

		// Token: 0x060367FC RID: 223228 RVA: 0x00CE7260 File Offset: 0x00CE5460
		public CommonDefine.IPayShowCountDownRemainTime GetEndTimeRemainData()
		{
			long endTime = this.Data.EndTime;
			return new CommonDefine.PayShowCountDownRemainTime<string>
			{
				Value = PayShopGoods.GetEndTimeShowText(endTime)
			};
		}

		// Token: 0x060367FD RID: 223229 RVA: 0x00CE728C File Offset: 0x00CE548C
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
				if (this.GetGoodsData().GetItemConfig().ShowTypes.Contains(30) || itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem)
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

		// Token: 0x060367FE RID: 223230 RVA: 0x00CE733D File Offset: 0x00CE553D
		[NullableContext(2)]
		public string GetConditionLimitText()
		{
			if (!this.Data.GetIfCanBuy())
			{
				return this.Data.GetUnFinishConditionText();
			}
			return "";
		}

		// Token: 0x060367FF RID: 223231 RVA: 0x00CE7360 File Offset: 0x00CE5560
		[NullableContext(2)]
		public string GetExtraLimitText()
		{
			if (this.CheckIfMonthCardItem())
			{
				return "Text_MonthlyCardMax_Text";
			}
			if (this.IfCanBuy())
			{
				return null;
			}
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.GetGoodsData().ItemId));
			if (!this.GetGoodsData().GetItemConfig().ShowTypes.Contains(30) && itemDataTypeByConfigId != InventoryDefine.EItemDataType.RoleItem)
			{
				return this.GetConditionTextId();
			}
			int id;
			if (this.GetGoodsData().GetItemConfig().ShowTypes.Contains(30))
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

		// Token: 0x06036800 RID: 223232 RVA: 0x00CE7420 File Offset: 0x00CE5620
		public bool GetIfNeedExtraLimitText()
		{
			if (this.CheckIfMonthCardItem())
			{
				return !MonthCardModel.Instance.IsRemainDayInMaxLimit();
			}
			return !this.IfCanBuy();
		}

		// Token: 0x06036801 RID: 223233 RVA: 0x00CE7444 File Offset: 0x00CE5644
		public bool GetIfNeedShowDownTipsText()
		{
			return (this.CheckIfMonthCardItem() && MonthCardModel.Instance.GetRemainDays() > ConfigCommonParamById.GetIntConfig("MonthCardMaxDays").Value) || (this.IsLimitGoods() && this.IsSoldOut()) || !this.IfCanBuy();
		}

		// Token: 0x06036802 RID: 223234 RVA: 0x00CE7498 File Offset: 0x00CE5698
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

		// Token: 0x06036803 RID: 223235 RVA: 0x00CE74EC File Offset: 0x00CE56EC
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

		// Token: 0x06036804 RID: 223236 RVA: 0x00CE7540 File Offset: 0x00CE5740
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

		// Token: 0x06036805 RID: 223237 RVA: 0x00CE7640 File Offset: 0x00CE5840
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

		// Token: 0x06036806 RID: 223238 RVA: 0x00CE76AC File Offset: 0x00CE58AC
		public string GetExchangePopViewResellText()
		{
			string result = "";
			if (this.IsLimitGoods() && this.GetGoodsData().IsWeeklyRefresh() && this.GetRemainingData().Count == 0 && this.GetGoodsData().IfMayReSell())
			{
				result = "SoldOut";
			}
			return result;
		}

		// Token: 0x06036807 RID: 223239 RVA: 0x00CE76F8 File Offset: 0x00CE58F8
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

		// Token: 0x06036808 RID: 223240 RVA: 0x00CE780C File Offset: 0x00CE5A0C
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

		// Token: 0x06036809 RID: 223241 RVA: 0x00CE795C File Offset: 0x00CE5B5C
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

		// Token: 0x0603680A RID: 223242 RVA: 0x00CE7A3C File Offset: 0x00CE5C3C
		public int GetTabId()
		{
			return this.Data.TabId;
		}

		// Token: 0x0603680B RID: 223243 RVA: 0x00CE7A49 File Offset: 0x00CE5C49
		public bool IsLimitGoods()
		{
			return this.Data.HasBuyLimit();
		}

		// Token: 0x0603680C RID: 223244 RVA: 0x00CE7A58 File Offset: 0x00CE5C58
		public bool IfCanBuy()
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
			if (itemConfig != null)
			{
				int[] showTypes = itemConfig.ShowTypes;
				if (showTypes != null && showTypes.Contains(30))
				{
					int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(this.GetGoodsData().ItemId);
					if (resonantItemRoleId != null && resonantItemRoleId.Length != 0)
					{
						int num2 = resonantItemRoleId[0];
						return RoleModel.Instance.GetRoleInstanceById(num2) != null && RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(num2) > 0;
					}
				}
			}
			return this.Data.GetIfCanBuy();
		}

		// Token: 0x0603680D RID: 223245 RVA: 0x00CE7B7C File Offset: 0x00CE5D7C
		public bool IsSoldOut()
		{
			if (this.Data.HasBuyLimit())
			{
				return this.Data.BoughtCount == this.Data.BuyLimit;
			}
			int rewardRoleSkinId = this.GetRewardRoleSkinId();
			return rewardRoleSkinId > 0 && !RoleSkinModel.Instance.GetRoleSkinData(rewardRoleSkinId).IsLocked();
		}

		// Token: 0x0603680E RID: 223246 RVA: 0x00CE7BCF File Offset: 0x00CE5DCF
		public int GetGoodsId()
		{
			return this.Data.Id;
		}

		// Token: 0x0603680F RID: 223247 RVA: 0x00CE7BDC File Offset: 0x00CE5DDC
		public bool IsDirect()
		{
			return this.Data.IsDirect();
		}

		// Token: 0x06036810 RID: 223248 RVA: 0x00CE7BE9 File Offset: 0x00CE5DE9
		public void AddBoughtCount(int addCount)
		{
			this.Data.BoughtCount += addCount;
		}

		// Token: 0x06036811 RID: 223249 RVA: 0x00CE7BFE File Offset: 0x00CE5DFE
		public bool IsShowInShop()
		{
			return this.Data.IsShowInShop();
		}

		// Token: 0x06036812 RID: 223250 RVA: 0x00CE7C0B File Offset: 0x00CE5E0B
		public PayShopItemBaseSt ConvertToPayShopBaseSt()
		{
			this.CachePayShopItemBaseSt.Refresh(this);
			return this.CachePayShopItemBaseSt;
		}

		// Token: 0x06036813 RID: 223251 RVA: 0x00CE7C1F File Offset: 0x00CE5E1F
		public bool CheckIfMonthCardItem()
		{
			return this.GetGoodsData().CheckIfMonthCardItem();
		}

		// Token: 0x06036814 RID: 223252 RVA: 0x00CE7C2C File Offset: 0x00CE5E2C
		public bool GetIfNeedRemind()
		{
			return this.IsGoodsFree() || this.IfNeedRemind();
		}

		// Token: 0x06036815 RID: 223253 RVA: 0x00CE7C41 File Offset: 0x00CE5E41
		private bool IsGoodsFree()
		{
			return !this.IsLocked() && this.IfCanBuy() && !this.IsSoldOut() && this.CheckGoodIfShow() && !this.IsDirect() && this.GetPriceData().NowPrice == 0;
		}

		// Token: 0x06036816 RID: 223254 RVA: 0x00CE7C7B File Offset: 0x00CE5E7B
		private bool IfNeedRemind()
		{
			return this.IfCanBuy() && !this.IsSoldOut() && this.CheckGoodIfShow() && this.Data.GetIfNeedRemind();
		}

		// Token: 0x06036817 RID: 223255 RVA: 0x00CE7CA2 File Offset: 0x00CE5EA2
		public bool GetIfShowRecommendTag()
		{
			return this.Data.ShowRecommendTag;
		}

		// Token: 0x06036818 RID: 223256 RVA: 0x00CE7CB0 File Offset: 0x00CE5EB0
		public bool CheckGoodIfShow()
		{
			return this.IsShowInShop() && this.InSellTime() && this.GetGoodsData().Show && (!this.GetGoodsData().HasBuyLimit() || this.GetGoodsData().GetRemainingCount() != 0 || this.GetGoodsData().IsWeeklyRefresh() || this.GetGoodsData().IfShowAfterSoldOut()) && (!this.GetGoodsData().HasBuyLimit() || this.GetGoodsData().GetRemainingCount() != 0 || !this.GetGoodsData().IsWeeklyRefresh() || this.GetGoodsData().UpdateTime < this.GetGoodsData().EndTime || this.IsPermanentSell());
		}

		// Token: 0x06036819 RID: 223257 RVA: 0x00CE7D60 File Offset: 0x00CE5F60
		public void SaveRemindState(long timestamp)
		{
			if (this.Data.SaveRemindState(timestamp) == 0)
			{
				EventSystem.Instance.Emit(EEventName.RefreshPayShopEntranceRedDot);
				EventSystem.Instance.Emit<PayShopDefine.EPayShopTabType>(EEventName.RefreshPayShopInstanceRedDot, this.PayShopId);
				EventSystem.Instance.Emit<int>(EEventName.RefreshPayShopTabRedDot, this.GetTabId());
			}
		}

		// Token: 0x0603681A RID: 223258 RVA: 0x00CE7DB8 File Offset: 0x00CE5FB8
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

		// Token: 0x0603681B RID: 223259 RVA: 0x00CE7E68 File Offset: 0x00CE6068
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

		// Token: 0x0603681C RID: 223260 RVA: 0x00CE7F20 File Offset: 0x00CE6120
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

		// Token: 0x0603681D RID: 223261 RVA: 0x00CE8000 File Offset: 0x00CE6200
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

		// Token: 0x0603681E RID: 223262 RVA: 0x00CE80E0 File Offset: 0x00CE62E0
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

		// Token: 0x0603681F RID: 223263 RVA: 0x00CE81EC File Offset: 0x00CE63EC
		public bool CheckIfOrnamentGoods()
		{
			return this.GetRewardOrnamentId() != 0;
		}

		// Token: 0x06036820 RID: 223264 RVA: 0x00CE81F7 File Offset: 0x00CE63F7
		public bool CheckIfRoleSkinGoods()
		{
			return this.GetRewardRoleSkinId() != 0;
		}

		// Token: 0x06036821 RID: 223265 RVA: 0x00CE8204 File Offset: 0x00CE6404
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

		// Token: 0x06036822 RID: 223266 RVA: 0x00CE82F8 File Offset: 0x00CE64F8
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

		// Token: 0x06036823 RID: 223267 RVA: 0x00CE8360 File Offset: 0x00CE6560
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

		// Token: 0x06036824 RID: 223268 RVA: 0x00CE83A0 File Offset: 0x00CE65A0
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

		// Token: 0x06036825 RID: 223269 RVA: 0x00CE84B0 File Offset: 0x00CE66B0
		public bool CheckIfMotorSkinGoods()
		{
			return this.GetRewardMotorSkinId() != 0;
		}

		// Token: 0x06036826 RID: 223270 RVA: 0x00CE84BB File Offset: 0x00CE66BB
		public bool HasCloudGameInfo()
		{
			return this.Data.CloudGameTime > 0;
		}

		// Token: 0x06036827 RID: 223271 RVA: 0x00CE84CB File Offset: 0x00CE66CB
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

		// Token: 0x06036828 RID: 223272 RVA: 0x00CE850A File Offset: 0x00CE670A
		public string GetCloudGameIcon()
		{
			return this.Data.CloudGameIcon;
		}

		// Token: 0x06036829 RID: 223273 RVA: 0x00CE8517 File Offset: 0x00CE6717
		public bool GetIfShowTotalTopUpScore()
		{
			return TotalTopUpController.Instance.GetGoodsScore(this.GetGoodsId()) > 0;
		}

		// Token: 0x0401CD40 RID: 118080
		private bool IsOnSell;

		// Token: 0x0401CD41 RID: 118081
		public PayShopDefine.EPayShopTabType PayShopId = PayShopDefine.EPayShopTabType.Recommend;

		// Token: 0x0401CD42 RID: 118082
		[Nullable(2)]
		private PayShopItemBaseSt CachePayShopItemBaseSt;

		// Token: 0x0401CD43 RID: 118083
		private int PayGiftId;
	}
}
