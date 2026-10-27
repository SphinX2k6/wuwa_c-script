using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004558 RID: 17752
	public class IRollBlockBoardConfigT
	{
		// Token: 0x17007DEF RID: 32239
		// (get) Token: 0x0601AB99 RID: 109465 RVA: 0x003CFBEB File Offset: 0x003CDDEB
		// (set) Token: 0x0601AB9A RID: 109466 RVA: 0x003CFBF3 File Offset: 0x003CDDF3
		public List<TRollBlockGridUnion> Grids { get; set; }

		// Token: 0x17007DF0 RID: 32240
		// (get) Token: 0x0601AB9B RID: 109467 RVA: 0x003CFBFC File Offset: 0x003CDDFC
		// (set) Token: 0x0601AB9C RID: 109468 RVA: 0x003CFC04 File Offset: 0x003CDE04
		public IVector2T BoardSize { get; set; }

		// Token: 0x0601AB9D RID: 109469 RVA: 0x003CFC0D File Offset: 0x003CDE0D
		public IRollBlockBoardConfigT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
