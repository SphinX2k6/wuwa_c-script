using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005790 RID: 22416
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlShopExchangePopViewProxy : CommonGameplayShopExchangePopViewProxy
	{
		// Token: 0x06037519 RID: 226585 RVA: 0x00F733F5 File Offset: 0x00F715F5
		public new void UpdateFromPayShopGoods(PayShopGoods payShopGoods)
		{
			base.UpdateFromPayShopGoods(payShopGoods);
			this.UpdateMaxBuyCount();
			this.ApplyLeftTimePrefix();
		}

		// Token: 0x0603751A RID: 226586 RVA: 0x00F7340C File Offset: 0x00F7160C
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

		// Token: 0x0603751B RID: 226587 RVA: 0x00F73441 File Offset: 0x00F71641
		public override void UpdateShopItemResource()
		{
			base.ShopItemResource = "UiItem_DangoBrawlActShopItem";
		}

		// Token: 0x0603751C RID: 226588 RVA: 0x00F73450 File Offset: 0x00F71650
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

		// Token: 0x0603751D RID: 226589 RVA: 0x00F734FD File Offset: 0x00F716FD
		public override UiPanelBase ShopItemCreate()
		{
			this.ShopItem = new DangoBrawlExchangeShopItem();
			return this.ShopItem;
		}

		// Token: 0x0603751E RID: 226590 RVA: 0x00F73510 File Offset: 0x00F71710
		public override void ShopItemRefresh()
		{
			DangoBrawlExchangeShopItem dangoBrawlExchangeShopItem = this.ShopItem as DangoBrawlExchangeShopItem;
			if (dangoBrawlExchangeShopItem == null || base.ShopItemProxy == null)
			{
				return;
			}
			dangoBrawlExchangeShopItem.RefreshByData((DangoBrawlExchangeShopItemProxy)base.ShopItemProxy);
		}

		// Token: 0x0603751F RID: 226591 RVA: 0x00F73548 File Offset: 0x00F71748
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
			if (itemConfigData != null && itemDataTypeByConfigId == InventoryDefine.EItemDataType.RoleItem && Array.IndexOf<int>(itemConfigData.ShowTypes, 30) >= 0)
			{
				num2 = 1;
			}
			if (itemConfigData != null && Array.IndexOf<int>(itemConfigData.ShowTypes, 30) >= 0)
			{
				int[] resonantItemRoleId = RoleModel.Instance.GetResonantItemRoleId(goodsData.ItemId);
				int num3 = RoleModel.Instance.GetRoleLeftResonantCountWithInventoryItem(resonantItemRoleId[0]);
				num3 = ((num3 == 0) ? 1 : num3);
				num2 = ((num2 > num3) ? num3 : num2);
			}
			base.MaxBuyCount = num2;
		}

		// Token: 0x06037520 RID: 226592 RVA: 0x00F73670 File Offset: 0x00F71870
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
