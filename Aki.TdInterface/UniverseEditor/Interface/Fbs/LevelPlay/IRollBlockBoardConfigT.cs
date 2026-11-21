using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049C0 RID: 18880
	public class IRollBlockBoardConfigT
	{
		// Token: 0x17008430 RID: 33840
		// (get) Token: 0x0601C36E RID: 115566 RVA: 0x003FBE87 File Offset: 0x003FA087
		// (set) Token: 0x0601C36F RID: 115567 RVA: 0x003FBE8F File Offset: 0x003FA08F
		public List<TRollBlockGridUnion> Grids { get; set; }

		// Token: 0x17008431 RID: 33841
		// (get) Token: 0x0601C370 RID: 115568 RVA: 0x003FBE98 File Offset: 0x003FA098
		// (set) Token: 0x0601C371 RID: 115569 RVA: 0x003FBEA0 File Offset: 0x003FA0A0
		public IVector2T BoardSize { get; set; }

		// Token: 0x0601C372 RID: 115570 RVA: 0x003FBEA9 File Offset: 0x003FA0A9
		public IRollBlockBoardConfigT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
