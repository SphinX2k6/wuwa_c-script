using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.FlagChallenge;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A6E RID: 23150
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeRewardView : UiTickViewBase
	{
		// Token: 0x0603AA98 RID: 240280 RVA: 0x00DF8132 File Offset: 0x00DF6332
		public FlagChallengeRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AA99 RID: 240281 RVA: 0x00DF8148 File Offset: 0x00DF6348
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x0603AA9A RID: 240282 RVA: 0x00DF81B8 File Offset: 0x00DF63B8
		protected override void OnStart()
		{
			this.ActivityId = (int)this.OpenParam;
			this.PopupCaption = new PopupCaptionItem(base.GetItem(0));
			this.PopupCaption.SetCloseCallBack(new Action(this.OnBtnClose));
			if (FlagChallengeConfig.Instance.GetRewardHelpId() != 0)
			{
				this.PopupCaption.SetHelpBtnActive(true);
				this.PopupCaption.SetHelpCallBack(new Action(this.OnBtnHelp));
			}
			else
			{
				this.PopupCaption.SetHelpBtnActive(false);
			}
			UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(1);
			AUIBaseActor gridActor = base.GetItem(2).GetOwner() as AUIBaseActor;
			this.RewardScroll = new GenericScrollViewNew<FlagChallengeRewardItem, FlagChallengeTaskData>(scrollViewWithScrollbar, new Func<FlagChallengeRewardItem>(this.CreateRewardItem), gridActor, false, null);
			this.RefreshScrollView();
			this.TimeText = base.GetText(3);
			this.ActivityData = (ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityFlagChallengeData);
			this.RemainTimeFormatText = ConfigMultiTextLang.GetLocalTextNew("ActivityRemainingTime", null);
			this.RefreshRemainTime();
		}

		// Token: 0x0603AA9B RID: 240283 RVA: 0x00DF82B6 File Offset: 0x00DF64B6
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0603AA9C RID: 240284 RVA: 0x00DF82D4 File Offset: 0x00DF64D4
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0603AA9D RID: 240285 RVA: 0x00DF82F2 File Offset: 0x00DF64F2
		protected override void OnTick(float delta)
		{
			this.RefreshRemainTime();
		}

		// Token: 0x0603AA9E RID: 240286 RVA: 0x00DF82FC File Offset: 0x00DF64FC
		private void RefreshRemainTime()
		{
			if (this.TimeText == null || this.ActivityData == null)
			{
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, this.RemainTimeFormatText);
			this.TimeText.SetText(remainTimeText, true);
		}

		// Token: 0x0603AA9F RID: 240287 RVA: 0x00DF8344 File Offset: 0x00DF6544
		private void RefreshScrollView()
		{
			List<FlagChallengeTaskData> taskDataList = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).GetTaskDataList();
			this.RewardScroll.RefreshByData(taskDataList, null, true);
		}

		// Token: 0x0603AAA0 RID: 240288 RVA: 0x00DF8375 File Offset: 0x00DF6575
		private void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0603AAA1 RID: 240289 RVA: 0x00DF837E File Offset: 0x00DF657E
		private FlagChallengeRewardItem CreateRewardItem()
		{
			FlagChallengeRewardItem flagChallengeRewardItem = new FlagChallengeRewardItem();
			flagChallengeRewardItem.SetReceiveCallback(new Action<FlagChallengeTaskData>(this.OnReceiveCallback));
			return flagChallengeRewardItem;
		}

		// Token: 0x0603AAA2 RID: 240290 RVA: 0x00DF8398 File Offset: 0x00DF6598
		private void OnBtnHelp()
		{
			int rewardHelpId = FlagChallengeConfig.Instance.GetRewardHelpId();
			HelpController.Instance.OpenHelpById(rewardHelpId);
		}

		// Token: 0x0603AAA3 RID: 240291 RVA: 0x00DF83BC File Offset: 0x00DF65BC
		private void OnReceiveCallback(FlagChallengeTaskData taskData)
		{
			List<int> canReceiveTaskIdList = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).GetCanReceiveTaskIdList();
			FlagChallengeController.Instance.RequestFlagChallengeReward(this.ActivityId, canReceiveTaskIdList);
		}

		// Token: 0x0603AAA4 RID: 240292 RVA: 0x00DF83F0 File Offset: 0x00DF65F0
		private void OnTaskUpdate(int activityId)
		{
			if (activityId != this.ActivityId)
			{
				return;
			}
			this.RefreshScrollView();
		}

		// Token: 0x0401E9B2 RID: 125362
		private int ActivityId;

		// Token: 0x0401E9B3 RID: 125363
		private PopupCaptionItem PopupCaption;

		// Token: 0x0401E9B4 RID: 125364
		private GenericScrollViewNew<FlagChallengeRewardItem, FlagChallengeTaskData> RewardScroll;

		// Token: 0x0401E9B5 RID: 125365
		[Nullable(2)]
		private UUIText TimeText;

		// Token: 0x0401E9B6 RID: 125366
		[Nullable(2)]
		private ActivityFlagChallengeData ActivityData;

		// Token: 0x0401E9B7 RID: 125367
		private string RemainTimeFormatText = "";
	}
}
