using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A8 RID: 20904
	public class IEntityPackageDataT
	{
		// Token: 0x170098C0 RID: 39104
		// (get) Token: 0x06021D51 RID: 138577 RVA: 0x004B1787 File Offset: 0x004AF987
		// (set) Token: 0x06021D52 RID: 138578 RVA: 0x004B178F File Offset: 0x004AF98F
		public int PackagedLevelId { get; set; }

		// Token: 0x170098C1 RID: 39105
		// (get) Token: 0x06021D53 RID: 138579 RVA: 0x004B1798 File Offset: 0x004AF998
		// (set) Token: 0x06021D54 RID: 138580 RVA: 0x004B17A0 File Offset: 0x004AF9A0
		public int PackageEntityId { get; set; }

		// Token: 0x170098C2 RID: 39106
		// (get) Token: 0x06021D55 RID: 138581 RVA: 0x004B17A9 File Offset: 0x004AF9A9
		// (set) Token: 0x06021D56 RID: 138582 RVA: 0x004B17B1 File Offset: 0x004AF9B1
		public List<IEntityPackageNodeT> PackageTree { get; set; }

		// Token: 0x170098C3 RID: 39107
		// (get) Token: 0x06021D57 RID: 138583 RVA: 0x004B17BA File Offset: 0x004AF9BA
		// (set) Token: 0x06021D58 RID: 138584 RVA: 0x004B17C2 File Offset: 0x004AF9C2
		public byte NullMask { get; set; }

		// Token: 0x06021D59 RID: 138585 RVA: 0x004B17CB File Offset: 0x004AF9CB
		public IEntityPackageDataT()
		{
			this.PackagedLevelId = 0;
			this.PackageEntityId = 0;
			this.PackageTree = null;
			this.NullMask = 0;
		}
	}
}
