using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200494E RID: 18766
	public class ILevelBuildingGridConfigT
	{
		// Token: 0x170082D4 RID: 33492
		// (get) Token: 0x0601BE17 RID: 114199 RVA: 0x003F09A7 File Offset: 0x003EEBA7
		// (set) Token: 0x0601BE18 RID: 114200 RVA: 0x003F09AF File Offset: 0x003EEBAF
		public int LevelId { get; set; }

		// Token: 0x170082D5 RID: 33493
		// (get) Token: 0x0601BE19 RID: 114201 RVA: 0x003F09B8 File Offset: 0x003EEBB8
		// (set) Token: 0x0601BE1A RID: 114202 RVA: 0x003F09C0 File Offset: 0x003EEBC0
		public int CellSize { get; set; }

		// Token: 0x170082D6 RID: 33494
		// (get) Token: 0x0601BE1B RID: 114203 RVA: 0x003F09C9 File Offset: 0x003EEBC9
		// (set) Token: 0x0601BE1C RID: 114204 RVA: 0x003F09D1 File Offset: 0x003EEBD1
		public List<ILevelBuildingGridT> Grids { get; set; }

		// Token: 0x170082D7 RID: 33495
		// (get) Token: 0x0601BE1D RID: 114205 RVA: 0x003F09DA File Offset: 0x003EEBDA
		// (set) Token: 0x0601BE1E RID: 114206 RVA: 0x003F09E2 File Offset: 0x003EEBE2
		public int _MaxGridId { get; set; }

		// Token: 0x0601BE1F RID: 114207 RVA: 0x003F09EB File Offset: 0x003EEBEB
		public ILevelBuildingGridConfigT()
		{
			this.LevelId = 0;
			this.CellSize = 0;
			this.Grids = null;
			this._MaxGridId = 0;
		}
	}
}
