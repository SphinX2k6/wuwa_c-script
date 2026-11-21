using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005476 RID: 21622
	public class IButterflySplineT
	{
		// Token: 0x170099C2 RID: 39362
		// (get) Token: 0x06021F8B RID: 139147 RVA: 0x004AEB2B File Offset: 0x004ACD2B
		// (set) Token: 0x06021F8C RID: 139148 RVA: 0x004AEB33 File Offset: 0x004ACD33
		public ESplineType Type { get; set; }

		// Token: 0x170099C3 RID: 39363
		// (get) Token: 0x06021F8D RID: 139149 RVA: 0x004AEB3C File Offset: 0x004ACD3C
		// (set) Token: 0x06021F8E RID: 139150 RVA: 0x004AEB44 File Offset: 0x004ACD44
		public List<IButterflySplinePointT> Points { get; set; }

		// Token: 0x06021F8F RID: 139151 RVA: 0x004AEB4D File Offset: 0x004ACD4D
		public IButterflySplineT()
		{
			this.Type = ESplineType.Common;
			this.Points = null;
		}
	}
}
