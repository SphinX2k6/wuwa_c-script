using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004413 RID: 17427
	public class IMainWpPartitionDataT
	{
		// Token: 0x17007AF3 RID: 31475
		// (get) Token: 0x06019F46 RID: 106310 RVA: 0x003B643D File Offset: 0x003B463D
		// (set) Token: 0x06019F47 RID: 106311 RVA: 0x003B6445 File Offset: 0x003B4645
		public List<ISubWpDataT> SubWpData { get; set; }

		// Token: 0x06019F48 RID: 106312 RVA: 0x003B644E File Offset: 0x003B464E
		public IMainWpPartitionDataT()
		{
			this.SubWpData = null;
		}
	}
}
