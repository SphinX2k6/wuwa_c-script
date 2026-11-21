using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079ED RID: 31213
	public class ISubScreenModeExitT
	{
		// Token: 0x1700E4CC RID: 58572
		// (get) Token: 0x06036FF2 RID: 225266 RVA: 0x0075A243 File Offset: 0x00758443
		// (set) Token: 0x06036FF3 RID: 225267 RVA: 0x0075A24B File Offset: 0x0075844B
		public ESubScreenOperationType Type { get; set; }

		// Token: 0x1700E4CD RID: 58573
		// (get) Token: 0x06036FF4 RID: 225268 RVA: 0x0075A254 File Offset: 0x00758454
		// (set) Token: 0x06036FF5 RID: 225269 RVA: 0x0075A25C File Offset: 0x0075845C
		public List<ISetSubScreenDataT> ExitConfigs { get; set; }

		// Token: 0x06036FF6 RID: 225270 RVA: 0x0075A265 File Offset: 0x00758465
		public ISubScreenModeExitT()
		{
			this.Type = ESubScreenOperationType.Init;
			this.ExitConfigs = null;
		}
	}
}
