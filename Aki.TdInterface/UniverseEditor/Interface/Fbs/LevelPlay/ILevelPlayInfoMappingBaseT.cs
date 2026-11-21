using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200495A RID: 18778
	public class ILevelPlayInfoMappingBaseT
	{
		// Token: 0x17008355 RID: 33621
		// (get) Token: 0x0601BFA8 RID: 114600 RVA: 0x003F4DD6 File Offset: 0x003F2FD6
		// (set) Token: 0x0601BFA9 RID: 114601 RVA: 0x003F4DDE File Offset: 0x003F2FDE
		public ELevelPlayInfoMappingType Type { get; set; }

		// Token: 0x0601BFAA RID: 114602 RVA: 0x003F4DE7 File Offset: 0x003F2FE7
		public ILevelPlayInfoMappingBaseT()
		{
			this.Type = ELevelPlayInfoMappingType.PunishReport;
		}
	}
}
