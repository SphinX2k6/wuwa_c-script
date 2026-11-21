using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x0200186D RID: 6253
[NullableContext(1)]
[Nullable(0)]
public class PayShopItemBaseSt
{
	// Token: 0x0600F795 RID: 63381 RVA: 0x00486790 File Offset: 0x00484990
	public PayShopItemBaseSt()
	{
		this.Id = 0;
		this.Quality = 0;
		this.ItemId = 0;
		this.ItemCount = 0;
		this.ItemName = "";
		this.IsDirect = false;
		this.PriceData = null;
		this.IfRechargeItem = false;
		this.StageImage = "";
		this.ShowStageImage = "";
		this.GetShopTipsText = null;
		this.GetIfNeedShowDownTipsText = null;
		this.GetDownTipsText = null;
		this.GetSpriteTextBgColor = null;
		this.GetTextTipsColor = null;
		this.RedDotExistFunc = null;
		this.GetDirectPriceTextFunc = null;
		this.GachaAverageCount = null;
		this.GachaPrice = null;
		this.CurrentLanguage = "";
	}

	// Token: 0x0600F796 RID: 63382 RVA: 0x00486840 File Offset: 0x00484A40
	public void Refresh(IPayShopUnionData data)
	{
		if (this.CurrentLanguage != LanguageSystem.Instance.PackageLanguage)
		{
			PayShopGoods payShopGoods = data as PayShopGoods;
			if (payShopGoods != null)
			{
				this.PhraseFromPayItemData(payShopGoods);
				return;
			}
			PayItemData payItemData = data as PayItemData;
			if (payItemData != null)
			{
				this.PhrasePromPayItemData(payItemData);
			}
		}
	}

	// Token: 0x0600F797 RID: 63383 RVA: 0x00486888 File Offset: 0x00484A88
	public void PhraseFromPayItemData(PayShopGoods data)
	{
		this.Quality = data.GetItemData().Quality;
		this.QualityType = data.GetItemData().QualityType;
		this.ItemId = data.GetItemData().ItemId;
		this.ItemCount = data.GetGoodsData().ItemCount;
		this.ItemName = data.GetGoodsData().GetGoodsName(LanguageSystem.Instance.PackageLanguage);
		this.IsDirect = data.IsDirect();
		this.Id = data.GetGoodsData().Id;
		this.OnceBuyLimitCount = data.GetGoodsData().OnceBuyLimit;
		this.StageImage = data.GetGoodsData().StageImage;
		this.ShowStageImage = data.GetGoodsData().ShowStageImage;
		this.PriceData = data.GetPriceData();
		this.GetShopTipsText = new Func<string>(data.GetShopTipsText);
		this.GetIfNeedShowDownTipsText = new Func<bool>(data.GetIfNeedShowDownTipsText);
		this.GetDownTipsText = new Func<string>(data.GetDownTipsText);
		this.GetTextTipsColor = new Func<string>(data.GetTextTipsColor);
		this.GetSpriteTextBgColor = new Func<string>(data.GetSpriteTextBgColor);
		this.GetDirectPriceTextFunc = new Func<string>(data.GetDirectPriceText);
		this.RedDotExistFunc = new Func<bool>(data.GetIfNeedRemind);
		this.CurrentLanguage = LanguageSystem.Instance.PackageLanguage;
	}

	// Token: 0x0600F798 RID: 63384 RVA: 0x004869E0 File Offset: 0x00484BE0
	public void PhrasePromPayItemData(PayItemData data)
	{
		this.Quality = data.GetQuality();
		this.QualityType = data.GetQualityType();
		this.ItemId = data.ItemId;
		this.ItemCount = data.ItemCount;
		this.StageImage = data.StageImage;
		this.ItemName = data.GetPayItemShowName();
		this.IsDirect = true;
		this.Id = data.PayItemId;
		if (this.IsDirect)
		{
			this.GetDirectPriceTextFunc = (() => data.GetDirectPriceText());
		}
		this.IfRechargeItem = true;
		this.CurrentLanguage = LanguageSystem.Instance.PackageLanguage;
		this.GachaAverageCount = new Func<double>(data.GetGachaAverageCount);
		this.GachaPrice = new Func<string>(data.GetGachaAveragePriceText);
	}

	// Token: 0x04008AAF RID: 35503
	public int Id;

	// Token: 0x04008AB0 RID: 35504
	public int Quality;

	// Token: 0x04008AB1 RID: 35505
	public EItemQualityType QualityType;

	// Token: 0x04008AB2 RID: 35506
	public int ItemId;

	// Token: 0x04008AB3 RID: 35507
	public int ItemCount;

	// Token: 0x04008AB4 RID: 35508
	public string ItemName;

	// Token: 0x04008AB5 RID: 35509
	public bool IsDirect;

	// Token: 0x04008AB6 RID: 35510
	[Nullable(2)]
	public IPriceData PriceData;

	// Token: 0x04008AB7 RID: 35511
	public bool IfRechargeItem;

	// Token: 0x04008AB8 RID: 35512
	public string StageImage;

	// Token: 0x04008AB9 RID: 35513
	public string ShowStageImage;

	// Token: 0x04008ABA RID: 35514
	public int OnceBuyLimitCount;

	// Token: 0x04008ABB RID: 35515
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GetShopTipsText;

	// Token: 0x04008ABC RID: 35516
	[Nullable(2)]
	public Func<bool> GetIfNeedShowDownTipsText;

	// Token: 0x04008ABD RID: 35517
	[Nullable(2)]
	public Func<string> GetDownTipsText;

	// Token: 0x04008ABE RID: 35518
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GetSpriteTextBgColor;

	// Token: 0x04008ABF RID: 35519
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GetTextTipsColor;

	// Token: 0x04008AC0 RID: 35520
	[Nullable(2)]
	public Func<bool> RedDotExistFunc;

	// Token: 0x04008AC1 RID: 35521
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GetDirectPriceTextFunc;

	// Token: 0x04008AC2 RID: 35522
	[Nullable(2)]
	public Func<double> GachaAverageCount;

	// Token: 0x04008AC3 RID: 35523
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GachaPrice;

	// Token: 0x04008AC4 RID: 35524
	private string CurrentLanguage;
}
