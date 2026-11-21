using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054F4 RID: 21748
	public class ICircuitConnectStraightLayoutT
	{
		// Token: 0x17009B57 RID: 39767
		// (get) Token: 0x06022573 RID: 140659 RVA: 0x004BBA00 File Offset: 0x004B9C00
		// (set) Token: 0x06022574 RID: 140660 RVA: 0x004BBA08 File Offset: 0x004B9C08
		public ECircuitConnectElementType Type { get; set; }

		// Token: 0x17009B58 RID: 39768
		// (get) Token: 0x06022575 RID: 140661 RVA: 0x004BBA11 File Offset: 0x004B9C11
		// (set) Token: 0x06022576 RID: 140662 RVA: 0x004BBA19 File Offset: 0x004B9C19
		public ETurntableConnectorDisk Disk { get; set; }

		// Token: 0x06022577 RID: 140663 RVA: 0x004BBA22 File Offset: 0x004B9C22
		public ICircuitConnectStraightLayoutT()
		{
			this.Type = ECircuitConnectElementType.Straight;
			this.Disk = ETurntableConnectorDisk.Disk0;
		}
	}
}
