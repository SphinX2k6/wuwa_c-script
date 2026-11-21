using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B73 RID: 31603
	public class ITeleportToLatestResetPointT
	{
		// Token: 0x1700ECA1 RID: 60577
		// (get) Token: 0x06038EB6 RID: 233142 RVA: 0x007B1CBD File Offset: 0x007AFEBD
		// (set) Token: 0x06038EB7 RID: 233143 RVA: 0x007B1CC5 File Offset: 0x007AFEC5
		public ITeleportToLatestResetPointDirectlyT Option { get; set; }

		// Token: 0x06038EB8 RID: 233144 RVA: 0x007B1CCE File Offset: 0x007AFECE
		public ITeleportToLatestResetPointT()
		{
			this.Option = null;
		}
	}
}
