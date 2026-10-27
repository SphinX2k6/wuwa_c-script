using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006910 RID: 26896
	public class IHideWorldEntityAndLevelPlayGroupT
	{
		// Token: 0x1700C793 RID: 51091
		// (get) Token: 0x0602EF3A RID: 192314 RVA: 0x00667466 File Offset: 0x00665666
		// (set) Token: 0x0602EF3B RID: 192315 RVA: 0x0066746E File Offset: 0x0066566E
		public EHideType Type { get; set; }

		// Token: 0x1700C794 RID: 51092
		// (get) Token: 0x0602EF3C RID: 192316 RVA: 0x00667477 File Offset: 0x00665677
		// (set) Token: 0x0602EF3D RID: 192317 RVA: 0x0066747F File Offset: 0x0066567F
		public List<int> HideRangeEntities { get; set; }

		// Token: 0x1700C795 RID: 51093
		// (get) Token: 0x0602EF3E RID: 192318 RVA: 0x00667488 File Offset: 0x00665688
		// (set) Token: 0x0602EF3F RID: 192319 RVA: 0x00667490 File Offset: 0x00665690
		public List<int> ExcludeEntities { get; set; }

		// Token: 0x1700C796 RID: 51094
		// (get) Token: 0x0602EF40 RID: 192320 RVA: 0x00667499 File Offset: 0x00665699
		// (set) Token: 0x0602EF41 RID: 192321 RVA: 0x006674A1 File Offset: 0x006656A1
		public List<int> ExcludeLevelPlays { get; set; }

		// Token: 0x1700C797 RID: 51095
		// (get) Token: 0x0602EF42 RID: 192322 RVA: 0x006674AA File Offset: 0x006656AA
		// (set) Token: 0x0602EF43 RID: 192323 RVA: 0x006674B2 File Offset: 0x006656B2
		public List<int> AppendEntities { get; set; }

		// Token: 0x1700C798 RID: 51096
		// (get) Token: 0x0602EF44 RID: 192324 RVA: 0x006674BB File Offset: 0x006656BB
		// (set) Token: 0x0602EF45 RID: 192325 RVA: 0x006674C3 File Offset: 0x006656C3
		public List<int> AppendLevelPlays { get; set; }

		// Token: 0x1700C799 RID: 51097
		// (get) Token: 0x0602EF46 RID: 192326 RVA: 0x006674CC File Offset: 0x006656CC
		// (set) Token: 0x0602EF47 RID: 192327 RVA: 0x006674D4 File Offset: 0x006656D4
		public byte NullMask { get; set; }

		// Token: 0x0602EF48 RID: 192328 RVA: 0x006674DD File Offset: 0x006656DD
		public IHideWorldEntityAndLevelPlayGroupT()
		{
			this.Type = EHideType.WorldMonsterAndMonsterTreasure;
			this.HideRangeEntities = null;
			this.ExcludeEntities = null;
			this.ExcludeLevelPlays = null;
			this.AppendEntities = null;
			this.AppendLevelPlays = null;
			this.NullMask = 0;
		}
	}
}
