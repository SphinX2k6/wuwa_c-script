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
	// Token: 0x02005ACE RID: 23246
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefenceReviveView : UiTickViewBase
	{
		// Token: 0x0603ADF5 RID: 241141 RVA: 0x00E093E4 File Offset: 0x00E075E4
		public TowerDefenceReviveView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603ADF6 RID: 241142 RVA: 0x00E093F0 File Offset: 0x00E075F0
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

		// Token: 0x0603ADF7 RID: 241143 RVA: 0x00E0953C File Offset: 0x00E0773C
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefenceReviveView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefenceReviveView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ADF8 RID: 241144 RVA: 0x00E09580 File Offset: 0x00E07780
		protected override void OnBeforeShow()
		{
			base.GetButton(1).RootUIComp.Get().SetUIActive(false);
			base.GetButton(2).RootUIComp.Get().SetUIActive(false);
			base.GetButton(7).RootUIComp.Get().SetUIActive(true);
			base.GetButton(9).RootUIComp.Get().SetUIActive(false);
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x0603ADF9 RID: 241145 RVA: 0x00E09603 File Offset: 0x00E07803
		protected override void OnStart()
		{
			this.RefreshCountDown();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "TowerDefence_dead2", Array.Empty<object>());
		}

		// Token: 0x0603ADFA RID: 241146 RVA: 0x00E09628 File Offset: 0x00E07828
		protected override void OnBeforeDestroy()
		{
			TowerDefenseModel.Instance.SelfReviveTargetTimestampForUi = null;
			if (this.ConfirmBoxViewIdCache != null)
			{
				ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(this.ConfirmBoxViewIdCache.Value, null);
			}
			this.ConfirmBoxViewIdCache = null;
		}

		// Token: 0x0603ADFB RID: 241147 RVA: 0x00E09674 File Offset: 0x00E07874
		protected override void OnTick(float delta)
		{
			this.RefreshCountDown();
		}

		// Token: 0x0603ADFC RID: 241148 RVA: 0x00E0967C File Offset: 0x00E0787C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TowerDefenseOnTowerDefenseBattleEndNotify, new Action(this.HandleOnTowerDefenceBattleEndNotify));
		}

		// Token: 0x0603ADFD RID: 241149 RVA: 0x00E0969A File Offset: 0x00E0789A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TowerDefenseOnTowerDefenseBattleEndNotify, new Action(this.HandleOnTowerDefenceBattleEndNotify));
		}

		// Token: 0x0603ADFE RID: 241150 RVA: 0x00E096B8 File Offset: 0x00E078B8
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

		// Token: 0x0603ADFF RID: 241151 RVA: 0x00E0977C File Offset: 0x00E0797C
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

		// Token: 0x0603AE00 RID: 241152 RVA: 0x00E0980D File Offset: 0x00E07A0D
		private void CancelCallback()
		{
		}

		// Token: 0x0603AE01 RID: 241153 RVA: 0x00E0980F File Offset: 0x00E07A0F
		private void ConfirmCallback()
		{
			InstanceDungeonEntranceController.Instance.LeaveInstanceDungeon().Forget<bool>();
		}

		// Token: 0x0603AE02 RID: 241154 RVA: 0x00E09820 File Offset: 0x00E07A20
		private void FinishOpenCallback(bool success, int viewId)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenceReviveView) && success)
			{
				this.ConfirmBoxViewIdCache = new int?(viewId);
				return;
			}
			ConfirmBoxController.Instance.CloseNetWorkConfirmBoxView(viewId, null);
		}

		// Token: 0x0603AE03 RID: 241155 RVA: 0x00E0984E File Offset: 0x00E07A4E
		private void CloseCallback()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.TowerDefenceReviveView))
			{
				this.ConfirmBoxViewIdCache = null;
			}
		}

		// Token: 0x0603AE04 RID: 241156 RVA: 0x00E0986D File Offset: 0x00E07A6D
		private void HandleOnTowerDefenceBattleEndNotify()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401EB97 RID: 125847
		private const string TIPS_TEXT_ID = "TowerDefence_dead1";

		// Token: 0x0401EB98 RID: 125848
		private const string TIPS_TEXT_ID_NEW = "ReviveCountdownTime";

		// Token: 0x0401EB99 RID: 125849
		private const string TIPS_UNDER_BUTTON_TEXT_ID = "TowerDefence_dead2";

		// Token: 0x0401EB9A RID: 125850
		private int? ConfirmBoxViewIdCache;

		// Token: 0x0200BD20 RID: 48416
		[NullableContext(0)]
		private class ETowerDefenceReviveViewComponent
		{
			// Token: 0x040390AB RID: 233643
			public const int TextTips = 0;

			// Token: 0x040390AC RID: 233644
			public const int QuitButton = 1;

			// Token: 0x040390AD RID: 233645
			public const int AgainButton = 2;

			// Token: 0x040390AE RID: 233646
			public const int TeamPlayerStateItem = 3;

			// Token: 0x040390AF RID: 233647
			public const int RealQuitBtn = 7;

			// Token: 0x040390B0 RID: 233648
			public const int RealQuitText = 8;

			// Token: 0x040390B1 RID: 233649
			public const int ReviveAtLocationBtn = 9;
		}
	}
}
