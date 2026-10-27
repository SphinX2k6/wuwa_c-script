using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x02006643 RID: 26179
	[NullableContext(2)]
	[Nullable(0)]
	public class FeiXueGoBtnItem : UiPanelBase
	{
		// Token: 0x060419B5 RID: 268725 RVA: 0x00FE9504 File Offset: 0x00FE7704
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickGoButton))
			};
		}

		// Token: 0x060419B6 RID: 268726 RVA: 0x00FE95C3 File Offset: 0x00FE77C3
		protected override void OnStart()
		{
			this.GoBtnInteraction = (base.GetButton(0).GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup);
		}

		// Token: 0x060419B7 RID: 268727 RVA: 0x00FE95EB File Offset: 0x00FE77EB
		protected override void OnBeforeDestroy()
		{
			this.TryDisableRefreshTimer();
		}

		// Token: 0x060419B8 RID: 268728 RVA: 0x00FE95F4 File Offset: 0x00FE77F4
		[NullableContext(1)]
		public void RefreshBtnView(FeiXuePreheatTaskData data, ActivityFeiXuePreheatData activityData)
		{
			this.Data = data;
			this.ActivityData = activityData;
			bool isLock = data.IsLock;
			base.GetSprite(4).SetUIActive(isLock);
			base.GetSprite(3).SetUIActive(!isLock);
			this.GoBtnInteraction.SetInteractable(!isLock);
			if (isLock)
			{
				this.RefreshRemainTimeText(0f);
				this.TryEnableRefreshTimer();
			}
			else
			{
				this.TryDisableRefreshTimer();
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.QuestName, Array.Empty<object>());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "FeiXueWarmup_1001", new <>z__ReadOnlyArray<object>(new object[]
			{
				this.ActivityData.GetClaimableOrFinishedTaskNum(),
				this.ActivityData.GetTotalTaskNum()
			}));
			base.GetItem(5).SetUIActive(this.ActivityData.IsFirstDoingTaskIsUnClick());
		}

		// Token: 0x060419B9 RID: 268729 RVA: 0x00FE96D8 File Offset: 0x00FE78D8
		private void TryEnableRefreshTimer()
		{
			if (this.RefreshTimer != null)
			{
				return;
			}
			this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.RefreshRemainTimeText), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x060419BA RID: 268730 RVA: 0x00FE9712 File Offset: 0x00FE7912
		private void TryDisableRefreshTimer()
		{
			if (this.RefreshTimer == null)
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}

		// Token: 0x060419BB RID: 268731 RVA: 0x00FE9738 File Offset: 0x00FE7938
		public void RefreshRemainTimeText(float delta)
		{
			double num = Math.Max(0.0, (double)(this.Data.UnlockTime / (long)TimeUtil.Instance.InverseMillisecond) - TimeUtil.Instance.GetServerTime());
			if (num <= 0.0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(32, 2);
				defaultInterpolatedStringHandler.AppendLiteral("剩余时间显示失败，绯雪任务解锁时间戳小于当前时间戳，Id");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.Data.Config.Value.Id);
				defaultInterpolatedStringHandler.AppendLiteral("，时间戳");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.Data.UnlockTime);
				instance.Error(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				this.TryDisableRefreshTimer();
				return;
			}
			string multiText = TextConfig.Instance.GetMultiText("FeiXueWarmup_1002", Array.Empty<string>());
			string countDownText = TimeUtil.Instance.GetRemainTimeDataFormat3(num).CountDownText;
			base.GetText(1).SetText(multiText + countDownText, true);
		}

		// Token: 0x060419BC RID: 268732 RVA: 0x00FE983C File Offset: 0x00FE7A3C
		private void OnClickGoButton()
		{
			if (this.Data == null)
			{
				return;
			}
			if (this.ActivityData.GetFirstDoingTaskIndex() == -1)
			{
				return;
			}
			this.ActivityData.CancelFirstDoingTaskRedDot();
			EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityData.Id);
			SkipTaskManager.Run(ESkipName.SkipToQuest, new object[]
			{
				this.Data.Config.Value.QuestId,
				"0"
			});
		}

		// Token: 0x04022227 RID: 139815
		private UUIInteractionGroup GoBtnInteraction;

		// Token: 0x04022228 RID: 139816
		private ActivityFeiXuePreheatData ActivityData;

		// Token: 0x04022229 RID: 139817
		private FeiXuePreheatTaskData Data;

		// Token: 0x0402222A RID: 139818
		private TimerHandle RefreshTimer;
	}
}
