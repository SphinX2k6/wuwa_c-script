using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View
{
	// Token: 0x0200524B RID: 21067
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballActivitySubView : ActivitySubViewBase
	{
		// Token: 0x170065F1 RID: 26097
		// (get) Token: 0x06034716 RID: 214806 RVA: 0x00EACB6F File Offset: 0x00EAAD6F
		protected new PinballActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as PinballActivityData;
			}
		}

		// Token: 0x06034717 RID: 214807 RVA: 0x00EACB7C File Offset: 0x00EAAD7C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06034718 RID: 214808 RVA: 0x00EACC8C File Offset: 0x00EAAE8C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChangeHandler));
			EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(this.OnQuestRedDotStateChange));
		}

		// Token: 0x06034719 RID: 214809 RVA: 0x00EACCF0 File Offset: 0x00EAAEF0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChangeHandler));
			EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(this.OnQuestRedDotStateChange));
		}

		// Token: 0x0603471A RID: 214810 RVA: 0x00EACD51 File Offset: 0x00EAAF51
		private void OnQuestStateChangeHandler(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			this.OnQuestStateChange(questId);
		}

		// Token: 0x0603471B RID: 214811 RVA: 0x00EACD5C File Offset: 0x00EAAF5C
		private bool IsPinballRelatedQuest(int questId)
		{
			PinballActivityData activityBaseData = this.ActivityBaseData;
			if (activityBaseData == null)
			{
				return false;
			}
			if (activityBaseData.GetRecommendTaskId() == questId)
			{
				return true;
			}
			List<int> preGuideQuestIds = activityBaseData.GetPreGuideQuestIds();
			if (preGuideQuestIds != null)
			{
				using (List<int>.Enumerator enumerator = preGuideQuestIds.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == questId)
						{
							return true;
						}
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x0603471C RID: 214812 RVA: 0x00EACDD0 File Offset: 0x00EAAFD0
		private void OnQuestStateChange(int questId)
		{
			if (this.IsPinballRelatedQuest(questId))
			{
				base.RefreshView();
			}
		}

		// Token: 0x0603471D RID: 214813 RVA: 0x00EACDE1 File Offset: 0x00EAAFE1
		private void OnQuestRedDotStateChange(int questId)
		{
			if (questId == 0 || this.IsPinballRelatedQuest(questId))
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x0603471E RID: 214814 RVA: 0x00EACDF8 File Offset: 0x00EAAFF8
		protected override UniTask OnBeforeStartAsync()
		{
			PinballActivitySubView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballActivitySubView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603471F RID: 214815 RVA: 0x00EACE3C File Offset: 0x00EAB03C
		private void OnRefreshRedDot(int activityId)
		{
			PinballActivityData activityBaseData = this.ActivityBaseData;
			int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
			if (activityId == num.GetValueOrDefault() & num != null)
			{
				this.RefreshRewardButtons();
			}
		}

		// Token: 0x06034720 RID: 214816 RVA: 0x00EACE83 File Offset: 0x00EAB083
		protected override void OnRefreshView()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.OnRefreshView();
			}
			this.RefreshCondition();
			this.RefreshRewardButtons();
			this.RefreshRecommendTaskTips();
		}

		// Token: 0x06034721 RID: 214817 RVA: 0x00EACEA8 File Offset: 0x00EAB0A8
		private void RefreshCondition()
		{
			ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
			ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "LongShanStage_Join01",
				UnlockBtnFunction = new Action(this.OnConfirmBtnClick)
			};
			functional.RefreshGeneralPerformance(parameters);
			if (functional == null)
			{
				return;
			}
			ActivityButtonItem functionButton = functional.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.SetButtonAllowEventBubbleUp(true);
		}

		// Token: 0x06034722 RID: 214818 RVA: 0x00EACEFF File Offset: 0x00EAB0FF
		protected override void OnTimer(float gap)
		{
			this.RefreshTimeLimitRewardButtonText();
		}

		// Token: 0x06034723 RID: 214819 RVA: 0x00EACF07 File Offset: 0x00EAB107
		private void RefreshRewardButtons()
		{
			this.RefreshTimeLimitRewardButtonText();
			this.RefreshPermanentRewardButtonText();
			this.RefreshRedDot();
		}

		// Token: 0x06034724 RID: 214820 RVA: 0x00EACF1C File Offset: 0x00EAB11C
		private void RefreshTimeLimitRewardButtonText()
		{
			bool flag = this.ActivityBaseData.CheckIfInRewardTime();
			ButtonItem timeLimitRewardButton = this.TimeLimitRewardButton;
			if (timeLimitRewardButton != null)
			{
				timeLimitRewardButton.SetUiActive(flag);
			}
			if (!flag)
			{
				return;
			}
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Pinball_Main_LimitedRewardTime", null);
			if (localTextNew == null)
			{
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityBaseData.EndRewardTime, localTextNew);
			ButtonItem timeLimitRewardButton2 = this.TimeLimitRewardButton;
			if (timeLimitRewardButton2 == null)
			{
				return;
			}
			timeLimitRewardButton2.SetText(remainTimeText ?? "");
		}

		// Token: 0x06034725 RID: 214821 RVA: 0x00EACF8C File Offset: 0x00EAB18C
		private void RefreshPermanentRewardButtonText()
		{
			ValueTuple<int, int> permanentTaskProgress = this.ActivityBaseData.GetPermanentTaskProgress();
			int item = permanentTaskProgress.Item1;
			int item2 = permanentTaskProgress.Item2;
			ButtonItem permanentRewardButton = this.PermanentRewardButton;
			if (permanentRewardButton == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(item);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(item2);
			permanentRewardButton.SetText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06034726 RID: 214822 RVA: 0x00EACFF0 File Offset: 0x00EAB1F0
		private void RefreshRedDot()
		{
			PinballActivityData activityBaseData = this.ActivityBaseData;
			bool redDotVisible = false;
			if (activityBaseData.CheckIfInRewardTime())
			{
				using (List<PinballTaskData>.Enumerator enumerator = activityBaseData.GetTimeLimitTaskList().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current.IsUnclaimed)
						{
							redDotVisible = true;
							break;
						}
					}
				}
			}
			bool redDotVisible2 = false;
			using (List<PinballTaskData>.Enumerator enumerator = activityBaseData.GetPermanentTaskList().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnclaimed)
					{
						redDotVisible2 = true;
						break;
					}
				}
			}
			ButtonItem timeLimitRewardButton = this.TimeLimitRewardButton;
			if (timeLimitRewardButton != null)
			{
				timeLimitRewardButton.SetRedDotVisible(redDotVisible);
			}
			ButtonItem permanentRewardButton = this.PermanentRewardButton;
			if (permanentRewardButton != null)
			{
				permanentRewardButton.SetRedDotVisible(redDotVisible2);
			}
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel == null)
			{
				return;
			}
			commonInfoPanel.SetFunctionRedDotVisible(activityBaseData.IsMainHubEntranceHasRedDot());
		}

		// Token: 0x06034727 RID: 214823 RVA: 0x00EAD0D8 File Offset: 0x00EAB2D8
		private void OnConfirmBtnClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (this.ActivityBaseData == null)
				{
					return;
				}
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					if (unFinishPreGuideQuestId > 0)
					{
						UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					}
					return;
				}
				PinballController.Instance.OpenMainRootView(null).Forget<bool>();
			});
		}

		// Token: 0x06034728 RID: 214824 RVA: 0x00EAD0F6 File Offset: 0x00EAB2F6
		private void OnTimeLimitRewardButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballLimitedRewardView, this.ActivityBaseData, null);
		}

		// Token: 0x06034729 RID: 214825 RVA: 0x00EAD10E File Offset: 0x00EAB30E
		private void OnPermanentRewardButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballPermanentRewardView, this.ActivityBaseData, null);
		}

		// Token: 0x0603472A RID: 214826 RVA: 0x00EAD128 File Offset: 0x00EAB328
		private void OnRecommendTaskBtnClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DirectTrainRecommendQuest);
			Action value = delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, this.ActivityBaseData.GetRecommendTaskId(), null);
			};
			confirmBoxDataNew.FunctionMap[2] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603472B RID: 214827 RVA: 0x00EAD168 File Offset: 0x00EAB368
		private void RefreshRecommendTaskTips()
		{
			if (this.RecommendQuestTipsSubPanel == null)
			{
				return;
			}
			PinballActivityData activityBaseData = this.ActivityBaseData;
			if (activityBaseData.GetRecommendTaskId() == 0)
			{
				this.RecommendQuestTipsSubPanel.SetUiActive(false);
				return;
			}
			bool flag = !activityBaseData.IsRecommendTaskFinished();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				string recommendTaskDisplayName = activityBaseData.GetRecommendTaskDisplayName();
				string recommendTaskTips = activityBaseData.GetRecommendTaskTips();
				if (StringUtils.IsEmpty(recommendTaskTips))
				{
					this.RecommendQuestTipsSubPanel.SetTipsTxt(recommendTaskDisplayName);
					return;
				}
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(recommendTaskTips, null);
				string tipsTxt = StringUtils.IsEmpty(localTextNew) ? recommendTaskDisplayName : StringUtils.Format(localTextNew, new string[]
				{
					recommendTaskDisplayName
				});
				this.RecommendQuestTipsSubPanel.SetTipsTxt(tipsTxt);
			}
		}

		// Token: 0x0401BD59 RID: 114009
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401BD5A RID: 114010
		private ButtonItem TimeLimitRewardButton;

		// Token: 0x0401BD5B RID: 114011
		private ButtonItem PermanentRewardButton;

		// Token: 0x0401BD5C RID: 114012
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0200AE95 RID: 44693
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x04035EED RID: 220909
			CommonActionInfo,
			// Token: 0x04035EEE RID: 220910
			LimitRewardButton,
			// Token: 0x04035EEF RID: 220911
			RewardButton,
			// Token: 0x04035EF0 RID: 220912
			TexPlanetBehind,
			// Token: 0x04035EF1 RID: 220913
			TexPlanetMiddle,
			// Token: 0x04035EF2 RID: 220914
			TexPlanetFront,
			// Token: 0x04035EF3 RID: 220915
			QuestTips
		}
	}
}
