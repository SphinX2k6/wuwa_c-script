using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004978 RID: 18808
	public class ILevelPlayRefreshCdT
	{
		// Token: 0x1700839C RID: 33692
		// (get) Token: 0x0601C0EC RID: 114924 RVA: 0x003F77B4 File Offset: 0x003F59B4
		// (set) Token: 0x0601C0ED RID: 114925 RVA: 0x003F77BC File Offset: 0x003F59BC
		public int MinRefreshCd { get; set; }

		// Token: 0x1700839D RID: 33693
		// (get) Token: 0x0601C0EE RID: 114926 RVA: 0x003F77C5 File Offset: 0x003F59C5
		// (set) Token: 0x0601C0EF RID: 114927 RVA: 0x003F77CD File Offset: 0x003F59CD
		public int MaxRefreshCd { get; set; }

		// Token: 0x0601C0F0 RID: 114928 RVA: 0x003F77D6 File Offset: 0x003F59D6
		public ILevelPlayRefreshCdT()
		{
			this.MinRefreshCd = 0;
			this.MaxRefreshCd = 0;
		}
	}
}
