using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048A3 RID: 18595
	public class IBehindScoreLeConditionT
	{
		// Token: 0x17008152 RID: 33106
		// (get) Token: 0x0601B797 RID: 112535 RVA: 0x003E3360 File Offset: 0x003E1560
		// (set) Token: 0x0601B798 RID: 112536 RVA: 0x003E3368 File Offset: 0x003E1568
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17008153 RID: 33107
		// (get) Token: 0x0601B799 RID: 112537 RVA: 0x003E3371 File Offset: 0x003E1571
		// (set) Token: 0x0601B79A RID: 112538 RVA: 0x003E3379 File Offset: 0x003E1579
		public int Score { get; set; }

		// Token: 0x0601B79B RID: 112539 RVA: 0x003E3382 File Offset: 0x003E1582
		public IBehindScoreLeConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Score = 0;
		}
	}
}
