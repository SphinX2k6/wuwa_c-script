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
	// Token: 0x02003A79 RID: 14969
	[NullableContext(2)]
	[Nullable(0)]
	public class TrapDefenseShopView : UiViewBase
	{
		// Token: 0x06026753 RID: 157523 RVA: 0x00AC5957 File Offset: 0x00AC3B57
		[NullableContext(1)]
		public TrapDefenseShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06026754 RID: 157524 RVA: 0x00AC5960 File Offset: 0x00AC3B60
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

		// Token: 0x06026755 RID: 157525 RVA: 0x00AC5C20 File Offset: 0x00AC3E20
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseShopView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseShopView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026756 RID: 157526 RVA: 0x00AC5C64 File Offset: 0x00AC3E64
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

		// Token: 0x06026757 RID: 157527 RVA: 0x00AC5CAC File Offset: 0x00AC3EAC
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

		// Token: 0x06026758 RID: 157528 RVA: 0x00AC5CFD File Offset: 0x00AC3EFD
		protected override void OnBeforeHide()
		{
			this.NeedRefreshAfterShow = true;
		}

		// Token: 0x06026759 RID: 157529 RVA: 0x00AC5D06 File Offset: 0x00AC3F06
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TrapDefenseShopRefresh, new Action(this.OnShopRefresh));
		}

		// Token: 0x0602675A RID: 157530 RVA: 0x00AC5D24 File Offset: 0x00AC3F24
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TrapDefenseShopRefresh, new Action(this.OnShopRefresh));
		}

		// Token: 0x0602675B RID: 157531 RVA: 0x00AC5D44 File Offset: 0x00AC3F44
		protected override void OnBeforeDestroy()
		{
			TrapDefenseModel.Instance.ViewModelShop.RemoveOnSelectGoodsDelegate(new Action<ITrapDefenseShopGoods>(this.OnSelectGoods));
			TrapDefenseModel.Instance.ViewModelShop.OnViewClose();
			TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(10));
			this.NeedRefreshAfterShow = false;
		}

		// Token: 0x0602675C RID: 157532 RVA: 0x00AC5D94 File Offset: 0x00AC3F94
		private UniTask RefreshGoodsPanel()
		{
			TrapDefenseShopView.<RefreshGoodsPanel>d__19 <RefreshGoodsPanel>d__;
			<RefreshGoodsPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshGoodsPanel>d__.<>4__this = this;
			<RefreshGoodsPanel>d__.<>1__state = -1;
			<RefreshGoodsPanel>d__.<>t__builder.Start<TrapDefenseShopView.<RefreshGoodsPanel>d__19>(ref <RefreshGoodsPanel>d__);
			return <RefreshGoodsPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602675D RID: 157533 RVA: 0x00AC5DD8 File Offset: 0x00AC3FD8
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

		// Token: 0x0602675E RID: 157534 RVA: 0x00AC5F2D File Offset: 0x00AC412D
		[NullableContext(1)]
		private void OnSelectGoods(ITrapDefenseShopGoods goods)
		{
			this.RefreshGoodsDetail(goods);
		}

		// Token: 0x0602675F RID: 157535 RVA: 0x00AC5F38 File Offset: 0x00AC4138
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

		// Token: 0x06026760 RID: 157536 RVA: 0x00AC6070 File Offset: 0x00AC4270
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

		// Token: 0x06026761 RID: 157537 RVA: 0x00AC60F0 File Offset: 0x00AC42F0
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

		// Token: 0x06026762 RID: 157538 RVA: 0x00AC614C File Offset: 0x00AC434C
		private void OnShopRefresh()
		{
			this.RefreshGoodsPanel().Forget();
			ITrapDefenseShopGoods selectedGoods = TrapDefenseModel.Instance.ViewModelShop.SelectedGoods;
			TrapDefenseShopData shopData = TrapDefenseModel.Instance.ShopData;
			bool flag = shopData.ItemGoodsMap.ContainsKey(selectedGoods.Id) || shopData.BuffGoodsMap.ContainsKey(selectedGoods.Id);
			TrapDefenseModel.Instance.ViewModelShop.SelectGoods(flag ? selectedGoods : this.DefaultGoods);
			this.CostItem.UpdateGoldCostNum();
		}

		// Token: 0x0401515C RID: 86364
		private PopupCaptionItem Caption;

		// Token: 0x0401515D RID: 86365
		private NumberSelectComponent NumberSelectComponent;

		// Token: 0x0401515E RID: 86366
		private ButtonItem PurchaseButton;

		// Token: 0x0401515F RID: 86367
		private TrapDefenseGoldCostItem CostItem;

		// Token: 0x04015160 RID: 86368
		private TrapDefenseShopCheckBuffItem CheckBuffItem;

		// Token: 0x04015161 RID: 86369
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<TrapDefenseShopGoodsContainerItem, TrapDefenseShopGoodsListData> ScrollView;

		// Token: 0x04015162 RID: 86370
		private ITrapDefenseShopGoods DefaultGoods;

		// Token: 0x04015163 RID: 86371
		private FColor? OriginalCostTextColor;

		// Token: 0x04015164 RID: 86372
		private bool NeedRefreshAfterShow;

		// Token: 0x02009668 RID: 38504
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402EF46 RID: 192326
			public const int ItemCaption = 0;

			// Token: 0x0402EF47 RID: 192327
			public const int BtnRefresh = 1;

			// Token: 0x0402EF48 RID: 192328
			public const int ScrollView = 2;

			// Token: 0x0402EF49 RID: 192329
			public const int TextRefresh = 3;

			// Token: 0x0402EF4A RID: 192330
			public const int TextureRefreshIcon = 4;

			// Token: 0x0402EF4B RID: 192331
			public const int TextRefreshCost = 5;

			// Token: 0x0402EF4C RID: 192332
			public const int TextItemDetailName = 6;

			// Token: 0x0402EF4D RID: 192333
			public const int ItemPurchase = 7;

			// Token: 0x0402EF4E RID: 192334
			public const int ItemBtnPurchase = 8;

			// Token: 0x0402EF4F RID: 192335
			public const int ItemUnavailable = 9;

			// Token: 0x0402EF50 RID: 192336
			public const int TextItemDetailDesc = 10;

			// Token: 0x0402EF51 RID: 192337
			public const int ItemPrice = 11;

			// Token: 0x0402EF52 RID: 192338
			public const int TextPriceLabel = 12;

			// Token: 0x0402EF53 RID: 192339
			public const int TextureCostIcon = 13;

			// Token: 0x0402EF54 RID: 192340
			public const int TextPrice = 14;

			// Token: 0x0402EF55 RID: 192341
			public const int TextOriginalPrice = 15;

			// Token: 0x0402EF56 RID: 192342
			public const int ItemNumSlider = 16;

			// Token: 0x0402EF57 RID: 192343
			public const int TextUnavailable = 17;
		}
	}
}
