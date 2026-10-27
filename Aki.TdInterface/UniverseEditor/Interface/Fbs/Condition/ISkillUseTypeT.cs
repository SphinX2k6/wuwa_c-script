using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CCB RID: 19659
	public class ISkillUseTypeT
	{
		// Token: 0x17008EB0 RID: 36528
		// (get) Token: 0x0601F317 RID: 127767 RVA: 0x0045AC66 File Offset: 0x00458E66
		// (set) Token: 0x0601F318 RID: 127768 RVA: 0x0045AC6E File Offset: 0x00458E6E
		public ESkillUseType Type { get; set; }

		// Token: 0x0601F319 RID: 127769 RVA: 0x0045AC77 File Offset: 0x00458E77
		public ISkillUseTypeT()
		{
			this.Type = ESkillUseType.RoleSkill;
		}
	}
}
