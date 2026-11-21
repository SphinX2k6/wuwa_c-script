using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BA2 RID: 19362
	public class IFlowTemplateConfigT
	{
		// Token: 0x1700890A RID: 35082
		// (get) Token: 0x0601D888 RID: 120968 RVA: 0x00425751 File Offset: 0x00423951
		// (set) Token: 0x0601D889 RID: 120969 RVA: 0x00425759 File Offset: 0x00423959
		public List<IFlowTemplateDataT> List { get; set; }

		// Token: 0x0601D88A RID: 120970 RVA: 0x00425762 File Offset: 0x00423962
		public IFlowTemplateConfigT()
		{
			this.List = null;
		}
	}
}
