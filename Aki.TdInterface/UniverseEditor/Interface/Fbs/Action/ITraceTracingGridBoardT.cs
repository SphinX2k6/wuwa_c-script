using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200742E RID: 29742
	public class ITraceTracingGridBoardT
	{
		// Token: 0x1700E1D7 RID: 57815
		// (get) Token: 0x0603608E RID: 221326 RVA: 0x007599DF File Offset: 0x00757BDF
		// (set) Token: 0x0603608F RID: 221327 RVA: 0x007599E7 File Offset: 0x00757BE7
		public List<ETraceTracingGridType> Grids { get; set; }

		// Token: 0x1700E1D8 RID: 57816
		// (get) Token: 0x06036090 RID: 221328 RVA: 0x007599F0 File Offset: 0x00757BF0
		// (set) Token: 0x06036091 RID: 221329 RVA: 0x007599F8 File Offset: 0x00757BF8
		public IVector2T BoardSize { get; set; }

		// Token: 0x06036092 RID: 221330 RVA: 0x00759A01 File Offset: 0x00757C01
		public ITraceTracingGridBoardT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
