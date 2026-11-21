using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004975 RID: 18805
	public class ILevelPlayRefreshT
	{
		// Token: 0x17008398 RID: 33688
		// (get) Token: 0x0601C0D8 RID: 114904 RVA: 0x003F75DA File Offset: 0x003F57DA
		// (set) Token: 0x0601C0D9 RID: 114905 RVA: 0x003F75E2 File Offset: 0x003F57E2
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x0601C0DA RID: 114906 RVA: 0x003F75EB File Offset: 0x003F57EB
		public ILevelPlayRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
		}
	}
}
