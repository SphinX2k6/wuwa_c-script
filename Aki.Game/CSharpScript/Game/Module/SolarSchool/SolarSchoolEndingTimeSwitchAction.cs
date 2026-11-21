using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.ActivityAction;
using CSharpScript.Game.Module.VisualNovel;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058B5 RID: 22709
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolEndingTimeSwitchAction : SolarSchoolActionBase
	{
		// Token: 0x06037EF6 RID: 229110 RVA: 0x00FA2718 File Offset: 0x00FA0918
		protected override void OnParse(IReadOnlyDictionary<string, string> parameters)
		{
			this.Month = ActivityActionBase.GetParamInt(parameters, "Month", this.Month);
			this.Day = ActivityActionBase.GetParamInt(parameters, "Day", this.Day);
			this.TimeSlot = (ESolarSchoolTimeSlot)ActivityActionBase.GetParamInt(parameters, "SolarSchoolTimeSlot", (int)this.TimeSlot);
		}

		// Token: 0x06037EF7 RID: 229111 RVA: 0x00FA276C File Offset: 0x00FA096C
		protected unsafe override void OnStart()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			ESolarSchoolStageStateType currentStateType = instance.GetCurrentStateType();
			int month = this.Month;
			bool flag = month >= 1 && month <= 12 && this.Day >= 1 && this.Day <= DateTime.DaysInMonth(2000, this.Month);
			bool flag2 = this.TimeSlot >= ESolarSchoolTimeSlot.Morning && this.TimeSlot <= ESolarSchoolTimeSlot.Night;
			if (currentStateType != ESolarSchoolStageStateType.Ending || !flag || !flag2)
			{
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] EndingTimeSwitchAction 参数或状态非法";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", currentStateType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("month", this.Month);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("day", this.Day);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("timeSlot", this.TimeSlot);
				instance2.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				base.MarkFailed();
				return;
			}
			VisualNovelDate visualNovelDate = new VisualNovelDate(this.Month, this.Day, (int)this.TimeSlot);
			if (!instance.TrySetEndingVisualNovelTime(visualNovelDate))
			{
				Log instance3 = Log.Instance;
				ELogModule module2 = ELogModule.SolarSchool;
				ELogAuthor author2 = ELogAuthor.LRC;
				string message2 = "[SolarSchool] EndingTimeSwitchAction 写入结局表现时间失败";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("actionId", base.ActionId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("month", this.Month);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("day", this.Day);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("timeSlot", this.TimeSlot);
				instance3.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
				base.MarkFailed();
				return;
			}
			SolarSchoolRootViewModel rootViewModel = instance.RootViewModel;
			bool? flag3;
			if (rootViewModel == null)
			{
				flag3 = null;
			}
			else
			{
				Func<VisualNovelDate, Action, bool> playEndingTimeTransition = rootViewModel.PlayEndingTimeTransition;
				flag3 = ((playEndingTimeTransition != null) ? new bool?(playEndingTimeTransition(visualNovelDate, new Action(base.MarkDone))) : null);
			}
			bool? flag4 = flag3;
			if (!flag4.GetValueOrDefault())
			{
				base.MarkDone();
			}
		}

		// Token: 0x06037EF8 RID: 229112 RVA: 0x00FA29E8 File Offset: 0x00FA0BE8
		protected override void OnDelete()
		{
			SolarSchoolRootViewModel rootViewModel = SolarSchoolGamePlayModel.Instance.RootViewModel;
			if (rootViewModel == null)
			{
				return;
			}
			Action stopTimeSlotTransition = rootViewModel.StopTimeSlotTransition;
			if (stopTimeSlotTransition == null)
			{
				return;
			}
			stopTimeSlotTransition();
		}

		// Token: 0x0401D811 RID: 120849
		public const string ParamKeyMonth = "Month";

		// Token: 0x0401D812 RID: 120850
		public const string ParamKeyDay = "Day";

		// Token: 0x0401D813 RID: 120851
		public const string ParamKeyTimeSlot = "SolarSchoolTimeSlot";

		// Token: 0x0401D814 RID: 120852
		private int Month;

		// Token: 0x0401D815 RID: 120853
		private int Day;

		// Token: 0x0401D816 RID: 120854
		private ESolarSchoolTimeSlot TimeSlot;
	}
}
