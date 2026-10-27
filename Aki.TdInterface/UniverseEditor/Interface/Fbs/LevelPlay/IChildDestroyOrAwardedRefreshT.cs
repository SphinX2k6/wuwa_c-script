using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004444 RID: 17476
	public class IChildDestroyOrAwardedRefreshT
	{
		// Token: 0x17007B21 RID: 31521
		// (get) Token: 0x0601A006 RID: 106502 RVA: 0x003B7800 File Offset: 0x003B5A00
		// (set) Token: 0x0601A007 RID: 106503 RVA: 0x003B7808 File Offset: 0x003B5A08
		public ELevelPlayRefreshType Type { get; set; }

		// Token: 0x17007B22 RID: 31522
		// (get) Token: 0x0601A008 RID: 106504 RVA: 0x003B7811 File Offset: 0x003B5A11
		// (set) Token: 0x0601A009 RID: 106505 RVA: 0x003B7819 File Offset: 0x003B5A19
		public ILevelPlayRefreshCdT AwardedRefreshCd { get; set; }

		// Token: 0x17007B23 RID: 31523
		// (get) Token: 0x0601A00A RID: 106506 RVA: 0x003B7822 File Offset: 0x003B5A22
		// (set) Token: 0x0601A00B RID: 106507 RVA: 0x003B782A File Offset: 0x003B5A2A
		public ILevelPlayRefreshCdT ChildDestroyRefreshCd { get; set; }

		// Token: 0x0601A00C RID: 106508 RVA: 0x003B7833 File Offset: 0x003B5A33
		public IChildDestroyOrAwardedRefreshT()
		{
			this.Type = ELevelPlayRefreshType.None;
			this.AwardedRefreshCd = null;
			this.ChildDestroyRefreshCd = null;
		}
	}
}
