using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020054FF RID: 21759
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFishingSubView : ActivitySubViewBase
	{
		// Token: 0x170068B1 RID: 26801
		// (get) Token: 0x06035EC0 RID: 220864 RVA: 0x00F0F58E File Offset: 0x00F0D78E
		[Nullable(2)]
		protected new ActivityFishingData ActivityBaseData
		{
			[NullableContext(2)]
			get
			{
				return this.ActivityBaseData as ActivityFishingData;
			}
		}

		// Token: 0x06035EC1 RID: 220865 RVA: 0x00F0F59C File Offset: 0x00F0D79C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
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
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035EC2 RID: 220866 RVA: 0x00F0F6F0 File Offset: 0x00F0D8F0
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityFishingSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFishingSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035EC3 RID: 220867 RVA: 0x00F0F734 File Offset: 0x00F0D934
		protected override void OnStart()
		{
			Activity? localConfig = this.ActivityBaseData.LocalConfig;
			string descTheme = localConfig.Value.DescTheme;
			bool flag = !StringUtils.IsEmpty(descTheme);
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.TitleComponent.SetSubTitleVisible(flag);
			if (flag)
			{
				this.TitleComponent.SetSubTitleByTextId(descTheme, Array.Empty<string>());
			}
			string desc = localConfig.Value.Desc;
			this.DescriptionComponent.SetContentByTextId(desc, Array.Empty<string>());
			List<TItem> previewReward = this.ActivityBaseData.GetPreviewReward(null);
			this.RewardListComponent.SetTitleByTextId("CollectActivity_reward");
			this.RewardListComponent.InitGridLayout(new Func<CommonItemSmallItemGrid>(this.RewardListComponent.InitCommonGridItem));
			this.RewardListComponent.RefreshItemLayout(previewReward, null);
			this.RefreshButton();
			this.FunctionalComponent.FunctionButton.SetExtraFunction(new Action(this.ExtraButtonFunction));
			this.SwitchGenderItem();
		}

		// Token: 0x06035EC4 RID: 220868 RVA: 0x00F0F84A File Offset: 0x00F0DA4A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivityPreOpen, new Action<int>(this.OnActivityPreOpen));
		}

		// Token: 0x06035EC5 RID: 220869 RVA: 0x00F0F868 File Offset: 0x00F0DA68
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivityPreOpen, new Action<int>(this.OnActivityPreOpen));
		}

		// Token: 0x06035EC6 RID: 220870 RVA: 0x00F0F886 File Offset: 0x00F0DA86
		protected override void OnRefreshView()
		{
			this.RefreshTimerText();
			this.RefreshCondition();
			this.RefreshRedDot();
			this.RefreshRecommendQuestTips();
			this.RefreshButton();
		}

		// Token: 0x06035EC7 RID: 220871 RVA: 0x00F0F8A8 File Offset: 0x00F0DAA8
		protected override UniTask OnBeforeHideSelfAsync()
		{
			ActivityFishingSubView.<OnBeforeHideSelfAsync>d__16 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<ActivityFishingSubView.<OnBeforeHideSelfAsync>d__16>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035EC8 RID: 220872 RVA: 0x00F0F8EB File Offset: 0x00F0DAEB
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06035EC9 RID: 220873 RVA: 0x00F0F8F4 File Offset: 0x00F0DAF4
		private void SwitchGenderItem()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(8);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
		}

		// Token: 0x06035ECA RID: 220874 RVA: 0x00F0F938 File Offset: 0x00F0DB38
		private void RefreshCondition()
		{
			ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
			{
				UnlockBtnTextId = "Fishing_Goto",
				UnlockBtnFunction = new Action(this.FunctionExecute),
				BeforePreOpenCheck = new Func<bool>(this.BeforeFunctionCheck)
			};
			this.FunctionalComponent.RefreshGeneralPerformance(parameters);
		}

		// Token: 0x06035ECB RID: 220875 RVA: 0x00F0F988 File Offset: 0x00F0DB88
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06035ECC RID: 220876 RVA: 0x00F0F9C4 File Offset: 0x00F0DBC4
		private void RefreshButton()
		{
			this.LimitTimeRewardItem.RefreshActive();
			bool flag = this.ActivityBaseData.IsUnLock();
			if (flag)
			{
				this.PermanentRewardItem.Refresh();
			}
			this.PermanentRewardItem.SetUiActive(flag);
		}

		// Token: 0x06035ECD RID: 220877 RVA: 0x00F0FA04 File Offset: 0x00F0DC04
		private void RefreshRedDot()
		{
			bool buttonRedPointShowState = this.ActivityBaseData.GetButtonRedPointShowState();
			this.FunctionalComponent.SetFunctionRedDotVisible(buttonRedPointShowState);
		}

		// Token: 0x06035ECE RID: 220878 RVA: 0x00F0FA2C File Offset: 0x00F0DC2C
		private void OnRecommendBtnClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DirectTrainRecommendQuest);
			Action value = delegate()
			{
				int? recommendQuestLinkId = this.ActivityBaseData.GetRecommendQuestLinkId();
				UiManager.Instance.OpenView(EUiViewName.QuestView, recommendQuestLinkId, null);
			};
			confirmBoxDataNew.FunctionMap[2] = value;
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06035ECF RID: 220879 RVA: 0x00F0FA6A File Offset: 0x00F0DC6A
		private bool IsShowRecommend()
		{
			return !this.ActivityBaseData.IsRecommendQuestFinished();
		}

		// Token: 0x06035ED0 RID: 220880 RVA: 0x00F0FA7C File Offset: 0x00F0DC7C
		private void RefreshRecommendQuestTips()
		{
			bool flag = this.IsShowRecommend();
			this.RecommendQuestTipsSubPanel.SetUiActive(flag);
			if (flag)
			{
				string recommendQuestLabel = this.ActivityBaseData.GetActivityConfig().RecommendQuestLabel;
				this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId(recommendQuestLabel, Array.Empty<string>());
			}
		}

		// Token: 0x06035ED1 RID: 220881 RVA: 0x00F0FAC4 File Offset: 0x00F0DCC4
		private void ExtraButtonFunction()
		{
			if (!this.ActivityBaseData.SaveFirstCheckRedDotState(EFishingActivityCheckSaveFlag.PreOpen, 0))
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x06035ED2 RID: 220882 RVA: 0x00F0FADC File Offset: 0x00F0DCDC
		private void OnActivityPreOpen(int activityId)
		{
			if (this.ActivityBaseData.Id != activityId)
			{
				return;
			}
			int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
			if (!QuestNewModel.Instance.IsTrackingQuest(unFinishPreGuideQuestId))
			{
				QuestNewController.Instance.RequestTrackQuest(unFinishPreGuideQuestId, true, ERequestTrackOperate.Auto, ESetTrackReason.None, null);
			}
		}

		// Token: 0x06035ED3 RID: 220883 RVA: 0x00F0FB21 File Offset: 0x00F0DD21
		private bool BeforeFunctionCheck()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("CantUseInMultiplayerMode", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06035ED4 RID: 220884 RVA: 0x00F0FB46 File Offset: 0x00F0DD46
		private void FunctionExecute()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
			});
		}

		// Token: 0x0401C80B RID: 116747
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x0401C80C RID: 116748
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x0401C80D RID: 116749
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x0401C80E RID: 116750
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x0401C80F RID: 116751
		private FishingRewardLimitTimeButton LimitTimeRewardItem;

		// Token: 0x0401C810 RID: 116752
		private FishingPermanentRewardButton PermanentRewardItem;

		// Token: 0x0401C811 RID: 116753
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0200B15B RID: 45403
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04036D87 RID: 224647
			public const int TitleItem = 0;

			// Token: 0x04036D88 RID: 224648
			public const int DescriptionItem = 1;

			// Token: 0x04036D89 RID: 224649
			public const int RewardListItem = 2;

			// Token: 0x04036D8A RID: 224650
			public const int FunctionArea = 3;

			// Token: 0x04036D8B RID: 224651
			public const int LimitTimeReward = 4;

			// Token: 0x04036D8C RID: 224652
			public const int PermanentReward = 5;

			// Token: 0x04036D8D RID: 224653
			public const int RecommendQuestItem = 6;

			// Token: 0x04036D8E RID: 224654
			public const int MaleItem = 7;

			// Token: 0x04036D8F RID: 224655
			public const int FemaleItem = 8;
		}
	}
}
