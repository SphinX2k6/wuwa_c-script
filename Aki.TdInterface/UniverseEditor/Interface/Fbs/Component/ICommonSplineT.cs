using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FD1 RID: 20433
	public class ICommonSplineT
	{
		// Token: 0x17009402 RID: 37890
		// (get) Token: 0x060208AD RID: 133293 RVA: 0x0048682F File Offset: 0x00484A2F
		// (set) Token: 0x060208AE RID: 133294 RVA: 0x00486837 File Offset: 0x00484A37
		public ESplineType Type { get; set; }

		// Token: 0x17009403 RID: 37891
		// (get) Token: 0x060208AF RID: 133295 RVA: 0x00486840 File Offset: 0x00484A40
		// (set) Token: 0x060208B0 RID: 133296 RVA: 0x00486848 File Offset: 0x00484A48
		public List<ICommonSplinePointT> Points { get; set; }

		// Token: 0x060208B1 RID: 133297 RVA: 0x00486851 File Offset: 0x00484A51
		public ICommonSplineT()
		{
			this.Type = ESplineType.Common;
			this.Points = null;
		}
	}
}
