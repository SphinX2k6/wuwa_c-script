using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005301 RID: 21249
	public class IGraph3dBaseT
	{
		// Token: 0x17009C09 RID: 39945
		// (get) Token: 0x06022B64 RID: 142180 RVA: 0x004CF80C File Offset: 0x004CDA0C
		// (set) Token: 0x06022B65 RID: 142181 RVA: 0x004CF814 File Offset: 0x004CDA14
		public EGraph3dType Type { get; set; }

		// Token: 0x17009C0A RID: 39946
		// (get) Token: 0x06022B66 RID: 142182 RVA: 0x004CF81D File Offset: 0x004CDA1D
		// (set) Token: 0x06022B67 RID: 142183 RVA: 0x004CF825 File Offset: 0x004CDA25
		public List<IGraph3dNodeBaseT> Nodes { get; set; }

		// Token: 0x17009C0B RID: 39947
		// (get) Token: 0x06022B68 RID: 142184 RVA: 0x004CF82E File Offset: 0x004CDA2E
		// (set) Token: 0x06022B69 RID: 142185 RVA: 0x004CF836 File Offset: 0x004CDA36
		public List<IGraph3dEdgeBaseT> Edges { get; set; }

		// Token: 0x06022B6A RID: 142186 RVA: 0x004CF83F File Offset: 0x004CDA3F
		public IGraph3dBaseT()
		{
			this.Type = EGraph3dType.Normal;
			this.Nodes = null;
			this.Edges = null;
		}
	}
}
