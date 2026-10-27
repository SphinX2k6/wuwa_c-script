using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A91 RID: 23185
	public class ITimeScheduleComponentT
	{
		// Token: 0x1700AEAA RID: 44714
		// (get) Token: 0x06027804 RID: 161796 RVA: 0x0056F5F9 File Offset: 0x0056D7F9
		// (set) Token: 0x06027805 RID: 161797 RVA: 0x0056F601 File Offset: 0x0056D801
		public bool Disabled { get; set; }

		// Token: 0x1700AEAB RID: 44715
		// (get) Token: 0x06027806 RID: 161798 RVA: 0x0056F60A File Offset: 0x0056D80A
		// (set) Token: 0x06027807 RID: 161799 RVA: 0x0056F612 File Offset: 0x0056D812
		public List<ITimeScheduleConfigT> TimeScheduleConfigs { get; set; }

		// Token: 0x1700AEAC RID: 44716
		// (get) Token: 0x06027808 RID: 161800 RVA: 0x0056F61B File Offset: 0x0056D81B
		// (set) Token: 0x06027809 RID: 161801 RVA: 0x0056F623 File Offset: 0x0056D823
		public byte NullMask { get; set; }

		// Token: 0x0602780A RID: 161802 RVA: 0x0056F62C File Offset: 0x0056D82C
		public ITimeScheduleComponentT()
		{
			this.Disabled = false;
			this.TimeScheduleConfigs = null;
			this.NullMask = 0;
		}
	}
}
