using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045B1 RID: 17841
	public class FetterStarLvData : IFetterStarLvData
	{
		// Token: 0x17005AD1 RID: 23249
		// (get) Token: 0x0602CF0C RID: 184076 RVA: 0x00C9190C File Offset: 0x00C8FB0C
		// (set) Token: 0x0602CF0D RID: 184077 RVA: 0x00C91914 File Offset: 0x00C8FB14
		public int StageLv { get; set; }

		// Token: 0x17005AD2 RID: 23250
		// (get) Token: 0x0602CF0E RID: 184078 RVA: 0x00C9191D File Offset: 0x00C8FB1D
		// (set) Token: 0x0602CF0F RID: 184079 RVA: 0x00C91925 File Offset: 0x00C8FB25
		public int StageStarLv { get; set; }

		// Token: 0x17005AD3 RID: 23251
		// (get) Token: 0x0602CF10 RID: 184080 RVA: 0x00C9192E File Offset: 0x00C8FB2E
		// (set) Token: 0x0602CF11 RID: 184081 RVA: 0x00C91936 File Offset: 0x00C8FB36
		public int CurrentLv { get; set; }

		// Token: 0x17005AD4 RID: 23252
		// (get) Token: 0x0602CF12 RID: 184082 RVA: 0x00C9193F File Offset: 0x00C8FB3F
		// (set) Token: 0x0602CF13 RID: 184083 RVA: 0x00C91947 File Offset: 0x00C8FB47
		public int MaxLv { get; set; }
	}
}
