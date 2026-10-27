using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D0A RID: 19722
	public class IUltimateSkillReadyT
	{
		// Token: 0x17008F10 RID: 36624
		// (get) Token: 0x0601F4E0 RID: 128224 RVA: 0x0045DCAA File Offset: 0x0045BEAA
		// (set) Token: 0x0601F4E1 RID: 128225 RVA: 0x0045DCB2 File Offset: 0x0045BEB2
		public ESkillReadyType Type { get; set; }

		// Token: 0x0601F4E2 RID: 128226 RVA: 0x0045DCBB File Offset: 0x0045BEBB
		public IUltimateSkillReadyT()
		{
			this.Type = ESkillReadyType.UltimateSkill;
		}
	}
}
