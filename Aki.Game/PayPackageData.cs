using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Launcher.Platform.PlatformSdk;

// Token: 0x02002357 RID: 9047
[NullableContext(1)]
[Nullable(0)]
public class PayPackageData
{
	// Token: 0x0601206E RID: 73838 RVA: 0x0046BC38 File Offset: 0x00469E38
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

	// Token: 0x0601206F RID: 73839 RVA: 0x0046BEC4 File Offset: 0x0046A0C4
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

	// Token: 0x06012070 RID: 73840 RVA: 0x0046BF44 File Offset: 0x0046A144
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

	// Token: 0x06012071 RID: 73841 RVA: 0x0046BFBF File Offset: 0x0046A1BF
	public bool ShowInShop()
	{
		return this.Type != EPayGiftType.BattlePass && !this.ShowInSkinTab() && this.Type != EPayGiftType.RegressBp && this.Type != EPayGiftType.WeekCard;
	}

	// Token: 0x06012072 RID: 73842 RVA: 0x0046BFEC File Offset: 0x0046A1EC
	public bool ShowInSkinTab()
	{
		PayShopGoods payShopGoods = this.PayShopGoods;
		return payShopGoods != null && this.Type != EPayGiftType.CdkGift && (payShopGoods.CheckIfRoleSkinGoods() || payShopGoods.CheckIfFlySkinGoods() || payShopGoods.CheckIfMotorSkinGoods() || payShopGoods.CheckIfOrnamentGoods());
	}

	// Token: 0x06012073 RID: 73843 RVA: 0x0046C030 File Offset: 0x0046A230
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x06012074 RID: 73844 RVA: 0x0046C038 File Offset: 0x0046A238
	[NullableContext(2)]
	public PayShopGoods GetPayShopGoods()
	{
		return this.PayShopGoods;
	}

	// Token: 0x06012075 RID: 73845 RVA: 0x0046C040 File Offset: 0x0046A240
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

	// Token: 0x06012076 RID: 73846 RVA: 0x0046C08C File Offset: 0x0046A28C
	public bool HasDiscount()
	{
		return this.GetDiscount() > 0;
	}

	// Token: 0x06012077 RID: 73847 RVA: 0x0046C097 File Offset: 0x0046A297
	private PayShopGoodsData ConvertToPayShopGoodsData()
	{
		PayShopGoodsData payShopGoodsData = new PayShopGoodsData();
		payShopGoodsData.PhraseFromPayPackageData(this);
		return payShopGoodsData;
	}

	// Token: 0x06012078 RID: 73848 RVA: 0x0046C0A5 File Offset: 0x0046A2A5
	public bool CanShowInShopTab()
	{
		return !PlatformSdkManagerNew.Instance.GetPlatformSdk().NeedConfirmSdkProductInfo() || PayItemModel.Instance.GetProductInfoByGoodsId(this.ProductId) != null;
	}

	// Token: 0x04008809 RID: 34825
	private const string DEFAULTCURRENCYKEY = "Default";

	// Token: 0x0400880A RID: 34826
	private string Name = "";

	// Token: 0x0400880B RID: 34827
	[Nullable(2)]
	private PayShopGoods PayShopGoods;

	// Token: 0x0400880C RID: 34828
	public int Id;

	// Token: 0x0400880D RID: 34829
	public int PayId;

	// Token: 0x0400880E RID: 34830
	public int ItemId;

	// Token: 0x0400880F RID: 34831
	public int ItemCount;

	// Token: 0x04008810 RID: 34832
	public int Sort;

	// Token: 0x04008811 RID: 34833
	public int BuyLimit;

	// Token: 0x04008812 RID: 34834
	public int BoughtCount;

	// Token: 0x04008813 RID: 34835
	public string StageImage = "";

	// Token: 0x04008814 RID: 34836
	public string ShowStageImage = "";

	// Token: 0x04008815 RID: 34837
	public long BeginTime;

	// Token: 0x04008816 RID: 34838
	public long EndTime;

	// Token: 0x04008817 RID: 34839
	public long UpdateTime;

	// Token: 0x04008818 RID: 34840
	public PayShopDefine.EPayShopUpdateType UpdateType;

	// Token: 0x04008819 RID: 34841
	public string ProductId = "";

	// Token: 0x0400881A RID: 34842
	public string Amount = "";

	// Token: 0x0400881B RID: 34843
	public int TabId;

	// Token: 0x0400881C RID: 34844
	public EPayGiftType Type = EPayGiftType.LimitGift;

	// Token: 0x0400881D RID: 34845
	public bool IsLock;

	// Token: 0x0400881E RID: 34846
	public bool IsCanBuy = true;

	// Token: 0x0400881F RID: 34847
	public bool IsRemind;

	// Token: 0x04008820 RID: 34848
	public int VersionGroupId;

	// Token: 0x04008821 RID: 34849
	public int BuyCondition;

	// Token: 0x04008822 RID: 34850
	public int CloudGameTime;

	// Token: 0x04008823 RID: 34851
	public string CloudGameIcon = "";

	// Token: 0x04008824 RID: 34852
	public string CloudGameDesc = "";

	// Token: 0x04008825 RID: 34853
	public int LabelId;

	// Token: 0x04008826 RID: 34854
	public long LastUpdateTime;

	// Token: 0x04008827 RID: 34855
	public int PromotionShow;

	// Token: 0x04008828 RID: 34856
	public Dictionary<string, int> CurrencyDiscountTags = new Dictionary<string, int>();

	// Token: 0x04008829 RID: 34857
	public string DisclaimerText = "";

	// Token: 0x0400882A RID: 34858
	public PayShopDefine.EPayShopTabType ShopId = PayShopDefine.EPayShopTabType.GiftBag;

	// Token: 0x0400882B RID: 34859
	public bool NeedConsoleRulePrompt;
}
