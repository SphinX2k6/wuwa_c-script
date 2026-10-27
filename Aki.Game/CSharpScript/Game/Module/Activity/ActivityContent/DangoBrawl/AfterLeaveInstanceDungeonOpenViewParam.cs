using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200678A RID: 26506
	public struct AfterLeaveInstanceDungeonOpenViewParam
	{
		// Token: 0x060421DB RID: 270811 RVA: 0x0100A1F5 File Offset: 0x010083F5
		public AfterLeaveInstanceDungeonOpenViewParam()
		{
			this.OpenViewName = EDangoBrawlViewName.Null;
			this.IsNormalMode = true;
			this.LevelId = 0;
		}

		// Token: 0x040227FE RID: 141310
		public EDangoBrawlViewName OpenViewName;

		// Token: 0x040227FF RID: 141311
		public bool IsNormalMode;

		// Token: 0x04022800 RID: 141312
		public int LevelId;
	}
}
