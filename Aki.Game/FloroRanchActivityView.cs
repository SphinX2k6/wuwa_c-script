using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B59 RID: 7001
[NullableContext(2)]
[Nullable(0)]
public class FloroRanchActivityView : ActivitySubViewBase
{
	// Token: 0x0600CF9F RID: 53151 RVA: 0x002F4A66 File Offset: 0x002F2C66
	protected override void OnSetData()
	{
		this.ActivityData = (FloroRanchActivityData)this.ActivityBaseData;
	}

	// Token: 0x0600CFA0 RID: 53152 RVA: 0x002F4A7C File Offset: 0x002F2C7C
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

	// Token: 0x0600CFA1 RID: 53153 RVA: 0x002F4B48 File Offset: 0x002F2D48
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchActivityView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchActivityView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CFA2 RID: 53154 RVA: 0x002F4B8B File Offset: 0x002F2D8B
	protected override void OnBeforeShow()
	{
		this.RefreshTimeText();
		this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
		{
			this.RefreshTimeText();
		}, 1000f, 1f, null, null, true);
	}

	// Token: 0x0600CFA3 RID: 53155 RVA: 0x002F4BBC File Offset: 0x002F2DBC
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

	// Token: 0x0600CFA4 RID: 53156 RVA: 0x002F4C60 File Offset: 0x002F2E60
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

	// Token: 0x0600CFA5 RID: 53157 RVA: 0x002F4CE4 File Offset: 0x002F2EE4
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

	// Token: 0x0600CFA6 RID: 53158 RVA: 0x002F4D28 File Offset: 0x002F2F28
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

	// Token: 0x0600CFA7 RID: 53159 RVA: 0x002F4D78 File Offset: 0x002F2F78
	protected override void OnBeforeHide()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
	}

	// Token: 0x0600CFA8 RID: 53160 RVA: 0x002F4D9A File Offset: 0x002F2F9A
	protected override void OnBeforeDestroy()
	{
		USpineSkeletonAnimationComponent spine = base.GetSpine(3);
		if (spine == null)
		{
			return;
		}
		spine.AnimationComplete.Remove(new Action<UTrackEntry>(this.OnAnimationComplete));
	}

	// Token: 0x0600CFA9 RID: 53161 RVA: 0x002F4DBE File Offset: 0x002F2FBE
	private void OnConfirmBtnClick(ActivityBaseData data)
	{
		this.OnConfirmBtnClick();
	}

	// Token: 0x0600CFAA RID: 53162 RVA: 0x002F4DC6 File Offset: 0x002F2FC6
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

	// Token: 0x0600CFAB RID: 53163 RVA: 0x002F4DE4 File Offset: 0x002F2FE4
	private void OnLimitRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchLimitRewardView, null, null);
	}

	// Token: 0x0600CFAC RID: 53164 RVA: 0x002F4DF7 File Offset: 0x002F2FF7
	private void OnPermanentRewardBtnClick(int _)
	{
		UiManager.Instance.OpenView(EUiViewName.FloroRanchPermanentRewardView, null, null);
	}

	// Token: 0x0600CFAD RID: 53165 RVA: 0x002F4E0C File Offset: 0x002F300C
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

	// Token: 0x0600CFAE RID: 53166 RVA: 0x002F4E4A File Offset: 0x002F304A
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

	// Token: 0x04005F74 RID: 24436
	[Nullable(1)]
	protected FloroRanchActivityData ActivityData;

	// Token: 0x04005F75 RID: 24437
	protected ActivitySubViewGeneralInfo CommonInfoPanel;

	// Token: 0x04005F76 RID: 24438
	private RecommendQuestTipsSubPanel RecommendQuestTipsSubPanel;

	// Token: 0x04005F77 RID: 24439
	private ButtonItem LimitRewardBtn;

	// Token: 0x04005F78 RID: 24440
	private ButtonItem PermanentRewardBtn;

	// Token: 0x04005F79 RID: 24441
	private TimerHandle TimerHandle;

	// Token: 0x020080A5 RID: 32933
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04029F5A RID: 171866
		public const int CommonActionInfo = 0;

		// Token: 0x04029F5B RID: 171867
		public const int ItemLimitRewardBtn = 1;

		// Token: 0x04029F5C RID: 171868
		public const int ItemPermanentRewardBtn = 2;

		// Token: 0x04029F5D RID: 171869
		public const int Spine = 3;

		// Token: 0x04029F5E RID: 171870
		public const int ItemRecommendQuest = 4;
	}
}
