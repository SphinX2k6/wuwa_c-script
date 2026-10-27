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
	// Token: 0x02006639 RID: 26169
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewFeiXuePreheat : ActivitySubViewBase
	{
		// Token: 0x17009614 RID: 38420
		// (get) Token: 0x06041996 RID: 268694 RVA: 0x00FE8E04 File Offset: 0x00FE7004
		protected new ActivityFeiXuePreheatData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as ActivityFeiXuePreheatData;
			}
		}

		// Token: 0x06041997 RID: 268695 RVA: 0x00FE8E14 File Offset: 0x00FE7014
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06041998 RID: 268696 RVA: 0x00FE8E70 File Offset: 0x00FE7070
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewFeiXuePreheat.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewFeiXuePreheat.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041999 RID: 268697 RVA: 0x00FE8EB4 File Offset: 0x00FE70B4
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

		// Token: 0x0604199A RID: 268698 RVA: 0x00FE8F62 File Offset: 0x00FE7162
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0604199B RID: 268699 RVA: 0x00FE8F80 File Offset: 0x00FE7180
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0604199C RID: 268700 RVA: 0x00FE8F9E File Offset: 0x00FE719E
		private bool GetFunctionRedDotState()
		{
			return this.ActivityBaseData.IsFirstDoingTaskIsUnClick() || this.ActivityBaseData.IsExistClaimableTask();
		}

		// Token: 0x0604199D RID: 268701 RVA: 0x00FE8FBC File Offset: 0x00FE71BC
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

		// Token: 0x0604199E RID: 268702 RVA: 0x00FE9000 File Offset: 0x00FE7200
		private bool IsShowPreOpenTips()
		{
			int num = this.ActivityBaseData.IsUnLock() ? 1 : 0;
			bool flag = this.ActivityBaseData.CanPreOpen();
			return num == 0 && flag;
		}

		// Token: 0x0604199F RID: 268703 RVA: 0x00FE902C File Offset: 0x00FE722C
		private void RefreshRecommendQuestTips()
		{
			bool flag = this.IsShowPreOpenTips();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId("FeiXueWarmup_1030", Array.Empty<string>());
			}
		}

		// Token: 0x060419A0 RID: 268704 RVA: 0x00FE9064 File Offset: 0x00FE7264
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

		// Token: 0x060419A1 RID: 268705 RVA: 0x00FE908B File Offset: 0x00FE728B
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

		// Token: 0x060419A2 RID: 268706 RVA: 0x00FE90A9 File Offset: 0x00FE72A9
		private void OnRewardBtnClick(int _)
		{
			UiManager.Instance.OpenView(EUiViewName.FeiXuePreheatRewardView, this.ActivityBaseData, null);
		}

		// Token: 0x060419A3 RID: 268707 RVA: 0x00FE90C4 File Offset: 0x00FE72C4
		private void OnRecommendBtnClick()
		{
			if (QuestNewModel.Instance.GetQuest(165800001) == null)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("RecallActivity_Role_Precondition", Array.Empty<object>());
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, 165800001, null);
		}

		// Token: 0x04022205 RID: 139781
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x04022206 RID: 139782
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x04022207 RID: 139783
		private ButtonItem RewardBtn;
	}
}
