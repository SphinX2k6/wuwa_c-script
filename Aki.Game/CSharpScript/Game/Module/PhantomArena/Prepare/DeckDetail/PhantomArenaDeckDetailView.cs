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
	// Token: 0x02004151 RID: 16721
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaDeckDetailView : UiViewBase
	{
		// Token: 0x0602A4DC RID: 173276 RVA: 0x00BF17FA File Offset: 0x00BEF9FA
		public PhantomArenaDeckDetailView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602A4DD RID: 173277 RVA: 0x00BF1804 File Offset: 0x00BEFA04
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

		// Token: 0x0602A4DE RID: 173278 RVA: 0x00BF19D8 File Offset: 0x00BEFBD8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaDeckDetailView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaDeckDetailView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A4DF RID: 173279 RVA: 0x00BF1A1B File Offset: 0x00BEFC1B
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
		}

		// Token: 0x0602A4E0 RID: 173280 RVA: 0x00BF1A39 File Offset: 0x00BEFC39
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPhantomArenaCardUnlock, new Action<int>(this.OnPhantomArenaCardUnlock));
		}

		// Token: 0x0602A4E1 RID: 173281 RVA: 0x00BF1A58 File Offset: 0x00BEFC58
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

		// Token: 0x0602A4E2 RID: 173282 RVA: 0x00BF1B58 File Offset: 0x00BEFD58
		public void SelectFirstCardSlot()
		{
			if (this.SelectCoreCardSlot())
			{
				return;
			}
			this.SelectNormalCardSlotByIndex(0);
		}

		// Token: 0x0602A4E3 RID: 173283 RVA: 0x00BF1B6A File Offset: 0x00BEFD6A
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

		// Token: 0x0602A4E4 RID: 173284 RVA: 0x00BF1B9D File Offset: 0x00BEFD9D
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

		// Token: 0x0602A4E5 RID: 173285 RVA: 0x00BF1BD0 File Offset: 0x00BEFDD0
		public void SelectNormalCardSlotByIndex(int index)
		{
			this.DeckSlotsPanel.SelectNormalCardSlotByIndex(index);
			this.Data.CurCardId = new int?(this.DeckSlotsPanel.GetSelectedCardId());
			this.RefreshCardDetail();
		}

		// Token: 0x0602A4E6 RID: 173286 RVA: 0x00BF1C00 File Offset: 0x00BEFE00
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

		// Token: 0x0602A4E7 RID: 173287 RVA: 0x00BF1E16 File Offset: 0x00BF0016
		protected bool IsCardUnlock(int cardId)
		{
			return !this.Data.ShowLocked || PhantomArenaModel.Instance.IsCardUnlock(cardId);
		}

		// Token: 0x0602A4E8 RID: 173288 RVA: 0x00BF1E34 File Offset: 0x00BF0034
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

		// Token: 0x0602A4E9 RID: 173289 RVA: 0x00BF1EC7 File Offset: 0x00BF00C7
		protected void RefreshCardItemLockState()
		{
			this.CardItem.RefreshIsLocked();
		}

		// Token: 0x0602A4EA RID: 173290 RVA: 0x00BF1ED4 File Offset: 0x00BF00D4
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

		// Token: 0x0602A4EB RID: 173291 RVA: 0x00BF1F4C File Offset: 0x00BF014C
		private void OnUnlockCardBtnClick(int _)
		{
			PhantomArenaController.Instance.CardUnlockRequest(this.Data.CurCardId.Value, null);
		}

		// Token: 0x0602A4EC RID: 173292 RVA: 0x00BF1F77 File Offset: 0x00BF0177
		private void OnCoreSlotItemToggleStateChange(DeckBuilderCardSlotItem item, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectCoreCardSlot();
			}
		}

		// Token: 0x0602A4ED RID: 173293 RVA: 0x00BF1F84 File Offset: 0x00BF0184
		private bool CanCoreSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return true;
		}

		// Token: 0x0602A4EE RID: 173294 RVA: 0x00BF1F87 File Offset: 0x00BF0187
		private void OnFieldSlotItemToggleStateChange(DeckBuilderCardSlotItem item, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectFieldCardSlot();
			}
		}

		// Token: 0x0602A4EF RID: 173295 RVA: 0x00BF1F94 File Offset: 0x00BF0194
		private bool CanFieldSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return true;
		}

		// Token: 0x0602A4F0 RID: 173296 RVA: 0x00BF1F97 File Offset: 0x00BF0197
		private void OnNormalSlotItemToggleStateChange(DeckBuilderCardSlotItem item, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.SelectNormalCardSlotByIndex(item.GridIndex);
			}
		}

		// Token: 0x0602A4F1 RID: 173297 RVA: 0x00BF1FA9 File Offset: 0x00BF01A9
		private bool CanNormalSlotItemToggleChange(DeckBuilderCardSlotItem item)
		{
			return true;
		}

		// Token: 0x0602A4F2 RID: 173298 RVA: 0x00BF1FAC File Offset: 0x00BF01AC
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602A4F3 RID: 173299 RVA: 0x00BF1FB8 File Offset: 0x00BF01B8
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

		// Token: 0x0602A4F4 RID: 173300 RVA: 0x00BF2110 File Offset: 0x00BF0310
		private void OnPhantomArenaCardUnlock(int cardId)
		{
			this.RefreshLockState();
		}

		// Token: 0x0602A4F5 RID: 173301 RVA: 0x00BF2118 File Offset: 0x00BF0318
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

		// Token: 0x0602A4F6 RID: 173302 RVA: 0x00BF215C File Offset: 0x00BF035C
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

		// Token: 0x0602A4F7 RID: 173303 RVA: 0x00BF2198 File Offset: 0x00BF0398
		public void RefreshEntryShowState()
		{
			base.GetItem(4).SetUIActive(this.IsEntryShow);
			base.GetItem(10).SetUIActive(this.IsEntryShow);
			base.GetItem(11).SetUIActive(this.IsEntryShow);
		}

		// Token: 0x0602A4F8 RID: 173304 RVA: 0x00BF21D2 File Offset: 0x00BF03D2
		private void OnSeqEnd(string seqName)
		{
			if (seqName == "TipsHide".ToString())
			{
				this.RefreshEntryShowState();
			}
		}

		// Token: 0x0602A4F9 RID: 173305 RVA: 0x00BF21EC File Offset: 0x00BF03EC
		private void ShowMaskButton()
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0602A4FA RID: 173306 RVA: 0x00BF2214 File Offset: 0x00BF0414
		private void HideMaskButton()
		{
			base.GetButton(16).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0602A4FB RID: 173307 RVA: 0x00BF223C File Offset: 0x00BF043C
		private void OnCardDescBtnClick()
		{
			this.ShowEntry();
			this.ShowMaskButton();
		}

		// Token: 0x0602A4FC RID: 173308 RVA: 0x00BF224A File Offset: 0x00BF044A
		private void OnMaskBtnClick()
		{
			this.HideEntry();
			this.HideMaskButton();
		}

		// Token: 0x04017010 RID: 94224
		private IPhantomArenaDeckDetailViewData Data;

		// Token: 0x04017011 RID: 94225
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017012 RID: 94226
		private DetailViewCardItem CardItem;

		// Token: 0x04017013 RID: 94227
		private CardDetailItem DetailItem;

		// Token: 0x04017014 RID: 94228
		private CardDetailEntryDescLayoutItem EntryDescLayoutItem;

		// Token: 0x04017015 RID: 94229
		private DeckBuilderDeckSlotsPanel DeckSlotsPanel;

		// Token: 0x04017016 RID: 94230
		private ButtonItem UnlockBtnItem;

		// Token: 0x04017017 RID: 94231
		private ButtonItem ConfirmBtnItem;

		// Token: 0x04017018 RID: 94232
		private LevelSequencePlayer TipLevelSequencePlayer;

		// Token: 0x04017019 RID: 94233
		private bool IsEntryShow;

		// Token: 0x02009D2D RID: 40237
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E12 RID: 200210
			public const int CaptionItem = 0;

			// Token: 0x04030E13 RID: 200211
			public const int DeckSlotsPanelItem = 1;

			// Token: 0x04030E14 RID: 200212
			public const int CardItem = 2;

			// Token: 0x04030E15 RID: 200213
			public const int DetailItem = 3;

			// Token: 0x04030E16 RID: 200214
			public const int EntryRootItem = 4;

			// Token: 0x04030E17 RID: 200215
			public const int EntryDescLayout = 5;

			// Token: 0x04030E18 RID: 200216
			public const int EntryDescLayoutItem = 6;

			// Token: 0x04030E19 RID: 200217
			public const int UnlockBtnItem = 7;

			// Token: 0x04030E1A RID: 200218
			public const int ConfirmBtnItem = 8;

			// Token: 0x04030E1B RID: 200219
			public const int TipText = 9;

			// Token: 0x04030E1C RID: 200220
			public const int EntryBgItem = 10;

			// Token: 0x04030E1D RID: 200221
			public const int EntryLineItem = 11;

			// Token: 0x04030E1E RID: 200222
			public const int CardDescBtn = 12;

			// Token: 0x04030E1F RID: 200223
			public const int CardAndDetailRootItem = 13;

			// Token: 0x04030E20 RID: 200224
			public const int LockTipItem = 14;

			// Token: 0x04030E21 RID: 200225
			public const int LockTipText = 15;

			// Token: 0x04030E22 RID: 200226
			public const int MaskButton = 16;
		}
	}
}
