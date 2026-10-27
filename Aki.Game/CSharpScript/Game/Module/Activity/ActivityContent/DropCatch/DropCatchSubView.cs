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
	// Token: 0x020066C5 RID: 26309
	[NullableContext(2)]
	[Nullable(0)]
	public class DropCatchSubView : ActivitySubViewBase
	{
		// Token: 0x06041CC1 RID: 269505 RVA: 0x00FF54C0 File Offset: 0x00FF36C0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x06041CC2 RID: 269506 RVA: 0x00FF551C File Offset: 0x00FF371C
		protected override UniTask OnBeforeStartAsync()
		{
			DropCatchSubView.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DropCatchSubView.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041CC3 RID: 269507 RVA: 0x00FF555F File Offset: 0x00FF375F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.DropCatchActivityRewardUpdate, new Action(this.RefreshProgress));
		}

		// Token: 0x06041CC4 RID: 269508 RVA: 0x00FF557D File Offset: 0x00FF377D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DropCatchActivityRewardUpdate, new Action(this.RefreshProgress));
		}

		// Token: 0x06041CC5 RID: 269509 RVA: 0x00FF559B File Offset: 0x00FF379B
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

		// Token: 0x06041CC6 RID: 269510 RVA: 0x00FF55C0 File Offset: 0x00FF37C0
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

		// Token: 0x06041CC7 RID: 269511 RVA: 0x00FF55E0 File Offset: 0x00FF37E0
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

		// Token: 0x06041CC8 RID: 269512 RVA: 0x00FF5640 File Offset: 0x00FF3840
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

		// Token: 0x06041CC9 RID: 269513 RVA: 0x00FF5680 File Offset: 0x00FF3880
		private bool IsShowPreOpenTips()
		{
			int num = this.ActivityBaseData.IsUnLock() ? 1 : 0;
			bool flag = this.ActivityBaseData.CanPreOpen();
			return num == 0 && flag;
		}

		// Token: 0x06041CCA RID: 269514 RVA: 0x00FF56AC File Offset: 0x00FF38AC
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

		// Token: 0x06041CCB RID: 269515 RVA: 0x00FF56F0 File Offset: 0x00FF38F0
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

		// Token: 0x04022476 RID: 140406
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x04022477 RID: 140407
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;
	}
}
