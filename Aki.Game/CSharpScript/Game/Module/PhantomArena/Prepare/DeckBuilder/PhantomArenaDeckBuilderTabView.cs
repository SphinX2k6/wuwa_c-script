using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020051A8 RID: 20904
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDeckBuilderTabView : PhantomArenaChildViewBase
	{
		// Token: 0x170081A5 RID: 33189
		// (get) Token: 0x060357E3 RID: 219107 RVA: 0x00CA9A5A File Offset: 0x00CA7C5A
		// (set) Token: 0x060357E4 RID: 219108 RVA: 0x00CA9A67 File Offset: 0x00CA7C67
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

		// Token: 0x060357E5 RID: 219109 RVA: 0x00CA9A70 File Offset: 0x00CA7C70
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

		// Token: 0x060357E6 RID: 219110 RVA: 0x00CA9CEC File Offset: 0x00CA7EEC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaDeckBuilderTabView.<OnBeforeStartAsync>d__28 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<OnBeforeStartAsync>d__28>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060357E7 RID: 219111 RVA: 0x00CA9D30 File Offset: 0x00CA7F30
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
			EventSystem.Instance.Add(EEventName.GamepadTriggerCardInfo, new Action<UUIItem>(this.OnGamepadTriggerCardInfo));
		}

		// Token: 0x060357E8 RID: 219112 RVA: 0x00CA9D94 File Offset: 0x00CA7F94
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
			EventSystem.Instance.Remove(EEventName.GamepadTriggerCardInfo, new Action<UUIItem>(this.OnGamepadTriggerCardInfo));
		}

		// Token: 0x060357E9 RID: 219113 RVA: 0x00CA9DF8 File Offset: 0x00CA7FF8
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			PhantomArenaDeckBuilderTabView.<OnBeforeShowAsyncImplement>d__31 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<OnBeforeShowAsyncImplement>d__31>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060357EA RID: 219114 RVA: 0x00CA9E3C File Offset: 0x00CA803C
		protected override UniTask OnPlayingShowSequenceAsync()
		{
			PhantomArenaDeckBuilderTabView.<OnPlayingShowSequenceAsync>d__32 <OnPlayingShowSequenceAsync>d__;
			<OnPlayingShowSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingShowSequenceAsync>d__.<>4__this = this;
			<OnPlayingShowSequenceAsync>d__.<>1__state = -1;
			<OnPlayingShowSequenceAsync>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<OnPlayingShowSequenceAsync>d__32>(ref <OnPlayingShowSequenceAsync>d__);
			return <OnPlayingShowSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060357EB RID: 219115 RVA: 0x00CA9E80 File Offset: 0x00CA8080
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PhantomArenaDeckBuilderTabView.<OnPlayingStartSequenceAsync>d__33 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PhantomArenaDeckBuilderTabView.<OnPlayingStartSequenceAsync>d__33>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060357EC RID: 219116 RVA: 0x00CA9EC3 File Offset: 0x00CA80C3
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

		// Token: 0x060357ED RID: 219117 RVA: 0x00CA9EF0 File Offset: 0x00CA80F0
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

		// Token: 0x060357EE RID: 219118 RVA: 0x00CA9F84 File Offset: 0x00CA8184
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

		// Token: 0x060357EF RID: 219119 RVA: 0x00CAA040 File Offset: 0x00CA8240
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

		// Token: 0x060357F0 RID: 219120 RVA: 0x00CAA24C File Offset: 0x00CA844C
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

		// Token: 0x060357F1 RID: 219121 RVA: 0x00CAA2EC File Offset: 0x00CA84EC
		private void UpdateCurPageCardDataList()
		{
			int num = (this.CurPage - 1) * this.MaxCardCountPerPage;
			int num2 = this.CurPage * this.MaxCardCountPerPage;
			this.CurPageCardDataList = this.AllPageCardDataList.Skip(num).Take(num2 - num).ToList<DeckBuilderCardItemData>();
		}

		// Token: 0x060357F2 RID: 219122 RVA: 0x00CAA338 File Offset: 0x00CA8538
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

		// Token: 0x060357F3 RID: 219123 RVA: 0x00CAA390 File Offset: 0x00CA8590
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

		// Token: 0x060357F4 RID: 219124 RVA: 0x00CAA3D8 File Offset: 0x00CA85D8
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

		// Token: 0x060357F5 RID: 219125 RVA: 0x00CAA424 File Offset: 0x00CA8624
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

		// Token: 0x060357F6 RID: 219126 RVA: 0x00CAA4B8 File Offset: 0x00CA86B8
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

		// Token: 0x060357F7 RID: 219127 RVA: 0x00CAA534 File Offset: 0x00CA8734
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

		// Token: 0x060357F8 RID: 219128 RVA: 0x00CAA5B4 File Offset: 0x00CA87B4
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

		// Token: 0x060357F9 RID: 219129 RVA: 0x00CAA710 File Offset: 0x00CA8910
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

		// Token: 0x060357FA RID: 219130 RVA: 0x00CAA7F0 File Offset: 0x00CA89F0
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

		// Token: 0x060357FB RID: 219131 RVA: 0x00CAA8AC File Offset: 0x00CA8AAC
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

		// Token: 0x060357FC RID: 219132 RVA: 0x00CAA97C File Offset: 0x00CA8B7C
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

		// Token: 0x060357FD RID: 219133 RVA: 0x00CAABA0 File Offset: 0x00CA8DA0
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

		// Token: 0x060357FE RID: 219134 RVA: 0x00CAACFC File Offset: 0x00CA8EFC
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

		// Token: 0x060357FF RID: 219135 RVA: 0x00CAAD84 File Offset: 0x00CA8F84
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

		// Token: 0x06035800 RID: 219136 RVA: 0x00CAAE0B File Offset: 0x00CA900B
		private void OnElementTabSelect(int gridIndex)
		{
			this.SelectElementTabByIndex(gridIndex);
			this.UpdateAllPageCardDataList();
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
			this.RefreshFullTip();
		}

		// Token: 0x06035801 RID: 219137 RVA: 0x00CAAE32 File Offset: 0x00CA9032
		private void RefreshFieldCardEffectUnlock(PhantomBattleCheckCardSkillUnlockResponse info)
		{
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.RefreshFieldCardEffectUnlock(info);
		}

		// Token: 0x06035802 RID: 219138 RVA: 0x00CAAE45 File Offset: 0x00CA9045
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

		// Token: 0x06035803 RID: 219139 RVA: 0x00CAAE60 File Offset: 0x00CA9060
		private DeckBuilderElementTabItem CreateElementTabItem()
		{
			return new DeckBuilderElementTabItem
			{
				OnToggleSelect = new Action<int>(this.OnElementTabSelect)
			};
		}

		// Token: 0x06035804 RID: 219140 RVA: 0x00CAAE79 File Offset: 0x00CA9079
		private DeckBuilderCardItem CreateCardItem()
		{
			return new DeckBuilderCardItem
			{
				IsNewPhantomArenaActivity = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId)
			};
		}

		// Token: 0x06035805 RID: 219141 RVA: 0x00CAAE98 File Offset: 0x00CA9098
		private void OnNormalSlotItemClick(DeckBuilderCardSlotItem item)
		{
			DeckCardSlotInfo data = item.GetData();
			if (data == null)
			{
				return;
			}
			this.RemoveCardSlotByCardId(data.CardId, 1);
		}

		// Token: 0x06035806 RID: 219142 RVA: 0x00CAAEC0 File Offset: 0x00CA90C0
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

		// Token: 0x06035807 RID: 219143 RVA: 0x00CAAF50 File Offset: 0x00CA9150
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

		// Token: 0x06035808 RID: 219144 RVA: 0x00CAAFB4 File Offset: 0x00CA91B4
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

		// Token: 0x06035809 RID: 219145 RVA: 0x00CAB067 File Offset: 0x00CA9267
		private void OnSlotItemLongPressEnd()
		{
			UUIItem item = base.GetItem(17);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603580A RID: 219146 RVA: 0x00CAB07C File Offset: 0x00CA927C
		private bool CanNormalSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x0603580B RID: 219147 RVA: 0x00CAB07F File Offset: 0x00CA927F
		private bool CanFieldSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x0603580C RID: 219148 RVA: 0x00CAB084 File Offset: 0x00CA9284
		private void OnCoreSlotItemClick(DeckBuilderCardSlotItem item)
		{
			DeckCardSlotInfo data = item.GetData();
			if (data == null)
			{
				return;
			}
			this.RemoveCardSlotByCardId(data.CardId, 1);
		}

		// Token: 0x0603580D RID: 219149 RVA: 0x00CAB0A9 File Offset: 0x00CA92A9
		private bool CanCoreSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x0603580E RID: 219150 RVA: 0x00CAB0AC File Offset: 0x00CA92AC
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

		// Token: 0x0603580F RID: 219151 RVA: 0x00CAB100 File Offset: 0x00CA9300
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

		// Token: 0x06035810 RID: 219152 RVA: 0x00CAB154 File Offset: 0x00CA9354
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

		// Token: 0x06035811 RID: 219153 RVA: 0x00CAB1CC File Offset: 0x00CA93CC
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

		// Token: 0x06035812 RID: 219154 RVA: 0x00CAB1FA File Offset: 0x00CA93FA
		private void OnCostFilterResult(int configId, bool _)
		{
			this.CurCostFilter = configId;
			this.UpdateAllPageCardDataList();
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
		}

		// Token: 0x06035813 RID: 219155 RVA: 0x00CAB21B File Offset: 0x00CA941B
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

		// Token: 0x06035814 RID: 219156 RVA: 0x00CAB250 File Offset: 0x00CA9450
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

		// Token: 0x06035815 RID: 219157 RVA: 0x00CAB308 File Offset: 0x00CA9508
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

		// Token: 0x06035816 RID: 219158 RVA: 0x00CAB3DC File Offset: 0x00CA95DC
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

		// Token: 0x06035817 RID: 219159 RVA: 0x00CAB428 File Offset: 0x00CA9628
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

		// Token: 0x06035818 RID: 219160 RVA: 0x00CAB487 File Offset: 0x00CA9687
		private void OnGamepadTriggerCardInfo(UUIItem uiItem)
		{
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.GamepadTriggerDeckBuilderCardInfoView(uiItem);
		}

		// Token: 0x06035819 RID: 219161 RVA: 0x00CAB49A File Offset: 0x00CA969A
		private void OnSaveBtnClick()
		{
			if (this.DeckInfo == null)
			{
				return;
			}
			this.SaveDeckInternal();
		}

		// Token: 0x0603581A RID: 219162 RVA: 0x00CAB4AC File Offset: 0x00CA96AC
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

		// Token: 0x0603581B RID: 219163 RVA: 0x00CAB544 File Offset: 0x00CA9744
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

		// Token: 0x0603581C RID: 219164 RVA: 0x00CAB5E9 File Offset: 0x00CA97E9
		private void SetMainViewOverrideCloseFunc()
		{
			if (this.ViewModel != null)
			{
				this.ViewModel.SetOverrideCloseFunc(new Action(this.OnCloseBtnClick));
			}
		}

		// Token: 0x0603581D RID: 219165 RVA: 0x00CAB60A File Offset: 0x00CA980A
		private void ResetMainViewOverrideCloseFunc()
		{
			if (this.ViewModel != null)
			{
				this.ViewModel.ResetOverrideCloseFunc();
			}
		}

		// Token: 0x0603581E RID: 219166 RVA: 0x00CAB620 File Offset: 0x00CA9820
		private void OnChangeNameBtnClick()
		{
			string text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("PhantomBattle_1077", null), Array.Empty<string>());
			CommonInputViewController instance = CommonInputViewController.Instance;
			string bottomText = text;
			Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack = new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.<OnChangeNameBtnClick>g__inputCallBack|84_0);
			DeckInfo deckInfo = this.DeckInfo;
			instance.OpenSetPhantomArenaDeckName(bottomText, callBack, ((deckInfo != null) ? deckInfo.GetName() : null) ?? "");
		}

		// Token: 0x0603581F RID: 219167 RVA: 0x00CAB675 File Offset: 0x00CA9875
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

		// Token: 0x06035820 RID: 219168 RVA: 0x00CAB6A5 File Offset: 0x00CA98A5
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

		// Token: 0x06035821 RID: 219169 RVA: 0x00CAB6E0 File Offset: 0x00CA98E0
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

		// Token: 0x06035822 RID: 219170 RVA: 0x00CAB724 File Offset: 0x00CA9924
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

		// Token: 0x06035823 RID: 219171 RVA: 0x00CAB83C File Offset: 0x00CA9A3C
		protected override void OnBeforeDestroy()
		{
			IPhantomArenaDeckBuilderTabViewModel viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.EndEditDeck();
		}

		// Token: 0x06035824 RID: 219172 RVA: 0x00CAB850 File Offset: 0x00CA9A50
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

		// Token: 0x0603582A RID: 219178 RVA: 0x00CABA20 File Offset: 0x00CA9C20
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

		// Token: 0x0401C694 RID: 116372
		protected Dictionary<int, DeckBuilderCardItemData> LibraryCardDataMap = new Dictionary<int, DeckBuilderCardItemData>();

		// Token: 0x0401C695 RID: 116373
		protected List<DeckBuilderCardItemData> LibraryCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x0401C696 RID: 116374
		protected List<DeckBuilderCardItemData> AllPageCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x0401C697 RID: 116375
		protected List<DeckBuilderCardItemData> CurPageCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x0401C698 RID: 116376
		protected int CurSelectedCardIndex = -1;

		// Token: 0x0401C699 RID: 116377
		protected int CurPage;

		// Token: 0x0401C69A RID: 116378
		protected int MinPage;

		// Token: 0x0401C69B RID: 116379
		protected int MaxPage;

		// Token: 0x0401C69C RID: 116380
		protected readonly int MaxCardCountPerPage = 8;

		// Token: 0x0401C69D RID: 116381
		protected List<ICardTabItemData> TabDataList = new List<ICardTabItemData>();

		// Token: 0x0401C69E RID: 116382
		protected int CurSelectedElementTabIndex = -1;

		// Token: 0x0401C69F RID: 116383
		protected int CurCostFilter = 1;

		// Token: 0x0401C6A0 RID: 116384
		protected bool IncludeLockedCard;

		// Token: 0x0401C6A1 RID: 116385
		protected int CurSlotSortType = 1;

		// Token: 0x0401C6A2 RID: 116386
		protected bool IsAscending = true;

		// Token: 0x0401C6A3 RID: 116387
		protected DeckInfo DeckInfo;

		// Token: 0x0401C6A4 RID: 116388
		private LoopScrollView<DeckBuilderElementTabItem, ICardTabItemData> ElementTabScrollView;

		// Token: 0x0401C6A5 RID: 116389
		protected GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> CardLayout;

		// Token: 0x0401C6A6 RID: 116390
		protected PhantomArenaMainViewSwitchItem ShowLockedSwitchItem;

		// Token: 0x0401C6A7 RID: 116391
		protected DeckBuilderSortFilterEntrance SlotSortEntrance;

		// Token: 0x0401C6A8 RID: 116392
		protected DeckBuilderSortFilterEntrance CardFilterEntrance;

		// Token: 0x0401C6A9 RID: 116393
		protected DeckBuilderDeckSlotsPanel DeckSlotsPanel;

		// Token: 0x0401C6AA RID: 116394
		private DeckBuilderCardDetailTip CardDetailTip;

		// Token: 0x0200B317 RID: 45847
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x0403646F RID: 222319
			public const int ElementTabLoopScrollView = 0;

			// Token: 0x04036470 RID: 222320
			public const int ElementTabItem = 1;

			// Token: 0x04036471 RID: 222321
			public const int CardLayout = 2;

			// Token: 0x04036472 RID: 222322
			public const int CardItem = 3;

			// Token: 0x04036473 RID: 222323
			public const int FilterItem = 4;

			// Token: 0x04036474 RID: 222324
			public const int CardEmptyItem = 5;

			// Token: 0x04036475 RID: 222325
			public const int PageText = 6;

			// Token: 0x04036476 RID: 222326
			public const int PrePageBtn = 7;

			// Token: 0x04036477 RID: 222327
			public const int NextPageBtn = 8;

			// Token: 0x04036478 RID: 222328
			public const int SortItem = 9;

			// Token: 0x04036479 RID: 222329
			public const int QuicklyBuildBtn = 10;

			// Token: 0x0403647A RID: 222330
			public const int SaveBtn = 11;

			// Token: 0x0403647B RID: 222331
			public const int DeckSlotsPanelItem = 12;

			// Token: 0x0403647C RID: 222332
			public const int RenameBtn = 13;

			// Token: 0x0403647D RID: 222333
			public const int DeleteBtn = 14;

			// Token: 0x0403647E RID: 222334
			public const int TextFullTip = 15;

			// Token: 0x0403647F RID: 222335
			public const int ItemFullTip = 16;

			// Token: 0x04036480 RID: 222336
			public const int LongPressItem = 17;

			// Token: 0x04036481 RID: 222337
			public const int SpriteLongPressBar = 18;

			// Token: 0x04036482 RID: 222338
			public const int ItemDetailTipPanel = 19;
		}
	}
}
