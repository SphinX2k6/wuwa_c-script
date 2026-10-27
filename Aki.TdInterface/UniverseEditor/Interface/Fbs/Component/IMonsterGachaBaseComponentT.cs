using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005579 RID: 21881
	public class IMonsterGachaBaseComponentT
	{
		// Token: 0x1700A1B3 RID: 41395
		// (get) Token: 0x0602437B RID: 148347 RVA: 0x0050095D File Offset: 0x004FEB5D
		// (set) Token: 0x0602437C RID: 148348 RVA: 0x00500965 File Offset: 0x004FEB65
		public bool Disabled { get; set; }

		// Token: 0x1700A1B4 RID: 41396
		// (get) Token: 0x0602437D RID: 148349 RVA: 0x0050096E File Offset: 0x004FEB6E
		// (set) Token: 0x0602437E RID: 148350 RVA: 0x00500976 File Offset: 0x004FEB76
		public List<int> MonsterEntityIds { get; set; }

		// Token: 0x1700A1B5 RID: 41397
		// (get) Token: 0x0602437F RID: 148351 RVA: 0x0050097F File Offset: 0x004FEB7F
		// (set) Token: 0x06024380 RID: 148352 RVA: 0x00500987 File Offset: 0x004FEB87
		public List<IMonsterGachaSlotT> Config { get; set; }

		// Token: 0x1700A1B6 RID: 41398
		// (get) Token: 0x06024381 RID: 148353 RVA: 0x00500990 File Offset: 0x004FEB90
		// (set) Token: 0x06024382 RID: 148354 RVA: 0x00500998 File Offset: 0x004FEB98
		public List<IMonsterFormationT> Formation { get; set; }

		// Token: 0x1700A1B7 RID: 41399
		// (get) Token: 0x06024383 RID: 148355 RVA: 0x005009A1 File Offset: 0x004FEBA1
		// (set) Token: 0x06024384 RID: 148356 RVA: 0x005009A9 File Offset: 0x004FEBA9
		public byte NullMask { get; set; }

		// Token: 0x06024385 RID: 148357 RVA: 0x005009B2 File Offset: 0x004FEBB2
		public IMonsterGachaBaseComponentT()
		{
			this.Disabled = false;
			this.MonsterEntityIds = null;
			this.Config = null;
			this.Formation = null;
			this.NullMask = 0;
		}
	}
}
