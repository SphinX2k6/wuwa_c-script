using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004611 RID: 17937
	public class ITetrisBoardT
	{
		// Token: 0x17007D7A RID: 32122
		// (get) Token: 0x0601A3BA RID: 107450 RVA: 0x003BC491 File Offset: 0x003BA691
		// (set) Token: 0x0601A3BB RID: 107451 RVA: 0x003BC499 File Offset: 0x003BA699
		public List<ITetrisSingleGridT> Grids { get; set; }

		// Token: 0x17007D7B RID: 32123
		// (get) Token: 0x0601A3BC RID: 107452 RVA: 0x003BC4A2 File Offset: 0x003BA6A2
		// (set) Token: 0x0601A3BD RID: 107453 RVA: 0x003BC4AA File Offset: 0x003BA6AA
		public IRequiredVector2T BoardSize { get; set; }

		// Token: 0x0601A3BE RID: 107454 RVA: 0x003BC4B3 File Offset: 0x003BA6B3
		public ITetrisBoardT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
