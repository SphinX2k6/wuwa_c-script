using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ActivityGamePlay.CommonFSMManager;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058EE RID: 22766
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolStageFsm : CommonFsmManager<ActivityGameplayTurnStateBase<ESolarSchoolStageStateType>, ESolarSchoolStageStateType>
	{
		// Token: 0x0603822A RID: 229930 RVA: 0x00FB078C File Offset: 0x00FAE98C
		protected unsafe override void InitState()
		{
			base.RegisterState(ESolarSchoolStageStateType.GameStart, new SolarSchoolGameStartState());
			base.RegisterState(ESolarSchoolStageStateType.DayStart, new SolarSchoolDayStartState());
			base.RegisterState(ESolarSchoolStageStateType.DayInProgress, new SolarSchoolDayInProgressState());
			base.RegisterState(ESolarSchoolStageStateType.InstanceInProgress, new SolarSchoolInstanceInProgressState());
			base.RegisterState(ESolarSchoolStageStateType.ExamInProgress, new SolarSchoolExamInProgressState());
			base.RegisterState(ESolarSchoolStageStateType.DayEnd, new SolarSchoolDayEndState());
			base.RegisterState(ESolarSchoolStageStateType.Ending, new SolarSchoolEndingState());
			base.RegisterState(ESolarSchoolStageStateType.GameExit, new SolarSchoolGameExitState());
			ESolarSchoolStageStateType from = ESolarSchoolStageStateType.None;
			int num = 1;
			List<ESolarSchoolStageStateType> list = new List<ESolarSchoolStageStateType>(num);
			CollectionsMarshal.SetCount<ESolarSchoolStageStateType>(list, num);
			Span<ESolarSchoolStageStateType> span = CollectionsMarshal.AsSpan<ESolarSchoolStageStateType>(list);
			int num2 = 0;
			*span[num2] = ESolarSchoolStageStateType.GameStart;
			base.RegisterTransition(from, list);
			ESolarSchoolStageStateType from2 = ESolarSchoolStageStateType.GameStart;
			num2 = 3;
			List<ESolarSchoolStageStateType> list2 = new List<ESolarSchoolStageStateType>(num2);
			CollectionsMarshal.SetCount<ESolarSchoolStageStateType>(list2, num2);
			span = CollectionsMarshal.AsSpan<ESolarSchoolStageStateType>(list2);
			num = 0;
			*span[num] = ESolarSchoolStageStateType.DayStart;
			num++;
			*span[num] = ESolarSchoolStageStateType.Ending;
			num++;
			*span[num] = ESolarSchoolStageStateType.GameExit;
			base.RegisterTransition(from2, list2);
			ESolarSchoolStageStateType from3 = ESolarSchoolStageStateType.DayStart;
			num = 4;
			List<ESolarSchoolStageStateType> list3 = new List<ESolarSchoolStageStateType>(num);
			CollectionsMarshal.SetCount<ESolarSchoolStageStateType>(list3, num);
			span = CollectionsMarshal.AsSpan<ESolarSchoolStageStateType>(list3);
			num2 = 0;
			*span[num2] = ESolarSchoolStageStateType.DayInProgress;
			num2++;
			*span[num2] = ESolarSchoolStageStateType.InstanceInProgress;
			num2++;
			*span[num2] = ESolarSchoolStageStateType.ExamInProgress;
			num2++;
			*span[num2] = ESolarSchoolStageStateType.GameExit;
			base.RegisterTransition(from3, list3);
			ESolarSchoolStageStateType from4 = ESolarSchoolStageStateType.DayInProgress;
			num2 = 4;
			List<ESolarSchoolStageStateType> list4 = new List<ESolarSchoolStageStateType>(num2);
			CollectionsMarshal.SetCount<ESolarSchoolStageStateType>(list4, num2);
			span = CollectionsMarshal.AsSpan<ESolarSchoolStageStateType>(list4);
			num = 0;
			*span[num] = ESolarSchoolStageStateType.DayEnd;
			num++;
			*span[num] = ESolarSchoolStageStateType.DayStart;
			num++;
			*span[num] = ESolarSchoolStageStateType.Ending;
			num++;
			*span[num] = ESolarSchoolStageStateType.GameExit;
			base.RegisterTransition(from4, list4);
			ESolarSchoolStageStateType from5 = ESolarSchoolStageStateType.InstanceInProgress;
			num = 4;
			List<ESolarSchoolStageStateType> list5 = new List<ESolarSchoolStageStateType>(num);
			CollectionsMarshal.SetCount<ESolarSchoolStageStateType>(list5, num);
			span = CollectionsMarshal.AsSpan<ESolarSchoolStageStateType>(list5);
			num2 = 0;
			*span[num2] = ESolarSchoolStageStateType.DayEnd;
			num2++;
			*span[num2] = ESolarSchoolStageStateType.DayStart;
			num2++;
			*span[num2] = ESolarSchoolStageStateType.Ending;
			num2++;
			*span[num2] = ESolarSchoolStageStateType.GameExit;
			base.RegisterTransition(from5, list5);
			ESolarSchoolStageStateType from6 = ESolarSchoolStageStateType.ExamInProgress;
			num2 = 4;
			List<ESolarSchoolStageStateType> list6 = new List<ESolarSchoolStageStateType>(num2);
			CollectionsMarshal.SetCount<ESolarSchoolStageStateType>(list6, num2);
			span = CollectionsMarshal.AsSpan<ESolarSchoolStageStateType>(list6);
			num = 0;
			*span[num] = ESolarSchoolStageStateType.DayEnd;
			num++;
			*span[num] = ESolarSchoolStageStateType.DayStart;
			num++;
			*span[num] = ESolarSchoolStageStateType.Ending;
			num++;
			*span[num] = ESolarSchoolStageStateType.GameExit;
			base.RegisterTransition(from6, list6);
			ESolarSchoolStageStateType from7 = ESolarSchoolStageStateType.DayEnd;
			num = 3;
			List<ESolarSchoolStageStateType> list7 = new List<ESolarSchoolStageStateType>(num);
			CollectionsMarshal.SetCount<ESolarSchoolStageStateType>(list7, num);
			span = CollectionsMarshal.AsSpan<ESolarSchoolStageStateType>(list7);
			num2 = 0;
			*span[num2] = ESolarSchoolStageStateType.DayStart;
			num2++;
			*span[num2] = ESolarSchoolStageStateType.Ending;
			num2++;
			*span[num2] = ESolarSchoolStageStateType.GameExit;
			base.RegisterTransition(from7, list7);
			ESolarSchoolStageStateType from8 = ESolarSchoolStageStateType.Ending;
			num2 = 1;
			List<ESolarSchoolStageStateType> list8 = new List<ESolarSchoolStageStateType>(num2);
			CollectionsMarshal.SetCount<ESolarSchoolStageStateType>(list8, num2);
			span = CollectionsMarshal.AsSpan<ESolarSchoolStageStateType>(list8);
			num = 0;
			*span[num] = ESolarSchoolStageStateType.GameExit;
			base.RegisterTransition(from8, list8);
			base.RegisterTransition(ESolarSchoolStageStateType.GameExit, new List<ESolarSchoolStageStateType>());
		}
	}
}
