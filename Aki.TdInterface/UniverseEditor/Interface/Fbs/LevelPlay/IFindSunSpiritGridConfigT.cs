using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004921 RID: 18721
	public class IFindSunSpiritGridConfigT
	{
		// Token: 0x17008266 RID: 33382
		// (get) Token: 0x0601BC5F RID: 113759 RVA: 0x003ED3F7 File Offset: 0x003EB5F7
		// (set) Token: 0x0601BC60 RID: 113760 RVA: 0x003ED3FF File Offset: 0x003EB5FF
		public List<TFindSunSpiritGridUnion> Grids { get; set; }

		// Token: 0x17008267 RID: 33383
		// (get) Token: 0x0601BC61 RID: 113761 RVA: 0x003ED408 File Offset: 0x003EB608
		// (set) Token: 0x0601BC62 RID: 113762 RVA: 0x003ED410 File Offset: 0x003EB610
		public IVector2T BoardSize { get; set; }

		// Token: 0x0601BC63 RID: 113763 RVA: 0x003ED419 File Offset: 0x003EB619
		public IFindSunSpiritGridConfigT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
