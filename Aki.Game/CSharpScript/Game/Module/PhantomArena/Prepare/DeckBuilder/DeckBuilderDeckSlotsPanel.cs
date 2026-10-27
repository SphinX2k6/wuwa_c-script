using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200519A RID: 20890
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderDeckSlotsPanel : UiPanelBase
	{
		// Token: 0x06035709 RID: 218889 RVA: 0x00CA6AA8 File Offset: 0x00CA4CA8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(3, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(10, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(8, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(16, typeof(UUIItem))
			};
		}

		// Token: 0x0603570A RID: 218890 RVA: 0x00CA6C40 File Offset: 0x00CA4E40
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderDeckSlotsPanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderDeckSlotsPanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603570B RID: 218891 RVA: 0x00CA6C84 File Offset: 0x00CA4E84
		public void RefreshByData(IDeckBuilderDeckSlotsPanelData data)
		{
			this.Data = data;
			if (this.FieldCardItem != null)
			{
				this.FieldCardItem.OnEffectBtnClickCallback = this.Data.OnFieldCardItemEffectBtnClick;
				DeckBuilderCardSlotItem fieldSlotItem = this.FieldCardItem.FieldSlotItem;
				IDeckBuilderDeckSlotsPanelData data2 = this.Data;
				fieldSlotItem.LongPressStartTime = ((data2 != null) ? data2.SlotLongPressStartTime : null).GetValueOrDefault();
				DeckBuilderCardSlotItem fieldSlotItem2 = this.FieldCardItem.FieldSlotItem;
				IDeckBuilderDeckSlotsPanelData data3 = this.Data;
				fieldSlotItem2.LongPressEndTime = ((data3 != null) ? data3.SlotLongPressEndTime : null).GetValueOrDefault();
			}
			if (this.CoreSlotItem != null)
			{
				DeckBuilderCardSlotItem coreSlotItem = this.CoreSlotItem;
				IDeckBuilderDeckSlotsPanelData data4 = this.Data;
				coreSlotItem.LongPressStartTime = ((data4 != null) ? data4.SlotLongPressStartTime : null).GetValueOrDefault();
				DeckBuilderCardSlotItem coreSlotItem2 = this.CoreSlotItem;
				IDeckBuilderDeckSlotsPanelData data5 = this.Data;
				coreSlotItem2.LongPressEndTime = ((data5 != null) ? data5.SlotLongPressEndTime : null).GetValueOrDefault();
			}
			if (data.IsNeedRequestCheckCardSkillUnlock)
			{
				PhantomArenaController.Instance.RequestCheckCardSkillUnlock(data.DeckInfo, new Action<PhantomBattleCheckCardSkillUnlockResponse>(this.OnRefreshFieldCardEffectUnlock));
			}
			this.RefreshCardSlot(null, false);
			this.RefreshCardSlotElements();
			this.RefreshNameText();
		}

		// Token: 0x0603570C RID: 218892 RVA: 0x00CA6DBC File Offset: 0x00CA4FBC
		public void RefreshCardSlot(int? needPlayAddAnimCard = null, bool keepContentPosition = false)
		{
			this.RefreshCoreCardSlot(needPlayAddAnimCard);
			this.RefreshFieldCardSlot(needPlayAddAnimCard);
			this.RefreshNormalCardSlot(needPlayAddAnimCard, keepContentPosition, 0);
		}

		// Token: 0x0603570D RID: 218893 RVA: 0x00CA6DD8 File Offset: 0x00CA4FD8
		private IDeckBuilderCardSlotItemData CreateSlotItemData(DeckCardSlotInfo slotInfo)
		{
			int cardId = slotInfo.CardId;
			bool flag = this.Data.ShowLocked && !PhantomArenaModel.Instance.IsCardUnlock(cardId);
			bool redDotState = flag && PhantomArenaModel.Instance.CanCardUnlock(cardId);
			bool outlookUnlocked = this.Data.ShowOutlook && PhantomArenaModel.Instance.IsCardOutlookUnlock(cardId);
			return new DeckBuilderCardSlotItemData
			{
				SlotInfo = slotInfo,
				Locked = flag,
				RedDotState = redDotState,
				OutlookUnlocked = outlookUnlocked,
				NeedPlayAddAnim = false
			};
		}

		// Token: 0x0603570E RID: 218894 RVA: 0x00CA6E64 File Offset: 0x00CA5064
		public void RefreshCoreCardSlot(int? needPlayAddAnimCard = null)
		{
			DeckInfo deckInfo = this.Data.DeckInfo;
			DeckCardSlotInfo coreCardSlot = deckInfo.GetCoreCardSlot();
			bool flag = deckInfo.IsCoreCardSlotLocked();
			bool flag2 = coreCardSlot != null;
			this.CoreSlotItem.SetActive(!flag && flag2);
			base.GetItem(5).SetUIActive(!flag && !flag2);
			base.GetItem(6).SetUIActive(flag);
			int value = (coreCardSlot != null) ? coreCardSlot.Count : 0;
			int coreCardCountLimit = deckInfo.GetCoreCardCountLimit();
			UUIText text = base.GetText(3);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(coreCardCountLimit);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			if (coreCardSlot != null)
			{
				this.CurCoreSlotData = this.CreateSlotItemData(coreCardSlot);
				if (needPlayAddAnimCard != null && needPlayAddAnimCard.Value == this.CurCoreSlotData.SlotInfo.CardId)
				{
					this.CurCoreSlotData.NeedPlayAddAnim = true;
				}
				this.CoreSlotItem.Refresh(this.CurCoreSlotData, false, 0);
			}
		}

		// Token: 0x0603570F RID: 218895 RVA: 0x00CA6F64 File Offset: 0x00CA5164
		public void RefreshFieldCardSlot(int? needPlayAddAnimCard = null)
		{
			if (this.Data.IsNeedFieldCard)
			{
				DeckBuilderFieldCardItem fieldCardItem = this.FieldCardItem;
				if (fieldCardItem != null)
				{
					fieldCardItem.SetUiActive(true);
				}
				DeckInfo deckInfo = this.Data.DeckInfo;
				DeckBuilderFieldCardItem fieldCardItem2 = this.FieldCardItem;
				if (fieldCardItem2 != null)
				{
					fieldCardItem2.RefreshItem(deckInfo, needPlayAddAnimCard);
				}
				DeckCardSlotInfo fieldCardSlot = deckInfo.GetFieldCardSlot();
				if (fieldCardSlot != null)
				{
					IDeckBuilderCardSlotItemData deckBuilderCardSlotItemData = this.CreateSlotItemData(fieldCardSlot);
					if (needPlayAddAnimCard != null && needPlayAddAnimCard.Value == deckBuilderCardSlotItemData.SlotInfo.CardId)
					{
						deckBuilderCardSlotItemData.NeedPlayAddAnim = true;
					}
					DeckBuilderFieldCardItem fieldCardItem3 = this.FieldCardItem;
					if (fieldCardItem3 == null)
					{
						return;
					}
					fieldCardItem3.RefreshSlotItem(deckBuilderCardSlotItemData);
				}
				return;
			}
			DeckBuilderFieldCardItem fieldCardItem4 = this.FieldCardItem;
			if (fieldCardItem4 == null)
			{
				return;
			}
			fieldCardItem4.SetUiActive(false);
		}

		// Token: 0x06035710 RID: 218896 RVA: 0x00CA7008 File Offset: 0x00CA5208
		public void RefreshNormalCardSlot(int? needPlayAddAnimCard = null, bool keepContentPosition = false, int scrollToSlotId = 0)
		{
			DeckInfo deckInfo = this.Data.DeckInfo;
			List<DeckCardSlotInfo> list = deckInfo.GetNormalCardSlotList().ToList<DeckCardSlotInfo>();
			PhantomArenaModel.Instance.SortCardSlotList<DeckCardSlotInfo>(list, this.Data.SortContext);
			this.CurNormalSlotDataList.Clear();
			foreach (DeckCardSlotInfo slotInfo in list)
			{
				IDeckBuilderCardSlotItemData deckBuilderCardSlotItemData = this.CreateSlotItemData(slotInfo);
				deckBuilderCardSlotItemData.NeedPlayAddAnim = (needPlayAddAnimCard != null && needPlayAddAnimCard.Value == deckBuilderCardSlotItemData.SlotInfo.CardId);
				this.CurNormalSlotDataList.Add(deckBuilderCardSlotItemData);
			}
			GenericScrollViewNew<DeckBuilderCardSlotItem, IDeckBuilderCardSlotItemData> normalSlotScrollLayout = this.NormalSlotScrollLayout;
			if (normalSlotScrollLayout != null)
			{
				Predicate<IDeckBuilderCardSlotItemData> <>9__1;
				normalSlotScrollLayout.RefreshByData(this.CurNormalSlotDataList, delegate
				{
					if (scrollToSlotId != 0)
					{
						List<IDeckBuilderCardSlotItemData> curNormalSlotDataList = this.CurNormalSlotDataList;
						Predicate<IDeckBuilderCardSlotItemData> match;
						if ((match = <>9__1) == null)
						{
							match = (<>9__1 = ((IDeckBuilderCardSlotItemData slot) => slot.SlotInfo.CardId == scrollToSlotId));
						}
						int num = curNormalSlotDataList.FindIndex(match);
						if (num < 0)
						{
							return;
						}
						UUIItem itemByIndex = this.NormalSlotScrollLayout.GetItemByIndex(num);
						if (itemByIndex == null)
						{
							return;
						}
						if (this.NormalSlotScrollLayout.IsItemInViewport(itemByIndex, 0.1f) != EOutOfBoundsType.NotOut)
						{
							this.NormalSlotScrollLayout.ScrollTo(itemByIndex, false);
						}
					}
				}, false);
			}
			bool flag = this.CurNormalSlotDataList.Count > 0;
			base.GetVerticalLayout(14).RootUIComp.Get().SetUIActive(flag);
			base.GetItem(12).SetUIActive(!flag);
			int normalCardCount = deckInfo.GetNormalCardCount();
			int normalCardCountLimit = deckInfo.GetNormalCardCountLimit();
			UUIText text = base.GetText(10);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(normalCardCount);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(normalCardCountLimit);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06035711 RID: 218897 RVA: 0x00CA718C File Offset: 0x00CA538C
		private void OnRefreshFieldCardEffectUnlock(PhantomBattleCheckCardSkillUnlockResponse info)
		{
			this.RefreshFieldCardEffectUnlock(info);
		}

		// Token: 0x06035712 RID: 218898 RVA: 0x00CA7198 File Offset: 0x00CA5398
		public void RefreshFieldCardEffectUnlock(PhantomBattleCheckCardSkillUnlockResponse info)
		{
			DeckCardSlotInfo fieldCardSlot = this.Data.DeckInfo.GetFieldCardSlot();
			if (fieldCardSlot == null || this.FieldCardItem == null)
			{
				return;
			}
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(fieldCardSlot.CardId);
			string conditionDesc = (info.CurNum >= info.TargetNum) ? phantomBattleCardConfig.FieldConditionDesc : phantomBattleCardConfig.FieldUnlockConditionDesc;
			CardDetailConditionOutData data = new CardDetailConditionOutData
			{
				CurrentProgress = info.CurNum,
				MaxProgress = info.TargetNum,
				Icon = phantomBattleCardConfig.FieldConditionIcon,
				ConditionDesc = conditionDesc
			};
			DeckBuilderFieldCardItem fieldCardItem = this.FieldCardItem;
			if (fieldCardItem == null)
			{
				return;
			}
			fieldCardItem.RefreshEffectUnlock(data);
		}

		// Token: 0x06035713 RID: 218899 RVA: 0x00CA723A File Offset: 0x00CA543A
		public void RefreshCardSlotElements()
		{
			this.RefreshCoreCardSlotElement();
			this.RefreshNormalCardSlotElement();
		}

		// Token: 0x06035714 RID: 218900 RVA: 0x00CA7248 File Offset: 0x00CA5448
		private void RefreshCoreCardSlotElement()
		{
			DeckCardSlotInfo coreCardSlot = this.Data.DeckInfo.GetCoreCardSlot();
			List<int> list = new List<int>();
			if (coreCardSlot != null)
			{
				list.Add(coreCardSlot.Element);
			}
			GenericLayout<CardElementItem, ECardElement> coreElementLayout = this.CoreElementLayout;
			if (coreElementLayout == null)
			{
				return;
			}
			coreElementLayout.RefreshByData(list.Cast<ECardElement>().ToList<ECardElement>(), null, false);
		}

		// Token: 0x06035715 RID: 218901 RVA: 0x00CA7298 File Offset: 0x00CA5498
		private void RefreshNormalCardSlotElement()
		{
			GenericLayout<CardElementItem, ECardElement> normalElementLayout = this.NormalElementLayout;
			if (normalElementLayout == null)
			{
				return;
			}
			normalElementLayout.RefreshByData(this.Data.DeckInfo.GetElementList(), null, false);
		}

		// Token: 0x06035716 RID: 218902 RVA: 0x00CA72BC File Offset: 0x00CA54BC
		public void RefreshNameText()
		{
			base.GetText(0).SetText(this.Data.DeckInfo.GetDeckName(), true);
		}

		// Token: 0x06035717 RID: 218903 RVA: 0x00CA72DC File Offset: 0x00CA54DC
		public void RefreshBySortContext(CardSlotSortContext sortContext)
		{
			this.Data.SortContext = sortContext;
			this.RefreshNormalCardSlot(null, false, 0);
		}

		// Token: 0x06035718 RID: 218904 RVA: 0x00CA7308 File Offset: 0x00CA5508
		public bool SelectFieldCardSlot()
		{
			DeckCardSlotInfo fieldCardSlot = this.Data.DeckInfo.GetFieldCardSlot();
			if (fieldCardSlot == null)
			{
				return false;
			}
			GenericScrollViewNew<DeckBuilderCardSlotItem, IDeckBuilderCardSlotItemData> normalSlotScrollLayout = this.NormalSlotScrollLayout;
			if (normalSlotScrollLayout != null)
			{
				normalSlotScrollLayout.SelectGridProxy(-1, false);
			}
			this.CoreSlotItem.OnDeselected(false);
			this.SelectedCardId = fieldCardSlot.CardId;
			return true;
		}

		// Token: 0x06035719 RID: 218905 RVA: 0x00CA7358 File Offset: 0x00CA5558
		public bool SelectCoreCardSlot()
		{
			DeckCardSlotInfo coreCardSlot = this.Data.DeckInfo.GetCoreCardSlot();
			if (coreCardSlot == null)
			{
				return false;
			}
			GenericScrollViewNew<DeckBuilderCardSlotItem, IDeckBuilderCardSlotItemData> normalSlotScrollLayout = this.NormalSlotScrollLayout;
			if (normalSlotScrollLayout != null)
			{
				normalSlotScrollLayout.SelectGridProxy(-1, false);
			}
			DeckBuilderFieldCardItem fieldCardItem = this.FieldCardItem;
			if (fieldCardItem != null)
			{
				DeckBuilderCardSlotItem fieldSlotItem = fieldCardItem.FieldSlotItem;
				if (fieldSlotItem != null)
				{
					fieldSlotItem.OnDeselected(false);
				}
			}
			this.CoreSlotItem.OnSelected(false);
			this.SelectedCardId = coreCardSlot.CardId;
			return true;
		}

		// Token: 0x0603571A RID: 218906 RVA: 0x00CA73C4 File Offset: 0x00CA55C4
		public bool SelectNormalCardSlotByIndex(int index)
		{
			this.CoreSlotItem.OnDeselected(false);
			DeckBuilderFieldCardItem fieldCardItem = this.FieldCardItem;
			if (fieldCardItem != null)
			{
				DeckBuilderCardSlotItem fieldSlotItem = fieldCardItem.FieldSlotItem;
				if (fieldSlotItem != null)
				{
					fieldSlotItem.OnDeselected(false);
				}
			}
			this.NormalSlotScrollLayout.SelectGridProxy(index, false);
			if (index < 0 || index >= this.CurNormalSlotDataList.Count)
			{
				Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "SelectNormalCardSlotByIndex Error, index out of range", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			this.SelectedCardId = this.CurNormalSlotDataList[index].SlotInfo.CardId;
			return true;
		}

		// Token: 0x0603571B RID: 218907 RVA: 0x00CA7458 File Offset: 0x00CA5658
		public void RefreshOutlookByCardId(int cardId)
		{
			bool outlookUnlocked = this.Data.ShowOutlook && PhantomArenaModel.Instance.IsCardOutlookUnlock(cardId);
			IDeckBuilderCardSlotItemData curCoreSlotData = this.CurCoreSlotData;
			if (curCoreSlotData != null && cardId == curCoreSlotData.SlotInfo.CardId)
			{
				curCoreSlotData.OutlookUnlocked = outlookUnlocked;
				this.CoreSlotItem.RefreshOutlookState();
				return;
			}
			int num = this.CurNormalSlotDataList.FindIndex((IDeckBuilderCardSlotItemData slot) => slot.SlotInfo.CardId == cardId);
			if (num < 0)
			{
				return;
			}
			this.CurNormalSlotDataList[num].OutlookUnlocked = outlookUnlocked;
			DeckBuilderCardSlotItem scrollItemByIndex = this.NormalSlotScrollLayout.GetScrollItemByIndex(num);
			if (scrollItemByIndex == null)
			{
				return;
			}
			scrollItemByIndex.RefreshOutlookState();
		}

		// Token: 0x0603571C RID: 218908 RVA: 0x00CA7508 File Offset: 0x00CA5708
		private DeckBuilderCardSlotItem CreateNormalSlotItem()
		{
			DeckBuilderCardSlotItem deckBuilderCardSlotItem = new DeckBuilderCardSlotItem();
			IDeckBuilderDeckSlotsPanelData data = this.Data;
			deckBuilderCardSlotItem.LongPressStartTime = ((data != null) ? data.SlotLongPressStartTime : null).GetValueOrDefault();
			IDeckBuilderDeckSlotsPanelData data2 = this.Data;
			deckBuilderCardSlotItem.LongPressEndTime = ((data2 != null) ? data2.SlotLongPressEndTime : null).GetValueOrDefault();
			deckBuilderCardSlotItem.CanToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanNormalSlotItemToggleChange);
			deckBuilderCardSlotItem.ShortClickCallback = delegate(DeckBuilderCardSlotItem item)
			{
				IDeckBuilderDeckSlotsPanelData data4 = this.Data;
				if (data4 == null)
				{
					return;
				}
				Action<DeckBuilderCardSlotItem> onNormalSlotItemSortClick = data4.OnNormalSlotItemSortClick;
				if (onNormalSlotItemSortClick == null)
				{
					return;
				}
				onNormalSlotItemSortClick(item);
			};
			deckBuilderCardSlotItem.LongPressCallback = delegate(DeckBuilderCardSlotItem item, float progress)
			{
				IDeckBuilderDeckSlotsPanelData data4 = this.Data;
				if (data4 == null)
				{
					return;
				}
				Action<DeckBuilderCardSlotItem, float> onNormalSlotItemLongPress = data4.OnNormalSlotItemLongPress;
				if (onNormalSlotItemLongPress == null)
				{
					return;
				}
				onNormalSlotItemLongPress(item, progress);
			};
			IDeckBuilderDeckSlotsPanelData data3 = this.Data;
			deckBuilderCardSlotItem.LongPressEndCallback = ((data3 != null) ? data3.OnSlotItemLongPressEnd : null);
			deckBuilderCardSlotItem.OnToggleStateChange = delegate(DeckBuilderCardSlotItem item, EToggleState state)
			{
				IDeckBuilderDeckSlotsPanelData data4 = this.Data;
				if (data4 == null)
				{
					return;
				}
				Action<DeckBuilderCardSlotItem, EToggleState> onNormalSlotItemToggleStateChange = data4.OnNormalSlotItemToggleStateChange;
				if (onNormalSlotItemToggleStateChange == null)
				{
					return;
				}
				onNormalSlotItemToggleStateChange(item, state);
			};
			deckBuilderCardSlotItem.OnPointEnterCallback = delegate(int cardId)
			{
				IDeckBuilderDeckSlotsPanelData data4 = this.Data;
				if (data4 == null)
				{
					return;
				}
				Action<int> onSlotCardPointEnterCallback = data4.OnSlotCardPointEnterCallback;
				if (onSlotCardPointEnterCallback == null)
				{
					return;
				}
				onSlotCardPointEnterCallback(cardId);
			};
			deckBuilderCardSlotItem.OnPointExitCallback = delegate()
			{
				IDeckBuilderDeckSlotsPanelData data4 = this.Data;
				if (data4 == null)
				{
					return;
				}
				Action onSlotCardPointExitCallback = data4.OnSlotCardPointExitCallback;
				if (onSlotCardPointExitCallback == null)
				{
					return;
				}
				onSlotCardPointExitCallback();
			};
			return deckBuilderCardSlotItem;
		}

		// Token: 0x0603571D RID: 218909 RVA: 0x00CA75EE File Offset: 0x00CA57EE
		private bool CanNormalSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return this.Data.CanNormalSlotItemToggleChange(item);
		}

		// Token: 0x0603571E RID: 218910 RVA: 0x00CA7604 File Offset: 0x00CA5804
		private DeckBuilderCardSlotItem CreateCoreSlotItem()
		{
			return new DeckBuilderCardSlotItem
			{
				CanToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanCoreSlotItemToggleChange),
				ShortClickCallback = delegate(DeckBuilderCardSlotItem item)
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<DeckBuilderCardSlotItem> onCoreSlotItemSortClick = data.OnCoreSlotItemSortClick;
					if (onCoreSlotItemSortClick == null)
					{
						return;
					}
					onCoreSlotItemSortClick(item);
				},
				LongPressCallback = delegate(DeckBuilderCardSlotItem item, float progress)
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<DeckBuilderCardSlotItem, float> onCoreSlotItemLongPress = data.OnCoreSlotItemLongPress;
					if (onCoreSlotItemLongPress == null)
					{
						return;
					}
					onCoreSlotItemLongPress(item, progress);
				},
				LongPressEndCallback = delegate()
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action onSlotItemLongPressEnd = data.OnSlotItemLongPressEnd;
					if (onSlotItemLongPressEnd == null)
					{
						return;
					}
					onSlotItemLongPressEnd();
				},
				OnToggleStateChange = delegate(DeckBuilderCardSlotItem item, EToggleState state)
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<DeckBuilderCardSlotItem, EToggleState> onCoreSlotItemToggleStateChange = data.OnCoreSlotItemToggleStateChange;
					if (onCoreSlotItemToggleStateChange == null)
					{
						return;
					}
					onCoreSlotItemToggleStateChange(item, state);
				},
				OnPointEnterCallback = delegate(int cardId)
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<int> onSlotCardPointEnterCallback = data.OnSlotCardPointEnterCallback;
					if (onSlotCardPointEnterCallback == null)
					{
						return;
					}
					onSlotCardPointEnterCallback(cardId);
				},
				OnPointExitCallback = delegate()
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action onSlotCardPointExitCallback = data.OnSlotCardPointExitCallback;
					if (onSlotCardPointExitCallback == null)
					{
						return;
					}
					onSlotCardPointExitCallback();
				}
			};
		}

		// Token: 0x0603571F RID: 218911 RVA: 0x00CA7694 File Offset: 0x00CA5894
		private bool CanCoreSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return this.Data.CanCoreSlotItemToggleChange(item);
		}

		// Token: 0x06035720 RID: 218912 RVA: 0x00CA76A8 File Offset: 0x00CA58A8
		private DeckBuilderCardSlotItem CreateFieldSlotItem()
		{
			return new DeckBuilderCardSlotItem
			{
				CanToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanFieldSlotItemToggleChange),
				ShortClickCallback = delegate(DeckBuilderCardSlotItem item)
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<DeckBuilderCardSlotItem> onCoreSlotItemSortClick = data.OnCoreSlotItemSortClick;
					if (onCoreSlotItemSortClick == null)
					{
						return;
					}
					onCoreSlotItemSortClick(item);
				},
				LongPressCallback = delegate(DeckBuilderCardSlotItem item, float progress)
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<DeckBuilderCardSlotItem, float> onCoreSlotItemLongPress = data.OnCoreSlotItemLongPress;
					if (onCoreSlotItemLongPress == null)
					{
						return;
					}
					onCoreSlotItemLongPress(item, progress);
				},
				LongPressEndCallback = delegate()
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action onSlotItemLongPressEnd = data.OnSlotItemLongPressEnd;
					if (onSlotItemLongPressEnd == null)
					{
						return;
					}
					onSlotItemLongPressEnd();
				},
				OnToggleStateChange = delegate(DeckBuilderCardSlotItem item, EToggleState state)
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<DeckBuilderCardSlotItem, EToggleState> onFieldSlotItemToggleStateChange = data.OnFieldSlotItemToggleStateChange;
					if (onFieldSlotItemToggleStateChange == null)
					{
						return;
					}
					onFieldSlotItemToggleStateChange(item, state);
				},
				OnPointEnterCallback = delegate(int cardId)
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<int> onSlotCardPointEnterCallback = data.OnSlotCardPointEnterCallback;
					if (onSlotCardPointEnterCallback == null)
					{
						return;
					}
					onSlotCardPointEnterCallback(cardId);
				},
				OnPointExitCallback = delegate()
				{
					IDeckBuilderDeckSlotsPanelData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action onSlotCardPointExitCallback = data.OnSlotCardPointExitCallback;
					if (onSlotCardPointExitCallback == null)
					{
						return;
					}
					onSlotCardPointExitCallback();
				}
			};
		}

		// Token: 0x06035721 RID: 218913 RVA: 0x00CA7738 File Offset: 0x00CA5938
		private bool CanFieldSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return this.Data.CanFieldSlotItemToggleChange(item);
		}

		// Token: 0x06035722 RID: 218914 RVA: 0x00CA774B File Offset: 0x00CA594B
		private CardElementItem CreateElementItem()
		{
			return new CardElementItem();
		}

		// Token: 0x06035723 RID: 218915 RVA: 0x00CA7752 File Offset: 0x00CA5952
		public int GetSelectedCardId()
		{
			return this.SelectedCardId;
		}

		// Token: 0x06035724 RID: 218916 RVA: 0x00CA775A File Offset: 0x00CA595A
		private void OnNormalMaskToggleChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SwitchMaskState(EPhantomArenaDeckSlotType.Normal);
			}
		}

		// Token: 0x06035725 RID: 218917 RVA: 0x00CA7767 File Offset: 0x00CA5967
		private void OnCoreMaskToggleChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SwitchMaskState(EPhantomArenaDeckSlotType.Core);
			}
		}

		// Token: 0x06035726 RID: 218918 RVA: 0x00CA7774 File Offset: 0x00CA5974
		public void SetMaskAreaEnabled(EPhantomArenaDeckSlotType area, bool enabled)
		{
			SlotAreaInfo slotAreaInfo;
			if (!this.SlotAreaInfoMap.TryGetValue(area, out slotAreaInfo))
			{
				return;
			}
			if (slotAreaInfo.Enabled == enabled)
			{
				return;
			}
			slotAreaInfo.Enabled = enabled;
			UUIExtendToggle toggle = slotAreaInfo.Toggle;
			if (!enabled)
			{
				toggle.SetToggleState(EToggleState.ETT_UnDetermined, false, false, false);
				if (this.ActiveSlotArea == area)
				{
					this.ActiveSlotArea = EPhantomArenaDeckSlotType.None;
					return;
				}
			}
			else
			{
				if (this.ActiveSlotArea == area)
				{
					slotAreaInfo.MaskItem.SetUIActive(false);
					toggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
					return;
				}
				slotAreaInfo.MaskItem.SetUIActive(true);
				toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
		}

		// Token: 0x06035727 RID: 218919 RVA: 0x00CA7804 File Offset: 0x00CA5A04
		public void SwitchMaskState(EPhantomArenaDeckSlotType activeSlotArea)
		{
			if (this.ActiveSlotArea == activeSlotArea)
			{
				return;
			}
			SlotAreaInfo slotAreaInfo;
			if (!this.SlotAreaInfoMap.TryGetValue(activeSlotArea, out slotAreaInfo))
			{
				return;
			}
			if (!slotAreaInfo.Enabled)
			{
				return;
			}
			SlotAreaInfo slotAreaInfo2;
			this.SlotAreaInfoMap.TryGetValue(this.ActiveSlotArea, out slotAreaInfo2);
			SlotAreaInfo slotAreaInfo3 = this.SlotAreaInfoMap[activeSlotArea];
			this.ActiveSlotArea = activeSlotArea;
			if (slotAreaInfo2 != null && slotAreaInfo2.Enabled)
			{
				slotAreaInfo2.MaskItem.SetUIActive(true);
				slotAreaInfo2.Toggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			if (slotAreaInfo3 != null && slotAreaInfo3.Enabled)
			{
				slotAreaInfo3.MaskItem.SetUIActive(false);
				slotAreaInfo3.Toggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
		}

		// Token: 0x06035728 RID: 218920 RVA: 0x00CA78AC File Offset: 0x00CA5AAC
		public void GamepadTriggerDeckBuilderCardInfoView(UUIItem uiItem)
		{
			if (uiItem == this.CoreSlotItem.GetRootItem())
			{
				this.CoreSlotItem.TriggerLongPress();
				return;
			}
			for (int i = 0; i < this.CurNormalSlotDataList.Count; i++)
			{
				DeckBuilderCardSlotItem scrollItemByIndex = this.NormalSlotScrollLayout.GetScrollItemByIndex(i);
				if (((scrollItemByIndex != null) ? scrollItemByIndex.GetRootItem() : null) == uiItem)
				{
					scrollItemByIndex.TriggerLongPress();
					return;
				}
			}
		}

		// Token: 0x06035729 RID: 218921 RVA: 0x00CA790C File Offset: 0x00CA5B0C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (configParams == null || configParams.Length == 0)
			{
				return null;
			}
			if (!(configParams[0] == "CardInGroup"))
			{
				return null;
			}
			int index = int.Parse(configParams[1]);
			GenericScrollViewNew<DeckBuilderCardSlotItem, IDeckBuilderCardSlotItemData> normalSlotScrollLayout = this.NormalSlotScrollLayout;
			UUIItem uuiitem = (normalSlotScrollLayout != null) ? normalSlotScrollLayout.GetItemByIndex(index) : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x0401C64B RID: 116299
		private const float ITEM_LOCATION_TOLERANCE = 0.1f;

		// Token: 0x0401C64C RID: 116300
		[Nullable(2)]
		protected IDeckBuilderDeckSlotsPanelData Data;

		// Token: 0x0401C64D RID: 116301
		[Nullable(2)]
		protected IDeckBuilderCardSlotItemData CurCoreSlotData;

		// Token: 0x0401C64E RID: 116302
		[Nullable(2)]
		protected IDeckBuilderCardSlotItemData CurFieldSlotData;

		// Token: 0x0401C64F RID: 116303
		protected List<IDeckBuilderCardSlotItemData> CurNormalSlotDataList = new List<IDeckBuilderCardSlotItemData>();

		// Token: 0x0401C650 RID: 116304
		[Nullable(2)]
		private DeckBuilderCardSlotItem CoreSlotItem;

		// Token: 0x0401C651 RID: 116305
		[Nullable(2)]
		private DeckBuilderFieldCardItem FieldCardItem;

		// Token: 0x0401C652 RID: 116306
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<DeckBuilderCardSlotItem, IDeckBuilderCardSlotItemData> NormalSlotScrollLayout;

		// Token: 0x0401C653 RID: 116307
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CardElementItem, ECardElement> CoreElementLayout;

		// Token: 0x0401C654 RID: 116308
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CardElementItem, ECardElement> NormalElementLayout;

		// Token: 0x0401C655 RID: 116309
		private int SelectedCardId;

		// Token: 0x0401C656 RID: 116310
		private EPhantomArenaDeckSlotType ActiveSlotArea;

		// Token: 0x0401C657 RID: 116311
		private readonly Dictionary<EPhantomArenaDeckSlotType, SlotAreaInfo> SlotAreaInfoMap = new Dictionary<EPhantomArenaDeckSlotType, SlotAreaInfo>();

		// Token: 0x0200B308 RID: 45832
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036424 RID: 222244
			public const int NameText = 0;

			// Token: 0x04036425 RID: 222245
			public const int CoreMaskToggle = 1;

			// Token: 0x04036426 RID: 222246
			public const int CoreMaskItem = 2;

			// Token: 0x04036427 RID: 222247
			public const int CoreCardSlotCountText = 3;

			// Token: 0x04036428 RID: 222248
			public const int CoreElementLayout = 4;

			// Token: 0x04036429 RID: 222249
			public const int CoreCardSlotEmptyItem = 5;

			// Token: 0x0403642A RID: 222250
			public const int CoreCardSlotLockedItem = 6;

			// Token: 0x0403642B RID: 222251
			public const int CoreCardSlotItem = 7;

			// Token: 0x0403642C RID: 222252
			public const int NormalMaskToggle = 8;

			// Token: 0x0403642D RID: 222253
			public const int NormalMaskItem = 9;

			// Token: 0x0403642E RID: 222254
			public const int NormalCardSlotCountText = 10;

			// Token: 0x0403642F RID: 222255
			public const int NormalElementLayout = 11;

			// Token: 0x04036430 RID: 222256
			public const int NormalCardSlotEmptyItem = 12;

			// Token: 0x04036431 RID: 222257
			public const int NormalCardSlotScrollView = 13;

			// Token: 0x04036432 RID: 222258
			public const int NormalCardSlotLayout = 14;

			// Token: 0x04036433 RID: 222259
			public const int NormalCardSlotItem = 15;

			// Token: 0x04036434 RID: 222260
			public const int FieldCardItem = 16;
		}
	}
}
