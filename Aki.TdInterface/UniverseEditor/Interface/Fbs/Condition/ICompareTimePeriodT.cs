using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BC9 RID: 19401
	public class ICompareTimePeriodT
	{
		// Token: 0x17008CE9 RID: 36073
		// (get) Token: 0x0601E9E9 RID: 125417 RVA: 0x004482CA File Offset: 0x004464CA
		// (set) Token: 0x0601E9EA RID: 125418 RVA: 0x004482D2 File Offset: 0x004464D2
		public ECondition Type { get; set; }

		// Token: 0x17008CEA RID: 36074
		// (get) Token: 0x0601E9EB RID: 125419 RVA: 0x004482DB File Offset: 0x004464DB
		// (set) Token: 0x0601E9EC RID: 125420 RVA: 0x004482E3 File Offset: 0x004464E3
		public ECompare Compare { get; set; }

		// Token: 0x17008CEB RID: 36075
		// (get) Token: 0x0601E9ED RID: 125421 RVA: 0x004482EC File Offset: 0x004464EC
		// (set) Token: 0x0601E9EE RID: 125422 RVA: 0x004482F4 File Offset: 0x004464F4
		public ETimePeriod TimePeriod { get; set; }

		// Token: 0x0601E9EF RID: 125423 RVA: 0x004482FD File Offset: 0x004464FD
		public ICompareTimePeriodT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.TimePeriod = ETimePeriod.DayTime;
		}
	}
}
