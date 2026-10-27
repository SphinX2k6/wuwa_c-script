using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x0200473A RID: 18234
	public class IFlowTemplateConfigT
	{
		// Token: 0x170082C9 RID: 33481
		// (get) Token: 0x0601C0B3 RID: 114867 RVA: 0x003F94B5 File Offset: 0x003F76B5
		// (set) Token: 0x0601C0B4 RID: 114868 RVA: 0x003F94BD File Offset: 0x003F76BD
		public List<IFlowTemplateDataT> List { get; set; }

		// Token: 0x0601C0B5 RID: 114869 RVA: 0x003F94C6 File Offset: 0x003F76C6
		public IFlowTemplateConfigT()
		{
			this.List = null;
		}
	}
}
