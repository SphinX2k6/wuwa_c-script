using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C21 RID: 31777
	public class ITraceTracingGridBoardT
	{
		// Token: 0x1700EDF4 RID: 60916
		// (get) Token: 0x06039477 RID: 234615 RVA: 0x007BC70B File Offset: 0x007BA90B
		// (set) Token: 0x06039478 RID: 234616 RVA: 0x007BC713 File Offset: 0x007BA913
		public List<ETraceTracingGridType> Grids { get; set; }

		// Token: 0x1700EDF5 RID: 60917
		// (get) Token: 0x06039479 RID: 234617 RVA: 0x007BC71C File Offset: 0x007BA91C
		// (set) Token: 0x0603947A RID: 234618 RVA: 0x007BC724 File Offset: 0x007BA924
		public IVector2T BoardSize { get; set; }

		// Token: 0x0603947B RID: 234619 RVA: 0x007BC72D File Offset: 0x007BA92D
		public ITraceTracingGridBoardT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
