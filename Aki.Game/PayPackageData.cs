using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Launcher.Platform.PlatformSdk;

// Token: 0x0200183C RID: 6204
[NullableContext(1)]
[Nullable(0)]
public class PayPackageData
{
	// Token: 0x0600F51E RID: 62750 RVA: 0x00478CDC File Offset: 0x00476EDC
	public void Phrase(PayGiftInfo payGiftInfo)
	{
		this.Id = payGiftInfo.Id;
		this.PayId = payGiftInfo.PayId;
		this.ItemId = payGiftInfo.ItemId;
		this.ItemCount = payGiftInfo.ItemCount;
		this.Sort = payGiftInfo.Sort;
		this.BuyLimit = payGiftInfo.BuyLimit;
		this.BoughtCount = payGiftInfo.BoughtCount;
		this.StageImage = (payGiftInfo.StageImage ?? "");
		this.ShowStageImage = (payGiftInfo.ShowStageImage ?? "");
		this.BeginTime = payGiftInfo.BeginTime;
		this.EndTime = payGiftInfo.EndTime;
		this.UpdateTime = payGiftInfo.UpdateTime;
		this.LastUpdateTime = payGiftInfo.LastUpdateTime;
		this.UpdateType = (PayShopDefine.EPayShopUpdateType)payGiftInfo.UpdateType;
		this.ProductId = (payGiftInfo.ProductId ?? "");
		this.Amount = (payGiftInfo.Amount ?? "");
		this.TabId = payGiftInfo.TabId;
		this.Type = (EPayGiftType)payGiftInfo.Type;
		this.IsLock = payGiftInfo.Locked;
		this.IsCanBuy = payGiftInfo.IsCanBuy;
		this.IsRemind = payGiftInfo.IsRemind;
		this.VersionGroupId = payGiftInfo.VersionId;
		this.BuyCondition = payGiftInfo.BuyConditionId;
		this.CloudGameTime = payGiftInfo.CloudGameTime;
		this.CloudGameIcon = (payGiftInfo.CloudGameIcon ?? "");
		this.CloudGameDesc = (payGiftInfo.Desc ?? "");
		this.LabelId = payGiftInfo.Tag;
		this.PromotionShow = payGiftInfo.PromotionShow;
		this.NeedConsoleRulePrompt = payGiftInfo.NeedConsoleRulePrompt;
		this.CurrencyDiscountTags.Clear();
		foreach (KeyValuePair<string, int> keyValuePair in payGiftInfo.CurrencyDiscountTags)
		{
			this.CurrencyDiscountTags.Add(keyValuePair.Key, keyValuePair.Value);
		}
		this.DisclaimerText = payGiftInfo.ComplianceDetail;
		this.ShopId = this.ResolveShopId(payGiftInfo.ShopId);
		this.CalculateGoodsName();
		if (this.PayShopGoods == null)
		{
			this.PayShopGoods = new PayShopGoods(this.ShopId);
		}
		else
		{
			this.PayShopGoods.SetPayShopId(this.ShopId);
		}
		this.PayShopGoods.SetGoodsData(this.ConvertToPayShopGoodsData());
		this.PayShopGoods.SetPayGiftId(this.Id);
		if (this.ShowInSkinTab())
		{
			PayShopGoodsData goodsData = this.PayShopGoods.GetGoodsData();
			if (goodsData == null)
			{
				return;
			}
			goodsData.SetShowAfterSoldOut(true);
		}
	}

	// Token: 0x0600F51F RID: 62751 RVA: 0x00478F68 File Offset: 0x00477168
	private unsafe PayShopDefine.EPayShopTabType ResolveShopId(int rawShopId)
	{
		if (rawShopId == 0)
		{
			return PayShopDefine.EPayShopTabType.GiftBag;
		}
		if (rawShopId == 3 || rawShopId == 7)
		{
			return (PayShopDefine.EPayShopTabType)rawShopId;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Shop;
		ELogAuthor author = ELogAuthor.TZJ;
		string message = "[礼包商店区分] PayPackageData unknown Proto_ShopId, fallback to GiftBag";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", this.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Proto_ShopId", rawShopId);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return PayShopDefine.EPayShopTabType.GiftBag;
	}

	// Token: 0x0600F520 RID: 62752 RVA: 0x00478FE8 File Offset: 0x004771E8
	private void CalculateGoodsName()
	{
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(this.ItemId);
		if (itemConfigData != null)
		{
			this.Name = ConfigMultiTextLang.GetLocalTextNew(itemConfigData.Name, null);
		}
		if (this.ItemCount > 1)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(TextConfig.Instance.GetTextContentIdById("GoodsName"), null);
			this.Name = StringUtils.Format(localTextNew, new string[]
			{
				this.Name,
				this.ItemCount.ToString()
			});
		}
	}

	// Token: 0x0600F521 RID: 62753 RVA: 0x00479063 File Offset: 0x00477263
	public bool ShowInShop()
	{
		return this.Type != EPayGiftType.BattlePass && !this.ShowInSkinTab() && this.Type != EPayGiftType.RegressBp && this.Type != EPayGiftType.WeekCard;
	}

	// Token: 0x0600F522 RID: 62754 RVA: 0x00479090 File Offset: 0x00477290
	public bool ShowInSkinTab()
	{
		PayShopGoods payShopGoods = this.PayShopGoods;
		return payShopGoods != null && this.Type != EPayGiftType.CdkGift && (payShopGoods.CheckIfRoleSkinGoods() || payShopGoods.CheckIfFlySkinGoods() || payShopGoods.CheckIfMotorSkinGoods() || payShopGoods.CheckIfOrnamentGoods());
	}

	// Token: 0x0600F523 RID: 62755 RVA: 0x004790D4 File Offset: 0x004772D4
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x0600F524 RID: 62756 RVA: 0x004790DC File Offset: 0x004772DC
	[NullableContext(2)]
	public PayShopGoods GetPayShopGoods()
	{
		return this.PayShopGoods;
	}

	// Token: 0x0600F525 RID: 62757 RVA: 0x004790E4 File Offset: 0x004772E4
	public int GetDiscount()
	{
		string queryProductCurrency = KuroSdkModel.Instance.GetQueryProductCurrency(this.PayId.ToString());
		int result;
		if (this.CurrencyDiscountTags.TryGetValue(queryProductCurrency, out result))
		{
			return result;
		}
		int result2;
		if (this.CurrencyDiscountTags.TryGetValue("Default", out result2))
		{
			return result2;
		}
		return 0;
	}

	// Token: 0x0600F526 RID: 62758 RVA: 0x00479130 File Offset: 0x00477330
	public bool HasDiscount()
	{
		return this.GetDiscount() > 0;
	}

	// Token: 0x0600F527 RID: 62759 RVA: 0x0047913B File Offset: 0x0047733B
	private PayShopGoodsData ConvertToPayShopGoodsData()
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.PhraseFromPayPackageData(this);
		return payShopGoodsData;
	}

	// Token: 0x0600F528 RID: 62760 RVA: 0x00479149 File Offset: 0x00477349
	public bool CanShowInShopTab()
	{
		return !PlatformSdkManagerNew.Instance.GetPlatformSdk().NeedConfirmSdkProductInfo() || PayItemModel.Instance.GetProductInfoByGoodsId(this.ProductId) != null;
	}

	// Token: 0x0400894C RID: 35148
	private const string DEFAULTCURRENCYKEY = "Default";

	// Token: 0x0400894D RID: 35149
	private string Name = "";

	// Token: 0x0400894E RID: 35150
	[Nullable(2)]
	private PayShopGoods PayShopGoods;

	// Token: 0x0400894F RID: 35151
	public int Id;

	// Token: 0x04008950 RID: 35152
	public int PayId;

	// Token: 0x04008951 RID: 35153
	public int ItemId;

	// Token: 0x04008952 RID: 35154
	public int ItemCount;

	// Token: 0x04008953 RID: 35155
	public int Sort;

	// Token: 0x04008954 RID: 35156
	public int BuyLimit;

	// Token: 0x04008955 RID: 35157
	public int BoughtCount;

	// Token: 0x04008956 RID: 35158
	public string StageImage = "";

	// Token: 0x04008957 RID: 35159
	public string ShowStageImage = "";

	// Token: 0x04008958 RID: 35160
	public long BeginTime;

	// Token: 0x04008959 RID: 35161
	public long EndTime;

	// Token: 0x0400895A RID: 35162
	public long UpdateTime;

	// Token: 0x0400895B RID: 35163
	public PayShopDefine.EPayShopUpdateType UpdateType;

	// Token: 0x0400895C RID: 35164
	public string ProductId = "";

	// Token: 0x0400895D RID: 35165
	public string Amount = "";

	// Token: 0x0400895E RID: 35166
	public int TabId;

	// Token: 0x0400895F RID: 35167
	public EPayGiftType Type = EPayGiftType.LimitGift;

	// Token: 0x04008960 RID: 35168
	public bool IsLock;

	// Token: 0x04008961 RID: 35169
	public bool IsCanBuy = true;

	// Token: 0x04008962 RID: 35170
	public bool IsRemind;

	// Token: 0x04008963 RID: 35171
	public int VersionGroupId;

	// Token: 0x04008964 RID: 35172
	public int BuyCondition;

	// Token: 0x04008965 RID: 35173
	public int CloudGameTime;

	// Token: 0x04008966 RID: 35174
	public string CloudGameIcon = "";

	// Token: 0x04008967 RID: 35175
	public string CloudGameDesc = "";

	// Token: 0x04008968 RID: 35176
	public int LabelId;

	// Token: 0x04008969 RID: 35177
	public long LastUpdateTime;

	// Token: 0x0400896A RID: 35178
	public int PromotionShow;

	// Token: 0x0400896B RID: 35179
	public Dictionary<string, int> CurrencyDiscountTags = new Dictionary<string, int>();

	// Token: 0x0400896C RID: 35180
	public string DisclaimerText = "";

	// Token: 0x0400896D RID: 35181
	public PayShopDefine.EPayShopTabType ShopId = PayShopDefine.EPayShopTabType.GiftBag;

	// Token: 0x0400896E RID: 35182
	public bool NeedConsoleRulePrompt;
}
