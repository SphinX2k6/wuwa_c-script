using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E10 RID: 24080
	public class INightmareSettlementSystemVarT
	{
		// Token: 0x1700B430 RID: 46128
		// (get) Token: 0x060293A8 RID: 168872 RVA: 0x005A7ECB File Offset: 0x005A60CB
		// (set) Token: 0x060293A9 RID: 168873 RVA: 0x005A7ED3 File Offset: 0x005A60D3
		public ENightmareSettlementSystemVarType VarType { get; set; }

		// Token: 0x1700B431 RID: 46129
		// (get) Token: 0x060293AA RID: 168874 RVA: 0x005A7EDC File Offset: 0x005A60DC
		// (set) Token: 0x060293AB RID: 168875 RVA: 0x005A7EE4 File Offset: 0x005A60E4
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x060293AC RID: 168876 RVA: 0x005A7EED File Offset: 0x005A60ED
		public INightmareSettlementSystemVarT()
		{
			this.VarType = ENightmareSettlementSystemVarType.MonsterKilled;
			this.VarRef = null;
		}
	}
}
