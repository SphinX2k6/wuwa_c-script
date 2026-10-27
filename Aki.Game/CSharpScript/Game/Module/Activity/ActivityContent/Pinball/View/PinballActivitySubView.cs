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
	// Token: 0x020062CD RID: 25293
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballActivitySubView : ActivitySubViewBase
	{
		// Token: 0x1700928F RID: 37519
		// (get) Token: 0x0603FA55 RID: 260693 RVA: 0x00F65C13 File Offset: 0x00F63E13
		protected new PinballActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as PinballActivityData;
			}
		}

		// Token: 0x0603FA56 RID: 260694 RVA: 0x00F65C20 File Offset: 0x00F63E20
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

		// Token: 0x0603FA57 RID: 260695 RVA: 0x00F65D30 File Offset: 0x00F63F30
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
			EventSystem.Instance.Add<int, QuestState, EQuestStatusUpdateReason>(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChangeHandler));
			EventSystem.Instance.Add<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(this.OnQuestRedDotStateChange));
		}

		// Token: 0x0603FA58 RID: 260696 RVA: 0x00F65D94 File Offset: 0x00F63F94
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshRedDot));
			EventSystem.Instance.Remove(EEventName.OnQuestStateChange, new Action<int, QuestState, EQuestStatusUpdateReason>(this.OnQuestStateChangeHandler));
			EventSystem.Instance.Remove<int>(EEventName.OnQuestRedDotStateChange, new Action<int>(this.OnQuestRedDotStateChange));
		}

		// Token: 0x0603FA59 RID: 260697 RVA: 0x00F65DF5 File Offset: 0x00F63FF5
		private void OnQuestStateChangeHandler(int questId, QuestState state, EQuestStatusUpdateReason reason)
		{
			this.OnQuestStateChange(questId);
		}

		// Token: 0x0603FA5A RID: 260698 RVA: 0x00F65E00 File Offset: 0x00F64000
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

		// Token: 0x0603FA5B RID: 260699 RVA: 0x00F65E74 File Offset: 0x00F64074
		private void OnQuestStateChange(int questId)
		{
			if (this.IsPinballRelatedQuest(questId))
			{
				base.RefreshView();
			}
		}

		// Token: 0x0603FA5C RID: 260700 RVA: 0x00F65E85 File Offset: 0x00F64085
		private void OnQuestRedDotStateChange(int questId)
		{
			if (questId == 0 || this.IsPinballRelatedQuest(questId))
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x0603FA5D RID: 260701 RVA: 0x00F65E9C File Offset: 0x00F6409C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballActivitySubView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballActivitySubView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FA5E RID: 260702 RVA: 0x00F65EE0 File Offset: 0x00F640E0
		private void OnRefreshRedDot(int activityId)
		{
			PinballActivityData activityBaseData = this.ActivityBaseData;
			int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
			if (activityId == num.GetValueOrDefault() & num != null)
			{
				this.RefreshRewardButtons();
			}
		}

		// Token: 0x0603FA5F RID: 260703 RVA: 0x00F65F27 File Offset: 0x00F64127
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

		// Token: 0x0603FA60 RID: 260704 RVA: 0x00F65F4C File Offset: 0x00F6414C
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

		// Token: 0x0603FA61 RID: 260705 RVA: 0x00F65FA3 File Offset: 0x00F641A3
		protected override void OnTimer(float gap)
		{
			this.RefreshTimeLimitRewardButtonText();
		}

		// Token: 0x0603FA62 RID: 260706 RVA: 0x00F65FAB File Offset: 0x00F641AB
		private void RefreshRewardButtons()
		{
			this.RefreshTimeLimitRewardButtonText();
			this.RefreshPermanentRewardButtonText();
			this.RefreshRedDot();
		}

		// Token: 0x0603FA63 RID: 260707 RVA: 0x00F65FC0 File Offset: 0x00F641C0
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

		// Token: 0x0603FA64 RID: 260708 RVA: 0x00F66030 File Offset: 0x00F64230
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

		// Token: 0x0603FA65 RID: 260709 RVA: 0x00F66094 File Offset: 0x00F64294
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

		// Token: 0x0603FA66 RID: 260710 RVA: 0x00F6617C File Offset: 0x00F6437C
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

		// Token: 0x0603FA67 RID: 260711 RVA: 0x00F6619A File Offset: 0x00F6439A
		private void OnTimeLimitRewardButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballLimitedRewardView, this.ActivityBaseData, null);
		}

		// Token: 0x0603FA68 RID: 260712 RVA: 0x00F661B2 File Offset: 0x00F643B2
		private void OnPermanentRewardButtonClick()
		{
			UiManager.Instance.OpenView(EUiViewName.PinballPermanentRewardView, this.ActivityBaseData, null);
		}

		// Token: 0x0603FA69 RID: 260713 RVA: 0x00F661CC File Offset: 0x00F643CC
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

		// Token: 0x0603FA6A RID: 260714 RVA: 0x00F6620C File Offset: 0x00F6440C
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

		// Token: 0x0402142A RID: 136234
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0402142B RID: 136235
		private ButtonItem TimeLimitRewardButton;

		// Token: 0x0402142C RID: 136236
		private ButtonItem PermanentRewardButton;

		// Token: 0x0402142D RID: 136237
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0200C4AE RID: 50350
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403B58B RID: 243083
			CommonActionInfo,
			// Token: 0x0403B58C RID: 243084
			LimitRewardButton,
			// Token: 0x0403B58D RID: 243085
			RewardButton,
			// Token: 0x0403B58E RID: 243086
			TexPlanetBehind,
			// Token: 0x0403B58F RID: 243087
			TexPlanetMiddle,
			// Token: 0x0403B590 RID: 243088
			TexPlanetFront,
			// Token: 0x0403B591 RID: 243089
			QuestTips
		}
	}
}
