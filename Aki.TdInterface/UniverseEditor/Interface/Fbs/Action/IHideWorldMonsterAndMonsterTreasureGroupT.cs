using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006916 RID: 26902
	public class IHideWorldMonsterAndMonsterTreasureGroupT
	{
		// Token: 0x1700C7A0 RID: 51104
		// (get) Token: 0x0602EF74 RID: 192372 RVA: 0x006679D7 File Offset: 0x00665BD7
		// (set) Token: 0x0602EF75 RID: 192373 RVA: 0x006679DF File Offset: 0x00665BDF
		public EHideType Type { get; set; }

		// Token: 0x1700C7A1 RID: 51105
		// (get) Token: 0x0602EF76 RID: 192374 RVA: 0x006679E8 File Offset: 0x00665BE8
		// (set) Token: 0x0602EF77 RID: 192375 RVA: 0x006679F0 File Offset: 0x00665BF0
		public List<int> HideRangeEntities { get; set; }

		// Token: 0x0602EF78 RID: 192376 RVA: 0x006679F9 File Offset: 0x00665BF9
		public IHideWorldMonsterAndMonsterTreasureGroupT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.HideRangeEntities = null;
		}
	}
}
