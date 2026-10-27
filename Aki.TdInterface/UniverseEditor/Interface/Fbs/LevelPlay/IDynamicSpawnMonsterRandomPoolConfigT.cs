using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044A4 RID: 17572
	public class IDynamicSpawnMonsterRandomPoolConfigT
	{
		// Token: 0x17007C01 RID: 31745
		// (get) Token: 0x0601A3CC RID: 107468 RVA: 0x003BF9E9 File Offset: 0x003BDBE9
		// (set) Token: 0x0601A3CD RID: 107469 RVA: 0x003BF9F1 File Offset: 0x003BDBF1
		public int Id { get; set; }

		// Token: 0x17007C02 RID: 31746
		// (get) Token: 0x0601A3CE RID: 107470 RVA: 0x003BF9FA File Offset: 0x003BDBFA
		// (set) Token: 0x0601A3CF RID: 107471 RVA: 0x003BFA02 File Offset: 0x003BDC02
		public EMonsterSourceType MonsterSource { get; set; }

		// Token: 0x17007C03 RID: 31747
		// (get) Token: 0x0601A3D0 RID: 107472 RVA: 0x003BFA0B File Offset: 0x003BDC0B
		// (set) Token: 0x0601A3D1 RID: 107473 RVA: 0x003BFA13 File Offset: 0x003BDC13
		public List<IDynamicSpawnMonsterGroupT> MonsterGroup { get; set; }

		// Token: 0x0601A3D2 RID: 107474 RVA: 0x003BFA1C File Offset: 0x003BDC1C
		public IDynamicSpawnMonsterRandomPoolConfigT()
		{
			this.Id = 0;
			this.MonsterSource = EMonsterSourceType.EntityTemplate;
			this.MonsterGroup = null;
		}
	}
}
