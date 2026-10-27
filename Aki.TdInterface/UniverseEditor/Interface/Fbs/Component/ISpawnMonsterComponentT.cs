using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594E RID: 22862
	public class ISpawnMonsterComponentT
	{
		// Token: 0x1700AB94 RID: 43924
		// (get) Token: 0x06026B06 RID: 158470 RVA: 0x00553F55 File Offset: 0x00552155
		// (set) Token: 0x06026B07 RID: 158471 RVA: 0x00553F5D File Offset: 0x0055215D
		public bool Disabled { get; set; }

		// Token: 0x1700AB95 RID: 43925
		// (get) Token: 0x06026B08 RID: 158472 RVA: 0x00553F66 File Offset: 0x00552166
		// (set) Token: 0x06026B09 RID: 158473 RVA: 0x00553F6E File Offset: 0x0055216E
		public TSpawnMonsterStartConditionUnion ActiveType { get; set; }

		// Token: 0x1700AB96 RID: 43926
		// (get) Token: 0x06026B0A RID: 158474 RVA: 0x00553F77 File Offset: 0x00552177
		// (set) Token: 0x06026B0B RID: 158475 RVA: 0x00553F7F File Offset: 0x0055217F
		public List<ISpawnMonsterConfigT> SpawnMonsterConfigs { get; set; }

		// Token: 0x1700AB97 RID: 43927
		// (get) Token: 0x06026B0C RID: 158476 RVA: 0x00553F88 File Offset: 0x00552188
		// (set) Token: 0x06026B0D RID: 158477 RVA: 0x00553F90 File Offset: 0x00552190
		public bool IssharedHatred { get; set; }

		// Token: 0x1700AB98 RID: 43928
		// (get) Token: 0x06026B0E RID: 158478 RVA: 0x00553F99 File Offset: 0x00552199
		// (set) Token: 0x06026B0F RID: 158479 RVA: 0x00553FA1 File Offset: 0x005521A1
		public ISpawnMonsterConstraintAnnularSectorT SpawnMonsterConstraintType { get; set; }

		// Token: 0x1700AB99 RID: 43929
		// (get) Token: 0x06026B10 RID: 158480 RVA: 0x00553FAA File Offset: 0x005521AA
		// (set) Token: 0x06026B11 RID: 158481 RVA: 0x00553FB2 File Offset: 0x005521B2
		public byte NullMask { get; set; }

		// Token: 0x06026B12 RID: 158482 RVA: 0x00553FBB File Offset: 0x005521BB
		public ISpawnMonsterComponentT()
		{
			this.Disabled = false;
			this.ActiveType = null;
			this.SpawnMonsterConfigs = null;
			this.IssharedHatred = false;
			this.SpawnMonsterConstraintType = null;
			this.NullMask = 0;
		}
	}
}
