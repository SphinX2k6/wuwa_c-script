using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200609E RID: 24734
	public class ITimeScheduleComponentT
	{
		// Token: 0x1700B7E2 RID: 47074
		// (get) Token: 0x06029D7C RID: 171388 RVA: 0x005B6605 File Offset: 0x005B4805
		// (set) Token: 0x06029D7D RID: 171389 RVA: 0x005B660D File Offset: 0x005B480D
		public bool Disabled { get; set; }

		// Token: 0x1700B7E3 RID: 47075
		// (get) Token: 0x06029D7E RID: 171390 RVA: 0x005B6616 File Offset: 0x005B4816
		// (set) Token: 0x06029D7F RID: 171391 RVA: 0x005B661E File Offset: 0x005B481E
		public List<ITimeScheduleConfigT> TimeScheduleConfigs { get; set; }

		// Token: 0x1700B7E4 RID: 47076
		// (get) Token: 0x06029D80 RID: 171392 RVA: 0x005B6627 File Offset: 0x005B4827
		// (set) Token: 0x06029D81 RID: 171393 RVA: 0x005B662F File Offset: 0x005B482F
		public byte NullMask { get; set; }

		// Token: 0x06029D82 RID: 171394 RVA: 0x005B6638 File Offset: 0x005B4838
		public ITimeScheduleComponentT()
		{
			this.Disabled = false;
			this.TimeScheduleConfigs = null;
			this.NullMask = 0;
		}
	}
}
