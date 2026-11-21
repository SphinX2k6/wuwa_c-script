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
	// Token: 0x02003BA0 RID: 15264
	[NullableContext(2)]
	[Nullable(0)]
	public class MotorSkinRecommendItem : UiPanelBase
	{
		// Token: 0x060271E2 RID: 160226 RVA: 0x00AF1BF8 File Offset: 0x00AEFDF8
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

		// Token: 0x060271E3 RID: 160227 RVA: 0x00AF1D9C File Offset: 0x00AEFF9C
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

		// Token: 0x060271E4 RID: 160228 RVA: 0x00AF1DFC File Offset: 0x00AEFFFC
		protected override UniTask OnBeforeStartAsync()
		{
			MotorSkinRecommendItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MotorSkinRecommendItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060271E5 RID: 160229 RVA: 0x00AF1E3F File Offset: 0x00AF003F
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<SkinRewardItemGrid, SkinRewardData>(base.GetHorizontalLayout(0), new Func<SkinRewardItemGrid>(this.InitGridItem), null, false, true);
		}

		// Token: 0x060271E6 RID: 160230 RVA: 0x00AF1E62 File Offset: 0x00AF0062
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

		// Token: 0x060271E7 RID: 160231 RVA: 0x00AF1E90 File Offset: 0x00AF0090
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

		// Token: 0x060271E8 RID: 160232 RVA: 0x00AF1F20 File Offset: 0x00AF0120
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

		// Token: 0x060271E9 RID: 160233 RVA: 0x00AF1FA8 File Offset: 0x00AF01A8
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

		// Token: 0x060271EA RID: 160234 RVA: 0x00AF20B8 File Offset: 0x00AF02B8
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

		// Token: 0x060271EB RID: 160235 RVA: 0x00AF2100 File Offset: 0x00AF0300
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

		// Token: 0x060271EC RID: 160236 RVA: 0x00AF2148 File Offset: 0x00AF0348
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

		// Token: 0x060271ED RID: 160237 RVA: 0x00AF21A8 File Offset: 0x00AF03A8
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

		// Token: 0x060271EE RID: 160238 RVA: 0x00AF2244 File Offset: 0x00AF0444
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

		// Token: 0x060271EF RID: 160239 RVA: 0x00AF22A8 File Offset: 0x00AF04A8
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

		// Token: 0x060271F0 RID: 160240 RVA: 0x00AF2310 File Offset: 0x00AF0510
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

		// Token: 0x060271F1 RID: 160241 RVA: 0x00AF2348 File Offset: 0x00AF0548
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

		// Token: 0x060271F2 RID: 160242 RVA: 0x00AF2430 File Offset: 0x00AF0630
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

		// Token: 0x0401552E RID: 87342
		private ShopMotorSkinData CurrentRoleSkinData;

		// Token: 0x0401552F RID: 87343
		private PayShopRecommendData RecommendData;

		// Token: 0x04015530 RID: 87344
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SkinRewardItemGrid, SkinRewardData> ItemLayout;

		// Token: 0x04015531 RID: 87345
		private TotalTopUpPayAdditiveTagItem TotalTopUpTagItem;

		// Token: 0x02009804 RID: 38916
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402F6A6 RID: 194214
			RewardHorizontalLayout,
			// Token: 0x0402F6A7 RID: 194215
			RewardItem,
			// Token: 0x0402F6A8 RID: 194216
			TimeText,
			// Token: 0x0402F6A9 RID: 194217
			SkinNameText,
			// Token: 0x0402F6AA RID: 194218
			SkinSubNameText,
			// Token: 0x0402F6AB RID: 194219
			NowPrice,
			// Token: 0x0402F6AC RID: 194220
			BeforePrice,
			// Token: 0x0402F6AD RID: 194221
			BuyButton,
			// Token: 0x0402F6AE RID: 194222
			HaveItem,
			// Token: 0x0402F6AF RID: 194223
			BuyItemIcon,
			// Token: 0x0402F6B0 RID: 194224
			TimeLimitBg,
			// Token: 0x0402F6B1 RID: 194225
			TimeLimitItem,
			// Token: 0x0402F6B2 RID: 194226
			ItemCoupon,
			// Token: 0x0402F6B3 RID: 194227
			TextCouponDiscount,
			// Token: 0x0402F6B4 RID: 194228
			TextureCouponIcon,
			// Token: 0x0402F6B5 RID: 194229
			TotalTopUpTagRoot
		}
	}
}
