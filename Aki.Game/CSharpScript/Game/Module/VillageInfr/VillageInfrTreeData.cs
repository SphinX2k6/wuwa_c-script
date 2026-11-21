using System;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02003806 RID: 14342
	public class VillageInfrTreeData : IVillageInfrTreeData
	{
		// Token: 0x17004C9B RID: 19611
		// (get) Token: 0x060254A1 RID: 152737 RVA: 0x00A83DD9 File Offset: 0x00A81FD9
		// (set) Token: 0x060254A2 RID: 152738 RVA: 0x00A83DE1 File Offset: 0x00A81FE1
		public int Id { get; set; }

		// Token: 0x17004C9C RID: 19612
		// (get) Token: 0x060254A3 RID: 152739 RVA: 0x00A83DEA File Offset: 0x00A81FEA
		// (set) Token: 0x060254A4 RID: 152740 RVA: 0x00A83DF2 File Offset: 0x00A81FF2
		public InfrV2StatusPb Status { get; set; }

		// Token: 0x17004C9D RID: 19613
		// (get) Token: 0x060254A5 RID: 152741 RVA: 0x00A83DFB File Offset: 0x00A81FFB
		// (set) Token: 0x060254A6 RID: 152742 RVA: 0x00A83E03 File Offset: 0x00A82003
		public long CompleteTime { get; set; }
	}
}
