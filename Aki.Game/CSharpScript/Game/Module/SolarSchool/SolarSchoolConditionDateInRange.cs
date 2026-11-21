using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.ActivityCondition;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005895 RID: 22677
	public class SolarSchoolConditionDateInRange : ActivityConditionBase
	{
		// Token: 0x17006B3B RID: 27451
		// (get) Token: 0x06037DFB RID: 228859 RVA: 0x00FA0250 File Offset: 0x00F9E450
		protected override bool CanListenInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06037DFC RID: 228860 RVA: 0x00FA0254 File Offset: 0x00F9E454
		[NullableContext(1)]
		protected override bool OnInitialize(ConditionParams p)
		{
			this.StartDate = SolarSchoolUtils.ToMonthDay(p.GetInt("StartMonth", 0), p.GetInt("StartDay", 0));
			this.EndDate = SolarSchoolUtils.ToMonthDay(p.GetInt("EndMonth", 0), p.GetInt("EndDay", 0));
			return true;
		}

		// Token: 0x06037DFD RID: 228861 RVA: 0x00FA02A8 File Offset: 0x00F9E4A8
		protected override bool OnCheck()
		{
			SolarSchoolTimeData timeData = SolarSchoolGamePlayModel.Instance.TimeData;
			int num = SolarSchoolUtils.ToMonthDay(timeData.Month, timeData.Day);
			if (this.StartDate > this.EndDate)
			{
				return num >= this.StartDate || num <= this.EndDate;
			}
			return num >= this.StartDate && num <= this.EndDate;
		}

		// Token: 0x06037DFE RID: 228862 RVA: 0x00FA030F File Offset: 0x00F9E50F
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037DFF RID: 228863 RVA: 0x00FA032D File Offset: 0x00F9E52D
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolTimeChanged, new Action(this.OnTimeChanged));
		}

		// Token: 0x06037E00 RID: 228864 RVA: 0x00FA034B File Offset: 0x00F9E54B
		protected override void OnClear()
		{
			this.StartDate = 0;
			this.EndDate = 0;
		}

		// Token: 0x06037E01 RID: 228865 RVA: 0x00FA035B File Offset: 0x00F9E55B
		private void OnTimeChanged()
		{
			base.FinishExecute();
		}

		// Token: 0x0401D7CF RID: 120783
		private int StartDate;

		// Token: 0x0401D7D0 RID: 120784
		private int EndDate;
	}
}
