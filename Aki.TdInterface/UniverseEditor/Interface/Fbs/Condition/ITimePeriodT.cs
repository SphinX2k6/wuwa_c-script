using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051F4 RID: 20980
	public class ITimePeriodT
	{
		// Token: 0x17009632 RID: 38450
		// (get) Token: 0x060210AB RID: 135339 RVA: 0x00491026 File Offset: 0x0048F226
		// (set) Token: 0x060210AC RID: 135340 RVA: 0x0049102E File Offset: 0x0048F22E
		public EVisibleCondition Type { get; set; }

		// Token: 0x17009633 RID: 38451
		// (get) Token: 0x060210AD RID: 135341 RVA: 0x00491037 File Offset: 0x0048F237
		// (set) Token: 0x060210AE RID: 135342 RVA: 0x0049103F File Offset: 0x0048F23F
		public ECompare Compare { get; set; }

		// Token: 0x17009634 RID: 38452
		// (get) Token: 0x060210AF RID: 135343 RVA: 0x00491048 File Offset: 0x0048F248
		// (set) Token: 0x060210B0 RID: 135344 RVA: 0x00491050 File Offset: 0x0048F250
		public ETimePeriod TimePeriod { get; set; }

		// Token: 0x060210B1 RID: 135345 RVA: 0x00491059 File Offset: 0x0048F259
		public ITimePeriodT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.TimePeriod = ETimePeriod.DayTime;
		}
	}
}
