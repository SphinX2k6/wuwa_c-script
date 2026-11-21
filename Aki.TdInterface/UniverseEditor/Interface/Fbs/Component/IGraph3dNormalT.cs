using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058A5 RID: 22693
	public class IGraph3dNormalT
	{
		// Token: 0x1700A477 RID: 42103
		// (get) Token: 0x06024D00 RID: 150784 RVA: 0x0050E128 File Offset: 0x0050C328
		// (set) Token: 0x06024D01 RID: 150785 RVA: 0x0050E130 File Offset: 0x0050C330
		public EGraph3dType Type { get; set; }

		// Token: 0x1700A478 RID: 42104
		// (get) Token: 0x06024D02 RID: 150786 RVA: 0x0050E139 File Offset: 0x0050C339
		// (set) Token: 0x06024D03 RID: 150787 RVA: 0x0050E141 File Offset: 0x0050C341
		public List<IGraph3dNodeBaseT> Nodes { get; set; }

		// Token: 0x1700A479 RID: 42105
		// (get) Token: 0x06024D04 RID: 150788 RVA: 0x0050E14A File Offset: 0x0050C34A
		// (set) Token: 0x06024D05 RID: 150789 RVA: 0x0050E152 File Offset: 0x0050C352
		public List<IGraph3dEdgeBaseT> Edges { get; set; }

		// Token: 0x06024D06 RID: 150790 RVA: 0x0050E15B File Offset: 0x0050C35B
		public IGraph3dNormalT()
		{
			this.Type = EGraph3dType.Normal;
			this.Nodes = null;
			this.Edges = null;
		}
	}
}
