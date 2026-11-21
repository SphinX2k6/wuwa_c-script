using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005887 RID: 22663
	public class IGraph3dBaseT
	{
		// Token: 0x1700A441 RID: 42049
		// (get) Token: 0x06024C18 RID: 150552 RVA: 0x0050C6E0 File Offset: 0x0050A8E0
		// (set) Token: 0x06024C19 RID: 150553 RVA: 0x0050C6E8 File Offset: 0x0050A8E8
		public EGraph3dType Type { get; set; }

		// Token: 0x1700A442 RID: 42050
		// (get) Token: 0x06024C1A RID: 150554 RVA: 0x0050C6F1 File Offset: 0x0050A8F1
		// (set) Token: 0x06024C1B RID: 150555 RVA: 0x0050C6F9 File Offset: 0x0050A8F9
		public List<IGraph3dNodeBaseT> Nodes { get; set; }

		// Token: 0x1700A443 RID: 42051
		// (get) Token: 0x06024C1C RID: 150556 RVA: 0x0050C702 File Offset: 0x0050A902
		// (set) Token: 0x06024C1D RID: 150557 RVA: 0x0050C70A File Offset: 0x0050A90A
		public List<IGraph3dEdgeBaseT> Edges { get; set; }

		// Token: 0x06024C1E RID: 150558 RVA: 0x0050C713 File Offset: 0x0050A913
		public IGraph3dBaseT()
		{
			this.Type = EGraph3dType.Normal;
			this.Nodes = null;
			this.Edges = null;
		}
	}
}
