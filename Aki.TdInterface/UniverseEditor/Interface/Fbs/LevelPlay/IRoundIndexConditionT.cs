using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045AC RID: 17836
	public class IRoundIndexConditionT
	{
		// Token: 0x17007EC5 RID: 32453
		// (get) Token: 0x0601AF75 RID: 110453 RVA: 0x003D8930 File Offset: 0x003D6B30
		// (set) Token: 0x0601AF76 RID: 110454 RVA: 0x003D8938 File Offset: 0x003D6B38
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x17007EC6 RID: 32454
		// (get) Token: 0x0601AF77 RID: 110455 RVA: 0x003D8941 File Offset: 0x003D6B41
		// (set) Token: 0x0601AF78 RID: 110456 RVA: 0x003D8949 File Offset: 0x003D6B49
		public int Round { get; set; }

		// Token: 0x0601AF79 RID: 110457 RVA: 0x003D8952 File Offset: 0x003D6B52
		public IRoundIndexConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
			this.Round = 0;
		}
	}
}
