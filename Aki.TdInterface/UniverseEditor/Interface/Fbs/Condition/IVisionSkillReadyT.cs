using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005215 RID: 21013
	public class IVisionSkillReadyT
	{
		// Token: 0x17009658 RID: 38488
		// (get) Token: 0x0602118B RID: 135563 RVA: 0x00492582 File Offset: 0x00490782
		// (set) Token: 0x0602118C RID: 135564 RVA: 0x0049258A File Offset: 0x0049078A
		public ESkillReadyType Type { get; set; }

		// Token: 0x0602118D RID: 135565 RVA: 0x00492593 File Offset: 0x00490793
		public IVisionSkillReadyT()
		{
			this.Type = ESkillReadyType.UltimateSkill;
		}
	}
}
