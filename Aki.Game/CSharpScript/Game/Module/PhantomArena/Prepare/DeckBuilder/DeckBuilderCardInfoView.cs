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
	// Token: 0x0200518F RID: 20879
	[NullableContext(2)]
	[Nullable(0)]
	public class DeckBuilderCardInfoView : UiViewBase
	{
		// Token: 0x06035651 RID: 218705 RVA: 0x00CA595E File Offset: 0x00CA3B5E
		[NullableContext(1)]
		public DeckBuilderCardInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06035652 RID: 218706 RVA: 0x00CA5968 File Offset: 0x00CA3B68
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

		// Token: 0x06035653 RID: 218707 RVA: 0x00CA5A40 File Offset: 0x00CA3C40
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardInfoView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardInfoView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035654 RID: 218708 RVA: 0x00CA5A83 File Offset: 0x00CA3C83
		protected override void OnStart()
		{
			this.RefreshView();
			this.SelectToggleByIndex(0, false);
		}

		// Token: 0x06035655 RID: 218709 RVA: 0x00CA5A93 File Offset: 0x00CA3C93
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
		}

		// Token: 0x06035656 RID: 218710 RVA: 0x00CA5ACD File Offset: 0x00CA3CCD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardOutlookUnlock, new Action<int>(this.OnPhantomArenaCardOutlookUnlock));
		}

		// Token: 0x06035657 RID: 218711 RVA: 0x00CA5B08 File Offset: 0x00CA3D08
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

		// Token: 0x06035658 RID: 218712 RVA: 0x00CA5B58 File Offset: 0x00CA3D58
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

		// Token: 0x06035659 RID: 218713 RVA: 0x00CA5D6A File Offset: 0x00CA3F6A
		[NullableContext(1)]
		private DeckBuilderCardInfoTabItem CreateTabItem()
		{
			return new DeckBuilderCardInfoTabItem();
		}

		// Token: 0x0603565A RID: 218714 RVA: 0x00CA5D71 File Offset: 0x00CA3F71
		private void OnToggleSelect(int newTabIndex)
		{
			this.SelectToggleByIndex(newTabIndex, true);
		}

		// Token: 0x0603565B RID: 218715 RVA: 0x00CA5D7C File Offset: 0x00CA3F7C
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

		// Token: 0x0603565C RID: 218716 RVA: 0x00CA5E2C File Offset: 0x00CA402C
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

		// Token: 0x0603565D RID: 218717 RVA: 0x00CA5E6B File Offset: 0x00CA406B
		private void OnDetailPanelShow()
		{
		}

		// Token: 0x0603565E RID: 218718 RVA: 0x00CA5E6D File Offset: 0x00CA406D
		private void OnOutLookPanelShow()
		{
		}

		// Token: 0x0603565F RID: 218719 RVA: 0x00CA5E70 File Offset: 0x00CA4070
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

		// Token: 0x06035660 RID: 218720 RVA: 0x00CA5EFC File Offset: 0x00CA40FC
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

		// Token: 0x06035661 RID: 218721 RVA: 0x00CA5F87 File Offset: 0x00CA4187
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x06035662 RID: 218722 RVA: 0x00CA5F90 File Offset: 0x00CA4190
		private void OnPhantomArenaCardUnlock(int cardId)
		{
			if (cardId == this.Data.CurCardId)
			{
				this.RefreshView();
			}
		}

		// Token: 0x06035663 RID: 218723 RVA: 0x00CA5FA6 File Offset: 0x00CA41A6
		private void OnPhantomArenaCardOutlookUnlock(int cardId)
		{
			if (cardId == this.Data.CurCardId)
			{
				this.RefreshView();
			}
		}

		// Token: 0x06035664 RID: 218724 RVA: 0x00CA5FBC File Offset: 0x00CA41BC
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

		// Token: 0x0401C606 RID: 116230
		protected DeckBuilderCardInfoViewData Data;

		// Token: 0x0401C607 RID: 116231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected DeckBuilderCardInfoTabItemData[] TabItemDataList;

		// Token: 0x0401C608 RID: 116232
		[Nullable(new byte[]
		{
			2,
			1
		})]
		protected List<TabData> TabDataList;

		// Token: 0x0401C609 RID: 116233
		protected IDeckBuilderCardDetailPanelData DetailPanelData;

		// Token: 0x0401C60A RID: 116234
		protected IDeckBuilderCardOutlookUnlockPanelData OutlookUnlockPanelData;

		// Token: 0x0401C60B RID: 116235
		private DeckBuilderCardDetailPanel DetailPanel;

		// Token: 0x0401C60C RID: 116236
		private DeckBuilderCardOutlookUnlockPanel OutlookUnlockPanel;

		// Token: 0x0401C60D RID: 116237
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<DeckBuilderCardInfoTabItem, DeckBuilderCardInfoTabItemData> TabLayout;

		// Token: 0x0401C60E RID: 116238
		private PopupCaptionItem CaptionItem;

		// Token: 0x0200B301 RID: 45825
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036401 RID: 222209
			public const int TabLayout = 0;

			// Token: 0x04036402 RID: 222210
			public const int CaptionItem = 1;

			// Token: 0x04036403 RID: 222211
			public const int LeftArrowButton = 2;

			// Token: 0x04036404 RID: 222212
			public const int RightArrowButton = 3;

			// Token: 0x04036405 RID: 222213
			public const int ContentItem = 4;

			// Token: 0x04036406 RID: 222214
			public const int ItemTabPanel = 5;
		}
	}
}
