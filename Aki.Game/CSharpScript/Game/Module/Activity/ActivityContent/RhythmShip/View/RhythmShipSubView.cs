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
	// Token: 0x020051D6 RID: 20950
	[NullableContext(2)]
	[Nullable(0)]
	public class RhythmShipSubView : ActivitySubViewBase
	{
		// Token: 0x170065BC RID: 26044
		// (get) Token: 0x06034344 RID: 213828 RVA: 0x00E9B105 File Offset: 0x00E99305
		protected new RhythmShipData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as RhythmShipData;
			}
		}

		// Token: 0x06034345 RID: 213829 RVA: 0x00E9B114 File Offset: 0x00E99314
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

		// Token: 0x06034346 RID: 213830 RVA: 0x00E9B2A0 File Offset: 0x00E994A0
		protected override UniTask OnBeforeStartAsync()
		{
			RhythmShipSubView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RhythmShipSubView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034347 RID: 213831 RVA: 0x00E9B2E3 File Offset: 0x00E994E3
		protected override void OnStart()
		{
			this.RefreshTitle();
			this.RefreshDescription();
			this.RefreshRewardList();
			this.RefreshBottom();
			this.RefreshBottomTimeText();
		}

		// Token: 0x06034348 RID: 213832 RVA: 0x00E9B303 File Offset: 0x00E99503
		protected override void OnBeforeShow()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RhythmShipTask, base.GetItem(10), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RhythmShipTimeLimitTask, base.GetItem(9), null, 0);
		}

		// Token: 0x06034349 RID: 213833 RVA: 0x00E9B337 File Offset: 0x00E99537
		protected override void OnBeforeHide()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTask, base.GetItem(10), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RhythmShipTimeLimitTask, base.GetItem(9), 0);
		}

		// Token: 0x0603434A RID: 213834 RVA: 0x00E9B369 File Offset: 0x00E99569
		protected override void OnRefreshView()
		{
			base.GetText(8).SetText(RhythmShipModel.Instance.GetTaskProgressString(0), true);
			base.GetText(7).SetText(RhythmShipModel.Instance.GetTaskProgressString(1), true);
			this.RefreshBottom();
			this.RefreshRecommendQuestTips();
		}

		// Token: 0x0603434B RID: 213835 RVA: 0x00E9B3A8 File Offset: 0x00E995A8
		private void RefreshTitle()
		{
			string title = this.ActivityBaseData.GetTitle();
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(title);
			this.RefreshTimeTitle();
		}

		// Token: 0x0603434C RID: 213836 RVA: 0x00E9B3E4 File Offset: 0x00E995E4
		protected override void OnTimer(float gap)
		{
			this.RefreshTimeTitle();
			this.RefreshBottomTimeText();
		}

		// Token: 0x0603434D RID: 213837 RVA: 0x00E9B3F4 File Offset: 0x00E995F4
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

		// Token: 0x0603434E RID: 213838 RVA: 0x00E9B464 File Offset: 0x00E99664
		private void RefreshBottomTimeText()
		{
			bool uiactive = this.ActivityBaseData.CheckIfInLimitTime();
			base.GetItem(11).SetUIActive(uiactive);
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityBaseData.EndRewardTime, "{0}");
			base.GetText(13).SetText(remainTimeText ?? "", true);
		}

		// Token: 0x0603434F RID: 213839 RVA: 0x00E9B4C0 File Offset: 0x00E996C0
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

		// Token: 0x06034350 RID: 213840 RVA: 0x00E9B538 File Offset: 0x00E99738
		private void RefreshRewardList()
		{
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
		}

		// Token: 0x06034351 RID: 213841 RVA: 0x00E9B578 File Offset: 0x00E99778
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

		// Token: 0x06034352 RID: 213842 RVA: 0x00E9B603 File Offset: 0x00E99803
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

		// Token: 0x06034353 RID: 213843 RVA: 0x00E9B621 File Offset: 0x00E99821
		private void OnClickTaskBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipTaskView, null, null);
		}

		// Token: 0x06034354 RID: 213844 RVA: 0x00E9B634 File Offset: 0x00E99834
		private void OnClickTaskLimitBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.RhythmShipLimitTaskView, null, null);
		}

		// Token: 0x06034355 RID: 213845 RVA: 0x00E9B648 File Offset: 0x00E99848
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

		// Token: 0x06034356 RID: 213846 RVA: 0x00E9B688 File Offset: 0x00E99888
		private void RefreshRecommendQuestTips()
		{
			bool flag = !this.ActivityBaseData.IsRecommendQuestFinish();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId(this.ActivityBaseData.GetRecommendQuestIdTips(), Array.Empty<string>());
			}
		}

		// Token: 0x0401BB20 RID: 113440
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401BB21 RID: 113441
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401BB22 RID: 113442
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401BB23 RID: 113443
		private ActivityFunctionalTypeA BottomComponent;

		// Token: 0x0401BB24 RID: 113444
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;
	}
}
