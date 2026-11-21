using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005745 RID: 22341
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlShop : UiPanelBase
	{
		// Token: 0x17006A56 RID: 27222
		// (get) Token: 0x060370D2 RID: 225490 RVA: 0x00F5D0D4 File Offset: 0x00F5B2D4
		private static long NowWallMs
		{
			get
			{
				return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			}
		}

		// Token: 0x17006A57 RID: 27223
		// (get) Token: 0x060370D3 RID: 225491 RVA: 0x00F5D0EE File Offset: 0x00F5B2EE
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17006A58 RID: 27224
		// (get) Token: 0x060370D4 RID: 225492 RVA: 0x00F5D0FA File Offset: 0x00F5B2FA
		private UUIItem PnlSell
		{
			get
			{
				return base.GetItem(10);
			}
		}

		// Token: 0x17006A59 RID: 27225
		// (get) Token: 0x060370D5 RID: 225493 RVA: 0x00F5D104 File Offset: 0x00F5B304
		private UUIButtonComponent RefreshBtn
		{
			get
			{
				return base.GetButton(4);
			}
		}

		// Token: 0x17006A5A RID: 27226
		// (get) Token: 0x060370D6 RID: 225494 RVA: 0x00F5D10D File Offset: 0x00F5B30D
		public UUIItem HitItem
		{
			get
			{
				return this.PnlSell;
			}
		}

		// Token: 0x060370D7 RID: 225495 RVA: 0x00F5D118 File Offset: 0x00F5B318
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickHelp));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickRefresh));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060370D8 RID: 225496 RVA: 0x00F5D3DC File Offset: 0x00F5B5DC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlShop.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlShop.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060370D9 RID: 225497 RVA: 0x00F5D41F File Offset: 0x00F5B61F
		protected override void OnBeforeDestroy()
		{
			this.UnbindEvents();
			LguiIntTween coinTween = this.CoinTween;
			if (coinTween != null)
			{
				coinTween.Destroy();
			}
			this.CoinTween = null;
		}

		// Token: 0x060370DA RID: 225498 RVA: 0x00F5D440 File Offset: 0x00F5B640
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnShopRefreshed));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnShopBought));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCoinUpdated, new Action(this.OnCoinUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnBagUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopToggleLock, new Action<int>(this.OnShopToggleLock));
		}

		// Token: 0x060370DB RID: 225499 RVA: 0x00F5D4F8 File Offset: 0x00F5B6F8
		private void UnbindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnShopRefreshed));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnShopBought));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCoinUpdated, new Action(this.OnCoinUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnBagUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopToggleLock, new Action<int>(this.OnShopToggleLock));
		}

		// Token: 0x060370DC RID: 225500 RVA: 0x00F5D5AD File Offset: 0x00F5B7AD
		public void SetRootSequencePlayer(UiSequencePlayer seqPlayer)
		{
			this.RootSequencePlayer = seqPlayer;
		}

		// Token: 0x060370DD RID: 225501 RVA: 0x00F5D5B8 File Offset: 0x00F5B7B8
		private UniTask CreateGoodsItemPanels()
		{
			DangoBrawlPnlShop.<CreateGoodsItemPanels>d__28 <CreateGoodsItemPanels>d__;
			<CreateGoodsItemPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGoodsItemPanels>d__.<>4__this = this;
			<CreateGoodsItemPanels>d__.<>1__state = -1;
			<CreateGoodsItemPanels>d__.<>t__builder.Start<DangoBrawlPnlShop.<CreateGoodsItemPanels>d__28>(ref <CreateGoodsItemPanels>d__);
			return <CreateGoodsItemPanels>d__.<>t__builder.Task;
		}

		// Token: 0x060370DE RID: 225502 RVA: 0x00F5D5FB File Offset: 0x00F5B7FB
		private void RefreshView()
		{
			this.RefreshText();
			this.RefreshGoldView(false);
			this.RefreshAllSlots();
			this.RefreshShopRefresh();
		}

		// Token: 0x060370DF RID: 225503 RVA: 0x00F5D618 File Offset: 0x00F5B818
		private void RefreshText()
		{
			int shopRound = this.ActData.GetShopRound();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "DangoBrawlBattleUIText_001", new <>z__ReadOnlySingleElementList<object>(shopRound));
		}

		// Token: 0x060370E0 RID: 225504 RVA: 0x00F5D654 File Offset: 0x00F5B854
		private void RefreshGoldView(bool animate = false)
		{
			int shopCoin = this.ActData.ShopCoin;
			int num = shopCoin - this.DisplayedCoin;
			if (animate && num != 0)
			{
				LguiIntTween coinTween = this.CoinTween;
				if (coinTween != null)
				{
					coinTween.PlayTween(this.DisplayedCoin, shopCoin, 0.3f, null);
				}
			}
			else
			{
				LguiIntTween coinTween2 = this.CoinTween;
				if (coinTween2 != null)
				{
					coinTween2.KillTween();
				}
				UUIText text = base.GetText(2);
				if (text != null)
				{
					text.SetText(shopCoin.ToString(), true);
				}
			}
			if (num < 0)
			{
				UUIText text2 = base.GetText(13);
				if (text2 != null)
				{
					text2.SetText(num.ToString(), true);
				}
				UiSequencePlayer rootSequencePlayer = this.RootSequencePlayer;
				if (rootSequencePlayer != null)
				{
					rootSequencePlayer.PlaySequencePurely("GlodDown", false, false);
				}
			}
			this.DisplayedCoin = shopCoin;
		}

		// Token: 0x060370E1 RID: 225505 RVA: 0x00F5D708 File Offset: 0x00F5B908
		private void RefreshAllSlots()
		{
			for (int i = 0; i < this.GoodsItemPanels.Count; i++)
			{
				this.GoodsItemPanels[i].BindShopSlot(i, this.ActData);
			}
		}

		// Token: 0x060370E2 RID: 225506 RVA: 0x00F5D744 File Offset: 0x00F5B944
		private void RefreshShopRefresh()
		{
			DangoBrawlInstBaseNotify instBase = this.ActData.InstBase;
			int num = (instBase != null) ? instBase.Coin : 0;
			int shopRefreshCost = this.ActData.ShopRefreshCost;
			string hexStr;
			if (num < shopRefreshCost)
			{
				hexStr = "FF6767FF";
			}
			else
			{
				hexStr = "FFFFFFFF";
			}
			UUIText text = base.GetText(12);
			if (text != null)
			{
				text.SetColor(FColor.FromHex(hexStr));
			}
			UUIText text2 = base.GetText(12);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(shopRefreshCost.ToString(), true);
		}

		// Token: 0x060370E3 RID: 225507 RVA: 0x00F5D7B8 File Offset: 0x00F5B9B8
		private void RefreshItemTips(int selectedUid, DangoBrawlPnlShopSlot hitSlot, EDangoBrawlTipsOperationMode operationMode)
		{
			if (selectedUid == -1 || this.ItemTips == null || hitSlot == null)
			{
				return;
			}
			DangoBrawlItemTipsData data = new DangoBrawlItemTipsData
			{
				ItemId = hitSlot.GetConfigId(),
				ItemUid = new int?(selectedUid),
				From = EDangoBrawlItemTipsFrom.Shop,
				GridItem = hitSlot.GetRootItem(),
				GridSize = new float?((float)136),
				ChangeY = new float?(this.ItemTipsOffsetY),
				ShowCombine = new bool?(true),
				OperationMode = operationMode
			};
			this.ItemTips.RefreshAndShow(data).Forget();
		}

		// Token: 0x060370E4 RID: 225508 RVA: 0x00F5D84C File Offset: 0x00F5BA4C
		public UUIItem GetGoldItem()
		{
			return base.GetText(2);
		}

		// Token: 0x060370E5 RID: 225509 RVA: 0x00F5D855 File Offset: 0x00F5BA55
		public UUIItem GetGoodsSlotRootItem(int index)
		{
			if (index < 0 || index >= this.GoodsItemPanels.Count)
			{
				return null;
			}
			return this.GoodsItemPanels[index].GetRootItem();
		}

		// Token: 0x060370E6 RID: 225510 RVA: 0x00F5D87C File Offset: 0x00F5BA7C
		public void SetRefreshBtnInteractive(bool interactive)
		{
			UUIButtonComponent refreshBtn = this.RefreshBtn;
			if (refreshBtn == null)
			{
				return;
			}
			refreshBtn.SetSelfInteractive(interactive);
		}

		// Token: 0x060370E7 RID: 225511 RVA: 0x00F5D890 File Offset: 0x00F5BA90
		private int GetSelectedShopUid()
		{
			DangoBrawlTouchController touch = this.Touch;
			DangoBrawlSelection dangoBrawlSelection = (touch != null) ? touch.GetContext().GetSelection() : null;
			if (dangoBrawlSelection == null || dangoBrawlSelection.Source != EDragSourceKind.Shop)
			{
				return -1;
			}
			return dangoBrawlSelection.Id;
		}

		// Token: 0x060370E8 RID: 225512 RVA: 0x00F5D8C8 File Offset: 0x00F5BAC8
		private DangoBrawlPnlShopSlot FindSlotByUid(int uid)
		{
			if (uid <= 0)
			{
				return null;
			}
			RepeatedField<DangoBrawlShopSlotInfo> shopSlots = this.ActData.ShopSlots;
			foreach (DangoBrawlPnlShopSlot dangoBrawlPnlShopSlot in this.GoodsItemPanels)
			{
				int mySlotIndex = dangoBrawlPnlShopSlot.MySlotIndex;
				int num;
				if (mySlotIndex < 0 || mySlotIndex >= shopSlots.Count)
				{
					num = 0;
				}
				else
				{
					DangoBrawlShopSlotInfo dangoBrawlShopSlotInfo = shopSlots[mySlotIndex];
					int? num2;
					if (dangoBrawlShopSlotInfo == null)
					{
						num2 = null;
					}
					else
					{
						DangoBrawlBaseItemInfo item = dangoBrawlShopSlotInfo.Item;
						num2 = ((item != null) ? new int?(item.Uid) : null);
					}
					int? num3 = num2;
					num = num3.GetValueOrDefault();
				}
				if (num == uid)
				{
					return dangoBrawlPnlShopSlot;
				}
			}
			return null;
		}

		// Token: 0x060370E9 RID: 225513 RVA: 0x00F5D988 File Offset: 0x00F5BB88
		public void SetItemTips(DangoBrawlItemTipsBase tips)
		{
			this.ItemTips = tips;
		}

		// Token: 0x060370EA RID: 225514 RVA: 0x00F5D991 File Offset: 0x00F5BB91
		public void SetOffsetY(float offsetY)
		{
			this.ItemTipsOffsetY = offsetY;
		}

		// Token: 0x060370EB RID: 225515 RVA: 0x00F5D99A File Offset: 0x00F5BB9A
		public void SetSellRaycastActive(bool active)
		{
			UUIItem item = base.GetItem(16);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x060370EC RID: 225516 RVA: 0x00F5D9B0 File Offset: 0x00F5BBB0
		public void UpdateSellPanelInfo(int configId)
		{
			if (configId > 0)
			{
				bool flag = DangoBrawlUtil.IsItemBlockSell(configId);
				UUIItem item = base.GetItem(15);
				if (item != null)
				{
					item.SetUIActive(!flag);
				}
				if (!flag)
				{
					int sellPrice = DangoBrawlUtil.GetSellPrice(configId);
					UUIText text = base.GetText(11);
					if (text != null)
					{
						text.SetText(sellPrice.ToString(), true);
					}
				}
				string textStringId = flag ? "DangoBrawlBattleUIText_056" : "PrefabTextItem_2211927649_Text";
				LguiUtil.Instance.SetLocalTextNew(base.GetText(14), textStringId, Array.Empty<object>());
			}
		}

		// Token: 0x060370ED RID: 225517 RVA: 0x00F5DA2C File Offset: 0x00F5BC2C
		public void RefreshItemTips(int uid, EDangoBrawlTipsOperationMode operationMode)
		{
			this.RefreshItemTips(uid, this.FindSlotByUid(uid), operationMode);
		}

		// Token: 0x060370EE RID: 225518 RVA: 0x00F5DA40 File Offset: 0x00F5BC40
		public int BeginSellCoinHold()
		{
			int num = this.TokenSeed + 1;
			this.TokenSeed = num;
			int num2 = num;
			this.CoinHoldTokens.Add(num2);
			return num2;
		}

		// Token: 0x060370EF RID: 225519 RVA: 0x00F5DA70 File Offset: 0x00F5BC70
		public int BeginCoinHoldWithFlush()
		{
			int num = this.TokenSeed + 1;
			this.TokenSeed = num;
			int num2 = num;
			this.CoinHoldTokens.Add(num2);
			this.CoinHoldPendingFlush = true;
			return num2;
		}

		// Token: 0x060370F0 RID: 225520 RVA: 0x00F5DAA4 File Offset: 0x00F5BCA4
		public void EndSellCoinHold(int token, bool flush)
		{
			this.CoinHoldTokens.Remove(token);
			if (this.CoinHoldTokens.Count > 0)
			{
				if (flush)
				{
					this.CoinHoldPendingFlush = true;
				}
				return;
			}
			bool flag = flush && this.CoinHoldPendingFlush;
			this.CoinHoldPendingFlush = false;
			if (flag)
			{
				this.RefreshGoldView(true);
			}
		}

		// Token: 0x060370F1 RID: 225521 RVA: 0x00F5DAF3 File Offset: 0x00F5BCF3
		private void OnCoinTweenUpdate(int value)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(value.ToString(), true);
		}

		// Token: 0x060370F2 RID: 225522 RVA: 0x00F5DB0E File Offset: 0x00F5BD0E
		private void OnShopRefreshed()
		{
			this.RefreshView();
		}

		// Token: 0x060370F3 RID: 225523 RVA: 0x00F5DB16 File Offset: 0x00F5BD16
		private void OnShopBought(int slotIndex, int uid, int configId, bool toBench)
		{
			DangoBrawlPnlShopSlot dangoBrawlPnlShopSlot = this.GoodsItemPanels[slotIndex];
			if (dangoBrawlPnlShopSlot == null)
			{
				return;
			}
			dangoBrawlPnlShopSlot.BindShopSlot(slotIndex, this.ActData);
		}

		// Token: 0x060370F4 RID: 225524 RVA: 0x00F5DB35 File Offset: 0x00F5BD35
		private void OnCoinUpdated()
		{
			if (this.CoinHoldTokens.Count > 0)
			{
				this.CoinHoldPendingFlush = true;
			}
			else
			{
				this.RefreshGoldView(true);
			}
			this.RefreshShopRefresh();
		}

		// Token: 0x060370F5 RID: 225525 RVA: 0x00F5DB5B File Offset: 0x00F5BD5B
		private void OnClickHelp()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlBackpackShopRateView, this.ActData.GetShopRoundConfigId(), null);
		}

		// Token: 0x060370F6 RID: 225526 RVA: 0x00F5DB80 File Offset: 0x00F5BD80
		private void OnClickRefresh()
		{
			if (DangoBrawlViewManager.TryBlockIfHolding(null) || DangoBrawlViewManager.TryBlockIfLayerMode(true) || DangoBrawlViewManager.TryBlockIfThreeChoose(true))
			{
				return;
			}
			if (DangoBrawlPnlShop.NowWallMs - this.LastRefreshWallMs < 500L)
			{
				return;
			}
			bool flag = false;
			foreach (DangoBrawlShopSlotInfo dangoBrawlShopSlotInfo in this.ActData.ShopSlots)
			{
				if (dangoBrawlShopSlotInfo.Item == null || dangoBrawlShopSlotInfo.Item.ConfigId <= 0 || !dangoBrawlShopSlotInfo.Locked)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips005", Array.Empty<object>());
				return;
			}
			int shopRefreshCost = this.ActData.ShopRefreshCost;
			int shopCoin = this.ActData.ShopCoin;
			if (shopRefreshCost > shopCoin)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips004", Array.Empty<object>());
				return;
			}
			this.LastRefreshWallMs = DangoBrawlPnlShop.NowWallMs;
			ActivityDangoBrawlController.Instance.RequestShopRefresh().Forget<bool>();
		}

		// Token: 0x060370F7 RID: 225527 RVA: 0x00F5DC90 File Offset: 0x00F5BE90
		private void OnSelectionChanged()
		{
			int selectedShopUid = this.GetSelectedShopUid();
			RepeatedField<DangoBrawlShopSlotInfo> shopSlots = this.ActData.ShopSlots;
			foreach (DangoBrawlPnlShopSlot dangoBrawlPnlShopSlot in this.GoodsItemPanels)
			{
				int mySlotIndex = dangoBrawlPnlShopSlot.MySlotIndex;
				int num;
				if (mySlotIndex < 0 || mySlotIndex >= shopSlots.Count)
				{
					num = 0;
				}
				else
				{
					DangoBrawlShopSlotInfo dangoBrawlShopSlotInfo = shopSlots[mySlotIndex];
					int? num2;
					if (dangoBrawlShopSlotInfo == null)
					{
						num2 = null;
					}
					else
					{
						DangoBrawlBaseItemInfo item = dangoBrawlShopSlotInfo.Item;
						num2 = ((item != null) ? new int?(item.Uid) : null);
					}
					int? num3 = num2;
					num = num3.GetValueOrDefault();
				}
				int num4 = num;
				bool selected = num4 > 0 && num4 == selectedShopUid;
				dangoBrawlPnlShopSlot.SetSelected(selected);
			}
		}

		// Token: 0x060370F8 RID: 225528 RVA: 0x00F5DD5C File Offset: 0x00F5BF5C
		private void OnBagUpdated()
		{
			this.RefreshAllSlots();
			this.RefreshShopRefresh();
		}

		// Token: 0x060370F9 RID: 225529 RVA: 0x00F5DD6A File Offset: 0x00F5BF6A
		private void OnShopToggleLock(int uid)
		{
			DangoBrawlPnlShopSlot dangoBrawlPnlShopSlot = this.FindSlotByUid(uid);
			if (dangoBrawlPnlShopSlot == null)
			{
				return;
			}
			dangoBrawlPnlShopSlot.TryToggleLock();
		}

		// Token: 0x0401D1EA RID: 119274
		[Nullable(1)]
		public ActivityDangoBrawlData ActData;

		// Token: 0x0401D1EB RID: 119275
		[Nullable(1)]
		private List<DangoBrawlPnlShopSlot> GoodsItemPanels = new List<DangoBrawlPnlShopSlot>();

		// Token: 0x0401D1EC RID: 119276
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0401D1ED RID: 119277
		private float ItemTipsOffsetY;

		// Token: 0x0401D1EE RID: 119278
		private UiSequencePlayer RootSequencePlayer;

		// Token: 0x0401D1EF RID: 119279
		[Nullable(1)]
		private LguiIntTween CoinTween;

		// Token: 0x0401D1F0 RID: 119280
		private int DisplayedCoin;

		// Token: 0x0401D1F1 RID: 119281
		private int TokenSeed;

		// Token: 0x0401D1F2 RID: 119282
		private bool CoinHoldPendingFlush;

		// Token: 0x0401D1F3 RID: 119283
		[Nullable(1)]
		private readonly HashSet<int> CoinHoldTokens = new HashSet<int>();

		// Token: 0x0401D1F4 RID: 119284
		private long LastRefreshWallMs;

		// Token: 0x0200B322 RID: 45858
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403758B RID: 226699
			TxtTitle,
			// Token: 0x0403758C RID: 226700
			BtnHelp,
			// Token: 0x0403758D RID: 226701
			TxtGold,
			// Token: 0x0403758E RID: 226702
			PnlAlpha,
			// Token: 0x0403758F RID: 226703
			BtnRefresh,
			// Token: 0x04037590 RID: 226704
			ItemGoods1,
			// Token: 0x04037591 RID: 226705
			ItemGoods2,
			// Token: 0x04037592 RID: 226706
			ItemGoods3,
			// Token: 0x04037593 RID: 226707
			ItemGoods4,
			// Token: 0x04037594 RID: 226708
			ItemGoods5,
			// Token: 0x04037595 RID: 226709
			PnlSell,
			// Token: 0x04037596 RID: 226710
			TxtSellPrice,
			// Token: 0x04037597 RID: 226711
			TxtRefresh,
			// Token: 0x04037598 RID: 226712
			TxtGoldDown,
			// Token: 0x04037599 RID: 226713
			TxtSell,
			// Token: 0x0403759A RID: 226714
			ItemSellPrice,
			// Token: 0x0403759B RID: 226715
			PnlSellRaycast
		}
	}
}
