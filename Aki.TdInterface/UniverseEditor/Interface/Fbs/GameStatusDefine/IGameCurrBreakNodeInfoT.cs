using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B5A RID: 19290
	public class IGameCurrBreakNodeInfoT
	{
		// Token: 0x17008818 RID: 34840
		// (get) Token: 0x0601D49E RID: 119966 RVA: 0x0041CFC1 File Offset: 0x0041B1C1
		// (set) Token: 0x0601D49F RID: 119967 RVA: 0x0041CFC9 File Offset: 0x0041B1C9
		public int Id { get; set; }

		// Token: 0x17008819 RID: 34841
		// (get) Token: 0x0601D4A0 RID: 119968 RVA: 0x0041CFD2 File Offset: 0x0041B1D2
		// (set) Token: 0x0601D4A1 RID: 119969 RVA: 0x0041CFDA File Offset: 0x0041B1DA
		public ENodeBreakMoment BreakMoment { get; set; }

		// Token: 0x1700881A RID: 34842
		// (get) Token: 0x0601D4A2 RID: 119970 RVA: 0x0041CFE3 File Offset: 0x0041B1E3
		// (set) Token: 0x0601D4A3 RID: 119971 RVA: 0x0041CFEB File Offset: 0x0041B1EB
		public List<IGameCurrBreakNodeInfo_RefVarsT> RefVars { get; set; }

		// Token: 0x0601D4A4 RID: 119972 RVA: 0x0041CFF4 File Offset: 0x0041B1F4
		public IGameCurrBreakNodeInfoT()
		{
			this.Id = 0;
			this.BreakMoment = ENodeBreakMoment.Null;
			this.RefVars = null;
		}
	}
}
