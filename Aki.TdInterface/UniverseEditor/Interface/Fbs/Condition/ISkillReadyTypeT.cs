using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C1 RID: 20929
	public class ISkillReadyTypeT
	{
		// Token: 0x170095E4 RID: 38372
		// (get) Token: 0x06020F39 RID: 134969 RVA: 0x0048E85A File Offset: 0x0048CA5A
		// (set) Token: 0x06020F3A RID: 134970 RVA: 0x0048E862 File Offset: 0x0048CA62
		public ESkillReadyType Type { get; set; }

		// Token: 0x06020F3B RID: 134971 RVA: 0x0048E86B File Offset: 0x0048CA6B
		public ISkillReadyTypeT()
		{
			this.Type = ESkillReadyType.UltimateSkill;
		}
	}
}
