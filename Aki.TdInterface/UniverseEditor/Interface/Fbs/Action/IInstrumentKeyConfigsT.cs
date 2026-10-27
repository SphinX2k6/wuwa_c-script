using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006970 RID: 26992
	public class IInstrumentKeyConfigsT
	{
		// Token: 0x1700C82E RID: 51246
		// (get) Token: 0x0602F21A RID: 193050 RVA: 0x0066BDA1 File Offset: 0x00669FA1
		// (set) Token: 0x0602F21B RID: 193051 RVA: 0x0066BDA9 File Offset: 0x00669FA9
		public List<IInstrumentKeyAttributeT> Grids { get; set; }

		// Token: 0x1700C82F RID: 51247
		// (get) Token: 0x0602F21C RID: 193052 RVA: 0x0066BDB2 File Offset: 0x00669FB2
		// (set) Token: 0x0602F21D RID: 193053 RVA: 0x0066BDBA File Offset: 0x00669FBA
		public IInstrumentBoardSizeT BoardSize { get; set; }

		// Token: 0x0602F21E RID: 193054 RVA: 0x0066BDC3 File Offset: 0x00669FC3
		public IInstrumentKeyConfigsT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
