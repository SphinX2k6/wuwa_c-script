using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004543 RID: 17731
	public class IRemainScoreLeConditionT
	{
		// Token: 0x17007DC2 RID: 32194
		// (get) Token: 0x0601AAC3 RID: 109251 RVA: 0x003CE10C File Offset: 0x003CC30C
		// (set) Token: 0x0601AAC4 RID: 109252 RVA: 0x003CE114 File Offset: 0x003CC314
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17007DC3 RID: 32195
		// (get) Token: 0x0601AAC5 RID: 109253 RVA: 0x003CE11D File Offset: 0x003CC31D
		// (set) Token: 0x0601AAC6 RID: 109254 RVA: 0x003CE125 File Offset: 0x003CC325
		public int Score { get; set; }

		// Token: 0x0601AAC7 RID: 109255 RVA: 0x003CE12E File Offset: 0x003CC32E
		public IRemainScoreLeConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Score = 0;
		}
	}
}
