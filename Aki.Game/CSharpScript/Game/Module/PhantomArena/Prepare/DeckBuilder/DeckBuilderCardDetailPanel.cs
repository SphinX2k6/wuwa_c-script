using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x02005189 RID: 20873
	[NullableContext(2)]
	[Nullable(0)]
	public class DeckBuilderCardDetailPanel : UiPanelBase, IDeckBuilderCardInfoViewPanelSequencePlayer
	{
		// Token: 0x0603562C RID: 218668 RVA: 0x00CA50AC File Offset: 0x00CA32AC
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

		// Token: 0x0603562D RID: 218669 RVA: 0x00CA5174 File Offset: 0x00CA3374
		protected override UniTask OnBeforeStartAsync()
		{
			DeckBuilderCardDetailPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DeckBuilderCardDetailPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603562E RID: 218670 RVA: 0x00CA51B8 File Offset: 0x00CA33B8
		[NullableContext(1)]
		public void Refresh(IDeckBuilderCardDetailPanelData data)
		{
			this.Data = data;
			this.RefreshDetailLockState();
			this.CardItem.Refresh(data.CardItemData);
			this.DetailItem.Refresh(this.Data.DetailItemData);
			this.EntryDescLayoutItem.Refresh(this.Data.EntryIdList.ToList<int>());
		}

		// Token: 0x0603562F RID: 218671 RVA: 0x00CA5214 File Offset: 0x00CA3414
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

		// Token: 0x06035630 RID: 218672 RVA: 0x00CA540A File Offset: 0x00CA360A
		protected void RefreshCardItemLockState()
		{
			this.CardItem.RefreshIsLocked();
		}

		// Token: 0x06035631 RID: 218673 RVA: 0x00CA5417 File Offset: 0x00CA3617
		public void RefreshLockState()
		{
			this.RefreshDetailLockState();
			this.RefreshCardItemLockState();
		}

		// Token: 0x06035632 RID: 218674 RVA: 0x00CA5425 File Offset: 0x00CA3625
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

		// Token: 0x06035633 RID: 218675 RVA: 0x00CA5454 File Offset: 0x00CA3654
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

		// Token: 0x06035634 RID: 218676 RVA: 0x00CA5489 File Offset: 0x00CA3689
		private void OnUnlockCardBtnClick(int _)
		{
			PhantomArenaController.Instance.CardUnlockRequest(this.GetCardId(), null);
		}

		// Token: 0x06035635 RID: 218677 RVA: 0x00CA549C File Offset: 0x00CA369C
		public void PlaySwitchSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06035636 RID: 218678 RVA: 0x00CA54C4 File Offset: 0x00CA36C4
		public void PlayShowSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06035637 RID: 218679 RVA: 0x00CA54EB File Offset: 0x00CA36EB
		public int GetCardId()
		{
			return this.Data.CardItemData.CardId;
		}

		// Token: 0x06035638 RID: 218680 RVA: 0x00CA5500 File Offset: 0x00CA3700
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

		// Token: 0x0401C5F0 RID: 116208
		private IDeckBuilderCardDetailPanelData Data;

		// Token: 0x0401C5F1 RID: 116209
		public bool IsNewPhantomArenaActivity;

		// Token: 0x0401C5F2 RID: 116210
		private DetailViewCardItem CardItem;

		// Token: 0x0401C5F3 RID: 116211
		private CardDetailItem DetailItem;

		// Token: 0x0401C5F4 RID: 116212
		private CardDetailEntryDescLayoutItem EntryDescLayoutItem;

		// Token: 0x0401C5F5 RID: 116213
		private ButtonItem LeftBtnItem;

		// Token: 0x0401C5F6 RID: 116214
		private ButtonItem RightBtnItem;

		// Token: 0x0401C5F7 RID: 116215
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B2FB RID: 45819
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040363E4 RID: 222180
			public const int CardItem = 0;

			// Token: 0x040363E5 RID: 222181
			public const int DetailItem = 1;

			// Token: 0x040363E6 RID: 222182
			public const int EntryDescLayout = 2;

			// Token: 0x040363E7 RID: 222183
			public const int LeftBtnItem = 3;

			// Token: 0x040363E8 RID: 222184
			public const int RightBtnItem = 4;

			// Token: 0x040363E9 RID: 222185
			public const int TipText = 5;

			// Token: 0x040363EA RID: 222186
			public const int LockTipItem = 6;

			// Token: 0x040363EB RID: 222187
			public const int LockTipText = 7;
		}
	}
}
