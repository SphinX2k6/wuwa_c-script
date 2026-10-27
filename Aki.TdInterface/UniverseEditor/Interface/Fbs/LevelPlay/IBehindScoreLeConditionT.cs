using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200443B RID: 17467
	public class IBehindScoreLeConditionT
	{
		// Token: 0x17007B13 RID: 31507
		// (get) Token: 0x06019FC6 RID: 106438 RVA: 0x003B7154 File Offset: 0x003B5354
		// (set) Token: 0x06019FC7 RID: 106439 RVA: 0x003B715C File Offset: 0x003B535C
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17007B14 RID: 31508
		// (get) Token: 0x06019FC8 RID: 106440 RVA: 0x003B7165 File Offset: 0x003B5365
		// (set) Token: 0x06019FC9 RID: 106441 RVA: 0x003B716D File Offset: 0x003B536D
		public int Score { get; set; }

		// Token: 0x06019FCA RID: 106442 RVA: 0x003B7176 File Offset: 0x003B5376
		public IBehindScoreLeConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Score = 0;
		}
	}
}
