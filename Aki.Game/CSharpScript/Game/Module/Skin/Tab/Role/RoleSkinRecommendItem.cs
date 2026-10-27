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
	// Token: 0x02004BEB RID: 19435
	[NullableContext(2)]
	[Nullable(0)]
	public class RoleSkinRecommendItem : UiPanelBase
	{
		// Token: 0x06032420 RID: 205856 RVA: 0x00BACC38 File Offset: 0x00BAAE38
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

		// Token: 0x06032421 RID: 205857 RVA: 0x00BACDC4 File Offset: 0x00BAAFC4
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

		// Token: 0x06032422 RID: 205858 RVA: 0x00BACE23 File Offset: 0x00BAB023
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(0), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		}

		// Token: 0x06032423 RID: 205859 RVA: 0x00BACE46 File Offset: 0x00BAB046
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

		// Token: 0x06032424 RID: 205860 RVA: 0x00BACE74 File Offset: 0x00BAB074
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

		// Token: 0x06032425 RID: 205861 RVA: 0x00BACEF0 File Offset: 0x00BAB0F0
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

		// Token: 0x06032426 RID: 205862 RVA: 0x00BACF78 File Offset: 0x00BAB178
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

		// Token: 0x06032427 RID: 205863 RVA: 0x00BAD094 File Offset: 0x00BAB294
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

		// Token: 0x06032428 RID: 205864 RVA: 0x00BAD0DC File Offset: 0x00BAB2DC
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

		// Token: 0x06032429 RID: 205865 RVA: 0x00BAD124 File Offset: 0x00BAB324
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

		// Token: 0x0603242A RID: 205866 RVA: 0x00BAD184 File Offset: 0x00BAB384
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

		// Token: 0x0603242B RID: 205867 RVA: 0x00BAD220 File Offset: 0x00BAB420
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

		// Token: 0x0603242C RID: 205868 RVA: 0x00BAD284 File Offset: 0x00BAB484
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

		// Token: 0x0603242D RID: 205869 RVA: 0x00BAD2D0 File Offset: 0x00BAB4D0
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

		// Token: 0x0603242E RID: 205870 RVA: 0x00BAD308 File Offset: 0x00BAB508
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

		// Token: 0x0603242F RID: 205871 RVA: 0x00BAD3D4 File Offset: 0x00BAB5D4
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

		// Token: 0x0401ABCA RID: 109514
		private ShopSkinData CurrentRoleSkinData;

		// Token: 0x0401ABCB RID: 109515
		private PayShopRecommendData RecommendData;

		// Token: 0x0401ABCC RID: 109516
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemLayout;

		// Token: 0x0200ADDF RID: 44511
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034CE0 RID: 216288
			RewardHorizontalLayout,
			// Token: 0x04034CE1 RID: 216289
			RewardItem,
			// Token: 0x04034CE2 RID: 216290
			TimeText,
			// Token: 0x04034CE3 RID: 216291
			SkinNameText,
			// Token: 0x04034CE4 RID: 216292
			SkinSubNameText,
			// Token: 0x04034CE5 RID: 216293
			NowPrice,
			// Token: 0x04034CE6 RID: 216294
			BeforePrice,
			// Token: 0x04034CE7 RID: 216295
			BuyButton,
			// Token: 0x04034CE8 RID: 216296
			HaveItem,
			// Token: 0x04034CE9 RID: 216297
			BuyItemIcon,
			// Token: 0x04034CEA RID: 216298
			TimeLimitBg,
			// Token: 0x04034CEB RID: 216299
			TimeLimitItem,
			// Token: 0x04034CEC RID: 216300
			ItemCoupon,
			// Token: 0x04034CED RID: 216301
			TextCouponDiscount,
			// Token: 0x04034CEE RID: 216302
			TextureCouponIcon
		}
	}
}
