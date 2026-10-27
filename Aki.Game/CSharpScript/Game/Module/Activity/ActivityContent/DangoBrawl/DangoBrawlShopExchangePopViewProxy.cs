using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006840 RID: 26688
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShopExchangePopViewProxy : CommonGameplayShopExchangePopViewProxy
	{
		// Token: 0x060429C5 RID: 272837 RVA: 0x01031EE9 File Offset: 0x010300E9
		public new void UpdateFromPayShopGoods(PayShopGoods payShopGoods)
		{
			base.UpdateFromPayShopGoods(payShopGoods);
			this.UpdateMaxBuyCount();
			this.ApplyLeftTimePrefix();
		}

		// Token: 0x060429C6 RID: 272838 RVA: 0x01031F00 File Offset: 0x01030100
		public override void UpdateShopItemData()
		{
			if (this.GoodsData == null)
			{
				return;
			}
			DangoBrawlExchangeShopItemProxy dangoBrawlExchangeShopItemProxy = new DangoBrawlExchangeShopItemProxy();
			dangoBrawlExchangeShopItemProxy.UpdateFromPayShopGoods(this.GoodsData);
			base.ShopItemProxy = dangoBrawlExchangeShopItemProxy;
			this.UpdateShopItemResource();
		}

		// Token: 0x060429C7 RID: 272839 RVA: 0x01031F35 File Offset: 0x01030135
		public override void UpdateShopItemResource()
		{
			base.ShopItemResource = "UiItem_DangoBrawlActShopItem";
		}

		// Token: 0x060429C8 RID: 272840 RVA: 0x01031F44 File Offset: 0x01030144
		public override void UpdateTipTitleItem()
		{
			if (this.GoodsData == null || !this.GoodsData.IsLimitGoods())
			{
				base.TipTitleItemVisible = false;
				base.LimitTextItemVisible = false;
				return;
			}
			PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
			int num = goodsData.BuyLimit - goodsData.BoughtCount;
			string content = StringUtils.Format(TextConfig.Instance.GetMultiTextByKey("DangoBrawlGeneral_1011"), new string[]
			{
				num.ToString(),
				goodsData.BuyLimit.ToString()
			});
			base.TipTitleItemVisible = !StringUtils.IsEmpty(content);
			base.LimitTextItemVisible = base.TipTitleItemVisible;
			if (base.LimitTextItemVisible)
			{
				base.LimitTextData.SetContent(content);
			}
		}

		// Token: 0x060429C9 RID: 272841 RVA: 0x01031FF1 File Offset: 0x010301F1
		public override UiPanelBase ShopItemCreate()
		{
			this.ShopItem = new DangoBrawlExchangeShopItem();
			return this.ShopItem;
		}

		// Token: 0x060429CA RID: 272842 RVA: 0x01032004 File Offset: 0x01030204
		public override void ShopItemRefresh()
		{
			DangoBrawlExchangeShopItem dangoBrawlExchangeShopItem = this.ShopItem as DangoBrawlExchangeShopItem;
			if (dangoBrawlExchangeShopItem == null || base.ShopItemProxy == null)
			{
				return;
			}
			dangoBrawlExchangeShopItem.RefreshByData((DangoBrawlExchangeShopItemProxy)base.ShopItemProxy);
		}

		// Token: 0x060429CB RID: 272843 RVA: 0x0103203C File Offset: 0x0103023C
		private void UpdateMaxBuyCount()
		{
			if (this.GoodsData == null)
			{
				return;
			}
			PayShopGoodsData goodsData = this.GoodsData.GetGoodsData();
			if (goodsData == null)
			{
				return;
			}
			int id = goodsData.Price.Id;
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(id, 0);
			int nowPrice = goodsData.GetNowPrice();
			int num = (nowPrice > 0) ? (itemCountByConfigId / nowPrice) : int.MaxValue;
			int num2;
			if (goodsData.HasBuyLimit())
			{
				num2 = Math.Min(goodsData.GetRemainingCount(), num);
			}
			else
			{
				num2 = num;
			}
			if (goodsData.HasOnceBuyLimit())
			{
				num2 = Math.Min(num2, goodsData.OnceBuyLimit);
			}
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(goodsData.ItemId);
			InventoryDefine.EItemDataType itemDataTypeByConfigId = InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(goodsData.ItemId));
			if (itemConfigData != null && itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem && itemConfigData.ShowTypes.Contains(30))
			{
				num2 = 1;
			}
			if (itemConfigData != null && itemConfigData.ShowTypes.Contains(30))
			{
				int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(goodsData.ItemId);
				int num3 = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]);
				num3 = ((num3 == 0) ? 1 : num3);
				num2 = ((num2 > num3) ? num3 : num2);
			}
			base.MaxBuyCount = num2;
		}

		// Token: 0x060429CC RID: 272844 RVA: 0x01032164 File Offset: 0x01030364
		private void ApplyLeftTimePrefix()
		{
			if (!base.LeftTimeItemVisible)
			{
				return;
			}
			string text = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null) ?? "";
			if (StringUtils.IsEmpty(text))
			{
				return;
			}
			if (StringUtils.IsEmpty(base.LeftTimeTextData.Content))
			{
				return;
			}
			base.LeftTimeTextData.SetContent(StringUtils.Format(text, new string[]
			{
				base.LeftTimeTextData.Content
			}));
			base.LeftTimeTextVisible = true;
		}
	}
}
