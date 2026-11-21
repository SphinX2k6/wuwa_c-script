using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FEA RID: 12266
	public class TetrisTipsEndLessEndView : TetrisTipsBaseView
	{
		// Token: 0x0601D1B8 RID: 119224 RVA: 0x008E56EB File Offset: 0x008E38EB
		[NullableContext(1)]
		public TetrisTipsEndLessEndView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D1B9 RID: 119225 RVA: 0x008E56F4 File Offset: 0x008E38F4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D1BA RID: 119226 RVA: 0x008E5800 File Offset: 0x008E3A00
		protected override void OnStart()
		{
			base.OnStart();
			EndLessEndOpenParam endLessEndOpenParam = this.OpenParam as EndLessEndOpenParam;
			if (endLessEndOpenParam != null)
			{
				this.Score = new int?(endLessEndOpenParam.Score);
				this.IsNewRecord = endLessEndOpenParam.IsNewRecord;
				this.IsQuit = endLessEndOpenParam.IsQuit;
				this.IsAutoClose = endLessEndOpenParam.IsAutoClose;
				this.Rewards = endLessEndOpenParam.Rewards;
			}
		}

		// Token: 0x0601D1BB RID: 119227 RVA: 0x008E5863 File Offset: 0x008E3A63
		protected override void OnBeforeShow()
		{
			this.Refresh();
		}

		// Token: 0x0601D1BC RID: 119228 RVA: 0x008E586C File Offset: 0x008E3A6C
		protected override void OnFinishShow()
		{
			if (this.IsAutoClose)
			{
				TimerSystem.Instance.Delay(new TTimerAction(this.OnAutoCloseDelayFinished), 1083.3334f, null, null, true, 1f);
				return;
			}
			UUIButtonComponent button = base.GetButton(3);
			if (button != null)
			{
				button.SetSelfInteractive(true);
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetUIActive(true);
			}
		}

		// Token: 0x0601D1BD RID: 119229 RVA: 0x008E58CA File Offset: 0x008E3ACA
		protected override void OnClose()
		{
			if (this.IsQuit)
			{
				this.CloseAll();
				return;
			}
			base.OnClose();
			TetrisPlayView tetrisPlayView = UiManager.Instance.GetViewByName(EUiViewName.TetrisPlayView) as TetrisPlayView;
			if (tetrisPlayView == null)
			{
				return;
			}
			tetrisPlayView.OpenLoseConfirm();
		}

		// Token: 0x0601D1BE RID: 119230 RVA: 0x008E5900 File Offset: 0x008E3B00
		private void Refresh()
		{
			if (this.IsQuit)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_ChallengeFinish_Text", Array.Empty<object>());
			}
			UUIText text = base.GetText(0);
			if (this.Score != null)
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(text, "Tetristext_13", new <>z__ReadOnlySingleElementList<object>(this.Score.Value.ToString()));
			}
			else if (text != null)
			{
				text.SetUIActive(false);
			}
			base.GetItem(2).SetUIActive(this.IsNewRecord);
		}

		// Token: 0x0601D1BF RID: 119231 RVA: 0x008E5995 File Offset: 0x008E3B95
		private void CloseAll()
		{
			base.CloseMe(new Action<bool>(this.OpenCommonRewardView));
		}

		// Token: 0x0601D1C0 RID: 119232 RVA: 0x008E59AC File Offset: 0x008E3BAC
		private void OpenCommonRewardView(bool result)
		{
			if (result)
			{
				List<RewardItemData> rewards = this.Rewards;
				if (rewards != null && rewards.Count != 0)
				{
					ItemRewardController.Instance.OpenCommonRewardView(1009, this.Rewards, new Action(this.CloseTetrisPlayView));
					return;
				}
				this.CloseTetrisPlayView();
			}
		}

		// Token: 0x0601D1C1 RID: 119233 RVA: 0x008E59F6 File Offset: 0x008E3BF6
		private void CloseTetrisPlayView()
		{
			UiManager.Instance.CloseView(EUiViewName.TetrisPlayView, null);
		}

		// Token: 0x0601D1C2 RID: 119234 RVA: 0x008E5A08 File Offset: 0x008E3C08
		private void OnAutoCloseDelayFinished(float delta)
		{
			this.OnClose();
		}

		// Token: 0x0400F548 RID: 62792
		private const float AutoCloseDelay = 1083.3334f;

		// Token: 0x0400F549 RID: 62793
		private int? Score;

		// Token: 0x0400F54A RID: 62794
		private bool IsNewRecord;

		// Token: 0x0400F54B RID: 62795
		private bool IsQuit;

		// Token: 0x0400F54C RID: 62796
		private bool IsAutoClose;

		// Token: 0x0400F54D RID: 62797
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<RewardItemData> Rewards;

		// Token: 0x02008C61 RID: 35937
		private static class EComponents
		{
			// Token: 0x0402C6DC RID: 181980
			public const int TxtContent = 0;

			// Token: 0x0402C6DD RID: 181981
			public const int TxtNotSpace = 1;

			// Token: 0x0402C6DE RID: 181982
			public const int TxtTips = 2;

			// Token: 0x0402C6DF RID: 181983
			public const int BtnMask = 3;

			// Token: 0x0402C6E0 RID: 181984
			public const int TxtClose = 4;
		}
	}
}
