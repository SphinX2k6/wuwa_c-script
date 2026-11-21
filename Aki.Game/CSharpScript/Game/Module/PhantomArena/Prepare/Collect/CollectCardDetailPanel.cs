using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Common.CardDetail;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Collect
{
	// Token: 0x0200417F RID: 16767
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectCardDetailPanel : UiPanelBase
	{
		// Token: 0x0602A7A6 RID: 173990 RVA: 0x00BFC3E8 File Offset: 0x00BFA5E8
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

		// Token: 0x0602A7A7 RID: 173991 RVA: 0x00BFC4B0 File Offset: 0x00BFA6B0
		protected override UniTask OnBeforeStartAsync()
		{
			CollectCardDetailPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CollectCardDetailPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A7A8 RID: 173992 RVA: 0x00BFC4F3 File Offset: 0x00BFA6F3
		protected override void OnStart()
		{
			this.BtnUnlock.SetFunction(new Action<int>(this.OnClickUnlock));
		}

		// Token: 0x0602A7A9 RID: 173993 RVA: 0x00BFC50C File Offset: 0x00BFA70C
		public void Refresh(int cardId)
		{
			this.CardId = cardId;
			this.RefreshCard();
			this.RefreshDetail();
			this.RefreshEntry();
			this.RefreshBtn();
		}

		// Token: 0x0602A7AA RID: 173994 RVA: 0x00BFC530 File Offset: 0x00BFA730
		private void RefreshCard()
		{
			DetailViewCardItemData detailViewCardData = PhantomArenaModel.Instance.GetDetailViewCardData(this.CardId);
			this.CardItem.Refresh(detailViewCardData);
		}

		// Token: 0x0602A7AB RID: 173995 RVA: 0x00BFC55C File Offset: 0x00BFA75C
		private void RefreshDetail()
		{
			CardDetailItemData detailViewDetailItemData = PhantomArenaModel.Instance.GetDetailViewDetailItemData(this.CardId, null);
			this.DetailItem.Refresh(detailViewDetailItemData);
		}

		// Token: 0x0602A7AC RID: 173996 RVA: 0x00BFC588 File Offset: 0x00BFA788
		private void RefreshEntry()
		{
			List<int> detailViewEntryData = PhantomArenaModel.Instance.GetDetailViewEntryData(this.CardId);
			this.EntryItem.Refresh(detailViewEntryData);
		}

		// Token: 0x0602A7AD RID: 173997 RVA: 0x00BFC5B4 File Offset: 0x00BFA7B4
		private void RefreshBtn()
		{
			UpdateCardDetailLockStateContext context = new UpdateCardDetailLockStateContext
			{
				CardId = this.CardId,
				LockTipItem = base.GetItem(6),
				LockTipText = base.GetText(7),
				TipText = base.GetText(5),
				UnlockBtnItem = this.BtnUnlock,
				IsUnLocked = PhantomArenaModel.Instance.IsCardUnlock(this.CardId),
				ShowUnlockRedDotWhenCanUnlock = false
			};
			PhantomArenaController.Instance.UpdateCardDetailLockState(context);
			this.BtnConfirm.SetActive(false);
		}

		// Token: 0x0602A7AE RID: 173998 RVA: 0x00BFC63A File Offset: 0x00BFA83A
		private void OnClickUnlock(int _)
		{
			PhantomArenaController.Instance.CardUnlockRequest(this.CardId, null);
		}

		// Token: 0x0602A7AF RID: 173999 RVA: 0x00BFC650 File Offset: 0x00BFA850
		public void PlaySwitchSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0602A7B0 RID: 174000 RVA: 0x00BFC678 File Offset: 0x00BFA878
		public void PlayShowSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x04017102 RID: 94466
		private int CardId = -1;

		// Token: 0x04017103 RID: 94467
		public bool IsNewPhantomArenaActivity;

		// Token: 0x04017104 RID: 94468
		private ButtonItem BtnConfirm;

		// Token: 0x04017105 RID: 94469
		private ButtonItem BtnUnlock;

		// Token: 0x04017106 RID: 94470
		private DetailViewCardItem CardItem;

		// Token: 0x04017107 RID: 94471
		private CardDetailItem DetailItem;

		// Token: 0x04017108 RID: 94472
		private CardDetailEntryDescLayoutItem EntryItem;

		// Token: 0x04017109 RID: 94473
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x02009D6E RID: 40302
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030F59 RID: 200537
			public const int CardItem = 0;

			// Token: 0x04030F5A RID: 200538
			public const int DetailItem = 1;

			// Token: 0x04030F5B RID: 200539
			public const int EntryDescLayout = 2;

			// Token: 0x04030F5C RID: 200540
			public const int LeftBtnItem = 3;

			// Token: 0x04030F5D RID: 200541
			public const int RightBtnItem = 4;

			// Token: 0x04030F5E RID: 200542
			public const int TipText = 5;

			// Token: 0x04030F5F RID: 200543
			public const int LockTipItem = 6;

			// Token: 0x04030F60 RID: 200544
			public const int LockTipText = 7;
		}
	}
}
