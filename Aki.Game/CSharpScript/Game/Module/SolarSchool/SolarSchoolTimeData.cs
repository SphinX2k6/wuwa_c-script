using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020058E6 RID: 22758
	public class SolarSchoolTimeData : SolarSchoolRecordBase
	{
		// Token: 0x17006BA1 RID: 27553
		// (get) Token: 0x060381A0 RID: 229792 RVA: 0x00FAE6BC File Offset: 0x00FAC8BC
		// (set) Token: 0x060381A1 RID: 229793 RVA: 0x00FAE6C4 File Offset: 0x00FAC8C4
		public int DayIndex { get; private set; } = 1;

		// Token: 0x17006BA2 RID: 27554
		// (get) Token: 0x060381A2 RID: 229794 RVA: 0x00FAE6CD File Offset: 0x00FAC8CD
		// (set) Token: 0x060381A3 RID: 229795 RVA: 0x00FAE6D5 File Offset: 0x00FAC8D5
		public ESolarSchoolTimeSlot CurrentSlot { get; private set; } = ESolarSchoolTimeSlot.Morning;

		// Token: 0x17006BA3 RID: 27555
		// (get) Token: 0x060381A4 RID: 229796 RVA: 0x00FAE6DE File Offset: 0x00FAC8DE
		// (set) Token: 0x060381A5 RID: 229797 RVA: 0x00FAE6E6 File Offset: 0x00FAC8E6
		public ESolarSchoolTimeSlot DisplaySlot { get; private set; } = ESolarSchoolTimeSlot.Morning;

		// Token: 0x17006BA4 RID: 27556
		// (get) Token: 0x060381A6 RID: 229798 RVA: 0x00FAE6EF File Offset: 0x00FAC8EF
		public ESolarSchoolMapTimePhase CurrentMapTimePhase
		{
			get
			{
				return SolarSchoolTimeData.GetMapTimePhase(this.CurrentSlot);
			}
		}

		// Token: 0x17006BA5 RID: 27557
		// (get) Token: 0x060381A7 RID: 229799 RVA: 0x00FAE6FC File Offset: 0x00FAC8FC
		public ESolarSchoolMapTimePhase DisplayMapTimePhase
		{
			get
			{
				return SolarSchoolTimeData.GetMapTimePhase(this.DisplaySlot);
			}
		}

		// Token: 0x060381A8 RID: 229800 RVA: 0x00FAE70C File Offset: 0x00FAC90C
		public static ESolarSchoolMapTimePhase GetMapTimePhase(ESolarSchoolTimeSlot slot)
		{
			if (SolarSchoolConfig.Instance.GetTimeSlot(slot) == null)
			{
				return ESolarSchoolMapTimePhase.Day;
			}
			SolarSchoolTimeSlot? solarSchoolTimeSlot;
			return (ESolarSchoolMapTimePhase)solarSchoolTimeSlot.GetValueOrDefault().MapTimePhase;
		}

		// Token: 0x060381A9 RID: 229801 RVA: 0x00FAE73F File Offset: 0x00FAC93F
		public static bool UseNightPic(ESolarSchoolTimeSlot slot)
		{
			return SolarSchoolTimeData.GetMapTimePhase(slot) == ESolarSchoolMapTimePhase.Dusk;
		}

		// Token: 0x060381AA RID: 229802 RVA: 0x00FAE74A File Offset: 0x00FAC94A
		public void Reset()
		{
			this.DayIndex = 1;
			this.CurrentSlot = ESolarSchoolTimeSlot.Morning;
			this.DisplaySlot = ESolarSchoolTimeSlot.Morning;
		}

		// Token: 0x060381AB RID: 229803 RVA: 0x00FAE761 File Offset: 0x00FAC961
		public void NextDay()
		{
			this.AdvanceDays(1);
		}

		// Token: 0x060381AC RID: 229804 RVA: 0x00FAE76C File Offset: 0x00FAC96C
		public void AdvanceDays(int days)
		{
			if (days <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.BB;
				string message = "[SolarSchool] 推进天数失败：days 必须大于 0";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("days", days);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.DayIndex += days;
			this.CurrentSlot = ESolarSchoolTimeSlot.Morning;
			this.DisplaySlot = ESolarSchoolTimeSlot.Morning;
			this.EmitTimeChanged();
		}

		// Token: 0x060381AD RID: 229805 RVA: 0x00FAE7CF File Offset: 0x00FAC9CF
		internal void SetSkippedDayEnd(int dayIndex)
		{
			this.DayIndex = dayIndex;
			this.CurrentSlot = ESolarSchoolTimeSlot.Night;
			this.DisplaySlot = ESolarSchoolTimeSlot.Night;
		}

		// Token: 0x060381AE RID: 229806 RVA: 0x00FAE7E6 File Offset: 0x00FAC9E6
		public void SetEndingDayIndex(int dayIndex)
		{
			if (this.DayIndex == dayIndex)
			{
				return;
			}
			this.DayIndex = dayIndex;
			this.CurrentSlot = ESolarSchoolTimeSlot.Morning;
			this.DisplaySlot = ESolarSchoolTimeSlot.Morning;
			this.EmitTimeChanged();
		}

		// Token: 0x060381AF RID: 229807 RVA: 0x00FAE80D File Offset: 0x00FACA0D
		[Conditional("DEBUG")]
		public void GMSetDayIndex(int dayIndex)
		{
		}

		// Token: 0x060381B0 RID: 229808 RVA: 0x00FAE810 File Offset: 0x00FACA10
		public void SetTimeSlot(ESolarSchoolTimeSlot slot, bool syncDisplay = true)
		{
			bool flag = false;
			if (syncDisplay && this.DisplaySlot != slot)
			{
				this.DisplaySlot = slot;
				flag = true;
			}
			if (this.CurrentSlot != slot)
			{
				this.CurrentSlot = slot;
				flag = true;
			}
			if (!flag)
			{
				return;
			}
			this.EmitTimeChanged();
		}

		// Token: 0x060381B1 RID: 229809 RVA: 0x00FAE850 File Offset: 0x00FACA50
		public void SyncDisplaySlot()
		{
			if (this.DisplaySlot == this.CurrentSlot)
			{
				return;
			}
			this.DisplaySlot = this.CurrentSlot;
			this.EmitTimeChanged();
		}

		// Token: 0x060381B2 RID: 229810 RVA: 0x00FAE874 File Offset: 0x00FACA74
		public void NextSlot()
		{
			IReadOnlyList<SolarSchoolTimeSlot> timeSlotListOrdered = SolarSchoolConfig.Instance.GetTimeSlotListOrdered(SolarSchoolGamePlayModel.Instance.ActivityId);
			for (int i = 0; i < timeSlotListOrdered.Count - 1; i++)
			{
				if (timeSlotListOrdered[i].Id == (int)this.CurrentSlot)
				{
					this.SetTimeSlot((ESolarSchoolTimeSlot)timeSlotListOrdered[i + 1].Id, true);
					return;
				}
			}
		}

		// Token: 0x060381B3 RID: 229811 RVA: 0x00FAE8DC File Offset: 0x00FACADC
		private unsafe void EmitTimeChanged()
		{
			if (this.IsEmittingTimeChanged)
			{
				this.HasPendingTimeChanged = true;
				return;
			}
			this.IsEmittingTimeChanged = true;
			try
			{
				int num = 1;
				for (;;)
				{
					this.HasPendingTimeChanged = false;
					EventSystem.Instance.Emit(EEventName.SolarSchoolTimeChanged);
					if (!this.HasPendingTimeChanged)
					{
						break;
					}
					if (num >= 8)
					{
						goto Block_5;
					}
					num++;
				}
				return;
				Block_5:
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SolarSchool;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[SolarSchool] TimeChanged 补发轮数超限，检查监听链是否每轮都在改时间";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("dayIndex", this.DayIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("currentSlot", this.CurrentSlot);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("displaySlot", this.DisplaySlot);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			finally
			{
				this.IsEmittingTimeChanged = false;
				this.HasPendingTimeChanged = false;
			}
		}

		// Token: 0x17006BA6 RID: 27558
		// (get) Token: 0x060381B4 RID: 229812 RVA: 0x00FAE9E4 File Offset: 0x00FACBE4
		private DateTime CurrentDate
		{
			get
			{
				return SolarSchoolUtils.GetDate(this.DayIndex);
			}
		}

		// Token: 0x17006BA7 RID: 27559
		// (get) Token: 0x060381B5 RID: 229813 RVA: 0x00FAE9F4 File Offset: 0x00FACBF4
		public int Month
		{
			get
			{
				return this.CurrentDate.Month;
			}
		}

		// Token: 0x17006BA8 RID: 27560
		// (get) Token: 0x060381B6 RID: 229814 RVA: 0x00FAEA10 File Offset: 0x00FACC10
		public int Day
		{
			get
			{
				return this.CurrentDate.Day;
			}
		}

		// Token: 0x17006BA9 RID: 27561
		// (get) Token: 0x060381B7 RID: 229815 RVA: 0x00FAEA2C File Offset: 0x00FACC2C
		public DayOfWeek DayOfWeek
		{
			get
			{
				return this.CurrentDate.DayOfWeek;
			}
		}

		// Token: 0x060381B8 RID: 229816 RVA: 0x00FAEA47 File Offset: 0x00FACC47
		public int GetWeekday(int dayIndex)
		{
			return SolarSchoolUtils.GetWeekday(dayIndex);
		}

		// Token: 0x17006BAA RID: 27562
		// (get) Token: 0x060381B9 RID: 229817 RVA: 0x00FAEA4F File Offset: 0x00FACC4F
		public int CurrentWeekday
		{
			get
			{
				return this.GetWeekday(this.DayIndex);
			}
		}

		// Token: 0x060381BA RID: 229818 RVA: 0x00FAEA5D File Offset: 0x00FACC5D
		public bool IsSlotAtOrAfterNow(int weekday, ESolarSchoolTimeSlot slot)
		{
			if (weekday != this.CurrentWeekday)
			{
				return weekday > this.CurrentWeekday;
			}
			return this.GetSlotOrder(slot) >= this.GetSlotOrder(this.CurrentSlot);
		}

		// Token: 0x060381BB RID: 229819 RVA: 0x00FAEA8C File Offset: 0x00FACC8C
		private int GetSlotOrder(ESolarSchoolTimeSlot slot)
		{
			if (SolarSchoolConfig.Instance.GetTimeSlot(slot) == null)
			{
				return (int)slot;
			}
			SolarSchoolTimeSlot? solarSchoolTimeSlot;
			return solarSchoolTimeSlot.GetValueOrDefault().Order;
		}

		// Token: 0x060381BC RID: 229820 RVA: 0x00FAEABF File Offset: 0x00FACCBF
		public int GetMondayDayIndex(int dayIndex)
		{
			return SolarSchoolUtils.GetMondayDayIndex(dayIndex);
		}

		// Token: 0x17006BAB RID: 27563
		// (get) Token: 0x060381BD RID: 229821 RVA: 0x00FAEAC7 File Offset: 0x00FACCC7
		public int CurrentMondayDayIndex
		{
			get
			{
				return this.GetMondayDayIndex(this.DayIndex);
			}
		}

		// Token: 0x060381BE RID: 229822 RVA: 0x00FAEAD5 File Offset: 0x00FACCD5
		public int GetCurrentWeek()
		{
			return this.GetWeek(this.DayIndex);
		}

		// Token: 0x060381BF RID: 229823 RVA: 0x00FAEAE4 File Offset: 0x00FACCE4
		public int GetWeek(int dayIndex)
		{
			int num = Math.Max(1, dayIndex);
			int firstMondayDayIndex = SolarSchoolUtils.GetFirstMondayDayIndex();
			if (num < firstMondayDayIndex)
			{
				return 1;
			}
			return (num - firstMondayDayIndex) / 7 + 2;
		}

		// Token: 0x060381C0 RID: 229824 RVA: 0x00FAEB0C File Offset: 0x00FACD0C
		[return: TupleElementNames(new string[]
		{
			"Month",
			"Day"
		})]
		public ValueTuple<int, int> GetMonthDay(int dayIndex)
		{
			return SolarSchoolUtils.GetMonthDay(dayIndex);
		}

		// Token: 0x060381C1 RID: 229825 RVA: 0x00FAEB14 File Offset: 0x00FACD14
		public ESolarSchoolDayType GetDayType()
		{
			return SolarSchoolUtils.GetDayType(this.DayIndex);
		}

		// Token: 0x060381C2 RID: 229826 RVA: 0x00FAEB21 File Offset: 0x00FACD21
		public bool IsWeekend()
		{
			return this.GetDayType() == ESolarSchoolDayType.Weekend;
		}

		// Token: 0x060381C3 RID: 229827 RVA: 0x00FAEB2C File Offset: 0x00FACD2C
		[NullableContext(1)]
		public override void Serialize(SolarSchoolSaveGamePb gameData)
		{
			SolarSchoolTimeDataPb solarSchoolTimeDataPb = SolarSchoolTimeDataPb.Create();
			solarSchoolTimeDataPb.DayIndex = this.DayIndex;
			gameData.Time = solarSchoolTimeDataPb;
		}

		// Token: 0x060381C4 RID: 229828 RVA: 0x00FAEB52 File Offset: 0x00FACD52
		[NullableContext(1)]
		public override void Deserialize(SolarSchoolSaveGamePb gameData)
		{
			this.Reset();
			if (gameData.Time == null)
			{
				return;
			}
			this.DayIndex = gameData.Time.DayIndex;
		}

		// Token: 0x0401D8E2 RID: 121058
		private const int MaxTimeChangedEmitRounds = 8;

		// Token: 0x0401D8E3 RID: 121059
		private bool IsEmittingTimeChanged;

		// Token: 0x0401D8E4 RID: 121060
		private bool HasPendingTimeChanged;
	}
}
