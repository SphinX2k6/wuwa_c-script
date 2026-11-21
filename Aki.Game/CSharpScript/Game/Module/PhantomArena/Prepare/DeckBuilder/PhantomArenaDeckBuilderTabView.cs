using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.InputView.Controller;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004178 RID: 16760
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDeckBuilderTabView : PhantomArenaChildViewBase
	{
		// Token: 0x17005565 RID: 21861
		// (get) Token: 0x0602A6DE RID: 173790 RVA: 0x00BF7092 File Offset: 0x00BF5292
		// (set) Token: 0x0602A6DF RID: 173791 RVA: 0x00BF709F File Offset: 0x00BF529F
		public new IPhantomArenaDeckBuilderTabViewModel ViewModel
		{
			get
			{
				return this.ViewModel as IPhantomArenaDeckBuilderTabViewModel;
			}
			set
			{
				this.ViewModel = value;
			}
		}

		// Token: 0x0602A6E0 RID: 173792 RVA: 0x00BF70A8 File Offset: 0x00BF52A8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(15, typeof(UUIText)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUISprite)),
				new ValueTuple<int, Type>(19, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnPrePageBtnClick)),
				new ValueTuple<int, Delegate>(8, new Action(this.OnNextPageBtnClick)),
				new ValueTuple<int, Delegate>(10, new Action(this.OnQuicklyBuildBtnClick)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnSaveBtnClick)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnChangeNameBtnClick)),
				new ValueTuple<int, Delegate>(14, new Action(this.OnDeckDeleteBtnClick))
			};
		}

		// Token: 0x0602A6E1 RID: 173793 RVA: 0x00BF7324 File Offset: 0x00BF5524
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaDeckBuilderTabView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A6E2 RID: 173794 RVA: 0x00BF7368 File Offset: 0x00BF5568
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
			EventSystem.Instance.Add(EEventName.GamepadTriggerCardInfo, new Action<UUIItem>(this.OnGamepadTriggerCardInfo));
		}

		// Token: 0x0602A6E3 RID: 173795 RVA: 0x00BF73CC File Offset: 0x00BF55CC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
			EventSystem.Instance.Remove(EEventName.GamepadTriggerCardInfo, new Action<UUIItem>(this.OnGamepadTriggerCardInfo));
		}

		// Token: 0x0602A6E4 RID: 173796 RVA: 0x00BF7430 File Offset: 0x00BF5630
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			PhantomArenaDeckBuilderTabView.<OnBeforeShowAsyncImplement>d__31 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<OnBeforeShowAsyncImplement>d__31>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602A6E5 RID: 173797 RVA: 0x00BF7474 File Offset: 0x00BF5674
		protected override UniTask OnPlayingShowSequenceAsync()
		{
			PhantomArenaDeckBuilderTabView.<OnPlayingShowSequenceAsync>d__32 <OnPlayingShowSequenceAsync>d__;
			<OnPlayingShowSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingShowSequenceAsync>d__.<>4__this = this;
			<OnPlayingShowSequenceAsync>d__.<>1__state = -1;
			<OnPlayingShowSequenceAsync>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<OnPlayingShowSequenceAsync>d__32>(ref <OnPlayingShowSequenceAsync>d__);
			return <OnPlayingShowSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A6E6 RID: 173798 RVA: 0x00BF74B8 File Offset: 0x00BF56B8
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PhantomArenaDeckBuilderTabView.<OnPlayingStartSequenceAsync>d__33 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<OnPlayingStartSequenceAsync>d__33>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A6E7 RID: 173799 RVA: 0x00BF74FB File Offset: 0x00BF56FB
		protected override void OnBeforeHide()
		{
			this.ResetMainViewOverrideCloseFunc();
			PhantomArenaMainViewSwitchItem showLockedSwitchItem = this.ShowLockedSwitchItem;
			if (showLockedSwitchItem != null)
			{
				showLockedSwitchItem.SetActive(false);
			}
			PhantomArenaMainViewSwitchItem showLockedSwitchItem2 = this.ShowLockedSwitchItem;
			if (showLockedSwitchItem2 == null)
			{
				return;
			}
			showLockedSwitchItem2.SetOnStateChangedCallback(null);
		}

		// Token: 0x0602A6E8 RID: 173800 RVA: 0x00BF7528 File Offset: 0x00BF5728
		private List<ICardTabItemData> CreateElementTabItemDataList()
		{
			List<ECardTabType> list = new List<ECardTabType>();
			list.Add(ECardTabType.All);
			list.Add(ECardTabType.Ice);
			list.Add(ECardTabType.Fire);
			list.Add(ECardTabType.Thunder);
			list.Add(ECardTabType.Wind);
			list.Add(ECardTabType.Light);
			list.Add(ECardTabType.Dark);
			List<ICardTabItemData> list2 = new List<ICardTabItemData>();
			foreach (ECardTabType tabType in list)
			{
				ICardTabItemData item = this.CreateElementTabItemData(tabType);
				list2.Add(item);
			}
			return list2;
		}

		// Token: 0x0602A6E9 RID: 173801 RVA: 0x00BF75BC File Offset: 0x00BF57BC
		private ICardTabItemData CreateElementTabItemData(ECardTabType tabType)
		{
			ICardTabItemData result;
			if (tabType == ECardTabType.All)
			{
				result = new CardTabItemData
				{
					TabType = ECardTabType.All,
					ElementConfigId = null,
					TabTexturePath = "/Game/Aki/UI/UIResources/Common/Image/IconElementRound/T_IconElementAll.T_IconElementAll",
					TabElementColor = "FFFFFFFF",
					ShowRedDot = false,
					IsDisable = false,
					IsArrivedMax = false
				};
			}
			else
			{
				ECardElement ecardElement = PhantomArenaDefine.cardTabTypeToElementConfigId[tabType];
				PhantomBattleCardElement phantomBattleElementConfig = PhantomArenaConfig.Instance.GetPhantomBattleElementConfig((int)ecardElement);
				result = new CardTabItemData
				{
					TabType = tabType,
					ElementConfigId = new ECardElement?(ecardElement),
					TabTexturePath = phantomBattleElementConfig.TabIcon,
					TabElementColor = phantomBattleElementConfig.TabElementColor,
					ShowRedDot = false,
					IsDisable = false,
					IsArrivedMax = false
				};
			}
			return result;
		}

		// Token: 0x0602A6EA RID: 173802 RVA: 0x00BF7678 File Offset: 0x00BF5878
		private void UpdateLibraryCardDataList()
		{
			this.LibraryCardDataList.Clear();
			this.LibraryCardDataMap.Clear();
			foreach (PhantomBattleCard phantomBattleCard in PhantomArenaConfig.Instance.GetPhantomBattleCardByActivityId(base.ActivityId))
			{
				if (!phantomBattleCard.IsNpcCard)
				{
					int id = phantomBattleCard.Id;
					int element = phantomBattleCard.Element;
					Dictionary<int, int> dictionary = phantomBattleCard.InitAttack();
					int cardGroupNum = phantomBattleCard.CardGroupNum;
					int leftCount = cardGroupNum - this.DeckInfo.GetCardCount(id);
					DeckBuilderCardItemData deckBuilderCardItemData = new DeckBuilderCardItemData
					{
						CardId = id,
						CardFaceTexturePath = phantomBattleCard.CardFaceTexture,
						Cost = phantomBattleCard.Cost,
						Element = element,
						Attack = (dictionary.ContainsKey(0) ? dictionary[0] : 0),
						Life = (dictionary.ContainsKey(1) ? dictionary[1] : 0),
						IsLocked = !PhantomArenaModel.Instance.IsCardUnlock(id),
						LeftCount = leftCount,
						MaxCount = cardGroupNum,
						AddCardToDeck = new Action<int, int>(this.AddCardToDeck),
						DeckInfo = this.DeckInfo,
						OpenCardInfoView = new Action<int>(this.OpenCardInfoView),
						CardSpineData = PhantomArenaModel.Instance.CreateCardSpineData(id),
						OutlookUnlocked = PhantomArenaModel.Instance.IsCardOutlookUnlock(id),
						CardFaceType = PhantomArenaModel.Instance.GetCardFaceType(id),
						Disabled = false,
						IsAllInDeck = false,
						CardType = (ECardType)phantomBattleCard.Type
					};
					this.UpdateStateContextInCardData(deckBuilderCardItemData);
					this.LibraryCardDataList.Add(deckBuilderCardItemData);
					this.LibraryCardDataMap[id] = deckBuilderCardItemData;
				}
			}
			this.LibraryCardDataList.Sort((DeckBuilderCardItemData a, DeckBuilderCardItemData b) => PhantomArenaDefine.deckBuilderCardItemDataSortFunc(a, b));
		}

		// Token: 0x0602A6EB RID: 173803 RVA: 0x00BF7884 File Offset: 0x00BF5A84
		private void UpdateAllPageCardDataList()
		{
			CardFilterContext filterContext = new CardFilterContext
			{
				CostFilter = (ECardCostFilter)this.CurCostFilter,
				ElementFilter = this.TabDataList[this.CurSelectedElementTabIndex].TabType,
				IncludeLocked = this.IncludeLockedCard
			};
			this.AllPageCardDataList = PhantomArenaModel.Instance.FilterCardList<DeckBuilderCardItemData>(this.LibraryCardDataList, filterContext);
			int maxPage = (int)Math.Ceiling((double)this.AllPageCardDataList.Count / (double)this.MaxCardCountPerPage);
			this.MaxPage = maxPage;
			this.MinPage = Math.Min(this.MaxPage, 1);
			this.CurPage = this.MinPage;
		}

		// Token: 0x0602A6EC RID: 173804 RVA: 0x00BF7924 File Offset: 0x00BF5B24
		private void UpdateCurPageCardDataList()
		{
			int num = (this.CurPage - 1) * this.MaxCardCountPerPage;
			int num2 = this.CurPage * this.MaxCardCountPerPage;
			List<DeckBuilderCardItemData> list = new List<DeckBuilderCardItemData>();
			int num3 = num;
			while (num3 < num2 && num3 < this.AllPageCardDataList.Count)
			{
				list.Add(this.AllPageCardDataList[num3]);
				num3++;
			}
			this.CurPageCardDataList = list;
		}

		// Token: 0x0602A6ED RID: 173805 RVA: 0x00BF7988 File Offset: 0x00BF5B88
		private void RefreshPageText()
		{
			UUIText text = base.GetText(6);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.CurPage);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.MaxPage);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0602A6EE RID: 173806 RVA: 0x00BF79E0 File Offset: 0x00BF5BE0
		private void RefreshCardLayout()
		{
			bool uiactive = this.CurPageCardDataList.Count == 0;
			GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout = this.CardLayout;
			if (cardLayout != null)
			{
				cardLayout.RefreshByData(this.CurPageCardDataList, null, true);
			}
			UUIItem item = base.GetItem(5);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x0602A6EF RID: 173807 RVA: 0x00BF7A28 File Offset: 0x00BF5C28
		private UniTask RefreshCardLayoutAsync(bool playGridAnim)
		{
			PhantomArenaDeckBuilderTabView.<RefreshCardLayoutAsync>d__42 <RefreshCardLayoutAsync>d__;
			<RefreshCardLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardLayoutAsync>d__.<>4__this = this;
			<RefreshCardLayoutAsync>d__.playGridAnim = playGridAnim;
			<RefreshCardLayoutAsync>d__.<>1__state = -1;
			<RefreshCardLayoutAsync>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<RefreshCardLayoutAsync>d__42>(ref <RefreshCardLayoutAsync>d__);
			return <RefreshCardLayoutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A6F0 RID: 173808 RVA: 0x00BF7A74 File Offset: 0x00BF5C74
		private void RefreshAllCardLeftCount()
		{
			foreach (DeckBuilderCardItemData deckBuilderCardItemData in this.LibraryCardDataList)
			{
				deckBuilderCardItemData.LeftCount = deckBuilderCardItemData.MaxCount - this.DeckInfo.GetCardCount(deckBuilderCardItemData.CardId);
				GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout = this.CardLayout;
				if (cardLayout != null)
				{
					DeckBuilderCardItem layoutItemByKey = cardLayout.GetLayoutItemByKey(deckBuilderCardItemData.CardId);
					if (layoutItemByKey != null)
					{
						layoutItemByKey.RefreshLeftCount();
					}
				}
			}
		}

		// Token: 0x0602A6F1 RID: 173809 RVA: 0x00BF7B08 File Offset: 0x00BF5D08
		private void UpdateStateContextInCardData(DeckBuilderCardItemData data)
		{
			data.IsAllInDeck = (data.LeftCount == 0);
			AddCardContext context = new AddCardContext
			{
				CardId = data.CardId,
				Cost = data.Cost,
				Element = data.Element,
				MaxCount = data.MaxCount,
				AddCount = 1,
				CardType = data.CardType
			};
			data.Disabled = (this.DeckInfo.CheckCanAddCard(context) > EAddCardResult.Success);
		}

		// Token: 0x0602A6F2 RID: 173810 RVA: 0x00BF7B84 File Offset: 0x00BF5D84
		private void RefreshAllCardAvailable()
		{
			foreach (DeckBuilderCardItemData deckBuilderCardItemData in this.LibraryCardDataList)
			{
				this.UpdateStateContextInCardData(deckBuilderCardItemData);
				GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout = this.CardLayout;
				DeckBuilderCardItem deckBuilderCardItem = (cardLayout != null) ? cardLayout.GetLayoutItemByKey(deckBuilderCardItemData.CardId) : null;
				if (deckBuilderCardItem != null)
				{
					deckBuilderCardItem.RefreshAllInDeckComponent();
					deckBuilderCardItem.RefreshDisabledComponent();
				}
			}
		}

		// Token: 0x0602A6F3 RID: 173811 RVA: 0x00BF7C04 File Offset: 0x00BF5E04
		private void RefreshDeckSlotsPanel(bool needRequestCheckCardSkillUnlock = true)
		{
			DeckBuilderDeckSlotsPanelData data = new DeckBuilderDeckSlotsPanelData
			{
				DeckInfo = this.DeckInfo,
				SlotLongPressStartTime = new float?((float)PhantomArenaConfig.Instance.GetSlotLongPressStartTime(base.ActivityId)),
				SlotLongPressEndTime = new float?((float)PhantomArenaConfig.Instance.GetSlotLongPressEndTime(base.ActivityId)),
				OnCoreSlotItemSortClick = new Action<DeckBuilderCardSlotItem>(this.OnCoreSlotItemClick),
				OnCoreSlotItemLongPress = new Action<DeckBuilderCardSlotItem, float>(this.OnSlotItemLongPress),
				CanCoreSlotItemToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanCoreSlotItemToggleChange),
				OnNormalSlotItemSortClick = new Action<DeckBuilderCardSlotItem>(this.OnNormalSlotItemClick),
				OnNormalSlotItemLongPress = new Action<DeckBuilderCardSlotItem, float>(this.OnSlotItemLongPress),
				CanNormalSlotItemToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanNormalSlotItemToggleChange),
				CanFieldSlotItemToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanFieldSlotItemToggleChange),
				OnSlotItemLongPressEnd = new Action(this.OnSlotItemLongPressEnd),
				OnSlotCardPointEnterCallback = new Action<int>(this.OnSlotCardPointEnterCallback),
				OnSlotCardPointExitCallback = new Action(this.OnSlotCardPointExitCallback),
				SortContext = new CardSlotSortContext
				{
					SortType = (ECardSlotSortType)this.CurSlotSortType,
					IsAscending = this.IsAscending
				},
				ShowLocked = false,
				ShowOutlook = true,
				IsNeedFieldCard = false,
				IsNeedRequestCheckCardSkillUnlock = needRequestCheckCardSkillUnlock
			};
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.RefreshByData(data);
		}

		// Token: 0x0602A6F4 RID: 173812 RVA: 0x00BF7D60 File Offset: 0x00BF5F60
		public void RefreshElementTab()
		{
			List<ECardElement> elementList = this.DeckInfo.GetElementList();
			foreach (ICardTabItemData cardTabItemData in this.TabDataList)
			{
				if (cardTabItemData.TabType == ECardTabType.All)
				{
					cardTabItemData.IsArrivedMax = this.DeckInfo.IsDeckFull();
				}
				else
				{
					ECardElement tabElement = PhantomArenaDefine.cardTabTypeToElementConfigId[cardTabItemData.TabType];
					bool flag = this.DeckInfo.CheckCanAddElement(tabElement);
					cardTabItemData.IsDisable = !flag;
					cardTabItemData.ShowRedDot = (elementList.FindIndex((ECardElement element) => element == tabElement) != -1);
				}
			}
			LoopScrollView<DeckBuilderElementTabItem, ICardTabItemData> elementTabScrollView = this.ElementTabScrollView;
			if (elementTabScrollView == null)
			{
				return;
			}
			elementTabScrollView.RefreshAllGridProxies();
		}

		// Token: 0x0602A6F5 RID: 173813 RVA: 0x00BF7E40 File Offset: 0x00BF6040
		public void RefreshFullTip()
		{
			ECardTabType tabType = this.TabDataList[this.CurSelectedElementTabIndex].TabType;
			ECardElement? ecardElement = PhantomArenaDefine.cardTabTypeToElementConfigId.ContainsKey(tabType) ? new ECardElement?(PhantomArenaDefine.cardTabTypeToElementConfigId[tabType]) : null;
			bool flag = this.DeckInfo.IsDeckFull();
			bool flag2 = ecardElement != null && !this.DeckInfo.CheckCanAddElement(ecardElement.Value);
			UUIItem item = base.GetItem(16);
			if (item != null)
			{
				item.SetUIActive(flag || flag2);
			}
			string textStringId = flag2 ? "PrefabTextItem_3954833905_Text" : "PrefabTextItem_3799404500_Text";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(15), textStringId, Array.Empty<object>());
		}

		// Token: 0x0602A6F6 RID: 173814 RVA: 0x00BF7EFC File Offset: 0x00BF60FC
		private void OpenCardInfoView(int cardId)
		{
			DeckBuilderCardInfoViewData param = new DeckBuilderCardInfoViewData
			{
				CurCardId = cardId,
				CardList = this.AllPageCardDataList.ToArray(),
				DeckInfo = this.DeckInfo,
				AddCardToDeck = new Action<int, int>(this.AddCardToDeck),
				RemoveCardFromDeck = new Action<int, int>(this.RemoveCardSlotByCardId),
				CurCardIndex = new int?(this.AllPageCardDataList.FindIndex((DeckBuilderCardItemData data) => data.CardId == cardId)),
				CurrencyId = new int?(PhantomArenaModel.Instance.GetDustItemId(base.ActivityId)),
				SelectedTabIndex = new int?(0),
				NeedOutlookTab = true
			};
			UiManager.Instance.OpenView(EUiViewName.DeckBuilderCardInfoView, param, null);
		}

		// Token: 0x0602A6F7 RID: 173815 RVA: 0x00BF7FCC File Offset: 0x00BF61CC
		protected void AddCardToDeck(int cardId, int addCount = 1)
		{
			if (this.DeckInfo == null)
			{
				return;
			}
			DeckBuilderCardItemData deckBuilderCardItemData = this.AllPageCardDataList.Find((DeckBuilderCardItemData cardData) => cardData.CardId == cardId);
			if (deckBuilderCardItemData == null)
			{
				return;
			}
			if (deckBuilderCardItemData.IsLocked)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1071", Array.Empty<object>());
				return;
			}
			int cardCount = this.DeckInfo.GetCardCount(deckBuilderCardItemData.CardId);
			AddCardContext context = new AddCardContext
			{
				CardId = deckBuilderCardItemData.CardId,
				Cost = deckBuilderCardItemData.Cost,
				Element = deckBuilderCardItemData.Element,
				MaxCount = deckBuilderCardItemData.MaxCount,
				AddCount = addCount,
				CardType = deckBuilderCardItemData.CardType
			};
			EAddCardResult eaddCardResult = this.DeckInfo.AddCard(context);
			if (eaddCardResult == EAddCardResult.Success)
			{
				PhantomArenaController.Instance.RequestCheckCardSkillUnlock(this.DeckInfo, new Action<PhantomBattleCheckCardSkillUnlockResponse>(this.RefreshFieldCardEffectUnlock));
				DeckBuilderCardItemData deckBuilderCardItemData2 = this.LibraryCardDataMap[deckBuilderCardItemData.CardId];
				int cardCount2 = this.DeckInfo.GetCardCount(deckBuilderCardItemData.CardId);
				deckBuilderCardItemData2.LeftCount = deckBuilderCardItemData2.MaxCount - cardCount2;
				GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout = this.CardLayout;
				if (cardLayout != null)
				{
					DeckBuilderCardItem layoutItemByKey = cardLayout.GetLayoutItemByKey(deckBuilderCardItemData2.CardId);
					if (layoutItemByKey != null)
					{
						layoutItemByKey.RefreshLeftCount();
					}
				}
				int? needPlayAddAnimCard = (cardCount == 0) ? new int?(deckBuilderCardItemData.CardId) : null;
				if (deckBuilderCardItemData2.Cost == PhantomArenaConfig.Instance.GetPhantomArenaCardCoreCost())
				{
					DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
					if (deckSlotsPanel != null)
					{
						deckSlotsPanel.RefreshCoreCardSlot(needPlayAddAnimCard);
					}
					DeckBuilderDeckSlotsPanel deckSlotsPanel2 = this.DeckSlotsPanel;
					if (deckSlotsPanel2 != null)
					{
						deckSlotsPanel2.SwitchMaskState(EPhantomArenaDeckSlotType.Core);
					}
				}
				else
				{
					DeckBuilderDeckSlotsPanel deckSlotsPanel3 = this.DeckSlotsPanel;
					if (deckSlotsPanel3 != null)
					{
						deckSlotsPanel3.RefreshNormalCardSlot(needPlayAddAnimCard, true, deckBuilderCardItemData.CardId);
					}
					DeckBuilderDeckSlotsPanel deckSlotsPanel4 = this.DeckSlotsPanel;
					if (deckSlotsPanel4 != null)
					{
						deckSlotsPanel4.SwitchMaskState(EPhantomArenaDeckSlotType.Normal);
					}
				}
				DeckBuilderDeckSlotsPanel deckSlotsPanel5 = this.DeckSlotsPanel;
				if (deckSlotsPanel5 != null)
				{
					deckSlotsPanel5.RefreshCardSlotElements();
				}
				this.RefreshAllCardAvailable();
				this.RefreshElementTab();
				this.RefreshFullTip();
				return;
			}
			string text = PhantomArenaDefine.addCardFailedResultToTipTextId.ContainsKey(eaddCardResult) ? PhantomArenaDefine.addCardFailedResultToTipTextId[eaddCardResult] : null;
			if (text != null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId(text, Array.Empty<object>());
			}
		}

		// Token: 0x0602A6F8 RID: 173816 RVA: 0x00BF81F0 File Offset: 0x00BF63F0
		protected void RemoveCardSlotByCardId(int cardId, int removeCount = 1)
		{
			if (this.DeckInfo == null)
			{
				return;
			}
			RemoveCardContext context = new RemoveCardContext
			{
				CardId = cardId,
				RemoveCount = removeCount
			};
			if (this.DeckInfo.RemoveCard(context))
			{
				PhantomArenaController.Instance.RequestCheckCardSkillUnlock(this.DeckInfo, new Action<PhantomBattleCheckCardSkillUnlockResponse>(this.RefreshFieldCardEffectUnlock));
				DeckBuilderCardItemData deckBuilderCardItemData = this.LibraryCardDataMap[cardId];
				int cardCount = this.DeckInfo.GetCardCount(cardId);
				deckBuilderCardItemData.LeftCount = deckBuilderCardItemData.MaxCount - cardCount;
				GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout = this.CardLayout;
				if (cardLayout != null)
				{
					DeckBuilderCardItem layoutItemByKey = cardLayout.GetLayoutItemByKey(deckBuilderCardItemData.CardId);
					if (layoutItemByKey != null)
					{
						layoutItemByKey.RefreshLeftCount();
					}
				}
				if (deckBuilderCardItemData.Cost == PhantomArenaConfig.Instance.GetPhantomArenaCardCoreCost())
				{
					DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
					if (deckSlotsPanel != null)
					{
						deckSlotsPanel.RefreshCoreCardSlot(null);
					}
				}
				else if (deckBuilderCardItemData.CardType == ECardType.Field)
				{
					DeckBuilderDeckSlotsPanel deckSlotsPanel2 = this.DeckSlotsPanel;
					if (deckSlotsPanel2 != null)
					{
						deckSlotsPanel2.RefreshFieldCardSlot(null);
					}
				}
				else
				{
					DeckBuilderDeckSlotsPanel deckSlotsPanel3 = this.DeckSlotsPanel;
					if (deckSlotsPanel3 != null)
					{
						deckSlotsPanel3.RefreshNormalCardSlot(null, true, 0);
					}
				}
				DeckBuilderDeckSlotsPanel deckSlotsPanel4 = this.DeckSlotsPanel;
				if (deckSlotsPanel4 != null)
				{
					deckSlotsPanel4.RefreshCardSlotElements();
				}
				this.RefreshElementTab();
				this.RefreshAllCardAvailable();
				this.RefreshFullTip();
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "移除卡牌异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602A6F9 RID: 173817 RVA: 0x00BF834C File Offset: 0x00BF654C
		protected void RemoveCardSlotByElements(HashSet<ECardElement> elements)
		{
			if (this.DeckInfo == null)
			{
				return;
			}
			if (this.DeckInfo.RemoveCardByElements(elements))
			{
				this.RefreshAllCardLeftCount();
				this.RefreshAllCardAvailable();
				DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
				if (deckSlotsPanel != null)
				{
					deckSlotsPanel.RefreshCardSlot(null, false);
				}
				DeckBuilderDeckSlotsPanel deckSlotsPanel2 = this.DeckSlotsPanel;
				if (deckSlotsPanel2 != null)
				{
					deckSlotsPanel2.RefreshCardSlotElements();
				}
				this.RefreshElementTab();
				this.RefreshFullTip();
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "移除卡牌异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602A6FA RID: 173818 RVA: 0x00BF83D4 File Offset: 0x00BF65D4
		protected void RemoveAllCardSlot()
		{
			if (this.DeckInfo == null)
			{
				return;
			}
			if (this.DeckInfo.RemoveAllCard())
			{
				this.RefreshAllCardLeftCount();
				this.RefreshAllCardAvailable();
				DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
				if (deckSlotsPanel != null)
				{
					deckSlotsPanel.RefreshCardSlot(null, false);
				}
				DeckBuilderDeckSlotsPanel deckSlotsPanel2 = this.DeckSlotsPanel;
				if (deckSlotsPanel2 != null)
				{
					deckSlotsPanel2.RefreshCardSlotElements();
				}
				this.RefreshElementTab();
				this.RefreshFullTip();
				return;
			}
			Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "移除卡牌异常", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0602A6FB RID: 173819 RVA: 0x00BF845B File Offset: 0x00BF665B
		private void OnElementTabSelect(int gridIndex)
		{
			this.SelectElementTabByIndex(gridIndex);
			this.UpdateAllPageCardDataList();
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
			this.RefreshFullTip();
		}

		// Token: 0x0602A6FC RID: 173820 RVA: 0x00BF8482 File Offset: 0x00BF6682
		private void RefreshFieldCardEffectUnlock(PhantomBattleCheckCardSkillUnlockResponse info)
		{
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.RefreshFieldCardEffectUnlock(info);
		}

		// Token: 0x0602A6FD RID: 173821 RVA: 0x00BF8495 File Offset: 0x00BF6695
		private void SelectElementTabByIndex(int tabIndex)
		{
			this.CurSelectedElementTabIndex = tabIndex;
			LoopScrollView<DeckBuilderElementTabItem, ICardTabItemData> elementTabScrollView = this.ElementTabScrollView;
			if (elementTabScrollView == null)
			{
				return;
			}
			elementTabScrollView.SelectGridProxy(tabIndex, false);
		}

		// Token: 0x0602A6FE RID: 173822 RVA: 0x00BF84B0 File Offset: 0x00BF66B0
		private DeckBuilderElementTabItem CreateElementTabItem()
		{
			return new DeckBuilderElementTabItem
			{
				OnToggleSelect = new Action<int>(this.OnElementTabSelect)
			};
		}

		// Token: 0x0602A6FF RID: 173823 RVA: 0x00BF84C9 File Offset: 0x00BF66C9
		private DeckBuilderCardItem CreateCardItem()
		{
			return new DeckBuilderCardItem
			{
				IsNewPhantomArenaActivity = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId)
			};
		}

		// Token: 0x0602A700 RID: 173824 RVA: 0x00BF84E8 File Offset: 0x00BF66E8
		private void OnNormalSlotItemClick(DeckBuilderCardSlotItem item)
		{
			DeckCardSlotInfo data = item.GetData();
			if (data == null)
			{
				return;
			}
			this.RemoveCardSlotByCardId(data.CardId, 1);
		}

		// Token: 0x0602A701 RID: 173825 RVA: 0x00BF8510 File Offset: 0x00BF6710
		private void OnSlotItemLongPressComplete(DeckBuilderCardSlotItem item)
		{
			DeckCardSlotInfo data = item.GetData();
			if (data == null)
			{
				return;
			}
			DeckBuilderCardInfoViewData param = new DeckBuilderCardInfoViewData
			{
				CurCardId = data.CardId,
				DeckInfo = this.DeckInfo,
				AddCardToDeck = new Action<int, int>(this.AddCardToDeck),
				RemoveCardFromDeck = new Action<int, int>(this.RemoveCardSlotByCardId),
				CurrencyId = new int?(PhantomArenaModel.Instance.GetDustItemId(base.ActivityId)),
				NeedOutlookTab = true
			};
			UiManager.Instance.OpenView(EUiViewName.DeckBuilderCardInfoView, param, null);
		}

		// Token: 0x0602A702 RID: 173826 RVA: 0x00BF85A0 File Offset: 0x00BF67A0
		private void OnSlotItemLongPress(DeckBuilderCardSlotItem item, float progress)
		{
			if (progress == -1f)
			{
				this.OnSlotItemLongPressComplete(item);
				return;
			}
			UUIItem item2 = base.GetItem(17);
			if (item2 != null && !item2.bIsUIActive)
			{
				this.RefreshLongPressItemPosition();
				item2.SetUIActive(true);
			}
			UUISprite sprite = base.GetSprite(18);
			if (sprite != null)
			{
				sprite.SetFillAmount(progress);
			}
			if (progress >= 1f)
			{
				this.OnSlotItemLongPressComplete(item);
			}
		}

		// Token: 0x0602A703 RID: 173827 RVA: 0x00BF8604 File Offset: 0x00BF6804
		private void RefreshLongPressItemPosition()
		{
			FVector? pointerEventDataPosition = LguiEventSystemManager.Instance.GetPointerEventDataPosition(0);
			Vector2D vector2D = Vector2D.Create((double)pointerEventDataPosition.Value.X, (double)pointerEventDataPosition.Value.Y);
			Vector2D vector2D2 = vector2D;
			ULGUICanvasScaler canvasScaler = UiLayer.Instance.UiRootItem.GetCanvasScaler();
			FVector2D fvector2D = vector2D.ToUeVector2D(false);
			vector2D2.FromUeVector2D(canvasScaler.ConvertPositionFromViewportToLGUICanvas(fvector2D));
			float cardSlotItemLongPressOffsetX = PhantomArenaConfig.Instance.GetCardSlotItemLongPressOffsetX();
			float cardSlotItemLongPressOffsetY = PhantomArenaConfig.Instance.GetCardSlotItemLongPressOffsetY();
			float inX = (float)vector2D.X + cardSlotItemLongPressOffsetX;
			float inY = (float)vector2D.Y + cardSlotItemLongPressOffsetY;
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			FVector fvector = new FVector(inX, inY, 0f);
			item.SetLGUISpaceAbsolutePosition(fvector);
		}

		// Token: 0x0602A704 RID: 173828 RVA: 0x00BF86B7 File Offset: 0x00BF68B7
		private void OnSlotItemLongPressEnd()
		{
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0602A705 RID: 173829 RVA: 0x00BF86CC File Offset: 0x00BF68CC
		private bool CanNormalSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x0602A706 RID: 173830 RVA: 0x00BF86CF File Offset: 0x00BF68CF
		private bool CanFieldSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x0602A707 RID: 173831 RVA: 0x00BF86D4 File Offset: 0x00BF68D4
		private void OnCoreSlotItemClick(DeckBuilderCardSlotItem item)
		{
			DeckCardSlotInfo data = item.GetData();
			if (data == null)
			{
				return;
			}
			this.RemoveCardSlotByCardId(data.CardId, 1);
		}

		// Token: 0x0602A708 RID: 173832 RVA: 0x00BF86F9 File Offset: 0x00BF68F9
		private bool CanCoreSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x0602A709 RID: 173833 RVA: 0x00BF86FC File Offset: 0x00BF68FC
		private void OnPrePageBtnClick()
		{
			if (this.MaxPage == 0)
			{
				return;
			}
			if (this.CurPage == this.MinPage)
			{
				this.CurPage = this.MaxPage;
			}
			else
			{
				this.CurPage--;
			}
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
		}

		// Token: 0x0602A70A RID: 173834 RVA: 0x00BF8750 File Offset: 0x00BF6950
		private void OnNextPageBtnClick()
		{
			if (this.MaxPage == 0)
			{
				return;
			}
			if (this.CurPage == this.MaxPage)
			{
				this.CurPage = this.MinPage;
			}
			else
			{
				this.CurPage++;
			}
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
		}

		// Token: 0x0602A70B RID: 173835 RVA: 0x00BF87A4 File Offset: 0x00BF69A4
		private void OnDeckDeleteBtnClick()
		{
			if (this.DeckInfo == null || this.DeckInfo.GetTotalCardCount() == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_Delect_Empty", Array.Empty<object>());
				return;
			}
			HashSet<ECardElement> enabledElementSet = new HashSet<ECardElement>(this.DeckInfo.GetElementSetWithPhysical());
			DeckBuilderCardDeleteViewData param = new DeckBuilderCardDeleteViewData
			{
				EnabledElementSet = enabledElementSet,
				DeleteFunc = new Action<HashSet<ECardElement>>(this.RemoveCardSlotByElements)
			};
			UiManager.Instance.OpenView(EUiViewName.DeckBuilderCardDeleteView, param, null);
		}

		// Token: 0x0602A70C RID: 173836 RVA: 0x00BF881C File Offset: 0x00BF6A1C
		private void OnShowLockedToggleChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.IncludeLockedCard = true;
			}
			else
			{
				this.IncludeLockedCard = false;
			}
			this.UpdateAllPageCardDataList();
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
		}

		// Token: 0x0602A70D RID: 173837 RVA: 0x00BF884A File Offset: 0x00BF6A4A
		private void OnCostFilterResult(int configId, bool _)
		{
			this.CurCostFilter = configId;
			this.UpdateAllPageCardDataList();
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
		}

		// Token: 0x0602A70E RID: 173838 RVA: 0x00BF886B File Offset: 0x00BF6A6B
		private void OnSlotSortResult(int configId, bool isAscending)
		{
			this.CurSlotSortType = configId;
			this.IsAscending = isAscending;
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.RefreshBySortContext(new CardSlotSortContext
			{
				SortType = (ECardSlotSortType)configId,
				IsAscending = isAscending
			});
		}

		// Token: 0x0602A70F RID: 173839 RVA: 0x00BF88A0 File Offset: 0x00BF6AA0
		private void RefreshCardFilterEntrance()
		{
			IReadOnlyList<PhantomBattleCardFilter> allPhantomBattleCardFilter = PhantomArenaConfig.Instance.GetAllPhantomBattleCardFilter();
			List<IDeckBuilderSortFilterItemData> list = new List<IDeckBuilderSortFilterItemData>();
			foreach (PhantomBattleCardFilter phantomBattleCardFilter in allPhantomBattleCardFilter)
			{
				DeckBuilderSortFilterItemData item = new DeckBuilderSortFilterItemData
				{
					ConfigId = phantomBattleCardFilter.Id,
					Name = phantomBattleCardFilter.Name
				};
				list.Add(item);
			}
			DeckBuilderSortFilterEntrance cardFilterEntrance = this.CardFilterEntrance;
			if (cardFilterEntrance != null)
			{
				cardFilterEntrance.UpdateDataList(list.ToArray());
			}
			int gridIndex = allPhantomBattleCardFilter.IndexOf((PhantomBattleCardFilter config) => config.Id == this.CurCostFilter);
			DeckBuilderSortFilterEntrance cardFilterEntrance2 = this.CardFilterEntrance;
			if (cardFilterEntrance2 == null)
			{
				return;
			}
			cardFilterEntrance2.SelectItemByIndex(gridIndex, false);
		}

		// Token: 0x0602A710 RID: 173840 RVA: 0x00BF8958 File Offset: 0x00BF6B58
		private void RefreshSlotSortEntrance()
		{
			IReadOnlyList<PhantomBattleCardSlotSort> allPhantomBattleCardSlotSort = PhantomArenaConfig.Instance.GetAllPhantomBattleCardSlotSort();
			List<IDeckBuilderSortFilterItemData> list = new List<IDeckBuilderSortFilterItemData>();
			foreach (PhantomBattleCardSlotSort phantomBattleCardSlotSort in allPhantomBattleCardSlotSort)
			{
				DeckBuilderSortFilterItemData item = new DeckBuilderSortFilterItemData
				{
					ConfigId = phantomBattleCardSlotSort.Id,
					Name = phantomBattleCardSlotSort.Name
				};
				list.Add(item);
			}
			DeckBuilderSortFilterEntrance slotSortEntrance = this.SlotSortEntrance;
			if (slotSortEntrance != null)
			{
				slotSortEntrance.UpdateDataList(list.ToArray());
			}
			int gridIndex = allPhantomBattleCardSlotSort.IndexOf((PhantomBattleCardSlotSort config) => config.Id == this.CurSlotSortType);
			DeckBuilderSortFilterEntrance slotSortEntrance2 = this.SlotSortEntrance;
			if (slotSortEntrance2 != null)
			{
				slotSortEntrance2.SelectItemByIndex(gridIndex, false);
			}
			DeckBuilderSortFilterEntrance slotSortEntrance3 = this.SlotSortEntrance;
			if (slotSortEntrance3 == null)
			{
				return;
			}
			slotSortEntrance3.ChangeSortAscending(this.IsAscending, true, false);
		}

		// Token: 0x0602A711 RID: 173841 RVA: 0x00BF8A2C File Offset: 0x00BF6C2C
		private void OnPhantomArenaCardUnlock(int cardId)
		{
			DeckBuilderCardItemData deckBuilderCardItemData;
			if (this.LibraryCardDataMap.TryGetValue(cardId, out deckBuilderCardItemData))
			{
				deckBuilderCardItemData.IsLocked = false;
				this.UpdateStateContextInCardData(deckBuilderCardItemData);
				GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout = this.CardLayout;
				if (cardLayout == null)
				{
					return;
				}
				DeckBuilderCardItem layoutItemByKey = cardLayout.GetLayoutItemByKey(cardId);
				if (layoutItemByKey == null)
				{
					return;
				}
				layoutItemByKey.Refresh(deckBuilderCardItemData);
			}
		}

		// Token: 0x0602A712 RID: 173842 RVA: 0x00BF8A78 File Offset: 0x00BF6C78
		private void OnPhantomArenaCardOutlookUnlock(int cardId)
		{
			DeckBuilderCardItemData deckBuilderCardItemData;
			if (this.LibraryCardDataMap.TryGetValue(cardId, out deckBuilderCardItemData))
			{
				deckBuilderCardItemData.OutlookUnlocked = true;
				this.UpdateStateContextInCardData(deckBuilderCardItemData);
				GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout = this.CardLayout;
				if (cardLayout != null)
				{
					DeckBuilderCardItem layoutItemByKey = cardLayout.GetLayoutItemByKey(cardId);
					if (layoutItemByKey != null)
					{
						layoutItemByKey.Refresh(deckBuilderCardItemData);
					}
				}
				DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
				if (deckSlotsPanel == null)
				{
					return;
				}
				deckSlotsPanel.RefreshOutlookByCardId(cardId);
			}
		}

		// Token: 0x0602A713 RID: 173843 RVA: 0x00BF8AD7 File Offset: 0x00BF6CD7
		private void OnGamepadTriggerCardInfo(UUIItem uiItem)
		{
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.GamepadTriggerDeckBuilderCardInfoView(uiItem);
		}

		// Token: 0x0602A714 RID: 173844 RVA: 0x00BF8AEA File Offset: 0x00BF6CEA
		private void OnSaveBtnClick()
		{
			if (this.DeckInfo == null)
			{
				return;
			}
			this.SaveDeckInternal();
		}

		// Token: 0x0602A715 RID: 173845 RVA: 0x00BF8AFC File Offset: 0x00BF6CFC
		private void SaveDeckInternal()
		{
			if (this.DeckInfo == null)
			{
				return;
			}
			if (this.DeckInfo.GetDeckServerId() < 0)
			{
				PhantomArenaController.Instance.CardGroupAddRequest(this.DeckInfo.GetName(), this.DeckInfo.CoverToCardIdList().ToArray(), base.ActivityId, delegate(int _)
				{
					IPhantomArenaDeckBuilderTabViewModel viewModel = this.ViewModel;
					if (viewModel != null)
					{
						viewModel.UpdateEditableDeckList();
					}
					if (this.DeckInfo != null)
					{
						IPhantomArenaDeckBuilderTabViewModel viewModel2 = this.ViewModel;
						if (viewModel2 != null)
						{
							viewModel2.ReportDeckCreate(this.DeckInfo);
						}
					}
					base.CloseMe();
				});
				return;
			}
			int deckServerId = this.DeckInfo.GetDeckServerId();
			List<int> list = this.DeckInfo.CoverToCardIdList();
			PhantomArenaController.Instance.CardGroupUpdateRequest(deckServerId, list.ToArray(), base.ActivityId, delegate(int _)
			{
				IPhantomArenaDeckBuilderTabViewModel viewModel = this.ViewModel;
				if (viewModel != null)
				{
					viewModel.UpdateEditableDeckList();
				}
				if (this.DeckInfo != null)
				{
					IPhantomArenaDeckBuilderTabViewModel viewModel2 = this.ViewModel;
					if (viewModel2 != null)
					{
						viewModel2.ReportDeckCover(this.DeckInfo);
					}
				}
				base.CloseMe();
			});
		}

		// Token: 0x0602A716 RID: 173846 RVA: 0x00BF8B94 File Offset: 0x00BF6D94
		private void OnCloseBtnClick()
		{
			if (this.ViewModel == null)
			{
				return;
			}
			IPhantomArenaDeckBuilderTabViewModel viewModel = this.ViewModel;
			if (((viewModel != null) ? new bool?(viewModel.CheckCurEditDeckHasChange()) : null).GetValueOrDefault())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhantomArenaExitDeckBuilderViewConfirm);
				confirmBoxDataNew.FunctionMap[1] = new Action(base.CloseMe);
				confirmBoxDataNew.FunctionMap[2] = new Action(this.OnSaveBtnClick);
				confirmBoxDataNew.IsEscViewTriggerCallBack = false;
				bool isNew = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId);
				PhantomArenaController.Instance.OpenPhantomArenaConfirmBoxView(confirmBoxDataNew, isNew);
				return;
			}
			base.CloseMe();
		}

		// Token: 0x0602A717 RID: 173847 RVA: 0x00BF8C39 File Offset: 0x00BF6E39
		private void SetMainViewOverrideCloseFunc()
		{
			if (this.ViewModel != null)
			{
				this.ViewModel.SetOverrideCloseFunc(new Action(this.OnCloseBtnClick));
			}
		}

		// Token: 0x0602A718 RID: 173848 RVA: 0x00BF8C5A File Offset: 0x00BF6E5A
		private void ResetMainViewOverrideCloseFunc()
		{
			if (this.ViewModel != null)
			{
				this.ViewModel.ResetOverrideCloseFunc();
			}
		}

		// Token: 0x0602A719 RID: 173849 RVA: 0x00BF8C70 File Offset: 0x00BF6E70
		private void OnChangeNameBtnClick()
		{
			string text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("PhantomBattle_1077", null), Array.Empty<string>());
			CommonInputViewController instance = CommonInputViewController.Instance;
			string bottomText = text;
			Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack = new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.<OnChangeNameBtnClick>g__inputCallBack|84_0);
			DeckInfo deckInfo = this.DeckInfo;
			instance.OpenSetPhantomArenaDeckName(bottomText, callBack, ((deckInfo != null) ? deckInfo.GetName() : null) ?? "");
		}

		// Token: 0x0602A71A RID: 173850 RVA: 0x00BF8CC5 File Offset: 0x00BF6EC5
		private void OnSlotCardPointEnterCallback(int cardId)
		{
			if (this.CardDetailTip == null)
			{
				return;
			}
			this.CardDetailTip.IsMouseInSlotItem = true;
			this.CardDetailTip.RefreshCard(cardId, null);
			this.CardDetailTip.SetUiActive(true);
		}

		// Token: 0x0602A71B RID: 173851 RVA: 0x00BF8CF5 File Offset: 0x00BF6EF5
		private void OnSlotCardPointExitCallback()
		{
			if (this.CardDetailTip == null)
			{
				return;
			}
			this.CardDetailTip.IsMouseInSlotItem = false;
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				if (this.CardDetailTip == null)
				{
					return;
				}
				this.CardDetailTip.AddTimer();
			}, 500f, null, null, true, 1f);
		}

		// Token: 0x0602A71C RID: 173852 RVA: 0x00BF8D30 File Offset: 0x00BF6F30
		private void OnQuicklyBuildBtnClick()
		{
			DeckBuilderQuicklyBuildViewData param = new DeckBuilderQuicklyBuildViewData
			{
				ActivityId = base.ActivityId,
				ConfirmCallback = delegate(DeckInfo deckInfo)
				{
					bool flag = false;
					foreach (DeckCardSlotInfo deckCardSlotInfo in deckInfo.GetCardSlotList())
					{
						if (!PhantomArenaModel.Instance.IsCardUnlock(deckCardSlotInfo.CardId))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1080", Array.Empty<object>());
					}
					this.ReplaceDeck(deckInfo);
					IPhantomArenaDeckBuilderTabViewModel viewModel = this.ViewModel;
					if (viewModel == null)
					{
						return;
					}
					viewModel.RecordQuicklyBuildClick(deckInfo.GetDeckConfigId());
				}
			};
			UiManager.Instance.OpenView(EUiViewName.DeckBuilderQuicklyBuildView, param, null);
		}

		// Token: 0x0602A71D RID: 173853 RVA: 0x00BF8D74 File Offset: 0x00BF6F74
		private void ReplaceDeck(DeckInfo newDeckInfo)
		{
			DeckInfo deckInfo = this.DeckInfo;
			if (deckInfo != null)
			{
				deckInfo.RemoveAllCard();
			}
			foreach (DeckCardSlotInfo deckCardSlotInfo in newDeckInfo.GetCardSlotList())
			{
				if (PhantomArenaModel.Instance.IsCardUnlock(deckCardSlotInfo.CardId))
				{
					AddCardContext context = new AddCardContext
					{
						CardId = deckCardSlotInfo.CardId,
						Cost = deckCardSlotInfo.Cost,
						Element = deckCardSlotInfo.Element,
						MaxCount = deckCardSlotInfo.Count,
						AddCount = deckCardSlotInfo.Count,
						CardType = deckCardSlotInfo.CardType
					};
					DeckInfo deckInfo2 = this.DeckInfo;
					if (deckInfo2 != null)
					{
						deckInfo2.AddCard(context);
					}
				}
			}
			if (this.DeckInfo != null)
			{
				PhantomArenaController.Instance.RequestCheckCardSkillUnlock(this.DeckInfo, new Action<PhantomBattleCheckCardSkillUnlockResponse>(this.RefreshFieldCardEffectUnlock));
			}
			this.RefreshAllCardLeftCount();
			this.RefreshAllCardAvailable();
			this.RefreshDeckSlotsPanel(false);
			this.RefreshElementTab();
			this.RefreshFullTip();
		}

		// Token: 0x0602A71E RID: 173854 RVA: 0x00BF8E8C File Offset: 0x00BF708C
		protected override void OnBeforeDestroy()
		{
			IPhantomArenaDeckBuilderTabViewModel viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.EndEditDeck();
		}

		// Token: 0x0602A71F RID: 173855 RVA: 0x00BF8EA0 File Offset: 0x00BF70A0
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			string a = configParams[0];
			if (a == "Card")
			{
				int index = int.Parse(configParams[1]);
				GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout = this.CardLayout;
				UUIItem uuiitem;
				if (cardLayout == null)
				{
					uuiitem = null;
				}
				else
				{
					DeckBuilderCardItem layoutItemByIndex = cardLayout.GetLayoutItemByIndex(index);
					uuiitem = ((layoutItemByIndex != null) ? layoutItemByIndex.GetRootItem() : null);
				}
				UUIItem uuiitem2 = uuiitem;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
			else if (a == "CardDetail" || a == "New:CardDetail")
			{
				int index2 = int.Parse(configParams[1]);
				GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> cardLayout2 = this.CardLayout;
				if (cardLayout2 == null)
				{
					return null;
				}
				DeckBuilderCardItem layoutItemByIndex2 = cardLayout2.GetLayoutItemByIndex(index2);
				if (layoutItemByIndex2 == null)
				{
					return null;
				}
				return layoutItemByIndex2.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
			else
			{
				if (!(a == "CardInGroup"))
				{
					return null;
				}
				DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
				if (deckSlotsPanel == null)
				{
					return null;
				}
				return deckSlotsPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}

		// Token: 0x0602A725 RID: 173861 RVA: 0x00BF9070 File Offset: 0x00BF7270
		[NullableContext(0)]
		[CompilerGenerated]
		private UniTask<Aki.Protocol.ErrorCode> <OnChangeNameBtnClick>g__inputCallBack|84_0([Nullable(1)] string input)
		{
			PhantomArenaDeckBuilderTabView.<<OnChangeNameBtnClick>g__inputCallBack|84_0>d <<OnChangeNameBtnClick>g__inputCallBack|84_0>d;
			<<OnChangeNameBtnClick>g__inputCallBack|84_0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
			<<OnChangeNameBtnClick>g__inputCallBack|84_0>d.<>4__this = this;
			<<OnChangeNameBtnClick>g__inputCallBack|84_0>d.input = input;
			<<OnChangeNameBtnClick>g__inputCallBack|84_0>d.<>1__state = -1;
			<<OnChangeNameBtnClick>g__inputCallBack|84_0>d.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<<OnChangeNameBtnClick>g__inputCallBack|84_0>d>(ref <<OnChangeNameBtnClick>g__inputCallBack|84_0>d);
			return <<OnChangeNameBtnClick>g__inputCallBack|84_0>d.<>t__builder.Task;
		}

		// Token: 0x040170C9 RID: 94409
		protected Dictionary<int, DeckBuilderCardItemData> LibraryCardDataMap = new Dictionary<int, DeckBuilderCardItemData>();

		// Token: 0x040170CA RID: 94410
		protected List<DeckBuilderCardItemData> LibraryCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x040170CB RID: 94411
		protected List<DeckBuilderCardItemData> AllPageCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x040170CC RID: 94412
		protected List<DeckBuilderCardItemData> CurPageCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x040170CD RID: 94413
		protected int CurSelectedCardIndex = -1;

		// Token: 0x040170CE RID: 94414
		protected int CurPage;

		// Token: 0x040170CF RID: 94415
		protected int MinPage;

		// Token: 0x040170D0 RID: 94416
		protected int MaxPage;

		// Token: 0x040170D1 RID: 94417
		protected readonly int MaxCardCountPerPage = 8;

		// Token: 0x040170D2 RID: 94418
		protected List<ICardTabItemData> TabDataList = new List<ICardTabItemData>();

		// Token: 0x040170D3 RID: 94419
		protected int CurSelectedElementTabIndex = -1;

		// Token: 0x040170D4 RID: 94420
		protected int CurCostFilter = 1;

		// Token: 0x040170D5 RID: 94421
		protected bool IncludeLockedCard;

		// Token: 0x040170D6 RID: 94422
		protected int CurSlotSortType = 1;

		// Token: 0x040170D7 RID: 94423
		protected bool IsAscending = true;

		// Token: 0x040170D8 RID: 94424
		protected DeckInfo DeckInfo;

		// Token: 0x040170D9 RID: 94425
		private LoopScrollView<DeckBuilderElementTabItem, ICardTabItemData> ElementTabScrollView;

		// Token: 0x040170DA RID: 94426
		protected GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> CardLayout;

		// Token: 0x040170DB RID: 94427
		protected PhantomArenaMainViewSwitchItem ShowLockedSwitchItem;

		// Token: 0x040170DC RID: 94428
		protected DeckBuilderSortFilterEntrance SlotSortEntrance;

		// Token: 0x040170DD RID: 94429
		protected DeckBuilderSortFilterEntrance CardFilterEntrance;

		// Token: 0x040170DE RID: 94430
		protected DeckBuilderDeckSlotsPanel DeckSlotsPanel;

		// Token: 0x040170DF RID: 94431
		private DeckBuilderCardDetailTip CardDetailTip;

		// Token: 0x02009D4F RID: 40271
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x04030EC2 RID: 200386
			public const int ElementTabLoopScrollView = 0;

			// Token: 0x04030EC3 RID: 200387
			public const int ElementTabItem = 1;

			// Token: 0x04030EC4 RID: 200388
			public const int CardLayout = 2;

			// Token: 0x04030EC5 RID: 200389
			public const int CardItem = 3;

			// Token: 0x04030EC6 RID: 200390
			public const int FilterItem = 4;

			// Token: 0x04030EC7 RID: 200391
			public const int CardEmptyItem = 5;

			// Token: 0x04030EC8 RID: 200392
			public const int PageText = 6;

			// Token: 0x04030EC9 RID: 200393
			public const int PrePageBtn = 7;

			// Token: 0x04030ECA RID: 200394
			public const int NextPageBtn = 8;

			// Token: 0x04030ECB RID: 200395
			public const int SortItem = 9;

			// Token: 0x04030ECC RID: 200396
			public const int QuicklyBuildBtn = 10;

			// Token: 0x04030ECD RID: 200397
			public const int SaveBtn = 11;

			// Token: 0x04030ECE RID: 200398
			public const int DeckSlotsPanelItem = 12;

			// Token: 0x04030ECF RID: 200399
			public const int RenameBtn = 13;

			// Token: 0x04030ED0 RID: 200400
			public const int DeleteBtn = 14;

			// Token: 0x04030ED1 RID: 200401
			public const int TextFullTip = 15;

			// Token: 0x04030ED2 RID: 200402
			public const int ItemFullTip = 16;

			// Token: 0x04030ED3 RID: 200403
			public const int LongPressItem = 17;

			// Token: 0x04030ED4 RID: 200404
			public const int SpriteLongPressBar = 18;

			// Token: 0x04030ED5 RID: 200405
			public const int ItemDetailTipPanel = 19;
		}
	}
}
