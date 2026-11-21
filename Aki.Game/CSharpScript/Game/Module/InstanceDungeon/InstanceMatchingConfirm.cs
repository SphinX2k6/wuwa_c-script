using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200485B RID: 18523
	public class InstanceMatchingConfirm : UiViewBase
	{
		// Token: 0x0602E9CD RID: 190925 RVA: 0x00D03786 File Offset: 0x00D01986
		[NullableContext(1)]
		public InstanceMatchingConfirm(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E9CE RID: 190926 RVA: 0x00D03790 File Offset: 0x00D01990
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickBtnCancel));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtnConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602E9CF RID: 190927 RVA: 0x00D038BC File Offset: 0x00D01ABC
		protected override void OnStart()
		{
			this.ShowConfirmState(ConfigMultiTextLang.GetLocalTextNew(InstanceDungeonConfig.Instance.GetConfig(InstanceDungeonEntranceModel.Instance.GetMatchingId()).Value.MapName, null));
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				CommonPopViewBase popItem = childPopView.PopItem;
				if (popItem != null)
				{
					popItem.SetMaskResponsibleState(false);
				}
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 == null)
			{
				return;
			}
			CommonPopViewBase popItem2 = childPopView2.PopItem;
			if (popItem2 == null)
			{
				return;
			}
			popItem2.OverrideBackBtnCallBack(delegate
			{
				InstanceDungeonEntranceController.Instance.MatchConfirmRequest(false);
				InstanceDungeonModel.Instance.ResetData();
				base.CloseMe(null);
			});
		}

		// Token: 0x0602E9D0 RID: 190928 RVA: 0x00D0393C File Offset: 0x00D01B3C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		}

		// Token: 0x0602E9D1 RID: 190929 RVA: 0x00D0395A File Offset: 0x00D01B5A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		}

		// Token: 0x0602E9D2 RID: 190930 RVA: 0x00D03978 File Offset: 0x00D01B78
		protected override void OnBeforeDestroy()
		{
			if (this.Timer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Timer);
			}
			this.Timer = null;
			this.ConfirmTime = 0;
		}

		// Token: 0x0602E9D3 RID: 190931 RVA: 0x00D039A4 File Offset: 0x00D01BA4
		private void OnMatchingChange()
		{
			switch (InstanceDungeonEntranceModel.Instance.GetMatchingState())
			{
			case EInstanceMatchState.Default:
			case EInstanceMatchState.Matching:
			case EInstanceMatchState.ConfirmToReady:
				base.CloseMe(null);
				break;
			case EInstanceMatchState.MatchConfirm:
				break;
			case EInstanceMatchState.Waiting:
				this.ShowWaitState();
				return;
			default:
				return;
			}
		}

		// Token: 0x0602E9D4 RID: 190932 RVA: 0x00D039E8 File Offset: 0x00D01BE8
		private void TimerHandle(float _)
		{
			if (InstanceDungeonEntranceModel.Instance.GetMatchingState() != EInstanceMatchState.MatchConfirm && this.Timer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Timer);
				this.Timer = null;
				return;
			}
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(0);
			string textTableId = "MatchingCoolDown";
			TimeUtil instance2 = TimeUtil.Instance;
			int confirmTime = this.ConfirmTime;
			this.ConfirmTime = confirmTime - 1;
			instance.SetLocalText(text, textTableId, new <>z__ReadOnlySingleElementList<object>(instance2.GetCoolDown((double)confirmTime)));
		}

		// Token: 0x0602E9D5 RID: 190933 RVA: 0x00D03A5C File Offset: 0x00D01C5C
		[NullableContext(1)]
		public void ShowConfirmState(string instanceName)
		{
			this.ConfirmTime = ConfigCommonParamById.GetIntConfig("match_confirm_time_out_seconds").Value;
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(0);
			string textTableId = "MatchingCoolDown";
			int confirmTime = this.ConfirmTime;
			this.ConfirmTime = confirmTime - 1;
			instance.SetLocalText(text, textTableId, new <>z__ReadOnlySingleElementList<object>(confirmTime.ToString()));
			LguiUtil.Instance.SetLocalText(base.GetText(1), "MatchingContext", new <>z__ReadOnlySingleElementList<object>(instanceName));
			UUIText text2 = base.GetText(0);
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
			base.GetButton(2).GetRootComponent().SetUIActive(true);
			base.GetButton(3).GetRootComponent().SetUIActive(true);
			base.GetItem(4).SetUIActive(false);
			if (this.Timer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Timer);
				this.Timer = null;
			}
			this.Timer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.TimerHandle), 1000f, 1f, null, null, true);
		}

		// Token: 0x0602E9D6 RID: 190934 RVA: 0x00D03B5C File Offset: 0x00D01D5C
		public void ShowWaitState()
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(false);
			}
			base.GetButton(2).GetRootComponent().SetUIActive(false);
			base.GetButton(3).GetRootComponent().SetUIActive(false);
			base.GetItem(4).SetUIActive(true);
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView != null)
			{
				childPopView.PopItem.SetMaskResponsibleState(false);
			}
			IUiPopFrameInterface childPopView2 = this.ChildPopView;
			if (childPopView2 == null)
			{
				return;
			}
			childPopView2.PopItem.SetBackBtnShowState(false);
		}

		// Token: 0x0602E9D7 RID: 190935 RVA: 0x00D03BDA File Offset: 0x00D01DDA
		private void OnClickBtnCancel()
		{
			InstanceDungeonEntranceController.Instance.MatchConfirmRequest(false);
			InstanceDungeonModel.Instance.ResetData();
		}

		// Token: 0x0602E9D8 RID: 190936 RVA: 0x00D03BF1 File Offset: 0x00D01DF1
		private void OnClickBtnConfirm()
		{
			InstanceDungeonEntranceController.Instance.MatchConfirmRequest(true);
			this.ShowWaitState();
		}

		// Token: 0x04018CBF RID: 101567
		private int ConfirmTime;

		// Token: 0x04018CC0 RID: 101568
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x04018CC1 RID: 101569
		private const int ONE_SECONDS = 1000;

		// Token: 0x0200A4F7 RID: 42231
		private static class EInstanceMatchingConfirmComponent
		{
			// Token: 0x0403317B RID: 209275
			public const int TextTips = 0;

			// Token: 0x0403317C RID: 209276
			public const int TextContent = 1;

			// Token: 0x0403317D RID: 209277
			public const int BtnCancel = 2;

			// Token: 0x0403317E RID: 209278
			public const int BtnConfirm = 3;

			// Token: 0x0403317F RID: 209279
			public const int WaitingItem = 4;
		}
	}
}
