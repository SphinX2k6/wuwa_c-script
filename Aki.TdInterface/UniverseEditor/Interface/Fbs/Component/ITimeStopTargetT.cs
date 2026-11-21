using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C8 RID: 24776
	public class ITimeStopTargetT
	{
		// Token: 0x1700B82A RID: 47146
		// (get) Token: 0x06029EC8 RID: 171720 RVA: 0x005B8C67 File Offset: 0x005B6E67
		// (set) Token: 0x06029EC9 RID: 171721 RVA: 0x005B8C6F File Offset: 0x005B6E6F
		public List<int> EntityIds { get; set; }

		// Token: 0x1700B82B RID: 47147
		// (get) Token: 0x06029ECA RID: 171722 RVA: 0x005B8C78 File Offset: 0x005B6E78
		// (set) Token: 0x06029ECB RID: 171723 RVA: 0x005B8C80 File Offset: 0x005B6E80
		public IDynamicEntityMatchT EntityMatch { get; set; }

		// Token: 0x06029ECC RID: 171724 RVA: 0x005B8C89 File Offset: 0x005B6E89
		public ITimeStopTargetT()
		{
			this.EntityIds = null;
			this.EntityMatch = null;
		}
	}
}
