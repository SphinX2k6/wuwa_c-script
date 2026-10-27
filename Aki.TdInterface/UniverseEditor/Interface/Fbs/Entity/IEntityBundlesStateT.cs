using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004797 RID: 18327
	public class IEntityBundlesStateT
	{
		// Token: 0x17008383 RID: 33667
		// (get) Token: 0x0601C3F1 RID: 115697 RVA: 0x003FFD65 File Offset: 0x003FDF65
		// (set) Token: 0x0601C3F2 RID: 115698 RVA: 0x003FFD6D File Offset: 0x003FDF6D
		public List<IEntityStateT> Entities { get; set; }

		// Token: 0x17008384 RID: 33668
		// (get) Token: 0x0601C3F3 RID: 115699 RVA: 0x003FFD76 File Offset: 0x003FDF76
		// (set) Token: 0x0601C3F4 RID: 115700 RVA: 0x003FFD7E File Offset: 0x003FDF7E
		public int BundleId { get; set; }

		// Token: 0x17008385 RID: 33669
		// (get) Token: 0x0601C3F5 RID: 115701 RVA: 0x003FFD87 File Offset: 0x003FDF87
		// (set) Token: 0x0601C3F6 RID: 115702 RVA: 0x003FFD8F File Offset: 0x003FDF8F
		public byte NullMask { get; set; }

		// Token: 0x0601C3F7 RID: 115703 RVA: 0x003FFD98 File Offset: 0x003FDF98
		public IEntityBundlesStateT()
		{
			this.Entities = null;
			this.BundleId = 0;
			this.NullMask = 0;
		}
	}
}
