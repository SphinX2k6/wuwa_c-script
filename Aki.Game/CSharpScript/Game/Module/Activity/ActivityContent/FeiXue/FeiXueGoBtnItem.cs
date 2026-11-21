using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055C1 RID: 21953
	[NullableContext(2)]
	[Nullable(0)]
	public class FeiXueGoBtnItem : UiPanelBase
	{
		// Token: 0x0603667A RID: 222842 RVA: 0x00F305BC File Offset: 0x00F2E7BC
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

		// Token: 0x0603667B RID: 222843 RVA: 0x00F3067B File Offset: 0x00F2E87B
		protected override void OnStart()
		{
			this.GoBtnInteraction = (base.GetButton(0).GetOwner().GetComponentByClass(UUIInteractionGroup.StaticClass()) as UUIInteractionGroup);
		}

		// Token: 0x0603667C RID: 222844 RVA: 0x00F306A3 File Offset: 0x00F2E8A3
		protected override void OnBeforeDestroy()
		{
			this.TryDisableRefreshTimer();
		}

		// Token: 0x0603667D RID: 222845 RVA: 0x00F306AC File Offset: 0x00F2E8AC
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

		// Token: 0x0603667E RID: 222846 RVA: 0x00F30790 File Offset: 0x00F2E990
		private void TryEnableRefreshTimer()
		{
			if (this.RefreshTimer != null)
			{
				return;
			}
			this.RefreshTimer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.RefreshRemainTimeText), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}

		// Token: 0x0603667F RID: 222847 RVA: 0x00F307CA File Offset: 0x00F2E9CA
		private void TryDisableRefreshTimer()
		{
			if (this.RefreshTimer == null)
			{
				return;
			}
			TimerSystem.GameplayTimeInstance.Remove(this.RefreshTimer);
			this.RefreshTimer = null;
		}

		// Token: 0x06036680 RID: 222848 RVA: 0x00F307F0 File Offset: 0x00F2E9F0
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

		// Token: 0x06036681 RID: 222849 RVA: 0x00F308F4 File Offset: 0x00F2EAF4
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

		// Token: 0x0401CB58 RID: 117592
		private UUIInteractionGroup GoBtnInteraction;

		// Token: 0x0401CB59 RID: 117593
		private ActivityFeiXuePreheatData ActivityData;

		// Token: 0x0401CB5A RID: 117594
		private FeiXuePreheatTaskData Data;

		// Token: 0x0401CB5B RID: 117595
		private TimerHandle RefreshTimer;
	}
}
