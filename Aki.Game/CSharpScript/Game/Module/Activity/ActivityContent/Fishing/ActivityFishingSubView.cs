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
	// Token: 0x02006581 RID: 25985
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityFishingSubView : ActivitySubViewBase
	{
		// Token: 0x1700954F RID: 38223
		// (get) Token: 0x060411FB RID: 266747 RVA: 0x00FC85DA File Offset: 0x00FC67DA
		[Nullable(2)]
		protected new ActivityFishingData ActivityBaseData
		{
			[NullableContext(2)]
			get
			{
				return this.ActivityBaseData as ActivityFishingData;
			}
		}

		// Token: 0x060411FC RID: 266748 RVA: 0x00FC85E8 File Offset: 0x00FC67E8
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

		// Token: 0x060411FD RID: 266749 RVA: 0x00FC873C File Offset: 0x00FC693C
		protected override UniTask OnBeforeStartAsync()
		{
			ActivityFishingSubView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivityFishingSubView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060411FE RID: 266750 RVA: 0x00FC8780 File Offset: 0x00FC6980
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

		// Token: 0x060411FF RID: 266751 RVA: 0x00FC8896 File Offset: 0x00FC6A96
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnActivityPreOpen, new Action<int>(this.OnActivityPreOpen));
		}

		// Token: 0x06041200 RID: 266752 RVA: 0x00FC88B4 File Offset: 0x00FC6AB4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnActivityPreOpen, new Action<int>(this.OnActivityPreOpen));
		}

		// Token: 0x06041201 RID: 266753 RVA: 0x00FC88D2 File Offset: 0x00FC6AD2
		protected override void OnRefreshView()
		{
			this.RefreshTimerText();
			this.RefreshCondition();
			this.RefreshRedDot();
			this.RefreshRecommendQuestTips();
			this.RefreshButton();
		}

		// Token: 0x06041202 RID: 266754 RVA: 0x00FC88F4 File Offset: 0x00FC6AF4
		protected override UniTask OnBeforeHideSelfAsync()
		{
			ActivityFishingSubView.<OnBeforeHideSelfAsync>d__16 <OnBeforeHideSelfAsync>d__;
			<OnBeforeHideSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideSelfAsync>d__.<>4__this = this;
			<OnBeforeHideSelfAsync>d__.<>1__state = -1;
			<OnBeforeHideSelfAsync>d__.<>t__builder.Start<ActivityFishingSubView.<OnBeforeHideSelfAsync>d__16>(ref <OnBeforeHideSelfAsync>d__);
			return <OnBeforeHideSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041203 RID: 266755 RVA: 0x00FC8937 File Offset: 0x00FC6B37
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06041204 RID: 266756 RVA: 0x00FC8940 File Offset: 0x00FC6B40
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

		// Token: 0x06041205 RID: 266757 RVA: 0x00FC8984 File Offset: 0x00FC6B84
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

		// Token: 0x06041206 RID: 266758 RVA: 0x00FC89D4 File Offset: 0x00FC6BD4
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

		// Token: 0x06041207 RID: 266759 RVA: 0x00FC8A10 File Offset: 0x00FC6C10
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

		// Token: 0x06041208 RID: 266760 RVA: 0x00FC8A50 File Offset: 0x00FC6C50
		private void RefreshRedDot()
		{
			bool buttonRedPointShowState = this.ActivityBaseData.GetButtonRedPointShowState();
			this.FunctionalComponent.SetFunctionRedDotVisible(buttonRedPointShowState);
		}

		// Token: 0x06041209 RID: 266761 RVA: 0x00FC8A78 File Offset: 0x00FC6C78
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

		// Token: 0x0604120A RID: 266762 RVA: 0x00FC8AB6 File Offset: 0x00FC6CB6
		private bool IsShowRecommend()
		{
			return !this.ActivityBaseData.IsRecommendQuestFinished();
		}

		// Token: 0x0604120B RID: 266763 RVA: 0x00FC8AC8 File Offset: 0x00FC6CC8
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

		// Token: 0x0604120C RID: 266764 RVA: 0x00FC8B10 File Offset: 0x00FC6D10
		private void ExtraButtonFunction()
		{
			if (!this.ActivityBaseData.SaveFirstCheckRedDotState(EFishingActivityCheckSaveFlag.PreOpen, 0))
			{
				this.RefreshRedDot();
			}
		}

		// Token: 0x0604120D RID: 266765 RVA: 0x00FC8B28 File Offset: 0x00FC6D28
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

		// Token: 0x0604120E RID: 266766 RVA: 0x00FC8B6D File Offset: 0x00FC6D6D
		private bool BeforeFunctionCheck()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("CantUseInMultiplayerMode", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x0604120F RID: 266767 RVA: 0x00FC8B92 File Offset: 0x00FC6D92
		private void FunctionExecute()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivityController.Instance.OpenActivityContentView(this.ActivityBaseData);
			});
		}

		// Token: 0x04021EDA RID: 138970
		private ActivityTitleTypeA TitleComponent;

		// Token: 0x04021EDB RID: 138971
		private ActivityDescriptionTypeA DescriptionComponent;

		// Token: 0x04021EDC RID: 138972
		private ActivityRewardList<CommonItemSmallItemGrid, TItem> RewardListComponent;

		// Token: 0x04021EDD RID: 138973
		private ActivityFunctionalTypeA FunctionalComponent;

		// Token: 0x04021EDE RID: 138974
		private FishingRewardLimitTimeButton LimitTimeRewardItem;

		// Token: 0x04021EDF RID: 138975
		private FishingPermanentRewardButton PermanentRewardItem;

		// Token: 0x04021EE0 RID: 138976
		private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

		// Token: 0x0200C776 RID: 51062
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403C436 RID: 246838
			public const int TitleItem = 0;

			// Token: 0x0403C437 RID: 246839
			public const int DescriptionItem = 1;

			// Token: 0x0403C438 RID: 246840
			public const int RewardListItem = 2;

			// Token: 0x0403C439 RID: 246841
			public const int FunctionArea = 3;

			// Token: 0x0403C43A RID: 246842
			public const int LimitTimeReward = 4;

			// Token: 0x0403C43B RID: 246843
			public const int PermanentReward = 5;

			// Token: 0x0403C43C RID: 246844
			public const int RecommendQuestItem = 6;

			// Token: 0x0403C43D RID: 246845
			public const int MaleItem = 7;

			// Token: 0x0403C43E RID: 246846
			public const int FemaleItem = 8;
		}
	}
}
