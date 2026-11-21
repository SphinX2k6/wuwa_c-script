using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058EF RID: 22767
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolDayEndState : SolarSchoolTaskStateBase
	{
		// Token: 0x0603822C RID: 229932 RVA: 0x00FB0A38 File Offset: 0x00FAEC38
		protected unsafe override void OnEnterState(ESolarSchoolStageStateType? prev)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			SolarSchoolTimeData timeData = instance.TimeData;
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] DayEnd";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("dayIndex", timeData.DayIndex);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			timeData.SyncDisplaySlot();
			this.TransitionType = ESolarSchoolTimeTransition.None;
			this.DayAdvanceCount = instance.GetDayEndAdvanceDays();
			this.StartDayIndex = timeData.DayIndex;
			this.TargetDayIndex = instance.GetDayEndTargetDayIndex();
			this.NextSkippedDayIndex = timeData.DayIndex + 1;
			this.TransitionStarted = false;
			this.CurrentDayFlushed = false;
			List<SolarSchoolActionBase> list = SolarSchoolSpecialBehaviorCenter.Instance.SettleDeadlineFailures(timeData.DayIndex);
			instance.SummaryRecordData.TrySettleMonth(timeData.DayIndex);
			instance.AdvanceBuffDays();
			int totalDay = instance.TotalDay;
			if (totalDay <= 0)
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] 总天数读取失败，跳过结局判定继续下一天，检查 SolarSchoolParam 的 TotalDays 配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("activityId", instance.ActivityId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("dayIndex", timeData.DayIndex);
				instance3.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			else if (instance.IsLastDay(timeData.DayIndex))
			{
				Log instance4 = Log.Instance;
				ELogModule module3 = ELogModule.SolarSchool;
				ELogAuthor author3 = ELogAuthor.LRC;
				string message3 = "[SolarSchool] 已到总天数，进入结局流程";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("lastDayIndex", timeData.DayIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("totalDay", totalDay);
				instance4.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				SolarSchoolController.Instance.FlushDayEndBatchSync();
				instance.ChangeState(ESolarSchoolStageStateType.Ending);
				return;
			}
			if (list.Count > 0)
			{
				base.RunTask(new SolarSchoolDayEndTask(list));
				return;
			}
			this.ContinueDayEnd(instance);
		}

		// Token: 0x0603822D RID: 229933 RVA: 0x00FB0C18 File Offset: 0x00FAEE18
		protected override void OnTaskFinish(int taskId)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			if (!this.TransitionStarted)
			{
				this.ContinueDayEnd(instance);
				return;
			}
			if (this.TransitionType == ESolarSchoolTimeTransition.DaySmall)
			{
				instance.SetDaySmallTransitionUnplayed();
			}
			bool flag = this.TransitionType == ESolarSchoolTimeTransition.DayBig;
			if (flag)
			{
				instance.ClearSlotTransitionUnplayed();
				SolarSchoolRootViewModel rootViewModel = instance.RootViewModel;
				if (rootViewModel != null)
				{
					Action stopTimeSlotTransition = rootViewModel.StopTimeSlotTransition;
					if (stopTimeSlotTransition != null)
					{
						stopTimeSlotTransition();
					}
				}
			}
			int days = instance.ConsumeDayEndAdvanceDays();
			instance.TimeData.AdvanceDays(days);
			if (flag)
			{
				SolarSchoolRootViewModel rootViewModel2 = instance.RootViewModel;
				if (rootViewModel2 != null)
				{
					Action snapTimeDisplay = rootViewModel2.SnapTimeDisplay;
					if (snapTimeDisplay != null)
					{
						snapTimeDisplay();
					}
				}
			}
			instance.ChangeState(ESolarSchoolStageStateType.DayStart);
		}

		// Token: 0x0603822E RID: 229934 RVA: 0x00FB0CB0 File Offset: 0x00FAEEB0
		public override bool CanPlayerFreeChoose()
		{
			return false;
		}

		// Token: 0x0603822F RID: 229935 RVA: 0x00FB0CB4 File Offset: 0x00FAEEB4
		private void ContinueDayEnd(SolarSchoolGamePlayModel model)
		{
			if (!this.CurrentDayFlushed)
			{
				this.CurrentDayFlushed = true;
				SolarSchoolController.Instance.FlushDayEndBatchSync();
			}
			while (this.NextSkippedDayIndex < this.TargetDayIndex)
			{
				List<SolarSchoolActionBase> list = model.SettleSkippedDay(this.NextSkippedDayIndex);
				this.NextSkippedDayIndex++;
				if (list.Count != 0)
				{
					base.RunTask(new SolarSchoolDayEndTask(list));
					return;
				}
			}
			this.StartDayTransition(model);
		}

		// Token: 0x06038230 RID: 229936 RVA: 0x00FB0D24 File Offset: 0x00FAEF24
		private unsafe void StartDayTransition(SolarSchoolGamePlayModel model)
		{
			this.TransitionStarted = true;
			if (this.DayAdvanceCount > 1)
			{
				this.TransitionType = ESolarSchoolTimeTransition.DayBig;
			}
			else
			{
				this.TransitionType = model.GetDayTransitionType(model.TimeData.DayIndex);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.BB;
			string message = "[SolarSchool] DayEnd 跨天动效";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dayIndex", model.TimeData.DayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("advanceDays", this.DayAdvanceCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("dayTransition", this.TransitionType);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			List<SolarSchoolActionBase> list = new List<SolarSchoolActionBase>();
			SolarSchoolActionBase solarSchoolActionBase = this.CreateDayTransitionAction(model);
			if (solarSchoolActionBase != null)
			{
				list.Add(solarSchoolActionBase);
			}
			base.RunTask(new SolarSchoolDayEndTask(list));
		}

		// Token: 0x06038231 RID: 229937 RVA: 0x00FB0E18 File Offset: 0x00FAF018
		[return: Nullable(2)]
		private SolarSchoolActionBase CreateDayTransitionAction(SolarSchoolGamePlayModel model)
		{
			switch (this.TransitionType)
			{
			case ESolarSchoolTimeTransition.None:
			case ESolarSchoolTimeTransition.DaySmall:
				return null;
			case ESolarSchoolTimeTransition.DayBig:
				return model.CreateAction(EActivityActionType.SolarSchoolFullScreenDayTransition, new Dictionary<string, string>
				{
					{
						"DayTransitionStartDayIndex",
						this.StartDayIndex.ToString()
					},
					{
						"DayTransitionTargetDayIndex",
						this.TargetDayIndex.ToString()
					}
				});
			}
			EActivityActionType type = EActivityActionType.SolarSchoolDayTransition;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			string key = "SolarSchoolDayTransitionType";
			int transitionType = (int)this.TransitionType;
			dictionary.Add(key, transitionType.ToString());
			return model.CreateAction(type, dictionary);
		}

		// Token: 0x0401D904 RID: 121092
		private ESolarSchoolTimeTransition TransitionType;

		// Token: 0x0401D905 RID: 121093
		private int DayAdvanceCount;

		// Token: 0x0401D906 RID: 121094
		private int StartDayIndex;

		// Token: 0x0401D907 RID: 121095
		private int TargetDayIndex;

		// Token: 0x0401D908 RID: 121096
		private int NextSkippedDayIndex;

		// Token: 0x0401D909 RID: 121097
		private bool TransitionStarted;

		// Token: 0x0401D90A RID: 121098
		private bool CurrentDayFlushed;
	}
}
