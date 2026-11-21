using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E5 RID: 21733
	public class ICircuitConnectLinkageGroupT
	{
		// Token: 0x17009B45 RID: 39749
		// (get) Token: 0x06022515 RID: 140565 RVA: 0x004BB1CB File Offset: 0x004B93CB
		// (set) Token: 0x06022516 RID: 140566 RVA: 0x004BB1D3 File Offset: 0x004B93D3
		public ETurntableConnectorDisk MainDisk { get; set; }

		// Token: 0x17009B46 RID: 39750
		// (get) Token: 0x06022517 RID: 140567 RVA: 0x004BB1DC File Offset: 0x004B93DC
		// (set) Token: 0x06022518 RID: 140568 RVA: 0x004BB1E4 File Offset: 0x004B93E4
		public List<ETurntableConnectorDisk> LinkedDisks { get; set; }

		// Token: 0x06022519 RID: 140569 RVA: 0x004BB1ED File Offset: 0x004B93ED
		public ICircuitConnectLinkageGroupT()
		{
			this.MainDisk = ETurntableConnectorDisk.Disk0;
			this.LinkedDisks = null;
		}
	}
}
