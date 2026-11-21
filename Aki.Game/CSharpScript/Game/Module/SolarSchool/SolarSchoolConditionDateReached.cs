using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005896 RID: 22678
	public class SolarSchoolConditionDateReached : ActivityConditionBase
	{
		// Token: 0x17006B3C RID: 27452
		// (get) Token: 0x06037E03 RID: 228867 RVA: 0x00FA036B File Offset: 0x00F9E56B
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037E04 RID: 228868 RVA: 0x00FA036E File Offset: 0x00F9E56E
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.TargetDate = SolarSchoolUtils.ToMonthDay(p.GetInt("Month", 0), p.GetInt("Day", 0));
			this.IncludeSelf = p.GetBool("IncludeSelf", true);
			return true;
		}

		// Token: 0x06037E05 RID: 228869 RVA: 0x00FA03A8 File Offset: 0x00F9E5A8
		protected override bool OnCheck()
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			int num = SolarSchoolUtils.ToMonthDay(timeData.Month, timeData.Day);
			if (!this.IncludeSelf)
			{
				return num > this.TargetDate;
			}
			return num >= this.TargetDate;
		}

		// Token: 0x06037E06 RID: 228870 RVA: 0x00FA03F0 File Offset: 0x00F9E5F0
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037E07 RID: 228871 RVA: 0x00FA040E File Offset: 0x00F9E60E
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037E08 RID: 228872 RVA: 0x00FA042C File Offset: 0x00F9E62C
		protected override void OnClear()
		{
			this.TargetDate = 0;
			this.IncludeSelf = false;
		}

		// Token: 0x06037E09 RID: 228873 RVA: 0x00FA043C File Offset: 0x00F9E63C
		private void OnTimeChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x0401D7D1 RID: 120785
		private int TargetDate;

		// Token: 0x0401D7D2 RID: 120786
		private bool IncludeSelf;
	}
}
