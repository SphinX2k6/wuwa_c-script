using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056DA RID: 22234
	public struct AfterLeaveInstanceDungeonOpenViewParam
	{
		// Token: 0x06036D31 RID: 224561 RVA: 0x00F4B5D9 File Offset: 0x00F497D9
		public AfterLeaveInstanceDungeonOpenViewParam()
		{
			this.OpenViewName = EDangoBrawlViewName.Null;
			this.IsNormalMode = true;
			this.LevelId = 0;
		}

		// Token: 0x0401D05B RID: 118875
		public EDangoBrawlViewName OpenViewName;

		// Token: 0x0401D05C RID: 118876
		public bool IsNormalMode;

		// Token: 0x0401D05D RID: 118877
		public int LevelId;
	}
}
