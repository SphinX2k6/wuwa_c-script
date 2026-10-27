using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200531F RID: 21279
	public class IGraph3dNormalT
	{
		// Token: 0x17009C3F RID: 39999
		// (get) Token: 0x06022C4C RID: 142412 RVA: 0x004D1254 File Offset: 0x004CF454
		// (set) Token: 0x06022C4D RID: 142413 RVA: 0x004D125C File Offset: 0x004CF45C
		public EGraph3dType Type { get; set; }

		// Token: 0x17009C40 RID: 40000
		// (get) Token: 0x06022C4E RID: 142414 RVA: 0x004D1265 File Offset: 0x004CF465
		// (set) Token: 0x06022C4F RID: 142415 RVA: 0x004D126D File Offset: 0x004CF46D
		public List<IGraph3dNodeBaseT> Nodes { get; set; }

		// Token: 0x17009C41 RID: 40001
		// (get) Token: 0x06022C50 RID: 142416 RVA: 0x004D1276 File Offset: 0x004CF476
		// (set) Token: 0x06022C51 RID: 142417 RVA: 0x004D127E File Offset: 0x004CF47E
		public List<IGraph3dEdgeBaseT> Edges { get; set; }

		// Token: 0x06022C52 RID: 142418 RVA: 0x004D1287 File Offset: 0x004CF487
		public IGraph3dNormalT()
		{
			this.Type = EGraph3dType.Normal;
			this.Nodes = null;
			this.Edges = null;
		}
	}
}
