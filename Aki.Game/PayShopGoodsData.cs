using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02002358 RID: 9048
[NullableContext(1)]
[Nullable(0)]
public class PayShopGoodsData
{
	// Token: 0x0601207A RID: 73850 RVA: 0x0046C15C File Offset: 0x0046A35C
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
		this.ShowAfterSoldOut = data.SoldoutShowInShop;
		this.NeedRemind = data.IsRemind;
		this.StageImage = data.StageImage;
		this.ShowStageImage = data.ShowStageImage;
		this.Show = data.Show;
		this.DisclaimerText = data.ComplianceDetail;
		this.CalculateGoodsName();
		this.CheckVersionGroupConflict();
	}

	// Token: 0x0601207B RID: 73851 RVA: 0x0046C3D0 File Offset: 0x0046A5D0
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

	// Token: 0x0601207C RID: 73852 RVA: 0x0046C429 File Offset: 0x0046A629
	public bool GetCanBuyValue()
	{
		return this.CanBuy;
	}

	// Token: 0x0601207D RID: 73853 RVA: 0x0046C431 File Offset: 0x0046A631
	public bool IfRoleItem()
	{
		return InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(this.ItemId)) == InventoryDefine.EItemDataType.RoleItem;
	}

	// Token: 0x0601207E RID: 73854 RVA: 0x0046C44C File Offset: 0x0046A64C
	public bool IfRoleCallBackItem()
	{
		ItemConfig itemConfig = this.GetItemConfig();
		return itemConfig != null && itemConfig.ShowTypes != null && itemConfig.ShowTypes.Contains(30);
	}

	// Token: 0x0601207F RID: 73855 RVA: 0x0046C47C File Offset: 0x0046A67C
	public bool IfCanBuyRoleItem()
	{
		return RoleModel.Instance.GetRoleInstanceById(this.ItemId) == null || RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(this.ItemId) > 0;
	}

	// Token: 0x06012080 RID: 73856 RVA: 0x0046C4A8 File Offset: 0x0046A6A8
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

	// Token: 0x06012081 RID: 73857 RVA: 0x0046C4E0 File Offset: 0x0046A6E0
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

	// Token: 0x06012082 RID: 73858 RVA: 0x0046C519 File Offset: 0x0046A719
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

	// Token: 0x06012083 RID: 73859 RVA: 0x0046C550 File Offset: 0x0046A750
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

	// Token: 0x06012084 RID: 73860 RVA: 0x0046C5DA File Offset: 0x0046A7DA
	public bool CheckIfMonthCardItem()
	{
		return this.Id == PayShopConfig.Instance.GetMonthCardShopId();
	}

	// Token: 0x06012085 RID: 73861 RVA: 0x0046C5F0 File Offset: 0x0046A7F0
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

	// Token: 0x06012086 RID: 73862 RVA: 0x0046C690 File Offset: 0x0046A890
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

	// Token: 0x06012087 RID: 73863 RVA: 0x0046C858 File Offset: 0x0046AA58
	public void PhraseFromTempData(int id, int count)
	{
		this.ItemId = id;
		this.ItemCount = count;
		this.GoodType = PayShopGoodsData.EGoodType.ClientItem;
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(id);
		this.Name = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null);
	}

	// Token: 0x06012088 RID: 73864 RVA: 0x0046C898 File Offset: 0x0046AA98
	[NullableContext(2)]
	public ItemConfig GetItemConfig()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.ItemId);
	}

	// Token: 0x06012089 RID: 73865 RVA: 0x0046C8AA File Offset: 0x0046AAAA
	public string GetGoodsName(string language)
	{
		if (this.CurrentNameLanguage != LanguageSystem.Instance.PackageLanguage)
		{
			this.CalculateGoodsName();
		}
		return this.Name;
	}

	// Token: 0x0601208A RID: 73866 RVA: 0x0046C8CF File Offset: 0x0046AACF
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

	// Token: 0x0601208B RID: 73867 RVA: 0x0046C900 File Offset: 0x0046AB00
	public bool InLabelShowTime()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return this.LabelId != 0 && ((this.LabelBeginTime > 0L && serverTime >= (double)this.LabelBeginTime && this.LabelEndTime == 0L) || (this.LabelBeginTime == 0L && this.LabelEndTime == 0L) || ((double)this.LabelEndTime > serverTime && serverTime >= (double)this.LabelBeginTime));
	}

	// Token: 0x0601208C RID: 73868 RVA: 0x0046C96B File Offset: 0x0046AB6B
	public int GetSortValue()
	{
		if (this.NeedDiscountSort())
		{
			return this.DiscountSort;
		}
		return this.Sort;
	}

	// Token: 0x0601208D RID: 73869 RVA: 0x0046C982 File Offset: 0x0046AB82
	private bool NeedDiscountSort()
	{
		return this.HasDiscount() && this.DiscountSort != 0 && this.GetIfCanBuy() && this.GetRemainingCount() != 0 && !this.IsDirect();
	}

	// Token: 0x0601208E RID: 73870 RVA: 0x0046C9B3 File Offset: 0x0046ABB3
	public bool IsWeeklyRefresh()
	{
		return this.UpdateType != PayShopDefine.EPayShopUpdateType.None && this.UpdateType != PayShopDefine.EPayShopUpdateType.Forever;
	}

	// Token: 0x0601208F RID: 73871 RVA: 0x0046C9CB File Offset: 0x0046ABCB
	public void SetShowAfterSoldOut(bool show)
	{
		this.ShowAfterSoldOut = show;
	}

	// Token: 0x06012090 RID: 73872 RVA: 0x0046C9D4 File Offset: 0x0046ABD4
	public bool IfShowAfterSoldOut()
	{
		return this.ShowAfterSoldOut;
	}

	// Token: 0x06012091 RID: 73873 RVA: 0x0046C9DC File Offset: 0x0046ABDC
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

	// Token: 0x06012092 RID: 73874 RVA: 0x0046CA60 File Offset: 0x0046AC60
	public int? GetOriginalPrice()
	{
		if (this.HasDiscount())
		{
			return new int?(this.Price.Count);
		}
		return null;
	}

	// Token: 0x06012093 RID: 73875 RVA: 0x0046CA8F File Offset: 0x0046AC8F
	public int GetDiscount()
	{
		if (this.PromotionShow > 0)
		{
			return this.PromotionShow / 100;
		}
		return this.Price.GetDiscount();
	}

	// Token: 0x06012094 RID: 73876 RVA: 0x0046CAAF File Offset: 0x0046ACAF
	public int GetDiscountNew()
	{
		if (this.PromotionShow > 0)
		{
			return this.PromotionShow / 100;
		}
		return this.Price.GetDiscountNew();
	}

	// Token: 0x06012095 RID: 73877 RVA: 0x0046CACF File Offset: 0x0046ACCF
	public int GetRemainingCount()
	{
		return this.BuyLimit - this.BoughtCount;
	}

	// Token: 0x06012096 RID: 73878 RVA: 0x0046CADE File Offset: 0x0046ACDE
	public string GetRemainingTextId()
	{
		return PayShopDefine.payShopUpdateTypeTextId[this.UpdateType];
	}

	// Token: 0x06012097 RID: 73879 RVA: 0x0046CAF0 File Offset: 0x0046ACF0
	public bool HasBuyLimit()
	{
		return this.BuyLimit > 0;
	}

	// Token: 0x06012098 RID: 73880 RVA: 0x0046CAFB File Offset: 0x0046ACFB
	public bool HasOnceBuyLimit()
	{
		return this.OnceBuyLimit > 0;
	}

	// Token: 0x06012099 RID: 73881 RVA: 0x0046CB06 File Offset: 0x0046AD06
	public void SetUnLock()
	{
		this.Locked = false;
	}

	// Token: 0x0601209A RID: 73882 RVA: 0x0046CB0F File Offset: 0x0046AD0F
	public bool IsDirect()
	{
		return this.ShopItemType == PayShopDefine.EPayShopItemType.Direct;
	}

	// Token: 0x0601209B RID: 73883 RVA: 0x0046CB1A File Offset: 0x0046AD1A
	public int GetNowPrice()
	{
		if (this.HasDiscount())
		{
			return this.Price.PromotionCount;
		}
		return this.Price.Count;
	}

	// Token: 0x0601209C RID: 73884 RVA: 0x0046CB3B File Offset: 0x0046AD3B
	public bool IsShowInShop()
	{
		if (this.GoodType == PayShopGoodsData.EGoodType.DiscountItem)
		{
			return this.Show && !this.Locked;
		}
		return this.GoodType != PayShopGoodsData.EGoodType.PayGift || !this.Locked;
	}

	// Token: 0x0601209D RID: 73885 RVA: 0x0046CB6D File Offset: 0x0046AD6D
	public bool IfPayGift()
	{
		return this.GoodType == PayShopGoodsData.EGoodType.PayGift;
	}

	// Token: 0x0601209E RID: 73886 RVA: 0x0046CB78 File Offset: 0x0046AD78
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

	// Token: 0x0601209F RID: 73887 RVA: 0x0046CBE7 File Offset: 0x0046ADE7
	public InventoryDefine.EItemType? GetRewardItemType()
	{
		return InventoryConfig.Instance.GetItemConfigData(this.ItemId).ItemType;
	}

	// Token: 0x060120A0 RID: 73888 RVA: 0x0046CBFE File Offset: 0x0046ADFE
	public string GetProductId()
	{
		return this.ProductId;
	}

	// Token: 0x060120A1 RID: 73889 RVA: 0x0046CC08 File Offset: 0x0046AE08
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

	// Token: 0x060120A2 RID: 73890 RVA: 0x0046CDDC File Offset: 0x0046AFDC
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

	// Token: 0x060120A3 RID: 73891 RVA: 0x0046CFBD File Offset: 0x0046B1BD
	private ServerStorageMap GetVersionRedDotStorage()
	{
		return (ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.VersionPayGiftRedDot);
	}

	// Token: 0x060120A4 RID: 73892 RVA: 0x0046CFD0 File Offset: 0x0046B1D0
	private ServerStorageMap GetReadTimeStorage()
	{
		return (ServerStorageMap)ServerStorageModel.Instance.Get(EClientStorageSystemIdType.NormalPayGiftRedDot);
	}

	// Token: 0x060120A5 RID: 73893 RVA: 0x0046CFE4 File Offset: 0x0046B1E4
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

	// Token: 0x060120A6 RID: 73894 RVA: 0x0046D094 File Offset: 0x0046B294
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

	// Token: 0x0400882C RID: 34860
	public int Id;

	// Token: 0x0400882D RID: 34861
	public int TabId;

	// Token: 0x0400882E RID: 34862
	public int ShopId;

	// Token: 0x0400882F RID: 34863
	public int ItemId;

	// Token: 0x04008830 RID: 34864
	public int ShopItemQuality;

	// Token: 0x04008831 RID: 34865
	public int ItemCount;

	// Token: 0x04008832 RID: 34866
	public bool Locked;

	// Token: 0x04008833 RID: 34867
	private bool CanBuy = true;

	// Token: 0x04008834 RID: 34868
	public int BuyLimit;

	// Token: 0x04008835 RID: 34869
	public int OnceBuyLimit;

	// Token: 0x04008836 RID: 34870
	public int BoughtCount;

	// Token: 0x04008837 RID: 34871
	public PayShopGoodsPrice Price = new PayShopGoodsPrice();

	// Token: 0x04008838 RID: 34872
	public PayShopDefine.EPayShopUpdateType UpdateType;

	// Token: 0x04008839 RID: 34873
	public PayShopDefine.EPayShopItemType ShopItemType;

	// Token: 0x0400883A RID: 34874
	public long BeginTime;

	// Token: 0x0400883B RID: 34875
	public long EndTime;

	// Token: 0x0400883C RID: 34876
	public long BeginPromotionTime;

	// Token: 0x0400883D RID: 34877
	public long EndPromotionTime;

	// Token: 0x0400883E RID: 34878
	public long UpdateTime;

	// Token: 0x0400883F RID: 34879
	public int LabelId;

	// Token: 0x04008840 RID: 34880
	public long LabelBeginTime;

	// Token: 0x04008841 RID: 34881
	public long LabelEndTime;

	// Token: 0x04008842 RID: 34882
	public int Sort;

	// Token: 0x04008843 RID: 34883
	public int DiscountSort;

	// Token: 0x04008844 RID: 34884
	public bool Show = true;

	// Token: 0x04008845 RID: 34885
	public int PromotionShow;

	// Token: 0x04008846 RID: 34886
	private string Name = "";

	// Token: 0x04008847 RID: 34887
	public string StageImage = "";

	// Token: 0x04008848 RID: 34888
	private PayShopGoodsData.EGoodType GoodType;

	// Token: 0x04008849 RID: 34889
	private string CurrentNameLanguage = "";

	// Token: 0x0400884A RID: 34890
	private bool ShowAfterSoldOut;

	// Token: 0x0400884B RID: 34891
	[Nullable(2)]
	public List<int> UnFinishedCondition;

	// Token: 0x0400884C RID: 34892
	public int LimitBuyConditionId;

	// Token: 0x0400884D RID: 34893
	private bool NeedRemind;

	// Token: 0x0400884E RID: 34894
	private int VersionGroupId;

	// Token: 0x0400884F RID: 34895
	private string ProductId = "";

	// Token: 0x04008850 RID: 34896
	private List<int> Coupons = new List<int>();

	// Token: 0x04008851 RID: 34897
	public int CloudGameTime;

	// Token: 0x04008852 RID: 34898
	public string CloudGameIcon = "";

	// Token: 0x04008853 RID: 34899
	public string CloudGameDesc = "";

	// Token: 0x04008854 RID: 34900
	private long LastUpdateTime;

	// Token: 0x04008855 RID: 34901
	public string ShowStageImage = "";

	// Token: 0x04008856 RID: 34902
	public string DisclaimerText = "";

	// Token: 0x04008857 RID: 34903
	public bool ShowRecommendTag;

	// Token: 0x04008858 RID: 34904
	public bool IsShowHaveNum;

	// Token: 0x04008859 RID: 34905
	public bool IsBuyMaxButton;

	// Token: 0x0400885A RID: 34906
	public EPayGiftType? PayPackageType;

	// Token: 0x0400885B RID: 34907
	public int ConfirmLimitCount;

	// Token: 0x020088E1 RID: 35041
	[NullableContext(0)]
	private enum EGoodType
	{
		// Token: 0x0402C7B1 RID: 182193
		ClientItem = -1,
		// Token: 0x0402C7B2 RID: 182194
		DiscountItem,
		// Token: 0x0402C7B3 RID: 182195
		PayGift
	}
}
