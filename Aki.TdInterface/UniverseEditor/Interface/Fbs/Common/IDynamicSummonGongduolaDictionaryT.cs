using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D8F RID: 23951
	public class IDynamicSummonGongduolaDictionaryT
	{
		// Token: 0x1700B360 RID: 45920
		// (get) Token: 0x06028FCC RID: 167884 RVA: 0x005A13B9 File Offset: 0x0059F5B9
		// (set) Token: 0x06028FCD RID: 167885 RVA: 0x005A13C1 File Offset: 0x0059F5C1
		public List<IDynamicSummonGongduolaConfigT> Configs { get; set; }

		// Token: 0x06028FCE RID: 167886 RVA: 0x005A13CA File Offset: 0x0059F5CA
		public IDynamicSummonGongduolaDictionaryT()
		{
			this.Configs = null;
		}
	}
}
