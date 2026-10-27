using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.PayShop;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Motor
{
	// Token: 0x02004BEF RID: 19439
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorSkinRecommendItem : UiPanelBase
	{
		// Token: 0x0603243E RID: 205886 RVA: 0x00BAD678 File Offset: 0x00BAB878
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
				new ValueTuple<int, Type>(14, typeof(UUITexture)),
				new ValueTuple<int, Type>(15, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickBuyButton))
			};
		}

		// Token: 0x0603243F RID: 205887 RVA: 0x00BAD81C File Offset: 0x00BABA1C
		private void OnClickBuyButton()
		{
			MotorSkinBuyDetailViewData motorSkinBuyDetailViewData = MotorSkinBuyDetailViewData.Create(new List<ShopMotorSkinData>
			{
				this.CurrentRoleSkinData
			});
			motorSkinBuyDetailViewData.SetIndex(0);
			motorSkinBuyDetailViewData.SetPreviewTitle("MotorSkinShopTitle_Text");
			UiManager.Instance.OpenView(EUiViewName.MotorSkinBuyDetailView, motorSkinBuyDetailViewData, null);
			OnClickRecommendSkinButtonLogEvent onClickRecommendSkinButtonLogEvent = new OnClickRecommendSkinButtonLogEvent();
			onClickRecommendSkinButtonLogEvent.i_operation_type = 1;
			LogReportController.Instance.LogReport(onClickRecommendSkinButtonLogEvent);
		}

		// Token: 0x06032440 RID: 205888 RVA: 0x00BAD87C File Offset: 0x00BABA7C
		protected override UniTask OnBeforeStartAsync()
		{
			MotorSkinRecommendItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorSkinRecommendItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032441 RID: 205889 RVA: 0x00BAD8BF File Offset: 0x00BABABF
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(0), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		}

		// Token: 0x06032442 RID: 205890 RVA: 0x00BAD8E2 File Offset: 0x00BABAE2
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

		// Token: 0x06032443 RID: 205891 RVA: 0x00BAD910 File Offset: 0x00BABB10
		public void Refresh(int recommendId)
		{
			this.RecommendData = PayShopModel.Instance.GetRecommendDataById(recommendId);
			PayShopGoods payShopGoodsById = PayGiftModel.Instance.GetPayShopGoodsById(this.RecommendData.RecommendId);
			if (payShopGoodsById != null)
			{
				this.CurrentRoleSkinData = ShopMotorSkinData.Create(payShopGoodsById);
				TotalTopUpPayAdditiveTagItem totalTopUpTagItem = this.TotalTopUpTagItem;
				if (totalTopUpTagItem != null)
				{
					totalTopUpTagItem.RefreshByGoodsId(payShopGoodsById.GetGoodsId());
				}
			}
			else
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Shop;
				ELogAuthor author = ELogAuthor.LJQ;
				string message = "PayShopData is null";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", recommendId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.RefreshView();
		}

		// Token: 0x06032444 RID: 205892 RVA: 0x00BAD9A0 File Offset: 0x00BABBA0
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

		// Token: 0x06032445 RID: 205893 RVA: 0x00BADA28 File Offset: 0x00BABC28
		private void RefreshTimeText(ShopMotorSkinData data)
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
					if (discountTimeData is string)
					{
						text2.SetText((string)discountTimeData, true);
						return;
					}
					LguiUtil.Instance.SetLocalText(text2, ((CommonDefine.IRemainTime)discountTimeData).TextId, new <>z__ReadOnlySingleElementList<object>(((CommonDefine.IRemainTime)discountTimeData).TimeValue));
					return;
				}
			}
		}

		// Token: 0x06032446 RID: 205894 RVA: 0x00BADB38 File Offset: 0x00BABD38
		private void RefreshSkinName(ShopMotorSkinData data)
		{
			if (data == null)
			{
				base.GetText(3).SetText("", true);
				return;
			}
			string name = data.GetMotorSkinData().GetName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), name, Array.Empty<object>());
		}

		// Token: 0x06032447 RID: 205895 RVA: 0x00BADB80 File Offset: 0x00BABD80
		private void RefreshSubName(ShopMotorSkinData data)
		{
			if (data == null)
			{
				base.GetText(4).SetText("", true);
				return;
			}
			string name = data.GetMotorSkinData().GetName();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), name, Array.Empty<object>());
		}

		// Token: 0x06032448 RID: 205896 RVA: 0x00BADBC8 File Offset: 0x00BABDC8
		private void RefreshBuyItemIcon(ShopMotorSkinData data)
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

		// Token: 0x06032449 RID: 205897 RVA: 0x00BADC28 File Offset: 0x00BABE28
		private void RefreshSourcePriceText(ShopMotorSkinData data)
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

		// Token: 0x0603244A RID: 205898 RVA: 0x00BADCC4 File Offset: 0x00BABEC4
		private void RefreshNowPriceText(ShopMotorSkinData data)
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

		// Token: 0x0603244B RID: 205899 RVA: 0x00BADD28 File Offset: 0x00BABF28
		private void RefreshBuyButtonState(ShopMotorSkinData data)
		{
			if (data == null)
			{
				base.GetButton(7).RootUIComp.Get().SetUIActive(false);
				base.GetItem(15).SetUIActive(false);
				return;
			}
			bool ifCanBuy = data.GetIfCanBuy();
			base.GetButton(7).RootUIComp.Get().SetUIActive(ifCanBuy);
			base.GetItem(15).SetUIActive(ifCanBuy);
		}

		// Token: 0x0603244C RID: 205900 RVA: 0x00BADD90 File Offset: 0x00BABF90
		private void RefreshHaveItem(ShopMotorSkinData data)
		{
			if (data == null)
			{
				base.GetItem(8).SetUIActive(false);
				return;
			}
			bool ifCanBuy = data.GetIfCanBuy();
			base.GetItem(8).SetUIActive(!ifCanBuy);
		}

		// Token: 0x0603244D RID: 205901 RVA: 0x00BADDC8 File Offset: 0x00BABFC8
		private void RefreshLayout(ShopMotorSkinData data)
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
				List<TItem> allReward = data.GetAllReward();
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

		// Token: 0x0603244E RID: 205902 RVA: 0x00BADEB0 File Offset: 0x00BAC0B0
		private void RefreshCouponDiscount(ShopMotorSkinData data)
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

		// Token: 0x0401ABD3 RID: 109523
		private ShopMotorSkinData CurrentRoleSkinData;

		// Token: 0x0401ABD4 RID: 109524
		private PayShopRecommendData RecommendData;

		// Token: 0x0401ABD5 RID: 109525
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemLayout;

		// Token: 0x0401ABD6 RID: 109526
		private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

		// Token: 0x0200ADE5 RID: 44517
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034CFF RID: 216319
			RewardHorizontalLayout,
			// Token: 0x04034D00 RID: 216320
			RewardItem,
			// Token: 0x04034D01 RID: 216321
			TimeText,
			// Token: 0x04034D02 RID: 216322
			SkinNameText,
			// Token: 0x04034D03 RID: 216323
			SkinSubNameText,
			// Token: 0x04034D04 RID: 216324
			NowPrice,
			// Token: 0x04034D05 RID: 216325
			BeforePrice,
			// Token: 0x04034D06 RID: 216326
			BuyButton,
			// Token: 0x04034D07 RID: 216327
			HaveItem,
			// Token: 0x04034D08 RID: 216328
			BuyItemIcon,
			// Token: 0x04034D09 RID: 216329
			TimeLimitBg,
			// Token: 0x04034D0A RID: 216330
			TimeLimitItem,
			// Token: 0x04034D0B RID: 216331
			ItemCoupon,
			// Token: 0x04034D0C RID: 216332
			TextCouponDiscount,
			// Token: 0x04034D0D RID: 216333
			TextureCouponIcon,
			// Token: 0x04034D0E RID: 216334
			TotalTopUpTagRoot
		}
	}
}
