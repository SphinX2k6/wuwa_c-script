using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200472B RID: 18219
	public class ICameraFlowTemplateConfigT
	{
		// Token: 0x17008294 RID: 33428
		// (get) Token: 0x0601BFEF RID: 114671 RVA: 0x003F7A6D File Offset: 0x003F5C6D
		// (set) Token: 0x0601BFF0 RID: 114672 RVA: 0x003F7A75 File Offset: 0x003F5C75
		public List<ICameraTemplateT> List { get; set; }

		// Token: 0x0601BFF1 RID: 114673 RVA: 0x003F7A7E File Offset: 0x003F5C7E
		public ICameraFlowTemplateConfigT()
		{
			this.List = null;
		}
	}
}
