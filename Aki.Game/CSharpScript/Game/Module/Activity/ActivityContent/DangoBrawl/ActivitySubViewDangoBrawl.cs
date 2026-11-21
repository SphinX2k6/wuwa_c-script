using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056A6 RID: 22182
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewDangoBrawl : ActivitySubViewBase
	{
		// Token: 0x170069AE RID: 27054
		// (get) Token: 0x06036C3B RID: 224315 RVA: 0x00F481AA File Offset: 0x00F463AA
		[Nullable(1)]
		private DangoBrawlOutGameData OutGameData
		{
			[NullableContext(1)]
			get
			{
				return this.MyActivityData.GetOutGameData();
			}
		}

		// Token: 0x06036C3C RID: 224316 RVA: 0x00F481B7 File Offset: 0x00F463B7
		protected override void OnSetData()
		{
			this.MyActivityData = (this.ActivityBaseData as ActivityDangoBrawlData);
		}

		// Token: 0x06036C3D RID: 224317 RVA: 0x00F481CC File Offset: 0x00F463CC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06036C3E RID: 224318 RVA: 0x00F48278 File Offset: 0x00F46478
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewDangoBrawl.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewDangoBrawl.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036C3F RID: 224319 RVA: 0x00F482BC File Offset: 0x00F464BC
		protected override void OnStart()
		{
			DangoBrawlMainButtonItem shopButton = this.ShopButton;
			if (shopButton != null)
			{
				shopButton.SetOnClick(new Action(this.OnClickShop));
			}
			DangoBrawlMainButtonItem rewardButton = this.RewardButton;
			if (rewardButton != null)
			{
				rewardButton.SetOnClick(new Action(this.OnClickReward));
			}
			RecommendQuestTipsSubPanel recommendQuestTipsSubPanel = this.RecommendQuestTipsSubPanel;
			if (recommendQuestTipsSubPanel != null)
			{
				recommendQuestTipsSubPanel.BindClickBtnTipsCallBack(new TRecommendQuestTipsBtnCallBack(this.OnRecommendQuestBtnClick));
			}
			this.OnRefreshView();
		}

		// Token: 0x06036C40 RID: 224320 RVA: 0x00F48326 File Offset: 0x00F46526
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x06036C41 RID: 224321 RVA: 0x00F48344 File Offset: 0x00F46544
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x06036C42 RID: 224322 RVA: 0x00F48362 File Offset: 0x00F46562
		private void OnRedDotRefresh(int activityId)
		{
			if (this.MyActivityData == null || activityId != this.MyActivityData.Id)
			{
				return;
			}
			this.RefreshShopAndRewardButton();
			this.RefreshRedDot();
		}

		// Token: 0x06036C43 RID: 224323 RVA: 0x00F48388 File Offset: 0x00F46588
		protected override void OnRefreshView()
		{
			ActivityDangoBrawlData myActivityData = this.MyActivityData;
			if (myActivityData != null && myActivityData.HasFirstOpenPageRedDot())
			{
				this.MyActivityData.SetFirstOpenPageRedDot(false);
			}
			ActivitySubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
			if (commonActivityInfo != null)
			{
				commonActivityInfo.RefreshView();
			}
			this.RefreshCondition();
			this.RefreshShopAndRewardButton();
			this.RefreshRedDot();
			this.RefreshRecommendQuestTips();
		}

		// Token: 0x06036C44 RID: 224324 RVA: 0x00F483E0 File Offset: 0x00F465E0
		private void RefreshCondition()
		{
			ActivitySubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
			object obj = (commonActivityInfo != null) ? commonActivityInfo.GetFunctional() : null;
			ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "LongShanStage_Join01",
				UnlockBtnFunction = new Action(this.OnClickEnter)
			};
			object obj2 = obj;
			obj2.RefreshGeneralPerformance(parameters);
			ActivityButtonItem functionButton = obj2.FunctionButton;
			if (functionButton == null)
			{
				return;
			}
			functionButton.SetButtonAllowEventBubbleUp(true);
		}

		// Token: 0x06036C45 RID: 224325 RVA: 0x00F4843C File Offset: 0x00F4663C
		private void RefreshShopAndRewardButton()
		{
			if (this.MyActivityData == null)
			{
				return;
			}
			ValueTuple<int, int> taskProgress = this.OutGameData.GetTaskProgress(null);
			DangoBrawlMainButtonItem shopButton = this.ShopButton;
			if (shopButton != null)
			{
				shopButton.SetProgressText("DangoBrawlGeneral_Shop", new object[]
				{
					this.OutGameData.GetShopCoinCost()
				});
			}
			DangoBrawlMainButtonItem rewardButton = this.RewardButton;
			if (rewardButton == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskProgress.Item1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(taskProgress.Item2);
			rewardButton.SetProgressText(defaultInterpolatedStringHandler.ToStringAndClear());
		}

		// Token: 0x06036C46 RID: 224326 RVA: 0x00F484DC File Offset: 0x00F466DC
		private void RefreshRedDot()
		{
			if (this.MyActivityData == null)
			{
				return;
			}
			DangoBrawlMainButtonItem shopButton = this.ShopButton;
			if (shopButton != null)
			{
				shopButton.SetRedDotVisible(this.MyActivityData.HasShopRedDot());
			}
			DangoBrawlMainButtonItem rewardButton = this.RewardButton;
			if (rewardButton != null)
			{
				rewardButton.SetRedDotVisible(this.MyActivityData.HasLimitRewardRedDot());
			}
			ActivitySubViewGeneralInfo commonActivityInfo = this.CommonActivityInfo;
			if (commonActivityInfo == null)
			{
				return;
			}
			commonActivityInfo.SetFunctionRedDotVisible(this.MyActivityData.HasFirstOpenPageRedDot() || this.MyActivityData.HasNewLevelRedDot(null));
		}

		// Token: 0x06036C47 RID: 224327 RVA: 0x00F48560 File Offset: 0x00F46760
		private void RefreshRecommendQuestTips()
		{
			if (this.RecommendQuestTipsSubPanel == null || this.MyActivityData == null)
			{
				return;
			}
			bool flag = !this.OutGameData.IsRecommendQuestFinished();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId(this.OutGameData.GetRecommendQuestTipsTextId(), Array.Empty<string>());
			}
		}

		// Token: 0x06036C48 RID: 224328 RVA: 0x00F485B7 File Offset: 0x00F467B7
		private void OnClickEnter()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (this.MyActivityData == null)
				{
					return;
				}
				if (!this.MyActivityData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.MyActivityData.GetUnFinishPreGuideQuestId();
					if (unFinishPreGuideQuestId > 0)
					{
						UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					}
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.DangoBrawlMainView, null, null);
			});
		}

		// Token: 0x06036C49 RID: 224329 RVA: 0x00F485D5 File Offset: 0x00F467D5
		private void OnClickShop()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlShopView, null, null);
		}

		// Token: 0x06036C4A RID: 224330 RVA: 0x00F485E8 File Offset: 0x00F467E8
		private void OnClickReward()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRewardsView, null, null);
		}

		// Token: 0x06036C4B RID: 224331 RVA: 0x00F485FC File Offset: 0x00F467FC
		private void OnRecommendQuestBtnClick()
		{
			if (this.MyActivityData == null)
			{
				return;
			}
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DirectTrainRecommendQuest);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, this.OutGameData.GetRecommendQuestId(), null);
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0401CEAE RID: 118446
		private ActivityDangoBrawlData MyActivityData;

		// Token: 0x0401CEAF RID: 118447
		private ActivitySubViewGeneralInfo CommonActivityInfo;

		// Token: 0x0401CEB0 RID: 118448
		private DangoBrawlMainButtonItem ShopButton;

		// Token: 0x0401CEB1 RID: 118449
		private DangoBrawlMainButtonItem RewardButton;

		// Token: 0x0401CEB2 RID: 118450
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0200B2B3 RID: 45747
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x0403736D RID: 226157
			CommonActivityInfo,
			// Token: 0x0403736E RID: 226158
			Unused,
			// Token: 0x0403736F RID: 226159
			RecommendQuestTips,
			// Token: 0x04037370 RID: 226160
			ShopButton,
			// Token: 0x04037371 RID: 226161
			RewardButton
		}
	}
}
