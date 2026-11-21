using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.InstanceDungeon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02004AAF RID: 19119
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenceReviveView : UiTickViewBase
	{
		// Token: 0x0602FD67 RID: 195943 RVA: 0x00D5A0C4 File Offset: 0x00D582C4
		public TowerDefenceReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FD68 RID: 195944 RVA: 0x00D5A0D0 File Offset: 0x00D582D0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickQuitBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FD69 RID: 195945 RVA: 0x00D5A21C File Offset: 0x00D5841C
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenceReviveView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenceReviveView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FD6A RID: 195946 RVA: 0x00D5A260 File Offset: 0x00D58460
		protected override void OnBeforeShow()
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			base.GetButton(7).RootUIComp.Get().SetUIActive(true);
			base.GetButton(9).RootUIComp.Get().SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x0602FD6B RID: 195947 RVA: 0x00D5A2E3 File Offset: 0x00D584E3
		protected override void OnStart()
		{
			this.RefreshCountDown();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "TowerDefence_dead2", Array.Empty<object>());
		}

		// Token: 0x0602FD6C RID: 195948 RVA: 0x00D5A308 File Offset: 0x00D58508
		protected override void OnBeforeDestroy()
		{
			TowerDefenseModel.Instance.SelfReviveTargetTimestampForUi = null;
			if (this.ConfirmBoxViewIdCache != null)
			{
				ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(this.ConfirmBoxViewIdCache.Value, null);
			}
			this.ConfirmBoxViewIdCache = null;
		}

		// Token: 0x0602FD6D RID: 195949 RVA: 0x00D5A354 File Offset: 0x00D58554
		protected override void OnTick(float delta)
		{
			this.RefreshCountDown();
		}

		// Token: 0x0602FD6E RID: 195950 RVA: 0x00D5A35C File Offset: 0x00D5855C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TowerDefenseOnTowerDefenseBattleEndNotify, new Action(this.HandleOnTowerDefenceBattleEndNotify));
		}

		// Token: 0x0602FD6F RID: 195951 RVA: 0x00D5A37A File Offset: 0x00D5857A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TowerDefenseOnTowerDefenseBattleEndNotify, new Action(this.HandleOnTowerDefenceBattleEndNotify));
		}

		// Token: 0x0602FD70 RID: 195952 RVA: 0x00D5A398 File Offset: 0x00D58598
		private void RefreshCountDown()
		{
			long? selfReviveTargetTimestampForUi = TowerDefenseModel.Instance.SelfReviveTargetTimestampForUi;
			if (selfReviveTargetTimestampForUi == null)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "TowerDefence_dead1", Array.Empty<object>());
				return;
			}
			double serverStopTimeStamp = TimeUtil.Instance.GetServerStopTimeStamp();
			if (serverStopTimeStamp <= (double)selfReviveTargetTimestampForUi.Value)
			{
				UUIText text = base.GetText(0);
				if (text != null)
				{
					text.SetUIActive(true);
				}
				CommonDefine.ICountDown remainTimeDataFormat = TimeUtil.Instance.GetRemainTimeDataFormat3(0.5 + TimeUtil.Instance.Millisecond * ((double)selfReviveTargetTimestampForUi.Value - serverStopTimeStamp));
				LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "ReviveCountdownTime", new <>z__ReadOnlySingleElementList<object>(remainTimeDataFormat.CountDownText));
				return;
			}
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetUIActive(false);
		}

		// Token: 0x0602FD71 RID: 195953 RVA: 0x00D5A45C File Offset: 0x00D5865C
		private void OnClickQuitBtn()
		{
			if (SceneTeamModel.Instance.IsAllDid())
			{
				InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.OnlineQuitInstance);
			confirmBoxDataNew.FunctionMap[1] = new Action(this.CancelCallback);
			confirmBoxDataNew.FunctionMap[2] = new Action(this.ConfirmCallback);
			confirmBoxDataNew.SetCloseFunction(new Action(this.CloseCallback));
			confirmBoxDataNew.FinishOpenFunction = new TOpenViewCallBack(this.FinishOpenCallback);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0602FD72 RID: 195954 RVA: 0x00D5A4ED File Offset: 0x00D586ED
		private void CancelCallback()
		{
		}

		// Token: 0x0602FD73 RID: 195955 RVA: 0x00D5A4EF File Offset: 0x00D586EF
		private void ConfirmCallback()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		}

		// Token: 0x0602FD74 RID: 195956 RVA: 0x00D5A500 File Offset: 0x00D58700
		private void FinishOpenCallback(bool success, int viewId)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenceReviveView) && success)
			{
				this.ConfirmBoxViewIdCache = new int?(viewId);
				return;
			}
			ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(viewId, null);
		}

		// Token: 0x0602FD75 RID: 195957 RVA: 0x00D5A52E File Offset: 0x00D5872E
		private void CloseCallback()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenceReviveView))
			{
				this.ConfirmBoxViewIdCache = null;
			}
		}

		// Token: 0x0602FD76 RID: 195958 RVA: 0x00D5A54D File Offset: 0x00D5874D
		private void HandleOnTowerDefenceBattleEndNotify()
		{
			base.CloseMe(null);
		}

		// Token: 0x04019653 RID: 104019
		private const string TIPS_TEXT_ID = "TowerDefence_dead1";

		// Token: 0x04019654 RID: 104020
		private const string TIPS_TEXT_ID_NEW = "ReviveCountdownTime";

		// Token: 0x04019655 RID: 104021
		private const string TIPS_UNDER_BUTTON_TEXT_ID = "TowerDefence_dead2";

		// Token: 0x04019656 RID: 104022
		private int? ConfirmBoxViewIdCache;

		// Token: 0x0200A728 RID: 42792
		[NullableContext(0)]
		private class ETowerDefenceReviveViewComponent
		{
			// Token: 0x04033A75 RID: 211573
			public const int TextTips = 0;

			// Token: 0x04033A76 RID: 211574
			public const int QuitButton = 1;

			// Token: 0x04033A77 RID: 211575
			public const int AgainButton = 2;

			// Token: 0x04033A78 RID: 211576
			public const int TeamPlayerStateItem = 3;

			// Token: 0x04033A79 RID: 211577
			public const int RealQuitBtn = 7;

			// Token: 0x04033A7A RID: 211578
			public const int RealQuitText = 8;

			// Token: 0x04033A7B RID: 211579
			public const int ReviveAtLocationBtn = 9;
		}
	}
}
