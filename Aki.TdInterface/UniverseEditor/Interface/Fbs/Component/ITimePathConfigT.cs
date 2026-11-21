using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006093 RID: 24723
	public class ITimePathConfigT
	{
		// Token: 0x1700B7C1 RID: 47041
		// (get) Token: 0x06029D05 RID: 171269 RVA: 0x005B5587 File Offset: 0x005B3787
		// (set) Token: 0x06029D06 RID: 171270 RVA: 0x005B558F File Offset: 0x005B378F
		public float TotalTime { get; set; }

		// Token: 0x1700B7C2 RID: 47042
		// (get) Token: 0x06029D07 RID: 171271 RVA: 0x005B5598 File Offset: 0x005B3798
		// (set) Token: 0x06029D08 RID: 171272 RVA: 0x005B55A0 File Offset: 0x005B37A0
		public string TimePathCurve { get; set; }

		// Token: 0x06029D09 RID: 171273 RVA: 0x005B55A9 File Offset: 0x005B37A9
		public ITimePathConfigT()
		{
			this.TotalTime = 0f;
			this.TimePathCurve = null;
		}
	}
}
