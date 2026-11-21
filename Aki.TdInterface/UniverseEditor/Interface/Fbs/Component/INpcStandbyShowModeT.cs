using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C04 RID: 23556
	public class INpcStandbyShowModeT
	{
		// Token: 0x1700AC6E RID: 44142
		// (get) Token: 0x06026EC6 RID: 159430 RVA: 0x0055411D File Offset: 0x0055231D
		// (set) Token: 0x06026EC7 RID: 159431 RVA: 0x00554125 File Offset: 0x00552325
		public ENpcStandbyShowMode Type { get; set; }

		// Token: 0x1700AC6F RID: 44143
		// (get) Token: 0x06026EC8 RID: 159432 RVA: 0x0055412E File Offset: 0x0055232E
		// (set) Token: 0x06026EC9 RID: 159433 RVA: 0x00554136 File Offset: 0x00552336
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x1700AC70 RID: 44144
		// (get) Token: 0x06026ECA RID: 159434 RVA: 0x0055413F File Offset: 0x0055233F
		// (set) Token: 0x06026ECB RID: 159435 RVA: 0x00554147 File Offset: 0x00552347
		public byte NullMask { get; set; }

		// Token: 0x06026ECC RID: 159436 RVA: 0x00554150 File Offset: 0x00552350
		public INpcStandbyShowModeT()
		{
			this.Type = ENpcStandbyShowMode.Finite;
			this.LookAtConfigs = null;
			this.NullMask = 0;
		}
	}
}
