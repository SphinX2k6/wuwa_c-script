using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200453D RID: 17725
	public class IRemainScoreCanWinConditionT
	{
		// Token: 0x17007DB9 RID: 32185
		// (get) Token: 0x0601AA99 RID: 109209 RVA: 0x003CDD32 File Offset: 0x003CBF32
		// (set) Token: 0x0601AA9A RID: 109210 RVA: 0x003CDD3A File Offset: 0x003CBF3A
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x0601AA9B RID: 109211 RVA: 0x003CDD43 File Offset: 0x003CBF43
		public IRemainScoreCanWinConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
		}
	}
}
