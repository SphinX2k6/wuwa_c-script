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
	// Token: 0x02004A4A RID: 19018
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeRewardView : UiTickViewBase
	{
		// Token: 0x0602F9E1 RID: 195041 RVA: 0x00D486B6 File Offset: 0x00D468B6
		public FlagChallengeRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F9E2 RID: 195042 RVA: 0x00D486CC File Offset: 0x00D468CC
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

		// Token: 0x0602F9E3 RID: 195043 RVA: 0x00D4873C File Offset: 0x00D4693C
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

		// Token: 0x0602F9E4 RID: 195044 RVA: 0x00D4883A File Offset: 0x00D46A3A
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0602F9E5 RID: 195045 RVA: 0x00D48858 File Offset: 0x00D46A58
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnFlagChallengeTaskUpdate, new Action<int>(this.OnTaskUpdate));
		}

		// Token: 0x0602F9E6 RID: 195046 RVA: 0x00D48876 File Offset: 0x00D46A76
		protected override void OnTick(float delta)
		{
			this.RefreshRemainTime();
		}

		// Token: 0x0602F9E7 RID: 195047 RVA: 0x00D48880 File Offset: 0x00D46A80
		private void RefreshRemainTime()
		{
			if (this.TimeText == null || this.ActivityData == null)
			{
				return;
			}
			string remainTimeText = ActivityModel.Instance.GetRemainTimeText(this.ActivityData.EndShowTime, this.RemainTimeFormatText);
			this.TimeText.SetText(remainTimeText, true);
		}

		// Token: 0x0602F9E8 RID: 195048 RVA: 0x00D488C8 File Offset: 0x00D46AC8
		private void RefreshScrollView()
		{
			List<FlagChallengeTaskData> taskDataList = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).GetTaskDataList();
			this.RewardScroll.RefreshByData(taskDataList, null, true);
		}

		// Token: 0x0602F9E9 RID: 195049 RVA: 0x00D488F9 File Offset: 0x00D46AF9
		private void OnBtnClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x0602F9EA RID: 195050 RVA: 0x00D48902 File Offset: 0x00D46B02
		private FlagChallengeRewardItem CreateRewardItem()
		{
			FlagChallengeRewardItem flagChallengeRewardItem = new FlagChallengeRewardItem();
			flagChallengeRewardItem.SetReceiveCallback(new Action<FlagChallengeTaskData>(this.OnReceiveCallback));
			return flagChallengeRewardItem;
		}

		// Token: 0x0602F9EB RID: 195051 RVA: 0x00D4891C File Offset: 0x00D46B1C
		private void OnBtnHelp()
		{
			int rewardHelpId = FlagChallengeConfig.Instance.GetRewardHelpId();
			HelpController.Instance.OpenHelpById(rewardHelpId);
		}

		// Token: 0x0602F9EC RID: 195052 RVA: 0x00D48940 File Offset: 0x00D46B40
		private void OnReceiveCallback(FlagChallengeTaskData taskData)
		{
			List<int> canReceiveTaskIdList = FlagChallengeModel.Instance.GetFlagChallengeData(this.ActivityId).GetCanReceiveTaskIdList();
			FlagChallengeController.Instance.RequestFlagChallengeReward(this.ActivityId, canReceiveTaskIdList);
		}

		// Token: 0x0602F9ED RID: 195053 RVA: 0x00D48974 File Offset: 0x00D46B74
		private void OnTaskUpdate(int activityId)
		{
			if (activityId != this.ActivityId)
			{
				return;
			}
			this.RefreshScrollView();
		}

		// Token: 0x04019459 RID: 103513
		private int ActivityId;

		// Token: 0x0401945A RID: 103514
		private PopupCaptionItem PopupCaption;

		// Token: 0x0401945B RID: 103515
		private GenericScrollViewNew<FlagChallengeRewardItem, FlagChallengeTaskData> RewardScroll;

		// Token: 0x0401945C RID: 103516
		[Nullable(2)]
		private UUIText TimeText;

		// Token: 0x0401945D RID: 103517
		[Nullable(2)]
		private ActivityFlagChallengeData ActivityData;

		// Token: 0x0401945E RID: 103518
		private string RemainTimeFormatText = "";
	}
}
