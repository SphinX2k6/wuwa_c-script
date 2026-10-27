using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AFD RID: 15101
	public class IVarBooleanValidateConfigT
	{
		// Token: 0x1700678B RID: 26507
		// (get) Token: 0x0601494F RID: 84303 RVA: 0x002FEFE6 File Offset: 0x002FD1E6
		// (set) Token: 0x06014950 RID: 84304 RVA: 0x002FEFEE File Offset: 0x002FD1EE
		public EVar Type { get; set; }

		// Token: 0x06014951 RID: 84305 RVA: 0x002FEFF7 File Offset: 0x002FD1F7
		public IVarBooleanValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
