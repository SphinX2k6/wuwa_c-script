using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F12 RID: 16146
	public class ILogicNodeOccupationT
	{
		// Token: 0x1700704B RID: 28747
		// (get) Token: 0x06016EB2 RID: 93874 RVA: 0x0034EDC1 File Offset: 0x0034CFC1
		// (set) Token: 0x06016EB3 RID: 93875 RVA: 0x0034EDC9 File Offset: 0x0034CFC9
		public List<string> Occupations { get; set; }

		// Token: 0x1700704C RID: 28748
		// (get) Token: 0x06016EB4 RID: 93876 RVA: 0x0034EDD2 File Offset: 0x0034CFD2
		// (set) Token: 0x06016EB5 RID: 93877 RVA: 0x0034EDDA File Offset: 0x0034CFDA
		public string TidDesc { get; set; }

		// Token: 0x1700704D RID: 28749
		// (get) Token: 0x06016EB6 RID: 93878 RVA: 0x0034EDE3 File Offset: 0x0034CFE3
		// (set) Token: 0x06016EB7 RID: 93879 RVA: 0x0034EDEB File Offset: 0x0034CFEB
		public List<IActionInfoT> ExitActions { get; set; }

		// Token: 0x1700704E RID: 28750
		// (get) Token: 0x06016EB8 RID: 93880 RVA: 0x0034EDF4 File Offset: 0x0034CFF4
		// (set) Token: 0x06016EB9 RID: 93881 RVA: 0x0034EDFC File Offset: 0x0034CFFC
		public List<IActionInfoT> ReenterActions { get; set; }

		// Token: 0x1700704F RID: 28751
		// (get) Token: 0x06016EBA RID: 93882 RVA: 0x0034EE05 File Offset: 0x0034D005
		// (set) Token: 0x06016EBB RID: 93883 RVA: 0x0034EE0D File Offset: 0x0034D00D
		public List<int> BanInteractEntities { get; set; }

		// Token: 0x17007050 RID: 28752
		// (get) Token: 0x06016EBC RID: 93884 RVA: 0x0034EE16 File Offset: 0x0034D016
		// (set) Token: 0x06016EBD RID: 93885 RVA: 0x0034EE1E File Offset: 0x0034D01E
		public bool ReclaimOccupationWhenEnter { get; set; }

		// Token: 0x17007051 RID: 28753
		// (get) Token: 0x06016EBE RID: 93886 RVA: 0x0034EE27 File Offset: 0x0034D027
		// (set) Token: 0x06016EBF RID: 93887 RVA: 0x0034EE2F File Offset: 0x0034D02F
		public byte NullMask { get; set; }

		// Token: 0x06016EC0 RID: 93888 RVA: 0x0034EE38 File Offset: 0x0034D038
		public ILogicNodeOccupationT()
		{
			this.Occupations = null;
			this.TidDesc = null;
			this.ExitActions = null;
			this.ReenterActions = null;
			this.BanInteractEntities = null;
			this.ReclaimOccupationWhenEnter = false;
			this.NullMask = 0;
		}
	}
}
