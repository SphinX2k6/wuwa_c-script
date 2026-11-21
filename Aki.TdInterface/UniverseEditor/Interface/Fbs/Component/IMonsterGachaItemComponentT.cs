using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B1A RID: 23322
	public class IMonsterGachaItemComponentT
	{
		// Token: 0x1700AA46 RID: 43590
		// (get) Token: 0x060265B4 RID: 157108 RVA: 0x0054141A File Offset: 0x0053F61A
		// (set) Token: 0x060265B5 RID: 157109 RVA: 0x00541422 File Offset: 0x0053F622
		public bool Disabled { get; set; }

		// Token: 0x1700AA47 RID: 43591
		// (get) Token: 0x060265B6 RID: 157110 RVA: 0x0054142B File Offset: 0x0053F62B
		// (set) Token: 0x060265B7 RID: 157111 RVA: 0x00541433 File Offset: 0x0053F633
		public string MaterialDataPath { get; set; }

		// Token: 0x1700AA48 RID: 43592
		// (get) Token: 0x060265B8 RID: 157112 RVA: 0x0054143C File Offset: 0x0053F63C
		// (set) Token: 0x060265B9 RID: 157113 RVA: 0x00541444 File Offset: 0x0053F644
		public EMonsterMatchType MonsterType { get; set; }

		// Token: 0x1700AA49 RID: 43593
		// (get) Token: 0x060265BA RID: 157114 RVA: 0x0054144D File Offset: 0x0053F64D
		// (set) Token: 0x060265BB RID: 157115 RVA: 0x00541455 File Offset: 0x0053F655
		public List<int> MonsterEntityIds { get; set; }

		// Token: 0x1700AA4A RID: 43594
		// (get) Token: 0x060265BC RID: 157116 RVA: 0x0054145E File Offset: 0x0053F65E
		// (set) Token: 0x060265BD RID: 157117 RVA: 0x00541466 File Offset: 0x0053F666
		public byte NullMask { get; set; }

		// Token: 0x060265BE RID: 157118 RVA: 0x0054146F File Offset: 0x0053F66F
		public IMonsterGachaItemComponentT()
		{
			this.Disabled = false;
			this.MaterialDataPath = null;
			this.MonsterType = EMonsterMatchType.Normal;
			this.MonsterEntityIds = null;
			this.NullMask = 0;
		}
	}
}
