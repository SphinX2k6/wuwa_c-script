using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200510A RID: 20746
	public class IESkillReadyT
	{
		// Token: 0x170094B1 RID: 38065
		// (get) Token: 0x060209D1 RID: 133585 RVA: 0x004859EA File Offset: 0x00483BEA
		// (set) Token: 0x060209D2 RID: 133586 RVA: 0x004859F2 File Offset: 0x00483BF2
		public ESkillReadyType Type { get; set; }

		// Token: 0x060209D3 RID: 133587 RVA: 0x004859FB File Offset: 0x00483BFB
		public IESkillReadyT()
		{
			this.Type = ESkillReadyType.UltimateSkill;
		}
	}
}
