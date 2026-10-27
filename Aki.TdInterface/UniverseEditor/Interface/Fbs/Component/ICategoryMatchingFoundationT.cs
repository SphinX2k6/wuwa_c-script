using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F6B RID: 20331
	public class ICategoryMatchingFoundationT
	{
		// Token: 0x170092CF RID: 37583
		// (get) Token: 0x06020403 RID: 132099 RVA: 0x0047CDE7 File Offset: 0x0047AFE7
		// (set) Token: 0x06020404 RID: 132100 RVA: 0x0047CDEF File Offset: 0x0047AFEF
		public EItemFoundation Type { get; set; }

		// Token: 0x170092D0 RID: 37584
		// (get) Token: 0x06020405 RID: 132101 RVA: 0x0047CDF8 File Offset: 0x0047AFF8
		// (set) Token: 0x06020406 RID: 132102 RVA: 0x0047CE00 File Offset: 0x0047B000
		public int InitMatchEntity { get; set; }

		// Token: 0x170092D1 RID: 37585
		// (get) Token: 0x06020407 RID: 132103 RVA: 0x0047CE09 File Offset: 0x0047B009
		// (set) Token: 0x06020408 RID: 132104 RVA: 0x0047CE11 File Offset: 0x0047B011
		public List<ICategoryMatchingConfigT> MatchingConfigs { get; set; }

		// Token: 0x170092D2 RID: 37586
		// (get) Token: 0x06020409 RID: 132105 RVA: 0x0047CE1A File Offset: 0x0047B01A
		// (set) Token: 0x0602040A RID: 132106 RVA: 0x0047CE22 File Offset: 0x0047B022
		public byte NullMask { get; set; }

		// Token: 0x0602040B RID: 132107 RVA: 0x0047CE2B File Offset: 0x0047B02B
		public ICategoryMatchingFoundationT()
		{
			this.Type = EItemFoundation.CategoryMatching;
			this.InitMatchEntity = 0;
			this.MatchingConfigs = null;
			this.NullMask = 0;
		}
	}
}
