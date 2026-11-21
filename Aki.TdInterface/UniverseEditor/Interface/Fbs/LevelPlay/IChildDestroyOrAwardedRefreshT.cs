using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048AC RID: 18604
	public class IChildDestroyOrAwardedRefreshT
	{
		// Token: 0x17008160 RID: 33120
		// (get) Token: 0x0601B7D7 RID: 112599 RVA: 0x003E3A0C File Offset: 0x003E1C0C
		// (set) Token: 0x0601B7D8 RID: 112600 RVA: 0x003E3A14 File Offset: 0x003E1C14
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17008161 RID: 33121
		// (get) Token: 0x0601B7D9 RID: 112601 RVA: 0x003E3A1D File Offset: 0x003E1C1D
		// (set) Token: 0x0601B7DA RID: 112602 RVA: 0x003E3A25 File Offset: 0x003E1C25
		public ILevelPlayRefreshCdT AwardedRefreshCd { get; set; }

		// Token: 0x17008162 RID: 33122
		// (get) Token: 0x0601B7DB RID: 112603 RVA: 0x003E3A2E File Offset: 0x003E1C2E
		// (set) Token: 0x0601B7DC RID: 112604 RVA: 0x003E3A36 File Offset: 0x003E1C36
		public ILevelPlayRefreshCdT ChildDestroyRefreshCd { get; set; }

		// Token: 0x0601B7DD RID: 112605 RVA: 0x003E3A3F File Offset: 0x003E1C3F
		public IChildDestroyOrAwardedRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.AwardedRefreshCd = null;
			this.ChildDestroyRefreshCd = null;
		}
	}
}
