using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC5 RID: 19653
	public class ISkillReadyTypeT
	{
		// Token: 0x17008EAB RID: 36523
		// (get) Token: 0x0601F2F5 RID: 127733 RVA: 0x0045A962 File Offset: 0x00458B62
		// (set) Token: 0x0601F2F6 RID: 127734 RVA: 0x0045A96A File Offset: 0x00458B6A
		public ESkillReadyType Type { get; set; }

		// Token: 0x0601F2F7 RID: 127735 RVA: 0x0045A973 File Offset: 0x00458B73
		public ISkillReadyTypeT()
		{
			this.Type = ESkillReadyType.UltimateSkill;
		}
	}
}
