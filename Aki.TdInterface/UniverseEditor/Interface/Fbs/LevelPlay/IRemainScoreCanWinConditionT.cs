using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049A5 RID: 18853
	public class IRemainScoreCanWinConditionT
	{
		// Token: 0x170083FA RID: 33786
		// (get) Token: 0x0601C26E RID: 115310 RVA: 0x003F9FCE File Offset: 0x003F81CE
		// (set) Token: 0x0601C26F RID: 115311 RVA: 0x003F9FD6 File Offset: 0x003F81D6
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x0601C270 RID: 115312 RVA: 0x003F9FDF File Offset: 0x003F81DF
		public IRemainScoreCanWinConditionT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
		}
	}
}
