using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005091 RID: 20625
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRoverlike : ActivitySubViewBase
	{
		// Token: 0x170064E4 RID: 25828
		// (get) Token: 0x06033A29 RID: 211497 RVA: 0x00E7404A File Offset: 0x00E7224A
		protected new RoverlikeActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as RoverlikeActivityData;
			}
		}

		// Token: 0x06033A2A RID: 211498 RVA: 0x00E74058 File Offset: 0x00E72258
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033A2B RID: 211499 RVA: 0x00E74124 File Offset: 0x00E72324
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRoverlike.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoverlike.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033A2C RID: 211500 RVA: 0x00E74168 File Offset: 0x00E72368
		protected override void OnBeforeShow()
		{
			this.OnRefreshView();
			this.RefreshGenderSpine();
			RoverlikeQuestRewardButton questRewardBtn = this.QuestRewardBtn;
			if (questRewardBtn != null)
			{
				questRewardBtn.BindRedDot();
			}
			RoverlikeShopRewardButton shopRewardBtn = this.ShopRewardBtn;
			if (shopRewardBtn != null)
			{
				shopRewardBtn.BindRedDot();
			}
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06033A2D RID: 211501 RVA: 0x00E741BF File Offset: 0x00E723BF
		protected override void OnBeforeHide()
		{
			RoverlikeQuestRewardButton questRewardBtn = this.QuestRewardBtn;
			if (questRewardBtn != null)
			{
				questRewardBtn.UnBindRedDot();
			}
			RoverlikeShopRewardButton shopRewardBtn = this.ShopRewardBtn;
			if (shopRewardBtn != null)
			{
				shopRewardBtn.UnBindRedDot();
			}
			EventSystem.Instance.Remove<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06033A2E RID: 211502 RVA: 0x00E74200 File Offset: 0x00E72400
		private void OnRefreshCommonActivityRedDot(int activityId)
		{
			RoverlikeActivityData activityBaseData = this.ActivityBaseData;
			int? num = (activityBaseData != null) ? new int?(activityBaseData.Id) : null;
			if (!(activityId == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel == null)
			{
				return;
			}
			commonInfoPanel.SetFunctionRedDotVisible(this.GetFunctionRedDotState());
		}

		// Token: 0x06033A2F RID: 211503 RVA: 0x00E74258 File Offset: 0x00E72458
		protected void OnTimer(int gap)
		{
		}

		// Token: 0x06033A30 RID: 211504 RVA: 0x00E7425A File Offset: 0x00E7245A
		protected override void OnRefreshView()
		{
			ActivitySubViewGeneralInfo commonInfoPanel = this.CommonInfoPanel;
			if (commonInfoPanel != null)
			{
				commonInfoPanel.OnRefreshView();
			}
			ActivitySubViewGeneralInfo commonInfoPanel2 = this.CommonInfoPanel;
			if (commonInfoPanel2 != null)
			{
				commonInfoPanel2.SetFunctionRedDotVisible(this.GetFunctionRedDotState());
			}
			this.RefreshRewardProgress();
		}

		// Token: 0x06033A31 RID: 211505 RVA: 0x00E7428C File Offset: 0x00E7248C
		private void RefreshGenderSpine()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			this.SetSpineActiveAndPlay(base.GetSpine(3), flag);
			this.SetSpineActiveAndPlay(base.GetSpine(4), !flag);
		}

		// Token: 0x06033A32 RID: 211506 RVA: 0x00E742C8 File Offset: 0x00E724C8
		private void SetSpineActiveAndPlay(USpineSkeletonAnimationComponent spine, bool active)
		{
			if (spine == null)
			{
				return;
			}
			UUIItem uuiitem = spine.GetOwner().GetComponentByClass(UUIItem.StaticClass()) as UUIItem;
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(active);
			}
			if (active)
			{
				spine.SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
			}
		}

		// Token: 0x06033A33 RID: 211507 RVA: 0x00E7431C File Offset: 0x00E7251C
		private void RefreshRewardProgress()
		{
			RoverlikeActivityData activityBaseData = this.ActivityBaseData;
			if (activityBaseData == null)
			{
				return;
			}
			ValueTuple<int, int> questProgress = activityBaseData.GetQuestProgress();
			RoverlikeQuestRewardButton questRewardBtn = this.QuestRewardBtn;
			if (questRewardBtn != null)
			{
				questRewardBtn.SetProgressNumText(questProgress.Item1, questProgress.Item2);
			}
			ValueTuple<int, int> shopProgress = activityBaseData.GetShopProgress();
			RoverlikeShopRewardButton shopRewardBtn = this.ShopRewardBtn;
			if (shopRewardBtn == null)
			{
				return;
			}
			shopRewardBtn.SetProgressNumText(shopProgress.Item1, shopProgress.Item2);
		}

		// Token: 0x06033A34 RID: 211508 RVA: 0x00E7437B File Offset: 0x00E7257B
		private bool GetFunctionRedDotState()
		{
			RoverlikeActivityData activityBaseData = this.ActivityBaseData;
			return activityBaseData != null && activityBaseData.HasNewLevelUnlockRedDot();
		}

		// Token: 0x06033A35 RID: 211509 RVA: 0x00E7438E File Offset: 0x00E7258E
		private void OnEnterBtnClick(ActivityBaseData _)
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				if (!this.ActivityBaseData.GetPreGuideQuestFinishState())
				{
					int unFinishPreGuideQuestId = this.ActivityBaseData.GetUnFinishPreGuideQuestId();
					UiManager.Instance.OpenView(EUiViewName.QuestView, unFinishPreGuideQuestId, null);
					return;
				}
				UiManager.Instance.OpenView(EUiViewName.RoverlikeMainView, this.ActivityBaseData, null);
			});
		}

		// Token: 0x0401B646 RID: 112198
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x0401B647 RID: 112199
		protected RoverlikeShopRewardButton ShopRewardBtn;

		// Token: 0x0401B648 RID: 112200
		protected RoverlikeQuestRewardButton QuestRewardBtn;

		// Token: 0x0200AD56 RID: 44374
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358FF RID: 219391
			public const int CommonActionInfo = 0;

			// Token: 0x04035900 RID: 219392
			public const int NormalRewardBtn = 1;

			// Token: 0x04035901 RID: 219393
			public const int LimitedTimeRewardBtn = 2;

			// Token: 0x04035902 RID: 219394
			public const int SpineMale = 3;

			// Token: 0x04035903 RID: 219395
			public const int SpineFemale = 4;
		}
	}
}
