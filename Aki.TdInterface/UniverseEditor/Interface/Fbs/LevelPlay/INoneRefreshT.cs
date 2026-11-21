using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004999 RID: 18841
	public class INoneRefreshT
	{
		// Token: 0x170083E6 RID: 33766
		// (get) Token: 0x0601C20E RID: 115214 RVA: 0x003F967E File Offset: 0x003F787E
		// (set) Token: 0x0601C20F RID: 115215 RVA: 0x003F9686 File Offset: 0x003F7886
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x0601C210 RID: 115216 RVA: 0x003F968F File Offset: 0x003F788F
		public INoneRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
		}
	}
}
