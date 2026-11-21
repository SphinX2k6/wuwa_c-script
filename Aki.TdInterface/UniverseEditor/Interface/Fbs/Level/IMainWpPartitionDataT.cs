using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200487B RID: 18555
	public class IMainWpPartitionDataT
	{
		// Token: 0x17008132 RID: 33074
		// (get) Token: 0x0601B717 RID: 112407 RVA: 0x003E2649 File Offset: 0x003E0849
		// (set) Token: 0x0601B718 RID: 112408 RVA: 0x003E2651 File Offset: 0x003E0851
		public List<ISubWpDataT> SubWpData { get; set; }

		// Token: 0x0601B719 RID: 112409 RVA: 0x003E265A File Offset: 0x003E085A
		public IMainWpPartitionDataT()
		{
			this.SubWpData = null;
		}
	}
}
