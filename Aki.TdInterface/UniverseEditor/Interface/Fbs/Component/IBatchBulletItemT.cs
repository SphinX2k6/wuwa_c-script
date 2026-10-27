using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EFC RID: 20220
	public class IBatchBulletItemT
	{
		// Token: 0x17009180 RID: 37248
		// (get) Token: 0x0601FF1A RID: 130842 RVA: 0x004722E3 File Offset: 0x004704E3
		// (set) Token: 0x0601FF1B RID: 130843 RVA: 0x004722EB File Offset: 0x004704EB
		public int Time { get; set; }

		// Token: 0x17009181 RID: 37249
		// (get) Token: 0x0601FF1C RID: 130844 RVA: 0x004722F4 File Offset: 0x004704F4
		// (set) Token: 0x0601FF1D RID: 130845 RVA: 0x004722FC File Offset: 0x004704FC
		public List<IBatchBulletCasterT> CasterList { get; set; }

		// Token: 0x0601FF1E RID: 130846 RVA: 0x00472305 File Offset: 0x00470505
		public IBatchBulletItemT()
		{
			this.Time = 0;
			this.CasterList = null;
		}
	}
}
