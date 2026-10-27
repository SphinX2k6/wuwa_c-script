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
	// Token: 0x02006113 RID: 24851
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewRoverlike : ActivitySubViewBase
	{
		// Token: 0x17009182 RID: 37250
		// (get) Token: 0x0603ED67 RID: 257383 RVA: 0x00F2D236 File Offset: 0x00F2B436
		protected new RoverlikeActivityData ActivityBaseData
		{
			get
			{
				return this.ActivityBaseData as RoverlikeActivityData;
			}
		}

		// Token: 0x0603ED68 RID: 257384 RVA: 0x00F2D244 File Offset: 0x00F2B444
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

		// Token: 0x0603ED69 RID: 257385 RVA: 0x00F2D310 File Offset: 0x00F2B510
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewRoverlike.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewRoverlike.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603ED6A RID: 257386 RVA: 0x00F2D354 File Offset: 0x00F2B554
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

		// Token: 0x0603ED6B RID: 257387 RVA: 0x00F2D3AB File Offset: 0x00F2B5AB
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

		// Token: 0x0603ED6C RID: 257388 RVA: 0x00F2D3EC File Offset: 0x00F2B5EC
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

		// Token: 0x0603ED6D RID: 257389 RVA: 0x00F2D444 File Offset: 0x00F2B644
		protected void OnTimer(int gap)
		{
		}

		// Token: 0x0603ED6E RID: 257390 RVA: 0x00F2D446 File Offset: 0x00F2B646
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

		// Token: 0x0603ED6F RID: 257391 RVA: 0x00F2D478 File Offset: 0x00F2B678
		private void RefreshGenderSpine()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			this.SetSpineActiveAndPlay(base.GetSpine(3), flag);
			this.SetSpineActiveAndPlay(base.GetSpine(4), !flag);
		}

		// Token: 0x0603ED70 RID: 257392 RVA: 0x00F2D4B4 File Offset: 0x00F2B6B4
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

		// Token: 0x0603ED71 RID: 257393 RVA: 0x00F2D508 File Offset: 0x00F2B708
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

		// Token: 0x0603ED72 RID: 257394 RVA: 0x00F2D567 File Offset: 0x00F2B767
		private bool GetFunctionRedDotState()
		{
			RoverlikeActivityData activityBaseData = this.ActivityBaseData;
			return activityBaseData != null && activityBaseData.HasNewLevelUnlockRedDot();
		}

		// Token: 0x0603ED73 RID: 257395 RVA: 0x00F2D57A File Offset: 0x00F2B77A
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

		// Token: 0x04020D19 RID: 134425
		protected ActivitySubViewGeneralInfo CommonInfoPanel;

		// Token: 0x04020D1A RID: 134426
		protected RoverlikeShopRewardButton ShopRewardBtn;

		// Token: 0x04020D1B RID: 134427
		protected RoverlikeQuestRewardButton QuestRewardBtn;

		// Token: 0x0200C36E RID: 50030
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF9A RID: 241562
			public const int CommonActionInfo = 0;

			// Token: 0x0403AF9B RID: 241563
			public const int NormalRewardBtn = 1;

			// Token: 0x0403AF9C RID: 241564
			public const int LimitedTimeRewardBtn = 2;

			// Token: 0x0403AF9D RID: 241565
			public const int SpineMale = 3;

			// Token: 0x0403AF9E RID: 241566
			public const int SpineFemale = 4;
		}
	}
}
