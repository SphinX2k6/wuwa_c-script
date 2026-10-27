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
	// Token: 0x02006756 RID: 26454
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewDangoBrawl : ActivitySubViewBase
	{
		// Token: 0x1700966F RID: 38511
		// (get) Token: 0x060420E9 RID: 270569 RVA: 0x01006D26 File Offset: 0x01004F26
		[Nullable(1)]
		private DangoBrawlOutGameData OutGameData
		{
			[NullableContext(1)]
			get
			{
				return this.MyActivityData.GetOutGameData();
			}
		}

		// Token: 0x060420EA RID: 270570 RVA: 0x01006D33 File Offset: 0x01004F33
		protected override void OnSetData()
		{
			this.MyActivityData = (this.ActivityBaseData as ActivityDangoBrawlData);
		}

		// Token: 0x060420EB RID: 270571 RVA: 0x01006D48 File Offset: 0x01004F48
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

		// Token: 0x060420EC RID: 270572 RVA: 0x01006DF4 File Offset: 0x01004FF4
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewDangoBrawl.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewDangoBrawl.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060420ED RID: 270573 RVA: 0x01006E38 File Offset: 0x01005038
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

		// Token: 0x060420EE RID: 270574 RVA: 0x01006EA2 File Offset: 0x010050A2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x060420EF RID: 270575 RVA: 0x01006EC0 File Offset: 0x010050C0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRedDotRefresh));
		}

		// Token: 0x060420F0 RID: 270576 RVA: 0x01006EDE File Offset: 0x010050DE
		private void OnRedDotRefresh(int activityId)
		{
			if (this.MyActivityData == null || activityId != this.MyActivityData.Id)
			{
				return;
			}
			this.RefreshShopAndRewardButton();
			this.RefreshRedDot();
		}

		// Token: 0x060420F1 RID: 270577 RVA: 0x01006F04 File Offset: 0x01005104
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

		// Token: 0x060420F2 RID: 270578 RVA: 0x01006F5C File Offset: 0x0100515C
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

		// Token: 0x060420F3 RID: 270579 RVA: 0x01006FB8 File Offset: 0x010051B8
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

		// Token: 0x060420F4 RID: 270580 RVA: 0x01007058 File Offset: 0x01005258
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

		// Token: 0x060420F5 RID: 270581 RVA: 0x010070DC File Offset: 0x010052DC
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

		// Token: 0x060420F6 RID: 270582 RVA: 0x01007133 File Offset: 0x01005333
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

		// Token: 0x060420F7 RID: 270583 RVA: 0x01007151 File Offset: 0x01005351
		private void OnClickShop()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlShopView, null, null);
		}

		// Token: 0x060420F8 RID: 270584 RVA: 0x01007164 File Offset: 0x01005364
		private void OnClickReward()
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlRewardsView, null, null);
		}

		// Token: 0x060420F9 RID: 270585 RVA: 0x01007178 File Offset: 0x01005378
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

		// Token: 0x04022655 RID: 140885
		private ActivityDangoBrawlData MyActivityData;

		// Token: 0x04022656 RID: 140886
		private ActivitySubViewGeneralInfo CommonActivityInfo;

		// Token: 0x04022657 RID: 140887
		private DangoBrawlMainButtonItem ShopButton;

		// Token: 0x04022658 RID: 140888
		private DangoBrawlMainButtonItem RewardButton;

		// Token: 0x04022659 RID: 140889
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0200C8E4 RID: 51428
		[NullableContext(0)]
		private enum EComp
		{
			// Token: 0x0403CA73 RID: 248435
			CommonActivityInfo,
			// Token: 0x0403CA74 RID: 248436
			Unused,
			// Token: 0x0403CA75 RID: 248437
			RecommendQuestTips,
			// Token: 0x0403CA76 RID: 248438
			ShopButton,
			// Token: 0x0403CA77 RID: 248439
			RewardButton
		}
	}
}
