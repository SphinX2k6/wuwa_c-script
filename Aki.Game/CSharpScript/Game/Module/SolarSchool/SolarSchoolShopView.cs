using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A0D RID: 23053
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolShopView : UiViewBase
	{
		// Token: 0x06038C22 RID: 232482 RVA: 0x00FE3003 File Offset: 0x00FE1203
		public SolarSchoolShopView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038C23 RID: 232483 RVA: 0x00FE3038 File Offset: 0x00FE1238
		protected unsafe override void OnRegisterComponent()
		{
			int num = 18;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038C24 RID: 232484 RVA: 0x00FE32BC File Offset: 0x00FE14BC
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolShopView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolShopView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C25 RID: 232485 RVA: 0x00FE3300 File Offset: 0x00FE1500
		protected override void OnStart()
		{
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(3);
			this.GoodsRowScroll = new GenericScrollViewNew<SolarSchoolShopGoodsRowItem, SolarSchoolShopGoodsRowData>(scrollViewWithScrollbar, new Func<SolarSchoolShopGoodsRowItem>(this.CreateGoodsRowItem), base.GetItem(16).GetOwner() as AUIBaseActor, false, null);
			this.GoodsRowScroll.SetHorizontalScrollEnable(false);
			this.GoodsRowScroll.SetVerticalScrollEnable(false);
			UUILayoutBase verticalLayout = base.GetVerticalLayout(4);
			Func<SolarSchoolShopBonusItem> gridProxyCreateFunction;
			if ((gridProxyCreateFunction = SolarSchoolShopView.<>O.<0>__CreateBonusItem) == null)
			{
				gridProxyCreateFunction = (SolarSchoolShopView.<>O.<0>__CreateBonusItem = new Func<SolarSchoolShopBonusItem>(SolarSchoolShopView.CreateBonusItem));
			}
			this.BonusLayout = new GenericLayout<SolarSchoolShopBonusItem, SolarSchoolShopBonusItemData>(verticalLayout, gridProxyCreateFunction, base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
			UUILayoutBase gridLayout = base.GetGridLayout(14);
			Func<SolarSchoolShopLikeRoleItem> gridProxyCreateFunction2;
			if ((gridProxyCreateFunction2 = SolarSchoolShopView.<>O.<1>__CreateLikeRoleItem) == null)
			{
				gridProxyCreateFunction2 = (SolarSchoolShopView.<>O.<1>__CreateLikeRoleItem = new Func<SolarSchoolShopLikeRoleItem>(SolarSchoolShopView.CreateLikeRoleItem));
			}
			this.LikeRoleLayout = new GenericLayout<SolarSchoolShopLikeRoleItem, int>(gridLayout, gridProxyCreateFunction2, base.GetItem(15).GetOwner() as AUIBaseActor, false, true);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			rootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnPlaySequenceEvent));
		}

		// Token: 0x06038C26 RID: 232486 RVA: 0x00FE340F File Offset: 0x00FE160F
		private void OnPlaySequenceEvent(string sequenceName, string eventName)
		{
			if (eventName == "Sequence_Switch")
			{
				this.SelectGoods(this.SelectedGoods);
			}
		}

		// Token: 0x06038C27 RID: 232487 RVA: 0x00FE342A File Offset: 0x00FE162A
		protected override void OnBeforeShow()
		{
			this.RefreshViewAsync(ESolarSchoolSpineScene.Shop).Forget();
		}

		// Token: 0x06038C28 RID: 232488 RVA: 0x00FE3438 File Offset: 0x00FE1638
		protected override void OnBeforeDestroy()
		{
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor != null)
			{
				rootActor.OnSequencePlayEvent.Unbind();
			}
			this.ClerkSpineItem = null;
			this.GoodsRowScroll = null;
			this.LikeRoleLayout = null;
		}

		// Token: 0x06038C29 RID: 232489 RVA: 0x00FE3465 File Offset: 0x00FE1665
		private SolarSchoolShopGoodsRowItem CreateGoodsRowItem()
		{
			return new SolarSchoolShopGoodsRowItem
			{
				ClickCallback = new Action<SolarSchoolShopGoodsData>(this.OnGoodsClick)
			};
		}

		// Token: 0x06038C2A RID: 232490 RVA: 0x00FE347E File Offset: 0x00FE167E
		private static SolarSchoolShopBonusItem CreateBonusItem()
		{
			return new SolarSchoolShopBonusItem();
		}

		// Token: 0x06038C2B RID: 232491 RVA: 0x00FE3485 File Offset: 0x00FE1685
		private static SolarSchoolShopLikeRoleItem CreateLikeRoleItem()
		{
			return new SolarSchoolShopLikeRoleItem();
		}

		// Token: 0x06038C2C RID: 232492 RVA: 0x00FE348C File Offset: 0x00FE168C
		private UniTask RefreshViewAsync(ESolarSchoolSpineScene spineScene)
		{
			SolarSchoolShopView.<RefreshViewAsync>d__25 <RefreshViewAsync>d__;
			<RefreshViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshViewAsync>d__.<>4__this = this;
			<RefreshViewAsync>d__.spineScene = spineScene;
			<RefreshViewAsync>d__.<>1__state = -1;
			<RefreshViewAsync>d__.<>t__builder.Start<SolarSchoolShopView.<RefreshViewAsync>d__25>(ref <RefreshViewAsync>d__);
			return <RefreshViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C2D RID: 232493 RVA: 0x00FE34D8 File Offset: 0x00FE16D8
		private void AddGoodsBySoldOut(List<SolarSchoolShopGoodsData> goodsList, bool isSoldOut)
		{
			foreach (SolarSchoolShopGoodsData solarSchoolShopGoodsData in goodsList)
			{
				if (this.GoodsList.Count >= 8)
				{
					break;
				}
				if (solarSchoolShopGoodsData.IsSoldOut() == isSoldOut)
				{
					this.GoodsList.Add(solarSchoolShopGoodsData);
				}
			}
		}

		// Token: 0x06038C2E RID: 232494 RVA: 0x00FE3544 File Offset: 0x00FE1744
		private void BuildGoodsRows()
		{
			this.GoodsRows.Clear();
			for (int i = 0; i < 2; i++)
			{
				List<SolarSchoolShopSlotData> list = new List<SolarSchoolShopSlotData>(4);
				for (int j = 0; j < 4; j++)
				{
					int num = i * 4 + j;
					list.Add((num < this.GoodsList.Count) ? new SolarSchoolShopSlotData(this.GoodsList[num]) : SolarSchoolShopSlotData.Empty);
				}
				this.GoodsRows.Add(new SolarSchoolShopGoodsRowData(list));
			}
		}

		// Token: 0x06038C2F RID: 232495 RVA: 0x00FE35C0 File Offset: 0x00FE17C0
		private int FindGoodsIndex(long goodsKey)
		{
			for (int i = 0; i < this.GoodsList.Count; i++)
			{
				if ((long)this.GoodsList[i].Goods.Id == goodsKey)
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x06038C30 RID: 232496 RVA: 0x00FE3604 File Offset: 0x00FE1804
		private void RefreshTime()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int shopRefreshRemainingDays = instance.ShopData.GetShopRefreshRemainingDays(instance.TimeData.DayIndex);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "SolarSchoolShopDay", new <>z__ReadOnlySingleElementList<object>(shopRefreshRemainingDays));
		}

		// Token: 0x06038C31 RID: 232497 RVA: 0x00FE3650 File Offset: 0x00FE1850
		private UniTask ShowClerkAsync(ESolarSchoolSpineScene spineScene)
		{
			SolarSchoolShopView.<ShowClerkAsync>d__30 <ShowClerkAsync>d__;
			<ShowClerkAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowClerkAsync>d__.<>4__this = this;
			<ShowClerkAsync>d__.spineScene = spineScene;
			<ShowClerkAsync>d__.<>1__state = -1;
			<ShowClerkAsync>d__.<>t__builder.Start<SolarSchoolShopView.<ShowClerkAsync>d__30>(ref <ShowClerkAsync>d__);
			return <ShowClerkAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C32 RID: 232498 RVA: 0x00FE369C File Offset: 0x00FE189C
		private void RefreshDetail(SolarSchoolShopGoodsData data)
		{
			this.SelectedGoods = data;
			int itemCount = SolarSchoolGamePlayModel.Instance.InventoryData.GetItemCount(data.Goods.ItemId);
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "SolarSchool_BagNum", new <>z__ReadOnlySingleElementList<object>(itemCount));
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), data.Item.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), data.Item.Desc, Array.Empty<object>());
			this.RefreshBonusList(data.Item);
			this.RefreshGiftMetadata(data.Item);
			UUIItem item2 = base.GetItem(9);
			if (item2 != null)
			{
				item2.SetUIActive(!data.IsSoldOut());
			}
			UUIItem item3 = base.GetItem(10);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(data.IsSoldOut());
		}

		// Token: 0x06038C33 RID: 232499 RVA: 0x00FE3798 File Offset: 0x00FE1998
		private void RefreshGiftMetadata(SolarSchoolItem item)
		{
			bool flag = item.ItemType == 1;
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			this.LikeRoleIds.Clear();
			if (flag)
			{
				foreach (int num in item.GetFavorRoleListArray())
				{
					if (this.LikeRoleIds.Count >= 3)
					{
						break;
					}
					if (!this.LikeRoleIds.Contains(num) && SolarSchoolConfig.Instance.GetRole(num) != null)
					{
						this.LikeRoleIds.Add(num);
					}
				}
			}
			GenericLayout<SolarSchoolShopLikeRoleItem, int> likeRoleLayout = this.LikeRoleLayout;
			if (likeRoleLayout != null)
			{
				likeRoleLayout.RefreshByData(this.LikeRoleIds, null, false);
			}
			UUIItem item3 = base.GetItem(13);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(this.LikeRoleIds.Count > 0);
		}

		// Token: 0x06038C34 RID: 232500 RVA: 0x00FE3864 File Offset: 0x00FE1A64
		private void OnGoodsClick(SolarSchoolShopGoodsData data)
		{
			this.SelectedGoods = data;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06038C35 RID: 232501 RVA: 0x00FE3898 File Offset: 0x00FE1A98
		private void SelectGoods(SolarSchoolShopGoodsData data)
		{
			GenericScrollViewNew<SolarSchoolShopGoodsRowItem, SolarSchoolShopGoodsRowData> goodsRowScroll = this.GoodsRowScroll;
			foreach (SolarSchoolShopGoodsRowItem solarSchoolShopGoodsRowItem in (((goodsRowScroll != null) ? goodsRowScroll.GetScrollItemList() : null) ?? new List<SolarSchoolShopGoodsRowItem>()))
			{
				solarSchoolShopGoodsRowItem.SelectGoods((long)data.Goods.Id);
			}
			this.RefreshDetail(data);
		}

		// Token: 0x06038C36 RID: 232502 RVA: 0x00FE3914 File Offset: 0x00FE1B14
		private void RefreshBonusList(SolarSchoolItem item)
		{
			this.BonusList.Clear();
			foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in SolarSchoolGamePlayModel.Instance.GetItemAttrDeltas(item))
			{
				ESolarSchoolSecondAttr item2 = valueTuple.Item1;
				int item3 = valueTuple.Item2;
				this.BonusList.Add(new SolarSchoolShopBonusItemData(item2, item3));
			}
			bool flag = this.BonusList.Count > 0;
			GenericLayout<SolarSchoolShopBonusItem, SolarSchoolShopBonusItemData> bonusLayout = this.BonusLayout;
			if (bonusLayout != null)
			{
				UUIItem rootUiItem = bonusLayout.GetRootUiItem();
				if (rootUiItem != null)
				{
					rootUiItem.SetUIActive(flag);
				}
			}
			if (flag)
			{
				GenericLayout<SolarSchoolShopBonusItem, SolarSchoolShopBonusItemData> bonusLayout2 = this.BonusLayout;
				if (bonusLayout2 == null)
				{
					return;
				}
				bonusLayout2.RefreshByData(this.BonusList, null, false);
			}
		}

		// Token: 0x06038C37 RID: 232503 RVA: 0x00FE39D8 File Offset: 0x00FE1BD8
		private void OnBuyClick()
		{
			SolarSchoolShopGoodsData data = this.SelectedGoods;
			if (data == null || data.IsSoldOut())
			{
				return;
			}
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int price = data.GetPrice();
			if (instance.PlayerData.GetAttr(ESolarSchoolSecondAttr.Money) < price)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_InsufficientFunds", Array.Empty<object>());
				return;
			}
			SolarSchoolAttr? attrConfig = instance.GetAttrConfig(ESolarSchoolSecondAttr.Money);
			if (attrConfig == null)
			{
				return;
			}
			string str = ConfigMultiTextLang.GetLocalTextNew(attrConfig.Value.Name, null) ?? string.Empty;
			string text = StringUtils.Format("<texture={0}>", new string[]
			{
				attrConfig.Value.YellowIconSmall
			}) + str;
			string text2 = ConfigMultiTextLang.GetLocalTextNew(data.Item.Name, null) ?? string.Empty;
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolShopConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.BuyGoods(data.ShopId, data.Goods.Id);
			};
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				text,
				price.ToString(),
				text2,
				"1"
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06038C38 RID: 232504 RVA: 0x00FE3B29 File Offset: 0x00FE1D29
		private void BuyGoods(int shopId, int goodsId)
		{
			if (!SolarSchoolGamePlayModel.Instance.BuyShopGoods(shopId, goodsId, 1))
			{
				return;
			}
			this.RefreshViewAsync(ESolarSchoolSpineScene.ShopBuy).Forget();
		}

		// Token: 0x0401DE0D RID: 122381
		private const int GoodsCapacity = 8;

		// Token: 0x0401DE0E RID: 122382
		private const int GoodsPerRow = 4;

		// Token: 0x0401DE0F RID: 122383
		private const int LikeRoleCapacity = 3;

		// Token: 0x0401DE10 RID: 122384
		[Nullable(2)]
		private SolarSchoolCaptionItem Caption;

		// Token: 0x0401DE11 RID: 122385
		[Nullable(2)]
		private SolarSchoolBtnItem BuyButton;

		// Token: 0x0401DE12 RID: 122386
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<SolarSchoolShopGoodsRowItem, SolarSchoolShopGoodsRowData> GoodsRowScroll;

		// Token: 0x0401DE13 RID: 122387
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolShopBonusItem, SolarSchoolShopBonusItemData> BonusLayout;

		// Token: 0x0401DE14 RID: 122388
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolShopLikeRoleItem, int> LikeRoleLayout;

		// Token: 0x0401DE15 RID: 122389
		[Nullable(2)]
		private SolarSchoolCharacterSpineItem ClerkSpineItem;

		// Token: 0x0401DE16 RID: 122390
		private readonly List<SolarSchoolShopGoodsData> GoodsList = new List<SolarSchoolShopGoodsData>();

		// Token: 0x0401DE17 RID: 122391
		private readonly List<SolarSchoolShopGoodsRowData> GoodsRows = new List<SolarSchoolShopGoodsRowData>();

		// Token: 0x0401DE18 RID: 122392
		private readonly List<SolarSchoolShopBonusItemData> BonusList = new List<SolarSchoolShopBonusItemData>();

		// Token: 0x0401DE19 RID: 122393
		private readonly List<int> LikeRoleIds = new List<int>();

		// Token: 0x0401DE1A RID: 122394
		[Nullable(2)]
		private SolarSchoolShopGoodsData SelectedGoods;

		// Token: 0x0200B5BB RID: 46523
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038325 RID: 230181
			public const int Caption = 0;

			// Token: 0x04038326 RID: 230182
			public const int PnlSpineParentItem = 1;

			// Token: 0x04038327 RID: 230183
			public const int TxtTime = 2;

			// Token: 0x04038328 RID: 230184
			public const int ItemScroll = 3;

			// Token: 0x04038329 RID: 230185
			public const int PnlList = 4;

			// Token: 0x0403832A RID: 230186
			public const int PnlItem = 5;

			// Token: 0x0403832B RID: 230187
			public const int TxtDesc = 6;

			// Token: 0x0403832C RID: 230188
			public const int PnlGot = 7;

			// Token: 0x0403832D RID: 230189
			public const int TxtGot = 8;

			// Token: 0x0403832E RID: 230190
			public const int BtnBuy = 9;

			// Token: 0x0403832F RID: 230191
			public const int PnlSoldOut = 10;

			// Token: 0x04038330 RID: 230192
			public const int TxtTitle = 11;

			// Token: 0x04038331 RID: 230193
			public const int PnlGift = 12;

			// Token: 0x04038332 RID: 230194
			public const int PnlLike = 13;

			// Token: 0x04038333 RID: 230195
			public const int PnlRoleHead = 14;

			// Token: 0x04038334 RID: 230196
			public const int RoleHeadItem = 15;

			// Token: 0x04038335 RID: 230197
			public const int GoodsRowItem = 16;

			// Token: 0x04038336 RID: 230198
			public const int PnlRole = 17;
		}

		// Token: 0x0200B5BC RID: 46524
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04038337 RID: 230199
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<SolarSchoolShopBonusItem> <0>__CreateBonusItem;

			// Token: 0x04038338 RID: 230200
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Func<SolarSchoolShopLikeRoleItem> <1>__CreateLikeRoleItem;
		}
	}
}
