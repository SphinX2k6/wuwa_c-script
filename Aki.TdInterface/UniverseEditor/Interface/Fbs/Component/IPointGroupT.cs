using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575B RID: 22363
	public class IPointGroupT
	{
		// Token: 0x1700A6D2 RID: 42706
		// (get) Token: 0x0602579F RID: 153503 RVA: 0x0052BAA4 File Offset: 0x00529CA4
		// (set) Token: 0x060257A0 RID: 153504 RVA: 0x0052BAAC File Offset: 0x00529CAC
		public IPointGroupByLayerT GroupConfig { get; set; }

		// Token: 0x1700A6D3 RID: 42707
		// (get) Token: 0x060257A1 RID: 153505 RVA: 0x0052BAB5 File Offset: 0x00529CB5
		// (set) Token: 0x060257A2 RID: 153506 RVA: 0x0052BABD File Offset: 0x00529CBD
		public List<IVectorInfoT> Points { get; set; }

		// Token: 0x060257A3 RID: 153507 RVA: 0x0052BAC6 File Offset: 0x00529CC6
		public IPointGroupT()
		{
			this.GroupConfig = null;
			this.Points = null;
		}
	}
}
