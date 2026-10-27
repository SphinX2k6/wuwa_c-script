using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A9A RID: 15002
	public class IGlobalVarConfigsT
	{
		// Token: 0x170066C7 RID: 26311
		// (get) Token: 0x060145C8 RID: 83400 RVA: 0x002F8649 File Offset: 0x002F6849
		// (set) Token: 0x060145C9 RID: 83401 RVA: 0x002F8651 File Offset: 0x002F6851
		public List<IVarDefineT> Vars { get; set; }

		// Token: 0x060145CA RID: 83402 RVA: 0x002F865A File Offset: 0x002F685A
		public IGlobalVarConfigsT()
		{
			this.Vars = null;
		}
	}
}
