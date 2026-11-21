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
	// Token: 0x02004E30 RID: 20016
	public class BossPilingTopItem : BattleVisibleChildView
	{
		// Token: 0x060325DD RID: 206301 RVA: 0x00E20CB0 File Offset: 0x00E1EEB0
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

		// Token: 0x060325DE RID: 206302 RVA: 0x00E20D56 File Offset: 0x00E1EF56
		protected override void OnStart()
		{
			base.OnStart();
			base.InitChildType(EBattleUiChild.BossPiling);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TryShow();
		}

		// Token: 0x060325DF RID: 206303 RVA: 0x00E20D7D File Offset: 0x00E1EF7D
		protected override void OnBeforeDestroy()
		{
			BattleUiControl.OffsetMissionAnchor(-1f);
			this.LevelSequencePlayer.Clear();
			this.LevelSequencePlayer = null;
			this.RemoveEvent();
			base.OnBeforeDestroy();
		}

		// Token: 0x060325E0 RID: 206304 RVA: 0x00E20DA7 File Offset: 0x00E1EFA7
		public override void ShowBattleVisibleChildView(bool checkVisible = false)
		{
			if (!this.IsPendingLoaded)
			{
				base.ShowBattleVisibleChildView(checkVisible);
			}
		}

		// Token: 0x060325E1 RID: 206305 RVA: 0x00E20DB8 File Offset: 0x00E1EFB8
		protected override UniTask OnShowAsyncImplementImplement()
		{
			BossPilingTopItem.<OnShowAsyncImplementImplement>d__9 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<BossPilingTopItem.<OnShowAsyncImplementImplement>d__9>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060325E2 RID: 206306 RVA: 0x00E20DFC File Offset: 0x00E1EFFC
		protected override UniTask OnHideAsyncImplementImplement()
		{
			BossPilingTopItem.<OnHideAsyncImplementImplement>d__10 <OnHideAsyncImplementImplement>d__;
			<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnHideAsyncImplementImplement>d__.<>4__this = this;
			<OnHideAsyncImplementImplement>d__.<>1__state = -1;
			<OnHideAsyncImplementImplement>d__.<>t__builder.Start<BossPilingTopItem.<OnHideAsyncImplementImplement>d__10>(ref <OnHideAsyncImplementImplement>d__);
			return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060325E3 RID: 206307 RVA: 0x00E20E40 File Offset: 0x00E1F040
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

		// Token: 0x060325E4 RID: 206308 RVA: 0x00E20E8C File Offset: 0x00E1F08C
		private void RemoveEvent()
		{
			if (EventSystem.Instance.Has(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading)))
			{
				EventSystem.Instance.Remove(EEventName.WorldDoneAndCloseLoading, new Action(this.OnWorldDoneAndCloseLoading));
			}
		}

		// Token: 0x060325E5 RID: 206309 RVA: 0x00E20EC7 File Offset: 0x00E1F0C7
		private void OnWorldDoneAndCloseLoading()
		{
			this.IsPendingLoaded = false;
			this.SeqStartState = 0;
			this.RemoveEvent();
			this.ShowInner();
		}

		// Token: 0x060325E6 RID: 206310 RVA: 0x00E20EE3 File Offset: 0x00E1F0E3
		private void ShowInner()
		{
			BattleUiChildViewData childViewData = BattleUiModel.Instance.ChildViewData;
			if (childViewData != null)
			{
				childViewData.SetChildVisible(EBattleUiVisibleReason.Default, EBattleUiChild.BossPiling, true, true, 0);
			}
			this.ShowBattleVisibleChildView(false);
		}

		// Token: 0x060325E7 RID: 206311 RVA: 0x00E20F08 File Offset: 0x00E1F108
		public void StartShow()
		{
			if (this.RootItem != null && !this.RootItem.bIsUIActive)
			{
				this.SeqStartState = 0;
			}
			this.TryShow();
		}

		// Token: 0x060325E8 RID: 206312 RVA: 0x00E20F2C File Offset: 0x00E1F12C
		public void EndShow()
		{
			this.SeqEndState = 0;
			base.SetVisible(0, false);
		}

		// Token: 0x060325E9 RID: 206313 RVA: 0x00E20F40 File Offset: 0x00E1F140
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

		// Token: 0x0401AB5D RID: 109405
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401AB5E RID: 109406
		private int SeqStartState;

		// Token: 0x0401AB5F RID: 109407
		private int SeqEndState = 1;

		// Token: 0x0401AB60 RID: 109408
		[Nullable(2)]
		public UiPanelBase ParentLogic;

		// Token: 0x0401AB61 RID: 109409
		private bool IsPendingLoaded;

		// Token: 0x0200ABDD RID: 43997
		private enum EChildType
		{
			// Token: 0x04035315 RID: 217877
			BtnCollection,
			// Token: 0x04035316 RID: 217878
			PnlMissionContent
		}
	}
}
