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
	// Token: 0x020051AB RID: 20907
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaNewDeckBuilderTabView : PhantomArenaChildViewBase
	{
		// Token: 0x170081A7 RID: 33191
		// (get) Token: 0x06035847 RID: 219207 RVA: 0x00CAC8D6 File Offset: 0x00CAAAD6
		// (set) Token: 0x06035848 RID: 219208 RVA: 0x00CAC8E3 File Offset: 0x00CAAAE3
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

		// Token: 0x06035849 RID: 219209 RVA: 0x00CAC8EC File Offset: 0x00CAAAEC
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
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIText)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUISprite)),
				new ValueTuple<int, Type>(18, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnPrePageBtnClick)),
				new ValueTuple<int, Delegate>(8, new Action(this.OnNextPageBtnClick)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnQuicklyBuildBtnClick)),
				new ValueTuple<int, Delegate>(10, new Action(this.OnSaveBtnClick)),
				new ValueTuple<int, Delegate>(12, new Action(this.OnChangeNameBtnClick)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnDeckDeleteBtnClick))
			};
		}

		// Token: 0x0603584A RID: 219210 RVA: 0x00CACB50 File Offset: 0x00CAAD50
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaNewDeckBuilderTabView.<OnBeforeStartAsync>d__27 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaNewDeckBuilderTabView.<OnBeforeStartAsync>d__27>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603584B RID: 219211 RVA: 0x00CACB94 File Offset: 0x00CAAD94
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
			EventSystem.Instance.Add(EEventName.GamepadTriggerCardInfo, new Action<UUIItem>(this.OnGamepadTriggerCardInfo));
		}

		// Token: 0x0603584C RID: 219212 RVA: 0x00CACBF8 File Offset: 0x00CAADF8
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
			EventSystem.Instance.Remove(EEventName.GamepadTriggerCardInfo, new Action<UUIItem>(this.OnGamepadTriggerCardInfo));
		}

		// Token: 0x0603584D RID: 219213 RVA: 0x00CACC5C File Offset: 0x00CAAE5C
		protected override UniTask OnBeforeShowAsyncImplement()
		{
			PhantomArenaNewDeckBuilderTabView.<OnBeforeShowAsyncImplement>d__30 <OnBeforeShowAsyncImplement>d__;
			<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<PhantomArenaNewDeckBuilderTabView.<OnBeforeShowAsyncImplement>d__30>(ref <OnBeforeShowAsyncImplement>d__);
			return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603584E RID: 219214 RVA: 0x00CACCA0 File Offset: 0x00CAAEA0
		protected override UniTask OnPlayingShowSequenceAsync()
		{
			PhantomArenaNewDeckBuilderTabView.<OnPlayingShowSequenceAsync>d__31 <OnPlayingShowSequenceAsync>d__;
			<OnPlayingShowSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingShowSequenceAsync>d__.<>4__this = this;
			<OnPlayingShowSequenceAsync>d__.<>1__state = -1;
			<OnPlayingShowSequenceAsync>d__.<>t__builder.Start<PhantomArenaNewDeckBuilderTabView.<OnPlayingShowSequenceAsync>d__31>(ref <OnPlayingShowSequenceAsync>d__);
			return <OnPlayingShowSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603584F RID: 219215 RVA: 0x00CACCE4 File Offset: 0x00CAAEE4
		protected override UniTask OnPlayingStartSequenceAsync()
		{
			PhantomArenaNewDeckBuilderTabView.<OnPlayingStartSequenceAsync>d__32 <OnPlayingStartSequenceAsync>d__;
			<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnPlayingStartSequenceAsync>d__.<>4__this = this;
			<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
			<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<PhantomArenaNewDeckBuilderTabView.<OnPlayingStartSequenceAsync>d__32>(ref <OnPlayingStartSequenceAsync>d__);
			return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035850 RID: 219216 RVA: 0x00CACD27 File Offset: 0x00CAAF27
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

		// Token: 0x06035851 RID: 219217 RVA: 0x00CACD54 File Offset: 0x00CAAF54
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

		// Token: 0x06035852 RID: 219218 RVA: 0x00CACDE8 File Offset: 0x00CAAFE8
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

		// Token: 0x06035853 RID: 219219 RVA: 0x00CACEA4 File Offset: 0x00CAB0A4
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
						Attack = dictionary.GetValueOrDefault(0, 0),
						Life = dictionary.GetValueOrDefault(1, 0),
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

		// Token: 0x06035854 RID: 219220 RVA: 0x00CAD098 File Offset: 0x00CAB298
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

		// Token: 0x06035855 RID: 219221 RVA: 0x00CAD138 File Offset: 0x00CAB338
		private void UpdateCurPageCardDataList()
		{
			int num = (this.CurPage - 1) * this.MaxCardCountPerPage;
			int num2 = this.CurPage * this.MaxCardCountPerPage;
			this.CurPageCardDataList = this.AllPageCardDataList.Skip(num).Take(num2 - num).ToList<DeckBuilderCardItemData>();
		}

		// Token: 0x06035856 RID: 219222 RVA: 0x00CAD184 File Offset: 0x00CAB384
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

		// Token: 0x06035857 RID: 219223 RVA: 0x00CAD1DC File Offset: 0x00CAB3DC
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

		// Token: 0x06035858 RID: 219224 RVA: 0x00CAD224 File Offset: 0x00CAB424
		private UniTask RefreshCardLayoutAsync(bool playGridAnim)
		{
			PhantomArenaNewDeckBuilderTabView.<RefreshCardLayoutAsync>d__41 <RefreshCardLayoutAsync>d__;
			<RefreshCardLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCardLayoutAsync>d__.<>4__this = this;
			<RefreshCardLayoutAsync>d__.playGridAnim = playGridAnim;
			<RefreshCardLayoutAsync>d__.<>1__state = -1;
			<RefreshCardLayoutAsync>d__.<>t__builder.Start<PhantomArenaNewDeckBuilderTabView.<RefreshCardLayoutAsync>d__41>(ref <RefreshCardLayoutAsync>d__);
			return <RefreshCardLayoutAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035859 RID: 219225 RVA: 0x00CAD270 File Offset: 0x00CAB470
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

		// Token: 0x0603585A RID: 219226 RVA: 0x00CAD304 File Offset: 0x00CAB504
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

		// Token: 0x0603585B RID: 219227 RVA: 0x00CAD380 File Offset: 0x00CAB580
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

		// Token: 0x0603585C RID: 219228 RVA: 0x00CAD400 File Offset: 0x00CAB600
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
				OnFieldCardItemEffectBtnClick = new Action<DeckBuilderCardSlotItem>(this.OnFieldCardItemEffectBtnClick),
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
				IsNeedFieldCard = true,
				IsNeedRequestCheckCardSkillUnlock = needRequestCheckCardSkillUnlock
			};
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.RefreshByData(data);
		}

		// Token: 0x0603585D RID: 219229 RVA: 0x00CAD570 File Offset: 0x00CAB770
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

		// Token: 0x0603585E RID: 219230 RVA: 0x00CAD650 File Offset: 0x00CAB850
		public void RefreshFullTip()
		{
			ECardTabType tabType = this.TabDataList[this.CurSelectedElementTabIndex].TabType;
			ECardElement element;
			PhantomArenaDefine.cardTabTypeToElementConfigId.TryGetValue(tabType, out element);
			bool flag = this.DeckInfo.IsDeckFull();
			bool flag2 = !this.DeckInfo.CheckCanAddElement(element);
			UUIItem item = base.GetItem(15);
			if (item != null)
			{
				item.SetUIActive(flag || flag2);
			}
			string textStringId = flag2 ? "PrefabTextItem_3954833905_Text" : "PrefabTextItem_3799404500_Text";
			LguiUtil.Instance.SetLocalTextNew(base.GetText(14), textStringId, Array.Empty<object>());
		}

		// Token: 0x0603585F RID: 219231 RVA: 0x00CAD6E0 File Offset: 0x00CAB8E0
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
				NeedOutlookTab = false
			};
			UiManager.Instance.OpenView(EUiViewName.DeckBuilderCardInfoView, param, null);
		}

		// Token: 0x06035860 RID: 219232 RVA: 0x00CAD7B0 File Offset: 0x00CAB9B0
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
				else if (deckBuilderCardItemData2.CardType == ECardType.Field)
				{
					DeckBuilderDeckSlotsPanel deckSlotsPanel3 = this.DeckSlotsPanel;
					if (deckSlotsPanel3 != null)
					{
						deckSlotsPanel3.RefreshFieldCardSlot(needPlayAddAnimCard);
					}
				}
				else
				{
					DeckBuilderDeckSlotsPanel deckSlotsPanel4 = this.DeckSlotsPanel;
					if (deckSlotsPanel4 != null)
					{
						deckSlotsPanel4.RefreshNormalCardSlot(needPlayAddAnimCard, true, deckBuilderCardItemData.CardId);
					}
					DeckBuilderDeckSlotsPanel deckSlotsPanel5 = this.DeckSlotsPanel;
					if (deckSlotsPanel5 != null)
					{
						deckSlotsPanel5.SwitchMaskState(EPhantomArenaDeckSlotType.Normal);
					}
				}
				DeckBuilderDeckSlotsPanel deckSlotsPanel6 = this.DeckSlotsPanel;
				if (deckSlotsPanel6 != null)
				{
					deckSlotsPanel6.RefreshCardSlotElements();
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

		// Token: 0x06035861 RID: 219233 RVA: 0x00CAD9F0 File Offset: 0x00CABBF0
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

		// Token: 0x06035862 RID: 219234 RVA: 0x00CADB4C File Offset: 0x00CABD4C
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

		// Token: 0x06035863 RID: 219235 RVA: 0x00CADBD4 File Offset: 0x00CABDD4
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

		// Token: 0x06035864 RID: 219236 RVA: 0x00CADC5B File Offset: 0x00CABE5B
		private void OnElementTabSelect(int gridIndex)
		{
			this.SelectElementTabByIndex(gridIndex);
			this.UpdateAllPageCardDataList();
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
			this.RefreshFullTip();
		}

		// Token: 0x06035865 RID: 219237 RVA: 0x00CADC82 File Offset: 0x00CABE82
		private void RefreshFieldCardEffectUnlock(PhantomBattleCheckCardSkillUnlockResponse info)
		{
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.RefreshFieldCardEffectUnlock(info);
		}

		// Token: 0x06035866 RID: 219238 RVA: 0x00CADC95 File Offset: 0x00CABE95
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

		// Token: 0x06035867 RID: 219239 RVA: 0x00CADCB0 File Offset: 0x00CABEB0
		private DeckBuilderElementTabItem CreateElementTabItem()
		{
			return new DeckBuilderElementTabItem
			{
				OnToggleSelect = new Action<int>(this.OnElementTabSelect)
			};
		}

		// Token: 0x06035868 RID: 219240 RVA: 0x00CADCC9 File Offset: 0x00CABEC9
		private DeckBuilderCardItem CreateCardItem()
		{
			return new DeckBuilderCardItem
			{
				IsNewPhantomArenaActivity = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(base.ActivityId)
			};
		}

		// Token: 0x06035869 RID: 219241 RVA: 0x00CADCE8 File Offset: 0x00CABEE8
		private void OnNormalSlotItemClick(DeckBuilderCardSlotItem item)
		{
			DeckCardSlotInfo data = item.GetData();
			if (data == null)
			{
				return;
			}
			this.RemoveCardSlotByCardId(data.CardId, 1);
		}

		// Token: 0x0603586A RID: 219242 RVA: 0x00CADD10 File Offset: 0x00CABF10
		private void OnFieldCardItemEffectBtnClick(DeckBuilderCardSlotItem item)
		{
			DeckCardSlotInfo data = item.GetData();
			if (data == null)
			{
				return;
			}
			PhantomArenaController.Instance.OpenDeckBuilderCardInfoViewWithoutOutlookTab(data.CardId);
		}

		// Token: 0x0603586B RID: 219243 RVA: 0x00CADD38 File Offset: 0x00CABF38
		private bool CanNormalSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x0603586C RID: 219244 RVA: 0x00CADD3B File Offset: 0x00CABF3B
		private bool CanFieldSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x0603586D RID: 219245 RVA: 0x00CADD40 File Offset: 0x00CABF40
		private void OnCoreSlotItemClick(DeckBuilderCardSlotItem item)
		{
			DeckCardSlotInfo data = item.GetData();
			if (data == null)
			{
				return;
			}
			this.RemoveCardSlotByCardId(data.CardId, 1);
		}

		// Token: 0x0603586E RID: 219246 RVA: 0x00CADD68 File Offset: 0x00CABF68
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
				NeedOutlookTab = false
			};
			UiManager.Instance.OpenView(EUiViewName.DeckBuilderCardInfoView, param, null);
		}

		// Token: 0x0603586F RID: 219247 RVA: 0x00CADDF8 File Offset: 0x00CABFF8
		private void OnSlotItemLongPress(DeckBuilderCardSlotItem item, float progress)
		{
			if (progress == -1f)
			{
				this.OnSlotItemLongPressComplete(item);
				return;
			}
			UUIItem item2 = base.GetItem(16);
			if (item2 != null && !item2.bIsUIActive)
			{
				this.RefreshLongPressItemPosition();
				item2.SetUIActive(true);
			}
			UUISprite sprite = base.GetSprite(17);
			if (sprite != null)
			{
				sprite.SetFillAmount(progress);
			}
			if (progress >= 1f)
			{
				this.OnSlotItemLongPressComplete(item);
			}
		}

		// Token: 0x06035870 RID: 219248 RVA: 0x00CADE5C File Offset: 0x00CAC05C
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
			UUIItem item = base.GetItem(16);
			if (item == null)
			{
				return;
			}
			FVector fvector = new FVector(inX, inY, 0f);
			item.SetLGUISpaceAbsolutePosition(fvector);
		}

		// Token: 0x06035871 RID: 219249 RVA: 0x00CADF0F File Offset: 0x00CAC10F
		private void OnSlotItemLongPressEnd()
		{
			UUIItem item = base.GetItem(16);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x06035872 RID: 219250 RVA: 0x00CADF24 File Offset: 0x00CAC124
		private bool CanCoreSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return false;
		}

		// Token: 0x06035873 RID: 219251 RVA: 0x00CADF28 File Offset: 0x00CAC128
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

		// Token: 0x06035874 RID: 219252 RVA: 0x00CADF7C File Offset: 0x00CAC17C
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

		// Token: 0x06035875 RID: 219253 RVA: 0x00CADFD0 File Offset: 0x00CAC1D0
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

		// Token: 0x06035876 RID: 219254 RVA: 0x00CAE048 File Offset: 0x00CAC248
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

		// Token: 0x06035877 RID: 219255 RVA: 0x00CAE076 File Offset: 0x00CAC276
		private void OnCostFilterResult(int configId, bool _)
		{
			this.CurCostFilter = configId;
			this.UpdateAllPageCardDataList();
			this.UpdateCurPageCardDataList();
			this.RefreshPageText();
			this.RefreshCardLayout();
		}

		// Token: 0x06035878 RID: 219256 RVA: 0x00CAE098 File Offset: 0x00CAC298
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

		// Token: 0x06035879 RID: 219257 RVA: 0x00CAE150 File Offset: 0x00CAC350
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

		// Token: 0x0603587A RID: 219258 RVA: 0x00CAE19C File Offset: 0x00CAC39C
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

		// Token: 0x0603587B RID: 219259 RVA: 0x00CAE1FB File Offset: 0x00CAC3FB
		private void OnGamepadTriggerCardInfo(UUIItem uiItem)
		{
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.GamepadTriggerDeckBuilderCardInfoView(uiItem);
		}

		// Token: 0x0603587C RID: 219260 RVA: 0x00CAE20E File Offset: 0x00CAC40E
		private void OnSaveBtnClick()
		{
			if (this.DeckInfo == null)
			{
				return;
			}
			this.SaveDeckInternal();
		}

		// Token: 0x0603587D RID: 219261 RVA: 0x00CAE220 File Offset: 0x00CAC420
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

		// Token: 0x0603587E RID: 219262 RVA: 0x00CAE2B8 File Offset: 0x00CAC4B8
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

		// Token: 0x0603587F RID: 219263 RVA: 0x00CAE35D File Offset: 0x00CAC55D
		private void SetMainViewOverrideCloseFunc()
		{
			if (this.ViewModel != null)
			{
				this.ViewModel.SetOverrideCloseFunc(new Action(this.OnCloseBtnClick));
			}
		}

		// Token: 0x06035880 RID: 219264 RVA: 0x00CAE37E File Offset: 0x00CAC57E
		private void ResetMainViewOverrideCloseFunc()
		{
			if (this.ViewModel != null)
			{
				this.ViewModel.ResetOverrideCloseFunc();
			}
		}

		// Token: 0x06035881 RID: 219265 RVA: 0x00CAE394 File Offset: 0x00CAC594
		private void OnChangeNameBtnClick()
		{
			string text = StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("PhantomBattle_1077", null), Array.Empty<string>());
			CommonInputViewController instance = CommonInputViewController.Instance;
			string bottomText = text;
			Func<string, UniTask<Aki.Protocol.ErrorCode>> callBack = new Func<string, UniTask<Aki.Protocol.ErrorCode>>(this.<OnChangeNameBtnClick>g__inputCallBack|82_0);
			DeckInfo deckInfo = this.DeckInfo;
			instance.OpenSetPhantomArenaDeckName(bottomText, callBack, ((deckInfo != null) ? deckInfo.GetName() : null) ?? "");
		}

		// Token: 0x06035882 RID: 219266 RVA: 0x00CAE3E9 File Offset: 0x00CAC5E9
		private void OnSlotCardPointEnterCallback(int cardId)
		{
			if (this.CardDetailTip == null)
			{
				return;
			}
			this.CardDetailTip.IsMouseInSlotItem = true;
			this.CardDetailTip.RefreshCard(cardId, this.DeckInfo);
			this.CardDetailTip.SetUiActive(true);
		}

		// Token: 0x06035883 RID: 219267 RVA: 0x00CAE41E File Offset: 0x00CAC61E
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

		// Token: 0x06035884 RID: 219268 RVA: 0x00CAE45C File Offset: 0x00CAC65C
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

		// Token: 0x06035885 RID: 219269 RVA: 0x00CAE4A0 File Offset: 0x00CAC6A0
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

		// Token: 0x06035886 RID: 219270 RVA: 0x00CAE5B8 File Offset: 0x00CAC7B8
		protected override void OnBeforeDestroy()
		{
			IPhantomArenaDeckBuilderTabViewModel viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.EndEditDeck();
		}

		// Token: 0x06035887 RID: 219271 RVA: 0x00CAE5CC File Offset: 0x00CAC7CC
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

		// Token: 0x0603588C RID: 219276 RVA: 0x00CAE78C File Offset: 0x00CAC98C
		[NullableContext(0)]
		[CompilerGenerated]
		private UniTask<Aki.Protocol.ErrorCode> <OnChangeNameBtnClick>g__inputCallBack|82_0([Nullable(1)] string input)
		{
			PhantomArenaNewDeckBuilderTabView.<<OnChangeNameBtnClick>g__inputCallBack|82_0>d <<OnChangeNameBtnClick>g__inputCallBack|82_0>d;
			<<OnChangeNameBtnClick>g__inputCallBack|82_0>d.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
			<<OnChangeNameBtnClick>g__inputCallBack|82_0>d.<>4__this = this;
			<<OnChangeNameBtnClick>g__inputCallBack|82_0>d.input = input;
			<<OnChangeNameBtnClick>g__inputCallBack|82_0>d.<>1__state = -1;
			<<OnChangeNameBtnClick>g__inputCallBack|82_0>d.<>t__builder.Start<PhantomArenaNewDeckBuilderTabView.<<OnChangeNameBtnClick>g__inputCallBack|82_0>d>(ref <<OnChangeNameBtnClick>g__inputCallBack|82_0>d);
			return <<OnChangeNameBtnClick>g__inputCallBack|82_0>d.<>t__builder.Task;
		}

		// Token: 0x0401C6B0 RID: 116400
		protected Dictionary<int, DeckBuilderCardItemData> LibraryCardDataMap = new Dictionary<int, DeckBuilderCardItemData>();

		// Token: 0x0401C6B1 RID: 116401
		protected List<DeckBuilderCardItemData> LibraryCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x0401C6B2 RID: 116402
		protected List<DeckBuilderCardItemData> AllPageCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x0401C6B3 RID: 116403
		protected List<DeckBuilderCardItemData> CurPageCardDataList = new List<DeckBuilderCardItemData>();

		// Token: 0x0401C6B4 RID: 116404
		protected int CurSelectedCardIndex = -1;

		// Token: 0x0401C6B5 RID: 116405
		protected int CurPage;

		// Token: 0x0401C6B6 RID: 116406
		protected int MinPage;

		// Token: 0x0401C6B7 RID: 116407
		protected int MaxPage;

		// Token: 0x0401C6B8 RID: 116408
		protected readonly int MaxCardCountPerPage = 8;

		// Token: 0x0401C6B9 RID: 116409
		protected List<ICardTabItemData> TabDataList = new List<ICardTabItemData>();

		// Token: 0x0401C6BA RID: 116410
		protected int CurSelectedElementTabIndex = -1;

		// Token: 0x0401C6BB RID: 116411
		protected int CurCostFilter = 1;

		// Token: 0x0401C6BC RID: 116412
		protected bool IncludeLockedCard;

		// Token: 0x0401C6BD RID: 116413
		protected int CurSlotSortType = 1;

		// Token: 0x0401C6BE RID: 116414
		protected bool IsAscending = true;

		// Token: 0x0401C6BF RID: 116415
		protected DeckInfo DeckInfo;

		// Token: 0x0401C6C0 RID: 116416
		private LoopScrollView<DeckBuilderElementTabItem, ICardTabItemData> ElementTabScrollView;

		// Token: 0x0401C6C1 RID: 116417
		protected GenericLayout<DeckBuilderCardItem, DeckBuilderCardItemData> CardLayout;

		// Token: 0x0401C6C2 RID: 116418
		protected PhantomArenaMainViewSwitchItem ShowLockedSwitchItem;

		// Token: 0x0401C6C3 RID: 116419
		protected DeckBuilderSortFilterEntrance CardFilterEntrance;

		// Token: 0x0401C6C4 RID: 116420
		protected DeckBuilderDeckSlotsPanel DeckSlotsPanel;

		// Token: 0x0401C6C5 RID: 116421
		private DeckBuilderCardDetailTip CardDetailTip;

		// Token: 0x0200B328 RID: 45864
		[NullableContext(0)]
		private static class EComponent
		{
			// Token: 0x040364C7 RID: 222407
			public const int ElementTabLoopScrollView = 0;

			// Token: 0x040364C8 RID: 222408
			public const int ElementTabItem = 1;

			// Token: 0x040364C9 RID: 222409
			public const int CardLayout = 2;

			// Token: 0x040364CA RID: 222410
			public const int CardItem = 3;

			// Token: 0x040364CB RID: 222411
			public const int FilterItem = 4;

			// Token: 0x040364CC RID: 222412
			public const int CardEmptyItem = 5;

			// Token: 0x040364CD RID: 222413
			public const int PageText = 6;

			// Token: 0x040364CE RID: 222414
			public const int PrePageBtn = 7;

			// Token: 0x040364CF RID: 222415
			public const int NextPageBtn = 8;

			// Token: 0x040364D0 RID: 222416
			public const int QuicklyBuildBtn = 9;

			// Token: 0x040364D1 RID: 222417
			public const int SaveBtn = 10;

			// Token: 0x040364D2 RID: 222418
			public const int DeckSlotsPanelItem = 11;

			// Token: 0x040364D3 RID: 222419
			public const int RenameBtn = 12;

			// Token: 0x040364D4 RID: 222420
			public const int DeleteBtn = 13;

			// Token: 0x040364D5 RID: 222421
			public const int TextFullTip = 14;

			// Token: 0x040364D6 RID: 222422
			public const int ItemFullTip = 15;

			// Token: 0x040364D7 RID: 222423
			public const int LongPressItem = 16;

			// Token: 0x040364D8 RID: 222424
			public const int SpriteLongPressBar = 17;

			// Token: 0x040364D9 RID: 222425
			public const int ItemDetailTipPanel = 18;
		}
	}
}
