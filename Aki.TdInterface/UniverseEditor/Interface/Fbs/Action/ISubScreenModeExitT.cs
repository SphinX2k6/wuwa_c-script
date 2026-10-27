using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007218 RID: 29208
	public class ISubScreenModeExitT
	{
		// Token: 0x1700D8D3 RID: 55507
		// (get) Token: 0x06033CF0 RID: 212208 RVA: 0x006F8EE3 File Offset: 0x006F70E3
		// (set) Token: 0x06033CF1 RID: 212209 RVA: 0x006F8EEB File Offset: 0x006F70EB
		public ESubScreenOperationType Type { get; set; }

		// Token: 0x1700D8D4 RID: 55508
		// (get) Token: 0x06033CF2 RID: 212210 RVA: 0x006F8EF4 File Offset: 0x006F70F4
		// (set) Token: 0x06033CF3 RID: 212211 RVA: 0x006F8EFC File Offset: 0x006F70FC
		public List<ISetSubScreenDataT> ExitConfigs { get; set; }

		// Token: 0x06033CF4 RID: 212212 RVA: 0x006F8F05 File Offset: 0x006F7105
		public ISubScreenModeExitT()
		{
			this.Type = ESubScreenOperationType.Init;
			this.ExitConfigs = null;
		}
	}
}
