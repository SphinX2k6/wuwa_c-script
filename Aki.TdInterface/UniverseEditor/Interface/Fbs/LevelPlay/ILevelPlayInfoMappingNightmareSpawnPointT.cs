using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004960 RID: 18784
	public class ILevelPlayInfoMappingNightmareSpawnPointT
	{
		// Token: 0x1700835E RID: 33630
		// (get) Token: 0x0601BFE0 RID: 114656 RVA: 0x003F54D4 File Offset: 0x003F36D4
		// (set) Token: 0x0601BFE1 RID: 114657 RVA: 0x003F54DC File Offset: 0x003F36DC
		public ELevelPlayInfoMappingType Type { get; set; }

		// Token: 0x1700835F RID: 33631
		// (get) Token: 0x0601BFE2 RID: 114658 RVA: 0x003F54E5 File Offset: 0x003F36E5
		// (set) Token: 0x0601BFE3 RID: 114659 RVA: 0x003F54ED File Offset: 0x003F36ED
		public int LevelPlayId { get; set; }

		// Token: 0x17008360 RID: 33632
		// (get) Token: 0x0601BFE4 RID: 114660 RVA: 0x003F54F6 File Offset: 0x003F36F6
		// (set) Token: 0x0601BFE5 RID: 114661 RVA: 0x003F54FE File Offset: 0x003F36FE
		public List<string> Vars { get; set; }

		// Token: 0x17008361 RID: 33633
		// (get) Token: 0x0601BFE6 RID: 114662 RVA: 0x003F5507 File Offset: 0x003F3707
		// (set) Token: 0x0601BFE7 RID: 114663 RVA: 0x003F550F File Offset: 0x003F370F
		public List<int> DefaultValues { get; set; }

		// Token: 0x17008362 RID: 33634
		// (get) Token: 0x0601BFE8 RID: 114664 RVA: 0x003F5518 File Offset: 0x003F3718
		// (set) Token: 0x0601BFE9 RID: 114665 RVA: 0x003F5520 File Offset: 0x003F3720
		public byte NullMask { get; set; }

		// Token: 0x0601BFEA RID: 114666 RVA: 0x003F5529 File Offset: 0x003F3729
		public ILevelPlayInfoMappingNightmareSpawnPointT()
		{
			this.Type = ELevelPlayInfoMappingType.PunishReport;
			this.LevelPlayId = 0;
			this.Vars = null;
			this.DefaultValues = null;
			this.NullMask = 0;
		}
	}
}
