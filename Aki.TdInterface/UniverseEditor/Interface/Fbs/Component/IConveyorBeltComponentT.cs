using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558A RID: 21898
	public class IConveyorBeltComponentT
	{
		// Token: 0x17009CD9 RID: 40153
		// (get) Token: 0x06022D45 RID: 142661 RVA: 0x004CC5F5 File Offset: 0x004CA7F5
		// (set) Token: 0x06022D46 RID: 142662 RVA: 0x004CC5FD File Offset: 0x004CA7FD
		public bool Disabled { get; set; }

		// Token: 0x17009CDA RID: 40154
		// (get) Token: 0x06022D47 RID: 142663 RVA: 0x004CC606 File Offset: 0x004CA806
		// (set) Token: 0x06022D48 RID: 142664 RVA: 0x004CC60E File Offset: 0x004CA80E
		public List<IConveyorBeltStateT> StateGroups { get; set; }

		// Token: 0x17009CDB RID: 40155
		// (get) Token: 0x06022D49 RID: 142665 RVA: 0x004CC617 File Offset: 0x004CA817
		// (set) Token: 0x06022D4A RID: 142666 RVA: 0x004CC61F File Offset: 0x004CA81F
		public byte NullMask { get; set; }

		// Token: 0x06022D4B RID: 142667 RVA: 0x004CC628 File Offset: 0x004CA828
		public IConveyorBeltComponentT()
		{
			this.Disabled = false;
			this.StateGroups = null;
			this.NullMask = 0;
		}
	}
}
