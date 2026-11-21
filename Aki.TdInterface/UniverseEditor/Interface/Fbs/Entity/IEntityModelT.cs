using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C1A RID: 19482
	public class IEntityModelT
	{
		// Token: 0x17008A15 RID: 35349
		// (get) Token: 0x0601DD1C RID: 122140 RVA: 0x0042EBCA File Offset: 0x0042CDCA
		// (set) Token: 0x0601DD1D RID: 122141 RVA: 0x0042EBD2 File Offset: 0x0042CDD2
		public string BluePrintId { get; set; }

		// Token: 0x17008A16 RID: 35350
		// (get) Token: 0x0601DD1E RID: 122142 RVA: 0x0042EBDB File Offset: 0x0042CDDB
		// (set) Token: 0x0601DD1F RID: 122143 RVA: 0x0042EBE3 File Offset: 0x0042CDE3
		public string BluePrintClass { get; set; }

		// Token: 0x17008A17 RID: 35351
		// (get) Token: 0x0601DD20 RID: 122144 RVA: 0x0042EBEC File Offset: 0x0042CDEC
		// (set) Token: 0x0601DD21 RID: 122145 RVA: 0x0042EBF4 File Offset: 0x0042CDF4
		public string MeshPath { get; set; }

		// Token: 0x17008A18 RID: 35352
		// (get) Token: 0x0601DD22 RID: 122146 RVA: 0x0042EBFD File Offset: 0x0042CDFD
		// (set) Token: 0x0601DD23 RID: 122147 RVA: 0x0042EC05 File Offset: 0x0042CE05
		public string AnimPath { get; set; }

		// Token: 0x17008A19 RID: 35353
		// (get) Token: 0x0601DD24 RID: 122148 RVA: 0x0042EC0E File Offset: 0x0042CE0E
		// (set) Token: 0x0601DD25 RID: 122149 RVA: 0x0042EC16 File Offset: 0x0042CE16
		public List<string> Materials { get; set; }

		// Token: 0x0601DD26 RID: 122150 RVA: 0x0042EC1F File Offset: 0x0042CE1F
		public IEntityModelT()
		{
			this.BluePrintId = null;
			this.BluePrintClass = null;
			this.MeshPath = null;
			this.AnimPath = null;
			this.Materials = null;
		}
	}
}
