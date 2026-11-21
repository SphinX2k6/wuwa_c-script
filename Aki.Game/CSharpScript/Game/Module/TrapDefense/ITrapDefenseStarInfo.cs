using System;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A4A RID: 14922
	public class ITrapDefenseStarInfo
	{
		// Token: 0x17004E8B RID: 20107
		// (get) Token: 0x060265CC RID: 157132 RVA: 0x00ABEBE1 File Offset: 0x00ABCDE1
		// (set) Token: 0x060265CD RID: 157133 RVA: 0x00ABEBE9 File Offset: 0x00ABCDE9
		public bool IsAchieve { get; set; }

		// Token: 0x17004E8C RID: 20108
		// (get) Token: 0x060265CE RID: 157134 RVA: 0x00ABEBF2 File Offset: 0x00ABCDF2
		// (set) Token: 0x060265CF RID: 157135 RVA: 0x00ABEBFA File Offset: 0x00ABCDFA
		public bool IsNew { get; set; }

		// Token: 0x17004E8D RID: 20109
		// (get) Token: 0x060265D0 RID: 157136 RVA: 0x00ABEC03 File Offset: 0x00ABCE03
		// (set) Token: 0x060265D1 RID: 157137 RVA: 0x00ABEC0B File Offset: 0x00ABCE0B
		public bool HasPlayed { get; set; }

		// Token: 0x17004E8E RID: 20110
		// (get) Token: 0x060265D2 RID: 157138 RVA: 0x00ABEC14 File Offset: 0x00ABCE14
		// (set) Token: 0x060265D3 RID: 157139 RVA: 0x00ABEC1C File Offset: 0x00ABCE1C
		public int PlayDelay { get; set; }
	}
}
