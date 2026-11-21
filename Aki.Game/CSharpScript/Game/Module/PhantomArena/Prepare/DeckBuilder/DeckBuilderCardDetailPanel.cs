using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02004159 RID: 16729
	[NullableContext(2)]
	[Nullable(0)]
	public class DeckBuilderCardDetailPanel : UiPanelBase, IDeckBuilderCardInfoViewPanelSequencePlayer
	{
		// Token: 0x0602A527 RID: 173351 RVA: 0x00BF2664 File Offset: 0x00BF0864
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText))
			};
		}

		// Token: 0x0602A528 RID: 173352 RVA: 0x00BF272C File Offset: 0x00BF092C
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardDetailPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardDetailPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A529 RID: 173353 RVA: 0x00BF2770 File Offset: 0x00BF0970
		[NullableContext(1)]
		public void Refresh(IDeckBuilderCardDetailPanelData data)
		{
			this.Data = data;
			this.RefreshDetailLockState();
			this.CardItem.Refresh(data.CardItemData);
			this.DetailItem.Refresh(this.Data.DetailItemData);
			this.EntryDescLayoutItem.Refresh(this.Data.EntryIdList);
		}

		// Token: 0x0602A52A RID: 173354 RVA: 0x00BF27C8 File Offset: 0x00BF09C8
		protected void RefreshDetailLockState()
		{
			IDeckBuilderCardDetailPanelData data = this.Data;
			if (((data != null) ? data.DeckInfo : null) == null)
			{
				this.LeftBtnItem.SetActive(false);
				this.RightBtnItem.SetActive(false);
				base.GetText(5).SetUIActive(false);
				base.GetItem(6).SetUIActive(false);
				return;
			}
			if (this.Data.IsCardUnlocked)
			{
				this.LeftBtnItem.SetActive(true);
				this.LeftBtnItem.SetFunction(new Action<int>(this.OnRemoveCardBtnClick));
				this.LeftBtnItem.SetLocalTextNew("PhantomBattle_1007", Array.Empty<object>());
				this.RightBtnItem.SetActive(true);
				this.RightBtnItem.SetFunction(new Action<int>(this.OnAddCardBtnClick));
				this.RightBtnItem.SetLocalTextNew("PhantomBattle_1008", Array.Empty<object>());
				base.GetText(5).SetUIActive(true);
				base.GetItem(6).SetUIActive(false);
				DeckInfo deckInfo = this.Data.DeckInfo;
				int cardId = this.GetCardId();
				int cardCount = deckInfo.GetCardCount(cardId);
				int num = this.Data.CardLimit.Value - cardCount;
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "PhantomBattle_1009", new <>z__ReadOnlySingleElementList<object>(num));
				bool enableClick = cardCount > 0;
				this.LeftBtnItem.SetEnableClick(enableClick);
				bool enableClick2 = num > 0;
				this.RightBtnItem.SetEnableClick(enableClick2);
				return;
			}
			this.RightBtnItem.SetFunction(new Action<int>(this.OnUnlockCardBtnClick));
			this.LeftBtnItem.SetActive(false);
			UpdateCardDetailLockStateContext context = new UpdateCardDetailLockStateContext
			{
				CardId = this.GetCardId(),
				LockTipItem = base.GetItem(6),
				LockTipText = base.GetText(7),
				TipText = base.GetText(5),
				UnlockBtnItem = this.RightBtnItem,
				IsUnLocked = PhantomArenaModel.Instance.IsCardUnlock(this.GetCardId()),
				ShowUnlockRedDotWhenCanUnlock = false
			};
			PhantomArenaController.Instance.UpdateCardDetailLockState(context);
		}

		// Token: 0x0602A52B RID: 173355 RVA: 0x00BF29BE File Offset: 0x00BF0BBE
		protected void RefreshCardItemLockState()
		{
			this.CardItem.RefreshIsLocked();
		}

		// Token: 0x0602A52C RID: 173356 RVA: 0x00BF29CB File Offset: 0x00BF0BCB
		public void RefreshLockState()
		{
			this.RefreshDetailLockState();
			this.RefreshCardItemLockState();
		}

		// Token: 0x0602A52D RID: 173357 RVA: 0x00BF29D9 File Offset: 0x00BF0BD9
		private void OnAddCardBtnClick(int _)
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.AddCardToDeck == null)
			{
				return;
			}
			this.Data.AddCardToDeck();
			this.RefreshDetailLockState();
		}

		// Token: 0x0602A52E RID: 173358 RVA: 0x00BF2A08 File Offset: 0x00BF0C08
		private void OnRemoveCardBtnClick(int _)
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.Data.RemoveCardFromDeck == null)
			{
				return;
			}
			Action removeCardFromDeck = this.Data.RemoveCardFromDeck;
			if (removeCardFromDeck != null)
			{
				removeCardFromDeck();
			}
			this.RefreshDetailLockState();
		}

		// Token: 0x0602A52F RID: 173359 RVA: 0x00BF2A3D File Offset: 0x00BF0C3D
		private void OnUnlockCardBtnClick(int _)
		{
			PhantomArenaController.Instance.CardUnlockRequest(this.GetCardId(), null);
		}

		// Token: 0x0602A530 RID: 173360 RVA: 0x00BF2A50 File Offset: 0x00BF0C50
		public void PlaySwitchSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0602A531 RID: 173361 RVA: 0x00BF2A78 File Offset: 0x00BF0C78
		public void PlayShowSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x0602A532 RID: 173362 RVA: 0x00BF2A9F File Offset: 0x00BF0C9F
		public int GetCardId()
		{
			return this.Data.CardItemData.CardId;
		}

		// Token: 0x0602A533 RID: 173363 RVA: 0x00BF2AB4 File Offset: 0x00BF0CB4
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
			UUIItem guideUiItem = base.GetGuideUiItem("0");
			if (guideUiItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}

		// Token: 0x04017025 RID: 94245
		private IDeckBuilderCardDetailPanelData Data;

		// Token: 0x04017026 RID: 94246
		public bool IsNewPhantomArenaActivity;

		// Token: 0x04017027 RID: 94247
		private DetailViewCardItem CardItem;

		// Token: 0x04017028 RID: 94248
		private CardDetailItem DetailItem;

		// Token: 0x04017029 RID: 94249
		private CardDetailEntryDescLayoutItem EntryDescLayoutItem;

		// Token: 0x0401702A RID: 94250
		private ButtonItem LeftBtnItem;

		// Token: 0x0401702B RID: 94251
		private ButtonItem RightBtnItem;

		// Token: 0x0401702C RID: 94252
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x02009D34 RID: 40244
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E39 RID: 200249
			public const int CardItem = 0;

			// Token: 0x04030E3A RID: 200250
			public const int DetailItem = 1;

			// Token: 0x04030E3B RID: 200251
			public const int EntryDescLayout = 2;

			// Token: 0x04030E3C RID: 200252
			public const int LeftBtnItem = 3;

			// Token: 0x04030E3D RID: 200253
			public const int RightBtnItem = 4;

			// Token: 0x04030E3E RID: 200254
			public const int TipText = 5;

			// Token: 0x04030E3F RID: 200255
			public const int LockTipItem = 6;

			// Token: 0x04030E40 RID: 200256
			public const int LockTipText = 7;
		}
	}
}
