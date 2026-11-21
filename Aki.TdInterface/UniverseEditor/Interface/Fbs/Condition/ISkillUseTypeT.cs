using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C7 RID: 20935
	public class ISkillUseTypeT
	{
		// Token: 0x170095E9 RID: 38377
		// (get) Token: 0x06020F5B RID: 135003 RVA: 0x0048EB5E File Offset: 0x0048CD5E
		// (set) Token: 0x06020F5C RID: 135004 RVA: 0x0048EB66 File Offset: 0x0048CD66
		public ESkillUseType Type { get; set; }

		// Token: 0x06020F5D RID: 135005 RVA: 0x0048EB6F File Offset: 0x0048CD6F
		public ISkillUseTypeT()
		{
			this.Type = ESkillUseType.RoleSkill;
		}
	}
}
