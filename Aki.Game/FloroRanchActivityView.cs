using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001018 RID: 4120
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchActivityView : ActivitySubViewBase
{
	// Token: 0x0600A3B0 RID: 41904 RVA: 0x002FFB3E File Offset: 0x002FDD3E
	protected override void OnSetData()
	{
		this.ActivityData = (FloroRanchActivityData)this.ActivityBaseData;
	}

	// Token: 0x0600A3B1 RID: 41905 RVA: 0x002FFB54 File Offset: 0x002FDD54
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
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
		*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A3B2 RID: 41906 RVA: 0x002FFC20 File Offset: 0x002FDE20
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchActivityView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchActivityView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A3B3 RID: 41907 RVA: 0x002FFC63 File Offset: 0x002FDE63
	protected override void OnBeforeShow()
	{
		this.RefreshTimeText();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.RefreshTimeText();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600A3B4 RID: 41908 RVA: 0x002FFC94 File Offset: 0x002FDE94
	protected override void OnRefreshView()
	{
		this.RefreshCondition();
		ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
		if (commonInfoPanel != null)
		{
			commonInfoPanel.SetFunctionRedDotVisible(this.ActivityData.CheckRedDot());
		}
		ButtonItem permanentRewardBtn = this.PermanentRewardBtn;
		if (permanentRewardBtn != null)
		{
			permanentRewardBtn.SetRedDotVisible(this.ActivityData.IsPermanentTaskHasRedDot());
		}
		ButtonItem limitRewardBtn = this.LimitRewardBtn;
		if (limitRewardBtn != null)
		{
			limitRewardBtn.SetRedDotVisible(this.ActivityData.IsLimitTaskHasRedDot());
		}
		string permanentRewardProgress = this.ActivityData.GetPermanentRewardProgress();
		ButtonItem permanentRewardBtn2 = this.PermanentRewardBtn;
		if (permanentRewardBtn2 != null)
		{
			permanentRewardBtn2.SetText(permanentRewardProgress);
		}
		this.RefreshRecommendQuestTips();
		USpineSkeletonAnimationComponent spine = base.GetSpine(3);
		if (spine == null)
		{
			return;
		}
		spine.SetAnimation(0, "star", false);
	}

	// Token: 0x0600A3B5 RID: 41909 RVA: 0x002FFD38 File Offset: 0x002FDF38
	private void RefreshTimeText()
	{
		if (!this.ActivityData.IsInLimitTime() && this.TimerHandle != null)
		{
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(this.ActivityData.IsInLimitTime());
			}
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.GetLimitTimeActivityEndTime(), "{0}");
		ButtonItem limitRewardBtn = this.LimitRewardBtn;
		if (limitRewardBtn == null)
		{
			return;
		}
		limitRewardBtn.SetText(remainTimeText);
	}

	// Token: 0x0600A3B6 RID: 41910 RVA: 0x002FFDBC File Offset: 0x002FDFBC
	private void RefreshCondition()
	{
		ActivityFunctionalTypeA functional = this.CommonInfoPanel.GetFunctional();
		ActivityFunctionAreaParams parameters = new ActivityFunctionAreaParams
		{
			UnlockBtnTextId = "LongShanStage_Join01",
			UnlockBtnFunction = new Action(this.OnConfirmBtnClick)
		};
		functional.RefreshGeneralPerformance(parameters);
	}

	// Token: 0x0600A3B7 RID: 41911 RVA: 0x002FFE00 File Offset: 0x002FE000
	private void RefreshRecommendQuestTips()
	{
		bool flag = !this.ActivityData.IsRecommendQuestFinished();
		this.RecommendQuestTipsSubPanel.SetUiActive(flag);
		if (flag)
		{
			string recommendQuestLabel = this.ActivityData.GetFloroRanchParamConfig().RecommendQuestLabel;
			this.RecommendQuestTipsSubPanel.SetTipsTxtByTextId(recommendQuestLabel, Array.Empty<string>());
		}
	}

	// Token: 0x0600A3B8 RID: 41912 RVA: 0x002FFE50 File Offset: 0x002FE050
	protected override void OnBeforeHide()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600A3B9 RID: 41913 RVA: 0x002FFE72 File Offset: 0x002FE072
	protected override void OnBeforeDestroy()
	{
		USpineSkeletonAnimationComponent spine = base.GetSpine(3);
		if (spine == null)
		{
			return;
		}
		spine.AnimationComplete.Remove(new Action<UTrackEntry>(this.OnAnimationComplete));
	}

	// Token: 0x0600A3BA RID: 41914 RVA: 0x002FFE96 File Offset: 0x002FE096
	private void OnConfirmBtnClick(ActivityBaseData data)
	{
		this.OnConfirmBtnClick();
	}

	// Token: 0x0600A3BB RID: 41915 RVA: 0x002FFE9E File Offset: 0x002FE09E
	private void OnConfirmBtnClick()
	{
		ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Farm_ConnectBan", Array.Empty<object>());
				return;
			}
			if (this.ActivityData.GetIsReadComic())
			{
				UiManager.Instance.OpenView(EUiViewName.FloroRanchMainView, this.ActivityData, null);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.FloroRanchComicView, null, null);
		});
	}

	// Token: 0x0600A3BC RID: 41916 RVA: 0x002FFEBC File Offset: 0x002FE0BC
	private void OnLimitRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchLimitRewardView, null, null);
	}

	// Token: 0x0600A3BD RID: 41917 RVA: 0x002FFECF File Offset: 0x002FE0CF
	private void OnPermanentRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchPermanentRewardView, null, null);
	}

	// Token: 0x0600A3BE RID: 41918 RVA: 0x002FFEE4 File Offset: 0x002FE0E4
	private void OnRecommendBtnClick()
	{
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.DirectTrainRecommendQuest);
		Action value = delegate()
		{
			int? recommendQuestLinkId = this.ActivityData.GetRecommendQuestLinkId();
			UiManager.Instance.OpenView(EUiViewName.QuestView, recommendQuestLinkId, null);
		};
		confirmBoxDataNew.FunctionMap[2] = value;
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x0600A3BF RID: 41919 RVA: 0x002FFF22 File Offset: 0x002FE122
	private void OnAnimationComplete(UTrackEntry entry)
	{
		if (entry == null)
		{
			return;
		}
		if (entry.getAnimationName() == "star")
		{
			USpineSkeletonAnimationComponent spine = base.GetSpine(3);
			if (spine == null)
			{
				return;
			}
			spine.SetAnimation(0, "idle", true);
		}
	}

	// Token: 0x04006043 RID: 24643
	[Nullable(1)]
	protected FloroRanchActivityData ActivityData;

	// Token: 0x04006044 RID: 24644
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04006045 RID: 24645
	private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

	// Token: 0x04006046 RID: 24646
	private ButtonItem LimitRewardBtn;

	// Token: 0x04006047 RID: 24647
	private ButtonItem PermanentRewardBtn;

	// Token: 0x04006048 RID: 24648
	private TimerHandle TimerHandle;

	// Token: 0x02007233 RID: 29235
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402528E RID: 152206
		public const int CommonActionInfo = 0;

		// Token: 0x0402528F RID: 152207
		public const int ItemLimitRewardBtn = 1;

		// Token: 0x04025290 RID: 152208
		public const int ItemPermanentRewardBtn = 2;

		// Token: 0x04025291 RID: 152209
		public const int Spine = 3;

		// Token: 0x04025292 RID: 152210
		public const int ItemRecommendQuest = 4;
	}
}
