using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004614 RID: 17940
	public class ITetrisIndexedBoardT
	{
		// Token: 0x17007D7F RID: 32127
		// (get) Token: 0x0601A3D6 RID: 107478 RVA: 0x003BC8C5 File Offset: 0x003BAAC5
		// (set) Token: 0x0601A3D7 RID: 107479 RVA: 0x003BC8CD File Offset: 0x003BAACD
		public List<ITetrisSingleIndexGridT> IndexedGrids { get; set; }

		// Token: 0x17007D80 RID: 32128
		// (get) Token: 0x0601A3D8 RID: 107480 RVA: 0x003BC8D6 File Offset: 0x003BAAD6
		// (set) Token: 0x0601A3D9 RID: 107481 RVA: 0x003BC8DE File Offset: 0x003BAADE
		public IRequiredVector2T BoardSize { get; set; }

		// Token: 0x0601A3DA RID: 107482 RVA: 0x003BC8E7 File Offset: 0x003BAAE7
		public ITetrisIndexedBoardT()
		{
			this.IndexedGrids = null;
			this.BoardSize = null;
		}
	}
}
