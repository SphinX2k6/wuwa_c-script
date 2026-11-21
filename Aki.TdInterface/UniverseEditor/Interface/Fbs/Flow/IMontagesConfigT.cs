using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Flow
{
	// Token: 0x02004BAB RID: 19371
	public class IMontagesConfigT
	{
		// Token: 0x17008929 RID: 35113
		// (get) Token: 0x0601D90A RID: 121098 RVA: 0x00426859 File Offset: 0x00424A59
		// (set) Token: 0x0601D90B RID: 121099 RVA: 0x00426861 File Offset: 0x00424A61
		public List<IMontageConfigT> Montages { get; set; }

		// Token: 0x0601D90C RID: 121100 RVA: 0x0042686A File Offset: 0x00424A6A
		public IMontagesConfigT()
		{
			this.Montages = null;
		}
	}
}
