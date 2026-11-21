using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Role
{
	// Token: 0x02003B9C RID: 15260
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleSkinRecommendItem : UiPanelBase
	{
		// Token: 0x060271C4 RID: 160196 RVA: 0x00AF11B8 File Offset: 0x00AEF3B8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUITexture)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIText)),
				new ValueTuple<int, Type>(14, typeof(UUITexture))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickBuyButton))
			};
		}

		// Token: 0x060271C5 RID: 160197 RVA: 0x00AF1344 File Offset: 0x00AEF544
		private void OnClickBuyButton()
		{
			SkinBuyDetailViewData skinBuyDetailViewData = SkinBuyDetailViewData.Create(new List<ShopSkinData>
			{
				this.CurrentRoleSkinData
			});
			skinBuyDetailViewData.SetPreviewTitle("RoleSkinPreviewTitle_Text");
			skinBuyDetailViewData.SetIndex(0);
			UiManager.Instance.OpenView(EUiViewName.SkinBuyDetailView, skinBuyDetailViewData, null);
			OnClickRecommendSkinButtonLogEvent onClickRecommendSkinButtonLogEvent = new OnClickRecommendSkinButtonLogEvent();
			onClickRecommendSkinButtonLogEvent.i_operation_type = 1;
			LogReportController.Instance.LogReport(onClickRecommendSkinButtonLogEvent);
		}

		// Token: 0x060271C6 RID: 160198 RVA: 0x00AF13A3 File Offset: 0x00AEF5A3
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(0), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		}

		// Token: 0x060271C7 RID: 160199 RVA: 0x00AF13C6 File Offset: 0x00AEF5C6
		[NullableContext(1)]
		private SkinRewardItemGrid InitGridItem()
		{
			SkinRewardItemGrid skinRewardItemGrid = new SkinRewardItemGrid();
			skinRewardItemGrid.OnClickRecommendSkinButtonCallback = delegate(int itemId)
			{
				OnClickRecommendSkinButtonLogEvent onClickRecommendSkinButtonLogEvent = new OnClickRecommendSkinButtonLogEvent();
				onClickRecommendSkinButtonLogEvent.i_operation_type = 0;
				onClickRecommendSkinButtonLogEvent.i_item_id = itemId;
				LogReportController.Instance.LogReport(onClickRecommendSkinButtonLogEvent);
			};
			return skinRewardItemGrid;
		}

		// Token: 0x060271C8 RID: 160200 RVA: 0x00AF13F4 File Offset: 0x00AEF5F4
		public void Refresh(int recommendId)
		{
			this.RecommendData = PayShopModel.Instance.GetRecommendDataById(recommendId);
			PayShopGoods payShopGoods = PayShopModel.Instance.GetPayShopGoods(this.RecommendData.RecommendId);
			if (payShopGoods != null)
			{
				this.CurrentRoleSkinData = ShopSkinData.Create(payShopGoods);
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Shop;
				ELogAuthor author = ELogAuthor.YZY;
				string message = "PayShopData is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", recommendId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.RefreshView();
		}

		// Token: 0x060271C9 RID: 160201 RVA: 0x00AF1470 File Offset: 0x00AEF670
		private void RefreshView()
		{
			this.RefreshTimeText(this.CurrentRoleSkinData);
			this.RefreshSkinName(this.CurrentRoleSkinData);
			this.RefreshSubName(this.CurrentRoleSkinData);
			this.RefreshBuyItemIcon(this.CurrentRoleSkinData);
			this.RefreshSourcePriceText(this.CurrentRoleSkinData);
			this.RefreshNowPriceText(this.CurrentRoleSkinData);
			this.RefreshBuyButtonState(this.CurrentRoleSkinData);
			this.RefreshHaveItem(this.CurrentRoleSkinData);
			this.RefreshLayout(this.CurrentRoleSkinData);
			this.RefreshCouponDiscount(this.CurrentRoleSkinData);
		}

		// Token: 0x060271CA RID: 160202 RVA: 0x00AF14F8 File Offset: 0x00AEF6F8
		private void RefreshTimeText(ShopSkinData data)
		{
			if (data == null)
			{
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.SetText("", true);
				}
				UUIItem item = base.GetItem(10);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(11);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				object discountTimeData = data.GetDiscountTimeData();
				if (discountTimeData == null)
				{
					base.GetText(2).SetUIActive(false);
					UUIItem item3 = base.GetItem(10);
					if (item3 != null)
					{
						item3.SetUIActive(false);
					}
					UUIItem item4 = base.GetItem(11);
					if (item4 == null)
					{
						return;
					}
					item4.SetUIActive(false);
					return;
				}
				else
				{
					base.GetText(2).SetUIActive(true);
					UUIItem item5 = base.GetItem(10);
					if (item5 != null)
					{
						item5.SetUIActive(true);
					}
					UUIItem item6 = base.GetItem(11);
					if (item6 != null)
					{
						item6.SetUIActive(true);
					}
					UUIText text2 = base.GetText(2);
					if (discountTimeData is CommonDefine.PayShowCountDownRemainTime<string>)
					{
						text2.SetText(((CommonDefine.PayShowCountDownRemainTime<string>)discountTimeData).Value, true);
						return;
					}
					LguiUtil.Instance.SetLocalText(text2, ((CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>)discountTimeData).Value.TextId, new <>z__ReadOnlySingleElementList<object>(((CommonDefine.PayShowCountDownRemainTime<CommonDefine.IRemainTime>)discountTimeData).Value.TimeValue));
					return;
				}
			}
		}

		// Token: 0x060271CB RID: 160203 RVA: 0x00AF1614 File Offset: 0x00AEF814
		private void RefreshSkinName(ShopSkinData data)
		{
			if (data == null)
			{
				base.GetText(3).SetText("", true);
				return;
			}
			string titleName = data.GetRoleSkinData().GetTitleName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), titleName, Array.Empty<object>());
		}

		// Token: 0x060271CC RID: 160204 RVA: 0x00AF165C File Offset: 0x00AEF85C
		private void RefreshSubName(ShopSkinData data)
		{
			if (data == null)
			{
				base.GetText(4).SetText("", true);
				return;
			}
			string subTitle = data.GetRoleSkinData().GetSubTitle();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), subTitle, Array.Empty<object>());
		}

		// Token: 0x060271CD RID: 160205 RVA: 0x00AF16A4 File Offset: 0x00AEF8A4
		private void RefreshBuyItemIcon(ShopSkinData data)
		{
			if (data == null)
			{
				base.GetTexture(9).SetUIActive(false);
				return;
			}
			bool ifDirect = data.GetIfDirect();
			base.GetTexture(9).SetUIActive(!ifDirect);
			if (!ifDirect)
			{
				IPriceData priceData = data.GetPriceData();
				base.SetItemIcon(base.GetTexture(9), priceData.CurrencyId, null, null);
			}
		}

		// Token: 0x060271CE RID: 160206 RVA: 0x00AF1704 File Offset: 0x00AEF904
		private void RefreshSourcePriceText(ShopSkinData data)
		{
			if (data == null)
			{
				base.GetText(6).SetText("", true);
				return;
			}
			if (data.GetIfDirect())
			{
				base.GetText(6).SetText("", true);
				return;
			}
			int? originalPrice = data.GetPriceData().OriginalPrice;
			if (originalPrice == null)
			{
				base.GetText(6).SetUIActive(false);
				return;
			}
			base.GetText(6).SetUIActive(true);
			base.GetText(6).SetText("<s>" + originalPrice.Value.ToString() + "</s>", true);
		}

		// Token: 0x060271CF RID: 160207 RVA: 0x00AF17A0 File Offset: 0x00AEF9A0
		private void RefreshNowPriceText(ShopSkinData data)
		{
			if (data == null)
			{
				base.GetText(5).SetText("", true);
				return;
			}
			if (data.GetIfDirect())
			{
				string directPriceText = data.GetDirectPriceText();
				base.GetText(5).SetText(directPriceText, true);
				return;
			}
			int nowPrice = data.GetPriceData().NowPrice;
			base.GetText(5).SetText(nowPrice.ToString(), true);
		}

		// Token: 0x060271D0 RID: 160208 RVA: 0x00AF1804 File Offset: 0x00AEFA04
		private void RefreshBuyButtonState(ShopSkinData data)
		{
			if (data == null)
			{
				base.GetButton(7).RootUIComp.Get().SetUIActive(false);
				return;
			}
			bool ifCanBuy = data.GetIfCanBuy();
			base.GetButton(7).RootUIComp.Get().SetUIActive(ifCanBuy);
		}

		// Token: 0x060271D1 RID: 160209 RVA: 0x00AF1850 File Offset: 0x00AEFA50
		private void RefreshHaveItem(ShopSkinData data)
		{
			if (data == null)
			{
				base.GetItem(8).SetUIActive(false);
				return;
			}
			bool ifCanBuy = data.GetIfCanBuy();
			base.GetItem(8).SetUIActive(!ifCanBuy);
		}

		// Token: 0x060271D2 RID: 160210 RVA: 0x00AF1888 File Offset: 0x00AEFA88
		private void RefreshLayout(ShopSkinData data)
		{
			if (data == null)
			{
				GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout = this.ItemLayout;
				if (itemLayout == null)
				{
					return;
				}
				itemLayout.SetActive(false);
				return;
			}
			else
			{
				TItem[] allReward = data.GetAllReward();
				List<SkinRewardData> list = new List<SkinRewardData>();
				foreach (TItem titem in allReward)
				{
					SkinRewardData skinRewardData = new SkinRewardData();
					TItem value = new TItem(new InventoryDefine.GetItemData(titem.ItemData.ItemId, titem.ItemData.IncId), titem.Count);
					skinRewardData.ItemData = new TItem?(value);
					skinRewardData.FinishState = data.GetCurrentGoodsData().IsSoldOut();
					list.Add(skinRewardData);
				}
				GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout2 = this.ItemLayout;
				if (itemLayout2 != null)
				{
					itemLayout2.SetActive(list.Count != 0);
				}
				GenericLayout<SkinRewardItemGrid, SkinRewardData> itemLayout3 = this.ItemLayout;
				if (itemLayout3 == null)
				{
					return;
				}
				itemLayout3.RefreshByData(list, null, false);
				return;
			}
		}

		// Token: 0x060271D3 RID: 160211 RVA: 0x00AF1954 File Offset: 0x00AEFB54
		private void RefreshCouponDiscount(ShopSkinData data)
		{
			if (data == null)
			{
				base.GetItem(12).SetUIActive(false);
				return;
			}
			CommonItemData availableCouponItem = data.GetCurrentGoodsData().GetAvailableCouponItem();
			if (availableCouponItem == null)
			{
				base.GetItem(12).SetUIActive(false);
				return;
			}
			base.GetItem(12).SetUIActive(true);
			int availableCouponDiscount = data.GetCurrentGoodsData().GetAvailableCouponDiscount();
			base.GetText(13).SetText((-availableCouponDiscount).ToString(), true);
			UUITexture texture = base.GetTexture(14);
			base.SetTextureByPath(availableCouponItem.GetConfig().As<ItemInfo>().Value.IconSmall, texture, null, null);
		}

		// Token: 0x04015525 RID: 87333
		private ShopSkinData CurrentRoleSkinData;

		// Token: 0x04015526 RID: 87334
		private PayShopRecommendData RecommendData;

		// Token: 0x04015527 RID: 87335
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemLayout;

		// Token: 0x020097FE RID: 38910
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402F687 RID: 194183
			RewardHorizontalLayout,
			// Token: 0x0402F688 RID: 194184
			RewardItem,
			// Token: 0x0402F689 RID: 194185
			TimeText,
			// Token: 0x0402F68A RID: 194186
			SkinNameText,
			// Token: 0x0402F68B RID: 194187
			SkinSubNameText,
			// Token: 0x0402F68C RID: 194188
			NowPrice,
			// Token: 0x0402F68D RID: 194189
			BeforePrice,
			// Token: 0x0402F68E RID: 194190
			BuyButton,
			// Token: 0x0402F68F RID: 194191
			HaveItem,
			// Token: 0x0402F690 RID: 194192
			BuyItemIcon,
			// Token: 0x0402F691 RID: 194193
			TimeLimitBg,
			// Token: 0x0402F692 RID: 194194
			TimeLimitItem,
			// Token: 0x0402F693 RID: 194195
			ItemCoupon,
			// Token: 0x0402F694 RID: 194196
			TextCouponDiscount,
			// Token: 0x0402F695 RID: 194197
			TextureCouponIcon
		}
	}
}
