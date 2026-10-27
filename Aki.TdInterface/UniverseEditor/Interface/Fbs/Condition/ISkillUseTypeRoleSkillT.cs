using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CCE RID: 19662
	public class ISkillUseTypeRoleSkillT
	{
		// Token: 0x17008EB4 RID: 36532
		// (get) Token: 0x0601F32B RID: 127787 RVA: 0x0045AE40 File Offset: 0x00459040
		// (set) Token: 0x0601F32C RID: 127788 RVA: 0x0045AE48 File Offset: 0x00459048
		public ESkillUseType Type { get; set; }

		// Token: 0x17008EB5 RID: 36533
		// (get) Token: 0x0601F32D RID: 127789 RVA: 0x0045AE51 File Offset: 0x00459051
		// (set) Token: 0x0601F32E RID: 127790 RVA: 0x0045AE59 File Offset: 0x00459059
		public int SkillId { get; set; }

		// Token: 0x0601F32F RID: 127791 RVA: 0x0045AE62 File Offset: 0x00459062
		public ISkillUseTypeRoleSkillT()
		{
			this.Type = ESkillUseType.RoleSkill;
			this.SkillId = 0;
		}
	}
}
