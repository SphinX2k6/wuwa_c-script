using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004B93 RID: 19347
	public class ICameraFlowTemplateConfigT
	{
		// Token: 0x170088D5 RID: 35029
		// (get) Token: 0x0601D7C4 RID: 120772 RVA: 0x00423D09 File Offset: 0x00421F09
		// (set) Token: 0x0601D7C5 RID: 120773 RVA: 0x00423D11 File Offset: 0x00421F11
		public List<ICameraTemplateT> List { get; set; }

		// Token: 0x0601D7C6 RID: 120774 RVA: 0x00423D1A File Offset: 0x00421F1A
		public ICameraFlowTemplateConfigT()
		{
			this.List = null;
		}
	}
}
