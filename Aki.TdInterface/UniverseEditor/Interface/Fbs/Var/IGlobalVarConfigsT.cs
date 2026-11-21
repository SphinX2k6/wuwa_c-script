using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E9C RID: 16028
	public class IGlobalVarConfigsT
	{
		// Token: 0x17006C62 RID: 27746
		// (get) Token: 0x06015A6E RID: 88686 RVA: 0x0031E855 File Offset: 0x0031CA55
		// (set) Token: 0x06015A6F RID: 88687 RVA: 0x0031E85D File Offset: 0x0031CA5D
		public List<IVarDefineT> Vars { get; set; }

		// Token: 0x06015A70 RID: 88688 RVA: 0x0031E866 File Offset: 0x0031CA66
		public IGlobalVarConfigsT()
		{
			this.Vars = null;
		}
	}
}
