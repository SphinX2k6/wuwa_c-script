using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067D3 RID: 26579
	public class DangoBrawlSaveData
	{
		// Token: 0x06042338 RID: 271160 RVA: 0x0100DAD0 File Offset: 0x0100BCD0
		public DangoBrawlSaveData(int levelId, int roundNum, int roleId)
		{
			this.LevelId = levelId;
			this.RoundNum = roundNum;
			this.RoleId = roleId;
		}

		// Token: 0x040228E1 RID: 141537
		public int LevelId;

		// Token: 0x040228E2 RID: 141538
		public int RoundNum;

		// Token: 0x040228E3 RID: 141539
		public int RoleId;
	}
}
