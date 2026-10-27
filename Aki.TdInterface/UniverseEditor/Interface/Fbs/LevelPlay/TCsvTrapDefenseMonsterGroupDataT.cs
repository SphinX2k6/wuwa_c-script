using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045F4 RID: 17908
	public class TCsvTrapDefenseMonsterGroupDataT
	{
		// Token: 0x17007F54 RID: 32596
		// (get) Token: 0x0601B211 RID: 111121 RVA: 0x003DDBEB File Offset: 0x003DBDEB
		// (set) Token: 0x0601B212 RID: 111122 RVA: 0x003DDBF3 File Offset: 0x003DBDF3
		public int Id { get; set; }

		// Token: 0x17007F55 RID: 32597
		// (get) Token: 0x0601B213 RID: 111123 RVA: 0x003DDBFC File Offset: 0x003DBDFC
		// (set) Token: 0x0601B214 RID: 111124 RVA: 0x003DDC04 File Offset: 0x003DBE04
		public List<ITrapDefenseMonsterGroupT> Monsters { get; set; }

		// Token: 0x0601B215 RID: 111125 RVA: 0x003DDC0D File Offset: 0x003DBE0D
		public TCsvTrapDefenseMonsterGroupDataT()
		{
			this.Id = 0;
			this.Monsters = null;
		}
	}
}
