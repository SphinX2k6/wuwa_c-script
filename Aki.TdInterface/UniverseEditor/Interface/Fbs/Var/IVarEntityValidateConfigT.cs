using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B03 RID: 15107
	public class IVarEntityValidateConfigT
	{
		// Token: 0x170067A1 RID: 26529
		// (get) Token: 0x060149AB RID: 84395 RVA: 0x002FFFAE File Offset: 0x002FE1AE
		// (set) Token: 0x060149AC RID: 84396 RVA: 0x002FFFB6 File Offset: 0x002FE1B6
		public EVar Type { get; set; }

		// Token: 0x060149AD RID: 84397 RVA: 0x002FFFBF File Offset: 0x002FE1BF
		public IVarEntityValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
