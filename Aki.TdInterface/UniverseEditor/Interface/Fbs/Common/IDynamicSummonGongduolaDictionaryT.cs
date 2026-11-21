using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063CC RID: 25548
	public class IDynamicSummonGongduolaDictionaryT
	{
		// Token: 0x1700BCC6 RID: 48326
		// (get) Token: 0x0602B656 RID: 177750 RVA: 0x005EA0E9 File Offset: 0x005E82E9
		// (set) Token: 0x0602B657 RID: 177751 RVA: 0x005EA0F1 File Offset: 0x005E82F1
		public List<IDynamicSummonGongduolaConfigT> Configs { get; set; }

		// Token: 0x0602B658 RID: 177752 RVA: 0x005EA0FA File Offset: 0x005E82FA
		public IDynamicSummonGongduolaDictionaryT()
		{
			this.Configs = null;
		}
	}
}
