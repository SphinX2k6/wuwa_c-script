using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B21 RID: 15137
	public class IVarValidateConfigT
	{
		// Token: 0x170067D7 RID: 26583
		// (get) Token: 0x06014AB3 RID: 84659 RVA: 0x00301DC2 File Offset: 0x002FFFC2
		// (set) Token: 0x06014AB4 RID: 84660 RVA: 0x00301DCA File Offset: 0x002FFFCA
		public EVar Type { get; set; }

		// Token: 0x06014AB5 RID: 84661 RVA: 0x00301DD3 File Offset: 0x002FFFD3
		public IVarValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
