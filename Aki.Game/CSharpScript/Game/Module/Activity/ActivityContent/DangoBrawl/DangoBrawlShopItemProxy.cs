using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005792 RID: 22418
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShopItemProxy : CommonGameplayShopItemProxy
	{
		// Token: 0x06037532 RID: 226610 RVA: 0x00F73E68 File Offset: 0x00F72068
		public override void UpdatePriceData()
		{
			base.UpdatePriceData();
			if (this.GoodsData == null)
			{
				return;
			}
			IPriceData priceData = this.GoodsData.GetPriceData();
			string nowPriceTextColor = "3b3742";
			if (priceData.OwnNumber() < priceData.NowPrice)
			{
				nowPriceTextColor = "9c4242";
			}
			base.NowPriceTextColor = nowPriceTextColor;
		}

		// Token: 0x06037533 RID: 226611 RVA: 0x00F73EB8 File Offset: 0x00F720B8
		public override void UpdateBuyLimitCountText()
		{
			if (this.GoodsData == null)
			{
				return;
			}
			if (!this.GoodsData.IsLimitGoods())
			{
				base.BuyLimitCountTextVisible = false;
				return;
			}
			PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
			int num = goodsData.BuyLimit - goodsData.BoughtCount;
			string content = StringUtils.Format(TextConfig.Instance.GetMultiTextByKey("DangoBrawlGeneral_1011"), new string[]
			{
				num.ToString(),
				goodsData.BuyLimit.ToString()
			});
			base.BuyLimitCountTextVisible = true;
			base.BuyLimitCountTextData.SetContent(content);
		}

		// Token: 0x06037534 RID: 226612 RVA: 0x00F73F44 File Offset: 0x00F72144
		public override void UpdateQualityData()
		{
			if (this.GoodsData == null)
			{
				return;
			}
			CSharpScript.Game.Module.PayShop.IItemData itemData = this.GoodsData.GetItemData();
			DangoBrawlItemQuality? itemQualityConfigById = DangoBrawlConfig.Instance.GetItemQualityConfigById(itemData.Quality);
			if (itemQualityConfigById == null)
			{
				return;
			}
			this.QualityTexturePath = itemQualityConfigById.Value.ShopItemIcon;
		}

		// Token: 0x06037535 RID: 226613 RVA: 0x00F73F98 File Offset: 0x00F72198
		public override void OnBuyButtonClick()
		{
			if (this.GoodsData == null)
			{
				return;
			}
			DangoBrawlShopExchangePopViewProxy dangoBrawlShopExchangePopViewProxy = new DangoBrawlShopExchangePopViewProxy();
			dangoBrawlShopExchangePopViewProxy.UpdateFromPayShopGoods(this.GoodsData);
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlShopExchangePopView, dangoBrawlShopExchangePopViewProxy, null);
		}

		// Token: 0x0401D38D RID: 119693
		private const string NormalColor = "3b3742";

		// Token: 0x0401D38E RID: 119694
		private const string RedColor = "9c4242";

		// Token: 0x0401D38F RID: 119695
		public float LimitCountAlpha = 0.7f;

		// Token: 0x0401D390 RID: 119696
		public int ActivityId;

		// Token: 0x0401D391 RID: 119697
		public string QualityTexturePath = "";
	}
}
