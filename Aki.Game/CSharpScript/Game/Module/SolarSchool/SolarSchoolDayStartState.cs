using System;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058F1 RID: 22769
	public class SolarSchoolDayStartState : ActivityGameplayTurnStateBase<ESolarSchoolStageStateType>
	{
		// Token: 0x06038245 RID: 229957 RVA: 0x00FB1618 File Offset: 0x00FAF818
		public unsafe override void Enter(ESolarSchoolStageStateType? prev)
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int dayIndex = instance.TimeData.DayIndex;
			instance.SummaryRecordData.EnsureCurrentMonthStarted(dayIndex);
			instance.ResetScheduleOnWeekStart(true);
			instance.BuildWorldDataByDayIndex(dayIndex);
			SolarSchoolQuestCenter.Instance.OnDayStart(dayIndex);
			SolarSchoolSpecialBehaviorCenter.Instance.OnDayStart(dayIndex);
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] DayStart";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dayIndex", dayIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("instanceId", instance.InstanceId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("instanceType", instance.InstanceType);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			ESolarSchoolInstanceType instanceType = instance.InstanceType;
			if (instanceType == ESolarSchoolInstanceType.Normal)
			{
				instance.ChangeState(ESolarSchoolStageStateType.DayInProgress);
				return;
			}
			if (instanceType != ESolarSchoolInstanceType.Exam)
			{
				instance.ChangeState(ESolarSchoolStageStateType.InstanceInProgress);
				return;
			}
			instance.ChangeState(ESolarSchoolStageStateType.ExamInProgress);
		}
	}
}
