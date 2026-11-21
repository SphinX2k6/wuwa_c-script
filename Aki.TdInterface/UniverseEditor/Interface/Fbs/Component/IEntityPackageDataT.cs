using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570D RID: 22285
	public class IEntityPackageDataT
	{
		// Token: 0x1700A0AF RID: 41135
		// (get) Token: 0x06023CA9 RID: 146601 RVA: 0x004EB7EF File Offset: 0x004E99EF
		// (set) Token: 0x06023CAA RID: 146602 RVA: 0x004EB7F7 File Offset: 0x004E99F7
		public int PackagedLevelId { get; set; }

		// Token: 0x1700A0B0 RID: 41136
		// (get) Token: 0x06023CAB RID: 146603 RVA: 0x004EB800 File Offset: 0x004E9A00
		// (set) Token: 0x06023CAC RID: 146604 RVA: 0x004EB808 File Offset: 0x004E9A08
		public int PackageEntityId { get; set; }

		// Token: 0x1700A0B1 RID: 41137
		// (get) Token: 0x06023CAD RID: 146605 RVA: 0x004EB811 File Offset: 0x004E9A11
		// (set) Token: 0x06023CAE RID: 146606 RVA: 0x004EB819 File Offset: 0x004E9A19
		public List<IEntityPackageNodeT> PackageTree { get; set; }

		// Token: 0x1700A0B2 RID: 41138
		// (get) Token: 0x06023CAF RID: 146607 RVA: 0x004EB822 File Offset: 0x004E9A22
		// (set) Token: 0x06023CB0 RID: 146608 RVA: 0x004EB82A File Offset: 0x004E9A2A
		public byte NullMask { get; set; }

		// Token: 0x06023CB1 RID: 146609 RVA: 0x004EB833 File Offset: 0x004E9A33
		public IEntityPackageDataT()
		{
			this.PackagedLevelId = 0;
			this.PackageEntityId = 0;
			this.PackageTree = null;
			this.NullMask = 0;
		}
	}
}
