using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004918 RID: 18712
	public class TCsvLoopTeleportDataT
	{
		// Token: 0x170087B6 RID: 34742
		// (get) Token: 0x0601D452 RID: 119890 RVA: 0x004210D5 File Offset: 0x0041F2D5
		// (set) Token: 0x0601D453 RID: 119891 RVA: 0x004210DD File Offset: 0x0041F2DD
		public int Id { get; set; }

		// Token: 0x170087B7 RID: 34743
		// (get) Token: 0x0601D454 RID: 119892 RVA: 0x004210E6 File Offset: 0x0041F2E6
		// (set) Token: 0x0601D455 RID: 119893 RVA: 0x004210EE File Offset: 0x0041F2EE
		public IConditionGroupT Conditions { get; set; }

		// Token: 0x170087B8 RID: 34744
		// (get) Token: 0x0601D456 RID: 119894 RVA: 0x004210F7 File Offset: 0x0041F2F7
		// (set) Token: 0x0601D457 RID: 119895 RVA: 0x004210FF File Offset: 0x0041F2FF
		public List<ILoopTeleportClientLogicItemBase_UnionUnion> ClientLogic { get; set; }

		// Token: 0x0601D458 RID: 119896 RVA: 0x00421108 File Offset: 0x0041F308
		public TCsvLoopTeleportDataT()
		{
			this.Id = 0;
			this.Conditions = null;
			this.ClientLogic = null;
		}
	}
}
