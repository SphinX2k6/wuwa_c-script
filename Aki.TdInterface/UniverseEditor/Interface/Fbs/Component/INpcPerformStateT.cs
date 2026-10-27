using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200563C RID: 22076
	public class INpcPerformStateT
	{
		// Token: 0x1700A38B RID: 41867
		// (get) Token: 0x06024B1B RID: 150299 RVA: 0x005109DC File Offset: 0x0050EBDC
		// (set) Token: 0x06024B1C RID: 150300 RVA: 0x005109E4 File Offset: 0x0050EBE4
		public IInitNpcPerformStateT InitState { get; set; }

		// Token: 0x1700A38C RID: 41868
		// (get) Token: 0x06024B1D RID: 150301 RVA: 0x005109ED File Offset: 0x0050EBED
		// (set) Token: 0x06024B1E RID: 150302 RVA: 0x005109F5 File Offset: 0x0050EBF5
		public List<INpcPerformStateConfigT> Configs { get; set; }

		// Token: 0x06024B1F RID: 150303 RVA: 0x005109FE File Offset: 0x0050EBFE
		public INpcPerformStateT()
		{
			this.InitState = null;
			this.Configs = null;
		}
	}
}
