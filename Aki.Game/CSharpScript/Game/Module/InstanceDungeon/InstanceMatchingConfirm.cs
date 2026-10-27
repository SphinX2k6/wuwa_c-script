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
	// Token: 0x02005883 RID: 22659
	public class InstanceMatchingConfirm : UiViewBase
	{
		// Token: 0x06039AAA RID: 236202 RVA: 0x00DB486E File Offset: 0x00DB2A6E
		[NullableContext(1)]
		public InstanceMatchingConfirm(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039AAB RID: 236203 RVA: 0x00DB4878 File Offset: 0x00DB2A78
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

		// Token: 0x06039AAC RID: 236204 RVA: 0x00DB49A4 File Offset: 0x00DB2BA4
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

		// Token: 0x06039AAD RID: 236205 RVA: 0x00DB4A24 File Offset: 0x00DB2C24
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		}

		// Token: 0x06039AAE RID: 236206 RVA: 0x00DB4A42 File Offset: 0x00DB2C42
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMatchingChange, new Action(this.OnMatchingChange));
		}

		// Token: 0x06039AAF RID: 236207 RVA: 0x00DB4A60 File Offset: 0x00DB2C60
		protected override void OnBeforeDestroy()
		{
			if (this.Timer != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.Timer);
			}
			this.Timer = null;
			this.ConfirmTime = 0;
		}

		// Token: 0x06039AB0 RID: 236208 RVA: 0x00DB4A8C File Offset: 0x00DB2C8C
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

		// Token: 0x06039AB1 RID: 236209 RVA: 0x00DB4AD0 File Offset: 0x00DB2CD0
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

		// Token: 0x06039AB2 RID: 236210 RVA: 0x00DB4B44 File Offset: 0x00DB2D44
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

		// Token: 0x06039AB3 RID: 236211 RVA: 0x00DB4C44 File Offset: 0x00DB2E44
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

		// Token: 0x06039AB4 RID: 236212 RVA: 0x00DB4CC2 File Offset: 0x00DB2EC2
		private void OnClickBtnCancel()
		{
			InstanceDungeonEntranceController.Instance.MatchConfirmRequest(false);
			InstanceDungeonModel.Instance.ResetData();
		}

		// Token: 0x06039AB5 RID: 236213 RVA: 0x00DB4CD9 File Offset: 0x00DB2ED9
		private void OnClickBtnConfirm()
		{
			InstanceDungeonEntranceController.Instance.MatchConfirmRequest(true);
			this.ShowWaitState();
		}

		// Token: 0x0401E222 RID: 123426
		private int ConfirmTime;

		// Token: 0x0401E223 RID: 123427
		[Nullable(2)]
		private TimerHandle Timer;

		// Token: 0x0401E224 RID: 123428
		private const int ONE_SECONDS = 1000;

		// Token: 0x0200BADE RID: 47838
		private static class EInstanceMatchingConfirmComponent
		{
			// Token: 0x0403877A RID: 231290
			public const int TextTips = 0;

			// Token: 0x0403877B RID: 231291
			public const int TextContent = 1;

			// Token: 0x0403877C RID: 231292
			public const int BtnCancel = 2;

			// Token: 0x0403877D RID: 231293
			public const int BtnConfirm = 3;

			// Token: 0x0403877E RID: 231294
			public const int WaitingItem = 4;
		}
	}
}
