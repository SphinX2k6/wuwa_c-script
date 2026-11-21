using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FeiXue
{
	// Token: 0x020055B7 RID: 21943
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewFeiXuePreheat : ActivitySubViewBase
	{
		// Token: 0x17006976 RID: 26998
		// (get) Token: 0x0603665B RID: 222811 RVA: 0x00F2FEBC File Offset: 0x00F2E0BC
		protected new ActivityFeiXuePreheatData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityFeiXuePreheatData;
			}
		}

		// Token: 0x0603665C RID: 222812 RVA: 0x00F2FECC File Offset: 0x00F2E0CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603665D RID: 222813 RVA: 0x00F2FF28 File Offset: 0x00F2E128
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewFeiXuePreheat.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewFeiXuePreheat.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603665E RID: 222814 RVA: 0x00F2FF6C File Offset: 0x00F2E16C
		protected override void OnRefreshView()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.OnRefreshView();
			}
			ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
			if (commonInfoPanel2 != null)
			{
				commonInfoPanel2.SetFunctionRedDotVisible(this.GetFunctionRedDotState());
			}
			this.RefreshCondition();
			ButtonItem rewardBtn = this.RewardBtn;
			if (rewardBtn != null)
			{
				rewardBtn.SetRedDotVisible(this.ActivityBaseData.IsExistClaimableTask());
			}
			ButtonItem rewardBtn2 = this.RewardBtn;
			if (rewardBtn2 != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActivityBaseData.GetFinishedTaskNum());
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.ActivityBaseData.GetTotalTaskNum());
				rewardBtn2.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
			}
			this.RefreshRecommendQuestTips();
		}

		// Token: 0x0603665F RID: 222815 RVA: 0x00F3001A File Offset: 0x00F2E21A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06036660 RID: 222816 RVA: 0x00F30038 File Offset: 0x00F2E238
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06036661 RID: 222817 RVA: 0x00F30056 File Offset: 0x00F2E256
		private bool GetFunctionRedDotState()
		{
			return this.ActivityBaseData.IsFirstDoingTaskIsUnClick() || this.ActivityBaseData.IsExistClaimableTask();
		}

		// Token: 0x06036662 RID: 222818 RVA: 0x00F30074 File Offset: 0x00F2E274
		private void RefreshCondition()
		{
			ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
			ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "LongShanStage_Join01",
				UnlockBtnFunction = new Action(this.OnConfirmBtnClick)
			};
			functional.RefreshGeneralPerformance(parameters);
		}

		// Token: 0x06036663 RID: 222819 RVA: 0x00F300B8 File Offset: 0x00F2E2B8
		private bool IsShowPreOpenTips()
		{
			int num = this.ActivityBaseData.IsUnLock() ? 1 : 0;
			bool flag = this.ActivityBaseData.CanPreOpen();
			return num == 0 && flag;
		}

		// Token: 0x06036664 RID: 222820 RVA: 0x00F300E4 File Offset: 0x00F2E2E4
		private void RefreshRecommendQuestTips()
		{
			bool flag = this.IsShowPreOpenTips();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId("FeiXueWarmup_1030", Array.Empty<string>());
			}
		}

		// Token: 0x06036665 RID: 222821 RVA: 0x00F3011C File Offset: 0x00F2E31C
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (this.ActivityBaseData.Id != id)
			{
				return;
			}
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel == null)
			{
				return;
			}
			commonInfoPanel.SetFunctionRedDotVisible(this.GetFunctionRedDotState());
		}

		// Token: 0x06036666 RID: 222822 RVA: 0x00F30143 File Offset: 0x00F2E343
		private void OnConfirmBtnClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				}
				else
				{
					UiManager.Instance.OpenView(EUiViewName.FeiXuePreheatMainView, this.ActivityBaseData, null);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityBaseData.Id);
			});
		}

		// Token: 0x06036667 RID: 222823 RVA: 0x00F30161 File Offset: 0x00F2E361
		private void OnRewardBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.FeiXuePreheatRewardView, this.ActivityBaseData, null);
		}

		// Token: 0x06036668 RID: 222824 RVA: 0x00F3017C File Offset: 0x00F2E37C
		private void OnRecommendBtnClick()
		{
			if (QuestNewModel.Instance.GetQuest(165800001) == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Role_Precondition", Array.Empty<object>());
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, 165800001, null);
		}

		// Token: 0x0401CB36 RID: 117558
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401CB37 RID: 117559
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0401CB38 RID: 117560
		private ButtonItem RewardBtn;
	}
}
