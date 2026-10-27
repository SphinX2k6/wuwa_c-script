using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200488F RID: 18575
	public class VillageInfrTreeData : IVillageInfrTreeData
	{
		// Token: 0x17007933 RID: 31027
		// (get) Token: 0x06030975 RID: 199029 RVA: 0x00B48FD1 File Offset: 0x00B471D1
		// (set) Token: 0x06030976 RID: 199030 RVA: 0x00B48FD9 File Offset: 0x00B471D9
		public int Id { get; set; }

		// Token: 0x17007934 RID: 31028
		// (get) Token: 0x06030977 RID: 199031 RVA: 0x00B48FE2 File Offset: 0x00B471E2
		// (set) Token: 0x06030978 RID: 199032 RVA: 0x00B48FEA File Offset: 0x00B471EA
		public InfrV2StatusPb Status { get; set; }

		// Token: 0x17007935 RID: 31029
		// (get) Token: 0x06030979 RID: 199033 RVA: 0x00B48FF3 File Offset: 0x00B471F3
		// (set) Token: 0x0603097A RID: 199034 RVA: 0x00B48FFB File Offset: 0x00B471FB
		public long CompleteTime { get; set; }
	}
}
