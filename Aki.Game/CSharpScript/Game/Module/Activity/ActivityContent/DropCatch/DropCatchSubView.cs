using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005615 RID: 22037
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchSubView : ActivitySubViewBase
	{
		// Token: 0x0603680D RID: 223245 RVA: 0x00F368C4 File Offset: 0x00F34AC4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603680E RID: 223246 RVA: 0x00F36920 File Offset: 0x00F34B20
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchSubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchSubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603680F RID: 223247 RVA: 0x00F36963 File Offset: 0x00F34B63
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DropCatchActivityRewardUpdate, new Action(this.RefreshProgress));
		}

		// Token: 0x06036810 RID: 223248 RVA: 0x00F36981 File Offset: 0x00F34B81
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DropCatchActivityRewardUpdate, new Action(this.RefreshProgress));
		}

		// Token: 0x06036811 RID: 223249 RVA: 0x00F3699F File Offset: 0x00F34B9F
		protected override void OnRefreshView()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.OnRefreshView();
			}
			this.RefreshProgress();
			this.RefreshCondition();
			this.RefreshRecommendQuestTips();
		}

		// Token: 0x06036812 RID: 223250 RVA: 0x00F369C4 File Offset: 0x00F34BC4
		private void ClickCommonInfo()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (GameModeModel.Instance.IsMulti)
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("CoinCatch_MultiBan_Text", Array.Empty<object>());
					return;
				}
				ActivityBaseData activityBaseData = this.ActivityBaseData;
				if (((activityBaseData != null) ? new bool?(activityBaseData.GetPreGuideQuestFinishState()) : null).GetValueOrDefault())
				{
					UiManager.Instance.OpenView(EUiViewName.DropCatchLevelSelectView, null, null);
				}
				else
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityBaseData.Id);
			});
		}

		// Token: 0x06036813 RID: 223251 RVA: 0x00F369E4 File Offset: 0x00F34BE4
		private void OnRecommendBtnClick()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("DropCatchPreQuestId");
			if (QuestNewModel.Instance.GetQuest(intConfig.Value) == null)
			{
				string stringConfig = ConfigCommonParamById.GetStringConfig("DropCatchPreQuestTips");
				ScrollingTipsController.Instance.ShowTipsByTextId(stringConfig, Array.Empty<object>());
			}
			UiManager.Instance.OpenView(EUiViewName.QuestView, intConfig, null);
		}

		// Token: 0x06036814 RID: 223252 RVA: 0x00F36A44 File Offset: 0x00F34C44
		private void RefreshRecommendQuestTips()
		{
			bool flag = this.IsShowPreOpenTips();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				string stringConfig = ConfigCommonParamById.GetStringConfig("DropCatchPreQuestTips");
				this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId(stringConfig, Array.Empty<string>());
			}
		}

		// Token: 0x06036815 RID: 223253 RVA: 0x00F36A84 File Offset: 0x00F34C84
		private bool IsShowPreOpenTips()
		{
			int num = this.ActivityBaseData.IsUnLock() ? 1 : 0;
			bool flag = this.ActivityBaseData.CanPreOpen();
			return num == 0 && flag;
		}

		// Token: 0x06036816 RID: 223254 RVA: 0x00F36AB0 File Offset: 0x00F34CB0
		private void RefreshCondition()
		{
			ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
			ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "LongShanStage_Join01",
				UnlockBtnFunction = new Action(this.ClickCommonInfo)
			};
			functional.RefreshGeneralPerformance(parameters);
		}

		// Token: 0x06036817 RID: 223255 RVA: 0x00F36AF4 File Offset: 0x00F34CF4
		private void RefreshProgress()
		{
			DropCatchActivityData dropCatchActivityData = this.ActivityBaseData as DropCatchActivityData;
			if (dropCatchActivityData != null)
			{
				int finishLevelCount = dropCatchActivityData.GetFinishLevelCount();
				IReadOnlyList<DropCatchGameplay> dropCatchGameplayByActivityId = DropCatchConfig.Instance.GetDropCatchGameplayByActivityId(dropCatchActivityData.Id);
				int value = (dropCatchGameplayByActivityId != null) ? dropCatchGameplayByActivityId.Count : 0;
				UUIText text = base.GetText(1);
				if (text != null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(24, 2);
					defaultInterpolatedStringHandler.AppendLiteral("<color=#81e869>");
					defaultInterpolatedStringHandler.AppendFormatted<int>(finishLevelCount);
					defaultInterpolatedStringHandler.AppendLiteral("</color>/");
					defaultInterpolatedStringHandler.AppendFormatted<int>(value);
					text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
				bool canReceive = dropCatchActivityData.GetCanReceive();
				ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
				if (commonInfoPanel == null)
				{
					return;
				}
				ActivityFunctionalTypeA functional = commonInfoPanel.GetFunctional();
				if (functional == null)
				{
					return;
				}
				ActivityButtonItem functionButton = functional.FunctionButton;
				if (functionButton == null)
				{
					return;
				}
				functionButton.SetRedDotVisible(canReceive);
			}
		}

		// Token: 0x0401CCCF RID: 117967
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401CCD0 RID: 117968
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;
	}
}
