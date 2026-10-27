using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055DB RID: 21979
	public class FetterStarLvData : IFetterStarLvData
	{
		// Token: 0x1700870A RID: 34570
		// (get) Token: 0x0603800E RID: 229390 RVA: 0x00D43BC4 File Offset: 0x00D41DC4
		// (set) Token: 0x0603800F RID: 229391 RVA: 0x00D43BCC File Offset: 0x00D41DCC
		public int StageLv { get; set; }

		// Token: 0x1700870B RID: 34571
		// (get) Token: 0x06038010 RID: 229392 RVA: 0x00D43BD5 File Offset: 0x00D41DD5
		// (set) Token: 0x06038011 RID: 229393 RVA: 0x00D43BDD File Offset: 0x00D41DDD
		public int StageStarLv { get; set; }

		// Token: 0x1700870C RID: 34572
		// (get) Token: 0x06038012 RID: 229394 RVA: 0x00D43BE6 File Offset: 0x00D41DE6
		// (set) Token: 0x06038013 RID: 229395 RVA: 0x00D43BEE File Offset: 0x00D41DEE
		public int CurrentLv { get; set; }

		// Token: 0x1700870D RID: 34573
		// (get) Token: 0x06038014 RID: 229396 RVA: 0x00D43BF7 File Offset: 0x00D41DF7
		// (set) Token: 0x06038015 RID: 229397 RVA: 0x00D43BFF File Offset: 0x00D41DFF
		public int MaxLv { get; set; }
	}
}
