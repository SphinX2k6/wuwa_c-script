using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BossPiling;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E4B RID: 24139
	public class BossPilingTopItem : BattleVisibleChildView
	{
		// Token: 0x0603D64D RID: 251469 RVA: 0x00ECF740 File Offset: 0x00ECD940
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickCollection));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603D64E RID: 251470 RVA: 0x00ECF7E6 File Offset: 0x00ECD9E6
		protected override void OnStart()
		{
			base.OnStart();
			base.InitChildType(EBattleUiChild.BossPiling);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TryShow();
		}

		// Token: 0x0603D64F RID: 251471 RVA: 0x00ECF80D File Offset: 0x00ECDA0D
		protected override void OnBeforeDestroy()
		{
			BattleUiControl.OffsetMissionAnchor(-1f);
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			this.RemoveEvent();
			base.OnBeforeDestroy();
		}

		// Token: 0x0603D650 RID: 251472 RVA: 0x00ECF837 File Offset: 0x00ECDA37
		public override void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			if (!this.IsPendingLoaded)
			{
				base.ShowBattleVisibleChildView(checkVisible);
			}
		}

		// Token: 0x0603D651 RID: 251473 RVA: 0x00ECF848 File Offset: 0x00ECDA48
		protected override UniTask OnShowAsyncImplementImplement()
		{
			BossPilingTopItem.<OnShowAsyncImplementImplement>d__9 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<BossPilingTopItem.<OnShowAsyncImplementImplement>d__9>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603D652 RID: 251474 RVA: 0x00ECF88C File Offset: 0x00ECDA8C
		protected override UniTask OnHideAsyncImplementImplement()
		{
			BossPilingTopItem.<OnHideAsyncImplementImplement>d__10 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<BossPilingTopItem.<OnHideAsyncImplementImplement>d__10>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603D653 RID: 251475 RVA: 0x00ECF8D0 File Offset: 0x00ECDAD0
		private void TryShow()
		{
			if (this.IsPendingLoaded)
			{
				return;
			}
			if (GameModeModel.Instance.Loading)
			{
				this.IsPendingLoaded = true;
				EventSystem.Instance.Add(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
				return;
			}
			this.ShowInner();
		}

		// Token: 0x0603D654 RID: 251476 RVA: 0x00ECF91C File Offset: 0x00ECDB1C
		private void RemoveEvent()
		{
			if (EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			}
		}

		// Token: 0x0603D655 RID: 251477 RVA: 0x00ECF957 File Offset: 0x00ECDB57
		private void OnWorldDoneAndCloseLoading()
		{
			this.IsPendingLoaded = false;
			this.SeqStartState = 0;
			this.RemoveEvent();
			this.ShowInner();
		}

		// Token: 0x0603D656 RID: 251478 RVA: 0x00ECF973 File Offset: 0x00ECDB73
		private void ShowInner()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BossPiling, true, true, 0);
			}
			this.ShowBattleVisibleChildView(false);
		}

		// Token: 0x0603D657 RID: 251479 RVA: 0x00ECF998 File Offset: 0x00ECDB98
		public void StartShow()
		{
			if (this.RootItem != null && !this.RootItem.bIsUIActive)
			{
				this.SeqStartState = 0;
			}
			this.TryShow();
		}

		// Token: 0x0603D658 RID: 251480 RVA: 0x00ECF9BC File Offset: 0x00ECDBBC
		public void EndShow()
		{
			this.SeqEndState = 0;
			base.SetVisible(0, false);
		}

		// Token: 0x0603D659 RID: 251481 RVA: 0x00ECF9D0 File Offset: 0x00ECDBD0
		private void OnClickCollection()
		{
			InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			if (instanceDungeon == null || !BossPilingModel.Instance.CheckIsBossPiling())
			{
				return;
			}
			int item = BossPilingModel.Instance.GetLevelIdAndHalfByInstId(instanceDungeon.Value.Id).Item1;
			BossPilingBuffViewInfo param = new BossPilingBuffViewInfo
			{
				LevelId = item,
				InGame = true
			};
			UiManager.Instance.OpenView(EUiViewName.BossPilingBuffView, param, null);
		}

		// Token: 0x04020096 RID: 131222
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04020097 RID: 131223
		private int SeqStartState;

		// Token: 0x04020098 RID: 131224
		private int SeqEndState = 1;

		// Token: 0x04020099 RID: 131225
		[Nullable(2)]
		public UiPanelBase ParentLogic;

		// Token: 0x0402009A RID: 131226
		private bool IsPendingLoaded;

		// Token: 0x0200C1CE RID: 49614
		private enum EChildType
		{
			// Token: 0x0403A923 RID: 239907
			BtnCollection,
			// Token: 0x0403A924 RID: 239908
			PnlMissionContent
		}
	}
}
