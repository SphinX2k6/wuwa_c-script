using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E0 RID: 22752
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolScheduleData : SolarSchoolRecordBase
	{
		// Token: 0x060380F9 RID: 229625 RVA: 0x00FAB9FB File Offset: 0x00FA9BFB
		public void Clear()
		{
			this.CurWeekBoard.Clear();
		}

		// Token: 0x060380FA RID: 229626 RVA: 0x00FABA08 File Offset: 0x00FA9C08
		public SolarSchoolScheduleBoard CreateDraft()
		{
			SolarSchoolScheduleBoard solarSchoolScheduleBoard = new SolarSchoolScheduleBoard();
			solarSchoolScheduleBoard.CopyFrom(this.CurWeekBoard);
			return solarSchoolScheduleBoard;
		}

		// Token: 0x060380FB RID: 229627 RVA: 0x00FABA1B File Offset: 0x00FA9C1B
		public void ApplyDraft(SolarSchoolScheduleBoard draft)
		{
			this.CurWeekBoard.CopyFrom(draft);
		}

		// Token: 0x060380FC RID: 229628 RVA: 0x00FABA2C File Offset: 0x00FA9C2C
		public void SaveDataForHistory()
		{
			SolarSchoolScheduleBoard solarSchoolScheduleBoard = new SolarSchoolScheduleBoard();
			solarSchoolScheduleBoard.CopyFrom(this.CurWeekBoard);
			this.HistoryWeeks.Insert(0, solarSchoolScheduleBoard);
			while (this.HistoryWeeks.Count > 3)
			{
				this.HistoryWeeks.RemoveAt(this.HistoryWeeks.Count - 1);
			}
		}

		// Token: 0x17006B83 RID: 27523
		// (get) Token: 0x060380FD RID: 229629 RVA: 0x00FABA80 File Offset: 0x00FA9C80
		public int HistoryWeekCount
		{
			get
			{
				return this.HistoryWeeks.Count;
			}
		}

		// Token: 0x060380FE RID: 229630 RVA: 0x00FABA8D File Offset: 0x00FA9C8D
		public bool HasHistoryWeek(int weeksAgo)
		{
			return weeksAgo >= 1 && weeksAgo <= this.HistoryWeeks.Count;
		}

		// Token: 0x060380FF RID: 229631 RVA: 0x00FABAA8 File Offset: 0x00FA9CA8
		public SolarSchoolSlotCell GetHistoryCell(int weeksAgo, int weekday, ESolarSchoolTimeSlot slot)
		{
			if (!this.HasHistoryWeek(weeksAgo))
			{
				return default(SolarSchoolSlotCell);
			}
			return this.HistoryWeeks[weeksAgo - 1].GetCell(weekday, slot);
		}

		// Token: 0x06038100 RID: 229632 RVA: 0x00FABADD File Offset: 0x00FA9CDD
		public int GetHistoryBehaviorId(int weeksAgo, int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.GetHistoryCell(weeksAgo, weekday, slot).BehaviorId;
		}

		// Token: 0x17006B84 RID: 27524
		// (get) Token: 0x06038101 RID: 229633 RVA: 0x00FABAED File Offset: 0x00FA9CED
		public bool HasLastWeekData
		{
			get
			{
				return this.HasHistoryWeek(1);
			}
		}

		// Token: 0x06038102 RID: 229634 RVA: 0x00FABAF6 File Offset: 0x00FA9CF6
		public SolarSchoolSlotCell GetLastWeekCell(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.GetHistoryCell(1, weekday, slot);
		}

		// Token: 0x06038103 RID: 229635 RVA: 0x00FABB01 File Offset: 0x00FA9D01
		public int GetLastWeekBehaviorId(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.GetHistoryBehaviorId(1, weekday, slot);
		}

		// Token: 0x06038104 RID: 229636 RVA: 0x00FABB0C File Offset: 0x00FA9D0C
		public int CalcInstanceIdByDayIndex(int dayIndex)
		{
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			SolarSchoolCalendar? calendarDay = SolarSchoolConfig.Instance.GetCalendarDay(activityId, dayIndex);
			if (calendarDay == null)
			{
				return 1;
			}
			int instanceId = calendarDay.Value.InstanceId;
			if (instanceId != 0)
			{
				return instanceId;
			}
			return 1;
		}

		// Token: 0x06038105 RID: 229637 RVA: 0x00FABB54 File Offset: 0x00FA9D54
		public void SaveWeekInstanceIds(int mondayDayIndex)
		{
			for (int i = 1; i <= 5; i++)
			{
				this.CurWeekBoard.SetInstanceId(i, this.CalcInstanceIdByDayIndex(mondayDayIndex + i - 1));
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SolarSchool;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "[SolarSchool] 定格本周副本日";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mondayDayIndex", mondayDayIndex);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06038106 RID: 229638 RVA: 0x00FABBB4 File Offset: 0x00FA9DB4
		public void EnsureWeekInstanceIdsSaved(int mondayDayIndex)
		{
			for (int i = 1; i <= 5; i++)
			{
				if (this.CurWeekBoard.GetInstanceId(i) != 0)
				{
					return;
				}
			}
			this.SaveWeekInstanceIds(mondayDayIndex);
		}

		// Token: 0x06038107 RID: 229639 RVA: 0x00FABBE4 File Offset: 0x00FA9DE4
		public int GetWeekInstanceId(int weekOffset, int weekday)
		{
			if (weekday >= 1 && weekday <= 5)
			{
				if (weekOffset == 0)
				{
					return this.CurWeekBoard.GetInstanceId(weekday);
				}
				if (weekOffset < 0 && this.HasHistoryWeek(-weekOffset))
				{
					return this.HistoryWeeks[-weekOffset - 1].GetInstanceId(weekday);
				}
			}
			int dayIndex = SolarSchoolGamePlayModel.Instance.TimeData.CurrentMondayDayIndex + weekOffset * 7 + (weekday - 1);
			return this.CalcInstanceIdByDayIndex(dayIndex);
		}

		// Token: 0x06038108 RID: 229640 RVA: 0x00FABC4C File Offset: 0x00FA9E4C
		public bool IsNormalDay(int weekOffset, int weekday)
		{
			int weekInstanceId = this.GetWeekInstanceId(weekOffset, weekday);
			return weekInstanceId == 0 || weekInstanceId == 1;
		}

		// Token: 0x06038109 RID: 229641 RVA: 0x00FABC6C File Offset: 0x00FA9E6C
		public int GetInstanceIdByDayIndex(int dayIndex)
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			int mondayDayIndex = timeData.GetMondayDayIndex(dayIndex);
			int weekOffset = (mondayDayIndex - timeData.CurrentMondayDayIndex) / 7;
			return this.GetWeekInstanceId(weekOffset, dayIndex - mondayDayIndex + 1);
		}

		// Token: 0x0603810A RID: 229642 RVA: 0x00FABCA4 File Offset: 0x00FA9EA4
		public bool IsNormalDayByDayIndex(int dayIndex)
		{
			int instanceIdByDayIndex = this.GetInstanceIdByDayIndex(dayIndex);
			return instanceIdByDayIndex == 0 || instanceIdByDayIndex == 1;
		}

		// Token: 0x0603810B RID: 229643 RVA: 0x00FABCC2 File Offset: 0x00FA9EC2
		public bool IsSkippedDay(int weekOffset, int weekday)
		{
			if (weekOffset == 0)
			{
				return this.CurWeekBoard.IsSkippedDay(weekday);
			}
			return weekOffset < 0 && this.HasHistoryWeek(-weekOffset) && this.HistoryWeeks[-weekOffset - 1].IsSkippedDay(weekday);
		}

		// Token: 0x0603810C RID: 229644 RVA: 0x00FABCF9 File Offset: 0x00FA9EF9
		public SolarSchoolSlotCell GetCell(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.CurWeekBoard.GetCell(weekday, slot);
		}

		// Token: 0x0603810D RID: 229645 RVA: 0x00FABD08 File Offset: 0x00FA9F08
		public int GetScheduledBehaviorId(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.CurWeekBoard.GetScheduledBehaviorId(weekday, slot);
		}

		// Token: 0x0603810E RID: 229646 RVA: 0x00FABD17 File Offset: 0x00FA9F17
		public bool IsSlotScheduled(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.CurWeekBoard.IsSlotScheduled(weekday, slot);
		}

		// Token: 0x0603810F RID: 229647 RVA: 0x00FABD26 File Offset: 0x00FA9F26
		public ESolarSchoolBehaviorType? GetSlotBehaviorType(int weekday, ESolarSchoolTimeSlot slot)
		{
			return this.CurWeekBoard.GetSlotBehaviorType(weekday, slot);
		}

		// Token: 0x06038110 RID: 229648 RVA: 0x00FABD35 File Offset: 0x00FA9F35
		public bool HasPlayerScheduledBehavior()
		{
			return this.CurWeekBoard.HasPlayerScheduledBehavior();
		}

		// Token: 0x06038111 RID: 229649 RVA: 0x00FABD42 File Offset: 0x00FA9F42
		public void RecordSkippedDay(int dayIndex)
		{
			this.CurWeekBoard.SetSkippedDay(SolarSchoolUtils.GetWeekday(dayIndex), true);
		}

		// Token: 0x06038112 RID: 229650 RVA: 0x00FABD56 File Offset: 0x00FA9F56
		public void PrefillBehavior(int weekday, ESolarSchoolTimeSlot slot, int behaviorId)
		{
			this.CurWeekBoard.PrefillBehavior(weekday, slot, behaviorId);
		}

		// Token: 0x06038113 RID: 229651 RVA: 0x00FABD66 File Offset: 0x00FA9F66
		public void RecordExecutedBehavior(int weekday, ESolarSchoolTimeSlot slot, int behaviorId)
		{
			this.CurWeekBoard.RecordExecutedBehavior(weekday, slot, behaviorId);
		}

		// Token: 0x06038114 RID: 229652 RVA: 0x00FABD76 File Offset: 0x00FA9F76
		public bool SetNormalBehavior(int weekday, ESolarSchoolTimeSlot slot, int behaviorId)
		{
			return this.CurWeekBoard.SetNormalBehavior(weekday, slot, behaviorId);
		}

		// Token: 0x06038115 RID: 229653 RVA: 0x00FABD86 File Offset: 0x00FA9F86
		public bool SetSpecialBehavior(int specialBehaviorId, ESolarSchoolTimeSlot slot, int[] weekdays)
		{
			return this.CurWeekBoard.SetSpecialBehavior(specialBehaviorId, slot, weekdays, false);
		}

		// Token: 0x06038116 RID: 229654 RVA: 0x00FABD97 File Offset: 0x00FA9F97
		public bool RemoveSpecialBehavior(int specialBehaviorId)
		{
			return this.CurWeekBoard.RemoveSpecialBehavior(specialBehaviorId, false);
		}

		// Token: 0x06038117 RID: 229655 RVA: 0x00FABDA6 File Offset: 0x00FA9FA6
		public int ClearNormalFromNow()
		{
			return this.CurWeekBoard.ClearNormalFromNow();
		}

		// Token: 0x06038118 RID: 229656 RVA: 0x00FABDB4 File Offset: 0x00FA9FB4
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolScheduleDataPb solarSchoolScheduleDataPb = SolarSchoolScheduleDataPb.Create();
			foreach (SolarSchoolScheduleBoard board in this.HistoryWeeks)
			{
				solarSchoolScheduleDataPb.History.Add(this.SerializeBoard(board));
			}
			gameData.Schedule = solarSchoolScheduleDataPb;
		}

		// Token: 0x06038119 RID: 229657 RVA: 0x00FABE20 File Offset: 0x00FAA020
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.CurWeekBoard.Clear();
			this.HistoryWeeks.Clear();
			if (gameData.Schedule == null)
			{
				return;
			}
			foreach (SolarSchoolWeekSchedulePb weekPb in gameData.Schedule.History)
			{
				SolarSchoolScheduleBoard solarSchoolScheduleBoard = new SolarSchoolScheduleBoard();
				this.DeserializeBoard(weekPb, solarSchoolScheduleBoard);
				this.HistoryWeeks.Add(solarSchoolScheduleBoard);
			}
		}

		// Token: 0x0603811A RID: 229658 RVA: 0x00FABEA4 File Offset: 0x00FAA0A4
		private SolarSchoolWeekSchedulePb SerializeBoard(SolarSchoolScheduleBoard board)
		{
			SolarSchoolWeekSchedulePb solarSchoolWeekSchedulePb = SolarSchoolWeekSchedulePb.Create();
			for (int i = 1; i <= 5; i++)
			{
				foreach (ESolarSchoolTimeSlot slot in SolarSchoolScheduleData.SaveSlots)
				{
					SolarSchoolSlotCell cell = board.GetCell(i, slot);
					if (cell.BehaviorId != 0)
					{
						SolarSchoolSlotCellPb solarSchoolSlotCellPb = SolarSchoolSlotCellPb.Create();
						solarSchoolSlotCellPb.Weekday = i;
						solarSchoolSlotCellPb.Slot = (int)slot;
						solarSchoolSlotCellPb.BehaviorId = cell.BehaviorId;
						solarSchoolSlotCellPb.ReplacedLowBehaviorId = cell.ReplacedLowBehaviorId;
						solarSchoolSlotCellPb.FirstWeekday = cell.FirstWeekday;
						solarSchoolWeekSchedulePb.Cell.Add(solarSchoolSlotCellPb);
					}
				}
				solarSchoolWeekSchedulePb.InstanceId.Add(board.GetInstanceId(i));
				if (board.IsSkippedDay(i))
				{
					solarSchoolWeekSchedulePb.SkippedWeekday.Add(i);
				}
			}
			return solarSchoolWeekSchedulePb;
		}

		// Token: 0x0603811B RID: 229659 RVA: 0x00FABF8C File Offset: 0x00FAA18C
		private void DeserializeBoard(SolarSchoolWeekSchedulePb weekPb, SolarSchoolScheduleBoard board)
		{
			foreach (SolarSchoolSlotCellPb solarSchoolSlotCellPb in weekPb.Cell)
			{
				board.RestoreCell(solarSchoolSlotCellPb.Weekday, (ESolarSchoolTimeSlot)solarSchoolSlotCellPb.Slot, new SolarSchoolSlotCell
				{
					BehaviorId = solarSchoolSlotCellPb.BehaviorId,
					ReplacedLowBehaviorId = solarSchoolSlotCellPb.ReplacedLowBehaviorId,
					FirstWeekday = solarSchoolSlotCellPb.FirstWeekday
				});
			}
			int num = Math.Min(weekPb.InstanceId.Count, 5);
			for (int i = 0; i < num; i++)
			{
				board.SetInstanceId(i + 1, weekPb.InstanceId[i]);
			}
			foreach (int weekday in weekPb.SkippedWeekday)
			{
				board.SetSkippedDay(weekday, true);
			}
		}

		// Token: 0x0401D8BB RID: 121019
		private readonly SolarSchoolScheduleBoard CurWeekBoard = new SolarSchoolScheduleBoard();

		// Token: 0x0401D8BC RID: 121020
		private readonly List<SolarSchoolScheduleBoard> HistoryWeeks = new List<SolarSchoolScheduleBoard>();

		// Token: 0x0401D8BD RID: 121021
		private static readonly IReadOnlyList<ESolarSchoolTimeSlot> SaveSlots = new <>z__ReadOnlyArray<ESolarSchoolTimeSlot>(new ESolarSchoolTimeSlot[]
		{
			ESolarSchoolTimeSlot.Day,
			ESolarSchoolTimeSlot.Dusk
		});
	}
}
