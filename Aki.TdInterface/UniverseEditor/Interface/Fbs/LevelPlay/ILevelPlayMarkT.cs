using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200496F RID: 18799
	public class ILevelPlayMarkT
	{
		// Token: 0x1700838A RID: 33674
		// (get) Token: 0x0601C096 RID: 114838 RVA: 0x003F6AF3 File Offset: 0x003F4CF3
		// (set) Token: 0x0601C097 RID: 114839 RVA: 0x003F6AFB File Offset: 0x003F4CFB
		public int MarkId { get; set; }

		// Token: 0x1700838B RID: 33675
		// (get) Token: 0x0601C098 RID: 114840 RVA: 0x003F6B04 File Offset: 0x003F4D04
		// (set) Token: 0x0601C099 RID: 114841 RVA: 0x003F6B0C File Offset: 0x003F4D0C
		public string MapBgPath { get; set; }

		// Token: 0x0601C09A RID: 114842 RVA: 0x003F6B15 File Offset: 0x003F4D15
		public ILevelPlayMarkT()
		{
			this.MarkId = 0;
			this.MapBgPath = null;
		}
	}
}
