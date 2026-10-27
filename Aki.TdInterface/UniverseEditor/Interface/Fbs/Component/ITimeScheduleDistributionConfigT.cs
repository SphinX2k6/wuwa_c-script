using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A97 RID: 23191
	public class ITimeScheduleDistributionConfigT
	{
		// Token: 0x1700AEB8 RID: 44728
		// (get) Token: 0x06027842 RID: 161858 RVA: 0x0056FD5E File Offset: 0x0056DF5E
		// (set) Token: 0x06027843 RID: 161859 RVA: 0x0056FD66 File Offset: 0x0056DF66
		public ETimeScheduleDistributionType Type { get; set; }

		// Token: 0x06027844 RID: 161860 RVA: 0x0056FD6F File Offset: 0x0056DF6F
		public ITimeScheduleDistributionConfigT()
		{
			this.Type = ETimeScheduleDistributionType.RandomSchedulePosition;
		}
	}
}
