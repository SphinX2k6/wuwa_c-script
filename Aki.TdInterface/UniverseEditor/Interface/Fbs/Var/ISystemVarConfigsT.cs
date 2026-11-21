using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EDB RID: 16091
	public class ISystemVarConfigsT
	{
		// Token: 0x17006CEE RID: 27886
		// (get) Token: 0x06015CD1 RID: 89297 RVA: 0x00322D09 File Offset: 0x00320F09
		// (set) Token: 0x06015CD2 RID: 89298 RVA: 0x00322D11 File Offset: 0x00320F11
		public List<Record_ESystemModuleName_ISystemVarDefinesT> Vars { get; set; }

		// Token: 0x06015CD3 RID: 89299 RVA: 0x00322D1A File Offset: 0x00320F1A
		public ISystemVarConfigsT()
		{
			this.Vars = null;
		}
	}
}
