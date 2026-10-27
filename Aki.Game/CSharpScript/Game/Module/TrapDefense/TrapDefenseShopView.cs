using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.NumberSelect;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AD1 RID: 19153
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseShopView : UiViewBase
	{
		// Token: 0x060319C3 RID: 203203 RVA: 0x00B819A3 File Offset: 0x00B7FBA3
		[NullableContext(1)]
		public TrapDefenseShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060319C4 RID: 203204 RVA: 0x00B819AC File Offset: 0x00B7FBAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnRefreshButtonClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060319C5 RID: 203205 RVA: 0x00B81C6C File Offset: 0x00B7FE6C
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseShopView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseShopView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060319C6 RID: 203206 RVA: 0x00B81CB0 File Offset: 0x00B7FEB0
		protected override void OnStart()
		{
			TermExplanationRegistryParam param = new TermExplanationRegistryParam
			{
				UiText = base.GetText(10),
				ViewType = ETermExplanationViewType.Side,
				ReportType = ETermExplanationReportType.TrapDefenseBuff,
				AttachDirection = new ETermExplanationViewAttachDirection?(ETermExplanationViewAttachDirection.Left)
			};
			TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
		}

		// Token: 0x060319C7 RID: 203207 RVA: 0x00B81CF8 File Offset: 0x00B7FEF8
		protected override void OnAfterShow()
		{
			if (this.NeedRefreshAfterShow)
			{
				this.NeedRefreshAfterShow = false;
				this.OnShopRefresh();
				return;
			}
			if (this.DefaultGoods != null && TrapDefenseModel.Instance.ViewModelShop.SelectedGoods == null)
			{
				TrapDefenseModel.Instance.ViewModelShop.SelectGoods(this.DefaultGoods);
			}
		}

		// Token: 0x060319C8 RID: 203208 RVA: 0x00B81D49 File Offset: 0x00B7FF49
		protected override void OnBeforeHide()
		{
			this.NeedRefreshAfterShow = true;
		}

		// Token: 0x060319C9 RID: 203209 RVA: 0x00B81D52 File Offset: 0x00B7FF52
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseShopRefresh, new Action(this.OnShopRefresh));
		}

		// Token: 0x060319CA RID: 203210 RVA: 0x00B81D70 File Offset: 0x00B7FF70
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseShopRefresh, new Action(this.OnShopRefresh));
		}

		// Token: 0x060319CB RID: 203211 RVA: 0x00B81D90 File Offset: 0x00B7FF90
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelShop.RemoveOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
			TrapDefenseModel.Instance.ViewModelShop.OnViewClose();
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(10));
			this.NeedRefreshAfterShow = false;
		}

		// Token: 0x060319CC RID: 203212 RVA: 0x00B81DE0 File Offset: 0x00B7FFE0
		private UniTask RefreshGoodsPanel()
		{
			TrapDefenseShopView.<RefreshGoodsPanel>d__19 <RefreshGoodsPanel>d__;
			<RefreshGoodsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshGoodsPanel>d__.<>4__this = this;
			<RefreshGoodsPanel>d__.<>1__state = -1;
			<RefreshGoodsPanel>d__.<>t__builder.Start<TrapDefenseShopView.<RefreshGoodsPanel>d__19>(ref <RefreshGoodsPanel>d__);
			return <RefreshGoodsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060319CD RID: 203213 RVA: 0x00B81E24 File Offset: 0x00B80024
		[NullableContext(1)]
		private void RefreshGoodsDetail(ITrapDefenseShopGoods goods)
		{
			if (goods == null)
			{
				Log.Instance.Error(ELogModule.TowerDefense, ELogAuthor.HYF, "刷新塔防商店时，商品信息不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), goods.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), goods.Desc, goods.DescArgs ?? Array.Empty<string>());
			INumberSelectData data = new INumberSelectData
			{
				MaxNumber = goods.CanPurchaseNum,
				ValueChangeFunction = new Action<int>(this.OnSliderNumberChange)
			};
			this.NumberSelectComponent.Init(data);
			this.NumberSelectComponent.SetUiActive(goods.CanPurchaseNum > 1);
			base.GetItem(11).SetUIActive(!goods.Disable);
			this.PurchaseButton.SetUiActive(!goods.Disable);
			base.GetItem(9).SetUIActive(goods.Disable);
			if (goods.DisableReason == ETrapDefenseShopGoodsUnavailableReason.InventoryCountReachLimit)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(17), ETrapDefenseTextKey.ShopGoodsInventoryCountReachLimit.ToString(), Array.Empty<object>());
				return;
			}
			if (goods.DisableReason == ETrapDefenseShopGoodsUnavailableReason.SoldOut)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(17), ETrapDefenseTextKey.ShopGoodsSoldOut.ToString(), Array.Empty<object>());
			}
		}

		// Token: 0x060319CE RID: 203214 RVA: 0x00B81F79 File Offset: 0x00B80179
		[NullableContext(1)]
		private void OnSelectGoods(ITrapDefenseShopGoods goods)
		{
			this.RefreshGoodsDetail(goods);
		}

		// Token: 0x060319CF RID: 203215 RVA: 0x00B81F84 File Offset: 0x00B80184
		private void OnSliderNumberChange(int value)
		{
			ITrapDefenseShopGoods trapDefenseShopGoods = TrapDefenseModel.Instance.ViewModelShop.SelectedGoods ?? this.DefaultGoods;
			if (trapDefenseShopGoods == null)
			{
				return;
			}
			bool flag = TrapDefenseModel.Instance.BattleData.GetGoldNum() >= (long)(trapDefenseShopGoods.CurrentPrice * value);
			base.GetText(14).SetText((trapDefenseShopGoods.CurrentPrice * value).ToString(), true);
			base.GetText(14).SetColor(flag ? this.OriginalCostTextColor.Value : FColor.FromHex("9D2437FF"));
			UUIItem text = base.GetText(15);
			int? originalPrice = trapDefenseShopGoods.OriginalPrice;
			int currentPrice = trapDefenseShopGoods.CurrentPrice;
			text.SetUIActive(!(originalPrice.GetValueOrDefault() == currentPrice & originalPrice != null));
			UUIText text2 = base.GetText(15);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(7, 1);
			defaultInterpolatedStringHandler.AppendLiteral("<s>");
			defaultInterpolatedStringHandler.AppendFormatted<int>(trapDefenseShopGoods.OriginalPrice.GetValueOrDefault() * value);
			defaultInterpolatedStringHandler.AppendLiteral("</s>");
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), ETrapDefenseTextKey.ShopPurchaseNum.ToString(), new <>z__ReadOnlySingleElementList<object>(value));
		}

		// Token: 0x060319D0 RID: 203216 RVA: 0x00B820BC File Offset: 0x00B802BC
		private void OnPurchaseButtonClick(int _)
		{
			ITrapDefenseShopGoods selectedGoods = TrapDefenseModel.Instance.ViewModelShop.SelectedGoods;
			if (selectedGoods == null)
			{
				return;
			}
			int selectNumber = this.NumberSelectComponent.GetSelectNumber();
			if (selectNumber <= 0)
			{
				return;
			}
			if (TrapDefenseModel.Instance.BattleData.GetGoldNum() < (long)(selectedGoods.CurrentPrice * selectNumber))
			{
				GenericPromptController.Instance.ShowPromptByCode("TrapDefenseNotEnoughGold", Array.Empty<object>());
				return;
			}
			TrapDefenseController.Instance.RequestTrapDefenseShopPurchase(selectedGoods.Id, selectedGoods.Type, selectNumber);
		}

		// Token: 0x060319D1 RID: 203217 RVA: 0x00B8213C File Offset: 0x00B8033C
		private void OnRefreshButtonClick()
		{
			long goldNum = TrapDefenseModel.Instance.BattleData.GetGoldNum();
			int refreshCost = TrapDefenseModel.Instance.ShopData.RefreshCost;
			if (goldNum < (long)refreshCost)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(ETrapDefenseTextKey.TrapDefenseShopNoCost.ToString(), Array.Empty<object>());
				return;
			}
			TrapDefenseController.Instance.RequestTrapDefenseShopRefresh();
		}

		// Token: 0x060319D2 RID: 203218 RVA: 0x00B82198 File Offset: 0x00B80398
		private void OnShopRefresh()
		{
			this.RefreshGoodsPanel().Forget();
			ITrapDefenseShopGoods selectedGoods = TrapDefenseModel.Instance.ViewModelShop.SelectedGoods;
			TrapDefenseShopData shopData = TrapDefenseModel.Instance.ShopData;
			bool flag = shopData.ItemGoodsMap.ContainsKey(selectedGoods.Id) || shopData.BuffGoodsMap.ContainsKey(selectedGoods.Id);
			TrapDefenseModel.Instance.ViewModelShop.SelectGoods(flag ? selectedGoods : this.DefaultGoods);
			this.CostItem.UpdateGoldCostNum();
		}

		// Token: 0x0401A80A RID: 108554
		private PopupCaptionItem Caption;

		// Token: 0x0401A80B RID: 108555
		private NumberSelectComponent NumberSelectComponent;

		// Token: 0x0401A80C RID: 108556
		private ButtonItem PurchaseButton;

		// Token: 0x0401A80D RID: 108557
		private TrapDefenseGoldCostItem CostItem;

		// Token: 0x0401A80E RID: 108558
		private TrapDefenseShopCheckBuffItem CheckBuffItem;

		// Token: 0x0401A80F RID: 108559
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<TrapDefenseShopGoodsContainerItem, TrapDefenseShopGoodsListData> ScrollView;

		// Token: 0x0401A810 RID: 108560
		private ITrapDefenseShopGoods DefaultGoods;

		// Token: 0x0401A811 RID: 108561
		private FColor? OriginalCostTextColor;

		// Token: 0x0401A812 RID: 108562
		private bool NeedRefreshAfterShow;

		// Token: 0x0200AC48 RID: 44104
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04034595 RID: 214421
			public const int ItemCaption = 0;

			// Token: 0x04034596 RID: 214422
			public const int BtnRefresh = 1;

			// Token: 0x04034597 RID: 214423
			public const int ScrollView = 2;

			// Token: 0x04034598 RID: 214424
			public const int TextRefresh = 3;

			// Token: 0x04034599 RID: 214425
			public const int TextureRefreshIcon = 4;

			// Token: 0x0403459A RID: 214426
			public const int TextRefreshCost = 5;

			// Token: 0x0403459B RID: 214427
			public const int TextItemDetailName = 6;

			// Token: 0x0403459C RID: 214428
			public const int ItemPurchase = 7;

			// Token: 0x0403459D RID: 214429
			public const int ItemBtnPurchase = 8;

			// Token: 0x0403459E RID: 214430
			public const int ItemUnavailable = 9;

			// Token: 0x0403459F RID: 214431
			public const int TextItemDetailDesc = 10;

			// Token: 0x040345A0 RID: 214432
			public const int ItemPrice = 11;

			// Token: 0x040345A1 RID: 214433
			public const int TextPriceLabel = 12;

			// Token: 0x040345A2 RID: 214434
			public const int TextureCostIcon = 13;

			// Token: 0x040345A3 RID: 214435
			public const int TextPrice = 14;

			// Token: 0x040345A4 RID: 214436
			public const int TextOriginalPrice = 15;

			// Token: 0x040345A5 RID: 214437
			public const int ItemNumSlider = 16;

			// Token: 0x040345A6 RID: 214438
			public const int TextUnavailable = 17;
		}
	}
}
