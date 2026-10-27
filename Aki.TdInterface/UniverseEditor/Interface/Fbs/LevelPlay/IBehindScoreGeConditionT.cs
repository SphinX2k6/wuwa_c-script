using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004438 RID: 17464
	public class IBehindScoreGeConditionT
	{
		// Token: 0x17007B0E RID: 31502
		// (get) Token: 0x06019FB0 RID: 106416 RVA: 0x003B6F54 File Offset: 0x003B5154
		// (set) Token: 0x06019FB1 RID: 106417 RVA: 0x003B6F5C File Offset: 0x003B515C
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17007B0F RID: 31503
		// (get) Token: 0x06019FB2 RID: 106418 RVA: 0x003B6F65 File Offset: 0x003B5165
		// (set) Token: 0x06019FB3 RID: 106419 RVA: 0x003B6F6D File Offset: 0x003B516D
		public int Score { get; set; }

		// Token: 0x06019FB4 RID: 106420 RVA: 0x003B6F76 File Offset: 0x003B5176
		public IBehindScoreGeConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Score = 0;
		}
	}
}
