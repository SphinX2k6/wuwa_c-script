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
	// Token: 0x020067F5 RID: 26613
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlShop : UiPanelBase
	{
		// Token: 0x17009715 RID: 38677
		// (get) Token: 0x0604257D RID: 271741 RVA: 0x0101BB90 File Offset: 0x01019D90
		private static long NowWallMs
		{
			get
			{
				return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
			}
		}

		// Token: 0x17009716 RID: 38678
		// (get) Token: 0x0604257E RID: 271742 RVA: 0x0101BBAA File Offset: 0x01019DAA
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17009717 RID: 38679
		// (get) Token: 0x0604257F RID: 271743 RVA: 0x0101BBB6 File Offset: 0x01019DB6
		private UUIItem PnlSell
		{
			get
			{
				return base.GetItem(10);
			}
		}

		// Token: 0x17009718 RID: 38680
		// (get) Token: 0x06042580 RID: 271744 RVA: 0x0101BBC0 File Offset: 0x01019DC0
		private UUIButtonComponent RefreshBtn
		{
			get
			{
				return base.GetButton(4);
			}
		}

		// Token: 0x17009719 RID: 38681
		// (get) Token: 0x06042581 RID: 271745 RVA: 0x0101BBC9 File Offset: 0x01019DC9
		public UUIItem HitItem
		{
			get
			{
				return this.PnlSell;
			}
		}

		// Token: 0x06042582 RID: 271746 RVA: 0x0101BBD4 File Offset: 0x01019DD4
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

		// Token: 0x06042583 RID: 271747 RVA: 0x0101BE98 File Offset: 0x0101A098
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlShop.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlShop.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042584 RID: 271748 RVA: 0x0101BEDB File Offset: 0x0101A0DB
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

		// Token: 0x06042585 RID: 271749 RVA: 0x0101BEFC File Offset: 0x0101A0FC
		private void BindEvents()
		{
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnShopRefreshed));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnShopBought));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlCoinUpdated, new Action(this.OnCoinUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnBagUpdated));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopToggleLock, new Action<int>(this.OnShopToggleLock));
		}

		// Token: 0x06042586 RID: 271750 RVA: 0x0101BFB4 File Offset: 0x0101A1B4
		private void UnbindEvents()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopRefreshed, new Action(this.OnShopRefreshed));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopBought, new Action<int, int, int, bool>(this.OnShopBought));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCoinUpdated, new Action(this.OnCoinUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnBagUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopToggleLock, new Action<int>(this.OnShopToggleLock));
		}

		// Token: 0x06042587 RID: 271751 RVA: 0x0101C069 File Offset: 0x0101A269
		public void SetRootSequencePlayer(UiSequencePlayer seqPlayer)
		{
			this.RootSequencePlayer = seqPlayer;
		}

		// Token: 0x06042588 RID: 271752 RVA: 0x0101C074 File Offset: 0x0101A274
		private UniTask CreateGoodsItemPanels()
		{
			DangoBrawlPnlShop.<CreateGoodsItemPanels>d__28 <CreateGoodsItemPanels>d__;
			<CreateGoodsItemPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGoodsItemPanels>d__.<>4__this = this;
			<CreateGoodsItemPanels>d__.<>1__state = -1;
			<CreateGoodsItemPanels>d__.<>t__builder.Start<DangoBrawlPnlShop.<CreateGoodsItemPanels>d__28>(ref <CreateGoodsItemPanels>d__);
			return <CreateGoodsItemPanels>d__.<>t__builder.Task;
		}

		// Token: 0x06042589 RID: 271753 RVA: 0x0101C0B7 File Offset: 0x0101A2B7
		private void RefreshView()
		{
			this.RefreshText();
			this.RefreshGoldView(false);
			this.RefreshAllSlots();
			this.RefreshShopRefresh();
		}

		// Token: 0x0604258A RID: 271754 RVA: 0x0101C0D4 File Offset: 0x0101A2D4
		private void RefreshText()
		{
			int shopRound = this.ActData.GetShopRound();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "DangoBrawlBattleUIText_001", new <>z__ReadOnlySingleElementList<object>(shopRound));
		}

		// Token: 0x0604258B RID: 271755 RVA: 0x0101C110 File Offset: 0x0101A310
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

		// Token: 0x0604258C RID: 271756 RVA: 0x0101C1C4 File Offset: 0x0101A3C4
		private void RefreshAllSlots()
		{
			for (int i = 0; i < this.GoodsItemPanels.Count; i++)
			{
				this.GoodsItemPanels[i].BindShopSlot(i, this.ActData);
			}
		}

		// Token: 0x0604258D RID: 271757 RVA: 0x0101C200 File Offset: 0x0101A400
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

		// Token: 0x0604258E RID: 271758 RVA: 0x0101C274 File Offset: 0x0101A474
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

		// Token: 0x0604258F RID: 271759 RVA: 0x0101C308 File Offset: 0x0101A508
		public UUIItem GetGoldItem()
		{
			return base.GetText(2);
		}

		// Token: 0x06042590 RID: 271760 RVA: 0x0101C311 File Offset: 0x0101A511
		public UUIItem GetGoodsSlotRootItem(int index)
		{
			if (index < 0 || index >= this.GoodsItemPanels.Count)
			{
				return null;
			}
			return this.GoodsItemPanels[index].GetRootItem();
		}

		// Token: 0x06042591 RID: 271761 RVA: 0x0101C338 File Offset: 0x0101A538
		public void SetRefreshBtnInteractive(bool interactive)
		{
			UUIButtonComponent refreshBtn = this.RefreshBtn;
			if (refreshBtn == null)
			{
				return;
			}
			refreshBtn.SetSelfInteractive(interactive);
		}

		// Token: 0x06042592 RID: 271762 RVA: 0x0101C34C File Offset: 0x0101A54C
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

		// Token: 0x06042593 RID: 271763 RVA: 0x0101C384 File Offset: 0x0101A584
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

		// Token: 0x06042594 RID: 271764 RVA: 0x0101C444 File Offset: 0x0101A644
		public void SetItemTips(DangoBrawlItemTipsBase tips)
		{
			this.ItemTips = tips;
		}

		// Token: 0x06042595 RID: 271765 RVA: 0x0101C44D File Offset: 0x0101A64D
		public void SetOffsetY(float offsetY)
		{
			this.ItemTipsOffsetY = offsetY;
		}

		// Token: 0x06042596 RID: 271766 RVA: 0x0101C456 File Offset: 0x0101A656
		public void SetSellRaycastActive(bool active)
		{
			UUIItem item = base.GetItem(16);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x06042597 RID: 271767 RVA: 0x0101C46C File Offset: 0x0101A66C
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

		// Token: 0x06042598 RID: 271768 RVA: 0x0101C4E8 File Offset: 0x0101A6E8
		public void RefreshItemTips(int uid, EDangoBrawlTipsOperationMode operationMode)
		{
			this.RefreshItemTips(uid, this.FindSlotByUid(uid), operationMode);
		}

		// Token: 0x06042599 RID: 271769 RVA: 0x0101C4FC File Offset: 0x0101A6FC
		public int BeginSellCoinHold()
		{
			int num = this.TokenSeed + 1;
			this.TokenSeed = num;
			int num2 = num;
			this.CoinHoldTokens.Add(num2);
			return num2;
		}

		// Token: 0x0604259A RID: 271770 RVA: 0x0101C52C File Offset: 0x0101A72C
		public int BeginCoinHoldWithFlush()
		{
			int num = this.TokenSeed + 1;
			this.TokenSeed = num;
			int num2 = num;
			this.CoinHoldTokens.Add(num2);
			this.CoinHoldPendingFlush = true;
			return num2;
		}

		// Token: 0x0604259B RID: 271771 RVA: 0x0101C560 File Offset: 0x0101A760
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

		// Token: 0x0604259C RID: 271772 RVA: 0x0101C5AF File Offset: 0x0101A7AF
		private void OnCoinTweenUpdate(int value)
		{
			UUIText text = base.GetText(2);
			if (text == null)
			{
				return;
			}
			text.SetText(value.ToString(), true);
		}

		// Token: 0x0604259D RID: 271773 RVA: 0x0101C5CA File Offset: 0x0101A7CA
		private void OnShopRefreshed()
		{
			this.RefreshView();
		}

		// Token: 0x0604259E RID: 271774 RVA: 0x0101C5D2 File Offset: 0x0101A7D2
		private void OnShopBought(int slotIndex, int uid, int configId, bool toBench)
		{
			DangoBrawlPnlShopSlot dangoBrawlPnlShopSlot = this.GoodsItemPanels[slotIndex];
			if (dangoBrawlPnlShopSlot == null)
			{
				return;
			}
			dangoBrawlPnlShopSlot.BindShopSlot(slotIndex, this.ActData);
		}

		// Token: 0x0604259F RID: 271775 RVA: 0x0101C5F1 File Offset: 0x0101A7F1
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

		// Token: 0x060425A0 RID: 271776 RVA: 0x0101C617 File Offset: 0x0101A817
		private void OnClickHelp()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlBackpackShopRateView, this.ActData.GetShopRoundConfigId(), null);
		}

		// Token: 0x060425A1 RID: 271777 RVA: 0x0101C63C File Offset: 0x0101A83C
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

		// Token: 0x060425A2 RID: 271778 RVA: 0x0101C74C File Offset: 0x0101A94C
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

		// Token: 0x060425A3 RID: 271779 RVA: 0x0101C818 File Offset: 0x0101AA18
		private void OnBagUpdated()
		{
			this.RefreshAllSlots();
			this.RefreshShopRefresh();
		}

		// Token: 0x060425A4 RID: 271780 RVA: 0x0101C826 File Offset: 0x0101AA26
		private void OnShopToggleLock(int uid)
		{
			DangoBrawlPnlShopSlot dangoBrawlPnlShopSlot = this.FindSlotByUid(uid);
			if (dangoBrawlPnlShopSlot == null)
			{
				return;
			}
			dangoBrawlPnlShopSlot.TryToggleLock();
		}

		// Token: 0x0402298D RID: 141709
		[Nullable(1)]
		public ActivityDangoBrawlData ActData;

		// Token: 0x0402298E RID: 141710
		[Nullable(1)]
		private List<DangoBrawlPnlShopSlot> GoodsItemPanels = new List<DangoBrawlPnlShopSlot>();

		// Token: 0x0402298F RID: 141711
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x04022990 RID: 141712
		private float ItemTipsOffsetY;

		// Token: 0x04022991 RID: 141713
		private UiSequencePlayer RootSequencePlayer;

		// Token: 0x04022992 RID: 141714
		[Nullable(1)]
		private LguiIntTween CoinTween;

		// Token: 0x04022993 RID: 141715
		private int DisplayedCoin;

		// Token: 0x04022994 RID: 141716
		private int TokenSeed;

		// Token: 0x04022995 RID: 141717
		private bool CoinHoldPendingFlush;

		// Token: 0x04022996 RID: 141718
		[Nullable(1)]
		private readonly HashSet<int> CoinHoldTokens = new HashSet<int>();

		// Token: 0x04022997 RID: 141719
		private long LastRefreshWallMs;

		// Token: 0x0200C955 RID: 51541
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CC9E RID: 248990
			TxtTitle,
			// Token: 0x0403CC9F RID: 248991
			BtnHelp,
			// Token: 0x0403CCA0 RID: 248992
			TxtGold,
			// Token: 0x0403CCA1 RID: 248993
			PnlAlpha,
			// Token: 0x0403CCA2 RID: 248994
			BtnRefresh,
			// Token: 0x0403CCA3 RID: 248995
			ItemGoods1,
			// Token: 0x0403CCA4 RID: 248996
			ItemGoods2,
			// Token: 0x0403CCA5 RID: 248997
			ItemGoods3,
			// Token: 0x0403CCA6 RID: 248998
			ItemGoods4,
			// Token: 0x0403CCA7 RID: 248999
			ItemGoods5,
			// Token: 0x0403CCA8 RID: 249000
			PnlSell,
			// Token: 0x0403CCA9 RID: 249001
			TxtSellPrice,
			// Token: 0x0403CCAA RID: 249002
			TxtRefresh,
			// Token: 0x0403CCAB RID: 249003
			TxtGoldDown,
			// Token: 0x0403CCAC RID: 249004
			TxtSell,
			// Token: 0x0403CCAD RID: 249005
			ItemSellPrice,
			// Token: 0x0403CCAE RID: 249006
			PnlSellRaycast
		}
	}
}
