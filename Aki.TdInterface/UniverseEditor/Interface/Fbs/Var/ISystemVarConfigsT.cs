using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD9 RID: 15065
	public class ISystemVarConfigsT
	{
		// Token: 0x17006753 RID: 26451
		// (get) Token: 0x06014827 RID: 84007 RVA: 0x002FCA79 File Offset: 0x002FAC79
		// (set) Token: 0x06014828 RID: 84008 RVA: 0x002FCA81 File Offset: 0x002FAC81
		public List<Record_ESystemModuleName_ISystemVarDefinesT> Vars { get; set; }

		// Token: 0x06014829 RID: 84009 RVA: 0x002FCA8A File Offset: 0x002FAC8A
		public ISystemVarConfigsT()
		{
			this.Vars = null;
		}
	}
}
