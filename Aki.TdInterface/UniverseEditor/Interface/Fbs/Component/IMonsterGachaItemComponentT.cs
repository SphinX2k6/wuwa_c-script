using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200557C RID: 21884
	public class IMonsterGachaItemComponentT
	{
		// Token: 0x1700A1BE RID: 41406
		// (get) Token: 0x060243A7 RID: 148391 RVA: 0x00500EA2 File Offset: 0x004FF0A2
		// (set) Token: 0x060243A8 RID: 148392 RVA: 0x00500EAA File Offset: 0x004FF0AA
		public bool Disabled { get; set; }

		// Token: 0x1700A1BF RID: 41407
		// (get) Token: 0x060243A9 RID: 148393 RVA: 0x00500EB3 File Offset: 0x004FF0B3
		// (set) Token: 0x060243AA RID: 148394 RVA: 0x00500EBB File Offset: 0x004FF0BB
		public string MaterialDataPath { get; set; }

		// Token: 0x1700A1C0 RID: 41408
		// (get) Token: 0x060243AB RID: 148395 RVA: 0x00500EC4 File Offset: 0x004FF0C4
		// (set) Token: 0x060243AC RID: 148396 RVA: 0x00500ECC File Offset: 0x004FF0CC
		public EMonsterMatchType MonsterType { get; set; }

		// Token: 0x1700A1C1 RID: 41409
		// (get) Token: 0x060243AD RID: 148397 RVA: 0x00500ED5 File Offset: 0x004FF0D5
		// (set) Token: 0x060243AE RID: 148398 RVA: 0x00500EDD File Offset: 0x004FF0DD
		public List<int> MonsterEntityIds { get; set; }

		// Token: 0x1700A1C2 RID: 41410
		// (get) Token: 0x060243AF RID: 148399 RVA: 0x00500EE6 File Offset: 0x004FF0E6
		// (set) Token: 0x060243B0 RID: 148400 RVA: 0x00500EEE File Offset: 0x004FF0EE
		public byte NullMask { get; set; }

		// Token: 0x060243B1 RID: 148401 RVA: 0x00500EF7 File Offset: 0x004FF0F7
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
