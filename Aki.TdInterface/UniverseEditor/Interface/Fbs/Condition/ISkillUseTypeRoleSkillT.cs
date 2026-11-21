using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051CA RID: 20938
	public class ISkillUseTypeRoleSkillT
	{
		// Token: 0x170095ED RID: 38381
		// (get) Token: 0x06020F6F RID: 135023 RVA: 0x0048ED38 File Offset: 0x0048CF38
		// (set) Token: 0x06020F70 RID: 135024 RVA: 0x0048ED40 File Offset: 0x0048CF40
		public ESkillUseType Type { get; set; }

		// Token: 0x170095EE RID: 38382
		// (get) Token: 0x06020F71 RID: 135025 RVA: 0x0048ED49 File Offset: 0x0048CF49
		// (set) Token: 0x06020F72 RID: 135026 RVA: 0x0048ED51 File Offset: 0x0048CF51
		public int SkillId { get; set; }

		// Token: 0x06020F73 RID: 135027 RVA: 0x0048ED5A File Offset: 0x0048CF5A
		public ISkillUseTypeRoleSkillT()
		{
			this.Type = ESkillUseType.RoleSkill;
			this.SkillId = 0;
		}
	}
}
