using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckDetail
{
	// Token: 0x02005181 RID: 20865
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDeckDetailView : UiViewBase
	{
		// Token: 0x060355E1 RID: 218593 RVA: 0x00CA4242 File Offset: 0x00CA2442
		public PhantomArenaDeckDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060355E2 RID: 218594 RVA: 0x00CA424C File Offset: 0x00CA244C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIText)),
				new ValueTuple<int, Type>(16, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(12, new Action(this.OnCardDescBtnClick)),
				new ValueTuple<int, Delegate>(16, new Action(this.OnMaskBtnClick))
			};
		}

		// Token: 0x060355E3 RID: 218595 RVA: 0x00CA4420 File Offset: 0x00CA2620
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaDeckDetailView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaDeckDetailView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060355E4 RID: 218596 RVA: 0x00CA4463 File Offset: 0x00CA2663
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
		}

		// Token: 0x060355E5 RID: 218597 RVA: 0x00CA4481 File Offset: 0x00CA2681
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
		}

		// Token: 0x060355E6 RID: 218598 RVA: 0x00CA44A0 File Offset: 0x00CA26A0
		public void RefreshDeckSlotsPanel()
		{
			bool isNeedFieldCard = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.Data.ActivityId);
			DeckBuilderDeckSlotsPanelData data = new DeckBuilderDeckSlotsPanelData
			{
				DeckInfo = this.Data.DeckInfo,
				OnCoreSlotItemToggleStateChange = new Action<DeckBuilderCardSlotItem, EToggleState>(this.OnCoreSlotItemToggleStateChange),
				CanCoreSlotItemToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanCoreSlotItemToggleChange),
				OnNormalSlotItemToggleStateChange = new Action<DeckBuilderCardSlotItem, EToggleState>(this.OnNormalSlotItemToggleStateChange),
				CanNormalSlotItemToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanNormalSlotItemToggleChange),
				OnFieldSlotItemToggleStateChange = new Action<DeckBuilderCardSlotItem, EToggleState>(this.OnFieldSlotItemToggleStateChange),
				CanFieldSlotItemToggleChange = new Func<DeckBuilderCardSlotItem, bool>(this.CanFieldSlotItemToggleChange),
				SortContext = new CardSlotSortContext
				{
					SortType = ECardSlotSortType.Cost,
					IsAscending = true
				},
				ShowLocked = this.Data.ShowLocked,
				ShowOutlook = this.Data.ShowLocked,
				IsNeedFieldCard = isNeedFieldCard,
				IsNeedRequestCheckCardSkillUnlock = true
			};
			DeckBuilderDeckSlotsPanel deckSlotsPanel = this.DeckSlotsPanel;
			if (deckSlotsPanel == null)
			{
				return;
			}
			deckSlotsPanel.RefreshByData(data);
		}

		// Token: 0x060355E7 RID: 218599 RVA: 0x00CA45A0 File Offset: 0x00CA27A0
		public void SelectFirstCardSlot()
		{
			if (this.SelectCoreCardSlot())
			{
				return;
			}
			this.SelectNormalCardSlotByIndex(0);
		}

		// Token: 0x060355E8 RID: 218600 RVA: 0x00CA45B2 File Offset: 0x00CA27B2
		public bool SelectFieldCardSlot()
		{
			if (!this.DeckSlotsPanel.SelectFieldCardSlot())
			{
				return false;
			}
			this.Data.CurCardId = new int?(this.DeckSlotsPanel.GetSelectedCardId());
			this.RefreshCardDetail();
			return true;
		}

		// Token: 0x060355E9 RID: 218601 RVA: 0x00CA45E5 File Offset: 0x00CA27E5
		public bool SelectCoreCardSlot()
		{
			if (!this.DeckSlotsPanel.SelectCoreCardSlot())
			{
				return false;
			}
			this.Data.CurCardId = new int?(this.DeckSlotsPanel.GetSelectedCardId());
			this.RefreshCardDetail();
			return true;
		}

		// Token: 0x060355EA RID: 218602 RVA: 0x00CA4618 File Offset: 0x00CA2818
		public void SelectNormalCardSlotByIndex(int index)
		{
			this.DeckSlotsPanel.SelectNormalCardSlotByIndex(index);
			this.Data.CurCardId = new int?(this.DeckSlotsPanel.GetSelectedCardId());
			this.RefreshCardDetail();
		}

		// Token: 0x060355EB RID: 218603 RVA: 0x00CA4648 File Offset: 0x00CA2848
		public void RefreshCardDetail()
		{
			int value = this.Data.CurCardId.Value;
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(value);
			Dictionary<int, int> dictionary = phantomBattleCardConfig.InitAttack();
			int attack = dictionary.ContainsKey(0) ? dictionary[0] : 0;
			int life = dictionary.ContainsKey(1) ? dictionary[1] : 0;
			int cost = phantomBattleCardConfig.Cost;
			this.Data.IsUnlock = new bool?(this.IsCardUnlock(value));
			this.RefreshDetailLockState();
			bool flag = this.Data.ShowLocked && PhantomArenaModel.Instance.IsCardOutlookUnlock(value);
			ECardFaceType cardFaceType = (flag && PhantomArenaModel.Instance.CheckCardSpineConfigValid(value)) ? ECardFaceType.Spine : ECardFaceType.Texture;
			DetailViewCardItemData detailViewCardItemData = new DetailViewCardItemData
			{
				IsLock = !this.Data.IsUnlock.Value,
				CardId = value,
				Cost = cost,
				Attack = attack,
				Life = life,
				Element = phantomBattleCardConfig.Element,
				CardFaceTexturePath = phantomBattleCardConfig.CardFaceTexture,
				CardSpineData = PhantomArenaModel.Instance.CreateCardSpineData(value),
				OutlookUnlocked = flag,
				CardFaceType = cardFaceType,
				CardType = (ECardType)phantomBattleCardConfig.Type
			};
			this.Data.CardItemData = detailViewCardItemData;
			this.CardItem.Refresh(detailViewCardItemData);
			int[] array = phantomBattleCardConfig.CardFactorId();
			CardDetailItemData detailViewDetailItemData = PhantomArenaModel.Instance.GetDetailViewDetailItemData(value, this.Data.DeckInfo);
			this.Data.DetailItemData = detailViewDetailItemData;
			this.DetailItem.Refresh(detailViewDetailItemData);
			List<int> list = new List<int>();
			list.AddRange(phantomBattleCardConfig.GetEntryIdListBytes());
			foreach (int factorConfigId in array)
			{
				int entryId = PhantomArenaConfig.Instance.GetPhantomBattleFactorConfig(factorConfigId).EntryId;
				if (entryId > 0 && !list.Contains(entryId))
				{
					list.Add(entryId);
				}
			}
			this.Data.EntryList = list;
			this.EntryDescLayoutItem.Refresh(list);
		}

		// Token: 0x060355EC RID: 218604 RVA: 0x00CA485E File Offset: 0x00CA2A5E
		protected bool IsCardUnlock(int cardId)
		{
			return !this.Data.ShowLocked || PhantomArenaModel.Instance.IsCardUnlock(cardId);
		}

		// Token: 0x060355ED RID: 218605 RVA: 0x00CA487C File Offset: 0x00CA2A7C
		protected void RefreshDetailLockState()
		{
			UpdateCardDetailLockStateContext context = new UpdateCardDetailLockStateContext
			{
				CardId = this.Data.CurCardId.Value,
				LockTipItem = base.GetItem(14),
				LockTipText = base.GetText(15),
				TipText = base.GetText(9),
				UnlockBtnItem = this.UnlockBtnItem,
				IsUnLocked = this.IsCardUnlock(this.Data.CurCardId.Value),
				ShowUnlockRedDotWhenCanUnlock = true
			};
			PhantomArenaController.Instance.UpdateCardDetailLockState(context);
		}

		// Token: 0x060355EE RID: 218606 RVA: 0x00CA490F File Offset: 0x00CA2B0F
		protected void RefreshCardItemLockState()
		{
			this.CardItem.RefreshIsLocked();
		}

		// Token: 0x060355EF RID: 218607 RVA: 0x00CA491C File Offset: 0x00CA2B1C
		public void RefreshLockState()
		{
			int? curCardId = this.Data.CurCardId;
			if (curCardId == null)
			{
				return;
			}
			this.Data.IsUnlock = new bool?(this.IsCardUnlock(curCardId.Value));
			this.Data.CardItemData.IsLock = !this.Data.IsUnlock.Value;
			this.RefreshDetailLockState();
			this.RefreshCardItemLockState();
			this.RefreshDeckSlotsPanel();
		}

		// Token: 0x060355F0 RID: 218608 RVA: 0x00CA4994 File Offset: 0x00CA2B94
		private void OnUnlockCardBtnClick(int _)
		{
			PhantomArenaController.Instance.CardUnlockRequest(this.Data.CurCardId.Value, null);
		}

		// Token: 0x060355F1 RID: 218609 RVA: 0x00CA49BF File Offset: 0x00CA2BBF
		private void OnCoreSlotItemToggleStateChange(DeckBuilderCardSlotItem item, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectCoreCardSlot();
			}
		}

		// Token: 0x060355F2 RID: 218610 RVA: 0x00CA49CC File Offset: 0x00CA2BCC
		private bool CanCoreSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return true;
		}

		// Token: 0x060355F3 RID: 218611 RVA: 0x00CA49CF File Offset: 0x00CA2BCF
		private void OnFieldSlotItemToggleStateChange(DeckBuilderCardSlotItem item, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectFieldCardSlot();
			}
		}

		// Token: 0x060355F4 RID: 218612 RVA: 0x00CA49DC File Offset: 0x00CA2BDC
		private bool CanFieldSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return true;
		}

		// Token: 0x060355F5 RID: 218613 RVA: 0x00CA49DF File Offset: 0x00CA2BDF
		private void OnNormalSlotItemToggleStateChange(DeckBuilderCardSlotItem item, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectNormalCardSlotByIndex(item.GridIndex);
			}
		}

		// Token: 0x060355F6 RID: 218614 RVA: 0x00CA49F1 File Offset: 0x00CA2BF1
		private bool CanNormalSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return true;
		}

		// Token: 0x060355F7 RID: 218615 RVA: 0x00CA49F4 File Offset: 0x00CA2BF4
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060355F8 RID: 218616 RVA: 0x00CA4A00 File Offset: 0x00CA2C00
		private void OnConfirmBtnClick(int _)
		{
			bool flag = false;
			DeckInfo deckInfo = this.Data.DeckInfo.DeepCopy();
			deckInfo.RemoveAllCard();
			foreach (DeckCardSlotInfo deckCardSlotInfo in this.Data.DeckInfo.GetCardSlotList())
			{
				if (!PhantomArenaModel.Instance.IsCardUnlock(deckCardSlotInfo.CardId))
				{
					flag = true;
				}
				else
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
					deckInfo.AddCard(context);
				}
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(flag ? EConfirmBoxConfigId.PhantomArenaRecommendDeckCardInsufficientConfirm : EConfirmBoxConfigId.PhantomArenaApplyRecommendDeckConfirm);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.Data.SaveRecommendDeckCallback(deckInfo);
				this.CloseMe(null);
			};
			bool isNew = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(this.Data.ActivityId);
			PhantomArenaController.Instance.OpenPhantomArenaConfirmBoxView(confirmBoxDataNew, isNew);
		}

		// Token: 0x060355F9 RID: 218617 RVA: 0x00CA4B58 File Offset: 0x00CA2D58
		private void OnPhantomArenaCardUnlock(int cardId)
		{
			this.RefreshLockState();
		}

		// Token: 0x060355FA RID: 218618 RVA: 0x00CA4B60 File Offset: 0x00CA2D60
		public void ShowEntry()
		{
			if (this.IsEntryShow)
			{
				return;
			}
			this.IsEntryShow = true;
			LevelSequencePlayer tipLevelSequencePlayer = this.TipLevelSequencePlayer;
			if (tipLevelSequencePlayer != null)
			{
				tipLevelSequencePlayer.PlayOrReplaySequenceByName("TipsShow", false, null);
			}
			this.RefreshEntryShowState();
		}

		// Token: 0x060355FB RID: 218619 RVA: 0x00CA4BA4 File Offset: 0x00CA2DA4
		public void HideEntry()
		{
			if (!this.IsEntryShow)
			{
				return;
			}
			this.IsEntryShow = false;
			LevelSequencePlayer tipLevelSequencePlayer = this.TipLevelSequencePlayer;
			if (tipLevelSequencePlayer == null)
			{
				return;
			}
			tipLevelSequencePlayer.PlayOrReplaySequenceByName("TipsHide", false, null);
		}

		// Token: 0x060355FC RID: 218620 RVA: 0x00CA4BE0 File Offset: 0x00CA2DE0
		public void RefreshEntryShowState()
		{
			base.GetItem(4).SetUIActive(this.IsEntryShow);
			base.GetItem(10).SetUIActive(this.IsEntryShow);
			base.GetItem(11).SetUIActive(this.IsEntryShow);
		}

		// Token: 0x060355FD RID: 218621 RVA: 0x00CA4C1A File Offset: 0x00CA2E1A
		private void OnSeqEnd(string seqName)
		{
			if (seqName == "TipsHide".ToString())
			{
				this.RefreshEntryShowState();
			}
		}

		// Token: 0x060355FE RID: 218622 RVA: 0x00CA4C34 File Offset: 0x00CA2E34
		private void ShowMaskButton()
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x060355FF RID: 218623 RVA: 0x00CA4C5C File Offset: 0x00CA2E5C
		private void HideMaskButton()
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x06035600 RID: 218624 RVA: 0x00CA4C84 File Offset: 0x00CA2E84
		private void OnCardDescBtnClick()
		{
			this.ShowEntry();
			this.ShowMaskButton();
		}

		// Token: 0x06035601 RID: 218625 RVA: 0x00CA4C92 File Offset: 0x00CA2E92
		private void OnMaskBtnClick()
		{
			this.HideEntry();
			this.HideMaskButton();
		}

		// Token: 0x0401C5DB RID: 116187
		private IPhantomArenaDeckDetailViewData Data;

		// Token: 0x0401C5DC RID: 116188
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401C5DD RID: 116189
		private DetailViewCardItem CardItem;

		// Token: 0x0401C5DE RID: 116190
		private CardDetailItem DetailItem;

		// Token: 0x0401C5DF RID: 116191
		private CardDetailEntryDescLayoutItem EntryDescLayoutItem;

		// Token: 0x0401C5E0 RID: 116192
		private DeckBuilderDeckSlotsPanel DeckSlotsPanel;

		// Token: 0x0401C5E1 RID: 116193
		private ButtonItem UnlockBtnItem;

		// Token: 0x0401C5E2 RID: 116194
		private ButtonItem ConfirmBtnItem;

		// Token: 0x0401C5E3 RID: 116195
		private LevelSequencePlayer TipLevelSequencePlayer;

		// Token: 0x0401C5E4 RID: 116196
		private bool IsEntryShow;

		// Token: 0x0200B2F4 RID: 45812
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040363BD RID: 222141
			public const int CaptionItem = 0;

			// Token: 0x040363BE RID: 222142
			public const int DeckSlotsPanelItem = 1;

			// Token: 0x040363BF RID: 222143
			public const int CardItem = 2;

			// Token: 0x040363C0 RID: 222144
			public const int DetailItem = 3;

			// Token: 0x040363C1 RID: 222145
			public const int EntryRootItem = 4;

			// Token: 0x040363C2 RID: 222146
			public const int EntryDescLayout = 5;

			// Token: 0x040363C3 RID: 222147
			public const int EntryDescLayoutItem = 6;

			// Token: 0x040363C4 RID: 222148
			public const int UnlockBtnItem = 7;

			// Token: 0x040363C5 RID: 222149
			public const int ConfirmBtnItem = 8;

			// Token: 0x040363C6 RID: 222150
			public const int TipText = 9;

			// Token: 0x040363C7 RID: 222151
			public const int EntryBgItem = 10;

			// Token: 0x040363C8 RID: 222152
			public const int EntryLineItem = 11;

			// Token: 0x040363C9 RID: 222153
			public const int CardDescBtn = 12;

			// Token: 0x040363CA RID: 222154
			public const int CardAndDetailRootItem = 13;

			// Token: 0x040363CB RID: 222155
			public const int LockTipItem = 14;

			// Token: 0x040363CC RID: 222156
			public const int LockTipText = 15;

			// Token: 0x040363CD RID: 222157
			public const int MaskButton = 16;
		}
	}
}
