using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02002388 RID: 9096
[NullableContext(1)]
[Nullable(0)]
public class PayShopItemBaseSt
{
	// Token: 0x060122E3 RID: 74467 RVA: 0x00479440 File Offset: 0x00477640
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

	// Token: 0x060122E4 RID: 74468 RVA: 0x004794F0 File Offset: 0x004776F0
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

	// Token: 0x060122E5 RID: 74469 RVA: 0x00479538 File Offset: 0x00477738
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

	// Token: 0x060122E6 RID: 74470 RVA: 0x00479690 File Offset: 0x00477890
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

	// Token: 0x04008968 RID: 35176
	public int Id;

	// Token: 0x04008969 RID: 35177
	public int Quality;

	// Token: 0x0400896A RID: 35178
	public EItemQualityType QualityType;

	// Token: 0x0400896B RID: 35179
	public int ItemId;

	// Token: 0x0400896C RID: 35180
	public int ItemCount;

	// Token: 0x0400896D RID: 35181
	public string ItemName;

	// Token: 0x0400896E RID: 35182
	public bool IsDirect;

	// Token: 0x0400896F RID: 35183
	[Nullable(2)]
	public IPriceData PriceData;

	// Token: 0x04008970 RID: 35184
	public bool IfRechargeItem;

	// Token: 0x04008971 RID: 35185
	public string StageImage;

	// Token: 0x04008972 RID: 35186
	public string ShowStageImage;

	// Token: 0x04008973 RID: 35187
	public int OnceBuyLimitCount;

	// Token: 0x04008974 RID: 35188
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GetShopTipsText;

	// Token: 0x04008975 RID: 35189
	[Nullable(2)]
	public Func<bool> GetIfNeedShowDownTipsText;

	// Token: 0x04008976 RID: 35190
	[Nullable(2)]
	public Func<string> GetDownTipsText;

	// Token: 0x04008977 RID: 35191
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GetSpriteTextBgColor;

	// Token: 0x04008978 RID: 35192
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GetTextTipsColor;

	// Token: 0x04008979 RID: 35193
	[Nullable(2)]
	public Func<bool> RedDotExistFunc;

	// Token: 0x0400897A RID: 35194
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GetDirectPriceTextFunc;

	// Token: 0x0400897B RID: 35195
	[Nullable(2)]
	public Func<double> GachaAverageCount;

	// Token: 0x0400897C RID: 35196
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<string> GachaPrice;

	// Token: 0x0400897D RID: 35197
	private string CurrentLanguage;
}
