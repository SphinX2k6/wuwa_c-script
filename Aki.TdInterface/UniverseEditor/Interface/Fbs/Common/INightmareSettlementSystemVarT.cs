using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200644D RID: 25677
	public class INightmareSettlementSystemVarT
	{
		// Token: 0x1700BD96 RID: 48534
		// (get) Token: 0x0602BA32 RID: 178738 RVA: 0x005F0BFB File Offset: 0x005EEDFB
		// (set) Token: 0x0602BA33 RID: 178739 RVA: 0x005F0C03 File Offset: 0x005EEE03
		public ENightmareSettlementSystemVarType VarType { get; set; }

		// Token: 0x1700BD97 RID: 48535
		// (get) Token: 0x0602BA34 RID: 178740 RVA: 0x005F0C0C File Offset: 0x005EEE0C
		// (set) Token: 0x0602BA35 RID: 178741 RVA: 0x005F0C14 File Offset: 0x005EEE14
		public TVarRefUnion VarRef { get; set; }

		// Token: 0x0602BA36 RID: 178742 RVA: 0x005F0C1D File Offset: 0x005EEE1D
		public INightmareSettlementSystemVarT()
		{
			this.VarType = ENightmareSettlementSystemVarType.MonsterKilled;
			this.VarRef = null;
		}
	}
}
