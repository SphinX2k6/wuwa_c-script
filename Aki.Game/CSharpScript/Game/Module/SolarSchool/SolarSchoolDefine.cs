using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005978 RID: 22904
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolDefine : IStaticVariableResetter
	{
		// Token: 0x060385EB RID: 230891 RVA: 0x00FC2CA3 File Offset: 0x00FC0EA3
		static SolarSchoolDefine()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SolarSchoolDefine.CreateStaticDefaultValue), new Action(SolarSchoolDefine.ResetStaticDefaultValue));
		}

		// Token: 0x060385EC RID: 230892 RVA: 0x00FC2CC2 File Offset: 0x00FC0EC2
		public static void CreateStaticDefaultValue()
		{
			SolarSchoolDefine.AttrsShowList = new ESolarSchoolSecondAttr[]
			{
				ESolarSchoolSecondAttr.Knowledge,
				ESolarSchoolSecondAttr.Thinking,
				ESolarSchoolSecondAttr.Art,
				ESolarSchoolSecondAttr.Physique,
				ESolarSchoolSecondAttr.Emotion
			};
			SolarSchoolDefine.SummaryAttrs = new ESolarSchoolSecondAttr[]
			{
				ESolarSchoolSecondAttr.Knowledge,
				ESolarSchoolSecondAttr.Thinking,
				ESolarSchoolSecondAttr.Art,
				ESolarSchoolSecondAttr.Physique,
				ESolarSchoolSecondAttr.Emotion,
				ESolarSchoolSecondAttr.Popularity,
				ESolarSchoolSecondAttr.Money
			};
		}

		// Token: 0x060385ED RID: 230893 RVA: 0x00FC2CF0 File Offset: 0x00FC0EF0
		public static void ResetStaticDefaultValue()
		{
			SolarSchoolDefine.AttrsShowList = null;
			SolarSchoolDefine.SummaryAttrs = null;
		}

		// Token: 0x0401DBD7 RID: 121815
		public static ESolarSchoolSecondAttr[] AttrsShowList;

		// Token: 0x0401DBD8 RID: 121816
		public static ESolarSchoolSecondAttr[] SummaryAttrs;

		// Token: 0x0401DBD9 RID: 121817
		public const int MinFavorLevel = 0;

		// Token: 0x0401DBDA RID: 121818
		public const int DefaultFavorUpgradeValue = 100;

		// Token: 0x0401DBDB RID: 121819
		public const int MalePlayerRoleId = 101;

		// Token: 0x0401DBDC RID: 121820
		public const int FemalePlayerRoleId = 102;

		// Token: 0x0401DBDD RID: 121821
		public const int MaxHistoryWeeks = 3;

		// Token: 0x0401DBDE RID: 121822
		public const int WeekdayCount = 5;

		// Token: 0x0401DBDF RID: 121823
		public const int SlotCount = 2;

		// Token: 0x0401DBE0 RID: 121824
		public const int DaysPerWeek = 7;

		// Token: 0x0401DBE1 RID: 121825
		public const int AutoSaveSlotId = 0;

		// Token: 0x0401DBE2 RID: 121826
		public const float ScheduleRowHeight = 128f;

		// Token: 0x0401DBE3 RID: 121827
		public const float SchedulePreviewFramePadding = 8f;

		// Token: 0x0401DBE4 RID: 121828
		public const int NormalInstanceId = 1;

		// Token: 0x0401DBE5 RID: 121829
		public const int ConfirmBoxRightBtnIndex = 2;

		// Token: 0x0401DBE6 RID: 121830
		public const int DefaultSpecialAcceptMaxInProgress = 3;

		// Token: 0x0401DBE7 RID: 121831
		public const int ScheduleViewWeekRange = 3;

		// Token: 0x0401DBE8 RID: 121832
		public const int MainQuestInfoMaxShowCount = 2;

		// Token: 0x0401DBE9 RID: 121833
		public const int DayStartBackgroundId = 700021;

		// Token: 0x0401DBEA RID: 121834
		public const int DayStartMondayBackgroundId = 700020;

		// Token: 0x0401DBEB RID: 121835
		public const string DayTransitionMapMoveEvent = "Map_Move";

		// Token: 0x0401DBEC RID: 121836
		public const string DayTransitionDateChangeEvent = "Sequence_Date_Change";

		// Token: 0x0401DBED RID: 121837
		public const string DayTransitionCoverReadyEvent = "Sequence_Cover_Ready";

		// Token: 0x0401DBEE RID: 121838
		public const string DayTransitionSeqDuskToDay = "Dusk_To_Day";

		// Token: 0x0401DBEF RID: 121839
		public const string DayTransitionSeqDayToDay = "Day_To_Day";
	}
}
