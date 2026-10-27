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
	// Token: 0x020051AF RID: 20911
	[NullableContext(1)]
	[Nullable(0)]
	public class CollectCardDetailPanel : UiPanelBase
	{
		// Token: 0x060358AB RID: 219307 RVA: 0x00CAEDAC File Offset: 0x00CACFAC
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

		// Token: 0x060358AC RID: 219308 RVA: 0x00CAEE74 File Offset: 0x00CAD074
		protected override UniTask OnBeforeStartAsync()
		{
			CollectCardDetailPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CollectCardDetailPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060358AD RID: 219309 RVA: 0x00CAEEB7 File Offset: 0x00CAD0B7
		protected override void OnStart()
		{
			this.BtnUnlock.SetFunction(new Action<int>(this.OnClickUnlock));
		}

		// Token: 0x060358AE RID: 219310 RVA: 0x00CAEED0 File Offset: 0x00CAD0D0
		public void Refresh(int cardId)
		{
			this.CardId = cardId;
			this.RefreshCard();
			this.RefreshDetail();
			this.RefreshEntry();
			this.RefreshBtn();
		}

		// Token: 0x060358AF RID: 219311 RVA: 0x00CAEEF4 File Offset: 0x00CAD0F4
		private void RefreshCard()
		{
			DetailViewCardItemData detailViewCardData = PhantomArenaModel.Instance.GetDetailViewCardData(this.CardId);
			this.CardItem.Refresh(detailViewCardData);
		}

		// Token: 0x060358B0 RID: 219312 RVA: 0x00CAEF20 File Offset: 0x00CAD120
		private void RefreshDetail()
		{
			CardDetailItemData detailViewDetailItemData = PhantomArenaModel.Instance.GetDetailViewDetailItemData(this.CardId, null);
			this.DetailItem.Refresh(detailViewDetailItemData);
		}

		// Token: 0x060358B1 RID: 219313 RVA: 0x00CAEF4C File Offset: 0x00CAD14C
		private void RefreshEntry()
		{
			List<int> detailViewEntryData = PhantomArenaModel.Instance.GetDetailViewEntryData(this.CardId);
			this.EntryItem.Refresh(detailViewEntryData);
		}

		// Token: 0x060358B2 RID: 219314 RVA: 0x00CAEF78 File Offset: 0x00CAD178
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

		// Token: 0x060358B3 RID: 219315 RVA: 0x00CAEFFE File Offset: 0x00CAD1FE
		private void OnClickUnlock(int _)
		{
			PhantomArenaController.Instance.CardUnlockRequest(this.CardId, null);
		}

		// Token: 0x060358B4 RID: 219316 RVA: 0x00CAF014 File Offset: 0x00CAD214
		public void PlaySwitchSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x060358B5 RID: 219317 RVA: 0x00CAF03C File Offset: 0x00CAD23C
		public void PlayShowSequence()
		{
			this.SequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x0401C6CD RID: 116429
		private int CardId = -1;

		// Token: 0x0401C6CE RID: 116430
		public bool IsNewPhantomArenaActivity;

		// Token: 0x0401C6CF RID: 116431
		private ButtonItem BtnConfirm;

		// Token: 0x0401C6D0 RID: 116432
		private ButtonItem BtnUnlock;

		// Token: 0x0401C6D1 RID: 116433
		private DetailViewCardItem CardItem;

		// Token: 0x0401C6D2 RID: 116434
		private CardDetailItem DetailItem;

		// Token: 0x0401C6D3 RID: 116435
		private CardDetailEntryDescLayoutItem EntryItem;

		// Token: 0x0401C6D4 RID: 116436
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B336 RID: 45878
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036506 RID: 222470
			public const int CardItem = 0;

			// Token: 0x04036507 RID: 222471
			public const int DetailItem = 1;

			// Token: 0x04036508 RID: 222472
			public const int EntryDescLayout = 2;

			// Token: 0x04036509 RID: 222473
			public const int LeftBtnItem = 3;

			// Token: 0x0403650A RID: 222474
			public const int RightBtnItem = 4;

			// Token: 0x0403650B RID: 222475
			public const int TipText = 5;

			// Token: 0x0403650C RID: 222476
			public const int LockTipItem = 6;

			// Token: 0x0403650D RID: 222477
			public const int LockTipText = 7;
		}
	}
}
