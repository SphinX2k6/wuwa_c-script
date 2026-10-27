using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B09 RID: 15113
	public class IVarIntervalT
	{
		// Token: 0x170067B0 RID: 26544
		// (get) Token: 0x060149F7 RID: 84471 RVA: 0x00300B4B File Offset: 0x002FED4B
		// (set) Token: 0x060149F8 RID: 84472 RVA: 0x00300B53 File Offset: 0x002FED53
		public TVarRefUnion VarMin { get; set; }

		// Token: 0x170067B1 RID: 26545
		// (get) Token: 0x060149F9 RID: 84473 RVA: 0x00300B5C File Offset: 0x002FED5C
		// (set) Token: 0x060149FA RID: 84474 RVA: 0x00300B64 File Offset: 0x002FED64
		public TVarRefUnion VarMax { get; set; }

		// Token: 0x060149FB RID: 84475 RVA: 0x00300B6D File Offset: 0x002FED6D
		public IVarIntervalT()
		{
			this.VarMin = null;
			this.VarMax = null;
		}
	}
}
