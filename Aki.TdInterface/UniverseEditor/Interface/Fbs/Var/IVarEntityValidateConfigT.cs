using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F05 RID: 16133
	public class IVarEntityValidateConfigT
	{
		// Token: 0x17006D3C RID: 27964
		// (get) Token: 0x06015E55 RID: 89685 RVA: 0x0032623E File Offset: 0x0032443E
		// (set) Token: 0x06015E56 RID: 89686 RVA: 0x00326246 File Offset: 0x00324446
		public EVar Type { get; set; }

		// Token: 0x06015E57 RID: 89687 RVA: 0x0032624F File Offset: 0x0032444F
		public IVarEntityValidateConfigT()
		{
			this.Type = EVar.Boolean;
		}
	}
}
