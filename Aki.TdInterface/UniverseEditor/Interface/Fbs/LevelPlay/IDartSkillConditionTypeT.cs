using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048EE RID: 18670
	public class IDartSkillConditionTypeT
	{
		// Token: 0x1700820E RID: 33294
		// (get) Token: 0x0601BA6B RID: 113259 RVA: 0x003E8ED6 File Offset: 0x003E70D6
		// (set) Token: 0x0601BA6C RID: 113260 RVA: 0x003E8EDE File Offset: 0x003E70DE
		public EDartSkillConditionType Type { get; set; }

		// Token: 0x0601BA6D RID: 113261 RVA: 0x003E8EE7 File Offset: 0x003E70E7
		public IDartSkillConditionTypeT()
		{
			this.Type = EDartSkillConditionType.RemainScoreGe;
		}
	}
}
