using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005206 RID: 20998
	public class IUltimateSkillReadyT
	{
		// Token: 0x17009649 RID: 38473
		// (get) Token: 0x06021125 RID: 135461 RVA: 0x00491BFA File Offset: 0x0048FDFA
		// (set) Token: 0x06021126 RID: 135462 RVA: 0x00491C02 File Offset: 0x0048FE02
		public ESkillReadyType Type { get; set; }

		// Token: 0x06021127 RID: 135463 RVA: 0x00491C0B File Offset: 0x0048FE0B
		public IUltimateSkillReadyT()
		{
			this.Type = ESkillReadyType.UltimateSkill;
		}
	}
}
