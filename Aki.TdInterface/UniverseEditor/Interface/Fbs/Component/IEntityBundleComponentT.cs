using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200516C RID: 20844
	public class IEntityBundleComponentT
	{
		// Token: 0x1700980B RID: 38923
		// (get) Token: 0x06021A8E RID: 137870 RVA: 0x004ABC17 File Offset: 0x004A9E17
		// (set) Token: 0x06021A8F RID: 137871 RVA: 0x004ABC1F File Offset: 0x004A9E1F
		public bool Disabled { get; set; }

		// Token: 0x1700980C RID: 38924
		// (get) Token: 0x06021A90 RID: 137872 RVA: 0x004ABC28 File Offset: 0x004A9E28
		// (set) Token: 0x06021A91 RID: 137873 RVA: 0x004ABC30 File Offset: 0x004A9E30
		public int BundleId { get; set; }

		// Token: 0x1700980D RID: 38925
		// (get) Token: 0x06021A92 RID: 137874 RVA: 0x004ABC39 File Offset: 0x004A9E39
		// (set) Token: 0x06021A93 RID: 137875 RVA: 0x004ABC41 File Offset: 0x004A9E41
		public List<IEntityBundleChildInfoT> ChildInfos { get; set; }

		// Token: 0x1700980E RID: 38926
		// (get) Token: 0x06021A94 RID: 137876 RVA: 0x004ABC4A File Offset: 0x004A9E4A
		// (set) Token: 0x06021A95 RID: 137877 RVA: 0x004ABC52 File Offset: 0x004A9E52
		public byte NullMask { get; set; }

		// Token: 0x06021A96 RID: 137878 RVA: 0x004ABC5B File Offset: 0x004A9E5B
		public IEntityBundleComponentT()
		{
			this.Disabled = false;
			this.BundleId = 0;
			this.ChildInfos = null;
			this.NullMask = 0;
		}
	}
}
