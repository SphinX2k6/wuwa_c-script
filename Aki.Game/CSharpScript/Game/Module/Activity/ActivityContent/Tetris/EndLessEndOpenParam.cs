using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02006026 RID: 24614
	public class EndLessEndOpenParam : IEndLessEndOpenParam
	{
		// Token: 0x1700906A RID: 36970
		// (get) Token: 0x0603E4DF RID: 255199 RVA: 0x00F0C451 File Offset: 0x00F0A651
		// (set) Token: 0x0603E4E0 RID: 255200 RVA: 0x00F0C459 File Offset: 0x00F0A659
		public int Score { get; set; }

		// Token: 0x1700906B RID: 36971
		// (get) Token: 0x0603E4E1 RID: 255201 RVA: 0x00F0C462 File Offset: 0x00F0A662
		// (set) Token: 0x0603E4E2 RID: 255202 RVA: 0x00F0C46A File Offset: 0x00F0A66A
		public bool IsQuit { get; set; }
	}
}
