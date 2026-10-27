using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RhythmShip.View
{
	// Token: 0x02006258 RID: 25176
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipSubView : ActivitySubViewBase
	{
		// Token: 0x1700925A RID: 37466
		// (get) Token: 0x0603F683 RID: 259715 RVA: 0x00F541A9 File Offset: 0x00F523A9
		protected new RhythmShipData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as RhythmShipData;
			}
		}

		// Token: 0x0603F684 RID: 259716 RVA: 0x00F541B8 File Offset: 0x00F523B8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem)),
				new ValueTuple<int, Type>(13, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(6, new Action(this.OnClickTaskBtn)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickTaskLimitBtn))
			};
		}

		// Token: 0x0603F685 RID: 259717 RVA: 0x00F54344 File Offset: 0x00F52544
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipSubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipSubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F686 RID: 259718 RVA: 0x00F54387 File Offset: 0x00F52587
		protected override void OnStart()
		{
			this.RefreshTitle();
			this.RefreshDescription();
			this.RefreshRewardList();
			this.RefreshBottom();
			this.RefreshBottomTimeText();
		}

		// Token: 0x0603F687 RID: 259719 RVA: 0x00F543A7 File Offset: 0x00F525A7
		protected override void OnBeforeShow()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RhythmShipTask, base.GetItem(10), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RhythmShipTimeLimitTask, base.GetItem(9), null, 0);
		}

		// Token: 0x0603F688 RID: 259720 RVA: 0x00F543DB File Offset: 0x00F525DB
		protected override void OnBeforeHide()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTask, base.GetItem(10), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTimeLimitTask, base.GetItem(9), 0);
		}

		// Token: 0x0603F689 RID: 259721 RVA: 0x00F5440D File Offset: 0x00F5260D
		protected override void OnRefreshView()
		{
			base.GetText(8).SetText(RhythmShipModel.Instance.GetTaskProgressString(0), true);
			base.GetText(7).SetText(RhythmShipModel.Instance.GetTaskProgressString(1), true);
			this.RefreshBottom();
			this.RefreshRecommendQuestTips();
		}

		// Token: 0x0603F68A RID: 259722 RVA: 0x00F5444C File Offset: 0x00F5264C
		private void RefreshTitle()
		{
			string title = this.ActivityBaseData.GetTitle();
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(title);
			this.RefreshTimeTitle();
		}

		// Token: 0x0603F68B RID: 259723 RVA: 0x00F54488 File Offset: 0x00F52688
		protected override void OnTimer(float gap)
		{
			this.RefreshTimeTitle();
			this.RefreshBottomTimeText();
		}

		// Token: 0x0603F68C RID: 259724 RVA: 0x00F54498 File Offset: 0x00F52698
		private void RefreshTimeTitle()
		{
			RhythmShipData activityBaseData = this.ActivityBaseData;
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = ActivityModel.Instance.GetTimeVisibleAndRemainTime(activityBaseData, null);
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			if (activityBaseData.EndShowTime != 0L && (double)activityBaseData.EndShowTime < TimeUtil.Instance.GetServerTime())
			{
				this.TitleComponent.SetTimeTextVisible(false);
				return;
			}
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x0603F68D RID: 259725 RVA: 0x00F54508 File Offset: 0x00F52708
		private void RefreshBottomTimeText()
		{
			bool uiactive = this.ActivityBaseData.CheckIfInLimitTime();
			base.GetItem(11).SetUIActive(uiactive);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityBaseData.EndRewardTime, "{0}");
			base.GetText(13).SetText(remainTimeText ?? "", true);
		}

		// Token: 0x0603F68E RID: 259726 RVA: 0x00F54564 File Offset: 0x00F52764
		private void RefreshDescription()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			string descTheme = localConfig.Value.DescTheme;
			string desc = localConfig.Value.Desc;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.TitleComponent.SetSubTitleVisible(flag);
			if (flag)
			{
				this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			}
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
		}

		// Token: 0x0603F68F RID: 259727 RVA: 0x00F545DC File Offset: 0x00F527DC
		private void RefreshRewardList()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x0603F690 RID: 259728 RVA: 0x00F5461C File Offset: 0x00F5281C
		private void RefreshBottom()
		{
			RhythmShipData activityBaseData = this.ActivityBaseData;
			bool flag = activityBaseData.IsUnLock();
			ActivityFunctionAreaParams activityFunctionAreaParams = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "LongShanStage_Join01",
				UnlockBtnFunction = new Action(this.OnGotoBtnClick)
			};
			if (!flag)
			{
				this.BottomComponent.RefreshGeneralPerformance(activityFunctionAreaParams);
				return;
			}
			this.BottomComponent.SetGeneralUnlockPerformance(activityFunctionAreaParams);
			this.BottomComponent.SetPanelConditionVisible(!flag);
			this.BottomComponent.FunctionButton.SetUiActive(flag);
			this.BottomComponent.SetFunctionRedDotVisible(activityBaseData.GetGotoRhythmShipBtnRedDotActive());
		}

		// Token: 0x0603F691 RID: 259729 RVA: 0x00F546A7 File Offset: 0x00F528A7
		private void OnGotoBtnClick()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				RhythmShipChoseLevelViewData param = new RhythmShipChoseLevelViewData
				{
					OpenShowType = ERhythmShipPlanetType.Normal
				};
				UiManager.Instance.OpenView(EUiViewName.RhythmShipChoseLevelView, param, null);
			});
		}

		// Token: 0x0603F692 RID: 259730 RVA: 0x00F546C5 File Offset: 0x00F528C5
		private void OnClickTaskBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipTaskView, null, null);
		}

		// Token: 0x0603F693 RID: 259731 RVA: 0x00F546D8 File Offset: 0x00F528D8
		private void OnClickTaskLimitBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipLimitTaskView, null, null);
		}

		// Token: 0x0603F694 RID: 259732 RVA: 0x00F546EC File Offset: 0x00F528EC
		private void OnRecommendBtnClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DirectTrainRecommendQuest);
			Action value = delegate()
			{
				int recommendQuestId = this.ActivityBaseData.GetRecommendQuestId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, recommendQuestId, null);
			};
			confirmBoxDataNew.FunctionMap.Add(2, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603F695 RID: 259733 RVA: 0x00F5472C File Offset: 0x00F5292C
		private void RefreshRecommendQuestTips()
		{
			bool flag = !this.ActivityBaseData.IsRecommendQuestFinish();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId(this.ActivityBaseData.GetRecommendQuestIdTips(), Array.Empty<string>());
			}
		}

		// Token: 0x040211F1 RID: 135665
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x040211F2 RID: 135666
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x040211F3 RID: 135667
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x040211F4 RID: 135668
		private ActivityFunctionalTypeA BottomComponent;

		// Token: 0x040211F5 RID: 135669
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;
	}
}
