using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D1 RID: 22225
	public class IEntityBundleComponentT
	{
		// Token: 0x17009FF8 RID: 40952
		// (get) Token: 0x060239E2 RID: 145890 RVA: 0x004E5BA3 File Offset: 0x004E3DA3
		// (set) Token: 0x060239E3 RID: 145891 RVA: 0x004E5BAB File Offset: 0x004E3DAB
		public bool Disabled { get; set; }

		// Token: 0x17009FF9 RID: 40953
		// (get) Token: 0x060239E4 RID: 145892 RVA: 0x004E5BB4 File Offset: 0x004E3DB4
		// (set) Token: 0x060239E5 RID: 145893 RVA: 0x004E5BBC File Offset: 0x004E3DBC
		public int BundleId { get; set; }

		// Token: 0x17009FFA RID: 40954
		// (get) Token: 0x060239E6 RID: 145894 RVA: 0x004E5BC5 File Offset: 0x004E3DC5
		// (set) Token: 0x060239E7 RID: 145895 RVA: 0x004E5BCD File Offset: 0x004E3DCD
		public List<IEntityBundleChildInfoT> ChildInfos { get; set; }

		// Token: 0x17009FFB RID: 40955
		// (get) Token: 0x060239E8 RID: 145896 RVA: 0x004E5BD6 File Offset: 0x004E3DD6
		// (set) Token: 0x060239E9 RID: 145897 RVA: 0x004E5BDE File Offset: 0x004E3DDE
		public byte NullMask { get; set; }

		// Token: 0x060239EA RID: 145898 RVA: 0x004E5BE7 File Offset: 0x004E3DE7
		public IEntityBundleComponentT()
		{
			this.Disabled = false;
			this.BundleId = 0;
			this.ChildInfos = null;
			this.NullMask = 0;
		}
	}
}
