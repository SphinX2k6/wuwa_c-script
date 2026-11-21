using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060BC RID: 24764
	public class ITimeScheduleRefreshIntervalT
	{
		// Token: 0x1700B815 RID: 47125
		// (get) Token: 0x06029E68 RID: 171624 RVA: 0x005B81F4 File Offset: 0x005B63F4
		// (set) Token: 0x06029E69 RID: 171625 RVA: 0x005B81FC File Offset: 0x005B63FC
		public float MaxInterval { get; set; }

		// Token: 0x1700B816 RID: 47126
		// (get) Token: 0x06029E6A RID: 171626 RVA: 0x005B8205 File Offset: 0x005B6405
		// (set) Token: 0x06029E6B RID: 171627 RVA: 0x005B820D File Offset: 0x005B640D
		public float MinInterval { get; set; }

		// Token: 0x06029E6C RID: 171628 RVA: 0x005B8216 File Offset: 0x005B6416
		public ITimeScheduleRefreshIntervalT()
		{
			this.MaxInterval = 0f;
			this.MinInterval = 0f;
		}
	}
}
