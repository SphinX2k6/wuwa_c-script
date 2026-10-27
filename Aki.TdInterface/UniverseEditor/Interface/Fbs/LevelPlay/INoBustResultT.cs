using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200452E RID: 17710
	public class INoBustResultT
	{
		// Token: 0x17007DA1 RID: 32161
		// (get) Token: 0x0601AA25 RID: 109093 RVA: 0x003CD244 File Offset: 0x003CB444
		// (set) Token: 0x0601AA26 RID: 109094 RVA: 0x003CD24C File Offset: 0x003CB44C
		public EDartSkillResultType Type { get; set; }

		// Token: 0x17007DA2 RID: 32162
		// (get) Token: 0x0601AA27 RID: 109095 RVA: 0x003CD255 File Offset: 0x003CB455
		// (set) Token: 0x0601AA28 RID: 109096 RVA: 0x003CD25D File Offset: 0x003CB45D
		public int Probability { get; set; }

		// Token: 0x0601AA29 RID: 109097 RVA: 0x003CD266 File Offset: 0x003CB466
		public INoBustResultT()
		{
			this.Type = EDartSkillResultType.NoBust;
			this.Probability = 0;
		}
	}
}
