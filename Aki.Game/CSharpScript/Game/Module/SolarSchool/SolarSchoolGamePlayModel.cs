using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Module.ActivityCommonRootView;
using CSharpScript.Game.Module.ActivityCondition;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005979 RID: 22905
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class SolarSchoolGamePlayModel : ModelBase
	{
		// Token: 0x17006BE8 RID: 27624
		// (get) Token: 0x060385EF RID: 230895 RVA: 0x00FC2D06 File Offset: 0x00FC0F06
		public bool IsInGamePlay
		{
			get
			{
				return this.InGamePlay;
			}
		}

		// Token: 0x17006BE9 RID: 27625
		// (get) Token: 0x060385F0 RID: 230896 RVA: 0x00FC2D0E File Offset: 0x00FC0F0E
		// (set) Token: 0x060385F1 RID: 230897 RVA: 0x00FC2D16 File Offset: 0x00FC0F16
		public bool IsForceExiting { get; private set; }

		// Token: 0x17006BEA RID: 27626
		// (get) Token: 0x060385F2 RID: 230898 RVA: 0x00FC2D1F File Offset: 0x00FC0F1F
		// (set) Token: 0x060385F3 RID: 230899 RVA: 0x00FC2D27 File Offset: 0x00FC0F27
		public SolarSchoolTimeData TimeData { get; private set; }

		// Token: 0x17006BEB RID: 27627
		// (get) Token: 0x060385F4 RID: 230900 RVA: 0x00FC2D30 File Offset: 0x00FC0F30
		// (set) Token: 0x060385F5 RID: 230901 RVA: 0x00FC2D38 File Offset: 0x00FC0F38
		public SolarSchoolPlayerData PlayerData { get; private set; }

		// Token: 0x17006BEC RID: 27628
		// (get) Token: 0x060385F6 RID: 230902 RVA: 0x00FC2D41 File Offset: 0x00FC0F41
		// (set) Token: 0x060385F7 RID: 230903 RVA: 0x00FC2D49 File Offset: 0x00FC0F49
		public SolarSchoolFriendData FriendData { get; private set; }

		// Token: 0x17006BED RID: 27629
		// (get) Token: 0x060385F8 RID: 230904 RVA: 0x00FC2D52 File Offset: 0x00FC0F52
		// (set) Token: 0x060385F9 RID: 230905 RVA: 0x00FC2D5A File Offset: 0x00FC0F5A
		public SolarSchoolQuestData QuestData { get; private set; }

		// Token: 0x17006BEE RID: 27630
		// (get) Token: 0x060385FA RID: 230906 RVA: 0x00FC2D63 File Offset: 0x00FC0F63
		// (set) Token: 0x060385FB RID: 230907 RVA: 0x00FC2D6B File Offset: 0x00FC0F6B
		public SolarSchoolInventoryData InventoryData { get; private set; }

		// Token: 0x17006BEF RID: 27631
		// (get) Token: 0x060385FC RID: 230908 RVA: 0x00FC2D74 File Offset: 0x00FC0F74
		// (set) Token: 0x060385FD RID: 230909 RVA: 0x00FC2D7C File Offset: 0x00FC0F7C
		public SolarSchoolScheduleData ScheduleData { get; private set; }

		// Token: 0x17006BF0 RID: 27632
		// (get) Token: 0x060385FE RID: 230910 RVA: 0x00FC2D85 File Offset: 0x00FC0F85
		// (set) Token: 0x060385FF RID: 230911 RVA: 0x00FC2D8D File Offset: 0x00FC0F8D
		public SolarSchoolBonusData BonusData { get; private set; }

		// Token: 0x17006BF1 RID: 27633
		// (get) Token: 0x06038600 RID: 230912 RVA: 0x00FC2D96 File Offset: 0x00FC0F96
		// (set) Token: 0x06038601 RID: 230913 RVA: 0x00FC2D9E File Offset: 0x00FC0F9E
		public SolarSchoolShopData ShopData { get; private set; }

		// Token: 0x17006BF2 RID: 27634
		// (get) Token: 0x06038602 RID: 230914 RVA: 0x00FC2DA7 File Offset: 0x00FC0FA7
		// (set) Token: 0x06038603 RID: 230915 RVA: 0x00FC2DAF File Offset: 0x00FC0FAF
		public SolarSchoolAvgParamData AvgParamData { get; private set; }

		// Token: 0x17006BF3 RID: 27635
		// (get) Token: 0x06038604 RID: 230916 RVA: 0x00FC2DB8 File Offset: 0x00FC0FB8
		// (set) Token: 0x06038605 RID: 230917 RVA: 0x00FC2DC0 File Offset: 0x00FC0FC0
		public SolarSchoolPrizeDrawingData PrizeDrawingData { get; private set; }

		// Token: 0x17006BF4 RID: 27636
		// (get) Token: 0x06038606 RID: 230918 RVA: 0x00FC2DC9 File Offset: 0x00FC0FC9
		// (set) Token: 0x06038607 RID: 230919 RVA: 0x00FC2DD1 File Offset: 0x00FC0FD1
		public SolarSchoolSummaryRecordData SummaryRecordData { get; private set; }

		// Token: 0x17006BF5 RID: 27637
		// (get) Token: 0x06038608 RID: 230920 RVA: 0x00FC2DDA File Offset: 0x00FC0FDA
		// (set) Token: 0x06038609 RID: 230921 RVA: 0x00FC2DE2 File Offset: 0x00FC0FE2
		public SolarSchoolMapData MapData { get; private set; }

		// Token: 0x17006BF6 RID: 27638
		// (get) Token: 0x0603860A RID: 230922 RVA: 0x00FC2DEB File Offset: 0x00FC0FEB
		// (set) Token: 0x0603860B RID: 230923 RVA: 0x00FC2DF3 File Offset: 0x00FC0FF3
		public SolarSchoolScratchTicketRoundData ScratchTicketData { get; private set; }

		// Token: 0x17006BF7 RID: 27639
		// (get) Token: 0x0603860C RID: 230924 RVA: 0x00FC2DFC File Offset: 0x00FC0FFC
		public SolarSchoolLogReporter LogReporter { get; } = new SolarSchoolLogReporter();

		// Token: 0x0603860D RID: 230925 RVA: 0x00FC2E04 File Offset: 0x00FC1004
		public int GetActivityId()
		{
			return this.ActivityId;
		}

		// Token: 0x0603860E RID: 230926 RVA: 0x00FC2E0C File Offset: 0x00FC100C
		public float GetBehaviorPlaybackRate()
		{
			if (!this.BehaviorFastForwardEnabled)
			{
				return 1f;
			}
			float num = (float)SolarSchoolConfig.Instance.GetParamInt(this.ActivityId, "BehaviorFastForwardRate", 200) / 100f;
			if (num <= 0f)
			{
				return 1f;
			}
			return num;
		}

		// Token: 0x0603860F RID: 230927 RVA: 0x00FC2E58 File Offset: 0x00FC1058
		public bool GetBehaviorFastForwardEnabled()
		{
			return this.BehaviorFastForwardEnabled;
		}

		// Token: 0x06038610 RID: 230928 RVA: 0x00FC2E60 File Offset: 0x00FC1060
		public float SetBehaviorFastForwardEnabled(bool enabled)
		{
			this.BehaviorFastForwardEnabled = enabled;
			return this.GetBehaviorPlaybackRate();
		}

		// Token: 0x06038611 RID: 230929 RVA: 0x00FC2E6F File Offset: 0x00FC106F
		public IReadOnlyList<int> GetInfluenceIds()
		{
			return this.PlayerData.GetInfluenceIds();
		}

		// Token: 0x06038612 RID: 230930 RVA: 0x00FC2E7C File Offset: 0x00FC107C
		public SolarSchoolAttr? GetAttrConfig(ESolarSchoolSecondAttr attr)
		{
			return SolarSchoolConfig.Instance.TryGetAttrByType(this.ActivityId, (int)attr);
		}

		// Token: 0x06038613 RID: 230931 RVA: 0x00FC2E8F File Offset: 0x00FC108F
		public EPlayerGender GetPlayerGender()
		{
			if (this.PlayerData.Gender == EPlayerGender.None)
			{
				return PlayerInfoModel.Instance.GetPlayerGender();
			}
			return this.PlayerData.Gender;
		}

		// Token: 0x17006BF8 RID: 27640
		// (get) Token: 0x06038614 RID: 230932 RVA: 0x00FC2EB5 File Offset: 0x00FC10B5
		// (set) Token: 0x06038615 RID: 230933 RVA: 0x00FC2EBD File Offset: 0x00FC10BD
		public SolarSchoolCalendar? CalendarRow { get; private set; }

		// Token: 0x17006BF9 RID: 27641
		// (get) Token: 0x06038616 RID: 230934 RVA: 0x00FC2EC6 File Offset: 0x00FC10C6
		// (set) Token: 0x06038617 RID: 230935 RVA: 0x00FC2ECE File Offset: 0x00FC10CE
		public int InstanceId { get; private set; }

		// Token: 0x17006BFA RID: 27642
		// (get) Token: 0x06038618 RID: 230936 RVA: 0x00FC2ED7 File Offset: 0x00FC10D7
		// (set) Token: 0x06038619 RID: 230937 RVA: 0x00FC2EDF File Offset: 0x00FC10DF
		public ESolarSchoolInstanceType InstanceType { get; private set; }

		// Token: 0x17006BFB RID: 27643
		// (get) Token: 0x0603861A RID: 230938 RVA: 0x00FC2EE8 File Offset: 0x00FC10E8
		// (set) Token: 0x0603861B RID: 230939 RVA: 0x00FC2EF0 File Offset: 0x00FC10F0
		public string FestivalName { get; private set; } = string.Empty;

		// Token: 0x17006BFC RID: 27644
		// (get) Token: 0x0603861C RID: 230940 RVA: 0x00FC2EF9 File Offset: 0x00FC10F9
		public bool IsFestivalInstance
		{
			get
			{
				return !string.IsNullOrEmpty(this.FestivalName);
			}
		}

		// Token: 0x17006BFD RID: 27645
		// (get) Token: 0x0603861D RID: 230941 RVA: 0x00FC2F09 File Offset: 0x00FC1109
		public int TotalDay
		{
			get
			{
				return SolarSchoolConfig.Instance.GetParamInt(this.ActivityId, "TotalDays", 0);
			}
		}

		// Token: 0x0603861E RID: 230942 RVA: 0x00FC2F24 File Offset: 0x00FC1124
		public int[] GetSlotActions(ESolarSchoolTimeSlot slot)
		{
			if (this.CalendarRow == null)
			{
				return Array.Empty<int>();
			}
			SolarSchoolCalendar value = this.CalendarRow.Value;
			switch (slot)
			{
			case ESolarSchoolTimeSlot.Morning:
				return value.GetDawnActionsArray() ?? Array.Empty<int>();
			case ESolarSchoolTimeSlot.Day:
				return value.GetDayActionsArray() ?? Array.Empty<int>();
			case ESolarSchoolTimeSlot.Noon:
				return value.GetNoonActionsArray() ?? Array.Empty<int>();
			case ESolarSchoolTimeSlot.Dusk:
				return value.GetDuskActionsArray() ?? Array.Empty<int>();
			case ESolarSchoolTimeSlot.Night:
				return value.GetNightActionsArray() ?? Array.Empty<int>();
			default:
				return Array.Empty<int>();
			}
		}

		// Token: 0x0603861F RID: 230943 RVA: 0x00FC2FD0 File Offset: 0x00FC11D0
		public bool IsActionSlot(ESolarSchoolTimeSlot slot)
		{
			if (this.CalendarRow == null)
			{
				SolarSchoolTimeSlot? solarSchoolTimeSlot;
				return SolarSchoolConfig.Instance.GetTimeSlot(slot) != null && solarSchoolTimeSlot.GetValueOrDefault().IsActionSlot;
			}
			if (slot != ESolarSchoolTimeSlot.Day)
			{
				return slot == ESolarSchoolTimeSlot.Dusk && this.CalendarRow.Value.HasDuskAction;
			}
			return this.CalendarRow.Value.HasDayAction;
		}

		// Token: 0x06038620 RID: 230944 RVA: 0x00FC304D File Offset: 0x00FC124D
		public bool ShouldReturnDayStart(int dayIndex)
		{
			return dayIndex > 1 && (this.GetInstanceTypeByDayIndex(dayIndex) != ESolarSchoolInstanceType.Normal || SolarSchoolUtils.GetDayType(dayIndex) != SolarSchoolUtils.GetDayType(dayIndex - 1));
		}

		// Token: 0x06038621 RID: 230945 RVA: 0x00FC3074 File Offset: 0x00FC1274
		private ESolarSchoolInstanceType GetInstanceTypeByDayIndex(int dayIndex)
		{
			SolarSchoolCalendar? solarSchoolCalendar;
			int num = (SolarSchoolConfig.Instance.GetCalendarDay(this.ActivityId, dayIndex) != null) ? solarSchoolCalendar.GetValueOrDefault().InstanceId : 0;
			if (num == 0)
			{
				num = 1;
			}
			SolarSchoolInstance? instance = SolarSchoolConfig.Instance.GetInstance(this.ActivityId, num);
			if (instance == null)
			{
				return ESolarSchoolInstanceType.Normal;
			}
			return (ESolarSchoolInstanceType)instance.Value.InstanceType;
		}

		// Token: 0x06038622 RID: 230946 RVA: 0x00FC30E4 File Offset: 0x00FC12E4
		public bool IsLastDay(int dayIndex)
		{
			int totalDay = this.TotalDay;
			return totalDay > 0 && dayIndex >= totalDay;
		}

		// Token: 0x17006BFE RID: 27646
		// (get) Token: 0x06038623 RID: 230947 RVA: 0x00FC3105 File Offset: 0x00FC1305
		public bool IsAfterLastDay
		{
			get
			{
				return this.TotalDay > 0 && this.TimeData.DayIndex > this.TotalDay;
			}
		}

		// Token: 0x17006BFF RID: 27647
		// (get) Token: 0x06038624 RID: 230948 RVA: 0x00FC3125 File Offset: 0x00FC1325
		public bool HasSlotTransitionUnplayed
		{
			get
			{
				return this.SlotTransitionUnplayed;
			}
		}

		// Token: 0x17006C00 RID: 27648
		// (get) Token: 0x06038625 RID: 230949 RVA: 0x00FC312D File Offset: 0x00FC132D
		public bool HasDaySmallTransitionUnplayed
		{
			get
			{
				return this.DaySmallTransitionUnplayed;
			}
		}

		// Token: 0x06038626 RID: 230950 RVA: 0x00FC3135 File Offset: 0x00FC1335
		public void SetSlotTransitionUnplayed()
		{
			this.SlotTransitionUnplayed = true;
		}

		// Token: 0x06038627 RID: 230951 RVA: 0x00FC313E File Offset: 0x00FC133E
		public void SetDaySmallTransitionUnplayed()
		{
			this.SlotTransitionUnplayed = true;
			this.DaySmallTransitionUnplayed = true;
		}

		// Token: 0x06038628 RID: 230952 RVA: 0x00FC314E File Offset: 0x00FC134E
		public bool GetSlotTransitionUnplayed()
		{
			if (!this.SlotTransitionUnplayed)
			{
				return false;
			}
			this.SlotTransitionUnplayed = false;
			return true;
		}

		// Token: 0x06038629 RID: 230953 RVA: 0x00FC3162 File Offset: 0x00FC1362
		public void ClearDaySmallTransitionUnplayed()
		{
			this.DaySmallTransitionUnplayed = false;
		}

		// Token: 0x0603862A RID: 230954 RVA: 0x00FC316B File Offset: 0x00FC136B
		public void ClearSlotTransitionUnplayed()
		{
			this.SlotTransitionUnplayed = false;
			this.DaySmallTransitionUnplayed = false;
		}

		// Token: 0x0603862B RID: 230955 RVA: 0x00FC317B File Offset: 0x00FC137B
		public bool ShouldPlaySlotTransition(ESolarSchoolTimeSlot from, ESolarSchoolTimeSlot to)
		{
			return from == ESolarSchoolTimeSlot.Noon && to == ESolarSchoolTimeSlot.Dusk;
		}

		// Token: 0x0603862C RID: 230956 RVA: 0x00FC3187 File Offset: 0x00FC1387
		public ESolarSchoolTimeTransition GetDayTransitionType(int dayIndex)
		{
			if (this.IsLastDay(dayIndex))
			{
				return ESolarSchoolTimeTransition.None;
			}
			if (this.ShouldReturnDayStart(dayIndex + 1))
			{
				return ESolarSchoolTimeTransition.DayBig;
			}
			if (!this.IsDaySmallTransition(dayIndex))
			{
				return ESolarSchoolTimeTransition.DayMid;
			}
			return ESolarSchoolTimeTransition.DaySmall;
		}

		// Token: 0x0603862D RID: 230957 RVA: 0x00FC31B0 File Offset: 0x00FC13B0
		public unsafe bool TrySetPendingTargetDay(int targetDayIndex)
		{
			if (targetDayIndex <= this.TimeData.DayIndex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 设置跳转日期失败：目标日必须晚于当前日";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dayIndex", this.TimeData.DayIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("targetDayIndex", targetDayIndex);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			ESolarSchoolStageStateType currentStateType = this.GetCurrentStateType();
			bool flag = currentStateType == ESolarSchoolStageStateType.DayInProgress && this.TimeData.CurrentSlot == ESolarSchoolTimeSlot.Night;
			bool flag2;
			if (currentStateType == ESolarSchoolStageStateType.InstanceInProgress || currentStateType == ESolarSchoolStageStateType.ExamInProgress)
			{
				SolarSchoolTaskStateBase currentTaskState = this.CurrentTaskState;
				SolarSchoolInstanceExploreTask solarSchoolInstanceExploreTask = ((currentTaskState != null) ? currentTaskState.GetRunningTask() : null) as SolarSchoolInstanceExploreTask;
				if (solarSchoolInstanceExploreTask != null)
				{
					flag2 = solarSchoolInstanceExploreTask.IsEnding;
					goto IL_C2;
				}
			}
			flag2 = false;
			IL_C2:
			bool flag3 = flag2;
			if (!flag && !flag3)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 设置跳转日期失败：只能在普通天夜晚或副本收尾阶段执行";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("targetDayIndex", targetDayIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("stateType", currentStateType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("timeSlot", this.TimeData.CurrentSlot);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return false;
			}
			if (this.PendingSkipTargetDayIndex > 0)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SolarSchool;
				ELogAuthor author3 = ELogAuthor.LRC;
				string message3 = "[SolarSchool] 设置跳转日期失败：当天已经设置过目标日";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("pendingTargetDayIndex", this.PendingSkipTargetDayIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("targetDayIndex", targetDayIndex);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 2));
				return false;
			}
			int totalDay = this.TotalDay;
			if (totalDay <= 0 || targetDayIndex > totalDay)
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.SolarSchool;
				ELogAuthor author4 = ELogAuthor.BB;
				string message4 = "[SolarSchool] 设置跳转日期失败：目标日超过总天数";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("dayIndex", this.TimeData.DayIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("targetDayIndex", targetDayIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("totalDay", totalDay);
				instance4.Error(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
				return false;
			}
			this.PendingSkipTargetDayIndex = targetDayIndex;
			Log instance5 = Log.Instance;
			ELogModule module5 = ELogModule.SolarSchool;
			ELogAuthor author5 = ELogAuthor.BB;
			string message5 = "[SolarSchool] 已设置跳转目标日";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("dayIndex", this.TimeData.DayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("targetDayIndex", targetDayIndex);
			instance5.Info(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 2));
			return true;
		}

		// Token: 0x0603862E RID: 230958 RVA: 0x00FC3491 File Offset: 0x00FC1691
		public int GetDayEndAdvanceDays()
		{
			if (this.PendingSkipTargetDayIndex > 0)
			{
				return this.PendingSkipTargetDayIndex - this.TimeData.DayIndex;
			}
			return 1;
		}

		// Token: 0x0603862F RID: 230959 RVA: 0x00FC34B0 File Offset: 0x00FC16B0
		public int GetDayEndTargetDayIndex()
		{
			if (this.PendingSkipTargetDayIndex > 0)
			{
				return this.PendingSkipTargetDayIndex;
			}
			return this.TimeData.DayIndex + 1;
		}

		// Token: 0x06038630 RID: 230960 RVA: 0x00FC34CF File Offset: 0x00FC16CF
		public int ConsumeDayEndAdvanceDays()
		{
			int dayEndAdvanceDays = this.GetDayEndAdvanceDays();
			this.PendingSkipTargetDayIndex = 0;
			return dayEndAdvanceDays;
		}

		// Token: 0x06038631 RID: 230961 RVA: 0x00FC34E0 File Offset: 0x00FC16E0
		public List<SolarSchoolActionBase> SettleSkippedDay(int dayIndex)
		{
			this.TimeData.SetSkippedDayEnd(dayIndex);
			this.SummaryRecordData.EnsureCurrentMonthStarted(dayIndex);
			if (SolarSchoolUtils.GetDate(dayIndex).DayOfWeek == DayOfWeek.Monday)
			{
				int mondayDayIndex = this.TimeData.GetMondayDayIndex(this.GetDayEndTargetDayIndex());
				bool refreshShop = dayIndex == mondayDayIndex;
				this.ResetScheduleForWeek(dayIndex, refreshShop);
			}
			this.ScheduleData.RecordSkippedDay(dayIndex);
			List<SolarSchoolActionBase> result = SolarSchoolSpecialBehaviorCenter.Instance.SettleDeadlineFailures(dayIndex);
			this.SummaryRecordData.TrySettleMonth(dayIndex);
			this.AdvanceBuffDays();
			return result;
		}

		// Token: 0x06038632 RID: 230962 RVA: 0x00FC3560 File Offset: 0x00FC1760
		private bool IsDaySmallTransition(int dayIndex)
		{
			return this.ScheduleData.IsSlotScheduled(SolarSchoolUtils.GetWeekday(dayIndex), ESolarSchoolTimeSlot.Dusk) && this.ScheduleData.IsSlotScheduled(SolarSchoolUtils.GetWeekday(dayIndex + 1), ESolarSchoolTimeSlot.Day);
		}

		// Token: 0x06038633 RID: 230963 RVA: 0x00FC358C File Offset: 0x00FC178C
		public bool IsFunctionUnlocked(ESolarSchoolFunction function)
		{
			foreach (SolarSchoolFunction solarSchoolFunction in SolarSchoolConfig.Instance.GetFunctionList(this.ActivityId))
			{
				if (solarSchoolFunction.FunctionType == (int)function)
				{
					return solarSchoolFunction.UnlockConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(solarSchoolFunction.UnlockConditionGroupId);
				}
			}
			return true;
		}

		// Token: 0x06038634 RID: 230964 RVA: 0x00FC360C File Offset: 0x00FC180C
		public List<int> GetLocationBehaviors(int locationId)
		{
			return this.CollectPanelBehaviors(locationId, 0);
		}

		// Token: 0x06038635 RID: 230965 RVA: 0x00FC3616 File Offset: 0x00FC1816
		public List<int> GetRoleBehaviors(int roleId)
		{
			return this.CollectPanelBehaviors(0, roleId);
		}

		// Token: 0x06038636 RID: 230966 RVA: 0x00FC3620 File Offset: 0x00FC1820
		private List<int> CollectPanelBehaviors(int locationId, int roleId)
		{
			List<int> list = new List<int>();
			if (locationId == 0 && roleId == 0)
			{
				return list;
			}
			if (this.InstanceType != ESolarSchoolInstanceType.Normal)
			{
				return list;
			}
			IReadOnlyList<SolarSchoolBehavior> behaviorListByActivityId = SolarSchoolConfig.Instance.GetBehaviorListByActivityId(this.ActivityId);
			if (behaviorListByActivityId == null)
			{
				return list;
			}
			HashSet<int> hashSet = new HashSet<int>();
			foreach (SolarSchoolBehavior row in behaviorListByActivityId)
			{
				if (row.BehaviorType == 3 && row.Location == locationId && row.RoleId == roleId && this.MatchCurrentSlot(row) && hashSet.Add(row.BehaviorId) && this.IsBehaviorUnlocked(row.BehaviorId))
				{
					list.Add(row.BehaviorId);
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x06038637 RID: 230967 RVA: 0x00FC36F0 File Offset: 0x00FC18F0
		private bool MatchCurrentSlot(SolarSchoolBehavior row)
		{
			return this.IsActionSlot(this.TimeData.CurrentSlot) && SolarSchoolUtils.CanPlaceInSlot(row, this.TimeData.CurrentSlot);
		}

		// Token: 0x06038638 RID: 230968 RVA: 0x00FC3718 File Offset: 0x00FC1918
		public ESolarSchoolTimeSlot GetBehaviorOccupySlot(SolarSchoolBehavior? row)
		{
			if (row == null)
			{
				return ESolarSchoolTimeSlot.None;
			}
			if (!SolarSchoolUtils.CanPlaceInSlot(row.Value, this.TimeData.CurrentSlot))
			{
				return ESolarSchoolTimeSlot.None;
			}
			return this.TimeData.CurrentSlot;
		}

		// Token: 0x06038639 RID: 230969 RVA: 0x00FC374C File Offset: 0x00FC194C
		private void BuildWorldData(int dayIndex)
		{
			this.ResetWorldData();
			this.CalendarRow = SolarSchoolConfig.Instance.GetCalendarDay(this.ActivityId, dayIndex);
			this.SetInstance();
			this.MapData.ClearLocationsDaily();
			this.QuestData.ClearDaily();
			this.MapData.FillLocationOptions(this.ActivityId, this.InstanceId);
		}

		// Token: 0x0603863A RID: 230970 RVA: 0x00FC37AC File Offset: 0x00FC19AC
		private void ResetWorldData()
		{
			this.CalendarRow = null;
			this.InstanceId = 0;
			this.InstanceType = ESolarSchoolInstanceType.Normal;
			this.FestivalName = string.Empty;
		}

		// Token: 0x0603863B RID: 230971 RVA: 0x00FC37E4 File Offset: 0x00FC19E4
		private void SetInstance()
		{
			SolarSchoolCalendar? solarSchoolCalendar;
			int num = (this.CalendarRow != null) ? solarSchoolCalendar.GetValueOrDefault().InstanceId : 0;
			if (num == 0)
			{
				num = 1;
			}
			SolarSchoolInstance? instance = SolarSchoolConfig.Instance.GetInstance(this.ActivityId, num);
			this.InstanceId = num;
			this.InstanceType = (ESolarSchoolInstanceType)((instance != null) ? instance.Value.InstanceType : 0);
			this.FestivalName = (((instance != null) ? instance.GetValueOrDefault().FestivalName : null) ?? string.Empty);
		}

		// Token: 0x0603863C RID: 230972 RVA: 0x00FC3880 File Offset: 0x00FC1A80
		private unsafe void GetSpanBehaviorId(int dayIndex, out int dayBehaviorId, out int duskBehaviorId)
		{
			dayBehaviorId = 0;
			duskBehaviorId = 0;
			int num = int.MinValue;
			int num2 = int.MinValue;
			IReadOnlyList<SolarSchoolSpan> spanList = SolarSchoolConfig.Instance.GetSpanList(this.ActivityId);
			if (spanList == null)
			{
				return;
			}
			foreach (SolarSchoolSpan span in spanList)
			{
				if (dayIndex >= span.StartDayIndex && dayIndex <= span.EndDayIndex && !(span.ModifierType != "AutoPlaceBehavior"))
				{
					int num3 = this.ReadSpanBehaviorId(span);
					if (num3 != 0)
					{
						SolarSchoolBehavior? currentLevelRow = this.PlayerData.GetCurrentLevelRow(num3);
						if (currentLevelRow != null)
						{
							ESolarSchoolTimeSlot[] availableSlots = SolarSchoolUtils.GetAvailableSlots(currentLevelRow.Value);
							if (availableSlots.Length != 1)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.SolarSchool;
								ELogAuthor author = ELogAuthor.LRC;
								string message = "[SolarSchool] Span 自动置入行为的 AvailableTimeSlot 必须且只能配一个时段，已跳过";
								<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", num3);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("slotCount", availableSlots.Length);
								instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
							}
							else
							{
								ESolarSchoolTimeSlot esolarSchoolTimeSlot = availableSlots[0];
								if (esolarSchoolTimeSlot == ESolarSchoolTimeSlot.Day && span.Priority > num)
								{
									dayBehaviorId = num3;
									num = span.Priority;
								}
								else if (esolarSchoolTimeSlot == ESolarSchoolTimeSlot.Dusk && span.Priority > num2)
								{
									duskBehaviorId = num3;
									num2 = span.Priority;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0603863D RID: 230973 RVA: 0x00FC3A18 File Offset: 0x00FC1C18
		private int ReadSpanBehaviorId(SolarSchoolSpan span)
		{
			int i = 0;
			while (i < span.ModifierParamsLength)
			{
				DicStringString? dicStringString = span.ModifierParams(i);
				if (dicStringString != null && dicStringString.Value.Key == "BehaviorId")
				{
					int result;
					if (!int.TryParse(dicStringString.Value.Value, out result))
					{
						return 0;
					}
					return result;
				}
				else
				{
					i++;
				}
			}
			return 0;
		}

		// Token: 0x0603863E RID: 230974 RVA: 0x00FC3A84 File Offset: 0x00FC1C84
		private unsafe void RecomputeInstanceDistribution(int activityId, int instanceId)
		{
			this.MapData.ClearAllLocationRoles();
			foreach (SolarSchoolLocation solarSchoolLocation in SolarSchoolConfig.Instance.GetLocationList(activityId, instanceId))
			{
				int[] roleIdsArray = solarSchoolLocation.GetRoleIdsArray();
				if (roleIdsArray.Length != 0)
				{
					if (roleIdsArray.Length > 1)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.LRC;
						string message = "[SolarSchool] 副本地点配了多个角色，只取首个";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("instanceId", instanceId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("locationId", solarSchoolLocation.Id);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("roleCount", roleIdsArray.Length);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					this.MapData.SetLocationRole(solarSchoolLocation.Id, roleIdsArray[0], true);
				}
			}
		}

		// Token: 0x0603863F RID: 230975 RVA: 0x00FC3B94 File Offset: 0x00FC1D94
		private void RecomputeTodayDistribution(int activityId, int datOfWeek)
		{
			this.MapData.ClearAllLocationRoles();
			IReadOnlyList<SolarSchoolRoleSchedule> roleScheduleList = SolarSchoolConfig.Instance.GetRoleScheduleList(activityId);
			if (roleScheduleList == null)
			{
				return;
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			Dictionary<int, List<int>> dictionary2 = new Dictionary<int, List<int>>();
			this.CollectTodaySchedule(roleScheduleList, datOfWeek, dictionary, dictionary2);
			HashSet<int> usedRoleIds = new HashSet<int>();
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				this.MapData.SetLocationRole(keyValuePair.Key, keyValuePair.Value, true);
				usedRoleIds.Add(keyValuePair.Value);
			}
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, List<int>> keyValuePair2 in dictionary2)
			{
				if (!dictionary.ContainsKey(keyValuePair2.Key))
				{
					list.Add(keyValuePair2.Key);
				}
			}
			this.Shuffle(list);
			Predicate<int> <>9__0;
			foreach (int num in list)
			{
				List<int> list2 = dictionary2[num];
				List<int> list3 = list2;
				Predicate<int> match;
				if ((match = <>9__0) == null)
				{
					match = (<>9__0 = ((int roleId) => usedRoleIds.Contains(roleId)));
				}
				list3.RemoveAll(match);
				if (list2.Count != 0)
				{
					int num2 = list2[this.GetRandomIndex(list2.Count)];
					usedRoleIds.Add(num2);
					this.MapData.SetLocationRole(num, num2, false);
				}
			}
		}

		// Token: 0x06038640 RID: 230976 RVA: 0x00FC3D5C File Offset: 0x00FC1F5C
		private unsafe void CollectTodaySchedule(IReadOnlyList<SolarSchoolRoleSchedule> list, int datOfWeek, Dictionary<int, int> residentPlan, Dictionary<int, List<int>> randomPool)
		{
			foreach (SolarSchoolRoleSchedule row in list)
			{
				if (this.FriendData.IsRoleUnlocked(row.RoleId))
				{
					int[] weekdayRule = this.GetWeekdayRule(row, datOfWeek);
					if (weekdayRule.Length != 0)
					{
						if (weekdayRule.Length < 2)
						{
							Log instance = Log.Instance;
							ELogModule module = ELogModule.SolarSchool;
							ELogAuthor author = ELogAuthor.LRC;
							string message = "[SolarSchool] 角色行程当天列只有 type 没配地点，忽略";
							<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", row.RoleId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("weekday", datOfWeek);
							instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
						}
						else
						{
							int num = weekdayRule[0];
							if (num == 0)
							{
								if (weekdayRule.Length > 2)
								{
									Log instance2 = Log.Instance;
									ELogModule module2 = ELogModule.SolarSchool;
									ELogAuthor author2 = ELogAuthor.LRC;
									string message2 = "[SolarSchool] 固定角色一天配了多个地点，取首个";
									<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("roleId", row.RoleId);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("weekday", datOfWeek);
									instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
								}
								int num2 = weekdayRule[1];
								int num3;
								if (residentPlan.TryGetValue(num2, out num3))
								{
									Log instance3 = Log.Instance;
									ELogModule module3 = ELogModule.SolarSchool;
									ELogAuthor author3 = ELogAuthor.LRC;
									string message3 = "[SolarSchool] 同地点同日配了多个固定角色，取首行";
									<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("locationId", num2);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("keepRole", num3);
									*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("dropRole", row.RoleId);
									instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
								}
								else
								{
									residentPlan[num2] = row.RoleId;
								}
							}
							else if (num == 1)
							{
								for (int i = 1; i < weekdayRule.Length; i++)
								{
									int key = weekdayRule[i];
									List<int> list2;
									if (!randomPool.TryGetValue(key, out list2))
									{
										list2 = new List<int>();
										randomPool[key] = list2;
									}
									list2.Add(row.RoleId);
								}
							}
							else
							{
								Log instance4 = Log.Instance;
								ELogModule module4 = ELogModule.SolarSchool;
								ELogAuthor author4 = ELogAuthor.LRC;
								string message4 = "[SolarSchool] 角色行程当天列 type 非法";
								<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray3<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("roleId", row.RoleId);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("weekday", datOfWeek);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 2) = new ValueTuple<string, object>("type", num);
								instance4.Warn(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 3));
							}
						}
					}
				}
			}
		}

		// Token: 0x06038641 RID: 230977 RVA: 0x00FC4054 File Offset: 0x00FC2254
		private void Shuffle(List<int> values)
		{
			for (int i = values.Count - 1; i > 0; i--)
			{
				int randomIndex = this.GetRandomIndex(i + 1);
				int index = i;
				int index2 = randomIndex;
				int value = values[randomIndex];
				int value2 = values[i];
				values[index] = value;
				values[index2] = value2;
			}
		}

		// Token: 0x06038642 RID: 230978 RVA: 0x00FC40AC File Offset: 0x00FC22AC
		private int[] GetWeekdayRule(SolarSchoolRoleSchedule row, int dayOfWeek)
		{
			switch (dayOfWeek)
			{
			case 1:
				return row.GetMondayArray();
			case 2:
				return row.GetTuesdayArray();
			case 3:
				return row.GetWednesdayArray();
			case 4:
				return row.GetThursdayArray();
			case 5:
				return row.GetFridayArray();
			case 6:
				return row.GetSaturdayArray();
			case 7:
				return row.GetSundayArray();
			default:
				return Array.Empty<int>();
			}
		}

		// Token: 0x06038643 RID: 230979 RVA: 0x00FC411C File Offset: 0x00FC231C
		private int GetRandomIndex(int count)
		{
			if (count > 1)
			{
				return RandomSystem.GetRandomInteger() % count;
			}
			return 0;
		}

		// Token: 0x17006C01 RID: 27649
		// (get) Token: 0x06038644 RID: 230980 RVA: 0x00FC412B File Offset: 0x00FC232B
		public IReadOnlyList<int> SelectedEndingIds
		{
			get
			{
				return this.SelectedEndingIdList;
			}
		}

		// Token: 0x17006C02 RID: 27650
		// (get) Token: 0x06038645 RID: 230981 RVA: 0x00FC4133 File Offset: 0x00FC2333
		// (set) Token: 0x06038646 RID: 230982 RVA: 0x00FC413B File Offset: 0x00FC233B
		public VisualNovelDate? EndingVisualNovelTime { get; private set; }

		// Token: 0x17006C03 RID: 27651
		// (get) Token: 0x06038647 RID: 230983 RVA: 0x00FC4144 File Offset: 0x00FC2344
		// (set) Token: 0x06038648 RID: 230984 RVA: 0x00FC414C File Offset: 0x00FC234C
		public bool IsDateHiddenByEnding { get; private set; }

		// Token: 0x17006C04 RID: 27652
		// (get) Token: 0x06038649 RID: 230985 RVA: 0x00FC4155 File Offset: 0x00FC2355
		public bool IsInEndingStage
		{
			get
			{
				return this.GetCurrentStateType() == ESolarSchoolStageStateType.Ending;
			}
		}

		// Token: 0x0603864A RID: 230986 RVA: 0x00FC4160 File Offset: 0x00FC2360
		public void SetDateHiddenByEnding(bool hidden)
		{
			this.IsDateHiddenByEnding = hidden;
			SolarSchoolRootViewModel rootViewModel = this.RootViewModel;
			if (rootViewModel == null)
			{
				return;
			}
			Action refreshDateVisible = rootViewModel.RefreshDateVisible;
			if (refreshDateVisible == null)
			{
				return;
			}
			refreshDateVisible();
		}

		// Token: 0x0603864B RID: 230987 RVA: 0x00FC4184 File Offset: 0x00FC2384
		public unsafe void CaptureEndingSnapshot()
		{
			this.EndingSnapshot = new SolarSchoolEndingSnapshot(this);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 已定格结局快照";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dayIndex", this.TimeData.DayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("totalDay", this.TotalDay);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x0603864C RID: 230988 RVA: 0x00FC420C File Offset: 0x00FC240C
		public int GetConditionAttr(ESolarSchoolSecondAttr attr)
		{
			SolarSchoolEndingSnapshot endingSnapshot = this.EndingSnapshot;
			if (endingSnapshot == null)
			{
				return this.PlayerData.GetAttr(attr);
			}
			return endingSnapshot.GetAttr(attr);
		}

		// Token: 0x0603864D RID: 230989 RVA: 0x00FC422B File Offset: 0x00FC242B
		public int GetConditionInfluenceLevel(ESolarSchoolInfluence influence)
		{
			SolarSchoolEndingSnapshot endingSnapshot = this.EndingSnapshot;
			if (endingSnapshot == null)
			{
				return this.PlayerData.GetInfluenceLevel(influence);
			}
			return endingSnapshot.GetInfluenceLevel(influence);
		}

		// Token: 0x0603864E RID: 230990 RVA: 0x00FC424A File Offset: 0x00FC244A
		public int GetConditionExamScore(int examId)
		{
			SolarSchoolEndingSnapshot endingSnapshot = this.EndingSnapshot;
			if (endingSnapshot == null)
			{
				return this.PlayerData.GetExamScore(examId);
			}
			return endingSnapshot.GetExamScore(examId);
		}

		// Token: 0x0603864F RID: 230991 RVA: 0x00FC4269 File Offset: 0x00FC2469
		public bool IsConditionRoleUnlocked(int roleId)
		{
			SolarSchoolEndingSnapshot endingSnapshot = this.EndingSnapshot;
			if (endingSnapshot == null)
			{
				return this.FriendData.IsRoleUnlocked(roleId);
			}
			return endingSnapshot.IsRoleUnlocked(roleId);
		}

		// Token: 0x06038650 RID: 230992 RVA: 0x00FC4288 File Offset: 0x00FC2488
		public int GetConditionFavorLevel(int roleId)
		{
			SolarSchoolEndingSnapshot endingSnapshot = this.EndingSnapshot;
			if (endingSnapshot == null)
			{
				return this.FriendData.GetFavorLevel(roleId);
			}
			return endingSnapshot.GetFavorLevel(roleId);
		}

		// Token: 0x06038651 RID: 230993 RVA: 0x00FC42A7 File Offset: 0x00FC24A7
		public bool IsConditionFavorValueFull(int roleId)
		{
			SolarSchoolEndingSnapshot endingSnapshot = this.EndingSnapshot;
			if (endingSnapshot == null)
			{
				return this.FriendData.IsFavorValueFull(roleId);
			}
			return endingSnapshot.IsFavorValueFull(roleId);
		}

		// Token: 0x06038652 RID: 230994 RVA: 0x00FC42C6 File Offset: 0x00FC24C6
		public int GetConditionGiftReceivedCount(int roleId)
		{
			SolarSchoolEndingSnapshot endingSnapshot = this.EndingSnapshot;
			if (endingSnapshot == null)
			{
				return this.FriendData.GetGiftReceivedCount(roleId);
			}
			return endingSnapshot.GetGiftReceivedCount(roleId);
		}

		// Token: 0x06038653 RID: 230995 RVA: 0x00FC42E5 File Offset: 0x00FC24E5
		public int GetConditionCycleCount()
		{
			SolarSchoolEndingSnapshot endingSnapshot = this.EndingSnapshot;
			if (endingSnapshot == null)
			{
				return this.CycleCount;
			}
			return endingSnapshot.CycleCount;
		}

		// Token: 0x06038654 RID: 230996 RVA: 0x00FC4300 File Offset: 0x00FC2500
		public void ResetEndingRuntime()
		{
			this.SelectedEndingIdList.Clear();
			this.EndingVisualNovelTime = null;
			this.EndingSnapshot = null;
			this.SetDateHiddenByEnding(false);
		}

		// Token: 0x06038655 RID: 230997 RVA: 0x00FC4335 File Offset: 0x00FC2535
		public bool TrySetEndingVisualNovelTime(VisualNovelDate date)
		{
			if (this.GetCurrentStateType() != ESolarSchoolStageStateType.Ending)
			{
				return false;
			}
			this.EndingVisualNovelTime = new VisualNovelDate?(date);
			return true;
		}

		// Token: 0x06038656 RID: 230998 RVA: 0x00FC4350 File Offset: 0x00FC2550
		public void ClearEndingVisualNovelTime()
		{
			this.EndingVisualNovelTime = null;
			this.SetDateHiddenByEnding(false);
		}

		// Token: 0x06038657 RID: 230999 RVA: 0x00FC4373 File Offset: 0x00FC2573
		public void SelectEnding(int endingId)
		{
			if (!this.SelectedEndingIdList.Contains(endingId))
			{
				this.SelectedEndingIdList.Add(endingId);
			}
		}

		// Token: 0x06038658 RID: 231000 RVA: 0x00FC4390 File Offset: 0x00FC2590
		public void EnterEndingDay()
		{
			if (this.IsAfterLastDay)
			{
				return;
			}
			int totalDay = this.TotalDay;
			if (totalDay <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 进入结局日失败：总天数读取失败，检查 SolarSchoolParam 的 TotalDays 配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", this.ActivityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.TimeData.SetEndingDayIndex(totalDay + 1);
			this.CaptureWeekSnapshot(SolarSchoolSaveReason.SolarSchoolReasonNewWeek, true, null);
		}

		// Token: 0x06038659 RID: 231001 RVA: 0x00FC43FD File Offset: 0x00FC25FD
		public bool InitGame(int activityId)
		{
			return this.InitGameInternal(activityId, 0, null, 1, null, 0);
		}

		// Token: 0x0603865A RID: 231002 RVA: 0x00FC440B File Offset: 0x00FC260B
		public bool LoadGame(int activityId, int slotId, SolarSchoolSavePb save)
		{
			return this.IsSaveValid(activityId, save, "读档") && this.InitGameInternal(activityId, slotId, save, 1, null, 0);
		}

		// Token: 0x0603865B RID: 231003 RVA: 0x00FC442C File Offset: 0x00FC262C
		private unsafe bool IsSaveValid(int activityId, [Nullable(2)] SolarSchoolSavePb save, string operation)
		{
			if (((save != null) ? save.Game : null) == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] " + operation + "失败：存档为空";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("activityId", activityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (save.ActivityId != activityId)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "[SolarSchool] " + operation + "失败：存档活动不匹配";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", activityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("saveActivityId", save.ActivityId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			return true;
		}

		// Token: 0x0603865C RID: 231004 RVA: 0x00FC4500 File Offset: 0x00FC2700
		private void DisableGameplayNiagaraComputeShaders()
		{
			if (this.GameplayNiagaraComputeShadersOverridden)
			{
				return;
			}
			GameSettingsDeviceRender.Instance.TemporarySetIntCVar("fx.NiagaraAllowComputeShaders", 0);
			this.GameplayNiagaraComputeShadersOverridden = true;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "[SolarSchool][NiagaraWorkaround] 活动内禁用 Niagara ComputeShaders";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", UKismetSystemLibrary.GetConsoleVariableIntValue("fx.NiagaraAllowComputeShaders"));
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603865D RID: 231005 RVA: 0x00FC4568 File Offset: 0x00FC2768
		private void RestoreGameplayNiagaraComputeShaders()
		{
			if (!this.GameplayNiagaraComputeShadersOverridden)
			{
				return;
			}
			GameSettingsDeviceRender.Instance.TemporaryResetIntCVar("fx.NiagaraAllowComputeShaders");
			this.GameplayNiagaraComputeShadersOverridden = false;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LLX;
			string message = "[SolarSchool][NiagaraWorkaround] 恢复 Niagara ComputeShaders 原值";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", UKismetSystemLibrary.GetConsoleVariableIntValue("fx.NiagaraAllowComputeShaders"));
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603865E RID: 231006 RVA: 0x00FC45CC File Offset: 0x00FC27CC
		protected override bool OnClear()
		{
			this.RestoreGameplayNiagaraComputeShaders();
			return base.OnClear();
		}

		// Token: 0x0603865F RID: 231007 RVA: 0x00FC45DC File Offset: 0x00FC27DC
		[NullableContext(2)]
		private bool InitGameInternal(int activityId, int slotId, SolarSchoolSavePb save, int cycleCount = 1, [TupleElementNames(new string[]
		{
			"ItemId",
			"Count"
		})] [Nullable(new byte[]
		{
			2,
			0
		})] IReadOnlyList<ValueTuple<int, int>> inheritItems = null, int traceId = 0)
		{
			if (this.InGamePlay)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "SolarSchool 进入游戏失败：游戏已经开始", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			SolarSchoolController.Instance.ResetBatchSync();
			this.InGamePlay = true;
			this.ActivityId = activityId;
			this.RecordDataSet.Clear();
			this.TimeData = new SolarSchoolTimeData();
			this.PlayerData = new SolarSchoolPlayerData();
			this.FriendData = new SolarSchoolFriendData();
			this.QuestData = new SolarSchoolQuestData();
			this.InventoryData = new SolarSchoolInventoryData();
			this.ScheduleData = new SolarSchoolScheduleData();
			this.BonusData = new SolarSchoolBonusData();
			this.ShopData = new SolarSchoolShopData();
			this.AvgParamData = new SolarSchoolAvgParamData();
			this.PrizeDrawingData = new SolarSchoolPrizeDrawingData();
			this.SummaryRecordData = new SolarSchoolSummaryRecordData();
			this.MapData = new SolarSchoolMapData();
			this.ScratchTicketData = new SolarSchoolScratchTicketRoundData();
			foreach (SolarSchoolRecordBase solarSchoolRecordBase in this.RecordDataSet)
			{
				solarSchoolRecordBase.Init(activityId);
			}
			this.TimeData.Reset();
			this.AvgParamData.Reset();
			this.PlayerData.InitAttr();
			this.MapData.InitLocations(activityId);
			this.FriendData.InitRoles();
			if (save != null)
			{
				this.CurrentLocalRecord = SolarSchoolUtils.LoadLocalSlot(activityId, slotId);
				this.WeekSnapshotLocalRecord = SolarSchoolUtils.CloneLocalSlot(this.CurrentLocalRecord);
				SolarSchoolSavePreviewPb preview = save.Preview;
				this.CycleCount = ((preview != null) ? preview.CycleCount : 1);
				this.TraceId = save.TraceId;
				this.LoadRecord(save.Game);
				this.RestoreRuntimeAfterLoad();
				if (!this.IsAfterLastDay)
				{
					this.SummaryRecordData.EnsureCurrentMonthStarted(this.TimeData.DayIndex);
				}
				this.CurWeekSnapshot = save;
			}
			else
			{
				this.CurrentLocalRecord = new SolarSchoolSlotLocalData();
				this.WeekSnapshotLocalRecord = new SolarSchoolSlotLocalData();
				this.CycleCount = cycleCount;
				this.TraceId = ((traceId > 0) ? traceId : this.CreateTraceId());
				this.InheritItemsFromLastCycle(inheritItems);
				this.ScheduleData.SaveWeekInstanceIds(this.TimeData.CurrentMondayDayIndex);
				SolarSchoolQuestCenter.Instance.InitQuest(activityId);
				SolarSchoolSpecialBehaviorCenter.Instance.Init(activityId);
				this.ShopData.Refresh(this.ActivityId, this.TimeData.GetCurrentWeek());
				this.SummaryRecordData.EnsureCurrentMonthStarted(this.TimeData.DayIndex);
				this.CaptureWeekSnapshot(SolarSchoolSaveReason.SolarSchoolReasonNewCycle, true, delegate(bool _)
				{
					this.EnterGameStartAfterNewCycleSaved();
				});
			}
			this.MapData.WatchLocationsUnlock();
			this.PlayerData.WatchBehaviorsUnlock(activityId);
			this.InitTimerSystem();
			this.InitStateMachine();
			EventSystem.Instance.Add(EEventName.ClearSceneBegin, new Action(this.OnClearSceneBegin));
			EventSystem.Instance.Add(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
			this.DisableGameplayNiagaraComputeShaders();
			if (save != null)
			{
				this.ChangeState(ESolarSchoolStageStateType.GameStart);
			}
			return true;
		}

		// Token: 0x06038660 RID: 231008 RVA: 0x00FC48DC File Offset: 0x00FC2ADC
		private void EnterGameStartAfterNewCycleSaved()
		{
			if (!this.InGamePlay || this.GetCurrentStateType() != ESolarSchoolStageStateType.None)
			{
				return;
			}
			SolarSchoolModel.Instance.OpenLoadingView();
			this.ChangeState(ESolarSchoolStageStateType.GameStart);
		}

		// Token: 0x06038661 RID: 231009 RVA: 0x00FC4904 File Offset: 0x00FC2B04
		[NullableContext(0)]
		public UniTask<bool> StartNextCycleAsync()
		{
			SolarSchoolGamePlayModel.<StartNextCycleAsync>d__192 <StartNextCycleAsync>d__;
			<StartNextCycleAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<StartNextCycleAsync>d__.<>4__this = this;
			<StartNextCycleAsync>d__.<>1__state = -1;
			<StartNextCycleAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<StartNextCycleAsync>d__192>(ref <StartNextCycleAsync>d__);
			return <StartNextCycleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038662 RID: 231010 RVA: 0x00FC4948 File Offset: 0x00FC2B48
		[return: TupleElementNames(new string[]
		{
			"ItemId",
			"Count"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private List<ValueTuple<int, int>> CollectInheritItems()
		{
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			foreach (KeyValuePair<int, SolarSchoolItemData> keyValuePair in this.InventoryData.Items)
			{
				SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(keyValuePair.Key);
				if (item != null && item.Value.ItemType == 2)
				{
					list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value.Count));
				}
			}
			return list;
		}

		// Token: 0x06038663 RID: 231011 RVA: 0x00FC49E8 File Offset: 0x00FC2BE8
		private void InheritItemsFromLastCycle([TupleElementNames(new string[]
		{
			"ItemId",
			"Count"
		})] [Nullable(new byte[]
		{
			2,
			0
		})] IReadOnlyList<ValueTuple<int, int>> inheritItems)
		{
			if (inheritItems == null || inheritItems.Count == 0)
			{
				return;
			}
			foreach (ValueTuple<int, int> valueTuple in inheritItems)
			{
				int item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				this.InventoryData.AddInheritedItem(item, item2);
			}
			this.RebuildSpecialItemBonuses();
		}

		// Token: 0x06038664 RID: 231012 RVA: 0x00FC4A54 File Offset: 0x00FC2C54
		internal void InitGameplayAudioState()
		{
			this.InitViewNameSet();
			this.RefreshGameplayAudioState();
			this.RefreshFilterState();
		}

		// Token: 0x06038665 RID: 231013 RVA: 0x00FC4A68 File Offset: 0x00FC2C68
		internal void ClearGameplayAudioState()
		{
			this.ViewNameSet.Clear();
			this.ViewAudioStates.Clear();
			if (this.CurrentFilterState != "none")
			{
				AudioSystem.Instance.SetState("solarschool_filter", "none", true);
			}
			this.SeasonAudioState = string.Empty;
			this.DaytimeAudioState = string.Empty;
			this.CurrentFilterState = string.Empty;
		}

		// Token: 0x06038666 RID: 231014 RVA: 0x00FC4AD4 File Offset: 0x00FC2CD4
		internal void AddGameplayAudioEvents()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.RefreshGameplayAudioState));
			EventSystem.Instance.Add(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Add(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x06038667 RID: 231015 RVA: 0x00FC4B30 File Offset: 0x00FC2D30
		internal void RemoveGameplayAudioEvents()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.RefreshGameplayAudioState));
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			EventSystem.Instance.Remove(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}

		// Token: 0x06038668 RID: 231016 RVA: 0x00FC4B8A File Offset: 0x00FC2D8A
		internal void PushGameplayAudioFilter()
		{
			this.GameplayAudioFilterHandle = AudioFilterController.Instance.PushGameplayFilterState("ui_only_ui", "SolarSchool");
		}

		// Token: 0x06038669 RID: 231017 RVA: 0x00FC4BA6 File Offset: 0x00FC2DA6
		internal void RemoveGameplayAudioFilter()
		{
			if (this.GameplayAudioFilterHandle != 0)
			{
				AudioFilterController.Instance.RemoveGameplayFilterState(this.GameplayAudioFilterHandle, "SolarSchool");
				this.GameplayAudioFilterHandle = 0;
			}
		}

		// Token: 0x0603866A RID: 231018 RVA: 0x00FC4BCC File Offset: 0x00FC2DCC
		internal void PlayGameplayBgm()
		{
			this.GameplayBgmHandle = AudioSystem.Instance.PostEvent("play_solarschool_main");
		}

		// Token: 0x0603866B RID: 231019 RVA: 0x00FC4BE4 File Offset: 0x00FC2DE4
		internal void StopGameplayBgm()
		{
			if (this.GameplayBgmHandle != 0)
			{
				AudioSystem.Instance.ExecuteAction(this.GameplayBgmHandle, EAudioActionType.Stop, null);
				this.GameplayBgmHandle = 0;
			}
		}

		// Token: 0x0603866C RID: 231020 RVA: 0x00FC4C1C File Offset: 0x00FC2E1C
		private void RefreshGameplayAudioState()
		{
			SolarSchoolTimeSlot? timeSlot = SolarSchoolConfig.Instance.GetTimeSlot(this.TimeData.DisplaySlot);
			SolarSchoolDatePeriod? datePeriod = SolarSchoolConfig.Instance.GetDatePeriod(this.ActivityId, this.TimeData.DayIndex);
			string state = ((datePeriod != null) ? datePeriod.GetValueOrDefault().AudioState : null) ?? string.Empty;
			string state2 = ((timeSlot != null) ? timeSlot.GetValueOrDefault().AudioState : null) ?? string.Empty;
			SolarSchoolGamePlayModel.SetAudioState("solarschool_season", state, ref this.SeasonAudioState);
			SolarSchoolGamePlayModel.SetAudioState("solarschool_daytime", state2, ref this.DaytimeAudioState);
		}

		// Token: 0x0603866D RID: 231021 RVA: 0x00FC4CCC File Offset: 0x00FC2ECC
		private void InitViewNameSet()
		{
			this.ViewNameSet.Clear();
			foreach (SolarSchoolViewInfo solarSchoolViewInfo in SolarSchoolConfig.Instance.GetViewInfoList(this.ActivityId))
			{
				this.ViewNameSet.Add(solarSchoolViewInfo.ViewName);
			}
		}

		// Token: 0x0603866E RID: 231022 RVA: 0x00FC4D3C File Offset: 0x00FC2F3C
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			string text = viewName.ToString();
			if (!this.ViewNameSet.Contains(text))
			{
				return;
			}
			SolarSchoolViewInfo value = SolarSchoolConfig.Instance.GetViewInfo(text).Value;
			if (string.IsNullOrEmpty(value.AudioState))
			{
				return;
			}
			UiViewBase view = UiManager.Instance.GetView(viewId);
			UUIItem uuiitem = (view != null) ? view.GetRootItem() : null;
			if (uuiitem == null)
			{
				return;
			}
			int flattenHierarchyIndex = uuiitem.GetFlattenHierarchyIndex();
			this.ViewAudioStates[viewId] = new SolarSchoolGamePlayModel.ViewAudioState(flattenHierarchyIndex, value.AudioState);
			this.RefreshFilterState();
		}

		// Token: 0x0603866F RID: 231023 RVA: 0x00FC4DCC File Offset: 0x00FC2FCC
		private void OnCloseView(EUiViewName _, int viewId)
		{
			if (this.ViewAudioStates.Remove(viewId))
			{
				this.RefreshFilterState();
			}
		}

		// Token: 0x06038670 RID: 231024 RVA: 0x00FC4DE4 File Offset: 0x00FC2FE4
		private void RefreshFilterState()
		{
			SolarSchoolGamePlayModel.ViewAudioState? viewAudioState;
			string state = ((this.FindTopViewAudioState() != null) ? viewAudioState.GetValueOrDefault().AudioState : null) ?? "none";
			SolarSchoolGamePlayModel.SetAudioState("solarschool_filter", state, ref this.CurrentFilterState);
		}

		// Token: 0x06038671 RID: 231025 RVA: 0x00FC4E2C File Offset: 0x00FC302C
		private SolarSchoolGamePlayModel.ViewAudioState? FindTopViewAudioState()
		{
			SolarSchoolGamePlayModel.ViewAudioState? result = null;
			foreach (SolarSchoolGamePlayModel.ViewAudioState viewAudioState in this.ViewAudioStates.Values)
			{
				if (result == null || viewAudioState.Depth >= result.Value.Depth)
				{
					result = new SolarSchoolGamePlayModel.ViewAudioState?(viewAudioState);
				}
			}
			return result;
		}

		// Token: 0x06038672 RID: 231026 RVA: 0x00FC4EAC File Offset: 0x00FC30AC
		private static void SetAudioState(string group, string state, ref string currentState)
		{
			if (string.IsNullOrEmpty(state) || currentState == state)
			{
				return;
			}
			AudioSystem.Instance.SetState(group, state, true);
			currentState = state;
		}

		// Token: 0x06038673 RID: 231027 RVA: 0x00FC4ED4 File Offset: 0x00FC30D4
		public void BuildWorldDataByDayIndex(int dayIndex)
		{
			this.BuildWorldData(dayIndex);
			this.FriendData.FillTodayOptions(this.ActivityId, this.InstanceId);
			if (this.InstanceType == ESolarSchoolInstanceType.Normal)
			{
				this.RecomputeTodayDistribution(this.ActivityId, this.GetWeekday());
				return;
			}
			this.RecomputeInstanceDistribution(this.ActivityId, this.InstanceId);
		}

		// Token: 0x06038674 RID: 231028 RVA: 0x00FC4F2C File Offset: 0x00FC312C
		private void InitStateMachine()
		{
			this.StageFsm = new SolarSchoolStageFsm();
			this.StageFsm.Init();
		}

		// Token: 0x06038675 RID: 231029 RVA: 0x00FC4F44 File Offset: 0x00FC3144
		public void ChangeState(ESolarSchoolStageStateType state)
		{
			this.StageFsm.ChangeState(state).Forget();
		}

		// Token: 0x06038676 RID: 231030 RVA: 0x00FC4F57 File Offset: 0x00FC3157
		public UniTask ChangeStateAsync(ESolarSchoolStageStateType state)
		{
			return this.StageFsm.ChangeState(state);
		}

		// Token: 0x06038677 RID: 231031 RVA: 0x00FC4F65 File Offset: 0x00FC3165
		public ESolarSchoolStageStateType GetCurrentStateType()
		{
			if (this.StageFsm == null)
			{
				return ESolarSchoolStageStateType.None;
			}
			return this.StageFsm.GetCurrentStateType();
		}

		// Token: 0x06038678 RID: 231032 RVA: 0x00FC4F7C File Offset: 0x00FC317C
		public void GameEnd()
		{
			this.RestoreGameplayNiagaraComputeShaders();
			if (!this.InGamePlay)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "SolarSchool 结束游戏失败：游戏未开始", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			EventSystem.Instance.Remove(EEventName.ClearSceneBegin, new Action(this.OnClearSceneBegin));
			EventSystem.Instance.Remove(EEventName.OnEnterOnlineWorld, new Action(this.OnEnterOnlineWorld));
			SolarSchoolController.Instance.FlushBatchSync();
			SolarSchoolQuestCenter.Instance.EndQuest();
			SolarSchoolSpecialBehaviorCenter.Instance.End();
			this.PlayerData.UnwatchBehaviorsUnlock();
			this.ClearTimerSystem();
			this.PendingAttrRankUps.Clear();
			this.CheckingBehaviorUnlockIds.Clear();
			this.ClearData();
			ActivityConditionCenter.Instance.ClearIdlePools();
		}

		// Token: 0x06038679 RID: 231033 RVA: 0x00FC5044 File Offset: 0x00FC3244
		private void OnClearSceneBegin()
		{
			this.ForceExit("切场景清理");
		}

		// Token: 0x0603867A RID: 231034 RVA: 0x00FC5051 File Offset: 0x00FC3251
		private void OnEnterOnlineWorld()
		{
			this.ForceExit("进入联机");
		}

		// Token: 0x0603867B RID: 231035 RVA: 0x00FC5060 File Offset: 0x00FC3260
		private unsafe void ForceExit(string reason)
		{
			if (!this.InGamePlay || this.GetCurrentStateType() == ESolarSchoolStageStateType.GameExit)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 强制退出局内";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", this.GetCurrentStateType());
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.IsForceExiting = true;
			this.AbortCurrentStateTask();
			this.ChangeState(ESolarSchoolStageStateType.GameExit);
		}

		// Token: 0x0603867C RID: 231036 RVA: 0x00FC50F4 File Offset: 0x00FC32F4
		private void ClearData()
		{
			this.InGamePlay = false;
			this.IsForceExiting = false;
			this.BehaviorFastForwardEnabled = false;
			this.ActivityId = 0;
			this.StageFsm = null;
			this.RecordDataSet.Clear();
			this.TimeData = null;
			this.PlayerData = null;
			this.FriendData = null;
			this.QuestData = null;
			this.InventoryData = null;
			this.BonusData = null;
			this.ShopData = null;
			this.AvgParamData = null;
			this.PrizeDrawingData = null;
			this.SummaryRecordData = null;
			this.ScheduleData = null;
			this.MapData.Clear();
			this.MapData = null;
			this.CurWeekSnapshot = null;
			this.CurrentLocalRecord = new SolarSchoolSlotLocalData();
			this.WeekSnapshotLocalRecord = new SolarSchoolSlotLocalData();
			this.LastResetMondayDayIndex = 0;
			this.PendingSkipTargetDayIndex = 0;
			this.NoScheduleTipMondayDayIndex = 0;
			this.CycleCount = 1;
			this.TraceId = 0;
			this.ResetEndingRuntime();
			this.ResetWorldData();
			this.ScratchTicketData.Clear();
			this.ScratchTicketData = null;
		}

		// Token: 0x0603867D RID: 231037 RVA: 0x00FC51EC File Offset: 0x00FC33EC
		public bool ShouldShowShopEntryTip()
		{
			return this.ShopData.ShouldShowEntryTip() && this.ShopData.IsShopOpen() && this.InstanceType == ESolarSchoolInstanceType.Normal;
		}

		// Token: 0x0603867E RID: 231038 RVA: 0x00FC5213 File Offset: 0x00FC3413
		public bool TryOpenAvailableShop()
		{
			if (!this.ShopData.IsShopOpen())
			{
				return false;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolShopView, null, null);
			return true;
		}

		// Token: 0x0603867F RID: 231039 RVA: 0x00FC5236 File Offset: 0x00FC3436
		public List<SolarSchoolShopGoodsData> GetCurrentShopGoods()
		{
			if (!this.ShopData.IsShopOpen())
			{
				return new List<SolarSchoolShopGoodsData>();
			}
			return this.ShopData.GetVisibleGoodsList();
		}

		// Token: 0x06038680 RID: 231040 RVA: 0x00FC5258 File Offset: 0x00FC3458
		public bool BuyShopGoods(int shopId, int goodsId, int count)
		{
			if (count <= 0 || !this.ShopData.IsShopOpen())
			{
				return false;
			}
			SolarSchoolShopGoodsData goods = this.ShopData.GetGoods(shopId, goodsId);
			if (goods == null)
			{
				return false;
			}
			long num = (long)goods.GetPrice() * (long)count;
			if (count > goods.GetRemainingCount() || num > (long)this.PlayerData.GetAttr(ESolarSchoolSecondAttr.Money))
			{
				return false;
			}
			if (!this.InventoryData.CanAddItem(goods.Goods.ItemId, count, goods.Item.StackLimit))
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchoolItem99", Array.Empty<object>());
				return false;
			}
			goods.AddBoughtCount(count);
			SolarSchoolController.Instance.EnqueueShopBuy(goods.ShopId, goodsId, count);
			this.PlayerData.AddAttr(ESolarSchoolSecondAttr.Money, -(int)num);
			this.AddItem(goods.Goods.ItemId, count);
			this.SummaryRecordData.RecordManualPurchase();
			EventSystem.Instance.Emit(EEventName.SolarSchoolShopPurchaseChanged);
			return true;
		}

		// Token: 0x06038681 RID: 231041 RVA: 0x00FC534C File Offset: 0x00FC354C
		public int GetAutoPlacedBehaviorId(int dayIndex, ESolarSchoolTimeSlot slot)
		{
			int num;
			int num2;
			this.GetSpanBehaviorId(dayIndex, out num, out num2);
			int result;
			if (slot != ESolarSchoolTimeSlot.Day)
			{
				if (slot != ESolarSchoolTimeSlot.Dusk)
				{
					result = 0;
				}
				else
				{
					result = num2;
				}
			}
			else
			{
				result = num;
			}
			return result;
		}

		// Token: 0x06038682 RID: 231042 RVA: 0x00FC537C File Offset: 0x00FC357C
		public void ResetScheduleOnWeekStart(bool uploadAutoSave = true)
		{
			if (this.TimeData.DayOfWeek != DayOfWeek.Monday)
			{
				return;
			}
			int currentMondayDayIndex = this.TimeData.CurrentMondayDayIndex;
			if (!this.ResetScheduleForWeek(currentMondayDayIndex, true))
			{
				return;
			}
			this.CaptureWeekSnapshot(SolarSchoolSaveReason.SolarSchoolReasonNewWeek, uploadAutoSave, null);
		}

		// Token: 0x06038683 RID: 231043 RVA: 0x00FC53B8 File Offset: 0x00FC35B8
		private bool ResetScheduleForWeek(int mondayDayIndex, bool refreshShop)
		{
			if (this.LastResetMondayDayIndex == mondayDayIndex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 本周已Reset过，跳过周一Reset";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mondayDayIndex", mondayDayIndex);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.LastResetMondayDayIndex = mondayDayIndex;
			this.ScheduleData.SaveDataForHistory();
			this.ScheduleData.Clear();
			this.ScheduleData.SaveWeekInstanceIds(mondayDayIndex);
			this.SetScheduleFromSpan(mondayDayIndex);
			if (refreshShop)
			{
				this.ShopData.Refresh(this.ActivityId, this.TimeData.GetWeek(mondayDayIndex));
			}
			this.SettleWeeklyBuffRewards(mondayDayIndex);
			Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 周一排期视图重排（已预填低级课）", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06038684 RID: 231044 RVA: 0x00FC5478 File Offset: 0x00FC3678
		private unsafe void SettleWeeklyBuffRewards(int mondayDayIndex)
		{
			if (this.PlayerData.IsWeeklyRewardSettled(mondayDayIndex))
			{
				return;
			}
			foreach (int num in this.PlayerData.GetActiveBuffIds())
			{
				SolarSchoolBuff? buff = SolarSchoolConfig.Instance.GetBuff(num);
				if (buff == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.SWC;
					string message = "[SolarSchool] 周 Buff 奖励结算时找不到 Buff 配置";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dayIndex", mondayDayIndex);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("buffId", num);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					int weeklyRewardId = buff.Value.WeeklyRewardId;
					if (weeklyRewardId != 0)
					{
						string item;
						if (weeklyRewardId < 0)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.SolarSchool;
							ELogAuthor author2 = ELogAuthor.SWC;
							string message2 = "[SolarSchool] 周 Buff 奖励组配置非法";
							<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("dayIndex", mondayDayIndex);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("buffId", num);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("weeklyRewardId", weeklyRewardId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("error", "WeeklyRewardId 必须大于等于 0");
							instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
						}
						else if (!SolarSchoolRewardCenter.Instance.TryGiveWeeklyReward(weeklyRewardId, out item))
						{
							Log instance3 = Log.Instance;
							ELogModule module3 = ELogModule.SolarSchool;
							ELogAuthor author3 = ELogAuthor.SWC;
							string message3 = "[SolarSchool] 周 Buff 奖励发放失败";
							<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("dayIndex", mondayDayIndex);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("buffId", num);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("weeklyRewardId", weeklyRewardId);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("error", item);
							instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
						}
					}
				}
			}
			this.PlayerData.MarkWeeklyRewardSettled(mondayDayIndex);
		}

		// Token: 0x06038685 RID: 231045 RVA: 0x00FC56DC File Offset: 0x00FC38DC
		private void SetScheduleFromSpan(int mondayDayIndex)
		{
			for (int i = 1; i <= 5; i++)
			{
				int dayIndex = mondayDayIndex + (i - 1);
				int num;
				int num2;
				this.GetSpanBehaviorId(dayIndex, out num, out num2);
				if (num != 0)
				{
					this.ScheduleData.PrefillBehavior(i, ESolarSchoolTimeSlot.Day, num);
				}
				if (num2 != 0)
				{
					this.ScheduleData.PrefillBehavior(i, ESolarSchoolTimeSlot.Dusk, num2);
				}
			}
		}

		// Token: 0x06038686 RID: 231046 RVA: 0x00FC5728 File Offset: 0x00FC3928
		private int GetWeekday()
		{
			return this.TimeData.CurrentWeekday;
		}

		// Token: 0x06038687 RID: 231047 RVA: 0x00FC5738 File Offset: 0x00FC3938
		public bool IsBehaviorUnlocked(int behaviorId)
		{
			if (!this.CheckingBehaviorUnlockIds.Add(behaviorId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 行为解锁条件存在循环依赖";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", behaviorId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			bool result;
			try
			{
				SolarSchoolBehavior? currentLevelRow = this.PlayerData.GetCurrentLevelRow(behaviorId);
				if (currentLevelRow == null)
				{
					result = false;
				}
				else
				{
					int showConditionGroupId = currentLevelRow.Value.ShowConditionGroupId;
					result = (showConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(showConditionGroupId));
				}
			}
			finally
			{
				this.CheckingBehaviorUnlockIds.Remove(behaviorId);
			}
			return result;
		}

		// Token: 0x06038688 RID: 231048 RVA: 0x00FC57E4 File Offset: 0x00FC39E4
		public bool CanExecuteBehavior(int behaviorId)
		{
			SolarSchoolBehavior? currentLevelRow = this.PlayerData.GetCurrentLevelRow(behaviorId);
			if (currentLevelRow == null)
			{
				return false;
			}
			int executeConditionGroupId = currentLevelRow.Value.ExecuteConditionGroupId;
			return executeConditionGroupId == 0 || ActivityConditionCenter.Instance.CheckGroup(executeConditionGroupId);
		}

		// Token: 0x06038689 RID: 231049 RVA: 0x00FC582C File Offset: 0x00FC3A2C
		public int GetBehaviorFatigueDelta(int behaviorId)
		{
			SolarSchoolBehavior? currentLevelRow = this.PlayerData.GetCurrentLevelRow(behaviorId);
			if (currentLevelRow == null)
			{
				return 0;
			}
			foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in this.GetBehaviorSuccessAttrDeltas(currentLevelRow.Value))
			{
				ESolarSchoolSecondAttr item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				if (item == ESolarSchoolSecondAttr.Fatigue)
				{
					return item2;
				}
			}
			return 0;
		}

		// Token: 0x0603868A RID: 231050 RVA: 0x00FC58B0 File Offset: 0x00FC3AB0
		public int GetFatigueAfterBehavior(int behaviorId)
		{
			int num = this.PlayerData.GetAttr(ESolarSchoolSecondAttr.Fatigue) + this.GetBehaviorFatigueDelta(behaviorId);
			SolarSchoolAttr? attrConfig = this.GetAttrConfig(ESolarSchoolSecondAttr.Fatigue);
			if (attrConfig != null)
			{
				return Math.Clamp(num, attrConfig.Value.MinValue, attrConfig.Value.MaxValue);
			}
			return num;
		}

		// Token: 0x0603868B RID: 231051 RVA: 0x00FC590C File Offset: 0x00FC3B0C
		public bool IsBehaviorFatigueOverflow(int behaviorId)
		{
			SolarSchoolBehavior? currentLevelRow = this.PlayerData.GetCurrentLevelRow(behaviorId);
			SolarSchoolAttr? attrConfig = this.GetAttrConfig(ESolarSchoolSecondAttr.Fatigue);
			return currentLevelRow != null && attrConfig != null && this.PlayerData.GetAttr(ESolarSchoolSecondAttr.Fatigue) + this.GetBehaviorFatigueDelta(behaviorId) > attrConfig.Value.MaxValue;
		}

		// Token: 0x0603868C RID: 231052 RVA: 0x00FC5968 File Offset: 0x00FC3B68
		public List<int> GetScheduleAvailableBehaviorsByCategory(ESolarSchoolBehaviorCategory category)
		{
			if (category == ESolarSchoolBehaviorCategory.Special)
			{
				return SolarSchoolSpecialBehaviorCenter.Instance.GetSchedulableBehaviorIds();
			}
			List<int> list = new List<int>();
			HashSet<int> hashSet = new HashSet<int>();
			IReadOnlyList<SolarSchoolBehavior> behaviorListByActivityId = SolarSchoolConfig.Instance.GetBehaviorListByActivityId(this.ActivityId);
			if (behaviorListByActivityId == null)
			{
				return list;
			}
			foreach (SolarSchoolBehavior behavior in behaviorListByActivityId)
			{
				if (behavior.IsWorkDay && behavior.Category == (int)category && behavior.BehaviorType == 3 && this.IsBehaviorUnlocked(behavior.BehaviorId))
				{
					if (!SolarSchoolUtils.CanPlaceInSlot(behavior, ESolarSchoolTimeSlot.Day) && !SolarSchoolUtils.CanPlaceInSlot(behavior, ESolarSchoolTimeSlot.Dusk))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.LRC;
						string message = "[SolarSchool] 可排期行为的 AvailableTimeSlot 必须包含白天或放学后，已跳过";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", behavior.BehaviorId);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					}
					else if (hashSet.Add(behavior.BehaviorId))
					{
						list.Add(behavior.BehaviorId);
					}
				}
			}
			list.Sort();
			return list;
		}

		// Token: 0x0603868D RID: 231053 RVA: 0x00FC5A84 File Offset: 0x00FC3C84
		public void SaveScheduleTempData(SolarSchoolScheduleBoard tempData)
		{
			this.ScheduleData.ApplyDraft(tempData);
			Log.Instance.Info(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 保存排期草稿", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x17006C05 RID: 27653
		// (get) Token: 0x0603868E RID: 231054 RVA: 0x00FC5ABC File Offset: 0x00FC3CBC
		[Nullable(2)]
		private SolarSchoolInProgressStateBase CurrentInProgressState
		{
			[NullableContext(2)]
			get
			{
				SolarSchoolStageFsm stageFsm = this.StageFsm;
				return ((stageFsm != null) ? stageFsm.GetCurrentState() : null) as SolarSchoolInProgressStateBase;
			}
		}

		// Token: 0x17006C06 RID: 27654
		// (get) Token: 0x0603868F RID: 231055 RVA: 0x00FC5AD5 File Offset: 0x00FC3CD5
		[Nullable(2)]
		private SolarSchoolTaskStateBase CurrentTaskState
		{
			[NullableContext(2)]
			get
			{
				SolarSchoolStageFsm stageFsm = this.StageFsm;
				return ((stageFsm != null) ? stageFsm.GetCurrentState() : null) as SolarSchoolTaskStateBase;
			}
		}

		// Token: 0x06038690 RID: 231056 RVA: 0x00FC5AEE File Offset: 0x00FC3CEE
		public bool IsCurrentStageState(object state)
		{
			return this.StageFsm != null && this.StageFsm.GetCurrentState() == state;
		}

		// Token: 0x06038691 RID: 231057 RVA: 0x00FC5B08 File Offset: 0x00FC3D08
		public void OnClickGoOut()
		{
			SolarSchoolInProgressStateBase currentInProgressState = this.CurrentInProgressState;
			if (currentInProgressState == null)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 当前状态不支持【外出】", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.ShouldRemindSchedule() && this.TryShowNoScheduleConfirm(new Action(currentInProgressState.OnClickGoOut)))
			{
				return;
			}
			currentInProgressState.OnClickGoOut();
		}

		// Token: 0x17006C07 RID: 27655
		// (get) Token: 0x06038692 RID: 231058 RVA: 0x00FC5B63 File Offset: 0x00FC3D63
		public bool CanUseSchedule
		{
			get
			{
				return this.InstanceType == ESolarSchoolInstanceType.Normal && !this.TimeData.IsWeekend();
			}
		}

		// Token: 0x06038693 RID: 231059 RVA: 0x00FC5B80 File Offset: 0x00FC3D80
		public void TryOpenScheduleView()
		{
			if (this.InstanceType != ESolarSchoolInstanceType.Normal)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Schedule_WeekendForbid", Array.Empty<object>());
				return;
			}
			if (this.TimeData.IsWeekend())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchool_Schedule_WeekendForbid_2", Array.Empty<object>());
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolScheduleView, null, null);
		}

		// Token: 0x06038694 RID: 231060 RVA: 0x00FC5BE0 File Offset: 0x00FC3DE0
		public bool ShouldRemindSchedule()
		{
			if (this.IsFunctionUnlocked(ESolarSchoolFunction.Schedule) && this.CanUseSchedule && this.NoScheduleTipMondayDayIndex != this.TimeData.CurrentMondayDayIndex)
			{
				ConfirmBoxModel instance = ConfirmBoxModel.Instance;
				if (instance == null || !instance.NotShowAgainSet.Contains(EConfirmBoxConfigId.SolarSchoolNoScheduleGoOutConfirm))
				{
					return !this.ScheduleData.HasPlayerScheduledBehavior();
				}
			}
			return false;
		}

		// Token: 0x06038695 RID: 231061 RVA: 0x00FC5C44 File Offset: 0x00FC3E44
		private bool TryShowNoScheduleConfirm(Action onConfirm)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SolarSchoolNoScheduleGoOutConfirm);
			confirmBoxDataNew.FunctionMap[2] = onConfirm;
			if (ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew))
			{
				this.NoScheduleTipMondayDayIndex = this.TimeData.CurrentMondayDayIndex;
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 未排程外出确认框弹出失败，直接外出，检查 ConfirmBox 配表";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", 596);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}

		// Token: 0x06038696 RID: 231062 RVA: 0x00FC5CC0 File Offset: 0x00FC3EC0
		public void OnClickMapLocation(int locationId)
		{
			SolarSchoolInProgressStateBase currentInProgressState = this.CurrentInProgressState;
			if (currentInProgressState == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前状态不支持点地图地点";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("locationId", locationId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			currentInProgressState.OnClickMapLocation(locationId);
		}

		// Token: 0x06038697 RID: 231063 RVA: 0x00FC5D10 File Offset: 0x00FC3F10
		public unsafe void PlayerChooseOption(int locationId, int optionId)
		{
			SolarSchoolInProgressStateBase currentInProgressState = this.CurrentInProgressState;
			if (currentInProgressState == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前状态不支持选地点选项";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("locationId", locationId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("optionId", optionId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			currentInProgressState.OnPlayerChooseOption(locationId, optionId);
		}

		// Token: 0x06038698 RID: 231064 RVA: 0x00FC5D90 File Offset: 0x00FC3F90
		public unsafe void PlayerChooseRoleOption(int roleId, int optionId)
		{
			SolarSchoolInProgressStateBase currentInProgressState = this.CurrentInProgressState;
			if (currentInProgressState == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前状态不支持选角色选项";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("optionId", optionId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			currentInProgressState.OnPlayerChooseRoleOption(roleId, optionId);
		}

		// Token: 0x06038699 RID: 231065 RVA: 0x00FC5E10 File Offset: 0x00FC4010
		public void PlayerChooseBehavior(int behaviorId)
		{
			SolarSchoolInProgressStateBase currentInProgressState = this.CurrentInProgressState;
			if (currentInProgressState == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 当前状态不支持选行为";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", behaviorId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			currentInProgressState.OnPlayerChooseBehavior(behaviorId);
		}

		// Token: 0x0603869A RID: 231066 RVA: 0x00FC5E5E File Offset: 0x00FC405E
		public bool CanPlayerFreeChoose()
		{
			SolarSchoolTaskStateBase currentTaskState = this.CurrentTaskState;
			return currentTaskState == null || currentTaskState.CanPlayerFreeChoose();
		}

		// Token: 0x0603869B RID: 231067 RVA: 0x00FC5E74 File Offset: 0x00FC4074
		public List<int> GetMapVisibleLocations()
		{
			List<int> list = new List<int>();
			foreach (SolarSchoolLocation solarSchoolLocation in SolarSchoolConfig.Instance.GetLocationList(this.ActivityId, this.InstanceId))
			{
				if (this.MapData.IsLocationAvailable(solarSchoolLocation.Id))
				{
					list.Add(solarSchoolLocation.Id);
				}
			}
			return list;
		}

		// Token: 0x0603869C RID: 231068 RVA: 0x00FC5EF4 File Offset: 0x00FC40F4
		public bool ShouldShowInvitationTag()
		{
			if (this.InstanceType != ESolarSchoolInstanceType.Normal || !this.TimeData.IsWeekend())
			{
				return false;
			}
			foreach (SolarSchoolLocation solarSchoolLocation in SolarSchoolConfig.Instance.GetLocationList(this.ActivityId, this.InstanceId))
			{
				if (this.MapData.IsLocationUnlocked(solarSchoolLocation.Id) && this.MapData.GetLocationRole(solarSchoolLocation.Id).RoleId != 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603869D RID: 231069 RVA: 0x00FC5F98 File Offset: 0x00FC4198
		public bool HasLocationNormalRedPoint(int locationId)
		{
			if (this.MapData.GetLocationData(locationId) == null)
			{
				return false;
			}
			SolarSchoolLocation? location = SolarSchoolConfig.Instance.GetLocation(locationId);
			return location != null && location.GetValueOrDefault().FirstRedDot && !this.MapData.HasEnteredLocation(locationId);
		}

		// Token: 0x0603869E RID: 231070 RVA: 0x00FC5FEF File Offset: 0x00FC41EF
		public bool HasLocationAffinityRedPoint(int locationId)
		{
			return this.MapData.GetLocationData(locationId) != null && SolarSchoolQuestCenter.Instance.HasPendingNode(ESolarSchoolTriggerTiming.AtLocationAffinity, locationId);
		}

		// Token: 0x0603869F RID: 231071 RVA: 0x00FC6010 File Offset: 0x00FC4210
		public void AddCurrentExamScore(int value)
		{
			SolarSchoolStageFsm stageFsm = this.StageFsm;
			SolarSchoolExamInProgressState solarSchoolExamInProgressState = ((stageFsm != null) ? stageFsm.GetCurrentState() : null) as SolarSchoolExamInProgressState;
			if (solarSchoolExamInProgressState == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[SolarSchool] 当前不在考试副本，加分丢弃";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			solarSchoolExamInProgressState.AddScore(value);
		}

		// Token: 0x060386A0 RID: 231072 RVA: 0x00FC606F File Offset: 0x00FC426F
		[NullableContext(2)]
		public bool TryGetOptionAction(int locationId, int optionId, out SolarSchoolActionBase action)
		{
			return this.TryGetOptionActionFrom(this.MapData.GetLocationOptions(locationId), optionId, "地点", locationId, out action);
		}

		// Token: 0x060386A1 RID: 231073 RVA: 0x00FC608B File Offset: 0x00FC428B
		[NullableContext(2)]
		public bool TryGetRoleOptionAction(int roleId, int optionId, out SolarSchoolActionBase action)
		{
			return this.TryGetOptionActionFrom(this.FriendData.GetRoleOptions(roleId), optionId, "角色", roleId, out action);
		}

		// Token: 0x060386A2 RID: 231074 RVA: 0x00FC60A8 File Offset: 0x00FC42A8
		private unsafe bool TryGetOptionActionFrom(List<SolarSchoolOptionInfo> options, int optionId, string ownerDesc, int ownerId, [Nullable(2)] out SolarSchoolActionBase action)
		{
			action = null;
			SolarSchoolOptions? solarSchoolOptions = null;
			bool flag = false;
			foreach (SolarSchoolOptionInfo solarSchoolOptionInfo in options)
			{
				if (solarSchoolOptionInfo.Row.Id == optionId)
				{
					solarSchoolOptions = new SolarSchoolOptions?(solarSchoolOptionInfo.Row);
					flag = solarSchoolOptionInfo.CanClick;
					break;
				}
			}
			if (solarSchoolOptions == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 选项不在该选项组内";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("optionId", optionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ownerDesc", ownerDesc);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ownerId", ownerId);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return false;
			}
			if (!flag)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 选项当前置灰不可点";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("optionId", optionId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			action = this.CreateAction(solarSchoolOptions.Value.ActionId);
			if (action == null)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SolarSchool;
				ELogAuthor author3 = ELogAuthor.LRC;
				string message3 = "[SolarSchool] 选项 ActionId 无法造 action";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("optionId", optionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("actionId", solarSchoolOptions.Value.ActionId);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
			return true;
		}

		// Token: 0x060386A3 RID: 231075 RVA: 0x00FC6274 File Offset: 0x00FC4474
		public int GetBehaviorIdBySlot(ESolarSchoolTimeSlot slot)
		{
			return this.ScheduleData.GetScheduledBehaviorId(this.GetWeekday(), slot);
		}

		// Token: 0x060386A4 RID: 231076 RVA: 0x00FC6288 File Offset: 0x00FC4488
		public void RecordExecutedBehavior(int behaviorId)
		{
			this.ScheduleData.RecordExecutedBehavior(this.GetWeekday(), this.TimeData.CurrentSlot, behaviorId);
		}

		// Token: 0x060386A5 RID: 231077 RVA: 0x00FC62A8 File Offset: 0x00FC44A8
		[NullableContext(2)]
		public SolarSchoolActionBase CreateAction(int actionId)
		{
			ActivityActionBase activityActionBase = ActivityActionModel.Instance.CreateAction(actionId, EActivityCategory.SolarSchool);
			if (activityActionBase == null)
			{
				return null;
			}
			SolarSchoolActionBase solarSchoolActionBase = activityActionBase as SolarSchoolActionBase;
			if (solarSchoolActionBase != null)
			{
				return solarSchoolActionBase;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] CreateAction 造出的不是 SolarSchoolActionBase(ActionType 非索拉 action?)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionId", actionId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060386A6 RID: 231078 RVA: 0x00FC6304 File Offset: 0x00FC4504
		[NullableContext(2)]
		public SolarSchoolActionBase CreateAction(EActivityActionType type, [Nullable(new byte[]
		{
			2,
			1,
			1
		})] IReadOnlyDictionary<string, string> parameters = null)
		{
			SolarSchoolActionBase solarSchoolActionBase = ActivityActionFactory.Instance.Create(type, parameters) as SolarSchoolActionBase;
			if (solarSchoolActionBase != null)
			{
				return solarSchoolActionBase;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] CreateAction 造出的不是 SolarSchoolActionBase(ActionType 非索拉 action?)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("actionType", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}

		// Token: 0x060386A7 RID: 231079 RVA: 0x00FC6358 File Offset: 0x00FC4558
		[NullableContext(2)]
		public SolarSchoolActionBase CreateBehaviorAction(int behaviorId)
		{
			return this.CreateAction(EActivityActionType.SolarSchoolBehavior, new Dictionary<string, string>
			{
				{
					"SolarSchoolBehaviorId",
					behaviorId.ToString()
				}
			});
		}

		// Token: 0x060386A8 RID: 231080 RVA: 0x00FC6378 File Offset: 0x00FC4578
		public List<SolarSchoolActionBase> CreateBehaviorActionSequence(int behaviorId)
		{
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			SolarSchoolActionBase solarSchoolActionBase = this.CreateBehaviorAction(behaviorId);
			if (solarSchoolActionBase == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] 行为造 action 失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("behaviorId", behaviorId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return list;
			}
			SolarSchoolBehavior? currentLevelRow = this.PlayerData.GetCurrentLevelRow(behaviorId);
			if (currentLevelRow != null)
			{
				this.AppendPreActions(behaviorId, currentLevelRow.Value, list);
			}
			list.Add(solarSchoolActionBase);
			return list;
		}

		// Token: 0x060386A9 RID: 231081 RVA: 0x00FC63F4 File Offset: 0x00FC45F4
		private void AppendPreActions(int behaviorId, SolarSchoolBehavior behavior, List<SolarSchoolActionBase> sequence)
		{
			this.AppendBeforeBehaviorEvent(behaviorId, sequence);
			if (behavior.FirstAction != 0 && this.PlayerData.GetCompletedCount(behaviorId) == behavior.RequireCount)
			{
				this.TryAppendAction(behavior.FirstAction, sequence);
			}
			int preActionListLength = behavior.PreActionListLength;
			if (preActionListLength > 0)
			{
				this.TryAppendAction(behavior.PreActionList(this.GetRandomIndex(preActionListLength)), sequence);
			}
		}

		// Token: 0x060386AA RID: 231082 RVA: 0x00FC6458 File Offset: 0x00FC4658
		private void AppendBeforeBehaviorEvent(int behaviorId, List<SolarSchoolActionBase> sequence)
		{
			int num;
			SolarSchoolActionBase solarSchoolActionBase;
			if (SolarSchoolQuestCenter.Instance.TryTakePendingNode(ESolarSchoolTriggerTiming.BeforeBehavior, behaviorId, out num, out solarSchoolActionBase) && solarSchoolActionBase != null)
			{
				sequence.Add(solarSchoolActionBase);
			}
		}

		// Token: 0x060386AB RID: 231083 RVA: 0x00FC6484 File Offset: 0x00FC4684
		private void TryAppendAction(int actionId, List<SolarSchoolActionBase> sequence)
		{
			if (actionId == 0)
			{
				return;
			}
			SolarSchoolActionBase solarSchoolActionBase = this.CreateAction(actionId);
			if (solarSchoolActionBase == null)
			{
				return;
			}
			sequence.Add(solarSchoolActionBase);
		}

		// Token: 0x060386AC RID: 231084 RVA: 0x00FC64A8 File Offset: 0x00FC46A8
		[NullableContext(0)]
		public UniTask<bool> RunActionParallelAsync([Nullable(1)] SolarSchoolActionBase action, CancellationToken cancellationToken)
		{
			SolarSchoolGamePlayModel.<RunActionParallelAsync>d__271 <RunActionParallelAsync>d__;
			<RunActionParallelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RunActionParallelAsync>d__.<>4__this = this;
			<RunActionParallelAsync>d__.action = action;
			<RunActionParallelAsync>d__.cancellationToken = cancellationToken;
			<RunActionParallelAsync>d__.<>1__state = -1;
			<RunActionParallelAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<RunActionParallelAsync>d__271>(ref <RunActionParallelAsync>d__);
			return <RunActionParallelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386AD RID: 231085 RVA: 0x00FC64FC File Offset: 0x00FC46FC
		[NullableContext(0)]
		public UniTask<bool> RunActionParallelAsync(int actionId, CancellationToken cancellationToken)
		{
			SolarSchoolGamePlayModel.<RunActionParallelAsync>d__272 <RunActionParallelAsync>d__;
			<RunActionParallelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<RunActionParallelAsync>d__.<>4__this = this;
			<RunActionParallelAsync>d__.actionId = actionId;
			<RunActionParallelAsync>d__.cancellationToken = cancellationToken;
			<RunActionParallelAsync>d__.<>1__state = -1;
			<RunActionParallelAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<RunActionParallelAsync>d__272>(ref <RunActionParallelAsync>d__);
			return <RunActionParallelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386AE RID: 231086 RVA: 0x00FC6550 File Offset: 0x00FC4750
		public bool RollBehaviorResult(int behaviorId)
		{
			SolarSchoolBehavior? currentLevelRow = this.PlayerData.GetCurrentLevelRow(behaviorId);
			return currentLevelRow != null && RandomSystem.GetRandomPercent() < this.CalcSuccessRate(currentLevelRow.Value) * (float)RandomSystem.RAND_PERCENT;
		}

		// Token: 0x060386AF RID: 231087 RVA: 0x00FC6590 File Offset: 0x00FC4790
		public unsafe void SettleBehaviorResult(int behaviorId, bool success)
		{
			SolarSchoolBehavior? currentLevelRow = this.PlayerData.GetCurrentLevelRow(behaviorId);
			if (currentLevelRow == null)
			{
				return;
			}
			SolarSchoolBehavior value = currentLevelRow.Value;
			this.PlayerData.OnBehaviorExecuted(behaviorId, success);
			this.ApplyAttrChange(value, success);
			int num = success ? value.RewardSuccess : value.RewardFail;
			bool flag = value.BehaviorType == 4;
			int num2 = flag ? 0 : this.GetBonus(ESolarSchoolBonusType.BehaviorReward, value.BehaviorId);
			string item;
			if (num != 0 && !SolarSchoolRewardCenter.Instance.TryGiveReward(num, num2, out item))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 行为成功/失败奖励发放失败";
				<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", value.Level);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("success", success);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("rewardGroupId", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("rewardBonus", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("error", item);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "[SolarSchool] 行为结算";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("level", value.Level);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("success", success);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("completedCount", this.PlayerData.GetCompletedCount(behaviorId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("rewardId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("rewardBonus", num2);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 6));
			if (flag && SolarSchoolSpecialBehaviorCenter.Instance.TryMarkFinished(behaviorId))
			{
				this.InjectSpecialFinishSequence(behaviorId, value);
			}
			SolarSchoolController.Instance.EnqueueBehave(behaviorId, success, this.PlayerData.GetSpecialState(behaviorId));
		}

		// Token: 0x060386B0 RID: 231088 RVA: 0x00FC6808 File Offset: 0x00FC4A08
		private unsafe void InjectSpecialFinishSequence(int behaviorId, SolarSchoolBehavior behavior)
		{
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			if (behavior.FinishAction != 0)
			{
				this.TryAppendAction(behavior.FinishAction, list);
			}
			SolarSchoolActionBase solarSchoolActionBase = this.CreateAction(EActivityActionType.SolarSchoolPopup, SolarSchoolPopupAction.CreateBehaviorDonePopupParams(behaviorId, "", true));
			if (solarSchoolActionBase != null)
			{
				list.Add(solarSchoolActionBase);
			}
			if (behavior.RewardFinish != 0)
			{
				EActivityActionType type = EActivityActionType.SolarSchoolReward;
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary["SolarSchoolRewardId"] = behavior.RewardFinish.ToString(CultureInfo.InvariantCulture);
				SolarSchoolActionBase solarSchoolActionBase2 = this.CreateAction(type, dictionary);
				if (solarSchoolActionBase2 != null)
				{
					list.Add(solarSchoolActionBase2);
				}
			}
			foreach (SolarSchoolActionBase solarSchoolActionBase3 in list)
			{
				if (!this.TryInjectActionToCurrentTask(solarSchoolActionBase3))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 特批完成表现注入失败：当前无可注入 Task";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionType", solarSchoolActionBase3.GetType().Name);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return;
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.LRC;
			string message2 = "[SolarSchool] 特批完成表现已注入";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("behaviorId", behaviorId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("finishAction", behavior.FinishAction);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("rewardFinish", behavior.RewardFinish);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("actionCount", list.Count);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		}

		// Token: 0x060386B1 RID: 231089 RVA: 0x00FC69F4 File Offset: 0x00FC4BF4
		private unsafe float CalcSuccessRate(SolarSchoolBehavior behavior)
		{
			ESolarSchoolSecondAttr[] attrsShowList = SolarSchoolDefine.AttrsShowList;
			int[] array = SolarSchoolGamePlayModel.ReadCheckAttrValues(behavior.AttrLowerLength, new Func<int, DicIntInt?>(behavior.AttrLower));
			int[] array2 = SolarSchoolGamePlayModel.ReadCheckAttrValues(behavior.AttrUpperLength, new Func<int, DicIntInt?>(behavior.AttrUpper));
			int[] array3 = SolarSchoolGamePlayModel.ReadCheckAttrValues(behavior.AttrWeightLength, new Func<int, DicIntInt?>(behavior.AttrWeight));
			int[] array4 = new int[attrsShowList.Length];
			float[] array5 = new float[attrsShowList.Length];
			for (int i = 0; i < attrsShowList.Length; i++)
			{
				array4[i] = this.PlayerData.GetAttr(attrsShowList[i]);
				array5[i] = (float)array3[i] / 1000f;
				if (array5[i] > 0f && array2[i] <= array[i])
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 行为成功率配表错误：AttrUpper<=AttrLower，该维已置为不参与检定";
					<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("behaviorId", behavior.BehaviorId);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("level", behavior.Level);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("attr", attrsShowList[i]);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("lower", array[i]);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("upper", array2[i]);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("weight", array5[i]);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
					array5[i] = 0f;
				}
			}
			int attr = this.PlayerData.GetAttr(ESolarSchoolSecondAttr.Fatigue);
			float num = SolarSchoolUtils.CalcSuccessRate(this.ActivityId, array4, array, array2, array5, attr);
			int bonus = this.GetBonus(ESolarSchoolBonusType.BehaviorSuccessRate, behavior.BehaviorId);
			return Math.Clamp(num + (float)bonus / 10000f, 0f, 1f);
		}

		// Token: 0x060386B2 RID: 231090 RVA: 0x00FC6C10 File Offset: 0x00FC4E10
		private static int[] ReadCheckAttrValues(int length, Func<int, DicIntInt?> reader)
		{
			ESolarSchoolSecondAttr[] attrsShowList = SolarSchoolDefine.AttrsShowList;
			int[] array = new int[attrsShowList.Length];
			for (int i = 0; i < length; i++)
			{
				DicIntInt? dicIntInt = reader(i);
				if (dicIntInt != null)
				{
					int num = Array.IndexOf<ESolarSchoolSecondAttr>(attrsShowList, (ESolarSchoolSecondAttr)dicIntInt.Value.Key);
					if (num >= 0)
					{
						array[num] = dicIntInt.Value.Value;
					}
				}
			}
			return array;
		}

		// Token: 0x060386B3 RID: 231091 RVA: 0x00FC6C7B File Offset: 0x00FC4E7B
		[return: TupleElementNames(new string[]
		{
			"Attr",
			"Delta"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public List<ValueTuple<ESolarSchoolSecondAttr, int>> GetBehaviorSuccessAttrDeltas(SolarSchoolBehavior behavior)
		{
			return this.GetBehaviorAttrDeltas(behavior, true);
		}

		// Token: 0x060386B4 RID: 231092 RVA: 0x00FC6C88 File Offset: 0x00FC4E88
		[return: TupleElementNames(new string[]
		{
			"Attr",
			"Delta"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		private List<ValueTuple<ESolarSchoolSecondAttr, int>> GetBehaviorAttrDeltas(SolarSchoolBehavior behavior, bool success)
		{
			Dictionary<ESolarSchoolSecondAttr, int> dictionary = new Dictionary<ESolarSchoolSecondAttr, int>();
			int num = success ? behavior.SucAttrChangeLength : behavior.FailAttrChangeLength;
			for (int i = 0; i < num; i++)
			{
				DicIntInt? dicIntInt = success ? behavior.SucAttrChange(i) : behavior.FailAttrChange(i);
				if (dicIntInt != null)
				{
					ESolarSchoolSecondAttr key = (ESolarSchoolSecondAttr)dicIntInt.Value.Key;
					dictionary[key] = dictionary.GetValueOrDefault(key, 0) + dicIntInt.Value.Value;
				}
			}
			for (int j = 1; j <= 8; j++)
			{
				int behaviorBuffEffectValue = this.PlayerData.GetBehaviorBuffEffectValue(j, behavior.BehaviorId);
				if (behaviorBuffEffectValue != 0)
				{
					ESolarSchoolSecondAttr key2 = (ESolarSchoolSecondAttr)j;
					dictionary[key2] = dictionary.GetValueOrDefault(key2, 0) + behaviorBuffEffectValue;
				}
			}
			List<ValueTuple<ESolarSchoolSecondAttr, int>> list = new List<ValueTuple<ESolarSchoolSecondAttr, int>>();
			for (int k = 1; k <= 8; k++)
			{
				ESolarSchoolSecondAttr esolarSchoolSecondAttr = (ESolarSchoolSecondAttr)k;
				int num2 = this.ApplyFatigueReduction(behavior.BehaviorId, esolarSchoolSecondAttr, dictionary.GetValueOrDefault(esolarSchoolSecondAttr, 0));
				if (num2 != 0)
				{
					list.Add(new ValueTuple<ESolarSchoolSecondAttr, int>(esolarSchoolSecondAttr, num2));
				}
			}
			return list;
		}

		// Token: 0x060386B5 RID: 231093 RVA: 0x00FC6D9C File Offset: 0x00FC4F9C
		private int ApplyFatigueReduction(int behaviorId, ESolarSchoolSecondAttr attr, int delta)
		{
			if (attr != ESolarSchoolSecondAttr.Fatigue || delta <= 0)
			{
				return delta;
			}
			int bonus = this.GetBonus(ESolarSchoolBonusType.FatigueCostReduction, behaviorId);
			return Math.Max(delta - bonus, 0);
		}

		// Token: 0x060386B6 RID: 231094 RVA: 0x00FC6DC8 File Offset: 0x00FC4FC8
		private void ApplyAttrChange(SolarSchoolBehavior behavior, bool success)
		{
			foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in this.GetBehaviorAttrDeltas(behavior, success))
			{
				ESolarSchoolSecondAttr item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				this.PlayerData.AddAttr(item, item2);
			}
		}

		// Token: 0x060386B7 RID: 231095 RVA: 0x00FC6E30 File Offset: 0x00FC5030
		public List<SolarSchoolBagItemData> GetBagItems(ESolarSchoolItemType type)
		{
			List<SolarSchoolBagItemData> list = new List<SolarSchoolBagItemData>();
			if (!this.IsInGamePlay)
			{
				return list;
			}
			foreach (KeyValuePair<int, SolarSchoolItemData> keyValuePair in this.InventoryData.Items)
			{
				SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(keyValuePair.Key);
				if (item != null && item.Value.ActivityId == this.ActivityId && item.Value.ItemType == (int)type)
				{
					list.Add(new SolarSchoolBagItemData(item.Value, keyValuePair.Value.Count));
				}
			}
			List<SolarSchoolBagItemData> list2 = list;
			Comparison<SolarSchoolBagItemData> comparison;
			if ((comparison = SolarSchoolGamePlayModel.<>O.<0>__CompareBagItemBySortId) == null)
			{
				comparison = (SolarSchoolGamePlayModel.<>O.<0>__CompareBagItemBySortId = new Comparison<SolarSchoolBagItemData>(SolarSchoolGamePlayModel.CompareBagItemBySortId));
			}
			list2.Sort(comparison);
			return list;
		}

		// Token: 0x060386B8 RID: 231096 RVA: 0x00FC6F14 File Offset: 0x00FC5114
		private static int CompareBagItemBySortId(SolarSchoolBagItemData a, SolarSchoolBagItemData b)
		{
			int num = a.Config.SortId.CompareTo(b.Config.SortId);
			if (num == 0)
			{
				return a.ItemId.CompareTo(b.ItemId);
			}
			return num;
		}

		// Token: 0x060386B9 RID: 231097 RVA: 0x00FC6F64 File Offset: 0x00FC5164
		[return: TupleElementNames(new string[]
		{
			"Attr",
			"Delta"
		})]
		[return: Nullable(new byte[]
		{
			1,
			0
		})]
		public List<ValueTuple<ESolarSchoolSecondAttr, int>> GetItemAttrDeltas(SolarSchoolItem item)
		{
			List<ValueTuple<ESolarSchoolSecondAttr, int>> result = new List<ValueTuple<ESolarSchoolSecondAttr, int>>();
			foreach (int id in item.GetEffectIdsArray())
			{
				SolarSchoolItemEffect? itemEffect = SolarSchoolConfig.Instance.GetItemEffect(id);
				if (itemEffect != null)
				{
					SolarSchoolItemEffect value = itemEffect.Value;
					switch (value.EffectType)
					{
					case 0:
						for (int j = 0; j < SolarSchoolDefine.AttrsShowList.Length; j++)
						{
							SolarSchoolGamePlayModel.AddAttrDelta(result, SolarSchoolDefine.AttrsShowList[j], SolarSchoolGamePlayModel.GetEffectAttrValue(value, j));
						}
						break;
					case 1:
						SolarSchoolGamePlayModel.AddAttrDelta(result, ESolarSchoolSecondAttr.Popularity, value.Popularity);
						break;
					case 2:
						SolarSchoolGamePlayModel.AddAttrDelta(result, ESolarSchoolSecondAttr.Fatigue, value.Fatigue);
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060386BA RID: 231098 RVA: 0x00FC7022 File Offset: 0x00FC5222
		private static void AddAttrDelta([Nullable(new byte[]
		{
			1,
			0
		})] List<ValueTuple<ESolarSchoolSecondAttr, int>> result, ESolarSchoolSecondAttr attr, int delta)
		{
			if (delta != 0)
			{
				result.Add(new ValueTuple<ESolarSchoolSecondAttr, int>(attr, delta));
			}
		}

		// Token: 0x060386BB RID: 231099 RVA: 0x00FC7034 File Offset: 0x00FC5234
		private static int GetEffectAttrValue(SolarSchoolItemEffect effect, int index)
		{
			int result;
			switch (index)
			{
			case 0:
				result = effect.Value1;
				break;
			case 1:
				result = effect.Value2;
				break;
			case 2:
				result = effect.Value3;
				break;
			case 3:
				result = effect.Value4;
				break;
			case 4:
				result = effect.Value5;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x060386BC RID: 231100 RVA: 0x00FC7094 File Offset: 0x00FC5294
		public bool CanUseItem(int itemId)
		{
			if (!this.IsInGamePlay || this.InventoryData.GetItemCount(itemId) <= 0)
			{
				return false;
			}
			SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(itemId);
			return item != null && item.Value.ItemType == 0 && item.Value.CanUse;
		}

		// Token: 0x060386BD RID: 231101 RVA: 0x00FC70F4 File Offset: 0x00FC52F4
		public bool UseItem(int itemId)
		{
			if (!this.CanUseItem(itemId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 道具不可使用";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			SolarSchoolItem value = SolarSchoolConfig.Instance.GetItem(itemId).Value;
			this.AddItem(itemId, -1);
			foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple2 in this.GetItemAttrDeltas(value))
			{
				ESolarSchoolSecondAttr item = valueTuple2.Item1;
				int item2 = valueTuple2.Item2;
				this.PlayerData.AddAttr(item, item2);
			}
			foreach (int id in value.GetEffectIdsArray())
			{
				SolarSchoolItemEffect? itemEffect = SolarSchoolConfig.Instance.GetItemEffect(id);
				if (itemEffect != null && itemEffect.Value.EffectType == 3)
				{
					this.AddBuff(itemEffect.Value.Buff);
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SolarSchool;
			ELogAuthor author2 = ELogAuthor.SWC;
			string message2 = "[SolarSchool] 使用道具";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("itemId", itemId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
			return true;
		}

		// Token: 0x060386BE RID: 231102 RVA: 0x00FC724C File Offset: 0x00FC544C
		public int AddItem(int itemId, int count)
		{
			SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(itemId);
			if (item == null)
			{
				return 0;
			}
			SolarSchoolItem value = item.Value;
			int itemCount = this.InventoryData.GetItemCount(itemId);
			bool flag;
			int num = this.InventoryData.AddItem(itemId, count, value.StackLimit, out flag);
			if (num > itemCount)
			{
				this.LogReporter.ReportItemGet(itemId, num - itemCount, value.ItemType);
			}
			if (count > 0 && (long)itemCount + (long)count > (long)value.StackLimit && !this.IsInEndingStage)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("SolarSchoolItem99", Array.Empty<object>());
			}
			if (flag && value.ShowFirstGetTip)
			{
				if (this.IsRewardTipSuppressed())
				{
					this.PendingTipsPopups.Add(new ValueTuple<int, int>(itemId, num - itemCount));
				}
				else
				{
					this.TryInjectTipsPopup(itemId, num - itemCount);
				}
			}
			if (count > 0)
			{
				this.EnqueueRewardTip(ESolarSchoolRewardTipType.Item, itemId, count);
			}
			if (itemCount == 0 && num > 0 && value.ItemType == 2)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 首次获得特殊道具，结算永久加成";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.ApplySpecialItemBonus(value);
			}
			return num;
		}

		// Token: 0x060386BF RID: 231103 RVA: 0x00FC7370 File Offset: 0x00FC5570
		private void ApplySpecialItemBonus(SolarSchoolItem item)
		{
			foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in this.GetItemAttrDeltas(item))
			{
				ESolarSchoolSecondAttr item2 = valueTuple.Item1;
				int item3 = valueTuple.Item2;
				this.ApplyBonus((int)item2, item3);
			}
		}

		// Token: 0x060386C0 RID: 231104 RVA: 0x00FC73D4 File Offset: 0x00FC55D4
		private static bool TryGetAttrType(int type, out ESolarSchoolSecondAttr attr)
		{
			attr = (ESolarSchoolSecondAttr)type;
			return attr != ESolarSchoolSecondAttr.None && Enum.IsDefined<ESolarSchoolSecondAttr>(attr);
		}

		// Token: 0x060386C1 RID: 231105 RVA: 0x00FC73E8 File Offset: 0x00FC55E8
		private static bool CanScopeToBehavior(int type)
		{
			ESolarSchoolSecondAttr esolarSchoolSecondAttr;
			return SolarSchoolGamePlayModel.TryGetAttrType(type, out esolarSchoolSecondAttr) || type - 9 <= 2;
		}

		// Token: 0x060386C2 RID: 231106 RVA: 0x00FC7414 File Offset: 0x00FC5614
		public bool CanAddBuff(int buffId, out string error)
		{
			SolarSchoolBuff solarSchoolBuff;
			List<SolarSchoolGamePlayModel.BuffEffectInfo> list;
			return this.TryPrepareBuff(buffId, out solarSchoolBuff, out list, out error);
		}

		// Token: 0x060386C3 RID: 231107 RVA: 0x00FC742D File Offset: 0x00FC562D
		public bool AddBuff(int buffId)
		{
			if (!this.TryAddBuffState(buffId))
			{
				return false;
			}
			this.RebuildActiveBuffDerivedEffects(false);
			return true;
		}

		// Token: 0x060386C4 RID: 231108 RVA: 0x00FC7444 File Offset: 0x00FC5644
		private unsafe bool TryAddBuffState(int buffId)
		{
			SolarSchoolBuff solarSchoolBuff;
			List<SolarSchoolGamePlayModel.BuffEffectInfo> list;
			string item;
			if (!this.TryPrepareBuff(buffId, out solarSchoolBuff, out list, out item))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] Buff 挂载失败";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", buffId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", item);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return false;
			}
			bool flag;
			return this.PlayerData.TryAddBuff(buffId, solarSchoolBuff.DurationDays, out flag);
		}

		// Token: 0x060386C5 RID: 231109 RVA: 0x00FC74D2 File Offset: 0x00FC56D2
		public void AdvanceBuffDays()
		{
			if (!this.IsInGamePlay)
			{
				return;
			}
			if (this.PlayerData.AdvanceBuffDays().Count == 0)
			{
				return;
			}
			this.RebuildActiveBuffDerivedEffects(false);
		}

		// Token: 0x060386C6 RID: 231110 RVA: 0x00FC74F8 File Offset: 0x00FC56F8
		private bool TryPrepareBuff(int buffId, out SolarSchoolBuff buff, out List<SolarSchoolGamePlayModel.BuffEffectInfo> effects, out string error)
		{
			buff = default(SolarSchoolBuff);
			effects = new List<SolarSchoolGamePlayModel.BuffEffectInfo>();
			if (!this.IsInGamePlay)
			{
				error = "当前不在第二索拉学院局内";
				return false;
			}
			SolarSchoolBuff? buff2 = SolarSchoolConfig.Instance.GetBuff(buffId);
			if (buff2 == null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("未找到 Buff 配置：");
				defaultInterpolatedStringHandler.AppendFormatted<int>(buffId);
				error = defaultInterpolatedStringHandler.ToStringAndClear();
				return false;
			}
			buff = buff2.Value;
			if (!SolarSchoolPlayerData.IsValidBuffDuration(buff.DurationDays))
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(12, 1);
				defaultInterpolatedStringHandler.AppendLiteral("Buff 持续天数非法：");
				defaultInterpolatedStringHandler.AppendFormatted<int>(buff.DurationDays);
				error = defaultInterpolatedStringHandler.ToStringAndClear();
				return false;
			}
			foreach (int num in buff.GetEffectIdsArray())
			{
				SolarSchoolBuffEffect? buffEffect = SolarSchoolConfig.Instance.GetBuffEffect(num);
				if (buffEffect == null)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(36, 2);
					defaultInterpolatedStringHandler.AppendLiteral("buffId=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(buffId);
					defaultInterpolatedStringHandler.AppendLiteral(", effectId=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler.AppendLiteral(": Buff Effect 配置缺失");
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
				SolarSchoolBuffEffect value = buffEffect.Value;
				int[] behaviorIdArray = value.GetBehaviorIdArray();
				string value2;
				if (!this.CheckBuffEffect(value.Type, behaviorIdArray, out value2))
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(27, 4);
					defaultInterpolatedStringHandler.AppendLiteral("buffId=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(buffId);
					defaultInterpolatedStringHandler.AppendLiteral(", effectId=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler.AppendLiteral(", type=");
					defaultInterpolatedStringHandler.AppendFormatted<int>(value.Type);
					defaultInterpolatedStringHandler.AppendLiteral(": ");
					defaultInterpolatedStringHandler.AppendFormatted(value2);
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
				effects.Add(new SolarSchoolGamePlayModel.BuffEffectInfo(value.Type, value.Value, behaviorIdArray));
			}
			error = string.Empty;
			return true;
		}

		// Token: 0x060386C7 RID: 231111 RVA: 0x00FC76E8 File Offset: 0x00FC58E8
		private bool CheckBuffEffect(int type, int[] behaviorIds, out string error)
		{
			error = string.Empty;
			ESolarSchoolSecondAttr esolarSchoolSecondAttr;
			if (!SolarSchoolGamePlayModel.TryGetAttrType(type, out esolarSchoolSecondAttr) && !Enum.IsDefined<ESolarSchoolBonusType>((ESolarSchoolBonusType)type))
			{
				error = "Type 既不是玩家属性也不是已定义的加成类型";
				return false;
			}
			if (behaviorIds.Length != 0 && !SolarSchoolGamePlayModel.CanScopeToBehavior(type))
			{
				error = "该 Type 不支持按行为限定，不能配置 BehaviorIds";
				return false;
			}
			for (int i = 0; i < behaviorIds.Length; i++)
			{
				int num = behaviorIds[i];
				if (num <= 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
					defaultInterpolatedStringHandler.AppendLiteral("BehaviorId 必须大于 0：");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
				if (Array.IndexOf<int>(behaviorIds, num) != i)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
					defaultInterpolatedStringHandler.AppendLiteral("BehaviorIds 不能重复：");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
				if (SolarSchoolConfig.Instance.GetBehaviorListByBehaviorId(this.ActivityId, num).Count == 0)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(21, 1);
					defaultInterpolatedStringHandler.AppendLiteral("BehaviorId 在当前活动中不存在：");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
				if (type == 10 && SolarSchoolConfig.Instance.GetBehaviorType(this.ActivityId, num).GetValueOrDefault() == ESolarSchoolBehaviorType.Special)
				{
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(14, 1);
					defaultInterpolatedStringHandler.AppendLiteral("行为奖励加成不支持特批行为：");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					error = defaultInterpolatedStringHandler.ToStringAndClear();
					return false;
				}
			}
			return true;
		}

		// Token: 0x060386C8 RID: 231112 RVA: 0x00FC7831 File Offset: 0x00FC5A31
		internal int GetBonus(ESolarSchoolBonusType type, int behaviorId = 0)
		{
			return this.BonusData.GetBonus(type) + this.PlayerData.GetBuffEffectValue((int)type, behaviorId);
		}

		// Token: 0x060386C9 RID: 231113 RVA: 0x00FC7850 File Offset: 0x00FC5A50
		public unsafe void ApplyBonus(int type, int value)
		{
			if (value == 0)
			{
				return;
			}
			ESolarSchoolSecondAttr attr;
			if (SolarSchoolGamePlayModel.TryGetAttrType(type, out attr))
			{
				this.PlayerData.AddAttrBonus(attr, value);
				return;
			}
			if (Enum.IsDefined<ESolarSchoolBonusType>((ESolarSchoolBonusType)type))
			{
				this.BonusData.AddBonus((ESolarSchoolBonusType)type, value);
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.SWC;
			string message = "[SolarSchool] 加成类型未定义，已忽略";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x060386CA RID: 231114 RVA: 0x00FC78F4 File Offset: 0x00FC5AF4
		public int AddFavor(int roleId, int delta)
		{
			if (!this.IsInGamePlay)
			{
				return 0;
			}
			if (!this.FriendData.IsRoleUnlocked(roleId))
			{
				return this.FriendData.AddFavor(roleId, delta);
			}
			int favor = this.FriendData.GetFavor(roleId);
			int num = this.FriendData.AddFavor(roleId, delta);
			int num2 = num - favor;
			if (num2 != 0)
			{
				this.EnqueueRewardTip(ESolarSchoolRewardTipType.Favor, roleId, num2);
			}
			return num;
		}

		// Token: 0x060386CB RID: 231115 RVA: 0x00FC7954 File Offset: 0x00FC5B54
		public bool UnlockRole(int roleId)
		{
			if (!this.IsInGamePlay || SolarSchoolConfig.Instance.GetRole(roleId) == null)
			{
				return false;
			}
			if (!this.FriendData.UnlockRole(roleId))
			{
				return false;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.SWC;
			string message = "[SolarSchool] 角色解锁";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x060386CC RID: 231116 RVA: 0x00FC79C0 File Offset: 0x00FC5BC0
		public unsafe bool TryLevelUpFavor(int roleId)
		{
			if (!this.IsInGamePlay || !this.FriendData.IsFavorValueFull(roleId))
			{
				return false;
			}
			int favorLevel = this.FriendData.GetFavorLevel(roleId);
			if (!this.FriendData.LevelUp(roleId))
			{
				return false;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.SWC;
			string message = "[SolarSchool] 好感等级提升";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("favorLevel", this.FriendData.GetFavorLevel(roleId));
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.AutoLevelUpFavor(roleId);
			int favorLevel2 = this.FriendData.GetFavorLevel(roleId);
			this.LogReporter.ReportFavorLevelUp(roleId, favorLevel2);
			this.GiveFavorLevelUnlockRewards(roleId, favorLevel, favorLevel2);
			this.TryInjectFavorPopup(roleId, favorLevel, favorLevel2);
			return true;
		}

		// Token: 0x060386CD RID: 231117 RVA: 0x00FC7AA4 File Offset: 0x00FC5CA4
		private unsafe bool AutoLevelUpFavor(int roleId)
		{
			bool result = false;
			while (this.FriendData.IsFavorValueFull(roleId) && this.FriendData.LevelUp(roleId))
			{
				result = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 好感等级提升（无条件自动升级）";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("favorLevel", this.FriendData.GetFavorLevel(roleId));
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return result;
		}

		// Token: 0x060386CE RID: 231118 RVA: 0x00FC7B44 File Offset: 0x00FC5D44
		private unsafe void GiveFavorLevelUnlockRewards(int roleId, int previousLevel, int finalLevel)
		{
			for (int i = previousLevel + 1; i <= finalLevel; i++)
			{
				SolarSchoolRoleFavorLevel? roleFavorLevel = SolarSchoolConfig.Instance.GetRoleFavorLevel(roleId, i);
				if (roleFavorLevel != null)
				{
					int unlockRewardId = roleFavorLevel.Value.UnlockRewardId;
					string item;
					if (unlockRewardId != 0 && !SolarSchoolRewardCenter.Instance.TryGiveReward(unlockRewardId, out item))
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.SolarSchool;
						ELogAuthor author = ELogAuthor.SWC;
						string message = "[SolarSchool] 好感等级解锁奖励发放失败";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("roleId", roleId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("favorLevel", i);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("rewardGroupId", unlockRewardId);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("error", item);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
					}
				}
			}
		}

		// Token: 0x060386CF RID: 231119 RVA: 0x00FC7C40 File Offset: 0x00FC5E40
		private void ReconcileFavorPermanentBuffs()
		{
			IReadOnlyList<SolarSchoolRole> allRoles = SolarSchoolConfig.Instance.GetAllRoles(this.GetActivityId(), ESolarSchoolRoleClassify.Normal);
			if (allRoles == null)
			{
				return;
			}
			foreach (SolarSchoolRole solarSchoolRole in allRoles)
			{
				if (solarSchoolRole.ActivityId == this.ActivityId && this.FriendData.IsRoleUnlocked(solarSchoolRole.Id))
				{
					int favorLevel = this.FriendData.GetFavorLevel(solarSchoolRole.Id);
					for (int i = 1; i <= favorLevel; i++)
					{
						SolarSchoolRoleFavorLevel? solarSchoolRoleFavorLevel;
						int num = (SolarSchoolConfig.Instance.GetRoleFavorLevel(solarSchoolRole.Id, i) != null) ? solarSchoolRoleFavorLevel.GetValueOrDefault().UnlockRewardId : 0;
						List<int> list;
						string text;
						if (num != 0 && SolarSchoolRewardCenter.Instance.TryGetPermanentBuffRewardIds(num, out list, out text))
						{
							foreach (int buffId in list)
							{
								if (this.PlayerData.GetBuffRemainingDays(buffId) != -1)
								{
									this.TryAddBuffState(buffId);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060386D0 RID: 231120 RVA: 0x00FC7D8C File Offset: 0x00FC5F8C
		public List<SolarSchoolBehaviorSkill> GetBehaviorSkills(int behaviorId)
		{
			List<SolarSchoolBehaviorSkill> list = new List<SolarSchoolBehaviorSkill>();
			if (!this.IsInGamePlay || behaviorId <= 0)
			{
				return list;
			}
			IReadOnlyList<int> activeBuffIds = this.PlayerData.GetActiveBuffIds();
			if (activeBuffIds.Count == 0)
			{
				return list;
			}
			IReadOnlyList<SolarSchoolRole> allRoles = SolarSchoolConfig.Instance.GetAllRoles(this.ActivityId, ESolarSchoolRoleClassify.Normal);
			if (allRoles == null)
			{
				return list;
			}
			HashSet<int> hashSet = new HashSet<int>(activeBuffIds);
			HashSet<int> hashSet2 = new HashSet<int>();
			foreach (SolarSchoolRole role in allRoles)
			{
				if (role.ActivityId == this.ActivityId)
				{
					IReadOnlyList<SolarSchoolRoleFavorLevel> roleFavorLevelList = SolarSchoolConfig.Instance.GetRoleFavorLevelList(role.Id);
					if (roleFavorLevelList != null)
					{
						foreach (SolarSchoolRoleFavorLevel favorLevel in roleFavorLevelList)
						{
							if (favorLevel.UnlockRewardId != 0)
							{
								foreach (SolarSchoolReward solarSchoolReward in SolarSchoolRewardCenter.Instance.GetRewardPreview(favorLevel.UnlockRewardId))
								{
									if (solarSchoolReward.RewardType == 4)
									{
										int targetId = solarSchoolReward.TargetId;
										if (hashSet.Contains(targetId) && hashSet2.Add(targetId))
										{
											SolarSchoolBuff? buff = SolarSchoolConfig.Instance.GetBuff(targetId);
											if (buff != null && this.IsBuffShownInBehavior(buff.Value, behaviorId))
											{
												list.Add(new SolarSchoolBehaviorSkill(role, favorLevel, buff.Value));
											}
										}
									}
								}
							}
						}
						if (hashSet2.Count >= hashSet.Count)
						{
							break;
						}
					}
				}
			}
			return list;
		}

		// Token: 0x060386D1 RID: 231121 RVA: 0x00FC7F80 File Offset: 0x00FC6180
		private bool IsBuffShownInBehavior(SolarSchoolBuff buff, int behaviorId)
		{
			foreach (int id in buff.GetEffectIdsArray())
			{
				SolarSchoolBuffEffect? buffEffect = SolarSchoolConfig.Instance.GetBuffEffect(id);
				if (buffEffect != null && buffEffect.Value.IsShowInBehavior)
				{
					int[] behaviorIdArray = buffEffect.Value.GetBehaviorIdArray();
					if (behaviorIdArray.Length == 0 || Array.IndexOf<int>(behaviorIdArray, behaviorId) >= 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060386D2 RID: 231122 RVA: 0x00FC7FF3 File Offset: 0x00FC61F3
		public bool IsFavorLevelUpPending(int roleId)
		{
			return this.IsInGamePlay && this.FriendData.IsFavorValueFull(roleId) && !this.FriendData.IsFavorFrozen(roleId);
		}

		// Token: 0x060386D3 RID: 231123 RVA: 0x00FC801C File Offset: 0x00FC621C
		public bool HasAnyFavorLevelUpPending()
		{
			if (!this.IsInGamePlay)
			{
				return false;
			}
			foreach (SolarSchoolRoleData solarSchoolRoleData in this.FriendData.Roles)
			{
				if (this.IsFavorLevelUpPending(solarSchoolRoleData.RoleId))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060386D4 RID: 231124 RVA: 0x00FC8088 File Offset: 0x00FC6288
		public unsafe int GiveGift(int itemId, int roleId)
		{
			SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(itemId);
			if (item == null)
			{
				return 0;
			}
			SolarSchoolItem value = item.Value;
			if (value.ItemType != 1)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[SolarSchool] 送礼失败：道具不是礼物";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemId", itemId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemType", value.ItemType);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return 0;
			}
			if (this.InventoryData.GetItemCount(itemId) <= 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.SWC;
				string message2 = "[SolarSchool] 送礼失败：背包里没有该礼物";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemId", itemId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			if (SolarSchoolConfig.Instance.GetRole(roleId) == null)
			{
				return 0;
			}
			if (!this.FriendData.IsRoleUnlocked(roleId))
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.SolarSchool;
				ELogAuthor author3 = ELogAuthor.SWC;
				string message3 = "[SolarSchool] 送礼失败：角色未解锁";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("roleId", roleId);
				instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return 0;
			}
			if (this.FriendData.IsFavorFrozen(roleId))
			{
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.SolarSchool;
				ELogAuthor author4 = ELogAuthor.LRC;
				string message4 = "[SolarSchool] 送礼失败：好感被前置条件冻结";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("favorLevel", this.FriendData.GetFavorLevel(roleId));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("preUnlockConditionId", this.FriendData.GetNextLevelPreUnlockConditionId(roleId));
				instance4.Info(module4, author4, message4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return 0;
			}
			int currentLevelFavorCap = this.FriendData.GetCurrentLevelFavorCap(roleId);
			if (this.FriendData.GetFavor(roleId) >= currentLevelFavorCap)
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.SolarSchool;
				ELogAuthor author5 = ELogAuthor.SWC;
				string message5 = "[SolarSchool] 送礼失败：好感已到本级上限";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("roleId", roleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("favorLevel", this.FriendData.GetFavorLevel(roleId));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("cap", currentLevelFavorCap);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("pendingLevelUp", this.IsFavorLevelUpPending(roleId));
				instance5.Error(module5, author5, message5, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 4));
				return 0;
			}
			int giftFavorValue = this.GetGiftFavorValue(value, roleId);
			if (giftFavorValue <= 0)
			{
				Log instance6 = Log.Instance;
				ELogModule module6 = ELogModule.SolarSchool;
				ELogAuthor author6 = ELogAuthor.SWC;
				string message6 = "[SolarSchool] 送礼失败：该道具对该角色没有好感值";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray4 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 0) = new ValueTuple<string, object>("itemId", itemId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray4, 1) = new ValueTuple<string, object>("roleId", roleId);
				instance6.Error(module6, author6, message6, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray4, 2));
				return 0;
			}
			int favor = this.FriendData.GetFavor(roleId);
			int num = Math.Min(giftFavorValue, currentLevelFavorCap - favor);
			this.AddFavor(roleId, giftFavorValue);
			this.AddItem(itemId, -1);
			this.FriendData.RecordGiftReceived(roleId);
			EventSystem.Instance.Emit<int>(EEventName.SolarSchoolGiftCountChanged, roleId);
			Log instance7 = Log.Instance;
			ELogModule module7 = ELogModule.SolarSchool;
			ELogAuthor author7 = ELogAuthor.SWC;
			string message7 = "[SolarSchool] 送礼完成";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray5 = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 0) = new ValueTuple<string, object>("itemId", itemId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 1) = new ValueTuple<string, object>("roleId", roleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 2) = new ValueTuple<string, object>("favorValue", giftFavorValue);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 3) = new ValueTuple<string, object>("before", favor);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 4) = new ValueTuple<string, object>("granted", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 5) = new ValueTuple<string, object>("favorLevel", this.FriendData.GetFavorLevel(roleId));
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray5, 6) = new ValueTuple<string, object>("after", this.FriendData.GetFavor(roleId));
			instance7.Info(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray5, 7));
			return num;
		}

		// Token: 0x060386D5 RID: 231125 RVA: 0x00FC84F4 File Offset: 0x00FC66F4
		private int GetGiftFavorValue(SolarSchoolItem item, int roleId)
		{
			int paramInt = SolarSchoolConfig.Instance.GetParamInt(this.ActivityId, "NormalLikeVal", 0);
			int paramInt2 = SolarSchoolConfig.Instance.GetParamInt(this.ActivityId, "HighLikeVal", 0);
			if (Array.IndexOf<int>(item.GetFavorRoleListArray(), roleId) < 0)
			{
				return paramInt;
			}
			return paramInt2;
		}

		// Token: 0x060386D6 RID: 231126 RVA: 0x00FC8542 File Offset: 0x00FC6742
		public void ClearRootViewId()
		{
			this.RootViewId = 0;
		}

		// Token: 0x060386D7 RID: 231127 RVA: 0x00FC854C File Offset: 0x00FC674C
		public UniTask WaitRootViewDestroyedAsync()
		{
			SolarSchoolGamePlayModel.<WaitRootViewDestroyedAsync>d__315 <WaitRootViewDestroyedAsync>d__;
			<WaitRootViewDestroyedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitRootViewDestroyedAsync>d__.<>4__this = this;
			<WaitRootViewDestroyedAsync>d__.<>1__state = -1;
			<WaitRootViewDestroyedAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<WaitRootViewDestroyedAsync>d__315>(ref <WaitRootViewDestroyedAsync>d__);
			return <WaitRootViewDestroyedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386D8 RID: 231128 RVA: 0x00FC8590 File Offset: 0x00FC6790
		private UniTask WaitOpenedRootViewDestroyedAsync(UiViewBase rootView, CustomPromise<bool> openPromise)
		{
			SolarSchoolGamePlayModel.<WaitOpenedRootViewDestroyedAsync>d__316 <WaitOpenedRootViewDestroyedAsync>d__;
			<WaitOpenedRootViewDestroyedAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WaitOpenedRootViewDestroyedAsync>d__.rootView = rootView;
			<WaitOpenedRootViewDestroyedAsync>d__.openPromise = openPromise;
			<WaitOpenedRootViewDestroyedAsync>d__.<>1__state = -1;
			<WaitOpenedRootViewDestroyedAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<WaitOpenedRootViewDestroyedAsync>d__316>(ref <WaitOpenedRootViewDestroyedAsync>d__);
			return <WaitOpenedRootViewDestroyedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386D9 RID: 231129 RVA: 0x00FC85DB File Offset: 0x00FC67DB
		public bool HasVisibleRewardTips()
		{
			SolarSchoolRewardTipView rewardTipView = this.GetRewardTipView();
			return rewardTipView != null && rewardTipView.HasVisibleRewardTips();
		}

		// Token: 0x060386DA RID: 231130 RVA: 0x00FC85EE File Offset: 0x00FC67EE
		public bool HasUnfinishedRewardTips()
		{
			SolarSchoolRewardTipView rewardTipView = this.GetRewardTipView();
			return rewardTipView != null && rewardTipView.HasUnfinishedRewardTips();
		}

		// Token: 0x060386DB RID: 231131 RVA: 0x00FC8601 File Offset: 0x00FC6801
		public void EnqueueRewardTip(ESolarSchoolRewardTipType type, int targetId, int delta)
		{
			if (this.IsInEndingStage)
			{
				return;
			}
			SolarSchoolRewardTipView rewardTipView = this.GetRewardTipView();
			if (rewardTipView == null)
			{
				return;
			}
			rewardTipView.EnqueueRewardTip(type, targetId, delta);
		}

		// Token: 0x060386DC RID: 231132 RVA: 0x00FC861F File Offset: 0x00FC681F
		public void EnqueueQuestDoneTip(int questId)
		{
			if (this.IsInEndingStage)
			{
				return;
			}
			SolarSchoolRewardTipView rewardTipView = this.GetRewardTipView();
			if (rewardTipView == null)
			{
				return;
			}
			rewardTipView.EnqueueQuestDoneTip(questId);
		}

		// Token: 0x060386DD RID: 231133 RVA: 0x00FC863C File Offset: 0x00FC683C
		public void SetRewardTipSuppress(bool suppress)
		{
			SolarSchoolRewardTipView rewardTipView = this.GetRewardTipView();
			if (rewardTipView != null)
			{
				rewardTipView.SuppressShow = suppress;
			}
			if (!suppress)
			{
				this.FlushPendingTipsPopups();
				this.FlushAttrRankUps();
			}
		}

		// Token: 0x060386DE RID: 231134 RVA: 0x00FC8669 File Offset: 0x00FC6869
		private bool IsRewardTipSuppressed()
		{
			SolarSchoolRewardTipView rewardTipView = this.GetRewardTipView();
			return rewardTipView != null && rewardTipView.SuppressShow;
		}

		// Token: 0x060386DF RID: 231135 RVA: 0x00FC867C File Offset: 0x00FC687C
		private void FlushPendingTipsPopups()
		{
			foreach (ValueTuple<int, int> valueTuple in this.PendingTipsPopups)
			{
				int item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				this.TryInjectTipsPopup(item, item2);
			}
			this.PendingTipsPopups.Clear();
		}

		// Token: 0x060386E0 RID: 231136 RVA: 0x00FC86E8 File Offset: 0x00FC68E8
		public void EnqueueAttrRankUp(SolarSchoolAttrRankUpInfo info)
		{
			for (int i = 0; i < this.PendingAttrRankUps.Count; i++)
			{
				if (this.PendingAttrRankUps[i].Attr == info.Attr)
				{
					SolarSchoolAttrRankUpInfo value = this.PendingAttrRankUps[i];
					value.NewValue = info.NewValue;
					this.PendingAttrRankUps[i] = value;
					return;
				}
			}
			this.PendingAttrRankUps.Add(info);
		}

		// Token: 0x060386E1 RID: 231137 RVA: 0x00FC8758 File Offset: 0x00FC6958
		private void FlushAttrRankUps()
		{
			if (!this.IsInGamePlay || this.PendingAttrRankUps.Count == 0)
			{
				return;
			}
			if (this.IsRewardTipSuppressed())
			{
				return;
			}
			if (this.IsInEndingStage)
			{
				this.PendingAttrRankUps.Clear();
				return;
			}
			List<SolarSchoolAttrRankUpInfo> list = new List<SolarSchoolAttrRankUpInfo>(this.PendingAttrRankUps);
			this.PendingAttrRankUps.Clear();
			if (!this.TryInjectAttrRankUpPopup(list))
			{
				this.RequeueAttrRankUps(list);
			}
		}

		// Token: 0x060386E2 RID: 231138 RVA: 0x00FC87C0 File Offset: 0x00FC69C0
		internal void RequeueAttrRankUps(IReadOnlyList<SolarSchoolAttrRankUpInfo> infos)
		{
			if (!this.IsInGamePlay)
			{
				return;
			}
			int num = 0;
			foreach (SolarSchoolAttrRankUpInfo solarSchoolAttrRankUpInfo in infos)
			{
				bool flag = false;
				for (int i = 0; i < this.PendingAttrRankUps.Count; i++)
				{
					if (this.PendingAttrRankUps[i].Attr == solarSchoolAttrRankUpInfo.Attr)
					{
						SolarSchoolAttrRankUpInfo value = this.PendingAttrRankUps[i];
						value.OldValue = solarSchoolAttrRankUpInfo.OldValue;
						this.PendingAttrRankUps[i] = value;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.PendingAttrRankUps.Insert(num++, solarSchoolAttrRankUpInfo);
				}
			}
		}

		// Token: 0x060386E3 RID: 231139 RVA: 0x00FC888C File Offset: 0x00FC6A8C
		public bool IsViewAllowRewardTip(string viewName, bool isChildView)
		{
			if (!this.ViewNameSet.Contains(viewName))
			{
				return false;
			}
			SolarSchoolViewInfo? viewInfo = SolarSchoolConfig.Instance.GetViewInfo(viewName);
			return viewInfo != null && viewInfo.Value.IsChildView == isChildView && viewInfo.Value.AllowTip;
		}

		// Token: 0x060386E4 RID: 231140 RVA: 0x00FC88E1 File Offset: 0x00FC6AE1
		public bool HasRootView()
		{
			return this.RootViewId != 0 && UiManager.Instance.GetView(this.RootViewId) is SolarSchoolRootView;
		}

		// Token: 0x060386E5 RID: 231141 RVA: 0x00FC8908 File Offset: 0x00FC6B08
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<SolarSchoolRootView> EnsureRootViewAsync()
		{
			SolarSchoolGamePlayModel.<EnsureRootViewAsync>d__331 <EnsureRootViewAsync>d__;
			<EnsureRootViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<SolarSchoolRootView>.Create();
			<EnsureRootViewAsync>d__.<>4__this = this;
			<EnsureRootViewAsync>d__.<>1__state = -1;
			<EnsureRootViewAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<EnsureRootViewAsync>d__331>(ref <EnsureRootViewAsync>d__);
			return <EnsureRootViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386E6 RID: 231142 RVA: 0x00FC894C File Offset: 0x00FC6B4C
		public UniTask OpenRewardTipViewAsync()
		{
			SolarSchoolGamePlayModel.<OpenRewardTipViewAsync>d__332 <OpenRewardTipViewAsync>d__;
			<OpenRewardTipViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenRewardTipViewAsync>d__.<>4__this = this;
			<OpenRewardTipViewAsync>d__.<>1__state = -1;
			<OpenRewardTipViewAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<OpenRewardTipViewAsync>d__332>(ref <OpenRewardTipViewAsync>d__);
			return <OpenRewardTipViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386E7 RID: 231143 RVA: 0x00FC898F File Offset: 0x00FC6B8F
		[NullableContext(2)]
		private SolarSchoolRewardTipView GetRewardTipView()
		{
			return UiManager.Instance.GetViewByName(EUiViewName.SolarSchoolRewardTipView) as SolarSchoolRewardTipView;
		}

		// Token: 0x060386E8 RID: 231144 RVA: 0x00FC89A8 File Offset: 0x00FC6BA8
		[NullableContext(2)]
		private SolarSchoolRootView GetRootView()
		{
			if (this.RootViewId == 0)
			{
				return null;
			}
			SolarSchoolRootView solarSchoolRootView = UiManager.Instance.GetView(this.RootViewId) as SolarSchoolRootView;
			if (solarSchoolRootView == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] RootView 取不到，导航失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rootViewId", this.RootViewId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return solarSchoolRootView;
		}

		// Token: 0x060386E9 RID: 231145 RVA: 0x00FC8A0B File Offset: 0x00FC6C0B
		[NullableContext(2)]
		public void OpenMapView(SolarSchoolMapPanelParam viewParam = null)
		{
			this.OpenMapViewAsync(viewParam).Forget();
		}

		// Token: 0x060386EA RID: 231146 RVA: 0x00FC8A1C File Offset: 0x00FC6C1C
		[NullableContext(2)]
		public UniTask OpenMapViewAsync(SolarSchoolMapPanelParam viewParam = null)
		{
			SolarSchoolGamePlayModel.<OpenMapViewAsync>d__336 <OpenMapViewAsync>d__;
			<OpenMapViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenMapViewAsync>d__.<>4__this = this;
			<OpenMapViewAsync>d__.viewParam = viewParam;
			<OpenMapViewAsync>d__.<>1__state = -1;
			<OpenMapViewAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<OpenMapViewAsync>d__336>(ref <OpenMapViewAsync>d__);
			return <OpenMapViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386EB RID: 231147 RVA: 0x00FC8A67 File Offset: 0x00FC6C67
		public void OpenQuestView()
		{
			SolarSchoolRootView rootView = this.GetRootView();
			if (rootView == null)
			{
				return;
			}
			rootView.OpenChildView(ECommonChildViewName.SolarSchoolQuest, null);
		}

		// Token: 0x060386EC RID: 231148 RVA: 0x00FC8A7B File Offset: 0x00FC6C7B
		public void MarkCurrentLocationPresentFinished()
		{
			SolarSchoolRootView rootView = this.GetRootView();
			if (rootView == null)
			{
				return;
			}
			rootView.MarkCurrentLocationPresentFinished();
		}

		// Token: 0x060386ED RID: 231149 RVA: 0x00FC8A90 File Offset: 0x00FC6C90
		[NullableContext(0)]
		public UniTask<bool> OpenBehaviorExecuteViewAsync([Nullable(1)] SolarSchoolBehaviorExecuteParam param)
		{
			SolarSchoolGamePlayModel.<OpenBehaviorExecuteViewAsync>d__339 <OpenBehaviorExecuteViewAsync>d__;
			<OpenBehaviorExecuteViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenBehaviorExecuteViewAsync>d__.<>4__this = this;
			<OpenBehaviorExecuteViewAsync>d__.param = param;
			<OpenBehaviorExecuteViewAsync>d__.<>1__state = -1;
			<OpenBehaviorExecuteViewAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<OpenBehaviorExecuteViewAsync>d__339>(ref <OpenBehaviorExecuteViewAsync>d__);
			return <OpenBehaviorExecuteViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386EE RID: 231150 RVA: 0x00FC8ADC File Offset: 0x00FC6CDC
		public void CloseBehaviorExecuteView()
		{
			SolarSchoolRootView rootView = this.GetRootView();
			if (rootView == null || rootView.CurrentChildViewName.GetValueOrDefault() != ECommonChildViewName.SolarSchoolBehaviorExecute)
			{
				return;
			}
			rootView.CloseCurChildView();
		}

		// Token: 0x060386EF RID: 231151 RVA: 0x00FC8B13 File Offset: 0x00FC6D13
		public void CloseFinishedPresentView()
		{
			SolarSchoolRootView rootView = this.GetRootView();
			if (rootView == null)
			{
				return;
			}
			rootView.CloseCurChildViewIfNotKeep();
		}

		// Token: 0x060386F0 RID: 231152 RVA: 0x00FC8B25 File Offset: 0x00FC6D25
		public void RefreshMapView()
		{
			SolarSchoolRootView rootView = this.GetRootView();
			if (rootView == null)
			{
				return;
			}
			rootView.RefreshMapPanel();
		}

		// Token: 0x060386F1 RID: 231153 RVA: 0x00FC8B37 File Offset: 0x00FC6D37
		public void PushRootHudHide()
		{
			SolarSchoolRootView rootView = this.GetRootView();
			if (rootView == null)
			{
				return;
			}
			rootView.PushHudHide();
		}

		// Token: 0x060386F2 RID: 231154 RVA: 0x00FC8B49 File Offset: 0x00FC6D49
		public void PopRootHudHide()
		{
			SolarSchoolRootView rootView = this.GetRootView();
			if (rootView == null)
			{
				return;
			}
			rootView.PopHudHide();
		}

		// Token: 0x17006C08 RID: 27656
		// (get) Token: 0x060386F3 RID: 231155 RVA: 0x00FC8B5B File Offset: 0x00FC6D5B
		[Nullable(2)]
		public SolarSchoolRootViewModel RootViewModel
		{
			[NullableContext(2)]
			get
			{
				if (this.RootViewId == 0)
				{
					return null;
				}
				SolarSchoolRootView solarSchoolRootView = UiManager.Instance.GetView(this.RootViewId) as SolarSchoolRootView;
				if (solarSchoolRootView == null)
				{
					return null;
				}
				return solarSchoolRootView.ViewModel;
			}
		}

		// Token: 0x060386F4 RID: 231156 RVA: 0x00FC8B88 File Offset: 0x00FC6D88
		public UniTask OpenHomeViewAsync()
		{
			SolarSchoolGamePlayModel.<OpenHomeViewAsync>d__347 <OpenHomeViewAsync>d__;
			<OpenHomeViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenHomeViewAsync>d__.<>4__this = this;
			<OpenHomeViewAsync>d__.<>1__state = -1;
			<OpenHomeViewAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<OpenHomeViewAsync>d__347>(ref <OpenHomeViewAsync>d__);
			return <OpenHomeViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060386F5 RID: 231157 RVA: 0x00FC8BCC File Offset: 0x00FC6DCC
		public UniTask OpenLocationViewAsync(int locationId)
		{
			SolarSchoolGamePlayModel.<OpenLocationViewAsync>d__348 <OpenLocationViewAsync>d__;
			<OpenLocationViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenLocationViewAsync>d__.<>4__this = this;
			<OpenLocationViewAsync>d__.locationId = locationId;
			<OpenLocationViewAsync>d__.<>1__state = -1;
			<OpenLocationViewAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<OpenLocationViewAsync>d__348>(ref <OpenLocationViewAsync>d__);
			return <OpenLocationViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x17006C09 RID: 27657
		// (get) Token: 0x060386F6 RID: 231158 RVA: 0x00FC8C17 File Offset: 0x00FC6E17
		public bool HasRunningTask
		{
			get
			{
				SolarSchoolTaskStateBase currentTaskState = this.CurrentTaskState;
				return currentTaskState != null && currentTaskState.HasRunningTask;
			}
		}

		// Token: 0x060386F7 RID: 231159 RVA: 0x00FC8C2C File Offset: 0x00FC6E2C
		public bool TryNotifyConfirmPopupClosed()
		{
			SolarSchoolTaskStateBase currentTaskState = this.CurrentTaskState;
			SolarSchoolTaskBase solarSchoolTaskBase = (currentTaskState != null) ? currentTaskState.GetRunningTask() : null;
			if (solarSchoolTaskBase != null && solarSchoolTaskBase.HandlerHasWork)
			{
				solarSchoolTaskBase.ActionSequenceFinished -= this.OnConfirmPopupSequenceFinished;
				solarSchoolTaskBase.ActionSequenceFinished += this.OnConfirmPopupSequenceFinished;
				return true;
			}
			return false;
		}

		// Token: 0x060386F8 RID: 231160 RVA: 0x00FC8C7E File Offset: 0x00FC6E7E
		private void OnConfirmPopupSequenceFinished(SolarSchoolTaskBase task)
		{
			task.ActionSequenceFinished -= this.OnConfirmPopupSequenceFinished;
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "SolarSchoolConfirmPopupSequenceFinished");
		}

		// Token: 0x060386F9 RID: 231161 RVA: 0x00FC8CA7 File Offset: 0x00FC6EA7
		public bool TryInjectActionToCurrentTask(SolarSchoolActionBase action)
		{
			if (action == null)
			{
				return false;
			}
			SolarSchoolTaskStateBase currentTaskState = this.CurrentTaskState;
			return currentTaskState != null && currentTaskState.TryPushActionToCurrentTask(action);
		}

		// Token: 0x060386FA RID: 231162 RVA: 0x00FC8CC0 File Offset: 0x00FC6EC0
		public bool TryInjectTipsPopup(int itemId, int count)
		{
			if (this.IsInEndingStage)
			{
				return false;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["PopupType"] = "Tips";
			dictionary["ItemId"] = itemId.ToString(CultureInfo.InvariantCulture);
			dictionary["Count"] = count.ToString(CultureInfo.InvariantCulture);
			return this.TryInjectPopupAction(dictionary);
		}

		// Token: 0x060386FB RID: 231163 RVA: 0x00FC8D20 File Offset: 0x00FC6F20
		public bool TryInjectFavorPopup(int roleId, int previousLevel, int finalLevel)
		{
			if (finalLevel <= previousLevel || this.IsInEndingStage)
			{
				return false;
			}
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["PopupType"] = "Favor";
			dictionary["RoleId"] = roleId.ToString(CultureInfo.InvariantCulture);
			dictionary["PreviousLevel"] = previousLevel.ToString(CultureInfo.InvariantCulture);
			dictionary["FinalLevel"] = finalLevel.ToString(CultureInfo.InvariantCulture);
			return this.TryInjectPopupAction(dictionary);
		}

		// Token: 0x060386FC RID: 231164 RVA: 0x00FC8D9B File Offset: 0x00FC6F9B
		public bool TryInjectBuildPopup(string tipsKey, string iconPath)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			dictionary["PopupType"] = "Build";
			dictionary["TipsKey"] = tipsKey;
			dictionary["IconPath"] = iconPath;
			return this.TryInjectPopupAction(dictionary);
		}

		// Token: 0x060386FD RID: 231165 RVA: 0x00FC8DD0 File Offset: 0x00FC6FD0
		public bool TryInjectBehaviorDonePopup(int behaviorId, string textKey = "", bool showAttrList = true)
		{
			return this.TryInjectPopupAction(SolarSchoolPopupAction.CreateBehaviorDonePopupParams(behaviorId, textKey, showAttrList));
		}

		// Token: 0x060386FE RID: 231166 RVA: 0x00FC8DE0 File Offset: 0x00FC6FE0
		private bool TryInjectAttrRankUpPopup(IReadOnlyList<SolarSchoolAttrRankUpInfo> attributeRankUps)
		{
			return this.TryInjectPopupAction(SolarSchoolPopupAction.CreateAttrRankUpPopupParams(attributeRankUps));
		}

		// Token: 0x060386FF RID: 231167 RVA: 0x00FC8DF0 File Offset: 0x00FC6FF0
		private bool TryInjectPopupAction(IReadOnlyDictionary<string, string> parameters)
		{
			SolarSchoolActionBase solarSchoolActionBase = this.CreateAction(EActivityActionType.SolarSchoolPopup, parameters);
			return solarSchoolActionBase != null && this.TryInjectActionToCurrentTask(solarSchoolActionBase);
		}

		// Token: 0x06038700 RID: 231168 RVA: 0x00FC8E16 File Offset: 0x00FC7016
		public bool GmRunActionNow(int actionId)
		{
			return false;
		}

		// Token: 0x06038701 RID: 231169 RVA: 0x00FC8E19 File Offset: 0x00FC7019
		public bool GmSetBehaviorForcedResult(int behaviorId, bool? forcedResult)
		{
			return false;
		}

		// Token: 0x06038702 RID: 231170 RVA: 0x00FC8E1C File Offset: 0x00FC701C
		public bool GmSetAllFavorMax()
		{
			return false;
		}

		// Token: 0x06038703 RID: 231171 RVA: 0x00FC8E1F File Offset: 0x00FC701F
		[NullableContext(0)]
		public UniTask<bool> GmEnterEnding()
		{
			return UniTask.FromResult<bool>(false);
		}

		// Token: 0x06038704 RID: 231172 RVA: 0x00FC8E27 File Offset: 0x00FC7027
		[NullableContext(0)]
		public UniTask<bool> GmJumpToDay(int dayIndex)
		{
			return UniTask.FromResult<bool>(false);
		}

		// Token: 0x06038705 RID: 231173 RVA: 0x00FC8E2F File Offset: 0x00FC702F
		private void AbortCurrentStateTask()
		{
			SolarSchoolTaskStateBase currentTaskState = this.CurrentTaskState;
			if (currentTaskState == null)
			{
				return;
			}
			currentTaskState.AbortCurrentTask();
		}

		// Token: 0x06038706 RID: 231174 RVA: 0x00FC8E44 File Offset: 0x00FC7044
		[NullableContext(0)]
		public UniTask<bool> SwitchToSaveAsync(int activityId, int slotId, [Nullable(1)] SolarSchoolSavePb save)
		{
			SolarSchoolGamePlayModel.<SwitchToSaveAsync>d__366 <SwitchToSaveAsync>d__;
			<SwitchToSaveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<SwitchToSaveAsync>d__.<>4__this = this;
			<SwitchToSaveAsync>d__.activityId = activityId;
			<SwitchToSaveAsync>d__.slotId = slotId;
			<SwitchToSaveAsync>d__.save = save;
			<SwitchToSaveAsync>d__.<>1__state = -1;
			<SwitchToSaveAsync>d__.<>t__builder.Start<SolarSchoolGamePlayModel.<SwitchToSaveAsync>d__366>(ref <SwitchToSaveAsync>d__);
			return <SwitchToSaveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038707 RID: 231175 RVA: 0x00FC8E9F File Offset: 0x00FC709F
		private void InitTimerSystem()
		{
			if (this.TimerHandle != null)
			{
				this.ClearTimerHandle();
			}
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.OnTick), 20f, 1f, null, null, true);
		}

		// Token: 0x06038708 RID: 231176 RVA: 0x00FC8ED8 File Offset: 0x00FC70D8
		private void OnTick(float deltaTime)
		{
			SolarSchoolStageFsm stageFsm = this.StageFsm;
			if (stageFsm != null)
			{
				stageFsm.Tick(deltaTime);
			}
			this.FlushAttrRankUps();
		}

		// Token: 0x06038709 RID: 231177 RVA: 0x00FC8EF2 File Offset: 0x00FC70F2
		private void ClearTimerSystem()
		{
			this.ClearTimerHandle();
		}

		// Token: 0x0603870A RID: 231178 RVA: 0x00FC8EFA File Offset: 0x00FC70FA
		private void ClearTimerHandle()
		{
			if (TimerSystem.GameplayTimeInstance.Has(this.TimerHandle))
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x17006C0A RID: 27658
		// (get) Token: 0x0603870B RID: 231179 RVA: 0x00FC8F26 File Offset: 0x00FC7126
		// (set) Token: 0x0603870C RID: 231180 RVA: 0x00FC8F2E File Offset: 0x00FC712E
		public int CycleCount { get; private set; } = 1;

		// Token: 0x17006C0B RID: 27659
		// (get) Token: 0x0603870D RID: 231181 RVA: 0x00FC8F37 File Offset: 0x00FC7137
		// (set) Token: 0x0603870E RID: 231182 RVA: 0x00FC8F3F File Offset: 0x00FC713F
		public int TraceId { get; private set; }

		// Token: 0x17006C0C RID: 27660
		// (get) Token: 0x0603870F RID: 231183 RVA: 0x00FC8F48 File Offset: 0x00FC7148
		public bool HasWeekSnapshot
		{
			get
			{
				return this.CurWeekSnapshot != null;
			}
		}

		// Token: 0x06038710 RID: 231184 RVA: 0x00FC8F54 File Offset: 0x00FC7154
		public bool HasLocalRecord(ESolarSchoolLocalRecordType recordType, int recordId)
		{
			HashSet<int> hashSet;
			return this.CheckLocalRecordKey(recordType, recordId) && this.CurrentLocalRecord.Records.TryGetValue(recordType, out hashSet) && hashSet.Contains(recordId);
		}

		// Token: 0x06038711 RID: 231185 RVA: 0x00FC8F8C File Offset: 0x00FC718C
		public bool MarkLocalRecord(ESolarSchoolLocalRecordType recordType, int recordId)
		{
			if (!this.CheckLocalRecordKey(recordType, recordId))
			{
				return false;
			}
			HashSet<int> hashSet;
			if (this.CurrentLocalRecord.Records.TryGetValue(recordType, out hashSet) && hashSet.Contains(recordId))
			{
				return true;
			}
			this.CurrentLocalRecord = SolarSchoolUtils.AddLocalRecord(this.CurrentLocalRecord, recordType, recordId);
			return true;
		}

		// Token: 0x06038712 RID: 231186 RVA: 0x00FC8FDC File Offset: 0x00FC71DC
		private unsafe bool CheckLocalRecordKey(ESolarSchoolLocalRecordType recordType, int recordId)
		{
			if (recordType != ESolarSchoolLocalRecordType.None)
			{
				return true;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 操作本地记录失败：记录键非法";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("recordType", recordType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("recordId", recordId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}

		// Token: 0x06038713 RID: 231187 RVA: 0x00FC904F File Offset: 0x00FC724F
		public void RegisterRecordData(SolarSchoolRecordBase data)
		{
			this.RecordDataSet.Add(data);
		}

		// Token: 0x06038714 RID: 231188 RVA: 0x00FC9060 File Offset: 0x00FC7260
		public void LoadRecord(SolarSchoolSaveGamePb gameData)
		{
			foreach (SolarSchoolRecordBase solarSchoolRecordBase in this.RecordDataSet)
			{
				solarSchoolRecordBase.Deserialize(gameData);
			}
		}

		// Token: 0x06038715 RID: 231189 RVA: 0x00FC90B4 File Offset: 0x00FC72B4
		private void RestoreRuntimeAfterLoad()
		{
			this.RebuildSpecialItemBonuses();
			this.ReconcileFavorPermanentBuffs();
			this.RebuildActiveBuffDerivedEffects(true);
			this.ShopData.Refresh(this.ActivityId, this.TimeData.GetCurrentWeek());
			this.ScheduleData.EnsureWeekInstanceIdsSaved(this.TimeData.CurrentMondayDayIndex);
			SolarSchoolSpecialBehaviorCenter.Instance.RestoreFromSave(this.ActivityId);
			this.RestoreWeekScheduleFromSave();
			this.ShopData.Refresh(this.ActivityId, this.TimeData.GetCurrentWeek());
			SolarSchoolQuestCenter.Instance.RestoreFromSave(this.ActivityId);
			this.PlayerData.MarkWeeklyRewardSettled(this.TimeData.CurrentMondayDayIndex);
		}

		// Token: 0x06038716 RID: 231190 RVA: 0x00FC9164 File Offset: 0x00FC7364
		private void RebuildSpecialItemBonuses()
		{
			Dictionary<ESolarSchoolSecondAttr, int> dictionary = new Dictionary<ESolarSchoolSecondAttr, int>();
			foreach (SolarSchoolItem item in SolarSchoolConfig.Instance.GetItemListByActivityId(this.ActivityId))
			{
				if (item.ItemType == 2 && this.InventoryData.HasAcquiredItem(item.Id))
				{
					foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in this.GetItemAttrDeltas(item))
					{
						ESolarSchoolSecondAttr item2 = valueTuple.Item1;
						int item3 = valueTuple.Item2;
						dictionary[item2] = dictionary.GetValueOrDefault(item2, 0) + item3;
					}
				}
			}
			this.PlayerData.ReplaceAttrBonuses(dictionary);
		}

		// Token: 0x06038717 RID: 231191 RVA: 0x00FC9244 File Offset: 0x00FC7444
		private unsafe void RebuildActiveBuffDerivedEffects(bool silentAttributeChanges)
		{
			Dictionary<ValueTuple<int, int>, int> effectValues = new Dictionary<ValueTuple<int, int>, int>();
			foreach (int num in this.PlayerData.GetActiveBuffIds())
			{
				SolarSchoolBuff solarSchoolBuff;
				List<SolarSchoolGamePlayModel.BuffEffectInfo> list;
				string item;
				if (!this.TryPrepareBuff(num, out solarSchoolBuff, out list, out item))
				{
					this.PlayerData.RemoveBuff(num);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SolarSchool;
					ELogAuthor author = ELogAuthor.LRC;
					string message = "[SolarSchool] 活动 Buff 配置失效，已从运行态移除";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("buffId", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", item);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					foreach (SolarSchoolGamePlayModel.BuffEffectInfo buffEffectInfo in list)
					{
						if (buffEffectInfo.BehaviorIds.Length == 0)
						{
							SolarSchoolGamePlayModel.AccumulateBuffEffect(effectValues, buffEffectInfo.Type, 0, buffEffectInfo.Value);
						}
						else
						{
							foreach (int behaviorId in buffEffectInfo.BehaviorIds)
							{
								SolarSchoolGamePlayModel.AccumulateBuffEffect(effectValues, buffEffectInfo.Type, behaviorId, buffEffectInfo.Value);
							}
						}
					}
				}
			}
			this.PlayerData.ReplaceBuffEffects(effectValues, silentAttributeChanges);
		}

		// Token: 0x06038718 RID: 231192 RVA: 0x00FC93D0 File Offset: 0x00FC75D0
		private static void AccumulateBuffEffect([TupleElementNames(new string[]
		{
			"Type",
			"BehaviorId"
		})] [Nullable(new byte[]
		{
			1,
			0
		})] Dictionary<ValueTuple<int, int>, int> effectValues, int type, int behaviorId, int value)
		{
			ValueTuple<int, int> key = new ValueTuple<int, int>(type, behaviorId);
			int num = effectValues.GetValueOrDefault(key, 0) + value;
			if (num == 0)
			{
				effectValues.Remove(key);
				return;
			}
			effectValues[key] = num;
		}

		// Token: 0x06038719 RID: 231193 RVA: 0x00FC9408 File Offset: 0x00FC7608
		private void RestoreWeekScheduleFromSave()
		{
			if (this.TimeData.DayOfWeek != DayOfWeek.Monday)
			{
				return;
			}
			this.ScheduleData.SaveWeekInstanceIds(this.TimeData.DayIndex);
			this.SetScheduleFromSpan(this.TimeData.DayIndex);
			this.LastResetMondayDayIndex = this.TimeData.CurrentMondayDayIndex;
		}

		// Token: 0x0603871A RID: 231194 RVA: 0x00FC945C File Offset: 0x00FC765C
		public SolarSchoolSavePb BuildSavePb()
		{
			SolarSchoolSavePb solarSchoolSavePb = SolarSchoolSavePb.Create();
			solarSchoolSavePb.ActivityId = this.ActivityId;
			solarSchoolSavePb.Version = SolarSchoolConfig.Instance.GetParamInt(this.ActivityId, "SolarSchoolCsCheckResVersion", 0);
			solarSchoolSavePb.TraceId = this.TraceId;
			solarSchoolSavePb.Preview = this.BuildSavePreviewPb();
			solarSchoolSavePb.Game = this.BuildSaveGamePb();
			return solarSchoolSavePb;
		}

		// Token: 0x0603871B RID: 231195 RVA: 0x00FC94BC File Offset: 0x00FC76BC
		private SolarSchoolSaveGamePb BuildSaveGamePb()
		{
			SolarSchoolSaveGamePb solarSchoolSaveGamePb = SolarSchoolSaveGamePb.Create();
			foreach (SolarSchoolRecordBase solarSchoolRecordBase in this.RecordDataSet)
			{
				solarSchoolRecordBase.Serialize(solarSchoolSaveGamePb);
			}
			return solarSchoolSaveGamePb;
		}

		// Token: 0x0603871C RID: 231196 RVA: 0x00FC9514 File Offset: 0x00FC7714
		private SolarSchoolSavePreviewPb BuildSavePreviewPb()
		{
			SolarSchoolSavePreviewPb solarSchoolSavePreviewPb = SolarSchoolSavePreviewPb.Create();
			solarSchoolSavePreviewPb.CycleCount = this.CycleCount;
			solarSchoolSavePreviewPb.GameDay = this.TimeData.DayIndex;
			foreach (ESolarSchoolSecondAttr esolarSchoolSecondAttr in Enum.GetValues<ESolarSchoolSecondAttr>())
			{
				if (esolarSchoolSecondAttr != ESolarSchoolSecondAttr.None)
				{
					SolarSchoolAttrPb solarSchoolAttrPb = SolarSchoolAttrPb.Create();
					solarSchoolAttrPb.AttrType = (SolarSchoolAttrType)esolarSchoolSecondAttr;
					solarSchoolAttrPb.Value = this.PlayerData.GetAttr(esolarSchoolSecondAttr);
					solarSchoolSavePreviewPb.Attr.Add(solarSchoolAttrPb);
				}
			}
			return solarSchoolSavePreviewPb;
		}

		// Token: 0x0603871D RID: 231197 RVA: 0x00FC9590 File Offset: 0x00FC7790
		[NullableContext(2)]
		public unsafe void CaptureWeekSnapshot(SolarSchoolSaveReason reason, bool uploadAutoSave = true, Action<bool> onUploadFinish = null)
		{
			if (!this.InGamePlay)
			{
				Log.Instance.Error(ELogModule.SolarSchool, ELogAuthor.LRC, "[SolarSchool] 定格存档快照失败：游戏未开始", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.CurWeekSnapshot = this.BuildSavePb();
			this.WeekSnapshotLocalRecord = SolarSchoolUtils.CloneLocalSlot(this.CurrentLocalRecord);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 已定格本周存档快照";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dayIndex", this.TimeData.DayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("cycleCount", this.CycleCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("reason", reason);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (!uploadAutoSave)
			{
				return;
			}
			if (reason == SolarSchoolSaveReason.SolarSchoolReasonNewCycle)
			{
				SolarSchoolController.Instance.DiscardPendingSyncBeforeNewCycle();
			}
			else
			{
				SolarSchoolController.Instance.FlushBatchSync();
			}
			SolarSchoolController.Instance.SendAutoSave(reason, onUploadFinish);
		}

		// Token: 0x0603871E RID: 231198 RVA: 0x00FC9698 File Offset: 0x00FC7898
		private int CreateTraceId()
		{
			return (int)TimeUtil.Instance.GetServerTime();
		}

		// Token: 0x0603871F RID: 231199 RVA: 0x00FC96A5 File Offset: 0x00FC78A5
		[NullableContext(2)]
		public SolarSchoolSavePb GetWeekSnapshot()
		{
			return this.CurWeekSnapshot;
		}

		// Token: 0x06038720 RID: 231200 RVA: 0x00FC96AD File Offset: 0x00FC78AD
		public SolarSchoolSlotLocalData GetWeekLocalRecordSnapshot()
		{
			return SolarSchoolUtils.CloneLocalSlot(this.WeekSnapshotLocalRecord);
		}

		// Token: 0x17006C0D RID: 27661
		// (get) Token: 0x06038721 RID: 231201 RVA: 0x00FC96BA File Offset: 0x00FC78BA
		public static SolarSchoolGamePlayModel Instance
		{
			get
			{
				return SolarSchoolGamePlayModel._Instance;
			}
		}

		// Token: 0x06038722 RID: 231202 RVA: 0x00FC96C1 File Offset: 0x00FC78C1
		public static SolarSchoolGamePlayModel GetOrCreateInstance()
		{
			if (SolarSchoolGamePlayModel._Instance == null)
			{
				SolarSchoolGamePlayModel.CreateInstance();
			}
			return SolarSchoolGamePlayModel._Instance;
		}

		// Token: 0x06038723 RID: 231203 RVA: 0x00FC96D5 File Offset: 0x00FC78D5
		public static bool CreateInstance()
		{
			if (SolarSchoolGamePlayModel._Instance != null)
			{
				return true;
			}
			SolarSchoolGamePlayModel._Instance = new SolarSchoolGamePlayModel();
			return true;
		}

		// Token: 0x06038724 RID: 231204 RVA: 0x00FC96EB File Offset: 0x00FC78EB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06038725 RID: 231205 RVA: 0x00FC96ED File Offset: 0x00FC78ED
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolGamePlayModel._Instance = null;
		}

		// Token: 0x06038726 RID: 231206 RVA: 0x00FC96F5 File Offset: 0x00FC78F5
		static SolarSchoolGamePlayModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolGamePlayModel.CreateStaticDefaultValue), new Action(SolarSchoolGamePlayModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401DBF0 RID: 121840
		private const string GAMEPLAY_BGM_EVENT = "play_solarschool_main";

		// Token: 0x0401DBF1 RID: 121841
		private const string GAMEPLAY_AUDIO_FILTER = "ui_only_ui";

		// Token: 0x0401DBF2 RID: 121842
		private const string SEASON_STATE_GROUP = "solarschool_season";

		// Token: 0x0401DBF3 RID: 121843
		private const string DAYTIME_STATE_GROUP = "solarschool_daytime";

		// Token: 0x0401DBF4 RID: 121844
		private const string FILTER_STATE_GROUP = "solarschool_filter";

		// Token: 0x0401DBF5 RID: 121845
		private const string DEFAULT_FILTER_STATE = "none";

		// Token: 0x0401DBF6 RID: 121846
		private const string NIAGARA_COMPUTE_SHADERS_CVAR = "fx.NiagaraAllowComputeShaders";

		// Token: 0x0401DBF7 RID: 121847
		public int ActivityId;

		// Token: 0x0401DBF8 RID: 121848
		private bool InGamePlay;

		// Token: 0x0401DBF9 RID: 121849
		private bool GameplayNiagaraComputeShadersOverridden;

		// Token: 0x0401DBFB RID: 121851
		private int PendingSkipTargetDayIndex;

		// Token: 0x0401DBFC RID: 121852
		private int RootViewId;

		// Token: 0x0401DBFD RID: 121853
		private int GameplayBgmHandle;

		// Token: 0x0401DBFE RID: 121854
		private int GameplayAudioFilterHandle;

		// Token: 0x0401DBFF RID: 121855
		private string SeasonAudioState = string.Empty;

		// Token: 0x0401DC00 RID: 121856
		private string DaytimeAudioState = string.Empty;

		// Token: 0x0401DC01 RID: 121857
		private string CurrentFilterState = string.Empty;

		// Token: 0x0401DC02 RID: 121858
		private readonly HashSet<string> ViewNameSet = new HashSet<string>();

		// Token: 0x0401DC03 RID: 121859
		private readonly Dictionary<int, SolarSchoolGamePlayModel.ViewAudioState> ViewAudioStates = new Dictionary<int, SolarSchoolGamePlayModel.ViewAudioState>();

		// Token: 0x0401DC04 RID: 121860
		private readonly HashSet<int> CheckingBehaviorUnlockIds = new HashSet<int>();

		// Token: 0x0401DC05 RID: 121861
		private bool BehaviorFastForwardEnabled;

		// Token: 0x0401DC06 RID: 121862
		public bool GmShowDebugInfo;

		// Token: 0x0401DC19 RID: 121881
		private bool SlotTransitionUnplayed;

		// Token: 0x0401DC1A RID: 121882
		private bool DaySmallTransitionUnplayed;

		// Token: 0x0401DC1B RID: 121883
		[Nullable(2)]
		private SolarSchoolStageFsm StageFsm;

		// Token: 0x0401DC1C RID: 121884
		private readonly List<int> SelectedEndingIdList = new List<int>();

		// Token: 0x0401DC1F RID: 121887
		[Nullable(2)]
		private SolarSchoolEndingSnapshot EndingSnapshot;

		// Token: 0x0401DC20 RID: 121888
		private int NoScheduleTipMondayDayIndex;

		// Token: 0x0401DC21 RID: 121889
		[TupleElementNames(new string[]
		{
			"itemId",
			"count"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly List<ValueTuple<int, int>> PendingTipsPopups = new List<ValueTuple<int, int>>();

		// Token: 0x0401DC22 RID: 121890
		private readonly List<SolarSchoolAttrRankUpInfo> PendingAttrRankUps = new List<SolarSchoolAttrRankUpInfo>();

		// Token: 0x0401DC23 RID: 121891
		[Nullable(2)]
		private TimerHandle TimerHandle;

		// Token: 0x0401DC24 RID: 121892
		private readonly HashSet<SolarSchoolRecordBase> RecordDataSet = new HashSet<SolarSchoolRecordBase>();

		// Token: 0x0401DC25 RID: 121893
		[Nullable(2)]
		private SolarSchoolSavePb CurWeekSnapshot;

		// Token: 0x0401DC26 RID: 121894
		private SolarSchoolSlotLocalData CurrentLocalRecord = new SolarSchoolSlotLocalData();

		// Token: 0x0401DC27 RID: 121895
		private SolarSchoolSlotLocalData WeekSnapshotLocalRecord = new SolarSchoolSlotLocalData();

		// Token: 0x0401DC28 RID: 121896
		private int LastResetMondayDayIndex;

		// Token: 0x0401DC2B RID: 121899
		[Nullable(2)]
		private static SolarSchoolGamePlayModel _Instance;

		// Token: 0x0200B512 RID: 46354
		[Nullable(0)]
		private readonly struct ViewAudioState
		{
			// Token: 0x06047AE8 RID: 293608 RVA: 0x015CFDDA File Offset: 0x015CDFDA
			public ViewAudioState(int depth, string audioState)
			{
				this.Depth = depth;
				this.AudioState = audioState;
			}

			// Token: 0x04037FC6 RID: 229318
			public readonly int Depth;

			// Token: 0x04037FC7 RID: 229319
			public readonly string AudioState;
		}

		// Token: 0x0200B513 RID: 46355
		[Nullable(0)]
		private readonly struct BuffEffectInfo : IEquatable<SolarSchoolGamePlayModel.BuffEffectInfo>
		{
			// Token: 0x06047AE9 RID: 293609 RVA: 0x015CFDEA File Offset: 0x015CDFEA
			public BuffEffectInfo(int Type, int Value, int[] BehaviorIds)
			{
				this.Type = Type;
				this.Value = Value;
				this.BehaviorIds = BehaviorIds;
			}

			// Token: 0x17007A3D RID: 31293
			// (get) Token: 0x06047AEA RID: 293610 RVA: 0x015CFE01 File Offset: 0x015CE001
			// (set) Token: 0x06047AEB RID: 293611 RVA: 0x015CFE09 File Offset: 0x015CE009
			public int Type { get; set; }

			// Token: 0x17007A3E RID: 31294
			// (get) Token: 0x06047AEC RID: 293612 RVA: 0x015CFE12 File Offset: 0x015CE012
			// (set) Token: 0x06047AED RID: 293613 RVA: 0x015CFE1A File Offset: 0x015CE01A
			public int Value { get; set; }

			// Token: 0x17007A3F RID: 31295
			// (get) Token: 0x06047AEE RID: 293614 RVA: 0x015CFE23 File Offset: 0x015CE023
			// (set) Token: 0x06047AEF RID: 293615 RVA: 0x015CFE2B File Offset: 0x015CE02B
			public int[] BehaviorIds { get; set; }

			// Token: 0x06047AF0 RID: 293616 RVA: 0x015CFE34 File Offset: 0x015CE034
			[NullableContext(0)]
			[CompilerGenerated]
			public override string ToString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("BuffEffectInfo");
				stringBuilder.Append(" { ");
				if (this.PrintMembers(stringBuilder))
				{
					stringBuilder.Append(' ');
				}
				stringBuilder.Append('}');
				return stringBuilder.ToString();
			}

			// Token: 0x06047AF1 RID: 293617 RVA: 0x015CFE80 File Offset: 0x015CE080
			[NullableContext(0)]
			[CompilerGenerated]
			private bool PrintMembers(StringBuilder builder)
			{
				builder.Append("Type = ");
				builder.Append(this.Type.ToString());
				builder.Append(", Value = ");
				builder.Append(this.Value.ToString());
				builder.Append(", BehaviorIds = ");
				builder.Append(this.BehaviorIds);
				return true;
			}

			// Token: 0x06047AF2 RID: 293618 RVA: 0x015CFEF5 File Offset: 0x015CE0F5
			[CompilerGenerated]
			public static bool operator !=(SolarSchoolGamePlayModel.BuffEffectInfo left, SolarSchoolGamePlayModel.BuffEffectInfo right)
			{
				return !(left == right);
			}

			// Token: 0x06047AF3 RID: 293619 RVA: 0x015CFF01 File Offset: 0x015CE101
			[CompilerGenerated]
			public static bool operator ==(SolarSchoolGamePlayModel.BuffEffectInfo left, SolarSchoolGamePlayModel.BuffEffectInfo right)
			{
				return left.Equals(right);
			}

			// Token: 0x06047AF4 RID: 293620 RVA: 0x015CFF0B File Offset: 0x015CE10B
			[CompilerGenerated]
			public override int GetHashCode()
			{
				return (EqualityComparer<int>.Default.GetHashCode(this.<Type>k__BackingField) * -1521134295 + EqualityComparer<int>.Default.GetHashCode(this.<Value>k__BackingField)) * -1521134295 + EqualityComparer<int[]>.Default.GetHashCode(this.<BehaviorIds>k__BackingField);
			}

			// Token: 0x06047AF5 RID: 293621 RVA: 0x015CFF4B File Offset: 0x015CE14B
			[NullableContext(0)]
			[CompilerGenerated]
			public override bool Equals(object obj)
			{
				return obj is SolarSchoolGamePlayModel.BuffEffectInfo && this.Equals((SolarSchoolGamePlayModel.BuffEffectInfo)obj);
			}

			// Token: 0x06047AF6 RID: 293622 RVA: 0x015CFF64 File Offset: 0x015CE164
			[CompilerGenerated]
			public bool Equals(SolarSchoolGamePlayModel.BuffEffectInfo other)
			{
				return EqualityComparer<int>.Default.Equals(this.<Type>k__BackingField, other.<Type>k__BackingField) && EqualityComparer<int>.Default.Equals(this.<Value>k__BackingField, other.<Value>k__BackingField) && EqualityComparer<int[]>.Default.Equals(this.<BehaviorIds>k__BackingField, other.<BehaviorIds>k__BackingField);
			}

			// Token: 0x06047AF7 RID: 293623 RVA: 0x015CFFB9 File Offset: 0x015CE1B9
			[CompilerGenerated]
			public void Deconstruct(out int Type, out int Value, out int[] BehaviorIds)
			{
				Type = this.Type;
				Value = this.Value;
				BehaviorIds = this.BehaviorIds;
			}
		}

		// Token: 0x0200B514 RID: 46356
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04037FCB RID: 229323
			[Nullable(0)]
			public static Comparison<SolarSchoolBagItemData> <0>__CompareBagItemBySortId;
		}
	}
}
