using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050B6 RID: 20662
	public class ICompareTimePeriodT
	{
		// Token: 0x1700940D RID: 37901
		// (get) Token: 0x060205B7 RID: 132535 RVA: 0x0047B1D6 File Offset: 0x004793D6
		// (set) Token: 0x060205B8 RID: 132536 RVA: 0x0047B1DE File Offset: 0x004793DE
		public ECondition Type { get; set; }

		// Token: 0x1700940E RID: 37902
		// (get) Token: 0x060205B9 RID: 132537 RVA: 0x0047B1E7 File Offset: 0x004793E7
		// (set) Token: 0x060205BA RID: 132538 RVA: 0x0047B1EF File Offset: 0x004793EF
		public ECompare Compare { get; set; }

		// Token: 0x1700940F RID: 37903
		// (get) Token: 0x060205BB RID: 132539 RVA: 0x0047B1F8 File Offset: 0x004793F8
		// (set) Token: 0x060205BC RID: 132540 RVA: 0x0047B200 File Offset: 0x00479400
		public ETimePeriod TimePeriod { get; set; }

		// Token: 0x060205BD RID: 132541 RVA: 0x0047B209 File Offset: 0x00479409
		public ICompareTimePeriodT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.TimePeriod = ETimePeriod.DayTime;
		}
	}
}
