using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE2 RID: 23266
	public class ITriggerCountConfigT
	{
		// Token: 0x1700AF70 RID: 44912
		// (get) Token: 0x06027B32 RID: 162610 RVA: 0x005760B0 File Offset: 0x005742B0
		// (set) Token: 0x06027B33 RID: 162611 RVA: 0x005760B8 File Offset: 0x005742B8
		public int TriggerCount { get; set; }

		// Token: 0x1700AF71 RID: 44913
		// (get) Token: 0x06027B34 RID: 162612 RVA: 0x005760C1 File Offset: 0x005742C1
		// (set) Token: 0x06027B35 RID: 162613 RVA: 0x005760C9 File Offset: 0x005742C9
		public float TriggerInterval { get; set; }

		// Token: 0x06027B36 RID: 162614 RVA: 0x005760D2 File Offset: 0x005742D2
		public ITriggerCountConfigT()
		{
			this.TriggerCount = 0;
			this.TriggerInterval = 0f;
		}
	}
}
