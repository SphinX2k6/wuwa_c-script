using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200415F RID: 16735
	[NullableContext(2)]
	[Nullable(0)]
	public class DeckBuilderCardInfoView : UiViewBase
	{
		// Token: 0x0602A54C RID: 173388 RVA: 0x00BF2F12 File Offset: 0x00BF1112
		[NullableContext(1)]
		public DeckBuilderCardInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602A54D RID: 173389 RVA: 0x00BF2F1C File Offset: 0x00BF111C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action(this.OnLeftArrowButtonClick)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnRightArrowButtonClick))
			};
		}

		// Token: 0x0602A54E RID: 173390 RVA: 0x00BF2FF4 File Offset: 0x00BF11F4
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardInfoView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardInfoView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A54F RID: 173391 RVA: 0x00BF3037 File Offset: 0x00BF1237
		protected override void OnStart()
		{
			this.RefreshView();
			this.SelectToggleByIndex(0, false);
		}

		// Token: 0x0602A550 RID: 173392 RVA: 0x00BF3047 File Offset: 0x00BF1247
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
		}

		// Token: 0x0602A551 RID: 173393 RVA: 0x00BF3081 File Offset: 0x00BF1281
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
		}

		// Token: 0x0602A552 RID: 173394 RVA: 0x00BF30BC File Offset: 0x00BF12BC
		protected override void OnBeforeShow()
		{
			int? selectedTabIndex = this.Data.SelectedTabIndex;
			if (selectedTabIndex != null && selectedTabIndex.Value >= 0)
			{
				IDeckBuilderCardInfoViewPanelSequencePlayer sequencePlayer = this.TabDataList[selectedTabIndex.Value].SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlayShowSequence();
			}
		}

		// Token: 0x0602A553 RID: 173395 RVA: 0x00BF310C File Offset: 0x00BF130C
		public void RefreshView()
		{
			if (this.Data == null)
			{
				return;
			}
			int curCardId = 0;
			if (this.Data.CardList != null && this.Data.CurCardIndex != null)
			{
				DeckBuilderCardItemData deckBuilderCardItemData = this.Data.CardList[this.Data.CurCardIndex.Value];
				curCardId = deckBuilderCardItemData.CardId;
				this.Data.CurCardId = curCardId;
			}
			else
			{
				curCardId = this.Data.CurCardId;
			}
			DeckBuilderCardDetailPanelData deckBuilderCardDetailPanelData = new DeckBuilderCardDetailPanelData
			{
				DeckInfo = this.Data.DeckInfo,
				CardItemData = PhantomArenaModel.Instance.GetDetailViewCardData(curCardId),
				EntryIdList = PhantomArenaModel.Instance.GetDetailViewEntryData(curCardId).ToArray(),
				DetailItemData = PhantomArenaModel.Instance.GetDetailViewDetailItemData(curCardId, this.Data.DeckInfo),
				IsCardUnlocked = PhantomArenaModel.Instance.IsCardUnlock(curCardId)
			};
			if (this.Data.DeckInfo != null)
			{
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(curCardId);
				deckBuilderCardDetailPanelData.CurrencyId = new int?(phantomBattleCardConfig.UnlockConsumeItems()[0].ItemId);
				deckBuilderCardDetailPanelData.UnlockCost = new int?(phantomBattleCardConfig.UnlockConsumeItems()[0].Count);
				deckBuilderCardDetailPanelData.CardLimit = new int?(phantomBattleCardConfig.CardGroupNum);
			}
			if (this.Data.AddCardToDeck != null)
			{
				deckBuilderCardDetailPanelData.AddCardToDeck = delegate()
				{
					DeckBuilderCardInfoViewData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<int, int> addCardToDeck = data.AddCardToDeck;
					if (addCardToDeck == null)
					{
						return;
					}
					addCardToDeck(curCardId, 1);
				};
			}
			if (this.Data.RemoveCardFromDeck != null)
			{
				deckBuilderCardDetailPanelData.RemoveCardFromDeck = delegate()
				{
					DeckBuilderCardInfoViewData data = this.Data;
					if (data == null)
					{
						return;
					}
					Action<int, int> removeCardFromDeck = data.RemoveCardFromDeck;
					if (removeCardFromDeck == null)
					{
						return;
					}
					removeCardFromDeck(curCardId, 1);
				};
			}
			this.DetailPanelData = deckBuilderCardDetailPanelData;
			DeckBuilderCardDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel != null)
			{
				detailPanel.Refresh(deckBuilderCardDetailPanelData);
			}
			if (this.Data.NeedOutlookTab)
			{
				DeckBuilderCardOutlookUnlockPanelData deckBuilderCardOutlookUnlockPanelData = new DeckBuilderCardOutlookUnlockPanelData
				{
					CardId = curCardId
				};
				this.OutlookUnlockPanelData = deckBuilderCardOutlookUnlockPanelData;
				DeckBuilderCardOutlookUnlockPanel outlookUnlockPanel = this.OutlookUnlockPanel;
				if (outlookUnlockPanel == null)
				{
					return;
				}
				outlookUnlockPanel.Refresh(deckBuilderCardOutlookUnlockPanelData);
			}
		}

		// Token: 0x0602A554 RID: 173396 RVA: 0x00BF331E File Offset: 0x00BF151E
		[NullableContext(1)]
		private DeckBuilderCardInfoTabItem CreateTabItem()
		{
			return new DeckBuilderCardInfoTabItem();
		}

		// Token: 0x0602A555 RID: 173397 RVA: 0x00BF3325 File Offset: 0x00BF1525
		private void OnToggleSelect(int newTabIndex)
		{
			this.SelectToggleByIndex(newTabIndex, true);
		}

		// Token: 0x0602A556 RID: 173398 RVA: 0x00BF3330 File Offset: 0x00BF1530
		private void SelectToggleByIndex(int newTabIndex, bool bPlayAnim)
		{
			int? selectedTabIndex = this.Data.SelectedTabIndex;
			if (selectedTabIndex != null && selectedTabIndex.Value >= 0)
			{
				UiPanelBase panel = this.TabDataList[selectedTabIndex.Value].Panel;
				if (panel != null)
				{
					panel.SetActive(false);
				}
			}
			this.Data.SelectedTabIndex = new int?(newTabIndex);
			GenericLayout<DeckBuilderCardInfoTabItem, DeckBuilderCardInfoTabItemData> tabLayout = this.TabLayout;
			if (tabLayout != null)
			{
				tabLayout.SelectGridProxy(newTabIndex, false);
			}
			TabData tabData = this.TabDataList[newTabIndex];
			tabData.Panel.SetActive(true);
			Action onShow = tabData.OnShow;
			if (onShow != null)
			{
				onShow();
			}
			if (bPlayAnim)
			{
				IDeckBuilderCardInfoViewPanelSequencePlayer sequencePlayer = tabData.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlayShowSequence();
			}
		}

		// Token: 0x0602A557 RID: 173399 RVA: 0x00BF33E0 File Offset: 0x00BF15E0
		private void PlaySwitchSequence()
		{
			if (this.Data.SelectedTabIndex == null)
			{
				return;
			}
			IDeckBuilderCardInfoViewPanelSequencePlayer sequencePlayer = this.TabDataList[this.Data.SelectedTabIndex.Value].SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlaySwitchSequence();
		}

		// Token: 0x0602A558 RID: 173400 RVA: 0x00BF341F File Offset: 0x00BF161F
		private void OnDetailPanelShow()
		{
		}

		// Token: 0x0602A559 RID: 173401 RVA: 0x00BF3421 File Offset: 0x00BF1621
		private void OnOutLookPanelShow()
		{
		}

		// Token: 0x0602A55A RID: 173402 RVA: 0x00BF3424 File Offset: 0x00BF1624
		private void OnLeftArrowButtonClick()
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.CardList == null)
			{
				return;
			}
			if (this.Data.CurCardIndex == null)
			{
				return;
			}
			int value = (this.Data.CurCardIndex.Value == 0) ? (this.Data.CardList.Length - 1) : (this.Data.CurCardIndex.Value - 1);
			this.Data.CurCardIndex = new int?(value);
			this.RefreshView();
			this.PlaySwitchSequence();
		}

		// Token: 0x0602A55B RID: 173403 RVA: 0x00BF34B0 File Offset: 0x00BF16B0
		private void OnRightArrowButtonClick()
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.CardList == null)
			{
				return;
			}
			if (this.Data.CurCardIndex == null)
			{
				return;
			}
			int value = (this.Data.CurCardIndex.Value == this.Data.CardList.Length - 1) ? 0 : (this.Data.CurCardIndex.Value + 1);
			this.Data.CurCardIndex = new int?(value);
			this.RefreshView();
			this.PlaySwitchSequence();
		}

		// Token: 0x0602A55C RID: 173404 RVA: 0x00BF353B File Offset: 0x00BF173B
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602A55D RID: 173405 RVA: 0x00BF3544 File Offset: 0x00BF1744
		private void OnPhantomArenaCardUnlock(int cardId)
		{
			if (cardId == this.Data.CurCardId)
			{
				this.RefreshView();
			}
		}

		// Token: 0x0602A55E RID: 173406 RVA: 0x00BF355A File Offset: 0x00BF175A
		private void OnPhantomArenaCardOutlookUnlock(int cardId)
		{
			if (cardId == this.Data.CurCardId)
			{
				this.RefreshView();
			}
		}

		// Token: 0x0602A55F RID: 173407 RVA: 0x00BF3570 File Offset: 0x00BF1770
		[NullableContext(1)]
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
			if (!(configParams[0] == "UnlockCard"))
			{
				return null;
			}
			DeckBuilderCardDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel == null)
			{
				return null;
			}
			return detailPanel.GetGuideUiItemAndUiItemForShowEx(configParams);
		}

		// Token: 0x0401703B RID: 94267
		protected DeckBuilderCardInfoViewData Data;

		// Token: 0x0401703C RID: 94268
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected DeckBuilderCardInfoTabItemData[] TabItemDataList;

		// Token: 0x0401703D RID: 94269
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<TabData> TabDataList;

		// Token: 0x0401703E RID: 94270
		protected IDeckBuilderCardDetailPanelData DetailPanelData;

		// Token: 0x0401703F RID: 94271
		protected IDeckBuilderCardOutlookUnlockPanelData OutlookUnlockPanelData;

		// Token: 0x04017040 RID: 94272
		private DeckBuilderCardDetailPanel DetailPanel;

		// Token: 0x04017041 RID: 94273
		private DeckBuilderCardOutlookUnlockPanel OutlookUnlockPanel;

		// Token: 0x04017042 RID: 94274
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DeckBuilderCardInfoTabItem, DeckBuilderCardInfoTabItemData> TabLayout;

		// Token: 0x04017043 RID: 94275
		private PopupCaptionItem CaptionItem;

		// Token: 0x02009D3A RID: 40250
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E56 RID: 200278
			public const int TabLayout = 0;

			// Token: 0x04030E57 RID: 200279
			public const int CaptionItem = 1;

			// Token: 0x04030E58 RID: 200280
			public const int LeftArrowButton = 2;

			// Token: 0x04030E59 RID: 200281
			public const int RightArrowButton = 3;

			// Token: 0x04030E5A RID: 200282
			public const int ContentItem = 4;

			// Token: 0x04030E5B RID: 200283
			public const int ItemTabPanel = 5;
		}
	}
}
