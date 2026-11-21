using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047FE RID: 18430
	public class IExportAllRefOccupationsT
	{
		// Token: 0x1700808B RID: 32907
		// (get) Token: 0x0601B3B3 RID: 111539 RVA: 0x003DBBE6 File Offset: 0x003D9DE6
		// (set) Token: 0x0601B3B4 RID: 111540 RVA: 0x003DBBEE File Offset: 0x003D9DEE
		public List<IQuestAllRefOccupationsT> Quest { get; set; }

		// Token: 0x1700808C RID: 32908
		// (get) Token: 0x0601B3B5 RID: 111541 RVA: 0x003DBBF7 File Offset: 0x003D9DF7
		// (set) Token: 0x0601B3B6 RID: 111542 RVA: 0x003DBBFF File Offset: 0x003D9DFF
		public List<ILevelPlayAllRefOccupationsT> LevelPlay { get; set; }

		// Token: 0x0601B3B7 RID: 111543 RVA: 0x003DBC08 File Offset: 0x003D9E08
		public IExportAllRefOccupationsT()
		{
			this.Quest = null;
			this.LevelPlay = null;
		}
	}
}
