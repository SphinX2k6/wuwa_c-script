using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005890 RID: 22672
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolConditionAtLocation : ActivityConditionBase
	{
		// Token: 0x17006B36 RID: 27446
		// (get) Token: 0x06037DC8 RID: 228808 RVA: 0x00F9FA36 File Offset: 0x00F9DC36
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037DC9 RID: 228809 RVA: 0x00F9FA3C File Offset: 0x00F9DC3C
		protected unsafe override bool OnInitialize(ConditionParams p)
		{
			this.LocationIds = p.GetIntList("LocationIds").ToArray();
			bool flag = p.Has("StartMonth");
			bool flag2 = p.Has("StartDay");
			bool flag3 = p.Has("EndMonth");
			bool flag4 = p.Has("EndDay");
			this.HasDateRange = (flag || flag2 || flag3 || flag4);
			if (this.HasDateRange && (!flag || !flag2 || !flag3 || !flag4))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.ActivityCondition;
				ELogAuthor author = ELogAuthor.LRC;
				string message = "[ActivityCondition] 第二索拉当前所处地点的日期范围参数不完整";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("startMonth", p.GetString("StartMonth", ""));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("startDay", p.GetString("StartDay", ""));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("endMonth", p.GetString("EndMonth", ""));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("endDay", p.GetString("EndDay", ""));
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return false;
			}
			if (this.HasDateRange)
			{
				this.StartDate = SolarSchoolUtils.ToMonthDay(p.GetInt("StartMonth", 0), p.GetInt("StartDay", 0));
				this.EndDate = SolarSchoolUtils.ToMonthDay(p.GetInt("EndMonth", 0), p.GetInt("EndDay", 0));
			}
			this.TimeSlots = p.GetIntList("TimeSlots").ToArray();
			return true;
		}

		// Token: 0x06037DCA RID: 228810 RVA: 0x00F9FBDC File Offset: 0x00F9DDDC
		protected override bool OnCheck()
		{
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			int currentLocationId = instance.MapData.CurrentLocationId;
			bool flag = false;
			int[] locationIds = this.LocationIds;
			for (int i = 0; i < locationIds.Length; i++)
			{
				if (locationIds[i] == currentLocationId)
				{
					flag = true;
					break;
				}
			}
			if (!flag || !this.MatchesDateRange(instance.TimeData.Month, instance.TimeData.Day))
			{
				return false;
			}
			int currentSlot = (int)instance.TimeData.CurrentSlot;
			return this.TimeSlots.Length == 0 || Array.IndexOf<int>(this.TimeSlots, 0) >= 0 || Array.IndexOf<int>(this.TimeSlots, currentSlot) >= 0;
		}

		// Token: 0x06037DCB RID: 228811 RVA: 0x00F9FC7F File Offset: 0x00F9DE7F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolLocationChanged, new Action<int>(this.OnLocationChanged));
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037DCC RID: 228812 RVA: 0x00F9FCB9 File Offset: 0x00F9DEB9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolLocationChanged, new Action<int>(this.OnLocationChanged));
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037DCD RID: 228813 RVA: 0x00F9FCF3 File Offset: 0x00F9DEF3
		protected override void OnClear()
		{
			this.LocationIds = Array.Empty<int>();
			this.StartDate = 0;
			this.EndDate = 0;
			this.HasDateRange = false;
			this.TimeSlots = Array.Empty<int>();
		}

		// Token: 0x06037DCE RID: 228814 RVA: 0x00F9FD20 File Offset: 0x00F9DF20
		private void OnLocationChanged(int locationId)
		{
			base.FinishExecute();
		}

		// Token: 0x06037DCF RID: 228815 RVA: 0x00F9FD28 File Offset: 0x00F9DF28
		private void OnTimeChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x06037DD0 RID: 228816 RVA: 0x00F9FD30 File Offset: 0x00F9DF30
		private bool MatchesDateRange(int month, int day)
		{
			if (!this.HasDateRange)
			{
				return true;
			}
			int num = SolarSchoolUtils.ToMonthDay(month, day);
			if (this.StartDate > this.EndDate)
			{
				return num >= this.StartDate || num <= this.EndDate;
			}
			return num >= this.StartDate && num <= this.EndDate;
		}

		// Token: 0x0401D7BD RID: 120765
		private int[] LocationIds = Array.Empty<int>();

		// Token: 0x0401D7BE RID: 120766
		private int StartDate;

		// Token: 0x0401D7BF RID: 120767
		private int EndDate;

		// Token: 0x0401D7C0 RID: 120768
		private bool HasDateRange;

		// Token: 0x0401D7C1 RID: 120769
		private int[] TimeSlots = Array.Empty<int>();
	}
}
