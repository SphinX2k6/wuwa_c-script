using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x0200183D RID: 6205
[NullableContext(1)]
[Nullable(0)]
public class PayShopGoodsData
{
	// Token: 0x0600F52A RID: 62762 RVA: 0x00479200 File Offset: 0x00477400
	public unsafe void Phrase(Aki.Protocol.PayShopItem data)
	{
		this.Id = data.Id;
		this.TabId = data.TabId;
		this.ShopId = data.ShopId;
		this.ItemId = data.ItemId;
		this.ShopItemQuality = data.Quality;
		this.ItemCount = data.ItemCount;
		this.Locked = data.Locked;
		this.CanBuy = data.CanBuyGoods;
		this.BuyLimit = data.BuyLimit;
		this.OnceBuyLimit = data.OnceBuyLimit;
		this.LimitBuyConditionId = data.BuyLimitConditionId;
		this.BoughtCount = data.BoughtCount;
		this.Price.Phrase(data.Price);
		this.Coupons = new List<int>(data.Coupons);
		this.BeginTime = data.BeginTime;
		this.EndTime = data.EndTime;
		int activityId = data.ActivityId;
		if (activityId > 0)
		{
			ActivityBaseData activityById = ActivityModel.Instance.GetActivityById(activityId);
			if (activityById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Shop;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "活动商品对应的活动数据为空";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("goodsId", this.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("activityId", activityId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.EndTime = activityById.EndShowTime;
		}
		this.BeginPromotionTime = data.BeginPromotionTime;
		this.EndPromotionTime = data.EndPromotionTime;
		this.UpdateTime = data.UpdateTime;
		this.UpdateType = (PayShopDefine.EPayShopUpdateType)data.UpdateType;
		this.ShopItemType = (PayShopDefine.EPayShopItemType)data.ShopItemType;
		this.LastUpdateTime = data.LastUpdateTime;
		this.LabelId = data.Tag;
		this.LabelBeginTime = data.TagBeginTime;
		this.LabelEndTime = data.TagEndTime;
		this.Sort = data.Sort;
		this.DiscountSort = data.DiscountSort;
		this.PromotionShow = data.PromotionShow;
		this.ShowRecommendTag = data.IsRecommend;
		this.IsShowHaveNum = data.IsShowHaveNum;
		this.IsBuyMaxButton = data.IsBuyMaxButton;
		this.ConfirmLimitCount = data.ConfirmLimitCount;
		this.ShowBeginTime = data.ShowBeginTime;
		this.ShowEndTime = data.ShowEndTime;
		this.ShowAfterSoldOut = data.SoldoutShowInShop;
		this.NeedRemind = data.IsRemind;
		this.StageImage = data.StageImage;
		this.ShowStageImage = data.ShowStageImage;
		this.Show = data.Show;
		this.DisclaimerText = data.ComplianceDetail;
		this.CalculateGoodsName();
		this.CheckVersionGroupConflict();
	}

	// Token: 0x0600F52B RID: 62763 RVA: 0x0047948C File Offset: 0x0047768C
	public bool GetIfCanBuy()
	{
		if (this.IfRoleCallBackItem())
		{
			return this.IfHaveRoleCallBackItemNeedRole() && this.IfCanResonant();
		}
		if (this.IfRoleItem())
		{
			return this.IfCanBuyRoleItem();
		}
		return (!this.CheckIfMonthCardItem() || MonthCardModel.Instance.CheckMonthCardIfCanBuy()) && this.CanBuy;
	}

	// Token: 0x0600F52C RID: 62764 RVA: 0x004794E5 File Offset: 0x004776E5
	public bool GetCanBuyValue()
	{
		return this.CanBuy;
	}

	// Token: 0x0600F52D RID: 62765 RVA: 0x004794ED File Offset: 0x004776ED
	public bool IfRoleItem()
	{
		return InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.ItemId)) == InventoryDefine.EItemDataType.RoleItem;
	}

	// Token: 0x0600F52E RID: 62766 RVA: 0x00479508 File Offset: 0x00477708
	public bool IfRoleCallBackItem()
	{
		ItemConfig itemConfig = this.GetItemConfig();
		return itemConfig != null && itemConfig.ShowTypes != null && Array.IndexOf<int>(itemConfig.ShowTypes, 30) >= 0;
	}

	// Token: 0x0600F52F RID: 62767 RVA: 0x0047953E File Offset: 0x0047773E
	public bool IfCanBuyRoleItem()
	{
		return RoleModel.Instance.GetRoleInstanceById(this.ItemId) == null || RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(this.ItemId) > 0;
	}

	// Token: 0x0600F530 RID: 62768 RVA: 0x00479568 File Offset: 0x00477768
	public bool IfHaveRoleCallBackItemNeedRole()
	{
		if (this.IfRoleCallBackItem())
		{
			int id = RoleModel.Instance.GetResonantItemRoleId(this.ItemId)[0];
			if (RoleModel.Instance.GetRoleInstanceById(id) == null)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600F531 RID: 62769 RVA: 0x004795A0 File Offset: 0x004777A0
	public bool IfCanResonant()
	{
		if (this.IfRoleCallBackItem())
		{
			int roleId = RoleModel.Instance.GetResonantItemRoleId(this.ItemId)[0];
			if (RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(roleId) <= 0)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600F532 RID: 62770 RVA: 0x004795D9 File Offset: 0x004777D9
	public int GetBuyConditionId()
	{
		if (this.GoodType != PayShopGoodsData.EGoodType.PayGift)
		{
			return this.LimitBuyConditionId;
		}
		if (this.UnFinishedCondition != null && this.UnFinishedCondition.Count > 0)
		{
			return this.UnFinishedCondition[0];
		}
		return 0;
	}

	// Token: 0x0600F533 RID: 62771 RVA: 0x00479610 File Offset: 0x00477810
	[NullableContext(2)]
	public string GetUnFinishConditionText()
	{
		if (this.IfRoleCallBackItem())
		{
			if (!this.IfHaveRoleCallBackItemNeedRole())
			{
				return ConfigMultiTextLang.GetLocalTextNew("DontHaveRole", null);
			}
			if (!this.IfCanResonant())
			{
				return ConfigMultiTextLang.GetLocalTextNew("RoleBrenchItemMax", null);
			}
		}
		if (this.IfRoleItem())
		{
			return ConfigMultiTextLang.GetLocalTextNew("RoleBrenchItemMax", null);
		}
		if (this.CheckIfMonthCardItem())
		{
			return ConfigMultiTextLang.GetLocalTextNew("Text_MonthlyCardMax_Text", null);
		}
		int buyConditionId = this.GetBuyConditionId();
		if (buyConditionId != 0)
		{
			return ConfigMultiTextLang.GetLocalTextNew(LevelGeneralCommons.GetConditionGroupHintText(buyConditionId) ?? "", null);
		}
		return "";
	}

	// Token: 0x0600F534 RID: 62772 RVA: 0x0047969A File Offset: 0x0047789A
	public bool CheckIfMonthCardItem()
	{
		return this.Id == PayShopConfig.Instance.GetMonthCardShopId();
	}

	// Token: 0x0600F535 RID: 62773 RVA: 0x004796B0 File Offset: 0x004778B0
	private void CalculateGoodsName()
	{
		string text = "";
		if (text == "")
		{
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
			text = ConfigMultiTextLang.GetLocalTextNew(((itemConfigData != null) ? itemConfigData.Name : null) ?? "", null);
		}
		if (this.ItemCount > 1)
		{
			text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("GoodsName"), null), new string[]
			{
				text,
				this.ItemCount.ToString()
			});
		}
		this.CurrentNameLanguage = LanguageSystem.Instance.PackageLanguage;
		this.Name = text;
	}

	// Token: 0x0600F536 RID: 62774 RVA: 0x00479750 File Offset: 0x00477950
	public void PhraseFromPayPackageData(PayPackageData data)
	{
		this.Id = data.Id;
		this.ItemId = data.ItemId;
		this.ItemCount = data.ItemCount;
		this.Locked = data.IsLock;
		this.CanBuy = data.IsCanBuy;
		this.BuyLimit = data.BuyLimit;
		this.BoughtCount = data.BoughtCount;
		this.Price.Id = data.PayId;
		this.BeginTime = data.BeginTime;
		this.EndTime = data.EndTime;
		this.UpdateTime = data.UpdateTime;
		this.LastUpdateTime = data.LastUpdateTime;
		this.UpdateType = data.UpdateType;
		this.ShopItemType = PayShopDefine.EPayShopItemType.Direct;
		this.LabelId = data.LabelId;
		this.LabelBeginTime = 0L;
		this.LabelEndTime = 0L;
		this.Sort = data.Sort;
		this.PromotionShow = 0;
		this.TabId = data.TabId;
		this.StageImage = data.StageImage;
		this.ShowStageImage = data.ShowStageImage;
		this.GoodType = PayShopGoodsData.EGoodType.PayGift;
		this.NeedRemind = data.IsRemind;
		this.VersionGroupId = data.VersionGroupId;
		this.CloudGameTime = data.CloudGameTime;
		this.CloudGameIcon = data.CloudGameIcon;
		this.CloudGameDesc = data.CloudGameDesc;
		this.PayPackageType = new EPayGiftType?(data.Type);
		if (data.BuyCondition > 0)
		{
			this.UnFinishedCondition = new List<int>();
			this.UnFinishedCondition.Add(data.BuyCondition);
		}
		this.ProductId = data.ProductId;
		this.DisclaimerText = data.DisclaimerText;
		RechargeModel.Instance.SetRechargeInfo(data.PayId, data.Amount, data.ProductId);
		this.Name = data.GetName();
		this.CheckVersionGroupConflict();
	}

	// Token: 0x0600F537 RID: 62775 RVA: 0x00479918 File Offset: 0x00477B18
	public void PhraseFromTempData(int id, int count)
	{
		this.ItemId = id;
		this.ItemCount = count;
		this.GoodType = PayShopGoodsData.EGoodType.ClientItem;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(id);
		this.Name = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null);
	}

	// Token: 0x0600F538 RID: 62776 RVA: 0x00479958 File Offset: 0x00477B58
	[NullableContext(2)]
	public ItemConfig GetItemConfig()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.ItemId);
	}

	// Token: 0x0600F539 RID: 62777 RVA: 0x0047996A File Offset: 0x00477B6A
	public string GetGoodsName(string language)
	{
		if (this.CurrentNameLanguage != LanguageSystem.Instance.PackageLanguage)
		{
			this.CalculateGoodsName();
		}
		return this.Name;
	}

	// Token: 0x0600F53A RID: 62778 RVA: 0x0047998F File Offset: 0x00477B8F
	public bool IfMayReSell()
	{
		if (this.UpdateType != PayShopDefine.EPayShopUpdateType.None && this.UpdateType != PayShopDefine.EPayShopUpdateType.Forever)
		{
			if (this.EndTime == 0L)
			{
				return true;
			}
			if (this.UpdateTime < this.EndTime)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600F53B RID: 62779 RVA: 0x004799C0 File Offset: 0x00477BC0
	public bool InLabelShowTime()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return this.LabelId != 0 && ((this.LabelBeginTime > 0L && serverTime >= (double)this.LabelBeginTime && this.LabelEndTime == 0L) || (this.LabelBeginTime == 0L && this.LabelEndTime == 0L) || ((double)this.LabelEndTime > serverTime && serverTime >= (double)this.LabelBeginTime));
	}

	// Token: 0x0600F53C RID: 62780 RVA: 0x00479A2B File Offset: 0x00477C2B
	public int GetSortValue()
	{
		if (this.NeedDiscountSort())
		{
			return this.DiscountSort;
		}
		return this.Sort;
	}

	// Token: 0x0600F53D RID: 62781 RVA: 0x00479A42 File Offset: 0x00477C42
	private bool NeedDiscountSort()
	{
		return this.HasDiscount() && this.DiscountSort != 0 && this.GetIfCanBuy() && this.GetRemainingCount() != 0 && !this.IsDirect();
	}

	// Token: 0x0600F53E RID: 62782 RVA: 0x00479A73 File Offset: 0x00477C73
	public bool IsWeeklyRefresh()
	{
		return this.UpdateType != PayShopDefine.EPayShopUpdateType.None && this.UpdateType != PayShopDefine.EPayShopUpdateType.Forever;
	}

	// Token: 0x0600F53F RID: 62783 RVA: 0x00479A8B File Offset: 0x00477C8B
	public void SetShowAfterSoldOut(bool show)
	{
		this.ShowAfterSoldOut = show;
	}

	// Token: 0x0600F540 RID: 62784 RVA: 0x00479A94 File Offset: 0x00477C94
	public bool IfShowAfterSoldOut()
	{
		return this.ShowAfterSoldOut;
	}

	// Token: 0x0600F541 RID: 62785 RVA: 0x00479A9C File Offset: 0x00477C9C
	public bool HasDiscount()
	{
		if (this.Price.PromotionCount <= 0)
		{
			return false;
		}
		double serverTime = TimeUtil.Instance.GetServerTime();
		if ((this.EndPromotionTime == 0L && this.BeginPromotionTime == 0L) || (this.EndPromotionTime == 0L && this.BeginPromotionTime > 0L && serverTime >= (double)this.BeginPromotionTime))
		{
			return true;
		}
		bool flag = TimeUtil.Instance.IsExceededServerTime(this.EndPromotionTime);
		bool flag2 = (double)this.EndPromotionTime > serverTime && serverTime >= (double)this.BeginPromotionTime;
		return flag && flag2;
	}

	// Token: 0x0600F542 RID: 62786 RVA: 0x00479B20 File Offset: 0x00477D20
	public int? GetOriginalPrice()
	{
		if (this.HasDiscount())
		{
			return new int?(this.Price.Count);
		}
		return null;
	}

	// Token: 0x0600F543 RID: 62787 RVA: 0x00479B4F File Offset: 0x00477D4F
	public int GetDiscount()
	{
		if (this.PromotionShow > 0)
		{
			return this.PromotionShow / 100;
		}
		return this.Price.GetDiscount();
	}

	// Token: 0x0600F544 RID: 62788 RVA: 0x00479B6F File Offset: 0x00477D6F
	public int GetDiscountNew()
	{
		if (this.PromotionShow > 0)
		{
			return this.PromotionShow / 100;
		}
		return this.Price.GetDiscountNew();
	}

	// Token: 0x0600F545 RID: 62789 RVA: 0x00479B8F File Offset: 0x00477D8F
	public int GetRemainingCount()
	{
		return this.BuyLimit - this.BoughtCount;
	}

	// Token: 0x0600F546 RID: 62790 RVA: 0x00479B9E File Offset: 0x00477D9E
	public string GetRemainingTextId()
	{
		return PayShopDefine.payShopUpdateTypeTextId[this.UpdateType];
	}

	// Token: 0x0600F547 RID: 62791 RVA: 0x00479BB0 File Offset: 0x00477DB0
	public bool HasBuyLimit()
	{
		return this.BuyLimit > 0;
	}

	// Token: 0x0600F548 RID: 62792 RVA: 0x00479BBB File Offset: 0x00477DBB
	public bool HasOnceBuyLimit()
	{
		return this.OnceBuyLimit > 0;
	}

	// Token: 0x0600F549 RID: 62793 RVA: 0x00479BC6 File Offset: 0x00477DC6
	public void SetUnLock()
	{
		this.Locked = false;
	}

	// Token: 0x0600F54A RID: 62794 RVA: 0x00479BCF File Offset: 0x00477DCF
	public bool IsDirect()
	{
		return this.ShopItemType == PayShopDefine.EPayShopItemType.Direct;
	}

	// Token: 0x0600F54B RID: 62795 RVA: 0x00479BDA File Offset: 0x00477DDA
	public int GetNowPrice()
	{
		if (this.HasDiscount())
		{
			return this.Price.PromotionCount;
		}
		return this.Price.Count;
	}

	// Token: 0x0600F54C RID: 62796 RVA: 0x00479BFB File Offset: 0x00477DFB
	public bool IsShowInShop()
	{
		if (this.GoodType == PayShopGoodsData.EGoodType.DiscountItem)
		{
			return this.Show && !this.Locked;
		}
		return this.GoodType != PayShopGoodsData.EGoodType.PayGift || !this.Locked;
	}

	// Token: 0x0600F54D RID: 62797 RVA: 0x00479C2D File Offset: 0x00477E2D
	public bool IfPayGift()
	{
		return this.GoodType == PayShopGoodsData.EGoodType.PayGift;
	}

	// Token: 0x0600F54E RID: 62798 RVA: 0x00479C38 File Offset: 0x00477E38
	public int? GetGiftId()
	{
		int? result = null;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
		if (itemConfigData.ItemType.GetValueOrDefault() == InventoryDefine.EItemType.Gift)
		{
			int value;
			if (itemConfigData.Parameters.TryGetValue(2, out value))
			{
				result = new int?(value);
			}
			int value2;
			if (result == null && itemConfigData.Parameters.TryGetValue(4, out value2))
			{
				result = new int?(value2);
			}
		}
		return result;
	}

	// Token: 0x0600F54F RID: 62799 RVA: 0x00479CA7 File Offset: 0x00477EA7
	public InventoryDefine.EItemType? GetRewardItemType()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.ItemId).ItemType;
	}

	// Token: 0x0600F550 RID: 62800 RVA: 0x00479CBE File Offset: 0x00477EBE
	public string GetProductId()
	{
		return this.ProductId;
	}

	// Token: 0x0600F551 RID: 62801 RVA: 0x00479CC8 File Offset: 0x00477EC8
	public bool GetIfNeedRemind()
	{
		if (this.VersionGroupId > 0)
		{
			int? num = this.GetVersionRedDotStorage().Get(this.Id);
			if (this.NeedRemind)
			{
				int? num2 = num;
				int versionGroupId = this.VersionGroupId;
				return !(num2.GetValueOrDefault() == versionGroupId & num2 != null);
			}
			return false;
		}
		else
		{
			bool flag = true;
			if (this.GoodType != PayShopGoodsData.EGoodType.PayGift)
			{
				PayShopInfoData payShopInfoById = PayShopModel.Instance.GetPayShopInfoById((PayShopDefine.EPayShopTabType)this.ShopId);
				flag = (payShopInfoById != null && payShopInfoById.EnableServerRedDot);
			}
			if (!flag)
			{
				return false;
			}
			int? num3 = this.GetReadTimeStorage().Get(this.Id);
			uint? num4 = (num3 == null) ? null : new uint?((uint)num3.Value);
			long num5 = (long)Math.Floor((double)this.LastUpdateTime / 1000.0);
			long num6 = (long)Math.Floor((double)this.UpdateTime / 1000.0);
			if (this.LastUpdateTime > 0L && num4 != null)
			{
				uint? num7 = num4;
				uint num8 = 0U;
				if (num7.GetValueOrDefault() > num8 & num7 != null)
				{
					num7 = num4;
					long? num9 = (num7 != null) ? new long?((long)((ulong)num7.GetValueOrDefault())) : null;
					long num10 = num5;
					if (num9.GetValueOrDefault() > num10 & num9 != null)
					{
						num7 = num4;
						num9 = ((num7 != null) ? new long?((long)((ulong)num7.GetValueOrDefault())) : null);
						num10 = num6;
						if (num9.GetValueOrDefault() < num10 & num9 != null)
						{
							return false;
						}
					}
				}
			}
			else if (num4 != null)
			{
				uint? num7 = num4;
				uint num8 = 0U;
				if (num7.GetValueOrDefault() > num8 & num7 != null)
				{
					return false;
				}
			}
			return this.NeedRemind;
		}
	}

	// Token: 0x0600F552 RID: 62802 RVA: 0x00479E9C File Offset: 0x0047809C
	public int SaveRemindState(long timestamp)
	{
		if (this.VersionGroupId > 0)
		{
			ServerStorageMap versionRedDotStorage = this.GetVersionRedDotStorage();
			int? num = versionRedDotStorage.Get(this.Id);
			int versionGroupId = this.VersionGroupId;
			if (num.GetValueOrDefault() == versionGroupId & num != null)
			{
				return -1;
			}
			versionRedDotStorage.Set(this.Id, this.VersionGroupId);
			return 0;
		}
		else
		{
			bool flag = true;
			if (this.GoodType != PayShopGoodsData.EGoodType.PayGift)
			{
				PayShopInfoData payShopInfoById = PayShopModel.Instance.GetPayShopInfoById((PayShopDefine.EPayShopTabType)this.ShopId);
				flag = (payShopInfoById != null && payShopInfoById.EnableServerRedDot);
			}
			if (!flag)
			{
				return 0;
			}
			ServerStorageMap readTimeStorage = this.GetReadTimeStorage();
			int? num2 = readTimeStorage.Get(this.Id);
			uint? num3 = (num2 == null) ? null : new uint?((uint)num2.Value);
			long num4 = (long)Math.Floor((double)this.LastUpdateTime / 1000.0);
			long num5 = (long)Math.Floor((double)this.UpdateTime / 1000.0);
			if (this.LastUpdateTime == 0L)
			{
				if (num3 != null)
				{
					uint? num6 = num3;
					uint num7 = 0U;
					if (num6.GetValueOrDefault() > num7 & num6 != null)
					{
						return -1;
					}
				}
			}
			else if (num3 != null)
			{
				uint? num6 = num3;
				long? num8 = (num6 != null) ? new long?((long)((ulong)num6.GetValueOrDefault())) : null;
				long num9 = num4;
				if (num8.GetValueOrDefault() > num9 & num8 != null)
				{
					num6 = num3;
					num8 = ((num6 != null) ? new long?((long)((ulong)num6.GetValueOrDefault())) : null);
					num9 = num5;
					if (num8.GetValueOrDefault() < num9 & num8 != null)
					{
						return -1;
					}
				}
			}
			long num10 = (long)Math.Floor((double)timestamp / 1000.0);
			readTimeStorage.Set(this.Id, (int)num10);
			return 0;
		}
	}

	// Token: 0x0600F553 RID: 62803 RVA: 0x0047A07D File Offset: 0x0047827D
	private ServerStorageMap GetVersionRedDotStorage()
	{
		return (ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VersionPayGiftRedDot);
	}

	// Token: 0x0600F554 RID: 62804 RVA: 0x0047A090 File Offset: 0x00478290
	private ServerStorageMap GetReadTimeStorage()
	{
		return (ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.NormalPayGiftRedDot);
	}

	// Token: 0x0600F555 RID: 62805 RVA: 0x0047A0A4 File Offset: 0x004782A4
	private unsafe void CheckVersionGroupConflict()
	{
		if (this.VersionGroupId > 0 && this.UpdateType != PayShopDefine.EPayShopUpdateType.None)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shop;
			ELogAuthor author = ELogAuthor.CCJ;
			string message = "版本礼包不应同时配置周期刷新";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("goodsId", this.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("versionGroupId", this.VersionGroupId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("updateType", this.UpdateType);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
	}

	// Token: 0x0600F556 RID: 62806 RVA: 0x0047A154 File Offset: 0x00478354
	public List<int> GetCouponList()
	{
		List<int> list = new List<int>();
		foreach (int num in this.Coupons)
		{
			if (num > 0)
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x0400896F RID: 35183
	public int Id;

	// Token: 0x04008970 RID: 35184
	public int TabId;

	// Token: 0x04008971 RID: 35185
	public int ShopId;

	// Token: 0x04008972 RID: 35186
	public int ItemId;

	// Token: 0x04008973 RID: 35187
	public int ShopItemQuality;

	// Token: 0x04008974 RID: 35188
	public int ItemCount;

	// Token: 0x04008975 RID: 35189
	public bool Locked;

	// Token: 0x04008976 RID: 35190
	private bool CanBuy = true;

	// Token: 0x04008977 RID: 35191
	public int BuyLimit;

	// Token: 0x04008978 RID: 35192
	public int OnceBuyLimit;

	// Token: 0x04008979 RID: 35193
	public int BoughtCount;

	// Token: 0x0400897A RID: 35194
	public PayShopGoodsPrice Price = new PayShopGoodsPrice();

	// Token: 0x0400897B RID: 35195
	public PayShopDefine.EPayShopUpdateType UpdateType;

	// Token: 0x0400897C RID: 35196
	public PayShopDefine.EPayShopItemType ShopItemType;

	// Token: 0x0400897D RID: 35197
	public long BeginTime;

	// Token: 0x0400897E RID: 35198
	public long EndTime;

	// Token: 0x0400897F RID: 35199
	public long BeginPromotionTime;

	// Token: 0x04008980 RID: 35200
	public long EndPromotionTime;

	// Token: 0x04008981 RID: 35201
	public long UpdateTime;

	// Token: 0x04008982 RID: 35202
	public int LabelId;

	// Token: 0x04008983 RID: 35203
	public long LabelBeginTime;

	// Token: 0x04008984 RID: 35204
	public long LabelEndTime;

	// Token: 0x04008985 RID: 35205
	public int Sort;

	// Token: 0x04008986 RID: 35206
	public int DiscountSort;

	// Token: 0x04008987 RID: 35207
	public bool Show = true;

	// Token: 0x04008988 RID: 35208
	public int PromotionShow;

	// Token: 0x04008989 RID: 35209
	private string Name = "";

	// Token: 0x0400898A RID: 35210
	public string StageImage = "";

	// Token: 0x0400898B RID: 35211
	private PayShopGoodsData.EGoodType GoodType;

	// Token: 0x0400898C RID: 35212
	private string CurrentNameLanguage = "";

	// Token: 0x0400898D RID: 35213
	private bool ShowAfterSoldOut;

	// Token: 0x0400898E RID: 35214
	[Nullable(2)]
	public List<int> UnFinishedCondition;

	// Token: 0x0400898F RID: 35215
	public int LimitBuyConditionId;

	// Token: 0x04008990 RID: 35216
	private bool NeedRemind;

	// Token: 0x04008991 RID: 35217
	private int VersionGroupId;

	// Token: 0x04008992 RID: 35218
	private string ProductId = "";

	// Token: 0x04008993 RID: 35219
	private List<int> Coupons = new List<int>();

	// Token: 0x04008994 RID: 35220
	public int CloudGameTime;

	// Token: 0x04008995 RID: 35221
	public string CloudGameIcon = "";

	// Token: 0x04008996 RID: 35222
	public string CloudGameDesc = "";

	// Token: 0x04008997 RID: 35223
	private long LastUpdateTime;

	// Token: 0x04008998 RID: 35224
	public string ShowStageImage = "";

	// Token: 0x04008999 RID: 35225
	public string DisclaimerText = "";

	// Token: 0x0400899A RID: 35226
	public bool ShowRecommendTag;

	// Token: 0x0400899B RID: 35227
	public bool IsShowHaveNum;

	// Token: 0x0400899C RID: 35228
	public bool IsBuyMaxButton;

	// Token: 0x0400899D RID: 35229
	public EPayGiftType? PayPackageType;

	// Token: 0x0400899E RID: 35230
	public int ConfirmLimitCount;

	// Token: 0x0400899F RID: 35231
	public long ShowBeginTime;

	// Token: 0x040089A0 RID: 35232
	public long ShowEndTime;

	// Token: 0x02007A6A RID: 31338
	[NullableContext(0)]
	private enum EGoodType
	{
		// Token: 0x04027AC5 RID: 162501
		ClientItem = -1,
		// Token: 0x04027AC6 RID: 162502
		DiscountItem,
		// Token: 0x04027AC7 RID: 162503
		PayGift
	}
}
