using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006842 RID: 26690
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShopItemProxy : CommonGameplayShopItemProxy
	{
		// Token: 0x060429DE RID: 272862 RVA: 0x0103295C File Offset: 0x01030B5C
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

		// Token: 0x060429DF RID: 272863 RVA: 0x010329AC File Offset: 0x01030BAC
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

		// Token: 0x060429E0 RID: 272864 RVA: 0x01032A38 File Offset: 0x01030C38
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

		// Token: 0x060429E1 RID: 272865 RVA: 0x01032A8C File Offset: 0x01030C8C
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

		// Token: 0x04022B30 RID: 142128
		private const string NormalColor = "3b3742";

		// Token: 0x04022B31 RID: 142129
		private const string RedColor = "9c4242";

		// Token: 0x04022B32 RID: 142130
		public float LimitCountAlpha = 0.7f;

		// Token: 0x04022B33 RID: 142131
		public int ActivityId;

		// Token: 0x04022B34 RID: 142132
		public string QualityTexturePath = "";
	}
}
