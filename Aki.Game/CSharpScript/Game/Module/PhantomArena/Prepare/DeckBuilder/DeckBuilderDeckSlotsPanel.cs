using System;
using System.Collections.Generic;
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
	// Token: 0x0200416A RID: 16746
	[NullableContext(1)]
	[Nullable(0)]
	public class DeckBuilderDeckSlotsPanel : UiPanelBase
	{
		// Token: 0x0602A604 RID: 173572 RVA: 0x00BF405C File Offset: 0x00BF225C
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

		// Token: 0x0602A605 RID: 173573 RVA: 0x00BF41F4 File Offset: 0x00BF23F4
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderDeckSlotsPanel.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderDeckSlotsPanel.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A606 RID: 173574 RVA: 0x00BF4238 File Offset: 0x00BF2438
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

		// Token: 0x0602A607 RID: 173575 RVA: 0x00BF4370 File Offset: 0x00BF2570
		public void RefreshCardSlot(int? needPlayAddAnimCard = null, bool keepContentPosition = false)
		{
			this.RefreshCoreCardSlot(needPlayAddAnimCard);
			this.RefreshFieldCardSlot(needPlayAddAnimCard);
			this.RefreshNormalCardSlot(needPlayAddAnimCard, keepContentPosition, 0);
		}

		// Token: 0x0602A608 RID: 173576 RVA: 0x00BF438C File Offset: 0x00BF258C
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

		// Token: 0x0602A609 RID: 173577 RVA: 0x00BF4418 File Offset: 0x00BF2618
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

		// Token: 0x0602A60A RID: 173578 RVA: 0x00BF4518 File Offset: 0x00BF2718
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

		// Token: 0x0602A60B RID: 173579 RVA: 0x00BF45BC File Offset: 0x00BF27BC
		public void RefreshNormalCardSlot(int? needPlayAddAnimCard = null, bool keepContentPosition = false, int scrollToSlotId = 0)
		{
			DeckInfo deckInfo = this.Data.DeckInfo;
			List<DeckCardSlotInfo> list = new List<DeckCardSlotInfo>(deckInfo.GetNormalCardSlotList());
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

		// Token: 0x0602A60C RID: 173580 RVA: 0x00BF4740 File Offset: 0x00BF2940
		private void OnRefreshFieldCardEffectUnlock(PhantomBattleCheckCardSkillUnlockResponse info)
		{
			this.RefreshFieldCardEffectUnlock(info);
		}

		// Token: 0x0602A60D RID: 173581 RVA: 0x00BF474C File Offset: 0x00BF294C
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

		// Token: 0x0602A60E RID: 173582 RVA: 0x00BF47EE File Offset: 0x00BF29EE
		public void RefreshCardSlotElements()
		{
			this.RefreshCoreCardSlotElement();
			this.RefreshNormalCardSlotElement();
		}

		// Token: 0x0602A60F RID: 173583 RVA: 0x00BF47FC File Offset: 0x00BF29FC
		private void RefreshCoreCardSlotElement()
		{
			DeckCardSlotInfo coreCardSlot = this.Data.DeckInfo.GetCoreCardSlot();
			List<int> list = new List<int>();
			if (coreCardSlot != null)
			{
				list.Add(coreCardSlot.Element);
			}
			List<ECardElement> list2 = new List<ECardElement>(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				list2.Add((ECardElement)list[i]);
			}
			GenericLayout<CardElementItem, ECardElement> coreElementLayout = this.CoreElementLayout;
			if (coreElementLayout == null)
			{
				return;
			}
			coreElementLayout.RefreshByData(list2, null, false);
		}

		// Token: 0x0602A610 RID: 173584 RVA: 0x00BF486C File Offset: 0x00BF2A6C
		private void RefreshNormalCardSlotElement()
		{
			GenericLayout<CardElementItem, ECardElement> normalElementLayout = this.NormalElementLayout;
			if (normalElementLayout == null)
			{
				return;
			}
			normalElementLayout.RefreshByData(this.Data.DeckInfo.GetElementList(), null, false);
		}

		// Token: 0x0602A611 RID: 173585 RVA: 0x00BF4890 File Offset: 0x00BF2A90
		public void RefreshNameText()
		{
			base.GetText(0).SetText(this.Data.DeckInfo.GetDeckName(), true);
		}

		// Token: 0x0602A612 RID: 173586 RVA: 0x00BF48B0 File Offset: 0x00BF2AB0
		public void RefreshBySortContext(CardSlotSortContext sortContext)
		{
			this.Data.SortContext = sortContext;
			this.RefreshNormalCardSlot(null, false, 0);
		}

		// Token: 0x0602A613 RID: 173587 RVA: 0x00BF48DC File Offset: 0x00BF2ADC
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

		// Token: 0x0602A614 RID: 173588 RVA: 0x00BF492C File Offset: 0x00BF2B2C
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

		// Token: 0x0602A615 RID: 173589 RVA: 0x00BF4998 File Offset: 0x00BF2B98
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

		// Token: 0x0602A616 RID: 173590 RVA: 0x00BF4A2C File Offset: 0x00BF2C2C
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

		// Token: 0x0602A617 RID: 173591 RVA: 0x00BF4ADC File Offset: 0x00BF2CDC
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

		// Token: 0x0602A618 RID: 173592 RVA: 0x00BF4BC2 File Offset: 0x00BF2DC2
		private bool CanNormalSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return this.Data.CanNormalSlotItemToggleChange(item);
		}

		// Token: 0x0602A619 RID: 173593 RVA: 0x00BF4BD8 File Offset: 0x00BF2DD8
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

		// Token: 0x0602A61A RID: 173594 RVA: 0x00BF4C68 File Offset: 0x00BF2E68
		private bool CanCoreSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return this.Data.CanCoreSlotItemToggleChange(item);
		}

		// Token: 0x0602A61B RID: 173595 RVA: 0x00BF4C7C File Offset: 0x00BF2E7C
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

		// Token: 0x0602A61C RID: 173596 RVA: 0x00BF4D0C File Offset: 0x00BF2F0C
		private bool CanFieldSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return this.Data.CanFieldSlotItemToggleChange(item);
		}

		// Token: 0x0602A61D RID: 173597 RVA: 0x00BF4D1F File Offset: 0x00BF2F1F
		private CardElementItem CreateElementItem()
		{
			return new CardElementItem();
		}

		// Token: 0x0602A61E RID: 173598 RVA: 0x00BF4D26 File Offset: 0x00BF2F26
		public int GetSelectedCardId()
		{
			return this.SelectedCardId;
		}

		// Token: 0x0602A61F RID: 173599 RVA: 0x00BF4D2E File Offset: 0x00BF2F2E
		private void OnNormalMaskToggleChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SwitchMaskState(EPhantomArenaDeckSlotType.Normal);
			}
		}

		// Token: 0x0602A620 RID: 173600 RVA: 0x00BF4D3B File Offset: 0x00BF2F3B
		private void OnCoreMaskToggleChange(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SwitchMaskState(EPhantomArenaDeckSlotType.Core);
			}
		}

		// Token: 0x0602A621 RID: 173601 RVA: 0x00BF4D48 File Offset: 0x00BF2F48
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

		// Token: 0x0602A622 RID: 173602 RVA: 0x00BF4DD8 File Offset: 0x00BF2FD8
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

		// Token: 0x0602A623 RID: 173603 RVA: 0x00BF4E80 File Offset: 0x00BF3080
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

		// Token: 0x0602A624 RID: 173604 RVA: 0x00BF4EE0 File Offset: 0x00BF30E0
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

		// Token: 0x04017080 RID: 94336
		private const float ITEM_LOCATION_TOLERANCE = 0.1f;

		// Token: 0x04017081 RID: 94337
		[Nullable(2)]
		protected IDeckBuilderDeckSlotsPanelData Data;

		// Token: 0x04017082 RID: 94338
		[Nullable(2)]
		protected IDeckBuilderCardSlotItemData CurCoreSlotData;

		// Token: 0x04017083 RID: 94339
		[Nullable(2)]
		protected IDeckBuilderCardSlotItemData CurFieldSlotData;

		// Token: 0x04017084 RID: 94340
		protected List<IDeckBuilderCardSlotItemData> CurNormalSlotDataList = new List<IDeckBuilderCardSlotItemData>();

		// Token: 0x04017085 RID: 94341
		[Nullable(2)]
		private DeckBuilderCardSlotItem CoreSlotItem;

		// Token: 0x04017086 RID: 94342
		[Nullable(2)]
		private DeckBuilderFieldCardItem FieldCardItem;

		// Token: 0x04017087 RID: 94343
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericScrollViewNew<DeckBuilderCardSlotItem, IDeckBuilderCardSlotItemData> NormalSlotScrollLayout;

		// Token: 0x04017088 RID: 94344
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CardElementItem, ECardElement> CoreElementLayout;

		// Token: 0x04017089 RID: 94345
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected GenericLayout<CardElementItem, ECardElement> NormalElementLayout;

		// Token: 0x0401708A RID: 94346
		private int SelectedCardId;

		// Token: 0x0401708B RID: 94347
		private EPhantomArenaDeckSlotType ActiveSlotArea;

		// Token: 0x0401708C RID: 94348
		private readonly Dictionary<EPhantomArenaDeckSlotType, SlotAreaInfo> SlotAreaInfoMap = new Dictionary<EPhantomArenaDeckSlotType, SlotAreaInfo>();

		// Token: 0x02009D41 RID: 40257
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E79 RID: 200313
			public const int NameText = 0;

			// Token: 0x04030E7A RID: 200314
			public const int CoreMaskToggle = 1;

			// Token: 0x04030E7B RID: 200315
			public const int CoreMaskItem = 2;

			// Token: 0x04030E7C RID: 200316
			public const int CoreCardSlotCountText = 3;

			// Token: 0x04030E7D RID: 200317
			public const int CoreElementLayout = 4;

			// Token: 0x04030E7E RID: 200318
			public const int CoreCardSlotEmptyItem = 5;

			// Token: 0x04030E7F RID: 200319
			public const int CoreCardSlotLockedItem = 6;

			// Token: 0x04030E80 RID: 200320
			public const int CoreCardSlotItem = 7;

			// Token: 0x04030E81 RID: 200321
			public const int NormalMaskToggle = 8;

			// Token: 0x04030E82 RID: 200322
			public const int NormalMaskItem = 9;

			// Token: 0x04030E83 RID: 200323
			public const int NormalCardSlotCountText = 10;

			// Token: 0x04030E84 RID: 200324
			public const int NormalElementLayout = 11;

			// Token: 0x04030E85 RID: 200325
			public const int NormalCardSlotEmptyItem = 12;

			// Token: 0x04030E86 RID: 200326
			public const int NormalCardSlotScrollView = 13;

			// Token: 0x04030E87 RID: 200327
			public const int NormalCardSlotLayout = 14;

			// Token: 0x04030E88 RID: 200328
			public const int NormalCardSlotItem = 15;

			// Token: 0x04030E89 RID: 200329
			public const int FieldCardItem = 16;
		}
	}
}
