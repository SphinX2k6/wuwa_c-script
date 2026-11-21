using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005723 RID: 22307
	public class DangoBrawlSaveData
	{
		// Token: 0x06036E8E RID: 224910 RVA: 0x00F4EFA0 File Offset: 0x00F4D1A0
		public DangoBrawlSaveData(int levelId, int roundNum, int roleId)
		{
			this.LevelId = levelId;
			this.RoundNum = roundNum;
			this.RoleId = roleId;
		}

		// Token: 0x0401D13E RID: 119102
		public int LevelId;

		// Token: 0x0401D13F RID: 119103
		public int RoundNum;

		// Token: 0x0401D140 RID: 119104
		public int RoleId;
	}
}
