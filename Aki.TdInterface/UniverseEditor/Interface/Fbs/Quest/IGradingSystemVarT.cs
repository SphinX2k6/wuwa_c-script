using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E82 RID: 16002
	public class IGradingSystemVarT
	{
		// Token: 0x17006F01 RID: 28417
		// (get) Token: 0x060168F0 RID: 92400 RVA: 0x003427F3 File Offset: 0x003409F3
		// (set) Token: 0x060168F1 RID: 92401 RVA: 0x003427FB File Offset: 0x003409FB
		public EGradingSystemVarType VarType { get; set; }

		// Token: 0x17006F02 RID: 28418
		// (get) Token: 0x060168F2 RID: 92402 RVA: 0x00342804 File Offset: 0x00340A04
		// (set) Token: 0x060168F3 RID: 92403 RVA: 0x0034280C File Offset: 0x00340A0C
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x060168F4 RID: 92404 RVA: 0x00342815 File Offset: 0x00340A15
		public IGradingSystemVarT()
		{
			this.VarType = EGradingSystemVarType.Score;
			this.VarRef = null;
		}
	}
}
