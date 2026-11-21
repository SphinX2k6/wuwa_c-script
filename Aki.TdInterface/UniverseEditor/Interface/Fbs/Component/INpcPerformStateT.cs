using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BDA RID: 23514
	public class INpcPerformStateT
	{
		// Token: 0x1700AC15 RID: 44053
		// (get) Token: 0x06026D3A RID: 159034 RVA: 0x00551300 File Offset: 0x0054F500
		// (set) Token: 0x06026D3B RID: 159035 RVA: 0x00551308 File Offset: 0x0054F508
		public IInitNpcPerformStateT InitState { get; set; }

		// Token: 0x1700AC16 RID: 44054
		// (get) Token: 0x06026D3C RID: 159036 RVA: 0x00551311 File Offset: 0x0054F511
		// (set) Token: 0x06026D3D RID: 159037 RVA: 0x00551319 File Offset: 0x0054F519
		public List<INpcPerformStateConfigT> Configs { get; set; }

		// Token: 0x06026D3E RID: 159038 RVA: 0x00551322 File Offset: 0x0054F522
		public INpcPerformStateT()
		{
			this.InitState = null;
			this.Configs = null;
		}
	}
}
